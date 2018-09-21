Imports System.Data.SqlClient

Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call openkoneksi()
        Dim cmd As sqlcommand
        Dim dr As sqldatareader
        Dim strsql As String
        Dim judul As String
        Dim query id as string = "SELECT MAX(BukuId)+1 AS MXID FROM BUKU"

        judul = tJudul.text()

        Try

            strsql = "select * form pengarang"
            cmd = New SqlCommand(strsql, conn)
            dr = cmd.ExecuteReader

            cbpengarang.items.clear()
            Do While dr.Read
                cbpengarang.Items.Add(dr("pengarangId") & "-" & dr("NamaPengarang"))

            Loop
            dr.closekoneksi()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTsimpan.Click
        Dim query As String
        Dim cmd As SqlCommand '=" INSERT INTO buku (BukuId,pengarangId,penerbit,judul,sinopsis,stock) values (1,1,'TEST PENERBIT','TEST JUDUL','TEST SINOPSIS',2)"
        Dim dr As SqlDataReader
        Dim pengarang As Array = cbpengarang.Text.Split("-")
        Dim uid As String

        's = tJudul.text()

        Try
            Call openkoneksi()
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub openkoneksi()
        Throw New NotImplementedException
    End Sub

    Private Function conn() As Object
        Throw New NotImplementedException
    End Function

    Private Function tJudul() As Object
        Throw New NotImplementedException
    End Function

End Class