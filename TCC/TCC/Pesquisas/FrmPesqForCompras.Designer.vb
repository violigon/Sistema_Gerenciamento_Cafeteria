<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesqForCompras
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnok = New System.Windows.Forms.Button()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.DataGridFornec = New System.Windows.Forms.DataGridView()
        Me.CodFornecedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNPJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeFantasiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazãoSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBFornecedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFornec = New TCC.DataSetFornec()
        Me.TBFornecedorTableAdapter = New TCC.DataSetFornecTableAdapters.TBFornecedorTableAdapter()
        CType(Me.DataGridFornec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBFornecedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFornec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 19)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Consulta de Fornecedor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(362, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "X"
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnok.ForeColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(322, 338)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(51, 28)
        Me.btnok.TabIndex = 94
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'txtnome
        '
        Me.txtnome.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.Location = New System.Drawing.Point(12, 55)
        Me.txtnome.MaxLength = 100
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(361, 22)
        Me.txtnome.TabIndex = 93
        '
        'DataGridFornec
        '
        Me.DataGridFornec.AllowUserToDeleteRows = False
        Me.DataGridFornec.AutoGenerateColumns = False
        Me.DataGridFornec.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DataGridFornec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFornec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodFornecedorDataGridViewTextBoxColumn, Me.CNPJDataGridViewTextBoxColumn, Me.NomeFantasiaDataGridViewTextBoxColumn, Me.RazãoSocialDataGridViewTextBoxColumn})
        Me.DataGridFornec.DataSource = Me.TBFornecedorBindingSource
        Me.DataGridFornec.Location = New System.Drawing.Point(12, 83)
        Me.DataGridFornec.Name = "DataGridFornec"
        Me.DataGridFornec.ReadOnly = True
        Me.DataGridFornec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridFornec.Size = New System.Drawing.Size(361, 245)
        Me.DataGridFornec.TabIndex = 95
        '
        'CodFornecedorDataGridViewTextBoxColumn
        '
        Me.CodFornecedorDataGridViewTextBoxColumn.DataPropertyName = "Cod_Fornecedor"
        Me.CodFornecedorDataGridViewTextBoxColumn.HeaderText = "Cod Fornec"
        Me.CodFornecedorDataGridViewTextBoxColumn.Name = "CodFornecedorDataGridViewTextBoxColumn"
        Me.CodFornecedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CNPJDataGridViewTextBoxColumn
        '
        Me.CNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ"
        Me.CNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ"
        Me.CNPJDataGridViewTextBoxColumn.Name = "CNPJDataGridViewTextBoxColumn"
        Me.CNPJDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeFantasiaDataGridViewTextBoxColumn
        '
        Me.NomeFantasiaDataGridViewTextBoxColumn.DataPropertyName = "Nome_Fantasia"
        Me.NomeFantasiaDataGridViewTextBoxColumn.HeaderText = "Nome_Fantasia"
        Me.NomeFantasiaDataGridViewTextBoxColumn.Name = "NomeFantasiaDataGridViewTextBoxColumn"
        Me.NomeFantasiaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RazãoSocialDataGridViewTextBoxColumn
        '
        Me.RazãoSocialDataGridViewTextBoxColumn.DataPropertyName = "Razão_Social"
        Me.RazãoSocialDataGridViewTextBoxColumn.HeaderText = "Razão Social"
        Me.RazãoSocialDataGridViewTextBoxColumn.Name = "RazãoSocialDataGridViewTextBoxColumn"
        Me.RazãoSocialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBFornecedorBindingSource
        '
        Me.TBFornecedorBindingSource.DataMember = "TBFornecedor"
        Me.TBFornecedorBindingSource.DataSource = Me.DataSetFornec
        '
        'DataSetFornec
        '
        Me.DataSetFornec.DataSetName = "DataSetFornec"
        Me.DataSetFornec.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBFornecedorTableAdapter
        '
        Me.TBFornecedorTableAdapter.ClearBeforeFill = True
        '
        'FrmPesqForCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.ClientSize = New System.Drawing.Size(388, 379)
        Me.Controls.Add(Me.DataGridFornec)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPesqForCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPesqForCompras"
        CType(Me.DataGridFornec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBFornecedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFornec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents DataGridFornec As System.Windows.Forms.DataGridView
    Friend WithEvents DataSetFornec As TCC.DataSetFornec
    Friend WithEvents TBFornecedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBFornecedorTableAdapter As TCC.DataSetFornecTableAdapters.TBFornecedorTableAdapter
    Friend WithEvents CodFornecedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNPJDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeFantasiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RazãoSocialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
