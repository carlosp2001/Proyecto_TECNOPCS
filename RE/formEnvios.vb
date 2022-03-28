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
        FormModuloEnvios.nudDias.Enabled = True
        FormModuloEnvios.grbEstadoEnvio.Enabled = True
        FormModuloEnvios.grbEstadoEnvio.Visible = False
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

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        FormModuloEnvios.txtId.Text = dgvEnvios.CurrentRow.Cells(0).Value
        FormModuloEnvios.txtIdVenta.Text = dgvEnvios.CurrentRow.Cells(1).Value
        FormModuloEnvios.cbxEmpresa.SelectedValue = dgvEnvios.CurrentRow.Cells(2).Value
        FormModuloEnvios.nudDias.Value = dgvEnvios.CurrentRow.Cells(3).Value
        If dgvEnvios.CurrentRow.Cells(4).Value = "Entregado" Then
            FormModuloEnvios.rdbEntregado.Checked = True
        ElseIf dgvEnvios.CurrentRow.Cells(4).Value = "En procesamiento" Then
            FormModuloEnvios.rdbProcesamiento.Checked = True
        Else
            FormModuloEnvios.rdbEntregado.Checked = True
        End If
        FormModuloEnvios.dtpFechaEnvio.Value = dgvEnvios.CurrentRow.Cells(5).Value
        FormModuloEnvios.Show()

        'Inhabilitar botones y textbox
        FormModuloEnvios.btnBuscar.Visible = False
        FormModuloEnvios.btnEditar.Visible = False
        FormModuloEnvios.btnGuardar.Visible = False
        FormModuloEnvios.cbxEmpresa.Enabled = False
        FormModuloEnvios.nudDias.Enabled = False
        FormModuloEnvios.grbEstadoEnvio.Enabled = False
        FormModuloEnvios.dtpFechaEnvio.Enabled = False
        FormModuloEnvios.grbEstadoEnvio.Visible = True
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        FormModuloEnvios.btnEditar.Visible = True
        FormModuloEnvios.btnGuardar.Visible = False
        FormModuloEnvios.dtpFechaEnvio.Enabled = False
        FormModuloEnvios.btnBuscar.Visible = True
        FormModuloEnvios.rdbProcesamiento.Checked = True
        FormModuloEnvios.nudDias.Enabled = True
        FormModuloEnvios.grbEstadoEnvio.Enabled = True
        FormModuloEnvios.grbEstadoEnvio.Visible = True
        FormModuloEnvios.txtId.Text = dgvEnvios.CurrentRow.Cells(0).Value
        FormModuloEnvios.txtIdVenta.Text = dgvEnvios.CurrentRow.Cells(1).Value
        FormModuloEnvios.cbxEmpresa.SelectedValue = dgvEnvios.CurrentRow.Cells(2).Value
        FormModuloEnvios.nudDias.Value = dgvEnvios.CurrentRow.Cells(3).Value
        If dgvEnvios.CurrentRow.Cells(4).Value = "Entregado" Then
            FormModuloEnvios.rdbEntregado.Checked = True
        ElseIf dgvEnvios.CurrentRow.Cells(4).Value = "En procesamiento" Then
            FormModuloEnvios.rdbProcesamiento.Checked = True
        Else
            FormModuloEnvios.rdbEnviado.Checked = True
        End If
        FormModuloEnvios.dtpFechaEnvio.Value = dgvEnvios.CurrentRow.Cells(5).Value
        FormModuloEnvios.Show()

    End Sub
End Class