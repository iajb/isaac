Imports System.Security.Principal
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Net.Dns
Imports System.Net

Public Class usuario
    Inherits persona
    Private convmoneda As clsmoneda = New clsmoneda
#Region "Atributos de clase"

    Public txtusuario As String
    Public txtentrada As Date
    Public txtsalida As Date
    Private variables As New encriptaciones()
    Private user As String
    Private contraseña As String
    Private perciudad As String
    Private usucedula As String


    Private _codigo_pago As Integer
    Private _codigo As Integer
    Private _banco As Integer

    Private _localidad As String
    Private usulogin As String
    Private _tipo_usuario As String
    Private observacion As String

    Private fecha As Date
    Private fecha_importante As Date

    Public sqljoin As sqljoin = New sqljoin

#End Region

#Region "Propiedades de atributos"

    
    Public Property _fecha() As Date
        Get
            Return Me.fecha
        End Get
        Set(ByVal Value As Date)
            Me.fecha = Value
        End Set
    End Property
    Public Property _fecha_importante() As Date
        Get
            Return Me.fecha_importante
        End Get
        Set(ByVal Value As Date)
            Me.fecha_importante = Value
        End Set
    End Property
    
    Public Property codigo_pago() As Integer
        Get
            Return Me._codigo_pago
        End Get
        Set(ByVal Value As Integer)
            Me._codigo_pago = Value
        End Set
    End Property
    
    Public Property banco() As Integer
        Get
            Return Me._banco
        End Get
        Set(ByVal Value As Integer)
            Me._banco = Value
        End Set
    End Property
    Public Property codigo() As Integer
        Get
            Return Me._codigo
        End Get
        Set(ByVal Value As Integer)
            Me._codigo = Value
        End Set
    End Property


    Public Property tipo_usuario() As String
        Get
            Return Me._tipo_usuario
        End Get
        Set(ByVal Value As String)
            Me._tipo_usuario = Value
        End Set
    End Property
    Public Property login() As String
        Get
            Return Me.usulogin
        End Get
        Set(ByVal Value As String)
            Me.usulogin = Value
        End Set
    End Property
    
    Public Property observaciones() As String
        Get
            Return Me.observacion
        End Get
        Set(ByVal Value As String)
            Me.observacion = Value
        End Set
    End Property

    Public Property useruser() As String
        Get
            Return Me.user
        End Get
        Set(ByVal Value As String)
            Me.user = Value
        End Set
    End Property

    Public Property cedula() As String
        Get
            Return Me.usucedula
        End Get
        Set(ByVal Value As String)
            Me.usucedula = Value
        End Set
    End Property

    Public Property usercontraseña() As String
        Get
            Return Me.contraseña
        End Get
        Set(ByVal Value As String)
            Me.contraseña = Value
        End Set
    End Property

    Public Property ciudad() As String
        Get
            Return Me.perciudad
        End Get
        Set(ByVal Value As String)
            Me.perciudad = Value
        End Set
    End Property
    Public Property _conraseña() As String
        Get
            Return Me.contraseña
        End Get
        Set(ByVal Value As String)
            Me.contraseña = Value
        End Set
    End Property
#End Region

#Region "Métodos Privados"

    Private Function IntPrtStringTypeBoolConstructor(ByVal logonToken As IntPtr) As String

        Dim authenticationType As String = "WindowsAuthentication"
        Dim guestAccount As WindowsAccountType = WindowsAccountType.Guest
        Dim isAuthenticated As Boolean = True
        Dim windowsIdentity As New WindowsIdentity(logonToken, authenticationType, guestAccount, isAuthenticated)

        Return windowsIdentity.Name

    End Function

    Private Function LogonUser() As IntPtr

        Dim accountToken As IntPtr = WindowsIdentity.GetCurrent().Token

        Return accountToken

    End Function

#End Region

