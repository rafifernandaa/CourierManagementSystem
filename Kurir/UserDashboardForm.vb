Imports MySql.Data.MySqlClient

Public Class UserDashboardForm
    Dim connectionString As String = "Server=localhost;Database=CourierApp;Uid=root;Pwd=Rafeal1706!;"

    ' Load Dashboard Data
    Private Sub UserDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Total Packages
                Dim queryPackages As String = "SELECT COUNT(*) FROM Packages"
                Dim cmdPackages As New MySqlCommand(queryPackages, connection)
                lblTotalPackages.Text = "Total Packages: " & cmdPackages.ExecuteScalar().ToString()

                ' Active Couriers
                Dim queryCouriers As String = "SELECT COUNT(*) FROM Couriers WHERE Status='Active'"
                Dim cmdCouriers As New MySqlCommand(queryCouriers, connection)
                lblActiveCouriers.Text = "Active Couriers: " & cmdCouriers.ExecuteScalar().ToString()

                ' Pending Deliveries
                Dim queryPending As String = "SELECT COUNT(*) FROM Packages WHERE Status='Pending'"
                Dim cmdPending As New MySqlCommand(queryPending, connection)
                lblPendingDeliveries.Text = "Pending Deliveries: " & cmdPending.ExecuteScalar().ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat memuat data: " & ex.Message)
        End Try
    End Sub

    ' Navigate to Packages Management
    Private Sub btnViewPackages_Click(sender As Object, e As EventArgs) Handles btnViewPackages.Click
        Dim packagesForm As New ViewPackagesForm()
        packagesForm.Show()
        Me.Hide()
    End Sub

    ' Navigate to Couriers Management
    Private Sub btnViewCouriers_Click(sender As Object, e As EventArgs) Handles btnViewCouriers.Click
        Dim viewcourierForm As New ViewCourierForm()
        viewcourierForm.Show()
        Me.Hide()
    End Sub

    ' Navigate -> Packages
    Private Sub PackagesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PackagesToolStripMenuItem1.Click
        Dim packagesForm As New ViewPackagesForm()
        packagesForm.Show()
        Me.Close()
    End Sub

    ' Navigate -> Couriers
    Private Sub CouriersToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CouriersToolStripMenuItem1.Click
        Dim couriersForm As New ViewCourierForm()
        couriersForm.Show()
        Me.Close()
    End Sub

    ' Help -> About
    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MessageBox.Show("Courier Management System v1.2.2" & vbCrLf & "Developed by Kelompok 1.", "About")
    End Sub

    Private Sub LoginToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem1.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem2.Click
        Application.Exit()
    End Sub


End Class
