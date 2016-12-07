Imports System.IO

Public Class ConsultaInbound
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                With drlEstadoInboun
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultatipdilo
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
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub


    Sub buscarinf()
        Try
            Dim objdatos As New clscrmdatos
            If drlEstadoInboun.SelectedItem.Value <> 8 Then
                objdatos.tipificacion = drlEstadoInboun.SelectedItem.Text
            End If
            If txtFechaInicio.Text <> Nothing Then
                objdatos.fcini = txtFechaInicio.Text
            End If
            If txtFechaFin.Text <> Nothing Then
                objdatos.fcfin = txtFechaFin.Text
            End If
            If TxtBandeja.Text <> Nothing Then
                objdatos.mesa = TxtBandeja.Text
            End If
            dtggeneral.DataSource = objdatos.Consulta_Casos_Inbound
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBuscar.Click
        Try
            buscarinf()
            txtFechaInicio.Text = ""
            txtFechaFin.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Sub crearexcel()
        Dim sb As New StringBuilder
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim form = New HtmlForm
        Dim r As New clscrmdatos
        Dim objdtsconsultaxls As New DataSet
        Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
        If lblcuenta.Text <> Nothing Then
            If lblcuenta.Text < 20001 Then
                If drlEstadoInboun.SelectedItem.Value <> 8 Then
                    r.tipificacion = drlEstadoInboun.SelectedItem.Text
                End If
                If txtFechaInicio.Text <> Nothing Then
                    r.fcini = txtFechaInicio.Text
                End If
                If txtFechaFin.Text <> Nothing Then
                    r.fcfin = txtFechaFin.Text
                End If
                If TxtBandeja.Text <> Nothing Then
                    r.mesa = TxtBandeja.Text
                End If
                dtgxls.DataSource = r.Consulta_Casos_Inbound
                dtgxls.DataBind()
                dtgxls.Visible = True
                dtgxls.EnableViewState = False

                pagina.EnableEventValidation = False
                pagina.DesignerInitialize()
                pagina.Controls.Add(form)
                form.Controls.Add(dtgxls)
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

    Protected Sub Btnxls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btnxls.Click
        Try
            crearexcel()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
            lblmsg.ForeColor = Drawing.Color.Red
        End Try
    End Sub

    Protected Sub dtggeneral_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try

            dtggeneral.PageIndex = e.NewPageIndex
            buscarinf()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
End Class