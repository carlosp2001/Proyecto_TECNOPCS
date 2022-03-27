Imports System.Data.SqlClient
Public Class formPago




    Private Sub Frmpago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpFechaPago.Value = DateAndTime.Today
    End Sub

    Public Function validaciones()
        If validarVacio("El id del empleado no puede contener espacios en blanco", txtIdEmpleado.Text) Then
            Return False
        End If
        If validarLargoyEmptyNumero(9742, 50000, "Verifique la cantidad a pagar", Val(txtPagoEmpleado.Text)) Then
            Return False
        End If
        Return True
    End Function




    Private Sub btnaccion_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


        If validaciones() Then
            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_PAGOEMPLEADOS @idempleado,@pagoempleado, @fechapago", conectar)
            cmd.Parameters.AddWithValue("@idempleado", txtIdEmpleado.Text)
            cmd.Parameters.AddWithValue("@pagoempleado", txtPagoEmpleado.Text)
            cmd.Parameters.AddWithValue("@fechapago", dtpFechaPago.Value)
            cmd.ExecuteNonQuery()
            conectar.Close()
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BorrarTextBoxForm(Me)
            LlenarTablaQuery("select idpago as 'Id de pago', idempleado as 'Id del Empleado', pagoempleado as 'Monto de Pago',
            fechapago as 'Fecha del Pago'
            from pagoempleados
            ", formDataC.dataGridViewDatos)
        Else

            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If



    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If validaciones() Then
            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_PAGOEMPLEADOS  @idpago, @idempleado,@pagoempleado, @fechapago", conectar)
            cmd.Parameters.AddWithValue("@idpago", txtPago.Text)
            cmd.Parameters.AddWithValue("@idempleado", txtIdEmpleado.Text)
            cmd.Parameters.AddWithValue("@pagoempleado", txtPago.Text)
            cmd.Parameters.AddWithValue("@fechapago", dtpFechaPago.Value)
            cmd.ExecuteNonQuery()
            conectar.Close()
            LlenarTablaQuery("select idpago as 'Id de pago', idempleado as 'Id del Empleado', pagoempleado as 'Monto de Pago',
            fechapago as 'Fecha del Pago'
            from pagoempleados
            s", formDataC.dataGridViewDatos)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BorrarTextBoxForm(Me)
            Me.Close()

        Else

            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If




    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleado.Click
        selectempleado.Show()

    End Sub

    Private Sub txtPagoEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtPagoEmpleado.TextChanged
        If Not Mid(txtPagoEmpleado.Text, 1, 1) = "" Then
            If validarDecimals(txtPagoEmpleado.Text) Then
                txtPagoEmpleado.Text = ""
            End If
        End If

    End Sub
End Class