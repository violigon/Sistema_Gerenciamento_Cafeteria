<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btnok = New System.Windows.Forms.Button()
        Me.PBArrastar = New System.Windows.Forms.PictureBox()
        Me.PBSair = New System.Windows.Forms.PictureBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        CType(Me.PBArrastar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.ForeColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(65, 275)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(177, 47)
        Me.btnok.TabIndex = 33
        Me.btnok.Text = "Entrar"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'PBArrastar
        '
        Me.PBArrastar.BackColor = System.Drawing.Color.Transparent
        Me.PBArrastar.Location = New System.Drawing.Point(2, 1)
        Me.PBArrastar.Name = "PBArrastar"
        Me.PBArrastar.Size = New System.Drawing.Size(266, 37)
        Me.PBArrastar.TabIndex = 32
        Me.PBArrastar.TabStop = False
        '
        'PBSair
        '
        Me.PBSair.BackColor = System.Drawing.Color.Transparent
        Me.PBSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBSair.Location = New System.Drawing.Point(268, 1)
        Me.PBSair.Name = "PBSair"
        Me.PBSair.Size = New System.Drawing.Size(33, 37)
        Me.PBSair.TabIndex = 31
        Me.PBSair.TabStop = False
        '
        'txtSenha
        '
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenha.Location = New System.Drawing.Point(36, 216)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(216, 13)
        Me.txtSenha.TabIndex = 30
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'txtLogin
        '
        Me.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogin.Location = New System.Drawing.Point(36, 130)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(232, 13)
        Me.txtLogin.TabIndex = 29
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TCC.My.Resources.Resources.Login_terminado
        Me.ClientSize = New System.Drawing.Size(300, 400)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.PBArrastar)
        Me.Controls.Add(Me.PBSair)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PBArrastar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents PBArrastar As System.Windows.Forms.PictureBox
    Friend WithEvents PBSair As System.Windows.Forms.PictureBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
End Class
