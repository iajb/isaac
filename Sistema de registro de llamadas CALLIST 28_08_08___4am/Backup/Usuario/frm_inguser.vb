Public Class frm_inguser
    Public objusuario As usuarios


    Private Sub frmIngUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa_boton_nuevo()

    End Sub
 
    Private Sub ingusuario()

        Try
            Me.objusuario = New usuarios
            Me.objusuario.Nombre = Me.Usercontrol1.txbNombre.Text
            Me.objusuario.Apellido = Me.Usercontrol1.txbApellido.Text
            Me.objusuario.cedula1 = Me.Usercontrol1.txbCedula.Text.Trim
            Me.objusuario.Telefono = Me.Usercontrol1.txbTelefono.Text.Trim
            Me.objusuario.Direccion = Me.Usercontrol1.txbDireccion.Text
            Me.objusuario.contrasena = Me.txtcontraseña.Text
            Me.objusuario.usuario = Me.txtuser.Text
            Me.objusuario.ingusuario()

            MessageBox.Show("ingreso de usuario exitoso")
            limpiar()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function validar_datos() As Boolean

        For Each control As Control In Me.Usercontrol1.gpbdatos1.Controls

            If control.Text = "" Then
                'MessageBox.Show("todos los datos son importantes?", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        Next

        For Each control As Control In Me.GroupBox1.Controls

            If control.Text = "" Then
                'MessageBox.Show("todos los datos son importantes?", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub tlssalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlssalir.Click
        salir()
    End Sub
    Public Sub salir()

        If (MessageBox.Show("Desea salir de la opcion?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes) Then
            Me.Dispose()
        End If

    End Sub


    Private Sub tlsgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsgrabar.Click

        If Me.Usercontrol1.txbCedula.Text.Trim.Length <> 10 Then
            MessageBox.Show("Favor ingrese bien la cedula", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Usercontrol1.txbCedula.Focus()
            Exit Sub
        End If




        If validar_datos() = True Then
            'parte 2
            If (Me.txtcontraseña.Text = Me.txtrepcontraseña.Text) Then
                If (MessageBox.Show("Esta seguro que desea grabar ?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                    Me.objusuario = New usuarios
                    Me.objusuario.usuario = Me.txtuser.Text.Trim
                    If objusuario.buscaUsuario() Then   'busco si hay uuser repetido
                        MessageBox.Show("Ya existe un usuario con el user " & Me.objusuario.usuario, "Cambie usuario!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtuser.Focus()
                        Exit Sub
                    End If

                    Me.objusuario.cedula1 = Me.Usercontrol1.txbCedula.Text.Trim
                    'busco si hay una cedula repetida
                    If objusuario.buscacedula() Then
                        MessageBox.Show("Ya existe un usuario con la cédula " & Me.objusuario.cedula1, "Cambie cedula!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Usercontrol1.txbCedula.Focus()
                        Exit Sub
                    End If
                    ingusuario()
                    inacializa_boton_cancelar()
                End If
            Else
                MessageBox.Show("las contraseñas deben ser iguales")
                Exit Sub
            End If

        Else
            MessageBox.Show("Ingrese bien los datos por favor?", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    Private Sub tlsmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsmodificar.Click
        If (Me.Usercontrol1.txbNombre.Text.Trim <> "" And Me.Usercontrol1.txbApellido.Text.Trim <> "" And Me.Usercontrol1.txbCedula.Text.Trim <> "" And Me.Usercontrol1.txbDireccion.Text.Trim <> "" And Me.Usercontrol1.txbTelefono.Text.Trim <> "" And Me.txtcontraseña.Text.Trim <> "" And Me.txtuser.Text.Trim <> "" And Me.txtrepcontraseña.Text.Trim <> "") Then

            If (MessageBox.Show("Esta seguro que desea Modificar ?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                objusuarios1.modifica_usuario_set(Me.Usercontrol1.txbCedula.Text.Trim, Me.Usercontrol1.txbNombre.Text.Trim, Me.Usercontrol1.txbApellido.Text.Trim, Me.Usercontrol1.txbDireccion.Text.Trim, Me.Usercontrol1.txbTelefono.Text.Trim, Me.txtcontraseña.Text.Trim, Me.txtuser.Text.Trim)
                MessageBox.Show("Registro Actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
                inicializa_objusuarios1()
            End If
        Else
            MessageBox.Show("Se necesitan todos los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Usercontrol1.txbNombre.Focus()
        End If
    End Sub


    Private Sub btnconsuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsuser.Click
        Dim consultausuario As frm_consulta_usuario = New frm_consulta_usuario()
        consultausuario.ShowDialog()
        llenardatos()
    End Sub
    Private Sub llenardatos()
        If objusuarios1.cedula1 <> Nothing Then
            Me.Usercontrol1.txbCedula.Enabled = False
            Me.txtuser.Enabled = False
            Me.tlsmodificar.Enabled = True
            Me.tlsbeliminar.Enabled = True

            Me.tlsgrabar.Enabled = False

        End If
        Me.Usercontrol1.txbCedula.Text = objusuarios1.cedula1
        Me.Usercontrol1.txbNombre.Text = objusuarios1.nombre
        Me.Usercontrol1.txbApellido.Text = objusuarios1.apellido
        Me.Usercontrol1.txbDireccion.Text = objusuarios1.direccion
        Me.Usercontrol1.txbTelefono.Text = objusuarios1.telefono
        Me.txtuser.Text = objusuarios1.usuario
        Me.txtcontraseña.Text = objusuarios1.contrasena

    End Sub




    Private Sub inacializa_boton_true()
        Me.Usercontrol1.txbCedula.Enabled = True
        Me.txtuser.Enabled = True
        Me.Usercontrol1.txbCedula.Focus()
        Me.tlsgrabar.Enabled = True
        Me.tlsmodificar.Enabled = False
        Me.tlsbeliminar.Enabled = False
        Me.tlsnuevo.Enabled = False

    End Sub
    Private Sub tlsbeliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsbeliminar.Click
        If (MessageBox.Show("Esta seguro que desea borrar al Usuario", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.objusuario = New usuarios
            If (objusuario.borrar_usuario(Me.Usercontrol1.txbCedula.Text.Trim)) Then
                limpiar()
                inacializa_boton_cancelar()
                inicializa_objusuarios1()

            Else
                MessageBox.Show("No se pudo eliminar el usuario !", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub


    Private Sub tlsborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsborrar.Click
        limpiar()
        inacializa_boton_cancelar()
        inicializa_objusuarios1()
    End Sub
    Private Sub inacializa_boton_cancelar()
        Me.Usercontrol1.txbCedula.Enabled = True
        Me.txtuser.Enabled = True
        Me.Usercontrol1.txbCedula.Focus()
        Me.tlsgrabar.Enabled = True
        Me.tlsmodificar.Enabled = False
        Me.tlsbeliminar.Enabled = False
        Me.tlsnuevo.Enabled = True
        Me.tlsgrabar.Enabled = False
    End Sub
    Private Sub limpiar()

        Me.Usercontrol1.txbNombre.Text = ""
        Me.Usercontrol1.txbApellido.Text = ""
        Me.Usercontrol1.txbCedula.Text = ""
        Me.Usercontrol1.txbTelefono.Text = ""
        Me.Usercontrol1.txbDireccion.Text = ""
        Me.txtcontraseña.Text = ""
        Me.txtuser.Text = ""
        Me.txtrepcontraseña.Text = ""
        Me.tlsmodificar.Enabled = False
        Me.tlsbeliminar.Enabled = False

    End Sub
    Private Sub tlsnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsnuevo.Click
        inicializa_boton_nuevo()

    End Sub
    Private Sub inicializa_boton_nuevo()
        limpiar()
        inacializa_boton_true()
        inicializa_objusuarios1()
    End Sub


    Private Sub inicializa_objusuarios()
        objusuario.cedula1 = Nothing
        objusuario.nombre = Nothing
        objusuario.apellido = Nothing
        objusuario.direccion = Nothing
        objusuario.telefono = Nothing
        objusuario.usuario = Nothing
        objusuario.contrasena = Nothing

    End Sub
    'funcion que encera el objeto para que no se coloque en los controles despues de borrarlos
    'este objeto es alto alcance es por eso que se encera al borrar,limpiar u modificar el reistro
    Private Sub inicializa_objusuarios1()
        objusuarios1.cedula1 = Nothing
        objusuarios1.nombre = Nothing
        objusuarios1.apellido = Nothing
        objusuarios1.direccion = Nothing
        objusuarios1.telefono = Nothing
        objusuarios1.usuario = Nothing
        objusuarios1.contrasena = Nothing
    End Sub
End Class