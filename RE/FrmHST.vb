Imports System.Data.SqlClient
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
            If txtmaterial.Text <> String.Empty And txtidsoporte.Text <> String.Empty And txtdescdetalle.Text <> String.Empty Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_DETALLESOPORTE @idsoporte, @fechadetalle, @materialusado, @existenciatienda, @descripciondetalle", conectar)
                cmd.Parameters.AddWithValue("@idsoporte", txtidsoporte.Text)
                cmd.Parameters.AddWithValue("@fechadetalle", dtpdetalle.Value)
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
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnaccion_Click(sender As Object, e As EventArgs) Handles btnaccion.Click
        Try
            If Integer.TryParse(txtidempleado.Text, vbNull) And Integer.TryParse(txtidcliente.Text, vbNull) And txtdescripcion.Text <> String.Empty And Integer.TryParse(txtidventa.Text, vbNull) And Integer.TryParse(txtproductoid.Text, vbNull) Then
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
            If Integer.TryParse(txtidempleado.Text, vbNull) And Integer.TryParse(txtidcliente.Text, vbNull) And txtdescripcion.Text <> String.Empty And Integer.TryParse(txtidventa.Text, vbNull) And Integer.TryParse(txtproductoid.Text, vbNull) Then
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
            Else
                MessageBox.Show("Ingrese los datos marcados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try




    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
End Class