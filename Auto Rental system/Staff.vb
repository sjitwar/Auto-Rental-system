Imports System.Data.OleDb

Public Class Staff
    Private CurrentCarID As Integer = -1
    Private Sub DisplayForms(FormTemplate As Form)

        panFrmTemplate.Controls.Clear()
        FormTemplate.TopLevel = False
        panFrmTemplate.Controls.Add(FormTemplate)
        FormTemplate.Show()
        FormTemplate.Location = New Point(0, 0)
        FormTemplate.FormBorderStyle = Windows.Forms.FormBorderStyle.None


    End Sub













    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        'Reports.Show()
        DisplayForms(Reports)

    End Sub








    Private Sub txtCustomerName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtCarStock_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCarName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lblStaffName.Text = StaffSignIn.PublicStaffName
        lblStaffID.Text = StaffSignIn.PublicStaffID
        btnCarsManagement.PerformClick()

    End Sub






    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrdersManagement.Click
        'Me.Hide()
        'Orders.Show()
        DisplayForms(OrdersManagement)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnService_Click(sender As Object, e As EventArgs) Handles btnService.Click
        DisplayForms(Service)
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnCustomersManagement.Click
        'panCustomers.Visible = True
        'panCars.Visible = False
        DisplayForms(CustomersManagement)

    End Sub

    Private Sub panCustomers_Paint(sender As Object, e As PaintEventArgs)

    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnOverdueOrders.Click
        'OverDue.Show()
        DisplayForms(OverDueOrders)
    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnStaffManagement.Click
        DisplayForms(StaffManagement)
    End Sub

    Private Sub panFrmTemplate_Paint(sender As Object, e As PaintEventArgs) Handles panFrmTemplate.Paint

    End Sub

    Private Sub btnCars_Click(sender As Object, e As EventArgs) Handles btnCarsManagement.Click
        DisplayForms(CarsManagement)
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Close()
        Homepage.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnStaffDetails.Click
        DisplayForms(StaffDetails)
    End Sub
End Class