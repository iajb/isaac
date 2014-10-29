<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_consulta_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_consulta_usuario))
        Me.lsvuser = New System.Windows.Forms.ListView
        Me.numfilas = New System.Windows.Forms.ColumnHeader
        Me.colcod = New System.Windows.Forms.ColumnHeader
        Me.colnombre = New System.Windows.Forms.ColumnHeader
        Me.colapellido = New System.Windows.Forms.ColumnHeader
        Me.coldireccion = New System.Windows.Forms.ColumnHeader
        Me.coltelefono = New System.Windows.Forms.ColumnHeader
        Me.coluser = New System.Windows.Forms.ColumnHeader
        Me.colpassword = New System.Windows.Forms.ColumnHeader
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lsvuser
        '
        Me.lsvuser.BackColor = System.Drawing.Color.Linen
        Me.lsvuser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.numfilas, Me.colcod, Me.colnombre, Me.colapellido, Me.coldireccion, Me.coltelefono, Me.coluser, Me.colpassword})
        Me.lsvuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvuser.FullRowSelect = True
        Me.lsvuser.GridLines = True
        Me.lsvuser.Location = New System.Drawing.Point(8, 8)
        Me.lsvuser.Name = "lsvuser"
        Me.lsvuser.Size = New System.Drawing.Size(584, 168)
        Me.lsvuser.TabIndex = 0
        Me.lsvuser.UseCompatibleStateImageBehavior = False
        Me.lsvuser.View = System.Windows.Forms.View.Details
        '
        'numfilas
        '
        Me.numfilas.DisplayIndex = 7
        Me.numfilas.Text = "# Filas"
        Me.numfilas.Width = 0
        '
        'colcod
        '
        Me.colcod.DisplayIndex = 0
        Me.colcod.Text = "cedula"
        Me.colcod.Width = 120
        '
        'colnombre
        '
        Me.colnombre.DisplayIndex = 1
        Me.colnombre.Text = "Nombre"
        Me.colnombre.Width = 120
        '
        'colapellido
        '
        Me.colapellido.DisplayIndex = 2
        Me.colapellido.Text = "Apellido"
        Me.colapellido.Width = 120
        '
        'coldireccion
        '
        Me.coldireccion.DisplayIndex = 3
        Me.coldireccion.Text = "Direccion"
        Me.coldireccion.Width = 200
        '
        'coltelefono
        '
        Me.coltelefono.DisplayIndex = 4
        Me.coltelefono.Text = "Telefono"
        Me.coltelefono.Width = 120
        '
        'coluser
        '
        Me.coluser.DisplayIndex = 5
        Me.coluser.Text = "Usuario"
        Me.coluser.Width = 120
        '
        'colpassword
        '
        Me.colpassword.DisplayIndex = 6
        Me.colpassword.Text = "Password"
        Me.colpassword.Width = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(600, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_consulta_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 181)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lsvuser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_consulta_usuario"
        Me.Text = "Consulta de Usuarios"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsvuser As System.Windows.Forms.ListView
    Friend WithEvents colcod As System.Windows.Forms.ColumnHeader
    Friend WithEvents colnombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents colapellido As System.Windows.Forms.ColumnHeader
    Friend WithEvents coldireccion As System.Windows.Forms.ColumnHeader
    Friend WithEvents coltelefono As System.Windows.Forms.ColumnHeader
    Friend WithEvents coluser As System.Windows.Forms.ColumnHeader
    Friend WithEvents colpassword As System.Windows.Forms.ColumnHeader
    Friend WithEvents numfilas As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
