<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Status
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.statusTextBox = New System.Windows.Forms.TextBox()
        Me.posTextBox = New System.Windows.Forms.TextBox()
        Me.readButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'enableButton
        '
        Me.enableButton.Location = New System.Drawing.Point(120, 30)
        Me.enableButton.Name = "enableButton"
        Me.enableButton.Size = New System.Drawing.Size(97, 38)
        Me.enableButton.TabIndex = 0
        Me.enableButton.Text = "Amp Disable"
        Me.enableButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.statusTextBox)
        Me.GroupBox1.Controls.Add(Me.posTextBox)
        Me.GroupBox1.Controls.Add(Me.readButton)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 247)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Amp Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Amp event status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Actual Position (in counts)"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(6, 163)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(308, 68)
        Me.ListBox1.TabIndex = 3
        '
        'statusTextBox
        '
        Me.statusTextBox.Location = New System.Drawing.Point(212, 75)
        Me.statusTextBox.Name = "statusTextBox"
        Me.statusTextBox.ReadOnly = True
        Me.statusTextBox.Size = New System.Drawing.Size(81, 22)
        Me.statusTextBox.TabIndex = 2
        Me.statusTextBox.Text = "0"
        Me.statusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'posTextBox
        '
        Me.posTextBox.Location = New System.Drawing.Point(212, 34)
        Me.posTextBox.Name = "posTextBox"
        Me.posTextBox.ReadOnly = True
        Me.posTextBox.Size = New System.Drawing.Size(81, 22)
        Me.posTextBox.TabIndex = 1
        Me.posTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'readButton
        '
        Me.readButton.Location = New System.Drawing.Point(90, 115)
        Me.readButton.Name = "readButton"
        Me.readButton.Size = New System.Drawing.Size(136, 33)
        Me.readButton.TabIndex = 0
        Me.readButton.Text = "ReadEventSticky"
        Me.readButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 342)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.enableButton)
        Me.Name = "Status"
        Me.Text = "Status_Control"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents enableButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents posTextBox As TextBox
    Friend WithEvents readButton As Button
    Friend WithEvents statusTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Timer1 As Timer
End Class
