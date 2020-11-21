<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesqProdPA
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
        Me.DataGridProdPA = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CodProdutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeProdutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProduto = New TCC.DataSetProduto()
        Me.TBProdutosTableAdapter = New TCC.DataSetProdutoTableAdapters.TBProdutosTableAdapter()
        CType(Me.DataGridProdPA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridProdPA
        '
        Me.DataGridProdPA.AllowUserToDeleteRows = False
        Me.DataGridProdPA.AutoGenerateColumns = False
        Me.DataGridProdPA.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DataGridProdPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridProdPA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodProdutoDataGridViewTextBoxColumn, Me.NomeProdutoDataGridViewTextBoxColumn, Me.UnidadeDataGridViewTextBoxColumn})
        Me.DataGridProdPA.DataSource = Me.TBProdutosBindingSource
        Me.DataGridProdPA.Location = New System.Drawing.Point(12, 83)
        Me.DataGridProdPA.Name = "DataGridProdPA"
        Me.DataGridProdPA.ReadOnly = True
        Me.DataGridProdPA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridProdPA.Size = New System.Drawing.Size(347, 213)
        Me.DataGridProdPA.TabIndex = 110
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(352, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "X"
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnOk.ForeColor = System.Drawing.Color.White
        Me.BtnOk.Location = New System.Drawing.Point(308, 302)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(51, 28)
        Me.BtnOk.TabIndex = 108
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'txtnome
        '
        Me.txtnome.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.Location = New System.Drawing.Point(12, 55)
        Me.txtnome.MaxLength = 100
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(347, 22)
        Me.txtnome.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 19)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Consulta de Produtos Acabados"
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
        'UnidadeDataGridViewTextBoxColumn
        '
        Me.UnidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade"
        Me.UnidadeDataGridViewTextBoxColumn.HeaderText = "Unidade"
        Me.UnidadeDataGridViewTextBoxColumn.Name = "UnidadeDataGridViewTextBoxColumn"
        Me.UnidadeDataGridViewTextBoxColumn.ReadOnly = True
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
        'TBProdutosTableAdapter
        '
        Me.TBProdutosTableAdapter.ClearBeforeFill = True
        '
        'FrmPesqProdPA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.ClientSize = New System.Drawing.Size(378, 354)
        Me.Controls.Add(Me.DataGridProdPA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPesqProdPA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPesqProdPA"
        CType(Me.DataGridProdPA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridProdPA As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSetProduto As TCC.DataSetProduto
    Friend WithEvents TBProdutosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBProdutosTableAdapter As TCC.DataSetProdutoTableAdapters.TBProdutosTableAdapter
    Friend WithEvents CodProdutoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeProdutoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
