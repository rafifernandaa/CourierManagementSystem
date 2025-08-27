Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class RoundedTextBox
    Inherits TextBox

    Private _cornerRadius As Integer = 15

    <Category("Appearance"), Description("The radius of the textbox corners.")>
    Public Property CornerRadius() As Integer
        Get
            Return _cornerRadius
        End Get
        Set(ByVal value As Integer)
            _cornerRadius = Math.Max(0, value) ' memastikan radius >= 0
            UpdateRegion()
        End Set
    End Property

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        UpdateRegion()
    End Sub

    Private Sub UpdateRegion()
        Dim path As New GraphicsPath()
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

        If _cornerRadius > 0 Then
            path.AddArc(rect.X, rect.Y, _cornerRadius * 2, _cornerRadius * 2, 180, 90) ' kiri atas
            path.AddArc(rect.Right - _cornerRadius * 2, rect.Y, _cornerRadius * 2, _cornerRadius * 2, 270, 90) ' kanan atas
            path.AddArc(rect.Right - _cornerRadius * 2, rect.Bottom - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2, 0, 90) ' kanan bawah
            path.AddArc(rect.X, rect.Bottom - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2, 90, 90) ' kiri bawah
            path.CloseAllFigures()
        Else
            path.AddRectangle(rect)
        End If

        Me.Region = New Region(path)
    End Sub
End Class
