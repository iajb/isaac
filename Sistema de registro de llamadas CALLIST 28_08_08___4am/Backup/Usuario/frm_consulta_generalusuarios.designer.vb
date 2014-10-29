<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_consulta_generalusuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_consulta_generalusuarios))
        Me.lsvusuarios = New System.Windows.Forms.ListView
        Me.lsvnumero = New System.Windows.Forms.ColumnHeader
        Me.lsvcedula = New System.Windows.Forms.ColumnHeader
        Me.lsvnombre = New System.Windows.Forms.ColumnHeader
        Me.lsvapellido = New System.Windows.Forms.ColumnHeader
        Me.lsvtelefono = New System.Windows.Forms.ColumnHeader
        Me.lsvdireccion = New System.Windows.Forms.ColumnHeader
        Me.lsvmail = New System.Windows.Forms.ColumnHeader
        Me.lsvuser = New System.Windows.Forms.ColumnHeader
        Me.lsvpassword = New System.Windows.Forms.ColumnHeader
        Me.lsvfechacreacion = New System.Windows.Forms.ColumnHeader
        Me.Salirbtn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lsvusuarios
        '
        Me.lsvusuarios.BackColor = System.Drawing.Color.Linen
        Me.lsvusuarios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lsvnumero, Me.lsvcedula, Me.lsvnombre, Me.lsvapellido, Me.lsvtelefono, Me.lsvdireccion, Me.lsvmail, Me.lsvuser, Me.lsvpassword, Me.lsvfechacreacion})
        Me.lsvusuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvusuarios.FullRowSelect = True
        Me.lsvusuarios.GridLines = True
        Me.lsvusuarios.Location = New System.Drawing.Point(2, -2)
        Me.lsvusuarios.MaximumSize = New System.Drawing.Size(1027, 325)
        Me.lsvusuarios.Name = "lsvusuarios"
        Me.lsvusuarios.Size = New System.Drawing.Size(590, 325)
        Me.lsvusuarios.TabIndex = 2
        Me.lsvusuarios.UseCompatibleStateImageBehavior = False
        Me.lsvusuarios.View = System.Windows.Forms.View.Details
        '
        'lsvnumero
        '
        Me.lsvnumero.Text = "#"
        Me.lsvnumero.Width = 28
        '
        'lsvcedula
        '
        Me.lsvcedula.Text = "Cédula"
        Me.lsvcedula.Width = 73
        '
        'lsvnombre
        '
        Me.lsvnombre.Text = "Nombre"
        Me.lsvnombre.Width = 132
        '
        'lsvapellido
        '
        Me.lsvapellido.Text = "Apellido"
        Me.lsvapellido.Width = 137
        '
        'lsvtelefono
        '
        Me.lsvtelefono.Text = "Télefono"
        Me.lsvtelefono.Width = 79
        '
        'lsvdireccion
        '
        Me.lsvdireccion.Text = "Dirección"
        Me.lsvdireccion.Width = 139
        '
        'lsvmail
        '
        Me.lsvmail.Text = "E-mail"
        Me.lsvmail.Width = 126
        '
        'lsvuser
        '
        Me.lsvuser.Text = "User"
        Me.lsvuser.Width = 96
        '
        'lsvpassword
        '
        Me.lsvpassword.Text = "Password"
        Me.lsvpassword.Width = 86
        '
        'lsvfechacreacion
        '
        Me.lsvfechacreacion.Text = "Fecha de Creación"
        Me.lsvfechacreacion.Width = 118
        '
        'Salirbtn
        '
        Me.Salirbtn.Location = New System.Drawing.Point(22, 329)
        Me.Salirbtn.Name = "Salirbtn"
        Me.Salirbtn.Size = New System.Drawing.Size(75, 23)
        Me.Salirbtn.TabIndex = 3
        Me.Salirbtn.Text = "Salir"
        Me.Salirbtn.UseVisualStyleBackColor = True
        '
        'frm_consulta_generalusuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 358)
        Me.Controls.Add(Me.Salirbtn)
        Me.Controls.Add(Me.lsvusuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 71)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_consulta_generalusuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consulta General de Usuarios"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsvusuarios As System.Windows.Forms.ListView
    Friend WithEvents lsvnumero As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvcedula As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvnombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvapellido As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvtelefono As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvdireccion As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvuser As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvpassword As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvfechacreacion As System.Windows.Forms.ColumnHeader
    Friend WithEvents Salirbtn As System.Windows.Forms.Button
End Class
