// Example 12 LSS Rev 1
//
// This program demonstrates the Layer Setting Service (LSS)
// functionality. LSS is a CANopen protocol used to access
// devices on the network without the node id.
//
// As with any motion product extreme caution must be used! Read and understand
// all parameter settings before attempting to send to amplifier.
//
// Copley Motion Objects are Copyright, 2002-2021, Copley Controls.
//
// for more information on Copley Motion products see:
// http://www.copleycontrols.com
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CMLCOMLib;

namespace EX11_LSS
{
    public partial class LSS : Form
    {
        //***************************************************
        //
        //  CANOpen Network
        //
        //***************************************************
        canOpenObj canObj;
        const int MAX_DRIVES = 100;
        const int LOG_ALL = 99;
        CopleyMotionLibraryObj cmlObj;

        LSSObj lssObj;

        UInt32[] serial = new UInt32[MAX_DRIVES];
        byte[] newID = new byte[MAX_DRIVES];
        int userBitRate = 0;

        // Create a delegate to close down the application in a thread safe way.
        delegate void CloseApp();

        public LSS()
        {
            InitializeComponent();
        }

        private void LSS_Load(object sender, EventArgs e)
        {
            try
            {
                //**************************************************************************
                //* Turn on logging by setting a CML object
                //**************************************************************************
                cmlObj = new CopleyMotionLibraryObj();
                cmlObj.DebugLevel = LOG_ALL;

                //***************************************************
                //
                //  CANOpen Network
                //
                //***************************************************
                canObj = new canOpenObj();

                //**************************************************************************
                //* The next two lines of code are optional. If no bit rate is specified,
                //* then the default bit rate (1 Mbit per second) is used.  If no port name
                //* is specified, then CMO will use the first supported CAN card found and
                //* use channel 0 of that card.
                //**************************************************************************
                // Set the bit rate to 1 Mbit per second
                canObj.BitRate = CML_BIT_RATES.BITRATE_1_Mbit_per_sec;
                // Indicate that channel 0 of a Copley CAN card should be used
                canObj.PortName = "copley0";
                //***************************************************
                //* Initialize the CAN card and network
                //***************************************************
                canObj.Initialize();

                // Create an LSS object.
                // LSS (Layer Setting Services) is a CANopen protocol used to 
                // access devices on the network without the node id.
                lssObj = new LSSObj(canObj);

            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        public void DisplayError(Exception ex)
        {
            DialogResult errormsgbox;
            errormsgbox = MessageBox.Show("Error Message: " + ex.Message + "\n" + "Error Source: "
                + ex.Source, "CMO Error", MessageBoxButtons.OKCancel);
            if (errormsgbox == DialogResult.Cancel)
            {
                // it is possible that this method was called from a thread other than the 
                // GUI thread - if this is the case we must use a delegate to close the application.
                //Dim d As New CloseApp(AddressOf ThreadSafeClose)
                CloseApp d = new CloseApp(ThreadSafeClose);
                this.Invoke(d);
            }
        }

        public void ThreadSafeClose()
        {
            //If the calling thread is different than the GUI thread, then use the
            //delegate to close the application, otherwise call close() directly
            if (this.InvokeRequired)
            {
                CloseApp d = new CloseApp(ThreadSafeClose);
                this.Invoke(d);
            }
            else
                Close();
        }

        public byte GetID()
        {
            NodeInput nodeInputScreen = new NodeInput();

            return (byte)nodeInputScreen.NodeID;
        }

        private void AssignIDsButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Save the user specified bit rate.
                userBitRate = Convert.ToInt32(BitRateTextBox.Text);
                lssObj.userBitRate = userBitRate;

                // Search for the nodes and turn off CAN LEDs.
                int ampCount = lssObj.FindAndDisableAmps(serial);

                // Enable the nodes one at a time to blink the lights and
                // get the desired node IDs.
                for (int i = 0; i < ampCount; i++)
                {
                    // Enable the node.
                    lssObj.EnableAmplifier(serial[i]);

                    // Get the desired ID.
                    newID[i] = GetID();

                    // Turn the CAN LEDs off.
                    lssObj.DisableAmplifier(serial[i]);
                }

                // Set all of the node IDs and activate the new bit rate.
                lssObj.SetAllAmplifierNodeIDs(serial, newID);

                // Reinitialize the CAN object with the new bit rate.
                // Since the CAN object is being reinitialized, the
                // LSS object needs to be reinitialized as well.
                canObj.Dispose();
                lssObj.Dispose();

                // Give time for CAN and LSS objects to properly close.
                Thread.Sleep(200);
                canObj = new canOpenObj();
                canObj.BitRate = (CML_BIT_RATES)userBitRate;
                canObj.PortName = "copley0";
                canObj.Initialize();
                lssObj = new LSSObj(canObj);

            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }
    }
}
