Public Class Seguimasig
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                objdatos.idusuario = lblusuario.Text
                objdatos.consultared()
                lblidasig.Text = objdatos.localidad
                With drlestadoact
                    .DataSource = objdatos.consultaestado
                    .DataTextField = "descestado"
                    .DataValueField = "idestado"
                    .DataBind()
                End With
                consultagral()
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

    Protected Sub lnkseguimiento_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnkseguimiento.Click
        lnkseguimiento.ForeColor = Drawing.Color.Black
        lnkconsulta.ForeColor = Drawing.Color.Blue
        pnconsulta.Visible = False
        pnseguimiento.Visible = True
        lblmsg.Text = ""
    End Sub
    Protected Sub consultar()
        Try
            Dim objdatos As New clssolicitud
            If txtidreg.Text <> "" Then
                objdatos.idreg = txtidreg.Text
            Else
                lblmsg.Text = "Digite el número de caso a consultar"
                Exit Sub
            End If
            objdatos.idusuario = lblidasig.Text
            objdatos.consultasolicitudes()
            If objdatos.cantidad = 0 Then
                lblmsg.Text = "El caso digitado no se encuentra asignado a su usuario, verifique la información"
            Else
                dtggeneral.DataSource = objdatos.consultaseguimientos
                dtggeneral.DataBind()

                objdatos.consultasolic()
                If objdatos.cantidad > 0 Then

                    lbltipo.Text = objdatos.tiposolic
                    lblprioridad.Text = objdatos.prioridad
                    lbldescrip.Text = objdatos.obs
                    lblestado.Text = objdatos.estado
                    lblfcprobable.Text = objdatos.fcprobable
                    lblidsolic.Text = objdatos.idreg
                    hpladjunto.Text = objdatos.archivo
                    hpladjunto.NavigateUrl = "~/SolicClaro/data/" & objdatos.archivo
                Else
                    lbltipo.Text = ""
                    lblprioridad.Text = ""
                    lbldescrip.Text = ""
                    lblestado.Text = ""
                    lblfcprobable.Text = ""
                    lblidsolic.Text = ""
                    hpladjunto.Text = ""
                    hpladjunto.NavigateUrl = Nothing
                    lblmsg.Text = "No se encuentra el caso buscado"
                End If
                lblmsg.Text = ""
            End If

            

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub btnconsultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnconsultar.Click
        Try
            consultar()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardarseg_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardarseg.Click
        Try
            If lblestado.Text = "Cerrado" Then
                lblmsg.Text = "La solicitud se encuentra cerrada y no se puede generar seguimientos, si se requiere cree una nueva solicitud"
                Exit Sub
            End If
            Dim Fn As String
            Dim SaveLocation As String
            Dim objdatos As New clssolicitud
            If Fluadjuntoseg.HasFile Then
                Fn = System.IO.Path.GetFileName(Fluadjuntoseg.PostedFile.FileName)
                SaveLocation = Server.MapPath("data") & "\\" & Fn
                Fluadjuntoseg.PostedFile.SaveAs(SaveLocation)
                objdatos.archivo = Fn
            Else
                objdatos.archivo = ""
            End If
            If txtobsseg.Text = "" Then
                lblmsg.Text = "Digite la observación de atención al caso"
                Exit Sub
            Else
                objdatos.obs = txtobsseg.Text
            End If
            If drlestadoact.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Elija el estado de la solicitud"
                Exit Sub
            Else
                objdatos.estado = drlestadoact.SelectedItem.Value
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.idreg = lblidsolic.Text
            objdatos.registroseguimientokamasig()
            lblmsg.Text = "Solcitid registrada con éxito"
            consultar()
            txtobsseg.Text = ""
            lbltipo.Text = ""
            lblprioridad.Text = ""
            lbldescrip.Text = ""
            lblestado.Text = ""
            lblfcprobable.Text = ""
            lblidsolic.Text = ""
            hpladjunto.Text = ""
            hpladjunto.NavigateUrl = Nothing
            txtidreg.Text = ""
            drlestadoact.SelectedValue = 0
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub lnkconsulta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnkconsulta.Click
        lnkseguimiento.ForeColor = Drawing.Color.Blue
        lnkconsulta.ForeColor = Drawing.Color.Black
        pnconsulta.Visible = True
        pnseguimiento.Visible = False
        lblmsg.Text = ""
    End Sub
    Protected Sub consultagral()
        Try
            Dim objdatos As New clssolicitud
            objdatos.idusuario = lblidasig.Text
            dtgconsulta.DataSource = objdatos.consultasolicitudes
            dtgconsulta.DataBind()
            lblcantidad.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Private Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            consultar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub dtgconsulta_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgconsulta.PageIndexChanging
        Try
            dtgconsulta.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            consultagral()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class