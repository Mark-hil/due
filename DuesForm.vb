Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.IO.Compression
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports NPOI.OpenXmlFormats.Wordprocessing
Imports NPOI.SS.Formula.Functions
Imports Org.BouncyCastle.Math.EC.Custom

Public Class DuesForm
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
    End Sub
    Private Sub FillMemberId()
        Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
        Try
            con.Open()
            Dim query As String = "SELECT * FROM MemberTbl"
            Dim cmd As New SqlCommand(query, con)
            Dim sqlDr As SqlDataReader
            sqlDr = cmd.ExecuteReader()
            While sqlDr.Read
                Dim FirstName As String = sqlDr.GetString(1)
                comM_Id.Items.Add(FirstName)
            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
        End Try

    End Sub
    Private Sub UpdateStd()
        Dim Dues As Integer = txtAmount.Text
        Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand("UPDATE MemberTbl SET MemDues = '" & txtAmount.Text & "' WHERE M_Id = '" & comM_Id.SelectedItem.ToString & "'", con)
        cmd.ExecuteNonQuery()
        ' MessageBox.Show("successfully Updated")
        con.Close()
    End Sub
    Private Sub DuesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillMemberId()
        'Autoload()
        UpdateM_Table()
        'UpdateStd()
    End Sub

    Private Sub Autoload()
        Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")

        Try
            con.Open()
            Dim query As String
            query = "Select FirstName,LastName from MemberTbl "
            Dim Cmd As New SqlCommand(query, con)
            Dim Reader = Cmd.ExecuteReader()
            While Reader.Read
                Dim FirstName = Reader.GetString("FirstName")
                'FirstName = Reader.GetString("FirstName")
                comM_Id.Items.Add(FirstName)
            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub
    ' Private Sub comM_Id_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles comM_Id.SelectionChangeCommitted
    'Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")

    '   con.Open()
    'Dim P_FirstName As String = txtP_FirstName.Text
    'Dim P_LastName As String = txtP_LastName.Text
    'Dim M_Id As String = comM_Id.Text
    'Dim query As String = "SELECT * FROM MemberTbl WHERE M_Id = '" & comM_Id.SelectedValue.ToString() & "'"
    'Dim cmd As New SqlCommand(query, con)
    'Dim sqlDt As New DataTable
    'Dim sqlDa As New SqlDataAdapter(cmd)
    '   sqlDa.Fill(sqlDt)
    'Dim FirstName As String = txtFirstName_P.Text
    'Dim LastName As String = txtLastName_P.Text

    'End Sub

    Private Sub comM_Id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comM_Id.SelectedIndexChanged
        Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")

        Try
            con.Open()
            Dim query As String = "SELECT * FROM MemberTbl where FirstName = '" & comM_Id.Text & "'"
            Dim cmd As New SqlCommand(query, con)
            Dim sqlDr As SqlDataReader
            sqlDr = cmd.ExecuteReader()
            ' Dim FirstName = comM_Id.Text
            ' Dim sqlDt As New DataTable
            'sqlDt.Columns.Add(FirstName)
            ' sqlDt.Load(sqlDr)
            'comM_Id.DisplayMember = "M_Id"
            'comM_Id.ValueMember = "FirstName"
            'comM_Id.DataSource = sqlDt

            While sqlDr.Read
                ' comM_Id.Text = sqlDr.GetString("M_Id")
                txtP_LastName.Text = sqlDr.GetString(2)
                txtP_FirstName.Text = sqlDr.GetString(0)
                ComP_Level.Text = sqlDr.GetInt32(5)


            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Public Sub UpdateM_Table()
        Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT * FROM DuesTbl", con)
        Dim sqlDa As New SqlDataAdapter(cmd)
        Dim sqlDt As New DataTable
        sqlDa.Fill(sqlDt)
        DuesDGV.DataSource = sqlDt
    End Sub


    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim P_Id As Integer = txtP_Id.Text
        Dim FirstName As String = txtP_FirstName.Text
        Dim LastName As String = txtP_LastName.Text
        Dim M_Id As String = comM_Id.Text
        Dim Period As String = dtpPeriod.Text
        ' Dim Phone As String = txtT_Phone.Text
        Dim Level As String = ComP_Level.Text
        Dim Amount As String = txtAmount.Text
        Try
            Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
            con.Open()
            Dim sqlDa As New SqlDataAdapter("SELECT count(*) FROM DuesTbl WHERE M_Id =  '" & comM_Id.Text & "' AND Period = '" & dtpPeriod.Text & "'", con)
            Dim sqlDt As New DataTable()
            sqlDa.Fill(sqlDt)
            If sqlDt.Rows(0)(0).ToString = "1" Then
                MessageBox.Show("No Dues For the  Selected Period")
                con.Close()
            Else
                ' con.Open()
                Dim cmd As New SqlCommand("INSERT INTO  DuesTbl VALUES('" & P_Id & "','" & M_Id & "', '" & FirstName & "', '" & LastName & "', '" & Period & "', '" & Level & "', '" & Amount & "' )", con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("successfully inserted")
                con.Close()
                UpdateStd()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'UpdateStd()
        UpdateM_Table()

        txtP_Id.Text = ""
        comM_Id.Text = ""
        txtP_FirstName.Text = ""
        txtP_LastName.Text = ""

        dtpPeriod.Text = ""
        ComP_Level.Text = ""
        txtAmount.Text = ""
        ' txtT_Loc.Text = ""
    End Sub

    Private Sub btnP_Edit_Click(sender As Object, e As EventArgs) Handles btnP_Edit.Click
        Dim P_Id As Integer = txtP_Id.Text
        Dim FirstName As String = txtP_FirstName.Text
        Dim LastName As String = txtP_LastName.Text
        Dim M_Id As String = comM_Id.Text
        Dim Period As String = dtpPeriod.Text
        ' Dim Phone As String = txtT_Phone.Text
        Dim Level As String = ComP_Level.Text
        Dim Amount As String = txtAmount.Text
        Try
            Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("UPDATE DuesTbl SET Num = '" & P_Id & "',M_Id = '" & M_Id & "', FirstName = '" & FirstName & "', LastName =  '" & LastName & "', Period =  '" & Period & "', Level =  '" & Level & "',  Amount =  '" & Amount & "' WHERE M_Id = '" & M_Id & "'", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("successfully inserted")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        UpdateStd()
        UpdateM_Table()

        txtP_Id.Text = ""
        comM_Id.Text = ""
        txtP_FirstName.Text = ""
        txtP_LastName.Text = ""
        dtpPeriod.Text = ""
        ComP_Level.Text = ""
        txtAmount.Text = ""
        ' txtT_Loc.Text = ""
    End Sub

    Private Sub DuesDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DuesDGV.CellClick


        Try
            txtP_Id.Text = DuesDGV.SelectedRows(0).Cells(0).Value.ToString
            comM_Id.Text = DuesDGV.SelectedRows(0).Cells(2).Value.ToString
            txtP_FirstName.Text = DuesDGV.SelectedRows(0).Cells(1).Value.ToString
            txtP_LastName.Text = DuesDGV.SelectedRows(0).Cells(3).Value.ToString
            dtpPeriod.Text = DuesDGV.SelectedRows(0).Cells(4).Value.ToString
            ComP_Level.Text = DuesDGV.SelectedRows(0).Cells(5).Value.ToString
            txtAmount.Text = DuesDGV.SelectedRows(0).Cells(6).Value.ToString
            'ComT_Class.Text = T_DGV.SelectedRows(0).Cells(6).Value.ToString
            'txtT_Loc.Text = T_DGV.SelectedRows(0).Cells(6).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnM_Search_Click(sender As Object, e As EventArgs) Handles btnM_Search.Click
        Dim search As String = txtSearchM_G.Text
        Dim con As New SqlConnection("Data Source=CHILLOP\SQLEXPRESS01;Initial Catalog=GNAAS_UENR_db;Integrated Security=True")

        Dim cmd As New SqlCommand("SELECT * FROM  DuesTbl  WHERE   FirstName = '" & search & "'", con)
        Dim sqlDa As New SqlDataAdapter(cmd)
        Using sqldt As New DataTable
            sqlDa.Fill(sqldt)
            If sqldt.Rows.Count > 0 Then
                txtP_Id.Text = sqldt.Rows(0)(0).ToString()
                comM_Id.Text = sqldt.Rows(0)(1).ToString()
                txtP_FirstName.Text = sqldt.Rows(0)(2).ToString()
                txtP_LastName.Text = sqldt.Rows(0)(3).ToString()
                dtpPeriod.Text = sqldt.Rows(0)(4).ToString()
                ComP_Level.Text = sqldt.Rows(0)(5).ToString()
                txtAmount.Text = sqldt.Rows(0)(6).ToString()
                ' ComT_Class.Text = sqldt.Rows(0)(6).ToString()
                'txtT_Loc.Text = sqldt.Rows(0)(7).ToString()
            Else

                txtP_Id.Text = ""
                comM_Id.Text = ""
                txtP_FirstName.Text = ""
                txtP_LastName.Text = ""
                dtpPeriod.Text = ""
                ComP_Level.Text = ""
                txtAmount.Text = ""
                ' ComT_Class.Text = ""
                'txtT_Loc.Text = ""
            End If
        End Using
    End Sub

    Private Sub btnP_Home_Click(sender As Object, e As EventArgs) Handles btnP_Home.Click
        Dim Mform As New MainForm()
        Me.Close()
        Mform.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("DUES RECEIPT", New Font("centuy", 25, FontStyle.Bold), Brushes.Red, New Point(230))
        e.Graphics.DrawString("Member Id", New Font("centuy", 20, FontStyle.Bold), Brushes.Blue, New Point(40, 50))
        e.Graphics.DrawString(DuesDGV.SelectedRows(0).Cells(0).Value.ToString, New Font("centuy", 20, FontStyle.Bold), Brushes.Red, New Point(250, 50))
        e.Graphics.DrawString("SURNAME", New Font("centuy", 20, FontStyle.Bold), Brushes.Blue, New Point(40, 80))
        e.Graphics.DrawString(DuesDGV.SelectedRows(0).Cells(1).Value.ToString, New Font("centuy", 20, FontStyle.Bold), Brushes.Red, New Point(300, 80))
        e.Graphics.DrawString("FIRSTNAME", New Font("centuy", 20, FontStyle.Bold), Brushes.Blue, New Point(40, 110))
        e.Graphics.DrawString(DuesDGV.SelectedRows(0).Cells(2).Value.ToString, New Font("centuy", 20, FontStyle.Bold), Brushes.Red, New Point(300, 110))
        e.Graphics.DrawString("PERIOD", New Font("centuy", 20, FontStyle.Bold), Brushes.Blue, New Point(40, 140))
        e.Graphics.DrawString(DuesDGV.SelectedRows(0).Cells(3).Value.ToString, New Font("centuy", 20, FontStyle.Bold), Brushes.Red, New Point(300, 140))
        e.Graphics.DrawString("LEVEL", New Font("centuy", 20, FontStyle.Bold), Brushes.Blue, New Point(40, 170))
        e.Graphics.DrawString(DuesDGV.SelectedRows(0).Cells(4).Value.ToString, New Font("centuy", 20, FontStyle.Bold), Brushes.Red, New Point(300, 170))
        e.Graphics.DrawString("AMOUNT", New Font("centuy", 20, FontStyle.Bold), Brushes.Blue, New Point(40, 200))
        e.Graphics.DrawString(DuesDGV.SelectedRows(0).Cells(5).Value.ToString, New Font("centuy", 20, FontStyle.Bold), Brushes.Red, New Point(300, 200))
        e.Graphics.DrawString("GNAAS UENR/CUG", New Font("centuy", 20, FontStyle.Bold), Brushes.Red, New Point(230, 250))
    End Sub

    Private Sub DuesDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DuesDGV.CellContentClick
        If PrintPreviewDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub
End Class