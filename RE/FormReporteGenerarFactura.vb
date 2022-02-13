Public Class FormReporteGenerarFactura
    Private Sub FormReporteGenerarFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ReporteGenerarFactura' table. You can move, or remove it, as needed.
        Me.ReporteGenerarFacturaTableAdapter.Fill(Me.DataSet1.ReporteGenerarFactura, FrmVenta.txtidventa.Text)
        'TODO: This line of code loads data into the 'DataSet1.ReporteGenerarFacturaDetalle' table. You can move, or remove it, as needed.
        Me.ReporteGenerarFacturaDetalleTableAdapter.Fill(Me.DataSet1.ReporteGenerarFacturaDetalle, FrmVenta.txtidventa.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class