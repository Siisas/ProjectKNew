Public Class Digitacionsegvoz
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
            dtggeneral.DataSource = objdatos.consultaasignadodigitacdatosseguimvoz
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clsvoz
        Try
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el registro que desea digitar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            If rbtipo.SelectedValue = Nothing Then
                lblmsg.Text = "Confirme que el caso ha quedado digitado en AC"
                Exit Sub
            Else
                objdatos.dir = rbtipo.SelectedItem.Value
            End If
            objdatos.actualizadigitdtseguimvoz()
            casosptes()
            lblmsg.Text = "Registro ingresado con éxito"
            rbtipo.SelectedValue = Nothing
            txtcaso.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnconsultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnconsultar.Click
        Try
            Dim objdatos As New clsvoz
            objdatos.caso = txtcaso.Text
            objdatos.idusuario = lblusuario.Text
            objdatos.consultadigitarseguimvoz()
            If objdatos.cantidad > 0 Then
                lblguion.Text = "Se realizan comunicación con el usuario sin embargo no se logra establecer comunicación, última fecha de contacto: " & objdatos.fcreg
                btnguardar.Enabled = True
            Else
                lblmsg.Text = "El caso no tiene registros de seguimiento, si presenta duda consulte a un analista"
                btnguardar.Enabled = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
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