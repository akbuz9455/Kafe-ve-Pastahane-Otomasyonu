Imports System.IO

Public Class FormMasa
    Dim masaNo As Integer
    Dim siparisNo As Integer

    Private Sub urunGoster()
        Dim urun As DataTable = Veritabani.VeriGetir("select * from Urun where SilinmisMi=False")
        Dim grup As DataTable = Veritabani.VeriGetir("select * from UrunGrubu")

        For groupIndex As Integer = 0 To grup.Rows.Count - 1
            Me.lstUrunler.Groups.Add(grup.Rows(groupIndex)("UrunGrupNo").ToString(), grup.Rows(groupIndex)("Adi").ToString())

            For urunIndex As Integer = 0 To urun.Rows.Count - 1

                If urun.Rows(urunIndex)("UrunGrupNo").ToString() = grup.Rows(groupIndex)("UrunGrupNo").ToString() Then

                    If File.Exists(urun.Rows(urunIndex)("ResimYolu").ToString()) Then
                        Dim myImage As Image = Image.FromFile(urun.Rows(urunIndex)("ResimYolu").ToString())
                        imageList1.Images.Add(urun.Rows(urunIndex)("UrunNo").ToString(), myImage)
                        Dim item As ListViewItem = New ListViewItem(urun.Rows(urunIndex)("Adi").ToString() & "-" + urun.Rows(urunIndex)("Fiyati").ToString() & " ₺", urun.Rows(urunIndex)("UrunNo").ToString(), Me.lstUrunler.Groups(groupIndex))
                        Me.lstUrunler.Items.Insert(0, item)
                    Else
                        Dim item As ListViewItem = New ListViewItem(urun.Rows(urunIndex)("Adi").ToString() & "-" + urun.Rows(urunIndex)("Fiyati").ToString() & " ₺", urun.Rows(urunIndex)("UrunNo").ToString(), Me.lstUrunler.Groups(groupIndex))
                        Me.lstUrunler.Items.Insert(0, item)
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub sepetUrunGoster()
        Try
            Dim siparisNo As Integer = Siparis.siparisNoGetir(masaNo)

            If kontroller.veriVarmi("select * from SiparisUrun where SiparisNo=" & siparisNo & "") Then
                Dim siparisUrun As DataTable = Veritabani.VeriGetir("select Urun.UrunNo as UrunNo,SiparisUrun.UrunAdet as UrunAdet,Urun.Adi as Adi,Urun.Fiyati as Fiyati,Urun.ResimYolu as ResimYolu from SiparisUrun inner join Urun on SiparisUrun.UrunNo=Urun.UrunNo where SiparisUrun.SiparisNo=" & siparisNo & "")

                For urunIndex As Integer = 0 To siparisUrun.Rows.Count - 1

                    For i As Integer = 0 To Convert.ToInt32(siparisUrun.Rows(urunIndex)("UrunAdet").ToString()) - 1

                        If File.Exists(siparisUrun.Rows(urunIndex)("ResimYolu").ToString()) Then
                            Dim myImage As Image = Image.FromFile(siparisUrun.Rows(urunIndex)("ResimYolu").ToString())
                            imageList1.Images.Add(siparisUrun.Rows(urunIndex)("UrunNo").ToString(), myImage)
                            Dim item As ListViewItem = New ListViewItem(siparisUrun.Rows(urunIndex)("Adi").ToString() & "-" + siparisUrun.Rows(urunIndex)("Fiyati").ToString() & " ₺", siparisUrun.Rows(urunIndex)("UrunNo").ToString(), Me.lstUrunler.Groups(0))
                            Me.lstSepet.Items.Insert(0, item)
                            Me.lstSepet.Groups(0).Items.Insert(0, item)
                            Dim fiyati As Double = Convert.ToDouble(item.Text.Substring(item.Text.IndexOf("-"c) + 1, item.Text.LastIndexOf(" "c) - item.Text.LastIndexOf("-"c)))
                            txtToplam.Text = (Convert.ToDouble(txtToplam.Text) + fiyati).ToString()
                        Else
                            Dim item As ListViewItem = New ListViewItem(siparisUrun.Rows(urunIndex)("Adi").ToString() & "-" + siparisUrun.Rows(urunIndex)("Fiyati").ToString() & " ₺", siparisUrun.Rows(urunIndex)("UrunNo").ToString(), Me.lstSepet.Groups(0))
                            Me.lstSepet.Items.Insert(0, item)
                            Me.lstSepet.Groups(0).Items.Insert(0, item)
                            Dim fiyati As Double = Convert.ToDouble(item.Text.Substring(item.Text.IndexOf("-"c) + 1, item.Text.LastIndexOf(" "c) - item.Text.LastIndexOf("-"c)))
                            txtToplam.Text = (Convert.ToDouble(txtToplam.Text) + fiyati).ToString()
                        End If
                    Next
                Next
            End If

        Catch
            MessageBox.Show("SepetUrunGoster Metodunda hata")
        End Try
    End Sub

    Private Sub comboDoldur()
        Dim dt As DataTable = Veritabani.VeriGetir("select * from OdemeTuru")
        comboOdemeTuru.DataSource = dt
        comboOdemeTuru.DisplayMember = "Adi"
        comboOdemeTuru.ValueMember = "OdemeTuruNo"
    End Sub


    Private Sub siparisleriKaydet()
        If lstSepet.Items.Count > 0 Then

            If kontroller.veriVarmi("select * from Siparis where MasaNo=" & masaNo & " AND Hesap=True") Then
                Dim siparisNo As Integer = Siparis.siparisNoGetir(masaNo)

                If Siparis.siparisUrunTemizle(siparisNo) Then

                    For Each item As ListViewItem In lstSepet.Items

                        If item.Group.Equals(lstSepet.Groups(0)) Then

                            ' If Not kontroller.veriVarmi("select UrunNo from SiparisUrun where UrunNo=" & item.ImageKey & " AND SiparisNo=" + siparisNo & "") Then
                            Dim urunAdeti As Integer = 0

                                For i As Integer = 0 To lstSepet.Groups(0).Items.Count - 1

                                    If item.ImageKey = lstSepet.Groups(0).Items(i).ImageKey Then
                                        urunAdeti += 1
                                    End If
                                Next

                                If Siparis.siparisUrunEkle(siparisNo, item.ImageKey, urunAdeti) Then
                                Else
                                    MessageBox.Show("Ürünler eklenirken hata!")
                                End If
                                ' End If
                            Else
                        End If
                    Next
                End If
            Else

                If Siparis.siparisEkle(masaNo) Then
                    Dim siparisNo As Integer = Siparis.siparisNoGetir(masaNo)

                    For Each item As ListViewItem In lstSepet.Items

                        If item.Group.Equals(lstSepet.Groups(0)) Then

                            '    If Not kontroller.veriVarmi("select UrunNo from SiparisUrun where UrunNo=" & item.ImageKey & " AND SiparisNo=" + siparisNo & "") Then
                            Dim urunAdeti As Integer = 0

                                For i As Integer = 0 To lstSepet.Groups(0).Items.Count - 1

                                    If item.ImageKey = lstSepet.Groups(0).Items(i).ImageKey Then
                                        urunAdeti += 1
                                    End If
                                Next

                                If Siparis.siparisUrunEkle(siparisNo, item.ImageKey, urunAdeti) Then
                                Else
                                    MessageBox.Show("Ürünler eklenirken hata!")
                                End If
                                ' End If
                            End If
                    Next
                Else
                    MessageBox.Show("Siparisler eklenirken hata meydana geldi.")
                End If
            End If
        End If
    End Sub

    Private Sub FormMasa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Masa " & AnaForm.MasaNumarasi.ToString()
        masaNo = Convert.ToInt32(Me.Text.Substring(Convert.ToInt32(Me.Text.IndexOf(" "c))))
        grpUrun.Visible = True
        urunGoster()
        comboDoldur()
        Me.lstSepet.Groups.Add("0", "Ürünler")
        Dim siparisNo As Integer = Siparis.siparisNoGetir(masaNo)

        If siparisNo <> -1 Then
            sepetUrunGoster()
        End If
    End Sub

    Private Sub lstSepet_DoubleClick(sender As Object, e As EventArgs) Handles lstSepet.DoubleClick
        For Each seciliItem As ListViewItem In lstSepet.SelectedItems
            Dim fiyati As Double = Convert.ToDouble(seciliItem.Text.Substring(seciliItem.Text.IndexOf("-"c) + 1, seciliItem.Text.LastIndexOf(" "c) - seciliItem.Text.LastIndexOf("-"c)))
            txtToplam.Text = (Convert.ToDouble(txtToplam.Text) - fiyati).ToString()
            lstSepet.Items(seciliItem.Index).Remove()
        Next
    End Sub

    Private Sub FormMasa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If lstSepet.Items.Count > 0 Then
            siparisleriKaydet()

            If AnaForm.anaFrm.lstMasa.Items(masaNo - 1).ImageKey = "bosMasa.png" Then
                AnaForm.anaFrm.lstMasa.Items(masaNo - 1).ImageKey = "doluMasa.jpg"
            End If
        End If

        AnaForm.anaFrm.lstMasa_SelectedIndexChanged(Nothing, Nothing)
    End Sub



    Private Sub btnHesapOde_Click(sender As Object, e As EventArgs) Handles btnHesapOde.Click
        If lstSepet.Items.Count > 0 Then

            If MessageBox.Show("Hesabı Ödemek İstiyor Musunuz?", "Hesap Öde", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                siparisleriKaydet()
                siparisNo = Siparis.siparisNoGetir(masaNo)

                If Hesap.hesapOde(siparisNo, comboOdemeTuru.SelectedValue, txtToplam.Text) Then

                    If comboOdemeTuru.SelectedIndex = 0 Then
                    End If
                End If

                If AnaForm.anaFrm.lstMasa.Items(masaNo - 1).ImageKey = "doluMasa.jpg" Then
                    AnaForm.anaFrm.lstMasa.Items(masaNo - 1).ImageKey = "bosMasa.png"
                End If

                lstSepet.Items.Clear()
            End If
        End If
    End Sub

    Private Sub txtVerilenMiktar_TextChanged(sender As Object, e As EventArgs) Handles txtVerilenMiktar.TextChanged

        ' If txtVerilenMiktar.Text <> "" Then
        'txtParaUstu.Text = (Convert.ToInt64(txtVerilenMiktar.Text.ToString) - Convert.ToInt64(txtToplam.Text.ToString)).ToString
        'Else
        '  txtParaUstu.Text = 
        ' End If
    End Sub

    Private Sub txtVerilenMiktar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVerilenMiktar.KeyPress
        If txtVerilenMiktar.Text.IndexOf(","c) <> -1 Then

            If e.KeyChar = ChrW(44) Then
                e.Handled = True
            End If
        End If

        kontroller.txtParaKontrol(e)
    End Sub

    Private Sub btnUrunEkle_Click(sender As Object, e As EventArgs) Handles btnUrunEkle.Click
        If lstUrunler.SelectedItems.Count > 0 Then

            For Each seciliItem As ListViewItem In lstUrunler.SelectedItems
                Dim fiyati As Double = Convert.ToDouble(seciliItem.Text.Substring(seciliItem.Text.IndexOf("-"c) + 1, seciliItem.Text.LastIndexOf(" "c) - seciliItem.Text.LastIndexOf("-"c)))
                txtToplam.Text = (Convert.ToDouble(txtToplam.Text) + fiyati).ToString()
                Dim item As ListViewItem = New ListViewItem(lstUrunler.Items(seciliItem.Index).Text, lstUrunler.Items(seciliItem.Index).ImageKey, Me.lstSepet.Groups(0))
                Me.lstSepet.Items.Insert(0, item)
                lstUrunler.SelectedItems(0).Selected = False
            Next
        End If
    End Sub

    Private Sub txtToplam_TextChanged(sender As Object, e As EventArgs) Handles txtToplam.TextChanged
        txtVerilenMiktar_TextChanged(Nothing, Nothing)

    End Sub

    Private Sub btnUrunSil_Click(sender As Object, e As EventArgs) Handles btnUrunSil.Click
        For Each seciliItem As ListViewItem In lstSepet.SelectedItems
            Dim fiyati As Double = Convert.ToDouble(seciliItem.Text.Substring(seciliItem.Text.IndexOf("-"c) + 1, seciliItem.Text.LastIndexOf(" "c) - seciliItem.Text.LastIndexOf("-"c)))
            txtToplam.Text = (Convert.ToDouble(txtToplam.Text) - fiyati).ToString()
            lstSepet.Items(seciliItem.Index).Remove()
        Next
    End Sub

    Private Sub groupBox1_Enter(sender As Object, e As EventArgs) Handles groupBox1.Enter

    End Sub
End Class