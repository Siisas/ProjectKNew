Imports System.IO

Public Class Auditoria_Reg_V4
    Inherits System.Web.UI.Page
    Dim ObjCalidad As New clscalidad
    Dim ObjValidacion As New Cls_Gestion_Datos
    Public lista() As DropDownList
    Public Cajastexto() As TextBox
    Public Valores() As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing

            If Not IsPostBack Then
                Session("Formulario") = "Registro Auditoria V4"
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
    'Cargar drl
    Public Sub Cargar_drl()
        Try
            LblFecha.Text = FormatDateTime(Now, DateFormat.ShortDate)
            With drlProceso
                ObjCalidad.Validacion = "1"
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With drlEstado
                ObjCalidad.Validacion = "2"
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With drlTipo_Auditoria
                ObjCalidad.Validacion = "3"
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With drlCampaña_Consulta
                ObjCalidad.Validacion = "1"
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
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
            With Drl_Tipo_Cliente
                ObjCalidad.Validacion = "Tipos Clientes"
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Nombre"
                .DataValueField = "Cod_Calidad_Registro_Complemento"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
            With Drl_Tipo_PQR
                ObjCalidad.Validacion = "Tipos PQR"
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Nombre"
                .DataValueField = "Cod_Calidad_Registro_Complemento"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
        Catch ex As Exception
            Throw ex
            'Pnl_Message.CssClass = "alert alert-danger"
            'lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
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
    'Llenar campos
    Protected Sub Llenar_Observaciones()
        Try
            lista = {drldisponibilidad_Atender_Llamada, drlAmabilidad_lenguaje_apropiado, drlManejo_Tiempo, drlContacto_Activo, drlConcentracion_durante_llamada, drlProcedimientos_conocimientos, drlInteres_Escuchar_entender_plantear_soluciones, drlCuelgue_llamada, drlDocumentacion_sistema, drlFinalizacion_despedida_llamada}
            Cajastexto = {TxtObs_disponibilidad_Atender_Llamada, TxtObs_Amabilidad_lenguaje_apropiado, TxtObs_Manejo_Tiempo, TxtObs_Contacto_Activo, TxtObs_Concentracion_durante_llamada, TxtObs_Procedimientos_conocimientos, TxtObs_Interes_Escuchar_entender_plantear_soluciones, TxtObs_Cuelgue_llamada, TxtObs_Documentacion_sistema, TxtObs_Finalizacion_despedida_llamada}
            For i = 0 To lista.Length - 1
                lista(i).SelectedIndex = 0
                DRLS_SelectedIndexChanged(lista(i), EventArgs.Empty)
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'drl variables
    Protected Sub DRLS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drldisponibilidad_Atender_Llamada.SelectedIndexChanged, drlAmabilidad_lenguaje_apropiado.SelectedIndexChanged, drlManejo_Tiempo.SelectedIndexChanged, drlContacto_Activo.SelectedIndexChanged, drlConcentracion_durante_llamada.SelectedIndexChanged, drlProcedimientos_conocimientos.SelectedIndexChanged, drlInteres_Escuchar_entender_plantear_soluciones.SelectedIndexChanged, drlCuelgue_llamada.SelectedIndexChanged, drlDocumentacion_sistema.SelectedIndexChanged, drlFinalizacion_despedida_llamada.SelectedIndexChanged
        Try
            If lista Is Nothing Then
                lista = {drldisponibilidad_Atender_Llamada, drlAmabilidad_lenguaje_apropiado, drlManejo_Tiempo, drlContacto_Activo, drlConcentracion_durante_llamada, drlProcedimientos_conocimientos, drlInteres_Escuchar_entender_plantear_soluciones, drlCuelgue_llamada, drlDocumentacion_sistema, drlFinalizacion_despedida_llamada}
                Cajastexto = {TxtObs_disponibilidad_Atender_Llamada, TxtObs_Amabilidad_lenguaje_apropiado, TxtObs_Manejo_Tiempo, TxtObs_Contacto_Activo, TxtObs_Concentracion_durante_llamada, TxtObs_Procedimientos_conocimientos, TxtObs_Interes_Escuchar_entender_plantear_soluciones, TxtObs_Cuelgue_llamada, TxtObs_Documentacion_sistema, TxtObs_Finalizacion_despedida_llamada}
            End If
            Dim i As Int64
            Dim mensaje As String = "Cumple con los parametros solicitados para la variable"
            For i = 0 To lista.Length - 1
                If lista(i).Equals(sender) Then
                    If lista(i).SelectedIndex = 0 Then
                        Cajastexto(i).Text = mensaje
                        Cajastexto(i).Enabled = False
                    Else
                        Cajastexto(i).Text = Nothing
                        Cajastexto(i).Enabled = True
                    End If
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'btn validar
    Protected Sub BtnValidar_Click(sender As Object, e As EventArgs) Handles BtnValidar.Click
        Try
            ObjValidacion.Validar_Herramientas(txtcaso, "Numero de Consecutivo")
            ObjCalidad.caso = txtcaso.Text
            With drlNomAgente
                .DataSource = ObjCalidad.Consulta_Caso_Agente
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
            LblCampaña.Text = ObjCalidad.Campania
        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub
    'btn Consulta agente
    Protected Sub BtnConsultaAgente_Click(sender As Object, e As EventArgs) Handles BtnConsultaAgente.Click
        Try
            ObjValidacion.Validar_Herramientas(TxtConsultaCod_Agente, "Codigo Agente")
            ObjCalidad.caso = -1
            ObjCalidad.CodigoAgente = TxtConsultaCod_Agente.Text
            With drlNomAgente
                .DataSource = ObjCalidad.Consulta_Caso_Agente
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub
    'btn Guardar
    Protected Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            'Validacion
            ObjValidacion.Validar_Herramientas(txtcaso, "Caso")
            ObjValidacion.Validar_Herramientas(drlNomAgente, "Ingeniero")
            ObjValidacion.Validar_Herramientas(drlAuditor, "Auditor")
            ObjValidacion.Validar_Herramientas(drlProceso, "Proceso")
            ObjValidacion.Validar_Herramientas(Drl_Tipo_PQR, "Tipo PQR")
            ObjValidacion.Validar_Herramientas(Drl_Tipo_Cliente, "Tipo cliente")
            ObjValidacion.Validar_Herramientas(TxtFc_Llamada, "Fecha y Hora de llamada")
            ObjValidacion.Validar_Herramientas(TxtHora, "Tiempo Acumulado")
            ObjValidacion.Validar_Herramientas(TxtCantidad_Llamadas, "Cantidad de llamadas")
            ObjValidacion.Validar_Herramientas(drlEstado, "Estado caso")
            ObjValidacion.Validar_Herramientas(drlTipo_Auditoria, "Tipo Auditria")
            '----------------Atencion----------------------------
            ObjValidacion.Validar_Herramientas(TxtObs_disponibilidad_Atender_Llamada, "observacion de Disponibilidad para Atender la Llamada ")
            ObjValidacion.Validar_Herramientas(TxtObs_Amabilidad_lenguaje_apropiado, "observacion de Amabilidad y lenguaje apropiado")
            ObjValidacion.Validar_Herramientas(TxtObs_Manejo_Tiempo, "observacion de Manejo del Tiempo")
            ObjValidacion.Validar_Herramientas(TxtObs_Contacto_Activo, "observacion de Contacto Activo")
            '----------------Gestion------------------
            ObjValidacion.Validar_Herramientas(TxtObs_Concentracion_durante_llamada, "observacion de Concentración Durante la Llamada")
            ObjValidacion.Validar_Herramientas(TxtObs_Procedimientos_conocimientos, "observacion de Procedimientos y Conocimientos")
            '----------------SOLUCION---------------------
            ObjValidacion.Validar_Herramientas(TxtObs_Interes_Escuchar_entender_plantear_soluciones, "observacion de Interés en escuchar, entender sus necesidades y plantear soluciones")
            ObjValidacion.Validar_Herramientas(TxtObs_Cuelgue_llamada, "observacion de Cuelgue de Llamada")
            '----------------Cierre------------------------
            ObjValidacion.Validar_Herramientas(TxtObs_Documentacion_sistema, "observacion de Documentación en el Sistema")
            ObjValidacion.Validar_Herramientas(TxtObs_Finalizacion_despedida_llamada, "observacion de Finalización y despedida en la llamada")
            '----------------Estadistica-------------------
            ObjValidacion.Validar_Herramientas(DrlSolucion, "Solución")
            ObjValidacion.Validar_Herramientas(TxtObs_Solucion, "observacion de Solución")
            ObjValidacion.Validar_Herramientas(drlReporta_Inc, "Reporta Inconsistencia")
            ObjValidacion.Validar_Herramientas(DrlSatisfaccion, "Cliente Satisfecho")
            ObjValidacion.Validar_Herramientas(TxtObs_Generales, "OBSERVACIONES GENERALES")
            '------------------------------------------------------------------------------------------'
            '---------------------------------Captura de informacion-----------------------------------'
            '------------------------------------------------------------------------------------------'
            '---------------Informacion General-----------------
            ObjCalidad.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            ObjCalidad.caso = txtcaso.Text
            ObjCalidad.agente = drlNomAgente.SelectedValue
            ObjCalidad.Auditor = drlAuditor.Text
            ObjCalidad.Campania = LblCampaña.Text
            ObjCalidad.Proceso = drlProceso.Text
            ObjCalidad.Id_Tipo_PQR = Drl_Tipo_PQR.SelectedValue
            ObjCalidad.Id_Tipo_Cliente = Drl_Tipo_Cliente.SelectedValue
            ObjCalidad.Fc_Llamada = TxtFc_Llamada.Text
            ObjCalidad.Tiempo_Acum_Llamada = TxtHora.Text
            ObjCalidad.N_Llamadas_Min = TxtCantidad_Llamadas.Text
            ObjCalidad.Estado_Caso = drlEstado.Text
            ObjCalidad.Tipo_Auditoria = drlTipo_Auditoria.Text
            '--------------Atencion--------------
            ObjCalidad.Disponibilidad_Atender_Llamada = drldisponibilidad_Atender_Llamada.Text 'Peso 2
            ObjCalidad.Obs_disponibilidad_Atender_Llamada = TxtObs_disponibilidad_Atender_Llamada.Text
            ObjCalidad.Amabilidad_lenguaje_apropiado = drlAmabilidad_lenguaje_apropiado.Text
            ObjCalidad.Obs_Amabilidad_lenguaje_apropiado = TxtObs_Amabilidad_lenguaje_apropiado.Text
            ObjCalidad.Manejo_Tiempo = drlManejo_Tiempo.Text
            ObjCalidad.Obs_Manejo_Tiempo = TxtObs_Manejo_Tiempo.Text
            ObjCalidad.Contacto_Activo = drlContacto_Activo.Text 'Peso 2
            ObjCalidad.Obs_Contacto_Activo = TxtObs_Contacto_Activo.Text
            '--------------Gestion-----------------
            ObjCalidad.Concentracion_durante_llamada = drlConcentracion_durante_llamada.Text
            ObjCalidad.Obs_Concentracion_durante_llamada = TxtObs_Concentracion_durante_llamada.Text
            ObjCalidad.Procedimientos_conocimientos = drlProcedimientos_conocimientos.Text
            ObjCalidad.Obs_Procedimientos_conocimientos = TxtObs_Procedimientos_conocimientos.Text

            '--------------Solucion----------------
            ObjCalidad.Interes_escuchar = drlInteres_Escuchar_entender_plantear_soluciones.Text
            ObjCalidad.Obs_Interes_escuchar = TxtObs_Interes_Escuchar_entender_plantear_soluciones.Text
            ObjCalidad.Cuelgue_llamada = drlCuelgue_llamada.Text
            ObjCalidad.Obs_Cuelgue_llamada = TxtObs_Cuelgue_llamada.Text
            '--------------Cierre--------------------------
            ObjCalidad.Documentacion = drlDocumentacion_sistema.Text 'Peso 10
            ObjCalidad.Obs_Documentacion = TxtObs_Documentacion_sistema.Text
            ObjCalidad.Finalizacion_despedida_llamada = drlFinalizacion_despedida_llamada.Text
            ObjCalidad.Obs_Finalizacion_despedida_llamada = TxtObs_Finalizacion_despedida_llamada.Text

            '--------------Estadistica-----------------------
            ObjCalidad.Solucion = DrlSolucion.SelectedItem.Text
            ObjCalidad.Obs_Solucion = TxtObs_Solucion.Text
            ObjCalidad.Reporta_Inc = drlReporta_Inc.Text
            ObjCalidad.satisfaccion = DrlSatisfaccion.Text
            ObjCalidad.Obs_General = TxtObs_Generales.Text

            lista = {drldisponibilidad_Atender_Llamada, drlAmabilidad_lenguaje_apropiado, drlManejo_Tiempo, drlContacto_Activo, drlConcentracion_durante_llamada, drlProcedimientos_conocimientos, drlInteres_Escuchar_entender_plantear_soluciones, drlCuelgue_llamada, drlDocumentacion_sistema, drlFinalizacion_despedida_llamada}
            Valores = {3, 10, 5, 9, 5, 22, 21, 10, 10, 5}
            Dim acumulado As Integer
            '---------Calificaciones--------------
            For i = 0 To lista.Length - 1
                If lista(i).SelectedIndex = 0 Then
                    acumulado = acumulado + Valores(i)
                End If
                If i = 3 Then
                    ObjCalidad.Total_Atencion = acumulado
                    acumulado = 0
                ElseIf i = 5 Then
                    ObjCalidad.Total_Gestion = acumulado
                    acumulado = 0
                ElseIf i = 7 Then
                    ObjCalidad.Total_Solucion = acumulado
                    acumulado = 0
                ElseIf i = 9 Then
                    ObjCalidad.Total_Cierre = acumulado
                    acumulado = 0
                End If
            Next
            ObjCalidad.Registro_Auditoria_Calidad_V4()
            If ObjCalidad.idreg <> Nothing Then
                mostrar_Mensaje("Registro realizado con el codigo: " & ObjCalidad.idreg, "Correcto")
            Else
                Throw New Exception("Auditoria no registrada, por favor validar")
            End If
            Llenar_Observaciones()
            Limpiar_Herramientas()

        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub
    'Metodo Limpiar herramientas
    Protected Sub Limpiar_Herramientas()
        Try
            txtcaso.Text = ""
            drlNomAgente.Items.Clear()
            LblCampaña.Text = ""
            drlProceso.SelectedIndex = 0
            Drl_Tipo_PQR.SelectedIndex = 0
            Drl_Tipo_Cliente.SelectedIndex = 0
            TxtFc_Llamada.Text = ""
            TxtHora.Text = ""
            TxtCantidad_Llamadas.Text = ""
            drlEstado.SelectedIndex = 0
            drlTipo_Auditoria.SelectedIndex = 0
            DrlSolucion.SelectedIndex = 0
            TxtObs_Solucion.Text = ""
            drlReporta_Inc.SelectedIndex = 0
            DrlSatisfaccion.SelectedIndex = 0
            TxtObs_Generales.Text = ""
            TxtConsultaCod_Agente.Text = ""
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'btn Consulta
    Protected Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        Try
            ObjValidacion.Validar_Herramientas(TxtCod_Consulta, "Id de auditoria")
            ObjCalidad.Cod_Calidad_Registro = TxtCod_Consulta.Text
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
                Visibilidad_herramientas()
            Else
                mostrar_Mensaje("No se encontraron registros con el codigo: " + TxtCod_Consulta.Text, "Informacion")
            End If

        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub
    'metodo Ocultar herramientas
    Protected Sub Visibilidad_herramientas()
        Try
            PanelGeneral.Visible = False
            PanelConsulta.Visible = False
            Panel1.Visible = True
            Dim tx As TextBox
            Dim drl As DropDownList
            Dim btn As Button
            For Each control In Panel_registro2.Controls
                If TypeOf control Is TextBox Then
                    tx = control
                    tx.Visible = False
                End If
                If TypeOf control Is DropDownList Then
                    drl = control
                    drl.Visible = False
                End If
                If TypeOf control Is Button Then
                    btn = control
                    btn.Visible = False
                End If
            Next
            drlAuditorNombre.Visible = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'Btn Consulta auditoria
    Protected Sub BtnConsultaAditorias_Click(sender As Object, e As EventArgs) Handles BtnConsultaAditorias.Click
        Try
            ObjValidacion.Validar_Herramientas(TxtFechaInicio, "Fecha Inicio")
            ObjValidacion.Validar_Herramientas(TxtFechaFin, "Fecha Fin")

            If Date.Parse(TxtFechaInicio.Text) > Date.Parse(TxtFechaFin.Text) Then
                mostrar_Mensaje("verifique que Fecha Inicio sea menor a Fecha Fin", "Advertencia")
                Exit Sub
            End If
            If TxtCod_Agente.Text <> Nothing Then
                ObjCalidad.CodigoAgente = TxtCod_Agente.Text
            End If
            If drlCampaña_Consulta.SelectedIndex <> 0 Then
                ObjCalidad.Campania = drlCampaña_Consulta.SelectedItem.Text
            End If
            ObjCalidad.fcini = TxtFechaInicio.Text
            ObjCalidad.fcfin = TxtFechaFin.Text
            Session("dtggeneral_Calidad_Registro_v4") = ObjCalidad.Consulta_Auditorias_Agente_V4
            dtggeneral.DataSource = Session("dtggeneral_Calidad_Registro_v4")
            dtggeneral.DataBind()
            If ObjCalidad.cantidad > 0 Then
                LblCantidad.Text = "Registros encontrados: " & ObjCalidad.cantidad
                BtnExporta.Visible = True
            Else
                LblCantidad.Text = "Registros encontrados: 0"
                mostrar_Mensaje("No se encontraron registros", "Informacion")
                dtggeneral.DataSource = Nothing
                dtggeneral.DataBind()
                BtnExporta.Visible = True
            End If


        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub
    'Btn Exportar
    Protected Sub BtnExporta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnExporta.Click
        Try
            If dtggeneral.Rows.Count < 1 Then
                mostrar_Mensaje("Realice una consulta antes de exportar a excel y no modifique los filtros que utilizo para realizar la consulta.", "Advertencia")
                Exit Sub
            End If
            crearexcel()
        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub
    'Metodo Esportar
    Sub crearexcel()
        Try
            Dim sw As New StringWriter()
            Dim hw As New HtmlTextWriter(sw)
            Dim tabla As New Table()
            Dim tr1 As New TableRow()
            Dim cell1 As New TableCell()
            Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"
            If dtggeneral.Rows.Count() > 0 Then
                cell1.Controls.Add(dtggeneral)
                tr1.Cells.Add(cell1)
                tabla.Rows.Add(tr1)
                tabla.RenderControl(hw)
                Response.Clear()
                Response.Buffer = True
                Response.AddHeader("Content-Disposition", "attachment;filename=Auditoria_Registro.xls")
                Response.Charset = "UTF-8"
                Response.ContentType = "application/vnd.ms-excel"
                Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                Response.Write(style)
                Response.Output.Write(sw.ToString())
                Response.Flush()
                Response.End()
            Else
                mostrar_Mensaje("Primero haga una consulta e intente Exportarla!", "Advertencia")
            End If

        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub
    'Cambia color
    Protected Sub dtggeneral_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles dtggeneral.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                e.Row.Cells(17).BackColor = Drawing.Color.FromArgb(212, 222, 160)
                e.Row.Cells(17).Font.Size = 10
                e.Row.Cells(18).BackColor = Drawing.Color.FromArgb(212, 222, 160)
                e.Row.Cells(18).Font.Size = 10
                e.Row.Cells(19).BackColor = Drawing.Color.FromArgb(212, 222, 160)
                e.Row.Cells(19).Font.Size = 10
                e.Row.Cells(20).BackColor = Drawing.Color.FromArgb(212, 222, 160)
                e.Row.Cells(20).Font.Size = 10
                e.Row.Cells(21).ForeColor = Drawing.Color.White
                e.Row.Cells(21).BackColor = Drawing.Color.FromArgb(179, 197, 86)
                e.Row.Cells(21).Font.Size = 10
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
End Class