Public Class FormMenuReportes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReporteProductos.Click
        FormReporteProductos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReporteVentas.Click
        FormReporteVenta.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnReportePago.Click
        FormreportePagodeEmpleados.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnReporteEmpleados.Click
        FormReporteEmpleado.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles reporteHistorial.Click
        FormReporteHistorialSoporte.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles reporteRegistroClientes.Click
        FormReporteClientes.Show()
    End Sub
End Class