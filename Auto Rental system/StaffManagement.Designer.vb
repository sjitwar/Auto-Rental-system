<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffManagement
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtStaffPassword = New System.Windows.Forms.TextBox()
        Me.txtStaffUsername = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnUpdateSalary = New System.Windows.Forms.Button()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.datDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.txtAccessLevel = New System.Windows.Forms.TextBox()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Postcode = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnCustomerClear = New System.Windows.Forms.Button()
        Me.btnSearchStaff = New System.Windows.Forms.Button()
        Me.txtStaffSurname = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.panStaffSearchList = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lstStaff = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.panStaffSearchList.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 418)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 469)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(19, 16)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.MaxLength = 30
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(159, 30)
        Me.txtFirstName.TabIndex = 4
        '
        'txtStaffPassword
        '
        Me.txtStaffPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffPassword.Location = New System.Drawing.Point(19, 445)
        Me.txtStaffPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStaffPassword.MaxLength = 20
        Me.txtStaffPassword.Name = "txtStaffPassword"
        Me.txtStaffPassword.Size = New System.Drawing.Size(159, 30)
        Me.txtStaffPassword.TabIndex = 5
        '
        'txtStaffUsername
        '
        Me.txtStaffUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffUsername.Location = New System.Drawing.Point(19, 394)
        Me.txtStaffUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStaffUsername.MaxLength = 20
        Me.txtStaffUsername.Name = "txtStaffUsername"
        Me.txtStaffUsername.Size = New System.Drawing.Size(159, 30)
        Me.txtStaffUsername.TabIndex = 6
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(19, 65)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSurname.MaxLength = 30
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(159, 30)
        Me.txtSurname.TabIndex = 7
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffID.Location = New System.Drawing.Point(235, 68)
        Me.lblStaffID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(242, 25)
        Me.lblStaffID.TabIndex = 8
        Me.lblStaffID.Text = "<automatically generated>"
        '
        'btnCreate
        '
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(43, 578)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(96, 41)
        Me.btnCreate.TabIndex = 9
        Me.btnCreate.Text = "ADD"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(161, 575)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 41)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "New"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblStaffID)
        Me.Panel1.Location = New System.Drawing.Point(616, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(668, 736)
        Me.Panel1.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(59, 69)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 25)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Staff ID"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Location = New System.Drawing.Point(0, 10)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(667, 54)
        Me.Panel5.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(97, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(427, 33)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "ADD STAFF/STAFF DETAILS"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Postcode)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnCreate)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(57, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(559, 631)
        Me.Panel2.TabIndex = 23
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(290, 571)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 41)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnUpdateSalary)
        Me.Panel3.Controls.Add(Me.txtSalary)
        Me.Panel3.Controls.Add(Me.txtContactNumber)
        Me.Panel3.Controls.Add(Me.datDateOfBirth)
        Me.Panel3.Controls.Add(Me.txtAccessLevel)
        Me.Panel3.Controls.Add(Me.txtPostcode)
        Me.Panel3.Controls.Add(Me.txtAddress)
        Me.Panel3.Controls.Add(Me.txtSurname)
        Me.Panel3.Controls.Add(Me.txtStaffUsername)
        Me.Panel3.Controls.Add(Me.txtStaffPassword)
        Me.Panel3.Controls.Add(Me.txtFirstName)
        Me.Panel3.Location = New System.Drawing.Point(181, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(359, 543)
        Me.Panel3.TabIndex = 23
        '
        'btnUpdateSalary
        '
        Me.btnUpdateSalary.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSalary.Location = New System.Drawing.Point(186, 333)
        Me.btnUpdateSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateSalary.Name = "btnUpdateSalary"
        Me.btnUpdateSalary.Size = New System.Drawing.Size(151, 41)
        Me.btnUpdateSalary.TabIndex = 24
        Me.btnUpdateSalary.Text = "Update Salary"
        Me.btnUpdateSalary.UseVisualStyleBackColor = True
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(19, 338)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalary.MaxLength = 30
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(159, 30)
        Me.txtSalary.TabIndex = 20
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.Location = New System.Drawing.Point(19, 285)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContactNumber.MaxLength = 30
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(159, 30)
        Me.txtContactNumber.TabIndex = 17
        '
        'datDateOfBirth
        '
        Me.datDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datDateOfBirth.Location = New System.Drawing.Point(19, 115)
        Me.datDateOfBirth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datDateOfBirth.Name = "datDateOfBirth"
        Me.datDateOfBirth.Size = New System.Drawing.Size(199, 30)
        Me.datDateOfBirth.TabIndex = 16
        '
        'txtAccessLevel
        '
        Me.txtAccessLevel.Enabled = False
        Me.txtAccessLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccessLevel.Location = New System.Drawing.Point(19, 499)
        Me.txtAccessLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAccessLevel.MaxLength = 30
        Me.txtAccessLevel.Name = "txtAccessLevel"
        Me.txtAccessLevel.Size = New System.Drawing.Size(136, 30)
        Me.txtAccessLevel.TabIndex = 21
        Me.txtAccessLevel.Text = "STAFF"
        '
        'txtPostcode
        '
        Me.txtPostcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostcode.Location = New System.Drawing.Point(19, 178)
        Me.txtPostcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPostcode.MaxLength = 6
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(159, 30)
        Me.txtPostcode.TabIndex = 15
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(19, 232)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.MaxLength = 30
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(159, 30)
        Me.txtAddress.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 524)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 25)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Access Level"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 357)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Salary"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 309)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 25)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Contact Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 254)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Address"
        '
        'Postcode
        '
        Me.Postcode.AutoSize = True
        Me.Postcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Postcode.Location = New System.Drawing.Point(4, 201)
        Me.Postcode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Postcode.Name = "Postcode"
        Me.Postcode.Size = New System.Drawing.Size(94, 25)
        Me.Postcode.TabIndex = 12
        Me.Postcode.Text = "Postcode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 139)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Date Of Birth"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.panStaffSearchList)
        Me.Panel4.Location = New System.Drawing.Point(23, 3)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(572, 736)
        Me.Panel4.TabIndex = 14
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Location = New System.Drawing.Point(1, 10)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(570, 54)
        Me.Panel7.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(165, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(193, 33)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "FIND STAFF"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnCustomerClear)
        Me.Panel6.Controls.Add(Me.btnSearchStaff)
        Me.Panel6.Controls.Add(Me.txtStaffSurname)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.txtStaffID)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Location = New System.Drawing.Point(70, 97)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(387, 187)
        Me.Panel6.TabIndex = 11
        '
        'btnCustomerClear
        '
        Me.btnCustomerClear.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCustomerClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustomerClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerClear.Location = New System.Drawing.Point(115, 129)
        Me.btnCustomerClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustomerClear.Name = "btnCustomerClear"
        Me.btnCustomerClear.Size = New System.Drawing.Size(100, 41)
        Me.btnCustomerClear.TabIndex = 8
        Me.btnCustomerClear.Text = "Clear"
        Me.btnCustomerClear.UseVisualStyleBackColor = False
        '
        'btnSearchStaff
        '
        Me.btnSearchStaff.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearchStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchStaff.Location = New System.Drawing.Point(7, 129)
        Me.btnSearchStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchStaff.Name = "btnSearchStaff"
        Me.btnSearchStaff.Size = New System.Drawing.Size(100, 41)
        Me.btnSearchStaff.TabIndex = 8
        Me.btnSearchStaff.Text = "Search"
        Me.btnSearchStaff.UseVisualStyleBackColor = False
        '
        'txtStaffSurname
        '
        Me.txtStaffSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStaffSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffSurname.Location = New System.Drawing.Point(133, 66)
        Me.txtStaffSurname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStaffSurname.Name = "txtStaffSurname"
        Me.txtStaffSurname.Size = New System.Drawing.Size(194, 30)
        Me.txtStaffSurname.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 68)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 25)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Surname"
        '
        'txtStaffID
        '
        Me.txtStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffID.Location = New System.Drawing.Point(132, 25)
        Me.txtStaffID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(70, 30)
        Me.txtStaffID.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 27)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 25)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Staff ID"
        '
        'panStaffSearchList
        '
        Me.panStaffSearchList.Controls.Add(Me.Label13)
        Me.panStaffSearchList.Controls.Add(Me.Label14)
        Me.panStaffSearchList.Controls.Add(Me.lstStaff)
        Me.panStaffSearchList.Location = New System.Drawing.Point(70, 321)
        Me.panStaffSearchList.Margin = New System.Windows.Forms.Padding(4)
        Me.panStaffSearchList.Name = "panStaffSearchList"
        Me.panStaffSearchList.Size = New System.Drawing.Size(403, 383)
        Me.panStaffSearchList.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(155, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Surname"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 17)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "First Name"
        '
        'lstStaff
        '
        Me.lstStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStaff.FormattingEnabled = True
        Me.lstStaff.ItemHeight = 25
        Me.lstStaff.Location = New System.Drawing.Point(21, 54)
        Me.lstStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.lstStaff.Name = "lstStaff"
        Me.lstStaff.Size = New System.Drawing.Size(346, 277)
        Me.lstStaff.TabIndex = 0
        '
        'StaffManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1313, 744)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StaffManagement"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.panStaffSearchList.ResumeLayout(False)
        Me.panStaffSearchList.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtStaffPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtStaffUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblStaffID As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Postcode As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents datDateOfBirth As DateTimePicker
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAccessLevel As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCustomerClear As Button
    Friend WithEvents btnSearchStaff As Button
    Friend WithEvents txtStaffSurname As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents panStaffSearchList As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lstStaff As ListBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnUpdateSalary As Button
    Friend WithEvents Label16 As Label
End Class
