<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_auditoriausuario
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
        Me.lsvconsultaclientes = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.lsv_codauditoria = New System.Windows.Forms.ColumnHeader
        Me.lsv_cedula = New System.Windows.Forms.ColumnHeader
        Me.lsv_usuario = New System.Windows.Forms.ColumnHeader
        Me.lsv_fechaentrada = New System.Windows.Forms.ColumnHeader
        Me.lsv_fechasalida = New System.Windows.Forms.ColumnHeader
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lsvconsultaclientes
        '
        Me.lsvconsultaclientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.lsv_codauditoria, Me.lsv_cedula, Me.lsv_usuario, Me.lsv_fechaentrada, Me.lsv_fechasalida})
        Me.lsvconsultaclientes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvconsultaclientes.FullRowSelect = True
        Me.lsvconsultaclientes.GridLines = True
        Me.lsvconsultaclientes.Location = New System.Drawing.Point(9, 10)
        Me.lsvconsultaclientes.Name = "lsvconsultaclientes"
        Me.lsvconsultaclientes.Scrollable = False
        Me.lsvconsultaclientes.Size = New System.Drawing.Size(588, 274)
        Me.lsvconsultaclientes.TabIndex = 1
        Me.lsvconsultaclientes.UseCompatibleStateImageBehavior = False
        Me.lsvconsultaclientes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 30
        '
        'lsv_codauditoria
        '
        Me.lsv_codauditoria.Text = "Codido  Auditoría"
        Me.lsv_codauditoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lsv_codauditoria.Width = 114
        '
        'lsv_cedula
        '
        Me.lsv_cedula.Text = "Cédula"
        Me.lsv_cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lsv_cedula.Width = 114
        '
        'lsv_usuario
        '
        Me.lsv_usuario.Text = "Usuario"
        Me.lsv_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lsv_usuario.Width = 0
        '
        'lsv_fechaentrada
        '
        Me.lsv_fechaentrada.Text = "Fecha Entrada"
        Me.lsv_fechaentrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lsv_fechaentrada.Width = 186
        '
        'lsv_fechasalida
        '
        Me.lsv_fechasalida.Text = "Fecha Salida"
        Me.lsv_fechasalida.Width = 140
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_auditoriausuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 319)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lsvconsultaclientes)
        Me.Location = New System.Drawing.Point(0, 71)
        Me.MaximizeBox = False
        Me.Name = "frm_auditoriausuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditoría de Usuario"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsvconsultaclientes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsv_codauditoria As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsv_cedula As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsv_usuario As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsv_fechaentrada As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsv_fechasalida As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
