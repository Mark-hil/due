Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.Devices

Public Class MemberForm
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
    End Sub


    Private Sub MemberForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateM_Table()

    End Sub
    Public Sub UpdateM_Table()
        Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT * FROM MemberTbl", con)
        Dim sqlDa As New SqlDataAdapter(cmd)
        Dim sqlDt As New DataTable
        sqlDa.Fill(sqlDt)
        AllMembers.All_DGV.DataSource = sqlDt
    End Sub



    Private Sub btnM_Add_Click(sender As Object, e As EventArgs) Handles btnM_Add.Click
        Dim M_Id As String = txtM_Id.Text
        Dim FirstName As String = txtM_FirstName.Text
        Dim LastName As String = txtM_LastName.Text
        Dim Gender As String = comM_Gender.Text
        Dim Dob As String = dtpM_Dob.Text
        Dim Level As String = ComM_Level.Text
        Dim Deg_Dip As String = ""
        If RadioButton1.Checked = True Then
            Deg_Dip = "Degree"
        Else
            Deg_Dip = "Diploma"
        End If
        Dim Program As String = txtM_Pro.Text
        Dim Phone As String = txtM_Phone.Text
        Dim Sch_Phone As String = txtMsch_Phone.Text
        Dim Location As String = txtM_loc.Text
        Dim Town As String = txtM_Town.Text
        Dim G_FirstName As String = txtFirstNameM_G.Text
        Dim G_LastName As String = txtLastNameM_G.Text
        Dim G_Gender As String = comM_Gender.Text
        Dim G_Phone As String = txtPhoneM_G.Text
        Dim G_Location As String = txtLocM_G.Text
        Dim Occupation As String = txtOccupation.Text
        Dim MemDues As String = txtDues.Text

        Try
            Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
            con.Open()
            ' AllMembers.M_DGVRow.Add()
            Dim cmd As New SqlCommand("INSERT INTO  MemberTbl VALUES('" & M_Id & "', '" & FirstName & "', '" & LastName & "', '" & Gender & "', '" & Dob & "', '" & Level & "', '" & Deg_Dip & "',
                                             '" & Program & "', '" & Phone & "', '" & Sch_Phone & "', '" & Location & "',
                                            '" & Town & "', '" & G_FirstName & "', '" & G_LastName & "', '" & G_Gender & "', '" & G_Phone & "', '" & G_Location & "', '" & Occupation & "','" & MemDues & "' )", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("successfully inserted")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        UpdateM_Table()
        txtM_Id.Text = ""
        txtM_FirstName.Text = ""
        txtM_LastName.Text = ""
        comM_Gender.Text = ""
        dtpM_Dob.Text = ""
        ComM_Level.Text = ""
        txtM_loc.Text = ""
        txtM_Pro.Text = ""
        txtM_Phone.Text = ""
        txtMsch_Phone.Text = ""
        txtM_loc.Text = ""
        txtM_Town.Text = ""
        txtFirstNameM_G.Text = ""
        txtLastNameM_G.Text = ""
        comM_Gender.Text = ""
        txtPhoneM_G.Text = ""
        txtLocM_G.Text = ""
        txtOccupation.Text = ""
        txtDues.Text = ""
    End Sub

    Private Sub btnM_Delete_Click(sender As Object, e As EventArgs) Handles btnM_Delete.Click
        Dim M_Id As String = txtM_Id.Text
        Try
            Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM MemberTbl  WHERE M_Id = '" & M_Id & "'", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("successfully Updated")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        UpdateM_Table()
        txtM_Id.Text = ""
        txtM_FirstName.Text = ""
        txtM_LastName.Text = ""
        comM_Gender.Text = ""
        dtpM_Dob.Text = ""
        ComM_Level.Text = ""
        txtM_loc.Text = ""
        txtM_Pro.Text = ""
        txtM_Phone.Text = ""
        txtMsch_Phone.Text = ""
        txtM_loc.Text = ""
        txtM_Town.Text = ""
        txtFirstNameM_G.Text = ""
        txtLastNameM_G.Text = ""
        comM_Gender.Text = ""
        txtPhoneM_G.Text = ""
        txtLocM_G.Text = ""
        txtOccupation.Text = ""
        txtDues.Text = ""
    End Sub

    Private Sub btnM_Edit_Click(sender As Object, e As EventArgs) Handles btnM_Edit.Click
        Dim M_Id As String = txtM_Id.Text
        Dim FirstName As String = txtM_FirstName.Text
        Dim LastName As String = txtM_LastName.Text
        Dim Gender As String = comM_Gender.Text
        Dim Dob As String = dtpM_Dob.Text
        Dim Level As String = ComM_Level.Text
        Dim Deg_Dip As String = "True"
        If RadioButton1.Checked = True Then
            Deg_Dip = "Degree"
        Else
            Deg_Dip = "Diploma"
        End If
        Dim Program As String = txtM_Pro.Text
        Dim Phone As String = txtM_Phone.Text
        Dim Sch_Phone As String = txtMsch_Phone.Text
        Dim Location As String = txtM_loc.Text
        Dim Town As String = txtM_Town.Text
        Dim G_FirstName As String = txtFirstNameM_G.Text
        Dim G_LastName As String = txtLastNameM_G.Text
        Dim G_Gender As String = ComGenderM_G.Text
        Dim G_Phone As String = txtPhoneM_G.Text
        Dim G_Location As String = txtLocM_G.Text
        Dim Occupation As String = txtOccupation.Text
        Dim MemDues As String = txtDues.Text
        Try
            Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("UPDATE MemberTbl SET M_Id='" & M_Id & "',FirstName= '" & FirstName & "',LastName = '" & LastName & "', Gender = '" & Gender & "', M_Dob ='" & Dob & "', Level ='" & Level & "',M_Class = '" & Deg_Dip & "',
                                             Program = '" & Program & "', Phone = '" & Phone & "',Sch_Voda = '" & Sch_Phone & "',Location = '" & Location & "',
                                            Town ='" & Town & "',G_FirstName = '" & G_FirstName & "',G_LastName = '" & G_LastName & "',G_Gender = '" & G_Gender & "',
                                            G_Phone = '" & G_Phone & "', G_Location='" & G_Location & "',G_Occupation ='" & Occupation & "',MemDues ='" & MemDues & "' WHERE M_Id = '" & M_Id & "'", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("successfully Updated")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        UpdateM_Table()
        txtM_Id.Text = ""
        txtM_FirstName.Text = ""
        txtM_LastName.Text = ""
        comM_Gender.Text = ""
        dtpM_Dob.Text = ""
        ComM_Level.Text = ""
        txtM_loc.Text = ""
        txtM_Pro.Text = ""
        txtM_Phone.Text = ""
        txtMsch_Phone.Text = ""
        txtM_loc.Text = ""
        txtM_Town.Text = ""
        txtFirstNameM_G.Text = ""
        txtLastNameM_G.Text = ""
        comM_Gender.Text = ""
        txtPhoneM_G.Text = ""
        txtLocM_G.Text = ""
        txtOccupation.Text = ""
        txtDues.Text = ""
    End Sub


    Private Sub All_DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs)


        Try
            txtM_Id.Text = AllMembers.All_DGV.SelectedRows(0).Cells(0).Value.ToString
            txtM_FirstName.Text = AllMembers.All_DGV.SelectedRows(0).Cells(1).Value.ToString
            txtM_LastName.Text = AllMembers.All_DGV.SelectedRows(0).Cells(2).Value.ToString
            comM_Gender.Text = AllMembers.All_DGV.SelectedRows(0).Cells(3).Value.ToString
            dtpM_Dob.Text = AllMembers.All_DGV.SelectedRows(0).Cells(4).Value.ToString
            ComM_Level.Text = AllMembers.All_DGV.SelectedRows(0).Cells(5).Value.ToString
            ' RadioButton1.Checked = M_DGV.SelectedRows().Cells(6).Value.ToString
            txtM_loc.Text = AllMembers.All_DGV.SelectedRows(0).Cells(6).Value.ToString
            txtM_Pro.Text = AllMembers.All_DGV.SelectedRows(0).Cells(7).Value.ToString
            txtM_Phone.Text = AllMembers.All_DGV.SelectedRows(0).Cells(8).Value.ToString
            txtMsch_Phone.Text = AllMembers.All_DGV.SelectedRows(0).Cells(9).Value.ToString
            txtM_loc.Text = AllMembers.All_DGV.SelectedRows(0).Cells(10).Value.ToString
            txtM_Town.Text = AllMembers.All_DGV.SelectedRows(0).Cells(11).Value.ToString
            txtFirstNameM_G.Text = AllMembers.All_DGV.SelectedRows(0).Cells(12).Value.ToString
            txtLastNameM_G.Text = AllMembers.All_DGV.SelectedRows(0).Cells(13).Value.ToString
            comM_Gender.Text = AllMembers.All_DGV.SelectedRows(0).Cells(14).Value.ToString
            txtPhoneM_G.Text = AllMembers.All_DGV.SelectedRows(0).Cells(15).Value.ToString
            txtLocM_G.Text = AllMembers.All_DGV.SelectedRows(0).Cells(16).Value.ToString
            txtOccupation.Text = AllMembers.All_DGV.SelectedRows(0).Cells(17).Value.ToString
            txtDues.Text = AllMembers.All_DGV.SelectedRows(0).Cells(18).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnM_Home_Click(sender As Object, e As EventArgs) Handles btnM_Home.Click
        Dim Mform As New MainForm()
        Me.Close()
        Mform.Show()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class