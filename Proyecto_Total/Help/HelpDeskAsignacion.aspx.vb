Public Class HelpDeskAsignacion
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

                With drlTecnico
                    .DataSource = ObjHelpDesk.Consulta_Tecnico
                    .DataTextField = "nombreu"
                    .DataValueField = "idusuario"
                    .DataBind()
                End With
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
                With drlEstados
                    .DataSource = ObjHelpDesk.Consulta_Estado
                    .DataTextField = "Nombre"
                    .DataValueField = "Nombre"
                    .DataBind()
                End With
     
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Public Sub Consulta_Ticket()
        Try
            Session("HelpDeskAsignacion_dtggeneralHelpdesk") = ObjHelpDesk.ConsultaTodosTicketAsigna()
            dtggeneralHelpDesk.DataSource = Session("HelpDeskAsignacion_dtggeneralHelpdesk")
            dtggeneralHelpDesk.DataBind()
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error" + ex.Message
        End Try
    End Sub


    Protected Sub BtnActualizar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnActualizar.Click
        Consulta_Ticket()
    End Sub

    Protected Sub dtggeneralHelpDesk_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtggeneralHelpDesk.RowCommand
        Try
            'Mediante este codigo envio la identificacion del aspirante, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Seleccion" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                ObjHelpDesk.Cod_HelpDesk_Registro = dtggeneralHelpDesk.Rows(index).Cells(0).Text
                ObjHelpDesk.ConsultaTicketAsigna()
                LblCod_HeplDeks.Text = ObjHelpDesk.Cod_HelpDesk_Registro
                LblFecha_Registro.Text = ObjHelpDesk.Fecha_Registro
                LblUsuarioReporta.Text = ObjHelpDesk.Persona_Reporta
                LblPrioridad.Text = ObjHelpDesk.Prioridad
                LblTema.Text = ObjHelpDesk.Tema
                LblObservacion.Text = ObjHelpDesk.Observacion
                LblEstado.Text = ObjHelpDesk.Estado
                LblUsuarioReg.Text = ObjHelpDesk.Id_Usuario

                If (LblEstado.Text = "Abierto" Or LblEstado.Text = "Escalado" Or LblEstado.Text = "Rechazado") Then
                    BtnAsignarCaso.Enabled = True
                Else
                    BtnAsignarCaso.Enabled = False
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnConsulta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsulta.Click
        Try
            If (TxtCod_Ticket_Consulta.Text = "" And drlEstados.Text = "1" And TxtFecha_Inicio.Text = "" And TxtFecha_Fin.Text = "" And drlPrioridad.Text = "1") Then
                lblmsg.Text = "Seleccione una opcion de filtro"
                dtggeneralHelpDesk.DataSource = Nothing
                dtggeneralHelpDesk.DataBind()
                Exit Sub
            End If

            If (TxtCod_Ticket_Consulta.Text <> "") Then
                ObjHelpDesk.Cod_HelpDesk_Registro = TxtCod_Ticket_Consulta.Text
            Else
                ObjHelpDesk.Cod_HelpDesk_Registro = Nothing
            End If
            If (drlEstados.SelectedIndex <> 0) Then
                ObjHelpDesk.Estado = drlEstados.SelectedItem.Text
            Else
                ObjHelpDesk.Estado = ""
            End If
            If (TxtFecha_Inicio.Text <> "") Then
                ObjHelpDesk.Fecha_Inicio = TxtFecha_Inicio.Text
            Else
                ObjHelpDesk.Fecha_Inicio = ""
            End If
            If (TxtFecha_Fin.Text <> "") Then
                ObjHelpDesk.Fecha_Fin = TxtFecha_Fin.Text
            Else
                ObjHelpDesk.Fecha_Fin = ""
            End If
            If (drlPrioridad.SelectedIndex <> 0) Then
                ObjHelpDesk.Prioridad = drlPrioridad.SelectedItem.Text
            Else
                ObjHelpDesk.Prioridad = ""
            End If
            If (txt_cod_usu.Text <> "") Then
                ObjHelpDesk.Persona_Reporta = txt_cod_usu.Text
            Else
                ObjHelpDesk.Persona_Reporta = ""
            End If
            Session("HelpDeskAsignacion_dtggeneralHelpdesk") = ObjHelpDesk.ConsultaTodosTicketAsigna()
            dtggeneralHelpDesk.DataSource = Session("HelpDeskAsignacion_dtggeneralHelpdesk")
            dtggeneralHelpDesk.DataBind()
            lblcuentaHelpDesk.Text = ObjHelpDesk.Cantidad
            If lblcuentaHelpDesk.Text = "0" Then
                dtggeneralHelpDesk.DataSource = Nothing
                dtggeneralHelpDesk.DataBind()
                lblmsg.Text = "No se encontraron registros"
                Exit Sub
            End If
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error" + ex.Message
        End Try
    End Sub


    Protected Sub BtnAsignarCaso_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAsignarCaso.Click
        Try
            ObjHelpDesk.Cod_HelpDesk_Registro = LblCod_HeplDeks.Text
            ObjHelpDesk.Asignado = drlTecnico.Text
            ObjHelpDesk.Asigna = lblusuario.Text
            ObjHelpDesk.ObservacionAsigna = TxtObservacionAsigna.Text
            If CheckBoxTipificacion.Checked = True Then
                ObjHelpDesk.Fk_Cod_Categoria = drlCategoria.Text
                ObjHelpDesk.Fk_Cod_Tipo = drlTipo.Text
            End If
            If CheckBoxPrioridad.Checked = True Then
                ObjHelpDesk.Prioridad = drlPrioridadUpdate.Text
            End If
            If CheckBoxArea.Checked = True Then
                ObjHelpDesk.Fk_Cod_Complemento_Area = drlAreaUpdate.Text
            End If

            ObjHelpDesk.UpdateTicketAsignado()

            lblmsg.Text = "TicKet Asignado Correctamente"

            TxtObservacionAsigna.Text = ""
            drlPrioridadUpdate.Text = "1"
            drlCategoria.Text = "1"
            drlAreaUpdate.Text = "1"
            CheckBoxPrioridad.Checked = False
            CheckBoxTipificacion.Checked = False
            CheckBoxArea.Checked = False
            BtnAsignarCaso.Enabled = False

            LblCod_HeplDeks.Text = ""
            LblFecha_Registro.Text = ""
            LblUsuarioReporta.Text = ""
            LblPrioridad.Text = ""
            LblTema.Text = ""
            LblObservacion.Text = ""
            LblEstado.Text = ""
            LblUsuarioReg.Text = ""

            ObjHelpDesk.Prioridad = Nothing
            Consulta_Ticket()

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
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

    Private Sub dtggeneralHelpDesk_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtggeneralHelpDesk.PageIndexChanging
        Try
            dtggeneralHelpDesk.PageIndex = e.NewPageIndex
            dtggeneralHelpDesk.DataSource = Session("HelpDeskAsignacion_dtggeneralHelpdesk")
            dtggeneralHelpDesk.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

End Class