<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasicMoves
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
        Me.HomeAxisButton = New System.Windows.Forms.Button()
        Me.enableButton = New System.Windows.Forms.Button()
        Me.doMoveButton = New System.Windows.Forms.Button()
        Me.haltMoveButton = New System.Windows.Forms.Button()
        Me.VelocityTextBox = New System.Windows.Forms.TextBox()
        Me.AccelTextBox = New System.Windows.Forms.TextBox()
        Me.DecelTextBox = New System.Windows.Forms.TextBox()
        Me.DistanceTextBox = New System.Windows.Forms.TextBox()
        Me.posTextBox = New System.Windows.Forms.TextBox()
        Me.velocityLabel = New System.Windows.Forms.Label()
        Me.AccelerationLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'HomeAxisButton
        '
        Me.HomeAxisButton.Location = New System.Drawing.Point(73, 12)
        Me.HomeAxisButton.Name = "HomeAxisButton"
        Me.HomeAxisButton.Size = New System.Drawing.Size(237, 41)
        Me.HomeAxisButton.TabIndex = 0
        Me.HomeAxisButton.Text = "Home Axis"
        Me.HomeAxisButton.UseVisualStyleBackColor = True
        '
        'enableButton
        '
        Me.enableButton.Location = New System.Drawing.Point(12, 268)
        Me.enableButton.Name = "enableButton"
        Me.enableButton.Size = New System.Drawing.Size(111, 33)
        Me.enableButton.TabIndex = 1
        Me.enableButton.Text = "Amp Disable"
        Me.enableButton.UseVisualStyleBackColor = True
        '
        'doMoveButton
        '
        Me.doMoveButton.Location = New System.Drawing.Point(138, 268)
        Me.doMoveButton.Name = "doMoveButton"
        Me.doMoveButton.Size = New System.Drawing.Size(111, 33)
        Me.doMoveButton.TabIndex = 2
        Me.doMoveButton.Text = "Do Move"
        Me.doMoveButton.UseVisualStyleBackColor = True
        '
        'haltMoveButton
        '
        Me.haltMoveButton.Location = New System.Drawing.Point(264, 268)
        Me.haltMoveButton.Name = "haltMoveButton"
        Me.haltMoveButton.Size = New System.Drawing.Size(111, 33)
        Me.haltMoveButton.TabIndex = 3
        Me.haltMoveButton.Text = "Halt Move"
        Me.haltMoveButton.UseVisualStyleBackColor = True
        '
        'VelocityTextBox
        '
        Me.VelocityTextBox.Location = New System.Drawing.Point(186, 73)
        Me.VelocityTextBox.Name = "VelocityTextBox"
        Me.VelocityTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VelocityTextBox.TabIndex = 4
        Me.VelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AccelTextBox
        '
        Me.AccelTextBox.Location = New System.Drawing.Point(186, 112)
        Me.AccelTextBox.Name = "AccelTextBox"
        Me.AccelTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AccelTextBox.TabIndex = 5
        Me.AccelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DecelTextBox
        '
        Me.DecelTextBox.Location = New System.Drawing.Point(186, 149)
        Me.DecelTextBox.Name = "DecelTextBox"
        Me.DecelTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DecelTextBox.TabIndex = 6
        Me.DecelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DistanceTextBox
        '
        Me.DistanceTextBox.Location = New System.Drawing.Point(186, 188)
        Me.DistanceTextBox.Name = "DistanceTextBox"
        Me.DistanceTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DistanceTextBox.TabIndex = 7
        Me.DistanceTextBox.Text = "1000"
        Me.DistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'posTextBox
        '
        Me.posTextBox.Location = New System.Drawing.Point(186, 227)
        Me.posTextBox.Name = "posTextBox"
        Me.posTextBox.ReadOnly = True
        Me.posTextBox.Size = New System.Drawing.Size(100, 22)
        Me.posTextBox.TabIndex = 8
        Me.posTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'velocityLabel
        '
        Me.velocityLabel.AutoSize = True
        Me.velocityLabel.Location = New System.Drawing.Point(45, 76)
        Me.velocityLabel.Name = "velocityLabel"
        Me.velocityLabel.Size = New System.Drawing.Size(57, 17)
        Me.velocityLabel.TabIndex = 9
        Me.velocityLabel.Text = "Velocity"
        '
        'AccelerationLabel
        '
        Me.AccelerationLabel.AutoSize = True
        Me.AccelerationLabel.Location = New System.Drawing.Point(45, 115)
        Me.AccelerationLabel.Name = "AccelerationLabel"
        Me.AccelerationLabel.Size = New System.Drawing.Size(86, 17)
        Me.AccelerationLabel.TabIndex = 10
        Me.AccelerationLabel.Text = "Acceleration"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Deceleration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Move Distance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Actual Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(292, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "counts/s"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(292, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "counts/s^2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(292, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "counts/s^2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(292, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "counts"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(292, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "counts"
        '
        'Timer1
        '
        '
        'BasicMoves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 333)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AccelerationLabel)
        Me.Controls.Add(Me.velocityLabel)
        Me.Controls.Add(Me.posTextBox)
        Me.Controls.Add(Me.DistanceTextBox)
        Me.Controls.Add(Me.DecelTextBox)
        Me.Controls.Add(Me.AccelTextBox)
        Me.Controls.Add(Me.VelocityTextBox)
        Me.Controls.Add(Me.haltMoveButton)
        Me.Controls.Add(Me.doMoveButton)
        Me.Controls.Add(Me.enableButton)
        Me.Controls.Add(Me.HomeAxisButton)
        Me.Name = "BasicMoves"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HomeAxisButton As Button
    Friend WithEvents enableButton As Button
    Friend WithEvents doMoveButton As Button
    Friend WithEvents haltMoveButton As Button
    Friend WithEvents VelocityTextBox As TextBox
    Friend WithEvents AccelTextBox As TextBox
    Friend WithEvents DecelTextBox As TextBox
    Friend WithEvents DistanceTextBox As TextBox
    Friend WithEvents posTextBox As TextBox
    Friend WithEvents velocityLabel As Label
    Friend WithEvents AccelerationLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer1 As Timer
End Class
