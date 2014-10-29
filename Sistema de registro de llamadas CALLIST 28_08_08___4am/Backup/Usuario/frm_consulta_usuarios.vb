Public Class frm_consulta_usuario

    Private Sub frm_consulta_usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenar_lista()

    End Sub
    Public Sub llenar_lista()
        Dim conexion As SQLjoin = New SQLjoin
        Dim item As ListViewItem
        Dim reader As SqlClient.SqlDataReader
        Dim contador As Integer = 0
        Me.lsvuser.Items.Clear()

        Try
            reader = conexion.traerDataReader("Select * from usuarios order by nombre asc")
            While (reader.Read())

                contador = contador + 1
                item = New ListViewItem(contador.ToString())
                item.SubItems.Add(reader.GetValue(0).ToString)
                item.SubItems.Add(reader.GetString(1))
                item.SubItems.Add(reader.GetString(2))
                item.SubItems.Add(reader.GetString(3))
                item.SubItems.Add(reader.GetString(4))
                item.SubItems.Add(reader.GetString(5))
                item.SubItems.Add(reader.GetString(6))

                Me.lsvuser.Items.Add(item)

            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lsvuser_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvuser.DoubleClick

        Try


            objusuarios1.cedula1 = Me.lsvuser.SelectedItems(0).SubItems(1).Text
            objusuarios1.nombre = Me.lsvuser.SelectedItems(0).SubItems(2).Text
            objusuarios1.apellido = Me.lsvuser.SelectedItems(0).SubItems(3).Text
            objusuarios1.telefono = Me.lsvuser.SelectedItems(0).SubItems(4).Text
            objusuarios1.direccion = Me.lsvuser.SelectedItems(0).SubItems(5).Text
            objusuarios1.usuario = Me.lsvuser.SelectedItems(0).SubItems(6).Text
            objusuarios1.contrasena = Me.lsvuser.SelectedItems(0).SubItems(7).Text

        Catch ex As Exception
        End Try
        Me.Dispose()
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        salir()
    End Sub
    Public Sub salir()

        If (MessageBox.Show("Desea salir de la opcion?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes) Then
            Me.Dispose()
        End If

    End Sub

    Private Sub lsvuser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvuser.SelectedIndexChanged

    End Sub
End Class