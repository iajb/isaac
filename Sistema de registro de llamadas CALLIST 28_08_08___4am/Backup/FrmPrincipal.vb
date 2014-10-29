
Friend Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Public objusuario As usuario
    Dim objusuario2 As usuario
    Public objauditoria As auditoria_archivos = New auditoria_archivos
    Public frmDesencriptacion As frm_desencriptar
    Public frmVendedores As frm_Vendedor
    Public frmUsuario As frm_cliente

    Public frmproveedores As frm_Proveedores
    Public frmConsultaGeneralUsuarios As frm_consulta_generalusuarios
    Public frmuAuditoriaUsuario As frm_auditoriausuario
    Public frmCambiarContraseña As frm_cambiarcontraseña

    Public frmAcercaDe As frm_acercade
   
    Public frmAuditoria As frm_auditoria_de_archivo

    Public frmingreso_vendedor As frm_ingreso_vend
    Public frmingresouser As frm_inguser

    Private Sub RegistrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrosToolStripMenuItem.Click
        If IsNothing(frmDesencriptacion) Then
            frmDesencriptacion = New frm_desencriptar
            frmDesencriptacion.MdiParent = Me
            frmDesencriptacion.Show()
        Else
            If frmDesencriptacion.IsDisposed Then
                frmDesencriptacion = New frm_desencriptar
                frmDesencriptacion.MdiParent = Me
                frmDesencriptacion.Show()
            Else
                frmDesencriptacion.Focus()
            End If
        End If
    End Sub

   

   

    Private Sub CambiarContraseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click
        If IsNothing(frmCambiarContraseña) Then
            frmCambiarContraseña = New frm_cambiarcontraseña(objusuario)
            frmCambiarContraseña.MdiParent = Me
            frmCambiarContraseña.Show()
        Else
            If frmCambiarContraseña.IsDisposed Then
                frmCambiarContraseña = New frm_cambiarcontraseña(objusuario)
                frmCambiarContraseña.MdiParent = Me
                frmCambiarContraseña.Show()
            Else
                frmCambiarContraseña.Focus()
            End If

        End If
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click

        If IsNothing(frmAcercaDe) Then
            frmAcercaDe = New frm_acercade
            frmAcercaDe.MdiParent = Me
            frmAcercaDe.Show()
        Else
            If frmAcercaDe.IsDisposed Then
                frmAcercaDe = New frm_acercade
                frmAcercaDe.MdiParent = Me
                frmAcercaDe.Show()
            Else
                frmAcercaDe.Focus()
            End If

        End If
    End Sub

    Private Sub AuditoriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If IsNothing(frmAuditoria) Then
            frmAuditoria = New frm_auditoria_de_archivo
            frmAuditoria.MdiParent = Me
            frmAuditoria.Show()
        Else
            If frmAuditoria.IsDisposed Then
                frmAuditoria = New frm_auditoria_de_archivo
                frmAuditoria.MdiParent = Me
                frmAuditoria.Show()
            Else
                frmAuditoria.Focus()
            End If

        End If
    End Sub
    Private Sub ConsultaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNothing(frmConsultaGeneralUsuarios) Then
            frmConsultaGeneralUsuarios = New frm_consulta_generalusuarios
            frmConsultaGeneralUsuarios.MdiParent = Me
            frmConsultaGeneralUsuarios.Show()
        Else
            If frmConsultaGeneralUsuarios.IsDisposed Then
                frmConsultaGeneralUsuarios = New frm_consulta_generalusuarios
                frmConsultaGeneralUsuarios.MdiParent = Me
                frmConsultaGeneralUsuarios.Show()
            Else
                frmConsultaGeneralUsuarios.Focus()
            End If

        End If
    End Sub

    Private Sub AuditoriaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNothing(frmuAuditoriaUsuario) Then
            frmuAuditoriaUsuario = New frm_auditoriausuario
            frmuAuditoriaUsuario.MdiParent = Me
            frmuAuditoriaUsuario.Show()
        Else
            If frmuAuditoriaUsuario.IsDisposed Then
                frmuAuditoriaUsuario = New frm_auditoriausuario
                frmuAuditoriaUsuario.MdiParent = Me
                frmuAuditoriaUsuario.Show()
            Else
                frmuAuditoriaUsuario.Focus()
            End If

        End If
    End Sub



    Private Sub NuevoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
       
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_cliente" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next
        Dim formacliente As frm_cliente = New frm_cliente
        formacliente.MdiParent = Me
        formacliente.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        

        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_acercade" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next
        Dim ayuda As frm_acercade = New frm_acercade
        ayuda.MdiParent = Me
        ayuda.Show()
    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarContraseñaToolStripMenuItem1.Click
        If IsNothing(frmCambiarContraseña) Then
            frmCambiarContraseña = New frm_cambiarcontraseña(objusuario)
            frmCambiarContraseña.MdiParent = Me
            frmCambiarContraseña.Show()
        Else
            If frmCambiarContraseña.IsDisposed Then
                frmCambiarContraseña = New frm_cambiarcontraseña(objusuario)
                frmCambiarContraseña.MdiParent = Me
                frmCambiarContraseña.Show()
            Else
                frmCambiarContraseña.Focus()
            End If

        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click

        If MsgBox("¿ Esta seguro de salir del Sistema? ", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Advertencia del Sistema") = MsgBoxResult.Yes Then
            Me.Dispose()

        End If
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendedoresToolStripMenuItem.Click
        
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_Vendedor" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formavendedor As frm_Vendedor = New frm_Vendedor
        formavendedor.MdiParent = Me
        formavendedor.Show()
    End Sub

   

    Private Sub ProovedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProovedoresToolStripMenuItem.Click

        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_Proveedores" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formaProveedores As frm_Proveedores = New frm_Proveedores
        formaProveedores.MdiParent = Me
        formaProveedores.Show()
    End Sub



    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        If IsNothing(frmDesencriptacion) Then
            frmDesencriptacion = New frm_desencriptar
            frmDesencriptacion.MdiParent = Me
            frmDesencriptacion.Show()
        Else
            If frmDesencriptacion.IsDisposed Then
                frmDesencriptacion = New frm_desencriptar
                frmDesencriptacion.MdiParent = Me
                frmDesencriptacion.Show()
            Else
                frmDesencriptacion.Focus()
            End If

        End If
    End Sub

    

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click

        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_inguser" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formausuario As frm_inguser = New frm_inguser
        formausuario.MdiParent = Me
        formausuario.Show()
    End Sub

    Private Sub UsuariosDelSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosDelSistemaToolStripMenuItem.Click
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frmrepuser" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formarepuser As frmrepuser = New frmrepuser
        formarepuser.MdiParent = Me
        formarepuser.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frmrepproveedor" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formarepproveedor As frmrepproveedor = New frmrepproveedor
        formarepproveedor.MdiParent = Me
        formarepproveedor.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frmrepcliente" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formarepcliente As frmrepcliente = New frmrepcliente
        formarepcliente.MdiParent = Me
        formarepcliente.Show()
    End Sub

    Private Sub VendedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendedoresToolStripMenuItem1.Click
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frmrepvendedor" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formarepvendedor As frmrepvendedor = New frmrepvendedor
        formarepvendedor.MdiParent = Me
        formarepvendedor.Show()
    End Sub

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.sthora.Text = ""
        Me.stnombre.Text = ""
        ventanalogin()
    End Sub
    Public Sub ventanalogin()
        Me.objusuario2 = New usuario
        Dim login As frmlogin2 = New frmlogin2(Me.objusuario2)
        If (login.ShowDialog() = Windows.Forms.DialogResult.Cancel) Then
            Application.Exit()
        Else
            iniciar_sesion()
            proceso_verifica_cumple_clientes() 'verifica si algun cliente esta cerca su cumple
        End If

    End Sub
    'verifica si algun cliente esta cerca su cumple

    Private Sub proceso_verifica_cumple_clientes()
        Dim objcliente As usuario = New usuario
        Dim var_numcumplecli As Integer = 0
        var_numcumplecli = objcliente.cons_cli_fecha_nac("clientes")
        If var_numcumplecli <> 0 Then
            'Me.stcumplecli.Text = "                                                                                                                                                                                    Personas que cumplen años hoy :  " & var_numcumplecli
        End If
        'Me.stcumplecli.Text = " Personas que cumplean años? :  " & var_numcumplecli
    End Sub

    Public Sub iniciar_sesion()
        Me.sthora.Text = Today()
        Me.stnombre.Text = " Bienvenido:  " & Me.objusuario2.nombre & "    Fecha: "
    End Sub

    Private Sub tlsayuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsayuda.Click

        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_acercade" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim ayuda As frm_acercade = New frm_acercade
        ayuda.MdiParent = Me
        ayuda.Show()


    End Sub

    Private Sub tlsmclientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsmclientes.Click

        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_cliente" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formacliente As frm_cliente = New frm_cliente
        formacliente.MdiParent = Me
        formacliente.Show()

    End Sub

    Private Sub tlsusuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsusuario.Click

        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_inguser" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formausuario As frm_inguser = New frm_inguser
        formausuario.MdiParent = Me
        formausuario.Show()

    End Sub

    Private Sub tlsmproveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsmproveedores.Click
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_Proveedores" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formaProveedores As frm_Proveedores = New frm_Proveedores
        formaProveedores.MdiParent = Me
        formaProveedores.Show()
    End Sub

    Private Sub tlsmvendedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsmvendedores.Click
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_Vendedor" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formavendedor As frm_Vendedor = New frm_Vendedor
        formavendedor.MdiParent = Me
        formavendedor.Show()
    End Sub

  

    

    Private Sub tlsusers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsusers.Click
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frmrepuser" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formarepuser As frmrepuser = New frmrepuser
        formarepuser.MdiParent = Me
        formarepuser.Show()
    End Sub

    Private Sub tlsrclientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsrclientes.Click
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frmrepcliente" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formarepcliente As frmrepcliente = New frmrepcliente
        formarepcliente.MdiParent = Me
        formarepcliente.Show()
    End Sub

    Private Sub tlsrproveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsrproveedores.Click
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frmrepproveedor" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formarepproveedor As frmrepproveedor = New frmrepproveedor
        formarepproveedor.MdiParent = Me
        formarepproveedor.Show()
    End Sub

    Private Sub tlsrvendedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsrvendedores.Click
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frmrepvendedor" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formarepvendedor As frmrepvendedor = New frmrepvendedor
        formarepvendedor.MdiParent = Me
        formarepvendedor.Show()
    End Sub

    Private Sub tlssalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlssalir.Click

        If MsgBox("¿ Esta seguro de salir del Sistema? ", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Advertencia del Sistema") = MsgBoxResult.Yes Then
            Me.Dispose()

        End If
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tlsdreportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsdreportes.Click

    End Sub


   

    Private Sub BancosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BancosToolStripMenuItem1.Click

        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_bancos" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formabancos As frm_bancos = New frm_bancos
        formabancos.MdiParent = Me
        formabancos.Show()
    End Sub

    Private Sub ConsultaDeBancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeBancosToolStripMenuItem.Click
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_cons_bancos" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formaconsbancos As frm_cons_bancos = New frm_cons_bancos
        formaconsbancos.MdiParent = Me
        formaconsbancos.Show()
    End Sub




    Private Sub ActivaVendedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_ingreso_vend" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formaingvendedor As frm_ingreso_vend = New frm_ingreso_vend
        formaingvendedor.MdiParent = Me
        formaingvendedor.Show()
    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_ingreso_vend" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formaingvendedor As frm_ingreso_vend = New frm_ingreso_vend
        formaingvendedor.MdiParent = Me
        formaingvendedor.Show()
    End Sub


    Private Sub tlsbbancos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsbbancos.Click
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_bancos" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formabancos As frm_bancos = New frm_bancos
        formabancos.MdiParent = Me
        formabancos.Show()
    End Sub





    Private Sub RegistraInventarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistraInventarioToolStripMenuItem.Click
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_registrocampaña" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formacobranzas As frm_registrocampaña = New frm_registrocampaña
        formacobranzas.MdiParent = Me
        formacobranzas.Show()
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsregcob.Click
        For Each forma As Form In Me.MdiChildren

            If forma.Name = "frm_registrocampaña" Then
                MessageBox.Show("La ventana ya se encuentra abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        Dim formacobranzas As frm_registrocampaña = New frm_registrocampaña
        formacobranzas.MdiParent = Me
        formacobranzas.Show()
    End Sub

End Class