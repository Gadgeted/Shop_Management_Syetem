Imports MySql.Data.MySqlClient

Public Class frmSales
    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        LoadProducts()
        LoadSales()
    End Sub

    Private Sub LoadProducts()
        cmbProductName.Items.Clear()
        Dim query As String = "SELECT name FROM products"
        cmd = New MySqlCommand(query, conn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            cmbProductName.Items.Add(reader("name").ToString())
        End While
        reader.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim quantity As Integer = CInt(txtQuantity.Text)
        Dim price As Decimal

        Dim query As String = "SELECT price FROM products WHERE name=@name"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@name", cmbProductName.Text)
        reader = cmd.ExecuteReader()

        If reader.Read() Then
            price = reader("price")
        End If
        reader.Close()

        Dim subtotal As Decimal = price * quantity
        Dim tax As Decimal = subtotal * 0.16D
        Dim total As Decimal = subtotal + tax

        txtPrice.Text = price.ToString("F2")
        txtTax.Text = tax.ToString("F2")
        txtTotal.Text = total.ToString("F2")
    End Sub

    Private Sub btnAddSale_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim query As String = "INSERT INTO sales (product_name, quantity, price, tax, total) VALUES (@n, @q, @p, @t, @tot)"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@n", cmbProductName.Text)
        cmd.Parameters.AddWithValue("@q", txtQuantity.Text)
        cmd.Parameters.AddWithValue("@p", txtPrice.Text)
        cmd.Parameters.AddWithValue("@t", txtTax.Text)
        cmd.Parameters.AddWithValue("@tot", txtTotal.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Sale added successfully!")
        LoadSales()
    End Sub

    Private Sub LoadSales()
        Dim query As String = "SELECT * FROM sales"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable()
        adapter.Fill(dt)
        dgvSales.DataSource = dt
    End Sub
End Class
