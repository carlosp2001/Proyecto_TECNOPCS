<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEnvios
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
        Me.components = New System.ComponentModel.Container()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvEnvios = New System.Windows.Forms.DataGridView()
        Me.EnviosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewEnvios = New proyecto_de_analisis.DataGridViewEnvios()
        Me.TECNO_PCSDataSet1 = New proyecto_de_analisis.TECNO_PCSDataSet1()
        Me.EmpresaEnviosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresaEnviosTableAdapter = New proyecto_de_analisis.TECNO_PCSDataSet1TableAdapters.empresaEnviosTableAdapter()
        Me.EnviosTableAdapter = New proyecto_de_analisis.DataGridViewEnviosTableAdapters.enviosTableAdapter()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoEnvioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEnvioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvEnvios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnviosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewEnvios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TECNO_PCSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaEnviosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(353, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 37)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Envios"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEliminar.Location = New System.Drawing.Point(518, 464)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(81, 32)
        Me.btnEliminar.TabIndex = 49
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnMostrar.Location = New System.Drawing.Point(316, 464)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(81, 32)
        Me.btnMostrar.TabIndex = 48
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEditar.Location = New System.Drawing.Point(414, 464)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(81, 32)
        Me.btnEditar.TabIndex = 47
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAgregar.Location = New System.Drawing.Point(217, 464)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(81, 32)
        Me.btnAgregar.TabIndex = 46
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvEnvios
        '
        Me.dgvEnvios.AllowUserToAddRows = False
        Me.dgvEnvios.AutoGenerateColumns = False
        Me.dgvEnvios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnvios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.EstadoEnvioDataGridViewTextBoxColumn, Me.FechaEnvioDataGridViewTextBoxColumn})
        Me.dgvEnvios.DataSource = Me.EnviosBindingSource
        Me.dgvEnvios.Location = New System.Drawing.Point(12, 62)
        Me.dgvEnvios.Name = "dgvEnvios"
        Me.dgvEnvios.ReadOnly = True
        Me.dgvEnvios.Size = New System.Drawing.Size(776, 376)
        Me.dgvEnvios.TabIndex = 0
        '
        'EnviosBindingSource
        '
        Me.EnviosBindingSource.DataMember = "envios"
        Me.EnviosBindingSource.DataSource = Me.DataGridViewEnvios
        '
        'DataGridViewEnvios
        '
        Me.DataGridViewEnvios.DataSetName = "DataGridViewEnvios"
        Me.DataGridViewEnvios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TECNO_PCSDataSet1
        '
        Me.TECNO_PCSDataSet1.DataSetName = "TECNO_PCSDataSet1"
        Me.TECNO_PCSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresaEnviosBindingSource
        '
        Me.EmpresaEnviosBindingSource.DataMember = "empresaEnvios"
        Me.EmpresaEnviosBindingSource.DataSource = Me.TECNO_PCSDataSet1
        '
        'EmpresaEnviosTableAdapter
        '
        Me.EmpresaEnviosTableAdapter.ClearBeforeFill = True
        '
        'EnviosTableAdapter
        '
        Me.EnviosTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idEnvio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id de Envio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idVenta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Id de Venta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "idEmpresa"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Id de Empresa"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tiempoEnvio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tiempo Envio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'EstadoEnvioDataGridViewTextBoxColumn
        '
        Me.EstadoEnvioDataGridViewTextBoxColumn.DataPropertyName = "estadoEnvio"
        Me.EstadoEnvioDataGridViewTextBoxColumn.HeaderText = "Estado Envio"
        Me.EstadoEnvioDataGridViewTextBoxColumn.Name = "EstadoEnvioDataGridViewTextBoxColumn"
        Me.EstadoEnvioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaEnvioDataGridViewTextBoxColumn
        '
        Me.FechaEnvioDataGridViewTextBoxColumn.DataPropertyName = "fechaEnvio"
        Me.FechaEnvioDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaEnvioDataGridViewTextBoxColumn.Name = "FechaEnvioDataGridViewTextBoxColumn"
        Me.FechaEnvioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormEnvios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.fondo_azul
        Me.ClientSize = New System.Drawing.Size(800, 508)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvEnvios)
        Me.Name = "FormEnvios"
        Me.Text = "Envios"
        CType(Me.dgvEnvios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnviosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewEnvios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TECNO_PCSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaEnviosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents IdenvioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdventaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdempresaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TiempoenvioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvEnvios As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TECNO_PCSDataSet1 As TECNO_PCSDataSet1
    Friend WithEvents EmpresaEnviosBindingSource As BindingSource
    Friend WithEvents EmpresaEnviosTableAdapter As TECNO_PCSDataSet1TableAdapters.empresaEnviosTableAdapter
    Friend WithEvents DataGridViewEnvios As DataGridViewEnvios
    Friend WithEvents EnviosBindingSource As BindingSource
    Friend WithEvents EnviosTableAdapter As DataGridViewEnviosTableAdapters.enviosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents EstadoEnvioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaEnvioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
