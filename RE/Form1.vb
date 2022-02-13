Imports System.Data.SqlClient
Public Class Form1
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.BackColor = Color.Transparent
        Me.Label2.BackColor = Color.Transparent
        Me.Label3.BackColor = Color.Transparent
        Me.Label4.BackColor = Color.Transparent
        Me.Label5.BackColor = Color.Transparent
        Me.Label6.BackColor = Color.Transparent
        Me.Label7.BackColor = Color.Transparent
        Me.Label9.BackColor = Color.Transparent
        Me.Label10.BackColor = Color.Transparent
        Me.GroupBox1.BackColor = Color.Transparent
        Me.Label11.BackColor = Color.Transparent

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If Me.ValidateChildren And txtnombre.Text <> String.Empty And Int(txttelefono.Text) And txtdesc.Text <> String.Empty And txtemail.Text <> String.Empty Then
                conectar.Open()
                Dim genero As Integer
                If RadioButton1.Checked = True Then
                    genero = 2
                Else
                    genero = 1
                End If
                Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_EMPLEADO @nombre, @telefono, @fechanacimiento, @email, @genero, @direccion", conectar)
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
                cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
                cmd.Parameters.AddWithValue("@fechanacimiento", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@email", txtemail.Text)
                cmd.Parameters.AddWithValue("@genero", genero)
                cmd.Parameters.AddWithValue("@direccion", txtdesc.Text)
                cmd.ExecuteNonQuery()

                conectar.Close()
                LlenarTabla("empleado", FrmdataC.datagridviewdatos)
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
            If Me.ValidateChildren And txtnombre.Text <> String.Empty And Integer.TryParse(txttelefono.Text, vbNull) And txtdesc.Text <> String.Empty And txtemail.Text <> String.Empty Then
                conectar.Open()
                Dim genero As Integer
                If RadioButton1.Checked = True Then
                    genero = 2
                Else
                    genero = 1
                End If
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_EMPLEADO @idempleado, @nombre, @telefono, @fechanacimiento, @email, @genero, @direccion", conectar)
                cmd.Parameters.AddWithValue("@idempleado", txtid.Text)
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
                cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
                cmd.Parameters.AddWithValue("@fechanacimiento", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@email", txtemail.Text)
                cmd.Parameters.AddWithValue("@genero", genero)
                cmd.Parameters.AddWithValue("@direccion", txtdesc.Text)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTabla("empleado", FrmdataC.datagridviewdatos)
                BorrarTextBoxForm(Me)
                MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ingrese los datos marcados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub
End Class
