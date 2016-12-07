Public Class Plantilla
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
                Session("Formulario") = "Ingreso Productos"
                ConsultaDDl()
            End If

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_RegistrarProducto_Click(sender As Object, e As EventArgs) Handles Btn_RegistrarProducto.Click
        ObjProductosCafeteria.PublicNombreProducto = TxtProducto.Text
        ObjProductosCafeteria.PublicIdCategoria = Drl_Categoria.SelectedValue
        ObjProductosCafeteria.PublicValorProducto = TxtValorProducto.Text
        ObjProductosCafeteria.PublicFechaRegistroProducto = TxtFecha.Text
        ObjProductosCafeteria.PublicCodigoEmpleado = Drl_CodigoEmpleado.SelectedValue
        ObjProductosCafeteria.PublicProveedor = TxtProveedor.Text
        ObjProductosCafeteria.RegProductos()
    End Sub
    Public Sub ConsultaDDl()

        Drl_Categoria.DataSource = ObjProductosCafeteria.CargarDatosDDlProductos()
        Drl_Categoria.DataTextField = "Categoria"
        Drl_Categoria.DataValueField = "IdCategoria"
        Drl_Categoria.DataBind()
        Drl_Categoria.Items.Insert(0, "- Seleccione -")
        Drl_NombreProducto.DataSource = ObjProductosCafeteria.CargarDatosDDlProductosNmbreP()
        Drl_NombreProducto.DataTextField = "NombreProducto"
        Drl_NombreProducto.DataValueField = "IdProducto"
        Drl_NombreProducto.DataBind()
        Drl_NombreProducto.Items.Insert(0, "-Seleccione-")
        Drl_CodigoEmpleado.DataSource = ObjProductosCafeteria.CargarDatosDDlComprarNombreEmpleado
        Drl_CodigoEmpleado.DataTextField = "CedulaEmpleado"
        Drl_CodigoEmpleado.DataValueField = "CodigoEmpleado"
        Drl_CodigoEmpleado.Items.Insert(0, "-Seleccione-")
        Drl_CodigoEmpleado.DataBind()


    End Sub
End Class