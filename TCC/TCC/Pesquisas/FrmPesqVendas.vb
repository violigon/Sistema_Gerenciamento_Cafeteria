Imports System.Data.SqlClient

Public Class FrmPesqVendas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CalendarInicio.Visible = True
        CalendarFim.Visible = False
        Button1.Visible = False
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CalendarInicio.Visible = False
        CalendarFim.Visible = False
        Button1.Visible = True
        Button2.Visible = False
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CalendarInicio.Visible = False
        CalendarFim.Visible = True
        Button4.Visible = False
        Button3.Visible = True

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CalendarInicio.Visible = False
        CalendarFim.Visible = False
        Button4.Visible = True
        Button3.Visible = False

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()

    End Sub

    Private Sub CalendarInicio_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalendarInicio.DateChanged
        mskdinicio.Text = CalendarInicio.SelectionStart
    End Sub

    Private Sub CalendarFim_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalendarFim.DateChanged
        mskfim.Text = CalendarFim.SelectionStart
    End Sub

    Private Sub FrmPesqVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetItensVendas.TBItens_Vendas' table. You can move, or remove it, as needed.
        'Me.TBItens_VendasTableAdapter.Fill(Me.DataSetItensVendas.TBItens_Vendas)

        mskdinicio.Text = Format(Today, "dd/MM/yyyy")
        mskfim.Text = Format(Today, "dd/MM/yyyy")
        cbostatus.SelectedIndex = 0

    End Sub

    Private Sub pbapaga_Click(sender As Object, e As EventArgs) Handles pbapaga.Click
        DataGridVendas.Rows.Clear()
        ' pbapaga.Visible = True
        pbok.Visible = True
        pbapaga.Visible = False

    End Sub

    Private Sub pbok_Click(sender As Object, e As EventArgs) Handles pbok.Click
        Dim sConnString As String = "Provider=sqloledb; Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Persist Security Info=True;User ID=sa;Password=123456"
        Dim rowNum As Integer

        CalendarFim.Visible = False
        CalendarInicio.Visible = False


        If cbostatus.SelectedIndex = 0 Then

            Using cn As New OleDb.OleDbConnection(sConnString)
                cn.Open()
                Dim cmd As New OleDb.OleDbCommand("select TBVendas.Cod_Venda, Cod_Produto, Quantidade, Valor from TBVendas inner join TBItens_Vendas" & _
                                                  " on TBVendas.Cod_Venda = TBItens_Vendas.Cod_Venda " & _
                                                  " where TBVendas.Data_Venda between '" & Format(Date.Parse(mskdinicio.Text), "MM/dd/yyyy") & "' and '" & Format(Date.Parse(mskfim.Text), "MM/dd/yyyy") & "'", cn)


                Dim r As OleDb.OleDbDataReader = cmd.ExecuteReader()

                If Not r.HasRows Then Exit Sub

                Do While r.Read()
                    rowNum = DataGridVendas.Rows.Add()

                    DataGridVendas.Rows.Item(rowNum).Cells(0).Value = r.GetInt32(0)
                    DataGridVendas.Rows.Item(rowNum).Cells(1).Value = r.GetInt32(1)
                    DataGridVendas.Rows.Item(rowNum).Cells(2).Value = r.GetValue(2)
                    DataGridVendas.Rows.Item(rowNum).Cells(3).Value = r.GetValue(3)

                    DataGridVendas.Rows.Item(rowNum).Cells(4).Value = DataGridVendas.Rows.Item(rowNum).Cells(2).Value * DataGridVendas.Rows.Item(rowNum).Cells(3).Value

                Loop
                cn.Close()
                lblTotal.Text = AtuTotal()
            End Using


        ElseIf cbostatus.SelectedIndex = 1 Then

            Using cn As New OleDb.OleDbConnection(sConnString)
                cn.Open()
                Dim cmd As New OleDb.OleDbCommand("select TBVendas.Cod_Venda, Cod_Item, Cod_Produto, Quantidade, Valor from TBVendas inner join TBItens_Vendas" & _
                                                  " on TBVendas.Cod_Venda = TBItens_Vendas.Cod_Venda " & _
                                                  " where TBVendas.Data_Venda between '" & Format(Date.Parse(mskdinicio.Text), "MM/dd/yyyy") & "' and '" & Format(Date.Parse(mskfim.Text), "MM/dd/yyyy") & "'" & _
                                                  " AND TBVendas.Forma_Pagamento = 'Dinheiro' ", cn)



                Dim r As OleDb.OleDbDataReader = cmd.ExecuteReader()

                If Not r.HasRows Then Exit Sub

                Do While r.Read()
                    rowNum = DataGridVendas.Rows.Add()

                    DataGridVendas.Rows.Item(rowNum).Cells(0).Value = r.GetInt32(0)
                    DataGridVendas.Rows.Item(rowNum).Cells(1).Value = r.GetInt32(1)
                    DataGridVendas.Rows.Item(rowNum).Cells(2).Value = r.GetValue(2)
                    DataGridVendas.Rows.Item(rowNum).Cells(3).Value = r.GetValue(3)

                    DataGridVendas.Rows.Item(rowNum).Cells(4).Value = DataGridVendas.Rows.Item(rowNum).Cells(2).Value * DataGridVendas.Rows.Item(rowNum).Cells(3).Value

                Loop
                cn.Close()
                lblTotal.Text = AtuTotal()
            End Using

        ElseIf cbostatus.SelectedIndex = 2 Then
            Using cn As New OleDb.OleDbConnection(sConnString)
                cn.Open()
                Dim cmd As New OleDb.OleDbCommand("select TBVendas.Cod_Venda, Cod_Item, Cod_Produto, Quantidade, Valor from TBVendas inner join TBItens_Vendas" & _
                                                  " on TBVendas.Cod_Venda = TBItens_Vendas.Cod_Venda " & _
                                                  " where TBVendas.Data_Venda between '" & Format(Date.Parse(mskdinicio.Text), "MM/dd/yyyy") & "' and '" & Format(Date.Parse(mskfim.Text), "MM/dd/yyyy") & "'" & _
                                                  " AND TBVendas.Forma_Pagamento = 'Débito' ", cn)



                Dim r As OleDb.OleDbDataReader = cmd.ExecuteReader()

                If Not r.HasRows Then Exit Sub

                Do While r.Read()
                    rowNum = DataGridVendas.Rows.Add()

                    DataGridVendas.Rows.Item(rowNum).Cells(0).Value = r.GetInt32(0)
                    DataGridVendas.Rows.Item(rowNum).Cells(1).Value = r.GetInt32(1)
                    DataGridVendas.Rows.Item(rowNum).Cells(2).Value = r.GetValue(2)
                    DataGridVendas.Rows.Item(rowNum).Cells(3).Value = r.GetValue(3)

                    DataGridVendas.Rows.Item(rowNum).Cells(4).Value = DataGridVendas.Rows.Item(rowNum).Cells(2).Value * DataGridVendas.Rows.Item(rowNum).Cells(3).Value

                Loop
                cn.Close()
                lblTotal.Text = AtuTotal()
            End Using

        ElseIf cbostatus.SelectedIndex = 3 Then
            Using cn As New OleDb.OleDbConnection(sConnString)
                cn.Open()
                Dim cmd As New OleDb.OleDbCommand("select TBVendas.Cod_Venda, Cod_Item, Cod_Produto, Quantidade, Valor from TBVendas inner join TBItens_Vendas" & _
                                                  " on TBVendas.Cod_Venda = TBItens_Vendas.Cod_Venda " & _
                                                  " where TBVendas.Data_Venda between '" & Format(Date.Parse(mskdinicio.Text), "MM/dd/yyyy") & "' and '" & Format(Date.Parse(mskfim.Text), "MM/dd/yyyy") & "'" & _
                                                  " AND TBVendas.Forma_Pagamento = 'Crédito' ", cn)



                Dim r As OleDb.OleDbDataReader = cmd.ExecuteReader()

                If Not r.HasRows Then Exit Sub

                Do While r.Read()
                    rowNum = DataGridVendas.Rows.Add()

                    DataGridVendas.Rows.Item(rowNum).Cells(0).Value = r.GetInt32(0)
                    DataGridVendas.Rows.Item(rowNum).Cells(1).Value = r.GetInt32(1)
                    DataGridVendas.Rows.Item(rowNum).Cells(2).Value = r.GetValue(2)
                    DataGridVendas.Rows.Item(rowNum).Cells(3).Value = r.GetValue(3)

                    DataGridVendas.Rows.Item(rowNum).Cells(4).Value = DataGridVendas.Rows.Item(rowNum).Cells(2).Value * DataGridVendas.Rows.Item(rowNum).Cells(3).Value

                Loop
                cn.Close()
                lblTotal.Text = AtuTotal()
            End Using


            

        End If

        pbapaga.Visible = True
        pbok.Visible = False

    End Sub

    Function AtuTotal()

        Dim cont As Decimal
        Dim soma As Decimal

        cont = DataGridVendas.Rows.Count - 2

        For i = 0 To cont
            soma += DataGridVendas.Rows.Item(i).Cells(4).Value
        Next

        Return Format(soma, "###,##0.00")

    End Function


    Private Sub pbEstorno_Click(sender As Object, e As EventArgs) Handles pbEstorno.Click
        MsgBox("DESEJA ESTORNAR A VENDA " & txtcodvenda.Text & " ?", MsgBoxStyle.Information)

        If MsgBoxResult.Ok Then
            Dim con As New SqlClient.SqlConnection
            Dim con3 As New SqlClient.SqlConnection
            Dim con4 As New SqlClient.SqlConnection
            con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
            con3.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
            con4.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
            Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
            Dim cmd3 As SqlClient.SqlCommand = New SqlClient.SqlCommand()
            Dim cmd4 As SqlClient.SqlCommand = New SqlClient.SqlCommand()
            Dim sqlReader As SqlDataReader

            cmd.Connection = con
            cmd3.Connection = con3
            cmd4.Connection = con4

            cmd.CommandText = "DELETE FROM TBVendas WHERE Cod_Venda = '" & txtcodvenda.Text & "' " & _
                              "DELETE FROM TBItens_Vendas WHERE Cod_Venda = '" & txtcodvenda.Text & "' " & _
                              "DELETE FROM TBCaixa WHERE Cod_Movimento = '" & txtcodvenda.Text & "' "
            con.Open()
            Try
                cmd.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)

            End Try

            con3.Open()

            cmd3.CommandText = " select Cod_Produto, Cod_ProdIN, (Quantidade + (" & DataGridVendas.Item(2, DataGridVendas.CurrentRow.Index).Value & " * Baixa)) as Atualiza " & _
            "from " & _
            "    (select Prod.Cod_Produto, Prod.Cod_Produto as Cod_ProdIN, 1 as Baixa, Prod.Quantidade " & _
            "     from TBProdutos Prod " & _
            "     left join TBEstrutura Estr " & _
            "     on Estr.Cod_ProdPA = Prod.Cod_Produto " & _
            "where Cod_Est Is null " & _
            "Union All " & _
            "select Prod.Cod_Produto, Estr.Cod_ProdIN, Estr.Quantidade as Baixa, PrdIN.Quantidade " & _
            "from TBProdutos Prod " & _
            "        inner join TBEstrutura Estr " & _
            "        on Estr.Cod_ProdPA = Prod.Cod_Produto " & _
            "        inner join TBProdutos PrdIN " & _
            "        on Estr.Cod_ProdIN = PrdIN.Cod_Produto ) as CstPrd " & _
            "where Cod_Produto = " & DataGridVendas.Item(1, DataGridVendas.CurrentRow.Index).Value

            sqlReader = cmd3.ExecuteReader()

            Do While sqlReader.Read()

                con4.Open()

                cmd4.CommandText = "update TBProdutos set Quantidade = " & Replace(sqlReader.GetValue(2), ",", ".") & " where Cod_Produto = " & sqlReader.GetInt32(1)
                Try
                    cmd4.ExecuteNonQuery()
                Catch ex As System.Data.SqlClient.SqlException
                    MsgBox(ex.Message)
                End Try
                con4.Close()
            Loop

            con3.Close()

            DataGridVendas.Rows.RemoveAt(DataGridVendas.CurrentRow.Index)

            con.Close()

        End If



    End Sub

    Private Sub pbEstorno_MouseHover(sender As Object, e As EventArgs) Handles pbEstorno.MouseHover
        ToolTip1.SetToolTip(pbEstorno, "Estornar Venda")

    End Sub
    Private Sub DataGridVendas_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridVendas.RowHeaderMouseClick
        txtcodvenda.Text = CStr(DataGridVendas.Item(0, DataGridVendas.CurrentRow.Index).Value)

    End Sub
End Class