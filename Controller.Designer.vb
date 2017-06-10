<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Controller
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
        Me.BrowseClaymore = New System.Windows.Forms.FolderBrowserDialog()
        Me.SelectClaymoreFdBt = New System.Windows.Forms.Button()
        Me.ClaymoreFdLabel = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.WaitTimerVal = New System.Windows.Forms.NumericUpDown()
        Me.WaitTimerLabel = New System.Windows.Forms.Label()
        Me.ActionGrp = New System.Windows.Forms.GroupBox()
        Me.RestartPCRd = New System.Windows.Forms.RadioButton()
        Me.RestartClayRd = New System.Windows.Forms.RadioButton()
        Me.DoNothingRd = New System.Windows.Forms.RadioButton()
        Me.LoadingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LogFilesList = New System.Windows.Forms.ComboBox()
        Me.LogFilesLabel = New System.Windows.Forms.Label()
        Me.OpenLogBt = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WorkerNameTb = New System.Windows.Forms.TextBox()
        CType(Me.WaitTimerVal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActionGrp.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SelectClaymoreFdBt
        '
        Me.SelectClaymoreFdBt.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SelectClaymoreFdBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SelectClaymoreFdBt.Location = New System.Drawing.Point(40, 65)
        Me.SelectClaymoreFdBt.Name = "SelectClaymoreFdBt"
        Me.SelectClaymoreFdBt.Size = New System.Drawing.Size(118, 57)
        Me.SelectClaymoreFdBt.TabIndex = 0
        Me.SelectClaymoreFdBt.Text = "Select" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Claymore folder"
        Me.SelectClaymoreFdBt.UseVisualStyleBackColor = False
        '
        'ClaymoreFdLabel
        '
        Me.ClaymoreFdLabel.AutoSize = True
        Me.ClaymoreFdLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClaymoreFdLabel.Location = New System.Drawing.Point(37, 26)
        Me.ClaymoreFdLabel.Name = "ClaymoreFdLabel"
        Me.ClaymoreFdLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.ClaymoreFdLabel.Size = New System.Drawing.Size(89, 23)
        Me.ClaymoreFdLabel.TabIndex = 1
        Me.ClaymoreFdLabel.Text = "Claymore folder"
        '
        'WaitTimerVal
        '
        Me.WaitTimerVal.Location = New System.Drawing.Point(126, 36)
        Me.WaitTimerVal.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.WaitTimerVal.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.WaitTimerVal.Name = "WaitTimerVal"
        Me.WaitTimerVal.Size = New System.Drawing.Size(43, 20)
        Me.WaitTimerVal.TabIndex = 2
        Me.WaitTimerVal.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'WaitTimerLabel
        '
        Me.WaitTimerLabel.AutoSize = True
        Me.WaitTimerLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WaitTimerLabel.Location = New System.Drawing.Point(11, 27)
        Me.WaitTimerLabel.Name = "WaitTimerLabel"
        Me.WaitTimerLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.WaitTimerLabel.Size = New System.Drawing.Size(100, 36)
        Me.WaitTimerLabel.TabIndex = 3
        Me.WaitTimerLabel.Text = "Wait for restarting" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(in min)"
        '
        'ActionGrp
        '
        Me.ActionGrp.BackColor = System.Drawing.Color.LemonChiffon
        Me.ActionGrp.Controls.Add(Me.RestartPCRd)
        Me.ActionGrp.Controls.Add(Me.RestartClayRd)
        Me.ActionGrp.Controls.Add(Me.WaitTimerVal)
        Me.ActionGrp.Controls.Add(Me.WaitTimerLabel)
        Me.ActionGrp.Controls.Add(Me.DoNothingRd)
        Me.ActionGrp.Location = New System.Drawing.Point(12, 161)
        Me.ActionGrp.Name = "ActionGrp"
        Me.ActionGrp.Size = New System.Drawing.Size(183, 199)
        Me.ActionGrp.TabIndex = 4
        Me.ActionGrp.TabStop = False
        Me.ActionGrp.Text = "Action"
        '
        'RestartPCRd
        '
        Me.RestartPCRd.AutoSize = True
        Me.RestartPCRd.Location = New System.Drawing.Point(14, 160)
        Me.RestartPCRd.Name = "RestartPCRd"
        Me.RestartPCRd.Size = New System.Drawing.Size(76, 17)
        Me.RestartPCRd.TabIndex = 2
        Me.RestartPCRd.Text = "Restart PC"
        Me.RestartPCRd.UseVisualStyleBackColor = True
        '
        'RestartClayRd
        '
        Me.RestartClayRd.AutoSize = True
        Me.RestartClayRd.Location = New System.Drawing.Point(14, 122)
        Me.RestartClayRd.Name = "RestartClayRd"
        Me.RestartClayRd.Size = New System.Drawing.Size(105, 17)
        Me.RestartClayRd.TabIndex = 1
        Me.RestartClayRd.Text = "Restart Claymore"
        Me.RestartClayRd.UseVisualStyleBackColor = True
        '
        'DoNothingRd
        '
        Me.DoNothingRd.AutoSize = True
        Me.DoNothingRd.Location = New System.Drawing.Point(14, 87)
        Me.DoNothingRd.Name = "DoNothingRd"
        Me.DoNothingRd.Size = New System.Drawing.Size(77, 17)
        Me.DoNothingRd.TabIndex = 0
        Me.DoNothingRd.Text = "Do nothing"
        Me.DoNothingRd.UseVisualStyleBackColor = True
        '
        'LoadingTimer
        '
        Me.LoadingTimer.Enabled = True
        Me.LoadingTimer.Interval = 30000
        '
        'LogFilesList
        '
        Me.LogFilesList.FormattingEnabled = True
        Me.LogFilesList.Location = New System.Drawing.Point(24, 57)
        Me.LogFilesList.Name = "LogFilesList"
        Me.LogFilesList.Size = New System.Drawing.Size(208, 21)
        Me.LogFilesList.TabIndex = 5
        '
        'LogFilesLabel
        '
        Me.LogFilesLabel.AutoSize = True
        Me.LogFilesLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogFilesLabel.Location = New System.Drawing.Point(24, 18)
        Me.LogFilesLabel.Name = "LogFilesLabel"
        Me.LogFilesLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.LogFilesLabel.Size = New System.Drawing.Size(124, 23)
        Me.LogFilesLabel.TabIndex = 6
        Me.LogFilesLabel.Text = "Log files ( last 20 logs )"
        '
        'OpenLogBt
        '
        Me.OpenLogBt.Location = New System.Drawing.Point(24, 96)
        Me.OpenLogBt.Name = "OpenLogBt"
        Me.OpenLogBt.Size = New System.Drawing.Size(90, 34)
        Me.OpenLogBt.TabIndex = 7
        Me.OpenLogBt.Text = "Open log file"
        Me.OpenLogBt.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OpenLogBt)
        Me.GroupBox1.Controls.Add(Me.LogFilesList)
        Me.GroupBox1.Controls.Add(Me.LogFilesLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(250, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 155)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Log"
        '
        'WorkerNameTb
        '
        Me.WorkerNameTb.Location = New System.Drawing.Point(250, 102)
        Me.WorkerNameTb.Name = "WorkerNameTb"
        Me.WorkerNameTb.Size = New System.Drawing.Size(100, 20)
        Me.WorkerNameTb.TabIndex = 9
        Me.WorkerNameTb.Text = "Miner01"
        '
        'Controller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(518, 392)
        Me.Controls.Add(Me.WorkerNameTb)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ActionGrp)
        Me.Controls.Add(Me.ClaymoreFdLabel)
        Me.Controls.Add(Me.SelectClaymoreFdBt)
        Me.Name = "Controller"
        Me.Text = "Claymore controller"
        CType(Me.WaitTimerVal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActionGrp.ResumeLayout(False)
        Me.ActionGrp.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BrowseClaymore As FolderBrowserDialog
    Friend WithEvents SelectClaymoreFdBt As Button
    Friend WithEvents ClaymoreFdLabel As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents WaitTimerVal As NumericUpDown
    Friend WithEvents WaitTimerLabel As Label
    Friend WithEvents ActionGrp As GroupBox
    Friend WithEvents RestartPCRd As RadioButton
    Friend WithEvents RestartClayRd As RadioButton
    Friend WithEvents DoNothingRd As RadioButton
    Friend WithEvents LoadingTimer As Timer
    Friend WithEvents LogFilesList As ComboBox
    Friend WithEvents LogFilesLabel As Label
    Friend WithEvents OpenLogBt As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents WorkerNameTb As TextBox
End Class
