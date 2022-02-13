Imports System.Data.SqlClient
Module LlenarTable
    Public Sub LlenarTabla(tablename As String, dgvllenar As DataGridView)
        conectar.Open()
        Dim mostrar As String = "select * from " & tablename
        Dim recuperar As New DataTable
        Using adtabla As New SqlDataAdapter(mostrar, conectar)
            adtabla.Fill(recuperar)
        End Using
        dgvllenar.DataSource = recuperar
        conectar.Close()
    End Sub
    Public Sub LlenarTComboBox(Query As String, Combx As ComboBox)
        conectar.Open()

        Dim cmd As New SqlCommand(Query, conectar)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        Combx.DataSource = dt
        conectar.Close()
    End Sub

    Public Sub EjecutarQuey(Query As String)
        conectar.Open()
        Dim cmd As New SqlCommand(Query, conectar)
        cmd.ExecuteNonQuery()
        conectar.Close()
    End Sub

    Public Sub LlenarTablaQuery(query As String, dgvllenar As DataGridView)
        conectar.Open()

        Dim recuperar As New DataTable
        Using adtabla As New SqlDataAdapter(query, conectar)
            adtabla.Fill(recuperar)
        End Using
        dgvllenar.DataSource = recuperar
        conectar.Close()
    End Sub


End Module
