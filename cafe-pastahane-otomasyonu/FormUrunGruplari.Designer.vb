<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUrunGruplari
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUrunGruplari))
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ürünüDüzenleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.yeniÜrünEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDuzenle = New System.Windows.Forms.Button()
        Me.comboGruplar = New System.Windows.Forms.ComboBox()
        Me.txtDuzenlenenAd = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAdi = New System.Windows.Forms.TextBox()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblBildirim = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.contextMenuStrip1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "Ekle.png")
        Me.imageList1.Images.SetKeyName(1, "edit.png")
        '
        'contextMenuStrip1
        '
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ürünüDüzenleToolStripMenuItem, Me.yeniÜrünEkleToolStripMenuItem})
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'ürünüDüzenleToolStripMenuItem
        '
        Me.ürünüDüzenleToolStripMenuItem.Name = "ürünüDüzenleToolStripMenuItem"
        Me.ürünüDüzenleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ürünüDüzenleToolStripMenuItem.Text = "Ürünü Düzenle"
        '
        'yeniÜrünEkleToolStripMenuItem
        '
        Me.yeniÜrünEkleToolStripMenuItem.Name = "yeniÜrünEkleToolStripMenuItem"
        Me.yeniÜrünEkleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.yeniÜrünEkleToolStripMenuItem.Text = "Yeni Ürün Ekle"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.btnDuzenle)
        Me.groupBox2.Controls.Add(Me.comboGruplar)
        Me.groupBox2.Controls.Add(Me.txtDuzenlenenAd)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Location = New System.Drawing.Point(264, 250)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(231, 146)
        Me.groupBox2.TabIndex = 6
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Grup Düzenle"
        '
        'btnDuzenle
        '
        Me.btnDuzenle.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDuzenle.ForeColor = System.Drawing.Color.White
        Me.btnDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDuzenle.ImageKey = "edit.png"
        Me.btnDuzenle.Location = New System.Drawing.Point(60, 77)
        Me.btnDuzenle.Name = "btnDuzenle"
        Me.btnDuzenle.Size = New System.Drawing.Size(121, 29)
        Me.btnDuzenle.TabIndex = 3
        Me.btnDuzenle.Text = "Düzenle"
        Me.btnDuzenle.UseVisualStyleBackColor = False
        '
        'comboGruplar
        '
        Me.comboGruplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboGruplar.FormattingEnabled = True
        Me.comboGruplar.Location = New System.Drawing.Point(60, 24)
        Me.comboGruplar.Name = "comboGruplar"
        Me.comboGruplar.Size = New System.Drawing.Size(121, 21)
        Me.comboGruplar.TabIndex = 2
        '
        'txtDuzenlenenAd
        '
        Me.txtDuzenlenenAd.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtDuzenlenenAd.Location = New System.Drawing.Point(60, 51)
        Me.txtDuzenlenenAd.MaxLength = 50
        Me.txtDuzenlenenAd.Name = "txtDuzenlenenAd"
        Me.txtDuzenlenenAd.Size = New System.Drawing.Size(121, 20)
        Me.txtDuzenlenenAd.TabIndex = 1
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(10, 24)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(44, 13)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Gruplar:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(10, 51)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(25, 13)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Adı:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.txtAdi)
        Me.groupBox1.Controls.Add(Me.btnEkle)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(53, 250)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(205, 146)
        Me.groupBox1.TabIndex = 5
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Grup Ekle"
        '
        'txtAdi
        '
        Me.txtAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtAdi.Location = New System.Drawing.Point(49, 44)
        Me.txtAdi.MaxLength = 50
        Me.txtAdi.Name = "txtAdi"
        Me.txtAdi.Size = New System.Drawing.Size(100, 20)
        Me.txtAdi.TabIndex = 1
        '
        'btnEkle
        '
        Me.btnEkle.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEkle.ForeColor = System.Drawing.Color.White
        Me.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEkle.ImageKey = "Ekle.png"
        Me.btnEkle.Location = New System.Drawing.Point(49, 77)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(100, 29)
        Me.btnEkle.TabIndex = 2
        Me.btnEkle.Text = "Ekle"
        Me.btnEkle.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(18, 47)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(25, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Adı:"
        '
        'lblBildirim
        '
        Me.lblBildirim.AutoSize = True
        Me.lblBildirim.Location = New System.Drawing.Point(174, 399)
        Me.lblBildirim.Name = "lblBildirim"
        Me.lblBildirim.Size = New System.Drawing.Size(0, 13)
        Me.lblBildirim.TabIndex = 7
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.Product_documentation_icon
        Me.pictureBox1.Location = New System.Drawing.Point(535, 229)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(182, 183)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 31
        Me.pictureBox1.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.kafevepastanelogo
        Me.pictureBox2.Location = New System.Drawing.Point(77, 12)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(650, 192)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox2.TabIndex = 30
        Me.pictureBox2.TabStop = False
        '
        'FormUrunGruplari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(779, 443)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.lblBildirim)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "FormUrunGruplari"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ürün Grupları"
        Me.contextMenuStrip1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents imageList1 As ImageList
    Private WithEvents contextMenuStrip1 As ContextMenuStrip
    Private WithEvents ürünüDüzenleToolStripMenuItem As ToolStripMenuItem
    Private WithEvents yeniÜrünEkleToolStripMenuItem As ToolStripMenuItem
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents btnDuzenle As Button
    Public WithEvents comboGruplar As ComboBox
    Private WithEvents txtDuzenlenenAd As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents txtAdi As TextBox
    Private WithEvents btnEkle As Button
    Private WithEvents label1 As Label
    Private WithEvents lblBildirim As Label
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
End Class
