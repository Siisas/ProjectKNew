Imports System.IO
Public Class consinc
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Consulta Inconsistencias Datos"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            Dim objdatos As New clscrmdatos
            If drlestado.SelectedItem.Value <> "0" Then
                objdatos.tipificacion = drlestado.SelectedItem.Text
            End If
            If txtfcdesde.Text <> Nothing Then
                objdatos.fcini = txtfcdesde.Text
            End If
            If txtfchasta.Text <> Nothing Then
                objdatos.fcfin = txtfchasta.Text
            End If
            If txtcaso.Text <> Nothing Then
                objdatos.caso = txtcaso.Text
            End If
            If drlnivel.SelectedItem.Value <> "0" Then
                objdatos.barrio = drlnivel.SelectedItem.Value
            End If
            Session("dtggeneral") = objdatos.consultainc
            dtggeneral.DataSource = Session("dtggeneral")
            dtggeneral.DataBind()
            If objdatos.cantidad > 0 Then
                PnlGeneral.Visible = True
            Else
                PnlGeneral.Visible = False
            End If
            lblcuenta.Text = objdatos.cantidad
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Protected Sub btnxls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnxls.Click
        Try
            Dim sb As New StringBuilder
            Dim sw As New StringWriter(sb)
            Dim htw As New HtmlTextWriter(sw)
            Dim pagina As Page = New Page
            Dim form = New HtmlForm
            Dim r As New clscrmdatos
            Dim objdtsconsultaxls As New DataSet
            Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
            If lblcuenta.Text <> Nothing Then
                If lblcuenta.Text < 20001 Then
                    If drlestado.SelectedItem.Value <> "0" Then
                        r.tipificacion = drlestado.SelectedItem.Text
                    End If
                    If txtfcdesde.Text <> Nothing Then
                        r.fcini = txtfcdesde.Text
                    End If
                    If txtfchasta.Text <> Nothing Then
                        r.fcfin = txtfchasta.Text
                    End If
                    If txtcaso.Text <> Nothing Then
                        r.caso = txtcaso.Text
                    End If
                    If drlnivel.SelectedItem.Value <> "0" Then
                        r.barrio = drlnivel.SelectedItem.Value
                    End If
                    dtgxls.DataSource = r.consultainc
                    dtgxls.DataBind()
                    dtgxls.Visible = True
                    dtgxls.EnableViewState = False

                    pagina.EnableEventValidation = False
                    pagina.DesignerInitialize()
                    pagina.Controls.Add(form)
                    form.Controls.Add(dtgxls)
                    pagina.RenderControl(htw)
                    Response.Clear()
                    Response.Buffer = True

                    Response.ContentType = "application/vnd.ms-excel"
                    Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                    Response.AddHeader("Content-Disposition", "attachment;filename=data.xls")
                    Response.Charset = "UTF-8"
                    Response.Write(strStyle)
                    Response.Write(sb.ToString())
                    Response.End()
                Else
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No se puede generar archivo en xls, realice un filtro adicional o solicite la consulta al administrador de la base de datos"
                End If
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Realice una consulta y luego intente exportarla"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Protected Sub dtggeneral_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex
            dtggeneral.DataSource = Session("dtggeneral")
            dtggeneral.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
End Class