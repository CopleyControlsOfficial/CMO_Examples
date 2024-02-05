//
// Example 12 Data Logger Rev 0
// 
// The following example demonstrates how to poll CANopen Objects via TxPDO
// at an interval set by the user. When the Stop Logging Button is pressed,
// data polling is ceased, and the collected data is exported to a CSV file.
// The CSV file is stored in the project folder: bin\x64\Debug\DataLog.csv
// 
// The following example does not perform moves, so motor configuration with
// the drive is optional.
//
// This program assumes the following axis configuration:
// 1. Upon startup it will enable one axis at Can Node ID 1.
// 
// As with any motion product extreme caution must used! Read and understand
// all parameter settings before attemping to send to amplifier.
//
// Copley Motion Objects are Copyright, 2002-2020, Copley Controls.
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
using System.Diagnostics;
using System.Threading;
using CMLCOMLib;

namespace EX12_DataLogger
{
    public partial class DataLogger : Form
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

        List<object> DataLog = new List<object>();
        int PDO_interval_counter = 0;
        int ElapsedTime_count = 0;
        int stop_logging_bit = 0;
        int LED = 0;
        int update_rate, durationTicks, required_data_points, loops_per_minute;
        object elapsedtime;
        long frequency, nanosecPerTick;
        int using_timer = 0;

        AmpObj ampObj;
        Thread PDO_Thread;
        ampSettingsObj ampSettings;

        // RxPDO Constructors
        RPDOObj rpdo_1;
        PmapObj[] rpdoPmap_1;
        int[] rpdoObjID_1;
        int[] rpdoObjIdSub_1;
        int[] Data;

        // TxPDO Constructors
        TPDOObj tpdo_1, tpdo_2;
        PmapObj[] tpdoPmap_1, tpdoPmap_2;
        int[] tpdoObjID_1, tpdoObjID_2;
        int[] tpdoObjIdSub_1, tpdoObjIdSub_2;

        //Create a delegate to close down the application in a thread safe way
        delegate void CloseApp();
        public DataLogger()
        {
            InitializeComponent();
        }        
        
