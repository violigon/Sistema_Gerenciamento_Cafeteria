<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadCompras
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pbexcluirow = New System.Windows.Forms.PictureBox()
        Me.pbok = New System.Windows.Forms.PictureBox()
        Me.pbpesqprod = New System.Windows.Forms.PictureBox()
        Me.lblunid = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtqtd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcodpro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.mskpgto = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtnomefornec = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pbpesqfornec = New System.Windows.Forms.PictureBox()
        Me.mskinclusao = New System.Windows.Forms.MaskedTextBox()
        Me.mskemissao = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodfornec = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodcompra = New System.Windows.Forms.TextBox()
        Me.lblcodcli = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pbdelete = New System.Windows.Forms.PictureBox()
        Me.pbconsulta = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbcad = New System.Windows.Forms.PictureBox()
        Me.DataGridCompras = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalendarEmissao = New System.Windows.Forms.MonthCalendar()
        Me.CalendarInclusao = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblquant = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbexcluirow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbpesqprod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbpesqfornec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbconsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsalvar
        '
        Me.btnsalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalvar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnsalvar.ForeColor = System.Drawing.Color.White
        Me.btnsalvar.Location = New System.Drawing.Point(514, 458)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(102, 28)
        Me.btnsalvar.TabIndex = 9
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnLimpar.ForeColor = System.Drawing.Color.White
        Me.btnLimpar.Location = New System.Drawing.Point(404, 458)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(102, 28)
        Me.btnLimpar.TabIndex = 10
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblquant)
        Me.GroupBox2.Controls.Add(Me.pbexcluirow)
        Me.GroupBox2.Controls.Add(Me.pbok)
        Me.GroupBox2.Controls.Add(Me.pbpesqprod)
        Me.GroupBox2.Controls.Add(Me.lblunid)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtvalor)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtqtd)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtcodpro)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(16, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 87)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados Itens"
        '
        'pbexcluirow
        '
        Me.pbexcluirow.BackColor = System.Drawing.Color.Transparent
        Me.pbexcluirow.BackgroundImage = Global.TCC.My.Resources.Resources._stop
        Me.pbexcluirow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbexcluirow.Location = New System.Drawing.Point(537, 57)
        Me.pbexcluirow.Name = "pbexcluirow"
        Me.pbexcluirow.Size = New System.Drawing.Size(25, 24)
        Me.pbexcluirow.TabIndex = 155
        Me.pbexcluirow.TabStop = False
        '
        'pbok
        '
        Me.pbok.BackColor = System.Drawing.Color.Transparent
        Me.pbok.BackgroundImage = Global.TCC.My.Resources.Resources.Ok3D
        Me.pbok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbok.Location = New System.Drawing.Point(568, 57)
        Me.pbok.Name = "pbok"
        Me.pbok.Size = New System.Drawing.Size(25, 24)
        Me.pbok.TabIndex = 154
        Me.pbok.TabStop = False
        '
        'pbpesqprod
        '
        Me.pbpesqprod.BackColor = System.Drawing.Color.Transparent
        Me.pbpesqprod.BackgroundImage = Global.TCC.My.Resources.Resources.pesquisamenor
        Me.pbpesqprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbpesqprod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbpesqprod.Location = New System.Drawing.Point(107, 38)
        Me.pbpesqprod.Name = "pbpesqprod"
        Me.pbpesqprod.Size = New System.Drawing.Size(28, 26)
        Me.pbpesqprod.TabIndex = 130
        Me.pbpesqprod.TabStop = False
        '
        'lblunid
        '
        Me.lblunid.AutoSize = True
        Me.lblunid.BackColor = System.Drawing.Color.Transparent
        Me.lblunid.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunid.ForeColor = System.Drawing.Color.White
        Me.lblunid.Location = New System.Drawing.Point(247, 40)
        Me.lblunid.Name = "lblunid"
        Me.lblunid.Size = New System.Drawing.Size(0, 18)
        Me.lblunid.TabIndex = 129
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(247, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 18)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "Unid. Medida "
        '
        'txtvalor
        '
        Me.txtvalor.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtvalor.Location = New System.Drawing.Point(363, 36)
        Me.txtvalor.MaxLength = 100
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtvalor.Size = New System.Drawing.Size(81, 22)
        Me.txtvalor.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(360, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 18)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Valor: "
        '
        'txtqtd
        '
        Me.txtqtd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqtd.Location = New System.Drawing.Point(141, 38)
        Me.txtqtd.Name = "txtqtd"
        Me.txtqtd.ReadOnly = True
        Me.txtqtd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtqtd.Size = New System.Drawing.Size(100, 22)
        Me.txtqtd.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(138, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 18)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Quantidade: "
        '
        'txtcodpro
        '
        Me.txtcodpro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodpro.Location = New System.Drawing.Point(7, 38)
        Me.txtcodpro.Name = "txtcodpro"
        Me.txtcodpro.ReadOnly = True
        Me.txtcodpro.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcodpro.Size = New System.Drawing.Size(100, 22)
        Me.txtcodpro.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 18)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Código Produto: "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.mskpgto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtnomefornec)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.pbpesqfornec)
        Me.GroupBox1.Controls.Add(Me.mskinclusao)
        Me.GroupBox1.Controls.Add(Me.mskemissao)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcodfornec)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcodcompra)
        Me.GroupBox1.Controls.Add(Me.lblcodcli)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(16, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 104)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Compra"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.TCC.My.Resources.Resources.calendar_icon1_300x275
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(236, 76)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 22)
        Me.Button4.TabIndex = 181
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.TCC.My.Resources.Resources.calendar_icon1_300x275
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(236, 76)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 22)
        Me.Button3.TabIndex = 180
        Me.Button3.UseVisualStyleBackColor = False
        '
        'mskpgto
        '
        Me.mskpgto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskpgto.Location = New System.Drawing.Point(153, 76)
        Me.mskpgto.Mask = "00/00/0000"
        Me.mskpgto.Name = "mskpgto"
        Me.mskpgto.ReadOnly = True
        Me.mskpgto.Size = New System.Drawing.Size(77, 22)
        Me.mskpgto.TabIndex = 5
        Me.mskpgto.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 18)
        Me.Label3.TabIndex = 178
        Me.Label3.Text = "Data de Pagamento: "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.TCC.My.Resources.Resources.calendar_icon1_300x275
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(237, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 22)
        Me.Button2.TabIndex = 175
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
        Me.Button1.Location = New System.Drawing.Point(237, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 22)
        Me.Button1.TabIndex = 174
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtnomefornec
        '
        Me.txtnomefornec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomefornec.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomefornec.Location = New System.Drawing.Point(434, 46)
        Me.txtnomefornec.Name = "txtnomefornec"
        Me.txtnomefornec.ReadOnly = True
        Me.txtnomefornec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtnomefornec.Size = New System.Drawing.Size(157, 22)
        Me.txtnomefornec.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(295, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 18)
        Me.Label12.TabIndex = 115
        Me.Label12.Text = "Nome Fornecedor: "
        '
        'pbpesqfornec
        '
        Me.pbpesqfornec.BackColor = System.Drawing.Color.Transparent
        Me.pbpesqfornec.BackgroundImage = Global.TCC.My.Resources.Resources.pesquisamenor
        Me.pbpesqfornec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbpesqfornec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbpesqfornec.Location = New System.Drawing.Point(537, 16)
        Me.pbpesqfornec.Name = "pbpesqfornec"
        Me.pbpesqfornec.Size = New System.Drawing.Size(28, 26)
        Me.pbpesqfornec.TabIndex = 114
        Me.pbpesqfornec.TabStop = False
        '
        'mskinclusao
        '
        Me.mskinclusao.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskinclusao.Location = New System.Drawing.Point(434, 76)
        Me.mskinclusao.Mask = "00/00/0000"
        Me.mskinclusao.Name = "mskinclusao"
        Me.mskinclusao.ReadOnly = True
        Me.mskinclusao.Size = New System.Drawing.Size(77, 22)
        Me.mskinclusao.TabIndex = 6
        Me.mskinclusao.ValidatingType = GetType(Date)
        '
        'mskemissao
        '
        Me.mskemissao.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskemissao.Location = New System.Drawing.Point(153, 46)
        Me.mskemissao.Mask = "00/00/0000"
        Me.mskemissao.Name = "mskemissao"
        Me.mskemissao.ReadOnly = True
        Me.mskemissao.Size = New System.Drawing.Size(77, 22)
        Me.mskemissao.TabIndex = 3
        Me.mskemissao.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(306, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 18)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Data de Inclusão: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 18)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Data de Emissão: "
        '
        'txtcodfornec
        '
        Me.txtcodfornec.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodfornec.Location = New System.Drawing.Point(434, 16)
        Me.txtcodfornec.Name = "txtcodfornec"
        Me.txtcodfornec.ReadOnly = True
        Me.txtcodfornec.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcodfornec.Size = New System.Drawing.Size(100, 22)
        Me.txtcodfornec.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(285, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 18)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Código Fornecedor: "
        '
        'txtcodcompra
        '
        Me.txtcodcompra.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodcompra.Location = New System.Drawing.Point(154, 16)
        Me.txtcodcompra.Name = "txtcodcompra"
        Me.txtcodcompra.ReadOnly = True
        Me.txtcodcompra.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcodcompra.Size = New System.Drawing.Size(100, 22)
        Me.txtcodcompra.TabIndex = 1
        '
        'lblcodcli
        '
        Me.lblcodcli.AutoSize = True
        Me.lblcodcli.BackColor = System.Drawing.Color.Transparent
        Me.lblcodcli.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodcli.ForeColor = System.Drawing.Color.White
        Me.lblcodcli.Location = New System.Drawing.Point(3, 20)
        Me.lblcodcli.Name = "lblcodcli"
        Me.lblcodcli.Size = New System.Drawing.Size(126, 18)
        Me.lblcodcli.TabIndex = 42
        Me.lblcodcli.Text = "Código Compra: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 19)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Cadastro de Compras"
        '
        'pbdelete
        '
        Me.pbdelete.BackColor = System.Drawing.Color.Transparent
        Me.pbdelete.BackgroundImage = Global.TCC.My.Resources.Resources.Delete
        Me.pbdelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbdelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbdelete.Location = New System.Drawing.Point(106, 48)
        Me.pbdelete.Name = "pbdelete"
        Me.pbdelete.Size = New System.Drawing.Size(42, 45)
        Me.pbdelete.TabIndex = 110
        Me.pbdelete.TabStop = False
        '
        'pbconsulta
        '
        Me.pbconsulta.BackColor = System.Drawing.Color.Transparent
        Me.pbconsulta.BackgroundImage = Global.TCC.My.Resources.Resources.pesquisa
        Me.pbconsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbconsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbconsulta.Location = New System.Drawing.Point(60, 48)
        Me.pbconsulta.Name = "pbconsulta"
        Me.pbconsulta.Size = New System.Drawing.Size(42, 45)
        Me.pbconsulta.TabIndex = 109
        Me.pbconsulta.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(599, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "X"
        '
        'pbcad
        '
        Me.pbcad.BackColor = System.Drawing.Color.Transparent
        Me.pbcad.BackgroundImage = Global.TCC.My.Resources.Resources.iconcadastro1
        Me.pbcad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbcad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbcad.Location = New System.Drawing.Point(12, 48)
        Me.pbcad.Name = "pbcad"
        Me.pbcad.Size = New System.Drawing.Size(42, 45)
        Me.pbcad.TabIndex = 107
        Me.pbcad.TabStop = False
        '
        'DataGridCompras
        '
        Me.DataGridCompras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DataGridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Quantidade, Me.Column3})
        Me.DataGridCompras.Location = New System.Drawing.Point(16, 291)
        Me.DataGridCompras.Name = "DataGridCompras"
        Me.DataGridCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridCompras.Size = New System.Drawing.Size(600, 98)
        Me.DataGridCompras.TabIndex = 116
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cód Produto"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Quantidade
        '
        Me.Quantidade.HeaderText = "Quantidade"
        Me.Quantidade.Name = "Quantidade"
        '
        'Column3
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "Valor"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'CalendarEmissao
        '
        Me.CalendarEmissao.Location = New System.Drawing.Point(284, 4)
        Me.CalendarEmissao.Name = "CalendarEmissao"
        Me.CalendarEmissao.TabIndex = 165
        Me.CalendarEmissao.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CalendarEmissao.Visible = False
        '
        'CalendarInclusao
        '
        Me.CalendarInclusao.Location = New System.Drawing.Point(284, 30)
        Me.CalendarInclusao.Name = "CalendarInclusao"
        Me.CalendarInclusao.TabIndex = 188
        Me.CalendarInclusao.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(17, 391)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(599, 58)
        Me.GroupBox3.TabIndex = 221
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dados da compra:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(505, 22)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(45, 21)
        Me.lblTotal.TabIndex = 159
        Me.lblTotal.Text = "0,00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(385, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 21)
        Me.Label14.TabIndex = 158
        Me.Label14.Text = "Valor Total:  "
        '
        'lblquant
        '
        Me.lblquant.AutoSize = True
        Me.lblquant.BackColor = System.Drawing.Color.Transparent
        Me.lblquant.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquant.ForeColor = System.Drawing.Color.White
        Me.lblquant.Location = New System.Drawing.Point(291, 43)
        Me.lblquant.Name = "lblquant"
        Me.lblquant.Size = New System.Drawing.Size(12, 18)
        Me.lblquant.TabIndex = 156
        Me.lblquant.Text = "."
        '
        'FrmCadCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(629, 545)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CalendarInclusao)
        Me.Controls.Add(Me.CalendarEmissao)
        Me.Controls.Add(Me.DataGridCompras)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pbdelete)
        Me.Controls.Add(Me.pbconsulta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pbcad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCadCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadCompras"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbexcluirow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbpesqprod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbpesqfornec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbdelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbconsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsalvar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pbpesqprod As System.Windows.Forms.PictureBox
    Friend WithEvents lblunid As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtqtd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcodpro As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pbpesqfornec As System.Windows.Forms.PictureBox
    Friend WithEvents mskinclusao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskemissao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodfornec As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodcompra As System.Windows.Forms.TextBox
    Friend WithEvents lblcodcli As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pbdelete As System.Windows.Forms.PictureBox
    Friend WithEvents pbconsulta As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pbcad As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridCompras As System.Windows.Forms.DataGridView
    Friend WithEvents pbexcluirow As System.Windows.Forms.PictureBox
    Friend WithEvents pbok As System.Windows.Forms.PictureBox
    Friend WithEvents txtnomefornec As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CalendarEmissao As System.Windows.Forms.MonthCalendar
    Friend WithEvents CalendarInclusao As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents mskpgto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblquant As System.Windows.Forms.Label
End Class
