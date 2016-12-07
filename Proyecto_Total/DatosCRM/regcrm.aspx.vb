Public Class regcrm
    Inherits System.Web.UI.Page
    Dim control As String
    Dim a As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                objdatos.idusuario = lblusuario.Text
                objdatos.consultared()
                lblcrea.Text = objdatos.estado

                lblred.Text = objdatos.cargo
                lblasig.Text = objdatos.dpto
                If objdatos.estado <> " " Then
                    btncrea.Visible = True
                Else
                    btncrea.Visible = False
                End If
                traeprogramados()

                '--------inconsistencia encuesta---------'
                With drlinconsistencia
                    .DataSource = objdatos.Consulta_inconsistencia_encuesta
                    .DataTextField = "Nombre"
                    .DataValueField = "Cod_BD_Datos_Complemento"
                    .DataBind()
                End With
                '-----------------'

                'With drltipificacionll
                '    .DataSource = objdatos.consultatipificacion
                '    .DataTextField = "tipificacion"
                '    .DataValueField = "tipificacion"
                '    .DataBind()
                'End With
                'objdatos.idusuario = lblusuario.Text
                'objdatos.ConsultaSinRestriccion()
                'If objdatos.cantreg > 0 Then
                '    With drlgrupo
                '        .DataSource = objdatos.consultagrupo
                '        .DataTextField = "grupo"
                '        .DataValueField = "grupo"
                '        .DataBind()
                '    End With
                '    objdatos.tipo = drlgrupo.SelectedItem.Value
                '    objdatos.estado = drltipificacionll.Text
                '    With drltsoporte
                '        .DataSource = objdatos.consultatsoportegrupo
                '        .DataTextField = "escenario"
                '        .DataValueField = "escenario"
                '        .DataBind()
                '    End With
                'Else
                '    objdatos.estado = drltipificacionll.Text
                '    'grupo de tipificación
                '    With drlgrupo
                '        .DataSource = objdatos.consultagrupoResticcion
                '        .DataTextField = "grupo"
                '        .DataValueField = "grupo"
                '        .DataBind()
                '    End With
                '    objdatos.tipo = drlgrupo.SelectedItem.Value
                '    objdatos.estado = drltipificacionll.Text
                '    With drltsoporte
                '        .DataSource = objdatos.consultatsoportegrupoRestriccion
                '        .DataTextField = "escenario"
                '        .DataValueField = "escenario"
                '        .DataBind()
                '    End With
                'End If

                'Inconsistencia Global
                objdatos.cargo = "Global"
                With drlinconsglobal
                    .DataSource = objdatos.consultaincdatos
                    .DataTextField = "inconsistencia"
                    .DataValueField = "idtipoinc"
                    .DataBind()
                End With
                'Inconsistencia
                objdatos.cargo = "Global2"
                objdatos.estado = drlincons.Text
                With drlincons
                    .DataSource = objdatos.consultaincdatos
                    .DataTextField = "inconsistencia"
                    .DataValueField = "idtipoinc"
                    .DataBind()
                End With

                'divipola - dpto
                With drldpto
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultadpto
                    .DataTextField = "nombredpto"
                    .DataValueField = "coddpto"
                    .DataBind()
                End With
                objdatos.dpto = drldpto.SelectedItem.Value
                With drlmun
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultamun
                    .DataTextField = "nombremun"
                    .DataValueField = "coddiv"
                    .DataBind()
                End With
                'caracteristicas
                With drlFcaract
                    .DataSource = objdatos.consultacaractdat
                    .DataTextField = "desccarac"
                    .DataValueField = "idcarac"
                    .DataBind()
                End With
                cargadrl()
                consultafallamasiva()
                LblPQR.Text = objdatos.Consulta_Numero_PQR().Tables(0).Rows(0).Item("Nombre")
                ''''' INICIO SEGURIDAD ACCESO URL '''''
                Dim objGeneral As New clsgeneral
                objGeneral.DtsSeguridad = Session("dtsSeguridad")
                objGeneral.Consulta_Proyecto_Seguridad()
                objGeneral.PaginaAcceso = "~" + Mid(Request.RawUrl, Integer.Parse(objGeneral.nombreentidad))
                objGeneral.idusuario = CType(Session("permisos"), clsusuario).usuario
                objGeneral.PermisosUrl()
                ' ''''' FIN SEGURIDAD ACCESO URL '''''    
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Public Sub Limpia_Herramientas_Cargadas()
        Try
            drlFtectolog.SelectedValue = "89"
            drlFtectolog.Enabled = True
            'drlCicloFacturacion.SelectedValue = "- Seleccione -"
            'drlCicloFacturacion.Enabled = True
            drlmarca.SelectedValue = "- Seleccione -"
            drlmarca.Enabled = True
            drlmarca_SelectedIndexChanged(1, Nothing)
            drlequipo.Enabled = True
            'TxtVersion_S_O_Equipo.Text = ""
            'TxtVersion_S_O_Equipo.Enabled = True
            drldpto.SelectedValue = "0"
            drldpto.Enabled = True
            drldpto_SelectedIndexChanged(1, Nothing)
            drlmun.Enabled = True
            txtbarrio.Text = ""
            txtbarrio.Enabled = True
            txtultimc.Text = ""
            txtultimc.Enabled = True
            drlfranja.SelectedValue = "0"
            drlfranja.Enabled = True
            drlTipo_PQR.SelectedValue = "- Seleccione -"
            drlTipo_PQR.Enabled = True
            'drlTipo_Cliente.SelectedValue = "- Seleccione -"
            'drlTipo_Cliente.Enabled = True
            drlModalidad.SelectedValue = "- Seleccione -"
            drlModalidad.Enabled = True
            drlreclamoppal.SelectedValue = "- Seleccione -"
            drlreclamoppal.Enabled = True
            drltipofalla.SelectedValue = "- Seleccione -"
            drltipofalla.Enabled = True
            drl611.SelectedValue = "1"
            drl611.Enabled = True
            'RadioBtn_Promocion_WTF.SelectedItem.Selected = False
            TxtPQR.Text = ""
            TxtPQR.Enabled = True
            Btn_Habilita_Tecnologia.Visible = False
            'Btn_Habilita_CicloF.Visible = False
            Btn_Habilita_Equipo.Visible = False
            'Btn_Habilita_Version_S_O_Equipo.Visible = False
            Btn_Habilita_Municipio.Visible = False
            Btn_Habilita_Barrio.Visible = False
            Btn_Habilita_Fc_Utl_Caida.Visible = False
            Btn_Habilita_PQR.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Public Sub Consulta_Gestion()
        Try
            Dim ObjDatos As New clscrmdatos
            Dim dts As New DataSet
            ObjDatos.CampanaLogin = LblPerfil.Text
            ObjDatos.estadoinc = drltipificacionll.SelectedItem.Text
            dts = ObjDatos.Consulta_Gestion_Campaña()
            If dts.Tables(0).Rows.Count > 0 Then
                ObjDatos.caso = lblcaso.Text
                ObjDatos.idusuario = lblusuario.Text
                ObjDatos.estadoinc = drltipificacionll.SelectedItem.Text
                ObjDatos.CampanaLogin = LblPerfil.Text
                ObjDatos.Superv = LblSupervisor.Text
                ObjDatos.Ingreso_Gestion()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub consultafallamasiva()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.consultafallamasiva()
            If objdatos.cantidad > 0 Then
                lblobsmasiva.Text = objdatos.obs
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub traeprogramados()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.idusuario = lblusuario.Text
            dtgprog.DataSource = objdatos.consultaprogramado
            dtgprog.DataBind()

            objdatos.idusuario = lblusuario.Text
            dtgasig.DataSource = objdatos.consultaasignado
            dtgasig.DataBind()

            If objdatos.cantidad > 0 Then
                LblCuentaAsignados.Text = objdatos.cantidad
                PanelCasosAsignados.Visible = True
            Else
                UpdatePanelCasosProgramados.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub cargadrl()
        Try
            Dim objdatos As New clsgeneral
            'linea
            objdatos.identidad = 21
            With drllinea
                .DataSource = objdatos.consultalineadt
                .DataTextField = "tipo"
                .DataValueField = "tipo"
                .DataBind()
            End With


            'servicio
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.identidad = 21
            With drlservicio2
                .DataSource = objdatos.consultaservicio
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            'subservicio
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.mun = drlservicio2.SelectedItem.Text
            objdatos.identidad = 21
            With drlsubservicio
                .DataSource = objdatos.consultasubservicio
                .DataTextField = "tipificacion"
                .DataValueField = "tipificacion"
                .DataBind()
            End With
            'solicitud
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.mun = drlservicio2.SelectedItem.Text
            objdatos.nombre = drlsubservicio.SelectedItem.Text
            objdatos.identidad = 21
            With drlsolicitud
                .DataSource = objdatos.consultasolicitud
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With


            'reclamo ppal
            With drlreclamoppal
                .DataSource = objdatos.consultareclamo
                .DataTextField = "descreclamo"
                .DataValueField = "descreclamo"
                .DataBind()
            End With
            objdatos.tipo = drlreclamoppal.SelectedItem.Value
            'tipo falla
            With drltipofalla
                .DataSource = objdatos.consultatipofalla
                .DataTextField = "desctipofalla"
                .DataValueField = "desctipofalla"
                .DataBind()
            End With

            With drlFtectolog
                objdatos.idusuario = 4
                .DataSource = objdatos.consultadiagnostico
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
            With drlvariable
                objdatos.idusuario = 6
                .DataSource = objdatos.consultadiagnostico
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
            With drlmarca
                .DataSource = objdatos.consultamarca
                .DataTextField = "marca"
                .DataValueField = "marca"
                .DataBind()
            End With
            objdatos.estado = drlmarca.SelectedItem.Value
            With drlequipo
                .DataSource = objdatos.consultaequipo
                .DataTextField = "equipo"
                .DataValueField = "equipo"
                .DataBind()
            End With
            Dim ObjclsDatos As New clscrmdatos
            'Tipo PQR
            objdatos.Validacion = "Tipo PQR"
            With drlTipo_PQR
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            ''Modalidad
            objdatos.Validacion = "Modalidad"
            With drlModalidad
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            'Nuevo
            '*CATALOGO DE DIAGNOSTICO
            '
            '---Causa Raiz---'
            objdatos.idusuario = lblusuario.Text
            objdatos.ConsultaSinRestriccion()
            If objdatos.cantreg > 0 Then
                objdatos.Validacion = "Causa raiz"
                With drlCausa_Raiz
                    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                    .DataTextField = "tipificacion1"
                    .DataValueField = "tipificacion1"
                    .DataBind()
                End With
            Else
                objdatos.Validacion = "Causa raiz 2"
                With drlCausa_Raiz
                    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                    .DataTextField = "tipificacion1"
                    .DataValueField = "tipificacion1"
                    .DataBind()
                End With
            End If

            ''Segmento
            objdatos.Validacion = "Segmento"
            objdatos.localidad = drlCausa_Raiz.SelectedValue
            With drlSegmento
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion4"
                .DataValueField = "tipificacion4"
                .DataBind()
            End With
            'Elemento
            objdatos.Validacion = "Elemento"
            objdatos.localidad = drlCausa_Raiz.SelectedValue
            objdatos.nombre = drlSegmento.SelectedValue
            With drlElemento
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion3"
                .DataValueField = "id_tipificacion"
                .DataBind()
            End With
            'Tipo de falla
            objdatos.Validacion = "Tipo de falla"
            objdatos.localidad = drlElemento.SelectedValue
            With drlTipo_De_Falla
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion2"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With
            'tipo soporte'
            objdatos.Validacion = "Tipo Soporte"
            objdatos.localidad = drlTipo_De_Falla.SelectedValue
            With drltsoporte
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion2"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With

            'grupo
            objdatos.Validacion = "Grupo"
            objdatos.localidad = drlTipo_De_Falla.SelectedValue
            objdatos.nombre = drltsoporte.SelectedItem.Text
            With drlgrupo
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion1"
                .DataValueField = "tipificacion1"
                .DataBind()
            End With

            '----Estados---'           
            objdatos.Validacion = "Estado"
            objdatos.localidad = "Tipificacion"
            objdatos.nombre = drltsoporte.SelectedValue
            With drltipificacionll
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion2"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With

           '*CATEGORIA DE CIERRE
            'Categoria de cierre drl
            objdatos.Validacion = "Categoria de cierre"
            objdatos.localidad = drltipificacionll.SelectedValue
            With drlCategoriaCierre
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion1"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With



           

            'Error en registro
            objdatos.idusuario = 6
            With drlvariable
                .DataSource = objdatos.consultadiagnostico
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
            '* FALLA DE RED - VALIDACIONES SERVICIO AL CLINETE
            'Tipo de Edificacion Donde se Presenta la Falla
            objdatos.Validacion = "VF_Tipo_Edificacion_Donde_Presenta_Falla_1"
            With Drl_Tipo_Edificacion_Donde_Presenta_Falla_1
                .DataSource = objdatos.Carga_Drl_Servicio_Cliente_SAC
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
            objdatos.Validacion = "VF_Tipo_Edificacion_Donde_Presenta_Falla_2"
            With Drl_Tipo_Edificacion_Donde_Presenta_Falla_2
                .DataSource = objdatos.Carga_Drl_Servicio_Cliente_SAC
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
            'Tecnologia en la que se Presenta la Falla Luego de pruebas
            objdatos.Validacion = "VF_Tecnologia_Presenta_Falla_Luegodepruebas"
            With Drl_Tecnologia_Presenta_Falla_Luegodepruebas
                .DataSource = objdatos.Carga_Drl_Servicio_Cliente_SAC
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
            'Para cuando la opcion "No existen cambios administrativos sobre la línea o cuenta maestra" sea falsoSplit_Billing
            objdatos.Validacion = "Split_Billing"
            With Drl_Split_Billing
                .DataSource = objdatos.Carga_Drl_Servicio_Cliente_SAC
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
            'Valores de HLR_HSS
            objdatos.Validacion = "HLR_HSS"
            With Drl_HLR_HSS
                .DataSource = objdatos.Carga_Drl_Servicio_Cliente_SAC
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
            'Se forza la red del dispositivo
            objdatos.Validacion = "VF_Forza_Red_Dispositivo"
            With Drl_Forza_Red_Dispositivo
                .DataSource = objdatos.Carga_Drl_Servicio_Cliente_SAC
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
            'Se verifica o realiza configuración de APN
            objdatos.Validacion = "VF_Verifica_Realiza_Configuración_APN"
            With Drl_Verifica_Realiza_Configuración_APN
                .DataSource = objdatos.Carga_Drl_Servicio_Cliente_SAC
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
            ' Qos
            objdatos.Validacion = "VF_Qos"
            With Drl_Qos
                .DataSource = objdatos.Carga_Drl_Servicio_Cliente_SAC
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub


    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clscrmdatos
        Try
            If lblcaso.Text = "" Then
                lblmsg.Text = "Consulte el caso antes de guardar el registro"
                Exit Sub
            End If
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            objdatos.Validacion = 1
            objdatos.ConsultarEstados()
            If objdatos.tipificacion.Contains("Cerrado") Then
                lblmsg.Text = "¡El Caso que desea guardar se encuentra Cerrado!"
                Exit Sub
            Else
                objdatos.Validacion = Nothing
            End If

            If drltipificacionll.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione tipificacion de llamada"
                Exit Sub
            End If

            If (drltipificacionll.SelectedItem.Text = "No Contactado") And txtobs.Text = "" Then
                lblmsg.Text = "Digite la observación de atención al caso (OBSERVACIÓN)"
                Exit Sub
            Else
                If drltipificacionll.SelectedItem.Text <> "No Contactado" Then
                    If drltipificacionll.SelectedItem.Text = "Cerrado" And drltsoporte.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Si el caso se encuentra cerrado debe elegir un tipo de soporte (CIERRE DE LLAMADA - Tipo Soporte)"
                        Exit Sub
                    End If
                    If (drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD") And drltsoporte.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Si el caso se encuentra en solicitud escalar debe elegir un tipo de soporte (CIERRE DE LLAMADA - Tipo Soporte)"
                        Exit Sub
                    End If

                    If drlTipo_PQR.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione un tipo PQR (VOZ DEL CLIENTE - Tipo PQR)"
                        Exit Sub
                    End If
                    If drlModalidad.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una modalidad (VOZ DEL CLIENTE - Modalidad)"
                        Exit Sub
                    End If
                    If txtbarrio.Text = "" Then
                        lblmsg.Text = "Digite el barrio donde se presenta la falla"
                        Exit Sub
                    End If
                    If drlCategoriaCierre.SelectedItem.Text = "- Seleccione -" And drltipificacionll.SelectedItem.Text = "Cerrado" Then
                        lblmsg.Text = "Seleccione una categoria de cierre (CIERRE DE LLAMADA - Categoria de cierre)"
                        Exit Sub
                    End If
                    If drlsolicitud.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una Solicitud / Tipo Falla (VOZ DEL CLIENTE - Solicitud / Tipo Falla)"
                        Exit Sub
                    End If
                    If drl611.SelectedItem.Value <> "1" Then
                        objdatos.preg1 = drl611.SelectedItem.Text
                    Else
                        objdatos.preg1 = "0"
                    End If
                    If TxtPercep_Serv.Text <> "" Then
                        objdatos.Percep_serv = TxtPercep_Serv.Text
                    Else
                        objdatos.Percep_serv = ""
                    End If

                    If drltsoporte.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione el tipo de soporte brindado (CIERRE DE LLAMADA - Tipo Soporte)"
                        Exit Sub
                    Else
                        If lblred.Text = "1" Then
                            objdatos.tiposoporte = drltsoporte.SelectedItem.Text
                        Else
                            If (drltsoporte.SelectedItem.Text = "Intermitencias o Menor desempeño en la red x eventos temporales en la RED Celular" Or drltsoporte.SelectedItem.Value = "Demora en Aprovisionamientos en transacciones Activacion o Cambios desde AC, Poliedro u otras Plataformas o procesos" Or drltsoporte.SelectedItem.Value = "Disponibilidad Red Datos (Error de Conexión, Sin Señal, Conectado pero sin trafico, Cobertura)" Or drltsoporte.SelectedItem.Value = "Calidad Red Datos (Baja velocidad, Acceso solo a algunas paginas o servicios)" Or drltsoporte.SelectedItem.Value = "Fallas en Servidores de Aplicaciones de Terceros externas a CLARO") And (drltipificacionll.SelectedItem.Text <> "Solicitud Escalar CPD") Then
                                lblmsg.Text = "Si el tipo de soporte es falla de red la tipificación debe ser Solicitud Escalar CPD, verifique (CIERRE DE LLAMADA - Tipificación Llamada)"
                                Exit Sub
                            Else
                                objdatos.tiposoporte = drltsoporte.SelectedItem.Text
                            End If

                        End If
                    End If
                    If drltipificacionll.SelectedItem.Value = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione la tipificación de la llamada (CIERRE DE LLAMADA - Tipificación Llamada)"
                        Exit Sub
                    Else
                        objdatos.tipificacion = drltipificacionll.SelectedItem.Text
                    End If
                    If drltipificacionll.SelectedItem.Text = "Cerrado" Or drltipificacionll.SelectedItem.Text = "Seguimiento" Or drltipificacionll.SelectedItem.Text = "Gestionado" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD" Then
                        If drlreclamoppal.SelectedItem.Text = "- Seleccione -" Or drltipofalla.SelectedItem.Text = "- Seleccione -" Then
                            lblmsg.Text = "Si el caso es Cerrado, Solicitud Escalar, Gestionado o Seguimiento, debe elegir el reclamo principal y el tipo de falla (CATALOGO DE DIAGNOSTICO - Reclamo Principal & Tipo Falla Rec Ppal)"
                            Exit Sub
                        End If
                        'If drlCicloFacturacion.Text = "- Seleccione -" Then
                        '    lblmsg.Text = "Seleccione un ciclo de facturación (GEORREFERENCIACIÓN - Ciclo de Facturación)"
                        '    Exit Sub
                        'End If
                    End If

                    If txtobs.Text = "" Then
                        lblmsg.Text = "Digite la observación de atención al caso (OBSERVACIÓN)"
                        Exit Sub
                    Else
                        objdatos.obs = txtobs.Text
                    End If

                    If txtultimc.Text <> Nothing Then
                        'valida fecha no superior a la actual
                        If Convert.ToDateTime(Me.txtultimc.Text) > Today Then
                            lblmsg.Text = "La fecha de caida no puede ser mayor a la fecha actual (GEORREFERENCIACIÓN - Fecha Ultima Caida)"
                            Exit Sub
                        End If
                    End If
                    If txtultimc.Text <> "" And drlfranja.SelectedItem.Value = "0" Then
                        lblmsg.Text = "Elija la franja en la que se presentó la última caida: mañana, tarde, noche (GEORREFERENCIACIÓN - Fecha Ultima Caida)"
                        Exit Sub
                    End If
                    If drltipificacionll.SelectedItem.Text = "Programado" Then
                        If txtmin.Text = "" Or txthora.Text = "" Or txtfcprog.Text = "" Then
                            lblmsg.Text = "Si la llamada es programada elija la fecha y hora a la que se debe llamar nuevamente (SEGUIMIENTO - Fecha Programación & Hora)"
                            txtfcprog.Text = ""
                            Exit Sub
                        Else
                            Dim hora As String
                            If txthora.Text > 23 Or txtmin.Text > 59 Then
                                lblmsg.Text = "La hora de programación no es correcta, verifique (SEGUIMIENTO - Hora)"
                                txtfcprog.Text = ""
                                Exit Sub
                            End If
                            hora = Convert.ToDateTime(txtfcprog.Text & " " & txthora.Text & ":" & txtmin.Text)
                            If Convert.ToDateTime(hora) <= Now Then
                                lblmsg.Text = "La fecha de programación debe ser mayor a la fecha actual, verifique (SEGUIMIENTO - Fecha Programación & Hora)"
                                txtfcprog.Text = ""
                                Exit Sub
                            End If
                            objdatos.horaprog = hora
                        End If
                    End If
                    If lblobs611.Text = "Registro Inbound" Then
                        If drlequipo.SelectedItem.Text = "- Seleccione -" Then
                            lblmsg.Text = "El registro es inbound y requiere registro obligatorio de equipo (GEORREFERENCIACIÓN - Equipo)"
                            Exit Sub
                        End If
                    End If
                    If drlmun.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "El registro es inbound y requiere registro obligatorio de departamento y municipio (GEORREFERENCIACIÓN - Departamento & Municipio)"
                        Exit Sub
                    End If
                    If drltipificacionll.SelectedItem.Text = "Cerrado" Or drltipificacionll.SelectedItem.Text = "Gestionado" Or drltipificacionll.SelectedItem.Text = "Seguimiento" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD" Then
                        If drlmarca.SelectedItem.Text = "- Seleccione -" Then
                            lblmsg.Text = "Si el caso es cerrado, escalado o gestionado, debe elegir la marca del equipo (GEORREFERENCIACIÓN - Marca)"
                            Exit Sub
                        End If
                        If drlequipo.SelectedItem.Text = "- Seleccione -" Then
                            lblmsg.Text = "Seleccione un equipo (GEORREFERENCIACIÓN - Equipo)"
                            Exit Sub
                        End If
                    End If
                    If drltsoporte.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione el tipo de soporte brindado (CIERRE DE LLAMADA - Tipo Soporte)"
                        Exit Sub
                    End If
                    'If Txt_Tipificacion_Interna.Text = "" And (drltipificacionll.SelectedItem.Text = "Cerrado" Or drltipificacionll.SelectedItem.Text = "Gestionado" Or drltipificacionll.SelectedItem.Text = "Seguimiento" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD") Then
                    '    lblmsg.Text = "Ingrese una tipificacion interna (CIERRE DE LLAMADA - Tipificación Interna)"
                    '    Exit Sub
                    'End If

                Else
                    If drltipificacionll.SelectedItem.Text = "No Contactado" And drltsoporte.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione el tipo de soporte brindado (CIERRE DE LLAMADA - Tipo Soporte)"
                        Exit Sub
                    Else
                        objdatos.tiposoporte = drltsoporte.SelectedItem.Text
                    End If
                    objdatos.obs = txtobs.Text
                    objdatos.tipificacion = drltipificacionll.SelectedItem.Text
                End If
            End If

            '------Numero Alterno------'
            If chkSi.Checked = False And chkNo.Checked = False Then
                lblmsg.Text = "Seleccione si realizo contacto a linea alterna"
                Exit Sub
            Else
                If chkSi.Checked = True Then
                    If txtnumalt.Text = "" Then
                        lblmsg.Text = "Digite el numero alterno"
                        Exit Sub
                    Else
                        objdatos.telalt = txtnumalt.Text
                    End If
                End If
                If chkNo.Checked = True Then
                    objdatos.telalt = lblmin.Text
                End If
            End If
            '----Fin numero alterno------'



            If TxtPQR.Text = "" Then
                lblmsg.Text = "Ingrese el consecutivo PQR"
                Exit Sub
            Else
                objdatos.pqr = Int64.Parse(LblPQR.Text + TxtPQR.Text)
            End If
            objdatos.idusuario = lblusuario.Text
            If (drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD") And LblEscalamiento.Text = Nothing And lblcrea.Text <> "Es" Then
                lblmsg.Text = "Antes de que realice el registro de gestion, debe realizar el escalamiento a falla de red o services"
                Exit Sub
            Else
                If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar CPD" And LblEscalamiento.Text = "Falla de red" Then
                    lblmsg.Text = "Si reporto falla de red el estado del caso debe ser Solicitud Escalar CPD"
                    Exit Sub
                End If
                If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar SD" And LblEscalamiento.Text = "Escala service" Then
                    lblmsg.Text = "Si realizó Escalamiento Service el estado del caso debe ser Solicitud Escalar SD"
                    Exit Sub
                End If
            End If
            If drlCategoriaCierre.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una categoria cierre"
                Exit Sub
            End If


            '-----------inconsistencia--------'
            If drltipificacionll.SelectedItem.Text = "Cerrado" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD" Then
                If drlinconsistencia.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione inconsistencia en *611 / ENCUESTA"
                    Exit Sub
                Else
                    If drlinconsistencia.SelectedItem.Text = "Otro" And txtobsincon.Text = "" Then
                        lblmsg.Text = "Escriba una observacion en inconsistencia"
                        Exit Sub
                    ElseIf drlinconsistencia.SelectedItem.Text <> "Otro" Then
                        objdatos.inconsistencia_encuesta = drlinconsistencia.SelectedItem.Text
                    Else
                        objdatos.inconsistencia_encuesta = txtobsincon.Text
                    End If
                End If
            Else
                If drlinconsistencia.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.inconsistencia_encuesta = ""
                ElseIf drlinconsistencia.SelectedItem.Text = "Otro" And txtobsincon.Text = "" Then
                    lblmsg.Text = "Escriba una observacion en inconsistencia"
                    Exit Sub
                ElseIf drlinconsistencia.SelectedItem.Text <> "Otro" Then
                    objdatos.inconsistencia_encuesta = drlinconsistencia.SelectedItem.Text
                Else
                    objdatos.inconsistencia_encuesta = txtobsincon.Text
                End If
            End If
            '---------------------'

            ''Validacion para el aval de los casos
            If drlCategoriaCierre.SelectedItem.Text = "Remision a Servicio Tecnico" Or drlCategoriaCierre.SelectedItem.Text = "Remision a CAV por falta de conocimiento por parte del cliente" Then
                objdatos.caso = lblcaso.Text
                objdatos.Validacion = "3"
                objdatos.consultaperfilamiento()
                If objdatos.cantidad = 0 Then
                    lblmsg.Text = "Este caso no cuenta con el aval de un supervisor"
                    Exit Sub
                End If
            End If

            If Session("PermiteGuardar") <> Nothing Then
                objdatos.registrocrm()
            Else
                lblmsg.Text = "La acción esta inhabilita o genera duplicidad consulta de nuevo el caso para validar la gestión y permitir el registro"
                Exit Sub
            End If
           

            If lblestado.Text.ToUpper = "BUZON" Then
                If (drltipificacionll.SelectedItem.Text.Contains("Solicitud") Or drltipificacionll.SelectedItem.Text = "Cerrado") Then
                    actbandeja()

                End If
            Else
                actbandeja()
            End If

            guardadiagnostico()

            If control = 1 Then
                Exit Sub
            End If

           'Validacion Programados'''''
            If drltipificacionll.SelectedItem.Text = "Programado" Then
                If DrlLibera.Text = "SI" Then
                    objdatos.Validacion = "Libera"
                    objdatos.asignaprogramados()
                ElseIf DrlLibera.Text = "NO" Then
                    objdatos.Validacion = "Autoasigna"
                    objdatos.idusuario = lblusuario.Text
                    objdatos.asignaprogramados()
                End If
                DrlLibera.Text = "- Seleccione -"
            End If


            Consulta_Gestion()
            Validacion = "Registro"
            buscarinf()
            traeprogramados()
            lblmsg.Text = "Seguimiento ingresado con éxito"
            'El siguiente metodo para dejar en estado inicial todas las herramientas
            Session("PermiteGuardar") = Nothing
            Limpia_Herramientas()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub guardadiagnostico()
        Try
            Dim objdatos As New clscrmdatos

            If drlsolicitud.SelectedItem.Text <> "- Seleccione -" Or drlFtectolog.SelectedItem.Text <> "- Seleccione -" Or drlvariable.SelectedItem.Text <> "- Seleccione -" Or drlmun.SelectedItem.Text <> "- Seleccione -" Or txtultimc.Text <> "" Or drltipofalla.SelectedItem.Text <> "- Seleccione -" Or drlreclamoppal.SelectedItem.Text <> "- Seleccione -" Then

                '-----------Inconsistencia-------------'
                If drlinconsistencia.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.inconsistencia_encuesta = ""
                ElseIf drlinconsistencia.SelectedItem.Text <> "Otro" Then
                    objdatos.inconsistencia_encuesta = drlinconsistencia.SelectedItem.Text
                Else
                    objdatos.inconsistencia_encuesta = txtobsincon.Text
                End If
                '----------------------'

                If drlsolicitud.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.solicitud = "0"
                Else
                    objdatos.solicitud = drlsolicitud.SelectedItem.Value
                End If
                If drlreclamoppal.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.reclamoppal = "0"
                Else
                    objdatos.reclamoppal = drlreclamoppal.SelectedItem.Value
                End If
                If drltipofalla.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.tipofalla = "0"
                Else
                    objdatos.tipofalla = drltipofalla.SelectedItem.Value
                End If
                If drlFtectolog.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.diagtecnolog = "0"
                Else
                    objdatos.diagtecnolog = drlFtectolog.SelectedItem.Value
                End If
                If drlvariable.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.diagvariable = "0"
                Else
                    objdatos.diagvariable = drlvariable.SelectedItem.Value
                End If
                If drlmun.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.mun = "0"
                Else
                    objdatos.mun = drlmun.SelectedItem.Value
                End If
                objdatos.diagtcierre = "0"
                If txtbarrio.Text = "" Then
                    objdatos.barrio = ""
                Else
                    objdatos.barrio = txtbarrio.Text
                End If
                'If drlCicloFacturacion.SelectedItem.Text = "- Seleccione -" Then
                '    objdatos.CicloFactura = 0
                'Else
                '    objdatos.CicloFactura = drlCicloFacturacion.Text
                'End If
                If txtultimc.Text = "" Then
                    objdatos.fcultimac = "01/01/1900"
                    objdatos.franjaultimac = ""
                Else
                    objdatos.fcultimac = txtultimc.Text
                    If drlfranja.SelectedItem.Value = "0" Then
                        objdatos.franjaultimac = ""
                    Else
                        objdatos.franjaultimac = drlfranja.SelectedItem.Text
                    End If
                End If
                objdatos.caso = lblcaso.Text
                If drlequipo.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.equipo = ""
                Else
                    objdatos.equipo = drlequipo.Text
                End If
                If drlTipo_PQR.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Tipo_PQR = ""
                Else
                    objdatos.Tipo_PQR = drlTipo_PQR.SelectedItem.Text
                End If
                'If drlTipo_Cliente.SelectedItem.Text = "- Seleccione -" Then
                objdatos.Tipo_Cliente = ""
                'Else
                '    objdatos.Tipo_Cliente = drlTipo_Cliente.SelectedItem.Text
                'End If
                If drlModalidad.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Modalidad = ""
                Else
                    objdatos.Modalidad = drlModalidad.SelectedItem.Text
                End If
                If drlTipo_De_Falla.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Causa_Raiz = "0"
                Else
                    objdatos.Causa_Raiz = drlTipo_De_Falla.SelectedValue
                End If
                If drlCategoriaCierre.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Categoria_Cierre = "0"
                Else
                    objdatos.Categoria_Cierre = drlCategoriaCierre.SelectedValue
                End If
                'If TxtVersion_S_O_Equipo.Text = "" Then
                objdatos.Version_S_O_Equipo = " "
                'Else
                'objdatos.Version_S_O_Equipo = TxtVersion_S_O_Equipo.Text
                'End If
                'If TxtVersion_Facebook.Text = "" Then
                objdatos.Version_Facebook = " "
                'Else
                '    objdatos.Version_Facebook = TxtVersion_Facebook.Text
                'End If
                'If Txt_Tipificacion_Interna.Text = "" Then
                '    objdatos.Tipificacion_Interna = " "
                'Else
                '    objdatos.Tipificacion_Interna = Txt_Tipificacion_Interna.Text
                'End If
                'If RadioBtn_Promocion_WTF.SelectedValue <> "" Then
                '    objdatos.WTF = RadioBtn_Promocion_WTF.SelectedValue
                'Else
                objdatos.WTF = "0"
                'End If
                objdatos.registrodiag()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub actbandeja()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            If drltipificacionll.SelectedItem.Value = "- Seleccione -" Then
                lblmsg.Text = "Seleccione la tipificación de la llamada"
                Exit Sub
            Else
                objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            End If
            If drlequipo.SelectedItem.Value = "- Seleccione -" Then
                objdatos.equipo = ""
            Else
                objdatos.equipo = drlequipo.SelectedItem.Text
            End If
            objdatos.chk1 = "0"
            objdatos.chk2 = "0"
            objdatos.modificarbandeja()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub buscarinf()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el Caso o Min que desea consultar"
            Else
                If txtcaso.Text <> "" Then
                    objdatos.caso = txtcaso.Text
                End If
                dtggeneral.DataSource = objdatos.consultacaso
                dtggeneral.DataBind()
                lblcuenta.Text = objdatos.cantidad
                If objdatos.cantidad > 0 Then
                    lblcliente.Text = objdatos.cliente
                    lbldocumento.Text = objdatos.documento
                    lblmin.Text = objdatos.min
                    lblplan.Text = objdatos.plan
                    lblequipo.Text = objdatos.equipo
                    lbllugar.Text = objdatos.lugar
                    lblemail.Text = objdatos.email
                    lblcaso.Text = objdatos.caso
                    Lblfc_ingreso.Text = objdatos.casfcregistro
                    lblobs611.Text = objdatos.obsini
                    lblestado.Text = objdatos.tipificacion
                    lblnumeroaler.Text = objdatos.telalt
                    lblBandeja.Text = objdatos.Bandeja
                    CargarServicio()

                    If lblestado.Text = "Cerrado" Then
                        lblcaso.Text = ""
                        lblmsg.Text = "No puede realizar gestion sobre este caso ya que se encuentra cerrado"
                        Exit Sub
                    Else
                        Session("PermiteGuardar") = "True"
                    End If
                    If txtcaso.Text = "" Then
                        txtcaso.Text = objdatos.caso
                    End If
                    lblmsg.Text = ""
                    If lblmin.Text <> "" Then
                        objdatos.min = lblmin.Text
                        dtgcoincidentes.DataSource = objdatos.casosasociados
                        dtgcoincidentes.DataBind()
                        lblcuenta1.Text = objdatos.cantidad
                    End If
                    'If drlFtectolog.Enabled = False Or drlCicloFacturacion.Enabled = False Or drlmarca.Enabled = False Or drlequipo.Enabled = False Or drldpto.Enabled = False Or drlmun.Enabled = False Or txtbarrio.Enabled = False Or txtultimc.Enabled = False Or drlfranja.Enabled = False Or drlTipo_PQR.Enabled = False Or drlTipo_Cliente.Enabled = False Or drlModalidad.Enabled = False Or drlreclamoppal.Enabled = False Or drltipofalla.Enabled = False Or TxtVersion_S_O_Equipo.Enabled = False Or TxtPQR.Enabled = False Or drl611.Enabled = False Then
                    If drlFtectolog.Enabled = False Or drlmarca.Enabled = False Or drlequipo.Enabled = False Or drldpto.Enabled = False Or drlmun.Enabled = False Or txtbarrio.Enabled = False Or txtultimc.Enabled = False Or drlfranja.Enabled = False Or drlreclamoppal.Enabled = False Or drltipofalla.Enabled = False Or TxtPQR.Enabled = False Or drl611.Enabled = False Or drlModalidad.Enabled = False Then
                        Limpia_Herramientas_Cargadas()
                    End If
                    If Validacion = "Consulta" Then
                        objdatos.Consulta_Diganostico_Carga()
                        If objdatos.tecnologia <> "" And objdatos.tecnologia <> "0" Then
                            drlFtectolog.SelectedValue = objdatos.tecnologia
                            drlFtectolog.Enabled = False
                            Btn_Habilita_Tecnologia.Visible = True
                        Else
                            Btn_Habilita_Tecnologia.Visible = False
                            drlFtectolog.Enabled = True
                        End If
                        'If objdatos.CicloFactura <> Nothing And objdatos.CicloFactura <> 0 Then
                        '    drlCicloFacturacion.SelectedValue = objdatos.CicloFactura
                        '    drlCicloFacturacion.Enabled = False
                        '    Btn_Habilita_CicloF.Visible = True
                        'Else
                        '    Btn_Habilita_CicloF.Visible = False
                        '    drlCicloFacturacion.Enabled = True
                        'End If
                        If objdatos.marca <> "" And objdatos.marca <> " " And objdatos.marca <> "0" Then
                            drlmarca.SelectedValue = objdatos.marca
                            drlmarca.Enabled = False
                            drlmarca_SelectedIndexChanged(1, Nothing)
                            drlequipo.SelectedValue = objdatos.equipo
                            drlequipo.Enabled = False
                            Btn_Habilita_Equipo.Visible = True
                        Else
                            Btn_Habilita_Equipo.Visible = False
                            drlmarca.Enabled = True
                            drlequipo.Enabled = True
                        End If
                        If objdatos.dpto <> "" And objdatos.dpto <> " " And objdatos.dpto <> "0" Then
                            drldpto.SelectedValue = objdatos.dpto
                            drldpto.Enabled = False
                            drldpto_SelectedIndexChanged(1, Nothing)
                            drlmun.SelectedValue = objdatos.mun
                            drlmun.Enabled = False
                            Btn_Habilita_Municipio.Visible = True
                        Else
                            Btn_Habilita_Municipio.Visible = False
                            drldpto.Enabled = True
                            drlmun.Enabled = True
                        End If
                        If objdatos.barrio <> "" And objdatos.barrio <> " " Then
                            txtbarrio.Text = objdatos.barrio
                            txtbarrio.Enabled = False
                            Btn_Habilita_Barrio.Visible = True
                        Else
                            Btn_Habilita_Barrio.Visible = False
                            txtbarrio.Enabled = True
                        End If
                        If objdatos.fcultimac <> "" And objdatos.fcultimac <> "01/01/1900" Then
                            txtultimc.Text = objdatos.fcultimac
                            txtultimc.Enabled = False
                        Else
                            txtultimc.Enabled = True
                        End If
                        If objdatos.franjaultimac <> "" Then
                            drlfranja.SelectedValue = objdatos.franjaultimac
                            drlfranja.Enabled = False
                            Btn_Habilita_Fc_Utl_Caida.Visible = True
                        Else
                            Btn_Habilita_Fc_Utl_Caida.Visible = False
                            drlfranja.Enabled = True
                        End If
                        If objdatos.Tipo_PQR <> "" Then
                            drlTipo_PQR.SelectedValue = objdatos.Tipo_PQR
                            drlTipo_PQR.Enabled = False
                        Else
                            drlTipo_PQR.Enabled = True
                        End If
                        'If objdatos.Tipo_Cliente <> "" Then
                        '    drlTipo_Cliente.SelectedValue = objdatos.Tipo_Cliente
                        '    drlTipo_Cliente.Enabled = False
                        'Else
                        '    drlTipo_Cliente.Enabled = True
                        'End If
                        If objdatos.Modalidad <> "" Then
                            drlModalidad.SelectedValue = objdatos.Modalidad
                            drlModalidad.Enabled = False
                        Else
                            drlModalidad.Enabled = True
                        End If
                        If objdatos.reclamoppal <> "" And objdatos.reclamoppal <> " " And objdatos.reclamoppal <> "0" Then
                            drlreclamoppal.SelectedValue = objdatos.reclamoppal
                            drlreclamoppal.Enabled = False
                            drlreclamoppal_SelectedIndexChanged(1, Nothing)
                            drltipofalla.SelectedValue = objdatos.tipofalla
                            drltipofalla.Enabled = False
                        Else
                            drlreclamoppal.Enabled = True
                            drltipofalla.Enabled = True
                        End If
                        'If objdatos.Version_S_O_Equipo <> "" And objdatos.Version_S_O_Equipo <> " " Then
                        '    TxtVersion_S_O_Equipo.Text = objdatos.Version_S_O_Equipo
                        '    TxtVersion_S_O_Equipo.Enabled = False
                        '    Btn_Habilita_Version_S_O_Equipo.Visible = True
                        'Else
                        '    TxtVersion_S_O_Equipo.Enabled = True
                        '    Btn_Habilita_Version_S_O_Equipo.Visible = False
                        'End If
                        If objdatos.pqr <> "" And objdatos.pqr <> " " Then
                            TxtPQR.Text = Mid(objdatos.pqr, 10, 7)
                            TxtPQR.Enabled = False
                            Btn_Habilita_PQR.Visible = True
                        Else
                            TxtPQR.Enabled = True
                            Btn_Habilita_PQR.Visible = False
                        End If
                        If objdatos.preg1 <> "" And objdatos.preg1 <> " " And objdatos.preg1 <> "0" And objdatos.preg1 <> "- Selecione -" Then
                            drl611.SelectedValue = objdatos.preg1
                            drl611.Enabled = False
                            If objdatos.Percep_serv <> "" And objdatos.Percep_serv <> " " Then
                                TxtPercep_Serv.Text = objdatos.Percep_serv
                                TxtPercep_Serv.Enabled = False
                            Else
                                TxtPercep_Serv.Enabled = True
                                TxtPercep_Serv.Text = ""
                            End If
                        Else
                            drl611.Enabled = True
                            TxtPercep_Serv.Enabled = False
                            TxtPercep_Serv.Text = ""
                        End If

                    End If
                Else
                    lblcliente.Text = ""
                    lbldocumento.Text = ""
                    lblmin.Text = ""
                    lblplan.Text = ""
                    lblequipo.Text = ""
                    lbllugar.Text = ""
                    Lblfc_ingreso.Text = ""
                    lblemail.Text = ""
                    lblcaso.Text = ""
                    lblobs611.Text = ""
                    lblestado.Text = ""
                    lblfallatec.Text = ""
                    lblnumeroaler.Text = ""
                    lblBandeja.Text = ""

                    lblmsg.Text = "No se han encontrado registros coincidentes"
                    'If drlFtectolog.Enabled = False Or drlCicloFacturacion.Enabled = False Or drlmarca.Enabled = False Or drlequipo.Enabled = False Or drldpto.Enabled = False Or drlmun.Enabled = False Or txtbarrio.Enabled = False Or txtultimc.Enabled = False Or drlfranja.Enabled = False Or drlTipo_PQR.Enabled = False Or drlTipo_Cliente.Enabled = False Or drlModalidad.Enabled = False Or drlreclamoppal.Enabled = False Or drltipofalla.Enabled = False Or TxtVersion_S_O_Equipo.Enabled = False Or TxtPQR.Enabled = False Or drl611.Enabled = False Then
                    If drlFtectolog.Enabled = False Or drlmarca.Enabled = False Or drlequipo.Enabled = False Or drldpto.Enabled = False Or drlmun.Enabled = False Or txtbarrio.Enabled = False Or txtultimc.Enabled = False Or drlfranja.Enabled = False Or drlreclamoppal.Enabled = False Or drltipofalla.Enabled = False Or TxtPQR.Enabled = False Or drl611.Enabled = False Or drlTipo_PQR.Enabled = False Or drlModalidad.Enabled = False Then
                        Limpia_Herramientas_Cargadas()
                    End If
                    dtgcoincidentes.DataSource = Nothing
                    dtgcoincidentes.DataBind()
                    lblcuenta1.Text = 0
                End If
                'Nx Monitor
                If txtcaso.Text <> "" Then
                    objdatos.caso = txtcaso.Text
                End If
                'objdatos.ConsultaNxMonitor()
                'If objdatos.preg2 = "SI" Then
                '    drlIntalaApp.Enabled = False
                '    drlMotivo.Enabled = False
                'Else
                '    drlIntalaApp.Enabled = True
                '    drlMotivo.Enabled = True
                '    Dim objdatos1 As New clsgeneral
                '    objdatos1.idusuario = lblusuario.Text
                '    objdatos1.consultared()
                '    If objdatos1.mun <> "1" Then
                '        drlIntalaApp.Enabled = False
                '        drlMotivo.Enabled = False
                '    End If
                'End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub buscar()
        Try
            Dim objdatos As New clscrmdatos
            If lblasig.Text = "1" Then
                objdatos.idusuario = lblusuario.Text
                objdatos.caso = txtcaso.Text
                objdatos.validacasoasignado()
                If objdatos.cantidad = 0 Then
                    lblmsg.Text = "El caso no se encuentra asignado a su usuario, revise con su supervisor"
                    lblcliente.Text = ""
                    lbldocumento.Text = ""
                    lblmin.Text = ""
                    lblplan.Text = ""
                    lblequipo.Text = ""
                    lbllugar.Text = ""
                    lblemail.Text = ""
                    lblcaso.Text = ""
                    Lblfc_ingreso.Text = ""
                    lblobs611.Text = ""
                    lblestado.Text = ""
                    lblfallatec.Text = ""
                    dtgcoincidentes.DataSource = Nothing
                    dtgcoincidentes.DataBind()
                    lblcuenta1.Text = 0
                    Exit Sub
                End If
            End If
            Validacion = "Consulta"
            buscarinf()
            If txtcaso.Text <> "" Then
                objdatos.caso = txtcaso.Text
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.registroconsultacaso()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Public Sub Limpia_Herramientas()
        Try
            '''' © - JEPC
            '''''''''''''''''''' LIMPIA CARGUE DE INFORMACION  ''''''''''''''''''''
            lblmin.Text = ""
            lblcaso.Text = ""
            lblcliente.Text = ""
            lbldocumento.Text = ""
            lblequipo.Text = ""
            lblplan.Text = ""
            lbllugar.Text = ""
            lblemail.Text = ""
            lblestado.Text = ""
            lblobs611.Text = ""
            lblfallatec.Text = ""
            Lblfc_ingreso.Text = ""
            'LblCustcode_Ac.Text = ""
            'LblCustomer_Id.Text = ""
            lblobsmasiva.Text = ""
            chkmasiva.Checked = False

            '''''''''''''''''''' LIMPIA HERRAMIENTAS ''''''''''''''''''''
            '' GEORREFERENCIACIÓN ''
            drlFtectolog.SelectedValue = 89
            'drlCicloFacturacion.SelectedValue = "- Seleccione -"
            drlmarca.SelectedValue = "- Seleccione -"
            drlmarca_SelectedIndexChanged(1, Nothing)
            'TxtVersion_S_O_Equipo.Text = ""
            'TxtVersion_Facebook.Text = ""
            drldpto.SelectedValue = 0
            drldpto_SelectedIndexChanged(1, Nothing)
            txtbarrio.Text = ""
            txtultimc.Text = ""
            drlfranja.SelectedValue = 0

            '' VOZ DEL CLIENTE ''
            drlTipo_PQR.SelectedValue = "- Seleccione -"
            'drlTipo_Cliente.SelectedValue = "- Seleccione -"
            drlModalidad.SelectedValue = "- Seleccione -"
            drllinea.SelectedValue = "- Seleccione -"
            drllinea_SelectedIndexChanged(1, Nothing)
            drlservicio2_SelectedIndexChanged(1, Nothing)
            drlsubservicio_SelectedIndexChanged(1, Nothing)
            'drlsolicitud.SelectedValue = 358

            '' CATALOGO DE DIAGNOSTICO ''
            drlreclamoppal.SelectedValue = "- Seleccione -"
            drlreclamoppal_SelectedIndexChanged(1, Nothing)
            'drltipofalla.SelectedValue = "- Seleccione -"
            drlCausa_Raiz.SelectedValue = "- Seleccione -"
            drlCausa_Raiz_SelectedIndexChanged(1, Nothing)
            drlSegmento.SelectedValue = "- Seleccione -"
            drlSegmento_SelectedIndexChanged(1, Nothing)
            drlElemento.SelectedValue = 3
            drlElemento_SelectedIndexChanged(1, Nothing)
            drlTipo_De_Falla.SelectedValue = 3
            drlTipo_De_Falla_SelectedIndexChanged(1, Nothing)

            drlvariable.SelectedValue = 91
            'drlvariable_SelectedIndexChanged(1, Nothing)
            lblvariable.Text = ""

            '' SEGUIMIENTO ''
            txtfcprog.Text = ""
            txthora.Text = ""
            txtmin.Text = ""
            txtnumalt.Text = ""

            lblBandeja.Text = ""
            lblnumeroaler.Text = ""
            txtnumalt.Visible = False
            chkSi.Checked = False
            chkNo.Checked = False


            '' CIERRE DE LLAMADA ''
            drlCategoriaCierre.SelectedValue = "3"
            drlCategoriaCierre_SelectedIndexChanged(1, Nothing)
            drltipificacionll.SelectedValue = "3"
            drltipificacionll_SelectedIndexChanged(1, Nothing)
            'Txt_Tipificacion_Interna.Text = ""
            'drlCategoriaCierre.SelectedValue = 428

            ' LblCategoriaCierre.Text = ""
            'drlgrupo.SelectedValue = "- Seleccione -"
            drltsoporte.SelectedValue = "3"
            drltsoporte_SelectedIndexChanged(1, Nothing)
            drlgrupo.SelectedValue = "- Seleccione -"
            drlgrupo_SelectedIndexChanged(1, Nothing)

            TxtPQR.Text = ""

            '' ENCUESTAS ''
            'drlIntalaApp.SelectedValue = 1
            'drlMotivo.SelectedValue = "- Seleccione -"
            'TxtClientId.Text = ""
            drl611.SelectedValue = 1
            TxtPercep_Serv.Text = ""
            '' OBSERVACIÓN ''
            txtobs.Text = ""

            '----Inconsistencia------'
            drlinconsistencia.SelectedValue = 0
            txtobsincon.Text = ""
            txtobsincon.Enabled = False
            '------------------------'


            '' Herramienta para que realice escalamiento
            LblEscalamiento.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try

    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el Caso o Min que desea consultar"
            Else
                If InStr(1, txtcaso.Text, " ") Then
                    lblmsg.Text = "En la caja de texto caso no pueden existir espacios verifique!!"
                    Exit Sub
                End If
                'El siguiente metodo para dejar en estado inicial todas las herramientas
                If txtcaso.Text <> lblcaso.Text Then
                    Limpia_Herramientas()
                End If
                buscar()
                If lblmin.Text <> "" Then
                    Busca_No_Gestion()
                End If
                If Validacion = "True" Then
                    lblmsg.Font.Size = 40
                    lblmsg.Text = "Contacte a su supervisor, ya que este caso debe ser atendido por un agente de Nivel 3"
                Else
                    lblmsg.Font.Size = 12
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drlmarca_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlmarca.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.estado = drlmarca.SelectedItem.Value
            With drlequipo
                objdatos.idtip = 1
                .DataSource = objdatos.consultaequipo
                .DataTextField = "equipo"
                .DataValueField = "equipo"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try

    End Sub

    Protected Sub lnk1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnk1.Click
        dtggeneral.Visible = True
        dtgcoincidentes.Visible = False
    End Sub

    Protected Sub LinkButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton2.Click
        dtggeneral.Visible = False
        dtgcoincidentes.Visible = True
    End Sub

    Protected Sub drlgrupo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlgrupo.SelectedIndexChanged
        Try
            'grupo()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub grupo()
        Try
            Dim objdatos As New clsgeneral

            objdatos.idusuario = lblusuario.Text
            objdatos.ConsultaSinRestriccion()
            If objdatos.cantreg > 0 Then
                objdatos.tipo = drlgrupo.SelectedItem.Value
                objdatos.estado = drltipificacionll.Text
                With drltsoporte
                    .DataSource = objdatos.consultatsoportegrupo
                    .DataTextField = "escenario"
                    .DataValueField = "escenario"
                    .DataBind()
                End With
            Else
                objdatos.tipo = drlgrupo.SelectedItem.Value
                objdatos.estado = drltipificacionll.Text
                With drltsoporte
                    .DataSource = objdatos.consultatsoportegrupoRestriccion
                    .DataTextField = "escenario"
                    .DataValueField = "escenario"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton3.Click
        Try
            If lblcaso.Text = "" Then
                lblmsg.Text = "Consulte el caso antes de generar una inconsistencia"
            Else
                Dim objdatos As New clscrmdatos
                objdatos.caso = lblcaso.Text
                If objdatos.Consultar_Inconsistencia().Tables(0).Rows.Count > 0 Then
                    lblmsg.Text = "El caso  " + objdatos.caso + "  ya tiene reportada una inconsistencia"
                    Exit Sub
                End If
                Pninc.Visible = True
                LinkButton4.Visible = True
                LinkButton3.Visible = False
                LinkButton5.Visible = True
                LinkButton7.Visible = True
                LinkButton6.Visible = False
                LinkButton8.Visible = False
                PanelGestion.Visible = False
                PNEscalam.Visible = False
                pnservice.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton4.Click
        Try
            LinkButton3.Visible = True
            PanelGestion.Visible = True
            LinkButton4.Visible = False
            Pninc.Visible = False
            PNEscalam.Visible = False
            pnservice.Visible = False
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar0.Click
        Try
            Dim objdatos As New clscrmdatos
            If drlincons.SelectedItem.Value = 0 Then
                lblmsg.Text = "Elija el tipo de inconsistencia a reportar"
                Exit Sub
            Else
                objdatos.incidente = drlincons.SelectedItem.Value
            End If
            If txtobsinc.Text = "" Then
                lblmsg.Text = "Digite la observación de la inconsistencia"
                Exit Sub
            Else
                objdatos.obs = txtobsinc.Text
            End If
            If drlnivel.SelectedItem.Value <> "0" Then
                objdatos.barrio = drlnivel.SelectedItem.Value
            Else
                lblmsg.Text = "Elija el nivel que genera la inconsistencia, verifique"
                Exit Sub
            End If
            If txt_registro_numerico.Text <> "" Then
                objdatos.Num_Intento = txt_registro_numerico.Text
            End If
            objdatos.caso = lblcaso.Text
            objdatos.idusuario = lblusuario.Text
            objdatos.registroinc()
            lblmsg.Text = "Inconsistencia reportada con exito"
            drlincons.SelectedValue = 0
            txtobsinc.Text = ""
            Pninc.Visible = False
            PanelGestion.Visible = True
            drlnivel.SelectedValue = "0"
            txt_registro_numerico.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton5.Click
        Try
            If lblcaso.Text = "" Then
                lblmsg.Text = "Antes de crear una falla de red de clic en el botón buscar para verificar que el caso es válido"
                Exit Sub
            End If
            If drltsoporte.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Elija el tipo de cierre brindado antes de generar una falla de red"
                Exit Sub
            End If
            If drlequipo.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Elija el equipo actual antes de generar una falla de red"
                Exit Sub
            End If
            If drlmun.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Elija el municipio antes de generar una falla de red"
                Exit Sub
            End If
            If txtbarrio.Text = "" Then
                lblmsg.Text = "Digite el barrio antes de generar una falla de red"
                Exit Sub
            End If
            If drlFtectolog.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione la tecnología antes de generar una falla de red (GEORREFERENCIACIÓN - Condiciones de Uso)"
                Exit Sub
            End If
            If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar CPD" Then
                lblmsg.Text = "Si desea guardar una falla de red la tipificación debe ser Solicitud Escalar CPD, verifique"
                Exit Sub
            Else
                'PENDIENTE VALIDAR TIPIFICACIONES SERVICE
                'If drltsoporte.SelectedItem.Value = 10 Or drltsoporte.SelectedItem.Value = 17 Then
                '    lblmsg.Text = "Si el escalamiento es a Servisdesk no es necesario crear falla de red, verifique"
                '    Exit Sub
                'Else
                Pninc.Visible = False
                PNEscalam.Visible = True
                LinkButton5.Visible = False
                LinkButton6.Visible = True
                LinkButton3.Visible = True
                LinkButton7.Visible = True
                LinkButton4.Visible = False
                LinkButton8.Visible = False
                PanelGestion.Visible = False
                pnservice.Visible = False
                pnservice.Visible = False
                lblmsg.Text = ""

                txtFcontacto.Text = lblcliente.Text
                txtFnum.Text = txtnumalt.Text
                'txtFtipofalla.Text = lblobs611.Text
                'End If
            End If

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton6.Click
        Try
            Pninc.Visible = False
            PNEscalam.Visible = False
            LinkButton6.Visible = False
            LinkButton5.Visible = True
            PanelGestion.Visible = True
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub dpto1()
        Try
            Dim objdatos As New clsgeneral
            'divipola - dpto
            objdatos.dpto = drldpto.SelectedItem.Value
            With drlmun
                objdatos.idtip = 1
                .DataSource = objdatos.consultamun
                .DataTextField = "nombremun"
                .DataValueField = "coddiv"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drldpto_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drldpto.SelectedIndexChanged
        Try
            dpto1()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar1.Click
        Try
            Dim objdatos As New clsvoz
            If txtFcontacto.Text = "" Then
                lblmsg.Text = "Digite la persona de contacto"
                Exit Sub
            Else
                objdatos.cliente = txtFcontacto.Text
            End If
            If txtFnum.Text = "" Then
                lblmsg.Text = "Digite el número de contacto"
                Exit Sub
            Else
                objdatos.telcontacto = txtFnum.Text
            End If
            If drlFtiempo.SelectedItem.Value = "0" Then
                lblmsg.Text = "Elija el tiempo que lleva presentándose la falla"
                Exit Sub
            Else
                objdatos.tiempo = drlFtiempo.SelectedItem.Value
            End If
            If txtFtipofalla.Text = "" Then
                objdatos.tipofalla = ""
            Else
                objdatos.tipofalla = txtFtipofalla.Text
            End If
            If drlFcaract.SelectedItem.Value = "0" Then
                lblmsg.Text = "Describa las características del tipo de falla"
                Exit Sub
            Else
                objdatos.caracter = drlFcaract.SelectedItem.Text
            End If
            If drlFportada.SelectedItem.Value = "0" Then
                lblmsg.Text = "Elija si la línea es portada o no"
                Exit Sub
            Else
                objdatos.portada = drlFportada.SelectedItem.Value
            End If
            If drlmun.SelectedItem.Value = 0 Then
                lblmsg.Text = "Elija el Departamento y Municipio de la falla"
                Exit Sub
            Else
                objdatos.mun = drlmun.SelectedItem.Value
            End If
            If txtFciudad.Text = "" Then
                objdatos.vereda = ""
            Else
                If rdbvc.SelectedValue = Nothing And txtFciudad.Text <> Nothing Then
                    lblmsg.Text = "Elija si el lugar corresponde a un corregimiento, Vereda o Inspección"
                    Exit Sub
                Else
                    objdatos.vereda = rdbvc.SelectedItem.Value & " " & txtFciudad.Text
                End If
            End If
            If txtFdirecc.Text = "" Then
                lblmsg.Text = "Digite la dirección donde se presenta la falla"
                Exit Sub
            Else
                objdatos.dir = txtFdirecc.Text
            End If
            If txtbarrio.Text = "" Then
                lblmsg.Text = "Digite el barrio donde se presenta la falla"
                Exit Sub
            Else
                objdatos.barrio = txtbarrio.Text
            End If
            If drlFtectolog.SelectedItem.Value = "0" Then
                lblmsg.Text = "Elija la tecnología del equipo que presenta la falla"
                Exit Sub
            Else
                objdatos.tecnologia = drlFtectolog.SelectedItem.Text
            End If
            objdatos.equipo = drlequipo.SelectedItem.Value
            If drlFlineasfalla.SelectedItem.Value = "0" Then
                lblmsg.Text = "Elija si se reportan más líneas con falla en la ubicación reportada"
                Exit Sub
            Else
                objdatos.maslineas = drlFlineasfalla.SelectedItem.Value
            End If
            If txtfobs.Text = "" Then
                lblmsg.Text = "Digite las observaciones reportadas por el usuario"
                Exit Sub
            Else
                objdatos.obs = txtfobs.Text
            End If
            If txtapn.Text = "" Then
                lblmsg.Text = "Digite el APN Afectado"
                Exit Sub
            Else
                objdatos.apn = txtapn.Text
            End If
            If Drl_Qos.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un QoS"
                Exit Sub
            Else
                objdatos.qos = Drl_Qos.SelectedItem.Text
            End If
            '''''Validacion Servicio CLiente'''''''''''
            If Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para La falla se presenta luego de que se construyera una edificación aledaña"
                Exit Sub
            End If
            If Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para La falla se presenta luego de que se remodelara la estructura física del edificio"
                Exit Sub
            End If
            If Drl_Tipo_Edificacion_Donde_Presenta_Falla_1.SelectedItem.Text = "- Seleccione -" Or Drl_Tipo_Edificacion_Donde_Presenta_Falla_2.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione las dos (2) opciones para Tipo de edificación donde se presenta la falla"
                Exit Sub
            End If
            If Drl_Validaciones_Falla_Masiva.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Validaciones de falla masiva"
                Exit Sub
            End If
            If Drl_Tecnologia_Presenta_Falla_Luegodepruebas.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Tecnología en la que se presenta la falla - Luego de pruebas"
                Exit Sub
            End If
            If Txt_Validacion_Coordenadas.Text = "" Then
                lblmsg.Text = "Ingrese un valor para Validación de Coordenadas de maximo 20 caracteres"
                Exit Sub
            End If
            If Drl_Linea_No_Cuenta_Bloqueos_Internet.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Línea no cuenta con bloqueos de Internet"
                Exit Sub
            End If
            If Drl_Linea_No_Superado_Limite_Consumos.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Línea no ha superado el limite de consumos"
                Exit Sub
            End If
            If Drl_Linea_No_Encuentra_Enrutada_PorPagos.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Línea no se encuentra enrutada por pagos"
                Exit Sub
            End If
            If Drl_HLR_HSS.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para HLR / HSS"
                Exit Sub
            End If
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para No existen cambios administrativos sobre la línea o cuenta maestra"
                Exit Sub
            End If
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text = "FALSO" And Drl_Split_Billing.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "En opcion No existen cambios administrativos sobre la línea o cuenta maestra seleccione una opción de la segunda lista 'split billing'"
                Exit Sub
            End If
            If Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Se realizan pruebas de SIMCARD en otro dispositivo (Persiste Falla)"
                Exit Sub
            End If
            If Drl_Forza_Red_Dispositivo.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Se forza la red del dispositivo"
                Exit Sub
            End If
            If Drl_Verifica_Realiza_Configuración_APN.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Se verifica o realiza configuración de APN"
                Exit Sub
            End If
            If Drl_Equipo_Encuentra_Homologado_Operador.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Equipo se encuentra homologado por el operador"
                Exit Sub
            End If

            If Drl_Realiza_Conciliacion_Sobre_linea.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Se realiza conciliación sobre la línea"
                Exit Sub
            End If
            objdatos.Falla_Presenta_Luego_Construyera_Edificacion_Aledania = Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania.SelectedItem.Text
            objdatos.Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio.SelectedItem.Text
            objdatos.Tipo_Edificacion_Donde_Presenta_Falla = Drl_Tipo_Edificacion_Donde_Presenta_Falla_1.SelectedItem.Text + " - " + Drl_Tipo_Edificacion_Donde_Presenta_Falla_2.SelectedItem.Text
            objdatos.Validaciones_Falla_Masiva = Drl_Validaciones_Falla_Masiva.SelectedItem.Text
            objdatos.Tecnologia_Presenta_Falla_Luegodepruebas = Drl_Tecnologia_Presenta_Falla_Luegodepruebas.SelectedItem.Text
            objdatos.Validacion_Coordenadas = Txt_Validacion_Coordenadas.Text
            objdatos.Linea_No_Cuenta_Bloqueos_Internet = Drl_Linea_No_Cuenta_Bloqueos_Internet.SelectedItem.Text
            objdatos.Linea_No_Superado_Limite_Consumos = Drl_Linea_No_Superado_Limite_Consumos.SelectedItem.Text
            objdatos.Linea_No_Encuentra_Enrutada_PorPagos = Drl_Linea_No_Encuentra_Enrutada_PorPagos.SelectedItem.Text
            objdatos.HLR_HSS = Drl_HLR_HSS.SelectedItem.Text
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text = "FALSO" Then
                objdatos.No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text + " - " + Drl_Split_Billing.SelectedItem.Text
            Else
                objdatos.No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text
            End If
            objdatos.Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla.SelectedItem.Text
            objdatos.Forza_Red_Dispositivo = Drl_Forza_Red_Dispositivo.SelectedItem.Text
            objdatos.Verifica_Realiza_Configuración_APN = Drl_Verifica_Realiza_Configuración_APN.SelectedItem.Text
            objdatos.Equipo_Encuentra_Homologado_Operador = Drl_Equipo_Encuentra_Homologado_Operador.SelectedItem.Text
            objdatos.Realiza_Conciliacion_Sobre_linea = Drl_Realiza_Conciliacion_Sobre_linea.SelectedItem.Text


            objdatos.campana = "Datos"
            objdatos.caso = lblcaso.Text
            objdatos.idusuario = lblusuario.Text
            objdatos.fcini = Lblfc_ingreso.Text
            objdatos.registrofallasred()
            guardacrm()
            lblmsg.Text = "Falla de red reportada con éxito"
            'limpiar
            Pninc.Visible = False
            PNEscalam.Visible = False
            txtfobs.Text = ""
            drlFlineasfalla.SelectedValue = "0"
            txtFdirecc.Text = ""
            txtFciudad.Text = ""
            rdbvc.SelectedValue = Nothing
            drlFportada.SelectedValue = "0"
            drlFcaract.SelectedValue = "13"
            txtFtipofalla.Text = ""
            txtFcontacto.Text = ""
            txtFnum.Text = ""
            lblctrl.Text = "1"
            txtapn.Text = ""
            '''''''Servicio Cliente''''''''''''
            Drl_Qos.SelectedValue = "- Seleccione -"
            drlFtiempo.SelectedValue = "0"
            Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania.SelectedValue = "- Seleccione -"
            Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio.SelectedValue = "- Seleccione -"
            Drl_Tipo_Edificacion_Donde_Presenta_Falla_1.SelectedValue = "- Seleccione -"
            Drl_Tipo_Edificacion_Donde_Presenta_Falla_2.SelectedValue = "- Seleccione -"
            Drl_Validaciones_Falla_Masiva.SelectedValue = "- Seleccione -"
            Drl_Tecnologia_Presenta_Falla_Luegodepruebas.SelectedValue = "- Seleccione -"
            Txt_Validacion_Coordenadas.Text = ""
            Drl_Linea_No_Cuenta_Bloqueos_Internet.SelectedValue = "- Seleccione -"
            Drl_Linea_No_Superado_Limite_Consumos.SelectedValue = "- Seleccione -"
            Drl_Linea_No_Encuentra_Enrutada_PorPagos.SelectedValue = "- Seleccione -"
            Drl_HLR_HSS.SelectedValue = "- Seleccione -"
            Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedValue = "- Seleccione -"
            Drl_Split_Billing.SelectedValue = "- Seleccione -"
            Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla.SelectedValue = "- Seleccione -"
            Drl_Forza_Red_Dispositivo.SelectedValue = "- Seleccione -"
            Drl_Verifica_Realiza_Configuración_APN.SelectedValue = "- Seleccione -"
            Drl_Equipo_Encuentra_Homologado_Operador.SelectedValue = "- Seleccione -"
            Drl_Realiza_Conciliacion_Sobre_linea.SelectedValue = "- Seleccione -"

            LblEscalamiento.Text = "Falla de red"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub guardacrm()
        Dim objdatos As New clsvoz
        Try
            objdatos.caso = lblcaso.Text
            If txtfobs.Text = "" Then
                objdatos.obs = ""
            Else
                objdatos.obs = txtfobs.Text
            End If
            objdatos.tipificacion = "Creado"
            objdatos.idusuario = lblusuario.Text
            objdatos.registrocrmfallareddatos()
            lblmsg.Text = "Seguimiento ingresado con éxito"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drlvariable_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlvariable.SelectedIndexChanged
        Try
            Dim objdatos As New clscrmdatos
            objdatos.diagservicio = drlvariable.SelectedItem.Value
            objdatos.consultaproceso()
            lblvariable.Text = objdatos.tipificacion
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub


    Protected Sub drltsoporte_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drltsoporte.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.Validacion = "Grupo"
            objdatos.localidad = drlTipo_De_Falla.SelectedValue
            objdatos.nombre = drltsoporte.SelectedItem.Text
            With drlgrupo
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion1"
                .DataValueField = "tipificacion1"
                .DataBind()
            End With

            objdatos.Validacion = "Estado"
            objdatos.localidad = "Tipificacion"
            objdatos.nombre = drltsoporte.SelectedValue
            With drltipificacionll
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion2"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try

    End Sub

    Protected Sub drltipificacionll_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drltipificacionll.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.Validacion = "Categoria de cierre"
            objdatos.localidad = drltipificacionll.SelectedValue
            With drlCategoriaCierre
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion1"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With


        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub dtgasig_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgasig.PageIndexChanging
        Try
            dtgasig.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            traeprogramados()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub dtgprog_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgprog.PageIndexChanging
        Try
            dtgprog.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            traeprogramados()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub btnguardar2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar2.Click
        Try
            Dim objdatos As New clscrmdatos
            If rdbtipoinb.SelectedValue = Nothing Then
                lblmsg.Text = "Digite el tipo de llamada inbound, Corporativo o Fidelización"
                Exit Sub
            End If
            If txtminnv.Text = "" Then
                lblmsg.Text = "Digite el Min del caso recibido en Inbound"
                Exit Sub
            End If
            If txtplannv.Text = "" Then
                lblmsg.Text = "Digite el plan del caso recibido en Inbound"
                Exit Sub
            End If
            If txtidentifnv.Text = "" Then
                lblmsg.Text = "Digite la identificación del usuario del caso recibido en Inbound"
                Exit Sub
            End If
            If txtnombrenv.Text = "" Then
                lblmsg.Text = "Digite el nombre del usuario del caso recibido en Inbound"
                Exit Sub
            End If

            objdatos.min = txtminnv.Text
            objdatos.plan = txtplannv.Text
            objdatos.identificacion = txtidentifnv.Text
            objdatos.nompaquete = txtnombrenv.Text
            If lblobs611.Text = "" Then
                objdatos.tipofalla = "Registro Inbound " & rdbtipoinb.SelectedItem.Value
            Else
                objdatos.tipofalla = "Registro Inbound " & rdbtipoinb.SelectedItem.Value & " " & lblobs611.Text
            End If

            objdatos.idusuario = lblusuario.Text
            If TxtIngRemite.Text <> "" Then
                objdatos.ingn3 = TxtIngRemite.Text
            End If
            objdatos.asignaconsec()
            If TxtCasoNuevo.Text <> "" Then
                objdatos.abierto = TxtCasoNuevo.Text
            End If
            objdatos.caso = objdatos.abierto

            ''Validacion del caso inbaun cuando este ya est
            Dim dts As New DataSet
            dts = objdatos.Validacion_Registro_Inboun()
            If dts.Tables(0).Rows.Count > 0 Then
                objdatos.Actualizacion_Identifica_Caso_Inbound()
                lblmsg.Text = "Caso reconocido como inbound"
            Else
                objdatos.registroinb()
                lblmsg.Text = "Registro inbound ingresado con éxito"
            End If

            'objdatos.registroinb()
            txtcaso.Text = objdatos.abierto
            buscar()
            pnnuevo.Visible = False
            PanelGestion.Visible = True
            txtminnv.Text = ""
            txtplannv.Text = ""
            txtidentifnv.Text = ""
            rdbtipoinb.SelectedValue = Nothing
            txtnombrenv.Text = ""
            TxtCasoNuevo.Text = ""
            TxtIngRemite.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btncrea_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncrea.Click
        Try
            If txtcaso.Text = "" Then
                lblmsg.Text = "Consulte el caso"
                Exit Sub
            End If
            BuscarInfInbound()
            pnnuevo.Visible = True
            PNEscalam.Visible = False
            Pninc.Visible = False
            PanelGestion.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub chkmasiva_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkmasiva.CheckedChanged
        Try
            consultafallamasiva()
            If lblobsmasiva.Text = "" Then
                lblmsg.Text = "No se registra falla masiva en estos momentos, por favor gestione el caso de forma individual"
                Exit Sub
            Else
                lblmsg.Text = ""
            End If
            Dim objdatos As New clscrmdatos
            Dim objtmp As New clsgeneral
            objdatos.consultafallamasiva()
            If objdatos.barrio <> " " And objdatos.barrio <> "" Then
                txtbarrio.Text = objdatos.barrio
            End If
            If objdatos.obs <> " " And objdatos.obs <> "" Then
                txtobs.Text = objdatos.obs
            End If
            If objdatos.tipificacion <> " " And objdatos.tipificacion <> "" Then
                drltipificacionll.SelectedValue = objdatos.tipificacion
            End If
            If objdatos.grupo <> " " And objdatos.grupo <> "" Then
                drlgrupo.SelectedValue = objdatos.grupo
                objtmp.tipo = drlgrupo.SelectedItem.Value
                objtmp.estado = drltipificacionll.Text
                With drltsoporte
                    .DataSource = objtmp.consultatsoportegrupoRestriccion
                    .DataTextField = "escenario"
                    .DataValueField = "escenario"
                    .DataBind()
                End With
                drltsoporte.SelectedValue = objdatos.tiposoporte
            End If
            If objdatos.diagtecnolog <> " " And objdatos.diagtecnolog <> "0" Then
                drlFtectolog.SelectedValue = objdatos.diagtecnolog
            End If
            If objdatos.marca <> " " And objdatos.marca <> "" Then
                drlmarca.SelectedValue = objdatos.marca
                objtmp.estado = drlmarca.SelectedItem.Value
                With drlequipo
                    .DataSource = objtmp.consultaequipo
                    .DataTextField = "equipo"
                    .DataValueField = "equipo"
                    .DataBind()
                End With
                drlequipo.SelectedValue = objdatos.equipo
            End If
            If objdatos.idservicio <> " " And objdatos.idservicio <> "0" Then
                objtmp.idusuario = objdatos.idservicio
                With drlvariable
                    .DataSource = objtmp.consultadiagnostico
                    .DataTextField = "detalle"
                    .DataValueField = "idreg"
                    .DataBind()
                End With
                drlvariable.SelectedValue = objdatos.diagvariable
            End If
            If objdatos.dpto <> " " And objdatos.dpto <> "0" Then
                drldpto.SelectedValue = objdatos.dpto
                objdatos.dpto = drldpto.SelectedItem.Value
                With drlmun
                    objtmp.idtip = 1
                    .DataSource = objtmp.consultamun
                    .DataTextField = "nombremun"
                    .DataValueField = "coddiv"
                    .DataBind()
                End With
                drlmun.SelectedValue = objdatos.mun
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drlreclamoppal_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlreclamoppal.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.tipo = drlreclamoppal.SelectedItem.Value
            'tipo falla
            With drltipofalla
                .DataSource = objdatos.consultatipofalla
                .DataTextField = "desctipofalla"
                .DataValueField = "desctipofalla"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Sub BuscarInfInbound()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el Caso o Min que desea consultar"
            Else
                If txtcaso.Text <> "" Then
                    objdatos.caso = txtcaso.Text
                End If
                TxtCasoNuevo.Text = txtcaso.Text
                dtggeneral.DataSource = objdatos.consultacaso
                dtggeneral.DataBind()
                lblcuenta.Text = objdatos.cantidad
                If objdatos.cantidad > 0 Then
                    lblcliente.Text = objdatos.cliente
                    txtnombrenv.Text = objdatos.cliente
                    txtnombrenv.Enabled = False
                    lbldocumento.Text = objdatos.documento
                    txtidentifnv.Text = objdatos.documento
                    txtidentifnv.Enabled = False
                    lblmin.Text = objdatos.min
                    txtminnv.Text = objdatos.min
                    txtminnv.Enabled = False
                    lblplan.Text = objdatos.plan
                    txtplannv.Text = objdatos.plan
                    txtplannv.Enabled = False
                    lblequipo.Text = objdatos.equipo
                    lbllugar.Text = objdatos.lugar
                    lblemail.Text = objdatos.email
                    lblcaso.Text = objdatos.caso
                    lblobs611.Text = objdatos.obsini
                    lblestado.Text = objdatos.tipificacion
                    If txtcaso.Text = "" Then
                        txtcaso.Text = objdatos.caso
                    End If
                    lblmsg.Text = ""
                    If lblmin.Text <> "" Then
                        objdatos.min = lblmin.Text
                        dtgcoincidentes.DataSource = objdatos.casosasociados
                        dtgcoincidentes.DataBind()
                        lblcuenta1.Text = objdatos.cantidad
                    End If
                Else
                    lblcliente.Text = ""
                    lbldocumento.Text = ""
                    lblmin.Text = ""
                    lblplan.Text = ""
                    lblequipo.Text = ""
                    lbllugar.Text = ""
                    lblemail.Text = ""
                    lblcaso.Text = ""
                    lblobs611.Text = ""
                    lblestado.Text = ""
                    lblfallatec.Text = ""
                    lblmsg.Text = "No se han encontrado registros coincidentes"
                    dtgcoincidentes.DataSource = Nothing
                    dtgcoincidentes.DataBind()
                    lblcuenta1.Text = 0
                End If
                'Nx Monitor
                If txtcaso.Text <> "" Then
                    objdatos.caso = txtcaso.Text
                End If
                'objdatos.ConsultaNxMonitor()
                'If objdatos.preg2 = "SI" Then
                '    drlIntalaApp.Enabled = False
                '    drlMotivo.Enabled = False
                'Else
                '    drlIntalaApp.Enabled = True
                '    drlMotivo.Enabled = True
                '    Dim objdatos1 As New clsgeneral
                '    objdatos1.idusuario = lblusuario.Text
                '    objdatos1.consultared()
                '    If objdatos1.mun <> "1" Then
                '        drlIntalaApp.Enabled = False
                '        drlMotivo.Enabled = False
                '    End If
                'End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub LinkButton7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton7.Click
        Try
            If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar SD" Then
                lblmsg.Text = "Si va a realizar Escalamiento Service el estado caso debe ser Solicitud Escalar SD"
                Exit Sub
            End If

            Dim objdatos As New clscrmdatos
            Dim objcargas As New clsgeneral
            If drlvariable.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Elija un Error en Registro"
            Else
                If lblcaso.Text = "" Then
                    lblmsg.Text = "Consulte el caso antes de realizar escalamiento a Service"
                    Exit Sub
                End If
                If txtobs.Text = "" Then
                    lblmsg.Text = "Digite una descripción del escalamiento antes de dar clic en el link"
                    Exit Sub
                End If
                With drlapn
                    .DataSource = objcargas.consultaapn
                    .DataTextField = "apn"
                    .DataValueField = "apn"
                    .DataBind()
                End With
                With drlqos
                    .DataSource = objcargas.consultaqos
                    .DataTextField = "qos"
                    .DataValueField = "qos"
                    .DataBind()
                End With
                pnservice.Visible = True
                Pninc.Visible = False
                PNEscalam.Visible = False
                LinkButton7.Visible = False
                LinkButton8.Visible = True
                LinkButton3.Visible = True
                LinkButton5.Visible = True
                LinkButton4.Visible = False
                LinkButton6.Visible = False
                PanelGestion.Visible = False
                lblmsg.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton8.Click
        Try
            Pninc.Visible = False
            PNEscalam.Visible = False
            pnservice.Visible = False
            LinkButton8.Visible = False
            LinkButton7.Visible = True
            PanelGestion.Visible = True
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardservice_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardservice.Click
        Try
            Dim objdatos As New clscrmdatos
            Dim Fn As String
            Dim SaveLocation As String
            If Not FileDocumento.PostedFile Is Nothing And FileDocumento.PostedFile.ContentLength > 0 Then
                Fn = System.IO.Path.GetExtension(FileDocumento.PostedFile.FileName)
                SaveLocation = Server.MapPath("data_Doc") & "\\" & lblcaso.Text + Fn
                FileDocumento.PostedFile.SaveAs(SaveLocation)
                objdatos.archivo = lblcaso.Text + Fn
            Else
                objdatos.archivo = ""
                lblmsg.Text = "Adjunte un archivo"
                Exit Sub
            End If
            If drlapn.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Elija el APN del caso"
                Exit Sub
            Else
                objdatos.apn = drlapn.SelectedItem.Text
            End If
            If drlqos.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el QoS del caso"
                Exit Sub
            Else
                objdatos.qos = drlqos.SelectedItem.Text
            End If
            If txtfcactivacion.Text = "" Then
                lblmsg.Text = "Digite la fecha de activación del servicio"
                Exit Sub
            Else
                objdatos.fcini = txtfcactivacion.Text
            End If
            objdatos.caso = lblcaso.Text
            objdatos.diagvariable = drlvariable.SelectedItem.Value
            objdatos.obs = txtobs.Text
            objdatos.idusuario = lblusuario.Text
            objdatos.Registroservice()
            lblmsg.Text = "Escalamiento Service realizado con éxito"
            drlapn.SelectedValue = "- Seleccione -"
            drlqos.SelectedValue = "- Seleccione -"
            txtfcactivacion.Text = ""
            PanelGestion.Visible = True
            pnservice.Visible = False
            LblEscalamiento.Text = "Escala service"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drlinconsglobal_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlinconsglobal.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            'Inconsistencia
            objdatos.cargo = "Inconsistencia"
            objdatos.estado = drlinconsglobal.Text
            With drlincons
                .DataSource = objdatos.consultaincdatos
                .DataTextField = "inconsistencia"
                .DataValueField = "idtipoinc"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Dim Validacion As String = "False"
    Public Sub Busca_No_Gestion()
        Try
            Dim ObjDatos As New clscrmdatos
            Dim dts As New DataSet
            ObjDatos.min = lblmin.Text
            dts = ObjDatos.Consulta_No_Gestion()
            If dts.Tables(0).Rows.Count > 0 Then
                Validacion = "True"
            Else
                Validacion = "False"
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drllinea_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drllinea.SelectedIndexChanged
        Try

            Dim objdatos As New clsgeneral
            If lblBandeja.Text = "CONTROL VOZ" Then
                a = 20
            Else
                a = 21
            End If

            'servicio
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.identidad = a
            With drlservicio2
                .DataSource = objdatos.consultaservicio
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            'subservicio
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.mun = drlservicio2.SelectedItem.Text
            objdatos.identidad = a
            With drlsubservicio
                .DataSource = objdatos.consultasubservicio
                .DataTextField = "tipificacion"
                .DataValueField = "tipificacion"
                .DataBind()
            End With
            If drllinea.SelectedItem.Text = "- Seleccione -" Then
                'solicitud
                objdatos.localidad = drllinea.SelectedItem.Text
                objdatos.mun = drlservicio2.SelectedItem.Text
                objdatos.nombre = drlsubservicio.SelectedItem.Text
                objdatos.identidad = a
                With drlsolicitud
                    .DataSource = objdatos.consultasolicitud
                    .DataTextField = "detalle"
                    .DataValueField = "idreg"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub


    Protected Sub drlservicio2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlservicio2.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            If lblBandeja.Text = "CONTROL VOZ" Then
                a = 20
            Else
                a = 21
            End If
            'subservicio
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.mun = drlservicio2.SelectedItem.Text
            objdatos.identidad = a
            With drlsubservicio
                .DataSource = objdatos.consultasubservicio
                .DataTextField = "tipificacion"
                .DataValueField = "tipificacion"
                .DataBind()
            End With
            'solicitud
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.mun = drlservicio2.SelectedItem.Text
            objdatos.nombre = drlsubservicio.SelectedItem.Text
            objdatos.identidad = a
            With drlsolicitud
                .DataSource = objdatos.consultasolicitud
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub


    Protected Sub drlsubservicio_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlsubservicio.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            If lblBandeja.Text = "CONTROL VOZ" Then
                a = 20
            Else
                a = 21
            End If
            'solicitud
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.mun = drlservicio2.SelectedItem.Text
            objdatos.nombre = drlsubservicio.SelectedItem.Text
            objdatos.identidad = a
            With drlsolicitud
                .DataSource = objdatos.consultasolicitud
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub


    Protected Sub dtgasig_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtgasig.SelectedIndexChanged

    End Sub

    Protected Sub dtgasig_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtgasig.RowCommand
        Try
            Dim ObjDatos As New clscrmdatos
            If e.CommandName = "Seleccione" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                ObjDatos.idusuario = lblusuario.Text
                ObjDatos.caso = dtgasig.Rows(index).Cells(0).Text
                ObjDatos.Ingresa_N_Intentos()
                lblmsg.Text = "Numero de intentos Actualizado"
                traeprogramados()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub LinkBtnEscalaN3_Click(sender As Object, e As EventArgs) Handles LinkBtnEscalaN3.Click
        Try
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso a escalar y consultelo"
                Exit Sub
            End If
            Dim objdatos = New clscrmdatos
            objdatos.caso = txtcaso.Text
            objdatos.Validacion = 3
            objdatos.Consulta_NIvel3()
            If objdatos.cantidad > 0 Then
                lblmsg.Text = "El caso ya fue escalado a nivel 3"
                Exit Sub
            End If
            LinkBtnOcultaEscalaN3.Visible = True
            PanelEscalaN3.Visible = True
            LinkBtnEscalaN3.Visible = False

        Catch ex As Exception
            lblmsg.Text = "Se presneto error: " + ex.Message
        End Try
    End Sub

    Protected Sub LinkBtnOcultaEscalaN3_Click(sender As Object, e As EventArgs) Handles LinkBtnOcultaEscalaN3.Click
        Try
            LinkBtnOcultaEscalaN3.Visible = False
            PanelEscalaN3.Visible = False
            LinkBtnEscalaN3.Visible = True
        Catch ex As Exception
            lblmsg.Text = "Se presneto error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnGuarda_Esca_N3_Click(sender As Object, e As EventArgs) Handles BtnGuarda_Esca_N3.Click
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso para escalar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            If TxtFecha_Activacion.Text = "" Then
                lblmsg.Text = "Digite la fecha de activacion"
                Exit Sub
            Else
                objdatos.fcini = TxtFecha_Activacion.Text
            End If
            If TxtObs_Esca_N3.Text = "" Then
                lblmsg.Text = "Digite la Observacion"
                Exit Sub
            Else
                objdatos.ObsNivel3 = TxtObs_Esca_N3.Text
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.Validacion = 1
            objdatos.RegistroNivel3()
            lblmsg.Text = "Escalamiento a nivel 3 realizado con exito"
        Catch ex As Exception
            lblmsg.Text = "Se presneto error: " + ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            buscarinf()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub dtgcoincidentes_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgcoincidentes.PageIndexChanging
        Try
            dtgcoincidentes.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            buscarinf()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drlSegmento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlSegmento.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.Validacion = "Elemento"
            objdatos.localidad = drlCausa_Raiz.SelectedValue
            objdatos.nombre = drlSegmento.SelectedValue

            With drlElemento
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion3"
                .DataValueField = "id_tipificacion"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub

    Protected Sub drlElemento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlElemento.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.Validacion = "Tipo de falla"
            objdatos.localidad = drlElemento.SelectedValue
            With drlTipo_De_Falla
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion2"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try

    End Sub

    Protected Sub drlTipo_De_Falla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlTipo_De_Falla.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.Validacion = "Tipo Soporte"
            objdatos.localidad = drlTipo_De_Falla.SelectedValue
            With drltsoporte
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion2"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With

        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try

    End Sub

    Protected Sub drlCategoriaCierre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlCategoriaCierre.SelectedIndexChanged
        Try
            'Dim objdatos As New clsgeneral
            'objdatos.Validacion = "Estado"
            'objdatos.localidad = "Datos"
            'objdatos.nombre = drlCategoriaCierre.SelectedValue
            'With drltipificacionll
            '    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
            '    .DataTextField = "tipificacion2"
            '    .DataValueField = "tipificacion2"
            '    .DataBind()
            'End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try

    End Sub
    Protected Sub Btn_Habilita_Tecnologia_Click(sender As Object, e As EventArgs) Handles Btn_Habilita_Tecnologia.Click
        Try
            drlFtectolog.Enabled = True
            Btn_Habilita_Tecnologia.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub
    'Protected Sub Btn_Habilita_CicloF_Click(sender As Object, e As EventArgs) Handles Btn_Habilita_CicloF.Click
    '    Try
    '        drlCicloFacturacion.Enabled = True
    '        Btn_Habilita_CicloF.Visible = False
    '    Catch ex As Exception
    '        lblmsg.Text = "Se produjo error: " & ex.Message
    '    End Try
    'End Sub
    Protected Sub Btn_Habilita_Equipo_Click(sender As Object, e As EventArgs) Handles Btn_Habilita_Equipo.Click
        Try
            drlmarca.Enabled = True
            drlequipo.Enabled = True
            Btn_Habilita_Equipo.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub
    'Protected Sub Btn_Habilita_Version_S_O_Equipo_Click(sender As Object, e As EventArgs) Handles Btn_Habilita_Version_S_O_Equipo.Click
    '    Try
    '        TxtVersion_S_O_Equipo.Enabled = True
    '        Btn_Habilita_Version_S_O_Equipo.Visible = False
    '    Catch ex As Exception
    '        lblmsg.Text = "Se produjo error: " & ex.Message
    '    End Try
    'End Sub
    Protected Sub Btn_Habilita_Municipio_Click(sender As Object, e As EventArgs) Handles Btn_Habilita_Municipio.Click
        Try
            drldpto.Enabled = True
            drlmun.Enabled = True
            Btn_Habilita_Municipio.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Habilita_Barrio_Click(sender As Object, e As EventArgs) Handles Btn_Habilita_Barrio.Click
        Try
            txtbarrio.Enabled = True
            Btn_Habilita_Barrio.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Habilita_Fc_Utl_Caida_Click(sender As Object, e As EventArgs) Handles Btn_Habilita_Fc_Utl_Caida.Click
        Try
            txtultimc.Enabled = True
            drlfranja.Enabled = True
            Btn_Habilita_Fc_Utl_Caida.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Habilita_PQR_Click(sender As Object, e As EventArgs) Handles Btn_Habilita_PQR.Click
        Try
            TxtPQR.Enabled = True
            Btn_Habilita_PQR.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub

    Protected Sub Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedIndexChanged
        Try
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text = "FALSO" Then
                Drl_Split_Billing.Visible = True
            Else
                Drl_Split_Billing.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try

    End Sub

    Protected Sub drlCausa_Raiz_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drlCausa_Raiz.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            If drlCausa_Raiz.SelectedValue <> Nothing Then
                If drlCausa_Raiz.SelectedValue = "- Seleccione -" Then
                    drlSegmento.SelectedIndex = 0
                    drlElemento.SelectedIndex = 0
                    drlTipo_De_Falla.SelectedIndex = 0
                    drltsoporte.SelectedIndex = 0
                    drlgrupo.ClearSelection()
                    Exit Sub
                End If
                objdatos.Validacion = "Segmento"
                objdatos.localidad = drlCausa_Raiz.SelectedValue
                'If objdatos.localidad = "Diagnostico en curso" Then
                With drlSegmento
                    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                    .DataTextField = "tipificacion4"
                    .DataValueField = "tipificacion4"
                    .DataBind()
                    If drlSegmento.Items.Count >= 3 Then
                        drlSegmento.SelectedIndex = 0
                        drlElemento.SelectedIndex = 0
                        drlTipo_De_Falla.SelectedIndex = 0
                    Else
                        drlSegmento.SelectedIndex = 1
                    End If
                End With

                objdatos.Validacion = "Elemento"
                objdatos.localidad = drlCausa_Raiz.SelectedValue
                objdatos.nombre = drlSegmento.SelectedValue
                With drlElemento
                    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                    .DataTextField = "tipificacion3"
                    .DataValueField = "id_tipificacion"
                    .DataBind()
                    If drlElemento.Items.Count >= 3 Then
                        drlElemento.SelectedIndex = 0
                        drlTipo_De_Falla.SelectedIndex = 0
                    ElseIf drlSegmento.SelectedIndex = 0 Then
                        drlElemento.SelectedIndex = 0
                    Else
                        drlElemento.SelectedIndex = 1
                    End If
                End With

                objdatos.Validacion = "Tipo de falla"
                objdatos.localidad = objdatos.tipo
                With drlTipo_De_Falla
                    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                    .DataTextField = "tipificacion2"
                    .DataValueField = "cod_tipificacion"
                    .DataBind()
                    If drlTipo_De_Falla.Items.Count >= 3 Then
                        drlTipo_De_Falla.SelectedIndex = 0
                    ElseIf drlElemento.SelectedIndex = 0 Then
                        drlTipo_De_Falla.SelectedIndex = 0
                    Else
                        drlTipo_De_Falla.SelectedIndex = 1
                    End If
                End With
                objdatos.Validacion = "Tipo Soporte"
                objdatos.localidad = drlTipo_De_Falla.SelectedValue
                With drltsoporte
                    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                    .DataTextField = "tipificacion2"
                    .DataValueField = "cod_tipificacion"
                    .DataBind()
                    If drltsoporte.Items.Count >= 3 Then
                        drltsoporte.SelectedIndex = 0
                    ElseIf drlTipo_De_Falla.SelectedIndex = 0 Then
                        drltsoporte.SelectedIndex = 0
                    Else
                        drltsoporte.SelectedIndex = 1
                    End If

                End With
                objdatos.Validacion = "Grupo"
                objdatos.localidad = drlTipo_De_Falla.SelectedValue
                objdatos.nombre = drltsoporte.SelectedItem.Text
                With drlgrupo
                    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                    .DataTextField = "tipificacion1"
                    .DataValueField = "tipificacion1"
                    .DataBind()
                End With
                If drltsoporte.SelectedIndex = 0 Then
                    drlgrupo.SelectedValue = ""
                End If
                objdatos.Validacion = "Estado"
                objdatos.localidad = "Tipificacion"
                objdatos.nombre = drltsoporte.SelectedValue
                With drltipificacionll
                    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                    .DataTextField = "tipificacion2"
                    .DataValueField = "cod_tipificacion"
                    .DataBind()
                End With
            Else
                lblmsg.Text = "ingrese la Causa Raiz"
                Exit Sub
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub




    Protected Sub dtgprog_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles dtgprog.RowDataBound
        Try
            Dim FcActual As Date = Date.Now.ToString("dd/MM/yyyy")
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                If DataBinder.Eval(e.Row.DataItem, "fcprog") < FcActual Then
                    e.Row.ForeColor = Drawing.Color.Red
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub drl611_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drl611.SelectedIndexChanged
        If drl611.SelectedItem.Text = "- Seleccione -" Then
            TxtPercep_Serv.Enabled = False
        Else
            TxtPercep_Serv.Enabled = True
        End If
    End Sub

    Protected Sub drlinconsistencia_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlinconsistencia.SelectedIndexChanged
        Try
            If drlinconsistencia.SelectedItem.Text = "Otro" Then
                txtobsincon.Enabled = True
            Else
                txtobsincon.Enabled = False
                txtobsincon.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub

    Protected Sub Si_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkSi.CheckedChanged
        Try
            If chkSi.Checked = True Then
                txtnumalt.Visible = True
                txtnumalt.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub

    Protected Sub chkNo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkNo.CheckedChanged
        Try
            If chkNo.Checked = True Then
                txtnumalt.Visible = False
                txtnumalt.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub


    Protected Sub CargarServicio()
        Try
            Dim objdatos As New clsgeneral
            'linea
            If lblBandeja.Text = "CONTROL VOZ" Then
                a = 20
            Else
                a = 21
            End If
            objdatos.identidad = a
            With drllinea
                .DataSource = objdatos.consultalineadt
                .DataTextField = "tipo"
                .DataValueField = "tipo"
                .DataBind()
            End With
        Catch ex As Exception

        End Try
    End Sub



End Class