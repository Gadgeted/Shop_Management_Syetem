<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        dgvSales = New DataGridView()
        btnSave = New Button()
        btnCompute = New Button()
        txtTotal = New TextBox()
        txtTax = New TextBox()
        txtSubtotal = New TextBox()
        txtQuantity = New TextBox()
        txtPrice = New TextBox()
        cmbProductName = New ComboBox()
        lblProduct = New Label()
        lblQuantity = New Label()
        lblSubtotal = New Label()
        lblTax = New Label()
        lblTotal = New Label()
        Label7 = New Label()
        lblTitle = New Label()
        GroupBox1.SuspendLayout()
        CType(dgvSales, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvSales)
        GroupBox1.Controls.Add(btnSave)
        GroupBox1.Controls.Add(btnCompute)
        GroupBox1.Controls.Add(txtTotal)
        GroupBox1.Controls.Add(txtTax)
        GroupBox1.Controls.Add(txtSubtotal)
        GroupBox1.Controls.Add(txtQuantity)
        GroupBox1.Controls.Add(txtPrice)
        GroupBox1.Controls.Add(cmbProductName)
        GroupBox1.Controls.Add(lblProduct)
        GroupBox1.Controls.Add(lblQuantity)
        GroupBox1.Controls.Add(lblSubtotal)
        GroupBox1.Controls.Add(lblTax)
        GroupBox1.Controls.Add(lblTotal)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Location = New Point(14, 42)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(774, 381)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sales"
        ' 
        ' dgvSales
        ' 
        dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSales.Location = New Point(313, 184)
        dgvSales.Name = "dgvSales"
        dgvSales.Size = New Size(414, 165)
        dgvSales.TabIndex = 15
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(72, 326)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 14
        btnSave.Text = "Save Sale"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCompute
        ' 
        btnCompute.Location = New Point(72, 124)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(133, 23)
        btnCompute.TabIndex = 13
        btnCompute.Text = "Compute Total"
        btnCompute.UseVisualStyleBackColor = True
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(126, 273)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(121, 23)
        txtTotal.TabIndex = 12
        ' 
        ' txtTax
        ' 
        txtTax.Location = New Point(126, 218)
        txtTax.Name = "txtTax"
        txtTax.Size = New Size(121, 23)
        txtTax.TabIndex = 11
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.Location = New Point(126, 166)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.Size = New Size(121, 23)
        txtSubtotal.TabIndex = 10
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(313, 80)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(118, 23)
        txtQuantity.TabIndex = 9
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(126, 80)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(121, 23)
        txtPrice.TabIndex = 8
        ' 
        ' cmbProductName
        ' 
        cmbProductName.FormattingEnabled = True
        cmbProductName.Location = New Point(126, 40)
        cmbProductName.Name = "cmbProductName"
        cmbProductName.Size = New Size(121, 23)
        cmbProductName.TabIndex = 7
        ' 
        ' lblProduct
        ' 
        lblProduct.AutoSize = True
        lblProduct.Location = New Point(41, 43)
        lblProduct.Name = "lblProduct"
        lblProduct.Size = New Size(55, 15)
        lblProduct.TabIndex = 1
        lblProduct.Text = "Product: "
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(254, 83)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(53, 15)
        lblQuantity.TabIndex = 2
        lblQuantity.Text = "Quantity"
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Location = New Point(41, 169)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(51, 15)
        lblSubtotal.TabIndex = 3
        lblSubtotal.Text = "Subtotal"
        ' 
        ' lblTax
        ' 
        lblTax.AutoSize = True
        lblTax.Location = New Point(41, 218)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(54, 15)
        lblTax.TabIndex = 4
        lblTax.Text = "Tax(16%)"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(41, 276)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(79, 15)
        lblTotal.TabIndex = 5
        lblTotal.Text = "Total Amount"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(59, 83)
        Label7.Name = "Label7"
        Label7.Size = New Size(33, 15)
        Label7.TabIndex = 6
        Label7.Text = "Price"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(320, 24)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(75, 15)
        lblTitle.TabIndex = 0
        lblTitle.Text = "SALES FORM"
        ' 
        ' frmSales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblTitle)
        Controls.Add(GroupBox1)
        Name = "frmSales"
        Text = "frmSales"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvSales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblProduct As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cmbProductName As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents dgvSales As DataGridView
End Class
