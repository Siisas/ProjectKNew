Public Class regn3
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
                With drltipificacionll
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultatipificacionn3
                    .DataTextField = "tipificacion"
                    .DataValueField = "idtipificacion"
                    .DataBind()
                End With
                With drlingclaro
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultaing
                    .DataTextField = "ingclaro"
                    .DataValueField = "ingclaro"
                    .DataBind()
                End With
                'grupo de tipificación
                With drlgrupo
                    .DataSource = objdatos.consultagrupo
                    .DataTextField = "grupo"
                    .DataValueField = "grupo"
                    .DataBind()
                End With
                objdatos.tipo = drlgrupo.SelectedItem.Value
                With drltsoporte
                    .DataSource = objdatos.consultatsoportegrupo
                    .DataTextField = "escenario"
                    .DataValueField = "escenario"
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
                LblPQR.Text = objdatos.Consulta_Numero_PQR().Tables(0).Rows(0).Item("Nombre")
                Dim ObjclsDatos As New clscrmdatos
                With drlMotivo
                    .DataSource = ObjclsDatos.Consulta_Campo_NxMonitor
                    .DataTextField = "Nombre_NxMonitor"
                    .DataValueField = "Nombre_NxMonitor"
                    .DataBind()
                End With
                ''''' INICIO SEGURIDAD ACCESO URL '''''
                Dim objGeneral As New clsgeneral
                objGeneral.DtsSeguridad = Session("dtsSeguridad")
                objGeneral.Consulta_Proyecto_Seguridad()
                objGeneral.PaginaAcceso = "~" + Mid(Request.RawUrl, Integer.Parse(objGeneral.nombreentidad))
                objGeneral.idusuario = CType(Session("permisos"), clsusuario).usuario
                objGeneral.PermisosUrl()
                ''''' FIN SEGURIDAD ACCESO URL '''''    
            End If
            Bandeja()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub Bandeja()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.idusuarioasignado = lblusuario.text
            objdatos.Validacion = 5
            Session("Nivel3") = objdatos.Consulta_NIvel3()
            dtgprog.DataSource = Session("Nivel3")
            dtgprog.DataBind()
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
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clscrmdatos
        Try
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            If drltsoporte.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el tipo de soporte brindado"
                Exit Sub
            Else
                objdatos.tiposoporte = drltsoporte.SelectedItem.Text
            End If
            If drltipificacionll.SelectedItem.Value = 0 Then
                lblmsg.Text = "Seleccione la tipificación de la llamada"
                Exit Sub
            Else
                objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            End If
            If TxtPQR.Text = "" Then
                lblmsg.Text = "Ingrese el consecutivo PQR"
                Exit Sub
            Else
                objdatos.pqr = Int64.Parse(LblPQR.Text + TxtPQR.Text)
            End If
            If txtobs.Text = "" Then
                lblmsg.Text = "Digite la observación de atención al caso"
                Exit Sub
            Else
                objdatos.obs = txtobs.Text
            End If
            If lblfallatec.Text <> " " Then
                If drlfallatec.SelectedItem.Value = "0" Then
                    lblmsg.Text = "El caso fue reportado con Fallatec abierto, por favor especificar el estado del Fallatec"
                    Exit Sub
                Else
                    objdatos.fallatec = drlfallatec.SelectedItem.Value
                End If
            Else
                objdatos.fallatec = ""
            End If
            If txtnumalt.Text = "" Then
                objdatos.telalt = ""
            Else
                objdatos.telalt = txtnumalt.Text
            End If
            'nx monitor
            If drlIntalaApp.Enabled = True And drlMotivo.Enabled = True Then
                If drlIntalaApp.Text = "1" Then
                    lblmsg.Text = "Seleccione una opción de instalación de APP"
                    Exit Sub
                End If
                If drlIntalaApp.Text = "NO" Then
                    If drlMotivo.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione un motivo por el cual no se instaló la APP"
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
            If TxtClientId.Text = "" And drlIntalaApp.Text = "SI" Then
                lblmsg.Text = "debe digitar el client id  de la aplicacion  NX Monitor instalada"
                Exit Sub
            Else
                objdatos.idclient = TxtClientId.Text
            End If
            objdatos.preg1 = "0"
            objdatos.idusuario = lblusuario.Text
            objdatos.registrocrm()
            'If lblestado.Text <> "Escalado" Or drltipificacionll.SelectedItem.Text = "Cerrado" Then
            actbandeja()
            'End If
            buscarinf()
            Consulta_Gestion()
            lblmsg.Text = "Seguimiento ingresado con éxito"
            Bandeja()
            TxtClientId.Text = ""
            txtnumalt.Text = ""
            drlIntalaApp.SelectedValue = "1"
            drlMotivo.SelectedValue = "- Seleccione -"
            lblcliente.Text = ""
            lbldocumento.Text = ""
            lblmin.Text = ""
            lblplan.Text = ""
            lblequipo.Text = ""
            lbllugar.Text = ""
            lblemail.Text = ""
            lblcaso.Text = ""
            lblobs611.Text = ""
            lblestado.Text = ""
            txtcaso.Text = ""
            lblfallatec.Text = ""
            txtobs.Text = ""
            lblestadon3.Text = ""
            lblfcingn3.Text = ""
            drltipificacionll.SelectedValue = 35
            drlfallatec.SelectedValue = "0"
            drlgrupo.SelectedValue = "- Seleccione -"
            TxtPQR.Text = ""
            grupo()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub actbandeja()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.caso = txtcaso.Text
            objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            objdatos.fallatec = drlfallatec.SelectedItem.Value
            objdatos.modificarbandejan3()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub buscarinf()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el Caso o Min que desea consultar"
            Else
                If txtcaso.Text <> "" Then
                    objdatos.caso = txtcaso.Text
                End If
                dtggeneral.DataSource = objdatos.consultacaso
                dtggeneral.DataBind()
                lblcuenta.Text = objdatos.cantidad
                If objdatos.cantidad > 0 Then
                    lblcliente.Text = objdatos.cliente
                    lbldocumento.Text = objdatos.documento
                    lblmin.Text = objdatos.min
                    lblplan.Text = objdatos.plan
                    lblequipo.Text = objdatos.equipo
                    lbllugar.Text = objdatos.lugar
                    lblemail.Text = objdatos.email
                    lblcaso.Text = objdatos.caso
                    lblobs611.Text = objdatos.obsini
                    lblestado.Text = objdatos.tipificacion
                    lblestadon3.Text = objdatos.estadoinc
                    lblfcingn3.Text = objdatos.fcingn3
                    lblfallatec.Text = objdatos.fallatec
                    If lblfcingn3.Text = " " Then
                        btnguardar.Enabled = False
                        lblmsg.Text = "El caso no ha sido identificado como asignado a Nivel 3, solicite a Nivel 3 la identificación antes de registrar alguna gestión"
                    Else
                        btnguardar.Enabled = True
                        lblmsg.Text = ""
                    End If
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
                    lblemail.Text = ""
                    lblfallatec.Text = ""
                    lblcaso.Text = ""
                    lblobs611.Text = ""
                    lblestado.Text = ""
                    lblestadon3.Text = ""
                    lblfcingn3.Text = ""
                    lblmsg.Text = "No se han encontrado registros coincidentes"
                End If
                'Nx Monitor
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
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        buscarinf()
    End Sub

    Protected Sub btnindentifn3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnindentifn3.Click
        Dim objdatos As New clscrmdatos
        Try
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
                lblmsg.Text = "Eliga el ingeniero que asigna el caso en Claro"
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
            objdatos.modificaN3()
            lblmsg.Text = "Caso actualizado como Nivel 3"
            txtfcingn3.Text = ""
            chkpqr.Checked = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar0.Click
        Try
            Dim objdatos As New clscrmdatos
            Dim objdatosgr As New clsgeneral
            If txtingclaro.Text = "" Then
                lblmsg.Text = "Digite el nuevo ingeniero a registrar"
                Exit Sub
            Else
                objdatos.ingn3 = txtingclaro.Text
            End If
            objdatos.registroingclaro()
            lblmsg.Text = "Ingeniero ingresado con éxito"
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
            With drltsoporte
                .DataSource = objdatos.consultatsoportegrupo
                .DataTextField = "escenario"
                .DataValueField = "escenario"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton3.Click
        Try
            If lblcaso.Text = "" Then
                lblmsg.Text = "Consulte el caso antes de generar una inconsistencia"
            Else
                Pninc.Visible = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton4.Click
        Try
            Pninc.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
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
            objdatos.registroinc()
            lblmsg.Text = "Inconsistencia reportada con exito"
            drlincons.SelectedValue = 0
            txtobsinc.Text = ""
            Pninc.Visible = False
            drlnivel.SelectedValue = "0"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
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

    Protected Sub dtgprog_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgprog.PageIndexChanging
        Try
            dtgprog.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtgprog.DataSource = Session("Nivel3")
            dtgprog.DataBind()
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