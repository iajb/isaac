<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Proveedores
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
        Dim btncancelar As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Proveedores))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.salir = New System.Windows.Forms.Button
        Me.lvsproveedores = New System.Windows.Forms.ListView
        Me.lsvcedula = New System.Windows.Forms.ColumnHeader
        Me.lsvnombre = New System.Windows.Forms.ColumnHeader
        Me.lsvapellido = New System.Windows.Forms.ColumnHeader
        Me.lsvmail = New System.Windows.Forms.ColumnHeader
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.borrar = New System.Windows.Forms.Button
        Me.nuevo = New System.Windows.Forms.Button
        Me.modificar = New System.Windows.Forms.Button
        Me.aceptar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cmbpago = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpFechaimportante = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtactividad = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.txtobservaciones = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtfono2 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtfono1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtcargo = New System.Windows.Forms.TextBox
        Me.lbllogin = New System.Windows.Forms.Label
        Me.txtpais = New System.Windows.Forms.TextBox
        Me.lblusuariowindows = New System.Windows.Forms.Label
        Me.txtciudad = New System.Windows.Forms.TextBox
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        btncancelar = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncancelar
        '
        btncancelar.BackColor = System.Drawing.Color.White
        btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        btncancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText
        btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btncancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btncancelar.Location = New System.Drawing.Point(190, 1)
        btncancelar.Name = "btncancelar"
        btncancelar.Size = New System.Drawing.Size(76, 25)
        btncancelar.TabIndex = 11
        btncancelar.Text = "Cancelar"
        btncancelar.UseVisualStyleBackColor = False
        AddHandler btncancelar.Click, AddressOf Me.btncancelar_Click
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(602, 348)
        Me.TabControl1.TabIndex = 74
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BackgroundImage = Global.Project1.My.Resources.Resources.FONDO
        Me.TabPage1.Controls.Add(Me.salir)
        Me.TabPage1.Controls.Add(Me.lvsproveedores)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(594, 322)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "0"
        Me.TabPage1.Text = "Consulta de Proveedores"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.BackColor = System.Drawing.Color.White
        Me.salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.salir.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.salir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salir.Location = New System.Drawing.Point(498, 287)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(76, 26)
        Me.salir.TabIndex = 78
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = False
        '
        'lvsproveedores
        '
        Me.lvsproveedores.BackColor = System.Drawing.Color.Linen
        Me.lvsproveedores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lsvcedula, Me.lsvnombre, Me.lsvapellido, Me.lsvmail})
        Me.lvsproveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvsproveedores.ForeColor = System.Drawing.Color.DimGray
        Me.lvsproveedores.FullRowSelect = True
        Me.lvsproveedores.GridLines = True
        Me.lvsproveedores.Location = New System.Drawing.Point(0, 3)
        Me.lvsproveedores.MaximumSize = New System.Drawing.Size(1027, 325)
        Me.lvsproveedores.Name = "lvsproveedores"
        Me.lvsproveedores.Size = New System.Drawing.Size(592, 265)
        Me.lvsproveedores.TabIndex = 3
        Me.lvsproveedores.UseCompatibleStateImageBehavior = False
        Me.lvsproveedores.View = System.Windows.Forms.View.Details
        '
        'lsvcedula
        '
        Me.lsvcedula.Text = "Codigo"
        Me.lsvcedula.Width = 108
        '
        'lsvnombre
        '
        Me.lsvnombre.Text = "Nombre"
        Me.lsvnombre.Width = 176
        '
        'lsvapellido
        '
        Me.lsvapellido.Text = "Direccion"
        Me.lsvapellido.Width = 186
        '
        'lsvmail
        '
        Me.lsvmail.Text = "Telefono"
        Me.lsvmail.Width = 155
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.BackgroundImage = Global.Project1.My.Resources.Resources.FONDO
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(594, 322)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Tag = "1"
        Me.TabPage2.Text = "Datos del Proveedores"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.Project1.My.Resources.Resources.FONDO
        Me.Panel1.Controls.Add(Me.borrar)
        Me.Panel1.Controls.Add(Me.nuevo)
        Me.Panel1.Controls.Add(Me.modificar)
        Me.Panel1.Controls.Add(Me.aceptar)
        Me.Panel1.Controls.Add(btncancelar)
        Me.Panel1.Location = New System.Drawing.Point(1, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(591, 28)
        Me.Panel1.TabIndex = 73
        '
        'borrar
        '
        Me.borrar.BackColor = System.Drawing.Color.White
        Me.borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.borrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.borrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.borrar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrar.Location = New System.Drawing.Point(376, 1)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(76, 25)
        Me.borrar.TabIndex = 77
        Me.borrar.Text = "Borrar"
        Me.borrar.UseVisualStyleBackColor = False
        '
        'nuevo
        '
        Me.nuevo.BackColor = System.Drawing.Color.White
        Me.nuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevo.Location = New System.Drawing.Point(283, 1)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(76, 25)
        Me.nuevo.TabIndex = 76
        Me.nuevo.Text = "Nuevo"
        Me.nuevo.UseVisualStyleBackColor = False
        '
        'modificar
        '
        Me.modificar.BackColor = System.Drawing.Color.White
        Me.modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.modificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.modificar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modificar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.Location = New System.Drawing.Point(4, 1)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(76, 25)
        Me.modificar.TabIndex = 75
        Me.modificar.Text = "Modificar"
        Me.modificar.UseVisualStyleBackColor = False
        '
        'aceptar
        '
        Me.aceptar.BackColor = System.Drawing.Color.White
        Me.aceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.aceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptar.Location = New System.Drawing.Point(97, 1)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(76, 25)
        Me.aceptar.TabIndex = 74
        Me.aceptar.Text = "Aceptar"
        Me.aceptar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmbpago)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtpFechaimportante)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtactividad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtobservaciones)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtfono2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtfono1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtcargo)
        Me.GroupBox1.Controls.Add(Me.lbllogin)
        Me.GroupBox1.Controls.Add(Me.txtpais)
        Me.GroupBox1.Controls.Add(Me.lblusuariowindows)
        Me.GroupBox1.Controls.Add(Me.txtciudad)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 278)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Cmbpago
        '
        Me.Cmbpago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbpago.FormattingEnabled = True
        Me.Cmbpago.Location = New System.Drawing.Point(149, 164)
        Me.Cmbpago.Name = "Cmbpago"
        Me.Cmbpago.Size = New System.Drawing.Size(121, 21)
        Me.Cmbpago.TabIndex = 115
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 15)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Pago"
        '
        'dtpFechaimportante
        '
        Me.dtpFechaimportante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaimportante.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaimportante.Location = New System.Drawing.Point(481, 131)
        Me.dtpFechaimportante.MaxDate = New Date(9998, 12, 8, 0, 0, 0, 0)
        Me.dtpFechaimportante.Name = "dtpFechaimportante"
        Me.dtpFechaimportante.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaimportante.TabIndex = 113
        Me.dtpFechaimportante.Value = New Date(9998, 12, 8, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(276, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 16)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Fecha de Nacimiento"
        '
        'txtactividad
        '
        Me.txtactividad.Location = New System.Drawing.Point(398, 164)
        Me.txtactividad.MaxLength = 50
        Me.txtactividad.Name = "txtactividad"
        Me.txtactividad.Size = New System.Drawing.Size(183, 20)
        Me.txtactividad.TabIndex = 111
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(276, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Actividad"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Observacion"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(398, 79)
        Me.txtemail.MaxLength = 50
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(183, 20)
        Me.txtemail.TabIndex = 109
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(9, 215)
        Me.txtobservaciones.MaxLength = 300
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(565, 57)
        Me.txtobservaciones.TabIndex = 85
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(276, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Email"
        '
        'txtfono2
        '
        Me.txtfono2.Location = New System.Drawing.Point(398, 52)
        Me.txtfono2.MaxLength = 50
        Me.txtfono2.Name = "txtfono2"
        Me.txtfono2.Size = New System.Drawing.Size(183, 20)
        Me.txtfono2.TabIndex = 107
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(276, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 16)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Telefono Celular"
        '
        'txtfono1
        '
        Me.txtfono1.Location = New System.Drawing.Point(398, 24)
        Me.txtfono1.MaxLength = 50
        Me.txtfono1.Name = "txtfono1"
        Me.txtfono1.Size = New System.Drawing.Size(183, 20)
        Me.txtfono1.TabIndex = 105
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(276, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 16)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Telefono Domicilio"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(87, 19)
        Me.txtcodigo.MaxLength = 10
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(183, 20)
        Me.txtcodigo.TabIndex = 103
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "Cedula"
        '
        'txtcargo
        '
        Me.txtcargo.Location = New System.Drawing.Point(398, 105)
        Me.txtcargo.MaxLength = 50
        Me.txtcargo.Name = "txtcargo"
        Me.txtcargo.Size = New System.Drawing.Size(183, 20)
        Me.txtcargo.TabIndex = 101
        '
        'lbllogin
        '
        Me.lbllogin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogin.Location = New System.Drawing.Point(276, 107)
        Me.lbllogin.Name = "lbllogin"
        Me.lbllogin.Size = New System.Drawing.Size(80, 20)
        Me.lbllogin.TabIndex = 10
        Me.lbllogin.Text = "Cargo"
        '
        'txtpais
        '
        Me.txtpais.Location = New System.Drawing.Point(87, 133)
        Me.txtpais.MaxLength = 50
        Me.txtpais.Name = "txtpais"
        Me.txtpais.Size = New System.Drawing.Size(183, 20)
        Me.txtpais.TabIndex = 9
        '
        'lblusuariowindows
        '
        Me.lblusuariowindows.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuariowindows.Location = New System.Drawing.Point(6, 135)
        Me.lblusuariowindows.Name = "lblusuariowindows"
        Me.lblusuariowindows.Size = New System.Drawing.Size(75, 15)
        Me.lblusuariowindows.TabIndex = 6
        Me.lblusuariowindows.Text = "Pais"
        '
        'txtciudad
        '
        Me.txtciudad.Location = New System.Drawing.Point(87, 107)
        Me.txtciudad.MaxLength = 50
        Me.txtciudad.Name = "txtciudad"
        Me.txtciudad.Size = New System.Drawing.Size(183, 20)
        Me.txtciudad.TabIndex = 8
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(87, 78)
        Me.txtdireccion.MaxLength = 50
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(183, 20)
        Me.txtdireccion.TabIndex = 7
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(87, 50)
        Me.txtnombre.MaxLength = 50
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(183, 20)
        Me.txtnombre.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ciudad"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Direccion"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'frm_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 347)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Proveedores"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lvsproveedores As System.Windows.Forms.ListView
    Friend WithEvents lsvcedula As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvnombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvapellido As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents borrar As System.Windows.Forms.Button
    Friend WithEvents nuevo As System.Windows.Forms.Button
    Friend WithEvents modificar As System.Windows.Forms.Button
    Friend WithEvents aceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcargo As System.Windows.Forms.TextBox
    Friend WithEvents lbllogin As System.Windows.Forms.Label
    Friend WithEvents txtpais As System.Windows.Forms.TextBox
    Friend WithEvents lblusuariowindows As System.Windows.Forms.Label
    Friend WithEvents txtciudad As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtfono2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtfono1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtactividad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaimportante As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Cmbpago As System.Windows.Forms.ComboBox
    Friend WithEvents salir As System.Windows.Forms.Button
End Class
