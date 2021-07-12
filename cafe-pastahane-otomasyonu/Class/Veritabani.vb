Imports System.Data.OleDb
Imports System.IO


Public Class Veritabani

    Public Shared con As OleDbConnection = New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source = Veritabani/kafe.mdb")
    Public Shared Sub baglantiKontrol()
        If con.State = ConnectionState.Closed Then

            Try
                con.Open()
            Catch
                MessageBox.Show("Veri Tabanı Bağlantısı Yapılamadı")
                Application.[Exit]()
            End Try
        End If
    End Sub

    Public Shared Function VeriGetir(ByVal sql As String) As DataTable
        baglantiKontrol()
        Dim dt As DataTable = New DataTable()
        Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        dt.Load(dr)
        Return dt
    End Function

End Class
