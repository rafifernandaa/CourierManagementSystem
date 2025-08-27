Imports MySql.Data.MySqlClient

Public Class PackagesForm
    Dim connectionString As String = "Server=localhost;Database=CourierApp;Uid=root;Pwd=Rafeal1706!;"

    ' Load Packages into DataGridView
    Private Sub PackagesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPackages()
    End Sub

    Private Sub LoadPackages()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT PackageID, PackageName, DestinationAddress, Status FROM Packages"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvPackages.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat memuat data: " & ex.Message)
        End Try
    End Sub

    ' Add a New Package
    Private Sub btnAddPackage_Click(sender As Object, e As EventArgs) Handles btnAddPackage.Click
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Packages (PackageName, DestinationAddress, CourierID, Status) VALUES (@PackageName, @DestinationAddress, @CourierID, @Status)"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@PackageName", txtPackageName.Text)
                cmd.Parameters.AddWithValue("@DestinationAddress", txtDestinationAddress.Text)
                cmd.Parameters.AddWithValue("@CourierID", Convert.ToInt32(txtCourierID.Text))
                cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString())

                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Paket berhasil ditambahkan!")
                    LoadPackages()
                Else
                    MessageBox.Show("Gagal menambahkan paket.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat menambahkan paket: " & ex.Message)
        End Try
    End Sub
    Private Sub ClearFields()
        txtPackageName.Clear()
        txtDestinationAddress.Clear()
        txtCourierID.Clear()
        cmbStatus.SelectedIndex = -1
    End Sub
    ' Update an Existing Package
    Private Sub btnUpdatePackage_Click(sender As Object, e As EventArgs) Handles btnUpdatePackage.Click
        If String.IsNullOrEmpty(txtPackageID.Text) Or cmbStatus.SelectedItem Is Nothing Then
            MessageBox.Show("PackageID dan Status tidak boleh kosong!")
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE Packages SET PackageName = @PackageName, DestinationAddress = @DestinationAddress, CourierID = @CourierID, Status = @Status WHERE PackageID = @PackageID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@PackageID", Convert.ToInt32(txtPackageID.Text))
                    cmd.Parameters.AddWithValue("@PackageName", txtPackageName.Text)
                    cmd.Parameters.AddWithValue("@DestinationAddress", txtDestinationAddress.Text)
                    cmd.Parameters.AddWithValue("@CourierID", Convert.ToInt32(txtCourierID.Text))
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString())

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Paket berhasil diperbarui.")
                        ClearFields()
                        LoadPackages()
                    Else
                        MessageBox.Show("Gagal memperbarui paket.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat memperbarui paket: " & ex.Message)
        End Try
    End Sub


    ' Delete a Package
    Private Sub btnDeletePackage_Click(sender As Object, e As EventArgs) Handles btnDeletePackage.Click
        If String.IsNullOrEmpty(txtPackageID.Text) Then
            MessageBox.Show("PackageID tidak boleh kosong!")
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "DELETE FROM Packages WHERE PackageID = @PackageID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@PackageID", Convert.ToInt32(txtPackageID.Text))

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Paket berhasil dihapus.")
                        ClearFields()
                        LoadPackages()
                    Else
                        MessageBox.Show("Gagal menghapus paket. Pastikan PackageID benar.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat menghapus paket: " & ex.Message)
        End Try
    End Sub


    ' Handle DataGridView Row Selection
    Private Sub dgvPackages_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPackages.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPackages.Rows(e.RowIndex)
            txtPackageID.Text = row.Cells("PackageID").Value.ToString()
            txtPackageName.Text = row.Cells("PackageName").Value.ToString()
            txtDestinationAddress.Text = row.Cells("DestinationAddress").Value.ToString()
        End If
    End Sub

    ' Back Button to Navigate to Dashboard
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New AdminDashboardForm()
        dashboard.Show()
        Me.Close()
    End Sub
End Class
