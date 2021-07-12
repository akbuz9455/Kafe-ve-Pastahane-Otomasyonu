Imports System.Security.Cryptography
Imports System.Text

Public Class Islemler
    Public Shared Function MD5eDonustur(ByVal metin As String) As String
        Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
        Dim Girdi As Byte() = Encoding.UTF8.GetBytes(metin)
        Girdi = md5.ComputeHash(Girdi)
        Dim StringBuilderler As StringBuilder = New StringBuilder()

        For Each ba As Byte In Girdi
            StringBuilderler.Append(ba.ToString("x2").ToLower())
        Next

        Return StringBuilderler.ToString()
    End Function
End Class
