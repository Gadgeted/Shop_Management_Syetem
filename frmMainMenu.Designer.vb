<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        btnProducts = New Button()
        btnSales = New Button()
        btnReports = New Button()
        btnExit = New Button()
        btnLogout = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F)
        lblTitle.Location = New Point(173, 28)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(310, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "SHOP MANAGEMENT SYSTEM"
        lblTitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnProducts
        ' 
        btnProducts.Location = New Point(253, 93)
        btnProducts.Name = "btnProducts"
        btnProducts.Size = New Size(114, 23)
        btnProducts.TabIndex = 1
        btnProducts.Text = "Manage Products"
        btnProducts.UseVisualStyleBackColor = True
        ' 
        ' btnSales
        ' 
        btnSales.Location = New Point(279, 145)
        btnSales.Name = "btnSales"
        btnSales.Size = New Size(126, 23)
        btnSales.TabIndex = 2
        btnSales.Text = "Make a Sale"
        btnSales.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.Location = New Point(313, 197)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(144, 23)
        btnReports.TabIndex = 3
        btnReports.Text = "View Sales Record"
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(586, 321)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(153, 23)
        btnExit.TabIndex = 4
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(418, 250)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(75, 23)
        btnLogout.TabIndex = 5
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' frmMainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(751, 450)
        Controls.Add(btnLogout)
        Controls.Add(btnExit)
        Controls.Add(btnReports)
        Controls.Add(btnSales)
        Controls.Add(btnProducts)
        Controls.Add(lblTitle)
        Name = "frmMainMenu"
        Text = "Main Menu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogout As Button

End Class
