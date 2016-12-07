Imports System.IO

Public Class ReporteSolicitado
    Inherits System.Web.UI.Page
    Dim ObjReporte As New clsInformes

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
    Protected Sub drlCampaña_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlCampaña.SelectedIndexChanged
        If drlCampaña.Text = "Datos" Then
            drlconsultaVo.Visible = False
            drlconsultaVo.Text = "- Elija una opción -"
            drlconsultaDa.Visible = True
            drlconsultaDa.Text = "- Elija una opción -"
        Else
            If drlCampaña.Text = "Voz" Then
                drlconsultaDa.Visible = False
                drlconsultaDa.Text = "- Elija una opción -"
                drlconsultaVo.Visible = True
                drlconsultaVo.Text = "- Elija una opción -"
            End If
        End If
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            LblmsgReportes.Text = ""
            If drlCampaña.Text = "- Elija una opción -" Then
                LblmsgReportes.Text = "Ingrese Una campaña"
                Exit Sub
            End If
            If drlCampaña.Text = "Datos" Then
                If drlconsultaDa.Text = "- Elija una opción -" Then
                    LblmsgReportes.Text = "Ingrese una Sub Campaña para Datos"
                    Exit Sub
                End If
            Else
                If drlCampaña.Text = "Voz" Then
                    If drlconsultaVo.Text = "- Elija una opción -" Then
                        LblmsgReportes.Text = "Ingrese una Sub Campaña para Voz"
                        Exit Sub
                    End If
                End If
            End If
            If txtFecha.Text = "" Then
                LblmsgReportes.Text = "Ingrese una Fecha para la consulta"
                Exit Sub
            End If
            If drlCampaña.Text = "Datos" Then
                If drlconsultaDa.Text = "CIERRE" Then
                    ObjReporte.Fcini = txtFecha.Text
                    dtgReporteso8.DataSource = ObjReporte.Consulta_Cierre()
                    dtgReporteso8.DataBind()
                    lblcantidad.Text = ObjReporte.Cantidad
                    dtgReporteso8.Visible = True
                    dtgReporteso.Visible = False
                    dtgReporteso1.Visible = False
                    dtgReporteso2.Visible = False
                    dtgReporteso3.Visible = False
                    dtgReporteso4.Visible = False
                    dtgReporteso5.Visible = False
                    dtgReporteso6.Visible = False
                    dtgReporteso7.Visible = False
                    dtgReporteso9.Visible = False
                    dtgReporteso10.Visible = False
                    btnExportar.Visible = True
                Else
                    If drlconsultaDa.Text = "DATOS" Then
                        ObjReporte.Fcini = txtFecha.Text
                        dtgReporteso.DataSource = ObjReporte.Consulta_Datos()
                        dtgReporteso.DataBind()
                        lblcantidad.Text = ObjReporte.Cantidad
                        dtgReporteso.Visible = True
                        dtgReporteso1.Visible = False
                        dtgReporteso2.Visible = False
                        dtgReporteso3.Visible = False
                        dtgReporteso4.Visible = False
                        dtgReporteso5.Visible = False
                        dtgReporteso6.Visible = False
                        dtgReporteso7.Visible = False
                        dtgReporteso8.Visible = False
                        dtgReporteso9.Visible = False
                        dtgReporteso10.Visible = False
                        btnExportar.Visible = True
                    Else
                        If drlconsultaDa.Text = "DATOS_PREPAGO" Then
                            ObjReporte.Fcini = txtFecha.Text
                            dtgReporteso5.DataSource = ObjReporte.Consulta_DPrepa()
                            dtgReporteso5.DataBind()
                            lblcantidad.Text = ObjReporte.Cantidad
                            dtgReporteso5.Visible = True
                            dtgReporteso1.Visible = False
                            dtgReporteso2.Visible = False
                            dtgReporteso3.Visible = False
                            dtgReporteso4.Visible = False
                            dtgReporteso.Visible = False
                            dtgReporteso6.Visible = False
                            dtgReporteso7.Visible = False
                            dtgReporteso8.Visible = False
                            dtgReporteso9.Visible = False
                            dtgReporteso10.Visible = False
                            btnExportar.Visible = True
                        Else
                            If drlconsultaDa.Text = "DATOS_POSPAGO" Then
                                ObjReporte.Fcini = txtFecha.Text
                                dtgReporteso1.DataSource = ObjReporte.Consulta_DPospa()
                                dtgReporteso1.DataBind()
                                lblcantidad.Text = ObjReporte.Cantidad
                                dtgReporteso1.Visible = True
                                dtgReporteso.Visible = False
                                dtgReporteso2.Visible = False
                                dtgReporteso3.Visible = False
                                dtgReporteso4.Visible = False
                                dtgReporteso5.Visible = False
                                dtgReporteso6.Visible = False
                                dtgReporteso7.Visible = False
                                dtgReporteso8.Visible = False
                                dtgReporteso9.Visible = False
                                dtgReporteso10.Visible = False
                                btnExportar.Visible = True
                            Else
                                If drlconsultaDa.Text = "4G-LTE" Then
                                    ObjReporte.Fcini = txtFecha.Text
                                    dtgReporteso.DataSource = ObjReporte.Consulta_4glte()
                                    dtgReporteso.DataBind()
                                    lblcantidad.Text = ObjReporte.Cantidad
                                    dtgReporteso.Visible = True
                                    dtgReporteso1.Visible = False
                                    dtgReporteso2.Visible = False
                                    dtgReporteso3.Visible = False
                                    dtgReporteso4.Visible = False
                                    dtgReporteso5.Visible = False
                                    dtgReporteso6.Visible = False
                                    dtgReporteso7.Visible = False
                                    dtgReporteso8.Visible = False
                                    dtgReporteso9.Visible = False
                                    dtgReporteso10.Visible = False
                                    btnExportar.Visible = True
                                Else
                                    If drlconsultaDa.Text = "EMPRESARIALES" Then
                                        ObjReporte.Fcini = txtFecha.Text
                                        dtgReporteso6.DataSource = ObjReporte.Consulta_Empresa()
                                        dtgReporteso6.DataBind()
                                        lblcantidad.Text = ObjReporte.Cantidad
                                        dtgReporteso6.Visible = True
                                        dtgReporteso1.Visible = False
                                        dtgReporteso2.Visible = False
                                        dtgReporteso3.Visible = False
                                        dtgReporteso4.Visible = False
                                        dtgReporteso5.Visible = False
                                        dtgReporteso.Visible = False
                                        dtgReporteso7.Visible = False
                                        dtgReporteso8.Visible = False
                                        dtgReporteso9.Visible = False
                                        dtgReporteso10.Visible = False
                                        btnExportar.Visible = True
                                    Else
                                        If drlconsultaDa.Text = "NIVEL_3" Then
                                            ObjReporte.Fcini = txtFecha.Text
                                            dtgReporteso10.DataSource = ObjReporte.Consulta_Java()
                                            dtgReporteso10.DataBind()
                                            lblcantidad.Text = ObjReporte.Cantidad
                                            If lblcantidad.Text = 0 Then
                                                dtgReporteso10.Visible = False
                                            Else
                                                dtgReporteso10.Visible = True
                                            End If
                                            dtgReporteso3.DataSource = ObjReporte.Consulta_N3()
                                            dtgReporteso3.DataBind()
                                            lblcantidad.Text = ObjReporte.Cantidad
                                            dtgReporteso3.Visible = True
                                            dtgReporteso1.Visible = False
                                            dtgReporteso2.Visible = False
                                            dtgReporteso.Visible = False
                                            dtgReporteso4.Visible = False
                                            dtgReporteso5.Visible = False
                                            dtgReporteso6.Visible = False
                                            dtgReporteso7.Visible = False
                                            dtgReporteso8.Visible = False
                                            dtgReporteso9.Visible = False
                                            btnExportar.Visible = True
                                        Else
                                            If drlconsultaDa.Text = "PQR_DATOS" Then
                                                ObjReporte.Fcini = txtFecha.Text
                                                dtgReporteso4.DataSource = ObjReporte.Consulta_Pqr()
                                                dtgReporteso4.DataBind()
                                                lblcantidad.Text = ObjReporte.Cantidad
                                                dtgReporteso4.Visible = True
                                                dtgReporteso1.Visible = False
                                                dtgReporteso2.Visible = False
                                                dtgReporteso3.Visible = False
                                                dtgReporteso.Visible = False
                                                dtgReporteso5.Visible = False
                                                dtgReporteso6.Visible = False
                                                dtgReporteso7.Visible = False
                                                dtgReporteso8.Visible = False
                                                dtgReporteso9.Visible = False
                                                dtgReporteso10.Visible = False
                                                btnExportar.Visible = True
                                            Else
                                                If drlconsultaDa.Text = "INBOUND" Then
                                                    ObjReporte.Fcini = txtFecha.Text
                                                    dtgReporteso7.DataSource = ObjReporte.Consulta_In()
                                                    dtgReporteso7.DataBind()
                                                    lblcantidad.Text = ObjReporte.Cantidad
                                                    dtgReporteso7.Visible = True
                                                    dtgReporteso1.Visible = False
                                                    dtgReporteso2.Visible = False
                                                    dtgReporteso3.Visible = False
                                                    dtgReporteso4.Visible = False
                                                    dtgReporteso5.Visible = False
                                                    dtgReporteso6.Visible = False
                                                    dtgReporteso.Visible = False
                                                    dtgReporteso8.Visible = False
                                                    dtgReporteso9.Visible = False
                                                    dtgReporteso10.Visible = False
                                                    btnExportar.Visible = True
                                                Else
                                                    LblmsgReportes.Text = "Error en Sub Campaña de Datos"
                                                    Exit Sub
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If drlCampaña.Text = "Voz" Then
                If drlconsultaVo.Text = "CONSOLIDADO_VOZ" Then
                    ObjReporte.Fcini = txtFecha.Text
                    dtgReporteso2.DataSource = ObjReporte.Consulta_CosVoz()
                    dtgReporteso2.DataBind()
                    lblcantidad.Text = ObjReporte.Cantidad
                    dtgReporteso2.Visible = True
                    dtgReporteso1.Visible = False
                    dtgReporteso.Visible = False
                    dtgReporteso3.Visible = False
                    dtgReporteso4.Visible = False
                    dtgReporteso5.Visible = False
                    dtgReporteso6.Visible = False
                    dtgReporteso7.Visible = False
                    dtgReporteso8.Visible = False
                    dtgReporteso9.Visible = False
                    dtgReporteso10.Visible = False
                    btnExportar.Visible = True
                Else
                    If drlconsultaVo.Text = "VOZ" Then
                        ObjReporte.Fcini = txtFecha.Text
                        dtgReporteso9.DataSource = ObjReporte.Consulta_Voz()
                        dtgReporteso9.DataBind()
                        lblcantidad.Text = ObjReporte.Cantidad
                        dtgReporteso9.Visible = True
                        dtgReporteso1.Visible = False
                        dtgReporteso.Visible = False
                        dtgReporteso3.Visible = False
                        dtgReporteso4.Visible = False
                        dtgReporteso5.Visible = False
                        dtgReporteso6.Visible = False
                        dtgReporteso7.Visible = False
                        dtgReporteso8.Visible = False
                        dtgReporteso2.Visible = False
                        dtgReporteso10.Visible = False
                        btnExportar.Visible = True
                    Else
                        If drlconsultaVo.Text = "MENSAJES" Then
                            ObjReporte.Fcini = txtFecha.Text
                            dtgReporteso2.DataSource = ObjReporte.Consulta_Mensaje()
                            dtgReporteso2.DataBind()
                            lblcantidad.Text = ObjReporte.Cantidad
                            dtgReporteso2.Visible = True
                            dtgReporteso1.Visible = False
                            dtgReporteso.Visible = False
                            dtgReporteso3.Visible = False
                            dtgReporteso4.Visible = False
                            dtgReporteso5.Visible = False
                            dtgReporteso6.Visible = False
                            dtgReporteso7.Visible = False
                            dtgReporteso8.Visible = False
                            dtgReporteso9.Visible = False
                            dtgReporteso10.Visible = False
                            btnExportar.Visible = True
                        Else
                            If drlconsultaVo.Text = "BUZON" Then
                                ObjReporte.Fcini = txtFecha.Text
                                dtgReporteso2.DataSource = ObjReporte.Consulta_Buzon()
                                dtgReporteso2.DataBind()
                                lblcantidad.Text = ObjReporte.Cantidad
                                dtgReporteso2.Visible = True
                                dtgReporteso1.Visible = False
                                dtgReporteso.Visible = False
                                dtgReporteso3.Visible = False
                                dtgReporteso4.Visible = False
                                dtgReporteso5.Visible = False
                                dtgReporteso6.Visible = False
                                dtgReporteso7.Visible = False
                                dtgReporteso8.Visible = False
                                dtgReporteso9.Visible = False
                                dtgReporteso10.Visible = False
                                btnExportar.Visible = True
                            Else
                                If drlconsultaVo.Text = "OTROS SERV" Then
                                    ObjReporte.Fcini = txtFecha.Text
                                    dtgReporteso2.DataSource = ObjReporte.Consulta_Otroserv()
                                    dtgReporteso2.DataBind()
                                    lblcantidad.Text = ObjReporte.Cantidad
                                    dtgReporteso2.Visible = True
                                    dtgReporteso1.Visible = False
                                    dtgReporteso.Visible = False
                                    dtgReporteso3.Visible = False
                                    dtgReporteso4.Visible = False
                                    dtgReporteso5.Visible = False
                                    dtgReporteso6.Visible = False
                                    dtgReporteso7.Visible = False
                                    dtgReporteso8.Visible = False
                                    dtgReporteso9.Visible = False
                                    dtgReporteso10.Visible = False
                                    btnExportar.Visible = True
                                Else
                                    If drlconsultaVo.Text = "LDI" Then
                                        ObjReporte.Fcini = txtFecha.Text
                                        dtgReporteso2.DataSource = ObjReporte.Consulta_LDIvoz()
                                        dtgReporteso2.DataBind()
                                        lblcantidad.Text = ObjReporte.Cantidad
                                        dtgReporteso2.Visible = True
                                        dtgReporteso1.Visible = False
                                        dtgReporteso.Visible = False
                                        dtgReporteso3.Visible = False
                                        dtgReporteso4.Visible = False
                                        dtgReporteso5.Visible = False
                                        dtgReporteso6.Visible = False
                                        dtgReporteso7.Visible = False
                                        dtgReporteso8.Visible = False
                                        dtgReporteso9.Visible = False
                                        dtgReporteso10.Visible = False
                                        btnExportar.Visible = True
                                    Else
                                        If drlconsultaVo.Text = "BANCA MOVIL" Then
                                            ObjReporte.Fcini = txtFecha.Text
                                            dtgReporteso2.DataSource = ObjReporte.Consulta_BancaMovil()
                                            dtgReporteso2.DataBind()
                                            lblcantidad.Text = ObjReporte.Cantidad
                                            dtgReporteso2.Visible = True
                                            dtgReporteso1.Visible = False
                                            dtgReporteso.Visible = False
                                            dtgReporteso3.Visible = False
                                            dtgReporteso4.Visible = False
                                            dtgReporteso5.Visible = False
                                            dtgReporteso6.Visible = False
                                            dtgReporteso7.Visible = False
                                            dtgReporteso8.Visible = False
                                            dtgReporteso9.Visible = False
                                            dtgReporteso10.Visible = False
                                            btnExportar.Visible = True
                                        Else
                                            If drlconsultaVo.Text = "PQR_VOZ" Then
                                                ObjReporte.Fcini = txtFecha.Text
                                                dtgReporteso2.DataSource = ObjReporte.Consulta_Pqrvoz()
                                                dtgReporteso2.DataBind()
                                                lblcantidad.Text = ObjReporte.Cantidad
                                                dtgReporteso2.Visible = True
                                                dtgReporteso1.Visible = False
                                                dtgReporteso.Visible = False
                                                dtgReporteso3.Visible = False
                                                dtgReporteso4.Visible = False
                                                dtgReporteso5.Visible = False
                                                dtgReporteso6.Visible = False
                                                dtgReporteso7.Visible = False
                                                dtgReporteso8.Visible = False
                                                dtgReporteso9.Visible = False
                                                dtgReporteso10.Visible = False
                                                btnExportar.Visible = True
                                            Else
                                                LblmsgReportes.Text = "Error en Sub Campaña de Datos"
                                                Exit Sub
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            LblmsgReportes.Text = ""
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Sepresento error: " + ex.Message
        End Try
    End Sub

    Protected Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            If lblcantidad.Text = 0 Then
                lblmsg.Text = "No hay datos que exportar"
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
            If dtgReporteso.Visible = True Then
                form.Controls.Add(dtgReporteso)
                pagina.RenderControl(htw)
                Response.Clear()
                Response.Buffer = True
            Else
                If dtgReporteso1.Visible = True Then
                    form.Controls.Add(dtgReporteso1)
                    pagina.RenderControl(htw)
                    Response.Clear()
                    Response.Buffer = True
                Else
                    If dtgReporteso2.Visible = True Then
                        form.Controls.Add(dtgReporteso2)
                        pagina.RenderControl(htw)
                        Response.Clear()
                        Response.Buffer = True
                    Else
                        If dtgReporteso3.Visible = True And dtgReporteso10.Visible = True Then
                            form.Controls.Add(dtgReporteso3)
                            form.Controls.Add(dtgReporteso10)
                            pagina.RenderControl(htw)
                            Response.Clear()
                            Response.Buffer = True
                        Else
                            If dtgReporteso3.Visible = True Then
                                form.Controls.Add(dtgReporteso3)
                                pagina.RenderControl(htw)
                                Response.Clear()
                                Response.Buffer = True
                            Else
                                If dtgReporteso4.Visible = True Then
                                    form.Controls.Add(dtgReporteso4)
                                    pagina.RenderControl(htw)
                                    Response.Clear()
                                    Response.Buffer = True
                                Else
                                    If dtgReporteso5.Visible = True Then
                                        form.Controls.Add(dtgReporteso5)
                                        pagina.RenderControl(htw)
                                        Response.Clear()
                                        Response.Buffer = True
                                    Else
                                        If dtgReporteso6.Visible = True Then
                                            form.Controls.Add(dtgReporteso6)
                                            pagina.RenderControl(htw)
                                            Response.Clear()
                                            Response.Buffer = True
                                        Else
                                            If dtgReporteso7.Visible = True Then
                                                form.Controls.Add(dtgReporteso7)
                                                pagina.RenderControl(htw)
                                                Response.Clear()
                                                Response.Buffer = True
                                            Else
                                                If dtgReporteso8.Visible = True Then
                                                    form.Controls.Add(dtgReporteso8)
                                                    pagina.RenderControl(htw)
                                                    Response.Clear()
                                                    Response.Buffer = True
                                                Else
                                                    If dtgReporteso9.Visible = True Then
                                                        form.Controls.Add(dtgReporteso9)
                                                        pagina.RenderControl(htw)
                                                        Response.Clear()
                                                        Response.Buffer = True
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
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
End Class