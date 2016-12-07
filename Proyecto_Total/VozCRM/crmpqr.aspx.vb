Public Class crmpqr
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                'cons tipificacion llamada
                With drltipificacionll
                    .DataSource = objdatos.consultatipificapqr
                    .DataTextField = "tipificacion"
                    .DataValueField = "tipificacion"
                    .DataBind()
                End With
                'cons tipo falla
                objdatos.tipo = drltipificacionll.SelectedItem.Text
                With drltfalla
                    .DataSource = objdatos.tipofallapqr
                    .DataTextField = "tipofalla"
                    .DataValueField = "id"
                    .DataBind()
                End With
                'cons tiposoporte
                objdatos.tipo = drlareafalla.SelectedItem.Text
                With drlsoporte
                    .DataSource = objdatos.constiposoporte
                    .DataTextField = "tiposoporte"
                    .DataValueField = "id"
                    .DataBind()
                End With
                'divipola - dpto
                With drldpto
                    .DataSource = objdatos.consultadpto
                    .DataTextField = "nombredpto"
                    .DataValueField = "coddpto"
                    .DataBind()
                End With
                objdatos.dpto = drldpto.SelectedItem.Value
                With drlmun
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultamun
                    .DataTextField = "nombremun"
                    .DataValueField = "coddiv"
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
        'pendiente
        Dim objdatos As New clscrmdatos
        Try
            If lblcaso.Text = "" Then
                lblmsg.Text = "Antes de guardar de clic en el botón buscar para verificar que el caso es válido"
                Exit Sub
            End If
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            If drltipificacionll.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Elija la tipificación de gestión"
                Exit Sub
            End If
            If drltfalla.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el tipo de falla presentado"
                Exit Sub
            Else
                objdatos.tipificacion = drltfalla.SelectedItem.Value
            End If
            If drlsoporte.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Elija el tipo de soporte brindado"
                Exit Sub
            Else
                objdatos.tiposoporte = drlsoporte.SelectedItem.Value
            End If
            If txtobs.Text = "" Then
                lblmsg.Text = "Digite la observación de atención al caso"
                Exit Sub
            Else
                objdatos.obs = txtobs.Text
            End If
            If txtdir.Text = "" Then
                lblmsg.Text = "Digite la dirección donde se presenta la falla"
                Exit Sub
            Else
                objdatos.dir = txtdir.Text
            End If
            If drlmun.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Elija el Municipio de la falla"
                Exit Sub
            Else
                objdatos.mun = drlmun.SelectedItem.Value
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.registrocrmpqr()
            actbandeja()
            buscarinf()
            lblmsg.Text = "Seguimiento ingresado con éxito"
            lblcliente.Text = ""
            lbltickler.Text = ""
            lblmin.Text = ""
            lblfcsap.Text = ""
            lblcaso.Text = ""
            lblestado.Text = ""
            txtcaso.Text = ""
            txtobs.Text = ""
            txtdir.Text = ""
            drlareafalla.SelectedValue = "- Seleccione -"
            drltipificacionll.SelectedValue = "- Seleccione -"
            drldpto.SelectedValue = 0
            dpto1()
            tipif()
            tiposoporte()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub actbandeja()
        'pendiente
        Try
            Dim objdatos As New clscrmdatos
            objdatos.caso = txtcaso.Text
            objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            objdatos.modificarbandejapqr()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub buscarinf()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el Caso que desea consultar"
            Else
                objdatos.caso = txtcaso.Text
                dtggeneral.DataSource = objdatos.consultacasopqr
                dtggeneral.DataBind()
                lblcuenta.Text = objdatos.cantidad
                If objdatos.cantidad > 0 Then
                    lblcliente.Text = objdatos.cliente
                    lblmin.Text = objdatos.min
                    lbltickler.Text = objdatos.tickler
                    lblfcsap.Text = objdatos.fcsap
                    lblcaso.Text = objdatos.caso
                    lblestado.Text = objdatos.tipificacion
                    If txtcaso.Text = "" Then
                        txtcaso.Text = objdatos.caso
                    End If
                    lblmsg.Text = ""
                    If lblmin.Text <> "" Then
                        objdatos.min = lblmin.Text
                        dtgcoincidentes.DataSource = objdatos.casosasociadospqr
                        dtgcoincidentes.DataBind()
                        lblcuenta1.Text = objdatos.cantidad
                    End If
                Else
                    lblcliente.Text = ""
                    lbltickler.Text = ""
                    lblmin.Text = ""
                    lblfcsap.Text = ""
                    lblcaso.Text = ""
                    lblestado.Text = ""
                    lblmsg.Text = "No se han encontrado registros coincidentes"
                    dtgcoincidentes.DataSource = Nothing
                    dtgcoincidentes.DataBind()
                    lblcuenta1.Text = 0
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            Dim objdatos As New clscrmdatos
            buscarinf()
            If txtcaso.Text <> "" Then
                objdatos.caso = txtcaso.Text
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.registroconsultacaso()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub lnk1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnk1.Click
        dtggeneral.Visible = True
        dtgcoincidentes.Visible = False
    End Sub

    Protected Sub LinkButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton2.Click
        dtggeneral.Visible = False
        dtgcoincidentes.Visible = True
    End Sub

    Protected Sub drltipificacionll_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drltipificacionll.SelectedIndexChanged
        Try
            tipif()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub tipif()
        Try
            Dim objdatos As New clsgeneral
            objdatos.tipo = drltipificacionll.SelectedItem.Text
            With drltfalla
                .DataSource = objdatos.tipofallapqr
                .DataTextField = "tipofalla"
                .DataValueField = "id"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub drldpto_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drldpto.SelectedIndexChanged
        Try
            dpto1()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub dpto1()
        Try
            Dim objdatos As New clsgeneral
            'divipola - dpto
            objdatos.dpto = drldpto.SelectedItem.Value
            With drlmun
                objdatos.idtip = 1
                .DataSource = objdatos.consultamun
                .DataTextField = "nombremun"
                .DataValueField = "coddiv"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub tiposoporte()
        Try
            Dim objdatos As New clsgeneral
           objdatos.tipo = drlareafalla.SelectedItem.Value
            With drlsoporte
                .DataSource = objdatos.constiposoporte
                .DataTextField = "tiposoporte"
                .DataValueField = "id"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub drlareafalla_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlareafalla.SelectedIndexChanged
        Try
            tiposoporte()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
End Class