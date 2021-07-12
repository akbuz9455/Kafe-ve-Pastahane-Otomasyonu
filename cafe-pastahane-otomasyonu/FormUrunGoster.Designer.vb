<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUrunGoster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUrunGoster))
        Me.lstUrun = New System.Windows.Forms.ListView()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ürünüDüzenleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.yeniÜrünEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstUrun
        '
        Me.lstUrun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstUrun.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.lstUrun.HideSelection = False
        Me.lstUrun.Location = New System.Drawing.Point(0, 0)
        Me.lstUrun.MultiSelect = False
        Me.lstUrun.Name = "lstUrun"
        Me.lstUrun.Size = New System.Drawing.Size(784, 561)
        Me.lstUrun.TabIndex = 1
        Me.lstUrun.UseCompatibleStateImageBehavior = False
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "logo.png")
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
        'FormUrunGoster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lstUrun)
        Me.Name = "FormUrunGoster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ürünler"
        Me.contextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lstUrun As ListView
    Private WithEvents imageList1 As ImageList
    Private WithEvents contextMenuStrip1 As ContextMenuStrip
    Private WithEvents ürünüDüzenleToolStripMenuItem As ToolStripMenuItem
    Private WithEvents yeniÜrünEkleToolStripMenuItem As ToolStripMenuItem
End Class
