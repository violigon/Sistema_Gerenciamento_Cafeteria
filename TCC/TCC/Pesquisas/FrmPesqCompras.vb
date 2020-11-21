Imports System.Data.SqlClient

Public Class FrmPesqCompras

    Private Sub FrmPesqCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetViewRelCompras.RelCompras' table. You can move, or remove it, as needed.
        Me.RelComprasTableAdapter.Fill(Me.DataSetViewRelCompras.RelCompras)
        'TODO: This line of code loads data into the 'DataSetCompras.TBItens_Compras' table. You can move, or remove it, as needed.
        'Me.TBItens_ComprasTableAdapter.Fill(Me.DataSetCompras.TBItens_Compras)

    End Sub


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()

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

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click

        Dim sConnString As String = "Provider=sqloledb; Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Persist Security Info=True;User ID=sa;Password=123456"
        Dim rowNum As Integer

        FrmCadCompras.txtqtd.Text = String.Empty

        Using cn As New OleDb.OleDbConnection(sConnString)
            cn.Open()
            Dim cmd As New OleDb.OleDbCommand("SELECT TBCompras.Cod_Compra, TBCompras.Cod_Fornecedor, TBCompras.Data_Emissao, TBCompras.Data_Inclusao, TBCompras.Data_Pgto, TBItens_Compras.Cod_Produto, TBItens_Compras.Quantidade, TBItens_Compras.Valor" & _
                                              " FROM TBCompras" & _
                                              " INNER JOIN TBItens_Compras" & _
                                              " ON TBCompras.Cod_Compra = TBItens_Compras.Cod_Compra" & _
                                              " WHERE TBCompras.Cod_Compra = " + DataGridCompras.Item(0, DataGridCompras.CurrentRow.Index).Value.ToString + "", cn)

            Dim r As OleDb.OleDbDataReader = cmd.ExecuteReader()

            If Not r.HasRows Then Exit Sub

            r.Read()

            FrmCadCompras.txtcodcompra.Text = r.GetInt32(0)
            FrmCadCompras.txtcodfornec.Text = r.GetInt32(1)
            FrmCadCompras.mskemissao.Text = Format(Date.Parse(r.GetString(2)), "dd/MM/yyyy")
            FrmCadCompras.mskinclusao.Text = Format(Date.Parse(r.GetString(3)), "dd/MM/yyyy")
            FrmCadCompras.mskpgto.Text = Format(Date.Parse(r.GetString(4)), "dd/MM/yyyy")

            rowNum = FrmCadCompras.DataGridCompras.Rows.Add()
            FrmCadCompras.DataGridCompras.Rows.Item(rowNum).Cells(0).Value = r.GetInt32(5)
            FrmCadCompras.DataGridCompras.Rows.Item(rowNum).Cells(1).Value = r.GetValue(6)
            FrmCadCompras.DataGridCompras.Rows.Item(rowNum).Cells(2).Value = r.GetValue(7)

            Do While r.Read()
                rowNum = FrmCadCompras.DataGridCompras.Rows.Add()
                FrmCadCompras.DataGridCompras.Rows.Item(rowNum).Cells(0).Value = r.GetInt32(5)
                FrmCadCompras.DataGridCompras.Rows.Item(rowNum).Cells(1).Value = r.GetValue(6)
                FrmCadCompras.DataGridCompras.Rows.Item(rowNum).Cells(2).Value = r.GetValue(7)

            Loop

            FrmCadCompras.MdiParent = Me.MdiParent

            Me.Close()

            cn.Close()
        End Using

        FrmCadEstrutura.pbexcluirow.Visible = False





    End Sub

    Private Sub txtnome_TextChanged(sender As Object, e As EventArgs) Handles txtnome.TextChanged
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"

        DataGridCompras.DataSource = buscarprodcompra(txtnome.Text)
    End Sub

    Function buscarprodcompra(ByVal nome As String) As DataTable
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim adpt As New SqlDataAdapter("BuscarProdCompra", con)

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

End Class