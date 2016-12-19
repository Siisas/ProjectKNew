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
        'If TxtCantidad.Text <= 0 Then
        '    Lbl_MensajePlantilla.Text = "la cantidad del producto debe ser mayor a 0 "
        'Else
        ObjProductosCafeteria.PublicNombreProducto = TxtProducto.Text
            ObjProductosCafeteria.PublicIdCategoria = Drl_Categoria.SelectedValue
            ObjProductosCafeteria.PublicValorProducto = TxtValorProducto.Text
            ObjProductosCafeteria.PublicFechaRegistroProducto = TxtFechaCreacion.Text
            ObjProductosCafeteria.PublicCodigoEmpleado = Drl_CodigoEmpleado.SelectedValue
            ObjProductosCafeteria.PublicProveedor = TxtProveedor.Text
        'ObjProductosCafeteria.PublicCantidadProducto = TxtCantidad.Text
        ObjProductosCafeteria.CrearProducto()
        Lbl_MensajePlantilla.Text = " <span class='glyphicon glyphicon-warning-sign'></span> El producto fue creado con exito"
        TxtProducto.Text = ""
        Drl_CodigoEmpleado.SelectedItem.Value = 0
        TxtValorProducto.Text = ""
        TxtFechaCreacion.Text = ""
        'Drl_CodigoEmpleado.SelectedValue = "-Seleccione"
        TxtProveedor.Text = ""
        'TxtCantidad.Text = ""
        'End If
    End Sub
    Public Sub ConsultaDDl()
        Drl_Categoria.DataSource = ObjProductosCafeteria.CargarDatosDDlProductos()
        Drl_Categoria.DataTextField = "Categoria"
        Drl_Categoria.DataValueField = "IdCategoria"
        Drl_Categoria.DataBind()
        Drl_Categoria.Items.Insert(0, "-Seleccione-")
        Drl_CategoriaBuscar.DataSource = ObjProductosCafeteria.CargarDatosDDlProductos()
        Drl_CategoriaBuscar.DataTextField = "Categoria"
        Drl_CategoriaBuscar.DataValueField = "IdCategoria"
        Drl_CategoriaBuscar.DataBind()
        Drl_CategoriaBuscar.Items.Insert(0, "-Seleccione-")
        Drl_CodigoEmpleado.DataSource = ObjProductosCafeteria.CargarDatosDDlComprarNombreEmpleado
        Drl_CodigoEmpleado.DataTextField = "CedulaEmpleado"
        Drl_CodigoEmpleado.DataValueField = "CodigoEmpleado"
        Drl_CodigoEmpleado.DataBind()
        Drl_CodigoEmpleado.Items.Insert(0, "-Seleccione-")
        Drl_CodigoEmpleado1.DataSource = ObjProductosCafeteria.CargarDatosDDlComprarNombreEmpleado
        Drl_CodigoEmpleado1.DataTextField = "CedulaEmpleado"
        Drl_CodigoEmpleado1.DataValueField = "CodigoEmpleado"
        Drl_CodigoEmpleado1.DataBind()
        Drl_CodigoEmpleado1.Items.Insert(0, "-Seleccione-")
        Drl_NombreIdCreacionProducto.DataSource = ObjProductosCafeteria.CargarDatosDDlrCrearProducto()
        Drl_NombreIdCreacionProducto.DataTextField = "NombreProducto"
        Drl_NombreIdCreacionProducto.DataValueField = "IdCreacionProducto"
        Drl_NombreIdCreacionProducto.DataBind()
        Drl_NombreIdCreacionProducto.Items.Insert(0, "-Seleccione-")
        Drl_NombreProducto.DataSource = ObjProductosCafeteria.CargarDatosDDlrCrearProducto()
        Drl_NombreProducto.DataTextField = "NombreProducto"
        Drl_NombreProducto.DataValueField = "NombreProducto"
        Drl_NombreProducto.DataBind()
        Drl_NombreProducto.Items.Insert(0, "-Seleccione-")

    End Sub
    Protected Sub btn_Consultar_Click(sender As Object, e As EventArgs) Handles btn_Consultar.Click
        ObjProductosCafeteria.PublicNombreProducto = Drl_NombreProducto.SelectedItem.Value
        ObjProductosCafeteria.PublicCategoria = Drl_CategoriaBuscar.SelectedValue
        If TxtBuscarFecha.Text = "" Then
            TxtBuscarFecha.Text = Date.Now.Date
        End If
        ObjProductosCafeteria.PublicFechaRegistroProducto = TxtBuscarFecha.Text
        Gtg_Productos.DataSource = ObjProductosCafeteria.ConsultaProductos()
        'Gtg_Productos = ObjProductosCafeteria.ConsultaProductos() 'Metodo toca crear el metodo que haga la busqueda y nos devuelva la consulta en la clase remember
        Gtg_Productos.DataBind()
    End Sub

    Protected Sub Btn_IngresarProductos_Click(sender As Object, e As EventArgs) Handles Btn_IngresarProductos.Click
        ObjProductosCafeteria.PublicNombreProducto = Drl_NombreIdCreacionProducto.SelectedValue
        'ObjProductosCafeteria.PublicNombreProducto = Drl_NombreProducto.SelectedValue
        'ObjProductosCafeteria.PublicValorProducto = TxtValorProducto111.Text
        ObjProductosCafeteria.PublicCantidadProducto = TxtCantidad.Text
        ObjProductosCafeteria.PublicFechaRegistroProducto = TxtFecha.Text
        ObjProductosCafeteria.PublicCodigoEmpleado = Drl_CodigoEmpleado1.SelectedValue
        ObjProductosCafeteria.IngProductos()
        Lbl_MensajeIngresoProducto.Text = "<span class='glyphicon glyphicon-warning-sign'></span> El producto fue ingresado con exito"
        'TxtProducto.Text = ""
        'Drl_CodigoEmpleado.SelectedItem.Value = 0
        ''TxtValorProducto.Text = ""
        'TxtFechaCreacion.Text = ""
        ''Drl_CodigoEmpleado.SelectedValue = "-Seleccione"
        'TxtProveedor.Text = ""
        ''TxtCantidad.Text = ""
        'End If
    End Sub
End Class