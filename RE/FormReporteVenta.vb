Public Class FormReporteVenta
    Private Sub FormReporteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fechaini As Date
        fechaini = "1999-11-10"

        'TODO: Esta linea de codigo carga datos en dataset, puede dejarla o moverla como necesite
        Me.ReporteVentasTableAdapter.Fill(Me.DataSet1.ReporteVentas, fechaini, DateTime.Now)


        Me.rpvVenta.RefreshReport()
    End Sub

    Private Sub dtpinicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpinicio.ValueChanged
        If dtpinicio.Value > dtpfinal.Value Then
            MessageBox.Show("La fecha final debe ser mayor", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpinicio.Value = "2020 - 1 - 1"
            dtpfinal.Value = DateAndTime.Today
        End If
        'TODO:Esta line de codigo carga los datos del dataset, puede eliminar o dejarla
        Me.ReporteVentasTableAdapter.Fill(Me.DataSet1.ReporteVentas, dtpinicio.Value, dtpfinal.Value)


        Me.rpvVenta.RefreshReport()
    End Sub

    Private Sub dtpfinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpfinal.ValueChanged
        If dtpinicio.Value > dtpfinal.Value Then
            MessageBox.Show("La fecha final debe ser mayor", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpinicio.Value = "2020 - 1 - 1"
            dtpfinal.Value = DateAndTime.Today

        End If
        Me.ReporteVentasTableAdapter.Fill(Me.DataSet1.ReporteVentas, dtpinicio.Value, dtpfinal.Value)



        Me.rpvVenta.RefreshReport()
    End Sub
End Class