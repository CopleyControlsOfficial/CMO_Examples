<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homing
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
        Me.enableButton = New System.Windows.Forms.Button()
        Me.HomeAxisButton = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.posTextBox = New System.Windows.Forms.TextBox()
        Me.referencedLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'enableButton
        '
        Me.enableButton.Location = New System.Drawing.Point(77, 21)
        Me.enableButton.Name = "enableButton"
        Me.enableButton.Size = New System.Drawing.Size(144, 39)
        Me.enableButton.TabIndex = 0
        Me.enableButton.Text = "Amp Disable"
        Me.enableButton.UseVisualStyleBackColor = True
        '
        'HomeAxisButton
        '
        Me.HomeAxisButton.Location = New System.Drawing.Point(77, 83)
        Me.HomeAxisButton.Name = "HomeAxisButton"
        Me.HomeAxisButton.Size = New System.Drawing.Size(144, 39)
        Me.HomeAxisButton.TabIndex = 1
        Me.HomeAxisButton.Text = "Home Axis"
        Me.HomeAxisButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(36, 245)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(102, 26)
        Me.resetButton.TabIndex = 2
        Me.resetButton.Text = "Reset Amp"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'posTextBox
        '
        Me.posTextBox.Location = New System.Drawing.Point(141, 152)
        Me.posTextBox.Name = "posTextBox"
        Me.posTextBox.ReadOnly = True
        Me.posTextBox.Size = New System.Drawing.Size(100, 22)
        Me.posTextBox.TabIndex = 3
        Me.posTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'referencedLabel
        '
        Me.referencedLabel.AutoSize = True
        Me.referencedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.referencedLabel.Location = New System.Drawing.Point(12, 199)
        Me.referencedLabel.Name = "referencedLabel"
        Me.referencedLabel.Size = New System.Drawing.Size(140, 20)
        Me.referencedLabel.TabIndex = 6
        Me.referencedLabel.Text = "Not Referenced"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Actual Position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "counts"
        '
        'Homing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 283)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.referencedLabel)
        Me.Controls.Add(Me.posTextBox)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.HomeAxisButton)
        Me.Controls.Add(Me.enableButton)
        Me.Name = "Homing"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents enableButton As Button
    Friend WithEvents HomeAxisButton As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents posTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents referencedLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
