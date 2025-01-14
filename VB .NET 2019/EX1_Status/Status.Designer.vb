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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.statusTextBox = New System.Windows.Forms.TextBox()
        Me.posTextBox = New System.Windows.Forms.TextBox()
        Me.readButton = New System.Windows.Forms.Button()
        Me.EnableButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.statusTextBox)
        Me.GroupBox1.Controls.Add(Me.posTextBox)
        Me.GroupBox1.Controls.Add(Me.readButton)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 74)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(284, 232)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Amp Status"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(24, 136)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(243, 69)
        Me.ListBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Amp event status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Actual Position (in counts)"
        '
        'statusTextBox
        '
        Me.statusTextBox.Location = New System.Drawing.Point(180, 70)
        Me.statusTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.statusTextBox.Name = "statusTextBox"
        Me.statusTextBox.ReadOnly = True
        Me.statusTextBox.Size = New System.Drawing.Size(76, 20)
        Me.statusTextBox.TabIndex = 2
        Me.statusTextBox.Text = "0"
        Me.statusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'posTextBox
        '
        Me.posTextBox.Location = New System.Drawing.Point(180, 31)
        Me.posTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.posTextBox.Name = "posTextBox"
        Me.posTextBox.ReadOnly = True
        Me.posTextBox.Size = New System.Drawing.Size(76, 20)
        Me.posTextBox.TabIndex = 1
        Me.posTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'readButton
        '
        Me.readButton.Location = New System.Drawing.Point(85, 100)
        Me.readButton.Margin = New System.Windows.Forms.Padding(2)
        Me.readButton.Name = "readButton"
        Me.readButton.Size = New System.Drawing.Size(102, 24)
        Me.readButton.TabIndex = 0
        Me.readButton.Text = "ReadEventSticky"
        Me.readButton.UseVisualStyleBackColor = True
        '
        'EnableButton
        '
        Me.EnableButton.Location = New System.Drawing.Point(120, 31)
        Me.EnableButton.Margin = New System.Windows.Forms.Padding(2)
        Me.EnableButton.Name = "EnableButton"
        Me.EnableButton.Size = New System.Drawing.Size(75, 31)
        Me.EnableButton.TabIndex = 2
        Me.EnableButton.Text = "Amp Disable"
        Me.EnableButton.UseVisualStyleBackColor = True
        '
        'Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 336)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EnableButton)
        Me.Name = "Status"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents statusTextBox As TextBox
    Friend WithEvents posTextBox As TextBox
    Friend WithEvents readButton As Button
    Friend WithEvents EnableButton As Button
End Class
