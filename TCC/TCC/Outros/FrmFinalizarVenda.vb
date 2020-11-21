Imports System.Data.SqlClient

Public Class FrmFinalizarVenda

    Private Sub btnfinalizar_Click(sender As Object, e As EventArgs) Handles btnfinalizar.Click
        Dim con As New SqlClient.SqlConnection
        Dim con2 As New SqlClient.SqlConnection
        Dim con3 As New SqlClient.SqlConnection
        Dim con4 As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        con2.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        con3.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        con4.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        Dim cmd2 As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        Dim cmd3 As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        Dim cmd4 As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        Dim cont As Integer
        Dim sqlReader As SqlDataReader
        Dim custo As String
        Dim formapgto As String

        FrmVendas.txtvalor.Text = Replace(Replace(Replace(FrmVendas.txtvalor.Text, ".", ""), "R$", ""), ",", ".")

        cmd.Connection = con
        cmd2.Connection = con2
        cmd3.Connection = con3
        cmd4.Connection = con4

        cont = FrmVendas.DataGridVendas.Rows.Count - 2

        If rbtdinheiro.Checked Then
            formapgto = "Dinheiro"
        ElseIf rbtdebito.Checked Then
            formapgto = "Débito"
        ElseIf rbtcredito.Checked Then
            formapgto = "Crédito"
        Else
            Exit Sub
        End If

        con.Open()
        cmd.CommandText = "INSERT INTO TBVendas VALUES(" & _
                                FrmVendas.lblpedido.Text & ", " & _
                                FrmVendas.txtcodcli.Text & ", '" & _
                                Format(Date.Parse(FrmVendas.mskdata.Text), "MM/dd/yyyy") & "', '" & formapgto & "', '" & _
                                FrmVendas.mskcpf.Text & "', '" & _
                                FrmVendas.lbluser.Text & "')" & _
                                "INSERT INTO TBCaixa VALUES('E'," & FrmVendas.lblpedido.Text & ", '" & Replace(lblvlrtotal.Text, ",", ".") & "')"


        'cmd2.CommandText = "Select custo " & _
        '                   " FROM TBProdutos" & _
        '                   " Where Cod_Produto = " & FrmVendas.txtcodprod.Text & " "
       
        For i = 0 To cont
            'novaqtd = AtuEstoque(FrmVendas.DataGridVendas.Rows.Item(i).Cells(2).Value)

            FrmVendas.DataGridVendas.Rows.Item(i).Cells(3).Value = Replace(Replace(Replace(FrmVendas.DataGridVendas.Rows.Item(i).Cells(3).Value, ".", ""), "R$", ""), ",", ".")

            con2.Open()

            cmd2.CommandText = "select ( " & FrmVendas.DataGridVendas.Rows.Item(i).Cells(2).Value & " * Custo) as Custo " & _
            "from " & _
            "    (select Prod.Cod_Produto, Prod.Custo " & _
            "    from TBProdutos Prod " & _
            "        left join TBEstrutura Estr " & _
            "        on Estr.Cod_ProdPA = Prod.Cod_Produto  " & _
            "    where Cod_Est is null " & _
            "    Union All " & _
            "    select Prod.Cod_Produto, Sum(Estr.Quantidade * PrdIN.Custo) as Custo " & _
            "    from TBProdutos Prod " & _
            "        inner join TBEstrutura Estr " & _
            "        on Estr.Cod_ProdPA = Prod.Cod_Produto " & _
            "        inner join TBProdutos PrdIN " & _
            "        on Estr.Cod_ProdIN = PrdIN.Cod_Produto " & _
            "    Group by  Prod.Cod_Produto) as CstPrd " & _
            "where Cod_Produto = " & FrmVendas.DataGridVendas.Rows.Item(i).Cells(0).Value

            sqlReader = cmd2.ExecuteReader()

            If sqlReader.Read() Then
                custo = Replace(sqlReader.GetValue(0).ToString, ",", ".")
            Else
                Exit Sub
            End If

            'cmd.EndExecuteReader(sqlReader)

            cmd.CommandText += "INSERT INTO TBItens_Vendas VALUES(" & _
                                           FrmVendas.lblpedido.Text & ", " & _
                                           (i + 1).ToString & ", " & _
                                           FrmVendas.DataGridVendas.Rows.Item(i).Cells(0).Value & ", " & _
                                           FrmVendas.DataGridVendas.Rows.Item(i).Cells(2).Value & ", '" & _
                                           FrmVendas.DataGridVendas.Rows.Item(i).Cells(3).Value & "', " & custo & ") "
            '"UPDATE TBMov_Estoque SET Quantidade=" & novaqtd & " WHERE Cod_Produto=" & FrmVendas.DataGridVendas.Rows.Item(i).Cells(0).Value & ""

            cmd2.Parameters.Clear()

            con3.Open()

            cmd3.CommandText = " select Cod_Produto, Cod_ProdIN, (Quantidade - (" & FrmVendas.DataGridVendas.Rows.Item(i).Cells(2).Value & " * Baixa)) as Atualiza " & _
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
            "where Cod_Produto = " & FrmVendas.DataGridVendas.Rows.Item(i).Cells(0).Value

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

            Try
                cmd.ExecuteNonQuery()
            Catch ex As System.Data.SqlClient.SqlException
                'MsgBox(ex.Message)
            End Try

            con2.Close()
        Next

        con.Close()

        MsgBox("Venda Finalizada!", MsgBoxStyle.Information)
        LimpaVendas()
        FrmVendas.lblpedido.Text = FrmVendas.lblpedido.Text + 1
        Me.Close()

    End Sub
    Sub LimpaVendas()
        FrmVendas.txtcodcli.Clear()
        FrmVendas.txtcodprod.Clear()
        FrmVendas.DataGridVendas.Rows.Clear()
        FrmVendas.txtdesc.Clear()
        FrmVendas.txtnomecli.Clear()
        FrmVendas.txtqtd.Clear()
        FrmVendas.txtvalor.Clear()
        FrmVendas.mskcpf.Clear()
        FrmVendas.lblTotal.Text = "0,00"


    End Sub
    'Function AtuEstoque(qtdvenda As Decimal)
    '    Dim con As New SqlClient.SqlConnection
    '    con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"
    '    Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
    '    Dim sqlReader As SqlDataReader
    '    Dim cont As Integer
    '    Dim qtdest As Decimal
    '    Dim novaqtd As Decimal

    '    cmd.Connection = con

    '    cont = FrmVendas.DataGridVendas.Rows.Count - 2
    '    For i = 0 To cont
    '        cmd.CommandText = "SELECT Quantidade FROM TBMov_Estoque WHERE Cod_Produto = " & FrmVendas.DataGridVendas.Rows.Item(i).Cells(0).Value & ""
    '        con.Open()
    '        sqlReader = cmd.ExecuteReader()
    '        If sqlReader.Read() Then
    '            qtdest = sqlReader.GetValue(0)
    '        End If
    '        novaqtd = qtdest - qtdvenda
    '        con.Close()

    '    Next

    '    Return novaqtd
    'End Function


    Private Sub FrmFinalizarVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtdinheiro.Checked = True
    End Sub

    Private Sub rbtdinheiro_CheckedChanged(sender As Object, e As EventArgs) Handles rbtdinheiro.CheckedChanged
        txtrecebido.ReadOnly = False
    End Sub

    Private Sub rbtdebito_CheckedChanged(sender As Object, e As EventArgs) Handles rbtdebito.CheckedChanged
        lbltroco.Text = "0,00"
        txtrecebido.Clear()
        txtrecebido.ReadOnly = True

    End Sub

    Private Sub rbtcredito_CheckedChanged(sender As Object, e As EventArgs) Handles rbtcredito.CheckedChanged
        lbltroco.Text = "0,00"
        txtrecebido.Clear()
        txtrecebido.ReadOnly = True
    End Sub


    Private Sub pbok_Click(sender As Object, e As EventArgs) Handles pbok.Click
        If txtrecebido.Text = "" Then
            MsgBox("Digite o valor recebido!")
        End If
        lbltroco.Text = Format(txtrecebido.Text - lblvlrtotal.Text, "###,##0.00")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        txtrecebido.Clear()
        lbltroco.Text = "0,00"
        lblvlrtotal.Text = "0,00"

        Me.Close()
    End Sub
End Class