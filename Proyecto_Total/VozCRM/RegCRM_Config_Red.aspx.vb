Public Class RegCRM_Config_Red
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
                Cargardrl()

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
    Private Sub Llenar_Grid()
        Dim objvoz As New clsvoz
        objvoz.caso = txtcaso.Text
        dtggestiones.DataSource = objvoz.cargar_gestiones()
        dtggestiones.DataBind()
        lblcuenta.Text = objvoz.cantidad
    End Sub
    Sub Cargardrl()
        Dim objgnrl As New clsgeneral
        'Departamento
        With drldpto
            .DataSource = objgnrl.consultadpto
            .DataTextField = "nombredpto"
            .DataValueField = "coddpto"
            .DataBind()
        End With
        'Municipio
        objgnrl.dpto = drldpto.SelectedItem.Value
        With drlmun
            .DataSource = objgnrl.consultamun
            .DataTextField = "nombremun"
            .DataValueField = "coddiv"
            .DataBind()
        End With
        '---Resultado Contacto---'
        With drlresultado
            .DataSource = objgnrl.Consulta_Configuracion_Red()
            .DataTextField = "tipificacion1"
            .DataValueField = "cod_tipificacion"
            .DataBind()
        End With
        '---Resultado configuracion---'
        With Drlresultado_config
            objgnrl.Cod_Diagnostico = drlresultado.SelectedValue
            objgnrl.Validacion = "Config"
            .DataSource = objgnrl.Consulta_Configuracion_Red()
            .DataTextField = "tipificacion1"
            .DataValueField = "cod_tipificacion"
            .DataBind()
        End With
        'Marca
        With drlmarca
            .DataSource = objgnrl.consultamarca
            .DataTextField = "marca"
            .DataValueField = "marca"
            .DataBind()
        End With
        'Equipo
        objgnrl.estado = drlmarca.SelectedItem.Value
        With drlequipo
            .DataSource = objgnrl.consultaequipo
            .DataTextField = "equipo"
            .DataValueField = "equipo"
            .DataBind()
        End With
    End Sub
    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim objvoz As New clsvoz
            If txtcaso.Text = "" Then
                lblmsg.Text = "Ingrese un caso para consultar"
                Exit Sub
            Else
                objvoz.caso = txtcaso.Text
                objvoz.ConsultaConfiguracionRed()
                If objvoz.cantidad > 0 Then
                    Llenar_Grid()

                    lblcaso.Text = objvoz.caso
                    lblcliente.Text = objvoz.cliente
                    lblmin.Text = objvoz.min
                    Lbldepartamento.Text = objvoz.dpto
                    Lblmunicipio.Text = objvoz.mun
                    Lbltipolinea.Text = objvoz.Tipo_linea
                    LblEstado_linea.Text = objvoz.Estado_Cliente
                    lblresultado.Text = objvoz.Respuesta
                    Lblfc_ingreso.Text = objvoz.fcini
                    lblEquipo.Text = objvoz.equipo
                    lblcampaña.Text = objvoz.campana
                    lblCorporativo.Text = objvoz.Corporativo
                    lblmin_alterno.Text = objvoz.Num_Intento
                    lblmsg.Text = ""
                    If lblresultado.Text = "Efectivo" Then
                        lblmsg.Text = "Este caso ya se encuentra Efectivo , no podra realizar gestion sobre el"
                    End If

                Else

                    lblcaso.Text = " "
                    lblcliente.Text = " "
                    lblmin.Text = " "
                    Lbldepartamento.Text = " "
                    Lblmunicipio.Text = " "
                    Lbltipolinea.Text = " "
                    LblEstado_linea.Text = " "
                    lblresultado.Text = " "
                    Lblfc_ingreso.Text = " "
                    lblEquipo.Text = " "
                    lblcampaña.Text = " "
                    lblcuenta.Text = ""
                    lblCorporativo.Text = " "
                    lblmin_alterno.Text = " "
                    dtggestiones.DataSource = Nothing
                    dtggestiones.DataBind()
                    lblmsg.Text = "No se encontraron registros"
                End If
            End If

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drlresultado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlresultado.SelectedIndexChanged
        Try
            Dim objgnrl As New clsgeneral
            '---Resultado configuracion---'
            With Drlresultado_config
                objgnrl.Cod_Diagnostico = drlresultado.SelectedValue
                objgnrl.Validacion = "Config"
                .DataSource = objgnrl.Consulta_Configuracion_Red()
                .DataTextField = "tipificacion1"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drldpto_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drldpto.SelectedIndexChanged
        Try
            Dim objgnrl As New clsgeneral
            '---Municipio--'
            objgnrl.dpto = drldpto.SelectedItem.Value
            With drlmun
                .DataSource = objgnrl.consultamun
                .DataTextField = "nombremun"
                .DataValueField = "coddiv"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_Guardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Guardar.Click
        Try
            Dim objvoz As New clsvoz
            If lblcaso.Text = "" Then
                lblmsg.Text = "Antes de realizar un registro consulte un caso"
                Exit Sub
            Else
                If lblresultado.Text = "Efectivo" Then
                    lblmsg.Text = "Este caso ya se encuentra Efectivo , no podra realizar gestion sobre el"
                    Exit Sub
                End If

                If drlresultado.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione un Resultado de Contacto"
                    Exit Sub
                End If
                If Drlresultado_config.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione un Resultado de Configuracion"
                    Exit Sub
                End If
                If Txt_Obs.Text = "" Then
                    lblmsg.Text = "Digite una observacion"
                    Exit Sub
                End If
                If Drlresultado_config.SelectedValue = "2" Or Drlresultado_config.SelectedValue = "3" Then

                    objvoz.dpto = Nothing
                    objvoz.mun = Nothing
                    objvoz.dir = Nothing
                    objvoz.barrio = Nothing
                    objvoz.equipo = Nothing
                    objvoz.Estado_linea = Nothing
                    objvoz.Respuesta = drlresultado.SelectedItem.Text
                    objvoz.Respuesta_Config = Drlresultado_config.SelectedItem.Text
                    objvoz.Corporativo = Nothing
                    objvoz.Dual = Nothing
                    objvoz.min = Nothing
                    objvoz.caso = lblcaso.Text
                    objvoz.Modificar_Bandeja_Config_Red()

                    RegistroCRM()

                    LimpiarHerramientas()
                    Llenar_Grid()
                    lblmsg.Text = "Registro Ingresado con exito"
                    Exit Sub
                Else
                    If Drlresultado_config.SelectedValue = "6" Then
                        If txtfecha.Text = "" Then
                            lblmsg.Text = "Seleccione una Fecha de Programacion"
                            Exit Sub
                        End If
                        If txtfecha.Text < DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") Then
                            lblmsg.Text = "La fecha debe ser mayor a la actual"
                            Exit Sub
                        End If
                    End If
                    If Drlresultado_config.SelectedValue = "5" Or Drlresultado_config.SelectedValue = "8" Then 'Efectivo obligatorio los campos

                        If Drlestado_linea.SelectedItem.Text = "- Seleccione -" Then
                            lblmsg.Text = "Seleccione un Estado de Linea"
                            Exit Sub
                        End If
                        If DrlDual_sim.SelectedItem.Text = "- Seleccione -" Then
                            lblmsg.Text = "Seleccione si es Dual Sim"
                            Exit Sub
                        End If

                        If DrlCorporativo.SelectedItem.Text = "- Seleccione -" Then
                            lblmsg.Text = "Seleccione si es Corporativo"
                            Exit Sub
                        End If

                        If drlequipo.SelectedItem.Text = "- Seleccione -" Then
                            lblmsg.Text = "Seleccione un Equipo Actual"
                            Exit Sub
                        End If
                        If drlequipo.SelectedItem.Text = "OTRO" And txtequipo_act.Text = "" Then
                            lblmsg.Text = "Digite Equipo Actual"
                            Exit Sub
                        End If

                        If drldpto.SelectedItem.Text = "- SELECCIONE -" Then
                            lblmsg.Text = "Seleccione Departamento Actual"
                            Exit Sub
                        End If

                        If drlmun.SelectedItem.Text = "- SELECCIONE -" Then
                            lblmsg.Text = "Seleccione Municipio Actual"
                            Exit Sub
                        End If

                        If txtdireccion.Text = "" Then
                            lblmsg.Text = "Digite una Direccion"
                            Exit Sub
                        End If

                        If txtbarrio.Text = "" Then
                            lblmsg.Text = "Digite un barrio"
                            Exit Sub
                        End If
                    End If

                    If Txt_min_Alterno.Text = "" Then
                        objvoz.min = Nothing
                    Else
                        objvoz.min = Txt_min_Alterno.Text
                    End If

                    If Drlestado_linea.SelectedItem.Text = "- Seleccione -" Then
                        objvoz.Estado_linea = Nothing
                    Else
                        objvoz.Estado_linea = Drlestado_linea.SelectedItem.Text
                    End If

                    If DrlDual_sim.SelectedItem.Text = "- Seleccione -" Then
                        objvoz.Dual = Nothing
                    Else
                        objvoz.Dual = DrlDual_sim.SelectedItem.Text
                    End If

                    If DrlCorporativo.SelectedItem.Text = "- Seleccione -" Then
                        objvoz.Corporativo = Nothing
                    Else
                        objvoz.Corporativo = DrlCorporativo.SelectedItem.Text
                    End If

                    If drlequipo.SelectedItem.Text = "- Seleccione -" Then
                        objvoz.equipo = Nothing
                    Else
                        If drlequipo.SelectedItem.Text = "OTRO" And txtequipo_act.Text = "" Then
                            lblmsg.Text = "Digite el Equipo Actual"
                            Exit Sub
                        ElseIf drlequipo.SelectedItem.Text = "OTRO" And txtequipo_act.Text <> "" Then
                            objvoz.equipo = txtequipo_act.Text
                        Else
                            objvoz.equipo = drlequipo.SelectedItem.Text
                        End If

                    End If

                    If drldpto.SelectedItem.Text = "- SELECCIONE -" Then
                        objvoz.dpto = Nothing
                    Else
                        objvoz.dpto = drldpto.SelectedItem.Text
                    End If

                    If drlmun.SelectedItem.Text = "- SELECCIONE -" Then
                        objvoz.mun = Nothing
                    Else
                        objvoz.mun = drlmun.SelectedItem.Text
                    End If

                    If txtdireccion.Text = "" Then
                        objvoz.dir = Nothing
                    Else
                        objvoz.dir = txtdireccion.Text
                    End If

                    If txtbarrio.Text = "" Then
                        objvoz.barrio = Nothing
                    Else
                        objvoz.barrio = txtbarrio.Text
                    End If

                    If txtnumero.Text = "" And txtletra.Text = "" Then
                        objvoz.ICCID = Nothing
                    Else
                        If txtnumero.Text = "" And txtletra.Text <> "" Then
                            lblmsg.Text = "Digiten la primera parte de ICCID"
                            Exit Sub
                        ElseIf txtnumero.Text <> "" And txtletra.Text = "" Then
                            lblmsg.Text = "Digiten la segunda parte de ICCID"
                            Exit Sub
                        Else
                            objvoz.ICCID = txtnumero.Text & "-" & txtletra.Text
                        End If
                    End If
                End If
            End If


            objvoz.Respuesta = drlresultado.SelectedItem.Text
            objvoz.Respuesta_Config = Drlresultado_config.SelectedItem.Text

            objvoz.caso = lblcaso.Text
            objvoz.Modificar_Bandeja_Config_Red()

            RegistroCRM()

            LimpiarHerramientas()
            Llenar_Grid()
            lblmsg.Text = "Registro Ingresado con exito"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Drlresultado_config_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Drlresultado_config.SelectedIndexChanged
        Try

            If Drlresultado_config.SelectedValue = "2" Or Drlresultado_config.SelectedValue = "3" Then
                Txt_min_Alterno.Text = ""
                Txt_min_Alterno.Enabled = False
                Drlestado_linea.SelectedValue = "0"
                Drlestado_linea.Enabled = False
                DrlDual_sim.SelectedValue = "0"
                DrlDual_sim.Enabled = False
                DrlCorporativo.SelectedValue = "0"
                DrlCorporativo.Enabled = False
                drlmarca.SelectedValue = "- Seleccione -"
                drlmarca_SelectedIndexChanged("- Seleccione -", Nothing)
                drlmarca.Enabled = False
                drlequipo.Enabled = False
                txtequipo_act.Text = ""
                txtequipo_act.Enabled = False
                drldpto.SelectedValue = "0"
                drldpto.Enabled = False
                drldpto_SelectedIndexChanged("0", Nothing)
                drlmun.Enabled = False
                txtdireccion.Text = ""
                txtdireccion.Enabled = False
                txtbarrio.Text = ""
                txtbarrio.Enabled = False
                txtfecha.Text = ""
                txtfecha.Enabled = False

                txtletra.Text = ""
                txtletra.Enabled = False
                txtnumero.Text = ""
                txtnumero.Enabled = False
            ElseIf Drlresultado_config.SelectedValue = "6" Then
                txtfecha.Enabled = True
                txtfecha.Text = ""
                Txt_min_Alterno.Enabled = True
                Drlestado_linea.Enabled = True
                DrlDual_sim.Enabled = True
                DrlCorporativo.Enabled = True
                drlmarca.Enabled = True
                drlequipo.Enabled = True
                txtequipo_act.Enabled = False
                txtequipo_act.Text = ""
                drldpto.Enabled = True
                drlmun.Enabled = True
                txtdireccion.Enabled = True
                txtbarrio.Enabled = True

                txtletra.Text = ""
                txtletra.Enabled = True
                txtnumero.Text = ""
                txtnumero.Enabled = True
            Else
                txtfecha.Text = ""
                txtfecha.Enabled = False
                txtequipo_act.Text = ""
                txtequipo_act.Enabled = False
                Txt_min_Alterno.Enabled = True
                Drlestado_linea.Enabled = True
                DrlDual_sim.Enabled = True
                DrlCorporativo.Enabled = True

                drlequipo.Enabled = True
                drlmarca.Enabled = True

                drldpto.Enabled = True
                drlmun.Enabled = True
                txtdireccion.Enabled = True
                txtbarrio.Enabled = True

                txtletra.Text = ""
                txtletra.Enabled = True
                txtnumero.Text = ""
                txtnumero.Enabled = True

            End If

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Private Sub RegistroCRM()
        Try
            Dim Objvoz As New clsvoz
            If lblcaso.Text = "" Then
                lblmsg.Text = "Antes de realizar un registro consulte un caso"
                Exit Sub
            End If
            If drlresultado.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un Resultado de Contacto"
                Exit Sub
            End If
            If Drlresultado_config.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un Resultado de Configuracion"
                Exit Sub
            End If
            If Txt_Obs.Text = "" Then
                lblmsg.Text = "Digite una observacion"
                Exit Sub
            End If
            If Drlresultado_config.SelectedValue = "6" Then
                If txtfecha.Text = "" Then
                    lblmsg.Text = "Seleccione una Fecha de Programacion"
                    Exit Sub
                End If
                Objvoz.Fc_Programado = txtfecha.Text

            Else
                Objvoz.Fc_Programado = ""
            End If


            Objvoz.caso = lblcaso.Text
            Objvoz.idusuario = lblusuario.Text
            Objvoz.obs = Txt_Obs.Text
            Objvoz.Respuesta = drlresultado.SelectedItem.Text
            Objvoz.Respuesta_Config = Drlresultado_config.SelectedItem.Text
            Objvoz.Fc_Programado = txtfecha.Text
            Objvoz.Insertar_CRMBandeja_Config_Red()

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Private Sub LimpiarHerramientas()


        lblcaso.Text = " "
        lblcliente.Text = " "
        lblmin.Text = " "
        Lbldepartamento.Text = " "
        Lblmunicipio.Text = " "
        Lbltipolinea.Text = " "
        LblEstado_linea.Text = " "
        lblresultado.Text = " "
        Lblfc_ingreso.Text = " "
        lblEquipo.Text = " "
        lblcampaña.Text = " "
        lblCorporativo.Text = " "
        lblmin_alterno.Text = " "

        drlresultado.SelectedValue = "0"
        Drlresultado_config.SelectedValue = "0"
        Txt_min_Alterno.Text = ""
        Drlestado_linea.SelectedValue = "0"
        DrlDual_sim.SelectedValue = "0"
        DrlCorporativo.SelectedValue = "0"
        txtequipo_act.Text = ""
        drlmarca.SelectedValue = "- Seleccione -"
        drlmarca_SelectedIndexChanged("- Seleccione -", Nothing)

        drldpto.SelectedValue = "0"
        drldpto_SelectedIndexChanged("0", Nothing)
        txtdireccion.Text = ""
        txtbarrio.Text = ""
        txtfecha.Text = ""
        Txt_Obs.Text = ""

        txtfecha.Enabled = False
        txtequipo_act.Enabled = False
        Txt_min_Alterno.Enabled = True
        Drlestado_linea.Enabled = True
        DrlDual_sim.Enabled = True
        DrlCorporativo.Enabled = True

        drlmarca.Enabled = True
        drlequipo.Enabled = True


        drldpto.Enabled = True
        drlmun.Enabled = True
        txtdireccion.Enabled = True
        txtbarrio.Enabled = True

        txtletra.Text = ""
        txtletra.Enabled = True
        txtnumero.Text = ""
        txtnumero.Enabled = True

        lblcuenta.Text = ""
        dtggestiones.DataSource = Nothing
        dtggestiones.DataBind()

    End Sub

    Protected Sub drlmarca_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlmarca.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.estado = drlmarca.SelectedItem.Value
            With drlequipo
                .DataSource = objdatos.consultaequipo
                .DataTextField = "equipo"
                .DataValueField = "equipo"
                .DataBind()
                .Items.Insert(objdatos.consultaequipo.Tables(0).Rows.Count, "OTRO")

            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub


    Private Sub drlequipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drlequipo.SelectedIndexChanged
        Try
            If drlequipo.SelectedItem.Text = "OTRO" Then
                txtequipo_act.Enabled = True
            Else
                txtequipo_act.Enabled = False
                txtequipo_act.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
End Class