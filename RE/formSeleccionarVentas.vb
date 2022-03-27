Public Class formSeleccionarVentas
    Private Sub formSeleccionarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TECNO_PCSDataSet.venta' table. You can move, or remove it, as needed.
        Me.VentaTableAdapter.Fill(Me.TECNO_PCSDataSet.venta)

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellDoubleClick
        FormModuloEnvios.txtIdVenta.Text = dgvVentas.CurrentRow.Cells(0).Value
        Me.Close()

    End Sub
End Class
