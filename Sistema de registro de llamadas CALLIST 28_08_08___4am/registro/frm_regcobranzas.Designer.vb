<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_regcobranzas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_regcobranzas))
        Me.grb_trabajo = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.chk_estados = New System.Windows.Forms.CheckBox
        Me.cb_hora = New System.Windows.Forms.DateTimePicker
        Me.cb_fecha = New System.Windows.Forms.DateTimePicker
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtComentario = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txbnumtrabajo = New System.Windows.Forms.TextBox
        Me.txbnumdomicilio = New System.Windows.Forms.TextBox
        Me.txtnumcelular = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.grb_trabajo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_trabajo
        '
        Me.grb_trabajo.Controls.Add(Me.Label5)
        Me.grb_trabajo.Controls.Add(Me.TextBox2)
        Me.grb_trabajo.Controls.Add(Me.Label21)
        Me.grb_trabajo.Controls.Add(Me.chk_estados)
        Me.grb_trabajo.Controls.Add(Me.cb_hora)
        Me.grb_trabajo.Controls.Add(Me.cb_fecha)
        Me.grb_trabajo.Controls.Add(Me.Label19)
        Me.grb_trabajo.Controls.Add(Me.txtComentario)
        Me.grb_trabajo.Controls.Add(Me.Label17)
        Me.grb_trabajo.Controls.Add(Me.ComboBox2)
        Me.grb_trabajo.Controls.Add(Me.ComboBox1)
        Me.grb_trabajo.Controls.Add(Me.Label16)
        Me.grb_trabajo.Controls.Add(Me.txbnumtrabajo)
        Me.grb_trabajo.Controls.Add(Me.txbnumdomicilio)
        Me.grb_trabajo.Controls.Add(Me.txtnumcelular)
        Me.grb_trabajo.Controls.Add(Me.Label3)
        Me.grb_trabajo.Controls.Add(Me.Label4)
        Me.grb_trabajo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_trabajo.Location = New System.Drawing.Point(14, 46)
        Me.grb_trabajo.Name = "grb_trabajo"
        Me.grb_trabajo.Size = New System.Drawing.Size(663, 148)
        Me.grb_trabajo.TabIndex = 77
        Me.grb_trabajo.TabStop = False
        Me.grb_trabajo.Text = "Datos Trabajo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Fono 2 "
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox2.Location = New System.Drawing.Point(65, 17)
        Me.TextBox2.MaxLength = 9
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(157, 21)
        Me.TextBox2.TabIndex = 98
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(4, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 13)
        Me.Label21.TabIndex = 99
        Me.Label21.Text = " Trabajo"
        '
        'chk_estados
        '
        Me.chk_estados.AutoSize = True
        Me.chk_estados.Enabled = False
        Me.chk_estados.Location = New System.Drawing.Point(257, 57)
        Me.chk_estados.Name = "chk_estados"
        Me.chk_estados.Size = New System.Drawing.Size(15, 14)
        Me.chk_estados.TabIndex = 97
        Me.chk_estados.UseVisualStyleBackColor = True
        '
        'cb_hora
        '
        Me.cb_hora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.cb_hora.Location = New System.Drawing.Point(483, 53)
        Me.cb_hora.Name = "cb_hora"
        Me.cb_hora.ShowUpDown = True
        Me.cb_hora.Size = New System.Drawing.Size(71, 21)
        Me.cb_hora.TabIndex = 93
        '
        'cb_fecha
        '
        Me.cb_fecha.CustomFormat = ""
        Me.cb_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cb_fecha.Location = New System.Drawing.Point(379, 52)
        Me.cb_fecha.Name = "cb_fecha"
        Me.cb_fecha.Size = New System.Drawing.Size(93, 21)
        Me.cb_fecha.TabIndex = 92
        Me.cb_fecha.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(278, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 13)
        Me.Label19.TabIndex = 91
        Me.Label19.Text = "Fecha Call Back"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(81, 110)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentario.Size = New System.Drawing.Size(512, 33)
        Me.txtComentario.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 13)
        Me.Label17.TabIndex = 88
        Me.Label17.Text = "Comentario"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(460, 82)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(194, 21)
        Me.ComboBox2.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(314, 82)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(254, 82)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 85
        Me.Label16.Text = "Estado"
        '
        'txbnumtrabajo
        '
        Me.txbnumtrabajo.BackColor = System.Drawing.SystemColors.Window
        Me.txbnumtrabajo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txbnumtrabajo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbnumtrabajo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txbnumtrabajo.Location = New System.Drawing.Point(65, 50)
        Me.txbnumtrabajo.MaxLength = 9
        Me.txbnumtrabajo.Name = "txbnumtrabajo"
        Me.txbnumtrabajo.Size = New System.Drawing.Size(115, 21)
        Me.txbnumtrabajo.TabIndex = 2
        '
        'txbnumdomicilio
        '
        Me.txbnumdomicilio.BackColor = System.Drawing.SystemColors.Window
        Me.txbnumdomicilio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txbnumdomicilio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbnumdomicilio.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txbnumdomicilio.Location = New System.Drawing.Point(314, 19)
        Me.txbnumdomicilio.MaxLength = 9
        Me.txbnumdomicilio.Name = "txbnumdomicilio"
        Me.txbnumdomicilio.Size = New System.Drawing.Size(340, 21)
        Me.txbnumdomicilio.TabIndex = 0
        '
        'txtnumcelular
        '
        Me.txtnumcelular.BackColor = System.Drawing.SystemColors.Window
        Me.txtnumcelular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtnumcelular.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumcelular.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtnumcelular.Location = New System.Drawing.Point(65, 79)
        Me.txtnumcelular.MaxLength = 9
        Me.txtnumcelular.Name = "txtnumcelular"
        Me.txtnumcelular.Size = New System.Drawing.Size(113, 21)
        Me.txtnumcelular.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(249, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = " Direccion "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Fono 1 "
        '
        'frm_regcobranzas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 494)
        Me.Controls.Add(Me.grb_trabajo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_regcobranzas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cobranzas De Prati"
        Me.grb_trabajo.ResumeLayout(False)
        Me.grb_trabajo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grb_trabajo As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents chk_estados As System.Windows.Forms.CheckBox
    Friend WithEvents cb_hora As System.Windows.Forms.DateTimePicker
    Friend WithEvents cb_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtComentario As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txbnumtrabajo As System.Windows.Forms.TextBox
    Friend WithEvents txbnumdomicilio As System.Windows.Forms.TextBox
    Friend WithEvents txtnumcelular As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
