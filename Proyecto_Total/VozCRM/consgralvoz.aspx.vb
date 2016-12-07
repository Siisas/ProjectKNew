Imports System.IO
Public Class consgralvoz
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
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

    Sub buscarinf()
        Try
            Dim objdatos As New clsvoz
            If txtcaso.Text = "" And txtcliente.Text = "" And txtnit.Text = "" And txtmin.Text = "" And txtFechainicio.Text = "" And txtFechafin.Text = "" And drlbandeja.SelectedItem.Value = "0" And chkfallatec.Checked = False And txtfcsap.Text = "" And txtTipificacion.Text = "" Then
                lblmsg.Text = "Digite algún criterio de filtro antes de realizar la consulta"
                Exit Sub
            Else
                lblmsg.Text = ""
            End If
            If txtmin.Text <> Nothing Then
                objdatos.min = txtmin.Text
            End If
            If txtcaso.Text <> Nothing Then
                objdatos.caso = txtcaso.Text
            End If
            If txtcliente.Text <> Nothing Then
                objdatos.cliente = txtcliente.Text
            End If
            If drlbandeja.SelectedItem.Value <> "0" Then
                objdatos.mesa = drlbandeja.SelectedItem.Value
            End If
            If chkfallatec.Checked = True Then
                objdatos.fallatec = "1"
            End If
            If txtfcsap.Text <> Nothing Then
                objdatos.fcsap = txtfcsap.Text
            End If
            If txtnit.Text <> Nothing Then
                objdatos.nit = txtnit.Text
            End If
            If txtFechainicio.Text <> Nothing Then
                objdatos.fechainicial = txtFechainicio.Text
            End If

            If txtFechafin.Text <> Nothing Then
                objdatos.fechafin = txtFechafin.Text
            End If

            'TIPIFICACION
            If txtTipificacion.Text <> Nothing Then
                objdatos.tipificacion = txtTipificacion.Text
                dtgtipificacion.DataSource = objdatos.consultagralvoz
                dtgtipificacion.DataBind()
                lblcuenta.Text = objdatos.cantidad
            Else
                dtggeneral.DataSource = objdatos.consultagralvoz
                dtggeneral.DataBind()
                lblcuenta.Text = objdatos.cantidad
            End If

            'seguimientos
            If txtcaso.Text = Nothing And txtmin.Text = Nothing Then
                dtgseguimiento.DataSource = Nothing
                dtgseguimiento.DataBind()
                lblcuenta0.Text = ""
            Else
                dtgseguimiento.DataSource = objdatos.consultasegvoz
                dtgseguimiento.DataBind()
                lblcuenta0.Text = objdatos.cantidad
            End If
            'marcaciones
            If txtcaso.Text = Nothing And txtmin.Text = Nothing Then
                dtgmarcacion.DataSource = Nothing
                dtgmarcacion.DataBind()
                lblcuenta1.Text = ""
            Else
                dtgmarcacion.DataSource = objdatos.consultamarcvoz
                dtgmarcacion.DataBind()
                lblcuenta1.Text = objdatos.cantidad
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        buscarinf()
    End Sub

    Protected Sub btnxls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnxls.Click
        Try
            crearexcel()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
            lblmsg.ForeColor = Drawing.Color.Red
        End Try
    End Sub
    Sub crearexcel()
        Dim sb As New StringBuilder
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim form = New HtmlForm
        Dim r As New clsvoz
        Dim objdtsconsultaxls As New DataSet
        Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
        If lblcuenta.Text <> Nothing Then
            If lblcuenta.Text < 20001 Then
                If txtmin.Text <> Nothing Then
                    r.min = txtmin.Text
                End If
                If txtcaso.Text <> Nothing Then
                    r.caso = txtcaso.Text
                End If
                If txtcliente.Text <> Nothing Then
                    r.cliente = txtcliente.Text
                End If
                If drlbandeja.SelectedItem.Value <> "0" Then
                    r.mesa = drlbandeja.SelectedItem.Value
                End If
                If chkfallatec.Checked = True Then
                    r.fallatec = "1"
                End If
                If txtfcsap.Text <> Nothing Then
                    r.fcsap = txtfcsap.Text
                End If
                If txtFechainicio.Text <> Nothing Then
                    r.fechainicial = txtFechainicio.Text
                End If
                If txtFechafin.Text <> Nothing Then
                    r.fechafin = txtFechafin.Text
                End If
                If txtTipificacion.Text <> Nothing Then
                    r.tipificacion = txtTipificacion.Text
                    dtgxls2.DataSource = r.consultagralvoz
                    dtgxls2.DataBind()
                Else
                    dtgxls.DataSource = r.consultagralvoz
                    dtgxls.DataBind()
                End If
                dtgxls.Visible = True
                dtgxls.EnableViewState = False
                pagina.EnableEventValidation = False
                pagina.DesignerInitialize()
                pagina.Controls.Add(form)
                If dtgxls2.Rows.Count > 0 Then
                    dtgxls2.Visible = True
                    form.Controls.Add(dtgxls2)
                Else
                    form.Controls.Add(dtgxls)
                End If
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
            Else
                lblmsg.Text = "No se puede generar archivo en xls, realice un filtro adicional o solicite la consulta al administrador de la base de datos"
            End If
            Else
                lblmsg.Text = "Realice una consulta y luego intente exportarla"
            End If
    End Sub

    Private Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            buscarinf()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub dtgtipificacion_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgtipificacion.PageIndexChanging
        Try
            dtgtipificacion.PageIndex = e.NewPageIndex
            buscarinf()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub dtgseguimiento_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgseguimiento.PageIndexChanging
        Try
            dtgseguimiento.PageIndex = e.NewPageIndex
            buscarinf()
        Catch ex As Exception
            lblmsg.Text = "Se presentó error: " & ex.Message
        End Try
    End Sub

    Protected Sub dtgmarcacion_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgmarcacion.PageIndexChanging
        Try
            dtgmarcacion.PageIndex = e.NewPageIndex
            buscarinf()
        Catch ex As Exception
            lblmsg.Text = "Se presentó error: " & ex.Message
        End Try

    End Sub
End Class