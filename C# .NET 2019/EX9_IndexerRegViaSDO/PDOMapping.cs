// 
// Example 12 PDO Mapping Rev 3
//
// This program demonstrates Copley Motion PDO Mapping to a CANopen node
//
// The purpose of this example is to show how to map a transmit/receive PDO
// to a CANopen node using CMO and save the mapping to flash.
//
// This program assumes the following axis configuration:
// 1. Upon startup it will enable one axis at Can Node ID 1.
// 
// As with any motion product extreme caution must used! Read and understand
// all parameter settings before attemping to send to amplifier.
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

namespace EX9_PDOMapping
{
    public partial class PDOMapping : Form
    {
        //***************************************************
        //
        //  CANOpen Network
        //
        //***************************************************
        const int X_AXIS_CAN_ADDRESS = 1;
        const int Y_AXIS_CAN_ADDRESS = 2;
        canOpenObj canOpen;

        const int LOG_ALL = 99;
        CopleyMotionLibraryObj cmlObj;

        AmpObj amp;

        TPDOObj tpdo;
        PmapObj[] tpdoPmap;
        int[] tpdoObjID;
        int[] tpdoObjIdSub;
        const int ANALOG_REF_INDEX = 0;
        const int ACT_POSITION_INDEX = 1;

        RPDOObj rpdoOff;
        PmapObj[] rpdoPmap;
        int[] rpdoObjID;
        int[] rpdoObjIdSub;
        int[] newData;
        const int OFFSET_INDEX = 0;

        Thread displayTPDOdata;
        bool KeepPrinting = true;
        ampSettingsObj ampSettings;

        // Create a delegate to updateGui down the application in a thread safe way
        delegate void UpdateGui();
        // Create a delegate to close down the application in a thread safe way
        delegate void CloseApp();

        public PDOMapping()
        {
            InitializeComponent();
        }

