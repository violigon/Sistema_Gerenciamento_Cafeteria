Imports System.Data.SqlClient

Public Class FrmCadFornec

    Private Sub Habilita()
        txtNomeFan.ReadOnly = False
        mskcnpj.ReadOnly = False
        txtNomeFan.ReadOnly = False
        txtrazsoc.ReadOnly = False
        msktelefone.ReadOnly = False
        txtemail.ReadOnly = False
        txtLog.ReadOnly = False
        mskCEP.ReadOnly = False
        txtCidade.ReadOnly = False
        txtuf.ReadOnly = False
        txtemail.ReadOnly = False
        txtBairro.ReadOnly = False
        txtsite.ReadOnly = False
        cbostatus.Enabled = False
        TxtNum.ReadOnly = False
        txtuf.ReadOnly = False
        cbostatus.SelectedIndex = 0
    End Sub
    Private Sub Limpa_Tela()
        txtNomeFan.Clear()
        mskcnpj.Clear()
        txtrazsoc.Clear()
        msktelefone.Clear()
        txtLog.Clear()
        mskCEP.Clear()
        txtCidade.Clear()
        txtBairro.Clear()
        txtuf.ResetText()
        txtemail.Clear()
        txtsite.Clear()
        TxtNum.Clear()
        cbostatus.SelectedIndex = 0



    End Sub

    Public Shared Function IsValidaCNPJ(ByVal value As String) As Boolean
        Dim multiplier1() As Integer = New Integer() {5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2}
        Dim multiplier2() As Integer = New Integer() {6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2}
        Dim sum As Integer = 0
        Dim leftOver As Integer
        Dim digit As String
        value = value.Trim()
        value = value.Replace(".", "")
        value = value.Replace("/", "")
        value = value.Replace("-", "")
        Dim tempCPF As String = value
        If Not value.Length = 14 Then
            Return False ' Maior/Menor que 14 dígitos
        End If
        tempCPF = tempCPF.Substring(0, 12)
        For i As Integer = 0 To 11
            sum = sum + Integer.Parse(tempCPF(i).ToString * multiplier1(i))
        Next
        leftOver = sum Mod 11
        If leftOver < 2 Then
            leftOver = 0
        Else
            leftOver = 11 - leftOver
        End If
        digit = leftOver.ToString
        tempCPF = tempCPF + digit
        sum = 0
        For i As Integer = 0 To 12
            sum = sum + Integer.Parse(tempCPF(i).ToString * multiplier2(i))
        Next
        leftOver = sum Mod 11
        If leftOver < 2 Then
            leftOver = 0
        Else
            leftOver = 11 - leftOver
        End If
        digit = digit + leftOver.ToString
        Return value.EndsWith(digit)

        IsValidaCNPJ(True)
    End Function ' IsValidaCNPJ


    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click

        If ValidaCampos() = False Then
            Exit Sub
        End If


        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        cmd.Connection = con

        If txtemail.Text = "" Then
            If IsValidaCNPJ(mskcnpj.Text) = False Then
                MsgBox("CNPJ é inválido!", vbCritical)
            ElseIf cbostatus.SelectedIndex = 1 Then
                cmd.CommandText = "INSERT INTO TBFornecedor VALUES('" & _
                                           txtcodfornec.Text & "', '" & _
                                           mskcnpj.Text & "', '" & _
                                           txtNomeFan.Text & "', '" & _
                                           txtrazsoc.Text & "', '" & _
                                           msktelefone.Text & "', '" & _
                                           txtemail.Text & "', '" & _
                                           mskCEP.Text & "', '" & _
                                           txtLog.Text & "', '" & _
                                           txtCidade.Text & "', '" & _
                                           txtBairro.Text & "', '" & _
                                           TxtNum.Text & "', '" & _
                                           txtuf.Text & "', '" & _
                                           txtsite.Text & "', 0)"

                con.Open()
                Try
                    cmd.ExecuteNonQuery()

                Catch ex As System.Data.SqlClient.SqlException
                    MsgBox(ex.Message)

                End Try

                con.Close()

                MsgBox("Fornecedor cadastrado com sucesso!", MsgBoxStyle.Information)
                Limpa_Tela()
            Else
                cmd.CommandText = "INSERT INTO TBFornecedor VALUES('" & _
                                          txtcodfornec.Text & "', '" & _
                                          mskcnpj.Text & "', '" & _
                                          txtNomeFan.Text & "', '" & _
                                          txtrazsoc.Text & "', '" & _
                                          msktelefone.Text & "', '" & _
                                          txtemail.Text & "', '" & _
                                          mskCEP.Text & "', '" & _
                                          txtLog.Text & "', '" & _
                                          txtCidade.Text & "', '" & _
                                          txtBairro.Text & "', '" & _
                                          TxtNum.Text & "', '" & _
                                          txtuf.Text & "', '" & _
                                          txtsite.Text & "', 1)"

                con.Open()
                Try
                    cmd.ExecuteNonQuery()

                Catch ex As System.Data.SqlClient.SqlException
                    MsgBox(ex.Message)

                End Try

                con.Close()

                MsgBox("Fornecedor cadastrado com sucesso!", MsgBoxStyle.Information)
                Limpa_Tela()
            End If
        ElseIf EmailAddressCheck(txtemail.Text) = True Then
            If IsValidaCNPJ(mskcnpj.Text) = False Then
                MsgBox("CNPJ é inválido!", vbCritical)
            ElseIf cbostatus.SelectedIndex = 1 Then
                cmd.CommandText = "INSERT INTO TBFornecedor VALUES('" & _
                                           txtcodfornec.Text & "', '" & _
                                           mskcnpj.Text & "', '" & _
                                           txtNomeFan.Text & "', '" & _
                                           txtrazsoc.Text & "', '" & _
                                           msktelefone.Text & "', '" & _
                                           txtemail.Text & "', '" & _
                                           mskCEP.Text & "', '" & _
                                           txtLog.Text & "', '" & _
                                           txtCidade.Text & "', '" & _
                                           txtBairro.Text & "', '" & _
                                           TxtNum.Text & "', '" & _
                                           txtuf.Text & "', '" & _
                                           txtsite.Text & "', 0)"

                con.Open()
                Try
                    cmd.ExecuteNonQuery()

                Catch ex As System.Data.SqlClient.SqlException
                    MsgBox(ex.Message)

                End Try

                con.Close()

                MsgBox("Fornecedor cadastrado com sucesso!", MsgBoxStyle.Information)
                Limpa_Tela()
            Else
                cmd.CommandText = "INSERT INTO TBFornecedor VALUES('" & _
                                          txtcodfornec.Text & "', '" & _
                                          mskcnpj.Text & "', '" & _
                                          txtNomeFan.Text & "', '" & _
                                          txtrazsoc.Text & "', '" & _
                                          msktelefone.Text & "', '" & _
                                          txtemail.Text & "', '" & _
                                          mskCEP.Text & "', '" & _
                                          txtLog.Text & "', '" & _
                                          txtCidade.Text & "', '" & _
                                          txtBairro.Text & "', '" & _
                                          TxtNum.Text & "', '" & _
                                          txtuf.Text & "', '" & _
                                          txtsite.Text & "', 1)"

                con.Open()
                Try
                    cmd.ExecuteNonQuery()

                Catch ex As System.Data.SqlClient.SqlException
                    MsgBox(ex.Message)

                End Try

                con.Close()

                MsgBox("Fornecedor cadastrado com sucesso!", MsgBoxStyle.Information)
                Limpa_Tela()
            End If
        Else
            MsgBox("Email Inválido!", vbInformation)
        End If

    End Sub

    Function ValidaCampos()
        If mskcnpj.Text = "" Then
            MsgBox("Digite o CNPJ!")
            txtNomeFan.Focus()
            Return False

        End If

        If txtNomeFan.Text = "" Then
            MsgBox("Digite o nome!")
            txtNomeFan.Focus()
            Return False

        End If

        If txtrazsoc.Text = "" Then
            MsgBox("Digite a razão social!")
            txtrazsoc.Focus()
            Return False

        End If

        If mskCEP.Text = "" Then
            MsgBox("Digite o CEP!")
            mskCEP.Focus()
            Return False
        End If

        If txtLog.Text = "" Then
            MsgBox("Digite o logradouro!")
            txtLog.Focus()
            Return False
        End If

        If txtBairro.Text = "" Then
            MsgBox("Digite o bairro!")
            txtBairro.Focus()
            Return False
        End If

        If txtCidade.Text = "" Then
            MsgBox("Digite a cidade!")
            txtCidade.Focus()
            Return False
        End If

        If mskCEP.Text = "" Then
            MsgBox("Digite o CEP!")
            mskCEP.Focus()
            Return False
        End If


        Return True
    End Function


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Limpa_Tela()
        txtcodfornec.Clear()
        Me.Close()

    End Sub

    Private Sub pbconsulta_Click(sender As Object, e As EventArgs) Handles pbconsulta.Click
        FrmPesqFornec.ShowDialog()

    End Sub

    Private Sub pbedit_Click(sender As Object, e As EventArgs) Handles pbedit.Click
        txtNomeFan.ReadOnly = False
        txtrazsoc.ReadOnly = False
        msktelefone.ReadOnly = False
        txtemail.ReadOnly = False
        mskCEP.ReadOnly = False
        txtsite.ReadOnly = False

        btnsalvar.Visible = False
        btnAlterar.Visible = True
        btnAlterar.Enabled = True

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        cmd.Connection = con

        cmd.CommandText = "UPDATE TBFornecedor SET CNPJ = '" & _
                                   mskcnpj.Text & "', Nome_Fantasia = '" & _
                                   txtNomeFan.Text & "', Razão_Social = '" & _
                                   txtrazsoc.Text & "', Telefone = '" & _
                                   msktelefone.Text & "', Email = '" & _
                                   txtemail.Text & "', CEP = '" & _
                                   mskCEP.Text & "', Logradouro = '" & _
                                   txtLog.Text & "', Cidade = '" & _
                                   txtCidade.Text & "', Bairro = '" & _
                                   txtBairro.Text & "', UF = '" & _
                                   txtuf.Text & "', Numero = " & _
                                   TxtNum.Text & ", Site_Empresa = '" & _
                                   txtsite.Text & "' WHERE Cod_Fornecedor = " & txtcodfornec.Text & " "
        con.Open()
        Try
            cmd.ExecuteNonQuery()

        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message)

        End Try

        con.Close()

        MsgBox("Fornecedor alterado com sucesso!", MsgBoxStyle.Information)
        Limpa_Tela()
        txtcodfornec.Clear()

        FrmPesqFornec.txtnome.Clear()


    End Sub
    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean

        ' Pattern ou mascara de verificação
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"

        ' Verifica se o email corresponde a pattern/mascara
        Dim emailAddressMatch As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(emailAddress, pattern)

        ' Caso corresponda
        If emailAddressMatch.Success Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub pbdelete_Click(sender As Object, e As EventArgs) Handles pbdelete.Click
        MsgBox("Deseja inativar esse registro?", MessageBoxButtons.YesNo, "Atenção!")

        If MsgBoxResult.Yes Then
            Dim con As New SqlClient.SqlConnection
            con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
            Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
            cmd.Connection = con

            cmd.CommandText = "UPDATE TBFornecedor SET status = 0 where Cod_Fornecedor = '" & txtcodfornec.Text & "' "
            con.Open()
            Try
                cmd.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)

            End Try

            con.Close()

        End If
        Limpa_Tela()
        txtcodfornec.Clear()

        FrmPesqFornec.DataGridFornec.Rows.RemoveAt(FrmPesqFornec.DataGridFornec.CurrentRow.Index)


    End Sub


    Private Sub pbpesqcep_Click(sender As Object, e As EventArgs) Handles pbpesqcep.Click
        Try
            Dim ds As New DataSet()
            Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", mskCEP.Text)
            ds.ReadXml(xml)
            txtLog.Text = ds.Tables(0).Rows(0)("logradouro").ToString()
            txtBairro.Text = ds.Tables(0).Rows(0)("bairro").ToString()
            txtCidade.Text = ds.Tables(0).Rows(0)("cidade").ToString()
            txtuf.Text = ds.Tables(0).Rows(0)("uf").ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro")
        End Try
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtcodfornec.Clear()
        Limpa_Tela()

    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub pbcad_Click(sender As Object, e As EventArgs) Handles pbcad.Click
        Dim con As SqlConnection
        con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")
        con.Open()
        Dim sqlCommand As SqlCommand = New SqlCommand("SELECT ISNULL(MAX(Cod_Fornecedor) +1, 1) AS PROXNUM FROM TBFornecedor", con)
        Dim sqlReader As SqlDataReader

        sqlReader = sqlCommand.ExecuteReader()
        If sqlReader.Read() Then
            txtcodfornec.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        con.Close()

        cbostatus.Text = "ativo"


        btnsalvar.Visible = True
        btnAlterar.Visible = False

        Habilita()
        Limpa_Tela()

    End Sub


    Private Sub mskcnpj_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskcnpj.Validating
        If (mskcnpj.Text.Trim().Length = 0) Then
            ErrorProvider1.SetError(mskcnpj, "Informe o CNPJ.")
        Else
            ErrorProvider1.SetError(mskcnpj, "")
        End If
    End Sub

    Private Sub txtNomeFan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomeFan.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If

    End Sub

    Private Sub txtNomeFan_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNomeFan.Validating
        If (txtNomeFan.Text.Trim().Length = 0) Then
            ErrorProvider1.SetError(txtNomeFan, "Informe o Nome.")
        Else
            ErrorProvider1.SetError(txtNomeFan, "")
        End If
    End Sub

    Private Sub txtCidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCidade.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If

    End Sub

    Private Sub txtBairro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBairro.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If

    End Sub

    Private Sub txtrazsoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrazsoc.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If

    End Sub

    Private Sub txtuf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtuf.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If

    End Sub

End Class