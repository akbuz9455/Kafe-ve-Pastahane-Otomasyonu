<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnaForm))
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ayarlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.masayiKapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstMasa = New System.Windows.Forms.ListView()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ürünSilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ürünEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ürünDüzenleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.raporlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.satışlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kullanıcıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.yeniKullanıcıOluşturToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.şifreDeğiştirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyarlarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1.SuspendLayout()
        Me.contextMenuStrip1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.AutoSize = False
        Me.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.menuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1, Me.raporlarToolStripMenuItem, Me.kullanıcıToolStripMenuItem, Me.ayarlarToolStripMenuItem, Me.AyarlarToolStripMenuItem1})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuStrip1.Size = New System.Drawing.Size(1048, 62)
        Me.menuStrip1.TabIndex = 1
        '
        'ayarlarToolStripMenuItem
        '
        Me.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem"
        Me.ayarlarToolStripMenuItem.Size = New System.Drawing.Size(12, 58)
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "doluMasa.jpg")
        Me.imageList1.Images.SetKeyName(1, "bosMasa.png")
        '
        'contextMenuStrip1
        '
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.masayiKapatToolStripMenuItem})
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(145, 26)
        '
        'masayiKapatToolStripMenuItem
        '
        Me.masayiKapatToolStripMenuItem.Name = "masayiKapatToolStripMenuItem"
        Me.masayiKapatToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.masayiKapatToolStripMenuItem.Text = "Masayi Kapat"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.lstMasa)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox1.Location = New System.Drawing.Point(0, 62)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(1048, 671)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Masalar"
        '
        'lstMasa
        '
        Me.lstMasa.BackColor = System.Drawing.Color.AliceBlue
        Me.lstMasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstMasa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstMasa.HideSelection = False
        Me.lstMasa.LargeImageList = Me.imageList1
        Me.lstMasa.Location = New System.Drawing.Point(3, 16)
        Me.lstMasa.MultiSelect = False
        Me.lstMasa.Name = "lstMasa"
        Me.lstMasa.Size = New System.Drawing.Size(1042, 652)
        Me.lstMasa.TabIndex = 1
        Me.lstMasa.UseCompatibleStateImageBehavior = False
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ürünSilToolStripMenuItem, Me.ürünEkleToolStripMenuItem, Me.ürünDüzenleToolStripMenuItem})
        Me.toolStripMenuItem1.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.Food_Dome_icon
        Me.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(95, 58)
        Me.toolStripMenuItem1.Text = "Ürün"
        '
        'ürünSilToolStripMenuItem
        '
        Me.ürünSilToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ürünSilToolStripMenuItem.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.ekle32
        Me.ürünSilToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ürünSilToolStripMenuItem.Name = "ürünSilToolStripMenuItem"
        Me.ürünSilToolStripMenuItem.Size = New System.Drawing.Size(178, 38)
        Me.ürünSilToolStripMenuItem.Text = "Ürünleri Göster"
        '
        'ürünEkleToolStripMenuItem
        '
        Me.ürünEkleToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ürünEkleToolStripMenuItem.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.save
        Me.ürünEkleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem"
        Me.ürünEkleToolStripMenuItem.Size = New System.Drawing.Size(178, 38)
        Me.ürünEkleToolStripMenuItem.Text = "Ürün Ekle"
        '
        'ürünDüzenleToolStripMenuItem
        '
        Me.ürünDüzenleToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ürünDüzenleToolStripMenuItem.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.edit
        Me.ürünDüzenleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ürünDüzenleToolStripMenuItem.Name = "ürünDüzenleToolStripMenuItem"
        Me.ürünDüzenleToolStripMenuItem.Size = New System.Drawing.Size(178, 38)
        Me.ürünDüzenleToolStripMenuItem.Text = "Ürün Düzenle"
        '
        'raporlarToolStripMenuItem
        '
        Me.raporlarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.satışlarToolStripMenuItem})
        Me.raporlarToolStripMenuItem.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.SEO_icon
        Me.raporlarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem"
        Me.raporlarToolStripMenuItem.Size = New System.Drawing.Size(117, 58)
        Me.raporlarToolStripMenuItem.Text = "Raporlar"
        '
        'satışlarToolStripMenuItem
        '
        Me.satışlarToolStripMenuItem.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.Sales_report_icon__32x_
        Me.satışlarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.satışlarToolStripMenuItem.Name = "satışlarToolStripMenuItem"
        Me.satışlarToolStripMenuItem.Size = New System.Drawing.Size(168, 38)
        Me.satışlarToolStripMenuItem.Text = "Satışlar"
        '
        'kullanıcıToolStripMenuItem
        '
        Me.kullanıcıToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.yeniKullanıcıOluşturToolStripMenuItem, Me.şifreDeğiştirToolStripMenuItem})
        Me.kullanıcıToolStripMenuItem.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.Actions_view_process_users_icon
        Me.kullanıcıToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem"
        Me.kullanıcıToolStripMenuItem.Size = New System.Drawing.Size(114, 58)
        Me.kullanıcıToolStripMenuItem.Text = "Kullanıcı"
        '
        'yeniKullanıcıOluşturToolStripMenuItem
        '
        Me.yeniKullanıcıOluşturToolStripMenuItem.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.useradd
        Me.yeniKullanıcıOluşturToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.yeniKullanıcıOluşturToolStripMenuItem.Name = "yeniKullanıcıOluşturToolStripMenuItem"
        Me.yeniKullanıcıOluşturToolStripMenuItem.Size = New System.Drawing.Size(211, 38)
        Me.yeniKullanıcıOluşturToolStripMenuItem.Text = "Yeni Kullanıcı Oluştur"
        '
        'şifreDeğiştirToolStripMenuItem
        '
        Me.şifreDeğiştirToolStripMenuItem.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.sifredegis
        Me.şifreDeğiştirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.şifreDeğiştirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem"
        Me.şifreDeğiştirToolStripMenuItem.Size = New System.Drawing.Size(211, 38)
        Me.şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir"
        '
        'AyarlarToolStripMenuItem1
        '
        Me.AyarlarToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÇıkışToolStripMenuItem})
        Me.AyarlarToolStripMenuItem1.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.Settings_icon
        Me.AyarlarToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AyarlarToolStripMenuItem1.Name = "AyarlarToolStripMenuItem1"
        Me.AyarlarToolStripMenuItem1.Size = New System.Drawing.Size(109, 58)
        Me.AyarlarToolStripMenuItem1.Text = "Ayarlar"
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources._exit
        Me.ÇıkışToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(168, 38)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'AnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1048, 733)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "AnaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kafe Otomasyonu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.contextMenuStrip1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents toolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents ürünSilToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ürünEkleToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ürünDüzenleToolStripMenuItem As ToolStripMenuItem
    Private WithEvents raporlarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents satışlarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents kullanıcıToolStripMenuItem As ToolStripMenuItem
    Private WithEvents yeniKullanıcıOluşturToolStripMenuItem As ToolStripMenuItem
    Private WithEvents şifreDeğiştirToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ayarlarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents imageList1 As ImageList
    Private WithEvents contextMenuStrip1 As ContextMenuStrip
    Private WithEvents masayiKapatToolStripMenuItem As ToolStripMenuItem
    Private WithEvents groupBox1 As GroupBox
    Public WithEvents lstMasa As ListView
    Friend WithEvents AyarlarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem As ToolStripMenuItem
End Class
