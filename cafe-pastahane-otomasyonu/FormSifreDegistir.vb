Public Class FormSifreDegistir
    Private Sub btnDegistir_Click(sender As Object, e As EventArgs) Handles btnDegistir.Click
        If txtEskiSifre.Text = "" OrElse txtYeniSifre.Text = "" OrElse txtYeniSifre.Text = "" Then
            errorProvider1.SetError(lblBildirim, "Lütfen boş alan bırakmayınız!")
        Else

            If Not kontroller.kullaniciKontrolu(Form1.kulAdi, Islemler.MD5eDonustur(txtEskiSifre.Text)) Then
                MessageBox.Show("Şifreniz Yanlış!")
            Else

                If txtYeniSifre.Text = txtYeniSifreTekrar.Text Then

                    If Kullanici.KullaniciSifreDegistir(Form1.kulAdi, Islemler.MD5eDonustur(txtYeniSifre.Text)) Then
                        lblBildirim.ForeColor = Color.Green
                        lblBildirim.Text = "Şifre Değiştirildi."

                    Else
                        lblBildirim.ForeColor = Color.Red
                        lblBildirim.Text = "Şifre Değiştirilemedi!"
                    End If
                Else
                    lblBildirim.ForeColor = Color.Red
                    lblBildirim.Text = "Şifreler Uyumuşmuyor!"
                End If
            End If
        End If
    End Sub

    Private Sub FormSifreDegistir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Form1.kulAdi & " Şifresi Değiştiriliyor"
    End Sub
End Class