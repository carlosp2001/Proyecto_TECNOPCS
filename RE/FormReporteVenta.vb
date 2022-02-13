Public Class FormReporteVenta
    Private Sub FormReporteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fechaini As Date
        fechaini = "1999-11-10"

        'TODO: This line of code loads data into the 'DataSet1.ReporteVentas' table. You can move, or remove it, as needed.
        Me.ReporteVentasTableAdapter.Fill(Me.DataSet1.ReporteVentas, fechaini, DateTime.Now)


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dtpinicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpinicio.ValueChanged

        'TODO: This line of code loads data into the 'DataSet1.ReporteVentas' table. You can move, or remove it, as needed.
        Me.ReporteVentasTableAdapter.Fill(Me.DataSet1.ReporteVentas, dtpinicio.Value, dtpfinal.Value)


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dtpfinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpfinal.ValueChanged
        Me.ReporteVentasTableAdapter.Fill(Me.DataSet1.ReporteVentas, dtpinicio.Value, dtpfinal.Value)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class