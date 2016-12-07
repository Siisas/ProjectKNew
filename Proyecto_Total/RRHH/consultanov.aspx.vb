Imports System.IO
Public Class consultanov
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Session("Formulario") = " Consulta de Novedades General"
                cargadrl()
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
    Protected Sub cargadrl()
        Dim objdatos As New clsgeneral
        With drltiponov
            .DataSource = objdatos.consultatipoact
            .DataTextField = "descripcioninasistencia"
            .DataValueField = "idinasistencia"
            .DataBind()
        End With
        objdatos.tipo = drltiponov.SelectedItem.Text
        With drltipificacion
            .DataSource = objdatos.consultatiponoved
            .DataTextField = "desctipo"
            .DataValueField = "idtipo"
            .DataBind()
        End With
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
                Response.AddHeader("Content-Disposition", "attachment;filename=Reporte de novedades.xls")
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
    Protected Sub DtgControl_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex
            dtggeneral.DataSource = Session("dtggeneral")
            dtggeneral.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Sub buscarinf()
        Try
            Dim objdatos As New clsrrhh
            Dim val As Boolean = False
            If txtcod.Text <> "" Then
                objdatos.codigo = txtcod.Text
                val = True
            End If
            If rdbreporta.SelectedItem.Value <> "0" Then
                objdatos.reporta = rdbreporta.SelectedItem.Value
                val = True
            End If
            If drltiponov.SelectedItem.Value <> 0 Then
                objdatos.tiponov = drltiponov.SelectedItem.Value
                val = True
            End If
            If drltipificacion.SelectedItem.Value <> 0 Then
                objdatos.tipificacion = drltipificacion.SelectedItem.Value
                val = True
            End If
            If txtfcini.Text <> "" Then
                objdatos.fcnovedad = txtfcini.Text
                val = True
            End If
            If txtfcfin.Text <> "" Then
                objdatos.fcregistro = txtfcfin.Text
                val = True
            End If
            If val = True Then
                panel1.Visible = True
                Session("dtggeneral") = objdatos.consultanovedad
                dtggeneral.DataSource = Session("dtggeneral")
                dtggeneral.DataBind()
                Lblcuenta.Text = objdatos.cantidad
                lblmsg.Text = ""
            Else
            Pnl_Message.CssClass = "alert alert-warning"
            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Realice algun filtro de consulta"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try

    End Sub
    Protected Sub btnvalidar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnvalidar.Click
        buscarinf()
    End Sub
    Protected Sub drltiponov_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drltiponov.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.tipo = drltiponov.SelectedValue
            With drltipificacion
                .DataSource = objdatos.consultatiponoved
                .DataTextField = "desctipo"
                .DataValueField = "idtipo"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class