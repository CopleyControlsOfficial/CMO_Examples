<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jog
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ActPosVar = New System.Windows.Forms.Label()
        Me.ActPosLabel = New System.Windows.Forms.Label()
        Me.DecelLabel = New System.Windows.Forms.Label()
        Me.AccelLabel = New System.Windows.Forms.Label()
        Me.VelocityLabel = New System.Windows.Forms.Label()
        Me.DecelTextBox = New System.Windows.Forms.TextBox()
        Me.AccelTextBox = New System.Windows.Forms.TextBox()
        Me.VelocityTextBox = New System.Windows.Forms.TextBox()
        Me.JogPosButton = New System.Windows.Forms.Button()
        Me.JogNegButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "counts"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(218, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "counts/s^2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "counts/s^2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "counts/s"
        '
        'ActPosVar
        '
        Me.ActPosVar.AutoSize = True
        Me.ActPosVar.Location = New System.Drawing.Point(130, 150)
        Me.ActPosVar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ActPosVar.Name = "ActPosVar"
        Me.ActPosVar.Size = New System.Drawing.Size(52, 13)
        Me.ActPosVar.TabIndex = 23
        Me.ActPosVar.Text = "               "
        '
        'ActPosLabel
        '
        Me.ActPosLabel.AutoSize = True
        Me.ActPosLabel.Location = New System.Drawing.Point(32, 150)
        Me.ActPosLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ActPosLabel.Name = "ActPosLabel"
        Me.ActPosLabel.Size = New System.Drawing.Size(77, 13)
        Me.ActPosLabel.TabIndex = 22
        Me.ActPosLabel.Text = "Actual Position"
        '
        'DecelLabel
        '
        Me.DecelLabel.AutoSize = True
        Me.DecelLabel.Location = New System.Drawing.Point(32, 109)
        Me.DecelLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DecelLabel.Name = "DecelLabel"
        Me.DecelLabel.Size = New System.Drawing.Size(70, 13)
        Me.DecelLabel.TabIndex = 21
        Me.DecelLabel.Text = "Deceleration:"
        '
        'AccelLabel
        '
        Me.AccelLabel.AutoSize = True
        Me.AccelLabel.Location = New System.Drawing.Point(32, 68)
        Me.AccelLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AccelLabel.Name = "AccelLabel"
        Me.AccelLabel.Size = New System.Drawing.Size(69, 13)
        Me.AccelLabel.TabIndex = 20
        Me.AccelLabel.Text = "Acceleration:"
        '
        'VelocityLabel
        '
        Me.VelocityLabel.AutoSize = True
        Me.VelocityLabel.Location = New System.Drawing.Point(32, 30)
        Me.VelocityLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VelocityLabel.Name = "VelocityLabel"
        Me.VelocityLabel.Size = New System.Drawing.Size(47, 13)
        Me.VelocityLabel.TabIndex = 19
        Me.VelocityLabel.Text = "Velocity:"
        '
        'DecelTextBox
        '
        Me.DecelTextBox.Location = New System.Drawing.Point(132, 106)
        Me.DecelTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DecelTextBox.Name = "DecelTextBox"
        Me.DecelTextBox.Size = New System.Drawing.Size(76, 20)
        Me.DecelTextBox.TabIndex = 18
        '
        'AccelTextBox
        '
        Me.AccelTextBox.Location = New System.Drawing.Point(132, 65)
        Me.AccelTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AccelTextBox.Name = "AccelTextBox"
        Me.AccelTextBox.Size = New System.Drawing.Size(76, 20)
        Me.AccelTextBox.TabIndex = 17
        '
        'VelocityTextBox
        '
        Me.VelocityTextBox.Location = New System.Drawing.Point(132, 27)
        Me.VelocityTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.VelocityTextBox.Name = "VelocityTextBox"
        Me.VelocityTextBox.Size = New System.Drawing.Size(76, 20)
        Me.VelocityTextBox.TabIndex = 16
        '
        'JogPosButton
        '
        Me.JogPosButton.Location = New System.Drawing.Point(163, 194)
        Me.JogPosButton.Margin = New System.Windows.Forms.Padding(2)
        Me.JogPosButton.Name = "JogPosButton"
        Me.JogPosButton.Size = New System.Drawing.Size(76, 28)
        Me.JogPosButton.TabIndex = 15
        Me.JogPosButton.Text = "Jog Pos"
        Me.JogPosButton.UseVisualStyleBackColor = True
        '
        'JogNegButton
        '
        Me.JogNegButton.Location = New System.Drawing.Point(34, 194)
        Me.JogNegButton.Margin = New System.Windows.Forms.Padding(2)
        Me.JogNegButton.Name = "JogNegButton"
        Me.JogNegButton.Size = New System.Drawing.Size(76, 28)
        Me.JogNegButton.TabIndex = 14
        Me.JogNegButton.Text = "Jog Neg"
        Me.JogNegButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Jog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 257)
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
        Me.Name = "Jog"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ActPosVar As Label
    Friend WithEvents ActPosLabel As Label
    Friend WithEvents DecelLabel As Label
    Friend WithEvents AccelLabel As Label
    Friend WithEvents VelocityLabel As Label
    Friend WithEvents DecelTextBox As TextBox
    Friend WithEvents AccelTextBox As TextBox
    Friend WithEvents VelocityTextBox As TextBox
    Friend WithEvents JogPosButton As Button
    Friend WithEvents JogNegButton As Button
    Friend WithEvents Timer1 As Timer
End Class
