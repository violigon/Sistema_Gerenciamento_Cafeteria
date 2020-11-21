Imports System.Data.SqlClient

Public Class FrmPesqProd

    Private Sub FrmPesqProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetProduto.TBProdutos' table. You can move, or remove it, as needed.
        ' Me.TBProdutosTableAdapter.Fill(Me.DataSetProduto.TBProdutos)

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        FrmCadProd.txtCodProd.Text = CStr(DataGridProd.Item(0, DataGridProd.CurrentRow.Index).Value)
        FrmCadProd.txtnome.Text = CStr(DataGridProd.Item(1, DataGridProd.CurrentRow.Index).Value)
        FrmCadProd.CboTipo.Text = CStr(DataGridProd.Item(2, DataGridProd.CurrentRow.Index).Value)
        FrmCadProd.CboUnid.Text = CStr(DataGridProd.Item(3, DataGridProd.CurrentRow.Index).Value)
        FrmCadProd.txtcusto.Text = CStr(Format(DataGridProd.Item(4, DataGridProd.CurrentRow.Index).Value, "###,##0.00"))
        FrmCadProd.txtpreçovenda.Text = CStr(Format(DataGridProd.Item(5, DataGridProd.CurrentRow.Index).Value, "###,##0.00"))
        FrmCadProd.txtqtd.Text = CStr(Format(DataGridProd.Item(6, DataGridProd.CurrentRow.Index).Value, "###,##0.000"))
        FrmCadProd.MdiParent = Me.MdiParent

        Me.Close()


        FrmCadProd.CboTipo.Enabled = False
        FrmCadProd.CboUnid.Enabled = False
        FrmCadProd.txtnome.ReadOnly = True
        FrmCadProd.txtpreçovenda.ReadOnly = True
        FrmCadProd.txtcusto.ReadOnly = True
        FrmCadProd.rbtsim.Enabled = False
        FrmCadProd.rbtnao.Enabled = False

        FrmCadProd.cbostatus.SelectedIndex = 0
    End Sub
    Function buscarproduto(ByVal nome As String) As DataTable
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim adpt As New SqlDataAdapter("BuscarProd", con)

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
        Me.Close()


    End Function

    Private Sub txtnome_TextChanged(sender As Object, e As EventArgs) Handles txtnome.TextChanged
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"

        DataGridProd.DataSource = buscarproduto(txtnome.Text)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()

    End Sub
End Class