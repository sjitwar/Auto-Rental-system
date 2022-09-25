Imports System.Data.OleDb
Public Class CustomerSignUp
    Private CurrentCustomerID As Integer = -1 'variable that is always set to -1 which means that a new customer can be added.
    Private CheckUsername As Boolean = False ' A flag that will be set to TRUE if the username entered matches a username in the database.
    Private Sub CHUsernameExists(username)
        '--------------------------------------------------------------
        'this procedure checks if the username enetered by the customer already exists in the database.
        'the username enetered is specified in the username parameter
        '-----------------------------------------------------------------
        If DbConnect() Then


            Dim SQLCmd As New OleDbCommand 'Holds the SQL Command to be run
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Customer Where CustomerUsername = @CustomerUsername"
                .Parameters.AddWithValue("@CustomerUsername", username)

                Dim rs As OleDbDataReader = .ExecuteReader() 'this excutes the query and rs will hold the username that is returned.

                While rs.Read
                    If Not IsDBNull(rs("CustomerUsername")) Then
                        CheckUsername = True ' a username was returned so the flag is now set to True.
                    End If


                End While
                rs.Close()

            End With
            cn.Close()
        End If



    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        '-----------------------------------------
        'add a customer record in the database by storing data entered into the text boxes
        '----------------------------------------

        CheckUsername = False ' a flag that will always be false until it is changed to TRUE in the following procedure.
        CHUsernameExists(txtCustomerUsername.Text)



        'the following lines are minimum length checks

        If txtFirstname.Text.Length < 1 Then
            MessageBox.Show("You must enter your First Name", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFirstname.Focus()
            txtFirstname.ForeColor = Color.DarkRed
        ElseIf txtSurname.Text.Length < 1 Then
            MessageBox.Show("You must enter your Surname", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSurname.Focus()
        ElseIf txtPostcode.Text.Length < 5 Then
            MessageBox.Show("Please enter a valid Postcode", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPostcode.Focus()
        ElseIf txtAddress.Text.Length < 3 Then
            MessageBox.Show("Please enter a valid Address", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAddress.Focus()
        ElseIf txtNumber.Text.Length < 11 Then
            MessageBox.Show("Please enter a valid Telephone Number", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNumber.Focus()
        ElseIf txtCustomerUsername.Text.Length < 1 Then
            MessageBox.Show("You must enter a username", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCustomerUsername.Focus()
        ElseIf txtCustomerPassword.Text.Length < 1 Then
            MessageBox.Show("You must enter a password", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCustomerPassword.Focus()

            'the following line is a range check that checks if the customer signing up is under 18 years old.

        ElseIf datDOB.Value > Now.AddYears(-18) Then
            MessageBox.Show("You must be over the age of 18 to sign up", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)



        ElseIf CheckUsername = True Then 'checks if flag has been set to True which would mean the username enterd already exists therefore displays the following message.
            MessageBox.Show("This username has been taken, please enter a different one")


            'if everthing is valid then 
        ElseIf DbConnect() Then
            Dim SQLCmd As New OleDbCommand 'Holds the SQL Command to be run
            If CurrentCustomerID = -1 Then

                'add a new customer record

                SQLCmd.Connection = cn
                SQLCmd.CommandText = "Insert into Customer (Firstname, Surname, DateOfBirth, Postcode, CustomerAddress, ContactNumber, CustomerUsername, CustomerPassword) Values (@Firstname, @Surname, @DateOfBirth, @Postcode, @CustomerAddress, @ContactNumber, @CustomerUsername, @CustomerPassword)"
                SQLCmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text)
                SQLCmd.Parameters.AddWithValue("@Surname", txtSurname.Text)
                SQLCmd.Parameters.AddWithValue("@DateOfBirth", datDOB.Value.Date)
                SQLCmd.Parameters.AddWithValue("@Postcode", txtPostcode.Text)
                SQLCmd.Parameters.AddWithValue("@CustomerAddress", txtAddress.Text)
                SQLCmd.Parameters.AddWithValue("@ContactNumber", txtNumber.Text)
                SQLCmd.Parameters.AddWithValue("@CustomerUsername", txtCustomerUsername.Text)
                SQLCmd.Parameters.AddWithValue("@CustomerPassword", txtCustomerPassword.Text)

                SQLCmd.ExecuteNonQueryAsync()
                SQLCmd.CommandText = "Select @@Identity"
                CurrentCustomerID = SQLCmd.ExecuteScalar
                lblCustomerID.Text = CurrentCustomerID

                MessageBox.Show("Account created")
                butNew.PerformClick()
            End If
            cn.Close()
        End If

    End Sub

    Private Sub butNew_Click(sender As Object, e As EventArgs) Handles butNew.Click

        CurrentCustomerID = -1 'variable set to -1 for a new customer 

        'Clears all text boxes in the form

        lblCustomerID.Text = "ID"
        txtNumber.Text = ""
        txtNumber.Text = ""
        txtNumber.Text = ""
        txtSurname.Text = ""
        txtFirstname.Text = ""
        txtPostcode.Text = ""
        txtAddress.Text = ""
        datDOB.Value = Now.AddYears(-18)
        txtCustomerUsername.Text = ""
        txtCustomerPassword.Text = ""
    End Sub

    Private Sub BookCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        butNew.PerformClick()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        txtNumber.Text = ""

    End Sub

    Private Sub btnAutoPass_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LstCars_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCarID_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'exits the Sign Up page back to the homepage
        butNew.PerformClick()
        Homepage.panFrmTemp.Visible = False
        Homepage.panTemp.Visible = True
    End Sub

    Private Sub LblCustomerID_Click(sender As Object, e As EventArgs) Handles lblCustomerID.Click

    End Sub



    Private Sub TxtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged

    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        'the following line checks if the characters entered in the text box are not digits.
        If Not Char.IsDigit(e.KeyChar) Then
            'this checks that the key pressed wasn't backspace.
            If Asc(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub TxtFirstname_TextChanged(sender As Object, e As EventArgs) Handles txtFirstname.TextChanged

    End Sub

    Private Sub txtFirstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstname.KeyPress
        'the following line checks if the characters entered in the First name text box are not letters, hypen or apostrophe.
        If Not Char.IsLetter(e.KeyChar) And e.KeyChar <> "-" And e.KeyChar <> "'" Then
            'this checks that the key pressed wasn't backspace.
            If Asc(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub TxtSurname_TextChanged(sender As Object, e As EventArgs) Handles txtSurname.TextChanged

    End Sub

    Private Sub txtSurname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSurname.KeyPress
        'the following line checks if the characters entered in the Surname text box are not letters, hypen, apostrophe or a space.
        If Not Char.IsLetter(e.KeyChar) And e.KeyChar <> "-" And e.KeyChar <> "'" And e.KeyChar <> " " Then
            'this checks that the key pressed wasn't backspace.
            If Asc(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub TxtPostcode_TextChanged(sender As Object, e As EventArgs) Handles txtPostcode.TextChanged

    End Sub

    Private Sub txtPostcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPostcode.KeyPress
        'the following line checks if the characters entered in the postcode text box are not letters, numbers or a space.
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And e.KeyChar <> " " Then
            'this checks that the key pressed wasn't backspace.
            If Asc(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub TxtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub txtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress
        'the following line checks if the characters entered in the postcode text box are not letters, numbers or a space.
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And e.KeyChar <> " " Then
            'this checks that the key pressed wasn't backspace.
            If Asc(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class