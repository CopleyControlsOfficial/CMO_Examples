'
' Example 9 Indexer register via SDO Rev 3
'
' This program demonstrates how to set and read and indexer register using
' the SDO_Upld and SDO_Dnld methods in the AmpObj
'
'
' This program assumes the following axis configuration:
' 1. Upon startup it will enable axis at Can Node ID 1.
'
' This code also includes the following prerequisites:
' 1. The amplifier and motor must be preconfigured and set up properly to run.
' 2. The hardware enable switch must be installed and easily accessible
' 
' As with any motion product extreme caution must used! Read and understand
' all parameter settings before attemping to send to amplifier.
'
'
' Copley Motion Objects are Copyright, 2006-2018, Copley Controls.
'
' For more information on Copley Motion products see:
' http://www.copleycontrols.com
'
Imports CMLCOMLib

Public Class IndexerReg
    Inherits System.Windows.Forms.Form

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

    ' Create a delegate to close down the application in a thread safe way
    Delegate Sub CloseApp()

    Private Sub IndexerReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '**************************************************************************
            '* Turn on logging by setting a CML object
            '**************************************************************************
            cmlObj = New CopleyMotionLibraryObj()
            cmlObj.DebugLevel = LOG_ALL


            ampObj = New AmpObj()

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



        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub cmdRead_Click(sender As Object, e As EventArgs) Handles cmdRead.Click
        Dim Data As Integer
        Dim ObjectID As Short
        Dim SubIndex As Short

        'CAN object ID for the Indexer Registers is 0x2600 (9728 decimal) 
        ObjectID = 9728

        'Each sub index of this object contains a register value.  Sub index 1               contains the value in register 0.
        SubIndex = Val(txtRegisterNumber.Text) + 1

        Try

            'Use the SDO_Upld method to read the value in the amplifiers register.
            ampObj.SDO_Upld(ObjectID, SubIndex, Data)

            txtReadData().Text = Data

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub cmdWrite_Click(sender As Object, e As EventArgs) Handles cmdWrite.Click
        Dim Data As Integer
        Dim SubIndex As Short
        Dim ObjectID As Short

        'CAN object ID for the Indexer Registers is 0x2600 (9728 decimal) 
        ObjectID = 9728

        'Each sub index of this object contains a register value.  Sub index 1 contains the value in register 0.
        SubIndex = Val(txtRegisterNumber.Text) + 1

        Try

            Data = Val(txtWriteData.Text)
            'Use the SDO_Dnld method to write the value to the amplifier's register.
            ampObj.SDO_Dnld(ObjectID, SubIndex, Data)

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
