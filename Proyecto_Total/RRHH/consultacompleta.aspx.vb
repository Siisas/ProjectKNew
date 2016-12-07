Imports System.IO
Public Class consultacompleta
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                Session("Formulario") = "Consulta Recursos Humanos"
                objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                objdatos.consultacod()
                With drlarea
                    .DataSource = objdatos.consultaarea
                    .DataTextField = "area"
                    .DataValueField = "idarea"
                    .DataBind()
                End With

            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Sub buscarinf()
        Dim objdatos As New clsrrhh
        If txtdocumento.Text <> "" Then
            objdatos.documento = txtdocumento.Text
        End If
        If txtcodigo.Text <> "" Then
            objdatos.codigo = txtcodigo.Text
        End If
        If txtnombre.Text <> "" Then
            objdatos.nombres = txtnombre.Text
        End If
        If txtapellido.Text <> "" Then
            objdatos.apellidos = txtapellido.Text
        End If
        If drlarea.SelectedItem.Value <> 0 Then
            objdatos.area = drlarea.SelectedItem.Value
        End If
        If drlestado.SelectedItem.Value <> "0" Then
            objdatos.estado = drlestado.SelectedItem.Value
        End If
        dtggeneral.DataSource = objdatos.consultapersonal
        dtggeneral.DataBind()
        lblcantgral.Text = objdatos.cantidad
        If txtcodigo.Text = "" And txtdocumento.Text = "" Then
            lblcanthist.Text = "0"
            lblcantcheck.Text = "0"
            lblcantnov.Text = "0"
        End If
        If txtdocumento.Text <> "" Then
            dtghistorico.DataSource = objdatos.consultahistorico
            dtghistorico.DataBind()
            lblcanthist.Text = objdatos.cantidad
            objdatos.documento = txtdocumento.Text
            dtgcheck.DataSource = objdatos.consultacheck
            dtgcheck.DataBind()
            lblcantcheck.Text = objdatos.cantidad

            objdatos.documento = txtdocumento.Text
            dtgnovedad.DataSource = objdatos.consultanovedad
            dtgnovedad.DataBind()
            lblcantnov.Text = objdatos.cantidad
        Else
            dtghistorico.DataSource = Nothing
            dtghistorico.DataBind()
            dtgcheck.DataSource = Nothing
            dtgcheck.DataBind()
        End If
        If txtcodigo.Text <> "" Then
            objdatos.codigo = txtcodigo.Text
            dtghistorico.DataSource = objdatos.consultahistorico
            dtghistorico.DataBind()
            lblcanthist.Text = objdatos.cantidad

            objdatos.codigo = txtcodigo.Text
            dtgcheck.DataSource = objdatos.consultacheck
            dtgcheck.DataBind()
            lblcantcheck.Text = objdatos.cantidad

            objdatos.codigo = txtcodigo.Text
            dtgnovedad.DataSource = objdatos.consultanovedad
            dtgnovedad.DataBind()
            lblcantnov.Text = objdatos.cantidad
        End If

        lblmsg.Text = ""
    End Sub
    Protected Sub btnconsultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnconsultar.Click
        Try
            dtggeneral.PageIndex = 0
            buscarinf()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Sub crearexcel()
        Dim sb As New StringBuilder
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim form = New HtmlForm
        Dim r As New clsrrhh
        Dim objdtsconsultaxls As New DataSet
        Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
        If lblcantgral.Text <> 0 Then
            If lblcantgral.Text < 20001 Then
                If txtdocumento.Text <> "" Then
                    r.documento = txtdocumento.Text
                End If
                If txtcodigo.Text <> "" Then
                    r.codigo = txtcodigo.Text
                End If
                If txtnombre.Text <> "" Then
                    r.nombres = txtnombre.Text
                End If
                If txtapellido.Text <> "" Then
                    r.apellidos = txtapellido.Text
                End If
                If drlarea.SelectedItem.Value <> 0 Then
                    r.area = drlarea.SelectedItem.Value
                End If
                If drlestado.SelectedItem.Value <> "0" Then
                    r.estado = drlestado.SelectedItem.Value
                End If
                dtgxls.DataSource = r.consultapersonal
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
    End Sub
    Protected Sub btnxls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnxls.Click
        Try
            crearexcel()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub lnkgneral_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnkgneral.Click
        dtggeneral.Visible = True
        dtghistorico.Visible = False
        dtgcheck.Visible = False
        dtgnovedad.Visible = False
    End Sub
    Protected Sub lnkhistorico_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnkhistorico.Click
        dtggeneral.Visible = False
        dtghistorico.Visible = True
        dtgcheck.Visible = False
        dtgnovedad.Visible = False
    End Sub
    Protected Sub lnkcheck_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnkcheck.Click
        dtggeneral.Visible = False
        dtghistorico.Visible = False
        dtgcheck.Visible = True
        dtgnovedad.Visible = False
    End Sub
    Protected Sub lnkcheck0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnkcheck0.Click
        dtggeneral.Visible = False
        dtghistorico.Visible = False
        dtgcheck.Visible = False
        dtgnovedad.Visible = True
    End Sub
End Class