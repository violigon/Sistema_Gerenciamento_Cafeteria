<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMensagem
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtmsg = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtassunto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbconsulta = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbconsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(616, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 19)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Consulta de Mensagens - WEBSITE"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtmsg)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtassunto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnome)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 272)
        Me.GroupBox1.TabIndex = 177
        Me.GroupBox1.TabStop = False
        '
        'txtmsg
        '
        Me.txtmsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtmsg.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmsg.Location = New System.Drawing.Point(201, 117)
        Me.txtmsg.Multiline = True
        Me.txtmsg.Name = "txtmsg"
        Me.txtmsg.ReadOnly = True
        Me.txtmsg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtmsg.Size = New System.Drawing.Size(394, 127)
        Me.txtmsg.TabIndex = 223
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(197, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 19)
        Me.Label5.TabIndex = 222
        Me.Label5.Text = "Mensagem:"
        '
        'txtassunto
        '
        Me.txtassunto.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtassunto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtassunto.Location = New System.Drawing.Point(10, 117)
        Me.txtassunto.Name = "txtassunto"
        Me.txtassunto.ReadOnly = True
        Me.txtassunto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtassunto.Size = New System.Drawing.Size(157, 26)
        Me.txtassunto.TabIndex = 221
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 19)
        Me.Label4.TabIndex = 220
        Me.Label4.Text = "Assunto:"
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtemail.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(201, 45)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.ReadOnly = True
        Me.txtemail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtemail.Size = New System.Drawing.Size(394, 26)
        Me.txtemail.TabIndex = 219
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(197, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 19)
        Me.Label3.TabIndex = 218
        Me.Label3.Text = "Email:"
        '
        'txtnome
        '
        Me.txtnome.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtnome.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.Location = New System.Drawing.Point(10, 45)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.ReadOnly = True
        Me.txtnome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtnome.Size = New System.Drawing.Size(157, 26)
        Me.txtnome.TabIndex = 217
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 19)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Nome:"
        '
        'pbconsulta
        '
        Me.pbconsulta.BackColor = System.Drawing.Color.Transparent
        Me.pbconsulta.BackgroundImage = Global.TCC.My.Resources.Resources.go_back_icon
        Me.pbconsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbconsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbconsulta.Location = New System.Drawing.Point(22, 44)
        Me.pbconsulta.Name = "pbconsulta"
        Me.pbconsulta.Size = New System.Drawing.Size(42, 45)
        Me.pbconsulta.TabIndex = 178
        Me.pbconsulta.TabStop = False
        '
        'FrmMensagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.telafundo
        Me.ClientSize = New System.Drawing.Size(642, 415)
        Me.Controls.Add(Me.pbconsulta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMensagem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMensagem"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbconsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtassunto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents txtmsg As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pbconsulta As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
