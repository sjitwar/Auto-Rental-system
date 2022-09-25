Imports System.Data.OleDb
Public Class CarServiceHistory

    Private Sub CarServiceHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarServiceHistory(CarsManagement.lblCarID.Text)
    End Sub
    Private Sub CarServiceHistory(CarID As Integer)
        '-------------------------------
        'Selects servive records of the car with ID specified in the CarID parameter
        '---------------------------------------

        If DbConnect() Then

            lstPreviousHistory.Items.Clear()

            Dim SQLCmd As New OleDbCommand 'Holds the SQL Command to be run
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Service Where (CarID = @CarID) and (Repaired = True)"
                .Parameters.AddWithValue("@CarID", CarID)
                Dim rs As OleDbDataReader = .ExecuteReader() 'this excutes the query and rs will hold the service record set that is returned.

                While rs.Read
                    Dim DisplayValue As String = rs("ServiceID") & "               " & rs("RepairDate") & " "
                    Dim ServiceItem As New ListBoxData(DisplayValue, rs("ServiceID"))
                    'Adds the service record(S) to the list box
                    lstPreviousHistory.Items.Add(ServiceItem)
                End While
                rs.Close()

            End With
            cn.Close()

        End If
    End Sub

    Private Sub LstPreviousHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPreviousHistory.SelectedIndexChanged
        If lstPreviousHistory.SelectedItem IsNot Nothing Then
            Dim SelectedService As ListBoxData = lstPreviousHistory.SelectedItem 'this variable holds the serviceID of the record selected from the list box
            DisplayCar(SelectedService.Identifier)
        End If
    End Sub
    Private Sub DisplayCar(ServiceID As Integer)

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand 'Holds the SQL Command to be run
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Service Where (ServiceID = @ServiceID)"
                .Parameters.AddWithValue("@ServiceID", ServiceID)
                Dim rs As OleDbDataReader = .ExecuteReader() 'this excutes the query and rs will hold the service details that are returned.

                While rs.Read
                    datRepairDate.Value = rs("RepairDate")
                    txtFaultDetails.Text = rs("FaultDetails")
                    txtRepairDetails.Text = rs("RepairDetails")
                End While
                rs.Close()
            End With
            cn.Close()

        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class