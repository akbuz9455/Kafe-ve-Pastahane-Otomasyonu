Public Class FormUrunGruplari
    Dim comboValue As Object
    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        If txtAdi.Text = "" Then
            MessageBox.Show("Ürün Adını Boş Bırakmayınız!")
        Else

            If kontroller.veriVarmi("select Adi from UrunGrubu where Adi='" & txtAdi.Text & "'") Then
                lblBildirim.Text = "Böyle bir grup vardır."
            Else

                If Grup.grupEkle(txtAdi.Text) Then
                    txtAdi.Clear()
                    lblBildirim.ForeColor = Color.Green
                    lblBildirim.Text = "Grup Oluşturuldu."
                Else
                    txtAdi.Clear()
                    lblBildirim.ForeColor = Color.Red
                    lblBildirim.Text = "Grup Oluştururken Hata Meydana Geldi."
                End If
            End If
        End If
    End Sub

    Private Sub comboDoldur()
        Dim dt As DataTable = Veritabani.VeriGetir("select * from UrunGrubu")
        comboGruplar.DataSource = dt
        comboGruplar.DisplayMember = "Adi"
        comboGruplar.ValueMember = "UrunGrupNo"
        comboValue = comboGruplar.SelectedValue
    End Sub

    Private Sub FormUrunGruplari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboDoldur()
    End Sub

    Private Sub comboGruplar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboGruplar.SelectedIndexChanged
        comboValue = comboGruplar.SelectedValue

    End Sub

    Private Sub btnDuzenle_Click(sender As Object, e As EventArgs) Handles btnDuzenle.Click
        If comboGruplar.Text = "" OrElse txtDuzenlenenAd.Text = "" Then

            If txtDuzenlenenAd.Text = "" Then
                MessageBox.Show("Lütfen Boş Bırakmayınız!")
            End If

            If comboGruplar.Text = "" Then
                MessageBox.Show("Lütfen Grup Seçiniz.")
            End If
        Else

            If kontroller.veriVarmi("select Adi from UrunGrubu where Adi='" & txtDuzenlenenAd.Text & "'") Then
                lblBildirim.Text = "Böyle bir grup vardır."
            Else

                If Grup.grupDuzenle(comboValue, txtDuzenlenenAd.Text) Then
                    txtDuzenlenenAd.Clear()
                    lblBildirim.ForeColor = Color.Green
                    lblBildirim.Text = "Grup Başarılıyla Düzenlenmiştir."
                Else
                    txtDuzenlenenAd.Clear()
                    lblBildirim.ForeColor = Color.Green
                    lblBildirim.Text = "Grup Düzenlenirken Hata Meydana Geldi."
                End If
            End If
        End If
    End Sub

    Private Sub comboGruplar_Click(sender As Object, e As EventArgs) Handles comboGruplar.Click
        comboDoldur()

    End Sub
End Class