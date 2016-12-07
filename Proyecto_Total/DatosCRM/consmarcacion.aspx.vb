Imports System.IO
Public Class marcacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Consulta General Datos y BSCS"
                Carga_drl()
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

    Protected Sub Carga_drl()
        Try
            Dim ObjGeneral As New clsgeneral
            Dim row As Integer
            'Estado
            row = ObjGeneral.consultartipificacion.Tables(0).Rows.Count
            With drl_estado
                .DataSource = ObjGeneral.consultartipificacion
                .DataTextField = "Tipificacion1"
                .DataValueField = "Tipificacion1"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items.Insert(1, "ABIERTO")
                .Items.Insert(row + 1, "Escalado")
                .Items.Insert(row + 2, "Cerrado Informatica")
                .Items.Insert(row + 3, "Cerrado Tecnica")
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            Dim ObjDatos As New clscrmdatos
            Dim dts As DataSet
            If txtcaso.Text = "" And txtmin.Text = "" And Txt_Fc_Ini.Text = "" And Txt_Fc_Fin.Text = "" And drl_estado.SelectedIndex = 0 And drlcampaña.SelectedIndex = 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Escoja un filtro de busqueda"
                Exit Sub
            Else
                If txtcaso.Text <> "" Then
                    ObjDatos.caso = txtcaso.Text
                End If
                If txtmin.Text <> "" Then
                    ObjDatos.min = txtmin.Text
                End If
                If drl_estado.SelectedIndex <> 0 Then
                    ObjDatos.tipificacion = drl_estado.SelectedItem.Text
                End If
                If drlcampaña.SelectedIndex <> 0 Then
                    ObjDatos.Bandeja = drlcampaña.SelectedItem.Text
                End If
                If Txt_Fc_Ini.Text <> "" Then
                    ObjDatos.fcini = Txt_Fc_Ini.Text
                End If
                If Txt_Fc_Fin.Text <> "" Then
                    ObjDatos.fcfin = Txt_Fc_Fin.Text
                End If
                If Txt_Fc_Ini.Text <> "" And Txt_Fc_Fin.Text <> "" Then
                    If Date.Parse(Txt_Fc_Ini.Text) > Date.Parse(Txt_Fc_Fin.Text) Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Fecha inicio debe ser menor a fecha fin"
                        Exit Sub
                    End If
                End If
                dts = ObjDatos.Consulta_general_datos_BSCS


                If ObjDatos.cantidad = 0 Then
                    dtgbandeja.DataSource = dts.Tables(0)
                    dtgbandeja.DataBind()
                    LblCuentaAsignados.Text = ""
                    dtggeneral.DataSource = Nothing
                    dtggeneral.DataBind()
                    Lbl_seguimiento.Text = ""
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No se encontraron registros"
                    Exit Sub
                End If
                Session("dtgbandeja") = dts.Tables(0)
                dtgbandeja.DataSource = Session("dtgbandeja")
                dtgbandeja.DataBind()
                LblCuentaAsignados.Text = "Casos " + ObjDatos.cantidad

                If dts.Tables.Count > 1 Then
                    dtggeneral.DataSource = dts.Tables(1)
                    dtggeneral.DataBind()
                    Lbl_seguimiento.Text = "Seguimientos: " & dts.Tables(1).Rows.Count
                Else
                    dtggeneral.DataSource = Nothing
                    dtggeneral.DataBind()
                    Lbl_seguimiento.Text = ""
                End If

                'marcaciones
                If txtmin.Text <> Nothing Or txtcaso.Text <> Nothing Then
                    If txtcaso.Text <> "" Then
                        ObjDatos.caso = txtcaso.Text
                        ObjDatos.min = ""
                    ElseIf txtmin.Text <> "" Then
                        ObjDatos.min = txtmin.Text
                        ObjDatos.caso = ""
                    End If
                    dtgmarcacion.DataSource = ObjDatos.consultamarc
                    dtgmarcacion.DataBind()
                    lblmarca.Text = "Marcaciones: " & ObjDatos.cantidad
                Else
                    dtgmarcacion.DataSource = Nothing
                    dtgmarcacion.DataBind()
                    lblmarca.Text = ""
                End If
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
            If dtgbandeja.Rows.Count > 0 And dtgbandeja.Rows.Count < 8101 Then
                Val = True
                dtgbandeja.AllowPaging = False
                dtgbandeja.DataSource = Session("dtgbandeja")
                dtgbandeja.DataBind()
                cell1.Controls.Add(dtgbandeja)
                cell1.Controls.Add(dtggeneral)
                cell1.Controls.Add(dtgmarcacion)
                tr1.Cells.Add(cell1)
                tabla.Rows.Add(tr1)
                tabla.RenderControl(hw)
                dtgbandeja.AllowPaging = True
            ElseIf dtgbandeja.Rows.Count > 8100 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Se denego el permiso de exportacion debido a que exede el limite de registros; Realice otro filtro y reintente exportar! "
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span Class='glyphicon glyphicon-warning-sign'></span> ¡No se encontraron registros para realizar la exportacion! "
            End If
            If Val = True Then
                Response.Clear()
                Response.Buffer = True
                Response.AddHeader("Content-Disposition", "attachment;filename=Consulta_General_Datos_BSCS.xls")
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

    Protected Sub dtgbandeja_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtgbandeja.PageIndexChanging
        Try
            dtgbandeja.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtgbandeja.DataSource = Session("dtgbandeja")
            dtgbandeja.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles dtggeneral.RowDataBound
        If (e.Row.RowType = DataControlRowType.DataRow) Or (e.Row.RowType = DataControlRowType.Header) Then
            e.Row.Cells(8).Visible = False
            If DataBinder.Eval(e.Row.DataItem, "Estado") = "Eliminado" Then
                e.Row.ForeColor = Drawing.Color.Red
            End If
        End If
    End Sub

End Class