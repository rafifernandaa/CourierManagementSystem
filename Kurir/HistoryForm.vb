Imports MySql.Data.MySqlClient

Public Class HistoryForm
    Dim connectionString As String = "Server=localhost;Database=CourierApp;Uid=root;Pwd=Rafeal1706!;"

    ' Load data history saat form dimuat
    Private Sub HistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadHistory()
    End Sub

    ' Fungsi untuk memuat data history ke DataGridView
    Private Sub LoadHistory(Optional filter As String = "")
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT HistoryID, ActionType, TableAffected, RecordID, ChangedBy, OldValue, NewValue, ActionDate FROM History"
                If filter <> "" Then
                    query &= " WHERE ActionType = @Filter"
                End If
                Dim cmd As New MySqlCommand(query, connection)
                If filter <> "" Then
                    cmd.Parameters.AddWithValue("@Filter", filter)
                End If

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvHistory.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat memuat data history: " & ex.Message)
        End Try
    End Sub

    ' Tombol untuk memfilter data history
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim filter As String = cmbFilter.SelectedItem.ToString()
        LoadHistory(filter)
    End Sub

    Private Sub btnBackHF_Click(sender As Object, e As EventArgs) Handles btnBackHF.Click
        Dim dashboard As New AdminDashboardForm()
        dashboard.Show()
        Me.Close()
    End Sub
End Class
