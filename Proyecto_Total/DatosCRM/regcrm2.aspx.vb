Public Class regcrm2
    Inherits System.Web.UI.Page
    Dim control As String
    Protected Obj_General As New clsgeneral
    Protected Obj_G_D As New Cls_Gestion_Datos
#Region "Métodos"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            'Obj_G_D.Val_Session("CRM")
            If Not IsPostBack Then
                Limpiar_Herramientas()
                Dim Objgnrl As New clsgeneral
                Dim dt As New DataSet
                Session("Formulario") = "Registro Datos"
                Objgnrl.idusuario = CType(Session("permisos"), clsusuario).usuario
                Objgnrl.consultared()
                LblPQR.Text = Objgnrl.Consulta_Numero_PQR().Tables(0).Rows(0).Item("Nombre")
                Consultar_Programados()
                Consultar_Falla_Masiva()
            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'Limpiar herramientas
    Protected Sub Limpiar_Herramientas()
        Try
            rdbvc.selectedvalue = Nothing
            '''''''''''''''''''' LIMPIA CARGUE DE INFORMACION  ''''''''''''''''''''
            'Session("CRM")("Datos")("Val_Reg") = False
            ViewState("dtgcoincidentes") = Nothing
            ViewState("dtggeneral") = Nothing
            btnguardar.Visible = False
            dtggeneral.DataSource = Nothing
            dtggeneral.DataBind()
            dtgcoincidentes.DataSource = Nothing
            dtgcoincidentes.DataBind()
            lblcuenta1.Text = 0
            lblmin.Text = Nothing
            lblcaso.Text = Nothing
            lblcliente.Text = Nothing
            lbldocumento.Text = Nothing
            lblequipo.Text = Nothing
            lblplan.Text = Nothing
            lbllugar.Text = Nothing
            lblemail.Text = Nothing
            lblestado.Text = Nothing
            lblnumeroaler.Text = Nothing
            lblobs611.Text = Nothing
            lblfallatec.Text = Nothing
            Lblfc_ingreso.Text = Nothing
            lblobsmasiva.Text = Nothing
            chkmasiva.Checked = False
            '--------------- GEORREFERENCIACIÓN-----------------
            txtbarrio.Text = Nothing
            txtultimc.Text = Nothing
            txtnumalt.Text = Nothing
            txtnumalt.Visible = False
            chkSi.Checked = False
            chkNo.Checked = False
            lblBandeja.Text = Nothing
            '---------------- DIAGNOSTICO-------------------'
            '-----------------Cierre llamada-----------------
            TxtPQR.Text = Nothing
            '-------------------- SEGUIMIENTO----------------- ''
            txtfcprog.Text = Nothing
            '------------------' ENCUESTAS-------------------'
            TxtPercep_Serv.Text = Nothing
            txtobsincon.Enabled = False
            txtobs.Text = Nothing
            '---------------PANELES-------------------
            pnservice.Visible = False
            PNEscalam.Visible = False
            Pninc.Visible = False
            Panel_seguimiento.Visible = False
            Panel_Justificacion.Visible = False
            '-------------HABILITA------------------
            drlFtectolog.Enabled = True
            drlmarca.Enabled = True
            drlequipo.Enabled = True
            drldpto.Enabled = True
            drlmun.Enabled = True
            txtbarrio.Enabled = True
            txtultimc.Enabled = True
            drlfranja.Enabled = True
            drlTipo_PQR.Enabled = True
            drlModalidad.Enabled = True
            drl611.Enabled = True
            TxtPQR.Enabled = True
            '--------------BOTONES------------
            Btn_Habilita_Tecnologia.Visible = False
            Btn_Habilita_Equipo.Visible = False
            Btn_Habilita_Municipio.Visible = False
            Btn_Habilita_Barrio.Visible = False
            Btn_Habilita_Fc_Utl_Caida.Visible = False
            Btn_Habilita_PQR.Visible = False
            'FALLA DE DATOS
            Txt_N_Doc_Id_CPD.Text = Nothing
            txtfobs.Text = Nothing
            txtFdirecc.Text = Nothing
            txtFciudad.Text = Nothing
            txtFtipofalla.Text = Nothing
            txtFcontacto.Text = Nothing
            txtFnum.Text = Nothing
            txtapn.Text = Nothing
            ''''''''''''SERVICIO CLIENTE'''''''
            Txt_Validacion_Coordenadas.Text = Nothing
            'SERVICE
            drlapn.Enabled = True
            drlqos.Enabled = True
            txtfcactivacion.Text = Nothing
            txtfcactivacion.Enabled = True
            drlvariable.Enabled = False
            lbl_Fecha_Act_Ciclo.Text = "Fecha Activacion"
            Cargar_Drls()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'Limpiar CPD
    Protected Sub Consultar_Falla_Masiva()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.consultafallamasiva()
            If objdatos.cantidad > 0 Then
                lblobsmasiva.Text = objdatos.obs
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'Consultar programados
    Protected Sub Consultar_Programados()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            ViewState("dtgasig") = objdatos.consultaasignado.Tables(0)
            dtgasig.DataSource = ViewState("dtgasig")
            dtgasig.DataBind()
            If dtgasig.Rows.Count > 0 Then
                LblCuentaAsignados.Text = dtgasig.Rows.Count
                PanelCasosAsignados.Visible = True
            Else
                PanelCasosAsignados.Visible = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''busca inbound
    'Protected Sub BuscarInfInbound()
    '    Try
    '        Dim objdatos As New clscrmdatos
    '        If txtcaso.Text = "" Then
    '            Throw New Exception("Digite el Caso o Min que desea consultar")
    '        End If
    '        If txtcaso.Text <> "" Then
    '            objdatos.caso = txtcaso.Text
    '        End If
    '        TxtCasoNuevo.Text = txtcaso.Text
    '        dtggeneral.DataSource = objdatos.consultacaso
    '        dtggeneral.DataBind()
    '        lblcuenta.Text = objdatos.cantidad
    '        If objdatos.cantidad > 0 Then
    '            lblcliente.Text = objdatos.cliente
    '            txtnombrenv.Text = objdatos.cliente
    '            txtnombrenv.Enabled = False
    '            lbldocumento.Text = objdatos.documento
    '            txtidentifnv.Text = objdatos.documento
    '            txtidentifnv.Enabled = False
    '            lblmin.Text = objdatos.min
    '            txtminnv.Text = objdatos.min
    '            txtminnv.Enabled = False
    '            lblplan.Text = objdatos.plan
    '            txtplannv.Text = objdatos.plan
    '            txtplannv.Enabled = False
    '            lblequipo.Text = objdatos.equipo
    '            lbllugar.Text = objdatos.lugar
    '            lblemail.Text = objdatos.email
    '            lblcaso.Text = objdatos.caso
    '            lblobs611.Text = objdatos.obsini
    '            lblestado.Text = objdatos.tipificacion
    '            If txtcaso.Text = "" Then
    '                txtcaso.Text = objdatos.caso
    '            End If
    '            lblmsg.Text = ""
    '            If lblmin.Text <> "" Then
    '                objdatos.min = lblmin.Text
    '                dtgcoincidentes.DataSource = objdatos.casosasociados
    '                dtgcoincidentes.DataBind()
    '                lblcuenta1.Text = objdatos.cantidad
    '            End If
    '        Else
    '            lblcliente.Text = ""
    '            lbldocumento.Text = ""
    '            lblmin.Text = ""
    '            lblplan.Text = ""
    '            lblequipo.Text = ""
    '            lbllugar.Text = ""
    '            lblemail.Text = ""
    '            lblcaso.Text = ""
    '            lblobs611.Text = ""
    '            lblestado.Text = ""
    '            lblfallatec.Text = ""
    '            dtgcoincidentes.DataSource = Nothing
    '            dtgcoincidentes.DataBind()
    '            lblcuenta1.Text = 0
    '            Throw New Exception("No se han encontrado registros coincidentes")
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub
    'Guardad diagnostic
    Protected Sub Registrar_Diagnostico()
        Try
            Dim objdatos As New clscrmdatos
            If drlsolicitud.SelectedIndex > 0 Or drlFtectolog.SelectedIndex > 0 Or drlvariable.SelectedIndex > 0 Or drlmun.SelectedIndex > 0 Or txtultimc.Text <> "" Then
                objdatos.caso = lblcaso.Text
                'EQUIPO
                If drlequipo.SelectedIndex <= 0 Then
                    objdatos.equipo = ""
                Else
                    objdatos.equipo = drlequipo.Text
                End If
                'MUNICIPIO
                If drlmun.SelectedIndex <= 0 Then
                    objdatos.mun = "0"
                Else
                    objdatos.mun = drlmun.SelectedItem.Value
                End If
                'BARRIO
                If txtbarrio.Text = "" Then
                    objdatos.barrio = ""
                Else
                    objdatos.barrio = txtbarrio.Text
                End If
                'CONDICION DE USO
                If drlFtectolog.SelectedIndex <= 0 Then
                    objdatos.diagtecnolog = "0"
                Else
                    objdatos.diagtecnolog = drlFtectolog.SelectedItem.Value
                End If
                'FECHA ULTIMA CAIDA
                If txtultimc.Text = "" Then
                    objdatos.fcultimac = "01/01/1900"
                    objdatos.franjaultimac = ""
                Else
                    objdatos.fcultimac = txtultimc.Text
                    If drlfranja.SelectedIndex <= 0 Then
                        objdatos.franjaultimac = ""
                    Else
                        objdatos.franjaultimac = drlfranja.SelectedItem.Text
                    End If
                End If
                'SERVICIO
                If drlservicio2.SelectedIndex <= 0 Then
                    objdatos.servreest = "0"
                Else
                    objdatos.servreest = drlservicio2.SelectedValue
                End If
                'SOLICITUD TIPO FALLA
                If drlsolicitud.SelectedIndex <= 0 Then
                    objdatos.solicitud = "0"
                Else
                    objdatos.solicitud = drlsolicitud.SelectedValue
                End If
                'SEGMENTO Y CAUSA
                If drlCausa_Raiz.SelectedIndex <= 0 Then
                    objdatos.Causa_Raiz = "0"
                Else
                    objdatos.Causa_Raiz = drlCausa_Raiz.SelectedValue
                End If
                'CATEGORIA CIERRE
                If drlCategoriaCierre.SelectedIndex <= 0 Then
                    objdatos.Categoria_Cierre = "0"
                Else
                    objdatos.Categoria_Cierre = drlCategoriaCierre.SelectedValue
                End If
                'MODALIDAD
                If drlModalidad.SelectedIndex <= 0 Then
                    objdatos.Modalidad = ""
                Else
                    objdatos.Modalidad = drlModalidad.SelectedItem.Text
                End If
                'TIPO PQR
                If drlTipo_PQR.SelectedIndex <= 0 Then
                    objdatos.Tipo_PQR = ""
                Else
                    objdatos.Tipo_PQR = drlTipo_PQR.SelectedItem.Text
                End If
                'INCONSISTENCIA
                If drlinconsistencia.SelectedIndex <= 0 Then
                    objdatos.inconsistencia_encuesta = ""
                ElseIf drlinconsistencia.SelectedItem.Text <> "Otro" Then
                    objdatos.inconsistencia_encuesta = drlinconsistencia.SelectedItem.Text
                Else
                    objdatos.inconsistencia_encuesta = txtobsincon.Text
                End If
                '----------------------'
                'ERROR EN REGISTRO
                If drlvariable.SelectedIndex <= 0 Then
                    objdatos.diagvariable = "0"
                Else
                    objdatos.diagvariable = drlvariable.SelectedItem.Value
                End If
                '--------------------------------------------------------------------------------------
                'campos pendientes por eliminar
                objdatos.reclamoppal = "0"
                objdatos.tipofalla = "0"
                objdatos.diagtcierre = "0"
                objdatos.Version_S_O_Equipo = " "
                objdatos.Version_Facebook = " "
                objdatos.WTF = "0"
                objdatos.Tipo_Cliente = ""
                '--------------------------------------------------------------------------------------
                objdatos.registrodiag()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'guarda creado
    Protected Sub Registra_CRM()
        Dim objdatos As New clsvoz
        Try
            objdatos.caso = lblcaso.Text
            If txtobs.Text = "" Then
                objdatos.obs = ""
            Else
                objdatos.obs = txtobs.Text
            End If
            objdatos.tipificacion = "Creado"
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.registrocrmfallareddatos()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Seguimiento ingresado con éxito"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'actualiza bandeja
    Protected Sub Actualizar_Bandeja()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                Throw New Exception("Digite el caso que desea registrar")
            End If
            objdatos.caso = txtcaso.Text
            If drltipificacionll.SelectedIndex = 0 Then
                Throw New Exception("Seleccione la tipificación de la llamada")
            End If
            objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            If drlequipo.SelectedIndex = 0 Then
                objdatos.equipo = ""
            Else
                objdatos.equipo = drlequipo.SelectedItem.Text
            End If
            objdatos.modificarbandeja()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub Registrar_CPD()
        Try
            Obj_G_D.Validar_Herramientas(txtFcontacto, "persona de contacto")
            Obj_G_D.Validar_Herramientas(Txt_N_Doc_Id_CPD, "Documento identidad contacto")
            If Not IsNumeric(Txt_N_Doc_Id_CPD.Text) Then
                Throw New Exception("El número de documento de identidad de la persona que reporta debe estar compuesto solo por números")
            End If
            Obj_G_D.Validar_Herramientas(txtFnum, "número de contacto")
            If Not IsNumeric(txtFnum.Text) Then
                Throw New Exception("El número de contacto debe se un número")
            End If
            Obj_G_D.Validar_Herramientas(drlFtiempo, "Tiempo Falla")
            Obj_G_D.Validar_Herramientas(drlFcaract, "Características de la Falla")
            Obj_G_D.Validar_Herramientas(drlFportada, "Línea Portada")
            Obj_G_D.Validar_Herramientas(drlmun, "Municipio")
            Obj_G_D.Validar_Herramientas(txtFdirecc, "Dirección Falla")
            Obj_G_D.Validar_Herramientas(txtbarrio, "Barrio")
            Obj_G_D.Validar_Herramientas(drlFtectolog, "Condiciones de uso")
            Obj_G_D.Validar_Herramientas(drlFlineasfalla, "Lineas con falla en la Ubicación Reportada")
            Obj_G_D.Validar_Herramientas(txtfobs, "Observación Cliente")
            Obj_G_D.Validar_Herramientas(txtapn, "APN")
            Obj_G_D.Validar_Herramientas(Drl_Qos, "QoS")
            Obj_G_D.Validar_Herramientas(Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania, "La falla se presenta luego de que se")
            Obj_G_D.Validar_Herramientas(Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio, "La falla se presenta luego de que se remodelara la estructura física del edificio")
            If Drl_Tipo_Edificacion_Donde_Presenta_Falla_1.SelectedIndex = 0 Or Drl_Tipo_Edificacion_Donde_Presenta_Falla_2.SelectedIndex = 0 Then
                Throw New Exception("Seleccione las dos (2) opciones para Tipo de edificación donde se presenta la falla")
            End If
            Obj_G_D.Validar_Herramientas(Drl_Validaciones_Falla_Masiva, "Validaciones de falla masiva")
            Obj_G_D.Validar_Herramientas(Drl_Tecnologia_Presenta_Falla_Luegodepruebas, "Tecnología en la que se presenta la falla - Luego de pruebas")
            Obj_G_D.Validar_Herramientas(Txt_Validacion_Coordenadas, "Validación de Coordenadas")
            Obj_G_D.Validar_Herramientas(Drl_Linea_No_Cuenta_Bloqueos_Internet, "Línea no cuenta con bloqueos de Internet")
            Obj_G_D.Validar_Herramientas(Drl_Linea_No_Superado_Limite_Consumos, "Línea no ha superado el limite de consumos")
            Obj_G_D.Validar_Herramientas(Drl_Linea_No_Encuentra_Enrutada_PorPagos, "Línea no se encuentra enrutada por pagos")
            Obj_G_D.Validar_Herramientas(Drl_HLR_HSS, "HLR / HSS")
            Obj_G_D.Validar_Herramientas(Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra, "No existen cambios administrativos sobre la línea o cuenta maestra")
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text = "FALSO" And Drl_Split_Billing.SelectedIndex = 0 Then
                Throw New Exception("En opcion No existen cambios administrativos sobre la línea o cuenta maestra seleccione una opción de la segunda lista 'split billing'")
            End If
            Obj_G_D.Validar_Herramientas(Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla, "Se realizan pruebas de SIMCARD en otro dispositivo (Persiste Falla)")
            Obj_G_D.Validar_Herramientas(Drl_Forza_Red_Dispositivo, "Se forza la red del dispositivo")
            Obj_G_D.Validar_Herramientas(Drl_Verifica_Realiza_Configuración_APN, "Se verifica o realiza configuración de APN")
            Obj_G_D.Validar_Herramientas(Drl_Equipo_Encuentra_Homologado_Operador, "Equipo se encuentra homologado por el operador")
            Obj_G_D.Validar_Herramientas(Drl_Realiza_Conciliacion_Sobre_linea, "Drl_Realiza_Conciliacion_Sobre_linea")

            Dim objFdatos As New clsvoz
            If txtFtipofalla.Text = "" Then
                objFdatos.tipofalla = ""
            Else
                objFdatos.tipofalla = txtFtipofalla.Text
            End If
            If txtFciudad.Text = "" Then
                objFdatos.vereda = ""
            Else
                If rdbvc.selectedvalue = Nothing = Nothing And txtFciudad.Text <> Nothing Then
                    Throw New Exception("Elija si el lugar corresponde a un corregimiento, Vereda o Inspección")
                End If
                objFdatos.vereda = rdbvc.SelectedItem.Value & " " & txtFciudad.Text
            End If
            objFdatos.N_Doc_Id = Txt_N_Doc_Id_CPD.Text
            objFdatos.cliente = txtFcontacto.Text
            objFdatos.telcontacto = txtFnum.Text
            objFdatos.tiempo = drlFtiempo.SelectedItem.Value
            objFdatos.caracter = drlFcaract.SelectedItem.Text
            objFdatos.portada = drlFportada.SelectedItem.Value
            objFdatos.mun = drlmun.SelectedItem.Value
            objFdatos.dir = txtFdirecc.Text
            objFdatos.barrio = txtbarrio.Text
            objFdatos.tecnologia = drlFtectolog.SelectedItem.Text
            objFdatos.equipo = drlequipo.SelectedItem.Value
            objFdatos.maslineas = drlFlineasfalla.SelectedItem.Value
            objFdatos.obs = txtfobs.Text
            objFdatos.apn = txtapn.Text
            objFdatos.qos = Drl_Qos.SelectedItem.Text
            objFdatos.Falla_Presenta_Luego_Construyera_Edificacion_Aledania = Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania.SelectedItem.Text
            objFdatos.Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio.SelectedItem.Text
            objFdatos.Tipo_Edificacion_Donde_Presenta_Falla = Drl_Tipo_Edificacion_Donde_Presenta_Falla_1.SelectedItem.Text + " - " + Drl_Tipo_Edificacion_Donde_Presenta_Falla_2.SelectedItem.Text
            objFdatos.Validaciones_Falla_Masiva = Drl_Validaciones_Falla_Masiva.SelectedItem.Text
            objFdatos.Tecnologia_Presenta_Falla_Luegodepruebas = Drl_Tecnologia_Presenta_Falla_Luegodepruebas.SelectedItem.Text
            objFdatos.Validacion_Coordenadas = Txt_Validacion_Coordenadas.Text
            objFdatos.Linea_No_Cuenta_Bloqueos_Internet = Drl_Linea_No_Cuenta_Bloqueos_Internet.SelectedItem.Text
            objFdatos.Linea_No_Superado_Limite_Consumos = Drl_Linea_No_Superado_Limite_Consumos.SelectedItem.Text
            objFdatos.Linea_No_Encuentra_Enrutada_PorPagos = Drl_Linea_No_Encuentra_Enrutada_PorPagos.SelectedItem.Text
            objFdatos.HLR_HSS = Drl_HLR_HSS.SelectedItem.Text
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text = "FALSO" Then
                objFdatos.No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text + " - " + Drl_Split_Billing.SelectedItem.Text
            Else
                objFdatos.No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text
            End If
            objFdatos.Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla.SelectedItem.Text
            objFdatos.Forza_Red_Dispositivo = Drl_Forza_Red_Dispositivo.SelectedItem.Text
            objFdatos.Verifica_Realiza_Configuración_APN = Drl_Verifica_Realiza_Configuración_APN.SelectedItem.Text
            objFdatos.Equipo_Encuentra_Homologado_Operador = Drl_Equipo_Encuentra_Homologado_Operador.SelectedItem.Text
            objFdatos.Realiza_Conciliacion_Sobre_linea = Drl_Realiza_Conciliacion_Sobre_linea.SelectedItem.Text

            objFdatos.campana = "Datos"
            objFdatos.caso = lblcaso.Text
            objFdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objFdatos.fcini = Lblfc_ingreso.Text
            objFdatos.registrofallasred()
            Registra_CRM()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Falla de red reportada con éxito"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub Registrar_SD()
        Try
            Dim ObjSdatos As New clscrmdatos
            If drl_causal_escalamiento_service.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una causa de escalamiento")
            End If
            ObjSdatos.Causal_escalam = drl_causal_escalamiento_service.SelectedItem.Text
            If drl_causal_escalamiento_service.SelectedItem.Text = "Linea No Registra" Then
                ObjSdatos.apn = DBNull.Value.ToString
                ObjSdatos.qos = DBNull.Value.ToString
                ObjSdatos.fcini = DBNull.Value.ToString
            Else
                If drlapn.SelectedIndex = 0 Then
                    Throw New Exception("Elija el APN del caso")
                End If
                ObjSdatos.apn = drlapn.SelectedItem.Text
                If drlqos.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione el QoS del caso")
                End If
                ObjSdatos.qos = drlqos.SelectedItem.Text
                If txtfcactivacion.Text = "" Then
                    If drl_causal_escalamiento_service.SelectedItem.Text = "Reinicio de Ciclo - Linea Postpago" Then
                        Throw New Exception("Digite la Fecha de Ciclo")
                    Else
                        Throw New Exception("Digite la fecha de activación del servicio")
                    End If
                Else
                    If drl_causal_escalamiento_service.SelectedItem.Text = "Reinicio de Ciclo - Linea Postpago" Then
                        ObjSdatos.Fecha_ciclo = txtfcactivacion.Text
                        ObjSdatos.fcini = Nothing
                    Else
                        ObjSdatos.fcini = txtfcactivacion.Text
                        ObjSdatos.Fecha_ciclo = Nothing
                    End If
                End If
            End If
            If drlvariable.SelectedIndex = 0 Then
                Throw New Exception("Elija un Error en Registro")
            End If
            If Not FileDocumento.PostedFile Is Nothing Then
                If Not FileDocumento.PostedFile Is Nothing And FileDocumento.PostedFile.ContentLength > 0 Then
                    FileDocumento.PostedFile.SaveAs(Server.MapPath("data_Doc") & "\\" & lblcaso.Text + System.IO.Path.GetExtension(FileDocumento.PostedFile.FileName))
                    ObjSdatos.archivo = lblcaso.Text + System.IO.Path.GetExtension(FileDocumento.PostedFile.FileName)
                Else
                    ObjSdatos.archivo = ""
                    Throw New Exception("Adjunte un archivo")
                End If
            Else
                Throw New Exception("Adjunte un archivo")
            End If
            ObjSdatos.caso = lblcaso.Text
            ObjSdatos.diagvariable = drlvariable.SelectedItem.Value
            ObjSdatos.obs = txtobs.Text
            ObjSdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            ObjSdatos.Registroservice()
            Registra_CRM()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Escalamiento Service realizado con éxito"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#Region "Btn"
    'Guardar
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clscrmdatos
        Try
            'CASO
            If lblcaso.Text = Nothing Then
                Throw New Exception("Digite el caso que desea registrar")
            End If
            objdatos.caso = lblcaso.Text
            'vALIDACION DEL CASO
            objdatos.Validacion = 1
            objdatos.ConsultarEstados()
            If objdatos.tipificacion.Contains("Cerrado") Then
                Throw New Exception("¡El Caso que desea guardar se encuentra Cerrado!")
            Else
                objdatos.Validacion = Nothing
            End If
            'LINEA DE SERVICIO
            If drllinea.SelectedIndex = 0 Then
                Throw New Exception("Seleccione linea de servicio")
            End If
            'SERVICIO
            If drlservicio2.SelectedIndex = 0 Then
                Throw New Exception("Seleccione servicio")
            End If
            'TIPO FALLA
            If drlsolicitud.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una Solicitud / Tipo Falla ")
            End If
            'SEGMENTO
            If drlSegmento.SelectedIndex = 0 Then
                Throw New Exception("Seleccione segmento de llamada")
            End If
            'CAUSA RAIZ
            If drlCausa_Raiz.SelectedIndex = 0 Then
                Throw New Exception("Seleccione causa raiz de llamada")
            End If
            'TIPIFICACION
            If drltipificacionll.SelectedIndex = 0 Then
                Throw New Exception("Seleccione tipificacion de llamada")
            End If
            'CATEGORIA DE CIERRE
            If drlCategoriaCierre.SelectedIndex = 0 Then
                Throw New Exception("Seleccione categoria de cierre de llamada")
            End If
            'PQR
            If TxtPQR.Text = "" Then
                Throw New Exception("Ingrese el consecutivo PQR")
            Else
                objdatos.pqr = Int64.Parse(LblPQR.Text + TxtPQR.Text)
            End If
            'Juistificacion caso
            If drltipificacionll.SelectedItem.Text <> "Cerrado" And Not drltipificacionll.SelectedItem.Text.Contains("Solici") And drltipificacionll.SelectedItem.Text <> "Falla Masiva" Then
                If Drl_justificacion_seguimiento.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione la justificacion del seguimiento")
                Else
                    objdatos.tiposoporte = Drl_justificacion_seguimiento.SelectedItem.Text
                End If
            Else
                objdatos.tiposoporte = ""
            End If
            'NUMERO ALTERNO'
            If chkSi.Checked = False And chkNo.Checked = False Then
                Throw New Exception("Seleccione si realizo contacto a linea alterna")
            Else
                If chkSi.Checked = True Then
                    If txtnumalt.Text = "" Then
                        Throw New Exception("Digite el numero alterno")
                    Else
                        objdatos.telalt = txtnumalt.Text
                    End If
                End If
                If chkNo.Checked = True Then
                    objdatos.telalt = lblmin.Text
                End If
            End If
            'CAPTURA OBSERVACION
            If txtobs.Text = "" Then
                Throw New Exception("Digite la observación de atención al caso (OBSERVACIÓN)")
            Else
                objdatos.obs = txtobs.Text
            End If
            '-------------NO CONTACTADO----------------
            If drltipificacionll.SelectedItem.Text <> "No Contactado" Then
                '----------GEORREFERENCIACION------------
                'CONDICION DE USO
                If drlFtectolog.SelectedIndex = 0 Then
                    Throw New Exception("Elija la tecnología del equipo que presenta la falla")
                End If

                'MARCA
                If drlmarca.SelectedIndex = 0 Then
                    Throw New Exception("Si el caso es cerrado, escalado o gestionado, debe elegir la marca del equipo ")
                End If
                'EQUIPO
                If drlequipo.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione un equipo ")
                End If
                'MUNICIPIO
                If drlmun.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione departamento y municipio ")
                End If
                'BARRIO
                If txtbarrio.Text = "" Then
                    Throw New Exception("Digite el barrio donde se presenta la falla")
                End If
                'ULTIMA CAIDA
                If txtultimc.Text <> "" And drlfranja.SelectedIndex = 0 Then
                    Throw New Exception("Elija la franja en la que se presentó la última caida: mañana, tarde, noche ")
                End If
                If txtultimc.Text <> Nothing Then
                    'valida fecha no superior a la actual
                    If Convert.ToDateTime(Me.txtultimc.Text) > Today Then
                        Throw New Exception("La fecha de caida no puede ser mayor a la fecha actual")
                    End If
                End If
                'FECHA PROGAMACION
                If drltipificacionll.SelectedItem.Text = "Programado" Then
                    If txtfcprog.Text = "" Then
                        txtfcprog.Text = ""
                        Throw New Exception("Si la llamada es programada elija la fecha y hora a la que se debe llamar nuevamente ")
                    Else
                        Dim hora As String
                        hora = Convert.ToDateTime(txtfcprog.Text)
                        If Convert.ToDateTime(hora) <= Now Then
                            txtfcprog.Text = ""
                            Throw New Exception("La fecha de programación debe ser mayor a la fecha actual, verifique ")
                        End If
                        objdatos.horaprog = hora
                    End If
                End If
                'TIPO PQR
                If drlTipo_PQR.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione un tipo PQR ")
                End If
                'MODALIDAD
                If drlModalidad.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione una modalidad ")
                End If
                '--------------------------------------------------------------------------------------
                'CAPTURA SATISFECHA ATENCION *611
                If drl611.SelectedIndex > 0 Then
                    objdatos.preg1 = drl611.SelectedItem.Text
                Else
                    Throw New Exception("Seleccione Satisfecha atencion *611")
                End If
                'CAPTURA PERCEPCION DEL SERVICIO
                If TxtPercep_Serv.Text <> "" Then
                    objdatos.Percep_serv = TxtPercep_Serv.Text
                Else
                    Throw New Exception("Digite Percepcion de servicio")
                End If

                'CAPTURA TIPIFICACION
                If drltipificacionll.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione la tipificación de la llamada ")
                Else
                    objdatos.tipificacion = drltipificacionll.SelectedItem.Text
                End If
            Else
                'tiposoporte para no contactado
                objdatos.obs = txtobs.Text
                objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            End If
            'USUARIO
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            'inconsistencia'
            If drltipificacionll.SelectedItem.Text = "Cerrado" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD" Then
                If drlinconsistencia.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione inconsistencia en *611 / ENCUESTA")
                Else
                    If drlinconsistencia.SelectedItem.Text = "Otro" And txtobsincon.Text = "" Then
                        Throw New Exception("Escriba una observacion en inconsistencia")
                    ElseIf drlinconsistencia.SelectedItem.Text <> "Otro" Then
                        objdatos.inconsistencia_encuesta = drlinconsistencia.SelectedItem.Text
                    Else
                        objdatos.inconsistencia_encuesta = txtobsincon.Text
                    End If
                End If
            Else
                If drlinconsistencia.SelectedIndex = 0 Then
                    objdatos.inconsistencia_encuesta = ""
                ElseIf drlinconsistencia.SelectedItem.Text = "Otro" And txtobsincon.Text = "" Then
                    Throw New Exception("Escriba una observacion en inconsistencia")
                    Exit Sub
                ElseIf drlinconsistencia.SelectedItem.Text <> "Otro" Then
                    objdatos.inconsistencia_encuesta = drlinconsistencia.SelectedItem.Text
                Else
                    objdatos.inconsistencia_encuesta = txtobsincon.Text
                End If
            End If
            'VALIDACION ESCALAMIENTO
            If drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD" Then
                objdatos.Validacion = "informatica"
                objdatos.Busca_escalamiento_inbound()
                If objdatos.cantidad > 0 Then
                    Throw New Exception("Este caso ya fue escalado al area de informatica")
                End If
            ElseIf drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Then
                objdatos.Validacion = "tecnica"
                objdatos.Busca_escalamiento_inbound()
                If objdatos.cantidad > 0 Then
                    Throw New Exception("Este caso ya fue escalado al area de tecnica")
                End If
            End If
            '---------ESCALAMIENTOS----------'
            'ESCALAMIENTO CPD'
            If drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Then
                Registrar_CPD()
            ElseIf drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD" Then
                Registrar_SD()
            End If
            ''Validacion para el aval de los casos
            If drlCategoriaCierre.SelectedItem.Text = "Remision a Servicio Tecnico" Or drlCategoriaCierre.SelectedItem.Text = "Remision a CAV por falta de conocimiento por parte del cliente" Then
                objdatos.caso = lblcaso.Text
                objdatos.Validacion = "3"
                objdatos.consultaperfilamiento()
                If objdatos.cantidad = 0 Then
                    Throw New Exception("Este caso no cuenta con el aval de un supervisor")
                End If
            End If
            'REGISTRO CRMDETALLE
            objdatos.registrocrm()
            'Validacion Programados'''''
            If drltipificacionll.SelectedItem.Text = "Programado" Then
                If DrlLibera.Text = "SI" Then
                    objdatos.Validacion = "Libera"
                    objdatos.asignaprogramados()
                ElseIf DrlLibera.Text = "NO" Then
                    objdatos.Validacion = "Autoasigna"
                    objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                    objdatos.asignaprogramados()
                End If
                DrlLibera.SelectedIndex = 0
            End If
            'BANDEJA
            Actualizar_Bandeja()
            'DIAGNOSTICO
            Registrar_Diagnostico()
            'Recargar información de caso
            Btn_Consultar_Click(1, Nothing)
            Consultar_Programados()

            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Seguimiento ingresado con éxito"
        Catch ex As Exception
            'Pnl_Message.CssClass = "alert alert-danger"
            'lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'Consultar
    Protected Sub Btn_Consultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Consultar.Click
        Try
            Limpiar_Herramientas()
            If txtcaso.Text = Nothing Then
                Throw New Exception("Digite el Caso o Min que desea consultar")
            ElseIf Not IsNumeric(txtcaso.Text) Then
                Throw New Exception("El código del caso debe estar conformado por un número entero!!")
            End If
            Dim objdatos As New clscrmdatos
            objdatos.caso = txtcaso.Text
            ViewState("dtggeneral") = objdatos.consultacaso().Tables(0)
            If ViewState("dtggeneral").Rows.Count > 0 Then
                dtggeneral.DataSource = ViewState("dtggeneral")
                dtggeneral.DataBind()
                lblcuenta.Text = dtggeneral.Rows.Count
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
                If lblmin.Text <> "" Then
                    objdatos.min = lblmin.Text
                    ViewState("dtgcoincidentes") = objdatos.casosasociados()
                    dtgcoincidentes.DataSource = ViewState("dtgcoincidentes")
                    dtgcoincidentes.DataBind()
                    lblcuenta1.Text = dtgcoincidentes.Rows.Count
                End If
                If TypeOf sender Is Button Then
                    If objdatos.tipificacion.Contains("Cerrado") Or objdatos.tipificacion.Contains("Escala") Then
                        btnguardar.Visible = False
                        Throw New Exception("No puede realizar gestion sobre este caso ya que se encuentra Cerrado o Escalado")
                    Else
                        btnguardar.Visible = True
                    End If
                    objdatos.Consulta_Diganostico_Carga()
                    If objdatos.tecnologia <> "" And objdatos.tecnologia <> "0" Then
                        drlFtectolog.SelectedValue = objdatos.tecnologia
                        drlFtectolog.Enabled = False
                        Btn_Habilita_Tecnologia.Visible = True
                    End If
                    If objdatos.marca <> "" And objdatos.marca <> " " And objdatos.marca <> "0" Then
                        drlmarca.SelectedValue = objdatos.marca
                        drlmarca.Enabled = False
                        drlmarca_SelectedIndexChanged(1, Nothing)
                        drlequipo.SelectedValue = objdatos.equipo
                        drlequipo.Enabled = False
                        Btn_Habilita_Equipo.Visible = True
                    End If
                    If objdatos.dpto <> "" And objdatos.dpto <> " " And objdatos.dpto <> "0" Then
                        drldpto.SelectedValue = objdatos.dpto
                        drldpto.Enabled = False
                        drldpto_SelectedIndexChanged(1, Nothing)
                        drlmun.SelectedValue = objdatos.mun
                        drlmun.Enabled = False
                        Btn_Habilita_Municipio.Visible = True
                    End If
                    If objdatos.barrio <> "" And objdatos.barrio <> " " Then
                        txtbarrio.Text = objdatos.barrio
                        txtbarrio.Enabled = False
                        Btn_Habilita_Barrio.Visible = True
                    End If
                    If objdatos.fcultimac <> "" And objdatos.fcultimac <> "01/01/1900" Then
                        txtultimc.Text = objdatos.fcultimac
                        txtultimc.Enabled = False
                    End If
                    If objdatos.franjaultimac <> "" Then
                        drlfranja.SelectedValue = objdatos.franjaultimac
                        drlfranja.Enabled = False
                        Btn_Habilita_Fc_Utl_Caida.Visible = True
                    End If
                    If objdatos.Tipo_PQR <> "" And objdatos.Tipo_PQR <> " " Then
                        drlTipo_PQR.SelectedValue = objdatos.Tipo_PQR
                        drlTipo_PQR.Enabled = False
                    End If
                    If objdatos.Modalidad <> "" And objdatos.Modalidad <> " " Then
                        drlModalidad.SelectedValue = objdatos.Modalidad
                        drlModalidad.Enabled = False
                    End If
                    If objdatos.pqr <> "" And objdatos.pqr <> " " Then
                        TxtPQR.Text = Mid(objdatos.pqr, 10, 7)
                        TxtPQR.Enabled = False
                        Btn_Habilita_PQR.Visible = True
                    End If
                    If objdatos.preg1 <> "" And objdatos.preg1 <> " " And objdatos.preg1 <> "0" And objdatos.preg1 <> "- Selecione -" Then
                        drl611.SelectedValue = objdatos.preg1
                        drl611.Enabled = False
                        If objdatos.Percep_serv <> "" And objdatos.Percep_serv <> " " Then
                            TxtPercep_Serv.Text = objdatos.Percep_serv
                            TxtPercep_Serv.Enabled = False
                        End If
                    End If
                End If
            Else
                Throw New Exception("No se han encontrado registros coincidentes")
            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            If Obj_G_D.Ex("System") Then
                Limpiar_Herramientas()
            End If
            If TypeOf sender Is Button Then
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Throw ex
            End If
        End Try
    End Sub
    'Reportar inconsistencia
    Protected Sub LinkButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton3.Click
        Try
            If lblcaso.Text = "" Then
                Throw New Exception("Consulte el caso antes de generar una inconsistencia")
            End If
            Dim objdatos As New clscrmdatos
            objdatos.caso = lblcaso.Text
            If objdatos.Consultar_Inconsistencia().Tables(0).Rows.Count > 0 Then
                lblmsg.Text = "El caso  " + objdatos.caso + "  ya tiene reportada una inconsistencia"
                Exit Sub
            End If
            drl_ubicacion_call.SelectedIndex = 0

            Pninc.Visible = True
            LinkButton4.Visible = True
            LinkButton3.Visible = False
            PNEscalam.Visible = False
            pnservice.Visible = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'ocultar inconsistencia
    Protected Sub LinkButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton4.Click
        Try
            LinkButton3.Visible = True
            LinkButton4.Visible = False
            Pninc.Visible = False
            PNEscalam.Visible = False
            pnservice.Visible = False
            lblmsg.Text = ""
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'guardar inconsistencia
    Protected Sub btnguardar0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar0.Click
        Try
            ''''Consulta si ya existe algun registro para evitar conflicto con PK- © CDRR.
            Dim ObjDataCons As New clscrmdatos
            ObjDataCons.Validacion = "Inconsistencia"
            ObjDataCons.caso = lblcaso.Text
            ObjDataCons.Consulta_Registro_Falla_Red_Incinsistencia_Otro()
            If ObjDataCons.cantidad > 0 Then
                Throw New Exception("El Caso Claro: " + lblcaso.Text + " ya tiene un registro de inconsistencai")
            End If
            Dim objdatos As New clscrmdatos
            If drlincons.SelectedIndex = 0 Then
                Throw New Exception("Elija el tipo de inconsistencia a reportar")
            End If
            objdatos.incidente = drlincons.SelectedItem.Value
            If txtobsinc.Text = "" Then
                Throw New Exception("Digite la observación de la inconsistencia")
            End If
            objdatos.obs = txtobsinc.Text
            If Txt_custcode.Text = "" Then
                Throw New Exception("Es obligatorio llenar Custcode")
            End If
            objdatos.custcode = Txt_custcode.Text
            If Txt_usuario_reporta.Text = "" Then
                Throw New Exception("Digite el usuario reporta de la inconsistencia")
            End If
            objdatos.usuarioreporta = Txt_usuario_reporta.Text
            If drl_ubicacion_call.SelectedIndex = 0 Then
                Throw New Exception("Seleccione ubicacion de call center")
            End If
            objdatos.lugar = drl_ubicacion_call.SelectedValue

            If drlnivel.SelectedIndex = 0 Then
                Throw New Exception("Elija el nivel que genera la inconsistencia, verifique")
            End If
            objdatos.barrio = drlnivel.SelectedItem.Value
            objdatos.caso = lblcaso.Text
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.estadoinc = "Aprobado"
            objdatos.registroinc()
            drlincons.SelectedIndex = 0
            drlinconsglobal.SelectedIndex = 0
            txtobsinc.Text = ""
            Txt_custcode.Text = ""
            Txt_usuario_reporta.Text = ""
            Pninc.Visible = False
            drlnivel.SelectedIndex = 0
            LinkButton3.Visible = True
            LinkButton4.Visible = False
            drl_ubicacion_call.SelectedIndex = 0
            drl_ubicacion_call.Enabled = True
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Inconsistencia reportada con exito"
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'Ver seguimiento
    Protected Sub lnk1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnk1.Click
        dtggeneral.Visible = True
        dtgcoincidentes.Visible = False
    End Sub
    'ver casos asociados
    Protected Sub LinkButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton2.Click
        dtggeneral.Visible = False
        dtgcoincidentes.Visible = True
    End Sub
    ''btn guarda inbound
    'Protected Sub btnguardar2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar2.Click
    '    Try
    '        Dim objdatos As New clscrmdatos
    '        If rdbtipoinb.SelectedIndex = 0 Then
    '            Throw New Exception("Digite el tipo de llamada inbound, Corporativo o Fidelización")
    '        End If
    '        If txtminnv.Text = "" Then
    '            Throw New Exception("Digite el Min del caso recibido en Inbound")
    '        End If
    '        If txtplannv.Text = "" Then
    '            Throw New Exception("Digite el plan del caso recibido en Inbound")
    '        End If
    '        If txtidentifnv.Text = "" Then
    '            Throw New Exception("Digite la identificación del usuario del caso recibido en Inbound")
    '        End If
    '        If txtnombrenv.Text = "" Then
    '            Throw New Exception("Digite el nombre del usuario del caso recibido en Inbound")
    '        End If

    '        objdatos.min = txtminnv.Text
    '        objdatos.plan = txtplannv.Text
    '        objdatos.identificacion = txtidentifnv.Text
    '        objdatos.nompaquete = txtnombrenv.Text
    '        If lblobs611.Text = "" Then
    '            objdatos.tipofalla = "Registro Inbound " & rdbtipoinb.SelectedItem.Value
    '        Else
    '            objdatos.tipofalla = "Registro Inbound " & rdbtipoinb.SelectedItem.Value & " " & lblobs611.Text
    '        End If

    '        objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
    '        If TxtIngRemite.Text <> "" Then
    '            objdatos.ingn3 = TxtIngRemite.Text
    '        End If
    '        objdatos.asignaconsec()
    '        If TxtCasoNuevo.Text <> "" Then
    '            objdatos.abierto = TxtCasoNuevo.Text
    '        End If
    '        objdatos.caso = objdatos.abierto

    '        ''Validacion del caso inbaun cuando este ya est
    '        Dim dts As New DataSet
    '        dts = objdatos.Validacion_Registro_Inboun()
    '        If dts.Tables(0).Rows.Count > 0 Then
    '            objdatos.Actualizacion_Identifica_Caso_Inbound()
    '            Pnl_Message.CssClass = "alert alert-info"
    '            lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Caso reconocido como inbound"
    '        Else
    '            objdatos.registroinb()
    '            Pnl_Message.CssClass = "alert alert-success"
    '            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro inbound ingresado con éxito"
    '        End If
    '        'objdatos.registroinb()
    '        txtcaso.Text = objdatos.abierto
    '        Btn_Consultar_Click(1, Nothing)
    '        pnnuevo.Visible = False
    '        'PanelGestion.Visible = True
    '        txtminnv.Text = ""
    '        txtplannv.Text = ""
    '        txtidentifnv.Text = ""
    '        rdbtipoinb.SelectedIndex = 0
    '        txtnombrenv.Text = ""
    '        TxtCasoNuevo.Text = ""
    '        TxtIngRemite.Text = ""
    '    Catch ex As Exception
    '        Obj_G_D.Val_Ex(ex)
    '        Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
    '        lblmsg.Text = Obj_G_D.Ex("Message")
    '    End Try
    'End Sub
    ''btn muestra inbound
    'Protected Sub btncrea_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncrea.Click
    '    Try
    '        If txtcaso.Text = "" Then
    '            Throw New Exception("Consulte el caso")
    '        End If
    '        BuscarInfInbound()
    '        pnnuevo.Visible = True
    '        PNEscalam.Visible = False
    '        Pninc.Visible = False
    '    Catch ex As Exception
    '        Obj_G_D.Val_Ex(ex)
    '        Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
    '        lblmsg.Text = Obj_G_D.Ex("Message")
    '    End Try
    'End Sub
    '--------Botones-----------
    'habilita condiciones de uso
    Protected Sub Btn_Habilita_Tecnologia_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Habilita_Tecnologia.Click
        Try
            drlFtectolog.Enabled = True
            Btn_Habilita_Tecnologia.Visible = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'habilita equipo
    Protected Sub Btn_Habilita_Equipo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Habilita_Equipo.Click
        Try
            drlmarca.Enabled = True
            drlequipo.Enabled = True
            Btn_Habilita_Equipo.Visible = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'habilita municipio
    Protected Sub Btn_Habilita_Municipio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Habilita_Municipio.Click
        Try
            drldpto.Enabled = True
            drlmun.Enabled = True
            Btn_Habilita_Municipio.Visible = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'habilita barrio
    Protected Sub Btn_Habilita_Barrio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Habilita_Barrio.Click
        Try
            txtbarrio.Enabled = True
            Btn_Habilita_Barrio.Visible = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'habilita ult caida
    Protected Sub Btn_Habilita_Fc_Utl_Caida_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Habilita_Fc_Utl_Caida.Click
        Try
            txtultimc.Enabled = True
            drlfranja.Enabled = True
            Btn_Habilita_Fc_Utl_Caida.Visible = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'habilita pqr
    Protected Sub Btn_Habilita_PQR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Habilita_PQR.Click
        Try
            TxtPQR.Enabled = True
            drlTipo_PQR.Enabled = True
            Btn_Habilita_PQR.Visible = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
