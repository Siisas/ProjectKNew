Public Class CafeteriaComprarProducto
    Inherits System.Web.UI.Page
    Dim ObjetoClsCafeteriaProductos As New clsCafeteriaProductos
    Dim dt As New DataTable
    Dim CantidadDisponible As Integer
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
                LimpiarCache()
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
        dt.Columns.Add(New DataColumn("Valor Total", GetType(Integer)))
    End Sub
    Protected Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        Dim totalSuma As Double
        Dim cant As Double = Session("Cantidad")
        Dim resta As Double = Session("Resta")
        Dim suma As Double = Session("Suma")
        Dim Total As Double = Session("Total")
        Dim Flag As Boolean = True
        Dim ValorFor As Integer = 0
        Session("Valor1") = TxtCantidadProducto.Text
        Session("Valor2") = Lbl_Valor.Text
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
                    For index = 0 To Gtg_TotalCompras.Rows.Count - 1
                        If Flag = True Then
                            ValorFor = index
                        End If
                    Next
                    If dt.Rows.Count = 0 Then
                        dt.Rows.Add(Convert.ToDouble(Drl_Productos.SelectedValue), Convert.ToString(Drl_Productos.SelectedItem), Convert.ToDouble(Lbl_Valor.Text), Convert.ToDouble(TxtCantidadProducto.Text), Convert.ToDouble(TxtCantidadProducto.Text) * Convert.ToDouble(Lbl_Valor.Text))
                    Else
                        If dt.Rows(ValorFor).Item(0) = (Convert.ToDouble(Drl_Productos.SelectedValue)) Then
                            If (Convert.ToDouble(TxtCantidadProducto.Text) + dt.Rows(ValorFor).Item(3) > Lbl_CantidadDisponible.Text) Then
                                Lbl_String.Text = "la cantidad seleccionada no es disponible"
                            Else
                                If Lbl_CantidadDisponible.Text < dt.Rows(ValorFor).Item(3) Then
                                    Lbl_String.Text = "Ya selecciono la cantidad disponible del producto"
                                Else
                                    cant = Convert.ToDouble(TxtCantidadProducto.Text) + dt.Rows(ValorFor).Item(3)
                                    dt.Rows(ValorFor).Item(3) = cant
                                    dt.Rows(ValorFor).Item(4) = Convert.ToDouble(TxtCantidadProducto.Text) * (Convert.ToDouble(Lbl_Valor.Text)) + dt.Rows(ValorFor).Item(4)
                                    Lbl_String.Text = ""
                                End If
                            End If
                        Else
                            dt.Rows.Add(Convert.ToDouble(Drl_Productos.SelectedValue), Convert.ToString(Drl_Productos.SelectedItem), Convert.ToDouble(Lbl_Valor.Text), Convert.ToDouble(TxtCantidadProducto.Text), Convert.ToDouble(TxtCantidadProducto.Text) * Convert.ToDouble(Lbl_Valor.Text))
                            Lbl_String.Text = ""
                        End If
                    End If
                    CantidadDisponible = Session("Cantidad") - Convert.ToDouble(TxtCantidadProducto.Text)
                    Gtg_TotalCompras.DataSource = dt
                    Gtg_TotalCompras.DataBind()
                    Session("AcumulaRegistros") = dt
                    btn_Comprar.Visible = True
                    If Lbl_String.Text = "la cantidad seleccionada no es disponible" Then
                        Lbl_ValorTotal.Text = Session("Total")
                    Else
                        If totalSuma = 0 Then
                            Session("Total") = Session("Valor1") * Session("Valor2")
                        Else
                            Lbl_String.Text = ""
                        End If
                        If Lbl_String.Text = "Ya selecciono la cantidad disponible del producto" Then
                        Else
                            Lbl_ValorTotal.Text += Session("Total")
                        End If
                    End If
                End If
                End If
            End If
    End Sub
    Private Sub Gtg_TotalCompras_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles Gtg_TotalCompras.RowDeleting
        Dim dt As DataTable = Session("AcumulaRegistros")
        Dim resta As Double = Session("ValorResta")
        Dim suma As Double = Session("Suma")
        Dim Total As Double = Session("Total")
        dt.Rows.Item(e.RowIndex).Delete()
        Gtg_TotalCompras.DataSource = dt
        Gtg_TotalCompras.DataBind()
        Session("AcumulaRegistros") = dt
        Lbl_ValorTotal.Text = Session("ValorResta")
        'Lbl_ValorTotal.Text = Session("Total")
    End Sub
    Protected Sub Drl_Productos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Productos.SelectedIndexChanged
        If Drl_Productos.SelectedValue = "- Seleccione -" Then
            Drl_Productos.SelectedIndex = 0
        Else
            ObjetoClsCafeteriaProductos.PublicidProducto = Drl_Productos.SelectedValue
            Lbl_Valor.Text = ObjetoClsCafeteriaProductos.CargarDatosIndexProducto()
            Lbl_CantidadDisponible.Text = ObjetoClsCafeteriaProductos.CargarDatosIndexProductoCantidadProductosDisponibles()
            Session("Cantidad") = Lbl_CantidadDisponible.Text
            CantidadDisponible = Session("Cantidad")
            Lbl_IdProducto.Text = ObjetoClsCafeteriaProductos.CargarDatosIndexProductoXIdProducto()
            Lbl_Catego.Text = ObjetoClsCafeteriaProductos.CargarDatosIndexProductoXCategoria()
        End If
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
                If Drl_NombreEmpleado.SelectedValue = "- Seleccione -" Then
                    Lbl_String.Text = "Por favor seleccione un producto para agregar a su pedido"
                Else
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
    Public Sub LimpiarCache()
        Lbl_ValorTotal.Text = 0
        Lbl_String.Text = "Selecciona"
        Session("Suma") = 0
        Session.Contents.Remove("Suma")
        Session("Suma") = Nothing
        dt.Clear()
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