Public Class Dilo2
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
            'Obj_G_D.Val_Session("CRM")
            If Not IsPostBack Then
                Limpiar_Herramientas()
                Session("Formulario") = "Registro CRM Dilo"
                Dim objdatos As New clsgeneral
                objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                Consultar_Asignados()
                Lbl_Title.Text = "Error en Registro"
                LblPQR.Text = objdatos.Consulta_Numero_PQR().Tables(0).Rows(0).Item("Nombre")
            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub Registrar_Diagnostico()
        Try
            Dim objdatos As New clscrmdatos
            If drlTipo_PQR.SelectedIndex > 0 Or drlModalidad.SelectedIndex > 0 Or drlCausa_Raiz.SelectedIndex > 0 Or drlCategoriaCierre.SelectedIndex > 0 Or drlsolicitud.SelectedIndex = 0 Then
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
                'CAUSA RAIZ
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
                If drlmun.SelectedIndex = 0 Then
                    objdatos.mun = "0"
                Else
                    objdatos.mun = drlmun.SelectedItem.Value
                End If
                If drlsolicitud.SelectedIndex = 0 Then
                    objdatos.solicitud = "0"
                Else
                    objdatos.solicitud = drlsolicitud.SelectedItem.Value
                End If
                If drlservicio2.SelectedIndex = 0 Then
                    objdatos.servreest = ""
                Else
                    objdatos.servreest = drlservicio2.SelectedItem.Value
                End If
                If drlvariable.SelectedIndex = 0 Then
                    objdatos.diagvariable = "0"
                Else
                    objdatos.diagvariable = drlvariable.SelectedValue
                End If
                objdatos.inconsistencia_encuesta = ""
                objdatos.tipofalla = ""
                objdatos.reclamoppal = ""
                objdatos.Validacion = "Diagnostico Dilo y Fidelizacion"
                objdatos.Bandeja = "Dilo"
                objdatos.caso = lblcaso.Text
                objdatos.registrodiag()
                txtbarrio.Text = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub Consultar_Asignados()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.Validacion = "Asignados"
            ViewState("dtgprog") = objdatos.Consulta_Asignado_Dilo.Tables(0)
            If ViewState("dtgprog").Rows.Count > 0 Then
                dtgprog.DataSource = ViewState("dtgprog")
            Else
                dtgprog.DataSource = Nothing
            End If
            dtgprog.DataBind()
            lblcasos_asig.Text = ViewState("dtgprog").Rows.Count()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub Consulta_Municipio_Distrubuidores()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.caso = txtcaso.Text
            objdatos.Consulta_Municipio_Distribuidores()
            If objdatos.dpto <> " " Then
                drldpto_incon.SelectedValue = objdatos.dpto
                drldpto_incon_SelectedIndexChanged(1, Nothing)
                drldpto_incon.Enabled = False
            Else
                drldpto_incon.SelectedIndex = 0
                drldpto_incon_SelectedIndexChanged(1, Nothing)
                drldpto_incon.Enabled = True
            End If
            If objdatos.mun <> " " Then
                drlmun_incon.SelectedValue = objdatos.mun
                drlmun_incon.Enabled = False
            Else
                drlmun_incon.SelectedIndex = 0
                drlmun_incon.Enabled = True
            End If
            If objdatos.dpto <> " " And objdatos.mun <> " " Then
                Btn_Actualizar_Mun_Distri.Visible = True
            Else
                Btn_Actualizar_Mun_Distri.Visible = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub Actualizar_Bandeja()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                Throw New Exception("Digite el caso que desea registrar")
            Else
                objdatos.caso = txtcaso.Text
            End If
            If drltipificacionll.SelectedIndex > 0 Then
                objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            End If
            If drltipificacionll.SelectedItem.Text.Contains("CPD") Then
                If drl_tipo_canal.SelectedIndex > 0 Then
                    objdatos.Tipo_Canal = drl_tipo_canal.SelectedItem.Text
                Else
                    objdatos.Tipo_Canal = ""
                End If
                If txt_Estacion_base.Text <> "" Then
                    objdatos.Estacion_base = txt_Estacion_base.Text
                Else
                    objdatos.Estacion_base = ""
                End If
            Else
                objdatos.Tipo_Canal = ""
                objdatos.Estacion_base = ""
            End If
            If drlmun_incon.SelectedIndex > 0 Then
                objdatos.lugar = drlmun_incon.SelectedValue
            Else
                objdatos.lugar = ""
            End If
            If Txt_Distribuidor.Text <> "" Then
                objdatos.preg3 = Txt_Distribuidor.Text
            Else
                objdatos.preg3 = ""
            End If
            objdatos.modificarbandejadilo()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub Registrar_CRM()
        Dim objdatos As New clsvoz
        Try
            objdatos.caso = txtcaso.Text
            If txtobs.Text = "" Then
                objdatos.obs = ""
            Else
                objdatos.obs = txtobs.Text
            End If
            objdatos.tipificacion = "Creado"
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.registrocrmfallareddilo()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Seguimiento ingresado con éxito"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub Escalar_SD()
        Try
            Dim objdatos As New clscrmdatos
            If lblcaso.Text = "" Then
                Throw New Exception("Consulte el caso antes de realizar escalamiento a Service")
            End If
            If txtobs.Text = "" Then
                Throw New Exception("Digite una descripción del escalamiento antes de dar clic en el link")
            End If
            If lblescalamiento.Text = "Falla de red" Then
                Throw New Exception("Ya se encuentra una falla de red registrada con este caso")
            End If
            If drlvariable.SelectedIndex = 0 Then
                Throw New Exception("Elija la variable de diagnóstico antes de realizar escalamiento a Service")
            End If
            If drlapn.SelectedIndex = 0 Then
                Throw New Exception("Elija el APN del caso")
            End If
            If drlqos.SelectedIndex = 0 Then
                Throw New Exception("Seleccione el QoS del caso")
            End If
            If txtfcactivacion.Text = "" Then
                Throw New Exception("Digite la fecha de activación del servicio")
            End If
            If Not FileDocumento.PostedFile Is Nothing Then
                If Not FileDocumento.PostedFile Is Nothing And FileDocumento.PostedFile.ContentLength > 0 Then
                    Dim Name As String = System.IO.Path.GetExtension(FileDocumento.PostedFile.FileName)
                    FileDocumento.PostedFile.SaveAs(Server.MapPath("data_Doc") & "\\" & lblcaso.Text + Name)
                    objdatos.archivo = lblcaso.Text + Name
                Else
                    Throw New Exception("Adjunte un archivo")
                End If
            Else
                Throw New Exception("Adjunte un archivo")
            End If
            objdatos.apn = drlapn.SelectedItem.Text
            objdatos.qos = drlqos.SelectedItem.Text
            objdatos.fcini = txtfcactivacion.Text
            objdatos.caso = lblcaso.Text
            objdatos.diagvariable = drlvariable.SelectedItem.Value
            objdatos.obs = txtobs.Text
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.Registroservice()
            Registrar_CRM()
            lblescalamiento.Text = "Escalamiento"
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Escalamiento Service realizado con éxito"
            '--Escalamiento--'
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub Escalar_CPD()
        Try
            If drlmun.SelectedIndex = 0 Then
                Throw New Exception("Elija el municipio antes de generar una falla de red")
            End If
            If txtbarrio.Text = "" Then
                Throw New Exception("Digite el barrio antes de generar una falla de red")
            End If
            If txtFcontacto.Text = "" Then
                Throw New Exception("Digite la persona de contacto")
            End If
            If Txt_N_Doc_Id_CPD.Text = Nothing Then
                Throw New Exception("Ingrese el número de documento de identidad de la persona que reporta")
            ElseIf Not IsNumeric(Txt_N_Doc_Id_CPD.Text) Then
                Throw New Exception("El número de documento de identidad de la persona que reporta debe estar compuesto solo por números")
            End If
            If lblcaso.Text = Nothing Then
                Throw New Exception("Antes de crear una falla de red de clic en el botón buscar para verificar que el caso es válido")
            End If
            If drlequipo.SelectedIndex = 0 Then
                Throw New Exception("Elija la marca y el equipo actual antes de generar una falla de red")
            End If
            If txtFnum.Text = Nothing Then
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
            If drlequipo.SelectedIndex = 0 Then
                Throw New Exception("Elija el equipo actual antes de generar una falla de red")
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
            If DrlCanalDilo.SelectedIndex = 0 Then
                Throw New Exception("Seleccione el canal de ingreso")
            End If
            If txtFdirecc.Text = "" Then
                Throw New Exception("Digite la dirección donde se presenta la falla")
            End If
            If txtbarrio.Text = "" Then
                Throw New Exception("Digite el barrio donde se presenta la falla")
            End If
            ''''''''''Servicio CLiente''''''''''''''''''''''''
            If drlFtectolog.SelectedIndex = 0 Then
                Throw New Exception("Elija la tecnología del equipo que presenta la falla")
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
            Dim objvoz As New clsvoz
            If txtFtipofalla.Text = "" Then
                objvoz.tipofalla = ""
            Else
                objvoz.tipofalla = txtFtipofalla.Text
            End If
            If txtFciudad.Text = "" Then
                objvoz.vereda = ""
            Else
                If rdbvc.selectedvalue = Nothing And txtFciudad.Text <> Nothing Then
                    Throw New Exception("Elija si el lugar corresponde a un corregimiento, Vereda o Inspección")
                End If
                objvoz.vereda = rdbvc.SelectedItem.Value & " " & txtFciudad.Text
            End If
            objvoz.N_Doc_Id = Txt_N_Doc_Id_CPD.Text
            objvoz.barrio = txtbarrio.Text
            objvoz.cliente = txtFcontacto.Text
            objvoz.telcontacto = txtFnum.Text
            objvoz.tiempo = drlFtiempo.SelectedItem.Value
            objvoz.caracter = drlFcaract.SelectedItem.Text
            objvoz.portada = drlFportada.SelectedItem.Value
            objvoz.mun = drlmun.SelectedItem.Value
            objvoz.dir = txtFdirecc.Text
            objvoz.tecnologia = drlFtectolog.SelectedItem.Text
            objvoz.equipo = drlequipo.SelectedItem.Value
            objvoz.maslineas = drlFlineasfalla.SelectedItem.Value
            objvoz.obs = txtfobs.Text
            objvoz.apn = txtapn.Text
            objvoz.qos = Drl_Qos.SelectedItem.Text
            objvoz.CanalDilo = DrlCanalDilo.Text

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

            objvoz.campana = "Datos"
            objvoz.caso = lblcaso.Text
            objvoz.idusuario = CType(Session("permisos"), clsusuario).usuario
            objvoz.fcini = Lblfc_ingreso.Text
            objvoz.registrofallasred()
            Registrar_CRM()
            'limpiar
            lblescalamiento.Text = "Falla de red"
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
            btnguardar.Visible = False
            'limpiar
            lblbarrio.Text = Nothing
            lblmesa.Text = Nothing
            lbltelcontacto.Text = Nothing
            lblcliente.Text = Nothing
            lblfcreporte.Text = Nothing
            lbltecnologia.Text = Nothing
            lblequipo.Text = Nothing
            lbltipofalla.Text = Nothing
            lblmin.Text = Nothing
            lblsolicitud.Text = Nothing
            lblestado.Text = Nothing
            txtbarrio.Text = Nothing
            txtobs.Text = Nothing
            lblNumero_Alterno.Text = Nothing
            txtnumalt.Enabled = False
            chkSi.Checked = False
            chkNo.Checked = False
            lblcaso.Text = Nothing
            Lblfc_ingreso.Text = Nothing
            TxtPQR.Text = Nothing
            lblescalamiento.Text = Nothing
            drlmun.Enabled = True
            drlequipo.Enabled = True
            drlmarca.Enabled = True
            drldpto.Enabled = True
            Btn_Act_Barrio.Visible = False
            Btn_Act_Mun.Visible = False
            Btn_Act_PQR.Visible = False
            TxtPQR.Enabled = True
            drlTipo_PQR.Enabled = True
            drlModalidad.Enabled = True
            lbl_canal.Text = Nothing
            Panel_Justificacion.Visible = False
            Txt_Distribuidor.Enabled = True
            Txt_Distribuidor.Text = Nothing
            'SD
            txtfcactivacion.Text = Nothing
            pnservice.Visible = False
            'CPD
            Txt_N_Doc_Id_CPD.Text = Nothing
            Pninc.Visible = False
            PNEscalam.Visible = False
            txtfobs.Text = Nothing
            txtFdirecc.Text = Nothing
            txtFciudad.Text = Nothing
            txtFtipofalla.Text = Nothing
            txtFcontacto.Text = Nothing
            txtFnum.Text = Nothing
            txtapn.Text = Nothing
            ''''''''''''''''''''ServicioCliente''''''''''''''''''''''
            Txt_Validacion_Coordenadas.Text = Nothing
            If drl_tipo_canal.Items.Count > 0 Then
                drl_tipo_canal.SelectedIndex = 0
            End If
            Cargar_Drls()
            Consultar_Asignados()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#Region "Btn's"
    Protected Sub Btn_Consultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Consultar.Click
        Try
            If txtcaso.Text = Nothing Then
                Throw New Exception("Digite el Caso o Min que desea consultar")
            ElseIf Not IsNumeric(txtcaso.Text) Then
                Throw New Exception("El código del caso debe estar compuesto por un número entero")
            End If
            Limpiar_Herramientas()
            Dim objdatos As New clscrmdatos
            objdatos.caso = txtcaso.Text
            ViewState("dtggeneral") = objdatos.consultadilo.Tables(0)
            If ViewState("dtggeneral").Rows.Count > 0 Then
                dtggeneral.DataSource = ViewState("dtggeneral")
                dtggeneral.DataBind()
                lblcuenta.Text = dtggeneral.Rows.Count
                lblfcreporte.Text = objdatos.fcreg
                lblmin.Text = objdatos.min
                lbltelcontacto.Text = objdatos.telcontacto
                lblcliente.Text = objdatos.cliente
                lblequipo.Text = objdatos.equipo
                lbltecnologia.Text = objdatos.tecnologia
                lbltipofalla.Text = objdatos.tiposoporte
                lblestado.Text = objdatos.tipificacion
                lblmesa.Text = objdatos.mesa
                lblsolicitud.Text = objdatos.obsini
                lblbarrio.Text = objdatos.barrio
                lblNumero_Alterno.Text = objdatos.telalt
                lblcaso.Text = objdatos.caso
                Lblfc_ingreso.Text = objdatos.casfcregistro
                lbl_canal.Text = objdatos.Bandeja
                If objdatos.preg3 <> " " Then
                    Txt_Distribuidor.Text = objdatos.preg3
                    Txt_Distribuidor.Enabled = False
                    Btn_Actualizar_Distribuidor.Visible = True
                End If
                If TypeOf sender Is Button Then
                    If lblestado.Text.Contains("Cerrado") Or lblestado.Text.Contains("Escala") Then
                        btnguardar.Visible = False
                        Throw New Exception("No puede realizar gestion sobre este caso ya que se encuentra Cerrado, Escalado o Solicitud Escalar")
                    Else
                        btnguardar.Visible = True
                    End If
                    objdatos.Validacion = "DILO"
                    objdatos.Consulta_Diganostico_Carga_Fidelizacion_y_Dilo()
                    objdatos.Validacion = ""
                    If objdatos.Tipo_PQR <> "" Then
                        drlTipo_PQR.SelectedValue = objdatos.Tipo_PQR
                        drlTipo_PQR.Enabled = False
                    End If
                    If objdatos.pqr <> "" Then
                        TxtPQR.Text = Mid(objdatos.pqr, 10, 7)
                        TxtPQR.Enabled = False
                    End If
                    If objdatos.barrio <> "" Then
                        txtbarrio.Text = objdatos.barrio
                        txtbarrio.Enabled = False
                        Btn_Act_Barrio.Visible = True
                    End If
                    If objdatos.pqr <> "" Or objdatos.Tipo_PQR <> "" Then
                        Btn_Act_PQR.Visible = True
                    End If
                    If objdatos.Tipo_Cliente <> "" Then
                        drlModalidad.SelectedValue = objdatos.Tipo_Cliente
                        drlModalidad.Enabled = False
                    End If
                    objdatos.Validacion = "DILO"
                    objdatos.Consulta_Campos_Fideliza_y_Dilo()
                    objdatos.Validacion = ""
                    If objdatos.dpto <> "" And objdatos.dpto <> " " And objdatos.dpto <> "0" Then
                        drldpto.SelectedValue = objdatos.dpto
                        drldpto.Enabled = False
                        drldpto_SelectedIndexChanged(1, Nothing)
                        drlmun.SelectedValue = objdatos.mun
                        drlmun.Enabled = False
                        Btn_Act_Mun.Visible = True
                    End If
                    Consulta_Municipio_Distrubuidores()
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
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Try
            If txtcaso.Text = "" Then
                Throw New Exception("Digite el caso que desea registrar")
            End If
            If drltipificacionll.SelectedIndex = 0 Then
                Throw New Exception("Seleccione la tipificación de la llamada")
            End If
            If txtobs.Text = "" Then
                Throw New Exception("Digite la observación de atención al caso")
            End If
            If drlservicio2.SelectedIndex = 0 Then
                Throw New Exception("Seleccione el Servicio en CATALOGO DE DIAGNOSTICO")
            End If
            If txtbarrio.Text = "" And drltipificacionll.SelectedItem.Text <> "No Contactado" Then
                Throw New Exception("Digite el barrio donde se presenta la falla")
            End If
            If drlModalidad.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una modalidad")
            End If
            If drlsolicitud.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una Solicitud / Tipo Falla")
            End If
            If drlCausa_Raiz.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una causa raiz de falla")
            End If
            If drlCategoriaCierre.SelectedIndex = 0 Then
                Throw New Exception("Seleccione una categoria de cierre")
            End If
            If TxtPQR.Text = "" Then
                Throw New Exception("Ingrese el consecutivo PQR")
            End If
            If (drltipificacionll.SelectedItem.Text = "Cerrado" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD" Or drltipificacionll.SelectedItem.Text = "Seguimiento" Or drltipificacionll.SelectedItem.Text = "Gestionado") And drlmun.SelectedIndex = 0 Then
                Throw New Exception("Seleccione el departamento y municipio")
            End If
            Dim objdatos As New clscrmdatos
            objdatos.caso = txtcaso.Text
            objdatos.Validacion = 3
            objdatos.ConsultarEstados()
            If objdatos.tipificacion.Contains("Cerrado") Or objdatos.tipificacion.Contains("Escala") Then
                Throw New Exception("¡El Caso que desea guardar se encuentra Cerrado, Escalado o Solicitud Escalar!")
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
            objdatos.Validacion = Nothing
            objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            If drltipificacionll.SelectedItem.Text <> "No Contactado" Then
                If drlmun_incon.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione Departamento y municipio en inconsistencia distribuidor")
                End If
                If Txt_Distribuidor.Text = "" Then
                    Throw New Exception("Digite Distribuidor en inconsistencia distribuidor")
                End If
                objdatos.lugar = drlmun_incon.SelectedValue
                objdatos.preg3 = Txt_Distribuidor.Text
            Else
                objdatos.lugar = ""
                objdatos.preg3 = ""
            End If
            objdatos.obs = txtobs.Text
            objdatos.servreest = drlservicio2.SelectedItem.Value
            objdatos.estadoinc = ""
            objdatos.mesaesc = ""
            objdatos.incidente = ""

            objdatos.mun = drlmun.SelectedItem.Value
            objdatos.barrio = txtbarrio.Text
            objdatos.pqr = Int64.Parse(LblPQR.Text + TxtPQR.Text)
            '-----------inconsistencia--------'
            objdatos.inconsistencia_encuesta = ""
            '---------------------'
            '---Programado---'
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
            '---Fin Programados'
            '-------Escalar--------'
            If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar CPD" And lblescalamiento.Text = "Falla de red" Then
                Throw New Exception("Si reporto falla de red el estado del caso debe ser Solicitud Escalar CPD")
            End If
            If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar SD" And lblescalamiento.Text = "Escalamiento" Then
                Throw New Exception("Si realizó Escalamiento Service el estado del caso debe ser Solicitud Escalar SD")
            End If
            '------Numero Alterno------'
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
            If drltipificacionll.SelectedItem.Text.Contains("CPD") Then
                If drl_tipo_canal.SelectedIndex = 0 Then
                    Throw New Exception("Seleccione un tipo de canal")
                End If
                objdatos.Tipo_Canal = drl_tipo_canal.SelectedItem.Text
                If txt_Estacion_base.Text = "" Then
                    Throw New Exception("Digite Estacion Base")
                End If
                objdatos.Estacion_base = txt_Estacion_base.Text
            End If

            If pnservice.Visible = True And drltipificacionll.SelectedItem.Text.Contains("SD") Then
                Escalar_SD()
            End If
            If PNEscalam.Visible = True And drltipificacionll.SelectedItem.Text.Contains("CPD") Then
                Escalar_CPD()
            End If

            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            '''''Registro de gestion
            objdatos.registrodilo()
            Actualizar_Bandeja()
            '---Autoasignar caso---'
            If drltipificacionll.SelectedItem.Text = "Programado" Then
                If drlLibera.SelectedItem.Text = "SI" Then
                    objdatos.caso = lblcaso.Text
                    objdatos.Validacion = "Libera"
                    objdatos.asignacionDilo()
                ElseIf drlLibera.SelectedItem.Text = "NO" Then
                    objdatos.caso = lblcaso.Text
                    objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                    objdatos.Validacion = "Autoasigna"
                    objdatos.asignacionDilo()
                End If
            End If
            Registrar_Diagnostico()
            Btn_Consultar_Click(1, Nothing)
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Seguimiento ingresado con éxito"
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub LinkButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton3.Click
        Try
            If lblcaso.Text = Nothing Then
                Throw New Exception("Consulte el caso antes de generar una inconsistencia")
            End If
            Pninc.Visible = True
            'ubicacion call
            LinkButton4.Visible = True
            LinkButton3.Visible = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub LinkButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton4.Click 'oculta inconsistencia
        Try
            Pninc.Visible = False
            LinkButton4.Visible = False
            LinkButton3.Visible = True
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub btnguardar0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar0.Click 'registro de inconsistencia
        Try
            ''''Consulta si ya existe algun registro para evitar conflicto con PK- © CDRR.
            If lblcaso.Text = Nothing Then
                Throw New Exception("Primero debe consultar el caso para poder registrar una inconsistencia")
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

            If drlnivel.SelectedIndex = 0 Then
                Throw New Exception("Elija el nivel que genera la inconsistencia, verifique")
            End If
            Dim objdatos As New clscrmdatos
            If drl_ubicacion_call.SelectedIndex = 0 Then
                Throw New Exception("Seleccione ubicacion de call center")
            End If
            objdatos.Validacion = "Inconsistencia"
            objdatos.caso = lblcaso.Text
            objdatos.Consulta_Registro_Falla_Red_Incinsistencia_Otro()
            If objdatos.cantidad > 0 Then
                Throw New Exception("El Caso Claro: " + lblcaso.Text + " ya tiene un registro de inconsistencai")
            End If
            objdatos.incidente = drlincons.SelectedItem.Value
            objdatos.obs = txtobsinc.Text
            objdatos.custcode = Txt_custcode.Text
            objdatos.usuarioreporta = Txt_usuario_reporta.Text
            objdatos.lugar = drl_ubicacion_call.SelectedValue
            objdatos.barrio = drlnivel.SelectedItem.Value
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
            Pninc.Visible = False
            drlnivel.SelectedIndex = 0
            drlnivel_SelectedIndexChanged(1, Nothing)
            LinkButton3.Visible = True
            LinkButton4.Visible = False
            drl_ubicacion_call.Enabled = True
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub Btn_Act_Barrio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Act_Barrio.Click
        Try
            txtbarrio.Enabled = True
            Btn_Act_Barrio.Visible = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub Btn_Act_Mun_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Act_Mun.Click
        Try
            drlmun.Enabled = True
            drldpto.Enabled = True
            Btn_Act_Mun.Visible = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub Btn_Act_PQR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Act_PQR.Click
        Try
            drlTipo_PQR.Enabled = True
            TxtPQR.Enabled = True
            Btn_Act_PQR.Visible = False
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub Btn_Actualizar_Distribuidor_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar_Distribuidor.Click
        Try
            Btn_Actualizar_Distribuidor.Visible = False
            Txt_Distribuidor.Enabled = True
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub Btn_Actualizar_Mun_Distri_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar_Mun_Distri.Click
        Try
            Btn_Actualizar_Mun_Distri.Visible = False
            drldpto_incon.Enabled = True
            drlmun_incon.Enabled = True
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
#End Region
#Region "Check"
    Protected Sub rdbron_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdbron.SelectedIndexChanged
        Try
            'Dim objdatos As New clsgeneral
            If rdbron.SelectedItem.Value = "Error en Registro" Then
                Cargar_drlvariable(6)
                Lbl_Title.Text = rdbron.SelectedItem.Value
            End If
            If rdbron.SelectedItem.Value = "Ajeno a Red Celular" Then
                Cargar_drlvariable(7)
                Lbl_Title.Text = rdbron.SelectedItem.Value
            End If
            If rdbron.SelectedItem.Value = "Asociado Red Celular" Then
                Cargar_drlvariable(8)
                Lbl_Title.Text = rdbron.SelectedItem.Value
            End If
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
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
#End Region
#Region "Drl"
    Protected Sub Cargar_Drls()
        Try
            If Not IsPostBack Then
                'divipola - dpto
                With drldpto
                    .DataSource = Obj_General.consultadpto
                    .DataTextField = "nombredpto"
                    .DataValueField = "coddpto"
                    .DataBind()
                    drldpto = Obj_G_D.Gest_Drl(drldpto)
                End With
                'Dpto inconsis
                With drldpto_incon
                    .DataSource = Obj_General.consultadpto
                    .DataTextField = "nombredpto"
                    .DataValueField = "coddpto"
                    .DataBind()
                    Obj_G_D.Gest_Drl(drldpto_incon)
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
                With drlmarca
                    .DataSource = Obj_General.consultamarca
                    .DataTextField = "marca"
                    .DataValueField = "marca"
                    .DataBind()
                    drlmarca = Obj_G_D.Gest_Drl(drlmarca)
                End With
                'caracteristicas
                With drlFcaract
                    .DataSource = Obj_General.consultacaractdat
                    .DataTextField = "desccarac"
                    .DataValueField = "idcarac"
                    .DataBind()
                    drlFcaract = Obj_G_D.Gest_Drl(drlFcaract)
                End With
                With DrlCanalDilo
                    .DataSource = Obj_General.Consulta_Complemento_CanalDilo
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    DrlCanalDilo = Obj_G_D.Gest_Drl(DrlCanalDilo)
                End With
                'Linea de servicio
                Obj_General.Validacion = "linea_serv"
                With drllinea
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Diagnostico2
                    .DataTextField = "tipificacion1"
                    .DataValueField = "tipificacion1"
                    .DataBind()
                    drllinea = Obj_G_D.Gest_Drl(drllinea)
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
                'Modalidad
                Obj_General.Validacion = "Modalidad"
                With drlModalidad
                    .DataSource = Obj_General.Consulta_Cargue_Catalogo_Servicio_V2
                    .DataTextField = "tipo2"
                    .DataValueField = "tipo2"
                    .DataBind()
                    drlModalidad = Obj_G_D.Gest_Drl(drlModalidad)
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
                ' Qos
                Obj_General.Validacion = "VF_Qos"
                With Drl_Qos
                    .DataSource = Obj_General.Carga_Drl_Servicio_Cliente_SAC
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    Drl_Qos = Obj_G_D.Gest_Drl(Drl_Qos)
                End With
                Obj_General.Validacion = "Ubicacion_call2"
                With drl_ubicacion_call
                    .DataSource = Obj_General.consulta_campaña_inb
                    .DataTextField = "nombre"
                    .DataValueField = "valor"
                    .DataBind()
                    drl_ubicacion_call = Obj_G_D.Gest_Drl(drl_ubicacion_call)
                End With
                'validar enbebidos en el html
                drlnivel = Obj_G_D.Gest_Drl(drlnivel)
                drlLibera = Obj_G_D.Gest_Drl(drlLibera)
                drlFtiempo = Obj_G_D.Gest_Drl(drlFtiempo)
                drlFlineasfalla = Obj_G_D.Gest_Drl(drlFlineasfalla)
                drlFportada = Obj_G_D.Gest_Drl(drlFportada)
                drlFtectolog = Obj_G_D.Gest_Drl(drlFtectolog)
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
                drldpto.SelectedIndex = 0
                drldpto_incon.SelectedIndex = 0
                drlinconsglobal.SelectedIndex = 0
                drlmarca.SelectedIndex = 0
                drlFcaract.SelectedIndex = 0
                DrlCanalDilo.SelectedIndex = 0
                drllinea.SelectedIndex = 0
                drlTipo_PQR.SelectedIndex = 0
                Drl_justificacion_seguimiento.SelectedIndex = 0
                drlModalidad.SelectedIndex = 0
                Drl_Tipo_Edificacion_Donde_Presenta_Falla_1.SelectedIndex = 0
                Drl_Tipo_Edificacion_Donde_Presenta_Falla_2.SelectedIndex = 0
                Drl_Tecnologia_Presenta_Falla_Luegodepruebas.SelectedIndex = 0
                Drl_Split_Billing.SelectedIndex = 0
                Drl_HLR_HSS.SelectedIndex = 0
                Drl_Forza_Red_Dispositivo.SelectedIndex = 0
                Drl_Verifica_Realiza_Configuración_APN.SelectedIndex = 0
                drlapn.SelectedIndex = 0
                drlqos.SelectedIndex = 0
                Drl_Qos.SelectedIndex = 0
                drl_ubicacion_call.SelectedIndex = 0

                'reiniciar envividos en el hatml
                drlnivel.SelectedIndex = 0
                drlLibera.SelectedIndex = 0
                drlFtiempo.SelectedIndex = 0
                drlFlineasfalla.SelectedIndex = 0
                drlFportada.SelectedIndex = 0
                drlFtectolog.SelectedIndex = 0
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
            drldpto_SelectedIndexChanged(1, Nothing)
            drldpto_incon_SelectedIndexChanged(1, Nothing)
            drlinconsglobal_SelectedIndexChanged(1, Nothing)
            drlmarca_SelectedIndexChanged(1, Nothing)
            drllinea_SelectedIndexChanged(1, Nothing)
            Cargar_drlvariable(6)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub Cargar_drlvariable(ByVal Cod As Integer)
        Try
            With drlvariable
                Obj_General.idusuario = Cod
                .DataSource = Obj_General.consultadiagnostico
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
        Catch ex As Exception
            Throw ex
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
    Protected Sub drldpto_incon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drldpto_incon.SelectedIndexChanged
        Try
            With drlmun_incon
                If drldpto_incon.SelectedIndex > 0 Then
                    Obj_General.dpto = drldpto_incon.SelectedItem.Value
                    .DataSource = Obj_General.consultamun
                    .DataTextField = "nombremun"
                    .DataValueField = "coddiv"
                    .DataBind()
                Else
                    .Items.Clear()
                End If
                drlmun_incon = Obj_G_D.Gest_Drl(drlmun_incon)
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
    Protected Sub drlvariable_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlvariable.SelectedIndexChanged
        Try
            Dim objdatos As New clscrmdatos
            objdatos.diagservicio = drlvariable.SelectedItem.Value
            objdatos.consultaproceso()
            lblvariable.Text = objdatos.tipificacion
        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub drlinconsglobal_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlinconsglobal.SelectedIndexChanged
        Try
            With drlincons
                If drlinconsglobal.SelectedIndex > 0 Then
                    Obj_General.cargo = "inconsistencia"
                    Obj_General.estado = drlinconsglobal.SelectedValue
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
    'Cascada
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
            If drltipificacionll.SelectedItem.Text.Contains("SD") Then
                pnservice.Visible = True
                PNEscalam.Visible = False
                Pnl_Estacion.Visible = False
                txt_Estacion_base.Text = ""
                Pnl_Tipo_canal.Visible = False
            ElseIf drltipificacionll.SelectedItem.Text.Contains("CPD") Then
                pnservice.Visible = False
                PNEscalam.Visible = True
                Pnl_Estacion.Visible = True
                Pnl_Tipo_canal.Visible = True

                Obj_General.Validacion = "Tipo_Canal_Dilo"
                Obj_General.tipo = lbl_canal.Text
                With drl_tipo_canal
                    .DataSource = Obj_General.consulta_campaña_inb
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                    drl_tipo_canal = Obj_G_D.Gest_Drl(drl_tipo_canal)
                End With
            Else
                pnservice.Visible = False
                PNEscalam.Visible = False
                Pnl_Estacion.Visible = False
                txt_Estacion_base.Text = ""
                Pnl_Tipo_canal.Visible = False
            End If
            If drltipificacionll.SelectedItem.Text = "Programado" Then
                Pnl_Seguimiento.Visible = True
                Pnl_Estacion.Visible = False
                txt_Estacion_base.Text = ""
                Pnl_Tipo_canal.Visible = False
            Else
                Pnl_Seguimiento.Visible = False
            End If

            If drltipificacionll.SelectedItem.Text <> "Cerrado" And Not drltipificacionll.SelectedItem.Text.Contains("Solici") And drltipificacionll.SelectedItem.Text <> "Falla Masiva" And drltipificacionll.SelectedIndex > 0 Then
                Panel_Justificacion.Visible = True
                Pnl_Estacion.Visible = False
                txt_Estacion_base.Text = ""
                Pnl_Tipo_canal.Visible = False
            Else
                Panel_Justificacion.Visible = False
                Drl_justificacion_seguimiento.SelectedIndex = 0
            End If

        Catch ex As Exception
            Obj_G_D.Val_Ex(ex)
            Pnl_Message.CssClass = Obj_G_D.Ex("Alert")
            lblmsg.Text = Obj_G_D.Ex("Message")
        End Try
    End Sub
    Protected Sub Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedIndexChanged
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
End Class