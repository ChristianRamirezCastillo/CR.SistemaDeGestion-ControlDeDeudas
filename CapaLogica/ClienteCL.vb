Imports CapaDatos

Public Class ClienteCL

    Dim clienteCD As New ClienteCD()

    Public Function Listar(idBanco As Integer) As DataTable
        Return Me.clienteCD.Listar(idBanco)
    End Function
    Public Function Listar(idBanco As Integer, idEmpleado As Integer) As DataTable
        Return Me.clienteCD.Listar(idBanco, idEmpleado)
    End Function
    Public Function Buscar(idBanco As Integer, idEmpleado As String,
                           idCliente As String, nombres As String, apellidos As String) As DataTable
        Return Me.clienteCD.Buscar(idBanco, idEmpleado, idCliente, nombres, apellidos)
    End Function

    Public Function Buscar(idBanco As Integer, idEmpleado As String,
                         idCliente As String, nombres As String, apellidos As String, empleado As String) As DataTable
        Return Me.clienteCD.Buscar(idBanco, idEmpleado, idCliente, nombres, apellidos, empleado)
    End Function
    Public Function ListarProducto(idCliente As Integer) As DataTable
        Return Me.clienteCD.ListarProducto(idCliente)
    End Function
    Public Function ListarProducto(idCliente As Integer, activo As Boolean) As DataTable
        Return Me.clienteCD.ListarProducto(idCliente, activo)
    End Function
    Public Function ListarEmpresa(idCliente As Integer) As DataTable
        Return Me.clienteCD.ListarEmpresa(idCliente)
    End Function
End Class
