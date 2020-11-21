Imports System.Data.SqlClient

Public Class FrmCadCompras

    Private Sub pbcad_Click(sender As Object, e As EventArgs) Handles pbcad.Click
        Dim con As SqlConnection
        con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")
        con.Open()
        Dim sqlCommand As SqlCommand = New SqlCommand("SELECT ISNULL(MAX(Cod_Compra) +1, 1) AS PROXNUM FROM TBCompras", con)
        Dim sqlReader As SqlDataReader

        sqlReader = sqlCommand.ExecuteReader()
        If sqlReader.Read() Then
            txtcodcompra.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        con.Close()

        mskemissao.ReadOnly = False

        mskpgto.ReadOnly = False

        mskinclusao.Text = Format(Today, "dd/MM/yyyy")

        txtqtd.ReadOnly = False

        mskemissao.Text = Format(Today, "dd/MM/yyyy")
        mskpgto.Text = Format(Today, "dd/MM/yyyy")



    End Sub

    Private Sub txtqtd_MouseLeave(sender As Object, e As EventArgs) Handles txtqtd.MouseLeave
        'Dim con As SqlConnection
        'con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")
        'con.Open()


        'Dim sqlCommand As SqlCommand = New SqlCommand("SELECT Unidade FROM TBProdutos where Cod_Produto=" & txtcodpro.Text & "", con)
        'Dim sqlReader As SqlDataReader

        'sqlReader = sqlCommand.ExecuteReader()
        'If sqlReader.Read() Then
        '    lblunid.Text = sqlReader.GetString(0)
        'End If
        'sqlReader.Close()
        'con.Close()
    End Sub

    Private Sub txtqtd_TextChanged(sender As Object, e As EventArgs) Handles txtqtd.TextChanged
       
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        Dim cont As Integer
        Dim soma As Decimal
        Dim vlrmedio As Decimal

        txtvalor.Text = Replace(Replace(Replace(txtvalor.Text, ".", ""), "R$", ""), ",", ".")

        cmd.Connection = con

        cont = DataGridCompras.Rows.Count - 2



        cmd.CommandText = "INSERT INTO TBCompras VALUES('" & _
                                txtcodcompra.Text & "', '" & _
                                txtcodfornec.Text & "', '" & _
                                Format(Date.Parse(mskemissao.Text), "MM/dd/yyyy") & "', '" & _
                                Format(Date.Parse(mskpgto.Text), "MM/dd/yyyy") & "', '" & _
                                Format(Date.Parse(mskinclusao.Text), "MM/dd/yyyy") & "')"

        For i = 0 To cont

            vlrmedio = CalculaMedia(DataGridCompras.Rows.Item(i).Cells(0).Value, DataGridCompras.Rows.Item(i).Cells(1).Value, DataGridCompras.Rows.Item(i).Cells(2).Value)
            DataGridCompras.Rows.Item(i).Cells(1).Value = Replace(DataGridCompras.Rows.Item(i).Cells(1).Value, ",", ".")

            'DataGridCompras.Rows.Item(i).Cells(2).Value = Replace(DataGridCompras.Rows.Item(i).Cells(2).Value.ToString, ",", ".")
            con.Open()

            cmd.CommandText += "INSERT INTO TBItens_Compras VALUES(" & _
                                           (i + 1).ToString & ", " & _
                                           txtcodcompra.Text & ", " & _
                                           DataGridCompras.Rows.Item(i).Cells(0).Value & ", " & _
                                           Replace(DataGridCompras.Rows.Item(i).Cells(2).Value.ToString, ",", ".") & ", '" & _
                                           Decimal.Parse(DataGridCompras.Rows.Item(i).Cells(1).Value) & "')" & _
                                "UPDATE TBProdutos Set custo = " & Replace(vlrmedio.ToString, ",", ".") & ", Quantidade=" & DataGridCompras.Rows.Item(i).Cells(1).Value & " + Quantidade WHERE Cod_Produto =" & DataGridCompras.Rows.Item(i).Cells(0).Value & " "
            '"INSERT INTO TBMov_Estoque VALUES(" & _
            '    DataGridCompras.Rows.Item(i).Cells(0).Value & ", " & _
            '    DataGridCompras.Rows.Item(i).Cells(1).Value & ")"

            soma += DataGridCompras.Rows.Item(i).Cells(2).Value * DataGridCompras.Rows.Item(i).Cells(1).Value

            Try
                cmd.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)

            End Try

            cmd.CommandText = ""
            con.Close()
        Next

        con.Open()

        cmd.CommandText = "INSERT INTO TBContas_a_Pagar(Cod_Compra, Descrição, Valor, Vencimento, Saldo) VALUES(" & _
                                 txtcodcompra.Text & ",'" & _
                                 txtnomefornec.Text & "'," & _
                                 Replace(soma.ToString, ",", ".") & ",'" & _
                                 Format(Date.Parse(mskpgto.Text), "MM/dd/yyyy") & "'," & _
                                 Replace(soma.ToString, ",", ".") & ")"

        Try
            cmd.ExecuteNonQuery()

        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message)

        End Try

        con.Close()

        MsgBox("Compra cadastrada com sucesso!", MsgBoxStyle.Information)


        LimpaTela()

    End Sub
    Function CalculaMedia(produto As Integer, qtdfim As Decimal, vlrfim As Decimal)
        Dim vlrmedio As Decimal
        Dim vlrTotal As Decimal
        Dim con As SqlConnection
        con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")
        con.Open()
        Dim sqlCommand As SqlCommand = New SqlCommand("SELECT Quantidade, custo FROM TBProdutos WHERE Cod_Produto = " & produto & "", con)
        Dim sqlReader As SqlDataReader

        sqlReader = sqlCommand.ExecuteReader()
        If sqlReader.Read() Then
            vlrTotal = sqlReader.GetDecimal(0) * sqlReader.GetDecimal(1) + qtdfim * vlrfim
            vlrmedio = vlrTotal / (qtdfim + sqlReader.GetDecimal(0))
        End If
        sqlReader.Close()
        con.Close()

        Return Math.Round(vlrmedio, 2)
    End Function
    Function CalculaMediaDeleteCompra(produto As Integer, qtdini As Decimal, vlrini As Decimal)
        Dim vlrmedio As Decimal
        Dim vlrTotal As Decimal
        Dim con As SqlConnection
        con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")
        con.Open()
        Dim sqlCommand As SqlCommand = New SqlCommand("SELECT Quantidade, custo FROM TBProdutos WHERE Cod_Produto = " & produto & "", con)
        Dim sqlReader As SqlDataReader

        sqlReader = sqlCommand.ExecuteReader()
        If sqlReader.Read() Then
            vlrTotal = (sqlReader.GetDecimal(0) * sqlReader.GetDecimal(1))
            vlrTotal = vlrTotal - (qtdini * vlrini)
            vlrmedio = vlrTotal / (sqlReader.GetDecimal(0) - qtdini)

        End If
        sqlReader.Close()
        con.Close()

        Return Math.Round(vlrmedio, 2)
    End Function

    Private Sub FrmCadCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pbpesqfornec_Click(sender As Object, e As EventArgs) Handles pbpesqfornec.Click
        FrmPesqForCompras.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()

    End Sub

    Private Sub pbpesqprod_Click(sender As Object, e As EventArgs) Handles pbpesqprod.Click
        FrmPesqProCompras.Show()

    End Sub

    Private Sub pbconsulta_Click(sender As Object, e As EventArgs) Handles pbconsulta.Click
        FrmPesqCompras.Show()
        DataGridCompras.Rows.Clear()
    End Sub
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub pbok_Click(sender As Object, e As EventArgs) Handles pbok.Click
        Dim rowNum As Integer = DataGridCompras.Rows.Add()
        'Dim cont As Integer
        'Dim soma As Decimal



        DataGridCompras.Rows.Item(rowNum).Cells(0).Value = txtcodpro.Text
        DataGridCompras.Rows.Item(rowNum).Cells(1).Value = txtqtd.Text
        DataGridCompras.Rows.Item(rowNum).Cells(2).Value = txtvalor.Text

        lblTotal.Text = AtuTotal()
        'For i = 0 To cont
        '    soma += DataGridCompras.Rows.Item(i).Cells(2).Value * DataGridCompras.Rows.Item(i).Cells(1).Value
        '    lblTotal.Text = soma
        'Next
    End Sub

    Private Sub pbexcluirow_Click(sender As Object, e As EventArgs) Handles pbexcluirow.Click
        DataGridCompras.Rows.RemoveAt(DataGridCompras.CurrentRow.Index)
        lblTotal.Text = AtuTotal()
    End Sub

    Private Sub pbdelete_Click(sender As Object, e As EventArgs) Handles pbdelete.Click
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        cmd.Connection = con
        MsgBox("Deseja deletar esse registro?", MessageBoxButtons.YesNo, "Atenção!")




        If MsgBoxResult.Yes Then
            Dim vlrmedio As Decimal
            Dim cont As Integer

            For i = 0 To cont

                vlrmedio = CalculaMediaDeleteCompra(DataGridCompras.Rows.Item(i).Cells(0).Value, DataGridCompras.Rows.Item(i).Cells(1).Value, DataGridCompras.Rows.Item(i).Cells(2).Value)

                DataGridCompras.Rows.Item(i).Cells(2).Value = Replace(Replace(Replace(DataGridCompras.Rows.Item(i).Cells(2).Value, ".", ""), "R$", ""), ",", ".")




                cmd.CommandText = "UPDATE TBProdutos Set custo = " & Replace(vlrmedio.ToString, ",", ".") & ", Quantidade=" & DataGridCompras.Rows.Item(i).Cells(1).Value & " + Quantidade WHERE Cod_Produto =" & DataGridCompras.Rows.Item(i).Cells(0).Value & " " & _
                                  "DELETE FROM TBContas_a_Pagar WHERE Cod_Compra= '" & txtcodcompra.Text & "' " & _
                                  "DELETE FROM TBItens_Compras WHERE Cod_Compra = '" & txtcodcompra.Text & "' " & _
                                  "DELETE FROM TBCompras WHERE Cod_Compra = '" & txtcodcompra.Text & "' "
                con.Open()
                Try
                    cmd.ExecuteNonQuery()

                Catch ex As System.Data.SqlClient.SqlException
                    MsgBox(ex.Message)

                End Try

                con.Close()

            Next
          
        End If
        DataGridCompras.Rows.Clear()
        txtcodcompra.Clear()


    End Sub

    Function AtuTotal()

        Dim cont As Decimal
        Dim soma As Decimal

        cont = DataGridCompras.Rows.Count - 2

        For i = 0 To cont
            soma += DataGridCompras.Rows.Item(i).Cells(2).Value * DataGridCompras.Rows.Item(i).Cells(1).Value
        Next

        Return Format(soma, "###,##0.00")

    End Function


    Private Sub mskinclusao_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskinclusao.MaskInputRejected

    End Sub

    Private Sub txtvalor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvalor.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtvalor_TextChanged(sender As Object, e As EventArgs) Handles txtvalor.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CalendarEmissao.Visible = True
        CalendarInclusao.Visible = False
        Button1.Visible = True
        Button2.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CalendarEmissao.Visible = False
        CalendarEmissao.Visible = False
        Button2.Visible = True
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CalendarInclusao.Visible = True
        CalendarEmissao.Visible = False
        Button3.Visible = True
        Button4.Visible = False
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CalendarEmissao.Visible = False
        CalendarInclusao.Visible = False
        Button4.Visible = True
    End Sub

    Private Sub CalendarInclusao_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalendarInclusao.DateChanged
        mskpgto.Text = CalendarInclusao.SelectionStart
    End Sub

    Private Sub CalendarEmissao_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalendarEmissao.DateChanged
        mskemissao.Text = CalendarEmissao.SelectionStart
    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        LimpaTela()
    End Sub
    Sub LimpaTela()
        txtcodcompra.Clear()
        txtcodfornec.Clear()
        txtcodpro.Clear()
        txtqtd.Clear()
        txtnomefornec.Clear()
        mskemissao.Clear()
        mskinclusao.Clear()
        mskpgto.Clear()
        DataGridCompras.Rows.Clear()
        txtvalor.Clear()
        lblTotal.Text = "0,00"

    End Sub

    Private Sub CalendarInclusao_DateSelected(sender As Object, e As DateRangeEventArgs) Handles CalendarInclusao.DateSelected
        CalendarInclusao.Dispose()
    End Sub

    Private Sub CalendarEmissao_DateSelected(sender As Object, e As DateRangeEventArgs) Handles CalendarEmissao.DateSelected
        CalendarEmissao.Dispose()

    End Sub
End Class