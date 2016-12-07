Public Class LiberarNivel3
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
                CargaDrl()
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

    Sub CargaDrl()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.Validacion = 1
            With drlIngeniero
                .DataSource = objdatos.Consulta_NIvel3
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If drlIngeniero.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un Ingeniero de nivel tres antes de realizar la liberacion"
                Exit Sub
            End If
            Dim objdatos As New clscrmdatos
            For Each row As GridViewRow In DtgVisualizar.Rows
                objdatos.caso = CInt(row.Cells(0).Text)
                objdatos.Liberaescalanivel3()
            Next
            lblmsg.Text = "Liberacion masiva realizada con éxito"
            DtgVisualizar.DataSource = Nothing
            DtgVisualizar.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            If drlIngeniero.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un Ingeniero de nivel tres antes de realizar la consulta"
                Exit Sub
            End If
            Dim objdatos As New clscrmdatos
            objdatos.idusuarioasignado = drlIngeniero.SelectedValue
            objdatos.Validacion = 5
            DtgVisualizar.DataSource = objdatos.Consulta_NIvel3()
            DtgVisualizar.DataBind()
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
End Class