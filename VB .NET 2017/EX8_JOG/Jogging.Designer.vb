<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jogging
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
        Me.JogNegButton = New System.Windows.Forms.Button()
        Me.JogPosButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.VelocityTextBox = New System.Windows.Forms.TextBox()
        Me.AccelTextBox = New System.Windows.Forms.TextBox()
        Me.DecelTextBox = New System.Windows.Forms.TextBox()
        Me.VelocityLabel = New System.Windows.Forms.Label()
        Me.AccelLabel = New System.Windows.Forms.Label()
        Me.DecelLabel = New System.Windows.Forms.Label()
        Me.ActPosLabel = New System.Windows.Forms.Label()
        Me.ActPosVar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'JogNegButton
        '
        Me.JogNegButton.Location = New System.Drawing.Point(36, 222)
        Me.JogNegButton.Name = "JogNegButton"
        Me.JogNegButton.Size = New System.Drawing.Size(101, 31)
        Me.JogNegButton.TabIndex = 0
        Me.JogNegButton.Text = "Jog Neg"
        Me.JogNegButton.UseVisualStyleBackColor = True
        '
        'JogPosButton
        '
        Me.JogPosButton.Location = New System.Drawing.Point(200, 222)
        Me.JogPosButton.Name = "JogPosButton"
        Me.JogPosButton.Size = New System.Drawing.Size(101, 31)
        Me.JogPosButton.TabIndex = 1
        Me.JogPosButton.Text = "Jog Pos"
        Me.JogPosButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'VelocityTextBox
        '
        Me.VelocityTextBox.Location = New System.Drawing.Point(150, 36)
        Me.VelocityTextBox.Name = "VelocityTextBox"
        Me.VelocityTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VelocityTextBox.TabIndex = 2
        '
        'AccelTextBox
        '
        Me.AccelTextBox.Location = New System.Drawing.Point(150, 91)
        Me.AccelTextBox.Name = "AccelTextBox"
        Me.AccelTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AccelTextBox.TabIndex = 3
        '
        'DecelTextBox
        '
        Me.DecelTextBox.Location = New System.Drawing.Point(150, 138)
        Me.DecelTextBox.Name = "DecelTextBox"
        Me.DecelTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DecelTextBox.TabIndex = 4
        '
        'VelocityLabel
        '
        Me.VelocityLabel.AutoSize = True
        Me.VelocityLabel.Location = New System.Drawing.Point(33, 39)
        Me.VelocityLabel.Name = "VelocityLabel"
        Me.VelocityLabel.Size = New System.Drawing.Size(61, 17)
        Me.VelocityLabel.TabIndex = 5
        Me.VelocityLabel.Text = "Velocity:"
        '
        'AccelLabel
        '
        Me.AccelLabel.AutoSize = True
        Me.AccelLabel.Location = New System.Drawing.Point(33, 94)
        Me.AccelLabel.Name = "AccelLabel"
        Me.AccelLabel.Size = New System.Drawing.Size(90, 17)
        Me.AccelLabel.TabIndex = 6
        Me.AccelLabel.Text = "Acceleration:"
        '
        'DecelLabel
        '
        Me.DecelLabel.AutoSize = True
        Me.DecelLabel.Location = New System.Drawing.Point(33, 141)
        Me.DecelLabel.Name = "DecelLabel"
        Me.DecelLabel.Size = New System.Drawing.Size(92, 17)
        Me.DecelLabel.TabIndex = 7
        Me.DecelLabel.Text = "Deceleration:"
        '
        'ActPosLabel
        '
        Me.ActPosLabel.AutoSize = True
        Me.ActPosLabel.Location = New System.Drawing.Point(33, 185)
        Me.ActPosLabel.Name = "ActPosLabel"
        Me.ActPosLabel.Size = New System.Drawing.Size(105, 17)
        Me.ActPosLabel.TabIndex = 8
        Me.ActPosLabel.Text = "Actual Position:"
        '
        'ActPosVar
        '
        Me.ActPosVar.AutoSize = True
        Me.ActPosVar.Location = New System.Drawing.Point(156, 185)
        Me.ActPosVar.Name = "ActPosVar"
        Me.ActPosVar.Size = New System.Drawing.Size(60, 17)
        Me.ActPosVar.TabIndex = 9
        Me.ActPosVar.Text = "             "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "counts/s"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "counts/s^2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "counts/s^2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(222, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "counts"
        '
        'Jogging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 280)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ActPosVar)
        Me.Controls.Add(Me.ActPosLabel)
        Me.Controls.Add(Me.DecelLabel)
        Me.Controls.Add(Me.AccelLabel)
        Me.Controls.Add(Me.VelocityLabel)
        Me.Controls.Add(Me.DecelTextBox)
        Me.Controls.Add(Me.AccelTextBox)
        Me.Controls.Add(Me.VelocityTextBox)
        Me.Controls.Add(Me.JogPosButton)
        Me.Controls.Add(Me.JogNegButton)
        Me.Name = "Jogging"
        Me.Text = "Jog Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents JogNegButton As Button
    Friend WithEvents JogPosButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents VelocityTextBox As TextBox
    Friend WithEvents AccelTextBox As TextBox
    Friend WithEvents DecelTextBox As TextBox
    Friend WithEvents VelocityLabel As Label
    Friend WithEvents AccelLabel As Label
    Friend WithEvents DecelLabel As Label
    Friend WithEvents ActPosLabel As Label
    Friend WithEvents ActPosVar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
