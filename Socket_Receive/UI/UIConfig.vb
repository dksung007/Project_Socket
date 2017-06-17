Public Class UIConfig
    Private Sub btn_path_Click(sender As Object, e As EventArgs) Handles btn_path.Click
        Dim f As New FolderBrowserDialog()
        f.ShowDialog()
        txt_path.Text = f.SelectedPath
    End Sub

    Private Sub UIConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

    End Sub
End Class