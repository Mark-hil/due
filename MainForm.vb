Imports System.ComponentModel
Imports ControlzEx.Standard

Public Class MainForm
    Private Sub btnMformU_Click(sender As Object, e As EventArgs) Handles btnMformU.Click
        Dim Userform As New UserForm()
        Userform.ShowDialog()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Aluform As New AluminiForm()
        Aluform.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Tform As New TeacherForm()
        Tform.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Memform As New MemberForm()
        Memform.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Dform As New DuesForm()
        Dform.ShowDialog()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Dash As New DashBoard()
        Dash.ShowDialog()
    End Sub

    Private Sub btnUserHome_Click(sender As Object, e As EventArgs) Handles btnUserHome.Click
        Dim All As New AllMembers()
        All.ShowDialog()
    End Sub

    'Dim Sc As Object

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Sc.SplitterDistance > 80 Then
            Sc.SplitterDistance -= 10
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Sc.SplitterDistance < 280 Then
            Sc.SplitterDistance += 10
        Else
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub btnExpand_Click(sender As Object, e As EventArgs) Handles btnExpand.Click
        If Sc.SplitterDistance > 80 Then
            Timer1.Enabled = True
        Else
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Logform As New Login()
        Logform.Show()
        Me.Hide()
    End Sub

    Private Sub Sc_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Sc.Panel2.Paint

    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class