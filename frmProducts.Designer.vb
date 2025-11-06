<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        lblTitle = New Label()
        GroupBox1 = New GroupBox()
        DataGridView1 = New DataGridView()
        txtProductID = New TextBox()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnAdd = New Button()
        txtStock = New TextBox()
        txtPrice = New TextBox()
        txtProductName = New TextBox()
        lblProductName = New Label()
        lblStock = New Label()
        lblPrice = New Label()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(236, 22)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(145, 15)
        lblTitle.TabIndex = 0
        lblTitle.Text = "PRODUCT MANAGEMENT"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Controls.Add(txtProductID)
        GroupBox1.Controls.Add(btnDelete)
        GroupBox1.Controls.Add(btnUpdate)
        GroupBox1.Controls.Add(btnAdd)
        GroupBox1.Controls.Add(txtStock)
        GroupBox1.Controls.Add(txtPrice)
        GroupBox1.Controls.Add(txtProductName)
        GroupBox1.Controls.Add(lblProductName)
        GroupBox1.Controls.Add(lblStock)
        GroupBox1.Controls.Add(lblPrice)
        GroupBox1.Location = New Point(104, 49)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(461, 377)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Product"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(36, 197)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(240, 150)
        DataGridView1.TabIndex = 11
        ' 
        ' txtProductID
        ' 
        txtProductID.Location = New Point(115, 12)
        txtProductID.Name = "txtProductID"
        txtProductID.Size = New Size(100, 23)
        txtProductID.TabIndex = 10
        txtProductID.Visible = False
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(308, 162)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(99, 23)
        btnDelete.TabIndex = 9
        btnDelete.Text = "Delete Product"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(162, 162)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(104, 23)
        btnUpdate.TabIndex = 8
        btnUpdate.Text = "Update Product"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(25, 162)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(100, 23)
        btnAdd.TabIndex = 7
        btnAdd.Text = "Add Product"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(298, 96)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(100, 23)
        txtStock.TabIndex = 6
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(80, 96)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(100, 23)
        txtPrice.TabIndex = 5
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(115, 41)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(219, 23)
        txtProductName.TabIndex = 4
        ' 
        ' lblProductName
        ' 
        lblProductName.AutoSize = True
        lblProductName.Location = New Point(25, 44)
        lblProductName.Name = "lblProductName"
        lblProductName.Size = New Size(84, 15)
        lblProductName.TabIndex = 3
        lblProductName.Text = "Product Name"
        ' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.Location = New Point(207, 99)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(88, 15)
        lblStock.TabIndex = 2
        lblStock.Text = "Stock Quantity:"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(25, 99)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(36, 15)
        lblPrice.TabIndex = 1
        lblPrice.Text = "Price:"
        ' 
        ' frmProducts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Controls.Add(lblTitle)
        Name = "frmProducts"
        Text = "frmProducts"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
