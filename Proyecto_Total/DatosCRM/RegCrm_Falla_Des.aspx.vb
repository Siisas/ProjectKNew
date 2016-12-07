Public Class RegCrm_Falla_Des
    Inherits System.Web.UI.Page

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
                Consulta_Asignados()
                Cargar_Drl()
                LblPQR.Text = objdatos.Consulta_Numero_PQR().Tables(0).Rows(0).Item("Nombre")
                ''''' INICIO SEGURIDAD ACCESO URL '''''
                Dim objGeneral As New clsgeneral
                objGeneral.DtsSeguridad = Session("dtsSeguridad")
                objGeneral.Consulta_Proyecto_Seguridad()
                objGeneral.PaginaAcceso = "~" + Mid(Request.RawUrl, Integer.Parse(objGeneral.nombreentidad))
                objGeneral.idusuario = CType(Session("permisos"), clsusuario).usuario
                objGeneral.PermisosUrl()
                ''''' FIN SEGURIDAD ACCESO URL '''''    
            End If
            'Bandeja()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub


    Protected Sub Consulta_Asignados()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.idusuario = lblusuario.Text
            objdatos.Validacion = "Asignados"

            Session("Asignados") = objdatos.Consulta_Asignado_Fideliza
            dtgprog.DataSource = Session("Asignados")
            dtgprog.DataBind()
            lblcasos_asig.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Public Sub Cargar_Drl()
        Try
            Dim objdatos As New clsgeneral

            '--------inconsistencia encuesta---------'
            With drlinconsistencia
                .DataSource = objdatos.Consulta_inconsistencia_encuesta
                .DataTextField = "Nombre"
                .DataValueField = "Cod_BD_Datos_Complemento"
                .DataBind()
            End With
            '-----------------'

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
            With drlvariableCatalogo
                objdatos.idusuario = 6
                .DataSource = objdatos.consultadiagnostico
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
            
            'With drlSegmentacion_linea
            '    objdatos.Validacion = "Datos_Fa_Des_Segmentacion_linea"
            '    .DataSource = objdatos.Consulta_Complemento_General
            '    .DataTextField = "nombre"
            '    .DataValueField = "nombre"
            '    .DataBind()
            'End With
            With drlingclaro
                objdatos.idtip = 1
                .DataSource = objdatos.consultaing
                .DataTextField = "ingclaro"
                .DataValueField = "ingclaro"
                .DataBind()
            End With
           
            
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
            'Marca
            With drlmarca
                .DataSource = objdatos.consultamarca
                .DataTextField = "marca"
                .DataValueField = "marca"
                .DataBind()
            End With
            'Equipo
            objdatos.estado = drlmarca.SelectedItem.Value
            With drlequipo
                .DataSource = objdatos.consultaequipo
                .DataTextField = "equipo"
                .DataValueField = "equipo"
                .DataBind()
            End With
            'Condicion de Uso
            With drlFtectolog
                objdatos.idusuario = 4
                .DataSource = objdatos.consultadiagnostico
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
            'divipola - dpto Departamento
            With drldpto
                objdatos.idtip = 1
                .DataSource = objdatos.consultadpto
                .DataTextField = "nombredpto"
                .DataValueField = "coddpto"
                .DataBind()
            End With
            'Municipio
            objdatos.dpto = drldpto.SelectedItem.Value
            With drlmun
                objdatos.idtip = 1
                .DataSource = objdatos.consultamun
                .DataTextField = "nombremun"
                .DataValueField = "coddiv"
                .DataBind()
            End With

            ''''''''''''''''''' Limpia despues de Registro de Falla de Red o de Inconsistencia
            'Visibilidad Inconsistenacia
            Pninc.Visible = False
            LinkBtn_Inconsistencia.Visible = True
            LinkBtn_Oculta_Inconsistencia.Visible = False
            'Visibilidad Falla de Red
            Pnfallared.Visible = False
            LinkBtn_Falla_Red.Visible = True
            LinkBtn_Oculta_Falla_Red.Visible = False

            'Visibilidad Falla escal service
            Pnl_Esc_Service.Visible = False
            LinkBtn_Esc_Service.Visible = True
            LinkBtn_Ocultar_Esc_Service.Visible = False

            'caracteristicas
            With drlFcaract
                .DataSource = objdatos.consultacaractdat
                .DataTextField = "desccarac"
                .DataValueField = "idcarac"
                .DataBind()
            End With
            '*Catalogo de Servicio 3 drl
            'Tipo PQR Adicional
            objdatos.Validacion = "Tipo PQR Adicional"
            With drlTipo_Pqr_Adicional
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            'Intencion Des Por Falla
            objdatos.Validacion = "Intencion Des Por Falla"
            With drlIntension_Des_Por_Fallaen
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            'Tipo Proceso Linea
            objdatos.Validacion = "Tipo Proceso Linea"
            With drlTipo_Proceso_Linea
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            'Tipo PQR
            objdatos.Validacion = "Tipo PQR"
            With drlTipo_PQR
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            '*CATALOGO DE DIAGNOSTICO
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


            'Segmento
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
            objdatos.nombre = drlSegmento.SelectedItem.Text
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

            ''''''''''''''''''CATEGORIA DE CIERRE''''''''''''''''''''''
            'tipo soporte'
            objdatos.Validacion = "Tipo Soporte"
            objdatos.localidad = drlTipo_De_Falla.SelectedValue
            With drltsoporte
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion2"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With

            'grupo de tipificación
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


            'objdatos.Validacion = "Categoria de cierre"
            'With drlCategoriaCierre
            '    .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
            '    .DataTextField = "tipificacion"
            '    .DataValueField = "idreg"
            '    .DataBind()
            'End With
            'Categoria de cierre lbl
            'LblCategoriaCierre.Text = ""


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

            Dim objcargas As New clsgeneral
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



        Catch ex As Exception
            lblmsg.Text = "Se presento error: " & ex.Message
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
    Public Sub Limpia_Herramientas_Cargadas()
        Try
            drlTipo_Pqr_Adicional.SelectedValue = "- Seleccione -"
            drlTipo_Pqr_Adicional.Enabled = True
            drlIntension_Des_Por_Fallaen.SelectedValue = "- Seleccione -"
            drlIntension_Des_Por_Fallaen.Enabled = True
            drlTipo_Proceso_Linea.SelectedValue = "- Seleccione -"
            drlTipo_Proceso_Linea.Enabled = True
            drlAplica_Fidelizacion.SelectedValue = "- Seleccione -"
            drlAplica_Fidelizacion.Enabled = True
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub BuscarInf()
        Try
            Dim objdatos As New clscrmdatos
            LblmsgOtros.Text = ""
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el Caso que desea consultar"
            Else
                If txtcaso.Text <> "" Then
                    objdatos.caso = txtcaso.Text
                End If
                dtggeneral.DataSource = objdatos.Consulta_Inf_Caso_Falla_Desactivacion_D_V
                dtggeneral.DataBind()
                lblcuenta.Text = objdatos.cantidad
                If objdatos.cantidad > 0 Then
                    lblcliente.Text = objdatos.cliente
                    lbldocumento.Text = objdatos.documento
                    lblmin.Text = objdatos.min
                    lblplan.Text = objdatos.plan
                    lblBandeja.Text = objdatos.Bandeja
                    lbllugar.Text = objdatos.lugar
                    Lblfc_ingreso.Text = objdatos.casfcregistro
                    lblcaso.Text = objdatos.caso
                    LblCasoClaro.Text = objdatos.Caso_Claro
                    lblobs611.Text = objdatos.obsini
                    lblestado.Text = objdatos.tipificacion
                    lblestadon3.Text = objdatos.estadoinc
                    lblfcingn3.Text = objdatos.fcingn3
                    LblCall_Remite.Text = objdatos.archivo
                    lblNumero_Alterno.Text = objdatos.telalt
                    lblmsg.Text = ""
                    If lblfcingn3.Text = " " Then
                        Btn_Guardar.Enabled = False
                        lblmsg.Text = "El caso no ha sido identificado como asignado a Nivel 3, solicite a Nivel 3 la identificación antes de registrar alguna gestión"
                    Else
                        Btn_Guardar.Enabled = True
                        lblmsg.Text = ""
                        LblmsgOtros.Text = ""
                    End If
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
                    If drlTipo_Pqr_Adicional.Enabled = False Or drlIntension_Des_Por_Fallaen.Enabled = False Or drlTipo_Proceso_Linea.Enabled = False Or drlAplica_Fidelizacion.Enabled = False Then
                        Limpia_Herramientas_Cargadas()
                    End If
                    objdatos.Consulta_Diganostico_Carga_Fidelizacion()
                    If objdatos.Tipo_PQR_Adicional <> "" Then
                        drlTipo_Pqr_Adicional.SelectedValue = objdatos.Tipo_PQR_Adicional
                        drlTipo_Pqr_Adicional.Enabled = False
                    Else
                        drlTipo_Pqr_Adicional.Enabled = True
                    End If
                    If objdatos.Intension_Des_Por_Falla <> "" Then
                        drlIntension_Des_Por_Fallaen.SelectedValue = objdatos.Intension_Des_Por_Falla
                        drlIntension_Des_Por_Fallaen.Enabled = False
                    Else
                        drlIntension_Des_Por_Fallaen.Enabled = True
                    End If
                    If objdatos.Tipo_Proceso_Linea <> "" Then
                        drlTipo_Proceso_Linea.SelectedValue = objdatos.Tipo_Proceso_Linea
                        drlTipo_Proceso_Linea.Enabled = False
                    Else
                        drlTipo_Proceso_Linea.Enabled = True
                    End If
                    If objdatos.aplicaajuste <> "" Then
                        drlAplica_Fidelizacion.SelectedValue = objdatos.aplicaajuste
                        drlAplica_Fidelizacion.Enabled = False
                    Else
                        drlAplica_Fidelizacion.Enabled = True
                    End If
                    objdatos.Consulta_Campos_Fideliza()
                    If objdatos.marca <> "" And objdatos.marca <> " " And objdatos.marca <> "0" Then
                        drlmarca.SelectedValue = objdatos.marca
                        drlmarca.Enabled = False
                        drlmarca_SelectedIndexChanged(1, Nothing)
                        drlequipo.SelectedValue = objdatos.equipo
                        drlequipo.Enabled = False
                        Btn_act_equipo.Enabled = True
                    Else
                        Btn_act_equipo.Enabled = False
                        drlmarca.Enabled = True
                        drlequipo.Enabled = True
                    End If
                    If objdatos.dpto <> "" And objdatos.dpto <> " " And objdatos.dpto <> "0" Then
                        drldpto.SelectedValue = objdatos.dpto
                        drldpto.Enabled = False
                        drldpto_SelectedIndexChanged(1, Nothing)
                        drlmun.SelectedValue = objdatos.mun
                        drlmun.Enabled = False
                        Btn_act_municipio.Enabled = True
                    Else
                        Btn_act_municipio.Enabled = False
                        drldpto.Enabled = True
                        drldpto.SelectedValue = 0
                        drldpto_SelectedIndexChanged(1, Nothing)
                        drlmun.Enabled = True
                    End If

                Else
                    lblmsg.Text = "No se han encontrado registros coincidentes con el caso: " + txtcaso.Text
                    lblcliente.Text = ""
                    lbldocumento.Text = ""
                    lblmin.Text = ""
                    lblplan.Text = ""
                    lblBandeja.Text = ""
                    lbllugar.Text = ""
                    Lblfc_ingreso.Text = ""
                    lblcaso.Text = ""
                    LblCasoClaro.Text = ""
                    lblobs611.Text = ""
                    lblestado.Text = ""
                    lblestadon3.Text = ""
                    lblfcingn3.Text = ""
                    LblCall_Remite.Text = ""
                    lblNumero_Alterno.Text = ""
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBuscar.Click
        Try
            BuscarInf()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Indentifica_N3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Indentifica_N3.Click
        Try
            LblmsgOtros.Text = ""
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            If txtfcingn3.Text = "" Then
                lblmsg.Text = "Digite la fecha en la que ingresa el caso a Nivel 3"
                Exit Sub
            Else
                If Convert.ToDateTime(txtfcingn3.Text) > Today Then
                    lblmsg.Text = "La fecha de bitácora no puede ser mayor que hoy"
                    Exit Sub
                Else
                    objdatos.fcingn3 = txtfcingn3.Text
                End If
            End If
            If drlingclaro.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Eliga el Consultor que asigna el caso en Claro"
                Exit Sub
            Else
                objdatos.ingn3 = drlingclaro.SelectedItem.Text
            End If
            If chkpqr.Checked = True Then
                objdatos.pqr = "SI"
            Else
                objdatos.pqr = "NO"
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.Modificacion_Caso_N3_Falla_Desactivacion_D_V()
            lblmsg.Text = "Caso '" + txtcaso.Text + "' actualizado como Nivel 3"
            txtfcingn3.Text = ""
            chkpqr.Checked = False
            Dim ObjGeneral As New clsgeneral
            With drlingclaro
                ObjGeneral.idtip = 1
                .DataSource = ObjGeneral.consultaing
                .DataTextField = "ingclaro"
                .DataValueField = "ingclaro"
                .DataBind()
            End With
            txtingclaro.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Guardar_NConsultor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Guardar_NConsultor.Click
        Try
            LblmsgOtros.Text = ""
            Dim objdatos As New clscrmdatos
            Dim objdatosgr As New clsgeneral
            If txtingclaro.Text = "" Then
                lblmsg.Text = "Digite el nuevo consultor a registrar"
                Exit Sub
            Else
                objdatos.ingn3 = txtingclaro.Text
            End If
            objdatos.registroingclaro()
            lblmsg.Text = "Consultor ingresado con éxito"
            txtingclaro.Text = ""
            With drlingclaro
                objdatosgr.idtip = 1
                .DataSource = objdatosgr.consultaing
                .DataTextField = "ingclaro"
                .DataValueField = "ingclaro"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub guardadiagnostico()
        Try
            Dim objdatos As New clscrmdatos
            If drlTipo_PQR.SelectedItem.Text <> "- Seleccione -" Or drlCausa_Raiz.SelectedItem.Text <> "- Seleccione -" Or drlCategoriaCierre.SelectedItem.Text <> "- Seleccione -" Or drlsolicitud.SelectedItem.Text <> "- Seleccione -" Or drltipofalla.SelectedItem.Text <> "- Seleccione -" Or drlvariableCatalogo.SelectedItem.Text <> "- Seleccione -" Or drlmun.SelectedItem.Text <> "- SELECCIONE -" Or drlTipo_Pqr_Adicional.SelectedItem.Text <> "- Seleccione -" Or drlIntension_Des_Por_Fallaen.SelectedItem.Text <> "- Seleccione -" Or drlTipo_Proceso_Linea.SelectedItem.Text <> "- Seleccione -" Or drlAplica_Fidelizacion.SelectedItem.Text <> "- Seleccione -" Then

                '-----------Inconsistencia-------------'
                If drlinconsistencia.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.inconsistencia_encuesta = ""
                ElseIf drlinconsistencia.SelectedItem.Text <> "Otro" Then
                    objdatos.inconsistencia_encuesta = drlinconsistencia.SelectedItem.Text
                Else
                    objdatos.inconsistencia_encuesta = txtobsincon.Text
                End If
                '---------------------------------------'


                If drlTipo_PQR.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Tipo_PQR = ""
                Else
                    objdatos.Tipo_PQR = drlTipo_PQR.SelectedItem.Text
                End If

                'Nuevo
                If drlTipo_De_Falla.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Causa_Raiz = "0"
                Else
                    objdatos.Causa_Raiz = drlTipo_De_Falla.SelectedValue
                End If
                'Se remplaza
                'If drlCausa_Raiz.SelectedItem.Text = "- Seleccione -" Then
                '    objdatos.Causa_Raiz = 0
                'Else
                '    objdatos.Causa_Raiz = drlCausa_Raiz.SelectedValue
                'End If

                If drlCategoriaCierre.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Categoria_Cierre = 0
                Else
                    objdatos.Categoria_Cierre = drlCategoriaCierre.SelectedValue
                End If
                objdatos.Tipo_Cliente = ""
                objdatos.Modalidad = ""
                If drlsolicitud.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.solicitud = "0"
                Else
                    objdatos.solicitud = drlsolicitud.SelectedItem.Value
                End If
                If drltipofalla.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.tipofalla = "0"
                Else
                    objdatos.tipofalla = drltipofalla.SelectedItem.Value
                End If
                If drlvariableCatalogo.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.diagvariable = "0"
                Else
                    objdatos.diagvariable = drlvariableCatalogo.SelectedItem.Value
                End If
                If drlmun.SelectedItem.Text = "- SELECCIONE -" Then
                    objdatos.mun = "0"
                Else
                    objdatos.mun = drlmun.SelectedItem.Value
                End If
                If drlTipo_Pqr_Adicional.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Tipo_PQR_Adicional = ""
                Else
                    objdatos.Tipo_PQR_Adicional = drlTipo_Pqr_Adicional.SelectedItem.Value
                End If
                If drlIntension_Des_Por_Fallaen.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Intension_Des_Por_Falla = ""
                Else
                    objdatos.Intension_Des_Por_Falla = drlIntension_Des_Por_Fallaen.SelectedItem.Value
                End If
                If drlTipo_Proceso_Linea.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Tipo_Proceso_Linea = ""
                Else
                    objdatos.Tipo_Proceso_Linea = drlTipo_Proceso_Linea.SelectedItem.Value
                End If
                If drlAplica_Fidelizacion.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.aplicaajuste = ""
                Else
                    objdatos.aplicaajuste = drlAplica_Fidelizacion.SelectedItem.Value
                End If
                objdatos.Validacion = "Diagnostico Dilo y Fidelizacion"
                objdatos.Bandeja = "Fidelizacion"
                objdatos.caso = lblcaso.Text
                objdatos.registrodiag()
                txtbarrio.Text = ""
                Cargar_Drl()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try

    End Sub


    'Public Sub Registro_Services_Segun_Tipificacion()
    '    Try
    '        Dim objdatos As New clscrmdatos
    '        '''''''''''''' Inicio Identifica si el caso debe registrarse en services ''''''''''''''
    '        objdatos.nompaquete = drltipificacionll.SelectedItem.Text
    '        If objdatos.ConsultaEscalarService().Tables(0).Rows.Count > 0 Then
    '            objdatos.caso = LblCasoClaro.Text
    '            objdatos.idusuario = lblusuario.Text
    '            objdatos.obs = txtobs.Text
    '            objdatos.registrofallaservice()
    '        End If
    '        '''''''''''''' Fin Identifica si el caso debe registrarse en services ''''''''''''''
    '    Catch ex As Exception
    '        lblmsg.Text = "Se produjo error " & ex.Message
    '    End Try
    'End Sub
    Protected Sub Btn_Guardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Guardar.Click
        Try
            LblmsgOtros.Text = ""
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = lblcaso.Text
            End If

            objdatos.Validacion = 2
            objdatos.ConsultarEstados()
            If objdatos.tipificacion.Contains("Cerrado") Then
                lblmsg.Text = "¡El Caso que desea guardar se encuentra Cerrado!"
                Exit Sub
            Else
                objdatos.Validacion = Nothing
            End If

            If lblcaso.Text = "" Then
                lblmsg.Text = "Consulte el caso para continuar con la gestion"
                Exit Sub
            End If

            If drltipificacionll.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione la tipificación de la llamada"
                Exit Sub
            Else
                objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            End If

            If drlCategoriaCierre.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una categoria de cierre"
                Exit Sub
            End If


            If txtobs.Text = "" Then
                lblmsg.Text = "Digite la observación de atención al caso"
                Exit Sub
            Else
                objdatos.obs = txtobs.Text
            End If

            If (Date.Parse(Lblfc_ingreso.Text) >= Date.Parse("01/09/2015")) And (drlTipo_Pqr_Adicional.SelectedItem.Text = "- Seleccione -" Or drlIntension_Des_Por_Fallaen.SelectedItem.Text = "- Seleccione -" Or drlTipo_Proceso_Linea.SelectedItem.Text = "- Seleccione -") Then
                If drlTipo_Proceso_Linea.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una opcion en la lista 'Tipo de proceso de la línea'"
                End If
                If drlIntension_Des_Por_Fallaen.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una opcion en la lista 'Intensión de Desactivación por falla en'"
                End If
                If drlTipo_Pqr_Adicional.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una opcion en la lista 'Tipo pqr adicional'"
                End If
                Exit Sub
            End If
            If drlAplica_Fidelizacion.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opcion en la lista 'Aplica fidelizacion'"
                Exit Sub
            End If

            If drltipificacionll.SelectedItem.Text.Contains("Escalar") Then
                If Rdb_Contacto.SelectedValue = "" Then
                    lblmsg.Text = "Seleccione si realizo contacto con el cliente"
                    Exit Sub
                Else
                    objdatos.Contacto_cliente = Rdb_Contacto.SelectedValue
                End If
            End If


            If (drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD") And LblEscalamiento.Text = Nothing Then
                lblmsg.Text = "Antes de que realice el registro de gestion, debe realizar el escalamiento a falla de red o services"
                Exit Sub
            Else
                If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar CPD" And LblEscalamiento.Text = "Falla de red" Then
                    lblmsg.Text = "Si reporto falla de red el estado del caso debe ser Solicitud Escalar CPD"
                    Exit Sub
                End If
                If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar SD" And LblEscalamiento.Text = "Escalamiento" Then
                    lblmsg.Text = "Si realizó Escalamiento Service el estado del caso debe ser Solicitud Escalar SD"
                    Exit Sub
                End If
            End If
            If drltipificacionll.SelectedItem.Text <> "No Contactado" Then
                If drltipolinea.SelectedItem.Value = "- Seleccione -" Then
                    lblmsg.Text = "Sleccione el tipo de la línea"
                    Exit Sub
                Else
                    objdatos.tlinea = drltipolinea.SelectedItem.Text
                End If
                If drltsoporte.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione el tipo de soporte brindado"
                    Exit Sub
                Else
                    objdatos.tiposoporte = drltsoporte.SelectedItem.Text
                End If

                If drlequipo.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Elija la marca y el equipo actual antes de generar una falla de red"
                    Exit Sub
                Else
                    objdatos.equipo = drlequipo.SelectedItem.Value
                End If
                'If drlmun.SelectedItem.Text = "- SELECCIONE -" And (drltipificacionll.SelectedItem.Text = "Cerrado" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD") Then
                If drlmun.SelectedItem.Text = "- SELECCIONE -" Then
                    lblmsg.Text = "Elija el departamento y el municipio antes de realizar el registro"
                    Exit Sub
                Else
                    objdatos.equipo = drlequipo.SelectedItem.Value
                End If
                If TxtEscalamiento_CPD_SD.Text = "" Then
                    objdatos.Escalamiento_CPD_SD = ""
                Else
                    objdatos.Escalamiento_CPD_SD = TxtEscalamiento_CPD_SD.Text
                End If
                'If drlSegmentacion_linea.SelectedItem.Text = "- Seleccione -" Then
                '    lblmsg.Text = "Elija la segmentacion de la linea"
                '    Exit Sub
                'Else
                '    objdatos.Segmentacion_Linea = drlSegmentacion_linea.SelectedItem.Value
                'End If

                objdatos.Segmentacion_Linea = "0"

                If TxtCorreo.Text = "" Then
                    lblmsg.Text = "Digite un correo"
                    Exit Sub
                Else
                    objdatos.email = TxtCorreo.Text
                End If
                If drlTipo_PQR.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione un tipo PQR"
                    Exit Sub
                End If
                If drlCausa_Raiz.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una causa raiz de falla"
                    Exit Sub
                End If
                If drlCategoriaCierre.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una categoria de cierre"
                    Exit Sub
                End If
                If drlsolicitud.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una Solicitud / Tipo Falla (VOZ DEL CLIENTE - Solicitud / Tipo Falla)"
                    Exit Sub
                End If
                If drltipificacionll.SelectedItem.Text = "Cerrado" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD" Or drltipificacionll.SelectedItem.Text = "Gestionado" Then
                    If drlreclamoppal.SelectedItem.Text = "- Seleccione -" Or drltipofalla.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Si el caso es cerrado, Solicitud Escalar o gestionado, debe elegir el reclamo principal y el tipo de falla (CATALOGO DE DIAGNOSTICO - Reclamo Principal & Tipo Falla Rec Ppal)"
                        Exit Sub
                    End If
                End If

                For Each drResultado As Data.DataRow In objdatos.Consultar_Estados_Escalar_Falla_Fideliza.Tables(0).Rows
                    If drResultado("Nombre").ToString = drltipificacionll.SelectedItem.Text And LblEscalamiento.Text = Nothing Then
                        ''''Consulta si ya existe algun registro para evitar conflicto con PK- © CDRR.
                        Dim ObjDataCons As New clscrmdatos
                        ObjDataCons.Validacion = "Falla Red"
                        ObjDataCons.caso = LblCasoClaro.Text
                        ObjDataCons.Consulta_Registro_Falla_Red_Incinsistencia_Otro()
                        If ObjDataCons.cantidad > 0 Then
                            'LblmsgOtros.Text = "El Caso Claro: " + LblCasoClaro.Text + " ya tiene un registro de falla de red"
                            LblEscalamiento.Text = "Falla de red"
                            lblmsg.Text = "Realice nuevamente la accion de guardar ya que el Caso Claro: " + LblCasoClaro.Text + " ya tiene un registro de falla de red"
                            Exit Sub
                        End If
                    End If
                Next
            Else
                If drltipificacionll.SelectedItem.Text = "No Contactado" And drltsoporte.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione el tipo de soporte brindado (CIERRE DE LLAMADA - Tipo Soporte)"
                    Exit Sub
                Else
                    objdatos.tiposoporte = drltsoporte.SelectedItem.Text
                End If
                objdatos.obs = txtobs.Text
                objdatos.tipificacion = drltipificacionll.SelectedItem.Text
                If (Date.Parse(Lblfc_ingreso.Text) >= Date.Parse("01/09/2015")) And (drlTipo_Pqr_Adicional.SelectedItem.Text = "- Seleccione -" Or drlIntension_Des_Por_Fallaen.SelectedItem.Text = "- Seleccione -" Or drlTipo_Proceso_Linea.SelectedItem.Text = "- Seleccione -") Then
                    If drlTipo_Proceso_Linea.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una opcion en la lista 'Tipo de proceso de la línea'"
                    End If
                    If drlIntension_Des_Por_Fallaen.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una opcion en la lista 'Intensión de Desactivación por falla en'"
                    End If
                    If drlTipo_Pqr_Adicional.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una opcion en la lista 'Tipo pqr adicional'"
                    End If
                    Exit Sub
                End If
            End If
            If TxtPQR.Text = "" Then
                lblmsg.Text = "Ingrese el consecutivo PQR"
                Exit Sub
            Else
                objdatos.pqr = Int64.Parse(LblPQR.Text + TxtPQR.Text)
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

            If drltipificacionll.SelectedItem.Text = "Programado" Then
                If txtfc_programado.Text = "" Then
                    lblmsg.Text = "Seleccione una fecha de programacion"
                    Exit Sub
                Else
                    If txtfc_programado.Text < DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") Then
                        lblmsg.Text = "La fecha debe ser mayor a la actual"
                        Exit Sub
                    End If
                    objdatos.horaprog = txtfc_programado.Text
                End If
            Else
                objdatos.horaprog = Nothing
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

            objdatos.idusuario = lblusuario.Text
            If Session("PermiteGuardar") <> Nothing Then
                '''''Registro de gestion
                objdatos.RegistroCrm_Falla_Desactivacion_D_V()
            Else
                lblmsg.Text = "La acción esta inhabilita o genera duplicidad consulta de nuevo el caso para validar la gestión y permitir el registro"
                Exit Sub
            End If

            '---Autoasignar caso---'
            If drltipificacionll.SelectedItem.Text = "Programado" Then
                If drlLibera.SelectedItem.Text = "SI" Then
                    objdatos.caso = lblcaso.Text
                    objdatos.Validacion = "Libera"
                    objdatos.asignacionFideliza()
                ElseIf drlLibera.SelectedItem.Text = "NO" Then
                    objdatos.caso = lblcaso.Text
                    objdatos.idusuario = lblusuario.Text
                    objdatos.Validacion = "Autoasigna"
                    objdatos.asignacionFideliza()
                End If
            End If



            If lblestado.Text.ToUpper = "BUZON" Then
                If (drltipificacionll.SelectedItem.Text.Contains("Solicitud") Or drltipificacionll.SelectedItem.Text = "Cerrado") Then
                    objdatos.Actualiza_Bandejan_Falla_Desactivacion_D_V()
                End If
            Else
                objdatos.Actualiza_Bandejan_Falla_Desactivacion_D_V()
            End If
            guardadiagnostico()





            BuscarInf()
            Consulta_Gestion()
            lblmsg.Text = "Seguimiento ingresado con éxito al caso: " + txtcaso.Text
            'Bandeja()
            lblcliente.Text = ""
            lbldocumento.Text = ""
            lblmin.Text = ""
            lblplan.Text = ""
            lblBandeja.Text = ""
            lbllugar.Text = ""
            Lblfc_ingreso.Text = ""
            lblcaso.Text = ""
            LblCasoClaro.Text = ""
            lblobs611.Text = ""
            lblestado.Text = ""
            lblNumero_Alterno.Text = ""
            txtnumalt.Enabled = False
            chkSi.Checked = False
            chkNo.Checked = False

            txtcaso.Text = ""
            drltipolinea.SelectedValue = "- Seleccione -"
            txtnumalt.Text = ""
            txtobs.Text = ""
            lblestadon3.Text = ""
            lblfcingn3.Text = ""
            TxtEscalamiento_CPD_SD.Text = ""
            TxtCorreo.Text = ""
            TxtPQR.Text = ""
            LblEscalamiento.Text = ""
            If drlmun.Enabled = False Then
                drlmun.Enabled = True
            End If
            If drlequipo.Enabled = False Then
                drlequipo.Enabled = True
            End If
            If drlmarca.Enabled = False Then
                drlmarca.Enabled = True
            End If
            If drldpto.Enabled = False Then
                drldpto.Enabled = True
            End If
            If Btn_act_equipo.Enabled Then
                Btn_act_equipo.Enabled = False
            End If
            If Btn_act_municipio.Enabled Then
                Btn_act_municipio.Enabled = False
            End If

            '----Inconsistencia------'
            drlinconsistencia.SelectedValue = 0
            txtobsincon.Text = ""
            txtobsincon.Enabled = False
            '----------'

            drlmun.SelectedItem.Value = "0"
            drlmun.SelectedValue = "0"
            drlmarca.SelectedItem.Value = "- Seleccione -"
            drlmarca.SelectedValue = "- Seleccione -"
            drlequipo.SelectedItem.Value = "- Seleccione -"
            drlequipo.SelectedValue = "- Seleccione -"
            drldpto.SelectedItem.Value = 0
            drldpto.SelectedValue = 0

            txtfc_programado.Text = ""
            drlLibera.SelectedValue = "0"
            Rdb_Contacto.Enabled = False
            Rdb_Contacto.ClearSelection()


            Consulta_Asignados()
            Session("PermiteGuardar") = Nothing
            Cargar_Drl()
            Limpia_Herramientas_Cargadas()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    'Protected Sub drlgrupo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlgrupo.SelectedIndexChanged
    '    Try
    '        Dim objdatos As New clsgeneral
    '        objdatos.tipo = drlgrupo.SelectedItem.Value
    '        With drltsoporte
    '            .DataSource = objdatos.consultatsoportegrupo
    '            .DataTextField = "escenario"
    '            .DataValueField = "escenario"
    '            .DataBind()
    '        End With
    '    Catch ex As Exception
    '        lblmsg.Text = "Se produjo error " & ex.Message
    '    End Try
    'End Sub
    Protected Sub LinkBtn_Inconsistencia_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkBtn_Inconsistencia.Click
        Try
            If LblCasoClaro.Text = "" Then
                LblmsgOtros.Text = "Consulte el caso antes de generar una Inconsistencia, Si el caso ya se consulto y no se cargo el 'Caso Claro', no se podra generar la Inconsistencia"
                Exit Sub
            Else
                ''''Visibilidad Inconsistenacia
                Pninc.Visible = True
                LinkBtn_Inconsistencia.Visible = False
                LinkBtn_Oculta_Inconsistencia.Visible = True
                ''''Visibilidad Falla de Red
                Pnfallared.Visible = False
                LinkBtn_Falla_Red.Visible = True
                LinkBtn_Oculta_Falla_Red.Visible = False

                Pnl_Esc_Service.Visible = False
                LinkBtn_Esc_Service.Visible = True
                LinkBtn_Ocultar_Esc_Service.Visible = False

                LblmsgOtros.Text = ""
            End If
        Catch ex As Exception
            LblmsgOtros.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub LinkBtn_Oculta_Inconsistencia_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkBtn_Oculta_Inconsistencia.Click
        Try
            Pninc.Visible = False
            LinkBtn_Inconsistencia.Visible = True
            LinkBtn_Oculta_Inconsistencia.Visible = False
            LblmsgOtros.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Guardar_Inconsistencia_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Guardar_Inconsistencia.Click
        Try
            ''''Consulta si ya existe algun registro para evitar conflicto con PK- © CDRR.
            Dim ObjDataCons As New clscrmdatos
            ObjDataCons.Validacion = "Inconsistencia"
            ObjDataCons.caso = LblCasoClaro.Text
            ObjDataCons.Consulta_Registro_Falla_Red_Incinsistencia_Otro()
            If ObjDataCons.cantidad > 0 Then
                LblmsgOtros.Text = "El Caso Claro: " + LblCasoClaro.Text + " ya tiene un registro de inconsistencai"
                Exit Sub
            End If

            lblmsg.Text = ""
            Dim objdatos As New clscrmdatos
            If drlincons.SelectedItem.Value = 0 Then
                LblmsgOtros.Text = "Elija el tipo de inconsistencia a reportar"
                Exit Sub
            Else
                objdatos.incidente = drlincons.SelectedItem.Value
            End If
            If drlnivel.SelectedItem.Value <> "0" Then
                objdatos.barrio = drlnivel.SelectedItem.Value
            Else
                LblmsgOtros.Text = "Elija el nivel que genera la inconsistencia, verifique"
                Exit Sub
            End If
            If txtobsinc.Text = "" Then
                LblmsgOtros.Text = "Digite la observación de la inconsistencia"
                Exit Sub
            Else
                objdatos.obs = txtobsinc.Text
            End If
            If txt_registro_numerico.Text <> "" Then
                objdatos.Num_Intento = txt_registro_numerico.Text
            End If
            objdatos.caso = LblCasoClaro.Text
            objdatos.idusuario = lblusuario.Text
            objdatos.estadoinc = "Aprobado"
            objdatos.registroinc()
            lblmsg.Text = "Inconsistencia reportada con exito, Caso Claro: " + LblCasoClaro.Text
            LblmsgOtros.Text = ""
            drlnivel.SelectedValue = "0"
            txtobsinc.Text = ""
            txt_registro_numerico.Text = ""
            drlinconsglobal.SelectedValue = 0
            drlinconsglobal_SelectedIndexChanged(1, Nothing)
        Catch ex As Exception
            LblmsgOtros.Text = "Se produjo error " & ex.Message
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
    'Sub Bandeja()
    '    Try
    '        Dim objdatos As New clscrmdatos
    '        objdatos.idusuarioasignado = lblusuario.text
    '        objdatos.Validacion = 5
    '        Session("Nivel3") = objdatos.Consulta_NIvel3()
    '        dtgprog.DataSource = Session("Nivel3")
    '        dtgprog.DataBind()
    '    Catch ex As Exception
    '        lblmsg.Text = "Se presento error: " + ex.Message
    '    End Try
    'End Sub

    Protected Sub dtgprog_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgprog.PageIndexChanging
        Try
            dtgprog.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtgprog.DataSource = Session("Asignados")
            dtgprog.DataBind()

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub LinkBtn_Falla_Red_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkBtn_Falla_Red.Click
        Try
            If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar CPD" Then
                lblmsg.Text = "Si va a reportar Falla de Red la tipificacion debe ser Solicitud Escalar CPD"
                Exit Sub
            End If

            If LblCasoClaro.Text = "" Then
                LblmsgOtros.Text = "Consulte el caso antes de reportar una Falla de Red, Si el caso ya se consulto y no se cargo el 'Caso Claro', no se podra generar falla de red"
                Exit Sub
            Else
                If drlequipo.SelectedItem.Text = "- Seleccione -" Then
                    LblmsgOtros.Text = "Elija la marca y el equipo actual antes de generar una falla de red"
                    Exit Sub
                End If
                ''''Visibilidad Inconsistenacia
                Pninc.Visible = False
                LinkBtn_Inconsistencia.Visible = True
                LinkBtn_Oculta_Inconsistencia.Visible = False
                ''''Visibilidad Falla de Red
                Pnfallared.Visible = True
                LinkBtn_Falla_Red.Visible = False
                LinkBtn_Oculta_Falla_Red.Visible = True

                Pnl_Esc_Service.Visible = False
                LinkBtn_Esc_Service.Visible = True
                LinkBtn_Ocultar_Esc_Service.Visible = False

                txtFcontacto.Text = lblcliente.Text
                txtFnum.Text = txtnumalt.Text
                LblmsgOtros.Text = ""
            End If
        Catch ex As Exception
            LblmsgOtros.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkBtn_Oculta_Falla_Red_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkBtn_Oculta_Falla_Red.Click
        Try
            Pnfallared.Visible = False
            LinkBtn_Falla_Red.Visible = True
            LinkBtn_Oculta_Falla_Red.Visible = False
            LblmsgOtros.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_Guardar_Falla_Red_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Guardar_Falla_Red.Click
        Try
            ''''Consulta si ya existe algun registro para evitar conflicto con PK- © CDRR.
            Dim ObjDataCons As New clscrmdatos
            ObjDataCons.Validacion = "Falla Red"
            ObjDataCons.caso = LblCasoClaro.Text
            ObjDataCons.Consulta_Registro_Falla_Red_Incinsistencia_Otro()
            If ObjDataCons.cantidad > 0 Then
                LblmsgOtros.Text = "El Caso Claro: " + LblCasoClaro.Text + " ya tiene un registro de falla de red"
                Exit Sub
            End If

            lblmsg.Text = ""
            Dim objdatos As New clsvoz
            If drlequipo.SelectedItem.Text = "- Seleccione -" Then
                LblmsgOtros.Text = "Elija la marca y el equipo actual antes de generar una falla de red"
                Exit Sub
            Else
                objdatos.equipo = drlequipo.SelectedItem.Value
            End If
            If drlmun.SelectedItem.Text = "- SELECCIONE -" Then
                LblmsgOtros.Text = "Elija el Departamento y Municipio antes de generar una falla de red"
                Exit Sub
            Else
                objdatos.mun = drlmun.SelectedItem.Value
            End If
            If drlFtectolog.SelectedItem.Text = "- Seleccione -" Then
                LblmsgOtros.Text = "Seleccione la tecnología antes de generar una falla de red"
                Exit Sub
            Else
                objdatos.tecnologia = drlFtectolog.SelectedItem.Text
            End If
            If txtbarrio.Text = "" Then
                LblmsgOtros.Text = "Digite el barrio donde se presenta la falla"
                Exit Sub
            Else
                objdatos.barrio = txtbarrio.Text
            End If
            If txtFcontacto.Text = "" Then
                LblmsgOtros.Text = "Digite la persona de contacto"
                Exit Sub
            Else
                objdatos.cliente = txtFcontacto.Text
            End If
            If txtFnum.Text = "" Then
                LblmsgOtros.Text = "Digite el número de contacto"
                Exit Sub
            Else
                objdatos.telcontacto = txtFnum.Text
            End If
            If drlFtiempo.SelectedItem.Value = "0" Then
                LblmsgOtros.Text = "Elija el tiempo que lleva presentándose la falla"
                Exit Sub
            Else
                objdatos.tiempo = drlFtiempo.SelectedItem.Value
            End If
            If txtFtipofalla.Text = "" Then
                objdatos.tipofalla = ""
            Else
                objdatos.tipofalla = txtFtipofalla.Text
            End If
            If drlFcaract.SelectedItem.Text = "- Seleccione -" Then
                LblmsgOtros.Text = "Describa las características del tipo de falla"
                Exit Sub
            Else
                objdatos.caracter = drlFcaract.SelectedItem.Text
            End If
            If drlFportada.SelectedItem.Value = "0" Then
                LblmsgOtros.Text = "Elija si la línea es portada o no"
                Exit Sub
            Else
                objdatos.portada = drlFportada.SelectedItem.Value
            End If
            If txtFciudad.Text = "" Then
                objdatos.vereda = ""
            Else
                If rdbvc.SelectedValue = Nothing And txtFciudad.Text <> Nothing Then
                    LblmsgOtros.Text = "Elija si el lugar corresponde a un corregimiento, Vereda o Inspección"
                    Exit Sub
                Else
                    objdatos.vereda = rdbvc.SelectedItem.Value & " " & txtFciudad.Text
                End If
            End If
            If txtFdirecc.Text = "" Then
                LblmsgOtros.Text = "Digite la dirección donde se presenta la falla"
                Exit Sub
            Else
                objdatos.dir = txtFdirecc.Text
            End If
            If txtapn.Text = "" Then
                LblmsgOtros.Text = "Digite el APN Afectado"
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

            If drlFlineasfalla.SelectedItem.Value = "0" Then
                LblmsgOtros.Text = "Elija si se reportan más líneas con falla en la ubicación reportada"
                Exit Sub
            Else
                objdatos.maslineas = drlFlineasfalla.SelectedItem.Value
            End If
            If txtfobs.Text = "" Then
                LblmsgOtros.Text = "Digite las observaciones reportadas por el usuario"
                Exit Sub
            Else
                objdatos.obs = txtfobs.Text
            End If
            '''''Validacion Servicio Cliente''''''
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

            objdatos.campana = lblBandeja.Text
            objdatos.caso = LblCasoClaro.Text
            objdatos.idusuario = lblusuario.Text
            objdatos.fcini = Lblfc_ingreso.Text
            ''''Registro de Falla de Red
            objdatos.registrofallasred()
            ''''Registro de que queda falla de Red
            objdatos.caso = lblcaso.Text
            objdatos.tipificacion = "Creado"
            objdatos.RegistroCRM_Falla_Red_Falla_Desactivacion_D_V()
            lblmsg.Text = "Falla de red reportada con éxito, Caso Claro: " + LblCasoClaro.Text + " y registro de trazabilidad, Caso Interno: " + lblcaso.Text
            LblmsgOtros.Text = ""
            'limpiar
            txtbarrio.Text = ""
            txtfobs.Text = ""
            drlFlineasfalla.SelectedValue = "0"
            txtFdirecc.Text = ""
            txtFciudad.Text = ""
            rdbvc.SelectedValue = Nothing
            drlFportada.SelectedValue = "0"
            txtFtipofalla.Text = ""
            txtFcontacto.Text = ""
            txtFnum.Text = ""
            txtapn.Text = ""
            Drl_Qos.SelectedValue = "- Seleccione -"
            drlFtiempo.SelectedValue = "0"
            '''''Validacion Servicio Cliente''''''
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
            'Visibilidad Falla de Red
            Pnfallared.Visible = False
            LinkBtn_Falla_Red.Visible = True
            LinkBtn_Oculta_Falla_Red.Visible = False
            'Cargar_Drl()
        Catch ex As Exception
            LblmsgOtros.Text = "Se produjo error " & ex.Message
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

    Protected Sub drldpto_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drldpto.SelectedIndexChanged
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
                objdatos.Validacion = 1
                dtggeneral.DataSource = objdatos.Consulta_Inf_Caso_Falla_Desactivacion_D_V
                dtggeneral.DataBind()
                lblcuenta.Text = objdatos.cantidad
                If objdatos.cantidad > 0 Then
                    lblcliente.Text = objdatos.cliente
                    txtnombrenv.Text = objdatos.cliente
                    lbldocumento.Text = objdatos.documento
                    txtidentifnv.Text = objdatos.documento
                    lblmin.Text = objdatos.min
                    txtminnv.Text = objdatos.min
                    lblplan.Text = objdatos.plan
                    txtplannv.Text = objdatos.plan
                    lbllugar.Text = objdatos.lugar
                    lblcaso.Text = objdatos.caso
                    lblobs611.Text = objdatos.obsini
                    lblestado.Text = objdatos.tipificacion
                    If txtcaso.Text = "" Then
                        txtcaso.Text = objdatos.caso
                    End If
                    lblmsg.Text = ""
                    If lblmin.Text <> "" Then
                        objdatos.min = lblmin.Text
                    End If
                Else
                    lblcliente.Text = ""
                    lbldocumento.Text = ""
                    lblmin.Text = ""
                    lblplan.Text = ""
                    lbllugar.Text = ""
                    lblcaso.Text = ""
                    lblobs611.Text = ""
                    lblestado.Text = ""
                    pnnuevo.Visible = False
                    txtminnv.Text = ""
                    txtplannv.Text = ""
                    txtidentifnv.Text = ""
                    rdbtipoinb.SelectedValue = Nothing
                    txtnombrenv.Text = ""
                    TxtIngRemite.Text = ""
                    Btn_Nuevo_Regist_Inb.Visible = False
                    pnnuevo.Visible = False
                    lblmsg.Text = "No se han encontrado registros coincidentes"
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub BtnNuevo_caso_Click(sender As Object, e As EventArgs) Handles BtnNuevo_caso.Click
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Consulte el caso"
                Exit Sub
            End If
            BuscarInfInbound()
            Dim dts As New DataSet
            objdatos.caso = txtcaso.Text
            objdatos.Validacion = "Fidelizacion"
            dts = objdatos.Validacion_Registro_Inboun()
            If dts.Tables(0).Rows.Count > 0 Then
                lblmsg.Text = "El Caso " & txtcaso.Text & " ya se encuentra identificado, con la id " & objdatos.min
                Lblfc_ingreso.Text = ""
                lblBandeja.Text = ""
                LblCasoClaro.Text = ""
                Exit Sub
            End If
            pnnuevo.Visible = True
            pnnuevo2.Visible = True
            Btn_Nuevo_Regist_Inb.Visible = True
            Pninc.Visible = False
            If txtminnv.Text <> "" Then
                txtminnv.Enabled = False
                txtplannv.Enabled = False
                txtnombrenv.Enabled = False
                txtidentifnv.Enabled = False
            Else
                txtminnv.Enabled = True
                txtplannv.Enabled = True
                txtnombrenv.Enabled = True
                txtidentifnv.Enabled = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_Nuevo_Regist_Inb_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo_Regist_Inb.Click
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
            If TxtIngRemite.Text = "" Then
                lblmsg.Text = "Digite el Nombre del Ingeniero que lo Remite"
                Exit Sub
            End If
            LblmsgOtros.Text = ""
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
            objdatos.abierto = TxtCasoNuevo.Text
            objdatos.caso = objdatos.abierto
            ''Validacion del caso inbaun cuando este ya est
            Dim dts As New DataSet
            objdatos.Validacion = "Fidelizacion2"
            dts = objdatos.Validacion_Registro_Inboun()
            If dts.Tables(0).Rows.Count > 0 Then
                objdatos.Validacion = "Fidelizacion"
                objdatos.Actualizacion_Identifica_Caso_Inbound()
                lblmsg.Text = "Caso reconocido como inbound"
            Else
                objdatos.Validacion = "Fidelizacion"
                objdatos.registroinb()
                objdatos.caso = txtcaso.Text
                objdatos.Validacion = "Fidelizacion"
                dts = objdatos.Validacion_Registro_Inboun()
                objdatos.caso = objdatos.min
                txtcaso.Text = objdatos.min
                BuscarInf()
                lblmsg.Text = "Registro inbound ingresado con éxito"
            End If
            pnnuevo.Visible = False
            pnnuevo2.Visible = False
            txtminnv.Text = ""
            txtplannv.Text = ""
            txtidentifnv.Text = ""
            rdbtipoinb.SelectedValue = Nothing
            txtnombrenv.Text = ""
            TxtCasoNuevo.Text = ""
            TxtIngRemite.Text = ""
            txtcaso.Text = objdatos.abierto
            txtcaso.Text = lblcaso.Text
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


    Protected Sub drltsoporte_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drltsoporte.SelectedIndexChanged
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
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub



    Protected Sub drlCategoriaCierre_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlCategoriaCierre.SelectedIndexChanged
        Try
            'Dim objdatos As New clsgeneral
            'objdatos.Validacion = "Estado"
            'objdatos.localidad = "Fideliza"
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


    Protected Sub drllinea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drllinea.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
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
            If drllinea.SelectedItem.Text = "- Seleccione -" Then
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
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drlservicio2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlservicio2.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
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
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drlsubservicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlsubservicio.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
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
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drlreclamoppal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlreclamoppal.SelectedIndexChanged
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

    Protected Sub drlvariableCatalogo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlvariableCatalogo.SelectedIndexChanged
        Try
            Dim objdatos As New clscrmdatos
            objdatos.diagservicio = drlvariableCatalogo.SelectedItem.Value
            objdatos.consultaproceso()
            lblvariable1.Text = objdatos.tipificacion
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
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

    '************NUEVO**************
    Protected Sub Btn_act_equipo_Click(sender As Object, e As EventArgs) Handles Btn_act_equipo.Click
        drlmarca.Enabled = True
        drlequipo.Enabled = True
    End Sub

    Protected Sub Btn_act_municipio_Click(sender As Object, e As EventArgs) Handles Btn_act_municipio.Click
        drlmun.Enabled = True
        drldpto.Enabled = True
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

    Protected Sub drltipificacionll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drltipificacionll.SelectedIndexChanged
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
            If drltipificacionll.SelectedItem.Text.Contains("Escalar") Then
                Rdb_Contacto.Enabled = True
                Rdb_Contacto.ClearSelection()
            ElseIf Not drltipificacionll.SelectedItem.Text.Contains("Escalar") Then
                Rdb_Contacto.Enabled = False
                Rdb_Contacto.ClearSelection()
            End If


        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try

    End Sub

    Protected Sub LinkBtn_Esc_Service_Click(sender As Object, e As EventArgs) Handles LinkBtn_Esc_Service.Click
        Try
            If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar SD" Then
                lblmsg.Text = "Si va a Escalar a service la tipificacion debe ser Solicitud Escalar SD"
                Exit Sub
            End If
            If LblCasoClaro.Text = "" Then
                lblmsg.Text = "Consulte el caso antes de generar un Escalamiento a Service, Si el caso ya se consulto y no se cargo el 'Caso Claro', no se podra generar la Inconsistencia"
                Exit Sub
            Else
                If drlCausa_Raiz.SelectedValue = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una Causa Raiz"
                    Exit Sub
                End If
                lblmsg.Text = ""
                ''''Visibilidad Inconsistenacia
                Pninc.Visible = False
                LinkBtn_Inconsistencia.Visible = True
                LinkBtn_Oculta_Inconsistencia.Visible = False
                ''''Visibilidad Falla de Red
                Pnfallared.Visible = False
                LinkBtn_Falla_Red.Visible = True
                LinkBtn_Oculta_Falla_Red.Visible = False
                LblmsgOtros.Text = ""
                '''''Visibilidad Esc_Service
                Pnl_Esc_Service.Visible = True
                LinkBtn_Esc_Service.Visible = False
                LinkBtn_Ocultar_Esc_Service.Visible = True
                lblmsg.Text = ""
            End If
        Catch ex As Exception
            LblmsgOtros.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkBtn_Ocultar_Esc_Service_Click(sender As Object, e As EventArgs) Handles LinkBtn_Ocultar_Esc_Service.Click
        Try
            Pnl_Esc_Service.Visible = False
            LinkBtn_Esc_Service.Visible = True
            LinkBtn_Ocultar_Esc_Service.Visible = False
            LblmsgOtros.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_Guardar_Esc_Service_Click(sender As Object, e As EventArgs) Handles Btn_Guardar_Esc_Service.Click
        Try
            If LblEscalamiento.Text = "Falla de red" Then
                LblmsgOtros.Text = "Ya se encuentra una falla de red registrada con este caso"
                Exit Sub
            End If
            Dim objdatos As New clscrmdatos

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
            If drlTipo_De_Falla.SelectedItem.Value = 3 Then
                lblmsg.Text = "Seleccione un tipo de falla"
                Exit Sub
            End If
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
            objdatos.caso = LblCasoClaro.Text
            objdatos.diagvariable = drlTipo_De_Falla.SelectedItem.Value
            objdatos.obs = txtobs.Text
            objdatos.idusuario = lblusuario.Text
            objdatos.Registroservice()
            lblmsg.Text = "Escalamiento Service realizado con éxito"
            drlapn.SelectedValue = "- Seleccione -"
            drlqos.SelectedValue = "- Seleccione -"
            txtfcactivacion.Text = ""
            Pnl_Esc_Service.Visible = False
            LblEscalamiento.Text = "Escala service"
            Pnl_Esc_Service.Visible = False
            LinkBtn_Esc_Service.Visible = True
            LinkBtn_Ocultar_Esc_Service.Visible = False
            LblEscalamiento.Text = "Escalamiento"
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub Si_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkSi.CheckedChanged
        Try
            If chkSi.Checked = True Then
                txtnumalt.Enabled = True
                txtnumalt.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub

    Protected Sub chkNo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkNo.CheckedChanged
        Try
            If chkNo.Checked = True Then
                txtnumalt.Enabled = False
                txtnumalt.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub



End Class