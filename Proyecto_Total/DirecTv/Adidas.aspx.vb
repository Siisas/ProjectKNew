Public Class Adidas
    Inherits System.Web.UI.Page
    Dim obj_Adidas As New clsAdidas
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                Cargar_drl()
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
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Sub Cargar_drl()
        With drltipificación
            drltipificación.DataSource = obj_Adidas.Consulta_tip
            drltipificación.DataTextField = "Nombre"
            drltipificación.DataValueField = "Nombre"
            drltipificación.DataBind()
        End With
    End Sub


    Protected Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Try
            If Txt_Tarjeta.Text = "" Then
                lblmsg.Text = "Ingrese el numero de La Tarjeta"
                Exit Sub
            End If
            If Txt_telefono.Text = "" Then
                lblmsg.Text = "Ingrese el numero de Telefono "
                Exit Sub
            End If

            
            If drltipificación.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una Tipificacion"
                Exit Sub
            End If

            If TxtFechaInicio.Text = "" And drltipificación.SelectedItem.Text = "Efectivo" Then
                lblmsg.Text = "Ingrese La Fecha de Nacimiento"
                Exit Sub
            End If

            If drltipificación.SelectedValue <> "Efectivo" And Txt_Observacion.Text = "" Then
                lblmsg.Text = "Ingrese una Observacion"
                Exit Sub
            End If

            obj_Adidas.Tarjeta = Txt_Tarjeta.Text
            obj_Adidas.Telefono = Txt_telefono.Text
            If TxtFechaInicio.Text <> "" Then
                obj_Adidas.Fc_Nacimiento = TxtFechaInicio.Text
            End If
            obj_Adidas.Tipificacion = drltipificación.SelectedValue
            obj_Adidas.Observacion = Txt_Observacion.Text
            obj_Adidas.Usuario = lblusuario.Text


            obj_Adidas.registro_tarjeta()
            lblmsg.Text = "Registro Exitoso"

            Txt_Tarjeta.Text = ""
            Txt_telefono.Text = ""
            TxtFechaInicio.Text = ""
            drltipificación.SelectedValue = "- Seleccione -"
            Txt_Observacion.Text = ""


        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drltipificación_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drltipificación.SelectedIndexChanged
        Try
            If drltipificación.Text <> "Efectivo" Then
                Txt_Observacion.Enabled = True
                TxtFechaInicio.Enabled = False
                TxtFechaInicio.Text = ""
            Else
                Txt_Observacion.Enabled = False
                TxtFechaInicio.Enabled = True
                Txt_Observacion.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
End Class