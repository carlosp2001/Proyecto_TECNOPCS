Imports System.Text.RegularExpressions
Public Class FormreportePagodeEmpleados
    Private Sub FormreportePagodeEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Esta linea de codigo carga datos en 'DataSet1.ReportePagoEmpleados' tabla. Puedes moverla, o removerla, como necesite.
        Me.ReportePagoEmpleadosTableAdapter.Fill(Me.DataSet1.ReportePagoEmpleados, "")

        Me.reportViewerPagoEmpleados.RefreshReport()
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

        Me.reportViewerPagoEmpleados.RefreshReport()
    End Sub
End Class