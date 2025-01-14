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
        Me.referencedLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.posTextBox = New System.Windows.Forms.TextBox()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.HomeAxisButton = New System.Windows.Forms.Button()
        Me.enableButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'referencedLabel
        '
        Me.referencedLabel.AutoSize = True
        Me.referencedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.referencedLabel.Location = New System.Drawing.Point(40, 168)
        Me.referencedLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.referencedLabel.Name = "referencedLabel"
        Me.referencedLabel.Size = New System.Drawing.Size(117, 16)
        Me.referencedLabel.TabIndex = 13
        Me.referencedLabel.Text = "Not Referenced"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "counts"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 127)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Actual Position"
        '
        'posTextBox
        '
        Me.posTextBox.Location = New System.Drawing.Point(139, 125)
        Me.posTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.posTextBox.Name = "posTextBox"
        Me.posTextBox.ReadOnly = True
        Me.posTextBox.Size = New System.Drawing.Size(76, 20)
        Me.posTextBox.TabIndex = 10
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(42, 194)
        Me.resetButton.Margin = New System.Windows.Forms.Padding(2)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(67, 27)
        Me.resetButton.TabIndex = 9
        Me.resetButton.Text = "ResetAmp"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'HomeAxisButton
        '
        Me.HomeAxisButton.Location = New System.Drawing.Point(70, 70)
        Me.HomeAxisButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HomeAxisButton.Name = "HomeAxisButton"
        Me.HomeAxisButton.Size = New System.Drawing.Size(133, 35)
        Me.HomeAxisButton.TabIndex = 8
        Me.HomeAxisButton.Text = "Home Axis"
        Me.HomeAxisButton.UseVisualStyleBackColor = True
        '
        'enableButton
        '
        Me.enableButton.Location = New System.Drawing.Point(70, 23)
        Me.enableButton.Margin = New System.Windows.Forms.Padding(2)
        Me.enableButton.Name = "enableButton"
        Me.enableButton.Size = New System.Drawing.Size(133, 35)
        Me.enableButton.TabIndex = 7
        Me.enableButton.Text = "Amp Disable"
        Me.enableButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Homing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 245)
        Me.Controls.Add(Me.referencedLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.posTextBox)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.HomeAxisButton)
        Me.Controls.Add(Me.enableButton)
        Me.Name = "Homing"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents referencedLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents posTextBox As TextBox
    Friend WithEvents resetButton As Button
    Friend WithEvents HomeAxisButton As Button
    Friend WithEvents enableButton As Button
    Friend WithEvents Timer1 As Timer
End Class
