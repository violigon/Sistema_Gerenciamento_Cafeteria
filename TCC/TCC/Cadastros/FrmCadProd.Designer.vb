<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadProd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadProd))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbedit = New System.Windows.Forms.PictureBox()
        Me.PBDelete = New System.Windows.Forms.PictureBox()
        Me.PBPesquisar = New System.Windows.Forms.PictureBox()
        Me.PBCad = New System.Windows.Forms.PictureBox()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtqtd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtpreçovenda = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcusto = New System.Windows.Forms.TextBox()
        Me.rbtnao = New System.Windows.Forms.RadioButton()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbtsim = New System.Windows.Forms.RadioButton()
        Me.cbostatus = New System.Windows.Forms.ComboBox()
        Me.lblcontrole = New System.Windows.Forms.Label()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboUnid = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.lblCod = New System.Windows.Forms.Label()
        CType(Me.pbedit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(472, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 19)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Cadastro de Produtos"
        '
        'pbedit
        '
        Me.pbedit.BackColor = System.Drawing.Color.Transparent
        Me.pbedit.BackgroundImage = CType(resources.GetObject("pbedit.BackgroundImage"), System.Drawing.Image)
        Me.pbedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbedit.Location = New System.Drawing.Point(108, 51)
        Me.pbedit.Name = "pbedit"
        Me.pbedit.Size = New System.Drawing.Size(42, 45)
        Me.pbedit.TabIndex = 92
        Me.pbedit.TabStop = False
        '
        'PBDelete
        '
        Me.PBDelete.BackColor = System.Drawing.Color.Transparent
        Me.PBDelete.BackgroundImage = CType(resources.GetObject("PBDelete.BackgroundImage"), System.Drawing.Image)
        Me.PBDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBDelete.Location = New System.Drawing.Point(147, 51)
        Me.PBDelete.Name = "PBDelete"
        Me.PBDelete.Size = New System.Drawing.Size(42, 45)
        Me.PBDelete.TabIndex = 91
        Me.PBDelete.TabStop = False
        '
        'PBPesquisar
        '
        Me.PBPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.PBPesquisar.BackgroundImage = CType(resources.GetObject("PBPesquisar.BackgroundImage"), System.Drawing.Image)
        Me.PBPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBPesquisar.Location = New System.Drawing.Point(57, 51)
        Me.PBPesquisar.Name = "PBPesquisar"
        Me.PBPesquisar.Size = New System.Drawing.Size(45, 45)
        Me.PBPesquisar.TabIndex = 90
        Me.PBPesquisar.TabStop = False
        '
        'PBCad
        '
        Me.PBCad.BackColor = System.Drawing.Color.Transparent
        Me.PBCad.BackgroundImage = CType(resources.GetObject("PBCad.BackgroundImage"), System.Drawing.Image)
        Me.PBCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBCad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBCad.Location = New System.Drawing.Point(10, 51)
        Me.PBCad.Name = "PBCad"
        Me.PBCad.Size = New System.Drawing.Size(45, 45)
        Me.PBCad.TabIndex = 89
        Me.PBCad.TabStop = False
        '
        'btnsalvar
        '
        Me.btnsalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalvar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnsalvar.ForeColor = System.Drawing.Color.White
        Me.btnsalvar.Location = New System.Drawing.Point(384, 342)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(102, 28)
        Me.btnsalvar.TabIndex = 8
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnAlterar.Enabled = False
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnAlterar.ForeColor = System.Drawing.Color.White
        Me.btnAlterar.Location = New System.Drawing.Point(384, 342)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(102, 28)
        Me.btnAlterar.TabIndex = 105
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = False
        Me.btnAlterar.Visible = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnLimpar.ForeColor = System.Drawing.Color.White
        Me.btnLimpar.Location = New System.Drawing.Point(276, 342)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(102, 28)
        Me.btnLimpar.TabIndex = 9
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtqtd)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtpreçovenda)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtcusto)
        Me.GroupBox1.Controls.Add(Me.rbtnao)
        Me.GroupBox1.Controls.Add(Me.lblstatus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rbtsim)
        Me.GroupBox1.Controls.Add(Me.cbostatus)
        Me.GroupBox1.Controls.Add(Me.lblcontrole)
        Me.GroupBox1.Controls.Add(Me.txtnome)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CboUnid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CboTipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodProd)
        Me.GroupBox1.Controls.Add(Me.lblCod)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(8, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 231)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Produtos"
        '
        'txtqtd
        '
        Me.txtqtd.Enabled = False
        Me.txtqtd.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtqtd.Location = New System.Drawing.Point(112, 198)
        Me.txtqtd.MaxLength = 100
        Me.txtqtd.Name = "txtqtd"
        Me.txtqtd.ReadOnly = True
        Me.txtqtd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtqtd.Size = New System.Drawing.Size(77, 22)
        Me.txtqtd.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(14, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 18)
        Me.Label8.TabIndex = 143
        Me.Label8.Text = "Quantidade: "
        '
        'txtpreçovenda
        '
        Me.txtpreçovenda.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtpreçovenda.Location = New System.Drawing.Point(359, 166)
        Me.txtpreçovenda.MaxLength = 100
        Me.txtpreçovenda.Name = "txtpreçovenda"
        Me.txtpreçovenda.ReadOnly = True
        Me.txtpreçovenda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpreçovenda.Size = New System.Drawing.Size(77, 22)
        Me.txtpreçovenda.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(222, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 18)
        Me.Label7.TabIndex = 141
        Me.Label7.Text = "Preço de Venda: "
        '
        'txtcusto
        '
        Me.txtcusto.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtcusto.Location = New System.Drawing.Point(112, 166)
        Me.txtcusto.MaxLength = 100
        Me.txtcusto.Name = "txtcusto"
        Me.txtcusto.ReadOnly = True
        Me.txtcusto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcusto.Size = New System.Drawing.Size(77, 22)
        Me.txtcusto.TabIndex = 4
        '
        'rbtnao
        '
        Me.rbtnao.AutoSize = True
        Me.rbtnao.BackColor = System.Drawing.Color.Transparent
        Me.rbtnao.Enabled = False
        Me.rbtnao.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbtnao.ForeColor = System.Drawing.Color.White
        Me.rbtnao.Location = New System.Drawing.Point(88, 139)
        Me.rbtnao.Name = "rbtnao"
        Me.rbtnao.Size = New System.Drawing.Size(54, 22)
        Me.rbtnao.TabIndex = 5
        Me.rbtnao.TabStop = True
        Me.rbtnao.Text = "Não"
        Me.rbtnao.UseVisualStyleBackColor = False
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.BackColor = System.Drawing.Color.Transparent
        Me.lblstatus.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.Color.White
        Me.lblstatus.Location = New System.Drawing.Point(261, 202)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(61, 18)
        Me.lblstatus.TabIndex = 137
        Me.lblstatus.Text = "Status: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(13, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Custo: "
        '
        'rbtsim
        '
        Me.rbtsim.AutoSize = True
        Me.rbtsim.BackColor = System.Drawing.Color.Transparent
        Me.rbtsim.Enabled = False
        Me.rbtsim.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbtsim.ForeColor = System.Drawing.Color.White
        Me.rbtsim.Location = New System.Drawing.Point(14, 139)
        Me.rbtsim.Name = "rbtsim"
        Me.rbtsim.Size = New System.Drawing.Size(52, 22)
        Me.rbtsim.TabIndex = 4
        Me.rbtsim.TabStop = True
        Me.rbtsim.Text = "Sim"
        Me.rbtsim.UseVisualStyleBackColor = False
        '
        'cbostatus
        '
        Me.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostatus.Enabled = False
        Me.cbostatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"Ativo", "Inativo"})
        Me.cbostatus.Location = New System.Drawing.Point(325, 198)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.Size = New System.Drawing.Size(111, 24)
        Me.cbostatus.TabIndex = 7
        '
        'lblcontrole
        '
        Me.lblcontrole.AutoSize = True
        Me.lblcontrole.BackColor = System.Drawing.Color.Transparent
        Me.lblcontrole.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblcontrole.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblcontrole.Location = New System.Drawing.Point(11, 118)
        Me.lblcontrole.Name = "lblcontrole"
        Me.lblcontrole.Size = New System.Drawing.Size(166, 18)
        Me.lblcontrole.TabIndex = 128
        Me.lblcontrole.Text = "Controle de Estrutura:"
        '
        'txtnome
        '
        Me.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnome.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtnome.Location = New System.Drawing.Point(112, 49)
        Me.txtnome.MaxLength = 100
        Me.txtnome.Name = "txtnome"
        Me.txtnome.ReadOnly = True
        Me.txtnome.Size = New System.Drawing.Size(324, 22)
        Me.txtnome.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(13, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 18)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "Nome: "
        '
        'CboUnid
        '
        Me.CboUnid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUnid.FormattingEnabled = True
        Me.CboUnid.Items.AddRange(New Object() {"KG", "L", "UNID"})
        Me.CboUnid.Location = New System.Drawing.Point(357, 121)
        Me.CboUnid.Name = "CboUnid"
        Me.CboUnid.Size = New System.Drawing.Size(77, 22)
        Me.CboUnid.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(206, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 18)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Unidade de Medida: "
        '
        'CboTipo
        '
        Me.CboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipo.FormattingEnabled = True
        Me.CboTipo.Items.AddRange(New Object() {"IN", "PA", "UC"})
        Me.CboTipo.Location = New System.Drawing.Point(112, 82)
        Me.CboTipo.Name = "CboTipo"
        Me.CboTipo.Size = New System.Drawing.Size(81, 22)
        Me.CboTipo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(14, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Tipo:"
        '
        'txtCodProd
        '
        Me.txtCodProd.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtCodProd.Location = New System.Drawing.Point(112, 15)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.ReadOnly = True
        Me.txtCodProd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCodProd.Size = New System.Drawing.Size(80, 22)
        Me.txtCodProd.TabIndex = 119
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.BackColor = System.Drawing.Color.Transparent
        Me.lblCod.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblCod.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCod.Location = New System.Drawing.Point(13, 21)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(63, 18)
        Me.lblCod.TabIndex = 117
        Me.lblCod.Text = "Código:"
        '
        'FrmCadProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(497, 418)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.pbedit)
        Me.Controls.Add(Me.PBDelete)
        Me.Controls.Add(Me.PBPesquisar)
        Me.Controls.Add(Me.PBCad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCadProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadProd"
        CType(Me.pbedit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbedit As System.Windows.Forms.PictureBox
    Friend WithEvents PBDelete As System.Windows.Forms.PictureBox
    Friend WithEvents PBPesquisar As System.Windows.Forms.PictureBox
    Friend WithEvents PBCad As System.Windows.Forms.PictureBox
    Friend WithEvents btnsalvar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnao As System.Windows.Forms.RadioButton
    Friend WithEvents rbtsim As System.Windows.Forms.RadioButton
    Friend WithEvents lblcontrole As System.Windows.Forms.Label
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CboUnid As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodProd As System.Windows.Forms.TextBox
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents txtpreçovenda As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcusto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbostatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents txtqtd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
