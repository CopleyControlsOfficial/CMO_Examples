Imports System.Threading

' Example 7 Trace Rev 4
'
' This program demonstrates the use of the amplifier's trace functionality
' by using the trace methods and properties of CMO.  The trace is a
' valuable tool because it allows data (e.g velocity, position, etc.) to
' be collected by the amplifier, then read from the amplifier over the
' CAN bus network for analysis.
' 
' Trace configuration:
'   Before using the trace, it must be configured.  The InitTraceData()
'   method of this program performs the trace configuration.  This is done
'   by:
'      1) Read all of the trace settings from the amplifier.
'      2) Set up the trace variables to indicate to the amplifier what data
'         is to be collected.
'      3) Get the maximum samples that can be collected (this value changes 
'         based on how many and what type of trace variables are chosen).
'      4) Set up the trace trigger.  This will determine what condition must
'         be met before the trace data will be collected from the amplifier.
' The trace settings used by this program are:
'   Trace Variables: Channels 0 and 1 are set to actual current and bus voltage.
'   Trigger: Set up to trigger when the amplifier's software enable changes from
'   disabled to enabled.
'   
'
' Running the trace:
'   Running the trace consists of:
'      1) Sending a command to the amplifier to start the trace.  The amplifier
'         will start sampling data to monitor for the trigger.
'      2) Monitor the trace status to see when the trigger occurs and when the 
'         amplifier is finished collecting data.
'      3) Read the trace data from the amplifier after both condition of step 2
'         are met.
'   This program uses a thread for steps 2 and 3 above, because polling the
'   trace status can be processor intensive and without a thread doing the work,
'   the GUI may become unresponsive.
'   Once the data is read in from the amplifier, this program saves it to a file
'   in a comma-separated value format, so that it can be opened in a spreadsheet
'   type of program for analysis.
'
'
' Using this program:
'   Once the program has been started, the GUI will display all of the trace
'   settings and the amplifier will be disabled (done in the Form1_Load() method).
'   Press the Start button to start the amplifier's trace. This will also start the
'   thread in this program that monitors the trace status and collects data. To 
'   trigger the trace, press the Amp Enable button.  This will cause the trace to 
'   trigger because the trigger was setup to trigger when the amplifier software 
'   enable goes from disabled to enabled.  Once the data is collected, it is written
'   to a file that can be opened in a spreadsheet type of program.
'
'
' Copley Motion Objects are Copyright, 2005-2018, Copley Controls Corp.
'
' For more information on Copley Motion products see:
' http://www.copleycontrols.com
'
Imports CMLCOMLib

