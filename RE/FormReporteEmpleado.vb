Public Class FormReporteEmpleado
    Private Sub FormReporteEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ReporteEmpleado' table. You can move, or remove it, as needed.
        Me.ReporteEmpleadoTableAdapter.Fill(Me.DataSet1.ReporteEmpleado)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class