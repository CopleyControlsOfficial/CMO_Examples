﻿'
' Example 8 Jogging Rev 4
'
' This program demonstrates how to perform jogging moves.
'
' This program assumes the following axis configuration:
' 1. Upon startup it will enable axis at Can Node ID 1 or
'    an axis at EtherCAT Node ID -1.
'
' This code also includes the following prerequisites:
' 1. The amplifier and motor must be preconfigured and set up properly to run.
' 2. The hardware enable switch must be installed and easily accessible
' 
' As with any motion product extreme caution must be used! Read and understand
' all parameter settings before attemping to send to amplifier.
' 
' 
' Copley Motion Objects are Copyright, 2006-2024, Copley Controls.
'
' For more information on Copley Motion products see:
' http://www.copleycontrols.com
'
Imports CMLCOMLib

Public Class Jog
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
    Const CAN_ADDRESS As Integer = 1
    Dim canOpen As canOpenObj

    Const LOG_ALL As Integer = 99
    Dim cmlObj As CopleyMotionLibraryObj

    Dim ampObj As AmpObj
    Dim ProfileParameters As ProfileSettingsObj
    ' Create a delegate to close down the application in a thread safe way
    Delegate Sub CloseApp()
    Private Sub Jog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '**************************************************************************
            '* Turn on logging by setting a CML object
            '**************************************************************************
            cmlObj = New CopleyMotionLibraryObj()
            cmlObj.DebugLevel = LOG_ALL

            ampObj = New AmpObj()
            ProfileParameters = New ProfileSettingsObj

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
            '***************************************************
            '* Initialize the amplifier
            '***************************************************
            ampObj.Initialize(canOpen, CAN_ADDRESS)


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
            'ampObj.InitializeEcat(ecatObj, ECAT_NODE)
            '


            ' Read velocity loop settings from the amp, use these as reasonble starting
            ' points for the trajectory limits.
            VelocityTextBox.Text = (ampObj.VelocityLoopSettings.VelLoopMaxVel) / 10
            AccelTextBox.Text = (ampObj.VelocityLoopSettings.VelLoopMaxAcc) / 10
            DecelTextBox.Text = (ampObj.VelocityLoopSettings.VelLoopMaxDec) / 10

            'Selects profile type
            ProfileParameters.ProfileType = CML_PROFILE_TYPE.PROFILE_VELOCITY

            Timer1.Start()
            Exit Sub

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    'Code for button with mouse pressed
    Private Sub JogPosButton_MouseDown(sender As Object, e As MouseEventArgs) Handles JogPosButton.MouseDown
        Try
            'Sets velocity, acceleration, deceleration limits for move to inputed values
            ProfileParameters.ProfileAccel = Val(AccelTextBox.Text)
            ProfileParameters.ProfileDecel = Val(DecelTextBox.Text)
            ProfileParameters.ProfileVel = Val(VelocityTextBox.Text)

            'Store inputed parameters as the profile settings
            ampObj.ProfileSettings = ProfileParameters

            'Performs positive move. 1 indicates positive move, -1 indicates negative move
            ampObj.MoveAbs(1)

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    'Code for button with mouse depressed
    Private Sub JogPosButton_MouseUp(sender As Object, e As MouseEventArgs) Handles JogPosButton.MouseUp
        Try
            'Sets profile velocity to zero
            ProfileParameters.ProfileVel = 0

            'Store inputed parameters as the profile settings
            ampObj.ProfileSettings = ProfileParameters

            'Performs move
            ampObj.MoveAbs(1)

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    'Code for button with mouse pressed
    Private Sub JogNegButton_MouseDown(sender As Object, e As MouseEventArgs) Handles JogNegButton.MouseDown
        Try
            'Sets velocity, acceleration, deceleration limits for move to inputed values
            ProfileParameters.ProfileAccel = Val(AccelTextBox.Text)
            ProfileParameters.ProfileDecel = Val(DecelTextBox.Text)
            ProfileParameters.ProfileVel = Val(VelocityTextBox.Text)

            'Store inputed parameters as the profile settings
            ampObj.ProfileSettings = ProfileParameters

            'Performs negative move
            ampObj.MoveAbs(-1)

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    'Code for button with mouse depressed
    Private Sub JogNegButton_MouseUp(sender As Object, e As MouseEventArgs) Handles JogNegButton.MouseUp
        Try
            'Sets profile velocity to zero
            ProfileParameters.ProfileVel = 0

            'Store inputed parameters as the profile settings
            ampObj.ProfileSettings = ProfileParameters

            'Performs move
            ampObj.MoveAbs(1)

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            'Reads actual position information from the amplifier
            ActPosVar.Text = ampObj.PositionActual

        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub
End Class
