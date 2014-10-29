<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_desencriptar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_desencriptar))
        Me.Label1 = New System.Windows.Forms.Label
        Me.btndesencriptar = New System.Windows.Forms.Button
        Me.txtdesencriptar = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtcedula = New System.Windows.Forms.TextBox
        Me.btnsalir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desencriptación"
        '
        'btndesencriptar
        '
        Me.btndesencriptar.Location = New System.Drawing.Point(40, 75)
        Me.btndesencriptar.Name = "btndesencriptar"
        Me.btndesencriptar.Size = New System.Drawing.Size(81, 25)
        Me.btndesencriptar.TabIndex = 2
        Me.btndesencriptar.Text = "Desencriptar"
        Me.btndesencriptar.UseVisualStyleBackColor = True
        '
        'txtdesencriptar
        '
        Me.txtdesencriptar.BackColor = System.Drawing.SystemColors.Window
        Me.txtdesencriptar.Location = New System.Drawing.Point(126, 46)
        Me.txtdesencriptar.Name = "txtdesencriptar"
        Me.txtdesencriptar.ReadOnly = True
        Me.txtdesencriptar.Size = New System.Drawing.Size(115, 20)
        Me.txtdesencriptar.TabIndex = 0
        Me.txtdesencriptar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " Cédula"
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(126, 15)
        Me.txtcedula.MaxLength = 10
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(116, 20)
        Me.txtcedula.TabIndex = 1
        '
        'btnsalir
        '
        Me.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsalir.Location = New System.Drawing.Point(127, 75)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(89, 25)
        Me.btnsalir.TabIndex = 3
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'frm_desencriptar
        '
        Me.AcceptButton = Me.btndesencriptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnsalir
        Me.ClientSize = New System.Drawing.Size(254, 112)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdesencriptar)
        Me.Controls.Add(Me.btndesencriptar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 71)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_desencriptar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desencriptar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btndesencriptar As System.Windows.Forms.Button
    Friend WithEvents txtdesencriptar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcedula As System.Windows.Forms.TextBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
End Class
