//
// Example 9 Indexer register via SDO Rev 4
//
// This program demonstrates how to set and read and indexer register using
// the SDO_Upld and SDO_Dnld methods in the AmpObj
//
//
// This program assumes the following axis configuration:
// 1. Upon startup it will enable axis at Can Node ID 1 or
//    an axis at EtherCAT Node ID -1.
//
// This code also includes the following prerequisites:
// 1. The amplifier and motor must be preconfigured and set up properly to run.
// 2. The hardware enable switch must be installed and easily accessible
// 
// As with any motion product extreme caution must used! Read and understand
// all parameter settings before attemping to send to amplifier.
//
//
// Copley Motion Objects are Copyright, 2006-2024, Copley Controls.
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

namespace EX9_IndexerRegViaSDO
{
    public partial class IndexerRegViaSDO : Form
    {
        //***************************************************
        //*
        //*  EtherCAT Network
        //*
        //***************************************************
        //// A negative node number refers to the drive's physical position on the network
        //// -1 for the first drive, -2 for the second, etc.
        //const int ECAT_NODE = -1;
        //EcatObj ecatObj;
		//
		//EcatSettingsObj ecatSettingsObj;

        //***************************************************
        //
        //  CANOpen Network
        //
        //***************************************************
        const int CAN_ADDRESS = 1;
        canOpenObj canOpen;

        const int LOG_ALL = 99;
        CopleyMotionLibraryObj cmlObj;

        AmpObj ampObj;

        //Create a delegate to close down the application in a thread safe way
        delegate void CloseApp();

        public IndexerRegViaSDO()
        {
            InitializeComponent();
        }

        private void IndexerRegViaSDO_Load(object sender, EventArgs e)
        {
            try
            {
                //**************************************************************************
                //* Turn on logging by setting a CML object
                //**************************************************************************
                cmlObj = new CopleyMotionLibraryObj();
                cmlObj.DebugLevel = LOG_ALL;

                ampObj = new AmpObj();
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
                ampObj.Initialize(canOpen, CAN_ADDRESS);


                //***************************************************
                //*
                //*  EtherCAT Network
                //*
                //***************************************************
                //ecatObj = new EcatObj();
                //
                //***************************************************
                //* The next line of code is optional. The port name is the IP address of 
                //* the Ethernet adapter. Alternatively, a shortcut name “eth” can be used 
                //* in conjunction with the adapter number. For example “eth0” for the first 
                //* Ethernet adapter, “eth1” for the second adapter. If no port name is 
                //* supplied, it will default to “eth0”.
                //**************************************************************************
                //// Indicate that the first Ethernet adapter is to be used
                //ecatObj.PortName = "eth0";
                //// Specify an IP address
                //ecatObj.PortName = "192.168.1.1";
                //
                //***************************************************
                //* Initialize the EtherCAT network
                //***************************************************
                //ecatObj.Initialize();
                //
                //***************************************************
                //* An alternate way of initializing the EcatObj is to set up the 
                //* EcatSettingsObj then pass it into the InitializeExt method of the EcatObj. 
                //* To use it, first comment out the call to the EcatObj's Initialize method 
                //* above, then uncomment the following three lines of code.
                //**************************************************************************
                //// Create an instance of the EcatSettingsObj object by calling the constructor 
                //// (all of the properties will be initialized to their default values).
                //ecatSettingsObj = new EcatSettingsObj();
                //// Change a property
                //ecatSettingsObj.cyclePeriod = 10; // milliseconds
                //// Initialize the EcatObj with the settings object
                //ecatObj.InitializeExt(ecatSettingsObj);
                //
                //***************************************************
                //* Initialize the amplifier
                //***************************************************
                //ampObj.InitializeEcat(ecatObj, ECAT_NODE);
                //

            }

            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void cmdRead_Click(object sender, EventArgs e)
        {
            object Data = new int();
            short ObjectID;
            short SubIndex;

            //CAN object ID for the Indexer Registers is 0x2600 (9728 decimal) 
            ObjectID = 9728;

            //Each sub index of this object contains a register value.  Sub index 1               contains the value in register 0.
            SubIndex = Convert.ToInt16((Convert.ToInt16(txtRegisterNumber.Text)) + 1);

            try
            {
                //Use the SDO_Upld method to read the value in the amplifiers register.

                ampObj.SDO_Upld(ObjectID, SubIndex, ref Data);

                txtReadData.Text = Convert.ToString(Data);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void cmdWrite_Click(object sender, EventArgs e)
        {
            int Data;
            short ObjectID;
            short SubIndex;

            //CAN object ID for the Indexer Registers is 0x2600 (9728 decimal) 
            ObjectID = 9728;

            //Each sub index of this object contains a register value.  Sub index 1 contains the value in register 0.
            SubIndex = Convert.ToInt16(Convert.ToInt16((txtRegisterNumber.Text)) + 1);

            try
            {
                Data = Convert.ToInt32(txtWriteData.Text);
                //Use the SDO_Dnld method to write the value to the amplifier//s register.
                ampObj.SDO_Dnld(ObjectID, SubIndex, Data);
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
    }
}
