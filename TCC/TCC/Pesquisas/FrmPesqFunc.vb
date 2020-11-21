Imports System.Data.SqlClient

Public Class FrmPesqFunc

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Function buscarfunc(ByVal nome As String) As DataTable
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim adpt As New SqlDataAdapter("BuscarFunc", con)

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


    Private Sub FrmPesqFunc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetFunc.TBFuncionarios' table. You can move, or remove it, as needed.
        'Me.TBFuncionariosTableAdapter.Fill(Me.DataSetFunc.TBFuncionarios)

    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        FrmCadFunc.txtCodFunc.Text = CStr(DataGridFunc.Item(0, DataGridFunc.CurrentRow.Index).Value)
        FrmCadFunc.txtNome.Text = CStr(DataGridFunc.Item(1, DataGridFunc.CurrentRow.Index).Value)
        FrmCadFunc.mskDataNasc.Text = CStr(DataGridFunc.Item(2, DataGridFunc.CurrentRow.Index).Value)
        FrmCadFunc.CBOSexo.Text = CStr(DataGridFunc.Item(3, DataGridFunc.CurrentRow.Index).Value)
        FrmCadFunc.mskCPF.Text = CStr(DataGridFunc.Item(4, DataGridFunc.CurrentRow.Index).Value)
        FrmCadFunc.mskRG.Text = CStr(DataGridFunc.Item(5, DataGridFunc.CurrentRow.Index).Value)
        FrmCadFunc.msktelefone.Text = CStr(DataGridFunc.Item(6, DataGridFunc.CurrentRow.Index).Value)
        FrmCadFunc.txtLog.Text = CStr(DataGridFunc.Item(7, DataGridFunc.CurrentRow.Index).Value)
        FrmCadFunc.TxtNum.Text = CStr(DataGridFunc.Item(8, DataGridFunc.CurrentRow.Index).Value)
        FrmCadFunc.mskCEP.Text = CStr(DataGridFunc.Item(9, DataGridFunc.CurrentRow.Index).Value)
        FrmCadFunc.txtCidade.Text = CStr(DataGridFunc.Item(10, DataGridFunc.CurrentRow.Index).Value)
        FrmCadFunc.txtBairro.Text = CStr(DataGridFunc.Item(11, DataGridFunc.CurrentRow.Index).Value)
        FrmCadFunc.txtuf.Text = CStr(DataGridFunc.Item(12, DataGridFunc.CurrentRow.Index).Value)


        FrmCadCli.MdiParent = Me.MdiParent

        Me.Close()


        'FrmCadCli.ShowDialog()

        FrmCadFunc.txtNome.ReadOnly = True
        FrmCadFunc.mskDataNasc.ReadOnly = True
        FrmCadFunc.mskCPF.ReadOnly = True
        FrmCadFunc.mskRG.ReadOnly = True
        FrmCadFunc.msktelefone.ReadOnly = True
        FrmCadFunc.txtLog.ReadOnly = True
        FrmCadFunc.mskCEP.ReadOnly = True
        FrmCadFunc.txtCidade.ReadOnly = True
        FrmCadFunc.txtBairro.ReadOnly = True
        FrmCadFunc.txtuf.Enabled = False
        FrmCadCli.cbosexo.Enabled = False
        FrmCadFunc.TxtNum.ReadOnly = True

        FrmCadFunc.btnAlterar.Visible = True
        FrmCadFunc.btnsalvar.Visible = False
        FrmCadFunc.btnAlterar.Enabled = False


        FrmCadFunc.cbostatus.SelectedIndex = 0

        If DataGridFunc.Item(3, DataGridFunc.CurrentRow.Index).Value = "F" Then
            FrmCadFunc.CBOSexo.SelectedIndex = 1
        Else
            FrmCadFunc.CBOSexo.SelectedIndex = 0
        End If
    End Sub

    Private Sub DataGridFunc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridFunc_DoubleClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtnome_TextChanged(sender As Object, e As EventArgs) Handles txtnome.TextChanged
        Dim busca As New DataTable
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"

        DataGridFunc.DataSource = buscarfunc(txtnome.Text)
    End Sub

    Private Sub pbsair_Click(sender As Object, e As EventArgs) Handles pbsair.Click
        Me.Close()

    End Sub

  
End Class