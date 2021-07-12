Public Class FormUrunEkle

    Dim comboValue As Object
    Private Sub btnUrunGozat_Click(sender As Object, e As EventArgs) Handles btnUrunGozat.Click
       openFileDialog1.Title = "Resimi Seçiniz"
    openFileDialog1.Filter = "Tümü|*.png;*.jpg;*ico;*.gif|png|*.png|jpeg|*.jpg|icon|*ico|gif|*.gif"
    openFileDialog1.DefaultExt = "jpg"
    openFileDialog1.RestoreDirectory = True
    openFileDialog1.FileName = ""

    If openFileDialog1.ShowDialog() = DialogResult.OK Then

        Try
            System.IO.File.Copy(openFileDialog1.FileName, openFileDialog1.SafeFileName)
            lblGozat.Text = openFileDialog1.SafeFileName
            pictureBox1.Image = Image.FromFile(lblGozat.Text)
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Catch hata As Exception
            MessageBox.Show(hata.Message & " Aynı ürün resmi mevcut")
        End Try
    End If
    End Sub

    Private Sub btnGrupEkle_Click(sender As Object, e As EventArgs) Handles btnGrupEkle.Click
        Dim frm As FormUrunGruplari = New FormUrunGruplari()
        frm.ShowDialog()
    End Sub

    Private Sub comboDoldur()
        Dim dt As DataTable = Veritabani.VeriGetir("select * from UrunGrubu")
        comboGrup.DataSource = dt
        comboGrup.DisplayMember = "Adi"
        comboGrup.ValueMember = "UrunGrupNo"
        comboValue = comboGrup.SelectedValue
    End Sub

    Private Sub groupBox1_Enter(sender As Object, e As EventArgs) Handles groupBox1.Enter

    End Sub

    Private Sub FormUrunEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboDoldur()
    End Sub

    Private Sub btnUrunEkle_Click(sender As Object, e As EventArgs) Handles btnUrunEkle.Click
        If txtUrunAdi.Text = "" OrElse txtUrunFiyati.Text = "" OrElse comboGrup.Text = "" Then

            If txtUrunAdi.Text = "" Then
                MessageBox.Show("Boş Geçmeyiniz.")
            End If

            If txtUrunFiyati.Text = "" Then
                MessageBox.Show("Boş Geçmeyiniz.")
            End If

            If comboGrup.Text = "" Then
                MessageBox.Show("Lütfen Grup Seçiniz.")
            End If
        Else

            If kontroller.veriVarmi("select Adi from Urun where Adi='" & txtUrunAdi.Text & "'") Then
                lblBildirim.Text = "Böyle bir ürün vardır."
            Else

                If lblGozat.Text = "" Then
                    MessageBox.Show("Resim ekleyiniz")
                End If

                If Urun.urunEkle(txtUrunAdi.Text, txtUrunFiyati.Text, comboValue, lblGozat.Text) Then
                    txtUrunAdi.Clear()
                    txtUrunFiyati.Clear()
                    comboGrup.SelectedIndex = 0
                    pictureBox1.Image = Nothing
                    lblGozat.Text = ""
                    lblBildirim.ForeColor = Color.Green
                    lblBildirim.Text = "Ürün Başarıyla Eklenmiştir."
                Else
                    txtUrunAdi.Clear()
                    txtUrunFiyati.Clear()
                    comboGrup.SelectedIndex = 0
                    pictureBox1.Image = Nothing
                    lblGozat.Text = ""
                    lblBildirim.ForeColor = Color.Red
                    lblBildirim.Text = "Ürün Eklenirken Hata!"
                End If
            End If
        End If
    End Sub

    Private Sub FormUrunEkle_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub comboGrup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboGrup.SelectedIndexChanged
        comboValue = comboGrup.SelectedValue

    End Sub

    Private Sub comboGrup_Click(sender As Object, e As EventArgs) Handles comboGrup.Click
        Dim dt As DataTable = Veritabani.VeriGetir("select * from UrunGrubu")
        comboGrup.DataSource = dt
        comboGrup.DisplayMember = "Adi"
        comboGrup.ValueMember = "UrunGrupNo"
    End Sub

    Private Sub txtUrunFiyati_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUrunFiyati.KeyPress
        If txtUrunFiyati.Text.IndexOf(","c) <> -1 Then

            If e.KeyChar = ChrW(44) Then
                e.Handled = True
            End If
        End If

        kontroller.txtParaKontrol(e)
    End Sub

    Private Sub btnUrunGoster_Click(sender As Object, e As EventArgs) Handles btnUrunGoster.Click
        Dim frm As FormUrunGoster = New FormUrunGoster()
        frm.ShowDialog()
    End Sub
End Class