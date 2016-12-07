Public Class Chat_Supervisor
    Inherits System.Web.UI.Page
    Dim ObjChat As New clsChat
    Dim Cod_Registro As Int64

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                Cargardrl()
                Actualizar_Bandeja()
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
            lblmsg.Text = "Sepresento Error: " + ex.Message
        End Try
    End Sub

    Public Sub Cargardrl()

        With drlGrupo
            .DataSource = ObjChat.Consulta_Grupos
            .DataTextField = "cargo"
            .DataValueField = "cargo"
            .DataBind()
        End With
            ObjChat.Fecha_Creacion = drlGrupo.Text
        With drlUsuario
            .DataSource = ObjChat.Consulta_Agentes_Grupo
            .DataTextField = "nombreu"
            .DataValueField = "idusuario"
            .DataBind()
        End With

    End Sub

    Public Sub Actualizar_Bandeja()
        Try
            ObjChat.Fk_idusuario = lblusuario.Text
            dtgBandeja.DataSource = ObjChat.Consulta_Bandeja()
            dtgBandeja.DataBind()
            LblCantidadMensajes.Text = ObjChat.Cantidad
            ObjChat.Fk_idusuario = Nothing
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Public Sub Consulta_Historico()
        Try
            ObjChat.Id_Usuarios = lblusuario.Text
            ObjChat.Fk_idusuario = drlUsuario.Text
            dtggeneral.DataSource = ObjChat.Consulta_Registro_Chat()
            dtggeneral.DataBind()
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub


    Protected Sub BtnActualizar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnActualizar.Click
        Try
            If drlGrupo.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un grupo"
                Exit Sub
            End If
            If drlUsuario.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el agente para actualizar la conversacion"
                Exit Sub
            End If
            Consulta_Historico()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Public Sub Consulta_Ultimo_Mensaje()
        Try
            ObjChat.Consulta_Ultimo_Registro_Chat()
            Cod_Registro = ObjChat.Cod_Chat_Notas
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Public Sub Crear_Mensaje()
        Try
            ObjChat.Ingresar_Mensaje()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Public Sub Consulta_Registro_Existente()
        Try
            ObjChat.Consulta_Registro_Chat()
            Cod_Registro = ObjChat.Cod_Chat_Notas
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub btnEnviar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEnviar.Click
        Try
            If drlGrupo.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un grupo"
                Exit Sub
            End If
            If drlUsuario.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el agente para el cual enviara la conversacion"
                Exit Sub
            End If
            If TxtMensaje.Text = "" Then
                lblmsg.Text = "Digite el mensaje que enviara"
                Exit Sub
            End If
            ObjChat.Id_Usuarios = lblusuario.Text
            ObjChat.Obs = TxtMensaje.Text
            ObjChat.Aletar = True
            ObjChat.Fk_idusuario = drlUsuario.Text
            Consulta_Registro_Existente()
            If Cod_Registro = 0 Or Cod_Registro = Nothing Then
                Crear_Mensaje()
                Consulta_Ultimo_Mensaje()
            End If
            ObjChat.Fk_Cod_Chat_Notas = Cod_Registro

            ObjChat.Actualizar_Alerta_Bandeja()
            ObjChat.Ingresar_Detalle_Mensaje()

            lblmsg.Text = "Mensaje Enviado"

            TxtMensaje.Text = ""
            Consulta_Historico()
            Actualizar_Bandeja()
            Cargardrl()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Public Sub Cargar_Agentes()
        Try
            ObjChat.Fecha_Creacion = drlGrupo.Text
            With drlUsuario
                .DataSource = ObjChat.Consulta_Agentes_Grupo
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drlGrupo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlGrupo.SelectedIndexChanged
        Try
            Cargar_Agentes()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnActualizarBandeja_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnActualizarBandeja.Click
        Try
            Actualizar_Bandeja()
        Catch ex As Exception
            lblmsg.Text = "Se presento erro: " + ex.Message
        End Try
    End Sub

    Protected Sub dtgBandeja_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgBandeja.PageIndexChanging
        Try
            dtgBandeja.PageIndex = e.NewPageIndex
            Actualizar_Bandeja()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub dtgBandeja_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles dtgBandeja.RowCommand
        Try
            If e.CommandName = "Seleccionar" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                drlGrupo.Text = dtgBandeja.Rows(index).Cells(0).Text
                Cargar_Agentes()
                'drlUsuario.SelectedItem.Text = dtgBandeja.Rows(index).Cells(1).Text
                drlUsuario.SelectedValue = dtgBandeja.Rows(index).Cells(2).Text
                Consulta_Historico()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
End Class