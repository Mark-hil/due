Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Xml

Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Dim UserId As Integer = txtUserId.Text
        Dim UserName As String = txtU_Login.Text
        Dim Password As String = txtU_Pass.Text
        Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT * FROM  UserTbl  WHERE  UserName = '" & UserName & "'AND Password = '" & Password & "'", con)
        Dim sqlDa As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        sqlDa.Fill(dt)
        If dt.Rows.Count > 0 Then
            MessageBox.Show("login Successfull", "information", MessageBoxButtons.OK)
            Dim Mform As New MainForm()
            Mform.Show()
            Me.Hide()
        Else
            MessageBox.Show("Enter Correct UserName Or Password", "information", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class