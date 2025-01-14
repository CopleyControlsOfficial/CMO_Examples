Imports System.Threading
'
' Example 6 PVT Rev 5
'
' This program demonstrates Copley Motion PVT Motion
'
' The purpose of this lab is perform Position-Velocity-Time move
' on a Linkage (Coordinated) Object and draw the equivalent of a circle
' using two axes.
'
' This program assumes the following axis configuration:
' 1. Upon startup it will enable one axis at Can Node ID 1 and
'    one at Can Node ID 2, or one axis at EtherCAT node -1 and 
'    one at EtherCAT node -2.
' 2. Both motors have an encoders with an indexes
'
' This code also includes the following prerequisites:
' 1. The both amplifiers and motors must be preconfigured and set up properly to run.
' 2. The hardware enable switch must be installed on both amplifiers 
'    and both are easily accessible
' 
' As with any motion product extreme caution must used! Read and understand
' all parameter settings before attemping to send to amplifier.
' This program assumes the following axis configurations:
'
' Copley Motion Objects are Copyright, 2002-2024, Copley Controls.
'
' For more information on Copley Motion products see:
' http://www.copleycontrols.com
'
Imports CMLCOMLib

Public Class PVT
    Inherits System.Windows.Forms.Form

    '***************************************************
    '*
    '*  EtherCAT Network
    '*
    '***************************************************
    '''' A negative node number refers to the drive's physical position on the network
    '''' -1 for the first drive, -2 for the second, etc.
    'Const X_AXIS_ECAT_NODE As Integer = -1
    'Const Y_AXIS_ECAT_NODE As Integer = -2
    'Dim ecatObj As EcatObj
    '
    'Dim ecatSettingsObj As EcatSettingsObj

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

    Dim Linkage As LinkageObj
    Dim ampArray(1) As AmpObj
    Dim Home As HomeSettingsObj
    Friend WithEvents EventObj As eventObj

    Const X_AXIS_AMP As Short = 0
    Const Y_AXIS_AMP As Short = 1
    Const ARRAY_LEN As Integer = 200

    Dim positions(ARRAY_LEN, 1) As Double
    Dim velocities(ARRAY_LEN, 1) As Double
    Dim times(ARRAY_LEN) As Integer
    Dim numberOfEvents As Integer = 0
    Dim ang, angV As Double

    ' Create a delegate to updateGui down the application in a thread safe way
    Delegate Sub UpdateGui()
    ' Create a delegate to close down the application in a thread safe way
    Delegate Sub CloseApp()

    Private Sub PVT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '**************************************************************************
            '* Turn on logging by setting a CML object
            '**************************************************************************
            cmlObj = New CopleyMotionLibraryObj()
            cmlObj.DebugLevel = LOG_ALL

            'Initialize code here

            ampArray(X_AXIS_AMP) = New AmpObj
            ampArray(Y_AXIS_AMP) = New AmpObj
            Linkage = New LinkageObj

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
            ampArray(X_AXIS_AMP).Initialize(CanOpen, X_AXIS_CAN_ADDRESS)
            ampArray(Y_AXIS_AMP).Initialize(CanOpen, Y_AXIS_CAN_ADDRESS)


            '***************************************************
            '*
            '*  EtherCAT Network
            '*
            '***************************************************
            'ecatObj = New EcatObj()
            '
            '***************************************************
            '* The next line of code is optional. The port name is the IP address of 
            '* the Ethernet adapter. Alternatively, a shortcut name “eth” can be used 
            '* in conjunction with the adapter number. For example “eth0” for the first 
            '* Ethernat adapter, “eth1” for the second adapter. If no port name is 
            '* supplied, it will default to “eth0”.
            '**************************************************************************
            '''' Indicate that the first Ethernet adapter is to be used
            'ecatObj.PortName = "eth0"
            '''' Specify an IP address
            'ecatObj.PortName = "192.168.1.1"
            '
            '***************************************************
            '* Initialize the EtherCAT network
            '***************************************************
            'ecatObj.Initialize()
            '
            '***************************************************
            '* An alternate way of initializing the EcatObj is to set up the 
            '* EcatSettingsObj then pass it into the InitializeExt method of the EcatObj. 
            '* To use it, first comment out the call to the EcatObj's Initialize method 
            '* above, then uncomment the following three lines of code.
            '**************************************************************************
            '''' Create an instance of the EcatSettingsObj object by calling the constructor 
            '''' (all of the properties will be initialized to their default values).
            'ecatSettingsObj = new EcatSettingsObj()
            '''' Change a property
            'ecatSettingsObj.cyclePeriod = 10 ' milliseconds
            '''' Initialize the EcatObj with the settings object
            'ecatObj.InitializeExt(ecatSettingsObj)
            '
            '***************************************************
            '* Initialize the amplifier
            '***************************************************
            'ampArray(X_AXIS_AMP).InitializeEcat(ecatObj, X_AXIS_ECAT_NODE)
            'ampArray(Y_AXIS_AMP).InitializeEcat(ecatObj, Y_AXIS_ECAT_NODE)


            '*******************************************************************************
            '* Initialization of a multi-axis EtherCAT drive (AE2, XE2, etc)
            '*******************************************************************************
            ' Initialize the first axis - 2 axis drives are treated like a single node on 
            ' the EtherCAT network, so only one EtherCAT node ID is used.
            ' This example assumes that there are two AmpObj declared.
            'ampArray(X_AXIS_AMP).InitializeEcat(ecatObj, X_AXIS_ECAT_NODE)
            ' Initialize the second axis by passing in the already inititalized
            ' x axis amp object in as a paramter
            'ampArray(Y_AXIS_AMP).InitializeEcatSubAxis(ampArray(X_AXIS_AMP))


            Linkage.Initialize(ampArray)


            EventObj = Linkage.CreateEvent(CML_LINK_EVENT.LINKEVENT_LOWWATER,
                                          CML_EVENT_CONDITION.CML_EVENT_ALL)


        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub calcSegments()
        Try
            '  This sub is used to calculate the points of the PVT profile used to generate 
            ' a circle.
            Dim i As Integer
            Dim x, y, xv, yv, angA As Double
            Dim xc, yc, t, angVmax, angAmax, R, PI As Double
            Dim velocityScalor As Double


            '//*****************
            ' Use the following parameters to adjust the speed
            ' and size of the profile circle

            R = 64000.0# ' Radius of circle in (counts)
            xc = 64000.0#   ' x-value for center of circle in (counts)
            yc = 5000.0#    ' y-value for center of circle in (counts)
            velocityScalor = 0.25 ' used to control the max velocity
            ' *****************

            t = 0.01
            PI = 4 * System.Math.Atan(1)
            angVmax = PI * velocityScalor
            angAmax = angVmax

            For i = 0 To ARRAY_LEN Step 1

                If (angV < angVmax) Then
                    angA = angAmax
                Else
                    angA = 0
                End If

                ang = ang + t * angV + t * t * angA / 2
                angV = angV + t * angA


                x = xc + R * System.Math.Cos(ang)
                y = yc + R * System.Math.Sin(ang)
                xv = -System.Math.Sin(ang) * angV * R
                yv = System.Math.Cos(ang) * angV * R

                positions(i, 0) = x
                velocities(i, 0) = xv
                positions(i, 1) = y
                velocities(i, 1) = yv
                times(i) = 1000 * t

            Next i

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        Try
            HomeAxisButton.Enabled = False
            startButton.Enabled = False

            ang = 4 * System.Math.Atan(1) ' = PI
            angV = 0

            calcSegments()

            numberOfEvents = 0
            numberOfEventsTextBox.Text = numberOfEvents

            Dim ProfileSettings As ProfileSettingsObj

            ProfileSettings = ampArray(X_AXIS_AMP).ProfileSettings
            ProfileSettings.ProfileAccel = (ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxAcc) / 10
            ProfileSettings.ProfileDecel = (ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxDec) / 10
            ProfileSettings.ProfileVel = (ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 10
            ProfileSettings.ProfileType = CML_PROFILE_TYPE.PROFILE_TRAP
            ampArray(X_AXIS_AMP).ProfileSettings = ProfileSettings


            ProfileSettings = ampArray(Y_AXIS_AMP).ProfileSettings
            ProfileSettings.ProfileAccel = (ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxAcc) / 10
            ProfileSettings.ProfileDecel = (ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxDec) / 10
            ProfileSettings.ProfileVel = (ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 10
            ampArray(Y_AXIS_AMP).ProfileSettings = ProfileSettings


            ampArray(X_AXIS_AMP).MoveAbs(positions(0, 0))
            ampArray(Y_AXIS_AMP).MoveAbs(positions(0, 1))   ' start y motor at midpoint

            ampArray(X_AXIS_AMP).WaitMoveDone(4000)
            ampArray(Y_AXIS_AMP).WaitMoveDone(4000)


            Linkage.TrajectoryInitialize(positions, velocities, times, 100)

            EventObj.Start(True, 5000) ' false for repeating 5000 for timout

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub EventObj_EventNotify(ByVal match As CML_AMP_EVENT, ByVal hasError As Boolean) Handles EventObj.EventNotify
        Try
            If hasError Then
                EventObj.Stop()
                Linkage.HaltMove()
                Dim errormsgbox As Short
                errormsgbox = MsgBox("Error reported by amplifier in Event Notify", MsgBoxStyle.OkCancel)
                If errormsgbox = MsgBoxResult.Cancel Then
                    ' it is possible that this method was called from a thread other than the 
                    ' GUI thread - if this is the case we must use a delegate to close the application.
                    Dim closeDelegate As New CloseApp(AddressOf ThreadSafeClose)
                    Me.Invoke(closeDelegate)
                End If
                Exit Sub
            End If

            calcSegments()

            numberOfEvents = numberOfEvents + 1

            ' Since this thread is different from the GUI thread we must use a delegate
            ' to call a method to update the GUI component (numberOfEventsTextBox)
            Dim textBoxDelegate As New UpdateGui(AddressOf UpdateNumberOfEvents)
            numberOfEventsTextBox.Invoke(textBoxDelegate)

            Linkage.TrajectoryAdd(positions, velocities, times, 100)

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Public Sub UpdateNumberOfEvents()
        ' If the calling thread is different than the GUI thread, then use the
        ' delegate to update the application, otherwise update text box directly
        If numberOfEventsTextBox.InvokeRequired Then
            Dim d As New UpdateGui(AddressOf UpdateNumberOfEvents)
            numberOfEventsTextBox.Invoke(d)
        Else
            numberOfEventsTextBox.Text = numberOfEvents
        End If
    End Sub

    Private Sub StopPVTButton_Click(sender As Object, e As EventArgs) Handles StopPVTButton.Click
        Try
            EventObj.Stop()
            Linkage.HaltMove()
            startButton.Enabled = True
            HomeAxisButton.Enabled = True

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub HomeAxisButton_Click(sender As Object, e As EventArgs) Handles HomeAxisButton.Click
        Try
            HomeAxisButton.Enabled = False

            Home = ampArray(X_AXIS_AMP).HomeSettings
            Home.HomeVelFast = (ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 10
            Home.HomeVelSlow = (ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 15
            Home.HomeAccel = ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxAcc / 10
            Home.HomeMethod = CML_HOME_METHOD.CHOME_INDEX_POSITIVE
            Home.HomeOffset = -4000
            ampArray(X_AXIS_AMP).HomeSettings = Home
            ampArray(X_AXIS_AMP).GoHome()
            ampArray(X_AXIS_AMP).WaitMoveDone(10000)


            Home = ampArray(Y_AXIS_AMP).HomeSettings
            Home.HomeVelFast = (ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 10
            Home.HomeVelSlow = (ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 15
            Home.HomeAccel = ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxAcc / 10
            Home.HomeMethod = CML_HOME_METHOD.CHOME_INDEX_POSITIVE
            Home.HomeOffset = -1000
            ampArray(Y_AXIS_AMP).HomeSettings = Home
            ampArray(Y_AXIS_AMP).GoHome()
            ampArray(Y_AXIS_AMP).WaitMoveDone(10000)

            HomeAxisButton.Enabled = True
            startButton.Enabled = True

        Catch ex As Exception
            HomeAxisButton.Enabled = True
            DisplayError(ex)
        End Try
    End Sub

    Private Sub PVT_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            ampArray(Y_AXIS_AMP).Disable()
            ampArray(X_AXIS_AMP).Disable()

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
