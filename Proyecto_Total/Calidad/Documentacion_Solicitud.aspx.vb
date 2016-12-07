Imports System.IO


Public Class Documentacion_Solicitud_Documentos
    Inherits System.Web.UI.Page
    Dim ObjArchivo As New clsrrhh
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario ' obtengo los datos del usuario logueado
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                cargar_drl() 'llamo el metodo cargar drl - para cargar las listas desplegables          
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Sub cargar_drl() 'cargo listas desplegables por base de datos utilizando la clase clsrrhh
        With drl_Proceso
            .DataSource = ObjArchivo.Consulta_Archivo_Categoria
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        ObjArchivo.Validacion = "tip_solicitud"
        With drl_Tipo_solicitud
            .DataSource = ObjArchivo.Consulta_Archivo_Tipo_Solicitud
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        ObjArchivo.Validacion = "tip_documento"
        With drl_Tipo_documento
            .DataSource = ObjArchivo.Consulta_Archivo_Tipo_Solicitud
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        ObjArchivo.Validacion = "tip_prioridad"
        With drl_prioridad
            .DataSource = ObjArchivo.Consulta_Archivo_Tipo_Solicitud
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        ObjArchivo.Validacion = "seleccionar"
        With drl_Sub_proceso
            .DataSource = ObjArchivo.Consulta_Archivo_Tipo_Solicitud
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
    End Sub
    Protected Sub btn_Guardar_solicitud_Click1(sender As Object, e As ImageClickEventArgs) Handles btn_Guardar_solicitud.Click
        Try
            ObjArchivo.usuario_registra = CType(Session("permisos"), clsusuario).usuario  'obtengo el usuario logueado - seguridad
            '---------------------
            If drl_Tipo_solicitud.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el Tipo de Solicitud "
                Exit Sub
            End If
            If txt_Persona_soli.Text = "" Then
                lblmsg.Text = "Digite el Nombre De la Persona Que Realiza La Solicitud "
                Exit Sub
            End If
            If drl_Tipo_documento.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el Tipo de Documento"
                Exit Sub
            End If
            If drl_prioridad.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una prioridad"
                Exit Sub
            End If
            If drl_Proceso.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Seleccione Un Proceso"
                Exit Sub
            End If
            If drl_Sub_proceso.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Seleccione Un Sub Proceso"
                Exit Sub
            End If
            If txtObservacion.Text = "" Then
                lblmsg.Text = "Digite una Observacion"
                Exit Sub
            End If
            '---------------------
            'guardo la iformcaion validada y la guardo en el objeto objArchivo
            ObjArchivo.tipo_solicitud = drl_Tipo_solicitud.Text
            ObjArchivo.tipo_documento = drl_Tipo_documento.Text
            ObjArchivo.persona_solicita = txt_Persona_soli.Text
            ObjArchivo.proceso = drl_Proceso.Text
            ObjArchivo.Sub_proceso = drl_Sub_proceso.Text
            ObjArchivo.observacionn = txtObservacion.Text
            ObjArchivo.prioridad = drl_prioridad.Text
            ObjArchivo.Registro_Solicitud_Documento()
            ObjArchivo.Validacion = "buscar id"
            ObjArchivo.Consulta_Todas_Solicitudes()
            lblmsg.Text = "Registro Exitoso, Con La Solicitud Numero " & ObjArchivo.ticket
            txt_Persona_soli.Text = ""
            drl_Sub_proceso.Items.Clear()
            txtObservacion.Text = ""
            drl_prioridad.SelectedValue = "- Seleccione -"
            cargar_drl()
            txt_id_soli.Text = ""
            Txt_Fecha_Inicio.Text = ""
            Txt_Fecha_fin.Text = ""
            lblcuenta.Text = ""
            CheckBoxTicket.Checked = False
            Pn_contenedor1.Visible = False
            Pn_contenedor2.Visible = False
            lblcuenta.Text = ""
            lblcuenta2.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub
    Protected Sub drl_Proceso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drl_Proceso.SelectedIndexChanged
        Try
            ObjArchivo.Validacion = "cargar drl_Sub_proceso"
            ObjArchivo.tipo_solicitud = drl_Proceso.SelectedValue
            With drl_Sub_proceso
                .DataSource = ObjArchivo.Consulta_Archivo_Tipo_Solicitud
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub
    Sub sub_lista()
        Try
            If drl_Proceso.SelectedItem.Text <> "- Seleccione -" Then
                ObjArchivo.Validacion = "cargar drl_Sub_proceso"
                With drl_Sub_proceso
                    .DataSource = ObjArchivo.Consulta_Archivo_Tipo_Solicitud
                    .DataTextField = "Nombre"
                    .DataValueField = "Nombre"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub
    Protected Sub btn_buscar_Click(sender As Object, e As ImageClickEventArgs) Handles btn_buscar.Click
        Try
            txt_id_soli.Text = Trim(Replace(txt_id_soli.Text, " ", " ")) ' validar alt 0160
            txt_id_soli.Text = Trim(Replace(txt_id_soli.Text, " ", " ")) ' alt 32
            If Txt_Fecha_fin.Text = "" And Txt_Fecha_Inicio.Text = "" And txt_id_soli.Text = "" And CheckBoxTicket.Checked = False Then
                lblmsg.Text = "Ingrese alguna Opcion de Filtro"
                Exit Sub
            End If
            ObjArchivo.nombres = lblusuario.Text
            ObjArchivo.Validacion = "filtros3"
            If txt_id_soli.Text <> Nothing Then
                ObjArchivo.ticket = txt_id_soli.Text
            ElseIf CheckBoxTicket.Checked <> True Then
                If Txt_Fecha_Inicio.Text <> Nothing Then
                    ObjArchivo.fecha_registro = Txt_Fecha_Inicio.Text
                End If
                If Txt_Fecha_fin.Text <> "" Then
                    ObjArchivo.fcfin = Txt_Fecha_fin.Text
                End If
                If Txt_Fecha_Inicio.Text <> "" And Txt_Fecha_fin.Text <> "" Then
                    If Date.Parse(Txt_Fecha_Inicio.Text) > Date.Parse(Txt_Fecha_fin.Text) Then
                        lblmsg.Text = "Verifique el rango de fechas ya que la fecha inicio no puede ser mayor a la fecha fin"
                        Exit Sub
                    End If
                End If
            End If
            Session("dtsB") = ObjArchivo.Consulta_Todas_Solicitudes
            dtgConsultas.DataSource = Session("dtsB")
            dtgConsultas.DataBind()
            lblmsg.Text = ""
            If ObjArchivo.Validacion = "1" Then
                lblmsg.Text = "No se Han Encontrado Registros Con Este Filtro"
            End If
            lblcuenta.Text = ObjArchivo.Version
            CheckBoxTicket.Checked = False
            Pn_contenedor2.Visible = False
            lblcuenta2.Text = ""
            Pn_contenedor1.Visible = True
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub
    'este evento lo utilizo para cuando el usuario selecciona un registro 
    Protected Sub dtgConsultas_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtgConsultas.RowCommand
        Try
            If e.CommandName = "Seleccion" Then
                ObjArchivo.Validacion = "buscar ticket"
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)

                ObjArchivo.ticket = dtgConsultas.Rows(index).Cells(0).Text
                Session("dtsZ") = ObjArchivo.Consulta_Todas_Solicitudes
                dtg_historial.DataSource = Session("dtsZ")
                dtg_historial.DataBind()

                lblcuenta2.Text = ObjArchivo.Version
                Pn_contenedor2.Visible = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
    'el PageIndexChanging Se produce cuando se hace clic en uno de los botones de paginación
    Protected Sub dtgConsultas_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgConsultas.PageIndexChanging
        Try
            dtgConsultas.DataSource = ObjArchivo.Consulta_Todas_Solicitudes()
            dtgConsultas.PageIndex = e.NewPageIndex
            dtgConsultas.DataSource = Session("dtsB") 'guardo la sesion para evitar error cuando el usuario cambie de pajina en el grid, y realizo la consulta con la que voy a cargar el grid 
            dtgConsultas.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub dtg_historial_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtg_historial.PageIndexChanging
        Try
            dtg_historial.PageIndex = e.NewPageIndex
            dtg_historial.DataSource = Session("dtsZ") 'cambio el nombre de la sesion cambiandole la ultima letra para no confundirme con la otra sesion del otro grid 
            dtg_historial.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        Try
            If dtgConsultas.Visible = False Then
                lblmsg.Text = "Realice una consulta y luego intente exportarla"
                Exit Sub
            End If
            crearexcel()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
            lblmsg.ForeColor = Drawing.Color.Red
        End Try
    End Sub
    Sub crearexcel()
        Dim sb As New StringBuilder
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim form = New HtmlForm
        Dim r As New clscalidad
        Dim objdtsconsultaxls As New DataSet
        Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
        If lblcuenta.Text <> Nothing Then
            If lblcuenta.Text < 20001 Then
                pagina.EnableEventValidation = False
                pagina.DesignerInitialize()
                pagina.Controls.Add(form)
                form.Controls.Add(dtgConsultas)
                pagina.RenderControl(htw)
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/vnd.ms-excel"
                Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                Response.AddHeader("Content-Disposition", "attachment;filename=JustificacionPQR.xls")
                Response.Charset = "UTF-8"
                Response.Write(strStyle)
                Response.Write(sb.ToString())
                Response.End()
            Else
                lblmsg.Text = "No se puede generar archivo en xls, realice un filtro adicional o solicite la consulta al administrador de la base de datos"
            End If
        Else
            lblmsg.Text = "Realice una consulta y luego intente exportarla"
        End If
    End Sub






End Class