<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasa
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
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtVerilenMiktar = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtToplam = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.comboOdemeTuru = New System.Windows.Forms.ComboBox()
        Me.grpUrun = New System.Windows.Forms.GroupBox()
        Me.lstUrunler = New System.Windows.Forms.ListView()
        Me.btnUrunler = New System.Windows.Forms.Button()
        Me.grpSepet = New System.Windows.Forms.GroupBox()
        Me.lstSepet = New System.Windows.Forms.ListView()
        Me.btnHesapOde = New System.Windows.Forms.Button()
        Me.btnUrunSil = New System.Windows.Forms.Button()
        Me.btnUrunEkle = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.groupBox1.SuspendLayout()
        Me.grpUrun.SuspendLayout()
        Me.grpSepet.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'imageList1
        '
        Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imageList1.ImageSize = New System.Drawing.Size(48, 48)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.comboOdemeTuru)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.txtVerilenMiktar)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.txtToplam)
        Me.groupBox1.Controls.Add(Me.btnHesapOde)
        Me.groupBox1.Location = New System.Drawing.Point(333, 294)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(814, 99)
        Me.groupBox1.TabIndex = 18
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Hesap"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label4.Location = New System.Drawing.Point(227, 46)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(98, 17)
        Me.label4.TabIndex = 12
        Me.label4.Text = "Verilen Miktar:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label5.Location = New System.Drawing.Point(410, 46)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(15, 16)
        Me.label5.TabIndex = 13
        Me.label5.Text = "₺"
        '
        'txtVerilenMiktar
        '
        Me.txtVerilenMiktar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtVerilenMiktar.Location = New System.Drawing.Point(331, 43)
        Me.txtVerilenMiktar.Name = "txtVerilenMiktar"
        Me.txtVerilenMiktar.Size = New System.Drawing.Size(73, 23)
        Me.txtVerilenMiktar.TabIndex = 11
        Me.txtVerilenMiktar.Text = "0"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.Location = New System.Drawing.Point(24, 46)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(97, 17)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Toplam Tutar:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.Location = New System.Drawing.Point(206, 47)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(15, 16)
        Me.label2.TabIndex = 7
        Me.label2.Text = "₺"
        '
        'txtToplam
        '
        Me.txtToplam.BackColor = System.Drawing.Color.White
        Me.txtToplam.Enabled = False
        Me.txtToplam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtToplam.Location = New System.Drawing.Point(127, 43)
        Me.txtToplam.Name = "txtToplam"
        Me.txtToplam.ReadOnly = True
        Me.txtToplam.Size = New System.Drawing.Size(73, 23)
        Me.txtToplam.TabIndex = 5
        Me.txtToplam.Text = "0,0"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.label3.Location = New System.Drawing.Point(431, 47)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(92, 17)
        Me.label3.TabIndex = 10
        Me.label3.Text = "Ödeme Türü:"
        '
        'comboOdemeTuru
        '
        Me.comboOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboOdemeTuru.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.comboOdemeTuru.FormattingEnabled = True
        Me.comboOdemeTuru.Location = New System.Drawing.Point(529, 44)
        Me.comboOdemeTuru.Name = "comboOdemeTuru"
        Me.comboOdemeTuru.Size = New System.Drawing.Size(121, 24)
        Me.comboOdemeTuru.TabIndex = 9
        '
        'grpUrun
        '
        Me.grpUrun.Controls.Add(Me.lstUrunler)
        Me.grpUrun.Location = New System.Drawing.Point(49, 21)
        Me.grpUrun.Name = "grpUrun"
        Me.grpUrun.Size = New System.Drawing.Size(1098, 267)
        Me.grpUrun.TabIndex = 15
        Me.grpUrun.TabStop = False
        '
        'lstUrunler
        '
        Me.lstUrunler.BackColor = System.Drawing.Color.AntiqueWhite
        Me.lstUrunler.HideSelection = False
        Me.lstUrunler.LargeImageList = Me.imageList1
        Me.lstUrunler.Location = New System.Drawing.Point(6, 14)
        Me.lstUrunler.MultiSelect = False
        Me.lstUrunler.Name = "lstUrunler"
        Me.lstUrunler.Size = New System.Drawing.Size(1086, 247)
        Me.lstUrunler.TabIndex = 1
        Me.lstUrunler.UseCompatibleStateImageBehavior = False
        '
        'btnUrunler
        '
        Me.btnUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUrunler.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnUrunler.Location = New System.Drawing.Point(15, 21)
        Me.btnUrunler.Name = "btnUrunler"
        Me.btnUrunler.Size = New System.Drawing.Size(23, 562)
        Me.btnUrunler.TabIndex = 13
        Me.btnUrunler.Text = "Ürün"
        Me.btnUrunler.UseVisualStyleBackColor = True
        '
        'grpSepet
        '
        Me.grpSepet.Controls.Add(Me.lstSepet)
        Me.grpSepet.Location = New System.Drawing.Point(55, 399)
        Me.grpSepet.Name = "grpSepet"
        Me.grpSepet.Size = New System.Drawing.Size(1092, 187)
        Me.grpSepet.TabIndex = 14
        Me.grpSepet.TabStop = False
        Me.grpSepet.Text = "Sepet"
        '
        'lstSepet
        '
        Me.lstSepet.BackColor = System.Drawing.Color.Aquamarine
        Me.lstSepet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSepet.HideSelection = False
        Me.lstSepet.LargeImageList = Me.imageList1
        Me.lstSepet.Location = New System.Drawing.Point(3, 16)
        Me.lstSepet.Name = "lstSepet"
        Me.lstSepet.Size = New System.Drawing.Size(1086, 168)
        Me.lstSepet.TabIndex = 4
        Me.lstSepet.UseCompatibleStateImageBehavior = False
        '
        'btnHesapOde
        '
        Me.btnHesapOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHesapOde.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnHesapOde.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.shop_cart_apply_icon
        Me.btnHesapOde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHesapOde.Location = New System.Drawing.Point(670, 19)
        Me.btnHesapOde.Name = "btnHesapOde"
        Me.btnHesapOde.Size = New System.Drawing.Size(79, 71)
        Me.btnHesapOde.TabIndex = 8
        Me.btnHesapOde.UseVisualStyleBackColor = True
        '
        'btnUrunSil
        '
        Me.btnUrunSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUrunSil.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.shop_cart_exclude_icon
        Me.btnUrunSil.Location = New System.Drawing.Point(147, 19)
        Me.btnUrunSil.Name = "btnUrunSil"
        Me.btnUrunSil.Size = New System.Drawing.Size(79, 71)
        Me.btnUrunSil.TabIndex = 16
        Me.btnUrunSil.UseVisualStyleBackColor = True
        '
        'btnUrunEkle
        '
        Me.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUrunEkle.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.shop_cart_down_icon
        Me.btnUrunEkle.Location = New System.Drawing.Point(18, 19)
        Me.btnUrunEkle.Name = "btnUrunEkle"
        Me.btnUrunEkle.Size = New System.Drawing.Size(79, 71)
        Me.btnUrunEkle.TabIndex = 17
        Me.btnUrunEkle.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.btnUrunEkle)
        Me.GroupBox2.Controls.Add(Me.btnUrunSil)
        Me.GroupBox2.Location = New System.Drawing.Point(58, 294)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 99)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ürün Ekle / Çıkar"
        '
        'FormMasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1159, 598)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.grpUrun)
        Me.Controls.Add(Me.btnUrunler)
        Me.Controls.Add(Me.grpSepet)
        Me.Name = "FormMasa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Masa"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.grpUrun.ResumeLayout(False)
        Me.grpSepet.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents imageList1 As ImageList
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents label4 As Label
    Private WithEvents label5 As Label
    Private WithEvents txtVerilenMiktar As TextBox
    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Private WithEvents txtToplam As TextBox
    Private WithEvents label3 As Label
    Private WithEvents btnHesapOde As Button
    Private WithEvents comboOdemeTuru As ComboBox
    Private WithEvents btnUrunSil As Button
    Private WithEvents btnUrunEkle As Button
    Private WithEvents grpUrun As GroupBox
    Private WithEvents lstUrunler As ListView
    Private WithEvents btnUrunler As Button
    Private WithEvents grpSepet As GroupBox
    Private WithEvents lstSepet As ListView
    Friend WithEvents GroupBox2 As GroupBox
End Class
