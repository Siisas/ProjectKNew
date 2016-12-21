
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
                btn_Comprar.Visible = False
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Public Sub LlenatDDL()
        Drl_Productos.DataSource = ObjetoClsCafeteriaProductos.CargarDatosDDlComprarProductos()
        Drl_Productos.DataTextField = "NombreProducto"
        Drl_Productos.DataValueField = "IdCreacionProducto"
        Drl_Productos.DataBind()
        Drl_Productos.Items.Insert(0, "- Seleccione -")
        Drl_NombreEmpleado.DataSource = ObjetoClsCafeteriaProductos.CargarDatosDDlComprarNombreEmpleado()
        Drl_NombreEmpleado.DataTextField = "NombreEmpleado"
        Drl_NombreEmpleado.DataValueField = "CodigoEmpleado"
        Drl_NombreEmpleado.DataBind()
        Drl_NombreEmpleado.Items.Insert(0, "- Seleccione -")
        Drl_NombreCliente.DataSource = ObjetoClsCafeteriaProductos.CargarDatosDDlComprarNombreCliente()
        Drl_NombreCliente.DataTextField = "NombreCliente"
        Drl_NombreCliente.DataValueField = "CodigoCLiente"
        Drl_NombreCliente.DataBind()
        Drl_NombreCliente.Items.Insert(0, "- Seleccione -")
    End Sub
    Private Sub Detalle()
        dt.Columns.Add(New DataColumn("Codigo del Producto", GetType(Integer)))
        dt.Columns.Add(New DataColumn("Nombre del Producto", GetType(String)))
        dt.Columns.Add(New DataColumn("Valor Unidad", GetType(Integer)))
        dt.Columns.Add(New DataColumn("Cantidad", GetType(Integer)))
    End Sub
    Protected Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        Dim totalSuma As Double
        Dim totalSuma2 As Double
        Dim dt As DataTable
        If Drl_Productos.SelectedIndex = 0 Then
            Drl_NombreEmpleado.SelectedIndex = 0
            TxtCantidadProducto.Text = ""
            Drl_NombreCliente.SelectedIndex = 0
            Lbl_Valor.Text = ""
            Lbl_CantidadDisponible.Text = ""
            Lbl_String.Text = "Por favor agregue un elemento para agregar"
        Else
            If Lbl_CantidadDisponible.Text <= 0 Then
                Lbl_String.Text = "No hay disponibilidad del producto por favor seleccione otro"
            Else
                If Convert.ToInt32(TxtCantidadProducto.Text) > Convert.ToInt32(Lbl_CantidadDisponible.Text) Then
                    Lbl_String.Text = "La cantidad seleccionada sobre pasa la cantidad disponible"
                Else
                    dt = Session("AcumulaRegistros")
                    dt.AcceptChanges()
                    'dt.Rows.Add(Convert.ToDouble(Drl_Productos.SelectedValue), Convert.ToString(Drl_Productos.SelectedItem), Convert.ToDouble(Lbl_Valor.Text), Convert.ToDouble(TxtCantidadProducto.Text))
                    If (Convert.ToDouble(TxtCantidadProducto.Text) < TxtCantidadProducto.Text) Then
                        Lbl_String.Text = "la cantidad seleccionada no es disponible"
                    Else
                        'dt.Rows.Add(Convert.ToDouble(Drl_Productos.SelectedValue), Convert.ToString(Drl_Productos.SelectedItem), Convert.ToDouble(Lbl_Valor.Text), Convert.ToDouble(TxtCantidadProducto.Text))
                        'Gtg_TotalCompras.DataSource = dt
                        'Gtg_TotalCompras.DataBind()
                        dt.Rows.Add(Convert.ToDouble(Drl_Productos.SelectedValue), Convert.ToString(Drl_Productos.SelectedItem), Convert.ToDouble(Lbl_Valor.Text), Convert.ToDouble(TxtCantidadProducto.Text))

                        Gtg_TotalCompras.DataSource = dt
                                Gtg_TotalCompras.DataBind()

                                Session("AcumulaRegistros") = dt
                        totalSuma = Session("Suma")
                        btn_Comprar.Visible = True
                        If totalSuma = 0 Then
                            totalSuma += Val(TxtCantidadProducto.Text) * Val(Lbl_Valor.Text)
                            Lbl_ValorTotal.Text = totalSuma
                            Lbl_String.Text = ""
                        Else
                            totalSuma2 += Val(TxtCantidadProducto.Text) * Val(Lbl_Valor.Text)
                            Lbl_ValorTotal.Text = totalSuma + totalSuma2
                            Lbl_String.Text = ""
                        End If
                        Session("Suma") += totalSuma
                    End If
                End If
            End If
        End If
    End Sub
    '13
    Private Sub Gtg_TotalCompras_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles Gtg_TotalCompras.RowDeleting
        Dim dt As DataTable = Session("AcumulaRegistros")
        Dim resta As Double = Session("Resta")
        dt.Rows.RemoveAt(e.RowIndex)
        Gtg_TotalCompras.DataSource = dt
        Gtg_TotalCompras.DataBind()
        resta = Lbl_ValorTotal.Text - Lbl_Valor.Text * TxtCantidadProducto.Text
        Lbl_ValorTotal.Text = resta
        Session("Resta") = resta
    End Sub
    Protected Sub Drl_Productos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Productos.SelectedIndexChanged
        ObjetoClsCafeteriaProductos.PublicidProducto = Drl_Productos.SelectedValue
        Lbl_Valor.Text = ObjetoClsCafeteriaProductos.CargarDatosIndexProducto()
        Lbl_CantidadDisponible.Text = ObjetoClsCafeteriaProductos.CargarDatosIndexProductoCantidadProductosDisponibles()
        Lbl_IdProducto.Text = ObjetoClsCafeteriaProductos.CargarDatosIndexProductoXIdProducto()
        Lbl_Catego.Text = ObjetoClsCafeteriaProductos.CargarDatosIndexProductoXCategoria()
    End Sub
    Protected Sub btn_Comprar_Click(sender As Object, e As EventArgs) Handles btn_Comprar.Click
        If Drl_Productos.SelectedIndex = 0 Then
            Drl_NombreEmpleado.SelectedIndex = 0
            TxtCantidadProducto.Text = ""
            Drl_NombreCliente.SelectedIndex = 0
            Lbl_Valor.Text = ""
            Lbl_CantidadDisponible.Text = ""
            Lbl_String.Text = "Por favor agregue un elemento para comprar"
        Else
            Dim dt As DataTable = Session("AcumulaRegistros")
            Dim row As DataRow
            For index = 0 To Gtg_TotalCompras.Rows.Count - 1
                dt.AcceptChanges()
                row = dt.Rows(index)
                Session("AcumulaRegistros") = dt.Rows.Item(0)
                Session("AcumulaRegistros") = dt
                ObjetoClsCafeteriaProductos.PublicidProducto = row(0)
                ObjetoClsCafeteriaProductos.PublicNombreProducto = row(1)
                ObjetoClsCafeteriaProductos.PublicProveedor = row(2)
                ObjetoClsCafeteriaProductos.PublicValorProducto = row(3)
                'ObjetoClsCafeteriaProductos.PublicCantidadProducto = row(4)
                If Drl_NombreEmpleado.SelectedValue = "- Seleccione -" Then
                    Lbl_String.Text = "Por favor seleccione el nombre del empleado"
                Else
                    ObjetoClsCafeteriaProductos.PublicCodigoEmpleado = Drl_NombreEmpleado.SelectedValue
                    If Drl_NombreCliente.SelectedValue = "- Seleccione -" Then
                        Lbl_String.Text = "Por favor seleccione el codigo del cliente"
                    Else
                        ObjetoClsCafeteriaProductos.PublicCodigoCliente = Drl_NombreCliente.SelectedValue
                        ObjetoClsCafeteriaProductos.PublicCantidadProducto = TxtCantidadProducto.Text
                        ObjetoClsCafeteriaProductos.PublicFechaVenta = TxtFechaComprar.Text
                        ObjetoClsCafeteriaProductos.PublicValorVenta = Lbl_ValorTotal.Text
                        ObjetoClsCafeteriaProductos.Ventas()
                        ObjetoClsCafeteriaProductos.DatoTblVentas()
                        Gtg_TotalCompras.DataBind()
                    End If
                End If
            Next
            dt.Clear()
            Drl_NombreEmpleado.SelectedIndex = 0
            Drl_NombreCliente.SelectedIndex = 0
            Drl_Productos.SelectedIndex = 0
            TxtCantidadProducto.Text = ""
            Lbl_Valor.Text = ""
            Lbl_CantidadDisponible.Text = 0
            Lbl_ValorTotal.Text = 0
            Lbl_IdProducto.Text = 0
        End If
    End Sub
    Protected Sub btn_NuevaCompra_Click(sender As Object, e As EventArgs) Handles btn_NuevaCompra.Click
        Lbl_ValorTotal.Text = 0
        Lbl_String.Text = "Selecciona"
        Session("Suma") = 0
        Session.Contents.Remove("Suma")
        Session("Suma") = Nothing
        dt.Clear()
        'Session.RemoveAll()
        'Session("Suma") = ""
        Drl_Productos.SelectedIndex = 0
        Drl_NombreEmpleado.SelectedIndex = 0
        TxtCantidadProducto.Text = ""
        Drl_NombreCliente.SelectedIndex = 0
        Lbl_Valor.Text = ""
        Lbl_CantidadDisponible.Text = ""
        Lbl_ValorTotal.Text = Session("Suma")
        dt.Rows.Clear()
        dt.AcceptChanges()
        dt.Clear()
        Drl_NombreEmpleado.SelectedIndex = 0
        Drl_NombreCliente.SelectedIndex = 0
        Drl_Productos.SelectedIndex = 0
        TxtCantidadProducto.Text = ""
        Lbl_Valor.Text = ""
        Lbl_CantidadDisponible.Text = 0
        Lbl_ValorTotal.Text = 0
        Lbl_IdProducto.Text = 0
    End Sub
End Class