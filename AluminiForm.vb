Imports System.Data.Common
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AluminiForm
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
    End Sub

    Private Sub AluminiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateAluTable()
    End Sub

    Public Sub UpdateAluTable()
        Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT * FROM AluminiTbl", con)
        Dim sqlDa As New SqlDataAdapter(cmd)
        Dim sqlDt As New DataTable
        sqlDa.Fill(sqlDt)
        AluDGV.DataSource = sqlDt
    End Sub

    Private Sub btnAluAdd_Click(sender As Object, e As EventArgs) Handles btnAluAdd.Click
        Dim AluId As Integer = txtAluId.Text
        Dim AluFirstName As String = txtAluFirstName.Text
        Dim AluLastName As String = txtAluLastName.Text
        Dim AluGender As String = comAluGender.Text
        Dim AluDob As String = dtpAlu.Text
        Dim AluPhone As String = txtAluPhone.Text
        Try
            Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO  AluminiTbl VALUES('" & AluId & "', '" & AluFirstName & "', '" & AluLastName & "', '" & AluGender & "', '" & AluDob & "', '" & AluPhone & "' )", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("successfully inserted")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        UpdateAluTable()

        txtAluId.Text = ""
        txtAluFirstName.Text = ""
        txtAluLastName.Text = ""
        comAluGender.Text = ""
        dtpAlu.Text = ""
        txtAluPhone.Text = ""
    End Sub

    Private Sub btnAluEdit_Click(sender As Object, e As EventArgs) Handles btnAluEdit.Click
        Dim AluId As Integer = txtAluId.Text
        Dim AluFirstName As String = txtAluFirstName.Text
        Dim AluLastName As String = txtAluLastName.Text
        Dim AluGender As String = comAluGender.Text
        Dim AluDob As String = dtpAlu.Text
        Dim AluPhone As String = txtAluPhone.Text
        Try
            Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("UPDATE AluminiTbl SET AluId = '" & AluId & "', AluFirstName = '" & AluFirstName & "', AluLastName =  '" & AluLastName & "', AluGender =  '" & AluGender & "', AluDob =  '" & AluDob & "',  AluPhone =  '" & AluPhone & "' WHERE AluId = '" & AluId & "'", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("successfully Updated")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        UpdateAluTable()

        txtAluId.Text = ""
        txtAluFirstName.Text = ""
        txtAluLastName.Text = ""
        comAluGender.Text = ""
        dtpAlu.Text = ""
        txtAluPhone.Text = ""
    End Sub

    Private Sub btnAluDelete_Click(sender As Object, e As EventArgs) Handles btnAluDelete.Click
        Dim AluId As Integer = txtAluId.Text
        Try
            Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM AluminiTbl  WHERE   AluId = '" & AluId & "'", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("successfully Updated")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        UpdateAluTable()

        txtAluId.Text = ""
        txtAluFirstName.Text = ""
        txtAluLastName.Text = ""
        comAluGender.Text = ""
        dtpAlu.Text = ""
        txtAluPhone.Text = ""
    End Sub

    Private Sub AluDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AluDGV.CellContentClick

    End Sub

    Private Sub AluDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AluDGV.CellClick


        Try
            txtAluId.Text = AluDGV.SelectedRows(0).Cells(0).Value.ToString
            txtAluFirstName.Text = AluDGV.SelectedRows(0).Cells(1).Value.ToString
            txtAluLastName.Text = AluDGV.SelectedRows(0).Cells(2).Value.ToString
            comAluGender.Text = AluDGV.SelectedRows(0).Cells(3).Value.ToString
            dtpAlu.Text = AluDGV.SelectedRows(0).Cells(4).Value.ToString
            txtAluPhone.Text = AluDGV.SelectedRows(0).Cells(5).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSearchAlu_Click(sender As Object, e As EventArgs) Handles btnSearchAlu.Click
        Dim search As String = txtSearchAlu.Text
        Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")

        Dim cmd As New SqlCommand("SELECT * FROM  AluminiTbl  WHERE   AluId = '" & search & "'", con)
        Dim sqlDa As New SqlDataAdapter(cmd)
        Using sqldt As New DataTable
            sqlDa.Fill(sqldt)
            If sqldt.Rows.Count > 0 Then
                txtAluId.Text = sqldt.Rows(0)(0).ToString()
                txtAluFirstName.Text = sqldt.Rows(0)(1).ToString()
                txtAluLastName.Text = sqldt.Rows(0)(2).ToString()
                comAluGender.Text = sqldt.Rows(0)(3).ToString()
                dtpAlu.Text = sqldt.Rows(0)(4).ToString()
                txtAluPhone.Text = sqldt.Rows(0)(5).ToString()

                'MessageBox.Show(Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString))
            Else
                txtAluId.Text = ""
                txtAluFirstName.Text = ""
                txtAluLastName.Text = ""
                comAluGender.Text = ""
                dtpAlu.Text = ""
                txtAluPhone.Text = ""
            End If
        End Using

    End Sub

    Private Sub btnUserHome_Click(sender As Object, e As EventArgs) Handles btnUserHome.Click
        Dim Mform As New MainForm()
        Me.Close()
        MForm.Show()
    End Sub
End Class