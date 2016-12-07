Public Class AsignacionNivel3
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
                asignado()
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

    Protected Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim objdatos As New clscrmdatos
            If TxtCantidad.Text = "" Then
                lblmsg.Text = "Digite la cantidad de casos que desea asignar"
                Exit Sub
            Else
                objdatos.cantidad = TxtCantidad.Text
                objdatos.Validacion = 2
                DtgVisualizar.DataSource = objdatos.Consulta_NIvel3()
                DtgVisualizar.DataBind()
                lblCantidad.Text = objdatos.cantidad
                lblmsg.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub CargaDrl()
        Dim objdatos As New clscrmdatos
        objdatos.Validacion = 1
        With drlIngeniero
            .DataSource = objdatos.Consulta_NIvel3
            .DataTextField = "nombreu"
            .DataValueField = "idusuario"
            .DataBind()
        End With
    End Sub

    Protected Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim actualizar As New clscrmdatos
        Try
            If drlIngeniero.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un Ingeniero de nivel tres antes de realizar la asignación"
                Exit Sub
            End If
            actualizar.idusuarioasignado = drlIngeniero.SelectedItem.Value
            actualizar.idusuario = lblusuario.Text
            If txtcaso.Text <> Nothing Then
                actualizar.caso = txtcaso.Text
                actualizar.asignaescalanivel3()
                txtcaso.Text = ""
                lblmsg.Text = "Asignación individual realizada con éxito"
            Else
                For Each row As GridViewRow In DtgVisualizar.Rows
                    actualizar.caso = CInt(row.Cells(0).Text)
                    actualizar.asignaescalanivel3()
                Next
                lblmsg.Text = "Asignación masiva realizada con éxito"
            End If
            DtgVisualizar.DataSource = Nothing
            DtgVisualizar.DataBind()
            lblCantidad.Text = ""
            TxtCantidad.Text = ""
            asignado()
        Catch ex As Exception
            Me.lblmsg.Text = "se ha producido un error:" & ex.Message
        End Try
    End Sub
    Protected Sub asignado()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.cantidad = "10000"
            objdatos.Validacion = 2
            objdatos.Consulta_NIvel3()
            lblCantidad.Text = objdatos.cantidad

            objdatos.Validacion = 4
            DtgAsigado.DataSource = objdatos.Consulta_NIvel3()
            DtgAsigado.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

End Class