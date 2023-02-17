//
// Example 6 PVT Rev 3
//
// This program demonstrates Copley Motion PVT Motion
//
// The purpose of this lab is perform Position-Velocity-Time move
// on a Linkage (Coordinated) Object and draw the equivalent of a circle
// using two axes.
//
// This program assumes the following axis configuration:
// 1. Upon startup it will enable one axis at Can Node ID 1 and
//     one at Can Node ID 2.
// 2. Both motors have an encoders with an indexes
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
// http://www.copleycontrols.com/motion
//
// NOTE: Each time calcSegments() writes to the .txt files and then calcSegments2() will read the text files. 
//             The program could be changed to read one large premade .txt file by adjusting the loops in calcSegments2() and 
//             commenting out the calcSegments() calls.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using CMLCOMLib;

namespace EX6_PVT
{
    public partial class PVT : Form
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
		
        LinkageObj Linkage;
        AmpObj[] ampArray = new AmpObj [2];

        HomeSettingsObj Home;
        eventObj EventObj ;

        const short X_AXIS_AMP = 0;
        const short Y_AXIS_AMP = 1;
        const int ARRAY_LEN = 200;


        double[,] positions = new double[ARRAY_LEN, 2];
        double[,] velocities = new double [ARRAY_LEN,2];
        int[] times = new int [ARRAY_LEN];
        int numberOfEvents= 0;
        double ang, angV;

