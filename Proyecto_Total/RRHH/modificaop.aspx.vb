Public Class modificaop
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Modificaciones Operativas"
                Dim objdatos As New clsgeneral
                With drlactualizacion
                    .DataSource = objdatos.consultatipoactualizacion
                    .DataTextField = "tipoactualizacion"
                    .DataValueField = "idactualizacion"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Sub buscarinf()
        Dim objdatos As New clsrrhh
        If txtcod.Text <> "" Then
            objdatos.codigo = txtcod.Text
            dtggeneral.DataSource = objdatos.consultapersonal
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
            If lblcuenta.Text <> 0 Then
                dtg.Visible = True
            Else
                dtg.Visible = False
            End If
        End If
        Pnl_Message.CssClass = Nothing
        lblmsg.Text = Nothing
    End Sub

    Protected Sub btnvalidar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnvalidar.Click
        Try
            Dim objdatos As New clsrrhh
            If txtcod.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el código de usuario al que desea registrar la novedad"
            Else
                objdatos.codigo = txtcod.Text
                objdatos.consultadotac()
                If objdatos.cantidad > 0 Then
                    lblnombre.Text = objdatos.nombres & " " & objdatos.apellidos
                    lblidentif.Text = objdatos.documento
                    txtgrupo.Text = objdatos.grupo
                    txtobs.Text = objdatos.obs
                    drlturno.SelectedValue = objdatos.turno
                    buscarinf()
                Else
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> El código no se encuentran creado en la base de datos, revise la información"
                    lblnombre.Text = ""
                    txtgrupo.Text = ""
                    txtobs.Text = ""
                    lblidentif.Text = ""
                    drlturno.SelectedValue = "0"
                    dtggeneral.DataSource = Nothing
                    dtggeneral.DataBind()
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clsrrhh
        Try
            If lblnombre.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el código del empleado que desea consultar junto con el ID del registro que desea modificar"
            Else
                objdatos.codigo = txtcod.Text
                If txtgrupo.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el grupo asignado"
                    Exit Sub
                Else
                    objdatos.grupo = txtgrupo.Text
                End If
                If txtobs.Text = Nothing Then
                    objdatos.obs = ""
                Else
                    objdatos.obs = txtobs.Text
                End If
                If drlturno.SelectedItem.Value = "0" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija el turno asignado"
                    Exit Sub
                Else
                    objdatos.turno = drlturno.SelectedItem.Value
                End If
                objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                objdatos.modificaop()
                buscarinf()
                txtcod.Text = ""
                lblnombre.Text = ""
                txtgrupo.Text = ""
                txtobs.Text = ""
                drlturno.SelectedValue = "0"
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Actualización ingresada con éxito"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub btnactualiza0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnactualiza0.Click
        Try
            Dim objdatos As New clsrrhh
            If lblidentif.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija el empleado al cual desea registrarle un evento histórico"
                Exit Sub
            Else
                objdatos.documento = lblidentif.Text
            End If
            If drlactualizacion.SelectedItem.Value = 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija una opción de modificación realizada"
                Exit Sub
            Else
                objdatos.actualizacion = drlactualizacion.SelectedItem.Value
            End If
            If txtdescripcion.Text = "" Then
                objdatos.descripcionac = ""
            Else
                objdatos.descripcionac = txtdescripcion.Text
            End If
            If drlactualizacion.SelectedItem.Value = 29 And TxtCompromisoMejora.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese un compromiso de mejora"
                Exit Sub
            Else
                objdatos.Comp_Mejora = TxtCompromisoMejora.Text
            End If
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.registrohistorico()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Histórico registrado con éxito"
            drlactualizacion.SelectedValue = 0
            txtdescripcion.Text = ""
            TxtCompromisoMejora.Text = ""
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub drlactualizacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlactualizacion.SelectedIndexChanged
        If drlactualizacion.SelectedItem.Value = "29" Then
            TxtCompromisoMejora.Enabled = True
        Else
            TxtCompromisoMejora.Enabled = False
        End If
    End Sub
End Class