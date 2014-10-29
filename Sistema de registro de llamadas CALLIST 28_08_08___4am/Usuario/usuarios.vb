Imports System.Data
Imports System.Data.SqlClient
Public Class usuarios
    Inherits persona
    Private variables As New encriptaciones()
    Private userusuario As String
    Private reuser As String
    Private usercontrasena As String
    Public join As sqljoin = New sqljoin



    Public Property usuario() As String
        Get
            Return Me.userusuario
        End Get
        Set(ByVal value As String)
            Me.userusuario = value

        End Set
    End Property
    Public Property contrasena() As String
        Get
            Return Me.usercontrasena
        End Get
        Set(ByVal value As String)
            Me.usercontrasena = value
        End Set
    End Property

    Public Function ValidaUsuario() As Boolean

        Me.join = New sqljoin
        Dim reader As SqlDataReader
        reader = join.traerDataReader("Select * from Usuarios where usuario='" & Me.usuario & "' and contrasena='" & Me.variables.Encripta(Me.contrasena) & "'")

        Try
            If (reader.HasRows) Then


                While (reader.Read())
                    Me.cedula1 = reader.GetString(0)
                    Me.nombre = reader.GetString(1).ToString()
                    Me.apellido = reader.GetString(2).ToString()
                    Me.telefono = reader.GetString(3).ToString()

                End While
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub ingusuario()
        Me.join.conexion("insert into usuarios values(" & Me.cedula1 & ",'" & Me.nombre & "','" & Me.apellido & "' ,'" & Me.telefono & "' ,'" & Me.direccion & "','" & Me.usuario & "','" & Me.variables.Encripta(Me.contrasena) & "')")
    End Sub
    Public Sub modificarcontrasena()
        Me.join.conexion("update Usuarios set contraseña='" & Me.variables.Encripta(Me.contrasena) & "' where coduser=" & Me.cedula1 & "")
    End Sub
    Public Sub modifica_usuario_set(ByVal varcedula As Long, ByVal varnombre As String, ByVal varapellido As String, ByVal vardireccion As String, ByVal vartelefono As String, ByVal varcontrasena As String, ByVal varusuario As String)
        Me.join.conexion("update usuarios set nombre='" & varnombre & "',apellido='" & varapellido & "',direccion='" & vardireccion & "', telefono='" & vartelefono & "', usuario='" & varusuario & "',contrasena='" & Me.variables.Encripta(varcontrasena) & "'where coduser=" & varcedula & "")
    End Sub

    Public Function buscaUsuario() As Boolean
        Dim reader As SqlClient.SqlDataReader
        reader = join.traerDataReader("Select * from Usuarios where usuario=" & Me.usuario & "")

        Try
            If (reader.HasRows) Then
                Return True
            Else
                Return False
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function buscacedula() As Boolean

        Dim reader As SqlDataReader
        reader = join.traerDataReader("Select * from Usuarios where coduser=" & Me.cedula1 & "")

        Try
            If (reader.HasRows) Then
                Return True
            Else
                Return False
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function


    Public Function borrar_usuario(ByVal codigo As Long) As Boolean
        Try
            mensaje = Me.sql.conexion("delete from usuarios where coduser=" & codigo & "")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
