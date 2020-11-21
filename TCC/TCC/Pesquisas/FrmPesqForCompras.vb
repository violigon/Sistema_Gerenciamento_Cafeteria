Imports System.Data.SqlClient

Public Class FrmPesqForCompras

    Private Sub FrmPesqForCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetFornec.TBFornecedor' table. You can move, or remove it, as needed.
        Me.TBFornecedorTableAdapter.Fill(Me.DataSetFornec.TBFornecedor)
        'TODO: This line of code loads data into the 'DataSetFornec.TBFornecedor' table. You can move, or remove it, as needed.
        'Me.TBFornecedorTableAdapter.Fill(Me.DataSetFornec.TBFornecedor)

    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        FrmCadCompras.txtcodfornec.Text = CStr(DataGridFornec.Item(0, DataGridFornec.CurrentRow.Index).Value)
        FrmCadCompras.txtnomefornec.Text = CStr(DataGridFornec.Item(2, DataGridFornec.CurrentRow.Index).Value)

        FrmCadCli.MdiParent = Me.MdiParent
        Me.Close()

    End Sub

    Private Sub txtnome_TextChanged(sender As Object, e As EventArgs) Handles txtnome.TextChanged
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"

        DataGridFornec.DataSource = buscarfornec(txtnome.Text)
    End Sub
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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()

    End Sub
End Class