Imports System.Data.SqlClient

Public Class FrmVendas

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub

    Private Sub FrmVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As SqlConnection
        con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")
        con.Open()
        Dim sqlCommand As SqlCommand = New SqlCommand("SELECT ISNULL(MAX(Cod_Venda) + 1, 1) AS PROXNUM FROM TBVendas", con)
        Dim sqlReader As SqlDataReader

        sqlReader = sqlCommand.ExecuteReader()
        If sqlReader.Read() Then
            lblpedido.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        con.Close()

        mskdata.Text = Format(Today, "dd/MM/yyyy")

        lbluser.Text = FrmPrinc.lblacesso.Text

    End Sub

    Private Sub txtvalor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvalor.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then
            e.Handled = True
        End If

    End Sub
  

    Private Sub pbpesqcli_Click(sender As Object, e As EventArgs) Handles pbpesqcli.Click
        FrmPesqCliVendas.Show()

    End Sub

    Private Sub pbpesqprod_Click(sender As Object, e As EventArgs) Handles pbpesqprod.Click
        FrmPesqProdVendas.Show()
    End Sub

    Private Sub pbok_Click(sender As Object, e As EventArgs) Handles pbok.Click
        Dim rowNum As Integer = DataGridVendas.Rows.Add()
        'Dim cont As Integer

        DataGridVendas.Rows.Item(rowNum).Cells(0).Value = txtcodprod.Text
        DataGridVendas.Rows.Item(rowNum).Cells(1).Value = txtdesc.Text
        DataGridVendas.Rows.Item(rowNum).Cells(2).Value = txtqtd.Text
        DataGridVendas.Rows.Item(rowNum).Cells(3).Value = txtvalor.Text

        DataGridVendas.Rows.Item(rowNum).Cells(4).Value = txtvalor.Text * txtqtd.Text


        lblTotal.Text = AtuTotal()

        txtcodprod.Clear()
        txtdesc.Clear()
        txtqtd.Clear()
        txtvalor.Clear()
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

    Private Sub btnfinalizar_Click(sender As Object, e As EventArgs) Handles btnfinalizar.Click
        FrmFinalizarVenda.Show()

        FrmFinalizarVenda.lblvlrtotal.Text = lblTotal.Text
    End Sub


    Private Sub txtcodcli_Leave(sender As Object, e As EventArgs) Handles txtcodcli.Leave
        If txtcodcli.Text = "" Then
            MsgBox("Digite ou pesquise um código de cliente!")
            txtcodcli.Focus()
        Else
            Dim con As SqlConnection
            con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")
            con.Open()
            Dim sqlCommand As SqlCommand = New SqlCommand("SELECT Nome_Completo, CPF, Cod_Cliente FROM TBClientes WHERE Cod_Cliente=" & txtcodcli.Text & " ", con)
            Dim sqlReader As SqlDataReader

            sqlReader = sqlCommand.ExecuteReader()
            If sqlReader.Read() And sqlReader.GetInt32(2) <> 1 Then
                txtnomecli.Text = sqlReader.GetString(0)
                mskcpf.Text = sqlReader.GetValue(1)
            ElseIf sqlReader.GetInt32(2) = 1 Then
                txtnomecli.Text = sqlReader.GetString(0)
            Else
                MsgBox("Não há cliente com este código!")
                txtcodcli.Focus()

            End If
            sqlReader.Close()
            con.Close()
        End If
    End Sub

    Private Sub txtcodprod_Leave(sender As Object, e As EventArgs) Handles txtcodprod.Leave
        If txtcodprod.Text = "" Then
            MsgBox("Digite ou pesquise um código de produto!")
            txtcodprod.Focus()
        Else
            Dim con As SqlConnection
            con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")
            con.Open()
            Dim sqlCommand As SqlCommand = New SqlCommand("SELECT Nome_Produto, preço_venda FROM TBProdutos WHERE Cod_Produto=" & txtcodprod.Text & " ", con)
            Dim sqlReader As SqlDataReader



            sqlReader = sqlCommand.ExecuteReader()
            If sqlReader.Read() Then
                txtdesc.Text = sqlReader.GetString(0)
                txtvalor.Text = Format(sqlReader.GetValue(1), "###,##0.00")
            Else
                MsgBox("Não há produto com este código!")
                txtcodprod.Focus()
            End If
            sqlReader.Close()
            con.Close()

        End If
    End Sub

    Private Sub pbexcluirow_Click(sender As Object, e As EventArgs) Handles pbexcluirow.Click
        DataGridVendas.Rows.RemoveAt(DataGridVendas.CurrentRow.Index)
        lblTotal.Text = AtuTotal()
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

    Private Sub mskcpf_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskcpf.MaskInputRejected

    End Sub

    Private Sub mskcpf_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskcpf.Validating
        If mskcpf.MaskFull Then
            If isCPF(mskcpf.Text) = False Then
                MsgBox("CPF é inválido!", vbCritical)
                mskcpf.Focus()
            Else
                Exit Sub
            End If
        ElseIf mskcpf.Text = "" Then
            Exit Sub
        Else
            MsgBox("CPF é inválido!", vbCritical)
            mskcpf.Focus()

        End If
    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub
End Class