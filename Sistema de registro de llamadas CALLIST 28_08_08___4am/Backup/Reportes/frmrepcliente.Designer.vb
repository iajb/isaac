<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrepcliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrepcliente))
        Me.crpviewclientes = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crpviewclientes
        '
        Me.crpviewclientes.ActiveViewIndex = 0
        Me.crpviewclientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crpviewclientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crpviewclientes.Location = New System.Drawing.Point(0, 0)
        Me.crpviewclientes.Name = "crpviewclientes"
        Me.crpviewclientes.ReportSource = "E:\proyectos recientes\Sistema Mendieta\Sistema de registro de llamadas CALLIST\R" & _
            "eportes\crpclientes.rpt"
        Me.crpviewclientes.Size = New System.Drawing.Size(566, 436)
        Me.crpviewclientes.TabIndex = 0
        '
        'frmrepcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 436)
        Me.Controls.Add(Me.crpviewclientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmrepcliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Masivo Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crpviewclientes As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
