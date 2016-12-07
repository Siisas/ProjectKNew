
Public Class CafeteriaComprarProducto
    Inherits System.Web.UI.Page
    Dim ObjetoClsCafeteriaProductos As New clsCafeteriaProductos
    Dim dt As New DataTable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Compra de Productos"
                LlenatDDL()
                Detalle()
                Session("AcumulaRegistros") = dt
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Public Sub LlenatDDL()
        Drl_Productos.DataSource = ObjetoClsCafeteriaProductos.CargarDatosDDlComprarProductos()
        Drl_Productos.DataTextField = "NombreProducto"
        Drl_Productos.DataValueField = "IdProducto"
        Drl_Productos.DataBind()
        Drl_Productos.Items.Insert(0, "- Seleccione -")
        Drl_Categoria.DataSource = ObjetoClsCafeteriaProductos.CargarDatosDDlComprarCategoria()
        Drl_Categoria.DataTextField = "Categoria"
        Drl_Categoria.DataValueField = "IdCategoria"
        Drl_Categoria.DataBind()
        Drl_Categoria.Items.Insert(0, "- Seleccione -")
        Drl_NombreEmpleado.DataSource = ObjetoClsCafeteriaProductos.CargarDatosDDlComprarNombreEmpleado()
        Drl_NombreEmpleado.DataTextField = "NombreEmpleado"
        Drl_NombreEmpleado.DataValueField = "CodigoEmpleado"
        Drl_NombreEmpleado.DataBind()
        Drl_NombreEmpleado.Items.Insert(0, "- Seleccione -")
        'Lbl_Valor.DataSource = ObjetoClsCafeteriaProductos.CargarDatosDDlValorProducto
        'Drl_Valor.DataTextField = "ValorProducto"
        'Drl_Valor.DataValueField = "ValorProducto"
        'Drl_Valor.DataBind()
        'Drl_Valor.Items.Insert(0, "- Seleccione -")
        Drl_NombreCliente.DataSource = ObjetoClsCafeteriaProductos.CargarDatosDDlComprarNombreCliente()
        Drl_NombreCliente.DataTextField = "NombreCliente"
        Drl_NombreCliente.DataValueField = "CodigoCLiente"
        Drl_NombreCliente.DataBind()
        Drl_NombreCliente.Items.Insert(0, "- Seleccione -")
    End Sub
    Private Sub Detalle()
        'dt.Columns.Add(New DataColumn("Codigo del Producto", GetType(Integer)))
        dt.Columns.Add(New DataColumn("Nombre del Producto", GetType(String)))
        dt.Columns.Add(New DataColumn("Categoria", GetType(String)))
        dt.Columns.Add(New DataColumn("Nombre del Empleado", GetType(String)))
        dt.Columns.Add(New DataColumn("Valor", GetType(Integer)))
        dt.Columns.Add(New DataColumn("Cantidad", GetType(Integer)))
        dt.Columns.Add(New DataColumn("Nombre del Cliente", GetType(String)))
    End Sub
    Protected Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        Dim totalSuma As Double
        Dim totalSuma2 As Double
        Dim dt As DataTable
        If Lbl_CantidadDisponible.Text < 0 Or TxtCantidadProducto.Text > Lbl_CantidadDisponible.Text Then
            Lbl_ValorTotal.Text = "No hay disponibilidad del producto por favor seleccione otro"
        Else
            dt = Session("AcumulaRegistros")
            dt.AcceptChanges()
            dt.Rows.Add(Convert.ToString(Drl_Productos.SelectedItem), Convert.ToString(Drl_Categoria.SelectedItem), Convert.ToString(Drl_NombreEmpleado.SelectedItem), Convert.ToDouble(Lbl_Valor.Text), Convert.ToDouble(TxtCantidadProducto.Text), Convert.ToString(Drl_NombreCliente.SelectedValue))
            Gtg_TotalCompras.DataSource = dt
            Gtg_TotalCompras.DataBind()
            Session("AcumulaRegistros") = dt
            totalSuma = Session("Suma")
            If totalSuma = 0 Then
                totalSuma += Val(TxtCantidadProducto.Text) * Val(Lbl_Valor.Text)
                Lbl_ValorTotal.Text = totalSuma
            Else
                totalSuma2 += Val(TxtCantidadProducto.Text) * Val(Lbl_Valor.Text)
                Lbl_ValorTotal.Text = totalSuma + totalSuma2
            End If
            Session("Suma") += totalSuma
        End If
    End Sub
    Private Sub Gtg_TotalCompras_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles Gtg_TotalCompras.RowDeleting
        Dim dt As DataTable = Session("AcumulaRegistros")
        Dim resta As Double = Session("Resta")
        dt.Rows.RemoveAt(e.RowIndex = -1)
        resta = Lbl_ValorTotal.Text - Lbl_Valor.Text * TxtCantidadProducto.Text
        Lbl_ValorTotal.Text = resta
        dt.AcceptChanges()
        Session("AcumulaRegistros") = dt
        Gtg_TotalCompras.DataSource = dt
        Gtg_TotalCompras.DataBind()
        If (e.RowIndex = 0) Then
            Lbl_ValorTotal.Text = "Seleccione Productos"
            Session("Suma") = 0
            'Session.Clear() con esta ópcion de session salgo de la sesion actual 
        End If
        'Session("Resta") = resta - Session("Suma")
    End Sub

    Protected Sub Drl_Productos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Productos.SelectedIndexChanged
        ObjetoClsCafeteriaProductos.PublicidProducto = Drl_Productos.SelectedValue
        Lbl_Valor.Text = ObjetoClsCafeteriaProductos.CargarDatosIndexProducto
        Lbl_CantidadDisponible.Text = ObjetoClsCafeteriaProductos.CargarDatosIndexProductoCantidadProductosDisponibles




    End Sub



    Protected Sub btn_Comprar_Click(sender As Object, e As EventArgs) Handles btn_Comprar.Click
        ObjetoClsCafeteriaProductos.PublicIdCategoria = Drl_Categoria.SelectedValue
        ObjetoClsCafeteriaProductos.PublicidProducto = Drl_Productos.SelectedItem.Value
        ObjetoClsCafeteriaProductos.PublicNombreEmpleado = Drl_NombreEmpleado.SelectedItem.Value
        ObjetoClsCafeteriaProductos.PublicValorProducto = Lbl_Valor.Text
        ObjetoClsCafeteriaProductos.PublicCantidadProducto = TxtCantidadProducto.Text
        ObjetoClsCafeteriaProductos.PublicNombreCliente = Drl_NombreCliente.SelectedItem.Value
        ObjetoClsCafeteriaProductos.PublicFechaVenta = TxtFechaVenta.Text
        ObjetoClsCafeteriaProductos.Ventas()
    End Sub

    Protected Sub btn_NuevaCompra_Click(sender As Object, e As EventArgs) Handles btn_NuevaCompra.Click
        Lbl_ValorTotal.Text = "selecciona los productos"
        Session("Suma") = 0
        Session("Suma") = Nothing
        Session("Suma") = ""
        Drl_Productos.SelectedIndex = 0
        Drl_Categoria.SelectedIndex = 0
        Drl_NombreEmpleado.SelectedIndex = 0
        TxtCantidadProducto.Text = ""
        Drl_NombreCliente.SelectedIndex = 0
        Lbl_Valor.Text = ""
        Lbl_CantidadDisponible.Text = ""
        'ok
    End Sub
End Class