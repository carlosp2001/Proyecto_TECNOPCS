Public Class selectproducto
    Dim formabr As String
    Private Sub selectproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTabla("producto", dgvProductos)

    End Sub

    Public Sub selectproducto(formabrir As String)
        formabr = formabrir
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellDoubleClick
        If formabr = "hst" Then
            formHST.txtProductoId.Text = dgvProductos.CurrentRow.Cells(0).Value
        Else
            formVenta.txtIdProducto.Text = dgvProductos.CurrentRow.Cells(0).Value
            formVenta.txtPrecio.Text = dgvProductos.CurrentRow.Cells(2).Value
        End If
        Me.Close()
    End Sub
End Class