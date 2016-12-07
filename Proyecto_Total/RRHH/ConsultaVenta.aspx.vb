Imports System.IO

Public Class ConsultaVenta
    Inherits System.Web.UI.Page
    Dim ObjCafeteria As New clsCafeteria

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                ''''' INICIO SEGURIDAD ACCESO URL '''''
                Dim objGeneral As New clsgeneral
                objGeneral.DtsSeguridad = Session("dtsSeguridad")
                objGeneral.Consulta_Proyecto_Seguridad()
                objGeneral.PaginaAcceso = "~" + Mid(Request.RawUrl, Integer.Parse(objGeneral.nombreentidad))
                objGeneral.idusuario = CType(Session("permisos"), clsusuario).usuario
                objGeneral.PermisosUrl()
                ''''' FIN SEGURIDAD ACCESO URL '''''
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Public Sub Consulta_venta()
        Try
            lblmsg.Text = ""
            If RdbCodigo.Checked = False Or RdbDocumento.Checked = False Or rdbFecha.Checked = False Or RdbTotal.Checked = False Or RdbUsu.Checked = False Then

                If RdbCodigo.Checked = True Then
                    txtdoc.Text = ""
                    txtUsu.Text = ""
                    If txtCod.Text <> "" Then
                        ObjCafeteria.ConsultaVen = txtCod.Text
                        ObjCafeteria.ConsultaVentaTotal()
                        DtgVentas.DataSource = ObjCafeteria.ConsultaVentaTicket()
                        DtgVentas.DataBind()
                        lblmsg.Text = ""
                    Else
                        lblmsg.Text = "Digite Codigo del ticket"
                    End If

                End If
                If RdbDocumento.Checked = True Then
                    txtCod.Text = ""
                    txtUsu.Text = ""
                    If txtdoc.Text <> "" Then
                        ObjCafeteria.Documento_Cliente = txtdoc.Text
                        ObjCafeteria.ConsultaVentaTotal()
                        DtgVentas.DataSource = ObjCafeteria.ConsultaVentaTicket()
                        DtgVentas.DataBind()
                        lblmsg.Text = ""
                    Else
                        lblmsg.Text = "Digite documento del cliente"
                    End If

                End If
                If RdbUsu.Checked = True Then
                    txtCod.Text = ""
                    txtdoc.Text = ""
                    If txtUsu.Text <> "" Then
                        ObjCafeteria.Id_Usuario = txtUsu.Text
                        ObjCafeteria.ConsultaVentaTotal()
                        DtgVentas.DataSource = ObjCafeteria.ConsultaVentaTicket()
                        DtgVentas.DataBind()
                        lblmsg.Text = ""
                    Else
                        lblmsg.Text = "Digite usuario de quien realizo la venta"
                    End If

                End If
                If rdbFecha.Checked = True Then
                    txtCod.Text = ""
                    txtdoc.Text = ""
                    If TxtFecha_Inicio.Text <> "" And TxtFecha_Fin.Text <> "" Then
                        ObjCafeteria.ConsultaFechaini = TxtFecha_Inicio.Text + " 01:00:00 "
                        ObjCafeteria.ConsultaFechafin = TxtFecha_Fin.Text + " 23:50:00 "
                        ObjCafeteria.ConsultaVentaTotal()
                        DtgVentas.DataSource = ObjCafeteria.ConsultaVentaTicket()
                        DtgVentas.DataBind()
                        lblmsg.Text = ""
                        TxtFecha_Fin.Text = ""
                        TxtFecha_Inicio.Text = ""
                    ElseIf TxtFecha_Inicio.Text <> "" Then
                        ObjCafeteria.ConsultaFechaini = TxtFecha_Inicio.Text + " 01:00:00 "
                        ObjCafeteria.ConsultaVentaTotal()
                        DtgVentas.DataSource = ObjCafeteria.ConsultaVentaTicket()
                        DtgVentas.DataBind()
                        lblmsg.Text = ""
                        TxtFecha_Fin.Text = ""
                        TxtFecha_Inicio.Text = ""
                    ElseIf TxtFecha_Fin.Text <> "" Then
                        ObjCafeteria.ConsultaFechafin = TxtFecha_Fin.Text + " 23:50:00 "
                        ObjCafeteria.ConsultaVentaTotal()
                        DtgVentas.DataSource = ObjCafeteria.ConsultaVentaTicket()
                        DtgVentas.DataBind()
                        lblmsg.Text = ""
                        TxtFecha_Fin.Text = ""
                        TxtFecha_Inicio.Text = ""
                    Else
                        lblmsg.Text = "Digite las fechas que quiere consultar"
                    End If

                End If

                If RdbTotal.Checked = True Then
                    txtCod.Text = ""
                    txtdoc.Text = ""
                    txtUsu.Text = ""
                    ObjCafeteria.ConsultaVentaTotal()
                    DtgVentas.DataSource = ObjCafeteria.consultaVentas()

                    DtgVentas.DataBind()
                End If
            Else
                lblmsg.Text = "Seleccione un metodo de busqueda"
            End If

            lbltotal.Text = ObjCafeteria.Total
            lblcantgral.Text = ObjCafeteria.Contador
        Catch ex As Exception

            If ex.Message.Contains("La conversión de la cadena") = True Then
                lblmsg.Text = "No se encontraron registros"
            Else
                lblmsg.Text = "Se produjo error " + ex.Message
            End If

        End Try
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Consulta_venta()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Public Sub Exportarxls()
        Try
            Dim sb As New StringBuilder
            Dim sw As New StringWriter(sb)
            Dim htw As New HtmlTextWriter(sw)
            Dim pagina As Page = New Page
            Dim form = New HtmlForm
            Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"


            pagina.EnableEventValidation = False
            pagina.DesignerInitialize()
            pagina.Controls.Add(form)
            form.Controls.Add(DtgVentas)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True

            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=data.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Try
            Exportarxls()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub DtgVentas_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles DtgVentas.PageIndexChanging
        Try
            DtgVentas.PageIndex = e.NewPageIndex
            Consulta_venta()
        Catch ex As Exception
            lblmsg.Text = ex.Message
        End Try
    End Sub
End Class