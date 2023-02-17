' Example 12 LSS Rev 1
'
' This program demonstrates the Layer Setting Service (LSS)
' functionality. LSS Is a CANopen protocol used to access
' devices on the network without the node id.
'
' As with any motion product extreme caution must be used! Read And understand
' all parameter settings before attempting to send to amplifier.
'
' Copley Motion Objects are Copyright, 2002-2018, Copley Controls.
'
' for more information on Copley Motion products see:
' http://www.copleycontrols.com
'

Imports System.Threading
Imports CMLCOMLib

Public Class LSS
    '***************************************************
    '*
    '*  CANOpen Network
    '*
    '***************************************************
    Dim canObj As canOpenObj
    Const MAX_DRIVES As Integer = 100
    Const LOG_ALL As Integer = 99
    Dim cmlObj As CopleyMotionLibraryObj

    Dim serial(MAX_DRIVES) As UInt32
    Dim newID(MAX_DRIVES) As Byte
    Dim lssObj As LSSObj

    Dim userBitRate As Integer = 0

    ' Create a delegate to close down the application in a thread safe way
    Delegate Sub CloseApp()

    Private Sub LSS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '**************************************************************************
            '* Turn on logging by setting a CML object
            '**************************************************************************
            cmlObj = New CopleyMotionLibraryObj()
            cmlObj.DebugLevel = LOG_ALL

            '***************************************************
            '
            '  CANOpen Network
            '
            '***************************************************
            canObj = New canOpenObj()
            '
            '**************************************************************************
            '* The next two lines of code are optional. If no bit rate is specified,
            '* then the default bit rate (1 Mbit per second) is used.  If no port name
            '* is specified, then CMO will use the first supported CAN card found and
            '* use channel 0 of that card.
            '**************************************************************************
            '''' Set the bit rate to 1 Mbit per second
            canObj.BitRate = CML_BIT_RATES.BITRATE_1_Mbit_per_sec
            '''' Indicate that channel 0 of a Copley CAN card should be used
            canObj.PortName = "copley0"
            '***************************************************
            '* Initialize the CAN card and network
            '***************************************************
            canObj.Initialize()

            ' Create an LSS Object
            ' LSS (Layer Setting Services) is a CANopen protocol used to
            ' access devices on the network without the node id.
            lssObj = New LSSObj(canObj)

        Catch ex As Exception
            DisplayError(ex)
        End Try
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

    Public Function GetID() As Byte
        Dim nodeInputScreen As NodeInput
        nodeInputScreen = New NodeInput()
        nodeInputScreen.ShowDialog()

        Return nodeInputScreen.nodeID

    End Function

    Private Sub AssignIDsButton_Click(sender As Object, e As EventArgs) Handles AssignIDsButton.Click
        Try
            ' Save the user specified bit rate.
            userBitRate = Convert.ToInt32(BitRateTextBox.Text)
            lssObj.userBitRate = userBitRate

            ' Search for the nodes and turn off CAN LEDs.
            Dim ampCount As Integer
            ampCount = lssObj.FindAndDisableAmps(serial)

            ' Enable the nodes one at a time to blink the lights
            ' and get the desired node IDs.
            For i As Integer = 0 To ampCount - 1
                ' Enable the node
                lssObj.EnableAmplifier(serial(i))

                ' Get the desired ID.
                newID(i) = GetID()

                ' Turn the CAN LEDs off.
                lssObj.DisableAmplifier(serial(i))
            Next

            ' Set all of the node IDs and activate the new bit rate.
            lssObj.SetAllAmplifierNodeIDs(serial, newID)

            ' Re-initialize the CAN object with the new bit rate.
            ' Since the CAN object is being re-initialized, the
            ' LSS object needs to be re-initialized as well.
            canObj.Dispose()
            lssObj.Dispose()

            ' Give time for the CAN and LSS objects to properly close.
            Thread.Sleep(200)
            canObj = New canOpenObj()
            canObj.BitRate = userBitRate
            canObj.PortName = "copley0"
            canObj.Initialize()
            lssObj = New LSSObj(canObj)

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub
End Class
