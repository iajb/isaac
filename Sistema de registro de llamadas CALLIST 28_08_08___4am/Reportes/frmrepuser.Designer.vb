<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrepuser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrepuser))
        Me.crpviewuser = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crpviewuser
        '
        Me.crpviewuser.ActiveViewIndex = 0
        Me.crpviewuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crpviewuser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crpviewuser.Location = New System.Drawing.Point(0, 0)
        Me.crpviewuser.Name = "crpviewuser"
        Me.crpviewuser.ReportSource = "E:\proyectos recientes\Sistema Mendieta\Sistema de registro de llamadas CALLIST\R" & _
            "eportes\crpuser.rpt"
        Me.crpviewuser.Size = New System.Drawing.Size(564, 429)
        Me.crpviewuser.TabIndex = 0
        '
        'frmrepuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 429)
        Me.Controls.Add(Me.crpviewuser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmrepuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Masivo Usuario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crpviewuser As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
