<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFinalizarVenda
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblvlrtotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltroco = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtrecebido = New System.Windows.Forms.TextBox()
        Me.btnfinalizar = New System.Windows.Forms.Button()
        Me.rbtdinheiro = New System.Windows.Forms.RadioButton()
        Me.rbtcredito = New System.Windows.Forms.RadioButton()
        Me.rbtdebito = New System.Windows.Forms.RadioButton()
        Me.pbok = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.pbok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 19)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Forma de Pagamento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(630, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(129, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "VALOR TOTAL"
        '
        'lblvlrtotal
        '
        Me.lblvlrtotal.AutoSize = True
        Me.lblvlrtotal.BackColor = System.Drawing.Color.Transparent
        Me.lblvlrtotal.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvlrtotal.ForeColor = System.Drawing.Color.White
        Me.lblvlrtotal.Location = New System.Drawing.Point(417, 16)
        Me.lblvlrtotal.Name = "lblvlrtotal"
        Me.lblvlrtotal.Size = New System.Drawing.Size(80, 37)
        Me.lblvlrtotal.TabIndex = 32
        Me.lblvlrtotal.Text = "0,00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(129, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 19)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "RECEBIDO"
        '
        'lbltroco
        '
        Me.lbltroco.AutoSize = True
        Me.lbltroco.BackColor = System.Drawing.Color.Transparent
        Me.lbltroco.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltroco.ForeColor = System.Drawing.Color.White
        Me.lbltroco.Location = New System.Drawing.Point(417, 135)
        Me.lbltroco.Name = "lbltroco"
        Me.lbltroco.Size = New System.Drawing.Size(80, 37)
        Me.lbltroco.TabIndex = 35
        Me.lbltroco.Text = "0,00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(129, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "TROCO"
        '
        'txtrecebido
        '
        Me.txtrecebido.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtrecebido.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrecebido.Location = New System.Drawing.Point(410, 75)
        Me.txtrecebido.Name = "txtrecebido"
        Me.txtrecebido.ReadOnly = True
        Me.txtrecebido.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtrecebido.Size = New System.Drawing.Size(116, 35)
        Me.txtrecebido.TabIndex = 43
        '
        'btnfinalizar
        '
        Me.btnfinalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnfinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfinalizar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfinalizar.ForeColor = System.Drawing.Color.White
        Me.btnfinalizar.Location = New System.Drawing.Point(534, 357)
        Me.btnfinalizar.Name = "btnfinalizar"
        Me.btnfinalizar.Size = New System.Drawing.Size(113, 37)
        Me.btnfinalizar.TabIndex = 44
        Me.btnfinalizar.Text = "Finalizar"
        Me.btnfinalizar.UseVisualStyleBackColor = False
        '
        'rbtdinheiro
        '
        Me.rbtdinheiro.AutoSize = True
        Me.rbtdinheiro.BackColor = System.Drawing.Color.Transparent
        Me.rbtdinheiro.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtdinheiro.ForeColor = System.Drawing.Color.White
        Me.rbtdinheiro.Location = New System.Drawing.Point(133, 19)
        Me.rbtdinheiro.Name = "rbtdinheiro"
        Me.rbtdinheiro.Size = New System.Drawing.Size(112, 28)
        Me.rbtdinheiro.TabIndex = 45
        Me.rbtdinheiro.TabStop = True
        Me.rbtdinheiro.Text = "Dinheiro"
        Me.rbtdinheiro.UseVisualStyleBackColor = False
        '
        'rbtcredito
        '
        Me.rbtcredito.AutoSize = True
        Me.rbtcredito.BackColor = System.Drawing.Color.Transparent
        Me.rbtcredito.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtcredito.ForeColor = System.Drawing.Color.White
        Me.rbtcredito.Location = New System.Drawing.Point(415, 19)
        Me.rbtcredito.Name = "rbtcredito"
        Me.rbtcredito.Size = New System.Drawing.Size(101, 28)
        Me.rbtcredito.TabIndex = 46
        Me.rbtcredito.TabStop = True
        Me.rbtcredito.Text = "Crédito"
        Me.rbtcredito.UseVisualStyleBackColor = False
        '
        'rbtdebito
        '
        Me.rbtdebito.AutoSize = True
        Me.rbtdebito.BackColor = System.Drawing.Color.Transparent
        Me.rbtdebito.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtdebito.ForeColor = System.Drawing.Color.White
        Me.rbtdebito.Location = New System.Drawing.Point(274, 19)
        Me.rbtdebito.Name = "rbtdebito"
        Me.rbtdebito.Size = New System.Drawing.Size(93, 28)
        Me.rbtdebito.TabIndex = 47
        Me.rbtdebito.TabStop = True
        Me.rbtdebito.Text = "Débito"
        Me.rbtdebito.UseVisualStyleBackColor = False
        '
        'pbok
        '
        Me.pbok.BackColor = System.Drawing.Color.Transparent
        Me.pbok.BackgroundImage = Global.TCC.My.Resources.Resources.Ok3D
        Me.pbok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbok.Location = New System.Drawing.Point(532, 75)
        Me.pbok.Name = "pbok"
        Me.pbok.Size = New System.Drawing.Size(38, 35)
        Me.pbok.TabIndex = 174
        Me.pbok.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbtdinheiro)
        Me.GroupBox1.Controls.Add(Me.rbtcredito)
        Me.GroupBox1.Controls.Add(Me.rbtdebito)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(16, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(631, 62)
        Me.GroupBox1.TabIndex = 176
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblvlrtotal)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.pbok)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtrecebido)
        Me.GroupBox2.Controls.Add(Me.lbltroco)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(16, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(631, 193)
        Me.GroupBox2.TabIndex = 177
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados Venda"
        '
        'FrmFinalizarVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(659, 455)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnfinalizar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmFinalizarVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmFinalizarVenda"
        CType(Me.pbok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblvlrtotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbltroco As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtrecebido As System.Windows.Forms.TextBox
    Friend WithEvents btnfinalizar As System.Windows.Forms.Button
    Friend WithEvents rbtdinheiro As System.Windows.Forms.RadioButton
    Friend WithEvents rbtcredito As System.Windows.Forms.RadioButton
    Friend WithEvents rbtdebito As System.Windows.Forms.RadioButton
    Friend WithEvents pbok As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
