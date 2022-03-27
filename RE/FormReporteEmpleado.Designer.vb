<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteEmpleado
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReporteEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New proyecto_de_analisis.DataSet1()
        Me.rpvEmpleado = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReporteEmpleadoTableAdapter = New proyecto_de_analisis.DataSet1TableAdapters.ReporteEmpleadoTableAdapter()
        CType(Me.ReporteEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReporteEmpleadoBindingSource
        '
        Me.ReporteEmpleadoBindingSource.DataMember = "ReporteEmpleado"
        Me.ReporteEmpleadoBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpvEmpleado
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ReporteEmpleadoBindingSource
        Me.rpvEmpleado.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvEmpleado.LocalReport.ReportEmbeddedResource = "proyecto_de_analisis.ReporteEmpleado.rdlc"
        Me.rpvEmpleado.Location = New System.Drawing.Point(12, 12)
        Me.rpvEmpleado.Name = "rpvEmpleado"
        Me.rpvEmpleado.ServerReport.BearerToken = Nothing
        Me.rpvEmpleado.Size = New System.Drawing.Size(776, 436)
        Me.rpvEmpleado.TabIndex = 0
        '
        'ReporteEmpleadoTableAdapter
        '
        Me.ReporteEmpleadoTableAdapter.ClearBeforeFill = True
        '
        'FormReporteEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rpvEmpleado)
        Me.Name = "FormReporteEmpleado"
        Me.Text = "Reporte de Empleado"
        CType(Me.ReporteEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rpvEmpleado As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReporteEmpleadoBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ReporteEmpleadoTableAdapter As DataSet1TableAdapters.ReporteEmpleadoTableAdapter
End Class
