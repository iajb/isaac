<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usercontrol
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.gpbdatos1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txbDireccion = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txbCedula = New System.Windows.Forms.TextBox
        Me.txbApellido = New System.Windows.Forms.TextBox
        Me.txbNombre = New System.Windows.Forms.TextBox
        Me.txbTelefono = New System.Windows.Forms.TextBox
        Me.gpbdatos1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbdatos1
        '
        Me.gpbdatos1.Controls.Add(Me.Label5)
        Me.gpbdatos1.Controls.Add(Me.txbDireccion)
        Me.gpbdatos1.Controls.Add(Me.Label3)
        Me.gpbdatos1.Controls.Add(Me.Label2)
        Me.gpbdatos1.Controls.Add(Me.Label1)
        Me.gpbdatos1.Controls.Add(Me.Label4)
        Me.gpbdatos1.Controls.Add(Me.txbCedula)
        Me.gpbdatos1.Controls.Add(Me.txbApellido)
        Me.gpbdatos1.Controls.Add(Me.txbNombre)
        Me.gpbdatos1.Controls.Add(Me.txbTelefono)
        Me.gpbdatos1.Location = New System.Drawing.Point(9, 12)
        Me.gpbdatos1.Name = "gpbdatos1"
        Me.gpbdatos1.Size = New System.Drawing.Size(271, 225)
        Me.gpbdatos1.TabIndex = 0
        Me.gpbdatos1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Dirección : "
        '
        'txbDireccion
        '
        Me.txbDireccion.Location = New System.Drawing.Point(120, 187)
        Me.txbDireccion.MaxLength = 200
        Me.txbDireccion.Name = "txbDireccion"
        Me.txbDireccion.Size = New System.Drawing.Size(144, 20)
        Me.txbDireccion.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Cédula :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Apellido :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Teléfono : "
        '
        'txbCedula
        '
        Me.txbCedula.Location = New System.Drawing.Point(120, 16)
        Me.txbCedula.MaxLength = 10
        Me.txbCedula.Name = "txbCedula"
        Me.txbCedula.Size = New System.Drawing.Size(139, 20)
        Me.txbCedula.TabIndex = 1
        '
        'txbApellido
        '
        Me.txbApellido.Location = New System.Drawing.Point(120, 104)
        Me.txbApellido.MaxLength = 50
        Me.txbApellido.Name = "txbApellido"
        Me.txbApellido.Size = New System.Drawing.Size(144, 20)
        Me.txbApellido.TabIndex = 3
        '
        'txbNombre
        '
        Me.txbNombre.Location = New System.Drawing.Point(120, 56)
        Me.txbNombre.MaxLength = 50
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(144, 20)
        Me.txbNombre.TabIndex = 2
        '
        'txbTelefono
        '
        Me.txbTelefono.Location = New System.Drawing.Point(120, 147)
        Me.txbTelefono.MaxLength = 50
        Me.txbTelefono.Name = "txbTelefono"
        Me.txbTelefono.Size = New System.Drawing.Size(144, 20)
        Me.txbTelefono.TabIndex = 4
        '
        'usercontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gpbdatos1)
        Me.Name = "usercontrol"
        Me.Size = New System.Drawing.Size(291, 244)
        Me.gpbdatos1.ResumeLayout(False)
        Me.gpbdatos1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpbdatos1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txbDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txbCedula As System.Windows.Forms.TextBox
    Friend WithEvents txbApellido As System.Windows.Forms.TextBox
    Friend WithEvents txbNombre As System.Windows.Forms.TextBox
    Friend WithEvents txbTelefono As System.Windows.Forms.TextBox

End Class
