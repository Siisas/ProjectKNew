Public Class Solicitud
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                objdatos.idusuario = lblusuario.Text
                objdatos.consultacod()
                If objdatos.estado = 12 Then
                    lblmsg.Text = "Su perfil no se encuentra habilitado para registrar solicitudes, por favor contacte al administrador"
                    Exit Sub
                    btnguardar.Enabled = False
                End If
                With drltiposolicitud
                    .DataSource = objdatos.consultatiposolic
                    .DataTextField = "descsolicitud"
                    .DataValueField = "idtipo"
                    .DataBind()
                End With
                With drlpriorizacion
                    .DataSource = objdatos.consultaprioridad
                    .DataTextField = "descprioridad"
                    .DataValueField = "idprioridad"
                    .DataBind()
                End With
                With drltiposolicitudcons
                    .DataSource = objdatos.consultatiposolic
                    .DataTextField = "descsolicitud"
                    .DataValueField = "idtipo"
                    .DataBind()
                End With
                With drlpriorizacioncons
                    .DataSource = objdatos.consultaprioridad
                    .DataTextField = "descprioridad"
                    .DataValueField = "idprioridad"
                    .DataBind()
                End With
                With drlestado
                    .DataSource = objdatos.consultaestado
                    .DataTextField = "descestado"
                    .DataValueField = "idestado"
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
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
  
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Try
            lblticket.Visible = False
            Dim Fn As String
            Dim SaveLocation As String
            Dim objdatos As New clssolicitud
            If Fluadjunto.HasFile Then
                Fn = System.IO.Path.GetFileName(Fluadjunto.PostedFile.FileName)
                SaveLocation = Server.MapPath("data") & "\\" & Fn
                Fluadjunto.PostedFile.SaveAs(SaveLocation)
                objdatos.archivo = Fn
            Else
                objdatos.archivo = ""
            End If

            If drltiposolicitud.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el tipo de solicitud requerida"
                Exit Sub
            Else
                objdatos.tiposolic = drltiposolicitud.SelectedItem.Value
            End If
            If drlpriorizacion.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione la prioridad asignada a la solicitud"
                Exit Sub
            Else
                objdatos.prioridad = drlpriorizacion.SelectedItem.Value
            End If
            If txtobs.Text = "" Then
                lblmsg.Text = "Digite la observación de atención al caso"
                Exit Sub
            Else
                objdatos.obs = txtobs.Text
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.registrosolic()
            lblmsg.Text = "Solcitid registrada con éxito"
            traeconsecutivo()
            EnviarCorreo()
            txtobs.Text = ""
            drlpriorizacion.SelectedValue = 0
            drltiposolicitud.SelectedValue = 0

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Public Sub EnviarCorreo()
        Dim correo As New System.Net.Mail.MailMessage
        Dim smtp As New System.Net.Mail.SmtpClient
        'Envio correo 3
        correo.From = New System.Net.Mail.MailAddress("solicitudes@comunicaciones-moviles.com")
        correo.To.Add("pedro.rojas@comunicaciones-moviles.com")
        correo.Subject = "Nueva solicitud Claro con prioridad " & drlpriorizacion.SelectedItem.Text
        correo.Body = txtobs.Text & "               No responder a este correo"
        correo.IsBodyHtml = False
        correo.Priority = System.Net.Mail.MailPriority.Normal
        smtp.Host = "smtp.comunicaciones-moviles.com"
        smtp.Credentials = New System.Net.NetworkCredential("pedro.rojas@comunicaciones-moviles.com", "pedro.rojas")
        smtp.Send(correo)

        'Envio correo 2
        correo.From = New System.Net.Mail.MailAddress("solicitudes@comunicaciones-moviles.com")
        correo.To.Add("viviana.ortiz@comunicaciones-moviles.com")
        correo.Subject = "Nueva solicitud Claro con prioridad " & drlpriorizacion.SelectedItem.Text
        correo.Body = txtobs.Text & "               No responder a este correo"
        correo.IsBodyHtml = False
        correo.Priority = System.Net.Mail.MailPriority.Normal
        smtp.Host = "smtp.comunicaciones-moviles.com"
        smtp.Credentials = New System.Net.NetworkCredential("viviana.ortiz@comunicaciones-moviles.com", "iphone2011")
        smtp.Send(correo)


    End Sub
    Protected Sub traeconsecutivo()
        Try
            Dim objdatos As New clssolicitud
            objdatos.tiposolic = drltiposolicitud.SelectedItem.Value
            objdatos.prioridad = drlpriorizacion.SelectedItem.Value
            objdatos.idusuario = lblusuario.Text
            objdatos.traeconsecutivo()
            lblticket.Text = lblticket.Text & " " & objdatos.idreg
            lblticket.Visible = True
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub lnknueva_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnknueva.Click
        pnnueva.Visible = True
        lnknueva.ForeColor = Drawing.Color.Black
        lnkseguimiento.ForeColor = Drawing.Color.Blue
        lnkconsulta.ForeColor = Drawing.Color.Blue
        pnconsulta.Visible = False
        pnnueva.Visible = True
        pnseguimiento.Visible = False

        lblmsg.Text = ""
    End Sub

    Protected Sub lnkseguimiento_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnkseguimiento.Click
        lnknueva.ForeColor = Drawing.Color.Blue
        lnkseguimiento.ForeColor = Drawing.Color.Black
        lnkconsulta.ForeColor = Drawing.Color.Blue
        pnconsulta.Visible = False
        pnnueva.Visible = False
        pnseguimiento.Visible = True
        lblmsg.Text = ""
    End Sub
    Protected Sub consultar()
        Try
            Dim objdatos As New clssolicitud
            If txtidreg.Text <> "" Then
                objdatos.idreg = txtidreg.Text
            Else
                lblmsg.Text = "Digite el número de caso a consultar"
                Exit Sub
            End If
            dtggeneral.DataSource = objdatos.consultaseguimientosclaro
            dtggeneral.DataBind()

            objdatos.consultasolic()
            If objdatos.cantidad > 0 Then

                lbltipo.Text = objdatos.tiposolic
                lblprioridad.Text = objdatos.prioridad
                lbldescrip.Text = objdatos.obs
                lblestado.Text = objdatos.estado
                lblfcprobable.Text = objdatos.fcprobable
                lblidsolic.Text = objdatos.idreg
                hpladjunto.Text = objdatos.archivo
                hpladjunto.NavigateUrl = "~/SolicClaro/data/" & objdatos.archivo
            Else
                lbltipo.Text = ""
                lblprioridad.Text = ""
                lbldescrip.Text = ""
                lblestado.Text = ""
                lblfcprobable.Text = ""
                lblidsolic.Text = ""
                hpladjunto.Text = ""
                hpladjunto.NavigateUrl = Nothing
            End If

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub btnconsultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnconsultar.Click
        Try
            consultar()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardarseg_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardarseg.Click
        Try
            If lblestado.Text = "Cerrado" Then
                lblmsg.Text = "La solicitud se encuentra cerrada y no se puede generar seguimientos, si se requiere cree una nueva solicitud"
                Exit Sub
            End If
            Dim Fn As String
            Dim SaveLocation As String
            Dim objdatos As New clssolicitud
            If Fluadjuntoseg.HasFile Then
                Fn = System.IO.Path.GetFileName(Fluadjuntoseg.PostedFile.FileName)
                SaveLocation = Server.MapPath("data") & "\\" & Fn
                Fluadjuntoseg.PostedFile.SaveAs(SaveLocation)
                objdatos.archivo = Fn
            Else
                objdatos.archivo = ""
            End If
            If txtobsseg.Text = "" Then
                lblmsg.Text = "Digite la observación de atención al caso"
                Exit Sub
            Else
                objdatos.obs = txtobsseg.Text
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.idreg = lblidsolic.Text
            objdatos.registroseguimiento()
            lblmsg.Text = "Solcitid registrada con éxito"
            actualizaestado()
            consultar()
            txtobsseg.Text = ""
            lbltipo.Text = ""
            lblprioridad.Text = ""
            lbldescrip.Text = ""
            lblestado.Text = ""
            lblfcprobable.Text = ""
            lblidsolic.Text = ""
            hpladjunto.Text = ""
            hpladjunto.NavigateUrl = Nothing
            txtidreg.Text = ""

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub actualizaestado()
        Try
            Dim objdatos As New clssolicitud
            objdatos.idreg = lblidsolic.Text
            objdatos.estado = 2
            objdatos.Actualizaestado()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub lnkconsulta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnkconsulta.Click
        lnknueva.ForeColor = Drawing.Color.Blue
        lnkseguimiento.ForeColor = Drawing.Color.Blue
        lnkconsulta.ForeColor = Drawing.Color.Black
        pnconsulta.Visible = True
        pnnueva.Visible = False
        pnseguimiento.Visible = False
        lblmsg.Text = ""
    End Sub
    Protected Sub consultagral()
        Try
            Dim objdatos As New clssolicitud
            If txtidregconsulta.Text <> "" Then
                objdatos.idreg = txtidregconsulta.Text
            End If
            If drlestado.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.estado = drlestado.SelectedItem.Value
            End If
            If drltiposolicitudcons.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.tiposolic = drltiposolicitudcons.SelectedItem.Value
            End If
            If drlpriorizacioncons.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.prioridad = drlpriorizacioncons.SelectedItem.Value
            End If
            dtgconsulta.DataSource = objdatos.consultasolicitudes
            dtgconsulta.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub btnconsultar0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnconsultar0.Click
        Try
            consultagral()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Private Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            consultar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub dtgconsulta_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgconsulta.PageIndexChanging
        Try
            dtgconsulta.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            consultagral()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class