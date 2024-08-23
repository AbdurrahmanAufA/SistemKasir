Imports System.Data.SqlClient
Public Class msaConn
    Dim strkoneksi As String = String.Empty
    Dim con As SqlConnection, com As SqlCommand, adap As SqlDataAdapter
    Dim sqlkoneksi As SqlConnection, sqlcommand As SqlCommand, sqlDataAdapter As SqlDataAdapter
    Dim builder As SqlConnectionStringBuilder

    Public Sub New()
        strkoneksi = "Data Source= (LocalDB)\MSSQLLocalDB; Integrated Security = true"
        sqlkoneksi = New SqlConnection(strkoneksi)
        builder = New SqlConnectionStringBuilder(strkoneksi)
        builder.ConnectTimeout = sqllogin
        sqlcommand = New SqlCommand
        sqlDataAdapter = New SqlDataAdapter
    End Sub
    Protected Overrides Sub Finalize()
        If Not sqlkoneksi Is Nothing Then
            Select Case sqlkoneksi.State
                Case ConnectionState.Connecting, ConnectionState.Executing, ConnectionState.Fetching
                    sqlkoneksi.Close()
                    sqlkoneksi = Nothing
                Case Else
                    sqlkoneksi = Nothing
            End Select
            sqlcommand = Nothing
            sqlDataAdapter = Nothing
        End If
    End Sub
    Private Sub openkoneksi()
        HapusDumpProses()
        sqlkoneksi.Open()
    End Sub
    Private Sub closekoneksi()
        HapusDumpProses()
        sqlkoneksi.Close()
    End Sub

    Public Function ExecNonQuery(ByVal Query As String) As Integer
        Dim retval As Integer = -1
        Try
            openkoneksi()
            sqlcommand.Connection = sqlkoneksi
            sqlcommand.CommandText = Query
            retval = sqlcommand.ExecuteNonQuery
        Catch e As Exception
            MsgBox(Err.Description & Chr(10) & Query, vbInformation, "Chek Err SeML")
        Finally
            closekoneksi()
        End Try
        Return retval
    End Function

    Public Function ExecQuery(ByVal Query As String) As System.Data.DataTable
        Dim retval As DataTable = Nothing
        Try
            openkoneksi()
            retval = New DataTable
            sqlcommand.Connection = sqlkoneksi
            sqlcommand.CommandText = Query
            sqlDataAdapter.SelectCommand = sqlcommand
            sqlDataAdapter.SelectCommand.CommandTimeout = sqlDatafill
            sqlDataAdapter.Fill(retval)
        Catch e As Exception
            MsgBox(Err.Description & Chr(10) & Query, vbInformation, "Chek Err SeML")
        Finally
            closekoneksi()
        End Try
        Return retval
    End Function

    Public Function ExecQueryDS(ByVal Query As String) As System.Data.DataSet
        Dim retval As DataSet = Nothing
        Try
            openkoneksi()
            retval = New DataSet
            sqlcommand.Connection = sqlkoneksi
            sqlcommand.CommandText = Query
            sqlDataAdapter.SelectCommand = sqlcommand
            sqlDataAdapter.SelectCommand.CommandTimeout = sqlDatafill
            sqlDataAdapter.Fill(retval)
        Catch e As Exception
            MsgBox(Err.Description & Chr(10) & Query, vbInformation, "Chek Err SeML")
        Finally
            closekoneksi()
        End Try
        Return retval
    End Function
    Public Function ExecScalar(ByVal Query As String) As Object
        Dim retval As Object = Nothing
        Try
            openkoneksi()
            sqlcommand.Connection = sqlkoneksi
            sqlcommand.CommandText = Query
            retval = sqlcommand.ExecuteScalar
        Catch e As Exception
            MsgBox(Err.Description & Chr(10) & Query, vbInformation, "Chek Err SeML")
        Finally
            closekoneksi()
        End Try
        Return retval
    End Function
End Class
