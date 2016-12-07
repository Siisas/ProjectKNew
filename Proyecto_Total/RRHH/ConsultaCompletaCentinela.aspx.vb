Imports System.IO
Public Class ConsultaCompletaCentinela
    Inherits System.Web.UI.Page
    Dim objconsultapausas As New clsrrhh

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Consulta Entrada y Salida Pausas"
                Dim objdatos As New clsgeneral
                Pngeneral.Visible = False
                Pntipohorario.Visible = False
                grupo()
                Tipo_horario()
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
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Protected Sub grupo()
        Dim objconsultapausas As New clsrrhh
        With drlGrupo
            .DataSource = objconsultapausas.Consulta_grupo
            .DataTextField = "grupo"
            .DataValueField = "grupo"
            .DataBind()
        End With
    End Sub
    Protected Sub Tipo_horario()
        Dim objconsultapausas As New clsrrhh
        With Drltipohorario
            .DataSource = objconsultapausas.Consulta_tipo_horario
            .DataTextField = "Nombre"
            .DataValueField = "Cod_Validacion_Horario_Complemento"
            .DataBind()
        End With
    End Sub
    Protected Sub buscarinf()
        Try
            Dim objconsultapausas As New clsrrhh
            If txtcod.Text = "" And TxtFechaInicio.Text = "" And TxtFechaFin.Text = "" And drlGrupo.SelectedItem.Text = "- Seleccione -" And Drltipohorario.SelectedItem.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite un criterio de filtro antes de realizar la consulta"
                dtggeneral.DataSource = Nothing
                dtggeneral.DataBind()
                Dtgtipohorario.DataSource = Nothing
                Dtgtipohorario.DataBind()
                Lblcuenta.Text = ""
            Else
                If txtcod.Text <> "" Then
                    objconsultapausas.codigo = txtcod.Text
                End If
                If TxtFechaInicio.Text <> "" Then
                    objconsultapausas.fcini = TxtFechaInicio.Text
                End If
                If TxtFechaFin.Text <> "" Then
                    objconsultapausas.fcfin = TxtFechaFin.Text
                End If
                If drlGrupo.SelectedItem.Text <> "- Seleccione -" Then
                    objconsultapausas.grupo = drlGrupo.Text
                End If
                If Drltipohorario.SelectedItem.Text <> "- Seleccione -" Then
                    objconsultapausas.Tipo_Horario = Drltipohorario.Text
                End If
                If TxtFechaInicio.Text <> Nothing Or TxtFechaFin.Text <> Nothing Then
                    If TxtFechaInicio.Text = Nothing And TxtFechaFin.Text <> Nothing Then
                        Pnl_Message.CssClass = "alert alert-danger"
                        lblmsg.Text = "<strong><span Class='glyphicon glyphicon-warning-sign'></span></strong> Para consultar, las fechas deben tener una fecha inicio y una fecha fin"
                        Lblcuenta.Text = ""
                        Exit Sub
                    End If
                    If TxtFechaInicio.Text <> Nothing And TxtFechaFin.Text = Nothing Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Para consultar, las fechas deben tener una fecha inicio y una fecha fin"
                        Lblcuenta.Text = ""
                        Exit Sub
                    End If
                    If Date.Parse(TxtFechaInicio.Text) > Date.Parse(TxtFechaFin.Text) Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> La fecha inicio es mayor que la fecha fin"
                        Lblcuenta.Text = ""
                        Exit Sub
                    End If
                End If
                If Drltipohorario.SelectedItem.Text <> "- Seleccione -" Then
                    Session("dtsB") = objconsultapausas.consultatotalcentinela
                    Dtgtipohorario.DataSource = Session("dtsB")
                    Dtgtipohorario.DataBind()
                    Lblcuentatipohorario.Text = objconsultapausas.cantidad
                    lblmsg.Text = ""
                    Pntipohorario.Visible = True
                    Pngeneral.Visible = False
                End If
                If Drltipohorario.SelectedItem.Text = "- Seleccione -" Then
                    Session("dtsA") = objconsultapausas.consultatotalcentinela
                    dtggeneral.DataSource = Session("dtsA")
                    dtggeneral.DataBind()
                    Lblcuenta.Text = objconsultapausas.cantidad
                    lblmsg.Text = ""
                    Pngeneral.Visible = True
                    Pntipohorario.Visible = False
                End If
                If Drltipohorario.SelectedItem.Text <> "- Seleccione -" Then
                    Lblcuentatipohorario.Text = Lblcuentatipohorario.Text + " de " + Drltipohorario.SelectedItem.Text
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btnconsultar_Click(sender As Object, e As EventArgs) Handles Btnconsultar.Click
        Try
            buscarinf()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub btnexportarexcel_Click(sender As Object, e As EventArgs) Handles btnexportarexcel.Click
        Try
            Dim sw As New StringWriter()
            Dim hw As New HtmlTextWriter(sw)
            Dim tabla As New Table()
            Dim tr1 As New TableRow()
            Dim cell1 As New TableCell()
            Dim Val As Boolean = False
            Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"
            If Pngeneral.Visible = True Then
                If dtggeneral.Rows.Count > 0 And dtggeneral.Rows.Count < 8101 Then
                    Val = True
                    dtggeneral.AllowPaging = False
                    dtggeneral.DataSource = Session("dtsA")
                    dtggeneral.DataBind()
                    cell1.Controls.Add(dtggeneral)
                    tr1.Cells.Add(cell1)
                    tabla.Rows.Add(tr1)
                    tabla.RenderControl(hw)
                    dtggeneral.AllowPaging = True
                ElseIf dtggeneral.Rows.Count > 8100 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Se denego el permiso de exportacion debido a que exede el limite de registros; Realice otro filtro y reintente exportar! "
                Else
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span Class='glyphicon glyphicon-warning-sign'></span> ¡No se encontraron registros para realizar la exportacion! "
                End If
            Else
                If Dtgtipohorario.Rows.Count > 0 And Dtgtipohorario.Rows.Count < 8101 Then
                    Val = True
                    Dtgtipohorario.AllowPaging = False
                    Dtgtipohorario.DataSource = Session("dtsB")
                    Dtgtipohorario.DataBind()
                    cell1.Controls.Add(Dtgtipohorario)
                    tr1.Cells.Add(cell1)
                    tabla.Rows.Add(tr1)
                    tabla.RenderControl(hw)
                    Dtgtipohorario.AllowPaging = True
                ElseIf Dtgtipohorario.Rows.Count > 8100 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Se denego el permiso de exportacion debido a que exede el limite de registros; Realice otro filtro y reintente exportar! "
                Else
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡No se encontraron registros para realizar la exportacion! "
                End If
            End If
            If Val = True Then
                Response.Clear()
                Response.Buffer = True
                Response.AddHeader("Content-Disposition", "attachment;filename=Reporte de entradas y salidas.xls")
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

    Protected Sub Dtgtipohorario_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Dtgtipohorario.PageIndexChanging
        Try
            Dtgtipohorario.PageIndex = e.NewPageIndex
            Dtgtipohorario.DataSource = Session("dtsB")
            Dtgtipohorario.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex
            dtggeneral.DataSource = Session("dtsA")
            dtggeneral.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class
