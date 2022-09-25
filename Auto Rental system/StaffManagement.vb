Imports System.Data.OleDb
Public Class StaffManagement
    Private CurrentStaffID As Integer = -1 'variable that is always set to -1 which means that a new staff record can be added.
    Private CheckUsername As Boolean = False ' A flag that will be set to TRUE if the username entered matches a username in the database.
    Private Sub CHUsernameExists(username)

        '--------------------------------------------------------------
        'this procedure checks if the username enetered by the customer already exists in the database.
        'the username enetered is specified in the username parameter
        '-----------------------------------------------------------------
        If DbConnect() Then


            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Staff Where StaffUsername = @StaffUsername"
                .Parameters.AddWithValue("@StaffUsername", username)

                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    If Not IsDBNull(rs("StaffUsername")) Then
                        CheckUsername = True
                    End If


                End While
                rs.Close()

            End With
            cn.Close()
        End If



    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        '-----------------------------------------
        'adds a new staff record in the database by storing data entered into the text boxes
        '----------------------------------------
        CheckUsername = False ' a flag that will always be false until it is changed to TRUE in the following procedure.
        CHUsernameExists(txtStaffUsername.Text)

        'Minimum lenght check

        If txtFirstName.Text.Length < 1 Then
            MessageBox.Show("You must enter your First Name", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFirstName.Focus()
        ElseIf txtSurname.Text.Length < 1 Then
            MessageBox.Show("You must enter your Surname", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSurname.Focus()
        ElseIf txtPostcode.Text.Length < 5 Then
            MessageBox.Show("You must enter a valid Postcode", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPostcode.Focus()
        ElseIf txtAddress.Text.Length < 3 Then
            MessageBox.Show("You must enter a valid Address", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAddress.Focus()
        ElseIf txtContactNumber.Text.Length < 11 Then
            MessageBox.Show("You must enter a valid Telephone Number", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContactNumber.Focus()
        ElseIf Val(txtSalary.Text) <= 0 Then
            MessageBox.Show("The Salary must be greater than £0.00", "Save Car", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSalary.Focus()
        ElseIf txtStaffUsername.Text.Length < 1 Then
            MessageBox.Show("You must enter a username", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtStaffUsername.Focus()
        ElseIf txtStaffPassword.Text.Length < 1 Then
            MessageBox.Show("You must enter a password", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtStaffPassword.Focus()
            'RANGE CHECK VALIDATION
        ElseIf datDateOfBirth.Value > Now.AddYears(-18) Then 'EXTREME TEST
            MessageBox.Show("You must be over the age of 18 to sign up", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CheckUsername = True Then
            MessageBox.Show("This username has been taken, please enter a different one")


        ElseIf DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            If CurrentStaffID = -1 Then

                SQLCmd.Connection = cn
                SQLCmd.CommandText = "Insert into Staff (SFirstname, SSurname, StaffUsername, StaffPassword, DateOfBirth, Postcode, StaffAddress, ContactNumber, Salary, AccessLevel) Values (@Firstname, @Surname, @StaffUsername, @StaffPassword, @DateOfBirth, @Postcode, @StaffAddress, @ContactNumber, @Salary, @AccessLevel)"
                SQLCmd.Parameters.AddWithValue("@Firstname", txtFirstName.Text)
                SQLCmd.Parameters.AddWithValue("@Surname", txtSurname.Text)
                SQLCmd.Parameters.AddWithValue("@StaffUsername", txtStaffUsername.Text)
                SQLCmd.Parameters.AddWithValue("@StaffPassword", txtStaffPassword.Text)
                SQLCmd.Parameters.AddWithValue("@DateOfBirth", datDateOfBirth.Value.Date)
                SQLCmd.Parameters.AddWithValue("@Postcode", txtPostcode.Text)
                SQLCmd.Parameters.AddWithValue("@StaffAddress", txtAddress.Text)
                SQLCmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text)
                SQLCmd.Parameters.AddWithValue("@Salary", txtSalary.Text)
                SQLCmd.Parameters.AddWithValue("@AccessLevel", txtAccessLevel.Text)

                SQLCmd.ExecuteNonQuery()
                SQLCmd.CommandText = "Select @@Identity"
                CurrentStaffID = SQLCmd.ExecuteScalar
                lblStaffID.Text = CurrentStaffID



            End If
            cn.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub TxtStaffUsername_TextChanged(sender As Object, e As EventArgs) Handles txtStaffUsername.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchStaff.Click
        If IsNumeric(txtStaffID.Text) Then
            DisplayStaff(txtStaffID.Text)
        ElseIf txtStaffSurname.Text.Length > 0 Then
            SearchStaffSurname(txtStaffSurname.Text)

        End If
        btnUpdateSalary.Visible = True
    End Sub
    Private Sub SearchStaffSurname(CustomerName As String)




        If DbConnect() Then

            lstStaff.Items.Clear()

            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Staff Where SSurname Like @StaffNameSearch"
                .Parameters.AddWithValue("@StaffNameSearch", "%" & txtStaffSurname.Text & "%")
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    Dim CustomerDisplayValue As String = rs("SFirstName") & vbTab & rs("SSurname")
                    Dim StaffItem As New ListBoxData(CustomerDisplayValue, rs("StaffID"))
                    lstStaff.Items.Add(StaffItem)
                End While

                rs.Close()
                If lstStaff.Items.Count > 1 Then

                    'SHOWING THE LIST

                    panStaffSearchList.Visible = True
                Else
                    panStaffSearchList.Visible = False
                    If lstStaff.Items.Count = 0 Then
                        MessageBox.Show("There are no staff with that name", "Find Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        lstStaff.SelectedIndex = 0
                    End If
                End If
            End With
            cn.Close()
        End If
    End Sub
    Private Sub DisplayStaff(StaffID As Integer)

        '-------------------------------------------
        'Find Staff record with the ID specified in the StaffID parameter
        'Display the Staff record in the text boxes
        '--------------------------------------------
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            SQLCmd.Connection = cn
            SQLCmd.CommandText = "Select * From Staff Where StaffID = @StaffID and AccessLevel = @AccessLevel"
            SQLCmd.Parameters.AddWithValue("@StaffID", StaffID)
            SQLCmd.Parameters.AddWithValue("@AccessLevel", "STAFF")

            Dim rs As OleDbDataReader = SQLCmd.ExecuteReader()

            If rs.Read Then
                CurrentStaffID = StaffID
                lblStaffID.Text = rs("StaffID")
                txtFirstName.Text = rs("SFirstname")
                txtSurname.Text = rs("SSurname")
                datDateOfBirth.Value = rs("DateOfBirth")
                txtPostcode.Text = rs("Postcode")
                txtContactNumber.Text = rs("ContactNumber")
                txtAddress.Text = rs("StaffAddress")
                txtSalary.Text = rs("Salary")
                txtStaffUsername.Text = rs("StaffUsername")
                txtStaffPassword.Text = rs("StaffPassword")

                btnDelete.Enabled = True
                btnCreate.Enabled = False

            Else
                MessageBox.Show("Could not find Staff with ID" & StaffID, "Find Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            rs.Close()
            cn.Close()
        End If
    End Sub

    Private Sub BtnDeleteCust_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        'Deletes record of the selected staff

        If MessageBox.Show("Confirm delete?", "Delete Staff", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) = DialogResult.OK Then
            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Delete * From Staff Where StaffID = @StaffID"
                    .Parameters.AddWithValue("@StaffID", CurrentStaffID)
                    .ExecuteNonQuery()
                    btnCustomerClear.PerformClick()
                End With
                cn.Close()
                btnSearchStaff.PerformClick()
                btnClear.PerformClick()

            End If
        End If
    End Sub

    Private Sub LstStaff_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStaff.SelectedIndexChanged
        If lstStaff.SelectedItem IsNot Nothing Then
            Dim SelectedStaff As ListBoxData = lstStaff.SelectedItem
            DisplayStaff(SelectedStaff.Identifier)
            btnUpdateSalary.Visible = True
        End If
    End Sub

    Private Sub StaffSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnCreate.Enabled = True
        btnUpdateSalary.Visible = False
        btnDelete.Enabled = False
        txtStaffUsername.PasswordChar = Chr(151)
        txtStaffPassword.PasswordChar = Chr(151)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        CurrentStaffID = -1
        lblStaffID.Text = "<automatically generated>"
        txtFirstName.Text = ""
        txtSurname.Text = ""
        txtPostcode.Text = ""
        txtContactNumber.Text = ""
        txtAddress.Text = ""
        txtSalary.Text = ""
        txtStaffUsername.Text = ""
        txtStaffPassword.Text = ""
        btnUpdateSalary.Visible = False
        btnCreate.Enabled = True
    End Sub

    Private Sub BtnUpdateSalary_Click(sender As Object, e As EventArgs) Handles btnUpdateSalary.Click

        'Updates the salary field in the record of the selected staff

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand

            With SQLCmd
                .Connection = cn
                .CommandText = "Update Staff Set Salary = @Salary Where StaffID = @StaffID"


                .Parameters.AddWithValue("@Salary", txtSalary.Text)
                .Parameters.AddWithValue("@StaffID", CurrentStaffID)

                .ExecuteNonQuery()
            End With
            MessageBox.Show("The salary has been updated")
        End If
        cn.Close()
    End Sub

    Private Sub TxtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
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

    Private Sub TxtContactNumber_TextChanged(sender As Object, e As EventArgs) Handles txtContactNumber.TextChanged

    End Sub

    Private Sub txtContactNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactNumber.KeyPress
        'the following line checks if the characters entered in the text box are not digits.
        If Not Char.IsDigit(e.KeyChar) Then
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

    Private Sub TxtSalary_TextChanged(sender As Object, e As EventArgs) Handles txtSalary.TextChanged

    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        'the following line checks if the characters entered in the text box are not digits.
        If Not Char.IsDigit(e.KeyChar) Then
            'this checks that the key pressed wasn't backspace.
            If Asc(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If

        End If
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

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class