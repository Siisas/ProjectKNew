Imports System.IO
Public Class Consulta_Falla_Des
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Consulta CRM Desactivación"
                Cargar_Drl()
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
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Public Sub Cargar_Drl()
        Try
            Dim ObjGeneral As New clsgeneral
            With drltipificacionll
                ObjGeneral.idtip = 1
                .DataSource = ObjGeneral.consultatipdilo
                .DataTextField = "tipificacion"
                .DataValueField = "idtipificacion"
                .DataBind()
            End With
            With drlBandeja
                ObjGeneral.Validacion = "Bandeja_Datos_Fa_Des"
                .DataSource = ObjGeneral.Consulta_Complemento_General
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim ObjCrmDatos As New clscrmdatos
            If txtcaso.Text = "" And txtCasoClaro.Text = "" And txtmin.Text = "" And TxtFc_Ini.Text = "" And TxtFc_Fin.Text = "" And drltipificacionll.SelectedItem.Text = "- Seleccione -" And drlBandeja.SelectedItem.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite algún criterio de filtro antes de realizar la consulta"
                Exit Sub
            End If
            If txtcaso.Text <> Nothing Then
                ObjCrmDatos.caso = txtcaso.Text
            ElseIf txtCasoClaro.Text <> Nothing Then
                ObjCrmDatos.caso = txtCasoClaro.Text
                ObjCrmDatos.cantidad = "CASO_CLARO"
            Else
                If drltipificacionll.SelectedItem.Text <> "- Seleccione -" Then
                    ObjCrmDatos.tipificacion = drltipificacionll.SelectedItem.Text
                End If
                If drlBandeja.SelectedItem.Text <> "- Seleccione -" Then
                    ObjCrmDatos.Bandeja = drlBandeja.Text
                End If
                If txtmin.Text <> Nothing Then
                    ObjCrmDatos.min = txtmin.Text
                End If
                If TxtFc_Ini.Text <> Nothing And TxtFc_Fin.Text <> Nothing Then
                    If Date.Parse(TxtFc_Ini.Text) > Date.Parse(TxtFc_Fin.Text) Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Verifique el rango de fechas ya que la fecha inicio no puede ser mayor a la fecha fin"
                        Exit Sub
                    Else
                        ObjCrmDatos.fechainicial = TxtFc_Ini.Text & " 00:00:00"
                        ObjCrmDatos.fechafin = TxtFc_Fin.Text & " 23:59:59"
                    End If
                ElseIf (TxtFc_Ini.Text = Nothing Or TxtFc_Fin.Text = Nothing) And (TxtFc_Ini.Text <> Nothing Or TxtFc_Fin.Text <> Nothing) Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Complete y/o verifique el filtro de Fechas!"
                    Exit Sub
                End If
                ObjCrmDatos.cantidad = Nothing
            End If
            ObjCrmDatos.Validacion = "General"
            Session("DtgGeneral") = ObjCrmDatos.Consulta_General_Bandeja_Falla_Desactivacion_D_V
            DtgGeneral.DataSource = Session("DtgGeneral")
            DtgGeneral.DataBind()
            lblcuenta.Text = ObjCrmDatos.cantidad
            If txtcaso.Text <> Nothing Or txtCasoClaro.Text <> Nothing Then
                ObjCrmDatos.Validacion = "Seguimiento"
                If txtcaso.Text <> Nothing Then
                    ObjCrmDatos.cantidad = Nothing
                ElseIf txtCasoClaro.Text <> Nothing Then
                    ObjCrmDatos.cantidad = "CASO_CLARO"
                End If
                Session("DtgGestion") = ObjCrmDatos.Consulta_General_Bandeja_Falla_Desactivacion_D_V
                DtgGestion.DataSource = Session("DtgGestion")
                DtgGestion.DataBind()
                lblcuentaSeguimiento.Text = "Seguimientos: " & ObjCrmDatos.cantidad
            Else
                Session("DtgGestion") = Nothing
                DtgGestion.DataSource = Session("DtgGestion")
                DtgGestion.DataBind()
                lblcuentaSeguimiento.Text = ""
            End If
            If lblcuenta.Text = 0 Then
                limpiar()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Public Sub limpiar()
        Try
            Session("DtgGestion") = Nothing
            DtgGestion.DataSource = Session("DtgGestion")
            DtgGestion.DataBind()
            lblcuentaSeguimiento.Text = Nothing
            Session("DtgGeneral") = Nothing
            DtgGeneral.DataSource = Session("DtgGeneral")
            DtgGeneral.DataBind()
            lblcuenta.Text = Nothing
            TxtFc_Ini.Text = Nothing
            TxtFc_Fin.Text = Nothing
            txtcaso.Text = Nothing
            txtmin.Text = Nothing
            txtCasoClaro.Text = Nothing
            drltipificacionll.SelectedIndex = 0
            drlBandeja.SelectedIndex = 0
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub btnxls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnxls.Click
        Try
            Dim sw As New StringWriter()
            Dim hw As New HtmlTextWriter(sw)
            Dim tabla As New Table()
            Dim tr1 As New TableRow()
            Dim cell1 As New TableCell()
            Dim Val As Boolean = False
            Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"
            If DtgGeneral.Rows.Count > 0 And DtgGeneral.Rows.Count < 8101 Then
                Val = True
                DtgGeneral.AllowPaging = False
                DtgGeneral.DataSource = Session("DtgGeneral")
                DtgGeneral.DataBind()
                cell1.Controls.Add(DtgGeneral)
                tr1.Cells.Add(cell1)
                tabla.Rows.Add(tr1)
                tabla.RenderControl(hw)
                DtgGeneral.AllowPaging = True
            ElseIf DtgGeneral.Rows.Count > 8100 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Se denego el permiso de exportacion debido a que exede el limite de registros; Realice otro filtro y reintente exportar! "
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span Class='glyphicon glyphicon-warning-sign'></span> ¡No se encontraron registros para realizar la exportacion! "
            End If
            If Val = True Then
                Response.Clear()
                Response.Buffer = True
                Response.AddHeader("Content-Disposition", "attachment;filename=Clientes con Intención de Desactivación Voz Y Datos - " + Now + ".xls")
                Response.Charset = "UTF-8"
                Response.ContentType = "application/vnd.ms-excel"
                Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                Response.Write(style)
                Response.Output.Write(sw.ToString())
                Response.End()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub DtgGestion_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles DtgGestion.RowDataBound
        If (e.Row.RowType = DataControlRowType.DataRow) Or (e.Row.RowType = DataControlRowType.Header) Then
            e.Row.Cells(9).Visible = False
            If DataBinder.Eval(e.Row.DataItem, "Estado") = "Eliminado" Then
                e.Row.ForeColor = Drawing.Color.Red
            End If
        End If
    End Sub

End Class