Public Class TiendaVirtual
    Inherits System.Web.UI.Page
    Dim ObjVoz As New clsvoz

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                Cargardrl()
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

    Public Sub Cargardrl()
        Try
            With drlTipificacion
                .DataSource = ObjVoz.Consulta_Tipificacion_TiendaVirtual
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnConsulta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsulta.Click
        Try
            If TxtId.Text = "" Then
                lblmsg.Text = "Ingrese in ID de consulta"
                Exit Sub
            End If
            ObjVoz.caso = TxtId.Text
            ObjVoz.Consulta_Bandeja_TiendaVirtual()

            If ObjVoz.cantidad > 0 Then
                TxtNombre.Text = ObjVoz.Nombre
                lblId.Text = ObjVoz.caso
                TxtFcFormato_Tickler.Text = ObjVoz.fcini3
                TxtFcIniGestion.Text = ObjVoz.fcini
                TxtFcFinGestion.Text = ObjVoz.fcfin
                Txtobs.Text = ObjVoz.obs
                btnguardar.Visible = False
                BtnActualizar.Visible = True
                lblmsg.Text = ""
            Else
                lblmsg.Text = "No se encontraron registros con el ID: " + TxtId.Text
                TxtNombre.Text = ""
                lblId.Text = ""
                TxtFcFormato_Tickler.Text = ""
                TxtFcIniGestion.Text = ""
                TxtFcFinGestion.Text = ""
                Txtobs.Text = ""
                btnguardar.Visible = True
                BtnActualizar.Visible = False
                Cargardrl()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Try
            If TxtNombre.Text = "" Then
                lblmsg.Text = "Ingrese un nombre antes de realizar el registro"
                Exit Sub
            End If
            If Txtobs.Text = "" Then
                lblmsg.Text = "Ingrese una observacion antes de realizar un registro"
                Exit Sub
            End If
            If TxtFcFormato_Tickler.Text <> "" Then
                ObjVoz.fcini3 = TxtFcFormato_Tickler.Text
            Else
                ObjVoz.fcini3 = ""
            End If
            If TxtFcIniGestion.Text <> "" Then
                ObjVoz.fcini = TxtFcIniGestion.Text
            Else
                ObjVoz.fcini = ""
            End If
            If TxtFcFinGestion.Text <> "" Then
                ObjVoz.fcfin = TxtFcFinGestion.Text
            Else
                ObjVoz.fcfin = ""
            End If
            If drlTipificacion.SelectedValue <> "- Seleccione -" Then
                ObjVoz.Estado_Llamada = drlTipificacion.Text
            Else
                ObjVoz.Estado_Llamada = "Abierto"
            End If
            ObjVoz.idusuario = lblusuario.Text
            ObjVoz.Nombre = TxtNombre.Text
            ObjVoz.obs = Txtobs.Text

            ObjVoz.Ingresar_Tienda_Virtual()

            lblmsg.Text = "Registro realizado correctamente"

            TxtNombre.Text = ""
            TxtFcFormato_Tickler.Text = ""
            TxtFcIniGestion.Text = ""
            TxtFcFinGestion.Text = ""
            Txtobs.Text = ""
            lblId.Text = ""
            Cargardrl()

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnActualizar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnActualizar.Click
        Try
            If lblId.Text = "" Then
                lblmsg.Text = "Consulte un caso antes de realizar una actualizacion"
                Exit Sub
            End If
            If TxtNombre.Text <> "" Then
                ObjVoz.Nombre = TxtNombre.Text
            Else
                ObjVoz.Nombre = ""
            End If
            If TxtFcFormato_Tickler.Text <> "" Then
                ObjVoz.fcini3 = TxtFcFormato_Tickler.Text
            Else
                ObjVoz.fcini3 = ""
            End If
            If TxtFcIniGestion.Text <> "" Then
                ObjVoz.fcini = TxtFcIniGestion.Text
            Else
                ObjVoz.fcini = ""
            End If
            If TxtFcFinGestion.Text <> "" Then
                ObjVoz.fcfin = TxtFcFinGestion.Text
            Else
                ObjVoz.fcfin = ""
            End If
            If drlTipificacion.SelectedValue <> "- Seleccione -" Then
                ObjVoz.Estado_Llamada = drlTipificacion.Text
            Else
                ObjVoz.Estado_Llamada = "1"
            End If
            If Txtobs.Text <> "" Then
                ObjVoz.obs = Txtobs.Text
            Else
                ObjVoz.obs = ""
            End If

            ObjVoz.caso = lblId.Text
            ObjVoz.idusuario = lblusuario.Text

            ObjVoz.Actualiza_Tienda_Virtual()

            lblmsg.Text = "Registro actualizado correctamente"

            TxtNombre.Text = ""
            TxtFcFormato_Tickler.Text = ""
            TxtFcIniGestion.Text = ""
            TxtFcFinGestion.Text = ""
            Txtobs.Text = ""
            lblId.Text = ""
            Cargardrl()

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
End Class