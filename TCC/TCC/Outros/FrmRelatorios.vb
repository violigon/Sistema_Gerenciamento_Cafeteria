Public Class FrmRelatorios

    Private Sub FrmRelatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReportVenda.Visible = True
        ReportProdutos.Visible = False
        ReportCompras.Visible = False

        Me.RelVendasTableAdapter.Fill(Me.DataSetRelVendas.RelVendas)


        Me.ReportVenda.RefreshReport()


    End Sub

    Private Sub rbtprod_CheckedChanged(sender As Object, e As EventArgs) Handles rbtprod.CheckedChanged
        ReportVenda.Visible = False
        ReportProdutos.Visible = True
        ReportCompras.Visible = False

        Me.RelProdTableAdapter.Fill(Me.DataSetRelProd.RelProd)


        Me.ReportProdutos.RefreshReport()

    End Sub

    Private Sub rbtvendas_CheckedChanged(sender As Object, e As EventArgs) Handles rbtvendas.CheckedChanged

        ReportVenda.Visible = True
        ReportProdutos.Visible = False
        ReportCompras.Visible = False

        Me.RelVendasTableAdapter.Fill(Me.DataSetRelVendas.RelVendas)


        Me.ReportVenda.RefreshReport()


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtcompras.CheckedChanged
        ReportCompras.Visible = True
        ReportProdutos.Visible = False
        ReportVenda.Visible = False

        Me.RelComprasTableAdapter.Fill(Me.DataSetViewRelCompras.RelCompras)

        Me.ReportCompras.RefreshReport()

    End Sub

    Private Sub ReportCompras_Load(sender As Object, e As EventArgs) Handles ReportCompras.Load

    End Sub

    Private Sub ReportVendas_Load(sender As Object, e As EventArgs) Handles ReportVenda.Load

    End Sub
End Class