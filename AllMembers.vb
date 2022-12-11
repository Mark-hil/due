Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class AllMembers
    Private Sub btnGoTo_Click(sender As Object, e As EventArgs) Handles btnGoTo.Click
        Dim MForm As New MemberForm()
        MForm.Show()
        Me.Hide()
    End Sub

    Public Sub UpdateM_Table()
        Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT * FROM MemberTbl", con)
        Dim sqlDa As New SqlDataAdapter(cmd)
        Dim sqlDt As New DataTable
        sqlDa.Fill(sqlDt)
        All_DGV.DataSource = sqlDt
    End Sub

    Public Sub DuesList()
        Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT * FROM MemberTbl WHERE MemDues > " & 0 & "", con)
        Dim sqlDa As New SqlDataAdapter(cmd)
        Dim sqlDt As New DataTable
        sqlDa.Fill(sqlDt)
        All_DGV.DataSource = sqlDt
    End Sub

    Private Sub AllMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateM_Table()
    End Sub

    Private Sub All_DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles All_DGV.CellClick

    End Sub
    Private Sub All_DGV_MouseClick(sender As Object, e As MouseEventArgs) Handles All_DGV.MouseClick
        Try
            MemberForm.txtM_Id.Text = All_DGV.SelectedRows(0).Cells(0).Value.ToString
            MemberForm.txtM_FirstName.Text = All_DGV.SelectedRows(0).Cells(1).Value.ToString
            MemberForm.txtM_LastName.Text = All_DGV.SelectedRows(0).Cells(2).Value.ToString
            MemberForm.comM_Gender.Text = All_DGV.SelectedRows(0).Cells(3).Value.ToString
            MemberForm.dtpM_Dob.Text = All_DGV.SelectedRows(0).Cells(4).Value.ToString
            MemberForm.ComM_Level.Text = All_DGV.SelectedRows(0).Cells(5).Value.ToString
            'MemberForm.RadioButton1.Checked = All_DGV.SelectedRows(0).Cells(6).Value.ToString
            MemberForm.txtM_loc.Text = All_DGV.SelectedRows(0).Cells(6).Value.ToString
            MemberForm.txtM_Pro.Text = All_DGV.SelectedRows(0).Cells(7).Value.ToString
            MemberForm.txtM_Phone.Text = All_DGV.SelectedRows(0).Cells(8).Value.ToString
            MemberForm.txtMsch_Phone.Text = All_DGV.SelectedRows(0).Cells(9).Value.ToString
            MemberForm.txtM_loc.Text = All_DGV.SelectedRows(0).Cells(10).Value.ToString
            MemberForm.txtM_Town.Text = All_DGV.SelectedRows(0).Cells(11).Value.ToString
            MemberForm.txtFirstNameM_G.Text = All_DGV.SelectedRows(0).Cells(12).Value.ToString
            MemberForm.txtLastNameM_G.Text = All_DGV.SelectedRows(0).Cells(13).Value.ToString
            MemberForm.comM_Gender.Text = All_DGV.SelectedRows(0).Cells(14).Value.ToString
            MemberForm.txtPhoneM_G.Text = All_DGV.SelectedRows(0).Cells(15).Value.ToString
            MemberForm.txtLocM_G.Text = All_DGV.SelectedRows(0).Cells(16).Value.ToString
            MemberForm.txtOccupation.Text = All_DGV.SelectedRows(0).Cells(17).Value.ToString
            MemberForm.txtDues.Text = All_DGV.SelectedRows(0).Cells(18).Value.ToString

            MemberForm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnM_Search_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDuesList_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDuesList_Click_1(sender As Object, e As EventArgs) Handles btnDuesList.Click
        DuesList()
    End Sub

    Private Sub btnRefresh_Click_1(sender As Object, e As EventArgs) Handles btnRefresh.Click
        UpdateM_Table()
    End Sub

    Private Sub btnM_Search_Click_1(sender As Object, e As EventArgs) Handles btnM_Sea.Click


        TryCast(All_DGV.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("FirstName LIKE '%" & txtSearchA_G.Text & "%' OR LastName Like '%" & txtSearchA_G.Text & "%' OR Phone Like '%" & txtSearchA_G.Text & "%'")



    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
    End Sub

    Private Sub txtSearchA_G_TextChanged(sender As Object, e As EventArgs) Handles txtSearchA_G.TextChanged

        TryCast(All_DGV.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("FirstName LIKE '%" & txtSearchA_G.Text & "%' OR LastName Like '%" & txtSearchA_G.Text & "%'")


    End Sub
End Class