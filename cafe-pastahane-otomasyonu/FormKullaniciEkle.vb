Public Class FormKullaniciEkle
    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        If txtKulAdi.Text = "" OrElse txtSifre.Text = "" OrElse txtAdi.Text = "" OrElse txtSoyadi.Text = "" Then
            MessageBox.Show("Lütfen boş alan bırakmayınız!")
        Else

            If kontroller.veriVarmi("select KullaniciAdi from Kullanici where KullaniciAdi='" & txtKulAdi.Text & "'") Then
                lblBildirim.ForeColor = Color.Red
                lblBildirim.Text = "Böyle bir kullanıcı var!."
            Else

                If Kullanici.KullaniciEkle(txtKulAdi.Text, Islemler.MD5eDonustur(txtSifre.Text), txtAdi.Text, txtSoyadi.Text) Then
                    lblBildirim.ForeColor = Color.Green
                    lblBildirim.Text = "Başarıyla kullanıcı eklenmiştir."
                    txtAdi.Text = ""
                    txtKulAdi.Text = ""
                    txtSifre.Text = ""
                    txtSoyadi.Text = ""
                Else
                    lblBildirim.ForeColor = Color.Red
                    lblBildirim.Text = "Kullanıcı eklenemedi!."
                End If
            End If
        End If
    End Sub
End Class