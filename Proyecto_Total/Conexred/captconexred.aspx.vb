Public Class captconexred
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                With drltipificacionll
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultatipificacionconexred
                    .DataTextField = "tipificacion"
                    .DataValueField = "idtipificacion"
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

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clscrmdatos
        Try
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            If drltipificacionll.SelectedItem.Value = 0 Then
                lblmsg.Text = "Seleccione la tipificación de la llamada"
                Exit Sub
            Else
                objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            End If
            If txtobs.Text = "" Then
                lblmsg.Text = "Digite la observación de atención al caso"
                Exit Sub
            Else
                objdatos.obs = txtobs.Text
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.registroconexred()
            buscarinf()
            lblmsg.Text = "Seguimiento ingresado con éxito"
            txtcaso.Text = ""
            txtobs.Text = ""
            drltipificacionll.SelectedValue = 0
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Sub buscarinf()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el Caso o Min que desea consultar"
            Else
                If txtcaso.Text <> "" Then
                    objdatos.caso = txtcaso.Text
                End If
                dtggeneral.DataSource = objdatos.consultacasoconexred
                dtggeneral.DataBind()
                lblcuenta.Text = objdatos.cantidad
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar0.Click
        buscarinf()
    End Sub
End Class