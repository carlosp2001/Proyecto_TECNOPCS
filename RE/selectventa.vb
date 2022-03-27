Public Class selectventa
    Private Sub selectventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTabla("venta", dgvVentas)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellDoubleClick
        formHST.txtIdVenta.Text = dgvVentas.CurrentRow.Cells(0).Value
        Me.Close()

    End Sub
End Class