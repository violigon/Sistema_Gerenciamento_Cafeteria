Public Class FrmPrinc

    Private Sub pbsair_Click(sender As Object, e As EventArgs) Handles pbsair.Click
        End
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmCadCli.ShowDialog()
    End Sub

    Private Sub FuncionárioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmCadFunc.ShowDialog()

    End Sub

    Private Sub FornecedorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmCadFornec.ShowDialog()

    End Sub

    Private Sub ProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmCadProd.ShowDialog()

    End Sub


    Private Sub UsuárioToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        FrmCadUsuario.ShowDialog()
    End Sub
    Private Sub FrmPrinc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False

        lbldata.Text = Today

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        PBCadCliente.Visible = False
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PBMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PBCadastros_MouseHover(sender As Object, e As EventArgs) Handles PBCadastros.MouseHover
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        PBCadastros.BackgroundImage = My.Resources.Mananger_invertido
        TTCadastros.SetToolTip(PBCadastros, "Cadastros")

    End Sub

    Private Sub PbConfig_Click(sender As Object, e As EventArgs) Handles PbConfig.Click

    End Sub

    Private Sub PbConfig_MouseHover(sender As Object, e As EventArgs) Handles PbConfig.MouseHover
        Panel2.Visible = True
        Panel1.Visible = False
        Panel3.Visible = False
        PbConfig.BackgroundImage = My.Resources.wheel_iconCOMBRILHO

    End Sub

    Private Sub FrmPrinc_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub PBCadastros_MouseLeave(sender As Object, e As EventArgs) Handles PBCadastros.MouseLeave
        PBCadastros.BackgroundImage = My.Resources.Manager_Suit_Black_Tie_icon
    End Sub

    Private Sub PBCadCliente_DoubleClick(sender As Object, e As EventArgs) Handles PBCadCliente.DoubleClick
        Panel1.Visible = False
        lblcadcliente.Visible = False
        FrmCadCli.ShowDialog()
    End Sub

    Private Sub PBCadCliente_MouseHover(sender As Object, e As EventArgs) Handles PBCadCliente.MouseHover
        PBCadCliente.BackgroundImage = My.Resources.clientescombrilho
        lblcadcliente.Visible = True
    End Sub

    Private Sub PBCadCliente_MouseLeave(sender As Object, e As EventArgs) Handles PBCadCliente.MouseLeave
        PBCadCliente.BackgroundImage = My.Resources.clientes
        lblcadcliente.Visible = False
    End Sub

    Private Sub PBCadUser_DoubleClick(sender As Object, e As EventArgs) Handles PBCadUser.DoubleClick
        Panel1.Visible = False
        lblcadusuarios.Visible = False
        FrmCadUsuario.ShowDialog()
    End Sub

    Private Sub PBCadUser_MouseHover(sender As Object, e As EventArgs) Handles PBCadUser.MouseHover
        PBCadUser.BackgroundImage = My.Resources.Office_Customer_Male_Light_iconcombrilho
        lblcadusuarios.Visible = True
    End Sub

    Private Sub PBCadUser_MouseLeave(sender As Object, e As EventArgs) Handles PBCadUser.MouseLeave
        PBCadUser.BackgroundImage = My.Resources.OfficeCustomerMaleLighticon
        lblcadusuarios.Visible = False
    End Sub

    Private Sub PBCadFornecedor_DoubleClick(sender As Object, e As EventArgs) Handles PBCadFornecedor.DoubleClick
        Panel1.Visible = False
        lblcadfornecedores.Visible = False
        FrmCadFornec.ShowDialog()
    End Sub

    Private Sub PBCadFornecedor_MouseHover(sender As Object, e As EventArgs) Handles PBCadFornecedor.MouseHover
        PBCadFornecedor.BackgroundImage = My.Resources.truck_iconcombrilho
        lblcadfornecedores.Visible = True
    End Sub

    Private Sub PBCadFornecedor_MouseLeave(sender As Object, e As EventArgs) Handles PBCadFornecedor.MouseLeave
        PBCadFornecedor.BackgroundImage = My.Resources.truckicon
        lblcadfornecedores.Visible = False
    End Sub


    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmCadUsuario.ShowDialog()

    End Sub

    Private Sub PBLogout_Click(sender As Object, e As EventArgs) Handles PBLogout.Click
        Dim MENSAGEM As MsgBoxResult
        MENSAGEM = MsgBox("Deseja mesmo fazer Logout?", MessageBoxButtons.YesNo, "Atenção!")

        If MENSAGEM = MsgBoxResult.Yes Then
            Me.Close()
            Login.Show()
            Login.txtLogin.Text = ""
            Login.txtSenha.Text = ""
            Login.txtLogin.Focus()

        Else

        End If

        FrmVendas.Dispose()

    End Sub

    Private Sub PBLogout_MouseHover(sender As Object, e As EventArgs) Handles PBLogout.MouseHover
        PBLogout.BackgroundImage = My.Resources.Logout_com_brilho
        TTlogout.SetToolTip(PBLogout, "Logout")

    End Sub

    Private Sub PBLogout_MouseLeave(sender As Object, e As EventArgs) Handles PBLogout.MouseLeave
        PBLogout.BackgroundImage = My.Resources.Logout
    End Sub

    Private Sub PbConfig_MouseLeave(sender As Object, e As EventArgs) Handles PbConfig.MouseLeave
        PbConfig.BackgroundImage = My.Resources.wheel_icon

    End Sub
    Private Sub PBCadeado_MouseHover(sender As Object, e As EventArgs) Handles PBCadeado.MouseHover
        Panel3.Visible = True
        Panel1.Visible = False
        Panel2.Visible = False
        PBCadeado.BackgroundImage = My.Resources.Lock_iconcombrilho

    End Sub

    Private Sub PBBackup_MouseLeave(sender As Object, e As EventArgs) Handles PBCadeado.MouseLeave
        Pbbackup.BackgroundImage = My.Resources.Blue_Backup_W_icon
        lblbackup.Visible = False

    End Sub

    Private Sub PBCaixa_Click(sender As Object, e As EventArgs) Handles PBCaixa.Click

    End Sub

    Private Sub PBCaixa_DoubleClick(sender As Object, e As EventArgs) Handles PBCaixa.DoubleClick
        FrmVendas.Show()
    End Sub

    Private Sub PBCaixa_MouseHover(sender As Object, e As EventArgs) Handles PBCaixa.MouseHover
        PBCaixa.BackgroundImage = My.Resources.cash_resgistercombrilho
        TTVendas.SetToolTip(PBCaixa, "Vendas")

    End Sub

    Private Sub PBCaixa_MouseLeave(sender As Object, e As EventArgs) Handles PBCaixa.MouseLeave
        PBCaixa.BackgroundImage = My.Resources.cash_resgister
    End Sub


    Private Sub TimerPrinc_Tick(sender As Object, e As EventArgs) Handles TimerPrinc.Tick
        lblhora.Text = TimeString
    End Sub

    Private Sub PBCadProduto_DoubleClick(sender As Object, e As EventArgs) Handles PBCadProduto.DoubleClick
        Panel1.Visible = False
        lblcadprodutos.Visible = False
        FrmCadProd.ShowDialog()
    End Sub



    Private Sub PBCadProduto_MouseHover(sender As Object, e As EventArgs) Handles PBCadProduto.MouseHover
        PBCadProduto.BackgroundImage = My.Resources.cadProdutocombrilho
        lblcadprodutos.Visible = True
    End Sub


    Private Sub PBCadProduto_MouseLeave(sender As Object, e As EventArgs) Handles PBCadProduto.MouseLeave
        PBCadProduto.BackgroundImage = My.Resources.cadProduto
        lblcadprodutos.Visible = False
    End Sub

    Private Sub pbEstrutura_DoubleClick(sender As Object, e As EventArgs) Handles pbEstrutura.DoubleClick
        Panel1.Visible = False
        FrmCadEstrutura.Show()

    End Sub

    Private Sub pbEstrutura_MouseHover(sender As Object, e As EventArgs) Handles pbEstrutura.MouseHover
        pbEstrutura.BackgroundImage = My.Resources.cup_coffee_icon_com_brilho
        lblcadest.Visible = True

    End Sub

    Private Sub pbEstrutura_MouseLeave(sender As Object, e As EventArgs) Handles pbEstrutura.MouseLeave
        pbEstrutura.BackgroundImage = My.Resources.cup_coffee_icon
        lblcadest.Visible = False
    End Sub

    Private Sub PBCadFuncionario_DoubleClick(sender As Object, e As EventArgs) Handles PBCadFuncionario.DoubleClick
        Panel1.Visible = False
        LblCadFuncionários.Visible = False
        FrmCadFunc.ShowDialog()
    End Sub

    Private Sub PBCadFuncionario_MouseHover(sender As Object, e As EventArgs) Handles PBCadFuncionario.MouseHover
        PBCadFuncionario.BackgroundImage = My.Resources.funcionariocombrilho
        LblCadFuncionários.Visible = True
    End Sub

    Private Sub PBCadFuncionario_MouseLeave1(sender As Object, e As EventArgs) Handles PBCadFuncionario.MouseLeave
        PBCadFuncionario.BackgroundImage = My.Resources.funcionario
        LblCadFuncionários.Visible = False
    End Sub

    Private Sub PBCompras_DoubleClick(sender As Object, e As EventArgs) Handles PBCompras.DoubleClick
        Panel2.Visible = False
        FrmCadCompras.Show()

    End Sub


    Private Sub PBCompras_MouseHover(sender As Object, e As EventArgs) Handles PBCompras.MouseHover
        PBCompras.BackgroundImage = My.Resources.full_basket_icon_com_brilhop
        lblcompras.Visible = True

    End Sub

    Private Sub PBCompras_MouseLeave(sender As Object, e As EventArgs) Handles PBCompras.MouseLeave
        PBCompras.BackgroundImage = My.Resources.full_basket_icon
        lblcompras.Visible = False
    End Sub

    Private Sub PbContas_pagar_DoubleClick(sender As Object, e As EventArgs) Handles PbContas_pagar.DoubleClick
        Panel2.Visible = False
        FrmCadContas.Show()
    End Sub

    Private Sub PbContas_pagar_MouseHover(sender As Object, e As EventArgs) Handles PbContas_pagar.MouseHover
        PbContas_pagar.BackgroundImage = My.Resources.price_list_money_com_brilho
        lblcontas.Visible = True
    End Sub

    Private Sub PbContas_pagar_MouseLeave(sender As Object, e As EventArgs) Handles PbContas_pagar.MouseLeave
        PbContas_pagar.BackgroundImage = My.Resources.price_list_money_256
        lblcontas.Visible = False
    End Sub

    Private Sub Pbbackup_DoubleClick(sender As Object, e As EventArgs) Handles Pbbackup.DoubleClick

        Panel3.Visible = False
        FrmBackupRestore.Show()
    End Sub


    Private Sub Pbbackup_MouseHover(sender As Object, e As EventArgs) Handles Pbbackup.MouseHover
        Pbbackup.BackgroundImage = My.Resources.Blue_Backup_W_icon_com_brilho
        lblbackup.Visible = True
    End Sub

  
    Private Sub PBPesqVendas_DoubleClick(sender As Object, e As EventArgs) Handles PBPesqVendas.DoubleClick
        Panel2.Visible = False
        FrmPesqVendas.Show()
    End Sub

    Private Sub PBPesqVendas_MouseHover(sender As Object, e As EventArgs) Handles PBPesqVendas.MouseHover
        PBPesqVendas.BackgroundImage = My.Resources.Search1_com_brilho_fw
        lblpesqVendas.Visible = True
    End Sub

    Private Sub PBPesqVendas_MouseLeave(sender As Object, e As EventArgs) Handles PBPesqVendas.MouseLeave
        PBPesqVendas.BackgroundImage = My.Resources.Search1_fw
        lblpesqVendas.Visible = False
    End Sub

    Private Sub PBRelatorios_DoubleClick(sender As Object, e As EventArgs) Handles PBRelatorios.DoubleClick
        Panel3.Visible = False
        FrmRelatorios.Show()
    End Sub


    Private Sub PBRelatorios_MouseHover(sender As Object, e As EventArgs) Handles PBRelatorios.MouseHover
        PBRelatorios.BackgroundImage = My.Resources.qdc_exec_jobs_com_brilho
        lblrelatórios.Visible = True
    End Sub

    Private Sub Pbbackup_MouseLeave1(sender As Object, e As EventArgs) Handles Pbbackup.MouseLeave
        PBRelatorios.BackgroundImage = My.Resources.qdc_exec_jobs
        lblbackup.Visible = False
    End Sub

    Private Sub PBMensagem_DoubleClick(sender As Object, e As EventArgs) Handles PBMensagem.DoubleClick
        Panel3.Visible = False
        FrmPesqMensagemWEBSITE.Show()

    End Sub

    Private Sub PBMensagem_MouseHover(sender As Object, e As EventArgs) Handles PBMensagem.MouseHover
        PBMensagem.BackgroundImage = My.Resources.new_message_icon_com_brilho
        lblmensagem.Visible = True
    End Sub

    Private Sub PBMensagem_MouseLeave(sender As Object, e As EventArgs) Handles PBMensagem.MouseLeave
        PBMensagem.BackgroundImage = My.Resources.new_message_icon
        lblmensagem.Visible = False
    End Sub


    Private Sub PBRelatorios_MouseLeave(sender As Object, e As EventArgs) Handles PBRelatorios.MouseLeave
        PBRelatorios.BackgroundImage = My.Resources.qdc_exec_jobs
        lblrelatórios.Visible = False
    End Sub


 

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave

        Panel2.Visible = False
        Panel3.Visible = False
    End Sub



   

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Panel1.Visible = False

        Panel3.Visible = False
    End Sub

  

  

  



    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave
        Panel1.Visible = False
        Panel2.Visible = False

    End Sub

  
 

  
   
End Class