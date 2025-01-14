// Example 7 Trace Rev 5
//
// This program demonstrates the use of the amplifier's trace functionality
// by using the trace methods and properties of CMO.  The trace is a
// valuable tool because it allows data (e.g velocity, position, etc.) to
// be collected by the amplifier, then read from the amplifier over the
// CAN bus or EtherCAT network for analysis.
// 
// Trace configuration:
//   Before using the trace, it must be configured.  The InitTraceData()
//   method of this program performs the trace configuration.  This is done
//   by:
//      1) Read all of the trace settings from the amplifier.
//      2) Set up the trace variables to indicate to the amplifier what data
//         is to be collected.
//      3) Get the maximum samples that can be collected (this value changes 
//         based on how many and what type of trace variables are chosen).
//      4) Set up the trace trigger.  This will determine what condition must
//         be met before the trace data will be collected from the amplifier.
// The trace settings used by this program are:
//   Trace Variables: Channels 0 and 1 are set to actual current and bus voltage.
//   Trigger: Set up to trigger when the amplifier's software enable changes from
//   disabled to enabled.
//   
//
// Running the trace:
//   Running the trace consists of:
//      1) Sending a command to the amplifier to start the trace.  The amplifier
//         will start sampling data to monitor for the trigger.
//      2) Monitor the trace status to see when the trigger occurs and when the 
//         amplifier is finished collecting data.
//      3) Read the trace data from the amplifier after both condition of step 2
//         are met.
//   This program uses a thread for steps 2 and 3 above, because polling the
//   trace status can be processor intensive and without a thread doing the work,
//   the GUI may become unresponsive.
//   Once the data is read in from the amplifier, this program saves it to a file
//   in a comma-separated value format, so that it can be opened in a spreadsheet
//   type of program for analysis.
//
//
// Using this program:
//   Once the program has been started, the GUI will display all of the trace
//   settings and the amplifier will be disabled (done in the Form1_Load() method).
//   Press the Start button to start the amplifier's trace. This will also start the
//   thread in this program that monitors the trace status and collects data. To 
//   trigger the trace, press the Amp Enable button.  This will cause the trace to 
//   trigger because the trigger was setup to trigger when the amplifier software 
//   enable goes from disabled to enabled.  Once the data is collected, it is written
//   to a file that can be opened in a spreadsheet type of program.
//
// NOTE: .csv gets placed in the project folder then \bin\debug
//
// Copley Motion Objects are Copyright, 2005-2024, Copley Controls Corp.
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
using System.Threading;
using System.IO;
using CMLCOMLib;

namespace EX7_Trace
{
    public partial class Trace : Form
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

        AmpObj Amp;


        CML_EVENT_STATUS EventStatus;

        const int CHANNEL0 = 0;
        const int CHANNEL1 = 1;

        const int ACTIVE_CHANNEL_COUNT = 2;

        CML_AMP_TRACE_STATUS AmpTraceStatus;
        short AmpSamplesCollected;
        short AmpMaxChannels;
        int AmpTraceRefPeriod;
        short AmpMaxSamples;
        short AmpTracePeriod;
        int CalcTotalTraceTime;

        CML_AMP_TRACE_VAR AmpChan1Var;
        CML_AMP_TRACE_VAR AmpChan2Var;

        CML_AMP_TRACE_TRIGGER AmpTrigType;
        short AmpTrigChan;
        int AmpTrigLevel;
        short AmpTrigDelay;

        public int[] TraceData;
        public int DataCount;

        Thread TraceThread;

        //Create a delegate to updateGui down the application in a thread safe way
        delegate void UpdateButton(bool enabled);
        //Create a delegate to updateGui down the application in a thread safe way
        delegate void UpdateText(string text);
        //Create a delegate to close down the application in a thread safe way
        delegate void CloseApp();

        public Trace()
        {
            InitializeComponent();
        }