#End Region
#Region "Drl's"
    'Cargar Drl's
    Protected Sub Cargar_Drls()
        Try
            If Not IsPostBack Then
                '--------inconsistencia encuesta 611---------'
                With drlinconsistencia
                    .DataSource = Obj_General.Consulta_inconsistencia_encuesta
                    .DataTextField = "Nombre"
                    .DataValueField = "Cod_BD_Datos_Complemento"
                    .DataBind()
                    drlinconsistencia = Obj_G_D.Gest_Drl(drlinconsistencia)
                End With
                'Inconsistencia Global - tipificacion
                With drlinconsglobal
                    Obj_General.cargo = "Global"
                    .DataSource = Obj_General.consultaincdatos
                    .DataTextField = "inconsistencia"
                    .DataValueField = "idtipoinc"
                    .DataBind()
                    drlinconsglobal = Obj_G_D.Gest_Drl(drlinconsglobal)
                End With
                Cargar_drlvariable(6)
                'divipola - dpto
                With drldpto
                    .DataSource = Obj_General.consultadpto
                    .DataTextField = "nombredpto"
                    .DataValueField = "coddpto"
                    .DataBind()
                    drldpto = Obj_G_D.Gest_Drl(drldpto)
                End With
                With drlFtectolog
                    Obj_General.idusuario = 4
                    .DataSource = Obj_General.consultadiagnostico
                    .DataTextField = "detalle"
                    .DataValueField = "idreg"
                    .DataBind()
                    drlFtectolog = Obj_G_D.Gest_Drl(drlFtectolog)
                End With
                'Marcar
                With drlmarca
                    .DataSource = Obj_General.consultamarca
                    .DataTextField = "marca"
                    .DataValueField = "marca"
                    .DataBind()
                    drlmarca = Obj_G_D.Gest_Drl(drlmarca)
                End With
                'Tipo PQR
                With drlTipo_PQR
                    Obj_General.Validacion = "Tipo PQR"
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Servicio_V2
                    .DataTextField = "tipo2"
                    .DataValueField = "tipo2"
                    .DataBind()
                    drlTipo_PQR = Obj_G_D.Gest_Drl(drlTipo_PQR)
                End With
                'Justificacion Seguimiento
                With Drl_justificacion_seguimiento
                    Obj_General.Validacion = "Justificacion"
                    .DataSource = Obj_General.consulta_campaña_inb
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_justificacion_seguimiento = Obj_G_D.Gest_Drl(Drl_justificacion_seguimiento)
                End With
                ''Modalidad
                With drlModalidad
                    Obj_General.Validacion = "Modalidad"
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Servicio_V2
                    .DataTextField = "tipo2"
                    .DataValueField = "tipo2"
                    .DataBind()
                    drlModalidad = Obj_G_D.Gest_Drl(drlModalidad)
                End With
                'Linea de servicio
                With drllinea
                    Obj_General.Validacion = "linea_serv"
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Diagnostico2
                    .DataTextField = "tipificacion1"
                    .DataValueField = "tipificacion1"
                    .DataBind()
                    drllinea = Obj_G_D.Gest_Drl(drllinea)
                End With
                '____________________________tecnica_____________________
                'caracteristicas
                With drlFcaract
                    .DataSource = Obj_General.consultacaractdat
                    .DataTextField = "desccarac"
                    .DataValueField = "idcarac"
                    .DataBind()
                    drlFcaract = Obj_G_D.Gest_Drl(drlFcaract)
                End With
                'Tipo de Edificacion Donde se Presenta la Falla
                With Drl_Tipo_Edificacion_Donde_Presenta_Falla_1
                    Obj_General.Validacion = "VF_Tipo_Edificacion_Donde_Presenta_Falla_1"
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_Tipo_Edificacion_Donde_Presenta_Falla_1 = Obj_G_D.Gest_Drl(Drl_Tipo_Edificacion_Donde_Presenta_Falla_1)
                End With
                With Drl_Tipo_Edificacion_Donde_Presenta_Falla_2
                    Obj_General.Validacion = "VF_Tipo_Edificacion_Donde_Presenta_Falla_2"
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_Tipo_Edificacion_Donde_Presenta_Falla_2 = Obj_G_D.Gest_Drl(Drl_Tipo_Edificacion_Donde_Presenta_Falla_2)
                End With
                'Tecnologia en la que se Presenta la Falla Luego de pruebas
                With Drl_Tecnologia_Presenta_Falla_Luegodepruebas
                    Obj_General.Validacion = "VF_Tecnologia_Presenta_Falla_Luegodepruebas"
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_Tecnologia_Presenta_Falla_Luegodepruebas = Obj_G_D.Gest_Drl(Drl_Tecnologia_Presenta_Falla_Luegodepruebas)
                End With
                'Para cuando la opcion "No existen cambios administrativos sobre la línea o cuenta maestra" sea falsoSplit_Billing
                With Drl_Split_Billing
                    Obj_General.Validacion = "Split_Billing"
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_Split_Billing = Obj_G_D.Gest_Drl(Drl_Split_Billing)
                End With
                'Valores de HLR_HSS
                With Drl_HLR_HSS
                    Obj_General.Validacion = "HLR_HSS"
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_HLR_HSS = Obj_G_D.Gest_Drl(Drl_HLR_HSS)
                End With
                'Se forza la red del dispositivo
                With Drl_Forza_Red_Dispositivo
                    Obj_General.Validacion = "VF_Forza_Red_Dispositivo"
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_Forza_Red_Dispositivo = Obj_G_D.Gest_Drl(Drl_Forza_Red_Dispositivo)
                End With
                'Se verifica o realiza configuración de APN
                With Drl_Verifica_Realiza_Configuración_APN
                    Obj_General.Validacion = "VF_Verifica_Realiza_Configuración_APN"
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_Verifica_Realiza_Configuración_APN = Obj_G_D.Gest_Drl(Drl_Verifica_Realiza_Configuración_APN)
                End With
                ' Qos
                With Drl_Qos
                    Obj_General.Validacion = "VF_Qos"
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_Qos = Obj_G_D.Gest_Drl(Drl_Qos)
                End With
                'sevice  detalle
                With drlapn
                    .DataSource = Obj_General.consultaapn
                    .DataTextField = "apn"
                    .DataValueField = "apn"
                    .DataBind()
                    drlapn = Obj_G_D.Gest_Drl(drlapn)
                End With
                With drlqos
                    .DataSource = Obj_General.consultaqos
                    .DataTextField = "qos"
                    .DataValueField = "qos"
                    .DataBind()
                    drlqos = Obj_G_D.Gest_Drl(drlqos)
                End With
                With drl_causal_escalamiento_service
                    Obj_General.idusuario = 31
                    .DataSource = Obj_General.consultadiagnostico
                    .DataTextField = "detalle"
                    .DataValueField = "idreg"
                    .DataBind()
                    drl_causal_escalamiento_service = Obj_G_D.Gest_Drl(drl_causal_escalamiento_service)
                End With
                'ubicacion call
                Obj_General.Validacion = "Ubicacion_call2"
                With drl_ubicacion_call
                    .DataSource = Obj_General.consulta_campaña_inb
                    .DataTextField = "nombre"
                    .DataValueField = "valor"
                    .DataBind()
                    drl_ubicacion_call = Obj_G_D.Gest_Drl(drl_ubicacion_call)
                End With

                drlfranja = Obj_G_D.Gest_Drl(drlfranja)
                DrlLibera = Obj_G_D.Gest_Drl(DrlLibera)
                drl611 = Obj_G_D.Gest_Drl(drl611)
                drlFtiempo = Obj_G_D.Gest_Drl(drlFtiempo)
                drlFportada = Obj_G_D.Gest_Drl(drlFportada)
                drlFlineasfalla = Obj_G_D.Gest_Drl(drlFlineasfalla)
                Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania = Obj_G_D.Gest_Drl(Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania)
                Drl_Linea_No_Cuenta_Bloqueos_Internet = Obj_G_D.Gest_Drl(Drl_Linea_No_Cuenta_Bloqueos_Internet)
                Drl_Linea_No_Encuentra_Enrutada_PorPagos = Obj_G_D.Gest_Drl(Drl_Linea_No_Encuentra_Enrutada_PorPagos)
                Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = Obj_G_D.Gest_Drl(Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra)
                Drl_Equipo_Encuentra_Homologado_Operador = Obj_G_D.Gest_Drl(Drl_Equipo_Encuentra_Homologado_Operador)
                Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = Obj_G_D.Gest_Drl(Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio)
                Drl_Validaciones_Falla_Masiva = Obj_G_D.Gest_Drl(Drl_Validaciones_Falla_Masiva)
                Drl_Linea_No_Superado_Limite_Consumos = Obj_G_D.Gest_Drl(Drl_Linea_No_Superado_Limite_Consumos)
                Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = Obj_G_D.Gest_Drl(Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla)
                Drl_Realiza_Conciliacion_Sobre_linea = Obj_G_D.Gest_Drl(Drl_Realiza_Conciliacion_Sobre_linea)
                drlnivel = Obj_G_D.Gest_Drl(drlnivel)

            Else
                drl_ubicacion_call.SelectedIndex = 0
                drlinconsistencia.SelectedIndex = 0
                drlinconsglobal.SelectedIndex = 0
                drldpto.SelectedIndex = 0
                drlFtectolog.SelectedIndex = 0
                drlmarca.SelectedIndex = 0
                drlTipo_PQR.SelectedIndex = 0
                Drl_justificacion_seguimiento.SelectedIndex = 0
                drlModalidad.SelectedIndex = 0
                drllinea.SelectedIndex = 0
                drlFcaract.SelectedIndex = 0
                Drl_Tipo_Edificacion_Donde_Presenta_Falla_1.SelectedIndex = 0
                Drl_Tipo_Edificacion_Donde_Presenta_Falla_2.SelectedIndex = 0
                Drl_Tecnologia_Presenta_Falla_Luegodepruebas.SelectedIndex = 0
                Drl_Split_Billing.SelectedIndex = 0
                Drl_HLR_HSS.SelectedIndex = 0
                Drl_Forza_Red_Dispositivo.SelectedIndex = 0
                Drl_Verifica_Realiza_Configuración_APN.SelectedIndex = 0
                Drl_Qos.SelectedIndex = 0
                drlapn.SelectedIndex = 0
                drlqos.SelectedIndex = 0
                drl_causal_escalamiento_service.SelectedIndex = 0

                'limpiar enbebidos en html
                drlfranja.SelectedIndex = 0
                DrlLibera.SelectedIndex = 0
                drl611.SelectedIndex = 0
                drlFtiempo.SelectedIndex = 0
                drlFportada.SelectedIndex = 0
                drlFlineasfalla.SelectedIndex = 0
                Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania.SelectedIndex = 0
                Drl_Linea_No_Cuenta_Bloqueos_Internet.SelectedIndex = 0
                Drl_Linea_No_Encuentra_Enrutada_PorPagos.SelectedIndex = 0
                Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedIndex = 0
                Drl_Equipo_Encuentra_Homologado_Operador.SelectedIndex = 0
                Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio.SelectedIndex = 0
                Drl_Validaciones_Falla_Masiva.SelectedIndex = 0
                Drl_Linea_No_Superado_Limite_Consumos.SelectedIndex = 0
                Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla.SelectedIndex = 0
                Drl_Realiza_Conciliacion_Sobre_linea.SelectedIndex = 0
                drlnivel.SelectedIndex = 0
            End If
            drlinconsglobal_SelectedIndexChanged(1, Nothing)
            drldpto_SelectedIndexChanged(1, Nothing)
            drlmarca_SelectedIndexChanged(1, Nothing)
            drllinea_SelectedIndexChanged(1, Nothing)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'Cargar Drl_Variable
    Protected Sub Cargar_drlvariable(ByVal Cod As Integer)
        Try
            With drlvariable
                If Cod <> Nothing Then
                    Obj_General.idusuario = Cod
                    .DataSource = Obj_General.consultadiagnostico
                    .DataTextField = "detalle"
                    .DataValueField = "idreg"
                    .DataBind()
                Else
                    .Items.Clear()
                End If
                drlvariable = Obj_G_D.Gest_Drl(drlvariable)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    '______________Drls_SelectedIndexChanged______________
    'marca drl
    Protected Sub drlmarca_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlmarca.SelectedIndexChanged
        Try
            With drlequipo
                If drlmarca.SelectedIndex > 0 Then
                    Obj_General.estado = drlmarca.SelectedItem.Value
                    .DataSource = Obj_General.consultaequipo
                    .DataTextField = "equipo"
                    .DataValueField = "equipo"
                    .DataBind()
                Else
                    .Items.Clear()
                End If
                drlequipo = Obj_G_D.Gest_Drl(drlequipo)
            End With
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Obj_G_D.Val_Ex(ex)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Throw ex
            End If
        End Try
    End Sub
    'dpto drl
    Protected Sub drldpto_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drldpto.SelectedIndexChanged
        Try
            With drlmun
                If drldpto.SelectedIndex > 0 Then
                    Obj_General.dpto = drldpto.SelectedItem.Value
                    .DataSource = Obj_General.consultamun
                    .DataTextField = "nombremun"
                    .DataValueField = "coddiv"
                    .DataBind()
                Else
                    .Items.Clear()
                End If
                drlmun = Obj_G_D.Gest_Drl(drlmun)
            End With
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Obj_G_D.Val_Ex(ex)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Throw ex
            End If
        End Try
    End Sub
    'drl linea
    Protected Sub drllinea_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drllinea.SelectedIndexChanged
        Try
            With drlservicio2
                If drllinea.SelectedIndex > 0 Then
                    Obj_General.Validacion = "servicio"
                    Obj_General.Cod_Diagnostico = drllinea.SelectedValue
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Diagnostico2
                    .DataTextField = "tipificacion2"
                    .DataValueField = "cod_tipificacion"
                    .DataBind()
                Else
                    .Items.Clear()
                End If
                drlservicio2 = Obj_G_D.Gest_Drl(drlservicio2)
            End With
            drlservicio2_SelectedIndexChanged(1, Nothing)
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Obj_G_D.Val_Ex(ex)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Throw ex
            End If
        End Try
    End Sub
    'drl servicio
    Protected Sub drlservicio2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlservicio2.SelectedIndexChanged
        Try
            With drlsolicitud
                If drlservicio2.SelectedIndex > 0 Then
                    Obj_General.Validacion = "solictid_falla"
                    Obj_General.Cod_Diagnostico = drlservicio2.SelectedValue
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Diagnostico2
                    .DataTextField = "tipificacion1"
                    .DataValueField = "cod_tipificacion"
                    .DataBind()
                Else
                    .Items.Clear()
                End If
                drlsolicitud = Obj_G_D.Gest_Drl(drlsolicitud)
            End With
            drlsolicitud_SelectedIndexChanged(1, Nothing)
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Obj_G_D.Val_Ex(ex)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Throw ex
            End If
        End Try
    End Sub
    'drl solicitud
    Protected Sub drlsolicitud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlsolicitud.SelectedIndexChanged
        Try
            With drlSegmento
                If drlsolicitud.SelectedIndex > 0 Then
                    Obj_General.Validacion = "segmento"
                    Obj_General.Cod_Diagnostico = drlsolicitud.SelectedValue
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Diagnostico2
                    .DataTextField = "tipificacion1"
                    .DataValueField = "tipificacion1"
                    .DataBind()
                Else
                    .Items.Clear()
                End If
                drlSegmento = Obj_G_D.Gest_Drl(drlSegmento)
            End With
            drlSegmento_SelectedIndexChanged(1, Nothing)
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Obj_G_D.Val_Ex(ex)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Throw ex
            End If
        End Try
    End Sub
    'drl segmento
    Protected Sub drlSegmento_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlSegmento.SelectedIndexChanged
        Try
            With drlCausa_Raiz
                If drlSegmento.SelectedIndex > 0 And drlsolicitud.SelectedIndex > 0 Then
                    Obj_General.Validacion = "causa_falla"
                    Obj_General.Cod_Diagnostico = drlSegmento.SelectedValue
                    Obj_General.nombre = drlsolicitud.SelectedValue
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Diagnostico2
                    .DataTextField = "tipificacion2"
                    .DataValueField = "cod_tipificacion"
                    .DataBind()
                Else
                    .Items.Clear()
                End If
                drlCausa_Raiz = Obj_G_D.Gest_Drl(drlCausa_Raiz)
            End With
            drlCausa_Raiz_SelectedIndexChanged(1, Nothing)
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Obj_G_D.Val_Ex(ex)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Throw ex
            End If
        End Try
    End Sub
    'drl causa raiz
    Protected Sub drlCausa_Raiz_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drlCausa_Raiz.SelectedIndexChanged
        Try
            With drltipificacionll
                If drlCausa_Raiz.SelectedIndex > 0 Then
                    Obj_General.Validacion = "estado"
                    Obj_General.Cod_Diagnostico = drlCausa_Raiz.SelectedValue
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Diagnostico2
                    .DataTextField = "tipificacion1"
                    .DataValueField = "cod_tipificacion"
                    .DataBind()
                Else
                    .Items.Clear()
                End If
                drltipificacionll = Obj_G_D.Gest_Drl(drltipificacionll)
            End With
            drltipificacionll_SelectedIndexChanged(1, Nothing)
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Obj_G_D.Val_Ex(ex)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Throw ex
            End If
        End Try
    End Sub
    'drl estado
    Protected Sub drltipificacionll_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drltipificacionll.SelectedIndexChanged
        Try
            With drlCategoriaCierre
                If drltipificacionll.SelectedIndex > 0 Then
                    Obj_General.Validacion = "categoria"
                    Obj_General.Cod_Causa_Raiz = drlCausa_Raiz.SelectedValue
                    Obj_General.Cod_Diagnostico = drltipificacionll.SelectedValue
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Diagnostico2
                    .DataTextField = "tipificacion1"
                    .DataValueField = "cod_tipificacion"
                    .DataBind()
                Else
                    .Items.Clear()
                End If
                drlCategoriaCierre = Obj_G_D.Gest_Drl(drlCategoriaCierre)
            End With
            'FALLA DE RED
            If drltipificacionll.SelectedItem.Text.Contains("CPD") Then
                Pninc.Visible = False
                PNEscalam.Visible = True
                LinkButton3.Visible = True
                LinkButton4.Visible = False
                pnservice.Visible = False
                pnservice.Visible = False
                txtFcontacto.Text = lblcliente.Text
                txtFnum.Text = txtnumalt.Text
                Panel_seguimiento.Visible = False
                ''SERVICE
            ElseIf drltipificacionll.SelectedItem.Text.Contains("SD") Then
                pnservice.Visible = True
                Pninc.Visible = False
                PNEscalam.Visible = False
                LinkButton3.Visible = True
                LinkButton4.Visible = False
                Panel_seguimiento.Visible = False
            ElseIf drltipificacionll.SelectedItem.Text.Contains("Programado") Then
                PNEscalam.Visible = False
                Pninc.Visible = False
                LinkButton3.Visible = True
                LinkButton4.Visible = False
                pnservice.Visible = False
                Panel_seguimiento.Visible = True
            Else
                pnservice.Visible = False
                Pninc.Visible = False
                PNEscalam.Visible = False
                LinkButton3.Visible = True
                LinkButton4.Visible = False
                Panel_seguimiento.Visible = False
            End If

            If drltipificacionll.SelectedItem.Text <> "Cerrado" And Not drltipificacionll.SelectedItem.Text.Contains("Solici") And drltipificacionll.SelectedItem.Text <> "Falla Masiva" And drltipificacionll.SelectedIndex > 0 Then
                Panel_Justificacion.Visible = True
            Else
                Panel_Justificacion.Visible = False
                Drl_justificacion_seguimiento.SelectedIndex = 0
            End If
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Obj_G_D.Val_Ex(ex)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Throw ex
            End If
        End Try
    End Sub
    'error en registro
    Protected Sub drlvariable_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlvariable.SelectedIndexChanged
        Try
            If drlvariable.SelectedIndex > 0 Then
                Dim objdatos As New clscrmdatos
                objdatos.diagservicio = drlvariable.SelectedItem.Value
                objdatos.consultaproceso()
                lblvariable.Text = objdatos.tipificacion
            End If
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Obj_G_D.Val_Ex(ex)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Throw ex
            End If
        End Try
    End Sub
    'inconsistencia
    Protected Sub drlinconsglobal_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlinconsglobal.SelectedIndexChanged
        Try
            With drlincons
                If drlinconsglobal.SelectedIndex > 0 Then
                    Obj_General.cargo = "Inconsistencia"
                    Obj_General.estado = drlinconsglobal.Text
                    .DataSource = Obj_General.consultaincdatos
                    .DataTextField = "inconsistencia"
                    .DataValueField = "idtipoinc"
                    .DataBind()
                Else
                    .Items.Clear()
                End If
                drlincons = Obj_G_D.Gest_Drl(drlincons)
            End With
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Obj_G_D.Val_Ex(ex)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Throw ex
            End If
        End Try
    End Sub
    'drl no existen cambios
    Protected Sub Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedIndexChanged
        Try
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text = "FALSO" Then
                Drl_Split_Billing.Visible = True
            Else
                Drl_Split_Billing.Visible = False
            End If
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Obj_G_D.Val_Ex(ex)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Throw ex
            End If
        End Try
    End Sub
    'Nuevo traza
    Protected Sub drl611_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drl611.SelectedIndexChanged
        Try
            If drl611.SelectedIndex = 0 Then
                TxtPercep_Serv.Enabled = False
            Else
                TxtPercep_Serv.Enabled = True
            End If
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Obj_G_D.Val_Ex(ex)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Throw ex
            End If
        End Try
    End Sub
    'drl inconsistencia
    Protected Sub drlinconsistencia_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlinconsistencia.SelectedIndexChanged
        Try
            If drlinconsistencia.SelectedItem.Text = "Otro" Then
                txtobsincon.Enabled = True
            Else
                txtobsincon.Enabled = False
                txtobsincon.Text = ""
            End If
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Obj_G_D.Val_Ex(ex)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Throw ex
            End If
        End Try
    End Sub
    'drl casua escalamiento
    Protected Sub drl_causal_escalamiento_service_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drl_causal_escalamiento_service.SelectedIndexChanged
        Try
            If drl_causal_escalamiento_service.SelectedIndex = 0 Or drl_causal_escalamiento_service.SelectedItem.Text = "Otros" Then
                drlapn.SelectedIndex = 0
                drlapn.Enabled = True
                drlqos.SelectedIndex = 0
                drlqos.Enabled = True
                txtfcactivacion.Text = ""
                txtfcactivacion.Enabled = True
                drlvariable.SelectedIndex = 0
                drlvariable.Enabled = True
                drlvariable_SelectedIndexChanged(1, Nothing)
                lbl_Fecha_Act_Ciclo.Text = "Fecha Activacion"
            ElseIf drl_causal_escalamiento_service.SelectedItem.Text = "Linea No Registra" Then
                drlapn.SelectedIndex = 0
                drlapn.Enabled = False
                drlqos.SelectedIndex = 0
                drlqos.Enabled = False
                txtfcactivacion.Text = ""
                txtfcactivacion.Enabled = False
                drlvariable.SelectedIndex = 2
                drlvariable.Enabled = False
                drlvariable_SelectedIndexChanged(1, Nothing)
                lbl_Fecha_Act_Ciclo.Text = "Fecha Activacion"
            ElseIf drl_causal_escalamiento_service.SelectedItem.Text = "Aprovisionamiento de Paquetes Prepago" Then
                drlapn.SelectedIndex = 0
                drlapn.Enabled = True
                drlqos.SelectedIndex = 0
                drlqos.Enabled = True
                txtfcactivacion.Text = ""
                txtfcactivacion.Enabled = True
                drlvariable.SelectedIndex = 1
                drlvariable.Enabled = False
                drlvariable_SelectedIndexChanged(1, Nothing)
                lbl_Fecha_Act_Ciclo.Text = "Fecha Activacion"
            ElseIf drl_causal_escalamiento_service.SelectedItem.Text = "Reinicio de Ciclo - Linea Postpago" Then
                drlapn.SelectedIndex = 0
                drlapn.Enabled = True
                drlqos.SelectedIndex = 0
                drlqos.Enabled = True
                txtfcactivacion.Text = ""
                txtfcactivacion.Enabled = True
                drlvariable.SelectedIndex = 6
                drlvariable.Enabled = False
                drlvariable_SelectedIndexChanged(1, Nothing)
                lbl_Fecha_Act_Ciclo.Text = "Fecha de Ciclo"
            End If
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Obj_G_D.Val_Ex(ex)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Throw ex
            End If
        End Try
    End Sub
    'drlnivel
    Protected Sub drlnivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlnivel.SelectedIndexChanged
        Try
            If drlnivel.SelectedItem.Text = "Operacion" Then
                With drl_ubicacion_call
                    .Items.Insert(drl_ubicacion_call.Items.Count, "Kamilion")
                    .Items(drl_ubicacion_call.Items.Count - 1).Value = "KM"
                    .SelectedValue = "KM"
                    .Enabled = False
                End With
            Else
                If drl_ubicacion_call.Items.IndexOf(drl_ubicacion_call.Items.FindByText("Kamilion")) > 0 Then
                    drl_ubicacion_call.Items.RemoveAt(drl_ubicacion_call.Items.IndexOf(drl_ubicacion_call.Items.FindByText("Kamilion")))
                End If
                drl_ubicacion_call.Enabled = True
                drl_ubicacion_call.SelectedIndex = 0
            End If
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Obj_G_D.Val_Ex(ex)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Throw ex
            End If
        End Try
    End Sub
