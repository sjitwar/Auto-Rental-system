Imports System.Data.OleDb
Public Class CustOrderDetails

    Private Sub CustOrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CustomerOrders(Customer.lblCustomerID.Text)

    End Sub
    Private Sub CustomerOrders(CustomerID As Integer)
        'Find and display all orders of the customer with the id speccified in the parameter.


        If DbConnect() Then

            lstOrders.Items.Clear()

            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders Where (CustomerID = @CustomerID)"
                .Parameters.AddWithValue("@CustomerID", CustomerID)
                Dim rs As OleDbDataReader = .ExecuteReader()


                While rs.Read
                    Dim DisplayValue As String = rs("OrderID") & "                     " & rs("StartDate") & " "
                    Dim OrderItem As New ListBoxData(DisplayValue, rs("OrderID"))
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

        'Display the selected order in the text boxes
        'Displays order deatils of the order withe the id specified in the parameter

        txtOCarMake.Text = ""
        txtOCarModel.Text = ""
        txtOTotalCost.Text = ""
        txtOCollected.Text = ""
        txtOReturned.Text = ""

        '

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders, Cars Where (OrderID = @SearchID) and (tblOrders.CarID = Cars.CarID)"
                .Parameters.AddWithValue("@SearchID", OrderID)
                Dim rs As OleDbDataReader = .ExecuteReader()

                If rs.Read Then

                    Dim checkCollect As String = "<Not Collected>"
                    Dim checkReturn As String = "<Not Returned>"
                    Dim checkPaid As String = "<Not Paid>"


                    If Not IsDBNull(rs("CollectedDate")) Then
                        checkCollect = rs("CollectedDate")
                    End If

                    If Not IsDBNull(rs("ReturnedDate")) Then
                        checkReturn = rs("ReturnedDate")
                    End If

                    If Not IsDBNull(rs("PaidDate")) Then
                        checkPaid = rs("PaidDate")
                    End If


                    txtOCarMake.Text = rs("CarMake")
                    txtOCarModel.Text = rs("CarModel")
                    txtOTotalCost.Text = rs("TotalCost")
                    txtCollectDate.Text = rs("StartDate")
                    txtReturnDate.Text = rs("ReturnDate")
                    txtPenaltyCost.Text = rs("PenaltyCost")

                    txtOCollected.Text = checkCollect
                    txtOReturned.Text = checkReturn
                    txtPaidDate.Text = checkPaid

                Else

                    DisplayDetailsWithoutCar(OrderID)


                End If
                rs.Close()
            End With
            cn.Close()

        End If

    End Sub
    Private Sub DisplayDetailsWithoutCar(OrderID As Integer)

        txtOCarMake.Text = ""
        txtOCarModel.Text = ""
        txtOTotalCost.Text = ""
        txtOCollected.Text = ""
        txtOReturned.Text = ""

        'Displays the order without the car if the car doesn't exist

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders Where (OrderID = @SearchID)"
                .Parameters.AddWithValue("@SearchID", OrderID)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read

                    Dim checkCollect As String = "<Not Collected>"
                    Dim checkReturn As String = "<Not Returned>"
                    Dim checkPaid As String = "<Not Paid>"


                    If Not IsDBNull(rs("CollectedDate")) Then
                        checkCollect = rs("CollectedDate")
                    End If

                    If Not IsDBNull(rs("ReturnedDate")) Then
                        checkReturn = rs("ReturnedDate")
                    End If

                    If Not IsDBNull(rs("PaidDate")) Then
                        checkPaid = rs("PaidDate")
                    End If


                    txtOCarMake.Text = "<Car Not Found>"
                    txtOCarModel.Text = "<Car Not Found>"
                    txtOTotalCost.Text = rs("TotalCost")
                    txtCollectDate.Text = rs("StartDate")
                    txtReturnDate.Text = rs("ReturnDate")
                    txtPenaltyCost.Text = rs("PenaltyCost")

                    txtOCollected.Text = checkCollect
                    txtOReturned.Text = checkReturn
                    txtPaidDate.Text = checkPaid





                End While
                rs.Close()
            End With
            cn.Close()

        End If

    End Sub

    Private Sub txtOReturned_TextChanged(sender As Object, e As EventArgs) Handles txtOReturned.TextChanged

    End Sub
End Class