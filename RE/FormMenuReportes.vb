Public Class FormMenuReportes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormReporteProductos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormReporteVenta.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormreportePagodeEmpleados.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormReporteEmpleado.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FormReporteHistorialSoporte.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FormReporteClientes.Show()
    End Sub
End Class