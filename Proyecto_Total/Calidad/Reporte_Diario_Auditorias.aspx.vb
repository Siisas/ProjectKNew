Imports System.IO
Public Class Reporte_Diario_Auditorias
    Inherits System.Web.UI.Page
    Dim objGeneral As New clsgeneral
    Dim ObjCalidad As New clscalidad
    Dim ObjDatos As New clscrmdatos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Reporte Diario Auditorias"
                cargar_drl()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub cargar_drl()
        Try
            'Campaña
            ObjCalidad.Validacion = "1"
            With drl_campaña
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With

            ObjDatos.Validacion = "1"
            With Drl_Supervisor
                .DataSource = ObjDatos.Consultar_Jefes_Productividad()
                .DataTextField = "Jefe_Inmediato"
                .DataValueField = "Jefe_Inmediato"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
            End With
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            If txt_cod_agente.Text <> "" Or Drl_Supervisor.SelectedIndex <> 0 Or drl_campaña.SelectedIndex <> 0 Or Txt_Fc_Ini.Text <> "" Or Txt_Fc_Fin.Text <> "" Then
                'CODIGO
                If txt_cod_agente.Text <> "" Then
                    ObjCalidad.agente = txt_cod_agente.Text
                Else
                    ObjCalidad.agente = ""
                End If
                'SUPERVISOR
                If Drl_Supervisor.SelectedIndex <> 0 Then
                    ObjCalidad.Supervisor = Drl_Supervisor.SelectedItem.Text
                Else
                    ObjCalidad.Supervisor = ""
                End If
                'PROCESO
                If drl_campaña.SelectedIndex <> 0 Then
                    ObjCalidad.Proceso = drl_campaña.SelectedItem.Text
                Else
                    ObjCalidad.Proceso = ""
                End If

                'Filtros de fecha
                If (Txt_Fc_Ini.Text = "" And Txt_Fc_Fin.Text <> "") Or (Txt_Fc_Ini.Text <> "" And Txt_Fc_Fin.Text = "") Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione los dos rangos de fecha"
                    dtggeneral.DataSource = Nothing
                    dtggeneral.DataBind()
                    btn_exportar.Visible = False
                    Lbl_seguimiento.Text = ""
                    Exit Sub
                End If
                If Txt_Fc_Ini.Text <> "" And Txt_Fc_Fin.Text <> "" Then
                    If Date.Parse(Txt_Fc_Ini.Text) > Date.Parse(Txt_Fc_Fin.Text) Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Fecha inicio debe ser menor a fecha fin"
                        dtggeneral.DataSource = Nothing
                        dtggeneral.DataBind()
                        btn_exportar.Visible = False
                        Lbl_seguimiento.Text = ""
                        Exit Sub
                    End If
                End If
                If Txt_Fc_Ini.Text <> "" Then
                    ObjCalidad.fcini = Txt_Fc_Ini.Text
                End If
                If Txt_Fc_Fin.Text <> "" Then
                    ObjCalidad.fcfin = Txt_Fc_Fin.Text
                End If
                Session("Reporte_Diario_Auditorias") = ObjCalidad.Consulta_REporte_diario_auditoria()
                dtggeneral.DataSource = Session("Reporte_Diario_Auditorias")
                dtggeneral.DataBind()
                If ObjCalidad.cantidad = 0 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No se encontraron registros"
                    Lbl_seguimiento.Text = "No se encontraron registros"
                    btn_exportar.Visible = False
                Else
                    Lbl_seguimiento.Text = "Registros encontrados: " + ObjCalidad.cantidad
                    btn_exportar.Visible = True
                End If
            Else
                ObjCalidad.Validacion = "Diario"
                Session("Reporte_Diario_Auditorias") = ObjCalidad.Consulta_REporte_diario_auditoria()
                dtggeneral.DataSource = Session("Reporte_Diario_Auditorias")
                dtggeneral.DataBind()
                If ObjCalidad.cantidad = 0 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No se encontraron registros"
                    Lbl_seguimiento.Text = "No se encontraron registros"
                    btn_exportar.Visible = False
                Else
                    Lbl_seguimiento.Text = "Registros encontrados: " + ObjCalidad.cantidad
                    btn_exportar.Visible = True
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub btn_exportar_Click(sender As Object, e As EventArgs) Handles btn_exportar.Click
        Try
            dtggeneral.PageSize = 20000
            dtggeneral.DataSource = Session("Reporte_Diario_Auditorias")
            dtggeneral.DataBind()
            exportar()
            dtggeneral.PageSize = 100
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Sub exportar()
        Try
            Dim sw As New StringWriter()
            Dim hw As New HtmlTextWriter(sw)
            Dim tabla As New Table()
            Dim tr1 As New TableRow()
            Dim cell1 As New TableCell()
            Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"
            If dtggeneral.Rows.Count() > 0 Then
                cell1.Controls.Add(dtggeneral)
                tr1.Cells.Add(cell1)
                tabla.Rows.Add(tr1)
                tabla.RenderControl(hw)
                Response.Clear()
                Response.Buffer = True
                Response.AddHeader("Content-Disposition", "attachment;filename=Reporte_diario_Auditoria.xls")
                Response.Charset = "UTF-8"
                Response.ContentType = "application/vnd.ms-excel"
                Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                Response.Write(style)
                Response.Output.Write(sw.ToString())
                Response.Flush()
                Response.End()
            Else
                Pnl_Message.CssClass = "alert alert-danger"
                lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Primero haga una consulta e intente Exportarla!"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub dtggeneral_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtggeneral.DataSource = Session("Reporte_Diario_Auditorias")
            dtggeneral.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class