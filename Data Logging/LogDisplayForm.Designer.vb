<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogDisplayForm
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SaveDataButton = New System.Windows.Forms.Button()
        Me.StartLogButton = New System.Windows.Forms.Button()
        Me.StopLogButton = New System.Windows.Forms.Button()
        Me.ThirtySecondsRadioButton = New System.Windows.Forms.RadioButton()
        Me.EntireHistoryRadioButton = New System.Windows.Forms.RadioButton()
        Me.DataCollectionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.COMSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ComboBoxToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ConnectCOMToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.DataGraphPictureBox = New System.Windows.Forms.PictureBox()
        Me.DataCollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartDataCollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopDataCollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayLast30sToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayFullDataSetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
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
        Me.ThirtySecondsRadioButton.UseVisualStyleBackColor = True
        '
        'EntireHistoryRadioButton
        '
        Me.EntireHistoryRadioButton.AutoSize = True
        Me.EntireHistoryRadioButton.Location = New System.Drawing.Point(320, 554)
        Me.EntireHistoryRadioButton.Name = "EntireHistoryRadioButton"
        Me.EntireHistoryRadioButton.Size = New System.Drawing.Size(160, 21)
        Me.EntireHistoryRadioButton.TabIndex = 6
        Me.EntireHistoryRadioButton.TabStop = True
        Me.EntireHistoryRadioButton.Text = "Display Full Data Set"
        Me.EntireHistoryRadioButton.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataCollectionToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1014, 28)
        Me.MenuStrip.TabIndex = 7
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComboBoxToolStripComboBox, Me.ConnectCOMToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1014, 28)
        Me.ToolStrip.TabIndex = 8
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ComboBoxToolStripComboBox
        '
        Me.ComboBoxToolStripComboBox.Name = "ComboBoxToolStripComboBox"
        Me.ComboBoxToolStripComboBox.Size = New System.Drawing.Size(121, 28)
        '
        'ConnectCOMToolStripButton
        '
        Me.ConnectCOMToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConnectCOMToolStripButton.Image = Global.Data_Logging.My.Resources.Resources.icons8_usb_connector_30
        Me.ConnectCOMToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConnectCOMToolStripButton.Name = "ConnectCOMToolStripButton"
        Me.ConnectCOMToolStripButton.Size = New System.Drawing.Size(29, 25)
        Me.ConnectCOMToolStripButton.Text = "ToolStripButton1"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Location = New System.Drawing.Point(0, 586)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1014, 22)
        Me.StatusStrip.TabIndex = 9
        Me.StatusStrip.Text = "StatusStrip1"
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
        'DataCollectionToolStripMenuItem
        '
        Me.DataCollectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartDataCollectionToolStripMenuItem, Me.StopDataCollectionToolStripMenuItem, Me.DisplayLast30sToolStripMenuItem, Me.DisplayFullDataSetToolStripMenuItem})
        Me.DataCollectionToolStripMenuItem.Name = "DataCollectionToolStripMenuItem"
        Me.DataCollectionToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.DataCollectionToolStripMenuItem.Text = "Data Collection"
        '
        'StartDataCollectionToolStripMenuItem
        '
        Me.StartDataCollectionToolStripMenuItem.Name = "StartDataCollectionToolStripMenuItem"
        Me.StartDataCollectionToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.StartDataCollectionToolStripMenuItem.Text = "Start Data Collection"
        '
        'StopDataCollectionToolStripMenuItem
        '
        Me.StopDataCollectionToolStripMenuItem.Name = "StopDataCollectionToolStripMenuItem"
        Me.StopDataCollectionToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.StopDataCollectionToolStripMenuItem.Text = "Stop Data Collection"
        '
        'DisplayLast30sToolStripMenuItem
        '
        Me.DisplayLast30sToolStripMenuItem.Name = "DisplayLast30sToolStripMenuItem"
        Me.DisplayLast30sToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.DisplayLast30sToolStripMenuItem.Text = "Display Last 30s"
        '
        'DisplayFullDataSetToolStripMenuItem
        '
        Me.DisplayFullDataSetToolStripMenuItem.Name = "DisplayFullDataSetToolStripMenuItem"
        Me.DisplayFullDataSetToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.DisplayFullDataSetToolStripMenuItem.Text = "Display Full Data Set"
        '
        'LogDisplayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 608)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.EntireHistoryRadioButton)
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
    Friend WithEvents EntireHistoryRadioButton As RadioButton
    Friend WithEvents DataCollectionTimer As Timer
    Friend WithEvents COMSerialPort As IO.Ports.SerialPort
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBoxToolStripComboBox As ToolStripComboBox
    Friend WithEvents ConnectCOMToolStripButton As ToolStripButton
    Friend WithEvents DataCollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartDataCollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopDataCollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayLast30sToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayFullDataSetToolStripMenuItem As ToolStripMenuItem
End Class
