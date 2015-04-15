Imports System.Data.SqlClient
Imports System.Data

Public Class MetodoDatosCD
    Inherits ConexionCD


    Private Function sqlCrearComandoProc(proc As String, par As SqlParameter()) As SqlCommand
        Using cmd As New SqlCommand(proc, conectar())
            cmd.CommandType = CommandType.StoredProcedure

            If (IsNothing(par) = False) Then
                cmd.Parameters.AddRange(par)
            End If
            Return cmd
        End Using
    End Function
    Public Function sqlListar(proc As String, par As SqlParameter()) As DataTable
        Try
            Using dap As New SqlDataAdapter(sqlCrearComandoProc(proc, par))
                Dim dt As DataTable = New DataTable()
                dap.Fill(dt)
                Return dt
            End Using
        Catch ex As SqlException
            Return Nothing
        Catch ex As Exception
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
    Public Function sqlEjecutar(proc As String, par As SqlParameter()) As Boolean
        Try
            sqlCrearComandoProc(proc, par).ExecuteNonQuery()
            Return True
        Catch ex As SqlException
            Return False
        Catch ex As Exception
            Return False
        Finally
            desconectar()
        End Try
    End Function
End Class

