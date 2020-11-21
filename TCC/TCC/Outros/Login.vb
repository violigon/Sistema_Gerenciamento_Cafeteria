Imports System.Data.OleDb

Public Class Login
    Public CN As New OleDbConnection()

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim comandos As New OleDbCommand
        Dim consulta As OleDbDataReader
        'Dim tipo As Char
        CN.ConnectionString = ("Provider=SQLOLEDB;Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Persist Security Info=True;User ID=sa;Password=123456")
        CN.Open()
        comandos.CommandText = "SELECT * from TB_Login where LoginUser='" + txtLogin.Text + "'And Senha='" + txtSenha.Text + "' SELECT CodAcesso from TB_Login where LoginUser ='" + txtLogin.Text + "'And Senha='" + txtSenha.Text + "'"


        comandos.Connection = CN
        consulta = comandos.ExecuteReader()
        If txtLogin.Text = "" Then
            MsgBox("Login em branco", MsgBoxStyle.Critical)
        ElseIf txtSenha.Text = "" Then
            MsgBox("Senha em branco", MsgBoxStyle.Critical)
        End If
        If (consulta.HasRows) Then
            Me.Hide()
            FrmPrinc.Show()
            Dim cmd As New OleDbCommand
            Dim sqlreader As OleDbDataReader

            cmd.Connection = CN
            cmd.CommandText = "SELECT CodAcesso FROM TB_Login where LoginUser='" & txtLogin.Text & "' "


            sqlreader = cmd.ExecuteReader()
            If sqlreader.Read() Then
                If sqlreader.GetValue(0) = 1 Then
                    FrmPrinc.lblacesso.Text = "ADMINISTRADOR - " + txtLogin.Text
                   
                Else
                    FrmPrinc.lblacesso.Text = "EMPREGADO - " + txtLogin.Text
                    FrmPrinc.PBCadFuncionario.Visible = False
                    FrmPrinc.PBCadUser.Visible = False
                    FrmPrinc.PBRelatorios.Visible = False
                    FrmPrinc.Pbbackup.Visible = False
                    FrmPrinc.PBCadeado.Enabled = False

                End If
            End If

                sqlreader.Close()





            Else
                MsgBox("Nome de Usuário ou Senha Está Incorreto, Tente Novamente!", MsgBoxStyle.Critical)
                txtLogin.Clear()
                txtSenha.Clear()
                txtLogin.Focus()
            End If
            CN.Close()

    End Sub

    Private Sub txtSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSenha.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnok_Click(sender, e)
        End If
    End Sub

    Private Sub PBSair_Click(sender As Object, e As EventArgs) Handles PBSair.Click
        End

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtLogin.Focus()

    End Sub

    Private Sub PBArrastar_Click(sender As Object, e As EventArgs) Handles PBArrastar.Click

    End Sub
End Class