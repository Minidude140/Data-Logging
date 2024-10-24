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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SaveDataButton = New System.Windows.Forms.Button()
        Me.StartLogButton = New System.Windows.Forms.Button()
        Me.StopLogButton = New System.Windows.Forms.Button()
        Me.DataGraphPictureBox = New System.Windows.Forms.PictureBox()
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
        Me.StartLogButton.Location = New System.Drawing.Point(12, 514)
        Me.StartLogButton.Name = "StartLogButton"
        Me.StartLogButton.Size = New System.Drawing.Size(139, 68)
        Me.StartLogButton.TabIndex = 2
        Me.StartLogButton.Text = "Start Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Collection"
        Me.StartLogButton.UseVisualStyleBackColor = True
        '
        'StopLogButton
        '
        Me.StopLogButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopLogButton.Location = New System.Drawing.Point(157, 514)
        Me.StopLogButton.Name = "StopLogButton"
        Me.StopLogButton.Size = New System.Drawing.Size(139, 68)
        Me.StopLogButton.TabIndex = 3
        Me.StopLogButton.Text = "Stop Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Collection"
        Me.StopLogButton.UseVisualStyleBackColor = True
        '
        'DataGraphPictureBox
        '
        Me.DataGraphPictureBox.Location = New System.Drawing.Point(12, 55)
        Me.DataGraphPictureBox.Name = "DataGraphPictureBox"
        Me.DataGraphPictureBox.Size = New System.Drawing.Size(989, 440)
        Me.DataGraphPictureBox.TabIndex = 4
        Me.DataGraphPictureBox.TabStop = False
        '
        'LogDisplayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 594)
        Me.Controls.Add(Me.DataGraphPictureBox)
        Me.Controls.Add(Me.StopLogButton)
        Me.Controls.Add(Me.StartLogButton)
        Me.Controls.Add(Me.SaveDataButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "LogDisplayForm"
        Me.Text = "Data Logger"
        CType(Me.DataGraphPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents SaveDataButton As Button
    Friend WithEvents StartLogButton As Button
    Friend WithEvents StopLogButton As Button
    Friend WithEvents DataGraphPictureBox As PictureBox
End Class
