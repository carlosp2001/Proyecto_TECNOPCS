Imports System.Text.RegularExpressions
Public Class FormReporteProductos
    Private Sub FormReporteProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ReporteProductos' table. You can move, or remove it, as needed.
        Me.ReporteProductosTableAdapter.Fill(Me.DataSet1.ReporteProductos, "")

        Me.rpvProductos.RefreshReport()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        For Each letra As Char In TextBox1.Text
            If Not Regex.IsMatch(letra, "^[A-Za-z0-9\s]") Or Mid(TextBox1.Text, 1, 1) = " " Then
                MessageBox.Show("No ingresar caracteres especiales en el nombre o espacios en blanco", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Text = ""
                Exit For

            End If
        Next
        Me.ReporteProductosTableAdapter.Fill(Me.DataSet1.ReporteProductos, TextBox1.Text)

        Me.rpvProductos.RefreshReport()
    End Sub
End Class