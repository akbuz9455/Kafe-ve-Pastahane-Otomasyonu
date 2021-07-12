<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSifreDegistir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSifreDegistir))
        Me.lblBildirim = New System.Windows.Forms.Label()
        Me.txtYeniSifreTekrar = New System.Windows.Forms.TextBox()
        Me.txtYeniSifre = New System.Windows.Forms.TextBox()
        Me.txtEskiSifre = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.errorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDegistir = New System.Windows.Forms.Button()
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBildirim
        '
        Me.lblBildirim.AutoSize = True
        Me.lblBildirim.Location = New System.Drawing.Point(74, 133)
        Me.lblBildirim.Name = "lblBildirim"
        Me.lblBildirim.Size = New System.Drawing.Size(0, 13)
        Me.lblBildirim.TabIndex = 10
        '
        'txtYeniSifreTekrar
        '
        Me.txtYeniSifreTekrar.Location = New System.Drawing.Point(162, 103)
        Me.txtYeniSifreTekrar.MaxLength = 255
        Me.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar"
        Me.txtYeniSifreTekrar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtYeniSifreTekrar.Size = New System.Drawing.Size(100, 21)
        Me.txtYeniSifreTekrar.TabIndex = 9
        '
        'txtYeniSifre
        '
        Me.txtYeniSifre.Location = New System.Drawing.Point(162, 75)
        Me.txtYeniSifre.MaxLength = 255
        Me.txtYeniSifre.Name = "txtYeniSifre"
        Me.txtYeniSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtYeniSifre.Size = New System.Drawing.Size(100, 21)
        Me.txtYeniSifre.TabIndex = 8
        '
        'txtEskiSifre
        '
        Me.txtEskiSifre.Location = New System.Drawing.Point(162, 47)
        Me.txtEskiSifre.MaxLength = 255
        Me.txtEskiSifre.Name = "txtEskiSifre"
        Me.txtEskiSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEskiSifre.Size = New System.Drawing.Size(100, 21)
        Me.txtEskiSifre.TabIndex = 4
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(50, 106)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(108, 13)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Yeni Şifreniz(Tekrar):"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(51, 78)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(69, 13)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Yeni Şifreniz:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(51, 47)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 13)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Eski Şifreniz:"
        '
        'errorProvider1
        '
        Me.errorProvider1.ContainerControl = Me
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "HesapOde.png")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.lblBildirim)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.btnDegistir)
        Me.GroupBox1.Controls.Add(Me.label3)
        Me.GroupBox1.Controls.Add(Me.txtYeniSifreTekrar)
        Me.GroupBox1.Controls.Add(Me.txtEskiSifre)
        Me.GroupBox1.Controls.Add(Me.txtYeniSifre)
        Me.GroupBox1.Location = New System.Drawing.Point(313, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 224)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Şifre Değiştirme İşlemi"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.pasword
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 236)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'btnDegistir
        '
        Me.btnDegistir.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.edit
        Me.btnDegistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDegistir.ImageKey = "HesapOde.png"
        Me.btnDegistir.Location = New System.Drawing.Point(121, 158)
        Me.btnDegistir.Name = "btnDegistir"
        Me.btnDegistir.Size = New System.Drawing.Size(124, 40)
        Me.btnDegistir.TabIndex = 11
        Me.btnDegistir.Text = "Değiştir"
        Me.btnDegistir.UseVisualStyleBackColor = True
        '
        'FormSifreDegistir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(666, 278)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "FormSifreDegistir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Şifre Değiştir"
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lblBildirim As Label
    Private WithEvents btnDegistir As Button
    Private WithEvents txtYeniSifreTekrar As TextBox
    Private WithEvents txtYeniSifre As TextBox
    Private WithEvents txtEskiSifre As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents errorProvider1 As ErrorProvider
    Private WithEvents imageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
