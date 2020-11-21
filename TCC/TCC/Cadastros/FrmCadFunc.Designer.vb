<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadFunc
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
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.pbedit = New System.Windows.Forms.PictureBox()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.PBDelete = New System.Windows.Forms.PictureBox()
        Me.PBPesquisar = New System.Windows.Forms.PictureBox()
        Me.PBCad = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbostatus = New System.Windows.Forms.ComboBox()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.txtuf = New System.Windows.Forms.TextBox()
        Me.pbpesqcep = New System.Windows.Forms.PictureBox()
        Me.msktelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.mskCEP = New System.Windows.Forms.MaskedTextBox()
        Me.mskCPF = New System.Windows.Forms.MaskedTextBox()
        Me.mskRG = New System.Windows.Forms.MaskedTextBox()
        Me.CBOSexo = New System.Windows.Forms.ComboBox()
        Me.mskDataNasc = New System.Windows.Forms.MaskedTextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCodFunc = New System.Windows.Forms.TextBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFone = New System.Windows.Forms.Label()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.lblRG = New System.Windows.Forms.Label()
        Me.lblDtNasc = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CalendarInicio = New System.Windows.Forms.MonthCalendar()
        CType(Me.pbedit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbpesqcep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.BackColor = System.Drawing.Color.Transparent
        Me.lblSenha.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblSenha.Location = New System.Drawing.Point(474, 295)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(0, 18)
        Me.lblSenha.TabIndex = 77
        '
        'pbedit
        '
        Me.pbedit.BackColor = System.Drawing.Color.Transparent
        Me.pbedit.BackgroundImage = Global.TCC.My.Resources.Resources.editicon2
        Me.pbedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbedit.Location = New System.Drawing.Point(107, 51)
        Me.pbedit.Name = "pbedit"
        Me.pbedit.Size = New System.Drawing.Size(42, 45)
        Me.pbedit.TabIndex = 76
        Me.pbedit.TabStop = False
        '
        'btnsalvar
        '
        Me.btnsalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalvar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnsalvar.ForeColor = System.Drawing.Color.White
        Me.btnsalvar.Location = New System.Drawing.Point(686, 349)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(102, 28)
        Me.btnsalvar.TabIndex = 14
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
        Me.btnAlterar.Location = New System.Drawing.Point(686, 349)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(102, 28)
        Me.btnAlterar.TabIndex = 73
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
        Me.btnLimpar.Location = New System.Drawing.Point(577, 349)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(102, 28)
        Me.btnLimpar.TabIndex = 15
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'PBDelete
        '
        Me.PBDelete.BackColor = System.Drawing.Color.Transparent
        Me.PBDelete.BackgroundImage = Global.TCC.My.Resources.Resources.Delete
        Me.PBDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBDelete.Location = New System.Drawing.Point(155, 51)
        Me.PBDelete.Name = "PBDelete"
        Me.PBDelete.Size = New System.Drawing.Size(42, 45)
        Me.PBDelete.TabIndex = 47
        Me.PBDelete.TabStop = False
        '
        'PBPesquisar
        '
        Me.PBPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.PBPesquisar.BackgroundImage = Global.TCC.My.Resources.Resources.pesquisa
        Me.PBPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBPesquisar.Location = New System.Drawing.Point(59, 51)
        Me.PBPesquisar.Name = "PBPesquisar"
        Me.PBPesquisar.Size = New System.Drawing.Size(42, 45)
        Me.PBPesquisar.TabIndex = 46
        Me.PBPesquisar.TabStop = False
        '
        'PBCad
        '
        Me.PBCad.BackColor = System.Drawing.Color.Transparent
        Me.PBCad.BackgroundImage = Global.TCC.My.Resources.Resources.iconcadastro1
        Me.PBCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBCad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBCad.Location = New System.Drawing.Point(11, 51)
        Me.PBCad.Name = "PBCad"
        Me.PBCad.Size = New System.Drawing.Size(42, 45)
        Me.PBCad.TabIndex = 45
        Me.PBCad.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(777, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 83
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
        Me.Label1.Size = New System.Drawing.Size(204, 19)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Cadastro de Empregados"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(474, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 18)
        Me.Label5.TabIndex = 94
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cbostatus)
        Me.GroupBox1.Controls.Add(Me.lblstatus)
        Me.GroupBox1.Controls.Add(Me.lblNumero)
        Me.GroupBox1.Controls.Add(Me.TxtNum)
        Me.GroupBox1.Controls.Add(Me.txtuf)
        Me.GroupBox1.Controls.Add(Me.pbpesqcep)
        Me.GroupBox1.Controls.Add(Me.msktelefone)
        Me.GroupBox1.Controls.Add(Me.txtCidade)
        Me.GroupBox1.Controls.Add(Me.txtBairro)
        Me.GroupBox1.Controls.Add(Me.txtLog)
        Me.GroupBox1.Controls.Add(Me.mskCEP)
        Me.GroupBox1.Controls.Add(Me.mskCPF)
        Me.GroupBox1.Controls.Add(Me.mskRG)
        Me.GroupBox1.Controls.Add(Me.CBOSexo)
        Me.GroupBox1.Controls.Add(Me.mskDataNasc)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.txtCodFunc)
        Me.GroupBox1.Controls.Add(Me.lblSexo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblFone)
        Me.GroupBox1.Controls.Add(Me.lblCPF)
        Me.GroupBox1.Controls.Add(Me.lblRG)
        Me.GroupBox1.Controls.Add(Me.lblDtNasc)
        Me.GroupBox1.Controls.Add(Me.lblNome)
        Me.GroupBox1.Controls.Add(Me.lblCod)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(11, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(780, 241)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Empregado"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.TCC.My.Resources.Resources.calendar_icon1_300x275
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(448, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 210
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.TCC.My.Resources.Resources.calendar_icon1_300x2751
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(448, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 209
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbostatus
        '
        Me.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostatus.Enabled = False
        Me.cbostatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"Ativo", "Inativo"})
        Me.cbostatus.Location = New System.Drawing.Point(105, 211)
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
        Me.lblstatus.Location = New System.Drawing.Point(4, 217)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(61, 18)
        Me.lblstatus.TabIndex = 159
        Me.lblstatus.Text = "Status: "
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.BackColor = System.Drawing.Color.Transparent
        Me.lblNumero.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblNumero.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNumero.Location = New System.Drawing.Point(580, 151)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(68, 18)
        Me.lblNumero.TabIndex = 116
        Me.lblNumero.Text = "Número:"
        '
        'TxtNum
        '
        Me.TxtNum.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.TxtNum.Location = New System.Drawing.Point(652, 148)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.ReadOnly = True
        Me.TxtNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtNum.Size = New System.Drawing.Size(62, 22)
        Me.TxtNum.TabIndex = 10
        '
        'txtuf
        '
        Me.txtuf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuf.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtuf.Location = New System.Drawing.Point(712, 181)
        Me.txtuf.Name = "txtuf"
        Me.txtuf.ReadOnly = True
        Me.txtuf.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtuf.Size = New System.Drawing.Size(62, 22)
        Me.txtuf.TabIndex = 13
        '
        'pbpesqcep
        '
        Me.pbpesqcep.BackColor = System.Drawing.Color.Transparent
        Me.pbpesqcep.BackgroundImage = Global.TCC.My.Resources.Resources.pesquisamenor
        Me.pbpesqcep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbpesqcep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbpesqcep.Location = New System.Drawing.Point(726, 114)
        Me.pbpesqcep.Name = "pbpesqcep"
        Me.pbpesqcep.Size = New System.Drawing.Size(28, 26)
        Me.pbpesqcep.TabIndex = 113
        Me.pbpesqcep.TabStop = False
        '
        'msktelefone
        '
        Me.msktelefone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msktelefone.Location = New System.Drawing.Point(105, 117)
        Me.msktelefone.Mask = "(00)0000-0000"
        Me.msktelefone.Name = "msktelefone"
        Me.msktelefone.ReadOnly = True
        Me.msktelefone.Size = New System.Drawing.Size(100, 22)
        Me.msktelefone.TabIndex = 6
        Me.msktelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtCidade.Location = New System.Drawing.Point(414, 180)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.ReadOnly = True
        Me.txtCidade.Size = New System.Drawing.Size(254, 22)
        Me.txtCidade.TabIndex = 12
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtBairro.Location = New System.Drawing.Point(105, 180)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.ReadOnly = True
        Me.txtBairro.Size = New System.Drawing.Size(229, 22)
        Me.txtBairro.TabIndex = 11
        '
        'txtLog
        '
        Me.txtLog.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLog.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtLog.Location = New System.Drawing.Point(105, 148)
        Me.txtLog.MaxLength = 150
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.Size = New System.Drawing.Size(452, 22)
        Me.txtLog.TabIndex = 9
        '
        'mskCEP
        '
        Me.mskCEP.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.mskCEP.Location = New System.Drawing.Point(630, 117)
        Me.mskCEP.Mask = "00000-000"
        Me.mskCEP.Name = "mskCEP"
        Me.mskCEP.ReadOnly = True
        Me.mskCEP.Size = New System.Drawing.Size(77, 22)
        Me.mskCEP.TabIndex = 8
        Me.mskCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mskCPF
        '
        Me.mskCPF.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.mskCPF.Location = New System.Drawing.Point(257, 87)
        Me.mskCPF.Mask = "000,000,000-00"
        Me.mskCPF.Name = "mskCPF"
        Me.mskCPF.ReadOnly = True
        Me.mskCPF.Size = New System.Drawing.Size(100, 22)
        Me.mskCPF.TabIndex = 4
        Me.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mskRG
        '
        Me.mskRG.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.mskRG.Location = New System.Drawing.Point(105, 86)
        Me.mskRG.Mask = "00,000,000-0"
        Me.mskRG.Name = "mskRG"
        Me.mskRG.ReadOnly = True
        Me.mskRG.Size = New System.Drawing.Size(88, 22)
        Me.mskRG.TabIndex = 3
        Me.mskRG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'CBOSexo
        '
        Me.CBOSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOSexo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.CBOSexo.FormattingEnabled = True
        Me.CBOSexo.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.CBOSexo.Location = New System.Drawing.Point(436, 86)
        Me.CBOSexo.Name = "CBOSexo"
        Me.CBOSexo.Size = New System.Drawing.Size(121, 24)
        Me.CBOSexo.TabIndex = 5
        '
        'mskDataNasc
        '
        Me.mskDataNasc.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.mskDataNasc.Location = New System.Drawing.Point(370, 118)
        Me.mskDataNasc.Mask = "00/00/0000"
        Me.mskDataNasc.Name = "mskDataNasc"
        Me.mskDataNasc.ReadOnly = True
        Me.mskDataNasc.Size = New System.Drawing.Size(73, 22)
        Me.mskDataNasc.TabIndex = 7
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtNome.Location = New System.Drawing.Point(105, 56)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.ReadOnly = True
        Me.txtNome.Size = New System.Drawing.Size(413, 22)
        Me.txtNome.TabIndex = 2
        '
        'txtCodFunc
        '
        Me.txtCodFunc.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtCodFunc.Location = New System.Drawing.Point(105, 26)
        Me.txtCodFunc.Name = "txtCodFunc"
        Me.txtCodFunc.ReadOnly = True
        Me.txtCodFunc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCodFunc.Size = New System.Drawing.Size(77, 22)
        Me.txtCodFunc.TabIndex = 1
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.BackColor = System.Drawing.Color.Transparent
        Me.lblSexo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblSexo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSexo.Location = New System.Drawing.Point(382, 90)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(48, 18)
        Me.lblSexo.TabIndex = 111
        Me.lblSexo.Text = "Sexo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(675, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 18)
        Me.Label11.TabIndex = 110
        Me.Label11.Text = "UF:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(348, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 18)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Cidade:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(5, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 18)
        Me.Label9.TabIndex = 108
        Me.Label9.Text = "Bairro:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(5, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 18)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Logradouro:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(581, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 18)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "CEP:"
        '
        'lblFone
        '
        Me.lblFone.AutoSize = True
        Me.lblFone.BackColor = System.Drawing.Color.Transparent
        Me.lblFone.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblFone.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFone.Location = New System.Drawing.Point(2, 121)
        Me.lblFone.Name = "lblFone"
        Me.lblFone.Size = New System.Drawing.Size(75, 18)
        Me.lblFone.TabIndex = 105
        Me.lblFone.Text = "Telefone:"
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.BackColor = System.Drawing.Color.Transparent
        Me.lblCPF.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblCPF.ForeColor = System.Drawing.Color.Transparent
        Me.lblCPF.Location = New System.Drawing.Point(209, 91)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(42, 18)
        Me.lblCPF.TabIndex = 104
        Me.lblCPF.Text = "CPF:"
        '
        'lblRG
        '
        Me.lblRG.AutoSize = True
        Me.lblRG.BackColor = System.Drawing.Color.Transparent
        Me.lblRG.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblRG.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRG.Location = New System.Drawing.Point(5, 93)
        Me.lblRG.Name = "lblRG"
        Me.lblRG.Size = New System.Drawing.Size(35, 18)
        Me.lblRG.TabIndex = 103
        Me.lblRG.Text = "RG:"
        '
        'lblDtNasc
        '
        Me.lblDtNasc.AutoSize = True
        Me.lblDtNasc.BackColor = System.Drawing.Color.Transparent
        Me.lblDtNasc.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblDtNasc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDtNasc.Location = New System.Drawing.Point(211, 122)
        Me.lblDtNasc.Name = "lblDtNasc"
        Me.lblDtNasc.Size = New System.Drawing.Size(153, 18)
        Me.lblDtNasc.TabIndex = 102
        Me.lblDtNasc.Text = "Data de Nascimento:"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.BackColor = System.Drawing.Color.Transparent
        Me.lblNome.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNome.Location = New System.Drawing.Point(5, 62)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(53, 18)
        Me.lblNome.TabIndex = 101
        Me.lblNome.Text = "Nome:"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.BackColor = System.Drawing.Color.Transparent
        Me.lblCod.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblCod.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCod.Location = New System.Drawing.Point(5, 29)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(63, 18)
        Me.lblCod.TabIndex = 100
        Me.lblCod.Text = "Código:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CalendarInicio
        '
        Me.CalendarInicio.Location = New System.Drawing.Point(488, 79)
        Me.CalendarInicio.Name = "CalendarInicio"
        Me.CalendarInicio.TabIndex = 211
        Me.CalendarInicio.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CalendarInicio.Visible = False
        '
        'FrmCadFunc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.ClientSize = New System.Drawing.Size(803, 408)
        Me.Controls.Add(Me.CalendarInicio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.pbedit)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.PBDelete)
        Me.Controls.Add(Me.PBPesquisar)
        Me.Controls.Add(Me.PBCad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCadFunc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadFunc"
        CType(Me.pbedit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbpesqcep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents pbedit As System.Windows.Forms.PictureBox
    Friend WithEvents btnsalvar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents PBDelete As System.Windows.Forms.PictureBox
    Friend WithEvents PBPesquisar As System.Windows.Forms.PictureBox
    Friend WithEvents PBCad As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents TxtNum As System.Windows.Forms.TextBox
    Friend WithEvents txtuf As System.Windows.Forms.TextBox
    Friend WithEvents pbpesqcep As System.Windows.Forms.PictureBox
    Friend WithEvents msktelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents mskCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskRG As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CBOSexo As System.Windows.Forms.ComboBox
    Friend WithEvents mskDataNasc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtCodFunc As System.Windows.Forms.TextBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblFone As System.Windows.Forms.Label
    Friend WithEvents lblCPF As System.Windows.Forms.Label
    Friend WithEvents lblRG As System.Windows.Forms.Label
    Friend WithEvents lblDtNasc As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents cbostatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CalendarInicio As System.Windows.Forms.MonthCalendar
End Class
