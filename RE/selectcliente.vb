Public Class selectcliente
    Dim formAbrir As String


    Public Sub selectcliente(formabr As String)
        formAbrir = formabr
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        If formAbrir = "hst" Then
            FrmHST.txtIdCliente.Text = dgvClientes.CurrentRow.Cells(0).Value
        Else
            FrmVenta.txtidcliente.Text = dgvClientes.CurrentRow.Cells(0).Value
        End If

        Me.Close()
    End Sub

    Private Sub selectcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTabla("cliente", dgvClientes)
    End Sub
End Class