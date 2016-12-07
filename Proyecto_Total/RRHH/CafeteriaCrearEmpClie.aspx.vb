Public Class CafeteriaCrearEmpClie
    Inherits System.Web.UI.Page
    Dim ObjProductosCafeteria As New clsCafeteriaProductos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Registro Empleados - Registro Clientes"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub btn_AgregarEmpleado_Click(sender As Object, e As EventArgs) Handles btn_AgregarEmpleado.Click
        Try
            If TxtNombreEmpleado.Text = Nothing Then
                Mensaje.Text = ("Por favor registre un nombre")
            Else
                ObjProductosCafeteria.PublicNombreEmpleado = TxtNombreEmpleado.Text
                ObjProductosCafeteria.PublicCodigoEmpleado = TxtNumeroCedulaEmp.Text
                ObjProductosCafeteria.RegEmpleadosCafeteria()
                Mensaje.Text = "El Empleado se Registro con Exito"
                TxtNombreEmpleado.Text = ""
                TxtNumeroCedulaEmp.Text = ""
            End If
        Catch ex As Exception
            Mensaje.Text = "Se genero un error" + ex.Message
        End Try


    End Sub

    Protected Sub btn_AgregarCliente_Click(sender As Object, e As EventArgs) Handles btn_AgregarCliente.Click


        Try

            If TxtNombreCliente.Text = Nothing Then
                Mensaje.Text = ("Por favor registre un nombre")
            Else
                ObjProductosCafeteria.PublicNombreCliente = TxtNombreCliente.Text
                ObjProductosCafeteria.PublicicCedulaCliente = TxtNumeroCedulaCli.Text
                ObjProductosCafeteria.RegClienteCafeteria()
                Mensaje.Text = "Se Registro el cliente con exito"
                TxtNombreCliente.Text = ""
                TxtNumeroCedulaCli.Text = ""
            End If
        Catch ex As Exception
            Mensaje.Text = "Se genero un error " + ex.Message
        End Try



    End Sub
End Class