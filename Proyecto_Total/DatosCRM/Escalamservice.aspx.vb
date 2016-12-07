Public Class Escalamservice
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If

            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                casosptes()
                Session("Formulario") = "Escalamiento Service"

            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub casosptes()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            If txtcaso.Text <> Nothing Then
                objdatos.caso = txtcaso.Text
            End If
            Session("dtggeneral") = objdatos.consultaescaladosv2servdatos
            dtggeneral.DataSource = Session("dtggeneral")
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
            If objdatos.cantidad > 0 Then
                lblmin.Text = objdatos.min
                lblcliente.Text = objdatos.cliente
                'LblBandeja.Text = objdatos.Bandeja
            Else
                lblmin.Text = ""
                lblcliente.Text = ""
                'LblBandeja.Text = ""
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clscrmdatos
        Try
            If txtcaso.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If


            If chkanula.Checked = True Then
                objdatos.fechafin = 1
                If txtobs.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite la razón de la devolución del escalamiento"
                    Exit Sub
                Else
                    objdatos.obs = txtobs.Text
                End If
                objdatos.estadoinc = "Devuelto"
                'objdatos.actualizaestadodevueltoserv()
            Else
                objdatos.estadoinc = "Escalado"
            End If

            If txtcpd.Text = "" And chkanula.Checked = False Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el consecutivo asignado para el escalamiento o anulelo"
                Exit Sub
            Else
                objdatos.tickler = txtcpd.Text
            End If
            If txtobs.Text = "" Then
                objdatos.obs = ""
            Else
                objdatos.obs = txtobs.Text
            End If
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            If objdatos.consultaescaladosv2servdatos.Tables(0).Rows.Count = 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese un caso valido o que se encuentre asignado"
                Exit Sub
            End If
            objdatos.actualizaescaladosv2servdatos()
            'If objdatos.estadoinc = "Escalado" Then
            '    objdatos.caso = txtcaso.Text
            '    objdatos.tipificacion = objdatos.estadoinc
            '    objdatos.Actualiza_Estado_Bandeja_Datos()
            'End If
            guardacrm()
            If chkanula.Checked = False Then
                Dim objvoz As New clsvoz
                objvoz.caso = txtcaso.Text
                objvoz.Nombre = "Escalado"
                '---Dilo---' guardo estado escalado
                If lblcampaña.Text = "DILO" Then
                    objvoz.Validacion = "DILO"
                    objvoz.Modificar_Bandejas_Estado_Escalado()
                End If
                '---Datos---'  guardo estado escalado
                If lblcampaña.Text = "DATOS" Or lblcampaña.Text = "BSCS" Then
                    objvoz.Validacion = "DATOS"
                    objvoz.Modificar_Bandejas_Estado_Escalado()
                End If
                '---Fideliza---'guardo estado escalado      
                If lblcampaña.Text = "FALLA DES" Then
                    objvoz.Validacion = "FALLA DES"
                    objvoz.Modificar_Bandejas_Estado_Escalado()
                End If
                '---Voz---' guardo estado escalado
                If lblcampaña.Text = "VOZ" Then
                    objvoz.Validacion = "VOZ"
                    objvoz.Modificar_Bandejas_Estado_Escalado()
                End If
                '---Inbound---' guardo estado escalado
                If lblcampaña.Text = "INBOUND" Then
                    objvoz.Validacion = "INBOUND"
                    objvoz.Modificar_Bandejas_Estado_Escalado()
                End If
            Else
                Dim objvoz As New clsvoz
                objvoz.caso = txtcaso.Text
                objvoz.Nombre = "No Contactado"
                '---Dilo---' guardo estado escalado
                If lblcampaña.Text = "DILO" Then
                    objvoz.Validacion = "DILO"
                    objvoz.Modificar_Bandejas_Estado_Escalado()
                End If
                '---Datos---'  guardo estado escalado
                If lblcampaña.Text = "DATOS" Or lblcampaña.Text = "BSCS" Then
                    objvoz.Validacion = "DATOS"
                    objvoz.Modificar_Bandejas_Estado_Escalado()
                End If
                '---Fideliza---'guardo estado escalado      
                If lblcampaña.Text = "FALLA DES" Then
                    objvoz.Validacion = "FALLA DES"
                    objvoz.Modificar_Bandejas_Estado_Escalado()
                End If
                '---Voz---' guardo estado escalado
                If lblcampaña.Text = "VOZ" Then
                    objvoz.Validacion = "VOZ"
                    objvoz.Modificar_Bandejas_Estado_Escalado()
                End If
                '---Inbound---' guardo estado escalado
                If lblcampaña.Text = "INBOUND" Then
                    objvoz.Validacion = "INBOUND"
                    objvoz.Modificar_Bandejas_Estado_Escalado()
                End If
            End If

            lblcampaña.Text = ""
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Seguimiento ingresado con éxito"
            txtcpd.Text = ""
            txtcaso.Text = ""
            txtobs.Text = ""
            chkanula.Checked = False
            casosptes()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub guardacrm()
        Dim objvoz As New clsvoz
        Dim objdatos As New clscrmdatos
        Try
            'caso
            objvoz.caso = txtcaso.Text
            objdatos.caso = txtcaso.Text
            'Observacion
            If txtobs.Text = "" Then
                objvoz.obs = ""
                objdatos.obs = ""
            Else
                objvoz.obs = txtobs.Text
                objdatos.obs = txtobs.Text
            End If
            'Tipificacion
            If chkanula.Checked = True Then
                objvoz.tipificacion = "Devuelto"
                objdatos.tipificacion = "Devuelto"
            Else
                objvoz.tipificacion = "Reportado"
                objdatos.tipificacion = "Reportado"
            End If
            'usuario
            objvoz.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            If lblcampaña.Text = "DILO" Then
                objvoz.registrocrmfallareddilo()
            End If
            If lblcampaña.Text = "DATOS" Or lblcampaña.Text = "BSCS" Then
                objvoz.Validacion = "Gestion_De_Resolved_SD"
                objvoz.registrocrmfallareddatos()
            End If
            If lblcampaña.Text = "FALLA DES" Then
                If lblcampaña.Text = "FALLA DES" Then
                    objdatos.caso = txtcaso.Text
                    objdatos.Validacion = "Fidelizacion"
                    objdatos.Validacion_Registro_Inboun()
                    objvoz.caso = objdatos.min
                End If
                objvoz.Validacion = "Gestion_De_Resolved_SD"
                objvoz.registrocrmfallaredFideiza()
            End If
            If lblcampaña.Text = "VOZ" Then
                objvoz.Validacion = "Gestion_De_Resolved_SD"
                objvoz.registrocrmfallared()
            End If
            If lblcampaña.Text = "INBOUND" Then
                objdatos.preg2 = "Service"
                objdatos.registro_CRM_inbound_escalamiento()
            End If
            'objdatos.Registro_Gestion_CRM_de_SERVICES()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex
            dtggeneral.DataSource = Session("dtggeneral")
            dtggeneral.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub dtggeneral_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtggeneral.RowCommand
        Try
            Dim objdatos As New clsvoz
            'Mediante este codigo envio la identificacion del aspirante, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Seleccion" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                txtcaso.Text = dtggeneral.Rows(index).Cells(1).Text
                If txtcaso.Text <> Nothing Then
                    objdatos.caso = txtcaso.Text
                End If
                casosptes()
                Dim objgeneral As New clsgeneral
                objgeneral.cargo = txtcaso.Text
                objgeneral.Consulta_Campaña()
                lblcampaña.Text = objgeneral.cargo
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class