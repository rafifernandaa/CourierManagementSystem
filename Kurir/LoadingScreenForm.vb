Imports System.Windows.Forms

Public Class LoadingScreenForm
    Private fadeStep As Double = 0.05 ' Nilai untuk meningkatkan Opacity (fade-in)
    Private fadeInTimer As New Timer()
    Private delayTimer As New Timer()

    Private Sub LoadingScreenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Atur Opacity form menjadi transparan di awal
        Me.Opacity = 0
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Atur ukuran form
        Me.FormBorderStyle = FormBorderStyle.None ' Hilangkan border
        Me.WindowState = FormWindowState.Normal
        Me.TopMost = True ' Form berada di atas

        ' Atur Timer untuk Fade In
        fadeInTimer.Interval = 30 ' Interval dalam milidetik
        AddHandler fadeInTimer.Tick, AddressOf FadeIn
        fadeInTimer.Start()
    End Sub

    ' Proses Fade In
    Private Sub FadeIn(sender As Object, e As EventArgs)
        If Me.Opacity < 1 Then
            Me.Opacity += fadeStep ' Tambah Opacity
        Else
            ' Jika Fade In selesai, hentikan timer
            fadeInTimer.Stop()
            ' Atur Timer Delay untuk berpindah form
            delayTimer.Interval = 2000 ' Tunggu 2 detik
            AddHandler delayTimer.Tick, AddressOf MoveToLoginForm
            delayTimer.Start()
        End If
    End Sub

    ' Pindah ke LoginForm
    Private Sub MoveToLoginForm(sender As Object, e As EventArgs)
        delayTimer.Stop() ' Hentikan delay timer

        ' Tampilkan LoginForm
        Dim loginForm As New LoginForm()
        loginForm.Show()

        ' Sembunyikan LoadingScreenForm tanpa menutup aplikasi
        Me.Hide()
    End Sub

End Class
