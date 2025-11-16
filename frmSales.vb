Imports MySql.Data.MySqlClient

Public Class frmSales

    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        LoadProducts()
        LoadSales()
    End Sub

    '---------------------------------------------------------
    ' LOAD PRODUCT NAMES INTO COMBOBOX
    '---------------------------------------------------------
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

    '---------------------------------------------------------
    ' CALCULATE TOTAL, TAX, PRICE
    '---------------------------------------------------------
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim quantity As Integer = CInt(txtQuantity.Text)
        Dim price As Decimal = 0D

        ' Get price from selected product
        Dim query As String = "SELECT price FROM products WHERE name=@name"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@name", cmbProductName.Text)

        reader = cmd.ExecuteReader()

        If reader.Read() Then
            price = reader("price")
        End If

        reader.Close()

        ' Calculate totals
        Dim subtotal As Decimal = price * quantity
        Dim tax As Decimal = subtotal * 0.16D
        Dim total As Decimal = subtotal + tax

        ' Display results
        txtPrice.Text = price.ToString("F2")
        txtTax.Text = tax.ToString("F2")
        txtTotal.Text = total.ToString("F2")
    End Sub

    '---------------------------------------------------------
    ' SAVE SALE + UPDATE STOCK
    '---------------------------------------------------------
    Private Sub btnAddSale_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim productName As String = cmbProductName.Text
        Dim qtySold As Integer = CInt(txtQuantity.Text)

        '---------------------------------------------
        ' STEP 1: Check available stock
        '---------------------------------------------
        Dim stockQuery As String = "SELECT quantity FROM products WHERE name=@name"
        cmd = New MySqlCommand(stockQuery, conn)
        cmd.Parameters.AddWithValue("@name", productName)

        Dim currentStock As Integer = CInt(cmd.ExecuteScalar())

        If qtySold > currentStock Then
            MsgBox("Error: Not enough stock available!", vbCritical)
            Exit Sub
        End If

        '---------------------------------------------
        ' STEP 2: Insert the sale into SALES table
        '---------------------------------------------
        Dim insertSale As String = "INSERT INTO sales (product_name, quantity, price, tax, total) VALUES (@n, @q, @p, @t, @tot)"
        cmd = New MySqlCommand(insertSale, conn)
        cmd.Parameters.AddWithValue("@n", productName)
        cmd.Parameters.AddWithValue("@q", qtySold)
        cmd.Parameters.AddWithValue("@p", txtPrice.Text)
        cmd.Parameters.AddWithValue("@t", txtTax.Text)
        cmd.Parameters.AddWithValue("@tot", txtTotal.Text)

        cmd.ExecuteNonQuery()

        '---------------------------------------------
        ' STEP 3: Deduct stock
        '---------------------------------------------
        Dim updateStock As String = "UPDATE products SET quantity = quantity - @qty WHERE name = @name"
        cmd = New MySqlCommand(updateStock, conn)
        cmd.Parameters.AddWithValue("@qty", qtySold)
        cmd.Parameters.AddWithValue("@name", productName)

        cmd.ExecuteNonQuery()

        MsgBox("Sale saved and stock updated!", vbInformation)

        LoadSales()
        LoadProducts()  ' refresh combo in case stock hits 0
    End Sub

    '---------------------------------------------------------
    ' LOAD SALES INTO GRID
    '---------------------------------------------------------
    Private Sub LoadSales()
        Dim query As String = "SELECT * FROM sales"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable()
        adapter.Fill(dt)
        dgvSales.DataSource = dt
    End Sub

End Class