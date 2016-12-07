Public Class Resolved
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If

            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Seguimiento Faclletec - Fallas de Red"
                Cargar_DRLS()
                Consulta_Control_Escala()

            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Cargar_DRLS()
        Dim objdatos As New clsgeneral
        Dim objvoz As New clsvoz
        With drlestadocpd
            .DataSource = objdatos.consultaestadocpd
            .DataTextField = "estadocpd"
            .DataValueField = "idestadocpd"
            .DataBind()
        End With
        objdatos.Validacion = "Estado_Cliente"
        With drlrespuesta
            .DataSource = objdatos.consultaestadocpd
            .DataTextField = "Nombre"
            .DataValueField = "Cod_BD_Voz_Complemento"
            .DataBind()
        End With
        ''''Categoria Cierre'''
        With drlCategoria
            .DataSource = objvoz.CategoriacierreCPD_inbound
            .DataTextField = "tipificacion1"
            .DataValueField = "cod_tipificacion"
            .DataBind()
        End With
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clsvoz
        Try
            If lblEstado_remedy.Text = "Cerrado" And lblestadocpd.Text = "Cerrado" Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span>Este caso ya se encuentra cerrado"
                Exit Sub
            End If
            If lblestadocpd.Text <> "Cerrado" Then
                If txtcaso.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Digite el caso que desea registrar"
                    Exit Sub
                Else
                    objdatos.caso = txtcaso.Text
                End If
                If drlestadocpd.SelectedItem.Value = "0" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Elija el estado del CPD"
                    Exit Sub
                Else
                    objdatos.estadoinc = drlestadocpd.SelectedItem.Text
                End If
                ''''''''''''''''Nuevo Cierre CPD''''''''''''''''
                If drlestadocpd.SelectedItem.Text = "Cerrado" Then
                    If drlrespuesta.SelectedItem.Text = "- Seleccione -" Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Seleccione una opcion en respuesta"
                        Exit Sub
                    Else
                        objdatos.Respuesta = drlrespuesta.SelectedItem.Text
                    End If
                    If drlSoluciono_falla.SelectedItem.Text = "- Seleccione -" Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Seleccione si se soluciono la falla"
                        Exit Sub
                    Else
                        objdatos.Falla_solucionada = drlSoluciono_falla.SelectedItem.Text
                    End If
                    If drlestado_cliente.Text = "- Seleccione -" Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Seleccione una opcion en estado del cliente"
                        Exit Sub
                    Else
                        objdatos.Estado_Cliente = drlestado_cliente.SelectedItem.Text
                    End If
                    If drlubicacion_falla.SelectedItem.Text = "- Seleccione -" Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Seleccione una opcion en cliente en la misma ubicacion falla "
                        Exit Sub
                    Else
                        objdatos.Cliente_Misma_Ubicacion_Falla = drlubicacion_falla.SelectedItem.Text
                    End If
                    If drlmis_zona.SelectedItem.Text = "- Seleccione -" Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Seleccione una opcion en CPD's Mismo Min"
                        Exit Sub
                    Else
                        objdatos.CPD_Mismo_Min_Zona = drlmis_zona.SelectedItem.Text
                        If drlmis_zona.SelectedItem.Text = "SI" Then
                            If drlcantidad.SelectedItem.Text = "- Seleccione -" Then
                                Pnl_Message.CssClass = "alert alert-warning"
                                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Seleccine un numero en el campo Cuantos"
                                Exit Sub
                            Else
                                objdatos.CPD_Mismo_Min_Zona_Can = drlcantidad.SelectedItem.Text
                            End If
                        Else
                            objdatos.CPD_Mismo_Min_Zona_Can = "0"
                        End If
                    End If
                    If drlCategoria.SelectedItem.Text = "- Seleccione -" Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Seleccione una categoria para el CPD"
                        Exit Sub
                    Else
                        objdatos.Categoria_Cierre = drlCategoria.SelectedValue
                    End If
                Else
                    objdatos.Respuesta = ""
                    objdatos.Falla_solucionada = ""
                    objdatos.Estado_Cliente = ""
                    objdatos.Cliente_Misma_Ubicacion_Falla = ""
                    objdatos.CPD_Mismo_Min_Zona = ""
                    objdatos.CPD_Mismo_Min_Zona_Can = ""
                End If
                If txtobs.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Digite la observación de seguimiento al CPD"
                    Exit Sub
                End If
                If lblfallatec.Text <> " " Then
                    If drlfallatec.SelectedItem.Value = "0" Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>El caso fue reportado como Fallatec, elija el estado actual del fallatec"
                        Exit Sub
                    End If
                End If
                If drlestadocpd.SelectedItem.Text = "Cerrado" Then
                    objdatos.Estado_linea = "CerradoCRM"
                ElseIf drlestadocpd.SelectedItem.Text = "Asignado" Or drlestadocpd.SelectedItem.Text = "En Curso" Or drlestadocpd.SelectedItem.Text = "Pendiente" Or drlestadocpd.SelectedItem.Text = "Reportado" Then
                    objdatos.Estado_linea = "Pendiente"
                End If
                If Session("VALIDACION") = "True" Then
                    If txtvereda.Text = "" Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Escriba una vereda para actualizar"
                        Exit Sub
                    End If
                End If
                guardacrm()
                objdatos.actualizaestadocpd()
                If lblfallatec.Text <> " " Then
                    actfallatec()
                End If
                If drlestadocpd.SelectedItem.Value = 1 Or drlestadocpd.SelectedItem.Value = 2 Then
                    actbandeja()
                End If
              
                actualizar()
                Dim objGeneral As New clsgeneral
                objGeneral.identidad = txtcaso.Text
                objGeneral.Validacion = "Control_Llamada"
                objGeneral.Actualizacion_Escalado()
                Consulta_Control_Escala()
            ElseIf (lblestadocpd.Text = "Cerrado" And lblEstado_remedy.Text <> "Cerrado") Then
                If drl_estado_remedy.SelectedItem.Text = "- Seleccione -" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Seleccione una opcion en Estado Remedy"
                    Exit Sub
                End If
                objdatos.Estado_linea = drl_estado_remedy.SelectedItem.Text
                objdatos.caso = lblcaso.Text
                Dim fc As DateTime
                fc = Now
                objdatos.fcfin = fc
                objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                objdatos.Actualizar_Estado_Vfallared()
            End If
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span>Seguimiento ingresado con éxito"
            lblcaso.Text = ""
            lblcliente.Text = ""
            Lbl_N_Doc_Id.Text = Nothing
            lbltelcontacto.Text = ""
            lbltiempo.Text = ""
            lbltipof.Text = ""
            lblcaract.Text = ""
            drldpto.Items.Clear()
            drldpto.Enabled = False
            drlmun.Items.Clear()
            drlmun.Enabled = False
            txtvereda.Text = ""
            txtvereda.Enabled = False
            txtdir.Text = ""
            txtdir.Enabled = False
            txtbarrio.Text = ""
            txtbarrio.Enabled = False
            lbltecnologia.Text = ""
            lblequipo.Text = ""
            lblmaslineas.Text = ""
            lblobs.Text = ""
            drlestadocpd.SelectedValue = "0"
            drlfallatec.SelectedValue = "0"
            txtobs.Text = ""
            lblestadocpd.Text = ""
            lblfallatec.Text = ""
            txtcaso.Text = ""
            lblcampana.Text = ""
            lblapn.Text = ""
            lblCPD.Text = ""
            Pnl_Cierre.Visible = False
            Pnl_Gestion.Visible = True
            drl_estado_remedy.SelectedIndex = 0
            Pnl_remedy.Visible = False
            lblEstado_remedy.Text = ""
            ''Cierre cpd
            drlrespuesta.SelectedValue = "0"
            drlSoluciono_falla.SelectedValue = "0"
            drlestado_cliente.SelectedValue = "0"
            drlubicacion_falla.SelectedValue = "0"
            drlmis_zona.SelectedValue = "0"
            drlcantidad.SelectedValue = "0"
            Pnl_drlcantidad.Visible = False
            Session("Dtg_Gestiones") = Nothing
            Dtg_Gestiones.DataSource = Session("Dtg_Gestiones")
            Dtg_Gestiones.DataBind()
            Lbl_Cuenta3.Text = ""
            '----Categoria Cierre----'
            drlCategoria.SelectedValue = "0"
            ''''Validaciones servicio al cliente
            Lbl_Validacion_Coordenadas.Text = ""

            Consulta_Control_Escala()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Sub buscarinf()
        Try
            Dim objdatos As New clsvoz
            objdatos.caso = txtcaso.Text
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            If lblcampana.Text = "Datos" Or lblcampana.Text = "BSCS" Then
                objdatos.consultaresolveddatos()
                'Nuevo Fideliza'
            ElseIf lblcampana.Text = "DATOS" Or lblcampana.Text = "VOZ" Then
                objdatos.consultaresolveddesactivacion()
                'Fin'
            ElseIf lblcampana.Text = "INBOUND" Then
                objdatos.Consulta_Resolved_Inbound()
            Else
                objdatos.consultaresolveduxu()
            End If
            If objdatos.cantidad > 0 Then
                lblcaso.Text = objdatos.caso
                lblcliente.Text = objdatos.cliente
                Lbl_N_Doc_Id.Text = objdatos.N_Doc_Id
                lbltelcontacto.Text = objdatos.telcontacto
                lbltiempo.Text = objdatos.tiempo
                lbltipof.Text = objdatos.tipofalla
                lblcaract.Text = objdatos.caracter
                drldpto.SelectedValue = objdatos.dpto.ToUpper
                Dim objGeneral As New clsgeneral
                'Municipio
                objGeneral.dpto = drldpto.SelectedItem.Value
                With drlmun
                    objGeneral.Validacion = "Resolved"
                    .DataSource = objGeneral.consultamun
                    .DataTextField = "nombremun"
                    .DataValueField = "nombremun"
                    .DataBind()
                End With
                drlmun.SelectedValue = objdatos.mun
                txtvereda.Text = objdatos.vereda
                txtdir.Text = objdatos.dir
                txtbarrio.Text = objdatos.barrio
                lbltecnologia.Text = objdatos.tecnologia
                lblequipo.Text = objdatos.equipo
                lblmaslineas.Text = objdatos.maslineas
                lblobs.Text = objdatos.obs
                lblCPD.Text = objdatos.cpd
                lblEstado_remedy.Text = objdatos.Estado_linea
                Pnl_Message.CssClass = Nothing
                lblmsg.Text = Nothing
                lblestadocpd.Text = objdatos.estadoinc
                If lblcampana.Text = "Voz" Then
                    lblfallatec.Text = objdatos.fallatec
                End If
                drlestadocpd.SelectedValue = "0"
                lblcampana.Text = objdatos.campana
                lblapn.Text = objdatos.apn
                ''''Validaciones servicio al cliente
                Lbl_Validacion_Coordenadas.Text = objdatos.Validacion_Coordenadas
                txtobs.Text = ""
                txtbarrio.Enabled = False
                txtdir.Enabled = False
                txtvereda.Enabled = False
                drldpto.Enabled = False
                drlmun.Enabled = False
            Else
                lblcaso.Text = ""
                lblcliente.Text = ""
                Lbl_N_Doc_Id.Text = Nothing
                lbltelcontacto.Text = ""
                lbltiempo.Text = ""
                lbltipof.Text = ""
                lblcaract.Text = ""
                drldpto.Items.Clear()
                drlmun.Items.Clear()
                txtvereda.Text = ""
                txtdir.Text = ""
                txtbarrio.Text = ""
                lbltecnologia.Text = ""
                lblequipo.Text = ""
                lblmaslineas.Text = ""
                lblobs.Text = ""
                lblfallatec.Text = ""
                lblestadocpd.Text = ""
                lblcampana.Text = ""
                lblapn.Text = ""
                lblCPD.Text = objdatos.cpd
                ''''Validaciones servicio al cliente
                Lbl_Validacion_Coordenadas.Text = ""
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>El caso no existe o no se ha reportado escalamiento o no se ha reportado CPD, verifique"
            End If
            If lblestadocpd.Text = "Cerrado" And lblEstado_remedy.Text <> "cerrado" Then
                Pnl_Gestion.Visible = False
                Pnl_remedy.Visible = True
            Else
                Pnl_Gestion.Visible = True
                Pnl_remedy.Visible = False
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            Dim objdatos As New clsvoz
            If txtcaso.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Digite el caso que desea consultar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
                objdatos.consultacamapana()
                If objdatos.cantidad = 0 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>No existen registros coincidentes para ese caso, revise la información"
                    lblcaso.Text = ""
                    lblcliente.Text = ""
                    Lbl_N_Doc_Id.Text = Nothing
                    lbltelcontacto.Text = ""
                    lbltiempo.Text = ""
                    lbltipof.Text = ""
                    lblcaract.Text = ""
                    drldpto.Items.Clear()
                    drlmun.Items.Clear()
                    txtvereda.Text = ""
                    txtdir.Text = ""
                    txtbarrio.Text = ""
                    lbltecnologia.Text = ""
                    lblequipo.Text = ""
                    lblmaslineas.Text = ""
                    lblobs.Text = ""
                    lblfallatec.Text = ""
                    lblestadocpd.Text = ""
                    lblcampana.Text = ""
                    lblapn.Text = ""
                    lblCPD.Text = ""
                    ''''Validaciones servicio al cliente
                    Lbl_Validacion_Coordenadas.Text = ""
                    Exit Sub
                Else
                    lblcampana.Text = objdatos.campana
                    Dim objfallatec As New clscrmdatos
                    If lblcampana.Text = "Datos" Then
                        objfallatec.caso = txtcaso.Text
                        objfallatec.consultacaso()
                        If objfallatec.cantidad > 0 Then
                            lblfallatec.Text = objfallatec.fallatec
                        End If
                    End If
                    Dim objGeneral As New clsgeneral
                    With drldpto
                        objGeneral.idtip = 1
                        .DataSource = objGeneral.consultadpto
                        .DataTextField = "nombredpto"
                        .DataValueField = "nombredpto"
                        .DataBind()
                    End With
                    buscarinf()
                    objGeneral.nombre = lblCPD.Text
                    objGeneral.consultar_Respuesta_CPD()
                    Lbl_Respuesta.Text = objGeneral.nombreut
                    objGeneral.Cod_Diagnostico = txtcaso.Text
                    objdatos.caso = txtcaso.Text
                    objdatos.Validacion = "DILO"
                    objdatos.consultacamapana()
                    If objdatos.cantidad <> "" And objdatos.cantidad <> " " Then
                        objGeneral.Validacion = "DILO"
                        Session("Dtg_Gestiones") = objGeneral.Consultar_Gestiones_Resolved()
                    Else
                        If lblcampana.Text = "Datos" Or lblcampana.Text = "BSCS" Then
                            objGeneral.Validacion = "DATOS"
                            Session("Dtg_Gestiones") = objGeneral.Consultar_Gestiones_Resolved()
                        ElseIf lblcampana.Text = "DATOS" Or lblcampana.Text = "VOZ" Then
                            objGeneral.Validacion = "DESACTIVACION"
                            Session("Dtg_Gestiones") = objGeneral.Consultar_Gestiones_Resolved()
                        ElseIf lblcampana.Text = "INBOUND" Then
                            objGeneral.Validacion = "INBOUND"
                            Session("Dtg_Gestiones") = objGeneral.Consultar_Gestiones_Resolved()
                        Else
                            objGeneral.Validacion = ""
                        End If
                    End If
                    If objGeneral.cantreg <> Nothing Then
                        If objGeneral.cantreg > 0 Then
                            Dtg_Gestiones.DataSource = Session("Dtg_Gestiones")
                            Dtg_Gestiones.DataBind()
                            Lbl_Cuenta3.Text = "Gestiones registradas: " & objGeneral.cantreg
                        Else
                            Session("Dtg_Gestiones") = Nothing
                            Dtg_Gestiones.DataSource = Session("Dtg_Gestiones")
                            Dtg_Gestiones.DataBind()
                            Lbl_Cuenta3.Text = ""
                        End If
                    Else
                        Session("Dtg_Gestiones") = Nothing
                        Dtg_Gestiones.DataSource = Session("Dtg_Gestiones")
                        Dtg_Gestiones.DataBind()
                        Lbl_Cuenta3.Text = ""
                    End If
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub guardacrm()
        Dim objdatos As New clsvoz
        Try
            objdatos.caso = txtcaso.Text
            If drlestadocpd.SelectedItem.Text = "Cerrado" Then
                objdatos.tipificacion = "Cerrado Tecnica"
            Else
                objdatos.tipificacion = drlestadocpd.SelectedItem.Text
            End If
            objdatos.obs = txtobs.Text
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.Validacion = "DILO"
            objdatos.consultacamapana()
            If objdatos.cantidad <> " " Then
                objdatos.registrocrmfallareddilo()
            Else
                If lblcampana.Text = "Datos" Or lblcampana.Text = "BSCS" Then
                    objdatos.registrocrmfallareddatos()
                ElseIf lblcampana.Text = "DATOS" Or lblcampana.Text = "VOZ" Then
                    Dim Obj_Fideliza As New clscrmdatos
                    Obj_Fideliza.caso = txtcaso.Text
                    Obj_Fideliza.Validacion = "Fidelizacion"
                    If Obj_Fideliza.Validacion_Registro_Inboun.Tables(0).Rows.Count > 0 Then
                        objdatos.caso = Obj_Fideliza.min
                    End If
                    objdatos.registrocrmfallaredFideiza()
                ElseIf lblcampana.Text = "INBOUND" Then
                    objdatos.preg2 = "Tecnica"
                    If drlestadocpd.SelectedItem.Text = "Cerrado" Then
                        objdatos.Validacion = "Diagnostico"
                        objdatos.Categoria_Cierre = drlCategoria.SelectedValue
                        objdatos.registro_CRM_inbound_escalamiento()
                    Else
                        objdatos.Validacion = ""
                        objdatos.registro_CRM_inbound_escalamiento()
                    End If
                Else
                    objdatos.registrocrmfallared()
                End If
            End If
            guardadiagnostico()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span>Seguimiento ingresado con éxito"
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub guardadiagnostico()
        Dim objdatos As New clsvoz
        Try
            objdatos.caso = txtcaso.Text
            objdatos.Categoria_Cierre = drlCategoria.SelectedValue
            If drlestadocpd.SelectedItem.Text = "Cerrado" Then
                objdatos.tipificacion = "Cerrado Tecnica"
                objdatos.Validacion = "DILO"
                objdatos.consultacamapana()
                If objdatos.cantidad <> " " Then
                    objdatos.Validacion = "Diagnostico"
                    objdatos.registrocrmfallareddilo()
                Else
                    If lblcampana.Text = "Datos" Or lblcampana.Text = "BSCS" Then
                        objdatos.Validacion = "Diagnostico"
                        objdatos.registrocrmfallareddatos()
                    ElseIf lblcampana.Text = "DATOS" Or lblcampana.Text = "VOZ" Then
                        Dim Obj_Fideliza As New clscrmdatos
                        Obj_Fideliza.caso = txtcaso.Text
                        Obj_Fideliza.Validacion = "Fidelizacion"
                        If Obj_Fideliza.Validacion_Registro_Inboun.Tables(0).Rows.Count > 0 Then
                            objdatos.caso = Obj_Fideliza.min
                        Else
                            objdatos.caso = 0
                        End If
                        objdatos.Validacion = "Diagnostico"
                        objdatos.registrocrmfallaredFideiza()
                    Else
                        objdatos.Validacion = "Diagnostico"
                        objdatos.registrocrmfallared()
                    End If
                End If
            End If
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span>Seguimiento ingresado con éxito"
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Sub actbandeja()
        Try
            Dim objdatos As New clsvoz
            objdatos.caso = txtcaso.Text
            objdatos.Validacion = "DILO"
            objdatos.consultacamapana()
            If objdatos.cantidad <> " " Then
                '---Dilo---'
                objdatos.tipificacion = "Cerrado Tecnica"
                objdatos.modificarbandejafallaDilo()
            Else
                If lblcampana.Text = "Datos" Or lblcampana.Text = "BSCS" Then
                    '---Datos---'
                    objdatos.modificarbandejafalladatos()
                ElseIf lblcampana.Text = "DATOS" Or lblcampana.Text = "VOZ" Then
                    '---Fideliza---'
                    objdatos.tipificacion = "Cerrado Tecnica"
                    objdatos.modificarbandejafallaFideliza()
                ElseIf lblcampana.Text = "INBOUND" Then
                    objdatos.Nombre = "Cerrado Tecnica"
                    objdatos.Validacion = "INBOUND"
                    objdatos.Modificar_Bandejas_Estado_Escalado()
                Else
                    '---Voz---'
                    objdatos.modificarbandejafalla()
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Sub actfallatec()
        Try
            Dim objdatos As New clsvoz
            objdatos.caso = txtcaso.Text
            objdatos.estadoinc = drlfallatec.SelectedItem.Value
            If lblcampana.Text = "Datos" Then
                objdatos.modificarfallatecfrdatos()
            Else
                objdatos.modificarfallatecfr()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub drlmin_zona_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlmis_zona.SelectedIndexChanged
        Try
            If drlmis_zona.SelectedItem.Text = "SI" Then
                Pnl_drlcantidad.Visible = True
            ElseIf drlmis_zona.SelectedItem.Text = "NO" Then
                Pnl_drlcantidad.Visible = False
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Sub Consulta_Control_Escala()
        Try
            Dim objGeneral As New clsgeneral
            objGeneral.idusuario = CType(Session("permisos"), clsusuario).usuario
            objGeneral.nombre = "Tecnica"
            Session("Control") = objGeneral.Consulta_Control()
            dtggeneral2.DataSource = Session("Control")
            dtggeneral2.DataBind()
            Lbl_Cuenta2.Text = objGeneral.cantreg
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub dtggeneral2_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtggeneral2.RowCommand
        Try
            If e.CommandName = "Seleccion" Then
                Dim objGeneral As New clsgeneral
                Dim ObjVoz As New clsvoz
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                txtcaso.Text = dtggeneral2.Rows(index).Cells(1).Text
                Button1_Click(1, Nothing)
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub drlestadocpd_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlestadocpd.SelectedIndexChanged
        Try
            If drlestadocpd.SelectedItem.Text = "Cerrado" Then
                Pnl_Cierre.Visible = True
                drlrespuesta.SelectedIndex = 0
                drlSoluciono_falla.SelectedIndex = 0
                drlestado_cliente.SelectedIndex = 0
                drlubicacion_falla.SelectedIndex = 0
                drlmis_zona.SelectedIndex = 0
                drlcantidad.SelectedIndex = 0
            Else
                Pnl_Cierre.Visible = False
                drlrespuesta.SelectedIndex = 0
                drlSoluciono_falla.SelectedIndex = 0
                drlestado_cliente.SelectedIndex = 0
                drlubicacion_falla.SelectedIndex = 0
                drlmis_zona.SelectedIndex = 0
                drlcantidad.SelectedIndex = 0
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub drldpto_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drldpto.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.dpto = drldpto.SelectedItem.Value
            With drlmun
                objdatos.Validacion = "Resolved"
                .DataSource = objdatos.consultamun
                .DataTextField = "nombremun"
                .DataValueField = "nombremun"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub btnactualizaDepar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnactualizaDepar.Click
        Try
            drlmun.Enabled = True
            drldpto.Enabled = True
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub btnActualizadireccion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnActualizadireccion.Click
        Try
            Session("VALIDACION") = Nothing
            txtbarrio.Enabled = True
            txtdir.Enabled = True
            txtvereda.Enabled = True
            If txtvereda.Text <> "" Then
                Session("VALIDACION") = "True"
            Else
                Session("VALIDACION") = "False"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Public Sub actualizar()
        Try
            Dim objVoz As New clsvoz
            '--------------Municipio---------------
            If drlmun.Enabled = True Then
                If drlmun.SelectedItem.Text = "- SELECCIONE -" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Seleccione un municipio para actualizar"
                    Exit Sub
                Else
                    objVoz.dpto = drldpto.SelectedValue
                    objVoz.mun = drlmun.SelectedValue
                End If
            Else
                objVoz.dpto = drldpto.SelectedValue
                objVoz.mun = drlmun.SelectedValue
            End If

            If txtbarrio.Enabled = True Then
                '--------------Barrio---------------
                If txtbarrio.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Escriba barrio para actualizar"
                    Exit Sub
                Else
                    objVoz.barrio = txtbarrio.Text
                End If
                '--------------Direccion---------------
                If txtdir.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Escriba una direccion para actualizar"
                    Exit Sub
                Else
                    objVoz.dir = txtdir.Text
                End If
                If txtvereda.Text <> "" Then
                    objVoz.vereda = txtvereda.Text
                Else
                    objVoz.vereda = ""
                End If
            Else
                objVoz.barrio = txtbarrio.Text
                objVoz.dir = txtdir.Text
                objVoz.vereda = txtvereda.Text
            End If
            objVoz.caso = txtcaso.Text
            '---------Actualiza Bandeja-----------
            objVoz.Validacion = "VFALLA"
            objVoz.ActualizarFallaRed()
            '----------------Actualiza Detalle---------------
            ''Consulta dilo''
            objVoz.Validacion = "DILO"
            objVoz.consultacamapana()
            If objVoz.cantidad <> " " Then
                '---Dilo---'
                objVoz.Validacion = "DILO"
            Else
                '---Datos---'
                If lblcampana.Text = "Datos" Or lblcampana.Text = "BSCS" Then
                    objVoz.Validacion = "DATOS"
                    ''---Nuevo fideliza---''
                ElseIf lblcampana.Text = "DATOS" Or lblcampana.Text = "VOZ" Then
                    Dim Obj_Fideliza As New clscrmdatos
                    Obj_Fideliza.caso = txtcaso.Text
                    Obj_Fideliza.Validacion = "Fidelizacion"
                    If Obj_Fideliza.Validacion_Registro_Inboun.Tables(0).Rows.Count > 0 Then
                        objVoz.caso = Obj_Fideliza.min
                        objVoz.Validacion = "FALLA DES"
                    End If
                End If
            End If
            objVoz.ActualizarFallaRed()
            Session("VALIDACION") = Nothing
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Dtg_General_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral2.PageIndexChanging
        Try
            dtggeneral2.PageIndex = e.NewPageIndex
            dtggeneral2.DataSource = Session("Control")
            dtggeneral2.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class