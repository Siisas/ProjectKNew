Imports System.IO

Public Class HelpDeskSolucion
    Inherits System.Web.UI.Page
    Dim ObjHelpDesk As New clsHelpDesk

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If

            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                Cargar_Drl()

            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Public Sub Cargar_Drl()
        Try
            With drlCategoria
                .DataSource = ObjHelpDesk.Consulta_Categoria
                .DataTextField = "Nombre"
                .DataValueField = "Cod_HelpDesk_Categoria"
                .DataBind()
            End With
            ObjHelpDesk.Cod_HelpDesk_Registro = drlCategoria.SelectedItem.Value
            With drlTipo
                .DataSource = ObjHelpDesk.Consulta_Tipo
                .DataTextField = "Nombre"
                .DataValueField = "Cod_HelpDesk_Tipo"
                .DataBind()
            End With
            With drlAreaUpdate
                .DataSource = ObjHelpDesk.Consulta_Area
                .DataTextField = "Nombre"
                .DataValueField = "Cod_HelpDesk_Complemento"
                .DataBind()
            End With
            With drlcomplejidad
                .DataSource = ObjHelpDesk.Consulta_Complejidad
                .DataTextField = "Nombre"
                .DataValueField = "Cod_HelpDesk_Complemento"
                .DataBind()
            End With
            With drloperatividad
                .DataSource = ObjHelpDesk.Consulta_Operatividad
                .DataTextField = "Nombre"
                .DataValueField = "Cod_HelpDesk_Complemento"
                .DataBind()
            End With
            With drlTecnico
                .DataSource = ObjHelpDesk.Consulta_Tecnico
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
            With drlEstadoConsulta
                .DataSource = ObjHelpDesk.Consulta_Estado
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            ObjHelpDesk.Observacion = "estado"
            With drlEstado
                .DataSource = ObjHelpDesk.Consulta_Estado
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub btnConsultaCod_HelpDesk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConsultaCod_HelpDesk.Click
        Try
            If TxtCod_Help_Desk.Text = "" And TxtFecha_Inicio.Text = "" And TxtFecha_Fin.Text = "" And drlPrioridad.Text = "1" And drlEstadoConsulta.Text = "1" Then
                lblmsg.Text = "Ingrese alguna opcion de filtro"
                Exit Sub
            End If
            ObjHelpDesk.Id_Usuario = lblusuario.Text
            If TxtCod_Help_Desk.Text <> Nothing Then
                ObjHelpDesk.Cod_HelpDesk_Solucion = TxtCod_Help_Desk.Text
            Else
                ObjHelpDesk.Cod_HelpDesk_Solucion = Nothing
            End If
            If TxtFecha_Inicio.Text <> Nothing Then
                ObjHelpDesk.Fecha_Inicio = TxtFecha_Inicio.Text
            Else
                ObjHelpDesk.Fecha_Inicio = Nothing
            End If
            If TxtFecha_Fin.Text <> Nothing Then
                ObjHelpDesk.Fecha_Fin = TxtFecha_Fin.Text
            Else
                ObjHelpDesk.Fecha_Fin = Nothing
            End If
            If drlPrioridad.SelectedIndex <> 0 Then
                ObjHelpDesk.Prioridad = drlPrioridad.Text
            Else
                ObjHelpDesk.Prioridad = Nothing
            End If
            If drlEstadoConsulta.SelectedIndex <> 0 Then
                ObjHelpDesk.Estado = drlEstadoConsulta.Text
            Else
                ObjHelpDesk.Estado = Nothing
            End If
            If txt_cod_usu.Text <> Nothing Then
                ObjHelpDesk.Persona_Reporta = txt_cod_usu.Text
            Else
                ObjHelpDesk.Persona_Reporta = Nothing
            End If
            Session("dtsB") = ObjHelpDesk.ConsultaTicketGestion
            dtggeneralHelpDesk.DataSource = Session("dtsB")

            dtggeneralHelpDesk.DataBind()
            lblcuentaHelpDesk.Text = ObjHelpDesk.Cantidad

            If TxtCod_Help_Desk.Text <> Nothing Then
                ObjHelpDesk.Cod_HelpDesk_Registro = TxtCod_Help_Desk.Text
                dtggeneralHelpDeskSolucion.DataSource = ObjHelpDesk.Consulta_Proceso()
                dtggeneralHelpDeskSolucion.DataBind()
                lblcuentaSoluciones.Text = ObjHelpDesk.Cantidad
            Else
                dtggeneralHelpDeskSolucion.DataSource = Nothing
                dtggeneralHelpDeskSolucion.DataBind()
                lblcuentaSoluciones.Text = ""
            End If

            TxtFecha_Inicio.Text = ""
            TxtFecha_Fin.Text = ""
            lblmsg.Text = ""
            If lblcuentaHelpDesk.Text <> "" And lblcuentaHelpDesk.Text <> "0" Then
                Btnxls.Visible = True
            Else
                Btnxls.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub


    Public Sub ActualizarTicket()
        Try
            If drlEstado.Text = "Escalado" Then
                ObjHelpDesk.validacion = 1
                ObjHelpDesk.Asignado = drlTecnico.SelectedValue
            End If
            ObjHelpDesk.Cod_HelpDesk_Solucion = LblCod_HeplDeks.Text
            ObjHelpDesk.Estado = drlEstado.Text
            ObjHelpDesk.Actualizar_Estado_Ticket()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub BtnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGuardar.Click
        Try
            If txtObservacion.Text = "" Then
                lblmsg.Text = "Ingrese una Observacion"
                Exit Sub
            End If
            If drlEstado.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un estado"
                Exit Sub
            End If
            If drlcomplejidad.Text = "1" Then
                lblmsg.Text = "Ingrese una Complejidad"
                Exit Sub
            End If
            If drloperatividad.Text = "1" Then
                lblmsg.Text = "Ingrese una Operatividad"
                Exit Sub
            End If
            If drlCategoria.SelectedIndex = 0 Then
                lblmsg.Text = "Debe registrar Categoria y Tipo!!"
                Exit Sub
            End If

            If drlEstado.Text = "Escalado" And drlTecnico.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Debe seleccionar la persona a la cual escalar el ticket"
                Exit Sub
            End If

            ObjHelpDesk.Id_Usuario = lblusuario.Text
            ObjHelpDesk.Observacion = txtObservacion.Text
            ObjHelpDesk.Estado = drlEstado.Text
            ObjHelpDesk.Fk_Cod_HelpDesk_Registro = LblCod_HeplDeks.Text

            If txtreiteracion.Text <> "" Then
                ObjHelpDesk.reiteracion = txtreiteracion.Text '''''REITERACION
            Else
                ObjHelpDesk.Fk_Cod_Tipo = 0 '''''REITERACION
            End If
            ObjHelpDesk.Fk_Complejidad = drlcomplejidad.SelectedItem.Text ''''COMPLEJIDAD
            ObjHelpDesk.Fk_Operatividad = drloperatividad.SelectedItem.Text ''''OPERATIVIDAD
            ObjHelpDesk.Fk_Cod_Categoria = drlCategoria.SelectedItem.Value '*** CATEGORIA
            ObjHelpDesk.Fk_Cod_Tipo = drlTipo.SelectedItem.Value '*** TIPO

            ObjHelpDesk.Ingresar_Solucion_Ticket()

            If txtreiteracion.Text = Nothing Then
                ObjHelpDesk.Cod_HelpDesk_Registro = LblCod_HeplDeks.Text
                ObjHelpDesk.Fk_Complejidad = drlcomplejidad.Text
                ObjHelpDesk.Fk_Operatividad = drloperatividad.Text
                ObjHelpDesk.Update_Solucion_compleyopera()
            Else
                ObjHelpDesk.reiteracion = txtreiteracion.Text
                ObjHelpDesk.Cod_HelpDesk_Registro = LblCod_HeplDeks.Text
                ObjHelpDesk.Fk_Complejidad = drlcomplejidad.Text
                ObjHelpDesk.Fk_Operatividad = drloperatividad.Text
                ObjHelpDesk.Update_Solucion_compleyopera()
            End If


            If CheckBoxTipificacion.Checked = True Then
                ObjHelpDesk.Cod_HelpDesk_Registro = LblCod_HeplDeks.Text
                ObjHelpDesk.Fk_Cod_Categoria = drlCategoria.Text
                ObjHelpDesk.Fk_Cod_Tipo = drlTipo.Text
            End If

            If CheckBoxArea.Checked = True Then
                ObjHelpDesk.Fk_Cod_Complemento_Area = drlAreaUpdate.Text

                ObjHelpDesk.Update_Solucion_Ticket()
            End If

            ActualizarTicket()

            lblmsg.Text = "seguimiento Registrado "

            If TxtCod_Help_Desk.Text <> Nothing Then
                ObjHelpDesk.Cod_HelpDesk_Solucion = LblCod_HeplDeks.Text

                dtggeneralHelpDeskSolucion.DataSource = ObjHelpDesk.Consulta_Proceso
                dtggeneralHelpDeskSolucion.DataBind()
                lblcuentaSoluciones.Text = ObjHelpDesk.Cantidad
            End If


            CheckBoxTipificacion.Checked = False
            CheckBoxArea.Checked = False

            BtnGuardar.Visible = False
            txtObservacion.Text = ""
            txtreiteracion.Text = ""

            Cargar_Drl()
            LblCod_HeplDeks.Text = ""
            LblFecha_Registro.Text = ""
            LblUsuarioAsigan.Text = ""
            LblFecha_Asigan.Text = ""
            LblComentario.Text = ""
            LblPrioridad.Text = ""
            LblTema.Text = ""
            LblObservacion.Text = ""
            LblPersona_Reporta_Falla.Text = ""
            LblModulo.Text = ""
            LblEstado.Text = ""
            LblArea.Text = ""
            lblmsg.Text = "Registro Exitoso"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

     Protected Sub dtggeneralHelpDesk_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneralHelpDesk.PageIndexChanging
        Try
            If TxtCod_Help_Desk.Text = "" And TxtFecha_Inicio.Text = "" And TxtFecha_Fin.Text = "" And drlPrioridad.Text = "1" And drlEstadoConsulta.Text = "1" Then
                lblmsg.Text = "Ingrese alguna opcion de filtro"
                Exit Sub
            End If
            If TxtFecha_Inicio.Text <> Nothing Then
                ObjHelpDesk.Fecha_Inicio = TxtFecha_Inicio.Text
            End If
            If TxtFecha_Fin.Text <> Nothing Then
                ObjHelpDesk.Fecha_Fin = TxtFecha_Fin.Text
            End If
            If drlPrioridad.Text <> "1" Then
                ObjHelpDesk.Prioridad = drlPrioridad.Text
            End If
            If drlEstadoConsulta.Text <> "1" Then
                ObjHelpDesk.Estado = drlEstadoConsulta.Text
            End If
            dtggeneralHelpDesk.DataSource = Session("dtsB")
            dtggeneralHelpDesk.PageIndex = e.NewPageIndex
            dtggeneralHelpDesk.DataBind()
            lblcuentaHelpDesk.Text = ObjHelpDesk.Cantidad
            TxtFecha_Inicio.Text = ""
            TxtFecha_Fin.Text = ""
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se producjo error " + ex.Message
        End Try
    End Sub



    Protected Sub dtggeneralHelpDeskSolucion_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneralHelpDeskSolucion.PageIndexChanging
        Try
            If LblCod_HeplDeks.Text = "" Then
                lblmsg.Text = "No se puede realizar esta accion debido a que no hay un codigo de Help Desk"
                Exit Sub
            End If

            dtggeneralHelpDeskSolucion.PageIndex = e.NewPageIndex
            dtggeneralHelpDeskSolucion.DataBind()

            TxtFecha_Inicio.Text = ""
            TxtFecha_Fin.Text = ""
            lblmsg.Text = ""

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Public Sub Exportarxls()
        Try
            Dim sb As New StringBuilder
            Dim sw As New StringWriter(sb)
            Dim htw As New HtmlTextWriter(sw)
            Dim pagina As Page = New Page
            Dim form = New HtmlForm
            Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"


            pagina.EnableEventValidation = False
            pagina.DesignerInitialize()
            pagina.Controls.Add(form)
            form.Controls.Add(dtggeneralHelpDesk)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True

            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=data.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub Btnxls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btnxls.Click
        Try
            Exportarxls()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub BtnTodos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTodos.Click
        Try
            ObjHelpDesk.Cod_HelpDesk_Solucion = Nothing
            ObjHelpDesk.Prioridad = Nothing
            ObjHelpDesk.Fecha_Inicio = Nothing
            ObjHelpDesk.Fecha_Fin = Nothing
            ObjHelpDesk.Estado = Nothing
            ObjHelpDesk.Id_Usuario = lblusuario.Text
            Session("dtsB") = ObjHelpDesk.ConsultaTicketGestion
            dtggeneralHelpDesk.DataSource = Session("dtsB")

            dtggeneralHelpDesk.DataBind()
            lblcuentaHelpDesk.Text = ObjHelpDesk.Cantidad

            If lblcuentaHelpDesk.Text <> "" And lblcuentaHelpDesk.Text <> "0" Then
                Btnxls.Visible = True
            Else
                Btnxls.Visible = False
            End If
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error " + ex.Message
        End Try
    End Sub

    Protected Sub dtggeneralHelpDesk_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtggeneralHelpDesk.RowCommand
        Try
            'Mediante este codigo envio la identificacion del aspirante, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Seleccion" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                ObjHelpDesk.Id_Usuario = lblusuario.Text
                ObjHelpDesk.Cod_HelpDesk_Registro = dtggeneralHelpDesk.Rows(index).Cells(0).Text
                ObjHelpDesk.ConsultaSeleccion_TicketGestion()
                LblCod_HeplDeks.Text = ObjHelpDesk.Cod_HelpDesk_Registro
                LblFecha_Registro.Text = ObjHelpDesk.Fecha_Registro
                LblUsuarioAsigan.Text = ObjHelpDesk.Asigna
                LblFecha_Asigan.Text = ObjHelpDesk.Fecha_Asigna
                LblComentario.Text = ObjHelpDesk.ObservacionAsigna
                LblPrioridad.Text = ObjHelpDesk.Prioridad
                LblTema.Text = ObjHelpDesk.Tema
                LblObservacion.Text = ObjHelpDesk.Observacion
                LblPersona_Reporta_Falla.Text = ObjHelpDesk.Persona_Reporta
                LblModulo.Text = ObjHelpDesk.Modulo
                LblEstado.Text = ObjHelpDesk.Estado
                LblArea.Text = ObjHelpDesk.Nombre

                If TxtCod_Help_Desk.Text <> Nothing Then
                    ObjHelpDesk.Cod_HelpDesk_Solucion = LblCod_HeplDeks.Text

                    dtggeneralHelpDeskSolucion.DataSource = ObjHelpDesk.Consulta_Proceso
                    dtggeneralHelpDeskSolucion.DataBind()
                    lblcuentaSoluciones.Text = ObjHelpDesk.Cantidad
                End If

                ObjHelpDesk.Consulta_Proceso()
                If ObjHelpDesk.Fk_Cod_Categoria = 0 Or ObjHelpDesk.Fk_Cod_Tipo = 0 Then
                    drlCategoria.SelectedIndex = 0
                    ObjHelpDesk.Cod_HelpDesk_Registro = drlCategoria.SelectedItem.Value
                    With drlTipo
                        .DataSource = ObjHelpDesk.Consulta_Tipo
                        .DataTextField = "Nombre"
                        .DataValueField = "Cod_HelpDesk_Tipo"
                        .DataBind()
                    End With
                    drlCategoria.Enabled = True
                    drlTipo.Enabled = True
                    drlTipo.SelectedIndex = 0
                    CheckBoxTipificacion.Checked = True
                Else
                    drlCategoria.SelectedValue = Integer.Parse(ObjHelpDesk.Fk_Cod_Categoria)
                    ObjHelpDesk.Cod_HelpDesk_Registro = drlCategoria.SelectedItem.Value
                    With drlTipo
                        .DataSource = ObjHelpDesk.Consulta_Tipo
                        .DataTextField = "Nombre"
                        .DataValueField = "Cod_HelpDesk_Tipo"
                        .DataBind()
                    End With
                    drlTipo.SelectedValue = Integer.Parse(ObjHelpDesk.Fk_Cod_Tipo)
                    CheckBoxTipificacion.Checked = False
                    drlCategoria.Enabled = False
                    drlTipo.Enabled = False
                End If

                If LblCod_HeplDeks.Text = "0" Then
                    BtnGuardar.Visible = False
                Else
                    BtnGuardar.Visible = True
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub drlCategoria_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlCategoria.SelectedIndexChanged
        Try
            ObjHelpDesk.Cod_HelpDesk_Registro = drlCategoria.SelectedItem.Value
            With drlTipo
                .DataSource = ObjHelpDesk.Consulta_Tipo
                .DataTextField = "Nombre"
                .DataValueField = "Cod_HelpDesk_Tipo"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub CheckBoxTipificacion_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTipificacion.CheckedChanged
        If CheckBoxTipificacion.Checked = True Then
            drlCategoria.Enabled = True
            drlTipo.Enabled = True
        Else
            drlCategoria.Enabled = False
            drlTipo.Enabled = False
        End If
    End Sub

End Class