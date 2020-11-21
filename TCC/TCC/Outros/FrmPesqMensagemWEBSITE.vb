Imports System.Data.SqlClient

Public Class FrmPesqMensagemWEBSITE

    Private Sub FrmFaleConoscoWebsite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TBMSGTableAdapter.Fill(Me.TBfaleconoscoMaiscaféDataSet.TBMSG)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()

    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click

        FrmMensagem.txtnome.Text = CStr(DataGridMsg.Item(1, DataGridMsg.CurrentRow.Index).Value)
        FrmMensagem.txtassunto.Text = CStr(DataGridMsg.Item(2, DataGridMsg.CurrentRow.Index).Value)

        Dim con As SqlConnection
        con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=TBfaleconoscoMaiscafé;Persist Security Info=True;User ID=sa;Password=123456")
        con.Open()
        Dim sqlCommand As SqlCommand = New SqlCommand("select * from TBMSG where codmsg =" & DataGridMsg.Item(0, DataGridMsg.CurrentRow.Index).Value & "", con)
        Dim sqlReader As SqlDataReader

        sqlReader = sqlCommand.ExecuteReader()
        If sqlReader.Read() Then
            FrmMensagem.txtemail.Text = sqlReader.GetString(1)
            FrmMensagem.txtmsg.Text = sqlReader.GetString(4)

        End If
        sqlReader.Close()
        con.Close()



        FrmMensagem.Show()
        Me.Close()

    End Sub
End Class