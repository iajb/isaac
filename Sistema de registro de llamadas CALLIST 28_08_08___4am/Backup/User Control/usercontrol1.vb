Public Class usercontrol
    Dim objvalidaciones As New clsvalidaciones
    Private Sub txbCedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbCedula.KeyPress
        objvalidaciones.validar_numeros(e)

        If (Microsoft.VisualBasic.AscW((e.KeyChar)) <> 8) Then
            If (Me.txbCedula.Text.Trim.Length >= 10) Then
                e.Handled = True
            End If
        End If

    End Sub


    Private Sub txbNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbNombre.KeyPress
        'objvalidaciones.validar_letras(e)
    End Sub


    Private Sub txbApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbApellido.KeyPress
        'objvalidaciones.validar_letras(e)
    End Sub

    Private Sub txbTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbTelefono.KeyPress
        objvalidaciones.validar_numeros(e)
    End Sub

    Private Sub txbNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbNombre.TextChanged

    End Sub

    Private Sub usercontrol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txbCedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbCedula.TextChanged

    End Sub
End Class
