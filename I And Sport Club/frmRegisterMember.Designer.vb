<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterMember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegisterMember))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMemId = New System.Windows.Forms.TextBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.dtpMem = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboMemId = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMemAddr = New System.Windows.Forms.TextBox()
        Me.txtMemTel = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdMember = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "លេខរៀង"
        '
        'txtMemId
        '
        Me.txtMemId.Location = New System.Drawing.Point(117, 32)
        Me.txtMemId.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtMemId.Name = "txtMemId"
        Me.txtMemId.Size = New System.Drawing.Size(131, 32)
        Me.txtMemId.TabIndex = 1
        '
        'cboGender
        '
        Me.cboGender.DropDownHeight = 50
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.IntegralHeight = False
        Me.cboGender.Items.AddRange(New Object() {"ប្រុស", "ស្រី"})
        Me.cboGender.Location = New System.Drawing.Point(117, 116)
        Me.cboGender.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(263, 32)
        Me.cboGender.TabIndex = 4
        '
        'dtpMem
        '
        Me.dtpMem.Location = New System.Drawing.Point(117, 206)
        Me.dtpMem.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpMem.Name = "dtpMem"
        Me.dtpMem.Size = New System.Drawing.Size(265, 32)
        Me.dtpMem.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboMemId)
        Me.GroupBox1.Controls.Add(Me.dtpMem)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMemAddr)
        Me.GroupBox1.Controls.Add(Me.txtMemTel)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.txtMemId)
        Me.GroupBox1.Controls.Add(Me.cboGender)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 20)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(978, 253)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ចុះឈ្មោះជាសមាជិក"
        '
        'cboMemId
        '
        Me.cboMemId.DropDownHeight = 50
        Me.cboMemId.FormattingEnabled = True
        Me.cboMemId.IntegralHeight = False
        Me.cboMemId.Location = New System.Drawing.Point(256, 32)
        Me.cboMemId.Name = "cboMemId"
        Me.cboMemId.Size = New System.Drawing.Size(124, 32)
        Me.cboMemId.TabIndex = 8
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.I_And_Sport_Club.My.Resources.Resources.garbage4
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(811, 191)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(129, 42)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "លុប"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = Global.I_And_Sport_Club.My.Resources.Resources.edit26
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(811, 137)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(129, 42)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.TabStop = False
        Me.btnUpdate.Text = "កែប្រែ"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Image = Global.I_And_Sport_Club.My.Resources.Resources.text70
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(811, 33)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(129, 42)
        Me.btnNew.TabIndex = 0
        Me.btnNew.TabStop = False
        Me.btnNew.Text = "បញ្ចូលថ្មី"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.I_And_Sport_Club.My.Resources.Resources.floppy13
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(811, 83)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(129, 42)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.TabStop = False
        Me.btnAdd.Text = "រក្សាទុក"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 211)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ថ្ងៃជាសមាជិក"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 166)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "អាស័យដា្ឋន"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ភេទ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "គោត្តនាម"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(390, 124)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "លេខទូរស័ព្ទ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(390, 78)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "នាម"
        '
        'txtMemAddr
        '
        Me.txtMemAddr.Location = New System.Drawing.Point(117, 163)
        Me.txtMemAddr.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtMemAddr.Name = "txtMemAddr"
        Me.txtMemAddr.Size = New System.Drawing.Size(644, 32)
        Me.txtMemAddr.TabIndex = 6
        '
        'txtMemTel
        '
        Me.txtMemTel.Location = New System.Drawing.Point(475, 120)
        Me.txtMemTel.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtMemTel.Name = "txtMemTel"
        Me.txtMemTel.Size = New System.Drawing.Size(286, 32)
        Me.txtMemTel.TabIndex = 5
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(475, 76)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(286, 32)
        Me.txtFName.TabIndex = 3
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(117, 76)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(263, 32)
        Me.txtLName.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdMember)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 284)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(978, 285)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'grdMember
        '
        Me.grdMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMember.Location = New System.Drawing.Point(5, 18)
        Me.grdMember.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdMember.Name = "grdMember"
        Me.grdMember.Size = New System.Drawing.Size(967, 259)
        Me.grdMember.TabIndex = 0
        '
        'frmRegisterMember
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 582)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Khmer OS Content", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmRegisterMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Member"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMemId As System.Windows.Forms.TextBox
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents dtpMem As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMemAddr As System.Windows.Forms.TextBox
    Friend WithEvents txtMemTel As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grdMember As System.Windows.Forms.DataGridView
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents cboMemId As System.Windows.Forms.ComboBox

End Class
