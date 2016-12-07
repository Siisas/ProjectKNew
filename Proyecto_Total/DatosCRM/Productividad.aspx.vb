Imports System.IO
Public Class Productividad1
    Inherits System.Web.UI.Page
    Dim Objdatos As New clscrmdatos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            lblmsg.Text = ""
            lblmsgg.Text = ""
            If Not IsPostBack Then
                Dim objgeneral As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                objgeneral.idusuario = lblusuario.Text
                objgeneral.consultacod()
                lblcod.Text = objgeneral.cargo
                ''''' INICIO SEGURIDAD ACCESO URL '''''
                objgeneral.DtsSeguridad = Session("dtsSeguridad")
                objgeneral.Consulta_Proyecto_Seguridad()
                objgeneral.PaginaAcceso = "~" + Mid(Request.RawUrl, Integer.Parse(objgeneral.nombreentidad))
                objgeneral.idusuario = CType(Session("permisos"), clsusuario).usuario
                objgeneral.PermisosUrl()
                ''''' FIN SEGURIDAD ACCESO URL '''''
                If Txt_Fecha.Text = "" Then
                    Objdatos.fcini = Date.Now.ToString("dd/MM/yyyy") & " 00:00:00"
                    Objdatos.fcfin = Date.Now.ToString("dd/MM/yyyy") & " 23:59:59"
                    Objdatos.fcreg = Date.Now.ToString("dd/MM/yyyy")
                Else
                    Objdatos.fcini = Txt_Fecha.Text & " 00:00:00"
                    Objdatos.fcfin = Txt_Fecha.Text & " 23:59:59"
                    Objdatos.fcreg = Txt_Fecha.Text
                End If
                Objdatos.obs = " AND  (crm.Tipificacion Like '%Cerrado%' OR crm.Tipificacion Like '%Solicitud esc%' OR crm.Tipificacion = 'Escalado' OR crm.Tipificacion = 'Asignado' OR crm.Tipificacion = 'Reportado' ) "
                Objdatos.obsini = " AND  (crm.Tipificacion not Like '%Cerrado%' and crm.Tipificacion not Like '%Solicitud esc%' and crm.Tipificacion <> 'Escalado' AND crm.Tipificacion <> 'Asignado' AND crm.Tipificacion <> 'Reportado' ) "
                Session("Hora - Hora") = Objdatos.Consultar_Productividad_Hora
                Dtg_Productividad.DataSource = Session("Hora - Hora")
                Dtg_Productividad.DataBind()
                Lbl_Cantidad.Text = "Productividad " & Objdatos.cantidad
                If Dtg_Productividad.Rows.Count > 0 Then
                    Pnl_Dtg_Productividad.Visible = True
                End If
                With Drl_JefeInmediato
                    .DataSource = Objdatos.Consultar_Jefes_Productividad()
                    .DataTextField = "Jefe_Inmediato"
                    .DataValueField = "Jefe_Inmediato"
                    .DataBind()
                    .Items.Insert(0, "- Seleccione -")
                End With
                With Drl_Campaña
                    .DataSource = Objdatos.Consultar_Segmentos()
                    .DataTextField = "Segmento"
                    .DataValueField = "Segmento"
                    .DataBind()
                    .Items.Insert(0, "- Seleccione -")
                End With
                With Drl_Turno
                    .DataSource = Objdatos.Consultar_Turnos()
                    .DataTextField = "Nombre"
                    .DataValueField = "Codigo"
                    .DataBind()
                    .Items.Insert(0, "- Seleccione -")
                End With
                Pliegue()
            End If
        Catch ex As Exception
            lblmsg.Text = "<strong> ¡Error! </strong>" & ex.Message
            Pliegue()
        End Try
    End Sub
    Dim Vector(18) As Integer
    Protected Sub Dtg_Productividad_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles Dtg_Productividad.RowCommand
        Dim Index As Integer
        Try
            Select Case e.CommandName
                Case "Seleccionar"
                    Index = Convert.ToInt32(e.CommandArgument)
                    If Txt_Fecha.Text = "" Then
                        Objdatos.fcini = Date.Now.ToString("dd/MM/yyyy") & " 00:00:00"
                        Objdatos.fcfin = Date.Now.ToString("dd/MM/yyyy") & " 23:59:59"
                    Else
                        Objdatos.fcini = Txt_Fecha.Text & " 00:00:00"
                        Objdatos.fcfin = Txt_Fecha.Text & " 23:59:59"
                    End If
                    Objdatos.idusuario = Dtg_Productividad.Rows(Index).Cells(1).Text
                    Lbl_Turno.Text = Dtg_Productividad.Rows(Index).Cells(0).Text
                    Lbl_Cod.Text = Dtg_Productividad.Rows(Index).Cells(1).Text
                    Lbl_Nombre.Text = Dtg_Productividad.Rows(Index).Cells(2).Text
                    Lbl_Jefe.Text = Dtg_Productividad.Rows(Index).Cells(3).Text
                    Lbl_Campaña.Text = Dtg_Productividad.Rows(Index).Cells(4).Text
                    If Chk_Asig.Checked = True Then
                        Objdatos.obs = " AND  (crm.Tipificacion Like '%Cerrado%' OR crm.Tipificacion Like '%Solicitud esc%' OR crm.Tipificacion = 'Escalado' OR crm.Tipificacion = 'Asignado' OR crm.Tipificacion = 'Reportado' ) "
                    Else
                        Objdatos.obs = " AND  (crm.Tipificacion Like '%Cerrado%' OR crm.Tipificacion Like '%Solicitud esc%' OR crm.Tipificacion = 'Escalado' OR crm.Tipificacion = 'Reportado' ) "
                    End If
                    System.Threading.Thread.Sleep(300)
                    With Dtg_Campañas
                        Session("Hora - Campaña") = Objdatos.Consultar_Productividad_Hora_y_Campañas()
                        .DataSource = Session("Hora - Campaña")
                        .DataBind()
                    End With
                    Session("Detalle") = Objdatos.Consultar_Productividad_Detalle()
                    Dtg_Detalle.DataSource = Session("Detalle")
                    Dtg_Detalle.DataBind()
                    Pnl_Filtros.Visible = False
                    Pnl_Info.Visible = True
                    Pnl_Dtg_Productividad.Visible = False
                    Pliegue()
            End Select
        Catch ex As Exception
            lblmsg.Text = "<strong> ¡Error! </strong>" & Index & ex.Message
            Pliegue()
        End Try
    End Sub
    Public Sub TotalHoras()
        Dim miDataTable As New DataTable
        Dim Renglon As DataRow = miDataTable.NewRow()
        For index = 6 To 21
            miDataTable.Columns.Add("" & index & "")
        Next
        miDataTable.Columns.Add("TOTAL")
        For index = 6 To 21
            Renglon("" & index & "") = Vector(index - 6)
        Next
        Renglon("TOTAL") = Vector(16)
        miDataTable.Rows.Add(Renglon)
        Dtg_Total_Horas.DataSource = miDataTable
        Dtg_Total_Horas.DataBind()
    End Sub
    Protected Sub Dtg_Productividad_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtg_Productividad.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                For index = 6 To 21
                    If DataBinder.Eval(e.Row.DataItem, "" & index & "") = "0" Then
                        e.Row.Cells(index - 1).ForeColor = Drawing.Color.Red
                    End If
                Next
            End If
            Dim C As Integer
            Vector(16) = Vector(16) + DataBinder.Eval(e.Row.DataItem, "TOTAL")
            For index = 6 To 21
                If (e.Row.RowType = DataControlRowType.DataRow) Then
                    Vector(C) = Vector(C) + DataBinder.Eval(e.Row.DataItem, "" & index & "")
                ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                    TotalHoras()
                End If
                C += 1
            Next
        Catch ex As Exception
            lblmsg.Text = "<strong> ¡Error! </strong>" & ex.Message
            Pliegue()
        End Try
    End Sub
    Protected Sub Dtg_Campañas_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtg_Campañas.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                e.Row.Cells(0).ForeColor = Drawing.Color.White
                e.Row.Cells(0).BackColor = Drawing.Color.FromArgb(179, 197, 86)
                Dim Vector() As String = {"DATOS", "TSF", "DILO", "INBOUND", "DESACTIVACION", "CONFIGURACION", "BSCS", "PQR"}
                For index = 1 To 7
                    Dim a = DataBinder.Eval(e.Row.DataItem, "" & Vector(index - 1) & "")
                    If DataBinder.Eval(e.Row.DataItem, "" & Vector(index - 1) & "") = "0" Then
                        e.Row.Cells(index).ForeColor = Drawing.Color.Red
                    End If
                Next
            End If
        Catch ex As Exception
            lblmsg.Text = "<strong> ¡Error! </strong>" & ex.Message
            Pliegue()
        End Try
    End Sub

    Protected Sub Btn_Filtrar_Click(sender As Object, e As EventArgs) Handles Btn_Filtrar.Click
        Try
            If Txt_Fecha.Text <> "" Then
                Objdatos.fcini = Txt_Fecha.Text & " 00:00:00"
                Objdatos.fcfin = Txt_Fecha.Text & " 23:59:59"
                Objdatos.fcreg = Txt_Fecha.Text
            Else
                Objdatos.fcini = Date.Now.ToString("dd/MM/yyyy") & " 00:00:00"
                Objdatos.fcfin = Date.Now.ToString("dd/MM/yyyy") & " 23:59:59"
                Objdatos.fcreg = Date.Now.ToString("dd/MM/yyyy")
            End If
            If Drl_JefeInmediato.SelectedIndex = 0 Then
                Objdatos.Superv = ""
            Else
                Objdatos.Superv = Drl_JefeInmediato.SelectedItem.Text
            End If
            If Drl_Campaña.SelectedIndex = 0 Then
                Objdatos.CampanaLogin = ""
            Else
                Objdatos.CampanaLogin = Drl_Campaña.SelectedItem.Text
            End If
            If Drl_Turno.SelectedIndex = 0 Then
                Objdatos.horaprog = ""
            Else
                Objdatos.horaprog = Drl_Turno.SelectedItem.Text
            End If
            If Txt_Cod_Agente.Text = "" Then
                Objdatos.idusuario = ""
            Else
                Objdatos.idusuario = Txt_Cod_Agente.Text
            End If
            If Chk_Asig.Checked = True Then
                Objdatos.obs = " AND  (crm.Tipificacion Like '%Cerrado%' OR crm.Tipificacion Like '%Solicitud esc%' OR crm.Tipificacion = 'Escalado' OR crm.Tipificacion = 'Asignado' OR crm.Tipificacion = 'Reportado') "
                Objdatos.obsini = " AND  (crm.Tipificacion not Like '%Cerrado%' and crm.Tipificacion not Like '%Solicitud esc%' and crm.Tipificacion <> 'Escalado' AND crm.Tipificacion <> 'Asignado' AND crm.Tipificacion <> 'Reportado') "
            Else
                Objdatos.obs = " AND  (crm.Tipificacion Like '%Cerrado%' OR crm.Tipificacion Like '%Solicitud esc%' OR crm.Tipificacion = 'Escalado' OR crm.Tipificacion = 'Reportado' ) "
                Objdatos.obsini = " AND  (crm.Tipificacion not Like '%Cerrado%' and crm.Tipificacion not Like '%Solicitud esc%' and crm.Tipificacion <> 'Escalado' AND crm.Tipificacion <> 'Reportado'  ) "
            End If
            System.Threading.Thread.Sleep(500)
            Session("Hora - Hora") = Objdatos.Consultar_Productividad_Hora
            Dtg_Productividad.DataSource = Session("Hora - Hora")
            Dtg_Productividad.DataBind()
            Lbl_Cantidad.Text = "Productividad " & Objdatos.cantidad
            If Objdatos.cantidad > 0 Then
                Pnl_Dtg_Productividad.Visible = True
            Else
                Pnl_Dtg_Productividad.Visible = False
            End If
            Pliegue()
        Catch ex As Exception
            lblmsg.Text = "<strong> ¡Error! </strong>" & ex.Message
            Pliegue()
        End Try
    End Sub
    Protected Sub Btn_Volver_Click(sender As Object, e As EventArgs) Handles Btn_Volver.Click
        Try
            Lbl_Cod.Text = ""
            Lbl_Campaña.Text = ""
            Lbl_Turno.Text = ""
            Lbl_Nombre.Text = ""
            Lbl_Jefe.Text = ""
            If Txt_Fecha.Text = "" Then
                Objdatos.fcini = Date.Now.ToString("dd/MM/yyyy") & " 00:00:00"
                Objdatos.fcfin = Date.Now.ToString("dd/MM/yyyy") & " 23:59:59"
                Objdatos.fcreg = Date.Now.ToString("dd/MM/yyyy")
            Else
                Objdatos.fcini = Txt_Fecha.Text & " 00:00:00"
                Objdatos.fcfin = Txt_Fecha.Text & " 23:59:59"
                Objdatos.fcreg = Txt_Fecha.Text
            End If
            Dtg_Productividad.AutoGenerateColumns = False
            Dtg_Productividad.DataSource = Session("Hora - Hora")
            Dtg_Productividad.DataBind()
            Lbl_Cantidad.Text = "Productividad " & Dtg_Productividad.Rows.Count
            Dtg_Detalle.DataSource = Nothing
            Dtg_Detalle.DataBind()
            Dtg_Campañas.DataSource = Nothing
            Dtg_Campañas.DataBind()
            Pnl_Info.Visible = False
            Pnl_Filtros.Visible = True
            Pnl_Dtg_Productividad.Visible = True
        Catch ex As Exception
            lblmsg.Text = "<strong> ¡Error! </strong>" & ex.Message
        End Try
    End Sub
    Protected Sub Pliegue()
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Plegar", "Plegar();", True)
    End Sub
    Protected Sub Chk_Asig_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Asig.CheckedChanged
        If Chk_Asig.Checked = True Then
            Chk_Asig.Text = "SI"
        Else
            Chk_Asig.Text = "NO"
        End If
    End Sub
    Protected Sub Exportar_Click(sender As Object, e As EventArgs) Handles Btn_Exportar1.Click, Btn_Exportar2.Click
        Try
            Dim sw As New StringWriter()
            Dim hw As New HtmlTextWriter(sw)
            Dim tabla As New Table()
            Dim tr1 As New TableRow()
            Dim cell1 As New TableCell()
            Dim tr2 As New TableRow()
            Dim cell2 As New TableCell()
            Dim Val As Boolean = False
            Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"
            If Pnl_Filtros.Visible = True Then

                If Dtg_Productividad.Rows.Count > 0 Then
                    Val = True
                    Dtg_Productividad.Columns(Dtg_Productividad.Columns.Count - 1).Visible = False
                    cell1.Controls.Add(tblHeader)
                    tr1.Cells.Add(cell1)
                    tabla.Rows.Add(tr1)
                    cell2.Controls.Add(Dtg_Productividad)
                    tr2.Cells.Add(cell2)
                    tabla.Rows.Add(tr2)
                    tabla.RenderControl(hw)
                    Dtg_Productividad.Columns(Dtg_Productividad.Columns.Count - 1).Visible = True
                Else
                    lblmsg.Text = "¡No se encontraron registros para realizar la exportacion!"
                End If
            Else
                If Dtg_Detalle.Rows.Count > 0 Then
                    Val = True
                    cell1.Controls.Add(Dtg_Detalle)
                    tr1.Cells.Add(cell1)
                    tabla.Rows.Add(tr1)
                    tabla.RenderControl(hw)
                Else
                    lblmsg.Text = "¡No se encontraron registros para realizar la exportacion!"
                End If
            End If
            If Val = True Then
                Response.Clear()
                Response.Buffer = True
                Response.AddHeader("Content-Disposition", "attachment;filename=Productividad.xls")
                Response.Charset = "UTF-8"
                Response.ContentType = "application/vnd.ms-excel"
                Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                Response.Write(style)
                Response.Output.Write(sw.ToString())
                Response.Flush()
                Response.End()
            End If
        Catch ex As Exception
            lblmsg.Text = "¡Error! " & ex.Message
        End Try
    End Sub
End Class
