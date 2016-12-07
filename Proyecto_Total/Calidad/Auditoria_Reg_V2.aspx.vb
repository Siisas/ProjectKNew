Imports System.IO

Public Class Auditoria_Reg_V2
    Inherits System.Web.UI.Page
    Dim ObjCalidad As New clscalidad

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                drlAuditor.Text = lblusuario.Text
                drlAuditorNombre.Text = lblnombreusu.Text
                Cargar_drl()
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

    Public Sub Cargar_drl()
        Try
            LblFecha.Text = ObjCalidad.Fc_Reg
            ObjCalidad.Validacion = "1"
            With drlProceso
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            ObjCalidad.Validacion = "2"
            With drlEstado
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            ObjCalidad.Validacion = "3"
            With drlTipo_Auditoria
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            'ObjCalidad.Validacion = "4"
            'With drlAuditor
            '    .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
            '    .DataTextField = "nombreu"
            '    .DataValueField = "idusuario"
            '    .DataBind()
            'End With
            ObjCalidad.Validacion = "5"
            With drlGrupo
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Cargo"
                .DataValueField = "Cargo"
                .DataBind()
            End With
            ObjCalidad.Validacion = "5"
            With drlGrupo_Consulta
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Cargo"
                .DataValueField = "Cargo"
                .DataBind()
            End With
            ObjCalidad.caso = -1
            With drlNomAgente
                .DataSource = ObjCalidad.Consulta_Caso_Agente
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnValidar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnValidar.Click
        Try
            If txtcaso.Text = "" Then
                lblmsg.Text = "Ingrese algun caso para realizar la validacion"
                ObjCalidad.caso = -1
                With drlNomAgente
                    .DataSource = ObjCalidad.Consulta_Caso_Agente
                    .DataTextField = "nombreu"
                    .DataValueField = "idusuario"
                    .DataBind()
                End With
                Exit Sub
            End If
            ObjCalidad.caso = txtcaso.Text
            With drlNomAgente
                .DataSource = ObjCalidad.Consulta_Caso_Agente
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
            LblCampaña.Text = ObjCalidad.Campania
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Try
            If txtcaso.Text = "" Then
                lblmsg.Text = "Ingrese algun caso y luego realizar la validacion de este"
                Exit Sub
            End If
            If drlNomAgente.Text = "- Seleccione -" Or drlNomAgente.Text = "" Or drlNomAgente.Text = "0" Then
                lblmsg.Text = "Seleccione un ingeniero o agente"
                Exit Sub
            End If
            If drlGrupo.Text = "- Seleccione -" Or drlGrupo.Text = "" Or drlGrupo.Text = "0" Then
                lblmsg.Text = "Seleccione el grupo del ingeniero o agente"
                Exit Sub
            End If
            If drlAuditor.Text = "" Then
                lblmsg.Text = "Ingrese el nombre del auditor"
                Exit Sub
            End If
            If drlProceso.Text = "- Seleccione -" Or drlProceso.Text = "" Then
                lblmsg.Text = "Seleccione un proceso"
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
            If drlEstado.Text = "- Seleccione -" Or drlEstado.Text = "" Then
                lblmsg.Text = "Seleccione el estado del caso"
                Exit Sub
            End If
            If drlTipo_Auditoria.Text = "- Seleccione -" Then
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
                lblmsg.Text = "Seleccione una calificacion para colgada de llamada"
                Exit Sub
            End If
            If TxtObs_Colgada_Llamada.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de colgada de llamada"
                Exit Sub
            End If
            If drlRealiza_Filtro_A.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para filtros adecuados"
                Exit Sub
            End If
            If TxtObs_Realiza_Filtro_A.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de filtros adecuados"
                Exit Sub
            End If
            If drlCorona_Abierta.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para corona abierta"
                Exit Sub
            End If
            If TxtObs_Corona_Abierta.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de corona abierta"
                Exit Sub
            End If
            If drlDocumentacion.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para documentacion"
                Exit Sub
            End If
            If TxtObs_Documentacion.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de documentacion"
                Exit Sub
            End If
            If drlProcedimiento_PQR.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para procedimiento PQR"
                Exit Sub
            End If
            If TxtObs_Procedimiento_PQR.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de procedimientos PQR"
                Exit Sub
            End If
            If drlProcedimiento_Prueb_Tram_Incom_Incorrec.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Procedimiento, Pruebas, Tramites incompletos o incorrectos"
                Exit Sub
            End If
            If TxtObs_Procedimiento_Prueb_Tram_Incom_Incorrec.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de Procedimientos, pruebas y tramites incompletos o incorrectos"
                Exit Sub
            End If
            If drlPresenta_Obj_Llamada.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para el objetivo de la llamada"
                Exit Sub
            End If
            If TxtObs_Presenta_Obj_Llamada.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de presenta objetivo de la llamada"
                Exit Sub
            End If
            If drlCordialidad_Comunicacion.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para comunicacion"
                Exit Sub
            End If
            If TxtObs_Cordialidad_Comunicacion.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de comunicacion"
                Exit Sub
            End If
            If drlCordialidad.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para cordialidad"
                Exit Sub
            End If
            If TxtObs_Cordialidad.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de Cordialidad"
                Exit Sub
            End If
            If drlContacto_Activo.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para contacto activo"
                Exit Sub
            End If
            If TxtObs_Contacto_Activo.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de contacto activo"
                Exit Sub
            End If
            If drlClaridad_Transmitir_Inf.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para claridad al transmitir la informacion"
                Exit Sub
            End If
            If TxtObs_Claridad_Transmitir_Inf.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de claridad al transmitir la informacion"
                Exit Sub
            End If
            If drlSeguridad.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para seguridad"
                Exit Sub
            End If
            If TxtObs_Seguridad.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de seguridad"
                Exit Sub
            End If
            If drlUtiliza_Guion_Saludo_Nom.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para guion de saludo"
                Exit Sub
            End If
            If TxtObs_Utiliza_Guion_Saludo_Nom.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de guion de saludo y nombre completo"
                Exit Sub
            End If
            If drlGestion_Llamada.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para la gestion de la llamada"
                Exit Sub
            End If
            If TxtObs_Gestion_Llamada.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de gestion de llamada"
                Exit Sub
            End If
            If drlGestion_Soporte.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para la gestion el soporte"
                Exit Sub
            End If
            If TxtObs_Gestion_Soporte.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de gestion de soporte"
                Exit Sub
            End If
            If drlGestion_Asignacion.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para la gestion de asignacion"
                Exit Sub
            End If
            If TxtObs_Gestion_Asignacion.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de gestion de asignacion"
                Exit Sub
            End If
            If drlGestion_Cierre.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para la gestion de cierre"
                Exit Sub
            End If
            If TxtObs_Gestion_Cierre.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de gestion de cierre"
                Exit Sub
            End If
            If DrlReincide.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opcion para reincide"
                Exit Sub
            End If
            If TxtObsReincide.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de reincide"
                Exit Sub
            End If
            If drlSolucion.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opcion de solucion"
                Exit Sub
            End If
            If TxtObs_Solucion.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de solucion"
                Exit Sub
            End If
            If drlInteres_Escucha.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opcion para Interes en escuchar"
                Exit Sub
            End If
            If TxtObs_Interes_Escucha.Text = "" Then
                lblmsg.Text = "Ingrese alguna observacion para el item de interes en escuchar"
                Exit Sub
            End If
            If TxtObs_Generales.Text = "" Then
                lblmsg.Text = "Ingrese alguna comentario para observacion general"
                Exit Sub
            End If

            ObjCalidad.Id_Usuario = lblusuario.Text
            ObjCalidad.caso = txtcaso.Text
            ObjCalidad.agente = drlNomAgente.Text
            ObjCalidad.grupo = drlGrupo.Text
            ObjCalidad.Auditor = drlAuditor.Text
            ObjCalidad.Campania = LblCampaña.Text
            ObjCalidad.Proceso = drlProceso.Text
            ObjCalidad.Fc_Llamada = TxtFc_Llamada.Text + " " + TxtHora_Llamada.Text + ":" + TxtMinuto_Llamada.Text
            ObjCalidad.Tiempo_Acum_Llamada = TxtHora.Text + ":" + TxtMinuto.Text + ":" + TxtSegundo.Text
            ObjCalidad.N_Llamadas_Min = TxtCantidad_Llamadas.Text
            ObjCalidad.Estado_Caso = drlEstado.Text
            ObjCalidad.Tipo_Auditoria = drlTipo_Auditoria.Text
            ObjCalidad.Amabilidad_Empatia = drlAmabilidad_Empatia.Text
            ObjCalidad.Obs_Amabilidad_Empatia = TxtObs_Amabilidad_Empatia.Text
            ObjCalidad.Colgada_Llamada = drlColgada_Llamada.Text
            ObjCalidad.Obs_Colgada_Llamada = TxtObs_Colgada_Llamada.Text
            ObjCalidad.Real_filtros_adecuados = drlRealiza_Filtro_A.Text
            ObjCalidad.Obs_Real_filtros_adecuados = TxtObs_Realiza_Filtro_A.Text
            ObjCalidad.Corona_Abierta = drlCorona_Abierta.Text
            ObjCalidad.Obs_Corona_Abierta = TxtObs_Corona_Abierta.Text
            ObjCalidad.Documentacion = drlDocumentacion.Text
            ObjCalidad.Obs_Documentacion = TxtObs_Documentacion.Text
            ObjCalidad.Procedimiento_PQR = drlProcedimiento_PQR.Text
            ObjCalidad.Obs_Procedimiento_PQR = TxtObs_Procedimiento_PQR.Text
            ObjCalidad.Procedimiento_prueba_tramite_incompleto_incorrecto = drlProcedimiento_Prueb_Tram_Incom_Incorrec.Text
            ObjCalidad.Obs_Procedimiento_prueba_tramite_incompleto_incorrecto = TxtObs_Procedimiento_Prueb_Tram_Incom_Incorrec.Text
            ObjCalidad.Presenta_objetivo_llamada = drlPresenta_Obj_Llamada.Text
            ObjCalidad.Obs_Presenta_objetivo_llamada = TxtObs_Presenta_Obj_Llamada.Text
            ObjCalidad.Cordialidad_Comunicacion = drlCordialidad_Comunicacion.Text
            ObjCalidad.Obs_Cordialidad_Comunicacion = TxtObs_Cordialidad_Comunicacion.Text
            ObjCalidad.Cordialidad = drlCordialidad.Text
            ObjCalidad.Obs_Cordialidad = TxtObs_Cordialidad.Text
            ObjCalidad.Contacto_Activo = drlContacto_Activo.Text
            ObjCalidad.Obs_Contacto_Activo = TxtObs_Contacto_Activo.Text
            ObjCalidad.Claridad_transmitir_informacion = drlClaridad_Transmitir_Inf.Text
            ObjCalidad.Obs_Claridad_transmitir_informacion = TxtObs_Claridad_Transmitir_Inf.Text
            ObjCalidad.Seguridad = drlSeguridad.Text
            ObjCalidad.Obs_Seguridad = TxtObs_Seguridad.Text
            ObjCalidad.Util_guion_saludo = drlUtiliza_Guion_Saludo_Nom.Text
            ObjCalidad.Obs_Util_guion_saludo = TxtObs_Utiliza_Guion_Saludo_Nom.Text
            ObjCalidad.Gestion_Llamada = drlGestion_Llamada.Text
            ObjCalidad.Obs_Gestion_Llamada = TxtObs_Gestion_Llamada.Text
            ObjCalidad.Gestion_Soporte = drlGestion_Soporte.Text
            ObjCalidad.Obs_Gestion_Soporte = TxtObs_Gestion_Soporte.Text
            ObjCalidad.Gestion_Asignacion = drlGestion_Asignacion.Text
            ObjCalidad.Obs_Gestion_Asignacion = TxtObs_Gestion_Asignacion.Text
            ObjCalidad.Gestion_Cierre = drlGestion_Cierre.Text
            ObjCalidad.Obs_Gestion_Cierre = TxtObs_Gestion_Cierre.Text
            ObjCalidad.Solucion = drlSolucion.Text
            ObjCalidad.Obs_Solucion = TxtObs_Solucion.Text
            ObjCalidad.Interes_escuchar = drlInteres_Escucha.Text
            ObjCalidad.Obs_Interes_escuchar = TxtObs_Interes_Escucha.Text
            ObjCalidad.Reincide = DrlReincide.SelectedItem.Text
            ObjCalidad.obs_Reincide = TxtObsReincide.Text
            ObjCalidad.Obs_General = TxtObs_Generales.Text

            ObjCalidad.Registro_Auditoria_Calidad()

            ObjCalidad.Consulta_Registro()

            lblmsg.Text = "Registro Realizado con el codigo: " + ObjCalidad.Cod_Calidad_Registro.ToString

            txtcaso.Text = ""
            LblCampaña.Text = ""
            TxtFc_Llamada.Text = ""
            TxtHora_Llamada.Text = ""
            TxtMinuto_Llamada.Text = ""
            TxtHora.Text = ""
            TxtMinuto.Text = ""
            TxtSegundo.Text = ""
            TxtCantidad_Llamadas.Text = ""
            drlAmabilidad_Empatia.Text = "- Seleccione -"
            TxtObs_Amabilidad_Empatia.Text = ""
            drlColgada_Llamada.Text = "- Seleccione -"
            TxtObs_Colgada_Llamada.Text = ""
            drlRealiza_Filtro_A.Text = "- Seleccione -"
            TxtObs_Realiza_Filtro_A.Text = ""
            drlCorona_Abierta.Text = "- Seleccione -"
            TxtObs_Corona_Abierta.Text = ""
            drlDocumentacion.Text = "- Seleccione -"
            TxtObs_Documentacion.Text = ""
            drlProcedimiento_PQR.Text = "- Seleccione -"
            TxtObs_Procedimiento_PQR.Text = ""
            drlProcedimiento_Prueb_Tram_Incom_Incorrec.Text = "- Seleccione -"
            TxtObs_Procedimiento_Prueb_Tram_Incom_Incorrec.Text = ""
            drlPresenta_Obj_Llamada.Text = "- Seleccione -"
            TxtObs_Presenta_Obj_Llamada.Text = ""
            drlCordialidad_Comunicacion.Text = "- Seleccione -"
            TxtObs_Cordialidad_Comunicacion.Text = ""
            drlCordialidad.Text = "- Seleccione -"
            TxtObs_Cordialidad.Text = ""
            drlContacto_Activo.Text = "- Seleccione -"
            TxtObs_Contacto_Activo.Text = ""
            drlClaridad_Transmitir_Inf.Text = "- Seleccione -"
            TxtObs_Claridad_Transmitir_Inf.Text = ""
            drlSeguridad.Text = "- Seleccione -"
            TxtObs_Seguridad.Text = ""
            drlUtiliza_Guion_Saludo_Nom.Text = "- Seleccione -"
            TxtObs_Utiliza_Guion_Saludo_Nom.Text = ""
            drlGestion_Llamada.Text = "- Seleccione -"
            TxtObs_Gestion_Llamada.Text = ""
            drlGestion_Soporte.Text = "- Seleccione -"
            TxtObs_Gestion_Soporte.Text = ""
            drlGestion_Asignacion.Text = "- Seleccione -"
            TxtObs_Gestion_Asignacion.Text = ""
            drlGestion_Cierre.Text = "- Seleccione -"
            TxtObs_Gestion_Cierre.Text = ""
            drlSolucion.Text = "- Seleccione -"
            TxtObs_Solucion.Text = ""
            drlInteres_Escucha.Text = "- Seleccione -"
            TxtObs_Interes_Escucha.Text = ""
            TxtObs_Generales.Text = ""
            TxtConsultaCod_Agente.Text = ""
            DrlReincide.Text = "- Seleccione -"
            TxtObsReincide.Text = ""

            Cargar_drl()

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Public Sub Visibilidad()
        Try
            PanelGeneral.Visible = False
            PanelConsulta.Visible = False
            btnguardar.Visible = False
            BtnVista.Visible = False
            TxtCod_Consulta.Visible = False
            BtnConsulta.Visible = False
            BtnValidar.Visible = False

            txtcaso.Visible = False
            drlNomAgente.Visible = False
            drlGrupo.Visible = False
            drlAuditor.Visible = False
            drlAuditorNombre.Visible = False
            drlProceso.Visible = False
            PanelFc_Llamada.Visible = False
            PanelTiempoAcumulado.Visible = False
            PanelCantidad_Llamada.Visible = False
            drlEstado.Visible = False
            drlTipo_Auditoria.Visible = False
            drlAmabilidad_Empatia.Visible = False
            TxtObs_Amabilidad_Empatia.Visible = False
            drlColgada_Llamada.Visible = False
            TxtObs_Colgada_Llamada.Visible = False
            drlRealiza_Filtro_A.Visible = False
            TxtObs_Realiza_Filtro_A.Visible = False
            drlCorona_Abierta.Visible = False
            TxtObs_Corona_Abierta.Visible = False
            drlDocumentacion.Visible = False
            TxtObs_Documentacion.Visible = False
            drlProcedimiento_PQR.Visible = False
            TxtObs_Procedimiento_PQR.Visible = False
            drlProcedimiento_Prueb_Tram_Incom_Incorrec.Visible = False
            TxtObs_Procedimiento_Prueb_Tram_Incom_Incorrec.Visible = False
            drlPresenta_Obj_Llamada.Visible = False
            TxtObs_Presenta_Obj_Llamada.Visible = False
            drlCordialidad_Comunicacion.Visible = False
            TxtObs_Cordialidad_Comunicacion.Visible = False
            drlCordialidad.Visible = False
            TxtObs_Cordialidad.Visible = False
            drlContacto_Activo.Visible = False
            TxtObs_Contacto_Activo.Visible = False
            drlClaridad_Transmitir_Inf.Visible = False
            TxtObs_Claridad_Transmitir_Inf.Visible = False
            drlSeguridad.Visible = False
            TxtObs_Seguridad.Visible = False
            drlUtiliza_Guion_Saludo_Nom.Visible = False
            TxtObs_Utiliza_Guion_Saludo_Nom.Visible = False
            drlGestion_Llamada.Visible = False
            TxtObs_Gestion_Llamada.Visible = False
            drlGestion_Soporte.Visible = False
            TxtObs_Gestion_Soporte.Visible = False
            drlGestion_Asignacion.Visible = False
            TxtObs_Gestion_Asignacion.Visible = False
            drlGestion_Cierre.Visible = False
            TxtObs_Gestion_Cierre.Visible = False
            drlSolucion.Visible = False
            TxtObs_Solucion.Visible = False
            drlInteres_Escucha.Visible = False
            TxtObs_Interes_Escucha.Visible = False
            TxtObs_Generales.Visible = False
            TxtConsultaCod_Agente.Visible = False
            BtnConsultaAgente.Visible = False
            Panel1.Visible = True
            DrlReincide.Visible = False
            TxtObsReincide.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnVista_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnVista.Click
        Try
            Lblcaso.Text = txtcaso.Text

            LblNomAgente.Text = drlNomAgente.Text
            LblGrupo.Text = drlGrupo.Text
            LblAuditorConsulta.Text = drlAuditor.Text
            LblProceso.Text = drlProceso.Text
            LblFc_Llamada.Text = TxtFc_Llamada.Text + " " + TxtHora_Llamada.Text + ":" + TxtMinuto_Llamada.Text
            LblTiempoAcumulado.Text = TxtHora.Text + ":" + TxtMinuto.Text + ":" + TxtSegundo.Text
            LblCantidad_Llamadas.Text = TxtCantidad_Llamadas.Text
            LblEstado.Text = drlEstado.Text
            LblTipo_Auditoria.Text = drlTipo_Auditoria.Text
            LblAmabilidad_Empatia.Text = drlAmabilidad_Empatia.Text
            LblObs_Amabilidad_Empatia.Text = TxtObs_Amabilidad_Empatia.Text
            LblColgada_Llamada.Text = drlColgada_Llamada.Text
            LblObs_Colgada_Llamada.Text = TxtObs_Colgada_Llamada.Text
            LblObs_Realiza_Filtro_A.Text = drlRealiza_Filtro_A.Text
            LblObs_Realiza_Filtro_A.Text = TxtObs_Realiza_Filtro_A.Text
            LblCorona_Abierta.Text = drlCorona_Abierta.Text
            LblObs_Corona_Abierta.Text = TxtObs_Corona_Abierta.Text
            LblDocumentacion.Text = drlDocumentacion.Text
            LblObs_Documentacion.Text = TxtObs_Documentacion.Text
            LblProcedimiento_PQR.Text = drlProcedimiento_PQR.Text
            LblObs_Procedimiento_PQR.Text = TxtObs_Procedimiento_PQR.Text
            LblProcedimiento_Prueb_Tram_Incom_Incorrec.Text = drlProcedimiento_Prueb_Tram_Incom_Incorrec.Text
            LblObs_Procedimiento_Prueb_Tram_Incom_Incorrec.Text = TxtObs_Procedimiento_Prueb_Tram_Incom_Incorrec.Text
            LblPresenta_Obj_Llamada.Text = drlPresenta_Obj_Llamada.Text
            LblObs_Presenta_Obj_Llamada.Text = TxtObs_Presenta_Obj_Llamada.Text
            LblCordialidad_Comunicacion.Text = drlCordialidad_Comunicacion.Text
            LblObs_Cordialidad_Comunicacion.Text = TxtObs_Cordialidad_Comunicacion.Text
            LblCordialidad.Text = drlCordialidad.Text
            LblObs_Cordialidad.Text = TxtObs_Cordialidad.Text
            LblContacto_Activo.Text = drlContacto_Activo.Text
            LblObs_Contacto_Activo.Text = TxtObs_Contacto_Activo.Text
            LblClaridad_Transmitir_Inf.Text = drlClaridad_Transmitir_Inf.Text
            LblObs_Claridad_Transmitir_Inf.Text = TxtObs_Claridad_Transmitir_Inf.Text
            LblSeguridad.Text = drlSeguridad.Text
            LblObs_Seguridad.Text = TxtObs_Seguridad.Text
            LblUtiliza_Guion_Saludo_Nom.Text = drlUtiliza_Guion_Saludo_Nom.Text
            LblObs_Utiliza_Guion_Saludo_Nom.Text = TxtObs_Utiliza_Guion_Saludo_Nom.Text
            LblGestion_Llamada.Text = drlGestion_Llamada.Text
            LblObs_Gestion_Llamada.Text = TxtObs_Gestion_Llamada.Text
            LblGestion_Soporte.Text = drlGestion_Soporte.Text
            LblObs_Gestion_Soporte.Text = TxtObs_Gestion_Soporte.Text
            LblGestion_Asignacion.Text = drlGestion_Asignacion.Text
            LblObs_Gestion_Asignacion.Text = TxtObs_Gestion_Asignacion.Text
            LblGestion_Cierre.Text = drlGestion_Cierre.Text
            LblObs_Gestion_Cierre.Text = TxtObs_Gestion_Cierre.Text
            LblSolucion.Text = drlSolucion.Text
            LblObs_Solucion.Text = TxtObs_Solucion.Text
            LblInteres_Escucha.Text = drlInteres_Escucha.Text
            LblObs_Interes_Escucha.Text = TxtObs_Interes_Escucha.Text
            LblObs_Generales.Text = TxtObs_Generales.Text
            Visibilidad()

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnConsulta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsulta.Click
        Try
            Dim dts As DataSet
            If TxtCod_Consulta.Text = "" Then
                lblmsg.Text = "Ingrese un codigo para realizar la consulta"
                Exit Sub
            Else
                ObjCalidad.Cod_Calidad_Registro = TxtCod_Consulta.Text
                dts = ObjCalidad.Llenar_TextBox()

                If dts.Tables(0).Rows.Count > 0 Then
                    Lblcaso.Text = ObjCalidad.caso
                    LblNomAgente.Text = ObjCalidad.agente
                    LblGrupo.Text = ObjCalidad.grupo
                    LblAuditorConsulta.Text = ObjCalidad.Auditor
                    LblProceso.Text = ObjCalidad.Proceso
                    LblCampaña.Text = ObjCalidad.Campania
                    LblFc_Llamada.Text = ObjCalidad.Fc_Llamada
                    LblTiempoAcumulado.Text = ObjCalidad.Tiempo_Acum_Llamada
                    LblCantidad_Llamadas.Text = ObjCalidad.N_Llamadas_Min
                    LblEstado.Text = ObjCalidad.Estado_Caso
                    LblTipo_Auditoria.Text = ObjCalidad.Tipo_Auditoria
                    LblAmabilidad_Empatia.Text = ObjCalidad.Amabilidad_Empatia
                    LblRealiza_Filtro_A.Text = ObjCalidad.Real_filtros_adecuados
                    LblObs_Amabilidad_Empatia.Text = ObjCalidad.Obs_Amabilidad_Empatia
                    LblColgada_Llamada.Text = ObjCalidad.Colgada_Llamada
                    LblObs_Colgada_Llamada.Text = ObjCalidad.Obs_Colgada_Llamada
                    LblObs_Realiza_Filtro_A.Text = ObjCalidad.Obs_Real_filtros_adecuados
                    LblCorona_Abierta.Text = ObjCalidad.Corona_Abierta
                    LblObs_Corona_Abierta.Text = ObjCalidad.Obs_Corona_Abierta
                    LblDocumentacion.Text = ObjCalidad.Documentacion
                    LblObs_Documentacion.Text = ObjCalidad.Obs_Documentacion
                    LblProcedimiento_PQR.Text = ObjCalidad.Procedimiento_PQR
                    LblObs_Procedimiento_PQR.Text = ObjCalidad.Obs_Procedimiento_PQR
                    LblProcedimiento_Prueb_Tram_Incom_Incorrec.Text = ObjCalidad.Procedimiento_prueba_tramite_incompleto_incorrecto
                    LblObs_Procedimiento_Prueb_Tram_Incom_Incorrec.Text = ObjCalidad.Obs_Procedimiento_prueba_tramite_incompleto_incorrecto
                    LblPresenta_Obj_Llamada.Text = ObjCalidad.Presenta_objetivo_llamada
                    LblObs_Presenta_Obj_Llamada.Text = ObjCalidad.Obs_Presenta_objetivo_llamada
                    LblCordialidad_Comunicacion.Text = ObjCalidad.Cordialidad_Comunicacion
                    LblObs_Cordialidad_Comunicacion.Text = ObjCalidad.Obs_Cordialidad_Comunicacion
                    LblCordialidad.Text = ObjCalidad.Cordialidad
                    LblObs_Cordialidad.Text = ObjCalidad.Obs_Cordialidad
                    LblContacto_Activo.Text = ObjCalidad.Contacto_Activo
                    LblObs_Contacto_Activo.Text = ObjCalidad.Obs_Contacto_Activo
                    LblClaridad_Transmitir_Inf.Text = ObjCalidad.Claridad_transmitir_informacion
                    LblObs_Claridad_Transmitir_Inf.Text = ObjCalidad.Obs_Claridad_transmitir_informacion
                    LblSeguridad.Text = ObjCalidad.Seguridad
                    LblObs_Seguridad.Text = ObjCalidad.Obs_Seguridad
                    LblUtiliza_Guion_Saludo_Nom.Text = ObjCalidad.Util_guion_saludo
                    LblObs_Utiliza_Guion_Saludo_Nom.Text = ObjCalidad.Obs_Util_guion_saludo
                    LblGestion_Llamada.Text = ObjCalidad.Gestion_Llamada
                    LblObs_Gestion_Llamada.Text = ObjCalidad.Obs_Gestion_Llamada
                    LblGestion_Soporte.Text = ObjCalidad.Gestion_Soporte
                    LblObs_Gestion_Soporte.Text = ObjCalidad.Obs_Gestion_Soporte
                    LblGestion_Asignacion.Text = ObjCalidad.Gestion_Asignacion
                    LblObs_Gestion_Asignacion.Text = ObjCalidad.Obs_Gestion_Asignacion
                    LblGestion_Cierre.Text = ObjCalidad.Gestion_Cierre
                    LblObs_Gestion_Cierre.Text = ObjCalidad.Obs_Gestion_Cierre
                    LblSolucion.Text = ObjCalidad.Solucion
                    LblObs_Solucion.Text = ObjCalidad.Obs_Solucion
                    LblInteres_Escucha.Text = ObjCalidad.Interes_escuchar
                    LblObs_Interes_Escucha.Text = ObjCalidad.Obs_Interes_escuchar
                    LblObs_Generales.Text = ObjCalidad.Obs_General
                    LblReincide.Text = ObjCalidad.Reincide
                    LblObs_Reincide.Text = ObjCalidad.obs_Reincide
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

    Protected Sub BtnConsultaAgente_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultaAgente.Click
        Try
            If TxtConsultaCod_Agente.Text = "" Then
                lblmsg.Text = "Ingrese el codigo del agente antes de realizar la consulta"
                Exit Sub
            End If
            ObjCalidad.caso = -1
            ObjCalidad.CodigoAgente = TxtConsultaCod_Agente.Text
            With drlNomAgente
                .DataSource = ObjCalidad.Consulta_Caso_Agente
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento erro: " + ex.Message
        End Try
    End Sub

    Public Sub Consulta()
        Try
            If TxtFechaInicio.Text = "" Or TxtFechaFin.Text = "" Then
                lblmsg.Text = "Ingrese un rango de fechas para realizar la consulta, se recomienda que no sea tan extenso el rango para agilizar la consulta"
                dtggeneral.DataSource = Nothing
                dtggeneral.DataBind()
                LblCantidad.Text = "0"
                Exit Sub
            End If
            ObjCalidad.fcini = TxtFechaInicio.Text
            ObjCalidad.fcfin = TxtFechaFin.Text
            If TxtCod_Agente.Text <> Nothing Then
                ObjCalidad.CodigoAgente = TxtCod_Agente.Text
            End If
            If drlGrupo_Consulta.Text <> Nothing And drlGrupo_Consulta.Text <> "- Seleccione -" Then
                ObjCalidad.grupo = drlGrupo_Consulta.Text
            End If
            If ValidaExcel = "1" Then
                dtgExcel.DataSource = ObjCalidad.Consulta_Auditorias_Agente
                dtgExcel.DataBind()
            Else
                ValidaExcel = "2"
            End If

            dtggeneral.DataSource = ObjCalidad.Consulta_Auditorias_Agente
            dtggeneral.DataBind()

            LblCantidad.Text = ObjCalidad.cantidad

            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnConsultaAditorias_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultaAditorias.Click
        Try
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Sub crearexcel()
        Try
            Dim sb As New StringBuilder
            Dim sw As New StringWriter(sb)
            Dim htw As New HtmlTextWriter(sw)
            Dim pagina As Page = New Page
            Dim form = New HtmlForm
            Dim objdtsconsultaxls As New DataSet
            Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"

            pagina.EnableEventValidation = False
            pagina.DesignerInitialize()
            pagina.Controls.Add(form)
            dtgExcel.Visible = True
            form.Controls.Add(dtgExcel)
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
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Dim ValidaExcel As String

    Protected Sub BtnExporta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnExporta.Click
        Try
            If Integer.Parse(LblCantidad.Text) < 1 Then
                lblmsg.Text = "Realice una consulta antes de exportar a excel."
                Exit Sub
            End If
            ValidaExcel = "1"
            Consulta()
            If ValidaExcel = "2" Then
                Exit Sub
            End If
            crearexcel()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
End Class