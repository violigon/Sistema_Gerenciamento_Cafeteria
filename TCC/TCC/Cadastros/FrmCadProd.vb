Imports System.Data.SqlClient

Public Class FrmCadProd


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Limpa_Tela()
        txtCodProd.Clear()
        Me.Close()

    End Sub

    Private Sub PBCad_Click(sender As Object, e As EventArgs) Handles PBCad.Click
        CboTipo.Enabled = True
        btnsalvar.Visible = True
        btnsalvar.Enabled = True

        Dim con As SqlConnection
        con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")
        con.Open()


        Dim sqlCommand As SqlCommand = New SqlCommand("SELECT ISNULL(MAX(Cod_Produto) +1, 1) AS PROXNUM FROM TBProdutos", con)
        Dim sqlReader As SqlDataReader

        sqlReader = sqlCommand.ExecuteReader()
        If sqlReader.Read() Then
            txtCodProd.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        con.Close()


        btnsalvar.Enabled = True
        btnAlterar.Enabled = False


        cbostatus.Text = "Ativo"
        Habilita()
        Limpa_Tela()



    End Sub
    Private Sub Habilita()
        txtnome.ReadOnly = False
        txtpreçovenda.ReadOnly = False
        rbtsim.Enabled = True
        rbtnao.Enabled = True


    End Sub

    Private Sub Limpa_Tela()

        CboTipo.SelectedIndex = -1
        CboUnid.SelectedIndex = -1
        txtnome.Clear()
        txtcusto.Clear()
        txtpreçovenda.Clear()
        txtqtd.Clear()



    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        Dim unidade As String
       
        If ValidaCampos() = False Then
            Exit Sub
        End If

        If CboUnid.SelectedIndex = 0 Then
            unidade = "KG"
        ElseIf CboUnid.SelectedIndex = 1 Then
            unidade = "L"
        Else
            unidade = "UNIDADE"
        End If

        txtcusto.Text = Replace(Replace(Replace(txtcusto.Text, ".", ""), "R$", ""), ",", ".")
        txtpreçovenda.Text = Replace(Replace(Replace(txtpreçovenda.Text, ".", ""), "R$", ""), ",", ".")


        cmd.Connection = con

        If cbostatus.SelectedIndex = 1 Then


            cmd.CommandText = "INSERT INTO TBProdutos(Nome_Produto, Tipo_Produto, Unidade, status, custo, preço_venda, Quantidade) VALUES('" & _
                                       txtnome.Text & "', '" & _
                                       CboTipo.Text & "', '" & _
                                       unidade & "', 0,'" & _
                                       txtcusto.Text & "', '" & _
                                       txtpreçovenda.Text & "', 0)"
            con.Open()
            Try
                cmd.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)

            End Try

            con.Close()
            MsgBox("Produto cadastrado com sucesso!", MsgBoxStyle.Information)
        Else

            cmd.CommandText = "INSERT INTO TBProdutos(Cod_Produto, Nome_Produto, Tipo_Produto, Unidade, status, custo, preço_venda, Quantidade) VALUES('" & _
                                       txtCodProd.Text & "', '" & _
                                       txtnome.Text & "', '" & _
                                       CboTipo.Text & "', '" & _
                                       CboUnid.Text & "', 1,'" & _
                                       txtcusto.Text & "', '" & _
                                       txtpreçovenda.Text & "', 0)"

            con.Open()
            Try
                cmd.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)

            End Try

            con.Close()
            MsgBox("Produto cadastrado com sucesso!", MsgBoxStyle.Information)
        End If


        If rbtsim.Checked Then
            MsgBox("Deseja estruturar produto agora?", MessageBoxButtons.YesNo, "Atenção!")
            If MsgBoxResult.Yes Then
                FrmCadEstrutura.Show()
                FrmCadEstrutura.txtnomePA.Text = Me.txtnome.Text
                FrmCadEstrutura.txtcodPA.Text = txtCodProd.Text
                FrmCadEstrutura.txtnomePA.Enabled = False
                Me.Close()
                Limpa_Tela()
                FrmCadEstrutura.txtnomePA.ReadOnly = False
                FrmCadEstrutura.txtcodpro.Enabled = True
                txtqtd.Enabled = True

                btnsalvar.Enabled = True
            Else
                '
            End If
        End If


       




        If CboTipo.SelectedIndex = 2 Then
            rbtsim.Enabled = True
            rbtnao.Enabled = True
            CboUnid.Enabled = False

        End If

        Limpa_Tela()
        txtCodProd.Clear()

    End Sub
    Private Sub PBPesquisar_Click(sender As Object, e As EventArgs) Handles PBPesquisar.Click
        Limpa_Tela()

        FrmPesqProd.ShowDialog()

    End Sub

    Private Sub pbedit_Click(sender As Object, e As EventArgs) Handles pbedit.Click

        btnsalvar.Visible = False
        btnAlterar.Visible = True
        btnAlterar.Enabled = True

        CboUnid.Enabled = True
        txtpreçovenda.ReadOnly = False
        txtcusto.ReadOnly = False
        txtnome.ReadOnly = False


    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        cmd.Connection = con

        cmd.CommandText = "UPDATE TBProdutos SET Nome_Produto = '" & _
                                   txtnome.Text & "', Tipo_Produto = '" & _
                                   CboTipo.Text & "', Unidade = '" & _
                                   CboUnid.Text & "', Custo='" & _
                                   Replace(txtcusto.Text, ",", ".") & "', preço_venda= '" & _
                                   Replace(txtpreçovenda.Text, ",", ".") & "' WHERE Cod_Produto = " & txtCodProd.Text & " "
        con.Open()
        Try
            cmd.ExecuteNonQuery()

        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message)

        End Try

        con.Close()

        MsgBox("Produto alterado com sucesso!", MsgBoxStyle.Information)
        Limpa_Tela()
        txtCodProd.Clear()


    End Sub

    Private Sub FrmCadProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtsim.Enabled = False
        rbtnao.Enabled = False
        btnsalvar.Visible = True
        btnsalvar.Enabled = True


        If Not CboTipo.SelectedIndex = 1 Then
            rbtsim.Enabled = False
            rbtnao.Enabled = False

        End If
    End Sub

    Private Sub txtcusto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub CboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTipo.SelectedIndexChanged
        If CboTipo.SelectedIndex = 1 Then
            rbtsim.Enabled = True
            rbtnao.Enabled = True
            txtcusto.ReadOnly = True
            If rbtsim.Checked = True Then
                txtcusto.Enabled = False
                CboUnid.Enabled = False
            Else
                txtcusto.Enabled = False
                txtpreçovenda.ReadOnly = False
            End If

        ElseIf CboTipo.SelectedIndex = 0 Then
            rbtsim.Enabled = False
            rbtnao.Enabled = False
            txtpreçovenda.ReadOnly = True
        Else
            rbtsim.Enabled = False
            rbtnao.Enabled = False
            txtpreçovenda.ReadOnly = True

        End If

    End Sub


    Private Sub txtpreçovenda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpreçovenda.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then
            e.Handled = True
        End If

    End Sub
    Private Sub rbtsim_Click(sender As Object, e As EventArgs) Handles rbtsim.Click
        txtcusto.Enabled = False
        CboUnid.SelectedIndex = -1
        CboUnid.Enabled = False
    End Sub

    Private Sub rbtnao_Click(sender As Object, e As EventArgs) Handles rbtnao.Click
        If CboTipo.SelectedIndex = 1 Then


            CboUnid.Enabled = True
            txtcusto.Enabled = False
            txtpreçovenda.ReadOnly = False
        End If
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtCodProd.Clear()
        Limpa_Tela()

    End Sub

    Private Sub PBDelete_Click(sender As Object, e As EventArgs) Handles PBDelete.Click
        MsgBox("Deseja inativar esse registro?", MessageBoxButtons.YesNo, "Atenção!")

        If MsgBoxResult.Yes Then
            Dim con As New SqlClient.SqlConnection
            con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
            Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
            cmd.Connection = con

            cmd.CommandText = "UPDATE TBProdutos SET status = 0 where Cod_Produto = " & txtCodProd.Text & " "
            con.Open()
            Try
                cmd.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)

            End Try

            con.Close()

        End If
        Limpa_Tela()
        txtCodProd.Clear()

        FrmPesqProd.DataGridProd.Rows.RemoveAt(FrmPesqProd.DataGridProd.CurrentRow.Index)


    End Sub

    Function ValidaCampos()
        If txtnome.Text = "" Then
            MsgBox("Digite o nome do produto!")
            txtnome.Focus()
            Return False

        End If

        If CboTipo.Text = "" Then
            MsgBox("Selecione o tipo!")
            CboTipo.Focus()
            Return False

        End If

        If CboUnid.Text = "" Then
            MsgBox("Selecione a unidade de medida!")
            CboUnid.Focus()
            Return False
        End If

        Return True

    End Function

End Class