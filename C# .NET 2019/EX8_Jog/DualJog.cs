//
// Example 8 Dual Jogging Rev 2
//
// This program demonstrates how to perform single axis jogging moves as well as dual axis linkage jogging moves.
//
// This program assumes the following axis configuration:
// 1. Upon startup it will enable axis at Can Node ID 1 and 2.
//
// This code also includes the following prerequisites:
// 1. The amplifier and motor must be preconfigured and set up properly to run.
// 2. The hardware enable switch must be installed and easily accessible
// 
// As with any motion product extreme caution must be used! Read and understand
// all parameter settings before attemping to send to amplifier.
// 
// Copley Motion Objects are Copyright, 2006-2021, Copley Controls.
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

namespace EX8_DualJog
{
    public partial class DualJog : Form
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
        LinkageObj Link;
        LinkageSettingsObj linkageSettings;

        AmpObj[] ampArray = new AmpObj[2];

        const short X_AXIS_AMP = 0;
        const short Y_AXIS_AMP = 1;

        double Negative_Position_Limit_X_Axis = 0; //input position limits
        double Negative_Position_Limit_Y_Axis = 0; //units are in counts
        double Positive_Position_Limit_X_Axis = 10000000; // 10 million counts
        double Positive_Position_Limit_Y_Axis = 10000000; // 
        double Percentage_Limit = 0.003; // 0.3 percent

        double Percentage_X, Percentage_Y;
        double ActPos1, ActPos2, Delta_Pos;

        HomeSettingsObj Home;
        ProfileSettingsObj ProfileParameters_X;
        ProfileSettingsObj ProfileParameters_Y;

        // Create a delegate to close down the application in a thread safe way
        delegate void CloseApp();

        public DualJog()
        {
            InitializeComponent();
        }