#End Region
#Region "Check"
    'check falla masiva
    Protected Sub chkmasiva_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkmasiva.CheckedChanged
        Try
            Consultar_Falla_Masiva()
            If lblobsmasiva.Text = Nothing Then
                Throw New Exception("No se registra falla masiva en estos momentos, por favor gestione el caso de forma individual")
            Else
                lblmsg.Text = Nothing
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

            If objdatos.diagtecnolog <> " " And objdatos.diagtecnolog <> "0" Then
                drlFtectolog.SelectedValue = objdatos.diagtecnolog
            End If
            If objdatos.marca <> " " And objdatos.marca <> "" Then
                drlmarca.SelectedValue = objdatos.marca
                drlmarca_SelectedIndexChanged(1, Nothing)
                drlequipo.SelectedValue = objdatos.equipo
            End If
            If objdatos.idservicio <> " " And objdatos.idservicio <> "0" Then
                Cargar_drlvariable(objdatos.idservicio)
                drlvariable.SelectedValue = objdatos.diagvariable
            End If
            If objdatos.dpto <> " " And objdatos.dpto <> "0" Then
                drldpto.SelectedValue = objdatos.dpto
                drldpto_SelectedIndexChanged(1, Nothing)
                drlmun.SelectedValue = objdatos.mun
            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
#End Region
#Region "Dtg"
    '---------DTGs-----------
    'dtg seguimentos
    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtggeneral.DataSource = ViewState("dtggeneral")
            dtggeneral.DataBind()
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'dtg coincidentes
    Protected Sub dtgcoincidentes_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgcoincidentes.PageIndexChanging
        Try
            dtgcoincidentes.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtgcoincidentes.DataSource = ViewState("dtgcoincidentes")
            dtgcoincidentes.DataBind()
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'paginado programados
    Protected Sub dtgasig_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgasig.PageIndexChanging
        Try

            dtgasig.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtgasig.DataSource = ViewState("dtgasig")
            dtgasig.DataBind()
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub

    'chk si num alterno
    Protected Sub Si_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkSi.CheckedChanged
        Try
            If chkSi.Checked = True Then
                txtnumalt.Visible = True
                txtnumalt.Text = ""
            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'chk no num alterno
    Protected Sub chkNo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkNo.CheckedChanged
        Try
            If chkNo.Checked = True Then
                txtnumalt.Visible = False
                txtnumalt.Text = ""
            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
#End Region



End Class