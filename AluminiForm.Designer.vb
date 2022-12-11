<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AluminiForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAluFirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAluId = New System.Windows.Forms.TextBox()
        Me.txtAluLastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUserHome = New System.Windows.Forms.Button()
        Me.btnAluDelete = New System.Windows.Forms.Button()
        Me.btnAluEdit = New System.Windows.Forms.Button()
        Me.btnAluAdd = New System.Windows.Forms.Button()
        Me.txtAluPhone = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.comAluGender = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpAlu = New System.Windows.Forms.DateTimePicker()
        Me.AluDGV = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSearchAlu = New System.Windows.Forms.Button()
        Me.txtSearchAlu = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.AluDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1190, 112)
        Me.Panel1.TabIndex = 0
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
        Me.Panel2.Size = New System.Drawing.Size(1190, 109)
        Me.Panel2.TabIndex = 9
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
        Me.Label1.Size = New System.Drawing.Size(220, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Alumini Form"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(392, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 38)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Alumini Form"
        '
        'txtAluFirstName
        '
        Me.txtAluFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAluFirstName.Location = New System.Drawing.Point(209, 195)
        Me.txtAluFirstName.Name = "txtAluFirstName"
        Me.txtAluFirstName.Size = New System.Drawing.Size(233, 38)
        Me.txtAluFirstName.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(23, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 38)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(23, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 38)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(23, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 38)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Id"
        '
        'txtAluId
        '
        Me.txtAluId.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAluId.Location = New System.Drawing.Point(83, 141)
        Me.txtAluId.Name = "txtAluId"
        Me.txtAluId.Size = New System.Drawing.Size(233, 38)
        Me.txtAluId.TabIndex = 8
        '
        'txtAluLastName
        '
        Me.txtAluLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAluLastName.Location = New System.Drawing.Point(209, 247)
        Me.txtAluLastName.Name = "txtAluLastName"
        Me.txtAluLastName.Size = New System.Drawing.Size(233, 38)
        Me.txtAluLastName.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(23, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 38)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Last Name"
        '
        'btnUserHome
        '
        Me.btnUserHome.BackColor = System.Drawing.Color.Red
        Me.btnUserHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserHome.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnUserHome.Location = New System.Drawing.Point(138, 580)
        Me.btnUserHome.Name = "btnUserHome"
        Me.btnUserHome.Size = New System.Drawing.Size(259, 51)
        Me.btnUserHome.TabIndex = 26
        Me.btnUserHome.Text = "Home"
        Me.btnUserHome.UseVisualStyleBackColor = False
        '
        'btnAluDelete
        '
        Me.btnAluDelete.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnAluDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAluDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnAluDelete.Location = New System.Drawing.Point(383, 478)
        Me.btnAluDelete.Name = "btnAluDelete"
        Me.btnAluDelete.Size = New System.Drawing.Size(136, 86)
        Me.btnAluDelete.TabIndex = 25
        Me.btnAluDelete.Text = "Delete"
        Me.btnAluDelete.UseVisualStyleBackColor = False
        '
        'btnAluEdit
        '
        Me.btnAluEdit.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnAluEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAluEdit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnAluEdit.Location = New System.Drawing.Point(197, 478)
        Me.btnAluEdit.Name = "btnAluEdit"
        Me.btnAluEdit.Size = New System.Drawing.Size(141, 86)
        Me.btnAluEdit.TabIndex = 24
        Me.btnAluEdit.Text = "Edit"
        Me.btnAluEdit.UseVisualStyleBackColor = False
        '
        'btnAluAdd
        '
        Me.btnAluAdd.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnAluAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAluAdd.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnAluAdd.Location = New System.Drawing.Point(18, 478)
        Me.btnAluAdd.Name = "btnAluAdd"
        Me.btnAluAdd.Size = New System.Drawing.Size(142, 86)
        Me.btnAluAdd.TabIndex = 23
        Me.btnAluAdd.Text = "Add"
        Me.btnAluAdd.UseVisualStyleBackColor = False
        '
        'txtAluPhone
        '
        Me.txtAluPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAluPhone.Location = New System.Drawing.Point(209, 420)
        Me.txtAluPhone.Name = "txtAluPhone"
        Me.txtAluPhone.Size = New System.Drawing.Size(233, 38)
        Me.txtAluPhone.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label9.Location = New System.Drawing.Point(23, 417)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 38)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Phone No."
        '
        'comAluGender
        '
        Me.comAluGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comAluGender.FormattingEnabled = True
        Me.comAluGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.comAluGender.Location = New System.Drawing.Point(209, 312)
        Me.comAluGender.Name = "comAluGender"
        Me.comAluGender.Size = New System.Drawing.Size(233, 33)
        Me.comAluGender.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label10.Location = New System.Drawing.Point(23, 358)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 38)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "D.O.B"
        '
        'dtpAlu
        '
        Me.dtpAlu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAlu.Location = New System.Drawing.Point(209, 373)
        Me.dtpAlu.Name = "dtpAlu"
        Me.dtpAlu.Size = New System.Drawing.Size(322, 30)
        Me.dtpAlu.TabIndex = 31
        '
        'AluDGV
        '
        Me.AluDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AluDGV.Location = New System.Drawing.Point(565, 195)
        Me.AluDGV.Name = "AluDGV"
        Me.AluDGV.RowHeadersWidth = 51
        Me.AluDGV.RowTemplate.Height = 24
        Me.AluDGV.Size = New System.Drawing.Size(613, 414)
        Me.AluDGV.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(940, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(195, 38)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Alumini List"
        '
        'btnSearchAlu
        '
        Me.btnSearchAlu.BackColor = System.Drawing.Color.Gold
        Me.btnSearchAlu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchAlu.Location = New System.Drawing.Point(535, 139)
        Me.btnSearchAlu.Name = "btnSearchAlu"
        Me.btnSearchAlu.Size = New System.Drawing.Size(124, 40)
        Me.btnSearchAlu.TabIndex = 34
        Me.btnSearchAlu.Text = "Search"
        Me.btnSearchAlu.UseVisualStyleBackColor = False
        '
        'txtSearchAlu
        '
        Me.txtSearchAlu.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchAlu.Location = New System.Drawing.Point(665, 139)
        Me.txtSearchAlu.Name = "txtSearchAlu"
        Me.txtSearchAlu.Size = New System.Drawing.Size(233, 38)
        Me.txtSearchAlu.TabIndex = 35
        '
        'AluminiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 641)
        Me.Controls.Add(Me.txtSearchAlu)
        Me.Controls.Add(Me.btnSearchAlu)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.AluDGV)
        Me.Controls.Add(Me.dtpAlu)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.comAluGender)
        Me.Controls.Add(Me.txtAluPhone)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnUserHome)
        Me.Controls.Add(Me.btnAluDelete)
        Me.Controls.Add(Me.btnAluEdit)
        Me.Controls.Add(Me.btnAluAdd)
        Me.Controls.Add(Me.txtAluLastName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtAluFirstName)
        Me.Controls.Add(Me.txtAluId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AluminiForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AluminiForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.AluDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAluFirstName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAluId As TextBox
    Friend WithEvents txtAluLastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnUserHome As Button
    Friend WithEvents btnAluDelete As Button
    Friend WithEvents btnAluEdit As Button
    Friend WithEvents btnAluAdd As Button
    Friend WithEvents txtAluPhone As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents comAluGender As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpAlu As DateTimePicker
    Friend WithEvents AluDGV As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSearchAlu As Button
    Friend WithEvents txtSearchAlu As TextBox
End Class
