<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdersManagement
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
        Me.dateCollected = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstOrdersCollect = New System.Windows.Forms.ListBox()
        Me.btnSearchOrdersCollect = New System.Windows.Forms.Button()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtCarMake = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtCarModel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCollected = New System.Windows.Forms.Button()
        Me.lstOrdersReturn = New System.Windows.Forms.ListBox()
        Me.dateReturned = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchOrdersReturn = New System.Windows.Forms.Button()
        Me.btnReturned = New System.Windows.Forms.Button()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.panReturnDetails = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.txtTotalPenaltyCost = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.checkCarBody = New System.Windows.Forms.CheckBox()
        Me.checkInterior = New System.Windows.Forms.CheckBox()
        Me.checkScratches = New System.Windows.Forms.CheckBox()
        Me.checkTyres = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AddService = New System.Windows.Forms.CheckBox()
        Me.checkPaid = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAmend = New System.Windows.Forms.Button()
        Me.panAmendOrder = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.panCarSearchList = New System.Windows.Forms.Panel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lstCars = New System.Windows.Forms.ListBox()
        Me.comModel = New System.Windows.Forms.ComboBox()
        Me.comMake = New System.Windows.Forms.ComboBox()
        Me.btnSearchAVCars = New System.Windows.Forms.Button()
        Me.datReturn = New System.Windows.Forms.DateTimePicker()
        Me.datCollect = New System.Windows.Forms.DateTimePicker()
        Me.lblCarID = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCostPerDay = New System.Windows.Forms.TextBox()
        Me.btnUpdateOrder = New System.Windows.Forms.Button()
        Me.dateReturn = New System.Windows.Forms.DateTimePicker()
        Me.datStart = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.panCollectODetails = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnDeleteOrder = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panOrdersList = New System.Windows.Forms.Panel()
        Me.panReturnDetails.SuspendLayout()
        Me.panAmendOrder.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.panCarSearchList.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.panCollectODetails.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.panOrdersList.SuspendLayout()
        Me.SuspendLayout()
        '
        'dateCollected
        '
        Me.dateCollected.Enabled = False
        Me.dateCollected.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateCollected.Location = New System.Drawing.Point(15, 84)
        Me.dateCollected.Margin = New System.Windows.Forms.Padding(4)
        Me.dateCollected.Name = "dateCollected"
        Me.dateCollected.Size = New System.Drawing.Size(228, 30)
        Me.dateCollected.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATE TODAY"
        '
        'lstOrdersCollect
        '
        Me.lstOrdersCollect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOrdersCollect.FormattingEnabled = True
        Me.lstOrdersCollect.ItemHeight = 25
        Me.lstOrdersCollect.Location = New System.Drawing.Point(15, 160)
        Me.lstOrdersCollect.Margin = New System.Windows.Forms.Padding(4)
        Me.lstOrdersCollect.Name = "lstOrdersCollect"
        Me.lstOrdersCollect.Size = New System.Drawing.Size(392, 129)
        Me.lstOrdersCollect.TabIndex = 2
        '
        'btnSearchOrdersCollect
        '
        Me.btnSearchOrdersCollect.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearchOrdersCollect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchOrdersCollect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchOrdersCollect.Location = New System.Drawing.Point(289, 80)
        Me.btnSearchOrdersCollect.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchOrdersCollect.Name = "btnSearchOrdersCollect"
        Me.btnSearchOrdersCollect.Size = New System.Drawing.Size(103, 36)
        Me.btnSearchOrdersCollect.TabIndex = 4
        Me.btnSearchOrdersCollect.Text = "Search"
        Me.btnSearchOrdersCollect.UseVisualStyleBackColor = False
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderID.Location = New System.Drawing.Point(113, 14)
        Me.lblOrderID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(19, 25)
        Me.lblOrderID.TabIndex = 5
        Me.lblOrderID.Text = "-"
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(8, 73)
        Me.lblCustomer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(106, 25)
        Me.lblCustomer.TabIndex = 6
        Me.lblCustomer.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 180)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Car Make"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 311)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Start Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 372)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "ReturnDate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 474)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 25)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Total Cost"
        '
        'txtFirstname
        '
        Me.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstname.Enabled = False
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(156, 57)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.ReadOnly = True
        Me.txtFirstname.Size = New System.Drawing.Size(225, 30)
        Me.txtFirstname.TabIndex = 11
        '
        'txtCarMake
        '
        Me.txtCarMake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCarMake.Enabled = False
        Me.txtCarMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarMake.Location = New System.Drawing.Point(156, 172)
        Me.txtCarMake.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCarMake.Name = "txtCarMake"
        Me.txtCarMake.ReadOnly = True
        Me.txtCarMake.Size = New System.Drawing.Size(225, 30)
        Me.txtCarMake.TabIndex = 12
        '
        'txtTotalCost
        '
        Me.txtTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalCost.Enabled = False
        Me.txtTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCost.Location = New System.Drawing.Point(153, 474)
        Me.txtTotalCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(129, 30)
        Me.txtTotalCost.TabIndex = 13
        '
        'txtSurname
        '
        Me.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSurname.Enabled = False
        Me.txtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(156, 116)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.ReadOnly = True
        Me.txtSurname.Size = New System.Drawing.Size(225, 30)
        Me.txtSurname.TabIndex = 16
        '
        'txtCarModel
        '
        Me.txtCarModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCarModel.Enabled = False
        Me.txtCarModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarModel.Location = New System.Drawing.Point(156, 234)
        Me.txtCarModel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCarModel.Name = "txtCarModel"
        Me.txtCarModel.ReadOnly = True
        Me.txtCarModel.Size = New System.Drawing.Size(225, 30)
        Me.txtCarModel.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 250)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Car Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Surname"
        '
        'btnCollected
        '
        Me.btnCollected.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCollected.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCollected.Location = New System.Drawing.Point(15, 297)
        Me.btnCollected.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCollected.Name = "btnCollected"
        Me.btnCollected.Size = New System.Drawing.Size(131, 59)
        Me.btnCollected.TabIndex = 20
        Me.btnCollected.Text = "Collected"
        Me.btnCollected.UseVisualStyleBackColor = False
        '
        'lstOrdersReturn
        '
        Me.lstOrdersReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOrdersReturn.FormattingEnabled = True
        Me.lstOrdersReturn.ItemHeight = 25
        Me.lstOrdersReturn.Location = New System.Drawing.Point(31, 151)
        Me.lstOrdersReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.lstOrdersReturn.Name = "lstOrdersReturn"
        Me.lstOrdersReturn.Size = New System.Drawing.Size(376, 154)
        Me.lstOrdersReturn.TabIndex = 21
        '
        'dateReturned
        '
        Me.dateReturned.Enabled = False
        Me.dateReturned.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateReturned.Location = New System.Drawing.Point(32, 87)
        Me.dateReturned.Margin = New System.Windows.Forms.Padding(4)
        Me.dateReturned.Name = "dateReturned"
        Me.dateReturned.Size = New System.Drawing.Size(247, 30)
        Me.dateReturned.TabIndex = 22
        '
        'btnSearchOrdersReturn
        '
        Me.btnSearchOrdersReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearchOrdersReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchOrdersReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchOrdersReturn.Location = New System.Drawing.Point(313, 78)
        Me.btnSearchOrdersReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchOrdersReturn.Name = "btnSearchOrdersReturn"
        Me.btnSearchOrdersReturn.Size = New System.Drawing.Size(95, 43)
        Me.btnSearchOrdersReturn.TabIndex = 23
        Me.btnSearchOrdersReturn.Text = "Search"
        Me.btnSearchOrdersReturn.UseVisualStyleBackColor = False
        '
        'btnReturned
        '
        Me.btnReturned.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReturned.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturned.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturned.Location = New System.Drawing.Point(67, 641)
        Me.btnReturned.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReturned.Name = "btnReturned"
        Me.btnReturned.Size = New System.Drawing.Size(147, 73)
        Me.btnReturned.TabIndex = 24
        Me.btnReturned.Text = "Returned"
        Me.btnReturned.UseVisualStyleBackColor = False
        '
        'txtComments
        '
        Me.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComments.Location = New System.Drawing.Point(67, 364)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(337, 142)
        Me.txtComments.TabIndex = 25
        Me.txtComments.Text = "No Comment"
        '
        'panReturnDetails
        '
        Me.panReturnDetails.Controls.Add(Me.btnCancel)
        Me.panReturnDetails.Controls.Add(Me.btnTotal)
        Me.panReturnDetails.Controls.Add(Me.txtTotalPenaltyCost)
        Me.panReturnDetails.Controls.Add(Me.Label10)
        Me.panReturnDetails.Controls.Add(Me.checkCarBody)
        Me.panReturnDetails.Controls.Add(Me.checkInterior)
        Me.panReturnDetails.Controls.Add(Me.checkScratches)
        Me.panReturnDetails.Controls.Add(Me.checkTyres)
        Me.panReturnDetails.Controls.Add(Me.Label9)
        Me.panReturnDetails.Controls.Add(Me.AddService)
        Me.panReturnDetails.Controls.Add(Me.checkPaid)
        Me.panReturnDetails.Controls.Add(Me.Label8)
        Me.panReturnDetails.Controls.Add(Me.txtComments)
        Me.panReturnDetails.Controls.Add(Me.btnReturned)
        Me.panReturnDetails.Location = New System.Drawing.Point(24, 7)
        Me.panReturnDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.panReturnDetails.Name = "panReturnDetails"
        Me.panReturnDetails.Size = New System.Drawing.Size(584, 758)
        Me.panReturnDetails.TabIndex = 26
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(276, 641)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(147, 73)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(96, 284)
        Me.btnTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(116, 40)
        Me.btnTotal.TabIndex = 36
        Me.btnTotal.Text = "Total "
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'txtTotalPenaltyCost
        '
        Me.txtTotalPenaltyCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalPenaltyCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPenaltyCost.Location = New System.Drawing.Point(289, 527)
        Me.txtTotalPenaltyCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalPenaltyCost.Name = "txtTotalPenaltyCost"
        Me.txtTotalPenaltyCost.Size = New System.Drawing.Size(106, 30)
        Me.txtTotalPenaltyCost.TabIndex = 35
        Me.txtTotalPenaltyCost.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(62, 532)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 25)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Total penalty cost"
        '
        'checkCarBody
        '
        Me.checkCarBody.AutoSize = True
        Me.checkCarBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkCarBody.Location = New System.Drawing.Point(284, 234)
        Me.checkCarBody.Margin = New System.Windows.Forms.Padding(4)
        Me.checkCarBody.Name = "checkCarBody"
        Me.checkCarBody.Size = New System.Drawing.Size(154, 29)
        Me.checkCarBody.TabIndex = 33
        Me.checkCarBody.Text = "Car Body £50"
        Me.checkCarBody.UseVisualStyleBackColor = True
        '
        'checkInterior
        '
        Me.checkInterior.AutoSize = True
        Me.checkInterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkInterior.Location = New System.Drawing.Point(253, 176)
        Me.checkInterior.Margin = New System.Windows.Forms.Padding(4)
        Me.checkInterior.Name = "checkInterior"
        Me.checkInterior.Size = New System.Drawing.Size(131, 29)
        Me.checkInterior.TabIndex = 32
        Me.checkInterior.Text = "Interior £50"
        Me.checkInterior.UseVisualStyleBackColor = True
        '
        'checkScratches
        '
        Me.checkScratches.AutoSize = True
        Me.checkScratches.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkScratches.Location = New System.Drawing.Point(101, 234)
        Me.checkScratches.Margin = New System.Windows.Forms.Padding(4)
        Me.checkScratches.Name = "checkScratches"
        Me.checkScratches.Size = New System.Drawing.Size(160, 29)
        Me.checkScratches.TabIndex = 31
        Me.checkScratches.Text = "Scratches £20"
        Me.checkScratches.UseVisualStyleBackColor = True
        '
        'checkTyres
        '
        Me.checkTyres.AutoSize = True
        Me.checkTyres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkTyres.Location = New System.Drawing.Point(101, 176)
        Me.checkTyres.Margin = New System.Windows.Forms.Padding(4)
        Me.checkTyres.Name = "checkTyres"
        Me.checkTyres.Size = New System.Drawing.Size(122, 29)
        Me.checkTyres.TabIndex = 30
        Me.checkTyres.Text = "Tyres £40"
        Me.checkTyres.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(62, 99)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(255, 25)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Assess Condition of the Car"
        '
        'AddService
        '
        Me.AddService.AutoSize = True
        Me.AddService.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddService.Location = New System.Drawing.Point(238, 593)
        Me.AddService.Margin = New System.Windows.Forms.Padding(4)
        Me.AddService.Name = "AddService"
        Me.AddService.Size = New System.Drawing.Size(162, 29)
        Me.AddService.TabIndex = 28
        Me.AddService.Text = "Add to Service"
        Me.AddService.UseVisualStyleBackColor = True
        '
        'checkPaid
        '
        Me.checkPaid.AutoSize = True
        Me.checkPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkPaid.Location = New System.Drawing.Point(64, 593)
        Me.checkPaid.Margin = New System.Windows.Forms.Padding(4)
        Me.checkPaid.Name = "checkPaid"
        Me.checkPaid.Size = New System.Drawing.Size(73, 29)
        Me.checkPaid.TabIndex = 27
        Me.checkPaid.Text = "Paid"
        Me.checkPaid.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 343)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Comments"
        '
        'btnAmend
        '
        Me.btnAmend.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAmend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAmend.Location = New System.Drawing.Point(40, 564)
        Me.btnAmend.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAmend.Name = "btnAmend"
        Me.btnAmend.Size = New System.Drawing.Size(108, 49)
        Me.btnAmend.TabIndex = 28
        Me.btnAmend.Text = "AMEND"
        Me.btnAmend.UseVisualStyleBackColor = False
        '
        'panAmendOrder
        '
        Me.panAmendOrder.Controls.Add(Me.Panel8)
        Me.panAmendOrder.Controls.Add(Me.Label35)
        Me.panAmendOrder.Controls.Add(Me.Label34)
        Me.panAmendOrder.Controls.Add(Me.Label33)
        Me.panAmendOrder.Controls.Add(Me.Label32)
        Me.panAmendOrder.Controls.Add(Me.panCarSearchList)
        Me.panAmendOrder.Controls.Add(Me.comModel)
        Me.panAmendOrder.Controls.Add(Me.comMake)
        Me.panAmendOrder.Controls.Add(Me.btnSearchAVCars)
        Me.panAmendOrder.Controls.Add(Me.datReturn)
        Me.panAmendOrder.Controls.Add(Me.datCollect)
        Me.panAmendOrder.Location = New System.Drawing.Point(23, 10)
        Me.panAmendOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.panAmendOrder.Name = "panAmendOrder"
        Me.panAmendOrder.Size = New System.Drawing.Size(553, 745)
        Me.panAmendOrder.TabIndex = 29
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel8.Controls.Add(Me.Label31)
        Me.Panel8.Location = New System.Drawing.Point(0, 2)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(553, 71)
        Me.Panel8.TabIndex = 43
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(144, 18)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(201, 29)
        Me.Label31.TabIndex = 41
        Me.Label31.Text = "AMEND ORDER"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(261, 261)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(103, 25)
        Me.Label35.TabIndex = 47
        Me.Label35.Text = "Car Model"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(95, 261)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(98, 25)
        Me.Label34.TabIndex = 46
        Me.Label34.Text = "Car Make"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(37, 181)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(115, 25)
        Me.Label33.TabIndex = 45
        Me.Label33.Text = "Return Date"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(35, 96)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(118, 25)
        Me.Label32.TabIndex = 44
        Me.Label32.Text = "Collect Date"
        '
        'panCarSearchList
        '
        Me.panCarSearchList.Controls.Add(Me.Label37)
        Me.panCarSearchList.Controls.Add(Me.Label36)
        Me.panCarSearchList.Controls.Add(Me.lstCars)
        Me.panCarSearchList.Location = New System.Drawing.Point(48, 338)
        Me.panCarSearchList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panCarSearchList.Name = "panCarSearchList"
        Me.panCarSearchList.Size = New System.Drawing.Size(421, 385)
        Me.panCarSearchList.TabIndex = 9
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(177, 31)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(72, 17)
        Me.Label37.TabIndex = 8
        Me.Label37.Text = "Car Model"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(48, 30)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(68, 17)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Car Make"
        '
        'lstCars
        '
        Me.lstCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCars.FormattingEnabled = True
        Me.lstCars.ItemHeight = 25
        Me.lstCars.Location = New System.Drawing.Point(43, 53)
        Me.lstCars.Margin = New System.Windows.Forms.Padding(4)
        Me.lstCars.Name = "lstCars"
        Me.lstCars.Size = New System.Drawing.Size(320, 254)
        Me.lstCars.TabIndex = 0
        '
        'comModel
        '
        Me.comModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comModel.FormattingEnabled = True
        Me.comModel.Location = New System.Drawing.Point(264, 288)
        Me.comModel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comModel.Name = "comModel"
        Me.comModel.Size = New System.Drawing.Size(121, 33)
        Me.comModel.TabIndex = 8
        '
        'comMake
        '
        Me.comMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comMake.FormattingEnabled = True
        Me.comMake.Location = New System.Drawing.Point(91, 288)
        Me.comMake.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comMake.Name = "comMake"
        Me.comMake.Size = New System.Drawing.Size(121, 33)
        Me.comMake.TabIndex = 7
        '
        'btnSearchAVCars
        '
        Me.btnSearchAVCars.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearchAVCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchAVCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchAVCars.Location = New System.Drawing.Point(291, 146)
        Me.btnSearchAVCars.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchAVCars.Name = "btnSearchAVCars"
        Me.btnSearchAVCars.Size = New System.Drawing.Size(109, 55)
        Me.btnSearchAVCars.TabIndex = 6
        Me.btnSearchAVCars.Text = "Search"
        Me.btnSearchAVCars.UseVisualStyleBackColor = False
        '
        'datReturn
        '
        Me.datReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datReturn.Location = New System.Drawing.Point(37, 210)
        Me.datReturn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datReturn.Name = "datReturn"
        Me.datReturn.Size = New System.Drawing.Size(216, 30)
        Me.datReturn.TabIndex = 5
        '
        'datCollect
        '
        Me.datCollect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datCollect.Location = New System.Drawing.Point(37, 132)
        Me.datCollect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datCollect.Name = "datCollect"
        Me.datCollect.Size = New System.Drawing.Size(217, 30)
        Me.datCollect.TabIndex = 4
        '
        'lblCarID
        '
        Me.lblCarID.AutoSize = True
        Me.lblCarID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarID.Location = New System.Drawing.Point(341, 14)
        Me.lblCarID.Name = "lblCarID"
        Me.lblCarID.Size = New System.Drawing.Size(19, 25)
        Me.lblCarID.TabIndex = 31
        Me.lblCarID.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 428)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 25)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Cost P/Day"
        '
        'txtCostPerDay
        '
        Me.txtCostPerDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostPerDay.Enabled = False
        Me.txtCostPerDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostPerDay.Location = New System.Drawing.Point(153, 426)
        Me.txtCostPerDay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostPerDay.Name = "txtCostPerDay"
        Me.txtCostPerDay.ReadOnly = True
        Me.txtCostPerDay.Size = New System.Drawing.Size(129, 30)
        Me.txtCostPerDay.TabIndex = 33
        '
        'btnUpdateOrder
        '
        Me.btnUpdateOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateOrder.Location = New System.Drawing.Point(273, 564)
        Me.btnUpdateOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateOrder.Name = "btnUpdateOrder"
        Me.btnUpdateOrder.Size = New System.Drawing.Size(108, 49)
        Me.btnUpdateOrder.TabIndex = 36
        Me.btnUpdateOrder.Text = " Update"
        Me.btnUpdateOrder.UseVisualStyleBackColor = False
        '
        'dateReturn
        '
        Me.dateReturn.Enabled = False
        Me.dateReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateReturn.Location = New System.Drawing.Point(153, 356)
        Me.dateReturn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dateReturn.Name = "dateReturn"
        Me.dateReturn.Size = New System.Drawing.Size(227, 30)
        Me.dateReturn.TabIndex = 10
        '
        'datStart
        '
        Me.datStart.Enabled = False
        Me.datStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datStart.Location = New System.Drawing.Point(156, 294)
        Me.datStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datStart.Name = "datStart"
        Me.datStart.Size = New System.Drawing.Size(224, 30)
        Me.datStart.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.btnCollected)
        Me.Panel1.Controls.Add(Me.btnSearchOrdersCollect)
        Me.Panel1.Controls.Add(Me.lstOrdersCollect)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dateCollected)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 372)
        Me.Panel1.TabIndex = 37
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(236, 139)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 17)
        Me.Label27.TabIndex = 25
        Me.Label27.Text = "CAR ID"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(115, 139)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(103, 17)
        Me.Label26.TabIndex = 24
        Me.Label26.Text = "CUSTOMER ID"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(19, 139)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(75, 17)
        Me.Label25.TabIndex = 23
        Me.Label25.Text = "ORDER ID"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Location = New System.Drawing.Point(0, 2)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(561, 59)
        Me.Panel5.TabIndex = 22
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(17, 12)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(453, 29)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "ORDERS BEING COLLECTED TODAY"
        '
        'panCollectODetails
        '
        Me.panCollectODetails.BackColor = System.Drawing.SystemColors.Control
        Me.panCollectODetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panCollectODetails.Controls.Add(Me.btnClear)
        Me.panCollectODetails.Controls.Add(Me.Panel7)
        Me.panCollectODetails.Controls.Add(Me.Panel2)
        Me.panCollectODetails.Location = New System.Drawing.Point(691, 5)
        Me.panCollectODetails.Margin = New System.Windows.Forms.Padding(4)
        Me.panCollectODetails.Name = "panCollectODetails"
        Me.panCollectODetails.Size = New System.Drawing.Size(608, 773)
        Me.panCollectODetails.TabIndex = 37
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(480, 719)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 36)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel7.Controls.Add(Me.Label24)
        Me.Panel7.Location = New System.Drawing.Point(-1, 7)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(608, 59)
        Me.Panel7.TabIndex = 42
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(144, 18)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(214, 29)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "ORDER DETAILS"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.btnAmend)
        Me.Panel2.Controls.Add(Me.btnUpdateOrder)
        Me.Panel2.Controls.Add(Me.btnDeleteOrder)
        Me.Panel2.Controls.Add(Me.dateReturn)
        Me.Panel2.Controls.Add(Me.datStart)
        Me.Panel2.Controls.Add(Me.txtCostPerDay)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.lblCarID)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtCarModel)
        Me.Panel2.Controls.Add(Me.txtSurname)
        Me.Panel2.Controls.Add(Me.txtTotalCost)
        Me.Panel2.Controls.Add(Me.txtCarMake)
        Me.Panel2.Controls.Add(Me.txtFirstname)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblCustomer)
        Me.Panel2.Controls.Add(Me.lblOrderID)
        Me.Panel2.Location = New System.Drawing.Point(53, 84)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(455, 644)
        Me.Panel2.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(249, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 25)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "CarID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 14)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 25)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Order ID"
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteOrder.Location = New System.Drawing.Point(156, 564)
        Me.btnDeleteOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(108, 49)
        Me.btnDeleteOrder.TabIndex = 37
        Me.btnDeleteOrder.Text = "DELETE"
        Me.btnDeleteOrder.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label30)
        Me.Panel3.Controls.Add(Me.Label29)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.btnSearchOrdersReturn)
        Me.Panel3.Controls.Add(Me.dateReturned)
        Me.Panel3.Controls.Add(Me.lstOrdersReturn)
        Me.Panel3.Location = New System.Drawing.Point(5, 390)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(496, 318)
        Me.Panel3.TabIndex = 38
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(269, 130)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(53, 17)
        Me.Label30.TabIndex = 26
        Me.Label30.Text = "CAR ID"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(135, 130)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(103, 17)
        Me.Label29.TabIndex = 26
        Me.Label29.Text = "CUSTOMER ID"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(33, 130)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(75, 17)
        Me.Label28.TabIndex = 26
        Me.Label28.Text = "ORDER ID"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel6.Controls.Add(Me.Label23)
        Me.Panel6.Location = New System.Drawing.Point(0, 2)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(493, 59)
        Me.Panel6.TabIndex = 23
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(24, 16)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(442, 29)
        Me.Label23.TabIndex = 24
        Me.Label23.Text = "ORDERS BEING RETURNED TODAY"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(28, 65)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 17)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "DATE TODAY"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.panOrdersList)
        Me.Panel4.Controls.Add(Me.panReturnDetails)
        Me.Panel4.Controls.Add(Me.panAmendOrder)
        Me.Panel4.Location = New System.Drawing.Point(25, 5)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(653, 773)
        Me.Panel4.TabIndex = 39
        '
        'panOrdersList
        '
        Me.panOrdersList.Controls.Add(Me.Panel1)
        Me.panOrdersList.Controls.Add(Me.Panel3)
        Me.panOrdersList.Location = New System.Drawing.Point(55, 10)
        Me.panOrdersList.Margin = New System.Windows.Forms.Padding(4)
        Me.panOrdersList.Name = "panOrdersList"
        Me.panOrdersList.Size = New System.Drawing.Size(516, 736)
        Me.panOrdersList.TabIndex = 39
        '
        'OrdersManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1331, 791)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.panCollectODetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "OrdersManagement"
        Me.Text = " "
        Me.panReturnDetails.ResumeLayout(False)
        Me.panReturnDetails.PerformLayout()
        Me.panAmendOrder.ResumeLayout(False)
        Me.panAmendOrder.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.panCarSearchList.ResumeLayout(False)
        Me.panCarSearchList.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.panCollectODetails.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.panOrdersList.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dateCollected As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstOrdersCollect As System.Windows.Forms.ListBox
    Friend WithEvents btnSearchOrdersCollect As System.Windows.Forms.Button
    Friend WithEvents lblOrderID As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtCarMake As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtCarModel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCollected As System.Windows.Forms.Button
    Friend WithEvents lstOrdersReturn As ListBox
    Friend WithEvents dateReturned As DateTimePicker
    Friend WithEvents btnSearchOrdersReturn As Button
    Friend WithEvents btnReturned As Button
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents panReturnDetails As System.Windows.Forms.Panel
    Friend WithEvents checkPaid As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AddService As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents checkCarBody As System.Windows.Forms.CheckBox
    Friend WithEvents checkInterior As System.Windows.Forms.CheckBox
    Friend WithEvents checkScratches As System.Windows.Forms.CheckBox
    Friend WithEvents checkTyres As System.Windows.Forms.CheckBox
    Friend WithEvents txtTotalPenaltyCost As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents btnAmend As System.Windows.Forms.Button
    Friend WithEvents panAmendOrder As System.Windows.Forms.Panel
    Friend WithEvents lstCars As System.Windows.Forms.ListBox
    Friend WithEvents datReturn As DateTimePicker
    Friend WithEvents datCollect As DateTimePicker
    Friend WithEvents btnSearchAVCars As Button
    Friend WithEvents lblCarID As Label
    Friend WithEvents comMake As ComboBox
    Friend WithEvents comModel As ComboBox
    Friend WithEvents panCarSearchList As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCostPerDay As TextBox
    Friend WithEvents btnUpdateOrder As Button
    Friend WithEvents dateReturn As DateTimePicker
    Friend WithEvents datStart As DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents panCollectODetails As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDeleteOrder As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents panOrdersList As System.Windows.Forms.Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClear As Button
End Class
