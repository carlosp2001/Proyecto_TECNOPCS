Imports System.Text.RegularExpressions
Public Class FormreportePagodeEmpleados
    Private Sub FormreportePagodeEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ReportePagoEmpleados' table. You can move, or remove it, as needed.
        Me.ReportePagoEmpleadosTableAdapter.Fill(Me.DataSet1.ReportePagoEmpleados, "")

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        For Each letra As Char In TextBox1.Text

            If Not Regex.IsMatch(letra, "^[A-Za-z\s]") Or Mid(TextBox1.Text, 1, 1) = " " Then
                MessageBox.Show("No ingresar caracteres especiales en el nombre o espacios en blanco", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Text = ""
                Exit For

            End If
        Next
        Me.ReportePagoEmpleadosTableAdapter.Fill(Me.DataSet1.ReportePagoEmpleados, TextBox1.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class