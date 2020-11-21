<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesqProdVendas
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
        Me.DataGridProd = New System.Windows.Forms.DataGridView()
        Me.CodProdutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeProdutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoProdutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CustoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreçovendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProduto = New TCC.DataSetProduto()
        Me.btnok = New System.Windows.Forms.Button()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBProdutosTableAdapter = New TCC.DataSetProdutoTableAdapters.TBProdutosTableAdapter()
        CType(Me.DataGridProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridProd
        '
        Me.DataGridProd.AllowUserToDeleteRows = False
        Me.DataGridProd.AutoGenerateColumns = False
        Me.DataGridProd.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DataGridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridProd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodProdutoDataGridViewTextBoxColumn, Me.NomeProdutoDataGridViewTextBoxColumn, Me.TipoProdutoDataGridViewTextBoxColumn, Me.UnidadeDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.CustoDataGridViewTextBoxColumn, Me.PreçovendaDataGridViewTextBoxColumn, Me.QuantidadeDataGridViewTextBoxColumn})
        Me.DataGridProd.DataSource = Me.TBProdutosBindingSource
        Me.DataGridProd.Location = New System.Drawing.Point(16, 79)
        Me.DataGridProd.Name = "DataGridProd"
        Me.DataGridProd.ReadOnly = True
        Me.DataGridProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridProd.Size = New System.Drawing.Size(344, 213)
        Me.DataGridProd.TabIndex = 112
        '
        'CodProdutoDataGridViewTextBoxColumn
        '
        Me.CodProdutoDataGridViewTextBoxColumn.DataPropertyName = "Cod_Produto"
        Me.CodProdutoDataGridViewTextBoxColumn.HeaderText = "Cod_Produto"
        Me.CodProdutoDataGridViewTextBoxColumn.Name = "CodProdutoDataGridViewTextBoxColumn"
        Me.CodProdutoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeProdutoDataGridViewTextBoxColumn
        '
        Me.NomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "Nome_Produto"
        Me.NomeProdutoDataGridViewTextBoxColumn.HeaderText = "Nome_Produto"
        Me.NomeProdutoDataGridViewTextBoxColumn.Name = "NomeProdutoDataGridViewTextBoxColumn"
        Me.NomeProdutoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoProdutoDataGridViewTextBoxColumn
        '
        Me.TipoProdutoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Produto"
        Me.TipoProdutoDataGridViewTextBoxColumn.HeaderText = "Tipo_Produto"
        Me.TipoProdutoDataGridViewTextBoxColumn.Name = "TipoProdutoDataGridViewTextBoxColumn"
        Me.TipoProdutoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnidadeDataGridViewTextBoxColumn
        '
        Me.UnidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade"
        Me.UnidadeDataGridViewTextBoxColumn.HeaderText = "Unidade"
        Me.UnidadeDataGridViewTextBoxColumn.Name = "UnidadeDataGridViewTextBoxColumn"
        Me.UnidadeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        Me.StatusDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'CustoDataGridViewTextBoxColumn
        '
        Me.CustoDataGridViewTextBoxColumn.DataPropertyName = "Custo"
        Me.CustoDataGridViewTextBoxColumn.HeaderText = "Custo"
        Me.CustoDataGridViewTextBoxColumn.Name = "CustoDataGridViewTextBoxColumn"
        Me.CustoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PreçovendaDataGridViewTextBoxColumn
        '
        Me.PreçovendaDataGridViewTextBoxColumn.DataPropertyName = "preço_venda"
        Me.PreçovendaDataGridViewTextBoxColumn.HeaderText = "preço_venda"
        Me.PreçovendaDataGridViewTextBoxColumn.Name = "PreçovendaDataGridViewTextBoxColumn"
        Me.PreçovendaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantidadeDataGridViewTextBoxColumn
        '
        Me.QuantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade"
        Me.QuantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade"
        Me.QuantidadeDataGridViewTextBoxColumn.Name = "QuantidadeDataGridViewTextBoxColumn"
        Me.QuantidadeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBProdutosBindingSource
        '
        Me.TBProdutosBindingSource.DataMember = "TBProdutos"
        Me.TBProdutosBindingSource.DataSource = Me.DataSetProduto
        '
        'DataSetProduto
        '
        Me.DataSetProduto.DataSetName = "DataSetProduto"
        Me.DataSetProduto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnok.ForeColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(309, 298)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(51, 28)
        Me.btnok.TabIndex = 111
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'txtnome
        '
        Me.txtnome.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.Location = New System.Drawing.Point(16, 51)
        Me.txtnome.MaxLength = 100
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(344, 22)
        Me.txtnome.TabIndex = 110
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 19)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Consulta de Produto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(350, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "X"
        '
        'TBProdutosTableAdapter
        '
        Me.TBProdutosTableAdapter.ClearBeforeFill = True
        '
        'FrmPesqProdVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.ClientSize = New System.Drawing.Size(376, 336)
        Me.Controls.Add(Me.DataGridProd)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPesqProdVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPesqProdVendas"
        CType(Me.DataGridProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridProd As System.Windows.Forms.DataGridView
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataSetProduto As TCC.DataSetProduto
    Friend WithEvents TBProdutosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBProdutosTableAdapter As TCC.DataSetProdutoTableAdapters.TBProdutosTableAdapter
    Friend WithEvents CodProdutoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeProdutoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoProdutoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CustoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreçovendaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
