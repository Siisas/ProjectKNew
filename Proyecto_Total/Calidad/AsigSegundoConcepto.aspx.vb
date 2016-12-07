Imports System.IO

Public Class AsigsSegundoConcepto
    Inherits System.Web.UI.Page
    Dim objdatos As New clscalidad
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
            lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
            LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
            LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
            If LblSupervisor.Text = "" Then
                LblSuperVisorTitulo.Visible = False
            End If
            ''''' INICIO SEGURIDAD ACCESO URL '''''
            Dim objGeneral As New clsgeneral
            objGeneral.DtsSeguridad = Session("dtsSeguridad")
            objGeneral.Consulta_Proyecto_Seguridad()
            objGeneral.PaginaAcceso = "~" + Mid(Request.RawUrl, Integer.Parse(objGeneral.nombreentidad))
            objGeneral.idusuario = CType(Session("permisos"), clsusuario).usuario
            objGeneral.PermisosUrl()
            ''''' FIN SEGURIDAD ACCESO URL '''''    
        End If
        CargarInfo()
    End Sub
    Sub CargarInfo()
        Pnl2.Visible = True
        objdatos.Validacion = 1
        Session("dtsB") = objdatos.segundoconceptocaso()
        DtgAuditoria.DataSource = Session("dtsB")
        DtgAuditoria.DataBind()
        BtnActualizar.Visible = True
        BtnExportar.Visible = True
        objdatos.Validacion = 0
    End Sub

    Protected Sub DtgAuditoria_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles DtgAuditoria.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                If DataBinder.Eval(e.Row.DataItem, "Estado") = "Pendiente" Then
                    e.Row.Cells(7).BackColor = Drawing.Color.FromName("#B3C556")
                    e.Row.Cells(7).ForeColor = Drawing.Color.Black
                End If
                If (e.Row.RowType = DataControlRowType.DataRow) Then
                    If DataBinder.Eval(e.Row.DataItem, "Estado") = "Asignado" Then
                        e.Row.Cells(7).BackColor = Drawing.Color.FromName("#ff6347")
                        e.Row.Cells(7).ForeColor = Drawing.Color.Black
                    End If
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub DtgAuditoria_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles DtgAuditoria.RowCommand
        Try
            If e.CommandName = "Solicitar" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                Dim Valor As String = DtgAuditoria.Rows(index).Cells(7).Text
                LblCod_SegCocepto.Text = DtgAuditoria.Rows(index).Cells(0).Text
                If Valor = "Asignado" Then
                    Pnl1.Visible = False
                    lblmsg.Text = "Segundo concepto en proceso"
                    Exit Sub
                ElseIf Valor = "Ratifica" Or Valor = "No Aplica" Or Valor = "No Ratifica" Then
                    lblmsg.Text = "Segundo concepto realizado"
                    Pnl1.Visible = False
                    Exit Sub
                Else
                    lblmsg.Text = ""
                    Pnl1.Visible = True
                    With drlAuditor
                        objdatos.Validacion = 6
                        .DataSource = objdatos.segundoconceptocaso
                        .DataTextField = "nombreu"
                        .DataValueField = "idusuario"
                        .DataBind()
                    End With
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
    Sub Asignar()
        Try
            objdatos.Auditor = drlAuditor.SelectedItem.Value
            objdatos.Codigo_reg = LblCod_SegCocepto.Text
            objdatos.registrosegundoconcepto()
            CargarInfo()
            LblCod_SegCocepto.Text = ""
            Pnl1.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnAsignar_Click(sender As Object, e As EventArgs) Handles BtnAsignar.Click
        Try
            objdatos.Validacion = 3
            Asignar()
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
    Protected Sub BtnDevolver_Click(sender As Object, e As EventArgs) Handles BtnDevolver.Click
        Try

            objdatos.Validacion = 4
            objdatos.razon = lblusuario.Text
            Asignar()
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Try
            Pnl1.Visible = False
            Pnl2.Visible = True
            CargarInfo()
            LblCod_SegCocepto.Text = ""
            Pnl1.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
    Protected Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            Pnl1.Visible = False
            Pnl2.Visible = True
            CargarInfo()
            LblCod_SegCocepto.Text = ""
            Pnl1.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
    Protected Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Try
            If DtgAuditoria.Visible = False Then
                lblmsg.Text = "No tiene casos asignados"
                Exit Sub
            End If
            Dim sb As New StringBuilder
            Dim sw As New StringWriter(sb)
            Dim htw As New HtmlTextWriter(sw)
            Dim pagina As Page = New Page
            Dim form = New HtmlForm
            Dim nuevo As New GridView
            Dim objdtsconsultaxls As New DataSet
            Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
            pagina.EnableEventValidation = False
            pagina.DesignerInitialize()
            pagina.Controls.Add(form)
            nuevo.DataSource = Session("dtsB")
            nuevo.DataBind()
            nuevo.AllowPaging = True
            nuevo.CellPadding = "4"
            nuevo.ForeColor = Drawing.Color.FromName("#333333")
            nuevo.GridLines = GridLines.None
            nuevo.Font.Size = FontSize.XXLarge
            nuevo.RowStyle.BackColor = Drawing.Color.FromName("#F7F6F3")
            nuevo.RowStyle.ForeColor = Drawing.Color.FromName("#333333")
            nuevo.FooterStyle.BackColor = Drawing.Color.FromName("#B3C556")
            nuevo.FooterStyle.Font.Bold = True
            nuevo.FooterStyle.ForeColor = Drawing.Color.White
            nuevo.PagerStyle.BackColor = Drawing.Color.FromName("#B3C556")
            nuevo.PagerStyle.ForeColor = Drawing.Color.White
            nuevo.PagerStyle.HorizontalAlign = HorizontalAlign.Center
            nuevo.SelectedRowStyle.BackColor = Drawing.Color.FromName("#E2DED6")
            nuevo.SelectedRowStyle.Font.Bold = True
            nuevo.SelectedRowStyle.ForeColor = Drawing.Color.FromName("#333333")
            nuevo.HeaderStyle.BackColor = Drawing.Color.FromName("#B3C556")
            nuevo.HeaderStyle.Font.Bold = False
            nuevo.HeaderStyle.ForeColor = Drawing.Color.White
            nuevo.HeaderStyle.Font.Size = FontSize.XXLarge
            nuevo.EditRowStyle.BackColor = Drawing.Color.FromName("#999999")
            nuevo.AlternatingRowStyle.BackColor = Drawing.Color.White
            nuevo.AlternatingRowStyle.ForeColor = Drawing.Color.FromName("#8F9E45")
            form.Controls.Add(nuevo)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=SegundoConcepto.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
End Class