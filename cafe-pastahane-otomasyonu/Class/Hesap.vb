Imports System.Data.OleDb

Public Class Hesap
    Public Shared Function hesapOde(ByVal siparisNo As Object, ByVal odemeTuru As Object, ByVal tutar As Object) As Boolean
        Veritabani.baglantiKontrol()

        Try
            Dim Siparis As OleDbCommand = New OleDbCommand("update Siparis set Hesap=False where SiparisNo=" & siparisNo & " ", Veritabani.con)
            Siparis.ExecuteNonQuery()
            Dim Hesap As OleDbCommand = New OleDbCommand("insert into Hesap (SiparisNo,OdemeTuruNo,Tutar) values (@siparisNo,@odemeTuruNo,@tutar)", Veritabani.con)
            Hesap.Parameters.Add("@siparisNo", OleDbType.Integer).Value = siparisNo
            Hesap.Parameters.Add("@odemeTuruNo", OleDbType.TinyInt).Value = odemeTuru
            Hesap.Parameters.Add("@tutar", OleDbType.Currency).Value = tutar
            Hesap.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function
End Class
