<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelatorios
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.RelProdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetRelProd = New TCC.DataSetRelProd()
        Me.rbtprod = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbtvendas = New System.Windows.Forms.RadioButton()
        Me.ReportProdutos = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportVenda = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbtcompras = New System.Windows.Forms.RadioButton()
        Me.RelProdTableAdapter = New TCC.DataSetRelProdTableAdapters.RelProdTableAdapter()
        Me.ReportCompras = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetViewRelCompras = New TCC.DataSetViewRelCompras()
        Me.RelComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RelComprasTableAdapter = New TCC.DataSetViewRelComprasTableAdapters.RelComprasTableAdapter()
        Me.DataSetRelVendas = New TCC.DataSetRelVendas()
        Me.RelVendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RelVendasTableAdapter = New TCC.DataSetRelVendasTableAdapters.RelVendasTableAdapter()
        CType(Me.RelProdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetRelProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetViewRelCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RelComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetRelVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RelVendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RelProdBindingSource
        '
        Me.RelProdBindingSource.DataMember = "RelProd"
        Me.RelProdBindingSource.DataSource = Me.DataSetRelProd
        '
        'DataSetRelProd
        '
        Me.DataSetRelProd.DataSetName = "DataSetRelProd"
        Me.DataSetRelProd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rbtprod
        '
        Me.rbtprod.AutoSize = True
        Me.rbtprod.BackColor = System.Drawing.Color.Transparent
        Me.rbtprod.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtprod.ForeColor = System.Drawing.Color.White
        Me.rbtprod.Location = New System.Drawing.Point(494, 65)
        Me.rbtprod.Name = "rbtprod"
        Me.rbtprod.Size = New System.Drawing.Size(121, 28)
        Me.rbtprod.TabIndex = 46
        Me.rbtprod.Text = "Produtos"
        Me.rbtprod.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Lucida Handwriting", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 33)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = " + Café -"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(146, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 30)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Relatórios"
        '
        'rbtvendas
        '
        Me.rbtvendas.AutoSize = True
        Me.rbtvendas.BackColor = System.Drawing.Color.Transparent
        Me.rbtvendas.Checked = True
        Me.rbtvendas.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtvendas.ForeColor = System.Drawing.Color.White
        Me.rbtvendas.Location = New System.Drawing.Point(356, 65)
        Me.rbtvendas.Name = "rbtvendas"
        Me.rbtvendas.Size = New System.Drawing.Size(102, 28)
        Me.rbtvendas.TabIndex = 49
        Me.rbtvendas.TabStop = True
        Me.rbtvendas.Text = "Vendas"
        Me.rbtvendas.UseVisualStyleBackColor = False
        '
        'ReportProdutos
        '
        Me.ReportProdutos.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.RelProdBindingSource
        Me.ReportProdutos.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportProdutos.LocalReport.ReportEmbeddedResource = "TCC.ReportProd.rdlc"
        Me.ReportProdutos.Location = New System.Drawing.Point(25, 107)
        Me.ReportProdutos.Name = "ReportProdutos"
        Me.ReportProdutos.Size = New System.Drawing.Size(966, 435)
        Me.ReportProdutos.TabIndex = 50
        Me.ReportProdutos.Visible = False
        '
        'ReportVenda
        '
        Me.ReportVenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.RelVendasBindingSource
        Me.ReportVenda.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportVenda.LocalReport.ReportEmbeddedResource = "TCC.ReportVenda.rdlc"
        Me.ReportVenda.Location = New System.Drawing.Point(25, 117)
        Me.ReportVenda.Name = "ReportVenda"
        Me.ReportVenda.Size = New System.Drawing.Size(966, 435)
        Me.ReportVenda.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(968, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "X"
        '
        'rbtcompras
        '
        Me.rbtcompras.AutoSize = True
        Me.rbtcompras.BackColor = System.Drawing.Color.Transparent
        Me.rbtcompras.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtcompras.ForeColor = System.Drawing.Color.White
        Me.rbtcompras.Location = New System.Drawing.Point(650, 65)
        Me.rbtcompras.Name = "rbtcompras"
        Me.rbtcompras.Size = New System.Drawing.Size(120, 28)
        Me.rbtcompras.TabIndex = 93
        Me.rbtcompras.Text = "Compras"
        Me.rbtcompras.UseVisualStyleBackColor = False
        '
        'RelProdTableAdapter
        '
        Me.RelProdTableAdapter.ClearBeforeFill = True
        '
        'ReportCompras
        '
        Me.ReportCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.RelComprasBindingSource
        Me.ReportCompras.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportCompras.LocalReport.ReportEmbeddedResource = "TCC.ReportCompras.rdlc"
        Me.ReportCompras.Location = New System.Drawing.Point(25, 127)
        Me.ReportCompras.Name = "ReportCompras"
        Me.ReportCompras.Size = New System.Drawing.Size(966, 435)
        Me.ReportCompras.TabIndex = 94
        Me.ReportCompras.Visible = False
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
        'DataSetRelVendas
        '
        Me.DataSetRelVendas.DataSetName = "DataSetRelVendas"
        Me.DataSetRelVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RelVendasBindingSource
        '
        Me.RelVendasBindingSource.DataMember = "RelVendas"
        Me.RelVendasBindingSource.DataSource = Me.DataSetRelVendas
        '
        'RelVendasTableAdapter
        '
        Me.RelVendasTableAdapter.ClearBeforeFill = True
        '
        'FrmRelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.TelaVendasMax
        Me.ClientSize = New System.Drawing.Size(1003, 554)
        Me.Controls.Add(Me.ReportCompras)
        Me.Controls.Add(Me.rbtcompras)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ReportVenda)
        Me.Controls.Add(Me.ReportProdutos)
        Me.Controls.Add(Me.rbtvendas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rbtprod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRelatorios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRelatorios"
        CType(Me.RelProdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetRelProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetViewRelCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RelComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetRelVendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RelVendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtprod As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbtvendas As System.Windows.Forms.RadioButton
    Friend WithEvents ReportProdutos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportVenda As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbtcompras As System.Windows.Forms.RadioButton
    Friend WithEvents RelProdBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetRelProd As TCC.DataSetRelProd
    Friend WithEvents RelProdTableAdapter As TCC.DataSetRelProdTableAdapters.RelProdTableAdapter
    Friend WithEvents ReportCompras As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RelComprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetViewRelCompras As TCC.DataSetViewRelCompras
    Friend WithEvents RelComprasTableAdapter As TCC.DataSetViewRelComprasTableAdapters.RelComprasTableAdapter
    Friend WithEvents RelVendasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetRelVendas As TCC.DataSetRelVendas
    Friend WithEvents RelVendasTableAdapter As TCC.DataSetRelVendasTableAdapters.RelVendasTableAdapter
End Class
