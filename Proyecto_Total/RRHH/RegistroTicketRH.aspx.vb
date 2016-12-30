Public Class RegistroTicketRH
    Inherits System.Web.UI.Page
    Dim Message As New System.Net.Mail.MailMessage()
    Dim SMTP As New System.Net.Mail.SmtpClient
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Registro Ticket"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_GuardarRegistro_Click(sender As Object, e As EventArgs) Handles Btn_GuardarRegistro.Click

        SMTP.Credentials = New System.Net.NetworkCredential("felix.lara@kamilion.co", "Aviatur2016")
        SMTP.Host = "smtp.gmail.com"
        SMTP.Port = 587
        SMTP.EnableSsl = True
        ' CONFIGURACION DEL MENSAJE
        Message.[To].Add("sofia.borrero@kamilion.co")
        Message.[To].Add("frlara@misena.edu.co") ' Acá se escribe la cuenta de correo al que se le quiere enviar el e-mail
        '----------------------------------------------"Quien lo envía","Nombre de quien lo envía" 
        Message.From = New System.Net.Mail.MailAddress("felix.lara@kamilion.co", "Aviatur2016", System.Text.Encoding.UTF8) 'Quien envía el e-mail
        Message.Subject = "Buen día" 'Motivo o Asunto del e-mail
        Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
        Message.Body = "Este es un mensaje enviado desde el CRM de Kamilion" 'contenido del mail
        Message.BodyEncoding = System.Text.Encoding.UTF8
        Message.Priority = System.Net.Mail.MailPriority.Normal
        Message.IsBodyHtml = False

        'ENVIO
        Try
            SMTP.Send(Message)
            TxtTema.Text = "ok"
        Catch ex As System.Net.Mail.SmtpException
            Txt_Requerimientos.Text = "No"
        End Try
    End Sub



End Class