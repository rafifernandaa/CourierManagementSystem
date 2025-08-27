Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class CouriersForm
    Dim connectionString As String = "Server=localhost;Database=CourierApp;Uid=root;Pwd=Rafeal1706!;"

    ' Load Couriers into DataGridView
    Private Sub CouriersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCouriers()
    End Sub

    Private Sub LoadCouriers()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Pastikan status diperbarui jika waktu suspend telah berakhir
                Dim queryActivateCouriers As String = "UPDATE Couriers SET Status = 'Active', SuspendUntil = NULL WHERE SuspendUntil IS NOT NULL AND SuspendUntil <= NOW();"
                Dim cmdActivateCouriers As New MySqlCommand(queryActivateCouriers, connection)
                cmdActivateCouriers.ExecuteNonQuery()

                ' Load data couriers
                Dim query As String = "SELECT CourierID, Name, Phone, Status, AssignedPackages, SuspendUntil FROM Couriers"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvCouriers.DataSource = table

                ' Tambahkan header dan pengaturan kolom untuk SuspendUntil
                If dgvCouriers.Columns.Contains("SuspendUntil") Then
                    dgvCouriers.Columns("SuspendUntil").HeaderText = "Suspend Until"
                    dgvCouriers.Columns("SuspendUntil").Visible = True ' Atur ke False jika ingin menyembunyikan kolom ini
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat memuat data: " & ex.Message)
        End Try
    End Sub

    ' Add a New Courier
    Private Sub btnAddCourier_Click(sender As Object, e As EventArgs) Handles btnAddCourier.Click
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Couriers (Name, Phone, Status, AssignedPackages) VALUES (@name, @phone, @availability, @orders)"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@name", txtName.Text)
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                cmd.Parameters.AddWithValue("@availability", chkAvailability.Checked)
                cmd.Parameters.AddWithValue("@orders", numAssignedOrders.Value)

                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Kurir berhasil ditambahkan!")
                    LoadCouriers()
                Else
                    MessageBox.Show("Gagal menambahkan kurir.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat menambahkan kurir: " & ex.Message)
        End Try
    End Sub

    ' Update an Existing Courier
    Private Sub btnUpdateCourier_Click(sender As Object, e As EventArgs) Handles btnUpdateCourier.Click
        ' Ambil CourierID dan status dari form
        Dim courierID As Integer = Integer.Parse(txtCourierID.Text)
        Dim status As String

        ' Cek status dari checkbox dan tentukan status
        If chkAvailability.Checked Then
            status = "Active"  ' Jika checkbox dicentang, set status ke "Active"
        Else
            status = "Inactive"  ' Jika checkbox tidak dicentang, set status ke "Inactive"
        End If

        ' Update query
        Try
            Dim query As String = "UPDATE Couriers SET Status = @Status WHERE CourierID = @CourierID"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Status", status)
                cmd.Parameters.AddWithValue("@CourierID", courierID)

                ' Eksekusi query update
                cmd.ExecuteNonQuery()
                MessageBox.Show("Status courier berhasil diperbarui!")
            End Using
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat memperbarui data: " & ex.Message)
        End Try
    End Sub


    ' Delete a Courier
    Private Sub btnDeleteCourier_Click(sender As Object, e As EventArgs) Handles btnDeleteCourier.Click
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim courierID As Integer = Integer.Parse(txtCourierID.Text)
                Dim query As String = "DELETE FROM Couriers WHERE CourierID=@id"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@id", txtCourierID.Text)

                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Kurir berhasil dihapus!")
                    LoadCouriers()
                Else
                    MessageBox.Show("Gagal menghapus kurir.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat menghapus kurir: " & ex.Message)
        End Try
    End Sub

    ' Handle DataGridView Row Selection
    Private Sub dgvCouriers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCouriers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCouriers.Rows(e.RowIndex)

            ' Ambil nilai dari setiap kolom dan set ke TextBox atau kontrol lainnya
            txtCourierID.Text = row.Cells("CourierID").Value.ToString()
            txtName.Text = row.Cells("Name").Value.ToString()
            txtPhone.Text = row.Cells("Phone").Value.ToString()

            ' Periksa nilai Status dan set checkbox
            Dim status As String = row.Cells("Status").Value.ToString()
            If status = "Active" Then
                chkAvailability.Checked = True
            ElseIf status = "Inactive" Then
                chkAvailability.Checked = False
            End If

            ' Atur nilai AssignedPackages
            numAssignedOrders.Value = Convert.ToInt32(row.Cells("AssignedPackages").Value)
        End If
    End Sub

    ' Back Button to Navigate to Dashboard
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New AdminDashboardForm()
        dashboard.Show()
        Me.Close()
    End Sub

    Private Sub chkAvailability_CheckedChanged(sender As Object, e As EventArgs) Handles chkAvailability.CheckedChanged

    End Sub
    Private Sub SuspendCourier_Click(sender As Object, e As EventArgs) Handles SuspendCourier.Click
        Dim courierID As Integer
        If Not Integer.TryParse(txtCourierID.Text, courierID) Then
            MessageBox.Show("Masukkan CourierID yang valid!")
            Return
        End If

        ' Pilihan durasi suspend (dalam hari)
        Dim suspendDuration As Integer
        Dim input = InputBox("Masukkan durasi suspend dalam hari (misalnya 3 atau 7):", "Durasi Suspend")
        If Not Integer.TryParse(input, suspendDuration) OrElse suspendDuration <= 0 Then
            MessageBox.Show("Masukkan durasi suspend yang valid (angka positif)!")
            Return
        End If

        ' Hitung tanggal akhir suspend
        Dim suspendUntil As DateTime = DateTime.Now.AddDays(suspendDuration)
        Dim transaction As MySqlTransaction = Nothing

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Mulai transaksi
                transaction = connection.BeginTransaction()

                ' 1. Update Status dan SuspendUntil di tabel Couriers
                Dim queryUpdateCourier As String = "UPDATE Couriers SET Status = 'Suspended', SuspendUntil = @SuspendUntil WHERE CourierID = @CourierID"
                Dim cmdUpdateCourier As New MySqlCommand(queryUpdateCourier, connection, transaction)
                cmdUpdateCourier.Parameters.AddWithValue("@SuspendUntil", suspendUntil)
                cmdUpdateCourier.Parameters.AddWithValue("@CourierID", courierID)
                cmdUpdateCourier.ExecuteNonQuery()

                ' 2. Update Status di tabel Users
                Dim queryUpdateUser As String = "UPDATE Users SET Status = 'Suspended' WHERE CourierID = @CourierID"
                Dim cmdUpdateUser As New MySqlCommand(queryUpdateUser, connection, transaction)
                cmdUpdateUser.Parameters.AddWithValue("@CourierID", courierID)
                cmdUpdateUser.ExecuteNonQuery()

                ' Commit transaksi jika semua query berhasil
                transaction.Commit()
                MessageBox.Show("Courier dan user berhasil disuspend hingga " & suspendUntil.ToString("yyyy-MM-dd HH:mm:ss") & "!")
                LoadCouriers() ' Refresh data couriers
            End Using
        Catch ex As Exception
            ' Rollback jika terjadi error
            If transaction IsNot Nothing Then
                transaction.Rollback()
            End If
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub
End Class