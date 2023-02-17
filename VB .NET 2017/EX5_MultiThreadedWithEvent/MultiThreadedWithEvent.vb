Imports System.Threading

'  Example 5 MultiThreaded with Events Rev 4
'
' This program demonstrates multithreaded moves with two axis using
' event driven callback
'
' This program assumes the following axis configuration:
' 1. Upon startup it will enable one axis at Can Node ID 1 and
'    one at Can Node ID 2.
' 2. Both motors have an encoders with an index
'
' This code also includes the following prerequisites:
' 1. The both amplifiers and motors must be preconfigured and set up properly to run.
' 2. The hardware enable switch must be installed on both amplifiers 
' and both are easily accessible
' 
' As with any motion product extreme caution must used! Read and understand
' all parameter settings before attemping to send to amplifier.
'
' 
' Copley Motion Objects are Copyright, 2002-2018, Copley Controls.
'
' For more information on Copley Motion products see:
' http://www.copleycontrols.com

Imports CMLCOMLib

Public Class MultiThreadedWithEvent
    Inherits System.Windows.Forms.Form

    '***************************************************
    '*
    '*  CANOpen Network
    '*
    '***************************************************
    Const X_AXIS_CAN_ADDRESS As Integer = 1
    Const Y_AXIS_CAN_ADDRESS As Integer = 2
    Dim CanOpen As canOpenObj

    Const LOG_ALL As Integer = 99
    Dim cmlObj As CopleyMotionLibraryObj

    ' thread objects for each axis
    Dim xAxisThread As Threading.Thread
    Dim yAxisThread As Threading.Thread

    ' These are the .NET classes used to synchronize threads
    Dim xResetEvent As New AutoResetEvent(False)
    Dim yResetEvent As New AutoResetEvent(False)


    Dim AmpX As AmpObj
    Dim AmpY As AmpObj

    Friend WithEvents xAxisEventObj As eventObj
    Friend WithEvents YAxisEventObj As eventObj

    Dim xMoveDistance As Double
    Dim yMoveDistance As Double

    Dim Home As HomeSettingsObj
    Dim ProfileSettings As ProfileSettingsObj

    ' Create a delegate to close down the application in a thread safe way
    Delegate Sub CloseApp()

    Private Sub MultiThreadedWithEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '**************************************************************************
            '* Turn on logging by setting a CML object
            '**************************************************************************
            cmlObj = New CopleyMotionLibraryObj()
            cmlObj.DebugLevel = LOG_ALL


            AmpX = New AmpObj
            AmpY = New AmpObj


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
            AmpX.Initialize(CanOpen, X_AXIS_CAN_ADDRESS)
            AmpY.Initialize(CanOpen, Y_AXIS_CAN_ADDRESS)


            AmpX.HaltMode = CML_HALT_MODE.HALT_DECEL
            AmpY.HaltMode = CML_HALT_MODE.HALT_DECEL


            ' These are the CMO objects that are setup to callback when the move is done
            ' Set up the event call back conditions
            xAxisEventObj = AmpX.CreateEvent(CML_AMP_EVENT.AMPEVENT_MOVE_DONE, CML_EVENT_CONDITION.CML_EVENT_ANY)
            YAxisEventObj = AmpY.CreateEvent(CML_AMP_EVENT.AMPEVENT_MOVE_DONE, CML_EVENT_CONDITION.CML_EVENT_ANY)

            'set up profile settings for moves
            ProfileSettings = AmpX.ProfileSettings ' read profile settings from amp
            ProfileSettings.ProfileType = CML_PROFILE_TYPE.PROFILE_TRAP
            ProfileSettings.ProfileAccel = (AmpX.VelocityLoopSettings.VelLoopMaxAcc) / 10
            ProfileSettings.ProfileDecel = (AmpX.VelocityLoopSettings.VelLoopMaxDec) / 10
            ProfileSettings.ProfileVel = (AmpX.VelocityLoopSettings.VelLoopMaxVel) / 10
            AmpX.ProfileSettings = ProfileSettings

            ProfileSettings = AmpY.ProfileSettings ' read profile settings from amp
            ProfileSettings.ProfileType = CML_PROFILE_TYPE.PROFILE_TRAP
            ProfileSettings.ProfileAccel = (AmpY.VelocityLoopSettings.VelLoopMaxAcc) / 10
            ProfileSettings.ProfileDecel = (AmpY.VelocityLoopSettings.VelLoopMaxDec) / 10
            ProfileSettings.ProfileVel = (AmpY.VelocityLoopSettings.VelLoopMaxVel) / 10
            AmpY.ProfileSettings = ProfileSettings

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    ' X axis thread.
    ' Alternate from +/-destination position. Issue the move Absolute
    ' command to the amplifier.  The thread is suspended after issuing the move command to
    ' wait for the move to comlpete before issuing the next move command.  
    Private Sub RunXaxis()
        Try
            Do
                AmpX.MoveAbs(xMoveDistance)
                ' Starts the CMO event object - this starts a thread in CMO that looks
                '      for the move done
                xAxisEventObj.Start(False, 50000)

                ' Wait to be signaled before continuing - the event callback method below
                '      will signal the reset event to wake up this thread
                xResetEvent.WaitOne()

            Loop While xAxisThread IsNot Nothing
        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    ' Y axis thread.
    ' Alternate from +/-destination position. Issue the move Absolute
    ' command to the amplifier.  The thread is suspended after issuing the move command to
    ' wait for the move to comlpete before issuing the next move command.  
    Private Sub RunYaxis()
        Try
            Do
                AmpY.MoveAbs(yMoveDistance)

                'Starts the CMO event object - this starts a thread in CMO that looks
                'for the move done
                YAxisEventObj.Start(False, 50000)

                ' Wait to be signaled before continuing - the event callback method below
                ' will signal the reset event to wake up this thread

                yResetEvent.WaitOne()
            Loop While yAxisThread IsNot Nothing
        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub xAxisStartButton_Click(sender As Object, e As EventArgs) Handles xAxisStartButton.Click
        Try
            HomeAxisButton.Enabled = False

            'Read in move distance to be used
            xMoveDistance = xMoveDistanceTextBox.Text

            xAxisStartButton.Enabled = False
            xAxisThread = New Threading.Thread(AddressOf RunXaxis)
            xAxisThread.Start()

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub xAxisStopButton_Click(sender As Object, e As EventArgs) Handles xAxisStopButton.Click
        Try
            xAxisEventObj.Stop()
            Stop_X_AXIS()

            If (yAxisStartButton.Enabled = True) Then
                HomeAxisButton.Enabled = True
            End If

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub yAxisStartButton_Click(sender As Object, e As EventArgs) Handles yAxisStartButton.Click
        Try
            HomeAxisButton.Enabled = False

            'Read in move distance to be used
            yMoveDistance = yAxisMoveDistanceTextBox.Text

            yAxisStartButton.Enabled = False
            yAxisThread = New Threading.Thread(AddressOf RunYaxis)
            yAxisThread.Start()

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub yAxisStopButton_Click(sender As Object, e As EventArgs) Handles yAxisStopButton.Click
        Try
            YAxisEventObj.Stop()
            Stop_Y_Axis()

            If (xAxisStartButton.Enabled = True) Then
                HomeAxisButton.Enabled = True
            End If

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub Stop_X_AXIS()
        Try
            ' If the thread object is null then return
            If xAxisThread Is Nothing Then
                Exit Sub
            End If
            ' if the thread has already been aborted, then don't try to abort it again
            If xAxisThread.ThreadState = Threading.ThreadState.Aborted Then
                Exit Sub
            End If

            AmpX.HaltMove()
            xAxisEventObj.Stop()

            xAxisStartButton.Enabled = True

            xAxisThread = Nothing

            ' Trigger the event to break out of the WaitOne() function And allow thread to close.
            xResetEvent.Set()

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub Stop_Y_Axis()
        Try
            ' If the thread object is null then return
            If yAxisThread Is Nothing Then
                Exit Sub
            End If

            ' if the thread has already been aborted, then don't try to abort it again
            If yAxisThread.ThreadState = Threading.ThreadState.Aborted Then
                Exit Sub
            End If

            AmpY.HaltMove()
            YAxisEventObj.Stop()

            yAxisStartButton.Enabled = True

            yAxisThread = Nothing

            ' Trigger the event to break out of the WaitOne() function And allow thread to close.
            yResetEvent.Set()

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub xAxisEventObj_EventNotify(ByVal match As CML_AMP_EVENT, ByVal hasError As Boolean) Handles xAxisEventObj.EventNotify
        Try
            If hasError Then
                Stop_X_AXIS()
                Dim errormsgbox As Short
                errormsgbox = MsgBox("Error reported by X-Axis amplifier in Event Notify", MsgBoxStyle.RetryCancel)
                If errormsgbox = MsgBoxResult.Cancel Then
                    ' it is possible that this method was called from a thread other than the 
                    ' GUI thread - if this is the case we must use a delegate to close the application.
                    Dim d As New CloseApp(AddressOf ThreadSafeClose)
                    Me.Invoke(d)
                End If
                Exit Sub
            End If

            ' If the thread object is null then return
            If xAxisThread Is Nothing Then
                Exit Sub
            End If

            ' if the thread has already been aborted, then don't try to abort it again
            If xAxisThread.ThreadState = Threading.ThreadState.Aborted Then
                Exit Sub
            End If

            xMoveDistance = xMoveDistance * -1

            ' This is where the x axis reset event gets signaled
            xResetEvent.Set()

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub yAxisEventObj_EventNotify(ByVal match As CML_AMP_EVENT, ByVal hasError As Boolean) Handles YAxisEventObj.EventNotify
        Try
            If hasError Then
                Stop_Y_Axis()
                Dim errormsgbox As Short
                errormsgbox = MsgBox("Error reported by Y-Axis amplifier in Event Notify", MsgBoxStyle.RetryCancel)
                If errormsgbox = MsgBoxResult.Cancel Then
                    ' it is possible that this method was called from a thread other than the 
                    ' GUI thread - if this is the case we must use a delegate to close the application.
                    Dim d As New CloseApp(AddressOf ThreadSafeClose)
                    Me.Invoke(d)
                End If
                Exit Sub
            End If

            ' If the thread object is null then return
            If yAxisThread Is Nothing Then
                Exit Sub
            End If

            ' if the thread has already been aborted, then don't try to abort it again
            If yAxisThread.ThreadState = Threading.ThreadState.Aborted Then
                Exit Sub
            End If

            yMoveDistance = yMoveDistance * -1

            ' This is where the y axis reset evet gets signaled
            yResetEvent.Set()

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub HomeAxisButton_Click(sender As Object, e As EventArgs) Handles HomeAxisButton.Click
        Try
            xAxisStartButton.Enabled = False
            yAxisStartButton.Enabled = False

            Home = AmpX.HomeSettings
            Home.HomeVelFast = (AmpX.VelocityLoopSettings.VelLoopMaxVel) / 10
            Home.HomeVelSlow = (AmpX.VelocityLoopSettings.VelLoopMaxVel) / 15
            Home.HomeAccel = (AmpX.VelocityLoopSettings.VelLoopMaxAcc) / 10
            Home.HomeMethod = CML_HOME_METHOD.CHOME_INDEX_POSITIVE
            Home.HomeOffset = 0
            AmpX.HomeSettings = Home
            AmpX.GoHome()
            AmpX.WaitMoveDone(10000)


            Home = AmpY.HomeSettings
            Home.HomeVelFast = (AmpY.VelocityLoopSettings.VelLoopMaxVel) / 10
            Home.HomeVelSlow = (AmpY.VelocityLoopSettings.VelLoopMaxVel) / 15
            Home.HomeAccel = AmpY.VelocityLoopSettings.VelLoopMaxAcc / 10
            Home.HomeMethod = CML_HOME_METHOD.CHOME_NONE

            Home.HomeOffset = 0
            AmpY.HomeSettings = Home
            AmpY.GoHome()
            AmpY.WaitMoveDone(10000)

            yAxisStartButton.Enabled = True
            xAxisStartButton.Enabled = True

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub MultiThreadedWithEvent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Stop_X_AXIS()
            Stop_Y_Axis()
            AmpY.Disable()
            AmpX.Disable()

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Public Sub DisplayError(ex As Exception)
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
