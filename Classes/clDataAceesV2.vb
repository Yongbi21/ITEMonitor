Imports System.Data.SqlClient
Imports System.Threading.Tasks

Public Class clDataAceesV2
    Public sqlservername As String
    Public sqlserveruserid As String
    Public sqlserverpassword As String

    Public Sub New(ByVal m_servername As String, ByVal m_serveruserid As String, ByVal m_serverpassword As String)
        sqlservername = m_servername
        sqlserveruserid = m_serveruserid
        sqlserverpassword = m_serverpassword
    End Sub

    Public Function GetConnection(ByVal var_database As String) As SqlConnection
        GetConnection = New SqlConnection("Server=" & sqlservername & ";Database=" & var_database & ";User Id=" & sqlserveruserid &
                                          ";Password=" & sqlserverpassword & ";MultipleActiveResultSets=True;Connection Timeout=300")

        GetConnection.Open()

        Return GetConnection
    End Function

    Public Function GetConnection(ip As String, ByVal var_database As String) As SqlConnection
        Dim result As New SqlConnection
        result = New SqlConnection("Server=" & ip & ";Database=" & var_database & ";User Id=" & sqlserveruserid & ";Password=" &
                                   sqlserverpassword & ";MultipleActiveResultSets=True;Connection Timeout=300")
        result.Open()

        Return result
    End Function

    Public Function GetLoadData(ByVal var_database As String, ByVal SelectQuery As String) As DataTable
        GetLoadData = New DataTable
        Using ConSql As SqlConnection = GetConnection(var_database)
            Using cmdqry As New SqlCommand(SelectQuery, ConSql)
                cmdqry.CommandTimeout = 0
                Using dr As SqlDataReader = cmdqry.ExecuteReader()
                    GetLoadData.Clear() : GetLoadData.Load(dr)
                End Using
            End Using
            ConSql.Close()
        End Using
    End Function
    Public Function GetLoadData(ByVal VAR_ip As String, ByVal var_database As String, ByVal SelectQuery As String) As DataTable
        Dim result As New DataTable

        Using ConSql As SqlConnection = GetConnection(VAR_ip, var_database)
            Using cmdqry As New SqlCommand(SelectQuery, ConSql)
                cmdqry.CommandTimeout = 0
                Using dr As SqlDataReader = cmdqry.ExecuteReader()
                    result.Clear() : result.Load(dr)
                End Using

            End Using
            ConSql.Close()
        End Using
        Return result
    End Function

    Public Function GetLoadData(ByVal var_Sqlconnection As SqlConnection, ByVal SelectQuery As String) As DataTable

        GetLoadData = New DataTable
        Using cmdqry As New SqlCommand(SelectQuery, var_Sqlconnection)
            cmdqry.CommandTimeout = 0
            Using dr As SqlDataReader = cmdqry.ExecuteReader()
                GetLoadData.Clear() : GetLoadData.Load(dr)
            End Using
        End Using

    End Function

    Public Function GetLoadDataDataAdapter(ByVal var_Sqlconnection As SqlConnection, ByVal SelectQuery As String) As DataTable
        GetLoadDataDataAdapter = New DataTable

        Using cmdqry As New SqlCommand(SelectQuery, var_Sqlconnection)
            Using dr As New SqlDataAdapter(cmdqry)
                GetLoadDataDataAdapter.Clear()
                dr.Fill(GetLoadDataDataAdapter)
            End Using
        End Using

    End Function

    Public Function getData(ByVal con As SqlConnection, ByVal query As String) As DataTable
        Dim dt As New DataTable

        Using cmd As New SqlCommand(query, con)
            Using da As New SqlDataAdapter
                dt.Clear()
                da.SelectCommand = cmd
                da.Fill(dt)
                getData = dt
            End Using

        End Using
    End Function



    Public Function GetLoadDataDataAdapter(ByVal var_database As String, ByVal SelectQuery As String) As DataTable
        GetLoadDataDataAdapter = New DataTable
        Using ConSql As SqlConnection = GetConnection(var_database)
            Using cmdqry As New SqlCommand(SelectQuery, ConSql)
                Using dr As New SqlDataAdapter(cmdqry)
                    GetLoadDataDataAdapter.Clear()
                    dr.Fill(GetLoadDataDataAdapter)
                End Using
            End Using
            ConSql.Close()

        End Using
    End Function

    Public Function ExcuteSQLQuery(ByVal var_database As String, ByVal SelectQuery As String) As Boolean
        Try
            Using ConSql As SqlConnection = GetConnection(var_database)
                Using cmdqry As New SqlCommand(SelectQuery, ConSql)
                    ExcuteSQLQuery = IIf(cmdqry.ExecuteNonQuery() > 0, True, False)
                End Using
                ConSql.Close()
            End Using
        Catch ex As Exception
            Using ConSql As SqlConnection = GetConnection(var_database)
                Using cmdqry As New SqlCommand(SelectQuery, ConSql)
                    ExcuteSQLQuery = IIf(cmdqry.ExecuteNonQuery() > 0, True, False)
                End Using
                ConSql.Close()
            End Using
        End Try
    End Function

    Public Function ExcuteSQLQueryV2(ByVal var_database As String, ByVal SelectQuery As String) As Boolean
        Dim attemptCount As Integer

        attemptCount = 0


        While attemptCount <> 5
            Try
                Using ConSql As SqlConnection = GetConnection(var_database)
                    Using cmdqry As New SqlCommand(SelectQuery, ConSql)
                        cmdqry.CommandTimeout = 0
                        cmdqry.ExecuteNonQuery()

                    End Using
                    ConSql.Close()
                End Using

                Return True

            Catch ex As Exception
                attemptCount += 1
            End Try
        End While

        Return False
    End Function

    Public Function ExcuteSQLQuery(ByVal var_Sqlconnection As SqlConnection, ByVal SelectQuery As String) As Boolean
        Dim result As Boolean = False
        Using cmdqry As New SqlCommand(SelectQuery, var_Sqlconnection)
            result = IIf(cmdqry.ExecuteNonQuery() > 0, True, False)
        End Using
        Return result
    End Function

    Public Function ExcuteSQLQuery(ByVal var_Sqlconnection As SqlConnection, ByVal SelectQuery As String, ByVal parameters As List(Of SqlParameter)) As Boolean
        Dim result As Boolean = False
        Using cmdqry As New SqlCommand(SelectQuery, var_Sqlconnection)
            cmdqry.Parameters.AddRange(parameters.ToArray())
            result = IIf(cmdqry.ExecuteNonQuery() > 0, True, False)
        End Using
        Return result

    End Function

    Public Function ExcuteSQLQuery(ByVal var_database As String, ByVal SelectQuery As String, ByVal parameters As List(Of SqlParameter)) As Boolean
        Dim result As Boolean = False
        Using ConSql As SqlConnection = GetConnection(var_database)
            Using cmdqry As New SqlCommand(SelectQuery, ConSql)
                cmdqry.CommandType = System.Data.CommandType.StoredProcedure
                If parameters IsNot Nothing Then
                    cmdqry.Parameters.AddRange(parameters.ToArray())
                End If
                result = (cmdqry.ExecuteNonQuery() > 0)
            End Using
            ConSql.Close()
        End Using
        Return result
    End Function

    Public Function ExecuteSPWithOutput1(ByVal var_database As String, ByVal spName As String, ByVal parameters As List(Of SqlParameter)) As Boolean
        Dim outputValue As String = ""
        Try
            Using ConSql As SqlConnection = GetConnection(var_database)
                Using cmd As New SqlCommand(spName, ConSql)
                    cmd.CommandType = System.Data.CommandType.StoredProcedure

                    If parameters IsNot Nothing Then
                        cmd.Parameters.AddRange(parameters.ToArray())
                    End If

                    ExecuteSPWithOutput1 = If(cmd.ExecuteNonQuery() > 0, True, False)
                End Using
                ConSql.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            ExecuteSPWithOutput1 = False
        End Try

        Return ExecuteSPWithOutput1
    End Function

    Public Function GetDataTableFromSP(ByVal var_database As String, ByVal spName As String, ByVal parameters As List(Of SqlParameter)) As DataTable
        Dim dt As New DataTable
        Using ConSql As SqlConnection = GetConnection(var_database)
            Using cmd As New SqlCommand(spName, ConSql)
                cmd.CommandType = System.Data.CommandType.StoredProcedure
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
            ConSql.Close()
        End Using
        Return dt
    End Function

    Public Function ExecuteSPWithOutput(ByVal var_database As String, ByVal spName As String, ByVal parameters As List(Of SqlParameter)) As String
        Dim outputValue As String = ""
        Try
            Using ConSql As SqlConnection = GetConnection(var_database)
                Using cmd As New SqlCommand(spName, ConSql)
                    ' This is important - it tells ADO.NET we are calling a stored procedure
                    cmd.CommandType = System.Data.CommandType.StoredProcedure

                    ' Add the list of parameters
                    If parameters IsNot Nothing Then
                        cmd.Parameters.AddRange(parameters.ToArray())
                    End If

                    ' Execute the command
                    cmd.ExecuteNonQuery()

                    ' Find the output parameter and get its value
                    For Each p As SqlParameter In cmd.Parameters
                        If p.Direction = System.Data.ParameterDirection.Output OrElse p.Direction = System.Data.ParameterDirection.InputOutput Then
                            outputValue = p.Value.ToString()
                            Exit For ' Exit after finding the first output parameter
                        End If
                    Next
                End Using
                ConSql.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return ""
    End Function


End Class
