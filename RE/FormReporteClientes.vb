Public Class FormReporteClientes
    Private Sub FormReporteClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Reportehistorialcl' table. You can move, or remove it, as needed.
        Me.ReportehistorialclTableAdapter.Fill(Me.DataSet1.Reportehistorialcl)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class