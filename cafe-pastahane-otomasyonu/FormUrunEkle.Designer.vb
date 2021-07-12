<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUrunEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUrunEkle))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.lblBildirim = New System.Windows.Forms.Label()
        Me.btnGrupEkle = New System.Windows.Forms.Button()
        Me.comboGrup = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.lblGozat = New System.Windows.Forms.Label()
        Me.txtUrunFiyati = New System.Windows.Forms.TextBox()
        Me.txtUrunAdi = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnUrunGoster = New System.Windows.Forms.Button()
        Me.btnUrunEkle = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnUrunGozat = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.groupBox1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.PictureBox2)
        Me.groupBox1.Controls.Add(Me.Label7)
        Me.groupBox1.Controls.Add(Me.btnUrunGoster)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.lblBildirim)
        Me.groupBox1.Controls.Add(Me.btnGrupEkle)
        Me.groupBox1.Controls.Add(Me.btnUrunEkle)
        Me.groupBox1.Controls.Add(Me.comboGrup)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.pictureBox1)
        Me.groupBox1.Controls.Add(Me.btnUrunGozat)
        Me.groupBox1.Controls.Add(Me.lblGozat)
        Me.groupBox1.Controls.Add(Me.txtUrunFiyati)
        Me.groupBox1.Controls.Add(Me.txtUrunAdi)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox1.Location = New System.Drawing.Point(0, 0)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(776, 469)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Ürünün"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label6.Location = New System.Drawing.Point(308, 291)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(19, 23)
        Me.label6.TabIndex = 14
        Me.label6.Text = "₺"
        '
        'lblBildirim
        '
        Me.lblBildirim.AutoSize = True
        Me.lblBildirim.Location = New System.Drawing.Point(12, 187)
        Me.lblBildirim.Name = "lblBildirim"
        Me.lblBildirim.Size = New System.Drawing.Size(0, 16)
        Me.lblBildirim.TabIndex = 13
        '
        'btnGrupEkle
        '
        Me.btnGrupEkle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGrupEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrupEkle.ForeColor = System.Drawing.Color.White
        Me.btnGrupEkle.Location = New System.Drawing.Point(329, 320)
        Me.btnGrupEkle.Name = "btnGrupEkle"
        Me.btnGrupEkle.Size = New System.Drawing.Size(100, 24)
        Me.btnGrupEkle.TabIndex = 3
        Me.btnGrupEkle.Text = "Grup İşlemleri"
        Me.btnGrupEkle.UseVisualStyleBackColor = False
        '
        'comboGrup
        '
        Me.comboGrup.BackColor = System.Drawing.Color.White
        Me.comboGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboGrup.FormattingEnabled = True
        Me.comboGrup.Location = New System.Drawing.Point(153, 320)
        Me.comboGrup.Name = "comboGrup"
        Me.comboGrup.Size = New System.Drawing.Size(150, 24)
        Me.comboGrup.TabIndex = 2
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(100, 324)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(47, 16)
        Me.label5.TabIndex = 9
        Me.label5.Text = "Grubu:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(529, 238)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(112, 16)
        Me.label4.TabIndex = 8
        Me.label4.Text = "Ürünün Görünümü"
        '
        'lblGozat
        '
        Me.lblGozat.Location = New System.Drawing.Point(151, 354)
        Me.lblGozat.Name = "lblGozat"
        Me.lblGozat.Size = New System.Drawing.Size(206, 19)
        Me.lblGozat.TabIndex = 5
        Me.lblGozat.Text = "*"
        '
        'txtUrunFiyati
        '
        Me.txtUrunFiyati.Location = New System.Drawing.Point(153, 291)
        Me.txtUrunFiyati.Name = "txtUrunFiyati"
        Me.txtUrunFiyati.Size = New System.Drawing.Size(149, 23)
        Me.txtUrunFiyati.TabIndex = 1
        Me.txtUrunFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUrunAdi
        '
        Me.txtUrunAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtUrunAdi.Location = New System.Drawing.Point(153, 262)
        Me.txtUrunAdi.MaxLength = 50
        Me.txtUrunAdi.Name = "txtUrunAdi"
        Me.txtUrunAdi.Size = New System.Drawing.Size(149, 23)
        Me.txtUrunAdi.TabIndex = 0
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(65, 354)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(80, 16)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Resim Yolu :"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(70, 294)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(78, 16)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Ürün Fiyatı :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(81, 265)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(66, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Ürün Adı :"
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog1"
        '
        'btnUrunGoster
        '
        Me.btnUrunGoster.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnUrunGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUrunGoster.ForeColor = System.Drawing.Color.White
        Me.btnUrunGoster.Image = CType(resources.GetObject("btnUrunGoster.Image"), System.Drawing.Image)
        Me.btnUrunGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUrunGoster.Location = New System.Drawing.Point(231, 399)
        Me.btnUrunGoster.Name = "btnUrunGoster"
        Me.btnUrunGoster.Size = New System.Drawing.Size(150, 40)
        Me.btnUrunGoster.TabIndex = 6
        Me.btnUrunGoster.Text = "Ürünleri Göster"
        Me.btnUrunGoster.UseVisualStyleBackColor = False
        '
        'btnUrunEkle
        '
        Me.btnUrunEkle.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUrunEkle.ForeColor = System.Drawing.Color.White
        Me.btnUrunEkle.Image = CType(resources.GetObject("btnUrunEkle.Image"), System.Drawing.Image)
        Me.btnUrunEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUrunEkle.Location = New System.Drawing.Point(67, 399)
        Me.btnUrunEkle.Name = "btnUrunEkle"
        Me.btnUrunEkle.Size = New System.Drawing.Size(150, 40)
        Me.btnUrunEkle.TabIndex = 5
        Me.btnUrunEkle.Text = "Ürünü Ekle"
        Me.btnUrunEkle.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox1.Location = New System.Drawing.Point(532, 265)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox1.TabIndex = 7
        Me.pictureBox1.TabStop = False
        '
        'btnUrunGozat
        '
        Me.btnUrunGozat.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnUrunGozat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUrunGozat.ForeColor = System.Drawing.Color.White
        Me.btnUrunGozat.Image = CType(resources.GetObject("btnUrunGozat.Image"), System.Drawing.Image)
        Me.btnUrunGozat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUrunGozat.Location = New System.Drawing.Point(532, 399)
        Me.btnUrunGozat.Name = "btnUrunGozat"
        Me.btnUrunGozat.Size = New System.Drawing.Size(128, 40)
        Me.btnUrunGozat.TabIndex = 4
        Me.btnUrunGozat.Text = "Gözat"
        Me.btnUrunGozat.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(138, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Ürünün Bilgileri"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.kafevepastanelogo
        Me.PictureBox2.Location = New System.Drawing.Point(67, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(658, 201)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'FormUrunEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(776, 469)
        Me.Controls.Add(Me.groupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormUrunEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ürün Ekle"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnUrunGoster As Button
    Private WithEvents label6 As Label
    Private WithEvents lblBildirim As Label
    Private WithEvents btnGrupEkle As Button
    Private WithEvents btnUrunEkle As Button
    Private WithEvents comboGrup As ComboBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents btnUrunGozat As Button
    Private WithEvents lblGozat As Label
    Private WithEvents txtUrunFiyati As TextBox
    Private WithEvents txtUrunAdi As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents openFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox2 As PictureBox
    Private WithEvents Label7 As Label
End Class
