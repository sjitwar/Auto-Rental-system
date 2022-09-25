<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarsManagement
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
        Me.panCars = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnAddToService = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.datDatePurchased = New System.Windows.Forms.DateTimePicker()
        Me.lblCarID = New System.Windows.Forms.Label()
        Me.btnServiceHistory = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDeleteCar = New System.Windows.Forms.Button()
        Me.txtRegNumber = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.butAddCar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCarModel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCarMake = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCostPerDay = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panCarSearchList = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstCars = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearchCar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSearchMake = New System.Windows.Forms.TextBox()
        Me.txtCarID = New System.Windows.Forms.TextBox()
        Me.panCars.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panCarSearchList.SuspendLayout()
        Me.SuspendLayout()
        '
        'panCars
        '
        Me.panCars.Controls.Add(Me.Panel2)
        Me.panCars.Controls.Add(Me.Panel3)
        Me.panCars.Location = New System.Drawing.Point(6, 4)
        Me.panCars.Margin = New System.Windows.Forms.Padding(4)
        Me.panCars.Name = "panCars"
        Me.panCars.Size = New System.Drawing.Size(1370, 774)
        Me.panCars.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(658, 9)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(640, 748)
        Me.Panel2.TabIndex = 16
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Location = New System.Drawing.Point(-1, 10)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(673, 84)
        Me.Panel6.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(98, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(440, 42)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "ADD CAR/CAR DETAILS"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnAddToService)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.datDatePurchased)
        Me.Panel4.Controls.Add(Me.lblCarID)
        Me.Panel4.Controls.Add(Me.btnServiceHistory)
        Me.Panel4.Controls.Add(Me.btnNew)
        Me.Panel4.Controls.Add(Me.btnDeleteCar)
        Me.Panel4.Controls.Add(Me.txtRegNumber)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.butAddCar)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtCarModel)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtCarMake)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtCostPerDay)
        Me.Panel4.Location = New System.Drawing.Point(61, 125)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(497, 569)
        Me.Panel4.TabIndex = 20
        '
        'btnAddToService
        '
        Me.btnAddToService.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddToService.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddToService.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToService.Location = New System.Drawing.Point(80, 475)
        Me.btnAddToService.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddToService.Name = "btnAddToService"
        Me.btnAddToService.Size = New System.Drawing.Size(155, 64)
        Me.btnAddToService.TabIndex = 20
        Me.btnAddToService.Text = "Add To Service"
        Me.btnAddToService.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 10)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 25)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Car ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 341)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Date Purchased"
        '
        'datDatePurchased
        '
        Me.datDatePurchased.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datDatePurchased.Location = New System.Drawing.Point(200, 334)
        Me.datDatePurchased.Margin = New System.Windows.Forms.Padding(4)
        Me.datDatePurchased.Name = "datDatePurchased"
        Me.datDatePurchased.Size = New System.Drawing.Size(219, 30)
        Me.datDatePurchased.TabIndex = 17
        '
        'lblCarID
        '
        Me.lblCarID.AutoSize = True
        Me.lblCarID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarID.Location = New System.Drawing.Point(173, 10)
        Me.lblCarID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCarID.Name = "lblCarID"
        Me.lblCarID.Size = New System.Drawing.Size(242, 25)
        Me.lblCarID.TabIndex = 1
        Me.lblCarID.Text = "<automatically generated>"
        '
        'btnServiceHistory
        '
        Me.btnServiceHistory.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnServiceHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnServiceHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceHistory.Location = New System.Drawing.Point(269, 475)
        Me.btnServiceHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.btnServiceHistory.Name = "btnServiceHistory"
        Me.btnServiceHistory.Size = New System.Drawing.Size(155, 64)
        Me.btnServiceHistory.TabIndex = 16
        Me.btnServiceHistory.Text = "Service History"
        Me.btnServiceHistory.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(200, 396)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(108, 46)
        Me.btnNew.TabIndex = 15
        Me.btnNew.Text = "NEW"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnDeleteCar
        '
        Me.btnDeleteCar.BackColor = System.Drawing.Color.Red
        Me.btnDeleteCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCar.Location = New System.Drawing.Point(350, 396)
        Me.btnDeleteCar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteCar.Name = "btnDeleteCar"
        Me.btnDeleteCar.Size = New System.Drawing.Size(116, 46)
        Me.btnDeleteCar.TabIndex = 14
        Me.btnDeleteCar.Text = "DELETE"
        Me.btnDeleteCar.UseVisualStyleBackColor = False
        '
        'txtRegNumber
        '
        Me.txtRegNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRegNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegNumber.Location = New System.Drawing.Point(177, 262)
        Me.txtRegNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegNumber.MaxLength = 8
        Me.txtRegNumber.Name = "txtRegNumber"
        Me.txtRegNumber.Size = New System.Drawing.Size(163, 30)
        Me.txtRegNumber.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(25, 270)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 25)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Reg Number"
        '
        'butAddCar
        '
        Me.butAddCar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.butAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butAddCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddCar.Location = New System.Drawing.Point(35, 396)
        Me.butAddCar.Margin = New System.Windows.Forms.Padding(4)
        Me.butAddCar.Name = "butAddCar"
        Me.butAddCar.Size = New System.Drawing.Size(111, 46)
        Me.butAddCar.TabIndex = 0
        Me.butAddCar.Text = "ADD "
        Me.butAddCar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 132)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 199)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cost Per Day"
        '
        'txtCarModel
        '
        Me.txtCarModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCarModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarModel.Location = New System.Drawing.Point(177, 124)
        Me.txtCarModel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCarModel.MaxLength = 20
        Me.txtCarModel.Name = "txtCarModel"
        Me.txtCarModel.Size = New System.Drawing.Size(161, 30)
        Me.txtCarModel.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(173, 197)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "£"
        '
        'txtCarMake
        '
        Me.txtCarMake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCarMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarMake.Location = New System.Drawing.Point(177, 55)
        Me.txtCarMake.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCarMake.MaxLength = 20
        Me.txtCarMake.Name = "txtCarMake"
        Me.txtCarMake.Size = New System.Drawing.Size(163, 30)
        Me.txtCarMake.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Make"
        '
        'txtCostPerDay
        '
        Me.txtCostPerDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostPerDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostPerDay.Location = New System.Drawing.Point(269, 192)
        Me.txtCostPerDay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostPerDay.MaxLength = 6
        Me.txtCostPerDay.Name = "txtCostPerDay"
        Me.txtCostPerDay.Size = New System.Drawing.Size(69, 30)
        Me.txtCostPerDay.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(3, 9)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(641, 748)
        Me.Panel3.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Location = New System.Drawing.Point(0, 10)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(664, 84)
        Me.Panel5.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(191, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(193, 42)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "FIND CAR"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.panCarSearchList)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnSearchCar)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtSearchMake)
        Me.Panel1.Controls.Add(Me.txtCarID)
        Me.Panel1.Location = New System.Drawing.Point(73, 125)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(504, 618)
        Me.Panel1.TabIndex = 8
        '
        'panCarSearchList
        '
        Me.panCarSearchList.Controls.Add(Me.Label9)
        Me.panCarSearchList.Controls.Add(Me.Label8)
        Me.panCarSearchList.Controls.Add(Me.lstCars)
        Me.panCarSearchList.Location = New System.Drawing.Point(37, 213)
        Me.panCarSearchList.Margin = New System.Windows.Forms.Padding(4)
        Me.panCarSearchList.Name = "panCarSearchList"
        Me.panCarSearchList.Size = New System.Drawing.Size(401, 390)
        Me.panCarSearchList.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(147, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Car Model"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Car Make"
        '
        'lstCars
        '
        Me.lstCars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCars.FormattingEnabled = True
        Me.lstCars.ItemHeight = 25
        Me.lstCars.Location = New System.Drawing.Point(35, 54)
        Me.lstCars.Margin = New System.Windows.Forms.Padding(4)
        Me.lstCars.Name = "lstCars"
        Me.lstCars.Size = New System.Drawing.Size(313, 302)
        Me.lstCars.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(173, 143)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 41)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSearchCar
        '
        Me.btnSearchCar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearchCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCar.Location = New System.Drawing.Point(37, 143)
        Me.btnSearchCar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchCar.Name = "btnSearchCar"
        Me.btnSearchCar.Size = New System.Drawing.Size(100, 41)
        Me.btnSearchCar.TabIndex = 5
        Me.btnSearchCar.Text = "Search"
        Me.btnSearchCar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 87)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 25)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Car Make"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 38)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 25)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Car ID"
        '
        'txtSearchMake
        '
        Me.txtSearchMake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchMake.Location = New System.Drawing.Point(148, 82)
        Me.txtSearchMake.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchMake.Name = "txtSearchMake"
        Me.txtSearchMake.Size = New System.Drawing.Size(190, 30)
        Me.txtSearchMake.TabIndex = 1
        '
        'txtCarID
        '
        Me.txtCarID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCarID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarID.Location = New System.Drawing.Point(147, 33)
        Me.txtCarID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCarID.Name = "txtCarID"
        Me.txtCarID.Size = New System.Drawing.Size(190, 30)
        Me.txtCarID.TabIndex = 0
        '
        'CarsManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1331, 791)
        Me.Controls.Add(Me.panCars)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CarsManagement"
        Me.Text = "StaffCars"
        Me.panCars.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panCarSearchList.ResumeLayout(False)
        Me.panCarSearchList.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panCars As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnDeleteCar As System.Windows.Forms.Button
    Friend WithEvents txtRegNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents butAddCar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCarModel As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCarMake As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCostPerDay As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents panCarSearchList As System.Windows.Forms.Panel
    Friend WithEvents lstCars As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSearchCar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSearchMake As System.Windows.Forms.TextBox
    Friend WithEvents txtCarID As System.Windows.Forms.TextBox
    Friend WithEvents lblCarID As System.Windows.Forms.Label
    Friend WithEvents btnServiceHistory As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents datDatePurchased As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnAddToService As Button
End Class
