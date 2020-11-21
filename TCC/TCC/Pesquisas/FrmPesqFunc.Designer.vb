<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesqFunc
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
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.btnok = New System.Windows.Forms.Button()
        Me.pbsair = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridFunc = New System.Windows.Forms.DataGridView()
        Me.CodFuncionarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataNascimentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogradouroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BairroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBFuncionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFunc = New TCC.DataSetFunc()
        Me.TBFuncionariosTableAdapter = New TCC.DataSetFuncTableAdapters.TBFuncionariosTableAdapter()
        CType(Me.DataGridFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBFuncionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnome
        '
        Me.txtnome.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.Location = New System.Drawing.Point(12, 61)
        Me.txtnome.MaxLength = 100
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(471, 22)
        Me.txtnome.TabIndex = 21
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnok.ForeColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(432, 347)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(51, 28)
        Me.btnok.TabIndex = 26
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'pbsair
        '
        Me.pbsair.AutoSize = True
        Me.pbsair.BackColor = System.Drawing.Color.Transparent
        Me.pbsair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbsair.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pbsair.ForeColor = System.Drawing.Color.White
        Me.pbsair.Location = New System.Drawing.Point(469, 9)
        Me.pbsair.Name = "pbsair"
        Me.pbsair.Size = New System.Drawing.Size(23, 22)
        Me.pbsair.TabIndex = 27
        Me.pbsair.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 19)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Consulta de Empregados"
        '
        'DataGridFunc
        '
        Me.DataGridFunc.AllowUserToDeleteRows = False
        Me.DataGridFunc.AutoGenerateColumns = False
        Me.DataGridFunc.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DataGridFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFunc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodFuncionarioDataGridViewTextBoxColumn, Me.NomeCompletoDataGridViewTextBoxColumn, Me.DataNascimentoDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.CPFDataGridViewTextBoxColumn, Me.RGDataGridViewTextBoxColumn, Me.TelefoneDataGridViewTextBoxColumn, Me.LogradouroDataGridViewTextBoxColumn, Me.NumeroDataGridViewTextBoxColumn, Me.CEPDataGridViewTextBoxColumn, Me.CidadeDataGridViewTextBoxColumn, Me.BairroDataGridViewTextBoxColumn, Me.UFDataGridViewTextBoxColumn})
        Me.DataGridFunc.DataSource = Me.TBFuncionariosBindingSource
        Me.DataGridFunc.Location = New System.Drawing.Point(12, 89)
        Me.DataGridFunc.Name = "DataGridFunc"
        Me.DataGridFunc.ReadOnly = True
        Me.DataGridFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridFunc.Size = New System.Drawing.Size(471, 252)
        Me.DataGridFunc.TabIndex = 89
        '
        'CodFuncionarioDataGridViewTextBoxColumn
        '
        Me.CodFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Cod_Funcionario"
        Me.CodFuncionarioDataGridViewTextBoxColumn.HeaderText = "Cod Empreg"
        Me.CodFuncionarioDataGridViewTextBoxColumn.Name = "CodFuncionarioDataGridViewTextBoxColumn"
        Me.CodFuncionarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeCompletoDataGridViewTextBoxColumn
        '
        Me.NomeCompletoDataGridViewTextBoxColumn.DataPropertyName = "Nome_Completo"
        Me.NomeCompletoDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomeCompletoDataGridViewTextBoxColumn.Name = "NomeCompletoDataGridViewTextBoxColumn"
        Me.NomeCompletoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomeCompletoDataGridViewTextBoxColumn.Width = 120
        '
        'DataNascimentoDataGridViewTextBoxColumn
        '
        Me.DataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "Data_Nascimento"
        Me.DataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data Nasc"
        Me.DataNascimentoDataGridViewTextBoxColumn.Name = "DataNascimentoDataGridViewTextBoxColumn"
        Me.DataNascimentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        Me.SexoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CPFDataGridViewTextBoxColumn
        '
        Me.CPFDataGridViewTextBoxColumn.DataPropertyName = "CPF"
        Me.CPFDataGridViewTextBoxColumn.HeaderText = "CPF"
        Me.CPFDataGridViewTextBoxColumn.Name = "CPFDataGridViewTextBoxColumn"
        Me.CPFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RGDataGridViewTextBoxColumn
        '
        Me.RGDataGridViewTextBoxColumn.DataPropertyName = "RG"
        Me.RGDataGridViewTextBoxColumn.HeaderText = "RG"
        Me.RGDataGridViewTextBoxColumn.Name = "RGDataGridViewTextBoxColumn"
        Me.RGDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefoneDataGridViewTextBoxColumn
        '
        Me.TelefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone"
        Me.TelefoneDataGridViewTextBoxColumn.HeaderText = "Telefone"
        Me.TelefoneDataGridViewTextBoxColumn.Name = "TelefoneDataGridViewTextBoxColumn"
        Me.TelefoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LogradouroDataGridViewTextBoxColumn
        '
        Me.LogradouroDataGridViewTextBoxColumn.DataPropertyName = "Logradouro"
        Me.LogradouroDataGridViewTextBoxColumn.HeaderText = "Logradouro"
        Me.LogradouroDataGridViewTextBoxColumn.Name = "LogradouroDataGridViewTextBoxColumn"
        Me.LogradouroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEPDataGridViewTextBoxColumn
        '
        Me.CEPDataGridViewTextBoxColumn.DataPropertyName = "CEP"
        Me.CEPDataGridViewTextBoxColumn.HeaderText = "CEP"
        Me.CEPDataGridViewTextBoxColumn.Name = "CEPDataGridViewTextBoxColumn"
        Me.CEPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CidadeDataGridViewTextBoxColumn
        '
        Me.CidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade"
        Me.CidadeDataGridViewTextBoxColumn.HeaderText = "Cidade"
        Me.CidadeDataGridViewTextBoxColumn.Name = "CidadeDataGridViewTextBoxColumn"
        Me.CidadeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BairroDataGridViewTextBoxColumn
        '
        Me.BairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro"
        Me.BairroDataGridViewTextBoxColumn.HeaderText = "Bairro"
        Me.BairroDataGridViewTextBoxColumn.Name = "BairroDataGridViewTextBoxColumn"
        Me.BairroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UFDataGridViewTextBoxColumn
        '
        Me.UFDataGridViewTextBoxColumn.DataPropertyName = "UF"
        Me.UFDataGridViewTextBoxColumn.HeaderText = "UF"
        Me.UFDataGridViewTextBoxColumn.Name = "UFDataGridViewTextBoxColumn"
        Me.UFDataGridViewTextBoxColumn.ReadOnly = True
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
        'FrmPesqFunc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.ClientSize = New System.Drawing.Size(495, 417)
        Me.Controls.Add(Me.DataGridFunc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbsair)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtnome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPesqFunc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPesqFunc"
        CType(Me.DataGridFunc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBFuncionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFunc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents pbsair As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridFunc As System.Windows.Forms.DataGridView
    Friend WithEvents DataSetFunc As TCC.DataSetFunc
    Friend WithEvents TBFuncionariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBFuncionariosTableAdapter As TCC.DataSetFuncTableAdapters.TBFuncionariosTableAdapter
    Friend WithEvents CodFuncionarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeCompletoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataNascimentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RGDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogradouroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CidadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BairroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
