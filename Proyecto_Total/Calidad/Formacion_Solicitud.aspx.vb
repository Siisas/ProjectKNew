Public Class Solicitud_Formacion
    Inherits System.Web.UI.Page
    Dim ObjFormacion As New clsFormacion

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario  ' obtengo los datos del usuario logueado
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                cargar_drl() 'llamo el metodo cargar drl - para cargar las listas desplegables


                Dim objdatos As New clsgeneral
                objdatos.idusuario = lblusuario.Text
                objdatos.consultacod()
                lblcod.Text = objdatos.cargo

                If lblcod.Text = "C0270" Or lblcod.Text = "C0344" Or lblcod.Text = "C0559" Or lblcod.Text = "C0665" Or lblcod.Text = "C0783" Or lblcod.Text = "C0823" Or lblcod.Text = "C0865" Or lblcod.Text = "C0938" Or lblcod.Text = "C1078" Or lblcod.Text = "C0003" Or lblcod.Text = "C0014" Or lblcod.Text = "C0021" Or lblcod.Text = "C0031" Or lblcod.Text = "C0035" Or lblcod.Text = "C0042" Or lblcod.Text = "C0051" Or lblcod.Text = "C0053" Or lblcod.Text = "C0083" Or lblcod.Text = "C1543" Or lblcod.Text = "C1556" Or lblcod.Text = "C0940" Or lblcod.Text = "C1566" Or lblcod.Text = "C1583" Or lblcod.Text = "C1390" Then
                    btn_crear.Visible = True

                    Btn_Buscar.Visible = True
                Else
                    btn_crear.Visible = False
                    Btn_Buscar.Visible = False
                End If

            End If
            ''''' INICIO SEGURIDAD ACCESO URL '''''
            Dim objGeneral As New clsgeneral
            objGeneral.DtsSeguridad = Session("dtsSeguridad")
            objGeneral.Consulta_Proyecto_Seguridad()
            objGeneral.PaginaAcceso = "~" + Mid(Request.RawUrl, Integer.Parse(objGeneral.nombreentidad))
            objGeneral.idusuario = CType(Session("permisos"), clsusuario).usuario
            objGeneral.PermisosUrl()
            ''''' FIN SEGURIDAD ACCESO URL '''''  



          





          





           

        Catch ex As Exception

            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
 
    Sub cargar_drl()
        With Drl_Lugar
            ObjFormacion.validacion = "6"
            .DataSource = ObjFormacion.cargar_drl
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        With Drl_Tipo_Formacion
            ObjFormacion.validacion = "1"
            .DataSource = ObjFormacion.cargar_drl
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        With drl_area
            ObjFormacion.validacion = "2"
            .DataSource = ObjFormacion.cargar_drl
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        With Drl_prioridad
            ObjFormacion.validacion = "4"
            .DataSource = ObjFormacion.cargar_drl
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
    End Sub

    Protected Sub btn_crear_Click1(sender As Object, e As ImageClickEventArgs) Handles btn_crear.Click
        Try
            If Drl_Tipo_Formacion.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un tipo de formacion"
                Exit Sub
            End If
            If Txt_N_Personas.Text = "" Then
                lblmsg.Text = "Digite el numero de personas a capacitar"
                Exit Sub
            End If
            If drl_area.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una un area"
                Exit Sub
            End If
            If Drl_prioridad.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Seleccione Una prioridad"
                Exit Sub
            End If
            If Txt_Tema.Text = "" Then
                lblmsg.Text = "Seleccione un tema"
                Exit Sub
            End If
            If txtfcingn3.Text = "" Then
                lblmsg.Text = "Seleccione una fecha"
                Exit Sub
            End If
            If Date.Parse(Date.Now.ToString("dd/MM/yyyy")) > Date.Parse(txtfcingn3.Text) Then
                lblmsg.Text = "La fecha para la ejecucion no puede ser anterior a la actual"
                Exit Sub
            End If
            If Drl_Lugar.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un lugar para la formacion"
                Exit Sub
            End If
            If Txt_Observacion.Text = "" Then
                lblmsg.Text = "Digite una observacion"
                Exit Sub
            End If
            ObjFormacion.Numero_Personas = Txt_N_Personas.Text
            ObjFormacion.Usuario = lblusuario.Text
            ObjFormacion.Tipo_Formacion = Drl_Tipo_Formacion.SelectedValue
            ObjFormacion.fecha = txtfcingn3.Text
            ObjFormacion.area = drl_area.SelectedValue
            ObjFormacion.tema = Txt_Tema.Text
            ObjFormacion.observacion = Txt_Observacion.Text
            ObjFormacion.prioridad = Drl_prioridad.SelectedValue
            ObjFormacion.Lugar = Drl_Lugar.SelectedValue
            ObjFormacion.validacion = "Registro_Formacion"
            ObjFormacion.Ingreso_Solicitud_Formacion()
            ObjFormacion.validacion = "Buscar_Id"
            ObjFormacion.consultas()
            lblmsg.Text = "Registro Exitoso con el numero " & ObjFormacion.id
            Drl_Tipo_Formacion.SelectedValue = "- Seleccione -"
            txtfcingn3.Text = ""
            drl_area.SelectedValue = "- Seleccione -"
            Txt_Tema.Text = ""
            Txt_Observacion.Text = ""
            Drl_prioridad.SelectedValue = "- Seleccione -"
            Txt_N_Personas.Text = ""
            Drl_Lugar.SelectedValue = "- Seleccione -"
            Txt_Tema.Text = ""
            ObjFormacion.Usuario = lblusuario.Text
            ObjFormacion.validacion = "Usuario"
            ObjFormacion.validacion = "Filtros"
            dtggeneral.DataSource = ObjFormacion.consultas()
            dtggeneral.DataBind()
            lblcuenta.Text = ObjFormacion.area
            Pnl_cabecera_2.Visible = True
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_Buscar_Click(sender As Object, e As ImageClickEventArgs) Handles Btn_Buscar.Click
        Try
            ObjFormacion.Usuario = lblusuario.Text
            If Txt_Caso.Text = "" Then
                ObjFormacion.validacion = "Usuario"
                ObjFormacion.validacion = "Filtros"
                ObjFormacion.validacion = "Buscar_Solicitudes_Id"
            End If

            If Txt_Caso.Text <> "" Then
                ObjFormacion.validacion = "Buscar_Id_Por_Usuario"
                ObjFormacion.id = Txt_Caso.Text
            End If
            dtggeneral.DataSource = ObjFormacion.consultas()
            dtggeneral.DataBind()
            lblmsg.Text = ""
            lblcuenta.Text = ObjFormacion.area
            If ObjFormacion.validacion = "1" Then
                lblmsg.Text = "No se encontraron Registros"
            Else
                Pnl_cabecera_2.Visible = True
            End If
            If dtggeneral.Rows.Count > 0 Then
                Pnl_cabecera_2.Visible = True
            Else
                Pnl_cabecera_2.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtggeneral.RowCommand
        Try
            ObjFormacion.validacion = "Respuesta"
            If e.CommandName = "Seleccion" Then
                dtggeneral.Visible = True
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                ObjFormacion.id = dtggeneral.Rows(index).Cells(0).Text
                dtg_seguim.DataSource = ObjFormacion.consultas()
                dtg_seguim.DataBind()
                If dtg_seguim.Rows.Count > 0 Then
                    Pnl_cabecera_1.Visible = True
                Else
                    Pnl_cabecera_1.Visible = False
                End If
                lblcuenta2.Text = ObjFormacion.area
                lblmsg.Text = ""
                If ObjFormacion.validacion = "1" Then
                    lblmsg.Text = "No se encontraron Registros"
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub







End Class