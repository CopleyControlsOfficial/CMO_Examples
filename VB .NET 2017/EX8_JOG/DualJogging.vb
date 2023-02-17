'
' Example 8 Dual Jogging Rev 1
'
' This program demonstrates how to perform single axis jogging moves as well as dual axis linkage jogging moves.
'
' This program assumes the following axis configuration:
' 1. Upon startup it will enable axis at Can Node 1 and 2
'
' This code also includes the following prerequisites:
' 1. The amplifier and motor must be preconfigured and set up properly to run.
' 2. The hardware enable switch must be installed and easily accessible
'
' As with any motion product extreme caution must be used! Read and understand
' all parameter settings before attempting to send to amplifier.
'
'
' Copley Motion Objects are Copyright, 2006-2018, Copley Controls.
'
' For more information on Copley Motion products see:
' http://www.copleycontrols.com
'

Imports CMLCOMLib

Public Class DualJogging
    Inherits System.Windows.Forms.Form

    '***************************************************
    '*
    '*  CANOpen Network
    '*
    '***************************************************
    Const X_AXIS_CAN_ADDRESS As Integer = 1
    Const Y_AXIS_CAN_ADDRESS As Integer = 2
    Dim canOpen As canOpenObj
    Const LOG_ALL As Integer = 99

    Dim cmlObj As CopleyMotionLibraryObj
    Dim Link As LinkageObj
    Dim linkageSettings As LinkageSettingsObj

    Dim ampArray(1) As AmpObj
    Const X_AXIS_AMP As Short = 0
    Const Y_AXIS_AMP As Short = 1

    Dim Negative_Position_Limit_X_Axis As Double = 0 ' input position limits
    Dim Negative_Position_Limit_Y_Axis As Double = 0 ' units are in counts
    Dim Positive_Position_Limit_X_Axis As Double = 10000000 ' 10 million counts
    Dim Positive_Position_Limit_Y_Axis As Double = 10000000
    Dim Percentage_Limit As Double = 0.003 ' 0.3 percent

    Dim PERCENTAGE_X, PERCENTAGE_Y As Double
    Dim ActPos1, ActPos2, Delta_Pos As Double

    Dim Home As HomeSettingsObj
    Dim ProfileParameters_X As ProfileSettingsObj
    Dim ProfileParameters_Y As ProfileSettingsObj

    'Create a delegate to close down the application in a thread safe way
    Delegate Sub CloseApp()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '**************************************************************************
            '* Turn on logging by setting a CML object
            '**************************************************************************
            cmlObj = New CopleyMotionLibraryObj()
            cmlObj.DebugLevel = LOG_ALL

            'Initialize code here

            ampArray(X_AXIS_AMP) = New AmpObj
            ampArray(Y_AXIS_AMP) = New AmpObj
            Link = New LinkageObj
            ProfileParameters_X = New ProfileSettingsObj()
            ProfileParameters_Y = New ProfileSettingsObj()


            '***************************************************
            '
            '  CANOpen Network
            '
            '***************************************************
            canOpen = New canOpenObj()
            '
            '**************************************************************************
            '* The next two lines of code are optional. If no bit rate is specified,
            '* then the default bit rate (1 Mbit per second) is used.  If no port name
            '* is specified, then CMO will use the first supported CAN card found and
            '* use channel 0 of that card.
            '**************************************************************************
            '''' Set the bit rate to 1 Mbit per second
            canOpen.BitRate = CML_BIT_RATES.BITRATE_1_Mbit_per_sec
            '''' Indicate that channel 0 of a Copley CAN card should be used
            canOpen.PortName = "copley0"
            '***************************************************
            '* Initialize the CAN card and network
            '***************************************************
            canOpen.Initialize()
            '**************************************************************************
            '* Initialize the amplifier
            '**************************************************************************
            ampArray(X_AXIS_AMP).Initialize(canOpen, X_AXIS_CAN_ADDRESS)
            ampArray(Y_AXIS_AMP).Initialize(canOpen, Y_AXIS_CAN_ADDRESS)

            Link.Initialize(ampArray)

            '***************************************************
            '* An alternate way of initializing the Linkage object is to set up the 
            '* LinkageSettingsObj then pass it into the InitializeExt method of the LinkageObj. 
            '* To use it, first comment out the call to the LinkageObj's Initialize method 
            '* above, then uncomment the following three lines of code.
            '**************************************************************************
            '''' Create an instance of the AmpSettings object by calling the constructor 
            '''' (all of the properties will be initialized to their default values).
            ''linkageSettings = New LinkageSettingsObj()
            '''' Change a property
            ''linkageSettings.moveAckTimeout = 400
            '''' Initialize the AmpObj with the settings object
            ''Linkage.InitializeExt(ampArray, linkageSettings)




            ' Read velocity loop settings from the amp, use these as reasonable starting
            ' points for the trajectory limits
            VelocityTextBox1.Text = Convert.ToString((ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 10)
            AccelTextBox1.Text = Convert.ToString((ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxAcc) / 10)
            DecelTextBox1.Text = Convert.ToString((ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxDec) / 10)

            VelocityTextBox2.Text = Convert.ToString((ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 10)
            AccelTextBox2.Text = Convert.ToString((ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxAcc) / 10)
            DecelTextBox2.Text = Convert.ToString((ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxDec) / 10)

            VelocityTextBox12.Text = Convert.ToString((ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 10)
            AccelTextBox12.Text = Convert.ToString((ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxAcc) / 10)
            DecelTextBox12.Text = Convert.ToString((ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxDec) / 10)

            'Selects profile type
            ProfileParameters_X.ProfileType = CML_PROFILE_TYPE.PROFILE_VELOCITY
            ProfileParameters_Y.ProfileType = CML_PROFILE_TYPE.PROFILE_VELOCITY

            JogPosButton1.Enabled = False
            JogNegButton1.Enabled = False

            JogPosButton2.Enabled = False
            JogNegButton2.Enabled = False

            JogPosButton12.Enabled = False
            JogNegButton12.Enabled = False

            Timer1.Start()

        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub Check()
        Try
            If ((JogNegButton1.Enabled = True) And (JogNegButton2.Enabled = True)) Then
                JogPosButton12.Enabled = True
                JogNegButton12.Enabled = True
            End If
        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub Home_X_Axis()
        Try
            ' Adjust the HomeOffset value and HomeMethod based on your application
            ampArray(X_AXIS_AMP).SoftPositionPosLimit = Positive_Position_Limit_X_Axis
            ampArray(X_AXIS_AMP).SoftPositionNegLimit = Negative_Position_Limit_X_Axis

            Home = ampArray(X_AXIS_AMP).HomeSettings
            Home.HomeVelFast = (ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 10
            Home.HomeVelSlow = (ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 15
            Home.HomeAccel = ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxAcc / 10
            Home.HomeMethod = CML_HOME_METHOD.CHOME_NONE
            Home.HomeOffset = 223

            ampArray(X_AXIS_AMP).HomeSettings = Home
            ampArray(X_AXIS_AMP).GoHome()
            ampArray(X_AXIS_AMP).WaitMoveDone(10000)
        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub Home_Y_Axis()
        Try
            ' Adjust the HomeOffset value and HomeMethod based on your application
            ampArray(Y_AXIS_AMP).SoftPositionPosLimit = Positive_Position_Limit_X_Axis
            ampArray(Y_AXIS_AMP).SoftPositionNegLimit = Negative_Position_Limit_X_Axis

            Home = ampArray(Y_AXIS_AMP).HomeSettings
            Home.HomeVelFast = (ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 10
            Home.HomeVelSlow = (ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 15
            Home.HomeAccel = ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxAcc / 10
            Home.HomeMethod = CML_HOME_METHOD.CHOME_NONE
            Home.HomeOffset = 223

            ampArray(Y_AXIS_AMP).HomeSettings = Home
            ampArray(Y_AXIS_AMP).GoHome()
            ampArray(Y_AXIS_AMP).WaitMoveDone(10000)
        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            ' Reads actual velocity information from the amplifier
            ActVelVar_1.Text = Convert.ToString(ampArray(X_AXIS_AMP).VelocityActual)
            ActVelVar_2.Text = Convert.ToString(ampArray(Y_AXIS_AMP).VelocityActual)

            ' Reads actual position information from the amplifier
            ActPosVar_1.Text = Convert.ToString(ampArray(X_AXIS_AMP).PositionActual)
            ActPosVar_2.Text = Convert.ToString(ampArray(Y_AXIS_AMP).PositionActual)

            ActPos1 = Convert.ToDouble(ActPosVar_1.Text)
            ActPos2 = Convert.ToDouble(ActPosVar_2.Text)

            Delta_Pos = ActPos1 - ActPos2 ' Delta_Pos = x - y
            DeltaPos.Text = Convert.ToString(Delta_Pos) ' display Delta_Pos

            PERCENTAGE_X = ((ActPos1 - Negative_Position_Limit_X_Axis) / (Positive_Position_Limit_X_Axis - Negative_Position_Limit_X_Axis))
            PERCENTAGE_Y = ((ActPos2 - Negative_Position_Limit_Y_Axis) / (Positive_Position_Limit_Y_Axis - Negative_Position_Limit_Y_Axis))

            ProgressBar1.Value = (Convert.ToInt32(PERCENTAGE_X * 100))
            ProgressBar2.Value = (Convert.ToInt32(PERCENTAGE_Y * 100))

            PercentDisplay1.Text = (Convert.ToString(Math.Round((PERCENTAGE_X * 100), 2))) ' Display the percentage. Round To 2 Decimal places (one hundredth).
            PercentDisplay2.Text = (Convert.ToString(Math.Round((PERCENTAGE_Y * 100), 2)))
        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub JogPosButton1_MouseDown(sender As Object, e As MouseEventArgs) Handles JogPosButton1.MouseDown
        Try
            ' Sets velocity, acceleration, deceleration limits for move to input values
            ProfileParameters_X.ProfileAccel = Convert.ToDouble(AccelTextBox1.Text)
            ProfileParameters_X.ProfileDecel = Convert.ToDouble(DecelTextBox1.Text)
            ProfileParameters_X.ProfileVel = Convert.ToDouble(VelocityTextBox1.Text)

            ' Store input parameters as the profile settings
            ampArray(X_AXIS_AMP).ProfileSettings = ProfileParameters_X

            ' Performs positive move. 1 indicates positive move, -1 indicates negative move
            ampArray(X_AXIS_AMP).MoveAbs(1)
        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub JogPosButton1_MouseUp(sender As Object, e As MouseEventArgs) Handles JogPosButton1.MouseUp
        Try
            'Sets profile velocity to zero
            ProfileParameters_X.ProfileVel = 0

            ' Store inputed parameters as the profile settings
            ampArray(X_AXIS_AMP).ProfileSettings = ProfileParameters_X

            ' Performs move
            ampArray(X_AXIS_AMP).MoveAbs(1) ' sends SDO to update the velocity above in the positive direction. Does Not represent position.
        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub JogNegButton1_MouseDown(sender As Object, e As MouseEventArgs) Handles JogNegButton1.MouseDown
        Try
            ' Sets velocity, acceleration, deceleration limits for move to inputed values
            ProfileParameters_X.ProfileAccel = Convert.ToDouble(AccelTextBox1.Text)
            ProfileParameters_X.ProfileDecel = Convert.ToDouble(DecelTextBox1.Text)
            ProfileParameters_X.ProfileVel = Convert.ToDouble(VelocityTextBox1.Text)

            ' Store inputed parameters as the profile settings
            ampArray(X_AXIS_AMP).ProfileSettings = ProfileParameters_X

            ' Performs negative move
            ampArray(X_AXIS_AMP).MoveAbs(-1)
        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub JogNegButton1_MouseUp(sender As Object, e As MouseEventArgs) Handles JogNegButton1.MouseUp
        Try
            ' Sets profile velocity to zero
            ProfileParameters_X.ProfileVel = 0

            ' Store inputed parameters as the profile settings
            ampArray(X_AXIS_AMP).ProfileSettings = ProfileParameters_X

            ' Performs move
            ampArray(X_AXIS_AMP).MoveAbs(1) ' sends SDO to update the velocity above in the positive direction. Does Not represent position.
        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub JogPosButton2_MouseDown(sender As Object, e As MouseEventArgs) Handles JogPosButton2.MouseDown
        Try
            ' Sets velocity, acceleration, deceleration limits for move to inputed values
            ProfileParameters_Y.ProfileAccel = Convert.ToDouble(AccelTextBox2.Text)
            ProfileParameters_Y.ProfileDecel = Convert.ToDouble(DecelTextBox2.Text)
            ProfileParameters_Y.ProfileVel = Convert.ToDouble(VelocityTextBox2.Text)

            ' Store inputed parameters as the profile settings
            ampArray(Y_AXIS_AMP).ProfileSettings = ProfileParameters_Y

            ' Performs positive move. 1 indicates positive move, -1 indicates negative move
            ampArray(Y_AXIS_AMP).MoveAbs(1)
        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub JogPosButton2_MouseUp(sender As Object, e As MouseEventArgs) Handles JogPosButton2.MouseUp
        Try
            ' Sets profile velocity to zero
            ProfileParameters_Y.ProfileVel = 0

            ' Store inputed parameters as the profile settings
            ampArray(Y_AXIS_AMP).ProfileSettings = ProfileParameters_Y

            ' Performs move
            ampArray(Y_AXIS_AMP).MoveAbs(1) ' sends SDO to update the velocity above in the positive direction. Does Not represent position.
        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub JogNegButton2_MouseDown(sender As Object, e As MouseEventArgs) Handles JogNegButton2.MouseDown
        Try
            ' Sets velocity, acceleration, deceleration limits for move to inputed values
            ProfileParameters_Y.ProfileAccel = Convert.ToDouble(AccelTextBox2.Text)
            ProfileParameters_Y.ProfileDecel = Convert.ToDouble(DecelTextBox2.Text)
            ProfileParameters_Y.ProfileVel = Convert.ToDouble(VelocityTextBox2.Text)

            ' Store inputed parameters as the profile settings
            ampArray(Y_AXIS_AMP).ProfileSettings = ProfileParameters_Y

            ' Performs negative move
            ampArray(Y_AXIS_AMP).MoveAbs(-1)
        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub JogNegButton2_MouseUp(sender As Object, e As MouseEventArgs) Handles JogNegButton2.MouseUp
        Try
            ' Sets profile velocity to zero
            ProfileParameters_Y.ProfileVel = 0

            ' Store inputed parameters as the profile settings
            ampArray(Y_AXIS_AMP).ProfileSettings = ProfileParameters_Y

            ' Performs move
            ampArray(Y_AXIS_AMP).MoveAbs(1) ' sends SDO to update the velocity above in the positive direction. Does Not represent position.
        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub JogPosButton12_MouseDown(sender As Object, e As MouseEventArgs) Handles JogPosButton12.MouseDown
        Try
            Dim positionArray(1) As Double ' Set up array
            If (((PERCENTAGE_X - PERCENTAGE_Y) <= Percentage_Limit) And ((PERCENTAGE_X - PERCENTAGE_Y) >= -(Percentage_Limit))) Then
                positionArray(0) = Positive_Position_Limit_X_Axis
                positionArray(1) = Positive_Position_Limit_Y_Axis ' Moving toward positive position limit For both axis
            End If
            If ((PERCENTAGE_X > PERCENTAGE_Y) And ((PERCENTAGE_X - PERCENTAGE_Y) > Percentage_Limit)) Then
                positionArray(0) = Positive_Position_Limit_X_Axis
                positionArray(1) = (Positive_Position_Limit_Y_Axis - ((Positive_Position_Limit_Y_Axis - Negative_Position_Limit_Y_Axis) * (PERCENTAGE_X - PERCENTAGE_Y))) ' Adjust positive position limit For y axis
            End If
            If ((PERCENTAGE_Y > PERCENTAGE_X) And ((PERCENTAGE_Y - PERCENTAGE_X) > Percentage_Limit)) Then
                positionArray(0) = (Positive_Position_Limit_X_Axis - ((Positive_Position_Limit_X_Axis - Negative_Position_Limit_X_Axis) * (PERCENTAGE_Y - PERCENTAGE_X))) ' Adjust positive position limit For x axis
                positionArray(1) = Positive_Position_Limit_Y_Axis
            End If

            ' Get move values to be used by linkage 
            Dim velocity As Double = Convert.ToDouble(VelocityTextBox12.Text)
            Dim accel As Double = Convert.ToDouble(AccelTextBox12.Text)
            Dim decel As Double = Convert.ToDouble(DecelTextBox12.Text)
            Dim jerk As Double = accel

            ' Set the Linkage move limits( all values must be non zero)
            Link.SetMoveLimits(velocity, accel, decel, jerk)

            ' Do linkage move
            Link.MoveTo(positionArray)
        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub JogPosButton12_MouseUp(sender As Object, e As MouseEventArgs) Handles JogPosButton12.MouseUp
        Try
            ' Use a Halt to stop jogging once finger lifts from button
            ampArray(X_AXIS_AMP).HaltMode = CML_HALT_MODE.HALT_ABRUPT
            ampArray(Y_AXIS_AMP).HaltMode = CML_HALT_MODE.HALT_ABRUPT
            Link.HaltMove()
        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub JogNegButton12_MouseDown(sender As Object, e As MouseEventArgs) Handles JogNegButton12.MouseDown
        Try
            Dim positionArray(1) As Double ' Set up array
            If (((PERCENTAGE_X - PERCENTAGE_Y) <= Percentage_Limit) And ((PERCENTAGE_X - PERCENTAGE_Y) >= -(Percentage_Limit))) Then
                positionArray(0) = Negative_Position_Limit_X_Axis
                positionArray(1) = Negative_Position_Limit_Y_Axis ' Moving toward negative position limit For both axis
            End If
            If ((PERCENTAGE_X > PERCENTAGE_Y) And ((PERCENTAGE_X - PERCENTAGE_Y) > Percentage_Limit)) Then
                positionArray(0) = (Negative_Position_Limit_X_Axis + ((Positive_Position_Limit_X_Axis - Negative_Position_Limit_X_Axis) * (PERCENTAGE_X - PERCENTAGE_Y))) ' Adjust positive position limit For x axis
                positionArray(1) = Negative_Position_Limit_Y_Axis
            End If
            If ((PERCENTAGE_Y > PERCENTAGE_X) And ((PERCENTAGE_Y - PERCENTAGE_X) > Percentage_Limit)) Then
                positionArray(0) = Negative_Position_Limit_X_Axis
                positionArray(1) = (Negative_Position_Limit_Y_Axis + ((Positive_Position_Limit_Y_Axis - Negative_Position_Limit_Y_Axis) * (PERCENTAGE_Y - PERCENTAGE_X))) ' Adjust positive position limit For x axis
            End If

            ' Get move values to be used by linkage
            Dim velocity As Double = Convert.ToDouble(VelocityTextBox12.Text)
            Dim accel As Double = Convert.ToDouble(AccelTextBox12.Text)
            Dim decel As Double = Convert.ToDouble(DecelTextBox12.Text)
            Dim jerk As Double = accel

            ' Set the Linkage move limits( all values must be non zero)
            Link.SetMoveLimits(velocity, accel, decel, jerk)

            ' Do linkage move
            Link.MoveTo(positionArray)
        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub JogNegButton12_MouseUp(sender As Object, e As MouseEventArgs) Handles JogNegButton12.MouseUp
        Try
            ' Use a Halt to stop jogging once finger lifts from button
            ampArray(X_AXIS_AMP).HaltMode = CML_HALT_MODE.HALT_ABRUPT
            ampArray(Y_AXIS_AMP).HaltMode = CML_HALT_MODE.HALT_ABRUPT
            Link.HaltMove()
        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            ampArray(X_AXIS_AMP).Disable()
            ampArray(Y_AXIS_AMP).Disable()
        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Public Sub DisplayError(ByVal ex As Exception)
        Dim errormsgbox As Short

        errormsgbox = MsgBox("Error Message: " & ex.Message & vbCr & "Error Source: " & ex.Source, MsgBoxStyle.OkCancel)
        If errormsgbox = MsgBoxResult.Cancel Then
            ' it is possible that this method was called from a thread other than the 
            ' GUI thread - if this is the case we must use a delegate to close the application.
            Dim d As New CloseApp(AddressOf ThreadSafeClose)
            Me.Invoke(d)
        End If
    End Sub

    Public Sub ThreadSafeClose()
        ' If the calling thread is different than the GUI thread, then use the
        ' delegate to close the application, otherwise call close() directly
        If Me.InvokeRequired Then
            Dim d As New CloseApp(AddressOf ThreadSafeClose)
            Me.Invoke(d)
        Else
            Close()
        End If
    End Sub

    ' Home Axis 1 Button
    ' All buttons associated with the homing of a particular axis have to be disabled before the homing 
    ' routine And then re-enabled after the routine Is finished.
    ' As you are turning off the buttons associated with the axis being homed, if it Is a dual axis button
    ' in a single axis home, then you can Not re-enable the button after the homing routine unless you use 
    ' an "if" statement to handle both cases of whether this button was initially enabled (true) Or disabled
    ' (false). If you already homed via the Dual Axis Home Button, then the Dual Axis Jog Buttons shall stay 
    ' enabled. If (JogNegButton12 == true) then go to a function that disables the buttons, homes the axis, 
    ' And re-enables the dual axis jog buttons. If (JogNegButton12 == false) then go to a function that 
    ' disables the buttons, homes the axis, but does Not re-enable the dual axis jog buttons.
    Private Sub HomeButton1_Click(sender As Object, e As EventArgs) Handles HomeButton1.Click
        Try
            If (JogPosButton12.Enabled = False) Then
                HomeButton1.Enabled = False
                JogNegButton1.Enabled = False
                JogPosButton1.Enabled = False
                HomeButton12.Enabled = False

                Home_X_Axis()

                JogPosButton1.Enabled = True
                JogNegButton1.Enabled = True
                HomeButton1.Enabled = True
                HomeButton12.Enabled = True
            End If
            If (JogPosButton12.Enabled = True) Then
                HomeButton1.Enabled = False
                JogNegButton1.Enabled = False
                JogPosButton1.Enabled = False

                HomeButton12.Enabled = False
                JogNegButton12.Enabled = False
                JogPosButton12.Enabled = False

                Home_X_Axis()

                JogPosButton1.Enabled = True
                JogNegButton1.Enabled = True
                HomeButton1.Enabled = True

                JogNegButton12.Enabled = True
                JogPosButton12.Enabled = True
                HomeButton12.Enabled = True
            End If
            Check()
        Catch ex As Exception
            Timer1.Stop()
            HomeButton1.Enabled = True
            DisplayError(ex)
        End Try
    End Sub

    Private Sub HomeButton2_Click(sender As Object, e As EventArgs) Handles HomeButton2.Click
        Try
            If (JogNegButton12.Enabled = False) Then
                HomeButton2.Enabled = False
                JogNegButton2.Enabled = False
                JogPosButton2.Enabled = False
                HomeButton12.Enabled = False

                Home_Y_Axis()

                JogPosButton2.Enabled = True
                JogNegButton2.Enabled = True
                HomeButton2.Enabled = True
                HomeButton12.Enabled = True
            End If
            If (JogNegButton12.Enabled = True) Then
                HomeButton2.Enabled = False
                JogPosButton2.Enabled = False
                JogNegButton2.Enabled = False

                HomeButton12.Enabled = False
                JogNegButton12.Enabled = False
                JogPosButton12.Enabled = False

                Home_Y_Axis()

                JogPosButton2.Enabled = True
                JogNegButton2.Enabled = True
                HomeButton2.Enabled = True

                HomeButton12.Enabled = True
                JogNegButton12.Enabled = True
                JogPosButton12.Enabled = True
            End If
            Check()
        Catch ex As Exception
            Timer1.Stop()
            HomeButton2.Enabled = True
            DisplayError(ex)
        End Try
    End Sub

    Private Sub HomeButton12_Click(sender As Object, e As EventArgs) Handles HomeButton12.Click
        Try
            HomeButton1.Enabled = False
            HomeButton2.Enabled = False
            HomeButton12.Enabled = False

            JogNegButton1.Enabled = False
            JogPosButton1.Enabled = False

            JogNegButton2.Enabled = False
            JogPosButton2.Enabled = False

            JogNegButton12.Enabled = False
            JogPosButton12.Enabled = False

            Home_X_Axis()
            Home_Y_Axis()

            HomeButton12.Enabled = True
            JogPosButton12.Enabled = True
            JogNegButton12.Enabled = True

            HomeButton1.Enabled = True
            JogPosButton1.Enabled = True
            JogNegButton1.Enabled = True

            HomeButton2.Enabled = True
            JogPosButton2.Enabled = True
            JogNegButton2.Enabled = True
        Catch ex As Exception
            Timer1.Stop()
            HomeButton12.Enabled = True
            DisplayError(ex)
        End Try
    End Sub

End Class
