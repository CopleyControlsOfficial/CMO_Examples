// Template
//
// This program demonstrates various initialization and usages of the objects in CMO
//
// This code also includes the following prerequisites:
// 1. The amplifier and motor must be preconfigured and set up properly to run.
// 2. The hardware enable switch must be installed and easily accessible
// 
// As with any motion product extreme caution must used! Read and understand
// all parameter settings before attemping to send to amplifier.
//
//
// Copley Motion Objects are Copyright, 2002-2018, Copley Controls.
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
using CMLCOMLib;

namespace CMO_CS2017_TEMPLATE
{
    public partial class Template : Form
    {
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

        ampSettingsObj ampSettings;
        AmpInfoObj ampInfo;

        ProfileSettingsObj profileSettings;

        eventObj evt;

        // Create a delegate to close down the application in a thread safe way
        delegate void CloseApp();

        public Template()
        {
            InitializeComponent();
        }

        private void Template_Load(object sender, EventArgs e)
        {
            try
            {
                //**************************************************************************
                //* Turn on logging by setting a CML object
                //**************************************************************************
                cmlObj = new CopleyMotionLibraryObj();
                cmlObj.DebugLevel = LOG_ALL;

                //**************************************************************************
                //* Part 1:
                //*
                //* network and amplifier initialization
                //**************************************************************************

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
                //* An alternate way of initializing the amp object is to set up the 
                //* AmpSettingsObj then pass it into the InitializeExt method of the AmpObj. 
                //* To use it, first comment out the call to the AmpObj's Initialize method 
                //* above, then uncomment the following three lines of code.
                //**************************************************************************
                //// Create an instance of the AmpSettings object by calling the constructor 
                //// (all of the properties will be initialized to their default values).
                //ampSettings = new ampSettingsObj();
                //// Change a property
                //ampSettings.enableOnInit = false;
                //// Initialize the AmpObj with the settings object
                //ampObj.InitializeExt(canOpen, CAN_ADDRESS, ampSettings);


                //******************************************************************************
                //* Part 2:  Example code for the various objects in CMO
                //*
                //* The remaining code is shown for example purposes only.  It has been
                //* commented out because it will change your amplifier's settings.  To run
                //* code simply uncomment it, then put in reasonable values for your amplifier
                //* wherever the settings are changed.
                //******************************************************************************

                //**************************************************************************
                //* Example of reading the amp info from the amplifier
                //**************************************************************************
                // Create an instance of the ampInfo from the AmpObj
                //ampInfo = ampObj.ampInfo;
                //// Access a property of the AmpInfo object (the AmpInfo is read only)
                //Double peakCurrent;
                //peakCurrent = ampInfo.crntPeak();


                //**************************************************************************
                //* Example of using the ProfileSettings object. The following objects, which
                //* are obtained from the AmpObj, are handled the same way:
                //*   CurrentLoopSettings
                //*   VelocityLoopSettings
                //*   PositionLoopSettings
                //*   TrackingWindows
                //*   HomeSettings
                //*   MotorInfoObj
                //**************************************************************************
                //// Create an instance of the ProfileSettings object from the AmpObj.  All of
                //// the properties of the ProfileSettings will get the values that are set
                //// in the amplifier.
                //profileSettings = ampObj.ProfileSettings;
                //// Change a property of the object
                //profileSettings.ProfileType = CML_PROFILE_TYPE.PROFILE_SCURVE;
                //// Send the settings to the amplifier
                //ampObj.ProfileSettings = profileSettings;


                //**************************************************************************
                //* Example of using the event object to fire an event when a move is 
                //* complete or an amplifier fault occurs.
                //**************************************************************************
                //// Create an event object from the AmpObj so that an event will be fired when a
                //// move is done or an amplifier fault occurs
                //  evt = ampObj.CreateEvent(CML_AMP_EVENT.AMPEVENT_MOVE_DONE, CML_EVENT_CONDITION.CML_EVENT_ANY);
                //evt.EventNotify += new _IEventObjEvents_EventNotifyEventHandler(evt_EventNotify);
                // Start the move
                //ampObj.MoveRel(4000);
                // Start the event monitor.  This call is non-blocking; it will return as soon
                // as the event monitor is started, so that the program can remain responsive
                // to other events like user interaction with the GUI
                // evt.Start(false, 15000);


                //**************************************************************************
                //* Example of using the event object to wait on an event (move done or amp
                //* fault)
                //**************************************************************************
                //// Create an event object from the AmpObj so that an event will be fired when a
                //// move is done or an amplifier fault occurs
                //eventObj = ampObj.CreateEvent(CML_AMP_EVENT.AMPEVENT_MOVE_DONE
                //                              | CML_AMP_EVENT.AMPEVENT_FAULT,
                //                              CML_EVENT_CONDITION.CML_EVENT_ANY);
                //// Start the move
                //ampObj.MoveRel(MOVE_DISTANCE);
                //// Wait here for the event to occur.  This call is blocking.  The program will
                //// not remain responsive to other events (like user interaction with the GUI)
                //eventObj.Wait(MOVE_TIMEOUT);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void evt_EventNotify(int match, bool timeOut)
        {
            //TODO: Add your event handler code here
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
