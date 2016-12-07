Public Class Desarrollo_Registro
    Inherits System.Web.UI.Page
    Dim ObjDesarrollo As New ClsDesarrollo
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            lblmsg.Text = ""
            lblmsgg.Text = ""
            Alert_error.Visible = False
            Alert_correcto.Visible = False
            If Not IsPostBack Then
                Cargar_Drls()
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                objdatos.idusuario = lblusuario.Text
                objdatos.consultacod()
                lblcod.Text = objdatos.cargo
                ''''' INICIO SEGURIDAD ACCESO URL '''''
                'Dim objGeneral As New clsgeneral
                'objGeneral.DtsSeguridad = Session("dtsSeguridad")
                'objGeneral.Consulta_Proyecto_Seguridad()
                'objGeneral.PaginaAcceso = "~" + Mid(Request.RawUrl, Integer.Parse(objGeneral.nombreentidad))
                'objGeneral.idusuario = CType(Session("permisos"), clsusuario).usuario
                'objGeneral.PermisosUrl()
                ''''' FIN SEGURIDAD ACCESO URL '''''                
                ObjDesarrollo.IdUsuario = lblusuario.Text
                Session("Consulta") = ObjDesarrollo.Consulta_Desarrollos()
                Dtg_Desarrollos.DataSource = Session("Consulta")
                Dtg_Desarrollos.DataBind()
                Lbl_Cantidad.Text = ObjDesarrollo.Cantidad
            End If
        Catch ex As Exception
            lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> ¡Error! " & ex.Message
            Alert_error.Visible = True
        End Try
    End Sub

    Public Sub Cargar_Drls()
        With Drl_Area
            ObjDesarrollo.Validacion = "Cargar_Area"
            .DataSource = ObjDesarrollo.Consulta_Carga_Drls()
            .DataTextField = "Com_Nom"
            .DataValueField = "Com_Cod"
            .DataBind()
        End With
        With Drl_Prioridad
            ObjDesarrollo.Validacion = "Cargar_Prioridad"
            .DataSource = ObjDesarrollo.Consulta_Carga_Drls()
            .DataTextField = "Com_Nom"
            .DataValueField = "Com_Cod"
            .DataBind()
        End With
        With Drl_Cons_Prioridad
            .DataSource = ObjDesarrollo.Consulta_Carga_Drls()
            .DataTextField = "Com_Nom"
            .DataValueField = "Com_Cod"
            .DataBind()
        End With
        With Drl_Solicitante
            ObjDesarrollo.Validacion = "Cargar_Solicitante"
            .DataSource = ObjDesarrollo.Consulta_Carga_Drls()
            .DataTextField = "nombreu"
            .DataValueField = "idusuario"
            .DataBind()
            .Items.Insert(0, "- Seleccione -")
        End With
    End Sub
    Public Sub Limpiar()
        Txt_Tema.Text = Nothing
        Txt_Requerimientos.Text = Nothing
        Drl_Prioridad.SelectedIndex = 0
        Drl_Area.SelectedIndex = 0
        Drl_Solicitante.SelectedIndex = 0
    End Sub

    Protected Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Try
            If Txt_Tema.Text = Nothing Or Txt_Tema.Text = "" Or Txt_Tema.Text = " " Or Txt_Tema.Text = "0" Then
                lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> ¡El campo (Tema) debe ser diligenciado!"
                Alert_error.Visible = True
                Exit Sub
            End If
            If Drl_Prioridad.SelectedItem.Value = "0" Then
                lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> ¡El campo (Prioridad) es obligatorio!"
                Alert_error.Visible = True
                Exit Sub
            End If
            If Drl_Area.SelectedItem.Value = "0" Then
                lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> ¡El campo (Area) es obligatorio!"
                Alert_error.Visible = True
                Exit Sub
            End If
            If Drl_Solicitante.SelectedItem.Value = "- Seleccione -" Then
                lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> ¡El campo (Persona Solicita) es obligatorio!"
                Alert_error.Visible = True
                Exit Sub
            End If
            If Txt_Requerimientos.Text = Nothing Or Txt_Requerimientos.Text = "" Or Txt_Requerimientos.Text = " " Or Txt_Requerimientos.Text = "0" Then
                lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> ¡Para el campo (Requerimientos) debe diligenciar especificamente lo que se requiere en el desarrollo!"
                Alert_error.Visible = True
                Exit Sub
            End If
            ObjDesarrollo.IdUsuario = lblusuario.Text
            ObjDesarrollo.Tema = Txt_Tema.Text
            ObjDesarrollo.Prioridad = Drl_Prioridad.SelectedItem.Text
            ObjDesarrollo.Area = Drl_Area.SelectedItem.Value
            ObjDesarrollo.Solicitante = Drl_Solicitante.SelectedItem.Value
            ObjDesarrollo.Requerimientos = Txt_Requerimientos.Text
            ObjDesarrollo.Reg_Solicitud_Desarrollo()
            ObjDesarrollo.Consultar_Codigo()
            Limpiar()
            lblmsgg.Text = "<strong><span class='glyphicon glyphicon-ok-circle'></span></strong> ¡Se registro exitosamente la solicitud con el codigo " & ObjDesarrollo.Codigo & "!"
            Alert_correcto.Visible = True
            ObjDesarrollo.IdUsuario = lblusuario.Text
            Session("Consulta") = ObjDesarrollo.Consulta_Desarrollos()
            Dtg_Desarrollos.DataSource = Session("Consulta")
            Dtg_Desarrollos.DataBind()
            Lbl_Cantidad.Text = ObjDesarrollo.Cantidad
        Catch ex As Exception
            lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> ¡Error! " & ex.Message
            Alert_error.Visible = True
        End Try
    End Sub

    Protected Sub Btn_Filtrar_Click(sender As Object, e As EventArgs) Handles Btn_Filtrar.Click
        Try
            ObjDesarrollo.IdUsuario = lblusuario.Text
            ObjDesarrollo.Codigo = Txt_Cons_Codigo.Text
            If Drl_Cons_Prioridad.SelectedItem.Text = "- Seleccione -" Then
                ObjDesarrollo.Prioridad = ""
            Else
                ObjDesarrollo.Prioridad = Drl_Cons_Prioridad.SelectedItem.Text
            End If
            ObjDesarrollo.Fecha_Inicio = Txt_Fc_Inicio.Text
            If Txt_Fc_Fin.Text = "" Then
                ObjDesarrollo.Fecha_Fin = ""
            Else
                ObjDesarrollo.Fecha_Fin = Txt_Fc_Fin.Text & " 23:59:59"
            End If
            Session("Consulta") = ObjDesarrollo.Consulta_Desarrollos()
            Dtg_Desarrollos.DataSource = Session("Consulta")
            Dtg_Desarrollos.DataBind()
            Lbl_Cantidad.Text = ObjDesarrollo.Cantidad
        Catch ex As Exception
            lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> ¡Error! " & ex.Message
            Alert_error.Visible = True
        End Try
    End Sub

    Protected Sub Dtg_Desarrollos_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Dtg_Desarrollos.PageIndexChanging
        Try
            Dtg_Desarrollos.DataSource = Session("Consulta")
            Dtg_Desarrollos.PageIndex = e.NewPageIndex
            Dtg_Desarrollos.DataBind()
            Lbl_Cantidad.Text = ObjDesarrollo.Cantidad
        Catch ex As Exception
            lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> ¡Error! " & ex.Message
            Alert_error.Visible = True
        End Try
    End Sub
End Class