

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
End Module
