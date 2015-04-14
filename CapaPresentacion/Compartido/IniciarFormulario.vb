Module IniciarFormulario
    Public Sub Inicializar(form As Form, titulo As String)
        With form
            .Text = titulo
            .MaximizeBox = False
            .FormBorderStyle = FormBorderStyle.FixedDialog
        End With
    End Sub
    Public Sub FormularioHijo()

    End Sub
End Module
