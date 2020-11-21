<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesqCliVendas
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
        Me.DataGridCli = New System.Windows.Forms.DataGridView()
        Me.CodClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCliente = New TCC.DataSetCliente()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnok = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.TBClientesTableAdapter = New TCC.DataSetClienteTableAdapters.TBClientesTableAdapter()
        CType(Me.DataGridCli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridCli
        '
        Me.DataGridCli.AllowUserToDeleteRows = False
        Me.DataGridCli.AutoGenerateColumns = False
        Me.DataGridCli.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DataGridCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodClienteDataGridViewTextBoxColumn, Me.NomeCompletoDataGridViewTextBoxColumn, Me.CPFDataGridViewTextBoxColumn})
        Me.DataGridCli.DataSource = Me.TBClientesBindingSource
        Me.DataGridCli.Location = New System.Drawing.Point(12, 83)
        Me.DataGridCli.Name = "DataGridCli"
        Me.DataGridCli.ReadOnly = True
        Me.DataGridCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridCli.Size = New System.Drawing.Size(347, 213)
        Me.DataGridCli.TabIndex = 94
        '
        'CodClienteDataGridViewTextBoxColumn
        '
        Me.CodClienteDataGridViewTextBoxColumn.DataPropertyName = "Cod_Cliente"
        Me.CodClienteDataGridViewTextBoxColumn.HeaderText = "Cod_Cliente"
        Me.CodClienteDataGridViewTextBoxColumn.Name = "CodClienteDataGridViewTextBoxColumn"
        Me.CodClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeCompletoDataGridViewTextBoxColumn
        '
        Me.NomeCompletoDataGridViewTextBoxColumn.DataPropertyName = "Nome_Completo"
        Me.NomeCompletoDataGridViewTextBoxColumn.HeaderText = "Nome_Completo"
        Me.NomeCompletoDataGridViewTextBoxColumn.Name = "NomeCompletoDataGridViewTextBoxColumn"
        Me.NomeCompletoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CPFDataGridViewTextBoxColumn
        '
        Me.CPFDataGridViewTextBoxColumn.DataPropertyName = "CPF"
        Me.CPFDataGridViewTextBoxColumn.HeaderText = "CPF"
        Me.CPFDataGridViewTextBoxColumn.Name = "CPFDataGridViewTextBoxColumn"
        Me.CPFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBClientesBindingSource
        '
        Me.TBClientesBindingSource.DataMember = "TBClientes"
        Me.TBClientesBindingSource.DataSource = Me.DataSetCliente
        '
        'DataSetCliente
        '
        Me.DataSetCliente.DataSetName = "DataSetCliente"
        Me.DataSetCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 19)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Consulta de Clientes por Nome"
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnok.ForeColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(308, 302)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(51, 28)
        Me.btnok.TabIndex = 92
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
        Me.Label6.Location = New System.Drawing.Point(346, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "X"
        '
        'txtnome
        '
        Me.txtnome.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.Location = New System.Drawing.Point(15, 55)
        Me.txtnome.MaxLength = 100
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(344, 22)
        Me.txtnome.TabIndex = 90
        '
        'TBClientesTableAdapter
        '
        Me.TBClientesTableAdapter.ClearBeforeFill = True
        '
        'FrmPesqCliVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.ClientSize = New System.Drawing.Size(372, 344)
        Me.Controls.Add(Me.DataGridCli)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPesqCliVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPesqCliVendas"
        CType(Me.DataGridCli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridCli As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents DataSetCliente As TCC.DataSetCliente
    Friend WithEvents TBClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBClientesTableAdapter As TCC.DataSetClienteTableAdapters.TBClientesTableAdapter
    Friend WithEvents CodClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeCompletoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
