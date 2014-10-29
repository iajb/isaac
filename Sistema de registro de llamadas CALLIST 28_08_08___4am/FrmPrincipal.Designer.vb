<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmPrincipal
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
	End Sub
	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EncriptacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ArchivosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SistemasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AuditoríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambiarContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SistemasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.CambiarContraseñaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProovedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BancosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaDeBancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistraInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuariosDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VendedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.stbarra = New System.Windows.Forms.StatusStrip
        Me.stnombre = New System.Windows.Forms.ToolStripStatusLabel
        Me.sthora = New System.Windows.Forms.ToolStripStatusLabel
        Me.stcumplecli = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlssalir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tlsusuario = New System.Windows.Forms.ToolStripButton
        Me.tlsmclientes = New System.Windows.Forms.ToolStripButton
        Me.tlsmproveedores = New System.Windows.Forms.ToolStripButton
        Me.tlsmvendedores = New System.Windows.Forms.ToolStripButton
        Me.tlsbbancos = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tlsregcob = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tlsdreportes = New System.Windows.Forms.ToolStripDropDownButton
        Me.tlsusers = New System.Windows.Forms.ToolStripMenuItem
        Me.tlsrclientes = New System.Windows.Forms.ToolStripMenuItem
        Me.tlsrproveedores = New System.Windows.Forms.ToolStripMenuItem
        Me.tlsrvendedores = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tlsayuda = New System.Windows.Forms.ToolStripButton
        Me.MainMenu1.SuspendLayout()
        Me.stbarra.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ArchivosToolStripMenuItem
        '
        Me.ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ArchivosToolStripMenuItem.Text = "&Desencriptar"
        '
        'EncriptacionesToolStripMenuItem
        '
        Me.EncriptacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrosToolStripMenuItem, Me.ArchivosToolStripMenuItem1})
        Me.EncriptacionesToolStripMenuItem.Name = "EncriptacionesToolStripMenuItem"
        Me.EncriptacionesToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.EncriptacionesToolStripMenuItem.Text = "&Encriptaciones"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.RegistrosToolStripMenuItem.Text = "Registros"
        '
        'ArchivosToolStripMenuItem1
        '
        Me.ArchivosToolStripMenuItem1.Name = "ArchivosToolStripMenuItem1"
        Me.ArchivosToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.ArchivosToolStripMenuItem1.Text = "Archivos"
        '
        'SistemasToolStripMenuItem
        '
        Me.SistemasToolStripMenuItem.Name = "SistemasToolStripMenuItem"
        Me.SistemasToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SistemasToolStripMenuItem.Text = "&Sistemas"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsuarioToolStripMenuItem.Text = "&Usuario"
        '
        'NuevioToolStripMenuItem
        '
        Me.NuevioToolStripMenuItem.Name = "NuevioToolStripMenuItem"
        Me.NuevioToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.NuevioToolStripMenuItem.Text = "Nuevo"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'AuditoríaToolStripMenuItem
        '
        Me.AuditoríaToolStripMenuItem.Name = "AuditoríaToolStripMenuItem"
        Me.AuditoríaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AuditoríaToolStripMenuItem.Text = "Auditoría"
        '
        'CambiarContraseñaToolStripMenuItem
        '
        Me.CambiarContraseñaToolStripMenuItem.Name = "CambiarContraseñaToolStripMenuItem"
        Me.CambiarContraseñaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AyudaToolStripMenuItem.Text = "A&yuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.SistemasToolStripMenuItem1, Me.ToolStripMenuItem4, Me.ToolStripMenuItem2, Me.AyudaToolStripMenuItem1})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(653, 24)
        Me.MainMenu1.TabIndex = 10
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.SalirToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(55, 20)
        Me.ToolStripMenuItem1.Text = "&Archivo"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem3.Text = "&Desencriptar password"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'SistemasToolStripMenuItem1
        '
        Me.SistemasToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem1, Me.VendedoresToolStripMenuItem, Me.ProovedoresToolStripMenuItem, Me.BancosToolStripMenuItem})
        Me.SistemasToolStripMenuItem1.Name = "SistemasToolStripMenuItem1"
        Me.SistemasToolStripMenuItem1.Size = New System.Drawing.Size(94, 20)
        Me.SistemasToolStripMenuItem1.Text = "&Mantenimientos"
        '
        'UsuarioToolStripMenuItem1
        '
        Me.UsuarioToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ToolStripMenuItem5, Me.CambiarContraseñaToolStripMenuItem1})
        Me.UsuarioToolStripMenuItem1.Name = "UsuarioToolStripMenuItem1"
        Me.UsuarioToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.UsuarioToolStripMenuItem1.Text = "Usuario/Clientes"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.NuevoToolStripMenuItem.Text = "&Clientes"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem5.Text = "&Usuarios"
        '
        'CambiarContraseñaToolStripMenuItem1
        '
        Me.CambiarContraseñaToolStripMenuItem1.Name = "CambiarContraseñaToolStripMenuItem1"
        Me.CambiarContraseñaToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.CambiarContraseñaToolStripMenuItem1.Text = "&Cambiar contraseña"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.VendedoresToolStripMenuItem.Text = "Operadores"
        '
        'ProovedoresToolStripMenuItem
        '
        Me.ProovedoresToolStripMenuItem.Name = "ProovedoresToolStripMenuItem"
        Me.ProovedoresToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ProovedoresToolStripMenuItem.Text = "Proveedores"
        '
        'BancosToolStripMenuItem
        '
        Me.BancosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BancosToolStripMenuItem1, Me.ConsultaDeBancosToolStripMenuItem})
        Me.BancosToolStripMenuItem.Name = "BancosToolStripMenuItem"
        Me.BancosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.BancosToolStripMenuItem.Text = "Entidades Bancarias"
        '
        'BancosToolStripMenuItem1
        '
        Me.BancosToolStripMenuItem1.Name = "BancosToolStripMenuItem1"
        Me.BancosToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.BancosToolStripMenuItem1.Text = "Bancos"
        '
        'ConsultaDeBancosToolStripMenuItem
        '
        Me.ConsultaDeBancosToolStripMenuItem.Name = "ConsultaDeBancosToolStripMenuItem"
        Me.ConsultaDeBancosToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ConsultaDeBancosToolStripMenuItem.Text = "Consulta de bancos"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistraInventarioToolStripMenuItem})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(57, 20)
        Me.ToolStripMenuItem4.Text = "&Proceso"
        '
        'RegistraInventarioToolStripMenuItem
        '
        Me.RegistraInventarioToolStripMenuItem.Name = "RegistraInventarioToolStripMenuItem"
        Me.RegistraInventarioToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.RegistraInventarioToolStripMenuItem.Text = "&Registra Cobranzas"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosDelSistemaToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.VendedoresToolStripMenuItem1})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(109, 20)
        Me.ToolStripMenuItem2.Text = "&Consulta/Reportes"
        '
        'UsuariosDelSistemaToolStripMenuItem
        '
        Me.UsuariosDelSistemaToolStripMenuItem.Name = "UsuariosDelSistemaToolStripMenuItem"
        Me.UsuariosDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.UsuariosDelSistemaToolStripMenuItem.Text = "&Usuarios "
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ClientesToolStripMenuItem.Text = "&Clientes"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ProveedoresToolStripMenuItem.Text = "&Proveedores"
        '
        'VendedoresToolStripMenuItem1
        '
        Me.VendedoresToolStripMenuItem1.Name = "VendedoresToolStripMenuItem1"
        Me.VendedoresToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.VendedoresToolStripMenuItem1.Text = "&Vendedores"
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem1})
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.AyudaToolStripMenuItem1.Text = "&Ayuda"
        '
        'AcercaDeToolStripMenuItem1
        '
        Me.AcercaDeToolStripMenuItem1.Name = "AcercaDeToolStripMenuItem1"
        Me.AcercaDeToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.AcercaDeToolStripMenuItem1.Text = "Acerca de"
        '
        'stbarra
        '
        Me.stbarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stnombre, Me.sthora, Me.stcumplecli})
        Me.stbarra.Location = New System.Drawing.Point(0, 646)
        Me.stbarra.Name = "stbarra"
        Me.stbarra.Size = New System.Drawing.Size(653, 22)
        Me.stbarra.TabIndex = 12
        Me.stbarra.Text = "StatusStrip1"
        '
        'stnombre
        '
        Me.stnombre.Name = "stnombre"
        Me.stnombre.Size = New System.Drawing.Size(0, 17)
        '
        'sthora
        '
        Me.sthora.Name = "sthora"
        Me.sthora.Size = New System.Drawing.Size(0, 17)
        '
        'stcumplecli
        '
        Me.stcumplecli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.stcumplecli.Name = "stcumplecli"
        Me.stcumplecli.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlssalir, Me.ToolStripSeparator1, Me.tlsusuario, Me.tlsmclientes, Me.tlsmproveedores, Me.tlsmvendedores, Me.tlsbbancos, Me.ToolStripSeparator2, Me.tlsregcob, Me.ToolStripSeparator3, Me.tlsdreportes, Me.ToolStripSeparator4, Me.tlsayuda})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(653, 25)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tlssalir
        '
        Me.tlssalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlssalir.Image = CType(resources.GetObject("tlssalir.Image"), System.Drawing.Image)
        Me.tlssalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlssalir.Name = "tlssalir"
        Me.tlssalir.Size = New System.Drawing.Size(23, 22)
        Me.tlssalir.Text = "Salir"
        Me.tlssalir.ToolTipText = "Salir del sistema"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tlsusuario
        '
        Me.tlsusuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsusuario.Image = CType(resources.GetObject("tlsusuario.Image"), System.Drawing.Image)
        Me.tlsusuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsusuario.Name = "tlsusuario"
        Me.tlsusuario.Size = New System.Drawing.Size(23, 22)
        Me.tlsusuario.Text = "Usuario"
        Me.tlsusuario.ToolTipText = "Mantenimiento de Usuarios"
        '
        'tlsmclientes
        '
        Me.tlsmclientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsmclientes.Image = CType(resources.GetObject("tlsmclientes.Image"), System.Drawing.Image)
        Me.tlsmclientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsmclientes.Name = "tlsmclientes"
        Me.tlsmclientes.Size = New System.Drawing.Size(23, 22)
        Me.tlsmclientes.Text = "Clientes"
        Me.tlsmclientes.ToolTipText = "Mantenimiento de Clientes"
        '
        'tlsmproveedores
        '
        Me.tlsmproveedores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsmproveedores.Image = CType(resources.GetObject("tlsmproveedores.Image"), System.Drawing.Image)
        Me.tlsmproveedores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsmproveedores.Name = "tlsmproveedores"
        Me.tlsmproveedores.Size = New System.Drawing.Size(23, 22)
        Me.tlsmproveedores.Text = "Proveedores"
        Me.tlsmproveedores.ToolTipText = "Mantenimiento de Proveedores"
        '
        'tlsmvendedores
        '
        Me.tlsmvendedores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsmvendedores.Image = CType(resources.GetObject("tlsmvendedores.Image"), System.Drawing.Image)
        Me.tlsmvendedores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsmvendedores.Name = "tlsmvendedores"
        Me.tlsmvendedores.Size = New System.Drawing.Size(23, 22)
        Me.tlsmvendedores.Text = "Operadores"
        Me.tlsmvendedores.ToolTipText = "Mantenimiento de Operadores"
        '
        'tlsbbancos
        '
        Me.tlsbbancos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsbbancos.Image = CType(resources.GetObject("tlsbbancos.Image"), System.Drawing.Image)
        Me.tlsbbancos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsbbancos.Name = "tlsbbancos"
        Me.tlsbbancos.Size = New System.Drawing.Size(23, 22)
        Me.tlsbbancos.ToolTipText = "Bancos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tlsregcob
        '
        Me.tlsregcob.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsregcob.Image = CType(resources.GetObject("tlsregcob.Image"), System.Drawing.Image)
        Me.tlsregcob.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsregcob.Name = "tlsregcob"
        Me.tlsregcob.Size = New System.Drawing.Size(23, 22)
        Me.tlsregcob.ToolTipText = "Registro Cobranzas"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tlsdreportes
        '
        Me.tlsdreportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsdreportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsusers, Me.tlsrclientes, Me.tlsrproveedores, Me.tlsrvendedores})
        Me.tlsdreportes.Image = CType(resources.GetObject("tlsdreportes.Image"), System.Drawing.Image)
        Me.tlsdreportes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsdreportes.Name = "tlsdreportes"
        Me.tlsdreportes.Size = New System.Drawing.Size(29, 22)
        Me.tlsdreportes.Text = "Reportes"
        Me.tlsdreportes.ToolTipText = "Reportes del sistema"
        '
        'tlsusers
        '
        Me.tlsusers.Image = CType(resources.GetObject("tlsusers.Image"), System.Drawing.Image)
        Me.tlsusers.Name = "tlsusers"
        Me.tlsusers.Size = New System.Drawing.Size(146, 22)
        Me.tlsusers.Text = "Usuario"
        Me.tlsusers.ToolTipText = "Reporte de Usuarios"
        '
        'tlsrclientes
        '
        Me.tlsrclientes.Image = CType(resources.GetObject("tlsrclientes.Image"), System.Drawing.Image)
        Me.tlsrclientes.Name = "tlsrclientes"
        Me.tlsrclientes.Size = New System.Drawing.Size(146, 22)
        Me.tlsrclientes.Text = "Clientes"
        Me.tlsrclientes.ToolTipText = "Reporte de Clientes"
        '
        'tlsrproveedores
        '
        Me.tlsrproveedores.Image = CType(resources.GetObject("tlsrproveedores.Image"), System.Drawing.Image)
        Me.tlsrproveedores.Name = "tlsrproveedores"
        Me.tlsrproveedores.Size = New System.Drawing.Size(146, 22)
        Me.tlsrproveedores.Text = "Proveedores"
        Me.tlsrproveedores.ToolTipText = "Reporte de Proveedores"
        '
        'tlsrvendedores
        '
        Me.tlsrvendedores.Image = CType(resources.GetObject("tlsrvendedores.Image"), System.Drawing.Image)
        Me.tlsrvendedores.Name = "tlsrvendedores"
        Me.tlsrvendedores.Size = New System.Drawing.Size(146, 22)
        Me.tlsrvendedores.Text = "Vendedores"
        Me.tlsrvendedores.ToolTipText = "Reporte de vendedores"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tlsayuda
        '
        Me.tlsayuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsayuda.Image = CType(resources.GetObject("tlsayuda.Image"), System.Drawing.Image)
        Me.tlsayuda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsayuda.Name = "tlsayuda"
        Me.tlsayuda.Size = New System.Drawing.Size(23, 22)
        Me.tlsayuda.Text = "Ayuda"
        '
        'FrmPrincipal
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.Project1.My.Resources.Resources.VisualStudio2005
        Me.ClientSize = New System.Drawing.Size(653, 668)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.stbarra)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Location = New System.Drawing.Point(11, 49)
        Me.Name = "FrmPrincipal"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Registro de Llamadas - CALLIST                                        " & _
            "                N.I.C  S.A"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.stbarra.ResumeLayout(False)
        Me.stbarra.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncriptacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchivosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SistemasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AuditoríaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarContraseñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SistemasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarContraseñaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProovedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosDelSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stbarra As System.Windows.Forms.StatusStrip
    Friend WithEvents sthora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stnombre As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlssalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsusuario As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsayuda As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsdreportes As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tlsusers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsrclientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsrproveedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsrvendedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsmclientes As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsmproveedores As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlsmvendedores As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BancosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BancosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeBancosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistraInventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsbbancos As System.Windows.Forms.ToolStripButton
    Friend WithEvents stcumplecli As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tlsregcob As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
#End Region
End Class