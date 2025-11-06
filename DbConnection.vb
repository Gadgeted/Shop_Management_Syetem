Imports MySql.Data.MySqlClient

Module DbConnection
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public adapter As MySqlDataAdapter
    Public dt As DataTable

    ' 🔌 Connect to your XAMPP MySQL
    Public Sub ConnectDB()
        Try
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=shopdb")
            conn.Open()
        Catch ex As Exception
            MsgBox("Database connection failed: " & ex.Message)
        End Try
    End Sub
End Module
