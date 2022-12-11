Imports System.Data.SqlClient

Public Class TeacherForm
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
    End Sub

    Private Sub TeacherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateT_Table()
    End Sub
    Public Sub UpdateT_Table()
        Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT * FROM TeacherTbl", con)
        Dim sqlDa As New SqlDataAdapter(cmd)
        Dim sqlDt As New DataTable
        sqlDa.Fill(sqlDt)
        T_DGV.DataSource = sqlDt
    End Sub

    Private Sub btnT_Add_Click(sender As Object, e As EventArgs) Handles btnT_Add.Click
        Dim T_Id As Integer = txtT_Id.Text
        Dim FirstName As String = txtT_FirstName.Text
        Dim LastName As String = txtT_LastName.Text
        Dim Gender As String = comT_Gender.Text
        Dim Dob As String = dtpTeach.Text
        Dim Phone As String = txtT_Phone.Text
        Dim Sabbath_Class As String = ComT_Class.Text
        Dim Location As String = txtT_Loc.Text
        Try
            Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO  TeacherTbl VALUES('" & T_Id & "', '" & FirstName & "', '" & LastName & "', '" & Gender & "', '" & Dob & "', '" & Phone & "', '" & Sabbath_Class & "', '" & Location & "' )", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("successfully inserted")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        UpdateT_Table()

        txtT_Id.Text = ""
        txtT_FirstName.Text = ""
        txtT_LastName.Text = ""
        comT_Gender.Text = ""
        dtpTeach.Text = ""
        txtT_Phone.Text = ""
        ComT_Class.Text = ""
        txtT_Loc.Text = ""
    End Sub

    Private Sub btnT_Edit_Click(sender As Object, e As EventArgs) Handles btnT_Edit.Click
        Dim T_Id As Integer = txtT_Id.Text
        Dim FirstName As String = txtT_FirstName.Text
        Dim LastName As String = txtT_LastName.Text
        Dim Gender As String = comT_Gender.Text
        Dim Dob As String = dtpTeach.Text
        Dim Phone As String = txtT_Phone.Text
        Dim Sabbath_Class As String = ComT_Class.Text
        Dim Location As String = txtT_Loc.Text
        Try
            Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("UPDATE TeacherTbl SET T_Id = '" & T_Id & "', FirstName = '" & FirstName & "', LastName =  '" & LastName & "', Gender =  '" & Gender & "', Dob =  '" & Dob & "',  Phone =  '" & Phone & "',  Sabbath_Class =  '" & Sabbath_Class & "',  Address =  '" & Location & "' WHERE T_Id = '" & T_Id & "'", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("successfully Updated")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        UpdateT_Table()

        txtT_Id.Text = ""
        txtT_FirstName.Text = ""
        txtT_LastName.Text = ""
        comT_Gender.Text = ""
        dtpTeach.Text = ""
        txtT_Phone.Text = ""
        ComT_Class.Text = ""
        txtT_Loc.Text = ""
    End Sub

    Private Sub btnT_Delete_Click(sender As Object, e As EventArgs) Handles btnT_Delete.Click
        Dim T_Id As Integer = txtT_Id.Text
        Try
            Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM TeacherTbl  WHERE   T_Id = '" & T_Id & "'", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("successfully Updated")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        UpdateT_Table()

        txtT_Id.Text = ""
        txtT_FirstName.Text = ""
        txtT_LastName.Text = ""
        comT_Gender.Text = ""
        dtpTeach.Text = ""
        txtT_Phone.Text = ""
        ComT_Class.Text = ""
        txtT_Loc.Text = ""
    End Sub
    Private Sub T_DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles T_DGV.CellClick


        Try
            txtT_Id.Text = T_DGV.SelectedRows(0).Cells(0).Value.ToString
            txtT_FirstName.Text = T_DGV.SelectedRows(0).Cells(1).Value.ToString
            txtT_LastName.Text = T_DGV.SelectedRows(0).Cells(2).Value.ToString
            comT_Gender.Text = T_DGV.SelectedRows(0).Cells(3).Value.ToString
            dtpTeach.Text = T_DGV.SelectedRows(0).Cells(4).Value.ToString
            txtT_Phone.Text = T_DGV.SelectedRows(0).Cells(5).Value.ToString
            ComT_Class.Text = T_DGV.SelectedRows(0).Cells(6).Value.ToString
            txtT_Loc.Text = T_DGV.SelectedRows(0).Cells(6).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSearch_T_Click(sender As Object, e As EventArgs) Handles btnSearch_T.Click
        Dim search As String = txtSearch_T.Text
        Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")

        Dim cmd As New SqlCommand("SELECT * FROM  TeacherTbl  WHERE   T_Id = '" & search & "'", con)
        Dim sqlDa As New SqlDataAdapter(cmd)
        Using sqldt As New DataTable
            sqlDa.Fill(sqldt)
            If sqldt.Rows.Count > 0 Then
                txtT_Id.Text = sqldt.Rows(0)(0).ToString()
                txtT_FirstName.Text = sqldt.Rows(0)(1).ToString()
                txtT_LastName.Text = sqldt.Rows(0)(2).ToString()
                comT_Gender.Text = sqldt.Rows(0)(3).ToString()
                dtpTeach.Text = sqldt.Rows(0)(4).ToString()
                txtT_Phone.Text = sqldt.Rows(0)(5).ToString()
                ComT_Class.Text = sqldt.Rows(0)(6).ToString()
                txtT_Loc.Text = sqldt.Rows(0)(7).ToString()
            Else

                txtT_Id.Text = ""
                txtT_FirstName.Text = ""
                txtT_LastName.Text = ""
                comT_Gender.Text = ""
                dtpTeach.Text = ""
                txtT_Phone.Text = ""
                ComT_Class.Text = ""
                txtT_Loc.Text = ""
            End If
        End Using

    End Sub

    Private Sub btnT_Home_Click(sender As Object, e As EventArgs) Handles btnT_Home.Click
        Dim Mform As New MainForm()
        Me.Close()
        Mform.Show()
    End Sub

    Private Sub T_DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles T_DGV.CellContentClick

    End Sub
End Class