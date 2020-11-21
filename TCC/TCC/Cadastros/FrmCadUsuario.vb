Imports System.Data.SqlClient

Public Class FrmCadUsuario

    Private Sub FrmCadUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetFunc.TBFuncionarios' table. You can move, or remove it, as needed.
        Me.TBFuncionariosTableAdapter.Fill(Me.DataSetFunc.TBFuncionarios)
        'TODO: This line of code loads data into the 'DataSetFuncUser.TBFuncionarios' table. You can move, or remove it, as needed.
        'Me.TBFuncionariosTableAdapter.Fill(Me.DataSetFuncUser.TBFuncionarios)
        'TODO: This line of code loads data into the 'DataSetFunc.TBFuncionarios' table. You can move, or remove it, as needed.
        'Me.TBFuncionariosTableAdapter.Fill(Me.DataSetFunc.TBFuncionarios)

        txtLogin.ReadOnly = True
        txtsenha.ReadOnly = True
        cbostatus.Enabled = False

    End Sub

    Private Sub PBCad_Click(sender As Object, e As EventArgs) Handles PBCad.Click
        Dim con As SqlConnection
        con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")
        con.Open()


        Dim sqlCommand As SqlCommand = New SqlCommand("SELECT ISNULL(MAX(Cod_login) +1, 1) AS PROXNUM FROM TB_Login", con)
        Dim sqlReader As SqlDataReader

        sqlReader = sqlCommand.ExecuteReader()
        If sqlReader.Read() Then
            txtCodUser.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        con.Close()


        txtCodFunc.Clear()
        txtLogin.Clear()
        txtsenha.Clear()
        CBOCod.SelectedIndex = -1


        btnaltera.Visible = False
        btnsalvar.Visible = True
        CBOCod.Enabled = True
        txtCodFunc.ReadOnly = False
        txtLogin.ReadOnly = False
        txtsenha.ReadOnly = False
        cbostatus.SelectedIndex = 0
    End Sub
    Private Sub DataGridUser_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Dim i As Integer
        i = DataGridUser.CurrentRow.Index
        txtCodFunc.Text = DataGridUser.Item(0, i).Value
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        cmd.Connection = con

        If ValidaCampos() = False Then
            Exit Sub
        End If

        If cbostatus.SelectedIndex = 1 Then
            cmd.CommandText = "INSERT INTO TB_Login (Cod_login, LoginUser, Senha, CodAcesso, Cod_Funcionario, status) VALUES('" & _
                                       txtCodUser.Text & "', '" & _
                                       txtLogin.Text & "', '" & _
                                       txtsenha.Text & "', '" & _
                                       CBOCod.Text & "', '" & _
                                       txtCodFunc.Text & "', 0 )"

            con.Open()
            Try
                cmd.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)

            End Try

            con.Close()

            MsgBox("Usuário cadastrado com sucesso!", MsgBoxStyle.Information)
        Else
            cmd.CommandText = "INSERT INTO TB_Login (Cod_login, LoginUser, Senha, CodAcesso, Cod_Funcionario, status) VALUES('" & _
                                       txtCodUser.Text & "', '" & _
                                       txtLogin.Text & "', '" & _
                                       txtsenha.Text & "', '" & _
                                       CBOCod.Text & "', '" & _
                                       txtCodFunc.Text & "', 1 )"

            con.Open()
            Try
                cmd.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)

            End Try

            con.Close()

            MsgBox("Usuário cadastrado com sucesso!", MsgBoxStyle.Information)
        End If
        cbostatus.Enabled = True

        LimpaTela()


    End Sub

    Function ValidaCampos()
        If txtCodUser.Text = "" Then
            MsgBox("Selecione o nível de acesso!")
            txtCodUser.Focus()
            Return False

        End If

        If txtCodFunc.Text = "" Then
            MsgBox("Selecione o código do empregado!")
            txtCodFunc.Focus()
            Return False

        End If

        If txtLogin.Text = "" Then
            MsgBox("Digite o usuário!")
            txtLogin.Focus()
            Return False

        End If

        If txtsenha.Text = "" Then
            MsgBox("Digite a senha!")
            txtsenha.Focus()
            Return False

        End If


        Return True
    End Function
    Private Sub PBpescUsua_Click(sender As Object, e As EventArgs) Handles PBpescUsua.Click
        FrmPesqUser.Show()
    End Sub

    Private Sub PBEdit_Click(sender As Object, e As EventArgs) Handles PBEdit.Click
        CBOCod.Enabled = True
        txtCodFunc.Enabled = True
        txtLogin.ReadOnly = False
        txtSenha.ReadOnly = False



        btnaltera.Enabled = True

    End Sub
    Sub LimpaTela()
        txtCodUser.Clear()
        txtCodFunc.Clear()
        txtLogin.Clear()
        txtsenha.Clear()
        CBOCod.SelectedIndex = -1
    End Sub


    Private Sub btnaltera_Click(sender As Object, e As EventArgs) Handles btnaltera.Click
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        cmd.Connection = con

        cmd.CommandText = "UPDATE TB_Login SET LoginUser = '" & _
                                   txtLogin.Text & "', Senha = '" & _
                                   txtSenha.Text & "', Cod_Funcionario = " & _
                                   txtCodFunc.Text & ", CodAcesso = " & _
                                   CBOCod.Text & " WHERE Cod_login = " & txtCodUser.Text & " "
        con.Open()
        Try
            cmd.ExecuteNonQuery()

        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message)

        End Try

        con.Close()

        MsgBox("Usuário alterado com sucesso!", MsgBoxStyle.Information)

        If MsgBoxResult.Ok Then
            LimpaTela()
            txtCodUser.Clear()
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        LimpaTela()
        txtCodUser.Clear()
        Me.Close()

    End Sub

    Private Sub DataGridUser_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridUser.RowHeaderMouseClick
        Dim con As SqlConnection
        con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")
        con.Open()
        Dim sqlCommand As SqlCommand = New SqlCommand("select f.Cod_Funcionario from TBFuncionarios F left join TB_Login L on f.Cod_Funcionario = l.Cod_Funcionario where f.Cod_Funcionario = " & DataGridUser.Item(0, DataGridUser.CurrentRow.Index).Value & " and L.LoginUser is null ", con)
        Dim sqlReader As SqlDataReader


        sqlReader = sqlCommand.ExecuteReader()
        If Not sqlReader.HasRows Then
            MsgBox("Já existe usuário cadastrado para este funcionário!", vbInformation)
            txtCodFunc.Clear()
        End If

        If sqlReader.Read() Then
            txtCodFunc.Text = CStr(DataGridUser.Item(0, DataGridUser.CurrentRow.Index).Value)
        End If
        sqlReader.Close()
        con.Close()


    End Sub

    Private Sub btnlimpar_Click(sender As Object, e As EventArgs) Handles btnlimpar.Click
        LimpaTela()

    End Sub

    Private Sub PBExcluiUser_Click(sender As Object, e As EventArgs) Handles PBExcluiUser.Click
        MsgBox("Deseja inativar esse registro?", MessageBoxButtons.YesNo, "Atenção!")

        If MsgBoxResult.Yes Then
            Dim con As New SqlClient.SqlConnection
            con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
            Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
            cmd.Connection = con

            cmd.CommandText = "UPDATE TB_Login SET status = 0 where Cod_login = '" & txtCodUser.Text & "' "
            con.Open()
            Try
                cmd.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)



            End Try

            con.Close()


            LimpaTela()
            txtCodUser.Clear()
        Else
            Exit Sub
        End If


    End Sub

    Private Sub DataGridUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridUser.CellContentClick

    End Sub
End Class