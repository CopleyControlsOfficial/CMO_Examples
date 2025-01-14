<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Linkage
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.yAxisTextBox = New System.Windows.Forms.TextBox()
        Me.xAxisTextBox = New System.Windows.Forms.TextBox()
        Me.linkageMoveButton = New System.Windows.Forms.Button()
        Me.HomeAxisButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(247, 154)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "counts"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(247, 122)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "counts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Y Axis Move to Position"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 122)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "X Axis Move to Position"
        '
        'yAxisTextBox
        '
        Me.yAxisTextBox.Location = New System.Drawing.Point(167, 152)
        Me.yAxisTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.yAxisTextBox.Name = "yAxisTextBox"
        Me.yAxisTextBox.Size = New System.Drawing.Size(76, 20)
        Me.yAxisTextBox.TabIndex = 11
        Me.yAxisTextBox.Text = "10000"
        '
        'xAxisTextBox
        '
        Me.xAxisTextBox.Location = New System.Drawing.Point(167, 119)
        Me.xAxisTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.xAxisTextBox.Name = "xAxisTextBox"
        Me.xAxisTextBox.Size = New System.Drawing.Size(76, 20)
        Me.xAxisTextBox.TabIndex = 10
        Me.xAxisTextBox.Text = "20000"
        '
        'linkageMoveButton
        '
        Me.linkageMoveButton.Location = New System.Drawing.Point(32, 71)
        Me.linkageMoveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.linkageMoveButton.Name = "linkageMoveButton"
        Me.linkageMoveButton.Size = New System.Drawing.Size(219, 32)
        Me.linkageMoveButton.TabIndex = 9
        Me.linkageMoveButton.Text = "Perform Linkage Move"
        Me.linkageMoveButton.UseVisualStyleBackColor = True
        '
        'HomeAxisButton
        '
        Me.HomeAxisButton.Location = New System.Drawing.Point(32, 24)
        Me.HomeAxisButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HomeAxisButton.Name = "HomeAxisButton"
        Me.HomeAxisButton.Size = New System.Drawing.Size(219, 32)
        Me.HomeAxisButton.TabIndex = 8
        Me.HomeAxisButton.Text = "Home Axis"
        Me.HomeAxisButton.UseVisualStyleBackColor = True
        '
        'Linkage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 207)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.yAxisTextBox)
        Me.Controls.Add(Me.xAxisTextBox)
        Me.Controls.Add(Me.linkageMoveButton)
        Me.Controls.Add(Me.HomeAxisButton)
        Me.Name = "Linkage"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents yAxisTextBox As TextBox
    Friend WithEvents xAxisTextBox As TextBox
    Friend WithEvents linkageMoveButton As Button
    Friend WithEvents HomeAxisButton As Button
End Class
