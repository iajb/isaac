<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrepvendedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrepvendedor))
        Me.crpviewvendedor = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.crpvend1 = New Project1.crpvend
        Me.SuspendLayout()
        '
        'crpviewvendedor
        '
        Me.crpviewvendedor.ActiveViewIndex = 0
        Me.crpviewvendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crpviewvendedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crpviewvendedor.Location = New System.Drawing.Point(0, 0)
        Me.crpviewvendedor.Name = "crpviewvendedor"
        Me.crpviewvendedor.ReportSource = "E:\proyectos recientes\Sistema Mendieta\Sistema de registro de llamadas CALLIST\R" & _
            "eportes\crpvend.rpt"
        Me.crpviewvendedor.Size = New System.Drawing.Size(588, 454)
        Me.crpviewvendedor.TabIndex = 0
        '
        'frmrepvendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 454)
        Me.Controls.Add(Me.crpviewvendedor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmrepvendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Masivo Vendedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crpviewvendedor As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crpvend1 As Project1.crpvend
End Class
