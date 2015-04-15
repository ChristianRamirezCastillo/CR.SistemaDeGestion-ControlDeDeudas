Module Tabla
    Public Sub TablaPersonalizar(grid As DataGridView)
        With grid
            .ReadOnly = True
            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
    End Sub
End Module
