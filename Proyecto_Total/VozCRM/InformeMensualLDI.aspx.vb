Imports System.IO

Public Class InformeMensualLDI
    Inherits System.Web.UI.Page
    Dim ObjCasos As New clsvoz
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
            lblmsg.Text = "Se presento erro: " + ex.Message
        End Try
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Format$(txtFechaIniFor.Text, "dd/mm/yyyy")
            Format$(txtFechaFinFor.Text, "dd/mm/yyyy")
            If txtFechaIniFor.Text = Nothing Then
                lblmsg.Text = "Ingrese una fecha inicial para consultar"
                Exit Sub
            End If
            If txtFechaFinFor.Text = Nothing Then
                lblmsg.Text = "Ingrese una fecha final para consultar"
                Exit Sub
            End If
            If CDate(txtFechaIniFor.Text) > CDate(txtFechaFinFor.Text) Then
                lblmsg.Text = "La fecha inicial es mayor que la fecha final del período"
                Exit Sub
            End If
            Consulta_Filtros()
            If lblcantidad.Text = "" Or lblcantidad.Text = "0" Then
                btnExportar.Visible = False
            Else
                btnExportar.Visible = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " + ex.Message
        End Try
    End Sub
    Public Sub Consulta_Filtros()
        Try
            ObjCasos.fechainicial = txtFechaIniFor.Text
            ObjCasos.fechafin = txtFechaFinFor.Text
            dtgCasos.DataSource = ObjCasos.Consulta_Casosinforme_LDI
            dtgCasos.DataBind()
            lblcantidad.Text = ObjCasos.cantidad
            lblmsg.Text = ""
            Exit Sub
        Catch ex As Exception
            lblmsg.Text = "Se presento error " + ex.Message
        End Try
    End Sub

    Protected Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            Exportarxls()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
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
            ObjCasos.fechainicial = txtFechaIniFor.Text
            ObjCasos.fechafin = txtFechaFinFor.Text
            dtgCasos2.DataSource = ObjCasos.Consulta_Casosinforme_LDI
            dtgCasos2.DataBind()
            pagina.EnableEventValidation = False
            pagina.DesignerInitialize()
            pagina.Controls.Add(form)
            If dtgCasos2.Visible = False Then
                dtgCasos2.Visible = True
            End If
            form.Controls.Add(dtgCasos2)
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
End Class