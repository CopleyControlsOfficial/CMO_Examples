//  Example 5 MultiThreaded with Events Rev 4
//
// This program demonstrates multithreaded moves with two axis using
// event driven callback
//
// This program assumes the following axis configuration:
// 1. Upon startup it will enable one axis at Can Node ID 1 and
//    one at Can Node ID 2.
// 2. Both motors have an encoders with an index
//
// This code also includes the following prerequisites:
// 1. The both amplifiers and motors must be preconfigured and set up properly to run.
// 2. The hardware enable switch must be installed on both amplifiers 
// and both are easily accessible
// 
// As with any motion product extreme caution must used! Read and understand
// all parameter settings before attemping to send to amplifier.
// This program assumes the following axis configurations:
// 
// Copley Motion Objects are Copyright, 2002-2018, Copley Controls.
//
// for more information on Copley Motion products see:
// http://www.copleycontrols.com

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

namespace EX5_MutliThreadedWithEvent
{
    public partial class MultiThreadedWithEvent : Form
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

        // thread objects for each axis
        Thread xAxisThread;
        Thread yAxisThread;

        // These are the .NET classes used to synchronize threads
        public static AutoResetEvent xResetEvent = new AutoResetEvent(false);
        public static AutoResetEvent yResetEvent = new AutoResetEvent(false);

        AmpObj AmpX;
        AmpObj AmpY;

        // X axis thread.
        // Alternate from +/-destination position. Issue the move Absolute
        // command to the amplifier.  The thread is suspended after issuing the move command to
        // wait for the move to comlpete before issuing the next move command.  
        eventObj xAxisEventObj;
        // Y axis thread.
        // Alternate from +/-destination position. Issue the move Absolute
        // command to the amplifier.  The thread is suspended after issuing the move command to
        // wait for the move to comlpete before issuing the next move command.  
        eventObj YAxisEventObj;


        double xMoveDistance;
        double yMoveDistance;

        HomeSettingsObj Home;

        ProfileSettingsObj ProfileSettings;

        // Create a delegate to close down the application in a thread safe way
        delegate void CloseApp();

        public MultiThreadedWithEvent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //**************************************************************************
                //* Turn on logging by setting a CML object
                //**************************************************************************
                cmlObj = new CopleyMotionLibraryObj();
                cmlObj.DebugLevel = LOG_ALL;

                // initialization
                AmpX = new AmpObj();
                AmpY = new AmpObj();

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
                AmpX.Initialize(canOpen, X_AXIS_CAN_ADDRESS);
                AmpY.Initialize(canOpen, Y_AXIS_CAN_ADDRESS);


                AmpX.HaltMode = CML_HALT_MODE.HALT_DECEL;
                AmpY.HaltMode = CML_HALT_MODE.HALT_DECEL;


                // These are the CMO objects that are setup to callback when the move is done
                // Set up the event call back conditions
                xAxisEventObj = AmpX.CreateEvent(CML_AMP_EVENT.AMPEVENT_MOVE_DONE, CML_EVENT_CONDITION.CML_EVENT_ANY);
                xAxisEventObj.EventNotify += new eventObj.EventHandler(xAxisEventObj_EventNotify);
                YAxisEventObj = AmpY.CreateEvent(CML_AMP_EVENT.AMPEVENT_MOVE_DONE, CML_EVENT_CONDITION.CML_EVENT_ANY);
                YAxisEventObj.EventNotify += new eventObj.EventHandler(yAxisEventObj_EventNotify);

                //set up profile settings for moves
                ProfileSettings = AmpX.ProfileSettings; // read profile settings from amp
                ProfileSettings.ProfileType = CML_PROFILE_TYPE.PROFILE_TRAP;
                ProfileSettings.ProfileAccel = (AmpX.VelocityLoopSettings.VelLoopMaxAcc) / 10;
                ProfileSettings.ProfileDecel = (AmpX.VelocityLoopSettings.VelLoopMaxDec) / 10;
                ProfileSettings.ProfileVel = (AmpX.VelocityLoopSettings.VelLoopMaxVel) / 10;
                AmpX.ProfileSettings = ProfileSettings;

