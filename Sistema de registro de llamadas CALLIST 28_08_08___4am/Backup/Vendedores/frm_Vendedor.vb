Public Class frm_Vendedor
    Public vendedores As csvendedores = New csvendedores()
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.btnAceptar.Enabled = False
        Me.btnBorrar.Enabled = True
        Me.btnModificar.Enabled = False
        Me.btnNuevo.Enabled = True
        Me.txtCodigo.Enabled = True
        limpiar_datos()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        If MsgBox("¿Esta seguro de salir? ", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Advertencia del Sistema") = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub frm_Vendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnAceptar.Enabled = False
        Me.btnModificar.Enabled = False
        Dim conexion1 As sqljoin = New sqljoin
        Dim item As ListViewItem
        Dim reader As SqlClient.SqlDataReader
        Try
            reader = conexion1.traerDataReader("Select codigo, nombre,comision from vendedores")
            While (reader.Read())
                item = New ListViewItem(reader.GetInt32(0))
                item.SubItems.Add(reader.GetString(1))
                item.SubItems.Add(reader.GetInt32(2))
                Me.lsvVendedores.Items.Add(item)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Public Sub limpiar_datos()
        Me.txtCodigo.Text = ""
        Me.txtComision.Text = ""
        Me.txtNombre.Text = ""
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiar_datos()
        Me.txtCodigo.Enabled = True
        Me.btnAceptar.Enabled = True
        Me.btnBorrar.Enabled = True
        Me.btnNuevo.Enabled = False
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        ingresar_datos()

    End Sub
    Private Sub ingresar_datos()

        If (Me.btnModificar.Enabled = False And Me.txtCodigo.Enabled = True) Then
            If (txtComision.Text.Trim = "" Or txtCodigo.Text.Trim = "" Or txtNombre.Text.Trim = "") Then
                MessageBox.Show("Favor ingrese todos los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.txtCodigo.Focus()
            Else

                'valida que lo in en el ctrol sea el num de cedula
                If Me.txtCodigo.Text.Length = 10 Then

                    If vendedores.valida_vendedor(Me.txtCodigo.Text.Trim) = False Then
                        If vendedores.nuevo_vendedor(Me.txtCodigo.Text.Trim, Me.txtNombre.Text.Trim, Me.txtComision.Text.Trim) Then
                            Dim item As ListViewItem
                            item = New ListViewItem(Me.txtCodigo.Text)
                            item.SubItems.Add(Me.txtNombre.Text)
                            item.SubItems.Add(Me.txtComision.Text)
                            Me.lsvVendedores.Items.Add(item)
                            Me.btnAceptar.Enabled = False
                        Else

                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("El numero de cedula esta repetido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtCodigo.Focus()
                    End If
                Else
                    'en caso de que los num in en el ctrol no sean los 10
                    MessageBox.Show("Por favor Ingrese bien la cedula", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtCodigo.Focus()
                    Exit Sub
                End If

                limpiar_datos()

            End If
        Else
            'este procedimiento es cuando vamos a modificar  y damos despues en aceptar validamos
            'para que in 
            If (txtComision.Text.Trim = "" Or txtCodigo.Text.Trim = "" Or txtNombre.Text.Trim = "") Then
                MessageBox.Show("Favor ingrese todos los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.txtCodigo.Focus()
                Exit Sub
            Else

                If vendedores.modificar_vendedor(Me.txtCodigo.Text.Trim, Me.txtNombre.Text.Trim, Me.txtComision.Text.Trim) Then
                    Try
                        Me.lsvVendedores.SelectedItems(0).SubItems(0).Text = Me.txtCodigo.Text.Trim
                        Me.lsvVendedores.SelectedItems(0).SubItems(1).Text = Me.txtNombre.Text.Trim
                        Me.lsvVendedores.SelectedItems(0).SubItems(2).Text = Me.txtComision.Text.Trim
                        Me.btnAceptar.Enabled = False
                    Catch ex As Exception

                    End Try
                Else
                    Exit Sub
                End If
                limpiar_datos()
            End If
        End If
        Me.btnNuevo.Enabled = True
        Me.btnModificar.Enabled = False
        Me.btnBorrar.Enabled = True
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Me.txtCodigo.Enabled = False
        Me.btnModificar.Enabled = False
        Me.btnAceptar.Enabled = True
        Me.btnBorrar.Enabled = False

    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

        If (MessageBox.Show("Esta seguro que desea eliminar ?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
            Exit Sub
        End If

        If (Me.txtCodigo.Text.Trim <> "") Then
            If vendedores.borrar_vendedor(Me.txtCodigo.Text.Trim) Then
                Me.lsvVendedores.Items.Clear()
                limpiar_datos()
                Me.lsvVendedores.Items.Clear()
                Me.lsvVendedores.Items.Clear()
                Dim conexion1 As sqljoin = New sqljoin
                Dim item As ListViewItem
                Dim reader As SqlClient.SqlDataReader

                Try
                    reader = conexion1.traerDataReader("Select codigo, nombre,comision from vendedores")
                    While (reader.Read())
                        item = New ListViewItem(reader.GetInt32(0))
                        item.SubItems.Add(reader.GetString(1))
                        item.SubItems.Add(reader.GetInt32(2))
                        Me.lsvVendedores.Items.Add(item)
                    End While
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Para eliminar un registro debe seleccionar un vendedor", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        End If
    End Sub

    Private Sub lsvVendedores_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsvVendedores.MouseUp
        Try
            Me.txtCodigo.Text = Me.lsvVendedores.SelectedItems(0).SubItems(0).Text
            Me.txtNombre.Text = Me.lsvVendedores.SelectedItems(0).SubItems(1).Text
            Me.txtComision.Text = Me.lsvVendedores.SelectedItems(0).SubItems(2).Text
            Me.txtCodigo.Enabled = False
            Me.btnModificar.Enabled = True
            Me.btnNuevo.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

   

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        Dim objvalidaciones As New clsvalidaciones
        objvalidaciones.validar_numeros(e) 'valida que los num in sean solo numerico

        If (Microsoft.VisualBasic.AscW((e.KeyChar)) <> 8) Then
            If (Me.txtCodigo.Text.Trim.Length >= 10) Then
                e.Handled = True
            End If

        End If

    End Sub

    Private Sub txtComision_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtComision.KeyPress
        Dim objvalidaciones As New clsvalidaciones
        objvalidaciones.validar_numeros(e) 'valida que los num in sean solo numerico

        If (Microsoft.VisualBasic.AscW(e.KeyChar) = 13) Then
            If (MessageBox.Show("Desea grabar vendedor ?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes) Then
                ingresar_datos()
            End If
        End If
    End Sub


    Private Sub txtComision_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComision.TextChanged

    End Sub
End Class