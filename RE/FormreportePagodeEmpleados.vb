Imports System.Text.RegularExpressions
Public Class FormreportePagodeEmpleados
    Private Sub FormreportePagodeEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ReportePagoEmpleados' table. You can move, or remove it, as needed.
        Me.ReportePagoEmpleadosTableAdapter.Fill(Me.DataSet1.ReportePagoEmpleados, "")

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        For Each letra As Char In TextBox1.Text
            If Not Regex.IsMatch(letra, "^[A-Za-z\s]") Then
                MessageBox.Show("No ingresar caracteres especiales en el nombre", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Text = ""
                Exit For

            End If
        Next
        Me.ReportePagoEmpleadosTableAdapter.Fill(Me.DataSet1.ReportePagoEmpleados, TextBox1.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class