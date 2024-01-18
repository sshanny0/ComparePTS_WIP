Imports System.Data.SqlClient

Module FunctionRun
    Public conTDF As New SqlConnection(My.Settings.TDF)
    Function GetDataTDF(sql As String) As DataTable
        Dim dataadapter As New SqlDataAdapter(sql, conTDF)
        Dim dt As New DataTable

        conTDF.Open()
        dataadapter.Fill(dt)
        conTDF.Close()
        Return dt
    End Function
    Function getDataReaderTDF(ByVal stringQuery) As ModSqlRaeder
        Dim msr = New ModSqlRaeder
        Try
            Dim sqlcon = New SqlConnection(My.Settings.TDF)
            sqlcon.Open()
            Dim com = New SqlCommand(stringQuery, sqlcon)
            msr.sqlConnection = sqlcon
            msr.sqlDataReader = com.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return msr
    End Function
    Class ModSqlRaeder
        Public sqlDataReader As SqlDataReader
        Public sqlConnection As SqlConnection
    End Class
    Sub ExecuteQueryTDF(ByVal stringQuery)
        Dim sqlcon = New SqlConnection(My.Settings.TDF)
        sqlcon.Open()
        Dim com = New SqlCommand(stringQuery, sqlcon)
        Try
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqlcon.Close()
    End Sub
End Module
