Public Class frm_desencriptar

    Dim conexion As sqljoin = New sqljoin
    Dim variables As New encriptaciones
    Dim objvalidaciones As New clsvalidaciones
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndesencriptar.Click
        Dim contraseña As String
        Dim reader As SqlClient.SqlDataReader
        If Me.txtcedula.Text = "" Then
            Exit Sub
        End If
        reader = conexion.traerDataReader("Select * from usuarios where coduser=" & Me.txtcedula.Text & "")
        contraseña = ""
        If (reader.HasRows) Then

            While (reader.Read())
                contraseña = reader.GetString(6).ToString()
            End While
        End If

        Me.txtdesencriptar.Text = Me.variables.Desencripta(contraseña)
    End Sub

    Private Sub frmdesencriptar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        If (MessageBox.Show("desea salir de la opcion?", "Callist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Try
                Me.Dispose()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub frm_desencriptar_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        If Me.Location.Y <= 71 Then
            Me.Location = New Point(Me.Location.X, 71)
        End If
    End Sub

    Private Sub txtcedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcedula.KeyPress

        objvalidaciones.validar_numeros(e)

        If (Microsoft.VisualBasic.AscW((e.KeyChar)) <> 8) Then
            If (Me.txtcedula.Text.Trim.Length >= 10) Then
                e.Handled = True
            End If
        End If

        Dim KeyAscii As Short = Asc(e.KeyChar)

        If KeyAscii = 13 Then

            btndesencriptar.Focus()
        End If
    End Sub

    Private Sub txtcedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcedula.TextChanged

    End Sub
End Class