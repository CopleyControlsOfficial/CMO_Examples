'
' Example 6 PVT Rev 6
'
' This program demonstrates Copley Motion PVT Motion
'
' The purpose of this lab is perform Position-Velocity-Time move
' on a Linkage (Coordinated) Object and draw the equivalent of a circle
' using two axes.
'
' This program assumes the following axis configuration:
' 1. Upon startup it will enable one axis at Can Node ID 1 and
'     one at Can Node ID 2, or one axis at EtherCAT node -1 and 
'    one at EtherCAT node -2.
' 3. Both motors have an encoders with an index
'
' This code also includes the following prerequisites:
' 1. The both amplifiers and motors must be preconfigured and set up properly to run.
' 2. The hardware enable switch must be installed on both amplifiers 
' and both are easily accessible
' 
' As with any motion product extreme caution must used! Read and understand
' all parameter settings before attemping to send to amplifier.
' This program assumes the following axis configurations:
'
' Copley Motion Objects are Copyright, 2002-2024, Copley Controls.
'
' for more information on Copley Motion products see:
' http://www.copleycontrols.com
'
Imports CMLCOMLib
Public Class PVTFromFile
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

#Region " Windows Form Designer generated code "

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.startButton = New System.Windows.Forms.Button()
        Me.homeButton = New System.Windows.Forms.Button()
        Me.stopButton = New System.Windows.Forms.Button()
        Me.numberOfEventsTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(47, 45)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(134, 49)
        Me.startButton.TabIndex = 0
        Me.startButton.Text = "Start PVT Move"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'homeButton
        '
        Me.homeButton.Location = New System.Drawing.Point(47, 155)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(134, 49)
        Me.homeButton.TabIndex = 1
        Me.homeButton.Text = "Home"
        Me.homeButton.UseVisualStyleBackColor = True
        '
        'stopButton
        '
        Me.stopButton.Location = New System.Drawing.Point(47, 100)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(134, 49)
        Me.stopButton.TabIndex = 2
        Me.stopButton.Text = "Stop PVT Move"
        Me.stopButton.UseVisualStyleBackColor = True
        '
        'numberOfEventsTextBox
        '
        Me.numberOfEventsTextBox.Location = New System.Drawing.Point(81, 230)
        Me.numberOfEventsTextBox.Name = "numberOfEventsTextBox"
        Me.numberOfEventsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.numberOfEventsTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Number of Events:"
        '
        'PVTFromFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 296)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numberOfEventsTextBox)
        Me.Controls.Add(Me.stopButton)
        Me.Controls.Add(Me.homeButton)
        Me.Controls.Add(Me.startButton)
        Me.Name = "PVTFromFile"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents startButton As Button
    Friend WithEvents homeButton As Button
    Friend WithEvents stopButton As Button
    Friend WithEvents numberOfEventsTextBox As TextBox

#End Region

    Private Sub PVTFromFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            '
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


            Dim filenum As Int32

            FileOpen(1, "posDataFile.txt", OpenMode.Output)

            FileOpen(2, "velDataFile.txt", OpenMode.Output)

            FileOpen(3, "time.txt", OpenMode.Output)

            ' Open "velDataFile.txt" For Output As #2

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
                Write(1, x)
                Write(1, y)
                Write(2, xv)
                Write(2, yv)
                Write(3, 1000 * t)

            Next i
            FileClose(1)
            FileClose(2)
            FileClose(3)

        Catch ex As Exception
            DisplayError(ex)
        End Try

    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        Try

            homeButton.Enabled = False
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

    Private Sub homeButton_Click(sender As Object, e As EventArgs) Handles homeButton.Click
        Try
            homeButton.Enabled = False

            Home = ampArray(X_AXIS_AMP).HomeSettings
            Home.HomeVelFast = (ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 10
            Home.HomeVelSlow = (ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 15
            Home.HomeAccel = ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxAcc / 10
            Home.HomeMethod = CML_HOME_METHOD.CHOME_INDEX_POSITIVE
            Home.HomeOffset = -150000
            ampArray(X_AXIS_AMP).HomeSettings = Home
            ampArray(X_AXIS_AMP).GoHome()
            ampArray(X_AXIS_AMP).WaitMoveDone(10000)


            Home = ampArray(Y_AXIS_AMP).HomeSettings
            Home.HomeVelFast = (ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 10
            Home.HomeVelSlow = (ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 15
            Home.HomeAccel = ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxAcc / 10
            Home.HomeMethod = CML_HOME_METHOD.CHOME_INDEX_NEGATIVE
            Home.HomeOffset = -1000
            ampArray(Y_AXIS_AMP).HomeSettings = Home
            ampArray(Y_AXIS_AMP).GoHome()
            ampArray(Y_AXIS_AMP).WaitMoveDone(10000)

            homeButton.Enabled = True
            startButton.Enabled = True

        Catch ex As Exception
            homeButton.Enabled = True
            DisplayError(ex)
        End Try
    End Sub

    Private Sub calcSegments2()
        Try

            Dim x As Double
            Dim poss(ARRAY_LEN, 0) As Double
            Dim j As Int32
            j = 0

            ' open file containing the positions for two axes
            FileOpen(1, "posDataFile.txt", OpenMode.Input)
            While Not EOF(1)   ' Loop until end of file.
                Input(1, x) ' Read line into variable.
                positions(j, 0) = x ' save it to the positions arrray row 1
                Input(1, x) ' Read line into variable.
                positions(j, 1) = x ' save it to the positions arrray row 2
                j = j + 1 ' set next column
            End While
            FileClose(1)   ' Close file.

            j = 0 ' reset counter
            ' open file containing the positions for two axes
            FileOpen(2, "velDataFile.txt", OpenMode.Input)
            While Not EOF(2)   ' Loop until end of file.
                Input(2, x) ' Read line into variable.
                velocities(j, 0) = x
                Input(2, x) ' Read line into variable.
                velocities(j, 1) = x
                j = j + 1
            End While
            FileClose(2)   ' Close file.

            j = 0 ' reset counter
            Dim y As Int32

            FileOpen(3, "time.txt", OpenMode.Input)
            While Not EOF(3)   ' Loop until end of file.
                Input(3, y) ' Read line into variable.
                times(j) = y
                j = j + 1
            End While
            FileClose(3)   ' Close file.


        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub PVTFromFile_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
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

    Private Sub EventObj_EventNotify(ByVal match As CML_AMP_EVENT, ByVal hasError As Boolean) Handles EventObj.EventNotify
        Try


            If hasError Then
                EventObj.Start(True, 5000) ' false for repeating 5000 for timout
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

    Private Sub stopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click
        Try

            EventObj.Stop()
            Linkage.HaltMove()
            startButton.Enabled = True
            homeButton.Enabled = True

        Catch ex As Exception
            DisplayError(ex)
        End Try
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
