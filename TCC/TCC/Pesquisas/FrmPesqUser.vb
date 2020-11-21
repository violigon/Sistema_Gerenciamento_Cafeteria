Imports System.Data.SqlClient

Public Class FrmPesqUser

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridUser.CellContentClick

    End Sub

    Private Sub FrmPesqUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetUsuario.TB_Login' table. You can move, or remove it, as needed.
        'Me.TB_LoginTableAdapter.Fill(Me.DataSetUsuario.TB_Login)
        'TODO: This line of code loads data into the 'DataSetUser.TB_Login' table. You can move, or remove it, as needed.

    End Sub
    Function buscaruser(ByVal nome As String) As DataTable
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim adpt As New SqlDataAdapter("BuscarUsuario", con)

        adpt.SelectCommand.CommandType = CommandType.StoredProcedure
        adpt.SelectCommand.Parameters.Add(New SqlParameter("@Nome", SqlDbType.NVarChar, 100))
        adpt.SelectCommand.Parameters("@Nome").Value = (nome)

        Try
            con.Open()
            adpt.Fill(busca)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return busca


    End Function

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click

        FrmCadUsuario.txtCodUser.Text = CStr(DataGridUser.Item(0, DataGridUser.CurrentRow.Index).Value)
        FrmCadUsuario.txtLogin.Text = CStr(DataGridUser.Item(1, DataGridUser.CurrentRow.Index).Value)
        FrmCadUsuario.CBOCod.Text = CStr(DataGridUser.Item(3, DataGridUser.CurrentRow.Index).Value)
        FrmCadUsuario.txtCodFunc.Text = CStr(DataGridUser.Item(4, DataGridUser.CurrentRow.Index).Value)

        FrmCadUsuario.MdiParent = Me.MdiParent

        FrmCadUsuario.btnaltera.Visible = True
        FrmCadUsuario.btnsalvar.Visible = False
        FrmCadUsuario.btnaltera.Enabled = False
        FrmCadUsuario.txtCodFunc.ReadOnly = True
        FrmCadUsuario.txtLogin.ReadOnly = True
        FrmCadUsuario.txtsenha.ReadOnly = True


        Me.Close()





    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()

    End Sub

    Private Sub txtnome_TextChanged(sender As Object, e As EventArgs) Handles txtnome.TextChanged
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"

        DataGridUser.DataSource = buscaruser(txtnome.Text)
    End Sub
End Class