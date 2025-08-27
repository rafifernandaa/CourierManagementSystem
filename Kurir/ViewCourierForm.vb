Imports MySql.Data.MySqlClient

Public Class ViewCourierForm
    Dim connectionString As String = "Server=localhost;Database=CourierApp;Uid=root;Pwd=Rafeal1706!;"

    ' Load data saat form dibuka
    Private Sub ViewCourierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCouriers2()
    End Sub

    ' Fungsi untuk memuat data Courier ke DataGridView
    Private Sub LoadCouriers2()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT CourierID, Name, Phone, Status, AssignedPackages FROM Couriers"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvViewCouriers.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat memuat data: " & ex.Message)
        End Try
    End Sub

    ' Event ketika user mengklik baris di DataGridView
    Private Sub dgvViewCouriers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvViewCouriers.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvViewCouriers.Rows(e.RowIndex)
            Dim selectedCourierID As Integer = Convert.ToInt32(selectedRow.Cells("CourierID").Value)

            ' Validasi akses berdasarkan CourierID
            If LoginForm.CurrentUserRole = "Admin" OrElse selectedCourierID = LoginForm.CurrentUserCourierID Then
                ' User memiliki akses, isi form dengan data
                txtCourierID2.Text = selectedCourierID.ToString()
                chkAvailability2.Checked = (selectedRow.Cells("Status").Value.ToString() = "Active")
                btnUpdateStatus.Enabled = True ' Enable the update button if user has access
            Else
                ' User tidak memiliki akses, disable editing
                MessageBox.Show("Anda tidak memiliki akses untuk mengedit courier ini.")
                dgvViewCouriers.ClearSelection()
                btnUpdateStatus.Enabled = False ' Disable the update button
            End If
        End If
    End Sub

    ' Tombol Update Status
    Private Sub btnUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click
        If String.IsNullOrEmpty(txtCourierID2.Text) Then
            MessageBox.Show("Silakan pilih Courier ID yang ingin diperbarui.")
            Return
        End If

        Dim courierID As Integer = Integer.Parse(txtCourierID2.Text)
        Dim status As String = If(chkAvailability2.Checked, "Active", "Inactive")

        ' Validasi akses user sebelum update
        If LoginForm.CurrentUserRole <> "Admin" AndAlso courierID <> LoginForm.CurrentUserCourierID Then
            MessageBox.Show("Anda tidak memiliki akses untuk mengedit courier ini.")
            Return
        End If

        ' Query update status
        Try
            Dim query As String = "UPDATE Couriers SET Status = @Status WHERE CourierID = @CourierID"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Status", status)
                cmd.Parameters.AddWithValue("@CourierID", courierID)

                Dim rowsAffected = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Status courier berhasil diperbarui!")
                    LoadCouriers2() ' Reload all couriers data
                Else
                    MessageBox.Show("Tidak ada perubahan yang dilakukan.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat memperbarui data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBackVCF_Click(sender As Object, e As EventArgs) Handles btnBackVCF.Click
        Dim dashboard As New UserDashboardForm()
        dashboard.Show()
        Me.Close()
    End Sub
End Class
