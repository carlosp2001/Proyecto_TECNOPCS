Public Class selectproducto
    Dim formabr As String
    Private Sub selectproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTabla("producto", DataGridView1)

    End Sub

    Public Sub selectproducto(formabrir As String)
        formabr = formabrir
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If formabr = "hst" Then
            FrmHST.txtproductoid.Text = DataGridView1.CurrentRow.Cells(0).Value
        Else
            FrmVenta.txtidproducto.Text = DataGridView1.CurrentRow.Cells(0).Value
            FrmVenta.txtprecio.Text = DataGridView1.CurrentRow.Cells(2).Value
        End If
        Me.Close()
    End Sub
End Class