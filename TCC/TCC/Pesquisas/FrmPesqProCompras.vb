Imports System.Data.SqlClient

Public Class FrmPesqProCompras

    Private Sub FrmPesqProCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetViewRelCompras.RelCompras' table. You can move, or remove it, as needed.
        ' Me.RelComprasTableAdapter.Fill(Me.DataSetViewRelCompras.RelCompras)
        'TODO: This line of code loads data into the 'DataSetViewProdCompras.PesqProdCompras' table. You can move, or remove it, as needed.
        'Me.PesqProdComprasTableAdapter.Fill(Me.DataSetViewProdCompras.PesqProdCompras)
        'TODO: This line of code loads data into the 'DataSetProduto.TBProdutos' table. You can move, or remove it, as needed.
        'Me.TBProdutosTableAdapter.Fill(Me.DataSetProduto.TBProdutos)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
    End Sub
    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        FrmCadCompras.txtcodpro.Text = CStr(DataGridProd.Item(0, DataGridProd.CurrentRow.Index).Value)
        FrmCadCompras.lblquant.Text = CStr(DataGridProd.Item(2, DataGridProd.CurrentRow.Index).Value)
        FrmCadProd.MdiParent = Me.MdiParent

        Me.Close()

    End Sub

    Private Sub txtnome_TextChanged(sender As Object, e As EventArgs) Handles txtnome.TextChanged
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"

        DataGridProd.DataSource = buscarproduto(txtnome.Text)
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
End Class