                ProfileSettings = AmpY.ProfileSettings; // read profile settings from amp
                ProfileSettings.ProfileType = CML_PROFILE_TYPE.PROFILE_TRAP;
                ProfileSettings.ProfileAccel = (AmpY.VelocityLoopSettings.VelLoopMaxAcc) / 10;
                ProfileSettings.ProfileDecel = (AmpY.VelocityLoopSettings.VelLoopMaxDec) / 10;
                ProfileSettings.ProfileVel = (AmpY.VelocityLoopSettings.VelLoopMaxVel) / 10;
                AmpY.ProfileSettings = ProfileSettings;
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
                xAxisStartButton.Enabled = false;
                yAxisStartButton.Enabled = false;

                Home = AmpX.HomeSettings;
                Home.HomeVelFast = (AmpX.VelocityLoopSettings.VelLoopMaxVel) / 10;
                Home.HomeVelSlow = (AmpX.VelocityLoopSettings.VelLoopMaxVel) / 15;
                Home.HomeAccel = (AmpX.VelocityLoopSettings.VelLoopMaxAcc) / 10;
                Home.HomeMethod = CML_HOME_METHOD.CHOME_INDEX_POSITIVE;
                Home.HomeOffset = 0;
                AmpX.HomeSettings = Home;
                AmpX.GoHome();
                AmpX.WaitMoveDone(10000);


                Home = AmpY.HomeSettings;
                Home.HomeVelFast = (AmpY.VelocityLoopSettings.VelLoopMaxVel) / 10;
                Home.HomeVelSlow = (AmpY.VelocityLoopSettings.VelLoopMaxVel) / 15;
                Home.HomeAccel = AmpY.VelocityLoopSettings.VelLoopMaxAcc / 10;
                Home.HomeMethod = CML_HOME_METHOD.CHOME_NONE;

                Home.HomeOffset = 0;
                AmpY.HomeSettings = Home;
                AmpY.GoHome();
                AmpY.WaitMoveDone(10000);

