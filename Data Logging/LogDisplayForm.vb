﻿'Zachary Christensen
'RCET Advanced Programming
'10/24/24
'Data Logging Assignment
'GitHub: https://github.com/Minidude140/Data-Logging


'TODO:
'[1/2]Add File Output {need to adjust Code to Save Low Byte}
'[]Add File Input
'[]Disconnect Error Handling
'[*]Add Variable Data Sample Rate

Imports System.Threading
Public Class LogDisplayForm
    'Data list formatted for Graphing
    Dim DataList As New List(Of Integer)
    'Data List formatted for Graphing (only 30 Seconds of Data)
    Dim limitDataList As New List(Of Integer)
    'Raw Data Input List
    Dim InputDataList As New List(Of Integer)
    'Max Input/Data Set Used for Scaling Graphing
    Dim maxInput As Integer = 249
    Dim maxDataSet As Integer

    Dim penColor As Color

    '********************Custom Methods*****************************************
    Sub SetDefaults()
        'Clear Graph
        DataGraphPictureBox.Refresh()
        'Start with 30 seconds data selected
        FullDataSetRadioButton.Checked = True
        FullDataSetMenuStrip.Enabled = False
        'Set pen color
        penColor = Color.Black
        'Disable Start Logging Button Until A QY@t Board is Connected
        StartLogButton.Enabled = False
        'Start with 10 samples per second data rate
        maxDataSet = 300
        DataCollectionTimer.Interval = 100
        SampleRateTextBox.Text = "10"
    End Sub

    ''' <summary>
    ''' Attempt Connection To Selected COM Port.  Verifies Selected COM is a QY@t Board
    ''' </summary>
    Sub ConnectCOM()
        COMSerialPort.PortName = COMSelectToolStripComboBox.SelectedItem
        COMSerialPort.BaudRate = 9600
        Try
            'Try to Open Selected COM
            COMSerialPort.Open()
            'Test if COM opened is a QY@t Board
            If GetQySettings() = True Then
                'Verified Selected COM as QY@t Board
                MsgBox("Successfully Connected to Selected COM Port.  Verified QY@ Board Input")
                'Enable Start Logging Button
                StartLogButton.Enabled = True
            Else
                'Not a QY@t Board Close COM
                MsgBox("Selected COM Port is not a QY@ Board")
                COMSerialPort.Close()
                'Disable Start Logging Button
                StartLogButton.Enabled = False
            End If
        Catch ex As Exception
            'Could Not Connect Close COM
            MsgBox("Sorry We Could Not Connect to Selected COM")
            COMSerialPort.Close()
            'Disable Start Logging Button
            StartLogButton.Enabled = False
        End Try
    End Sub

    ''' <summary>
    ''' Fill Combo Box With Available COM Ports
    ''' </summary>
    Sub PopulateCOMSelect()
        For Each portName In COMSerialPort.GetPortNames
            'add available Com Ports to combo box
            COMSelectToolStripComboBox.Items.Add(portName)
        Next

    End Sub

    ''' <summary>
    ''' Get Settings from Com Return True if Qy@ identifier is found
    ''' </summary>
    ''' <returns></returns>
    Function GetQySettings() As Boolean
        'Boolean Used to Check if COM is a Qy@ Board
        Dim isQY As Boolean = False
        'command QY Board to output settings data
        Dim command(0) As Byte
        command(0) = &B11110000
        COMSerialPort.Write(command, 0, 1)
        'Wait for Response
        Thread.Sleep(5)
        'create an array of bytes with the length of given bytes
        Dim data(COMSerialPort.BytesToRead) As Byte
        'populates data with incoming port data starting at 0 bit and reading the full bytes
        COMSerialPort.Read(data, 0, COMSerialPort.BytesToRead)
        'loops through the data array and writes each item to console (converts to hex)
        If data.Length < 61 Then
            'do nothing
        ElseIf data(58) = 81 And data(59) = 121 And data(60) = 64 Then
            'COM Selected is a Qy@ Board
            isQY = True
        End If
        Return isQY
    End Function

    ''' <summary>
    ''' Draws the Given Array Data onto the picture box
    ''' </summary>
    ''' <param name="plotData"></param>
    Sub Plot(plotData As List(Of Integer))
        'disable timer
        DataCollectionTimer.Enabled = False
        'clear old data
        DataGraphPictureBox.Refresh()
        Dim g As Graphics = DataGraphPictureBox.CreateGraphics
        Dim pen As New Pen(penColor)
        Dim oldx As Integer
        Dim oldy As Integer
        'scales the X to be the number of pixels in the picture box by max input value. 
        g.ScaleTransform(CSng(DataGraphPictureBox.Width / maxDataSet), 1)
        'iterate through the entire data set and plot each point on the screen or when initial data is empty in 30s mode
        For x = 0 To (plotData.Count - 1)
            g.DrawLine(pen, oldx, oldy, x, plotData.Item(x))
            oldx = x
            oldy = plotData.Item(x)
        Next
        DataCollectionTimer.Enabled = True
    End Sub

    ''' <summary>
    ''' Read Analog Input 1 and Return High MSB Byte
    ''' </summary>
    Function Qy_AnalogReadA1() As Integer
        'command to QY board to read analog data
        Dim command(0) As Byte
        command(0) = &B1010001
        COMSerialPort.Write(command, 0, 1)
        'Wait for Response
        Thread.Sleep(5)
        'create an array of bytes with the length of input data
        Dim data(COMSerialPort.BytesToRead) As Byte
        'Populate array with input data
        COMSerialPort.Read(data, 0, COMSerialPort.BytesToRead)
        'Return the first Byte (MSB) 
        Return data(0)
    End Function

    ''' <summary>
    ''' Given a minimum and maximum, returns a random number within range.  
    ''' <br/>
    ''' Defaults:
    ''' <br/>
    ''' Min = 0     Max = 10
    ''' </summary>
    ''' <param name="min"></param>
    ''' <param name="max"></param>
    ''' <returns></returns>
    Function RandomNumberFrom(Optional min As Integer = 0, Optional max As Integer = 10) As Integer
        Dim _random As Integer
        'max = max + 1 to still get the max number (floor always rounds down)
        max += 1
        'randomize with current millisecond as seed
        Randomize(DateTime.Now.Millisecond)
        'set random number as random within bounds
        _random = CInt(Math.Floor(Rnd() * (max - min))) + min
        Return _random
    End Function

    Function VerifySampleRate() As Boolean
        Dim Valid As Boolean = False
        If IsNumeric(SampleRateTextBox.Text) Then
            If CInt(SampleRateTextBox.Text) > 0 And CInt(SampleRateTextBox.Text) < 101 Then
                MsgBox("Selection is Valid")
                Valid = True
            Else
                MsgBox("Please Enter a Number from 1 t0 100")
                SampleRateTextBox.Text = "10"
            End If
        Else
            MsgBox("Please Enter a Number")
            SampleRateTextBox.Text = "10"
        End If
        Return Valid
    End Function

    Sub ExportData()
        'Name file and open
        Dim fileName As String = "..\..\..\log_" & DateTime.Now.ToString("yyMMddhh") & ".log"
        Dim fileNumber As Integer = FreeFile()
        FileOpen(fileNumber, fileName, OpenMode.Append)
        WriteLine(fileNumber)
        For I = 0 To (DataList.Count - 1)
            Write(fileNumber, $"$$AN1,<{InputDataList(I)}>,<{DateTime.Now.ToString("yyMMddhhMMmm")}")
            WriteLine(fileNumber)
        Next
        FileClose(fileNumber)
        'Prompt user that the game has been saved
        MsgBox("Your Log Has Been Saved as: " + fileName)
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

    Private Sub StartLogButton_Click(sender As Object, e As EventArgs) Handles StartLogButton.Click,
                                                                               StartDataCollectionToolMenuStrip.Click
        'Start Data Collection Timer
        If DataCollectionTimer.Enabled = False Then
            DataCollectionTimer.Enabled = True
        End If
        If UpdateGraphTimer.Enabled = False Then
            UpdateGraphTimer.Enabled = True
        End If
    End Sub

    Private Sub StopLogButton_Click(sender As Object, e As EventArgs) Handles StopLogButton.Click,
                                                                              StopDataCollectionMenuStrip.Click
        'Stop Data Collection Timer
        If DataCollectionTimer.Enabled = True Then
            DataCollectionTimer.Enabled = False
        End If
        If UpdateGraphTimer.Enabled = True Then
            UpdateGraphTimer.Enabled = False
        End If
    End Sub

    Private Sub DataCollectionTimer_Tick(sender As Object, e As EventArgs) Handles DataCollectionTimer.Tick
        'Collect High Byte of Analog 1
        Dim newInput As Integer = Qy_AnalogReadA1()
        'Add Raw Data to Input List
        InputDataList.Add(newInput)
        'Scale Input to graph picture box size
        newInput = (((DataGraphPictureBox.Height - 50) / maxInput) * newInput) + 25
        'Add New Data Point to Data Set
        DataList.Add(newInput)
        If FullDataSetRadioButton.Checked = True Then
            'If Data Set exceeds 30 seconds of data smoosh scaling
            If DataList.Count >= maxDataSet Then
                maxDataSet += 1
            End If
        End If
        If DataList.Count > maxDataSet Then
            'Update 30s data list 
            limitDataList.Clear()
            For x = (DataList.Count - maxDataSet) To DataList.Count - 1
                limitDataList.Add(DataList(x))
            Next
        End If
    End Sub

    Private Sub UpdateGraphTimer_Tick(sender As Object, e As EventArgs) Handles UpdateGraphTimer.Tick
        'Plot Current Data Set
        If FullDataSetRadioButton.Checked = True Or DataList.Count <= maxDataSet Then
            'Plot full data amount and first 30s of data when initial data is empty
            Plot(DataList)
        ElseIf ThirtySecondsRadioButton.Checked = True And DataList.Count >= maxDataSet Then
            'Plot data limited to last 30s
            Plot(limitDataList)
        End If
    End Sub

    Private Sub ThirtySecondsRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ThirtySecondsRadioButton.CheckedChanged
        'Update Menu strip buttons to mirror radio buttons
        If ThirtySecondsRadioButton.Checked = True Then
            ThirtySecondsMenuStrip.Enabled = False
            FullDataSetMenuStrip.Enabled = True
        End If
        If FullDataSetRadioButton.Checked = True Then
            ThirtySecondsMenuStrip.Enabled = True
            FullDataSetMenuStrip.Enabled = False
        End If
    End Sub

    Private Sub ThirtySecondsMenuStrip_Click(sender As Object, e As EventArgs) Handles ThirtySecondsMenuStrip.Click
        'Update radio buttons when menu strip buttons are clicked
        ThirtySecondsRadioButton.Checked = True
    End Sub

    Private Sub FullDataSetMenuStrip_Click(sender As Object, e As EventArgs) Handles FullDataSetMenuStrip.Click
        'Update radio buttons when menu strip buttons are clicked
        FullDataSetRadioButton.Checked = True
    End Sub

    Private Sub SampleRateTextBox_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles SampleRateTextBox.PreviewKeyDown
        If CInt(e.KeyValue) = 13 Then
            If VerifySampleRate() = True Then
                'Update sample Rate and max data set
                Dim newSampleRate As Integer = CInt(SampleRateTextBox.Text)
                DataCollectionTimer.Interval = 1000 / newSampleRate
                maxDataSet = newSampleRate * 30
            End If
        End If
    End Sub

    Private Sub SaveDataButton_Click(sender As Object, e As EventArgs) Handles SaveDataButton.Click,
                                                                               SaveFileMenuStrip.Click
        ExportData()
    End Sub
End Class
