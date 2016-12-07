Imports System.IO
Public Class CasosProgramados
    Inherits System.Web.UI.Page
    Dim ObjAmdocs As New clsdatos
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

    Protected Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            If lblcantidad.Text = 0 Then
                lblmsg.Text = "No hay nada que exportar"
                Exit Sub
            Else
                lblmsg.Text = ""
                Exportarxls()
            End If
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


            pagina.EnableEventValidation = False
            pagina.DesignerInitialize()
            pagina.Controls.Add(form)
            If dtgConsultaAmdocs2.Visible = False Then
                dtgConsultaAmdocs2.Visible = True
            End If
            form.Controls.Add(dtgConsultaAmdocs2)
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

    Protected Sub btnNivel1_Click(sender As Object, e As EventArgs) Handles btnNivel1.Click
        Try
            btnExportar.Visible = True
            Consulta_Filtros()
        Catch ex As Exception
            lblmsg.Text = "Se presento error " + ex.Message
        End Try
    End Sub
    Public Sub Consulta_Filtros()
        Try
            Dim objamdocs As New clscrmdatos
            lblFechaactual.Text = ObjAmdocs.Fecha_Actuals
            lblHoraactual.Text = ObjAmdocs.Fecha_Actual_Horas
            If lblHoraactual.Text < "14:00:00" Then
                dtgConsultaAmdocs.DataSource = ObjAmdocs.ConsultaCasosAm1()
                dtgConsultaAmdocs.DataBind()
                dtgConsultaAmdocs2.DataSource = ObjAmdocs.ConsultaCasosAm1()
                dtgConsultaAmdocs2.DataBind()
                lblcantidad.Text = ObjAmdocs.Cantidad
                lblmsg.Text = ""
                Exit Sub
            Else
                If lblHoraactual.Text > "14:00:00" Then
                    dtgConsultaAmdocs.DataSource = ObjAmdocs.ConsultaCasosPm1()
                    dtgConsultaAmdocs.DataBind()
                    dtgConsultaAmdocs2.DataSource = ObjAmdocs.ConsultaCasosPm1()
                    dtgConsultaAmdocs2.DataBind()
                    lblcantidad.Text = ObjAmdocs.Cantidad
                    lblmsg.Text = ""
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " + ex.Message
        End Try
    End Sub
    Protected Sub btnNivel2_Click(sender As Object, e As EventArgs) Handles btnNivel2.Click
        Try
            btnExportar.Visible = True
            Consulta_Filtros2()
        Catch ex As Exception
            lblmsg.Text = "Se presento error " + ex.Message
        End Try
    End Sub
    Public Sub Consulta_Filtros2()
        Try
            Dim objamdocs As New clscrmdatos
            lblFechaactual.Text = ObjAmdocs.Fecha_Actuals
            lblHoraactual.Text = ObjAmdocs.Fecha_Actual_Horas
            If lblHoraactual.Text < "14:00:00" Then
                dtgConsultaAmdocs.DataSource = ObjAmdocs.ConsultaCasosAm2()
                dtgConsultaAmdocs.DataBind()
                dtgConsultaAmdocs2.DataSource = ObjAmdocs.ConsultaCasosAm2()
                dtgConsultaAmdocs2.DataBind()
                lblcantidad.Text = ObjAmdocs.Cantidad
                lblmsg.Text = ""
                Exit Sub
            Else
                If lblHoraactual.Text > "14:00:00" Then
                    dtgConsultaAmdocs.DataSource = ObjAmdocs.ConsultaCasosPm2()
                    dtgConsultaAmdocs.DataBind()
                    dtgConsultaAmdocs2.DataSource = ObjAmdocs.ConsultaCasosPm2()
                    dtgConsultaAmdocs2.DataBind()
                    lblcantidad.Text = ObjAmdocs.Cantidad
                    lblmsg.Text = ""
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " + ex.Message
        End Try
    End Sub
End Class