                yAxisStartButton.Enabled = true;
                xAxisStartButton.Enabled = true;
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void xAxisStartButton_Click(object sender, EventArgs e)
        {
            try
            {
                HomeAxisButton.Enabled = false;

                //Read in move distance to be used
                xMoveDistance = Convert.ToDouble(xMoveDistanceTextBox.Text);

                xAxisStartButton.Enabled = false;
                xAxisThread = new Thread(RunXaxis);
                xAxisThread.Start();
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void xAxisStopButton_Click(object sender, EventArgs e)
        {
            try
            {
                xAxisEventObj.Stop();
                Stop_X_AXIS();
                if (yAxisStartButton.Enabled == true) HomeAxisButton.Enabled = true;
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void RunXaxis()
        {
            try
            {
                do
                {
                    AmpX.MoveAbs(xMoveDistance);
                    // Starts the CMO event object - this starts a thread in CMO that looks
                    //      for the move done

                    xAxisEventObj.Start(false, 50000);
                    // Wait to be signaled before continuing - the event callback method below
                    //      will signal the reset event to wake up this thread
                    xResetEvent.WaitOne();

                } while (xAxisThread != null);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void Stop_X_AXIS()
        {
            try
            {
                // If the thread object is null then return
                if (xAxisThread == null) return;

                // if the thread has already been aborted, then don't try to abort it again
                // if (xAxisThread.ThreadState.Aborted) return;
                if (xAxisThread.ThreadState == ThreadState.Aborted) return;
                AmpX.HaltMove();
                xAxisEventObj.Stop();

                xAxisStartButton.Enabled = true;

                xAxisThread = null;

                // Trigger the event to break out of the WaitOne() function and allow thread to close.
                xResetEvent.Set();
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void xAxisEventObj_EventNotify(CML_AMP_EVENT match, bool hasError)
        {
            try
            {
                if (hasError)
                {
                    Stop_X_AXIS();
                    DialogResult errormsgbox = DialogResult;
                    MessageBox.Show("Error reported by X-Axis amplifier in Event Notify", "CMO Error", MessageBoxButtons.RetryCancel);
                    if (errormsgbox == DialogResult.Cancel)
                    {
                        // it is possible that this method was called from a thread other than the 
                        // GUI thread - if this is the case we must use a delegate to close the application.
                        CloseApp d = new CloseApp(ThreadSafeClose);
                        this.Invoke(d);
                    }
                    return;
                }

                // If the thread object is null then return
                if (xAxisThread == null) return;

                // if the thread has already been aborted, then don't try to abort it again
                if (xAxisThread.ThreadState == ThreadState.Aborted) return;

                xMoveDistance = xMoveDistance * -1;

                // This is where the x axis reset event gets signaled
                xResetEvent.Set();
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void yAxisStartButton_Click(object sender, EventArgs e)
        {
            try
            {
                HomeAxisButton.Enabled = false;

                //Read in move distance to be used
                yMoveDistance = Convert.ToDouble(yAxisMoveDistanceTextBox.Text);

                yAxisStartButton.Enabled = false;
                yAxisThread = new Thread(RunYaxis);
                yAxisThread.Start();
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void yAxisStopButton_Click(object sender, EventArgs e)
        {
            try
            {
                YAxisEventObj.Stop();
                Stop_Y_Axis();

                if (xAxisStartButton.Enabled == true) HomeAxisButton.Enabled = true;
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void RunYaxis()
        {
            try
            {
                do
                {
                    AmpY.MoveAbs(yMoveDistance);

                    //Starts the CMO event object - this starts a thread in CMO that looks
                    //for the move done
                    YAxisEventObj.Start(false, 50000);

                    // Wait to be signaled before continuing - the event callback method below
                    // will signal the reset event to wake up this thread

                    yResetEvent.WaitOne();

                } while (yAxisThread != null);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void Stop_Y_Axis()
        {
            try
            {
                // If the thread object is null then return
                if (yAxisThread == null) return;
                // if the thread has already been aborted, then don't try to abort it again
                if (yAxisThread.ThreadState == ThreadState.Aborted) return;

                AmpY.HaltMove();
                YAxisEventObj.Stop();

                yAxisStartButton.Enabled = true;

                yAxisThread = null;

                // Trigger the event to break out of the WaitOne() function and allow thread to close.
                yResetEvent.Set();
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }

        }

        private void yAxisEventObj_EventNotify(CML_AMP_EVENT match, bool hasError)
        {
            try
            {
                if (hasError)
                {
                    Stop_Y_Axis();
                    DialogResult errormsgbox = DialogResult;
                    MessageBox.Show("Error reported by X-Axis amplifier in Event Notify", "CMO Error", MessageBoxButtons.RetryCancel);
                    if (errormsgbox == DialogResult.Cancel)
                    {
                        // it is possible that this method was called from a thread other than the 
                        // GUI thread - if this is the case we must use a delegate to close the application.
                        CloseApp d = new CloseApp(ThreadSafeClose);
                        this.Invoke(d);
                    }
                    return;
                }

                // If the thread object is null then return
                if (yAxisThread == null) return;

                // if the thread has already been aborted, then don't try to abort it again
                if (yAxisThread.ThreadState == ThreadState.Aborted) return;

                yMoveDistance = yMoveDistance * -1;

                // This is where the y axis reset evet gets signaled
                yResetEvent.Set();
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Stop_X_AXIS();
                Stop_Y_Axis();
                AmpY.Disable();
                AmpX.Disable();
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }
    }
}
