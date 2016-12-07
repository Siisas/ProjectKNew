Public Partial Class Regbitacora
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                With drlproyecto
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultaproyecto
                    .DataTextField = "nombreproyecto"
                    .DataValueField = "idproyecto"
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
        Dim objdatos As New clsbitacora
        Try
            If txtfcbitacora.Text = "" Then
                lblmsg.Text = "Digite la fecha de la acción de Bitácora"
                Exit Sub
            Else
                If Convert.ToDateTime(txtfcbitacora.Text) > Today Then
                    lblmsg.Text = "La fecha de bitácora no puede ser mayor que hoy"
                    Exit Sub
                Else
                    objdatos.fcbitacora = Convert.ToDateTime(txtfcbitacora.Text)
                End If
            End If
            If drlproyecto.SelectedItem.Value = 0 Then
                lblmsg.Text = "Seleccione el proyecto trabajado"
                Exit Sub
            Else
                objdatos.proyecto = drlproyecto.SelectedItem.Value
            End If
            If txthhinicio.Text = "" Then
                lblmsg.Text = "Digite la hora de inicio de la actividad"
                Exit Sub
            Else
                objdatos.hhinicio = txthhinicio.Text
            End If
            If txttiempo.Text = "" Then
                lblmsg.Text = "Digite el tiempo en horas empleado en el proyecto"
                Exit Sub
            Else
                objdatos.tiempo = txttiempo.Text
            End If
            If txtdescrip.Text = "" Then
                lblmsg.Text = "Digite la descripciòn de las actividades desarrolladas"
                Exit Sub
            Else
                objdatos.descripcion = txtdescrip.Text
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.registrobitac()
            buscarinf()
            txtfcbitacora.Text = ""
            txtdescrip.Text = ""
            drlproyecto.SelectedValue = 0
            txthhinicio.Text = ""
            txttiempo.Text = ""
            lblmsg.Text = "Bitácora ingresada con éxito"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub buscarinf()
        Dim objdatos As New clsbitacora
        If lblusuario.Text <> "" Then
            objdatos.idusuario = lblusuario.Text
            dtggeneral.DataSource = objdatos.consultabitacora
            dtggeneral.DataBind()
        End If
        lblmsg.Text = ""
    End Sub
End Class