#Region "Métodos públicos"



    Public Function ValidaUsuario() As Boolean
        'ejemplo para encripta con el procedure interno
        'Me.variables.Encripta(Me.contraseña) & "'"
        Me.sql = New sqljoin
        Dim reader As SqlClient.SqlDataReader
        reader = sql.traerDataReader("Select * from usuarios where usuario='" & Me.user & "' and contrasena='" & Me.variables.Encripta(Me.contraseña) & "'")

        Try
            If (reader.HasRows) Then

                While (reader.Read())
                    Me.cedula = reader.GetValue(0).ToString
                    'Me.cedula = reader.Item("coduser")
                    'Me.cedula = reader.Item("coduser") 'ej de dos formas de tener acceso a los datos

                    'Me.cedula = reader.GetString(0)
                    'Me.nombre = reader.GetString(1).ToString()
                    Me.nombre = reader.Item("nombre")
                    'reader.Item("cedula")
                    'reader.Item(1)
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


    Public Function buscarUsuario() As Boolean

        Me.sql = New sqljoin
        Dim reader As SqlClient.SqlDataReader
        reader = sql.traerDataReader("Select coduser,nombre from usuarios where usuario='" & Me.user & "' and contrasena='" & Me.variables.Encripta(Me.contraseña) & "'")

        Try
            If (reader.HasRows) Then

                While (reader.Read())
                    Me.cedula = reader.GetString(0).ToString()
                    Me.nombre = reader.GetString(1).ToString()

                    
                End While

                reader.Close()

                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function

    

    Public Sub modificacionusuario()
        Me.sqljoin.conexion("update usuarios set contrasena='" & Me.variables.Encripta(Me.contraseña) & "' where coduser=" & Me.cedula & "")
    End Sub


    ' Autor: 
    ' Fecha de creación:
    ' Nombre del método: yaExisteUsuario
    ' Descripción: Verifica si nombre de usuario ya actual ya esta siendo usado por otra persona
    ' RETORNO: Valor booleano, True si ya esta siendo usado, False si no.

    Public Function yaExisteUsuario() As Boolean

        Me.sql = New sqljoin
        Dim reader As SqlClient.SqlDataReader

        reader = sql.traerDataReader("Select usuario from clientes where usuario='" & Me.user & "'")

        Dim usuario As String = Nothing

        Try
            If (reader.HasRows) Then

                Return True
            Else
                Return False

            End If

            reader.Close()

        Catch ex As Exception

            MsgBox("Se presentaron problemas de conexion ")

        End Try

    End Function
   

    ' Autor: 
    ' Fecha de creación:
    ' Nombre del método: yaExistecedula
    ' Descripción: Verifica si ya existe un usuario con el número de cedula actual.
    ' RETORNO: Valor booleano, True si existe, False si no.

    Public Function yaExistecedula() As Boolean

        Me.sql = New sqljoin
        Dim reader As SqlClient.SqlDataReader

        reader = sql.traerDataReader("Select coduser from usuarios where coduser=" & Me.cedula & "")

        'Dim usuario As String = Nothing

        Try
            If (reader.HasRows) Then
                reader.Close()
                Return True
            Else
                reader.Close()
                Return False

            End If

        Catch ex As Exception
            If (exepciones = 1) Then
                MsgBox(ex.Message)
            End If
        End Try

    End Function

    Public Function yaExistecedulacliente() As Boolean

        Me.sql = New sqljoin
        Dim reader As SqlClient.SqlDataReader

        reader = sql.traerDataReader("Select cedula from clientes where cedula=" & Me.cedula & "")

        'Dim usuario As String = Nothing

        Try
            If (reader.HasRows) Then
                reader.Close()
                Return True
            Else
                reader.Close()
                Return False

            End If

        Catch ex As Exception
            If (exepciones = 1) Then
                MsgBox(ex.Message)
            End If
        End Try

    End Function
    ' Autor: 
    ' Fecha de creación:
    ' Nombre del método: yaExistecedula
    ' Descripción: Verifica si ya existe un usuario con el número de cedula actual.
    ' RETORNO: Valor booleano, True si existe, False si no.

    Public Function puedeCambiarContraseña() As Boolean

        Me.sql = New sqljoin
        Dim reader As SqlClient.SqlDataReader

        reader = sql.traerDataReader("Select cambio_clave_veces from clientes where cedula='" & Me.cedula & "' and usuario='" & objusuario.txtusuario & "'")


        Try
            If (reader.HasRows) Then

                While reader.Read

                    If reader(0) >= 1 Then
                        Return False
                    Else
                        Return True
                    End If


                End While

            End If

            reader.Close()

        Catch ex As Exception

            MsgBox("Se presentaron problemas de conexion ")
            If (exepciones = 1) Then
                MsgBox(ex.Message)
            End If
        End Try

    End Function

    ' Autor: 
    ' Fecha de creación:
    ' Nombre del método: ingresarusuario
    ' Descripción: ingresa un nuevo usuario con los datos del objeto actual
    ' RETORNO: El número de filas afectadas por el query, retorna -1 si no se realizó el ingreso

    Public Function ingresarusuario() As Boolean
        Dim numfilas As Integer
        'Dim localDate As String
        'Dim localDateimportante As String
        'localDate = Format(Me.fecha, "MM/dd/yy")
        'localDateimportante = Format(Me.fecha_importante, "MM/dd/yy")
        numfilas = (Me.sqljoin.conexion("insert into clientes(cedula,nombre,numero_cuenta,oficial_tarjeta,direccion,telefono,tlfconv2,fecha_creacion,ciudad,localidad,tipo_cta,fecha,fecha_ultpago,tipo_usuario,valorultpago,deuda) values('" & Me.cedula & "','" & Me.nombre & "','" & Me.numero_cuenta & "','" & Me.oficial_tarjeta & "','" & Me.direccion & "','" & Me.telefono & "','" & Me.telefonodomicilio & "',GETDATE(),'" & Me.ciudad & "','" & Me.localidad & "'," & Me.tipo_cta & ",'" & Me.fecha & "', '" & Me.fecha_importante & "','" & Me.tipo_usuario & "', " & convmoneda.Encripta(Me.totalultpago) & "," & convmoneda.Encripta(Me.totaldeuda) & ")"))

        If numfilas = -1 Then
            MsgBox("Datos incorrectos, no se pudo realizar evento, verifique informacion")
            Return False
        Else
            MsgBox("Registro Ingresado")
            Return True
        End If

    End Function
    Public Function modifica_usuario_set(ByVal nombre As String, ByVal numero_cuenta As String, ByVal direccion As String, ByVal oficial_tarjeta As String, ByVal CIUDAD As String, ByVal telefono As String, ByVal telefonodomicilio As String, ByVal localidad As String, ByVal tipo_cta As Integer, ByVal fecha As Date, ByVal fecha_importante As Date, ByVal valorultpago As Double, ByVal deuda As Double) As Boolean
        mensaje = Me.sql.conexion("update clientes set nombre='" & nombre & "',numero_cuenta='" & numero_cuenta & "',direccion='" & direccion & "', oficial_tarjeta='" & oficial_tarjeta & "',CIUDAD='" & CIUDAD & "',telefono='" & telefono & "',tlfconv2 ='" & telefonodomicilio & "',localidad ='" & localidad & "',tipo_cta=" & tipo_cta & ",fecha='" & fecha & "',fecha_ultpago='" & fecha_importante & "',valorultpago=" & convmoneda.Encripta(valorultpago) & ",deuda=" & convmoneda.Encripta(deuda) & " where cedula='" & cedula & "'")
        If mensaje = -1 Then
            MsgBox("Datos incorrectos, no se pudo realizar evento, verifique informacion")
            Return False

        Else
            MsgBox("Registros Actualizados")
            Return True

        End If
    End Function

    ' recorre la tabla clientes para verificar si algun cliente se acerca su cumple con 5 dias de anticipacion
    Public Sub consulta_entrada()
        'CONSULTA LA FECHA DEL SISTEMA DEL SERVIDOR PARA CALCULAR LA ENTRADA
        Me.sql = New sqljoin
        Dim reader As SqlClient.SqlDataReader

        reader = sql.traerDataReader("SELECT getdate()")

        Try
            If (reader.HasRows) Then

                If (reader.Read()) Then
                    objusuario.txtentrada = reader(0)
                End If

            End If

            reader.Close()

        Catch ex As Exception
            If (exepciones = 1) Then
                MsgBox(ex.Message)
            End If
        End Try

    End Sub
   

   
