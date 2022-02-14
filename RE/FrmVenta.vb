Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class FrmVenta
    Private Sub FrmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Validacion de Cantidad
            Dim resultado As Boolean
            resultado = False
            For Each letra In txtcantidad.Text
                If Not Regex.IsMatch(letra, "^[0-9]") Then
                    MessageBox.Show("Verifique la cantidad a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultado = True
                    Exit For

                End If
            Next

            If Mid(txtcantidad.Text, 1, 1) = " " Then
                MessageBox.Show("Espacios en blanco no son validos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If

            If Integer.TryParse(txtidproducto.Text, vbNull) And Integer.TryParse(txtcantidad.Text, vbNull) And Decimal.TryParse(txtprecio.Text, vbNull) And resultado = False Then
                Dim precio, cantidad, subtotal, cantidaddisponible As Integer
                cantidad = Val(txtcantidad.Text)
                conectar.Open()
                Dim consulta As String = "select cantidaddisponible from producto where idproducto=" & txtidproducto.Text
                Dim recuperar As SqlDataReader
                Dim ejecutar As New SqlCommand
                ejecutar = New SqlCommand(consulta, conectar)
                recuperar = ejecutar.ExecuteReader()
                If (recuperar.Read() = True) Then

                    cantidaddisponible = Val(recuperar(0))
                Else

                    System.Console.WriteLine("No se encontro ese producto")
                End If

                If cantidaddisponible > cantidad Then
                    DataGridView1.Rows.Add(txtidproducto.Text, txtcantidad.Text, (Val(txtcantidad.Text) * Val(txtprecio.Text)), txtprecio.Text)
                Else
                    MessageBox.Show("La cantidad de producto que quiere comprar no esta disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
                conectar.Close()


            Else
                MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnseleccionar_Click(sender As Object, e As EventArgs) Handles btnseleccionar.Click
        selectproducto.Show()
    End Sub

    Private Sub btnaccion_Click(sender As Object, e As EventArgs) Handles btnaccion.Click
        Try
            If Integer.TryParse(txtidempleado.Text, vbNull) And Integer.TryParse(txtidcliente.Text, vbNull) And Decimal.TryParse(txtprecio.Text, vbNull) Then
                Dim subtotal As Decimal
                subtotal = 0
                conectar.Open()

                Dim registros As DataGridViewRow = New DataGridViewRow()

                'Calcular el subtotal

                For Each registros In DataGridView1.Rows
                    subtotal = subtotal + registros.Cells("subtotal").Value
                Next


                'Ingresar venta
                Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_VENTA @idventa,@idempleado,@idcliente, @subtotal", conectar)
                cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
                cmd.Parameters.AddWithValue("@idempleado", txtidempleado.Text)
                cmd.Parameters.AddWithValue("@idcliente", txtidcliente.Text)
                cmd.Parameters.AddWithValue("@subtotal", subtotal)
                cmd.ExecuteNonQuery()

                For Each registros In DataGridView1.Rows
                    Dim insertard As String = "exec PA_INSERTAR_DETALLESVENTAS @idventa, @idproducto, @cantidad, @subtotal, @precio"
                    Dim insertar_detalle = New SqlCommand(insertard, conectar)
                    insertar_detalle.Parameters.Clear()
                    insertar_detalle.Parameters.AddWithValue("@idventa", txtidventa.Text)
                    insertar_detalle.Parameters.AddWithValue("@idproducto", registros.Cells("idproducto").Value)
                    insertar_detalle.Parameters.AddWithValue("@precio", registros.Cells("Precio").Value)
                    insertar_detalle.Parameters.AddWithValue("@cantidad", registros.Cells("cantidad").Value)
                    insertar_detalle.Parameters.AddWithValue("@subtotal", registros.Cells("subtotal").Value)
                    insertar_detalle.ExecuteNonQuery()

                    Dim consulta As String = "select cantidaddisponible from producto where idproducto=" & registros.Cells("idproducto").Value
                    Dim recuperar1 As SqlDataReader
                    Dim ejecutar1 As New SqlCommand
                    ejecutar1 = New SqlCommand(consulta, conectar)
                    recuperar1 = ejecutar1.ExecuteReader()
                    Dim stock As Integer
                    If (recuperar1.Read() = True) Then
                        stock = Val(recuperar1(0))
                    Else
                        System.Console.WriteLine("No encontrado")
                    End If
                    recuperar1.Close()

                    stock = stock - Val(registros.Cells("cantidad").Value)


                    Dim actualizar1 As String = "update producto set cantidaddisponible=@stock where idproducto=@codproducto"
                    Dim ejactualizar1 As New SqlCommand(actualizar1, conectar)
                    ejactualizar1.Parameters.Clear()
                    ejactualizar1.Parameters.AddWithValue("@codproducto", registros.Cells("idproducto").Value)
                    ejactualizar1.Parameters.AddWithValue("@stock", stock)
                    ejactualizar1.ExecuteNonQuery()


                Next


                conectar.Close()
                FormReporteGenerarFactura.Show()

                LlenarTablaQuery("select idventa as 'Id de Venta', idempleado as 'Id del Empleado', idcliente as 'Id del Cliente', 
subtotal as 'Subtotal'
from venta", FrmdataC.datagridviewdatos)
                BorrarTextBoxForm(Me)

                MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ingrese los datos marcados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Integer.TryParse(txtidempleado.Text, vbNull) And Integer.TryParse(txtidcliente.Text, vbNull) And Integer.TryParse(txtprecio.Text, vbNull) Then
                conectar.Open()

                Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_VENTA @idventa, @idempleado,@idcliente, @subtotal", conectar)
                cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
                cmd.Parameters.AddWithValue("@idempleado", txtidempleado.Text)
                cmd.Parameters.AddWithValue("@idcliente", txtidcliente.Text)
                cmd.Parameters.AddWithValue("@subtotal", txtsubtotal.Text)
                cmd.ExecuteNonQuery()

                conectar.Close()
                LlenarTablaQuery("select idventa as 'Id de Venta', idempleado as 'Id del Empleado', idcliente as 'Id del Cliente', 
subtotal as 'Subtotal'
from venta", FrmdataC.datagridviewdatos)

                MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Ingrese los datos marcados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        selectempleado.selectempleado("ventas")
        selectempleado.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        selectcliente.Show()
    End Sub
End Class