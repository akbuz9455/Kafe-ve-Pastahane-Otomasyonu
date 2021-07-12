Public Class AnaForm
    Public Shared MasaNumarasi As Integer
    Public Shared masaSayisi As Integer
    Public Shared ayaraGit As Boolean
    Private doluMasaSayisi As Integer = 0
    Public Shared anaFrm As AnaForm

    Private Sub AnaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        anaFrm = Me
        Dim dt As DataTable = Veritabani.VeriGetir("select * from Ayar")
        Dim masa As DataTable = Veritabani.VeriGetir("select MasaSayisi from Ayar")

        For i As Integer = 0 To Integer.Parse(masa.Rows(0)("MasaSayisi").ToString()) - 1

            If kontroller.veriVarmi("select * from Siparis where MasaNo=" & (i + 1) & " AND Hesap=True") Then
                lstMasa.Items.Add((i + 1) & ".Masa")
                lstMasa.Items(i).ImageKey = "doluMasa.jpg"
                doluMasaSayisi += 1
            Else
                lstMasa.Items.Add((i + 1) & ".Masa")
                lstMasa.Items(i).ImageKey = "bosMasa.png"
            End If
        Next

        masaSayisi = Convert.ToInt32(masa.Rows(0)("MasaSayisi").ToString())
    End Sub



    Private Sub ürünEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ürünEkleToolStripMenuItem.Click
        Dim frmUrunEkle As FormUrunEkle = New FormUrunEkle()
        frmUrunEkle.ShowDialog()
    End Sub

    Private Sub ürünDüzenleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ürünDüzenleToolStripMenuItem.Click
        Dim frm As FormUrunDuzenle = New FormUrunDuzenle()
        frm.ShowDialog()
    End Sub

    Private Sub ürünSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ürünSilToolStripMenuItem.Click
        Dim frmUrunGoster As FormUrunGoster = New FormUrunGoster()
        frmUrunGoster.ShowDialog()
    End Sub

    Public Sub lstMasa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMasa.SelectedIndexChanged
        If lstMasa.SelectedItems.Count > 0 Then
            Dim masaNo As Integer = Convert.ToInt32(lstMasa.SelectedItems(0).Text.Substring(0, lstMasa.SelectedItems(0).Text.IndexOf("."c)))
        End If
    End Sub

    Private Sub lstMasa_MouseClick(sender As Object, e As MouseEventArgs) Handles lstMasa.MouseClick
        If e.Button = MouseButtons.Right Then

            If lstMasa.FocusedItem.Bounds.Contains(e.Location) = True Then
                contextMenuStrip1.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub masayiKapatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles masayiKapatToolStripMenuItem.Click
        If lstMasa.SelectedItems.Count > 0 AndAlso lstMasa.SelectedItems(0).ImageKey = "doluMasa.jpg" Then
            Dim masaNo As Integer = Convert.ToInt32(lstMasa.SelectedItems(0).Text.Substring(0, lstMasa.SelectedItems(0).Text.IndexOf("."c)))
            Dim siparisNo As Integer = Siparis.siparisNoGetir(masaNo)

            If MessageBox.Show("Eğer masayı kapatırsanız hesap ödenmeden masa içerisindeki ürünler kaldırılacaktır." & vbLf & "(*Raporlarda kapatılan masaların bilgilerini göremezsiniz.)" & vbLf & "Devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                If Siparis.siparisUrunTemizle(siparisNo) Then

                    If Siparis.siparisTemizle(siparisNo) Then
                        lstMasa.SelectedItems(0).ImageKey = "bosMasa.png"
                        AnaForm.anaFrm.lstMasa_SelectedIndexChanged(Nothing, Nothing)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub satışlarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles satışlarToolStripMenuItem.Click
        Dim frm As istatistikler = New istatistikler()
        frm.ShowDialog()
    End Sub

    Private Sub yeniKullanıcıOluşturToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles yeniKullanıcıOluşturToolStripMenuItem.Click
        Dim frm As FormKullaniciEkle = New FormKullaniciEkle()
        frm.ShowDialog()
    End Sub

    Private Sub AnaForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.[Exit]()
    End Sub

    Private Sub lstMasa_DoubleClick(sender As Object, e As EventArgs) Handles lstMasa.DoubleClick
        Try
            MasaNumarasi = (Integer.Parse(lstMasa.SelectedIndices(0).ToString()) + 1)

            Dim frmMasa As FormMasa = New FormMasa()
            frmMasa.ShowDialog()
        Catch hata As Exception
            MessageBox.Show(hata.Message)
        End Try
    End Sub
    Private Sub listView1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
        Try
            MasaNumarasi = (Integer.Parse(lstMasa.SelectedIndices(0).ToString()) + 1)
            Dim frmMasa As FormMasa = New FormMasa()
            frmMasa.ShowDialog()
        Catch hata As Exception
            MessageBox.Show(hata.Message)
        End Try
    End Sub

    Private Sub şifreDeğiştirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles şifreDeğiştirToolStripMenuItem.Click
        Dim frm As FormSifreDegistir = New FormSifreDegistir()
        frm.ShowDialog()
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Application.[Exit]()

    End Sub
End Class