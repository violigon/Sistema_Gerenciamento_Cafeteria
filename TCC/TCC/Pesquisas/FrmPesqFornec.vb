Imports System.Data.SqlClient

Public Class FrmPesqFornec


    Function buscarfornec(ByVal nome As String) As DataTable
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim adpt As New SqlDataAdapter("BuscarFornec", con)

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
        FrmCadFornec.txtcodfornec.Text = CStr(DataGridFornec.Item(0, DataGridFornec.CurrentRow.Index).Value)
        FrmCadFornec.mskcnpj.Text = CStr(DataGridFornec.Item(1, DataGridFornec.CurrentRow.Index).Value)
        FrmCadFornec.txtNomeFan.Text = CStr(DataGridFornec.Item(2, DataGridFornec.CurrentRow.Index).Value)
        FrmCadFornec.txtrazsoc.Text = CStr(DataGridFornec.Item(3, DataGridFornec.CurrentRow.Index).Value)
        FrmCadFornec.msktelefone.Text = CStr(DataGridFornec.Item(4, DataGridFornec.CurrentRow.Index).Value)
        FrmCadFornec.txtemail.Text = CStr(DataGridFornec.Item(5, DataGridFornec.CurrentRow.Index).Value)
        FrmCadFornec.mskCEP.Text = CStr(DataGridFornec.Item(6, DataGridFornec.CurrentRow.Index).Value)
        FrmCadFornec.txtLog.Text = CStr(DataGridFornec.Item(7, DataGridFornec.CurrentRow.Index).Value)
        FrmCadFornec.txtCidade.Text = CStr(DataGridFornec.Item(8, DataGridFornec.CurrentRow.Index).Value)
        FrmCadFornec.txtBairro.Text = CStr(DataGridFornec.Item(9, DataGridFornec.CurrentRow.Index).Value)
        FrmCadFornec.TxtNum.Text = CStr(DataGridFornec.Item(10, DataGridFornec.CurrentRow.Index).Value)
        FrmCadFornec.txtuf.Text = CStr(DataGridFornec.Item(11, DataGridFornec.CurrentRow.Index).Value)
        FrmCadFornec.txtsite.Text = CStr(DataGridFornec.Item(12, DataGridFornec.CurrentRow.Index).Value)

        FrmCadCli.MdiParent = Me.MdiParent

        Me.Close()


        'FrmCadCli.ShowDialog()

        FrmCadFornec.mskcnpj.ReadOnly = True
        FrmCadFornec.txtNomeFan.ReadOnly = True
        FrmCadFornec.txtrazsoc.ReadOnly = True
        FrmCadFornec.msktelefone.ReadOnly = True
        FrmCadFornec.txtemail.ReadOnly = True
        FrmCadFornec.mskCEP.ReadOnly = True
        FrmCadFornec.txtLog.ReadOnly = True
        FrmCadFornec.txtCidade.ReadOnly = True
        FrmCadFornec.txtBairro.ReadOnly = True
        FrmCadFornec.txtuf.ReadOnly = True
        FrmCadFornec.txtsite.ReadOnly = True


        FrmCadFornec.btnsalvar.Visible = False
        FrmCadFornec.btnAlterar.Visible = True
        FrmCadFornec.btnAlterar.Enabled = False


        FrmCadFornec.cbostatus.SelectedIndex = 0




    End Sub

    Private Sub txtnome_TextChanged(sender As Object, e As EventArgs) Handles txtnome.TextChanged
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"

        DataGridFornec.DataSource = buscarfornec(txtnome.Text)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()

    End Sub

    Private Sub FrmPesqFornec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetFornec.TBFornecedor' table. You can move, or remove it, as needed.
        ' Me.TBFornecedorTableAdapter.Fill(Me.DataSetFornec.TBFornecedor)

    End Sub

    Private Sub DataGridFunc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridFornec.CellContentClick

    End Sub
End Class