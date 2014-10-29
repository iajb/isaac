Imports System.Data
Imports System.Data.SqlClient
Public Class cs_Proveedores
    Public sql As sqljoin = New sqljoin

    Public Function modifica_proveedor(ByVal codigo As String, ByVal nombre As String, ByVal direccion As String, ByVal ciudad As String, ByVal telefono As String, ByVal telefono2 As String, ByVal pais As String, ByVal observacion As String, ByVal email As String, ByVal cargo As String, ByVal actividad As String, ByVal fecha_nacimiento As String, ByVal pago As Integer) As Boolean


        mensaje = Me.sql.conexion("update proveedores set nombre='" & nombre & "',direccion='" & direccion & "',ciudad='" & ciudad & "',telefono='" & telefono & "',telefono2='" & telefono2 & "',pais='" & pais & "',observacion='" & observacion & "',email='" & email & "',cargo='" & cargo & "',actividad='" & actividad & "',fecha_nacimiento='" & fecha_nacimiento & "',pago=" & pago & " where codigo='" & codigo & "'")
        If mensaje = -1 Then
            MsgBox("Datos incorrectos, no se pudo realizar evento, verifique informacion")
            Return False
        Else
            MsgBox("Registros Actualizados")
            Return True
        End If

    End Function
    Public Function ingresa_proveedor(ByVal codigo As String, ByVal nombre As String, ByVal direccion As String, ByVal ciudad As String, ByVal telefono As String, ByVal telefono2 As String, ByVal pais As String, ByVal observacion As String, ByVal email As String, ByVal cargo As String, ByVal actividad As String, ByVal fecha_nacimiento As Date, ByVal pago As Integer) As Boolean

        'Dim localDateimportante As String
        'localDateimportante = Format(fecha_nacimiento, "MM/dd/yy")
        'localDate = Format(Me.fecha, "MM/dd/yy")
        mensaje = Me.sql.conexion("insert into proveedores(codigo,nombre,direccion,ciudad,telefono,telefono2,pais,observacion,email,cargo,actividad,fecha_nacimiento,pago)values ('" & codigo & "','" & nombre & "','" & direccion & "','" & ciudad & "','" & telefono & "','" & telefono2 & "','" & pais & "','" & observacion & "','" & email & "','" & cargo & "','" & actividad & "','" & fecha_nacimiento & "'," & pago & ")")
        If mensaje = -1 Then
            MsgBox("Datos incorrectos, no se pudo realizar evento, verifique informacion")
            Return False
        Else
            MsgBox("Registros Ingresados")
            Return True
        End If

    End Function


    Public Function borrar_proveedor(ByVal codigo As String) As Boolean
        Try
            mensaje = Me.sql.conexion("delete from proveedores where codigo='" & codigo & "'")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function buscacedula(ByVal cedula As String) As Boolean

        Dim reader As SqlDataReader
        reader = sql.traerDataReader("Select * from proveedores where codigo='" & cedula & "'")

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

End Class