        private void DataLogger_Load(object sender, EventArgs e)
        {
            try
            {
                // Load Default Values into CANopen ID User Inputs
                ObjectID_1_TextBox.Text = "0x2240"; // Actual Motor Position
                ObjectID_2_TextBox.Text = "0x6069"; // Actual Motor Velocity 
                ObjectID_3_TextBox.Text = "0x2251"; // Profile Acceleration
                ObjectID_4_TextBox.Text = "0x2215"; // Actual Current

                StartLoggingButton.Enabled = false;
                StopLoggingButton.Enabled = false;
                InitializeButton.Enabled = true;
            }
            catch(Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void InitializeButton_Click(object sender, EventArgs e)
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

                // initialize the "use timer - time elapsed" textbox with 0 in the GUI
                ElapsedTimeTextBox.Text = "0"; 

                // Enable/Disable Buttons on GUI
                StartLoggingButton.Enabled = true;
                StopLoggingButton.Enabled = false;
                InitializeButton.Enabled = false;
                InitializeButton.BackColor = Color.Green;
                UpdateRateTrackBar.Enabled = false;

                // Do not allow user to edit PDO's once the drive has been initialized
                ObjectID_1_TextBox.ReadOnly = true;
                ObjectID_2_TextBox.ReadOnly = true;
                ObjectID_3_TextBox.ReadOnly = true;
                ObjectID_4_TextBox.ReadOnly = true;

                // Receive PDO
                rpdo_1 = new RPDOObj();
                rpdoPmap_1 = new PmapObj[2];
                rpdoPmap_1[0] = new Pmap32Obj(); // Target Velocity
                rpdoPmap_1[1] = new Pmap16Obj(); // Control Word
                rpdoObjID_1 = new int[2];
                rpdoObjID_1[0] = 0x60ff;
                rpdoObjID_1[1] = 0x6040;
                rpdoObjIdSub_1 = new int[2];
                rpdoObjIdSub_1[0] = 0;
                rpdoObjIdSub_1[1] = 0;
                rpdo_1.Init(0x20000003, rpdoPmap_1, rpdoObjID_1, rpdoObjIdSub_1, 1);
                
                //***************************************************
                //
                //  Transmit PDO 
                //
                //***************************************************
                tpdo_1 = new TPDOObj();
                tpdo_2 = new TPDOObj();
                //
                //**************************************************************************
                //* Create an array of the objects to be mapped to this TPDO
                //* Each PDO can hold up to 8 bytes of data and a max of 4 objects
                //* The Pmap size corresponds to the size of the data (8, 16, 24, or 32)
                //**************************************************************************

                tpdoPmap_1 = new PmapObj[2];
                tpdoPmap_1[0] = new Pmap32Obj(); // Actual Current
                tpdoPmap_1[1] = new Pmap32Obj(); // Actual Torque

                tpdoPmap_2 = new PmapObj[2];
                tpdoPmap_2[0] = new Pmap32Obj(); // Actual Motor Position 32 bits
                tpdoPmap_2[1] = new Pmap16Obj(); // Actual Current is 16 bits

                //**************************************************************************
                //* Create an array of the corresponding CAN object IDs
                //**************************************************************************
                tpdoObjID_1 = new int[2];
                tpdoObjID_1[0] = Convert.ToInt32(ObjectID_1_TextBox.Text, 16); // 16 means interpret as a hex number
                tpdoObjID_1[1] = Convert.ToInt32(ObjectID_2_TextBox.Text, 16);

                tpdoObjID_2 = new int[2];
                tpdoObjID_2[0] = Convert.ToInt32(ObjectID_3_TextBox.Text, 16);
                tpdoObjID_2[1] = Convert.ToInt32(ObjectID_4_TextBox.Text, 16);

                //**************************************************************************
                //* Create an array of the corresponding CAN object ID subindexes
                //**************************************************************************
                tpdoObjIdSub_1 = new int[2];
                tpdoObjIdSub_1[0] = 0;
                tpdoObjIdSub_1[1] = 0;

                tpdoObjIdSub_2 = new int[2];
                tpdoObjIdSub_2[0] = 0;
                tpdoObjIdSub_2[1] = 0;

                //**************************************************************************

                //**************************************************************************
                //* Configure the transmit PDO
                //* The first parameter is a CAN message ID to use. This needs to be unique
                //* in the system. It is simplest to use an extended message ID (i.e. one
                //* with bit 29 set) since it willnot clash with any standard CAN ID used
                //* in the system. The fourth parameter is the type. Set transmit type to 1.
                //* This causes the PDO to be sent every sync period.  Setting the type to
                //* 2 would cause it to be sent every second period, etc.
                //**************************************************************************
                tpdo_1.Init(0x20000001, tpdoPmap_1, tpdoObjID_1, tpdoObjIdSub_1, 1);
                tpdo_2.Init(0x20000002, tpdoPmap_2, tpdoObjID_2, tpdoObjIdSub_2, 1);

                // Optionally, the RTR can be turned off (Defaults to on). 0 turns it off and
                // any non-zero value turns it back on.
                //tpdo.SetRtrOk(0);
                //
                //***************************************************
                //* Initialize the amplifier
                //***************************************************
                ampSettings = new ampSettingsObj();
                ampSettings.guardTime = 0;
                ampSettings.synchPeriod = (1000 * UpdateRateTrackBar.Value);
                ampObj.InitializeExt(canOpen, CAN_ADDRESS, ampSettings);

                //**************************************************************************
                //* Attach the TPDO to the node
                //* The first parameter gives the PDO slot to use. The amps have 8 transmit
                //* and 8 receive PDOs so this number should range from 0 - 7. CMO uses
                //* transmit PDO slots 0, 1, and 4, so those should not be used for custom
                //* PDOs.
                //**************************************************************************
                ampObj.SetTpdo(2, tpdo_1);
                ampObj.SetTpdo(3, tpdo_2);
                ampObj.SetRpdo(2, rpdo_1);

                // Displays the properties of the timer on the console.
                DisplayStopwatchProperties();
                update_rate = UpdateRateTrackBar.Value;
                Data = new int[2];
                Data[0] = 1000;
                Data[1] = 15;
                rpdo_1.SendData(Data, 1);

            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void StartLoggingButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((UseTimerCheckbox.Checked == true) && (TimerMinutesInput.Text == ""))
                {
                    DialogResult errormsgbox;
                    errormsgbox = MessageBox.Show("Timer Empty");
                }
                else
                {
                    // calculate the duration of ticks per millisecond
                    double duration_milliseconds = Convert.ToDouble(UpdateRateTrackBar.Value);
                    double ticks_per_millisecond = (Stopwatch.Frequency / 1000) - 200;

                    // calculate amount of ticks to use for .NET timer
                    durationTicks = Convert.ToInt32(Math.Round(duration_milliseconds * ticks_per_millisecond));
                    Console.WriteLine("Number of timer ticks per " + duration_milliseconds + " milliseconds is: " + durationTicks);

                    //Start Blinking LED on the GUI 
                    StatusTimer.Interval = 600;
                    StatusTimer.Start();
                    
                    // Disable and Enable Buttons in GUI
                    StartLoggingButton.Enabled = false;
                    StopLoggingButton.Enabled = true;

                    //PDOTimer.Interval = UpdateRateTrackBar.Value;  // set the interval of the PDO's 
                    UpdateRateTrackBar.Enabled = false;
                    UseTimerCheckbox.Enabled = false;
                    TimerMinutesInput.Enabled = false;

                    stop_logging_bit = 0; // bit that ends while loop 
                    
                    // create new thread
                    PDO_Thread = new Thread(PDO_Function);
                    PDO_Thread.IsBackground = true;
                    PDO_Thread.Name = "PDO Thread";
                    PDO_Thread.Start();
                    Elapsed_Time_Timer.Start();

                    if (UseTimerCheckbox.Checked == true)
                    {
                        int input_time = Convert.ToInt32(TimerMinutesInput.Text);
                        loops_per_minute = (60000 / update_rate);
                        required_data_points = loops_per_minute * input_time;
                    }
                }
            }
            catch(Exception ex)
            {
                DisplayError(ex);
            }            
        }

