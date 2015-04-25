Imports CapaLogica
Imports Microsoft.Reporting.WinForms

Public Class frmReportes

    Dim reporteCienteCL As New ReporteClienteCL()

    Private Sub ListarReporte()
        Dim dt As New DataTable()
        dt = Me.reporteCienteCL.Listar(txtBanco.Text, txtEmpleado.Text)

        With rvReporte
            .LocalReport.DataSources.Clear()
            .LocalReport.ReportEmbeddedResource = "CapaPresentacion.Cliente.rdlc"
            .LocalReport.DataSources.Add(New ReportDataSource("ReporteCliente", dt))

            .RefreshReport()
            .LocalReport.Refresh()
            .Visible = True
        End With

        lblTotalEncontrados.Text = dt.Rows.Count()
    End Sub

    Private Sub frmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarFormulario(Me, "Formulario de Reportes", Windows.Forms.FormBorderStyle.Sizable, False, FormWindowState.Normal)
        Me.rvReporte.RefreshReport()
    End Sub
    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        ListarReporte()
    End Sub
End Class