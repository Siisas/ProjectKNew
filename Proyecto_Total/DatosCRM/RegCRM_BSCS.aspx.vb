Public Class RegCRM_BSCS
    Inherits System.Web.UI.Page
    Dim control As String
    Protected Obj_General As New clsgeneral
    Protected Obj_G_D As New Cls_Gestion_Datos
    'inicio
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Limpiar_Herramientas()
                Dim objGnrl As New clsgeneral
                Dim dt As New DataSet
                Session("Formulario") = "Registro BSCS"
                objGnrl.idusuario = CType(Session("permisos"), clsusuario).usuario
                traeprogramados()
                consultafallamasiva()
                LblPQR.Text = objGnrl.Consulta_Numero_PQR().Tables(0).Rows(0).Item("Nombre")
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
#Region "Métodos"
    'LIMPIAR HERRAMIENTAS
    Protected Sub Limpiar_Herramientas()
        Try
            '''''''''''''''''''' LIMPIA CARGUE DE INFORMACION  ''''''''''''''''''''
            ViewState("dtggeneral") = Nothing
            dtggeneral.DataSource = Nothing
            dtggeneral.DataBind()
            ViewState("dtgcoincidentes") = Nothing
            dtgcoincidentes.DataSource = Nothing
            dtgcoincidentes.DataBind()
            ViewState("Dtg_Control_Bscs") = Nothing
            Dtg_Control_Bscs.DataSource = Nothing
            Dtg_Control_Bscs.DataBind()
            btnguardar.Visible = False
            lblmin.Text = Nothing
            lblcaso.Text = Nothing
            lblcliente.Text = Nothing
            lbldocumento.Text = Nothing
            lblequipo.Text = Nothing
            lblplan.Text = Nothing
            lbllugar.Text = Nothing
            lblemail.Text = Nothing
            lblestado.Text = Nothing
            lblobs611.Text = Nothing
            lblfallatec.Text = Nothing
            Lblfc_ingreso.Text = Nothing
            lblnumeroaler.Text = Nothing
            lblobsmasiva.Text = Nothing
            chkmasiva.Checked = False
            'GEORREFERENCIACIÓN
            '' CIERRE DE LLAMADA ''
            txtultimc.Text = Nothing
            txtbarrio.Text = Nothing
            TxtPQR.Text = Nothing
            txtfcprog.Text = Nothing
            txtnumalt.Text = Nothing
            TxtPercep_Serv.Text = Nothing
            txtobsincon.Text = Nothing
            txtobsincon.Enabled = False
            txtnumalt.Visible = False
            Txt_N_Doc_Id_CPD.Text = Nothing
            txtfobs.Text = Nothing
            txtFdirecc.Text = Nothing
            txtFciudad.Text = Nothing
            txtFtipofalla.Text = Nothing
            txtFcontacto.Text = Nothing
            txtFnum.Text = Nothing
            txtapn.Text = Nothing
            Txt_Validacion_Coordenadas.Text = Nothing
            txtfcactivacion.Text = Nothing
            txtobs.Text = Nothing
            chkSi.Checked = False
            chkNo.Checked = False
            Drl_Actualizacion_CMC.Enabled = True
            Drl_Causa_Raiz_Linea.Enabled = False
            Drl_Linea_CMC.Enabled = False
            Drl_Novedad_CMC.Enabled = False
            'drlvariable_SelectedIndexChanged(1, Nothing)
            Panel_Justificacion.Visible = False
            '' HABILITAR 
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
            Btn_Habilita_Tecnologia.Visible = False
            Btn_Habilita_Equipo.Visible = False
            Btn_Habilita_Municipio.Visible = False
            Btn_Habilita_Barrio.Visible = False
            Btn_Habilita_Fc_Utl_Caida.Visible = False
            Btn_Habilita_PQR.Visible = False
            'SERVICE
            drlapn.Enabled = True
            drlqos.Enabled = True
            txtfcactivacion.Enabled = True
            drlvariable.Enabled = True
            lbl_Fecha_Act_Ciclo.Text = "Fecha Activacion"
            'TECNICA
            Pninc.Visible = False
            PNEscalam.Visible = False
            rdbvc.selectedvalue = Nothing
            ''''''''''''SERVICIO CLIENTE'''''''
            lblcuenta1.Text = 0
            cargadrl()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'CONSULTA FALLA MASIVA
    Protected Sub consultafallamasiva()
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
    'TRAE PROGRAMADOS
    Protected Sub traeprogramados()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.Validacion = "BSCS"
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
    'GUARDA DIAGNOSTICO
    Protected Sub guardadiagnostico()
        Try
            Dim objdatos As New clscrmdatos

            If drlsolicitud.SelectedIndex > 0 Or drlFtectolog.SelectedIndex > 0 Or drlvariable.SelectedIndex > 0 Or drlmun.SelectedIndex > 0 Or txtultimc.Text <> "" Then
                '-----------Inconsistencia-------------'
                If drlinconsistencia.SelectedIndex = 0 Then
                    objdatos.inconsistencia_encuesta = ""
                ElseIf drlinconsistencia.SelectedItem.Text <> "Otro" Then
                    objdatos.inconsistencia_encuesta = drlinconsistencia.SelectedItem.Text
                Else
                    objdatos.inconsistencia_encuesta = txtobsincon.Text
                End If

                If drlsolicitud.SelectedIndex = 0 Then
                    objdatos.solicitud = "0"
                Else
                    objdatos.solicitud = drlsolicitud.SelectedItem.Value
                End If
                If drlservicio2.SelectedIndex = 0 Then
                    objdatos.servreest = "0"
                Else
                    objdatos.servreest = drlservicio2.SelectedValue
                End If

                If drlFtectolog.SelectedIndex = 0 Then
                    objdatos.diagtecnolog = "0"
                Else
                    objdatos.diagtecnolog = drlFtectolog.SelectedItem.Value
                End If
                If drlvariable.SelectedIndex = 0 Then
                    objdatos.diagvariable = "0"
                Else
                    objdatos.diagvariable = drlvariable.SelectedItem.Value
                End If
                If drlmun.SelectedIndex = 0 Then
                    objdatos.mun = "0"
                Else
                    objdatos.mun = drlmun.SelectedItem.Value
                End If
                If txtbarrio.Text = "" Then
                    objdatos.barrio = ""
                Else
                    objdatos.barrio = txtbarrio.Text
                End If

                If txtultimc.Text = "" Then
                    objdatos.fcultimac = "01/01/1900"
                    objdatos.franjaultimac = ""
                Else
                    objdatos.fcultimac = txtultimc.Text
                    If drlfranja.SelectedIndex = 0 Then
                        objdatos.franjaultimac = ""
                    Else
                        objdatos.franjaultimac = drlfranja.SelectedItem.Text
                    End If
                End If
                If drlequipo.SelectedIndex = 0 Then
                    objdatos.equipo = ""
                Else
                    objdatos.equipo = drlequipo.Text
                End If
                If drlTipo_PQR.SelectedIndex = 0 Then
                    objdatos.Tipo_PQR = ""
                Else
                    objdatos.Tipo_PQR = drlTipo_PQR.SelectedItem.Text
                End If
                objdatos.Tipo_Cliente = ""
                If drlModalidad.SelectedIndex = 0 Then
                    objdatos.Modalidad = ""
                Else
                    objdatos.Modalidad = drlModalidad.SelectedItem.Text
                End If
                If drlCausa_Raiz.SelectedIndex = 0 Then
                    objdatos.Causa_Raiz = "0"
                Else
                    objdatos.Causa_Raiz = drlCausa_Raiz.SelectedValue
                End If


                If drlCategoriaCierre.SelectedIndex = 0 Then
                    objdatos.Categoria_Cierre = "0"
                Else
                    objdatos.Categoria_Cierre = drlCategoriaCierre.SelectedValue
                End If
                objdatos.caso = lblcaso.Text
                objdatos.diagtcierre = "0"
                objdatos.reclamoppal = "0"
                objdatos.tipofalla = "0"
                objdatos.Version_S_O_Equipo = " "
                objdatos.Version_Facebook = " "
                objdatos.WTF = "0"
                objdatos.registrodiag()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'ACTUALIZA BANDEJA
    Protected Sub actbandeja()
        Try
            If txtcaso.Text = "" Then
                Throw New Exception("Digite el caso que desea registrar")
            End If
            If drltipificacionll.SelectedIndex = 0 Then
                Throw New Exception("Seleccione la tipificación de la llamada")
            End If
            Dim objdatos As New clscrmdatos
            If drlequipo.SelectedIndex = 0 Then
                objdatos.equipo = ""
            End If
            objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            objdatos.equipo = drlequipo.SelectedItem.Text
            objdatos.caso = txtcaso.Text
            objdatos.chk1 = "0"
            objdatos.chk2 = "0"
            objdatos.modificarbandeja()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'GUARDAR CRM
    Protected Sub guardacrm()
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
    'BUSCAR INFORMACION
    'Protected Sub buscarinf()
    '    Try

    '    Catch ex As Exception
    '        'Pnl_Message.CssClass = "alert alert-danger"
    '        'lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
    '        Throw ex
    '    End Try
    'End Sub
    'registro escalamiento cpd
    Protected Sub Registrar_CPD()
        Try
            If txtFcontacto.Text = "" Then
                Throw New Exception("Digite la persona de contacto")
            End If
            If Txt_N_Doc_Id_CPD.Text = Nothing Then
                Throw New Exception("Ingrese el número de documento de identidad de la persona que reporta")
            ElseIf Not IsNumeric(Txt_N_Doc_Id_CPD.Text) Then
                Throw New Exception("El número de documento de identidad de la persona que reporta debe estar compuesto solo por números")
            End If
            If txtFnum.Text = "" Then
                Throw New Exception("Digite el número de contacto")
            End If
            If drlFtiempo.SelectedIndex = 0 Then
                Throw New Exception("Elija el tiempo que lleva presentándose la falla")
            End If
            If drlFcaract.SelectedIndex = 0 Then
                Throw New Exception("Describa las características del tipo de falla")
            End If
            If drlFportada.SelectedIndex = 0 Then
                Throw New Exception("Elija si la línea es portada o no")
            End If
            If drlmun.SelectedIndex = 0 Then
                Throw New Exception("Elija el Departamento y Municipio de la falla")
            End If
            If txtFdirecc.Text = "" Then
                Throw New Exception("Digite la dirección donde se presenta la falla")
            End If
            If txtbarrio.Text = "" Then
                Throw New Exception("Digite el barrio donde se presenta la falla")
            End If
            If drlFtectolog.SelectedIndex = 0 Then
                Throw New Exception("Elija la tecnología del equipo que presenta la falla")
            End If
            If drlFlineasfalla.SelectedIndex = 0 Then
                Throw New Exception("Elija si se reportan más líneas con falla en la ubicación reportada")
            End If
            If txtfobs.Text = "" Then
                Throw New Exception("Digite las observaciones reportadas por el usuario")
            End If
            If txtapn.Text = "" Then
                Throw New Exception("Digite el APN Afectado")
            End If
            If Drl_Qos.SelectedIndex = 0 Then
                Throw New Exception("Seleccione un QoS")
            End If
            If Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una opción para La falla se presenta luego de que se construyera una edificación aledaña")
            End If
            If Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una opción para La falla se presenta luego de que se remodelara la estructura física del edificio")
            End If
            If Drl_Tipo_Edificacion_Donde_Presenta_Falla_1.SelectedIndex = 0 Or Drl_Tipo_Edificacion_Donde_Presenta_Falla_2.SelectedIndex = 0 Then
                Throw New Exception("Seleccione las dos (2) opciones para Tipo de edificación donde se presenta la falla")
            End If
            If Drl_Validaciones_Falla_Masiva.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una opción para Validaciones de falla masiva")
            End If
            If Drl_Tecnologia_Presenta_Falla_Luegodepruebas.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una opción para Tecnología en la que se presenta la falla - Luego de pruebas")
            End If
            If Txt_Validacion_Coordenadas.Text = "" Then
                Throw New Exception("Ingrese un valor para Validación de Coordenadas de maximo 20 caracteres")
            End If
            If Drl_Linea_No_Cuenta_Bloqueos_Internet.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una opción para Línea no cuenta con bloqueos de Internet")
            End If
            If Drl_Linea_No_Superado_Limite_Consumos.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una opción para Línea no ha superado el limite de consumos")
            End If
            If Drl_Linea_No_Encuentra_Enrutada_PorPagos.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una opción para Línea no se encuentra enrutada por pagos")
            End If
            If Drl_HLR_HSS.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una opción para HLR / HSS")
            End If
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una opción para No existen cambios administrativos sobre la línea o cuenta maestra")
            End If
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text = "FALSO" And Drl_Split_Billing.SelectedIndex = 0 Then
                Throw New Exception("En opcion No existen cambios administrativos sobre la línea o cuenta maestra seleccione una opción de la segunda lista 'split billing'")
            End If
            If Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una opción para Se realizan pruebas de SIMCARD en otro dispositivo (Persiste Falla)")
            End If
            If Drl_Forza_Red_Dispositivo.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una opción para Se forza la red del dispositivo")
            End If
            If Drl_Verifica_Realiza_Configuración_APN.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una opción para Se verifica o realiza configuración de APN")
            End If
            If Drl_Equipo_Encuentra_Homologado_Operador.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una opción para Equipo se encuentra homologado por el operador")
            End If
            If Drl_Realiza_Conciliacion_Sobre_linea.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una opción para Se realiza conciliación sobre la línea")
            End If
            Dim Objvoz As New clsvoz
            If txtFciudad.Text <> Nothing Then
                If rdbvc.selectedvalue = Nothing And txtFciudad.Text <> Nothing Then
                    Throw New Exception("Elija si el lugar corresponde a un corregimiento, Vereda o Inspección")
                End If
                Objvoz.vereda = rdbvc.SelectedItem.Value & " " & txtFciudad.Text
            Else
                Objvoz.vereda = ""
            End If
            If txtFtipofalla.Text = "" Then
                Objvoz.tipofalla = ""
            End If
            Objvoz.N_Doc_Id = Txt_N_Doc_Id_CPD.Text
            Objvoz.telcontacto = txtFnum.Text
            Objvoz.cliente = txtFcontacto.Text
            Objvoz.tiempo = drlFtiempo.SelectedItem.Value
            Objvoz.tipofalla = txtFtipofalla.Text
            Objvoz.caracter = drlFcaract.SelectedItem.Text
            Objvoz.portada = drlFportada.SelectedItem.Value
            Objvoz.mun = drlmun.SelectedItem.Value
            Objvoz.dir = txtFdirecc.Text
            Objvoz.barrio = txtbarrio.Text
            Objvoz.tecnologia = drlFtectolog.SelectedItem.Text
            Objvoz.equipo = drlequipo.SelectedItem.Value
            Objvoz.maslineas = drlFlineasfalla.SelectedItem.Value
            Objvoz.obs = txtfobs.Text
            Objvoz.apn = txtapn.Text
            Objvoz.qos = Drl_Qos.SelectedItem.Text

            Objvoz.Falla_Presenta_Luego_Construyera_Edificacion_Aledania = Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania.SelectedItem.Text
            Objvoz.Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio.SelectedItem.Text
            Objvoz.Tipo_Edificacion_Donde_Presenta_Falla = Drl_Tipo_Edificacion_Donde_Presenta_Falla_1.SelectedItem.Text + " - " + Drl_Tipo_Edificacion_Donde_Presenta_Falla_2.SelectedItem.Text
            Objvoz.Validaciones_Falla_Masiva = Drl_Validaciones_Falla_Masiva.SelectedItem.Text
            Objvoz.Tecnologia_Presenta_Falla_Luegodepruebas = Drl_Tecnologia_Presenta_Falla_Luegodepruebas.SelectedItem.Text
            Objvoz.Validacion_Coordenadas = Txt_Validacion_Coordenadas.Text
            Objvoz.Linea_No_Cuenta_Bloqueos_Internet = Drl_Linea_No_Cuenta_Bloqueos_Internet.SelectedItem.Text
            Objvoz.Linea_No_Superado_Limite_Consumos = Drl_Linea_No_Superado_Limite_Consumos.SelectedItem.Text
            Objvoz.Linea_No_Encuentra_Enrutada_PorPagos = Drl_Linea_No_Encuentra_Enrutada_PorPagos.SelectedItem.Text
            Objvoz.HLR_HSS = Drl_HLR_HSS.SelectedItem.Text
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text = "FALSO" Then
                Objvoz.No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text + " - " + Drl_Split_Billing.SelectedItem.Text
            Else
                Objvoz.No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text
            End If
            Objvoz.Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla.SelectedItem.Text
            Objvoz.Forza_Red_Dispositivo = Drl_Forza_Red_Dispositivo.SelectedItem.Text
            Objvoz.Verifica_Realiza_Configuración_APN = Drl_Verifica_Realiza_Configuración_APN.SelectedItem.Text
            Objvoz.Equipo_Encuentra_Homologado_Operador = Drl_Equipo_Encuentra_Homologado_Operador.SelectedItem.Text
            Objvoz.Realiza_Conciliacion_Sobre_linea = Drl_Realiza_Conciliacion_Sobre_linea.SelectedItem.Text

            Objvoz.campana = "BSCS"
            Objvoz.caso = lblcaso.Text
            Objvoz.idusuario = CType(Session("permisos"), clsusuario).usuario
            Objvoz.fcini = Lblfc_ingreso.Text
            Objvoz.registrofallasred()
            guardacrm()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'registro escalamiento sd
    Protected Sub Registrar_SD()
        Try
            If drl_causal_escalamiento_service.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una causa de escalamiento")
            End If
            If drlvariable.SelectedIndex = 0 Then
                Throw New Exception("Elija un Error en Registro")
            End If

            Dim ObjSdatos As New clscrmdatos
            ObjSdatos.Causal_escalam = drl_causal_escalamiento_service.SelectedItem.Text
            If drl_causal_escalamiento_service.SelectedItem.Text = "Linea No Registra" Then
                ObjSdatos.apn = DBNull.Value.ToString
                ObjSdatos.qos = DBNull.Value.ToString
                ObjSdatos.fcini = DBNull.Value.ToString
            Else
                If drlapn.SelectedIndex = 0 Then
                    Throw New Exception("Elija el APN del caso")
                End If
                If drlqos.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione el QoS del caso")
                End If
                ObjSdatos.apn = drlapn.SelectedItem.Text
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
            If Not FileDocumento.PostedFile Is Nothing Then
                If Not FileDocumento.PostedFile Is Nothing And FileDocumento.PostedFile.ContentLength > 0 Then
                    FileDocumento.PostedFile.SaveAs(Server.MapPath("data_Doc") & "\\" & lblcaso.Text + System.IO.Path.GetExtension(FileDocumento.PostedFile.FileName))
                    ObjSdatos.archivo = lblcaso.Text + System.IO.Path.GetExtension(FileDocumento.PostedFile.FileName)
                Else
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
            guardacrm()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#Region "Btn's"
    'BOTON GUARDAR
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Try
            If lblcaso.Text = "" Then
                Throw New Exception("Consulte el caso antes de guardar el registro")
            End If
            'CASO
            If txtcaso.Text = "" Then
                Throw New Exception("Digite el caso que desea registrar")
            End If
            'LINEA
            If drllinea.SelectedIndex = 0 Then
                Throw New Exception("Seleccione linea de servicio")
            End If
            'SERVICIO
            If drlservicio2.SelectedIndex = 0 Then
                Throw New Exception("Seleccione servicio")
            End If
            'SERVICIO
            If drlservicio2.SelectedIndex = 0 Then
                Throw New Exception("Seleccione servicio")
            End If
            'SOLICITUD tipo falla
            If drlsolicitud.SelectedIndex = 0 Then
                Throw New Exception("Seleccione Solicitud / Tipo Falla")
            End If
            'SEGMENTO
            If drlSegmento.SelectedIndex = 0 Then
                Throw New Exception("Seleccione Segmento de falla")
            End If
            'CAUSA RAIZ
            If drlCausa_Raiz.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una causa raiz de falla ")
            End If
            'TIPIFICACION
            If drltipificacionll.SelectedIndex = 0 Then
                Throw New Exception("Seleccione la tipificación de la llamada ")
            End If
            'CAMPAÑA
            If drltipificacionll.SelectedItem.Text.Contains("Cerrado") Or drltipificacionll.SelectedItem.Text.Contains("Escalar") Then
                If DrlTipollamada.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione el tipo de llamada - Estado caso")
                End If
            End If
            'CATEGORIA CIERRE
            If drlCategoriaCierre.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una categoria de cierre ")
            End If
            'OBSERVACION
            If txtobs.Text = "" Then
                Throw New Exception("Digite la observación de atención al caso (OBSERVACIÓN)")
            End If
            Dim objdatos As New clscrmdatos
            objdatos.caso = txtcaso.Text
            objdatos.Validacion = 4
            objdatos.ConsultarEstados()
            'VALIDACION CIERRE
            If objdatos.tipificacion.Contains("Cerrado") Or objdatos.tipificacion.Contains("Escala") Then
                Throw New Exception("¡El Caso que desea guardar se encuentra Cerrado o Escalado!")
            End If
            'NUMERO ALTERNO'
            If chkSi.Checked = False And chkNo.Checked = False Then
                Throw New Exception("Seleccione si realizo contacto a linea alterna")
            Else
                If chkSi.Checked = True Then
                    If txtnumalt.Text = "" Then
                        Throw New Exception("Digite el numero alterno")
                    End If
                    objdatos.telalt = txtnumalt.Text
                End If
                If chkNo.Checked = True Then
                    objdatos.telalt = lblmin.Text
                End If
            End If
            'VALIDACION PROGRAMACION
            If drltipificacionll.SelectedItem.Text <> "Programado" Then
                'PQR
                If TxtPQR.Text = "" Then
                    Throw New Exception("Ingrese el consecutivo PQR")
                End If
                'TIPO PQR
                If drlTipo_PQR.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione un tipo PQR ")
                End If
                objdatos.pqr = Int64.Parse(LblPQR.Text + TxtPQR.Text)
            Else
                objdatos.pqr = 0
                objdatos.Tipo_PQR = ""
            End If
            'ACTUALIZACION cmc
            If Drl_Actualizacion_CMC.SelectedIndex = 0 Then
                Throw New Exception("Elija una Opcion en Actualizacion CMC por favor")
            End If
            'LINEA CMC Y NOVEDAD CMC
            If Drl_Actualizacion_CMC.SelectedItem.Text = "Si" Then
                '---Linea---
                If Drl_Linea_CMC.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione un Estado de Linea despues de CMC")
                End If
                If Dtg_Control_Bscs.Rows.Count < 1 Then
                    '----Novedad---
                    Drl_Novedad_CMC.Enabled = True
                    If Drl_Novedad_CMC.SelectedIndex = 0 Then
                        Throw New Exception("Seleccione Novedad CMC")
                    End If
                End If
                objdatos.Linea_CMC = Drl_Linea_CMC.SelectedItem.Text
            Else
                objdatos.Linea_CMC = ""
                objdatos.Novedad_CMC = ""
                objdatos.Id_Novedad = ""
            End If
            'CAUSA RAIZ CMC
            If drltipificacionll.SelectedItem.Text = "Cerrado" Then
                If Drl_Causa_Raiz_Linea.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione una Causa Raíz Registro de Línea")
                End If
                objdatos.Causa_CMC = Drl_Causa_Raiz_Linea.SelectedItem.Text
            End If
            'Juistificacion caso
            If drltipificacionll.SelectedItem.Text <> "Cerrado" And Not drltipificacionll.SelectedItem.Text.Contains("Solici") And drltipificacionll.SelectedItem.Text <> "Falla Masiva" Then
                If Drl_justificacion_seguimiento.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione la justificacion del seguimiento")
                End If
                objdatos.tiposoporte = Drl_justificacion_seguimiento.SelectedItem.Text
            Else
                objdatos.tiposoporte = ""
            End If
            'INCONSISTENCIA-'
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
                ElseIf drlinconsistencia.SelectedItem.Text <> "Otro" Then
                    objdatos.inconsistencia_encuesta = drlinconsistencia.SelectedItem.Text
                Else
                    objdatos.inconsistencia_encuesta = txtobsincon.Text
                End If
            End If
            objdatos.Validacion = Nothing
            objdatos.obs = txtobs.Text
            objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            objdatos.ajuste = Drl_Actualizacion_CMC.SelectedValue
            If drltipificacionll.SelectedItem.Text <> "No Contactado" And drltipificacionll.SelectedItem.Text <> "Programado" Then
                'CONDICIONES DE USO
                If drlFtectolog.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione condiciones de uso ")
                End If
                'FECHA ULTIMA CAIDA
                If txtultimc.Text <> Nothing Then
                    'valida fecha no superior a la actual
                    If Convert.ToDateTime(Me.txtultimc.Text) > Today Then
                        Throw New Exception("La fecha de caida no puede ser mayor a la fecha actual (GEORREFERENCIACIÓN - Fecha Ultima Caida)")
                    End If
                End If
                'FRANJA
                If txtultimc.Text <> "" And drlfranja.SelectedIndex = 0 Then
                    Throw New Exception("Elija la franja en la que se presentó la última caida: mañana, tarde, noche (GEORREFERENCIACIÓN - Fecha Ultima Caida)")
                End If
                'EQUIPO
                If drlequipo.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione Marca y Equipo ")
                End If
                'MUNICIPIO
                If drlmun.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione departamento y municipio ")
                End If
                'BARRIO
                If txtbarrio.Text = "" Then
                    Throw New Exception("Digite el barrio donde se presenta la falla")
                End If

                'MODALIDAD
                If drlModalidad.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione una modalidad ")
                End If
                'ATENCION 611
                If drl611.SelectedIndex > 0 Then
                    objdatos.preg1 = drl611.SelectedItem.Text
                Else
                    Throw New Exception("Seleccione Satisfecha atencion *611")
                End If
                'PERCEPCION SERVICIO
                If TxtPercep_Serv.Text <> "" Then
                    objdatos.Percep_serv = TxtPercep_Serv.Text
                Else
                    Throw New Exception("Digite Percepcion de servicio")
                End If
            Else
                objdatos.obs = txtobs.Text
                objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            End If
            'FECHA Y HORA PROGRAMADA
            If drltipificacionll.SelectedItem.Text = "Programado" Then
                If txtfcprog.Text = "" Then
                    Throw New Exception("Si la llamada es programada elija la fecha y hora a la que se debe llamar nuevamente ")
                Else
                    Dim hora As String
                    hora = Convert.ToDateTime(txtfcprog.Text)
                    If Convert.ToDateTime(hora) <= Now Then
                        Throw New Exception("La fecha de programación debe ser mayor a la fecha actual, verifique ")
                    End If
                    objdatos.horaprog = hora
                End If
            End If
            'USUARIO
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            'VALIDACION AVAL
            If drlCategoriaCierre.SelectedItem.Text = "Remision a Servicio Tecnico" Or drlCategoriaCierre.SelectedItem.Text = "Remision a CAV por falta de conocimiento por parte del cliente" Then
                objdatos.caso = lblcaso.Text
                objdatos.Validacion = "3"
                objdatos.consultaperfilamiento()
                If objdatos.cantidad = 0 Then
                    Throw New Exception("Este caso no cuenta con el aval de un supervisor")
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
            'ESCALAMIENTO TECNOCA E INFORMÁTICA
            If drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Then
                Registrar_CPD()
            ElseIf drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD" Then
                Registrar_SD()
            End If
            'GUARDA CRM
            objdatos.registrocrm()
            'Registro CRM
            If Drl_Actualizacion_CMC.SelectedItem.Text = "Si" Then
                '---Linea---
                If Drl_Linea_CMC.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione un Estado de Linea despues de CMC")
                End If
                If Dtg_Control_Bscs.Rows.Count < 1 Then
                    '----Novedad---
                    Drl_Novedad_CMC.Enabled = True
                    If Drl_Novedad_CMC.SelectedIndex = 0 Then
                        Throw New Exception("Seleccione un Estado de Linea despues de CMC")
                    End If
                    objdatos.Novedad_CMC = Drl_Novedad_CMC.SelectedItem.Text
                    objdatos.Id_Novedad = Drl_Novedad_CMC.SelectedValue
                    objdatos.idusuarioasignado = "ECH7711A"
                    objdatos.min = lblmin.Text
                    objdatos.caso = lblcaso.Text
                    objdatos.registro_Control_BSCS()
                End If
                objdatos.Linea_CMC = Drl_Linea_CMC.SelectedItem.Text
            Else
                objdatos.Linea_CMC = ""
                objdatos.Novedad_CMC = ""
                objdatos.Id_Novedad = ""
            End If
            'actualiza bandeja
            actbandeja()
            'GUARDA DIAGNOSTICO
            guardadiagnostico()
            'VALIDACION AUTO-ASIGNACION
            If drltipificacionll.SelectedItem.Text = "Programado" Then
                If DrlLibera.Text = "SI" Then
                    objdatos.Validacion = "Libera"
                    objdatos.asignaprogramados()
                ElseIf DrlLibera.Text = "NO" Then
                    objdatos.Validacion = "Val_Asig_Cas"
                    objdatos.Consulta_Correo_Bandeja()
                    If objdatos.cantidad = Nothing Or objdatos.cantidad = "" Then
                        objdatos.Validacion = "Autoasigna"
                        objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                        objdatos.asignaprogramados()
                    End If
                End If
                DrlLibera.SelectedIndex = 0
            End If
            'TIPO LLAMADA
            If drltipificacionll.SelectedItem.Text.Contains("Cerrado") Or drltipificacionll.SelectedItem.Text.Contains("Escalar") Then
                objdatos.diagservicio = DrlTipollamada.SelectedItem.Text
                objdatos.caso = lblcaso.Text
                objdatos.ActualizaBSCS()
            Else
                DrlTipollamada.SelectedIndex = 0
                DrlTipollamada.Visible = False
            End If
            'buscarinf informacion
            Button1_Click(1, Nothing)
            'consulta programados
            traeprogramados()
            'limpia herramientas
            Limpiar_Herramientas()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Seguimiento ingresado con éxito"
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'GUARDA INCONSITENCIA
    Protected Sub btnguardar0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar0.Click 'boton para guardar incosistencia
        Try
            ''''Consulta si ya existe algun registro para evitar conflicto con PK- © CDRR.
            Dim ObjDataCons As New clscrmdatos
            ObjDataCons.Validacion = "Inconsistencia"
            ObjDataCons.caso = lblcaso.Text
            ObjDataCons.Consulta_Registro_Falla_Red_Incinsistencia_Otro()
            If ObjDataCons.cantidad > 0 Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> El Caso Claro: " + lblcaso.Text + " ya tiene un registro de inconsistencai"
                Exit Sub
            End If
            Dim objdatos As New clscrmdatos
            If drlincons.SelectedIndex = 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija el tipo de inconsistencia a reportar"
                Exit Sub
            Else
                objdatos.incidente = drlincons.SelectedItem.Value
            End If
            If txtobsinc.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite la observación de la inconsistencia"
                Exit Sub
            Else
                objdatos.obs = txtobsinc.Text
            End If
            If Txt_custcode.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Es obligatorio llenar Custcode "
                Exit Sub
            Else
                objdatos.custcode = Txt_custcode.Text
            End If
            If Txt_usuario_reporta.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el usuario reporta de la inconsistencia"
                Exit Sub
            Else
                objdatos.usuarioreporta = Txt_usuario_reporta.Text
            End If
            If drl_ubicacion_call.SelectedIndex = 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione ubicacion de call center"
                Exit Sub
            Else
                objdatos.lugar = drl_ubicacion_call.SelectedValue
            End If

            If drlnivel.SelectedIndex > 0 Then
                objdatos.barrio = drlnivel.SelectedItem.Value
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija el nivel que genera la inconsistencia, verifique"
                Exit Sub
            End If

            objdatos.caso = lblcaso.Text
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.estadoinc = "Aprobado"
            objdatos.registroinc()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Inconsistencia reportada con exito"
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
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'BOTON BUSCAR
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            If txtcaso.Text = Nothing Then
                Throw New Exception("Digite el Caso o Min que desea consultar")
            ElseIf Not IsNumeric(txtcaso.Text) Then
                Throw New Exception("El código del caso debe estar formado por un número entero!!")
            End If
            Limpiar_Herramientas()
            Dim objdatos As New clscrmdatos
            objdatos.caso = txtcaso.Text
            ViewState("dtggeneral") = objdatos.consultacasoBSCS.Tables(0)
            If ViewState("dtggeneral").rows.count > 0 Then
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
                If objdatos.min <> Nothing Then
                    ViewState("dtgcoincidentes") = objdatos.casosasociados.Tables(0)
                    dtgcoincidentes.DataSource = ViewState("dtgcoincidentes")
                    dtgcoincidentes.DataBind()
                    lblcuenta1.Text = dtgcoincidentes.Rows.Count
                End If
                If TypeOf sender Is Button Then
                    If objdatos.tipificacion.Contains("Cerrado") Or objdatos.tipificacion.Contains("Escala") Then
                        If lblestado.Text <> "Cerrado" Then
                            Obj_General.Validacion = "BSCS"
                            Obj_General.Cod_Diagnostico = txtcaso.Text
                            ViewState("Dtg_Control_Bscs") = Obj_General.Cargar_CMC.Tables(0)
                            If ViewState("Dtg_Control_Bscs").rows.count > 0 Then
                                Dtg_Control_Bscs.DataSource = ViewState("Dtg_Control_Bscs")
                            Else
                                Dtg_Control_Bscs.DataSource = Nothing
                            End If
                            Dtg_Control_Bscs.DataBind()
                        End If
                        btnguardar.Visible = False
                        Throw New Exception("No puede realizar gestion sobre este caso ya que se encuentra cerrado o en Soliciotud Escalar")
                    End If
                    btnguardar.Visible = True
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
                    '----------NUEVO------------'
                    If objdatos.Causa_CMC <> "" And objdatos.Causa_CMC <> " " Then
                        Drl_Causa_Raiz_Linea.SelectedValue = objdatos.Causa_CMC
                        Drl_Causa_Raiz_Linea.Enabled = False
                    End If
                    If objdatos.Linea_CMC <> "" And objdatos.Linea_CMC <> " " Then
                        Drl_Linea_CMC.SelectedValue = objdatos.Linea_CMC
                        Drl_Linea_CMC.Enabled = False
                        Drl_Actualizacion_CMC.Enabled = False
                        Drl_Actualizacion_CMC.SelectedValue = "Si"
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
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No se han encontrado registros coincidentes"
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
    'COINCIDENTES OCULTAR
    Protected Sub lnk1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnk1.Click
        dtggeneral.Visible = True
        dtgcoincidentes.Visible = False
    End Sub
    'COINCIDENTES MOSTRAR
    Protected Sub LinkButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton2.Click
        dtggeneral.Visible = False
        dtgcoincidentes.Visible = True
    End Sub
    'INCONSISTENCIA MOOSTRAR
    Protected Sub LinkButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton3.Click
        Try
            If lblcaso.Text = "" Then
                Throw New Exception("Consulte el caso antes de generar una inconsistencia")
            End If
            Dim objdatos As New clscrmdatos
            objdatos.caso = lblcaso.Text
            If objdatos.Consultar_Inconsistencia().Tables(0).Rows.Count > 0 Then
                Throw New Exception("El caso  " + objdatos.caso + "  ya tiene reportada una inconsistencia")
            End If
            'Dim ObjGeneral As New clsgeneral
            'ubicacion call
            Pninc.Visible = True
            LinkButton4.Visible = True
            LinkButton3.Visible = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'INCONSISTENCIA OCULTAR
    Protected Sub LinkButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton4.Click
        Try
            LinkButton3.Visible = True
            LinkButton4.Visible = False
            Pninc.Visible = False
            lblmsg.Text = ""
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'BOTON HABILITA CONDICIONES DE USO
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
    'BOTON HABILITA EQUIPO
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
    'BOTON HABILITA MUNICIPIO
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
    'BOTON HABILITA BARRIO
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
    'BOTON HABIULITA FECHA ULT CAIDA
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
    'BOTON HABILITA PQR
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
#Region "Drls's"
    'CARGA DRL
    Protected Sub cargadrl()
        Try
            If Not IsPostBack Then
                'Dim Obj_General As New clsgeneral
                '--------inconsistencia encuesta 611---------'
                With drlinconsistencia
                    .DataSource = Obj_General.Consulta_inconsistencia_encuesta
                    .DataTextField = "Nombre"
                    .DataValueField = "Cod_BD_Datos_Complemento"
                    .DataBind()
                    drlinconsistencia = Obj_G_D.Gest_Drl(drlinconsistencia)
                End With
                '-----------------'
                'Inconsistencia Global - tipificacion
                Obj_General.cargo = "Global"
                With drlinconsglobal
                    .DataSource = Obj_General.consultaincdatos
                    .DataTextField = "inconsistencia"
                    .DataValueField = "idtipoinc"
                    .DataBind()
                    drlinconsglobal = Obj_G_D.Gest_Drl(drlinconsglobal)
                End With
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
                'Marca
                With drlmarca
                    .DataSource = Obj_General.consultamarca
                    .DataTextField = "marca"
                    .DataValueField = "marca"
                    .DataBind()
                    drlmarca = Obj_G_D.Gest_Drl(drlmarca)
                End With
                Obj_General.Validacion = "Tipo PQR"
                With drlTipo_PQR
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Servicio_V2
                    .DataTextField = "tipo2"
                    .DataValueField = "tipo2"
                    .DataBind()
                    drlTipo_PQR = Obj_G_D.Gest_Drl(drlTipo_PQR)
                End With
                'Justificacion Seguimiento
                Obj_General.Validacion = "Justificacion"
                With Drl_justificacion_seguimiento
                    .DataSource = Obj_General.consulta_campaña_inb
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_justificacion_seguimiento = Obj_G_D.Gest_Drl(Drl_justificacion_seguimiento)
                End With
                ''Modalidad
                Obj_General.Validacion = "Modalidad"
                With drlModalidad
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Servicio_V2
                    .DataTextField = "tipo2"
                    .DataValueField = "tipo2"
                    .DataBind()
                    drlModalidad = Obj_G_D.Gest_Drl(drlModalidad)
                End With
                '-----Estado CMC-----
                Obj_General.Validacion = "Estado"
                With Drl_Linea_CMC
                    .DataSource = Obj_General.Cargar_CMC
                    .DataTextField = "Nombre"
                    .DataValueField = "Nombre"
                    .DataBind()
                    Drl_Linea_CMC = Obj_G_D.Gest_Drl(Drl_Linea_CMC)
                End With
                '----Causa CMC ----'
                Obj_General.Validacion = "Causa"
                With Drl_Causa_Raiz_Linea
                    .DataSource = Obj_General.Cargar_CMC
                    .DataTextField = "Nombre"
                    .DataValueField = "Nombre"
                    .DataBind()
                    Drl_Causa_Raiz_Linea = Obj_G_D.Gest_Drl(Drl_Causa_Raiz_Linea)
                End With
                '----Novedad CMC ----'
                Obj_General.Validacion = "Novedad"
                With Drl_Novedad_CMC
                    .DataSource = Obj_General.Cargar_CMC
                    .DataTextField = "tipificacion1"
                    .DataValueField = "cod_tipificacion"
                    .DataBind()
                    Drl_Novedad_CMC = Obj_G_D.Gest_Drl(Drl_Novedad_CMC)
                End With
                Obj_General.Validacion = "linea_serv"
                With drllinea
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Diagnostico2
                    .DataTextField = "tipificacion1"
                    .DataValueField = "tipificacion1"
                    .DataBind()
                    drllinea = Obj_G_D.Gest_Drl(drllinea)
                End With
                'inconsistencias
                Obj_General.Validacion = "Ubicacion_call2"
                With drl_ubicacion_call
                    .DataSource = Obj_General.consulta_campaña_inb
                    .DataTextField = "nombre"
                    .DataValueField = "valor"
                    .DataBind()
                    drl_ubicacion_call = Obj_G_D.Gest_Drl(drl_ubicacion_call)
                End With
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
                'Causal Escalamiento
                With drl_causal_escalamiento_service
                    Obj_General.idusuario = 31
                    .DataSource = Obj_General.consultadiagnostico
                    .DataTextField = "detalle"
                    .DataValueField = "idreg"
                    .DataBind()
                    drl_causal_escalamiento_service = Obj_G_D.Gest_Drl(drl_causal_escalamiento_service)
                End With
                'CARGA DRL FALLA RED
                With drlFcaract
                    .DataSource = Obj_General.consultacaractdat
                    .DataTextField = "desccarac"
                    .DataValueField = "idcarac"
                    .DataBind()
                    drlFcaract = Obj_G_D.Gest_Drl(drlFcaract)
                End With
                'Tipo de Edificacion Donde se Presenta la Falla
                Obj_General.Validacion = "VF_Tipo_Edificacion_Donde_Presenta_Falla_1"
                With Drl_Tipo_Edificacion_Donde_Presenta_Falla_1
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_Tipo_Edificacion_Donde_Presenta_Falla_1 = Obj_G_D.Gest_Drl(Drl_Tipo_Edificacion_Donde_Presenta_Falla_1)
                End With
                Obj_General.Validacion = "VF_Tipo_Edificacion_Donde_Presenta_Falla_2"
                With Drl_Tipo_Edificacion_Donde_Presenta_Falla_2
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_Tipo_Edificacion_Donde_Presenta_Falla_2 = Obj_G_D.Gest_Drl(Drl_Tipo_Edificacion_Donde_Presenta_Falla_2)
                End With
                'Tecnologia en la que se Presenta la Falla Luego de pruebas
                Obj_General.Validacion = "VF_Tecnologia_Presenta_Falla_Luegodepruebas"
                With Drl_Tecnologia_Presenta_Falla_Luegodepruebas
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_Tecnologia_Presenta_Falla_Luegodepruebas = Obj_G_D.Gest_Drl(Drl_Tecnologia_Presenta_Falla_Luegodepruebas)
                End With
                'Para cuando la opcion "No existen cambios administrativos sobre la línea o cuenta maestra" sea falsoSplit_Billing
                Obj_General.Validacion = "Split_Billing"
                With Drl_Split_Billing
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_Split_Billing = Obj_G_D.Gest_Drl(Drl_Split_Billing)
                End With
                'Valores de HLR_HSS
                Obj_General.Validacion = "HLR_HSS"
                With Drl_HLR_HSS
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_HLR_HSS = Obj_G_D.Gest_Drl(Drl_HLR_HSS)
                End With
                'Se forza la red del dispositivo
                Obj_General.Validacion = "VF_Forza_Red_Dispositivo"
                With Drl_Forza_Red_Dispositivo
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_Forza_Red_Dispositivo = Obj_G_D.Gest_Drl(Drl_Forza_Red_Dispositivo)
                End With
                'Se verifica o realiza configuración de APN
                Obj_General.Validacion = "VF_Verifica_Realiza_Configuración_APN"
                With Drl_Verifica_Realiza_Configuración_APN
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_Verifica_Realiza_Configuración_APN = Obj_G_D.Gest_Drl(Drl_Verifica_Realiza_Configuración_APN)
                End With
                ' Qos
                Obj_General.Validacion = "VF_Qos"
                With Drl_Qos
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_Qos = Obj_G_D.Gest_Drl(Drl_Qos)
                End With
                'validar
                drlfranja = Obj_G_D.Gest_Drl(drlfranja)
                DrlTipollamada = Obj_G_D.Gest_Drl(DrlTipollamada)
                Drl_Actualizacion_CMC = Obj_G_D.Gest_Drl(Drl_Actualizacion_CMC)
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
                drlinconsistencia.SelectedIndex = 0
                drlinconsglobal.SelectedIndex = 0
                drldpto.SelectedIndex = 0
                drlFtectolog.SelectedIndex = 0
                drlmarca.SelectedIndex = 0
                drlTipo_PQR.SelectedIndex = 0
                Drl_justificacion_seguimiento.SelectedIndex = 0
                drlModalidad.SelectedIndex = 0
                Drl_Linea_CMC.SelectedIndex = 0
                Drl_Causa_Raiz_Linea.SelectedIndex = 0
                Drl_Novedad_CMC.SelectedIndex = 0
                drllinea.SelectedIndex = 0
                drl_ubicacion_call.SelectedIndex = 0
                drlapn.SelectedIndex = 0
                drlqos.SelectedIndex = 0
                drl_causal_escalamiento_service.SelectedIndex = 0
                drlFcaract.SelectedIndex = 0
                Drl_Tipo_Edificacion_Donde_Presenta_Falla_1.SelectedIndex = 0
                Drl_Tipo_Edificacion_Donde_Presenta_Falla_2.SelectedIndex = 0
                Drl_Tecnologia_Presenta_Falla_Luegodepruebas.SelectedIndex = 0
                Drl_Split_Billing.SelectedIndex = 0
                Drl_HLR_HSS.SelectedIndex = 0
                Drl_Forza_Red_Dispositivo.SelectedIndex = 0
                Drl_Verifica_Realiza_Configuración_APN.SelectedIndex = 0
                Drl_Qos.SelectedIndex = 0

                'reiniciar enbebidos en el html
                drlfranja.SelectedIndex = 0
                DrlTipollamada.SelectedIndex = 0
                Drl_Actualizacion_CMC.SelectedIndex = 0
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
            Cargar_drlvariable(6)
            drlinconsglobal_SelectedIndexChanged(1, Nothing)
            drldpto_SelectedIndexChanged(1, Nothing)
            drlmarca_SelectedIndexChanged(1, Nothing)
            drllinea_SelectedIndexChanged(1, Nothing)
            Drl_Actualizacion_CMC_SelectedIndexChanged(1, Nothing)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'CARGAR DRL VARIABLE
    Protected Sub Cargar_drlvariable(idusuario)
        Try
            Obj_General.idusuario = idusuario
            With drlvariable
                .DataSource = Obj_General.consultadiagnostico
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
                drlvariable = Obj_G_D.Gest_Drl(drlvariable)
            End With
            drlvariable_SelectedIndexChanged(1, Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'DRLMARCA
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
    'DRL DPTO
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
    'DRL LINEA DE SERVICIO
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
    'DRL SERVICIO
    Protected Sub drlservicio2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlservicio2.SelectedIndexChanged
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
    'DRL SOLICITUD
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
    'DRL SEGMENTO
    Protected Sub drlSegmento_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlSegmento.SelectedIndexChanged
        Try
            With drlCausa_Raiz
                If drlSegmento.SelectedIndex > 0 Then
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
    'DRL CAUSA RAIZ
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
    'DRL TIPIFICACION
    Protected Sub drltipificacionll_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drltipificacionll.SelectedIndexChanged
        Try
            'Dim ObjGeneral As New clsgeneral
            'Categoria cierre
            'If drltipificacionll.SelectedItem.Text = "Cerrado" And drlCausa_Raiz.SelectedItem.Text = "Otr_Caso mal escalado" Then
            '    ObjGeneral.Validacion = "Categoria Cierre Cas Mal Esc"
            'Else
            '    ObjGeneral.Validacion = "categoria"
            'End If
            'ObjGeneral.Cod_Diagnostico = drltipificacionll.SelectedValue
            'With drlCategoriaCierre
            '    .DataSource = ObjGeneral.Consulta_Cargue_Catalogo_Diagnostico2
            '    .DataTextField = "tipificacion1"
            '    .DataValueField = "cod_tipificacion"
            '    .DataBind()
            '    .Items.Insert(0, "- Seleccione -")
            'End With
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
                'cargardrl_fallared()
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

            If drltipificacionll.SelectedItem.Text.Contains("Cerrado") Or drltipificacionll.SelectedItem.Text.Contains("Escalar") Then
                DrlTipollamada.Visible = True
                DrlTipollamada.SelectedIndex = 0
            Else
                DrlTipollamada.SelectedIndex = 0
                DrlTipollamada.Visible = False
            End If
            If drltipificacionll.SelectedItem.Text.Contains("Cerrado") Then
                Drl_Causa_Raiz_Linea.Enabled = True
                Drl_Causa_Raiz_Linea.SelectedIndex = 0
            Else
                Drl_Causa_Raiz_Linea.Enabled = False
                Drl_Causa_Raiz_Linea.SelectedIndex = 0
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
    'DRL NO EXISTE CAMBIOS
    Protected Sub Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedIndexChanged
        Try
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text = "FALSO" Then
                Drl_Split_Billing.Visible = True
            Else
                Drl_Split_Billing.Visible = False
            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try

    End Sub
    'DRL 611
    Protected Sub drl611_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drl611.SelectedIndexChanged
        Try
            If drl611.SelectedIndex = 0 Then
                TxtPercep_Serv.Enabled = False
            Else
                TxtPercep_Serv.Enabled = True
            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'DRL ACTUALIZACION CMC
    Protected Sub Drl_Actualizacion_CMC_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Drl_Actualizacion_CMC.SelectedIndexChanged
        Try
            If Drl_Actualizacion_CMC.SelectedItem.Text = "Si" Then
                Drl_Linea_CMC.Enabled = True
                Drl_Novedad_CMC.Enabled = True
                Drl_Linea_CMC.SelectedIndex = 0
                Drl_Novedad_CMC.SelectedIndex = 0
            Else
                Drl_Linea_CMC.Enabled = False
                Drl_Novedad_CMC.Enabled = False
                Drl_Linea_CMC.SelectedIndex = 0
                Drl_Novedad_CMC.SelectedIndex = 0
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
    'DRL ERROR EN REGISTRO
    Protected Sub drlvariable_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlvariable.SelectedIndexChanged
        Try
            If drlvariable.SelectedIndex > 0 Then
                Dim objdatos As New clscrmdatos
                objdatos.diagservicio = drlvariable.SelectedItem.Value
                objdatos.consultaproceso()
                lblvariable.Text = objdatos.tipificacion
            Else
                lblvariable.Text = Nothing
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
    'DRL INCONSISTENCIA GLOBAL
    Protected Sub drlinconsglobal_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlinconsglobal.SelectedIndexChanged
        Try
            With drlincons
                If drlinconsglobal.SelectedIndex > 0 Then
                    Obj_General.cargo = "Inconsistencia_BSCS"
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
    'DRL INCONSISTENCIA
    Protected Sub drlinconsistencia_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlinconsistencia.SelectedIndexChanged
        Try
            If drlinconsistencia.SelectedItem.Text = "Otro" Then
                txtobsincon.Enabled = True
            Else
                txtobsincon.Enabled = False
                txtobsincon.Text = ""
            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'drl causa escalamiento
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
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
#End Region
#Region "Dtg's"
    'DTG GESTIONES
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
    'DTG COINCIDENTES
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
    'DTG ASIGNACION
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
#End Region
#Region "Chek's"
    'CHECK FALLA MASIVA
    Protected Sub chkmasiva_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkmasiva.CheckedChanged
        Try
            consultafallamasiva()
            If lblobsmasiva.Text = "" Then
                Throw New Exception("No se registra falla masiva en estos momentos, por favor gestione el caso de forma individual")
                Exit Sub
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
                drlvariable_SelectedIndexChanged(1, Nothing)
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
    'CHK SI NUMERO ALTERNO
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
    'CHK NO NUMERO ALTERNO
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


