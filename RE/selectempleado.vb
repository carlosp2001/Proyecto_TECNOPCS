Public Class selectempleado
    Dim formAbrir As String
    Public Sub selectempleado(Form1 As String)
        formAbrir = Form1
    End Sub

    Private Sub selectempleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTabla("empleado", dgvEmpleado)
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleado.CellDoubleClick
        If formAbrir = "ventas" Then
            formVenta.txtIdEmpleado.Text = dgvEmpleado.CurrentRow.Cells(0).Value
        ElseIf formAbrir = "hst" Then
            formHST.txtIdEmpleado.Text = dgvEmpleado.CurrentRow.Cells(0).Value
        Else
            formPago.txtIdEmpleado.Text = dgvEmpleado.CurrentRow.Cells(0).Value
        End If

        Me.Close()
    End Sub

End Class