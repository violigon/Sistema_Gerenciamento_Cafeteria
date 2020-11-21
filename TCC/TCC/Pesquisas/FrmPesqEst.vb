Imports System.Data.SqlClient

Public Class FrmPesqEst


    Private Sub FrmPesqEst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TBEstruturaTableAdapter.Fill(Me.DataSetEst.TBEstrutura)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()

    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click

        Dim sConnString As String = "Provider=sqloledb; Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Persist Security Info=True;User ID=sa;Password=123456"
        Dim rowNum As Integer

        FrmCadEstrutura.txtqtd.Text = String.Empty

        Using cn As New OleDb.OleDbConnection(sConnString)
            cn.Open()
            Dim cmd As New OleDb.OleDbCommand("SELECT TBEstrutura.Cod_ProdIN, TBProdutos.Nome_Produto, TBEstrutura.Quantidade " & _
                        " FROM TBEstrutura INNER JOIN TBProdutos" & _
                        " ON TBEstrutura.Cod_ProdIN = TBProdutos.Cod_Produto" & _
                        " WHERE Cod_Est = " + DataGridEst.Item(0, DataGridEst.CurrentRow.Index).Value.ToString + "", cn)
            Dim r As OleDb.OleDbDataReader = cmd.ExecuteReader()

            If Not r.HasRows Then Exit Sub

            Do While r.Read()
                rowNum = FrmCadEstrutura.DataGridEst.Rows.Add()
                FrmCadEstrutura.DataGridEst.Rows.Item(rowNum).Cells(0).Value = r.GetInt32(0)
                FrmCadEstrutura.DataGridEst.Rows.Item(rowNum).Cells(1).Value = r.GetString(1)
                FrmCadEstrutura.DataGridEst.Rows.Item(rowNum).Cells(2).Value = r.GetValue(2)

            Loop
            FrmCadEstrutura.txtCodEst.Text = CStr(DataGridEst.Item(0, DataGridEst.CurrentRow.Index).Value)
            FrmCadEstrutura.txtnomePA.Text = CStr(DataGridEst.Item(1, DataGridEst.CurrentRow.Index).Value)

            FrmCadEstrutura.txtnomePA.ReadOnly = True

            FrmCadEstrutura.MdiParent = Me.MdiParent

            Me.Close()

            cn.Close()
        End Using

        FrmCadEstrutura.pbexcluirow.Visible = False


    End Sub
    Private Sub GetEmailAddresses()
        Dim sText As String = String.Empty
        Dim sConnString As String = String.Empty 'Put your connection string in here

    End Sub

    Private Sub txtnome_TextChanged(sender As Object, e As EventArgs) Handles txtnome.TextChanged
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"

        DataGridEst.DataSource = buscarest(txtnome.Text)
    End Sub
    Function buscarest(ByVal nome As String) As DataTable
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim adpt As New SqlDataAdapter("BuscarEst", con)

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