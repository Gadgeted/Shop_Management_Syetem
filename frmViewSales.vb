Imports MySql.Data.MySqlClient

Public Class frmViewSales

    Private Sub frmViewSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        LoadSales()
    End Sub

    Private Sub LoadSales()
        Try
            Dim query As String = "SELECT * FROM sales"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvSales.DataSource = table
        Catch ex As Exception
            MsgBox("Error loading sales: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadSales()
    End Sub

End Class
