Public Class CalibracionSala
    Inherits System.Web.UI.Page
    Dim ObjCalibracion As New clscalidad
    Dim Validacion As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                objdatos.idusuario = lblusuario.Text
                objdatos.consultared()
                LblPermiso.Text = objdatos.mun
                If LblPermiso.Text = "CA" Then
                    BtnCreaSesion.Visible = True
                    BtnCerrarSesion.Visible = True
                    PanelSesionAdmin.Visible = True
                    LblSesionAU.Text = "Administrador"
                    dtgCasos.Columns(8).Visible = True
                    dtgCasosVoz.Columns(8).Visible = True
                Else
                    BtnCreaSesion.Visible = False
                    BtnCerrarSesion.Visible = False
                    PanelSesionAdmin.Visible = False
                    LblSesionAU.Text = "Usuario"
                    dtgCasos.Columns(8).Visible = False
                    dtgCasosVoz.Columns(8).Visible = False
                End If
                Actualiza_Dtg_Sala()
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

    Protected Sub CuentaregistrosCalibracion()
        Try
            Dim dt As New DataTable
            Dim dr As DataRow
            Try
                If Me.ViewState("Tabla_CalibracionCasos") Is Nothing Then
                    dt.Columns.Add(New DataColumn("N_Registro", GetType(String)))
                Else
                    dt = Me.ViewState("Tabla_CalibracionCasos")
                End If
                If dtgCasos.Rows.Count > 0 Then
                    For contador As Integer = 0 To ((dtgCasos.Rows.Count) - 1)
                        ObjCalibracion.Id_Caso = dtgCasos.Rows(contador).Cells(0).Text
                        ObjCalibracion.agente = dtgCasos.Rows(contador).Cells(2).Text
                        ObjCalibracion.grupo = dtgCasos.Rows(contador).Cells(3).Text
                        ObjCalibracion.Campania = dtgCasos.Rows(contador).Cells(4).Text
                        ObjCalibracion.Validacion = "4"
                        ObjCalibracion.ConsultaCasosSesion()
                        dr = dt.NewRow()
                        dr("N_Registro") = ObjCalibracion.cantidad
                        dt.Rows.Add(dr)
                        dtgCasos.Rows(contador).Cells(5).Text = dt.Rows(contador).Item(0).ToString
                    Next
                End If
                If dtgCasosVoz.Rows.Count > 0 Then
                    For contador As Integer = 0 To ((dtgCasosVoz.Rows.Count) - 1)
                        ObjCalibracion.Id_Caso = dtgCasosVoz.Rows(contador).Cells(0).Text
                        ObjCalibracion.agente = dtgCasosVoz.Rows(contador).Cells(2).Text
                        ObjCalibracion.grupo = dtgCasosVoz.Rows(contador).Cells(3).Text
                        ObjCalibracion.Campania = dtgCasosVoz.Rows(contador).Cells(4).Text
                        ObjCalibracion.Validacion = "4"
                        ObjCalibracion.ConsultaCasosSesion()
                        dr = dt.NewRow()
                        dr("N_Registro") = ObjCalibracion.cantidad
                        dt.Rows.Add(dr)
                        dtgCasosVoz.Rows(contador).Cells(5).Text = dt.Rows(contador).Item(0).ToString
                    Next
                End If
            Catch ex As Exception
                lblmsg.Text = "Se produjo error " & ex.Message
            End Try
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Actualiza_Dtg_Sala()
        Try
            ObjCalibracion.Fc_Creacion = Nothing

            ''''''''''''''' Cargue Primera parte '''''''''''''''
            ObjCalibracion.Validacion = "1"
            ObjCalibracion.Id_Usuario = lblusuario.Text
            dtgSesionCalibracion.DataSource = ObjCalibracion.ConsultaSesionCalidadParte1()
            dtgSesionCalibracion.DataBind()
            ObjCalibracion.Validacion = "2"
            'ObjCalidad.Id_Usuario = lblusuario.Text
            dtgInvitacion.DataSource = ObjCalibracion.ConsultaSesionCalidadParte1()
            dtgInvitacion.DataBind()
            ObjCalibracion.Validacion = "3"
            dtgTodasSesionesCalibracion.DataSource = ObjCalibracion.ConsultaSesionCalidadParte1()
            dtgTodasSesionesCalibracion.DataBind()

            ''''''''''''''' Cargue Despues de crear secion o despues de seleccionar una '''''''''''''''
            If LblCodigoSesion.Text <> "" Then
                ObjCalibracion.Validacion = "1"
                ObjCalibracion.Fk_Cod_CalibracionSesion = LblCodigoSesion.Text
                dtgIntegrantesSesion.DataSource = ObjCalibracion.ConsultaSesionCalidadParte2()
                dtgIntegrantesSesion.DataBind()


                ObjCalibracion.Validacion = "2"
                ObjCalibracion.Fk_Cod_CalibracionSesion = LblCodigoSesion.Text
                dtgCasos.DataSource = ObjCalibracion.ConsultaCasosSesion()
                dtgCasos.DataBind()
                ObjCalibracion.Validacion = "3"
                ObjCalibracion.Fk_Cod_CalibracionSesion = LblCodigoSesion.Text
                dtgCasosVoz.DataSource = ObjCalibracion.ConsultaCasosSesion()
                dtgCasosVoz.DataBind()

                ''Cuenta Registros realizados al caso de la calibracion
                CuentaregistrosCalibracion()
            End If


        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnCreaSesion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCreaSesion.Click
        Try
            PanelSalaCalibracion.Visible = False
            PanelSesion.Visible = True
            dtgCasos.DataSource = Nothing
            dtgCasos.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnUnirse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnUnirse.Click
        Try
            If TxtUnirSesion.Text = "" Then
                lblmsg.Text = "Ingrese un id o caso para unirse a una sesión"
                Exit Sub
            End If

            ObjCalibracion.Administrador = lblusuario.Text
            ObjCalibracion.Cod_CalibracionSesion = TxtUnirSesion.Text

            ''Consulta antes de agregar en sesion ya esta incluido
            ObjCalibracion.Validacion = "1"
            If ObjCalibracion.ConsultaAntesDeIncluir().Tables(0).Rows.Count > 0 Then
                lblmsg.Text = "Usted ya se encuentra incluido en esta sesion: " + TxtUnirSesion.Text
                Exit Sub
            End If
            ObjCalibracion.Validacion = "2"
            ''Consulta antes de agregar en sesion, sesion cerrada
            If ObjCalibracion.ConsultaAntesDeIncluir().Tables(0).Rows.Count < 1 Then
                lblmsg.Text = "La sesion " + TxtUnirSesion.Text + " ya fue cerrada por lo cual no puede ser incluido"
                Exit Sub
            End If

            ''Incluye en la Sesión
            ObjCalibracion.IncluirEnSesion()
            lblmsg.Text = "Se a incluido en la sesion :" + TxtUnirSesion.Text


            Actualiza_Dtg_Sala()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnVolver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnVolver.Click
        Try
            PanelSalaCalibracion.Visible = True
            PanelSesion.Visible = False
            LblCodigoSesion.Text = ""
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnVolver1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnVolver1.Click
        Try
            PanelSesion.Visible = True
            PanelRegistroCalibracion.Visible = False
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnGuardaAdicion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGuardaAdicion.Click
        Try
            If TxtCaso.Text = "" Then
                lblmsg.Text = "Ingrese un caso"
                Exit Sub
            End If
            If TxtNombre.Text = "" Then
                lblmsg.Text = "Ingrese un nombre"
                Exit Sub
            End If
            If TxtGrupo.Text = "" Then
                lblmsg.Text = "Ingrese un grupo"
                Exit Sub
            End If
            If TxtCampania.Text = "" Then
                lblmsg.Text = "Ingrese una campaña"
                Exit Sub
            End If

            If LblCodigoSesion.Text = "" Or LblCodigoSesion.Text = Nothing Then
                ''Crea Sesión
                ObjCalibracion.Administrador = lblusuario.Text
                ObjCalibracion.CrearSesion()
                ''Consulta Codigo de Sesión
                ObjCalibracion.ConsultaSesionCalidadParte1()
                LblCodigoSesion.Text = ObjCalibracion.Cod_CalibracionSesion
                ''Incluye en la Sesión
                ObjCalibracion.Cod_CalibracionSesion = LblCodigoSesion.Text
                ObjCalibracion.IncluirEnSesion()

                lblmsg.Text = "Sesión creada"
            End If

            ObjCalibracion.Id_Usuario = lblusuario.Text
            ObjCalibracion.caso = TxtCaso.Text
            ObjCalibracion.Nombre = TxtNombre.Text
            ObjCalibracion.grupo = TxtGrupo.Text
            ObjCalibracion.Campania = TxtCampania.Text
            ObjCalibracion.Fk_Cod_CalibracionSesion = LblCodigoSesion.Text
            ObjCalibracion.AgregaCasos()




            TxtCaso.Text = ""
            TxtNombre.Text = ""

            Actualiza_Dtg_Sala()

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnCerrarSesion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCerrarSesion.Click
        Try
            If LblCodigoSesion.Text = "" Or LblCodigoSesion.Text = Nothing Then
                lblmsg.Text = "Para realizar el cierre de sesión debe tener cargado un id"
                Exit Sub
            End If

            ObjCalibracion.Cod_CalibracionSesion = LblCodigoSesion.Text
            ObjCalibracion.CerrarSesion()

            lblmsg.Text = "Sesión Cerrada"

            Actualiza_Dtg_Sala()

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub dtgTodasSesionesCalibracion_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtgTodasSesionesCalibracion.RowCommand
        Try
            'Mediante este codigo envio la identificacion, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Estado" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                ObjCalibracion.Fc_Creacion = dtgTodasSesionesCalibracion.Rows(index).Cells(1).Text
                ObjCalibracion.Administrador = dtgTodasSesionesCalibracion.Rows(index).Cells(3).Text

                ObjCalibracion.ConsultaSesionCalidadParte1()
                LblCodigoSesion.Text = ObjCalibracion.Cod_CalibracionSesion

                Actualiza_Dtg_Sala()

            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnGuardaVincular_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGuardaVincular.Click
        Try
            If LblCodigoSesion.Text = "" Then
                lblmsg.Text = "Vuelva a ingresar a la sala ya que no se a cargado ningun ID"
                Exit Sub
            End If
            If TxtCodigo.Text = "" Then
                lblmsg.Text = "Ingrese el codigo del usuario que desea vincular"
                Exit Sub
            End If
            ObjCalibracion.CodigoAgente = TxtCodigo.Text
            ObjCalibracion.ConsultaCodigoAgenteSesion()

            If ObjCalibracion.Id_Usuario = "" Then
                lblmsg.Text = "Verifique el codigo de la persona a la que le desea enviar la invitacion ya que no se encuntran en la base de datos: " + TxtCodigo.Text
                Exit Sub
            End If

            ObjCalibracion.Administrador = lblusuario.Text
            ObjCalibracion.Id_Usuario = ObjCalibracion.Id_Usuario
            ObjCalibracion.Fk_Cod_CalibracionSesion = LblCodigoSesion.Text
            ObjCalibracion.EnviarInvitacion()

            lblmsg.Text = "Invitacion realizada"

            Actualiza_Dtg_Sala()

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnActualizarSesion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnActualizarSesion.Click
        Try
            Actualiza_Dtg_Sala()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub dtgSesionCalibracion_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtgSesionCalibracion.RowCommand
        Try
            'Mediante este codigo envio la identificacion, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Ver" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                LblCodigoSesion.Text = dtgSesionCalibracion.Rows(index).Cells(0).Text
                Actualiza_Dtg_Sala()
                PanelSalaCalibracion.Visible = False
                PanelSesion.Visible = True
                If dtgSesionCalibracion.Rows(index).Cells(3).Text = lblusuario.Text Then
                    BtnCerrarSesion.Visible = True
                    PanelSesionAdmin.Visible = True
                    LblSesionAU.Text = "Administrador"
                    dtgCasos.Columns(8).Visible = True
                    dtgCasosVoz.Columns(8).Visible = True
                Else
                    BtnCerrarSesion.Visible = False
                    PanelSesionAdmin.Visible = False
                    LblSesionAU.Text = "Usuario"
                    dtgCasos.Columns(8).Visible = False
                    dtgCasosVoz.Columns(8).Visible = False
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub dtgInvitacion_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtgInvitacion.RowCommand
        Try
            'Mediante este codigo envio el id, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "RespuestaAceptar" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                ''Update Invitacion
                ObjCalibracion.Cod_CalibracionSesionInvita = dtgInvitacion.Rows(index).Cells(0).Text
                ObjCalibracion.Respuesta = "Acepta"
                ObjCalibracion.ActualizaInvitacion()


                ''Registro Inclucion Calibracion
                dtgInvitacion.Rows(index).Cells(4).Visible = True
                ObjCalibracion.Cod_CalibracionSesion = dtgInvitacion.Rows(index).Cells(4).Text
                ObjCalibracion.Administrador = lblusuario.Text
                ObjCalibracion.IncluirEnSesion()
            End If

            'Mediante este codigo envio el id, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "RespuestaRechazar" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                ''Update Invitacion
                ObjCalibracion.Cod_CalibracionSesionInvita = dtgInvitacion.Rows(index).Cells(0).Text
                ObjCalibracion.Respuesta = "Rechaza"
                ObjCalibracion.ActualizaInvitacion()
            End If
            Actualiza_Dtg_Sala()
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Try
            If drlAmabilidad_Empatia.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para la amabilidad y empatia"
                Exit Sub
            End If
            If drlColgada_Llamada.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para colgada de llamada"
                Exit Sub
            End If
            If drlRealiza_Filtro_A.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para filtros adecuados"
                Exit Sub
            End If
            If drlCorona_Abierta.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para corona abierta"
                Exit Sub
            End If
            If drlDocumentacion.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para documentacion"
                Exit Sub
            End If
            If drlProcedimiento_PQR.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para procedimiento PQR"
                Exit Sub
            End If
            If drlProcedimiento_Prueb_Tram_Incom_Incorrec.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para Procedimiento, Pruebas, Tramites incompletos o incorrectos"
                Exit Sub
            End If
            If drlPresenta_Obj_Llamada.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para el objetivo de la llamada"
                Exit Sub
            End If
            If drlCordialidad_Comunicacion.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para cordialidad y comunicacion"
                Exit Sub
            End If
            If drlClaridad_Transmitir_Inf.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para claridad al transmitir la informacion"
                Exit Sub
            End If
            If drlSeguridad.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para seguridad"
                Exit Sub
            End If
            If drlUtiliza_Guion_Saludo_Nom.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para guion de saludo"
                Exit Sub
            End If
            If drlGestion_Llamada.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para la gestion de la llamada"
                Exit Sub
            End If
            If drlGestion_Soporte.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para la gestion el soporte"
                Exit Sub
            End If
            If drlGestion_Asignacion.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para la gestion de asignacion"
                Exit Sub
            End If
            If drlGestion_Cierre.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una calificacion para la gestion de cierre"
                Exit Sub
            End If
            If DrlReincide.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opcion para reincide"
                Exit Sub
            End If
            If drlSolucion.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opcion de solucion"
                Exit Sub
            End If
            If drlInteres_Escucha.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opcion para Interes en escuchar"
                Exit Sub
            End If

            ObjCalibracion.Id_Usuario = lblusuario.Text
            ObjCalibracion.caso = Lblcaso.Text
            ObjCalibracion.agente = LblNomAgente.Text
            ObjCalibracion.grupo = LblGrupo.Text
            ObjCalibracion.Auditor = LblAuditor.Text
            ObjCalibracion.Campania = LblCampaña.Text
            ObjCalibracion.Amabilidad_Empatia = drlAmabilidad_Empatia.Text
            ObjCalibracion.Obs_Amabilidad_Empatia = TxtObs_Amabilidad_Empatia.Text
            ObjCalibracion.Colgada_Llamada = drlColgada_Llamada.Text
            ObjCalibracion.Obs_Colgada_Llamada = TxtObs_Colgada_Llamada.Text
            ObjCalibracion.Real_filtros_adecuados = drlRealiza_Filtro_A.Text
            ObjCalibracion.Obs_Real_filtros_adecuados = TxtObs_Realiza_Filtro_A.Text
            ObjCalibracion.Corona_Abierta = drlCorona_Abierta.Text
            ObjCalibracion.Obs_Corona_Abierta = TxtObs_Corona_Abierta.Text
            ObjCalibracion.Documentacion = drlDocumentacion.Text
            ObjCalibracion.Obs_Documentacion = TxtObs_Documentacion.Text
            ObjCalibracion.Procedimiento_PQR = drlProcedimiento_PQR.Text
            ObjCalibracion.Obs_Procedimiento_PQR = TxtObs_Procedimiento_PQR.Text
            ObjCalibracion.Procedimiento_prueba_tramite_incompleto_incorrecto = drlProcedimiento_Prueb_Tram_Incom_Incorrec.Text
            ObjCalibracion.Obs_Procedimiento_prueba_tramite_incompleto_incorrecto = TxtObs_Procedimiento_Prueb_Tram_Incom_Incorrec.Text
            ObjCalibracion.Presenta_objetivo_llamada = drlPresenta_Obj_Llamada.Text
            ObjCalibracion.Obs_Presenta_objetivo_llamada = TxtObs_Presenta_Obj_Llamada.Text
            ObjCalibracion.Cordialidad_Comunicacion = drlCordialidad_Comunicacion.Text
            ObjCalibracion.Obs_Cordialidad_Comunicacion = TxtObs_Cordialidad_Comunicacion.Text
            ObjCalibracion.Claridad_transmitir_informacion = drlClaridad_Transmitir_Inf.Text
            ObjCalibracion.Obs_Claridad_transmitir_informacion = TxtObs_Claridad_Transmitir_Inf.Text
            ObjCalibracion.Seguridad = drlSeguridad.Text
            ObjCalibracion.Obs_Seguridad = TxtObs_Seguridad.Text
            ObjCalibracion.Util_guion_saludo = drlUtiliza_Guion_Saludo_Nom.Text
            ObjCalibracion.Obs_Util_guion_saludo = TxtObs_Utiliza_Guion_Saludo_Nom.Text
            ObjCalibracion.Gestion_Llamada = drlGestion_Llamada.Text
            ObjCalibracion.Obs_Gestion_Llamada = TxtObs_Gestion_Llamada.Text
            ObjCalibracion.Gestion_Soporte = drlGestion_Soporte.Text
            ObjCalibracion.Obs_Gestion_Soporte = TxtObs_Gestion_Soporte.Text
            ObjCalibracion.Gestion_Asignacion = drlGestion_Asignacion.Text
            ObjCalibracion.Obs_Gestion_Asignacion = TxtObs_Gestion_Asignacion.Text
            ObjCalibracion.Gestion_Cierre = drlGestion_Cierre.Text
            ObjCalibracion.Obs_Gestion_Cierre = TxtObs_Gestion_Cierre.Text
            ObjCalibracion.Solucion = drlSolucion.Text
            ObjCalibracion.Obs_Solucion = TxtObs_Solucion.Text
            ObjCalibracion.Interes_escuchar = drlInteres_Escucha.Text
            ObjCalibracion.Obs_Interes_escuchar = TxtObs_Interes_Escucha.Text
            ObjCalibracion.Obs_General = TxtObs_Generales.Text
            ObjCalibracion.Reincide = DrlReincide.SelectedItem.Text
            ObjCalibracion.obs_Reincide = TxtObsReincide.Text

            ObjCalibracion.Registro_Calibracion()

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
            DrlReincide.Text = ""
            TxtObsReincide.Text = ""
            lblmsg.Text = "Registro de calibracion realizado correctamente"
            PanelRegistroCalibracion.Visible = False
            PanelSesion.Visible = True
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub Consulta_Calibracion()
        Try
            If ObjCalibracion.Consulta_Calibracion().Tables(0).Rows.Count > 0 Then
                Lblcaso.Text = ObjCalibracion.caso
                LblNomAgente.Text = ObjCalibracion.agente
                LblGrupo.Text = ObjCalibracion.grupo
                LblAuditor.Text = ObjCalibracion.Auditor
                LblCampaña.Text = ObjCalibracion.Campania
                LblAmabilidad_Empatia.Text = ObjCalibracion.Amabilidad_Empatia
                LblRealiza_Filtro_A.Text = ObjCalibracion.Real_filtros_adecuados
                LblObs_Amabilidad_Empatia.Text = ObjCalibracion.Obs_Amabilidad_Empatia
                LblColgada_Llamada.Text = ObjCalibracion.Colgada_Llamada
                LblObs_Colgada_Llamada.Text = ObjCalibracion.Obs_Colgada_Llamada
                LblObs_Realiza_Filtro_A.Text = ObjCalibracion.Obs_Real_filtros_adecuados
                LblCorona_Abierta.Text = ObjCalibracion.Corona_Abierta
                LblObs_Corona_Abierta.Text = ObjCalibracion.Obs_Corona_Abierta
                LblDocumentacion.Text = ObjCalibracion.Documentacion
                LblObs_Documentacion.Text = ObjCalibracion.Obs_Documentacion
                LblProcedimiento_PQR.Text = ObjCalibracion.Procedimiento_PQR
                LblObs_Procedimiento_PQR.Text = ObjCalibracion.Obs_Procedimiento_PQR
                LblProcedimiento_Prueb_Tram_Incom_Incorrec.Text = ObjCalibracion.Procedimiento_prueba_tramite_incompleto_incorrecto
                LblObs_Procedimiento_Prueb_Tram_Incom_Incorrec.Text = ObjCalibracion.Obs_Procedimiento_prueba_tramite_incompleto_incorrecto
                LblPresenta_Obj_Llamada.Text = ObjCalibracion.Presenta_objetivo_llamada
                LblObs_Presenta_Obj_Llamada.Text = ObjCalibracion.Obs_Presenta_objetivo_llamada
                LblCordialidad_Comunicacion.Text = ObjCalibracion.Cordialidad_Comunicacion
                LblObs_Cordialidad_Comunicacion.Text = ObjCalibracion.Obs_Cordialidad_Comunicacion
                LblClaridad_Transmitir_Inf.Text = ObjCalibracion.Claridad_transmitir_informacion
                LblObs_Claridad_Transmitir_Inf.Text = ObjCalibracion.Obs_Claridad_transmitir_informacion
                LblSeguridad.Text = ObjCalibracion.Seguridad
                LblObs_Seguridad.Text = ObjCalibracion.Obs_Seguridad
                LblUtiliza_Guion_Saludo_Nom.Text = ObjCalibracion.Util_guion_saludo
                LblObs_Utiliza_Guion_Saludo_Nom.Text = ObjCalibracion.Obs_Util_guion_saludo
                LblGestion_Llamada.Text = ObjCalibracion.Gestion_Llamada
                LblObs_Gestion_Llamada.Text = ObjCalibracion.Obs_Gestion_Llamada
                LblGestion_Soporte.Text = ObjCalibracion.Gestion_Soporte
                LblObs_Gestion_Soporte.Text = ObjCalibracion.Obs_Gestion_Soporte
                LblGestion_Asignacion.Text = ObjCalibracion.Gestion_Asignacion
                LblObs_Gestion_Asignacion.Text = ObjCalibracion.Obs_Gestion_Asignacion
                LblGestion_Cierre.Text = ObjCalibracion.Gestion_Cierre
                LblObs_Gestion_Cierre.Text = ObjCalibracion.Obs_Gestion_Cierre
                LblReincide.Text = ObjCalibracion.Reincide
                LblObs_Reincide.Text = ObjCalibracion.obs_Reincide
                LblSolucion.Text = ObjCalibracion.Solucion
                LblObs_Solucion.Text = ObjCalibracion.Obs_Solucion
                LblInteres_Escucha.Text = ObjCalibracion.Interes_escuchar
                LblObs_Interes_Escucha.Text = ObjCalibracion.Obs_Interes_escuchar
                LblObs_Generales.Text = ObjCalibracion.Obs_General
                lblmsg.Text = ""
                Validacion = "1"
                Visibilidad()
                PanelRegistroCalibracion.Visible = True
                PanelSesion.Visible = False
            Else
                lblmsg.Text = "No se ha realizado registro de calibracion sobre este caso: " + ObjCalibracion.Cod_Calidad_Registro.ToString
                Lblcaso.Text = ""
                LblNomAgente.Text = ""
                LblGrupo.Text = ""
                LblAuditor.Text = ""
                LblCampaña.Text = ""
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
                LblObs_Gestion_Cierre.Text = ""
                LblReincide.Text = ""
                LblObs_Reincide.Text = ""
                LblSolucion.Text = ""
                LblObs_Solucion.Text = ""
                LblInteres_Escucha.Text = ""
                LblObs_Interes_Escucha.Text = ""
                LblObs_Generales.Text = ""
                PanelRegistroCalibracion.Visible = False
                PanelSesion.Visible = True
                Exit Sub
            End If

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Public Sub Visibilidad()
        If Validacion = "1" Then
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
            btnguardar.Visible = False
            ''Muestro Labels
            LblAmabilidad_Empatia.Visible = True
            LblRealiza_Filtro_A.Visible = True
            LblObs_Amabilidad_Empatia.Visible = True
            LblColgada_Llamada.Visible = True
            LblObs_Colgada_Llamada.Visible = True
            LblObs_Realiza_Filtro_A.Visible = True
            LblCorona_Abierta.Visible = True
            LblObs_Corona_Abierta.Visible = True
            LblDocumentacion.Visible = True
            LblObs_Documentacion.Visible = True
            LblProcedimiento_PQR.Visible = True
            LblObs_Procedimiento_PQR.Visible = True
            LblProcedimiento_Prueb_Tram_Incom_Incorrec.Visible = True
            LblObs_Procedimiento_Prueb_Tram_Incom_Incorrec.Visible = True
            LblPresenta_Obj_Llamada.Visible = True
            LblObs_Presenta_Obj_Llamada.Visible = True
            LblCordialidad_Comunicacion.Visible = True
            LblObs_Cordialidad_Comunicacion.Visible = True
            LblClaridad_Transmitir_Inf.Visible = True
            LblObs_Claridad_Transmitir_Inf.Visible = True
            LblSeguridad.Visible = True
            LblObs_Seguridad.Visible = True
            LblUtiliza_Guion_Saludo_Nom.Visible = True
            LblObs_Utiliza_Guion_Saludo_Nom.Visible = True
            LblGestion_Llamada.Visible = True
            LblObs_Gestion_Llamada.Visible = True
            LblGestion_Soporte.Visible = True
            LblObs_Gestion_Soporte.Visible = True
            LblGestion_Asignacion.Visible = True
            LblObs_Gestion_Asignacion.Visible = True
            LblGestion_Cierre.Visible = True
            LblObs_Gestion_Cierre.Visible = True
            LblSolucion.Visible = True
            LblObs_Solucion.Visible = True
            LblInteres_Escucha.Visible = True
            LblObs_Interes_Escucha.Visible = True
            LblObs_Generales.Visible = True
        Else
            drlAmabilidad_Empatia.Visible = True
            TxtObs_Amabilidad_Empatia.Visible = True
            drlColgada_Llamada.Visible = True
            TxtObs_Colgada_Llamada.Visible = True
            drlRealiza_Filtro_A.Visible = True
            TxtObs_Realiza_Filtro_A.Visible = True
            drlCorona_Abierta.Visible = True
            TxtObs_Corona_Abierta.Visible = True
            drlDocumentacion.Visible = True
            TxtObs_Documentacion.Visible = True
            drlProcedimiento_PQR.Visible = True
            TxtObs_Procedimiento_PQR.Visible = True
            drlProcedimiento_Prueb_Tram_Incom_Incorrec.Visible = True
            TxtObs_Procedimiento_Prueb_Tram_Incom_Incorrec.Visible = True
            drlPresenta_Obj_Llamada.Visible = True
            TxtObs_Presenta_Obj_Llamada.Visible = True
            drlCordialidad_Comunicacion.Visible = True
            TxtObs_Cordialidad_Comunicacion.Visible = True
            drlClaridad_Transmitir_Inf.Visible = True
            TxtObs_Claridad_Transmitir_Inf.Visible = True
            drlSeguridad.Visible = True
            TxtObs_Seguridad.Visible = True
            drlUtiliza_Guion_Saludo_Nom.Visible = True
            TxtObs_Utiliza_Guion_Saludo_Nom.Visible = True
            drlGestion_Llamada.Visible = True
            TxtObs_Gestion_Llamada.Visible = True
            drlGestion_Soporte.Visible = True
            TxtObs_Gestion_Soporte.Visible = True
            drlGestion_Asignacion.Visible = True
            TxtObs_Gestion_Asignacion.Visible = True
            drlGestion_Cierre.Visible = True
            TxtObs_Gestion_Cierre.Visible = True
            drlSolucion.Visible = True
            TxtObs_Solucion.Visible = True
            drlInteres_Escucha.Visible = True
            TxtObs_Interes_Escucha.Visible = True
            TxtObs_Generales.Visible = True
            btnguardar.Visible = True
            ''Oculto Labels
            LblAmabilidad_Empatia.Visible = False
            LblRealiza_Filtro_A.Visible = False
            LblObs_Amabilidad_Empatia.Visible = False
            LblColgada_Llamada.Visible = False
            LblObs_Colgada_Llamada.Visible = False
            LblObs_Realiza_Filtro_A.Visible = False
            LblCorona_Abierta.Visible = False
            LblObs_Corona_Abierta.Visible = False
            LblDocumentacion.Visible = False
            LblObs_Documentacion.Visible = False
            LblProcedimiento_PQR.Visible = False
            LblObs_Procedimiento_PQR.Visible = False
            LblProcedimiento_Prueb_Tram_Incom_Incorrec.Visible = False
            LblObs_Procedimiento_Prueb_Tram_Incom_Incorrec.Visible = False
            LblPresenta_Obj_Llamada.Visible = False
            LblObs_Presenta_Obj_Llamada.Visible = False
            LblCordialidad_Comunicacion.Visible = False
            LblObs_Cordialidad_Comunicacion.Visible = False
            LblClaridad_Transmitir_Inf.Visible = False
            LblObs_Claridad_Transmitir_Inf.Visible = False
            LblSeguridad.Visible = False
            LblObs_Seguridad.Visible = False
            LblUtiliza_Guion_Saludo_Nom.Visible = False
            LblObs_Utiliza_Guion_Saludo_Nom.Visible = False
            LblGestion_Llamada.Visible = False
            LblObs_Gestion_Llamada.Visible = False
            LblGestion_Soporte.Visible = False
            LblObs_Gestion_Soporte.Visible = False
            LblGestion_Asignacion.Visible = False
            LblObs_Gestion_Asignacion.Visible = False
            LblGestion_Cierre.Visible = False
            LblObs_Gestion_Cierre.Visible = False
            LblSolucion.Visible = False
            LblObs_Solucion.Visible = False
            LblInteres_Escucha.Visible = False
            LblObs_Interes_Escucha.Visible = False
            LblObs_Generales.Visible = False
        End If
    End Sub

    Protected Sub dtgCasos_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtgCasos.RowCommand
        Try
            'Mediante este codigo envio el codigo o id, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Ver" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)

                ObjCalibracion.Cod_Calidad_Registro = dtgCasos.Rows(index).Cells(0).Text
                ObjCalibracion.Auditor = lblusuario.Text
                ObjCalibracion.agente = dtgCasos.Rows(index).Cells(2).Text
                ObjCalibracion.grupo = dtgCasos.Rows(index).Cells(3).Text

                Consulta_Calibracion()

            End If

            'Mediante este codigo envio el codigo o id, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Registrar" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)

                ObjCalibracion.Cod_Calidad_Registro = dtgCasos.Rows(index).Cells(0).Text
                ObjCalibracion.Auditor = lblusuario.Text
                ObjCalibracion.agente = dtgCasos.Rows(index).Cells(2).Text
                ObjCalibracion.grupo = dtgCasos.Rows(index).Cells(3).Text

                If ObjCalibracion.Consulta_Calibracion().Tables(0).Rows.Count > 0 Then
                    lblmsg.Text = "Ya ha realizado un registro sobre este caso"
                    Exit Sub
                Else
                    Lblcaso.Text = dtgCasos.Rows(index).Cells(0).Text
                    LblNomAgente.Text = dtgCasos.Rows(index).Cells(2).Text
                    LblGrupo.Text = dtgCasos.Rows(index).Cells(3).Text
                    LblAuditor.Text = lblusuario.Text
                    LblCampaña.Text = dtgCasos.Rows(index).Cells(4).Text
                    lblmsg.Text = ""
                    Validacion = "2"
                    Visibilidad()
                    PanelRegistroCalibracion.Visible = True
                    PanelSesion.Visible = False
                    lblmsg.Text = ""
                End If
            End If


            'Mediante este codigo envio el codigo o id, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "RegistrarConsenso" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)

                ObjCalibracion.Cod_Calidad_Registro = dtgCasos.Rows(index).Cells(0).Text
                ObjCalibracion.Auditor = "CONSENSO"
                ObjCalibracion.agente = dtgCasos.Rows(index).Cells(2).Text
                ObjCalibracion.grupo = dtgCasos.Rows(index).Cells(3).Text

                If ObjCalibracion.Consulta_Calibracion().Tables(0).Rows.Count > 0 Then
                    lblmsg.Text = "Ya ha realizado un consenso sobre este caso"
                    Exit Sub
                Else
                    Lblcaso.Text = dtgCasos.Rows(index).Cells(0).Text
                    LblNomAgente.Text = dtgCasos.Rows(index).Cells(2).Text
                    LblGrupo.Text = dtgCasos.Rows(index).Cells(3).Text
                    LblAuditor.Text = "CONSENSO"
                    LblCampaña.Text = dtgCasos.Rows(index).Cells(4).Text
                    PanelRegistroCalibracion.Visible = True
                    PanelSesion.Visible = False
                    lblmsg.Text = ""
                End If
            End If


            'Mediante este codigo envio el codigo o id, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Consultar_Macro" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                ObjCalibracion.Id_Caso = dtgCasos.Rows(index).Cells(0).Text
                ObjCalibracion.agente = dtgCasos.Rows(index).Cells(2).Text
                ObjCalibracion.grupo = dtgCasos.Rows(index).Cells(3).Text

                If ObjCalibracion.ConsultaMacro().Tables(0).Rows.Count > 0 Then
                    dtgMacro.DataSource = ObjCalibracion.ConsultaMacro
                    dtgMacro.DataBind()
                    LblMacro.Text = "caso:" + dtgCasos.Rows(index).Cells(0).Text + ", agente:" + dtgCasos.Rows(index).Cells(2).Text + ", grupo:" + dtgCasos.Rows(index).Cells(3).Text
                    PanelMacro.Visible = True
                    PanelSesion.Visible = False
                    lblmsg.Text = ""
                Else
                    LblMacro.Text = ""
                    lblmsg.Text = "No se encuentran registros de este caso:" + dtgCasos.Rows(index).Cells(0).Text + ", agente:" + dtgCasos.Rows(index).Cells(2).Text + ", grupo:" + dtgCasos.Rows(index).Cells(3).Text + ", para realizar la consulta macro"
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub dtgCasosVoz_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtgCasosVoz.RowCommand
        Try
            'Mediante este codigo envio el codigo o id, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Ver" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)

                ObjCalibracion.Cod_Calidad_Registro = dtgCasosVoz.Rows(index).Cells(0).Text
                ObjCalibracion.Auditor = lblusuario.Text
                ObjCalibracion.agente = dtgCasosVoz.Rows(index).Cells(2).Text
                ObjCalibracion.grupo = dtgCasosVoz.Rows(index).Cells(3).Text

                Consulta_Calibracion()

            End If

            'Mediante este codigo envio el codigo o id, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Registrar" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)

                ObjCalibracion.Cod_Calidad_Registro = dtgCasosVoz.Rows(index).Cells(0).Text
                ObjCalibracion.Auditor = lblusuario.Text
                ObjCalibracion.agente = dtgCasosVoz.Rows(index).Cells(2).Text
                ObjCalibracion.grupo = dtgCasosVoz.Rows(index).Cells(3).Text

                If ObjCalibracion.Consulta_Calibracion().Tables(0).Rows.Count > 0 Then
                    lblmsg.Text = "Ya ha realizado un registro sobre este caso"
                    Exit Sub
                Else
                    Lblcaso.Text = dtgCasosVoz.Rows(index).Cells(0).Text
                    LblNomAgente.Text = dtgCasosVoz.Rows(index).Cells(2).Text
                    LblGrupo.Text = dtgCasosVoz.Rows(index).Cells(3).Text
                    LblAuditor.Text = lblusuario.Text
                    LblCampaña.Text = dtgCasosVoz.Rows(index).Cells(4).Text
                    lblmsg.Text = ""
                    PanelRegistroCalibracion.Visible = True
                    PanelSesion.Visible = False
                    lblmsg.Text = ""
                End If
            End If


            'Mediante este codigo envio el codigo o id, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "RegistrarConsenso" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)

                ObjCalibracion.Cod_Calidad_Registro = dtgCasosVoz.Rows(index).Cells(0).Text
                ObjCalibracion.Auditor = "CONSENSO"
                ObjCalibracion.agente = dtgCasosVoz.Rows(index).Cells(2).Text
                ObjCalibracion.grupo = dtgCasosVoz.Rows(index).Cells(3).Text

                If ObjCalibracion.Consulta_Calibracion().Tables(0).Rows.Count > 0 Then
                    lblmsg.Text = "Ya ha realizado un consenso sobre este caso"
                    Exit Sub
                Else
                    Lblcaso.Text = dtgCasosVoz.Rows(index).Cells(0).Text
                    LblNomAgente.Text = dtgCasosVoz.Rows(index).Cells(2).Text
                    LblGrupo.Text = dtgCasosVoz.Rows(index).Cells(3).Text
                    LblAuditor.Text = "CONSENSO"
                    LblCampaña.Text = dtgCasosVoz.Rows(index).Cells(4).Text
                    PanelRegistroCalibracion.Visible = True
                    PanelSesion.Visible = False
                    lblmsg.Text = ""
                End If
            End If


            'Mediante este codigo envio el codigo o id, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Consultar_Macro" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)

                ObjCalibracion.Id_Caso = dtgCasosVoz.Rows(index).Cells(0).Text
                If ObjCalibracion.ConsultaMacro().Tables(0).Rows.Count > 0 Then
                    dtgMacro.DataSource = ObjCalibracion.ConsultaMacro
                    dtgMacro.DataBind()
                    PanelMacro.Visible = True
                    PanelSesion.Visible = False
                    lblmsg.Text = ""
                Else
                    lblmsg.Text = "No se encuentran registros de este caso " + dtgCasosVoz.Rows(index).Cells(0).Text + " para realizar la consulta macro"
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnVolver2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnVolver2.Click
        Try
            PanelSesion.Visible = True
            PanelMacro.Visible = False
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Dim Precision As String
    Protected Sub dtgMacro_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles dtgMacro.RowDataBound
        Try
            ''Obtengo valor de Concenso
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                If DataBinder.Eval(e.Row.DataItem, "Auditor") = "CONSENSO" Then
                    Precision = e.Row.Cells(17).Text
                End If
            End If

            ''Realizo operacion para obtener el dato final
            For Each row As GridViewRow In dtgMacro.Rows
                If row.Cells(0).Text = "CONSENSO" Then
                    row.Cells(18).Text = row.Cells(17).Text
                Else
                    row.Cells(18).Text = CInt(Precision) - CInt(row.Cells(17).Text)
                End If
            Next

            'If (e.Row.RowType = DataControlRowType.DataRow) Then
            '    If Precision <> "" And Precision <> Nothing Then
            '        e.Row.Cells(18).Text = CInt(Precision) - CInt(e.Row.Cells(17).Text)
            '    End If
            'End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

End Class