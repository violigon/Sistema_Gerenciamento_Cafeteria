Public Class FrmMensagem

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
        LimpaTela()
    End Sub
    Sub LimpaTela()
        txtassunto.Clear()
        txtemail.Clear()
        txtnome.Clear()
        txtmsg.Clear()
    End Sub

    Private Sub pbconsulta_Click(sender As Object, e As EventArgs) Handles pbconsulta.Click
        Me.Hide()
        FrmPesqMensagemWEBSITE.Show()
        ToolTip1.SetToolTip(pbconsulta, "Voltar")

    End Sub
End Class