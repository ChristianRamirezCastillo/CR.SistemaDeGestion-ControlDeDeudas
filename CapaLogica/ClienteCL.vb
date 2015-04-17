Imports CapaDatos

Public Class ClienteCL

    Dim clienteCD As New ClienteCD()

    Public Function Listar(idBanco As Integer) As DataTable
        Return Me.clienteCD.Listar(idBanco)
    End Function
    Public Function Listar(idBanco As Integer, idEmpleado As Integer) As DataTable
        Return Me.clienteCD.Listar(idBanco, idEmpleado)
    End Function
    Public Function Buscar(idBanco As Integer,
                            idCliente As String, nombres As String, apellidos As String) As DataTable
        Return Me.clienteCD.Buscar(idBanco, idCliente, nombres, apellidos)
    End Function
    Public Function Buscar(idBanco As Integer, idEmpleado As Integer,
                            idCliente As String, nombres As String, apellidos As String) As DataTable
        Return Me.clienteCD.Buscar(idBanco, idEmpleado, idCliente, nombres, apellidos)
    End Function
End Class
