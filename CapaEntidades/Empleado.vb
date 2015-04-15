
Public Class Empleado
    Inherits Persona
    Private _CodigoEmpleado As Integer

#Region "Constructor"
    Sub New(codigoEmpleado As String,
          nombres As String, apellidos As String, direccion As String,
          distrito As Integer, departamento As Integer, pais As Integer, telefono As String, sexo As String)
        MyBase.New(nombres, apellidos, direccion, distrito, departamento, pais, telefono, sexo)

        codigoEmpleado = Me.CodigoEmpleado
    End Sub
    Sub New()

    End Sub
#End Region

  

    Public Property CodigoEmpleado As Integer
        Get
            Return _CodigoEmpleado
        End Get
        Set(value As Integer)
            _CodigoEmpleado = value
        End Set
    End Property

End Class
