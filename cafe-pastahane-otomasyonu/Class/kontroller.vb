Imports System.Data.OleDb

Public Class kontroller
    Public Shared Sub txtSayiKontrol(ByVal e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) = False AndAlso e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Public Shared Sub txtParaKontrol(ByVal e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) = False AndAlso e.KeyChar <> ChrW(8) AndAlso e.KeyChar <> ChrW(44) Then
            e.Handled = True
        End If
    End Sub

    Public Shared Function kullaniciKontrolu(ByVal kulAdi As String, ByVal sifre As String) As Boolean
        Veritabani.baglantiKontrol()
        Dim cmd As OleDbCommand = New OleDbCommand("select KullaniciNo from Kullanici where KullaniciAdi=@kuladi and Sifre=@sifre", Veritabani.con)
        cmd.Parameters.Add("@kuladi", OleDbType.VarWChar).Value = kulAdi
        cmd.Parameters.Add("@sifre", OleDbType.VarWChar).Value = sifre
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        If dr.Read() Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function veriVarmi(ByVal sql As String) As Boolean
        Veritabani.baglantiKontrol()
        Dim cmd As OleDbCommand = New OleDbCommand(sql, Veritabani.con)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        If dr.Read() Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
