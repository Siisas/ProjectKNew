Imports System.IO

Public Class AsignacionHorariosValidacion
    Inherits System.Web.UI.Page
    Dim ObjAdmin As New clsrrhh

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Obtengo los datos del usuario'
        Try
            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                With drlPersonalACargo
                    drlPersonalACargo.DataSource = ObjAdmin.Consulta_Personal_Cargo
                    drlPersonalACargo.DataTextField = "Jefe_Inmediato"
                    drlPersonalACargo.DataValueField = "Jefe_Inmediato"
                    drlPersonalACargo.DataBind()
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

    Public Sub Consulta()
        Try
            If RadBtnTipoConsulta.SelectedValue = Nothing Then
                lblmsg.Text = "Seleccione un tipo de consulta"
                Exit Sub
            End If
            If TxtFechaInicio.Text = "" Then
                lblmsg.Text = "Ingrese una fecha de inicio"
                Exit Sub
            End If
            If TxtFechaFin.Text = "" Then
                lblmsg.Text = "Ingrese una fecha de fin"
                Exit Sub
            End If
            If TxtCod_Agente.Text <> Nothing Then
                ObjAdmin.codigo = TxtCod_Agente.Text
            End If
            If drlPersonalACargo.Text <> "- Seleccione -" Or drlPersonalACargo.Text <> "" Or drlPersonalACargo.Text <> Nothing Then
                ObjAdmin.Jefe_Inmediato = drlPersonalACargo.Text
            End If
            ObjAdmin.fcini = TxtFechaInicio.Text
            ObjAdmin.fcfin = TxtFechaFin.Text
            If RadBtnTipoConsulta.SelectedValue = "General" Then
                ObjAdmin.Validacion = "1"
            Else
                If RadBtnTipoConsulta.SelectedValue = "Descanso" Then
                    ObjAdmin.Validacion = "2"
                    dtgdescanso.DataSource = ObjAdmin.Validacion_Horarios
                    dtgdescanso.DataBind()
                    LblCuenta.Text = ObjAdmin.cantidad
                    lblmsg.Text = ""
                    dtgGeneral.DataSource = Nothing
                    dtgGeneral.DataBind()
                    dtgnoprogramados.DataSource = Nothing
                    dtgnoprogramados.DataBind()
                    Dtgbusquedaseleccion.DataSource = Nothing
                    Dtgbusquedaseleccion.DataBind()
                    Dtgbusquedaseleccion1.DataSource = Nothing
                    Dtgbusquedaseleccion1.DataBind()
                    dtginformacionovedad.DataSource = Nothing
                    dtginformacionovedad.DataBind()
                    dtgValidacion.DataSource = Nothing
                    dtgValidacion.DataBind()
                    If Excel = True Then
                        dtgdescansoexcel.DataSource = ObjAdmin.Validacion_Horarios
                        dtgdescansoexcel.DataBind()
                    End If
                    Exit Sub
                Else
                    If RadBtnTipoConsulta.SelectedValue = "Validacion" Then
                        ObjAdmin.Validacion = "3"
                        dtgValidacion.DataSource = ObjAdmin.Validacion_Horarios
                        dtgValidacion.DataBind()
                        LblCuenta.Text = ObjAdmin.cantidad
                        lblmsg.Text = ""
                        dtgGeneral.DataSource = Nothing
                        dtgGeneral.DataBind()
                        dtgnoprogramados.DataSource = Nothing
                        dtgnoprogramados.DataBind()
                        Dtgbusquedaseleccion.DataSource = Nothing
                        Dtgbusquedaseleccion.DataBind()
                        Dtgbusquedaseleccion1.DataSource = Nothing
                        Dtgbusquedaseleccion1.DataBind()
                        dtginformacionovedad.DataSource = Nothing
                        dtginformacionovedad.DataBind()
                        dtgdescanso.DataSource = Nothing
                        dtgdescanso.DataBind()
                        If Excel = True Then
                            dtgValidacionExcel.DataSource = ObjAdmin.Validacion_Horarios
                            dtgValidacionExcel.DataBind()
                        End If
                        Exit Sub
                    Else
                        If RadBtnTipoConsulta.SelectedValue = "No Programadas" Then
                            ObjAdmin.Validacion = "4"
                            dtgnoprogramados.DataSource = ObjAdmin.Validacion_Horarios
                            dtgnoprogramados.DataBind()
                            LblCuenta.Text = ObjAdmin.cantidad
                            lblmsg.Text = ""
                            dtgGeneral.DataSource = Nothing
                            dtgGeneral.DataBind()
                            dtgValidacion.DataSource = Nothing
                            dtgValidacion.DataBind()
                            Dtgbusquedaseleccion.DataSource = Nothing
                            Dtgbusquedaseleccion.DataBind()
                            Dtgbusquedaseleccion1.DataSource = Nothing
                            Dtgbusquedaseleccion1.DataBind()
                            dtginformacionovedad.DataSource = Nothing
                            dtginformacionovedad.DataBind()
                            dtgdescanso.DataSource = Nothing
                            dtgdescanso.DataBind()
                            If Excel = True Then
                                dtgnoprogramadosExcel.DataSource = ObjAdmin.Validacion_Horarios
                                dtgnoprogramadosExcel.DataBind()

                            End If
                            Exit Sub
                        Else
                            If RadBtnTipoConsulta.SelectedValue = "Inf. Novedad" Then
                                ObjAdmin.Validacion = "5"
                                dtginformacionovedad.DataSource = ObjAdmin.Validacion_Horarios
                                dtginformacionovedad.DataBind()
                                LblCuenta.Text = ObjAdmin.cantidad
                                lblmsg.Text = ""
                                dtgGeneral.DataSource = Nothing
                                dtgGeneral.DataBind()
                                dtgValidacion.DataSource = Nothing
                                dtgValidacion.DataBind()
                                Dtgbusquedaseleccion.DataSource = Nothing
                                Dtgbusquedaseleccion.DataBind()
                                Dtgbusquedaseleccion1.DataSource = Nothing
                                Dtgbusquedaseleccion1.DataBind()
                                dtgdescanso.DataSource = Nothing
                                dtgdescanso.DataBind()
                                dtgnoprogramados.DataSource = Nothing
                                dtgnoprogramados.DataBind()
                                If Excel = True Then
                                    dtginformacionovedadexcel.DataSource = ObjAdmin.Validacion_Horarios
                                    dtginformacionovedadexcel.DataBind()

                                End If
                                Exit Sub
                            Else
                                ObjAdmin.Validacion = "6"
                            End If
                        End If
                    End If
                End If
            End If
            dtgGeneral.DataSource = ObjAdmin.Validacion_Horarios
            dtgGeneral.DataBind()

            LblCuenta.Text = ObjAdmin.cantidad

            If Excel = True Then
                dtgGeneralExcel.DataSource = ObjAdmin.Validacion_Horarios
                dtgGeneralExcel.DataBind()
            End If

            Dtgbusquedaseleccion.DataSource = Nothing
            Dtgbusquedaseleccion.DataBind()
            Dtgbusquedaseleccion1.DataSource = Nothing
            Dtgbusquedaseleccion1.DataBind()

            lblmsg.Text = ""
            dtginformacionovedad.DataSource = Nothing
            dtginformacionovedad.DataBind()
            dtgnoprogramados.DataSource = Nothing
            dtgnoprogramados.DataBind()
            dtgValidacion.DataSource = Nothing
            dtgValidacion.DataBind()
            dtgdescanso.DataSource = Nothing
            dtgdescanso.DataBind()

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnConsultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultar.Click
        Try
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub dtgGeneral_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles dtgGeneral.RowDataBound
        Try
            Dim FcIngreso As Date
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                FcIngreso = DateAdd(DateInterval.Minute, 1, DataBinder.Eval(e.Row.DataItem, "Fc_Ingreso"))
                If DataBinder.Eval(e.Row.DataItem, "fcingreso") > FcIngreso Then
                    e.Row.Cells(3).ForeColor = Drawing.Color.Red
                    e.Row.Cells(10).BackColor = Drawing.Color.Red
                    e.Row.Cells(10).ForeColor = Drawing.Color.White
                Else
                    e.Row.Cells(3).ForeColor = Drawing.Color.Green
                End If
                If DataBinder.Eval(e.Row.DataItem, "fcsalida") < DataBinder.Eval(e.Row.DataItem, "Fc_Salida") Then
                    e.Row.Cells(5).ForeColor = Drawing.Color.Red
                    e.Row.Cells(10).BackColor = Drawing.Color.Red
                    e.Row.Cells(10).ForeColor = Drawing.Color.White
                Else
                    e.Row.Cells(5).ForeColor = Drawing.Color.Green
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub


    Public Sub CrearExcel()
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
            If dtgGeneralExcel.Rows.Count > 1 Then
                dtgGeneralExcel.Visible = True
                form.Controls.Add(dtgGeneralExcel)
            Else
                If dtgValidacionExcel.Rows.Count > 1 Then
                    dtgValidacionExcel.Visible = True
                    form.Controls.Add(dtgValidacionExcel)
                Else
                    dtgnoprogramadosExcel.Visible = True
                    form.Controls.Add(dtgnoprogramadosExcel)
                End If
                If dtginformacionovedadexcel.Rows.Count > 1 Then
                    dtginformacionovedadexcel.Visible = True
                    form.Controls.Add(dtginformacionovedadexcel)
                Else
                    dtgdescansoexcel.Visible = True
                    form.Controls.Add(dtgdescansoexcel)
                End If
            End If
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True

            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=Validacion_Horarios.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Dim Excel As Boolean = False
    Protected Sub BtnExporExc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnExporExc.Click
        Try
            If (TxtCod_Agente.Text = Nothing And TxtFechaInicio.Text = Nothing And TxtFechaFin.Text = Nothing And drlPersonalACargo.SelectedItem.Text = Nothing) Or (LblCuenta.Text = "" Or LblCuenta.Text = "0") Then
                lblmsg.Text = "Antes de exportar realice una consulta"
                Exit Sub
            End If
            Excel = True
            Consulta()
            CrearExcel()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub dtgGeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgGeneral.PageIndexChanging
        Try
            dtgGeneral.PageIndex = e.NewPageIndex
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub dtgGeneralExcel_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles dtgGeneralExcel.RowDataBound
        Try
            Dim FcIngreso As Date
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                FcIngreso = DateAdd(DateInterval.Minute, 1, DataBinder.Eval(e.Row.DataItem, "Fc_Ingreso"))
                If DataBinder.Eval(e.Row.DataItem, "fcingreso") > FcIngreso Then
                    e.Row.Cells(3).ForeColor = Drawing.Color.Red
                    e.Row.Cells(10).BackColor = Drawing.Color.Red
                    e.Row.Cells(10).ForeColor = Drawing.Color.White
                    e.Row.Cells(10).Text = "-O-"
                Else
                    e.Row.Cells(1).ForeColor = Drawing.Color.Green
                End If
                If DataBinder.Eval(e.Row.DataItem, "fcsalida") < DataBinder.Eval(e.Row.DataItem, "Fc_Salida") Then
                    e.Row.Cells(5).ForeColor = Drawing.Color.Red
                    e.Row.Cells(10).BackColor = Drawing.Color.Red
                    e.Row.Cells(10).ForeColor = Drawing.Color.White
                    e.Row.Cells(10).Text = "-O-"
                Else
                    e.Row.Cells(3).ForeColor = Drawing.Color.Green
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub


    Protected Sub dtgnoprogramados_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgnoprogramados.PageIndexChanging
        Try
            dtgnoprogramados.PageIndex = e.NewPageIndex
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub dtgGeneral_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtgGeneral.RowCommand
        Try
            If e.CommandName = "Seleccion" And TxtFechaInicio.Text = Nothing And TxtFechaFin.Text = Nothing Then
                lblmsg.Text = "Debe ingresar una fecha inicio y fecha fin"
                Exit Sub
            End If
            If e.CommandName = "Seleccion" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)

                ObjAdmin.codigo = dtgGeneral.Rows(index).Cells(0).Text
                ObjAdmin.fcregistro = FormatDateTime(dtgGeneral.Rows(index).Cells(3).Text, DateFormat.ShortDate)
                ObjAdmin.fcini = TxtFechaInicio.Text
                ObjAdmin.fcfin = TxtFechaFin.Text

                Dtgbusquedaseleccion.DataSource = ObjAdmin.consultarfechaalerta
                Dtgbusquedaseleccion.DataBind()
                LblCuenta.Text = ObjAdmin.cantidad
            End If
            dtgGeneral.DataSource = Nothing
            dtgGeneral.DataBind()
            Dtgbusquedaseleccion1.DataSource = Nothing
            Dtgbusquedaseleccion1.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se presentó error " & ex.Message
        End Try
    End Sub

    Protected Sub Dtgbusquedaseleccion_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles Dtgbusquedaseleccion.RowCommand
        Try
            If e.CommandName = "Aprobado" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)

                ObjAdmin.id = Dtgbusquedaseleccion.Rows(index).Cells(0).Text
                ObjAdmin.codigo = Dtgbusquedaseleccion.Rows(index).Cells(1).Text
                ObjAdmin.fcregistro = FormatDateTime(Dtgbusquedaseleccion.Rows(index).Cells(14).Text, DateFormat.ShortDate)
                ObjAdmin.idusuario = lblusuario.Text
                Dtgbusquedaseleccion.DataSource = ObjAdmin.consultacodigonovedad
                ObjAdmin.agregaraprobacion()
                Dtgbusquedaseleccion.DataBind()
                Dtgbusquedaseleccion1.DataSource = ObjAdmin.consultacodigonovedad
                Dtgbusquedaseleccion1.DataBind()

            End If
            If e.CommandName = "Anulado" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                ObjAdmin.id = Dtgbusquedaseleccion.Rows(index).Cells(0).Text
                ObjAdmin.codigo = Dtgbusquedaseleccion.Rows(index).Cells(1).Text
                ObjAdmin.fcregistro = FormatDateTime(Dtgbusquedaseleccion.Rows(index).Cells(14).Text, DateFormat.ShortDate)
                ObjAdmin.idusuario = lblusuario.Text
                Dtgbusquedaseleccion.DataSource = ObjAdmin.consultacodigonovedad
                ObjAdmin.agregarnoaprobacion()
                Dtgbusquedaseleccion.DataBind()
                Dtgbusquedaseleccion1.DataSource = ObjAdmin.consultacodigonovedad
                Dtgbusquedaseleccion1.DataBind()

            End If
            Dtgbusquedaseleccion.DataSource = Nothing
            Dtgbusquedaseleccion.DataBind()
            If e.CommandName = "Aprobado" Then
                lblmsg.Text = "La novedad fue aprobada"
            Else
                lblmsg.Text = "La novedad fue anulada"
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presentó error " & ex.Message
        End Try
    End Sub

    Protected Sub Dtgbusquedaseleccion_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Dtgbusquedaseleccion.PageIndexChanging
        Try
            Dtgbusquedaseleccion.PageIndex = e.NewPageIndex
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se presentó error: " + ex.Message
        End Try
    End Sub

    Protected Sub Dtgbusquedaseleccion1_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Dtgbusquedaseleccion1.PageIndexChanging
        Try
            Dtgbusquedaseleccion1.PageIndex = e.NewPageIndex
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se presentó error: " + ex.Message
        End Try
    End Sub

    Protected Sub Dtgbusquedaseleccion_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtgbusquedaseleccion.RowDataBound
        Try
            Dim FcMenosTres As String = Today.AddDays(-3)
            Dim FcMenosCinco As String = Today.AddDays(-5)

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                If DataBinder.Eval(e.Row.DataItem, "fcnovedad") <= FcMenosTres Then
                    e.Row.Cells(17).BackColor = Drawing.Color.Orange
                    e.Row.Cells(17).ForeColor = Drawing.Color.White
                End If
                If DataBinder.Eval(e.Row.DataItem, "fcnovedad") <= FcMenosCinco Then
                    e.Row.Cells(17).BackColor = Drawing.Color.Red
                    e.Row.Cells(17).ForeColor = Drawing.Color.White
                End If
                Dim sincolor As String = Convert.ToString(DataBinder.Eval(e.Row.DataItem, "Aprobacion"))
                If sincolor = "Aprobado" Or sincolor = "Anulado" Then
                    e.Row.Cells(17).BackColor = Drawing.Color.Empty
                    e.Row.Cells(17).ForeColor = Drawing.Color.Empty
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se peresento error: " + ex.Message
        End Try
    End Sub

    Protected Sub dtginformacionovedad_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtginformacionovedad.PageIndexChanging
        Try
            dtginformacionovedad.PageIndex = e.NewPageIndex
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se presentó error: " + ex.Message
        End Try
    End Sub

    Protected Sub dtgdescanso_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgdescanso.PageIndexChanging
        Try
            dtgdescanso.PageIndex = e.NewPageIndex
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub dtgValidacion_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgValidacion.PageIndexChanging
        Try
            dtgValidacion.PageIndex = e.NewPageIndex
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub Dtgbusquedaseleccion1_RowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtgbusquedaseleccion1.RowDataBound
        Try
            Dim FcMenosTres As String = Today.AddDays(-3)
            Dim FcMenosCinco As String = Today.AddDays(-5)
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                If DataBinder.Eval(e.Row.DataItem, "fcnovedad") <= FcMenosTres Then
                    e.Row.Cells(17).BackColor = Drawing.Color.Orange
                    e.Row.Cells(17).ForeColor = Drawing.Color.White
                End If
                If DataBinder.Eval(e.Row.DataItem, "fcnovedad") <= FcMenosCinco Then
                    e.Row.Cells(17).BackColor = Drawing.Color.Red
                    e.Row.Cells(17).ForeColor = Drawing.Color.White
                End If
                Dim sincolor As String = Convert.ToString(DataBinder.Eval(e.Row.DataItem, "Aprobacion"))
                If sincolor = "Aprobado" Or sincolor = "Anulado" Then
                    e.Row.Cells(17).BackColor = Drawing.Color.Empty
                    e.Row.Cells(17).ForeColor = Drawing.Color.Empty
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presentó error: " + ex.Message
        End Try
    End Sub
    Protected Sub RadBtnTipoConsulta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadBtnTipoConsulta.SelectedIndexChanged
        Try
            If RadBtnTipoConsulta.SelectedValue = "No Programadas" Then
                TxtFechaFin.Enabled = False
            Else
                TxtFechaFin.Enabled = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presentó error: " + ex.Message
        End Try
    End Sub
End Class