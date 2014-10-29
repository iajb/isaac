<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_inguser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_inguser))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtrepcontraseña = New System.Windows.Forms.TextBox
        Me.txtcontraseña = New System.Windows.Forms.TextBox
        Me.txtuser = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tstmantmaq = New System.Windows.Forms.ToolStrip
        Me.tlsnuevo = New System.Windows.Forms.ToolStripButton
        Me.tlsgrabar = New System.Windows.Forms.ToolStripButton
        Me.tlsmodificar = New System.Windows.Forms.ToolStripButton
        Me.tlsbeliminar = New System.Windows.Forms.ToolStripButton
        Me.tlsborrar = New System.Windows.Forms.ToolStripButton
        Me.tlssalir = New System.Windows.Forms.ToolStripButton
        Me.btnconsuser = New System.Windows.Forms.Button
        Me.Usercontrol1 = New Project1.usercontrol
        Me.GroupBox1.SuspendLayout()
        Me.tstmantmaq.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtrepcontraseña)
        Me.GroupBox1.Controls.Add(Me.txtcontraseña)
        Me.GroupBox1.Controls.Add(Me.txtuser)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 120)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'txtrepcontraseña
        '
        Me.txtrepcontraseña.Location = New System.Drawing.Point(144, 88)
        Me.txtrepcontraseña.MaxLength = 15
        Me.txtrepcontraseña.Name = "txtrepcontraseña"
        Me.txtrepcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtrepcontraseña.Size = New System.Drawing.Size(139, 20)
        Me.txtrepcontraseña.TabIndex = 9
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(144, 56)
        Me.txtcontraseña.MaxLength = 15
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(139, 20)
        Me.txtcontraseña.TabIndex = 8
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(144, 24)
        Me.txtuser.MaxLength = 15
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(139, 20)
        Me.txtuser.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Repetir Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User"
        '
        'tstmantmaq
        '
        Me.tstmantmaq.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsnuevo, Me.tlsgrabar, Me.tlsmodificar, Me.tlsbeliminar, Me.tlsborrar, Me.tlssalir})
        Me.tstmantmaq.Location = New System.Drawing.Point(0, 0)
        Me.tstmantmaq.Name = "tstmantmaq"
        Me.tstmantmaq.Size = New System.Drawing.Size(346, 25)
        Me.tstmantmaq.TabIndex = 11
        Me.tstmantmaq.Text = "ToolStrip1"
        '
        'tlsnuevo
        '
        Me.tlsnuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsnuevo.Image = CType(resources.GetObject("tlsnuevo.Image"), System.Drawing.Image)
        Me.tlsnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsnuevo.Name = "tlsnuevo"
        Me.tlsnuevo.Size = New System.Drawing.Size(23, 22)
        Me.tlsnuevo.ToolTipText = "Nuevo"
        '
        'tlsgrabar
        '
        Me.tlsgrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsgrabar.Image = CType(resources.GetObject("tlsgrabar.Image"), System.Drawing.Image)
        Me.tlsgrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsgrabar.Name = "tlsgrabar"
        Me.tlsgrabar.Size = New System.Drawing.Size(23, 22)
        Me.tlsgrabar.ToolTipText = "grabar"
        '
        'tlsmodificar
        '
        Me.tlsmodificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsmodificar.Image = CType(resources.GetObject("tlsmodificar.Image"), System.Drawing.Image)
        Me.tlsmodificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsmodificar.Name = "tlsmodificar"
        Me.tlsmodificar.Size = New System.Drawing.Size(23, 22)
        Me.tlsmodificar.ToolTipText = "Modificar"
        '
        'tlsbeliminar
        '
        Me.tlsbeliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsbeliminar.Image = CType(resources.GetObject("tlsbeliminar.Image"), System.Drawing.Image)
        Me.tlsbeliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsbeliminar.Name = "tlsbeliminar"
        Me.tlsbeliminar.Size = New System.Drawing.Size(23, 22)
        Me.tlsbeliminar.ToolTipText = "Eliminar Usuario"
        '
        'tlsborrar
        '
        Me.tlsborrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsborrar.Image = CType(resources.GetObject("tlsborrar.Image"), System.Drawing.Image)
        Me.tlsborrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsborrar.Name = "tlsborrar"
        Me.tlsborrar.Size = New System.Drawing.Size(23, 22)
        Me.tlsborrar.ToolTipText = "Cancelar"
        '
        'tlssalir
        '
        Me.tlssalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlssalir.Image = CType(resources.GetObject("tlssalir.Image"), System.Drawing.Image)
        Me.tlssalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlssalir.Name = "tlssalir"
        Me.tlssalir.Size = New System.Drawing.Size(23, 22)
        Me.tlssalir.ToolTipText = "Salir"
        '
        'btnconsuser
        '
        Me.btnconsuser.Location = New System.Drawing.Point(312, 56)
        Me.btnconsuser.Name = "btnconsuser"
        Me.btnconsuser.Size = New System.Drawing.Size(32, 23)
        Me.btnconsuser.TabIndex = 21
        Me.btnconsuser.Text = "..."
        Me.btnconsuser.UseVisualStyleBackColor = True
        '
        'Usercontrol1
        '
        Me.Usercontrol1.Location = New System.Drawing.Point(8, 32)
        Me.Usercontrol1.Name = "Usercontrol1"
        Me.Usercontrol1.Size = New System.Drawing.Size(291, 244)
        Me.Usercontrol1.TabIndex = 0
        '
        'frm_inguser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 414)
        Me.Controls.Add(Me.Usercontrol1)
        Me.Controls.Add(Me.btnconsuser)
        Me.Controls.Add(Me.tstmantmaq)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_inguser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tstmantmaq.ResumeLayout(False)
        Me.tstmantmaq.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtrepcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents tstmantmaq As System.Windows.Forms.ToolStrip
    Friend WithEvents tlsnuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsgrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsborrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlssalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsmodificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnconsuser As System.Windows.Forms.Button
    Friend WithEvents Usercontrol1 As Project1.usercontrol
    Friend WithEvents tlsbeliminar As System.Windows.Forms.ToolStripButton
End Class
