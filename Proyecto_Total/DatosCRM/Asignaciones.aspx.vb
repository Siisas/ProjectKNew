Public Class Asignaciones
    Inherits System.Web.UI.Page
    Dim table As New DataTable
    Dim objdatos As New clscrmdatos
    Dim objGeneral As New clsgeneral
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Asignacion General de Casos"
                Detalle()
                Session("LISTA") = table
                Cargar_Drl()
                objdatos.Validacion = "Datos"
                Session("Asignados") = objdatos.Consulta_Datos_Asignados()
                Dtg_Estad_Datos.DataSource = Session("Asignados")
                Dtg_Estad_Datos.DataBind()
                lblUsuDatos.Text = "Usuarios: " + objdatos.cantidad
                objdatos.ajuste = ""
                objdatos.Consulta_Total_Sin_Asignar()
                Lbl_Casos_Datos.Text = objdatos.cantidad
                Lbl_Rein_Datos.Text = objdatos.min
                Lbl_Segui_Datos.Text = objdatos.barrio
                objdatos.ajuste = "Programados"
                objdatos.Consulta_Total_Sin_Asignar()
                Lbl_Vig_Datos.Text = objdatos.archivo
                Lbl_Cad_Datos.Text = objdatos.apn
                Lbl_Prog_Datos.Text = objdatos.abierto
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Cargar_Drl()
        With Drl_Agentes
            .DataSource = objGeneral.consultaagentegrupo
            .DataTextField = "nombreu"
            .DataValueField = "idusuario"
            .DataBind()
        End With
    End Sub
    Protected Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        If Drl_Agentes.SelectedItem.Text <> "- Seleccione -" Then
            Dim table As DataTable
            Dim Val As Boolean = False
            table = Session("LISTA")
            For Each row As GridViewRow In DtgCarritoVen.Rows
                If row.Cells(0).Text = Drl_Agentes.SelectedItem.Value Then
                    Val = True
                End If
            Next
            If Val = False Then
                table.Rows.Add(Drl_Agentes.SelectedItem.Value, Drl_Agentes.SelectedItem.Text)
                table.AcceptChanges()
                DtgCarritoVen.DataSource = table
                DtgCarritoVen.DataBind()
                Cargar_Drl()
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> El Agente que selecciono ya fue agregado antes!!"
                Cargar_Drl()
                Exit Sub
            End If

            If DtgCarritoVen.Rows.Count() <= 1 Then
                'Datos
                Txt_Casos_Datos.Enabled = True
                Txt_Caso_Ind_Datos.Enabled = True
                Btn_Buscar_Datos.Enabled = True
                Drl_Bandeja_Datos.Enabled = True
                Drl_Estado_Datos.Enabled = True
                'Dilo
                Txt_Caso_Ind_Dilo.Enabled = True
                Txt_Casos_Dilo.Enabled = True
                Btn_Buscar_Dilo.Enabled = True
                Drl_Estado_Dilo.Enabled = True
                'Desactivacion
                Txt_Caso_Ind_Desact.Enabled = True
                Txt_Casos_Desact.Enabled = True
                Btn_Buscar_Desact.Enabled = True
                Drl_Estado_Desact.Enabled = True
                'Inbound
                Txt_Caso_Ind_Inbound.Enabled = True
                Txt_Casos_Inbound.Enabled = True
                Btn_Buscar_Inbound.Enabled = True
                Drl_Estado_Inbound.Enabled = True
                'BSCS
                Txt_Casos_BSCS.Enabled = True
                Txt_Caso_Ind_BSCS.Enabled = True
                Btn_Buscar_BSCS.Enabled = True
                Drl_Estado_BSCS.Enabled = True
            ElseIf DtgCarritoVen.Rows.Count() > 1 Then
                'Datos
                Txt_Caso_Ind_Datos.Enabled = False
                Txt_Casos_Datos.Enabled = True
                Btn_Buscar_Datos.Enabled = True
                Drl_Bandeja_Datos.Enabled = True
                Drl_Estado_Datos.Enabled = True
                'Dilo
                Txt_Caso_Ind_Dilo.Enabled = False
                Txt_Casos_Dilo.Enabled = True
                Btn_Buscar_Dilo.Enabled = True
                Drl_Estado_Dilo.Enabled = True
                'Desactivacion
                Txt_Caso_Ind_Desact.Enabled = False
                Txt_Casos_Desact.Enabled = True
                Btn_Buscar_Desact.Enabled = True
                Drl_Estado_Desact.Enabled = True
                'Inbound
                Txt_Caso_Ind_Inbound.Enabled = False
                Txt_Casos_Inbound.Enabled = True
                Btn_Buscar_Inbound.Enabled = True
                Drl_Estado_Inbound.Enabled = True
                'BSCS
                Txt_Caso_Ind_BSCS.Enabled = False
                Txt_Casos_BSCS.Enabled = True
                Btn_Buscar_BSCS.Enabled = True
                Drl_Estado_BSCS.Enabled = True
            End If
        Else
            Pnl_Message.CssClass = "alert alert-warning"
            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Agente para agregar"
        End If
    End Sub
    Protected Sub DtgCarritoVen_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles DtgCarritoVen.RowCommand
        Dim table As DataTable
        table = Session("LISTA")
        Dim Index As Integer
        Try
            Select Case e.CommandName
                Case "Delete"
                    Index = Convert.ToInt32(e.CommandArgument)
                    table.Rows.RemoveAt(Index)
                    Session("LISTA") = table
                    DtgCarritoVen.DataSource = table
                    DtgCarritoVen.DataBind()
            End Select
            Cargar_Drl()
            If DtgCarritoVen.Rows.Count() <= 1 Then
                'Datos
                Txt_Casos_Datos.Enabled = True
                Txt_Caso_Ind_Datos.Enabled = True
                Btn_Buscar_Datos.Enabled = True
                Drl_Bandeja_Datos.Enabled = True
                Drl_Estado_Datos.Enabled = True
                'Dilo
                Txt_Caso_Ind_Dilo.Enabled = True
                Txt_Casos_Dilo.Enabled = True
                Btn_Buscar_Dilo.Enabled = True
                Drl_Estado_Dilo.Enabled = True
                'Desactivacion
                Txt_Caso_Ind_Desact.Enabled = True
                Txt_Casos_Desact.Enabled = True
                Btn_Buscar_Desact.Enabled = True
                Drl_Estado_Desact.Enabled = True
                'Inbound
                Txt_Caso_Ind_Inbound.Enabled = True
                Txt_Casos_Inbound.Enabled = True
                Btn_Buscar_Inbound.Enabled = True
                Drl_Estado_Inbound.Enabled = True
                'BSCS
                Txt_Casos_BSCS.Enabled = True
                Txt_Caso_Ind_BSCS.Enabled = True
                Btn_Buscar_BSCS.Enabled = True
                Drl_Estado_BSCS.Enabled = True
            ElseIf DtgCarritoVen.Rows.Count() > 1 Then
                'Datos
                Txt_Caso_Ind_Datos.Enabled = False
                Txt_Casos_Datos.Enabled = True
                Btn_Buscar_Datos.Enabled = True
                Drl_Bandeja_Datos.Enabled = True
                Drl_Estado_Datos.Enabled = True
                'Dilo
                Txt_Caso_Ind_Dilo.Enabled = False
                Txt_Casos_Dilo.Enabled = True
                Btn_Buscar_Dilo.Enabled = True
                Drl_Estado_Dilo.Enabled = True
                'Desactivacion
                Txt_Caso_Ind_Desact.Enabled = False
                Txt_Casos_Desact.Enabled = True
                Btn_Buscar_Desact.Enabled = True
                Drl_Estado_Desact.Enabled = True
                'Inbound
                Txt_Caso_Ind_Inbound.Enabled = False
                Txt_Casos_Inbound.Enabled = True
                Btn_Buscar_Inbound.Enabled = True
                Drl_Estado_Inbound.Enabled = True
                'BSCS
                Txt_Caso_Ind_BSCS.Enabled = False
                Txt_Casos_BSCS.Enabled = True
                Btn_Buscar_BSCS.Enabled = True
                Drl_Estado_BSCS.Enabled = True
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub DtgCarritoVen_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles DtgCarritoVen.RowDeleting
        Try
            'lblmsg.Text = "Ingreso"
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Detalle()
        table.Columns.Add(New DataColumn("Codigo", GetType(String)))
        table.Columns.Add(New DataColumn("Agente", GetType(String)))
    End Sub
    Protected Sub Limpiar()
        Drl_Agentes.SelectedIndex = 0
        Dim table As DataTable
        table = Session("LISTA")
        table.Clear()
        Detalle()
        DtgCarritoVen.DataSource = Nothing
        DtgCarritoVen.DataBind()
        DtgCarritoVen.Enabled = True
        Btn_Agregar.Enabled = True
        'Datos
        Txt_Caso_Ind_Datos.Text = Nothing
        Txt_Casos_Datos.Text = Nothing
        Drl_Bandeja_Datos.SelectedIndex = 0
        Drl_Estado_Datos.SelectedIndex = 0
        Drl_Estado_Datos.Enabled = True
        Dtg_Casos_Datos.DataSource = Nothing
        Dtg_Casos_Datos.DataBind()
        Btn_Asignar_Datos.Enabled = False
        Lbl_Cuenta_Datos.Text = ""
        Drl_Estado_Programado.SelectedIndex = 0
        Txt_Fc_Ini_Datos.Text = ""
        Txt_Fc_Fin_Datos.Text = ""
        Chk_Segui_Datos.Checked = False
        Chk_Segui_Datos.Enabled = True
        Chk_Rein_Datos.Checked = False
        Chk_Man_Datos.Checked = True
        'Dilo
        Txt_Caso_Ind_Dilo.Text = Nothing
        Txt_Casos_Dilo.Text = Nothing
        Drl_Estado_Dilo.SelectedIndex = 0
        Dtg_Casos_Dilo.DataSource = Nothing
        Dtg_Casos_Dilo.DataBind()
        Btn_Asignar_Dilo.Enabled = False
        Lbl_Cuenta_Dilo.Text = ""
        Drl_Estado_Programado_Dilo.SelectedIndex = 0
        Txt_Fc_Ini_Dilo.Text = ""
        Txt_Fc_Fin_Dilo.Text = ""
        'Desactivacion
        Txt_Caso_Ind_Desact.Text = Nothing
        Txt_Casos_Desact.Text = Nothing
        Drl_Estado_Desact.SelectedIndex = 0
        Drl_Estado_Desact.Enabled = True
        Dtg_Casos_Desact.DataSource = Nothing
        Dtg_Casos_Desact.DataBind()
        Btn_Asignar_Desact.Enabled = False
        Lbl_Cuenta_Desact.Text = ""
        Drl_Estado_Programado_Desact.SelectedIndex = 0
        Txt_Fc_Ini_Desact.Text = ""
        Txt_Fc_Fin_Desact.Text = ""
        Chk_Segui_Desact.Checked = False
        Chk_Segui_Desact.Enabled = True
        Chk_Rein_Desact.Checked = False
        Chk_Man_Desact.Checked = True
        'Inbound
        Txt_Caso_Ind_Inbound.Text = Nothing
        Txt_Casos_Inbound.Text = Nothing
        Drl_Estado_Inbound.SelectedIndex = 0
        Dtg_Casos_Inbound.DataSource = Nothing
        Dtg_Casos_Inbound.DataBind()
        Btn_Asignar_Inbound.Enabled = False
        Lbl_Cuenta_Inbound.Text = ""
        Drl_Estado_Programado_Inbound.SelectedIndex = 0
        Txt_Fc_Ini_Inbound.Text = ""
        Txt_Fc_Fin_Inbound.Text = ""
        'BSCS
        Txt_Caso_Ind_BSCS.Text = Nothing
        Txt_Casos_BSCS.Text = Nothing
        Drl_Estado_BSCS.SelectedIndex = 0
        Drl_Estado_BSCS.Enabled = True
        Dtg_Casos_BSCS.DataSource = Nothing
        Dtg_Casos_BSCS.DataBind()
        Btn_Asignar_BSCS.Enabled = False
        Lbl_Cuenta_BSCS.Text = ""
        Drl_Estado_Programado_BSCS.SelectedIndex = 0
        Txt_Fc_Ini_BSCS.Text = ""
        Txt_Fc_Fin_BSCS.Text = ""
        Chk_Segui_BSCS.Checked = False
        Chk_Segui_BSCS.Enabled = True
        Chk_Rein_BSCS.Checked = False
        Chk_Man_BSCS.Checked = True
    End Sub
    Protected Sub Btn_Panel_Datos_Click(sender As Object, e As EventArgs) Handles Btn_Panel_Datos.Click
        Lbl_Validacion.Text = "Datos"
        objdatos.Validacion = "Datos"
        Session("Asignados") = objdatos.Consulta_Datos_Asignados()
        Dtg_Estad_Datos.DataSource = Session("Asignados")
        Dtg_Estad_Datos.DataBind()
        lblUsuDatos.Text = "Usuarios: " + objdatos.cantidad
        objdatos.ajuste = ""
        objdatos.Consulta_Total_Sin_Asignar()
        Lbl_Casos_Datos.Text = objdatos.cantidad
        Lbl_Rein_Datos.Text = objdatos.min
        Lbl_Segui_Datos.Text = objdatos.barrio
        objdatos.ajuste = "Programados"
        objdatos.Consulta_Total_Sin_Asignar()
        Lbl_Vig_Datos.Text = objdatos.archivo
        Lbl_Cad_Datos.Text = objdatos.apn
        Lbl_Prog_Datos.Text = objdatos.abierto
        Pnl_Dilo.Visible = False
        Pnl_Desact.Visible = False
        Pnl_Inbound.Visible = False
        Pnl_BSCS.Visible = False
        Pnl_Datos.Visible = True
        Session("Formulario") = "Asignacion de Casos Datos"
        Limpiar()
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
    End Sub
    Protected Sub Btn_Panel_Dilo_Click(sender As Object, e As EventArgs) Handles Btn_Panel_Dilo.Click
        Lbl_Validacion.Text = "Dilo"
        objdatos.Validacion = "Dilo"
        Session("Asignados_Dilo") = objdatos.Consulta_Datos_Asignados()
        Dtg_Estad_Dilo.DataSource = Session("Asignados_Dilo")
        Dtg_Estad_Dilo.DataBind()
        lblusuDilo.Text = "Usuarios: " + objdatos.cantidad
        objdatos.Consulta_Total_Sin_Asignar()
        Lbl_Casos_Dilo.Text = objdatos.cantidad
        objdatos.ajuste = "Programados"
        objdatos.Consulta_Total_Sin_Asignar()
        Lbl_Vig_Dilo.Text = objdatos.archivo
        Lbl_Cad_Dilo.Text = objdatos.apn
        Lbl_Prog_Dilo.Text = objdatos.abierto
        Pnl_Dilo.Visible = True
        Pnl_Desact.Visible = False
        Pnl_Datos.Visible = False
        Pnl_Inbound.Visible = False
        Pnl_BSCS.Visible = False
        Session("Formulario") = "Asignacion de Casos Dilo"
        Limpiar()
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
    End Sub
    Protected Sub Btn_Panel_Desact_Click(sender As Object, e As EventArgs) Handles Btn_Panel_Desact.Click
        Lbl_Validacion.Text = "Desactivacion"
        objdatos.Validacion = "Desactivacion"
        Session("Asignados_Desact") = objdatos.Consulta_Datos_Asignados()
        Dtg_Estad_Desact.DataSource = Session("Asignados_Desact")
        Dtg_Estad_Desact.DataBind()
        lblusuDesac.Text = "Usuarios: " + objdatos.cantidad
        objdatos.Consulta_Total_Sin_Asignar()
        Lbl_Casos_Desact.Text = objdatos.cantidad
        Lbl_Rein_Desact.Text = objdatos.min
        Lbl_Segui_Desact.Text = objdatos.barrio
        objdatos.ajuste = "Programados"
        objdatos.Consulta_Total_Sin_Asignar()
        Lbl_Vig_Desact.Text = objdatos.archivo
        Lbl_Cad_Desact.Text = objdatos.apn
        Lbl_Prog_Desact.Text = objdatos.abierto
        Pnl_Dilo.Visible = False
        Pnl_Desact.Visible = True
        Pnl_Datos.Visible = False
        Pnl_Inbound.Visible = False
        Pnl_BSCS.Visible = False
        Session("Formulario") = "Asignacion de Casos Desactivacion"
        Limpiar()
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
    End Sub
    Protected Sub Btn_Panel_Inbound_Click(sender As Object, e As EventArgs) Handles Btn_Panel_Inbound.Click
        Lbl_Validacion.Text = "Inbound"
        objdatos.Validacion = "Inbound"
        Session("Asignados_Inbound") = objdatos.Consulta_Datos_Asignados()
        Dtg_Estad_Inbound.DataSource = Session("Asignados_Inbound")
        Dtg_Estad_Inbound.DataBind()
        lblusuInbound.Text = "Usuarios: " + objdatos.cantidad
        objdatos.Consulta_Total_Sin_Asignar()
        Lbl_Casos_Inbound.Text = objdatos.cantidad
        objdatos.ajuste = "Programados"
        objdatos.Consulta_Total_Sin_Asignar()
        Lbl_Vig_Inbound.Text = objdatos.archivo
        Lbl_Cad_Inbound.Text = objdatos.apn
        Lbl_Prog_Inbound.Text = objdatos.abierto
        Pnl_Dilo.Visible = False
        Pnl_Desact.Visible = False
        Pnl_Datos.Visible = False
        Pnl_BSCS.Visible = False
        Pnl_Inbound.Visible = True
        Session("Formulario") = "Asignacion de Casos Inbound"
        Limpiar()
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
    End Sub
    Protected Sub Btn_Panel_BSCS_Click(sender As Object, e As EventArgs) Handles Btn_Panel_BSCS.Click
        Lbl_Validacion.Text = "BSCS"
        objdatos.Validacion = "BSCS"
        Session("Asignados_BSCS") = objdatos.Consulta_Datos_Asignados()
        Dtg_Estad_BSCS.DataSource = Session("Asignados_BSCS")
        Dtg_Estad_BSCS.DataBind()
        lblUsuBSCS.Text = "Usuarios: " + objdatos.cantidad
        objdatos.ajuste = ""
        objdatos.Consulta_Total_Sin_Asignar()
        Lbl_Casos_BSCS.Text = objdatos.cantidad
        Lbl_Rein_BSCS.Text = objdatos.min
        Lbl_Segui_BSCS.Text = objdatos.barrio
        objdatos.ajuste = "Programados"
        objdatos.Consulta_Total_Sin_Asignar()
        Lbl_Vig_BSCS.Text = objdatos.archivo
        Lbl_Cad_BSCS.Text = objdatos.apn
        Lbl_Prog_BSCS.Text = objdatos.abierto
        Pnl_Dilo.Visible = False
        Pnl_Desact.Visible = False
        Pnl_Inbound.Visible = False
        Pnl_Datos.Visible = False
        Pnl_BSCS.Visible = True
        Session("Formulario") = "Asignacion de Casos BSCS"
        Limpiar()
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
    End Sub
    '/***********************************************************/
    '/******************** CAMPAÑA DATOS ************************/
    '/***********************************************************/
    Protected Sub Btn_Buscar_Datos_Click(sender As Object, e As EventArgs) Handles Btn_Buscar_Datos.Click
        objdatos.Validacion = "Datos"
        If Chk_Man_Datos.Checked = True Then
            objdatos.obs = "Man"
        ElseIf Chk_Rein_Datos.Checked = True Then
            objdatos.obs = "Rein"
        Else
            objdatos.obs = "Segui"
        End If
        If Drl_Bandeja_Datos.SelectedItem.Text <> "- Seleccione -" Then
            objdatos.Bandeja = Drl_Bandeja_Datos.SelectedItem.Text
        Else
            Pnl_Message.CssClass = "alert alert-warning"
            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione la bandeja de la que va asignar"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
            Exit Sub
        End If
        If Drl_Estado_Datos.SelectedItem.Text <> "- Seleccione -" Then
            objdatos.estadoinc = Drl_Estado_Datos.SelectedItem.Text
        Else
            objdatos.estadoinc = ""
        End If
        If Drl_Estado_Datos.SelectedItem.Text = "Programado" And Drl_Estado_Programado.SelectedItem.Text = "Caducado" Then
            objdatos.archivo = Drl_Estado_Programado.SelectedItem.Text
        ElseIf Drl_Estado_Datos.SelectedItem.Text = "Programado" And Drl_Estado_Programado.SelectedItem.Text = "Vigente"
            objdatos.archivo = Drl_Estado_Programado.SelectedItem.Text
        Else
            objdatos.archivo = ""
        End If
        If Txt_Caso_Ind_Datos.Text <> "" And Txt_Casos_Datos.Text <> "" Then
            Pnl_Message.CssClass = "alert alert-info"
            lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Solo se puede hacer un tipo de asignacion, Individual o Multiple!!"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
            Exit Sub
        ElseIf Txt_Caso_Ind_Datos.Text <> "" And Txt_Casos_Datos.Text = "" Then
            objdatos.caso = Txt_Caso_Ind_Datos.Text
            objdatos.cantidad = ""
        ElseIf Txt_Caso_Ind_Datos.Text = "" And Txt_Casos_Datos.Text <> "" Then
            objdatos.cantidad = "0000"
            objdatos.caso = Txt_Casos_Datos.Text
        ElseIf Txt_Caso_Ind_Datos.Text = "" And Txt_Casos_Datos.Text = "" Then
            objdatos.caso = ""
            objdatos.cantidad = ""
        End If
        If Txt_Fc_Ini_Datos.Text <> "" And Txt_Fc_Fin_Datos.Text <> "" Then
            objdatos.fcini = Txt_Fc_Ini_Datos.Text & " 00:00:00"
            objdatos.fcfin = Txt_Fc_Fin_Datos.Text & " 23:59:59"
        Else
            objdatos.fcini = ""
            objdatos.fcfin = ""
        End If
        If objdatos.caso = "" And objdatos.Bandeja = "" And objdatos.estadoinc = "" And objdatos.fcini = "" And objdatos.fcfin = "" Then
            Pnl_Message.CssClass = "alert alert-warning"
            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Debe llenar por lo menos una opcion de filtro!!"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
            Exit Sub
        End If
        Session("Consulta_Datos") = objdatos.Consulta_Datos_Sin_Asignar()
        Dtg_Casos_Datos.DataSource = Session("Consulta_Datos")
        Dtg_Casos_Datos.DataBind()
        Lbl_Cuenta_Datos.Text = "Casos encontrados: " & objdatos.cantidad
        Drl_Bandeja_Datos.SelectedIndex = 0
        Drl_Estado_Datos.SelectedIndex = 0
        Drl_Estado_Programado.SelectedIndex = 0
        Pnl_Est_Prog.Visible = False
        Txt_Caso_Ind_Datos.Text = ""
        Txt_Casos_Datos.Text = ""
        Txt_Fc_Ini_Datos.Text = ""
        Txt_Fc_Fin_Datos.Text = ""
        If Dtg_Casos_Datos.Rows.Count > 0 Then
            Btn_Asignar_Datos.Enabled = True
        Else
            Btn_Asignar_Datos.Enabled = False
        End If
        Btn_Agregar.Enabled = True
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
    End Sub
    Protected Sub Btn_Asignar_Datos_Click(sender As Object, e As EventArgs) Handles Btn_Asignar_Datos.Click
        If DtgCarritoVen.Rows.Count > 0 Then
            Dim actualizar As New clscrmdatos
            actualizar.Validacion = "Datos"
            actualizar.Superv = CType(Session("permisos"), clsusuario).usuario
            Try
                Dim agentes, rei As Integer
                rei = 0
                agentes = DtgCarritoVen.Rows.Count
                For Each row As GridViewRow In Dtg_Casos_Datos.Rows
                    actualizar.caso = Int64.Parse(row.Cells(0).Text)
                    actualizar.idusuario = DtgCarritoVen.Rows(rei).Cells(0).Text
                    actualizar.Asignacion_Casos_General()
                    actualizar.estadoinc = (row.Cells(3).Text)
                    actualizar.Registro_Control_Asignacion()

                    rei = rei + 1
                    If rei = agentes Then
                        rei = 0
                    End If
                Next
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Asignación masiva realizada con éxito"
                Limpiar()
                objdatos.Validacion = "Datos"
                objdatos.ajuste = ""
                Session("Asignados") = objdatos.Consulta_Datos_Asignados()
                Dtg_Estad_Datos.DataSource = Session("Asignados")
                Dtg_Estad_Datos.DataBind()
                lblUsuDatos.Text = "Usuarios: " + objdatos.cantidad
                objdatos.ajuste = ""
                objdatos.Consulta_Total_Sin_Asignar()
                Lbl_Casos_Datos.Text = objdatos.cantidad
                Lbl_Rein_Datos.Text = objdatos.min
                objdatos.ajuste = "Programados"
                objdatos.Consulta_Total_Sin_Asignar()
                Lbl_Vig_Datos.Text = objdatos.archivo
                Lbl_Cad_Datos.Text = objdatos.apn
                Lbl_Prog_Datos.Text = objdatos.abierto
            Catch ex As Exception
                Pnl_Message.CssClass = "alert alert-danger"
                lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
            Finally
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
            End Try
        Else
            Pnl_Message.CssClass = "alert alert-info"
            lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Para realizar una asignacion, debe agregar agentes!!"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
        End If
    End Sub
    Protected Sub Dtg_Casos_Datos_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtg_Casos_Datos.RowDataBound
        Dim FcIngreso As Date
        If objdatos.Validacion = "Programado" Then
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                FcIngreso = Date.Now
                If DataBinder.Eval(e.Row.DataItem, "Fecha Programado") < FcIngreso Then
                    e.Row.ForeColor = Drawing.Color.Red
                    e.Row.Cells(6).Text = "CADUCADO"
                Else
                    e.Row.Cells(6).Text = "VIGENTE"
                End If
            End If
        End If
    End Sub
    Protected Sub Dtg_Estad_Datos_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtg_Estad_Datos.RowDataBound
        If objdatos.ajuste <> "Programados" Then
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                e.Row.Cells(1).ForeColor = Drawing.Color.White
                e.Row.Cells(1).BackColor = Drawing.Color.FromArgb(179, 197, 86)
            End If
        End If
    End Sub
    Protected Sub Dtg_Estad_Datos_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Dtg_Estad_Datos.PageIndexChanging
        Try
            Dtg_Estad_Datos.PageIndex = e.NewPageIndex
            Dtg_Estad_Datos.DataSource = Session("Asignados")
            Dtg_Estad_Datos.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Drl_Estado_Datos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Estado_Datos.SelectedIndexChanged
        If Drl_Estado_Datos.SelectedIndex <> 0 Then
            Chk_Segui_Datos.Checked = False
            Chk_Segui_Datos.Enabled = False
        Else
            Chk_Segui_Datos.Enabled = True
        End If
        If Drl_Estado_Datos.SelectedItem.Text = "Programado" Then
            Pnl_Est_Prog.Visible = True
            objdatos.Validacion = "Datos"
            objdatos.ajuste = "Programados"
            Session("Asignados") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_Datos.DataSource = Session("Asignados")
            Dtg_Estad_Datos.DataBind()
            lblUsuDatos.Text = "Usuarios: " + objdatos.cantidad
        Else
            Pnl_Est_Prog.Visible = False
            objdatos.Validacion = "Datos"
            Drl_Estado_Programado.SelectedIndex = 0
            objdatos.ajuste = ""
            Session("Asignados") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_Datos.DataSource = Session("Asignados")
            Dtg_Estad_Datos.DataBind()
            lblUsuDatos.Text = "Usuarios: " + objdatos.cantidad
        End If
    End Sub
    Protected Sub Chk_Segui_Datos_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Segui_Datos.CheckedChanged
        objdatos.Validacion = "Datos"
        If Chk_Segui_Datos.Checked = True Then
            Drl_Estado_Datos.SelectedIndex = 0
            Drl_Estado_Datos.Enabled = False
            Drl_Estado_Programado.SelectedIndex = 0
            objdatos.ajuste = "Seguimiento"
            Session("Asignados") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_Datos.DataSource = Session("Asignados")
            Dtg_Estad_Datos.DataBind()
            lblUsuDatos.Text = "Usuarios: " + objdatos.cantidad
        End If
    End Sub
    Protected Sub Chk_Man_Datos_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Man_Datos.CheckedChanged
        objdatos.Validacion = "Datos"
        If Chk_Man_Datos.Checked = True Then
            Drl_Estado_Datos.SelectedIndex = 0
            Drl_Estado_Datos.Enabled = True
            Drl_Estado_Programado.SelectedIndex = 0
            objdatos.ajuste = ""
            Session("Asignados") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_Datos.DataSource = Session("Asignados")
            Dtg_Estad_Datos.DataBind()
            lblUsuDatos.Text = "Usuarios: " + objdatos.cantidad
        End If
    End Sub
    Protected Sub Chk_Rein_Datos_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Rein_Datos.CheckedChanged
        objdatos.Validacion = "Datos"
        If Chk_Rein_Datos.Checked = True Then
            Drl_Estado_Datos.SelectedIndex = 0
            Drl_Estado_Datos.Enabled = True
            Drl_Estado_Programado.SelectedIndex = 0
            objdatos.ajuste = ""
            Session("Asignados") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_Datos.DataSource = Session("Asignados")
            Dtg_Estad_Datos.DataBind()
            lblUsuDatos.Text = "Usuarios: " + objdatos.cantidad
        End If
    End Sub
    '/***********************************************************/
    '/******************** CAMPAÑA DILO *************************/
    '/***********************************************************/
    Protected Sub Btn_Buscar_Dilo_Click(sender As Object, e As EventArgs) Handles Btn_Buscar_Dilo.Click
        objdatos.Validacion = Lbl_Validacion.Text
        objdatos.Bandeja = ""
        objdatos.obs = "Man"
        If Drl_Estado_Dilo.SelectedItem.Text <> "- Seleccione -" Then
            objdatos.estadoinc = Drl_Estado_Dilo.SelectedItem.Text
        Else
            objdatos.estadoinc = ""
        End If
        If Drl_Estado_Dilo.SelectedItem.Text = "Programado" And Drl_Estado_Programado_Dilo.SelectedItem.Text = "Caducado" Then
            objdatos.archivo = Drl_Estado_Programado_Dilo.SelectedItem.Text
        ElseIf Drl_Estado_Dilo.SelectedItem.Text = "Programado" And Drl_Estado_Programado_Dilo.SelectedItem.Text = "Vigente"
            objdatos.archivo = Drl_Estado_Programado_Dilo.SelectedItem.Text
        Else
            objdatos.archivo = ""
        End If
        If Txt_Caso_Ind_Dilo.Text <> "" And Txt_Casos_Dilo.Text <> "" Then
            Pnl_Message.CssClass = "alert alert-info"
            lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Solo se puede hacer un tipo de asignacion, Individual o Multiple!!"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
            Exit Sub
        ElseIf Txt_Caso_Ind_Dilo.Text <> "" And Txt_Casos_Dilo.Text = "" Then
            objdatos.caso = Txt_Caso_Ind_Dilo.Text
            objdatos.cantidad = ""
        ElseIf Txt_Caso_Ind_Dilo.Text = "" And Txt_Casos_Dilo.Text <> "" Then
            objdatos.cantidad = "0000"
            objdatos.caso = Txt_Casos_Dilo.Text
        ElseIf Txt_Caso_Ind_Dilo.Text = "" And Txt_Casos_Dilo.Text = "" Then
            objdatos.caso = ""
            objdatos.cantidad = ""
        End If
        If Txt_Fc_Ini_Dilo.Text <> "" And Txt_Fc_Fin_Dilo.Text <> "" Then
            objdatos.fcini = Txt_Fc_Ini_Dilo.Text & " 00:00:00"
            objdatos.fcfin = Txt_Fc_Fin_Dilo.Text & " 23:59:59"
        Else
            objdatos.fcini = ""
            objdatos.fcfin = ""
        End If
        If objdatos.caso = "" And objdatos.Bandeja = "" And objdatos.estadoinc = "" And objdatos.fcini = "" And objdatos.fcfin = "" Then
            Pnl_Message.CssClass = "alert alert-warning"
            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Debe llenar por lo menos una opcion de filtro!!"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
            Exit Sub
        End If
        Session("Consulta_Dilo") = objdatos.Consulta_Datos_Sin_Asignar()
        Dtg_Casos_Dilo.DataSource = Session("Consulta_Dilo")
        Dtg_Casos_Dilo.DataBind()
        Lbl_Cuenta_Dilo.Text = "Casos encontrados: " & objdatos.cantidad
        Drl_Estado_Dilo.SelectedIndex = 0
        Drl_Estado_Programado_Dilo.SelectedIndex = 0
        Pnl_Est_Prog_Dilo.Visible = False
        Txt_Caso_Ind_Dilo.Text = ""
        Txt_Casos_Dilo.Text = ""
        Txt_Fc_Ini_Dilo.Text = ""
        Txt_Fc_Fin_Dilo.Text = ""
        If Dtg_Casos_Dilo.Rows.Count > 0 Then
            Btn_Asignar_Dilo.Enabled = True
        Else
            Btn_Asignar_Dilo.Enabled = False
        End If
        Btn_Agregar.Enabled = True
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
    End Sub
    Protected Sub Btn_Asignar_Dilo_Click(sender As Object, e As EventArgs) Handles Btn_Asignar_Dilo.Click
        If DtgCarritoVen.Rows.Count > 0 Then
            Dim actualizar As New clscrmdatos
            actualizar.Validacion = "Dilo"
            actualizar.Superv = CType(Session("permisos"), clsusuario).usuario
            Try
                Dim agentes, rei As Integer
                rei = 0
                agentes = DtgCarritoVen.Rows.Count
                For Each row As GridViewRow In Dtg_Casos_Dilo.Rows
                    actualizar.caso = Int64.Parse(row.Cells(0).Text)
                    actualizar.idusuario = DtgCarritoVen.Rows(rei).Cells(0).Text
                    actualizar.Asignacion_Casos_General()
                    actualizar.estadoinc = (row.Cells(3).Text)
                    actualizar.Registro_Control_Asignacion()

                    rei = rei + 1
                    If rei = agentes Then
                        rei = 0
                    End If
                Next
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Asignación masiva realizada con éxito"
                Limpiar()
                objdatos.Validacion = "Dilo"
                objdatos.ajuste = ""
                Session("Asignados_Dilo") = objdatos.Consulta_Datos_Asignados()
                Dtg_Estad_Dilo.DataSource = Session("Asignados_Dilo")
                Dtg_Estad_Dilo.DataBind()
                lblusuDilo.Text = "Usuarios: " + objdatos.cantidad
                objdatos.ajuste = ""
                objdatos.Consulta_Total_Sin_Asignar()
                Lbl_Casos_Dilo.Text = objdatos.cantidad
                objdatos.ajuste = "Programados"
                objdatos.Consulta_Total_Sin_Asignar()
                Lbl_Vig_Dilo.Text = objdatos.archivo
                Lbl_Cad_Dilo.Text = objdatos.apn
                Lbl_Prog_Dilo.Text = objdatos.abierto
            Catch ex As Exception
                Pnl_Message.CssClass = "alert alert-danger"
                lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
            Finally
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
            End Try
        Else
            Pnl_Message.CssClass = "alert alert-info"
            lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Para realizar una asignacion, debe agregar agentes!!"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
        End If
    End Sub
    Protected Sub Dtg_Casos_Dilo_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtg_Casos_Dilo.RowDataBound
        Dim FcIngreso As Date
        If objdatos.Validacion = "Programado" Then
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                FcIngreso = Date.Now
                If DataBinder.Eval(e.Row.DataItem, "Fecha Programado") < FcIngreso Then
                    e.Row.ForeColor = Drawing.Color.Red
                    e.Row.Cells(6).Text = "CADUCADO"
                Else
                    e.Row.Cells(6).Text = "VIGENTE"
                End If
            End If
        End If
    End Sub
    Protected Sub Dtg_Estad_Dilo_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtg_Estad_Dilo.RowDataBound
        If objdatos.ajuste <> "Programados" Then
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                e.Row.Cells(1).ForeColor = Drawing.Color.White
                e.Row.Cells(1).BackColor = Drawing.Color.FromArgb(179, 197, 86)
            End If
        End If
    End Sub
    Protected Sub Dtg_Estad_Dilo_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Dtg_Estad_Dilo.PageIndexChanging
        Try
            Dtg_Estad_Dilo.PageIndex = e.NewPageIndex
            Dtg_Estad_Dilo.DataSource = Session("Asignados_Dilo")
            Dtg_Estad_Dilo.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Drl_Estado_Dilo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Estado_Dilo.SelectedIndexChanged
        If Drl_Estado_Dilo.SelectedItem.Text = "Programado" Then
            Pnl_Est_Prog_Dilo.Visible = True
            objdatos.Validacion = "Dilo"
            objdatos.ajuste = "Programados"
            Session("Asignados_Dilo") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_Dilo.DataSource = Session("Asignados_Dilo")
            Dtg_Estad_Dilo.DataBind()
            lblusuDilo.Text = "Usuarios: " + objdatos.cantidad
        Else
            Pnl_Est_Prog_Dilo.Visible = False
            objdatos.Validacion = "Dilo"
            Drl_Estado_Programado_Dilo.SelectedIndex = 0
            objdatos.ajuste = ""
            Session("Asignados_Dilo") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_Dilo.DataSource = Session("Asignados_Dilo")
            Dtg_Estad_Dilo.DataBind()
            lblusuDilo.Text = "Usuarios: " + objdatos.cantidad

        End If
    End Sub
    '/***********************************************************/
    '/****************** CAMPAÑA DESACTIVACION ******************/
    '/***********************************************************/
    Protected Sub Btn_Buscar_Desact_Click(sender As Object, e As EventArgs) Handles Btn_Buscar_Desact.Click
        objdatos.Validacion = Lbl_Validacion.Text
        objdatos.Bandeja = ""
        If Chk_Man_Desact.Checked = True Then
            objdatos.obs = "Man"
        ElseIf Chk_Rein_Desact.Checked = True Then
            objdatos.obs = "Rein"
        Else
            objdatos.obs = "Segui"
        End If
        If Drl_Estado_Desact.SelectedItem.Text <> "- Seleccione -" Then
            objdatos.estadoinc = Drl_Estado_Desact.SelectedItem.Text
        Else
            objdatos.estadoinc = ""
        End If
        If Drl_Estado_Desact.SelectedItem.Text = "Programado" And Drl_Estado_Programado_Desact.SelectedItem.Text = "Caducado" Then
            objdatos.archivo = Drl_Estado_Programado_Desact.SelectedItem.Text
        ElseIf Drl_Estado_Desact.SelectedItem.Text = "Programado" And Drl_Estado_Programado_Desact.SelectedItem.Text = "Vigente"
            objdatos.archivo = Drl_Estado_Programado_Desact.SelectedItem.Text
        Else
            objdatos.archivo = ""
        End If
        If Txt_Caso_Ind_Desact.Text <> "" And Txt_Casos_Desact.Text <> "" Then
            Pnl_Message.CssClass = "alert alert-info"
            lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Solo se puede hacer un tipo de asignacion, Individual o Multiple!!"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
            Exit Sub
        ElseIf Txt_Caso_Ind_Desact.Text <> "" And Txt_Casos_Desact.Text = "" Then
            objdatos.caso = Txt_Caso_Ind_Desact.Text
            objdatos.cantidad = ""
        ElseIf Txt_Caso_Ind_Desact.Text = "" And Txt_Casos_Desact.Text <> "" Then
            objdatos.cantidad = "0000"
            objdatos.caso = Txt_Casos_Desact.Text
        ElseIf Txt_Caso_Ind_Desact.Text = "" And Txt_Casos_Desact.Text = "" Then
            objdatos.caso = ""
            objdatos.cantidad = ""
        End If
        If Txt_Fc_Ini_Desact.Text <> "" And Txt_Fc_Fin_Desact.Text <> "" Then
            objdatos.fcini = Txt_Fc_Ini_Desact.Text & " 00:00:00"
            objdatos.fcfin = Txt_Fc_Fin_Desact.Text & " 23:59:59"
        Else
            objdatos.fcini = ""
            objdatos.fcfin = ""
        End If
        If objdatos.caso = "" And objdatos.Bandeja = "" And objdatos.estadoinc = "" And objdatos.fcini = "" And objdatos.fcfin = "" Then
            Pnl_Message.CssClass = "alert alert-warning"
            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Debe llenar por lo menos una opcion de filtro!!"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
            Exit Sub
        End If
        Session("Consulta_Desact") = objdatos.Consulta_Datos_Sin_Asignar()
        Dtg_Casos_Desact.DataSource = Session("Consulta_Desact")
        Dtg_Casos_Desact.DataBind()
        Lbl_Cuenta_Desact.Text = "Casos encontrados: " & objdatos.cantidad
        Drl_Estado_Desact.SelectedIndex = 0
        Drl_Estado_Programado_Desact.SelectedIndex = 0
        Pnl_Est_Prog_Desact.Visible = False
        Txt_Caso_Ind_Desact.Text = ""
        Txt_Casos_Desact.Text = ""
        Txt_Fc_Ini_Desact.Text = ""
        Txt_Fc_Fin_Desact.Text = ""
        If Dtg_Casos_Desact.Rows.Count > 0 Then
            Btn_Asignar_Desact.Enabled = True
        Else
            Btn_Asignar_Desact.Enabled = False
        End If
        Btn_Agregar.Enabled = True
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
    End Sub
    Protected Sub Btn_Asignar_Desact_Click(sender As Object, e As EventArgs) Handles Btn_Asignar_Desact.Click
        If DtgCarritoVen.Rows.Count > 0 Then
            Dim actualizar As New clscrmdatos
            actualizar.Validacion = "Desactivacion"
            actualizar.Superv = CType(Session("permisos"), clsusuario).usuario
            Try
                Dim agentes, rei As Integer
                rei = 0
                agentes = DtgCarritoVen.Rows.Count
                For Each row As GridViewRow In Dtg_Casos_Desact.Rows
                    actualizar.caso = Int64.Parse(row.Cells(0).Text)
                    actualizar.idusuario = DtgCarritoVen.Rows(rei).Cells(0).Text
                    actualizar.Asignacion_Casos_General()
                    actualizar.estadoinc = (row.Cells(3).Text)
                    actualizar.Registro_Control_Asignacion()

                    rei = rei + 1
                    If rei = agentes Then
                        rei = 0
                    End If
                Next
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Asignación masiva realizada con éxito"
                Limpiar()
                objdatos.Validacion = "Desactivacion"
                objdatos.ajuste = ""
                Session("Asignados_Desact") = objdatos.Consulta_Datos_Asignados()
                Dtg_Estad_Desact.DataSource = Session("Asignados_Desact")
                Dtg_Estad_Desact.DataBind()
                lblusuDesac.Text = "Usuarios: " + objdatos.cantidad
                objdatos.ajuste = ""
                objdatos.Consulta_Total_Sin_Asignar()
                Lbl_Casos_Desact.Text = objdatos.cantidad
                Lbl_Rein_Desact.Text = objdatos.min
                objdatos.ajuste = "Programados"
                objdatos.Consulta_Total_Sin_Asignar()
                Lbl_Vig_Desact.Text = objdatos.archivo
                Lbl_Cad_Desact.Text = objdatos.apn
                Lbl_Prog_Desact.Text = objdatos.abierto
            Catch ex As Exception
                Pnl_Message.CssClass = "alert alert-danger"
                lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
            Finally
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
            End Try
        Else
            Pnl_Message.CssClass = "alert alert-info"
            lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Para realizar una asignacion, debe agregar agentes!!"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
        End If
    End Sub
    Protected Sub Dtg_Casos_Desact_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtg_Casos_Desact.RowDataBound
        Dim FcIngreso As Date
        If objdatos.Validacion = "Programado" Then
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                FcIngreso = Date.Now
                If DataBinder.Eval(e.Row.DataItem, "Fecha Programado") < FcIngreso Then
                    e.Row.ForeColor = Drawing.Color.Red
                    e.Row.Cells(6).Text = "CADUCADO"
                Else
                    e.Row.Cells(6).Text = "VIGENTE"
                End If
            End If
        End If
    End Sub
    Protected Sub Dtg_Estad_Desact_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtg_Estad_Desact.RowDataBound
        If objdatos.ajuste <> "Programados" Then
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                e.Row.Cells(1).ForeColor = Drawing.Color.White
                e.Row.Cells(1).BackColor = Drawing.Color.FromArgb(179, 197, 86)
            End If
        End If
    End Sub
    Protected Sub Dtg_Estad_Desact_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Dtg_Estad_Desact.PageIndexChanging
        Try
            Dtg_Estad_Desact.PageIndex = e.NewPageIndex
            Dtg_Estad_Desact.DataSource = Session("Asignados_Desact")
            Dtg_Estad_Desact.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Drl_Estado_Desact_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Estado_Desact.SelectedIndexChanged
        If Drl_Estado_Desact.SelectedIndex <> 0 Then
            Chk_Segui_Desact.Checked = False
            Chk_Segui_Desact.Enabled = False
        Else
            Chk_Segui_Desact.Enabled = True
        End If
        If Drl_Estado_Desact.SelectedItem.Text = "Programado" Then
            Pnl_Est_Prog_Desact.Visible = True
            objdatos.Validacion = "Desactivacion"
            objdatos.ajuste = "Programados"
            Session("Asignados_Desact") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_Desact.DataSource = Session("Asignados_Desact")
            Dtg_Estad_Desact.DataBind()
            lblusuDesac.Text = "Usuarios: " + objdatos.cantidad
        Else
            Pnl_Est_Prog_Desact.Visible = False
            objdatos.Validacion = "Desactivacion"
            Drl_Estado_Programado_Desact.SelectedIndex = 0
            objdatos.ajuste = ""
            Session("Asignados_Desact") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_Desact.DataSource = Session("Asignados_Desact")
            Dtg_Estad_Desact.DataBind()
            lblusuDesac.Text = "Usuarios: " + objdatos.cantidad
        End If
    End Sub
    Protected Sub Chk_Segui_Desact_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Segui_Desact.CheckedChanged
        objdatos.Validacion = "Desactivacion"
        If Chk_Segui_Desact.Checked = True Then
            Drl_Estado_Desact.SelectedIndex = 0
            Drl_Estado_Desact.Enabled = False
            Drl_Estado_Programado_Desact.SelectedIndex = 0
            objdatos.ajuste = "Seguimiento"
            Session("Asignados_Desact") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_Desact.DataSource = Session("Asignados_Desact")
            Dtg_Estad_Desact.DataBind()
            lblusuDesac.Text = "Usuarios: " + objdatos.cantidad
        End If
    End Sub
    Protected Sub Chk_Man_Desact_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Man_Desact.CheckedChanged
        objdatos.Validacion = "Desactivacion"
        If Chk_Man_Desact.Checked = True Then
            Drl_Estado_Desact.SelectedIndex = 0
            Drl_Estado_Desact.Enabled = True
            Drl_Estado_Programado_Desact.SelectedIndex = 0
            objdatos.ajuste = ""
            Session("Asignados_Desact") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_Desact.DataSource = Session("Asignados_Desact")
            Dtg_Estad_Desact.DataBind()
            lblusuDesac.Text = "Usuarios: " + objdatos.cantidad
        End If
    End Sub
    Protected Sub Chk_Rein_Desact_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Rein_Desact.CheckedChanged
        objdatos.Validacion = "Desactivacion"
        If Chk_Rein_Desact.Checked = True Then
            Drl_Estado_Desact.SelectedIndex = 0
            Drl_Estado_Desact.Enabled = True
            Drl_Estado_Programado_Desact.SelectedIndex = 0
            objdatos.ajuste = ""
            Session("Asignados_Desact") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_Desact.DataSource = Session("Asignados_Desact")
            Dtg_Estad_Desact.DataBind()
            lblusuDesac.Text = "Usuarios: " + objdatos.cantidad
        End If
    End Sub
    '/***********************************************************/
    '/******************* CAMPAÑA INBOUND ***********************/
    '/***********************************************************/
    Protected Sub Btn_Buscar_Inbound_Click(sender As Object, e As EventArgs) Handles Btn_Buscar_Inbound.Click
        objdatos.Validacion = Lbl_Validacion.Text
        objdatos.Bandeja = ""
        objdatos.obs = "Man"
        If Drl_Estado_Inbound.SelectedItem.Text <> "- Seleccione -" Then
            objdatos.estadoinc = Drl_Estado_Inbound.SelectedItem.Text
        Else
            objdatos.estadoinc = ""
        End If
        If Drl_Estado_Inbound.SelectedItem.Text = "Programado" And Drl_Estado_Programado_Inbound.SelectedItem.Text = "Caducado" Then
            objdatos.archivo = Drl_Estado_Programado_Inbound.SelectedItem.Text
        ElseIf Drl_Estado_Inbound.SelectedItem.Text = "Programado" And Drl_Estado_Programado_Inbound.SelectedItem.Text = "Vigente"
            objdatos.archivo = Drl_Estado_Programado_Inbound.SelectedItem.Text
        Else
            objdatos.archivo = ""
        End If
        If Txt_Caso_Ind_Inbound.Text <> "" And Txt_Casos_Inbound.Text <> "" Then
            Pnl_Message.CssClass = "alert alert-info"
            lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Solo se puede hacer un tipo de asignacion, Individual o Multiple!!"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
            Exit Sub
        ElseIf Txt_Caso_Ind_Inbound.Text <> "" And Txt_Casos_Inbound.Text = "" Then
            objdatos.caso = Txt_Caso_Ind_Inbound.Text
            objdatos.cantidad = ""
        ElseIf Txt_Caso_Ind_Inbound.Text = "" And Txt_Casos_Inbound.Text <> "" Then
            objdatos.cantidad = "0000"
            objdatos.caso = Txt_Casos_Inbound.Text
        ElseIf Txt_Caso_Ind_Inbound.Text = "" And Txt_Casos_Inbound.Text = "" Then
            objdatos.caso = ""
            objdatos.cantidad = ""
        End If
        If Txt_Fc_Ini_Inbound.Text <> "" And Txt_Fc_Fin_Inbound.Text <> "" Then
            objdatos.fcini = Txt_Fc_Ini_Inbound.Text & " 00:00:00"
            objdatos.fcfin = Txt_Fc_Fin_Inbound.Text & " 23:59:59"
        Else
            objdatos.fcini = ""
            objdatos.fcfin = ""
        End If
        If objdatos.caso = "" And objdatos.Bandeja = "" And objdatos.estadoinc = "" And objdatos.fcini = "" And objdatos.fcfin = "" Then
            Pnl_Message.CssClass = "alert alert-warning"
            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Debe llenar por lo menos una opcion de filtro!!"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
            Exit Sub
        End If
        Session("Consulta_Inbound") = objdatos.Consulta_Datos_Sin_Asignar()
        Dtg_Casos_Inbound.DataSource = Session("Consulta_Inbound")
        Dtg_Casos_Inbound.DataBind()
        Lbl_Cuenta_Inbound.Text = "Casos encontrados: " & objdatos.cantidad
        Drl_Estado_Inbound.SelectedIndex = 0
        Drl_Estado_Programado_Inbound.SelectedIndex = 0
        Pnl_Est_Prog_Inbound.Visible = False
        Txt_Caso_Ind_Inbound.Text = ""
        Txt_Casos_Inbound.Text = ""
        Txt_Fc_Ini_Inbound.Text = ""
        Txt_Fc_Fin_Inbound.Text = ""
        If Dtg_Casos_Inbound.Rows.Count > 0 Then
            Btn_Asignar_Inbound.Enabled = True
        Else
            Btn_Asignar_Inbound.Enabled = False
        End If
        Btn_Agregar.Enabled = True
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
    End Sub
    Protected Sub Btn_Asignar_Inbound_Click(sender As Object, e As EventArgs) Handles Btn_Asignar_Inbound.Click
        If DtgCarritoVen.Rows.Count > 0 Then
            Dim actualizar As New clscrmdatos
            actualizar.Validacion = "Inbound"
            actualizar.Superv = CType(Session("permisos"), clsusuario).usuario
            Try
                Dim agentes, rei As Integer
                rei = 0
                agentes = DtgCarritoVen.Rows.Count
                For Each row As GridViewRow In Dtg_Casos_Inbound.Rows
                    actualizar.caso = Int64.Parse(row.Cells(0).Text)
                    actualizar.idusuario = DtgCarritoVen.Rows(rei).Cells(0).Text
                    actualizar.Asignacion_Casos_General_Inbound_y_BSCS()
                    actualizar.estadoinc = (row.Cells(3).Text)
                    actualizar.Registro_Control_Asignacion()
                    rei = rei + 1
                    If rei = agentes Then
                        rei = 0
                    End If
                Next
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Asignación masiva realizada con éxito"
                Limpiar()
                objdatos.Validacion = "Inbound"
                objdatos.ajuste = ""
                Session("Asignados_Inbound") = objdatos.Consulta_Datos_Asignados()
                Dtg_Estad_Inbound.DataSource = Session("Asignados_Inbound")
                Dtg_Estad_Inbound.DataBind()
                lblusuInbound.Text = "Usuarios: " + objdatos.cantidad
                objdatos.ajuste = ""
                objdatos.Consulta_Total_Sin_Asignar()
                Lbl_Casos_Inbound.Text = objdatos.cantidad
                objdatos.ajuste = "Programados"
                objdatos.Consulta_Total_Sin_Asignar()
                Lbl_Vig_Inbound.Text = objdatos.archivo
                Lbl_Cad_Inbound.Text = objdatos.apn
                Lbl_Prog_Inbound.Text = objdatos.abierto
            Catch ex As Exception
                Pnl_Message.CssClass = "alert alert-danger"
                lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
            Finally
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
            End Try
        Else
            Pnl_Message.CssClass = "alert alert-info"
            lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Para realizar una asignacion, debe agregar agentes!!"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
        End If
    End Sub
    Protected Sub Dtg_Casos_Inbound_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtg_Casos_Inbound.RowDataBound
        Dim FcIngreso As Date
        If objdatos.Validacion = "Programado" Then
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                FcIngreso = Date.Now
                If DataBinder.Eval(e.Row.DataItem, "Fecha Programado") < FcIngreso Then
                    e.Row.ForeColor = Drawing.Color.Red
                    e.Row.Cells(6).Text = "CADUCADO"
                Else
                    e.Row.Cells(6).Text = "VIGENTE"
                End If
            End If
        End If
    End Sub
    Protected Sub Dtg_Estad_Inbound_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtg_Estad_Inbound.RowDataBound
        If objdatos.ajuste <> "Programados" Then
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                e.Row.Cells(1).ForeColor = Drawing.Color.White
                e.Row.Cells(1).BackColor = Drawing.Color.FromArgb(179, 197, 86)
            End If
        End If
    End Sub
    Protected Sub Dtg_Estad_Inbound_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Dtg_Estad_Inbound.PageIndexChanging
        Try
            Dtg_Estad_Inbound.PageIndex = e.NewPageIndex
            Dtg_Estad_Inbound.DataSource = Session("Asignados_Inbound")
            Dtg_Estad_Inbound.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Drl_Estado_Inbound_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Estado_Inbound.SelectedIndexChanged
        If Drl_Estado_Inbound.SelectedItem.Text = "Programado" Then
            Pnl_Est_Prog_Inbound.Visible = True
            objdatos.Validacion = "Inbound"
            objdatos.ajuste = "Programados"
            Session("Asignados_Inbound") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_Inbound.DataSource = Session("Asignados_Inbound")
            Dtg_Estad_Inbound.DataBind()
            lblusuInbound.Text = "Usuarios: " + objdatos.cantidad
        Else
            Pnl_Est_Prog_Inbound.Visible = False
            objdatos.Validacion = "Inbound"
            Drl_Estado_Programado_Inbound.SelectedIndex = 0
            objdatos.ajuste = ""
            Session("Asignados_Inbound") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_Inbound.DataSource = Session("Asignados_Inbound")
            Dtg_Estad_Inbound.DataBind()
            lblusuInbound.Text = "Usuarios: " + objdatos.cantidad
        End If
    End Sub
    '/***********************************************************/
    '/******************** CAMPAÑA BSCS *************************/
    '/***********************************************************/
    Protected Sub Btn_Buscar_BSCS_Click(sender As Object, e As EventArgs) Handles Btn_Buscar_BSCS.Click
        objdatos.Validacion = Lbl_Validacion.Text
        If Chk_Man_BSCS.Checked = True Then
            objdatos.obs = "Man"
        ElseIf Chk_Rein_BSCS.Checked = True Then
            objdatos.obs = "Rein"
        Else
            objdatos.obs = "Segui"
        End If
        If Drl_Estado_BSCS.SelectedItem.Text <> "- Seleccione -" Then
            objdatos.estadoinc = Drl_Estado_BSCS.SelectedItem.Text
        Else
            objdatos.estadoinc = ""
        End If
        If Drl_Estado_BSCS.SelectedItem.Text = "Programado" And Drl_Estado_Programado_BSCS.SelectedItem.Text = "Caducado" Then
            objdatos.archivo = Drl_Estado_Programado_BSCS.SelectedItem.Text
        ElseIf Drl_Estado_BSCS.SelectedItem.Text = "Programado" And Drl_Estado_Programado_BSCS.SelectedItem.Text = "Vigente"
            objdatos.archivo = Drl_Estado_Programado_BSCS.SelectedItem.Text
        Else
            objdatos.archivo = ""
        End If
        If Txt_Caso_Ind_BSCS.Text <> "" And Txt_Casos_BSCS.Text <> "" Then
            Pnl_Message.CssClass = "alert alert-info"
            lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Solo se puede hacer un tipo de asignacion, Individual o Multiple!!"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
            Exit Sub
        ElseIf Txt_Caso_Ind_BSCS.Text <> "" And Txt_Casos_BSCS.Text = "" Then
            objdatos.caso = Txt_Caso_Ind_BSCS.Text
            objdatos.cantidad = ""
        ElseIf Txt_Caso_Ind_BSCS.Text = "" And Txt_Casos_BSCS.Text <> "" Then
            objdatos.cantidad = "0000"
            objdatos.caso = Txt_Casos_BSCS.Text
        ElseIf Txt_Caso_Ind_BSCS.Text = "" And Txt_Casos_BSCS.Text = "" Then
            objdatos.caso = ""
            objdatos.cantidad = ""
        End If
        If Txt_Fc_Ini_BSCS.Text <> "" And Txt_Fc_Fin_BSCS.Text <> "" Then
            objdatos.fcini = Txt_Fc_Ini_BSCS.Text & " 00:00:00"
            objdatos.fcfin = Txt_Fc_Fin_BSCS.Text & " 23:59:59"
        Else
            objdatos.fcini = ""
            objdatos.fcfin = ""
        End If
        If objdatos.caso = "" And objdatos.Bandeja = "" And objdatos.estadoinc = "" And objdatos.fcini = "" And objdatos.fcfin = "" Then
            Pnl_Message.CssClass = "alert alert-warning"
            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Debe llenar por lo menos una opcion de filtro!!"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
            Exit Sub
        End If
        Session("Consulta_BSCS") = objdatos.Consulta_Datos_Sin_Asignar()
        Dtg_Casos_BSCS.DataSource = Session("Consulta_BSCS")
        Dtg_Casos_BSCS.DataBind()
        Lbl_Cuenta_BSCS.Text = "Casos encontrados: " & objdatos.cantidad
        Drl_Estado_BSCS.SelectedIndex = 0
        Drl_Estado_Programado_BSCS.SelectedIndex = 0
        Pnl_Est_Prog_BSCS.Visible = False
        Txt_Caso_Ind_BSCS.Text = ""
        Txt_Casos_BSCS.Text = ""
        Txt_Fc_Ini_BSCS.Text = ""
        Txt_Fc_Fin_BSCS.Text = ""
        If Dtg_Casos_BSCS.Rows.Count > 0 Then
            Btn_Asignar_BSCS.Enabled = True
        Else
            Btn_Asignar_BSCS.Enabled = False
        End If
        Btn_Agregar.Enabled = True
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
    End Sub
    Protected Sub Btn_Asignar_BSCS_Click(sender As Object, e As EventArgs) Handles Btn_Asignar_BSCS.Click
        If DtgCarritoVen.Rows.Count > 0 Then
            Dim actualizar As New clscrmdatos
            actualizar.Validacion = "BSCS"
            actualizar.Superv = CType(Session("permisos"), clsusuario).usuario
            Try
                Dim agentes, rei As Integer
                rei = 0
                agentes = DtgCarritoVen.Rows.Count
                For Each row As GridViewRow In Dtg_Casos_BSCS.Rows
                    actualizar.caso = Int64.Parse(row.Cells(0).Text)
                    actualizar.idusuario = DtgCarritoVen.Rows(rei).Cells(0).Text
                    actualizar.Asignacion_Casos_General_Inbound_y_BSCS()
                    actualizar.estadoinc = (row.Cells(3).Text)
                    actualizar.Registro_Control_Asignacion()
                    rei = rei + 1
                    If rei = agentes Then
                        rei = 0
                    End If
                Next
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Asignación masiva realizada con éxito"
                Limpiar()
                objdatos.Validacion = "BSCS"
                objdatos.ajuste = ""
                Session("Asignados_BSCS") = objdatos.Consulta_Datos_Asignados()
                Dtg_Estad_BSCS.DataSource = Session("Asignados_BSCS")
                Dtg_Estad_BSCS.DataBind()
                lblUsuBSCS.Text = "Usuarios: " + objdatos.cantidad
                objdatos.ajuste = ""
                objdatos.Consulta_Total_Sin_Asignar()
                Lbl_Casos_BSCS.Text = objdatos.cantidad
                Lbl_Rein_BSCS.Text = objdatos.min
                objdatos.ajuste = "Programados"
                objdatos.Consulta_Total_Sin_Asignar()
                Lbl_Vig_BSCS.Text = objdatos.archivo
                Lbl_Cad_BSCS.Text = objdatos.apn
                Lbl_Prog_BSCS.Text = objdatos.abierto
            Catch ex As Exception
                Pnl_Message.CssClass = "alert alert-danger"
                lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
            Finally
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
            End Try
        Else
            Pnl_Message.CssClass = "alert alert-info"
            lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Para realizar una asignacion, debe agregar agentes!!"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "Pleg_Loading();", True)
        End If
    End Sub
    Protected Sub Dtg_Casos_BSCS_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtg_Casos_BSCS.RowDataBound
        Dim FcIngreso As Date
        If objdatos.Validacion = "Programado" Then
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                FcIngreso = Date.Now
                If DataBinder.Eval(e.Row.DataItem, "Fecha Programado") < FcIngreso Then
                    e.Row.ForeColor = Drawing.Color.Red
                    e.Row.Cells(6).Text = "CADUCADO"
                Else
                    e.Row.Cells(6).Text = "VIGENTE"
                End If
            End If
        End If
    End Sub
    Protected Sub Dtg_Estad_BSCS_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtg_Estad_BSCS.RowDataBound
        If objdatos.ajuste <> "Programados" Then
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                e.Row.Cells(1).ForeColor = Drawing.Color.White
                e.Row.Cells(1).BackColor = Drawing.Color.FromArgb(179, 197, 86)
            End If
        End If
    End Sub
    Protected Sub Dtg_Estad_BSCS_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Dtg_Estad_BSCS.PageIndexChanging
        Try
            Dtg_Estad_BSCS.PageIndex = e.NewPageIndex
            Dtg_Estad_BSCS.DataSource = Session("Asignados_BSCS")
            Dtg_Estad_BSCS.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Drl_Estado_BSCS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Estado_BSCS.SelectedIndexChanged
        If Drl_Estado_BSCS.SelectedIndex <> 0 Then
            Chk_Segui_BSCS.Checked = False
            Chk_Segui_BSCS.Enabled = False
        Else
            Chk_Segui_BSCS.Enabled = True
        End If
        If Drl_Estado_BSCS.SelectedItem.Text = "Programado" Then
            Pnl_Est_Prog_BSCS.Visible = True
            objdatos.Validacion = "BSCS"
            objdatos.ajuste = "Programados"
            Session("Asignados_BSCS") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_BSCS.DataSource = Session("Asignados_BSCS")
            Dtg_Estad_BSCS.DataBind()
            lblUsuBSCS.Text = "Usuarios: " + objdatos.cantidad
        Else
            Pnl_Est_Prog_BSCS.Visible = False
            objdatos.Validacion = "BSCS"
            Drl_Estado_Programado_BSCS.SelectedIndex = 0
            objdatos.ajuste = ""
            Session("Asignados_BSCS") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_BSCS.DataSource = Session("Asignados_BSCS")
            Dtg_Estad_BSCS.DataBind()
            lblUsuBSCS.Text = "Usuarios: " + objdatos.cantidad
        End If
    End Sub
    Protected Sub Chk_Segui_BSCS_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Segui_BSCS.CheckedChanged
        objdatos.Validacion = "BSCS"
        If Chk_Segui_BSCS.Checked = True Then
            Drl_Estado_BSCS.SelectedIndex = 0
            Drl_Estado_BSCS.Enabled = False
            Drl_Estado_Programado_BSCS.SelectedIndex = 0
            objdatos.ajuste = "Seguimiento"
            Session("Asignados_BSCS") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_BSCS.DataSource = Session("Asignados_BSCS")
            Dtg_Estad_BSCS.DataBind()
            lblUsuBSCS.Text = "Usuarios: " + objdatos.cantidad
        End If
    End Sub
    Protected Sub Chk_Man_BSCS_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Man_BSCS.CheckedChanged
        objdatos.Validacion = "BSCS"
        If Chk_Man_BSCS.Checked = True Then
            Drl_Estado_BSCS.SelectedIndex = 0
            Drl_Estado_BSCS.Enabled = True
            Drl_Estado_Programado_BSCS.SelectedIndex = 0
            objdatos.ajuste = ""
            Session("Asignados_BSCS") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_BSCS.DataSource = Session("Asignados_BSCS")
            Dtg_Estad_BSCS.DataBind()
            lblUsuBSCS.Text = "Usuarios: " + objdatos.cantidad
        End If
    End Sub
    Protected Sub Chk_Rein_BSCS_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Rein_BSCS.CheckedChanged
        objdatos.Validacion = "BSCS"
        If Chk_Rein_BSCS.Checked = True Then
            Drl_Estado_BSCS.SelectedIndex = 0
            Drl_Estado_BSCS.Enabled = True
            Drl_Estado_Programado_BSCS.SelectedIndex = 0
            objdatos.ajuste = ""
            Session("Asignados_BSCS") = objdatos.Consulta_Datos_Asignados()
            Dtg_Estad_BSCS.DataSource = Session("Asignados_BSCS")
            Dtg_Estad_BSCS.DataBind()
            lblUsuBSCS.Text = "Usuarios: " + objdatos.cantidad
        End If
    End Sub
End Class