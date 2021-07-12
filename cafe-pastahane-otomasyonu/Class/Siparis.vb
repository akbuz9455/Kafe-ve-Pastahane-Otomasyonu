Imports System.Data.OleDb

Public Class Siparis
    Public Shared Function siparisEkle(ByVal masaNo As Object) As Boolean
        Veritabani.baglantiKontrol()

        Try
            Dim cmd As OleDbCommand = New OleDbCommand("insert into Siparis (MasaNo,Hesap) values (@masano,True)", Veritabani.con)
            cmd.Parameters.Add("@masano", OleDbType.Integer).Value = masaNo
            cmd.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Shared Function siparisUrunEkle(ByVal siparisNo As Object, ByVal urunNo As Object, ByVal urunAdet As Object) As Boolean
        Veritabani.baglantiKontrol()

        Try
            Dim cmd As OleDbCommand = New OleDbCommand("insert into SiparisUrun (SiparisNo,UrunNo,UrunAdet) values (@siparisNo,@urunNo,@urunAdet)", Veritabani.con)
            cmd.Parameters.Add("@siparisNo", OleDbType.Integer).Value = siparisNo
            cmd.Parameters.Add("@urunNo", OleDbType.Integer).Value = urunNo
            cmd.Parameters.Add("@urunAdet", OleDbType.Integer).Value = urunAdet
            cmd.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Shared Function siparisUrunTemizle(ByVal siparisNo As Object) As Boolean
        Veritabani.baglantiKontrol()

        Try
            Dim sil As OleDbCommand = New OleDbCommand("delete from SiparisUrun where SiparisNo=@siparisNo", Veritabani.con)
            sil.Parameters.Add("@siparisNo", OleDbType.Integer).Value = siparisNo
            sil.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Shared Function siparisTemizle(ByVal siparisNo As Object) As Boolean
        Veritabani.baglantiKontrol()

        Try
            Dim sil As OleDbCommand = New OleDbCommand("delete from Siparis where SiparisNo=@siparisNo", Veritabani.con)
            sil.Parameters.Add("@siparisNo", OleDbType.Integer).Value = siparisNo
            sil.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Shared Function siparisNoGetir(ByVal masaNo As Object) As Integer
        Dim dt As DataTable = Veritabani.VeriGetir("select SiparisNo from Siparis where MasaNo=" & masaNo & " AND Hesap=True")

        If dt.Rows.Count > 0 Then
            Dim siparisNo As Integer = Convert.ToInt32(dt.Rows(0)(0).ToString())
            Return siparisNo
        Else
            Return -1
        End If
    End Function
End Class
