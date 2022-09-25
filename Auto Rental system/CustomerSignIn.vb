Imports System.Data.OleDb
Public Class CustomerSignIn

    Public PublicCustomerName 'Holds name of the customer that has signed in
    Public PublicCustomerID 'Holds ID of the customer that has signed in
    Private Sub CustomerSign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear.PerformClick()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        PublicCustomerID = ""
        PublicCustomerName = ""
        txtUsername.Text = ""
        txtPassword.Text = ""




    End Sub


    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        'checks if log in detailsl are correct

        If DbConnect() Then

            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Customer Where (CustomerUsername = @CustomerUsername) and (CustomerPassword = @CustomerPassword)"
                .Parameters.AddWithValue("@CustomerUsername", txtUsername.Text)
                .Parameters.AddWithValue("@CustomerPassword", txtPassword.Text)
                Dim rs As OleDbDataReader = .ExecuteReader()

                If rs.Read Then
                    PublicCustomerName = rs("Firstname")
                    PublicCustomerID = rs("CustomerID")
                    Customer.Show()       'Customer page displayed if log in details are correct.
                    Homepage.Hide()

                Else
                    MessageBox.Show("Incorrect username or password")

                End If
                rs.Close()

            End With
            cn.Close()
        End If
        'Me.Close()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        btnClear.PerformClick()
        Homepage.panFrmTemp.Visible = False
        Homepage.panTemp.Visible = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class

