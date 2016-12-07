Imports System.ComponentModel
Imports System.IO

Public Class Control_Escalamiento_CPD
    Inherits System.Web.UI.Page
    Dim objGeneral As New clsgeneral
    Dim Objdatos As New clscrmdatos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Control Escalamiento CPD"
                Cargar_DRLS()
                Session("Dtg_Estad") = Objdatos.Casos_Asginados_Control()
                Dtg_Estad.DataSource = Session("Dtg_Estad")
                Dtg_Estad.DataBind()
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
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Cargar_DRLS()
        Objdatos.Validacion = "Agentes"
        With Drl_Agente
            .DataSource = Objdatos.Cargar_DRLS_Control()
            .DataTextField = "nombreu"
            .DataValueField = "idusuario"
            .DataBind()
            .Items.Insert(0, "- Seleccione ")
            .Items(0).Value = 0
        End With
        Objdatos.Validacion = "Estado_Caso"
        With Drl_Estado_Caso
            .DataSource = Objdatos.Cargar_DRLS_Control()
            .DataTextField = "Nombre"
            .DataValueField = "Codigo"
            .DataBind()
            .Items.Insert(0, "- Seleccione ")
            .Items(0).Value = 0
        End With
        Objdatos.Validacion = "Estado_Remedy"
        With Drl_Estado_Remedy
            .DataSource = Objdatos.Cargar_DRLS_Control()
            .DataTextField = "Nombre"
            .DataValueField = "Codigo"
            .DataBind()
            .Items.Insert(0, "- Seleccione ")
            .Items(0).Value = 0
        End With
        Objdatos.Validacion = "Bandejas"
        With Drl_Bandeja
            .DataSource = Objdatos.Cargar_DRLS_Control()
            .DataTextField = "Nombre"
            .DataValueField = "Codigo"
            .DataBind()
            .Items.Insert(0, "- Seleccione ")
            .Items(0).Value = 0
        End With
    End Sub
    Protected Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
        Dim Val As Boolean = False
        Try
            If Txt_Cantidad.Text <> Nothing Then
                Objdatos.cantidad = Txt_Cantidad.Text
                Val = True
            Else
                Objdatos.cantidad = ""
            End If
            If Txt_Caso.Text <> Nothing Then
                Objdatos.caso = Txt_Caso.Text
                Val = True
            Else
                Objdatos.caso = ""
            End If
            If Drl_Estado_Caso.SelectedIndex > 0 Then
                Objdatos.estadoinc = Drl_Estado_Caso.SelectedItem.Text
                Val = True
            Else
                Objdatos.estadoinc = ""
            End If
            If Drl_Estado_Remedy.SelectedIndex > 0 Then
                Objdatos.qos = Drl_Estado_Remedy.SelectedItem.Text
                Val = True
            Else
                Objdatos.qos = ""
            End If
            If Drl_Bandeja.SelectedIndex > 0 Then
                Objdatos.abierto = Drl_Bandeja.SelectedItem.Text
                Val = True
            Else
                Objdatos.abierto = ""
            End If
            If Drl_Respuesta.SelectedIndex > 0 Then
                Objdatos.obs = Drl_Respuesta.SelectedItem.Text
                Val = True
            Else
                Objdatos.obs = ""
            End If
            If Txt_Fc_Ini.Text <> "" Then
                Objdatos.fcini = Txt_Fc_Ini.Text
                Val = True
            Else
                Objdatos.fcini = ""
            End If
            If Txt_Fc_Fin.Text <> "" Then
                Objdatos.fcfin = Txt_Fc_Fin.Text
                Val = True
            Else
                Objdatos.fcfin = ""
            End If
            If Val <> True Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione algun filtro de consulta!"
                Session("Dtg_General") = Nothing
                Dtg_General.DataSource = Session("Dtg_General")
                Dtg_General.DataBind()
                Lbl_Cuenta.Text = 0
                Exit Sub
            End If
            Session("Dtg_General") = Nothing
            Dtg_General.DataSource = Session("Dtg_General")
            Dtg_General.DataBind()
            Lbl_Cuenta.Text = 0
            Session("Dtg_General") = Objdatos.Control_Escalamiento_CPD()
            Dtg_General.DataSource = Session("Dtg_General")
            Dtg_General.DataBind()
            Lbl_Cuenta.Text = Objdatos.cantidad
            If Objdatos.cantidad < 1 Or Objdatos.cantidad = "" Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span>No se encontraron registros!"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        Finally
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
        End Try
    End Sub

    Protected Sub Dtg_General_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Dtg_General.PageIndexChanging
        Try
            Dtg_General.PageIndex = e.NewPageIndex
            Dtg_General.DataSource = Session("Dtg_General")
            Dtg_General.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Dtg_Estad_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Dtg_Estad.PageIndexChanging
        Try
            Dtg_Estad.PageIndex = e.NewPageIndex
            Dtg_Estad.DataSource = Session("Dtg_Estad")
            Dtg_Estad.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Exportar_Click(sender As Object, e As EventArgs) Handles Btn_Exportar.Click
        Try
            Dim sw As New StringWriter()
            Dim hw As New HtmlTextWriter(sw)
            Dim tabla As New Table()
            Dim tr1 As New TableRow()
            Dim cell1 As New TableCell()
            Dim Val As Boolean = False
            Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"
            If Dtg_General.Rows.Count > 0 And Dtg_General.Rows.Count < 8101 Then
                Val = True
                Dtg_General.AllowPaging = False
                Dtg_General.DataSource = Session("Dtg_General")
                Dtg_General.DataBind()
                cell1.Controls.Add(Dtg_General)
                tr1.Cells.Add(cell1)
                tabla.Rows.Add(tr1)
                tabla.RenderControl(hw)
                Dtg_General.AllowPaging = True
            ElseIf Dtg_General.Rows.Count > 8100 Then
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

    Protected Sub Btn_Asignar_Click(sender As Object, e As EventArgs) Handles Btn_Asignar.Click
        Try
            If Drl_Agente.SelectedIndex = 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un ingeniero para realizar la asignación!"
            ElseIf Dtg_General.Rows.Count() > 0 Then
                Objdatos.idusuarioasignado = Drl_Agente.SelectedItem.Value
                Objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                Objdatos.Validacion = "CPD"
                Dim num As Integer = 0
                Dtg_General.AllowPaging = False
                Dtg_General.DataSource = Session("Dtg_General")
                Dtg_General.DataBind()
                For Each row As GridViewRow In Dtg_General.Rows
                    Objdatos.caso = Int64.Parse(row.Cells(0).Text)
                    Objdatos.CampanaLogin = (row.Cells(7).Text)
                    Objdatos.Asignacion_Control()
                    num += 1
                Next
                Dtg_General.AllowPaging = True
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span Class='glyphicon glyphicon-ok-sign'></span> Se asignaron " & num & " casos al ingeniero " & Drl_Agente.SelectedItem.Text & "!"
                Session("Dtg_General") = Nothing
                Dtg_General.DataSource = Session("Dtg_General")
                Dtg_General.DataBind()
                Lbl_Cuenta.Text = 0
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span Class='glyphicon glyphicon-warning-sign'></span> Debe realizar una consulta con minimo 1 resultado para realizar la asignación!"
            End If
            Session("Dtg_Estad") = Objdatos.Casos_Asginados_Control()
            Dtg_Estad.DataSource = Session("Dtg_Estad")
            Dtg_Estad.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_Liberar_Click(sender As Object, e As EventArgs) Handles Btn_Liberar.Click
        Try
            If Drl_Agente.SelectedIndex > 0 Then
                Dim num As Integer = 0
                Objdatos.Validacion = "AGENTE_CPD"
                Objdatos.idusuarioasignado = Drl_Agente.SelectedItem.Value
                num = Objdatos.Liberacion_Control()
                If num < 1 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> El ingeniero " & Drl_Agente.SelectedItem.Text & " no tiene casos para liberar!"
                Else
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Se liberaron " & num & " casos del ingeniero " & Drl_Agente.SelectedItem.Text & "!"
                End If
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por favor seleccione un ingeniero para realizar la liberacion!"
            End If
            Session("Dtg_Estad") = Objdatos.Casos_Asginados_Control()
            Dtg_Estad.DataSource = Session("Dtg_Estad")
            Dtg_Estad.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Lib_Mas_Click(sender As Object, e As EventArgs) Handles Btn_Lib_Mas.Click
        Try
            Dim num As Integer = 0
            Objdatos.Validacion = "TODO_CPD"
            num = Objdatos.Liberacion_Control()
            If num < 1 Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No hay casos para liberar!"
            Else
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Se liberaron " & num & " casos!"
            End If
            Session("Dtg_Estad") = Objdatos.Casos_Asginados_Control()
            Dtg_Estad.DataSource = Session("Dtg_Estad")
            Dtg_Estad.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class