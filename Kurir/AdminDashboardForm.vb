Imports MySql.Data.MySqlClient

Public Class AdminDashboardForm
    Dim connectionString As String = "Server=localhost;Database=CourierApp;Uid=root;Pwd=Rafeal1706!;"

    ' Load Dashboard Data
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub btnPackages_Click(sender As Object, e As EventArgs) Handles btnPackages.Click
        Dim packagesForm As New PackagesForm()
        packagesForm.Show()
        Me.Hide()
    End Sub

    ' Navigate to Couriers Management
    Private Sub btnCouriers_Click(sender As Object, e As EventArgs) Handles btnCouriers.Click
        Dim couriersForm As New CouriersForm()
        couriersForm.Show()
        Me.Hide()
    End Sub

    ' Navigate -> Packages
    Private Sub PackagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PackagesToolStripMenuItem.Click
        Dim packagesForm As New PackagesForm()
        packagesForm.Show()
        Me.Close()
    End Sub

    ' Navigate -> Couriers
    Private Sub CouriersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CouriersToolStripMenuItem.Click
        Dim couriersForm As New CouriersForm()
        couriersForm.Show()
        Me.Close()
    End Sub

    ' Help -> About
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Courier Management System v1.2.2" & vbCrLf & "Developed by Kelompok 1.", "About")
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim historyForm As New HistoryForm()
        historyForm.Show()
        Me.Close()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub lblTotalPackages_Click(sender As Object, e As EventArgs) Handles lblTotalPackages.Click

    End Sub
End Class
