//  Example 16 Race Track Demo
//
// This program demonstrates how to use path planning in a 
// two axis machine. Path planning allows the user to plan
// a two dimensional path using the path planning object.
// Once created, the object contains the following methods:
//
//    SetStartingPos: set the two dimensional starting
//    position for the path.
//
//    AddLine: add a two dimensional line to the path. The
//    method has two overloads. One takes in a double that 
//    is applied to the current direction of travel. The 
//    other takes a two dimensional array that is used as 
//    the destination (endpoint) of the move.
//
//    AddArc: add an arc to the path. The method has two
//    overloads. One takes a double as the radius and a 
//    double as the angle in radians. The radius is applied
//    in the current direction of motion. The second 
//    overload takes a two dimensional center point of the
//    arc and a double as the angle in radians.
//
//    Pause: add a time delay in second to the path.
//    
//    PlayPath: retrieve the current commanded position
//    and velocity of the path. If the path is reset using
//    the reset method, PlayPath can be used in a while
//    loop to print the entire path.
//
//    There are other methods used to set up the trajectory
//    limits. See CMO manual for details.
//
// The racetrack is created using the Path Planning class. 
// Then the trajectory is extracted from the Path Planning 
// class and loaded into a PvtConstAccelTrjObj for PVT 
// streaming. The time value can be altered to adjust the 
// velocity of the move. 
//
// A high-speed position triggered output is configured and
// pulses based on the two-dimensional distance traveled 
// along the path of the racetrack. 
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
// Copley Motion Objects are Copyright, 2002-2021, Copley Controls.
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMLCOMLib;

namespace EX13_PathPlanning
{
    public partial class PathPlanning : Form
    {
        //***************************************************
        //
        //  CANOpen Network
        //
        //***************************************************
        const int xAxisCanAddress = 1;
        const int yAxisCanAddress = 2;

        // four threads are used. Three for each shape and one to draw them (updates chart in GUI).
        Thread circleMove;

        canOpenObj canOpen;

        const int LOG_ALL = 99;
        CopleyMotionLibraryObj cmlObj;

        // linkage object
        LinkageObj linkageObj; // a linkage object needed to send the path

        // two dimensional array of amplifier objects
        AmpObj[] ampArray = new AmpObj[2]; // amp array containing two axes

        // create a 2 dimensional point and a scalar for the shapes
        const int dimension = 2;
        double[] point = new double[dimension]; // 2 dimensional point in space

        // used to indicate if the halt button was clicked.
        bool haltButtonClicked = false;

        // time between PVT points
        int timeBetweenPoints = 10; // 10 milliseconds

        // indices in the amp object array
        const short xAxisAmp = 0;
        const short yAxisAmp = 1;

        double xLength = 3000000;
        double radius = 1100000;

        //Create a delegate to close down the application in a thread safe way
        delegate void CloseApp();

        // declaring PvtConstAccelTrjObj
        PvtConstAccelTrjObj pvtObj;

        public PathPlanning()
        {
            InitializeComponent();
        }

