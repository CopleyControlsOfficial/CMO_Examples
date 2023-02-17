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
        Me.HomeAxisButton = New System.Windows.Forms.Button()
        Me.xAxisGroupBox = New System.Windows.Forms.GroupBox()
        Me.xMoveDistanceTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xAxisStopButton = New System.Windows.Forms.Button()
        Me.xAxisStartButton = New System.Windows.Forms.Button()
        Me.YaxisGroupBox = New System.Windows.Forms.GroupBox()
        Me.yAxisMoveDistanceTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.yAxisStopButton = New System.Windows.Forms.Button()
        Me.yAxisStartButton = New System.Windows.Forms.Button()
        Me.xAxisGroupBox.SuspendLayout()
        Me.YaxisGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'HomeAxisButton
        '
        Me.HomeAxisButton.Location = New System.Drawing.Point(159, 12)
        Me.HomeAxisButton.Name = "HomeAxisButton"
        Me.HomeAxisButton.Size = New System.Drawing.Size(256, 46)
        Me.HomeAxisButton.TabIndex = 0
        Me.HomeAxisButton.Text = "Home Axis"
        Me.HomeAxisButton.UseVisualStyleBackColor = True
        '
        'xAxisGroupBox
        '
        Me.xAxisGroupBox.Controls.Add(Me.xMoveDistanceTextBox)
        Me.xAxisGroupBox.Controls.Add(Me.Label3)
        Me.xAxisGroupBox.Controls.Add(Me.Label1)
        Me.xAxisGroupBox.Controls.Add(Me.xAxisStopButton)
        Me.xAxisGroupBox.Controls.Add(Me.xAxisStartButton)
        Me.xAxisGroupBox.Location = New System.Drawing.Point(12, 64)
        Me.xAxisGroupBox.Name = "xAxisGroupBox"
        Me.xAxisGroupBox.Size = New System.Drawing.Size(270, 146)
        Me.xAxisGroupBox.TabIndex = 1
        Me.xAxisGroupBox.TabStop = False
        Me.xAxisGroupBox.Text = "X Axis"
        '
        'xMoveDistanceTextBox
        '
        Me.xMoveDistanceTextBox.Location = New System.Drawing.Point(126, 32)
        Me.xMoveDistanceTextBox.Name = "xMoveDistanceTextBox"
        Me.xMoveDistanceTextBox.Size = New System.Drawing.Size(81, 22)
        Me.xMoveDistanceTextBox.TabIndex = 8
        Me.xMoveDistanceTextBox.Text = "1000"
        Me.xMoveDistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "counts"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Move Distance"
        '
        'xAxisStopButton
        '
        Me.xAxisStopButton.Location = New System.Drawing.Point(132, 104)
        Me.xAxisStopButton.Name = "xAxisStopButton"
        Me.xAxisStopButton.Size = New System.Drawing.Size(75, 25)
        Me.xAxisStopButton.TabIndex = 1
        Me.xAxisStopButton.Text = "Stop"
        Me.xAxisStopButton.UseVisualStyleBackColor = True
        '
        'xAxisStartButton
        '
        Me.xAxisStartButton.Enabled = False
        Me.xAxisStartButton.Location = New System.Drawing.Point(33, 104)
        Me.xAxisStartButton.Name = "xAxisStartButton"
        Me.xAxisStartButton.Size = New System.Drawing.Size(75, 25)
        Me.xAxisStartButton.TabIndex = 0
        Me.xAxisStartButton.Text = "Start"
        Me.xAxisStartButton.UseVisualStyleBackColor = True
        '
        'YaxisGroupBox
        '
        Me.YaxisGroupBox.Controls.Add(Me.yAxisMoveDistanceTextBox)
        Me.YaxisGroupBox.Controls.Add(Me.Label4)
        Me.YaxisGroupBox.Controls.Add(Me.Label2)
        Me.YaxisGroupBox.Controls.Add(Me.yAxisStopButton)
        Me.YaxisGroupBox.Controls.Add(Me.yAxisStartButton)
        Me.YaxisGroupBox.Location = New System.Drawing.Point(303, 64)
        Me.YaxisGroupBox.Name = "YaxisGroupBox"
        Me.YaxisGroupBox.Size = New System.Drawing.Size(294, 146)
        Me.YaxisGroupBox.TabIndex = 0
        Me.YaxisGroupBox.TabStop = False
        Me.YaxisGroupBox.Text = "Y Axis"
        '
        'yAxisMoveDistanceTextBox
        '
        Me.yAxisMoveDistanceTextBox.Location = New System.Drawing.Point(137, 32)
        Me.yAxisMoveDistanceTextBox.Name = "yAxisMoveDistanceTextBox"
        Me.yAxisMoveDistanceTextBox.Size = New System.Drawing.Size(81, 22)
        Me.yAxisMoveDistanceTextBox.TabIndex = 9
        Me.yAxisMoveDistanceTextBox.Text = "1000"
        Me.yAxisMoveDistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(224, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "counts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MoveDistance"
        '
        'yAxisStopButton
        '
        Me.yAxisStopButton.Location = New System.Drawing.Point(143, 104)
        Me.yAxisStopButton.Name = "yAxisStopButton"
        Me.yAxisStopButton.Size = New System.Drawing.Size(75, 25)
        Me.yAxisStopButton.TabIndex = 3
        Me.yAxisStopButton.Text = "Stop"
        Me.yAxisStopButton.UseVisualStyleBackColor = True
        '
        'yAxisStartButton
        '
        Me.yAxisStartButton.Enabled = False
        Me.yAxisStartButton.Location = New System.Drawing.Point(48, 104)
        Me.yAxisStartButton.Name = "yAxisStartButton"
        Me.yAxisStartButton.Size = New System.Drawing.Size(75, 25)
        Me.yAxisStartButton.TabIndex = 2
        Me.yAxisStartButton.Text = "Start"
        Me.yAxisStartButton.UseVisualStyleBackColor = True
        '
        'MultiThreadedWithEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 237)
        Me.Controls.Add(Me.YaxisGroupBox)
        Me.Controls.Add(Me.xAxisGroupBox)
        Me.Controls.Add(Me.HomeAxisButton)
        Me.Name = "MultiThreadedWithEvent"
        Me.Text = "Form1"
        Me.xAxisGroupBox.ResumeLayout(False)
        Me.xAxisGroupBox.PerformLayout()
        Me.YaxisGroupBox.ResumeLayout(False)
        Me.YaxisGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HomeAxisButton As Button
    Friend WithEvents xAxisGroupBox As GroupBox
    Friend WithEvents YaxisGroupBox As GroupBox
    Friend WithEvents xAxisStopButton As Button
    Friend WithEvents xAxisStartButton As Button
    Friend WithEvents yAxisStopButton As Button
    Friend WithEvents yAxisStartButton As Button
    Friend WithEvents xMoveDistanceTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents yAxisMoveDistanceTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
End Class
