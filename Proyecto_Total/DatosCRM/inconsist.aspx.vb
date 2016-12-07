Public Class inconsist
    Inherits System.Web.UI.Page
    Dim objdatos As New clscrmdatos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Revisión y Envío de Inconsistencias"
                casosptes()

            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub casosptes()
        Try
            Session("dtggeneral") = objdatos.consultaincons
            dtggeneral.DataSource = Session("dtggeneral")
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
            Session("dtgaprobado") = objdatos.consultaaprobado
            dtgaprobado.DataSource = Session("dtgaprobado")
            dtgaprobado.DataBind()
            lblcuentaaprob.Text = objdatos.cantidad
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Try
            If txtcaso.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.Consulta_Sin_Restriccion_Envio_Inconsistencia()
            If objdatos.cantidad < 1 Or objdatos.cantidad = Nothing Then
                objdatos.consultaincons()
            End If
            If objdatos.cantidad > 0 Then
                If drlestado.SelectedItem.Value = "0" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija la tipificación de revisión de la inconsistencia"
                    Exit Sub
                Else
                    objdatos.tipificacion = drlestado.SelectedItem.Value
                End If
                objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                objdatos.actualizainc()
                casosptes()
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro ingresado con éxito"
                drlestado.SelectedValue = 0
                txtcaso.Text = ""
            Else
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> El caso " + txtcaso.Text + " no se encuentra como Reportado por favor verifique que este cargando en la tabla"
                Exit Sub
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub btnguardar0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar0.Click
        Try
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            For Each row As GridViewRow In dtgaprobado.Rows
                objdatos.caso = Int64.Parse(row.Cells(0).Text)
                objdatos.envioinc()
            Next
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Envio realizado con éxito"
            dtgaprobado.DataSource = Nothing
            dtgaprobado.DataBind()
            casosptes()
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
            Throw ex
        End Try
    End Sub
    Protected Sub dtgaprobado_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgaprobado.PageIndexChanging
        Try
            dtgaprobado.PageIndex = e.NewPageIndex
            dtgaprobado.DataSource = Session("dtgaprobado")
            dtgaprobado.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class