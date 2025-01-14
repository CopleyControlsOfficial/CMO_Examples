'  Example 13 PathPlanning Rev 1
'
' This program demonstrates how to use path planning in a 
' two axis machine. Path planning allows the user to plan
' a two dimensional path using the path planning object.
' Once created, the object contains the following methods:
'
'    SetStartingPos: Set the two dimensional starting
'    position for the path.
'
'    AddLine: add a two dimensional line To the path. The
'    method has two overloads. One takes in a double that 
'    Is applied to the current direction of travel. The 
'    other takes a two dimensional array that Is used as 
'    the destination (endpoint) of the move.
'
'    AddArc: add an arc to the path. The method has two
'    overloads. One takes a double as the radius And a 
'    double as the angle in radians. The radius Is applied
'    in the current direction of motion. The second 
'    overload takes a two dimensional center point of the
'    arc And a double as the angle in radians.
'
'    Pause: add a time delay In second To the path.
'    
'    PlayPath: retrieve the current commanded position
'    And velocity of the path. If the path Is reset using
'    the reset method, PlayPath can be used in a while
'    loop to print the entire path.
'
'    There are other methods used to set up the trajectory
'    limits. See CMO manual for details.
'
' This program assumes the following axis configuration:
' 1. Upon startup it will enable one axis at Can Node ID 1 and
'    one at Can Node ID 2, or one axis at EtherCAT node -1 and 
'    one at EtherCAT node -2.
' 2. Both motors have an encoders with an index
'
' This code also includes the following prerequisites:
' 1. The both amplifiers And motors must be preconfigured And set up properly to run.
' 2. The hardware enable switch must be installed on both amplifiers 
' And both are easily accessible
' 
' As with any motion product extreme caution must used! Read And understand
' all parameter settings before attemping to send to amplifier.
' This program assumes the following axis configurations:
' 
' Copley Motion Objects are Copyright, 2002-2024, Copley Controls.
'
' for more information on Copley Motion products see:
' http://www.copleycontrols.com

