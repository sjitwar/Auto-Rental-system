Imports System.Data.OleDb
Public Class CarsManagement
    Private CurrentCarID As Integer = -1 'variable that is set to -1 which means that a new booking can be made.
    Private CheckIfInService As Boolean = False 'flag set to false. if it changes to true then car cannot be added to service.

    Private Sub txtSearchCustomer_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub butAddCar_Click(sender As Object, e As EventArgs) Handles butAddCar.Click
        '------------------------------------
        'adding a new car record to the database with the details that have been entered in the text boxes
        'OR updating an existing car record
        '-----------------------------------------------------------------
        'Minimum length checks
        If txtCarMake.Text.Length < 1 Then
            MessageBox.Show("You must enter a Car Make", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCarMake.Focus()
            txtCarMake.ForeColor = Color.DarkRed
        ElseIf txtCarModel.Text.Length < 1 Then
            MessageBox.Show("You must a Car Model", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCarModel.Focus()
        ElseIf txtRegNumber.Text.Length < 1 Then
            MessageBox.Show("You must enter a REG number")
        ElseIf Val(txtCostPerDay.Text) <= 0 Then
            MessageBox.Show("The price of the car must be greater than £0.00", "Save Car", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCostPerDay.Focus()


        ElseIf DbConnect() Then
            Dim SQLCmd As New OleDbCommand 'Holds the SQL Command to be run
            If CurrentCarID = -1 Then 'if the CurrentCarID is -1 then it adds a new record
                With SQLCmd
                    SQLCmd.Connection = cn
                    SQLCmd.CommandText = "Insert into Cars (CarMake, CarModel, CostPerDay, RegNumber, DatePurchased) " &
                        "Values (@CarMake, @CarModel, @CostPerDay, @RegNumber, @DatePurchased)"
                    .Parameters.AddWithValue("@CarMake", txtCarMake.Text)
                    .Parameters.AddWithValue("@CarModel", txtCarModel.Text)
                    .Parameters.AddWithValue("@CostPerDay", txtCostPerDay.Text)
                    .Parameters.AddWithValue("@RegNumber", txtRegNumber.Text)
                    .Parameters.AddWithValue("@DatePurchased", datDatePurchased.Value.Date)


                    .ExecuteNonQueryAsync()
                    .CommandText = "Select @@Identity"
                    CurrentCarID = SQLCmd.ExecuteScalar
                    lblCarID.Text = CurrentCarID
                    MessageBox.Show("Car added")
                End With
            Else 'if CurrentCarID is NOT -1 then it updates an existing car record
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Update Cars Set CarMake = @CarMake, CarModel = @CarModel, CostPerDay = @CostPerDay, RegNumber = @RegNumber where CarID = @CurrentCarID"

                    .Parameters.AddWithValue("@CarMake", txtCarMake.Text)
                    .Parameters.AddWithValue("@CarModel", txtCarModel.Text)
                    .Parameters.AddWithValue("@CostPerDay", txtCostPerDay.Text)
                    .Parameters.AddWithValue("@RegNumber", txtRegNumber.Text)
                    .Parameters.AddWithValue("@CurrentCarID", CurrentCarID)

                    .ExecuteNonQuery()
                    MessageBox.Show("Car details updated")

                End With

            End If
            cn.Close()
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        CurrentCarID = -1
        lblCarID.Text = "<automatically generated>"
        txtCarMake.Text = ""
        txtCarModel.Text = ""
        txtCostPerDay.Text = ""
        txtRegNumber.Text = ""
        txtSearchMake.Text = ""
        txtCarID.Text = ""
        btnDeleteCar.Visible = False
        btnServiceHistory.Visible = False
        btnAddToService.Visible = False
    End Sub

    Private Sub btnDeleteCar_Click(sender As Object, e As EventArgs) Handles btnDeleteCar.Click
        checkCarInOrders(lblCarID.Text)
    End Sub
    Private Sub checkCarInOrders(CarID As Integer)
        '------------------------------------
        'Before a car can be deleted, this checks if the ID of that car is currently out in an order
        '---------------------------------------

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand 'Holds the SQL Command to be run
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders where CarID = @CarID and Returned = False"
                .Parameters.AddWithValue("@CarID", CarID)
                Dim rs As OleDbDataReader = .ExecuteReader() 'this excutes the query and rs will hold the record set that is returned

                While rs.Read
                    If txtCarID.Text = rs("CarID") Then 'if a record set is returned and it match the ID of the car that is being deleted
                        'the system will not allow thw car to be deleted

                        MessageBox.Show("You cannot delete this car as it is currently being rented")

                        btnDeleteCar.Enabled = False
                    Else
                        DeleteCar(CarID)  'if not record is returned or if it doesn't match the car ID then it can be deleted.



                    End If
                End While
                rs.Close()
            End With
            cn.Close()
        End If

    End Sub
    Private Sub DeleteCar(CarID As Integer)
        '-------------------------------
        'this deletes te car record with the ID specified in the CarID parameter
        '------------------------------------
        If MessageBox.Show("Comfirm delete?", "Delete Car", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) = DialogResult.OK Then

            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand 'Holds the SQL Command to be run
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Delete * From Cars Where CarID = @CarID" 'Deletes the car record
                    .Parameters.AddWithValue("@CarID", lblCarID.Text)
                    .ExecuteNonQuery()
                    btnClear.PerformClick()
                End With
                cn.Close()
                btnClear.PerformClick()
            End If

            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand 'Holds the SQL Command to be run
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Delete * From Service Where CarID = @CarID" 'this deletes all service records of the car that is being deleted.
                    .Parameters.AddWithValue("@CarID", lblCarID.Text)
                    .ExecuteNonQuery()
                    btnClear.PerformClick()
                End With
                cn.Close()
                btnClear.PerformClick()
            End If

        End If

    End Sub

    Private Sub btnSearchCar_Click(sender As Object, e As EventArgs) Handles btnSearchCar.Click
        If IsNumeric(txtCarID.Text) Then            'if car searched by ID
            DisplayCar(txtCarID.Text)
        ElseIf txtSearchMake.Text.Length > 0 Then    'if car dearched by Car Make
            SearchMake(txtSearchMake.Text)

        End If
    End Sub
    Private Sub DisplayCar(CarID As Integer)
        '-------------------------------------------
        'Find car record with the ID specified in the CarID parameter
        'Display the car record in the text boxes
        '--------------------------------------------
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            SQLCmd.Connection = cn
            SQLCmd.CommandText = "Select * From Cars Where CarID = @CarID"
            SQLCmd.Parameters.AddWithValue("@CarID", CarID)
            Dim rs As OleDbDataReader = SQLCmd.ExecuteReader() 'this excutes the query and rs will hold the record set that is returned


            If rs.Read Then
                CurrentCarID = CarID

                lblCarID.Text = rs("CarID")
                txtCarMake.Text = rs("CarMake")
                txtCarModel.Text = rs("CarModel")
                txtCostPerDay.Text = rs("CostPerDay")
                txtRegNumber.Text = rs("RegNumber")
                datDatePurchased.Value = rs("DatePurchased")

                btnDeleteCar.Visible = True
                btnServiceHistory.Visible = True
                btnAddToService.Visible = True
            Else
                MessageBox.Show("could not find Car with ID" & CarID, "Find Car", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            rs.Close()
            cn.Close()
        End If
    End Sub
    Private Sub SearchMake(CarMake As String)
        '------------------------------
        'Searching car by Car Make specified in the Car Make Parameter.


        If DbConnect() Then

            lstCars.Items.Clear()

            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Cars Where CarMake Like @MakeSearch"
                .Parameters.AddWithValue("@MakeSearch", "%" & txtSearchMake.Text & "%")
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    Dim DisplayValue As String = rs("CarMake") & "             " & rs("CarModel") & " " 'Holds the car make and model that is read
                    Dim CarItem As New ListBoxData(DisplayValue, rs("CarID")) 'Holds the car id
                    lstCars.Items.Add(CarItem)
                End While

                rs.Close()
                If lstCars.Items.Count > 1 Then

                    'SHOWING THE LIST

                    panCarSearchList.Visible = True
                Else
                    panCarSearchList.Visible = False
                    If lstCars.Items.Count = 0 Then
                        MessageBox.Show("There are no cars with that name", "Find Car", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        lstCars.SelectedIndex = 0
                    End If
                End If
            End With
            cn.Close()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearchMake.Text = ""
        txtCarID.Text = ""
        lstCars.Items.Clear()

        lblCarID.Text = ""
        txtCarMake.Text = ""
        txtCarModel.Text = ""
        txtCostPerDay.Text = ""
        txtRegNumber.Text = ""
        btnDeleteCar.Visible = False
        btnServiceHistory.Visible = False
        btnAddToService.Visible = False


        txtCarID.Focus()
    End Sub

    Private Sub lstCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCars.SelectedIndexChanged
        If lstCars.SelectedItem IsNot Nothing Then
            Dim SelectedCar As ListBoxData = lstCars.SelectedItem 'Holds the carid of the selected record
            DisplayCar(SelectedCar.Identifier)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnServiceHistory.Click
        CarServiceHistory.Show()
    End Sub

    Private Sub txtCostPerDay_TextChanged(sender As Object, e As EventArgs) Handles txtCostPerDay.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub BtnAddToService_Click(sender As Object, e As EventArgs) Handles btnAddToService.Click
        CheckIfInService = False
        CheckInService()
        If CheckIfInService = True Then
            MessageBox.Show("This car is already in service")

        ElseIf DbConnect() Then                                                                     'ADDING RETURNED CARS TO SERVICE
            Dim SQLCmd As New OleDbCommand

            With SQLCmd
                .Connection = cn
                .CommandText = "Insert into Service (CarID) Values (@CarID)"

                .Parameters.AddWithValue("@CarID", lblCarID.Text)
                .ExecuteNonQuery()
                MessageBox.Show("Car has been added for service")
            End With

        End If
        cn.Close()
    End Sub
    Private Sub CheckInService()
        '--------------------------------------------------------------
        'this procedure checks if the car is already in service and hasn't been repaired.
        '-----------------------------------------------------------------
        If DbConnect() Then


            Dim SQLCmd As New OleDbCommand 'Holds the SQL Command to be run
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Service Where CarID = @CarID and Repaired = False"
                .Parameters.AddWithValue("@CarID", lblCarID.Text)

                Dim rs As OleDbDataReader = .ExecuteReader() 'this excutes the query and rs will hold the service record that is returned.

                While rs.Read
                    If Not IsDBNull(rs("CarID")) Then
                        CheckIfInService = True ' a record was returned so the flag is now set to True.
                    End If


                End While
                rs.Close()

            End With
            cn.Close()
        End If
    End Sub

    Private Sub PanCars_Paint(sender As Object, e As PaintEventArgs) Handles panCars.Paint

    End Sub

    Private Sub StaffCars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datDatePurchased.MaxDate = Today.Date
        btnDeleteCar.Visible = False
        btnServiceHistory.Visible = False
        btnAddToService.Visible = False

    End Sub

    Private Sub txtCostPerDay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostPerDay.KeyPress
        'the following line checks if the characters entered in the text box are not digits.
        If Not Char.IsDigit(e.KeyChar) Then
            'this checks that the key pressed wasn't backspace.
            If Asc(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub TxtRegNumber_TextChanged(sender As Object, e As EventArgs) Handles txtRegNumber.TextChanged

    End Sub

    Private Sub txtRegNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRegNumber.KeyPress
        'the following line checks if the characters entered in the postcode text box are not letters, numbers or a space.
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And e.KeyChar <> " " Then
            'this checks that the key pressed wasn't backspace.
            If Asc(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub TxtCarMake_TextChanged(sender As Object, e As EventArgs) Handles txtCarMake.TextChanged

    End Sub

    Private Sub txtCarMake_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCarMake.KeyPress
        'the following line checks if the characters entered in the Surname text box are not letters, hypen or a space.
        If Not Char.IsLetter(e.KeyChar) And e.KeyChar <> "-" And e.KeyChar <> " " Then
            'this checks that the key pressed wasn't backspace.
            If Asc(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub TxtCarModel_TextChanged(sender As Object, e As EventArgs) Handles txtCarModel.TextChanged

    End Sub

    Private Sub txtCarModel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCarModel.KeyPress
        'the following line checks if the characters entered in the Surname text box are not letters, hypen or a space.
        If Not Char.IsLetter(e.KeyChar) And e.KeyChar <> "-" And e.KeyChar <> " " Then
            'this checks that the key pressed wasn't backspace.
            If Asc(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If

        End If
    End Sub
End Class