<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesqVendas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pbapaga = New System.Windows.Forms.PictureBox()
        Me.CalendarFim = New System.Windows.Forms.MonthCalendar()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CalendarInicio = New System.Windows.Forms.MonthCalendar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pbok = New System.Windows.Forms.PictureBox()
        Me.mskfim = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskdinicio = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbostatus = New System.Windows.Forms.ComboBox()
        Me.DataGridVendas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pbEstorno = New System.Windows.Forms.PictureBox()
        Me.txtcodvenda = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.pbapaga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEstorno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbapaga
        '
        Me.pbapaga.BackColor = System.Drawing.Color.Transparent
        Me.pbapaga.BackgroundImage = Global.TCC.My.Resources.Resources.Ok3D
        Me.pbapaga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbapaga.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbapaga.Location = New System.Drawing.Point(590, 84)
        Me.pbapaga.Name = "pbapaga"
        Me.pbapaga.Size = New System.Drawing.Size(25, 24)
        Me.pbapaga.TabIndex = 210
        Me.pbapaga.TabStop = False
        Me.pbapaga.Visible = False
        '
        'CalendarFim
        '
        Me.CalendarFim.Location = New System.Drawing.Point(334, 103)
        Me.CalendarFim.Name = "CalendarFim"
        Me.CalendarFim.TabIndex = 205
        Me.CalendarFim.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.TCC.My.Resources.Resources.calendar_icon1_300x275
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(536, 85)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 25)
        Me.Button4.TabIndex = 208
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'CalendarInicio
        '
        Me.CalendarInicio.Location = New System.Drawing.Point(171, 103)
        Me.CalendarInicio.Name = "CalendarInicio"
        Me.CalendarInicio.TabIndex = 203
        Me.CalendarInicio.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CalendarInicio.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.TCC.My.Resources.Resources.calendar_icon1_300x275
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(536, 85)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 25)
        Me.Button3.TabIndex = 207
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.TCC.My.Resources.Resources.calendar_icon1_300x275
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(373, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 206
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.TCC.My.Resources.Resources.calendar_icon1_300x2751
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(373, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 204
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pbok
        '
        Me.pbok.BackColor = System.Drawing.Color.Transparent
        Me.pbok.BackgroundImage = Global.TCC.My.Resources.Resources.Ok3D
        Me.pbok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbok.Location = New System.Drawing.Point(590, 84)
        Me.pbok.Name = "pbok"
        Me.pbok.Size = New System.Drawing.Size(25, 24)
        Me.pbok.TabIndex = 202
        Me.pbok.TabStop = False
        '
        'mskfim
        '
        Me.mskfim.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskfim.Location = New System.Drawing.Point(453, 86)
        Me.mskfim.Mask = "00/00/0000"
        Me.mskfim.Name = "mskfim"
        Me.mskfim.Size = New System.Drawing.Size(77, 22)
        Me.mskfim.TabIndex = 194
        Me.mskfim.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(450, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 18)
        Me.Label3.TabIndex = 201
        Me.Label3.Text = "Até: "
        '
        'mskdinicio
        '
        Me.mskdinicio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskdinicio.Location = New System.Drawing.Point(290, 86)
        Me.mskdinicio.Mask = "00/00/0000"
        Me.mskdinicio.Name = "mskdinicio"
        Me.mskdinicio.Size = New System.Drawing.Size(77, 22)
        Me.mskdinicio.TabIndex = 193
        Me.mskdinicio.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(287, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 18)
        Me.Label4.TabIndex = 200
        Me.Label4.Text = "De:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 18)
        Me.Label2.TabIndex = 199
        Me.Label2.Text = "Formas de Pagamento:"
        '
        'cbostatus
        '
        Me.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"Todas", "Dinheiro", "Débito", "Crédito"})
        Me.cbostatus.Location = New System.Drawing.Point(18, 87)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.Size = New System.Drawing.Size(89, 21)
        Me.cbostatus.TabIndex = 198
        '
        'DataGridVendas
        '
        Me.DataGridVendas.AllowUserToDeleteRows = False
        Me.DataGridVendas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DataGridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridVendas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridVendas.Location = New System.Drawing.Point(12, 118)
        Me.DataGridVendas.Name = "DataGridVendas"
        Me.DataGridVendas.ReadOnly = True
        Me.DataGridVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridVendas.Size = New System.Drawing.Size(816, 350)
        Me.DataGridVendas.TabIndex = 197
        '
        'Column1
        '
        Me.Column1.HeaderText = "Cod Venda"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cod Produto"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantidade"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column4.HeaderText = "Valor"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 170
        '
        'Column5
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column5.HeaderText = "Subtotal"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 170
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 19)
        Me.Label1.TabIndex = 196
        Me.Label1.Text = "Consulta de Vendas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(808, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 195
        Me.Label6.Text = "X"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(156, 13)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(80, 37)
        Me.lblTotal.TabIndex = 212
        Me.lblTotal.Text = "0,00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(36, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 22)
        Me.Label5.TabIndex = 211
        Me.Label5.Text = "TOTAL:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(684, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 18)
        Me.Label7.TabIndex = 218
        Me.Label7.Text = "Nº Pedido:"
        '
        'pbEstorno
        '
        Me.pbEstorno.BackColor = System.Drawing.Color.Transparent
        Me.pbEstorno.BackgroundImage = Global.TCC.My.Resources.Resources._return
        Me.pbEstorno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbEstorno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEstorno.Location = New System.Drawing.Point(771, 63)
        Me.pbEstorno.Name = "pbEstorno"
        Me.pbEstorno.Size = New System.Drawing.Size(41, 46)
        Me.pbEstorno.TabIndex = 217
        Me.pbEstorno.TabStop = False
        '
        'txtcodvenda
        '
        Me.txtcodvenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtcodvenda.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodvenda.Location = New System.Drawing.Point(686, 82)
        Me.txtcodvenda.Name = "txtcodvenda"
        Me.txtcodvenda.ReadOnly = True
        Me.txtcodvenda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcodvenda.Size = New System.Drawing.Size(74, 26)
        Me.txtcodvenda.TabIndex = 216
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 469)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(816, 54)
        Me.GroupBox1.TabIndex = 219
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Todas vendas:"
        '
        'FrmPesqVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(840, 584)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pbEstorno)
        Me.Controls.Add(Me.txtcodvenda)
        Me.Controls.Add(Me.pbapaga)
        Me.Controls.Add(Me.CalendarFim)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CalendarInicio)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pbok)
        Me.Controls.Add(Me.mskfim)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mskdinicio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbostatus)
        Me.Controls.Add(Me.DataGridVendas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPesqVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPesqVendas"
        CType(Me.pbapaga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridVendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEstorno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbapaga As System.Windows.Forms.PictureBox
    Friend WithEvents CalendarFim As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CalendarInicio As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pbok As System.Windows.Forms.PictureBox
    Friend WithEvents mskfim As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mskdinicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbostatus As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridVendas As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pbEstorno As System.Windows.Forms.PictureBox
    Friend WithEvents txtcodvenda As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
