<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVendas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mskcpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblpedido = New System.Windows.Forms.Label()
        Me.mskdata = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnomecli = New System.Windows.Forms.TextBox()
        Me.pbpesqcli = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodcli = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pbexcluirow = New System.Windows.Forms.PictureBox()
        Me.DataGridVendas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pbok = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtqtd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.pbpesqprod = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcodprod = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnfinalizar = New System.Windows.Forms.Button()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbpesqcli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbexcluirow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbpesqprod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Lucida Handwriting", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(-3, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(427, 33)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = " + Café - Vendas - Usuário: "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.mskcpf)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lblpedido)
        Me.GroupBox1.Controls.Add(Me.mskdata)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtnomecli)
        Me.GroupBox1.Controls.Add(Me.pbpesqcli)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcodcli)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1260, 193)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'mskcpf
        '
        Me.mskcpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.mskcpf.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskcpf.Location = New System.Drawing.Point(291, 142)
        Me.mskcpf.Mask = "000,000,000-00"
        Me.mskcpf.Name = "mskcpf"
        Me.mskcpf.Size = New System.Drawing.Size(152, 35)
        Me.mskcpf.TabIndex = 172
        Me.mskcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(287, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 22)
        Me.Label11.TabIndex = 171
        Me.Label11.Text = "CPF"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.TCC.My.Resources.Resources.logo_escuro1
        Me.PictureBox1.Location = New System.Drawing.Point(1079, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 170
        Me.PictureBox1.TabStop = False
        '
        'lblpedido
        '
        Me.lblpedido.AutoSize = True
        Me.lblpedido.BackColor = System.Drawing.Color.Transparent
        Me.lblpedido.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpedido.ForeColor = System.Drawing.Color.White
        Me.lblpedido.Location = New System.Drawing.Point(850, 64)
        Me.lblpedido.Name = "lblpedido"
        Me.lblpedido.Size = New System.Drawing.Size(45, 32)
        Me.lblpedido.TabIndex = 169
        Me.lblpedido.Text = "00"
        '
        'mskdata
        '
        Me.mskdata.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.mskdata.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskdata.Location = New System.Drawing.Point(43, 142)
        Me.mskdata.Mask = "00/00/0000"
        Me.mskdata.Name = "mskdata"
        Me.mskdata.Size = New System.Drawing.Size(116, 35)
        Me.mskdata.TabIndex = 168
        Me.mskdata.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(35, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 22)
        Me.Label4.TabIndex = 167
        Me.Label4.Text = "Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(834, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 22)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "PEDIDO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(287, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 22)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Nome Cliente"
        '
        'txtnomecli
        '
        Me.txtnomecli.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtnomecli.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomecli.Location = New System.Drawing.Point(292, 63)
        Me.txtnomecli.Name = "txtnomecli"
        Me.txtnomecli.Size = New System.Drawing.Size(442, 35)
        Me.txtnomecli.TabIndex = 163
        '
        'pbpesqcli
        '
        Me.pbpesqcli.BackColor = System.Drawing.Color.Transparent
        Me.pbpesqcli.BackgroundImage = CType(resources.GetObject("pbpesqcli.BackgroundImage"), System.Drawing.Image)
        Me.pbpesqcli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbpesqcli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbpesqcli.Location = New System.Drawing.Point(165, 58)
        Me.pbpesqcli.Name = "pbpesqcli"
        Me.pbpesqcli.Size = New System.Drawing.Size(36, 40)
        Me.pbpesqcli.TabIndex = 162
        Me.pbpesqcli.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 22)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Código Cliente"
        '
        'txtcodcli
        '
        Me.txtcodcli.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtcodcli.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodcli.Location = New System.Drawing.Point(43, 63)
        Me.txtcodcli.Name = "txtcodcli"
        Me.txtcodcli.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcodcli.Size = New System.Drawing.Size(116, 35)
        Me.txtcodcli.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.pbexcluirow)
        Me.GroupBox2.Controls.Add(Me.DataGridVendas)
        Me.GroupBox2.Controls.Add(Me.pbok)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtvalor)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtqtd)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtdesc)
        Me.GroupBox2.Controls.Add(Me.pbpesqprod)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtcodprod)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 248)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1260, 351)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        '
        'pbexcluirow
        '
        Me.pbexcluirow.BackColor = System.Drawing.Color.Transparent
        Me.pbexcluirow.BackgroundImage = Global.TCC.My.Resources.Resources._stop
        Me.pbexcluirow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbexcluirow.Location = New System.Drawing.Point(1132, 56)
        Me.pbexcluirow.Name = "pbexcluirow"
        Me.pbexcluirow.Size = New System.Drawing.Size(48, 43)
        Me.pbexcluirow.TabIndex = 175
        Me.pbexcluirow.TabStop = False
        '
        'DataGridVendas
        '
        Me.DataGridVendas.AllowUserToDeleteRows = False
        Me.DataGridVendas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DataGridVendas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridVendas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridVendas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridVendas.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridVendas.Location = New System.Drawing.Point(40, 112)
        Me.DataGridVendas.Name = "DataGridVendas"
        Me.DataGridVendas.ReadOnly = True
        Me.DataGridVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridVendas.Size = New System.Drawing.Size(1196, 217)
        Me.DataGridVendas.TabIndex = 174
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código Produto"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Descrição"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 450
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantidade"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "Valor Unitário"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column5
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "Subtotal"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'pbok
        '
        Me.pbok.BackColor = System.Drawing.Color.Transparent
        Me.pbok.BackgroundImage = Global.TCC.My.Resources.Resources.Ok3D
        Me.pbok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbok.Location = New System.Drawing.Point(1188, 55)
        Me.pbok.Name = "pbok"
        Me.pbok.Size = New System.Drawing.Size(48, 43)
        Me.pbok.TabIndex = 173
        Me.pbok.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(971, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 22)
        Me.Label10.TabIndex = 172
        Me.Label10.Text = "Valor"
        '
        'txtvalor
        '
        Me.txtvalor.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtvalor.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalor.Location = New System.Drawing.Point(979, 63)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtvalor.Size = New System.Drawing.Size(142, 35)
        Me.txtvalor.TabIndex = 171
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(810, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 22)
        Me.Label6.TabIndex = 170
        Me.Label6.Text = "Quantidade"
        '
        'txtqtd
        '
        Me.txtqtd.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtqtd.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqtd.Location = New System.Drawing.Point(818, 63)
        Me.txtqtd.Name = "txtqtd"
        Me.txtqtd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtqtd.Size = New System.Drawing.Size(100, 35)
        Me.txtqtd.TabIndex = 169
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(287, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 22)
        Me.Label8.TabIndex = 164
        Me.Label8.Text = "Descrição"
        '
        'txtdesc
        '
        Me.txtdesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtdesc.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(292, 63)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(442, 35)
        Me.txtdesc.TabIndex = 163
        '
        'pbpesqprod
        '
        Me.pbpesqprod.BackColor = System.Drawing.Color.Transparent
        Me.pbpesqprod.BackgroundImage = CType(resources.GetObject("pbpesqprod.BackgroundImage"), System.Drawing.Image)
        Me.pbpesqprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbpesqprod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbpesqprod.Location = New System.Drawing.Point(149, 58)
        Me.pbpesqprod.Name = "pbpesqprod"
        Me.pbpesqprod.Size = New System.Drawing.Size(36, 40)
        Me.pbpesqprod.TabIndex = 162
        Me.pbpesqprod.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(35, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 22)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Código Produto"
        '
        'txtcodprod
        '
        Me.txtcodprod.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtcodprod.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodprod.Location = New System.Drawing.Point(43, 63)
        Me.txtcodprod.Name = "txtcodprod"
        Me.txtcodprod.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcodprod.Size = New System.Drawing.Size(100, 35)
        Me.txtcodprod.TabIndex = 42
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(1256, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 25)
        Me.PictureBox2.TabIndex = 175
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(810, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 22)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "TOTAL:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(936, 12)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(80, 37)
        Me.lblTotal.TabIndex = 176
        Me.lblTotal.Text = "0,00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnfinalizar
        '
        Me.btnfinalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnfinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfinalizar.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnfinalizar.ForeColor = System.Drawing.Color.White
        Me.btnfinalizar.Location = New System.Drawing.Point(1120, 621)
        Me.btnfinalizar.Name = "btnfinalizar"
        Me.btnfinalizar.Size = New System.Drawing.Size(128, 48)
        Me.btnfinalizar.TabIndex = 177
        Me.btnfinalizar.Text = "&Confirmar"
        Me.btnfinalizar.UseVisualStyleBackColor = False
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.BackColor = System.Drawing.Color.Transparent
        Me.lbluser.Font = New System.Drawing.Font("Lucida Handwriting", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.White
        Me.lbluser.Location = New System.Drawing.Point(414, 2)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(24, 33)
        Me.lbluser.TabIndex = 178
        Me.lbluser.Text = "."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 615)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1097, 54)
        Me.GroupBox3.TabIndex = 220
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dados da venda:"
        '
        'FrmVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.TelaVendasMax
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 732)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.btnfinalizar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmVendas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbpesqcli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbexcluirow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridVendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbpesqprod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodcli As System.Windows.Forms.TextBox
    Friend WithEvents mskdata As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnomecli As System.Windows.Forms.TextBox
    Friend WithEvents pbpesqcli As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtqtd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents pbpesqprod As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcodprod As System.Windows.Forms.TextBox
    Friend WithEvents DataGridVendas As System.Windows.Forms.DataGridView
    Friend WithEvents pbok As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblpedido As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnfinalizar As System.Windows.Forms.Button
    Friend WithEvents mskcpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents pbexcluirow As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
