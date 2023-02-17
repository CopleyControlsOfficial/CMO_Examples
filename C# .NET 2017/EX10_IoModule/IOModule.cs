//
// Example 10 CAN IO Module Rev 3
//
// This program demonstrates how to read and write to the digital IO 
//
// As with any motion product extreme caution must used! Read and understand
// all parameter settings before attemping to send to amplifier.
//
//
// Copley Motion Objects are Copyright, 2006-2017, Copley Controls.
//
// For more information on Copley Motion products see:
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
using CMLCOMLib;

namespace EX10_IoModule
{
    public partial class IOModule : Form
    {
        //Set CAN address here
        const int CAN_ADDRESS = 1;

        const int LOG_ALL = 99;
        CopleyMotionLibraryObj cmlObj;

        canOpenObj canOpen;
        IOObj ioObj;
        ioSettingsObj ioSettings;

        int outputState; //State of the outputs

        // Create a delegate to close down the application in a thread safe way
        delegate void CloseApp();

        public IOModule()
        {
            InitializeComponent();
        }

        private void IOModule_Load(object sender, EventArgs e)
        {
            try
            {
                //**************************************************************************
                //* Turn on logging by setting a CML object
                //**************************************************************************
                cmlObj = new CopleyMotionLibraryObj();
                cmlObj.DebugLevel = LOG_ALL;

                // CAN network and I/O initialization
                canOpen = new canOpenObj();
                ioObj = new IOObj();

                // To change bit rate or can card, un-comment one of the following lines
                // and make the appropriate change default bit rate is 1 Mbit/s, default
                // can card is first supported card found
                //canOpen.BitRate = CML_BIT_RATES.BITRATE_1_Mbit_per_sec
                canOpen.PortName = "copley0";

                canOpen.Initialize();

                //The ioSettings object allows the CAN network settings to be changed for the IOObj.
                ioSettings = new ioSettingsObj();
                //example of changing one of the settings
                //ioSettings.useStandardAinPDO = False

                // initialize the ioObj using the ioSettings object
                ioObj.InitializeExt(canOpen, CAN_ADDRESS, ioSettings);

                // Only comment in the following if there are outputs set.
                //Sets all outputs off
                //outputState = 0;
                //WriteOutput();

                this.TimerStat.Enabled = true;
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void cbOut1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOut1.Checked == false) outputState = outputState & 254;
            else outputState = outputState | 1;

            // Only comment in the following if there are outputs set.
            //WriteOutput();
        }

        private void cbOut2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOut2.Checked == false) outputState = outputState & 253;
            else outputState = outputState | 2;

            // Only comment in the following if there are outputs set.
            //WriteOutput();
        }

        public void WriteOutput()
        {
            try
            {
                ioObj.Dout8Write(0, Convert.ToInt16(outputState), false);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        //Read inputs and set display.
        public void ReadInputs()
        {
            try
            {
                int inputState = 0;

                ioObj.Din8Read(0, ref inputState, true);
                if (Convert.ToBoolean(inputState & 1)) txtInput1State.Text = "Hi";
                else txtInput1State.Text = "Low";

                if (Convert.ToBoolean(inputState & 2)) txtInput2State.Text = "Hi";
                else txtInput2State.Text = "Low";
            }
            catch (Exception ex)
            {
                this.TimerStat.Enabled = false;
                DisplayError(ex);
            }
        }

        private void TimerStat_Tick(object sender, EventArgs e)
        {
            ReadInputs();
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
    }
}
