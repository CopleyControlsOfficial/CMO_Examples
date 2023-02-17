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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.posTextBox = New System.Windows.Forms.TextBox()
        Me.DistanceTextBox = New System.Windows.Forms.TextBox()
        Me.DecelTextBox = New System.Windows.Forms.TextBox()
        Me.AccelTextBox = New System.Windows.Forms.TextBox()
        Me.VelocityTextBox = New System.Windows.Forms.TextBox()
        Me.haltMoveButton = New System.Windows.Forms.Button()
        Me.doMoveButton = New System.Windows.Forms.Button()
        Me.enableButton = New System.Windows.Forms.Button()
        Me.HomeAxisButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 218)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Actual Position"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 183)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Move Distance"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 148)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Deceleration"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 114)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Acceleration"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 81)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Velocity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(218, 217)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "counts"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 183)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "counts"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(218, 148)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "counts/s^2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 114)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "counts/s^2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "counts/s"
        '
        'posTextBox
        '
        Me.posTextBox.Location = New System.Drawing.Point(139, 214)
        Me.posTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.posTextBox.Name = "posTextBox"
        Me.posTextBox.ReadOnly = True
        Me.posTextBox.Size = New System.Drawing.Size(76, 20)
        Me.posTextBox.TabIndex = 27
        Me.posTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DistanceTextBox
        '
        Me.DistanceTextBox.Location = New System.Drawing.Point(139, 181)
        Me.DistanceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DistanceTextBox.Name = "DistanceTextBox"
        Me.DistanceTextBox.Size = New System.Drawing.Size(76, 20)
        Me.DistanceTextBox.TabIndex = 26
        Me.DistanceTextBox.Text = "1000"
        Me.DistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DecelTextBox
        '
        Me.DecelTextBox.Location = New System.Drawing.Point(139, 146)
        Me.DecelTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DecelTextBox.Name = "DecelTextBox"
        Me.DecelTextBox.Size = New System.Drawing.Size(76, 20)
        Me.DecelTextBox.TabIndex = 25
        Me.DecelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AccelTextBox
        '
        Me.AccelTextBox.Location = New System.Drawing.Point(139, 112)
        Me.AccelTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AccelTextBox.Name = "AccelTextBox"
        Me.AccelTextBox.Size = New System.Drawing.Size(76, 20)
        Me.AccelTextBox.TabIndex = 24
        Me.AccelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'VelocityTextBox
        '
        Me.VelocityTextBox.Location = New System.Drawing.Point(139, 79)
        Me.VelocityTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.VelocityTextBox.Name = "VelocityTextBox"
        Me.VelocityTextBox.Size = New System.Drawing.Size(76, 20)
        Me.VelocityTextBox.TabIndex = 23
        Me.VelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'haltMoveButton
        '
        Me.haltMoveButton.Location = New System.Drawing.Point(193, 248)
        Me.haltMoveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.haltMoveButton.Name = "haltMoveButton"
        Me.haltMoveButton.Size = New System.Drawing.Size(74, 22)
        Me.haltMoveButton.TabIndex = 22
        Me.haltMoveButton.Text = "Halt Move"
        Me.haltMoveButton.UseVisualStyleBackColor = True
        '
        'doMoveButton
        '
        Me.doMoveButton.Location = New System.Drawing.Point(114, 248)
        Me.doMoveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.doMoveButton.Name = "doMoveButton"
        Me.doMoveButton.Size = New System.Drawing.Size(74, 22)
        Me.doMoveButton.TabIndex = 21
        Me.doMoveButton.Text = "Do Move"
        Me.doMoveButton.UseVisualStyleBackColor = True
        '
        'enableButton
        '
        Me.enableButton.Location = New System.Drawing.Point(36, 248)
        Me.enableButton.Margin = New System.Windows.Forms.Padding(2)
        Me.enableButton.Name = "enableButton"
        Me.enableButton.Size = New System.Drawing.Size(74, 22)
        Me.enableButton.TabIndex = 20
        Me.enableButton.Text = "Amp Disable"
        Me.enableButton.UseVisualStyleBackColor = True
        '
        'HomeAxisButton
        '
        Me.HomeAxisButton.Location = New System.Drawing.Point(70, 26)
        Me.HomeAxisButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HomeAxisButton.Name = "HomeAxisButton"
        Me.HomeAxisButton.Size = New System.Drawing.Size(144, 28)
        Me.HomeAxisButton.TabIndex = 19
        Me.HomeAxisButton.Text = "Home Axis"
        Me.HomeAxisButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'BasicMoves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 308)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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

    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents posTextBox As TextBox
    Friend WithEvents DistanceTextBox As TextBox
    Friend WithEvents DecelTextBox As TextBox
    Friend WithEvents AccelTextBox As TextBox
    Friend WithEvents VelocityTextBox As TextBox
    Friend WithEvents haltMoveButton As Button
    Friend WithEvents doMoveButton As Button
    Friend WithEvents enableButton As Button
    Friend WithEvents HomeAxisButton As Button
    Friend WithEvents Timer1 As Timer
End Class
