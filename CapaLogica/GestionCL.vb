Imports CapaEntidades
Imports CapaDatos

Public Class GestionCL

    Dim gestionCD As New GestionCD()

    Public Function Listar(_idEmpleado As String, _idCliente As String) As DataTable
        Return Me.gestionCD.Listar(_idEmpleado, _idCliente)
    End Function
    Public Function ListarUltimaGestion(_idCliente As Integer) As String
        Return Me.gestionCD.ListarUltimaGestion(_idCliente)
    End Function
    Public Function Agregar(_gestion As Gestion, _tipoDeudor As Integer) As Boolean
        Return Me.gestionCD.Agregar(_gestion, _tipoDeudor)
    End Function
End Class
