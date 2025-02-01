//  Example 13 PathPlanning Rev 0
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
        Thread heartMove, circleMove, ampersandMove, stitchingMove, infinityMove;

        canOpenObj canOpen;

        const int LOG_ALL = 99;
        CopleyMotionLibraryObj cmlObj;
       
        // linkage object
        LinkageObj linkage; // a linkage object needed to send the path

        // two dimensional array of amplifier objects
        AmpObj[] ampArray = new AmpObj[2]; // amp array containing two axes

        // create a 2 dimensional point and a scalar for the shapes
        const int dimension = 2;
        double[] point = new double[dimension]; // 2 dimensional point in space

        // special offset applied to the ampersand path
        double ampersandOffsetX = 300000;
        double ampersandOffsetY = 300000;

        // defines the ranges of the x and y axes.
        double xMaxRange = 10000000;
        double yMaxRange = 5000000;

        // used in run forever function
        bool runForever = false;

        // used to indicate if the halt button was clicked.
        bool haltButtonClicked = false;

        // time between PVT points
        int timeBetweenPoints = 4; // 4 milliseconds

        // indices in the amp object array
        const short xAxisAmp = 0;
        const short yAxisAmp = 1;

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
                linkage = new LinkageObj();

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
                linkage.Initialize(ampArray);
                linkage.SetMoveLimits((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxVel * 0.75), 
                    ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxAcc * 0.5, 
                    ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxDec * 0.5, 
                    ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxAcc);

                // Enable the GUI components
                stitchingButton.Enabled = false;
                infinityButton.Enabled = false;
                drawHeartButton.Enabled = false;
                circleButton.Enabled = false;
                ampersandButton.Enabled = false;
                allShapesButton.Enabled = false;
                HaltButton.Enabled = false;

                // let the drive perform wake-and-wiggle phasing
                Thread.Sleep(10000);

                // perform homing routine
                ampArray[xAxisAmp].GoHome();
                ampArray[xAxisAmp].WaitMoveDone(-1);
                ampArray[yAxisAmp].GoHome();
                ampArray[yAxisAmp].WaitMoveDone(-1);

                // Enable the GUI components. Keep halt button disabled.
                stitchingButton.Enabled = true;
                infinityButton.Enabled = true;
                drawHeartButton.Enabled = true;
                circleButton.Enabled = true;
                ampersandButton.Enabled = true;
                allShapesButton.Enabled = true;

                // initialize the 2 dimensional point at (0.0, 0.0).
                point[0] = 0.0;
                point[1] = 0.0;

                // update the time between points to use the trackbar in the GUI
                timeBetweenPoints = timeBetweenPointsTrackBar.Value;
            }

            catch (Exception ex)
            {
                DisplayError(ex);
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
            catch(Exception ex)
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
            catch(Exception ex)
            {
                DisplayError(ex);
            }
        }

        // update the trajectory values in the path planning object with the values in the textfields in the GUI
        public void UpdateTrajectoryValues(ref PathPlanningObj pathObj)
        {
            try
            {
                // set trajectory limits using the user input values
                pathObj.SetMaxVel((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxVel) / 10);
                pathObj.SetMaxAcc((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxAcc) / 100);
                pathObj.SetMaxDec((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxDec) / 100);
                pathObj.SetMaxJrk((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxAcc) / 100);
            }
            catch(Exception ex)
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
                stitchingButton.Enabled = true;
                infinityButton.Enabled = true;
                circleButton.Enabled = true;
                drawHeartButton.Enabled = true;
                ampersandButton.Enabled = true;
                allShapesButton.Enabled = true;

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
                linkage.HaltMove();

                // clear all points from the pvtTrjObj
                pvtObj.ClearPvtData();

                // clear any latched faults.
                ampArray[0].ClearFaults();
                ampArray[1].ClearFaults();                

                // enable the other path buttons
                circleButton.Enabled = true;
                drawHeartButton.Enabled = true;
                ampersandButton.Enabled = true;
                allShapesButton.Enabled = true;
                infinityButton.Enabled = true;
                stitchingButton.Enabled = true;

                //disable the halt button
                HaltButton.Enabled = false;

                // set the run forever global variable to false.
                runForever = false;
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

        // add the path to the heart
        public void constructHeartPath(ref PathPlanningObj heartPath)
        {
            // set starting position of path
            point[0] = xMaxRange/2;
            point[1] = 0;
            heartPath.SetStartPos(point);

            // next destination vector
            double[] destPosition = new double[2];
            destPosition[0] = (5.0/16.0) * xMaxRange;
            destPosition[1] = (3.0/8.0) * yMaxRange;

            // next destination vector 
            heartPath.AddLine(destPosition);

            destPosition[0] = (3.0 / 8.0) * xMaxRange;
            destPosition[1] = yMaxRange / 2.0;

            // the first 180 degree arc
            heartPath.AddArc(destPosition, convertDegreesToRadians(180));

            destPosition[0] = xMaxRange / 2.0;
            destPosition[1] = yMaxRange / 2.0;

            // move down to meet next half
            heartPath.AddLine(destPosition);

            destPosition[0] = (9.0 / 16.0) * xMaxRange;
            destPosition[1] = (5.0 / 8.0) * yMaxRange;

            // begin second half of heart. Move up before beginning next arc segment
            heartPath.AddLine(destPosition);

            destPosition[0] = (5.0 / 8.0) * xMaxRange;
            destPosition[1] = yMaxRange / 2.0;

            // the second 180 degree arc
            heartPath.AddArc(destPosition, convertDegreesToRadians(180));

            // next destination vector equals the starting position vector
            heartPath.AddLine(point);
        }

        // add the path to the circle
        public void constructCirclePath(ref PathPlanningObj circlePath)
        {
            // set starting position of path
            point[0] = xMaxRange / 2.0;
            point[1] = 0;
            circlePath.SetStartPos(point);

            // the second 180 degree arc
            point[1] = yMaxRange / 2.0;
            circlePath.AddArc(point, convertDegreesToRadians(360));
        }

        // add the path to the ampersand
        public void constructAmpersandPath(ref PathPlanningObj ampersandPath)
        {
            // move to the starting position for the path
            point[0] = ((3.0 / 8.0) * xMaxRange) + ampersandOffsetX;
            point[1] = 0.0 + ampersandOffsetY;
            
            // set starting position of path
            ampersandPath.SetStartPos(point);

            // make first line
            double[] nextDestination = new double[2];
            nextDestination[0] = ((1.0/8.0) * xMaxRange) + ampersandOffsetX;
            nextDestination[1] = (yMaxRange/2.0) + ampersandOffsetY;
            ampersandPath.AddLine(nextDestination);

            // the first 270 degree arc
            ampersandPath.AddArc(883883.476, convertDegreesToRadians(270));

            // add line segment
            ampersandPath.AddLine(1767766.953);

            // add second arc: 180 degrees
            ampersandPath.AddArc(883883.476, convertDegreesToRadians(-180));

            // add a line segment
            ampersandPath.AddLine(1767766.953);

            nextDestination[0] = ((5.0 / 16.0) * xMaxRange) + ampersandOffsetX;
            nextDestination[1] = (yMaxRange / 4.0) + ampersandOffsetY;
            ampersandPath.AddLine(nextDestination);

        }

        // add the path to the ampersand
        public void constructInfinityPath(ref PathPlanningObj infinityPath)
        {
            // move to the starting position for the path
            point[0] = xMaxRange / 2.0;
            point[1] = yMaxRange / 2.0;

            // set starting position of path
            infinityPath.SetStartPos(point);

            // make first line
            double[] nextDestination = new double[2];
            nextDestination[0] = (5.0 / 8.0) * xMaxRange;
            nextDestination[1] = (3.0/4.0) * yMaxRange;
            infinityPath.AddLine(nextDestination);

            // center for the arc
            nextDestination[0] = (3.0 / 4.0) * xMaxRange;
            nextDestination[1] = yMaxRange / 2.0;

            // the first 270 degree arc
            infinityPath.AddArc(nextDestination, convertDegreesToRadians(270));

            // add a line segment
            infinityPath.AddLine(3535533.906);

            // add second arc: 180 degrees
            infinityPath.AddArc(1767766.953, convertDegreesToRadians(-270));

            // return to the starting position
            infinityPath.AddLine(1767766.953);

        }

        // add the path to the ampersand
        public void constructStitchingPath(ref PathPlanningObj stitchingPath)
        {
            // move to the starting position for the path
            point[0] = 0.0;
            point[1] = 0.0;

            // set starting position of path
            stitchingPath.SetStartPos(point);

            // make first line
            double[] nextDestination = new double[2];
            nextDestination[0] = (7.0 / 8.0) * xMaxRange;
            nextDestination[1] = 0.0;
            stitchingPath.AddLine(nextDestination);

            // the first 180 degree arc
            stitchingPath.AddArc(yMaxRange/8.0, convertDegreesToRadians(-180));

            // add line
            stitchingPath.AddLine(xMaxRange * (3.0 / 4.0));

            // the second 180 degree arc
            stitchingPath.AddArc(yMaxRange / 8.0, convertDegreesToRadians(180));

            // add line
            stitchingPath.AddLine(xMaxRange * (3.0 / 4.0));

            // the third 180 degree arc
            stitchingPath.AddArc(yMaxRange / 8.0, convertDegreesToRadians(-180));

            // add line
            stitchingPath.AddLine(xMaxRange * (3.0 / 4.0));

            // the fourth 180 degree arc
            stitchingPath.AddArc(yMaxRange / 8.0, convertDegreesToRadians(180));

            // add line
            stitchingPath.AddLine(xMaxRange * (3.0 / 4.0));

            // the first 90 degree arc
            stitchingPath.AddArc(yMaxRange / 8.0, convertDegreesToRadians(90));

            // add line
            stitchingPath.AddLine(yMaxRange * (3.0 / 4.0));

            // the first 180 degree arc
            stitchingPath.AddArc(yMaxRange / 8.0, convertDegreesToRadians(180));

            // add line
            stitchingPath.AddLine(yMaxRange * (3.0 / 4.0));

            // the second 180 degree arc
            stitchingPath.AddArc(yMaxRange / 8.0, convertDegreesToRadians(-180));

            // add line
            stitchingPath.AddLine(yMaxRange * (3.0 / 4.0));

            // the third 180 degree arc
            stitchingPath.AddArc(yMaxRange / 8.0, convertDegreesToRadians(180));

            // add line
            stitchingPath.AddLine(yMaxRange * (3.0 / 4.0));

            // the fourth 180 degree arc
            stitchingPath.AddArc(yMaxRange / 8.0, convertDegreesToRadians(-180));

            // add line
            stitchingPath.AddLine(yMaxRange * (3.0 / 4.0));

            // the fifth 180 degree arc
            stitchingPath.AddArc(yMaxRange / 8.0, convertDegreesToRadians(180));

            // add line
            stitchingPath.AddLine(yMaxRange * (3.0 / 4.0));

            // the sixth 180 degree arc
            stitchingPath.AddArc(yMaxRange / 8.0, convertDegreesToRadians(-180));

            // add line
            stitchingPath.AddLine(yMaxRange * (3.0 / 4.0));

            // the seventh 180 degree arc
            stitchingPath.AddArc(yMaxRange / 8.0, convertDegreesToRadians(180));

            // add line
            stitchingPath.AddLine(yMaxRange * (3.0 / 4.0));

        }

        // fill the empty pvt trajectory with constant velocity values.
        private void findConstAccelTrj(ref PathPlanningObj pathObj, ref PvtConstAccelTrjObj pvtTraj) {

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
        private void performHeartMove(ref PathPlanningObj heartPath)
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
                point[0] = xMaxRange / 2.0;
                point[1] = 0;

                // move to the starting position
                linkage.MoveTo(point);
                linkage.WaitMoveDone(-1);

                // convert the path to PVT points.
                findConstAccelTrj(ref heartPath, ref pvtObj);

                // update the chart in the GUI with the PVT data.
                PlayPath(ref pvtObj);

                // start executing the PVT trajectory
                linkage.SendPvtConstAccelTrj(pvtObj, true);

                // wait for the move to finish
                linkage.WaitMoveDone(-1);

                // enable the path buttons
                EnablePathButtons();

                // click the next button if the all shapes button was pressed
                if (runForever)
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        circleButton.PerformClick();
                    });
                }
            }
            catch (Exception ex)
            {
                // display the error
                // DisplayError(ex);
                
                // if the halt button was not clicked, then attempt to perform the move again.
                if(haltButtonClicked == false)
                {
                    // enable the button and click it again.
                    this.BeginInvoke((Action)delegate ()
                    {
                        drawHeartButton.Enabled = true;
                        drawHeartButton.PerformClick();
                    });
                }
            }
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
                point[0] = xMaxRange / 2.0;
                point[1] = 0.0;

                // move to the starting position
                linkage.MoveTo(point);
                linkage.WaitMoveDone(-1);

                // find the constant velocity PVT values.
                findConstAccelTrj(ref circlePath, ref pvtObj);

                // update the chart in the GUI with the PVT data.
                PlayPath(ref pvtObj);

                // start executing the PVT trajectory
                linkage.SendPvtConstAccelTrj(pvtObj, true);

                // wait for the move to finish
                linkage.WaitMoveDone(-1);

                // Enable the path buttons
                EnablePathButtons();

                // click the next button if the all shapes button was pressed
                if (runForever)
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        ampersandButton.PerformClick();
                    });
                }
            }
            catch (Exception ex)
            {
                // display the error
                //DisplayError(ex);

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

        // perform the move. start the play path thread to update GUI.
        private void performAmpersandMove(ref PathPlanningObj ampersandPath)
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

                // move to the starting position for the path
                point[0] = ((3.0 / 8.0) * xMaxRange) + ampersandOffsetX;
                point[1] = 0.0 + ampersandOffsetY;
                linkage.MoveTo(point);
                linkage.WaitMoveDone(-1);

                // fill the trajectory with PVT points.
                findConstAccelTrj(ref ampersandPath, ref pvtObj);

                // update the chart in the GUI with the PVT data.
                PlayPath(ref pvtObj);

                // start executing the PVT trajectory
                linkage.SendPvtConstAccelTrj(pvtObj, true);

                // wait for the move to finish
                linkage.WaitMoveDone(-1);

                // enable the path buttons
                EnablePathButtons();

                // click the next button if the all shapes button was pressed
                if (runForever)
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        infinityButton.PerformClick();
                    });
                }
            }
            catch (Exception ex)
            {
                // display the error
                // DisplayError(ex);

                // if the halt button was not clicked, then attempt to perform the move again.
                if (haltButtonClicked == false)
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        ampersandButton.Enabled = true;
                        ampersandButton.PerformClick();
                    });
                }
            }
        }

        // perform the move. start the play path thread to update GUI.
        private void performInfinityMove(ref PathPlanningObj infinityPath)
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

                // move to the starting position for the path
                point[0] = xMaxRange / 2.0;
                point[1] = yMaxRange / 2.0;
                linkage.MoveTo(point);
                linkage.WaitMoveDone(-1);

                // fill the trajectory with PVT points.
                findConstAccelTrj(ref infinityPath, ref pvtObj);

                // update the chart in the GUI with the PVT data.
                PlayPath(ref pvtObj);

                // start executing the PVT trajectory
                linkage.SendPvtConstAccelTrj(pvtObj, true);

                // wait for the move to finish
                linkage.WaitMoveDone(-1);

                // enable the path buttons
                EnablePathButtons();

                // click the next button if the all shapes button was pressed
                if (runForever)
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        stitchingButton.PerformClick();
                    });
                }
            }
            catch (Exception ex)
            {
                // display the error
                // DisplayError(ex);

                // if the halt button was not clicked, then attempt to perform the move again.
                if (haltButtonClicked == false)
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        infinityButton.Enabled = true;
                        infinityButton.PerformClick();
                    });
                }
            }
        }

        // perform the move. start the play path thread to update GUI.
        private void performStitchingMove(ref PathPlanningObj stitchingPath)
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

                // move to the starting position for the path
                point[0] = 0.0;
                point[1] = 0.0;
                linkage.MoveTo(point);
                linkage.WaitMoveDone(-1);

                // fill the trajectory with PVT points.
                findConstAccelTrj(ref stitchingPath, ref pvtObj);

                // update the chart in the GUI with the PVT data.
                PlayPath(ref pvtObj);

                // start executing the PVT trajectory
                linkage.SendPvtConstAccelTrj(pvtObj, true);

                // wait for the move to finish
                linkage.WaitMoveDone(-1);

                // enable the path buttons
                EnablePathButtons();

                // click the next button if the all shapes button was pressed
                if (runForever)
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        drawHeartButton.PerformClick();
                    });
                }
            }
            catch (Exception ex)
            {
                // display the error
                // DisplayError(ex);

                // if the halt button was not clicked, then attempt to perform the move again.
                if (haltButtonClicked == false)
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        stitchingButton.Enabled = true;
                        stitchingButton.PerformClick();
                    });
                }
            }
        }

        // user pressed the stitching button. Begin the event.
        private void stitchingButton_Click(object sender, EventArgs e)
        {
            try
            {
                // clear the PVT data
                pvtObj.ClearPvtData();

                // update the time between points to use the trackbar in the GUI
                timeBetweenPoints = timeBetweenPointsTrackBar.Value;

                // disable the other path buttons
                stitchingButton.Enabled = false;
                circleButton.Enabled = false;
                infinityButton.Enabled = false;
                drawHeartButton.Enabled = false;
                ampersandButton.Enabled = false;
                allShapesButton.Enabled = false;

                // enable the halt button
                HaltButton.Enabled = true;

                // create a new instance of the path planning class
                PathPlanningObj stitchingPath = new PathPlanningObj();

                // update the trajectory values of the path
                UpdateTrajectoryValues(ref stitchingPath);

                // construct the path
                constructStitchingPath(ref stitchingPath);

                // start the ampersand move thread (timer)
                stitchingMove = new Thread(() => performStitchingMove(ref stitchingPath));
                stitchingMove.IsBackground = true;
                stitchingMove.Name = "StitchingMoveThread";
                stitchingMove.Start();
            }
            catch (Exception ex)
            {
                // display the error
                // DisplayError(ex);

                // attempt to perform the shape again.
                // stitchingButton.PerformClick();
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
                drawHeartButton.Enabled = false;
                ampersandButton.Enabled = false;
                allShapesButton.Enabled = false;
                infinityButton.Enabled = false;
                stitchingButton.Enabled = false;

                // enable the halt button
                HaltButton.Enabled = true;

                // create a new instance of the path planning class
                PathPlanningObj circlePath = new PathPlanningObj();

                // update the trajectory values of the path
                UpdateTrajectoryValues(ref circlePath);

                // construct the path
                constructCirclePath(ref circlePath);

                // start the circle move thread (timer)
                circleMove = new Thread(() => performCircleMove(ref circlePath));
                circleMove.IsBackground = true;
                circleMove.Name = "CircleMoveThread";
                circleMove.Start();
            }
            catch(Exception ex)
            {
                // display the error
                // DisplayError(ex);

                // attempt to perform the shape again.
                // circleButton.PerformClick();
            }
        }

        // user pressed the heart button. Begin the event.
        private void drawHeartButton_Click(object sender, EventArgs e)
        {
            try
            {
                // clear the PVT data
                pvtObj.ClearPvtData();

                // update the time between points to use the trackbar in the GUI
                timeBetweenPoints = timeBetweenPointsTrackBar.Value;

                // disable the other path buttons
                circleButton.Enabled = false;
                drawHeartButton.Enabled = false;
                ampersandButton.Enabled = false;
                allShapesButton.Enabled = false;
                infinityButton.Enabled = false;
                stitchingButton.Enabled = false;

                // enable the halt button
                HaltButton.Enabled = true;

                // create a new instance of the path planning class
                PathPlanningObj heartPath = new PathPlanningObj();

                // update the trajectory values of the path
                UpdateTrajectoryValues(ref heartPath);

                // construct the path
                constructHeartPath(ref heartPath);

                // start the heart move thread (timer)
                heartMove = new Thread(() => performHeartMove(ref heartPath));
                heartMove.IsBackground = true;
                heartMove.Name = "HeartMoveThread";
                heartMove.Start();
            }
            catch (Exception ex)
            {
                // display the error
                // DisplayError(ex);

                // attempt to perform the shape again.
                // drawHeartButton.PerformClick();
            }
        }

        // user pressed the ampersand button. Begin the event.
        private void ampersandButton_Click(object sender, EventArgs e)
        {
            try
            {
                // clear the PVT data
                pvtObj.ClearPvtData();

                // update the time between points to use the trackbar in the GUI
                timeBetweenPoints = timeBetweenPointsTrackBar.Value;

                // disable the other path buttons
                circleButton.Enabled = false;
                drawHeartButton.Enabled = false;
                ampersandButton.Enabled = false;
                allShapesButton.Enabled = false;
                infinityButton.Enabled = false;
                stitchingButton.Enabled = false;

                // enable the halt button
                HaltButton.Enabled = true;

                // create a new instance of the path planning class
                PathPlanningObj ampersandPath = new PathPlanningObj();

                // update the trajectory values of the path
                UpdateTrajectoryValues(ref ampersandPath);

                // construct the path
                constructAmpersandPath(ref ampersandPath);

                // start the ampersand move thread (timer)
                ampersandMove = new Thread(() => performAmpersandMove(ref ampersandPath));
                ampersandMove.IsBackground = true;
                ampersandMove.Name = "AmpersandMoveThread";
                ampersandMove.Start();
            }
            catch(Exception ex)
            {
                // display the error
                // DisplayError(ex);

                // attempt to perform the shape again.
                // ampersandButton.PerformClick();
            }
        }

        // user pressed the infinity button. Begin the event.
        private void infinityButton_Click(object sender, EventArgs e)
        {
            try
            {
                // clear the PVT data
                pvtObj.ClearPvtData();

                // update the time between points to use the trackbar in the GUI
                timeBetweenPoints = timeBetweenPointsTrackBar.Value;

                // disable the other path buttons
                circleButton.Enabled = false;
                infinityButton.Enabled = false;
                drawHeartButton.Enabled = false;
                ampersandButton.Enabled = false;
                allShapesButton.Enabled = false;
                stitchingButton.Enabled = false;

                // enable the halt button
                HaltButton.Enabled = true;

                // create a new instance of the path planning class
                PathPlanningObj infinityPath = new PathPlanningObj();

                // update the trajectory values of the path
                UpdateTrajectoryValues(ref infinityPath);

                // construct the path
                constructInfinityPath(ref infinityPath);

                // start the ampersand move thread (timer)
                infinityMove = new Thread(() => performInfinityMove(ref infinityPath));
                infinityMove.IsBackground = true;
                infinityMove.Name = "InfinityMoveThread";
                infinityMove.Start();
            }
            catch (Exception ex)
            {
                // display the error
                // DisplayError(ex);

                // attempt to perform the shape again.
                // infinityButton.PerformClick();
            }
        }
        
        // user pressed the infinite loop button. 
        private void allShapesButton_Click(object sender, EventArgs e)
        {
            try
            {
                // set the run forever global boolean variable to true.
                runForever = true;

                // draw the heart first.
                drawHeartButton.PerformClick();
            }
            catch(Exception ex)
            {
                // display the error
                // DisplayError(ex);
            }
        }
    }
}
