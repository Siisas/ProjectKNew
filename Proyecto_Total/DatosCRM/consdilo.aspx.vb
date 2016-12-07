Imports System.IO
Public Class consdilo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Consulta CRM Dilo"
                Dim objgeneral2 As New clsgeneral
                With drlestadodilo
                    objgeneral2.idtip = 1
                    .DataSource = objgeneral2.consultatipdilo
                    .DataTextField = "tipificacion"
                    .DataValueField = "idtipificacion"
                    .DataBind()
                End With
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
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            Dim objdatos As New clscrmdatos
            If Txt_Caso.Text = "" And Txt_Reportado.Text = "" And txtfcdesde.Text = "" And txtfchasta.Text = "" And Txt_Min.Text = "" And Drl_Canal.SelectedIndex = 0 And drlestadodilo.SelectedIndex = 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Para realizar una consulta debe filtrar minimo por un criterio!"
                Exit Sub
            End If
            If Txt_Caso.Text <> Nothing Then
                objdatos.caso = Txt_Caso.Text
            ElseIf Txt_Reportado.Text <> Nothing Then
                objdatos.caso = Txt_Reportado.Text
                objdatos.cantidad = "REPORTADO"
            Else
                If drlestadodilo.SelectedItem.Value <> 8 Then
                    objdatos.tipificacion = drlestadodilo.SelectedItem.Text
                End If
                If Drl_Canal.SelectedIndex > 0 Then
                    objdatos.mesa = Drl_Canal.SelectedItem.Value
                End If
                If Txt_Min.Text <> Nothing Then
                    objdatos.min = Txt_Min.Text
                End If
                If txtfcdesde.Text <> Nothing And txtfchasta.Text <> Nothing Then
                    objdatos.fcini = txtfcdesde.Text & " 00:00:00"
                    objdatos.fcfin = txtfchasta.Text & " 23:59:59"
                ElseIf (txtfcdesde.Text = Nothing Or txtfchasta.Text = Nothing) And (txtfcdesde.Text <> Nothing Or txtfchasta.Text <> Nothing) Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Complete y/o verifique el filtro de Fechas!"
                    Exit Sub
                End If
                objdatos.cantidad = Nothing
            End If
            objdatos.Validacion = "General"
            Session("DtgGeneral") = objdatos.Consulta_Casos_Dilo()
            DtgGeneral.DataSource = Session("DtgGeneral")
            DtgGeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
            If Txt_Caso.Text <> Nothing Or Txt_Reportado.Text <> Nothing Then
                objdatos.Validacion = "Seguimiento"
                If Txt_Caso.Text <> Nothing Then
                    objdatos.cantidad = Nothing
                ElseIf Txt_Reportado.Text <> Nothing Then
                    objdatos.cantidad = "REPORTADO"
                End If
                Session("Dtg_Seguimientos") = objdatos.Consulta_Casos_Dilo()
                Dtg_Seguimientos.DataSource = Session("Dtg_Seguimientos")
                Dtg_Seguimientos.DataBind()
                lblcuenta2.Text = "Seguimientos: " & objdatos.cantidad
            Else
                Session("Dtg_Seguimientos") = Nothing
                Dtg_Seguimientos.DataSource = Session("Dtg_Seguimientos")
                Dtg_Seguimientos.DataBind()
                lblcuenta2.Text = ""
            End If
            If lblcuenta.Text = 0 Then
                limpiar()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Public Sub limpiar()
        Try
            Session("Dtg_Seguimientos") = Nothing
            Dtg_Seguimientos.DataSource = Session("Dtg_Seguimientos")
            Dtg_Seguimientos.DataBind()
            lblcuenta2.Text = Nothing
            Session("DtgGeneral") = Nothing
            DtgGeneral.DataSource = Session("DtgGeneral")
            DtgGeneral.DataBind()
            lblcuenta.Text = Nothing
            txtfcdesde.Text = Nothing
            txtfchasta.Text = Nothing
            Txt_Caso.Text = Nothing
            Txt_Min.Text = Nothing
            Txt_Reportado.Text = Nothing
            drlestadodilo.SelectedIndex = 0
            Drl_Canal.SelectedIndex = 0
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
                Response.AddHeader("Content-Disposition", "attachment;filename=Data.xls")
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

    Protected Sub DtgGeneral_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles DtgGeneral.PageIndexChanging
        Try
            DtgGeneral.PageIndex = e.NewPageIndex
            DtgGeneral.DataSource = Session("DtgGeneral")
            DtgGeneral.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Dtg_Seguimientos_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtg_Seguimientos.RowDataBound
        If (e.Row.RowType = DataControlRowType.DataRow) Or (e.Row.RowType = DataControlRowType.Header) Then
            e.Row.Cells(8).Visible = False
            If DataBinder.Eval(e.Row.DataItem, "Estado") = "Eliminado" Then
                e.Row.ForeColor = Drawing.Color.Red
            End If
        End If
    End Sub

End Class