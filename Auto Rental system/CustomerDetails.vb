Imports System.Data.OleDb
Public Class CustomerDetails
    Private CustomerID As Integer ' Holds the ID of the customer that is signed in
    Private CheckUsername As Boolean = False 'Flag set to false until a username is found that matches the username that has been entered


    Private Sub CustomerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'finds the customer record of the customer that is signed in and displays their details.


        If DbConnect() Then



            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Customer where (CustomerID = @CustomerID)"
                .Parameters.AddWithValue("@CustomerID", Customer.lblCustomerID.Text)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read         'Displays customers deatils
                    txtCustomerID.Text = rs("CustomerID")
                    txtFirstname.Text = rs("Firstname")
                    txtSurname.Text = rs("Surname")
                    datDoB.Value = rs("DateOfBirth")
                    txtPostcode.Text = rs("Postcode")
                    txtTelNo.Text = rs("ContactNumber")
                    txtUsername.Text = rs("CustomerUsername")
                    txtPassword.Text = rs("CustomerPassword")
                    txtAddress.Text = rs("CustomerAddress")
                    CustomerID = rs("CustomerID")
                End While
                rs.Close()

            End With
            cn.Close()

        End If
    End Sub
    Private Sub CHUsernameExists(username)
        'Checks if the useranem entered by the customer alredy exists.

        If DbConnect() Then


            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Customer Where CustomerUsername = @CustomerUsername"
                .Parameters.AddWithValue("@CustomerUsername", username)

                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    If Not IsDBNull(rs("CustomerUsername")) Then
                        CheckUsername = True
                    End If


                End While
                rs.Close()

            End With
            cn.Close()
        End If



    End Sub


    Private Sub btnUpdateDetails_Click(sender As Object, e As EventArgs) Handles btnUpdateDetails.Click

        'Upadtes the record of the customer with the new deatils that have been entered.

        'minimum length check
        If txtPostcode.Text.Length < 5 Then
            MessageBox.Show("You must enter a valid Postcode", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPostcode.Focus()
        ElseIf txtAddress.Text.Length < 3 Then
            MessageBox.Show("You must enter a valid Address", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAddress.Focus()
        ElseIf txtTelNo.Text.Length < 11 Then
            MessageBox.Show("You must enter a valid Telephone Number", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTelNo.Focus()


        ElseIf DbConnect() Then
            Dim SQLCmd As New OleDbCommand

            With SQLCmd
                .Connection = cn
                .CommandText = "Update Customer Set Postcode = @Postcode, ContactNumber = @ContactNumber, CustomerAddress = @CustomerAddress Where CustomerID = @CustomerID"


                .Parameters.AddWithValue("@Postcode", txtPostcode.Text)
                .Parameters.AddWithValue("@ContactNumber", txtTelNo.Text)
                .Parameters.AddWithValue("@CustomerAddress", txtAddress.Text)
                .Parameters.AddWithValue("@CustomerID", CustomerID)

                .ExecuteNonQuery()
            End With
            MessageBox.Show("Your personal information has been updated")
        End If
        cn.Close()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click
        CheckIfExistingOrder()

    End Sub
    Private Sub CheckIfExistingOrder()

        'Checks if the user has an existing or before letting them delete the account
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders where CustomerID = @CustomerID and Returned = False or Paid = False"
                .Parameters.AddWithValue("@CustomerID", CustomerID)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    If txtCustomerID.Text = rs("CustomerID") Then

                        MessageBox.Show("return existing order")

                        btnDeleteAccount.Enabled = False
                    Else
                        DeleteAccount() 'if there is no existing order then account can be deleted.



                    End If
                End While
                rs.Close()
            End With
            cn.Close()
        End If

    End Sub


    Private Sub DeleteAccount()

        'Deletes the customer record

        If MessageBox.Show("Confirm delete?", "Delete Customer", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) = DialogResult.OK Then
            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Delete * From Customer Where CustomerID = @Customer"
                    .Parameters.AddWithValue("@CustomerID", CustomerID)
                    .ExecuteNonQuery()
                    Customer.btnSignOut.PerformClick()
                End With
                cn.Close()


            End If

            'deletes are order records of the customer

            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Delete * From tblOrders Where CustomerID = @CustomerID"
                    .Parameters.AddWithValue("@CustomerID", CustomerID)
                    .ExecuteNonQuery()
                End With
                cn.Close()
            End If
        End If


    End Sub


    Private Sub BtnUpdateLog_Click(sender As Object, e As EventArgs) Handles btnUpdateLog.Click

        'Updates the log in deatails

        CheckUsername = False
        CHUsernameExists(txtUsername.Text) 'first checks if new username already exists.
        'minimum lenght check
        If txtUsername.Text.Length < 1 Then
            MessageBox.Show("You must enter a username", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Focus()
        ElseIf txtPassword.Text.Length < 1 Then
            MessageBox.Show("You must enter a password", "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPassword.Focus()
        ElseIf CheckUsername = True Then
            MessageBox.Show("This username has been taken, please enter a different one")


        ElseIf DbConnect() Then
            Dim SQLCmd As New OleDbCommand

            With SQLCmd
                .Connection = cn
                .CommandText = "Update Customer Set CustomerUsername = @CustomerUsername, CustomerPassword = @CustomerPassword Where CustomerID = @CustomerID"
                .Parameters.AddWithValue("@CustomerUsername", txtUsername.Text)
                .Parameters.AddWithValue("@CustomerPassword", txtPassword.Text)
                .Parameters.AddWithValue("@CustomerID", CustomerID)

                .ExecuteNonQuery()
            End With
            MessageBox.Show("Your Log in details have been updated")
            cn.Close()
        End If

    End Sub

    Private Sub TxtPostcode_TextChanged(sender As Object, e As EventArgs) Handles txtPostcode.TextChanged

    End Sub

    Private Sub TxtTelNo_TextChanged(sender As Object, e As EventArgs) Handles txtTelNo.TextChanged

    End Sub

    Private Sub txtTelNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelNo.KeyPress
        'the following line checks if the characters entered in the text box are not digits.
        If Not Char.IsDigit(e.KeyChar) Then
            'this checks that the key pressed wasn't backspace.
            If Asc(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If

        End If
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
End Class