'
' Example 10 CAN IO Module Rev 3
'
' This program demonstrates how to read and write to the digital IO 
' 
' As with any motion product extreme caution must used! Read and understand
' all parameter settings before attemping to send to amplifier.
' Note: The latest IO Module FW (Version 0.24) is required
'
' Copley Motion Objects are Copyright, 2006-2021, Copley Controls.
'
' For more information on Copley Motion products see:
' http://www.copleycontrols.com

Imports CMLCOMLib
Public Class IoModule
    Inherits System.Windows.Forms.Form

    'Set CAN address here
    Const CAN_ADDRESS As Integer = 1

    Const LOG_ALL As Integer = 99
    Dim cmlObj As CopleyMotionLibraryObj

    Dim canOpen As canOpenObj
    Dim ioObj As IOObj

    Dim ioSettings As ioSettingsObj

    Dim outputState As Integer 'State of the outputs
    Dim errormsgbox As Integer

    ' Create a delegate to close down the application in a thread safe way
    Delegate Sub CloseApp()
    Private Sub IoModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '**************************************************************************
            '* Turn on logging by setting a CML object
            '**************************************************************************
            cmlObj = New CopleyMotionLibraryObj()
            cmlObj.DebugLevel = LOG_ALL

            ' CAN network and I/O initialization
            canOpen = New canOpenObj
            ioObj = New IOObj

            ' To change bit rate or can card, un-comment one of the following lines
            ' and make the appropriate change default bit rate is 1 Mbit/s, default
            ' can card is first supported card found
            canOpen.BitRate = CML_BIT_RATES.BITRATE_1_Mbit_per_sec
            canOpen.PortName = "copley0"

            canOpen.Initialize()

            'The ioSettings object allows the CAN network settings to be changed for the IOObj.
            ioSettings = New ioSettingsObj
            'example of changing one of the settings
            'ioSettings.useStandardAinPDO = False

            ' initialize the ioObj using the ioSettings object
            ioObj.InitializeExt(canOpen, CAN_ADDRESS, ioSettings)

            ' Only comment in the following if there are outputs set.
            'Sets all outputs off
            'outputState = 0
            'WriteOutput()

            Me.TimerStat.Enabled = True

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub cbOut1_CheckedChanged(sender As Object, e As EventArgs) Handles cbOut1.CheckedChanged
        If cbOut1.CheckState = False Then outputState = outputState And 254 Else _
        outputState = outputState Or 1

        ' Only comment in the following if there are outputs set.
        'WriteOutput()
    End Sub

    Private Sub cbOut2_CheckedChanged(sender As Object, e As EventArgs) Handles cbOut2.CheckedChanged
        If cbOut2.CheckState = False Then outputState = outputState And 253 Else _
        outputState = outputState Or 2

        ' Only comment in the following if there are outputs set.
        'WriteOutput()
    End Sub
    Public Sub WriteOutput()
        Try

            ioObj.Dout8Write(0, outputState, False)

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    'Read inputs and set display.
    Public Sub ReadInputs()
        Try
            Dim inputState As Integer

            ioObj.Din8Read(0, inputState, True)

            If inputState And 1 Then txtInput1State.Text = "Hi" Else _
            txtInput1State.Text = "Low"

            If inputState And 2 Then txtInput2State.Text = "Hi" Else _
            txtInput2State.Text = "Low"

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub
    Private Sub TimerStat_Tick(sender As Object, e As EventArgs) Handles TimerStat.Tick
        ReadInputs()
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