Public Class Trace
    Inherits System.Windows.Forms.Form

    '***************************************************
    '*
    '*  CANOpen Network
    '*
    '***************************************************
    Const CAN_ADDRESS As Integer = 1
    Dim CanOpen As canOpenObj

    Const LOG_ALL As Integer = 99
    Dim cmlObj As CopleyMotionLibraryObj

    Dim Amp As AmpObj


    Dim EventStatus As CML_EVENT_STATUS

    Const CHANNEL0 As Integer = 0
    Const CHANNEL1 As Integer = 1

    Const ACTIVE_CHANNEL_COUNT As Integer = 2

    Dim AmpTraceStatus As CML_AMP_TRACE_STATUS
    Dim AmpSamplesCollected As Short
    Dim AmpMaxChannels As Short
    Dim AmpTraceRefPeriod As Integer
    Dim AmpMaxSamples As Short
    Dim AmpTracePeriod As Short
    Dim CalcTotalTraceTime As Integer

    Dim AmpChan1Var As CML_AMP_TRACE_VAR
    Dim AmpChan2Var As CML_AMP_TRACE_VAR

    Dim AmpTrigType As CML_AMP_TRACE_TRIGGER
    Dim AmpTrigChan As Short
    Dim AmpTrigLevel As Integer
    Dim AmpTrigDelay As Short

    Public TraceData() As Integer
    Public DataCount As Integer

    Dim TraceThread As Threading.Thread

    ' Create a delegate to updateGui down the application in a thread safe way
    Delegate Sub UpdateButton(ByVal enabled As Boolean)
    ' Create a delegate to updateGui down the application in a thread safe way
    Delegate Sub UpdateText(ByVal text As String)
    ' Create a delegate to close down the application in a thread safe way
    Delegate Sub CloseApp()

    Private Sub Trace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '**************************************************************************
            '* Turn on logging by setting a CML object
            '**************************************************************************
            cmlObj = New CopleyMotionLibraryObj()
            cmlObj.DebugLevel = LOG_ALL


            Amp = New AmpObj


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
            Amp.Initialize(CanOpen, CAN_ADDRESS)


            InitTraceData()

            InitGUI()

            Amp.Disable()

            Timer1.Enabled = True

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub Trace_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            StopTrace()

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub InitTraceData()
        Try
            ' These values need to be read first 
            Amp.ReadTraceRefPeriod(AmpTraceRefPeriod) 'the minimum rate at which the amplifier collects data
            Amp.ReadTraceMaxChannel(AmpMaxChannels)

            ' //////////////////////////////////////////////////////////////////////
            ' Read the rest of the trace settings from the amplifier
            ' //////////////////////////////////////////////////////////////////////
            Amp.ReadTraceStatus(AmpTraceStatus, AmpSamplesCollected, AmpMaxSamples)
            Amp.ReadTracePeriod(AmpTracePeriod)
            Amp.ReadTraceChannel(CHANNEL0, AmpChan1Var)
            Amp.ReadTraceChannel(CHANNEL1, AmpChan2Var)
            Amp.ReadTraceTrigger(AmpTrigType, AmpTrigChan, AmpTrigLevel, AmpTrigDelay)

            ' //////////////////////////////////////////////////////////////////////
            '           Now change the trace settings for our example
            ' //////////////////////////////////////////////////////////////////////

            ' set up channel 1 for actual current and channel 2 for bus voltage
            AmpChan1Var = CML_AMP_TRACE_VAR.TRACEVAR_CRNT_ACT_Q
            AmpChan2Var = CML_AMP_TRACE_VAR.TRACEVAR_HIGH_VOLT
            Amp.WriteTraceChannel(CHANNEL0, AmpChan1Var)
            Amp.WriteTraceChannel(CHANNEL1, AmpChan2Var)

            ' Set all of the remaining channels to 0 to ensure that nothing else is traced
            Dim channel As Integer
            channel = CHANNEL1 + 1
            Do While channel < AmpMaxChannels
                Amp.WriteTraceChannel(channel, 0)
                channel = channel + 1
            Loop

            ' Now that the trace variables have been set up, read in the trace status so
            ' that we can get the max samples per channel.  The value of max samples varies 
            ' depending upon how many trace variables are chosen and what types are chosen.  
            ' This value should be obtained each time the trace variables are changed.
            Amp.ReadTraceStatus(AmpTraceStatus, AmpSamplesCollected, AmpMaxSamples)

            ' Set up the array size based upon how many samples can be collected.  We need to
            ' multiply AmpMaxSamples by the number of active channels (2 in our case) because
            ' the array will contain the data for all channels
            ReDim TraceData(AmpMaxSamples * ACTIVE_CHANNEL_COUNT)

            ' ///////////////////////////////////////////////////////////////////////////////
            ' 
            ' Calculate the maximum trace time allowed based on the values of 
            '     Trace Ref Period - The minimum sample time that the amplifier can collect 
            '                        samples
            '     Trace Period     - The period at which the amplifier will collect samples.
            '                        It is an integer multiple of the Trace Ref Period
            '     Max Samples      - The maximum number of samples that can be held in the 
            '                        amplifier's internal trace buffer.  This number varies with
            '                        the number and type of trace variables set.
            ' 
            ' The maximum trace time = TraceRefPeriod * TracePeriod * MaxSamples
            ' This value is in nanoseconds.  Since the GUI displays milliseconds, we
            ' need to do a conversion.
            '
            ' ///////////////////////////////////////////////////////////////////////////////
            CalcTotalTraceTime = (AmpTraceRefPeriod * 0.000001) * AmpTracePeriod * AmpMaxSamples

            ' ///////////////////////////////////////////////////////////////////////////////
            ' set up the trace to trigger on a software enable of the amplifier with a negative 
            ' delay of 10% of max number of samples.  Setting a negative delay in this manner 
            ' results in capturing 10% of the waveform before the trigger occurs.
            ' //////////////////////////////////////////////////////////////////////////////
            AmpTrigChan = CHANNEL0
            AmpTrigType = CML_AMP_TRACE_TRIGGER.TRACETRIG_EVENTCLR
            AmpTrigLevel = &H1000 ' Event Status bit 12 = software enable
            AmpTrigDelay = AmpMaxSamples * -0.1  ' negative delay of 10% of max number of samples
            Amp.WriteTraceTrigger(AmpTrigType, AmpTrigChan, AmpTrigLevel, AmpTrigDelay)

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub InitGUI()
        Try
            ' initialized the values on the GUI
            TraceRefPeriodValue.Text = AmpTraceRefPeriod
            TracePeriodTextBox.Text = AmpTracePeriod
            MaxSamplesValue.Text = AmpMaxSamples
            TotalTraceTimeValue.Text = CalcTotalTraceTime

            TraceStatusValue.Text = "Ready"

            TrigTypeTextBox.Text = AmpTrigType
            TrigChannelTextBox.Text = AmpTrigChan
            TrigLevelTextBox.Text = AmpTrigLevel
            TrigDelayTextBox.Text = AmpTrigDelay

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub StartTraceButton_Click(sender As Object, e As EventArgs) Handles StartTraceButton.Click
        Try
            ' Create the new thread object and use the RunTrace() method in this file as
            ' the thread
            TraceThread = New Threading.Thread(AddressOf RunTrace)

            ' Start the trace in the amplifier
            Amp.TraceStart()

            ' Start the thread
            TraceThread.Start()

            StartTraceButton.Enabled = False

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub StopTraceButton_Click(sender As Object, e As EventArgs) Handles StopTraceButton.Click
        Try
            StopTrace()

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub StopTrace()
        Try
            StartTraceButton.Enabled = True
            TraceStatusValue.Text = "Ready"

            Amp.TraceStop()

            ' If the thread object has not been made or it is not running, then no need
            ' to do anything more.
            If TraceThread Is Nothing Then
                Exit Sub
            End If
            ' if the thread has already been aborted, then don't try to abort it again
            If TraceThread.ThreadState = Threading.ThreadState.Aborted Then
                Exit Sub
            End If

            TraceThread = Nothing
        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            ' Read the amplifier's event status word to get the state of the "amplifier
            ' disabled by software" bit
            Amp.ReadEventStatus(EventStatus)
            If (EventStatus And CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_DISABLE) = CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_DISABLE Then
                EnableDisableButton.Text = "Amp Enable"
            Else
                EnableDisableButton.Text = "Amp Disable"
            End If

        Catch ex As Exception
            Timer1.Stop()
            DisplayError(ex)
        End Try
    End Sub

    Private Sub SendPeriodButton_Click(sender As Object, e As EventArgs) Handles SendPeriodButton.Click
        Try
            ' Get the new value from the GUI
            AmpTracePeriod = TracePeriodTextBox.Text

            ' Write it to the amplifier
            Amp.WriteTracePeriod(AmpTracePeriod)

            ' Now calculate the total trace time and display it on the GUI.
            CalcTotalTraceTime = (AmpTraceRefPeriod * 0.000001) * AmpTracePeriod * AmpMaxSamples
            TotalTraceTimeValue.Text = CalcTotalTraceTime

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub SendTrigSettingsButton_Click(sender As Object, e As EventArgs) Handles SendTrigSettingsButton.Click
        Try
            ' get all of the values from the GUI
            AmpTrigDelay = TrigDelayTextBox.Text
            AmpTrigLevel = TrigLevelTextBox.Text
            AmpTrigChan = TrigChannelTextBox.Text
            AmpTrigType = TrigTypeTextBox.Text

            ' Send the trigger settings to the amplifier
            Amp.WriteTraceTrigger(AmpTrigType, AmpTrigChan, AmpTrigLevel, AmpTrigDelay)

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub EnableDisableButton_Click(sender As Object, e As EventArgs) Handles EnableDisableButton.Click
        Try
            If (EventStatus And CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_DISABLE) = CML_EVENT_STATUS.EVENT_STATUS_SOFTWARE_DISABLE Then
                Amp.Enable()
            Else
                Amp.Disable()
            End If

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub RunTrace()
        ' Create file for the trace data to be viewed in a spreadsheet type of program.
        ' The file location will be in the same folder as the project file for this 
        ' program.
        Dim file As System.IO.StreamWriter

        Try
            ' Wait for the trigger to occur

            ' Since this thread is different from the GUI thread we must use a delegate
            ' to call a method to update the GUI component (TraceStatusValue)
            Dim textDelegate As New UpdateText(AddressOf UpdateTraceStatus)
            TraceStatusValue.Invoke(textDelegate, "Waiting for Trigger.")

            Do
                Amp.ReadTraceStatus(AmpTraceStatus, AmpSamplesCollected, AmpMaxSamples)
            Loop While (((AmpTraceStatus And CML_AMP_TRACE_STATUS.TRACE_STATUS_TRIGGERED) <> CML_AMP_TRACE_STATUS.TRACE_STATUS_TRIGGERED) And TraceThread IsNot Nothing)

            ' This is null when the trace has stopped without triggering.
            If TraceThread Is Nothing Then
                Exit Sub
            End If

            ' Since this thread is different from the GUI thread we must use a delegate
            ' to call a method to update the GUI component (TraceStatusValue)
            TraceStatusValue.Invoke(textDelegate, "Amplifier is collecting data.")

            Do
                Amp.ReadTraceStatus(AmpTraceStatus, AmpSamplesCollected, AmpMaxSamples)
            Loop While (((AmpTraceStatus And CML_AMP_TRACE_STATUS.TRACE_STATUS_RUNNING) = CML_AMP_TRACE_STATUS.TRACE_STATUS_RUNNING) And TraceThread IsNot Nothing)

            If TraceThread Is Nothing Then
                Exit Sub
            End If

            ' Read in the trace data from the amp

            ' Since this thread is different from the GUI thread we must use a delegate
            ' to call a method to update the GUI component (TraceStatusValue)
            TraceStatusValue.Invoke(textDelegate, "Reading trace data from amplifier.")

            ' Keeps a running total of all of the samples collected so far
            Dim TotalSamplesReceived As Integer

            ' Request the max number of samples - the amplifier will let us know how many samples
            ' it returned in the ReadTraceData method.  Since AmpMaxSamples is per channel and
            ' the array will contain data for both channels, we have to multiply AmpMaxSamples 
            ' by 2 (number of active channels) to get the total number of data points available
            DataCount = AmpMaxSamples * ACTIVE_CHANNEL_COUNT

            file = New System.IO.StreamWriter("..\TraceData.csv")

            ' Keep reading data until we get all of it
            Do While TotalSamplesReceived < DataCount

                ' Read the trace data.  When calling ReadTraceData, DataCount contains how 
                ' many samples we want.
                ' When returning from the method call, DataCount contains the actual number
                ' of samples returned by the amplifier.
                '
                ' The data for both channels are contained within the TraceData array. Therefore
                ' if two channels are used and the max samples is 1024, then there are 512
                ' data points for each channel.
                '
                ' The data is arranged in the array as follows (assuming two channels were used):
                ' Chan1|Chan2|Chan1|Chan2...
                Amp.ReadTraceData((TraceData), DataCount)

                ' Now write all of the data to a file.  The file is written in a comma-
                ' separated value (CSV) form consisting of three values. The first value is
                ' time, the second and third values are channel 1 and and channel 2 respectively.
                Dim SampleNumber As Integer 'used in calculating the time for the file
                SampleNumber = 0
                For I As Integer = 0 To DataCount - 1 Step 2
                    ' The amplifier only returns the data that was requested when the trace
                    ' variables were set up. It does not return the time at which the data
                    ' was collected.  However, the times can be calculated because the rate 
                    ' at which the data was collected is known (TraceRefPeriod * TracePeriiod).
                    ' Using this information the time at which each sample was collected can 
                    ' be calculated.

                    ' Calculate the time that this sample was taken (convert to milliseconds)
                    ' and write it to the file.
                    file.Write((SampleNumber * AmpTraceRefPeriod * 0.000001 * AmpTracePeriod))
                    file.Write(",")

                    ' Write the data from channel 1
                    file.Write(TraceData(I))
                    file.Write(",")

                    ' Write the data from channel 2
                    file.Write(TraceData(I + 1))
                    file.WriteLine()

                    SampleNumber = SampleNumber + 1
                Next

                TotalSamplesReceived = TotalSamplesReceived + DataCount

            Loop

            file.Close()

            Dim buttonDelegate As New UpdateButton(AddressOf EnableStartTraceButton)
            StartTraceButton.Invoke(buttonDelegate, True)

            ' Since this thread is different from the GUI thread we must use a delegate
            ' to call a method to update the GUI component (TraceStatusValue)
            TraceStatusValue.Invoke(textDelegate, "Ready.")

        Catch ex As Exception
            If file Is Nothing Then
            Else
                file.Close()
            End If
            DisplayError(ex)
        End Try
    End Sub

    Public Sub EnableStartTraceButton(ByVal enabled As Boolean)
        ' If the calling thread is different than the GUI thread, then use the
        ' delegate to update the trace status, otherwise use the gui control directly
        If StartTraceButton.InvokeRequired Then
            Dim d As New UpdateButton(AddressOf EnableStartTraceButton)
            StartTraceButton.Invoke(d, enabled)
        Else
            StartTraceButton.Enabled = enabled
        End If
    End Sub

    Public Sub UpdateTraceStatus(ByVal text As String)
        ' If the calling thread is different than the GUI thread, then use the
        ' delegate to update the trace status, otherwise use the gui control directly
        If TraceStatusValue.InvokeRequired Then
            Dim d As New UpdateText(AddressOf UpdateTraceStatus)
            TraceStatusValue.Invoke(d, text)
        Else
            TraceStatusValue.Text = text
        End If
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
