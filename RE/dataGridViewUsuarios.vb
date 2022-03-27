Imports System.Data.SqlClient
Public Class dataGridViewUsuarios
    Private Sub Datagridviewusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formMenu.Hide()
        LlenarTablaQuery("select idusuario as 'Id del Usuario', username as 'Usuario', pass as 'Contraseña', tipo as 
'Nivel de Usuario' from usuarios", dgvUsuarios)
    End Sub

    Private Sub Datagridviewusuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        formMenu.Show()

    End Sub

    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        FormUsuarios.txtUsuario.Enabled = False
        FormUsuarios.txtPass.Enabled = False
        FormUsuarios.cbxUsuarios.Enabled = False
        FormUsuarios.btnEditar.Visible = False
        FormUsuarios.btnGuardar.Visible = False
        FormUsuarios.txtId.Text = dgvUsuarios.CurrentRow.Cells(0).Value
        FormUsuarios.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells(1).Value
        FormUsuarios.txtPass.Text = dgvUsuarios.CurrentRow.Cells(2).Value

        If dgvUsuarios.CurrentRow.Cells(3).Value = 1 Then
            FormUsuarios.cbxUsuarios.SelectedIndex = 0
        ElseIf dgvUsuarios.CurrentRow.Cells(3).Value = 2 Then
            FormUsuarios.cbxUsuarios.SelectedIndex = 1
        ElseIf dgvUsuarios.CurrentRow.Cells(3).Value = 3 Then
            FormUsuarios.cbxUsuarios.SelectedIndex = 2

        End If
        FormUsuarios.Show()


    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FormUsuarios.txtUsuario.Enabled = True
        FormUsuarios.txtPass.Enabled = True
        FormUsuarios.cbxUsuarios.Enabled = True

        FormUsuarios.Show()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click



        conectar.Open()
        Dim cmd As SqlCommand = New SqlCommand("delete from usuarios where idusuario=@id", conectar)
        cmd.Parameters.AddWithValue("@id", dgvUsuarios.CurrentRow.Cells(0).Value)
        cmd.ExecuteNonQuery()
        conectar.Close()
        LlenarTablaQuery("select idusuario as 'Id del Usuario', username as 'Usuario', pass as 'Contraseña', tipo as 
'Nivel de Usuario' from usuarios", dgvUsuarios)

    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        FormUsuarios.txtUsuario.Enabled = True
        FormUsuarios.txtPass.Enabled = True
        FormUsuarios.cbxUsuarios.Enabled = True
        FormUsuarios.btnEditar.Visible = True
        FormUsuarios.btnGuardar.Visible = False
        FormUsuarios.txtId.Text = dgvUsuarios.CurrentRow.Cells(0).Value
        FormUsuarios.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells(1).Value
        FormUsuarios.txtPass.Text = dgvUsuarios.CurrentRow.Cells(2).Value

        If dgvUsuarios.CurrentRow.Cells(3).Value = 1 Then
            FormUsuarios.cbxUsuarios.SelectedIndex = 0
        ElseIf dgvUsuarios.CurrentRow.Cells(3).Value = 2 Then
            FormUsuarios.cbxUsuarios.SelectedIndex = 1
        ElseIf dgvUsuarios.CurrentRow.Cells(3).Value = 3 Then
            FormUsuarios.cbxUsuarios.SelectedIndex = 2

        End If
        FormUsuarios.Show()
    End Sub
End Class