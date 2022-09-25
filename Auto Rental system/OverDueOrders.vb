Imports System.Data.OleDb
Public Class OverDueOrders



    Private Sub lstOverDueOrders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOverDueOrders.SelectedIndexChanged
        If lstOverDueOrders.SelectedItem IsNot Nothing Then
            Dim SelectedOrder As ListBoxData = lstOverDueOrders.SelectedItem

            DisplayOrderDetails(SelectedOrder.Identifier)


            btnPaid.Enabled = False
            CalculateTimePenalty(datReturnDate.Value.Date)

            btnReturned.Enabled = True

        End If
    End Sub
    Private Sub CalculateTimePenalty(ReturnDate As Date)

        'Calculates the peanly cost of the returning order

        Dim TodayDate As Date = Now.Date 'hold current date

        Dim CostPerDay As Integer = txtCostPerDay.Text 'holds price of the car that is being returned 


        Dim span = TodayDate - ReturnDate ' 
        Dim Days As Double = span.TotalDays 'hold number days order was due by


        Dim TotalCost As Integer 'holds the total penalty cost that has been calculated below

        TotalCost = CostPerDay * Days
        txtTimePenaltyCost.Text = TotalCost


    End Sub

    Private Sub DisplayOrderDetails(OrderID)

        'Displays order details of the selected order from the list box
        'Displays deatils from three tables

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

                If rs.Read Then
                    lblOrderID.Text = rs("OrderID")
                    lblCarID.Text = rs("tblOrders.CarID")
                    lblCustomerID.Text = rs("tblOrders.CustomerID")
                    txtFirstname.Text = rs("Firstname")
                    txtSurname.Text = rs("Surname")
                    txtCarMake.Text = rs("CarMake")
                    txtCarModel.Text = rs("CarModel")
                    txtCostPerDay.Text = rs("CostPerDay")
                    datStartDate.Value = rs("StartDate")
                    datReturnDate.Value = rs("ReturnDate")
                    txtTotalCost.Text = rs("TotalCost")

                Else
                    DisplayWithoutCar(OrderID)
                End If
                rs.Close()
            End With
            cn.Close()

        End If


    End Sub
    Private Sub DisplayWithoutCar(OrderID As Integer)

        'displays the order without car details if car doesn't exist

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders, Customer Where (OrderID = @SearchID) and tblOrders.CustomerID = Customer.CustomerID"
                .Parameters.AddWithValue("@SearchID", OrderID)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    lblOrderID.Text = rs("OrderID")
                    lblCarID.Text = rs("CarID")
                    lblCustomerID.Text = rs("tblOrders.CustomerID")
                    txtFirstname.Text = rs("Firstname")
                    txtSurname.Text = rs("Surname")
                    txtCarMake.Text = "<Car Not Found>"
                    txtCarModel.Text = "<Car Not Found>"
                    txtTotalCost.Text = rs("TotalCost")
                    datStartDate.Text = rs("StartDate")
                    datReturnDate.Text = rs("ReturnDate")

                End While
                rs.Close()

            End With
            cn.Close()

        End If


    End Sub




    Private Sub OverdueOrders()

        'Displays orders that are overdue in the list box


        lstOverDueOrders.Items.Clear()

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders Where (ReturnDate <= @Today) and (Returned = False)"
                .Parameters.AddWithValue("@Today", Today.Date)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read

                    Dim DisplayValue As String = rs("OrderID") & vbTab & rs("CarID") & vbTab & rs("CustomerID")
                    Dim OrderItem As New ListBoxData(DisplayValue, rs("OrderID"))
                    Dim CustomerID As New ListBoxData(DisplayValue, rs("CustomerID"))
                    lstOverDueOrders.Items.Add(OrderItem)


                End While
                rs.Close()
            End With
            cn.Close()
        End If
    End Sub
    Private Sub OrdersNotPaid() 'Displays orders that have an outstanding payment



        lstOrdersNotPaid.Items.Clear()

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders Where (Returned = True) and (Paid = False)"
                Dim rs As OleDbDataReader = .ExecuteReader

                While rs.Read
                    Dim DisplayValue As String = rs("OrderID") & vbTab & rs("CarID") & vbTab & rs("CustomerID")
                    Dim OrderItem As New ListBoxData(DisplayValue, rs("OrderID"))
                    Dim CustomerID As New ListBoxData(DisplayValue, rs("CustomerID"))
                    lstOrdersNotPaid.Items.Add(OrderItem)
                End While
                rs.Close()
            End With
            cn.Close()
        End If


    End Sub

    Private Sub btnReturned_Click(sender As Object, e As EventArgs) Handles btnReturned.Click
        panReturnDetails.Visible = True
        panOrders.Visible = False
        'panOrders.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpdateReturn.Click
        If lstOverDueOrders.SelectedItem IsNot Nothing Then

            Dim SelectedOrder As ListBoxData = lstOverDueOrders.SelectedItem
            ReturnedOrder(SelectedOrder.Identifier)


        End If


        If AddService.Checked = True Then

            AddToService(lblOrderID.Text)

        End If


        panReturnDetails.Visible = False
        panOrders.Visible = True


    End Sub
    Private Sub ReturnedOrder(SelectedOrder As Integer)

        'Updates the seleted order to retured and more details

        Dim Returned As Boolean
        Dim CurrentDate As Date

        CurrentDate = Now
        Returned = True

        If checkPaid.Checked = True Then 'If order is paid then  updates to paid as well

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
            OverdueOrders()
            OrdersNotPaid()

        Else                    'if order is not paid then it doesnt update to paid

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
            OverdueOrders()
            OrdersNotPaid()

        End If

    End Sub
    Private Sub AddToService(SelectedOrder As Integer)

        'Add the car in the selected order to service

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


    Private Sub txtReturn_Click(sender As Object, e As EventArgs)
        panReturnDetails.Visible = True
    End Sub

    Private Sub OverDue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panReturnDetails.Visible = False
        OverdueOrders()
        OrdersNotPaid()
        btnReturned.Enabled = False
        btnPaid.Enabled = False

    End Sub

    Private Sub lstOrdersNotPaid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOrdersNotPaid.SelectedIndexChanged
        If lstOrdersNotPaid.SelectedItem IsNot Nothing Then
            Dim SelectedOrder As ListBoxData = lstOrdersNotPaid.SelectedItem


            DisplayOrderDetails(SelectedOrder.Identifier)
            btnReturned.Enabled = False
            btnPaid.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPaid.Click
        If lstOrdersNotPaid.SelectedItem IsNot Nothing Then

            Dim SelectedOrder As ListBoxData = lstOrdersNotPaid.SelectedItem
            OrderPaid(SelectedOrder.Identifier)


        End If
    End Sub
    Private Sub OrderPaid(SelectedOrder As Integer)

        ' updates the slected order to paid

        Dim Paid As Boolean ' set to true and used as a parameter
        Dim StaffID As Integer ' hold the Id of the staff that is signed in
        StaffID = Staff.lblStaffID.Text

        Paid = True

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand

            With SQLCmd
                .Connection = cn
                .CommandText = "Update tblOrders Set Paid = @Paid, PaidDate = @PaidDate, StaffIDPaid = @StaffIDPaid Where OrderID = @SelectedOrder"
                .Parameters.AddWithValue("@Paid", Paid)
                .Parameters.AddWithValue("@PaidDate", Now.Date)
                .Parameters.AddWithValue("@StaffIDPaid", StaffID)


                .Parameters.AddWithValue("@SelectedOrder", SelectedOrder)


                .ExecuteNonQuery()
            End With
            lstOrdersNotPaid.Items.Clear()
            lblOrderID.Text = ""
            lblCarID.Text = ""
            lblCustomerID.Text = ""
            txtFirstname.Text = ""
            txtSurname.Text = ""
            txtCarMake.Text = ""
            txtCarModel.Text = ""
            txtCostPerDay.Text = ""
            txtTotalCost.Text = ""



        End If
        cn.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub



    Private Sub TxtCalculatePenalty_Click(sender As Object, e As EventArgs) Handles txtCalculatePenalty.Click
        Dim TotalPenaltyCost As Integer = 0
        Dim TyresCost As Integer = 40
        Dim ScratchesCost As Integer = 20 'same as the one in the OrderManagement form
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

        txtTotalPenaltyCost.Text = TotalPenaltyCost + txtTimePenaltyCost.Text
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        panReturnDetails.Visible = False
        panOrders.Visible = True

    End Sub
End Class