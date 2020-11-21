Imports System.Data.SqlClient

Public Class FrmCadFunc

    Private Sub PBCad_Click(sender As Object, e As EventArgs) Handles PBCad.Click
        Dim con As SqlConnection
        con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")
        con.Open()
        Dim sqlCommand As SqlCommand = New SqlCommand("SELECT ISNULL(MAX(Cod_Funcionario) +1, 1) AS PROXNUM FROM TBFuncionarios", con)
        Dim sqlReader As SqlDataReader

        sqlReader = sqlCommand.ExecuteReader()
        If sqlReader.Read() Then
            txtCodFunc.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        con.Close()

        Habilita()
        cbostatus.SelectedIndex = 0
        cbostatus.Enabled = False

        Limpa_Tela()
        btnAlterar.Enabled = False
    End Sub
    Private Sub Habilita()

        txtNome.ReadOnly = False
        mskDataNasc.ReadOnly = False
        mskCPF.ReadOnly = False
        mskRG.ReadOnly = False
        msktelefone.ReadOnly = False
        txtLog.ReadOnly = False
        mskCEP.ReadOnly = False
        txtCidade.ReadOnly = False
        txtuf.ReadOnly = False
        TxtNum.ReadOnly = False
        txtBairro.ReadOnly = False
        CBOSexo.Enabled = True
        cbostatus.Enabled = True
        cbostatus.SelectedIndex = 0

    End Sub

    Private Sub bntSalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        cmd.Connection = con


        If ValidaCampos() = False Then
            Exit Sub
        End If


        If isCPF(mskCPF.Text) = False Then
            MsgBox("CPF é inválido!", vbCritical)
        Else
            cmd.CommandText = "INSERT INTO TBFuncionarios VALUES('" & _
                                       txtCodFunc.Text & "', '" & _
                                       txtNome.Text & "', '" & _
                                       Format(Date.Parse(mskDataNasc.Text), "MM/dd/yyyy") & "', " & _
                                        "LEFT('" & CBOSexo.Text & "',1), '" & _
                                       mskCPF.Text & "', '" & _
                                       mskRG.Text & "', '" & _
                                       msktelefone.Text & "', '" & _
                                       txtLog.Text & "', '" & _
                                       TxtNum.Text & "', '" & _
                                       mskCEP.Text & "', '" & _
                                       txtCidade.Text & "', '" & _
                                       txtBairro.Text & "', '" & _
                                       txtuf.Text & "', 1)"

            con.Open()
            Try
                cmd.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)

            End Try
            con.Close()

            MsgBox("Empregado cadastrado com sucesso!", MsgBoxStyle.Information)
            Limpa_Tela()
            txtCodFunc.Clear()

        End If
       
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

    Public Function isCPF(ByVal pCPF As String) As Boolean

        Dim Conta As Integer, Soma As Integer, Resto As Integer, Passo As Integer

        isCPF = False : pCPF = Trim(pCPF)

        If Len(pCPF) <> 11 Then
            Exit Function
        End If

        For Passo = 11 To 12
            Soma = 0
            For Conta = 1 To Passo - 2
                Soma = Soma + Val(Mid(pCPF, Conta, 1)) * (Passo - Conta)
            Next

            Resto = 11 - (Soma - (Int(Soma / 11) * 11))

            If Resto = 10 Or Resto = 11 Then Resto = 0

            If Resto <> Val(Mid(pCPF, Passo - 1, 1)) Then
                Exit Function

            End If
        Next

        isCPF = True

    End Function

    Function ValidaCampos()
        If txtnome.Text = "" Then
            MsgBox("Digite o nome!")
            txtnome.Focus()
            Return False

        End If

        If mskRG.Text = "" Then
            MsgBox("Digite o RG!")
            mskRG.Focus()
            Return False

        End If

        If mskCPF.Text = "" Then
            MsgBox("Digite o CPF!")
            mskCPF.Focus()
            Return False

        End If

        If CBOSexo.Text = "" Then
            MsgBox("Selecione o sexo!")
            CBOSexo.Focus()
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

        If txtCidade.Text = "" Then
            MsgBox("Digite a cidade!")
            txtCidade.Focus()
            Return False

        End If

        If txtBairro.Text = "" Then
            MsgBox("Digite o bairro!")
            txtBairro.Focus()
            Return False

        End If

        If txtuf.Text = "" Then
            MsgBox("Digite a UF!")
            txtuf.Focus()
            Return False

        End If


        Return True
    End Function

    Private Sub Limpa_Tela()
        txtNome.Clear()
        mskDataNasc.Clear()
        mskCPF.Clear()
        mskRG.Clear()
        msktelefone.Clear()
        txtLog.Clear()
        mskCEP.Clear()
        txtCidade.Clear()
        txtBairro.Clear()
        txtuf.ResetText()
        CBOSexo.ResetText()
        TxtNum.Clear()
        CBOSexo.SelectedIndex = -1
        cbostatus.SelectedIndex = 0

        txtNome.Focus()
    End Sub

    Private Sub PBPesquisar_Click(sender As Object, e As EventArgs) Handles PBPesquisar.Click
        FrmPesqFunc.ShowDialog()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Limpa_Tela()
        txtCodFunc.Clear()
        Me.Close()

    End Sub


    Private Sub pbedit_Click(sender As Object, e As EventArgs) Handles pbedit.Click
        txtNome.ReadOnly = False
        mskDataNasc.ReadOnly = False
        mskRG.ReadOnly = False
        mskCEP.ReadOnly = False
        CBOSexo.Enabled = True
        msktelefone.ReadOnly = False
        TxtNum.ReadOnly = False
        txtLog.ReadOnly = False
        txtCidade.ReadOnly = False
        txtBairro.ReadOnly = False
        txtuf.ReadOnly = False





        btnsalvar.Enabled = False
        btnAlterar.Enabled = True

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        cmd.Connection = con

        cmd.CommandText = "UPDATE TBFuncionarios SET Nome_Completo = '" & _
                                   txtNome.Text & "', Data_Nascimento = '" & _
                                   Format(Date.Parse(mskDataNasc.Text), "MM/dd/yyyy") & "', Sexo = " & _
                                   "LEFT('" & CBOSexo.Text & "',1), CPF = '" & _
                                   mskCPF.Text & "', RG = '" & _
                                   mskRG.Text & "', Telefone = '" & _
                                   msktelefone.Text & "', Logradouro = '" & _
                                   txtLog.Text & "', Numero = '" & _
                                   TxtNum.Text & "', CEP = '" & _
                                   mskCEP.Text & "', Cidade = '" & _
                                   txtCidade.Text & "', Bairro = '" & _
                                   txtBairro.Text & "', UF = '" & _
                                   txtuf.Text & "' WHERE Cod_Funcionario = " & txtCodFunc.Text & ""
        con.Open()

        Try
            cmd.ExecuteNonQuery()

        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message)

        End Try

        con.Close()

        MsgBox("Empregado alterado com sucesso!", MsgBoxStyle.Information)
        Limpa_Tela()
        txtCodFunc.Clear()

    End Sub

    Private Sub PBDelete_Click(sender As Object, e As EventArgs) Handles PBDelete.Click
        MsgBox("Deseja inativar esse registro?", MessageBoxButtons.YesNo, "Atenção!")


        If MsgBoxResult.Yes Then
            Dim con As New SqlClient.SqlConnection
            con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
            Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
            cmd.Connection = con

            cmd.CommandText = "UPDATE TBFuncionarios SET status = 0 where Cod_Funcionario = '" & txtCodFunc.Text & "' "
            con.Open()
            Try
                cmd.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)

            End Try

            con.Close()
        Else
            Exit Sub

        End If
        Limpa_Tela()
        txtCodFunc.Clear()

        FrmPesqFunc.DataGridFunc.Rows.RemoveAt(FrmPesqFunc.DataGridFunc.CurrentRow.Index)


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FrmCadFunc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnpreencher_Click(sender As Object, e As EventArgs)
        txtNome.Text = "mariana"
        mskDataNasc.Text = "24/05/1996"
        mskCPF.Text = "44834190803"
        mskRG.Text = "380202074"
        msktelefone.Text = "1142471635"
        mskCEP.Text = "06404020"
        CBOSexo.Text = "Feminino"
        TxtNum.Text = "70"
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtCodFunc.Clear()
        Limpa_Tela()

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

        If mskCEP.Text And txtLog.Text = "" Then
            MsgBox("CEP inválido", vbCritical)
        End If
    End Sub

    Private Sub txtNome_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNome.Validating
        If (txtNome.Text.Trim().Length = 0) Then
            ErrorProvider1.SetError(txtNome, "Informe o nome.")
        Else
            ErrorProvider1.SetError(txtNome, "")
        End If
    End Sub

    Private Sub mskCPF_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskCPF.Validating
        If (mskCPF.Text.Trim().Length = 0) Then
            ErrorProvider1.SetError(mskCPF, "Informe o CPF.")
        Else
            ErrorProvider1.SetError(mskCPF, "")
        End If
    End Sub

    Private Sub mskCEP_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskCEP.Validating
        If (mskCEP.Text.Trim().Length = 0) Then
            ErrorProvider1.SetError(mskCEP, "Informe o CEP.")
        Else
            ErrorProvider1.SetError(mskCEP, "")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CalendarInicio.Visible = True
        Button1.Visible = False
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CalendarInicio.Visible = False
        Button1.Visible = True
        Button2.Visible = False
    End Sub
    Private Sub CalendarInicio_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalendarInicio.DateChanged
        mskDataNasc.Text = CalendarInicio.SelectionStart
    End Sub

    Private Sub CalendarInicio_DateSelected(sender As Object, e As DateRangeEventArgs) Handles CalendarInicio.DateSelected
        CalendarInicio.Dispose()
    End Sub
End Class