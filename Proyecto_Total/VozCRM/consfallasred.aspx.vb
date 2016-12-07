Imports System.IO
Public Class consfallasred
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Consulta General Fallas de Red"
                Dim objdatos As New clsgeneral
                With drlestadocpd
                    .DataSource = objdatos.consultaestadocpd
                    .DataTextField = "estadocpd"
                    .DataValueField = "idestadocpd"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            Dim objdatos As New clsvoz
            If txtcaso.Text = "" And txtcliente.Text = "" And txtmin.Text = "" And drlbandeja.SelectedItem.Value = "0" And chkpteescala.Checked = False And drlestadocpd.SelectedItem.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite algún criterio de filtro antes de realizar la consulta"
                Exit Sub
            Else
                Pnl_Message.CssClass = Nothing
                lblmsg.Text = Nothing
            End If
            If txtmin.Text <> Nothing Then
                objdatos.min = txtmin.Text
            End If
            If txtcaso.Text <> Nothing Then
                objdatos.caso = txtcaso.Text
            End If
            If txtcliente.Text <> Nothing Then
                objdatos.cliente = txtcliente.Text
            End If
            If drlbandeja.SelectedItem.Value <> "0" Then
                objdatos.mesa = drlbandeja.SelectedItem.Value
            End If
            If chkpteescala.Checked = True Then
                objdatos.escala = 1
            End If
            If drlestadocpd.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.estadoinc = drlestadocpd.SelectedItem.Text
            End If
            Session("dtggeneral") = objdatos.consultagralfallas
            dtggeneral.DataSource = Session("dtggeneral")
            dtggeneral.DataBind()
            lblcuenta.Text = "Información General: " & objdatos.cantidad
            'seguimientos
            If txtcaso.Text = Nothing And txtmin.Text = Nothing Then
                Session("dtgseguimiento") = Nothing
                dtgseguimiento.DataSource = Session("dtgseguimiento")
                dtgseguimiento.DataBind()
                lblcuenta0.Text = ""
            Else
                Session("dtgseguimiento") = objdatos.consultasegvoz
                dtgseguimiento.DataSource = Session("dtgseguimiento")
                dtgseguimiento.DataBind()
                lblcuenta0.Text = "Seguimientos: " & objdatos.cantidad
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub btnxls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnxls.Click
        Try
            Dim sw As New StringWriter()
            Dim hw As New HtmlTextWriter(sw)
            Dim tabla As New Table()
            Dim tr1 As New TableRow()
            Dim cell1 As New TableCell()
            Dim Val As Boolean = False
            Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"
            If dtggeneral.Rows.Count > 0 And dtggeneral.Rows.Count < 8101 Then
                Val = True
                dtggeneral.AllowPaging = False
                dtggeneral.DataSource = Session("dtggeneral")
                dtggeneral.DataBind()
                cell1.Controls.Add(dtggeneral)
                tr1.Cells.Add(cell1)
                tabla.Rows.Add(tr1)
                tabla.RenderControl(hw)
                dtggeneral.AllowPaging = True
            ElseIf dtggeneral.Rows.Count > 8100 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Se denego el permiso de exportacion debido a que exede el limite de registros; Realice otro filtro y reintente exportar! "
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span Class='glyphicon glyphicon-warning-sign'></span> ¡No se encontraron registros para realizar la exportacion! "
            End If
            If Val = True Then
                Response.Clear()
                Response.Buffer = True
                Response.AddHeader("Content-Disposition", "attachment;filename=Data.xls")
                Response.Charset = "UTF-8"
                Response.ContentType = "application/vnd.ms-excel"
                Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                Response.Write(style)
                Response.Output.Write(sw.ToString())
                Response.End()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Private Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex
            dtggeneral.DataSource = Session("dtggeneral")
            dtggeneral.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub dtgseguimiento_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgseguimiento.PageIndexChanging
        Try
            dtgseguimiento.PageIndex = e.NewPageIndex
            dtgseguimiento.DataSource = Session("dtgseguimiento")
            dtgseguimiento.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class