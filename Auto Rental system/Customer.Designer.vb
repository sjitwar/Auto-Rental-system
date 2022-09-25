<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstCars = New System.Windows.Forms.ListBox()
        Me.panCarSearchList = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCarMake = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comMake = New System.Windows.Forms.ComboBox()
        Me.comModel = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCarID = New System.Windows.Forms.Label()
        Me.dateCollect = New System.Windows.Forms.DateTimePicker()
        Me.dateReturn = New System.Windows.Forms.DateTimePicker()
        Me.lblCollect = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnConfirmOrder = New System.Windows.Forms.Button()
        Me.txtCarModel = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCostPerDay = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.txtTotalDays = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dateCollectCar = New System.Windows.Forms.DateTimePicker()
        Me.dateReturnCar = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchAVCars = New System.Windows.Forms.Button()
        Me.panFrmTemplate = New System.Windows.Forms.Panel()
        Me.panBooking = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnMyDetails = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.panCarSearchList.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panBooking.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUSTOMER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Car Make"
        '
        'lstCars
        '
        Me.lstCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCars.FormattingEnabled = True
        Me.lstCars.ItemHeight = 25
        Me.lstCars.Location = New System.Drawing.Point(23, 30)
        Me.lstCars.Margin = New System.Windows.Forms.Padding(4)
        Me.lstCars.Name = "lstCars"
        Me.lstCars.Size = New System.Drawing.Size(348, 304)
        Me.lstCars.TabIndex = 6
        '
        'panCarSearchList
        '
        Me.panCarSearchList.Controls.Add(Me.Label17)
        Me.panCarSearchList.Controls.Add(Me.lstCars)
        Me.panCarSearchList.Controls.Add(Me.Label4)
        Me.panCarSearchList.Location = New System.Drawing.Point(79, 156)
        Me.panCarSearchList.Margin = New System.Windows.Forms.Padding(4)
        Me.panCarSearchList.Name = "panCarSearchList"
        Me.panCarSearchList.Size = New System.Drawing.Size(415, 345)
        Me.panCarSearchList.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(161, 9)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 17)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Car Model"
        '
        'txtCarMake
        '
        Me.txtCarMake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCarMake.Enabled = False
        Me.txtCarMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarMake.Location = New System.Drawing.Point(231, 10)
        Me.txtCarMake.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCarMake.Name = "txtCarMake"
        Me.txtCarMake.Size = New System.Drawing.Size(171, 30)
        Me.txtCarMake.TabIndex = 10
        '
        'txtTotalCost
        '
        Me.txtTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalCost.Enabled = False
        Me.txtTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCost.Location = New System.Drawing.Point(231, 366)
        Me.txtTotalCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(171, 30)
        Me.txtTotalCost.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 10)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Car Make"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 368)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Total Cost"
        '
        'comMake
        '
        Me.comMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comMake.FormattingEnabled = True
        Me.comMake.Location = New System.Drawing.Point(79, 107)
        Me.comMake.Margin = New System.Windows.Forms.Padding(4)
        Me.comMake.Name = "comMake"
        Me.comMake.Size = New System.Drawing.Size(144, 33)
        Me.comMake.Sorted = True
        Me.comMake.TabIndex = 14
        '
        'comModel
        '
        Me.comModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comModel.FormattingEnabled = True
        Me.comModel.Location = New System.Drawing.Point(320, 107)
        Me.comModel.Margin = New System.Windows.Forms.Padding(4)
        Me.comModel.Name = "comModel"
        Me.comModel.Size = New System.Drawing.Size(147, 33)
        Me.comModel.Sorted = True
        Me.comModel.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(74, 68)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Car Make"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(315, 68)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Car Model"
        '
        'lblCarID
        '
        Me.lblCarID.AutoSize = True
        Me.lblCarID.Location = New System.Drawing.Point(1193, 22)
        Me.lblCarID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCarID.Name = "lblCarID"
        Me.lblCarID.Size = New System.Drawing.Size(47, 17)
        Me.lblCarID.TabIndex = 18
        Me.lblCarID.Text = "Car ID"
        Me.lblCarID.Visible = False
        '
        'dateCollect
        '
        Me.dateCollect.Enabled = False
        Me.dateCollect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateCollect.Location = New System.Drawing.Point(231, 212)
        Me.dateCollect.Margin = New System.Windows.Forms.Padding(4)
        Me.dateCollect.Name = "dateCollect"
        Me.dateCollect.Size = New System.Drawing.Size(217, 30)
        Me.dateCollect.TabIndex = 19
        '
        'dateReturn
        '
        Me.dateReturn.Enabled = False
        Me.dateReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateReturn.Location = New System.Drawing.Point(231, 289)
        Me.dateReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.dateReturn.Name = "dateReturn"
        Me.dateReturn.Size = New System.Drawing.Size(217, 30)
        Me.dateReturn.TabIndex = 20
        '
        'lblCollect
        '
        Me.lblCollect.AutoSize = True
        Me.lblCollect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollect.Location = New System.Drawing.Point(19, 213)
        Me.lblCollect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCollect.Name = "lblCollect"
        Me.lblCollect.Size = New System.Drawing.Size(72, 25)
        Me.lblCollect.TabIndex = 21
        Me.lblCollect.Text = "Collect"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 289)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 25)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Return"
        '
        'btnConfirmOrder
        '
        Me.btnConfirmOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfirmOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmOrder.Location = New System.Drawing.Point(24, 482)
        Me.btnConfirmOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirmOrder.Name = "btnConfirmOrder"
        Me.btnConfirmOrder.Size = New System.Drawing.Size(157, 81)
        Me.btnConfirmOrder.TabIndex = 23
        Me.btnConfirmOrder.Text = "Confirm Order"
        Me.btnConfirmOrder.UseVisualStyleBackColor = False
        '
        'txtCarModel
        '
        Me.txtCarModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCarModel.Enabled = False
        Me.txtCarModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarModel.Location = New System.Drawing.Point(231, 70)
        Me.txtCarModel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCarModel.Name = "txtCarModel"
        Me.txtCarModel.Size = New System.Drawing.Size(171, 30)
        Me.txtCarModel.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 73)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 25)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Car Model"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 142)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 25)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Cost P/Day"
        '
        'txtCostPerDay
        '
        Me.txtCostPerDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostPerDay.Enabled = False
        Me.txtCostPerDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostPerDay.Location = New System.Drawing.Point(231, 145)
        Me.txtCostPerDay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostPerDay.Name = "txtCostPerDay"
        Me.txtCostPerDay.Size = New System.Drawing.Size(171, 30)
        Me.txtCostPerDay.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.lblOrderID)
        Me.Panel1.Controls.Add(Me.txtTotalDays)
        Me.Panel1.Location = New System.Drawing.Point(736, 9)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 728)
        Me.Panel1.TabIndex = 28
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel7.Controls.Add(Me.Label21)
        Me.Panel7.Location = New System.Drawing.Point(0, 15)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(577, 82)
        Me.Panel7.TabIndex = 38
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(116, 20)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(318, 42)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "ORDER DETAILS"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.txtCostPerDay)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.txtCarModel)
        Me.Panel4.Controls.Add(Me.btnConfirmOrder)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.lblCollect)
        Me.Panel4.Controls.Add(Me.dateReturn)
        Me.Panel4.Controls.Add(Me.dateCollect)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtTotalCost)
        Me.Panel4.Controls.Add(Me.txtCarMake)
        Me.Panel4.Location = New System.Drawing.Point(39, 134)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(480, 578)
        Me.Panel4.TabIndex = 38
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(217, 482)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(157, 81)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Location = New System.Drawing.Point(169, 793)
        Me.lblOrderID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(59, 17)
        Me.lblOrderID.TabIndex = 28
        Me.lblOrderID.Text = "Label12"
        '
        'txtTotalDays
        '
        Me.txtTotalDays.Location = New System.Drawing.Point(4, 789)
        Me.txtTotalDays.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalDays.Name = "txtTotalDays"
        Me.txtTotalDays.Size = New System.Drawing.Size(133, 22)
        Me.txtTotalDays.TabIndex = 32
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(139, 55)
        Me.lblCustomerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(13, 17)
        Me.lblCustomerName.TabIndex = 29
        Me.lblCustomerName.Text = "-"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Location = New System.Drawing.Point(255, 55)
        Me.lblCustomerID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(13, 17)
        Me.lblCustomerID.TabIndex = 30
        Me.lblCustomerID.Text = "-"
        '
        'btnSignOut
        '
        Me.btnSignOut.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignOut.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOut.Location = New System.Drawing.Point(978, 5)
        Me.btnSignOut.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(177, 64)
        Me.btnSignOut.TabIndex = 31
        Me.btnSignOut.Text = "Sign Out"
        Me.btnSignOut.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.comModel)
        Me.Panel2.Controls.Add(Me.comMake)
        Me.Panel2.Controls.Add(Me.panCarSearchList)
        Me.Panel2.Location = New System.Drawing.Point(25, 207)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(580, 505)
        Me.Panel2.TabIndex = 33
        '
        'dateCollectCar
        '
        Me.dateCollectCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateCollectCar.Location = New System.Drawing.Point(25, 156)
        Me.dateCollectCar.Margin = New System.Windows.Forms.Padding(4)
        Me.dateCollectCar.Name = "dateCollectCar"
        Me.dateCollectCar.Size = New System.Drawing.Size(236, 30)
        Me.dateCollectCar.TabIndex = 34
        '
        'dateReturnCar
        '
        Me.dateReturnCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateReturnCar.Location = New System.Drawing.Point(296, 156)
        Me.dateReturnCar.Margin = New System.Windows.Forms.Padding(4)
        Me.dateReturnCar.Name = "dateReturnCar"
        Me.dateReturnCar.Size = New System.Drawing.Size(223, 30)
        Me.dateReturnCar.TabIndex = 35
        '
        'btnSearchAVCars
        '
        Me.btnSearchAVCars.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearchAVCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchAVCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchAVCars.Location = New System.Drawing.Point(527, 152)
        Me.btnSearchAVCars.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchAVCars.Name = "btnSearchAVCars"
        Me.btnSearchAVCars.Size = New System.Drawing.Size(105, 34)
        Me.btnSearchAVCars.TabIndex = 18
        Me.btnSearchAVCars.Text = "Search"
        Me.btnSearchAVCars.UseVisualStyleBackColor = False
        '
        'panFrmTemplate
        '
        Me.panFrmTemplate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panFrmTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panFrmTemplate.Location = New System.Drawing.Point(13, 76)
        Me.panFrmTemplate.Margin = New System.Windows.Forms.Padding(4)
        Me.panFrmTemplate.Name = "panFrmTemplate"
        Me.panFrmTemplate.Size = New System.Drawing.Size(1281, 740)
        Me.panFrmTemplate.TabIndex = 36
        '
        'panBooking
        '
        Me.panBooking.Controls.Add(Me.Panel1)
        Me.panBooking.Controls.Add(Me.Panel5)
        Me.panBooking.Location = New System.Drawing.Point(14, 74)
        Me.panBooking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panBooking.Name = "panBooking"
        Me.panBooking.Size = New System.Drawing.Size(1280, 742)
        Me.panBooking.TabIndex = 37
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.btnSearchAVCars)
        Me.Panel5.Controls.Add(Me.dateReturnCar)
        Me.Panel5.Controls.Add(Me.dateCollectCar)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Location = New System.Drawing.Point(24, 9)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(687, 729)
        Me.Panel5.TabIndex = 36
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Location = New System.Drawing.Point(0, 14)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(713, 82)
        Me.Panel6.TabIndex = 37
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(219, 21)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(240, 42)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "BOOK HERE"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(329, 126)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(115, 25)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "Return Date"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(47, 126)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 25)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Collect Date"
        '
        'btnMyDetails
        '
        Me.btnMyDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMyDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMyDetails.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyDetails.Location = New System.Drawing.Point(776, 5)
        Me.btnMyDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMyDetails.Name = "btnMyDetails"
        Me.btnMyDetails.Size = New System.Drawing.Size(204, 64)
        Me.btnMyDetails.TabIndex = 37
        Me.btnMyDetails.Text = "My Details"
        Me.btnMyDetails.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(573, 5)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(204, 64)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "My Orders"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnBooking
        '
        Me.btnBooking.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBooking.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooking.Location = New System.Drawing.Point(370, 5)
        Me.btnBooking.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(204, 64)
        Me.btnBooking.TabIndex = 48
        Me.btnBooking.Text = "Book a Car"
        Me.btnBooking.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.Controls.Add(Me.btnBooking)
        Me.Panel3.Controls.Add(Me.btnSignOut)
        Me.Panel3.Controls.Add(Me.btnMyDetails)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.lblCarID)
        Me.Panel3.Controls.Add(Me.lblCustomerID)
        Me.Panel3.Controls.Add(Me.lblCustomerName)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1304, 74)
        Me.Panel3.TabIndex = 49
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(56, 55)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 17)
        Me.Label24.TabIndex = 33
        Me.Label24.Text = "NAME"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(211, 55)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(21, 17)
        Me.Label23.TabIndex = 32
        Me.Label23.Text = "ID"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(651, 30)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(0, 17)
        Me.Label22.TabIndex = 31
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1304, 825)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panFrmTemplate)
        Me.Controls.Add(Me.panBooking)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Customer"
        Me.Text = " "
        Me.panCarSearchList.ResumeLayout(False)
        Me.panCarSearchList.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panBooking.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstCars As System.Windows.Forms.ListBox
    Friend WithEvents panCarSearchList As System.Windows.Forms.Panel
    Friend WithEvents txtCarMake As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents comMake As System.Windows.Forms.ComboBox
    Friend WithEvents comModel As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblCarID As System.Windows.Forms.Label
    Friend WithEvents dateCollect As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateReturn As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCollect As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmOrder As System.Windows.Forms.Button
    Friend WithEvents txtCarModel As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCostPerDay As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents btnSignOut As System.Windows.Forms.Button
    Friend WithEvents lblOrderID As System.Windows.Forms.Label
    Friend WithEvents txtTotalDays As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dateCollectCar As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateReturnCar As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSearchAVCars As System.Windows.Forms.Button
    Friend WithEvents panFrmTemplate As System.Windows.Forms.Panel
    Friend WithEvents btnMyDetails As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents panBooking As Panel
    Friend WithEvents btnBooking As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
End Class
