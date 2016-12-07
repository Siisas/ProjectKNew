Public Class consnovxusu
    Inherits System.Web.UI.Page
    Dim cod As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Session("Formulario") = "Novedades por usuario"
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

    Protected Sub btnconsultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnconsultar.Click
        Try
            Dim objdatos As New clsrrhh
            cod = CType(Session("permisos"), clsusuario).Codnom
            If cod <> "" Then
                objdatos.codigo = cod
                If txtfcini.Text <> "" Then
                    objdatos.fcnovedad = txtfcini.Text
                End If
                If txtfcfin.Text <> "" Then
                    objdatos.fcregistro = txtfcfin.Text
                End If
                Pnl_dtggeneral.Visible = True
                dtggeneral.DataSource = objdatos.consultanovedad
                dtggeneral.DataBind()
                lblcuenta.Text = objdatos.cantidad
                If lblcuenta.Text = 0 Then
                    Pnl_dtggeneral.Visible = False
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No se encontraron registros"
                Else
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span>  Busqueda Exitosa!"
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class