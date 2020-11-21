<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadCli
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
        Me.pbcad = New System.Windows.Forms.PictureBox()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbconsulta = New System.Windows.Forms.PictureBox()
        Me.btnlimpar = New System.Windows.Forms.Button()
        Me.pbedit = New System.Windows.Forms.PictureBox()
        Me.pbdelete = New System.Windows.Forms.PictureBox()
        Me.BdMaisCafeDataSet1 = New TCC.DataSetCliente()
        Me.btnaltera = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbostatus = New System.Windows.Forms.ComboBox()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.txtcodcli = New System.Windows.Forms.TextBox()
        Me.lblcodcli = New System.Windows.Forms.Label()
        Me.cbosexo = New System.Windows.Forms.ComboBox()
        Me.mskdtnasc = New System.Windows.Forms.MaskedTextBox()
        Me.mskcpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CalendarInicio = New System.Windows.Forms.MonthCalendar()
        CType(Me.pbcad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbconsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbedit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdMaisCafeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbcad
        '
        Me.pbcad.BackColor = System.Drawing.Color.Transparent
        Me.pbcad.BackgroundImage = Global.TCC.My.Resources.Resources.iconcadastro1
        Me.pbcad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbcad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbcad.Location = New System.Drawing.Point(12, 48)
        Me.pbcad.Name = "pbcad"
        Me.pbcad.Size = New System.Drawing.Size(42, 45)
        Me.pbcad.TabIndex = 6
        Me.pbcad.TabStop = False
        '
        'btnsalvar
        '
        Me.btnsalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalvar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalvar.ForeColor = System.Drawing.Color.White
        Me.btnsalvar.Location = New System.Drawing.Point(317, 346)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(102, 28)
        Me.btnsalvar.TabIndex = 9
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(405, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "X"
        '
        'pbconsulta
        '
        Me.pbconsulta.BackColor = System.Drawing.Color.Transparent
        Me.pbconsulta.BackgroundImage = Global.TCC.My.Resources.Resources.pesquisa
        Me.pbconsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbconsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbconsulta.Location = New System.Drawing.Point(60, 48)
        Me.pbconsulta.Name = "pbconsulta"
        Me.pbconsulta.Size = New System.Drawing.Size(42, 45)
        Me.pbconsulta.TabIndex = 20
        Me.pbconsulta.TabStop = False
        '
        'btnlimpar
        '
        Me.btnlimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpar.ForeColor = System.Drawing.Color.White
        Me.btnlimpar.Location = New System.Drawing.Point(209, 346)
        Me.btnlimpar.Name = "btnlimpar"
        Me.btnlimpar.Size = New System.Drawing.Size(102, 28)
        Me.btnlimpar.TabIndex = 21
        Me.btnlimpar.Text = "Limpar"
        Me.btnlimpar.UseVisualStyleBackColor = False
        '
        'pbedit
        '
        Me.pbedit.BackColor = System.Drawing.Color.Transparent
        Me.pbedit.BackgroundImage = Global.TCC.My.Resources.Resources.editicon2
        Me.pbedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbedit.Location = New System.Drawing.Point(113, 48)
        Me.pbedit.Name = "pbedit"
        Me.pbedit.Size = New System.Drawing.Size(42, 45)
        Me.pbedit.TabIndex = 22
        Me.pbedit.TabStop = False
        '
        'pbdelete
        '
        Me.pbdelete.BackColor = System.Drawing.Color.Transparent
        Me.pbdelete.BackgroundImage = Global.TCC.My.Resources.Resources.Delete
        Me.pbdelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbdelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbdelete.Location = New System.Drawing.Point(161, 48)
        Me.pbdelete.Name = "pbdelete"
        Me.pbdelete.Size = New System.Drawing.Size(42, 45)
        Me.pbdelete.TabIndex = 23
        Me.pbdelete.TabStop = False
        '
        'BdMaisCafeDataSet1
        '
        Me.BdMaisCafeDataSet1.DataSetName = "BDMaisCafeDataSet"
        Me.BdMaisCafeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnaltera
        '
        Me.btnaltera.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnaltera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaltera.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaltera.ForeColor = System.Drawing.Color.White
        Me.btnaltera.Location = New System.Drawing.Point(317, 346)
        Me.btnaltera.Name = "btnaltera"
        Me.btnaltera.Size = New System.Drawing.Size(102, 28)
        Me.btnaltera.TabIndex = 24
        Me.btnaltera.Text = "Alterar"
        Me.btnaltera.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 19)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Cadastro de Clientes"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cbostatus)
        Me.GroupBox1.Controls.Add(Me.lblstatus)
        Me.GroupBox1.Controls.Add(Me.txtcodcli)
        Me.GroupBox1.Controls.Add(Me.lblcodcli)
        Me.GroupBox1.Controls.Add(Me.cbosexo)
        Me.GroupBox1.Controls.Add(Me.mskdtnasc)
        Me.GroupBox1.Controls.Add(Me.mskcpf)
        Me.GroupBox1.Controls.Add(Me.txtnome)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(16, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 230)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Cliente"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.TCC.My.Resources.Resources.calendar_icon1_300x275
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(254, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 208
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
        Me.Button1.Location = New System.Drawing.Point(254, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 207
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbostatus
        '
        Me.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"Ativo", "Inativo"})
        Me.cbostatus.Location = New System.Drawing.Point(81, 180)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.Size = New System.Drawing.Size(111, 24)
        Me.cbostatus.TabIndex = 7
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.BackColor = System.Drawing.Color.Transparent
        Me.lblstatus.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.Color.White
        Me.lblstatus.Location = New System.Drawing.Point(16, 184)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(61, 18)
        Me.lblstatus.TabIndex = 31
        Me.lblstatus.Text = "Status: "
        '
        'txtcodcli
        '
        Me.txtcodcli.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodcli.Location = New System.Drawing.Point(80, 26)
        Me.txtcodcli.Name = "txtcodcli"
        Me.txtcodcli.ReadOnly = True
        Me.txtcodcli.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcodcli.Size = New System.Drawing.Size(100, 22)
        Me.txtcodcli.TabIndex = 1
        '
        'lblcodcli
        '
        Me.lblcodcli.AutoSize = True
        Me.lblcodcli.BackColor = System.Drawing.Color.Transparent
        Me.lblcodcli.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodcli.ForeColor = System.Drawing.Color.White
        Me.lblcodcli.Location = New System.Drawing.Point(17, 28)
        Me.lblcodcli.Name = "lblcodcli"
        Me.lblcodcli.Size = New System.Drawing.Size(63, 18)
        Me.lblcodcli.TabIndex = 29
        Me.lblcodcli.Text = "Código:"
        '
        'cbosexo
        '
        Me.cbosexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosexo.Enabled = False
        Me.cbosexo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosexo.FormattingEnabled = True
        Me.cbosexo.Items.AddRange(New Object() {"Masculino" & Global.Microsoft.VisualBasic.ChrW(9), "Feminino"})
        Me.cbosexo.Location = New System.Drawing.Point(259, 87)
        Me.cbosexo.Name = "cbosexo"
        Me.cbosexo.Size = New System.Drawing.Size(111, 24)
        Me.cbosexo.TabIndex = 3
        '
        'mskdtnasc
        '
        Me.mskdtnasc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskdtnasc.Location = New System.Drawing.Point(172, 118)
        Me.mskdtnasc.Mask = "00/00/0000"
        Me.mskdtnasc.Name = "mskdtnasc"
        Me.mskdtnasc.ReadOnly = True
        Me.mskdtnasc.Size = New System.Drawing.Size(77, 22)
        Me.mskdtnasc.TabIndex = 4
        Me.mskdtnasc.ValidatingType = GetType(Date)
        '
        'mskcpf
        '
        Me.mskcpf.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskcpf.Location = New System.Drawing.Point(80, 88)
        Me.mskcpf.Mask = "000,000,000-00"
        Me.mskcpf.Name = "mskcpf"
        Me.mskcpf.ReadOnly = True
        Me.mskcpf.Size = New System.Drawing.Size(100, 22)
        Me.mskcpf.TabIndex = 3
        Me.mskcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtnome
        '
        Me.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnome.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.Location = New System.Drawing.Point(80, 57)
        Me.txtnome.MaxLength = 100
        Me.txtnome.Name = "txtnome"
        Me.txtnome.ReadOnly = True
        Me.txtnome.Size = New System.Drawing.Size(290, 22)
        Me.txtnome.TabIndex = 2
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(81, 149)
        Me.txtemail.MaxLength = 50
        Me.txtemail.Name = "txtemail"
        Me.txtemail.ReadOnly = True
        Me.txtemail.Size = New System.Drawing.Size(290, 22)
        Me.txtemail.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(17, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "E-mail: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(194, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 18)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Sexo: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "CPF: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Data de Nascimento: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nome: "
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CalendarInicio
        '
        Me.CalendarInicio.Location = New System.Drawing.Point(192, 47)
        Me.CalendarInicio.Name = "CalendarInicio"
        Me.CalendarInicio.TabIndex = 209
        Me.CalendarInicio.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CalendarInicio.Visible = False
        '
        'FrmCadCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.ClientSize = New System.Drawing.Size(431, 413)
        Me.Controls.Add(Me.CalendarInicio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnaltera)
        Me.Controls.Add(Me.pbdelete)
        Me.Controls.Add(Me.pbedit)
        Me.Controls.Add(Me.btnlimpar)
        Me.Controls.Add(Me.pbconsulta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.pbcad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCadCli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadCli"
        CType(Me.pbcad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbconsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbedit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbdelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdMaisCafeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbcad As System.Windows.Forms.PictureBox
    Friend WithEvents btnsalvar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pbconsulta As System.Windows.Forms.PictureBox
    Friend WithEvents btnlimpar As System.Windows.Forms.Button
    Friend WithEvents pbedit As System.Windows.Forms.PictureBox
    Friend WithEvents pbdelete As System.Windows.Forms.PictureBox
    Friend WithEvents BdMaisCafeDataSet1 As TCC.DataSetCliente
    Friend WithEvents btnaltera As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcodcli As System.Windows.Forms.TextBox
    Friend WithEvents lblcodcli As System.Windows.Forms.Label
    Friend WithEvents cbosexo As System.Windows.Forms.ComboBox
    Friend WithEvents mskdtnasc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskcpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents cbostatus As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CalendarInicio As System.Windows.Forms.MonthCalendar
End Class
