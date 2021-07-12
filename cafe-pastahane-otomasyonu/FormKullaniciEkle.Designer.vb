<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKullaniciEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKullaniciEkle))
        Me.lblBildirim = New System.Windows.Forms.Label()
        Me.txtKulAdi = New System.Windows.Forms.TextBox()
        Me.txtSoyadi = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtAdi = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtSifre = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBildirim
        '
        Me.lblBildirim.AutoSize = True
        Me.lblBildirim.Location = New System.Drawing.Point(133, 203)
        Me.lblBildirim.Name = "lblBildirim"
        Me.lblBildirim.Size = New System.Drawing.Size(0, 13)
        Me.lblBildirim.TabIndex = 23
        '
        'txtKulAdi
        '
        Me.txtKulAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtKulAdi.Location = New System.Drawing.Point(136, 63)
        Me.txtKulAdi.MaxLength = 25
        Me.txtKulAdi.Name = "txtKulAdi"
        Me.txtKulAdi.Size = New System.Drawing.Size(100, 21)
        Me.txtKulAdi.TabIndex = 14
        '
        'txtSoyadi
        '
        Me.txtSoyadi.Location = New System.Drawing.Point(136, 165)
        Me.txtSoyadi.MaxLength = 25
        Me.txtSoyadi.Name = "txtSoyadi"
        Me.txtSoyadi.Size = New System.Drawing.Size(100, 21)
        Me.txtSoyadi.TabIndex = 17
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(48, 67)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(69, 13)
        Me.label4.TabIndex = 19
        Me.label4.Text = "Kullanıcı Adı :"
        '
        'txtAdi
        '
        Me.txtAdi.Location = New System.Drawing.Point(136, 131)
        Me.txtAdi.MaxLength = 25
        Me.txtAdi.Name = "txtAdi"
        Me.txtAdi.Size = New System.Drawing.Size(100, 21)
        Me.txtAdi.TabIndex = 16
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(81, 101)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(36, 13)
        Me.label5.TabIndex = 20
        Me.label5.Text = "Şifre :"
        '
        'txtSifre
        '
        Me.txtSifre.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSifre.Location = New System.Drawing.Point(136, 97)
        Me.txtSifre.MaxLength = 255
        Me.txtSifre.Name = "txtSifre"
        Me.txtSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSifre.Size = New System.Drawing.Size(100, 23)
        Me.txtSifre.TabIndex = 15
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(90, 135)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(27, 13)
        Me.label6.TabIndex = 21
        Me.label6.Text = "Ad :"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(73, 169)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(44, 13)
        Me.label7.TabIndex = 22
        Me.label7.Text = "Soyad :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label4)
        Me.GroupBox1.Controls.Add(Me.lblBildirim)
        Me.GroupBox1.Controls.Add(Me.label7)
        Me.GroupBox1.Controls.Add(Me.btnEkle)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.txtKulAdi)
        Me.GroupBox1.Controls.Add(Me.txtSifre)
        Me.GroupBox1.Controls.Add(Me.txtSoyadi)
        Me.GroupBox1.Controls.Add(Me.label5)
        Me.GroupBox1.Controls.Add(Me.txtAdi)
        Me.GroupBox1.Location = New System.Drawing.Point(311, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 253)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kullanı Ekleme İşlemi"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.kekle
        Me.PictureBox1.Location = New System.Drawing.Point(25, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 253)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'btnEkle
        '
        Me.btnEkle.Image = CType(resources.GetObject("btnEkle.Image"), System.Drawing.Image)
        Me.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEkle.Location = New System.Drawing.Point(136, 203)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(100, 31)
        Me.btnEkle.TabIndex = 18
        Me.btnEkle.Text = "Ekle"
        Me.btnEkle.UseVisualStyleBackColor = True
        '
        'FormKullaniciEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(634, 369)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "FormKullaniciEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kullanıcı Ekle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lblBildirim As Label
    Private WithEvents btnEkle As Button
    Private WithEvents txtKulAdi As TextBox
    Private WithEvents txtSoyadi As TextBox
    Private WithEvents label4 As Label
    Private WithEvents txtAdi As TextBox
    Private WithEvents label5 As Label
    Private WithEvents txtSifre As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
