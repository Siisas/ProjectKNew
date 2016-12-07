Public Class RegCrm_Falla_Des2
    Inherits System.Web.UI.Page
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
            'bj_G_D.Val_Session("CRM")
            If Not IsPostBack Then
                Limpiar_Herramientas()
                Session("Formulario") = "Registro Desactivación"
                Dim objgeneral1 As New clsgeneral
                objgeneral1.idusuario = CType(Session("permisos"), clsusuario).usuario
                objgeneral1.consultared()
                If objgeneral1.estado <> " " Then
                    BtnNuevo_caso.Visible = True
                Else
                    BtnNuevo_caso.Visible = False
                End If
                Consulta_Asignados()
                LblPQR.Text = objgeneral1.Consulta_Numero_PQR().Tables(0).Rows(0).Item("Nombre")
            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub Consulta_Asignados()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.Validacion = "Asignados"
            ViewState("dtgprog") = objdatos.Consulta_Asignado_Fideliza.Tables(0)
            If ViewState("dtgprog").Rows.Count > 0 Then
                dtgprog.DataSource = ViewState("dtgprog")
                lblcasos_asig.Text = dtgprog.Rows.Count()
            Else
                dtgprog.DataSource = Nothing
            End If
            dtgprog.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub Limpiar_Herramientas()
        Try
            rdbvc.selectedvalue = Nothing
            ViewState("dtggeneral") = Nothing
            dtggeneral.DataSource = Nothing
            dtggeneral.DataBind()
            Btn_Guardar.Visible = False
            Panel_Justificacion.Visible = False
            Pnfallared.Visible = False
            'limpiar lbl
            lblcliente.Text = Nothing
            lbldocumento.Text = Nothing
            lblmin.Text = Nothing
            lblplan.Text = Nothing
            lblBandeja.Text = Nothing
            lbllugar.Text = Nothing
            Lblfc_ingreso.Text = Nothing
            lblcaso.Text = Nothing
            LblCasoClaro.Text = Nothing
            lblobs611.Text = Nothing
            lblestado.Text = Nothing
            lblNumero_Alterno.Text = Nothing
            lblestadon3.Text = Nothing
            lblfcingn3.Text = Nothing
            LblEscalamiento.Text = Nothing
            LblCall_Remite.Text = Nothing
            txtnumalt.Text = Nothing
            txtobs.Text = Nothing
            TxtPQR.Text = Nothing
            txtfc_programado.Text = Nothing
            'enabled
            chkSi.Checked = False
            chkNo.Checked = False
            txtnumalt.Enabled = False
            TxtPQR.Enabled = True
            drlTipo_PQR.Enabled = True
            drlmun.Enabled = True
            drlequipo.Enabled = True
            drlmarca.Enabled = True
            drldpto.Enabled = True
            'visible
            Btn_act_equipo.Visible = False
            Btn_act_municipio.Visible = False
            Btn_Act_PQR.Visible = False
            'recarga drl
            drltipolinea.Enabled = True
            drlTipo_Pqr_Adicional.Enabled = True
            drlIntension_Des_Por_Fallaen.Enabled = True
            drlTipo_Proceso_Linea.Enabled = True
            drlAplica_Fidelizacion.Enabled = True
            'limpiar falla red
            Txt_N_Doc_Id_CPD.Text = Nothing
            txtbarrio.Text = Nothing
            txtfobs.Text = Nothing
            txtFdirecc.Text = Nothing
            txtFciudad.Text = Nothing
            txtFtipofalla.Text = Nothing
            txtFcontacto.Text = Nothing
            txtFnum.Text = Nothing
            txtapn.Text = Nothing
            '''''''''''''Servicio CLiente''''''''''''''''''''
            Txt_Validacion_Coordenadas.Text = Nothing
            Cargar_Drls()
            Consulta_Asignados()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub Registrar_CPD()
        Try
            If LblCasoClaro.Text = Nothing Then
                Throw New Exception("Consulte el caso antes de reportar una Falla de Red, Si el caso ya se consulto y no se cargo el 'Caso Claro', no se podra generar falla de red")
            End If
            If drlequipo.SelectedIndex = 0 Then
                Throw New Exception("Elija la marca y el equipo actual antes de generar una falla de red")
            End If
            Dim ObjDataCons As New clscrmdatos
            ObjDataCons.Validacion = "Falla Red"
            ObjDataCons.caso = LblCasoClaro.Text
            ObjDataCons.Consulta_Registro_Falla_Red_Incinsistencia_Otro()
            If ObjDataCons.cantidad > 0 Then
                Throw New Exception("El Caso Claro: " + LblCasoClaro.Text + " ya tiene un registro de falla de red")
            End If
            lblmsg.Text = ""
            Dim objvoz As New clsvoz
            If drlequipo.SelectedIndex = 0 Then
                Throw New Exception("Elija la marca y el equipo actual antes de generar una falla de red")
            End If
            objvoz.equipo = drlequipo.SelectedItem.Value
            If drlmun.SelectedIndex = 0 Then
                Throw New Exception("Elija el Departamento y Municipio antes de generar una falla de red")
            End If
            objvoz.mun = drlmun.SelectedItem.Value
            If drlFtectolog.SelectedIndex = 0 Then
                Throw New Exception("Seleccione la tecnología antes de generar una falla de red")
            End If
            objvoz.tecnologia = drlFtectolog.SelectedItem.Text
            If txtbarrio.Text = "" Then
                Throw New Exception("Digite el barrio donde se presenta la falla")
            End If
            objvoz.barrio = txtbarrio.Text
            If txtFcontacto.Text = "" Then
                Throw New Exception("Digite la persona de contacto")
            End If
            If Txt_N_Doc_Id_CPD.Text = Nothing Then
                Throw New Exception("Ingrese el número de documento de identidad de la persona que reporta")
            ElseIf Not IsNumeric(Txt_N_Doc_Id_CPD.Text) Then
                Throw New Exception("El número de documento de identidad de la persona que reporta debe estar compuesto solo por números")
            End If
            objvoz.cliente = txtFcontacto.Text
            If txtFnum.Text = "" Then
                Throw New Exception("Digite el número de contacto")
            End If
            objvoz.telcontacto = txtFnum.Text
            If drlFtiempo.SelectedIndex = 0 Then
                Throw New Exception("Elija el tiempo que lleva presentándose la falla")
            End If
            objvoz.tiempo = drlFtiempo.SelectedItem.Value
            If txtFtipofalla.Text = "" Then
                objvoz.tipofalla = ""
            Else
                objvoz.tipofalla = txtFtipofalla.Text
            End If
            If drlFcaract.SelectedIndex = 0 Then
                Throw New Exception("Describa las características del tipo de falla")
            End If
            objvoz.caracter = drlFcaract.SelectedItem.Text
            If drlFportada.SelectedIndex = 0 Then
                Throw New Exception("Elija si la línea es portada o no")
            End If
            objvoz.portada = drlFportada.SelectedItem.Value
            If txtFciudad.Text = "" Then
                objvoz.vereda = ""
            Else
                If rdbvc.selectedvalue = Nothing And txtFciudad.Text <> Nothing Then
                    Throw New Exception("Elija si el lugar corresponde a un corregimiento, Vereda o Inspección")
                End If
                objvoz.vereda = rdbvc.SelectedItem.Value & " " & txtFciudad.Text
            End If
            If txtFdirecc.Text = "" Then
                Throw New Exception("Digite la dirección donde se presenta la falla")
            End If
            objvoz.dir = txtFdirecc.Text
            If txtapn.Text = "" Then
                Throw New Exception("Digite el APN Afectado")
            End If
            objvoz.apn = txtapn.Text
            If Drl_Qos.SelectedIndex = 0 Then
                Throw New Exception("Seleccione un QoS")
            End If
            objvoz.qos = Drl_Qos.SelectedItem.Text
            If drlFlineasfalla.SelectedIndex = 0 Then
                Throw New Exception("Elija si se reportan más líneas con falla en la ubicación reportada")
            End If
            objvoz.maslineas = drlFlineasfalla.SelectedItem.Value
            If txtfobs.Text = "" Then
                Throw New Exception("Digite las observaciones reportadas por el usuario")
            End If
            objvoz.obs = txtfobs.Text
            ''''''''Servicio Cliente'''''''''''''''''''''
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
                'Exit Sub
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
            objvoz.N_Doc_Id = Txt_N_Doc_Id_CPD.Text
            objvoz.Falla_Presenta_Luego_Construyera_Edificacion_Aledania = Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania.SelectedItem.Text
            objvoz.Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio.SelectedItem.Text
            objvoz.Tipo_Edificacion_Donde_Presenta_Falla = Drl_Tipo_Edificacion_Donde_Presenta_Falla_1.SelectedItem.Text + " - " + Drl_Tipo_Edificacion_Donde_Presenta_Falla_2.SelectedItem.Text
            objvoz.Validaciones_Falla_Masiva = Drl_Validaciones_Falla_Masiva.SelectedItem.Text
            objvoz.Tecnologia_Presenta_Falla_Luegodepruebas = Drl_Tecnologia_Presenta_Falla_Luegodepruebas.SelectedItem.Text
            objvoz.Validacion_Coordenadas = Txt_Validacion_Coordenadas.Text
            objvoz.Linea_No_Cuenta_Bloqueos_Internet = Drl_Linea_No_Cuenta_Bloqueos_Internet.SelectedItem.Text
            objvoz.Linea_No_Superado_Limite_Consumos = Drl_Linea_No_Superado_Limite_Consumos.SelectedItem.Text
            objvoz.Linea_No_Encuentra_Enrutada_PorPagos = Drl_Linea_No_Encuentra_Enrutada_PorPagos.SelectedItem.Text
            objvoz.HLR_HSS = Drl_HLR_HSS.SelectedItem.Text
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text = "FALSO" Then
                objvoz.No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text + " - " + Drl_Split_Billing.SelectedItem.Text
            Else
                objvoz.No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text
            End If
            objvoz.Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla.SelectedItem.Text
            objvoz.Forza_Red_Dispositivo = Drl_Forza_Red_Dispositivo.SelectedItem.Text
            objvoz.Verifica_Realiza_Configuración_APN = Drl_Verifica_Realiza_Configuración_APN.SelectedItem.Text
            objvoz.Equipo_Encuentra_Homologado_Operador = Drl_Equipo_Encuentra_Homologado_Operador.SelectedItem.Text
            objvoz.Realiza_Conciliacion_Sobre_linea = Drl_Realiza_Conciliacion_Sobre_linea.SelectedItem.Text

            objvoz.campana = lblBandeja.Text
            objvoz.caso = LblCasoClaro.Text
            objvoz.idusuario = CType(Session("permisos"), clsusuario).usuario
            objvoz.fcini = Lblfc_ingreso.Text
            objvoz.registrofallasred()
            ''''Registro de que queda falla de Red
            objvoz.caso = lblcaso.Text
            objvoz.tipificacion = "Creado"
            objvoz.RegistroCRM_Falla_Red_Falla_Desactivacion_D_V()
            LblEscalamiento.Text = "Falla de red"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub guardadiagnostico()
        Try
            Dim objdatos As New clscrmdatos
            If drlTipo_PQR.SelectedIndex > 0 Or drlCausa_Raiz.SelectedIndex > 0 Or drlCategoriaCierre.SelectedIndex > 0 Or drlsolicitud.SelectedIndex > 0 Or drlvariableCatalogo.SelectedIndex > 0 Or drlmun.SelectedIndex > 0 Or drlTipo_Pqr_Adicional.SelectedIndex > 0 Or drlIntension_Des_Por_Fallaen.SelectedIndex > 0 Or drlTipo_Proceso_Linea.SelectedIndex > 0 Or drlAplica_Fidelizacion.SelectedIndex > 0 Then
                If drlTipo_PQR.SelectedIndex = 0 Then
                    objdatos.Tipo_PQR = ""
                Else
                    objdatos.Tipo_PQR = drlTipo_PQR.SelectedItem.Text
                End If
                'CAUSA RAIZ
                If drlCausa_Raiz.SelectedIndex = 0 Then
                    objdatos.Causa_Raiz = ""
                Else
                    objdatos.Causa_Raiz = drlCausa_Raiz.SelectedValue
                End If
                If drlCategoriaCierre.SelectedIndex = 0 Then
                    objdatos.Categoria_Cierre = 0
                Else
                    objdatos.Categoria_Cierre = drlCategoriaCierre.SelectedValue
                End If
                objdatos.Tipo_Cliente = ""
                objdatos.Modalidad = ""
                If drlsolicitud.SelectedIndex = 0 Then
                    objdatos.solicitud = "0"
                Else
                    objdatos.solicitud = drlsolicitud.SelectedItem.Value
                End If
                If drlvariableCatalogo.SelectedIndex = 0 Then
                    objdatos.diagvariable = "0"
                Else
                    objdatos.diagvariable = drlvariableCatalogo.SelectedItem.Value
                End If
                If drlmun.SelectedIndex = 0 Then
                    objdatos.mun = "0"
                Else
                    objdatos.mun = drlmun.SelectedItem.Value
                End If
                If drlTipo_Pqr_Adicional.SelectedIndex = 0 Then
                    objdatos.Tipo_PQR_Adicional = ""
                Else
                    objdatos.Tipo_PQR_Adicional = drlTipo_Pqr_Adicional.SelectedItem.Value
                End If
                If drlIntension_Des_Por_Fallaen.SelectedIndex = 0 Then
                    objdatos.Intension_Des_Por_Falla = ""
                Else
                    objdatos.Intension_Des_Por_Falla = drlIntension_Des_Por_Fallaen.SelectedItem.Value
                End If
                If drlTipo_Proceso_Linea.SelectedIndex = 0 Then
                    objdatos.Tipo_Proceso_Linea = ""
                Else
                    objdatos.Tipo_Proceso_Linea = drlTipo_Proceso_Linea.SelectedItem.Value
                End If
                If drlAplica_Fidelizacion.SelectedIndex = 0 Then
                    objdatos.aplicaajuste = ""
                Else
                    objdatos.aplicaajuste = drlAplica_Fidelizacion.SelectedItem.Value
                End If
                If drlservicio2.SelectedIndex = 0 Then
                    objdatos.servreest = ""
                Else
                    objdatos.servreest = drlservicio2.SelectedItem.Value
                End If
                objdatos.tipofalla = ""
                objdatos.reclamoppal = ""
                objdatos.inconsistencia_encuesta = ""
                objdatos.Validacion = "Diagnostico Dilo y Fidelizacion"
                objdatos.Bandeja = "Fidelizacion"
                objdatos.caso = lblcaso.Text
                objdatos.registrodiag()
                txtbarrio.Text = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
    Protected Sub Btn_Guardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Guardar.Click
        Try

            If lblcaso.Text = Nothing Then
                Throw New Exception("Pimero debe consultar el caso que desea registrar")
            End If
            Dim objdatos As New clscrmdatos
            objdatos.caso = lblcaso.Text
            objdatos.Validacion = 2
            objdatos.ConsultarEstados()
            If objdatos.tipificacion.Contains("Cerrado") Or objdatos.tipificacion.Contains("Escala") Then
                Throw New Exception("¡El Caso que desea guardar se encuentra Cerrado, Escalado o Solicitud Escalar!")
            End If
            objdatos.Validacion = Nothing
            If txtobs.Text = "" Then
                Throw New Exception("Digite la observación de atención al caso")
            End If
            objdatos.obs = txtobs.Text
            If drlservicio2.SelectedIndex = 0 Then
                Throw New Exception("Seleccione el Servicio en CATALOGO DE DIAGNOSTICO")
            End If
            objdatos.servreest = drlservicio2.SelectedItem.Value
            If drltipificacionll.SelectedIndex = 0 Then
                Throw New Exception("Seleccione la tipificación de la llamada")
            End If
            objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            If drlCategoriaCierre.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una categoria de cierre")
            End If
            If (Date.Parse(Lblfc_ingreso.Text) >= Date.Parse("01/09/2015")) And (drlTipo_Pqr_Adicional.SelectedIndex = 0 Or drlIntension_Des_Por_Fallaen.SelectedIndex = 0 Or drlTipo_Proceso_Linea.SelectedIndex = 0) Then
                If drlTipo_Proceso_Linea.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione una opcion en la lista 'Tipo de proceso de la línea'")
                End If
                If drlIntension_Des_Por_Fallaen.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione una opcion en la lista 'Intensión de Desactivación por falla en'")
                End If
                If drlTipo_Pqr_Adicional.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione una opcion en la lista 'Tipo pqr adicional'")
                End If
            End If
            If drlAplica_Fidelizacion.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una opcion en la lista 'Aplica fidelizacion'")
            End If

            If drltipificacionll.SelectedItem.Text.Contains("Escalar") Then
                If Rdb_Contacto.selectedvalue = Nothing Then
                    Throw New Exception("Seleccione si realizo contacto con el cliente")
                End If
                objdatos.Contacto_cliente = Rdb_Contacto.SelectedValue
            End If

            If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar CPD" And LblEscalamiento.Text = "Falla de red" Then
                Throw New Exception("Si reporto falla de red el estado del caso debe ser Solicitud Escalar CPD")
            End If
            If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar SD" And LblEscalamiento.Text = "Escalamiento" Then
                Throw New Exception("Si realizó Escalamiento Service el estado del caso debe ser Solicitud Escalar SD")
            End If
            If drltipificacionll.SelectedItem.Text <> "No Contactado" Then
                If drltipolinea.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione el tipo de la línea")
                End If
                objdatos.tlinea = drltipolinea.SelectedItem.Text
                If drlequipo.SelectedIndex = 0 Then
                    Throw New Exception("Elija la marca y el equipo actual antes de generar una falla de red")
                End If
                objdatos.equipo = drlequipo.SelectedItem.Value
                If drlmun.SelectedIndex = 0 Then
                    Throw New Exception("Elija el departamento y el municipio antes de realizar el registro")
                End If
                objdatos.equipo = drlequipo.SelectedItem.Value
                If drlTipo_PQR.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione un tipo PQR")
                End If
                If drlCausa_Raiz.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione una causa raiz de falla")
                End If
                If drlCategoriaCierre.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione una categoria de cierre")
                End If
                If drlsolicitud.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione una Solicitud / Tipo Falla (VOZ DEL CLIENTE - Solicitud / Tipo Falla)")
                End If
            Else
                objdatos.obs = txtobs.Text
                objdatos.tipificacion = drltipificacionll.SelectedItem.Text
                If (Date.Parse(Lblfc_ingreso.Text) >= Date.Parse("01/09/2015")) And (drlTipo_Pqr_Adicional.SelectedIndex = 0 Or drlIntension_Des_Por_Fallaen.SelectedIndex = 0 Or drlTipo_Proceso_Linea.SelectedIndex = 0) Then
                    If drlTipo_Proceso_Linea.SelectedIndex = 0 Then
                        Throw New Exception("Seleccione una opcion en la lista 'Tipo de proceso de la línea'")
                    End If
                    If drlIntension_Des_Por_Fallaen.SelectedIndex = 0 Then
                        Throw New Exception("Seleccione una opcion en la lista 'Intensión de Desactivación por falla en'")
                    End If
                    If drlTipo_Pqr_Adicional.SelectedIndex = 0 Then
                        Throw New Exception("Seleccione una opcion en la lista 'Tipo pqr adicional'")
                    End If
                End If
            End If
            If TxtPQR.Text = "" Then
                Throw New Exception("Ingrese el consecutivo PQR")
            End If
            objdatos.pqr = Int64.Parse(LblPQR.Text + TxtPQR.Text)
            'Juistificacion caso
            If drltipificacionll.SelectedItem.Text <> "Cerrado" And Not drltipificacionll.SelectedItem.Text.Contains("Solici") And drltipificacionll.SelectedItem.Text <> "Falla Masiva" Then
                If Drl_justificacion_seguimiento.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione la justificacion del seguimiento")
                End If
                objdatos.tiposoporte = Drl_justificacion_seguimiento.SelectedItem.Text
            Else
                objdatos.tiposoporte = ""
            End If
            '------Numero Alterno------'
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
            '----Fin numero alterno------'
            If drltipificacionll.SelectedItem.Text = "Programado" Then
                If txtfc_programado.Text = "" Then
                    Throw New Exception("Seleccione una fecha de programacion")
                Else
                    If txtfc_programado.Text < DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") Then
                        Throw New Exception("La fecha debe ser mayor a la actual")
                    End If
                    objdatos.horaprog = txtfc_programado.Text
                End If
            Else
                objdatos.horaprog = Nothing
            End If

            If Pnl_Esc_Service.Visible = True And drltipificacionll.SelectedItem.Text.Contains("SD") Then

                If LblCasoClaro.Text = "" Then
                    Throw New Exception("Consulte el caso antes de generar un Escalamiento a Service, Si el caso ya se consulto y no se cargo el 'Caso Claro', no se podra generar la Inconsistencia")
                Else
                    If drlCausa_Raiz.SelectedIndex = 0 Then
                        Throw New Exception("Seleccione una Causa Raiz")
                    End If
                End If
                If LblEscalamiento.Text = "Falla de red" Then
                    Throw New Exception("Ya se encuentra una falla de red registrada con este caso")
                End If
                If drl_causal_escalamiento_service.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione una causa de escalamiento")
                Else
                    objdatos.Causal_escalam = drl_causal_escalamiento_service.SelectedItem.Text
                End If
                If drl_causal_escalamiento_service.SelectedItem.Text = "Linea No Registra" Then
                    objdatos.apn = DBNull.Value.ToString
                    objdatos.qos = DBNull.Value.ToString
                    objdatos.fcini = DBNull.Value.ToString
                Else
                    If drlapn.SelectedIndex = 0 Then
                        Throw New Exception("Elija el APN del caso")
                    End If
                    objdatos.apn = drlapn.SelectedItem.Text
                    If drlqos.SelectedIndex = 0 Then
                        Throw New Exception("Seleccione el QoS del caso")
                    End If
                    objdatos.qos = drlqos.SelectedItem.Text

                    If txtfcactivacion.Text = "" Then
                        If drl_causal_escalamiento_service.SelectedItem.Text = "Reinicio de Ciclo - Linea Postpago" Then
                            Throw New Exception("Digite la Fecha de Ciclo")
                        Else
                            Throw New Exception("Digite la fecha de activación del servicio")
                        End If
                    Else
                        If drl_causal_escalamiento_service.SelectedItem.Text = "Reinicio de Ciclo - Linea Postpago" Then
                            objdatos.Fecha_ciclo = txtfcactivacion.Text
                            objdatos.fcini = Nothing
                        Else
                            objdatos.fcini = txtfcactivacion.Text
                            objdatos.Fecha_ciclo = Nothing
                        End If
                    End If
                End If
                If drlvariableCatalogo.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione una opcion de Error en Registro")
                Else
                    objdatos.diagvariable = drlvariableCatalogo.SelectedValue
                End If

                If Not FileDocumento.PostedFile Is Nothing Then
                    If FileDocumento.PostedFile.ContentLength > 0 Then
                        FileDocumento.PostedFile.SaveAs(Server.MapPath("data_Doc") & "\\" & lblcaso.Text & System.IO.Path.GetExtension(FileDocumento.PostedFile.FileName))
                        objdatos.archivo = lblcaso.Text & System.IO.Path.GetExtension(FileDocumento.PostedFile.FileName)
                    Else
                        Throw New Exception("Adjunte un archivo")
                    End If
                Else
                    Throw New Exception("Adjunte un archivo")
                End If
                objdatos.caso = LblCasoClaro.Text
                objdatos.obs = txtobs.Text
                objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                objdatos.Registroservice()
                If objdatos.cantidad = 0 Then
                    Throw New Exception("No se logro hacer el registro!")
                End If
                Dim objvoz2 As New clsvoz
                objvoz2.caso = lblcaso.Text
                objvoz2.idusuario = CType(Session("permisos"), clsusuario).usuario
                objvoz2.tipificacion = "Creado"
                objvoz2.obs = txtobs.Text
                objvoz2.Validacion = "Service"
                objvoz2.RegistroCRM_Falla_Red_Falla_Desactivacion_D_V()

                'SERVICE
                drlapn.SelectedIndex = 0
                drlapn.Enabled = True
                drlqos.SelectedIndex = 0
                drlqos.Enabled = True
                txtfcactivacion.Text = ""
                txtfcactivacion.Enabled = True
                drlvariableCatalogo.SelectedIndex = 0
                drlvariableCatalogo.Enabled = True
                drlvariableCatalogo_SelectedIndexChanged(1, Nothing)
                lbl_Fecha_Act_Ciclo.Text = "Fecha Activacion"

                Pnl_Esc_Service.Visible = False
                LblEscalamiento.Text = "Escala service"
                Pnl_Esc_Service.Visible = False
                LblEscalamiento.Text = "Escalamiento"

            End If
            If Pnfallared.Visible = True And drltipificacionll.SelectedItem.Text.Contains("CPD") Then
                Registrar_CPD()
            End If
            '---------------------'
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.caso = lblcaso.Text
            '''''Registro de gestion
            objdatos.RegistroCrm_Falla_Desactivacion_D_V()
            '---Autoasignar caso---'
            If drltipificacionll.SelectedItem.Text = "Programado" Then
                If drlLibera.SelectedItem.Text = "SI" Then
                    objdatos.Validacion = "Libera"
                ElseIf drlLibera.SelectedItem.Text = "NO" Then
                    objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                    objdatos.Validacion = "Autoasigna"
                End If
                objdatos.asignacionFideliza()

            End If
            objdatos.Actualiza_Bandejan_Falla_Desactivacion_D_V()
            guardadiagnostico()
            Consulta_Asignados()
            BtnBuscar_Click(1, Nothing)
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Seguimiento ingresado con éxito"
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBuscar.Click
        Try
            If txtcaso.Text = Nothing Then
                Throw New Exception("Digite el Caso que desea consultar")
            ElseIf Not IsNumeric(txtcaso.Text) Then
                Throw New Exception("El código del caso debe estar conformado por un número entero!!")
            Else
                Limpiar_Herramientas()
                Dim objdatos As New clscrmdatos
                objdatos.caso = txtcaso.Text
                ViewState("dtggeneral") = objdatos.Consulta_Inf_Caso_Falla_Desactivacion_D_V.Tables(0)
                If ViewState("dtggeneral").Rows.Count > 0 Then
                    dtggeneral.DataSource = ViewState("dtggeneral")
                    dtggeneral.DataBind()
                    lblcuenta.Text = dtggeneral.Rows.Count
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
                    If TypeOf sender Is Button Then
                        If objdatos.tipificacion.Contains("Cerrado") Or objdatos.tipificacion.Contains("Escala") Then
                            Btn_Guardar.Visible = False
                            Throw New Exception("No puede realizar gestion sobre este caso ya que se encuentra Cerrado, Escalado o Solicitud Escalar")
                        Else
                            Btn_Guardar.Visible = True
                        End If
                        Btn_Guardar.Enabled = True
                        If txtcaso.Text = "" Then
                            txtcaso.Text = objdatos.caso
                        End If
                        objdatos.Consulta_Diganostico_Carga_Fidelizacion_y_Dilo()
                        If objdatos.Tipo_PQR_Adicional <> "" Then
                            drlTipo_Pqr_Adicional.SelectedValue = objdatos.Tipo_PQR_Adicional
                            drlTipo_Pqr_Adicional.Enabled = False
                        End If
                        If objdatos.Intension_Des_Por_Falla <> "" Then
                            drlIntension_Des_Por_Fallaen.SelectedValue = objdatos.Intension_Des_Por_Falla
                            drlIntension_Des_Por_Fallaen.Enabled = False
                        End If
                        If objdatos.Tipo_Proceso_Linea <> "" Then
                            drlTipo_Proceso_Linea.SelectedValue = objdatos.Tipo_Proceso_Linea
                            drlTipo_Proceso_Linea.Enabled = False
                        End If
                        If objdatos.aplicaajuste <> "" Then
                            drlAplica_Fidelizacion.SelectedValue = objdatos.aplicaajuste
                            drlAplica_Fidelizacion.Enabled = False
                        End If
                        If objdatos.Tipo_PQR <> "" Then
                            drlTipo_PQR.SelectedValue = objdatos.Tipo_PQR
                            drlTipo_PQR.Enabled = False
                        End If
                        If objdatos.pqr <> "" Then
                            TxtPQR.Text = Mid(objdatos.pqr, 10, 7)
                            TxtPQR.Enabled = False
                        End If
                        If objdatos.pqr <> "" Or objdatos.Tipo_PQR <> "" Then
                            Btn_Act_PQR.Visible = True
                        End If
                        If objdatos.Tipo_Cliente <> "" Then
                            drltipolinea.SelectedValue = objdatos.Tipo_Cliente
                            drltipolinea.Enabled = False
                        End If
                        objdatos.Consulta_Campos_Fideliza_y_Dilo()
                        If objdatos.marca <> "" And objdatos.marca <> " " And objdatos.marca <> "0" Then
                            drlmarca.SelectedValue = objdatos.marca
                            drlmarca.Enabled = False
                            drlmarca_SelectedIndexChanged(1, Nothing)
                            drlequipo.SelectedValue = objdatos.equipo
                            drlequipo.Enabled = False
                            Btn_act_equipo.Visible = True
                        End If
                        If objdatos.dpto <> "" And objdatos.dpto <> " " And objdatos.dpto <> "0" Then
                            drldpto.SelectedValue = objdatos.dpto
                            drldpto.Enabled = False
                            drldpto_SelectedIndexChanged(1, Nothing)
                            drlmun.SelectedValue = objdatos.mun
                            drlmun.Enabled = False
                            Btn_act_municipio.Visible = True
                        End If
                    End If
                Else
                    Throw New Exception("No se han encontrado registros coincidentes con el caso: " + txtcaso.Text)
                End If
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
    Protected Sub LinkBtn_Inconsistencia_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkBtn_Inconsistencia.Click
        Try
            If LblCasoClaro.Text = "" Then
                Throw New Exception("Consulte el caso antes de generar una Inconsistencia, Si el caso ya se consulto y no se cargo el 'Caso Claro', no se podra generar la Inconsistencia")
            Else
                ''''Visibilidad Inconsistenacia
                Pninc.Visible = True
                'ubicacion call
                drl_ubicacion_call.SelectedIndex = 0
                LinkBtn_Inconsistencia.Visible = False
                LinkBtn_Oculta_Inconsistencia.Visible = True
                ''''Visibilidad Falla de Red
                Pnfallared.Visible = False
                '---Escalamiento servicxe---'
                Pnl_Esc_Service.Visible = False
                lblmsg.Text = ""
            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub LinkBtn_Oculta_Inconsistencia_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkBtn_Oculta_Inconsistencia.Click
        Try
            Pninc.Visible = False
            LinkBtn_Inconsistencia.Visible = True
            LinkBtn_Oculta_Inconsistencia.Visible = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
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
                Throw New Exception("El Caso Claro: " + LblCasoClaro.Text + " ya tiene un registro de inconsistencai")
            End If
            Dim objdatos As New clscrmdatos
            If drlincons.SelectedIndex = 0 Then
                Throw New Exception("Elija el tipo de inconsistencia a reportar")
            Else
                objdatos.incidente = drlincons.SelectedItem.Value
            End If
            If txtobsinc.Text = "" Then
                Throw New Exception("Digite la observación de la inconsistencia")
            Else
                objdatos.obs = txtobsinc.Text
            End If
            If Txt_custcode.Text = "" Then
                Throw New Exception("Es obligatorio llenar Custcode ")
            Else
                objdatos.custcode = Txt_custcode.Text
            End If
            If Txt_usuario_reporta.Text = "" Then
                Throw New Exception("Digite el usuario reporta de la inconsistencia")
            Else
                objdatos.usuarioreporta = Txt_usuario_reporta.Text
            End If
            If drl_ubicacion_call.SelectedIndex = 0 Then
                Throw New Exception("Seleccione ubicacion de call center")
            Else
                objdatos.lugar = drl_ubicacion_call.SelectedValue
            End If
            If drlnivel.SelectedIndex > 0 Then
                objdatos.barrio = drlnivel.SelectedItem.Value
            Else
                Throw New Exception("Elija el nivel que genera la inconsistencia, verifique")
            End If
            objdatos.caso = LblCasoClaro.Text
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.estadoinc = "Aprobado"
            objdatos.registroinc()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Inconsistencia reportada con exito"
            drlinconsglobal.SelectedIndex = 0
            drlinconsglobal_SelectedIndexChanged(1, Nothing)
            drlincons.SelectedIndex = 0
            txtobsinc.Text = ""
            Txt_custcode.Text = ""
            Txt_usuario_reporta.Text = ""
            Pninc.Visible = False
            drlnivel.SelectedIndex = 0
            drlnivel_SelectedIndexChanged(1, Nothing)
            LinkBtn_Oculta_Inconsistencia.Visible = False
            LinkBtn_Inconsistencia.Visible = True
            drl_ubicacion_call.SelectedIndex = 0
            drl_ubicacion_call.Enabled = True
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub Btn_act_equipo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_act_equipo.Click
        drlmarca.Enabled = True
        drlequipo.Enabled = True
        Btn_act_equipo.Visible = False
    End Sub
    Protected Sub Btn_act_municipio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_act_municipio.Click
        drlmun.Enabled = True
        drldpto.Enabled = True
        Btn_act_municipio.Visible = False
    End Sub
    Protected Sub Btn_Act_PQR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Act_PQR.Click
        drlTipo_PQR.Enabled = True
        TxtPQR.Enabled = True
        Btn_Act_PQR.Visible = False
    End Sub

#Region "Drl's"
    Protected Sub Cargar_Drls()
        Try
            'Marca
            If Not IsPostBack Then
                With drlmarca
                    .DataSource = Obj_General.consultamarca
                    .DataTextField = "marca"
                    .DataValueField = "marca"
                    .DataBind()
                    drlmarca = Obj_G_D.Gest_Drl(drlmarca)
                End With
                'dpto Departamento
                With drldpto
                    .DataSource = Obj_General.consultadpto
                    .DataTextField = "nombredpto"
                    .DataValueField = "coddpto"
                    .DataBind()
                    drldpto = Obj_G_D.Gest_Drl(drldpto)
                End With
                With drlvariableCatalogo
                    Obj_General.idusuario = 6
                    .DataSource = Obj_General.consultadiagnostico
                    .DataTextField = "detalle"
                    .DataValueField = "idreg"
                    .DataBind()
                    drlvariableCatalogo = Obj_G_D.Gest_Drl(drlvariableCatalogo)
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
                'Inconsistencia Global
                Obj_General.cargo = "Global"
                With drlinconsglobal
                    .DataSource = Obj_General.consultaincdatos
                    .DataTextField = "inconsistencia"
                    .DataValueField = "idtipoinc"
                    .DataBind()
                    drlinconsglobal = Obj_G_D.Gest_Drl(drlinconsglobal)
                End With
                With drlFtectolog
                    Obj_General.idusuario = 4
                    .DataSource = Obj_General.consultadiagnostico
                    .DataTextField = "detalle"
                    .DataValueField = "idreg"
                    .DataBind()
                    drlFtectolog = Obj_G_D.Gest_Drl(drlFtectolog)
                End With
                With drlFcaract
                    .DataSource = Obj_General.consultacaractdat
                    .DataTextField = "desccarac"
                    .DataValueField = "idcarac"
                    .DataBind()
                    drlFcaract = Obj_G_D.Gest_Drl(drlFcaract)
                End With
                '*Catalogo de Servicio 3 drl
                'Tipo PQR Adicional
                Obj_General.Validacion = "Tipo PQR Adicional"
                With drlTipo_Pqr_Adicional
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Servicio_V2
                    .DataTextField = "tipo2"
                    .DataValueField = "tipo2"
                    .DataBind()
                    drlTipo_Pqr_Adicional = Obj_G_D.Gest_Drl(drlTipo_Pqr_Adicional)
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
                'Intencion Des Por Falla
                Obj_General.Validacion = "Intencion Des Por Falla"
                With drlIntension_Des_Por_Fallaen
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Servicio_V2
                    .DataTextField = "tipo2"
                    .DataValueField = "tipo2"
                    .DataBind()
                    drlIntension_Des_Por_Fallaen = Obj_G_D.Gest_Drl(drlIntension_Des_Por_Fallaen)
                End With
                'Tipo Proceso Linea
                Obj_General.Validacion = "Tipo Proceso Linea"
                With drlTipo_Proceso_Linea
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Servicio_V2
                    .DataTextField = "tipo2"
                    .DataValueField = "tipo2"
                    .DataBind()
                    drlTipo_Proceso_Linea = Obj_G_D.Gest_Drl(drlTipo_Proceso_Linea)
                End With
                'Tipo PQR
                Obj_General.Validacion = "Tipo PQR"
                With drlTipo_PQR
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Servicio_V2
                    .DataTextField = "tipo2"
                    .DataValueField = "tipo2"
                    .DataBind()
                    drlTipo_PQR = Obj_G_D.Gest_Drl(drlTipo_PQR)
                End With
                '* FALLA DE RED - VALIDACIONES SERVICIO AL CLINETE
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
                Obj_General.Validacion = "linea_serv"
                With drllinea
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Diagnostico2
                    .DataTextField = "tipificacion1"
                    .DataValueField = "tipificacion1"
                    .DataBind()
                    drllinea = Obj_G_D.Gest_Drl(drllinea)
                End With
                Obj_General.Validacion = "Ubicacion_call2"
                With drl_ubicacion_call
                    .DataSource = Obj_General.consulta_campaña_inb
                    .DataTextField = "nombre"
                    .DataValueField = "valor"
                    .DataBind()
                    drl_ubicacion_call = Obj_G_D.Gest_Drl(drl_ubicacion_call)
                End With
                drlAplica_Fidelizacion = Obj_G_D.Gest_Drl(drlAplica_Fidelizacion)
                drltipolinea = Obj_G_D.Gest_Drl(drltipolinea)
                drlLibera = Obj_G_D.Gest_Drl(drlLibera)
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
                drlmarca.SelectedIndex = 0
                drldpto.SelectedIndex = 0
                drlvariableCatalogo.SelectedIndex = 0
                drl_causal_escalamiento_service.SelectedIndex = 0
                drlinconsglobal.SelectedIndex = 0
                drlFtectolog.SelectedIndex = 0
                drlFcaract.SelectedIndex = 0
                drlTipo_Pqr_Adicional.SelectedIndex = 0
                Drl_justificacion_seguimiento.SelectedIndex = 0
                drlIntension_Des_Por_Fallaen.SelectedIndex = 0
                drlTipo_Proceso_Linea.SelectedIndex = 0
                drlTipo_PQR.SelectedIndex = 0
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
                drllinea.SelectedIndex = 0
                'reiniciar enbebidos en html
                drlAplica_Fidelizacion.SelectedIndex = 0
                drltipolinea.SelectedIndex = 0
                drlLibera.SelectedIndex = 0
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
            drlmarca_SelectedIndexChanged(1, Nothing)
            drldpto_SelectedIndexChanged(1, Nothing)
            drlinconsglobal_SelectedIndexChanged(1, Nothing)
            drllinea_SelectedIndexChanged(1, Nothing)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
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
    Protected Sub drlvariableCatalogo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlvariableCatalogo.SelectedIndexChanged
        Try
            If drlvariableCatalogo.SelectedIndex > 0 Then
                Dim objdatos As New clscrmdatos
                objdatos.diagservicio = drlvariableCatalogo.SelectedItem.Value
                objdatos.consultaproceso()
                lblvariable1.Text = objdatos.tipificacion
            Else
                lblvariable1.Text = Nothing
            End If
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Pnl_Message.CssClass = "alert alert-danger"
                lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
            Else
                Throw ex
            End If
        End Try
    End Sub
    Protected Sub Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedIndexChanged
        Try
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text = "FALSO" Then
                Drl_Split_Billing.Visible = True
            Else
                Drl_Split_Billing.Visible = False
            End If
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Pnl_Message.CssClass = "alert alert-danger"
                lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
            Else
                Throw ex
            End If
        End Try
    End Sub
    Protected Sub drl_causal_escalamiento_service_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drl_causal_escalamiento_service.SelectedIndexChanged
        Try
            If drl_causal_escalamiento_service.SelectedIndex = 0 Or drl_causal_escalamiento_service.SelectedItem.Text = "Otros" Then
                drlapn.SelectedIndex = 0
                drlapn.Enabled = True
                drlqos.SelectedIndex = 0
                drlqos.Enabled = True
                txtfcactivacion.Text = ""
                txtfcactivacion.Enabled = True
                drlvariableCatalogo.SelectedIndex = 0
                drlvariableCatalogo.Enabled = True
                drlvariableCatalogo_SelectedIndexChanged(1, Nothing)
                lbl_Fecha_Act_Ciclo.Text = "Fecha Activacion"
            ElseIf drl_causal_escalamiento_service.SelectedItem.Text = "Linea No Registra" Then
                drlapn.SelectedIndex = 0
                drlapn.Enabled = False
                drlqos.SelectedIndex = 0
                drlqos.Enabled = False
                txtfcactivacion.Text = ""
                txtfcactivacion.Enabled = False
                drlvariableCatalogo.SelectedIndex = 2
                drlvariableCatalogo.Enabled = False
                drlvariableCatalogo_SelectedIndexChanged(1, Nothing)
                lbl_Fecha_Act_Ciclo.Text = "Fecha Activacion"
            ElseIf drl_causal_escalamiento_service.SelectedItem.Text = "Aprovisionamiento de Paquetes Prepago" Then
                drlapn.SelectedIndex = 0
                drlapn.Enabled = True
                drlqos.SelectedIndex = 0
                drlqos.Enabled = True
                txtfcactivacion.Text = ""
                txtfcactivacion.Enabled = True
                drlvariableCatalogo.SelectedIndex = 1
                drlvariableCatalogo.Enabled = False
                drlvariableCatalogo_SelectedIndexChanged(1, Nothing)
                lbl_Fecha_Act_Ciclo.Text = "Fecha Activacion"
            ElseIf drl_causal_escalamiento_service.SelectedItem.Text = "Reinicio de Ciclo - Linea Postpago" Then
                drlapn.SelectedIndex = 0
                drlapn.Enabled = True
                drlqos.SelectedIndex = 0
                drlqos.Enabled = True
                txtfcactivacion.Text = ""
                txtfcactivacion.Enabled = True
                drlvariableCatalogo.SelectedIndex = 6
                drlvariableCatalogo.Enabled = False
                drlvariableCatalogo_SelectedIndexChanged(1, Nothing)
                lbl_Fecha_Act_Ciclo.Text = "Fecha de Ciclo"
            End If
        Catch ex As Exception
            If TypeOf sender Is DropDownList Then
                Pnl_Message.CssClass = "alert alert-danger"
                lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
            Else
                Throw ex
            End If
        End Try
    End Sub
    Protected Sub drllinea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drllinea.SelectedIndexChanged
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
    Protected Sub drlSegmento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlSegmento.SelectedIndexChanged
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
    Protected Sub drlCausa_Raiz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlCausa_Raiz.SelectedIndexChanged
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
            If drltipificacionll.SelectedItem.Text.Contains("Escalar") Then
                Rdb_Contacto.Enabled = True
                Rdb_Contacto.ClearSelection()
            ElseIf Not drltipificacionll.SelectedItem.Text.Contains("Escalar") Then
                Rdb_Contacto.Enabled = False
                Rdb_Contacto.ClearSelection()
            End If
            If drltipificacionll.SelectedItem.Text.Contains("SD") Then
                Pnl_Esc_Service.Visible = True
                Pnfallared.Visible = False
            ElseIf drltipificacionll.SelectedItem.Text.Contains("CPD") Then
                Pnl_Esc_Service.Visible = False
                Pnfallared.Visible = True
            Else
                Pnl_Esc_Service.Visible = False
                Pnfallared.Visible = False
            End If
            If drltipificacionll.SelectedItem.Text = "Programado" Then
                Pnl_Seguimiento.Visible = True
            Else
                Pnl_Seguimiento.Visible = False
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
#Region "Check & Dtg change"
    Protected Sub Si_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkSi.CheckedChanged
        Try
            If chkSi.Checked = True Then
                txtnumalt.Enabled = True
                txtnumalt.Text = ""
            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub chkNo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkNo.CheckedChanged
        Try
            If chkNo.Checked = True Then
                txtnumalt.Enabled = False
                txtnumalt.Text = ""
            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub dtgprog_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgprog.PageIndexChanging
        Try
            dtgprog.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtgprog.DataSource = ViewState("dtgprog")
            dtgprog.DataBind()
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
#End Region
#Region "Seción en desuso"
    Protected Sub BuscarInfInbound()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                Throw New Exception("Digite el Caso o Min que desea consultar")
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
                    Pnl_Message.CssClass = Nothing
                    lblmsg.Text = Nothing
                    If lblmin.Text <> "" Then
                        objdatos.min = lblmin.Text
                    End If
                Else
                    lblcliente.Text = Nothing
                    lbldocumento.Text = Nothing
                    lblmin.Text = Nothing
                    lblplan.Text = Nothing
                    lbllugar.Text = Nothing
                    lblcaso.Text = Nothing
                    lblobs611.Text = Nothing
                    lblestado.Text = Nothing

                    txtminnv.Text = Nothing
                    txtplannv.Text = Nothing
                    txtidentifnv.Text = Nothing
                    txtnombrenv.Text = Nothing
                    TxtIngRemite.Text = Nothing

                    rdbtipoinb.selectedvalue = Nothing
                    Btn_Nuevo_Regist_Inb.Visible = False
                    pnnuevo.Visible = False
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se han encontrado registros coincidentes"
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub BtnNuevo_caso_Click(sender As Object, e As EventArgs) Handles BtnNuevo_caso.Click
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                Throw New Exception("Consulte el caso")
            End If
            BuscarInfInbound()
            Dim dts As New DataSet
            objdatos.caso = txtcaso.Text
            objdatos.Validacion = "Fidelizacion"
            dts = objdatos.Validacion_Registro_Inboun()
            If dts.Tables(0).Rows.Count > 0 Then
                Lblfc_ingreso.Text = ""
                lblBandeja.Text = ""
                LblCasoClaro.Text = ""
                Throw New Exception("El Caso " & txtcaso.Text & " ya se encuentra identificado, con la id " & objdatos.min)
                'Exit Sub
            End If
            pnnuevo.Visible = True
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
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub Btn_Nuevo_Regist_Inb_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo_Regist_Inb.Click
        Try
            Dim objdatos As New clscrmdatos
            If rdbtipoinb.selectedvalue = Nothing Then
                Throw New Exception("Digite el tipo de llamada inbound, Corporativo o Fidelización")
            End If
            If txtminnv.Text = "" Then
                Throw New Exception("Digite el Min del caso recibido en Inbound")
            End If
            If txtplannv.Text = "" Then
                Throw New Exception("Digite el plan del caso recibido en Inbound")
            End If
            If txtidentifnv.Text = "" Then
                Throw New Exception("Digite la identificación del usuario del caso recibido en Inbound")
            End If
            If txtnombrenv.Text = "" Then
                Throw New Exception("Digite el nombre del usuario del caso recibido en Inbound")
            End If
            If TxtIngRemite.Text = "" Then
                Throw New Exception("Digite el Nombre del Ingeniero que lo Remite")
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            objdatos.min = txtminnv.Text
            objdatos.plan = txtplannv.Text
            objdatos.identificacion = txtidentifnv.Text
            objdatos.nompaquete = txtnombrenv.Text
            If lblobs611.Text = "" Then
                objdatos.tipofalla = "Registro Inbound " & rdbtipoinb.SelectedItem.Value
            Else
                objdatos.tipofalla = "Registro Inbound " & rdbtipoinb.SelectedItem.Value & " " & lblobs611.Text
            End If
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
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
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Caso reconocido como inbound"
            Else
                objdatos.Validacion = "Fidelizacion"
                objdatos.registroinb()
                objdatos.caso = txtcaso.Text
                objdatos.Validacion = "Fidelizacion"
                dts = objdatos.Validacion_Registro_Inboun()
                objdatos.caso = objdatos.min
                txtcaso.Text = objdatos.min
                BtnBuscar_Click(1, Nothing)
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro inbound ingresado con éxito"
            End If
            pnnuevo.Visible = False
            txtminnv.Text = ""
            txtplannv.Text = ""
            txtidentifnv.Text = ""
            rdbtipoinb.selectedvalue = Nothing
            txtnombrenv.Text = ""
            TxtCasoNuevo.Text = ""
            TxtIngRemite.Text = ""
            txtcaso.Text = objdatos.abierto
            txtcaso.Text = lblcaso.Text
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
#End Region
End Class
