Public Class Asignafallatec1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                asignado()
                objdatos.nombre = 1
                With drlusuario
                    .DataSource = objdatos.consultadigitador
                    .DataTextField = "nombreu"
                    .DataValueField = "idusuario"
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
    Private Sub asignado()
        Try
            Dim objdatos As New clsvoz
            dtgestad.DataSource = objdatos.enprocesofallatec
            dtgestad.DataBind()
            objdatos.idusuario = lblusuario.Text
            objdatos.pteasignacionfallatec()
            lblcantidadtot.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim actualizar As New clsvoz
        Try
            actualizar.idusuario = Me.drlusuario.SelectedItem.Value
            actualizar.idusuarioasignado = lblusuario.Text
            If txtcaso.Text <> Nothing Then
                actualizar.caso = txtcaso.Text
                actualizar.asignacasofallatec()
                txtcaso.Text = ""
                lblmsg.Text = "Asignación individual realizada con éxito"
            Else
                For Each row As GridViewRow In dtggeneral.Rows
                    actualizar.caso = CInt(row.Cells(0).Text)
                    actualizar.asignacasofallatec()
                Next
                lblmsg.Text = "Asignación masiva realizada con éxito"
            End If
            dtggeneral.DataSource = Nothing
            dtggeneral.DataBind()
            lblcantidad.Text = ""
            asignado()
        Catch ex As Exception
            Me.lblmsg.Text = "se ha producido un error:" & ex.Message
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            busca()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Private Sub busca()
        Try
            Dim objdatos As New clsvoz
            If txtcantidad.Text = "" Then
                lblmsg.Text = "Digite la cantidad de casos que desea asignar"
                Exit Sub
            Else
                objdatos.cantidad = txtcantidad.Text
                objdatos.idusuario = lblusuario.Text
                dtggeneral.DataSource = objdatos.consultapteasignarfallatec
                dtggeneral.DataBind()
                lblcantidad.Text = objdatos.cantidad
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Private Sub dtgestad_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgestad.PageIndexChanging
        Try
            dtgestad.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            asignado()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class