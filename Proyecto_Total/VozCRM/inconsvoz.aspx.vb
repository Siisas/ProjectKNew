Public Class inconsvoz
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
            dtggeneral.DataSource = objdatos.consultainconsvoz
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad

            dtgaprobado.DataSource = objdatos.consultaaprobadovoz
            dtgaprobado.DataBind()
            lblcuentaaprob.Text = objdatos.cantidad
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
            Dim Obj_clsdatos As New clscrmdatos
            Obj_clsdatos.idusuario = lblusuario.Text
            Obj_clsdatos.Consulta_Sin_Restriccion_Envio_Inconsistencia()
            If Obj_clsdatos.cantidad < 1 Or Obj_clsdatos.cantidad = Nothing Then
                objdatos.consultainconsvoz()
            Else
                objdatos.cantidad = 1
            End If
            If objdatos.cantidad > 0 Then
                If drlestado.SelectedItem.Value = "0" Then
                    lblmsg.Text = "Elija la tipificación de revisión de la inconsistencia"
                    Exit Sub
                Else
                    objdatos.tipificacion = drlestado.SelectedItem.Value
                End If
                objdatos.idusuario = lblusuario.Text
                objdatos.actualizaincvoz()
                casosptes()
                lblmsg.Text = "Registro ingresado con éxito"
                drlestado.SelectedValue = 0
                txtcaso.Text = ""
            Else
                lblmsg.Text = "El caso " + txtcaso.Text + " no se encuentra como Reportado por favor verifique que este cargando en la tabla"
                Exit Sub
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton3.Click
        Try
            Pnenvio.Visible = False
            Pnrev.Visible = True
            dtgaprobado.Visible = False
            dtggeneral.Visible = True
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton4.Click
        Pnenvio.Visible = True
        Pnrev.Visible = False
        dtgaprobado.Visible = True
        dtggeneral.Visible = False
    End Sub

    Protected Sub btnguardar0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar0.Click
        Dim actualizar As New clsvoz
        Try
            actualizar.idusuario = lblusuario.Text
            For Each row As GridViewRow In dtgaprobado.Rows
                actualizar.caso = Int64.Parse(row.Cells(0).Text)
                actualizar.envioincvoz()
            Next
            lblmsg.Text = "Envio realizado con éxito"
            dtgaprobado.DataSource = Nothing
            dtgaprobado.DataBind()
            casosptes()
        Catch ex As Exception
            Me.lblmsg.Text = "se ha producido un error:" & ex.Message
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

    Private Sub dtgaprobado_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgaprobado.PageIndexChanging
        Try
            dtgaprobado.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            casosptes()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub dtgaprobado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtgaprobado.SelectedIndexChanged

    End Sub
End Class