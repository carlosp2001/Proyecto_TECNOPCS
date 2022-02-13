Public Class selectcliente
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        FrmVenta.txtidcliente.Text = DataGridView1.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub

    Private Sub selectcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTabla("cliente", DataGridView1)
    End Sub
End Class