Imports MySql.Data.MySqlClient

Module mdlOfficePage
    Public konek As MySqlConnection

    Sub koneksi()
        Dim str As String = "Server=localhost; user id=root; password=; database=officepage;"
        konek = New MySqlConnection(str)
        If konek.State = ConnectionState.Closed Then
            konek.Open()
        End If
    End Sub

End Module
