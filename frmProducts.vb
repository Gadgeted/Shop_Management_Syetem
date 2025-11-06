Imports MySql.Data.MySqlClient

Public Class frmProducts
    Private Sub ProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        Dim query As String = "SELECT * FROM products"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable()
        adapter.Fill(dt)
        'dgvProducts.DataSource = dt
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = "INSERT INTO products (name, price, quantity) VALUES (@n, @p, @q)"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@n", txtProductName.Text)
        cmd.Parameters.AddWithValue("@p", txtPrice.Text)
        cmd.Parameters.AddWithValue("@q", txtStock.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Product added successfully!")
        LoadProducts()
    End Sub
End Class
