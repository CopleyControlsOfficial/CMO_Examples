<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IOModule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cbOut1 = New System.Windows.Forms.CheckBox()
        Me.cbOut2 = New System.Windows.Forms.CheckBox()
        Me.txtInput1State = New System.Windows.Forms.TextBox()
        Me.txtInput2State = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimerStat = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'cbOut1
        '
        Me.cbOut1.AutoSize = True
        Me.cbOut1.Location = New System.Drawing.Point(37, 42)
        Me.cbOut1.Name = "cbOut1"
        Me.cbOut1.Size = New System.Drawing.Size(85, 21)
        Me.cbOut1.TabIndex = 0
        Me.cbOut1.Text = "Output 1"
        Me.cbOut1.UseVisualStyleBackColor = True
        '
        'cbOut2
        '
        Me.cbOut2.AutoSize = True
        Me.cbOut2.Location = New System.Drawing.Point(37, 86)
        Me.cbOut2.Name = "cbOut2"
        Me.cbOut2.Size = New System.Drawing.Size(85, 21)
        Me.cbOut2.TabIndex = 1
        Me.cbOut2.Text = "Output 2"
        Me.cbOut2.UseVisualStyleBackColor = True
        '
        'txtInput1State
        '
        Me.txtInput1State.Location = New System.Drawing.Point(158, 40)
        Me.txtInput1State.Name = "txtInput1State"
        Me.txtInput1State.Size = New System.Drawing.Size(58, 22)
        Me.txtInput1State.TabIndex = 2
        '
        'txtInput2State
        '
        Me.txtInput2State.Location = New System.Drawing.Point(158, 84)
        Me.txtInput2State.Name = "txtInput2State"
        Me.txtInput2State.Size = New System.Drawing.Size(58, 22)
        Me.txtInput2State.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(222, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Input 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Input 2"
        '
        'TimerStat
        '
        '
        'IOModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 135)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInput2State)
        Me.Controls.Add(Me.txtInput1State)
        Me.Controls.Add(Me.cbOut2)
        Me.Controls.Add(Me.cbOut1)
        Me.Name = "IOModule"
        Me.Text = "I/O Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbOut1 As CheckBox
    Friend WithEvents cbOut2 As CheckBox
    Friend WithEvents txtInput1State As TextBox
    Friend WithEvents txtInput2State As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TimerStat As Timer
End Class