        private void Trace_Load(object sender, EventArgs e)
        {
            try
            {
                //**************************************************************************
                //* Turn on logging by setting a CML object
                //**************************************************************************
                cmlObj = new CopleyMotionLibraryObj();
                cmlObj.DebugLevel = LOG_ALL;

                Amp = new AmpObj();

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
                Amp.Initialize(canOpen, CAN_ADDRESS);


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
                //Amp.InitializeEcat(ecatObj, ECAT_NODE);
                //

                InitTraceData();

                InitGUI();

                Amp.Disable();

                Timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void Trace_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StopTrace();
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void InitTraceData()
        {
            try
            {

                // These values need to be read first 
                Amp.ReadTraceRefPeriod(ref AmpTraceRefPeriod); //the minimum rate at which the amplifier collects data
                Amp.ReadTraceMaxChannel(ref AmpMaxChannels);

                // //////////////////////////////////////////////////////////////////////
                // Read the rest of the trace settings from the amplifier
                // //////////////////////////////////////////////////////////////////////
                Amp.ReadTraceStatus(ref AmpTraceStatus, ref AmpSamplesCollected, ref AmpMaxSamples);
                Amp.ReadTracePeriod(ref AmpTracePeriod);
                Amp.ReadTraceChannel(CHANNEL0, ref AmpChan1Var);
                Amp.ReadTraceChannel(CHANNEL1, ref AmpChan2Var);
                Amp.ReadTraceTrigger(ref AmpTrigType, ref AmpTrigChan, ref AmpTrigLevel, ref AmpTrigDelay);

                // //////////////////////////////////////////////////////////////////////
                //           Now change the trace settings for our example
                // //////////////////////////////////////////////////////////////////////

                // set up channel 1 for actual current and channel 2 for bus voltage
                AmpChan1Var = CML_AMP_TRACE_VAR.TRACEVAR_CRNT_ACT_Q;
                AmpChan2Var = CML_AMP_TRACE_VAR.TRACEVAR_HIGH_VOLT;
                Amp.WriteTraceChannel(CHANNEL0, AmpChan1Var);
                Amp.WriteTraceChannel(CHANNEL1, AmpChan2Var);

                // Set all of the remaining channels to 0 to ensure that nothing else is traced
                int channel;
                channel = CHANNEL1 + 1;
                while (channel < AmpMaxChannels)
                {
                    Amp.WriteTraceChannel(Convert.ToInt16(channel), 0);
                    channel = channel + 1;
                }

                // Now that the trace variables have been set up, read in the trace status so
                // that we can get the max samples per channel.  The value of max samples varies 
                // depending upon how many trace variables are chosen and what types are chosen.  
                // This value should be obtained each time the trace variables are changed.
                Amp.ReadTraceStatus(ref AmpTraceStatus, ref AmpSamplesCollected, ref AmpMaxSamples);

                // Set up the array size based upon how many samples can be collected.  We need to
                // multiply AmpMaxSamples by the number of active channels (2 in our case) because
                // the array will contain the data for all channels

                // C# can't dynamically resize an array.  Just copy into new array.
                //string[] names2 = new string[7]; 
                int[] TraceData = new int[AmpMaxSamples * ACTIVE_CHANNEL_COUNT];
                // ///////////////////////////////////////////////////////////////////////////////
                // 
                // Calculate the maximum trace time allowed based on the values of 
                //     Trace Ref Period - The minimum sample time that the amplifier can collect 
                //                        samples
                //     Trace Period     - The period at which the amplifier will collect samples.
                //                        It is an integer multiple of the Trace Ref Period
                //     Max Samples      - The maximum number of samples that can be held in the 
                //                        amplifier//s internal trace buffer.  This number varies with
                //                        the number and type of trace variables set.
                // 
                // The maximum trace time = TraceRefPeriod * TracePeriod * MaxSamples
                // This value is in nanoseconds.  Since the GUI displays milliseconds, we
                // need to do a conversion.
                //
                // ///////////////////////////////////////////////////////////////////////////////
                CalcTotalTraceTime = Convert.ToInt32((AmpTraceRefPeriod * 0.000001) * AmpTracePeriod * AmpMaxSamples);

                // ///////////////////////////////////////////////////////////////////////////////
                // set up the trace to trigger on a software enable of the amplifier with a negative 
                // delay of 10% of max number of samples.  Setting a negative delay in this manner 
                // results in capturing 10% of the waveform before the trigger occurs.
                // //////////////////////////////////////////////////////////////////////////////
                AmpTrigChan = CHANNEL0;
                AmpTrigType = CML_AMP_TRACE_TRIGGER.TRACETRIG_EVENTCLR;
                AmpTrigLevel = 0x1000; // Event Status bit 12 = software enable
                AmpTrigDelay = Convert.ToInt16(AmpMaxSamples * -0.1);  // negative delay of 10% of max number of samples
                Amp.WriteTraceTrigger(AmpTrigType, AmpTrigChan, AmpTrigLevel, AmpTrigDelay);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void InitGUI()
        {
            try
            {
                // initialized the values on the GUI
                TraceRefPeriodValue.Text = Convert.ToString(AmpTraceRefPeriod);
                TracePeriodTextBox.Text = Convert.ToString(AmpTracePeriod);
                MaxSamplesValue.Text = Convert.ToString(AmpMaxSamples);
                TotalTraceTimeValue.Text = Convert.ToString(CalcTotalTraceTime);

                TraceStatusValue.Text = "Ready";

                TrigTypeTextBox.Text = Convert.ToString(Convert.ToInt32(AmpTrigType));
                TrigChannelTextBox.Text = Convert.ToString(AmpTrigChan);
                TrigLevelTextBox.Text = Convert.ToString(AmpTrigLevel);
                TrigDelayTextBox.Text = Convert.ToString(AmpTrigDelay);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void SendPeriodButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Get the new value from the GUI
                AmpTracePeriod = Convert.ToInt16(TracePeriodTextBox.Text);

                //Write it to the amplifier
                Amp.WriteTracePeriod(AmpTracePeriod);

                //Now calculate the total trace time and display it on the GUI.
                CalcTotalTraceTime = Convert.ToInt32((AmpTraceRefPeriod * 0.000001) * AmpTracePeriod * AmpMaxSamples);
                TotalTraceTimeValue.Text = Convert.ToString(CalcTotalTraceTime);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void StartTraceButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create the new thread object and use the RunTrace() method in this file as
                // the thread
                TraceThread = new Thread(new ThreadStart(RunTrace));

                // Start the trace in the amplifier
                Amp.TraceStart();

                // Start the thread
                TraceThread.Start();

                StartTraceButton.Enabled = false;
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void StopTraceButton_Click(object sender, EventArgs e)
        {
            try
            {
                StopTrace();
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void StopTrace()
        {
            try
            {
                StartTraceButton.Enabled = true;
                TraceStatusValue.Text = "Ready";

                Amp.TraceStop();

                //If the thread object has not been made or it is not running, then no need
                //to do anything more.
                if (TraceThread == null)
                {
                    return;
                }
                //if the thread has already been aborted, then don't try to abort it again
                if (TraceThread.ThreadState == System.Threading.ThreadState.Aborted)
                {
                    return;
                }
                TraceThread = null;
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void SendTrigSettingsButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get all of the values from the GUI
                AmpTrigDelay = Convert.ToInt16(TrigDelayTextBox.Text);
                AmpTrigLevel = Convert.ToInt32(TrigLevelTextBox.Text);
                AmpTrigChan = Convert.ToInt16(TrigChannelTextBox.Text);
                //    (YourEnum)Enum.Parse(typeof(yourEnum), yourString);
                AmpTrigType = (CML_AMP_TRACE_TRIGGER)Enum.Parse(typeof(CML_AMP_TRACE_TRIGGER), TrigTypeTextBox.Text);

                //Send the trigger settings to the amplifier
                Amp.WriteTraceTrigger(AmpTrigType, AmpTrigChan, AmpTrigLevel, AmpTrigDelay);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void EnableDisableButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((EventStatus & CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_DISABLE) == CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_DISABLE)
                {
                    Amp.Enable();
                }
                else
                {
                    Amp.Disable();
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //Read the amplifier's event status word to get the state of the "amplifier
                //disabled by software" bit
                Amp.ReadEventStatus(ref EventStatus);
                if ((EventStatus & CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_DISABLE) == CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_DISABLE)
                {
                    EnableDisableButton.Text = "Amp Enable";
                }
                else
                {
                    EnableDisableButton.Text = "Amp Disable";
                }
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }

        private void RunTrace()
        {
            // Create file for the trace data to be viewed in a spreadsheet type of program.
            // The file location will be in the same folder as the project file for this 
            // program.
            //System.IO.StreamWriter file=null;
            FileStream fs = null;

            try
            {
                // Wait for the trigger to occur

                // Since this thread is different from the GUI thread we must use a delegate
                // to call a method to update the GUI component (TraceStatusValue)
                UpdateText textDelegate = new UpdateText(UpdateTraceStatus);
                TraceStatusValue.Invoke(textDelegate, "Waiting for Trigger.");

                do
                {
                    Amp.ReadTraceStatus(ref AmpTraceStatus, ref AmpSamplesCollected, ref AmpMaxSamples);
                } while (((AmpTraceStatus & CML_AMP_TRACE_STATUS.TRACE_STATUS_TRIGGERED) != CML_AMP_TRACE_STATUS.TRACE_STATUS_TRIGGERED)
                                && (TraceThread != null));

                // This is null when the trace has stopped without triggering.
                if (TraceThread == null)
                    return;

                // Since this thread is different from the GUI thread we must use a delegate 
                // to call a method to update the GUI component (TraceStatusValue)
                TraceStatusValue.Invoke(textDelegate, "Amplifier is collecting data.");

                do
                {
                    Amp.ReadTraceStatus(ref AmpTraceStatus, ref AmpSamplesCollected, ref AmpMaxSamples);
                } while (((AmpTraceStatus & CML_AMP_TRACE_STATUS.TRACE_STATUS_RUNNING) == CML_AMP_TRACE_STATUS.TRACE_STATUS_RUNNING)
                                && (TraceThread != null));

                if (TraceThread == null)
                    return;

                // Read in the trace data from the amp

                // Since this thread is different from the GUI thread we must use a delegate
                // to call a method to update the GUI component (TraceStatusValue)
                TraceStatusValue.Invoke(textDelegate, "Reading trace data from amplifier.");

                // Keeps a running total of all of the samples collected so far
                int TotalSamplesReceived = 0;

                // Request the max number of samples - the amplifier will let us know how many samples
                // it returned in the ReadTraceData method.  Since AmpMaxSamples is per channel and
                // the array will contain data for both channels, we have to multiply AmpMaxSamples 
                // by 2 (number of active channels) to get the total number of data points available
                DataCount = AmpMaxSamples * ACTIVE_CHANNEL_COUNT;

                //file = new System.IO.StreamWriter("..\\TraceData.csv");
                fs = new FileStream(".\\TraceData.csv", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                // Keep reading data until we get all of it
                while (TotalSamplesReceived < DataCount)
                {

                    // Read the trace data.  When calling ReadTraceData, DataCount contains how 
                    // many samples we want.
                    // When returning from the method call, DataCount contains the actual number
                    // of samples returned by the amplifier.
                    //
                    // The data for both channels are contained within the TraceData array. Therefore
                    // if two channels are used and the max samples is 1024, then there are 512
                    // data points for each channel.
                    //
                    // The data is arranged in the array as follows (assuming two channels were used):
                    // Chan1|Chan2|Chan1|Chan2...
                    // Must cast TraceData into Object for ReadTraceData to take it 
                    int[] TraceDataObj = new int[AmpMaxSamples * ACTIVE_CHANNEL_COUNT];
                    Amp.ReadTraceData(ref TraceDataObj, ref DataCount);
                    // Now turn TraceDataObj back to normal array TraceData
                    TraceData = (int[])TraceDataObj;
                    // Now write all of the data to a file.  The file is written in a comma-
                    // separated value (CSV) form consisting of three values. The first value is
                    // time, the second and third values are channel 1 and and channel 2 respectively.
                    int SampleNumber; //used in calculating the time for the file
                    SampleNumber = 0;
                    for (int i = 0; i < DataCount; i = i + 2)
                    {
                        // The amplifier only returns the data that was requested when the trace
                        // variables were set up. It does not return the time at which the data
                        // was collected.  However, the times can be calculated because the rate 
                        // at which the data was collected is known (TraceRefPeriod * TracePeriiod).
                        // Using this information the time at which each sample was collected can 
                        // be calculated.

                        // Calculate the time that this sample was taken (convert to milliseconds)
                        // and write it to the file.
                        sw.Write((SampleNumber * AmpTraceRefPeriod * 0.000001 * AmpTracePeriod));
                        sw.Write(",");

                        // Write the data from channel 1
                        sw.Write(TraceData[i]);
                        sw.Write(",");

                        // Write the data from channel 2
                        sw.Write(TraceData[i + 1]);
                        sw.WriteLine();

                        SampleNumber = SampleNumber + 1;
                    }//close for loop

                    TotalSamplesReceived = TotalSamplesReceived + DataCount;

                }//close while loop

                sw.Close();

                UpdateButton buttonDelegate = new UpdateButton(EnableStartTraceButton);
                StartTraceButton.Invoke(buttonDelegate, true);

                // Since this thread is different from the GUI thread we must use a delegate
                // to call a method to update the GUI component (TraceStatusValue)
                TraceStatusValue.Invoke(textDelegate, "Ready.");

            }
            catch (Exception ex)
            {
                if (fs == null) { }
                else
                {
                    fs.Close();
                }
                DisplayError(ex);
            }
        }

        public void EnableStartTraceButton(bool enabled)
        {
            // If the calling thread is different than the GUI thread, then use the
            //delegate to update the trace status, otherwise use the gui control directly
            if (StartTraceButton.InvokeRequired)
            {
                UpdateButton d = new UpdateButton(EnableStartTraceButton);
                StartTraceButton.Invoke(d, enabled);
            }
            else
            {
                StartTraceButton.Enabled = enabled;
            }
        }

        public void UpdateTraceStatus(string text)
        {
            //If the calling thread is different than the GUI thread, then use the
            // delegate to update the trace status, otherwise use the gui control directly
            if (TraceStatusValue.InvokeRequired)
            {
                UpdateText d = new UpdateText(UpdateTraceStatus);
                TraceStatusValue.Invoke(d, text);
            }
            else
            {
                TraceStatusValue.Text = text;
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
