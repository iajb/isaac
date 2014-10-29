Imports System.Data
Public Class frm_auditoriausuario

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
    Private Sub frm_auditoriausuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenardatalist()
    End Sub
    'metodo que permite filtrar datos en el data list
    Public Sub llenardatalist()
        Dim conexion As sqljoin = New sqljoin
        Dim item As ListViewItem
        Dim reader As SqlClient.SqlDataReader
        Dim contador As Integer = 0
        Me.lsvconsultaclientes.Items.Clear()
        reader = conexion.traerDataReader("Select codigo_auditoria,cedula,usuario,fecha_entrada,fecha_salida from auditoria_usuarios order by fecha_salida,usuario desc")


        While (reader.Read())

            contador = contador + 1
            item = New ListViewItem(contador.ToString())
            item.SubItems.Add(reader.GetInt32(0))
            item.SubItems.Add(reader.GetString(1))
            item.SubItems.Add(reader.GetString(2))
            item.SubItems.Add(reader.GetDateTime(3))
            item.SubItems.Add(reader.GetDateTime(4))
           
            Me.lsvconsultaclientes.Items.Add(item)

        End While
    End Sub

    Private Sub lsvconsultaclientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvconsultaclientes.DoubleClick
        Try
            Me.objcliente.identificacion = Me.lsvconsultaclientes.SelectedItems(0).SubItems(1).Text
            Me.objcliente.nombre = Me.lsvconsultaclientes.SelectedItems(0).SubItems(2).Text
            Me.objcliente.apellido = Me.lsvconsultaclientes.SelectedItems(0).SubItems(3).Text
            Me.objcliente.telefono = Me.lsvconsultaclientes.SelectedItems(0).SubItems(4).Text
            Me.objcliente.direccion = Me.lsvconsultaclientes.SelectedItems(0).SubItems(5).Text

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub frm_auditoriausuario_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        If Me.Location.Y <= 71 Then
            Me.Location = New Point(Me.Location.X, 71)
        End If
    End Sub
End Class

