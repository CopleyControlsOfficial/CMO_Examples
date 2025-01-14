<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LSS
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BitRateTextBox = New System.Windows.Forms.TextBox()
        Me.AssignIDsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Bit Rate: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "bits/sec"
        '
        'BitRateTextBox
        '
        Me.BitRateTextBox.Location = New System.Drawing.Point(95, 36)
        Me.BitRateTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.BitRateTextBox.Name = "BitRateTextBox"
        Me.BitRateTextBox.Size = New System.Drawing.Size(76, 20)
        Me.BitRateTextBox.TabIndex = 5
        Me.BitRateTextBox.Text = "1000000"
        Me.BitRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AssignIDsButton
        '
        Me.AssignIDsButton.Location = New System.Drawing.Point(74, 100)
        Me.AssignIDsButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AssignIDsButton.Name = "AssignIDsButton"
        Me.AssignIDsButton.Size = New System.Drawing.Size(104, 28)
        Me.AssignIDsButton.TabIndex = 4
        Me.AssignIDsButton.Text = "Assign Node IDs"
        Me.AssignIDsButton.UseVisualStyleBackColor = True
        '
        'LSS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 180)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BitRateTextBox)
        Me.Controls.Add(Me.AssignIDsButton)
        Me.Name = "LSS"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BitRateTextBox As TextBox
    Friend WithEvents AssignIDsButton As Button
End Class
