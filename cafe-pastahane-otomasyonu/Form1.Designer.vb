<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.txtSifre = New System.Windows.Forms.TextBox()
        Me.txtKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.btnGiris = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Bisque
        Me.panel1.Controls.Add(Me.btnGiris)
        Me.panel1.Controls.Add(Me.txtSifre)
        Me.panel1.Controls.Add(Me.txtKullaniciAdi)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(140, 257)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(491, 164)
        Me.panel1.TabIndex = 6
        '
        'txtSifre
        '
        Me.txtSifre.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSifre.Location = New System.Drawing.Point(218, 69)
        Me.txtSifre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSifre.Name = "txtSifre"
        Me.txtSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSifre.Size = New System.Drawing.Size(134, 23)
        Me.txtSifre.TabIndex = 3
        '
        'txtKullaniciAdi
        '
        Me.txtKullaniciAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtKullaniciAdi.Location = New System.Drawing.Point(218, 38)
        Me.txtKullaniciAdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKullaniciAdi.Name = "txtKullaniciAdi"
        Me.txtKullaniciAdi.Size = New System.Drawing.Size(134, 20)
        Me.txtKullaniciAdi.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.Location = New System.Drawing.Point(168, 72)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(42, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Şifre:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.Location = New System.Drawing.Point(120, 41)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(91, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Kullanıcı Adı:"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.kafevepastanelogo
        Me.pictureBox1.Location = New System.Drawing.Point(140, 23)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(491, 227)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 10
        Me.pictureBox1.TabStop = False
        '
        'btnKapat
        '
        Me.btnKapat.FlatAppearance.BorderSize = 2
        Me.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKapat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKapat.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.kapat
        Me.btnKapat.Location = New System.Drawing.Point(737, 12)
        Me.btnKapat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(40, 44)
        Me.btnKapat.TabIndex = 7
        Me.btnKapat.UseVisualStyleBackColor = True
        '
        'btnGiris
        '
        Me.btnGiris.BackColor = System.Drawing.Color.White
        Me.btnGiris.FlatAppearance.BorderSize = 0
        Me.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGiris.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGiris.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.anasayfa
        Me.btnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGiris.Location = New System.Drawing.Point(251, 100)
        Me.btnGiris.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGiris.Name = "btnGiris"
        Me.btnGiris.Size = New System.Drawing.Size(101, 31)
        Me.btnGiris.TabIndex = 4
        Me.btnGiris.Text = "Giriş Yap"
        Me.btnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGiris.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 463)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kafe ve Pastahane Otomasyonu"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents btnKapat As Button
    Private WithEvents panel1 As Panel
    Private WithEvents btnGiris As Button
    Private WithEvents txtSifre As TextBox
    Private WithEvents txtKullaniciAdi As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
