Public Class FrmBackupRestore

   

    Private Sub pbbackup_Click(sender As Object, e As EventArgs) Handles pbbackup.Click
        Dim bkp As New BackupRestore

        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.DefaultExt = ".bak"

        SaveFileDialog1.ShowDialog()

        txtcaminho.Text = SaveFileDialog1.FileName

        Dim resposta As String = bkp.Backup(SaveFileDialog1.FileName)

        MessageBox.Show(resposta)
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles pbrestore.Click
        Dim rst As New BackupRestore

        OpenFileDialog1.AddExtension = True
        OpenFileDialog1.DefaultExt = ".bak"
        OpenFileDialog1.Title = "Escolha um backup para restaurar"

        OpenFileDialog1.ShowDialog()

        txtcaminho.Text = OpenFileDialog1.FileName

        If txtcaminho.Text.Equals(Nothing) Then
            MessageBox.Show("Escolha um backup para restaurar!")
        Else
            Dim resposta As String = rst.Restore(OpenFileDialog1.FileName)

            MessageBox.Show(resposta)
        End If
    End Sub

    Private Sub pbrestore_Click(sender As Object, e As EventArgs) Handles pbrestore.Click
        Dim rst As New BackupRestore

        OpenFileDialog1.AddExtension = True
        OpenFileDialog1.DefaultExt = ".bak"
        OpenFileDialog1.Title = "Escolha um backup para restaurar"

        OpenFileDialog1.ShowDialog()

        txtcaminho.Text = OpenFileDialog1.FileName

        If txtcaminho.Text.Equals(Nothing) Then
            MessageBox.Show("Escolha um backup para restaurar!")
        Else
            Dim resposta As String = rst.Restore(OpenFileDialog1.FileName)

            MessageBox.Show(resposta)
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        txtcaminho.Clear()
        Me.Close()

    End Sub
End Class