Imports System.Data.OleDb
Public Class CustomersManagement
    Private CurrentCustomerID As Integer = -1 'set to -1, holds the customer ID

    Private Sub StaffCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        If IsNumeric(txtCustomerID.Text) Then
            DisplayCustomer(txtCustomerID.Text)
            CustomerOrders(txtCustomerID.Text)

        ElseIf txtCustomerSurname.Text.Length > 0 Then
            SearchCustomerName(txtCustomerSurname.Text)

        End If
    End Sub
    Private Sub SearchCustomerName(CustomerName As String)

        If DbConnect() Then

            lstCustomers.Items.Clear()

            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Customer Where Surname Like @CustomerNameSearch"
                .Parameters.AddWithValue("@CustomerNameSearch", "%" & txtCustomerSurname.Text & "%")
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    Dim CustomerDisplayValue As String = rs("FirstName") & vbTab & rs("Surname")
                    Dim CustomerItem As New ListBoxData(CustomerDisplayValue, rs("CustomerID"))
                    lstCustomers.Items.Add(CustomerItem)
                End While

                rs.Close()
                If lstCustomers.Items.Count > 1 Then

                    'SHOWING THE LIST

                    panCustomerSearchList.Visible = True
                Else
                    panCustomerSearchList.Visible = False
                    If lstCustomers.Items.Count = 0 Then
                        MessageBox.Show("There are no customers with that name", "Find Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        lstCustomers.SelectedIndex = 0
                    End If
                End If
            End With
            cn.Close()
        End If
    End Sub
    Private Sub DisplayCustomer(CustomerID As Integer)

        '-------------------------------------------
        'Find customer record with the ID specified in the CustomerID parameter
        'Display the customer record in the text boxes
        '--------------------------------------------

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            SQLCmd.Connection = cn
            SQLCmd.CommandText = "Select * From Customer Where CustomerID = @CustomerID"
            SQLCmd.Parameters.AddWithValue("@CustomerID", CustomerID)
            Dim rs As OleDbDataReader = SQLCmd.ExecuteReader()

            If rs.Read Then
                CurrentCustomerID = CustomerID
                txtID.Text = rs("CustomerID")
                txtFirstName.Text = rs("Firstname")
                txtSurname.Text = rs("Surname")
                txtDOB.Text = rs("DateOfBirth")
                txtPostcode.Text = rs("Postcode")
                txtContactNumber.Text = rs("ContactNumber")
                txtAddress.Text = rs("CustomerAddress")
            Else
                MessageBox.Show("could not find Customer with ID" & CustomerID, "Find Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            rs.Close()
            cn.Close()
        End If
    End Sub

    Private Sub btnCustomerClear_Click(sender As Object, e As EventArgs) Handles btnCustomerClear.Click
        txtCustomerID.Text = ""
        txtCustomerSurname.Text = ""

        txtID.Text = ""
        txtFirstName.Text = ""
        txtSurname.Text = ""
        txtDOB.Text = ""
        txtPostcode.Text = ""
        txtContactNumber.Text = ""
        txtAddress.Text = ""
        lstCustomers.Items.Clear()

        lstOrders.Items.Clear()
        txtCarMake.Text = ""
        txtCarModel.Text = ""
        txtTotalCost.Text = ""
        txtStartDate.Text = ""
        txtReturnDate.Text = ""
        txtCollectedDate.Text = ""
        txtReturnedDate.Text = ""
        txtStaffIDCollect.Text = ""
        txtStaffIDReturn.Text = ""
        txtReturnComments.Text = ""
        txtPenaltyCost.Text = ""
        txtPaidDate.Text = ""
        txtStaffIDPaid.Text = ""


    End Sub

    Private Sub btnDeleteCust_Click(sender As Object, e As EventArgs) Handles btnDeleteCust.Click

        'Delete customer record of the selected customer

        If MessageBox.Show("Confirm delete?", "Delete Customer", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) = DialogResult.OK Then
            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Delete * From Customer Where CustomerID = @CustomerID"
                    .Parameters.AddWithValue("@CustomerID", CurrentCustomerID)
                    .ExecuteNonQuery()
                    btnCustomerClear.PerformClick()
                End With
                cn.Close()
                btnCustomerClear.PerformClick()
                btnSearchCustomer.PerformClick()


            End If

            'Delete order records of the deleted customer

            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Delete * From tblOrders Where CustomerID = @CustomerID"
                    .Parameters.AddWithValue("@CustomerID", CurrentCustomerID)
                    .ExecuteNonQuery()
                End With
                cn.Close()
            End If
        End If


    End Sub

    Private Sub lstCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomers.SelectedIndexChanged
        If lstCustomers.SelectedItem IsNot Nothing Then
            Dim SelectedCustomer As ListBoxData = lstCustomers.SelectedItem
            DisplayCustomer(SelectedCustomer.Identifier)
            CustomerOrders(SelectedCustomer.Identifier)

        End If
    End Sub
    Private Sub CustomerOrders(CustomerID As Integer)

        'Find and display all orders (in list box) of the customer specified in the CustomerID parameter.

        If DbConnect() Then

            lstOrders.Items.Clear()

            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders Where CustomerID = @SearchID"
                .Parameters.AddWithValue("@SearchID", CustomerID)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    Dim DisplayValue As String = rs("OrderID") & "                      " & rs("CustomerID") & "                         " & rs("CarID") & " "
                    Dim OrderItem As New ListBoxData(DisplayValue, rs("OrderID")) 'Hold OrderID of the order record returned
                    lstOrders.Items.Add(OrderItem)
                End While
                rs.Close()

            End With
            cn.Close()

        End If
    End Sub

    Private Sub lstOrders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOrders.SelectedIndexChanged
        If lstOrders.SelectedItem IsNot Nothing Then
            Dim SelectedOrder As ListBoxData = lstOrders.SelectedItem
            DisplayOrderDetails(SelectedOrder.Identifier)

        End If
    End Sub
    Private Sub DisplayOrderDetails(OrderID As Integer)

        'Display order details of the slected order from the list box


        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn


                .CommandText = "Select * " &
                    "From tblOrders " &
                    "inner join Cars on tblOrders.CarID = Cars.CarID " &
                    "Where (OrderID = @OrderID) and (tblOrders.CarID = Cars.CarID)"
                .Parameters.AddWithValue("@OrderID", OrderID)

                Dim rs As OleDbDataReader = .ExecuteReader()

                If rs.Read Then

                    Dim checkCollect As String = "<Not Collected>" 'holds text that will be displayed if these field are not found
                    Dim checkReturn As String = "<Not Returned>"
                    Dim checkPaid As String = "<Not Paid>"
                    Dim checkComments As String = "<Not Returned>"

                    If Not IsDBNull(rs("CollectedDate")) Then
                        checkCollect = rs("CollectedDate")
                    End If

                    If Not IsDBNull(rs("ReturnedDate")) Then
                        checkReturn = rs("ReturnedDate")
                    End If

                    If Not IsDBNull(rs("PaidDate")) Then
                        checkPaid = rs("PaidDate")
                    End If

                    If Not IsDBNull(rs("ReturnComments")) Then
                        checkComments = rs("ReturnComments")
                    End If

                    txtCarMake.Text = rs("CarMake")
                    txtCarModel.Text = rs("CarModel")
                    txtTotalCost.Text = rs("TotalCost")
                    txtStartDate.Text = rs("StartDate")
                    txtReturnDate.Text = rs("ReturnDate")
                    txtCollectedDate.Text = checkCollect
                    txtReturnedDate.Text = checkReturn
                    txtStaffIDCollect.Text = rs("StaffIDCollect")
                    txtStaffIDReturn.Text = rs("StaffIDReturn")
                    txtReturnComments.Text = checkComments
                    txtPenaltyCost.Text = rs("PenaltyCost")
                    txtPaidDate.Text = checkPaid
                    txtStaffIDPaid.Text = rs("StaffIDPaid")

                Else

                    DisplayWithoutCar(OrderID)

                End If
                rs.Close()
            End With
            cn.Close()

        End If

    End Sub
    Private Sub DisplayWithoutCar(OrderID As Integer)
        'Procedure to displays order if the car doesnt exist 

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders Where (OrderID = @SearchID)"
                .Parameters.AddWithValue("@SearchID", OrderID)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    Dim checkCollect As String = "<Not Collected>" 'text displayed in replacement of the car fields 
                    Dim checkReturn As String = "<Not Returned>"
                    Dim checkPaid As String = "<Not Paid>"
                    Dim checkComments As String = "<Not Returned>"


                    If Not IsDBNull(rs("CollectedDate")) Then
                        checkCollect = rs("CollectedDate")
                    End If

                    If Not IsDBNull(rs("ReturnedDate")) Then
                        checkReturn = rs("ReturnedDate")
                    End If

                    If Not IsDBNull(rs("PaidDate")) Then
                        checkPaid = rs("PaidDate")
                    End If

                    If Not IsDBNull(rs("ReturnComments")) Then
                        checkComments = rs("ReturnComments")
                    End If

                    txtCarMake.Text = "<Car Not Found>"
                    txtCarModel.Text = "<Car Not Found>"
                    txtTotalCost.Text = rs("TotalCost")
                    txtStartDate.Text = rs("StartDate")
                    txtReturnDate.Text = rs("ReturnDate")
                    txtCollectedDate.Text = checkCollect
                    txtReturnedDate.Text = checkReturn
                    txtStaffIDCollect.Text = rs("StaffIDCollect")
                    txtStaffIDReturn.Text = rs("StaffIDReturn")
                    txtReturnComments.Text = checkComments
                    txtPenaltyCost.Text = rs("PenaltyCost")
                    txtPaidDate.Text = checkPaid
                    txtStaffIDPaid.Text = rs("StaffIDPaid")
                End While
                rs.Close()

            End With
            cn.Close()

        End If


    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub TxtContactNumber_TextChanged(sender As Object, e As EventArgs) Handles txtContactNumber.TextChanged

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PanCustomers_Paint(sender As Object, e As PaintEventArgs) Handles panCustomers.Paint

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles panOrderDetails.Paint

    End Sub
End Class