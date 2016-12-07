Public Class solicituddoc
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Session("Formulario") = "Solicitud y Consulta de Documentos"
                consultasolc()
                With drltipo
                    .DataSource = objdatos.consultatipocert
                    .DataTextField = "tipodoc"
                    .DataValueField = "id"
                    .DataBind()
                End With
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span>  Por favor en la casilla de ""Observación"" incluir la información detallada del requerimiento, por ejemplo, para certificación laboral: a quien va dirigida, en caso de desprendible de nómina: el periodo solicitado, etc. Entre más explícito sea, con mayor facilidad podremos colaborarle."
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
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Try
            Dim objdatos As New clsrrhh
            Dim cod = CType(Session("permisos"), clsusuario).Codnom
            If cod <> "" Then
                objdatos.codigo = cod
                If drltipo.SelectedItem.Value = 0 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>   Elija el tipo de documento a solicitar"
                    Exit Sub
                Else
                    objdatos.tipodoc = drltipo.SelectedItem.Value
                End If
                If txtobs.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>  Describa la observación de la solicitud, sea lo más detallado posible"
                    Exit Sub
                Else
                    objdatos.obs = txtobs.Text
                End If
                objdatos.registrosolicdoc()
                drltipo.SelectedValue = 0
                txtobs.Text = ""
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Solicitud registrada con éxito, el área administrativa le estará respondiendo antes de 3 días"
                consultasolc()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Private Sub consultasolc()
        Try
            Dim objdatos As New clsrrhh
            objdatos.codigo = CType(Session("permisos"), clsusuario).Codnom
            dtggeneral.DataSource = objdatos.consultasolicdoc
            dtggeneral.DataBind()
            Lblcuenta.Text = objdatos.cantidad
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class