#End Region

    Public Function borrar_cliente() As Boolean
        Try
            Me.sql.conexion("delete from clientes where cedula='" & objusuarios.cedula & "'")
            Return True
        Catch ex As Exception
            If (exepciones = 1) Then
                MsgBox(ex.Message)

            End If
            Return False
        End Try
    End Function
    'llena el obj usuarios con los datos de inicializacion


    Public Sub consulta_datos(ByVal cedula As String)

        Me.sql = New sqljoin
        Dim reader As SqlClient.SqlDataReader
        Try
            reader = sql.traerDataReader("select * FROM clientes WHERE (cedula ='" & cedula & "')")


            If (reader.HasRows) Then

                If (reader.Read()) Then
                    objusuarios.cedula = reader(0)
                    objusuarios.nombre = reader(1)
                    objusuarios.numero_cuenta = reader(2)
                    objusuarios.oficial_tarjeta = reader(3)
                    objusuarios.direccion = reader(4)
                    objusuarios.telefono = reader(5)
                    objusuarios.telefonodomicilio = reader(6)
                    objusuarios.ciudad = reader(8)
                    objusuarios.localidad = reader(9)
                    objusuarios.tipo_usuario = reader(10)
                    objusuarios.tipo_cta = reader(11)
                    objusuarios.fecha = reader.GetValue(12)
                    objusuarios.fecha_importante = reader.GetValue(13)
                    objusuarios.totalultpago = reader.GetValue(14) 'tipo double
                    objusuarios.totaldeuda = reader.GetValue(15) 'tipo double
                End If

            End If

            reader.Close()

        Catch ex As Exception
            If (exepciones = 1) Then
                MessageBox.Show(ex.Message)
            End If
        End Try

    End Sub
    'verifica si el codigo se repite siempre y cuando este inactivo el codigo a repetir


    Public Function cons_cli_fecha_nac(ByVal tabla As String) As Integer
        Dim reader As SqlClient.SqlDataReader
        Dim var_num_cumple As Integer = 0
        Dim var_fecha_cli As Date
        Try

            reader = Me.sql.traerDataReader("Select fecha as fecha_cumple from " & tabla & "")
            If (reader.HasRows) Then


                While (reader.Read())
                    var_fecha_cli = reader.Item("fecha_cumple")
                    If var_fecha_cli = DateTime.Now.Date Then
                        var_num_cumple = var_num_cumple + 1
                    End If
                End While
                reader.Close()
            End If

            reader.Close()

            Return var_num_cumple
        Catch ex As Exception
            Return var_num_cumple
        End Try
    End Function
    Public Function Verifica_IDcodigo_estado(ByVal tabla As String, ByVal codigo As String) As Boolean
        Dim var_estado As String = "Activo"
        Try
            Me.sql = New sqljoin
            Dim reader As SqlClient.SqlDataReader

            reader = sql.traerDataReader("select * FROM " & tabla & " WHERE (codigo ='" & codigo & "') and (estado='" & var_estado & "')")

            If (reader.HasRows) Then
                reader.Close()
                Return False
            Else
                reader.Close()
                Return True
            End If

        Catch ex As Exception
            If (exepciones = 1) Then
                MsgBox(ex.Message)

            End If
            Return False
        End Try
    End Function



    'verifica si el codigo y el estado estan inactivos , si es asi se pregunta si se desea activar

    Public Function Verifica_estado_producto(ByVal tabla As String, ByVal codigo As String) As Boolean
        Dim var_estado As String = "Inactivo"
        Try
            Me.sql = New sqljoin
            Dim reader As SqlClient.SqlDataReader

            reader = sql.traerDataReader("select * FROM " & tabla & " WHERE (codigo ='" & codigo & "') and (estado='" & var_estado & "')")

            If (reader.HasRows) Then
                reader.Close()
                Return True
            Else
                reader.Close()
                Return False
            End If

        Catch ex As Exception
            If (exepciones = 1) Then
                MsgBox(ex.Message)

            End If
            Return True
        End Try
    End Function

    Public Function Verifica_IDcodigo(ByVal tabla As String, ByVal codigo As String) As Boolean
        Try
            Me.sql = New sqljoin
            Dim reader As SqlClient.SqlDataReader

            reader = sql.traerDataReader("select * FROM " & tabla & " WHERE (codigo ='" & codigo & "')")

            If (reader.HasRows) Then
                reader.Close()
                Return False
            Else
                reader.Close()
                Return True
            End If

        Catch ex As Exception
            If (exepciones = 1) Then
                MsgBox(ex.Message)

            End If
            Return False
        End Try
    End Function
    Public Function tipousuario() As Boolean

        Me.sql = New sqljoin
        Dim reader As SqlClient.SqlDataReader

        reader = sql.traerDataReader("Select cedula from clientes where tipo_usuario='Usuario del sistema' and cedula='" & Me.cedula & "'")

        'Dim usuario As String = Nothing

        Try
            If (reader.HasRows) Then
                reader.Close()
                Return True
            Else
                reader.Close()
                Return False

            End If

        Catch ex As Exception
            If (exepciones = 1) Then
                MsgBox(ex.Message)
            End If
        End Try

    End Function
    Public Function validacontraseña() As Boolean

        Me.sql = New sqljoin
        Dim reader As SqlClient.SqlDataReader

        reader = sql.traerDataReader("Select coduser from usuarios where contrasena='" & Me.variables.Encripta(Me.usercontraseña) & "' and coduser=" & Me.cedula & "")

        'Dim usuario As String = Nothing

        Try
            If (reader.HasRows) Then
                reader.Close()
                Return True
            Else
                reader.Close()
                Return False

            End If

        Catch ex As Exception
            If (exepciones = 1) Then
                MsgBox(ex.Message)
            End If
        End Try

    End Function
End Class

