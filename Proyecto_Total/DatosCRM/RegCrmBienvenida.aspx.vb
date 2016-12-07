Public Class RegCrmBienvenida
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("Permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("Permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                Cargar_drl()
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
            lblmsg.Text = "Se presento error: " + ex.Message
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
    Public Sub Cargar_drl()
        Try
            Dim ObjVoz As New clsvoz
            ObjVoz.Validacion = "1"
            With drltipificacionll
                .DataSource = ObjVoz.ConsultadrlBienvenidaDatos
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            ObjVoz.Validacion = "3"
            With drltipificacionllEnfoque
                .DataSource = ObjVoz.ConsultadrlBienvenidaDatos
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            Dim ObjclsDatos As New clscrmdatos
            With drlMotivo
                .DataSource = ObjclsDatos.Consulta_Campo_NxMonitor
                .DataTextField = "Nombre_NxMonitor"
                .DataValueField = "Nombre_NxMonitor"
                .DataBind()
            End With
            Dim ObjGeneral As New clsgeneral
            'Inconsistencia Global
            ObjGeneral.cargo = "GlobalBienv"
            With drlinconsglobal
                .DataSource = ObjGeneral.consultaincdatos
                .DataTextField = "inconsistencia"
                .DataValueField = "idtipoinc"
                .DataBind()
            End With
            'Inconsistencia
            ObjGeneral.cargo = "Global2"
            ObjGeneral.estado = drlincons.Text
            With drlincons
                .DataSource = ObjGeneral.consultaincdatos
                .DataTextField = "inconsistencia"
                .DataValueField = "idtipoinc"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Public Sub buscarinf()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el Min que desea consultar"
            Else
                If txtcaso.Text <> "" Then
                    objdatos.caso = txtcaso.Text
                End If
                dtggeneral.DataSource = objdatos.Consulta_Caso_Bienvenida()
                dtggeneral.DataBind()
                lblcuenta.Text = objdatos.cantidad
                If objdatos.cantidad > 0 Then
                    lblcliente.Text = objdatos.cliente
                    lbldocumento.Text = objdatos.documento
                    lblmin.Text = objdatos.min
                    lblplan.Text = objdatos.plan
                    lblequipo.Text = objdatos.equipo
                    lbllugar.Text = objdatos.lugar
                    LblFcCompra.Text = objdatos.fcingn3
                    lblcaso.Text = objdatos.caso
                    LblPaqDatos.Text = objdatos.ajuste
                    lblestado.Text = objdatos.tipificacion
                    If txtcaso.Text = "" Then
                        txtcaso.Text = objdatos.caso
                    End If
                    lblmsg.Text = ""
                Else
                    lblcliente.Text = ""
                    lbldocumento.Text = ""
                    lblmin.Text = ""
                    lblplan.Text = ""
                    lblequipo.Text = ""
                    lbllugar.Text = ""
                    LblFcCompra.Text = ""
                    lblcaso.Text = ""
                    LblPaqDatos.Text = ""
                    lblestado.Text = ""
                    lblcuenta.Text = ""
                    lblmsg.Text = "No se han encontrado registros coincidentes"
                End If
                'Nx Monitor
                If txtcaso.Text <> "" Then
                    objdatos.caso = lblcaso.Text
                End If
                objdatos.ConsultaNxMonitorBienvenida()
                If objdatos.preg2 = "SI" Then
                    drlIntalaApp.Enabled = False
                    drlMotivo.Enabled = False
                Else
                    drlIntalaApp.Enabled = True
                    drlMotivo.Enabled = True
                    Dim objdatos1 As New clsgeneral
                    objdatos1.idusuario = lblusuario.Text
                    objdatos1.consultared()
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            buscarinf()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Sub actbandeja()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = lblcaso.Text
            End If
            If drltipificacionll.SelectedItem.Value = "- Seleccione -" Then
                lblmsg.Text = "Seleccione la tipificación de la llamada"
                Exit Sub
            Else
                objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            End If
            objdatos.ActualizaBandejaBienvenida()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el min que desea registrar"
                Exit Sub
            Else
                If lblcaso.Text = "" Then
                    lblmsg.Text = "Realice la consulta del min"
                    Exit Sub
                End If
                objdatos.caso = lblcaso.Text
            End If
            If txtobs.Text = "" Then
                lblmsg.Text = "Digite la observación de atención al caso"
                Exit Sub
            Else
                objdatos.obs = txtobs.Text
            End If
            If drltipificacionll.SelectedItem.Value = "- Seleccione -" Then
                lblmsg.Text = "Seleccione la tipificación de la llamada"
                Exit Sub
            Else
                objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            End If
            If drltipificacionll.SelectedItem.Text = "Llamada Programada" Then
                If txtmin.Text = "" Or txthora.Text = "" Or txtfcprog.Text = "" Then
                    lblmsg.Text = "Si la llamada es programada elija la fecha y hora a la que se debe llamar nuevamente"
                    txtfcprog.Text = ""
                    Exit Sub
                Else
                    Dim hora As String
                    If txthora.Text > 23 Or txtmin.Text > 59 Then
                        lblmsg.Text = "La hora de programación no es correcta, verifique"
                        txtfcprog.Text = ""
                        Exit Sub
                    End If
                    hora = Convert.ToDateTime(txtfcprog.Text & " " & txthora.Text & ":" & txtmin.Text)
                    If Convert.ToDateTime(hora) <= Now Then
                        lblmsg.Text = "La fecha de programación debe ser mayor a la fecha actual, verifique"
                        txtfcprog.Text = ""
                        Exit Sub
                    End If
                    objdatos.horaprog = hora
                End If
            End If
            If drltipificacionll.SelectedItem.Text = "Llamada Rechazada" And drlTipificacionRechaza.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Elija un motivo por el cual el usuario no desea recibir la información "
                Exit Sub
            Else
                If drltipificacionll.SelectedItem.Text <> "Llamada Rechazada" And drltipificacionll.SelectedItem.Text <> "Llamada Buzon" Then
                    objdatos.tiposoporte = ""
                Else
                    objdatos.tiposoporte = drlTipificacionRechaza.SelectedItem.Text
                End If
            End If
            If drltipificacionll.SelectedItem.Text = "Llamada Rechazada" Or drltipificacionll.SelectedItem.Text = "Llamada Programada" Or drltipificacionll.SelectedItem.Text = "Llamada Buzon" Then
                objdatos.preg1 = ""
            Else
                If drltipificacionllEnfoque.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Elija cual fue cual fue la orientación o el enfoque de la llamada"
                    Exit Sub
                Else
                    objdatos.preg1 = drltipificacionllEnfoque.SelectedItem.Text
                End If
            End If
            'nx monitor
            If drlIntalaApp.Enabled = True And drlMotivo.Enabled = True Then
                If drlIntalaApp.Text = "1" Then
                    lblmsg.Text = "Seleccione una opcion de instalacion de APP"
                    Exit Sub
                End If
                If drlIntalaApp.Text = "NO" Then
                    If drlMotivo.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione un motivo por el cual no se instalo la APP"
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
                objdatos.preg2 = ""
                objdatos.preg3 = ""
            End If
            If RdbtnSoporte.SelectedValue = Nothing Then
                lblmsg.Text = "Seleccione una opcion si brindo el soporte"
                Exit Sub
            Else
                objdatos.chk1 = RdbtnSoporte.SelectedItem.Text
            End If
            If CheckBox_Des_Caracteristica_Plan.Checked = False And CheckBox_Canal_Consulta_Control_Consumo.Checked = False And CheckBox_Asesoria_Reg_Tienda_Des_App.Checked = False And CheckBox_Config_Cuenta_Correo.Checked = False And CheckBox_Caracte_Basica_Equipo.Checked = False And CheckBox_Condiciones_Cobertura_Red.Checked = False And CheckBox_Tips_Auto_Atencion.Checked = False And CheckBox_Info_Roaming_Internacional.Checked = False And CheckBox_Remision_Canal_Atencion.Checked = False Then
                lblmsg.Text = "Debe Chequear por lo menos una de las variables de medicion"
                Exit Sub
            Else
                ''''Des_Caracteristica_Plan
                If CheckBox_Des_Caracteristica_Plan.Checked <> False Then
                    objdatos.Des_Caracteristica_Plan = "SI-"
                Else
                    objdatos.Des_Caracteristica_Plan = "NO-"
                End If
                If Drl_Des_Caracteristica_Plan.Text <> "- Seleccione -" Then
                    objdatos.Des_Caracteristica_Plan = objdatos.Des_Caracteristica_Plan + Drl_Des_Caracteristica_Plan.Text
                End If
                ''''Canal_Consulta_Control_Consumo
                If CheckBox_Canal_Consulta_Control_Consumo.Checked <> False Then
                    objdatos.Canal_Consulta_Control_Consumo = "SI-"
                Else
                    objdatos.Canal_Consulta_Control_Consumo = "NO-"
                End If
                If Drl_Canal_Consulta_Control_Consumo.Text <> "- Seleccione -" Then
                    objdatos.Canal_Consulta_Control_Consumo = objdatos.Canal_Consulta_Control_Consumo + Drl_Canal_Consulta_Control_Consumo.Text
                End If
                ''''Asesoria_Reg_Tienda_Des_App
                If CheckBox_Asesoria_Reg_Tienda_Des_App.Checked <> False Then
                    objdatos.Asesoria_Reg_Tienda_Des_App = "SI-"
                Else
                    objdatos.Asesoria_Reg_Tienda_Des_App = "NO-"
                End If
                If Drl_Asesoria_Reg_Tienda_Des_App.Text <> "- Seleccione -" Then
                    objdatos.Asesoria_Reg_Tienda_Des_App = objdatos.Asesoria_Reg_Tienda_Des_App + Drl_Asesoria_Reg_Tienda_Des_App.Text
                End If
                ''''Config_Cuenta_Correo
                If CheckBox_Config_Cuenta_Correo.Checked <> False Then
                    objdatos.Config_Cuenta_Correo = "SI-"
                Else
                    objdatos.Config_Cuenta_Correo = "NO-"
                End If
                If Drl_Config_Cuenta_Correo.Text <> "- Seleccione -" Then
                    objdatos.Config_Cuenta_Correo = objdatos.Config_Cuenta_Correo + Drl_Config_Cuenta_Correo.Text
                End If
                ''''Caracte_Basica_Equipo
                If CheckBox_Caracte_Basica_Equipo.Checked <> False Then
                    objdatos.Caracte_Basica_Equipo = "SI-"
                Else
                    objdatos.Caracte_Basica_Equipo = "NO-"
                End If
                If Drl_Caracte_Basica_Equipo.Text <> "- Seleccione -" Then
                    objdatos.Caracte_Basica_Equipo = objdatos.Caracte_Basica_Equipo + Drl_Caracte_Basica_Equipo.Text
                End If
                ''''Condiciones_Cobertura_Red
                If CheckBox_Condiciones_Cobertura_Red.Checked <> False Then
                    objdatos.Condiciones_Cobertura_Red = "SI-"
                Else
                    objdatos.Condiciones_Cobertura_Red = "NO-"
                End If
                If Drl_Condiciones_Cobertura_Red.Text <> "- Seleccione -" Then
                    objdatos.Condiciones_Cobertura_Red = objdatos.Condiciones_Cobertura_Red + Drl_Condiciones_Cobertura_Red.Text
                End If
                ''''Tips_Auto_Atencion
                If CheckBox_Tips_Auto_Atencion.Checked <> False Then
                    objdatos.Tips_Auto_Atencion = "SI-"
                Else
                    objdatos.Tips_Auto_Atencion = "NO-"
                End If
                If Drl_Tips_Auto_Atencion.Text <> "- Seleccione -" Then
                    objdatos.Tips_Auto_Atencion = objdatos.Tips_Auto_Atencion + Drl_Tips_Auto_Atencion.Text
                End If
                ''''Info_Roaming_Internacional
                If CheckBox_Info_Roaming_Internacional.Checked <> False Then
                    objdatos.Info_Roaming_Internacional = "SI-"
                Else
                    objdatos.Info_Roaming_Internacional = "NO-"
                End If
                If Drl_Info_Roaming_Internacional.Text <> "- Seleccione -" Then
                    objdatos.Info_Roaming_Internacional = objdatos.Info_Roaming_Internacional + Drl_Info_Roaming_Internacional.Text
                End If
                ''''Remision_Canal_Atencion
                If CheckBox_Remision_Canal_Atencion.Checked <> False Then
                    objdatos.Remision_Canal_Atencion = "SI-"
                Else
                    objdatos.Remision_Canal_Atencion = "NO-"
                End If
                If Drl_Remision_Canal_Atencion.Text <> "- Seleccione -" Then
                    objdatos.Remision_Canal_Atencion = objdatos.Remision_Canal_Atencion + Drl_Remision_Canal_Atencion.Text
                End If
            End If
            objdatos.telalt = txtnumalt.Text
            objdatos.idusuario = lblusuario.Text


            objdatos.Registro_CRM_Bienvenida()
            actbandeja()
            objdatos.Insercion_Variable_Medicion_Bienvenida()
            Consulta_Gestion()

            lblmsg.Text = "Seguimiento ingresado con éxito"

            txtobs.Text = ""
            txtfcprog.Text = ""
            txthora.Text = ""
            txtmin.Text = ""
            txtnumalt.Text = ""
            RdbtnSoporte.SelectedValue = Nothing
            ''''Des_Caracteristica_Plan
            CheckBox_Des_Caracteristica_Plan.Checked = False
            Drl_Des_Caracteristica_Plan.SelectedValue = "- Seleccione -"
            ''''Canal_Consulta_Control_Consumo
            CheckBox_Canal_Consulta_Control_Consumo.Checked = False
            Drl_Canal_Consulta_Control_Consumo.SelectedValue = "- Seleccione -"
            ''''Asesoria_Reg_Tienda_Des_App
            CheckBox_Asesoria_Reg_Tienda_Des_App.Checked = False
            Drl_Asesoria_Reg_Tienda_Des_App.SelectedValue = "- Seleccione -"
            ''''Config_Cuenta_Correo
            CheckBox_Config_Cuenta_Correo.Checked = False
            Drl_Config_Cuenta_Correo.SelectedValue = "- Seleccione -"
            ''''Caracte_Basica_Equipo
            CheckBox_Caracte_Basica_Equipo.Checked = False
            Drl_Caracte_Basica_Equipo.SelectedValue = "- Seleccione -"
            ''''Condiciones_Cobertura_Red
            CheckBox_Condiciones_Cobertura_Red.Checked = False
            Drl_Condiciones_Cobertura_Red.SelectedValue = "- Seleccione -"
            ''''Tips_Auto_Atencion
            CheckBox_Tips_Auto_Atencion.Checked = False
            Drl_Tips_Auto_Atencion.SelectedValue = "- Seleccione -"
            ''''Info_Roaming_Internacional
            CheckBox_Info_Roaming_Internacional.Checked = False
            Drl_Info_Roaming_Internacional.SelectedValue = "- Seleccione -"
            ''''Remision_Canal_Atencion
            CheckBox_Remision_Canal_Atencion.Checked = False
            Drl_Remision_Canal_Atencion.SelectedValue = "- Seleccione -"
            Cargar_drl()
            buscarinf()

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drltipificacionll_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drltipificacionll.SelectedIndexChanged
        Try
            Dim ObjVoz As New clsvoz
            ObjVoz.Validacion = drltipificacionll.Text
            If drltipificacionll.Text <> "Llamada Satisfecha" And drltipificacionll.Text <> "- Seleccione -" Then
                With drlTipificacionRechaza
                    .DataSource = ObjVoz.ConsultadrlBienvenidaDatos
                    .DataTextField = "Nombre"
                    .DataValueField = "Nombre"
                    .DataBind()
                End With
            End If
            If drltipificacionll.Text = "Llamada Satisfecha" Then
                drlTipificacionRechaza.Text = "- Seleccione -"
                drlTipificacionRechaza.Enabled = False
                drltipificacionllEnfoque.Enabled = True

            Else
                drlTipificacionRechaza.Enabled = True
                drltipificacionllEnfoque.Text = "- Seleccione -"
                drltipificacionllEnfoque.Enabled = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " + ex.Message
        End Try
    End Sub

    Protected Sub LinkButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton3.Click
        Try
            If lblcaso.Text = "" Then
                lblmsg.Text = "Consulte el caso antes de generar una inconsistencia"
            Else
                Pninc.Visible = True
                Pndiagnostico.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton4.Click
        Try
            Pninc.Visible = False
            Pndiagnostico.Visible = True
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
            objdatos.caso = lblcaso.Text
            objdatos.idusuario = lblusuario.Text
            Dim dts As New DataSet
            dts = objdatos.validainconsistenciaasignada
            If dts.Tables(0).Rows.Count > 0 Then
                lblmsg.Text = "Este caso ya tiene un registro de inconsistencia"
                Exit Sub
            Else
                objdatos.registroincbienvenidad()
                lblmsg.Text = "Inconsistencia reportada con exito"
                drlincons.SelectedValue = "0"
                txtobsinc.Text = ""
                'Pninc.Visible = False
                'Pndiagnostico.Visible = True
                drlnivel.SelectedValue = "0"
            End If
            Pninc.Visible = False
            Pndiagnostico.Visible = True
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drlinconsglobal_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlinconsglobal.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            'Inconsistencia
            objdatos.cargo = "InconsistenciaBienv"
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

    Protected Sub dtggeneral_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            buscarinf()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
End Class