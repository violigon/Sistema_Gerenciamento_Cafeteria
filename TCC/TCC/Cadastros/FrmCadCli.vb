Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class FrmCadCli

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        cmd.Connection = con

        If ValidaCampos() = False Then
            Exit Sub
        End If

        If txtemail.Text = "" Then
            If mskcpf.MaskFull Then
                If isCPF(mskcpf.Text) = False Then
                    MsgBox("CPF é inválido!", vbCritical)
                ElseIf cbostatus.SelectedIndex = 1 Then
                    cmd.CommandText = "INSERT INTO TBClientes VALUES('" & _
                                               txtcodcli.Text & "', '" & _
                                               txtnome.Text & "', '" & _
                                               mskcpf.Text & "'," & _
                                               "LEFT('" & cbosexo.Text & "',1), '" & _
                                               Format(Date.Parse(mskdtnasc.Text), "MM/dd/yyyy") & "', '" & _
                                               txtemail.Text & "', 0)"


                    con.Open()
                    Try
                        cmd.ExecuteNonQuery()

                    Catch ex As System.Data.SqlClient.SqlException
                        MsgBox(ex.Message)

                    End Try

                    con.Close()

                    MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information)
                    Limpa_Tela()
                    txtcodcli.Clear()


                Else
                    cmd.CommandText = "INSERT INTO TBClientes VALUES('" & _
                                          txtcodcli.Text & "', '" & _
                                          txtnome.Text & "', '" & _
                                          mskcpf.Text & "'," & _
                                          "LEFT('" & cbosexo.Text & "',1), '" & _
                                          Format(Date.Parse(mskdtnasc.Text), "MM/dd/yyyy") & "', '" & _
                                          txtemail.Text & "', 1)"


                    con.Open()
                    Try
                        cmd.ExecuteNonQuery()

                    Catch ex As System.Data.SqlClient.SqlException
                        MsgBox(ex.Message)

                    End Try

                    con.Close()

                    MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information)
                    Limpa_Tela()
                    txtcodcli.Clear()

                End If

            ElseIf mskcpf.Text = "" Then
                If cbostatus.SelectedIndex = 1 Then
                    cmd.CommandText = "INSERT INTO TBClientes VALUES('" & _
                                               txtcodcli.Text & "', '" & _
                                               txtnome.Text & "', '" & _
                                               mskcpf.Text & "'," & _
                                               "LEFT('" & cbosexo.Text & "',1), '" & _
                                               Format(Date.Parse(mskdtnasc.Text), "MM/dd/yyyy") & "', '" & _
                                               txtemail.Text & "', 0)"


                    con.Open()
                    Try
                        cmd.ExecuteNonQuery()

                    Catch ex As System.Data.SqlClient.SqlException
                        MsgBox(ex.Message)

                    End Try

                    con.Close()

                    MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information)
                    Limpa_Tela()
                    txtcodcli.Clear()


                Else
                    cmd.CommandText = "INSERT INTO TBClientes VALUES('" & _
                                          txtcodcli.Text & "', '" & _
                                          txtnome.Text & "', '" & _
                                          mskcpf.Text & "'," & _
                                          "LEFT('" & cbosexo.Text & "',1), '" & _
                                          Format(Date.Parse(mskdtnasc.Text), "MM/dd/yyyy") & "', '" & _
                                          txtemail.Text & "', 1)"


                    con.Open()
                    Try
                        cmd.ExecuteNonQuery()

                    Catch ex As System.Data.SqlClient.SqlException
                        MsgBox(ex.Message)

                    End Try

                    con.Close()

                    MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information)
                    Limpa_Tela()
                    txtcodcli.Clear()

                End If
            Else
                MsgBox("CPF é inválido!", vbCritical)

            End If

        ElseIf EmailAddressCheck(txtemail.Text) = True Then
            If mskcpf.MaskFull Then
                If isCPF(mskcpf.Text) = False Then
                    MsgBox("CPF é inválido!", vbCritical)
                ElseIf cbostatus.SelectedIndex = 1 Then
                    cmd.CommandText = "INSERT INTO TBClientes VALUES('" & _
                                               txtcodcli.Text & "', '" & _
                                               txtnome.Text & "', '" & _
                                               mskcpf.Text & "'," & _
                                               "LEFT('" & cbosexo.Text & "',1), '" & _
                                               Format(Date.Parse(mskdtnasc.Text), "MM/dd/yyyy") & "', '" & _
                                               txtemail.Text & "', 0)"


                    con.Open()
                    Try
                        cmd.ExecuteNonQuery()

                    Catch ex As System.Data.SqlClient.SqlException
                        MsgBox(ex.Message)

                    End Try

                    con.Close()

                    MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information)
                    Limpa_Tela()
                    txtcodcli.Clear()


                Else
                    cmd.CommandText = "INSERT INTO TBClientes VALUES('" & _
                                          txtcodcli.Text & "', '" & _
                                          txtnome.Text & "', '" & _
                                          mskcpf.Text & "'," & _
                                          "LEFT('" & cbosexo.Text & "',1), '" & _
                                          Format(Date.Parse(mskdtnasc.Text), "MM/dd/yyyy") & "', '" & _
                                          txtemail.Text & "', 1)"


                    con.Open()
                    Try
                        cmd.ExecuteNonQuery()

                    Catch ex As System.Data.SqlClient.SqlException
                        MsgBox(ex.Message)

                    End Try

                    con.Close()

                    MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information)
                    Limpa_Tela()
                    txtcodcli.Clear()

                End If

            ElseIf mskcpf.Text = "" Then
                If cbostatus.SelectedIndex = 1 Then
                    cmd.CommandText = "INSERT INTO TBClientes VALUES('" & _
                                               txtcodcli.Text & "', '" & _
                                               txtnome.Text & "', '" & _
                                               mskcpf.Text & "'," & _
                                               "LEFT('" & cbosexo.Text & "',1), '" & _
                                               Format(Date.Parse(mskdtnasc.Text), "MM/dd/yyyy") & "', '" & _
                                               txtemail.Text & "', 0)"


                    con.Open()
                    Try
                        cmd.ExecuteNonQuery()

                    Catch ex As System.Data.SqlClient.SqlException
                        MsgBox(ex.Message)

                    End Try

                    con.Close()

                    MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information)
                    Limpa_Tela()
                    txtcodcli.Clear()


                Else
                    cmd.CommandText = "INSERT INTO TBClientes VALUES('" & _
                                          txtcodcli.Text & "', '" & _
                                          txtnome.Text & "', '" & _
                                          mskcpf.Text & "'," & _
                                          "LEFT('" & cbosexo.Text & "',1), '" & _
                                          Format(Date.Parse(mskdtnasc.Text), "MM/dd/yyyy") & "', '" & _
                                          txtemail.Text & "', 1)"


                    con.Open()
                    Try
                        cmd.ExecuteNonQuery()

                    Catch ex As System.Data.SqlClient.SqlException
                        MsgBox(ex.Message)

                    End Try

                    con.Close()

                    MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information)
                    Limpa_Tela()
                    txtcodcli.Clear()

                End If
            Else
                MsgBox("CPF é inválido!", vbCritical)

            End If
        Else
            MsgBox("Email Inválido!", vbInformation)
        End If





    End Sub


    Function ValidaCampos()
        If txtnome.Text = "" Then
            MsgBox("Digite o nome!")
            txtnome.Focus()
            Return False

        End If

        If mskcpf.Text = "" Then
            MsgBox("Digite o CPF!")
            mskcpf.Focus()
            Return False

        End If

        If cbosexo.Text = "" Then
            MsgBox("Digite o sexo!")
            cbosexo.Focus()
            Return False

        End If



        Return True
    End Function

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

    Private Sub Limpa_Tela()
        txtnome.Clear()
        mskcpf.Clear()
        mskdtnasc.Clear()
        txtemail.Clear()
        cbosexo.SelectedIndex = -1
        txtnome.Focus()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
        Limpa_Tela()
        txtcodcli.Clear()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        MsgBox(Format(Date.Parse(mskdtnasc.Text), "MM/dd/yyyy"), MsgBoxStyle.Information)
    End Sub

    Private Sub pbcad_Click(sender As Object, e As EventArgs) Handles pbcad.Click

        Dim con As SqlConnection
        con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")
        con.Open()
        Dim sqlCommand As SqlCommand = New SqlCommand("SELECT ISNULL(MAX(Cod_Cliente) +1, 1) AS PROXNUM FROM TBClientes", con)
        Dim sqlReader As SqlDataReader

        sqlReader = sqlCommand.ExecuteReader()
        If sqlReader.Read() Then
            txtcodcli.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        con.Close()

        cbostatus.Text = "ativo"


        txtnome.ReadOnly = False
        mskcpf.ReadOnly = False
        mskdtnasc.ReadOnly = False
        cbosexo.Enabled = True
        txtemail.ReadOnly = False
        cbostatus.Enabled = False


        cbosexo.SelectedIndex = -1
        cbostatus.SelectedIndex = 0


        btnsalvar.Visible = True
        btnaltera.Visible = False

        Limpa_Tela()


    End Sub

    Private Sub pbconsulta_Click(sender As Object, e As EventArgs) Handles pbconsulta.Click
        FrmPesquisaCli.ShowDialog()
        FrmPesquisaCli.DataGridCli.Refresh()

    End Sub

    Private Sub btnlimpar_Click(sender As Object, e As EventArgs) Handles btnlimpar.Click
        Limpa_Tela()
        txtcodcli.Clear()


    End Sub


    Private Sub pbedit_Click(sender As Object, e As EventArgs) Handles pbedit.Click

        txtnome.ReadOnly = False
        mskdtnasc.ReadOnly = False
        cbosexo.Enabled = True
        txtemail.ReadOnly = False
        cbostatus.Enabled = False






        btnsalvar.Visible = False
        btnaltera.Enabled = True

    End Sub

    Private Sub btnaltera_Click(sender As Object, e As EventArgs) Handles btnaltera.Click
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        cmd.Connection = con


        If isCPF(mskcpf.Text) = False Then
            MsgBox("CPF é inválido!", vbCritical)
        ElseIf cbostatus.SelectedIndex = 1 Then
            cmd.CommandText = "UPDATE TBClientes SET Nome_Completo = '" & _
                                       txtnome.Text & "', CPF = " & _
                                       mskcpf.Text & ", Sexo = " & _
                                       "LEFT('" & cbosexo.Text & "',1), Data_de_Nascimento = '" & _
                                       Format(Date.Parse(mskdtnasc.Text), "MM/dd/yyyy") & "', Email = '" & _
                                       txtemail.Text & "', status= 1 WHERE Cod_Cliente = " & txtcodcli.Text & " "
            con.Open()
            Try
                cmd.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)

            End Try

            con.Close()

            MsgBox("Cliente alterado com sucesso!", MsgBoxStyle.Information)
            Limpa_Tela()
            txtcodcli.Clear()
        Else
            cmd.CommandText = "UPDATE TBClientes SET Nome_Completo = '" & _
                                       txtnome.Text & "', CPF = " & _
                                       mskcpf.Text & ", Sexo = " & _
                                       "LEFT('" & cbosexo.Text & "',1), Data_de_Nascimento = '" & _
                                       Format(Date.Parse(mskdtnasc.Text), "MM/dd/yyyy") & "', Email = '" & _
                                       txtemail.Text & "' WHERE Cod_Cliente = " & txtcodcli.Text & " "
            con.Open()
            Try
                cmd.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)

            End Try

            con.Close()

            MsgBox("Cliente alterado com sucesso!", MsgBoxStyle.Information)
            Limpa_Tela()
            txtcodcli.Clear()


        End If


    End Sub

    Private Sub FrmCadCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnaltera.Visible = False

    End Sub

    Private Sub pbdelete_Click(sender As Object, e As EventArgs) Handles pbdelete.Click
        MsgBox("Deseja inativar esse registro?", MessageBoxButtons.YesNo, "Atenção!")

        If MsgBoxResult.Yes Then
            Dim con As New SqlClient.SqlConnection
            con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
            Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
            cmd.Connection = con

            cmd.CommandText = "UPDATE TBClientes SET status = 0 where Cod_Cliente = '" & txtcodcli.Text & "' "
            con.Open()
            Try
                cmd.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)

            End Try

            con.Close()

        End If
        Limpa_Tela()
        txtcodcli.Clear()

        FrmPesquisaCli.DataGridCli.Rows.RemoveAt(FrmPesquisaCli.DataGridCli.CurrentRow.Index)




    End Sub


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

    Private Sub txtnome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnome.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtnome_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnome.Validating
        If (txtnome.Text.Trim().Length = 0) Then
            ErrorProvider1.SetError(txtnome, "Informe o nome.")
        Else
            ErrorProvider1.SetError(txtnome, "")
        End If
    End Sub

    Private Sub mskcpf_MouseLeave(sender As Object, e As EventArgs) Handles mskcpf.MouseLeave

    End Sub
    Private Sub mskcpf_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskcpf.Validating
        If (mskcpf.Text.Trim().Length = 0) Then
            ErrorProvider1.SetError(mskcpf, "Informe o CPF.")
        Else
            ErrorProvider1.SetError(mskcpf, "")
        End If
    End Sub

    Private Sub mskdtnasc_MouseLeave(sender As Object, e As EventArgs) Handles mskdtnasc.MouseLeave

    End Sub

    Private Sub mskdtnasc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskdtnasc.Validating
        If (mskdtnasc.Text.Trim().Length = 0) Then
            ErrorProvider1.SetError(mskdtnasc, "Informe a data de nascimento.")
        Else
            ErrorProvider1.SetError(mskdtnasc, "")
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
        mskdtnasc.Text = CalendarInicio.SelectionStart

    End Sub


    Private Sub CalendarInicio_DateSelected(sender As Object, e As DateRangeEventArgs) Handles CalendarInicio.DateSelected
        CalendarInicio.Dispose()

    End Sub

    Private Sub mskdtnasc_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskdtnasc.MaskInputRejected

    End Sub

    Private Sub mskcpf_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskcpf.MaskInputRejected

    End Sub
End Class