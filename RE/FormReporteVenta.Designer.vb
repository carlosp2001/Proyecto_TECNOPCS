<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteVenta
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
        Me.ReporteVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New proyecto_de_analisis.DataSet1()
        Me.dtpinicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfinal = New System.Windows.Forms.DateTimePicker()
        Me.rpvVenta = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReporteVentasTableAdapter = New proyecto_de_analisis.DataSet1TableAdapters.ReporteVentasTableAdapter()
        CType(Me.ReporteVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReporteVentasBindingSource
        '
        Me.ReporteVentasBindingSource.DataMember = "ReporteVentas"
        Me.ReporteVentasBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpinicio
        '
        Me.dtpinicio.Location = New System.Drawing.Point(169, 31)
        Me.dtpinicio.Name = "dtpinicio"
        Me.dtpinicio.Size = New System.Drawing.Size(200, 20)
        Me.dtpinicio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Inicio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(398, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Final:"
        '
        'dtpfinal
        '
        Me.dtpfinal.Location = New System.Drawing.Point(472, 31)
        Me.dtpfinal.Name = "dtpfinal"
        Me.dtpfinal.Size = New System.Drawing.Size(200, 20)
        Me.dtpfinal.TabIndex = 3
        '
        'rpvVenta
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ReporteVentasBindingSource
        Me.rpvVenta.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvVenta.LocalReport.ReportEmbeddedResource = "proyecto_de_analisis.ReporteVentas.rdlc"
        Me.rpvVenta.Location = New System.Drawing.Point(12, 72)
        Me.rpvVenta.Name = "rpvVenta"
        Me.rpvVenta.ServerReport.BearerToken = Nothing
        Me.rpvVenta.Size = New System.Drawing.Size(776, 366)
        Me.rpvVenta.TabIndex = 5
        '
        'ReporteVentasTableAdapter
        '
        Me.ReporteVentasTableAdapter.ClearBeforeFill = True
        '
        'FormReporteVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rpvVenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpfinal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpinicio)
        Me.Name = "FormReporteVenta"
        Me.Text = "Reporte de Venta"
        CType(Me.ReporteVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReporteVentasBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ReporteVentasTableAdapter As DataSet1TableAdapters.ReporteVentasTableAdapter
    Friend WithEvents dtpinicio As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpfinal As DateTimePicker
    Friend WithEvents rpvVenta As Microsoft.Reporting.WinForms.ReportViewer
End Class
