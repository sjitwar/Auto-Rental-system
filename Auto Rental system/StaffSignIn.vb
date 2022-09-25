Imports System.Data.OleDb
Public Class StaffSignIn
    Public PublicStaffName 'Holds name of the satff that has signed in
    Public PublicStaffID 'Holds ID of the satff that has signed in

    Private Sub BtnStaffLog_Click(sender As Object, e As EventArgs) Handles BtnStaffLog.Click
        If checkAdmin.Checked = True Then
            AdminSignIn()
        Else
            StaffSignIn()

        End If

    End Sub
    Private Sub AdminSignIn()

        'checks if log in detailsl are correct for ADMIN sign in

        Dim AccessLevel As String = "Admin" 'used as a parameter below

        If DbConnect() Then

            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Staff Where (StaffUsername = @StaffUsername) and (StaffPassword = @StaffPassword) and (AccessLevel = @AccessLevel)"
                .Parameters.AddWithValue("@StaffUsername", TxtUsername.Text)
                .Parameters.AddWithValue("@StaffPassword", TxtPassword.Text)
                .Parameters.AddWithValue("@AccessLevel", AccessLevel)

                Dim rs As OleDbDataReader = .ExecuteReader()

                If rs.Read Then
                    PublicStaffName = rs("SFirstname")
                    PublicStaffID = rs("StaffID")
                    Staff.Show() 'Staff page displayed if log in details are correct.
                    Homepage.Hide()
                Else
                    MessageBox.Show("incorrect details")

                End If
                rs.Close()

            End With
            cn.Close()
        End If

    End Sub
    Private Sub StaffSignIn()
        'checks if log in detailsl are correct for ADMIN sign in

        Dim AccessLevel As String = "Staff" 'used as a parameter below

        If DbConnect() Then

            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Staff Where (StaffUsername = @StaffUsername) and (StaffPassword = @StaffPassword) and (AccessLevel = @AccessLevel)"
                .Parameters.AddWithValue("@StaffUsername", TxtUsername.Text)
                .Parameters.AddWithValue("@StaffPassword", TxtPassword.Text)
                .Parameters.AddWithValue("@AccessLevel", AccessLevel)

                Dim rs As OleDbDataReader = .ExecuteReader()

                If rs.Read Then
                    PublicStaffName = rs("SFirstname")
                    PublicStaffID = rs("StaffID")

                    Staff.Show()
                    Staff.btnStaffManagement.Enabled = False
                    Staff.btnReports.Enabled = False
                    Homepage.Hide()

                Else
                    MessageBox.Show("incorrect details")

                End If
                rs.Close()

            End With
            cn.Close()
        End If

    End Sub

    Private Sub StaffLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PublicStaffID = ""
        PublicStaffName = ""
        TxtUsername.Text = ""
        TxtPassword.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TxtUsername.Text = ""
        TxtPassword.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        btnClear.PerformClick()
        Homepage.panFrmTemp.Visible = False
        Homepage.panTemp.Visible = True

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class