        private void PathPlanning_Load(object sender, EventArgs e)
        {
            try
            {
                //**************************************************************************
                //* Turn on logging by setting a CML object
                //**************************************************************************
                cmlObj = new CopleyMotionLibraryObj();
                cmlObj.DebugLevel = LOG_ALL;

                ampArray[xAxisAmp] = new AmpObj();
                ampArray[yAxisAmp] = new AmpObj();
                linkageObj = new LinkageObj();

                // allocate the pvtObj on the heap
                pvtObj = new PvtConstAccelTrjObj();

                // initialize the pvtObj with the number of axes
                pvtObj.Init(2);

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

                // initialize the nodes on the CANopen network.
                ampArray[xAxisAmp].Initialize(canOpen, xAxisCanAddress);
                ampArray[yAxisAmp].Initialize(canOpen, yAxisCanAddress);

                // initiailize the linkage trajectory settings.
                linkageObj.Initialize(ampArray);
                linkageObj.SetMoveLimits((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxVel * 0.75),
                    ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxAcc * 0.5,
                    ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxDec * 0.5,
                    ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxAcc);

                // Enable the GUI components
                circleButton.Enabled = false;
                HaltButton.Enabled = false;

                // let the drive perform wake-and-wiggle phasing
                Thread.Sleep(5000);

                // perform homing routine
                ampArray[xAxisAmp].GoHome();
                ampArray[xAxisAmp].WaitMoveDone(-1);
                ampArray[yAxisAmp].GoHome();
                ampArray[yAxisAmp].WaitMoveDone(-1);

                // output compare module
                short outputCompareModule = 0x2160; // ASCII 0x185
                short outputCompareVal0 = 0x2162;   // ASCII 0x187
                short outputCompareInc = 0x2164;    // ASCII 0x189
                short outputPulseWidth = 0x2165;    // ASCII 0x18a
                short outputConfig = 0x2193;        //
                short highSpeedSChannelSubIndex = 8;// ASCII 0x77

                // how many counts is one lap around the race track?
                double distancePerCycle = (Math.PI * 2 * radius) + (2 * xLength);

                short subIndex = 0;
                UInt32 moduleData = 0;
                int hardwarePositionTriggeredConfigValue = 16;

                // fire the output 8 times per lap
                int increment = Convert.ToInt32(distancePerCycle / 8);
                int pulseDuration = 10000000; // 100ms
                int posFirstPulse = Convert.ToInt32(distancePerCycle / 8);

                // set the output config of the S /S high-speed channel to be hardware position triggered
                ampArray[0].SDO_Dnld(outputConfig, highSpeedSChannelSubIndex, hardwarePositionTriggeredConfigValue);
                
                // disable the hardware position triggered compare module
                ampArray[0].SDO_Dnld(outputCompareModule, subIndex, moduleData);
                
                // set the position increment value
                ampArray[0].SDO_Dnld(outputCompareInc, subIndex, increment);
                
                // set the output pulse width to 100ms
                ampArray[0].SDO_Dnld(outputPulseWidth, subIndex, pulseDuration);
                
                // set the XY distance to fire the first pulse
                ampArray[0].SDO_Dnld(outputCompareVal0, subIndex, posFirstPulse);
                
                // bit 0 set = Enable Module
                // bit 1 set = Invert active state of output
                // Mode of Compare Module: Bits 3-4 equal a value of 1 = Single Direction Compare Mode
                // Encoder Selection: Bits 16-18 equal a value of 4 = Use XY distance on multi-axis drive
                // Axis X Selection: Bits 28-29 equal a value of 0 = Axis A
                // Axis Y Selection: Bits 24-25 equal a value of 1 = Axis B
                moduleData = 0x0104000b;

                // configure and enable the hardware position triggered compare module
                ampArray[0].SDO_Dnld(outputCompareModule, subIndex, moduleData);

                // Enable the GUI components. Keep halt button disabled.
                circleButton.Enabled = true;

                // initialize the 2 dimensional point at (0.0, 0.0).
                point[0] = 0.0;
                point[1] = 0.0;

                // update the time between points to use the trackbar in the GUI
                timeBetweenPoints = timeBetweenPointsTrackBar.Value;
            }

            catch (Exception ex)
            {
                //DisplayError(ex);
            }
        }

        struct Positions
        {
            public double x;
            public double y;
        }

        struct Velocities
        {
            public double x;
            public double y;
        }

