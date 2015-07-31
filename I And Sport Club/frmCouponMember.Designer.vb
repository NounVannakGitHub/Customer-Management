<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCouponMember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCouponMember))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdGym = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtId = New System.Windows.Forms.ComboBox()
        Me.dtpTimeCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.dtpTimeCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.dtpDateCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtTimePrice = New System.Windows.Forms.TextBox()
        Me.txtTotalTime = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grdFootball = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBallId = New System.Windows.Forms.ComboBox()
        Me.dtpBallTimeCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.dtpBallTimeCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.cboFieldType = New System.Windows.Forms.ComboBox()
        Me.btnBallDelete = New System.Windows.Forms.Button()
        Me.btnBallUpdate = New System.Windows.Forms.Button()
        Me.btnBallNew = New System.Windows.Forms.Button()
        Me.btnBallInsert = New System.Windows.Forms.Button()
        Me.dtpBallDateIn = New System.Windows.Forms.DateTimePicker()
        Me.txtBallAmount = New System.Windows.Forms.TextBox()
        Me.txtBallTimePrice = New System.Windows.Forms.TextBox()
        Me.txtBallTotalTime = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdGym, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdFootball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1008, 585)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TabPage1.Size = New System.Drawing.Size(1000, 548)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ក្លឹបហាត់ប្រាណ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(28, 213)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(403, 24)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "*សំគាល់ៈ លេខប័ណ្ណមិនតំរូវឲ្យបញ្ចូលឡើយវាប្រើសំរាប់ស្វែងរកទិន្នន័យប៉ុណ្ណោះ"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdGym)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 223)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(982, 315)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'grdGym
        '
        Me.grdGym.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGym.Location = New System.Drawing.Point(5, 18)
        Me.grdGym.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdGym.Name = "grdGym"
        Me.grdGym.Size = New System.Drawing.Size(971, 289)
        Me.grdGym.TabIndex = 0
        Me.grdGym.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.dtpTimeCheckOut)
        Me.GroupBox1.Controls.Add(Me.dtpTimeCheckIn)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.btnInsert)
        Me.GroupBox1.Controls.Add(Me.dtpDateCheckIn)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.txtTimePrice)
        Me.GroupBox1.Controls.Add(Me.txtTotalTime)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(981, 203)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ទិន្នន័យកន្លែងហាត់ប្រាណ"
        '
        'txtId
        '
        Me.txtId.DropDownHeight = 50
        Me.txtId.FormattingEnabled = True
        Me.txtId.IntegralHeight = False
        Me.txtId.Location = New System.Drawing.Point(466, 18)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(285, 32)
        Me.txtId.TabIndex = 10
        '
        'dtpTimeCheckOut
        '
        Me.dtpTimeCheckOut.CustomFormat = ""
        Me.dtpTimeCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTimeCheckOut.Location = New System.Drawing.Point(110, 145)
        Me.dtpTimeCheckOut.Name = "dtpTimeCheckOut"
        Me.dtpTimeCheckOut.Size = New System.Drawing.Size(258, 32)
        Me.dtpTimeCheckOut.TabIndex = 9
        '
        'dtpTimeCheckIn
        '
        Me.dtpTimeCheckIn.CustomFormat = ""
        Me.dtpTimeCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTimeCheckIn.Location = New System.Drawing.Point(110, 102)
        Me.dtpTimeCheckIn.Name = "dtpTimeCheckIn"
        Me.dtpTimeCheckIn.Size = New System.Drawing.Size(258, 32)
        Me.dtpTimeCheckIn.TabIndex = 9
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.I_And_Sport_Club.My.Resources.Resources.garbage4
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(782, 151)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(125, 42)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "លុប"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = Global.I_And_Sport_Club.My.Resources.Resources.edit26
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(782, 108)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(125, 42)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.TabStop = False
        Me.btnUpdate.Text = "កែប្រែ"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Image = Global.I_And_Sport_Club.My.Resources.Resources.text70
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(782, 21)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(125, 44)
        Me.btnNew.TabIndex = 3
        Me.btnNew.TabStop = False
        Me.btnNew.Text = "បញ្ចូលថ្មី"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Image = Global.I_And_Sport_Club.My.Resources.Resources.floppy13
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.Location = New System.Drawing.Point(782, 66)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(125, 42)
        Me.btnInsert.TabIndex = 3
        Me.btnInsert.TabStop = False
        Me.btnInsert.Text = "រក្សាទុក"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'dtpDateCheckIn
        '
        Me.dtpDateCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateCheckIn.Location = New System.Drawing.Point(110, 58)
        Me.dtpDateCheckIn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.dtpDateCheckIn.Name = "dtpDateCheckIn"
        Me.dtpDateCheckIn.Size = New System.Drawing.Size(258, 32)
        Me.dtpDateCheckIn.TabIndex = 1
        '
        'txtAmount
        '
        Me.txtAmount.Enabled = False
        Me.txtAmount.Location = New System.Drawing.Point(466, 145)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(285, 32)
        Me.txtAmount.TabIndex = 1
        Me.txtAmount.TabStop = False
        Me.txtAmount.Text = "0"
        '
        'txtTimePrice
        '
        Me.txtTimePrice.Enabled = False
        Me.txtTimePrice.Location = New System.Drawing.Point(466, 102)
        Me.txtTimePrice.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtTimePrice.Name = "txtTimePrice"
        Me.txtTimePrice.Size = New System.Drawing.Size(285, 32)
        Me.txtTimePrice.TabIndex = 4
        Me.txtTimePrice.Text = "0.25"
        '
        'txtTotalTime
        '
        Me.txtTotalTime.Enabled = False
        Me.txtTotalTime.Location = New System.Drawing.Point(466, 59)
        Me.txtTotalTime.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtTotalTime.Name = "txtTotalTime"
        Me.txtTotalTime.Size = New System.Drawing.Size(285, 32)
        Me.txtTotalTime.TabIndex = 1
        Me.txtTotalTime.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(376, 146)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "សរុបតំលៃ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(376, 109)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "តំលៃក្នុង១ម៉ោង"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(376, 21)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 24)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "លេខប័ណ្ណ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(376, 64)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ម៉ោងសរុប"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ម៉ោងចេញ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ម៉ោងចូល"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ថ្ងៃចូល"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TabPage2.Size = New System.Drawing.Size(1000, 548)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "តារាងបាល់ទាត់"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdFootball)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 268)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(986, 270)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'grdFootball
        '
        Me.grdFootball.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFootball.Location = New System.Drawing.Point(5, 19)
        Me.grdFootball.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdFootball.Name = "grdFootball"
        Me.grdFootball.Size = New System.Drawing.Size(975, 243)
        Me.grdFootball.TabIndex = 0
        Me.grdFootball.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtBallId)
        Me.GroupBox4.Controls.Add(Me.dtpBallTimeCheckOut)
        Me.GroupBox4.Controls.Add(Me.dtpBallTimeCheckIn)
        Me.GroupBox4.Controls.Add(Me.cboFieldType)
        Me.GroupBox4.Controls.Add(Me.btnBallDelete)
        Me.GroupBox4.Controls.Add(Me.btnBallUpdate)
        Me.GroupBox4.Controls.Add(Me.btnBallNew)
        Me.GroupBox4.Controls.Add(Me.btnBallInsert)
        Me.GroupBox4.Controls.Add(Me.dtpBallDateIn)
        Me.GroupBox4.Controls.Add(Me.txtBallAmount)
        Me.GroupBox4.Controls.Add(Me.txtBallTimePrice)
        Me.GroupBox4.Controls.Add(Me.txtBallTotalTime)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox4.Size = New System.Drawing.Size(980, 248)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ទិន្នន័យកតារាងបាល់ទាត់"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(20, 220)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(403, 24)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "*សំគាល់ៈ លេខប័ណ្ណមិនតំរូវឲ្យបញ្ចូលឡើយវាប្រើសំរាប់ស្វែងរកទិន្នន័យប៉ុណ្ណោះ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(378, 188)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 24)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "លេខប័ណ្ណ"
        '
        'txtBallId
        '
        Me.txtBallId.DropDownHeight = 50
        Me.txtBallId.FormattingEnabled = True
        Me.txtBallId.IntegralHeight = False
        Me.txtBallId.Location = New System.Drawing.Point(468, 185)
        Me.txtBallId.Name = "txtBallId"
        Me.txtBallId.Size = New System.Drawing.Size(261, 32)
        Me.txtBallId.TabIndex = 9
        Me.txtBallId.TabStop = False
        '
        'dtpBallTimeCheckOut
        '
        Me.dtpBallTimeCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpBallTimeCheckOut.Location = New System.Drawing.Point(110, 185)
        Me.dtpBallTimeCheckOut.Name = "dtpBallTimeCheckOut"
        Me.dtpBallTimeCheckOut.Size = New System.Drawing.Size(260, 32)
        Me.dtpBallTimeCheckOut.TabIndex = 8
        '
        'dtpBallTimeCheckIn
        '
        Me.dtpBallTimeCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpBallTimeCheckIn.Location = New System.Drawing.Point(110, 143)
        Me.dtpBallTimeCheckIn.Name = "dtpBallTimeCheckIn"
        Me.dtpBallTimeCheckIn.Size = New System.Drawing.Size(260, 32)
        Me.dtpBallTimeCheckIn.TabIndex = 8
        '
        'cboFieldType
        '
        Me.cboFieldType.DropDownHeight = 50
        Me.cboFieldType.FormattingEnabled = True
        Me.cboFieldType.IntegralHeight = False
        Me.cboFieldType.Items.AddRange(New Object() {"តូច", "ធំ"})
        Me.cboFieldType.Location = New System.Drawing.Point(110, 98)
        Me.cboFieldType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboFieldType.Name = "cboFieldType"
        Me.cboFieldType.Size = New System.Drawing.Size(260, 32)
        Me.cboFieldType.TabIndex = 2
        '
        'btnBallDelete
        '
        Me.btnBallDelete.Image = Global.I_And_Sport_Club.My.Resources.Resources.garbage4
        Me.btnBallDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBallDelete.Location = New System.Drawing.Point(758, 176)
        Me.btnBallDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBallDelete.Name = "btnBallDelete"
        Me.btnBallDelete.Size = New System.Drawing.Size(132, 42)
        Me.btnBallDelete.TabIndex = 3
        Me.btnBallDelete.TabStop = False
        Me.btnBallDelete.Text = "លុប"
        Me.btnBallDelete.UseVisualStyleBackColor = True
        '
        'btnBallUpdate
        '
        Me.btnBallUpdate.Image = Global.I_And_Sport_Club.My.Resources.Resources.edit26
        Me.btnBallUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBallUpdate.Location = New System.Drawing.Point(758, 133)
        Me.btnBallUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBallUpdate.Name = "btnBallUpdate"
        Me.btnBallUpdate.Size = New System.Drawing.Size(132, 42)
        Me.btnBallUpdate.TabIndex = 3
        Me.btnBallUpdate.TabStop = False
        Me.btnBallUpdate.Text = "កែប្រែ"
        Me.btnBallUpdate.UseVisualStyleBackColor = True
        '
        'btnBallNew
        '
        Me.btnBallNew.Image = Global.I_And_Sport_Club.My.Resources.Resources.text70
        Me.btnBallNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBallNew.Location = New System.Drawing.Point(758, 47)
        Me.btnBallNew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBallNew.Name = "btnBallNew"
        Me.btnBallNew.Size = New System.Drawing.Size(132, 42)
        Me.btnBallNew.TabIndex = 3
        Me.btnBallNew.TabStop = False
        Me.btnBallNew.Text = "បញ្ចូលថ្មី"
        Me.btnBallNew.UseVisualStyleBackColor = True
        '
        'btnBallInsert
        '
        Me.btnBallInsert.Image = Global.I_And_Sport_Club.My.Resources.Resources.floppy13
        Me.btnBallInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBallInsert.Location = New System.Drawing.Point(758, 90)
        Me.btnBallInsert.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBallInsert.Name = "btnBallInsert"
        Me.btnBallInsert.Size = New System.Drawing.Size(132, 42)
        Me.btnBallInsert.TabIndex = 3
        Me.btnBallInsert.TabStop = False
        Me.btnBallInsert.Text = "រក្សាទុក"
        Me.btnBallInsert.UseVisualStyleBackColor = True
        '
        'dtpBallDateIn
        '
        Me.dtpBallDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBallDateIn.Location = New System.Drawing.Point(110, 58)
        Me.dtpBallDateIn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.dtpBallDateIn.Name = "dtpBallDateIn"
        Me.dtpBallDateIn.Size = New System.Drawing.Size(260, 32)
        Me.dtpBallDateIn.TabIndex = 1
        '
        'txtBallAmount
        '
        Me.txtBallAmount.Enabled = False
        Me.txtBallAmount.Location = New System.Drawing.Point(468, 143)
        Me.txtBallAmount.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtBallAmount.Name = "txtBallAmount"
        Me.txtBallAmount.Size = New System.Drawing.Size(261, 32)
        Me.txtBallAmount.TabIndex = 1
        Me.txtBallAmount.TabStop = False
        Me.txtBallAmount.Text = "0"
        '
        'txtBallTimePrice
        '
        Me.txtBallTimePrice.Enabled = False
        Me.txtBallTimePrice.Location = New System.Drawing.Point(468, 100)
        Me.txtBallTimePrice.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtBallTimePrice.Name = "txtBallTimePrice"
        Me.txtBallTimePrice.Size = New System.Drawing.Size(261, 32)
        Me.txtBallTimePrice.TabIndex = 1
        Me.txtBallTimePrice.TabStop = False
        Me.txtBallTimePrice.Text = "0"
        '
        'txtBallTotalTime
        '
        Me.txtBallTotalTime.Enabled = False
        Me.txtBallTotalTime.Location = New System.Drawing.Point(468, 57)
        Me.txtBallTotalTime.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtBallTotalTime.Name = "txtBallTotalTime"
        Me.txtBallTotalTime.Size = New System.Drawing.Size(261, 32)
        Me.txtBallTotalTime.TabIndex = 1
        Me.txtBallTotalTime.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(378, 146)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "សរុបតំលៃ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(378, 105)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "តំលៃក្នុង១ម៉ោង"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(378, 63)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ម៉ោងសរុប"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 193)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "ម៉ោងចេញ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 144)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 24)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ម៉ោងចូល"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 104)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 24)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "ទំហំតារាង"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 58)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 24)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "ថ្ងៃចូល"
        '
        'frmCouponMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 582)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Khmer OS Content", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmCouponMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coupon Member Control"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdGym, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdFootball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grdGym As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents dtpDateCheckIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtTimePrice As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalTime As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grdFootball As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboFieldType As System.Windows.Forms.ComboBox
    Friend WithEvents btnBallDelete As System.Windows.Forms.Button
    Friend WithEvents btnBallUpdate As System.Windows.Forms.Button
    Friend WithEvents btnBallInsert As System.Windows.Forms.Button
    Friend WithEvents dtpBallDateIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBallAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtBallTimePrice As System.Windows.Forms.TextBox
    Friend WithEvents txtBallTotalTime As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnBallNew As System.Windows.Forms.Button
    Friend WithEvents dtpBallTimeCheckOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpBallTimeCheckIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTimeCheckOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTimeCheckIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtId As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtBallId As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
