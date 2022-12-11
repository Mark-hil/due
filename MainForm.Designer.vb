<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnExpand = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Sc = New System.Windows.Forms.SplitContainer()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnUserHome = New System.Windows.Forms.Button()
        Me.btnMformU = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Sc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sc.Panel1.SuspendLayout()
        Me.Sc.Panel2.SuspendLayout()
        Me.Sc.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(1305, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 38)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "X"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(3, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(328, 69)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Teacher"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(16, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(863, 64)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "GHANA NATIONAL ASSOCIATION OF ADVENTISIT STUDENT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UENR/CUCG"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(290, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 230)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "WELCOME" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " OUR " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " FOLLOWSHIP " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DATABASE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.btnMin)
        Me.Panel1.Controls.Add(Me.btnMax)
        Me.Panel1.Controls.Add(Me.btnExpand)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1347, 86)
        Me.Panel1.TabIndex = 0
        '
        'btnMin
        '
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Image = Global.Gnaas_UENR.My.Resources.Resources.min
        Me.btnMin.Location = New System.Drawing.Point(1217, 3)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(38, 35)
        Me.btnMin.TabIndex = 17
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Image = Global.Gnaas_UENR.My.Resources.Resources.max
        Me.btnMax.Location = New System.Drawing.Point(1263, 3)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(44, 35)
        Me.btnMax.TabIndex = 16
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'btnExpand
        '
        Me.btnExpand.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExpand.FlatAppearance.BorderSize = 0
        Me.btnExpand.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpand.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExpand.Image = Global.Gnaas_UENR.My.Resources.Resources.menus
        Me.btnExpand.Location = New System.Drawing.Point(0, 0)
        Me.btnExpand.Name = "btnExpand"
        Me.btnExpand.Size = New System.Drawing.Size(74, 76)
        Me.btnExpand.TabIndex = 15
        Me.btnExpand.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Sc
        '
        Me.Sc.Location = New System.Drawing.Point(0, 82)
        Me.Sc.Name = "Sc"
        '
        'Sc.Panel1
        '
        Me.Sc.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Sc.Panel1.Controls.Add(Me.Button6)
        Me.Sc.Panel1.Controls.Add(Me.Panel2)
        Me.Sc.Panel1.Controls.Add(Me.Button5)
        Me.Sc.Panel1.Controls.Add(Me.Button1)
        Me.Sc.Panel1.Controls.Add(Me.Button2)
        Me.Sc.Panel1.Controls.Add(Me.Button3)
        Me.Sc.Panel1.Controls.Add(Me.Button4)
        Me.Sc.Panel1.Controls.Add(Me.btnUserHome)
        Me.Sc.Panel1.Controls.Add(Me.btnMformU)
        '
        'Sc.Panel2
        '
        Me.Sc.Panel2.Controls.Add(Me.Panel3)
        Me.Sc.Panel2.Controls.Add(Me.Label1)
        Me.Sc.Panel2.Controls.Add(Me.Label7)
        Me.Sc.Panel2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Sc.Size = New System.Drawing.Size(1347, 812)
        Me.Sc.SplitterDistance = 334
        Me.Sc.TabIndex = 16
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.Control
        Me.Button6.Image = Global.Gnaas_UENR.My.Resources.Resources.shutdown
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(3, 734)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(328, 63)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "LogOut"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 160)
        Me.Panel2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.Gnaas_UENR.My.Resources.Resources.gnaas_logo
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Location = New System.Drawing.Point(82, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(223, 129)
        Me.Panel4.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button5.Image = Global.Gnaas_UENR.My.Resources.Resources.dashborad
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(3, 558)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(328, 71)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "DashBoard"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Image = Global.Gnaas_UENR.My.Resources.Resources.student
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(3, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(328, 83)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Add Members"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Image = Global.Gnaas_UENR.My.Resources.Resources.icons8_old_man_smiling_48
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(3, 333)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(328, 70)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Alumini"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.Control
        Me.Button4.Image = Global.Gnaas_UENR.My.Resources.Resources.dues_copy2
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(3, 482)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(328, 80)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Dues"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnUserHome
        '
        Me.btnUserHome.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnUserHome.FlatAppearance.BorderSize = 0
        Me.btnUserHome.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnUserHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserHome.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnUserHome.Image = Global.Gnaas_UENR.My.Resources.Resources.manage
        Me.btnUserHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserHome.Location = New System.Drawing.Point(3, 641)
        Me.btnUserHome.Name = "btnUserHome"
        Me.btnUserHome.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnUserHome.Size = New System.Drawing.Size(328, 79)
        Me.btnUserHome.TabIndex = 11
        Me.btnUserHome.Text = "All Members"
        Me.btnUserHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUserHome.UseVisualStyleBackColor = False
        '
        'btnMformU
        '
        Me.btnMformU.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnMformU.FlatAppearance.BorderSize = 0
        Me.btnMformU.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnMformU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMformU.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMformU.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMformU.Image = Global.Gnaas_UENR.My.Resources.Resources.users
        Me.btnMformU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMformU.Location = New System.Drawing.Point(3, 401)
        Me.btnMformU.Name = "btnMformU"
        Me.btnMformU.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnMformU.Size = New System.Drawing.Size(328, 87)
        Me.btnMformU.TabIndex = 1
        Me.btnMformU.Text = "Users"
        Me.btnMformU.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 760)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1009, 52)
        Me.Panel3.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(799, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Design by chillop®"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1347, 893)
        Me.Controls.Add(Me.Sc)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Sc.Panel1.ResumeLayout(False)
        Me.Sc.Panel2.ResumeLayout(False)
        Me.Sc.Panel2.PerformLayout()
        CType(Me.Sc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sc.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMformU As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnUserHome As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExpand As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Sc As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
End Class
