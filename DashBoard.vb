Imports System.Data.SqlClient
Imports NPOI.OpenXmlFormats.Dml.Chart
Imports NPOI.SS.Formula.Functions

Public Class DashBoard
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
    End Sub

    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
        con.Open()
        Dim sqlDa1 As New SqlDataAdapter("SELECT count(*) FROM MemberTbl ", con)
        Dim sqlDt1 As New DataTable()
        sqlDa1.Fill(sqlDt1)
        lblMember.Text = sqlDt1.Rows(0)(0).ToString()

        Dim sqlDa2 As New SqlDataAdapter("SELECT count(*) FROM DuesTbl ", con)
        Dim sqlDt2 As New DataTable()
        sqlDa2.Fill(sqlDt2)
        lblDues.Text = Convert.ToDouble(sqlDt2.Rows(0)(0).ToString()) * 10

        Dim sqlDa3 As New SqlDataAdapter("SELECT count(*) FROM TeacherTbl ", con)
        Dim sqlDt3 As New DataTable()
        sqlDa3.Fill(sqlDt3)
        lblTeacher.Text = sqlDt3.Rows(0)(0).ToString()

        Dim sqlDa4 As New SqlDataAdapter("SELECT count(*) FROM AluminiTbl ", con)
        Dim sqlDt4 As New DataTable()
        sqlDa4.Fill(sqlDt4)
        lblAlumini.Text = sqlDt4.Rows(0)(0).ToString()
        con.Close()
    End Sub

    Private Sub btnHome_Dash_Click(sender As Object, e As EventArgs) Handles btnHome_Dash.Click
        Dim Mform As New MainForm()
        Me.Close()
        Mform.Show()
    End Sub


End Class