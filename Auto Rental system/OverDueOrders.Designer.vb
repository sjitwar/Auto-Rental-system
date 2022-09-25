<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OverDueOrders
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
        Me.lstOverDueOrders = New System.Windows.Forms.ListBox()
        Me.panReturnODetails = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCostPerDay = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPaid = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReturned = New System.Windows.Forms.Button()
        Me.datReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.datStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCarID = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCarModel = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.txtCarMake = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panReturnDetails = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtTimePenaltyCost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCalculatePenalty = New System.Windows.Forms.Button()
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
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.btnUpdateReturn = New System.Windows.Forms.Button()
        Me.panOrders = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstOrdersNotPaid = New System.Windows.Forms.ListBox()
        Me.panReturnODetails.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panReturnDetails.SuspendLayout()
        Me.panOrders.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstOverDueOrders
        '
        Me.lstOverDueOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOverDueOrders.FormattingEnabled = True
        Me.lstOverDueOrders.ItemHeight = 25
        Me.lstOverDueOrders.Location = New System.Drawing.Point(65, 145)
        Me.lstOverDueOrders.Margin = New System.Windows.Forms.Padding(4)
        Me.lstOverDueOrders.Name = "lstOverDueOrders"
        Me.lstOverDueOrders.Size = New System.Drawing.Size(361, 154)
        Me.lstOverDueOrders.TabIndex = 0
        '
        'panReturnODetails
        '
        Me.panReturnODetails.BackColor = System.Drawing.SystemColors.Control
        Me.panReturnODetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panReturnODetails.Controls.Add(Me.Panel6)
        Me.panReturnODetails.Controls.Add(Me.Panel3)
        Me.panReturnODetails.Location = New System.Drawing.Point(649, 4)
        Me.panReturnODetails.Margin = New System.Windows.Forms.Padding(4)
        Me.panReturnODetails.Name = "panReturnODetails"
        Me.panReturnODetails.Size = New System.Drawing.Size(626, 758)
        Me.panReturnODetails.TabIndex = 39
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Location = New System.Drawing.Point(-1, 20)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(692, 69)
        Me.Panel6.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(157, 17)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(294, 39)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "ORDER DETAILS"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtCostPerDay)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.lblCustomerID)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.btnPaid)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.btnReturned)
        Me.Panel3.Controls.Add(Me.datReturnDate)
        Me.Panel3.Controls.Add(Me.datStartDate)
        Me.Panel3.Controls.Add(Me.lblCarID)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.txtCarModel)
        Me.Panel3.Controls.Add(Me.txtSurname)
        Me.Panel3.Controls.Add(Me.txtTotalCost)
        Me.Panel3.Controls.Add(Me.txtCarMake)
        Me.Panel3.Controls.Add(Me.txtFirstname)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.lblOrderID)
        Me.Panel3.Location = New System.Drawing.Point(67, 76)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(476, 626)
        Me.Panel3.TabIndex = 45
        '
        'txtCostPerDay
        '
        Me.txtCostPerDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostPerDay.Enabled = False
        Me.txtCostPerDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostPerDay.Location = New System.Drawing.Point(219, 319)
        Me.txtCostPerDay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostPerDay.Name = "txtCostPerDay"
        Me.txtCostPerDay.ReadOnly = True
        Me.txtCostPerDay.Size = New System.Drawing.Size(182, 30)
        Me.txtCostPerDay.TabIndex = 47
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(35, 331)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(112, 25)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "Cost P/Day"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Location = New System.Drawing.Point(176, 89)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(13, 17)
        Me.lblCustomerID.TabIndex = 45
        Me.lblCustomerID.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Customer ID"
        '
        'btnPaid
        '
        Me.btnPaid.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPaid.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaid.Location = New System.Drawing.Point(219, 535)
        Me.btnPaid.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPaid.Name = "btnPaid"
        Me.btnPaid.Size = New System.Drawing.Size(140, 66)
        Me.btnPaid.TabIndex = 43
        Me.btnPaid.Text = "Paid"
        Me.btnPaid.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(213, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 25)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Car ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Order ID"
        '
        'btnReturned
        '
        Me.btnReturned.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReturned.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturned.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturned.Location = New System.Drawing.Point(64, 535)
        Me.btnReturned.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReturned.Name = "btnReturned"
        Me.btnReturned.Size = New System.Drawing.Size(145, 66)
        Me.btnReturned.TabIndex = 40
        Me.btnReturned.Text = "Returned"
        Me.btnReturned.UseVisualStyleBackColor = False
        '
        'datReturnDate
        '
        Me.datReturnDate.Enabled = False
        Me.datReturnDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datReturnDate.Location = New System.Drawing.Point(219, 409)
        Me.datReturnDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datReturnDate.Name = "datReturnDate"
        Me.datReturnDate.Size = New System.Drawing.Size(221, 30)
        Me.datReturnDate.TabIndex = 10
        '
        'datStartDate
        '
        Me.datStartDate.Enabled = False
        Me.datStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datStartDate.Location = New System.Drawing.Point(217, 361)
        Me.datStartDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datStartDate.Name = "datStartDate"
        Me.datStartDate.Size = New System.Drawing.Size(221, 30)
        Me.datStartDate.TabIndex = 11
        '
        'lblCarID
        '
        Me.lblCarID.AutoSize = True
        Me.lblCarID.Location = New System.Drawing.Point(317, 55)
        Me.lblCarID.Name = "lblCarID"
        Me.lblCarID.Size = New System.Drawing.Size(13, 17)
        Me.lblCarID.TabIndex = 31
        Me.lblCarID.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(35, 187)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 25)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Surname"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(35, 286)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 25)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Car Model"
        '
        'txtCarModel
        '
        Me.txtCarModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCarModel.Enabled = False
        Me.txtCarModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarModel.Location = New System.Drawing.Point(219, 277)
        Me.txtCarModel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCarModel.Name = "txtCarModel"
        Me.txtCarModel.ReadOnly = True
        Me.txtCarModel.Size = New System.Drawing.Size(182, 30)
        Me.txtCarModel.TabIndex = 17
        '
        'txtSurname
        '
        Me.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSurname.Enabled = False
        Me.txtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(219, 180)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.ReadOnly = True
        Me.txtSurname.Size = New System.Drawing.Size(182, 30)
        Me.txtSurname.TabIndex = 16
        '
        'txtTotalCost
        '
        Me.txtTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalCost.Enabled = False
        Me.txtTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCost.Location = New System.Drawing.Point(219, 460)
        Me.txtTotalCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(182, 30)
        Me.txtTotalCost.TabIndex = 13
        '
        'txtCarMake
        '
        Me.txtCarMake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCarMake.Enabled = False
        Me.txtCarMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarMake.Location = New System.Drawing.Point(219, 230)
        Me.txtCarMake.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCarMake.Name = "txtCarMake"
        Me.txtCarMake.ReadOnly = True
        Me.txtCarMake.Size = New System.Drawing.Size(182, 30)
        Me.txtCarMake.TabIndex = 12
        '
        'txtFirstname
        '
        Me.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstname.Enabled = False
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(219, 127)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.ReadOnly = True
        Me.txtFirstname.Size = New System.Drawing.Size(182, 30)
        Me.txtFirstname.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(35, 470)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 25)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Total Cost"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(35, 417)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(110, 25)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "ReturnDate"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(35, 372)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(99, 25)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Start Date"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(35, 239)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 25)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Car Make"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(35, 135)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 25)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "First Name"
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Location = New System.Drawing.Point(132, 49)
        Me.lblOrderID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(13, 17)
        Me.lblOrderID.TabIndex = 5
        Me.lblOrderID.Text = "-"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.panReturnODetails)
        Me.Panel1.Controls.Add(Me.panOrders)
        Me.Panel1.Controls.Add(Me.panReturnDetails)
        Me.Panel1.Location = New System.Drawing.Point(5, 7)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 781)
        Me.Panel1.TabIndex = 40
        '
        'panReturnDetails
        '
        Me.panReturnDetails.BackColor = System.Drawing.SystemColors.Control
        Me.panReturnDetails.Controls.Add(Me.btnCancel)
        Me.panReturnDetails.Controls.Add(Me.txtTimePenaltyCost)
        Me.panReturnDetails.Controls.Add(Me.Label1)
        Me.panReturnDetails.Controls.Add(Me.txtCalculatePenalty)
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
        Me.panReturnDetails.Controls.Add(Me.btnUpdateReturn)
        Me.panReturnDetails.Location = New System.Drawing.Point(16, 4)
        Me.panReturnDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.panReturnDetails.Name = "panReturnDetails"
        Me.panReturnDetails.Size = New System.Drawing.Size(625, 758)
        Me.panReturnDetails.TabIndex = 41
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(389, 626)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(147, 73)
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtTimePenaltyCost
        '
        Me.txtTimePenaltyCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimePenaltyCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimePenaltyCost.Location = New System.Drawing.Point(272, 49)
        Me.txtTimePenaltyCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimePenaltyCost.Name = "txtTimePenaltyCost"
        Me.txtTimePenaltyCost.Size = New System.Drawing.Size(106, 30)
        Me.txtTimePenaltyCost.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 25)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Time Penalty cost"
        '
        'txtCalculatePenalty
        '
        Me.txtCalculatePenalty.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCalculatePenalty.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtCalculatePenalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalculatePenalty.Location = New System.Drawing.Point(322, 523)
        Me.txtCalculatePenalty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCalculatePenalty.Name = "txtCalculatePenalty"
        Me.txtCalculatePenalty.Size = New System.Drawing.Size(116, 30)
        Me.txtCalculatePenalty.TabIndex = 36
        Me.txtCalculatePenalty.Text = "Total Cost"
        Me.txtCalculatePenalty.UseVisualStyleBackColor = False
        '
        'txtTotalPenaltyCost
        '
        Me.txtTotalPenaltyCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalPenaltyCost.Enabled = False
        Me.txtTotalPenaltyCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPenaltyCost.Location = New System.Drawing.Point(192, 523)
        Me.txtTotalPenaltyCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalPenaltyCost.Name = "txtTotalPenaltyCost"
        Me.txtTotalPenaltyCost.Size = New System.Drawing.Size(106, 30)
        Me.txtTotalPenaltyCost.TabIndex = 35
        Me.txtTotalPenaltyCost.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(63, 527)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 17)
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
        Me.Label9.Location = New System.Drawing.Point(73, 142)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 25)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Faults/ Damage"
        '
        'AddService
        '
        Me.AddService.AutoSize = True
        Me.AddService.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddService.Location = New System.Drawing.Point(239, 578)
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
        Me.checkPaid.Location = New System.Drawing.Point(67, 578)
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
        Me.Label8.Location = New System.Drawing.Point(63, 331)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Comments"
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
        'btnUpdateReturn
        '
        Me.btnUpdateReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdateReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateReturn.Location = New System.Drawing.Point(67, 626)
        Me.btnUpdateReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateReturn.Name = "btnUpdateReturn"
        Me.btnUpdateReturn.Size = New System.Drawing.Size(147, 73)
        Me.btnUpdateReturn.TabIndex = 24
        Me.btnUpdateReturn.Text = "Returned"
        Me.btnUpdateReturn.UseVisualStyleBackColor = False
        '
        'panOrders
        '
        Me.panOrders.BackColor = System.Drawing.SystemColors.Control
        Me.panOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panOrders.Controls.Add(Me.Label23)
        Me.panOrders.Controls.Add(Me.Label22)
        Me.panOrders.Controls.Add(Me.Label21)
        Me.panOrders.Controls.Add(Me.Label13)
        Me.panOrders.Controls.Add(Me.Label12)
        Me.panOrders.Controls.Add(Me.Label11)
        Me.panOrders.Controls.Add(Me.Panel5)
        Me.panOrders.Controls.Add(Me.Panel4)
        Me.panOrders.Controls.Add(Me.lstOrdersNotPaid)
        Me.panOrders.Controls.Add(Me.lstOverDueOrders)
        Me.panOrders.Location = New System.Drawing.Point(32, 5)
        Me.panOrders.Margin = New System.Windows.Forms.Padding(4)
        Me.panOrders.Name = "panOrders"
        Me.panOrders.Size = New System.Drawing.Size(589, 757)
        Me.panOrders.TabIndex = 43
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(263, 457)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(85, 17)
        Me.Label23.TabIndex = 52
        Me.Label23.Text = "Customer ID"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(171, 457)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 17)
        Me.Label22.TabIndex = 51
        Me.Label22.Text = "Car ID"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(65, 457)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 17)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "Order ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(263, 123)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 17)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Customer ID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(171, 123)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 17)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Car ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(65, 123)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 17)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Order ID"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Location = New System.Drawing.Point(0, 353)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(588, 69)
        Me.Panel5.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(445, 26)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "ORDERS WITH OUTSTANDING PAYMENT"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(0, 18)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(588, 69)
        Me.Panel4.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(352, 39)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "OVER DUE ORDERS"
        '
        'lstOrdersNotPaid
        '
        Me.lstOrdersNotPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOrdersNotPaid.FormattingEnabled = True
        Me.lstOrdersNotPaid.ItemHeight = 25
        Me.lstOrdersNotPaid.Location = New System.Drawing.Point(65, 476)
        Me.lstOrdersNotPaid.Margin = New System.Windows.Forms.Padding(4)
        Me.lstOrdersNotPaid.Name = "lstOrdersNotPaid"
        Me.lstOrdersNotPaid.Size = New System.Drawing.Size(361, 154)
        Me.lstOrdersNotPaid.TabIndex = 42
        '
        'OverDueOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1307, 791)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "OverDueOrders"
        Me.Text = " "
        Me.panReturnODetails.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.panReturnDetails.ResumeLayout(False)
        Me.panReturnDetails.PerformLayout()
        Me.panOrders.ResumeLayout(False)
        Me.panOrders.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstOverDueOrders As System.Windows.Forms.ListBox
    Friend WithEvents panReturnODetails As System.Windows.Forms.Panel
    Friend WithEvents datReturnDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents datStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCarID As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCarModel As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents txtCarMake As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblOrderID As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnReturned As System.Windows.Forms.Button
    Friend WithEvents panReturnDetails As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCalculatePenalty As System.Windows.Forms.Button
    Friend WithEvents txtTotalPenaltyCost As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents checkCarBody As System.Windows.Forms.CheckBox
    Friend WithEvents checkInterior As System.Windows.Forms.CheckBox
    Friend WithEvents checkScratches As System.Windows.Forms.CheckBox
    Friend WithEvents checkTyres As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents AddService As System.Windows.Forms.CheckBox
    Friend WithEvents checkPaid As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdateReturn As System.Windows.Forms.Button
    Friend WithEvents lstOrdersNotPaid As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPaid As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents panOrders As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTimePenaltyCost As System.Windows.Forms.TextBox
    Friend WithEvents txtCostPerDay As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As Button
End Class
