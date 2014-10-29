<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrocampaña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registrocampaña))
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.cmbtipocta = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txboficialtarjeta = New System.Windows.Forms.TextBox
        Me.txbtarjetacliente = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtestadopago = New System.Windows.Forms.TextBox
        Me.cmbestadopago = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpfechapago = New System.Windows.Forms.DateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txbformapago = New System.Windows.Forms.TextBox
        Me.txtfechapagovcdo = New System.Windows.Forms.TextBox
        Me.txbpagovencido = New System.Windows.Forms.TextBox
        Me.txbpagocontado = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.txbnombre = New System.Windows.Forms.TextBox
        Me.txbidcliente = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.tabdatos = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.grpdomicilio = New System.Windows.Forms.GroupBox
        Me.txbciudad = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtdireccioncasa = New System.Windows.Forms.TextBox
        Me.txtfdomi = New System.Windows.Forms.TextBox
        Me.txtf2domi = New System.Windows.Forms.TextBox
        Me.txtlocalidad = New System.Windows.Forms.TextBox
        Me.txtestadodomi = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.chkfechavolvercalldomi = New System.Windows.Forms.CheckBox
        Me.ctmhoravolvercalldomi = New System.Windows.Forms.DateTimePicker
        Me.dtmfechavolvercalldomi = New System.Windows.Forms.DateTimePicker
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtcomentariodomi = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.cmbestadodomi = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.grptrabajo = New System.Windows.Forms.GroupBox
        Me.txtciudadtrab = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.txtdirecciontrab = New System.Windows.Forms.TextBox
        Me.txtftrab = New System.Windows.Forms.TextBox
        Me.txtf2trab = New System.Windows.Forms.TextBox
        Me.txtlocaltrab = New System.Windows.Forms.TextBox
        Me.txtesttrab = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkfechacalltrab = New System.Windows.Forms.CheckBox
        Me.dtphoracalltrab = New System.Windows.Forms.DateTimePicker
        Me.dtpfechacalltrab = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtcomentariotrab = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbesttrab = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.grpparientes = New System.Windows.Forms.GroupBox
        Me.cmbestpariente2 = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtfpariente2 = New System.Windows.Forms.TextBox
        Me.txtfpariente1 = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtpariente2 = New System.Windows.Forms.TextBox
        Me.txtpariente1 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtcomentarioparientes = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.cmbestpariente1 = New System.Windows.Forms.ComboBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.dtgregcliente = New System.Windows.Forms.DataGridView
        Me.GroupBox2.SuspendLayout()
        Me.tabdatos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpdomicilio.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grptrabajo.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.grpparientes.SuspendLayout()
        CType(Me.dtgregcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnaceptar
        '
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.Location = New System.Drawing.Point(304, 496)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(87, 32)
        Me.btnaceptar.TabIndex = 11
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'cmbtipocta
        '
        Me.cmbtipocta.FormattingEnabled = True
        Me.cmbtipocta.Location = New System.Drawing.Point(304, 37)
        Me.cmbtipocta.Name = "cmbtipocta"
        Me.cmbtipocta.Size = New System.Drawing.Size(121, 21)
        Me.cmbtipocta.TabIndex = 117
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(239, 38)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 13)
        Me.Label22.TabIndex = 116
        Me.Label22.Text = "Tipo Cta."
        '
        'txboficialtarjeta
        '
        Me.txboficialtarjeta.BackColor = System.Drawing.Color.Linen
        Me.txboficialtarjeta.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txboficialtarjeta.Location = New System.Drawing.Point(558, 38)
        Me.txboficialtarjeta.Name = "txboficialtarjeta"
        Me.txboficialtarjeta.ReadOnly = True
        Me.txboficialtarjeta.Size = New System.Drawing.Size(119, 20)
        Me.txboficialtarjeta.TabIndex = 115
        Me.txboficialtarjeta.TabStop = False
        Me.txboficialtarjeta.Text = "   "
        '
        'txbtarjetacliente
        '
        Me.txbtarjetacliente.BackColor = System.Drawing.Color.Linen
        Me.txbtarjetacliente.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txbtarjetacliente.Location = New System.Drawing.Point(72, 38)
        Me.txbtarjetacliente.Name = "txbtarjetacliente"
        Me.txbtarjetacliente.ReadOnly = True
        Me.txbtarjetacliente.Size = New System.Drawing.Size(85, 20)
        Me.txbtarjetacliente.TabIndex = 114
        Me.txbtarjetacliente.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtestadopago)
        Me.GroupBox2.Controls.Add(Me.cmbestadopago)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtpfechapago)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txbformapago)
        Me.GroupBox2.Controls.Add(Me.txtfechapagovcdo)
        Me.GroupBox2.Controls.Add(Me.txbpagovencido)
        Me.GroupBox2.Controls.Add(Me.txbpagocontado)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(669, 102)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saldos"
        '
        'txtestadopago
        '
        Me.txtestadopago.BackColor = System.Drawing.Color.Linen
        Me.txtestadopago.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtestadopago.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtestadopago.Location = New System.Drawing.Point(326, 44)
        Me.txtestadopago.Name = "txtestadopago"
        Me.txtestadopago.ReadOnly = True
        Me.txtestadopago.Size = New System.Drawing.Size(266, 21)
        Me.txtestadopago.TabIndex = 112
        Me.txtestadopago.TabStop = False
        Me.txtestadopago.Text = "  "
        '
        'cmbestadopago
        '
        Me.cmbestadopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestadopago.FormattingEnabled = True
        Me.cmbestadopago.Location = New System.Drawing.Point(230, 44)
        Me.cmbestadopago.Name = "cmbestadopago"
        Me.cmbestadopago.Size = New System.Drawing.Size(83, 21)
        Me.cmbestadopago.TabIndex = 110
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(182, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Estado"
        '
        'dtpfechapago
        '
        Me.dtpfechapago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechapago.Location = New System.Drawing.Point(547, 14)
        Me.dtpfechapago.Name = "dtpfechapago"
        Me.dtpfechapago.Size = New System.Drawing.Size(90, 21)
        Me.dtpfechapago.TabIndex = 103
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "Deuda"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(462, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Fecha Actual"
        '
        'txbformapago
        '
        Me.txbformapago.BackColor = System.Drawing.Color.Linen
        Me.txbformapago.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txbformapago.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txbformapago.Location = New System.Drawing.Point(93, 72)
        Me.txbformapago.Name = "txbformapago"
        Me.txbformapago.ReadOnly = True
        Me.txbformapago.Size = New System.Drawing.Size(73, 21)
        Me.txbformapago.TabIndex = 101
        Me.txbformapago.TabStop = False
        '
        'txtfechapagovcdo
        '
        Me.txtfechapagovcdo.BackColor = System.Drawing.Color.Linen
        Me.txtfechapagovcdo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtfechapagovcdo.Location = New System.Drawing.Point(230, 14)
        Me.txtfechapagovcdo.Name = "txtfechapagovcdo"
        Me.txtfechapagovcdo.ReadOnly = True
        Me.txtfechapagovcdo.Size = New System.Drawing.Size(131, 21)
        Me.txtfechapagovcdo.TabIndex = 76
        Me.txtfechapagovcdo.TabStop = False
        Me.txtfechapagovcdo.Text = " "
        '
        'txbpagovencido
        '
        Me.txbpagovencido.BackColor = System.Drawing.Color.Linen
        Me.txbpagovencido.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txbpagovencido.Location = New System.Drawing.Point(93, 14)
        Me.txbpagovencido.Name = "txbpagovencido"
        Me.txbpagovencido.ReadOnly = True
        Me.txbpagovencido.Size = New System.Drawing.Size(73, 21)
        Me.txbpagovencido.TabIndex = 75
        Me.txbpagovencido.TabStop = False
        '
        'txbpagocontado
        '
        Me.txbpagocontado.BackColor = System.Drawing.Color.Linen
        Me.txbpagocontado.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txbpagocontado.Location = New System.Drawing.Point(93, 44)
        Me.txbpagocontado.Name = "txbpagocontado"
        Me.txbpagocontado.ReadOnly = True
        Me.txbpagocontado.Size = New System.Drawing.Size(73, 21)
        Me.txbpagocontado.TabIndex = 74
        Me.txbpagocontado.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 13)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Pago Contado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(184, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Fecha"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Ultimo Pago"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(465, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 112
        Me.Label13.Text = "Oficial Tarjeta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 111
        Me.Label12.Text = "Num. Cta."
        '
        'btnbuscar
        '
        Me.btnbuscar.Image = CType(resources.GetObject("btnbuscar.Image"), System.Drawing.Image)
        Me.btnbuscar.Location = New System.Drawing.Point(163, 9)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(31, 23)
        Me.btnbuscar.TabIndex = 110
        Me.btnbuscar.UseVisualStyleBackColor = True
        Me.btnbuscar.Visible = False
        '
        'txbnombre
        '
        Me.txbnombre.BackColor = System.Drawing.Color.Linen
        Me.txbnombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbnombre.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txbnombre.Location = New System.Drawing.Point(304, 11)
        Me.txbnombre.Name = "txbnombre"
        Me.txbnombre.ReadOnly = True
        Me.txbnombre.Size = New System.Drawing.Size(250, 21)
        Me.txbnombre.TabIndex = 108
        Me.txbnombre.TabStop = False
        Me.txbnombre.Text = "  "
        '
        'txbidcliente
        '
        Me.txbidcliente.BackColor = System.Drawing.Color.Linen
        Me.txbidcliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbidcliente.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txbidcliente.Location = New System.Drawing.Point(72, 11)
        Me.txbidcliente.Name = "txbidcliente"
        Me.txbidcliente.ReadOnly = True
        Me.txbidcliente.Size = New System.Drawing.Size(85, 21)
        Me.txbidcliente.TabIndex = 107
        Me.txbidcliente.TabStop = False
        Me.txbidcliente.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Id Cliente"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(196, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 23)
        Me.Button1.TabIndex = 119
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'tabdatos
        '
        Me.tabdatos.Controls.Add(Me.TabPage1)
        Me.tabdatos.Controls.Add(Me.TabPage2)
        Me.tabdatos.Controls.Add(Me.TabPage3)
        Me.tabdatos.Location = New System.Drawing.Point(12, 172)
        Me.tabdatos.Name = "tabdatos"
        Me.tabdatos.SelectedIndex = 0
        Me.tabdatos.Size = New System.Drawing.Size(668, 205)
        Me.tabdatos.TabIndex = 120
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grpdomicilio)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(660, 179)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Domicilio"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grpdomicilio
        '
        Me.grpdomicilio.Controls.Add(Me.txbciudad)
        Me.grpdomicilio.Controls.Add(Me.Label9)
        Me.grpdomicilio.Controls.Add(Me.txtdireccioncasa)
        Me.grpdomicilio.Controls.Add(Me.txtfdomi)
        Me.grpdomicilio.Controls.Add(Me.txtf2domi)
        Me.grpdomicilio.Controls.Add(Me.txtlocalidad)
        Me.grpdomicilio.Controls.Add(Me.txtestadodomi)
        Me.grpdomicilio.Controls.Add(Me.Label20)
        Me.grpdomicilio.Controls.Add(Me.Label23)
        Me.grpdomicilio.Controls.Add(Me.chkfechavolvercalldomi)
        Me.grpdomicilio.Controls.Add(Me.ctmhoravolvercalldomi)
        Me.grpdomicilio.Controls.Add(Me.dtmfechavolvercalldomi)
        Me.grpdomicilio.Controls.Add(Me.Label25)
        Me.grpdomicilio.Controls.Add(Me.txtcomentariodomi)
        Me.grpdomicilio.Controls.Add(Me.Label26)
        Me.grpdomicilio.Controls.Add(Me.cmbestadodomi)
        Me.grpdomicilio.Controls.Add(Me.Label27)
        Me.grpdomicilio.Controls.Add(Me.Label28)
        Me.grpdomicilio.Controls.Add(Me.Label29)
        Me.grpdomicilio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpdomicilio.Location = New System.Drawing.Point(3, 6)
        Me.grpdomicilio.Name = "grpdomicilio"
        Me.grpdomicilio.Size = New System.Drawing.Size(651, 150)
        Me.grpdomicilio.TabIndex = 119
        Me.grpdomicilio.TabStop = False
        Me.grpdomicilio.Text = "Datos Domicilio"
        '
        'txbciudad
        '
        Me.txbciudad.BackColor = System.Drawing.Color.Linen
        Me.txbciudad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbciudad.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txbciudad.Location = New System.Drawing.Point(539, 69)
        Me.txbciudad.Name = "txbciudad"
        Me.txbciudad.ReadOnly = True
        Me.txbciudad.Size = New System.Drawing.Size(106, 21)
        Me.txbciudad.TabIndex = 120
        Me.txbciudad.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(487, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Ciudad"
        '
        'txtdireccioncasa
        '
        Me.txtdireccioncasa.BackColor = System.Drawing.Color.Linen
        Me.txtdireccioncasa.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtdireccioncasa.Location = New System.Drawing.Point(279, 16)
        Me.txtdireccioncasa.Name = "txtdireccioncasa"
        Me.txtdireccioncasa.ReadOnly = True
        Me.txtdireccioncasa.Size = New System.Drawing.Size(366, 21)
        Me.txtdireccioncasa.TabIndex = 118
        Me.txtdireccioncasa.TabStop = False
        '
        'txtfdomi
        '
        Me.txtfdomi.BackColor = System.Drawing.Color.Linen
        Me.txtfdomi.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtfdomi.Location = New System.Drawing.Point(71, 46)
        Me.txtfdomi.Name = "txtfdomi"
        Me.txtfdomi.ReadOnly = True
        Me.txtfdomi.Size = New System.Drawing.Size(98, 21)
        Me.txtfdomi.TabIndex = 117
        Me.txtfdomi.TabStop = False
        '
        'txtf2domi
        '
        Me.txtf2domi.BackColor = System.Drawing.Color.Linen
        Me.txtf2domi.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtf2domi.Location = New System.Drawing.Point(71, 72)
        Me.txtf2domi.Name = "txtf2domi"
        Me.txtf2domi.ReadOnly = True
        Me.txtf2domi.Size = New System.Drawing.Size(98, 21)
        Me.txtf2domi.TabIndex = 116
        Me.txtf2domi.TabStop = False
        '
        'txtlocalidad
        '
        Me.txtlocalidad.BackColor = System.Drawing.Color.Linen
        Me.txtlocalidad.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtlocalidad.Location = New System.Drawing.Point(71, 19)
        Me.txtlocalidad.Name = "txtlocalidad"
        Me.txtlocalidad.ReadOnly = True
        Me.txtlocalidad.Size = New System.Drawing.Size(131, 21)
        Me.txtlocalidad.TabIndex = 115
        Me.txtlocalidad.TabStop = False
        '
        'txtestadodomi
        '
        Me.txtestadodomi.BackColor = System.Drawing.Color.Linen
        Me.txtestadodomi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtestadodomi.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtestadodomi.Location = New System.Drawing.Point(336, 69)
        Me.txtestadodomi.Name = "txtestadodomi"
        Me.txtestadodomi.ReadOnly = True
        Me.txtestadodomi.Size = New System.Drawing.Size(145, 21)
        Me.txtestadodomi.TabIndex = 109
        Me.txtestadodomi.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(10, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 13)
        Me.Label20.TabIndex = 102
        Me.Label20.Text = "Localidad"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(10, 72)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 13)
        Me.Label23.TabIndex = 100
        Me.Label23.Text = "Fono 2"
        '
        'chkfechavolvercalldomi
        '
        Me.chkfechavolvercalldomi.AutoSize = True
        Me.chkfechavolvercalldomi.Enabled = False
        Me.chkfechavolvercalldomi.Location = New System.Drawing.Point(245, 45)
        Me.chkfechavolvercalldomi.Name = "chkfechavolvercalldomi"
        Me.chkfechavolvercalldomi.Size = New System.Drawing.Size(15, 14)
        Me.chkfechavolvercalldomi.TabIndex = 97
        Me.chkfechavolvercalldomi.UseVisualStyleBackColor = True
        '
        'ctmhoravolvercalldomi
        '
        Me.ctmhoravolvercalldomi.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.ctmhoravolvercalldomi.Location = New System.Drawing.Point(464, 41)
        Me.ctmhoravolvercalldomi.Name = "ctmhoravolvercalldomi"
        Me.ctmhoravolvercalldomi.ShowUpDown = True
        Me.ctmhoravolvercalldomi.Size = New System.Drawing.Size(71, 21)
        Me.ctmhoravolvercalldomi.TabIndex = 93
        '
        'dtmfechavolvercalldomi
        '
        Me.dtmfechavolvercalldomi.CustomFormat = ""
        Me.dtmfechavolvercalldomi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmfechavolvercalldomi.Location = New System.Drawing.Point(365, 41)
        Me.dtmfechavolvercalldomi.Name = "dtmfechavolvercalldomi"
        Me.dtmfechavolvercalldomi.Size = New System.Drawing.Size(93, 21)
        Me.dtmfechavolvercalldomi.TabIndex = 92
        Me.dtmfechavolvercalldomi.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(266, 45)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(93, 13)
        Me.Label25.TabIndex = 91
        Me.Label25.Text = "Fecha Call Back"
        '
        'txtcomentariodomi
        '
        Me.txtcomentariodomi.Location = New System.Drawing.Point(71, 109)
        Me.txtcomentariodomi.Multiline = True
        Me.txtcomentariodomi.Name = "txtcomentariodomi"
        Me.txtcomentariodomi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtcomentariodomi.Size = New System.Drawing.Size(574, 33)
        Me.txtcomentariodomi.TabIndex = 6
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(10, 93)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(73, 13)
        Me.Label26.TabIndex = 88
        Me.Label26.Text = "Comentario"
        '
        'cmbestadodomi
        '
        Me.cmbestadodomi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestadodomi.FormattingEnabled = True
        Me.cmbestadodomi.Location = New System.Drawing.Point(272, 69)
        Me.cmbestadodomi.Name = "cmbestadodomi"
        Me.cmbestadodomi.Size = New System.Drawing.Size(58, 21)
        Me.cmbestadodomi.TabIndex = 4
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(223, 72)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(45, 13)
        Me.Label27.TabIndex = 85
        Me.Label27.Text = "Estado"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(219, 19)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 13)
        Me.Label28.TabIndex = 50
        Me.Label28.Text = " Direccion "
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(10, 45)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 13)
        Me.Label29.TabIndex = 51
        Me.Label29.Text = "Fono 1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grptrabajo)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(660, 179)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Trabajo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grptrabajo
        '
        Me.grptrabajo.Controls.Add(Me.txtciudadtrab)
        Me.grptrabajo.Controls.Add(Me.Label34)
        Me.grptrabajo.Controls.Add(Me.txtdirecciontrab)
        Me.grptrabajo.Controls.Add(Me.txtftrab)
        Me.grptrabajo.Controls.Add(Me.txtf2trab)
        Me.grptrabajo.Controls.Add(Me.txtlocaltrab)
        Me.grptrabajo.Controls.Add(Me.txtesttrab)
        Me.grptrabajo.Controls.Add(Me.Label4)
        Me.grptrabajo.Controls.Add(Me.Label5)
        Me.grptrabajo.Controls.Add(Me.chkfechacalltrab)
        Me.grptrabajo.Controls.Add(Me.dtphoracalltrab)
        Me.grptrabajo.Controls.Add(Me.dtpfechacalltrab)
        Me.grptrabajo.Controls.Add(Me.Label7)
        Me.grptrabajo.Controls.Add(Me.txtcomentariotrab)
        Me.grptrabajo.Controls.Add(Me.Label11)
        Me.grptrabajo.Controls.Add(Me.cmbesttrab)
        Me.grptrabajo.Controls.Add(Me.Label16)
        Me.grptrabajo.Controls.Add(Me.Label17)
        Me.grptrabajo.Controls.Add(Me.Label18)
        Me.grptrabajo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grptrabajo.Location = New System.Drawing.Point(3, 6)
        Me.grptrabajo.Name = "grptrabajo"
        Me.grptrabajo.Size = New System.Drawing.Size(654, 150)
        Me.grptrabajo.TabIndex = 120
        Me.grptrabajo.TabStop = False
        Me.grptrabajo.Text = "Datos Trabajo"
        '
        'txtciudadtrab
        '
        Me.txtciudadtrab.BackColor = System.Drawing.Color.Linen
        Me.txtciudadtrab.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtciudadtrab.Location = New System.Drawing.Point(539, 69)
        Me.txtciudadtrab.Name = "txtciudadtrab"
        Me.txtciudadtrab.ReadOnly = True
        Me.txtciudadtrab.Size = New System.Drawing.Size(107, 21)
        Me.txtciudadtrab.TabIndex = 120
        Me.txtciudadtrab.TabStop = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(488, 72)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(45, 13)
        Me.Label34.TabIndex = 119
        Me.Label34.Text = "Ciudad"
        '
        'txtdirecciontrab
        '
        Me.txtdirecciontrab.BackColor = System.Drawing.Color.Linen
        Me.txtdirecciontrab.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtdirecciontrab.Location = New System.Drawing.Point(279, 16)
        Me.txtdirecciontrab.Name = "txtdirecciontrab"
        Me.txtdirecciontrab.ReadOnly = True
        Me.txtdirecciontrab.Size = New System.Drawing.Size(367, 21)
        Me.txtdirecciontrab.TabIndex = 118
        Me.txtdirecciontrab.TabStop = False
        '
        'txtftrab
        '
        Me.txtftrab.BackColor = System.Drawing.Color.Linen
        Me.txtftrab.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtftrab.Location = New System.Drawing.Point(71, 46)
        Me.txtftrab.Name = "txtftrab"
        Me.txtftrab.ReadOnly = True
        Me.txtftrab.Size = New System.Drawing.Size(98, 21)
        Me.txtftrab.TabIndex = 117
        Me.txtftrab.TabStop = False
        '
        'txtf2trab
        '
        Me.txtf2trab.BackColor = System.Drawing.Color.Linen
        Me.txtf2trab.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtf2trab.Location = New System.Drawing.Point(71, 72)
        Me.txtf2trab.Name = "txtf2trab"
        Me.txtf2trab.ReadOnly = True
        Me.txtf2trab.Size = New System.Drawing.Size(98, 21)
        Me.txtf2trab.TabIndex = 116
        Me.txtf2trab.TabStop = False
        '
        'txtlocaltrab
        '
        Me.txtlocaltrab.BackColor = System.Drawing.Color.Linen
        Me.txtlocaltrab.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtlocaltrab.Location = New System.Drawing.Point(71, 19)
        Me.txtlocaltrab.Name = "txtlocaltrab"
        Me.txtlocaltrab.ReadOnly = True
        Me.txtlocaltrab.Size = New System.Drawing.Size(130, 21)
        Me.txtlocaltrab.TabIndex = 115
        Me.txtlocaltrab.TabStop = False
        '
        'txtesttrab
        '
        Me.txtesttrab.BackColor = System.Drawing.Color.Linen
        Me.txtesttrab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtesttrab.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtesttrab.Location = New System.Drawing.Point(336, 69)
        Me.txtesttrab.Name = "txtesttrab"
        Me.txtesttrab.ReadOnly = True
        Me.txtesttrab.Size = New System.Drawing.Size(139, 21)
        Me.txtesttrab.TabIndex = 109
        Me.txtesttrab.TabStop = False
        Me.txtesttrab.Text = "  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Localidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Fono 2"
        '
        'chkfechacalltrab
        '
        Me.chkfechacalltrab.AutoSize = True
        Me.chkfechacalltrab.Enabled = False
        Me.chkfechacalltrab.Location = New System.Drawing.Point(246, 45)
        Me.chkfechacalltrab.Name = "chkfechacalltrab"
        Me.chkfechacalltrab.Size = New System.Drawing.Size(15, 14)
        Me.chkfechacalltrab.TabIndex = 97
        Me.chkfechacalltrab.UseVisualStyleBackColor = True
        '
        'dtphoracalltrab
        '
        Me.dtphoracalltrab.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtphoracalltrab.Location = New System.Drawing.Point(465, 41)
        Me.dtphoracalltrab.Name = "dtphoracalltrab"
        Me.dtphoracalltrab.ShowUpDown = True
        Me.dtphoracalltrab.Size = New System.Drawing.Size(71, 21)
        Me.dtphoracalltrab.TabIndex = 93
        '
        'dtpfechacalltrab
        '
        Me.dtpfechacalltrab.CustomFormat = ""
        Me.dtpfechacalltrab.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechacalltrab.Location = New System.Drawing.Point(366, 41)
        Me.dtpfechacalltrab.Name = "dtpfechacalltrab"
        Me.dtpfechacalltrab.Size = New System.Drawing.Size(93, 21)
        Me.dtpfechacalltrab.TabIndex = 92
        Me.dtpfechacalltrab.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(267, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Fecha Call Back"
        '
        'txtcomentariotrab
        '
        Me.txtcomentariotrab.Location = New System.Drawing.Point(71, 109)
        Me.txtcomentariotrab.Multiline = True
        Me.txtcomentariotrab.Name = "txtcomentariotrab"
        Me.txtcomentariotrab.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtcomentariotrab.Size = New System.Drawing.Size(575, 33)
        Me.txtcomentariotrab.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Comentario"
        '
        'cmbesttrab
        '
        Me.cmbesttrab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbesttrab.FormattingEnabled = True
        Me.cmbesttrab.Location = New System.Drawing.Point(271, 69)
        Me.cmbesttrab.Name = "cmbesttrab"
        Me.cmbesttrab.Size = New System.Drawing.Size(59, 21)
        Me.cmbesttrab.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(220, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 85
        Me.Label16.Text = "Estado"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(217, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = " Direccion "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 45)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "Fono 1"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.grpparientes)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(660, 179)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Parientes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'grpparientes
        '
        Me.grpparientes.Controls.Add(Me.cmbestpariente2)
        Me.grpparientes.Controls.Add(Me.Label21)
        Me.grpparientes.Controls.Add(Me.Label36)
        Me.grpparientes.Controls.Add(Me.txtfpariente2)
        Me.grpparientes.Controls.Add(Me.txtfpariente1)
        Me.grpparientes.Controls.Add(Me.Label24)
        Me.grpparientes.Controls.Add(Me.Label32)
        Me.grpparientes.Controls.Add(Me.txtpariente2)
        Me.grpparientes.Controls.Add(Me.txtpariente1)
        Me.grpparientes.Controls.Add(Me.Label19)
        Me.grpparientes.Controls.Add(Me.txtcomentarioparientes)
        Me.grpparientes.Controls.Add(Me.Label30)
        Me.grpparientes.Controls.Add(Me.cmbestpariente1)
        Me.grpparientes.Controls.Add(Me.Label31)
        Me.grpparientes.Controls.Add(Me.Label33)
        Me.grpparientes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpparientes.Location = New System.Drawing.Point(3, 6)
        Me.grpparientes.Name = "grpparientes"
        Me.grpparientes.Size = New System.Drawing.Size(655, 150)
        Me.grpparientes.TabIndex = 120
        Me.grpparientes.TabStop = False
        Me.grpparientes.Text = "Datos Parientes"
        '
        'cmbestpariente2
        '
        Me.cmbestpariente2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestpariente2.FormattingEnabled = True
        Me.cmbestpariente2.Location = New System.Drawing.Point(431, 46)
        Me.cmbestpariente2.Name = "cmbestpariente2"
        Me.cmbestpariente2.Size = New System.Drawing.Size(59, 21)
        Me.cmbestpariente2.TabIndex = 128
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(380, 49)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 129
        Me.Label21.Text = "Estado"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(493, 22)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(34, 13)
        Me.Label36.TabIndex = 127
        Me.Label36.Text = "Fono"
        '
        'txtfpariente2
        '
        Me.txtfpariente2.BackColor = System.Drawing.Color.Linen
        Me.txtfpariente2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtfpariente2.Location = New System.Drawing.Point(534, 46)
        Me.txtfpariente2.Name = "txtfpariente2"
        Me.txtfpariente2.ReadOnly = True
        Me.txtfpariente2.Size = New System.Drawing.Size(115, 21)
        Me.txtfpariente2.TabIndex = 126
        Me.txtfpariente2.TabStop = False
        '
        'txtfpariente1
        '
        Me.txtfpariente1.BackColor = System.Drawing.Color.Linen
        Me.txtfpariente1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtfpariente1.Location = New System.Drawing.Point(534, 19)
        Me.txtfpariente1.Name = "txtfpariente1"
        Me.txtfpariente1.ReadOnly = True
        Me.txtfpariente1.Size = New System.Drawing.Size(115, 21)
        Me.txtfpariente1.TabIndex = 125
        Me.txtfpariente1.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(266, 22)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 13)
        Me.Label24.TabIndex = 124
        Me.Label24.Text = "  "
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(495, 49)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(34, 13)
        Me.Label32.TabIndex = 123
        Me.Label32.Text = "Fono"
        '
        'txtpariente2
        '
        Me.txtpariente2.BackColor = System.Drawing.Color.Linen
        Me.txtpariente2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtpariente2.Location = New System.Drawing.Point(79, 46)
        Me.txtpariente2.Name = "txtpariente2"
        Me.txtpariente2.ReadOnly = True
        Me.txtpariente2.Size = New System.Drawing.Size(295, 21)
        Me.txtpariente2.TabIndex = 117
        Me.txtpariente2.TabStop = False
        '
        'txtpariente1
        '
        Me.txtpariente1.BackColor = System.Drawing.Color.Linen
        Me.txtpariente1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtpariente1.Location = New System.Drawing.Point(79, 19)
        Me.txtpariente1.Name = "txtpariente1"
        Me.txtpariente1.ReadOnly = True
        Me.txtpariente1.Size = New System.Drawing.Size(295, 21)
        Me.txtpariente1.TabIndex = 115
        Me.txtpariente1.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(10, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 13)
        Me.Label19.TabIndex = 102
        Me.Label19.Text = "Pariente 1"
        '
        'txtcomentarioparientes
        '
        Me.txtcomentarioparientes.Location = New System.Drawing.Point(85, 76)
        Me.txtcomentarioparientes.Multiline = True
        Me.txtcomentarioparientes.Name = "txtcomentarioparientes"
        Me.txtcomentarioparientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtcomentarioparientes.Size = New System.Drawing.Size(564, 49)
        Me.txtcomentarioparientes.TabIndex = 6
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(10, 76)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(73, 13)
        Me.Label30.TabIndex = 88
        Me.Label30.Text = "Comentario"
        '
        'cmbestpariente1
        '
        Me.cmbestpariente1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestpariente1.FormattingEnabled = True
        Me.cmbestpariente1.Location = New System.Drawing.Point(431, 19)
        Me.cmbestpariente1.Name = "cmbestpariente1"
        Me.cmbestpariente1.Size = New System.Drawing.Size(59, 21)
        Me.cmbestpariente1.TabIndex = 4
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(380, 22)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(45, 13)
        Me.Label31.TabIndex = 85
        Me.Label31.Text = "Estado"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(10, 49)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(65, 13)
        Me.Label33.TabIndex = 51
        Me.Label33.Text = "Pariente 2"
        '
        'dtgregcliente
        '
        Me.dtgregcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgregcliente.Location = New System.Drawing.Point(12, 379)
        Me.dtgregcliente.Name = "dtgregcliente"
        Me.dtgregcliente.ReadOnly = True
        Me.dtgregcliente.Size = New System.Drawing.Size(664, 111)
        Me.dtgregcliente.TabIndex = 121
        '
        'frm_registrocampaña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 529)
        Me.Controls.Add(Me.dtgregcliente)
        Me.Controls.Add(Me.tabdatos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbtipocta)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txboficialtarjeta)
        Me.Controls.Add(Me.txbtarjetacliente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txbnombre)
        Me.Controls.Add(Me.txbidcliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnaceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 71)
        Me.MaximizeBox = False
        Me.Name = "frm_registrocampaña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Campaña Cobranzas De Praty"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabdatos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.grpdomicilio.ResumeLayout(False)
        Me.grpdomicilio.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.grptrabajo.ResumeLayout(False)
        Me.grptrabajo.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.grpparientes.ResumeLayout(False)
        Me.grpparientes.PerformLayout()
        CType(Me.dtgregcliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents cmbtipocta As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txboficialtarjeta As System.Windows.Forms.TextBox
    Friend WithEvents txbtarjetacliente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfechapago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txbformapago As System.Windows.Forms.TextBox
    Friend WithEvents txbpagovencido As System.Windows.Forms.TextBox
    Friend WithEvents txbpagocontado As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents txbnombre As System.Windows.Forms.TextBox
    Friend WithEvents txbidcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfechapagovcdo As System.Windows.Forms.TextBox
    Friend WithEvents txtestadopago As System.Windows.Forms.TextBox
    Friend WithEvents cmbestadopago As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tabdatos As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents grpdomicilio As System.Windows.Forms.GroupBox
    Friend WithEvents txtdireccioncasa As System.Windows.Forms.TextBox
    Friend WithEvents txtfdomi As System.Windows.Forms.TextBox
    Friend WithEvents txtf2domi As System.Windows.Forms.TextBox
    Friend WithEvents txtlocalidad As System.Windows.Forms.TextBox
    Friend WithEvents txtestadodomi As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents chkfechavolvercalldomi As System.Windows.Forms.CheckBox
    Friend WithEvents ctmhoravolvercalldomi As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtmfechavolvercalldomi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtcomentariodomi As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cmbestadodomi As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grptrabajo As System.Windows.Forms.GroupBox
    Friend WithEvents txtdirecciontrab As System.Windows.Forms.TextBox
    Friend WithEvents txtftrab As System.Windows.Forms.TextBox
    Friend WithEvents txtf2trab As System.Windows.Forms.TextBox
    Friend WithEvents txtlocaltrab As System.Windows.Forms.TextBox
    Friend WithEvents txtesttrab As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkfechacalltrab As System.Windows.Forms.CheckBox
    Friend WithEvents dtphoracalltrab As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechacalltrab As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcomentariotrab As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbesttrab As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents grpparientes As System.Windows.Forms.GroupBox
    Friend WithEvents txtpariente2 As System.Windows.Forms.TextBox
    Friend WithEvents txtpariente1 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtcomentarioparientes As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cmbestpariente1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtciudadtrab As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtfpariente2 As System.Windows.Forms.TextBox
    Friend WithEvents txtfpariente1 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents cmbestpariente2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txbciudad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtgregcliente As System.Windows.Forms.DataGridView
End Class
