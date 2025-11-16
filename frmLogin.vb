Imports MySql.Data.MySqlClient

Public Class frmLogin

    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=shopdb")
    Dim cmd As MySqlCommand

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim query As String = "SELECT * FROM users WHERE username=@user AND password=@pass"

        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@user", txtUsername.Text)
        cmd.Parameters.AddWithValue("@pass", txtPassword.Text)

        Try
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                MsgBox("Login Successful!")

                conn.Close()
                Me.Hide()
                frmMainMenu.Show()

            Else
                MsgBox("Invalid username or password!")
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub btnGoSignup_Click(sender As Object, e As EventArgs) Handles btnGoSignup.Click
        Me.Hide()
        frmSignup.Show()
    End Sub

End Class
