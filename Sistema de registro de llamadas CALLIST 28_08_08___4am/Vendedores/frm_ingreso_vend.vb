Imports System.Windows.Forms


Public Class frm_ingreso_vend
    Private conexion As New sqljoin
    Public vendedores As csvendedores = New csvendedores()



    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If validar_datos() = False Then
            MessageBox.Show("Ingrese datos por favor", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If vendedores.valida_vendedor(Me.txtcodigo.Text.Trim) Then
            If Me.cmbvendedores.SelectedValue.ToString = Me.txtcodigo.Text.Trim Then
                MessageBox.Show("Codigo Correcto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                glb_name_vendedor = Me.cmbvendedores.Text.ToString   'cargo el nombre del vendedor
                'encero controles y cierro la ventana
                cod_vendedor = 0
                glb_cod_vendedor = CInt(Me.txtcodigo.Text.Trim)
                Me.Dispose()
            Else
                MessageBox.Show("Clave incorrecta, Favor ingrese bien la clave", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.txtcodigo.Focus()
            End If
        Else
            MsgBox("Codigo Incorrecto")
            Me.txtcodigo.Text = ""
            Me.txtcodigo.Focus()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()


    End Sub

    Private Sub frm_ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _dtEstados As DataTable
        Me.cmbvendedores.DataSource = Nothing
        Me.cmbvendedores.Items.Clear()

        _dtEstados = conexion.devolverDatosEnDataTable("Select nombre,codigo from vendedores")

        Me.cmbvendedores.DataSource = _dtEstados '
        Me.cmbvendedores.ValueMember = "codigo"
        Me.cmbvendedores.DisplayMember = "nombre" 'Campo del query que debe mostrarse en el combo
        Me.cmbvendedores.SelectedIndex = -1
        Me.txtcodigo.Focus()



    End Sub
    Private Function validar_datos() As Boolean
        If Me.cmbvendedores.SelectedIndex = -1 Or Me.txtcodigo.Text = "" Then
            Return False
        Else
            Return True
        End If

    End Function


    Private Sub txtcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodigo.TextChanged

    End Sub
End Class
