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

        canOpenObj canOpen;

        const int LOG_ALL = 99;
        CopleyMotionLibraryObj cmlObj;
        PathPlanningObj pathObj = new PathPlanningObj(); // the path planning object

        LinkageObj linkage; // a linkage object needed to send the path

        AmpObj[] ampArray = new AmpObj[2]; // amp array containing two axes

        const int dimension = 2;
        double[] point = new double[dimension]; // 2 dimensional point in space

        const short xAxisAmp = 0;
        const short yAxisAmp = 1;

        //Create a delegate to close down the application in a thread safe way
        delegate void CloseApp();

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
                ampArray[xAxisAmp].Initialize(canOpen, xAxisCanAddress);
                ampArray[yAxisAmp].Initialize(canOpen, yAxisCanAddress);

                linkage.Initialize(ampArray);

                // Enable the GUI components
                StartButton.Enabled = true;
                MaxVelTextBox.Enabled = true;
                MaxAccelTextBox.Enabled = true;
                MaxDecelTextBox.Enabled = true;
                MaxJerkTextBox.Enabled = true;

                // Read velocity loop settings from the amp, use these as reasonble starting
                // points for the trajectory limits.
                MaxVelTextBox.Text = Convert.ToString((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxVel) / 10);
                MaxAccelTextBox.Text = Convert.ToString((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxAcc) / 10);
                MaxDecelTextBox.Text = Convert.ToString((ampArray[xAxisAmp].VelocityLoopSettings.VelLoopMaxDec) / 10);
                MaxJerkTextBox.Text = Convert.ToString(Convert.ToDouble(MaxAccelTextBox.Text) * 10);

                // arbitrarily initialize the 2 dimensional point at (50000, 50000).
                point[0] = ampArray[yAxisAmp].PositionActual;
                point[1] = ampArray[xAxisAmp].PositionActual;

                // Read velocity loop settings from the amp, use these as reasonble starting
                // points for the trajectory limits.
                StartPosXAxisTextBox.Text = Convert.ToString(point[0]);
                StartPosYAxisTextBox.Text = Convert.ToString(point[1]);
                AddLineXAxisTextBox.Text = Convert.ToString(point[0] + 100000);
                AddLineYAxisTextBox.Text = Convert.ToString(point[1] + 100000);
                RadiusTextBox.Text = Convert.ToString(100000);
                AddArcAngleTextBox.Text = Convert.ToString(180);
                AddPauseTextBox.Text = Convert.ToString(1);

                // use the textfield values to set the trajectory limits of the path.
                pathObj.SetMaxVel(Convert.ToDouble(MaxVelTextBox.Text));
                pathObj.SetMaxAcc(Convert.ToDouble(MaxAccelTextBox.Text));
                pathObj.SetMaxDec(Convert.ToDouble(MaxDecelTextBox.Text));
                pathObj.SetMaxJrk(Convert.ToDouble(MaxJerkTextBox.Text));
            }

            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        // clear X,Y points from graph
        void ClearPoints()
        {
            try
            {
                foreach (var series in Chart.Series)
                {
                    series.Points.Clear();
                }
            }
            catch(Exception ex)
            {
                DisplayError(ex);
            }
        }

        // close the application
        private void PathPlanning_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {            
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

        // set the starting two dimensional position of the path.
        private void SetStartPosButton_Click(object sender, EventArgs e)
        {
            try
            {
                point[0] = Convert.ToDouble(StartPosXAxisTextBox.Text);
                point[1] = Convert.ToDouble(StartPosYAxisTextBox.Text);
                pathObj.SetStartPos(point);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        // add a line to the end of the path.
        private void AddLineButton_Click(object sender, EventArgs e)
        {
            try
            {
                point[0] = Convert.ToDouble(AddLineXAxisTextBox.Text);
                point[1] = Convert.ToDouble(AddLineYAxisTextBox.Text);
                pathObj.AddLine(point);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }
        
        // add an arc to the end of the path.
        private void AddArcButton_Click(object sender, EventArgs e)
        {
            try
            {
                // convert the user's input from degrees to radians
                double arcDegrees = Convert.ToDouble(AddArcAngleTextBox.Text);
                double arcRadians = (arcDegrees * Math.PI) / 180;
                double radius = Convert.ToDouble(RadiusTextBox.Text);
                pathObj.AddArc(radius, arcRadians);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        // add a pause in seconds to the path.
        private void AddPauseButton_Click(object sender, EventArgs e)
        {
            try
            {
                double seconds = Convert.ToDouble(AddPauseTextBox.Text);
                pathObj.Pause(seconds);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void PlayPathButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClearPoints(); // clear the points of the graph

                double[] pos = { 0, 0 };
                double[] vel = { 0, 0 };

                // Now, print out the positions and velocities along the path.
                // We need to reset the path before we start playing it back.
                pathObj.Reset();

                int count = 0;

                bool done = false;
                do
                {
                    done = pathObj.PlayPath(0.01, pos, vel); // get the velocity and position back from trajectory generator

                    Chart.Series[0].Points.AddXY(pos[0], pos[1]);  // graph position data
                    Chart.Series[1].Points.AddXY(count, vel[0]);   // graph axis A velocity data 
                    Chart.Series[2].Points.AddXY(count, vel[1]);   // graph axis B velocity data

                    count = count + 1;

                    //Console.WriteLine("Count: " + Convert.ToString(count) + " Axis A pos: " + Convert.ToString(pos[0]) + " Axis A vel: " + Convert.ToString(vel[0]) +
                    //   " Axis B pos: " + Convert.ToString(pos[1]) + " Axis B vel: " + Convert.ToString(vel[1]));
                } while (!done);
            }
            catch(Exception ex)
            {
                DisplayError(ex);
            }

        }

        private void HaltButton_Click(object sender, EventArgs e)
        {
            try
            {
                linkage.HaltMove();
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                // If the stop button was pressed (halt commanded), clear the
                // halted condition before beginning next move.
                for (int i = 0; i < dimension; i++)
                {
                    ampArray[i].ClearFaults();
                }

                // set trajectory limits using the user input values
                pathObj.SetMaxVel(Convert.ToDouble(MaxVelTextBox.Text));
                pathObj.SetMaxAcc(Convert.ToDouble(MaxAccelTextBox.Text));
                pathObj.SetMaxDec(Convert.ToDouble(MaxDecelTextBox.Text));
                pathObj.SetMaxJrk(Convert.ToDouble(MaxJerkTextBox.Text));

                // start executing the path
                linkage.SendPath(pathObj, true);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }
    }
}
