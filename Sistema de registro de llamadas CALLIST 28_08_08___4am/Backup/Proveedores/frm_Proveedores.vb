Public Class frm_Proveedores
    Public cs_proveedor As cs_Proveedores = New cs_Proveedores()
    Private _dtEstados1 As DataTable
    Private Sub frm_Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenar_proveedores()
    End Sub
    
    Private Sub lvsproveedores_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvsproveedores.DoubleClick
        Try
            llenardatos()
            Me.TabControl1.SelectedIndex = 1
            Me.modificar.Enabled = True
            Me.aceptar.Enabled = False
            Me.nuevo.Enabled = True
            Me.borrar.Enabled = True
            Me.txtcodigo.Enabled = False

        Catch ex As Exception
        End Try
    End Sub
    Public Sub llenardatos()
        Dim sql As sqljoin = New sqljoin
        Dim reader As SqlClient.SqlDataReader
        Try
            reader = sql.traerDataReader("select * from proveedores where codigo='" & Me.lvsproveedores.SelectedItems(0).SubItems(0).Text & "'")
            reader.Read()
            Me.txtcodigo.Text = reader.GetString(0)
            Me.txtnombre.Text = reader.GetString(1)
            Me.txtdireccion.Text = reader.GetString(2)
            Me.txtciudad.Text = reader.GetString(3)
            Me.txtfono1.Text = reader.GetString(4)
            Me.txtfono2.Text = reader.GetString(5)
            Me.txtpais.Text = reader.GetString(6)
            Me.txtobservaciones.Text = reader.GetString(7)
            Me.txtemail.Text = reader.GetString(8)
            Me.txtactividad.Text = reader.GetString(9)
            Me.txtcargo.Text = reader.GetString(10) ' si funciona bien la fecha
            Me.dtpFechaimportante.Value = reader.GetValue(11)
            Me.Cmbpago.SelectedValue = reader.GetInt32(12)
        Catch ex As Exception
            If exepciones = 1 Then
                MessageBox.Show(ex.Message)
            End If
            Me.borrar.Enabled = True
            Me.aceptar.Enabled = False
            Me.modificar.Enabled = True
        End Try
    End Sub

    Private Sub lvsproveedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvsproveedores.SelectedIndexChanged

    End Sub

    Private Sub txtfono1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfono1.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> 8) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtfono2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfono2.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> 8) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If (Char.IsNumber(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> 8) Then
            e.Handled = True

        End If
    End Sub

    Private Sub modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modificar.Click
        If (Me.txtcodigo.Text.Trim <> "" And Me.txtnombre.Text.Trim <> "" And Me.txtfono1.Text.Trim <> "" And Me.txtciudad.Text.Trim <> "" And Me.txtemail.Text.Trim <> "" And Me.txtpais.Text.Trim <> "" And Me.txtdireccion.Text.Trim <> "" And Me.txtcargo.Text.Trim <> "") Then

            If cs_proveedor.modifica_proveedor(Me.txtcodigo.Text.Trim, Me.txtnombre.Text.Trim, Me.txtdireccion.Text.Trim, Me.txtciudad.Text.Trim, Me.txtfono1.Text.Trim, Me.txtfono2.Text.Trim, Me.txtpais.Text.Trim, Me.txtobservaciones.Text.Trim, Me.txtemail.Text.Trim, Me.txtcargo.Text.Trim, Me.txtactividad.Text.Trim, Me.dtpFechaimportante.Text, Me.Cmbpago.SelectedValue) Then

                limpiardatos()
                llenar_proveedores()
            Else
                Exit Sub
            End If
        Else
            MsgBox("Ingrese todos los datos")
            Me.txtnombre.Focus()
            MessageBox.Show("Se necesitan todos los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub
    Public Sub llenar_proveedores()
        Dim conexion As New sqljoin
        Dim conexion1 As sqljoin = New sqljoin
        Dim item As ListViewItem
        Dim reader As SqlClient.SqlDataReader
        Me.lvsproveedores.Items.Clear()
        Try
            reader = conexion1.traerDataReader("Select codigo,nombre,direccion,telefono from proveedores")
            While (reader.Read())


                item = New ListViewItem(reader.GetString(0))
                item.SubItems.Add(reader.GetString(1))
                item.SubItems.Add(reader.GetString(2))
                item.SubItems.Add(reader.GetString(3))

                Me.lvsproveedores.Items.Add(item)
            End While


            ' Llena el data table con los registros obtenidos del query
            _dtEstados1 = conexion.devolverDatosEnDataTable("Select tipopago,codpago from tipo_pago_proveedor")

            Me.Cmbpago.DataSource = Me._dtEstados1 ' Establece el origen de datos del combo a los registros obtenidos del query
            Me.Cmbpago.ValueMember = "codpago"
            Me.Cmbpago.DisplayMember = "tipopago" 'Campo del query que debe mostrarse en el combo
            Me.Cmbpago.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub limpiardatos()
        Me.txtcodigo.Text = ""
        Me.txtnombre.Text = ""
        Me.txtactividad.Text = ""
        Me.txtcargo.Text = ""
        Me.txtciudad.Text = ""
        Me.txtdireccion.Text = ""
        Me.txtemail.Text = ""
        Me.txtfono1.Text = ""
        Me.txtfono2.Text = ""
        Me.txtobservaciones.Text = ""
        Me.txtpais.Text = ""
        Me.Cmbpago.Text = ""
        Me.modificar.Enabled = False
        Me.aceptar.Enabled = False
        Me.nuevo.Enabled = True
        Me.borrar.Enabled = False
        Me.txtcodigo.Enabled = False
        Me.dtpFechaimportante.Text = Date.Today
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiardatos()
    End Sub

    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click
        Me.aceptar.Enabled = True
        Me.borrar.Enabled = False
        Me.txtcodigo.Enabled = True
        Me.nuevo.Enabled = False
        Me.modificar.Enabled = False
        Me.txtcodigo.Text = ""
        Me.txtnombre.Text = ""
        Me.txtactividad.Text = ""
        Me.txtcargo.Text = ""
        Me.txtciudad.Text = ""
        Me.txtdireccion.Text = ""
        Me.txtemail.Text = ""
        Me.txtfono1.Text = ""
        Me.txtfono2.Text = ""
        Me.txtobservaciones.Text = ""
        Me.txtpais.Text = ""
    End Sub

    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aceptar.Click
        If (Me.txtcodigo.Text.Trim <> "" And Me.txtnombre.Text.Trim <> "" And Me.txtfono1.Text.Trim <> "" And Me.txtciudad.Text.Trim <> "" And Me.txtemail.Text.Trim <> "" And Me.txtpais.Text.Trim <> "" And Me.txtdireccion.Text.Trim <> "" And Me.txtcargo.Text.Trim <> "") Then
            If Me.txtcodigo.Text.Length = 10 Then 'valida el numero de cedula
                If (objusuarios.Verifica_IDcodigo("proveedores", Me.txtcodigo.Text.Trim)) Then
                    If cs_proveedor.ingresa_proveedor(Me.txtcodigo.Text.Trim, Me.txtnombre.Text.Trim, Me.txtdireccion.Text.Trim, Me.txtciudad.Text.Trim, Me.txtfono1.Text.Trim, Me.txtfono2.Text.Trim, Me.txtpais.Text.Trim, Me.txtobservaciones.Text.Trim, Me.txtemail.Text.Trim, Me.txtcargo.Text.Trim, Me.txtactividad.Text.Trim, Me.dtpFechaimportante.Value.Date, Me.Cmbpago.SelectedValue) Then
                        limpiardatos()
                        llenar_proveedores()
                    Else
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("El codigo ya existe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.txtcodigo.Focus()
                End If
            Else
                MessageBox.Show("Por favor Ingrese bien la cedula", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtcodigo.Focus()
            End If
        Else
            Me.txtnombre.Focus()
            MessageBox.Show("Se necesitan todos los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If


    End Sub

    Private Sub borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles borrar.Click
        If (MsgBox("Esta seguro que desea borrar al Proveedor", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            If (cs_proveedor.borrar_proveedor(Me.txtcodigo.Text.Trim)) Then
                Me.limpiardatos()
                Me.borrar.Enabled = False
                Me.aceptar.Enabled = False
                Me.modificar.Enabled = False
                Me.nuevo.Enabled = True
                llenar_proveedores()
            Else
                MsgBox("No se pudo borrar al proveedor intente de nuevo")
            End If
        End If
    End Sub

    Private Sub salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click
        If MsgBox("¿Esta seguro de salir? ", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Advertencia del Sistema") = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub txtcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
        Dim objvalidaciones As New clsvalidaciones

        objvalidaciones.validar_numeros(e)

        If (Microsoft.VisualBasic.AscW((e.KeyChar)) <> 8) Then
            If (Me.txtcodigo.Text.Trim.Length >= 10) Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodigo.TextChanged

    End Sub
End Class