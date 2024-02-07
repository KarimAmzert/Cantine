Imports System.Data.OleDb
Public Class DATABASE_ACCESS
    Private _Conn As OleDbConnection
    Private ReadOnly _ConnectionString

    Protected Sub New(connectionString)
        _ConnectionString = connectionString
    End Sub

#Region "getDatatable"
    Public Function GetDatatable(ByVal sql As String) As DataTable
        Dim table As New DataTable
        _Conn = New OleDbConnection(_ConnectionString)
        Dim command As New OleDbCommand(sql, _Conn)

        _Conn.Open()

        Dim adapter As New OleDbDataAdapter(command)
        adapter.Fill(table)

        _Conn.Close()
        Return table
    End Function
#End Region

#Region "Execute queries"
    Public Sub ExecuteQueries(ByVal queries As List(Of SqlQuery))
        _Conn = New OleDbConnection(_ConnectionString)
        _Conn.Open()
        Dim transaction = _Conn.BeginTransaction
        Try
            For each query In queries
                Dim cmd As New OleDbCommand(query.SQL, _Conn, transaction)
                    For each parameter In query.Parameters
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
    Public Sub ExecuteQuery(query As SqlQuery)
        _Conn = New OleDbConnection(_ConnectionString)

        _Conn.Open()

        Dim cmd As New OleDbCommand(query.SQL, _Conn)

        For each parameter In query.Parameters
            cmd.Parameters.Add(parameter)
        Next
        cmd.ExecuteNonQuery()

        _Conn.Close()
    End Sub
#End Region
End Class
