Public Class Auditoria_Con_V3
    Inherits System.Web.UI.Page
    Dim ObjCalidad As New clscalidad

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If Session("permisos") Is Nothing Then
                    Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
                End If
                Session("Formulario") = "Consulta Auditorias V3"
                Cargue_Auditorias()
            End If
        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert-danger"
            Lbl_Alerta.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Public Sub Cargue_Auditorias()
        Try
            ObjCalidad.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            dtggeneral.DataSource = ObjCalidad.Consulta_Auditorias_Agente_V3
            dtggeneral.DataBind()
            LblCuenta.Text = ObjCalidad.cantidad
        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert-danger"
            Lbl_Alerta.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Consultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Consultar.Click
        Try
            Dim dts As DataSet
            If TxtCod_Consulta.Text = "" Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese un codigo para realizar la consulta"
                Exit Sub
            Else
                ObjCalidad.Cod_Calidad_Registro = TxtCod_Consulta.Text
                ObjCalidad.Validacion = "1"
                ObjCalidad.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
                dts = ObjCalidad.Llenar_TextBox_V3()
                If dts.Tables(0).Rows.Count > 0 Then
                    Lbl_Tipo_Cliente.Text = ObjCalidad.Tipo_Cliente
                    Lbl_Tipo_PQR.Text = ObjCalidad.Tipo_PQR

                    Lblcaso.Text = ObjCalidad.caso
                    LblNomAgente.Text = ObjCalidad.agente
                    LblGrupo.Text = ObjCalidad.grupo
                    LblAuditor.Text = ObjCalidad.Auditor
                    LblProceso.Text = ObjCalidad.Proceso
                    LblCampaña.Text = ObjCalidad.Campania
                    LblFc_Llamada.Text = ObjCalidad.Fc_Llamada
                    LblTiempoAcumulado.Text = ObjCalidad.Tiempo_Acum_Llamada
                    LblCantidad_Llamadas.Text = ObjCalidad.N_Llamadas_Min
                    LblEstado.Text = ObjCalidad.Estado_Caso
                    LblTipo_Auditoria.Text = ObjCalidad.Tipo_Auditoria
                    LblManejo_Guion.Text = ObjCalidad.Amabilidad_Empatia
                    LblObs_Manejo_Guion.Text = ObjCalidad.Obs_Amabilidad_Empatia
                    LblDisponibilidad_Atender_Llamada.Text = ObjCalidad.Colgada_Llamada
                    LblObs_Disponibilidad_Para_AtenderDisponibilidad_Atender_Llamada.Text = ObjCalidad.Obs_Colgada_Llamada
                    lblCordialidad_Comunicacion.Text = ObjCalidad.Real_filtros_adecuados
                    LblObs_Cordialidad_Comunicacion.Text = ObjCalidad.Obs_Real_filtros_adecuados
                    LblClaridad_Transmitir_Informacion.Text = ObjCalidad.Corona_Abierta
                    LblObs_Claridad_Transmitir_Informacion.Text = ObjCalidad.Obs_Corona_Abierta
                    LblContacto_Activo.Text = ObjCalidad.Documentacion
                    LblObs_Contacto_Activo.Text = ObjCalidad.Obs_Documentacion
                    LblCorona_Abierta.Text = ObjCalidad.Procedimiento_PQR
                    LblObs_Corona_Abierta.Text = ObjCalidad.Obs_Procedimiento_PQR
                    LblAmabilidad_Empatia.Text = ObjCalidad.Procedimiento_prueba_tramite_incompleto_incorrecto
                    LblObs_Amabilidad_Empatia.Text = ObjCalidad.Obs_Procedimiento_prueba_tramite_incompleto_incorrecto
                    LblFiltros_Eficiencia_Gestion.Text = ObjCalidad.Presenta_objetivo_llamada
                    LblObs_Filtros_Eficiencia_Gestion.Text = ObjCalidad.Obs_Presenta_objetivo_llamada
                    LblInteres_Escuchar_Entender_Necesidades_Plantear_Soluciones.Text = ObjCalidad.Cordialidad_Comunicacion
                    LblObs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones.Text = ObjCalidad.Obs_Cordialidad_Comunicacion
                    LblEscucha_Activa.Text = ObjCalidad.Cordialidad
                    LblObs_Escucha_Activa.Text = ObjCalidad.Obs_Cordialidad
                    LblDocumentacion_Sistema.Text = ObjCalidad.Contacto_Activo
                    LblObs_Documentacion_Sistema.Text = ObjCalidad.Obs_Contacto_Activo
                    LblCuelgue_Llamada.Text = ObjCalidad.Claridad_transmitir_informacion
                    LblObs_Cuelgue_Llamada.Text = ObjCalidad.Obs_Claridad_transmitir_informacion
                    LblAplicacion_Manejo_Incompleto_Procedmientos_Tramites.Text = ObjCalidad.Gestion_Llamada
                    LblObs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites.Text = ObjCalidad.Obs_Gestion_Llamada
                    LblAplicacion_Manejo_Correcto_Procedimientos_Tramites.Text = ObjCalidad.Gestion_Soporte
                    LblObs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites.Text = ObjCalidad.Obs_Gestion_Soporte
                    LblResolucion_Necesidad_Cliente.Text = ObjCalidad.Gestion_Asignacion
                    LblObs_Resolucion_Necesidad_Cliente.Text = ObjCalidad.Obs_Gestion_Asignacion
                    LblProcedimiento_PQR.Text = ObjCalidad.Solucion
                    LblObs_Procedimiento_PQR.Text = ObjCalidad.Obs_Solucion
                    LblEscalamientos_Requeridos.Text = ObjCalidad.Interes_escuchar
                    LblObs_Escalamientos_Requeridos.Text = ObjCalidad.Obs_Interes_escuchar
                    LblObs_Generales.Text = ObjCalidad.Obs_General
                    LblSolucion_Primer_contacto.Text = ObjCalidad.Tono_voz
                    LblObs_Solucion_Primer_contacto.Text = ObjCalidad.obs_Tono_voz_Fluidez_verbal
                    LblSolucion_Parcial.Text = ObjCalidad.Reincide
                    LblObs_Solucion_Parcial.Text = ObjCalidad.obs_Reincide
                    Pnl_Alerta.CssClass = Nothing
                    Lbl_Alerta.Text = Nothing
                Else
                    Pnl_Alerta.CssClass = "alert alert-warning"
                    Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No se encontraron registros con el codigo: " & TxtCod_Consulta.Text
                    Lblcaso.Text = ""
                    LblNomAgente.Text = ""
                    LblGrupo.Text = ""
                    LblAuditor.Text = ""
                    LblProceso.Text = ""
                    LblCampaña.Text = ""
                    LblFc_Llamada.Text = ""
                    LblTiempoAcumulado.Text = ""
                    LblCantidad_Llamadas.Text = ""
                    LblEstado.Text = ""
                    LblTipo_Auditoria.Text = ""
                    LblManejo_Guion.Text = ""
                    lblCordialidad_Comunicacion.Text = ""
                    LblObs_Manejo_Guion.Text = ""
                    LblDisponibilidad_Atender_Llamada.Text = ""
                    LblObs_Disponibilidad_Para_AtenderDisponibilidad_Atender_Llamada.Text = ""
                    LblObs_Cordialidad_Comunicacion.Text = ""
                    LblClaridad_Transmitir_Informacion.Text = ""
                    LblObs_Claridad_Transmitir_Informacion.Text = ""
                    LblContacto_Activo.Text = ""
                    LblObs_Contacto_Activo.Text = ""
                    LblCorona_Abierta.Text = ""
                    LblObs_Corona_Abierta.Text = ""
                    LblAmabilidad_Empatia.Text = ""
                    LblObs_Amabilidad_Empatia.Text = ""
                    LblFiltros_Eficiencia_Gestion.Text = ""
                    LblObs_Filtros_Eficiencia_Gestion.Text = ""
                    LblInteres_Escuchar_Entender_Necesidades_Plantear_Soluciones.Text = ""
                    LblObs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones.Text = ""
                    LblEscucha_Activa.Text = ""
                    LblObs_Escucha_Activa.Text = ""
                    LblDocumentacion_Sistema.Text = ""
                    LblObs_Documentacion_Sistema.Text = ""
                    LblCuelgue_Llamada.Text = ""
                    LblObs_Cuelgue_Llamada.Text = ""
                    LblAplicacion_Manejo_Incompleto_Procedmientos_Tramites.Text = ""
                    LblObs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites.Text = ""
                    LblAplicacion_Manejo_Correcto_Procedimientos_Tramites.Text = ""
                    LblObs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites.Text = ""
                    LblResolucion_Necesidad_Cliente.Text = ""
                    LblObs_Resolucion_Necesidad_Cliente.Text = ""
                    LblProcedimiento_PQR.Text = ""
                    LblObs_Procedimiento_PQR.Text = ""
                    LblEscalamientos_Requeridos.Text = ""
                    LblObs_Escalamientos_Requeridos.Text = ""
                    LblObs_Generales.Text = ""
                    LblSolucion_Primer_contacto.Text = ""
                    LblObs_Solucion_Primer_contacto.Text = ""
                    LblSolucion_Parcial.Text = ""
                    LblObs_Solucion_Parcial.Text = ""
                    Lbl_Tipo_Cliente.Text = ""
                    Lbl_Tipo_PQR.Text = ""

                    Exit Sub
                End If
            End If
        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert-danger"
            Lbl_Alerta.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        Finally
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "show_loding", "PlegDes_Dinamico('#Desp_Loading', 'show', 'puff', 500, '');", True)
        End Try
    End Sub

    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex
            Cargue_Auditorias()
        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert-danger"
            Lbl_Alerta.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class