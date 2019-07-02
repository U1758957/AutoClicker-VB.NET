<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ClickTimeLabel = New System.Windows.Forms.Label()
        Me.HourBox = New System.Windows.Forms.TextBox()
        Me.MinuteBox = New System.Windows.Forms.TextBox()
        Me.SecondBox = New System.Windows.Forms.TextBox()
        Me.MillisecondBox = New System.Windows.Forms.TextBox()
        Me.HourLabel = New System.Windows.Forms.Label()
        Me.MinuteLabel = New System.Windows.Forms.Label()
        Me.SecondLabel = New System.Windows.Forms.Label()
        Me.MillisecondLabel = New System.Windows.Forms.Label()
        Me.AutoClickButton = New System.Windows.Forms.Button()
        Me.TestButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.TimeMeasureLabel = New System.Windows.Forms.Label()
        Me.TestButtonClicksLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ClickTimeLabel
        '
        Me.ClickTimeLabel.AutoSize = True
        Me.ClickTimeLabel.Location = New System.Drawing.Point(12, 17)
        Me.ClickTimeLabel.Name = "ClickTimeLabel"
        Me.ClickTimeLabel.Size = New System.Drawing.Size(106, 13)
        Me.ClickTimeLabel.TabIndex = 0
        Me.ClickTimeLabel.Text = "Time Between Clicks"
        '
        'HourBox
        '
        Me.HourBox.Location = New System.Drawing.Point(125, 54)
        Me.HourBox.Name = "HourBox"
        Me.HourBox.Size = New System.Drawing.Size(100, 20)
        Me.HourBox.TabIndex = 1
        Me.HourBox.Text = "0"
        Me.HourBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MinuteBox
        '
        Me.MinuteBox.Location = New System.Drawing.Point(284, 54)
        Me.MinuteBox.Name = "MinuteBox"
        Me.MinuteBox.Size = New System.Drawing.Size(100, 20)
        Me.MinuteBox.TabIndex = 2
        Me.MinuteBox.Text = "0"
        Me.MinuteBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SecondBox
        '
        Me.SecondBox.Location = New System.Drawing.Point(448, 54)
        Me.SecondBox.Name = "SecondBox"
        Me.SecondBox.Size = New System.Drawing.Size(100, 20)
        Me.SecondBox.TabIndex = 3
        Me.SecondBox.Text = "0"
        Me.SecondBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MillisecondBox
        '
        Me.MillisecondBox.Location = New System.Drawing.Point(621, 54)
        Me.MillisecondBox.Name = "MillisecondBox"
        Me.MillisecondBox.Size = New System.Drawing.Size(100, 20)
        Me.MillisecondBox.TabIndex = 4
        Me.MillisecondBox.Text = "0"
        Me.MillisecondBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HourLabel
        '
        Me.HourLabel.AutoSize = True
        Me.HourLabel.Location = New System.Drawing.Point(80, 61)
        Me.HourLabel.Name = "HourLabel"
        Me.HourLabel.Size = New System.Drawing.Size(40, 13)
        Me.HourLabel.TabIndex = 5
        Me.HourLabel.Text = "Hour/s"
        '
        'MinuteLabel
        '
        Me.MinuteLabel.AutoSize = True
        Me.MinuteLabel.Location = New System.Drawing.Point(230, 61)
        Me.MinuteLabel.Name = "MinuteLabel"
        Me.MinuteLabel.Size = New System.Drawing.Size(49, 13)
        Me.MinuteLabel.TabIndex = 6
        Me.MinuteLabel.Text = "Minute/s"
        '
        'SecondLabel
        '
        Me.SecondLabel.AutoSize = True
        Me.SecondLabel.Location = New System.Drawing.Point(389, 61)
        Me.SecondLabel.Name = "SecondLabel"
        Me.SecondLabel.Size = New System.Drawing.Size(54, 13)
        Me.SecondLabel.TabIndex = 7
        Me.SecondLabel.Text = "Second/s"
        '
        'MillisecondLabel
        '
        Me.MillisecondLabel.AutoSize = True
        Me.MillisecondLabel.Location = New System.Drawing.Point(553, 61)
        Me.MillisecondLabel.Name = "MillisecondLabel"
        Me.MillisecondLabel.Size = New System.Drawing.Size(63, 13)
        Me.MillisecondLabel.TabIndex = 8
        Me.MillisecondLabel.Text = "Milliscond/s"
        '
        'AutoClickButton
        '
        Me.AutoClickButton.Location = New System.Drawing.Point(249, 136)
        Me.AutoClickButton.Name = "AutoClickButton"
        Me.AutoClickButton.Size = New System.Drawing.Size(75, 23)
        Me.AutoClickButton.TabIndex = 9
        Me.AutoClickButton.Text = "Autoclick!"
        Me.AutoClickButton.UseVisualStyleBackColor = True
        '
        'TestButton
        '
        Me.TestButton.Location = New System.Drawing.Point(476, 136)
        Me.TestButton.Name = "TestButton"
        Me.TestButton.Size = New System.Drawing.Size(75, 23)
        Me.TestButton.TabIndex = 10
        Me.TestButton.Text = "Test"
        Me.TestButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(713, 118)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 58)
        Me.StopButton.TabIndex = 11
        Me.StopButton.Text = "STOP"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'TimeMeasureLabel
        '
        Me.TimeMeasureLabel.AutoSize = True
        Me.TimeMeasureLabel.Location = New System.Drawing.Point(551, 166)
        Me.TimeMeasureLabel.Name = "TimeMeasureLabel"
        Me.TimeMeasureLabel.Size = New System.Drawing.Size(0, 13)
        Me.TimeMeasureLabel.TabIndex = 12
        '
        'TestButtonClicksLabel
        '
        Me.TestButtonClicksLabel.AutoSize = True
        Me.TestButtonClicksLabel.Location = New System.Drawing.Point(476, 167)
        Me.TestButtonClicksLabel.Name = "TestButtonClicksLabel"
        Me.TestButtonClicksLabel.Size = New System.Drawing.Size(0, 13)
        Me.TestButtonClicksLabel.TabIndex = 13
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 192)
        Me.Controls.Add(Me.TestButtonClicksLabel)
        Me.Controls.Add(Me.TimeMeasureLabel)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.TestButton)
        Me.Controls.Add(Me.AutoClickButton)
        Me.Controls.Add(Me.MillisecondLabel)
        Me.Controls.Add(Me.SecondLabel)
        Me.Controls.Add(Me.MinuteLabel)
        Me.Controls.Add(Me.HourLabel)
        Me.Controls.Add(Me.MillisecondBox)
        Me.Controls.Add(Me.SecondBox)
        Me.Controls.Add(Me.MinuteBox)
        Me.Controls.Add(Me.HourBox)
        Me.Controls.Add(Me.ClickTimeLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.Text = "DocMarker Autoclicker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClickTimeLabel As Label
    Friend WithEvents HourBox As TextBox
    Friend WithEvents MinuteBox As TextBox
    Friend WithEvents SecondBox As TextBox
    Friend WithEvents MillisecondBox As TextBox
    Friend WithEvents HourLabel As Label
    Friend WithEvents MinuteLabel As Label
    Friend WithEvents SecondLabel As Label
    Friend WithEvents MillisecondLabel As Label
    Friend WithEvents AutoClickButton As Button
    Friend WithEvents TestButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents TimeMeasureLabel As Label
    Friend WithEvents TestButtonClicksLabel As Label
End Class
