<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGenerarFacturacion
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataSet1 = New proyecto_de_analisis.DataSet1()
        Me.ReporteGenerarFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteGenerarFacturaTableAdapter = New proyecto_de_analisis.DataSet1TableAdapters.ReporteGenerarFacturaTableAdapter()
        Me.rpvFactura = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReporteGenerarFacturaDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteGenerarFacturaDetalleTableAdapter = New proyecto_de_analisis.DataSet1TableAdapters.ReporteGenerarFacturaDetalleTableAdapter()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteGenerarFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteGenerarFacturaDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReporteGenerarFacturaBindingSource
        '
        Me.ReporteGenerarFacturaBindingSource.DataMember = "ReporteGenerarFactura"
        Me.ReporteGenerarFacturaBindingSource.DataSource = Me.DataSet1
        '
        'ReporteGenerarFacturaTableAdapter
        '
        Me.ReporteGenerarFacturaTableAdapter.ClearBeforeFill = True
        '
        'rpvFactura
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ReporteGenerarFacturaBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.ReporteGenerarFacturaDetalleBindingSource
        Me.rpvFactura.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvFactura.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rpvFactura.LocalReport.ReportEmbeddedResource = "proyecto_de_analisis.ReportFactura.rdlc"
        Me.rpvFactura.Location = New System.Drawing.Point(12, 12)
        Me.rpvFactura.Name = "rpvFactura"
        Me.rpvFactura.ServerReport.BearerToken = Nothing
        Me.rpvFactura.Size = New System.Drawing.Size(776, 426)
        Me.rpvFactura.TabIndex = 0
        '
        'ReporteGenerarFacturaDetalleBindingSource
        '
        Me.ReporteGenerarFacturaDetalleBindingSource.DataMember = "ReporteGenerarFacturaDetalle"
        Me.ReporteGenerarFacturaDetalleBindingSource.DataSource = Me.DataSet1
        '
        'ReporteGenerarFacturaDetalleTableAdapter
        '
        Me.ReporteGenerarFacturaDetalleTableAdapter.ClearBeforeFill = True
        '
        'FormGenerarFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rpvFactura)
        Me.Name = "FormGenerarFacturacion"
        Me.Text = "FormGenerarFacturacion"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteGenerarFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteGenerarFacturaDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReporteGenerarFacturaBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ReporteGenerarFacturaTableAdapter As DataSet1TableAdapters.ReporteGenerarFacturaTableAdapter
    Friend WithEvents rpvFactura As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReporteGenerarFacturaDetalleBindingSource As BindingSource
    Friend WithEvents ReporteGenerarFacturaDetalleTableAdapter As DataSet1TableAdapters.ReporteGenerarFacturaDetalleTableAdapter
End Class
