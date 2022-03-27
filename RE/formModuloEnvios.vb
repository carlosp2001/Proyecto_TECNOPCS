Imports System.Data.SqlClient
Public Class FormModuloEnvios
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TECNO_PCSDataSet1.empresaEnvios' table. You can move, or remove it, as needed.
        Me.EmpresaEnviosTableAdapter1.Fill(Me.TECNO_PCSDataSet1.empresaEnvios)


    End Sub
    Function validarRadioButton()

        If rdbEntregado.Checked Then
            Return "Entregado"
        ElseIf rdbEnviado.Checked Then
            Return "Enviado"
        ElseIf rdbProcesamiento.Checked Then
            Return "En procesamiento"
        Else
            Return "En procesamiento"
        End If
    End Function
    Function validaciones()
        If validarVacio("Debe seleccionar una venta", txtIdVenta.Text) Then
            Return False
        End If

        Return True
    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If validaciones() Then
            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_ENVIO @idVenta,@idEmpresa,@tiempoEnvio,@estadoEnvio,@fechaEnvio", conectar)
            cmd.Parameters.AddWithValue("@idVenta", txtIdVenta.Text)
            cmd.Parameters.AddWithValue("@idEmpresa", cbxEmpresa.SelectedValue)
            cmd.Parameters.AddWithValue("@fechaEnvio", dtpFechaEnvio.Value)
            cmd.Parameters.AddWithValue("@tiempoEnvio", nudDias.Value)
            cmd.Parameters.AddWithValue("@estadoEnvio", validarRadioButton())
            cmd.ExecuteNonQuery()
            conectar.Close()

            FormEnvios.EnviosTableAdapter.Fill(FormEnvios.DataGridViewEnvios.envios)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        formSeleccionarVentas.Show()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If validaciones() Then
            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_ENVIOS @idEnvio, @idVenta,@idEmpresa,@tiempoEnvio,@estadoEnvio,@fechaEnvio", conectar)
            cmd.Parameters.AddWithValue("@idVenta", txtIdVenta.Text)
            cmd.Parameters.AddWithValue("@idEnvio", txtId.Text)
            cmd.Parameters.AddWithValue("@idEmpresa", cbxEmpresa.SelectedValue)
            cmd.Parameters.AddWithValue("@fechaEnvio", dtpFechaEnvio.Value)
            cmd.Parameters.AddWithValue("@tiempoEnvio", nudDias.Value)
            cmd.Parameters.AddWithValue("@estadoEnvio", validarRadioButton())
            cmd.ExecuteNonQuery()
            conectar.Close()
            FormEnvios.EnviosTableAdapter.Fill(FormEnvios.DataGridViewEnvios.envios)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        End If
    End Sub
End Class