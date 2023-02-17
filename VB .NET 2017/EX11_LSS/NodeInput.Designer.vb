<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NodeInput
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
        Me.SendIDButton = New System.Windows.Forms.Button()
        Me.NodeIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SendIDButton
        '
        Me.SendIDButton.Location = New System.Drawing.Point(184, 109)
        Me.SendIDButton.Name = "SendIDButton"
        Me.SendIDButton.Size = New System.Drawing.Size(75, 28)
        Me.SendIDButton.TabIndex = 0
        Me.SendIDButton.Text = "Send"
        Me.SendIDButton.UseVisualStyleBackColor = True
        '
        'NodeIDTextBox
        '
        Me.NodeIDTextBox.Location = New System.Drawing.Point(78, 112)
        Me.NodeIDTextBox.Name = "NodeIDTextBox"
        Me.NodeIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NodeIDTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please enter the desired node ID for the"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "amp with the blinking CAN LEDs"
        '
        'NodeInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 239)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NodeIDTextBox)
        Me.Controls.Add(Me.SendIDButton)
        Me.Name = "NodeInput"
        Me.Text = "NodeInput"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SendIDButton As Button
    Friend WithEvents NodeIDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
