Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class FrmHST
    Private Sub FrmHST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.BackColor = Color.Transparent
        Me.Label2.BackColor = Color.Transparent
        Me.Label3.BackColor = Color.Transparent
        Me.Label4.BackColor = Color.Transparent
        Me.Label5.BackColor = Color.Transparent
        Me.Label6.BackColor = Color.Transparent
        Me.Label7.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim resultado As Boolean = False
            'Validacion Descripcion detalle
            Dim descripcion_detalle As String
            descripcion_detalle = txtdescdetalle.Text
            If Len(descripcion_detalle) < 10 Or Len(descripcion_detalle) > 60 Then
                MessageBox.Show("El largo de la descripcion del detalle no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If
            If RadioButton1.Checked = False And RadioButton2.Checked = False Then
                MessageBox.Show("Seleccione la existencia del producto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If


            'Validacion de Material Usado
            Dim material_usado As String
            material_usado = txtmaterial.Text
            If Len(material_usado) < 5 Or Len(material_usado) > 30 Then
                MessageBox.Show("El largo del material usado no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If

            If Mid(txtdescdetalle.Text, 1, 1) = " " Or Mid(txtmaterial.Text, 1, 1) = " " Or Mid(txtdescripcion.Text, 1, 1) = " " Then
                MessageBox.Show("Espacios en blanco no son validos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If


            If txtmaterial.Text <> String.Empty And txtidsoporte.Text <> String.Empty And txtdescdetalle.Text <> String.Empty Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_DETALLESOPORTE @idsoporte, @fechadetalle, @materialusado, @existenciatienda, @descripciondetalle", conectar)
                cmd.Parameters.AddWithValue("@idsoporte", txtidsoporte.Text)
                cmd.Parameters.AddWithValue("@fechadetalle", DateAndTime.Today)
                cmd.Parameters.AddWithValue("@materialusado", txtmaterial.Text)
                Dim existencia As Integer
                If RadioButton1.Checked = True Then
                    existencia = 1
                ElseIf RadioButton2.Checked = True Then
                    existencia = 2
                End If
                cmd.Parameters.AddWithValue("@existenciatienda", existencia)
                cmd.Parameters.AddWithValue("@descripciondetalle", txtdescdetalle.Text)

                cmd.ExecuteNonQuery()

                conectar.Close()
                LlenarTablaQuery("select * from detalle_soporte where idsoporte=" & txtidsoporte.Text, DataGridView1)
            Else
                MessageBox.Show("Verifique los datos ingresados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnaccion_Click(sender As Object, e As EventArgs) Handles btnaccion.Click
        Try
            'Validacion de Descripcion
            Dim resultado As Boolean
            resultado = False

            Dim descripcion As String
            descripcion = txtdescripcion.Text
            Dim letra As Char
            If Len(descripcion) < 10 Or Len(descripcion) > 60 Then
                MessageBox.Show("El largo de la descripcion no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If

            If Mid(txtdescripcion.Text, 1, 1) = " " Then
                MessageBox.Show("Espacios en blanco no son validos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If




            If Integer.TryParse(txtidempleado.Text, vbNull) And Integer.TryParse(txtidcliente.Text, vbNull) And txtdescripcion.Text <> String.Empty And Integer.TryParse(txtidventa.Text, vbNull) And Integer.TryParse(txtproductoid.Text, vbNull) And resultado = False Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_HISTORIALSOPORTE @idempleado, @fechasoporte, @idproducto, @descripcion, @idcliente, @estado, 
@idventa", conectar)
                cmd.Parameters.AddWithValue("@idempleado", txtidempleado.Text)
                cmd.Parameters.AddWithValue("@fechasoporte", dtpfecha.Value)
                cmd.Parameters.AddWithValue("@idproducto", txtproductoid.Text)
                cmd.Parameters.AddWithValue("@descripcion", txtdescripcion.Text)
                cmd.Parameters.AddWithValue("@idcliente", txtidcliente.Text)
                cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
                cmd.Parameters.AddWithValue("@estado", 1)
                cmd.ExecuteNonQuery()

                conectar.Close()
                LlenarTablaQuery("exec SELECT_HISTORIALSOPORTETABLA", FrmdataC.datagridviewdatos)
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
            'Validacion de Descripcion
            Dim resultado As Boolean
            resultado = False

            Dim descripcion As String
            descripcion = txtdescripcion.Text
            Dim letra As Char
            If Len(descripcion) < 10 Or Len(descripcion) > 60 Then
                MessageBox.Show("El largo de la descripcion no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If



            If Mid(txtdescripcion.Text, 1, 1) = " " Then
                MessageBox.Show("Espacios en blanco no son validos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If




            If Integer.TryParse(txtidempleado.Text, vbNull) And Integer.TryParse(txtidcliente.Text, vbNull) And txtdescripcion.Text <> String.Empty And Integer.TryParse(txtidventa.Text, vbNull) And Integer.TryParse(txtproductoid.Text, vbNull) And resultado = False Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_HISTORIALSOPORTE @idsoporte,@idempleado, @fechasoporte, @idproducto, @descripcion, @idcliente, @estado, 
@idventa", conectar)
                cmd.Parameters.AddWithValue("@idsoporte", txtidsoporte.Text)
                cmd.Parameters.AddWithValue("@idempleado", txtidempleado.Text)
                cmd.Parameters.AddWithValue("@fechasoporte", dtpfecha.Value)
                cmd.Parameters.AddWithValue("@idproducto", txtproductoid.Text)
                cmd.Parameters.AddWithValue("@descripcion", txtdescripcion.Text)
                cmd.Parameters.AddWithValue("@idcliente", txtidcliente.Text)
                cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
                cmd.Parameters.AddWithValue("@estado", 1)
                cmd.ExecuteNonQuery()

                conectar.Close()
                LlenarTablaQuery("exec SELECT_HISTORIALSOPORTETABLA", FrmdataC.datagridviewdatos)
                BorrarTextBoxForm(Me)
                MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            Else
                MessageBox.Show("Ingrese los datos marcados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try




    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        selectproducto.selectproducto("hst")
        selectproducto.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        selectempleado.selectempleado("hst")
        selectempleado.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        selectcliente.selectcliente("hst")
        selectcliente.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        selectventa.Show()

    End Sub

    Private Sub dtpfecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpfecha.ValueChanged

    End Sub
End Class