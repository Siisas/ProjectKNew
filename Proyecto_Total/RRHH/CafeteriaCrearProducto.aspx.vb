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

                If TxtProducto.Text = "" Then


                End If
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
        ViewState("Dato") = TxtProducto.Text
        ViewState("Da1") = Drl_Categoria.SelectedValue
        If Drl_Categoria.SelectedValue = "-Seleccione-" Then
            Lbl_MensajePlantilla.Text = "Por favor seleccione una categoria"
        Else
            ObjProductosCafeteria.PublicIdCategoria = Drl_Categoria.SelectedValue
            ObjProductosCafeteria.PublicValorProducto = TxtValorProducto.Text
            ObjProductosCafeteria.PublicFechaRegistroProducto = TxtFechaCreacion.Text
            If Drl_CodigoEmpleado.SelectedValue = "-Seleccione-" Then
                Lbl_MensajePlantilla.Text = "Por favor seleccione el Codigo del empleado"
            Else
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
                ConsultaDDl()
            End If
        End If
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
        If Drl_NombreIdCreacionProducto.SelectedValue = "-Seleccione-" Then
            Lbl_MensajeIngresoProducto.Text = "Por favor seleccione un Producto"
        Else
            ObjProductosCafeteria.PublicNombreProducto = Drl_NombreIdCreacionProducto.SelectedValue
            ObjProductosCafeteria.PublicCantidadProducto = TxtCantidad.Text
            'ObjProductosCafeteria.PublicFechaRegistroProducto = TxtFecha.Text
            If Drl_CodigoEmpleado1.SelectedValue = "-Seleccione-" Then
                Lbl_MensajeIngresoProducto.Text = "Por favor seleccione el codigo del empleado"
            Else
                ObjProductosCafeteria.PublicCodigoEmpleado = Drl_CodigoEmpleado1.SelectedValue
                ObjProductosCafeteria.IngProductos()
                Lbl_MensajeIngresoProducto.Text = "<span class='glyphicon glyphicon-warning-sign'></span> El producto fue ingresado con exito"
            End If
        End If
        TxtProducto.Text = ""
        Drl_CodigoEmpleado.SelectedItem.Value = 0
        TxtValorProducto.Text = ""
        TxtFechaCreacion.Text = ""
        Drl_CodigoEmpleado.SelectedIndex = 0
        TxtProveedor.Text = ""
        TxtCantidad.Text = ""
    End Sub

    Protected Sub Btn_Prueba_Click(sender As Object, e As EventArgs) Handles Btn_Prueba.Click
        demo.Visible = True
        ViewState("Dato") = TxtProducto.Text
        ViewState("Dato1") = "Hola "
        ViewState("Dato2") = "Mi nombre es:"
        ViewState("Dato3") = Convert.ToString(Drl_CodigoEmpleado1.SelectedItem)
        demo.Value = ViewState("Dato1") & "" & ViewState("Dato") & "" & ViewState("Dato2") & "" & ViewState("Dato3")
        ViewState("Dato") = Nothing
        ViewState("Dato1") = Nothing
        TxtProducto.Text = ""
        ViewState("Dato1") = ""
        ViewState.Clear()

        'If demo.Value <> "" Then
        '    EnableViewState = "false"
        '    demo.Value = ""
        'End If
    End Sub


    Protected Sub EliminarVariables()
        ViewState("Dato").Clear
        ViewState("Dato1").Clear
        ViewState("Dato2").Clear
        ViewState("Dato3").Clear
        demo.Value = ""
        demo.Visible = False

    End Sub
End Class