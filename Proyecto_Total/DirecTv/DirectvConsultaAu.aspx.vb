Public Class ConsultaAuDirectv
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblGrupo.Text = ""
                LblCampania.Text = ""
                Buscar()
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
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        Try
            Dim ObjCalidad As New clscalidad
            Dim dts As DataSet
            If TxtCod_Consulta.Text = "" Then
                lblmsg.Text = "Ingrese un codigo para realizar la consulta"
                Exit Sub
            Else
                lblmsg.Text = ""
                ObjCalidad.Cod_Calidad_Registro = TxtCod_Consulta.Text
                ObjCalidad.Validacion = 1
                ObjCalidad.CodigoAgente = lblusuario.Text
                dts = ObjCalidad.Llenar_informacionDirectv()
                If dts.Tables(0).Rows.Count > 0 Then
                    LblId_cliente.Text = ObjCalidad.caso
                    LblAsesor.Text = ObjCalidad.agente
                    LblAuditorConsulta.Text = ObjCalidad.Auditor
                    LblCampania.Text = ObjCalidad.Campania
                    LblGrupo.Text = ObjCalidad.grupo
                    LblFc_Llamada.Text = ObjCalidad.Fc_Llamada
                    LblTiempoAcumulado.Text = ObjCalidad.Tiempo_Acum_Llamada
                    LblCantidad_Llamadas.Text = ObjCalidad.N_Llamadas_Min
                    LblTipo_Llamada.Text = ObjCalidad.tipo_llamada
                    LblTipificacion.Text = ObjCalidad.tipificacion
                    LblTipoAuditoria.Text = ObjCalidad.Tipo_Auditoria
                    LblAmabilidad_Empatia.Text = ObjCalidad.Amabilidad_Empatia
                    LblObs_Amabilidad_Empatia.Text = ObjCalidad.Obs_Amabilidad_Empatia
                    LblColgada_Llamada.Text = ObjCalidad.Colgada_Llamada
                    LblObs_Colgada_Llamada.Text = ObjCalidad.Obs_Colgada_Llamada
                    LblDocumentacion.Text = ObjCalidad.Documentación_toma_datos
                    LblObs_Documentacion.Text = ObjCalidad.Obs_Documentación_toma_datos
                    LblBrindarInformacion.Text = ObjCalidad.Brindar_información_errada_cerrar_venta
                    LblObs_Brindar_Infromacion.Text = ObjCalidad.obs_Brindar_información_errada_cerrar_venta
                    LblInicia_LLamada.Text = ObjCalidad.Inicia_llamada_horario_saludo_identidad_motivo_llamada
                    LblObs_inicia_llamada.Text = ObjCalidad.obs_Inicia_llamada_horario_saludo_identidad_motivo_llamada
                    LblRealiza_Preguntas.Text = ObjCalidad.Realiza_preguntas_concretas_perfilar_cliente
                    LblObs_Realiza_Preguntas.Text = ObjCalidad.obs_Realiza_preguntas_concretas_perfilar_cliente
                    LblProceso.Text = ObjCalidad.Proceso
                    LblUso_Informacion.Text = ObjCalidad.Uso_información
                    LblObs_Uso_Informacion.Text = ObjCalidad.obs_Uso_información
                    LblConocimiento_Completo.Text = ObjCalidad.Tiene_conocimiento_completo_producto
                    LblObs_ConocomientoCompleto.Text = ObjCalidad.obs_Tiene_conocimiento_completo_producto
                    LblBeneficios_Producto.Text = ObjCalidad.Indica_beneficios_producto
                    LblObs_Beneficios_Producto.Text = ObjCalidad.obs_Indica_beneficios_producto
                    LblAclara_Dudas.Text = ObjCalidad.Aclara_dudas_tiene_cliente_acerca_servicio
                    LblObs_Aclara_Dudas.Text = ObjCalidad.obs_Aclara_dudas_tiene_cliente_acerca_servicio
                    LblPrecierre.Text = ObjCalidad.Realiza_precierre_ofrece_beneficio_producto
                    LblObs_Precierre_Beneficio_P.Text = ObjCalidad.obs_Realiza_precierre_ofrece_beneficio_producto
                    LblInformacion_Cierre.Text = ObjCalidad.Informacion_cierre
                    LblObs_Informacion_Cierre.Text = ObjCalidad.obs_Informacion_cierre
                    LblCierra_Venta_tiempo.Text = ObjCalidad.Cierra_venta_tiempo_oportuno
                    LblObs_Cierra_Venta.Text = ObjCalidad.obs_Cierra_venta_tiempo_oportuno
                    LblRebate_Objeciones.Text = ObjCalidad.Rebate_minimo_objecione_negativa_cliente
                    LblObs_Rebate_Objeciones.Text = ObjCalidad.obs_Rebate_minimo_objecione_negativa_cliente
                    LblManejo_Objeciones.Text = ObjCalidad.manejo_objeciones_coherente
                    LblObs_Manejo_Objecciones.Text = ObjCalidad.obs_manejo_objeciones_coherente
                    LblManejo_Llamada.Text = ObjCalidad.Retoma_llamada_tiempos_establecidos
                    LblObs_Retoma_Llamada.Text = ObjCalidad.obs_Retoma_llamada_tiempos_establecidos
                    LblAmbiente_Laboral.Text = ObjCalidad.evidencia_ambiente_laboral
                    LblObs_Evidencia_Ambiente.Text = ObjCalidad.obs_evidencia_ambiente_laboral
                    LblTono_Voz.Text = ObjCalidad.Tono_voz
                    LblObs_Tono_Voz.Text = ObjCalidad.obs_Tono_voz_Fluidez_verbal
                    LblPersonaliza_Llamada.Text = ObjCalidad.Personaliza_llamada
                    LblObs_Personaliza_llamada.Text = ObjCalidad.obs_Personaliza_llamada
                    LblHabilidad_Escucha.Text = ObjCalidad.Habilidad_escucha
                    LblObs_Habilidad_Escucha.Text = ObjCalidad.obs_Habilidad_escucha
                    LblCordialidad_Empatia.Text = ObjCalidad.Cordialidad_empatia
                    LblObs_Cordialidad_Empatia.Text = ObjCalidad.obs_Cordialidad_empatia
                    LblTipifica_Apropiadamente.Text = ObjCalidad.Tipifica_apropiadamente_gestió_llamada_aplicativos
                    LblObs_Tipifica_Apropiadamente.Text = ObjCalidad.obs_Tipifica_apropiadamente_gestió_llamada_aplicativos
                    LblObs_Generales.Text = ObjCalidad.Obs_General
                Else
                    lblmsg.Text = "No se encontraron registros con el codigo: " + TxtCod_Consulta.Text
                    Limpiar()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Sub limpiar()
        LblGrupo.Text = ""
        LblId_cliente.Text = ""
        LblAsesor.Text = ""
        LblAuditorConsulta.Text = ""
        LblCampania.Text = ""
        LblFc_Llamada.Text = ""
        LblTiempoAcumulado.Text = ""
        LblCantidad_Llamadas.Text = ""
        LblTipo_Llamada.Text = ""
        LblTipificacion.Text = ""
        LblTipoAuditoria.Text = ""
        LblAmabilidad_Empatia.Text = ""
        LblObs_Amabilidad_Empatia.Text = ""
        LblColgada_Llamada.Text = ""
        LblObs_Colgada_Llamada.Text = ""
        LblDocumentacion.Text = ""
        LblObs_Documentacion.Text = ""
        LblBrindarInformacion.Text = ""
        LblObs_Brindar_Infromacion.Text = ""
        LblInicia_LLamada.Text = ""
        LblObs_inicia_llamada.Text = ""
        LblRealiza_Preguntas.Text = ""
        LblObs_Realiza_Preguntas.Text = ""
        LblProceso.Text = ""
        LblUso_Informacion.Text = ""
        LblObs_Uso_Informacion.Text = ""
        LblConocimiento_Completo.Text = ""
        LblObs_ConocomientoCompleto.Text = ""
        LblBeneficios_Producto.Text = ""
        LblObs_Beneficios_Producto.Text = ""
        LblAclara_Dudas.Text = ""
        LblObs_Aclara_Dudas.Text = ""
        LblPrecierre.Text = ""
        LblObs_Precierre_Beneficio_P.Text = ""
        LblInformacion_Cierre.Text = ""
        LblObs_Informacion_Cierre.Text = ""
        LblCierra_Venta_tiempo.Text = ""
        LblObs_Cierra_Venta.Text = ""
        LblRebate_Objeciones.Text = ""
        LblObs_Rebate_Objeciones.Text = ""
        LblManejo_Objeciones.Text = ""
        LblObs_Manejo_Objecciones.Text = ""
        LblManejo_Llamada.Text = ""
        LblObs_Retoma_Llamada.Text = ""
        LblAmbiente_Laboral.Text = ""
        LblObs_Evidencia_Ambiente.Text = ""
        LblTono_Voz.Text = ""
        LblObs_Tono_Voz.Text = ""
        LblPersonaliza_Llamada.Text = ""
        LblObs_Personaliza_llamada.Text = ""
        LblHabilidad_Escucha.Text = ""
        LblObs_Habilidad_Escucha.Text = ""
        LblCordialidad_Empatia.Text = ""
        LblObs_Cordialidad_Empatia.Text = ""
        LblTipifica_Apropiadamente.Text = ""
        LblObs_Tipifica_Apropiadamente.Text = ""
        LblObs_Generales.Text = ""
    End Sub
    Sub Buscar()
        Dim ObjCalidad As New clscalidad
        ObjCalidad.Validacion = 1
        ObjCalidad.Id_Usuario = lblusuario.Text
        ObjCalidad.CodigoAgente = lblusuario.Text
        Session("dtsB") = ObjCalidad.Consulta_Auditorias_De()
        dtggeneral.DataSource = Session("dtsB")
        dtggeneral.DataBind()
        LblCantidad.Text = ObjCalidad.cantidad
    End Sub
    'Protected Sub BtnConsultaAditorias_Click(sender As Object, e As EventArgs) Handles BtnConsultaAditorias.Click
    '  Try
    ' Dim ObjCalidad As New clscalidad
    '   If TxtCod_Agente.Text = "" And TxtFechaInicio.Text = "" And TxtFechaFin.Text = "" Then
    '      lblmsg.Text = "Ingrese un filtro para realzar la busqueda"
    '      Exit Sub
    '   ElseIf TxtCod_Agente.Text <> "" Then
    '      ObjCalidad.Id_Usuario = TxtCod_Agente.Text
    '  End If
    '  If TxtFechaInicio.Text = "" And TxtFechaFin.Text <> "" Then
    '      lblmsg.Text = "Ingrese una fecha inical"
    '      Exit Sub
    '   ElseIf TxtFechaInicio.Text <> "" And TxtFechaFin.Text = "" Then
    '       lblmsg.Text = "Ingrese una fecha final"
    '       Exit Sub
    '    Else
    '     ObjCalidad.fcini = TxtFechaInicio.Text
    '      ObjCalidad.fcfin = TxtFechaFin.Text
    '    End If
    '   ObjCalidad.Validacion = 1
    '  ObjCalidad.CodigoAgente = lblusuario.Text
    '  Session("dtsB") = ObjCalidad.Consulta_Auditorias_De()
    '  dtggeneral.DataSource = Session("dtsB")
    ' dtggeneral.DataBind()
    ' LblCantidad.Text = ObjCalidad.cantidad
    ' Catch ex As Exception
    '   lblmsg.Text = "Se presento erro: " + ex.Message
    ' End Try
    'End Sub
End Class