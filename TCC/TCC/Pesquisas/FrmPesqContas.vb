Imports System.Data.SqlClient

Public Class FrmPesqContas

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()

    End Sub


 
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

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click

        mskdinicio.Clear()
        mskfim.Clear()

        Dim con As SqlConnection
        con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")
        con.Open()
        Dim sqlCommand As SqlCommand = New SqlCommand("SELECT Valor FROM TBContas_a_Pagar where Cod_Compra = " & DataGridContas.Item(0, DataGridContas.CurrentRow.Index).Value & "", con)
        Dim sqlReader As SqlDataReader

        sqlReader = sqlCommand.ExecuteReader()
        If sqlReader.Read() Then
            FrmCadContas.txtvalor.Text = FormatCurrency(CStr(sqlReader.GetValue(0)))
        End If
        sqlReader.Close()

        FrmCadContas.txtcodcompra.Text = CStr(DataGridContas.Item(0, DataGridContas.CurrentRow.Index).Value)
        FrmCadContas.txtdesc.Text = CStr(DataGridContas.Item(1, DataGridContas.CurrentRow.Index).Value)
        FrmCadContas.txtsaldo.Text = FormatCurrency(CStr(DataGridContas.Item(2, DataGridContas.CurrentRow.Index).Value))
        FrmCadContas.mskdtvenc.Text = CStr(DataGridContas.Item(3, DataGridContas.CurrentRow.Index).Value)
        FrmCadContas.btnsalvar.Enabled = False

        con.Close()
        Me.Close()



        FrmCadContas.Label9.Visible = True
        FrmCadContas.Label10.Visible = True

        If FrmCadContas.txtsaldo.Text = "R$ 0,00" Then

            FrmCadContas.Label10.Text = "CONTA PAGA"
        Else

            FrmCadContas.Label10.Text = "CONTA EM ABERTO"
        End If
    End Sub


    Private Sub CalendarInicio_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalendarInicio.DateChanged
        mskdinicio.Text = CalendarInicio.SelectionStart
    End Sub

    Private Sub CalendarFim_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalendarFim.DateChanged
        mskfim.Text = CalendarFim.SelectionStart
    End Sub

    Private Sub pbok_Click(sender As Object, e As EventArgs) Handles pbok.Click

        Dim sConnString As String = "Provider=sqloledb; Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Persist Security Info=True;User ID=sa;Password=123456"
        Dim rowNum As Integer

        CalendarFim.Visible = False
        CalendarInicio.Visible = False


        If cbostatus.SelectedIndex = 0 Then


            Using cn As New OleDb.OleDbConnection(sConnString)
                cn.Open()
                Dim cmd As New OleDb.OleDbCommand("SELECT iSNULL(TBContas_a_Pagar.Cod_Compra,''), Descrição, Valor, Vencimento, Data_Pagamento, *" & _
                                                  " FROM TBContas_a_Pagar LEFT JOIN TBCompras " & _
                                                  " ON TBCompras.Cod_Compra = TBContas_a_Pagar.Cod_Compra" & _
                                                  " WHERE TBContas_a_Pagar.Vencimento BETWEEN '" & Format(Date.Parse(mskdinicio.Text), "MM/dd/yyyy") & "' and '" & Format(Date.Parse(mskfim.Text), "MM/dd/yyyy") & "'", cn)



                Dim r As OleDb.OleDbDataReader = cmd.ExecuteReader()

                If Not r.HasRows Then Exit Sub

                Do While r.Read()
                    rowNum = DataGridContas.Rows.Add()

                    DataGridContas.Rows.Item(rowNum).Cells(0).Value = r.GetInt32(0)
                    DataGridContas.Rows.Item(rowNum).Cells(1).Value = r.GetString(1)
                    DataGridContas.Rows.Item(rowNum).Cells(2).Value = r.GetValue(11)
                    DataGridContas.Rows.Item(rowNum).Cells(3).Value = Format(Date.Parse(r.GetString(3)), "dd/MM/yyyy")


                Loop





                cn.Close()
            End Using
        ElseIf cbostatus.SelectedIndex = 1 Then
            Using cn As New OleDb.OleDbConnection(sConnString)
                cn.Open()
                Dim cmd As New OleDb.OleDbCommand("SELECT iSNULL(TBContas_a_Pagar.Cod_Compra,''), Descrição, Valor, Vencimento, Data_Pagamento, *" & _
                                                  " FROM TBContas_a_Pagar LEFT JOIN TBCompras " & _
                                                  " ON TBCompras.Cod_Compra = TBContas_a_Pagar.Cod_Compra" & _
                                                  " WHERE TBContas_a_Pagar.Vencimento BETWEEN '" & Format(Date.Parse(mskdinicio.Text), "MM/dd/yyyy") & "' and '" & Format(Date.Parse(mskfim.Text), "MM/dd/yyyy") & "'" & _
                                                  " AND Saldo = '0,00'", cn)



                Dim r As OleDb.OleDbDataReader = cmd.ExecuteReader()

                If Not r.HasRows Then Exit Sub

                Do While r.Read()
                    rowNum = DataGridContas.Rows.Add()

                    DataGridContas.Rows.Item(rowNum).Cells(0).Value = r.GetInt32(0)
                    DataGridContas.Rows.Item(rowNum).Cells(1).Value = r.GetString(1)
                    DataGridContas.Rows.Item(rowNum).Cells(2).Value = r.GetValue(11)
                    DataGridContas.Rows.Item(rowNum).Cells(3).Value = Format(Date.Parse(r.GetString(3)), "dd/MM/yyyy")


                Loop





                cn.Close()
            End Using
        Else
            Using cn As New OleDb.OleDbConnection(sConnString)
                cn.Open()
                Dim cmd As New OleDb.OleDbCommand("SELECT iSNULL(TBContas_a_Pagar.Cod_Compra,''), Descrição, Valor, Vencimento, Data_Pagamento, *" & _
                                                  " FROM TBContas_a_Pagar LEFT JOIN TBCompras " & _
                                                  " ON TBCompras.Cod_Compra = TBContas_a_Pagar.Cod_Compra" & _
                                                  " WHERE TBContas_a_Pagar.Vencimento BETWEEN '" & Format(Date.Parse(mskdinicio.Text), "MM/dd/yyyy") & "' and '" & Format(Date.Parse(mskfim.Text), "MM/dd/yyyy") & "'" & _
                                                  " AND Saldo <> '0.00'", cn)



                Dim r As OleDb.OleDbDataReader = cmd.ExecuteReader()

                If Not r.HasRows Then Exit Sub

                Do While r.Read()
                    rowNum = DataGridContas.Rows.Add()

                    DataGridContas.Rows.Item(rowNum).Cells(0).Value = r.GetInt32(0)
                    DataGridContas.Rows.Item(rowNum).Cells(1).Value = r.GetString(1)
                    DataGridContas.Rows.Item(rowNum).Cells(2).Value = r.GetValue(11)
                    DataGridContas.Rows.Item(rowNum).Cells(3).Value = Format(Date.Parse(r.GetString(3)), "dd/MM/yyyy")


                Loop





                cn.Close()
            End Using
        End If

        pbok.Visible = False
        pbapaga.Visible = True

    End Sub

    Private Sub pbapaga_Click(sender As Object, e As EventArgs) Handles pbapaga.Click
        DataGridContas.Rows.Clear()
        pbapaga.Visible = False
        pbok.Visible = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbostatus.SelectedIndexChanged

    End Sub
    Private Sub FrmPesqContas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbostatus.SelectedIndex = 0
        mskdinicio.Text = Format(Today, "dd/MM/yyyy")
        mskfim.Text = Format(Today, "dd/MM/yyyy")

    End Sub

    Private Sub CalendarInicio_DateSelected(sender As Object, e As DateRangeEventArgs) Handles CalendarInicio.DateSelected
        CalendarInicio.Dispose()
    End Sub

    Private Sub CalendarFim_DateSelected(sender As Object, e As DateRangeEventArgs) Handles CalendarFim.DateSelected
        CalendarFim.Dispose()
    End Sub
End Class