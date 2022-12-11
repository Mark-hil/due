Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim startpos As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        startpos += 1
        MyProgressBar.Value = startpos
        If MyProgressBar.Value = 100 Then
            MyProgressBar.Value = 0
            Timer1.Stop()
            Dim log As New Login()
            log.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
