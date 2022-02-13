Public Class selectempleado
    Private Sub selectempleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTabla("empleado", DataGridView1)
    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Frmpago.txtidempleado.Text = DataGridView1.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub
End Class