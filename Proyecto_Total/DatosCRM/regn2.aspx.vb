Public Class regn2
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
                    .DataSource = objdatos.consultatipificacion
                    .DataTextField = "tipificacion"
                    .DataValueField = "idtipificacion"
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
            objdatos.preg1 = "0"
            objdatos.idusuario = lblusuario.Text
            objdatos.registrocrm()
            actbandeja()
            buscarinf()
            Consulta_Gestion()
            lblmsg.Text = "Seguimiento ingresado con éxito"
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
            txtobs.Text = ""
            lblestadon3.Text = ""
            lblfcingn3.Text = ""
            drltipificacionll.SelectedValue = 0
            drlfallatec.SelectedValue = "0"
            lblfallatec.Text = ""
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
                    lblfallatec.Text = objdatos.fallatec
                    lblfcingn3.Text = objdatos.fcingn3
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
                    lblfallatec.Text = ""
                    lblemail.Text = ""
                    lblcaso.Text = ""
                    lblobs611.Text = ""
                    lblestado.Text = ""
                    lblestadon3.Text = ""
                    lblfcingn3.Text = ""
                    lblmsg.Text = "No se han encontrado registros coincidentes"
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        buscarinf()
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

    Protected Sub drlgrupo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlgrupo.SelectedIndexChanged
        grupo()
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

    Protected Sub dtggeneral_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            buscarinf()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
End Class