'
' Example 12 Position Triggered Output Rev 0
'
' This program demonstrates how to configure two types of position triggered 
' outputs: Software Triggered And Hardware Triggered. Non-PLUS drives do not
' support hardware triggered And thus, must use the slower software triggered
' configuration. 
'
' Please first read App Note 137 "Setting Outputs At Position" desribing
' the details of the various configurations of the position triggered outputs.
'
' There can only be one hardware position triggered output per axis.
' The hardware position triggered output reacts in 10's of nanoseconds to a change
' in position. Please consult pages 4 & 5 of AppNote 137 for the list of parameters
' needed to properly configure a hardware position triggered output.
'
' The software position triggered outputs can be used on any output. They do not have as 
' fast a reaction time as the hardware triggered type but are useful if multiple outputs
' per axis need to react to a change in position. To configure a software position triggered 
' output, multiple 32-bit words may need to be written to the output. Therefore, CMO has to 
' use serial binary over CAN to accomplish this action.
'
' This program assumes the following axis configuration:
' 1. Upon startup it will enable one axis at Can Node ID 1.
' 2. The motor has an encoder properly configured in CME.
'
' The code also includes the following prerequisites:
' 1. The amplifier and motor must be preconfigured and set up properly to run.
' 2. The hardware enable switch must be installed on the amplifier and easily 
'    accessible.
' 
' As with any motion product extreme caution must used! Read and understand
' all parameter settings before attemping to send to amplifier.
'
' Copley Motion Objects are Copyright, 2002-2021, Copley Controls.
'
' For more information on Copley Motion products see
' http://www.copleycontrols.com
'
Imports System.Threading
Imports System.IO
Imports CMLCOMLib

Public Class PositionTriggeredOutput
    Inherits System.Windows.Forms.Form

    '***************************************************
    '*
    '*  CANOpen Network
    '*
    '***************************************************

    ' assign Node ID's for each axis
    Const X_AXIS_CAN_ADDRESS As Integer = 1

    Dim CanOpen As canOpenObj
    Dim ObjectID As Short
    Dim SubIndex As Short
    Dim Data As Int32
    Dim Data_Size As Short

    ' create a debug log of all messages
    Const LOG_ALL As Integer = 99
    Dim cmlObj As CopleyMotionLibraryObj

    ' create the Amp Object and an ampSettings Object
    Dim Amp As AmpObj
    Dim ampSettings As ampSettingsObj

    ' Create a delegate to close down the application in a thread safe way
    Delegate Sub CloseApp()

    Private Sub PositionTriggeredOutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '**************************************************************************
            '* Turn on logging by setting a CML object
            '**************************************************************************
            cmlObj = New CopleyMotionLibraryObj()
            cmlObj.DebugLevel = LOG_ALL

            'Initialize code here

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
            '**************************************************************************
            '* Initialize the amplifier.
            '**************************************************************************
            Amp.Initialize(CanOpen, X_AXIS_CAN_ADDRESS)

            ' Enable the GUI components
            HardwarePositionTriggeredOutputButton.Enabled = True
            SoftwarePositionTriggeredOutputButton.Enabled = True

        Catch ex As Exception
            DisplayError(ex)
        End Try

    End Sub

    Private Sub ConfigureHardwarePositionTriggeredOutputButton_Click(sender As Object, e As EventArgs) Handles HardwarePositionTriggeredOutputButton.Click
        Try

            ' Set 0x70 (Output 1 Configuration) to 16 = Hardware Position Triggered
            ObjectID = 8595 ' CANopen Object Index = 0x2193 = 8595 decimal
            SubIndex = 1
            Data = Convert.ToInt32(16)
            Amp.SDO_Dnld(ObjectID, SubIndex, Data)

            ' Set Compare Module Configuration to 17 = Bits 0 And 4 are set = Enable the module And use Mode 2 "Set In Position Window"
            ObjectID = 8544 ' CANopen Object Index = 0x2160 = 8544 decimal
            SubIndex = 0
            Data = Convert.ToInt32(17)
            Amp.SDO_Dnld(ObjectID, SubIndex, Data)

            ' Set the Compare Value Lower Bound Position = 4,660 counts
            ObjectID = 8546 ' CANopen Object Index = 0x2162 = 8546 decimal
            SubIndex = 0
            Data = Convert.ToInt32(4660)
            Amp.SDO_Dnld(ObjectID, SubIndex, Data)

            ' Set the Compare Value Upper Bound Position = 305,419,896 counts
            ObjectID = 8547 ' CANopen Object Index = 0x2163 = 8547 decimal
            SubIndex = 0
            Data = Convert.ToInt32(305419896)
            Amp.SDO_Dnld(ObjectID, SubIndex, Data)

            ''Set the Compare Increment. If in Mode 0, the compare increment must equal 2*(upper_compare_value - lower_compare_value)
            ''In this case, (305419896-4660)*2 = 610830472
            'ObjectID = 8548 ' CANopen Object Index = 0x2164 = 8548 decimal
            'SubIndex = 0
            'Data = Convert.ToInt32(610830472)
            'Amp.SDO_Dnld(ObjectID, SubIndex, Data)

            ''Set Time Delay (time of output firing) in tens of nanoseconds
            'ObjectID = 8549 ' CANopen Object Index = 0x2165 = 8549 decimal
            'SubIndex = 0
            'Data = Convert.ToInt32(762144)
            'Amp.SDO_Dnld(ObjectID, SubIndex, Data)


        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    ' To configure software position triggered outputs for non-plus drives, use the following.
    ' The code below sets up output 1 to trigger while in position window 4660-305419896 counts. 
    ' 4,660 in decimal Is 0x1234 in hex. 305,419,896 in decimal Is 0x12345678 in hex.
    ' ASCII Command Equivalent: s r0x70 4 0x1234 0x12345678 
    Private Sub ConfigureSoftwarePositionTriggeredOutput_Click(sender As Object, e As EventArgs) Handles SoftwarePositionTriggeredOutputButton.Click
        Try
            ObjectID = 8192 ' 8192 decimal = 0x2000 hex (CANopen Object ID = 0x2000)
            SubIndex = 0
            Data_Size = 13
            Dim Bytes(Data_Size) As Byte

            Bytes(0) = 13  ' op-code 13 for "set" command ; Each word after this byte is byte swapped.                 
            Bytes(1) = 112 ' Output 1 Is 0x70 ; CANopen ID for 0x70 Is 0x2193.1 ; To see how many outputs are on drive, read sub-index 0.
            Bytes(2) = 0   ' Rest Of word Is 0x00  -- 0x0070 = OUT1
            Bytes(3) = 4
            Bytes(4) = 0   ' Output Config = 0x0004 = trigger while in position window
            Bytes(5) = 0
            Bytes(6) = 0
            Bytes(7) = 52 ' 0x34
            Bytes(8) = 18 ' 0x12. 32-bit word = 0x00001234 = 4,660 counts for lower bound 
            Bytes(9) = 52 ' 0x34
            Bytes(10) = 18 ' 0x12
            Bytes(11) = 120 ' 0x78
            Bytes(12) = 86 ' 0x56. 32-bit word = 0x12345678 = 305,419,896 counts for lower bound 
            Amp.SDO_DnldExt(ObjectID, SubIndex, Bytes, Data_Size)
        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub PositionTriggeredOutput_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Amp.Disable()

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
