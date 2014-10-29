Imports System.Data
Public Class frm_consulta_generalusuarios

    Inherits System.Windows.Forms.Form

    Public objcliente As persona = New persona
    Public objusuario As usuario = New usuario
    Public Sub New()
        MyBase.new()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.objcliente = objcliente
        Me.objusuario = objusuario
    End Sub
    Private Sub frm_consulta_generalusuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenardatalist()
    End Sub
    'metodo que permite filtrar datos en el data list
    Public Sub llenardatalist()
        Dim conexion As sqljoin = New sqljoin
        Dim item As ListViewItem
        Dim reader As SqlClient.SqlDataReader
        Dim contador As Integer = 0
        Me.lsvusuarios.Items.Clear()
        reader = conexion.traerDataReader("Select cedula,nombre,apellido ,telefono,direccion ,email,usuario, contraseña,fecha_creacion from usuario order by fecha_creacion,nombre,apellido desc")


        While (reader.Read())

            contador = contador + 1
            item = New ListViewItem(contador.ToString())
            item.SubItems.Add(reader.GetString(0))
            item.SubItems.Add(reader.GetString(1))
            item.SubItems.Add(reader.GetString(2))
            item.SubItems.Add(reader.GetString(3))
            item.SubItems.Add(reader.GetString(4))
            item.SubItems.Add(reader.GetName(5))
            item.SubItems.Add(reader.GetString(6))
            item.SubItems.Add(reader.GetString(7))
            item.SubItems.Add(reader.GetDateTime(8))
            Me.lsvusuarios.Items.Add(item)

        End While
    End Sub

    Private Sub lsvusuarios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvusuarios.DoubleClick
        Try
            Me.objcliente.identificacion = Me.lsvusuarios.SelectedItems(0).SubItems(1).Text
            Me.objcliente.nombre = Me.lsvusuarios.SelectedItems(0).SubItems(2).Text
            Me.objcliente.apellido = Me.lsvusuarios.SelectedItems(0).SubItems(3).Text
            Me.objcliente.telefono = Me.lsvusuarios.SelectedItems(0).SubItems(4).Text
            Me.objcliente.direccion = Me.lsvusuarios.SelectedItems(0).SubItems(5).Text
            Me.objcliente.email = Me.lsvusuarios.SelectedItems(0).SubItems(6).Text
            Me.objusuario.useruser = Me.lsvusuarios.SelectedItems(0).SubItems(7).Text
            Me.objusuario.usercontraseña = Me.lsvusuarios.SelectedItems(0).SubItems(8).Text
            Me.objusuario.usercontraseña = Me.lsvusuarios.SelectedItems(0).SubItems(9).Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    Private Sub lsvusuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvusuarios.SelectedIndexChanged

    End Sub

    Private Sub Salirbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salirbtn.Click
        Me.Dispose()
    End Sub

    Private Sub frm_consulta_generalusuarios_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel

    End Sub

    Private Sub frm_consulta_generalusuarios_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        If Me.Location.Y <= 71 Then
            Me.Location = New Point(Me.Location.X, 71)
        End If
    End Sub
End Class
