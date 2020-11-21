<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadFornec
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
        Me.components = New System.ComponentModel.Container()
        Me.pbdelete = New System.Windows.Forms.PictureBox()
        Me.pbedit = New System.Windows.Forms.PictureBox()
        Me.pbconsulta = New System.Windows.Forms.PictureBox()
        Me.pbcad = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.cbostatus = New System.Windows.Forms.ComboBox()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.mskcnpj = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtsite = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtuf = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pbpesqcep = New System.Windows.Forms.PictureBox()
        Me.msktelefone = New System.Windows.Forms.MaskedTextBox()
        Me.mskCEP = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFone = New System.Windows.Forms.Label()
        Me.txtrazsoc = New System.Windows.Forms.TextBox()
        Me.txtNomeFan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodfornec = New System.Windows.Forms.TextBox()
        Me.lblcodcli = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.pbdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbedit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbconsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbpesqcep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbdelete
        '
        Me.pbdelete.BackColor = System.Drawing.Color.Transparent
        Me.pbdelete.BackgroundImage = Global.TCC.My.Resources.Resources.Delete
        Me.pbdelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbdelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbdelete.Location = New System.Drawing.Point(167, 42)
        Me.pbdelete.Name = "pbdelete"
        Me.pbdelete.Size = New System.Drawing.Size(42, 45)
        Me.pbdelete.TabIndex = 29
        Me.pbdelete.TabStop = False
        '
        'pbedit
        '
        Me.pbedit.BackColor = System.Drawing.Color.Transparent
        Me.pbedit.BackgroundImage = Global.TCC.My.Resources.Resources.editicon2
        Me.pbedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbedit.Location = New System.Drawing.Point(119, 42)
        Me.pbedit.Name = "pbedit"
        Me.pbedit.Size = New System.Drawing.Size(42, 45)
        Me.pbedit.TabIndex = 28
        Me.pbedit.TabStop = False
        '
        'pbconsulta
        '
        Me.pbconsulta.BackColor = System.Drawing.Color.Transparent
        Me.pbconsulta.BackgroundImage = Global.TCC.My.Resources.Resources.pesquisa
        Me.pbconsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbconsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbconsulta.Location = New System.Drawing.Point(67, 42)
        Me.pbconsulta.Name = "pbconsulta"
        Me.pbconsulta.Size = New System.Drawing.Size(42, 45)
        Me.pbconsulta.TabIndex = 27
        Me.pbconsulta.TabStop = False
        '
        'pbcad
        '
        Me.pbcad.BackColor = System.Drawing.Color.Transparent
        Me.pbcad.BackgroundImage = Global.TCC.My.Resources.Resources.iconcadastro1
        Me.pbcad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbcad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbcad.Location = New System.Drawing.Point(16, 42)
        Me.pbcad.Name = "pbcad"
        Me.pbcad.Size = New System.Drawing.Size(42, 45)
        Me.pbcad.TabIndex = 24
        Me.pbcad.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 19)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Cadastro de Fornecedores"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(689, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "X"
        '
        'btnsalvar
        '
        Me.btnsalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalvar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnsalvar.ForeColor = System.Drawing.Color.White
        Me.btnsalvar.Location = New System.Drawing.Point(602, 365)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(102, 28)
        Me.btnsalvar.TabIndex = 14
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnAlterar.ForeColor = System.Drawing.Color.White
        Me.btnAlterar.Location = New System.Drawing.Point(602, 365)
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
        Me.btnLimpar.Location = New System.Drawing.Point(494, 365)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(102, 28)
        Me.btnLimpar.TabIndex = 15
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblNumero)
        Me.GroupBox1.Controls.Add(Me.TxtNum)
        Me.GroupBox1.Controls.Add(Me.cbostatus)
        Me.GroupBox1.Controls.Add(Me.lblstatus)
        Me.GroupBox1.Controls.Add(Me.mskcnpj)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtsite)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtuf)
        Me.GroupBox1.Controls.Add(Me.txtCidade)
        Me.GroupBox1.Controls.Add(Me.txtBairro)
        Me.GroupBox1.Controls.Add(Me.txtLog)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.pbpesqcep)
        Me.GroupBox1.Controls.Add(Me.msktelefone)
        Me.GroupBox1.Controls.Add(Me.mskCEP)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblFone)
        Me.GroupBox1.Controls.Add(Me.txtrazsoc)
        Me.GroupBox1.Controls.Add(Me.txtNomeFan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcodfornec)
        Me.GroupBox1.Controls.Add(Me.lblcodcli)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(16, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 273)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Fornecedor"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.BackColor = System.Drawing.Color.Transparent
        Me.lblNumero.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblNumero.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNumero.Location = New System.Drawing.Point(587, 147)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(24, 18)
        Me.lblNumero.TabIndex = 160
        Me.lblNumero.Text = "Nº"
        '
        'TxtNum
        '
        Me.TxtNum.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.TxtNum.Location = New System.Drawing.Point(620, 143)
        Me.TxtNum.MaxLength = 4
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.ReadOnly = True
        Me.TxtNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtNum.Size = New System.Drawing.Size(62, 22)
        Me.TxtNum.TabIndex = 8
        '
        'cbostatus
        '
        Me.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostatus.Enabled = False
        Me.cbostatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"Ativo", "Inativo"})
        Me.cbostatus.Location = New System.Drawing.Point(509, 206)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.Size = New System.Drawing.Size(111, 24)
        Me.cbostatus.TabIndex = 13
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.BackColor = System.Drawing.Color.Transparent
        Me.lblstatus.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.Color.White
        Me.lblstatus.Location = New System.Drawing.Point(449, 212)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(61, 18)
        Me.lblstatus.TabIndex = 157
        Me.lblstatus.Text = "Status: "
        '
        'mskcnpj
        '
        Me.mskcnpj.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.mskcnpj.Location = New System.Drawing.Point(284, 14)
        Me.mskcnpj.Mask = "00,000,000/0000-00"
        Me.mskcnpj.Name = "mskcnpj"
        Me.mskcnpj.ReadOnly = True
        Me.mskcnpj.Size = New System.Drawing.Size(124, 22)
        Me.mskcnpj.TabIndex = 2
        Me.mskcnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(226, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 18)
        Me.Label12.TabIndex = 156
        Me.Label12.Text = "CNPJ:"
        '
        'txtsite
        '
        Me.txtsite.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsite.Location = New System.Drawing.Point(121, 239)
        Me.txtsite.MaxLength = 50
        Me.txtsite.Name = "txtsite"
        Me.txtsite.ReadOnly = True
        Me.txtsite.Size = New System.Drawing.Size(318, 22)
        Me.txtsite.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "Site: "
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(121, 207)
        Me.txtemail.MaxLength = 50
        Me.txtemail.Name = "txtemail"
        Me.txtemail.ReadOnly = True
        Me.txtemail.Size = New System.Drawing.Size(318, 22)
        Me.txtemail.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 18)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "E-mail: "
        '
        'txtuf
        '
        Me.txtuf.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtuf.Location = New System.Drawing.Point(620, 176)
        Me.txtuf.MaxLength = 2
        Me.txtuf.Name = "txtuf"
        Me.txtuf.ReadOnly = True
        Me.txtuf.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtuf.Size = New System.Drawing.Size(62, 22)
        Me.txtuf.TabIndex = 11
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtCidade.Location = New System.Drawing.Point(416, 176)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.ReadOnly = True
        Me.txtCidade.Size = New System.Drawing.Size(160, 22)
        Me.txtCidade.TabIndex = 10
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtBairro.Location = New System.Drawing.Point(121, 175)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.ReadOnly = True
        Me.txtBairro.Size = New System.Drawing.Size(229, 22)
        Me.txtBairro.TabIndex = 9
        '
        'txtLog
        '
        Me.txtLog.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLog.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtLog.Location = New System.Drawing.Point(121, 143)
        Me.txtLog.MaxLength = 150
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.Size = New System.Drawing.Size(452, 22)
        Me.txtLog.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(586, 179)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 18)
        Me.Label11.TabIndex = 152
        Me.Label11.Text = "UF:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(356, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 18)
        Me.Label10.TabIndex = 151
        Me.Label10.Text = "Cidade:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(7, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 18)
        Me.Label9.TabIndex = 150
        Me.Label9.Text = "Bairro:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(7, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 18)
        Me.Label8.TabIndex = 149
        Me.Label8.Text = "Logradouro:"
        '
        'pbpesqcep
        '
        Me.pbpesqcep.BackColor = System.Drawing.Color.Transparent
        Me.pbpesqcep.BackgroundImage = Global.TCC.My.Resources.Resources.pesquisamenor
        Me.pbpesqcep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbpesqcep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbpesqcep.Location = New System.Drawing.Point(376, 107)
        Me.pbpesqcep.Name = "pbpesqcep"
        Me.pbpesqcep.Size = New System.Drawing.Size(28, 26)
        Me.pbpesqcep.TabIndex = 145
        Me.pbpesqcep.TabStop = False
        '
        'msktelefone
        '
        Me.msktelefone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msktelefone.Location = New System.Drawing.Point(121, 110)
        Me.msktelefone.Mask = "(00)0000-0000"
        Me.msktelefone.Name = "msktelefone"
        Me.msktelefone.ReadOnly = True
        Me.msktelefone.Size = New System.Drawing.Size(100, 22)
        Me.msktelefone.TabIndex = 5
        Me.msktelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mskCEP
        '
        Me.mskCEP.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.mskCEP.Location = New System.Drawing.Point(293, 111)
        Me.mskCEP.Mask = "00000-000"
        Me.mskCEP.Name = "mskCEP"
        Me.mskCEP.ReadOnly = True
        Me.mskCEP.Size = New System.Drawing.Size(77, 22)
        Me.mskCEP.TabIndex = 6
        Me.mskCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(244, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 18)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "CEP:"
        '
        'lblFone
        '
        Me.lblFone.AutoSize = True
        Me.lblFone.BackColor = System.Drawing.Color.Transparent
        Me.lblFone.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblFone.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFone.Location = New System.Drawing.Point(7, 116)
        Me.lblFone.Name = "lblFone"
        Me.lblFone.Size = New System.Drawing.Size(75, 18)
        Me.lblFone.TabIndex = 143
        Me.lblFone.Text = "Telefone:"
        '
        'txtrazsoc
        '
        Me.txtrazsoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrazsoc.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtrazsoc.Location = New System.Drawing.Point(121, 78)
        Me.txtrazsoc.MaxLength = 60
        Me.txtrazsoc.Name = "txtrazsoc"
        Me.txtrazsoc.ReadOnly = True
        Me.txtrazsoc.Size = New System.Drawing.Size(452, 22)
        Me.txtrazsoc.TabIndex = 4
        '
        'txtNomeFan
        '
        Me.txtNomeFan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeFan.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtNomeFan.Location = New System.Drawing.Point(121, 46)
        Me.txtNomeFan.MaxLength = 40
        Me.txtNomeFan.Name = "txtNomeFan"
        Me.txtNomeFan.ReadOnly = True
        Me.txtNomeFan.Size = New System.Drawing.Size(452, 22)
        Me.txtNomeFan.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 18)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Razão Social:  "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Nome Fantasia: "
        '
        'txtcodfornec
        '
        Me.txtcodfornec.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodfornec.Location = New System.Drawing.Point(121, 14)
        Me.txtcodfornec.Name = "txtcodfornec"
        Me.txtcodfornec.ReadOnly = True
        Me.txtcodfornec.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcodfornec.Size = New System.Drawing.Size(84, 22)
        Me.txtcodfornec.TabIndex = 1
        '
        'lblcodcli
        '
        Me.lblcodcli.AutoSize = True
        Me.lblcodcli.BackColor = System.Drawing.Color.Transparent
        Me.lblcodcli.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodcli.ForeColor = System.Drawing.Color.White
        Me.lblcodcli.Location = New System.Drawing.Point(7, 18)
        Me.lblcodcli.Name = "lblcodcli"
        Me.lblcodcli.Size = New System.Drawing.Size(67, 18)
        Me.lblcodcli.TabIndex = 139
        Me.lblcodcli.Text = "Código: "
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmCadFornec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(716, 440)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pbdelete)
        Me.Controls.Add(Me.pbedit)
        Me.Controls.Add(Me.pbconsulta)
        Me.Controls.Add(Me.pbcad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCadFornec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadFornec"
        CType(Me.pbdelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbedit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbconsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbpesqcep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents pbdelete As System.Windows.Forms.PictureBox
    Friend WithEvents pbedit As System.Windows.Forms.PictureBox
    Friend WithEvents pbconsulta As System.Windows.Forms.PictureBox
    Friend WithEvents pbcad As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnsalvar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mskcnpj As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtsite As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtuf As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pbpesqcep As System.Windows.Forms.PictureBox
    Friend WithEvents msktelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblFone As System.Windows.Forms.Label
    Friend WithEvents txtrazsoc As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeFan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodfornec As System.Windows.Forms.TextBox
    Friend WithEvents lblcodcli As System.Windows.Forms.Label
    Friend WithEvents cbostatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents TxtNum As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
