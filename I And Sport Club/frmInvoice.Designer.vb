<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoice))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.InvGym = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.crptGymInv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGymShowInv = New System.Windows.Forms.Button()
        Me.dtpGymInv = New System.Windows.Forms.DateTimePicker()
        Me.InvFootBall = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.crptBallInv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnBallShowInv = New System.Windows.Forms.Button()
        Me.dtpBallInv = New System.Windows.Forms.DateTimePicker()
        Me.InvMember = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.crptMemInv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtMemIdInv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMemShowInv = New System.Windows.Forms.Button()
        Me.dtpDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.dptDateStart = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1.SuspendLayout()
        Me.InvGym.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.InvFootBall.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.InvMember.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.InvGym)
        Me.TabControl1.Controls.Add(Me.InvFootBall)
        Me.TabControl1.Controls.Add(Me.InvMember)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1004, 580)
        Me.TabControl1.TabIndex = 0
        '
        'InvGym
        '
        Me.InvGym.Controls.Add(Me.GroupBox2)
        Me.InvGym.Controls.Add(Me.GroupBox1)
        Me.InvGym.Location = New System.Drawing.Point(4, 33)
        Me.InvGym.Name = "InvGym"
        Me.InvGym.Padding = New System.Windows.Forms.Padding(3)
        Me.InvGym.Size = New System.Drawing.Size(996, 543)
        Me.InvGym.TabIndex = 0
        Me.InvGym.Text = "វិក័យប័ត្រប្រចាំថ្ងៃរបស់កន្លែងហាត់ប្រាណ"
        Me.InvGym.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.crptGymInv)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(982, 425)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'crptGymInv
        '
        Me.crptGymInv.ActiveViewIndex = -1
        Me.crptGymInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crptGymInv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crptGymInv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crptGymInv.Location = New System.Drawing.Point(3, 28)
        Me.crptGymInv.Name = "crptGymInv"
        Me.crptGymInv.Size = New System.Drawing.Size(976, 394)
        Me.crptGymInv.TabIndex = 0
        Me.crptGymInv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGymShowInv)
        Me.GroupBox1.Controls.Add(Me.dtpGymInv)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(982, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnGymShowInv
        '
        Me.btnGymShowInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGymShowInv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGymShowInv.Location = New System.Drawing.Point(304, 42)
        Me.btnGymShowInv.Name = "btnGymShowInv"
        Me.btnGymShowInv.Size = New System.Drawing.Size(144, 32)
        Me.btnGymShowInv.TabIndex = 1
        Me.btnGymShowInv.Text = "បង្ហាញវិក័យប័ត្រ"
        Me.btnGymShowInv.UseVisualStyleBackColor = True
        '
        'dtpGymInv
        '
        Me.dtpGymInv.CustomFormat = ""
        Me.dtpGymInv.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpGymInv.Location = New System.Drawing.Point(25, 42)
        Me.dtpGymInv.Name = "dtpGymInv"
        Me.dtpGymInv.Size = New System.Drawing.Size(259, 32)
        Me.dtpGymInv.TabIndex = 0
        '
        'InvFootBall
        '
        Me.InvFootBall.Controls.Add(Me.GroupBox3)
        Me.InvFootBall.Controls.Add(Me.GroupBox4)
        Me.InvFootBall.Location = New System.Drawing.Point(4, 33)
        Me.InvFootBall.Name = "InvFootBall"
        Me.InvFootBall.Padding = New System.Windows.Forms.Padding(3)
        Me.InvFootBall.Size = New System.Drawing.Size(996, 543)
        Me.InvFootBall.TabIndex = 1
        Me.InvFootBall.Text = "វិក័យប័ត្រប្រចាំថ្ងៃរបស់តារាងបាល់ទាត់"
        Me.InvFootBall.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.crptBallInv)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(982, 425)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'crptBallInv
        '
        Me.crptBallInv.ActiveViewIndex = -1
        Me.crptBallInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crptBallInv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crptBallInv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crptBallInv.Location = New System.Drawing.Point(3, 28)
        Me.crptBallInv.Name = "crptBallInv"
        Me.crptBallInv.Size = New System.Drawing.Size(976, 394)
        Me.crptBallInv.TabIndex = 0
        Me.crptBallInv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnBallShowInv)
        Me.GroupBox4.Controls.Add(Me.dtpBallInv)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(982, 100)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'btnBallShowInv
        '
        Me.btnBallShowInv.Location = New System.Drawing.Point(304, 42)
        Me.btnBallShowInv.Name = "btnBallShowInv"
        Me.btnBallShowInv.Size = New System.Drawing.Size(144, 32)
        Me.btnBallShowInv.TabIndex = 1
        Me.btnBallShowInv.Text = "បង្ហាញវិក័យប័ត្រ"
        Me.btnBallShowInv.UseVisualStyleBackColor = True
        '
        'dtpBallInv
        '
        Me.dtpBallInv.CustomFormat = ""
        Me.dtpBallInv.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBallInv.Location = New System.Drawing.Point(25, 42)
        Me.dtpBallInv.Name = "dtpBallInv"
        Me.dtpBallInv.Size = New System.Drawing.Size(259, 32)
        Me.dtpBallInv.TabIndex = 0
        '
        'InvMember
        '
        Me.InvMember.Controls.Add(Me.GroupBox5)
        Me.InvMember.Controls.Add(Me.GroupBox6)
        Me.InvMember.Location = New System.Drawing.Point(4, 33)
        Me.InvMember.Name = "InvMember"
        Me.InvMember.Padding = New System.Windows.Forms.Padding(3)
        Me.InvMember.Size = New System.Drawing.Size(996, 543)
        Me.InvMember.TabIndex = 2
        Me.InvMember.Text = "វិក័យប័ត្រប្រចាំខែរបស់សមាជិកអចិន្ត្រៃយ៍"
        Me.InvMember.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.crptMemInv)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 112)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(982, 425)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'crptMemInv
        '
        Me.crptMemInv.ActiveViewIndex = -1
        Me.crptMemInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crptMemInv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crptMemInv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crptMemInv.Location = New System.Drawing.Point(3, 28)
        Me.crptMemInv.Name = "crptMemInv"
        Me.crptMemInv.Size = New System.Drawing.Size(976, 394)
        Me.crptMemInv.TabIndex = 0
        Me.crptMemInv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtMemIdInv)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.btnMemShowInv)
        Me.GroupBox6.Controls.Add(Me.dtpDateEnd)
        Me.GroupBox6.Controls.Add(Me.dptDateStart)
        Me.GroupBox6.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(982, 100)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        '
        'txtMemIdInv
        '
        Me.txtMemIdInv.Location = New System.Drawing.Point(113, 42)
        Me.txtMemIdInv.Name = "txtMemIdInv"
        Me.txtMemIdInv.Size = New System.Drawing.Size(123, 32)
        Me.txtMemIdInv.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(535, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ដល់ថ្ងៃទី"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "លេខរៀងសមាជិក"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ចាប់ពីថ្ងៃទី"
        '
        'btnMemShowInv
        '
        Me.btnMemShowInv.Location = New System.Drawing.Point(817, 42)
        Me.btnMemShowInv.Name = "btnMemShowInv"
        Me.btnMemShowInv.Size = New System.Drawing.Size(144, 32)
        Me.btnMemShowInv.TabIndex = 1
        Me.btnMemShowInv.Text = "បង្ហាញវិក័យប័ត្រ"
        Me.btnMemShowInv.UseVisualStyleBackColor = True
        '
        'dtpDateEnd
        '
        Me.dtpDateEnd.CustomFormat = ""
        Me.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateEnd.Location = New System.Drawing.Point(595, 42)
        Me.dtpDateEnd.Name = "dtpDateEnd"
        Me.dtpDateEnd.Size = New System.Drawing.Size(216, 32)
        Me.dtpDateEnd.TabIndex = 0
        '
        'dptDateStart
        '
        Me.dptDateStart.CustomFormat = ""
        Me.dptDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptDateStart.Location = New System.Drawing.Point(311, 40)
        Me.dptDateStart.Name = "dptDateStart"
        Me.dptDateStart.Size = New System.Drawing.Size(218, 32)
        Me.dptDateStart.TabIndex = 0
        '
        'frmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 582)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Khmer OS Content", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.TabControl1.ResumeLayout(False)
        Me.InvGym.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.InvFootBall.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.InvMember.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents InvGym As System.Windows.Forms.TabPage
    Friend WithEvents InvFootBall As System.Windows.Forms.TabPage
    Friend WithEvents InvMember As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGymShowInv As System.Windows.Forms.Button
    Friend WithEvents dtpGymInv As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBallShowInv As System.Windows.Forms.Button
    Friend WithEvents dtpBallInv As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMemShowInv As System.Windows.Forms.Button
    Friend WithEvents dtpDateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dptDateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents crptGymInv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crptBallInv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crptMemInv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMemIdInv As System.Windows.Forms.TextBox
End Class
