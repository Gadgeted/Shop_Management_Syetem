<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignup
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
        lblFullName = New Label()
        lblUsername = New Label()
        lblPassword = New Label()
        lblConfirm = New Label()
        txtFullName = New TextBox()
        txtConfirm = New TextBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        btnSignup = New Button()
        btnGoLogin = New Button()
        SuspendLayout()
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Location = New Point(32, 24)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(61, 15)
        lblFullName.TabIndex = 0
        lblFullName.Text = "Full Name"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(32, 68)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(60, 15)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(32, 119)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(57, 15)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password"
        ' 
        ' lblConfirm
        ' 
        lblConfirm.AutoSize = True
        lblConfirm.Location = New Point(32, 166)
        lblConfirm.Name = "lblConfirm"
        lblConfirm.Size = New Size(104, 15)
        lblConfirm.TabIndex = 3
        lblConfirm.Text = "Confirm Password"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(179, 24)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(150, 23)
        txtFullName.TabIndex = 4
        ' 
        ' txtConfirm
        ' 
        txtConfirm.Location = New Point(179, 166)
        txtConfirm.Name = "txtConfirm"
        txtConfirm.Size = New Size(150, 23)
        txtConfirm.TabIndex = 5
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(179, 111)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(150, 23)
        txtPassword.TabIndex = 6
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(179, 65)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(150, 23)
        txtUsername.TabIndex = 7
        ' 
        ' btnSignup
        ' 
        btnSignup.Location = New Point(78, 261)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(75, 23)
        btnSignup.TabIndex = 8
        btnSignup.Text = "Sign Up"
        btnSignup.UseVisualStyleBackColor = True
        ' 
        ' btnGoLogin
        ' 
        btnGoLogin.Location = New Point(230, 261)
        btnGoLogin.Name = "btnGoLogin"
        btnGoLogin.Size = New Size(221, 23)
        btnGoLogin.TabIndex = 9
        btnGoLogin.Text = "Already have an Account? Login"
        btnGoLogin.UseVisualStyleBackColor = True
        ' 
        ' frmSignup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnGoLogin)
        Controls.Add(btnSignup)
        Controls.Add(txtUsername)
        Controls.Add(txtPassword)
        Controls.Add(txtConfirm)
        Controls.Add(txtFullName)
        Controls.Add(lblConfirm)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(lblFullName)
        Name = "frmSignup"
        Text = "frmSignup"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFullName As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblConfirm As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnSignup As Button
    Friend WithEvents btnGoLogin As Button
End Class
