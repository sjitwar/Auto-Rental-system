Imports System.Data.OleDb
Public Class StaffDetails
    Private StaffID As Integer ' Holds the ID of the staff that is signed in
    Private CheckUsername As Boolean = False 'Flag set to false until a username is found that matches the username that has been entered

    Private Sub StaffDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'finds the Staff record of the customer that is signed in and displays their details.


        txtSalary.Text = FormatCurrency(0)


        If DbConnect() Then



            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Staff where (StaffID = @StaffID)"
                .Parameters.AddWithValue("@StaffID", Staff.lblStaffID.Text)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    txtStaffID.Text = rs("StaffID")
                    txtFirstname.Text = rs("SFirstname")
                    txtSurname.Text = rs("SSurname")
                    datDoB.Value = rs("DateOfBirth")
                    txtPostcode.Text = rs("Postcode")
                    txtTelNo.Text = rs("ContactNumber")
                    txtUsername.Text = rs("StaffUsername")
                    txtPassword.Text = rs("StaffPassword")
                    txtAddress.Text = rs("StaffAddress")
                    txtSalary.Text = rs("Salary")
                    StaffID = rs("StaffID")
                End While
                rs.Close()

            End With
            cn.Close()

        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnUpdateDetails_Click(sender As Object, e As EventArgs) Handles btnUpdateDetails.Click

        'Upadtes the record of the customer with the new deatils that have been entered.


        'minimum length check
        If txtPostcode.Text.Length < 6 Then
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
                .CommandText = "Update Staff Set Postcode = @Postcode, ContactNumber = @ContactNumber, StaffAddress = @StaffAddress Where StaffID = @StaffID"


                .Parameters.AddWithValue("@Postcode", txtPostcode.Text)
                .Parameters.AddWithValue("@ContactNumber", txtTelNo.Text)
                .Parameters.AddWithValue("@StaffAddress", txtAddress.Text)
                .Parameters.AddWithValue("@StaffID", StaffID)

                .ExecuteNonQuery()

            End With
            MessageBox.Show("Your personal information has been updated")


        End If
        cn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub CHUsernameExists(username)

        'Checks if the useranem entered by the customer alredy exists.

        If DbConnect() Then


            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Staff Where (StaffUsername = @StaffUsername) and (Not Exists(Select * From Staff Where StaffUsername = @StaffUsername and StaffID = @StaffID)) "

                .Parameters.AddWithValue("@StaffUsername", username)
                .Parameters.AddWithValue("@StaffID", Staff.lblStaffID)


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


    Private Sub BtnUpdateLog_Click(sender As Object, e As EventArgs) Handles btnUpdateLog.Click

        'Updates the log in deatils of the staff

        CheckUsername = False
        CHUsernameExists(txtUsername.Text)

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
                .CommandText = "Update Staff Set StaffUsername = @StaffUsername, StaffPassword = @StaffPassword Where StaffID = @StaffID"
                .Parameters.AddWithValue("@StaffUsername", txtUsername.Text)
                .Parameters.AddWithValue("@StaffPassword", txtPassword.Text)
                .Parameters.AddWithValue("@StaffID", StaffID)

                .ExecuteNonQuery()

            End With
            MessageBox.Show("Your Log in details have been updated")


        End If
        cn.Close()

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
End Class