        // Create a delegate to updateGui down the application in a thread safe way
        delegate void UpdateGui();
        // Create a delegate to close down the application in a thread safe way
        delegate void CloseApp();
        public PVT()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try{
				
			//**************************************************************************
            //* Turn on logging by setting a CML object
            //**************************************************************************
            cmlObj = new CopleyMotionLibraryObj();
            cmlObj.DebugLevel = LOG_ALL;
			
            //Initialize code here

            ampArray[X_AXIS_AMP] = new AmpObj();
            ampArray[Y_AXIS_AMP] = new AmpObj();
            Linkage = new LinkageObj();

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
            ampArray[X_AXIS_AMP].Initialize(canOpen, X_AXIS_CAN_ADDRESS);
            ampArray[Y_AXIS_AMP].Initialize(canOpen, Y_AXIS_CAN_ADDRESS);


            Linkage.Initialize(ampArray);


            EventObj = Linkage.CreateEvent(CML_LINK_EVENT.LINKEVENT_LOWWATER,
                                          CML_EVENT_CONDITION.CML_EVENT_ALL);
            EventObj.EventNotify += new eventObj.EventHandler(EventObj_EventNotify);
            }
            catch (Exception ex){
            DisplayError(ex);
            }
        }

        private void calcSegments()
        {

            TextWriter tw1 = new StreamWriter("posDataFile.txt");
            TextWriter tw2 = new StreamWriter("velDataFile.txt");
            TextWriter tw3 = new StreamWriter("time.txt");
            try
            {

                //  This sub is used to calculate the points of the PVT profile used to generate 
                // a circle.
                //  int i;
                double x, y, xv, yv, angA;
                double xc, yc, t, angVmax, angAmax, R, PI;
                double velocityScalor;


                ////*****************
                // Use the following parameters to adjust the speed
                // and size of the profile circle

                R = 64000.0; // Radius of circle in (counts)
                xc = 64000.0;  // x-value for center of circle in (counts)
                yc = 5000.0;    // y-value for center of circle in (counts)
                velocityScalor = 0.25; // used to control the max velocity
                // *****************

                t = 0.01;
                PI = 4 * System.Math.Atan(1);
                angVmax = PI * velocityScalor;
                angAmax = angVmax;

                for (int j = 0; j < ARRAY_LEN; j++)
                {

                    if (angV < angVmax)
                    {
                        angA = angAmax;
                    }
                    else
                    {
                        angA = 0;
                    }

                    ang = ang + t * angV + t * t * angA / 2;
                    angV = angV + t * angA;


                    x = xc + R * System.Math.Cos(ang);
                    y = yc + R * System.Math.Sin(ang);
                    xv = -System.Math.Sin(ang) * angV * R;
                    yv = System.Math.Cos(ang) * angV * R;

               //   positions[j, 0] = x;
              //    velocities[j, 0] = xv;
                //  positions[j, 1] = y;
               //   velocities[j, 1] = yv;
               //   times[j] = Convert.ToInt32(1000 * t);
                    tw1.WriteLine(x);
                    tw1.WriteLine(y);
                    tw2.WriteLine(xv);
                    tw2.WriteLine(yv);
                    tw3.WriteLine(1000 * t);
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
            tw1.Close();
            tw2.Close();
            tw3.Close();
        }


        private void calcSegments2()
        {
            try
            {

                double[,] poss = new double[ARRAY_LEN, 0];
                int j;
                j = 0;
                string line;

                // open file containing the positions for two axes
                //FileOpen(1, "posDataFile.txt", OpenMode.Input);
                TextReader tr1 = new StreamReader("posDataFile.txt");
                while ((line = tr1.ReadLine()) != null)
                {   // Loop until end of file.
                    positions[j, 0] = Convert.ToDouble(line); // save it to the positions arrray row 1
                    positions[j, 1] = Convert.ToDouble(tr1.ReadLine()); // save it to the positions arrray row 2
                    j = j + 1; // set next column
                }
                tr1.Close();   // Close file.

                j = 0; // reset counter
                // open file containing the positions for two axes
                //FileOpen(2, "velDataFile.txt", OpenMode.Input);
                TextReader tr2 = new StreamReader("velDataFile.txt");
                while ((line = tr2.ReadLine()) != null)
                {   // Loop until end of file.
                    velocities[j, 0] = Convert.ToDouble(line);
                    velocities[j, 1] = Convert.ToDouble(tr2.ReadLine());
                    j = j + 1;
                }
                tr2.Close();   // Close file.

                j = 0; // reset counter

                //FileOpen(3, "time.txt", OpenMode.Input);
                TextReader tr3 = new StreamReader("time.txt");
                while ((line = tr3.ReadLine()) != null)
                {   // Loop until end of file.

                    times[j] = Convert.ToInt32(line);
                    j = j + 1;
                }
                tr3.Close();   // Close file.

            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }

        }


        private void startButton_Click(object sender, EventArgs e)
        {
            try{

            HomeAxisButton.Enabled = false;
            startButton.Enabled = false;

            ang = 4 * System.Math.Atan(1); // = PI;
            angV = 0;

            calcSegments();
            calcSegments2();

            numberOfEvents = 0;
            numberOfEventsTextBox.Text = Convert.ToString(numberOfEvents);

            ProfileSettingsObj ProfileSettings;

            ProfileSettings = ampArray[X_AXIS_AMP].ProfileSettings;
            ProfileSettings.ProfileAccel = (ampArray[X_AXIS_AMP].VelocityLoopSettings.VelLoopMaxAcc) / 10;
            ProfileSettings.ProfileDecel = (ampArray[X_AXIS_AMP].VelocityLoopSettings.VelLoopMaxDec) / 10;
            ProfileSettings.ProfileVel = (ampArray[X_AXIS_AMP].VelocityLoopSettings.VelLoopMaxVel) / 10;
            ProfileSettings.ProfileType = CML_PROFILE_TYPE.PROFILE_TRAP;
            ampArray[X_AXIS_AMP].ProfileSettings = ProfileSettings;


            ProfileSettings = ampArray[Y_AXIS_AMP].ProfileSettings;
            ProfileSettings.ProfileAccel = (ampArray[Y_AXIS_AMP].VelocityLoopSettings.VelLoopMaxAcc) / 10;
            ProfileSettings.ProfileDecel = (ampArray[Y_AXIS_AMP].VelocityLoopSettings.VelLoopMaxDec) / 10;
            ProfileSettings.ProfileVel = (ampArray[Y_AXIS_AMP].VelocityLoopSettings.VelLoopMaxVel) / 10;
            ampArray[Y_AXIS_AMP].ProfileSettings = ProfileSettings;


            ampArray[X_AXIS_AMP].MoveAbs(positions[0, 0]);
            ampArray[Y_AXIS_AMP].MoveAbs(positions[0, 1]);   // start y motor at midpoint

            ampArray[X_AXIS_AMP].WaitMoveDone(4000);
            ampArray[Y_AXIS_AMP].WaitMoveDone(4000);


            Linkage.TrajectoryInitialize(positions, velocities, times, 100);

            EventObj.Start(true, 5000); // false for repeating 5000 for timout
            }
            catch (Exception ex){
            DisplayError(ex);
            }
        }
        private void EventObj_EventNotify(CML_AMP_EVENT match, bool hasError){// Handles EventObj.EventNotify
                try
                {
                if (hasError)
                {
					EventObj.Stop();
                    Linkage.HaltMove();
                    DialogResult errormsgbox = DialogResult;
                    MessageBox.Show("Error reported by amplifier in Event Notify", "CMO Error", MessageBoxButtons.OKCancel);
                    if (errormsgbox == DialogResult.Cancel)
                    {
                        // it is possible that this method was called from a thread other than the 
                        // GUI thread - if this is the case we must use a delegate to close the application.
                        CloseApp d = new CloseApp(ThreadSafeClose);
                        this.Invoke(d);
                    }
                    return;
                }


            calcSegments();
            calcSegments2();

            numberOfEvents = numberOfEvents + 1;

            // Since this thread is different from the GUI thread we must use a delegate
            // to call a method to update the GUI component (numberOfEventsTextBox)
            UpdateGui textBoxDelegate = new UpdateGui(UpdateNumberOfEvents);
            numberOfEventsTextBox.Invoke(textBoxDelegate);

            Linkage.TrajectoryAdd(positions, velocities, times, 100);
            }
            catch (Exception ex){
            DisplayError(ex);
            }
        }

        public void UpdateNumberOfEvents(){
        // If the calling thread is different than the GUI thread, then use the
        // delegate to update the application, otherwise update text box directly
            if (numberOfEventsTextBox.InvokeRequired){
                UpdateGui d = new UpdateGui(UpdateNumberOfEvents);
                numberOfEventsTextBox.Invoke(d);
            }
            else{
                numberOfEventsTextBox.Text = Convert.ToString(numberOfEvents);
            }
        }

        private void StopPVTButton_Click(object sender, EventArgs e)
        {
            try{

            EventObj.Stop();
            Linkage.HaltMove();
            startButton.Enabled = true;
            HomeAxisButton.Enabled = true;
            }
            catch(Exception ex){
            DisplayError(ex);
            }
        }

        private void HomeAxisButton_Click(object sender, EventArgs e)
        {
            try{

            HomeAxisButton.Enabled = false;

            Home = ampArray[X_AXIS_AMP].HomeSettings;
            Home.HomeVelFast = (ampArray[X_AXIS_AMP].VelocityLoopSettings.VelLoopMaxVel) / 10;
            Home.HomeVelSlow = (ampArray[X_AXIS_AMP].VelocityLoopSettings.VelLoopMaxVel) / 15;
            Home.HomeAccel = ampArray[X_AXIS_AMP].VelocityLoopSettings.VelLoopMaxAcc / 10;
            Home.HomeMethod = CML_HOME_METHOD.CHOME_INDEX_POSITIVE;
            Home.HomeOffset = -4000;
            ampArray[X_AXIS_AMP].HomeSettings = Home;
            ampArray[X_AXIS_AMP].GoHome();
            ampArray[X_AXIS_AMP].WaitMoveDone(10000);


            Home = ampArray[Y_AXIS_AMP].HomeSettings;
            Home.HomeVelFast = (ampArray[Y_AXIS_AMP].VelocityLoopSettings.VelLoopMaxVel) / 10;
            Home.HomeVelSlow = (ampArray[Y_AXIS_AMP].VelocityLoopSettings.VelLoopMaxVel) / 15;
            Home.HomeAccel = ampArray[Y_AXIS_AMP].VelocityLoopSettings.VelLoopMaxAcc / 10;
            Home.HomeMethod = CML_HOME_METHOD.CHOME_INDEX_POSITIVE;
            Home.HomeOffset = -1000;
            ampArray[Y_AXIS_AMP].HomeSettings = Home;
            ampArray[Y_AXIS_AMP].GoHome();
            ampArray[Y_AXIS_AMP].WaitMoveDone(10000);

            HomeAxisButton.Enabled = true;
            startButton.Enabled = true;
            }
            catch(Exception ex){
            HomeAxisButton.Enabled = true;
            DisplayError(ex);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try{

            ampArray[Y_AXIS_AMP].Disable();
            ampArray[X_AXIS_AMP].Disable();
            }
            catch (Exception ex){
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
