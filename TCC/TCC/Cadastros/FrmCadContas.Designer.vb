<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadContas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadContas))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pbcad = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtsaldo = New System.Windows.Forms.TextBox()
        Me.CalendarContasVenc = New System.Windows.Forms.MonthCalendar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mskdtpgto = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.mskdtvenc = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodcompra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnlimpar = New System.Windows.Forms.Button()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.pbdelete = New System.Windows.Forms.PictureBox()
        Me.pbconsulta = New System.Windows.Forms.PictureBox()
        Me.pbpagarconta = New System.Windows.Forms.PictureBox()
        Me.CalendarContasPag = New System.Windows.Forms.MonthCalendar()
        CType(Me.pbcad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbconsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbpagarconta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(600, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 19)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Contas a Pagar"
        '
        'pbcad
        '
        Me.pbcad.BackColor = System.Drawing.Color.Transparent
        Me.pbcad.BackgroundImage = CType(resources.GetObject("pbcad.BackgroundImage"), System.Drawing.Image)
        Me.pbcad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbcad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbcad.Location = New System.Drawing.Point(3, 46)
        Me.pbcad.Name = "pbcad"
        Me.pbcad.Size = New System.Drawing.Size(42, 45)
        Me.pbcad.TabIndex = 156
        Me.pbcad.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtsaldo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.mskdtpgto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtvalor)
        Me.GroupBox1.Controls.Add(Me.mskdtvenc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtdesc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcodcompra)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(601, 113)
        Me.GroupBox1.TabIndex = 157
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Conta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(447, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 18)
        Me.Label10.TabIndex = 177
        Me.Label10.Text = "."
        Me.Label10.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(392, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 18)
        Me.Label9.TabIndex = 176
        Me.Label9.Text = "Status:"
        Me.Label9.Visible = False
        '
        'txtsaldo
        '
        Me.txtsaldo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtsaldo.Location = New System.Drawing.Point(63, 82)
        Me.txtsaldo.Name = "txtsaldo"
        Me.txtsaldo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtsaldo.Size = New System.Drawing.Size(82, 22)
        Me.txtsaldo.TabIndex = 5
        '
        'CalendarContasVenc
        '
        Me.CalendarContasVenc.Location = New System.Drawing.Point(386, 17)
        Me.CalendarContasVenc.Name = "CalendarContasVenc"
        Me.CalendarContasVenc.TabIndex = 164
        Me.CalendarContasVenc.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CalendarContasVenc.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 18)
        Me.Label5.TabIndex = 175
        Me.Label5.Text = "Saldo:"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.TCC.My.Resources.Resources.calendar_icon1_300x275
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(350, 79)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 25)
        Me.Button4.TabIndex = 173
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.TCC.My.Resources.Resources.calendar_icon1_300x275
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(350, 79)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 25)
        Me.Button3.TabIndex = 172
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.TCC.My.Resources.Resources.calendar_icon1_300x275
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(350, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 171
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
        Me.Button1.Location = New System.Drawing.Point(350, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 170
        Me.Button1.UseVisualStyleBackColor = False
        '
        'mskdtpgto
        '
        Me.mskdtpgto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskdtpgto.Location = New System.Drawing.Point(270, 80)
        Me.mskdtpgto.Mask = "00/00/0000"
        Me.mskdtpgto.Name = "mskdtpgto"
        Me.mskdtpgto.Size = New System.Drawing.Size(77, 22)
        Me.mskdtpgto.TabIndex = 6
        Me.mskdtpgto.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(177, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 18)
        Me.Label8.TabIndex = 168
        Me.Label8.Text = "Pagamento: "
        '
        'txtvalor
        '
        Me.txtvalor.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtvalor.Location = New System.Drawing.Point(64, 50)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtvalor.Size = New System.Drawing.Size(82, 22)
        Me.txtvalor.TabIndex = 3
        '
        'mskdtvenc
        '
        Me.mskdtvenc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskdtvenc.Location = New System.Drawing.Point(270, 49)
        Me.mskdtvenc.Mask = "00/00/0000"
        Me.mskdtvenc.Name = "mskdtvenc"
        Me.mskdtvenc.Size = New System.Drawing.Size(77, 22)
        Me.mskdtvenc.TabIndex = 4
        Me.mskdtvenc.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 18)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "Valor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(174, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 166
        Me.Label4.Text = "Vencimento: "
        '
        'txtdesc
        '
        Me.txtdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdesc.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtdesc.Location = New System.Drawing.Point(323, 19)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdesc.Size = New System.Drawing.Size(249, 22)
        Me.txtdesc.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(239, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "Descrição:"
        '
        'txtcodcompra
        '
        Me.txtcodcompra.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtcodcompra.Location = New System.Drawing.Point(129, 19)
        Me.txtcodcompra.Name = "txtcodcompra"
        Me.txtcodcompra.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcodcompra.Size = New System.Drawing.Size(81, 22)
        Me.txtcodcompra.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 18)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "Código Compra: "
        '
        'btnlimpar
        '
        Me.btnlimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnlimpar.ForeColor = System.Drawing.Color.White
        Me.btnlimpar.Location = New System.Drawing.Point(390, 226)
        Me.btnlimpar.Name = "btnlimpar"
        Me.btnlimpar.Size = New System.Drawing.Size(102, 28)
        Me.btnlimpar.TabIndex = 8
        Me.btnlimpar.Text = "Limpar"
        Me.btnlimpar.UseVisualStyleBackColor = False
        '
        'btnsalvar
        '
        Me.btnsalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalvar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnsalvar.ForeColor = System.Drawing.Color.White
        Me.btnsalvar.Location = New System.Drawing.Point(498, 226)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(102, 28)
        Me.btnsalvar.TabIndex = 7
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = False
        '
        'pbdelete
        '
        Me.pbdelete.BackColor = System.Drawing.Color.Transparent
        Me.pbdelete.BackgroundImage = CType(resources.GetObject("pbdelete.BackgroundImage"), System.Drawing.Image)
        Me.pbdelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbdelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbdelete.Location = New System.Drawing.Point(93, 46)
        Me.pbdelete.Name = "pbdelete"
        Me.pbdelete.Size = New System.Drawing.Size(42, 45)
        Me.pbdelete.TabIndex = 163
        Me.pbdelete.TabStop = False
        '
        'pbconsulta
        '
        Me.pbconsulta.BackColor = System.Drawing.Color.Transparent
        Me.pbconsulta.BackgroundImage = CType(resources.GetObject("pbconsulta.BackgroundImage"), System.Drawing.Image)
        Me.pbconsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbconsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbconsulta.Location = New System.Drawing.Point(51, 42)
        Me.pbconsulta.Name = "pbconsulta"
        Me.pbconsulta.Size = New System.Drawing.Size(43, 56)
        Me.pbconsulta.TabIndex = 161
        Me.pbconsulta.TabStop = False
        '
        'pbpagarconta
        '
        Me.pbpagarconta.BackColor = System.Drawing.Color.Transparent
        Me.pbpagarconta.BackgroundImage = Global.TCC.My.Resources.Resources.US_dollar
        Me.pbpagarconta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbpagarconta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbpagarconta.Location = New System.Drawing.Point(141, 46)
        Me.pbpagarconta.Name = "pbpagarconta"
        Me.pbpagarconta.Size = New System.Drawing.Size(42, 45)
        Me.pbpagarconta.TabIndex = 166
        Me.pbpagarconta.TabStop = False
        '
        'CalendarContasPag
        '
        Me.CalendarContasPag.Location = New System.Drawing.Point(387, 46)
        Me.CalendarContasPag.Name = "CalendarContasPag"
        Me.CalendarContasPag.TabIndex = 167
        Me.CalendarContasPag.Visible = False
        '
        'FrmCadContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(627, 264)
        Me.Controls.Add(Me.CalendarContasPag)
        Me.Controls.Add(Me.pbpagarconta)
        Me.Controls.Add(Me.pbdelete)
        Me.Controls.Add(Me.pbconsulta)
        Me.Controls.Add(Me.CalendarContasVenc)
        Me.Controls.Add(Me.btnlimpar)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbcad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCadContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadContas"
        CType(Me.pbcad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbdelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbconsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbpagarconta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pbcad As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodcompra As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mskdtpgto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents mskdtvenc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnlimpar As System.Windows.Forms.Button
    Friend WithEvents btnsalvar As System.Windows.Forms.Button
    Friend WithEvents pbdelete As System.Windows.Forms.PictureBox
    Friend WithEvents pbconsulta As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CalendarContasVenc As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents pbpagarconta As System.Windows.Forms.PictureBox
    Friend WithEvents txtsaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CalendarContasPag As System.Windows.Forms.MonthCalendar
End Class
