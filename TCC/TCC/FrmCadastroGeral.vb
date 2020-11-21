Public Class FrmCadastrosGeral

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        FrmCadCli.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        FrmCadFunc.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        FrmCadFornec.ShowDialog()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        FrmCadProd.ShowDialog()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        FrmCadUsuario.ShowDialog()
    End Sub
End Class