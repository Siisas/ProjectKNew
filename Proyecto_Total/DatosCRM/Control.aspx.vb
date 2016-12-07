Public Class Control
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "	Registro CRM Control"
                Dim objdatos As New clsgeneral
                With drltipificacionll
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultatipctrl
                    .DataTextField = "tipificacion"
                    .DataValueField = "idtipificacion"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
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
            If drltsoporte.SelectedItem.Value = "0" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione si se realizó soporte o no"
                Exit Sub
            Else
                objdatos.tiposoporte = drltsoporte.SelectedItem.Text
            End If
            If drltipificacionll.SelectedItem.Value = 21 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione la tipificación de la llamada"
                Exit Sub
            Else
                objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            End If
            If txtobs.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite la observación de atención al caso"
                Exit Sub
            Else
                objdatos.obs = txtobs.Text
            End If
            If drlmesa.SelectedItem.Value = "0" Then
                objdatos.mesa = ""
            Else
                objdatos.mesa = drlmesa.SelectedItem.Value
            End If

            If drltlinea.SelectedItem.Value = "0" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione el tipo de línea"
                Exit Sub
            Else
                objdatos.tlinea = drltlinea.SelectedItem.Value
            End If

            If drlservreest.SelectedItem.Value = "0" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione si el servicio ya fue reestablecido o no"
                Exit Sub
            Else
                objdatos.servreest = drlservreest.SelectedItem.Value
            End If
            If txtfcrestab.Text = "" Then
                objdatos.fcrest = "01/01/1900"
            Else
                objdatos.fcrest = txtfcrestab.Text
            End If
            If drlajuste.SelectedItem.Value = "0" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione si aplica realizar ajuste o no"
                Exit Sub
            Else
                objdatos.aplicaajuste = drlajuste.SelectedItem.Value
            End If
            If drlsolicajuste.SelectedItem.Value = "0" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione si el usuario solicita ajuste o no"
                Exit Sub
            Else
                objdatos.solicajuste = drlsolicajuste.SelectedItem.Value
            End If
            If txtnombrepaq.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el nombre del plan o paquete"
                Exit Sub
            Else
                objdatos.nompaquete = txtnombrepaq.Text
            End If
            If txtvlrpaq.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el valor del plan o paquete"
                Exit Sub
            Else
                objdatos.vlrpaquete = txtvlrpaq.Text
            End If
            If txtdias.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite los días que lleva sin servicio"
                Exit Sub
            Else
                objdatos.dias = txtdias.Text
            End If
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.registrocrmcontrol()
            actbandeja()
            buscarinf()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Seguimiento ingresado con éxito"
            lblcliente.Text = ""
            lblmin.Text = ""
            lblcaso.Text = ""
            lblestado.Text = ""
            txtcaso.Text = ""
            txtobs.Text = ""
            lbltickler.Text = ""
            lblfcsap.Text = ""
            drltipificacionll.SelectedValue = 21
            drltsoporte.SelectedValue = "0"
            drlmesa.SelectedValue = "0"
            drltlinea.SelectedValue = "0"
            drlservreest.SelectedValue = "0"
            txtfcrestab.Text = ""
            drlajuste.SelectedValue = "0"
            drlsolicajuste.SelectedValue = "0"
            txtnombrepaq.Text = ""
            txtvlrpaq.Text = ""
            txtdias.Text = ""
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Sub actbandeja()
        Try
            Dim objdatos As New clscrmdatos
            If lblestado.Text <> "Cerrado" Then
                If txtcaso.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el caso que desea registrar"
                    Exit Sub
                Else
                    objdatos.caso = txtcaso.Text
                End If
                If drltipificacionll.SelectedItem.Value = 0 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione la tipificación de la llamada"
                    Exit Sub
                Else
                    objdatos.tipificacion = drltipificacionll.SelectedItem.Text
                End If
                objdatos.modificarbandejacontrol()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Sub buscarinf()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el Caso o Min que desea consultar"
            Else
                If txtcaso.Text <> "" Then
                    objdatos.caso = txtcaso.Text
                End If
                dtggeneral.DataSource = objdatos.consultacasocontrol
                dtggeneral.DataBind()
                lblcuenta.Text = objdatos.cantidad
                If objdatos.cantidad > 0 Then
                    lblcliente.Text = objdatos.cliente
                    lblmin.Text = objdatos.min
                    lblcaso.Text = objdatos.caso
                    lblestado.Text = objdatos.tipificacion
                    If txtcaso.Text = "" Then
                        txtcaso.Text = objdatos.caso
                    End If
                    lbltickler.Text = objdatos.tickler
                    lblfcsap.Text = objdatos.fcsap
                    lblmsg.Text = ""
                Else
                    lblcliente.Text = ""
                    lblmin.Text = ""
                    lblcaso.Text = ""
                    lblestado.Text = ""
                    lblfcsap.Text = ""
                    lbltickler.Text = ""
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se han encontrado registros coincidentes"
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        buscarinf()
    End Sub

    Protected Sub dtggeneral_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            buscarinf()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
End Class