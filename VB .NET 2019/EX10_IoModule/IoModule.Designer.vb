<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IoModule
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInput2State = New System.Windows.Forms.TextBox()
        Me.txtInput1State = New System.Windows.Forms.TextBox()
        Me.cbOut2 = New System.Windows.Forms.CheckBox()
        Me.cbOut1 = New System.Windows.Forms.CheckBox()
        Me.TimerStat = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Input 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Input 1"
        '
        'txtInput2State
        '
        Me.txtInput2State.Location = New System.Drawing.Point(108, 65)
        Me.txtInput2State.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInput2State.Name = "txtInput2State"
        Me.txtInput2State.Size = New System.Drawing.Size(34, 20)
        Me.txtInput2State.TabIndex = 9
        Me.txtInput2State.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInput1State
        '
        Me.txtInput1State.Location = New System.Drawing.Point(108, 29)
        Me.txtInput1State.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInput1State.Name = "txtInput1State"
        Me.txtInput1State.Size = New System.Drawing.Size(34, 20)
        Me.txtInput1State.TabIndex = 8
        Me.txtInput1State.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbOut2
        '
        Me.cbOut2.AutoSize = True
        Me.cbOut2.Location = New System.Drawing.Point(28, 66)
        Me.cbOut2.Margin = New System.Windows.Forms.Padding(2)
        Me.cbOut2.Name = "cbOut2"
        Me.cbOut2.Size = New System.Drawing.Size(67, 17)
        Me.cbOut2.TabIndex = 7
        Me.cbOut2.Text = "Output 2"
        Me.cbOut2.UseVisualStyleBackColor = True
        '
        'cbOut1
        '
        Me.cbOut1.AutoSize = True
        Me.cbOut1.Location = New System.Drawing.Point(28, 30)
        Me.cbOut1.Margin = New System.Windows.Forms.Padding(2)
        Me.cbOut1.Name = "cbOut1"
        Me.cbOut1.Size = New System.Drawing.Size(67, 17)
        Me.cbOut1.TabIndex = 6
        Me.cbOut1.Text = "Output 1"
        Me.cbOut1.UseVisualStyleBackColor = True
        '
        'TimerStat
        '
        '
        'IoModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 121)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInput2State)
        Me.Controls.Add(Me.txtInput1State)
        Me.Controls.Add(Me.cbOut2)
        Me.Controls.Add(Me.cbOut1)
        Me.Name = "IoModule"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput2State As TextBox
    Friend WithEvents txtInput1State As TextBox
    Friend WithEvents cbOut2 As CheckBox
    Friend WithEvents cbOut1 As CheckBox
    Friend WithEvents TimerStat As Timer
End Class
