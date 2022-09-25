Imports System.Data.OleDb
Public Class Customer
    Private CheckExistingOrder As Boolean = False ' a flag set to False, if true customer can not access the booking form


    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        dateCollectCar.MinDate = Now.Date
        dateReturnCar.MinDate = Now.AddDays(+1)
        panFrmTemplate.Visible = True

        lblCustomerName.Text = CustomerSignIn.PublicCustomerName
        lblCustomerID.Text = CustomerSignIn.PublicCustomerID


        dateCollect.Value = Now
        dateReturn.Value = Now.AddDays(+7)
        txtTotalCost.Text = FormatCurrency(0)

        btnConfirmOrder.Enabled = False

        btnMyDetails.PerformClick()




    End Sub
    Private Sub CheckIfExistingOrder()

        'Checks if the user that is signed in has an existing order that hasn;t been returned or paid

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From tblOrders where CustomerID = @CustomerID and Returned = False or Paid = False"
                .Parameters.AddWithValue("@CustomerID", lblCustomerID.Text)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    If lblCustomerID.Text = rs("CustomerID") Then


                        CheckExistingOrder = True







                    End If
                End While
                rs.Close()
            End With
            cn.Close()
        End If

    End Sub









    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCostPerDay.TextChanged

    End Sub

    Private Sub btnShowAllCars_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblCustName_Click(sender As Object, e As EventArgs) Handles lblCustomerName.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Close()
        Homepage.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub



    Private Sub txtTotalCost_TextChanged(sender As Object, e As EventArgs) Handles txtTotalCost.TextChanged

    End Sub

    Private Sub txtTotalDays_TextChanged(sender As Object, e As EventArgs) Handles txtTotalDays.TextChanged

    End Sub







    Private Sub lstTest_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub





    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub LblCarID_Click(sender As Object, e As EventArgs) Handles lblCarID.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        panFrmTemplate.Visible = True
        CustOrderDetails.Refresh()
        DisplayForms(CustOrderDetails)

    End Sub
    Private Sub DisplayForms(FormTemplate As Form)

        panFrmTemplate.Controls.Clear()
        FormTemplate.TopLevel = False
        panFrmTemplate.Controls.Add(FormTemplate)
        FormTemplate.Show()
        FormTemplate.Location = New Point(0, 0)
        FormTemplate.FormBorderStyle = Windows.Forms.FormBorderStyle.None


    End Sub

    Private Sub BtnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click

        CheckIfExistingOrder()
        If CheckExistingOrder = True Then
            MessageBox.Show("You are not able to make a booking because you have an existing order or you have got an overdue order")
            btnBooking.Enabled = False            'Booking form cannot be displayed
        Else
            panFrmTemplate.Visible = True
            DisplayForms(Booking)                    'Displays booking form
        End If

    End Sub

    Private Sub panFrmTemplate_Paint(sender As Object, e As PaintEventArgs) Handles panFrmTemplate.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMyDetails.Click
        panFrmTemplate.Visible = True
        DisplayForms(CustomerDetails)
    End Sub

    Private Sub panBooking_Paint(sender As Object, e As PaintEventArgs) Handles panBooking.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        btnSearchAVCars.PerformClick()
        txtCarMake.Text = ""
        txtCarModel.Text = ""
        txtCostPerDay.Text = ""
        txtTotalCost.Text = ""

    End Sub

    Private Sub DateCollectCar_ValueChanged(sender As Object, e As EventArgs) Handles dateCollectCar.ValueChanged

    End Sub

    Private Sub LblCollect_Click(sender As Object, e As EventArgs) Handles lblCollect.Click

    End Sub

    Private Sub BtnSearchCar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class


