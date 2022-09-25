Imports System.Data.OleDb
Public Class OrdersManagement



    Private Sub Orders_Load(sender As Object, e As EventArgs)

        dateCollected.Value = Now
        dateReturned.Value = Now
    End Sub

    Private Sub SearchOrderCollect(OrderDate As String)

        'finds and displays all order that are due to be collected in the date in the parameter.

        If DbConnect() Then
            lstOrdersCollect.Items.Clear()
            Dim SQLCmd As New OleDbCommand

            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders Where StartDate = @CollectedDate And Collected = False"
                .Parameters.AddWithValue("@CollectedDate", dateCollected.Value.Date)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    Dim DisplayValue As String = rs("OrderID") & "                 " & rs("CustomerID") & "                " & rs("CarID") & "              "
                    Dim OrderItem As New ListBoxData(DisplayValue, rs("OrderID"))
                    lstOrdersCollect.Items.Add(OrderItem)
                End While
                rs.Close()


                If lstOrdersCollect.Items.Count = 0 Then
                    MessageBox.Show("There are no orders being collected today", "Search Orders", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    lstOrdersCollect.SelectedIndex = 0
                End If

            End With
            cn.Close()




        End If



    End Sub





    Private Sub Orders_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        datCollect.MinDate = Today.Date
        datReturn.MinDate = Today.AddDays(+1)

        btnUpdateOrder.Visible = False
        panReturnDetails.Visible = False
        panAmendOrder.Visible = False
        btnAmend.Enabled = False
        btnDeleteOrder.Enabled = False

        DeleteOrdersNotCollected()

    End Sub
    Private Sub DeleteOrdersNotCollected()

        'deletes all orders that ahve not been collected on time

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Delete * From tblOrders Where (StartDate < @TodayDate) and (Collected = False)"
                .Parameters.AddWithValue("@TodayDate", Today.Date)
                .ExecuteNonQuery()
                'btnClear.PerformClick()
            End With
            cn.Close()
            'btnClear.PerformClick()
        End If


    End Sub

    Private Sub btnSearchOrder_Click(sender As Object, e As EventArgs) Handles btnSearchOrdersCollect.Click
        panCollectODetails.Visible = True
        SearchOrderCollect(dateCollected.Value.Date)


    End Sub

    Private Sub clstOrders_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub lstOrdersCollect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOrdersCollect.SelectedIndexChanged
        If lstOrdersCollect.SelectedItem IsNot Nothing Then
            Dim SelectedOrder As ListBoxData = lstOrdersCollect.SelectedItem

            DisplayCollectOrderDetails(SelectedOrder.Identifier)

            btnAmend.Enabled = True
            btnDeleteOrder.Enabled = True


        End If
    End Sub
    Private Sub DisplayCollectOrderDetails(OrderID As Integer)
        'displays the order details of the order with the order id specified in the parameter
        'Selects fields from three tables

        txtFirstname.Text = ""
        txtSurname.Text = ""

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn

                .CommandText = "Select * " &
                    "From (tblOrders " &
                    "inner join Cars on tblOrders.CarID = Cars.CarID) " &
                    "inner join Customer on tblOrders.CustomerID = Customer.CustomerID " &
                    "Where (OrderID = @OrderID) and (tblOrders.CarID = Cars.CarID) and (tblOrders.CustomerID = Customer.CustomerID)"
                .Parameters.AddWithValue("@OrderID", OrderID)




                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read

                    lblOrderID.Text = rs("OrderID")
                    txtFirstname.Text = rs("Firstname")
                    txtSurname.Text = rs("Surname")
                    lblCarID.Text = rs("tblOrders.CarID")
                    datStart.Value = rs("StartDate")
                    dateReturn.Value = rs("ReturnDate")
                    txtTotalCost.Text = rs("TotalCost")
                    txtCarMake.Text = rs("CarMake")
                    txtCarModel.Text = rs("CarModel")
                    txtCostPerDay.Text = rs("CostPerDay")
                End While
                rs.Close()
            End With
            cn.Close()
        End If
        CHCarReturned()

    End Sub


    Private Sub CHCarReturned()
        ' checks if the order being collected contain a car that has not yet been returned

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders where CarID = @CarID and Collected = True and Returned = False"
                .Parameters.AddWithValue("@CarID", lblCarID.Text)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    If lblCarID.Text = rs("CarID") Then
                        btnCollected.Enabled = False
                        MessageBox.Show("This order contains a car that has not yet been returned, " &
                            " please select a different car")
                        panOrdersList.Visible = False
                        panAmendOrder.Visible = True
                        btnUpdateOrder.Visible = True
                        txtCarMake.Text = ""
                        txtCarMake.Text = ""
                        txtCostPerDay.Text = ""
                        txtTotalCost.Text = ""

                    Else
                        btnCollected.Enabled = True
                    End If
                End While
                rs.Close()
            End With
            cn.Close()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFirstname.TextChanged

    End Sub

    Private Sub btnCollected_Click(sender As Object, e As EventArgs) Handles btnCollected.Click

        If lstOrdersCollect.SelectedItem IsNot Nothing Then
            Dim SelectedOrder As ListBoxData = lstOrdersCollect.SelectedItem
            CollectedOrder(SelectedOrder.Identifier)
            btnSearchOrdersCollect.PerformClick()


        End If

    End Sub

    Private Sub CollectedOrder(SelectedOrder As Integer)

        'updates slected order from the list box to collected.

        Dim Collected As Boolean
        Dim CurrentDate As Date

        CurrentDate = Now
        Collected = True

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand

            With SQLCmd
                .Connection = cn
                .CommandText = "Update tblOrders Set CollectedDate = @CollectedDate, Collected = @Collected, StaffIDCollect = @StaffID Where OrderID = @SelectedOrder"
                .Parameters.AddWithValue("@CollectedDate", CurrentDate.Date)
                .Parameters.AddWithValue("@Collected", Collected)
                .Parameters.AddWithValue("@StaffID", Staff.lblStaffID.Text)
                .Parameters.AddWithValue("@SelectedOrder", SelectedOrder)

                .ExecuteNonQuery()
            End With
        End If
        cn.Close()
        MessageBox.Show("Order Collected")

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOrdersReturn.SelectedIndexChanged
        If lstOrdersReturn.SelectedItem IsNot Nothing Then
            Dim SelectedOrder As ListBoxData = lstOrdersReturn.SelectedItem

            DisplayReturnOrderDetails(SelectedOrder.Identifier)

            panReturnDetails.Visible = True
            panAmendOrder.Visible = False
            panOrdersList.Visible = False
            btnDeleteOrder.Enabled = True
        End If
    End Sub
    Private Sub DisplayReturnOrderDetails(OrderID As Integer)

        'Displays details of the order being returend

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn

                .CommandText = "Select * " &
                    "From (tblOrders " &
                    "inner join Cars on tblOrders.CarID = Cars.CarID) " &
                    "inner join Customer on tblOrders.CustomerID = Customer.CustomerID " &
                    "Where (OrderID = @OrderID) and (tblOrders.CarID = Cars.CarID) and (tblOrders.CustomerID = Customer.CustomerID)"
                .Parameters.AddWithValue("@OrderID", OrderID)




                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read

                    lblOrderID.Text = rs("OrderID")
                    txtFirstname.Text = rs("Firstname")
                    txtSurname.Text = rs("Surname")
                    lblCarID.Text = rs("tblOrders.CarID")
                    datStart.Value = rs("StartDate")
                    dateReturn.Value = rs("ReturnDate")
                    txtTotalCost.Text = rs("TotalCost")
                    txtCarMake.Text = rs("CarMake")
                    txtCarModel.Text = rs("CarModel")
                    txtCostPerDay.Text = rs("CostPerDay")
                End While
                rs.Close()
            End With
            cn.Close()
        End If

    End Sub
    Private Sub DisplayRCarDetails(OrderID As Integer)

        txtCarMake.Text = ""
        txtCarModel.Text = ""

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders, Cars Where (OrderID = @SearchID) And (tblOrders.CarID = Cars.CarID)"
                .Parameters.AddWithValue("@SearchID", OrderID)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    txtCarMake.Text = rs("CarMake")
                    txtCarModel.Text = rs("CarModel")
                    txtCostPerDay.Text = rs("CostPerDay")


                End While
                rs.Close()
            End With
            cn.Close()

        End If
        'CHCarReturned()
    End Sub
    Private Sub DisplayRCustomerName(OrderID As Integer)

        txtFirstname.Text = ""
        txtSurname.Text = ""

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders, Customer Where (OrderID = @SearchID) And (tblOrders.CustomerID = Customer.CustomerID)"
                .Parameters.AddWithValue("@SearchID", OrderID)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    'Dim DisplayValue As String = rs("Firstname")
                    'txtFirstname.Text = DisplayValue
                    lblOrderID.Text = rs("OrderID")
                    txtFirstname.Text = rs("Firstname")
                    txtSurname.Text = rs("Surname")
                    lblCarID.Text = rs("CarID")
                    datStart.Value = rs("StartDate")
                    dateReturn.Value = rs("ReturnDate")

                    txtTotalCost.Text = rs("TotalCost")
                End While
                rs.Close()
            End With
            cn.Close()
        End If

    End Sub


    Private Sub BtnSearchOrdersReturn_Click(sender As Object, e As EventArgs) Handles btnSearchOrdersReturn.Click

        'panCollectODetails.Visible = False
        'panReturnODetails.Visible = True

        If DbConnect() Then
            lstOrdersReturn.Items.Clear()
            Dim SQLCmd As New OleDbCommand

            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders Where ReturnDate = @ReturnedDate And Returned = False And Collected = True"
                .Parameters.AddWithValue("@ReturnedDate", dateReturned.Value.Date)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    Dim DisplayValue As String = rs("OrderID") & "                 " & rs("CustomerID") & "                 " & rs("CarID") & "              "
                    Dim OrderItem As New ListBoxData(DisplayValue, rs("OrderID"))
                    lstOrdersReturn.Items.Add(OrderItem)
                End While
                rs.Close()
                If lstOrdersCollect.Items.Count = 0 Then
                    MessageBox.Show("There are no orders being Returned today", "Search Orders", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    lstOrdersCollect.SelectedIndex = 0
                End If

            End With
            cn.Close()

        End If
    End Sub

    Private Sub BtnReturned_Click(sender As Object, e As EventArgs) Handles btnReturned.Click
        If lstOrdersReturn.SelectedItem IsNot Nothing Then

            Dim SelectedOrder As ListBoxData = lstOrdersReturn.SelectedItem
            ReturnedOrder(SelectedOrder.Identifier)

        End If


        If AddService.Checked = True Then
            Dim SelectedOrder As ListBoxData = lstOrdersReturn.SelectedItem

            AddToService(SelectedOrder.Identifier)

        End If

        panReturnDetails.Visible = False
        panOrdersList.Visible = True
        btnSearchOrdersReturn.PerformClick()

    End Sub

    Private Sub AddToService(SelectedOrder As Integer) 'Adding a returned car to service

        Dim CarIDs As Integer
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select CarID From tblOrders where (OrderID = @SelectedOrder)"
                .Parameters.AddWithValue("@SelectedOrder", SelectedOrder)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    CarIDs = rs("CarID")
                End While
                rs.Close()

            End With
            cn.Close()
        End If

        If DbConnect() Then                                                                     'ADDING RETURNED CARS TO SERVICE
            Dim SQLCmd As New OleDbCommand

            With SQLCmd
                .Connection = cn
                .CommandText = "Insert into Service (CarID) Values (@CarID)"

                .Parameters.AddWithValue("@CarID", CarIDs)
                .ExecuteNonQuery()
            End With

        End If
        cn.Close()
    End Sub
    Private Sub ReturnedOrder(SelectedOrder As Integer)

        'Updating slected order from the list box to Returned.

        Dim Returned As Boolean 'Set to true
        Dim CurrentDate As Date 'holds the current date

        CurrentDate = Now
        Returned = True

        If checkPaid.Checked = True Then

            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand

                With SQLCmd
                    .Connection = cn
                    .CommandText = "Update tblOrders Set ReturnedDate = @ReturnedDate, Returned = @Returned, StaffIDReturn = @StaffID, Paid = True, ReturnComments = @Comments, StaffIDPaid = @StaffIDPaid, PenaltyCost = @PenaltyCost, PaidDate = @ReturnedDate Where OrderID = @SelectedOrder"
                    .Parameters.AddWithValue("@ReturnedDate", CurrentDate.Date)
                    .Parameters.AddWithValue("@Returned", Returned)
                    .Parameters.AddWithValue("@StaffID", Staff.lblStaffID.Text)
                    .Parameters.AddWithValue("@Comments", txtComments.Text)
                    .Parameters.AddWithValue("@StaffIDPaid", Staff.lblStaffID.Text)
                    .Parameters.AddWithValue("@PenaltyCost", txtTotalPenaltyCost.Text)
                    .Parameters.AddWithValue("@SelectedOrder", SelectedOrder)

                    .ExecuteNonQuery()
                End With
            End If
            cn.Close()
            MessageBox.Show("Order Returned")
        Else

            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand

                With SQLCmd
                    .Connection = cn
                    .CommandText = "Update tblOrders Set ReturnedDate = @ReturnedDate, Returned = @Returned, StaffIDReturn = @StaffID, ReturnComments = @Comments, PenaltyCost = @PenaltyCost Where OrderID = @SelectedOrder"
                    .Parameters.AddWithValue("@ReturnedDate", CurrentDate.Date)
                    .Parameters.AddWithValue("@Returned", Returned)
                    .Parameters.AddWithValue("@StaffID", Staff.lblStaffID.Text)
                    .Parameters.AddWithValue("@Comments", txtComments.Text)
                    .Parameters.AddWithValue("@PenaltyCost", txtTotalPenaltyCost.Text)
                    .Parameters.AddWithValue("@SelectedOrder", SelectedOrder)

                    .ExecuteNonQuery()
                End With

            End If
            cn.Close()
            MessageBox.Show("Order Returned")

        End If

    End Sub

    Private Sub btnSendService_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dateCollected_ValueChanged(sender As Object, e As EventArgs) Handles dateCollected.ValueChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtComments.TextChanged

    End Sub

    Private Sub txtAddService_Paint(sender As Object, e As PaintEventArgs) Handles panReturnDetails.Paint

    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs) Handles txtTotalPenaltyCost.TextChanged

    End Sub

    Private Sub txtCalculatePenalty_Click(sender As Object, e As EventArgs) Handles btnTotal.Click

        Dim TotalPenaltyCost As Integer = 0
        Dim TyresCost As Integer = 40
        Dim ScratchesCost As Integer = 20
        Dim InteriorCost As Integer = 50
        Dim CarBodyCost As Integer = 50



        If checkTyres.Checked = True Then

            TotalPenaltyCost = TotalPenaltyCost + TyresCost

        End If

        If checkScratches.Checked = True Then
            TotalPenaltyCost = TotalPenaltyCost + ScratchesCost
        End If
        If checkInterior.Checked = True Then
            TotalPenaltyCost = TotalPenaltyCost + InteriorCost
        End If
        If checkCarBody.Checked = True Then
            TotalPenaltyCost = TotalPenaltyCost + CarBodyCost

        End If

        txtTotalPenaltyCost.Text = TotalPenaltyCost


    End Sub


    Private Sub AddService_CheckedChanged(sender As Object, e As EventArgs) Handles AddService.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        OverDueOrders.Show()
    End Sub

    Private Sub btnAmend_Click(sender As Object, e As EventArgs) Handles btnAmend.Click

        panAmendOrder.Visible = True
        panOrdersList.Visible = False
        panReturnDetails.Visible = False
    End Sub

    Private Sub txtTotalCost_TextChanged(sender As Object, e As EventArgs) Handles txtTotalCost.TextChanged

    End Sub

    Private Sub lstCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCars.SelectedIndexChanged

        If lstCars.SelectedItem IsNot Nothing Then
            Dim SelectedCar As ListBoxData = lstCars.SelectedItem
            DisplayCar(SelectedCar.Identifier)
        End If
    End Sub
    Private Sub DisplayCar(CarID As Integer)                                 'SEARCHING CAR BY ID AND THEN DISPLAY

        Dim DBCostPerDay As Integer



        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            SQLCmd.Connection = cn
            SQLCmd.CommandText = "Select * From Cars Where CarID = @CarID"
            SQLCmd.Parameters.AddWithValue("@CarID", CarID)
            Dim rs As OleDbDataReader = SQLCmd.ExecuteReader()

            If rs.Read Then
                lblCarID.Text = rs("CarID")
                txtCarMake.Text = rs("CarMake")
                txtCarModel.Text = rs("CarModel")
                txtCostPerDay.Text = rs("CostPerDay")
                datStart.Value = datCollect.Value
                dateReturn.Value = datReturn.Value

                DBCostPerDay = rs("CostPerDay")

                Dim CollectDate As Date
                Dim ReturnDate As Date = CollectDate.AddDays(4.0#)

                CollectDate = datCollect.Value.Date
                ReturnDate = datReturn.Value.Date

                Dim span = ReturnDate - CollectDate
                Dim Days As Double = span.TotalDays

                Dim CostPerDay As Integer
                Dim TotalCost As Integer
                CostPerDay = DBCostPerDay
                TotalCost = CostPerDay * Days
                txtTotalCost.Text = TotalCost

                'txtRegNumber.Text = rs("RegNumber")
                'butEditCar.Enabled = True

                btnUpdateOrder.Visible = True
            End If
            rs.Close()
            cn.Close()
        End If
        CHCarReturned()
        CHCarInService()

    End Sub
    Private Sub CHCarInService()

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Service where CarID = @CarID and Repaired = False"
                .Parameters.AddWithValue("@CarID", lblCarID.Text)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    If lblCarID.Text = rs("CarID") Then
                        btnUpdateOrder.Enabled = False
                        MessageBox.Show("This car is currently in service, please select a different car")

                    Else
                        btnUpdateOrder.Enabled = True
                    End If
                End While
                rs.Close()
            End With
            cn.Close()
        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comMake.SelectedIndexChanged
        DisplayAvailableCars(datCollect.Value.Date, datReturn.Value.Date, comMake.Text, comModel.Text)
    End Sub

    Private Sub BtnSearchAVCars_Click(sender As Object, e As EventArgs) Handles btnSearchAVCars.Click
        DisplayAvailableCars(datCollect.Value.Date, datReturn.Value.Date, comMake.Text, comModel.Text)
    End Sub
    Private Sub DisplayAvailableCars(CollectDate As String, ReturnDate As String, ByVal SelectedMake As String, ByVal SelectedModel As String)

        If DbConnect() Then

            lstCars.Items.Clear()
            comMake.Items.Clear()
            comModel.Items.Clear()

            If SelectedMake = "" Then
                SelectedMake = "-1"
            End If
            If SelectedModel = "" Then
                SelectedModel = "-1"
            End If
            Dim SQLcmd As New OleDbCommand
            With SQLcmd
                .Connection = cn
                .CommandText = "Select Cars.CarID, Cars.CarMake, Cars.CarModel, Cars.RegNumber " &
                               "From Cars " &
                               "Where (Not Exists(Select * From tblOrders Where tblOrders.CarID = Cars.CarID and tblOrders.ReturnDate >= @StartDate and tblOrders.StartDate <= @EndDate)) " &
                               "and (@SelectedMake = '-1' or Cars.CarMake = @SelectedMake) and (@SelectedModel = '-1' or Cars.CarModel = @SelectedModel)"


                .Parameters.AddWithValue("@StartDate", datCollect.Value.Date)
                .Parameters.AddWithValue("@EndDate", datReturn.Value.Date)
                .Parameters.AddWithValue("@SelectedMake", SelectedMake)
                .Parameters.AddWithValue("@SelectedModel", SelectedModel)

                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    Dim DisplayValue As String = rs("CarMake") & "                    " & rs("CarModel") & " "
                    Dim CarItem As New ListBoxData(DisplayValue, rs("CarID"))
                    lstCars.Items.Add(CarItem)
                    If Not comMake.Items.Contains(rs("CarMake")) Then
                        comMake.Items.Add(rs("CarMake"))
                    End If
                    If Not comModel.Items.Contains(rs("CarModel")) Then
                        comModel.Items.Add(rs("CarModel"))
                    End If
                End While

                rs.Close()

                If lstCars.Items.Count > 1 Then

                    'SHOWING THE LIST

                    panCarSearchList.Visible = True
                Else
                    panCarSearchList.Visible = False
                    If lstCars.Items.Count = 0 Then
                        MessageBox.Show("There are no cars available within the dates entered", "Find Car", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        lstCars.SelectedIndex = 0
                    End If
                End If
            End With
            cn.Close()
        End If
    End Sub

    Private Sub ComModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comModel.SelectedIndexChanged
        DisplayAvailableCars(datCollect.Value.Date, datReturn.Value.Date, comMake.Text, comModel.Text)
    End Sub

    Private Sub BtnUpdateOrder_Click(sender As Object, e As EventArgs) Handles btnUpdateOrder.Click
        If txtCarMake.Text.Length < 1 Then
            MessageBox.Show("Please select a car", "Update Order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)



        ElseIf DbConnect() Then
            Dim SQLCmd As New OleDbCommand

            With SQLCmd
                .Connection = cn
                .CommandText = "Update tblOrders Set CarID = @CarID, StartDate = @StartDate, ReturnDate = @ReturnDate, TotalCost = @TotalCost where OrderID = @OrderID"
                .Parameters.AddWithValue("@CarID", lblCarID.Text)
                .Parameters.AddWithValue("@StartDate", datStart.Value.Date)
                .Parameters.AddWithValue("@ReturnDate", dateReturn.Value.Date)
                .Parameters.AddWithValue("@TotalCost", txtTotalCost.Text)

                .Parameters.AddWithValue("@OrderID", lblOrderID.Text)
                .ExecuteNonQuery()
            End With
            lstOrdersCollect.Items.Clear()
            btnCollected.Enabled = True
            panAmendOrder.Visible = False
            panOrdersList.Visible = True


            lblCarID.Text = ""
            lblOrderID.Text = ""
            txtCarMake.Text = ""

            MessageBox.Show("Order Updated")

            panAmendOrder.Visible = False
            panOrdersList.Visible = True
            btnClear.PerformClick()

        End If
        cn.Close()



    End Sub


    Private Sub btnDeleteOrder_Click(sender As Object, e As EventArgs) Handles btnDeleteOrder.Click
        If MessageBox.Show("Comfirm delete?", "Delete Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) = DialogResult.OK Then

            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Delete * From tblOrders Where OrderID = @OrderID"
                    .Parameters.AddWithValue("@OrderID", lblOrderID.Text)
                    .ExecuteNonQuery()

                End With
                cn.Close()
            End If
            btnClear.PerformClick()
            btnSearchOrdersCollect.PerformClick()
            btnSearchOrdersReturn.PerformClick()
            panAmendOrder.Visible = False
            panReturnDetails.Visible = False
            panOrdersList.Visible = True
        End If
    End Sub

    Private Sub PanCollectODetails_Paint(sender As Object, e As PaintEventArgs) Handles panCollectODetails.Paint

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        panReturnDetails.Visible = False
        panOrdersList.Visible = True
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOrderID.Text = ""
        txtFirstname.Text = ""
        txtSurname.Text = ""
        lblCarID.Text = ""

        txtTotalCost.Text = ""
        txtCarMake.Text = ""
        txtCarModel.Text = ""
        txtCostPerDay.Text = ""

        btnDeleteOrder.Enabled = False
        btnAmend.Enabled = False


    End Sub
End Class