        private void PDOMapping_Load(object sender, EventArgs e)
        {
            try
            {
                //**************************************************************************
                //* Turn on logging by setting a CML object
                //**************************************************************************
                cmlObj = new CopleyMotionLibraryObj();
                cmlObj.DebugLevel = LOG_ALL;

                //Initialize code here
                amp = new AmpObj();

                //***************************************************
                //
                //  CANOpen Network
                //
                //***************************************************
                canOpen = new canOpenObj();
                //
                //**************************************************************************
                //* The next two lines of code are optional. If no bit rate is specified,
                //* then the default bit rate (1 Mbit per second) is used.  If no port name
                //* is specified, then CMO will use the first supported CAN card found and
                //* use channel 0 of that card.
                //**************************************************************************
                // Set the bit rate to 1 Mbit per second
                canOpen.BitRate = CML_BIT_RATES.BITRATE_1_Mbit_per_sec;
                // Indicate that channel 0 of a Copley CAN card should be used
                canOpen.PortName = "copley0";
                //***************************************************
                //* Initialize the CAN card and network
                //***************************************************
                canOpen.Initialize();
                //***************************************************
                //* Initialize the amplifier
                //***************************************************
                //amp.Initialize(canOpen, X_AXIS_CAN_ADDRESS);
                ampSettings = new ampSettingsObj();
                ampSettings.guardTime = 0;
                ampSettings.synchPeriod = 2000;
                amp.InitializeExt(canOpen, X_AXIS_CAN_ADDRESS, ampSettings);

                //***************************************************
                //
                //  Transmit PDO 
                //
                //***************************************************
                tpdo = new TPDOObj();
                //
                //**************************************************************************
                //* Create an array of the objects to be mapped to this TPDO
                //* Each PDO can hold up to 8 bytes of data and a max of 4 objects
                //* The Pmap size corresponds to the size of the data (8, 16, 24, or 32)
                //**************************************************************************
                tpdoPmap = new PmapObj[2];
                tpdoPmap[ANALOG_REF_INDEX] = new Pmap16Obj();
                tpdoPmap[ACT_POSITION_INDEX] = new Pmap32Obj();
                //**************************************************************************
                //* Create an array of the corresponding CAN object IDs
                //**************************************************************************
                tpdoObjID = new int[2];
                tpdoObjID[ANALOG_REF_INDEX] = 0x2200;
                tpdoObjID[ACT_POSITION_INDEX] = 0x6064;

                //**************************************************************************
                //* Create an array of the corresponding CAN object ID subindexes
                //**************************************************************************
                tpdoObjIdSub = new int[2];
                tpdoObjIdSub[ANALOG_REF_INDEX] = 0;
                tpdoObjIdSub[ACT_POSITION_INDEX] = 0;

                //**************************************************************************
                //* Configure the transmit PDO
                //* The first parameter is a CAN message ID to use. This needs to be unique
                //* in the system. It is simplest to use an extended message ID (i.e. one
                //* with bit 29 set) since it willnot clash with any standard CAN ID used
                //* in the system. The fourth parameter is the type. Set transmit type to 1.
                //* This causes the PDO to be sent every sync period.  Setting the type to
                //* 2 would cause it to be sent every second period, etc.
                //**************************************************************************
                // This function assumes all object IDs have a subindex of 0.
                //tpdo.Init(0x20000001, tpdoPmap, tpdoObjID, 1); 

                // This function allows non-zero subindexes.
                tpdo.Init(0x20000001, tpdoPmap, tpdoObjID, tpdoObjIdSub, 1);
                // Optionally, the RTR can be turned off (Defaults to on). 0 turns it off and
                // any non-zero value turns it back on.
                //tpdo.SetRtrOk(0);
                //
                //**************************************************************************
                //* Attach the TPDO to the node
                //* The first parameter gives the PDO slot to use. The amps have 8 transmit
                //* and 8 receive PDOs so this number should range from 0 - 7. CMO uses
                //* transmit PDO slots 0, 1, and 4, so those should not be used for custom
                //* PDOs.
                //**************************************************************************
                amp.SetTpdo(2, tpdo);

                //***************************************************
                //
                //  Receive PDO 
                //
                //***************************************************
                rpdoOff = new RPDOObj();
                //
                //**************************************************************************
                //* Create an array of the objects to be mapped to this RPDO
                //* Each PDO can hold up to 8 bytes of data and a max of 4 objects
                //* The Pmap size corresponds to the size of the data (8, 16, 24, or 32)
                //**************************************************************************
                rpdoPmap = new PmapObj[1];
                rpdoPmap[OFFSET_INDEX] = new Pmap16Obj();
                //
                //**************************************************************************
                //* Create an array of the corresponding CAN object IDs
                //**************************************************************************
                rpdoObjID = new int[1];
                rpdoObjID[OFFSET_INDEX] = 0x2311;

                //**************************************************************************
                //* Create an array of the corresponding CAN object ID subindexes
                //**************************************************************************
                rpdoObjIdSub = new int[1];
                rpdoObjIdSub[OFFSET_INDEX] = 0;
                //
                //**************************************************************************
                //* Configure the receive PDO
                //* Again, CAN ID should be unique. Easiest is to use an extended ID (bit 29)
                //* The fourth parameter is the type. Set transmit type to 255. This causes
                //* the PDO to be acted on immediately.
                //**************************************************************************
                // This function assumes all object IDs have a subindex of 0.
                //rpdoOff.Init(0x20000101, rpdoPmap, rpdoObjID, 255);

                // This function allows non-zero subindexes.
                rpdoOff.Init(0x20000101, rpdoPmap, rpdoObjID, rpdoObjIdSub, 255);
                //
                //**************************************************************************
                //* Attach the TPDO to the node
                //* CMO uses RPDO slots 0, 1, and 4 so I should use slot numbers 2, 3, 5-7.
                //**************************************************************************
                amp.SetRpdo(2, rpdoOff);

                // Start a thread to display values
                displayTPDOdata = new Thread(DisplayOffset);
                displayTPDOdata.Start();

                // Create an array of the data, these should correspond to the rpdo mapping.
                newData = new int[1];
                newData[OFFSET_INDEX] = 0;

                // Send a PDO to reset the A/D offset on the drive to 0.
                // The second parameter is the indexes of the pdo objects to send.
                // i.e. 1 sends index 0, 2 sends index 1, 3 sends indexes 0 and 1, etc.
                rpdoOff.SendData(newData, 1);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void DisplayOffset()
        {
            try
            {
                while (KeepPrinting)
                {
                    ThreadSafeUpdateGUI();
                    Thread.Sleep(1);
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void StopDisplayThread()
        {
            KeepPrinting = false;
        }

        public void ThreadSafeUpdateGUI()
        {
            if (KeepPrinting)
            {
                if (this.InvokeRequired)
                {
                    UpdateGui g = new UpdateGui(ThreadSafeUpdateGUI);
                    this.Invoke(g);
                }
                else
                {
                    AlogRefTextBox.Text = tpdo.data[ANALOG_REF_INDEX].ToString();
                    PositionTextBox.Text = tpdo.data[ACT_POSITION_INDEX].ToString();
                }
            }
        }

        public void DisplayError(Exception ex)
        {
            if (KeepPrinting)
                KeepPrinting = false;
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

        // Send a new offset each time this button is pressed.
        private void SendOffsetButton_Click(object sender, EventArgs e)
        {
            try
            {
                newData[OFFSET_INDEX] += 100;
                rpdoOff.SendData(newData, 1);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void SaveMappingToFlashButton_Click(object sender, EventArgs e)
        {
            try
            {
                // This saves the PDO mapping to flash.
                // Passing true saves the communications parameters to flash
                // in addition to the PDO mapping.
                amp.SavePDOmappingToFlash(false);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void PDOMapping_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StopDisplayThread();
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }
    }
}
