Public Class Homepage

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show(" Email address: autorental@gmail.com" +
                         " Contact number: 0161 123 456")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSignin.Click
        'panLogIn.Controls.Add(CustomerSign)
        'CustomerSign.Show()
        panFrmTemp.Visible = True
        panTemp.Visible = False
        DisplayForms(CustomerSignIn)
  

    End Sub
    Private Sub DisplayForms(FormTemplate As Form)

        panFrmTemp.Controls.Clear()
        FormTemplate.TopLevel = False
        panFrmTemp.Controls.Add(FormTemplate)
        FormTemplate.Show()
        FormTemplate.Location = New Point(0, 0)
        FormTemplate.FormBorderStyle = Windows.Forms.FormBorderStyle.None


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        'CustomerSignUp.Show()
        panFrmTemp.Visible = True
        panTemp.Visible = False
        DisplayForms(CustomerSignUp)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show(" We are a car rental company called ‘Auto Rental’. We are a British company which was founded in 1992. We are a car rental company which currently uses an online system where people can go and book their chosen cars for a certain amount of time. We rent out all sorts of cars and vehicles with different prices (e.g. sports cars, luxurious cars, vans etc.). The company also provides cars for people that a car immediately because they might have damaged their own car or their car is out of reach. The company only have 10 branches across the UK  ")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnStaff.Click
        'Me.Hide()
        'StaffLog.Show()
        panFrmTemp.Visible = True
        panTemp.Visible = False
        DisplayForms(StaffSignIn)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panFrmTemp.Visible = False
    End Sub

    Private Sub btnStaffSignUp_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Service.Show()

    End Sub

    Private Sub PanLogIn_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_3(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub
End Class
