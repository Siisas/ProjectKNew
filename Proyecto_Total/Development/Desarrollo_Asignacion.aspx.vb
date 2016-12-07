Imports System.Net
Public Class Desarrollo_Asignacion
    Inherits System.Web.UI.Page
    Dim ObjDesarrollo As New ClsDesarrollo
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            lblmsg.Text = ""
            lblmsgg.Text = ""
            Alert_error.Visible = False
            Alert_correcto.Visible = False
            If Not IsPostBack Then
                Cargar_Drls()
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                objdatos.idusuario = lblusuario.Text
                objdatos.consultacod()
                lblcod.Text = objdatos.cargo
                ''''' INICIO SEGURIDAD ACCESO URL '''''
                Dim objGeneral As New clsgeneral
                objGeneral.DtsSeguridad = Session("dtsSeguridad")
                objGeneral.Consulta_Proyecto_Seguridad()
                objGeneral.PaginaAcceso = "~" + Mid(Request.RawUrl, Integer.Parse(objGeneral.nombreentidad))
                objGeneral.idusuario = CType(Session("permisos"), clsusuario).usuario
                objGeneral.PermisosUrl()
                ''''' FIN SEGURIDAD ACCESO URL '''''                
                Session("Consulta") = ObjDesarrollo.Consulta_Desarrollos_Sin_Asignar()
                Dtg_Desarrollos.DataSource = Session("Consulta")
                Dtg_Desarrollos.DataBind()
                Lbl_Cantidad.Text = ObjDesarrollo.Cantidad
                If ObjDesarrollo.Cantidad > 0 Then
                    Pnl_Dtg_Desarrollos.Visible = True
                Else
                    Pnl_Dtg_Desarrollos.Visible = False
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> ¡Error! " & ex.Message
            Alert_error.Visible = True
        End Try
    End Sub
    Public Sub Cargar_Drls()
        With Drl_Cons_Prioridad
            ObjDesarrollo.Validacion = "Cargar_Prioridad"
            .DataSource = ObjDesarrollo.Consulta_Carga_Drls()
            .DataTextField = "Com_Nom"
            .DataValueField = "Com_Cod"
            .DataBind()
        End With
        With Drl_Desarrollador
            ObjDesarrollo.Validacion = "Cargar_Desarrollador"
            .DataSource = ObjDesarrollo.Consulta_Carga_Drls()
            .DataTextField = "nombreu"
            .DataValueField = "Com_Nom"
            .DataBind()
            .Items.Insert(0, "- Seleccione -")
        End With
    End Sub
    Protected Sub Btn_Filtrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Filtrar.Click
        ObjDesarrollo.Codigo = Txt_Cons_Codigo.Text
        If Drl_Cons_Prioridad.SelectedItem.Text = "- Seleccione -" Then
            ObjDesarrollo.Prioridad = ""
        Else
            ObjDesarrollo.Prioridad = Drl_Cons_Prioridad.SelectedItem.Text
        End If
        ObjDesarrollo.Fecha_Inicio = Txt_Fc_Inicio.Text
        If Txt_Fc_Fin.Text = "" Then
            ObjDesarrollo.Fecha_Fin = ""
        Else
            ObjDesarrollo.Fecha_Fin = Txt_Fc_Fin.Text & " 23:59:59"
        End If
        If ObjDesarrollo.Prioridad = "" And (ObjDesarrollo.Fecha_Fin = "" Or ObjDesarrollo.Fecha_Inicio = "") And ObjDesarrollo.Codigo = "" Then
            lblmsgg.Text = "<strong><span class='glyphicon glyphicon-ok-circle'></span></strong> ¡Consulta sin filtro!"
            Alert_correcto.Visible = True
        End If
        Session("Consulta") = ObjDesarrollo.Consulta_Desarrollos_Sin_Asignar()
        Dtg_Desarrollos.DataSource = Session("Consulta")
        Dtg_Desarrollos.DataBind()
        Lbl_Cantidad.Text = ObjDesarrollo.Cantidad
        If ObjDesarrollo.Cantidad > 0 Then
            Pnl_Dtg_Desarrollos.Visible = True
        Else
            Pnl_Dtg_Desarrollos.Visible = False
        End If
    End Sub
    Protected Sub Btn_Cancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Cancelar.Click
        PnlAsignar.Visible = False
        PnlFiltros.Visible = True
        Drl_Desarrollador.SelectedIndex = 0
        Txt_Codigo.Text = ""
        Txt_Tema.Text = ""
        Txt_Requerimientos.Text = ""
        Dtg_Desarrollos.DataSource = Session("Consulta")
        Dtg_Desarrollos.DataBind()
        Lbl_Cantidad.Text = Dtg_Desarrollos.Rows.Count
        If Lbl_Cantidad.Text > 0 Then
            Pnl_Dtg_Desarrollos.Visible = True
        Else
            Pnl_Dtg_Desarrollos.Visible = False
        End If
    End Sub
    Public Sub Limpiar()
        Txt_Tema.Text = Nothing
        Txt_Requerimientos.Text = Nothing
        Txt_Codigo.Text = Nothing
        Txt_Cons_Codigo.Text = Nothing
        Txt_Fc_Fin.Text = Nothing
        Txt_Fc_Inicio.Text = Nothing
        Drl_Cons_Prioridad.SelectedIndex = 0
        Drl_Desarrollador.SelectedIndex = 0
    End Sub
    Protected Sub Btn_Asignar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Asignar.Click
        Dim ObjDesarrollo As New ClsDesarrollo
        ObjDesarrollo.IdUsuario = lblusuario.Text
        If Txt_Codigo.Text = "" Then
            Txt_Codigo.Text = ""
            lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> ¡No se encontro ningun codigo de Desarrollo a asignar!"
            Alert_error.Visible = True
            Exit Sub
        Else
            ObjDesarrollo.Codigo = Txt_Codigo.Text
        End If
        If Drl_Desarrollador.SelectedIndex = 0 Then
            ObjDesarrollo.Desarrollador = ""
            lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> ¡Debe seleccionar un Desarrollador a asignar!"
            Alert_error.Visible = True
            Exit Sub
        Else
            ObjDesarrollo.Desarrollador = Drl_Desarrollador.SelectedItem.Value
        End If
        ObjDesarrollo.Actualizar_Estado_Desarrollo()
        lblmsgg.Text = "<strong><span class='glyphicon glyphicon-ok-circle'></span></strong> ¡Asignacion realizada exitosamente!"
        Alert_correcto.Visible = True
        Limpiar()
        ObjDesarrollo.Codigo = Nothing
        ObjDesarrollo.IdUsuario = Nothing
        ObjDesarrollo.Desarrollador = Nothing
        Session("Consulta") = ObjDesarrollo.Consulta_Desarrollos_Sin_Asignar()
        Dtg_Desarrollos.DataSource = Session("Consulta")
        Dtg_Desarrollos.DataBind()
        Lbl_Cantidad.Text = ObjDesarrollo.Cantidad
        If ObjDesarrollo.Cantidad > 0 Then
            Pnl_Dtg_Desarrollos.Visible = True
        Else
            Pnl_Dtg_Desarrollos.Visible = False
        End If
        Btn_Cancelar_Click(sender, e)
    End Sub
    Protected Sub Dtg_Desarrollos_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles Dtg_Desarrollos.RowCommand
        Dim Dt As DataTable = New DataTable()
        Dim Index As Integer
        Try

            Select Case e.CommandName
                Case "Seleccionar"
                    Index = Convert.ToInt32(e.CommandArgument)
                    Txt_Codigo.Text = HttpUtility.HtmlDecode(Dtg_Desarrollos.Rows(Index).Cells(0).Text)
                    Txt_Tema.Text = HttpUtility.HtmlDecode(Dtg_Desarrollos.Rows(Index).Cells(4).Text)
                    Txt_Requerimientos.Text = HttpUtility.HtmlDecode(Dtg_Desarrollos.Rows(Index).Cells(7).Text)
                    PnlAsignar.Visible = True
                    PnlFiltros.Visible = False
            End Select
        Catch ex As Exception
            lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> ¡Error! " & Index & ex.Message
            Alert_error.Visible = True
        End Try
    End Sub

    Protected Sub Dtg_Desarrollos_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Dtg_Desarrollos.PageIndexChanging
        Try
            Dtg_Desarrollos.DataSource = Session("Consulta")
            Dtg_Desarrollos.PageIndex = e.NewPageIndex
            Dtg_Desarrollos.DataBind()
            Lbl_Cantidad.Text = ObjDesarrollo.Cantidad
        Catch ex As Exception
            lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> ¡Error! " & ex.Message
            Alert_error.Visible = True
        End Try
    End Sub

End Class