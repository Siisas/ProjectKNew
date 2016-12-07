Public Class modsuperv
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
                    .DataSource = objdatos.consultatipificacion
                    .DataTextField = "tipificacion"
                    .DataValueField = "idtipificacion"
                    .DataBind()
                End With
                'grupo de tipificación
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
            objdatos.tiposoporte = "0"
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
            objdatos.telalt = ""
            objdatos.preg1 = "0"
            objdatos.idusuario = lblusuario.Text
            objdatos.registrocrm()
            actbandeja()
            buscarinf()
            lblmsg.Text = "Seguimiento ingresado con éxito"
            lblcliente.Text = ""
            lbldocumento.Text = ""
            lblmin.Text = ""
            lblplan.Text = ""
            lblequipo.Text = ""
            lbllugar.Text = ""
            lblemail.Text = ""
            lblcaso.Text = ""
            lblobs611.Text = ""
            lblestado.Text = ""
            txtcaso.Text = ""
            txtobs.Text = ""
          
            drltipificacionll.SelectedValue = 0
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub actbandeja()
        Try
            Dim objdatos As New clscrmdatos
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
            objdatos.modificarbandejasup()
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
                dtggeneral.DataSource = objdatos.consultacaso
                dtggeneral.DataBind()
                lblcuenta.Text = objdatos.cantidad
                If objdatos.cantidad > 0 Then
                    lblcliente.Text = objdatos.cliente
                    lbldocumento.Text = objdatos.documento
                    lblmin.Text = objdatos.min
                    lblplan.Text = objdatos.plan
                    lblequipo.Text = objdatos.equipo
                    lbllugar.Text = objdatos.lugar
                    lblemail.Text = objdatos.email
                    lblcaso.Text = objdatos.caso
                    lblobs611.Text = objdatos.obsini
                    lblestado.Text = objdatos.tipificacion
                    If txtcaso.Text = "" Then
                        txtcaso.Text = objdatos.caso
                    End If
                    lblmsg.Text = ""
                Else
                    lblcliente.Text = ""
                    lbldocumento.Text = ""
                    lblmin.Text = ""
                    lblplan.Text = ""
                    lblequipo.Text = ""
                    lbllugar.Text = ""
                    lblemail.Text = ""
                    lblcaso.Text = ""
                    lblobs611.Text = ""
                    lblestado.Text = ""
                    lblmsg.Text = "No se han encontrado registros coincidentes"
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        buscarinf()
    End Sub
End Class