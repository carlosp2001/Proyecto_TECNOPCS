Public Class FormReporteHistorialSoporte
    Private Sub FormReporteHistorialSoporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ReporteHistorialSoporte' table. You can move, or remove it, as needed.
        Me.ReporteHistorialSoporteTableAdapter.Fill(Me.DataSet1.ReporteHistorialSoporte)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class