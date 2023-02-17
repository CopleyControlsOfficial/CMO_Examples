'  Example 4 Linkage Rev 4
'
' This program demonstrates linkage moves (coordinated motion on multiple axes)
'
' The program allows the target positions for two axis to be set and 
' the user can then perform a linkage (coordinated) move
' to that set of positions.
'
' This program assumes the following axis configuration:
' 1. Upon startup it will enable one axis at Can Node ID 1 and
'    one at Can Node ID 2.
' 2. Both motors have an encoders with an index

'
' This code also includes the following prerequisites:
' 1. The both amplifiers and motors must be preconfigured and set up properly to run.
' 2. The hardware enable switch must be installed on both amplifiers 
' and both are easily accessible
' 
' As with any motion product extreme caution must used! Read and understand
' all parameter settings before attempting to send to amplifier.
' 
' Copley Motion Objects are Copyright, 2002-2018, Copley Controls.
'
' For more information on Copley Motion products see:
' http://www.copleycontrols.com
'
Imports CMLCOMLib

Public Class Linkage
    Inherits System.Windows.Forms.Form

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

    Dim ampArray(1) As AmpObj

    Const X_AXIS_AMP As Short = 0
    Const Y_AXIS_AMP As Short = 1

    Dim Home As HomeSettingsObj

    ' Create a delegate to close down the application in a thread safe way
    Delegate Sub CloseApp()

    Private Sub Linkage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '**************************************************************************
            '* Turn on logging by setting a CML object
            '**************************************************************************
            cmlObj = New CopleyMotionLibraryObj()
            cmlObj.DebugLevel = LOG_ALL

            'Initialize code here


            ampArray(X_AXIS_AMP) = New AmpObj
            ampArray(Y_AXIS_AMP) = New AmpObj
            Linkage = New LinkageObj

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
            ampArray(X_AXIS_AMP).Initialize(CanOpen, X_AXIS_CAN_ADDRESS)
            ampArray(Y_AXIS_AMP).Initialize(CanOpen, Y_AXIS_CAN_ADDRESS)


            Linkage.Initialize(ampArray)

            '***************************************************
            '* An alternate way of initializing the Linkage object is to set up the 
            '* LinkageSettingsObj then pass it into the InitializeExt method of the LinkageObj. 
            '* To use it, first comment out the call to the LinkageObj's Initialize method 
            '* above, then uncomment the following three lines of code.
            '**************************************************************************
            '''' Create an instance of the AmpSettings object by calling the constructor 
            '''' (all of the properties will be initialized to their default values).
            ''linkageSettings = New LinkageSettingsObj()
            '''' Change a property
            ''linkageSettings.moveAckTimeout = 400
            '''' Initialize the AmpObj with the settings object
            ''Linkage.InitializeExt(ampArray, linkageSettings)

        Catch ex As Exception
            DisplayError(ex)
        End Try
    End Sub

    Private Sub linkageMoveButton_Click(sender As Object, e As EventArgs) Handles linkageMoveButton.Click
        Try
            linkageMoveButton.Enabled = False
            HomeAxisButton.Enabled = False

            Dim positionArray(1) As Double 'Set up array
            positionArray(0) = xAxisTextBox.Text
            positionArray(1) = yAxisTextBox.Text

            'Get move values to be used by linkage 
            Dim velocity As Double = (ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 10
            Dim accel As Double = (ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxAcc) / 15
            Dim decel As Double = ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxDec / 10
            Dim jerk As Double = accel

            'Set the Linkage move limits( all values must be non zero)
            Linkage.SetMoveLimits(velocity, accel, decel, jerk)

            'Do linkage move
            Linkage.MoveTo(positionArray)

            Linkage.WaitMoveDone(10000)

            linkageMoveButton.Enabled = True
            HomeAxisButton.Enabled = True


        Catch ex As Exception
            linkageMoveButton.Enabled = True
            HomeAxisButton.Enabled = True
            DisplayError(ex)
        End Try
    End Sub

    Private Sub HomeAxisButton_Click(sender As Object, e As EventArgs) Handles HomeAxisButton.Click
        Try
            linkageMoveButton.Enabled = False
            HomeAxisButton.Enabled = False

            Home = ampArray(X_AXIS_AMP).HomeSettings
            Home.HomeVelFast = (ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 10
            Home.HomeVelSlow = (ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 15
            Home.HomeAccel = ampArray(X_AXIS_AMP).VelocityLoopSettings.VelLoopMaxAcc / 10
            Home.HomeMethod = CML_HOME_METHOD.CHOME_INDEX_POSITIVE
            Home.HomeOffset = -100000
            ampArray(X_AXIS_AMP).HomeSettings = Home
            ampArray(X_AXIS_AMP).GoHome()
            ampArray(X_AXIS_AMP).WaitMoveDone(10000)


            Home = ampArray(Y_AXIS_AMP).HomeSettings
            Home.HomeVelFast = (ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 10
            Home.HomeVelSlow = (ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxVel) / 15
            Home.HomeAccel = ampArray(Y_AXIS_AMP).VelocityLoopSettings.VelLoopMaxAcc / 10
            Home.HomeMethod = CML_HOME_METHOD.CHOME_INDEX_NEGATIVE
            Home.HomeOffset = -1000
            ampArray(Y_AXIS_AMP).HomeSettings = Home
            ampArray(Y_AXIS_AMP).GoHome()
            ampArray(Y_AXIS_AMP).WaitMoveDone(10000)

            HomeAxisButton.Enabled = True

            linkageMoveButton.Enabled = True

        Catch ex As Exception
            HomeAxisButton.Enabled = True
            DisplayError(ex)
        End Try
    End Sub

    Private Sub Linkage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            ampArray(Y_AXIS_AMP).Disable()
            ampArray(X_AXIS_AMP).Disable()

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
