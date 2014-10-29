Public Class csvendedores
    Public sql As sqljoin = New sqljoin
    Public Function nuevo_vendedor(ByVal codigo As String, ByVal nombre As String, ByVal comision As Double) As Boolean
        mensaje = Me.sql.conexion("insert into vendedores(codigo,nombre,comision) values ('" & codigo & "','" & nombre & "'," & comision & ")")
        If mensaje = -1 Then
            MessageBox.Show("Datos incorrectos, no se pudo realizar evento, verifique informacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            MessageBox.Show("Registro ingresado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        End If
    End Function
    Public Function modificar_vendedor(ByVal codigo As String, ByVal nombre As String, ByVal comision As Double) As Boolean

        mensaje = Me.sql.conexion("update vendedores set nombre='" & nombre & "',comision=" & comision & "where codigo='" & codigo & "'")
        If mensaje = -1 Then
            MessageBox.Show("Datos incorrectos, no se pudo realizar evento, verifique informacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            MessageBox.Show("Registro Actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        End If
    End Function
    Public Function borrar_vendedor(ByVal codigo As String) As Boolean

        mensaje = Me.sql.conexion("delete from vendedores where codigo='" & codigo & "'")
        If mensaje = -1 Then
            MessageBox.Show("Datos incorrectos, no se pudo realizar evento, verifique informacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            MessageBox.Show("Registro Borrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        End If
    End Function
    Public Function valida_vendedor(ByVal codigo As String) As Boolean
        Dim reader As SqlClient.SqlDataReader
        Try
            reader = Me.sql.traerDataReader("Select codigo from vendedores where codigo='" & codigo & "'")
            If reader.HasRows() Then
                reader.Close()
                Return True
            Else
                reader.Close()
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function
End Class
