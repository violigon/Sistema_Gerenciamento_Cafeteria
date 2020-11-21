Imports TCC.DataSetEstTableAdapters

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadEstrutura
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pbdelete = New System.Windows.Forms.PictureBox()
        Me.pbconsulta = New System.Windows.Forms.PictureBox()
        Me.pbcad = New System.Windows.Forms.PictureBox()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnlimpar = New System.Windows.Forms.Button()
        Me.DataGridEst = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pbok = New System.Windows.Forms.PictureBox()
        Me.txtCodEst = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtcodPA = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnomePA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblunid = New System.Windows.Forms.Label()
        Me.txtqtd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnomeIN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pbpesqcep = New System.Windows.Forms.PictureBox()
        Me.txtcodpro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbexcluirow = New System.Windows.Forms.PictureBox()
        Me.BDMaisCafeDataSetEst = New TCC.DataSetEst()
        Me.TBEstruturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBEstruturaTableAdapter = New TCC.DataSetEstTableAdapters.TBEstruturaTableAdapter()
        CType(Me.pbdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbconsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridEst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbpesqcep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbexcluirow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDMaisCafeDataSetEst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBEstruturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(687, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 19)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Cadastro de Estrutura"
        '
        'pbdelete
        '
        Me.pbdelete.BackColor = System.Drawing.Color.Transparent
        Me.pbdelete.BackgroundImage = Global.TCC.My.Resources.Resources.Delete
        Me.pbdelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbdelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbdelete.Location = New System.Drawing.Point(115, 49)
        Me.pbdelete.Name = "pbdelete"
        Me.pbdelete.Size = New System.Drawing.Size(42, 45)
        Me.pbdelete.TabIndex = 35
        Me.pbdelete.TabStop = False
        '
        'pbconsulta
        '
        Me.pbconsulta.BackColor = System.Drawing.Color.Transparent
        Me.pbconsulta.BackgroundImage = Global.TCC.My.Resources.Resources.pesquisa
        Me.pbconsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbconsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbconsulta.Location = New System.Drawing.Point(67, 49)
        Me.pbconsulta.Name = "pbconsulta"
        Me.pbconsulta.Size = New System.Drawing.Size(42, 45)
        Me.pbconsulta.TabIndex = 33
        Me.pbconsulta.TabStop = False
        '
        'pbcad
        '
        Me.pbcad.BackColor = System.Drawing.Color.Transparent
        Me.pbcad.BackgroundImage = Global.TCC.My.Resources.Resources.iconcadastro1
        Me.pbcad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbcad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbcad.Location = New System.Drawing.Point(16, 49)
        Me.pbcad.Name = "pbcad"
        Me.pbcad.Size = New System.Drawing.Size(42, 45)
        Me.pbcad.TabIndex = 32
        Me.pbcad.TabStop = False
        '
        'btnsalvar
        '
        Me.btnsalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalvar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnsalvar.ForeColor = System.Drawing.Color.White
        Me.btnsalvar.Location = New System.Drawing.Point(598, 417)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(102, 28)
        Me.btnsalvar.TabIndex = 6
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = False
        '
        'btnlimpar
        '
        Me.btnlimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnlimpar.ForeColor = System.Drawing.Color.White
        Me.btnlimpar.Location = New System.Drawing.Point(491, 417)
        Me.btnlimpar.Name = "btnlimpar"
        Me.btnlimpar.Size = New System.Drawing.Size(102, 28)
        Me.btnlimpar.TabIndex = 7
        Me.btnlimpar.Text = "Limpar"
        Me.btnlimpar.UseVisualStyleBackColor = False
        '
        'DataGridEst
        '
        Me.DataGridEst.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DataGridEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridEst.Location = New System.Drawing.Point(12, 300)
        Me.DataGridEst.Name = "DataGridEst"
        Me.DataGridEst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridEst.Size = New System.Drawing.Size(689, 104)
        Me.DataGridEst.TabIndex = 133
        '
        'Column1
        '
        Me.Column1.HeaderText = "CódigoIN"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nome"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 445
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantidade"
        Me.Column3.Name = "Column3"
        '
        'pbok
        '
        Me.pbok.BackColor = System.Drawing.Color.Transparent
        Me.pbok.BackgroundImage = Global.TCC.My.Resources.Resources.Ok3D
        Me.pbok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbok.Location = New System.Drawing.Point(640, 272)
        Me.pbok.Name = "pbok"
        Me.pbok.Size = New System.Drawing.Size(25, 24)
        Me.pbok.TabIndex = 140
        Me.pbok.TabStop = False
        '
        'txtCodEst
        '
        Me.txtCodEst.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtCodEst.Location = New System.Drawing.Point(163, 105)
        Me.txtCodEst.Name = "txtCodEst"
        Me.txtCodEst.ReadOnly = True
        Me.txtCodEst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCodEst.Size = New System.Drawing.Size(81, 22)
        Me.txtCodEst.TabIndex = 149
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 18)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "Código Estrutura: "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.txtcodPA)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtnomePA)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(689, 54)
        Me.GroupBox2.TabIndex = 151
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados PA"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.TCC.My.Resources.Resources.pesquisamenor
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(253, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 32)
        Me.PictureBox1.TabIndex = 155
        Me.PictureBox1.TabStop = False
        '
        'txtcodPA
        '
        Me.txtcodPA.Enabled = False
        Me.txtcodPA.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtcodPA.Location = New System.Drawing.Point(169, 18)
        Me.txtcodPA.Name = "txtcodPA"
        Me.txtcodPA.ReadOnly = True
        Me.txtcodPA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcodPA.Size = New System.Drawing.Size(80, 22)
        Me.txtcodPA.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(9, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 18)
        Me.Label10.TabIndex = 153
        Me.Label10.Text = "Código Produto PA: "
        '
        'txtnomePA
        '
        Me.txtnomePA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomePA.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtnomePA.Location = New System.Drawing.Point(473, 19)
        Me.txtnomePA.Name = "txtnomePA"
        Me.txtnomePA.Size = New System.Drawing.Size(156, 22)
        Me.txtnomePA.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(325, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 18)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Nome Produto PA: "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblunid)
        Me.GroupBox1.Controls.Add(Me.txtqtd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnomeIN)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.pbpesqcep)
        Me.GroupBox1.Controls.Add(Me.txtcodpro)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 193)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(689, 76)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados IN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(325, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Unid. Medida:"
        '
        'lblunid
        '
        Me.lblunid.AutoSize = True
        Me.lblunid.BackColor = System.Drawing.Color.Transparent
        Me.lblunid.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblunid.ForeColor = System.Drawing.Color.White
        Me.lblunid.Location = New System.Drawing.Point(465, 48)
        Me.lblunid.Name = "lblunid"
        Me.lblunid.Size = New System.Drawing.Size(12, 18)
        Me.lblunid.TabIndex = 156
        Me.lblunid.Text = "."
        '
        'txtqtd
        '
        Me.txtqtd.Enabled = False
        Me.txtqtd.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtqtd.Location = New System.Drawing.Point(162, 44)
        Me.txtqtd.Name = "txtqtd"
        Me.txtqtd.Size = New System.Drawing.Size(80, 22)
        Me.txtqtd.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "Quantidade: "
        '
        'txtnomeIN
        '
        Me.txtnomeIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomeIN.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtnomeIN.Location = New System.Drawing.Point(468, 16)
        Me.txtnomeIN.Name = "txtnomeIN"
        Me.txtnomeIN.ReadOnly = True
        Me.txtnomeIN.Size = New System.Drawing.Size(161, 22)
        Me.txtnomeIN.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(325, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 18)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "Nome Produto IN: "
        '
        'pbpesqcep
        '
        Me.pbpesqcep.BackColor = System.Drawing.Color.Transparent
        Me.pbpesqcep.BackgroundImage = Global.TCC.My.Resources.Resources.pesquisamenor
        Me.pbpesqcep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbpesqcep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbpesqcep.Location = New System.Drawing.Point(245, 14)
        Me.pbpesqcep.Name = "pbpesqcep"
        Me.pbpesqcep.Size = New System.Drawing.Size(28, 24)
        Me.pbpesqcep.TabIndex = 149
        Me.pbpesqcep.TabStop = False
        '
        'txtcodpro
        '
        Me.txtcodpro.Enabled = False
        Me.txtcodpro.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtcodpro.Location = New System.Drawing.Point(162, 14)
        Me.txtcodpro.Name = "txtcodpro"
        Me.txtcodpro.ReadOnly = True
        Me.txtcodpro.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcodpro.Size = New System.Drawing.Size(80, 22)
        Me.txtcodpro.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 18)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "Código Produto IN: "
        '
        'pbexcluirow
        '
        Me.pbexcluirow.BackColor = System.Drawing.Color.Transparent
        Me.pbexcluirow.BackgroundImage = Global.TCC.My.Resources.Resources._stop
        Me.pbexcluirow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbexcluirow.Location = New System.Drawing.Point(675, 272)
        Me.pbexcluirow.Name = "pbexcluirow"
        Me.pbexcluirow.Size = New System.Drawing.Size(25, 24)
        Me.pbexcluirow.TabIndex = 153
        Me.pbexcluirow.TabStop = False
        '
        'BDMaisCafeDataSetEst
        '
        Me.BDMaisCafeDataSetEst.DataSetName = "BDMaisCafeDataSetEst"
        Me.BDMaisCafeDataSetEst.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBEstruturaBindingSource
        '
        Me.TBEstruturaBindingSource.DataMember = "TBEstrutura"
        Me.TBEstruturaBindingSource.DataSource = Me.BDMaisCafeDataSetEst
        '
        'TBEstruturaTableAdapter
        '
        Me.TBEstruturaTableAdapter.ClearBeforeFill = True
        '
        'FrmCadEstrutura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(717, 502)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtCodEst)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pbexcluirow)
        Me.Controls.Add(Me.DataGridEst)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.btnlimpar)
        Me.Controls.Add(Me.pbok)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pbdelete)
        Me.Controls.Add(Me.pbconsulta)
        Me.Controls.Add(Me.pbcad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCadEstrutura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadEstrutura"
        CType(Me.pbdelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbconsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridEst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbpesqcep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbexcluirow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDMaisCafeDataSetEst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBEstruturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pbdelete As System.Windows.Forms.PictureBox
    Friend WithEvents pbconsulta As System.Windows.Forms.PictureBox
    Friend WithEvents pbcad As System.Windows.Forms.PictureBox
    Friend WithEvents btnsalvar As System.Windows.Forms.Button
    Friend WithEvents btnlimpar As System.Windows.Forms.Button
    Friend WithEvents DataGridEst As System.Windows.Forms.DataGridView
    Friend WithEvents pbok As System.Windows.Forms.PictureBox
    Friend WithEvents txtCodEst As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtcodPA As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtnomePA As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnomeIN As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pbpesqcep As System.Windows.Forms.PictureBox
    Friend WithEvents txtcodpro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDMaisCafeDataSetEst As TCC.DataSetEst
    Friend WithEvents TBEstruturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBEstruturaTableAdapter As DataSetEstTableAdapters.TBEstruturaTableAdapter
    Friend WithEvents pbexcluirow As System.Windows.Forms.PictureBox
    Friend WithEvents lblunid As System.Windows.Forms.Label
    Friend WithEvents txtqtd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
