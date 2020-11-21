Imports System.Data.SqlClient

Public Class FrmCadContas

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        cmd.Connection = con

        txtvalor.Text = Replace(Replace(Replace(txtvalor.Text, ".", ""), "R$", ""), ",", ".")


        cmd.CommandText = "INSERT INTO TBContas_a_Pagar(Descrição, Valor, Vencimento, Data_Pagamento, Saldo) VALUES('" & _
                                   txtdesc.Text & "','" & _
                                   txtvalor.Text & "','" & _
                                   Format(Date.Parse(mskdtvenc.Text), "MM/dd/yyyy") & "', '" & _
                                   Format(Date.Parse(mskdtpgto.Text), "MM/dd/yyyy") & "', '" & _
                                   txtvalor.Text & "')"


        con.Open()
        Try
            cmd.ExecuteNonQuery()

        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message)

        End Try

        con.Close()

        MsgBox("Conta cadastrada com sucesso!", MsgBoxStyle.Information)
        LimparTela()

        Label10.Visible = False
        Label9.Visible = False


    End Sub

    Private Sub pbcad_Click(sender As Object, e As EventArgs) Handles pbcad.Click
        txtdesc.Enabled = True
        mskdtpgto.Enabled = True
        mskdtvenc.Enabled = True
        btnsalvar.Enabled = True


        txtvalor.Enabled = True
        txtsaldo.Enabled = False
        txtdesc.Focus()

        Label10.Visible = False
        Label9.Visible = False

        LimparTela()

    End Sub

    Private Sub txtvalor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvalor.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CalendarContasPag.Visible = False
        CalendarContasVenc.Visible = False
        Button2.Visible = True

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalendarContasVenc.DateChanged
        mskdtvenc.Text = CalendarContasVenc.SelectionStart
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CalendarContasPag.Visible = False
        CalendarContasVenc.Visible = True
        Button1.Visible = True
        Button2.Visible = False
    End Sub

    Private Sub CalendarContasPag_DateChanged(sender As Object, e As DateRangeEventArgs)
        mskdtpgto.Text = CalendarContasPag.SelectionStart
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        CalendarContasVenc.Visible = False
        CalendarContasPag.Visible = False
        Button3.Visible = False
        Button4.Visible = True
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        CalendarContasVenc.Visible = False
        CalendarContasPag.Visible = True
        Button3.Visible = True
        Button4.Visible = False
    End Sub


    Private Sub pbconsulta_Click(sender As Object, e As EventArgs) Handles pbconsulta.Click
        FrmPesqContas.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        LimparTela()
        Me.Close()

    End Sub

    Private Sub pbedit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pbpagarconta_Click(sender As Object, e As EventArgs) Handles pbpagarconta.Click
        FrmPagarConta.Show()
        FrmPagarConta.mskpgto.Text = Format(Today, "dd/MM/yyyy")

        FrmPagarConta.txtvalor.Text = txtsaldo.Text

    End Sub


    Private Sub FrmCadContas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Visible = True
        Button1.Visible = False
        txtcodcompra.Enabled = False
        txtvalor.Enabled = False
        txtsaldo.Enabled = False
        txtdesc.Enabled = False
        mskdtpgto.Enabled = False
        mskdtvenc.Enabled = False

    End Sub

    Private Sub txtvalor_TextChanged(sender As Object, e As EventArgs) Handles txtvalor.TextChanged

    End Sub

    Private Sub txtsaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsaldo.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then
            e.Handled = True

        End If
    End Sub

    Private Sub CalendarContasVenc_DateSelected(sender As Object, e As DateRangeEventArgs) Handles CalendarContasVenc.DateSelected
        CalendarContasVenc.Dispose()
    End Sub

    Private Sub btnlimpar_Click(sender As Object, e As EventArgs) Handles btnlimpar.Click
        LimparTela()
        txtsaldo.Clear()

        Label10.Visible = False
        Label9.Visible = False

    End Sub

    Sub LimparTela()
        txtcodcompra.Clear()
        txtdesc.Clear()
        txtvalor.Clear()
        mskdtpgto.Clear()
        mskdtvenc.Clear()
    End Sub

    Private Sub CalendarContasPag_DateChanged_1(sender As Object, e As DateRangeEventArgs) Handles CalendarContasPag.DateChanged
        mskdtpgto.Text = CalendarContasPag.SelectionStart

    End Sub

    Private Sub CalendarContasPag_DateSelected(sender As Object, e As DateRangeEventArgs) Handles CalendarContasPag.DateSelected
        CalendarContasPag.Dispose()

    End Sub
End Class