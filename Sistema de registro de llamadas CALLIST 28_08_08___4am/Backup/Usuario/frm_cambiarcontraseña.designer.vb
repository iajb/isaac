<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cambiarcontraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cambiarcontraseña))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtcontraseñaactual = New System.Windows.Forms.TextBox
        Me.txtcontraseñanueva = New System.Windows.Forms.TextBox
        Me.aceptar = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txbrepetircontraseña = New System.Windows.Forms.TextBox
        Me.txbcedula = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña Actual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña Nueva"
        '
        'txtcontraseñaactual
        '
        Me.txtcontraseñaactual.Location = New System.Drawing.Point(155, 126)
        Me.txtcontraseñaactual.MaxLength = 15
        Me.txtcontraseñaactual.Name = "txtcontraseñaactual"
        Me.txtcontraseñaactual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseñaactual.Size = New System.Drawing.Size(157, 20)
        Me.txtcontraseñaactual.TabIndex = 2
        '
        'txtcontraseñanueva
        '
        Me.txtcontraseñanueva.Location = New System.Drawing.Point(155, 155)
        Me.txtcontraseñanueva.MaxLength = 15
        Me.txtcontraseñanueva.Name = "txtcontraseñanueva"
        Me.txtcontraseñanueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseñanueva.Size = New System.Drawing.Size(155, 20)
        Me.txtcontraseñanueva.TabIndex = 3
        '
        'aceptar
        '
        Me.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.aceptar.Location = New System.Drawing.Point(69, 215)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(86, 23)
        Me.aceptar.TabIndex = 5
        Me.aceptar.Text = "Aceptar"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btncancelar.Location = New System.Drawing.Point(172, 215)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(81, 23)
        Me.btncancelar.TabIndex = 6
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 59)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Repetir Contraseña "
        '
        'txbrepetircontraseña
        '
        Me.txbrepetircontraseña.Location = New System.Drawing.Point(155, 184)
        Me.txbrepetircontraseña.MaxLength = 15
        Me.txbrepetircontraseña.Name = "txbrepetircontraseña"
        Me.txbrepetircontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbrepetircontraseña.Size = New System.Drawing.Size(157, 20)
        Me.txbrepetircontraseña.TabIndex = 4
        '
        'txbcedula
        '
        Me.txbcedula.Location = New System.Drawing.Point(152, 78)
        Me.txbcedula.MaxLength = 10
        Me.txbcedula.Name = "txbcedula"
        Me.txbcedula.Size = New System.Drawing.Size(158, 20)
        Me.txbcedula.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Ingrese Num.Cédula"
        '
        'frm_cambiarcontraseña
        '
        Me.AcceptButton = Me.aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btncancelar
        Me.ClientSize = New System.Drawing.Size(320, 250)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txbcedula)
        Me.Controls.Add(Me.txbrepetircontraseña)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.txtcontraseñanueva)
        Me.Controls.Add(Me.txtcontraseñaactual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_cambiarcontraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar Contraseña"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcontraseñaactual As System.Windows.Forms.TextBox
    Friend WithEvents txtcontraseñanueva As System.Windows.Forms.TextBox
    Friend WithEvents aceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txbrepetircontraseña As System.Windows.Forms.TextBox
    Friend WithEvents txbcedula As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
