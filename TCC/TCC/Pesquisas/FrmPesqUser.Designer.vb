<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesqUser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnok = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.DataGridUser = New System.Windows.Forms.DataGridView()
        Me.CodloginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SenhaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodAcessoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodFuncionarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetUsuario = New TCC.DataSetUsuario()
        Me.TB_LoginTableAdapter = New TCC.DataSetUsuarioTableAdapters.TB_LoginTableAdapter()
        CType(Me.DataGridUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 19)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Consulta de Usuários"
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnok.ForeColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(305, 304)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(51, 28)
        Me.btnok.TabIndex = 91
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(345, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "X"
        '
        'txtnome
        '
        Me.txtnome.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.Location = New System.Drawing.Point(15, 57)
        Me.txtnome.MaxLength = 100
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(344, 22)
        Me.txtnome.TabIndex = 89
        '
        'DataGridUser
        '
        Me.DataGridUser.AllowUserToDeleteRows = False
        Me.DataGridUser.AutoGenerateColumns = False
        Me.DataGridUser.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodloginDataGridViewTextBoxColumn, Me.LoginUserDataGridViewTextBoxColumn, Me.SenhaDataGridViewTextBoxColumn, Me.CodAcessoDataGridViewTextBoxColumn, Me.CodFuncionarioDataGridViewTextBoxColumn})
        Me.DataGridUser.DataSource = Me.TBLoginBindingSource
        Me.DataGridUser.Location = New System.Drawing.Point(16, 85)
        Me.DataGridUser.Name = "DataGridUser"
        Me.DataGridUser.ReadOnly = True
        Me.DataGridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridUser.Size = New System.Drawing.Size(340, 213)
        Me.DataGridUser.TabIndex = 93
        '
        'CodloginDataGridViewTextBoxColumn
        '
        Me.CodloginDataGridViewTextBoxColumn.DataPropertyName = "Cod_login"
        Me.CodloginDataGridViewTextBoxColumn.HeaderText = "Cod_login"
        Me.CodloginDataGridViewTextBoxColumn.Name = "CodloginDataGridViewTextBoxColumn"
        Me.CodloginDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LoginUserDataGridViewTextBoxColumn
        '
        Me.LoginUserDataGridViewTextBoxColumn.DataPropertyName = "LoginUser"
        Me.LoginUserDataGridViewTextBoxColumn.HeaderText = "LoginUser"
        Me.LoginUserDataGridViewTextBoxColumn.Name = "LoginUserDataGridViewTextBoxColumn"
        Me.LoginUserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SenhaDataGridViewTextBoxColumn
        '
        Me.SenhaDataGridViewTextBoxColumn.DataPropertyName = "Senha"
        Me.SenhaDataGridViewTextBoxColumn.HeaderText = "Senha"
        Me.SenhaDataGridViewTextBoxColumn.Name = "SenhaDataGridViewTextBoxColumn"
        Me.SenhaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SenhaDataGridViewTextBoxColumn.Visible = False
        '
        'CodAcessoDataGridViewTextBoxColumn
        '
        Me.CodAcessoDataGridViewTextBoxColumn.DataPropertyName = "CodAcesso"
        Me.CodAcessoDataGridViewTextBoxColumn.HeaderText = "CodAcesso"
        Me.CodAcessoDataGridViewTextBoxColumn.Name = "CodAcessoDataGridViewTextBoxColumn"
        Me.CodAcessoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodFuncionarioDataGridViewTextBoxColumn
        '
        Me.CodFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Cod_Funcionario"
        Me.CodFuncionarioDataGridViewTextBoxColumn.HeaderText = "Cod_Funcionario"
        Me.CodFuncionarioDataGridViewTextBoxColumn.Name = "CodFuncionarioDataGridViewTextBoxColumn"
        Me.CodFuncionarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBLoginBindingSource
        '
        Me.TBLoginBindingSource.DataMember = "TB_Login"
        Me.TBLoginBindingSource.DataSource = Me.DataSetUsuario
        '
        'DataSetUsuario
        '
        Me.DataSetUsuario.DataSetName = "DataSetUsuario"
        Me.DataSetUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TB_LoginTableAdapter
        '
        Me.TB_LoginTableAdapter.ClearBeforeFill = True
        '
        'FrmPesqUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.ClientSize = New System.Drawing.Size(371, 342)
        Me.Controls.Add(Me.DataGridUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPesqUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPesqUser"
        CType(Me.DataGridUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents DataGridUser As System.Windows.Forms.DataGridView
    Friend WithEvents DataSetUsuario As TCC.DataSetUsuario
    Friend WithEvents TBLoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_LoginTableAdapter As TCC.DataSetUsuarioTableAdapters.TB_LoginTableAdapter
    Friend WithEvents CodloginDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoginUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SenhaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodAcessoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodFuncionarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
