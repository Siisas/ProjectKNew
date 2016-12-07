Imports System.IO
Public Class Control_PQR
    Inherits System.Web.UI.Page
    Dim Objdatos As New clscrmdatos
    Dim ObjGeneral As New clsgeneral

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Control de PQR"
                Objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                If Objdatos.Mis_Asignados_Control_PQR().Tables(0).Rows.Count < 1 And (CType(Session("permisos"), clsusuario).perfil = 3 Or CType(Session("permisos"), clsusuario).perfil = 1 Or CType(Session("permisos"), clsusuario).NomPerfil.Contains("Supervisor")) Then
                    Pnl_Ingenieros.Visible = False
                    Pnl_General.Visible = True
                    Cargar_DRLS()
                    Limpiar()
                    Session("Dtg_Estad.Control_PQR") = Objdatos.Casos_Asignados_Control_PQR()
                    Dtg_Estad.DataSource = Session("Dtg_Estad.Control_PQR")
                    Dtg_Estad.DataBind()
                Else
                    Pnl_Ingenieros.Visible = True
                    Pnl_General.Visible = False
                    Session("Dtg_Mis_Asignados.Control_PQR") = Objdatos.Mis_Asignados_Control_PQR()
                    Dtg_Mis_Asignados.DataSource = Session("Dtg_Mis_Asignados.Control_PQR")
                    Dtg_Mis_Asignados.DataBind()
                    Lbl_Cuenta2.Text = "Asignados: " & Objdatos.cantidad
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Cargar_DRLS()
        Objdatos.Validacion = "Agentes"
        With Drl_Agente
            .DataSource = Objdatos.Cargar_DRLS_Control()
            .DataTextField = "nombreu"
            .DataValueField = "idusuario"
            .DataBind()
            .Items.Insert(0, "- Seleccione -")
            .Items(0).Value = 0
        End With
        Dim row As Integer
        'Estado
        row = ObjGeneral.consultartipificacion.Tables(0).Rows.Count
        With Drl_Estado
            .DataSource = ObjGeneral.consultartipificacion
            .DataTextField = "Tipificacion1"
            .DataValueField = "Tipificacion1"
            .DataBind()
            .Items.Insert(0, "- Seleccione -")
            .Items.Insert(1, "Abierto")
            .Items.Insert(row + 1, "Escalado")
            .Items.Insert(row + 2, "Cerrado Informatica")
            .Items.Insert(row + 3, "Cerrado Tecnica")
        End With
        Objdatos.Validacion = "Bandejas"
        With Drl_Bandeja
            .DataSource = Objdatos.Cargar_DRLS_Control()
            .DataTextField = "Nombre"
            .DataValueField = "Codigo"
            .DataBind()
            .Items.Insert(0, "- Seleccione -")
            .Items(0).Value = 0
        End With
    End Sub
    Protected Sub Btn_Asignacion_Click(sender As Object, e As EventArgs) Handles Btn_Asignacion.Click
        Limpiar()
    End Sub
    Protected Sub Btn_Cargue_PQR_Click(sender As Object, e As EventArgs) Handles Btn_Cargue_PQR.Click
        Limpiar()
    End Sub
    Protected Sub Btn_Liberar_Click(sender As Object, e As EventArgs) Handles Btn_Liberar.Click, Btn_Lib_Mas.Click
        Try
            Dim Boton As Button
            Boton = CType(sender, Button)
            Select Case Boton.ID
                Case "Btn_Liberar"
                    If Drl_Agente.SelectedIndex = 0 Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un agente para realizar la liberacion!"
                        Exit Sub
                    Else
                        Objdatos.idusuario = Drl_Agente.SelectedValue
                        Objdatos.Liberacion_Control_PQR()
                    End If
                Case "Btn_Lib_Mas"
                    Objdatos.idusuario = Nothing
                    Objdatos.Liberacion_Control_PQR()
            End Select
            If Objdatos.cantidad < 1 Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron casos para liberar!"
                Limpiar()
            Else
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span Class='glyphicon glyphicon-ok-sign'></span> Se realizo la liberacion de " & Objdatos.cantidad & " caso(s) exitosamente!"
                Limpiar()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
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
            If Drl_Bandeja.SelectedIndex > 0 Then
                Objdatos.Bandeja = Drl_Bandeja.SelectedItem.Text
                Val = True
            Else
                Objdatos.Bandeja = ""
            End If
            If Drl_Estado.SelectedIndex > 0 Then
                Objdatos.estadoinc = Drl_Estado.SelectedItem.Text
                Val = True
            Else
                Objdatos.estadoinc = ""
            End If
            If Drl_Escalamiento.SelectedValue = "SD" Then
                Objdatos.Escalamiento_CPD_SD = "SD"
                Val = True
            ElseIf Drl_Escalamiento.SelectedValue = "CPD" Then
                Objdatos.Escalamiento_CPD_SD = "CPD"
                Val = True
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
                Limpiar()
                Exit Sub
            End If
            Session("Dtg_General.Control_PQR") = Objdatos.Consulta_Control_PQR()
            Dtg_General.DataSource = Session("Dtg_General.Control_PQR")
            Dtg_General.DataBind()
            Lbl_Cuenta.Text = "Casos a Asignar: " & Objdatos.cantidad
            If Objdatos.cantidad < 1 Or Objdatos.cantidad = "" Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span>No se encontraron registros!"
                Lbl_Cuenta.Text = Nothing
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "R", "GridViewNOPOINT('#Pnl_Dtg_General');", True)
            Else
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "R", "GridViewPOINT('#Pnl_Dtg_General');", True)
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        Finally
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
        End Try
    End Sub
    Public Sub Limpiar()
        Drl_Agente.SelectedIndex = 0
        Drl_Bandeja.SelectedIndex = 0
        Drl_Escalamiento.SelectedIndex = 0
        Drl_Estado.SelectedIndex = 0
        Txt_Cantidad.Text = Nothing
        Txt_Caso.Text = Nothing
        Txt_Fc_Ini.Text = Nothing
        Txt_Fc_Fin.Text = Nothing
        Session("Dtg_General.Control_PQR") = Nothing
        Dtg_General.DataSource = Session("Dtg_General.Control_PQR")
        Dtg_General.DataBind()
        Lbl_Cuenta.Text = Nothing
        Objdatos.cantidad = Nothing
        Lbl_Casos.Text = Objdatos.Consulta_Control_PQR().Tables(0).Rows.Count()
        Session("Dtg_Estad.Control_PQR") = Objdatos.Casos_Asignados_Control_PQR()
        Dtg_Estad.DataSource = Session("Dtg_Estad.Control_PQR")
        Dtg_Estad.DataBind()
    End Sub
    Protected Sub Dtg_General_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Dtg_General.PageIndexChanging
        Try
            Dtg_General.PageIndex = e.NewPageIndex
            Dtg_General.DataSource = Session("Dtg_General.Control_PQR")
            Dtg_General.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Dtg_Estad_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Dtg_Estad.PageIndexChanging
        Try
            Dtg_Estad.PageIndex = e.NewPageIndex
            Dtg_Estad.DataSource = Session("Dtg_Estad.Control_PQR")
            Dtg_Estad.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
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
                Dim num As Integer = 0
                Dtg_General.AllowPaging = False
                Dtg_General.DataSource = Session("Dtg_General.Control_PQR")
                Dtg_General.DataBind()
                For Each row As GridViewRow In Dtg_General.Rows
                    Objdatos.caso = Int64.Parse(row.Cells(0).Text)
                    Objdatos.Escalamiento_CPD_SD = row.Cells(8).Text
                    Objdatos.Asignacion_Control_PQR()
                    num += 1
                Next
                Dtg_General.AllowPaging = True
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span Class='glyphicon glyphicon-ok-sign'></span> Se asignaron " & num & " casos al ingeniero " & Drl_Agente.SelectedItem.Text & "!"
                Limpiar()
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span Class='glyphicon glyphicon-warning-sign'></span> Debe realizar una consulta con minimo 1 resultado para realizar la asignación!"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Dtg_Productividad_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles Dtg_Mis_Asignados.RowCommand
        Dim Index As Integer
        Try
            Index = Convert.ToInt32(e.CommandArgument)
            Objdatos.caso = Dtg_Mis_Asignados.Rows(Index).Cells(1).Text
            Objdatos.idusuario = Nothing
            Select Case e.CommandName
                Case "Liberar"
                    Objdatos.estadoinc = "Liberado"
                Case "Cerrar"
                    Objdatos.estadoinc = "Cerrado"
            End Select
            Objdatos.Liberacion_Control_PQR()
            Objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            Session("Dtg_Mis_Asignados.Control_PQR") = Objdatos.Mis_Asignados_Control_PQR()
            Dtg_Mis_Asignados.DataSource = Session("Dtg_Mis_Asignados.Control_PQR")
            Dtg_Mis_Asignados.DataBind()
            Lbl_Cuenta2.Text = "Asignados: " & Objdatos.cantidad
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span Class='glyphicon glyphicon-ok-sign'></span> Se ha " & Objdatos.estadoinc & " el caso " & Objdatos.caso & " correctamente!"
            If Objdatos.cantidad < 1 And (CType(Session("permisos"), clsusuario).perfil = 3 Or CType(Session("permisos"), clsusuario).NomPerfil.Contains("Supervisor")) Then
                Pnl_Ingenieros.Visible = False
                Pnl_General.Visible = True
                Cargar_DRLS()
                Limpiar()
                Session("Dtg_Estad.Control_PQR") = Objdatos.Casos_Asignados_Control_PQR()
                Dtg_Estad.DataSource = Session("Dtg_Estad.Control_PQR")
                Dtg_Estad.DataBind()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub


    Protected Sub Btn_Carga_Masiva_File_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Carga_Masiva.Click
        Try
            If Path.GetExtension(File_Carga_Masiva.FileName).ToLower() = ".xlsx" Then
                File_Carga_Masiva.SaveAs(Server.MapPath("~/Documento/" & Path.GetFileName(File_Carga_Masiva.FileName)))
                Objdatos.ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("~/Documento/" & Path.GetFileName(File_Carga_Masiva.FileName)) & ";Extended Properties=Excel 12.0;"
                Objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                Dim Val = Objdatos.Registro_Masivo_Base_PQR()
                If Val = Nothing Then
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-circle'></span> El registro masivo se completó exitosamente"
                    Limpiar()
                Else
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> " & Val
                End If
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Lo que intenta cargar no esta en formato .xlsx"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> " & ex.Message
        End Try
    End Sub

End Class