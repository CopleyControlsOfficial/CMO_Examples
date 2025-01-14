//
// Example 12 Position Triggered Output Rev 1
//
// This program demonstrates how to configure two types of position triggered 
// outputs: Software Triggered and Hardware Triggered. Non-PLUS drives do not
// support hardware triggered and thus, must use the slower software triggered
// configuration. 
//
// Please first read App Note 137 "Setting Outputs At Position" desribing
// the details of the various configurations of the position triggered outputs.
//
// There can only be one hardware position triggered output per axis.
// The hardware position triggered output reacts in 10's of nanoseconds to a change
// in position. Please consult pages 4 & 5 of AppNote 137 for the list of parameters
// needed to properly configure a hardware position triggered output.
//
// The software position triggered outputs can be used on any output. They do not have as 
// fast a reaction time as the hardware triggered type but are useful if multiple outputs
// per axis need to react to a change in position. To configure a software position triggered 
// output, multiple 32-bit words may need to be written to the output. Therefore, CMO has to 
// use serial binary over CAN to accomplish this action.
//
// This program assumes the following axis configuration:
// 1. Upon startup it will enable axis at Can Node ID 1 or
//    an axis at EtherCAT Node ID -1.
// 2. The motor has an encoders with an index.
//
// This code also includes the following prerequisites:
// 1. The amplifier and motor must be preconfigured and set up properly to run.
// 2. The hardware enable switch must be installed on the amplifier and easily accessible.
// 
// As with any motion product extreme caution must used! Read and understand
// all parameter settings before attemping to send to amplifier.
//
// Copley Motion Objects are Copyright, 2002-2024, Copley Controls.
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

namespace EX12_PositionTriggeredOutput
{
    public partial class PositionTriggeredOutput : Form
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

        public PositionTriggeredOutput()
        {
            InitializeComponent();
        }

        private void PositionTriggeredOutput_Load(object sender, EventArgs e)
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

                // Enable the GUI components
                HardwarePositionTriggeredOutputButton.Enabled = true;
                SoftwarePositionTriggeredOutputButton.Enabled = true;
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void HardwarePositionTriggeredOutputButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Set 0x70 (Output 1 Configuration) to 16 = Hardware Position Triggered 
                short ObjectID = 0x2193;
                short SubIndex = 1;
                Int32 Data = Convert.ToInt32(16);
                ampObj.SDO_Dnld(ObjectID, SubIndex, Data);

                // Set Compare Module Configuration to 17 = Bits 0 and 4 are set = Enable the module and use Mode 2 "Set In Position Window".
                ObjectID = 0x2160;
                SubIndex = 0;
                Data = Convert.ToInt32(17);
                ampObj.SDO_Dnld(ObjectID, SubIndex, Data);

                // Set the Compare Value Lower Bound Position = 0x1234 = 4,660 counts
                ObjectID = 0x2162;
                SubIndex = 0;
                Data = Convert.ToInt32(0x1234);
                ampObj.SDO_Dnld(ObjectID, SubIndex, Data);

                // Set the Compare Value Upper Bound Position = 0x12345678 = 305,419,896 counts
                ObjectID = 0x2163;
                SubIndex = 0;
                Data = Convert.ToInt32(0x12345678);
                ampObj.SDO_Dnld(ObjectID, SubIndex, Data);

                /*
                // Set the Compare Increment. If in Mode 0, the compare increment must equal 2*(upper_compare_value - lower_compare_value)
                // In this case, (305419896-4660)*2 = 610830472
                ObjectID = 0x2164;
                SubIndex = 0;
                Data = Convert.ToInt32(610830472);
                ampObj.SDO_Dnld(ObjectID, SubIndex, Data);

                // Set Time Delay (time of output firing) in tens of nanoseconds
                ObjectID = 0x2165;
                SubIndex = 0;
                Int32 Data = Convert.ToInt32(762144);
                ampObj.SDO_Dnld(ObjectID, SubIndex, Data);
                */

            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        // To configure software position triggered outputs for non-plus drives, use the following.
        // The code below sets up output 1 to trigger while in position window 4660-305419896 counts. 
        // 4660 in decimal is 0x1234 in hex. 305419896 in decimal is 0x12345678 in hex.
        // ASCII Command Equivalent: s r0x70 4 0x1234 0x12345678 
        private void SoftwarePositionTriggeredOutputButton_Click(object sender, EventArgs e)
        {
            try
            {
                short ObjectID = 0x2000;
                short SubIndex = 0;
                short Data_Size = 13;
                byte[] Data = new byte[Data_Size];
                Data[0] = 0x0d; // op-code 13 for "set" command ; Each word after this byte is byte swapped.                
                Data[1] = 0x70; // Output 1 is 0x70 ; CANopen ID for 0x70 is 0x2193.1 ; to see how many outputs are on drive, read sub-index 0.
                Data[2] = 0x00; // Rest of word is 0x00  -- 0x0070 = OUT1
                Data[3] = 0x04;
                Data[4] = 0x00; // Output Config = 0x0004 = trigger while in position window
                Data[5] = 0x00;
                Data[6] = 0x00;
                Data[7] = 0x34;
                Data[8] = 0x12; // 0x00001234 = 4,660 counts for lower bound 
                Data[9] = 0x34;
                Data[10] = 0x12;
                Data[11] = 0x78;
                Data[12] = 0x56; // 0x12345678 = 305,419,896 counts for upper bound 
                ampObj.SDO_DnldExt(ObjectID, SubIndex, Data, Data_Size);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void PositionTriggeredOutput_FormClosed(object sender, FormClosingEventArgs e)
        {
            ampObj.Disable();
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
