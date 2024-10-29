'Zachary Christensen
'RCET Advanced Programming
'10/24/24
'Data Logging Assignment
'GitHub: https://github.com/Minidude140/Data-Logging


Public Class LogDisplayForm

    '********************Custom Methods*****************************************
    Sub SetDefaults()
        DataGraphPictureBox.Refresh()
        ThirtySecondsRadioButton.Checked = True
        ThirtySecondsMenuStrip.Enabled = False
    End Sub

    '********************Event Handlers*****************************************

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LogDisplayForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub
End Class
