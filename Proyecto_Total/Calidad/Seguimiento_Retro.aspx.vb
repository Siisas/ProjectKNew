Imports System.IO

Public Class Seguimiento_Retro
    Inherits System.Web.UI.Page
    Dim objGeneral As New clsgeneral
    Dim ObjCalidad As New clscalidad
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_mensaje.CssClass = Nothing
            lbl_mensaje.Text = Nothing
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Seguimiento Retroalimentacion"
                Cargar_Drl()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub Cargar_Drl()
        Try
            'ingenieros
            With Drl_ing
                .DataSource = objGeneral.consultaagentegrupo
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
            'Auditor
            With Drl_auditor
                objGeneral.Validacion = "Calidad"
                .DataSource = objGeneral.consultaagentegrupo
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
            End With
            'Campaña
            ObjCalidad.Validacion = "1"
            With drl_campaña
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            'Tipo Rechaza
            ObjCalidad.Validacion = "7"
            With drl_tipo_recha
                .DataSource = ObjCalidad.Consulta_Calidad_Registro_Complemento
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            If Drl_auditor.SelectedIndex = 0 And Drl_ing.SelectedIndex = 0 And drl_campaña.SelectedIndex = 0 And drl_estado.SelectedIndex = 0 And drl_criticidad.SelectedIndex = 0 And Txt_Fc_Ini.Text = "" And Txt_Fc_Fin.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Escoja un filtro de busqueda"
                Exit Sub
            Else
                Dim dts As DataSet
                If Drl_auditor.SelectedIndex <> 0 Then
                    ObjCalidad.Auditor = Drl_auditor.SelectedValue
                End If
                If Drl_ing.SelectedIndex <> 0 Then
                    ObjCalidad.agente = Drl_ing.SelectedValue
                End If
                If drl_campaña.SelectedIndex <> 0 Then
                    ObjCalidad.Proceso = drl_campaña.SelectedItem.Text
                End If
                If drl_estado.SelectedIndex <> 0 Then
                    ObjCalidad.Estado = drl_estado.SelectedItem.Text
                End If
                If drl_criticidad.SelectedIndex <> 0 Then
                    If drl_criticidad.SelectedItem.Text = "Critico" Then
                        ObjCalidad.grupo = " <=85"
                    ElseIf drl_criticidad.SelectedItem.Text = "Urgente" Then
                        ObjCalidad.grupo = " >85"
                    End If
                End If
                If Txt_Fc_Ini.Text <> "" Then
                    ObjCalidad.fcini = Txt_Fc_Ini.Text
                End If
                If Txt_Fc_Fin.Text <> "" Then
                    ObjCalidad.fcfin = Txt_Fc_Fin.Text
                End If
                If Txt_Fc_Ini.Text <> "" And Txt_Fc_Fin.Text <> "" Then
                    If Date.Parse(Txt_Fc_Ini.Text) > Date.Parse(Txt_Fc_Fin.Text) Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Fecha inicio debe ser menor a fecha fin"
                        Exit Sub
                    End If
                End If
                Session("dtggeneral_Seguimiento_retro") = ObjCalidad.Seguimiento_Retro
                dtggeneral.DataSource = Session("dtggeneral_Seguimiento_retro")
                dtggeneral.DataBind()
                If ObjCalidad.cantidad = 0 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No se encontraron registros"
                    Lbl_seguimiento.Text = ""
                    btn_exportar.Visible = False
                Else
                    btn_exportar.Visible = True
                    Lbl_seguimiento.Text = "Registros Encontrados: " & ObjCalidad.cantidad
                End If

            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtggeneral.DataSource = Session("dtggeneral_Seguimiento_retro")
            dtggeneral.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles dtggeneral.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Dim Caducado As String = e.Row.Cells(11).Text
                If Caducado = "Caducado" Then
                    e.Row.ForeColor = Drawing.Color.FromArgb(255, 0, 0)
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Sub crearexcel()
        Dim sw As New StringWriter()
        Dim hw As New HtmlTextWriter(sw)
        Dim tabla As New Table()
        Dim tr1 As New TableRow()
        Dim cell1 As New TableCell()
        Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"
        If dtggeneral2.Rows.Count() > 0 Then
            cell1.Controls.Add(dtggeneral2)
            tr1.Cells.Add(cell1)
            tabla.Rows.Add(tr1)
            tabla.RenderControl(hw)
            Response.Clear()
            Response.Buffer = True
            Response.AddHeader("Content-Disposition", "attachment;filename=Seguimiento_Retro.xls")
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
    End Sub

    Protected Sub btn_exportar_Click(sender As Object, e As EventArgs) Handles btn_exportar.Click
        Try
            dtggeneral2.Visible = True
            dtggeneral2.PageSize = 10000
            dtggeneral2.DataSource = Session("dtggeneral_Seguimiento_retro")
            dtggeneral2.DataBind()
            crearexcel()
            dtggeneral2.DataSource = Nothing
            dtggeneral2.DataBind()
            dtggeneral2.PageSize = 300
            dtggeneral2.Visible = False
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub


    Protected Sub dtggeneral_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles dtggeneral.RowCommand
        Try
            Dim Index As Integer
            lbl_fc_aud.Text = ""
            lbl_id_auditoria.Text = ""
            Lbl_ingeniero.Text = ""
            txt_obs.Text = ""
            drl_tipo_recha.SelectedIndex = 0
            Select Case e.CommandName
                Case "Seleccionar"
                    Index = Convert.ToInt32(e.CommandArgument)
                    If dtggeneral.Rows(Index).Cells(11).Text = "Realizado" Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Esta auditoria no se puede Homologar"
                        Exit Sub
                    End If
                    If dtggeneral.Rows(Index).Cells(11).Text = "HOMOLOGADA" Then
                        Btn_rechaza.Enabled = False
                    Else
                        Btn_rechaza.Enabled = True
                    End If

                    If dtggeneral.Rows(Index).Cells(11).Text = "HOMOLOGADA" Then
                        lbl_id_auditoria.Text = dtggeneral.Rows(Index).Cells(0).Text
                        lbl_fc_aud.Text = dtggeneral.Rows(Index).Cells(1).Text
                        Lbl_ingeniero.Text = dtggeneral.Rows(Index).Cells(5).Text
                        ObjCalidad.Auditoria = lbl_id_auditoria.Text
                        ObjCalidad.Consulta_Retro_Homologada()
                        If ObjCalidad.obs <> "" Then
                            txt_obs.Text = ObjCalidad.obs
                            txt_obs.ReadOnly = True
                        End If
                        If ObjCalidad.Tipo_Auditoria <> "" Then
                            drl_tipo_recha.SelectedValue = ObjCalidad.Tipo_Auditoria
                            drl_tipo_recha.Enabled = False
                        End If
                    Else
                        drl_tipo_recha.Enabled = True
                        txt_obs.ReadOnly = False
                        lbl_id_auditoria.Text = dtggeneral.Rows(Index).Cells(0).Text
                        lbl_fc_aud.Text = dtggeneral.Rows(Index).Cells(1).Text
                        Lbl_ingeniero.Text = dtggeneral.Rows(Index).Cells(5).Text
                    End If
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Plegar", "PlegDes_Dinamico('#Rechazados', 'slide', '', '', '');", True)
            End Select
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Try
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Plegar", "PlegDes_Dinamico('#Rechazados', 'slide', '', '', '');", True)
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message

        End Try
    End Sub

    Protected Sub Btn_rechaza_Click(sender As Object, e As EventArgs) Handles Btn_rechaza.Click
        Try
            If drl_tipo_recha.SelectedIndex = 0 Then
                Pnl_mensaje.CssClass = "alert alert-warning"
                lbl_mensaje.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un tipo"
                Exit Sub
            End If

            If txt_obs.Text = "" Then
                Pnl_mensaje.CssClass = "alert alert-warning"
                lbl_mensaje.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Escriba una observacion"
                Exit Sub
            End If
            ObjCalidad.idusuario = CType(Session("permisos"), clsusuario).usuario
            ObjCalidad.Auditoria = lbl_id_auditoria.Text
            ObjCalidad.obs = txt_obs.Text
            ObjCalidad.Tipo_Auditoria = drl_tipo_recha.SelectedItem.Text
            ObjCalidad.registro_retro_rechazada()

            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Auditoria Homologada"

            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Plegar", "PlegDes_Dinamico('#Rechazados', 'slide', '', '', '');", True)
            lbl_fc_aud.Text = ""
            lbl_id_auditoria.Text = ""
            Lbl_ingeniero.Text = ""
            txt_obs.Text = ""
            drl_tipo_recha.SelectedIndex = 0
            btn_buscar_Click(1, Nothing)
        Catch ex As Exception
            Pnl_mensaje.CssClass = "alert alert-danger"
            lbl_mensaje.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
End Class