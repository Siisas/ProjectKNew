Public Class nuevoformato
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                casosptes()
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
            Dim objdatos As New clsvoz
            objdatos.idusuario = lblusuario.Text
            If txtcaso.Text <> Nothing Then
                objdatos.caso = txtcaso.Text
            End If
            dtggeneral.DataSource = objdatos.consultanuevoformato
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
            If objdatos.cantidad > 0 Then
                lblmesa.Text = objdatos.mesa
                lblusuariosolic.Text = objdatos.idusuario
                lblmin.Text = objdatos.min
            Else
                lblmesa.Text = ""
                lblusuariosolic.Text = ""
                lblmin.Text = ""
            End If

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clsvoz
        Try
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            If txtcpd.Text = "" Then
                lblmsg.Text = "Digite el consecutivo asignado para el nuevo caso"
                Exit Sub
            Else
                objdatos.tickler = txtcpd.Text
            End If
            If txtobs.Text = "" Then
                objdatos.obs = ""
            Else
                objdatos.obs = txtobs.Text
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.actualizanuevocaso()
            lblmsg.Text = "Caso creado con éxito"
            txtcpd.Text = ""
            txtcaso.Text = ""
            txtobs.Text = ""
            casosptes()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnbusca_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnbusca.Click
        casosptes()
    End Sub

    Private Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            casosptes()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class