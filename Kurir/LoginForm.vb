Imports MySql.Data.MySqlClient

Public Class LoginForm
    Public Shared CurrentUserCourierID As Integer
    Public Shared CurrentUserRole As String
    ' Connection string ke database MySQL
    Dim connectionString As String = "Server=localhost;Database=CourierApp;Uid=root;Pwd=Rafeal1706!;"

    ' Tombol Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT Role, CourierID FROM Users WHERE Username=@username AND PasswordHash=SHA2(@passwordhash, 256)"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@passwordhash", password)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        ' Ambil Role
                        CurrentUserRole = reader("Role").ToString()

                        ' Ambil CourierID jika tersedia
                        If Not IsDBNull(reader("CourierID")) Then
                            CurrentUserCourierID = Convert.ToInt32(reader("CourierID"))
                        Else
                            CurrentUserCourierID = -1 ' Default value jika CourierID kosong
                        End If

                        MessageBox.Show("Login berhasil sebagai " & CurrentUserRole & "!")

                        ' Buka form berdasarkan Role
                        If CurrentUserRole = "Admin" Then
                            Dim adminForm As New AdminDashboardForm()
                            adminForm.Show()
                        ElseIf CurrentUserRole = "User" Then
                            Dim userForm As New UserDashboardForm()
                            userForm.Show()
                        End If

                        Me.Hide()
                    End While
                Else
                    MessageBox.Show("Username atau password salah!")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Kesalahan koneksi: " & ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class