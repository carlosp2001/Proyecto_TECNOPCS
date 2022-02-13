Public Class selectempleado
    Dim formabrir As String
    Public Sub selectempleado(Form1 As String)
        formabrir = Form1
    End Sub

    Private Sub selectempleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTabla("empleado", DataGridView1)
    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If formabrir = "ventas" Then
            FrmVenta.txtidempleado.Text = DataGridView1.CurrentRow.Cells(0).Value
        Else
            Frmpago.txtidempleado.Text = DataGridView1.CurrentRow.Cells(0).Value
        End If

        Me.Close()
    End Sub
End Class