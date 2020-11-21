Imports System.Data.SqlClient

Public Class FrmPesqCliVendas

    Private Sub FrmPesqCliVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetCliente.TBClientes' table. You can move, or remove it, as needed.
        Me.TBClientesTableAdapter.Fill(Me.DataSetCliente.TBClientes)
        'TODO: This line of code loads data into the 'DataSetCliente.TBClientes' table. You can move, or remove it, as needed.
        ' Me.TBClientesTableAdapter.Fill(Me.DataSetCliente.TBClientes)

    End Sub

    Private Sub txtnome_TextChanged(sender As Object, e As EventArgs) Handles txtnome.TextChanged
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"

        DataGridCli.DataSource = buscarcliente(txtnome.Text)
    End Sub
    Function buscarcliente(ByVal nome As String) As DataTable
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim adpt As New SqlDataAdapter("BuscarCliente", con)

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
        FrmVendas.txtcodcli.Text = CStr(DataGridCli.Item(0, DataGridCli.CurrentRow.Index).Value)
        FrmVendas.txtnomecli.Text = CStr(DataGridCli.Item(1, DataGridCli.CurrentRow.Index).Value)

        FrmVendas.MdiParent = Me.MdiParent

        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
    End Sub
End Class