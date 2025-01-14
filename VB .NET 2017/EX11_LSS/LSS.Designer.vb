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
        Me.AssignIDsButton = New System.Windows.Forms.Button()
        Me.BitRateTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AssignIDsButton
        '
        Me.AssignIDsButton.Location = New System.Drawing.Point(94, 160)
        Me.AssignIDsButton.Name = "AssignIDsButton"
        Me.AssignIDsButton.Size = New System.Drawing.Size(132, 41)
        Me.AssignIDsButton.TabIndex = 0
        Me.AssignIDsButton.Text = "Assign Node IDs"
        Me.AssignIDsButton.UseVisualStyleBackColor = True
        '
        'BitRateTextBox
        '
        Me.BitRateTextBox.Location = New System.Drawing.Point(115, 81)
        Me.BitRateTextBox.Name = "BitRateTextBox"
        Me.BitRateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BitRateTextBox.TabIndex = 1
        Me.BitRateTextBox.Text = "1000000"
        Me.BitRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(221, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "bits/sec"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bit Rate: "
        '
        'LSS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 255)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BitRateTextBox)
        Me.Controls.Add(Me.AssignIDsButton)
        Me.Name = "LSS"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AssignIDsButton As Button
    Friend WithEvents BitRateTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
