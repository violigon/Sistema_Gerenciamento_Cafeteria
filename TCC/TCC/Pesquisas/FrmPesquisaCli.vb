Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class FrmPesquisaCli


    Private Sub FrmPesquisaCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetCliente.TBClientes' table. You can move, or remove it, as needed.
        'Me.TBClientesTableAdapter.Fill(Me.DataSetCliente.TBClientes)



    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub btnpesq_Click(sender As Object, e As EventArgs)

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

    Private Sub DataGridCli_DoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridCli.DoubleClick
        Me.btnpesq_Click(sender, e)
    End Sub

    Private Sub FrmPesquisaCli_Load()
        Throw New NotImplementedException
    End Sub


    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click

        FrmCadCli.txtcodcli.Text = CStr(DataGridCli.Item(0, DataGridCli.CurrentRow.Index).Value)
        FrmCadCli.txtnome.Text = CStr(DataGridCli.Item(1, DataGridCli.CurrentRow.Index).Value)
        FrmCadCli.mskcpf.Text = CStr(DataGridCli.Item(2, DataGridCli.CurrentRow.Index).Value)
        FrmCadCli.cbosexo.Text = CStr(DataGridCli.Item(3, DataGridCli.CurrentRow.Index).Value)
        FrmCadCli.mskdtnasc.Text = CStr(DataGridCli.Item(4, DataGridCli.CurrentRow.Index).Value)
        FrmCadCli.txtemail.Text = CStr(DataGridCli.Item(5, DataGridCli.CurrentRow.Index).Value)
        'FrmCadCli.cbostatus.Text = CStr(DataGridCli.Item(6, DataGridCli.CurrentRow.Index).Value)

        FrmCadCli.MdiParent = Me.MdiParent

        FrmCadCli.btnaltera.Visible = True
        FrmCadCli.btnaltera.Enabled = False
        FrmCadCli.btnsalvar.Visible = False



        Me.Close()


        'FrmCadCli.ShowDialog()

        FrmCadCli.txtnome.ReadOnly = True
        FrmCadCli.mskcpf.ReadOnly = True
        FrmCadCli.cbosexo.Enabled = False
        FrmCadCli.mskdtnasc.ReadOnly = True
        FrmCadCli.txtemail.ReadOnly = True
        FrmCadCli.cbostatus.Enabled = False

        FrmCadCli.cbostatus.SelectedIndex = 0





        If DataGridCli.Item(3, DataGridCli.CurrentRow.Index).Value = "F" Then
            FrmCadCli.cbosexo.SelectedIndex = 1
        Else
            FrmCadCli.cbosexo.SelectedIndex = 0
        End If





    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
    End Sub

    Private Sub txtnome_TextChanged(sender As Object, e As EventArgs) Handles txtnome.TextChanged
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"

        DataGridCli.DataSource = buscarcliente(txtnome.Text)
    End Sub
End Class