<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnSearchAVCars = New System.Windows.Forms.Button()
        Me.dateReturnCar = New System.Windows.Forms.DateTimePicker()
        Me.dateCollectCar = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.comModel = New System.Windows.Forms.ComboBox()
        Me.comMake = New System.Windows.Forms.ComboBox()
        Me.panCarSearchList = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lstCars = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblCarID = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.txtCostPerDay = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCarModel = New System.Windows.Forms.TextBox()
        Me.btnConfirmOrder = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCollect = New System.Windows.Forms.Label()
        Me.dateReturn = New System.Windows.Forms.DateTimePicker()
        Me.dateCollect = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.txtCarMake = New System.Windows.Forms.TextBox()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.txtTotalDays = New System.Windows.Forms.TextBox()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panCarSearchList.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel5.Location = New System.Drawing.Point(12, 4)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(687, 729)
        Me.Panel5.TabIndex = 37
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
        'dateReturnCar
        '
        Me.dateReturnCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateReturnCar.Location = New System.Drawing.Point(296, 156)
        Me.dateReturnCar.Margin = New System.Windows.Forms.Padding(4)
        Me.dateReturnCar.Name = "dateReturnCar"
        Me.dateReturnCar.Size = New System.Drawing.Size(223, 30)
        Me.dateReturnCar.TabIndex = 35
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.lblOrderID)
        Me.Panel1.Controls.Add(Me.txtTotalDays)
        Me.Panel1.Location = New System.Drawing.Point(711, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 728)
        Me.Panel1.TabIndex = 38
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel7.Controls.Add(Me.lblCarID)
        Me.Panel7.Controls.Add(Me.Label21)
        Me.Panel7.Location = New System.Drawing.Point(0, 15)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(577, 82)
        Me.Panel7.TabIndex = 38
        '
        'lblCarID
        '
        Me.lblCarID.AutoSize = True
        Me.lblCarID.Location = New System.Drawing.Point(442, 30)
        Me.lblCarID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCarID.Name = "lblCarID"
        Me.lblCarID.Size = New System.Drawing.Size(47, 17)
        Me.lblCarID.TabIndex = 38
        Me.lblCarID.Text = "Car ID"
        Me.lblCarID.Visible = False
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
        Me.Panel4.Controls.Add(Me.btnCancelOrder)
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
        'btnCancelOrder
        '
        Me.btnCancelOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelOrder.Location = New System.Drawing.Point(217, 482)
        Me.btnCancelOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(157, 81)
        Me.btnCancelOrder.TabIndex = 33
        Me.btnCancelOrder.Text = "Cancel"
        Me.btnCancelOrder.UseVisualStyleBackColor = False
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
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1281, 740)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Booking"
        Me.Text = "Booking"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panCarSearchList.ResumeLayout(False)
        Me.panCarSearchList.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnSearchAVCars As Button
    Friend WithEvents dateReturnCar As DateTimePicker
    Friend WithEvents dateCollectCar As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents comModel As ComboBox
    Friend WithEvents comMake As ComboBox
    Friend WithEvents panCarSearchList As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents lstCars As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents txtCostPerDay As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCarModel As TextBox
    Friend WithEvents btnConfirmOrder As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents lblCollect As Label
    Friend WithEvents dateReturn As DateTimePicker
    Friend WithEvents dateCollect As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents txtCarMake As TextBox
    Friend WithEvents lblOrderID As Label
    Friend WithEvents txtTotalDays As TextBox
    Friend WithEvents lblCarID As Label
End Class
