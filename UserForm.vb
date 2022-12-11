Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.Devices
Imports System.Net
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class UserForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUserEdit.Click
        Dim UserId As Integer = txtUserId.Text
        Dim UserName As String = txtUserName.Text
        Dim Password As String = txtUserPass.Text
        Try
            Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("UPDATE UserTbl SET UserId = '" & UserId & "', UserName = '" & UserName & "', Password =  '" & Password & "' WHERE UserId = '" & UserId & "'", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("successfully Updated")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        UpdateTable()

        txtUserId.Text = ""
        txtUserName.Text = ""
        txtUserPass.Text = ""
    End Sub
    Public Sub UpdateTable()
        Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT * FROM UserTbl", con)
        Dim sqlDa As New SqlDataAdapter(cmd)
        Dim sqlDt As New DataTable
        sqlDa.Fill(sqlDt)
        UserDGV.DataSource = sqlDt
    End Sub

    Private Sub btnUserAdd_Click(sender As Object, e As EventArgs) Handles btnUserAdd.Click
        Dim UserId As Integer = txtUserId.Text
        Dim UserName As String = txtUserName.Text
        Dim Password As String = txtUserPass.Text
        Try
            Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO  UserTbl VALUES('" & UserId & "', '" & UserName & "', '" & Password & "' )", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("successfully inserted")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        UpdateTable()

        txtUserId.Text = ""
        txtUserName.Text = ""
        txtUserPass.Text = ""
    End Sub

    Private Sub btnUserDelete_Click(sender As Object, e As EventArgs) Handles btnUserDelete.Click
        Dim UserId As Integer = txtUserId.Text
        Try
            Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM UserTbl  WHERE   UserId = '" & UserId & "'", con)

            cmd.ExecuteNonQuery()
            MessageBox.Show("successfully Updated")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        UpdateTable()

        txtUserId.Text = ""
        txtUserName.Text = ""
        txtUserPass.Text = ""
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTable()
    End Sub
    Private Sub UserDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDGV.CellClick


        Try
            txtUserId.Text = UserDGV.SelectedRows(0).Cells(0).Value.ToString
            txtUserName.Text = UserDGV.SelectedRows(0).Cells(1).Value.ToString
            txtUserPass.Text = UserDGV.SelectedRows(0).Cells(2).Value.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Application.Exit()
    End Sub

    Private Sub txtUserId_TextChanged(sender As Object, e As EventArgs) Handles txtUserId.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub UserDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDGV.CellContentClick

    End Sub

    Private Sub btnUserHome_Click(sender As Object, e As EventArgs) Handles btnUserHome.Click
        Dim Mform As New MainForm()
        Me.Close()
        Mform.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class