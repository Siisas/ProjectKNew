Public Class HelpDeskRegistro
    Inherits System.Web.UI.Page
    Dim ObjHelpDesk As New clsHelpDesk

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Registro Help Desk"
                With drlCanal
                    .DataSource = ObjHelpDesk.Consulta_Canal
                    .DataTextField = "Nombre"
                    .DataValueField = "Cod_HelpDesk_Canal"
                    .DataBind()
                End With
                With drlArea
                    .DataSource = ObjHelpDesk.Consulta_Area
                    .DataTextField = "Nombre"
                    .DataValueField = "Cod_HelpDesk_Complemento"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub BtnNuevoTicket_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNuevoTicket.Click
        Limpiar()
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Plegar_panel();", True)
        Pnl_Message.CssClass = Nothing
        lblmsg.Text = Nothing
    End Sub

    Protected Sub BtnConsultaTicket_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultaTicket.Click
        Limpiar()
        PanelConsulta.Visible = True
        Pnl_Message.CssClass = Nothing
        lblmsg.Text = Nothing
    End Sub

    Protected Sub btnConsultaCaso_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConsultaCaso.Click
        Try
            Consultar_Tickets()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        Finally
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
        End Try
    End Sub
    'Public Sub EnviarCorreo()
    '    Try
    '        Dim correo As New System.Net.Mail.MailMessage
    '        ''De
    '        correo.From = New System.Net.Mail.MailAddress(CType(Session("permisos"), clsusuario).usuario + "@comunicaciones-moviles.com")
    '        ''Para
    '        correo.To.Add("helpdesk@comunicaciones-moviles.com")
    '        ''Asunto
    '        correo.Subject = TxtTema.Text
    '        ''Cometarios
    '        correo.Body = "OBSERVACION: " + txtObservacion.Text + ". PERSONA REPORTA: " + TxtPersona_Reporta.Text + ". MODULO: " + drlLetraModulo.SelectedItem.ToString + TxtNumeroModulo.Text
    '        correo.IsBodyHtml = False
    '        correo.Priority = System.Net.Mail.MailPriority.Normal

    '        ''Hots para enviar el correo
    '        Dim smtp As New System.Net.Mail.SmtpClient
    '        smtp.Host = "smtp.comunicaciones-moviles.com"

    '        ''Autenticacion o credenciales del correo que recive el mensaje
    '        smtp.Credentials = New System.Net.NetworkCredential("helpdesk@comunicaciones-moviles.com", "Helpk2014*")
    '        smtp.Send(correo)
    '    Catch ex As Exception
    '        Pnl_Message.CssClass = "alert alert-danger"
    '        lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
    '    End Try
    'End Sub

    Public Sub AutoAsignacion()
        Try
            ObjHelpDesk.Cod_HelpDesk_Registro = ObjHelpDesk.Cod_HelpDesk_Registro
            ObjHelpDesk.Asignado = CType(Session("permisos"), clsusuario).usuario
            ObjHelpDesk.Asigna = CType(Session("permisos"), clsusuario).usuario
            ObjHelpDesk.ObservacionAsigna = "Auto Asignacion"
            ObjHelpDesk.Prioridad = Nothing
            ObjHelpDesk.Fk_Cod_Categoria = Nothing
            ObjHelpDesk.Fk_Cod_Tipo = Nothing
            ObjHelpDesk.UpdateTicketAsignado()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub BtnEnviar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnEnviar.Click
        Try
            If TxtTema.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese un Tema"
                Exit Sub
            End If
            If txtObservacion.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese una Observacion"
                Exit Sub
            End If
            If drlPrioridad.Text = "1" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija una priorodad"
                Exit Sub
            End If
            If drlCanal.Text = "1" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija un canal"
                Exit Sub
            End If
            If drlLetraModulo.Text = "1" Then
                ObjHelpDesk.Modulo = ""
            Else
                If TxtNumeroModulo.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el numero del modulo o cambie la letra del modulo a seleccion"
                    Exit Sub
                Else
                    ObjHelpDesk.Modulo = drlLetraModulo.Text + TxtNumeroModulo.Text
                End If
            End If
            If TxtPersona_Reporta.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el Nombre de quien reporta el ticket"
                Exit Sub
            End If
            If drlArea.SelectedItem.ToString = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija un Area"
                Exit Sub
            End If
            ObjHelpDesk.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            ObjHelpDesk.Prioridad = drlPrioridad.Text
            ObjHelpDesk.Tema = TxtTema.Text
            ObjHelpDesk.Observacion = txtObservacion.Text
            ObjHelpDesk.Estado = "Abierto"
            ObjHelpDesk.Fk_Cod_Canal = drlCanal.Text
            ObjHelpDesk.Persona_Reporta = TxtPersona_Reporta.Text
            ObjHelpDesk.Fk_Cod_Complemento_Area = drlArea.Text
            ObjHelpDesk.IngresarTicket()
            Dim A As DataSet
            A = ObjHelpDesk.Codigo_Registro()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> El ticket se a registrado con el codigo: " + ObjHelpDesk.Cod_HelpDesk_Registro.ToString
            ObjHelpDesk.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            Dim dts As New DataSet
            dts = ObjHelpDesk.Consulta_Tecnico_AutoAsigna()
            If dts.Tables(0).Rows.Count > 0 Then
                AutoAsignacion()
            End If
            'EnviarCorreo()
            Limpiar()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        Finally
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
        End Try
    End Sub
    Protected Sub dtgTicket_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgTicket.PageIndexChanging
        Try
            dtgTicket.DataSource = Session("DtT_Tickets")
            dtgTicket.PageIndex = e.NewPageIndex
            dtgTicket.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub dtgProceso_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgProceso.PageIndexChanging
        Try

            If TxtCodTicket.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese alguna opcion de filtro antes de consultar"
                Exit Sub
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If TxtCodTicket.Text <> Nothing Then
                ObjHelpDesk.Cod_HelpDesk_Registro = TxtCodTicket.Text
                dtgProceso.DataSource = ObjHelpDesk.Consulta_Proceso()
                dtgProceso.DataBind()
                lblCuentaProceso.Text = ObjHelpDesk.Cantidad
            End If

            dtgProceso.DataSource = ObjHelpDesk.Consulta_Proceso()
            dtgProceso.PageIndex = e.NewPageIndex
            dtgProceso.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub dtgTicket_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtgTicket.RowCommand
        Try
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            If e.CommandName = "Calificar" Then
                If dtgTicket.Rows(index).Cells(dtgTicket.Columns.Count - 3).Text <> "&nbsp;" Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> El ticket ya se encuentra calificado!"
                Else
                    Session("Cod_Ticket") = dtgTicket.Rows(index).Cells(0).Text
                    Cargar_Drl_Calificacion()
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Plegar", "PlegDes_Dinamico('#Desp_Calif', 'slide', '', '', '');", True)
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub Btn_Calificar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Calificar.Click
        Try
            ObjHelpDesk.Cod_Calificacion = Drl_Calificacion.SelectedValue
            ObjHelpDesk.Descripcion = Txb_Observacion.Text
            ObjHelpDesk.Cod_HelpDesk_Registro = Session("Cod_Ticket")
            ObjHelpDesk.Actualizar_Ticket()
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Plegar", "PlegDes_Dinamico('#Desp_Calif', 'show', '', '', '');PlegDes_Dinamico('#Desp_Calif', 'slide', '', '', '');", True)
            ObjHelpDesk.Cod_HelpDesk_Registro = Nothing
            Consultar_Tickets()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Calificación exitosa"
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Ha ocurrido un error durante o despues de calificar!"
        End Try
    End Sub


    Protected Sub Cargar_Drl_Calificacion()
        With Drl_Calificacion
            .DataSource = ObjHelpDesk.Consultar_Complementos(Nothing, Nothing, "Calificacion")
            .DataTextField = "Nombre"
            .DataValueField = "Cod_HelpDesk_Complemento"
            .DataBind()
        End With
    End Sub

    Protected Sub Consultar_Tickets()
        Session("DtT_Tickets") = New DataTable
        Session("DtT_Gestiones") = New DataTable
        Try
            ObjHelpDesk.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            ObjHelpDesk.Cod_Ticket = TxtCodTicket.Text
            If TxtCodTicket.Text <> Nothing Then
                Consultar_Gestiones()
            End If

            ObjHelpDesk.Fecha_Inicio = TxtFecha_Inicio.Text
            ObjHelpDesk.Fecha_Fin = TxtFecha_Fin.Text
            Session("DtT_Tickets") = ObjHelpDesk.Consultar_Tickets("").Tables(0)
            lblCuentaTicket.Text = Session("DtT_Tickets").Rows.Count
            dtgTicket.DataSource = Session("DtT_Tickets")
            dtgTicket.DataBind()
            If Session("DtT_Tickets").Rows.Count > 0 Then
                PanelConsulta2.Visible = True
            Else
                PanelConsulta2.Visible = False
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros que coincidan con su criterio de busqueda!"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Private Sub Consultar_Gestiones()
        Try
            Session("Dts_Gestiones") = ObjHelpDesk.Consultar_Gestiones().Tables(0)
            dtgProceso.DataSource = Session("Dts_Gestiones")
            dtgProceso.DataBind()
            lblCuentaProceso.Text = Session("Dts_Gestiones").rows.count
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>  Se presento error consultando las gestiones" & ex.Message
        End Try
    End Sub

    Public Sub Limpiar()
        'PanelConsulta
        TxtFecha_Inicio.Text = Nothing
        TxtFecha_Fin.Text = Nothing
        TxtCodTicket.Text = Nothing
        lblCuentaTicket.Text = Nothing
        lblCuentaProceso.Text = Nothing
        dtgTicket.DataSource = Nothing
        dtgTicket.DataBind()
        dtgProceso.DataSource = Nothing
        dtgProceso.DataBind()
        PanelConsulta2.Visible = False
        'PanelRegistro
        TxtTema.Text = Nothing
        drlPrioridad.SelectedIndex = 0
        drlLetraModulo.SelectedIndex = 0
        drlArea.SelectedIndex = 0
        txtObservacion.Text = Nothing
        drlCanal.SelectedIndex = 0
        TxtNumeroModulo.Text = Nothing
        TxtPersona_Reporta.Text = Nothing
    End Sub
End Class