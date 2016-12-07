Public Class liberaasignacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Liberar Asignación Escalamiento"
                Dim objdatos As New clsgeneral
                With drlusuario
                    .DataSource = objdatos.consultaagenteescala
                    .DataTextField = "nombreu"
                    .DataValueField = "idusuario"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim actualizar As New clsvoz
        Try
            actualizar.idusuario = Me.drlusuario.SelectedItem.Value
            actualizar.idcrm = CType(Session("permisos"), clsusuario).usuario
            For Each row As GridViewRow In dtggeneral.Rows
                actualizar.caso = (row.Cells(0).Text)
                actualizar.liberaasigecalam()
            Next
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Liberación realizada con éxito"
            dtggeneral.DataSource = Nothing
            dtggeneral.DataBind()
            lblcantidad.Text = ""
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            Dim objdatos As New clsvoz
            objdatos.idusuario = drlusuario.SelectedItem.Value
            dtggeneral.DataSource = objdatos.consultaasignado
            dtggeneral.DataBind()
            lblcantidad.Text = "Casos Asignados sin Proceso:  " & objdatos.cantidad
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class