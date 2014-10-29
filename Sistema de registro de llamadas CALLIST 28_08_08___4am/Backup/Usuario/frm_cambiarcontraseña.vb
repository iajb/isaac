Public Class frm_cambiarcontraseña
    Inherits System.Windows.Forms.Form
    Private objusuario As usuario

    Public Sub New(ByRef objusuario As usuario)
        MyBase.New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.objusuario = objusuario

    End Sub
    Public Function validadatos() As Boolean
        'valida que los datos esten bien ingresados en la clase frmcambiarcontraseña
        If Me.txtcontraseñaactual.Text = "" Or Me.txtcontraseñanueva.Text = "" Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aceptar.Click

        '     If objusuario.numeroVecesCambioContraseña < 1 Then

        If (MessageBox.Show("desea Reemplazar contraseña?", "Callist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then

            If Me.txtcontraseñanueva.Text.Trim = Me.txbrepetircontraseña.Text.Trim Then

                If Me.txbcedula.Text.Length <= 10 Then

                    Me.objusuario.usercontraseña = Me.txtcontraseñaactual.Text.Trim
                    Me.objusuario.cedula = Me.txbcedula.Text.Trim

                    If (validacelula()) Then

                        If objusuario.validacontraseña() Then
                            Me.objusuario.usercontraseña = Me.txtcontraseñanueva.Text.Trim
                            Me.objusuario.modificacionusuario()

                            MessageBox.Show("Se ha realizado el cambio de manera exitosa", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Dispose()
                        Else
                            MsgBox("Contraseña ingresada incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    Else

                        MessageBox.Show("No se puede cambiar contraseña, datos incorrectos", "Cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.txbcedula.Focus()

                    End If

                Else

                    MessageBox.Show("Número de cédula no valido", "Cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txbcedula.Focus()

                End If

            Else

                MessageBox.Show("Las Contraseñas deben de ser iguales", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.txbrepetircontraseña.Focus()

            End If
        End If
       

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        If (MessageBox.Show("desea salir ?", "Callist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Dispose()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbcedula.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> 8) Then
            e.Handled = True

        End If

    End Sub
    Public Function validacelula() As Boolean
        If (objusuario.yaExistecedula()) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub frm_cambiarcontraseña_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Private Sub frm_cambiarcontraseña_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        If Me.Location.Y <= 71 Then
            Me.Location = New Point(Me.Location.X, 71)
        End If
    End Sub
End Class