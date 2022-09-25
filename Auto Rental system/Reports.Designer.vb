<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Me.dateStart = New System.Windows.Forms.DateTimePicker()
        Me.dateEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCar7Days = New System.Windows.Forms.Button()
        Me.btnCarLastMonth = New System.Windows.Forms.Button()
        Me.btnShowCars = New System.Windows.Forms.Button()
        Me.lstPosition = New System.Windows.Forms.ListBox()
        Me.lstCars = New System.Windows.Forms.ListBox()
        Me.lstCarPopularity = New System.Windows.Forms.ListBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panMostPopularCustomers = New System.Windows.Forms.Panel()
        Me.panTemp = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNumOfBookings = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.txtTotalRevenue = New System.Windows.Forms.TextBox()
        Me.DateREnd = New System.Windows.Forms.DateTimePicker()
        Me.dateRStart = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnCustLastMonth = New System.Windows.Forms.Button()
        Me.btnCust7Days = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lstCustPopularity = New System.Windows.Forms.ListBox()
        Me.lstPos = New System.Windows.Forms.ListBox()
        Me.lstCustomers = New System.Windows.Forms.ListBox()
        Me.btnShowCustomers = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnRev7Days = New System.Windows.Forms.Button()
        Me.btnRevLastMonth = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panMostPopularCustomers.SuspendLayout()
        Me.panTemp.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dateStart
        '
        Me.dateStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateStart.Location = New System.Drawing.Point(100, 90)
        Me.dateStart.Margin = New System.Windows.Forms.Padding(4)
        Me.dateStart.Name = "dateStart"
        Me.dateStart.Size = New System.Drawing.Size(224, 30)
        Me.dateStart.TabIndex = 4
        '
        'dateEnd
        '
        Me.dateEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateEnd.Location = New System.Drawing.Point(100, 128)
        Me.dateEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.dateEnd.Name = "dateEnd"
        Me.dateEnd.Size = New System.Drawing.Size(224, 30)
        Me.dateEnd.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 133)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "To"
        '
        'btnCar7Days
        '
        Me.btnCar7Days.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCar7Days.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCar7Days.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCar7Days.Location = New System.Drawing.Point(17, 188)
        Me.btnCar7Days.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCar7Days.Name = "btnCar7Days"
        Me.btnCar7Days.Size = New System.Drawing.Size(187, 42)
        Me.btnCar7Days.TabIndex = 8
        Me.btnCar7Days.Text = "Last 7 days"
        Me.btnCar7Days.UseVisualStyleBackColor = False
        '
        'btnCarLastMonth
        '
        Me.btnCarLastMonth.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCarLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCarLastMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarLastMonth.Location = New System.Drawing.Point(229, 188)
        Me.btnCarLastMonth.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCarLastMonth.Name = "btnCarLastMonth"
        Me.btnCarLastMonth.Size = New System.Drawing.Size(187, 42)
        Me.btnCarLastMonth.TabIndex = 9
        Me.btnCarLastMonth.Text = "Last Month"
        Me.btnCarLastMonth.UseVisualStyleBackColor = False
        '
        'btnShowCars
        '
        Me.btnShowCars.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnShowCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShowCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowCars.Location = New System.Drawing.Point(332, 104)
        Me.btnShowCars.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowCars.Name = "btnShowCars"
        Me.btnShowCars.Size = New System.Drawing.Size(84, 42)
        Me.btnShowCars.TabIndex = 10
        Me.btnShowCars.Text = " Show"
        Me.btnShowCars.UseVisualStyleBackColor = False
        '
        'lstPosition
        '
        Me.lstPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPosition.FormattingEnabled = True
        Me.lstPosition.ItemHeight = 25
        Me.lstPosition.Location = New System.Drawing.Point(9, 32)
        Me.lstPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.lstPosition.Name = "lstPosition"
        Me.lstPosition.Size = New System.Drawing.Size(54, 329)
        Me.lstPosition.TabIndex = 11
        '
        'lstCars
        '
        Me.lstCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCars.FormattingEnabled = True
        Me.lstCars.ItemHeight = 25
        Me.lstCars.Location = New System.Drawing.Point(68, 32)
        Me.lstCars.Margin = New System.Windows.Forms.Padding(4)
        Me.lstCars.Name = "lstCars"
        Me.lstCars.Size = New System.Drawing.Size(284, 329)
        Me.lstCars.TabIndex = 12
        '
        'lstCarPopularity
        '
        Me.lstCarPopularity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCarPopularity.FormattingEnabled = True
        Me.lstCarPopularity.ItemHeight = 25
        Me.lstCarPopularity.Location = New System.Drawing.Point(357, 32)
        Me.lstCarPopularity.Margin = New System.Windows.Forms.Padding(4)
        Me.lstCarPopularity.Name = "lstCarPopularity"
        Me.lstCarPopularity.Size = New System.Drawing.Size(55, 329)
        Me.lstCarPopularity.TabIndex = 13
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(-1, 7)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(541, 53)
        Me.Panel6.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 12)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(233, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Most Popular Car Make..."
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.btnShowCars)
        Me.Panel3.Controls.Add(Me.btnCarLastMonth)
        Me.Panel3.Controls.Add(Me.btnCar7Days)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.dateEnd)
        Me.Panel3.Controls.Add(Me.dateStart)
        Me.Panel3.Location = New System.Drawing.Point(436, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(444, 749)
        Me.Panel3.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.lstCarPopularity)
        Me.Panel2.Controls.Add(Me.lstCars)
        Me.Panel2.Controls.Add(Me.lstPosition)
        Me.Panel2.Location = New System.Drawing.Point(9, 258)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(425, 384)
        Me.Panel2.TabIndex = 14
        '
        'panMostPopularCustomers
        '
        Me.panMostPopularCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panMostPopularCustomers.Controls.Add(Me.Panel3)
        Me.panMostPopularCustomers.Controls.Add(Me.panTemp)
        Me.panMostPopularCustomers.Controls.Add(Me.Panel5)
        Me.panMostPopularCustomers.Location = New System.Drawing.Point(2, 13)
        Me.panMostPopularCustomers.Margin = New System.Windows.Forms.Padding(4)
        Me.panMostPopularCustomers.Name = "panMostPopularCustomers"
        Me.panMostPopularCustomers.Size = New System.Drawing.Size(1374, 752)
        Me.panMostPopularCustomers.TabIndex = 15
        '
        'panTemp
        '
        Me.panTemp.BackColor = System.Drawing.SystemColors.Control
        Me.panTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panTemp.Controls.Add(Me.Panel8)
        Me.panTemp.Controls.Add(Me.Panel1)
        Me.panTemp.Location = New System.Drawing.Point(888, 1)
        Me.panTemp.Name = "panTemp"
        Me.panTemp.Size = New System.Drawing.Size(437, 750)
        Me.panTemp.TabIndex = 17
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.Controls.Add(Me.btnRevLastMonth)
        Me.Panel8.Controls.Add(Me.btnRev7Days)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Controls.Add(Me.txtNumOfBookings)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.Label12)
        Me.Panel8.Controls.Add(Me.btnShow)
        Me.Panel8.Controls.Add(Me.txtTotalRevenue)
        Me.Panel8.Controls.Add(Me.DateREnd)
        Me.Panel8.Controls.Add(Me.dateRStart)
        Me.Panel8.Location = New System.Drawing.Point(7, 66)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(440, 547)
        Me.Panel8.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(158, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(227, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "(Bookings that have been paid for)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "No. Of Bookings"
        '
        'txtNumOfBookings
        '
        Me.txtNumOfBookings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOfBookings.Location = New System.Drawing.Point(192, 261)
        Me.txtNumOfBookings.Name = "txtNumOfBookings"
        Me.txtNumOfBookings.Size = New System.Drawing.Size(143, 30)
        Me.txtNumOfBookings.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 396)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 25)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Total Revenue"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 17)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "To"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "From"
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(282, 37)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(98, 42)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'txtTotalRevenue
        '
        Me.txtTotalRevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRevenue.Location = New System.Drawing.Point(207, 391)
        Me.txtTotalRevenue.Name = "txtTotalRevenue"
        Me.txtTotalRevenue.Size = New System.Drawing.Size(143, 30)
        Me.txtTotalRevenue.TabIndex = 2
        '
        'DateREnd
        '
        Me.DateREnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateREnd.Location = New System.Drawing.Point(60, 66)
        Me.DateREnd.Name = "DateREnd"
        Me.DateREnd.Size = New System.Drawing.Size(216, 30)
        Me.DateREnd.TabIndex = 1
        '
        'dateRStart
        '
        Me.dateRStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateRStart.Location = New System.Drawing.Point(60, 18)
        Me.dateRStart.Name = "dateRStart"
        Me.dateRStart.Size = New System.Drawing.Size(216, 30)
        Me.dateRStart.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(0, 6)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 53)
        Me.Panel1.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 12)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Total Revenue"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnCustLastMonth)
        Me.Panel5.Controls.Add(Me.btnCust7Days)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.btnShowCustomers)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.dateTo)
        Me.Panel5.Controls.Add(Me.dateFrom)
        Me.Panel5.Location = New System.Drawing.Point(4, 1)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(426, 750)
        Me.Panel5.TabIndex = 15
        '
        'btnCustLastMonth
        '
        Me.btnCustLastMonth.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCustLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustLastMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustLastMonth.Location = New System.Drawing.Point(227, 188)
        Me.btnCustLastMonth.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustLastMonth.Name = "btnCustLastMonth"
        Me.btnCustLastMonth.Size = New System.Drawing.Size(187, 42)
        Me.btnCustLastMonth.TabIndex = 13
        Me.btnCustLastMonth.Text = "Last Month"
        Me.btnCustLastMonth.UseVisualStyleBackColor = False
        '
        'btnCust7Days
        '
        Me.btnCust7Days.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCust7Days.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCust7Days.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCust7Days.Location = New System.Drawing.Point(21, 188)
        Me.btnCust7Days.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCust7Days.Name = "btnCust7Days"
        Me.btnCust7Days.Size = New System.Drawing.Size(187, 42)
        Me.btnCust7Days.TabIndex = 12
        Me.btnCust7Days.Text = "Last 7 Days"
        Me.btnCust7Days.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Location = New System.Drawing.Point(1, 7)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(535, 53)
        Me.Panel7.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Most Popular Customers..."
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.lstCustPopularity)
        Me.Panel4.Controls.Add(Me.lstPos)
        Me.Panel4.Controls.Add(Me.lstCustomers)
        Me.Panel4.Location = New System.Drawing.Point(6, 258)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(408, 384)
        Me.Panel4.TabIndex = 14
        '
        'lstCustPopularity
        '
        Me.lstCustPopularity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCustPopularity.FormattingEnabled = True
        Me.lstCustPopularity.ItemHeight = 25
        Me.lstCustPopularity.Location = New System.Drawing.Point(344, 35)
        Me.lstCustPopularity.Margin = New System.Windows.Forms.Padding(4)
        Me.lstCustPopularity.Name = "lstCustPopularity"
        Me.lstCustPopularity.Size = New System.Drawing.Size(56, 329)
        Me.lstCustPopularity.TabIndex = 13
        '
        'lstPos
        '
        Me.lstPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPos.FormattingEnabled = True
        Me.lstPos.ItemHeight = 25
        Me.lstPos.Location = New System.Drawing.Point(4, 35)
        Me.lstPos.Margin = New System.Windows.Forms.Padding(4)
        Me.lstPos.Name = "lstPos"
        Me.lstPos.Size = New System.Drawing.Size(54, 329)
        Me.lstPos.TabIndex = 1
        '
        'lstCustomers
        '
        Me.lstCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.ItemHeight = 25
        Me.lstCustomers.Location = New System.Drawing.Point(63, 35)
        Me.lstCustomers.Margin = New System.Windows.Forms.Padding(4)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(276, 329)
        Me.lstCustomers.TabIndex = 0
        '
        'btnShowCustomers
        '
        Me.btnShowCustomers.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnShowCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShowCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowCustomers.Location = New System.Drawing.Point(325, 104)
        Me.btnShowCustomers.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowCustomers.Name = "btnShowCustomers"
        Me.btnShowCustomers.Size = New System.Drawing.Size(89, 42)
        Me.btnShowCustomers.TabIndex = 11
        Me.btnShowCustomers.Text = "Show"
        Me.btnShowCustomers.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 133)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "From"
        '
        'dateTo
        '
        Me.dateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTo.Location = New System.Drawing.Point(105, 128)
        Me.dateTo.Margin = New System.Windows.Forms.Padding(4)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(212, 30)
        Me.dateTo.TabIndex = 3
        '
        'dateFrom
        '
        Me.dateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFrom.Location = New System.Drawing.Point(105, 90)
        Me.dateFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(212, 30)
        Me.dateFrom.TabIndex = 2
        '
        'btnRev7Days
        '
        Me.btnRev7Days.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRev7Days.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRev7Days.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRev7Days.Location = New System.Drawing.Point(17, 121)
        Me.btnRev7Days.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRev7Days.Name = "btnRev7Days"
        Me.btnRev7Days.Size = New System.Drawing.Size(187, 42)
        Me.btnRev7Days.TabIndex = 10
        Me.btnRev7Days.Text = "Last 7 days"
        Me.btnRev7Days.UseVisualStyleBackColor = False
        '
        'btnRevLastMonth
        '
        Me.btnRevLastMonth.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRevLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRevLastMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRevLastMonth.Location = New System.Drawing.Point(235, 121)
        Me.btnRevLastMonth.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRevLastMonth.Name = "btnRevLastMonth"
        Me.btnRevLastMonth.Size = New System.Drawing.Size(187, 42)
        Me.btnRevLastMonth.TabIndex = 18
        Me.btnRevLastMonth.Text = "Last Month"
        Me.btnRevLastMonth.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(68, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(250, 17)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Cust ID           First Name       Surname"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 17)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Position"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(341, -3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 17)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "No. Of"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(354, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 17)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Bookings"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(354, -4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 17)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "No. Of"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(337, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 17)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Bookings"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 11)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 17)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Position"
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1331, 791)
        Me.Controls.Add(Me.panMostPopularCustomers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Reports"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panMostPopularCustomers.ResumeLayout(False)
        Me.panTemp.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCar7Days As System.Windows.Forms.Button
    Friend WithEvents btnCarLastMonth As System.Windows.Forms.Button
    Friend WithEvents btnShowCars As System.Windows.Forms.Button
    Friend WithEvents lstPosition As System.Windows.Forms.ListBox
    Friend WithEvents lstCars As System.Windows.Forms.ListBox
    Friend WithEvents lstCarPopularity As System.Windows.Forms.ListBox
    Friend WithEvents panMostPopularCustomers As System.Windows.Forms.Panel
    Friend WithEvents btnShowCustomers As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lstPos As System.Windows.Forms.ListBox
    Friend WithEvents lstCustomers As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstCustPopularity As System.Windows.Forms.ListBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnCustLastMonth As System.Windows.Forms.Button
    Friend WithEvents btnCust7Days As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents panTemp As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNumOfBookings As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents txtTotalRevenue As TextBox
    Friend WithEvents DateREnd As DateTimePicker
    Friend WithEvents dateRStart As DateTimePicker
    Friend WithEvents btnRevLastMonth As Button
    Friend WithEvents btnRev7Days As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
End Class
