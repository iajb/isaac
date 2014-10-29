<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrepproveedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrepproveedor))
        Me.crpviewproveedor = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.crpproveedor1 = New Project1.crpproveedor
        Me.SuspendLayout()
        '
        'crpviewproveedor
        '
        Me.crpviewproveedor.ActiveViewIndex = 0
        Me.crpviewproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crpviewproveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crpviewproveedor.Location = New System.Drawing.Point(0, 0)
        Me.crpviewproveedor.Name = "crpviewproveedor"
        Me.crpviewproveedor.ReportSource = "E:\proyectos recientes\Sistema Mendieta\Sistema de registro de llamadas CALLIST\R" & _
            "eportes\crpproveedor.rpt"
        Me.crpviewproveedor.Size = New System.Drawing.Size(536, 425)
        Me.crpviewproveedor.TabIndex = 0
        '
        'frmrepproveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 425)
        Me.Controls.Add(Me.crpviewproveedor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmrepproveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Masivo Proveedor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crpviewproveedor As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crpproveedor1 As Project1.crpproveedor
End Class
