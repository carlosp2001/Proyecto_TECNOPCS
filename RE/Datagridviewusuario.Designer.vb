<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Datagridviewusuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 396)
        Me.DataGridView1.TabIndex = 0
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(215, 431)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 1
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnmostrar
        '
        Me.btnmostrar.Location = New System.Drawing.Point(309, 431)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnmostrar.TabIndex = 2
        Me.btnmostrar.Text = "Mostrar"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(399, 431)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 3
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(492, 431)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(75, 23)
        Me.btneditar.TabIndex = 4
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'Datagridviewusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 466)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Datagridviewusuario"
        Me.Text = "Datagridviewusuario"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnmostrar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btneditar As Button
End Class
