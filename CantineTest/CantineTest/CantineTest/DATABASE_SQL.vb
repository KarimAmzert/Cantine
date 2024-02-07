Imports System.Data.SqlClient

Public Class DATABASE_SQL
    Private _Conn As SqlConnection
    Private Readonly _ConnectionString As String = "CONNECTION STRING HIDDEN FOR SAFETY REASONS, USE THE LOCAL ACCESS DB INSTEAD"

    Protected Sub New()
    End Sub

#Region "getDatatable"
    Public Function GetDatatable(ByVal Query As SqlQuery_SQL) As DataTable
        Dim table As New DataTable
        _Conn = New SqlConnection(_ConnectionString)
        Dim command As New SqlCommand(Query.SQL, _Conn)

        If Query.Parameters IsNot Nothing AndAlso Query.Parameters.Count > 0 Then
            command.Parameters.AddRange(Query.Parameters.ToArray())
        End If

        _Conn.Open()

        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(table)

        _Conn.Close()
        Return table
    End Function
#End Region

#Region "Execute queries"
    Public Sub ExecuteQueries(ByVal queries As List(Of SqlQuery_SQL))
        _Conn = New SqlConnection(_ConnectionString)
        _Conn.Open()
        Dim transaction = _Conn.BeginTransaction()
        Try
            For each query In queries
                Dim cmd As New SqlCommand(query.SQL, _Conn, transaction)
                For Each parameter In query.Parameters
                    cmd.Parameters.Add(parameter)
                Next
                cmd.ExecuteNonQuery()
            Next
            transaction.Commit()
        Catch ex As Exception
            transaction.Rollback()
        End Try
        _Conn.Close()
    End Sub
#End Region

#Region "Execute query"
    Public Sub ExecuteQuery(query As SqlQuery_SQL)
        _Conn = New SqlConnection(_ConnectionString)

        _Conn.Open()

        Dim cmd As New SqlCommand(query.SQL, _Conn)

        For each parameter In query.Parameters
            cmd.Parameters.Add(parameter)
        Next
        cmd.ExecuteNonQuery()

        _Conn.Close()
    End Sub
#End Region
End Class
