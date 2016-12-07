Public Class Auditoria_Con_V4
    Inherits System.Web.UI.Page
    Dim ObjCalidad As New clscalidad
    Dim ObjValidacion As New Cls_Gestion_Datos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Consulta Auditoria V4"
                Consulta_Auditorias()
            End If
        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub

    Protected Sub Consulta_Auditorias()
        Try
            ObjCalidad.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            Session("dtggeneral_Calidad_Registro_v4") = ObjCalidad.Consulta_Auditorias_Agente_V4
            If ObjCalidad.cantidad > 0 Then
                dtggeneral.DataSource = Session("dtggeneral_Calidad_Registro_v4")
                dtggeneral.DataBind()

                LblCantidad.Text = "Registros encontrados: " & ObjCalidad.cantidad
            Else
                LblCantidad.Text = "Registros encontrados: 0"
                mostrar_Mensaje("No tiene registros de auditorias", "Informacion")
                dtggeneral.DataSource = Nothing
                dtggeneral.DataBind()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub dtggeneral_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles dtggeneral.RowCommand
        Try
            Dim Index As Integer

            Select Case e.CommandName
                Case "Select"
                    Index = Convert.ToInt32(e.CommandArgument)
                    ObjCalidad.Cod_Calidad_Registro = dtggeneral.Rows(Index).Cells(1).Text
                    ObjCalidad.Llenar_TextBox_V4()
                    If ObjCalidad.cantidad > 0 Then
                        Lblcaso.Text = ObjCalidad.caso
                        LblNomAgente.Text = ObjCalidad.agente
                        LblAuditorConsulta.Text = ObjCalidad.Auditor
                        LblCampaña.Text = ObjCalidad.Campania
                        LblProceso.Text = ObjCalidad.Proceso
                        Lbl_Tipo_PQR.Text = ObjCalidad.Tipo_PQR
                        Lbl_Tipo_Cliente.Text = ObjCalidad.Tipo_Cliente
                        LblFc_Llamada.Text = ObjCalidad.Fc_Llamada
                        LblTiempoAcumulado.Text = ObjCalidad.Tiempo_Acum_Llamada
                        LblCantidad_Llamadas.Text = ObjCalidad.N_Llamadas_Min
                        LblEstado.Text = ObjCalidad.Estado_Caso
                        LblTipo_Auditoria.Text = ObjCalidad.Tipo_Auditoria
                        '--------------Atencion--------------
                        Lbldisponibilidad_Atender_Llamada.Text = ObjCalidad.Disponibilidad_Atender_Llamada
                        LblObs_disponibilidad_Atender_Llamada.Text = ObjCalidad.Obs_disponibilidad_Atender_Llamada
                        LblAmabilidad_lenguaje_apropiado.Text = ObjCalidad.Amabilidad_lenguaje_apropiado
                        LblObs_Amabilidad_lenguaje_apropiado.Text = ObjCalidad.Obs_Amabilidad_lenguaje_apropiado
                        LblManejo_Tiempo.Text = ObjCalidad.Manejo_Tiempo
                        LblObs_Manejo_Tiempo.Text = ObjCalidad.Obs_Manejo_Tiempo
                        LblContacto_Activo.Text = ObjCalidad.Contacto_Activo
                        LblObs_Contacto_Activo.Text = ObjCalidad.Obs_Contacto_Activo
                        '--------------Gestion-----------------
                        LblConcentracion_durante_llamada.Text = ObjCalidad.Concentracion_durante_llamada
                        LblObs_Concentracion_durante_llamada.Text = ObjCalidad.Obs_Concentracion_durante_llamada
                        LblProcedimientos_conocimientos.Text = ObjCalidad.Procedimientos_conocimientos
                        LblObs_Procedimientos_conocimientos.Text = ObjCalidad.Obs_Procedimientos_conocimientos

                        '--------------Solucion----------------
                        LblInteres_Escuchar_entender_plantear_soluciones.Text = ObjCalidad.Interes_escuchar
                        LblObs_Interes_Escuchar_entender_plantear_soluciones.Text = ObjCalidad.Obs_Interes_escuchar
                        LblCuelgue_llamada.Text = ObjCalidad.Cuelgue_llamada
                        LblObs_Cuelgue_llamada.Text = ObjCalidad.Obs_Cuelgue_llamada
                        '--------------Cierre--------------------------
                        LblDocumentacion_sistema.Text = ObjCalidad.Documentacion
                        LblObs_Documentacion_sistema.Text = ObjCalidad.Obs_Documentacion
                        LblFinalizacion_despedida_llamada.Text = ObjCalidad.Finalizacion_despedida_llamada
                        LblObs_Finalizacion_despedida_llamada.Text = ObjCalidad.Obs_Finalizacion_despedida_llamada

                        '--------------Estadistica-----------------------
                        LblSolucion.Text = ObjCalidad.Solucion
                        LblObs_Solucion.Text = ObjCalidad.Obs_Solucion
                        LblReporta_Inc.Text = ObjCalidad.Reporta_Inc
                        LblSatisfaccion.Text = ObjCalidad.satisfaccion
                        LblObs_Generales.Text = ObjCalidad.Obs_General
                    Else
                        mostrar_Mensaje("No se encontraron registros con el codigo: " + dtggeneral.Rows(Index).Cells(1).Text, "Informacion")
                    End If

            End Select
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    'Cambia color
    Protected Sub dtggeneral_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles dtggeneral.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                e.Row.Cells(18).BackColor = Drawing.Color.FromArgb(212, 222, 160)
                e.Row.Cells(18).Font.Size = 10
                e.Row.Cells(19).BackColor = Drawing.Color.FromArgb(212, 222, 160)
                e.Row.Cells(19).Font.Size = 10
                e.Row.Cells(20).BackColor = Drawing.Color.FromArgb(212, 222, 160)
                e.Row.Cells(20).Font.Size = 10
                e.Row.Cells(21).BackColor = Drawing.Color.FromArgb(212, 222, 160)
                e.Row.Cells(21).Font.Size = 10
                e.Row.Cells(22).ForeColor = Drawing.Color.White
                e.Row.Cells(22).BackColor = Drawing.Color.FromArgb(179, 197, 86)
                e.Row.Cells(22).Font.Size = 10
            End If
        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub
    'Cambia pagina
    Protected Sub dtggeneral_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtggeneral.DataSource = Session("dtggeneral_Calidad_Registro_v4")
            dtggeneral.DataBind()
        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub
    'Mostrar Mensajes
    Sub mostrar_Mensaje(mensaje As String, tipo As String)
        Try
            If tipo = "Advertencia" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span Class='glyphicon glyphicon-warning-sign'></span> " & mensaje
            ElseIf tipo = "Error" Then
                Pnl_Message.CssClass = "alert alert-danger"
                lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & mensaje
            ElseIf tipo = "Correcto" Then
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> " & mensaje
            ElseIf tipo = "Informacion" Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> " & mensaje
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class