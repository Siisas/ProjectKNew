Imports System.IO
Public Class Auditoria_Reg_V3
    Inherits System.Web.UI.Page
    Dim ObjCalidad As New clscalidad

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Registro Auditoria V3"
                drlAuditor.Text = CType(Session("permisos"), clsusuario).usuario
                drlAuditorNombre.Text = CType(Session("permisos"), clsusuario).nombre
                Cargar_drl()
                Llenar_Observaciones()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Public Sub Cargar_drl()
        Try
            LblFecha.Text = FormatDateTime(Now, DateFormat.ShortDate)
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
            'ObjCalidad.Validacion = "5"
            'With drlGrupo
            '    .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
            '    .DataTextField = "Cargo"
            '    .DataValueField = "Cargo"
            '    .DataBind()
            'End With
            ObjCalidad.Validacion = "1"
            With drlCampaña_Consulta
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            ObjCalidad.caso = -1
            With drlNomAgente
                .DataSource = ObjCalidad.Consulta_Caso_Agente
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
            ObjCalidad.Validacion = "Tipos Clientes"
            With Drl_Tipo_Cliente
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Nombre"
                .DataValueField = "Cod_Calidad_Registro_Complemento"
                .DataBind()
                .Items.Insert(0, "-Seleccione-")
                .Items(0).Value = 0
            End With
            ObjCalidad.Validacion = "Tipos PQR"
            With Drl_Tipo_PQR
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Nombre"
                .DataValueField = "Cod_Calidad_Registro_Complemento"
                .DataBind()
                .Items.Insert(0, "-Seleccione-")
                .Items(0).Value = 0
            End With

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub BtnValidar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnValidar.Click
        Try
            If txtcaso.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese algun caso para realizar la validacion"
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
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Try
            If txtcaso.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese algun caso y luego realizar la validacion de este"
                Exit Sub
            End If
            'If drlNomAgente.Text = "- Seleccione -" Or drlNomAgente.Text = "" Or drlNomAgente.Text = "0" Then
            '    Pnl_Message.CssClass = "alert alert-warning"
            '    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un ingeniero o agente"
            '    Exit Sub
            'End If
            'If drlGrupo.Text = "- Seleccione -" Or drlGrupo.Text = "" Or drlGrupo.Text = "0" Then
            '    Pnl_Message.CssClass = "alert alert-warning"
            '    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione el grupo del ingeniero o agente"
            '    Exit Sub
            'End If
            If drlAuditor.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el nombre del auditor"
                Exit Sub
            End If
            If drlProceso.Text = "- Seleccione -" Or drlProceso.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un proceso"
                Exit Sub
            End If
            If TxtFc_Llamada.Text = "" Or TxtHora_Llamada.Text = "" Or TxtMinuto_Llamada.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese una fecha y hora de la llamada"
                Exit Sub
            Else
                If Integer.Parse(TxtHora_Llamada.Text) > 23 Or Integer.Parse(TxtHora_Llamada.Text) < 1 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Verifique la hora de la llamada"
                    Exit Sub
                End If
                If Integer.Parse(TxtMinuto_Llamada.Text) > 59 Or Integer.Parse(TxtMinuto_Llamada.Text) < 0 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Verifique los minutos de la llamda"
                    Exit Sub
                End If
            End If
            If TxtHora.Text = "" Or TxtMinuto.Text = "" Or TxtSegundo.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el tiempo acumulado de llamada"
                Exit Sub
            Else
                If Integer.Parse(TxtHora.Text) > 24 Or Integer.Parse(TxtHora.Text) < 0 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Verifique la hora de tiempo acumulado"
                    Exit Sub
                End If
                If Integer.Parse(TxtMinuto.Text) > 59 Or Integer.Parse(TxtMinuto.Text) < 0 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Verifique los minutos de tiempo acumulado"
                    Exit Sub
                End If
                If Integer.Parse(TxtSegundo.Text) > 59 Or Integer.Parse(TxtSegundo.Text) < 0 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Verifique los segundos de tiempo acumulado"
                    Exit Sub
                End If
            End If
            If TxtCantidad_Llamadas.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la cantidad de llamadas"
                Exit Sub
            End If
            If drlEstado.Text = "- Seleccione -" Or drlEstado.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione el estado del caso"
                Exit Sub
            End If
            If drlTipo_Auditoria.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione el tipo de auditoria"
                Exit Sub
            End If
            '------------------ ATENCION ------------------'
            If drlManejo_Guion.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para el manejo de guion"
                Exit Sub
            End If
            If TxtObs_Manejo_Guion.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el manejo de guion"
                Exit Sub
            End If
            '--
            If drlDisponibilidad_Atender_Llamada.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para el ítem de disponibilidad para atender y manejo de llamada"
                Exit Sub
            End If
            If TxtObs_Disponibilidad_Atender_Llamada.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el ítem de disponibilidad para atender y manejo de llamada"
                Exit Sub
            End If
            '--
            If drlCordialidad_Comunicacion.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para Cordialidad y comunicacion"
                Exit Sub
            End If
            If TxtObs_Cordialidad_Comunicacion.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de Cordialidad y comunicacion"
                Exit Sub
            End If
            '--
            If drlClaridad_Transmitir_Informacion.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para calidad al transmitir informacion"
                Exit Sub
            End If
            If TxtObs_Claridad_Transmitir_Informacion.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de transmitir informacion"
                Exit Sub
            End If
            '--
            If drlContacto_Activo.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para contacto activo"
                Exit Sub
            End If
            If TxtObs_Contacto_Activo.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de contacto activo"
                Exit Sub
            End If
            '--
            If drlCorona_Abierta.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para corona abierta"
                Exit Sub
            End If
            If TxtObs_Corona_Abierta.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de corona abierta"
                Exit Sub
            End If
            '--
            If drlAmabilidad_Empatia.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para la amabilidad y empatia"
                Exit Sub
            End If
            If TxtObs_Amabilidad_Empatia.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de amabilidad y empatia"
                Exit Sub
            End If
            '------------------ GESTION ------------------'
            If drlFiltros_Eficiencia_Gestion.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para filtros y eficiencia en la gestion"
                Exit Sub
            End If
            If TxtObs_Filtros_Eficiencia_Gestion.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de filtros y eficiencia en la gestion"
                Exit Sub
            End If
            '--
            If drlInteres_Escuchar_Entender_Necesidades_Plantear_Soluciones.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para interes en escuchar, entender sus necesidades y plantear soluciones"
                Exit Sub
            End If
            If TxtObs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de interes en escuchar, entender sus necesidades y plantear soluciones"
                Exit Sub
            End If
            '--
            If drlEscucha_Activa.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para escucha activa e identidad corporativa"
                Exit Sub
            End If
            If TxtObs_Escucha_Activa.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de escucha activa e identidad corporativa"
                Exit Sub
            End If
            '--
            If drlDocumentacion_Sistema.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para documentacion en el sistema"
                Exit Sub
            End If
            If TxtObs_Documentacion_Sistema.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de documentacion en el sistema"
                Exit Sub
            End If
            '--
            If drlCuelgue_Llamada.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para cuelgue de llamada"
                Exit Sub
            End If
            If TxtObs_Cuelgue_Llamada.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de cuelgue de llamada"
                Exit Sub
            End If
            '------------------ SOLUCION ------------------'
            If drlAplicacion_Manejo_Incompleto_Procedmientos_Tramites.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para la aplicacion y manejo incompleto de procedimientos y tramites"
                Exit Sub
            End If
            If TxtObs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de aplicacion y manejo  incompleto de procedimientos y tramites"
                Exit Sub
            End If
            '--
            If drlAplicacion_Manejo_Correcto_Procedimientos_Tramites.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para la aplicacion y manejo  correcto de procedimientos y tramites "
                Exit Sub
            End If
            If TxtObs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de aplicacion y manejo  correcto de procedimientos y tramites"
                Exit Sub
            End If
            '--
            If drlResolucion_Necesidad_Cliente.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para la resolucion necesidad del cliente "
                Exit Sub
            End If
            If TxtObs_Resolucion_Necesidad_Cliente.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de resolucion necesidad del cliente "
                Exit Sub
            End If
            '------------------ CIERRE ------------------'
            If drlProcedimiento_PQR.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para el procedimiento de PQR"
                Exit Sub
            End If
            If TxtObs_Procedimiento_PQR.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de procedimiento de PQR"
                Exit Sub
            End If
            '--
            If drlEscalamientos_Requeridos.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una opcion para escalamientos requeridos"
                Exit Sub
            End If
            If TxtObs_Escalamientos_Requeridos.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de escalamientos requeridos"
                Exit Sub
            End If
            '------------------ ESTADISTICAS ------------------'
            If DrlSolucion_Primer_contacto.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para la solucion en primer contacto"
                Exit Sub
            End If
            If TxtObs_Solucion_Primer_contacto.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de solucion en primer contacto"
                Exit Sub
            End If
            '--
            If DrlSolucion_Parcial.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una calificacion para la solucion parcial"
                Exit Sub
            End If
            If TxtObs_Solucion_Parcial.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna observacion para el item de Solucion Parcial"
                Exit Sub
            End If
            If drlReporta_Inc.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una opcion para Reporta Inconsistencia"
                Exit Sub
            End If

            If TxtObs_Generales.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna comentario para observacion general"
                Exit Sub
            End If
            If DrlSatisfaccion.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna opcion de satisfaccion"
                Exit Sub
            End If

            ObjCalidad.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            ObjCalidad.caso = txtcaso.Text
            ObjCalidad.agente = drlNomAgente.Text
            ObjCalidad.grupo = ""
            ObjCalidad.Auditor = drlAuditor.Text
            ObjCalidad.Campania = LblCampaña.Text
            ObjCalidad.Proceso = drlProceso.Text
            ObjCalidad.Fc_Llamada = TxtFc_Llamada.Text + " " + TxtHora_Llamada.Text + ":" + TxtMinuto_Llamada.Text
            ObjCalidad.Tiempo_Acum_Llamada = TxtHora.Text + ":" + TxtMinuto.Text + ":" + TxtSegundo.Text
            ObjCalidad.N_Llamadas_Min = TxtCantidad_Llamadas.Text
            ObjCalidad.Estado_Caso = drlEstado.Text
            ObjCalidad.Tipo_Auditoria = drlTipo_Auditoria.Text
            Dim Acumulado As Integer
            '------------------ ATENCION ------------------' Peso 22
            ObjCalidad.Procedimiento_prueba_tramite_incompleto_incorrecto = drlManejo_Guion.Text 'Peso 2
            ObjCalidad.Obs_Procedimiento_prueba_tramite_incompleto_incorrecto = TxtObs_Manejo_Guion.Text
            ObjCalidad.Amabilidad_Empatia = drlDisponibilidad_Atender_Llamada.Text 'Peso 2
            ObjCalidad.Obs_Amabilidad_Empatia = TxtObs_Disponibilidad_Atender_Llamada.Text
            ObjCalidad.Colgada_Llamada = drlCordialidad_Comunicacion.Text 'Peso 5
            ObjCalidad.Obs_Colgada_Llamada = TxtObs_Cordialidad_Comunicacion.Text
            ObjCalidad.Real_filtros_adecuados = drlClaridad_Transmitir_Informacion.Text 'Peso 2
            ObjCalidad.Obs_Real_filtros_adecuados = TxtObs_Claridad_Transmitir_Informacion.Text
            ObjCalidad.Seguridad = drlContacto_Activo.Text 'Peso 2
            ObjCalidad.Obs_Seguridad = TxtObs_Contacto_Activo.Text
            ObjCalidad.Corona_Abierta = drlCorona_Abierta.Text 'Peso 2
            ObjCalidad.Obs_Corona_Abierta = TxtObs_Corona_Abierta.Text
            ObjCalidad.Procedimiento_PQR = drlAmabilidad_Empatia.Text 'Peso 7
            ObjCalidad.Obs_Procedimiento_PQR = TxtObs_Amabilidad_Empatia.Text
            If drlManejo_Guion.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 2
            End If
            If drlDisponibilidad_Atender_Llamada.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 2
            End If
            If drlCordialidad_Comunicacion.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 5
            End If
            If drlClaridad_Transmitir_Informacion.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 2
            End If
            If drlContacto_Activo.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 2
            End If
            If drlCorona_Abierta.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 2
            End If
            If drlAmabilidad_Empatia.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 7
            End If
            ObjCalidad.Total_Atencion = Acumulado
            Acumulado = 0
            '------------------ GESTION ------------------' Peso 29
            ObjCalidad.Presenta_objetivo_llamada = drlFiltros_Eficiencia_Gestion.Text 'Peso 3
            ObjCalidad.Obs_Presenta_objetivo_llamada = TxtObs_Filtros_Eficiencia_Gestion.Text
            ObjCalidad.Cordialidad_Comunicacion = drlInteres_Escuchar_Entender_Necesidades_Plantear_Soluciones.Text 'Peso 3
            ObjCalidad.Obs_Cordialidad_Comunicacion = TxtObs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones.Text
            ObjCalidad.Cordialidad = drlEscucha_Activa.Text 'Peso 3
            ObjCalidad.Obs_Cordialidad = TxtObs_Escucha_Activa.Text
            ObjCalidad.Documentacion = drlDocumentacion_Sistema.Text 'Peso 10
            ObjCalidad.Obs_Documentacion = TxtObs_Documentacion_Sistema.Text
            ObjCalidad.Claridad_transmitir_informacion = drlCuelgue_Llamada.Text 'Peso 10
            ObjCalidad.Obs_Claridad_transmitir_informacion = TxtObs_Cuelgue_Llamada.Text
            If drlFiltros_Eficiencia_Gestion.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 3
            End If
            If drlInteres_Escuchar_Entender_Necesidades_Plantear_Soluciones.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 3
            End If
            If drlEscucha_Activa.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 3
            End If
            If drlDocumentacion_Sistema.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 10
            End If
            If drlCuelgue_Llamada.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 10
            End If
            ObjCalidad.Total_Gestion = Acumulado
            Acumulado = 0
            '------------------ SOLUCION ------------------' Peso 29
            ObjCalidad.Gestion_Asignacion = drlAplicacion_Manejo_Incompleto_Procedmientos_Tramites.Text 'Peso 7
            ObjCalidad.Obs_Gestion_Asignacion = TxtObs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites.Text
            ObjCalidad.Gestion_Llamada = drlAplicacion_Manejo_Correcto_Procedimientos_Tramites.Text 'Peso 9
            ObjCalidad.Obs_Gestion_Llamada = TxtObs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites.Text
            ObjCalidad.Gestion_Soporte = drlResolucion_Necesidad_Cliente.Text 'Peso 13
            ObjCalidad.Obs_Gestion_Soporte = TxtObs_Resolucion_Necesidad_Cliente.Text
            If drlAplicacion_Manejo_Incompleto_Procedmientos_Tramites.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 7
            End If
            If drlAplicacion_Manejo_Correcto_Procedimientos_Tramites.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 9
            End If
            If drlResolucion_Necesidad_Cliente.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 13
            End If
            ObjCalidad.Total_Solucion = Acumulado
            Acumulado = 0
            '------------------ CIERRE ------------------' Peso 20
            ObjCalidad.Solucion = drlProcedimiento_PQR.Text 'Peso 12
            ObjCalidad.Obs_Solucion = TxtObs_Procedimiento_PQR.Text
            ObjCalidad.Interes_escuchar = drlEscalamientos_Requeridos.Text 'Peso 8
            ObjCalidad.Obs_Interes_escuchar = TxtObs_Escalamientos_Requeridos.Text
            If drlProcedimiento_PQR.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 12
            End If
            If drlEscalamientos_Requeridos.SelectedItem.Text = "100" Then
                Acumulado = Acumulado + 8
            End If
            ObjCalidad.Total_Cierre = Acumulado
            '------------------ ESTADISTICAS ------------------'
            ObjCalidad.Contacto_Activo = DrlSolucion_Primer_contacto.Text
            ObjCalidad.Obs_Contacto_Activo = TxtObs_Solucion_Primer_contacto.Text
            ObjCalidad.Reincide = DrlSolucion_Parcial.Text
            ObjCalidad.Reporta_Inc = drlReporta_Inc.Text
            ObjCalidad.obs_Reincide = TxtObs_Solucion_Parcial.Text
            ObjCalidad.Obs_General = TxtObs_Generales.Text
            ObjCalidad.satisfaccion = DrlSatisfaccion.Text
            ObjCalidad.Id_Tipo_PQR = Drl_Tipo_PQR.SelectedValue
            ObjCalidad.Id_Tipo_Cliente = Drl_Tipo_Cliente.SelectedValue

            ''''
            ObjCalidad.Registro_Auditoria_Calidad_V3()
            ObjCalidad.Consulta_Registro_V3()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro Realizado con el codigo: " + ObjCalidad.Cod_Calidad_Registro.ToString
            txtcaso.Text = ""
            LblCampaña.Text = ""
            TxtFc_Llamada.Text = ""
            TxtHora_Llamada.Text = ""
            TxtMinuto_Llamada.Text = ""
            TxtHora.Text = ""
            TxtMinuto.Text = ""
            TxtSegundo.Text = ""
            TxtCantidad_Llamadas.Text = ""
            drlDisponibilidad_Atender_Llamada.SelectedIndex = 0
            TxtObs_Disponibilidad_Atender_Llamada.Text = ""
            drlCordialidad_Comunicacion.SelectedIndex = 0
            TxtObs_Cordialidad_Comunicacion.Text = ""
            drlClaridad_Transmitir_Informacion.SelectedIndex = 0
            TxtObs_Claridad_Transmitir_Informacion.Text = ""
            drlCorona_Abierta.SelectedIndex = 0
            TxtObs_Corona_Abierta.Text = ""
            drlAmabilidad_Empatia.SelectedIndex = 0
            TxtObs_Amabilidad_Empatia.Text = ""
            drlManejo_Guion.SelectedIndex = 0
            TxtObs_Manejo_Guion.Text = ""
            drlFiltros_Eficiencia_Gestion.SelectedIndex = 0
            TxtObs_Filtros_Eficiencia_Gestion.Text = ""
            drlInteres_Escuchar_Entender_Necesidades_Plantear_Soluciones.SelectedIndex = 0
            TxtObs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones.Text = ""
            drlEscucha_Activa.SelectedIndex = 0
            TxtObs_Escucha_Activa.Text = ""
            drlDocumentacion_Sistema.SelectedIndex = 0
            TxtObs_Documentacion_Sistema.Text = ""
            drlCuelgue_Llamada.SelectedIndex = 0
            TxtObs_Cuelgue_Llamada.Text = ""
            drlAplicacion_Manejo_Correcto_Procedimientos_Tramites.SelectedIndex = 0
            TxtObs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites.Text = ""
            drlResolucion_Necesidad_Cliente.SelectedIndex = 0
            TxtObs_Procedimiento_PQR.Text = ""
            drlAplicacion_Manejo_Incompleto_Procedmientos_Tramites.SelectedIndex = 0
            TxtObs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites.Text = ""
            drlProcedimiento_PQR.SelectedIndex = 0
            TxtObs_Procedimiento_PQR.Text = ""
            drlEscalamientos_Requeridos.SelectedIndex = 0
            DrlSolucion_Primer_contacto.SelectedIndex = 0
            DrlSolucion_Parcial.SelectedIndex = 0
            TxtObs_Solucion_Primer_contacto.Text = ""
            TxtObs_Solucion_Parcial.Text = ""
            TxtObs_Escalamientos_Requeridos.Text = ""
            TxtObs_Generales.Text = ""
            TxtConsultaCod_Agente.Text = ""
            drlContacto_Activo.SelectedIndex = 0
            TxtObs_Contacto_Activo.Text = ""
            TxtObs_Resolucion_Necesidad_Cliente.Text = ""
            drlReporta_Inc.SelectedIndex = 0
            DrlSatisfaccion.SelectedIndex = 0
            LblCantidad.Text = Nothing
            Cargar_drl()
            Drl_Tipo_PQR.SelectedIndex = 0
            Drl_Tipo_Cliente.SelectedIndex = 0

            Llenar_Observaciones()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
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
            'drlGrupo.Visible = False
            drlAuditor.Visible = False
            drlAuditorNombre.Visible = False
            drlProceso.Visible = False
            PanelFc_Llamada.Visible = False
            PanelTiempoAcumulado.Visible = False
            PanelCantidad_Llamada.Visible = False
            drlEstado.Visible = False
            drlTipo_Auditoria.Visible = False
            drlDisponibilidad_Atender_Llamada.Visible = False
            TxtObs_Disponibilidad_Atender_Llamada.Visible = False
            drlCordialidad_Comunicacion.Visible = False
            TxtObs_Cordialidad_Comunicacion.Visible = False
            drlClaridad_Transmitir_Informacion.Visible = False
            TxtObs_Claridad_Transmitir_Informacion.Visible = False
            drlContacto_Activo.Visible = False
            TxtObs_Contacto_Activo.Visible = False
            drlCorona_Abierta.Visible = False
            TxtObs_Corona_Abierta.Visible = False
            drlAmabilidad_Empatia.Visible = False
            TxtObs_Amabilidad_Empatia.Visible = False
            drlManejo_Guion.Visible = False
            TxtObs_Manejo_Guion.Visible = False
            drlFiltros_Eficiencia_Gestion.Visible = False
            TxtObs_Filtros_Eficiencia_Gestion.Visible = False
            drlInteres_Escuchar_Entender_Necesidades_Plantear_Soluciones.Visible = False
            TxtObs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones.Visible = False
            drlEscucha_Activa.Visible = False
            TxtObs_Escucha_Activa.Visible = False
            drlDocumentacion_Sistema.Visible = False
            TxtObs_Documentacion_Sistema.Visible = False
            drlCuelgue_Llamada.Visible = False
            TxtObs_Cuelgue_Llamada.Visible = False
            drlAplicacion_Manejo_Correcto_Procedimientos_Tramites.Visible = False
            TxtObs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites.Visible = False
            drlResolucion_Necesidad_Cliente.Visible = False
            TxtObs_Resolucion_Necesidad_Cliente.Visible = False
            drlAplicacion_Manejo_Incompleto_Procedmientos_Tramites.Visible = False
            TxtObs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites.Visible = False
            drlProcedimiento_PQR.Visible = False
            TxtObs_Procedimiento_PQR.Visible = False
            drlEscalamientos_Requeridos.Visible = False
            DrlSolucion_Primer_contacto.Visible = False
            DrlSolucion_Parcial.Visible = False
            TxtObs_Solucion_Parcial.Visible = False
            TxtObs_Solucion_Primer_contacto.Visible = False
            TxtObs_Escalamientos_Requeridos.Visible = False
            TxtObs_Generales.Visible = False
            TxtConsultaCod_Agente.Visible = False
            BtnConsultaAgente.Visible = False
            Panel1.Visible = True
            drlReporta_Inc.Visible = False
            DrlSatisfaccion.Visible = False
            Drl_Tipo_Cliente.Visible = False
            Drl_Tipo_PQR.Visible = False


        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub BtnVista_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnVista.Click
        Try
            Lblcaso.Text = txtcaso.Text
            LblNomAgente.Text = drlNomAgente.Text
            'LblGrupo.Text = drlGrupo.Text
            LblAuditorConsulta.Text = drlAuditor.Text
            LblProceso.Text = drlProceso.Text
            LblFc_Llamada.Text = TxtFc_Llamada.Text + " " + TxtHora_Llamada.Text + ":" + TxtMinuto_Llamada.Text
            LblTiempoAcumulado.Text = TxtHora.Text + ":" + TxtMinuto.Text + ":" + TxtSegundo.Text
            LblCantidad_Llamadas.Text = TxtCantidad_Llamadas.Text
            LblEstado.Text = drlEstado.Text
            LblTipo_Auditoria.Text = drlTipo_Auditoria.Text
            LblDisponibilidad_Atender_Llamada.Text = drlDisponibilidad_Atender_Llamada.Text
            LblObs_Disponibilidad_Atender_Llamada.Text = TxtObs_Disponibilidad_Atender_Llamada.Text
            LblCordialidad_Comunicacion.Text = drlCordialidad_Comunicacion.Text
            LblObs_Cordialidad_Comunicacion.Text = TxtObs_Cordialidad_Comunicacion.Text
            LblObs_Claridad_Transmitir_Informacion.Text = drlClaridad_Transmitir_Informacion.Text
            LblObs_Claridad_Transmitir_Informacion.Text = TxtObs_Claridad_Transmitir_Informacion.Text
            LblCorona_Abierta.Text = drlCorona_Abierta.Text
            LblObs_Corona_Abierta.Text = TxtObs_Corona_Abierta.Text
            LblAmabilidad_Empatia.Text = drlAmabilidad_Empatia.Text
            LblObs_Amabilidad_Empatia.Text = TxtObs_Amabilidad_Empatia.Text
            LblManejo_Guion.Text = drlManejo_Guion.Text
            LblObs_Manejo_Guion.Text = TxtObs_Manejo_Guion.Text
            LblFiltros_Eficiencia_Gestion.Text = drlFiltros_Eficiencia_Gestion.Text
            LblObs_Filtros_Eficiencia_Gestion.Text = TxtObs_Filtros_Eficiencia_Gestion.Text
            LblInteres_Escuchar_Entender_Necesidades_Plantear_Soluciones.Text = drlInteres_Escuchar_Entender_Necesidades_Plantear_Soluciones.Text
            LblObs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones.Text = TxtObs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones.Text
            LblEscucha_Activa.Text = drlEscucha_Activa.Text
            LblObs_Escucha_Activa.Text = TxtObs_Escucha_Activa.Text
            LblDocumentacion_Sistema.Text = drlDocumentacion_Sistema.Text
            LblObs_Documentacion_Sistema.Text = TxtObs_Documentacion_Sistema.Text
            LblCuelgue_Llamada.Text = drlCuelgue_Llamada.Text
            LblObs_Cuelgue_Llamada.Text = TxtObs_Cuelgue_Llamada.Text
            LblAplicacion_Manejo_Correcto_Procedimientos_Tramites.Text = drlAplicacion_Manejo_Correcto_Procedimientos_Tramites.Text
            LblObs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites.Text = TxtObs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites.Text
            LblResolucion_Necesidad_Cliente.Text = drlResolucion_Necesidad_Cliente.Text
            LblObs_Resolucion_Necesidad_Cliente.Text = TxtObs_Resolucion_Necesidad_Cliente.Text
            LblAplicacion_Manejo_Incompleto_Procedmientos_Tramites.Text = drlAplicacion_Manejo_Incompleto_Procedmientos_Tramites.Text
            LblObs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites.Text = TxtObs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites.Text
            LblProcedimiento_PQR.Text = drlProcedimiento_PQR.Text
            LblObs_Procedimiento_PQR.Text = TxtObs_Procedimiento_PQR.Text
            LblEscalamientos_Requeridos.Text = drlEscalamientos_Requeridos.Text
            LblObs_Escalamientos_Requeridos.Text = TxtObs_Escalamientos_Requeridos.Text
            LblSolucion_Primer_contacto.Text = DrlSolucion_Primer_contacto.Text
            LblObs_Solucion_Primer_contacto.Text = TxtObs_Solucion_Primer_contacto.Text
            LblSolucion_Parcial.Text = DrlSolucion_Parcial.Text
            LblObs_Solucion_Parcial.Text = TxtObs_Solucion_Parcial.Text
            LblObs_Generales.Text = TxtObs_Generales.Text
            Visibilidad()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub BtnConsulta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsulta.Click
        Try
            Dim dts As DataSet
            If TxtCod_Consulta.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese un codigo para realizar la consulta"
                Exit Sub
            Else
                ObjCalidad.Cod_Calidad_Registro = TxtCod_Consulta.Text
                dts = ObjCalidad.Llenar_TextBox_V3()
                If dts.Tables(0).Rows.Count > 0 Then
                    Lbl_Tipo_Cliente.Text = ObjCalidad.Tipo_Cliente
                    Lbl_Tipo_PQR.Text = ObjCalidad.Tipo_PQR

                    Lblcaso.Text = ObjCalidad.caso
                    LblNomAgente.Text = ObjCalidad.agente
                    'LblGrupo.Text = ObjCalidad.grupo
                    LblAuditorConsulta.Text = ObjCalidad.Auditor
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
                    LblObs_Disponibilidad_Atender_Llamada.Text = ObjCalidad.Obs_Colgada_Llamada
                    LblCordialidad_Comunicacion.Text = ObjCalidad.Real_filtros_adecuados
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
                    LblReporta_Inc.Text = ObjCalidad.Reporta_Inc
                    Lbl_Satisfaccion.Text = ObjCalidad.satisfaccion
                    Visibilidad()
                    Pnl_Message.CssClass = Nothing
                    lblmsg.Text = Nothing
                Else
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros con el codigo: " + TxtCod_Consulta.Text
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub BtnConsultaAgente_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultaAgente.Click
        Try
            If TxtConsultaCod_Agente.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el codigo del agente antes de realizar la consulta"
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
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Public Sub Consulta()
        Try
            If TxtFechaInicio.Text = "" Or TxtFechaFin.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese un rango de fechas para realizar la consulta, se recomienda que no sea tan extenso el rango para agilizar la consulta"
                Exit Sub
            End If
            If Date.Parse(TxtFechaInicio.Text) > Date.Parse(TxtFechaFin.Text) Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Verifique el rango de fechas ya que la Fecha Inicio no puede ser mayor a la Fecha Fin "
                Exit Sub
            End If
            ObjCalidad.fcini = TxtFechaInicio.Text
            ObjCalidad.fcfin = TxtFechaFin.Text
            If TxtCod_Agente.Text <> Nothing Then
                ObjCalidad.CodigoAgente = TxtCod_Agente.Text
            End If
            If drlCampaña_Consulta.SelectedIndex <> 0 Then
                ObjCalidad.Campania = drlCampaña_Consulta.SelectedItem.Text
            End If
            If ValidaExcel = "1" Then
                dtggeneral.DataSource = ObjCalidad.Consulta_Auditorias_Agente_V3
                dtggeneral.DataBind()
                LblCantidad.Text = "Registros encontrados: " & ObjCalidad.cantidad
            Else
                ValidaExcel = "2"
            End If
            dtggeneral.DataSource = ObjCalidad.Consulta_Auditorias_Agente_V3
            dtggeneral.DataBind()
            LblCantidad.Text = "Registros encontrados: " & ObjCalidad.cantidad
            If Integer.Parse(dtggeneral.Rows.Count) < 1 Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros con el filtro realizado"
                LblCantidad.Text = Nothing
            Else
                Pnl_Message.CssClass = Nothing
                lblmsg.Text = Nothing
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub BtnConsultaAditorias_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultaAditorias.Click
        Try
            Consulta()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
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
            dtggeneral.Visible = True
            form.Controls.Add(dtggeneral)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True

            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=Registros de Auditorias.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Dim ValidaExcel As String
    Protected Sub BtnExporta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnExporta.Click
        Try
            If dtggeneral.Rows.Count < 1 Or TxtFechaInicio.Text = "" Or TxtFechaFin.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Realice una consulta antes de exportar a excel y no modifique los filtros que utilizo para realizar la consulta."
                Exit Sub
            End If
            ValidaExcel = "1"
            Consulta()
            If ValidaExcel = "2" Then
                Exit Sub
            End If
            crearexcel()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex
            Consulta()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Llenar_Observaciones()
        Dim DRLS() As String = {"drlManejo_Guion", "drlDisponibilidad_Atender_Llamada", "drlCordialidad_Comunicacion", "drlClaridad_Transmitir_Informacion", "drlContacto_Activo", "drlCorona_Abierta", "drlAmabilidad_Empatia", "drlFiltros_Eficiencia_Gestion", "drlInteres_Escuchar_Entender_Necesidades_Plantear_Soluciones", "drlEscucha_Activa", "drlDocumentacion_Sistema", "drlCuelgue_Llamada", "drlAplicacion_Manejo_Incompleto_Procedmientos_Tramites", "drlAplicacion_Manejo_Correcto_Procedimientos_Tramites", "drlResolucion_Necesidad_Cliente", "drlProcedimiento_PQR", "drlEscalamientos_Requeridos"}
        For i = 0 To DRLS.Length - 1
            Nom_DRL2 = DRLS(i)
            DRLS_SelectedIndexChanged(Nothing, Nothing)
        Next
        Nom_DRL2 = Nothing
    End Sub
    Dim Nom_DRL2 As String
    Protected Sub DRLS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlManejo_Guion.SelectedIndexChanged, drlDisponibilidad_Atender_Llamada.SelectedIndexChanged, drlCordialidad_Comunicacion.SelectedIndexChanged, drlClaridad_Transmitir_Informacion.SelectedIndexChanged, drlContacto_Activo.SelectedIndexChanged, drlCorona_Abierta.SelectedIndexChanged, drlAmabilidad_Empatia.SelectedIndexChanged, drlFiltros_Eficiencia_Gestion.SelectedIndexChanged, drlInteres_Escuchar_Entender_Necesidades_Plantear_Soluciones.SelectedIndexChanged, drlEscucha_Activa.SelectedIndexChanged, drlDocumentacion_Sistema.SelectedIndexChanged, drlCuelgue_Llamada.SelectedIndexChanged, drlAplicacion_Manejo_Incompleto_Procedmientos_Tramites.SelectedIndexChanged, drlAplicacion_Manejo_Correcto_Procedimientos_Tramites.SelectedIndexChanged, drlResolucion_Necesidad_Cliente.SelectedIndexChanged, drlProcedimiento_PQR.SelectedIndexChanged, drlEscalamientos_Requeridos.SelectedIndexChanged
        Try
            Dim Nom_DRL As DropDownList
            Nom_DRL = CType(sender, DropDownList)
            If Not Nom_DRL Is Nothing Then
                Nom_DRL2 = Nom_DRL.ID
            End If
            Select Case Nom_DRL2
                Case "drlManejo_Guion"
                    If drlManejo_Guion.SelectedIndex = 0 Then
                        TxtObs_Manejo_Guion.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Manejo_Guion.Enabled = False
                    Else
                        TxtObs_Manejo_Guion.Text = Nothing
                        TxtObs_Manejo_Guion.Enabled = True
                    End If
                Case "drlDisponibilidad_Atender_Llamada"
                    If drlDisponibilidad_Atender_Llamada.SelectedIndex = 0 Then
                        TxtObs_Disponibilidad_Atender_Llamada.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Disponibilidad_Atender_Llamada.Enabled = False
                    Else
                        TxtObs_Disponibilidad_Atender_Llamada.Text = Nothing
                        TxtObs_Disponibilidad_Atender_Llamada.Enabled = True
                    End If
                Case "drlCordialidad_Comunicacion"
                    If drlCordialidad_Comunicacion.SelectedIndex = 0 Then
                        TxtObs_Cordialidad_Comunicacion.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Cordialidad_Comunicacion.Enabled = False
                    Else
                        TxtObs_Cordialidad_Comunicacion.Text = Nothing
                        TxtObs_Cordialidad_Comunicacion.Enabled = True
                    End If
                Case "drlClaridad_Transmitir_Informacion"
                    If drlClaridad_Transmitir_Informacion.SelectedIndex = 0 Then
                        TxtObs_Claridad_Transmitir_Informacion.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Claridad_Transmitir_Informacion.Enabled = False
                    Else
                        TxtObs_Claridad_Transmitir_Informacion.Text = Nothing
                        TxtObs_Claridad_Transmitir_Informacion.Enabled = True
                    End If
                Case "drlContacto_Activo"
                    If drlContacto_Activo.SelectedIndex = 0 Then
                        TxtObs_Contacto_Activo.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Contacto_Activo.Enabled = False
                    Else
                        TxtObs_Contacto_Activo.Text = Nothing
                        TxtObs_Contacto_Activo.Enabled = True
                    End If
                Case "drlCorona_Abierta"
                    If drlCorona_Abierta.SelectedIndex = 0 Then
                        TxtObs_Corona_Abierta.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Corona_Abierta.Enabled = False
                    Else
                        TxtObs_Corona_Abierta.Text = Nothing
                        TxtObs_Corona_Abierta.Enabled = True
                    End If
                Case "drlAmabilidad_Empatia"
                    If drlAmabilidad_Empatia.SelectedIndex = 0 Then
                        TxtObs_Amabilidad_Empatia.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Amabilidad_Empatia.Enabled = False
                    Else
                        TxtObs_Amabilidad_Empatia.Text = Nothing
                        TxtObs_Amabilidad_Empatia.Enabled = True
                    End If
                Case "drlFiltros_Eficiencia_Gestion"
                    If drlFiltros_Eficiencia_Gestion.SelectedIndex = 0 Then
                        TxtObs_Filtros_Eficiencia_Gestion.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Filtros_Eficiencia_Gestion.Enabled = False
                    Else
                        TxtObs_Filtros_Eficiencia_Gestion.Text = Nothing
                        TxtObs_Filtros_Eficiencia_Gestion.Enabled = True
                    End If
                Case "drlInteres_Escuchar_Entender_Necesidades_Plantear_Soluciones"
                    If drlInteres_Escuchar_Entender_Necesidades_Plantear_Soluciones.SelectedIndex = 0 Then
                        TxtObs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones.Enabled = False
                    Else
                        TxtObs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones.Text = Nothing
                        TxtObs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones.Enabled = True
                    End If
                Case "drlEscucha_Activa"
                    If drlEscucha_Activa.SelectedIndex = 0 Then
                        TxtObs_Escucha_Activa.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Escucha_Activa.Enabled = False
                    Else
                        TxtObs_Escucha_Activa.Text = Nothing
                        TxtObs_Escucha_Activa.Enabled = True
                    End If
                Case "drlDocumentacion_Sistema"
                    If drlDocumentacion_Sistema.SelectedIndex = 0 Then
                        TxtObs_Documentacion_Sistema.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Documentacion_Sistema.Enabled = False
                    Else
                        TxtObs_Documentacion_Sistema.Text = Nothing
                        TxtObs_Documentacion_Sistema.Enabled = True
                    End If
                Case "drlCuelgue_Llamada"
                    If drlCuelgue_Llamada.SelectedIndex = 0 Then
                        TxtObs_Cuelgue_Llamada.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Cuelgue_Llamada.Enabled = False
                    Else
                        TxtObs_Cuelgue_Llamada.Text = Nothing
                        TxtObs_Cuelgue_Llamada.Enabled = True
                    End If
                Case "drlAplicacion_Manejo_Incompleto_Procedmientos_Tramites"
                    If drlAplicacion_Manejo_Incompleto_Procedmientos_Tramites.SelectedIndex = 0 Then
                        TxtObs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites.Enabled = False
                    Else
                        TxtObs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites.Text = Nothing
                        TxtObs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites.Enabled = True
                    End If
                Case "drlAplicacion_Manejo_Correcto_Procedimientos_Tramites"
                    If drlAplicacion_Manejo_Correcto_Procedimientos_Tramites.SelectedIndex = 0 Then
                        TxtObs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites.Enabled = False
                    Else
                        TxtObs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites.Text = Nothing
                        TxtObs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites.Enabled = True
                    End If
                Case "drlResolucion_Necesidad_Cliente"
                    If drlResolucion_Necesidad_Cliente.SelectedIndex = 0 Then
                        TxtObs_Resolucion_Necesidad_Cliente.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Resolucion_Necesidad_Cliente.Enabled = False
                    Else
                        TxtObs_Resolucion_Necesidad_Cliente.Text = Nothing
                        TxtObs_Resolucion_Necesidad_Cliente.Enabled = True
                    End If
                Case "drlProcedimiento_PQR"
                    If drlProcedimiento_PQR.SelectedIndex = 0 Then
                        TxtObs_Procedimiento_PQR.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Procedimiento_PQR.Enabled = False
                    Else
                        TxtObs_Procedimiento_PQR.Text = Nothing
                        TxtObs_Procedimiento_PQR.Enabled = True
                    End If
                Case "drlEscalamientos_Requeridos"
                    If drlEscalamientos_Requeridos.SelectedIndex = 0 Then
                        TxtObs_Escalamientos_Requeridos.Text = "Cumple con los parametros solicitados para la variable"
                        TxtObs_Escalamientos_Requeridos.Enabled = False
                    Else
                        TxtObs_Escalamientos_Requeridos.Text = Nothing
                        TxtObs_Escalamientos_Requeridos.Enabled = True
                    End If
            End Select
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class