Public Class selectproducto
    Private Sub selectproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTabla("producto", DataGridView1)

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        FrmVenta.txtidproducto.Text = DataGridView1.CurrentRow.Cells(0).Value
        FrmVenta.txtprecio.Text = DataGridView1.CurrentRow.Cells(2).Value
        Me.Close()
    End Sub
End Class