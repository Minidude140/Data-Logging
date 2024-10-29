'Zachary Christensen
'RCET Advanced Programming
'10/24/24
'Data Logging Assignment
'GitHub: https://github.com/Minidude140/Data-Logging


Public Class LogDisplayForm

    '********************Custom Methods*****************************************
    Sub SetDefaults()
        'Clear Graph
        DataGraphPictureBox.Refresh()
        'Start with 30 seconds data selected
        ThirtySecondsRadioButton.Checked = True
        ThirtySecondsMenuStrip.Enabled = False
    End Sub

    Sub ConnectCOM()
        COMSerialPort.PortName = COMSelectToolStripComboBox.SelectedIndex
        COMSerialPort.BaudRate = 9600
        COMSerialPort.Open()
    End Sub

    Sub PopulateCOMSelect()
        For Each portName In SerialPort1.GetPortNames
            'add available Com Ports to combo box
            COMSelectToolStripComboBox.Items.Add(portName)
        Next

    End Sub

    '********************Event Handlers*****************************************

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LogDisplayForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
        'Load COM Select Combo Box with available COM Ports
        PopulateCOMSelect()
    End Sub

    Private Sub ConnectCOMToolStripButton_Click(sender As Object, e As EventArgs) Handles ConnectCOMToolStripButton.Click
        ConnectCOM()
    End Sub
End Class
