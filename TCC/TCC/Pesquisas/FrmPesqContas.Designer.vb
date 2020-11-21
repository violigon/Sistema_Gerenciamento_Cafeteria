<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesqContas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridContas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.btnok = New System.Windows.Forms.Button()
        Me.pbapaga = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridContas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbapaga, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(160, 19)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Consulta de Contas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(516, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "X"
        '
        'DataGridContas
        '
        Me.DataGridContas.AllowUserToDeleteRows = False
        Me.DataGridContas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DataGridContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridContas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridContas.Location = New System.Drawing.Point(12, 109)
        Me.DataGridContas.Name = "DataGridContas"
        Me.DataGridContas.ReadOnly = True
        Me.DataGridContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridContas.Size = New System.Drawing.Size(518, 208)
        Me.DataGridContas.TabIndex = 173
        '
        'Column1
        '
        Me.Column1.HeaderText = "Cód Compra"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Descrição"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 170
        '
        'Column4
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column4.HeaderText = "Saldo"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Vencimento"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'CalendarFim
        '
        Me.CalendarFim.Location = New System.Drawing.Point(303, 99)
        Me.CalendarFim.Name = "CalendarFim"
        Me.CalendarFim.TabIndex = 187
        Me.CalendarFim.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.TCC.My.Resources.Resources.calendar_icon1_300x275
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(374, 67)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 25)
        Me.Button4.TabIndex = 190
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'CalendarInicio
        '
        Me.CalendarInicio.Location = New System.Drawing.Point(211, 99)
        Me.CalendarInicio.Name = "CalendarInicio"
        Me.CalendarInicio.TabIndex = 185
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
        Me.Button3.Location = New System.Drawing.Point(374, 67)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 25)
        Me.Button3.TabIndex = 189
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.TCC.My.Resources.Resources.calendar_icon1_300x275
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(211, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 188
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
        Me.Button1.Location = New System.Drawing.Point(211, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 186
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pbok
        '
        Me.pbok.BackColor = System.Drawing.Color.Transparent
        Me.pbok.BackgroundImage = Global.TCC.My.Resources.Resources.Ok3D
        Me.pbok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbok.Location = New System.Drawing.Point(490, 64)
        Me.pbok.Name = "pbok"
        Me.pbok.Size = New System.Drawing.Size(25, 24)
        Me.pbok.TabIndex = 184
        Me.pbok.TabStop = False
        '
        'mskfim
        '
        Me.mskfim.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskfim.Location = New System.Drawing.Point(291, 70)
        Me.mskfim.Mask = "00/00/0000"
        Me.mskfim.Name = "mskfim"
        Me.mskfim.Size = New System.Drawing.Size(77, 22)
        Me.mskfim.TabIndex = 2
        Me.mskfim.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(288, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 18)
        Me.Label3.TabIndex = 182
        Me.Label3.Text = "Vencimento até: "
        '
        'mskdinicio
        '
        Me.mskdinicio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskdinicio.Location = New System.Drawing.Point(128, 70)
        Me.mskdinicio.Mask = "00/00/0000"
        Me.mskdinicio.Name = "mskdinicio"
        Me.mskdinicio.Size = New System.Drawing.Size(77, 22)
        Me.mskdinicio.TabIndex = 1
        Me.mskdinicio.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(125, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 18)
        Me.Label4.TabIndex = 180
        Me.Label4.Text = "Vencimento de: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "Status:"
        '
        'cbostatus
        '
        Me.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"Todos", "Pagos", "Em Aberto"})
        Me.cbostatus.Location = New System.Drawing.Point(12, 70)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.Size = New System.Drawing.Size(89, 21)
        Me.cbostatus.TabIndex = 178
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnok.ForeColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(479, 340)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(51, 28)
        Me.btnok.TabIndex = 191
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'pbapaga
        '
        Me.pbapaga.BackColor = System.Drawing.Color.Transparent
        Me.pbapaga.BackgroundImage = Global.TCC.My.Resources.Resources.Ok3D
        Me.pbapaga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbapaga.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbapaga.Location = New System.Drawing.Point(490, 63)
        Me.pbapaga.Name = "pbapaga"
        Me.pbapaga.Size = New System.Drawing.Size(25, 24)
        Me.pbapaga.TabIndex = 192
        Me.pbapaga.TabStop = False
        Me.pbapaga.Visible = False
        '
        'FrmPesqContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.ClientSize = New System.Drawing.Size(542, 421)
        Me.Controls.Add(Me.pbapaga)
        Me.Controls.Add(Me.btnok)
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
        Me.Controls.Add(Me.DataGridContas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPesqContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPesqContas"
        CType(Me.DataGridContas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbapaga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridContas As System.Windows.Forms.DataGridView
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
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents pbapaga As System.Windows.Forms.PictureBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
