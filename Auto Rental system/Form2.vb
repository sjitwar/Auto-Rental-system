Public Class Form2
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim numOne As Integer
        Dim numTwo As Integer
        Dim result As Integer
        numOne = txtNumOne.Text
        numTwo = txtNumTwo.Text
        result = numOne + numTwo
        txtResult.Text = result
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
End Class