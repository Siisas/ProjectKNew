Public Class Fallamasiva
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Falla Masiva Datos"
                Dim objdatos As New clsgeneral
                cargadrl()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Protected Sub cargadrl()
        Try
            Dim objdatos As New clsgeneral
            With drltipificacionll
                .DataSource = objdatos.consultatipificacion
                .DataTextField = "tipificacion"
                .DataValueField = "idtipificacion"
                .DataBind()
            End With
            'grupo de tipificación
            With drlgrupo
                .DataSource = objdatos.consultagrupo
                .DataTextField = "grupo"
                .DataValueField = "grupo"
                .DataBind()
            End With
            objdatos.tipo = drlgrupo.SelectedItem.Value
            With drltsoporte
                .DataSource = objdatos.consultatsoportegrupo
                .DataTextField = "escenario"
                .DataValueField = "escenario"
                .DataBind()
            End With
            'divipola - dpto
            With drldpto
                objdatos.idtip = 1
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
            'variables de diagnóstico
            With drlservicio
                objdatos.idusuario = 1
                .DataSource = objdatos.consultadiagnostico
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With

            With drlpercep
                objdatos.idusuario = 3
                .DataSource = objdatos.consultadiagnostico
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
            With drlFtectolog
                objdatos.idusuario = 4
                .DataSource = objdatos.consultadiagnostico
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
            With drlvariable
                objdatos.idusuario = 6
                .DataSource = objdatos.consultadiagnostico
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
            With drlmarca
                .DataSource = objdatos.consultamarca
                .DataTextField = "marca"
                .DataValueField = "marca"
                .DataBind()
            End With
            objdatos.estado = drlmarca.SelectedItem.Value
            With drlequipo
                .DataSource = objdatos.consultaequipo
                .DataTextField = "equipo"
                .DataValueField = "equipo"
                .DataBind()
            End With
        Catch ex As Exception

            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clscrmdatos
        Try
            objdatos.inactivafallamasiva()
            If drlservicio.SelectedItem.Text = "- Seleccione -" Then
                objdatos.diagservicio = "0"
            Else
                objdatos.diagservicio = drlservicio.SelectedItem.Value
            End If
            If drlpercep.SelectedItem.Text = "- Seleccione -" Then
                objdatos.diagperep = "0"
            Else
                objdatos.diagperep = drlpercep.SelectedItem.Value
            End If
            If drlFtectolog.SelectedItem.Text = "- Seleccione -" Then
                objdatos.diagtecnolog = "0"
            Else
                objdatos.diagtecnolog = drlFtectolog.SelectedItem.Value
            End If
            If drlequipo.SelectedItem.Value = "- Seleccione -" Then
                objdatos.equipo = ""
            Else
                objdatos.equipo = drlequipo.SelectedItem.Text
            End If
            If drlvariable.SelectedItem.Text = "- Seleccione -" Then
                objdatos.diagvariable = "0"
            Else
                objdatos.diagvariable = drlvariable.SelectedItem.Value
            End If
            If drlmun.SelectedItem.Text = "- Seleccione -" Then
                objdatos.mun = "0"
            Else
                objdatos.mun = drlmun.SelectedItem.Value
            End If
            If txtbarrio.Text = "" Then
                objdatos.barrio = ""
            Else
                objdatos.barrio = txtbarrio.Text
            End If
            If drltipificacionll.SelectedItem.Value = 0 Then
                objdatos.tipificacion = ""
            Else
                objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            End If
            If drltsoporte.SelectedItem.Text = "- Seleccione -" Then
                objdatos.tiposoporte = ""
            Else
                objdatos.tiposoporte = drltsoporte.SelectedItem.Text
            End If
            If txtobs.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite la observación de la falla masiva"
                Exit Sub
            Else
                objdatos.obs = txtobs.Text
            End If

            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.registrofmasivadatos()

            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Seguimiento ingresado con éxito"
            txtobs.Text = ""
            txtbarrio.Text = ""
            lblcierre.Text = ""
            lblvariable.Text = ""
            lbltipificacion.Text = ""
            cargadrl()
            'drldpto.SelectedValue = "0"
            'dpto1()
            'grupo()
        Catch ex As Exception

            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub drlmarca_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlmarca.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.estado = drlmarca.SelectedItem.Value
            With drlequipo
                objdatos.idtip = 1
                .DataSource = objdatos.consultaequipo
                .DataTextField = "equipo"
                .DataValueField = "equipo"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try

    End Sub

    Protected Sub drlgrupo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlgrupo.SelectedIndexChanged
        Try
            grupo()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Protected Sub grupo()
        Try
            Dim objdatos As New clsgeneral
            objdatos.tipo = drlgrupo.SelectedItem.Value
            With drltsoporte
                .DataSource = objdatos.consultatsoportegrupo
                .DataTextField = "escenario"
                .DataValueField = "escenario"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
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
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub drldpto_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drldpto.SelectedIndexChanged
        Try
            dpto1()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub rdbron_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdbron.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            If rdbron.SelectedItem.Value = "Error en Registro" Then
                objdatos.idusuario = 6
                Diag.Text = "Error en Registro"
            End If
            If rdbron.SelectedItem.Value = "Ajeno a Red Celular" Then
                objdatos.idusuario = 7
                Diag.Text = "Ajeno a Red Celular"
            End If
            If rdbron.SelectedItem.Value = "Asociado Red Celular" Then
                objdatos.idusuario = 9
                Diag.Text = "Asociado Red Celular"
            End If
            With drlvariable
                .DataSource = objdatos.consultadiagnostico
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try

    End Sub

    Protected Sub drlservicio_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlservicio.SelectedIndexChanged
        Try
            Dim objdatos As New clscrmdatos
            objdatos.diagservicio = drlservicio.SelectedItem.Value
            objdatos.consultaproceso()
            lbltipificacion.Text = objdatos.tipificacion
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub drlvariable_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlvariable.SelectedIndexChanged
        Try
            Dim objdatos As New clscrmdatos
            objdatos.diagservicio = drlvariable.SelectedItem.Value
            objdatos.consultaproceso()
            lblvariable.Text = objdatos.tipificacion
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub


    Protected Sub drltsoporte_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drltsoporte.SelectedIndexChanged
        Try
            Dim objdatos As New clscrmdatos
            objdatos.tiposoporte = drltsoporte.SelectedItem.Value
            objdatos.consultacierre()
            lblcierre.Text = objdatos.tipificacion
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub chkinhab_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkinhab.CheckedChanged
        Try
            Dim objdatos As New clscrmdatos
            objdatos.inactivafallamasiva()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Actualizacíon realizada con éxito, no se encuentran fallas masivas activas"
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
End Class