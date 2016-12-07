Public Class Resolved_SD
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Seguimiento - Service"
                Consulta_Control_Escala()
                carga_drl()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Sub carga_drl()
        Dim objdatos As New clscrmdatos
        Dim objvoz As New clsvoz
        objdatos.Validacion = "Estado_Caso_SD"
        With Drl_Estado_Sd
            .DataSource = objdatos.Cargar_DRLS_Control()
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
            .Items.Insert(0, "- Seleccione ")
            .Items(0).Value = 0
        End With
        objvoz.Validacion = "Service"
        With drlCategoria
            .DataSource = objvoz.CategoriacierreCPD_inbound
            .DataTextField = "tipificacion1"
            .DataValueField = "cod_tipificacion"
            .DataBind()
        End With
    End Sub

    Sub limpiar()
        lbl_caso.Text = ""
        Lbl_campaña.Text = ""
        Drl_Estado_Sd.SelectedIndex = 0
        drlCategoria.SelectedIndex = 0
        Txt_Observaciones.Text = ""
        lbl_SD.Text = ""
        Txt_Respuesta.Text = ""
        Consulta_Control_Escala()
    End Sub
    Sub Consulta_Control_Escala()
        Try
            Dim objGeneral As New clsgeneral
            objGeneral.idusuario = CType(Session("permisos"), clsusuario).usuario
            objGeneral.nombre = "Service"
            objGeneral.Validacion = "Resolved_SD"
            Dtg_General.DataSource = objGeneral.Consulta_Control()
            Dtg_General.DataBind()
            Lbl_Cuenta2.Text = objGeneral.cantreg
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Protected Sub Dtg_General_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles Dtg_General.RowCommand
        Try
            If e.CommandName = "Seleccion" Then
                Dim objvoz As New clsvoz
                Pnl_Message.CssClass = Nothing
                lblmsg.Text = Nothing
                Drl_Estado_Sd.SelectedIndex = 0
                Txt_Observaciones.Text = ""
                drlCategoria.SelectedIndex = 0
                drlCategoria.Enabled = False
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                lbl_caso.Text = Dtg_General.Rows(index).Cells(1).Text
                Lbl_campaña.Text = Dtg_General.Rows(index).Cells(5).Text
                lbl_SD.Text = Dtg_General.Rows(index).Cells(2).Text
                Lbl_Estado.Text = Dtg_General.Rows(index).Cells(6).Text
                Dim objGeneral As New clsgeneral
               
                If Lbl_Estado.Text = "Cerrado" Then
                    Btn_Guardar.Enabled = False
                Else
                    Btn_Guardar.Enabled = True
                End If

                objGeneral.identidad = lbl_caso.Text
                objGeneral.Validacion = "Buscar_Respuesta"
                objGeneral.Consulta_Control()
                Txt_Respuesta.Text = objGeneral.cargo
                Session("Vlidacion_Reload_Resolved") = True
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Protected Sub Drl_Estado_Sd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Estado_Sd.SelectedIndexChanged
        Try
            If Drl_Estado_Sd.SelectedItem.Value = "Cerrado" Then
                drlCategoria.Enabled = True
            Else
                drlCategoria.Enabled = False
                drlCategoria.SelectedIndex = 0
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
        Try
            If txtcaso.Text <> "" Then
                Dim objvoz As New clsvoz
                Pnl_Message.CssClass = Nothing
                lblmsg.Text = Nothing
                Drl_Estado_Sd.SelectedIndex = 0
                Txt_Observaciones.Text = ""
                drlCategoria.SelectedIndex = 0
                drlCategoria.Enabled = False
                objvoz.caso = txtcaso.Text
                objvoz.Consulta_Resolved_Inbound_SD()
                If objvoz.cantidad > 0 Then
                    lbl_caso.Text = objvoz.caso
                    Lbl_campaña.Text = objvoz.campana
                    Lbl_Estado.Text = objvoz.estadoinc
                    lbl_SD.Text = objvoz.tickler
                    Dim objGeneral As New clsgeneral
                   
                    If Lbl_Estado.Text = "Cerrado" Then
                        Btn_Guardar.Enabled = False
                    Else
                        Btn_Guardar.Enabled = True
                    End If

                    objGeneral.identidad = lbl_caso.Text
                    objGeneral.Validacion = "Buscar_Respuesta"
                    objGeneral.Consulta_Control()
                    Txt_Respuesta.Text = objGeneral.cargo
                    Session("Vlidacion_Reload_Resolved") = True
                Else
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No existen registros coincidentes para ese caso, revise la información!"
                End If
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span Class='glyphicon glyphicon-warning-sign'></span> Debe ingresar el caso para realizar una busqueda!"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Try
            If Session("Seg_Caso_Resolved") = lbl_caso.Text And Session("Seg_Estado_Resolved") = "Cerrado" And Drl_Estado_Sd.SelectedItem.Value = "Cerrado" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> La acción esta inhabilita o genera duplicidad consulta de nuevo el caso para validar la gestión y permitir el registro"
                Dim objGeneral1 As New clsgeneral
                objGeneral1.idusuario = CType(Session("permisos"), clsusuario).usuario
                objGeneral1.nombre = "Service"
                objGeneral1.Validacion = "Resolved_SD"
                Dtg_General.DataSource = objGeneral1.Consulta_Control()
                Dtg_General.DataBind()
                Lbl_Cuenta2.Text = objGeneral1.cantreg
                Exit Sub
            End If
            If lbl_caso.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione Un Caso Por Favor"
                Exit Sub
            End If
            If Drl_Estado_Sd.SelectedIndex = 0 Then
                lblmsg.Text = "Seleccione un estado SD"
                Exit Sub
            End If
            If drlCategoria.SelectedItem.Value = "0" And Drl_Estado_Sd.SelectedItem.Value = "Cerrado" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una categoria de cierre"
                Exit Sub
            End If
            If Txt_Observaciones.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite una obsevacion"
                Exit Sub
            End If
            Dim objdatos As New clsvoz
            objdatos.caso = lbl_caso.Text
            objdatos.estadoinc = Drl_Estado_Sd.SelectedItem.Text
            objdatos.obs = Txt_Observaciones.Text
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            If drlCategoria.SelectedItem.Value <> "- Seleccione -" Then
                objdatos.Categoria_Cierre = drlCategoria.SelectedValue
            End If
            objdatos.tipificacion = Drl_Estado_Sd.SelectedItem.Text
            If objdatos.tipificacion = "Cerrado" Then
                objdatos.tipificacion = "Cerrado Informatica"
            End If
            If Lbl_campaña.Text = "DILO" Then
                objdatos.registrocrmfallareddilo()
            End If
            If Lbl_campaña.Text = "DATOS" Or Lbl_campaña.Text = "BSCS" Then
                objdatos.Validacion = "Gestion_De_Resolved_SD"
                objdatos.registrocrmfallareddatos()
            End If
            If Lbl_campaña.Text = "FALLA DES" Then
                If Lbl_campaña.Text = "FALLA DES" Then
                    Dim objdatos2 As New clscrmdatos
                    objdatos2.caso = lbl_caso.Text
                    objdatos2.Validacion = "Fidelizacion"
                    objdatos2.Validacion_Registro_Inboun()
                    objdatos.caso = objdatos2.min
                End If
                objdatos.Validacion = "Gestion_De_Resolved_SD"
                objdatos.registrocrmfallaredFideiza()
            End If
            If Lbl_campaña.Text = "VOZ" Then
                objdatos.Validacion = "Gestion_De_Resolved_SD"
                objdatos.registrocrmfallared()
            End If
            If Lbl_campaña.Text = "INBOUND" Then
                If Drl_Estado_Sd.SelectedItem.Value = "Cerrado" Then
                    objdatos.Validacion = "Diagnostico"
                    objdatos.registro_CRM_inbound_escalamiento()
                Else
                    objdatos.preg2 = "Service"
                    objdatos.Validacion = ""
                    objdatos.registro_CRM_inbound_escalamiento()
                End If
            End If
            'GUARDAR DIAGNOSTICO SOLO CUANDO EL ESTADO ES CERRADO-------------
            If Drl_Estado_Sd.SelectedItem.Value = "Cerrado" Then
                ''dilo''
                If Lbl_campaña.Text = "DILO" Then
                    objdatos.Validacion = "Diagnostico"
                    objdatos.registrocrmfallareddilo()
                End If
                ''DATOS''
                If Lbl_campaña.Text = "DATOS" Or Lbl_campaña.Text = "BSCS" Then
                    objdatos.Validacion = "Diagnostico"
                    objdatos.registrocrmfallareddatos()
                End If
                ''fideliza''
                If Lbl_campaña.Text = "FALLA DES" Then
                    If Lbl_campaña.Text = "FALLA DES" Then
                        Dim objdatos2 As New clscrmdatos
                        objdatos2.caso = lbl_caso.Text
                        objdatos2.Validacion = "Fidelizacion"
                        objdatos2.Validacion_Registro_Inboun()
                        objdatos.caso = objdatos2.min
                    End If
                    objdatos.Validacion = "Diagnostico"
                    objdatos.registrocrmfallaredFideiza()
                End If
                '---Voz---'
                If Lbl_campaña.Text = "VOZ" Then
                    objdatos.Validacion = "Diagnostico"
                    objdatos.registrocrmfallared()
                End If
            End If
            ''CAMBIAR ESTADO EN BANDEJAS CUANDO EL ESTADO ES CERRADO----------
            If Drl_Estado_Sd.SelectedItem.Value = "Cerrado" Then
                objdatos.Nombre = "Cerrado Informatica"
                objdatos.Validacion = Lbl_campaña.Text
                objdatos.caso = lbl_caso.Text
                objdatos.Modificar_Bandejas_Estado_Escalado()
            ElseIf Drl_Estado_Sd.SelectedItem.Text = "Transfiere a Tecnica" Then
                objdatos.Nombre = "Seguimiento"
                objdatos.Validacion = Lbl_campaña.Text
                objdatos.caso = lbl_caso.Text
                objdatos.Modificar_Bandejas_Estado_Escalado()

            End If

            Dim objGeneral As New clsgeneral
            objGeneral.identidad = lbl_caso.Text
            objGeneral.estado = Drl_Estado_Sd.SelectedItem.Text
            objGeneral.Actualizacion_Estado_SD()

            If Drl_Estado_Sd.SelectedItem.Text <> "Pendiente" Then
                objGeneral.Validacion = "Control_Llamada"
                objGeneral.Actualizacion_Escalado()
            End If
            Consulta_Control_Escala()
            Session("Seg_Estado_Resolved") = Drl_Estado_Sd.SelectedItem.Text
            Session("Seg_Caso_Resolved") = Val(lbl_caso.Text)

            limpiar()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Seguimiento ingresado con exito "
            Session("Vlidacion_Reload_Resolved") = False
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
End Class