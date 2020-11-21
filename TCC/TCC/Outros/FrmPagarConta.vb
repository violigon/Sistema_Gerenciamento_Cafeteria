Public Class FrmPagarConta

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()

    End Sub


    Private Sub btnpagar_Click(sender As Object, e As EventArgs) Handles btnpagar.Click
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        Dim diff As Double




        diff = FrmCadContas.txtsaldo.Text - txtvalor.Text

        txtvalor.Text = Replace(Replace(Replace(txtvalor.Text, ".", ""), "R$", ""), ",", ".")


        cmd.Connection = con

        cmd.CommandText = "UPDATE TBContas_a_Pagar SET Saldo = '" & _
                                       diff & "', Data_Pagamento ='" & _
                                       Format(Date.Parse(mskpgto.Text), "MM/dd/yyyy") & "' WHERE Cod_Compra = " & FrmCadContas.txtcodcompra.Text & " " & _
                        "INSERT INTO TBCaixa VALUES('S'," & FrmCadContas.txtcodcompra.Text & ", '" & txtvalor.Text & "')"



        con.Open()
        Try
            cmd.ExecuteNonQuery()

        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message)

        End Try


        'FrmCadContas.txtsaldo.Text = String.Format("{2;N}")

        FrmCadContas.txtsaldo.Text = FormatCurrency(diff)

        con.Close()
        Me.Close()

        mskpgto.Text = FrmCadContas.mskdtpgto.Text

       


    End Sub

    Private Sub FrmPagarConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class