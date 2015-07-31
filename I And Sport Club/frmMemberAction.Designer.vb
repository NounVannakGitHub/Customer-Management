<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberAction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMemberAction))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.ComboBox()
        Me.txtMemId = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpMemTimeCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.dtpMemTimeCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPriceTime = New System.Windows.Forms.TextBox()
        Me.txtTotalTime = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalPerDay = New System.Windows.Forms.TextBox()
        Me.dtpMemDateCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grdMemberAction = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdMemberAction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtMemId)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.btnInsert)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTotalPerDay)
        Me.GroupBox1.Controls.Add(Me.dtpMemDateCheckIn)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(978, 251)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ចុះឈ្មោះចូលហាត់ប្រាណ"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(34, 215)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(403, 24)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "*សំគាល់ៈ លេខប័ណ្ណមិនតំរូវឲ្យបញ្ចូលឡើយវាប្រើសំរាប់ស្វែងរកទិន្នន័យប៉ុណ្ណោះ"
        '
        'txtID
        '
        Me.txtID.DropDownHeight = 50
        Me.txtID.FormattingEnabled = True
        Me.txtID.IntegralHeight = False
        Me.txtID.Location = New System.Drawing.Point(118, 176)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(186, 32)
        Me.txtID.TabIndex = 8
        Me.txtID.TabStop = False
        '
        'txtMemId
        '
        Me.txtMemId.Location = New System.Drawing.Point(118, 48)
        Me.txtMemId.Name = "txtMemId"
        Me.txtMemId.Size = New System.Drawing.Size(186, 32)
        Me.txtMemId.TabIndex = 7
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.I_And_Sport_Club.My.Resources.Resources.garbage4
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(817, 189)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(127, 45)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "លុប"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = Global.I_And_Sport_Club.My.Resources.Resources.edit26
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(817, 131)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(127, 45)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.TabStop = False
        Me.btnUpdate.Text = "កែប្រែ"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Image = Global.I_And_Sport_Club.My.Resources.Resources.text70
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(817, 23)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(127, 45)
        Me.btnNew.TabIndex = 6
        Me.btnNew.TabStop = False
        Me.btnNew.Text = "បញ្ចូលថ្មី"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Image = Global.I_And_Sport_Club.My.Resources.Resources.floppy13
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.Location = New System.Drawing.Point(817, 76)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(127, 45)
        Me.btnInsert.TabIndex = 6
        Me.btnInsert.TabStop = False
        Me.btnInsert.Text = "រក្សាទុក"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpMemTimeCheckOut)
        Me.GroupBox2.Controls.Add(Me.dtpMemTimeCheckIn)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtPriceTime)
        Me.GroupBox2.Controls.Add(Me.txtTotalTime)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(323, 19)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(460, 220)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "កំណត់ម៉ោង"
        '
        'dtpMemTimeCheckOut
        '
        Me.dtpMemTimeCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpMemTimeCheckOut.Location = New System.Drawing.Point(133, 72)
        Me.dtpMemTimeCheckOut.Name = "dtpMemTimeCheckOut"
        Me.dtpMemTimeCheckOut.Size = New System.Drawing.Size(307, 32)
        Me.dtpMemTimeCheckOut.TabIndex = 9
        '
        'dtpMemTimeCheckIn
        '
        Me.dtpMemTimeCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpMemTimeCheckIn.Location = New System.Drawing.Point(133, 29)
        Me.dtpMemTimeCheckIn.Name = "dtpMemTimeCheckIn"
        Me.dtpMemTimeCheckIn.Size = New System.Drawing.Size(307, 32)
        Me.dtpMemTimeCheckIn.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 160)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "តំលៃក្នុង១ម៉ោង"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 120)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ម៉ោងសរុប"
        '
        'txtPriceTime
        '
        Me.txtPriceTime.Enabled = False
        Me.txtPriceTime.Location = New System.Drawing.Point(133, 155)
        Me.txtPriceTime.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtPriceTime.Name = "txtPriceTime"
        Me.txtPriceTime.Size = New System.Drawing.Size(307, 32)
        Me.txtPriceTime.TabIndex = 5
        Me.txtPriceTime.Text = "0.25"
        '
        'txtTotalTime
        '
        Me.txtTotalTime.Enabled = False
        Me.txtTotalTime.Location = New System.Drawing.Point(133, 116)
        Me.txtTotalTime.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtTotalTime.Name = "txtTotalTime"
        Me.txtTotalTime.Size = New System.Drawing.Size(307, 32)
        Me.txtTotalTime.TabIndex = 8
        Me.txtTotalTime.TabStop = False
        Me.txtTotalTime.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 83)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 24)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "ម៉ោងចេញ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 43)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "ម៉ោងចូល"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 179)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "លេខប័ណ្ណ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "សរុបប្រចាំថ្ងៃ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ថ្ងៃចូលហាត់"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "លេខរៀង"
        '
        'txtTotalPerDay
        '
        Me.txtTotalPerDay.Enabled = False
        Me.txtTotalPerDay.Location = New System.Drawing.Point(118, 134)
        Me.txtTotalPerDay.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtTotalPerDay.Name = "txtTotalPerDay"
        Me.txtTotalPerDay.Size = New System.Drawing.Size(186, 32)
        Me.txtTotalPerDay.TabIndex = 2
        Me.txtTotalPerDay.TabStop = False
        '
        'dtpMemDateCheckIn
        '
        Me.dtpMemDateCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMemDateCheckIn.Location = New System.Drawing.Point(118, 91)
        Me.dtpMemDateCheckIn.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.dtpMemDateCheckIn.Name = "dtpMemDateCheckIn"
        Me.dtpMemDateCheckIn.Size = New System.Drawing.Size(186, 32)
        Me.dtpMemDateCheckIn.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdMemberAction)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 272)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(978, 297)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'grdMemberAction
        '
        Me.grdMemberAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMemberAction.Location = New System.Drawing.Point(6, 18)
        Me.grdMemberAction.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.grdMemberAction.Name = "grdMemberAction"
        Me.grdMemberAction.Size = New System.Drawing.Size(968, 271)
        Me.grdMemberAction.TabIndex = 0
        Me.grdMemberAction.TabStop = False
        '
        'frmMemberAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1006, 582)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Khmer OS Content", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "frmMemberAction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Action"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdMemberAction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPerDay As System.Windows.Forms.TextBox
    Friend WithEvents dtpMemDateCheckIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPriceTime As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalTime As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grdMemberAction As System.Windows.Forms.DataGridView
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents dtpMemTimeCheckOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMemTimeCheckIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMemId As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
