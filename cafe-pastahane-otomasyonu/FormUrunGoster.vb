Imports System.IO

Public Class FormUrunGoster
    Public seciliUrunNo As Integer


    Private Sub urunGoster()
        Dim UrunDT As DataTable = Veritabani.VeriGetir("select * from Urun where SilinmisMi=False")
        Dim urun As DataTable = Veritabani.VeriGetir("select * from Urun")
        Dim grup As DataTable = Veritabani.VeriGetir("select * from UrunGrubu")

        For groupIndex As Integer = 0 To grup.Rows.Count - 1
            Me.lstUrun.Groups.Add(grup.Rows(groupIndex)("UrunGrupNo").ToString(), grup.Rows(groupIndex)("Adi").ToString())

            For urunIndex As Integer = 0 To UrunDT.Rows.Count - 1

                If UrunDT.Rows(urunIndex)("UrunGrupNo").ToString() = grup.Rows(groupIndex)("UrunGrupNo").ToString() Then

                    If File.Exists(UrunDT.Rows(urunIndex)("ResimYolu").ToString()) Then
                        Dim myImage As Image = Image.FromFile(UrunDT.Rows(urunIndex)("ResimYolu").ToString())
                        imageList1.Images.Add(UrunDT.Rows(urunIndex)("UrunNo").ToString(), myImage)
                        Dim item As ListViewItem = New ListViewItem(UrunDT.Rows(urunIndex)("Adi").ToString() & vbLf + UrunDT.Rows(urunIndex)("Fiyati").ToString() & " ₺", UrunDT.Rows(urunIndex)("UrunNo").ToString(), Me.lstUrun.Groups(groupIndex))
                        Me.lstUrun.Items.Insert(0, item)
                        Me.lstUrun.Groups(groupIndex).Items.Insert(0, item)
                    Else
                        Dim item As ListViewItem = New ListViewItem(UrunDT.Rows(urunIndex)("Adi").ToString(), UrunDT.Rows(urunIndex)("UrunNo").ToString(), Me.lstUrun.Groups(groupIndex))
                        Me.lstUrun.Items.Insert(0, item)
                        Me.lstUrun.Groups(groupIndex).Items.Insert(0, item)
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub FormUrunGoster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        urunGoster()
    End Sub

    Private Sub ürünüDüzenleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ürünüDüzenleToolStripMenuItem.Click
        Dim frm As FormUrunDuzenle = New FormUrunDuzenle()
        frm.seciliUrunNo = seciliUrunNo
        frm.ShowDialog()
    End Sub

    Private Sub yeniÜrünEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles yeniÜrünEkleToolStripMenuItem.Click
        Dim frm As FormUrunEkle = New FormUrunEkle()
        frm.ShowDialog()
    End Sub

    Private Sub lstUrun_MouseClick(sender As Object, e As MouseEventArgs) Handles lstUrun.MouseClick
        If e.Button = MouseButtons.Right Then

            If lstUrun.FocusedItem.Bounds.Contains(e.Location) = True Then
                contextMenuStrip1.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub lstUrun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUrun.SelectedIndexChanged
        If lstUrun.SelectedItems.Count > 0 Then
            seciliUrunNo = Integer.Parse(lstUrun.SelectedIndices(0).ToString()) + 1
        End If
    End Sub
End Class