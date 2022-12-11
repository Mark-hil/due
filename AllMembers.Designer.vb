<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllMembers
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
        Me.All_DGV = New System.Windows.Forms.DataGridView()
        Me.btnGoTo = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDuesList = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSearchA_G = New System.Windows.Forms.TextBox()
        Me.btnM_Sea = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.All_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'All_DGV
        '
        Me.All_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.All_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.All_DGV.Location = New System.Drawing.Point(12, 188)
        Me.All_DGV.Name = "All_DGV"
        Me.All_DGV.RowHeadersWidth = 51
        Me.All_DGV.RowTemplate.Height = 24
        Me.All_DGV.Size = New System.Drawing.Size(1536, 483)
        Me.All_DGV.TabIndex = 65
        '
        'btnGoTo
        '
        Me.btnGoTo.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGoTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoTo.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnGoTo.Location = New System.Drawing.Point(23, 95)
        Me.btnGoTo.Name = "btnGoTo"
        Me.btnGoTo.Size = New System.Drawing.Size(252, 48)
        Me.btnGoTo.TabIndex = 68
        Me.btnGoTo.Text = "Go to Form"
        Me.btnGoTo.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnRefresh.Location = New System.Drawing.Point(596, 95)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(252, 48)
        Me.btnRefresh.TabIndex = 73
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnDuesList
        '
        Me.btnDuesList.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnDuesList.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDuesList.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnDuesList.Location = New System.Drawing.Point(306, 96)
        Me.btnDuesList.Name = "btnDuesList"
        Me.btnDuesList.Size = New System.Drawing.Size(252, 47)
        Me.btnDuesList.TabIndex = 72
        Me.btnDuesList.Text = "Paid Dues List"
        Me.btnDuesList.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label21.Location = New System.Drawing.Point(564, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(207, 38)
        Me.Label21.TabIndex = 71
        Me.Label21.Text = "Member List"
        '
        'txtSearchA_G
        '
        Me.txtSearchA_G.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchA_G.Location = New System.Drawing.Point(1071, 99)
        Me.txtSearchA_G.Name = "txtSearchA_G"
        Me.txtSearchA_G.Size = New System.Drawing.Size(233, 38)
        Me.txtSearchA_G.TabIndex = 70
        '
        'btnM_Sea
        '
        Me.btnM_Sea.BackColor = System.Drawing.Color.Gold
        Me.btnM_Sea.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnM_Sea.Location = New System.Drawing.Point(878, 95)
        Me.btnM_Sea.Name = "btnM_Sea"
        Me.btnM_Sea.Size = New System.Drawing.Size(163, 48)
        Me.btnM_Sea.TabIndex = 69
        Me.btnM_Sea.Text = "Search"
        Me.btnM_Sea.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1560, 86)
        Me.Panel1.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(1522, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 38)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "X"
        '
        'AllMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1560, 683)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDuesList)
        Me.Controls.Add(Me.txtSearchA_G)
        Me.Controls.Add(Me.btnM_Sea)
        Me.Controls.Add(Me.btnGoTo)
        Me.Controls.Add(Me.All_DGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AllMembers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AllMembers"
        CType(Me.All_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGoTo As Button
    Public WithEvents All_DGV As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDuesList As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents txtSearchA_G As TextBox
    Friend WithEvents btnM_Sea As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
End Class
