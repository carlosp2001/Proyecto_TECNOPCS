﻿Public Class FormReporteProductos
    Private Sub FormReporteProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ReporteProductos' table. You can move, or remove it, as needed.
        Me.ReporteProductosTableAdapter.Fill(Me.DataSet1.ReporteProductos, "")

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.ReporteProductosTableAdapter.Fill(Me.DataSet1.ReporteProductos, TextBox1.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class