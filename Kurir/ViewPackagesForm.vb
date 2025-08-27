Imports MySql.Data.MySqlClient

Public Class ViewPackagesForm
    Dim connectionString As String = "Server=localhost;Database=CourierApp;Uid=root;Pwd=Rafeal1706!;"

    ' Load data saat form dibuka
    Private Sub ViewPackagesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optionally load packages initially (for example, based on logged-in user)
        If LoginForm.CurrentUserRole = "User" Then
            LoadPackagesByCourierID(LoginForm.CurrentUserCourierID)
        End If

        ' Menambahkan status ke ComboBox saat form dimuat
        cmbStatus.Items.Add("Pending")
        cmbStatus.Items.Add("In Transit")
        cmbStatus.Items.Add("Delivered")
    End Sub

    ' Fungsi untuk memuat data paket yang sesuai dengan CourierID
    Private Sub LoadPackagesByCourierID(courierID As Integer)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Query untuk memilih paket yang sesuai dengan CourierID
                Dim query As String = "SELECT PackageID, PackageName, Status, DestinationAddress, CourierID, CreatedAt FROM Packages WHERE CourierID = @CourierID"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@CourierID", courierID)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Tampilkan data ke DataGridView
                If table.Rows.Count > 0 Then
                    dgvViewPackagesForm.DataSource = table
                Else
                    MessageBox.Show("Tidak ada paket yang ditemukan untuk CourierID ini.")
                    dgvViewPackagesForm.DataSource = Nothing
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat memuat data: " & ex.Message)
        End Try
    End Sub

    ' Event ketika user mengklik baris di DataGridView
    Private Sub dgvViewPackagesForm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvViewPackagesForm.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvViewPackagesForm.Rows(e.RowIndex)
            Dim selectedPackageID As Integer = Convert.ToInt32(selectedRow.Cells("PackageID").Value)
            Dim selectedCourierID As Integer = Convert.ToInt32(selectedRow.Cells("CourierID").Value)

            ' Menampilkan PackageID ke TextBox dan status ke ComboBox
            txtPackageID2.Text = selectedPackageID.ToString()
            cmbStatus.SelectedItem = selectedRow.Cells("Status").Value.ToString()

            ' Validasi apakah user memiliki akses untuk mengedit paket
            If LoginForm.CurrentUserRole = "Admin" OrElse selectedCourierID = LoginForm.CurrentUserCourierID Then
                ' User memiliki akses, memungkinkan update status
                btnUpdatePackageStatus.Enabled = True ' Enable the update button
            Else
                ' User tidak memiliki akses, disable update
                MessageBox.Show("Anda tidak memiliki akses untuk mengedit status paket ini.")
                dgvViewPackagesForm.ClearSelection()
                btnUpdatePackageStatus.Enabled = False
            End If
        End If
    End Sub

    ' Tombol Update Status Paket
    Private Sub btnUpdatePackageStatus_Click(sender As Object, e As EventArgs) Handles btnUpdatePackageStatus.Click
        If String.IsNullOrEmpty(txtPackageID2.Text) Then
            MessageBox.Show("Silakan pilih paket terlebih dahulu.")
            Return
        End If

        If cmbStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Silakan pilih status paket yang ingin diperbarui.")
            Return
        End If

        ' Mendapatkan PackageID dari TextBox
        Dim packageID As Integer = Convert.ToInt32(txtPackageID2.Text)
        Dim status As String = cmbStatus.SelectedItem.ToString()

        ' Validasi akses user sebelum update status
        If LoginForm.CurrentUserRole <> "Admin" AndAlso LoginForm.CurrentUserCourierID <> packageID Then
            MessageBox.Show("Anda tidak memiliki akses untuk mengedit status paket ini.")
            Return
        End If

        ' Query update status
        Try
            Dim query As String = "UPDATE Packages SET Status = @Status WHERE PackageID = @PackageID"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Status", status)
                cmd.Parameters.AddWithValue("@PackageID", packageID)

                Dim rowsAffected = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Status paket berhasil diperbarui!")
                    LoadPackagesByCourierID(LoginForm.CurrentUserCourierID) ' Reload packages for the current courier
                Else
                    MessageBox.Show("Tidak ada perubahan yang dilakukan.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat memperbarui status: " & ex.Message)
        End Try
    End Sub

    ' Tombol untuk memilih paket berdasarkan CourierID yang dimasukkan
    Private Sub btnSelectPackages_Click(sender As Object, e As EventArgs) Handles btnSelectPackages.Click
        Dim courierID As Integer

        ' Cek apakah CourierID valid
        If Integer.TryParse(txtCourierID3.Text, courierID) Then
            ' Jika CourierID valid, muat data paket yang sesuai
            LoadPackagesByCourierID(courierID)
        Else
            MessageBox.Show("Masukkan CourierID yang valid!")
        End If
    End Sub

    ' Tombol Back ke Dashboard User
    Private Sub btnBackVPF_Click(sender As Object, e As EventArgs) Handles btnBackVPF.Click
        Dim dashboard As New UserDashboardForm()
        dashboard.Show()
        Me.Close()
    End Sub
End Class
