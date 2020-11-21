<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesqMensagemWEBSITE
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridMsg = New System.Windows.Forms.DataGridView()
        Me.TBMSGBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBfaleconoscoMaiscaféDataSet = New TCC.TBfaleconoscoMaiscaféDataSet()
        Me.btnok = New System.Windows.Forms.Button()
        Me.TBMSGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBMSGTableAdapter = New TCC.TBfaleconoscoMaiscaféDataSetTableAdapters.TBMSGTableAdapter()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssuntoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridMsg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBMSGBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBfaleconoscoMaiscaféDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBMSGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 19)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Consulta de Mensagens - WEBSITE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(446, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "X"
        '
        'DataGridMsg
        '
        Me.DataGridMsg.AllowUserToDeleteRows = False
        Me.DataGridMsg.AutoGenerateColumns = False
        Me.DataGridMsg.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridMsg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridMsg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMsg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.NomeDataGridViewTextBoxColumn, Me.AssuntoDataGridViewTextBoxColumn})
        Me.DataGridMsg.DataSource = Me.TBMSGBindingSource1
        Me.DataGridMsg.Location = New System.Drawing.Point(13, 51)
        Me.DataGridMsg.Name = "DataGridMsg"
        Me.DataGridMsg.ReadOnly = True
        Me.DataGridMsg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMsg.Size = New System.Drawing.Size(445, 179)
        Me.DataGridMsg.TabIndex = 94
        '
        'TBMSGBindingSource1
        '
        Me.TBMSGBindingSource1.DataMember = "TBMSG"
        Me.TBMSGBindingSource1.DataSource = Me.TBfaleconoscoMaiscaféDataSet
        '
        'TBfaleconoscoMaiscaféDataSet
        '
        Me.TBfaleconoscoMaiscaféDataSet.DataSetName = "TBfaleconoscoMaiscaféDataSet"
        Me.TBfaleconoscoMaiscaféDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnok.ForeColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(407, 242)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(51, 28)
        Me.btnok.TabIndex = 192
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'TBMSGBindingSource
        '
        Me.TBMSGBindingSource.DataMember = "TBMSG"
        Me.TBMSGBindingSource.DataSource = Me.TBfaleconoscoMaiscaféDataSet
        '
        'TBMSGTableAdapter
        '
        Me.TBMSGTableAdapter.ClearBeforeFill = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "codmsg"
        Me.Column1.HeaderText = "Cod Mensagem"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 163
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        Me.NomeDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomeDataGridViewTextBoxColumn.Width = 200
        '
        'AssuntoDataGridViewTextBoxColumn
        '
        Me.AssuntoDataGridViewTextBoxColumn.DataPropertyName = "assunto"
        Me.AssuntoDataGridViewTextBoxColumn.HeaderText = "Assunto"
        Me.AssuntoDataGridViewTextBoxColumn.Name = "AssuntoDataGridViewTextBoxColumn"
        Me.AssuntoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AssuntoDataGridViewTextBoxColumn.Width = 200
        '
        'FrmPesqMensagemWEBSITE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(472, 309)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.DataGridMsg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPesqMensagemWEBSITE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmFaleConoscoWebsite"
        CType(Me.DataGridMsg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBMSGBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBfaleconoscoMaiscaféDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBMSGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridMsg As System.Windows.Forms.DataGridView
    Friend WithEvents TBfaleconoscoMaiscaféDataSet As TCC.TBfaleconoscoMaiscaféDataSet
    Friend WithEvents TBMSGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBMSGTableAdapter As TCC.TBfaleconoscoMaiscaféDataSetTableAdapters.TBMSGTableAdapter
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents TBMSGBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssuntoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
