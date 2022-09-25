Imports System.Data.OleDb
Public Class Booking
    Private CurrentOrderID As Integer = -1 'variable that is set to -1 which means that a new booking can be made.
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The followin two lines control the dates.
        dateCollectCar.MinDate = Today.Date 'sets minimum collect date to the current date.
        dateReturnCar.MinDate = Today.AddDays(+1) 'sets minimum return date to one day after the current date.


        txtTotalCost.Text = FormatCurrency(0)

        btnConfirmOrder.Enabled = False
    End Sub
    Private Sub DisplayAvailableCars(CollectDate As String, ReturnDate As String, ByVal SelectedMake As String, ByVal SelectedModel As String)
        '--------------------------------------------------------
        'This procedure displays cars in the list and the two combo boxes
        'it only displays cars that are available in two dates specified in the Collect and Return date parameter.
        '-------------------------------------------------------------------------
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
            Dim SQLcmd As New OleDbCommand 'Holds the SQL Command to be run
            With SQLcmd
                .Connection = cn
                .CommandText = "Select Cars.CarID, Cars.CarMake, Cars.CarModel, Cars.RegNumber " &
                               "From Cars " &
                               "Where (Not Exists(Select * From tblOrders Where tblOrders.CarID = Cars.CarID and tblOrders.ReturnDate >= @StartDate and tblOrders.StartDate <= @EndDate)) " &
                 "and (@SelectedMake = '-1' or Cars.CarMake = @SelectedMake) and (@SelectedModel = '-1' or Cars.CarModel = @SelectedModel)"


                .Parameters.AddWithValue("@StartDate", dateCollectCar.Value.Date)
                .Parameters.AddWithValue("@EndDate", dateReturnCar.Value.Date)
                .Parameters.AddWithValue("@SelectedMake", SelectedMake)
                .Parameters.AddWithValue("@SelectedModel", SelectedModel)

                Dim rs As OleDbDataReader = .ExecuteReader() 'this excutes the query and rs will hold the record set that is returned.

                While rs.Read
                    Dim DisplayValue As String = rs("CarMake") & "                    " & rs("CarModel") & " " 'this variable will store the Car make and the Car model that has been read.
                    Dim CarItem As New ListBoxData(DisplayValue, rs("CarID")) 'this variable will store the car id that identifies the car.
                    lstCars.Items.Add(CarItem) 'car record added to the list box
                    If Not comMake.Items.Contains(rs("CarMake")) Then
                        'adds the car make to the car make combo box
                        comMake.Items.Add(rs("CarMake"))
                    End If
                    If Not comModel.Items.Contains(rs("CarModel")) Then
                        'adds the car model to the car model combo box
                        comModel.Items.Add(rs("CarModel"))
                    End If
                End While

                rs.Close()

                If lstCars.Items.Count > 1 Then

                    panCarSearchList.Visible = True  'if more than one car record has been added then the list box will be visible

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

    Private Sub BtnSearchAVCars_Click(sender As Object, e As EventArgs) Handles btnSearchAVCars.Click
        DisplayAvailableCars(dateCollectCar.Value.Date, dateReturnCar.Value.Date, comMake.Text, comModel.Text)

    End Sub

    Private Sub ComMake_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comMake.SelectedIndexChanged
        DisplayAvailableCars(dateCollectCar.Value.Date, dateReturnCar.Value.Date, comMake.Text, comModel.Text)

    End Sub

    Private Sub ComModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comModel.SelectedIndexChanged
        DisplayAvailableCars(dateCollectCar.Value.Date, dateReturnCar.Value.Date, comMake.Text, comModel.Text)

    End Sub

    Private Sub LstCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCars.SelectedIndexChanged
        If lstCars.SelectedItem IsNot Nothing Then
            Dim SelectedCar As ListBoxData = lstCars.SelectedItem 'Holds the CarID
            '
            DisplayCar(SelectedCar.Identifier) 'sending the car id as a parameter
            btnConfirmOrder.Enabled = True
        End If
    End Sub
    Private Sub DisplayCar(CarID As Integer)
        '-----------------------------------------------
        'Displays car details of the selected car from the list box
        'Selects deatils of car with ID specified in the CarID parameter
        'The details are displayed in the text boxes
        '----------------------------------------------------
        Dim DBCostPerDay As Integer

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand 'Holds the SQL Command to be run
            SQLCmd.Connection = cn
            SQLCmd.CommandText = "Select * From Cars Where CarID = @CarID"
            SQLCmd.Parameters.AddWithValue("@CarID", CarID)
            Dim rs As OleDbDataReader = SQLCmd.ExecuteReader() 'this excutes the query and rs will hold the record set that is returned.

            If rs.Read Then
                lblCarID.Text = rs("CarID")
                txtCarMake.Text = rs("CarMake")
                txtCarModel.Text = rs("CarModel")
                txtCostPerDay.Text = rs("CostPerDay")
                dateCollect.Value = dateCollectCar.Value
                dateReturn.Value = dateReturnCar.Value

                DBCostPerDay = rs("CostPerDay")

                Dim CollectDate As Date 'this will hold the Collect date that has been selected by the user
                Dim ReturnDate As Date = CollectDate.AddDays(4.0#) 'this will hold the Return date that has been selected by the user

                CollectDate = dateCollect.Value.Date
                ReturnDate = dateReturn.Value.Date

                Dim span = ReturnDate - CollectDate 'this will hold the total number of days by taking away the collect date from the return date
                Dim Days As Double = span.TotalDays ' this will hold the total number of days the order is being booked for

                Dim CostPerDay As Integer ' this will hold the price per day of the selected car
                Dim TotalCost As Integer ' this will hold the total cost of the order which is calculated below.
                CostPerDay = DBCostPerDay
                TotalCost = CostPerDay * Days
                txtTotalCost.Text = TotalCost

            Else
                MessageBox.Show("could not find Car with ID" & CarID, "Find Car", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            rs.Close()
            cn.Close()
        End If



        CHCarInService()

    End Sub
    Private Sub CHCarInService()

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand 'Holds the SQL Command to be run
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Service where CarID = @CarID and Repaired = False"
                .Parameters.AddWithValue("@CarID", lblCarID.Text)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    If lblCarID.Text = rs("CarID") Then
                        MessageBox.Show("This car is currently in service, please select a different car")

                        'btnSearchAVCars.PerformClick()
                        btnCancelOrder.PerformClick()
                        'btnSearchAVCars.PerformClick()
                        btnConfirmOrder.Enabled = False
                    Else
                        btnConfirmOrder.Enabled = True



                    End If
                End While
                rs.Close()
            End With
            cn.Close()
        End If


    End Sub

    Private Sub BtnConfirmOrder_Click(sender As Object, e As EventArgs) Handles btnConfirmOrder.Click
        '-------------------------------------------
        'creates a new booking record with the details that have been entered in the text boxes/ dates.
        '--------------------------------------------------
        If MessageBox.Show("Comfirm Booking?", "Booking", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) = DialogResult.OK Then


            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand 'Holds the SQL Command to be run
                If CurrentOrderID = -1 Then ' booking can only be saved if this variable is -1.
                    With SQLCmd
                        .Connection = cn
                        .CommandText = "Insert into tblOrders (CustomerID, CarID, StartDate, ReturnDate, TotalCost) Values (@CustomerID, @CarID, @StartDate, @ReturnDate, @TotalCost)"
                        .Parameters.AddWithValue("@CustomerID", Customer.lblCustomerID.Text)
                        .Parameters.AddWithValue("@CarID", lblCarID.Text)
                        .Parameters.AddWithValue("@StartDate", dateCollect.Value.Date)
                        .Parameters.AddWithValue("@ReturnDate", dateReturn.Value.Date)
                        .Parameters.AddWithValue("@TotalCost", txtTotalCost.Text)
                        .ExecuteNonQuery()

                        .CommandText = "Select @@Identity"
                        CurrentOrderID = .ExecuteScalar
                        lblOrderID.Text = CurrentOrderID


                    End With
                    cn.Close()
                End If
                MessageBox.Show("Booking Confirmed")
                Customer.btnMyDetails.PerformClick()



            End If
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        txtCarMake.Text = ""
        txtCarModel.Text = ""
        txtCostPerDay.Text = ""
        txtTotalCost.Text = ""
    End Sub

    Private Sub DateCollectCar_ValueChanged(sender As Object, e As EventArgs) Handles dateCollectCar.ValueChanged
        lstCars.Items.Clear()
    End Sub

    Private Sub DateReturnCar_ValueChanged(sender As Object, e As EventArgs) Handles dateReturnCar.ValueChanged
        lstCars.Items.Clear()
    End Sub
End Class