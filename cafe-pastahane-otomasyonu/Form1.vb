Public Class Form1
    Public Shared durum As Boolean
    Public Shared kulAdi As String

    Private Sub btnGiris_Click(sender As Object, e As EventArgs) Handles btnGiris.Click
        If txtKullaniciAdi.Text = "" Then
            MessageBox.Show("Alanları Boş Geçmeyiniz!")
        ElseIf txtSifre.Text = "" Then
            MessageBox.Show("Şifreyi Boş Geçmeyiniz!")
        Else

            If kontroller.kullaniciKontrolu(txtKullaniciAdi.Text, Islemler.MD5eDonustur(txtSifre.Text)) = False Then
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!")
            Else
                durum = True
                kulAdi = txtKullaniciAdi.Text
                Dim frmAna As AnaForm = New AnaForm()
                frmAna.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Application.[Exit]()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not durum Then
            Application.[Exit]()
        End If
    End Sub
End Class
