'
' Example 1 Status and Control Rev 5
'
' This program demonstrates Copley Motion Object Status and Control
'
' The purpose of this example is to enable and disable the amplifier and
' read and decode the amplifier status.
'
' This program assumes the following axis configuration:
' 1. Upon startup it will enable axis at Can Node ID 1
'
' This code also includes the following prerequisites:
' 1. The amplifier and motor must be preconfigured and set up properly to run.
' 2. The hardware enable switch must be installed and easily accessible
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

Public Class Status
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
    Dim ampSettings As ampSettingsObj


    ' Create a delegate to close down the application in a thread safe way
    Delegate Sub CloseApp()

    Private Sub Status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            '**************************************************************************
            '* Initialize the amp to not be enabled on start up by creating an
            '* ampSettingsObj then passing it into the InitializeExt method of the AmpObj
            '**************************************************************************
            '''' Create an instance of the amp settings object by calling the constructor
            '''' (all the properties will be initialized to their default values).
            ampSettings = New ampSettingsObj()
            '''' Change a property
            ampSettings.enableOnInit = False
            '''' Initialize the AmpObj with the settings object
            xAxisAmp.InitializeExt(CanOpen, X_AXIS_CAN_ADDRESS, ampSettings)
            '***************************************************
            '* An alternate way of initializing the amplifier with default settings.
            '* To use it, comment out the above initialization code, and
            '* uncomment the following line.
            '***************************************************
            'xAxisAmp.Initialize(CanOpen, X_AXIS_CAN_ADDRESS)


            ' read event sticky clears all initial events
            Dim status As CML_EVENT_STATUS
            xAxisAmp.ReadEventSticky(status)
            statusTextBox.Text = status

            Timer1.Enabled = True
        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            'Read and display actual position 
            posTextBox.Text = xAxisAmp.PositionActual

            'Read and display amplifier status
            Dim status As CML_EVENT_STATUS
            xAxisAmp.ReadEventStatus(status)
            statusTextBox.Text = status

        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub enableButton_Click(sender As Object, e As EventArgs) Handles enableButton.Click
        Try
            If (enableButton.Text = "Amp Disable") Then
                'disable the amp
                xAxisAmp.Disable()
                enableButton.Text = "Amp Enable"
            Else
                'enable the amp
                xAxisAmp.Enable()
                enableButton.Text = "Amp Disable"
            End If

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub readButton_Click(sender As Object, e As EventArgs) Handles readButton.Click
        Try
            Dim stickyStatus As CML_EVENT_STATUS

            'Read event sticky status
            'Note reading event sticky status automatically clears 
            'events which have been set since last read
            xAxisAmp.ReadEventSticky(stickyStatus)
            Dim values As New ArrayList


            If (stickyStatus And CML_EVENT_STATUS.EVENT_STATUS_BRAKE) Then
                values.Add("EVENT_STATUS_BRAKE")
            End If
            If (stickyStatus And CML_EVENT_STATUS.EVENT_STATUS_FAULT) Then
                values.Add("EVENT_STATUS_FAULT")
            End If
            If (stickyStatus And CML_EVENT_STATUS.EVENT_STATUS_NEGATIVE_LIMIT) Then
                values.Add("EVENT_STATUS_NEGATIVE_LIMIT")
            End If
            If (stickyStatus And CML_EVENT_STATUS.EVENT_STATUS_POSITIVE_LIMIT) Then
                values.Add("EVENT_STATUS_POSITIVE_LIMIT")
            End If
            If (stickyStatus And CML_EVENT_STATUS.EVENT_STATUS_PWM_DISABLE) Then
                values.Add("EVENT_STATUS_PWM_DISABLE")
            End If
            If (stickyStatus And CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_DISABLE) Then
                values.Add("EVENT_STATUS_SOFTWARE_DISABLE")
            End If
            If (stickyStatus And CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_LIMIT_NEGATIVE) Then
                values.Add("EVENT_STATUS_SOFTWARE_LIMIT_NEGATIVE")
            End If
            If (stickyStatus And CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_LIMIT_POSITIVE) Then
                values.Add("EVENT_STATUS_SOFTWARE_LIMIT_POSITIVE")
            End If
            'Note all Events are not included for complete list see documentation

            ListBox1.DataSource = values

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub Status_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            xAxisAmp.Disable()

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
