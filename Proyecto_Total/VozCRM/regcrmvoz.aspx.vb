Public Class regcrm1
    Inherits System.Web.UI.Page
    Dim Validacion As String = "False"

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
                lblred.Text = objdatos.cargo
                lblasig.Text = objdatos.dpto
                With drlmarca
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultamarca
                    .DataTextField = "marca"
                    .DataValueField = "marca"
                    .DataBind()
                End With
                objdatos.estado = drlmarca.SelectedItem.Value
                With drlequipo
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultaequipo
                    .DataTextField = "equipo"
                    .DataValueField = "equipo"
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

                'localidad - barrio
                With drllocalidad
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultalocalidad
                    .DataTextField = "localidad"
                    .DataValueField = "localidad"
                    .DataBind()
                End With
                objdatos.localidad = drllocalidad.SelectedItem.Text
                With drlbarrio
                    .DataSource = objdatos.consultabarrio
                    .DataTextField = "barrio"
                    .DataValueField = "idbarrio"
                    .DataBind()
                End With
                'caracteristicas
                With drlFcaract
                    .DataSource = objdatos.consultacaract
                    .DataTextField = "desccarac"
                    .DataValueField = "idcarac"
                    .DataBind()
                End With

                cargadrl()
                cargadrlinc()
                traeprogramados()
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
    Protected Sub traeprogramados()
        Try
            Dim objdatos As New clsvoz
            'objdatos.idusuario = lblusuario.Text
            'dtgprog.DataSource = objdatos.consultaprogramado
            'dtgprog.DataBind()

            objdatos.idusuario = lblusuario.Text
            dtgasig.DataSource = objdatos.consultaasignadoseg
            dtgasig.DataBind()

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clsvoz
        Try
            If lblcaso.Text = "" Then
                lblmsg.Text = "Antes de guardar de clic en el botón buscar para verificar que el caso es válido"
                Exit Sub
            End If
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            If drltipificacionll.SelectedItem.Text <> "GESTIONADO" Then
                If (drltipificacionll.SelectedItem.Text = "CERRADO" Or drltipificacionll.SelectedItem.Text = "ESCALADO" Or drltipificacionll.SelectedItem.Text = "RECHAZADO") And drlsoporte.SelectedItem.Value = "0" Then
                    lblmsg.Text = "Si el caso se encuentra cerrado, escalado o rechazado debe elegir un tipo de soporte"
                    Exit Sub
                End If
                If drltipificacionll.SelectedItem.Text = "PROGRAMADO" Then
                    If TxtMinuto_Llamada.Text = "" Or TxtHora_Llamada.Text = "" Or TxtFcProgramado.Text = "" Then
                        lblmsg.Text = "Si la llamada es programada elija la fecha y hora a la que se debe llamar nuevamente (SEGUIMIENTO - Fecha Programación & Hora)"
                        TxtFcProgramado.Text = ""
                        Exit Sub
                    Else
                        Dim hora As String
                        If TxtHora_Llamada.Text > 23 Or TxtMinuto_Llamada.Text > 59 Then
                            lblmsg.Text = "La hora de programación no es correcta, verifique (SEGUIMIENTO - Hora)"
                            TxtFcProgramado.Text = ""
                            Exit Sub
                        End If
                        hora = Convert.ToDateTime(TxtFcProgramado.Text & " " & TxtHora_Llamada.Text & ":" & TxtMinuto_Llamada.Text)
                        If Convert.ToDateTime(hora) <= Now Then
                            lblmsg.Text = "La fecha de programación debe ser mayor a la fecha actual, verifique (SEGUIMIENTO - Fecha Programación & Hora)"
                            TxtFcProgramado.Text = ""
                            Exit Sub
                        End If
                        objdatos.fcfin = hora
                    End If
                End If
                If drltipificacionll.SelectedItem.Text = "PROGRAMADO" And drlpercep.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione un Servicio Afectado y una Percepción de Falla (CATALOGO DE DIAGNOSTICO - Percepción de Falla)"
                    Exit Sub
                End If
                If drl611.SelectedItem.Value <> "0" Then
                    objdatos.preg1 = drl611.SelectedItem.Value
                Else
                    objdatos.preg1 = "0"
                End If
                If drltsoporte.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione el tipo de cierre realizado (CIERRE LLAMADA- Tipo Cierre)"
                    Exit Sub
                Else
                    'validar que se halla guardado falla de red en caso de ser necesario
                    If drltsoporte.SelectedItem.Value = 7 Or drltsoporte.SelectedItem.Value = 8 Or drltsoporte.SelectedItem.Value = 9 Or drltsoporte.SelectedItem.Value = 20 Then
                        If lblctrl.Text = "0" Then
                            lblmsg.Text = "Si el escalamiento es por tipo 7, 8, 9 o 20 debe generar una falla de red"
                            Exit Sub
                        End If

                    End If
                    objdatos.tipificacion = drltsoporte.SelectedItem.Text
                End If
                If drlsoporte.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione el tipo de soporte brindado antes de guardar (CIERRE LLAMADA- Tipo Soporte)"
                    Exit Sub
                Else
                    objdatos.tiposoporte = drlsoporte.SelectedItem.Value
                End If
                If drlmun.SelectedItem.Value = 11001 Then
                    If drlbarrio.SelectedItem.Value = 0 Then
                        lblmsg.Text = "Elija el barrio donde se presenta la falla (GEORREFERENCIACION- Localidad -Barrio)"
                        Exit Sub
                    Else
                        objdatos.barrio = drlbarrio.SelectedItem.Value
                    End If
                Else
                    objdatos.barrio = drlbarrio.SelectedItem.Value
                End If
                If drlmun.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione el departamento y municipio (GEORREFERENCIACION- Departamento-Municipio )"
                    Exit Sub
                End If
                If TxtPQR.Text = "" Then
                    lblmsg.Text = "Ingrese el consecutivo PQR (CIERRE LLAMADA - pqr)"
                    Exit Sub
                Else
                    objdatos.pqr = Int64.Parse(LblPQR.Text + TxtPQR.Text)
                End If
                If txtobs.Text = "" Then
                    lblmsg.Text = "Digite la observación de atención al caso (Observacion)"
                    Exit Sub
                Else
                    objdatos.obs = txtobs.Text
                End If
                If txtnumalt.Text = "" Then
                    objdatos.telalt = ""
                Else
                    objdatos.telalt = txtnumalt.Text
                End If
                If txtultimc.Text <> "" And drlfranja.SelectedItem.Value = "0" Then
                    lblmsg.Text = "Elija la franja en la que se presentó la última caida: mañana, tarde, noche (GEORREFERENCIACIÓN -Fecha Ultima Caida)"
                    Exit Sub
                End If
                If lblfallatec.Text <> " " Then
                    If drlfallatec.SelectedItem.Value = "0" Then
                        lblmsg.Text = "El caso fue reportado con tickler abierto, por favor especificar el estado del tickler (SEGUIMIENTO-Estado Fallatec)"
                        Exit Sub
                    Else
                        objdatos.fallatec = drlfallatec.SelectedItem.Value
                    End If
                Else
                    objdatos.fallatec = ""
                End If
                objdatos.idusuario = lblusuario.Text
                If chknvoformato.Checked = True And drlmesa.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Elija la mesa en donde se debe crear un nuevo formato, o desactive el check de nuevo formato (SEGUIMIENTO - Mesa)"
                    Exit Sub
                End If
                'nx
                If drlIntalaApp.Enabled = True And drlMotivo.Enabled = True Then
                    If drlIntalaApp.Text = "1" Then
                        lblmsg.Text = "Seleccione una opcion de instalacion de APP (ENCUESTAS - Se Instalo App Nx Monitor)"
                        Exit Sub
                    End If
                    If drlIntalaApp.Text = "NO" Then
                        If drlMotivo.Text = "1" Then
                            lblmsg.Text = "Seleccione un motivo por el cual no se instalo la APP (ENCUESTAS - Motivo)"
                            Exit Sub
                        Else
                            objdatos.preg2 = drlIntalaApp.Text
                            objdatos.preg3 = drlMotivo.Text
                        End If
                    Else
                        objdatos.preg2 = drlIntalaApp.Text
                        objdatos.preg3 = "OK"
                    End If
                Else
                    objdatos.preg2 = Nothing
                End If
                If drltipificacionll.SelectedItem.Text = "CERRADO" Or drltipificacionll.SelectedItem.Text = "ESCALADO" Or drltipificacionll.SelectedItem.Text = "RECHAZADO" Then
                    If (drltsoporte.SelectedItem.Text <> "11_Rechazado_In_Lin_Campana_Voz") And (drltsoporte.SelectedItem.Text <> "14_NA_Senal_Otros_Campana_Voz") Then
                        If drlmarca.SelectedItem.Text = "- Seleccione -" Then
                            lblmsg.Text = "Si el caso es cerrado, escalado o rechazado, debe elegir la marca del equipo (GEORREFERENCIACION Marca-Equipo)"
                            Exit Sub
                        End If
                        If drlequipo.SelectedItem.Text = "- Seleccione -" Then
                            lblmsg.Text = "Seleccione un equipo (GEORREFERENCIACION Marca-Equipo)"
                            Exit Sub
                        End If
                    End If
                End If
                If drlsolicitud.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una Solicitud / Tipo Falla (VOZ DEL CLIENTE)"
                    Exit Sub
                End If
                If drlTipo_PQR.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione un tipo PQR (Voz del cliente)"
                    Exit Sub
                End If
                If drlTipo_Cliente.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione un tipo de cliente (Voz del cliente)"
                    Exit Sub
                End If
                If drlModalidad.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una modalidad (Voz del cliente)"
                    Exit Sub
                End If
                If drlCausa_Raiz.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una causa raiz de falla (CATALOGO DE DIAGNOSTICO)"
                    Exit Sub
                End If
                If drlCategoriaCierre.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una categoria de cierre (CIERRE DE LLAMADA)"
                    Exit Sub
                End If
            Else
                If drlsoporte.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione el tipo de soporte brindado antes de guardar (CIERRE DE LLAMADA)"
                    Exit Sub
                Else
                    objdatos.tiposoporte = drlsoporte.SelectedItem.Value
                End If

                If TxtPQR.Text = "" Then
                    lblmsg.Text = "Ingrese el consecutivo PQR (CIERRE DE LLAMADA)"
                    Exit Sub
                Else
                    objdatos.pqr = Int64.Parse(LblPQR.Text + TxtPQR.Text)
                End If
                If txtobs.Text = "" Then
                    lblmsg.Text = "Digite la observación de atención al caso (OBSERVACION)"
                    Exit Sub
                Else
                    objdatos.obs = txtobs.Text
                End If
                objdatos.tipificacion = drltsoporte.SelectedItem.Text
                objdatos.idusuario = lblusuario.Text
                objdatos.Validacion = drltipificacionll.SelectedItem.Text
            End If

            objdatos.registrocrmvoz()
            actbandeja()
            If chknvoformato.Checked = True Then
                nuevoformato()
            End If
            guardadiagnostico()
            Consulta_Gestion()
            buscarinf()
            lblmsg.Text = "Seguimiento ingresado con éxito"
            Limpia_Herramientas()
            traeprogramados()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub nuevoformato()
        Try
            Dim objdatos As New clsvoz
            objdatos.caso = txtcaso.Text
            objdatos.mesa = drlmesa.SelectedItem.Value
            objdatos.idusuario = lblusuario.Text
            objdatos.nuevoformato()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub actbandeja()
        Try
            Dim objdatos As New clsvoz
            objdatos.caso = txtcaso.Text
            objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            If drlequipo.SelectedItem.Value = "- Seleccione -" Then
                objdatos.equipo = ""
            Else
                objdatos.equipo = drlequipo.SelectedItem.Text
            End If
            objdatos.escala = 0
            objdatos.mun = drlmun.SelectedItem.Value
            objdatos.fallatec = drlfallatec.SelectedItem.Value
            objdatos.modificarbandeja()

            objdatos.Nombre = drltsoporte.SelectedItem.Text
            If objdatos.ConsultaEscalarService().Tables(0).Rows.Count > 0 Then
                objdatos.caso = txtcaso.Text
                objdatos.idusuario = lblusuario.Text
                objdatos.obs = txtobs.Text
                objdatos.registrofallaservice()
            End If
           
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub buscarinf()
        Try
            Dim objdatos As New clsvoz
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el Caso que desea consultar"
            Else
                'trae casos asignados
                If lblasig.Text = "1" Then
                    objdatos.idusuario = lblusuario.Text
                    objdatos.caso = txtcaso.Text
                    objdatos.validacasoasignadovoz()
                    If objdatos.cantidad = 0 Then
                        lblmsg.Text = "El caso no se encuentra asignado a su usuario, revise con su supervisor"
                        lblcliente.Text = ""
                        lbldocumento.Text = ""
                        lblmin.Text = ""
                        lblequipo.Text = ""
                        lblcaso.Text = ""
                        Lblfc_ingreso.Text = ""
                        lblobs611.Text = ""
                        lblestado.Text = ""
                        lblfallatec.Text = ""
                        dtgcoincidentes.DataSource = Nothing
                        dtgcoincidentes.DataBind()
                        lblcuenta1.Text = 0
                        Limpia_Herramientas()
                        Exit Sub
                    End If
                End If
                objdatos.caso = txtcaso.Text
                dtggeneral.DataSource = objdatos.consultacasovoz
                dtggeneral.DataBind()
                lblcuenta.Text = objdatos.cantidad
                If objdatos.cantidad > 0 Then
                    lblcliente.Text = objdatos.cliente
                    lbldocumento.Text = objdatos.documento
                    lblmin.Text = objdatos.min
                    lblequipo.Text = objdatos.equipo
                    lblcaso.Text = objdatos.caso
                    lblobs611.Text = objdatos.obsini
                    lblestado.Text = objdatos.tipificacion
                    lblmesa.Text = objdatos.mesa
                    lblfallatec.Text = objdatos.fallatec
                    Lblfc_ingreso.Text = objdatos.casfcregistro
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
                    ''''''''''''''''''''''''''''''''''''''''''''''''''
                    ''''''''''''''''''''''Carga'''''''''''''''''''''''
                    ''''''''''''''''''''''''''''''''''''''''''''''''''
                    If drlFtectolog.Enabled = False Or drlmarca.Enabled = False Or drlequipo.Enabled = False Or drldpto.Enabled = False Or drlmun.Enabled = False Or txtbarrio.Enabled = False Or txtultimc.Enabled = False Or drlfranja.Enabled = False Or drlTipo_PQR.Enabled = False Or drlTipo_Cliente.Enabled = False Or drlModalidad.Enabled = False Or TxtPQR.Enabled = False Or drl611.Enabled = False Then
                        Limpia_Herramientas_Cargadas()
                    End If
                    If Validacion = "Consulta" Then
                        objdatos.Consulta_Diganostico_Carga_Voz()
                        If objdatos.tecnologia <> "" And objdatos.tecnologia <> "0" Then
                            drlFtectolog.SelectedValue = objdatos.tecnologia
                            drlFtectolog.Enabled = False
                            Btn_Habilita_Tecnologia.Visible = True
                        Else
                            Btn_Habilita_Tecnologia.Visible = False
                            drlFtectolog.Enabled = True
                        End If
                        If objdatos.Marca <> "" And objdatos.Marca <> " " And objdatos.Marca <> "0" Then
                            drlmarca.SelectedValue = objdatos.Marca
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
                        If objdatos.Localidad <> "" And objdatos.Localidad <> " " And objdatos.Localidad <> "0" Then
                            drllocalidad.SelectedValue = objdatos.Localidad
                            drllocalidad.Enabled = False
                            drllocalidad_SelectedIndexChanged(1, Nothing)
                            drlbarrio.SelectedItem.Text = objdatos.barrio
                            drlbarrio_SelectedIndexChanged(1, Nothing)
                            drlbarrio.Enabled = False
                            Btn_Habilita_Barrio.Visible = True
                        Else
                            Btn_Habilita_Barrio.Visible = False
                            drllocalidad.Enabled = True
                            drlbarrio.Enabled = True
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
                        If objdatos.Tipo_Cliente <> "" Then
                            drlTipo_Cliente.SelectedValue = objdatos.Tipo_Cliente
                            drlTipo_Cliente.Enabled = False
                        Else
                            drlTipo_Cliente.Enabled = True
                        End If
                        If objdatos.Modalidad <> "" Then
                            drlModalidad.SelectedValue = objdatos.Modalidad
                            drlModalidad.Enabled = False
                        Else
                            drlModalidad.Enabled = True
                        End If
                        If objdatos.pqr <> "" And objdatos.pqr <> " " Then
                            TxtPQR.Text = Mid(objdatos.pqr, 10, 7)
                            TxtPQR.Enabled = False
                            Btn_Habilita_PQR.Visible = True
                        Else
                            TxtPQR.Enabled = True
                            Btn_Habilita_PQR.Visible = False
                        End If
                    End If
                    ''''''''''''''''''''''''''''''''''''''''''''''''''
                    ''''''''''''''''''''''Fin Carga'''''''''''''''''''
                    ''''''''''''''''''''''''''''''''''''''''''''''''''
                Else
                    lblmsg.Text = "No se han encontrado registros coincidentes"
                    If drlFtectolog.Enabled = False Or drlmarca.Enabled = False Or drlequipo.Enabled = False Or drldpto.Enabled = False Or drlmun.Enabled = False Or txtbarrio.Enabled = False Or txtultimc.Enabled = False Or drlfranja.Enabled = False Or drlTipo_PQR.Enabled = False Or drlTipo_Cliente.Enabled = False Or drlModalidad.Enabled = False Or TxtPQR.Enabled = False Or drl611.Enabled = False Then
                        Limpia_Herramientas_Cargadas()
                    End If
                    dtgcoincidentes.DataSource = Nothing
                    dtgcoincidentes.DataBind()
                    lblcuenta1.Text = 0
                End If
            End If
            ''''ConsultaNxMotor
            If txtcaso.Text <> "" Then
                objdatos.caso = txtcaso.Text
            End If
            objdatos.ConsultaNxMonitor()
            If objdatos.preg2 = "SI" Then
                drlIntalaApp.Enabled = False
                drlMotivo.Enabled = False
            Else
                drlIntalaApp.Enabled = True
                drlMotivo.Enabled = True
                Dim objdatos1 As New clsgeneral
                objdatos1.idusuario = lblusuario.Text
                objdatos1.consultared()
                If objdatos1.mun <> "1" Then
                    drlIntalaApp.Enabled = False
                    drlMotivo.Enabled = False
                End If
            End If
            cargadrl()
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
                Dim objdatos As New clscrmdatos
                Validacion = "Consulta"
                buscarinf()
                If txtcaso.Text <> "" Then
                    objdatos.caso = txtcaso.Text
                End If
                objdatos.idusuario = lblusuario.Text
                objdatos.registroconsultacaso()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try

    End Sub

    Protected Sub drlmarca_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlmarca.SelectedIndexChanged
        Try
            equipo1()
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

    Protected Sub drltipificacionll_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drltipificacionll.SelectedIndexChanged
        Try
            tipif()
            Dim objdatos As New clsgeneral
            With drlgrupo
                .DataSource = objdatos.consultagrupo
                .DataTextField = "grupo"
                .DataValueField = "grupo"
                .DataBind()
            End With
            If drltipificacionll.SelectedItem.Text = "GESTIONADO" Then
                chksolucion.Checked = False
                objdatos.Validacion = 1
                With drlgrupo
                    .DataSource = objdatos.consultagrupoResticcion
                    .DataTextField = "grupo"
                    .DataValueField = "grupo"
                    .DataBind()
                End With
            End If
            If drltipificacionll.SelectedItem.Text = "CERRADO" Or drltipificacionll.SelectedItem.Text = "Previamente Cerrado" Then
                chksolucion.Checked = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub tipif()
        Try
            Dim objdatos As New clsgeneral
            If lblmesa.Text = "VOZ       " Or lblmesa.Text = "BUZON     " Or lblmesa.Text = "MENSAJES  " Or lblmesa.Text = "OTROS SERV" Then
                objdatos.cargo = 1
            Else
                objdatos.cargo = 2
            End If
            objdatos.tipo = drltipificacionll.SelectedItem.Value
            With drltsoporte
                objdatos.idtip = 1
                .DataSource = objdatos.consultatsoportevoz
                .DataTextField = "tipifcrm"
                .DataValueField = "idtipo"
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

    Protected Sub LinkButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton3.Click
        Try
            If lblcaso.Text = "" Then
                lblmsg.Text = "Antes de crear una falla de red de clic en el botón buscar para verificar que el caso es válido"
                Exit Sub
            End If
            If drltsoporte.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Elija el tipo de cierre brindado antes de generar una falla de red"
                Exit Sub
            End If
            If txtbarrio.Text = "" Then
                lblmsg.Text = "Digite el barrio antes de generar una falla de red"
                Exit Sub
            End If
            If drlFtectolog.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione la tecnología antes de generar una falla de red"
                Exit Sub
            End If
            If drlmun.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el municipio antes de generar una falla de red"
                Exit Sub
            End If
            If drlequipo.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el equipo antes de generar una falla de red"
                Exit Sub
            End If
            If drltipificacionll.SelectedItem.Text <> "ESCALADO" Then
                lblmsg.Text = "Si desea guardar una falla de red la tipificación de llamada debe ser escalado, verifique"
                Exit Sub
            Else
                If drltsoporte.SelectedItem.Value = 10 Or drltsoporte.SelectedItem.Value = 17 Then
                    lblmsg.Text = "Si el escalamiento es a Servisdesk no es necesario crear falla de red, verifique"
                    Exit Sub
                Else
                    lblmsg.Text = ""
                    Panel1.Visible = True
                    Pninc.Visible = False
                    pndiagnostico.Visible = False
                    txtFcontacto.Text = lblcliente.Text
                    txtFnum.Text = txtnumalt.Text
                    txtFtipofalla.Text = lblobs611.Text

                    If drlbarrio.SelectedItem.Value <> 0 Then
                        txtbarrio.Text = drlbarrio.SelectedItem.Text
                    End If
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub equipo1()
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

    Protected Sub LinkButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton4.Click
        Panel1.Visible = False
        Pninc.Visible = False
        pndiagnostico.Visible = True
    End Sub

    Protected Sub btnguardar0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar0.Click
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
                lblmsg.Text = "Describa el tipo de falla que se presenta"
                Exit Sub
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
            '''''Validacion Servicio tecnico'''''
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

            objdatos.campana = "Voz"
            objdatos.apn = ""
            If Drl_Qos.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un QoS"
                Exit Sub
            Else
                objdatos.qos = Drl_Qos.SelectedItem.Text
            End If

            objdatos.caso = lblcaso.Text
            objdatos.idusuario = lblusuario.Text
            objdatos.fcini = Lblfc_ingreso.Text
            objdatos.registrofallasred()
            guardacrm()
            lblmsg.Text = "Falla de red reportada con éxito"
            'limpiar
            Panel1.Visible = False
            txtfobs.Text = ""
            drlFlineasfalla.SelectedValue = "0"
            txtFdirecc.Text = ""
            txtFciudad.Text = ""
            rdbvc.SelectedValue = Nothing
            drlFportada.SelectedValue = "0"
            drlFcaract.SelectedValue = "0"
            txtFtipofalla.Text = ""
            txtFcontacto.Text = ""
            txtFnum.Text = ""
            lblctrl.Text = "1"
            '''''Validacion Servicio Tecnico''''''''''''
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

            drlFtiempo.SelectedValue = "0"
            Drl_Qos.SelectedValue = "- Seleccione -"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub guardacrm()
        Dim objdatos As New clsvoz
        Try
            objdatos.caso = txtcaso.Text
            If txtfobs.Text = "" Then
                objdatos.obs = ""
            Else
                objdatos.obs = txtfobs.Text
            End If
            objdatos.tipificacion = "Creado"
            objdatos.idusuario = lblusuario.Text
            objdatos.registrocrmfallared()
            lblmsg.Text = "Seguimiento ingresado con éxito"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub barrio()
        Try
            Dim objdatos As New clsgeneral
            'localidad - barrio
            objdatos.localidad = drllocalidad.SelectedItem.Value
            With drlbarrio
                objdatos.idtip = 1
                .DataSource = objdatos.consultabarrio
                .DataTextField = "barrio"
                .DataValueField = "idbarrio"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub drllocalidad_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drllocalidad.SelectedIndexChanged
        Try
            barrio()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub guardadiagnostico()
        Try
            Dim objdatos As New clsvoz
            If drlsolicitud.SelectedItem.Text <> "- Seleccione -" Or drlservicio.SelectedItem.Text <> "- Seleccione -" Or drlpercep.SelectedItem.Text <> "- Seleccione -" Or drlFtectolog.SelectedItem.Text <> "- Seleccione -" Or drlvariable.SelectedItem.Text <> "- Seleccione -" Or drlmun.SelectedItem.Text <> "- Seleccione -" Or txtultimc.Text <> "" Or drlCategoriaCierre.SelectedItem.Text <> "- Seleccione -" Or drlCausa_Raiz.SelectedItem.Text <> "- Seleccione -" Or drlModalidad.SelectedItem.Text <> "- Seleccione -" Or drlTipo_Cliente.SelectedItem.Text <> "- Seleccione -" Or drlTipo_PQR.SelectedItem.Text <> "- Seleccione -" Then
                If drlsolicitud.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.solicitud = "0"
                Else
                    objdatos.solicitud = drlsolicitud.SelectedItem.Value
                End If
                If drlservicio.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.diagservicio = "0"
                Else
                    objdatos.diagservicio = drlservicio.SelectedItem.Value
                End If
                If drlpercep.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.diagperep = "0"
                Else
                    objdatos.diagperep = drlpercep.SelectedItem.Value
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
                If txtbarrio.Text = "" Then
                    objdatos.barrio = ""
                Else
                    objdatos.barrio = txtbarrio.Text
                End If
                If chksolucion.Checked = True Then
                    objdatos.solucion = "SI"
                Else
                    objdatos.solucion = "NO"
                End If
                If chkajuste.Checked = True Then
                    objdatos.ajuste = "SI"
                Else
                    objdatos.ajuste = "NO"
                End If
                If txtmonto.Text = "" Then
                    objdatos.vlrajuste = "0"
                Else
                    objdatos.vlrajuste = txtmonto.Text
                End If
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
                If RdBtnBaja.Checked = False And RdBtnUpgrade.Checked = False Then
                    objdatos.Desactivacion = "null"
                Else
                    If RdBtnBaja.Checked = True Then
                        objdatos.Desactivacion = RdBtnBaja.Text
                    End If
                    If RdBtnUpgrade.Checked = True Then
                        objdatos.Desactivacion = RdBtnUpgrade.Text
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
                If drlTipo_Cliente.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Tipo_Cliente = ""
                Else
                    objdatos.Tipo_Cliente = drlTipo_Cliente.SelectedItem.Text
                End If
                If drlModalidad.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Modalidad = ""
                Else
                    objdatos.Modalidad = drlModalidad.SelectedItem.Text
                End If
                If drlCausa_Raiz.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Causa_Raiz = 0
                Else
                    objdatos.Causa_Raiz = drlCausa_Raiz.SelectedValue
                End If
                If drlCategoriaCierre.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Categoria_Cierre = 0
                Else
                    objdatos.Categoria_Cierre = drlCategoriaCierre.SelectedValue
                End If
                objdatos.registrodiag()
                cargadrl()
            End If
            txtbarrio.Text = ""
            drldpto.SelectedValue = "0"
            drlfranja.SelectedValue = "0"
            txtultimc.Text = ""
            RdBtnUpgrade.Checked = False
            RdBtnBaja.Checked = False

            dpto1()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Private Sub cargadrlinc()
        Try
            Dim objdatos As New clsgeneral
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
    Private Sub cargadrl()
        Try
            Dim objdatos As New clsgeneral

            'linea
            With drllinea
                .DataSource = objdatos.consultalineavoz
                .DataTextField = "tipo"
                .DataValueField = "tipo"
                .DataBind()
            End With

            'servicio
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.identidad = 20
            With drlservicio2
                .DataSource = objdatos.consultaservicio
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            'subservicio
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.mun = drlservicio2.SelectedItem.Text
            objdatos.identidad = 20
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
            objdatos.identidad = 20
            With drlsolicitud
                .DataSource = objdatos.consultasolicitud
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With

            With drltipificacionll
                objdatos.idtip = 1
                If lblmesa.Text = "VOZ       " Or lblmesa.Text = "BUZON     " Or lblmesa.Text = "MENSAJES  " Or lblmesa.Text = "OTROS SERV" Then
                    objdatos.cargo = 1
                Else
                    objdatos.cargo = 2
                End If
                .DataSource = objdatos.consultatipificacionvoz
                .DataTextField = "estagogest"
                .DataValueField = "estagogest"
                .DataBind()
            End With
            objdatos.tipo = drltipificacionll.SelectedItem.Value
            With drltsoporte
                If lblmesa.Text = "VOZ       " Or lblmesa.Text = "BUZON     " Or lblmesa.Text = "MENSAJES  " Or lblmesa.Text = "OTROS SERV" Then
                    objdatos.cargo = 1
                Else
                    objdatos.cargo = 2
                End If
                .DataSource = objdatos.consultatsoportevoz
                .DataTextField = "tipifcrm"
                .DataValueField = "idtipo"
                .DataBind()
            End With
            With drlsoporte
                If lblmesa.Text = "VOZ       " Or lblmesa.Text = "BUZON     " Or lblmesa.Text = "MENSAJES  " Or lblmesa.Text = "OTROS SERV" Then
                    objdatos.cargo = 1
                Else
                    objdatos.cargo = 2
                End If
                .DataSource = objdatos.consultasoportevoz
                .DataTextField = "destiposoporte"
                .DataValueField = "idsoporte"
                .DataBind()
            End With
            'variables de diagnóstico
            With drlservicio
                objdatos.idusuario = 1
                .DataSource = objdatos.consultadiagnosticovoz
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
            With drlpercep
                objdatos.idusuario = drlservicio.SelectedItem.Text
                .DataSource = objdatos.consultadiagnosticovoztipif
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
            With drlFtectolog
                objdatos.idusuario = 9
                .DataSource = objdatos.consultadiagnosticovoz
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
            With drlvariable
                objdatos.idusuario = 10
                .DataSource = objdatos.consultadiagnosticovoz
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
            With drlgrupo
                .DataSource = objdatos.consultagrupo
                .DataTextField = "grupo"
                .DataValueField = "grupo"
                .DataBind()
            End With
            objdatos.tipo = drlgrupo.SelectedItem.Value
            With drlsoporte
                .DataSource = objdatos.consultatsoportegrupo
                .DataTextField = "escenario"
                .DataValueField = "id"
                .DataBind()
            End With
            '*Catalogo de Servicio 3 drl
            'Tipo PQR
            objdatos.Validacion = "Tipo PQR"
            With drlTipo_PQR
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            'Tipo Cliente
            objdatos.Validacion = "Tipo Cliente"
            With drlTipo_Cliente
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            'Modalidad
            objdatos.Validacion = "Modalidad"
            With drlModalidad
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            '*CATALOGO DE DIAGNOSTICO
            'Segmento
            objdatos.Validacion = "Segmento"
            With drlSegmento
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipo"
                .DataValueField = "tipo"
                .DataBind()
            End With
            'Elemento
            objdatos.Validacion = "Elemento"
            objdatos.localidad = drlSegmento.SelectedItem.Text
            With drlElemento
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            'Tipo de falla
            objdatos.Validacion = "Tipo de falla"
            objdatos.localidad = drlSegmento.SelectedItem.Text
            objdatos.mun = drlElemento.SelectedItem.Text
            With drlTipo_De_Falla
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipificacion"
                .DataValueField = "tipificacion"
                .DataBind()
            End With
            'Causa raiz Inicial
            objdatos.Validacion = "Causa raiz Inicial"
            objdatos.localidad = drlSegmento.SelectedItem.Text
            objdatos.mun = drlElemento.SelectedItem.Text
            objdatos.nombre = drlTipo_De_Falla.SelectedItem.Text
            With drlCausa_Raiz
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
            '*CATEGORIA DE CIERRE
            'Categoria de cierre drl
            objdatos.Validacion = "Categoria de cierre"
            With drlCategoriaCierre
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipificacion"
                .DataValueField = "idreg"
                .DataBind()
            End With
            'Categoria de cierre lbl
            LblCategoriaCierre.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub rdbron_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdbron.SelectedIndexChanged
        Try
            lblvariable.Text = ""
            Dim objdatos As New clsgeneral
            If rdbron.SelectedItem.Value = "Error en Registro" Then
                objdatos.idusuario = 10
            End If
            If rdbron.SelectedItem.Value = "Ajeno a Red Celular" Then
                objdatos.idusuario = 11
            End If
            If rdbron.SelectedItem.Value = "Asociado Red Celular" Then
                objdatos.idusuario = 12
            End If
            With drlvariable
                .DataSource = objdatos.consultadiagnosticovoz
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drlbarrio_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlbarrio.SelectedIndexChanged
        txtbarrio.Text = drlbarrio.SelectedItem.Text
    End Sub

    Protected Sub LinkButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton5.Click
        Try
            If lblcaso.Text = "" Then
                lblmsg.Text = "Consulte el caso antes de generar una inconsistencia"
            Else
                Dim objdatos As New clsvoz
                objdatos.caso = lblcaso.Text
                If objdatos.Consultar_InconsistenciaVoz().Tables(0).Rows.Count > 0 Then
                    lblmsg.Text = "El caso  " + objdatos.caso + "  ya tiene reportada una inconsistencia"
                    Exit Sub
                End If
                Pninc.Visible = True
                Panel1.Visible = False
                pndiagnostico.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton6.Click
        Try
            Pninc.Visible = False
            Panel1.Visible = False
            pndiagnostico.Visible = True
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar1.Click
        Try
            Dim objdatos As New clsvoz
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
            objdatos.registroincvoz()
            lblmsg.Text = "Inconsistencia reportada con exito"
            cargadrlinc()
            txtobsinc.Text = ""
            Pninc.Visible = False
            Panel1.Visible = False
            pndiagnostico.Visible = True
            drlnivel.SelectedValue = "0"
            txt_registro_numerico.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drlgrupo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlgrupo.SelectedIndexChanged
        Try
            grupo()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub grupo()
        Try
            Dim objdatos As New clsgeneral
            objdatos.tipo = drlgrupo.SelectedItem.Value
            With drlsoporte
                .DataSource = objdatos.consultatsoportegrupo
                .DataTextField = "escenario"
                .DataValueField = "id"
                .DataBind()
            End With
            If drltipificacionll.SelectedItem.Text = "GESTIONADO" Then
                objdatos.tipo = drlgrupo.SelectedItem.Value
                objdatos.estado = "No Contactado"
                With drlsoporte
                    .DataSource = objdatos.consultatsoportegrupoRestriccion
                    .DataTextField = "escenario"
                    .DataValueField = "id"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub drlservicio_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlservicio.SelectedIndexChanged
        Try
            With drlpercep
                Dim objdatos As New clsgeneral
                objdatos.idusuario = drlservicio.SelectedItem.Text
                .DataSource = objdatos.consultadiagnosticovoztipif
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
       
    End Sub

    Protected Sub drlpercep_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlpercep.SelectedIndexChanged
        Try
            Dim objdatos As New clsvoz
            objdatos.diagservicio = drlpercep.SelectedItem.Value
            objdatos.consultaprocesovoz()
            lbltipificacion.Text = objdatos.tipificacion
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

   
    Protected Sub drlvariable_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlvariable.SelectedIndexChanged
        Try
            Dim objdatos As New clsvoz
            objdatos.diagservicio = drlvariable.SelectedItem.Value
            objdatos.consultaprocesovoz()
            lblvariable.Text = objdatos.tipificacion
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drlsoporte_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlsoporte.SelectedIndexChanged
        Try
            Dim objdatos As New clscrmdatos
            objdatos.tiposoporte = drlsoporte.SelectedItem.Value
            objdatos.consultacierrevoz()
            lblcierre.Text = objdatos.tipificacion
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnDesactivacion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDesactivacion.Click
        Try
            RdBtnUpgrade.Checked = False
            RdBtnBaja.Checked = False
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
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
    Protected Sub drllinea_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drllinea.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            'servicio
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.identidad = 20
            With drlservicio2
                .DataSource = objdatos.consultaservicio
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            'subservicio
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.mun = drlservicio2.SelectedItem.Text
            objdatos.identidad = 20
            With drlsubservicio
                .DataSource = objdatos.consultasubservicio
                .DataTextField = "tipificacion"
                .DataValueField = "tipificacion"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drlservicio2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlservicio2.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            'subservicio
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.mun = drlservicio2.SelectedItem.Text
            objdatos.identidad = 20
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
            objdatos.identidad = 20
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
            'solicitud
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.mun = drlservicio2.SelectedItem.Text
            objdatos.nombre = drlsubservicio.SelectedItem.Text
            objdatos.identidad = 20
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

    Protected Sub dtgasig_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgasig.PageIndexChanging
        Try
            dtgasig.PageIndex = e.NewPageIndex
            traeprogramados()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex
            buscarinf()
        Catch ex As Exception
            lblmsg.Text = "Se presentó error: " & ex.Message
        End Try
    End Sub

    Protected Sub dtgcoincidentes_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgcoincidentes.PageIndexChanging
        Try
            dtgcoincidentes.PageIndex = e.NewPageIndex
            buscarinf()
        Catch ex As Exception
            lblmsg.Text = "Se presentó error: " & ex.Message
        End Try
    End Sub

    Protected Sub drlSegmento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlSegmento.SelectedIndexChanged
        Try
            Dim ObjGeneral As New clsgeneral
            ObjGeneral.Validacion = "Elemento"
            ObjGeneral.localidad = drlSegmento.SelectedItem.Text
            With drlElemento
                .DataSource = ObjGeneral.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            If drlSegmento.SelectedItem.Text = "- Seleccione -" Then
                drlElemento_SelectedIndexChanged(1, Nothing)
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub

    Protected Sub drlElemento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlElemento.SelectedIndexChanged
        Try
            Dim ObjGeneral As New clsgeneral
            ObjGeneral.Validacion = "Tipo de falla"
            ObjGeneral.localidad = drlSegmento.SelectedItem.Text
            ObjGeneral.mun = drlElemento.SelectedItem.Text
            With drlTipo_De_Falla
                .DataSource = ObjGeneral.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipificacion"
                .DataValueField = "tipificacion"
                .DataBind()
            End With
            If drlElemento.SelectedItem.Text = "- Seleccione -" Then
                drlTipo_De_Falla_SelectedIndexChanged("1", Nothing)
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub

    Protected Sub drlTipo_De_Falla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlTipo_De_Falla.SelectedIndexChanged
        Try
            Dim ObjGeneral As New clsgeneral
            ObjGeneral.Validacion = "Causa raiz"
            If sender.ToString = "1" Then
                ObjGeneral.Validacion = "Causa raiz Inicial"
            End If
            ObjGeneral.localidad = drlSegmento.SelectedItem.Text
            ObjGeneral.mun = drlElemento.SelectedItem.Text
            ObjGeneral.nombre = drlTipo_De_Falla.SelectedItem.Text
            With drlCausa_Raiz
                .DataSource = ObjGeneral.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub

    Protected Sub drlCategoriaCierre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlCategoriaCierre.SelectedIndexChanged
        Try
            Dim ObjGeneral As New clsgeneral
            'Categoria de cierre lbl
            ObjGeneral.Validacion = "Categoria de cierre lbl"
            ObjGeneral.nombre = drlCategoriaCierre.SelectedItem.Text
            If drlCategoriaCierre.SelectedItem.Text <> "- Seleccione -" Then
                LblCategoriaCierre.Text = ObjGeneral.Consulta_Cargue_Catalogo_Servicio_V2.Tables(0).Rows(0).Item("detalle")
            Else
                LblCategoriaCierre.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub
    ''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''Carga'''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''
    Protected Sub Btn_Habilita_Tecnologia_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Habilita_Tecnologia.Click
        Try
            drlFtectolog.Enabled = True
            Btn_Habilita_Tecnologia.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Habilita_Equipo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Habilita_Equipo.Click
        Try
            drlmarca.Enabled = True
            drlequipo.Enabled = True
            Btn_Habilita_Equipo.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Habilita_Municipio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Habilita_Municipio.Click
        Try
            drldpto.Enabled = True
            drlmun.Enabled = True
            Btn_Habilita_Municipio.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Habilita_Barrio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Habilita_Barrio.Click
        Try
            drlbarrio.Enabled = True
            drllocalidad.Enabled = True
            Btn_Habilita_Barrio.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Habilita_Fc_Utl_Caida_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Habilita_Fc_Utl_Caida.Click
        Try
            txtultimc.Enabled = True
            drlfranja.Enabled = True
            Btn_Habilita_Fc_Utl_Caida.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Habilita_PQR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Habilita_PQR.Click
        Try
            TxtPQR.Enabled = True
            Btn_Habilita_PQR.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub
    Public Sub Limpia_Herramientas_Cargadas()
        Try
            drlFtectolog.SelectedValue = "58"
            drlFtectolog.Enabled = True
            drlmarca.SelectedValue = "- Seleccione -"
            drlmarca.Enabled = True
            drlmarca_SelectedIndexChanged(1, Nothing)
            drlequipo.Enabled = True
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
            drlTipo_Cliente.SelectedValue = "- Seleccione -"
            drlTipo_Cliente.Enabled = True
            drlModalidad.SelectedValue = "- Seleccione -"
            drlModalidad.Enabled = True
            drl611.SelectedValue = "1"
            drl611.Enabled = True
            TxtPQR.Text = ""
            TxtPQR.Enabled = True
            Btn_Habilita_Tecnologia.Visible = False
            Btn_Habilita_Equipo.Visible = False
            Btn_Habilita_Municipio.Visible = False
            Btn_Habilita_Barrio.Visible = False
            Btn_Habilita_Fc_Utl_Caida.Visible = False
            Btn_Habilita_PQR.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Public Sub Limpia_Herramientas()
        Try
            '''''''''''''''''''' LIMPIA HERRAMIENTAS ''''''''''''''''''''
            Lblfc_ingreso.Text = ""
            lblcliente.Text = ""
            lbldocumento.Text = ""
            lblmin.Text = ""
            lblequipo.Text = ""
            lblcaso.Text = ""
            lblobs611.Text = ""
            lblestado.Text = ""
            txtobs.Text = ""
            txtnumalt.Text = ""
            lblmesa.Text = ""
            lblctrl.Text = "0"
            lblfallatec.Text = ""
            drllocalidad.SelectedValue = "- Seleccione -"
            drllocalidad_SelectedIndexChanged(1, Nothing)
            drlfallatec.SelectedValue = "0"
            chknvoformato.Checked = False
            drlIntalaApp.SelectedValue = "1"
            drlMotivo.SelectedValue = "1"
            drlmesa.SelectedValue = "- Seleccione -"
            drlmesa.SelectedValue = "- Seleccione -"
            drl611.SelectedValue = "0"
            chksolucion.Checked = False
            chkajuste.Checked = False
            txtmonto.Text = ""
            drlfallatec.SelectedItem.Value = "0"
            chknvoformato.Checked = False
            lblcierre.Text = ""
            '' GEORREFERENCIACIÓN ''
            drlFtectolog.SelectedValue = 58
            drlmarca.SelectedValue = "- Seleccione -"
            drlmarca_SelectedIndexChanged(1, Nothing)
            drldpto.SelectedValue = 0
            drldpto_SelectedIndexChanged(1, Nothing)
            txtbarrio.Text = ""
            txtultimc.Text = ""
            drlfranja.SelectedValue = 0
            '' VOZ DEL CLIENTE ''
            drlTipo_PQR.SelectedValue = "- Seleccione -"
            drlTipo_Cliente.SelectedValue = "- Seleccione -"
            drlModalidad.SelectedValue = "- Seleccione -"
            drllinea.SelectedValue = "- Seleccione -"
            drllinea_SelectedIndexChanged(1, Nothing)
            drlservicio2_SelectedIndexChanged(1, Nothing)
            drlsubservicio_SelectedIndexChanged(1, Nothing)
            '' CATALOGO DE DIAGNOSTICO ''
            drlSegmento.SelectedValue = "- Seleccione -"
            drlSegmento_SelectedIndexChanged(1, Nothing)
            drlElemento_SelectedIndexChanged(1, Nothing)
            drlTipo_De_Falla_SelectedIndexChanged(1, Nothing)
            drlvariable.SelectedItem.Text = "- Seleccione -"
            lblvariable.Text = ""
            '' SEGUIMIENTO ''
            txtnumalt.Text = ""
            '' CIERRE DE LLAMADA ''
            drltipificacionll.SelectedValue = "- Seleccione -"
            TxtMinuto_Llamada.Text = ""
            TxtFcProgramado.Text = ""
            TxtHora_Llamada.Text = ""
            drlCategoriaCierre.SelectedValue = 428
            LblCategoriaCierre.Text = ""
            drltipificacionll_SelectedIndexChanged(1, Nothing)
            drlgrupo_SelectedIndexChanged(1, Nothing)
            drlpercep_SelectedIndexChanged(1, Nothing)
            drltsoporte.SelectedValue = 25
            TxtPQR.Text = ""
            '' ENCUESTAS ''
            drlIntalaApp.SelectedValue = 1
            drlMotivo.SelectedValue = 1
            ' TxtClientId.Text = ""
            drl611.SelectedValue = 1
            '' OBSERVACIÓN ''
            txtobs.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    ''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''Fin Carga'''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedIndexChanged
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
End Class