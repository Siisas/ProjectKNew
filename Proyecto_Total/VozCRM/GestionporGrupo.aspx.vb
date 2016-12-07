Imports System.IO
Public Class GestionporGrupo
    Inherits System.Web.UI.Page
    Dim ObjGestion As New clsInformes

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
    Protected Sub drlInforme_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlInforme.SelectedIndexChanged
        Try
            If drlInforme.Text = "Casos Gestionados" Then
                drljornada.Enabled = False
                drljornada.Text = "- Seleccionar -"
                txtcola.Enabled = False
                txtcola.Text = ""
            End If
            If drlInforme.Text = "Casos Reincidentes" Then
                drljornada.Enabled = False
                drljornada.Text = "- Seleccionar -"
                txtcola.Enabled = False
                txtcola.Text = ""
            End If
            If drlInforme.Text = "Casos 4G" Then
                drljornada.Enabled = False
                drljornada.Text = "- Seleccionar -"
                txtcola.Enabled = False
                txtcola.Text = ""
            End If
            If drlInforme.Text = "Dato" Then
                drljornada.Enabled = True
                drljornada.Text = "- Seleccionar -"
                txtcola.Enabled = True
                txtcola.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento erro: " + ex.Message
        End Try
    End Sub
    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If drlgrupo.Text = "- Seleccionar -" Then
                If drljornada.Text = "- Seleccionar -" Then
                    lblmsg.Text = "Ingrese el grupo que desea consultar"
                    Exit Sub
                End If
            End If
            If txtfini.Text = "" Then
                lblmsg.Text = "Ingrese una fecha para la consulta"
                Exit Sub
            End If
            If drlInforme.Text = "- Seleccionar -" Then
                lblmsg.Text = "Ingrese el informe que desea consultar"
                Exit Sub
            End If
            If drlgrupo.Text = "Datos" Then
                If txtfini.Text <> "" Then
                    If drlInforme.Text = "Casos Gestionados" Then
                        dtgConsultages0.Visible = False
                        dtgConsultages.Visible = True
                        ObjGestion.Fcini = txtfini.Text
                        dtgConsultages.DataSource = ObjGestion.Consulta_Casges()
                        dtgConsultages.DataBind()
                        lblcantidad.Text = ObjGestion.Cantidad
                        btnExportar.Visible = True
                    End If
                    If drlInforme.Text = "Casos Reincidentes" Then
                        dtgConsultages0.Visible = False
                        dtgConsultages.Visible = True
                        ObjGestion.Fcini = txtfini.Text
                        dtgConsultages.DataSource = ObjGestion.Consulta_Casres()
                        dtgConsultages.DataBind()
                        lblcantidad.Text = ObjGestion.Cantidad
                        btnExportar.Visible = True
                    End If
                    If drlInforme.Text = "Casos 4G" Then
                        dtgConsultages0.Visible = False
                        dtgConsultages.Visible = True
                        ObjGestion.Fcini = txtfini.Text
                        dtgConsultages.DataSource = ObjGestion.Consulta_Cas4g()
                        dtgConsultages.DataBind()
                        lblcantidad.Text = ObjGestion.Cantidad
                        btnExportar.Visible = True
                    End If
                    If drlInforme.Text = "Dato" Then
                        If drljornada.Text = "- Seleccionar -" Then
                            lblmsg.Text = "Ingrese la jornada del grupo que desea consultar"
                            Exit Sub
                        End If
                        If drljornada.Text = "Mañana" Then
                            If txtcola.Text = Nothing Then
                                lblmsg.Text = "Ingrese la Cola del grupo que desea consultar"
                                Exit Sub
                            End If
                        End If
                        If drljornada.Text = "Mañana" Then
                            If txtcola.Text = Nothing Then
                                lblmsg.Text = "Ingrese la Cola del grupo que desea consultar"
                                Exit Sub
                            End If
                            If txtcola.Text <> Nothing Then
                                dtgConsultages.Visible = False
                                dtgConsultages0.Visible = True
                                ObjGestion.Fcini = txtfini.Text
                                ObjGestion.Cola = txtcola.Text
                                dtgConsultages0.DataSource = ObjGestion.Consulta_Casda()
                                dtgConsultages0.DataBind()
                                lblcantidad.Text = ObjGestion.Cantidad
                                btnExportar.Visible = True
                            End If
                        End If
                        If drljornada.Text = "Tarde" Then
                            If txtcola.Text = Nothing Then
                                lblmsg.Text = "Ingrese la Cola del grupo que desea consultar"
                                Exit Sub
                            End If
                            If txtcola.Text <> Nothing Then
                                dtgConsultages.Visible = False
                                dtgConsultages0.Visible = True
                                ObjGestion.Fcini = txtfini.Text
                                ObjGestion.Cola = txtcola.Text
                                dtgConsultages0.DataSource = ObjGestion.Consulta_Casda2()
                                dtgConsultages0.DataBind()
                                lblcantidad.Text = ObjGestion.Cantidad
                                btnExportar.Visible = True
                            End If
                        End If
                    End If

                End If
            End If
            If drlgrupo.Text = "Voz" Then
                If txtfini.Text <> "" Then
                    If drlInforme.Text = "Casos Gestionados" Then
                        dtgConsultages0.Visible = False
                        dtgConsultages.Visible = True
                        ObjGestion.Fcini = txtfini.Text
                        dtgConsultages.DataSource = ObjGestion.Consulta_Casgesvoz()
                        dtgConsultages.DataBind()
                        lblcantidad.Text = ObjGestion.Cantidad
                        btnExportar.Visible = True
                    End If
                    If drlInforme.Text = "Casos Reincidentes" Then
                        dtgConsultages0.Visible = False
                        dtgConsultages.Visible = True
                        ObjGestion.Fcini = txtfini.Text
                        dtgConsultages.DataSource = ObjGestion.Consulta_Casresvoz()
                        dtgConsultages.DataBind()
                        lblcantidad.Text = ObjGestion.Cantidad
                        btnExportar.Visible = True
                    End If
                    If drlInforme.Text = "Casos 4G" Then
                        dtgConsultages.Visible = False
                        dtgConsultages0.Visible = False
                        btnExportar.Visible = False
                        lblcantidad.Text = ""
                        lblmsg.Text = "No aplica para Voz porfavor seleccionar otro informe"
                        Exit Sub
                    End If
                    If drlInforme.Text = "Dato" Then
                        If drljornada.Text = "- Seleccionar -" Then
                            lblmsg.Text = "Ingrese la jornada del grupo que desea consultar"
                            Exit Sub
                        End If
                        If drljornada.Text = "Mañana" Then
                            If txtcola.Text = Nothing Then
                                lblmsg.Text = "Ingrese la Cola del grupo que desea consultar"
                                Exit Sub
                            End If
                        End If
                        If drljornada.Text = "Mañana" Then
                            If txtcola.Text = Nothing Then
                                lblmsg.Text = "Ingrese la Cola del grupo que desea consultar"
                                Exit Sub
                            End If
                            If txtcola.Text <> Nothing Then
                                dtgConsultages.Visible = False
                                dtgConsultages0.Visible = True
                                ObjGestion.Fcini = txtfini.Text
                                ObjGestion.Cola = txtcola.Text
                                dtgConsultages0.DataSource = ObjGestion.Consulta_Casdavoz()
                                dtgConsultages0.DataBind()
                                lblcantidad.Text = ObjGestion.Cantidad
                                btnExportar.Visible = True
                            End If
                        End If
                        If drljornada.Text = "Tarde" Then
                            If txtcola.Text = Nothing Then
                                lblmsg.Text = "Ingrese la Cola del grupo que desea consultar"
                                Exit Sub
                            End If
                            If txtcola.Text <> Nothing Then
                                dtgConsultages.Visible = False
                                dtgConsultages0.Visible = True
                                ObjGestion.Fcini = txtfini.Text
                                ObjGestion.Cola = txtcola.Text
                                dtgConsultages0.DataSource = ObjGestion.Consulta_Casda2voz()
                                dtgConsultages0.DataBind()
                                lblcantidad.Text = ObjGestion.Cantidad
                                btnExportar.Visible = True
                            End If
                        End If
                    End If
                End If
            End If
            If lblcantidad.Text = Nothing Or lblcantidad.Text = 0 Then
                dtgConsultages0 = Nothing
                dtgConsultages = Nothing
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento erro: " + ex.Message
        End Try
        lblmsg.Text = ""
    End Sub

    Protected Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            If lblcantidad.Text = 0 Then
                lblmsg.Text = "No se encontraron datos que exportar"
                Exit Sub
            Else
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
            If drlgrupo.Text = "Datos" Then
                If txtfini.Text <> "" Then
                    If drlInforme.Text = "Casos Gestionados" Then
                        dtgConsultages1.Visible = True
                        ObjGestion.Fcini = txtfini.Text
                        dtgConsultages1.DataSource = ObjGestion.Consulta_Casges()
                        dtgConsultages1.DataBind()
                        form.Controls.Add(dtgConsultages1)
                        pagina.RenderControl(htw)
                        Response.Clear()
                        Response.Buffer = True
                    End If
                    If drlInforme.Text = "Casos Reincidentes" Then
                        dtgConsultages1.Visible = True
                        ObjGestion.Fcini = txtfini.Text
                        dtgConsultages1.DataSource = ObjGestion.Consulta_Casres()
                        dtgConsultages1.DataBind()
                        form.Controls.Add(dtgConsultages1)
                        pagina.RenderControl(htw)
                        Response.Clear()
                        Response.Buffer = True
                    End If
                    If drlInforme.Text = "Casos 4G" Then
                        dtgConsultages1.Visible = True
                        ObjGestion.Fcini = txtfini.Text
                        dtgConsultages1.DataSource = ObjGestion.Consulta_Cas4g()
                        dtgConsultages1.DataBind()
                        form.Controls.Add(dtgConsultages1)
                        pagina.RenderControl(htw)
                        Response.Clear()
                        Response.Buffer = True
                    End If
                    If drlInforme.Text = "Dato" Then
                        If drljornada.Text = "- Seleccionar -" Then
                            lblmsg.Text = "Ingrese la jornada del grupo que desea consultar"
                            Exit Sub
                        End If
                        If drljornada.Text = "Mañana" Then
                            If txtcola.Text = Nothing Then
                                lblmsg.Text = "Ingrese la Cola del grupo que desea consultar"
                                Exit Sub
                            End If
                        End If
                        If drljornada.Text = "Mañana" Then
                            If txtcola.Text = Nothing Then
                                lblmsg.Text = "Ingrese la Cola del grupo que desea consultar"
                                Exit Sub
                            End If
                            If txtcola.Text <> Nothing Then
                                dtgConsultages2.Visible = True
                                ObjGestion.Fcini = txtfini.Text
                                ObjGestion.Cola = txtcola.Text
                                dtgConsultages2.DataSource = ObjGestion.Consulta_Casda()
                                dtgConsultages2.DataBind()
                                form.Controls.Add(dtgConsultages2)
                                pagina.RenderControl(htw)
                                Response.Clear()
                                Response.Buffer = True
                            End If
                        End If
                        If drljornada.Text = "Tarde" Then
                            If txtcola.Text = Nothing Then
                                lblmsg.Text = "Ingrese la Cola del grupo que desea consultar"
                                Exit Sub
                            End If
                            If txtcola.Text <> Nothing Then
                                dtgConsultages2.Visible = True
                                ObjGestion.Fcini = txtfini.Text
                                ObjGestion.Cola = txtcola.Text
                                dtgConsultages2.DataSource = ObjGestion.Consulta_Casda2()
                                dtgConsultages2.DataBind()
                                form.Controls.Add(dtgConsultages2)
                                pagina.RenderControl(htw)
                                Response.Clear()
                                Response.Buffer = True
                            End If
                        End If
                    End If

                End If
            End If
            If drlgrupo.Text = "Voz" Then
                If txtfini.Text <> "" Then
                    If drlInforme.Text = "Casos Gestionados" Then
                        dtgConsultages1.Visible = True
                        ObjGestion.Fcini = txtfini.Text
                        dtgConsultages1.DataSource = ObjGestion.Consulta_Casgesvoz()
                        dtgConsultages1.DataBind()
                        form.Controls.Add(dtgConsultages1)
                        pagina.RenderControl(htw)
                        Response.Clear()
                        Response.Buffer = True
                    End If
                    If drlInforme.Text = "Casos Reincidentes" Then
                        dtgConsultages1.Visible = True
                        ObjGestion.Fcini = txtfini.Text
                        dtgConsultages1.DataSource = ObjGestion.Consulta_Casresvoz()
                        dtgConsultages1.DataBind()
                        form.Controls.Add(dtgConsultages1)
                        pagina.RenderControl(htw)
                        Response.Clear()
                        Response.Buffer = True
                    End If
                    If drlInforme.Text = "Dato" Then
                        If drljornada.Text = "- Seleccionar -" Then
                            lblmsg.Text = "Ingrese la jornada del grupo que desea consultar"
                            Exit Sub
                        End If
                        If drljornada.Text = "Mañana" Then
                            If txtcola.Text = Nothing Then
                                lblmsg.Text = "Ingrese la Cola del grupo que desea consultar"
                                Exit Sub
                            End If
                        End If
                        If drljornada.Text = "Mañana" Then
                            If txtcola.Text = Nothing Then
                                lblmsg.Text = "Ingrese la Cola del grupo que desea consultar"
                                Exit Sub
                            End If
                            If txtcola.Text <> Nothing Then
                                dtgConsultages2.Visible = True
                                ObjGestion.Fcini = txtfini.Text
                                ObjGestion.Cola = txtcola.Text
                                dtgConsultages2.DataSource = ObjGestion.Consulta_Casdavoz()
                                dtgConsultages2.DataBind()
                                form.Controls.Add(dtgConsultages2)
                                pagina.RenderControl(htw)
                                Response.Clear()
                                Response.Buffer = True
                            End If
                        End If
                        If drljornada.Text = "Tarde" Then
                            If txtcola.Text = Nothing Then
                                lblmsg.Text = "Ingrese la Cola del grupo que desea consultar"
                                Exit Sub
                            End If
                            If txtcola.Text <> Nothing Then
                                dtgConsultages2.Visible = True
                                ObjGestion.Fcini = txtfini.Text
                                ObjGestion.Cola = txtcola.Text
                                dtgConsultages2.DataSource = ObjGestion.Consulta_Casda2voz()
                                dtgConsultages2.DataBind()
                                form.Controls.Add(dtgConsultages2)
                                pagina.RenderControl(htw)
                                Response.Clear()
                                Response.Buffer = True
                            End If
                        End If
                    End If
                End If
            End If
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

    Protected Sub dtgConsultages_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtgConsultages.PageIndexChanging
        Try
            If drlgrupo.Text = "Datos" Then
                If txtfini.Text <> "" Then
                    If drlInforme.Text = "Casos Gestionados" Then
                        dtgConsultages0.Visible = False
                        dtgConsultages.Visible = True
                        ObjGestion.Fcini = txtfini.Text
                        dtgConsultages.PageIndex = e.NewPageIndex
                        dtgConsultages.DataSource = ObjGestion.Consulta_Casges()
                        dtgConsultages.DataBind()
                        lblcantidad.Text = ObjGestion.Cantidad
                        btnExportar.Visible = True
                    End If
                    If drlInforme.Text = "Casos Reincidentes" Then
                        dtgConsultages0.Visible = False
                        dtgConsultages.Visible = True
                        ObjGestion.Fcini = txtfini.Text
                        dtgConsultages.PageIndex = e.NewPageIndex
                        dtgConsultages.DataSource = ObjGestion.Consulta_Casres()
                        dtgConsultages.DataBind()
                        lblcantidad.Text = ObjGestion.Cantidad
                        btnExportar.Visible = True
                    End If
                    If drlInforme.Text = "Casos 4G" Then
                        dtgConsultages0.Visible = False
                        dtgConsultages.Visible = True
                        ObjGestion.Fcini = txtfini.Text
                        dtgConsultages.PageIndex = e.NewPageIndex
                        dtgConsultages.DataSource = ObjGestion.Consulta_Cas4g()
                        dtgConsultages.DataBind()
                        lblcantidad.Text = ObjGestion.Cantidad
                        btnExportar.Visible = True
                    End If
                    If drlInforme.Text = "Dato" Then
                        If txtcola.Text <> Nothing Then
                            dtgConsultages.Visible = False
                            dtgConsultages0.Visible = True
                            ObjGestion.Fcini = txtfini.Text
                            ObjGestion.Cola = txtcola.Text
                            dtgConsultages0.PageIndex = e.NewPageIndex
                            dtgConsultages0.DataSource = ObjGestion.Consulta_Casda()
                            dtgConsultages0.DataBind()
                            lblcantidad.Text = ObjGestion.Cantidad
                            btnExportar.Visible = True
                        End If
                        End If
                        If drljornada.Text = "Tarde" Then
                            If txtcola.Text = Nothing Then
                                lblmsg.Text = "Ingrese la Cola del grupo que desea consultar"
                                Exit Sub
                            End If
                            If txtcola.Text <> Nothing Then
                                dtgConsultages.Visible = False
                                dtgConsultages0.Visible = True
                                ObjGestion.Fcini = txtfini.Text
                            ObjGestion.Cola = txtcola.Text
                            dtgConsultages0.PageIndex = e.NewPageIndex
                                dtgConsultages0.DataSource = ObjGestion.Consulta_Casda2()
                                dtgConsultages0.DataBind()
                                lblcantidad.Text = ObjGestion.Cantidad
                                btnExportar.Visible = True
                            End If
                        End If
                    End If

                End If
            If drlgrupo.Text = "Voz" Then
                If txtfini.Text <> "" Then
                    If drlInforme.Text = "Casos Gestionados" Then
                        dtgConsultages0.Visible = False
                        dtgConsultages.Visible = True
                        ObjGestion.Fcini = txtfini.Text
                        dtgConsultages.PageIndex = e.NewPageIndex
                        dtgConsultages.DataSource = ObjGestion.Consulta_Casgesvoz()
                        dtgConsultages.DataBind()
                        lblcantidad.Text = ObjGestion.Cantidad
                        btnExportar.Visible = True
                    End If
                    If drlInforme.Text = "Casos Reincidentes" Then
                        dtgConsultages0.Visible = False
                        dtgConsultages.Visible = True
                        ObjGestion.Fcini = txtfini.Text
                        dtgConsultages.PageIndex = e.NewPageIndex
                        dtgConsultages.DataSource = ObjGestion.Consulta_Casresvoz()
                        dtgConsultages.DataBind()
                        lblcantidad.Text = ObjGestion.Cantidad
                        btnExportar.Visible = True
                    End If
                    If drlInforme.Text = "Dato" Then
                        If txtcola.Text <> Nothing Then
                            dtgConsultages.Visible = False
                            dtgConsultages0.Visible = True
                            ObjGestion.Fcini = txtfini.Text
                            ObjGestion.Cola = txtcola.Text
                            dtgConsultages0.PageIndex = e.NewPageIndex
                            dtgConsultages0.DataSource = ObjGestion.Consulta_Casdavoz()
                            dtgConsultages0.DataBind()
                            lblcantidad.Text = ObjGestion.Cantidad
                            btnExportar.Visible = True
                        End If
                    End If
                    If drljornada.Text = "Tarde" Then
                        If txtcola.Text = Nothing Then
                            lblmsg.Text = "Ingrese la Cola del grupo que desea consultar"
                            Exit Sub
                        End If
                        If txtcola.Text <> Nothing Then
                            dtgConsultages.Visible = False
                            dtgConsultages0.Visible = True
                            ObjGestion.Fcini = txtfini.Text
                            ObjGestion.Cola = txtcola.Text
                            dtgConsultages0.PageIndex = e.NewPageIndex
                            dtgConsultages0.DataSource = ObjGestion.Consulta_Casda2voz()
                            dtgConsultages0.DataBind()
                            lblcantidad.Text = ObjGestion.Cantidad
                            btnExportar.Visible = True
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
End Class