        // close the application
        private void PathPlanning_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //if (playPathThread.ThreadState == ThreadState.Running) { playPathThread.Abort(); }
                // disable the drives before closing the application
                for (int i = 0; i < dimension; i++)
                {
                    ampArray[i].Disable();
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        // display the error to the user.
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

        // safely close the thread.
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

        // update the chart in the GUI with the PVT data.
        public void PlayPath(ref PvtConstAccelTrjObj pvtConstAccelTrjObj)
        {
            try
            {
                // empty lists used to store PVT data.
                List<double> xPos = new List<double>();
                List<double> yPos = new List<double>();
                List<double> xVel = new List<double>();
                List<double> yVel = new List<double>();
                List<int> times = new List<int>();

                // emptry arrays for transferring PVT data
                double[] posArr = new double[dimension];
                double[] velArr = new double[dimension];
                int timeVal = 0;

                // retrieve the number of PVT points in the profile.
                int numberOfPvtPoints = pvtConstAccelTrjObj.GetNumberOfPvtPoints();

                // retrieve the PVT data from the PvtConstAccelTrjObj
                for (int i = 0; i < numberOfPvtPoints; i++)
                {
                    pvtConstAccelTrjObj.GetPvtData(posArr, velArr, ref timeVal, i);
                    xPos.Add(posArr[0]);
                    yPos.Add(posArr[1]);
                    xVel.Add(velArr[0]);
                    yVel.Add(velArr[1]);
                    times.Add(timeVal);
                }

                // invoke editing the GUI as this thread is seperate from main thread, which owns GUI.
                this.Chart.BeginInvoke((Action)delegate ()
                {
                    // clear the points on the graph.
                    foreach (var series in Chart.Series)
                    {
                        series.Points.Clear();
                    }

                    // plot each PVT point on the chart in the GUI.
                    for (int i = 0; i < numberOfPvtPoints; i++)
                    {
                        Chart.Series[0].Points.AddXY(xPos[i], yPos[i]); // graph position data
                        Chart.Series[1].Points.AddXY(i, xVel[i]);
                        Chart.Series[2].Points.AddXY(i, yVel[i]);
                    }

                    // update the chart on the GUI.
                    Chart.Update();
                });
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        // update the trajectory values in the path planning object with the values in the textfields in the GUI
        public void UpdateTrajectoryValues(ref PathPlanningObj pathObj, string speed)
        {
            try
            {
                if(speed == "fast")
                {
                    // set trajectory limits using the user input values
                    pathObj.SetMaxVel((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxVel) / 1);
                    pathObj.SetMaxAcc((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxAcc) / 10);
                    pathObj.SetMaxDec((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxDec) / 10);
                    pathObj.SetMaxJrk((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxAcc) / 10);
                }
                else if(speed == "medium")
                {
                    // set trajectory limits using the user input values
                    pathObj.SetMaxVel((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxVel) / 2);
                    pathObj.SetMaxAcc((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxAcc) / 20);
                    pathObj.SetMaxDec((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxDec) / 20);
                    pathObj.SetMaxJrk((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxAcc) / 20);
                }
                else if(speed == "slow")
                {
                    // set trajectory limits using the user input values
                    pathObj.SetMaxVel((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxVel) / 3);
                    pathObj.SetMaxAcc((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxAcc) / 30);
                    pathObj.SetMaxDec((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxDec) / 30);
                    pathObj.SetMaxJrk((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxAcc) / 30);
                }
                else
                {
                    // nothing to do at this time.
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        // enable the path button in the GUI
        public void EnablePathButtons()
        {
            this.BeginInvoke((Action)delegate ()
            {
                // enable the other path buttons
                circleButton.Enabled = true;

                // disable the halt button.
                HaltButton.Enabled = false;
            });
        }

        // halt the linkage move
        private void HaltButton_Click(object sender, EventArgs e)
        {
            try
            {
                // set the boolean halt clicked variable to true.
                haltButtonClicked = true;

                // halt the linkage move
                linkageObj.HaltMove();

                // clear all points from the pvtTrjObj
                pvtObj.ClearPvtData();

                // clear any latched faults.
                ampArray[0].ClearFaults();
                ampArray[1].ClearFaults();

                // enable the other path buttons
                circleButton.Enabled = true;

                //disable the halt button
                HaltButton.Enabled = false;
            }
            catch (Exception ex)
            {
                //DisplayError(ex);
            }
        }

        // function that converts degrees to radians.
        public double convertDegreesToRadians(double inputDegrees)
        {
            return (inputDegrees * (Math.PI / 180));
        }

        // add the path to the circle
        public void constructCirclePath(ref PathPlanningObj circlePath)
        {
            UpdateTrajectoryValues(ref circlePath, "slow");
            constructCircleHelper(ref circlePath);

            UpdateTrajectoryValues(ref circlePath, "medium");
            constructCircleHelper(ref circlePath);

            UpdateTrajectoryValues(ref circlePath, "fast");
            constructCircleHelper(ref circlePath);
        }

        public void constructCircleHelper(ref PathPlanningObj circlePath)
        {
            circlePath.AddLine(xLength);
            circlePath.AddArc(radius, convertDegreesToRadians(-180));
            circlePath.AddLine(xLength);
            circlePath.AddArc(radius, convertDegreesToRadians(-180));
        }

        // fill the empty pvt trajectory with constant velocity values.
        private void findConstAccelTrj(ref PathPlanningObj pathObj, ref PvtConstAccelTrjObj pvtTraj)
        {

            // empty arrays for positions and velocities
            double[] pos = { 0, 0 };
            double[] vel = { 0, 0 };

            // Now, extract the positions along the path.
            // We need to reset the path before we start playing it back.
            pathObj.Reset();

            bool done = false;
            do
            {
                done = pathObj.PlayPath(0.01, pos, vel); // get the velocity and position back from trajectory generator
                pvtTraj.AddPvtPoint(pos, timeBetweenPoints);

            } while (!done);
        }

        // perform the move. Start the play path thread to update GUI.
        private void performCircleMove(ref PathPlanningObj circlePath)
        {
            try
            {
                // reset the halt button boolean variable
                haltButtonClicked = false;

                // If the stop button was pressed (halt commanded), clear the
                // halted condition before beginning next move.
                for (int i = 0; i < dimension; i++)
                {
                    ampArray[i].ClearFaults();
                }

                // set starting position of path
                point[0] = radius + (radius * 0.15);
                point[1] = 100000;

                // set starting position of path
                circlePath.SetStartPos(point);

                // move to the starting position
                linkageObj.MoveTo(point);
                linkageObj.WaitMoveDone(-1);

                // find the constant velocity PVT values.
                findConstAccelTrj(ref circlePath, ref pvtObj);

                // update the chart in the GUI with the PVT data.
                PlayPath(ref pvtObj);

                // start executing the PVT trajectory
                linkageObj.SendPvtConstAccelTrj(pvtObj, true);

                // wait for the move to finish
                linkageObj.WaitMoveDone(-1);

                // Enable the path buttons
                EnablePathButtons();                           
                
                this.BeginInvoke((Action)delegate ()
                {
                    circleButton.PerformClick();
                });     
            }
            catch (Exception ex)
            {

                // display the error
                //DisplayError(ex);

                // clear faults on all axes.
                for(int i = 0; i < dimension; i++)
                {
                    ampArray[i].ClearFaults();
                }

                // move back to starting position
                

                // if the halt button was not clicked, then attempt to perform the move again.
                if (haltButtonClicked == false)
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        circleButton.Enabled = true;
                        circleButton.PerformClick();
                    });
                }
            }
        }

        // user pressed the circle button. Begin the event.
        private void circleButton_Click(object sender, EventArgs e)
        {
            try
            {
                // clear the PVT data
                pvtObj.ClearPvtData();

                // update the time between points to use the trackbar in the GUI
                timeBetweenPoints = timeBetweenPointsTrackBar.Value;

                // disable the other path buttons
                circleButton.Enabled = false;

                // enable the halt button
                HaltButton.Enabled = true;

                // create a new instance of the path planning class
                PathPlanningObj circlePath = new PathPlanningObj();

                // update the trajectory values of the path
                UpdateTrajectoryValues(ref circlePath, "slow");

                // construct the path
                constructCirclePath(ref circlePath);

                // start the circle move thread (timer)
                circleMove = new Thread(() => performCircleMove(ref circlePath));
                circleMove.IsBackground = true;
                circleMove.Name = "CircleMoveThread";
                circleMove.Start();
            }
            catch (Exception ex)
            {
                // display the error
                // DisplayError(ex);

                // attempt to perform the shape again.
                // circleButton.PerformClick();
            }
        }
    }
}
