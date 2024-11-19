<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogDisplayForm
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
        Me.components = New System.ComponentModel.Container()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SaveDataButton = New System.Windows.Forms.Button()
        Me.StartLogButton = New System.Windows.Forms.Button()
        Me.StopLogButton = New System.Windows.Forms.Button()
        Me.ThirtySecondsRadioButton = New System.Windows.Forms.RadioButton()
        Me.FullDataSetRadioButton = New System.Windows.Forms.RadioButton()
        Me.DataCollectionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.COMSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SampleRateTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataCollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartDataCollectionToolMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopDataCollectionMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThirtySecondsMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullDataSetMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.COMSelectToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ConnectCOMToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.COMStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BlankStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FileSaveStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataGraphPictureBox = New System.Windows.Forms.PictureBox()
        Me.UpdateGraphTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SampleRateLabel = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.DataGraphPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(863, 514)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(139, 68)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "Exit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Exit the Program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SaveDataButton
        '
        Me.SaveDataButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveDataButton.Location = New System.Drawing.Point(700, 514)
        Me.SaveDataButton.Name = "SaveDataButton"
        Me.SaveDataButton.Size = New System.Drawing.Size(139, 68)
        Me.SaveDataButton.TabIndex = 1
        Me.SaveDataButton.Text = "Save Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To File"
        Me.ToolTip.SetToolTip(Me.SaveDataButton, "Export Data to FIle")
        Me.SaveDataButton.UseVisualStyleBackColor = True
        '
        'StartLogButton
        '
        Me.StartLogButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartLogButton.Location = New System.Drawing.Point(10, 507)
        Me.StartLogButton.Name = "StartLogButton"
        Me.StartLogButton.Size = New System.Drawing.Size(139, 68)
        Me.StartLogButton.TabIndex = 2
        Me.StartLogButton.Text = "Start Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Collection"
        Me.ToolTip.SetToolTip(Me.StartLogButton, "Begin Collecting Data From COM Input" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.StartLogButton.UseVisualStyleBackColor = True
        '
        'StopLogButton
        '
        Me.StopLogButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopLogButton.Location = New System.Drawing.Point(155, 507)
        Me.StopLogButton.Name = "StopLogButton"
        Me.StopLogButton.Size = New System.Drawing.Size(139, 68)
        Me.StopLogButton.TabIndex = 3
        Me.StopLogButton.Text = "Stop Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Collection"
        Me.ToolTip.SetToolTip(Me.StopLogButton, "Stop Collecting Data From COM Input")
        Me.StopLogButton.UseVisualStyleBackColor = True
        '
        'ThirtySecondsRadioButton
        '
        Me.ThirtySecondsRadioButton.AutoSize = True
        Me.ThirtySecondsRadioButton.Location = New System.Drawing.Point(320, 507)
        Me.ThirtySecondsRadioButton.Name = "ThirtySecondsRadioButton"
        Me.ThirtySecondsRadioButton.Size = New System.Drawing.Size(133, 21)
        Me.ThirtySecondsRadioButton.TabIndex = 5
        Me.ThirtySecondsRadioButton.TabStop = True
        Me.ThirtySecondsRadioButton.Text = "Display Last 30s"
        Me.ToolTip.SetToolTip(Me.ThirtySecondsRadioButton, "Display Only the Last 30 Seconds of Data Collected")
        Me.ThirtySecondsRadioButton.UseVisualStyleBackColor = True
        '
        'FullDataSetRadioButton
        '
        Me.FullDataSetRadioButton.AutoSize = True
        Me.FullDataSetRadioButton.Location = New System.Drawing.Point(320, 554)
        Me.FullDataSetRadioButton.Name = "FullDataSetRadioButton"
        Me.FullDataSetRadioButton.Size = New System.Drawing.Size(160, 21)
        Me.FullDataSetRadioButton.TabIndex = 6
        Me.FullDataSetRadioButton.TabStop = True
        Me.FullDataSetRadioButton.Text = "Display Full Data Set"
        Me.ToolTip.SetToolTip(Me.FullDataSetRadioButton, "Display Entire History Of Data Collected")
        Me.FullDataSetRadioButton.UseVisualStyleBackColor = True
        '
        'DataCollectionTimer
        '
        '
        'SampleRateTextBox
        '
        Me.SampleRateTextBox.Location = New System.Drawing.Point(536, 553)
        Me.SampleRateTextBox.Name = "SampleRateTextBox"
        Me.SampleRateTextBox.Size = New System.Drawing.Size(113, 22)
        Me.SampleRateTextBox.TabIndex = 12
        Me.ToolTip.SetToolTip(Me.SampleRateTextBox, "Press Enter to Submit Sample Rate")
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataCollectionToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1014, 30)
        Me.MenuStrip.TabIndex = 7
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileMenuStrip, Me.SaveFileMenuStrip})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 26)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenFileMenuStrip
        '
        Me.OpenFileMenuStrip.Name = "OpenFileMenuStrip"
        Me.OpenFileMenuStrip.Size = New System.Drawing.Size(224, 26)
        Me.OpenFileMenuStrip.Text = "Open"
        '
        'SaveFileMenuStrip
        '
        Me.SaveFileMenuStrip.Name = "SaveFileMenuStrip"
        Me.SaveFileMenuStrip.Size = New System.Drawing.Size(224, 26)
        Me.SaveFileMenuStrip.Text = "Save"
        '
        'DataCollectionToolStripMenuItem
        '
        Me.DataCollectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartDataCollectionToolMenuStrip, Me.StopDataCollectionMenuStrip, Me.ThirtySecondsMenuStrip, Me.FullDataSetMenuStrip})
        Me.DataCollectionToolStripMenuItem.Name = "DataCollectionToolStripMenuItem"
        Me.DataCollectionToolStripMenuItem.Size = New System.Drawing.Size(126, 26)
        Me.DataCollectionToolStripMenuItem.Text = "Data Collection"
        '
        'StartDataCollectionToolMenuStrip
        '
        Me.StartDataCollectionToolMenuStrip.Name = "StartDataCollectionToolMenuStrip"
        Me.StartDataCollectionToolMenuStrip.Size = New System.Drawing.Size(230, 26)
        Me.StartDataCollectionToolMenuStrip.Text = "Start Data Collection"
        '
        'StopDataCollectionMenuStrip
        '
        Me.StopDataCollectionMenuStrip.Name = "StopDataCollectionMenuStrip"
        Me.StopDataCollectionMenuStrip.Size = New System.Drawing.Size(230, 26)
        Me.StopDataCollectionMenuStrip.Text = "Stop Data Collection"
        '
        'ThirtySecondsMenuStrip
        '
        Me.ThirtySecondsMenuStrip.Name = "ThirtySecondsMenuStrip"
        Me.ThirtySecondsMenuStrip.Size = New System.Drawing.Size(230, 26)
        Me.ThirtySecondsMenuStrip.Text = "Display Last 30s"
        '
        'FullDataSetMenuStrip
        '
        Me.FullDataSetMenuStrip.Name = "FullDataSetMenuStrip"
        Me.FullDataSetMenuStrip.Size = New System.Drawing.Size(230, 26)
        Me.FullDataSetMenuStrip.Text = "Display Full Data Set"
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMSelectToolStripComboBox, Me.ConnectCOMToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 30)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1014, 31)
        Me.ToolStrip.TabIndex = 8
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'COMSelectToolStripComboBox
        '
        Me.COMSelectToolStripComboBox.Name = "COMSelectToolStripComboBox"
        Me.COMSelectToolStripComboBox.Size = New System.Drawing.Size(121, 31)
        Me.COMSelectToolStripComboBox.ToolTipText = "Select Available COM Ports"
        '
        'ConnectCOMToolStripButton
        '
        Me.ConnectCOMToolStripButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ConnectCOMToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConnectCOMToolStripButton.Image = Global.Data_Logging.My.Resources.Resources.icons8_usb_connector_30
        Me.ConnectCOMToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConnectCOMToolStripButton.Name = "ConnectCOMToolStripButton"
        Me.ConnectCOMToolStripButton.Size = New System.Drawing.Size(29, 28)
        Me.ConnectCOMToolStripButton.Text = "ToolStripButton1"
        Me.ConnectCOMToolStripButton.ToolTipText = "Attempt to Connect to Selected COM Port" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Must Successfully Connect Before Loggin" &
    "g Can Begin)"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMStatusLabel, Me.BlankStatusLabel, Me.FileSaveStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 582)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1014, 26)
        Me.StatusStrip.TabIndex = 9
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'COMStatusLabel
        '
        Me.COMStatusLabel.Name = "COMStatusLabel"
        Me.COMStatusLabel.Size = New System.Drawing.Size(109, 20)
        Me.COMStatusLabel.Text = "Not Connected"
        '
        'BlankStatusLabel
        '
        Me.BlankStatusLabel.Name = "BlankStatusLabel"
        Me.BlankStatusLabel.Size = New System.Drawing.Size(89, 20)
        Me.BlankStatusLabel.Text = "                    "
        '
        'FileSaveStatusLabel
        '
        Me.FileSaveStatusLabel.Name = "FileSaveStatusLabel"
        Me.FileSaveStatusLabel.Size = New System.Drawing.Size(99, 20)
        Me.FileSaveStatusLabel.Text = "File:                "
        '
        'DataGraphPictureBox
        '
        Me.DataGraphPictureBox.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGraphPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGraphPictureBox.Location = New System.Drawing.Point(12, 55)
        Me.DataGraphPictureBox.Name = "DataGraphPictureBox"
        Me.DataGraphPictureBox.Size = New System.Drawing.Size(989, 433)
        Me.DataGraphPictureBox.TabIndex = 4
        Me.DataGraphPictureBox.TabStop = False
        '
        'UpdateGraphTimer
        '
        Me.UpdateGraphTimer.Interval = 500
        '
        'SampleRateLabel
        '
        Me.SampleRateLabel.AutoSize = True
        Me.SampleRateLabel.Location = New System.Drawing.Point(533, 514)
        Me.SampleRateLabel.Name = "SampleRateLabel"
        Me.SampleRateLabel.Size = New System.Drawing.Size(123, 17)
        Me.SampleRateLabel.TabIndex = 11
        Me.SampleRateLabel.Text = "Data Sample Rate"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        Me.OpenFileDialog.Filter = ".log|"
        Me.OpenFileDialog.InitialDirectory = "..\..\..\"
        '
        'LogDisplayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 608)
        Me.Controls.Add(Me.SampleRateTextBox)
        Me.Controls.Add(Me.SampleRateLabel)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.FullDataSetRadioButton)
        Me.Controls.Add(Me.ThirtySecondsRadioButton)
        Me.Controls.Add(Me.DataGraphPictureBox)
        Me.Controls.Add(Me.StopLogButton)
        Me.Controls.Add(Me.StartLogButton)
        Me.Controls.Add(Me.SaveDataButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "LogDisplayForm"
        Me.Text = "Data Logger"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.DataGraphPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents SaveDataButton As Button
    Friend WithEvents StartLogButton As Button
    Friend WithEvents StopLogButton As Button
    Friend WithEvents DataGraphPictureBox As PictureBox
    Friend WithEvents ThirtySecondsRadioButton As RadioButton
    Friend WithEvents FullDataSetRadioButton As RadioButton
    Friend WithEvents DataCollectionTimer As Timer
    Friend WithEvents COMSerialPort As IO.Ports.SerialPort
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileMenuStrip As ToolStripMenuItem
    Friend WithEvents SaveFileMenuStrip As ToolStripMenuItem
    Friend WithEvents COMSelectToolStripComboBox As ToolStripComboBox
    Friend WithEvents ConnectCOMToolStripButton As ToolStripButton
    Friend WithEvents DataCollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartDataCollectionToolMenuStrip As ToolStripMenuItem
    Friend WithEvents StopDataCollectionMenuStrip As ToolStripMenuItem
    Friend WithEvents ThirtySecondsMenuStrip As ToolStripMenuItem
    Friend WithEvents FullDataSetMenuStrip As ToolStripMenuItem
    Friend WithEvents UpdateGraphTimer As Timer
    Friend WithEvents SampleRateLabel As Label
    Friend WithEvents SampleRateTextBox As TextBox
    Friend WithEvents COMStatusLabel As ToolStripStatusLabel
    Friend WithEvents BlankStatusLabel As ToolStripStatusLabel
    Friend WithEvents FileSaveStatusLabel As ToolStripStatusLabel
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
