<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesqEst
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
        Me.DataGridEst = New System.Windows.Forms.DataGridView()
        Me.CodEstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeEstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBEstruturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetEst = New TCC.DataSetEst()
        Me.TBEstruturaTableAdapter = New TCC.DataSetEstTableAdapters.TBEstruturaTableAdapter()
        CType(Me.DataGridEst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBEstruturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEst, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(176, 19)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Consulta de Estrutura"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(344, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "X"
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnok.ForeColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(308, 298)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(51, 28)
        Me.btnok.TabIndex = 92
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
        Me.txtnome.TabIndex = 91
        '
        'DataGridEst
        '
        Me.DataGridEst.AllowUserToDeleteRows = False
        Me.DataGridEst.AutoGenerateColumns = False
        Me.DataGridEst.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DataGridEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodEstDataGridViewTextBoxColumn, Me.NomeEstDataGridViewTextBoxColumn})
        Me.DataGridEst.DataSource = Me.TBEstruturaBindingSource
        Me.DataGridEst.Location = New System.Drawing.Point(16, 79)
        Me.DataGridEst.Name = "DataGridEst"
        Me.DataGridEst.ReadOnly = True
        Me.DataGridEst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridEst.Size = New System.Drawing.Size(344, 213)
        Me.DataGridEst.TabIndex = 93
        '
        'CodEstDataGridViewTextBoxColumn
        '
        Me.CodEstDataGridViewTextBoxColumn.DataPropertyName = "Cod_Est"
        Me.CodEstDataGridViewTextBoxColumn.HeaderText = "Cod_Est"
        Me.CodEstDataGridViewTextBoxColumn.Name = "CodEstDataGridViewTextBoxColumn"
        Me.CodEstDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeEstDataGridViewTextBoxColumn
        '
        Me.NomeEstDataGridViewTextBoxColumn.DataPropertyName = "Nome_Est"
        Me.NomeEstDataGridViewTextBoxColumn.HeaderText = "Nome_Est"
        Me.NomeEstDataGridViewTextBoxColumn.Name = "NomeEstDataGridViewTextBoxColumn"
        Me.NomeEstDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomeEstDataGridViewTextBoxColumn.Width = 200
        '
        'TBEstruturaBindingSource
        '
        Me.TBEstruturaBindingSource.DataMember = "TBEstrutura"
        Me.TBEstruturaBindingSource.DataSource = Me.DataSetEst
        '
        'DataSetEst
        '
        Me.DataSetEst.DataSetName = "DataSetEst"
        Me.DataSetEst.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBEstruturaTableAdapter
        '
        Me.TBEstruturaTableAdapter.ClearBeforeFill = True
        '
        'FrmPesqEst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.ClientSize = New System.Drawing.Size(371, 342)
        Me.Controls.Add(Me.DataGridEst)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPesqEst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPesqEst"
        CType(Me.DataGridEst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBEstruturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents DataGridEst As System.Windows.Forms.DataGridView
    Friend WithEvents DataSetEst As TCC.DataSetEst
    Friend WithEvents TBEstruturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBEstruturaTableAdapter As TCC.DataSetEstTableAdapters.TBEstruturaTableAdapter
    Friend WithEvents CodEstDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeEstDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