Imports CMLCOMLib
Public Class PathPlanning
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
    Dim linkageSettings As LinkageSettingsObj

    Dim pathObj As PathPlanningObj
    Const dimension As Integer = 2 ' number of dimensions
    Dim point(1) As Double ' create a 2 dimensional point in space (x, y)

    Dim ampArray(1) As AmpObj

    Const xAxisAmp As Short = 0
    Const yAxisAmp As Short = 1

    ' Create a delegate to close down the application in a thread safe way
    Delegate Sub CloseApp()
    Private Sub PathPlanning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '**************************************************************************
            '* Turn on logging by setting a CML object
            '**************************************************************************
            cmlObj = New CopleyMotionLibraryObj()
            cmlObj.DebugLevel = LOG_ALL

            'Initialize code here
            ampArray(xAxisAmp) = New AmpObj
            ampArray(yAxisAmp) = New AmpObj
            Linkage = New LinkageObj
            pathObj = New PathPlanningObj

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
            ampArray(xAxisAmp).Initialize(CanOpen, X_AXIS_CAN_ADDRESS)
            ampArray(yAxisAmp).Initialize(CanOpen, Y_AXIS_CAN_ADDRESS)

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
            'ampArray(xAxisAmp).InitializeEcat(ecatObj, X_AXIS_ECAT_NODE)
            'ampArray(yAxisAmp).InitializeEcat(ecatObj, Y_AXIS_ECAT_NODE)
            '
            '*******************************************************************************
            '* Initialization of a multi-axis EtherCAT drive (AE2, XE2, etc)
            '*******************************************************************************
            ' Initialize the first axis - 2 axis drives are treated like a single node on 
            ' the EtherCAT network, so only one EtherCAT node ID is used.
            ' This example assumes that there are two AmpObj declared.
            'ampArray(xAxisAmp).InitializeEcat(ecatObj, X_AXIS_ECAT_NODE)
            ' Initialize the second axis by passing in the already inititalized
            ' x axis amp object in as a paramter
            'ampArray(yAxisAmp).InitializeEcatSubAxis(ampArray(xAxisAmp))

            Linkage.Initialize(ampArray)

            ' Enable the GUI components
            StartButton.Enabled = True
            MaxVelTextBox.Enabled = True
            MaxAccelTextBox.Enabled = True
            MaxDecelTextBox.Enabled = True
            MaxJerkTextBox.Enabled = True

            ' Read velocity loop settings from the amp, use these as reasonble starting
            ' points for the trajectory limits.
            MaxVelTextBox.Text = Convert.ToString((ampArray(xAxisAmp).VelocityLoopSettings.VelLoopMaxVel) / 10)
            MaxAccelTextBox.Text = Convert.ToString((ampArray(xAxisAmp).VelocityLoopSettings.VelLoopMaxAcc) / 10)
            MaxDecelTextBox.Text = Convert.ToString((ampArray(xAxisAmp).VelocityLoopSettings.VelLoopMaxDec) / 10)
            MaxJerkTextBox.Text = Convert.ToString(Convert.ToDouble(MaxAccelTextBox.Text) * 10)

            ' arbitrarily initialize the 2 dimensional point at the x and y actual motor positions.
            point(0) = ampArray(xAxisAmp).PositionActual()
            point(1) = ampArray(yAxisAmp).PositionActual()

            ' Read velocity loop settings from the amp, use these as reasonble starting
            ' points for the trajectory limits.
            StartPosXAxisTextBox.Text = Convert.ToString(point(0))
            StartPosYAxisTextBox.Text = Convert.ToString(point(1))
            AddLineXAxisTextBox.Text = Convert.ToString(point(0) + 100000)
            AddLineYAxisTextBox.Text = Convert.ToString(point(1) + 100000)
            RadiusTextBox.Text = Convert.ToString(100000)
            AddArcAngleTextBox.Text = Convert.ToString(180)
            AddPauseTextBox.Text = Convert.ToString(1)

            ' use the textfield values to set the trajectory limits of the path.
            pathObj.SetMaxVel(Convert.ToDouble(MaxVelTextBox.Text))
            pathObj.SetMaxAcc(Convert.ToDouble(MaxAccelTextBox.Text))
            pathObj.SetMaxDec(Convert.ToDouble(MaxDecelTextBox.Text))
            pathObj.SetMaxJrk(Convert.ToDouble(MaxJerkTextBox.Text))

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub PathPlanning_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            ampArray(yAxisAmp).Disable()
            ampArray(xAxisAmp).Disable()

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

    Private Sub HaltButton_Click(sender As Object, e As EventArgs) Handles HaltButton.Click
        Try
            Linkage.HaltMove()
        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    ' send the path to the trajectory generator using the 
    ' SendPath method of the linkage object.
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Try
            ' If the stop button was pressed (halt commanded), clear the
            ' halted condition before beginning next move.
            For i As Integer = 0 To (dimension - 1)
                ampArray(i).ClearFaults()
            Next

            ' set trajectory limits using the user input values
            pathObj.SetMaxVel(Convert.ToDouble(MaxVelTextBox.Text))
            pathObj.SetMaxAcc(Convert.ToDouble(MaxAccelTextBox.Text))
            pathObj.SetMaxDec(Convert.ToDouble(MaxDecelTextBox.Text))
            pathObj.SetMaxJrk(Convert.ToDouble(MaxJerkTextBox.Text))

            ' start executing the path
            Linkage.SendPath(pathObj, True)

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    ' set the starting two dimensional position of the path.
    Private Sub SetStartPosButton_Click(sender As Object, e As EventArgs) Handles SetStartPosButton.Click
        Try
            point(0) = Convert.ToDouble(StartPosXAxisTextBox.Text)
            point(1) = Convert.ToDouble(StartPosYAxisTextBox.Text)
            pathObj.SetStartPos(point)

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    ' add a line to the end of the path.
    Private Sub AddLineButton_Click(sender As Object, e As EventArgs) Handles AddLineButton.Click
        Try
            point(0) = Convert.ToDouble(AddLineXAxisTextBox.Text)
            point(1) = Convert.ToDouble(AddLineYAxisTextBox.Text)
            pathObj.AddLine(point)

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    ' add an arc to the end of the path.
    Private Sub AddArcButton_Click(sender As Object, e As EventArgs) Handles AddArcButton.Click
        Try
            ' convert the user's input from degrees to radians
            Dim arcDegrees As Double = Convert.ToDouble(AddArcAngleTextBox.Text)
            Dim arcRadians As Double = (arcDegrees * Math.PI) / 180
            Dim radius As Double = Convert.ToDouble(RadiusTextBox.Text)
            pathObj.AddArc(radius, arcRadians)

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    ' add a pause in seconds to the path.
    Private Sub AddPauseButton_Click(sender As Object, e As EventArgs) Handles AddPauseButton.Click
        Try
            Dim seconds As Double = Convert.ToDouble(AddPauseTextBox.Text)
            pathObj.Pause(seconds)

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub PlayPathButton_Click(sender As Object, e As EventArgs) Handles PlayPathButton.Click
        Try
            ClearPoints() ' clear the points Of the graph

            Dim pos As Double() = {0.0, 0.0}
            Dim vel As Double() = {0.0, 0.0}

            ' Now, print out the positions And velocities along the path.
            ' We need to reset the path before we start playing it back.
            pathObj.Reset()

            Dim count As Integer = 0

            Dim done As Boolean = False
            Do
                done = pathObj.PlayPath(0.01, pos, vel) ' Get the velocity And position back from trajectory generator

                Chart.Series(0).Points.AddXY(pos(0), pos(1))  ' graph position data
                Chart.Series(1).Points.AddXY(count, vel(0))   ' graph axis A velocity data 
                Chart.Series(2).Points.AddXY(count, vel(1))   ' graph axis B velocity data

                count = count + 1

                'Console.WriteLine("Count: " + Convert.ToString(count) + " Axis A pos: " + Convert.ToString(pos(0)) + " Axis A vel: " + Convert.ToString(vel(0)) +
                '    " Axis B pos: " + Convert.ToString(pos(1)) + " Axis B vel: " + Convert.ToString(vel(1)))
            Loop Until (done)
        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    ' clear X,Y points from graph
    Private Sub ClearPoints()
        Try
            For Each series In Chart.Series
                series.Points.Clear()
            Next
        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

End Class
