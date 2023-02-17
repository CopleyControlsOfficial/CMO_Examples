//
// Example 1 Status and Control Rev 5
//
// This program demonstrates Copley Motion Object Status and Control
//
// The purpose of this Examble is to enable and disable the amplifier and
// read and decode the amplifier status.
//
// This program assumes the following axis configuration:
// 1. Upon startup it will enable axis at Can Node ID 1
//
// This code also includes the following prerequisites:
// 1. The amplifier and motor must be preconfigured and set up properly to run.
// 2. The hardware enable switch must be installed and easily accessible
// 
// As with any motion product extreme caution must used! Read and understand
// all parameter settings before attemping to send to amplifier.
//
//
// Copley Motion Objects are Copyright, 2002-2021, Copley Controls.
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
using System.Collections;
using CMLCOMLib;

namespace EX1_Status
{
    public partial class Status : Form
    {
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
        ampSettingsObj ampSettings;

        // Create a delegate to close down the application in a thread safe way
        delegate void CloseApp();

        public Status()
        {
            InitializeComponent();
        }

        private void Status_Load(object sender, EventArgs e)
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
                //* Initialize the amp to not be enabled on start up by creating an
                //* ampSettingsObj then passing it into the InitializeExt method of the AmpObj.
                //***************************************************
                // Create an instance of the amp settings object by calling the constructor
                // (all of the properties will be initialized to their default values).
                ampSettings = new ampSettingsObj();
                // Change a property
                ampSettings.enableOnInit = false;
                // Initialize the AmpObj with the settings object
                xAxisAmp.InitializeExt(canOpen, X_AXIS_CAN_ADDRESS, ampSettings);
                //***************************************************
                //* An alternate way of initializing the amplifier with default settings.
                //* To use it, comment out the above initialization code, and
                //* uncomment the following line.
                //***************************************************
                //xAxisAmp.Initialize(canOpen, X_AXIS_CAN_ADDRESS);


                // read event sticky clears all initial events
                CML_EVENT_STATUS status = 0;
                xAxisAmp.ReadEventSticky(ref status);
                statusTextBox.Text = Convert.ToString(status);

                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //Read and display actual position 
                posTextBox.Text = Convert.ToString(xAxisAmp.PositionActual);

                //Read and display amplifier status
                CML_EVENT_STATUS status = 0;
                xAxisAmp.ReadEventStatus(ref status);
                statusTextBox.Text = Convert.ToString((int)status);
            }
            catch (Exception ex)
            {
                timer1.Stop();
                DisplayError(ex);
            }
        }

        private void enableButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (enableButton.Text == "Amp Disable")
                {
                    //disable the amp
                    xAxisAmp.Disable();
                    enableButton.Text = "Amp Enable";
                }
                else
                {
                    //enable the amp
                    xAxisAmp.Enable();
                    enableButton.Text = "Amp Disable";
                }
            }
            catch (Exception ex)
            {
                timer1.Stop();
                DisplayError(ex);
            }
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            try
            {
                CML_EVENT_STATUS stickyStatus = 0;

                //Read event sticky status
                //Note reading event sticky status automatically clears 
                //events which have been set since last read
                xAxisAmp.ReadEventSticky(ref stickyStatus);
                ArrayList values = new ArrayList();


                if ((CML_EVENT_STATUS)(stickyStatus & CML_EVENT_STATUS.EVENT_STATUS_BRAKE) == CML_EVENT_STATUS.EVENT_STATUS_BRAKE)
                {
                    values.Add("EVENT_STATUS_BRAKE");
                }
                if ((CML_EVENT_STATUS)(stickyStatus & CML_EVENT_STATUS.EVENT_STATUS_FAULT) == CML_EVENT_STATUS.EVENT_STATUS_FAULT)
                {
                    values.Add("EVENT_STATUS_FAULT");
                }
                if ((CML_EVENT_STATUS)(stickyStatus & CML_EVENT_STATUS.EVENT_STATUS_NEGATIVE_LIMIT) == CML_EVENT_STATUS.EVENT_STATUS_NEGATIVE_LIMIT)
                {
                    values.Add("EVENT_STATUS_NEGATIVE_LIMIT");
                }
                if ((CML_EVENT_STATUS)(stickyStatus & CML_EVENT_STATUS.EVENT_STATUS_POSITIVE_LIMIT) == CML_EVENT_STATUS.EVENT_STATUS_POSITIVE_LIMIT)
                {
                    values.Add("EVENT_STATUS_POSITIVE_LIMIT");
                }
                if ((CML_EVENT_STATUS)(stickyStatus & CML_EVENT_STATUS.EVENT_STATUS_PWM_DISABLE) == CML_EVENT_STATUS.EVENT_STATUS_PWM_DISABLE)
                {
                    values.Add("EVENT_STATUS_PWM_DISABLE");
                }
                if ((CML_EVENT_STATUS)(stickyStatus & CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_DISABLE) == CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_DISABLE)
                {
                    values.Add("EVENT_STATUS_SOFTWARE_DISABLE");
                }
                if ((CML_EVENT_STATUS)(stickyStatus & CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_LIMIT_NEGATIVE) == CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_LIMIT_NEGATIVE)
                {
                    values.Add("EVENT_STATUS_SOFTWARE_LIMIT_NEGATIVE");
                }
                if ((CML_EVENT_STATUS)(stickyStatus & CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_LIMIT_POSITIVE) == CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_LIMIT_POSITIVE)
                {
                    values.Add("EVENT_STATUS_SOFTWARE_LIMIT_POSITIVE");
                }
                //Note all Events are not included for complete list see documentation

                ListBox1.DataSource = values;
            }
            catch (Exception ex)
            {
                timer1.Stop();
                DisplayError(ex);
            }
        }

        private void Status_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                xAxisAmp.Disable();
            }
            catch (Exception ex)
            {
                timer1.Stop();
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
