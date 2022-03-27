<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModuloEnvios
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtIdVenta = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmpresaEnviosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboboxEmpresa = New proyecto_de_analisis.ComboboxEmpresa()
        Me.EmpresaEnviosTableAdapter = New proyecto_de_analisis.ComboboxEmpresaTableAdapters.empresaEnviosTableAdapter()
        Me.nudDias = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaEnvio = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rdbProcesamiento = New System.Windows.Forms.RadioButton()
        Me.grbEstadoEnvio = New System.Windows.Forms.GroupBox()
        Me.rdbEntregado = New System.Windows.Forms.RadioButton()
        Me.rdbEnviado = New System.Windows.Forms.RadioButton()
        Me.cbxEmpresa = New System.Windows.Forms.ComboBox()
        Me.TECNO_PCSDataSet1 = New proyecto_de_analisis.TECNO_PCSDataSet1()
        Me.EmpresaEnviosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresaEnviosTableAdapter1 = New proyecto_de_analisis.TECNO_PCSDataSet1TableAdapters.empresaEnviosTableAdapter()
        CType(Me.EmpresaEnviosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboboxEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbEstadoEnvio.SuspendLayout()
        CType(Me.TECNO_PCSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaEnviosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(85, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Tiempo Envio:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(133, 329)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 20)
        Me.btnGuardar.TabIndex = 56
        Me.btnGuardar.Text = "Agregar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtIdVenta
        '
        Me.txtIdVenta.Enabled = False
        Me.txtIdVenta.Location = New System.Drawing.Point(162, 96)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.Size = New System.Drawing.Size(134, 20)
        Me.txtIdVenta.TabIndex = 54
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(162, 63)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(221, 20)
        Me.txtId.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(85, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Empresa de Envio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(85, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Id Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(85, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Id Envio:"
        '
        'EmpresaEnviosBindingSource
        '
        Me.EmpresaEnviosBindingSource.DataMember = "empresaEnvios"
        Me.EmpresaEnviosBindingSource.DataSource = Me.ComboboxEmpresa
        '
        'ComboboxEmpresa
        '
        Me.ComboboxEmpresa.DataSetName = "ComboboxEmpresa"
        Me.ComboboxEmpresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresaEnviosTableAdapter
        '
        Me.EmpresaEnviosTableAdapter.ClearBeforeFill = True
        '
        'nudDias
        '
        Me.nudDias.Location = New System.Drawing.Point(166, 171)
        Me.nudDias.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudDias.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDias.Name = "nudDias"
        Me.nudDias.Size = New System.Drawing.Size(31, 20)
        Me.nudDias.TabIndex = 59
        Me.nudDias.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(203, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "dias"
        '
        'dtpFechaEnvio
        '
        Me.dtpFechaEnvio.Location = New System.Drawing.Point(183, 209)
        Me.dtpFechaEnvio.Name = "dtpFechaEnvio"
        Me.dtpFechaEnvio.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaEnvio.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(85, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Fecha de Envio:"
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(280, 329)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 20)
        Me.btnEditar.TabIndex = 63
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(319, 95)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(64, 20)
        Me.btnBuscar.TabIndex = 64
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(6, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Estado de Envio"
        '
        'rdbProcesamiento
        '
        Me.rdbProcesamiento.AutoSize = True
        Me.rdbProcesamiento.Location = New System.Drawing.Point(99, 21)
        Me.rdbProcesamiento.Name = "rdbProcesamiento"
        Me.rdbProcesamiento.Size = New System.Drawing.Size(110, 17)
        Me.rdbProcesamiento.TabIndex = 67
        Me.rdbProcesamiento.TabStop = True
        Me.rdbProcesamiento.Text = "En procesamiento"
        Me.rdbProcesamiento.UseVisualStyleBackColor = True
        '
        'grbEstadoEnvio
        '
        Me.grbEstadoEnvio.BackColor = System.Drawing.Color.Transparent
        Me.grbEstadoEnvio.Controls.Add(Me.rdbEntregado)
        Me.grbEstadoEnvio.Controls.Add(Me.rdbEnviado)
        Me.grbEstadoEnvio.Controls.Add(Me.Label7)
        Me.grbEstadoEnvio.Controls.Add(Me.rdbProcesamiento)
        Me.grbEstadoEnvio.Location = New System.Drawing.Point(43, 249)
        Me.grbEstadoEnvio.Name = "grbEstadoEnvio"
        Me.grbEstadoEnvio.Size = New System.Drawing.Size(401, 55)
        Me.grbEstadoEnvio.TabIndex = 69
        Me.grbEstadoEnvio.TabStop = False
        '
        'rdbEntregado
        '
        Me.rdbEntregado.AutoSize = True
        Me.rdbEntregado.Location = New System.Drawing.Point(301, 21)
        Me.rdbEntregado.Name = "rdbEntregado"
        Me.rdbEntregado.Size = New System.Drawing.Size(74, 17)
        Me.rdbEntregado.TabIndex = 69
        Me.rdbEntregado.TabStop = True
        Me.rdbEntregado.Text = "Entregado"
        Me.rdbEntregado.UseVisualStyleBackColor = True
        '
        'rdbEnviado
        '
        Me.rdbEnviado.AutoSize = True
        Me.rdbEnviado.Location = New System.Drawing.Point(215, 21)
        Me.rdbEnviado.Name = "rdbEnviado"
        Me.rdbEnviado.Size = New System.Drawing.Size(64, 17)
        Me.rdbEnviado.TabIndex = 68
        Me.rdbEnviado.TabStop = True
        Me.rdbEnviado.Text = "Enviado"
        Me.rdbEnviado.UseVisualStyleBackColor = True
        '
        'cbxEmpresa
        '
        Me.cbxEmpresa.DataSource = Me.EmpresaEnviosBindingSource1
        Me.cbxEmpresa.DisplayMember = "nombreEmpresa"
        Me.cbxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEmpresa.FormattingEnabled = True
        Me.cbxEmpresa.Location = New System.Drawing.Point(184, 129)
        Me.cbxEmpresa.Name = "cbxEmpresa"
        Me.cbxEmpresa.Size = New System.Drawing.Size(199, 21)
        Me.cbxEmpresa.TabIndex = 58
        Me.cbxEmpresa.ValueMember = "idempresa"
        '
        'TECNO_PCSDataSet1
        '
        Me.TECNO_PCSDataSet1.DataSetName = "TECNO_PCSDataSet1"
        Me.TECNO_PCSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresaEnviosBindingSource1
        '
        Me.EmpresaEnviosBindingSource1.DataMember = "empresaEnvios"
        Me.EmpresaEnviosBindingSource1.DataSource = Me.TECNO_PCSDataSet1
        '
        'EmpresaEnviosTableAdapter1
        '
        Me.EmpresaEnviosTableAdapter1.ClearBeforeFill = True
        '
        'FormModuloEnvios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.fondo_azul
        Me.ClientSize = New System.Drawing.Size(492, 388)
        Me.Controls.Add(Me.grbEstadoEnvio)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpFechaEnvio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudDias)
        Me.Controls.Add(Me.cbxEmpresa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtIdVenta)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormModuloEnvios"
        Me.Text = "Modulo de Envios"
        CType(Me.EmpresaEnviosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboboxEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbEstadoEnvio.ResumeLayout(False)
        Me.grbEstadoEnvio.PerformLayout()
        CType(Me.TECNO_PCSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaEnviosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtIdVenta As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboboxEmpresa As ComboboxEmpresa
    Friend WithEvents EmpresaEnviosBindingSource As BindingSource
    Friend WithEvents EmpresaEnviosTableAdapter As ComboboxEmpresaTableAdapters.empresaEnviosTableAdapter
    Friend WithEvents nudDias As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFechaEnvio As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents rdbProcesamiento As RadioButton
    Friend WithEvents grbEstadoEnvio As GroupBox
    Friend WithEvents rdbEntregado As RadioButton
    Friend WithEvents rdbEnviado As RadioButton
    Friend WithEvents cbxEmpresa As ComboBox
    Friend WithEvents TECNO_PCSDataSet1 As TECNO_PCSDataSet1
    Friend WithEvents EmpresaEnviosBindingSource1 As BindingSource
    Friend WithEvents EmpresaEnviosTableAdapter1 As TECNO_PCSDataSet1TableAdapters.empresaEnviosTableAdapter
End Class
