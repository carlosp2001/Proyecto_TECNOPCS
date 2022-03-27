Public Class FormReporteEmpleado
    Private Sub FormReporteEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Esta linea de codigo carga los datos en 'DataSet1.ReporteEmpleado' tabla. Puedes moverla, o removerla, como necesite.
        Me.ReporteEmpleadoTableAdapter.Fill(Me.DataSet1.ReporteEmpleado)

        Me.rpvEmpleado.RefreshReport()
    End Sub
End Class