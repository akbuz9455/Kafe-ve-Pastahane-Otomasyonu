Imports System.IO

Public Class FormUrunDuzenle
    Private urunNo As Integer = 0
    Private comboValue As Object
    Public seciliUrunNo As Integer

    Private Sub FormUrunDuzenle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboDoldur()
        Dim urun As DataTable = Veritabani.VeriGetir("select * from Urun where SilinmisMi=False")
        Dim grup As DataTable = Veritabani.VeriGetir("select * from UrunGrubu")

        For groupIndex As Integer = 0 To grup.Rows.Count - 1
            Me.listView1.Groups.Add(grup.Rows(groupIndex)("UrunGrupNo").ToString(), grup.Rows(groupIndex)("Adi").ToString())

            For urunIndex As Integer = 0 To urun.Rows.Count - 1

                If urun.Rows(urunIndex)("UrunGrupNo").ToString() = grup.Rows(groupIndex)("UrunGrupNo").ToString() Then

                    If File.Exists(urun.Rows(urunIndex)("ResimYolu").ToString()) Then
                        Dim myImage As Image = Image.FromFile(urun.Rows(urunIndex)("ResimYolu").ToString())
                        imageList1.Images.Add(urun.Rows(urunIndex)("UrunNo").ToString(), myImage)
                        Dim item As ListViewItem = New ListViewItem(urun.Rows(urunIndex)("Adi").ToString(), urun.Rows(urunIndex)("UrunNo").ToString(), Me.listView1.Groups(groupIndex))
                        Me.listView1.Items.Insert(0, item)
                    Else
                        Dim item As ListViewItem = New ListViewItem(urun.Rows(urunIndex)("Adi").ToString(), urun.Rows(urunIndex)("UrunNo").ToString(), Me.listView1.Groups(groupIndex))
                        Me.listView1.Items.Insert(0, item)
                    End If
                End If
            Next
        Next

        If seciliUrunNo > 0 Then
            listView1.Items(seciliUrunNo - 1).Selected = True
        End If
    End Sub

    Private Sub listView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listView1.SelectedIndexChanged
        pictureBox1.Image = Nothing
        If listView1.SelectedItems.Count > 0 Then urunNo = Convert.ToInt32(listView1.SelectedItems(0).ImageKey)
        Dim urunDT As DataTable = Veritabani.VeriGetir("select * from Urun where UrunNo=" & urunNo & "")
        txtUrunAdi.Text = urunDT.Rows(0)("Adi").ToString()
        txtUrunFiyati.Text = urunDT.Rows(0)("Fiyati").ToString()
        lblResimYolu.Text = urunDT.Rows(0)("ResimYolu").ToString()
        comboUrunGrubu.SelectedValue = urunDT.Rows(0)("UrunGrupNo")

        If File.Exists(lblResimYolu.Text) Then
            pictureBox1.Image = Image.FromFile(lblResimYolu.Text)
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub comboDoldur()
        Dim dt As DataTable = Veritabani.VeriGetir("select * from UrunGrubu")
        comboUrunGrubu.DataSource = dt
        comboUrunGrubu.DisplayMember = "Adi"
        comboUrunGrubu.ValueMember = "UrunGrupNo"
        comboValue = comboUrunGrubu.SelectedValue
    End Sub

    Private Sub temizle()
        txtUrunAdi.Clear()
        txtUrunFiyati.Clear()
        pictureBox1.Image = Nothing
        lblResimYolu.Text = ""
    End Sub

    Private Sub btnDuzenle_Click(sender As Object, e As EventArgs) Handles btnDuzenle.Click
        If txtUrunAdi.Text = "" OrElse txtUrunFiyati.Text = "" OrElse lblResimYolu.Text = "" OrElse comboUrunGrubu.Text = "" Then

            If txtUrunAdi.Text = "" Then
                MessageBox.Show("Boş Alan Bırakmayınız.")
            End If

            If txtUrunFiyati.Text = "" Then
                MessageBox.Show("Boş Alan Bırakmayınız.")
            End If

            If lblResimYolu.Text = "" Then
                MessageBox.Show("Lütfen Bir Resim Yolu Seçiniz.")
            End If

            If comboUrunGrubu.Text = "" Then
                MessageBox.Show("Lütfen Grup Seçiniz.")
            End If
        Else

            If Urun.urunDuzenle(urunNo, lblResimYolu.Text, txtUrunFiyati.Text, comboValue, txtUrunAdi.Text) Then
                temizle()
                lblBildirim.ForeColor = Color.Green
                lblBildirim.Text = "Ürün Başarıyla Düzenlendi."
            Else
                temizle()
                lblBildirim.ForeColor = Color.Red
                lblBildirim.Text = "Ürün Düzenlenirken Hata!"
            End If
        End If

        listView1.Items.Clear()
        FormUrunDuzenle_Load(Nothing, Nothing)
    End Sub

    Private Sub btnGozat_Click(sender As Object, e As EventArgs) Handles btnGozat.Click
        openFileDialog1.Title = "Resimi Seçiniz"
        openFileDialog1.Filter = "Tümü|*.png;*.jpg;*ico;*.gif|png|*.png|jpeg|*.jpg|icon|*ico|gif|*.gif"
        openFileDialog1.DefaultExt = "jpg"
        openFileDialog1.RestoreDirectory = True
        openFileDialog1.FileName = ""

        If openFileDialog1.ShowDialog() = DialogResult.OK Then

            Try
                System.IO.File.Copy(openFileDialog1.FileName, openFileDialog1.SafeFileName)
                lblResimYolu.Text = openFileDialog1.SafeFileName
                pictureBox1.Image = Image.FromFile(lblResimYolu.Text)
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Catch hata As Exception
                MessageBox.Show(hata.Message & " Aynı ürün resmi mevcut")
            End Try
        End If
    End Sub

    Private Sub comboUrunGrubu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboUrunGrubu.SelectedIndexChanged
        comboValue = comboUrunGrubu.SelectedValue
    End Sub

    Private Sub txtUrunFiyati_TextChanged(sender As Object, e As EventArgs) Handles txtUrunFiyati.TextChanged

    End Sub

    Private Sub txtUrunFiyati_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUrunFiyati.KeyPress
        If txtUrunFiyati.Text.IndexOf(","c) <> -1 Then

            If e.KeyChar = ChrW(44) Then
                e.Handled = True
            End If
        End If

        kontroller.txtParaKontrol(e)
    End Sub

    Private Sub btnUrunSil_Click(sender As Object, e As EventArgs) Handles btnUrunSil.Click
        If txtUrunAdi.Text = "" OrElse txtUrunFiyati.Text = "" OrElse lblResimYolu.Text = "" OrElse comboUrunGrubu.Text = "" OrElse urunNo = 0 Then
            MessageBox.Show("Lütfen ürün seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            Dim sonuc As DialogResult = MessageBox.Show("Ürünü silmek istediğinizden emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If sonuc = DialogResult.Yes Then
                Urun.urunDuzenle(urunNo, True)
                temizle()
                listView1.Items.Clear()
                FormUrunDuzenle_Load(Nothing, Nothing)
            End If
        End If
    End Sub
End Class