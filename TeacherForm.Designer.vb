<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSearch_T = New System.Windows.Forms.TextBox()
        Me.btnSearch_T = New System.Windows.Forms.Button()
        Me.T_DGV = New System.Windows.Forms.DataGridView()
        Me.dtpTeach = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.comT_Gender = New System.Windows.Forms.ComboBox()
        Me.txtT_Phone = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtT_LastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtT_FirstName = New System.Windows.Forms.TextBox()
        Me.txtT_Id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtT_Loc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComT_Class = New System.Windows.Forms.ComboBox()
        Me.btnT_Delete = New System.Windows.Forms.Button()
        Me.btnT_Edit = New System.Windows.Forms.Button()
        Me.btnT_Add = New System.Windows.Forms.Button()
        Me.btnT_Home = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.T_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1188, 109)
        Me.Panel2.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(1148, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 38)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(445, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Teachers Form"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(379, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(333, 38)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "GNAAS UENR/CUG"
        '
        'txtSearch_T
        '
        Me.txtSearch_T.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch_T.Location = New System.Drawing.Point(657, 128)
        Me.txtSearch_T.Name = "txtSearch_T"
        Me.txtSearch_T.Size = New System.Drawing.Size(233, 38)
        Me.txtSearch_T.TabIndex = 50
        '
        'btnSearch_T
        '
        Me.btnSearch_T.BackColor = System.Drawing.Color.Gold
        Me.btnSearch_T.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch_T.Location = New System.Drawing.Point(527, 128)
        Me.btnSearch_T.Name = "btnSearch_T"
        Me.btnSearch_T.Size = New System.Drawing.Size(124, 40)
        Me.btnSearch_T.TabIndex = 49
        Me.btnSearch_T.Text = "Search"
        Me.btnSearch_T.UseVisualStyleBackColor = False
        '
        'T_DGV
        '
        Me.T_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_DGV.Location = New System.Drawing.Point(557, 184)
        Me.T_DGV.Name = "T_DGV"
        Me.T_DGV.RowHeadersWidth = 51
        Me.T_DGV.RowTemplate.Height = 24
        Me.T_DGV.Size = New System.Drawing.Size(613, 507)
        Me.T_DGV.TabIndex = 48
        '
        'dtpTeach
        '
        Me.dtpTeach.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTeach.Location = New System.Drawing.Point(201, 362)
        Me.dtpTeach.Name = "dtpTeach"
        Me.dtpTeach.Size = New System.Drawing.Size(322, 30)
        Me.dtpTeach.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label10.Location = New System.Drawing.Point(15, 347)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 38)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "D.O.B"
        '
        'comT_Gender
        '
        Me.comT_Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comT_Gender.FormattingEnabled = True
        Me.comT_Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.comT_Gender.Location = New System.Drawing.Point(201, 301)
        Me.comT_Gender.Name = "comT_Gender"
        Me.comT_Gender.Size = New System.Drawing.Size(233, 33)
        Me.comT_Gender.TabIndex = 45
        '
        'txtT_Phone
        '
        Me.txtT_Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT_Phone.Location = New System.Drawing.Point(201, 409)
        Me.txtT_Phone.Name = "txtT_Phone"
        Me.txtT_Phone.Size = New System.Drawing.Size(233, 38)
        Me.txtT_Phone.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label9.Location = New System.Drawing.Point(15, 406)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 38)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Phone No."
        '
        'txtT_LastName
        '
        Me.txtT_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT_LastName.Location = New System.Drawing.Point(201, 236)
        Me.txtT_LastName.Name = "txtT_LastName"
        Me.txtT_LastName.Size = New System.Drawing.Size(233, 38)
        Me.txtT_LastName.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(15, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 38)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Last Name"
        '
        'txtT_FirstName
        '
        Me.txtT_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT_FirstName.Location = New System.Drawing.Point(201, 184)
        Me.txtT_FirstName.Name = "txtT_FirstName"
        Me.txtT_FirstName.Size = New System.Drawing.Size(233, 38)
        Me.txtT_FirstName.TabIndex = 40
        '
        'txtT_Id
        '
        Me.txtT_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT_Id.Location = New System.Drawing.Point(75, 130)
        Me.txtT_Id.Name = "txtT_Id"
        Me.txtT_Id.Size = New System.Drawing.Size(233, 38)
        Me.txtT_Id.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(15, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 38)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(15, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 38)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(15, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 38)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "First Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(905, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(227, 38)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Teachers List"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label11.Location = New System.Drawing.Point(12, 465)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 38)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Class"
        '
        'txtT_Loc
        '
        Me.txtT_Loc.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT_Loc.Location = New System.Drawing.Point(198, 530)
        Me.txtT_Loc.Name = "txtT_Loc"
        Me.txtT_Loc.Size = New System.Drawing.Size(233, 38)
        Me.txtT_Loc.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label12.Location = New System.Drawing.Point(12, 527)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 38)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Location"
        '
        'ComT_Class
        '
        Me.ComT_Class.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComT_Class.FormattingEnabled = True
        Me.ComT_Class.Items.AddRange(New Object() {"Pioneers", "Reminants", "Disciples", "Milleerites", "Patriarchs", "Missionaries", "Adventurers", "soul winners"})
        Me.ComT_Class.Location = New System.Drawing.Point(198, 470)
        Me.ComT_Class.Name = "ComT_Class"
        Me.ComT_Class.Size = New System.Drawing.Size(233, 33)
        Me.ComT_Class.TabIndex = 55
        '
        'btnT_Delete
        '
        Me.btnT_Delete.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnT_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnT_Delete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnT_Delete.Location = New System.Drawing.Point(387, 585)
        Me.btnT_Delete.Name = "btnT_Delete"
        Me.btnT_Delete.Size = New System.Drawing.Size(136, 86)
        Me.btnT_Delete.TabIndex = 58
        Me.btnT_Delete.Text = "Delete"
        Me.btnT_Delete.UseVisualStyleBackColor = False
        '
        'btnT_Edit
        '
        Me.btnT_Edit.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnT_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnT_Edit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnT_Edit.Location = New System.Drawing.Point(201, 585)
        Me.btnT_Edit.Name = "btnT_Edit"
        Me.btnT_Edit.Size = New System.Drawing.Size(141, 86)
        Me.btnT_Edit.TabIndex = 57
        Me.btnT_Edit.Text = "Edit"
        Me.btnT_Edit.UseVisualStyleBackColor = False
        '
        'btnT_Add
        '
        Me.btnT_Add.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnT_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnT_Add.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnT_Add.Location = New System.Drawing.Point(22, 585)
        Me.btnT_Add.Name = "btnT_Add"
        Me.btnT_Add.Size = New System.Drawing.Size(142, 86)
        Me.btnT_Add.TabIndex = 56
        Me.btnT_Add.Text = "Add"
        Me.btnT_Add.UseVisualStyleBackColor = False
        '
        'btnT_Home
        '
        Me.btnT_Home.BackColor = System.Drawing.Color.Red
        Me.btnT_Home.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnT_Home.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnT_Home.Location = New System.Drawing.Point(144, 677)
        Me.btnT_Home.Name = "btnT_Home"
        Me.btnT_Home.Size = New System.Drawing.Size(259, 51)
        Me.btnT_Home.TabIndex = 59
        Me.btnT_Home.Text = "Home"
        Me.btnT_Home.UseVisualStyleBackColor = False
        '
        'TeacherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 747)
        Me.Controls.Add(Me.btnT_Home)
        Me.Controls.Add(Me.btnT_Delete)
        Me.Controls.Add(Me.btnT_Edit)
        Me.Controls.Add(Me.btnT_Add)
        Me.Controls.Add(Me.ComT_Class)
        Me.Controls.Add(Me.txtT_Loc)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSearch_T)
        Me.Controls.Add(Me.btnSearch_T)
        Me.Controls.Add(Me.T_DGV)
        Me.Controls.Add(Me.dtpTeach)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.comT_Gender)
        Me.Controls.Add(Me.txtT_Phone)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtT_LastName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtT_FirstName)
        Me.Controls.Add(Me.txtT_Id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TeacherForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TeacherForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.T_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearch_T As TextBox
    Friend WithEvents btnSearch_T As Button
    Friend WithEvents T_DGV As DataGridView
    Friend WithEvents dtpTeach As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents comT_Gender As ComboBox
    Friend WithEvents txtT_Phone As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtT_LastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtT_FirstName As TextBox
    Friend WithEvents txtT_Id As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtT_Loc As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComT_Class As ComboBox
    Friend WithEvents btnT_Delete As Button
    Friend WithEvents btnT_Edit As Button
    Friend WithEvents btnT_Add As Button
    Friend WithEvents btnT_Home As Button
End Class
