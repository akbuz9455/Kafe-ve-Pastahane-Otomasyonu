<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUrunDuzenle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUrunDuzenle))
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUrunSil = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDuzenle = New System.Windows.Forms.Button()
        Me.btnGozat = New System.Windows.Forms.Button()
        Me.lblResimYolu = New System.Windows.Forms.Label()
        Me.lblBildirim = New System.Windows.Forms.Label()
        Me.comboUrunGrubu = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtUrunFiyati = New System.Windows.Forms.TextBox()
        Me.txtUrunAdi = New System.Windows.Forms.TextBox()
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.groupBox1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog1"
        '
        'imageList1
        '
        Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imageList1.ImageSize = New System.Drawing.Size(48, 48)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnUrunSil)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.pictureBox1)
        Me.groupBox1.Controls.Add(Me.btnDuzenle)
        Me.groupBox1.Controls.Add(Me.btnGozat)
        Me.groupBox1.Controls.Add(Me.lblResimYolu)
        Me.groupBox1.Controls.Add(Me.lblBildirim)
        Me.groupBox1.Controls.Add(Me.comboUrunGrubu)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.txtUrunFiyati)
        Me.groupBox1.Controls.Add(Me.txtUrunAdi)
        Me.groupBox1.Location = New System.Drawing.Point(430, 195)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(431, 250)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Ürünün"
        '
        'btnUrunSil
        '
        Me.btnUrunSil.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnUrunSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUrunSil.ForeColor = System.Drawing.Color.White
        Me.btnUrunSil.Location = New System.Drawing.Point(159, 159)
        Me.btnUrunSil.Name = "btnUrunSil"
        Me.btnUrunSil.Size = New System.Drawing.Size(75, 40)
        Me.btnUrunSil.TabIndex = 16
        Me.btnUrunSil.Text = "Ürünü Sil"
        Me.btnUrunSil.UseVisualStyleBackColor = False
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label6.Location = New System.Drawing.Point(215, 65)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(19, 23)
        Me.label6.TabIndex = 15
        Me.label6.Text = "₺"
        '
        'pictureBox1
        '
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox1.Location = New System.Drawing.Point(317, 19)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 122)
        Me.pictureBox1.TabIndex = 7
        Me.pictureBox1.TabStop = False
        '
        'btnDuzenle
        '
        Me.btnDuzenle.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDuzenle.ForeColor = System.Drawing.Color.White
        Me.btnDuzenle.Image = CType(resources.GetObject("btnDuzenle.Image"), System.Drawing.Image)
        Me.btnDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDuzenle.Location = New System.Drawing.Point(31, 159)
        Me.btnDuzenle.Name = "btnDuzenle"
        Me.btnDuzenle.Size = New System.Drawing.Size(121, 40)
        Me.btnDuzenle.TabIndex = 4
        Me.btnDuzenle.Text = "Düzenle"
        Me.btnDuzenle.UseVisualStyleBackColor = False
        '
        'btnGozat
        '
        Me.btnGozat.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnGozat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGozat.ForeColor = System.Drawing.Color.White
        Me.btnGozat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGozat.ImageKey = "(none)"
        Me.btnGozat.Location = New System.Drawing.Point(317, 147)
        Me.btnGozat.Name = "btnGozat"
        Me.btnGozat.Size = New System.Drawing.Size(100, 40)
        Me.btnGozat.TabIndex = 3
        Me.btnGozat.Text = "Gözat"
        Me.btnGozat.UseVisualStyleBackColor = False
        '
        'lblResimYolu
        '
        Me.lblResimYolu.Location = New System.Drawing.Point(64, 118)
        Me.lblResimYolu.Name = "lblResimYolu"
        Me.lblResimYolu.Size = New System.Drawing.Size(151, 21)
        Me.lblResimYolu.TabIndex = 4
        '
        'lblBildirim
        '
        Me.lblBildirim.AutoSize = True
        Me.lblBildirim.ForeColor = System.Drawing.Color.OliveDrab
        Me.lblBildirim.Location = New System.Drawing.Point(28, 202)
        Me.lblBildirim.Name = "lblBildirim"
        Me.lblBildirim.Size = New System.Drawing.Size(0, 13)
        Me.lblBildirim.TabIndex = 3
        '
        'comboUrunGrubu
        '
        Me.comboUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboUrunGrubu.FormattingEnabled = True
        Me.comboUrunGrubu.Location = New System.Drawing.Point(67, 91)
        Me.comboUrunGrubu.Name = "comboUrunGrubu"
        Me.comboUrunGrubu.Size = New System.Drawing.Size(148, 21)
        Me.comboUrunGrubu.TabIndex = 2
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(17, 118)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(36, 13)
        Me.label4.TabIndex = 1
        Me.label4.Text = "Resmi"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(17, 92)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(36, 13)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Grubu"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(17, 66)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(31, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Fiyatı"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(17, 40)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(22, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Adı"
        '
        'txtUrunFiyati
        '
        Me.txtUrunFiyati.Location = New System.Drawing.Point(67, 66)
        Me.txtUrunFiyati.Name = "txtUrunFiyati"
        Me.txtUrunFiyati.Size = New System.Drawing.Size(148, 20)
        Me.txtUrunFiyati.TabIndex = 1
        Me.txtUrunFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUrunAdi
        '
        Me.txtUrunAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtUrunAdi.Location = New System.Drawing.Point(67, 40)
        Me.txtUrunAdi.MaxLength = 50
        Me.txtUrunAdi.Name = "txtUrunAdi"
        Me.txtUrunAdi.Size = New System.Drawing.Size(148, 20)
        Me.txtUrunAdi.TabIndex = 0
        '
        'listView1
        '
        Me.listView1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.listView1.HideSelection = False
        Me.listView1.LargeImageList = Me.imageList1
        Me.listView1.Location = New System.Drawing.Point(22, 12)
        Me.listView1.MultiSelect = False
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(374, 433)
        Me.listView1.TabIndex = 2
        Me.listView1.UseCompatibleStateImageBehavior = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cafe_pastahane_otomasyonu.My.Resources.Resources.kafevepastanelogo
        Me.PictureBox2.Location = New System.Drawing.Point(430, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(431, 181)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'FormUrunDuzenle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(873, 457)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.listView1)
        Me.Name = "FormUrunDuzenle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ürün Düzenle"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents openFileDialog1 As OpenFileDialog
    Private WithEvents imageList1 As ImageList
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnUrunSil As Button
    Private WithEvents label6 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents btnDuzenle As Button
    Private WithEvents btnGozat As Button
    Private WithEvents lblResimYolu As Label
    Private WithEvents lblBildirim As Label
    Private WithEvents comboUrunGrubu As ComboBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents txtUrunFiyati As TextBox
    Private WithEvents txtUrunAdi As TextBox
    Private WithEvents listView1 As ListView
    Friend WithEvents PictureBox2 As PictureBox
End Class
