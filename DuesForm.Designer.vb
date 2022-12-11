<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DuesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DuesForm))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComP_Level = New System.Windows.Forms.ComboBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpPeriod = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.comM_Id = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtP_FirstName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtP_LastName = New System.Windows.Forms.TextBox()
        Me.txtP_Id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DuesDGV = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSearchM_G = New System.Windows.Forms.TextBox()
        Me.btnM_Search = New System.Windows.Forms.Button()
        Me.btnP_Home = New System.Windows.Forms.Button()
        Me.btnP_Delete = New System.Windows.Forms.Button()
        Me.btnP_Edit = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel2.SuspendLayout()
        CType(Me.DuesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Size = New System.Drawing.Size(1226, 96)
        Me.Panel2.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(1187, 0)
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
        Me.Label1.Location = New System.Drawing.Point(422, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dues Form"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(372, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(333, 38)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "GNAAS UENR/CUG"
        '
        'ComP_Level
        '
        Me.ComP_Level.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComP_Level.FormattingEnabled = True
        Me.ComP_Level.Items.AddRange(New Object() {"100", "200", "300", "400"})
        Me.ComP_Level.Location = New System.Drawing.Point(151, 382)
        Me.ComP_Level.Name = "ComP_Level"
        Me.ComP_Level.Size = New System.Drawing.Size(305, 33)
        Me.ComP_Level.TabIndex = 71
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(151, 440)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(305, 30)
        Me.txtAmount.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(12, 445)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 25)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Amount"
        '
        'dtpPeriod
        '
        Me.dtpPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPeriod.Location = New System.Drawing.Point(151, 330)
        Me.dtpPeriod.Name = "dtpPeriod"
        Me.dtpPeriod.Size = New System.Drawing.Size(308, 30)
        Me.dtpPeriod.TabIndex = 68
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label10.Location = New System.Drawing.Point(12, 337)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 25)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Period"
        '
        'comM_Id
        '
        Me.comM_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comM_Id.FormattingEnabled = True
        Me.comM_Id.Location = New System.Drawing.Point(151, 272)
        Me.comM_Id.Name = "comM_Id"
        Me.comM_Id.Size = New System.Drawing.Size(308, 33)
        Me.comM_Id.TabIndex = 66
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label9.Location = New System.Drawing.Point(12, 393)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 25)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Level"
        '
        'txtP_FirstName
        '
        Me.txtP_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP_FirstName.Location = New System.Drawing.Point(145, 173)
        Me.txtP_FirstName.Name = "txtP_FirstName"
        Me.txtP_FirstName.Size = New System.Drawing.Size(311, 30)
        Me.txtP_FirstName.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(12, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 25)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Last Name"
        '
        'txtP_LastName
        '
        Me.txtP_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP_LastName.Location = New System.Drawing.Point(151, 220)
        Me.txtP_LastName.Name = "txtP_LastName"
        Me.txtP_LastName.Size = New System.Drawing.Size(308, 30)
        Me.txtP_LastName.TabIndex = 62
        '
        'txtP_Id
        '
        Me.txtP_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP_Id.Location = New System.Drawing.Point(72, 124)
        Me.txtP_Id.Name = "txtP_Id"
        Me.txtP_Id.Size = New System.Drawing.Size(233, 30)
        Me.txtP_Id.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(12, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 25)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(12, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 25)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Num"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(12, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 25)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Member Id"
        '
        'DuesDGV
        '
        Me.DuesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DuesDGV.Location = New System.Drawing.Point(542, 168)
        Me.DuesDGV.Name = "DuesDGV"
        Me.DuesDGV.RowHeadersWidth = 51
        Me.DuesDGV.RowTemplate.Height = 24
        Me.DuesDGV.Size = New System.Drawing.Size(672, 471)
        Me.DuesDGV.TabIndex = 72
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(947, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(218, 38)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Payment List"
        '
        'txtSearchM_G
        '
        Me.txtSearchM_G.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchM_G.Location = New System.Drawing.Point(695, 112)
        Me.txtSearchM_G.Name = "txtSearchM_G"
        Me.txtSearchM_G.Size = New System.Drawing.Size(233, 38)
        Me.txtSearchM_G.TabIndex = 74
        '
        'btnM_Search
        '
        Me.btnM_Search.BackColor = System.Drawing.Color.Gold
        Me.btnM_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnM_Search.Location = New System.Drawing.Point(541, 111)
        Me.btnM_Search.Name = "btnM_Search"
        Me.btnM_Search.Size = New System.Drawing.Size(124, 40)
        Me.btnM_Search.TabIndex = 73
        Me.btnM_Search.Text = "Search"
        Me.btnM_Search.UseVisualStyleBackColor = False
        '
        'btnP_Home
        '
        Me.btnP_Home.BackColor = System.Drawing.Color.Red
        Me.btnP_Home.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnP_Home.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnP_Home.Location = New System.Drawing.Point(137, 588)
        Me.btnP_Home.Name = "btnP_Home"
        Me.btnP_Home.Size = New System.Drawing.Size(259, 51)
        Me.btnP_Home.TabIndex = 78
        Me.btnP_Home.Text = "Home"
        Me.btnP_Home.UseVisualStyleBackColor = False
        '
        'btnP_Delete
        '
        Me.btnP_Delete.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnP_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnP_Delete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnP_Delete.Location = New System.Drawing.Point(382, 486)
        Me.btnP_Delete.Name = "btnP_Delete"
        Me.btnP_Delete.Size = New System.Drawing.Size(136, 86)
        Me.btnP_Delete.TabIndex = 77
        Me.btnP_Delete.Text = "Delete"
        Me.btnP_Delete.UseVisualStyleBackColor = False
        '
        'btnP_Edit
        '
        Me.btnP_Edit.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnP_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnP_Edit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnP_Edit.Location = New System.Drawing.Point(196, 486)
        Me.btnP_Edit.Name = "btnP_Edit"
        Me.btnP_Edit.Size = New System.Drawing.Size(141, 86)
        Me.btnP_Edit.TabIndex = 76
        Me.btnP_Edit.Text = "Edit"
        Me.btnP_Edit.UseVisualStyleBackColor = False
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnPay.Location = New System.Drawing.Point(17, 486)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(142, 86)
        Me.btnPay.TabIndex = 75
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'DuesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 651)
        Me.Controls.Add(Me.btnP_Home)
        Me.Controls.Add(Me.btnP_Delete)
        Me.Controls.Add(Me.btnP_Edit)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.txtSearchM_G)
        Me.Controls.Add(Me.btnM_Search)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DuesDGV)
        Me.Controls.Add(Me.ComP_Level)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpPeriod)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.comM_Id)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtP_FirstName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtP_LastName)
        Me.Controls.Add(Me.txtP_Id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DuesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DuesForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DuesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComP_Level As ComboBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpPeriod As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents comM_Id As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtP_FirstName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtP_LastName As TextBox
    Friend WithEvents txtP_Id As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DuesDGV As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSearchM_G As TextBox
    Friend WithEvents btnM_Search As Button
    Friend WithEvents btnP_Home As Button
    Friend WithEvents btnP_Delete As Button
    Friend WithEvents btnP_Edit As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
