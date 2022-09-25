Imports System.Data.OleDb
Public Class Reports

    Private Sub btnShowCars_Click(sender As Object, e As EventArgs) Handles btnShowCars.Click

        'Displays most popular cars between the two dates entered

        lstCars.Items.Clear()
        lstPosition.Items.Clear()
        lstCarPopularity.Items.Clear()

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select Cars.CarMake, Cars.CarID, Count(tblOrders.OrderID) as OrderCount " &
                    "From tblOrders " &
                    "inner join Cars on tblOrders.CarID = Cars.CarID " &
                    "Where (StartDate >= @StartDate) and (StartDate <= @EndDate) " &
                    "Group by Cars.CarMake, Cars.CarID " &
                    "Order by Count(tblOrders.OrderID) DESC"

                .Parameters.AddWithValue("@StartDate", dateStart.Value.Date)
                .Parameters.AddWithValue("@EndDate", dateEnd.Value.Date)

                Dim rs As OleDbDataReader = .ExecuteReader()

                Dim Position As Integer
                Position = 0


                While rs.Read
                    Position = Position + 1

                    lstCars.Items.Add(rs("CarMake"))

                    lstCarPopularity.Items.Add(rs("OrderCount"))

                    lstPosition.Items.Add(Position)


                End While
                rs.Close()
            End With
            cn.Close()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnShowCustomers.Click

        'Displays most popular customers between the two dates entered

        lstCustomers.Items.Clear()
        lstPos.Items.Clear()
        lstCustPopularity.Items.Clear()

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select Customer.Firstname, Customer.Surname, Customer.CustomerID, Count(tblOrders.CustomerID) as OrderCount " &
                    "From tblOrders " &
                    "inner join Customer on tblOrders.CustomerID = Customer.CustomerID " &
                    "Where (StartDate >= @FromDate) and (StartDate <= @ToDate) " &
                    "Group by Customer.Firstname, Customer.Surname, Customer.CustomerID " &
                    "Order by Count(tblOrders.OrderID) DESC"

                .Parameters.AddWithValue("@FromDate", dateFrom.Value.Date)
                .Parameters.AddWithValue("@ToDate", dateTo.Value.Date)

                Dim rs As OleDbDataReader = .ExecuteReader()

                Dim Position As Integer
                Position = 0
                While rs.Read
                    Position = Position + 1
                    Dim DisplayValue As String = rs("CustomerID") & "           " & rs("Firstname") & "           " & rs("Surname") & " "
                    lstCustomers.Items.Add(DisplayValue)
                    lstCustPopularity.Items.Add(rs("OrderCount"))

                    lstPos.Items.Add(Position)
                End While
                rs.Close()

            End With
            cn.Close()
        End If


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustPopularity.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCarLastMonth.Click

        'Displays most popular cars in the last month

        lstCars.Items.Clear()
        lstPosition.Items.Clear()
        lstCarPopularity.Items.Clear()

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select Cars.CarMake, Cars.CarID, Count(tblOrders.OrderID) as OrderCount " &
                    "From tblOrders " &
                    "inner join Cars on tblOrders.CarID = Cars.CarID " &
                    "Where (StartDate >= @StartDate) and (StartDate <= @EndDate) " &
                    "Group by Cars.CarMake, Cars.CarID " &
                    "Order by Count(tblOrders.OrderID) DESC"

                .Parameters.AddWithValue("@StartDate", Today.AddMonths(-1))
                .Parameters.AddWithValue("@EndDate", Today.Date)

                Dim rs As OleDbDataReader = .ExecuteReader()

                Dim Position As Integer
                Position = 0
                While rs.Read
                    Position = Position + 1

                    lstCars.Items.Add(rs("CarMake"))
                    lstCarPopularity.Items.Add(rs("OrderCount"))

                    'lstCars.Height = lstCars.Height + 20
                    lstPosition.Items.Add(Position)
                    'lstPosition.Height = lstPosition.Height + 20
                    'lstCarPopularity.Items.Add()

                End While
                rs.Close()
            End With
            cn.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCar7Days.Click

        'Displays most popular cars in the last 7 days

        lstCars.Items.Clear()
        lstPosition.Items.Clear()
        lstCarPopularity.Items.Clear()

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select Cars.CarMake, Cars.CarID, Count(tblOrders.OrderID) as OrderCount " &
                    "From tblOrders " &
                    "inner join Cars on tblOrders.CarID = Cars.CarID " &
                    "Where (StartDate >= @StartDate) and (StartDate <= @EndDate) " &
                    "Group by Cars.CarMake, Cars.CarID " &
                    "Order by Count(tblOrders.OrderID) DESC"

                .Parameters.AddWithValue("@StartDate", Today.AddDays(-7))
                .Parameters.AddWithValue("@EndDate", Today.Date)

                Dim rs As OleDbDataReader = .ExecuteReader()

                Dim Position As Integer
                Position = 0

                While rs.Read
                    Position = Position + 1

                    lstCars.Items.Add(rs("CarMake"))
                    lstCarPopularity.Items.Add(rs("OrderCount"))
                    lstPosition.Items.Add(Position)


                End While
                rs.Close()
            End With
            cn.Close()
        End If
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCust7Days.Click

        'Displays most popular customers in the last 7 days

        lstCustomers.Items.Clear()
        lstPos.Items.Clear()
        lstCustPopularity.Items.Clear()

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select Customer.Firstname, Customer.Surname, Customer.CustomerID, Count(tblOrders.CustomerID) as OrderCount " &
                    "From tblOrders " &
                    "inner join Customer on tblOrders.CustomerID = Customer.CustomerID " &
                    "Where (StartDate >= @FromDate) and (StartDate <= @ToDate) " &
                    "Group by Customer.Firstname, Customer.Surname, Customer.CustomerID " &
                    "Order by Count(tblOrders.OrderID) DESC"

                .Parameters.AddWithValue("@FromDate", Today.AddDays(-7))
                .Parameters.AddWithValue("@ToDate", Today.Date)

                Dim rs As OleDbDataReader = .ExecuteReader()

                Dim Position As Integer
                Position = 0
                While rs.Read
                    Position = Position + 1
                    Dim DisplayValue As String = rs("CustomerID") & "           " & rs("Firstname") & "           " & rs("Surname") & " "
                    lstCustomers.Items.Add(DisplayValue)
                    lstCustPopularity.Items.Add(rs("OrderCount"))

                    lstPos.Items.Add(Position)
                End While
                rs.Close()

            End With
            cn.Close()
        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnCustLastMonth.Click

        'Displays most popular customers in the past month

        lstCustomers.Items.Clear()
        lstPos.Items.Clear()
        lstCustPopularity.Items.Clear()


        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select Customer.Firstname, Customer.Surname, Customer.CustomerID, Count(tblOrders.CustomerID) as OrderCount " &
                    "From tblOrders " &
                    "inner join Customer on tblOrders.CustomerID = Customer.CustomerID " &
                    "Where (StartDate >= @FromDate) and (StartDate <= @ToDate) " &
                    "Group by Customer.Firstname, Customer.Surname, Customer.CustomerID " &
                    "Order by Count(tblOrders.OrderID) DESC"

                .Parameters.AddWithValue("@FromDate", Today.AddMonths(-1))
                .Parameters.AddWithValue("@ToDate", Today.Date)

                Dim rs As OleDbDataReader = .ExecuteReader()

                Dim Position As Integer
                Position = 0
                While rs.Read
                    Position = Position + 1
                    Dim DisplayValue As String = rs("CustomerID") & "           " & rs("Firstname") & "           " & rs("Surname") & " "
                    lstCustomers.Items.Add(DisplayValue)
                    lstCustPopularity.Items.Add(rs("OrderCount"))

                    lstPos.Items.Add(Position)
                    'lstOrders.Items.Add(count)
                End While
                rs.Close()

            End With
            cn.Close()
        End If

    End Sub



    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTotalRevenue.Text = FormatCurrency(0)

    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        'Displays the total revenue and the total number of bookings made in the two dates entered

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders Where (StartDate >= @StartDate) and (StartDate <= @EndDate) and (Paid = True)"

                .Parameters.AddWithValue("@StartDate", dateRStart.Value.Date)
                .Parameters.AddWithValue("@EndDate", DateREnd.Value.Date)

                Dim rs As OleDbDataReader = .ExecuteReader()

                Dim RevTotal As Integer
                Dim NumOfBookings As Integer = 0
                While rs.Read
                    RevTotal = RevTotal + rs("TotalCost")
                    NumOfBookings = NumOfBookings + 1
                End While
                txtNumOfBookings.Text = NumOfBookings

                rs.Close()
                txtTotalRevenue.Text = RevTotal
            End With
            cn.Close()
        End If
    End Sub

    Private Sub BtnRev7Days_Click(sender As Object, e As EventArgs) Handles btnRev7Days.Click

        'Displays the total revenue and the total number of bookings made in the last 7 days


        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders Where (StartDate >= @StartDate) and (StartDate <= @EndDate) and (Paid = True)"

                .Parameters.AddWithValue("@StartDate", Today.AddDays(-7))
                .Parameters.AddWithValue("@EndDate", Today.Date)

                Dim rs As OleDbDataReader = .ExecuteReader()

                Dim RevTotal As Integer
                Dim NumOfBookings As Integer = 0
                While rs.Read
                    RevTotal = RevTotal + rs("TotalCost")
                    NumOfBookings = NumOfBookings + 1
                End While
                txtNumOfBookings.Text = NumOfBookings

                rs.Close()
                txtTotalRevenue.Text = RevTotal
            End With
            cn.Close()
        End If
    End Sub

    Private Sub BtnRevLastMonth_Click(sender As Object, e As EventArgs) Handles btnRevLastMonth.Click

        'Displays the total revenue and the total number of bookings made in the last month


        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders Where (StartDate >= @StartDate) and (StartDate <= @EndDate) and (Paid = True)"

                .Parameters.AddWithValue("@StartDate", Today.AddMonths(-1))
                .Parameters.AddWithValue("@EndDate", Today.Date)

                Dim rs As OleDbDataReader = .ExecuteReader()

                Dim RevTotal As Integer
                Dim NumOfBookings As Integer = 0
                While rs.Read
                    RevTotal = RevTotal + rs("TotalCost")
                    NumOfBookings = NumOfBookings + 1
                End While
                txtNumOfBookings.Text = NumOfBookings

                rs.Close()
                txtTotalRevenue.Text = RevTotal
            End With
            cn.Close()
        End If
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub
End Class

