Public Class CafeteriaReportes
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
                ConsultarStock()

            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub btn_ConsultarVentasFecha_Click(sender As Object, e As EventArgs) Handles btn_ConsultarVentasFecha.Click
        '' Importante instancio la el objeto de la clase, selecciono el atributo y este es igual al parametro que llega de la aspx para pasar a la clase 
        If TxtFechaInicial.Text = "" Then
            TxtFechaInicial.Text = Date.Now.Date
            ObjProductosCafeteria.PublicFechaRegistroProducto = TxtFechaInicial.Text
            ObjProductosCafeteria.PublicFechaFinal = TxtFechaFinal.Text
            Gtg_Productos1.DataSource = ObjProductosCafeteria.ConsultarProductosPorFecha()
            Gtg_Productos1.DataBind()

        ElseIf TxtFechaFinal.Text = "" Then
            TxtFechaFinal.Text = Date.Now.Date
            ObjProductosCafeteria.PublicFechaRegistroProducto = TxtFechaInicial.Text
            ObjProductosCafeteria.PublicFechaFinal = TxtFechaFinal.Text
            Gtg_Productos1.DataSource = ObjProductosCafeteria.ConsultarProductosPorFecha()
            Gtg_Productos1.DataBind()

        Else
            ObjProductosCafeteria.PublicFechaRegistroProducto = TxtFechaInicial.Text
            ObjProductosCafeteria.PublicFechaFinal = TxtFechaFinal.Text
            Gtg_Productos1.DataSource = ObjProductosCafeteria.ConsultarProductosPorFecha()
            Gtg_Productos1.DataBind()
        End If
    End Sub

    Public Sub ConsultarStock()
        Drl_NombreProductoStock.DataSource = ObjProductosCafeteria.CargarDatosDDlProductosNmbreP
        Drl_NombreProductoStock.DataTextField = "NombreProducto"
        Drl_NombreProductoStock.DataValueField = "NombreProducto"
        Drl_NombreProductoStock.DataBind()
        Drl_NombreProductoStock.Items.Insert(0, "-Seleccione-")
    End Sub

    Protected Sub Btn_ConsultarDisProductos_Click(sender As Object, e As EventArgs) Handles Btn_ConsultarDisProductos.Click
        ObjProductosCafeteria.PublicNombreProducto = Drl_NombreProductoStock.SelectedValue
        Gtg_Productos.DataSource = ObjProductosCafeteria.ConsultarDisponibilidad()
        Gtg_Productos.DataBind()
        Gtg_Productos.DataSource = Nothing
    End Sub
End Class
