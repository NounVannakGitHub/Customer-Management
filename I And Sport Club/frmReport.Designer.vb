<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnShowMemberReport = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.crptMemberReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.crptIncomeReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShowIncomeReport = New System.Windows.Forms.Button()
        Me.dtpIncomeDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpIncomeDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.crptGymReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGymReport = New System.Windows.Forms.Button()
        Me.dtpGymReportDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpGymReportDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.crptBallReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBallReport = New System.Windows.Forms.Button()
        Me.dtpBallReportTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpBallReportFrom = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1007, 583)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnShowMemberReport)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(999, 546)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "របាយការណ៍សមាជិក"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnShowMemberReport
        '
        Me.btnShowMemberReport.Location = New System.Drawing.Point(14, 18)
        Me.btnShowMemberReport.Name = "btnShowMemberReport"
        Me.btnShowMemberReport.Size = New System.Drawing.Size(157, 37)
        Me.btnShowMemberReport.TabIndex = 1
        Me.btnShowMemberReport.Text = "បង្ហាញរបាយការណ៍"
        Me.btnShowMemberReport.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.crptMemberReport)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(982, 486)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'crptMemberReport
        '
        Me.crptMemberReport.ActiveViewIndex = -1
        Me.crptMemberReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crptMemberReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.crptMemberReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crptMemberReport.Location = New System.Drawing.Point(3, 28)
        Me.crptMemberReport.Name = "crptMemberReport"
        Me.crptMemberReport.Size = New System.Drawing.Size(976, 455)
        Me.crptMemberReport.TabIndex = 0
        Me.crptMemberReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(999, 546)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "របាយការណ៍ចំណូលសមាជិកក្លឹប"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.crptIncomeReport)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 94)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(982, 443)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'crptIncomeReport
        '
        Me.crptIncomeReport.ActiveViewIndex = -1
        Me.crptIncomeReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crptIncomeReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.crptIncomeReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crptIncomeReport.Location = New System.Drawing.Point(3, 28)
        Me.crptIncomeReport.Name = "crptIncomeReport"
        Me.crptIncomeReport.Size = New System.Drawing.Size(976, 412)
        Me.crptIncomeReport.TabIndex = 0
        Me.crptIncomeReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnShowIncomeReport)
        Me.GroupBox2.Controls.Add(Me.dtpIncomeDateTo)
        Me.GroupBox2.Controls.Add(Me.dtpIncomeDateFrom)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(984, 82)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ដល់ថ្ងៃទី"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ចំណូលពីថ្ងៃទី"
        '
        'btnShowIncomeReport
        '
        Me.btnShowIncomeReport.Location = New System.Drawing.Point(580, 31)
        Me.btnShowIncomeReport.Name = "btnShowIncomeReport"
        Me.btnShowIncomeReport.Size = New System.Drawing.Size(168, 32)
        Me.btnShowIncomeReport.TabIndex = 3
        Me.btnShowIncomeReport.Text = "បង្ហាញរបាយការណ៍ចំណូល"
        Me.btnShowIncomeReport.UseVisualStyleBackColor = True
        '
        'dtpIncomeDateTo
        '
        Me.dtpIncomeDateTo.CustomFormat = ""
        Me.dtpIncomeDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIncomeDateTo.Location = New System.Drawing.Point(359, 31)
        Me.dtpIncomeDateTo.Name = "dtpIncomeDateTo"
        Me.dtpIncomeDateTo.Size = New System.Drawing.Size(200, 32)
        Me.dtpIncomeDateTo.TabIndex = 2
        '
        'dtpIncomeDateFrom
        '
        Me.dtpIncomeDateFrom.CustomFormat = ""
        Me.dtpIncomeDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIncomeDateFrom.Location = New System.Drawing.Point(93, 31)
        Me.dtpIncomeDateFrom.Name = "dtpIncomeDateFrom"
        Me.dtpIncomeDateFrom.Size = New System.Drawing.Size(200, 32)
        Me.dtpIncomeDateFrom.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(999, 546)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "របាយការណ៍ចំណូលរបស់កន្លែងហាត់ប្រាណ"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.crptGymReport)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 96)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(982, 443)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'crptGymReport
        '
        Me.crptGymReport.ActiveViewIndex = -1
        Me.crptGymReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crptGymReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.crptGymReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crptGymReport.Location = New System.Drawing.Point(3, 28)
        Me.crptGymReport.Name = "crptGymReport"
        Me.crptGymReport.Size = New System.Drawing.Size(976, 412)
        Me.crptGymReport.TabIndex = 0
        Me.crptGymReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.btnGymReport)
        Me.GroupBox5.Controls.Add(Me.dtpGymReportDateTo)
        Me.GroupBox5.Controls.Add(Me.dtpGymReportDateFrom)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(984, 82)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(299, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ដល់ថ្ងៃទី"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ចំណូលពីថ្ងៃទី"
        '
        'btnGymReport
        '
        Me.btnGymReport.Location = New System.Drawing.Point(580, 31)
        Me.btnGymReport.Name = "btnGymReport"
        Me.btnGymReport.Size = New System.Drawing.Size(168, 32)
        Me.btnGymReport.TabIndex = 3
        Me.btnGymReport.Text = "បង្ហាញរបាយការណ៍ចំណូល"
        Me.btnGymReport.UseVisualStyleBackColor = True
        '
        'dtpGymReportDateTo
        '
        Me.dtpGymReportDateTo.CustomFormat = ""
        Me.dtpGymReportDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpGymReportDateTo.Location = New System.Drawing.Point(359, 31)
        Me.dtpGymReportDateTo.Name = "dtpGymReportDateTo"
        Me.dtpGymReportDateTo.Size = New System.Drawing.Size(200, 32)
        Me.dtpGymReportDateTo.TabIndex = 2
        '
        'dtpGymReportDateFrom
        '
        Me.dtpGymReportDateFrom.CustomFormat = ""
        Me.dtpGymReportDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpGymReportDateFrom.Location = New System.Drawing.Point(93, 31)
        Me.dtpGymReportDateFrom.Name = "dtpGymReportDateFrom"
        Me.dtpGymReportDateFrom.Size = New System.Drawing.Size(200, 32)
        Me.dtpGymReportDateFrom.TabIndex = 2
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox6)
        Me.TabPage4.Controls.Add(Me.GroupBox7)
        Me.TabPage4.Location = New System.Drawing.Point(4, 33)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(999, 546)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "របាយការណ៍ចំណូលរបស់តារាងបាល់ទាត់"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.crptBallReport)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 96)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(982, 443)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        '
        'crptBallReport
        '
        Me.crptBallReport.ActiveViewIndex = -1
        Me.crptBallReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crptBallReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.crptBallReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crptBallReport.Location = New System.Drawing.Point(3, 28)
        Me.crptBallReport.Name = "crptBallReport"
        Me.crptBallReport.Size = New System.Drawing.Size(976, 412)
        Me.crptBallReport.TabIndex = 0
        Me.crptBallReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.btnBallReport)
        Me.GroupBox7.Controls.Add(Me.dtpBallReportTo)
        Me.GroupBox7.Controls.Add(Me.dtpBallReportFrom)
        Me.GroupBox7.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(984, 82)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(299, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ដល់ថ្ងៃទី"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "ចំណូលពីថ្ងៃទី"
        '
        'btnBallReport
        '
        Me.btnBallReport.Location = New System.Drawing.Point(580, 31)
        Me.btnBallReport.Name = "btnBallReport"
        Me.btnBallReport.Size = New System.Drawing.Size(168, 32)
        Me.btnBallReport.TabIndex = 3
        Me.btnBallReport.Text = "បង្ហាញរបាយការណ៍ចំណូល"
        Me.btnBallReport.UseVisualStyleBackColor = True
        '
        'dtpBallReportTo
        '
        Me.dtpBallReportTo.CustomFormat = ""
        Me.dtpBallReportTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBallReportTo.Location = New System.Drawing.Point(359, 31)
        Me.dtpBallReportTo.Name = "dtpBallReportTo"
        Me.dtpBallReportTo.Size = New System.Drawing.Size(200, 32)
        Me.dtpBallReportTo.TabIndex = 2
        '
        'dtpBallReportFrom
        '
        Me.dtpBallReportFrom.CustomFormat = ""
        Me.dtpBallReportFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBallReportFrom.Location = New System.Drawing.Point(93, 31)
        Me.dtpBallReportFrom.Name = "dtpBallReportFrom"
        Me.dtpBallReportFrom.Size = New System.Drawing.Size(200, 32)
        Me.dtpBallReportFrom.TabIndex = 2
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 582)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Khmer OS Content", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnShowMemberReport As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents crptIncomeReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShowIncomeReport As System.Windows.Forms.Button
    Friend WithEvents dtpIncomeDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpIncomeDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents crptGymReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGymReport As System.Windows.Forms.Button
    Friend WithEvents dtpGymReportDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpGymReportDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents crptBallReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnBallReport As System.Windows.Forms.Button
    Friend WithEvents dtpBallReportTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpBallReportFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents crptMemberReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
