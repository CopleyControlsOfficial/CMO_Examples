Imports System.Threading
'
' Example 12 PDO Mapping Rev 3
'
' This program demonstrates Copley Motion PDO Mapping to a CANopen node
'
' The purpose of this lab Is to show how to map a transmit/receive PDO
' to a CANopen node using CMO.
'
' This program assumes the following axis configuration:
' 1. Upon startup it will enable one axis at Can Node ID 1.
' 
' As with any motion product extreme caution must used! Read And understand
' all parameter settings before attemping to send to amplifier.
'
' Copley Motion Objects are Copyright, 2002-2021, Copley Controls.
'
' for more information on Copley Motion products see:
' http://www.copleycontrols.com
'
Imports CMLCOMLib

Public Class PDOmapping
    '***************************************************
    '*
    '*  CANOpen Network
    '*
    '***************************************************
    Const X_AXIS_CAN_ADDRESS As Integer = 1
    Dim CanOpen As canOpenObj

    Const LOG_ALL As Integer = 99
    Dim cmlObj As CopleyMotionLibraryObj

    Dim amp As AmpObj
    Dim tpdo As TPDOObj
    Dim tpdoPmap(1) As PmapObj
    Dim tpdoObjID(1) As Int32
    Dim tpdoObjIdSub(1) As Int32
    Const ANALOG_REF_INDEX As Integer = 0
    Const ACT_POSITION_INDEX As Integer = 1

    Dim rpdoOff As RPDOObj
    Dim rpdoPmap(0) As PmapObj
    Dim rpdoObjID(0) As Int32
    Dim rpdoObjIdSub(0) As Int32
    Dim newData(0) As Int32
    Const OFFSET_INDEX As Integer = 0

    Dim displayTPDOdata As Thread
    Dim KeepPrinting As Boolean = True
    Dim ampSettings As ampSettingsObj

    ' Create a delegate to updateGui down the application in a thread safe way
    Delegate Sub UpdateGui()
    ' Create a delegate to close down the application in a thread safe way
    Delegate Sub CloseApp()

    Private Sub PDOmapping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '**************************************************************************
            '* Turn on logging by setting a CML object
            '**************************************************************************
            cmlObj = New CopleyMotionLibraryObj()
            cmlObj.DebugLevel = LOG_ALL

            'Initialize code here
            amp = New AmpObj()

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
            'amp.Initialize(CanOpen, X_AXIS_CAN_ADDRESS)
            ampSettings = New ampSettingsObj
            ampSettings.guardTime = 0
            amp.InitializeExt(CanOpen, X_AXIS_CAN_ADDRESS, ampSettings)



            '***************************************************
            '
            '  Transmit PDO
            '
            '***************************************************
            tpdo = New TPDOObj()
            ''
            '****************************************************************
            '* Create an array of the objects to be mapped to this TPDO
            '* Each PDO can hold up to 8 bytes of data and a max of 4 objects
            '* The Pmap size corresponds to the size of the data (8, 16, 24, or 32)
            '****************************************************************
            tpdoPmap(ANALOG_REF_INDEX) = New Pmap16Obj
            tpdoPmap(ACT_POSITION_INDEX) = New Pmap32Obj
            '****************************************************************
            '* Create an array of the corresponding CAN object IDs
            '****************************************************************
            tpdoObjID(ANALOG_REF_INDEX) = &H2200
            tpdoObjID(ACT_POSITION_INDEX) = &H6064

            '****************************************************************
            '* Create an array of the corresponding CAN object ID subindexes
            '****************************************************************
            tpdoObjIdSub(ANALOG_REF_INDEX) = 0
            tpdoObjIdSub(ACT_POSITION_INDEX) = 0

            '****************************************************************
            '* Configure the transmit PDO.
            '* The second parameter gives the PDO slot to use. The amps have
            '* 8 transmit And 8 receive PDOs so this number should range
            '* from 0 - 7. CMO uses transmit PDO slots 0, 1, And 4, so those
            '* should not be used for custom PDOs. The third parameter Is a
            '* CAN message ID to use. This needs to be unique in the system.
            '* It Is simplest to use an extended message ID (i.e. one with
            '* bit 29 set) since it will not clash with any standar CAN ID
            '* used in the system.
            '****************************************************************
            ' This function assumes all object IDs have a subindex of 0.
            'tpdo.Init(&H20000001, tpdoPmap, tpdoObjID, 1)

            ' This function allows non-zero subindexes.
            tpdo.Init(&H20000001, tpdoPmap, tpdoObjID, tpdoObjIdSub, 1)
            ' Optionally, the RTR can be turned off (defaults to on). 0 turns
            ' it off and any non - zero value turns it back on.
            'tpdo.SetRtrOk(0)
            ''
            '****************************************************************
            '* Attach the TPDO to the node.
            '* The first parameter gives the PDO slot to use. The amps have 8
            '* transmit And 8 receive PDOs so this number should range
            '* from 0 - 7. CMO uses transmit PDO slots 0, 1, And 4, so those
            '* should not be used for custom PDOs.
            '****************************************************************
            amp.SetTpdo(2, tpdo)



            '***************************************************
            '
            '  Receive PDO
            '
            '***************************************************
            rpdoOff = New RPDOObj()
            ''
            '****************************************************************
            '* Create an array of the objects to be mapped to this TPDO
            '* Each PDO can hold up to 8 bytes of data and a max of 4 objects
            '*The Pmap size corresponds to the size of the data (8, 16, 24, or 32)
            '****************************************************************
            rpdoPmap(OFFSET_INDEX) = New Pmap16Obj()
            ''
            '****************************************************************
            '* Create an array of the corresponding CAN object IDs
            '****************************************************************
            rpdoObjID(OFFSET_INDEX) = &H2311

            '****************************************************************
            '* Create an array of the corresponding CAN object ID subindexes
            '****************************************************************
            rpdoObjIdSub(OFFSET_INDEX) = 0
            ''
            '****************************************************************
            '* Configure the receive PDO.
            '* Again, CAN ID should be unique. Easiest is to use an extended
            '* ID (bit 29). The fourth parameter is the type. Set transmit
            '* type to 255. This causes the PDO to be acted on immediately.
            '****************************************************************
            ' This function assumes all object IUDs have a subindex of 0.
            'rpdoOff.Init(&H20000101, rpdoPmap, rpdoObjID, 255)

            ' This function allows non-zero subindexes.
            rpdoOff.Init(&H20000101, rpdoPmap, rpdoObjID, rpdoObjIdSub, 255)
            ''
            '****************************************************************
            '* Attach the TPDO to the node.
            '* CMO uses RPDO slots 0, 1, and 4 so I should use slot numbers
            '* 2, 3, 5-7.
            '****************************************************************
            amp.SetRpdo(2, rpdoOff)



            ' Start a thread to display the values
            displayTPDOdata = New Thread(AddressOf DisplayOffset)
            displayTPDOdata.Start()

            ' Create an array of the data, these should correspond to the
            ' rpdo mapping.
            newData(OFFSET_INDEX) = 0

            ' Send a PDO to reset the A/D offset on the drive to 0
            ' The second parameter is the indexes of the pdo objects to 
            ' send. i.e. 1 sends index 0, 2 sends index 1, 3 sends indexes
            ' 0 and 1, etc.
            rpdoOff.SendData(newData, 1)

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub DisplayOffset()
        Try
            Do
                ThreadSafeUpdateGUI()
                Thread.Sleep(1)
            Loop While KeepPrinting
        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Public Sub StopDisplayThread()
        KeepPrinting = False
    End Sub

    Public Sub ThreadSafeUpdateGUI()
        If Me.InvokeRequired Then
            Dim g As New UpdateGui(AddressOf ThreadSafeUpdateGUI)
            Me.Invoke(g)
        Else
            AlogRefTextBox.Text = tpdo.data(ANALOG_REF_INDEX).ToString()
            PositionTextBox.Text = tpdo.data(ACT_POSITION_INDEX).ToString()
        End If
    End Sub

    Public Sub DisplayError(ByVal ex As Exception)
        Dim errormsgbox As Short

        errormsgbox = MsgBox("Error Message: " & ex.Message & vbCr & "Error Source: " & ex.Source, MsgBoxStyle.OkCancel)
        If errormsgbox = MsgBoxResult.Cancel Then
            ' it is possible that this method was called from a thread other than the
            ' GUI thread - if this is the case we must use a delegate to close the application
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

    Private Sub SendOffsetButton_Click(sender As Object, e As EventArgs) Handles SendOffsetButton.Click
        Try
            newData(OFFSET_INDEX) += 100
            rpdoOff.SendData(newData, 1)
        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub SaveMappingToFlashButton_Click(sender As Object, e As EventArgs) Handles SaveMappingToFlashButton.Click
        Try
            ' This saves the PDO mapping to flash.
            ' Passing true saves the communications parameters to flash
            ' in addition to the PDO mapping.
            amp.SavePDOmappingToFlash(False)
        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub PDOmapping_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            StopDisplayThread()
            Application.DoEvents()
        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub
End Class
