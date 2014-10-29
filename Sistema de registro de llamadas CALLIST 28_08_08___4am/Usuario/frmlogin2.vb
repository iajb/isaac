
Public Class frmlogin2

    Inherits System.Windows.Forms.Form
    Dim objusuario2 As usuario
    Public Sub New(ByVal objusuario2 As usuario)
        MyBase.New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.objusuario2 = objusuario2
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click

        objusuario2.useruser = Me.txtUserName.Text.Trim
        objusuario2.usercontraseña = Me.txtPassword.Text.Trim
        Me.DialogResult = Windows.Forms.DialogResult.None



        If validadatos() Then

            If validaUsuarios() Then

                Me.DialogResult = Windows.Forms.DialogResult.OK


            Else
                MessageBox.Show("Usuario no valido, por favor intente otra vez.", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.txtUserName.Text = ""
                Me.txtPassword.Text = ""
                Me.txtUserName.Focus()

            End If

        End If

    End Sub
    'Private Sub proceso_verifica_cumple_clientes()

    'End Sub
    Public Function validaUsuarios() As Boolean

        If (Me.objusuario2.ValidaUsuario()) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function validadatos() As Boolean
        If objusuario2.useruser = "" Or objusuario2.usercontraseña = "" Then
            MessageBox.Show("Todos los datos son requeridos", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtUserName.Focus()
            Return False
        Else
            Return True
        End If

    End Function


    Private Sub frmlogin2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        salir()

    End Sub
    Public Sub salir()
        If (MessageBox.Show("Esta seguro que desea salir del Sistema", "Callist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Dispose()
            Application.Exit()
        Else
            Me.DialogResult = Windows.Forms.DialogResult.None
            Me.txtUserName.Text = ""
            Me.txtPassword.Text = ""
            Me.txtUserName.Focus()
        End If

    End Sub
End Class