Imports System.Data.SqlClient
Public Class FormEnvios
    Private Sub FormEnvios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataGridViewEnvios.envios' table. You can move, or remove it, as needed.
        Me.EnviosTableAdapter.Fill(Me.DataGridViewEnvios.envios)
        'TODO: This line of code loads data into the 'TECNO_PCSDataSet1.empresaEnvios' table. You can move, or remove it, as needed.
        Me.EmpresaEnviosTableAdapter.Fill(Me.TECNO_PCSDataSet1.empresaEnvios)




    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FormModuloEnvios.btnEditar.Visible = False
        FormModuloEnvios.btnGuardar.Visible = True
        FormModuloEnvios.dtpFechaEnvio.Enabled = False
        FormModuloEnvios.dtpFechaEnvio.Value = DateAndTime.Now
        FormModuloEnvios.btnBuscar.Visible = True
        FormModuloEnvios.rdbProcesamiento.Checked = True
        FormModuloEnvios.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        conectar.Open()
        Dim cmd As SqlCommand = New SqlCommand("exec PA_ELIMINAR_ENVIOs @idVenta", conectar)
        cmd.Parameters.AddWithValue("@idVenta", dgvEnvios.CurrentRow.Cells(0).Value)

        cmd.ExecuteNonQuery()

        conectar.Close()
        Me.EnviosTableAdapter.Fill(Me.DataGridViewEnvios.envios)
    End Sub


End Class