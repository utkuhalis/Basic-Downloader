Public Class Form1
    Dim save As New SaveFileDialog

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.Network.DownloadFile(TextBox1.Text, save.FileName, False, False, True, "60", True)
            TextBox2.Text = save.FileName
        End If

    End Sub
End Class
