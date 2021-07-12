Imports System.Data.OleDb

Public Class Urun
    Public Shared Function urunEkle(ByVal adi As Object, ByVal fiyati As Object, ByVal grupNo As Object, ByVal resimYolu As Object) As Boolean
        Veritabani.baglantiKontrol()

        Try
            Dim cmd As OleDbCommand = New OleDbCommand("insert into Urun (Adi,Fiyati,UrunGrupNo,ResimYolu) values (@adi,@fiyati,@urungrupno,@resimyolu)", Veritabani.con)
            cmd.Parameters.Add("@adi", OleDbType.VarWChar).Value = adi
            cmd.Parameters.Add("@fiyati", OleDbType.Currency).Value = fiyati
            cmd.Parameters.Add("@urungrupno", OleDbType.Integer).Value = grupNo
            cmd.Parameters.Add("@resimyolu", OleDbType.VarWChar).Value = resimYolu
            cmd.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Shared Function urunDuzenle(ByVal urunNo As Object, ByVal resimYolu As Object, ByVal fiyat As Object, ByVal grupNo As Object, ByVal urunAdi As Object) As Boolean
        Veritabani.baglantiKontrol()

        Try
            Dim cmd As OleDbCommand = New OleDbCommand("update Urun set ResimYolu=@resimyolu, Fiyati=@fiyati, UrunGrupNo=@urungrupno, Adi=@adi  where UrunNo=@urunno", Veritabani.con)
            cmd.Parameters.Add("@resimyolu", OleDbType.VarWChar).Value = resimYolu
            cmd.Parameters.Add("@fiyati", OleDbType.Currency).Value = fiyat
            cmd.Parameters.Add("@urungrupno", OleDbType.Integer).Value = grupNo
            cmd.Parameters.Add("@adi", OleDbType.VarWChar).Value = urunAdi
            cmd.Parameters.Add("@urunno", OleDbType.Integer).Value = urunNo
            cmd.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Shared Function urunDuzenle(ByVal UrunNo As Object, ByVal SilinmisMi As Boolean) As Boolean
        Veritabani.baglantiKontrol()

        Try
            Dim cmd As OleDbCommand = New OleDbCommand("update Urun set SilinmisMi=@SilinmisMi where UrunNo=@UrunNo", Veritabani.con)
            cmd.Parameters.Add("@SilinmisMi", OleDbType.Boolean).Value = SilinmisMi
            cmd.Parameters.Add("@UrunNo", OleDbType.Integer).Value = UrunNo
            cmd.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function
End Class
