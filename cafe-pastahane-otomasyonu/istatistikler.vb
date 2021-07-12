Imports System.Data.OleDb
Public Class istatistikler


    Public Shared con As OleDbConnection = New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source = Veritabani/kafe.mdb")
    Dim kmt As OleDbCommand = New OleDbCommand()
    Dim dtst As DataSet = New DataSet()
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Me.Close()



    End Sub


    Public Sub satisSayisi()
        con.Open()

        kmt.Connection = con
        kmt.CommandText = "SELECT COUNT(*) from Satislar"
        Dim oku As OleDbDataReader
        oku = kmt.ExecuteReader()

        If oku.Read() Then
            label6.Text = oku(0).ToString() & " Adet Satış"
        End If

        oku.Dispose()
        con.Close()
    End Sub

    Public Sub toplamPersonelSayisi()
        con.Open()
        kmt.Connection = con
        kmt.CommandText = "SELECT COUNT(KullaniciNo) from Kullanici"
        Dim oku As OleDbDataReader
        oku = kmt.ExecuteReader()

        If oku.Read() Then
            label10.Text = oku(0).ToString() & " Personel"
        End If

        oku.Dispose()
        con.Close()
    End Sub

    Public Sub urunSayisiToplam()
        con.Open()
        kmt.Connection = con
        kmt.CommandText = "SELECT COUNT(UrunNo) from Urun"
        Dim oku As OleDbDataReader
        oku = kmt.ExecuteReader()

        If oku.Read() Then
            label9.Text = oku(0).ToString() & " Ürün Sayısı"
        End If

        oku.Dispose()
        con.Close()
    End Sub


    Public Sub kazanilanUcret()
        con.Open()
        kmt.Connection = con
        kmt.CommandText = "SELECT sum(Tutar) from Satislar"
        Dim oku As OleDbDataReader
        oku = kmt.ExecuteReader()

        If oku.Read() Then
            label7.Text = oku(0).ToString() & " TL"
        End If

        oku.Dispose()
        con.Close()

    End Sub

    Private Sub istatistikler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        satisSayisi()
        kazanilanUcret()
        urunSayisiToplam()
        toplamPersonelSayisi()
    End Sub
End Class