        private void PDO_Function()
        {
            try
            {
                while (stop_logging_bit == 0)
                {
                    try
                    {
                        UPDATE_TEXTFIELDS(); // show data in real time in the GUI
                                                
                        elapsedtime = PDO_interval_counter * update_rate;
                        DataLog.Add(elapsedtime);
                        DataLog.Add(tpdo_1.data[0]);
                        DataLog.Add(tpdo_1.data[1]);
                        DataLog.Add(tpdo_2.data[0]);
                        DataLog.Add(tpdo_2.data[1]);
                        PDO_interval_counter = PDO_interval_counter + 1;

                        // if the required data has been collected, stop logging PDO's
                        if ((PDO_interval_counter == required_data_points) && (using_timer==1))
                        {
                            break;
                        }

                        var StopWatch = Stopwatch.StartNew(); // Stopwatches have a certain number of ticks per second.
                        while (StopWatch.ElapsedTicks < durationTicks) // durationTicks = 2237 * minutes
                        {
                            // do nothing for correct amount of milliseconds
                        }                       
                    }
                    catch (Exception ex)
                    {
                        STOP_ELAPSED_TIME_TIMER();
                        DisplayError(ex);
                        break;
                    }
                }
                if (using_timer == 1)
                {
                    STOP_LOGGING();
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void StopLoggingButton_Click(object sender, EventArgs e)
        {
            // Let the user know that data logging has cease blinking LED in gui
            StatusTimer.Stop();
            DataProgressBar.Value = 0;

            // Stop counting the elapsed time
            Elapsed_Time_Timer.Stop();   
            
            // Breaks the while loop in the StartLoggingButton_Click()
            stop_logging_bit = 1;

            // Reset PDO_interval_counter and Elapsed Time
            PDO_interval_counter = 0;
            ElapsedTime_count = 0;
            ElapsedTimeTextBox.Text = "0";
                    
            // Disable and enable buttons
            StartLoggingButton.Enabled = true;
            StopLoggingButton.Enabled = false;
            UseTimerCheckbox.Enabled = true;
            TimerMinutesInput.Enabled = true;

            // Begin formatting data in the DataLog list into a CSV file

            StringBuilder CSV = new StringBuilder();

            string title_1 = "Elapsed Time (ms)";
            string title_2 = "Object 1";
            string title_3 = "Object 2";
            string title_4 = "Object 3";
            string title_5 = "Object 4";
            string title_format = string.Format("{0},{1},{2},{3},{4}", title_1, title_2, title_3, title_4, title_5);

            CSV.Append(title_format);
            CSV.AppendLine(" ");

            // 
            // The number_of_CANopen_objects_plus_one variable should be equal to the number of CANopen
            // objects being polled plus one. Each CANopen object will be given a column in the CSV file
            // in addition to the timestamp column, hence the plus one.
            //
            string time, obj_1, obj_2, obj_3, obj_4, Data_Format;

            int number_of_CANopen_objects_plus_one = 5; // number of columns to file (objects being mapped + timestamp);
            for (int i = 0; i < DataLog.Count / number_of_CANopen_objects_plus_one; i++)
            {
                time = Convert.ToString(DataLog[0 + (number_of_CANopen_objects_plus_one * i)]); // timestamp
                obj_1 = Convert.ToString(DataLog[1 + (number_of_CANopen_objects_plus_one * i)]); // actual motor current
                obj_2 = Convert.ToString(DataLog[2 + (number_of_CANopen_objects_plus_one * i)]); // torque actual value
                obj_3 = Convert.ToString(DataLog[3 + (number_of_CANopen_objects_plus_one * i)]); // latched event status register
                obj_4 = Convert.ToString(DataLog[4 + (number_of_CANopen_objects_plus_one * i)]); // 
                Data_Format = string.Format("{0},{1},{2},{3},{4}", time, obj_1, obj_2, obj_3, obj_4); // CSV formatting
                CSV.AppendLine(Data_Format);
            }

            DataLog.Clear();
            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataLog.csv"), CSV.ToString());
        }

        // Displays the Stopwatch Properties inherent to the .NET Framework at the beginning of the project.
        public void DisplayStopwatchProperties()
        {
            // Display the stopwatch frequency and resolution.
            if (Stopwatch.IsHighResolution)
            {
                Console.WriteLine("Operations timed using the system's high-resolution performance counter.");
            }
            else
            {
                Console.WriteLine("Operations timed using the DateTime class.");
            }

            frequency = Stopwatch.Frequency;
            Console.WriteLine("  Stopwatch frequency in ticks per second = {0}",
                frequency);
            nanosecPerTick = (1000L * 1000L * 1000L) / frequency;
            Console.WriteLine("  Stopwatch is accurate within {0} nanoseconds",
                nanosecPerTick);
        }

        // The STOP_LOGGING, STOP_ELAPSED_TIME_TIMER, and UPDATE_TEXTFIELDS functions 
        // are called from the PDO_Thread to access buttons in the main thread.
        private void STOP_LOGGING()
        {
            this.BeginInvoke((Action)delegate ()
            {
                StopLoggingButton.PerformClick();
            });
        }
        private void STOP_ELAPSED_TIME_TIMER()
        {
            this.BeginInvoke((Action)delegate ()
            {
                Elapsed_Time_Timer.Stop();
                StopLoggingButton.PerformClick();
            });
        }

        // Update the PDO data collected in real time and display it in the GUI
        private void UPDATE_TEXTFIELDS()
        {
            this.BeginInvoke((Action)delegate ()
            {
                IDReadOnlyTextField1.Text = Convert.ToString(tpdo_1.data[0]);
                IDReadOnlyTextField2.Text = Convert.ToString(tpdo_1.data[1]);
                IDReadOnlyTextField3.Text = Convert.ToString(tpdo_2.data[0]);
                IDReadOnlyTextField4.Text = Convert.ToString(tpdo_2.data[1]);
            });
        }

        // Used when the Start Logging Button is pressed. 
        // Triggered every minute.
        private void GUI_Compare_Timer_Tick(object sender, EventArgs e)
        {            
            ElapsedTime_count = ElapsedTime_count + 1;
            ElapsedTimeTextBox.Text = Convert.ToString(ElapsedTime_count);
        }

        // Checkbox GUI Update Event
        private void UseTimerCheckbox_CheckedChanged(object sender, EventArgs e)
        {            
            // If the use timer checkbox is checked, the textfield for the timer is enabled 
            if (UseTimerCheckbox.Checked == true)
            {
                TimerMinutesInput.Enabled = true;
                using_timer = 1;
            }
            // If the checkbox is not checked, the textfield is disabled
            else
            {
                TimerMinutesInput.Enabled = false;
                using_timer = 0;
            }
        }
        
        // Update the label to display the correct update rate corresponding to the trackbar
        private void UpdateRateTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateRateLabel.Text = Convert.ToString(UpdateRateTrackBar.Value);
        }

        // Toggle the LED in the GUI letting user know data is being collected
        private void StatusTimer_Tick(object sender, EventArgs e)
        {
            if(LED == 0)
            {
                DataProgressBar.Value = 100;
                LED = 1;
            }
            else
            {
                DataProgressBar.Value = 0;
                LED = 0;
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
        private void LogData_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Environment.Exit(Environment.ExitCode);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }
    }
}
