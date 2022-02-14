Public Class selectventa
    Private Sub selectventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTabla("venta", DataGridView1)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        FrmHST.txtidventa.Text = DataGridView1.CurrentRow.Cells(0).Value
        Me.Close()

    End Sub
End Class