        private void DualJog_Load(object sender, EventArgs e)
        {
            try
            {
                //**************************************************************************
                //* Turn on logging by setting a CML object
                //**************************************************************************
                cmlObj = new CopleyMotionLibraryObj();
                cmlObj.DebugLevel = LOG_ALL;

                //Initialize code here     
                ampArray[X_AXIS_AMP] = new AmpObj();
                ampArray[Y_AXIS_AMP] = new AmpObj();
                Link = new LinkageObj();
                ProfileParameters_X = new ProfileSettingsObj();
                ProfileParameters_Y = new ProfileSettingsObj();

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

                Link.Initialize(ampArray);

                //***************************************************
                //* An alternate way of initializing the Linkage object is to set up the 
                //* LinkageSettingsObj then pass it into the InitializeExt method of the LinkageObj. 
                //* To use it, first comment out the call to the LinkageObj's Initialize method 
                //* above, then uncomment the following three lines of code.
                //**************************************************************************
                //// Create an instance of the AmpSettings object by calling the constructor 
                //// (all of the properties will be initialized to their default values).
                //linkageSettings = new LinkageSettingsObj();
                //// Change a property
                //linkageSettings.moveAckTimeout = 400;
                //// Initialize the AmpObj with the settings object
                //Link.InitializeExt(ampArray, linkageSettings);

                // Read velocity loop settings from the amp, use these as reasonable starting
                // points for the trajectory limits.
                VelocityTextBox1.Text = Convert.ToString((ampArray[X_AXIS_AMP].VelocityLoopSettings.VelLoopMaxVel) / 10);
                AccelTextBox1.Text = Convert.ToString((ampArray[X_AXIS_AMP].VelocityLoopSettings.VelLoopMaxAcc) / 10);
                DecelTextBox1.Text = Convert.ToString((ampArray[X_AXIS_AMP].VelocityLoopSettings.VelLoopMaxDec) / 10);

                VelocityTextBox2.Text = Convert.ToString((ampArray[Y_AXIS_AMP].VelocityLoopSettings.VelLoopMaxVel) / 10);
                AccelTextBox2.Text = Convert.ToString((ampArray[Y_AXIS_AMP].VelocityLoopSettings.VelLoopMaxAcc) / 10);
                DecelTextBox2.Text = Convert.ToString((ampArray[Y_AXIS_AMP].VelocityLoopSettings.VelLoopMaxDec) / 10);

                VelocityTextBox12.Text = Convert.ToString((ampArray[Y_AXIS_AMP].VelocityLoopSettings.VelLoopMaxVel) / 10);
                AccelTextBox12.Text = Convert.ToString((ampArray[Y_AXIS_AMP].VelocityLoopSettings.VelLoopMaxAcc) / 10);
                DecelTextBox12.Text = Convert.ToString((ampArray[Y_AXIS_AMP].VelocityLoopSettings.VelLoopMaxDec) / 10);

                //Selects profile type
                ProfileParameters_X.ProfileType = CML_PROFILE_TYPE.PROFILE_VELOCITY;
                ProfileParameters_Y.ProfileType = CML_PROFILE_TYPE.PROFILE_VELOCITY;

                JogPosButton1.Enabled = false;
                JogNegButton1.Enabled = false;

                JogPosButton2.Enabled = false;
                JogNegButton2.Enabled = false;

                JogPosButton12.Enabled = false;
                JogNegButton12.Enabled = false;

                Timer1.Start();
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }

        // Home Axis 1 Button
        // All buttons associated with the homing of a particular axis have to be disabled before the homing 
        // routine and then re-enabled after the routine is finished.
        // As you are turning off the buttons associated with the axis being homed, if it is a dual axis button
        // in a single axis home, then you can not re-enable the button after the homing routine unless you use 
        // an "if" statement to handle both cases of whether this button was initially enabled (true) or disabled
        // (false). If you already homed via the Dual Axis Home Button, then the Dual Axis Jog Buttons shall stay 
        // enabled. If (JogNegButton12 == true) then go to a function that disables the buttons, homes the axis, 
        // and re-enables the dual axis jog buttons. If (JogNegButton12 == false) then go to a function that 
        // disables the buttons, homes the axis, but does not re-enable the dual axis jog buttons.
        private void HomeButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (JogPosButton12.Enabled == false)
                {
                    HomeButton1.Enabled = false;
                    JogNegButton1.Enabled = false;
                    JogPosButton1.Enabled = false;
                    HomeButton12.Enabled = false;

                    Home_X_Axis();

                    JogPosButton1.Enabled = true;
                    JogNegButton1.Enabled = true;
                    HomeButton1.Enabled = true;
                    HomeButton12.Enabled = true;
                }
                if (JogPosButton12.Enabled == true)
                {
                    HomeButton1.Enabled = false;
                    JogNegButton1.Enabled = false;
                    JogPosButton1.Enabled = false;

                    HomeButton12.Enabled = false;
                    JogNegButton12.Enabled = false;
                    JogPosButton12.Enabled = false;

                    Home_X_Axis();

                    JogPosButton1.Enabled = true;
                    JogNegButton1.Enabled = true;
                    HomeButton1.Enabled = true;

                    JogNegButton12.Enabled = true;
                    JogPosButton12.Enabled = true;
                    HomeButton12.Enabled = true;
                }
                Check();
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                HomeButton1.Enabled = true;
                DisplayError(ex);
            }
        }

        private void HomeButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (JogNegButton12.Enabled == false)
                {
                    HomeButton2.Enabled = false;
                    JogNegButton2.Enabled = false;
                    JogPosButton2.Enabled = false;
                    HomeButton12.Enabled = false;

                    Home_Y_Axis();

                    JogPosButton2.Enabled = true;
                    JogNegButton2.Enabled = true;
                    HomeButton2.Enabled = true;
                    HomeButton12.Enabled = true;
                }
                if (JogNegButton12.Enabled == true)
                {
                    HomeButton2.Enabled = false;
                    JogPosButton2.Enabled = false;
                    JogNegButton2.Enabled = false;

                    HomeButton12.Enabled = false;
                    JogNegButton12.Enabled = false;
                    JogPosButton12.Enabled = false;

                    Home_Y_Axis();

                    JogPosButton2.Enabled = true;
                    JogNegButton2.Enabled = true;
                    HomeButton2.Enabled = true;

                    HomeButton12.Enabled = true;
                    JogNegButton12.Enabled = true;
                    JogPosButton12.Enabled = true;
                }
                Check();
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                HomeButton2.Enabled = true;
                DisplayError(ex);
            }
        }

        private void HomeButton12_Click(object sender, EventArgs e)
        {
            try
            {
                HomeButton1.Enabled = false;
                HomeButton2.Enabled = false;
                HomeButton12.Enabled = false;

                JogNegButton1.Enabled = false;
                JogPosButton1.Enabled = false;

                JogNegButton2.Enabled = false;
                JogPosButton2.Enabled = false;

                JogNegButton12.Enabled = false;
                JogPosButton12.Enabled = false;

                Home_X_Axis();
                Home_Y_Axis();

                HomeButton12.Enabled = true;
                JogPosButton12.Enabled = true;
                JogNegButton12.Enabled = true;

                HomeButton1.Enabled = true;
                JogPosButton1.Enabled = true;
                JogNegButton1.Enabled = true;

                HomeButton2.Enabled = true;
                JogPosButton2.Enabled = true;
                JogNegButton2.Enabled = true;
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                HomeButton12.Enabled = true;
                DisplayError(ex);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //Reads actual velocity information from the amplifier
                ActVelVar_1.Text = Convert.ToString(ampArray[X_AXIS_AMP].VelocityActual);
                ActVelVar_2.Text = Convert.ToString(ampArray[Y_AXIS_AMP].VelocityActual);

                //Reads actual position information from the amplifier
                ActPosVar_1.Text = Convert.ToString(ampArray[X_AXIS_AMP].PositionActual);
                ActPosVar_2.Text = Convert.ToString(ampArray[Y_AXIS_AMP].PositionActual);

                ActPos1 = Convert.ToDouble(ActPosVar_1.Text);
                ActPos2 = Convert.ToDouble(ActPosVar_2.Text);

                Delta_Pos = (Convert.ToDouble(ActPosVar_1.Text)) - (Convert.ToDouble(ActPosVar_2.Text)); // Delta_Pos = (x - y)
                DeltaPos.Text = Convert.ToString(Delta_Pos); // display Delta_Pos

                Percentage_X = ((ActPos1 - Negative_Position_Limit_X_Axis) / (Positive_Position_Limit_X_Axis - Negative_Position_Limit_X_Axis));
                Percentage_Y = ((ActPos2 - Negative_Position_Limit_Y_Axis) / (Positive_Position_Limit_Y_Axis - Negative_Position_Limit_Y_Axis));

                ProgressBar1.Value = (Convert.ToInt32(Percentage_X * 100));
                ProgressBar2.Value = (Convert.ToInt32(Percentage_Y * 100));

                PercentDisplay1.Text = (Convert.ToString(Math.Round((Percentage_X * 100), 2))); // Display the percentage. Round to 2 decimal places (one hundredth).
                PercentDisplay2.Text = (Convert.ToString(Math.Round((Percentage_Y * 100), 2)));
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }
        private void JogNegButton1_Click(object sender, EventArgs e)
        {

        }

        private void DualJog_FormClosing(object sender, FormClosedEventArgs e)
        {
            try
            {
                ampArray[X_AXIS_AMP].Disable();
                ampArray[Y_AXIS_AMP].Disable();
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
        private void JogPosButton_MouseDown1(object sender, MouseEventArgs e)
        {
            try
            {
                //Sets velocity, acceleration, deceleration limits for move to inputed values
                ProfileParameters_X.ProfileAccel = Convert.ToDouble(AccelTextBox1.Text);
                ProfileParameters_X.ProfileDecel = Convert.ToDouble(DecelTextBox1.Text);
                ProfileParameters_X.ProfileVel = Convert.ToDouble(VelocityTextBox1.Text);

                //Store input parameters as the profile settings
                ampArray[X_AXIS_AMP].ProfileSettings = ProfileParameters_X;

                //Performs positive move. 1 indicates positive move, -1 indicates negative move
                ampArray[X_AXIS_AMP].MoveAbs(1);
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }
        private void JogPosButton_MouseUp1(object sender, MouseEventArgs e)
        {
            try
            {
                //Sets profile velocity to zero
                ProfileParameters_X.ProfileVel = 0;

                //Store inputed parameters as the profile settings
                ampArray[X_AXIS_AMP].ProfileSettings = ProfileParameters_X;

                //Performs move
                ampArray[X_AXIS_AMP].MoveAbs(1); //sends SDO to update the velocity above in the positive direction. Does not represent position.
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }
        private void JogNegButton_MouseDown1(object sender, MouseEventArgs e)
        {
            try
            {
                //Sets velocity, acceleration, deceleration limits for move to inputed values
                ProfileParameters_X.ProfileAccel = Convert.ToDouble(AccelTextBox1.Text);
                ProfileParameters_X.ProfileDecel = Convert.ToDouble(DecelTextBox1.Text);
                ProfileParameters_X.ProfileVel = Convert.ToDouble(VelocityTextBox1.Text);

                //Store inputed parameters as the profile settings
                ampArray[X_AXIS_AMP].ProfileSettings = ProfileParameters_X;

                //Performs negative move
                ampArray[X_AXIS_AMP].MoveAbs(-1);
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }
        private void JogNegButton_MouseUp1(object sender, MouseEventArgs e)
        {
            try
            {
                //Sets profile velocity to zero
                ProfileParameters_X.ProfileVel = 0;

                //Store inputed parameters as the profile settings
                ampArray[X_AXIS_AMP].ProfileSettings = ProfileParameters_X;

                //Performs move
                ampArray[X_AXIS_AMP].MoveAbs(1); //sends SDO to update the velocity above in the positive direction. Does not represent position.
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }
        private void JogPosButton_MouseDown2(object sender, MouseEventArgs e)
        {
            try
            {
                //Sets velocity, acceleration, deceleration limits for move to inputed values
                ProfileParameters_Y.ProfileAccel = Convert.ToDouble(AccelTextBox2.Text);
                ProfileParameters_Y.ProfileDecel = Convert.ToDouble(DecelTextBox2.Text);
                ProfileParameters_Y.ProfileVel = Convert.ToDouble(VelocityTextBox2.Text);

                //Store inputed parameters as the profile settings
                ampArray[Y_AXIS_AMP].ProfileSettings = ProfileParameters_Y;

                //Performs positive move. 1 indicates positive move, -1 indicates negative move
                ampArray[Y_AXIS_AMP].MoveAbs(1);
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }
        private void JogPosButton_MouseUp2(object sender, MouseEventArgs e)
        {
            try
            {
                //Sets profile velocity to zero
                ProfileParameters_Y.ProfileVel = 0;

                //Store inputed parameters as the profile settings
                ampArray[Y_AXIS_AMP].ProfileSettings = ProfileParameters_Y;

                //Performs move
                ampArray[Y_AXIS_AMP].MoveAbs(1); //sends SDO to update the velocity above in the positive direction. Does not represent position.
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }
        private void JogNegButton_MouseDown2(object sender, MouseEventArgs e)
        {
            try
            {
                //Sets velocity, acceleration, deceleration limits for move to inputed values
                ProfileParameters_Y.ProfileAccel = Convert.ToDouble(AccelTextBox2.Text);
                ProfileParameters_Y.ProfileDecel = Convert.ToDouble(DecelTextBox2.Text);
                ProfileParameters_Y.ProfileVel = Convert.ToDouble(VelocityTextBox2.Text);

                //Store inputed parameters as the profile settings
                ampArray[Y_AXIS_AMP].ProfileSettings = ProfileParameters_Y;

                //Performs negative move
                ampArray[Y_AXIS_AMP].MoveAbs(-1);
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }
        private void JogNegButton_MouseUp2(object sender, MouseEventArgs e)
        {
            try
            {
                //Sets profile velocity to zero
                ProfileParameters_Y.ProfileVel = 0;

                //Store inputed parameters as the profile settings
                ampArray[Y_AXIS_AMP].ProfileSettings = ProfileParameters_Y;

                //Performs move
                ampArray[Y_AXIS_AMP].MoveAbs(1); //sends SDO to update the velocity above in the positive direction. Does not represent position.
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }
        private void JogPosButton_MouseDown12(object sender, MouseEventArgs e)
        {
            try
            {
                double[] positionArray = new double[2]; //Set up array
                if (((Percentage_X - Percentage_Y) <= Percentage_Limit) && ((Percentage_X - Percentage_Y) >= -(Percentage_Limit)))
                {
                    positionArray[0] = Positive_Position_Limit_X_Axis;
                    positionArray[1] = Positive_Position_Limit_Y_Axis; // Moving toward positive position limit for both axis
                }
                if ((Percentage_X > Percentage_Y) && ((Percentage_X - Percentage_Y) > Percentage_Limit))
                {
                    positionArray[0] = Positive_Position_Limit_X_Axis;
                    positionArray[1] = (Positive_Position_Limit_Y_Axis - ((Positive_Position_Limit_Y_Axis - Negative_Position_Limit_Y_Axis) * (Percentage_X - Percentage_Y))); // Adjust positive position limit for y axis
                }
                if ((Percentage_Y > Percentage_X) && ((Percentage_Y - Percentage_X) > Percentage_Limit))
                {
                    positionArray[0] = (Positive_Position_Limit_X_Axis - ((Positive_Position_Limit_X_Axis - Negative_Position_Limit_X_Axis) * (Percentage_Y - Percentage_X))); // Adjust positive position limit for x axis
                    positionArray[1] = Positive_Position_Limit_Y_Axis;
                }

                //Get move values to be used by linkage 
                double velocity = Convert.ToDouble(VelocityTextBox12.Text);
                double accel = Convert.ToDouble(AccelTextBox12.Text);
                double decel = Convert.ToDouble(DecelTextBox12.Text);
                double jerk = accel;

                //Set the Linkage move limits( all values must be non zero)
                Link.SetMoveLimits(velocity, accel, decel, jerk);

                //Do linkage move
                Link.MoveTo(positionArray);
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }
        private void JogPosButton_MouseUp12(object sender, MouseEventArgs e)
        {
            try
            {
                // Use a Halt to stop jogging once finger lifts from button
                ampArray[X_AXIS_AMP].HaltMode = CML_HALT_MODE.HALT_ABRUPT;
                ampArray[Y_AXIS_AMP].HaltMode = CML_HALT_MODE.HALT_ABRUPT;
                Link.HaltMove();
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }
        private void JogNegButton_MouseDown12(object sender, MouseEventArgs e)  // Both axis are moving in negative direction
        {
            try
            {
                double[] positionArray = new double[2];  //Set up array
                if (((Percentage_X - Percentage_Y) <= Percentage_Limit) && ((Percentage_X - Percentage_Y) >= -(Percentage_Limit)))
                {
                    positionArray[0] = Negative_Position_Limit_X_Axis;
                    positionArray[1] = Negative_Position_Limit_Y_Axis; // Moving toward negative position limit for both axis
                }
                if ((Percentage_X > Percentage_Y) && ((Percentage_X - Percentage_Y) > Percentage_Limit))
                {
                    positionArray[0] = (Negative_Position_Limit_X_Axis + ((Positive_Position_Limit_X_Axis - Negative_Position_Limit_X_Axis) * (Percentage_X - Percentage_Y))); // Adjust positive position limit for x axis
                    positionArray[1] = Negative_Position_Limit_Y_Axis;
                }
                if ((Percentage_Y > Percentage_X) && ((Percentage_Y - Percentage_X) > Percentage_Limit))
                {
                    positionArray[0] = Negative_Position_Limit_X_Axis;
                    positionArray[1] = (Negative_Position_Limit_Y_Axis + ((Positive_Position_Limit_Y_Axis - Negative_Position_Limit_Y_Axis) * (Percentage_Y - Percentage_X))); // Adjust positive position limit for x axis
                }

                //Get move values to be used by linkage 
                double velocity = Convert.ToDouble(VelocityTextBox12.Text);
                double accel = Convert.ToDouble(AccelTextBox12.Text);
                double decel = Convert.ToDouble(DecelTextBox12.Text);
                double jerk = accel;

                //Set the Linkage move limits( all values must be non zero)
                Link.SetMoveLimits(velocity, accel, decel, jerk);

                //Do linkage move
                Link.MoveTo(positionArray);
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }
        private void JogNegButton_MouseUp12(object sender, MouseEventArgs e)
        {
            try
            {
                // Use a Halt to stop jogging once finger lifts from button
                ampArray[X_AXIS_AMP].HaltMode = CML_HALT_MODE.HALT_ABRUPT;
                ampArray[Y_AXIS_AMP].HaltMode = CML_HALT_MODE.HALT_ABRUPT;
                Link.HaltMove();
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }

        private void Check()
        {
            try
            {
                if ((JogNegButton1.Enabled == true) && (JogNegButton2.Enabled == true))
                {
                    JogPosButton12.Enabled = true;
                    JogNegButton12.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }

        private void Home_X_Axis()
        {
            try
            {
                //Adjust the HomeOffset value and HomeMethod based on your application.
                ampArray[X_AXIS_AMP].SoftPositionPosLimit = Positive_Position_Limit_X_Axis;
                ampArray[X_AXIS_AMP].SoftPositionNegLimit = Negative_Position_Limit_X_Axis;

                Home = ampArray[X_AXIS_AMP].HomeSettings;
                Home.HomeVelFast = (ampArray[X_AXIS_AMP].VelocityLoopSettings.VelLoopMaxVel) / 10;
                Home.HomeVelSlow = (ampArray[X_AXIS_AMP].VelocityLoopSettings.VelLoopMaxVel) / 15;
                Home.HomeAccel = ampArray[X_AXIS_AMP].VelocityLoopSettings.VelLoopMaxAcc / 10;
                Home.HomeMethod = CML_HOME_METHOD.CHOME_NONE;
                Home.HomeOffset = 223;

                ampArray[X_AXIS_AMP].HomeSettings = Home;
                ampArray[X_AXIS_AMP].GoHome();
                ampArray[X_AXIS_AMP].WaitMoveDone(10000);
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }

        private void Home_Y_Axis()
        {
            try
            {
                // Adjust the HomeOffset value and HomeMethod based on your application.
                ampArray[Y_AXIS_AMP].SoftPositionPosLimit = Positive_Position_Limit_Y_Axis;
                ampArray[Y_AXIS_AMP].SoftPositionNegLimit = Negative_Position_Limit_Y_Axis;

                Home = ampArray[Y_AXIS_AMP].HomeSettings;
                Home.HomeVelFast = (ampArray[Y_AXIS_AMP].VelocityLoopSettings.VelLoopMaxVel) / 10;
                Home.HomeVelSlow = (ampArray[Y_AXIS_AMP].VelocityLoopSettings.VelLoopMaxVel) / 15;
                Home.HomeAccel = ampArray[Y_AXIS_AMP].VelocityLoopSettings.VelLoopMaxAcc / 10;
                Home.HomeMethod = CML_HOME_METHOD.CHOME_NONE;
                Home.HomeOffset = 0;

                ampArray[Y_AXIS_AMP].HomeSettings = Home;
                ampArray[Y_AXIS_AMP].GoHome();
                ampArray[Y_AXIS_AMP].WaitMoveDone(10000);
            }
            catch (Exception ex)
            {
                Timer1.Stop();
                DisplayError(ex);
            }
        }
    }
}
