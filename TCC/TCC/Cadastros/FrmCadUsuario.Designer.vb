<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadUsuario))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtsenha = New System.Windows.Forms.TextBox()
        Me.cbostatus = New System.Windows.Forms.ComboBox()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.CBOCod = New System.Windows.Forms.ComboBox()
        Me.txtCodUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodFunc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.btnaltera = New System.Windows.Forms.Button()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnlimpar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PBExcluiUser = New System.Windows.Forms.PictureBox()
        Me.PBpescUsua = New System.Windows.Forms.PictureBox()
        Me.PBEdit = New System.Windows.Forms.PictureBox()
        Me.PBCad = New System.Windows.Forms.PictureBox()
        Me.DataGridUser = New System.Windows.Forms.DataGridView()
        Me.CodFuncionarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBFuncionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFunc = New TCC.DataSetFunc()
        Me.TBFuncionariosTableAdapter = New TCC.DataSetFuncTableAdapters.TBFuncionariosTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBExcluiUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBpescUsua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBFuncionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtsenha)
        Me.GroupBox1.Controls.Add(Me.cbostatus)
        Me.GroupBox1.Controls.Add(Me.lblstatus)
        Me.GroupBox1.Controls.Add(Me.CBOCod)
        Me.GroupBox1.Controls.Add(Me.txtCodUser)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCodFunc)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtLogin)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(18, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 233)
        Me.GroupBox1.TabIndex = 132
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Usuário"
        '
        'txtsenha
        '
        Me.txtsenha.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtsenha.Location = New System.Drawing.Point(86, 155)
        Me.txtsenha.Name = "txtsenha"
        Me.txtsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtsenha.Size = New System.Drawing.Size(194, 22)
        Me.txtsenha.TabIndex = 4
        '
        'cbostatus
        '
        Me.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostatus.Enabled = False
        Me.cbostatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"Ativo", "Inativo"})
        Me.cbostatus.Location = New System.Drawing.Point(86, 187)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.Size = New System.Drawing.Size(111, 24)
        Me.cbostatus.TabIndex = 130
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.BackColor = System.Drawing.Color.Transparent
        Me.lblstatus.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.Color.White
        Me.lblstatus.Location = New System.Drawing.Point(9, 194)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(61, 18)
        Me.lblstatus.TabIndex = 131
        Me.lblstatus.Text = "Status: "
        '
        'CBOCod
        '
        Me.CBOCod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCod.FormattingEnabled = True
        Me.CBOCod.Items.AddRange(New Object() {"1", "2"})
        Me.CBOCod.Location = New System.Drawing.Point(158, 58)
        Me.CBOCod.Name = "CBOCod"
        Me.CBOCod.Size = New System.Drawing.Size(81, 22)
        Me.CBOCod.TabIndex = 2
        '
        'txtCodUser
        '
        Me.txtCodUser.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtCodUser.Location = New System.Drawing.Point(158, 26)
        Me.txtCodUser.Name = "txtCodUser"
        Me.txtCodUser.ReadOnly = True
        Me.txtCodUser.Size = New System.Drawing.Size(81, 22)
        Me.txtCodUser.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 18)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "Código Usuário: "
        '
        'txtCodFunc
        '
        Me.txtCodFunc.Enabled = False
        Me.txtCodFunc.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtCodFunc.Location = New System.Drawing.Point(159, 90)
        Me.txtCodFunc.Name = "txtCodFunc"
        Me.txtCodFunc.Size = New System.Drawing.Size(80, 22)
        Me.txtCodFunc.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 18)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Código Empregado: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 18)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Código de Acesso: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Senha: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Usuário: "
        '
        'txtLogin
        '
        Me.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogin.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtLogin.Location = New System.Drawing.Point(86, 123)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(194, 22)
        Me.txtLogin.TabIndex = 3
        '
        'btnaltera
        '
        Me.btnaltera.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnaltera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaltera.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnaltera.ForeColor = System.Drawing.Color.White
        Me.btnaltera.Location = New System.Drawing.Point(610, 345)
        Me.btnaltera.Name = "btnaltera"
        Me.btnaltera.Size = New System.Drawing.Size(102, 28)
        Me.btnaltera.TabIndex = 129
        Me.btnaltera.Text = "Alterar"
        Me.btnaltera.UseVisualStyleBackColor = False
        Me.btnaltera.Visible = False
        '
        'btnsalvar
        '
        Me.btnsalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalvar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnsalvar.ForeColor = System.Drawing.Color.White
        Me.btnsalvar.Location = New System.Drawing.Point(610, 345)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(102, 28)
        Me.btnsalvar.TabIndex = 128
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = False
        '
        'btnlimpar
        '
        Me.btnlimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnlimpar.ForeColor = System.Drawing.Color.White
        Me.btnlimpar.Location = New System.Drawing.Point(494, 345)
        Me.btnlimpar.Name = "btnlimpar"
        Me.btnlimpar.Size = New System.Drawing.Size(102, 28)
        Me.btnlimpar.TabIndex = 130
        Me.btnlimpar.Text = "Limpar"
        Me.btnlimpar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(707, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 19)
        Me.Label8.TabIndex = 127
        Me.Label8.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(14, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 19)
        Me.Label7.TabIndex = 126
        Me.Label7.Text = "Cadastro Usuario"
        '
        'PBExcluiUser
        '
        Me.PBExcluiUser.BackColor = System.Drawing.Color.Transparent
        Me.PBExcluiUser.BackgroundImage = CType(resources.GetObject("PBExcluiUser.BackgroundImage"), System.Drawing.Image)
        Me.PBExcluiUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBExcluiUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBExcluiUser.Location = New System.Drawing.Point(152, 52)
        Me.PBExcluiUser.Name = "PBExcluiUser"
        Me.PBExcluiUser.Size = New System.Drawing.Size(43, 42)
        Me.PBExcluiUser.TabIndex = 125
        Me.PBExcluiUser.TabStop = False
        '
        'PBpescUsua
        '
        Me.PBpescUsua.BackColor = System.Drawing.Color.Transparent
        Me.PBpescUsua.BackgroundImage = CType(resources.GetObject("PBpescUsua.BackgroundImage"), System.Drawing.Image)
        Me.PBpescUsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBpescUsua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBpescUsua.Location = New System.Drawing.Point(63, 49)
        Me.PBpescUsua.Name = "PBpescUsua"
        Me.PBpescUsua.Size = New System.Drawing.Size(40, 49)
        Me.PBpescUsua.TabIndex = 124
        Me.PBpescUsua.TabStop = False
        '
        'PBEdit
        '
        Me.PBEdit.BackColor = System.Drawing.Color.Transparent
        Me.PBEdit.BackgroundImage = CType(resources.GetObject("PBEdit.BackgroundImage"), System.Drawing.Image)
        Me.PBEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBEdit.Location = New System.Drawing.Point(107, 49)
        Me.PBEdit.Name = "PBEdit"
        Me.PBEdit.Size = New System.Drawing.Size(48, 49)
        Me.PBEdit.TabIndex = 123
        Me.PBEdit.TabStop = False
        '
        'PBCad
        '
        Me.PBCad.BackColor = System.Drawing.Color.Transparent
        Me.PBCad.BackgroundImage = CType(resources.GetObject("PBCad.BackgroundImage"), System.Drawing.Image)
        Me.PBCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBCad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBCad.Location = New System.Drawing.Point(14, 49)
        Me.PBCad.Name = "PBCad"
        Me.PBCad.Size = New System.Drawing.Size(43, 42)
        Me.PBCad.TabIndex = 122
        Me.PBCad.TabStop = False
        '
        'DataGridUser
        '
        Me.DataGridUser.AllowUserToDeleteRows = False
        Me.DataGridUser.AutoGenerateColumns = False
        Me.DataGridUser.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodFuncionarioDataGridViewTextBoxColumn, Me.NomeCompletoDataGridViewTextBoxColumn})
        Me.DataGridUser.DataSource = Me.TBFuncionariosBindingSource
        Me.DataGridUser.Location = New System.Drawing.Point(321, 72)
        Me.DataGridUser.Name = "DataGridUser"
        Me.DataGridUser.ReadOnly = True
        Me.DataGridUser.Size = New System.Drawing.Size(392, 267)
        Me.DataGridUser.TabIndex = 132
        '
        'CodFuncionarioDataGridViewTextBoxColumn
        '
        Me.CodFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Cod_Funcionario"
        Me.CodFuncionarioDataGridViewTextBoxColumn.HeaderText = "Cod Emp"
        Me.CodFuncionarioDataGridViewTextBoxColumn.Name = "CodFuncionarioDataGridViewTextBoxColumn"
        Me.CodFuncionarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeCompletoDataGridViewTextBoxColumn
        '
        Me.NomeCompletoDataGridViewTextBoxColumn.DataPropertyName = "Nome_Completo"
        Me.NomeCompletoDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomeCompletoDataGridViewTextBoxColumn.Name = "NomeCompletoDataGridViewTextBoxColumn"
        Me.NomeCompletoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomeCompletoDataGridViewTextBoxColumn.Width = 250
        '
        'TBFuncionariosBindingSource
        '
        Me.TBFuncionariosBindingSource.DataMember = "TBFuncionarios"
        Me.TBFuncionariosBindingSource.DataSource = Me.DataSetFunc
        '
        'DataSetFunc
        '
        Me.DataSetFunc.DataSetName = "DataSetFunc"
        Me.DataSetFunc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBFuncionariosTableAdapter
        '
        Me.TBFuncionariosTableAdapter.ClearBeforeFill = True
        '
        'FrmCadUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(730, 412)
        Me.Controls.Add(Me.DataGridUser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnaltera)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.btnlimpar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PBExcluiUser)
        Me.Controls.Add(Me.PBpescUsua)
        Me.Controls.Add(Me.PBEdit)
        Me.Controls.Add(Me.PBCad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCadUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadUsuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PBExcluiUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBpescUsua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBFuncionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFunc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBOCod As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodUser As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodFunc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents btnaltera As System.Windows.Forms.Button
    Friend WithEvents btnsalvar As System.Windows.Forms.Button
    Friend WithEvents btnlimpar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PBExcluiUser As System.Windows.Forms.PictureBox
    Friend WithEvents PBpescUsua As System.Windows.Forms.PictureBox
    Friend WithEvents PBEdit As System.Windows.Forms.PictureBox
    Friend WithEvents PBCad As System.Windows.Forms.PictureBox
    Friend WithEvents cbostatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents DataGridUser As System.Windows.Forms.DataGridView
    Friend WithEvents DataSetFunc As TCC.DataSetFunc
    Friend WithEvents TBFuncionariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBFuncionariosTableAdapter As TCC.DataSetFuncTableAdapters.TBFuncionariosTableAdapter
    Friend WithEvents txtsenha As System.Windows.Forms.TextBox
    Friend WithEvents CodFuncionarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeCompletoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
