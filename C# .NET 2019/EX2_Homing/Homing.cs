﻿// Example 2 Homing Rev 5
//
// This program demonstrates how to home a motor.
//
// This program assumes the following axis configuration:
// 1. The motor has an encoder with an index
// 2. Upon startup it will enable axis at Can Node ID 1, or
//    its the first ECAT_NODE and is using the fist 
//    EtherCAT port on the system, "eth0".
//
// This code also includes the following prerequisites:
// 1. The amplifier and motor must be preconfigured and set up properly to run.
// 2. The hardware enable switch must be installed and easily accessible
// 
// As with any motion product extreme caution must used! Read and understand
// all parameter settings before attemping to send to amplifier.
//
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

namespace EX2_Homing
{
    public partial class Homing : Form
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
        const int X_AXIS_CAN_ADDRESS = 1;
        canOpenObj canOpen;

        const int LOG_ALL = 99;
        CopleyMotionLibraryObj cmlObj;

        AmpObj xAxisAmp;
        HomeSettingsObj Home;

        // Create a delegate to close down the application in a thread safe way
        delegate void CloseApp();

        public Homing()
        {
            InitializeComponent();
        }

        private void Homing_Load(object sender, EventArgs e)
        {
            try
            {
                //**************************************************************************
                //* Turn on logging by setting a CML object
                //**************************************************************************
                cmlObj = new CopleyMotionLibraryObj();
                cmlObj.DebugLevel = LOG_ALL;

                //Initialize code here
                xAxisAmp = new AmpObj();

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
                xAxisAmp.Initialize(canOpen, X_AXIS_CAN_ADDRESS);


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
                //
                //***************************************************
                //* Initialize the amplifier
                //***************************************************
                //xAxisAmp.InitializeEcat(ecatObj, ECAT_NODE);
                //

                //Initialize home object with amplifier home settings 
                Home = xAxisAmp.HomeSettings;

                Timer1.Start();
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void enableButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (enableButton.Text == "Amp Disable")
                {
                    xAxisAmp.Disable();
                    enableButton.Text = "Amp Enable";
                }
                else
                {
                    xAxisAmp.Enable();
                    enableButton.Text = "Amp Disable";
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void HomeAxisButton_Click(object sender, EventArgs e)
        {
            try
            {

                HomeAxisButton.Enabled = false;

                // Read velocity loop settings from amp and use these as
                // reasonable homing speed values
                Home.HomeVelFast = (xAxisAmp.VelocityLoopSettings.VelLoopMaxVel) / 10;
                Home.HomeVelSlow = (xAxisAmp.VelocityLoopSettings.VelLoopMaxVel) / 15;
                Home.HomeAccel = xAxisAmp.VelocityLoopSettings.VelLoopMaxAcc / 10;

                // Choose a homing method.  In this case move positove to index
                Home.HomeMethod = CML_HOME_METHOD.CHOME_INDEX_POSITIVE;

                // Then back off index by 1000 counts
                Home.HomeOffset = -1000;

                // Send new home settings to amp
                xAxisAmp.HomeSettings = Home;

                // Perform homing operation
                xAxisAmp.GoHome();

                // Set Label
                referencedLabel.Text = " Not referenced";

                // Force screen update
                this.Refresh();

                xAxisAmp.WaitMoveDone(10000);  // wait up to 10 seconds for move to finish

                HomeAxisButton.Enabled = true;
            }
            catch (Exception ex)
            {
                ;
                HomeAxisButton.Enabled = true;
                DisplayError(ex);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            try
            {
                xAxisAmp.Reset();
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void Homing_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                xAxisAmp.Disable();
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
                // It is possible that this method was called from a thread other than the 
                // GUI thread - if this is the case we must use a delegate to close the application.
                //Dim d As New CloseApp(AddressOf ThreadSafeClose)
                CloseApp d = new CloseApp(ThreadSafeClose);
                this.Invoke(d);
            }
        }

        public void ThreadSafeClose()
        {
            // If the calling thread is different than the GUI thread, then use the
            // delegate to close the application, otherwise call close() directly
            if (this.InvokeRequired)
            {
                CloseApp d = new CloseApp(ThreadSafeClose);
                this.Invoke(d);
            }
            else
                Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // Read and display actual position 
                posTextBox.Text = Convert.ToString(xAxisAmp.PositionActual);

                // Read and display amplifier status
                if (xAxisAmp.IsReferenced)
                {
                    referencedLabel.Text = "Referenced";
                }
                else
                {
                    referencedLabel.Text = " Not referenced";
                }
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }
    }
}
