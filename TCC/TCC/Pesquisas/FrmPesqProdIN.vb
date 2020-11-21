Imports System.Data.SqlClient

Public Class FrmPesqProdIN

    Private Sub FrmPesqProdIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetProduto.TBProdutos' table. You can move, or remove it, as needed.
        'Me.TBProdutosTableAdapter.Fill(Me.DataSetProduto.TBProdutos)

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        FrmCadEstrutura.txtcodpro.Text = CStr(DataGridProd.Item(0, DataGridProd.CurrentRow.Index).Value)
        FrmCadEstrutura.txtnomeIN.Text = CStr(DataGridProd.Item(1, DataGridProd.CurrentRow.Index).Value)
        Me.Close()

    End Sub
    Function buscarprodutoIN(ByVal nome As String) As DataTable
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim adpt As New SqlDataAdapter("BuscarProdIN", con)

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

        DataGridProd.DataSource = buscarprodutoIN(txtnome.Text)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()

    End Sub
End Class