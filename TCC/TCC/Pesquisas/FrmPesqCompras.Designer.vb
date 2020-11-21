<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesqCompras
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
        Me.DataGridCompras = New System.Windows.Forms.DataGridView()
        Me.btnok = New System.Windows.Forms.Button()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataSetViewRelCompras = New TCC.DataSetViewRelCompras()
        Me.RelComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RelComprasTableAdapter = New TCC.DataSetViewRelComprasTableAdapters.RelComprasTableAdapter()
        Me.CodCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodProdutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeProdutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetViewRelCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RelComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridCompras
        '
        Me.DataGridCompras.AllowUserToDeleteRows = False
        Me.DataGridCompras.AutoGenerateColumns = False
        Me.DataGridCompras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DataGridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodCompraDataGridViewTextBoxColumn, Me.CodItemDataGridViewTextBoxColumn, Me.CodProdutoDataGridViewTextBoxColumn, Me.NomeProdutoDataGridViewTextBoxColumn, Me.QuantidadeDataGridViewTextBoxColumn, Me.ValorDataGridViewTextBoxColumn})
        Me.DataGridCompras.DataSource = Me.RelComprasBindingSource
        Me.DataGridCompras.Location = New System.Drawing.Point(16, 79)
        Me.DataGridCompras.Name = "DataGridCompras"
        Me.DataGridCompras.ReadOnly = True
        Me.DataGridCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridCompras.Size = New System.Drawing.Size(344, 213)
        Me.DataGridCompras.TabIndex = 102
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
        Me.btnok.TabIndex = 101
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
        Me.txtnome.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 19)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Consulta de Compras por Produto"
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
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "X"
        '
        'DataSetViewRelCompras
        '
        Me.DataSetViewRelCompras.DataSetName = "DataSetViewRelCompras"
        Me.DataSetViewRelCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RelComprasBindingSource
        '
        Me.RelComprasBindingSource.DataMember = "RelCompras"
        Me.RelComprasBindingSource.DataSource = Me.DataSetViewRelCompras
        '
        'RelComprasTableAdapter
        '
        Me.RelComprasTableAdapter.ClearBeforeFill = True
        '
        'CodCompraDataGridViewTextBoxColumn
        '
        Me.CodCompraDataGridViewTextBoxColumn.DataPropertyName = "Cod_Compra"
        Me.CodCompraDataGridViewTextBoxColumn.HeaderText = "Cod_Compra"
        Me.CodCompraDataGridViewTextBoxColumn.Name = "CodCompraDataGridViewTextBoxColumn"
        Me.CodCompraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodItemDataGridViewTextBoxColumn
        '
        Me.CodItemDataGridViewTextBoxColumn.DataPropertyName = "Cod_Item"
        Me.CodItemDataGridViewTextBoxColumn.HeaderText = "Cod_Item"
        Me.CodItemDataGridViewTextBoxColumn.Name = "CodItemDataGridViewTextBoxColumn"
        Me.CodItemDataGridViewTextBoxColumn.ReadOnly = True
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
        'QuantidadeDataGridViewTextBoxColumn
        '
        Me.QuantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade"
        Me.QuantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade"
        Me.QuantidadeDataGridViewTextBoxColumn.Name = "QuantidadeDataGridViewTextBoxColumn"
        Me.QuantidadeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorDataGridViewTextBoxColumn
        '
        Me.ValorDataGridViewTextBoxColumn.DataPropertyName = "Valor"
        Me.ValorDataGridViewTextBoxColumn.HeaderText = "Valor"
        Me.ValorDataGridViewTextBoxColumn.Name = "ValorDataGridViewTextBoxColumn"
        Me.ValorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmPesqCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.ClientSize = New System.Drawing.Size(376, 346)
        Me.Controls.Add(Me.DataGridCompras)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPesqCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPesqCompras"
        CType(Me.DataGridCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetViewRelCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RelComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridCompras As System.Windows.Forms.DataGridView
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataSetViewRelCompras As TCC.DataSetViewRelCompras
    Friend WithEvents RelComprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RelComprasTableAdapter As TCC.DataSetViewRelComprasTableAdapters.RelComprasTableAdapter
    Friend WithEvents CodCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodProdutoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeProdutoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
