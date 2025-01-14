<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiThreadedWithEvent
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
        Me.YaxisGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.yAxisMoveDistanceTextBox = New System.Windows.Forms.TextBox()
        Me.yAxisStopButton = New System.Windows.Forms.Button()
        Me.yAxisStartButton = New System.Windows.Forms.Button()
        Me.xAxisGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xMoveDistanceTextBox = New System.Windows.Forms.TextBox()
        Me.xAxisStopButton = New System.Windows.Forms.Button()
        Me.xAxisStartButton = New System.Windows.Forms.Button()
        Me.HomeAxisButton = New System.Windows.Forms.Button()
        Me.YaxisGroupBox.SuspendLayout()
        Me.xAxisGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'YaxisGroupBox
        '
        Me.YaxisGroupBox.Controls.Add(Me.Label4)
        Me.YaxisGroupBox.Controls.Add(Me.Label3)
        Me.YaxisGroupBox.Controls.Add(Me.yAxisMoveDistanceTextBox)
        Me.YaxisGroupBox.Controls.Add(Me.yAxisStopButton)
        Me.YaxisGroupBox.Controls.Add(Me.yAxisStartButton)
        Me.YaxisGroupBox.Location = New System.Drawing.Point(257, 68)
        Me.YaxisGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.YaxisGroupBox.Name = "YaxisGroupBox"
        Me.YaxisGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.YaxisGroupBox.Size = New System.Drawing.Size(228, 127)
        Me.YaxisGroupBox.TabIndex = 2
        Me.YaxisGroupBox.TabStop = False
        Me.YaxisGroupBox.Text = "Y Axis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(179, 43)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "counts"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Move Distance"
        '
        'yAxisMoveDistanceTextBox
        '
        Me.yAxisMoveDistanceTextBox.Location = New System.Drawing.Point(100, 41)
        Me.yAxisMoveDistanceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.yAxisMoveDistanceTextBox.Name = "yAxisMoveDistanceTextBox"
        Me.yAxisMoveDistanceTextBox.Size = New System.Drawing.Size(76, 20)
        Me.yAxisMoveDistanceTextBox.TabIndex = 5
        Me.yAxisMoveDistanceTextBox.Text = "1000"
        Me.yAxisMoveDistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'yAxisStopButton
        '
        Me.yAxisStopButton.Location = New System.Drawing.Point(129, 89)
        Me.yAxisStopButton.Margin = New System.Windows.Forms.Padding(2)
        Me.yAxisStopButton.Name = "yAxisStopButton"
        Me.yAxisStopButton.Size = New System.Drawing.Size(68, 25)
        Me.yAxisStopButton.TabIndex = 5
        Me.yAxisStopButton.Text = "Stop"
        Me.yAxisStopButton.UseVisualStyleBackColor = True
        '
        'yAxisStartButton
        '
        Me.yAxisStartButton.Enabled = False
        Me.yAxisStartButton.Location = New System.Drawing.Point(15, 89)
        Me.yAxisStartButton.Margin = New System.Windows.Forms.Padding(2)
        Me.yAxisStartButton.Name = "yAxisStartButton"
        Me.yAxisStartButton.Size = New System.Drawing.Size(68, 25)
        Me.yAxisStartButton.TabIndex = 4
        Me.yAxisStartButton.Text = "Start"
        Me.yAxisStartButton.UseVisualStyleBackColor = True
        '
        'xAxisGroupBox
        '
        Me.xAxisGroupBox.Controls.Add(Me.Label2)
        Me.xAxisGroupBox.Controls.Add(Me.Label1)
        Me.xAxisGroupBox.Controls.Add(Me.xMoveDistanceTextBox)
        Me.xAxisGroupBox.Controls.Add(Me.xAxisStopButton)
        Me.xAxisGroupBox.Controls.Add(Me.xAxisStartButton)
        Me.xAxisGroupBox.Location = New System.Drawing.Point(30, 68)
        Me.xAxisGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.xAxisGroupBox.Name = "xAxisGroupBox"
        Me.xAxisGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.xAxisGroupBox.Size = New System.Drawing.Size(223, 127)
        Me.xAxisGroupBox.TabIndex = 4
        Me.xAxisGroupBox.TabStop = False
        Me.xAxisGroupBox.Text = " X Axis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "counts"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Move Distance"
        '
        'xMoveDistanceTextBox
        '
        Me.xMoveDistanceTextBox.Location = New System.Drawing.Point(85, 41)
        Me.xMoveDistanceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.xMoveDistanceTextBox.Name = "xMoveDistanceTextBox"
        Me.xMoveDistanceTextBox.Size = New System.Drawing.Size(76, 20)
        Me.xMoveDistanceTextBox.TabIndex = 4
        Me.xMoveDistanceTextBox.Text = "1000"
        Me.xMoveDistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xAxisStopButton
        '
        Me.xAxisStopButton.Location = New System.Drawing.Point(134, 89)
        Me.xAxisStopButton.Margin = New System.Windows.Forms.Padding(2)
        Me.xAxisStopButton.Name = "xAxisStopButton"
        Me.xAxisStopButton.Size = New System.Drawing.Size(68, 25)
        Me.xAxisStopButton.TabIndex = 3
        Me.xAxisStopButton.Text = "Stop"
        Me.xAxisStopButton.UseVisualStyleBackColor = True
        '
        'xAxisStartButton
        '
        Me.xAxisStartButton.Enabled = False
        Me.xAxisStartButton.Location = New System.Drawing.Point(26, 89)
        Me.xAxisStartButton.Margin = New System.Windows.Forms.Padding(2)
        Me.xAxisStartButton.Name = "xAxisStartButton"
        Me.xAxisStartButton.Size = New System.Drawing.Size(68, 25)
        Me.xAxisStartButton.TabIndex = 2
        Me.xAxisStartButton.Text = "Start"
        Me.xAxisStartButton.UseVisualStyleBackColor = True
        '
        'HomeAxisButton
        '
        Me.HomeAxisButton.Location = New System.Drawing.Point(102, 27)
        Me.HomeAxisButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HomeAxisButton.Name = "HomeAxisButton"
        Me.HomeAxisButton.Size = New System.Drawing.Size(271, 34)
        Me.HomeAxisButton.TabIndex = 3
        Me.HomeAxisButton.Text = "Home Axis"
        Me.HomeAxisButton.UseVisualStyleBackColor = True
        '
        'MultiThreadedWithEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 225)
        Me.Controls.Add(Me.YaxisGroupBox)
        Me.Controls.Add(Me.xAxisGroupBox)
        Me.Controls.Add(Me.HomeAxisButton)
        Me.Name = "MultiThreadedWithEvent"
        Me.Text = "Form1"
        Me.YaxisGroupBox.ResumeLayout(False)
        Me.YaxisGroupBox.PerformLayout()
        Me.xAxisGroupBox.ResumeLayout(False)
        Me.xAxisGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents YaxisGroupBox As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents yAxisMoveDistanceTextBox As TextBox
    Friend WithEvents yAxisStopButton As Button
    Friend WithEvents yAxisStartButton As Button
    Friend WithEvents xAxisGroupBox As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents xMoveDistanceTextBox As TextBox
    Friend WithEvents xAxisStopButton As Button
    Friend WithEvents xAxisStartButton As Button
    Friend WithEvents HomeAxisButton As Button
End Class
