Public Class procesofallatec
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                casosptes()
                Dim objdatos2 As New clscrmdatos
                With drltipificacionll
                    objdatos2.Validacion = "FallaTec_Estado_Ges_D"
                    .DataSource = objdatos2.pteasignacionfallatec()
                    .DataValueField = "Nombre"
                    .DataTextField = "Nombre"
                    .DataBind()
                End With
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
    Protected Sub casosptes()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.idusuario = lblusuario.Text
            dtggeneral.DataSource = objdatos.consultaasigxusufallatec
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clscrmdatos
        Try
            If dtggeneral.Rows.Count < 1 Then
                lblmsg.Text = "No tiene casos aignados para realizar gestion"
                Exit Sub
            End If
            If txtcaso.Text = "" Or LblCaso_Gestion.Text = "" Then
                lblmsg.Text = "Seleccione el caso que desea gestionar"
                Exit Sub
            End If
            If InStr(1, txtcaso.Text, " ") Then
                lblmsg.Text = "En la caja de texto caso no pueden existir espacios verifique!!"
                Exit Sub
            End If
            objdatos.caso = txtcaso.Text
            objdatos.idcrm = LblCaso_Gestion.Text
            If drltipificacionll.Text = "- Seleccione -" Or drltipificacionll.Text = "" Then
                lblmsg.Text = "Elija el tipo de gestión realizada sobre el fallatec"
                Exit Sub
            Else
                objdatos.dir = drltipificacionll.SelectedItem.Value
            End If
            If TxtObs.Text = "" Then
                lblmsg.Text = "Ingrese una observacion para este caso"
                Exit Sub
            Else
                objdatos.obs = TxtObs.Text
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.Gestion_Fallatec()
            objdatos.actualizafallatec()
            casosptes()
            lblmsg.Text = "Registro ingresado con éxito"
            drltipificacionll.SelectedValue = "- Seleccione -"
            objdatos.caso = txtcaso.Text
            dtg_Gestion_FallaTec.DataSource = objdatos.Consulta_Gestion_Falla_Tec
            dtg_Gestion_FallaTec.DataBind()
            LblCuentaGestion.Text = objdatos.cantidad
            txtcaso.Text = ""
            LblCaso_Gestion.Text = ""
            TxtObs.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            casosptes()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub dtggeneral_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtggeneral.RowCommand
        Try
            Dim objdatos As New clscrmdatos
            'Mediante este codigo envio la identificacion del aspirante, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Seleccion" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                LblCaso_Gestion.Text = dtggeneral.Rows(index).Cells(1).Text
                txtcaso.Text = dtggeneral.Rows(index).Cells(2).Text
                objdatos.caso = txtcaso.Text
                dtg_Gestion_FallaTec.DataSource = objdatos.Consulta_Gestion_Falla_Tec
                dtg_Gestion_FallaTec.DataBind()
                LblCuentaGestion.Text = objdatos.cantidad
                lblmsg.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
End Class