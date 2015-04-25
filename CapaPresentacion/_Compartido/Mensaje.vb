Module Mensaje
    Public Sub MensajeInformacion(mensaje As String)
        MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub MensajeError(mensaje As String)
        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Public Sub MensajeExclamacion(mensaje As String)
        MessageBox.Show(mensaje, "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
    Public Function MensajePregunta(mensaje As String) As DialogResult
        Return MessageBox.Show(mensaje, "Consultar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Function
End Module
