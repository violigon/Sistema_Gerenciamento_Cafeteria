Public Class FormSplashScreen

    Dim Frase1 As String = "Inicializando o Software"
    Dim Frase2 As String = "Estabelecendo Conexão com SQL Server "
    Dim Frase3 As String = "Carregando forms e imagens"
    Dim Frase4 As String = "Carregando Códigos"
    'Se hover mais dicas é só continuar criando mais Strings...
    Dim cont As Integer = 0
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        cont = cont + 1
        If cont = 1 Then Me.Label1.Text = Frase1
        If cont = 2 Then Me.Label1.Text = Frase2
        If cont = 3 Then Me.Label1.Text = Frase3

        'Depois da ultima dica, o código abaixo faz voltar para a primeira dica.
        'Caso não deseje voltar é só retirar o "cont = 0"
        If cont = 4 Then
            Me.Label1.Text = Frase4
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar2.Increment(2)
        Label2.Text = ProgressBar2.Value & "%"
        If ProgressBar2.Value = ProgressBar2.Maximum Then
            Login.Show()
            Timer1.Stop()
            Me.Hide()

        End If
    End Sub
    Private Sub FormSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    
End Class
