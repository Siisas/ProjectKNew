Public Class Registro_Inbound
    Inherits System.Web.UI.Page
    Protected Obj_General As New clsgeneral
    Protected Obj_G_D As New Cls_Gestion_Datos
    'PAGE_LOAD
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Limpiar_Herramientas()
                Session("Formulario") = "Registro Inbound"
                Dim objGeneral As New clsgeneral
                LblPQR.Text = objGeneral.Consulta_Numero_PQR().Tables(0).Rows(0).Item("Nombre")
                Cargar_drl()
                Casos_Asignados()
            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
#Region "Métodos"
    'Caraga Programados
    Protected Sub Casos_Asignados()
        Dim ObjCrmDatos As New clscrmdatos
        ObjCrmDatos.idusuarioasignado = CType(Session("permisos"), clsusuario).usuario
        ViewState("Dtg_Asignados") = ObjCrmDatos.Casos_Asginados_Inbound()
        Dtg_Asignados.DataSource = ViewState("Dtg_Asignados")
        Dtg_Asignados.DataBind()
        Lbl_Cantidad.Text = "Casos Asignados: " & ObjCrmDatos.cantidad
    End Sub
    'Limpiar herramientas registro
    Protected Sub Limpiar_Herramientas()
        Try
            If (Date.Now.TimeOfDay >= Convert.ToDateTime("21:55").TimeOfDay And Date.Now.TimeOfDay <= Convert.ToDateTime("23:59:59").TimeOfDay) Or (Date.Now.TimeOfDay >= Convert.ToDateTime("00:00").TimeOfDay And Date.Now.TimeOfDay <= Convert.ToDateTime("06:00").TimeOfDay) Then
                Pnl_Fecha_Hora_Reg.Visible = True
            Else
                Pnl_Fecha_Hora_Reg.Visible = False
            End If
            ViewState("dtggeneral") = Nothing
            dtggeneral.DataSource = Nothing
            dtggeneral.DataBind()
            rdbvc.selectedvalue = Nothing
            Pnl_Llamada_Corta.Visible = False
            Panel_consulta.Visible = False
            btn_guardar.Visible = False
            Btn_rechazar_inb.Enabled = False
            lbl_caso.Text = Nothing
            lbl_estado.Text = Nothing
            lbl_min_alterno.Text = Nothing
            lbl_fecha_ingreso.Text = Nothing
            lbl_usuario_registra.Text = Nothing
            lbl_formato.Text = "Caso"
            '-----------REGISTRO INBOUND--------------'
            txt_IDAVAYA.Text = Nothing
            txt_min.Text = Nothing
            txt_nombre.Text = Nothing
            txt_usu_reporta.Text = Nothing
            txtbarrio.Text = Nothing
            txtultimc.Text = Nothing
            chkSi.Checked = False
            chkNo.Checked = False
            txtnumalt.Text = Nothing
            txtnumalt.Visible = False
            Txt_Fecha_Hora_Reg.Text = Nothing
            '-----------DIAGNOSTICO--------------'
            '-----------CIERRE LLAMADA--------------'
            TxtPQR.Text = Nothing
            txt_formato.Text = Nothing
            '---------------SEGUIMIENTO----------------'
            txtfcprog.Text = Nothing
            '----------------ENCUESTA-------------------'
            txtobsincon.Text = Nothing
            txtobs.Text = Nothing
            '---------PANELES-------------'
            Panel_Falla_red.Visible = False
            Panel_Service.Visible = False
            Panel_Justificacion.Visible = False
            '-------------HABILITAR-------------------'
            drlmarca.Enabled = True
            drlequipo.Enabled = True
            drldpto.Enabled = True
            drlmun.Enabled = True
            txtbarrio.Enabled = True
            txtultimc.Enabled = True
            drlfranja.Enabled = True
            drlFtectolog.Enabled = True
            drlTipo_PQR.Enabled = True
            TxtPQR.Enabled = True
            drlModalidad.Enabled = True
            txt_IDAVAYA.Enabled = True
            txt_min.Enabled = True
            txt_nombre.Enabled = True
            txt_usu_reporta.Enabled = True
            txt_formato.Enabled = True
            '---------BOTONES-------------'
            Btn_Habilita_Fc_Utl_Caida.Visible = False
            Btn_Habilita_Tecnologia.Visible = False
            Btn_Habilita_PQR.Visible = False
            Btn_Habilita_Equipo.Visible = False
            Btn_Habilita_Municipio.Visible = False
            '---------GRIDS-------------'
            dtggeneral.DataSource = Nothing
            dtggeneral.DataBind()
            CHKSD.Checked = False
            drlcampaña.Enabled = True
            CHKSD.Enabled = True
            Drl_Falla.Enabled = True
            drllinea.Enabled = True
            drlservicio2.Enabled = True
            drlsolicitud.Enabled = True
            drlSegmento.Enabled = True
            drlCausa_Raiz.Enabled = True
            drlCategoriaCierre.Enabled = True
            drltipificacionll.Enabled = True
            drlinconsistencia.Enabled = True
            txt_formato_recha.Text = Nothing
            txt_fecha_caso_recha.Text = Nothing
            txt_fecha_Ult_Ges.Text = Nothing
            txt_custcode_r.Text = Nothing
            Panel_Rechazado.Visible = False
            '----------------FALLA RED-------------------'
            Txt_N_Doc_Id_CPD.Text = Nothing
            txtFcontacto.Text = Nothing
            txtFnum.Text = Nothing
            txtFtipofalla.Text = Nothing
            txtFciudad.Text = Nothing
            txtFdirecc.Text = Nothing
            txtapn.Text = Nothing
            txtfobs.Text = Nothing
            '----------------SERVICE-------------------'
            txtfcactivacion.Text = Nothing
            lblvariable.Text = Nothing
            'service
            Txt_Validacion_Coordenadas.Text = Nothing
            Casos_Asignados()
            Cargar_drl()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub Crear_caso()
        Try
            Dim Objdatos As New clscrmdatos
            If lbl_estado.Text = "" Then
                If Pnl_Fecha_Hora_Reg.Visible = True Then
                    Objdatos.fcreg = Convert.ToDateTime(Txt_Fecha_Hora_Reg.Text)
                End If
                Objdatos.caso = txt_formato.Text
                Objdatos.Caso_Claro = txt_IDAVAYA.Text
                Objdatos.min = txt_min.Text
                Objdatos.cliente = txt_nombre.Text.ToUpper
                Objdatos.usuarioreporta = txt_usu_reporta.Text.ToUpper
                Objdatos.Bandeja = drlcampaña.SelectedValue.ToUpper
                If chkSi.Checked = True Then
                    If txtnumalt.Text <> "" Then
                        Objdatos.Contacto_cliente = txtnumalt.Text
                    Else
                        Objdatos.Contacto_cliente = ""
                    End If
                End If
                If chkNo.Checked = True Then
                    Objdatos.Contacto_cliente = txt_min.Text
                End If
                If CHKSD.Checked = True Then
                    Objdatos.tickler = txt_SD.Text
                Else
                    Objdatos.tickler = ""
                End If

                Objdatos.dpto = drldpto.SelectedItem.Text
                Objdatos.zona = drlmun.SelectedItem.Text
                Objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                Objdatos.Caso_rechazado = txt_formato_recha.Text
                Objdatos.fcini3 = txt_fecha_caso_recha.Text
                Objdatos.fcfin3 = txt_fecha_Ult_Ges.Text
                Objdatos.crear_caso_inbound()
                If Objdatos.caso <> Nothing Then
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Caso creado correctamente " & txt_formato.Text
                Else
                    Throw New Exception("Se presento un error, intente de nuevo")
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'creado
    Protected Sub Registro_CRM_escalamiento()
        Try
            Dim ObjDatos As New clscrmdatos
            If Pnl_Fecha_Hora_Reg.Visible = True Then
                ObjDatos.fcreg = Convert.ToDateTime(Txt_Fecha_Hora_Reg.Text)
            End If

            ObjDatos.caso = txt_formato.Text
            ObjDatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            ObjDatos.obs = txtobs.Text
            ObjDatos.tipificacion = "Creado"
            If drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD" Then
                ObjDatos.preg2 = "Service"
            ElseIf drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Then
                ObjDatos.preg2 = "Tecnica"
            End If
            ObjDatos.registro_CRM_inbound_escalamiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub Registrar_CPD()
        Dim objFdatos As New clsvoz
        If Pnl_Fecha_Hora_Reg.Visible = True Then
            objFdatos.fcreg = Convert.ToDateTime(Txt_Fecha_Hora_Reg.Text)
        End If
        If txtFcontacto.Text = "" Then
            Throw New Exception("Digite la persona de contacto")
        Else
            objFdatos.cliente = txtFcontacto.Text
        End If
        If Txt_N_Doc_Id_CPD.Text = Nothing Then
            Throw New Exception("Ingrese el número de documento de identidad de la persona que reporta")
        ElseIf Not IsNumeric(Txt_N_Doc_Id_CPD.Text) Then
            Throw New Exception("El número de documento de identidad de la persona que reporta debe estar compuesto solo por números")
        End If
        If txtFnum.Text = "" Then
            Throw New Exception("Digite el número de contacto")
        Else
            objFdatos.telcontacto = txtFnum.Text
        End If
        If drlFtiempo.SelectedIndex = 0 Then
            Throw New Exception("Elija el tiempo que lleva presentándose la falla")
        Else
            objFdatos.tiempo = drlFtiempo.SelectedItem.Value
        End If
        If txtFtipofalla.Text = "" Then
            objFdatos.tipofalla = ""
        Else
            objFdatos.tipofalla = txtFtipofalla.Text
        End If
        If drlFcaract.SelectedIndex = 0 Then
            Throw New Exception("Describa las características del tipo de falla")
        Else
            objFdatos.caracter = drlFcaract.SelectedItem.Text
        End If
        If drlFportada.SelectedIndex = 0 Then
            Throw New Exception("Elija si la línea es portada o no")
        Else
            objFdatos.portada = drlFportada.SelectedItem.Value
        End If
        If drlmun.SelectedIndex = 0 Then
            Throw New Exception("Elija el Departamento y Municipio de la falla")
        Else
            objFdatos.mun = drlmun.SelectedItem.Value
        End If
        If txtFciudad.Text = "" Then
            objFdatos.vereda = ""
        Else
            If rdbvc.selectedvalue = Nothing And txtFciudad.Text <> Nothing Then
                Throw New Exception("Elija si el lugar corresponde a un corregimiento, Vereda o Inspección")
            Else
                objFdatos.vereda = rdbvc.SelectedItem.Value & " " & txtFciudad.Text
            End If
        End If
        If txtFdirecc.Text = "" Then
            Throw New Exception("Digite la dirección donde se presenta la falla")
        Else
            objFdatos.dir = txtFdirecc.Text
        End If
        If txtbarrio.Text = "" Then
            Throw New Exception("Digite el barrio donde se presenta la falla")
        Else
            objFdatos.barrio = txtbarrio.Text
        End If
        If drlFtectolog.SelectedIndex = 0 Then
            Throw New Exception("Elija la tecnología del equipo que presenta la falla")
        Else
            objFdatos.tecnologia = drlFtectolog.SelectedItem.Text
        End If
        objFdatos.equipo = drlequipo.SelectedItem.Value
        If drlFlineasfalla.SelectedIndex = 0 Then
            Throw New Exception("Elija si se reportan más líneas con falla en la ubicación reportada")
        Else
            objFdatos.maslineas = drlFlineasfalla.SelectedItem.Value
        End If
        If txtfobs.Text = "" Then
            Throw New Exception("Digite las observaciones reportadas por el usuario")
        Else
            objFdatos.obs = txtfobs.Text
        End If
        If txtapn.Text = "" Then
            Throw New Exception("Digite el APN Afectado")
        Else
            objFdatos.apn = txtapn.Text
        End If
        If Drl_Qos.SelectedIndex = 0 Then
            Throw New Exception("Seleccione un QoS")
        Else
            objFdatos.qos = Drl_Qos.SelectedItem.Text
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
        objFdatos.N_Doc_Id = Txt_N_Doc_Id_CPD.Text
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
        objFdatos.campana = "INBOUND"
        objFdatos.caso = txt_formato.Text
        objFdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
        If lbl_estado.Text <> "" Then
            objFdatos.fcini = lbl_fecha_ingreso.Text
        Else
            objFdatos.fcini = Now
        End If
        Crear_caso()
        objFdatos.registrofallasred_inbound()
        Registro_CRM_escalamiento()
    End Sub
    Protected Sub Registrar_SD()
        Dim objSdatos_sd As New clscrmdatos
        If Pnl_Fecha_Hora_Reg.Visible = True Then
            objSdatos_sd.fcreg = Convert.ToDateTime(Txt_Fecha_Hora_Reg.Text)
        End If
        If drlvariable.SelectedIndex = 0 Then
            Throw New Exception("Elija un Error en Registro")
        End If
        If drlapn.SelectedIndex = 0 Then
            Throw New Exception("Elija el APN del caso")
        Else
            objSdatos_sd.apn = drlapn.SelectedItem.Text
        End If
        If drlqos.SelectedIndex = 0 Then
            Throw New Exception("Seleccione el QoS del caso")
        Else
            objSdatos_sd.qos = drlqos.SelectedItem.Text
        End If
        If txtfcactivacion.Text = "" Then
            Throw New Exception("Digite la fecha de activación del servicio")
        Else
            objSdatos_sd.fcini = txtfcactivacion.Text
        End If
        If Not FileDocumento.PostedFile Is Nothing Then
            If Not FileDocumento.PostedFile Is Nothing And FileDocumento.PostedFile.ContentLength > 0 Then
                FileDocumento.PostedFile.SaveAs(Server.MapPath("data_Doc") & "\\" & txt_formato.Text + System.IO.Path.GetExtension(FileDocumento.PostedFile.FileName))
                objSdatos_sd.archivo = txt_formato.Text + System.IO.Path.GetExtension(FileDocumento.PostedFile.FileName)
            Else
                Throw New Exception("Adjunte un archivo")
            End If
        Else
            Throw New Exception("Adjunte un archivo")
        End If
        objSdatos_sd.caso = txt_formato.Text
        objSdatos_sd.diagvariable = drlvariable.SelectedItem.Value
        objSdatos_sd.obs = txtobs.Text
        objSdatos_sd.idusuario = CType(Session("permisos"), clsusuario).usuario
        Crear_caso()
        objSdatos_sd.Registroservice_inbound()
        Registro_CRM_escalamiento()
    End Sub
    Protected Sub registro_inconsistencia_rechazado()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.caso = txt_formato.Text
            objdatos.incidente = drl_inconsistencia_recha.SelectedItem.Value
            objdatos.custcode = txt_custcode_r.Text
            objdatos.obs = txtobs.Text
            objdatos.usuarioreporta = txt_usu_reporta.Text
            objdatos.barrio = drl_nivel.SelectedItem.Value
            objdatos.lugar = drl_UbicacionCall.SelectedItem.Text
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.estadoinc = "Aprobado"
            objdatos.registroinc()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#Region "Btn's"
    'Caso nuevo
    Protected Sub Btn_caso_nuevo_Click(sender As Object, e As EventArgs) Handles Btn_caso_nuevo.Click
        Try
            Limpiar_Herramientas()
            btn_guardar.visible = True
            Panel_registro.Visible = True
            'Panel_rechazados.Visible = False
            PanelCasos.Visible = True
            Pnl_Llamada_Corta.Visible = False
            txtcaso.Text = ""
            LinkButton3.Visible = True
            Btn_rechazar_inb.Enabled = True
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'Boton guardar
    Protected Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim objdatos As New clscrmdatos
        Try
            '-------REGISTRO INBOUND------
            'fecha y hora de registro
            If Pnl_Fecha_Hora_Reg.Visible = True Then
                If Txt_Fecha_Hora_Reg.Text = Nothing Then
                    Throw New Exception("dijite una fecha y hora de regitro")
                Else
                    If Not IsDate(Txt_Fecha_Hora_Reg.Text) Then
                        Throw New Exception("la fecha y hora de registro no tiene el formato correcto")
                    ElseIf Convert.ToDateTime(Txt_Fecha_Hora_Reg.Text) > Date.Now Then
                        Throw New Exception("la fecha y hora de registro no peden ser mayores a la fecha y hora actual")
                    End If
                    objdatos.fcreg = Convert.ToDateTime(Txt_Fecha_Hora_Reg.Text)
                End If
            End If
            If Drl_Falla.SelectedIndex > 0 Then
                objdatos.Tipo_Falla = Drl_Falla.SelectedItem.Text
            Else
                objdatos.Tipo_Falla = Nothing
            End If
            '-------VALIDACION CAMBIO ESTADO----------
            If txt_formato.Text <> "" Then
                objdatos.Validacion = 5
                objdatos.caso = txt_formato.Text
                objdatos.ConsultarEstados()
                If objdatos.cantidad <> 0 Then
                    If objdatos.tipificacion.Contains("Cerrado") Or objdatos.tipificacion.Contains("Escala") Then
                        Throw New Exception("¡El Caso que desea guardar se encuentra Cerrado o Escalado!")
                    Else
                        objdatos.Validacion = Nothing
                    End If
                End If
            End If
            'ID AVAYA
            If txt_IDAVAYA.Text = "" Then
                Throw New Exception("Digite Id de AVAYA")
            End If
            'min
            If txt_min.Text = "" Then
                Throw New Exception("Digite numero principal")
            ElseIf txt_min.Text.Length < 10 Then
                Throw New Exception("El numero debe tener 10 digitos")
            End If
            'NOMBRE
            If txt_nombre.Text = "" Then
                Throw New Exception("Digite nombre")
            End If
            'CAMPAÑA
            If drlcampaña.SelectedIndex = 0 Then
                Throw New Exception("Seleccione Campaña")
            End If
            'REPORTA
            If txt_usu_reporta.Text = "" Then
                Throw New Exception("Digite usuario reporta")
            End If
            'MARCA
            If drlmarca.SelectedIndex = 0 Then
                Throw New Exception("Seleccione marca del equipo")
            End If
            'EQUIPO
            If drlequipo.SelectedIndex = 0 Then
                Throw New Exception("Seleccione un equipo ")
            End If
            'DEPARTAMENTO
            If drldpto.SelectedIndex = 0 Then
                Throw New Exception("Seleccione un departamento")
            End If

            'MUNICIPIO
            If drlmun.SelectedIndex = 0 Then
                Throw New Exception("Seleccione un municipio")
            End If
            'BARRIO
            If txtbarrio.Text = "" Then
                Throw New Exception("Digite el barrio donde se presenta la falla")
            End If
            'ULTIMA CAIDA
            If txtultimc.Text <> "" Then
                If txtultimc.Text <> "" And drlfranja.SelectedIndex = 0 Then
                    Throw New Exception("Elija la franja en la que se presentó la última caida: mañana, tarde, noche (GEORREFERENCIACIÓN - Fecha Ultima Caida)")
                End If
                If txtultimc.Text <> Nothing Then
                    'valida fecha no superior a la actual
                    If Convert.ToDateTime(Me.txtultimc.Text) > Today Then
                        Throw New Exception("La fecha de caida no puede ser mayor a la fecha actual (GEORREFERENCIACIÓN - Fecha Ultima Caida)")
                    End If
                End If
            End If
            'CONDICION DE USO
            If drlFtectolog.SelectedIndex = 0 Then
                Throw New Exception("Elija la tecnología del equipo que presenta la falla")
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
                    objdatos.telalt = txt_min.Text
                End If
            End If
            If CHKSD.Checked = True Then
                If txt_SD.Text = "" Then
                    Throw New Exception("Digite el SD de incidencia")
                End If
                If txt_SD.Text = "" Then
                    Throw New Exception("Digite el SD de incidencia")
                Else
                    objdatos.tickler = txt_SD.Text
                End If
            End If
            '-------DIAGNOSTICO------
            'LINEA DE SERVICIO
            If drllinea.SelectedIndex = 0 Then
                Throw New Exception("Seleccione linea de servicio")
            End If
            'SERVICIO
            If drlservicio2.SelectedIndex = 0 Then
                Throw New Exception("Seleccione servicio")
            End If
            'SOLICITUD / TIPO FALLA
            If drlsolicitud.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una Solicitud / Tipo Falla (VOZ DEL CLIENTE - Solicitud / Tipo Falla)")
            End If
            'SEGMENTO
            If drlSegmento.SelectedIndex = 0 Then
                Throw New Exception("Seleccione segmento de llamada")
            End If
            'CAUSA RAIZ
            If drlCausa_Raiz.SelectedIndex = 0 Then
                Throw New Exception("Seleccione causa raiz de llamada")
            End If
            '-------CIERRE LLAMADA------
            'TIPIFICACION
            If drltipificacionll.SelectedIndex = 0 Then
                Throw New Exception("Seleccione tipificacion de llamada")
            End If
            'CATEGORIA DE CIERRE
            If drlCategoriaCierre.SelectedIndex = 0 Then
                Throw New Exception("Seleccione categoria de cierre de llamada")
            End If
            'MODALIDAD
            If drlModalidad.SelectedIndex = 0 And drltipificacionll.SelectedItem.Text <> "Rechazado" Then
                Throw New Exception("Seleccione una modalidad (VOZ DEL CLIENTE - Modalidad)")
            End If
            If drltipificacionll.SelectedItem.Text = "Rechazado" Then
                Obj_G_D.Validar_Herramientas(txt_formato_recha, "Caso Rechazado")
                Obj_G_D.Validar_Herramientas(txt_fecha_caso_recha, "Fecha Caso Rechazado")
                Obj_G_D.Validar_Herramientas(txt_fecha_Ult_Ges, "Fecha Ultima Gestion")
                Obj_G_D.Validar_Herramientas(txt_custcode_r, "Custcode")
                Obj_G_D.Validar_Herramientas(drl_UbicacionCall, "Ubicacion Call Center")
            End If
            'PQR
            If drltipificacionll.SelectedItem.Text <> "Cerrado" And drltipificacionll.SelectedItem.Text <> "Rechazado" Then
                If TxtPQR.Text = "" Then
                    Throw New Exception("Ingrese el consecutivo PQR")
                Else
                    If TxtPQR.Text.Length < 7 Then
                        Throw New Exception("La PQR debe tener 7 digitos")
                    End If
                    objdatos.pqr = Int64.Parse(LblPQR.Text + TxtPQR.Text)
                End If
                'TIPO PQR
                If drlTipo_PQR.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione Tipo PQR")
                Else
                    objdatos.Tipo_PQR = drlTipo_PQR.SelectedItem.Text
                End If
            ElseIf lbl_estado.Text <> "" And drltipificacionll.SelectedItem.Text = "Cerrado" Then
                objdatos.pqr = Int64.Parse(LblPQR.Text + TxtPQR.Text)
                'TIPO PQR
                If drlTipo_PQR.SelectedIndex = 0 Then
                    objdatos.Tipo_PQR = ""
                Else
                    objdatos.Tipo_PQR = drlTipo_PQR.SelectedItem.Text
                End If
            ElseIf lbl_estado.Text = "" And drltipificacionll.SelectedItem.Text = "Cerrado" Then
                objdatos.pqr = ""
                objdatos.Tipo_PQR = ""
            End If
            'CASO
            If InStr(1, txt_formato.Text, " ") Then
                Throw New Exception("En la caja de texto caso no pueden existir espacios verifique!!")
            End If
            If txt_formato.Text = "" Then
                Throw New Exception("Digite numero de caso")
            End If
            'CASO
            If txt_formato.Text = "" Then
                Throw New Exception("Digite el caso que desea registrar")
            Else
                objdatos.caso = txt_formato.Text
            End If
            'Juistificacion caso
            If drltipificacionll.SelectedItem.Text <> "Cerrado" And Not drltipificacionll.SelectedItem.Text.Contains("Solici") And drltipificacionll.SelectedItem.Text <> "Falla Masiva" And drltipificacionll.SelectedItem.Text <> "Rechazado" Then
                If Drl_justificacion_seguimiento.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione la justificacion del seguimiento")
                Else
                    objdatos.preg3 = Drl_justificacion_seguimiento.SelectedItem.Text
                End If
            Else
                objdatos.preg3 = ""
            End If
            '-------SEGUMIENTO------
            'HORA PROGRAMADA
            If drltipificacionll.SelectedItem.Text = "Programado" Then
                If txtfcprog.Text = "" Then
                    Throw New Exception("Si la llamada es programada elija la fecha y hora a la que se debe llamar nuevamente ")
                    txtfcprog.Text = ""
                Else
                    Dim hora As String
                    hora = Convert.ToDateTime(txtfcprog.Text)
                    If Convert.ToDateTime(hora) <= Now Then
                        txtfcprog.Text = ""
                        Throw New Exception("La fecha de programación debe ser mayor a la fecha actual")
                    End If
                    objdatos.horaprog = hora
                End If
            End If
            '-------ENCUESTA------
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
                ElseIf drlinconsistencia.SelectedItem.Text <> "Otro" Then
                    objdatos.inconsistencia_encuesta = drlinconsistencia.SelectedItem.Text
                Else
                    objdatos.inconsistencia_encuesta = txtobsincon.Text
                End If
            End If
            '-------OBSERVACION------
            'CAPTURA OBSERVACION
            If txtobs.Text = "" Then
                Throw New Exception("Digite la observación de atención al caso (OBSERVACIÓN)")
            Else
                objdatos.obs = txtobs.Text
            End If
            '----------------------CAPTURA INFORMACION-------------------------------------'
            'CAPTURA CONDICION DE USO
            If drlFtectolog.SelectedIndex = 0 Then
                objdatos.diagtecnolog = ""
            Else
                objdatos.diagtecnolog = drlFtectolog.SelectedItem.Value
            End If
            'CAPTURA ERROR EN REGISTRO
            If drlvariable.SelectedIndex = 0 Then
                objdatos.diagvariable = ""
            Else
                objdatos.diagvariable = drlvariable.SelectedItem.Value
            End If
            'ESCALAMIENTO crm
            If drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD" Then
                objdatos.preg2 = "Service"
            ElseIf drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Then
                objdatos.preg2 = "Tecnica"
            Else
                objdatos.preg2 = ""
            End If
            'MUNICIPIO
            If drlmun.SelectedIndex = 0 Then
                objdatos.mun = ""
            Else
                objdatos.mun = drlmun.SelectedValue
            End If
            'BARRIO
            If txtbarrio.Text = "" Then
                objdatos.barrio = ""
            Else
                objdatos.barrio = txtbarrio.Text
            End If
            'FECHA ULTIMA CAIDA
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
            'SERVICIO
            If drlservicio2.SelectedIndex = 0 Then
                objdatos.idservicio = ""
            Else
                objdatos.idservicio = drlservicio2.SelectedValue
            End If
            'SOLICTUD / TIPO FALLA
            If drlsolicitud.SelectedIndex = 0 Then
                objdatos.solicitud = ""
            Else
                objdatos.solicitud = drlsolicitud.SelectedItem.Value
            End If
            'EQUIPO
            If drlequipo.SelectedIndex = 0 Then
                objdatos.equipo = ""
            Else
                objdatos.equipo = drlequipo.SelectedItem.Text
            End If
            'MODALIDAD
            If drlModalidad.SelectedIndex = 0 Then
                objdatos.Modalidad = ""
            Else
                objdatos.Modalidad = drlModalidad.SelectedItem.Text
            End If
            'CAUSA RAIZ
            If drlCausa_Raiz.SelectedIndex = 0 Then
                objdatos.Causa_Raiz = ""
            Else
                objdatos.Causa_Raiz = drlCausa_Raiz.SelectedValue
            End If
            'CATEGORIA
            If drlCategoriaCierre.SelectedIndex = 0 Then
                objdatos.Categoria_Cierre = ""
            Else
                objdatos.Categoria_Cierre = drlCategoriaCierre.SelectedValue
            End If
            'CAPTURA TIPIFICACION
            If drltipificacionll.SelectedIndex = 0 Then
                Throw New Exception("Seleccione la tipificación de la llamada (CIERRE DE LLAMADA - Tipificación Llamada)")
            Else
                objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            End If
            '------------------------------------------------------------'
            'USUARIO
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario

            'Validacion
            If lbl_estado.Text = "" Then
                objdatos.caso = txt_formato.Text
                objdatos.Validacion_caso_inbound()
                If objdatos.cantidad > 0 Then
                    Throw New Exception("El caso " & txt_formato.Text & " ya fue creado")
                End If
            End If
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
            '---------------------'         
            ''---------ESCALAMIENTOS----------''
            'ESCALAMIENTO CPD'
            If drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Then
                Registrar_CPD()
            End If
            'ESCALAMIENTO SD
            If drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD" Then
                Registrar_SD()
            End If
            If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar SD" And drltipificacionll.SelectedItem.Text <> "Solicitud Escalar CPD" Then
                Crear_caso()
            End If
            'REGISTRO CRMDETALLE
            objdatos.registro_CRM_inbound()
            'BANDEJA
            objdatos.actualiozar_Bandeja_inbound()
            'REGISTRO INC
            If drltipificacionll.SelectedItem.Text = "Rechazado" Then
                registro_inconsistencia_rechazado()
            End If
            'REGISTRO GESTION
            'El siguiente metodo para dejar en estado inicial todas las herramientas
            txtcaso.Text = txt_formato.Text
            'LIMPIA HERRAMIENTAS
            btn_buscar_Click(1, Nothing)
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Seguimiento ingresado con éxito para el caso " & txtcaso.Text & " "
        Catch ex As Exception
            If ex.Message.Contains("Infracción de la restricción UNIQUE KEY") Then
                Dim Exc As New Exception("El Caso " & txt_formato.Text & " ya fue creado")
                Obj_G_D.Val_Ex(Exc)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            Else
                Obj_G_D.Val_Ex(ex)
                Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
                lblmsg.Text = Obj_G_D.Ex("Message")
            End If
        End Try
    End Sub
    'Boton buscar
    Protected Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            If txtcaso.Text = Nothing Then
                Throw New Exception("Digite un caso para buscar")
            ElseIf Not IsNumeric(txtcaso.Text) Then
                Throw New Exception("El código del caso debe ser un número entero")
            End If
            Limpiar_Herramientas()
            Dim objdatos As New clscrmdatos
            objdatos.caso = txtcaso.Text
            ViewState("dtggeneral") = objdatos.Busca_Bandeja_Inbound().Tables(0)
            If ViewState("dtggeneral").Rows.Count > 0 Then
                dtggeneral.DataSource = ViewState("dtggeneral")
                dtggeneral.DataBind()
                Panel_consulta.Visible = True
                lbl_caso.Text = objdatos.idcrm
                lbl_estado.Text = objdatos.estadoinc
                lbl_min_alterno.Text = objdatos.Contacto_cliente
                lbl_fecha_ingreso.Text = objdatos.fcreg
                lbl_usuario_registra.Text = objdatos.idusuario
                txt_IDAVAYA.Text = objdatos.Caso_Claro
                txt_IDAVAYA.Enabled = False
                txt_min.Text = objdatos.min
                txt_min.Enabled = False
                txt_nombre.Text = objdatos.cliente
                txt_nombre.Enabled = False
                If objdatos.usuarioreporta <> "" And objdatos.usuarioreporta <> " " Then
                    txt_usu_reporta.Text = objdatos.usuarioreporta
                    txt_usu_reporta.Enabled = False
                End If
                If objdatos.Bandeja <> "" And objdatos.Bandeja <> " " Then
                    drlcampaña.SelectedValue = objdatos.Bandeja
                    drlcampaña.Enabled = False
                End If
                Panel_registro.Visible = True
                If TypeOf sender Is Button Then
                    If lbl_estado.Text.Contains("Cerrado") Or lbl_estado.Text.Contains("Rechazado") Then
                        btn_guardar.Visible = False
                        Btn_rechazar_inb.Visible = True
                        Throw New Exception("No puede realizar gestion sobre este caso ya que se encuentra cerrado o rechazado")
                    Else
                        btn_guardar.Visible = True
                        Btn_rechazar_inb.Visible = False
                    End If
                    txt_formato.Text = txtcaso.Text
                    txt_formato.Enabled = False
                    objdatos.Consulta_Diganostico_inbound()
                    'Condiciones de uso
                    If ObjDatos.tecnologia <> "" And ObjDatos.tecnologia <> "0" And ObjDatos.tecnologia <> " " Then
                        drlFtectolog.SelectedValue = ObjDatos.tecnologia
                        drlFtectolog.Enabled = False
                        Btn_Habilita_Tecnologia.Visible = True
                    End If
                    'Marca - Equipo
                    If ObjDatos.marca <> "" And ObjDatos.marca <> " " And ObjDatos.marca <> "0" Then
                        drlmarca.SelectedValue = ObjDatos.marca
                        drlmarca.Enabled = False
                        drlmarca_SelectedIndexChanged(1, Nothing)
                        drlequipo.SelectedValue = ObjDatos.equipo
                        drlequipo.Enabled = False
                        Btn_Habilita_Equipo.Visible = True
                    End If
                    'Departamento - Municipio
                    If ObjDatos.dpto <> "" And ObjDatos.dpto <> " " And ObjDatos.dpto <> "0" Then
                        drldpto.SelectedValue = ObjDatos.dpto
                        drldpto.Enabled = False
                        drldpto_SelectedIndexChanged(1, Nothing)
                        drlmun.SelectedValue = ObjDatos.mun
                        drlmun.Enabled = False
                        Btn_Habilita_Municipio.Visible = True
                    End If
                    'Barrio
                    If ObjDatos.barrio <> "" And ObjDatos.barrio <> " " Then
                        txtbarrio.Text = ObjDatos.barrio
                        txtbarrio.Enabled = False
                    End If
                    'Fecha ultima caida
                    If ObjDatos.fcultimac <> "" And ObjDatos.fcultimac <> "01/01/1900" Then
                        txtultimc.Text = ObjDatos.fcultimac
                        txtultimc.Enabled = False
                    End If
                    'Franja ultima caida
                    If ObjDatos.franjaultimac <> "" And ObjDatos.franjaultimac <> " " Then
                        drlfranja.SelectedValue = ObjDatos.franjaultimac
                        drlfranja.Enabled = False
                        Btn_Habilita_Fc_Utl_Caida.Visible = True
                    End If
                    'Tipo PQR
                    If ObjDatos.Tipo_PQR <> "" And ObjDatos.Tipo_PQR <> " " Then
                        drlTipo_PQR.SelectedValue = ObjDatos.Tipo_PQR
                        drlTipo_PQR.Enabled = False
                    End If
                    'Modalidad
                    If ObjDatos.Modalidad <> "" And ObjDatos.Modalidad <> " " Then
                        drlModalidad.SelectedValue = ObjDatos.Modalidad
                        drlModalidad.Enabled = False
                    End If
                    'PQR
                    If ObjDatos.pqr <> "" And ObjDatos.pqr <> " " Then
                        TxtPQR.Text = Mid(ObjDatos.pqr, 10, 7)
                        TxtPQR.Enabled = False
                        Btn_Habilita_PQR.Visible = True
                    End If
                End If
            Else
                Throw New Exception("No se encontraron registros")
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
    'BTN rechazar
    Protected Sub Btn_rechazar_inb_Click(sender As Object, e As EventArgs) Handles Btn_rechazar_inb.Click
        Try
            'GENERAL
            txtultimc.Enabled = False
            drlfranja.Enabled = False
            drlcampaña.SelectedIndex = 1
            drlcampaña.Enabled = False
            CHKSD.Enabled = False
            Drl_Falla.Enabled = False
            'CASO RECHAZADO
            Panel_Rechazado.Visible = True
            drl_nivel.SelectedValue = "Call"
            drl_tipificacion_recha.SelectedIndex = 1
            drl_tipificacion_recha_SelectedIndexChanged(1, Nothing)
            drl_inconsistencia_recha.SelectedIndex = 2
            'DIAGNOSTICO
            drlModalidad.Enabled = False
            drllinea.SelectedValue = "Otros"
            drllinea.Enabled = False
            drllinea_SelectedIndexChanged(1, Nothing)
            drlservicio2.SelectedValue = 27
            drlservicio2.Enabled = False
            drlservicio2_SelectedIndexChanged(1, Nothing)
            drlsolicitud.SelectedValue = 29
            drlsolicitud.Enabled = False
            drlsolicitud_SelectedIndexChanged(1, Nothing)
            drlSegmento.SelectedValue = "Otr_Error en procedimiento"
            drlSegmento.Enabled = False
            drlSegmento_SelectedIndexChanged(1, Nothing)
            drlCausa_Raiz.SelectedValue = 128
            drlCausa_Raiz.Enabled = False
            drlCausa_Raiz_SelectedIndexChanged(1, Nothing)
            'CIERRE LLAMADA
            drltipificacionll.SelectedValue = 250
            drltipificacionll_SelectedIndexChanged(1, Nothing)
            drlCategoriaCierre.SelectedValue = 1014
            drlCategoriaCierre.Enabled = False
            drltipificacionll.Items.Insert(1, "Rechazado")
            drltipificacionll.SelectedIndex = 1
            drltipificacionll.Enabled = False
            'ENCUESTA
            drlinconsistencia.Enabled = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'BTN guarda inconsistencia
    Protected Sub btn_guarda_inc_Click(sender As Object, e As EventArgs) Handles btn_guarda_inc.Click
        Try
            ''''Consulta si ya existe algun registro para evitar conflicto con PK- © CDRR.
            Dim ObjDataCons As New clscrmdatos
            ObjDataCons.Validacion = "Inconsistencia"
            ObjDataCons.caso = txt_formato.Text
            ObjDataCons.Consulta_Registro_Falla_Red_Incinsistencia_Otro()
            If ObjDataCons.cantidad > 0 Then
                Throw New Exception("El Caso Claro: " + txt_formato.Text + " ya tiene un registro de inconsistencai")
            End If
            If drlincons.SelectedIndex = 0 Then
                Throw New Exception("Elija el tipo de inconsistencia a reportar")
            End If
            If txtobsinc.Text = "" Then
                Throw New Exception("Digite la observación de la inconsistencia")
            End If
            If Txt_custcode.Text = "" Then
                Throw New Exception("Es obligatorio llenar Custcode ")
            End If
            If Txt_usuario_reporta.Text = "" Then
                Throw New Exception("Digite el usuario reporta de la inconsistencia")
            End If
            If drl_ubicacion_call.SelectedIndex = 0 Then
                Throw New Exception("Seleccione ubicacion de call center")
            End If
            If drlnivel.SelectedIndex = 0 Then
                Throw New Exception("Elija el nivel que genera la inconsistencia, verifique")
            End If
            Dim objdatos As New clscrmdatos
            objdatos.incidente = drlincons.SelectedItem.Value
            objdatos.obs = txtobsinc.Text
            objdatos.custcode = Txt_custcode.Text
            objdatos.usuarioreporta = Txt_usuario_reporta.Text
            objdatos.lugar = drl_ubicacion_call.SelectedValue
            objdatos.barrio = drlnivel.SelectedItem.Value
            objdatos.caso = txt_formato.Text
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.estadoinc = "Aprobado"
            objdatos.registroinc()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Inconsistencia reportada con exito"
            drlincons.SelectedIndex = 0
            drlinconsglobal.SelectedIndex = 0
            txtobsinc.Text = Nothing
            Txt_custcode.Text = Nothing
            Txt_usuario_reporta.Text = Nothing
            Panel_inconsistencia.Visible = False
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
    'Mostrar panel inconsistencia
    Protected Sub LinkButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton3.Click
        Try
            If txt_formato.Text = "" Then
                Throw New Exception("Consulte el caso antes de generar una inconsistencia")
            Else
                Dim objdatos As New clscrmdatos
                objdatos.caso = txt_formato.Text
                If objdatos.Consultar_Inconsistencia().Tables(0).Rows.Count > 0 Then
                    Throw New Exception("El caso  " + objdatos.caso + "  ya tiene reportada una inconsistencia")
                End If
                'Dim ObjGeneral As New clsgeneral
                'ubicacion call
                Panel_inconsistencia.Visible = True
                LinkButton4.Visible = True
                LinkButton3.Visible = False
            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'Ocultar panel inconsistencia
    Protected Sub LinkButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton4.Click
        Try
            LinkButton3.Visible = True
            LinkButton4.Visible = False
            Panel_inconsistencia.Visible = False
            lblmsg.Text = ""
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'Btm Llamada corta
    Protected Sub Btn_Llamada_Corta_Click(sender As Object, e As EventArgs) Handles Btn_Llamada_Corta.Click
        Try
            'Dim ObjGeneral As New clsgeneral
            Pnl_Llamada_Corta.Visible = True
            'Panel_rechazados.Visible = False
            Panel_registro.Visible = False
            Panel_inconsistencia.Visible = False
            Panel_consulta.Visible = False
            PanelCasos.Visible = False
            Panel_Service.Visible = False
            Panel_Falla_red.Visible = False
            LinkButton4.Visible = False
            LinkButton3.Visible = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    'Btn Guardar llamada corta
    Protected Sub Btn_Guardar_Ll_Co_Click(sender As Object, e As EventArgs) Handles Btn_Guardar_Ll_Co.Click
        Try
            Dim Objdatos As New clscrmdatos
            Objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            'ID AVAYA
            If Txt_Id_Avaya_Ll_Co.Text = "" Then
                Throw New Exception("Digite Id de AVAYA")
            End If
            'CASO
            If Txt_Caso_ll_co.Text = "" And Drl_Tipo_llamada_ll_co.SelectedItem.Text = "Formato Kamilion" Then
                Throw New Exception("Digite el Caso")
            End If
            'TIPO DE LLAMADA
            If Drl_Tipo_llamada_ll_co.SelectedIndex = 0 Then
                Throw New Exception("Seleccione ubicacion Call Center")
            End If
            'UBICACION CALL CENTER
            If drl_ubicacion_call_ll_co.SelectedIndex = 0 Then
                Throw New Exception("Seleccione ubicacion Call Center")
            End If
            ''OBSERVACION
            If Txt_Obs_Ll_Co.Text = "" Then
                Throw New Exception("Digite una observacion")
            End If
            Objdatos.idcrm = Txt_Id_Avaya_Ll_Co.Text
            Objdatos.caso = Txt_Caso_ll_co.Text
            Objdatos.tipofalla = Drl_Tipo_llamada_ll_co.SelectedItem.Text
            Objdatos.lugar = drl_ubicacion_call_ll_co.SelectedItem.Text
            Objdatos.obs = Txt_Obs_Ll_Co.Text
            Objdatos.Reg_Llamada_Corta_Inb()
            drl_ubicacion_call_ll_co.SelectedIndex = 0
            Drl_Tipo_llamada_ll_co.SelectedIndex = 0
            Txt_Obs_Ll_Co.Text = Nothing
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Se registro la llamada corta con el ID AVAYA " & Txt_Id_Avaya_Ll_Co.Text
            Txt_Id_Avaya_Ll_Co.Text = Nothing
            Txt_Caso_ll_co.Text = Nothing
            Pnl_Txt_Caso_ll_co.Visible = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub

    'BTN equipo
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
    'BTN ultima caida
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
    'condiciones de uso
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
    'BTN PQR
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
    'BTN MUNICIPIO
    Protected Sub Btn_Habilita_Municipio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Habilita_Municipio.Click
        Try
            drldpto.Enabled = True
            drlmun.Enabled = True
            txtbarrio.Enabled = True
            Btn_Habilita_Municipio.Visible = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
#End Region
#Region "Rb_CheckedChange"
    'numero alterno
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
    'CHK Falla sgsc
    Protected Sub CHKSD_CheckedChanged(sender As Object, e As EventArgs) Handles CHKSD.CheckedChanged
        Try
            If CHKSD.Checked = True Then
                txt_SD.Enabled = True
                lbl_formato.Text = "CUN o MIN"
            Else
                txt_SD.Enabled = False
                txt_SD.Text = ""
                lbl_formato.Text = "Caso"

            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
#End Region
#Region "Drl's"
    'carga drls
    Protected Sub Cargar_drl()
        Try
            If Not IsPostBack Then
                '--------inconsistencia encuesta 611---------'
                With drlinconsistencia
                    .DataSource = Obj_General.Consulta_inconsistencia_encuesta
                    .DataTextField = "Nombre"
                    .DataValueField = "Cod_BD_Datos_Complemento"
                    .DataBind()
                    .Items.RemoveAt(1)
                    drlinconsistencia = Obj_G_D.Gest_Drl(drlinconsistencia)
                End With
                'Inconsistencia Global- tipificacion
                Obj_General.cargo = "Global"
                With drlinconsglobal
                    .DataSource = Obj_General.consultaincdatos
                    .DataTextField = "inconsistencia"
                    .DataValueField = "idtipoinc"
                    .DataBind()
                    drlinconsglobal = Obj_G_D.Gest_Drl(drlinconsglobal)
                End With
                Obj_General.Validacion = "linea_serv"
                With drllinea
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Diagnostico2
                    .DataTextField = "tipificacion1"
                    .DataValueField = "tipificacion1"
                    .DataBind()
                    drllinea = Obj_G_D.Gest_Drl(drllinea)
                End With
                'divipola - dpto - REGISTRO CRM
                With drldpto
                    'Obj_General.idtip = 1
                    .DataSource = Obj_General.consultadpto
                    .DataTextField = "nombredpto"
                    .DataValueField = "coddpto"
                    .DataBind()
                    drldpto = Obj_G_D.Gest_Drl(drldpto)
                End With
                'Condiciones de uso
                With drlFtectolog
                    Obj_General.idusuario = 4
                    .DataSource = Obj_General.consultadiagnostico
                    .DataTextField = "detalle"
                    .DataValueField = "idreg"
                    .DataBind()
                    drlFtectolog = Obj_G_D.Gest_Drl(drlFtectolog)
                End With
                'Error en registro
                With drlvariable
                    Obj_General.idusuario = 6
                    .DataSource = Obj_General.consultadiagnostico
                    .DataTextField = "detalle"
                    .DataValueField = "idreg"
                    .DataBind()
                    drlvariable = Obj_G_D.Gest_Drl(drlvariable)
                End With
                'marca
                With drlmarca
                    .DataSource = Obj_General.consultamarca
                    .DataTextField = "marca"
                    .DataValueField = "marca"
                    .DataBind()
                    drlmarca = Obj_G_D.Gest_Drl(drlmarca)
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
                'Justificacion Seguimiento
                Obj_General.Validacion = "Justificacion"
                With Drl_justificacion_seguimiento
                    .DataSource = Obj_General.consulta_campaña_inb
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_justificacion_seguimiento = Obj_G_D.Gest_Drl(Drl_justificacion_seguimiento)
                End With
                'Falla Masiva
                With Drl_Falla
                    Obj_General.Validacion = "Falla_Masiva"
                    .DataSource = Obj_General.consulta_campaña_inb
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Obj_G_D.Gest_Drl(Drl_Falla)
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
                ''Campaña
                With drlcampaña
                    .DataSource = Obj_General.consulta_campaña_inb
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    drlcampaña = Obj_G_D.Gest_Drl(drlcampaña)
                End With
                '____________rechazar__________________
                'Inconsistencia Global- tipificacion
                Obj_General.cargo = "Global"
                With drl_tipificacion_recha
                    .DataSource = Obj_General.consultaincdatos
                    .DataTextField = "inconsistencia"
                    .DataValueField = "idtipoinc"
                    .DataBind()
                    Obj_G_D.Gest_Drl(drl_tipificacion_recha)
                End With
                'Tipo Inconsistencia 
                Obj_General.cargo = "Global2"
                Obj_General.estado = drl_tipificacion_recha.Text
                With drl_inconsistencia_recha
                    .DataSource = Obj_General.consultaincdatos
                    .DataTextField = "inconsistencia"
                    .DataValueField = "idtipoinc"
                    .DataBind()
                    Obj_G_D.Gest_Drl(drl_inconsistencia_recha)
                End With
                'ubicacion call
                Obj_General.Validacion = "Ubicacion_call2"
                With drl_UbicacionCall
                    .DataSource = Obj_General.consulta_campaña_inb
                    .DataTextField = "nombre"
                    .DataValueField = "valor"
                    .DataBind()
                    Obj_G_D.Gest_Drl(drl_UbicacionCall)
                End With
                '-------------------falla red----------------
                'caracteristicas falla
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
                '-------------llamada corta------------------
                Obj_General.Validacion = "Ubicacion_call2"
                With drl_ubicacion_call_ll_co
                    .DataSource = Obj_General.consulta_campaña_inb
                    .DataTextField = "nombre"
                    .DataValueField = "valor"
                    .DataBind()
                    '.Items.Insert(0, "- Seleccione -")
                    drl_ubicacion_call_ll_co = Obj_G_D.Gest_Drl(drl_ubicacion_call_ll_co)
                End With

                Obj_General.Validacion = "Tipo_Llamada"
                With Drl_Tipo_llamada_ll_co
                    .DataSource = Obj_General.consulta_campaña_inb
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_Tipo_llamada_ll_co = Obj_G_D.Gest_Drl(Drl_Tipo_llamada_ll_co)
                End With
                '-----------------inconsistencia-------------
                Obj_General.Validacion = "Ubicacion_call2"
                With drl_ubicacion_call
                    .DataSource = Obj_General.consulta_campaña_inb
                    .DataTextField = "nombre"
                    .DataValueField = "valor"
                    .DataBind()
                    drl_ubicacion_call = Obj_G_D.Gest_Drl(drl_ubicacion_call)
                End With
                '------------------SD------------------------
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

                Drl_Linea_No_Cuenta_Bloqueos_Internet = Obj_G_D.Gest_Drl(Drl_Linea_No_Cuenta_Bloqueos_Internet)
                Drl_Linea_No_Encuentra_Enrutada_PorPagos = Obj_G_D.Gest_Drl(Drl_Linea_No_Encuentra_Enrutada_PorPagos)
                Drl_Equipo_Encuentra_Homologado_Operador = Obj_G_D.Gest_Drl(Drl_Equipo_Encuentra_Homologado_Operador)
                Drl_Linea_No_Superado_Limite_Consumos = Obj_G_D.Gest_Drl(Drl_Linea_No_Superado_Limite_Consumos)
                Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = Obj_G_D.Gest_Drl(Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla)
                Drl_Realiza_Conciliacion_Sobre_linea = Obj_G_D.Gest_Drl(Drl_Realiza_Conciliacion_Sobre_linea)
            Else
                drlinconsistencia.SelectedIndex = 0
                drlinconsglobal.SelectedIndex = 0
                drllinea.SelectedIndex = 0
                drldpto.SelectedIndex = 0
                drlFtectolog.SelectedIndex = 0
                drlvariable.SelectedIndex = 0
                drlmarca.SelectedIndex = 0
                drlTipo_PQR.SelectedIndex = 0
                Drl_justificacion_seguimiento.SelectedIndex = 0
                Drl_Falla.SelectedIndex = 0
                drlModalidad.SelectedIndex = 0
                drlcampaña.SelectedIndex = 0
                drl_tipificacion_recha.SelectedIndex = 0
                drl_inconsistencia_recha.SelectedIndex = 0
                drl_UbicacionCall.SelectedIndex = 0
                drlFcaract.SelectedIndex = 0
                Drl_Tipo_Edificacion_Donde_Presenta_Falla_1.SelectedIndex = 0
                Drl_Tipo_Edificacion_Donde_Presenta_Falla_2.SelectedIndex = 0
                Drl_Tecnologia_Presenta_Falla_Luegodepruebas.SelectedIndex = 0
                Drl_Split_Billing.SelectedIndex = 0
                Drl_HLR_HSS.SelectedIndex = 0
                Drl_Forza_Red_Dispositivo.SelectedIndex = 0
                Drl_Verifica_Realiza_Configuración_APN.SelectedIndex = 0
                Drl_Qos.SelectedIndex = 0
                drl_ubicacion_call_ll_co.SelectedIndex = 0
                Drl_Tipo_llamada_ll_co.SelectedIndex = 0
                drl_ubicacion_call.SelectedIndex = 0
                drlapn.SelectedIndex = 0
                drlqos.SelectedIndex = 0
                'enbebidos en el html
                Drl_Linea_No_Cuenta_Bloqueos_Internet.SelectedIndex = 0
                Drl_Linea_No_Encuentra_Enrutada_PorPagos.SelectedIndex = 0
                Drl_Equipo_Encuentra_Homologado_Operador.SelectedIndex = 0
                Drl_Linea_No_Superado_Limite_Consumos.SelectedIndex = 0
                Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla.SelectedIndex = 0
                Drl_Realiza_Conciliacion_Sobre_linea.SelectedIndex = 0
            End If
            drlinconsglobal_SelectedIndexChanged(1, Nothing)
            drllinea_SelectedIndexChanged(1, Nothing)
            drldpto_SelectedIndexChanged(1, Nothing)
            drlmarca_SelectedIndexChanged(1, Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'drl departamento registro CRM
    Protected Sub drldpto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drldpto.SelectedIndexChanged
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
    'linea
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
    'servicio
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
    'solicitud / tipo falla
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
    'segmento
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
    'causa raiz
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
    'tipificacion estado
    Protected Sub drltipificacionll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drltipificacionll.SelectedIndexChanged
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
            If drltipificacionll.SelectedItem.Text.Contains("CPD") Then
                Panel_Falla_red.Visible = True
                Panel_inconsistencia.Visible = False
                LinkButton3.Visible = True
                LinkButton4.Visible = False
                Panel_Service.Visible = False
                Panel_seguimiento.Visible = False
                txtFcontacto.Text = txt_nombre.Text
                txtFnum.Text = txtnumalt.Text
                ''SERVICE
            ElseIf drltipificacionll.SelectedItem.Text.Contains("SD") Then
                Panel_Service.Visible = True
                Panel_inconsistencia.Visible = False
                Panel_Falla_red.Visible = False
                LinkButton3.Visible = True
                LinkButton4.Visible = False
                Panel_seguimiento.Visible = False
            ElseIf drltipificacionll.SelectedItem.Text.Contains("Programado") Then
                Panel_Falla_red.Visible = False
                Panel_inconsistencia.Visible = False
                LinkButton3.Visible = True
                LinkButton4.Visible = False
                Panel_Service.Visible = False
                Panel_seguimiento.Visible = True
            Else
                Panel_Service.Visible = False
                Panel_inconsistencia.Visible = False
                Panel_Falla_red.Visible = False
                LinkButton3.Visible = True
                LinkButton4.Visible = False
                Panel_seguimiento.Visible = False
            End If
            If drltipificacionll.SelectedItem.Text = "Cerrado" And lbl_estado.Text = "" Then
                TxtPQR.Enabled = False
                TxtPQR.Text = ""
                drlTipo_PQR.SelectedIndex = 0
                drlTipo_PQR.Enabled = False
            ElseIf drltipificacionll.SelectedItem.Text <> "Cerrado" And lbl_estado.Text = "" Then
                TxtPQR.Enabled = True
                drlTipo_PQR.Enabled = True
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
    'marca > equipo
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
    'error en registro
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
    'inconsistencia service
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
    'inconsistencia recha
    Protected Sub drl_tipificacion_recha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drl_tipificacion_recha.SelectedIndexChanged
        Try
            With drl_inconsistencia_recha
                If drl_tipificacion_recha.SelectedIndex > 0 Then
                    Obj_General.cargo = "Inconsistencia"
                    Obj_General.estado = drl_tipificacion_recha.SelectedItem.Value
                    .DataSource = Obj_General.consultaincdatos
                    .DataTextField = "inconsistencia"
                    .DataValueField = "idtipoinc"
                    .DataBind()
                Else
                    .Items.Clear()
                End If
                drl_inconsistencia_recha = Obj_G_D.Gest_Drl(drl_inconsistencia_recha)
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
    'Inconsistencia
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
    'No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra
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
    Protected Sub Drl_Tipo_llamada_ll_co_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Tipo_llamada_ll_co.SelectedIndexChanged
        Try
            If Drl_Tipo_llamada_ll_co.SelectedItem.Text = "Formato Kamilion" Then
                Pnl_Txt_Caso_ll_co.Visible = True
            Else
                Pnl_Txt_Caso_ll_co.Visible = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


#End Region
#Region "Dtg's"
    'dtgasignados
    Protected Sub Dtg_Asignados_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Dtg_Asignados.PageIndexChanging
        Try
            Dtg_Asignados.PageIndex = e.NewPageIndex
            Dtg_Asignados.DataSource = ViewState("Dtg_Asignados")
            Dtg_Asignados.DataBind()
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
#End Region
End Class