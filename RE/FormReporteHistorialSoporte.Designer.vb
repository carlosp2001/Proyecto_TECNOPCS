<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteHistorialSoporte
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
        Me.ReporteHistorialSoporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New proyecto_de_analisis.DataSet1()
        Me.rpvSoporte = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReporteHistorialSoporteTableAdapter = New proyecto_de_analisis.DataSet1TableAdapters.ReporteHistorialSoporteTableAdapter()
        CType(Me.ReporteHistorialSoporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReporteHistorialSoporteBindingSource
        '
        Me.ReporteHistorialSoporteBindingSource.DataMember = "ReporteHistorialSoporte"
        Me.ReporteHistorialSoporteBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpvSoporte
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ReporteHistorialSoporteBindingSource
        Me.rpvSoporte.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvSoporte.LocalReport.ReportEmbeddedResource = "proyecto_de_analisis.ReporteHistorialSoporte.rdlc"
        Me.rpvSoporte.Location = New System.Drawing.Point(12, 12)
        Me.rpvSoporte.Name = "rpvSoporte"
        Me.rpvSoporte.ServerReport.BearerToken = Nothing
        Me.rpvSoporte.Size = New System.Drawing.Size(814, 426)
        Me.rpvSoporte.TabIndex = 0
        '
        'ReporteHistorialSoporteTableAdapter
        '
        Me.ReporteHistorialSoporteTableAdapter.ClearBeforeFill = True
        '
        'FormReporteHistorialSoporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 450)
        Me.Controls.Add(Me.rpvSoporte)
        Me.Name = "FormReporteHistorialSoporte"
        Me.Text = "Reporte Historial de Soporte Tecnico"
        CType(Me.ReporteHistorialSoporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rpvSoporte As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReporteHistorialSoporteBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ReporteHistorialSoporteTableAdapter As DataSet1TableAdapters.ReporteHistorialSoporteTableAdapter
End Class
