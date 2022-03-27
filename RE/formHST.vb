Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class formHST



    Private Function validacionesDetalle()
        If validarLargoyEmpty(10, 60, "El largo del detalle de la descripcion no es el correcto o hay espacios en blanco", txtDescDetalle.Text) Then
            Return False
        End If
        If validarRadioButton(rdbSi, rdbNo) Then
            Return False
        End If
        If validarLargoyEmpty(5, 30, "El largo del material usado no es el correcto", txtMaterial.Text) Then
            Return False
        End If
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If validacionesDetalle() Then
            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_DETALLESOPORTE @idsoporte, @fechadetalle, @materialusado, @existenciatienda, @descripciondetalle", conectar)
            cmd.Parameters.AddWithValue("@idsoporte", txIdSoporte.Text)
            cmd.Parameters.AddWithValue("@fechadetalle", DateAndTime.Today)
            cmd.Parameters.AddWithValue("@materialusado", txtMaterial.Text)
            Dim existencia As Integer
            If rdbSi.Checked = True Then
                existencia = 1
            ElseIf rdbNo.Checked = True Then
                existencia = 2
            End If
            cmd.Parameters.AddWithValue("@existenciatienda", existencia)
            cmd.Parameters.AddWithValue("@descripciondetalle", txtDescDetalle.Text)

            cmd.ExecuteNonQuery()

            conectar.Close()
            LlenarTablaQuery("select * from detalle_soporte where idsoporte=" & txIdSoporte.Text, dgvHistorialDetalle)
        Else
            MessageBox.Show("Verifique los datos ingresados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub


    Private Function validaciones()
        If validarLargoyEmpty(10, 60, "El largo de la descripcion no es el correcto", txtDescripcion.Text) Then
            Return False
        End If
        If validarVacio(txtIdCliente.Text, "El id del Cliente no puede estar vacio") Then
            Return False
        End If
        If validarVacio(txtIdEmpleado.Text, "El Id del Empleado no puede estar vacio") Then
            Return False
        End If
        If validarVacio(txtProductoId.Text, "El Id de la Venta no puede estar vacio") Then
            Return False
        End If
        If validarVacio(txtIdVenta.Text, "El Id de Venta no puede estar vacio") Then
            Return False
        End If
        Return True
    End Function

    Private Sub btnaccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click



        If validaciones() Then
            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_HISTORIALSOPORTE @idempleado, @fechasoporte, @idproducto, @descripcion, @idcliente, @estado, 
                @idventa", conectar)
            cmd.Parameters.AddWithValue("@idempleado", txtIdEmpleado.Text)
            cmd.Parameters.AddWithValue("@fechasoporte", dtpFecha.Value)
            cmd.Parameters.AddWithValue("@idproducto", txtProductoId.Text)
            cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text)
            cmd.Parameters.AddWithValue("@idcliente", txtIdCliente.Text)
            cmd.Parameters.AddWithValue("@idventa", txtIdVenta.Text)
            cmd.Parameters.AddWithValue("@estado", 1)
            cmd.ExecuteNonQuery()

            conectar.Close()
            LlenarTablaQuery("exec SELECT_HISTORIALSOPORTETABLA", formDataC.dataGridViewDatos)
            BorrarTextBoxForm(Me)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If





    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click



        If validaciones() Then
            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_HISTORIALSOPORTE @idsoporte,@idempleado, @fechasoporte, @idproducto, @descripcion, @idcliente, @estado, 
            @idventa", conectar)
            cmd.Parameters.AddWithValue("@idsoporte", txIdSoporte.Text)
            cmd.Parameters.AddWithValue("@idempleado", txtIdEmpleado.Text)
            cmd.Parameters.AddWithValue("@fechasoporte", dtpFecha.Value)
            cmd.Parameters.AddWithValue("@idproducto", txtProductoId.Text)
            cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text)
            cmd.Parameters.AddWithValue("@idcliente", txtIdCliente.Text)
            cmd.Parameters.AddWithValue("@idventa", txtIdVenta.Text)
            cmd.Parameters.AddWithValue("@estado", 1)
            cmd.ExecuteNonQuery()

            conectar.Close()
            LlenarTablaQuery("exec SELECT_HISTORIALSOPORTETABLA", formDataC.dataGridViewDatos)
            BorrarTextBoxForm(Me)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Else
            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If




    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        selectproducto.selectproducto("hst")
        selectproducto.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleado.Click
        selectempleado.selectempleado("hst")
        selectempleado.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        selectcliente.selectcliente("hst")
        selectcliente.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBuscarVenta.Click
        selectventa.Show()

    End Sub


End Class