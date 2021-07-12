Imports System.Data.OleDb

Public Class Grup
    Public Shared Function grupEkle(ByVal Adi As Object) As Boolean
        Veritabani.baglantiKontrol()

        Try
            Dim cmd As OleDbCommand = New OleDbCommand("insert into UrunGrubu (Adi) values (@Adi)", Veritabani.con)
            cmd.Parameters.Add("@Adi", OleDbType.VarWChar).Value = Adi
            cmd.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Shared Function grupDuzenle(ByVal grupNo As Object, ByVal adi As Object) As Boolean
        Veritabani.baglantiKontrol()

        Try
            Dim cmd As OleDbCommand = New OleDbCommand("update UrunGrubu set Adi=@adi where UrunGrupNo=@grupno", Veritabani.con)
            cmd.Parameters.Add("@adi", OleDbType.VarWChar).Value = adi
            cmd.Parameters.Add("@grupno", OleDbType.Integer).Value = Convert.ToInt32(grupNo)
            cmd.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function
End Class
