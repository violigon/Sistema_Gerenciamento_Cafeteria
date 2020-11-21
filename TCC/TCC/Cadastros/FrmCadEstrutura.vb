Imports System.Data.SqlClient

Public Class FrmCadEstrutura

    Private Sub FrmCadEstrutura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDMaisCafeDataSetEst.TBEstrutura' table. You can move, or remove it, as needed.
        Me.TBEstruturaTableAdapter.Fill(Me.BDMaisCafeDataSetEst.TBEstrutura)
        ' DataGridEst.Columns(2).Visible = False

    End Sub

    Private Sub pbcad_Click(sender As Object, e As EventArgs) Handles pbcad.Click
        Dim con As SqlConnection
        con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")
        con.Open()


        Dim sqlCommand As SqlCommand = New SqlCommand("SELECT ISNULL(MAX(Cod_Est) +1, 1) AS PROXNUM FROM TBEstrutura", con)
        Dim sqlReader As SqlDataReader

        sqlReader = sqlCommand.ExecuteReader()
        If sqlReader.Read() Then
            txtCodEst.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        con.Close()

        txtnomePA.ReadOnly = False
        txtcodpro.Enabled = True
        txtqtd.Enabled = True

        btnsalvar.Enabled = True
        'txtnomePA.Focus()

        LimpaTela()



    End Sub
    Sub LimpaTela()
        txtcodpro.Clear()
        txtnomeIN.Clear()
        txtqtd.Clear()
        lblunid.Text = "."

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()

    End Sub

 
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pbpesqcep_Click(sender As Object, e As EventArgs)
        FrmPesqProdIN.Show()

    End Sub

    Private Sub pbok_Click(sender As Object, e As EventArgs) Handles pbok.Click
        Dim rowNum As Integer = DataGridEst.Rows.Add()

        DataGridEst.Rows.Item(rowNum).Cells(0).Value = txtcodpro.Text
        DataGridEst.Rows.Item(rowNum).Cells(1).Value = txtnomeIN.Text
        DataGridEst.Rows.Item(rowNum).Cells(2).Value = txtqtd.Text

        txtnomeIN.Clear()
        txtcodpro.Clear()
        txtqtd.Clear()
        lblunid.Text = "."




        'txtnome.Text = CStr(DataGridEst.Item(1, DataGridEst.CurrentRow.Index).Value)
        '  FrmPesqProdIN.DataGridProd.Item(1, FrmPesqProd.DataGridProd.CurrentRow.Index).Value

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        FrmPesqProdPA.Show()

    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Dim con As New SqlClient.SqlConnection

        con.ConnectionString = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"

        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()


        Dim cont As Integer


        cmd.Connection = con


        cont = DataGridEst.Rows.Count - 2

        For i = 0 To cont



            con.Open()

            cmd.CommandText = ""
            cmd.CommandText = "INSERT INTO TBEstrutura VALUES('" & _
                                txtCodEst.Text & "', '" & _
                                txtnomePA.Text & "', '" & _
                                DataGridEst.Rows.Item(i).Cells(0).Value & "', " & _
                                Replace(DataGridEst.Rows.Item(i).Cells(2).Value, ",", ".") & "," & _
                                txtcodPA.Text & ")"



            Try
                cmd.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)

            End Try

            con.Close()


        Next
        
        MsgBox("Estrutura cadastrada com sucesso!", MsgBoxStyle.Information)


       
        LimpaTela()
        txtnomePA.Clear()
        txtcodPA.Clear()
        DataGridEst.Rows.Clear()
        txtCodEst.Clear()

      
    End Sub

 
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmPesqProdPA.Show()

    End Sub

    Private Sub pbpesqcep_Click_1(sender As Object, e As EventArgs) Handles pbpesqcep.Click
        FrmPesqProdIN.Show()
    End Sub
    Private Sub lblunid_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pbconsulta_Click(sender As Object, e As EventArgs) Handles pbconsulta.Click
        DataGridEst.Rows.Clear()
        txtCodEst.Clear()
        txtnomePA.Clear()
        FrmPesqEst.Show()
    End Sub

    Private Sub txtqtd_MouseClick(sender As Object, e As MouseEventArgs)
       
    End Sub


    Private Sub pbexcluirow_Click(sender As Object, e As EventArgs) Handles pbexcluirow.Click
        DataGridEst.Rows.RemoveAt(DataGridEst.CurrentRow.Index)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnlimpar_Click(sender As Object, e As EventArgs) Handles btnlimpar.Click
        LimpaTela()
        txtcodPA.Clear()
        txtnomePA.Clear()
        txtCodEst.Clear()
        DataGridEst.Rows.Clear()
    End Sub

  
    Private Sub txtqtd_Click(sender As Object, e As EventArgs) Handles txtqtd.Click
        Dim con As SqlConnection
        con = New SqlConnection("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")
        con.Open()


        Dim sqlCommand As SqlCommand = New SqlCommand("SELECT Unidade FROM TBProdutos where Cod_Produto=" + txtcodpro.Text + "", con)
        Dim sqlReader As SqlDataReader

        sqlReader = sqlCommand.ExecuteReader()
        If sqlReader.Read() Then
            lblunid.Text = sqlReader.GetString(0)
        End If
        sqlReader.Close()
        con.Close()
    End Sub
End Class