Imports System.Data.OleDb
Public Class Service

    Private Sub lstCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCarsInService.SelectedIndexChanged
        If lstCarsInService.SelectedItem IsNot Nothing Then
            Dim SelectedService As ListBoxData = lstCarsInService.SelectedItem
            DisplayCar(SelectedService.Identifier)
            CarServiceHistory()


        End If
    End Sub
    Private Sub CarServiceHistory()

        'displays service history of the selected car

        If DbConnect() Then

            lstServiceHistory.Items.Clear()

            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Service Where CarID = @CarID and Repaired = True"
                .Parameters.AddWithValue("@CarID", lblCarID.Text)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    Dim DisplayValue As String = rs("ServiceID") & "                      " & rs("RepairDate") & " "
                    Dim ServiceItem As New ListBoxData(DisplayValue, rs("ServiceID"))
                    lstServiceHistory.Items.Add(ServiceItem)
                End While
                rs.Close()

            End With
            cn.Close()

        End If
    End Sub

    Private Sub ServiceCars()

        'Displays all the service records in service that have no been recorded as repaired

        If DbConnect() Then

            lstCarsInService.Items.Clear()

            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Service Where Repaired = False"
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    Dim DisplayValue As String = rs("ServiceID") & "                " & rs("CarID") & " "
                    Dim ServiceItem As New ListBoxData(DisplayValue, rs("ServiceID"))
                    lstCarsInService.Items.Add(ServiceItem)
                End While
                rs.Close()

            End With
            cn.Close()

        End If

        If lstCarsInService.Items.Count = 0 Then
            lstCarsInService.Enabled = False
            Dim DisplayMessage As String = "There are no cars in service"
            lstCarsInService.Items.Add(DisplayMessage)
        End If
    End Sub

    Private Sub DisplayCar(ServiceID As Integer)

        ' Displays the cars details of the car in the selected service record

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select Cars.CarID, Cars.CarMake, Cars.CarModel, ServiceID " &
                    "From Service " &
                    "inner join Cars on Service.CarID = Cars.CarID " &
                    "Where (ServiceID = @ServiceID) and (Service.CarID = Cars.CarID)"
                .Parameters.AddWithValue("@ServiceID", ServiceID)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    lblCarID.Text = rs("CarID")
                    txtCarMake.Text = rs("CarMake")
                    txtCarModel.Text = rs("CarModel")
                    lblServiceID.Text = rs("ServiceID")
                End While
                rs.Close()
            End With
            cn.Close()


        End If

    End Sub


    Private Sub Service_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtCarMake.Text = ""
        txtCarModel.Text = ""
        txtFaultDetails.Text = ""
        txtRepairDetails.Text = ""
        lblServiceID.Text = ""
        ServiceCars()



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lstCarsInService.SelectedItem IsNot Nothing Then

            Dim SelectedService As ListBoxData = lstCarsInService.SelectedItem
            SaveCarService(SelectedService.Identifier)

        End If
    End Sub
    Private Sub SaveCarService(SelectedService As Integer)

        Dim Repaired As Boolean 'same as the variables in the OverDue Orders form
        Dim CurrentDate As Date
        CurrentDate = Now
        Repaired = True


        'Presence check
        If txtFaultDetails.Text.Length < 1 Then
            MessageBox.Show("You must enter fault details", "Save Service", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFaultDetails.Focus()
            txtFaultDetails.ForeColor = Color.DarkRed
        ElseIf txtRepairDetails.Text.Length < 1 Then
            MessageBox.Show("You must enter repair details", "Save Service", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRepairDetails.Focus()

        ElseIf DbConnect() Then
            Dim SQLCmd As New OleDbCommand

            With SQLCmd
                .Connection = cn
                .CommandText = "Update Service Set RepairDate = @RepairDate, FaultDetails = @FaultDetails, RepairDetails = @RepairDetails, Repaired = @Repaired Where ServiceID = @SelectedService"
                .Parameters.AddWithValue("@RepairDate", CurrentDate.Date)
                .Parameters.AddWithValue("@FaultDetails", txtFaultDetails.Text)
                .Parameters.AddWithValue("@RepairDetails", txtRepairDetails.Text)
                .Parameters.AddWithValue("@Repaired", Repaired)
                .Parameters.AddWithValue("@SelectedService", SelectedService)


                .ExecuteNonQuery()
            End With
            txtCarMake.Text = ""
            txtCarModel.Text = ""
            txtFaultDetails.Text = ""
            txtRepairDetails.Text = ""
            ServiceCars()
        End If
        cn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub



    Private Sub datRepairDate_ValueChanged(sender As Object, e As EventArgs) Handles datRepairDate.ValueChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub LstServiceHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstServiceHistory.SelectedIndexChanged
        If lstServiceHistory.SelectedItem IsNot Nothing Then
            Dim SelectedService As ListBoxData = lstServiceHistory.SelectedItem
            DisplayCarServiceHistory(SelectedService.Identifier)


        End If
    End Sub
    Private Sub DisplayCarServiceHistory(ServiceID As Integer)

        ' Displays the service history of the car that is selected

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Service Where ServiceID = @ServiceID "
                .Parameters.AddWithValue("@ServiceID", ServiceID)
                Dim rs As OleDbDataReader = .ExecuteReader()

                While rs.Read
                    txtHFaultDetails.Text = rs("FaultDetails")
                    txtHRepairDetails.Text = rs("RepairDetails")
                    datRepairDate.Value = rs("RepairDate")

                End While
                rs.Close()
            End With
            cn.Close()


        End If

    End Sub
End Class