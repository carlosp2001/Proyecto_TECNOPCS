Imports System.Data.SqlClient
Public Class Datagridviewusuario
    Private Sub Datagridviewusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmMENU.Hide()
        LlenarTablaQuery("select idusuario as 'Id del Usuario', username as 'Usuario', pass as 'Contraseña', tipo as 
'Nivel de Usuario' from usuarios", DataGridView1)
    End Sub

    Private Sub Datagridviewusuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMENU.Show()

    End Sub

    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        FormUsuarios.txtusuario.Enabled = False
        FormUsuarios.txtpass.Enabled = False
        FormUsuarios.ComboBox1.Enabled = False
        FormUsuarios.btnEditar.Visible = False
        FormUsuarios.btnguardar.Visible = False
        FormUsuarios.txtid.Text = DataGridView1.CurrentRow.Cells(0).Value
        FormUsuarios.txtusuario.Text = DataGridView1.CurrentRow.Cells(1).Value
        FormUsuarios.txtpass.Text = DataGridView1.CurrentRow.Cells(2).Value

        If DataGridView1.CurrentRow.Cells(3).Value = 1 Then
            FormUsuarios.ComboBox1.SelectedIndex = 0
        ElseIf DataGridView1.CurrentRow.Cells(3).Value = 2 Then
            FormUsuarios.ComboBox1.SelectedIndex = 1
        ElseIf DataGridView1.CurrentRow.Cells(3).Value = 3 Then
            FormUsuarios.ComboBox1.SelectedIndex = 2

        End If
        FormUsuarios.Show()


    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        FormUsuarios.txtusuario.Enabled = True
        FormUsuarios.txtpass.Enabled = True
        FormUsuarios.ComboBox1.Enabled = True

        FormUsuarios.Show()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click



        conectar.Open()
        Dim cmd As SqlCommand = New SqlCommand("delete from usuarios where idusuario=@id", conectar)
        cmd.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
        cmd.ExecuteNonQuery()
        conectar.Close()
        LlenarTablaQuery("select idusuario as 'Id del Usuario', username as 'Usuario', pass as 'Contraseña', tipo as 
'Nivel de Usuario' from usuarios", DataGridView1)






    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        FormUsuarios.txtusuario.Enabled = True
        FormUsuarios.txtpass.Enabled = True
        FormUsuarios.ComboBox1.Enabled = True
        FormUsuarios.btnEditar.Visible = True
        FormUsuarios.btnguardar.Visible = False
        FormUsuarios.txtid.Text = DataGridView1.CurrentRow.Cells(0).Value
        FormUsuarios.txtusuario.Text = DataGridView1.CurrentRow.Cells(1).Value
        FormUsuarios.txtpass.Text = DataGridView1.CurrentRow.Cells(2).Value

        If DataGridView1.CurrentRow.Cells(3).Value = 1 Then
            FormUsuarios.ComboBox1.SelectedIndex = 0
        ElseIf DataGridView1.CurrentRow.Cells(3).Value = 2 Then
            FormUsuarios.ComboBox1.SelectedIndex = 1
        ElseIf DataGridView1.CurrentRow.Cells(3).Value = 3 Then
            FormUsuarios.ComboBox1.SelectedIndex = 2

        End If
        FormUsuarios.Show()
    End Sub
End Class