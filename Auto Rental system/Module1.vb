Imports System.Data.OleDb
Module Modmain
    'Public Const DataBasePath As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='E:\Computer Science\CS Project\Auto Rental DB.mdb';Persist Security Info=false;"
    Public Const DataBasePath As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\JS\Documents\Auto-Rental System\Auto Rental DB - College.mdb';Persist Security Info=false;"
    'holds thr location of the databse linked to the system
    Public cn As OleDbConnection
    Public Function DbConnect() As Boolean
        Try
            cn = New OleDbConnection(DataBasePath)
            cn.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("unable to open the database: " & ex.Message)
            Return False
        End Try


    End Function
    Public Class ListBoxData
        Public Data As String
        Public Identifier As Integer
        Public Sub New(NewData As String, NewIdentifier As Integer)
            Data = NewData
            Identifier = NewIdentifier
        End Sub
        Public Overrides Function ToString() As String
            Return data
        End Function
    End Class

End Module
