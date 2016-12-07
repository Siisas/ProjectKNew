Public Class Auditoria_Con_V2
    Inherits System.Web.UI.Page
    Dim ObjCalidad As New clscalidad

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                Cargue_Auditorias()
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

    Public Sub Cargue_Auditorias()
        Try
            ObjCalidad.Id_Usuario = lblusuario.Text
            dtggeneral.DataSource = ObjCalidad.Consulta_Auditorias_Agente
            dtggeneral.DataBind()
            LblCuenta.Text = ObjCalidad.cantidad
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
                ObjCalidad.Validacion = "1"
                ObjCalidad.Id_Usuario = lblusuario.Text
                dts = ObjCalidad.Llenar_TextBox()

                If dts.Tables(0).Rows.Count > 0 Then
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
                    LblReincide.Text = ObjCalidad.Reincide
                    LblObs_Reincide.Text = ObjCalidad.obs_Reincide
                    LblSolucion.Text = ObjCalidad.Solucion
                    LblObs_Solucion.Text = ObjCalidad.Obs_Solucion
                    LblInteres_Escucha.Text = ObjCalidad.Interes_escuchar
                    LblObs_Interes_Escucha.Text = ObjCalidad.Obs_Interes_escuchar
                    LblObs_Generales.Text = ObjCalidad.Obs_General
                    lblmsg.Text = ""
                Else
                    lblmsg.Text = "No se encontraron registros con el codigo: " + TxtCod_Consulta.Text
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
                    LblAmabilidad_Empatia.Text = ""
                    LblRealiza_Filtro_A.Text = ""
                    LblObs_Amabilidad_Empatia.Text = ""
                    LblColgada_Llamada.Text = ""
                    LblObs_Colgada_Llamada.Text = ""
                    LblObs_Realiza_Filtro_A.Text = ""
                    LblCorona_Abierta.Text = ""
                    LblObs_Corona_Abierta.Text = ""
                    LblDocumentacion.Text = ""
                    LblObs_Documentacion.Text = ""
                    LblProcedimiento_PQR.Text = ""
                    LblObs_Procedimiento_PQR.Text = ""
                    LblProcedimiento_Prueb_Tram_Incom_Incorrec.Text = ""
                    LblObs_Procedimiento_Prueb_Tram_Incom_Incorrec.Text = ""
                    LblPresenta_Obj_Llamada.Text = ""
                    LblObs_Presenta_Obj_Llamada.Text = ""
                    LblCordialidad_Comunicacion.Text = ""
                    LblObs_Cordialidad_Comunicacion.Text = ""
                    LblCordialidad.Text = ""
                    LblObs_Cordialidad.Text = ""
                    LblContacto_Activo.Text = ""
                    LblObs_Contacto_Activo.Text = ""
                    LblClaridad_Transmitir_Inf.Text = ""
                    LblObs_Claridad_Transmitir_Inf.Text = ""
                    LblSeguridad.Text = ""
                    LblObs_Seguridad.Text = ""
                    LblUtiliza_Guion_Saludo_Nom.Text = ""
                    LblObs_Utiliza_Guion_Saludo_Nom.Text = ""
                    LblGestion_Llamada.Text = ""
                    LblObs_Gestion_Llamada.Text = ""
                    LblGestion_Soporte.Text = ""
                    LblObs_Gestion_Soporte.Text = ""
                    LblGestion_Asignacion.Text = ""
                    LblObs_Gestion_Asignacion.Text = ""
                    LblGestion_Cierre.Text = ""
                    LblReincide.Text = ""
                    LblObs_Reincide.Text = ""
                    LblObs_Gestion_Cierre.Text = ""
                    LblSolucion.Text = ""
                    LblObs_Solucion.Text = ""
                    LblInteres_Escucha.Text = ""
                    LblObs_Interes_Escucha.Text = ""
                    LblObs_Generales.Text = ""
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex
            Cargue_Auditorias()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
End Class