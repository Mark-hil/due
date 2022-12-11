<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.UserDGV = New System.Windows.Forms.DataGridView()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtUserPass = New System.Windows.Forms.TextBox()
        Me.btnUserAdd = New System.Windows.Forms.Button()
        Me.btnUserEdit = New System.Windows.Forms.Button()
        Me.btnUserDelete = New System.Windows.Forms.Button()
        Me.btnUserHome = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.UserDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserDGV
        '
        Me.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDGV.Location = New System.Drawing.Point(600, 157)
        Me.UserDGV.Name = "UserDGV"
        Me.UserDGV.RowHeadersWidth = 51
        Me.UserDGV.RowTemplate.Height = 24
        Me.UserDGV.Size = New System.Drawing.Size(443, 414)
        Me.UserDGV.TabIndex = 0
        '
        'txtUserId
        '
        Me.txtUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserId.Location = New System.Drawing.Point(129, 177)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(233, 38)
        Me.txtUserId.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(12, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(12, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 38)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "UserName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(12, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 38)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Password"
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(198, 250)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(233, 38)
        Me.txtUserName.TabIndex = 5
        '
        'txtUserPass
        '
        Me.txtUserPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPass.Location = New System.Drawing.Point(198, 330)
        Me.txtUserPass.Name = "txtUserPass"
        Me.txtUserPass.Size = New System.Drawing.Size(233, 38)
        Me.txtUserPass.TabIndex = 6
        '
        'btnUserAdd
        '
        Me.btnUserAdd.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnUserAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserAdd.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnUserAdd.Location = New System.Drawing.Point(19, 418)
        Me.btnUserAdd.Name = "btnUserAdd"
        Me.btnUserAdd.Size = New System.Drawing.Size(142, 86)
        Me.btnUserAdd.TabIndex = 7
        Me.btnUserAdd.Text = "Add"
        Me.btnUserAdd.UseVisualStyleBackColor = False
        '
        'btnUserEdit
        '
        Me.btnUserEdit.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnUserEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserEdit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnUserEdit.Location = New System.Drawing.Point(198, 418)
        Me.btnUserEdit.Name = "btnUserEdit"
        Me.btnUserEdit.Size = New System.Drawing.Size(141, 86)
        Me.btnUserEdit.TabIndex = 8
        Me.btnUserEdit.Text = "Edit"
        Me.btnUserEdit.UseVisualStyleBackColor = False
        '
        'btnUserDelete
        '
        Me.btnUserDelete.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnUserDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnUserDelete.Location = New System.Drawing.Point(384, 418)
        Me.btnUserDelete.Name = "btnUserDelete"
        Me.btnUserDelete.Size = New System.Drawing.Size(136, 86)
        Me.btnUserDelete.TabIndex = 9
        Me.btnUserDelete.Text = "Delete"
        Me.btnUserDelete.UseVisualStyleBackColor = False
        '
        'btnUserHome
        '
        Me.btnUserHome.BackColor = System.Drawing.Color.Red
        Me.btnUserHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserHome.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnUserHome.Location = New System.Drawing.Point(139, 520)
        Me.btnUserHome.Name = "btnUserHome"
        Me.btnUserHome.Size = New System.Drawing.Size(259, 51)
        Me.btnUserHome.TabIndex = 10
        Me.btnUserHome.Text = "Home"
        Me.btnUserHome.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(363, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GNAAS UENR/CUG"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(445, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 38)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "User Form"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1103, 109)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1103, 109)
        Me.Panel2.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(1060, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 38)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "X"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(445, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 38)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "User Form"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(363, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(333, 38)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "GNAAS UENR/CUG"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(720, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 38)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "User List"
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 613)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnUserHome)
        Me.Controls.Add(Me.btnUserDelete)
        Me.Controls.Add(Me.btnUserEdit)
        Me.Controls.Add(Me.btnUserAdd)
        Me.Controls.Add(Me.txtUserPass)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UserDGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserForm"
        CType(Me.UserDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserDGV As DataGridView
    Friend WithEvents txtUserId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtUserPass As TextBox
    Friend WithEvents btnUserAdd As Button
    Friend WithEvents btnUserEdit As Button
    Friend WithEvents btnUserDelete As Button
    Friend WithEvents btnUserHome As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
End Class
