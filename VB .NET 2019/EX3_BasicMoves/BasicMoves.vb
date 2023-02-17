'
' Example 3 Basic Moves Rev 4
'
' This program demonstrates how to perform basic trap profile move.
'
' This program demonstrates the following types of motion:
' 1. Trapezoidal move 
' 2. Halt move
'
' This program assumes the following axis configuration:
' 1. Upon startup it will enable axis at Can Node ID 1.
' 2. The motor has an encoder with an index
'
' This code also includes the following prerequisites:
' 1. The amplifier and motor must be preconfigured and set up properly to run.
' 2. The hardware enable switch must be installed and easily accessible
' 
' As with any motion product extreme caution must used! Read and understand
' all parameter settings before attemping to send to amplifier.
' 
' 
' Copley Motion Objects are Copyright, 2002-2021, Copley Controls.
'
' For more information on Copley Motion products see:
' http://www.copleycontrols.com
'
Imports CMLCOMLib
Public Class BasicMoves
    Inherits System.Windows.Forms.Form
    '***************************************************
    '*
    '*  CANOpen Network
    '*
    '***************************************************
    Const X_AXIS_CAN_ADDRESS As Integer = 1
    Dim CanOpen As canOpenObj

    Const LOG_ALL As Integer = 99
    Dim cmlObj As CopleyMotionLibraryObj

    Dim xAxisAmp As AmpObj
    Dim ProfileSettings As ProfileSettingsObj
    Dim Home As HomeSettingsObj


    ' Create a delegate to close down the application in a thread safe way
    Delegate Sub CloseApp()

    Private Sub BasicMoves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '**************************************************************************
            '* Turn on logging by setting a CML object
            '**************************************************************************
            cmlObj = New CopleyMotionLibraryObj()
            cmlObj.DebugLevel = LOG_ALL

            'Initialize code here
            xAxisAmp = New AmpObj


            '***************************************************
            '
            '  CANOpen Network
            '
            '***************************************************
            CanOpen = New canOpenObj()
            '
            '**************************************************************************
            '* The next two lines of code are optional. If no bit rate is specified,
            '* then the default bit rate (1 Mbit per second) is used.  If no port name
            '* is specified, then CMO will use the first supported CAN card found and
            '* use channel 0 of that card.
            '**************************************************************************
            '''' Set the bit rate to 1 Mbit per second
            CanOpen.BitRate = CML_BIT_RATES.BITRATE_1_Mbit_per_sec
            '''' Indicate that channel 0 of a Copley CAN card should be used
            CanOpen.PortName = "copley0"
            '***************************************************
            '* Initialize the CAN card and network
            '***************************************************
            CanOpen.Initialize()
            '***************************************************
            '* Initialize the amplifier
            '***************************************************
            xAxisAmp.Initialize(CanOpen, X_AXIS_CAN_ADDRESS)


            ' Read velocity loop settings from the amp, use these as reasonble starting
            ' points for the trajectory limits.
            VelocityTextBox.Text = (xAxisAmp.VelocityLoopSettings.VelLoopMaxVel) / 10
            AccelTextBox.Text = (xAxisAmp.VelocityLoopSettings.VelLoopMaxAcc) / 10
            DecelTextBox.Text = (xAxisAmp.VelocityLoopSettings.VelLoopMaxDec) / 10

            'Initialize home object with amplifier home settings 
            Home = xAxisAmp.HomeSettings

            Timer1.Start()

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub HomeAxisButton_Click(sender As Object, e As EventArgs) Handles HomeAxisButton.Click
        Try
            HomeAxisButton.Enabled = False

            Home.HomeVelFast = (xAxisAmp.VelocityLoopSettings.VelLoopMaxVel) / 10
            Home.HomeVelSlow = (xAxisAmp.VelocityLoopSettings.VelLoopMaxVel) / 15
            Home.HomeAccel = xAxisAmp.VelocityLoopSettings.VelLoopMaxAcc / 10
            Home.HomeMethod = CML_HOME_METHOD.CHOME_INDEX_POSITIVE
            Home.HomeOffset = -100000
            xAxisAmp.HomeSettings = Home
            xAxisAmp.GoHome()
            xAxisAmp.WaitMoveDone(10000)

            doMoveButton.Enabled = True

            HomeAxisButton.Enabled = True

        Catch ex As Exception
            HomeAxisButton.Enabled = True
            DisplayError(ex)
        End Try
    End Sub

    Private Sub enableButton_Click(sender As Object, e As EventArgs) Handles enableButton.Click
        Try
            If (enableButton.Text = "Amp Disable") Then
                xAxisAmp.Disable()
                enableButton.Text = "Amp Enable"
            Else
                xAxisAmp.Enable()
                enableButton.Text = "Amp Disable"
            End If

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub doMoveButton_Click(sender As Object, e As EventArgs) Handles doMoveButton.Click
        Try
            Dim Distance As Double
            Distance = DistanceTextBox.Text

            ProfileSettings = xAxisAmp.ProfileSettings ' read profile settings from amp

            'Set the profile type for move
            ProfileSettings.ProfileType = CML_PROFILE_TYPE.PROFILE_TRAP

            'Set the profile trajectory values 
            ProfileSettings.ProfileAccel = AccelTextBox.Text
            ProfileSettings.ProfileDecel = DecelTextBox.Text
            ProfileSettings.ProfileVel = VelocityTextBox.Text

            ' Update the amplier's profile settigns
            xAxisAmp.ProfileSettings = ProfileSettings

            ' Execute the move
            xAxisAmp.MoveRel(Distance)

        Catch ex As Exception
            doMoveButton.Enabled = True
            HomeAxisButton.Enabled = True
            DisplayError(ex)
        End Try
    End Sub

    Private Sub haltMoveButton_Click(sender As Object, e As EventArgs) Handles haltMoveButton.Click
        Try
            doMoveButton.Enabled = False
            HomeAxisButton.Enabled = False

            'set halt mode desired before halting the move
            xAxisAmp.HaltMode = CML_HALT_MODE.HALT_DECEL
            ' now halt the move
            xAxisAmp.HaltMove()

            doMoveButton.Enabled = True
            HomeAxisButton.Enabled = True

        Catch ex As Exception
            doMoveButton.Enabled = True
            HomeAxisButton.Enabled = True
            DisplayError(ex)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            'Read and display actual position 
            posTextBox.Text = xAxisAmp.PositionActual

        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub BasicMoves_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            xAxisAmp.Disable()

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

End Class
