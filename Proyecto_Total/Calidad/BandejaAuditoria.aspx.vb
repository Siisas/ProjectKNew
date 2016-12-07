Public Class BandejaAuditoria
    Inherits System.Web.UI.Page
    Dim validacion As Boolean = False
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim objBandeja As New clscalidad
            Dim objvalida As New clsgeneral
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                carga()
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
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Sub carga()
        Try
            Dim objBandeja As New clscalidad
            Dim objvalida As New clsgeneral
            With DrlSupervisor
                objvalida.Validacion = "2"
                .DataSource = objvalida.Consulta_Perfiles()
                .DataTextField = "nombreu"
                .DataValueField = "Supervisor"
                .DataBind()
            End With
            With Drlturno
                objBandeja.Validacion = "5"
                .DataSource = objBandeja.UsuariosBandeja()
                .DataTextField = "turno"
                .DataValueField = "turno"
                .DataBind()
            End With
            With DrlAuditor
                objBandeja.Validacion = "4"
                .DataSource = objBandeja.UsuariosBandeja
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
            With DrlAuditor3
                objBandeja.Validacion = "4"
                .DataSource = objBandeja.UsuariosBandeja
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
            With DrlAuditor1
                objBandeja.Validacion = "4"
                .DataSource = objBandeja.UsuariosBandeja
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
            With DrlAuditorCasosManual
                objBandeja.Validacion = "4"
                .DataSource = objBandeja.UsuariosBandeja
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        Try
            DtgUsuariosAuditor.DataSource = Nothing
            DtgUsuariosAuditor.DataBind()
            DtgCasosAuditar.DataSource = Nothing
            DtgCasosAuditar.DataBind()
            DtgCasosAuditor.DataSource = Nothing
            DtgCasosAuditor.DataBind()
            LblCantidad2.Text = "0"
            Pnl2.Visible = False
            validacion = True
            consultar()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Sub consultar()
        Try
            Dim objBandeja As New clscalidad
            If validacion = True Then
                validacion = False
                If DrlSupervisor.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione el supervisor"
                    Exit Sub
                End If
            End If
            objBandeja.Validacion = "1"
            If TxtCantidad.Text <> "" Then
                objBandeja.cantidad = TxtCantidad.Text
            End If

            If Drlturno.Text <> "- Seleccione -" Then
                objBandeja.nivel = Drlturno.SelectedItem.Text
            End If
            objBandeja.Nombre = DrlSupervisor.SelectedItem.Value
            DtgUsuarios.DataSource = objBandeja.UsuariosBandeja()
            DtgUsuarios.DataBind()
            If objBandeja.cantidad > 0 Then
                DtgUsuarios.Visible = True
                Pnl1.Visible = True
            Else
                Pnl1.Visible = False
            End If
            LblCantidad.Text = objBandeja.cantidad
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub DtgUsuarios_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles DtgUsuarios.PageIndexChanging
        Try
            Dim objBandeja As New clscalidad
            DtgUsuarios.PageIndex = e.NewPageIndex
            DtgUsuarios.DataSource = objBandeja.UsuariosBandeja()
            DtgUsuarios.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Try
            Dim objBandeja As New clscalidad
            If DrlAuditor.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Debe seleccionar el auditor al cual asignara los ingenieros seleccionados"
                Exit Sub
            End If
            If DtgUsuarios.Visible = False Then
                lblmsg.Text = "Debe realizar almenos un filtro de busqueda"
                Exit Sub
            End If
            For Each row As GridViewRow In DtgUsuarios.Rows
                Dim isChecked As Boolean = (CType(row.FindControl("chkCtrl"), CheckBox)).Checked
                If isChecked = True Then
                    validacion = True
                    objBandeja.Id_Usuario = row.Cells(0).Text()
                    objBandeja.CodigoAgente = row.Cells(2).Text()
                    objBandeja.Auditor = DrlAuditor.SelectedValue
                    objBandeja.AsignarAuditor()
                End If
            Next
            If validacion = False And DtgUsuarios.Rows.Count > 0 Then
                lblmsg.Text = "Debe checkear almenos un ingeniero para realizar el registro"
                Exit Sub
            End If
            DtgUsuarios.DataSource = Nothing
            DtgUsuarios.DataBind()
            CheckSeleccionarA.Checked = False
            Pnl1.Visible = False
            carga()
            TxtCantidad.Text = ""
            LblCantidad.Text = ""
            lblmsg.Text = "Registro de asignacion exitoso"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub DrlAuditor1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DrlAuditor1.SelectedIndexChanged
        Try
            Dim objBandeja As New clscalidad
            If DrlAuditor1.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Debe seleccionar un auditor"
                Exit Sub
            End If
            objBandeja.Auditor = DrlAuditor1.SelectedValue
            objBandeja.Validacion = "6"
            DtgUsuariosAuditor.DataSource = objBandeja.UsuariosBandeja()
            DtgUsuariosAuditor.DataBind()
            If objBandeja.cantidad > 0 Then
                lblmsg.Text = ""
                LblCantidad2.Text = objBandeja.cantidad
                Pnl2.Visible = True
                Pnl1.Visible = False
                DtgUsuarios.DataSource = Nothing
                DtgUsuarios.DataBind()
                DtgCasosAuditar.DataSource = Nothing
                DtgCasosAuditar.DataBind()
                LblCantidad.Text = "0"
                DtgUsuariosAuditor.Visible = True
            End If
            If objBandeja.cantidad = 0 Then
                lblmsg.Text = "No tiene asignados auditores"
                Pnl2.Visible = False
                DtgUsuarios.DataSource = Nothing
                DtgUsuarios.DataBind()
                DtgCasosAuditar.DataSource = Nothing
                DtgCasosAuditar.DataBind()
                Pnl1.Visible = False
                LblCantidad2.Text = "0"
                DtgUsuariosAuditor.Visible = False
                LblCantidad2.Text = "0"
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub BtnConsultaMasiva_Click(sender As Object, e As EventArgs) Handles BtnConsultaMasiva.Click
        Try
            DtgUsuarios.DataSource = Nothing
            DtgUsuarios.DataBind()
            DtgCasosAuditar.DataSource = Nothing
            DtgCasosAuditar.DataBind()
            DtgCasosAuditor.DataSource = Nothing
            DtgCasosAuditor.DataBind()
            LblCantidad.Text = "0"
            Pnl1.Visible = False
            Dim objBandeja As New clscalidad
            objBandeja.Validacion = "7"
            DtgUsuariosAuditor.DataSource = objBandeja.UsuariosBandeja()
            DtgUsuariosAuditor.DataBind()
            If objBandeja.cantidad > 0 Then
                LblCantidad2.Text = objBandeja.cantidad
                Pnl2.Visible = True
                DtgUsuariosAuditor.Visible = True
            End If
            If objBandeja.cantidad = 0 Then
                Pnl2.Visible = False
                DtgUsuariosAuditor.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub BtnLiberarA_Click(sender As Object, e As EventArgs) Handles BtnLiberarA.Click
        Try

            Dim objBandeja As New clscalidad
            For Each row As GridViewRow In DtgUsuariosAuditor.Rows
                Dim isChecked As Boolean = (CType(row.FindControl("chkCtrllib"), CheckBox)).Checked
                If isChecked = True Then
                    validacion = True
                    objBandeja.Id_Usuario = row.Cells(0).Text()
                    objBandeja.CodigoAgente = row.Cells(3).Text()
                    objBandeja.LiberarAuditor()
                End If
            Next
            If validacion = False And DtgUsuariosAuditor.Rows.Count > 0 Then
                lblmsg.Text = "Debe checkear almenos un ingeniero para realizar el registro"
                Exit Sub
            End If
            If validacion = True Then
                lblmsg.Text = "Se liberaron  los ingenieros seleccionados, exitosamente"
                DtgUsuariosAuditor.DataSource = Nothing
                DtgUsuariosAuditor.DataBind()
                CheckSeleccionar.Checked = False
                LblCantidad2.Text = ""
                Pnl2.Visible = False
                carga()
            Else
                lblmsg.Text = "Debe realizar un filtro de busqueda"
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub BtnRegistrarCaso_Click(sender As Object, e As EventArgs) Handles BtnRegistrarCaso.Click
        Try
            If LblIdcrm.Text = "" Then
                lblmsg.Text = "Debe ingresar el caso para a asignar"
                Exit Sub
            End If
            If DrlAuditor3.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Debe seleccionar el auditor para el caso "
                Exit Sub
            End If
            Dim objBandeja As New clscalidad

            objBandeja.Auditor = DrlAuditor3.SelectedValue
            objBandeja.caso = LblIdcrm.Text
            objBandeja.Campania = LblBandeja.Text
            objBandeja.Id_Caso = LblCaso.Text
            objBandeja.Id_Usuario = lblusuario.Text
            objBandeja.agente = LblIngeniero.Text
            objBandeja.Validacion = 19
            If objBandeja.UsuariosBandeja.Tables(0).Rows.Count > 0 Then
                lblmsg.Text = "El codigo de gestion " + objBandeja.caso + " ya se encuentra asignado"
                Exit Sub
            End If
            objBandeja.Validacion = 18
            If objBandeja.UsuariosBandeja.Tables(0).Rows.Count > 0 Then
                objBandeja.IngresarAuditoria()
            Else
                lblmsg.Text = "El codigo de gestion " + objBandeja.caso + " no existe"
                Exit Sub
            End If
            TxtCodigoCaso.Text = ""
            LblIdcrm.Text = ""
            LblBandeja.Text = ""
            LblIngeniero.Text = ""
            LblCaso.Text = ""
            BtnRegistrarCaso.Visible = False
            carga()
            DtgCasosAuditar.DataSource = Nothing
            DtgCasosAuditar.DataBind()
            lblmsg.Text = "Registro Exitoso"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub BtnActualizarM_Click(sender As Object, e As EventArgs) Handles BtnActualizarM.Click
        Try
            If TxtMeta.Text = "" Then
                lblmsg.Text = "Ingrese una valor para fijar la meta "
                Exit Sub
            End If
            Dim objBandeja As New clscalidad
            objBandeja.cantidad = TxtMeta.Text
            objBandeja.ActualizarMeta()
            lblmsg.Text = "Registro Exitoso"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            BtnRegistrarCaso.Visible = False
            consultarCasoAsignar()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Sub consultarCasoAsignar()
        Try

            DtgUsuarios.DataSource = Nothing
            DtgUsuarios.DataBind()
            DtgUsuariosAuditor.DataSource = Nothing
            DtgUsuariosAuditor.DataBind()
            DtgCasosAuditor.DataSource = Nothing
            DtgCasosAuditor.DataBind()
            LblCantidad2.Text = "0"
            Pnl1.Visible = False
            Pnl2.Visible = False
            If TxtCodigoCaso.Text = "" Then
                lblmsg.Text = "Debe ingresar el caso para consultar"
                Exit Sub
            End If
            Dim objBandeja As New clscalidad
            lblmsg.Text = ""
            objBandeja.caso = TxtCodigoCaso.Text
            objBandeja.Validacion = "17"
            DtgCasosAuditar.DataSource = objBandeja.UsuariosBandeja()
            If objBandeja.cantidad = 0 Then
                lblmsg.Text = "No existe el caso" + objBandeja.caso + ""
            End If
            DtgCasosAuditar.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub CheckSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckSeleccionar.CheckedChanged
        Try
            If CheckSeleccionar.Checked = True Then
                For Each row As GridViewRow In DtgUsuariosAuditor.Rows
                    CType(row.FindControl("chkCtrllib"), CheckBox).Checked = True
                Next
            Else
                For Each row As GridViewRow In DtgUsuariosAuditor.Rows
                    CType(row.FindControl("chkCtrllib"), CheckBox).Checked = False
                Next
            End If


        Catch ex As Exception
            lblmsg.Text = "Se presento error" & ex.Message
        End Try

    End Sub
    Protected Sub CheckSeleccionarA_CheckedChanged(sender As Object, e As EventArgs) Handles CheckSeleccionarA.CheckedChanged
        Try
            If CheckSeleccionarA.Checked = True Then
                For Each row As GridViewRow In DtgUsuarios.Rows
                    CType(row.FindControl("chkCtrl"), CheckBox).Checked = True
                Next
            Else
                For Each row As GridViewRow In DtgUsuarios.Rows
                    CType(row.FindControl("chkCtrl"), CheckBox).Checked = False
                Next
            End If


        Catch ex As Exception
            lblmsg.Text = "Se presento error" & ex.Message
        End Try
    End Sub

    Protected Sub DtgCasosAuditar_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles DtgCasosAuditar.RowCommand
        Try
            'Mediante este codigo envio la identificacion del aspirante, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Seleccion" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                LblIdcrm.Text = DtgCasosAuditar.Rows(index).Cells(0).Text
                LblCaso.Text = DtgCasosAuditar.Rows(index).Cells(1).Text
                LblIngeniero.Text = DtgCasosAuditar.Rows(index).Cells(2).Text
                LblBandeja.Text = DtgCasosAuditar.Rows(index).Cells(3).Text
                BtnRegistrarCaso.Visible = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub DtgCasosAuditar_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles DtgCasosAuditar.PageIndexChanging
        Try
            DtgCasosAuditar.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            consultarCasoAsignar()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try

    End Sub
    Protected Sub BtnConsultarCasosAuditor_Click(sender As Object, e As EventArgs) Handles BtnConsultarCasosAuditor.Click
        Try
            ConsultaAuditorias()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub ConsultaAuditorias()
        Try
            Pnl2.Visible = False
            Pnl1.Visible = False
            DtgCasosAuditar.DataSource = Nothing
            DtgCasosAuditar.DataBind()
            DtgUsuarios.DataSource = Nothing
            DtgUsuarios.DataBind()
            DtgUsuariosAuditor.DataSource = Nothing
            DtgUsuariosAuditor.DataBind()
            Dim objBandeja As New clscalidad
            If DrlAuditorCasosManual.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el auditor para consultar auditorias asignadas"
                Exit Sub
            End If
            lblmsg.Text = ""
            objBandeja.Auditor = DrlAuditorCasosManual.SelectedValue
            objBandeja.Validacion = "11"
            DtgCasosAuditor.DataSource = objBandeja.UsuariosBandeja
            DtgCasosAuditor.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
     Protected Sub DtgCasosAuditor_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles DtgCasosAuditor.RowCommand
        Try
            Dim objBandeja As New clscalidad
            'Mediante este codigo envio la identificacion del aspirante, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Seleccion" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                objBandeja.caso = DtgCasosAuditor.Rows(index).Cells(0).Text
            End If
            objBandeja.Id_Usuario = lblusuario.Text
            objBandeja.Validacion = "1"
            objBandeja.IngresarAuditoria()
            ConsultaAuditorias()
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
End Class