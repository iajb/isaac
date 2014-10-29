'Autor: Equipo de desarrollo de Siemens
'Fecha de creación: 
'Descripción: Formulario de la campaña 1 de produbanco

'Fecha de modificación:
'Autor de la modificación:
'Descripción de la modificación:

Public Class frm_registrocampaña
    Inherits System.Windows.Forms.Form


    '#Region "Atributos de clase"
    '    Public sql As sqljoin = New sqljoin
    '    Public objpersona As persona = New persona 'Instancia de la clase persona.
    '    Private objclientecampaña As persona = New persona 'Instancia de la clase persona.

    '    Private num_contacto As Integer 'Número al que se llamará al cliente. 
    '    Private llamada As Integer = Nothing ' 

    '    Public ayuda As ayuda 'Instancia del formulario ayuda., que contiene el script del formulario
    '    Private a As FrmPrincipal 'Instancia del formulario FrmPrincipal, padre de este formulario.

    '    Private fecha As Date '
    '    Private fecha_call As Date 'Fecha callback que se envía a genesys para volver a llamar al cliente.

    '    Private dataTable1 As DataTable 'Instancia de la clase DataTable, para la carga de datos del combo de estados.
    '    Private dataTableContactado As DataTable 'Instancia de la clase DataTable, para la carga de datos del combo de estados de descripciones.
    '    Private dataTableNoContactado As DataTable 'Instancia de la clase DataTable, para la carga de datos del combo de estados de descripciones.

    '    Private filtro As String = "" '
    '    Private tipofiltro As String = "" '
    '    Private idCliente As String


    '#End Region

    '#Region "Constructor"

    '    Public Sub New()

    '        MyBase.New() 'Constructor de la clase padre.
    '        InitializeComponent() 'Método de inicialización de componentes.

    '        ayuda = New ayuda() 'Instanciación de formulario ayuda, que contiene el script para el usuario.
    '        ayuda.MdiParent = FrmPrincipal 'Establecimiento del midParent de este formulario.

    '        'ayuda8 = New frm_ayuda8()
    '        'ayuda8.MdiParent = FrmPrincipal

    '        Me.llenarDataTableContactado() 'Carga de instancias de clase DataTable de descripciones correspondientes al estado NO contactado.
    '        Me.llenarDataTableNoContactado() 'Carga de instancias de clase DataTable de descripciones correspondientes al estado contactado.

    '    End Sub

    '#End Region

    '#Region "Métodos Públicos"

    '    ' Autor: Luis Miranda
    '    ' Fecha de creación:
    '    ' Descripción: Se encarga de llenar los controles de este formulario con los datos
    '    ' del atributo de clase objpersona en el cual los valores debieron haber sido fijados previamente

    '    Public Sub llenardatos()

    '        Me.txbnombre.Text = Me.objpersona.nombre
    '        Me.txbidcliente.Text = Me.objpersona.identificacion
    '        Me.txbciudad.Text = Me.objpersona.ciudaddomicilio
    '        Me.txbnumdomicilio.Text = Me.objpersona.telefonodomicilio
    '        Me.txbnumtrabajo.Text = Me.objpersona.telefonotrabajo
    '        Me.txtnumcelular.Text = Me.objpersona.telefonocelular
    '        Me.txbtarjetacliente.Text = Me.objpersona.tarjetacliente

    '        Me.txboficialtarjeta.Text = Me.objpersona.oficial_tarjeta

    '        Me.txbpagocontado.Text = Me.objpersona.saldo_pago_contado
    '        Me.txbpagominimo.Text = Me.objpersona.saldo_pago_minimo
    '        'Me.dtpfechamaxpago.Value = Me.objpersona.fecha_maxima_pago
    '        Me.txbpagovencido.Text = Me.objpersona.saldo_pago_vencido
    '        Me.txb_tipodebito.Text = Me.objpersona.tipo_debito

    '        Me.txbtipo_tarjeta.Text = Me.objpersona.tipotarjeta
    '        Me.txbformapago.Text = Me.objpersona.forma_pago
    '        'Deshabilitamos fecha máxima de pago
    '        Me.txtfechamp.Text = Me.objpersona.fecha_maxima_pago_str
    '        Me.chk_estados.Checked = False
    '    End Sub

    '    ' Autor: Luis Miranda
    '    ' Fecha de creación:
    '    ' Descripción: Método que ingresa un Cliente a la base de datos

    '    Public Sub Modificarcliente()

    '        Try
    '            Me.objpersona.nombre = Me.txbnombre.Text
    '            Me.objpersona.identificacion = Me.txbidcliente.Text
    '            Me.objpersona.ciudaddomicilio = Me.txbciudad.Text
    '            Me.objpersona.telefonodomicilio = Me.txbnumdomicilio.Text
    '            Me.objpersona.telefonotrabajo = Me.txbnumtrabajo.Text
    '            Me.objpersona.telefonocelular = Me.txtnumcelular.Text

    '            Me.objpersona.tarjetacliente = Me.txbtarjetacliente.Text
    '            Me.objpersona.oficial_tarjeta = Me.txboficialtarjeta.Text

    '            Me.objpersona.saldo_pago_contado = Me.txbpagocontado.Text
    '            Me.objpersona.saldo_pago_minimo = Me.txbpagominimo.Text

    '            'Me.objpersona.fecha_maxima_pago = Format(Me.dtpfechamaxpago.Value, "dd/MM/yyyy")
    '            ' Me.objpersona.fecha_maxima_pago_str = Me.dtpfechamaxpago.Text
    '            Me.objpersona.saldo_pago_vencido = Me.txbpagovencido.Text
    '            Me.objpersona.tarjetacliente = Me.txbtarjetacliente.Text
    '            Me.objpersona.tipotarjeta = Me.txbtipo_tarjeta.Text
    '            Me.objpersona.forma_pago = Me.txbformapago.Text
    '            Me.objpersona.tipo_debito = Me.txb_tipodebito.Text


    '            Me.objpersona.ModificarPersona()
    '            MessageBox.Show("Modificación de Persona exitoso", "Modificar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            limpiarDatos()
    '            Me.btnbuscar.Focus()
    '        Catch ex As Exception
    '            MessageBox.Show("Error en el modificación, consulte a su proveedor", "Modificar Paciente Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            MessageBox.Show(ex.Message)
    '        End Try
    '    End Sub

    '    ' Autor: Luis Miranda
    '    ' Fecha de creación:
    '    ' Descripción: 'Metodo que limpia los controles de la pantalla

    '    Public Sub limpiarDatos()
    '        Me.txbnombre.Text = ""
    '        Me.txbidcliente.Text = ""
    '        Me.txbciudad.Text = ""
    '        Me.txbnumdomicilio.Text = ""
    '        Me.txbnumtrabajo.Text = ""
    '        Me.txtnumcelular.Text = ""
    '        Me.txbtarjetacliente.Text = ""
    '        Me.txboficialtarjeta.Text = ""
    '        Me.txbpagocontado.Text = ""
    '        Me.txbpagominimo.Text = ""
    '        '************************** cambie dtpfechamaxpago.value por dtpfechamaxpago.Text
    '        '  Me.dtpfechamaxpago.Text = ""
    '        Me.txbpagovencido.Text = ""
    '        Me.lsv_clientes_campañas.Items.Clear()
    '        Me.txtComentario.Text = ""
    '        Me.txbtipo_tarjeta.Text = ""
    '        Me.txbformapago.Text = ""
    '        Me.txb_tipodebito.Text = ""
    '        Me.txbidcliente.Text = ""
    '        Me.txtfechamp.Text = ""
    '        Me.chk_estados.Checked = False

    '        Me.txbnumdomicilio.Enabled = True
    '        Me.txbnumtrabajo.Enabled = True
    '        Me.txtnumcelular.Enabled = True
    '        Me.txbnumdomicilio.BackColor = Color.White
    '        Me.txbnumtrabajo.BackColor = Color.White
    '        Me.txtnumcelular.BackColor = Color.White
    '    End Sub

    '    ' Autor: 
    '    ' Fecha de creación:
    '    ' Descripción: 'Guarda el cliente actual en la tabla campaña1_cobranzas_mastercard
    '    ' si el estado del combo 2 es no se encuentra, se activa los time pickers,
    '    ' si están activados tomamos la fecha de los pickers, si no están entonces se asigna la fecha mínima
    '    ' es decir 1900-01-01, indicando con esto que el usuario no asignó ninguna
    '    ' fecha para volver a llamar al cliente.

    '    Public Sub guardarcontacto()

    '        If (Me.cb_hora.Enabled And Me.cb_fecha.Enabled) Then
    '            fecha_call = Me.cb_fecha.Text & " " & Me.cb_hora.Text
    '        Else
    '            fecha_call = DateTime.Today()
    '        End If

    '        ' Guarda el cliente actual a la base de datos
    '        Me.objpersona.guardarcontactos(Me.txbidcliente.Text, llamada, Me.ComboBox1.Text, Me.ComboBox2.Text, Me.txtComentario.Text, objusuario.txtusuario, fecha_call)

    '    End Sub

    '    ' Autor: Luis Miranda
    '    ' Fecha de creación:
    '    ' Descripción: 'Llena el control ListView con la historia de llamadas del cliente actual.

    '    Public Sub llenardatalist()

    '        Dim conexion As sqljoin = New sqljoin
    '        Dim item As ListViewItem
    '        Dim reader As SqlClient.SqlDataReader
    '        Dim contador As Integer = 0
    '        Me.lsv_clientes_campañas.Items.Clear()

    '        Try

    '            If (Me.txbidcliente.Text <> " ") Then
    '                reader = conexion.traerDataReader("Select num_telefonocontacto,fecha_ultima_llamada,estado_llamada ,observaciones_llamadas,usuario from campaña1_requerimientos where identificacion= " & Me.txbidcliente.Text & " order by fecha_ultima_llamada desc")

    '                While (reader.Read())

    '                    contador = contador + 1
    '                    item = New ListViewItem(contador.ToString())
    '                    item.SubItems.Add(reader.GetString(0))
    '                    item.SubItems.Add(reader.GetDateTime(1))
    '                    item.SubItems.Add(reader.GetString(2))
    '                    item.SubItems.Add(reader.GetString(3))
    '                    item.SubItems.Add(reader.GetString(4))

    '                    Me.lsv_clientes_campañas.Items.Add(item)

    '                End While

    '                reader.Close()

    '            End If

    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '        End Try

    '    End Sub

    '    ' Autor: 
    '    ' Fecha de creación:
    '    ' Descripción: Carga desde la tabla estados de la base de datos.
    '    ' Los estados pueden ser "Contactado", "No Contactado"
    '    ' Establece el elemento seleccionado por default al primer elemento del combo.

    '    Public Sub llenarCombo1()

    '        Dim conexion As sqljoin = New sqljoin

    '        Me.ComboBox1.DataSource = Nothing
    '        Me.ComboBox1.Items.Clear()

    '        ' Llena el data table con los registros obtenidos del query
    '        dataTable1 = conexion.devolverDatosEnDataTable("Select descripcion from estados  order by descripcion")

    '        Me.ComboBox1.DataSource = dataTable1 ' Establece el origen de datos del combo a los registros obtenidos del query
    '        Me.ComboBox1.DisplayMember = "descripcion" 'Campo del query que debe mostrarse en el combo
    '        Me.ComboBox1.SelectedIndex = 0 ' Elemento seleccionado pot default

    '    End Sub

    '    ' Autor: Raúl Cabrera
    '    ' Fecha de creación:
    '    ' Descripción: Carga desde la tabla descripcion_estados de la base de datos los registros correspondientes al estado "Contactado"

    '    Public Sub llenarDataTableContactado()

    '        Dim conexion As sqljoin = New sqljoin
    '        dataTableContactado = conexion.devolverDatosEnDataTable("Select descripcion from descripcion_estados where cod_estado_llamadas = 1 and codigo_campaña = 1 order by descripcion")

    '    End Sub

    '    ' Autor: Raúl Cabrera
    '    ' Fecha de creación:
    '    ' Descripción: Carga desde la tabla descripcion_estados de la base de datos los registros correspondientes al estado "NO Contactado"

    '    Public Sub llenarDataTableNoContactado()

    '        Dim conexion As sqljoin = New sqljoin
    '        dataTableNoContactado = conexion.devolverDatosEnDataTable("Select descripcion from descripcion_estados where cod_estado_llamadas = 2 and codigo_campaña = 1 order by descripcion")

    '    End Sub


    '#End Region

    '#Region "Métodos manejadores de eventos"

    '    ' Autor: 
    '    ' Fecha de creación:
    '    ' Descripción: 'Método que maneja el evento click sobre el botón btnaceptar,
    '    ' Si la identificación del cliente se ha fijado en el textbox txbnombre, mostramos un mensaje de confirmación, 
    '    ' si el usuario desea guardar el cliente, entonces hacemos la llamada al método guardar contacto. Si los time pickers están
    '    ' habilitados tomamos la hora de estos y llamamos a la función rutinaGeneraCitas. 

    '    Private Sub btnaceptar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim cedula As String = Me.txbidcliente.Text
    '        idCliente = Me.txbidcliente.Text.Trim
    '        Dim _strLlamada As String = llamada.ToString
    '        'Si la identificación del cliente ha sido fijada en el textbox txbnombre

    '        If (Me.llamada <> Nothing And gBlSeLlamoAlCliente) Then
    '            If Me.txbnombre.Text.Trim <> "" Then

    '                If MessageBox.Show("Desea guardar y procesar el registro registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

    '                    ' Método que se encarga de guardar el cliente actual a la base


    '                    If IsNothing(gStrDuracionLlamadaCallGsys) And gDateHoraInicioCallGsys <> "#12:00:00 AM#" Then
    '                        'Si se llamó al cliente y se tipifica sin colgar hacemos la resta aqui
    '                        gStrDuracionLlamadaCallGsys = (Date.Now - gDateHoraInicioCallGsys).Duration.ToString().Substring(0, 8)
    '                    Else
    '                        '    'Si no se presiono el boton llamar no se fija la hora en la variable gDateHoraInicioCallGsys
    '                        '    ' Por tanto nunca se realizá la llamada  ponemos un tiempo de 0

    '                        If gDateHoraInicioCallGsys = "#12:00:00 AM#" Then
    '                            gStrDuracionLlamadaCallGsys = "00:00:00"
    '                        End If

    '                    End If

    '                    guardarcontacto()

    '                    'REGISTRA QUE HIZO CLICK EN  EL BOTON ACEPTAR
    '                    'gbl_objAuditoriaArchivos.Auditoria_Evento("1", DateTime.Now(), objusuario.cedula, Me.txbidcliente.Text, Me.llamada, "01", "Transacción", 0)

    '                    gBlnSalir = True
    '                    gBlSeLlamoAlCliente = False

    '                    'REGISTRA EL USO DEL FORMULARIO 
    '                    gbl_objAuditoriaArchivos.Auditoria_Evento("1", DateTime.Now(), objusuario.cedula, Me.txbidcliente.Text, Me.llamada, "05", "Transacción", 1)


    '                    ' Si los timepickers es´tan habilitados
    '                    If Me.cb_fecha.Enabled And Me.cb_hora.Enabled Then

    '                        Dim localDate As String
    '                        Dim localTime As String

    '                        ' Damos formato a la hora    
    '                        localDate = Format(CDate(cb_fecha.Text), "MM/dd/yy")
    '                        localTime = Format(CDate(cb_hora.Text), "HH:mm")

    '                        ' Proceso que se encarga de generar citas de llamadas en GENESYS

    '                        Call rutinaGeneraCitas(localDate + " " + localTime, _
    '                                "Campaign", _
    '                                glb_Call_Campaign, _
    '                                glb_Call_AplicacionID, _
    '                                glb_Call_RecordHandle)

    '                    End If

    '                    ' Si el textbox txtestado tiene su propiedad .Text como "Inactivo" o Se ha seleccionado el primer elemento del
    '                    ' combo box ComboBox1(Contactado), entonces llamamos al procedimiento ActualizarRegistro_CTIGsys, que se encarga de que los
    '                    ' clientes que cumplen con estas condiciones no vuelvan a ser llamados

    '                    If Me.txtestado.Text = "Inactivo" Or Me.ComboBox1.SelectedIndex = 0 Then
    '                        Me.sql.conexion("Update campaña1_cobranzas_mastercard set estado_cliente=1, estado_registro='I', fecha_estado_registro=getdate() where identificacion=" & cedula)


    '                        'Procedimiento que se encarga de que GENESYS no vuelva a llamar a clientes(FILTRO = 1)
    '                        Call ActualizarRegistro_CTIGsys("valueOfUserField", _
    '                                                            0, _
    '                                                            "1", _
    '                                                            "0", _
    '                                                            glb_Call_Campaign, _
    '                                                            glb_Call_AplicacionID, _
    '                                                            glb_Call_RecordHandle)

    '                        Dim conexion As sqljoin = New sqljoin
    '                        conexion.conexion("EXEC asegurar_filtro_cobranzas 1, " & cedula & " ")

    '                    End If

    '                    If glb_call_result <> 0 Then
    '                        'PROCEDIMIENTO PARA COLOCAR EL RESULTADO DE LLAMADA - CALL_RESULT
    '                        Call ActualizarRegistro_CTIGsys("valueOfCallResult", _
    '                                                            glb_call_result, _
    '                                                            "", _
    '                                                            "0", _
    '                                                            glb_Call_Campaign, _
    '                                                            glb_Call_AplicacionID, _
    '                                                            glb_Call_RecordHandle)
    '                    End If


    '                    MessageBox.Show("Proceso registrado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '                    Me.ayuda.Visible = False ' Ocultamos el script
    '                    'Me.ayuda8.Visible = False
    '                    Me.Hide() 'Ocultamos este formulario

    '                    limpiarDatos() ' Limpiamos los controles de este formulario
    '                    releaseCTI() '

    '                    gStrDuracionLlamadaCallGsys = Nothing
    '                    gDateHoraInicioCallGsys = Nothing


    '                End If

    '            Else ' En caso de que no se haya fijado el textbox txbnombre con la identificación del cliente
    '                MessageBox.Show("Debe escojer un cliente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If
    '        Else
    '            MessageBox.Show("Debe escojer un telefono", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            '  gbl_objAuditoriaArchivos.Auditoria_Evento("1", DateTime.Now(), objusuario.cedula, Me.txbidcliente.Text, Me.llamada, "02", "Transacción", 0)
    '        End If

    '        Try
    '            Dim objGen As New ProdubancoCampanias.Common.General
    '            Dim objAuditoria As New ProdubancoCampanias.Common.Auditoria.AuditoriaLog
    '            objAuditoria.ConfigurarAuditoria(objAuditoria, objusuario.cedula, 1, objGen.Gen_btnAceptar, idCliente, ProdubancoCampanias.Common.TipoTransaccion.Escritura, llamada.ToString, ProdubancoCampanias.Common.Auditoria.AuditoriaLog.Supervisor, "", "")
    '            ProdubancoCampanias.Common.AuditoriaDalc.GrabarAuditoria_Log(objAuditoria)
    '        Catch
    '        End Try

    '    End Sub

    '    ' Autor: 
    '    ' Fecha de creación:
    '    ' Descripción: 'Método que maneja el evento load de este formulario.
    '    ' mostramos la ayuda, deshabilitamos los times pickers y llenamos el combo box ComboBox1, con sus respectivos estados

    '    Private Sub frmmodificacioncampaña_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    '        Me.ayuda.Show()

    '        Me.cb_fecha.Enabled = False
    '        Me.cb_hora.Enabled = False

    '        Me.llenarCombo1() ' Llenamos el combo box ComboBox1
    '        'Me.txbnumdomicilio.Focus()

    '        If (objusuario.txtusuario = "luis") Then
    '            Me.btnbuscar.Visible = True
    '        End If
    '    End Sub

    '    ' Autor: 
    '    ' Fecha de creación:
    '    ' Descripción: 'Método que maneja el evento click sobre el boton btnllamar_click

    '    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
    '        Dim KeyAscii As Short = Asc(e.KeyChar)

    '        If KeyAscii = 13 Then
    '            Me.txtComentario.Focus()
    '        End If
    '    End Sub

    '    ' Autor: 
    '    ' Fecha de creación:
    '    ' Descripción: 'Maneja el evento de cambio de indice en el combo box ComboBox2

    '    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
    '        'SE AGREGARON MAS INDICES PARA QUE SE ACTIVE EL CALLBACK
    '        If (Me.ComboBox1.SelectedIndex = 1 And ((Me.ComboBox2.SelectedIndex = 3) Or (Me.ComboBox2.SelectedIndex = 2) Or (Me.ComboBox2.SelectedIndex = 5) Or (Me.ComboBox2.SelectedIndex = 6) Or (Me.ComboBox2.SelectedIndex = 7))) Then
    '            Me.chk_estados.Enabled = True

    '            'Me.cb_fecha.Enabled = True
    '            'Me.cb_hora.Enabled = True
    '        Else

    '            Me.chk_estados.Enabled = False

    '            Me.chk_estados.Checked = False
    '            'Me.cb_hora.Enabled = False
    '            'Me.cb_fecha.Enabled = False
    '        End If
    '        If (((Me.ComboBox2.SelectedIndex = 1) Or (Me.ComboBox2.SelectedIndex = 4) Or Me.ComboBox2.SelectedIndex = 5 Or (Me.ComboBox2.SelectedIndex = 6) Or Me.ComboBox2.SelectedIndex = 8 Or Me.ComboBox2.SelectedIndex = 9)) And (Me.ComboBox1.SelectedIndex = 1) Then
    '            Me.txtestado.Text = "Inactivo"
    '        Else
    '            Me.txtestado.Text = "Activo"
    '        End If
    '    End Sub

    '    ' Autor: 
    '    ' Fecha de creación:
    '    ' Descripción: 'Maneja el evento de cierre de este formulario, se muestra un box
    '    ' informando de que este formulario no se puede cerrar

    '    Private Sub cerrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    '        MessageBox.Show("No es posible cerrar el formulario, consulte con su supervisor", "Call Center Salir", MessageBoxButtons.OK, MessageBoxIcon.Question)

    '        'lUIS 15/08/06
    '        'REGISTRA EL EVENTOD E HABER QUERIDO SALIR DEL FOPRMULARIO
    '        ' gbl_objAuditoriaArchivos.Auditoria_Evento("1", DateTime.Now(), objusuario.cedula, Me.txbidcliente.Text, Me.llamada, "03", "Transacción", 0)
    '        e.Cancel = True ' Cancela el cierre de este formulario.

    '    End Sub
    '    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
    '        Dim KeyAscii As Short = Asc(e.KeyChar)

    '        If KeyAscii = 13 Then
    '            Me.ComboBox2.Focus()
    '        End If
    '    End Sub

    '    ' Autor: 
    '    ' Fecha de creación:
    '    ' Descripción: 'Maneja el evento de cambio de índice en el combo box ComboBox1, 
    '    ' llena el combo box ComboBox2 de acuerdo al item seleccionado en el como box ComboBox1

    '    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
    '        Try
    '            Me.ComboBox2.DataSource = Nothing 'Vaciamos el contenido del combo box ComboBox2

    '            If Me.ComboBox1.SelectedIndex = 0 Then 'Si está seleccionado el primer elemento del combo box ComboBox1 (es decir, el text del combo es "Contactado")
    '                Me.ComboBox2.DataSource = dataTableContactado 'cargamos el combo con las descripciones correspondientes
    '                Me.ComboBox2.DisplayMember = "descripcion" 'Indicamos el campo del query que debe ser mostrado en el combo
    '            Else 'Si NO está seleccionado el primer elemento del combo box ComboBox1 (es decir, el text del combo es "NO Contactado")
    '                Me.ComboBox2.DataSource = dataTableNoContactado 'cargamos el combo con las descripciones correspondientes
    '                Me.ComboBox2.DisplayMember = "descripcion" 'Indicamos el campo del query que debe ser mostrado en el combo
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)

    '        End Try

    '    End Sub

    '    Private Sub txbnumdomicilio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbnumdomicilio.KeyPress

    '        If ((Microsoft.VisualBasic.AscW((e.KeyChar)) < 48 And Microsoft.VisualBasic.AscW(e.KeyChar) <> 8) Or Microsoft.VisualBasic.AscW(e.KeyChar) > 57) Then
    '            e.Handled = True
    '        End If
    '        Dim KeyAscii As Short = Asc(e.KeyChar)

    '        If KeyAscii = 13 Then
    '            Me.txtnumcelular.Focus()
    '        End If

    '    End Sub


    '    Private Sub txtnumcelular_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnumcelular.DoubleClick
    '        If Me.txtnumcelular.Text.Length > 7 And Me.txtnumcelular.Text.Length < 10 Then
    '            Me.llamada = CInt(Me.txtnumcelular.Text)
    '            frmToolKitGenesys.txtDestination.Text = Me.txtnumcelular.Text.Trim
    '            txbnumdomicilio.Enabled = False
    '            txtnumcelular.Enabled = False
    '            txbnumtrabajo.Enabled = False
    '            txtnumcelular.BackColor = Color.Linen
    '        End If

    '        Try
    '            Dim objGen As New ProdubancoCampanias.Common.General
    '            Dim objAuditoria As New ProdubancoCampanias.Common.Auditoria.AuditoriaLog
    '            objAuditoria.ConfigurarAuditoria(objAuditoria, objusuario.cedula, 1, objGen.Gen_txtTelefonoDomicilio, Me.idCliente, ProdubancoCampanias.Common.TipoTransaccion.Lectura, llamada.ToString, ProdubancoCampanias.Common.Auditoria.AuditoriaLog.Supervisor, "", "")
    '            ProdubancoCampanias.Common.AuditoriaDalc.GrabarAuditoria_Log(objAuditoria)
    '        Catch
    '        End Try
    '    End Sub

    '    Private Sub txtnumcelular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumcelular.KeyPress
    '        If ((Microsoft.VisualBasic.AscW((e.KeyChar)) < 48 And Microsoft.VisualBasic.AscW(e.KeyChar) <> 8) Or Microsoft.VisualBasic.AscW(e.KeyChar) > 57) Then
    '            e.Handled = True
    '        End If

    '        Dim KeyAscii As Short = Asc(e.KeyChar)

    '        If KeyAscii = 13 Then
    '            Me.txbnumtrabajo.Focus()
    '        End If
    '    End Sub


    '    Private Sub txbnumtrabajo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbnumtrabajo.DoubleClick
    '        If Me.txbnumtrabajo.Text.Length > 7 And Me.txbnumtrabajo.Text.Length < 10 Then
    '            Me.llamada = CInt(Me.txbnumtrabajo.Text.Trim)
    '            frmToolKitGenesys.txtDestination.Text = Me.txbnumtrabajo.Text.Trim
    '            txbnumdomicilio.Enabled = False
    '            txtnumcelular.Enabled = False
    '            txbnumtrabajo.Enabled = False
    '            txbnumtrabajo.BackColor = Color.Linen
    '        End If

    '        Try
    '            Dim objGen As New ProdubancoCampanias.Common.General
    '            Dim objAuditoria As New ProdubancoCampanias.Common.Auditoria.AuditoriaLog
    '            objAuditoria.ConfigurarAuditoria(objAuditoria, objusuario.cedula, 1, objGen.Gen_txtTelefonoDomicilio, Me.idCliente, ProdubancoCampanias.Common.TipoTransaccion.Lectura, llamada.ToString, ProdubancoCampanias.Common.Auditoria.AuditoriaLog.Supervisor, "", "")
    '            ProdubancoCampanias.Common.AuditoriaDalc.GrabarAuditoria_Log(objAuditoria)
    '        Catch
    '        End Try
    '    End Sub

    '    Private Sub txbnumtrabajo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbnumtrabajo.KeyPress
    '        If ((Microsoft.VisualBasic.AscW((e.KeyChar)) < 48 And Microsoft.VisualBasic.AscW(e.KeyChar) <> 8) Or Microsoft.VisualBasic.AscW(e.KeyChar) > 57) Then
    '            e.Handled = True
    '        End If

    '        Dim KeyAscii As Short = Asc(e.KeyChar)

    '        If KeyAscii = 13 Then
    '            Me.ComboBox1.Focus()
    '        End If
    '    End Sub


    '    ' Autor: 
    '    ' Fecha de creación:
    '    ' Descripción: Maneja el evento move del formulario actual,
    '    ' Establece como límite en Y el valor de 71, para que no se oculte la botonera trás algún formulario.
    '    ' Este método funciona correctamente si la resolución del monitor que se usa es de 
    '    ' 1024 * 768

    '    Private Sub frm_modificacioncampaña_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
    '        If Me.Location.Y <= 71 Then
    '            Me.Location = New Point(Me.Location.X, 71)
    '        End If
    '    End Sub

    '    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click

    '        Dim listadoclientes As frm_listadousuarios = New frm_listadousuarios(Me.objpersona)
    '        Me.ayuda.Visible = False

    '        Try
    '            listadoclientes.ShowDialog()
    '            llenardatos()

    '        Catch ex As Exception

    '        End Try
    '        llenardatalist()
    '        '***********************************A GREGAR**********

    '        Dim reader As SqlClient.SqlDataReader
    '        Dim connection As New sqljoin

    '        reader = connection.traerDataReader("SELECT COUNT(identificacion) AS num_veces_llamado FROM  campaña1_requerimientos WHERE identificacion = " & frmModificacionCampaña.objpersona.identificacion & "")

    '        frmModificacionCampaña.objpersona.numerovecesllamado = 0

    '        If reader.HasRows Then
    '            If reader.Read Then
    '                frmModificacionCampaña.objpersona.numerovecesllamado = reader.GetInt32(0)
    '            End If
    '        Else
    '            frmModificacionCampaña.objpersona.numerovecesllamado = 0
    '        End If

    '        'If frmModificacionCampaña.objpersona.numerovecesllamado >= 8 Then
    '        '    frmModificacionCampaña.ayuda8.Show()
    '        'Else
    '        '    frmModificacionCampaña.ayuda.Show()
    '        'End If

    '        reader.Close()

    '    End Sub

    '#End Region

    '    Private Sub txtComentario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtComentario.KeyPress
    '        Dim KeyAscii As Short = Asc(e.KeyChar)

    '        If KeyAscii = 13 Then
    '            Me.btnaceptar.Focus()
    '        End If
    '    End Sub

    '    Private Sub chk_estados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_estados.CheckedChanged
    '        If (Me.chk_estados.Checked) Then
    '            Me.cb_fecha.Enabled = True
    '            Me.cb_hora.Enabled = True
    '        Else
    '            Me.cb_fecha.Enabled = False
    '            Me.cb_hora.Enabled = False
    '        End If

    '    End Sub

    '    Private Sub txbnumdomicilio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbnumdomicilio.DoubleClick
    '        If Me.txbnumdomicilio.Text.Length > 7 And Me.txbnumdomicilio.Text.Length < 10 Then
    '            Me.llamada = CInt(Me.txbnumdomicilio.Text)
    '            frmToolKitGenesys.txtDestination.Text = Me.txbnumdomicilio.Text.Trim
    '            txbnumdomicilio.Enabled = False
    '            txtnumcelular.Enabled = False
    '            txbnumtrabajo.Enabled = False
    '            txbnumdomicilio.BackColor = Color.Linen
    '        End If

    '        Try
    '            Dim objGen As New ProdubancoCampanias.Common.General
    '            Dim objAuditoria As New ProdubancoCampanias.Common.Auditoria.AuditoriaLog
    '            objAuditoria.ConfigurarAuditoria(objAuditoria, objusuario.cedula, 1, objGen.Gen_txtTelefonoDomicilio, Me.idCliente, ProdubancoCampanias.Common.TipoTransaccion.Lectura, llamada.ToString, ProdubancoCampanias.Common.Auditoria.AuditoriaLog.Supervisor, "", "")
    '            ProdubancoCampanias.Common.AuditoriaDalc.GrabarAuditoria_Log(objAuditoria)
    '        Catch
    '        End Try
    '    End Sub

    '    Private Sub txbnumdomicilio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbnumdomicilio.TextChanged

    '    End Sub

    '    Private Sub txbnumtrabajo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbnumtrabajo.TextChanged

    '    End Sub

    '    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click

    '        Dim cedula As String = Me.txbidcliente.Text
    '        idCliente = Me.txbidcliente.Text.Trim
    '        Dim _strLlamada As String = llamada.ToString
    '        'Si la identificación del cliente ha sido fijada en el textbox txbnombre

    '        If (Me.llamada <> Nothing And gBlSeLlamoAlCliente) Then
    '            If Me.txbnombre.Text.Trim <> "" Then

    '                If MessageBox.Show("Desea guardar y procesar el registro registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

    '                    ' Método que se encarga de guardar el cliente actual a la base


    '                    If IsNothing(gStrDuracionLlamadaCallGsys) And gDateHoraInicioCallGsys <> "#12:00:00 AM#" Then
    '                        'Si se llamó al cliente y se tipifica sin colgar hacemos la resta aqui
    '                        gStrDuracionLlamadaCallGsys = (Date.Now - gDateHoraInicioCallGsys).Duration.ToString().Substring(0, 8)
    '                    Else
    '                        '    'Si no se presiono el boton llamar no se fija la hora en la variable gDateHoraInicioCallGsys
    '                        '    ' Por tanto nunca se realizá la llamada  ponemos un tiempo de 0

    '                        If gDateHoraInicioCallGsys = "#12:00:00 AM#" Then
    '                            gStrDuracionLlamadaCallGsys = "00:00:00"
    '                        End If

    '                    End If

    '                    guardarcontacto()

    '                    'REGISTRA QUE HIZO CLICK EN  EL BOTON ACEPTAR
    '                    'gbl_objAuditoriaArchivos.Auditoria_Evento("1", DateTime.Now(), objusuario.cedula, Me.txbidcliente.Text, Me.llamada, "01", "Transacción", 0)

    '                    gBlnSalir = True
    '                    gBlSeLlamoAlCliente = False

    '                    'REGISTRA EL USO DEL FORMULARIO 
    '                    gbl_objAuditoriaArchivos.Auditoria_Evento("1", DateTime.Now(), objusuario.cedula, Me.txbidcliente.Text, Me.llamada, "05", "Transacción", 1)


    '                    ' Si los timepickers es´tan habilitados
    '                    If Me.cb_fecha.Enabled And Me.cb_hora.Enabled Then

    '                        Dim localDate As String
    '                        Dim localTime As String

    '                        ' Damos formato a la hora    
    '                        localDate = Format(CDate(cb_fecha.Text), "MM/dd/yy")
    '                        localTime = Format(CDate(cb_hora.Text), "HH:mm")

    '                        ' Proceso que se encarga de generar citas de llamadas en GENESYS

    '                        Call rutinaGeneraCitas(localDate + " " + localTime, _
    '                                "Campaign", _
    '                                glb_Call_Campaign, _
    '                                glb_Call_AplicacionID, _
    '                                glb_Call_RecordHandle)

    '                    End If

    '                    ' Si el textbox txtestado tiene su propiedad .Text como "Inactivo" o Se ha seleccionado el primer elemento del
    '                    ' combo box ComboBox1(Contactado), entonces llamamos al procedimiento ActualizarRegistro_CTIGsys, que se encarga de que los
    '                    ' clientes que cumplen con estas condiciones no vuelvan a ser llamados

    '                    If (Me.txtestado.Text = "Inactivo" And Me.chk_estados.Checked = False) Or Me.ComboBox1.SelectedIndex = 0 Then

    '                        Me.sql.conexion("Update campaña1_cobranzas_mastercard set estado_cliente=1, estado_registro='I', fecha_estado_registro=getdate() where identificacion=" & cedula)


    '                        'Procedimiento que se encarga de que GENESYS no vuelva a llamar a clientes(FILTRO = 1)
    '                        Call ActualizarRegistro_CTIGsys("valueOfUserField", _
    '                                                            0, _
    '                                                            "1", _
    '                                                            "0", _
    '                                                            glb_Call_Campaign, _
    '                                                            glb_Call_AplicacionID, _
    '                                                            glb_Call_RecordHandle)

    '                        Dim conexion As sqljoin = New sqljoin
    '                        conexion.conexion("EXEC asegurar_filtro_cobranzas 1, " & cedula & " ")

    '                    End If

    '                    If glb_call_result <> 0 Then
    '                        'PROCEDIMIENTO PARA COLOCAR EL RESULTADO DE LLAMADA - CALL_RESULT
    '                        Call ActualizarRegistro_CTIGsys("valueOfCallResult", _
    '                                                            glb_call_result, _
    '                                                            "", _
    '                                                            "0", _
    '                                                            glb_Call_Campaign, _
    '                                                            glb_Call_AplicacionID, _
    '                                                            glb_Call_RecordHandle)
    '                    End If


    '                    MessageBox.Show("Proceso registrado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '                    Me.ayuda.Visible = False ' Ocultamos el script
    '                    'Me.ayuda8.Visible = False
    '                    Me.Hide() 'Ocultamos este formulario

    '                    limpiarDatos() ' Limpiamos los controles de este formulario
    '                    releaseCTI() '

    '                    gStrDuracionLlamadaCallGsys = Nothing
    '                    gDateHoraInicioCallGsys = Nothing


    '                End If

    '            Else ' En caso de que no se haya fijado el textbox txbnombre con la identificación del cliente
    '                MessageBox.Show("Debe escojer un cliente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If
    '        Else
    '            MessageBox.Show("Debe escojer un telefono", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            '  gbl_objAuditoriaArchivos.Auditoria_Evento("1", DateTime.Now(), objusuario.cedula, Me.txbidcliente.Text, Me.llamada, "02", "Transacción", 0)
    '        End If

    '        Try
    '            Dim objGen As New ProdubancoCampanias.Common.General
    '            Dim objAuditoria As New ProdubancoCampanias.Common.Auditoria.AuditoriaLog
    '            objAuditoria.ConfigurarAuditoria(objAuditoria, objusuario.cedula, 1, objGen.Gen_btnAceptar, idCliente, ProdubancoCampanias.Common.TipoTransaccion.Escritura, llamada.ToString, ProdubancoCampanias.Common.Auditoria.AuditoriaLog.Supervisor, "", "")
    '            ProdubancoCampanias.Common.AuditoriaDalc.GrabarAuditoria_Log(objAuditoria)
    '        Catch
    '        End Try

    '    End Sub

    '    Private Sub dtpfechamaxpago_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub grpdomicilio_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpdomicilio.Enter

    End Sub

    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtphoracalltrab.ValueChanged

    End Sub
End Class
