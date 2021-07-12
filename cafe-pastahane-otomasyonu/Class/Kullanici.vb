Imports System.Data.OleDb

Public Class Kullanici
    Public Shared Function KullaniciEkle(ByVal KullaniciAdi As Object, ByVal Sifre As Object, ByVal Adi As Object, ByVal Soyadi As Object) As Boolean
        Veritabani.baglantiKontrol()

        Try
            Dim cmd As OleDbCommand = New OleDbCommand("insert into Kullanici (KullaniciAdi,Sifre,Adi,Soyadi) values (@KullaniciAdi,@Sifre,@Adi,@Soyadi)", Veritabani.con)
            cmd.Parameters.Add("@KullaniciAdi", OleDbType.VarWChar).Value = KullaniciAdi
            cmd.Parameters.Add("@Sifre", OleDbType.VarWChar).Value = Sifre
            cmd.Parameters.Add("@Adi", OleDbType.VarWChar).Value = Adi
            cmd.Parameters.Add("@Soyadi", OleDbType.VarWChar).Value = Soyadi
            cmd.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Shared Function KullaniciSifreDegistir(ByVal KullaniciAdi As Object, ByVal Sifre As Object) As Boolean
        Veritabani.baglantiKontrol()

        Try
            Dim cmd As OleDbCommand = New OleDbCommand("update Kullanici set Sifre=@Sifre where KullaniciAdi=@KullaniciAdi", Veritabani.con)
            cmd.Parameters.Add("@Sifre", OleDbType.VarWChar).Value = Sifre
            cmd.Parameters.Add("@KullaniciAdi", OleDbType.VarWChar).Value = KullaniciAdi
            cmd.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function
End Class
