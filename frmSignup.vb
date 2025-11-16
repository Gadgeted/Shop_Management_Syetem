Imports MySql.Data.MySqlClient

Public Class frmSignup

    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=shopdb")
    Dim cmd As MySqlCommand

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click

        If txtPassword.Text <> txtConfirm.Text Then
            MsgBox("Passwords do not match!")
            Exit Sub
        End If

        Dim query As String = "INSERT INTO users (full_name, username, password) 
                               VALUES (@full, @user, @pass)"

        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@full", txtFullName.Text)
        cmd.Parameters.AddWithValue("@user", txtUsername.Text)
        cmd.Parameters.AddWithValue("@pass", txtPassword.Text)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Account created successfully!")
            conn.Close()

            Me.Hide()
            frmLogin.Show()

        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub btnGoLogin_Click(sender As Object, e As EventArgs) Handles btnGoLogin.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

End Class
