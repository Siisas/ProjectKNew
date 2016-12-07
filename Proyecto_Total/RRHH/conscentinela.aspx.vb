Imports System.IO
Public Class conscentinela
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Session("Formulario") = "Consulta de Entrada y Salida"
                grupo()
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
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub grupo()
        Dim objdatos As New clsrrhh
        objdatos.Validacion = "centinela"
        With drlcargo
            .DataSource = objdatos.Consulta_grupo
            .DataTextField = "cargo_cliente"
            .DataValueField = "cargo_cliente"
            .DataBind()
            .Items.Insert(0, "- Seleccione -")
        End With

        objdatos.Validacion = "centinela"
        With drlcargocontrol
            .DataSource = objdatos.Consulta_grupo
            .DataTextField = "cargo_cliente"
            .DataValueField = "cargo_cliente"
            .DataBind()
            .Items.Insert(0, "- Seleccione -")
        End With

        objdatos.Validacion = "Horario"
        With drlHorario
            .DataSource = objdatos.Consulta_grupo
            .DataTextField = "Nombre"
            .DataValueField = "Cod_Validacion_Horario_Complemento"
            .DataBind()
        End With
    End Sub
    'Buscar Consulta centinela
    Protected Sub buscarinf()
        Try
            Dim objdatos As New clsrrhh
            If txtcod.Text = "" And txtfcini.Text = "" And txtfcfin.Text = "" And drlcargo.SelectedItem.Text = "- Seleccione -" And drlHorario.SelectedItem.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite un criterio de filtro antes de realizar la consulta"
                dtggeneral.DataSource = Nothing
                dtggeneral.DataBind()
            Else
                If txtcod.Text <> "" Then
                    objdatos.codigo = txtcod.Text
                End If

                If txtfcini.Text = "" Or txtfcfin.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Debe seleccionar un rango de fechas para realizar la consulta"
                    Exit Sub
                Else
                    objdatos.fcfin = txtfcfin.Text
                    objdatos.fcini = txtfcini.Text
                End If


                If txtfcfin.Text <> "" And txtfcini.Text <> "" Then
                    If Date.Parse(txtfcini.Text) > Date.Parse(txtfcfin.Text) Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Fecha Inicio debe ser menor a fecha fin"
                        Exit Sub
                    End If
                End If

                If drlcargo.Text <> "- Seleccione -" Then
                    objdatos.Cargo_Cliente = drlcargo.SelectedItem.Text
                End If

                If drlHorario.SelectedItem.Text <> "- Seleccione -" Then
                    objdatos.Tipo_Horario = drlHorario.SelectedValue
                End If

                objdatos.Validacion = "Individual"
                Session("Centinela") = objdatos.consultacentinelatotal
                dtggeneral.DataSource = Session("Centinela")
                dtggeneral.DataBind()
                If dtggeneral.Rows.Count <= 0 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros"
                    Exit Sub
                End If
                lblcuenta.Text = objdatos.cantidad
                lblmsg.Text = ""
            End If

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    'Buscar control
    Protected Sub BtnBusca_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBusca.Click
        Try
            Dim objdatos As New clsrrhh
            If txtfechaini.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Debe seleccionar una fecha"
                Exit Sub
            Else
                objdatos.fcini = txtfechaini.Text
            End If
            If drlcargocontrol.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.Cargo_Cliente = drlcargocontrol.SelectedItem.Text
            End If
            objdatos.Validacion = "Control"
            Session("Control") = objdatos.consultacentinelatotal
            DtgControl.DataSource = Session("Control")
            DtgControl.DataBind()
            If DtgControl.Rows.Count < 0 Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros"
                Exit Sub
            End If
            lblmsg.Text = ""
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        buscarinf()
    End Sub
    Private Sub Exportar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnexportar.Click, btnxls.Click
        Try
            Dim sw As New StringWriter()
            Dim hw As New HtmlTextWriter(sw)
            Dim tabla As New Table()
            Dim tr1 As New TableRow()
            Dim cell1 As New TableCell()
            Dim Val As Boolean = False
            Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"
            If DirectCast(sender, System.Web.UI.Control).ClientID = "Btnexportar" Then
                If DtgControl.Rows.Count > 0 And DtgControl.Rows.Count < 8101 Then
                    Val = True
                    dtggeneral.AllowPaging = False
                    dtggeneral.DataSource = Session("Control")
                    dtggeneral.DataBind()
                    cell1.Controls.Add(dtggeneral)
                    tr1.Cells.Add(cell1)
                    tabla.Rows.Add(tr1)
                    tabla.RenderControl(hw)
                    dtggeneral.AllowPaging = True
                    If lblcuenta.Text <> Nothing Then
                        dtggeneral.DataSource = Session("Centinela")
                        dtggeneral.DataBind()
                    End If
                ElseIf DtgControl.Rows.Count > 8100 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Se denego el permiso de exportacion debido a que exede el limite de registros; Realice otro filtro y reintente exportar! "
                Else
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span Class='glyphicon glyphicon-warning-sign'></span> ¡No se encontraron registros para realizar la exportacion! "
                End If
            ElseIf DirectCast(sender, System.Web.UI.Control).ClientID = "btnxls" Then
                If dtggeneral.Rows.Count > 0 And dtggeneral.Rows.Count < 8101 Then
                    Val = True
                    dtggeneral.AllowPaging = False
                    dtggeneral.DataSource = Session("Centinela")
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
            End If
            If Val = True Then
                Response.Clear()
                Response.Buffer = True
                Response.AddHeader("Content-Disposition", "attachment;filename=Reporte de centinela.xls")
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
    Dim Hora, Tipo As String
    Dim Index As Integer
    Protected Sub DtgControl_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles DtgControl.RowCommand
        Try
            Dim objdatos As New clsrrhh
            Hora = DtgControl.Rows(e.CommandArgument).Cells(0).Text
            Tipo = e.CommandName.ToString

            objdatos.horanov = Hora
            objdatos.turno = Tipo
            If Tipo = "Presentes" Or Tipo = "Retardos" Then
                objdatos.Validacion = "Presentes"
            ElseIf Tipo = "Programados" Or Tipo = "Aus. Just" Or Tipo = "Vacaciones" Then
                objdatos.Validacion = "Validacion"
            ElseIf Tipo = "Aus. Injus" Then
                objdatos.Validacion = "Injus"
            ElseIf Tipo = "Total" Then
                objdatos.Validacion = "Total"
            End If
            objdatos.fcini = txtfechaini.Text
            If drlcargocontrol.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.Cargo_Cliente = drlcargocontrol.SelectedItem.Text
            End If
            Session("Centinela") = objdatos.consultacentinelatotal
            dtggeneral.DataSource = Session("Centinela")
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex
            dtggeneral.DataSource = Session("Centinela")
            dtggeneral.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub DtgControl_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles DtgControl.PageIndexChanging
        Try
            DtgControl.PageIndex = e.NewPageIndex
            DtgControl.DataSource = Session("Control")
            DtgControl.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class
