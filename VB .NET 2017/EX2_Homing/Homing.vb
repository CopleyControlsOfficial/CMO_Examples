﻿'Example 2 Homing Rev 5
'
' This program demonstrates how to home a motor.
'
' This program assumes the following axis configuration:
' 1. The motor has an encoder with an index
' 2. Upon startup it will enable axis at Can Node ID 1, or
'    its the first ECAT_NODE and is using the fist 
'    EtherCAT port on the system, "eth0".
'
' This code also includes the following prerequisites:
' 1. The amplifier and motor must be preconfigured and set up properly to run.
' 2. The hardware enable switch must be installed and easily accessible
' 
' As with any motion product extreme caution must used! Read and understand
' all parameter settings before attemping to send to amplifier.
'
' 
' Copley Motion Objects are Copyright, 2002-2024, Copley Controls.
'
' For more information on Copley Motion products see:
' http://www.copleycontrols.com
'
Imports CMLCOMLib

Public Class Homing
    Inherits System.Windows.Forms.Form

    '***************************************************
    '*
    '*  EtherCAT Network
    '*
    '***************************************************
    '''' A negative node number refers to the drive's physical position on the network
    '''' -1 for the first drive, -2 for the second, etc.
    'Const ECAT_NODE As Integer = -1
    'Dim ecatObj As EcatObj
    '
    'Dim ecatSettingsObj As EcatSettingsObj

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
    Dim Home As HomeSettingsObj

    ' Create a delegate to close down the application in a thread safe way
    Delegate Sub CloseApp()

    Private Sub Homing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            'xAxisAmp.InitializeEcat(ecatObj, ECAT_NODE)
            '

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

            ' Read velocity loop settings from amp and use these as
            ' reasonable homing speed values
            Home.HomeVelFast = (xAxisAmp.VelocityLoopSettings.VelLoopMaxVel) / 10
            Home.HomeVelSlow = (xAxisAmp.VelocityLoopSettings.VelLoopMaxVel) / 15
            Home.HomeAccel = xAxisAmp.VelocityLoopSettings.VelLoopMaxAcc / 10

            'Choose a homing method.  In this case move positive to index
            Home.HomeMethod = CML_HOME_METHOD.CHOME_INDEX_POSITIVE

            ' Then back off index by 1000 counts
            Home.HomeOffset = -1000

            ' send new home settings to amp
            xAxisAmp.HomeSettings = Home

            'Perform homing operation
            xAxisAmp.GoHome()

            ' Set Label
            referencedLabel.Text = " Not referenced"

            ' Force screen update
            Me.Refresh()

            xAxisAmp.WaitMoveDone(10000)  ' wait up to 10 seconds for move to finish

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            'Read and display actual position 
            posTextBox.Text = xAxisAmp.PositionActual

            'Read and display amplifier status
            If xAxisAmp.IsReferenced() Then
                referencedLabel.Text = "Referenced"
            Else
                referencedLabel.Text = " Not referenced"
            End If

        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub Homing_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            xAxisAmp.Reset()
        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        Try
            xAxisAmp.Reset()
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
