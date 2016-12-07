Imports System.IO

Public Class AuditoriaDirectTv
    Inherits System.Web.UI.Page

    Dim ObjCalidad As New clscalidad
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                drlAuditor.Text = lblusuario.Text
                drlAuditorNombre.Text = lblnombreusu.Text
                cargadrl()
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
            Dim dts As DataSet
            If TxtCod_Consulta.Text = "" Then
                lblmsg.Text = "Ingrese un codigo para realizar la consulta"
                Exit Sub
            Else
                ObjCalidad.Cod_Calidad_Registro = TxtCod_Consulta.Text
                dts = ObjCalidad.Llenar_informacionDirectv()
                If dts.Tables(0).Rows.Count > 0 Then
                    LblId_cliente.Text = ObjCalidad.caso
                    LblAsesor.Text = ObjCalidad.agente
                    LblAuditorConsulta.Text = ObjCalidad.Auditor
                    LblCampania.Text = ObjCalidad.Campania
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
                    DrlInformacionCierre.SelectedItem.Text = ObjCalidad.Informacion_cierre
                    TxtObs_Informacion_Cierre.Text = ObjCalidad.obs_Informacion_cierre
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
                    Visibilidad()
                Else
                    lblmsg.Text = "No se encontraron registros con el codigo: " + TxtCod_Consulta.Text
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Public Sub Visibilidad()
        PanelGeneral.Visible = False
        PanelConsulta.Visible = False
        btnguardar.Visible = False
        BtnVista.Visible = False
        TxtCod_Consulta.Visible = False
        txtcaso.Visible = False
        DrlTipoLlamada.Visible = False
        DrlTipificacion.Visible = False
        BtnConsulta.Visible = False
        BtnValidar.Visible = False
        TxtConsultaCod_Agente.Visible = False
        drlNomAgente.Visible = False
        drlAuditor.Visible = False
        drlAuditorNombre.Visible = False
        drlProceso.Visible = False
        PanelFc_Llamada.Visible = False
        PanelTiempoAcumulado.Visible = False
        PanelCantidad_Llamada.Visible = False
        DrlTipoAuditoria.Visible = False
        drlAmabilidad_Empatia.Visible = False
        TxtObs_Amabilidad_Empatia.Visible = False
        drlColgada_Llamada.Visible = False
        TxtObs_Colgada_Llamada.Visible = False
        drlDocumentacion.Visible = False
        TxtObs_Documentacion.Visible = False
        drlInformacionE.Visible = False
        TxtObs_InformacionE.Visible = False
        drlPresenta_Obj_Llamada.Visible = False
        TxtObsPresentacion.Visible = False
        drPreguntasConcretas.Visible = False
        TxtObs_Preguntas_Concretas.Visible = False
        drlUso_Informacion.Visible = False
        TxtObs_Uso_Informacion.Visible = False
        drlConocimientoProducto.Visible = False
        TxtObs_Conocimiento_Producto.Visible = False
        DrlBeneficiosProducto.Visible = False
        TxtObs_Beneficios_Producto.Visible = False
        DrlDudas.Visible = False
        TxtObs_Aclara_Dudas.Visible = False
        DrlPrecierreBeneficioP.Visible = False
        TxtObs_Precierre_Beneficio_P.Visible = False
        DrlCierraVentaTiempo.Visible = False
        TxtObs_Cierra_Venta.Visible = False
        DrlInformacionCierre.Visible = False
        TxtObs_Informacion_Cierre.Visible = False
        DrlReabateObjeciones.Visible = False
        TxtObs_Rebate_Objeciones.Visible = False
        DrlObjecionesCoherente.Visible = False
        TxtObs_Manejo_Objecciones.Visible = False
        DrlRetomaLlamadaTiempo.Visible = False
        TxtObs_Retoma_Llamada.Visible = False
        DrlAmbienteLaboral.Visible = False
        TxtObs_Evidencia_Ambiente.Visible = False
        DrlTonoFluidez.Visible = False
        TxtObs_Tono_Voz.Visible = False
        DrlPerzonaliza.Visible = False
        TxtObs_Personaliza_llamada.Visible = False
        DrlHabilidadEscucha.Visible = False
        TxtObs_Habilidad_Escucha.Visible = False
        DrlCordialidadEmpatia.Visible = False
        TxtObs_Cordialidad_Empatia.Visible = False
        DrlTipificaApropiada.Visible = False
        TxtObs_Tipifica_Apropiadamente.Visible = False
        TxtObs_Generales.Visible = False
        BtnConsultaAgente.Visible = False
        Panel1.Visible = True
    End Sub

    Protected Sub DrlTipoLlamada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DrlTipoLlamada.SelectedIndexChanged
        Try
            If DrlTipoLlamada.SelectedItem.Text = "- Seleccione -" Then
                DrlTipificacion.Items.Clear()
                Exit Sub
            End If
            If DrlTipoLlamada.SelectedItem.Text = "INBOUND" Then
                ObjCalidad.Validacion = 1
            ElseIf DrlTipoLlamada.Text = "OUTBOUND" Then
                ObjCalidad.Validacion = 2
            End If

            With DrlTipificacion
                .DataSource = ObjCalidad.ObtenerTipificaciones
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
            If DrlTipoLlamada.SelectedValue = "True" Then
                DrlTipificacion.Items.Clear()
                DrlTipificacion.Items.Add("Venta")
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo un error al cargar Droplist Tipificacion " & ex.Message
        End Try
    End Sub
    Protected Sub BtnValidar_Click(sender As Object, e As EventArgs) Handles BtnValidar.Click
        Try
            lblmsg.Text = ""
            If txtcaso.Text = "" Then
                lblmsg.Text = "Ingrese algun caso para realizar la validacion"
                cargadrl()
                Exit Sub
            End If
            ObjCalidad.caso = txtcaso.Text
            With drlNomAgente
                .DataSource = ObjCalidad.Consulta_Caso_AgenteD
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With

            If ObjCalidad.cantidad = 0 Then
                lblmsg.Text = "No se encontraron registros"
            End If

            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnConsultaAgente_Click(sender As Object, e As EventArgs) Handles BtnConsultaAgente.Click
        Try
            lblmsg.Text = ""
            If TxtConsultaCod_Agente.Text = "" Then
                lblmsg.Text = "Ingrese el codigo del agente antes de realizar la consulta"
                Exit Sub
            End If
            'ObjCalidad.caso = -1
            ObjCalidad.CodigoAgente = TxtConsultaCod_Agente.Text
            With drlNomAgente
                .DataSource = ObjCalidad.Consulta_Caso_AgenteD
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento erro: " + ex.Message
        End Try
    End Sub


    Protected Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            Registro_Calidad()
        Catch ex As Exception
            lblmsg.Text = "Se presento erro: " + ex.Message
        End Try
    End Sub

    Sub Registro_Calidad()
        Try
            lblmsg.Text = ""
            If txtcaso.Text = "" Then
                lblmsg.Text = "Ingrese algun caso y luego realizar la validacion de este"
                Exit Sub
            End If
            If drlNomAgente.Text = "- Seleccione -" Or drlNomAgente.Text = "" Or drlNomAgente.Text = "0" Then
                lblmsg.Text = "Seleccione un Asesor"
                Exit Sub
            End If
            If drlAuditor.Text = "" Then
                lblmsg.Text = "Ingrese el nombre del auditor"
                Exit Sub
            End If
            If drlProceso.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el proceso"
                Exit Sub
            End If
            If TxtFc_Llamada.Text = "" Or TxtHora_Llamada.Text = "" Or TxtMinuto_Llamada.Text = "" Then
                lblmsg.Text = "Ingrese una fecha y hora de la llamada"
                Exit Sub
            Else
                If Integer.Parse(TxtHora_Llamada.Text) > 23 Or Integer.Parse(TxtHora_Llamada.Text) < 1 Then
                    lblmsg.Text = "Verifique la hora de la llamada"
                    Exit Sub
                End If
                If Integer.Parse(TxtMinuto_Llamada.Text) > 59 Or Integer.Parse(TxtMinuto_Llamada.Text) < 0 Then
                    lblmsg.Text = "Verifique los minutos de la llamda"
                    Exit Sub
                End If
            End If
           
            If TxtHora.Text = "" Or TxtMinuto.Text = "" Or TxtSegundo.Text = "" Then
                lblmsg.Text = "Ingrese el tiempo acumulado de llamada"
                Exit Sub

            Else
                If Integer.Parse(TxtHora.Text) > 24 Or Integer.Parse(TxtHora.Text) < 0 Then
                    lblmsg.Text = "Verifique la hora de tiempo acumulado"
                    Exit Sub
                End If
                If Integer.Parse(TxtMinuto.Text) > 59 Or Integer.Parse(TxtMinuto.Text) < 0 Then
                    lblmsg.Text = "Verifique los minutos de tiempo acumulado"
                    Exit Sub
                End If
                If Integer.Parse(TxtSegundo.Text) > 59 Or Integer.Parse(TxtSegundo.Text) < 0 Then
                    lblmsg.Text = "Verifique los segundos de tiempo acumulado"
                    Exit Sub
                End If
            End If
            If TxtCantidad_Llamadas.Text = "" Then
                lblmsg.Text = "Ingrese la cantidad de llamadas"
                Exit Sub
            End If
            If DrlTipoLlamada.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el tipo de llamada"
                Exit Sub
            End If
            If DrlTipificacion.Text = "- Seleccione -" Or DrlTipificacion.Text = "" Or DrlTipificacion.Text = "0" Then
                lblmsg.Text = "Seleccione la tipificacion de la llamada"
                Exit Sub
            End If
            If DrlTipoAuditoria.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el tipo de auditoria"
                Exit Sub
            End If
            If drlAmabilidad_Empatia.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para la amabilidad y empatia"
                Exit Sub
            End If
            If TxtObs_Amabilidad_Empatia.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de amabilidad y empatia"
                Exit Sub
            End If
            If drlColgada_Llamada.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Colgada de llamada "
                Exit Sub
            End If
            If TxtObs_Colgada_Llamada.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item colgada de llamada"
                Exit Sub
            End If
            If drlDocumentacion.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Documentacion y toma de datos"
                Exit Sub
            End If
            If TxtObs_Documentacion.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de  Documentacion y toma de datos"
                Exit Sub
            End If
            If drlInformacionE.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Brindar información errada con el fin de cerrar la venta"
                Exit Sub
            End If
            If TxtObs_InformacionE.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de Brindar información errada con el fin de cerrar la venta"
                Exit Sub
            End If
            If drlPresenta_Obj_Llamada.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Inicia llamada con el horario de saludo, indica nombre e identidad corporativa y motivo de la llamada"
                Exit Sub
            End If
            If TxtObsPresentacion.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de Inicia llamada con el horario de saludo, indica nombre e identidad corporativa y motivo de la llamada"
                Exit Sub
            End If
            If drPreguntasConcretas.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Realiza preguntas concretas para perfilar al cliente"
                Exit Sub
            End If
            If TxtObs_Preguntas_Concretas.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de Realiza preguntas concretas para perfilar al cliente"
                Exit Sub
            End If
            If drlUso_Informacion.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para uso de informacion"
                Exit Sub
            End If
            If TxtObs_Uso_Informacion.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de uso de informacion"
                Exit Sub
            End If
            If drlConocimientoProducto.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Tiene conocimiento completo del producto"
                Exit Sub
            End If
            If TxtObs_Conocimiento_Producto.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de Tiene conocimiento completo del producto"
                Exit Sub
            End If
            If DrlBeneficiosProducto.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Indica beneficios del producto"
                Exit Sub
            End If
            If TxtObs_Beneficios_Producto.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de Indica beneficios del producto."
                Exit Sub
            End If
            If DrlDudas.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Aclara las dudas que tiene el cliente acerca del servicio"
                Exit Sub
            End If
            If TxtObs_Aclara_Dudas.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de Aclara las dudas que tiene el cliente acerca del servicio"
                Exit Sub
            End If
            If DrlPrecierreBeneficioP.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Realiza un precierre mientras ofrece los beneficios del producto"
                Exit Sub
            End If
            If TxtObs_Precierre_Beneficio_P.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de Realiza un precierre mientras ofrece los beneficios del producto"
                Exit Sub
            End If
            
            If DrlCierraVentaTiempo.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Cierra la venta en el tiempo oportuno"
                Exit Sub
            End If
            If TxtObs_Cierra_Venta.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de Cierra la venta en el tiempo oportuno"
                Exit Sub
            End If
            If DrlInformacionCierre.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Información de cierre"
                Exit Sub
            End If
            If TxtObs_Informacion_Cierre.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de Información de cierre"
                Exit Sub
            End If
            If DrlReabateObjeciones.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Rebate minimo 3 objeciones ante la negativa del cliente"
                Exit Sub
            End If
            If TxtObs_Rebate_Objeciones.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de Rebate minimo 3 objeciones ante la negativa del cliente"
                Exit Sub
            End If
            If DrlObjecionesCoherente.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para El manejo de objeciones es coherente"
                Exit Sub
            End If
            If TxtObs_Manejo_Objecciones.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de El manejo de objeciones es coherente"
                Exit Sub
            End If
            If DrlRetomaLlamadaTiempo.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para  Retoma la llamada en los tiempos establecidos"
                Exit Sub
            End If
            If TxtObs_Retoma_Llamada.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de Retoma la llamada  los tiempos establecidos."
                Exit Sub
            End If
            If DrlAmbienteLaboral.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para No se evidencia el ambiente laboral"
                Exit Sub
            End If
            If TxtObs_Evidencia_Ambiente.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de No se evidencia el ambiente laboral"
                Exit Sub
            End If
            If DrlTonoFluidez.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Tono de voz y Fluidez verbal"
                Exit Sub
            End If
            If TxtObs_Tono_Voz.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de Tono de voz y Fluidez verbal"
                Exit Sub
            End If
            If DrlPerzonaliza.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Personaliza la llamada"
                Exit Sub
            End If
            If TxtObs_Personaliza_llamada.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de Personaliza la llamada"
                Exit Sub
            End If
            If DrlHabilidadEscucha.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Habilidad de escucha"
                Exit Sub
            End If
            If TxtObs_Habilidad_Escucha.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de Habilidad de escucha."
                Exit Sub
            End If
            If DrlCordialidadEmpatia.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Cordialidad y empatia"
                Exit Sub
            End If
            If DrlTipificaApropiada.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una calificacion para Tipifica apropiadamente la gestión de la llamada en los aplicativos"
                    Exit Sub
                End If
                If TxtObs_Tipifica_Apropiadamente.Text = "" Then
                    lblmsg.Text = "Ingrese alguna observacion para el item de Tipifica apropiadamente la gestión de la llamada en los aplicativos"
                    Exit Sub
                End If
                If TxtObs_Generales.Text = "" Then
                    lblmsg.Text = "Ingrese alguna observacion general"
                    Exit Sub
                End If

            ObjCalidad.Id_Usuario = lblusuario.Text
            ObjCalidad.caso = txtcaso.Text
            ObjCalidad.agente = drlNomAgente.Text
            ObjCalidad.grupo = LblGrupo.Text
            ObjCalidad.Auditor = drlAuditor.Text
            ObjCalidad.Campania = LblCampania.Text
            ObjCalidad.Proceso = drlProceso.SelectedItem.Text
            ObjCalidad.Fc_Llamada = TxtFc_Llamada.Text + " " + TxtHora_Llamada.Text + ":" + TxtMinuto_Llamada.Text
            ObjCalidad.Tiempo_Acum_Llamada = TxtHora.Text + ":" + TxtMinuto.Text + ":" + TxtSegundo.Text
            ObjCalidad.N_Llamadas_Min = TxtCantidad_Llamadas.Text
            ObjCalidad.tipo_llamada = DrlTipoLlamada.SelectedItem.Text
            ObjCalidad.tipificacion = DrlTipificacion.SelectedItem.Text
            ObjCalidad.Tipo_Auditoria = DrlTipoAuditoria.SelectedItem.Text
            ObjCalidad.Amabilidad_Empatia = drlAmabilidad_Empatia.SelectedItem.Text
            ObjCalidad.Obs_Amabilidad_Empatia = TxtObs_Amabilidad_Empatia.Text
            ObjCalidad.Colgada_Llamada = drlColgada_Llamada.SelectedItem.Text
            ObjCalidad.Obs_Colgada_Llamada = TxtObs_Colgada_Llamada.Text
            ObjCalidad.Documentación_toma_datos = drlDocumentacion.SelectedItem.Text
            ObjCalidad.Obs_Documentación_toma_datos = TxtObs_Documentacion.Text
            ObjCalidad.Brindar_información_errada_cerrar_venta = drlInformacionE.SelectedItem.Text
            ObjCalidad.obs_Brindar_información_errada_cerrar_venta = TxtObs_InformacionE.Text
            ObjCalidad.Inicia_llamada_horario_saludo_identidad_motivo_llamada = drlPresenta_Obj_Llamada.SelectedItem.Text
            ObjCalidad.obs_Inicia_llamada_horario_saludo_identidad_motivo_llamada = TxtObsPresentacion.Text
            ObjCalidad.Realiza_preguntas_concretas_perfilar_cliente = drPreguntasConcretas.SelectedItem.Text
            ObjCalidad.obs_Realiza_preguntas_concretas_perfilar_cliente = TxtObs_Preguntas_Concretas.Text
            ObjCalidad.Uso_información = drlUso_Informacion.SelectedItem.Text
            ObjCalidad.obs_Uso_información = TxtObs_Uso_Informacion.Text
            ObjCalidad.Tiene_conocimiento_completo_producto = drlConocimientoProducto.SelectedItem.Text
            ObjCalidad.obs_Tiene_conocimiento_completo_producto = TxtObs_Conocimiento_Producto.Text
            ObjCalidad.Indica_beneficios_producto = DrlBeneficiosProducto.SelectedItem.Text
            ObjCalidad.obs_Indica_beneficios_producto = TxtObs_Beneficios_Producto.Text
            ObjCalidad.Aclara_dudas_tiene_cliente_acerca_servicio = DrlDudas.SelectedItem.Text
            ObjCalidad.obs_Aclara_dudas_tiene_cliente_acerca_servicio = TxtObs_Aclara_Dudas.Text
            ObjCalidad.Realiza_precierre_ofrece_beneficio_producto = DrlPrecierreBeneficioP.SelectedItem.Text
            ObjCalidad.obs_Realiza_precierre_ofrece_beneficio_producto = TxtObs_Precierre_Beneficio_P.Text
            ObjCalidad.Cierra_venta_tiempo_oportuno = DrlCierraVentaTiempo.SelectedItem.Text
            ObjCalidad.obs_Cierra_venta_tiempo_oportuno = TxtObs_Cierra_Venta.Text
            ObjCalidad.Informacion_cierre = DrlInformacionCierre.SelectedItem.Text
            ObjCalidad.obs_Informacion_cierre = TxtObs_Informacion_Cierre.Text
            ObjCalidad.Rebate_minimo_objecione_negativa_cliente = DrlReabateObjeciones.SelectedItem.Text
            ObjCalidad.obs_Rebate_minimo_objecione_negativa_cliente = TxtObs_Rebate_Objeciones.Text
            ObjCalidad.manejo_objeciones_coherente = DrlObjecionesCoherente.SelectedItem.Text
            ObjCalidad.obs_manejo_objeciones_coherente = TxtObs_Manejo_Objecciones.Text
            ObjCalidad.Retoma_llamada_tiempos_establecidos = DrlRetomaLlamadaTiempo.SelectedItem.Text
            ObjCalidad.obs_Retoma_llamada_tiempos_establecidos = TxtObs_Retoma_Llamada.Text
            ObjCalidad.evidencia_ambiente_laboral = DrlAmbienteLaboral.SelectedItem.Text
            ObjCalidad.obs_evidencia_ambiente_laboral = TxtObs_Evidencia_Ambiente.Text
            ObjCalidad.Tono_voz = DrlTonoFluidez.SelectedItem.Text
            ObjCalidad.obs_Tono_voz_Fluidez_verbal = TxtObs_Tono_Voz.Text
            ObjCalidad.Personaliza_llamada = DrlPerzonaliza.SelectedItem.Text
            ObjCalidad.obs_Personaliza_llamada = TxtObs_Personaliza_llamada.Text
            ObjCalidad.Habilidad_escucha = DrlHabilidadEscucha.SelectedItem.Text
            ObjCalidad.obs_Habilidad_escucha = TxtObs_Habilidad_Escucha.Text
            ObjCalidad.Cordialidad_empatia = DrlCordialidadEmpatia.SelectedItem.Text
            ObjCalidad.obs_Cordialidad_empatia = TxtObs_Cordialidad_Empatia.Text
            ObjCalidad.Tipifica_apropiadamente_gestió_llamada_aplicativos = DrlTipificaApropiada.SelectedItem.Text
            ObjCalidad.obs_Tipifica_apropiadamente_gestió_llamada_aplicativos = TxtObs_Tipifica_Apropiadamente.Text
            ObjCalidad.Obs_General = TxtObs_Generales.Text
            ObjCalidad.Registro_Calidad_directv()
            ''''Consulta Registro de Auditoria
            ObjCalidad.Consulta_RegistroDirectv()
            lblmsg.Text = "Registro Exitoso auditoria registrada con el id : " + ObjCalidad.Cod_Calidad_Registro.ToString
            Limpiar()
        Catch ex As Exception
            lblmsg.Text = "Se presento erro: " + ex.Message
        End Try
    End Sub
    Protected Sub BtnConsultaAditorias_Click(sender As Object, e As EventArgs) Handles BtnConsultaAditorias.Click
        Try
            If TxtCod_Agente.Text = "" And TxtFechaInicio.Text = "" And TxtFechaFin.Text = "" Then
                lblmsg.Text = "Ingrese un filtro para realzar la busqueda"
                Exit Sub
            ElseIf TxtCod_Agente.Text <> "" Then
                ObjCalidad.Id_Usuario = TxtCod_Agente.Text
            End If
            If TxtFechaInicio.Text = "" And TxtFechaFin.Text <> "" Then
                lblmsg.Text = "Ingrese una fecha inical"
                Exit Sub
            ElseIf TxtFechaInicio.Text <> "" And TxtFechaFin.Text = "" Then
                lblmsg.Text = "Ingrese una fecha final"
                Exit Sub
            Else
                ObjCalidad.fcini = TxtFechaInicio.Text
                ObjCalidad.fcfin = TxtFechaFin.Text
            End If
            Session("dtsB") = ObjCalidad.Consulta_Auditorias_De()
            dtggeneral.DataSource = Session("dtsB")
            dtggeneral.DataBind()
            LblCantidad.Text = ObjCalidad.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se presento erro: " + ex.Message
        End Try
    End Sub

    Sub cargadrl()
        Try
            ObjCalidad.Validacion = "6"
            With drlProceso
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            ObjCalidad.CodigoAgente = 1
            With drlNomAgente
                .DataSource = ObjCalidad.Consulta_Caso_AgenteD
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento erro: " + ex.Message
        End Try
    End Sub



    Sub Limpiar()
        Try
            txtcaso.Text = ""
            TxtHora.Text = ""
            TxtMinuto.Text = ""
            TxtSegundo.Text = ""
            drlNomAgente.DataValueField = Nothing
            TxtFc_Llamada.Text = ""
            TxtHora_Llamada.Text = ""
            TxtMinuto_Llamada.Text = ""
            TxtCantidad_Llamadas.Text = ""
            DrlTipoLlamada.Text = "- Seleccione -"
            DrlTipificacion.Text = "- Seleccione -"
            DrlTipoAuditoria.Text = "- Seleccione -"
            drlAmabilidad_Empatia.Text = "- Seleccione -"
            TxtObs_Amabilidad_Empatia.Text = ""
            drlColgada_Llamada.Text = "- Seleccione -"
            TxtObs_Colgada_Llamada.Text = ""
            drlDocumentacion.Text = "- Seleccione -"
            TxtObs_Documentacion.Text = ""
            drlInformacionE.Text = "- Seleccione -"
            TxtObs_InformacionE.Text = ""
            drlPresenta_Obj_Llamada.Text = "- Seleccione -"
            TxtObsPresentacion.Text = ""
            drPreguntasConcretas.Text = "- Seleccione -"
            TxtObs_Preguntas_Concretas.Text = ""
            drlUso_Informacion.Text = "- Seleccione -"
            TxtObs_Uso_Informacion.Text = ""
            drlConocimientoProducto.Text = "- Seleccione -"
            TxtObs_Conocimiento_Producto.Text = ""
            DrlBeneficiosProducto.Text = "- Seleccione -"
            TxtObs_Beneficios_Producto.Text = ""
            DrlDudas.Text = "- Seleccione -"
            TxtObs_Aclara_Dudas.Text = ""
            DrlPrecierreBeneficioP.Text = "- Seleccione -"
            TxtObs_Precierre_Beneficio_P.Text = ""
            DrlCierraVentaTiempo.Text = "- Seleccione -"
            TxtObs_Cierra_Venta.Text = ""
            DrlInformacionCierre.Text = "- Seleccione -"
            TxtObs_Informacion_Cierre.Text = ""
            DrlReabateObjeciones.Text = "- Seleccione -"
            TxtObs_Rebate_Objeciones.Text = ""
            DrlObjecionesCoherente.Text = "- Seleccione -"
            TxtObs_Manejo_Objecciones.Text = ""
            DrlRetomaLlamadaTiempo.Text = "- Seleccione -"
            TxtObs_Retoma_Llamada.Text = ""
            DrlAmbienteLaboral.Text = "- Seleccione -"
            TxtObs_Evidencia_Ambiente.Text = ""
            DrlTonoFluidez.Text = "- Seleccione -"
            TxtObs_Tono_Voz.Text = ""
            DrlPerzonaliza.Text = "- Seleccione -"
            TxtObs_Personaliza_llamada.Text = ""
            DrlHabilidadEscucha.Text = "- Seleccione -"
            TxtObs_Habilidad_Escucha.Text = ""
            DrlCordialidadEmpatia.Text = "- Seleccione -"
            TxtObs_Cordialidad_Empatia.Text = ""
            DrlTipificaApropiada.Text = "- Seleccione -"
            TxtObs_Tipifica_Apropiadamente.Text = ""
            TxtObs_Generales.Text = ""
            cargadrl()
        Catch ex As Exception
            lblmsg.Text = "Se presento erro: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnExporta_Click(sender As Object, e As EventArgs) Handles BtnExporta.Click
        Try

            If dtggeneral.Visible = True Then



                Dim sb As New StringBuilder
                Dim sw As New StringWriter(sb)
                Dim htw As New HtmlTextWriter(sw)
                Dim pagina As Page = New Page
                Dim form = New HtmlForm
                Dim nuevo As New GridView




                Dim objdtsconsultaxls As New DataSet
                Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"


                pagina.EnableEventValidation = False
                pagina.DesignerInitialize()
                pagina.Controls.Add(form)
                Dim dt As New DataTable
                dt = Session("dtsB")
                nuevo.DataSource = dt
                nuevo.DataBind()

                nuevo.AllowPaging = True
                nuevo.CellPadding = "4"
                nuevo.ForeColor = Drawing.Color.FromName("#333333")
                nuevo.GridLines = GridLines.None
                nuevo.Font.Size = FontSize.XXLarge
                nuevo.RowStyle.BackColor = Drawing.Color.FromName("#F7F6F3")
                nuevo.RowStyle.ForeColor = Drawing.Color.FromName("#333333")
                nuevo.FooterStyle.BackColor = Drawing.Color.FromName("#B3C556")
                nuevo.FooterStyle.Font.Bold = True
                nuevo.FooterStyle.ForeColor = Drawing.Color.White
                nuevo.PagerStyle.BackColor = Drawing.Color.FromName("#B3C556")
                nuevo.PagerStyle.ForeColor = Drawing.Color.White
                nuevo.PagerStyle.HorizontalAlign = HorizontalAlign.Center
                nuevo.SelectedRowStyle.BackColor = Drawing.Color.FromName("#E2DED6")
                nuevo.SelectedRowStyle.Font.Bold = True
                nuevo.SelectedRowStyle.ForeColor = Drawing.Color.FromName("#333333")
                nuevo.HeaderStyle.BackColor = Drawing.Color.FromName("#B3C556")
                nuevo.HeaderStyle.Font.Bold = False
                nuevo.HeaderStyle.ForeColor = Drawing.Color.White
                nuevo.HeaderStyle.Font.Size = FontSize.XXLarge
                nuevo.EditRowStyle.BackColor = Drawing.Color.FromName("#999999")
                nuevo.AlternatingRowStyle.BackColor = Drawing.Color.White
                nuevo.AlternatingRowStyle.ForeColor = Drawing.Color.FromName("#8F9E45")

                form.Controls.Add(nuevo)
                pagina.RenderControl(htw)
                Response.Clear()
                Response.Buffer = True

                Response.ContentType = "application/vnd.ms-excel"
                Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                Response.AddHeader("Content-Disposition", "attachment;filename=Auditorias.xls")
                Response.Charset = "UTF-8"
                Response.Write(strStyle)
                Response.Write(sb.ToString())
                Response.End()
            Else
                lblmsg.Text = "Realice un filtro para consultar"
                Exit Sub
            End If

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try

    End Sub
    Protected Sub dtggeneral_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            lblmsg.Text = ""
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtggeneral.DataSource = Session("dtsB")
            dtggeneral.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub


End Class