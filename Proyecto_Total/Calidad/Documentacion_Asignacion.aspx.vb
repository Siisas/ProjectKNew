Imports System.IO

Public Class Documentacion_Asignacion
    Inherits System.Web.UI.Page
    Dim ObjArchivo As New clsrrhh
    Protected x As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario  ' obtengo los datos del usuario logueado
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
        ObjArchivo.Validacion = "tip_prioridad"
        With drl_prioridad
            .DataSource = ObjArchivo.Consulta_Archivo_Tipo_Solicitud
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        ObjArchivo.Validacion = "Estado"
        With drl_Tipo_documento
            .DataSource = ObjArchivo.Consulta_Archivo_Tipo_Solicitud
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        ObjArchivo.Validacion = "Calidad_asignar"
        With drl_asignar
            .DataSource = ObjArchivo.Consulta_Archivo_Tipo_Solicitud
            .DataTextField = "nombreu"
            .DataValueField = "Nombre"
            .DataBind()
        End With
    End Sub

    Protected Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try

            txt_num_ticket0.Text = Trim(Replace(txt_num_ticket0.Text, " ", " ")) 'validar  alt 0160
            txt_num_ticket0.Text = Trim(Replace(txt_num_ticket0.Text, " ", " ")) 'validar alt 32
            If txt_num_ticket0.Text = "" And Txt_Fecha_Inicio.Text = "" And drl_prioridad.SelectedValue = "- Seleccione -" And drl_Tipo_documento.SelectedValue = "- Seleccione -" And Txt_Fecha_fin.Text = "" Then
                lblmsg.Text = "Ingrese alguna opcion de filtro" 'valido que el usuario halla seleccionado o diligenciado un campo 
                Exit Sub
            End If
            ObjArchivo.Validacion = "filtros"
            If txt_num_ticket0.Text <> Nothing Then   'valido si el usuario quiere consultar por la ID, si es asi , este filtro tendra la prioridad
                ObjArchivo.ticket = txt_num_ticket0.Text
            Else 'sino continuo con la validacion de los posibles filtros
                If Txt_Fecha_Inicio.Text <> Nothing Then
                    ObjArchivo.fecha_registro = Txt_Fecha_Inicio.Text
                End If
                If drl_prioridad.SelectedValue <> "- Seleccione -" Then
                    ObjArchivo.asignado = drl_prioridad.SelectedValue
                End If
                If drl_Tipo_documento.SelectedValue <> "- Seleccione -" Then
                    ObjArchivo.tipo_documento = drl_Tipo_documento.SelectedValue
                End If
                If Txt_Fecha_fin.Text <> "" Then
                    ObjArchivo.fcfin = Txt_Fecha_fin.Text
                End If
                If Txt_Fecha_Inicio.Text <> "" And Txt_Fecha_fin.Text <> "" Then 'valido fecha inicio REGISTRO - fecha fin REGISTRO
                    If Date.Parse(Txt_Fecha_Inicio.Text) > Date.Parse(Txt_Fecha_fin.Text) Then
                        lblmsg.Text = "Verifique el rango de fechas ya que la fecha inicio no puede ser mayor a la fecha fin"
                        Exit Sub
                    End If
                End If
            End If
            Session("dtsB") = ObjArchivo.Consulta_Todas_Solicitudes 'guardo la sesion para evitar error cuando el usuario cambie de pajina en el grid, y realizo la consulta con la que voy a cargar el grid 
            dtgConsultas.DataSource = Session("dtsB")
            dtgConsultas.DataBind()
            lblmsg.Text = ""
            limpiar()
            If ObjArchivo.Validacion = "1" Then 'realizo este condicional  para evitar un error cuando en la consulta que se realiza pasos atras , no me retorna nada
                lblmsg.Text = "No se Han Encontrado Registros Con Este Filtro"
            End If
            dtg_historial.Visible = False
            lblcuenta2.Text = ""
            lblcuenta.Text = ObjArchivo.Version 'este label me indiga en numero de registros cargados en el grid he incontrados en la consulta
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
    Sub limpiar() 'realizo metodo para limpiar herramientas y optimizar codigo
        lbl_num_ticket.Text = ""
        lbl_fecha_reg.Text = ""
        lbl_prioridad.Text = ""
        txt_comentario.Text = ""
        lbl_estado.Text = ""
        lbl_per_soli.Text = ""
        txt_obs.Text = ""
        drl_asignar.SelectedValue = "- Seleccione -"
        btn_guardar.Visible = False
        lbl_proceso.Text = ""
        lbl_tipo_documento.Text = ""
    End Sub

    Protected Sub btn_buscar_todos_Click(sender As Object, e As EventArgs) Handles btn_buscar_todos.Click
        Try
            Session("dtsB") = ObjArchivo.Consulta_Todas_Solicitudes
            dtgConsultas.DataSource = Session("dtsB")
            dtgConsultas.DataBind()
            lblmsg.Text = ""
            lblcuenta.Text = ObjArchivo.Version 'este label me indiga en numero de registros cargados en el grid he incontrados en la consulta
            dtg_historial.Visible = False
            lblcuenta2.Text = ""
            dtg_historial.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    'el PageIndexChanging Se produce cuando se hace clic en uno de los botones de paginación
    Protected Sub dtg_historial_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtg_historial.PageIndexChanging
        Try
            dtg_historial.PageIndex = e.NewPageIndex
            dtg_historial.DataSource = Session("dtsX") 'cambio el nombre de la sesion cambiandole la ultima letra para no confundirme con la otra sesion del otro grid 
            dtg_historial.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub dtgConsultas_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgConsultas.PageIndexChanging
        Try
            dtgConsultas.PageIndex = e.NewPageIndex
            dtgConsultas.DataSource = Session("dtsB")
            dtgConsultas.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    'este evento lo utilizo para cuando el usuario selecciona un registro  
    Protected Sub dtgConsultas_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtgConsultas.RowCommand
        Try
            'Mediante este codigo envio la identificacion del aspirante, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Seleccion" Then
                dtg_historial.Visible = True
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                'aqui selecciono la columna y la muestro en una herramienta
                lbl_num_ticket.Text = dtgConsultas.Rows(index).Cells(0).Text
                lbl_fecha_reg.Text = dtgConsultas.Rows(index).Cells(1).Text
                lbl_prioridad.Text = dtgConsultas.Rows(index).Cells(2).Text
                txt_comentario.Text = dtgConsultas.Rows(index).Cells(3).Text
                lbl_per_soli.Text = dtgConsultas.Rows(index).Cells(4).Text
                lbl_tipo_documento.Text = dtgConsultas.Rows(index).Cells(5).Text
                lbl_proceso.Text = dtgConsultas.Rows(index).Cells(6).Text
                lbl_estado.Text = dtgConsultas.Rows(index).Cells(8).Text
                lblmsg.Text = ""
                btn_guardar.Visible = True
                ObjArchivo.Validacion = "buscar ticket2"
                ObjArchivo.ticket = lbl_num_ticket.Text
                Session("dtsX") = ObjArchivo.Consulta_Todas_Solicitudes
                dtg_historial.DataSource = Session("dtsX")
                dtg_historial.DataBind()
                If lbl_estado.Text = "&nbsp;" Then
                    lbl_estado.Text = ""
                End If
                If lbl_per_soli.Text = "&nbsp;" Then
                    lbl_per_soli.Text = ""
                End If
            End If
            lblcuenta2.Text = ObjArchivo.Version
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try
            If lbl_estado.Text = "Terminado" Then 'valido si el estado es terminado, para no efectuar el registro
                lblmsg.Text = "la Solicitud " & lbl_num_ticket.Text & " ya se Encuentra Terminada"
                Exit Sub
            End If
            ObjArchivo.usuario_registra = CType(Session("permisos"), clsusuario).usuario 'obtengo el usuario logueado para registrarlo - seguridad
            ObjArchivo.ticket = lbl_num_ticket.Text
            txt_obs.Text = Left(txt_obs.Text, 199) 'como la herramienta txt_obs tiene la propiedad multilinea, agregue la funcion left para capturar el numero de caracteres exacto que tengo registrada en la tabla, para evitar un desbordamiento 
            ObjArchivo.comentario = txt_obs.Text
            ObjArchivo.fecha_registro = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") 'tomo la fecha y la hora del sistema para registrarlo - seguridad
            ObjArchivo.tipo_solicitud = drl_asignar.SelectedValue 'selecciono el value de la lista no el texto 'son diferentes el value que esta por debajo del texto' 
            If ObjArchivo.comentario = "" Then
                lblmsg.Text = "Digite Una Observacion"
                Exit Sub
            End If
            If (ObjArchivo.tipo_solicitud = "- Seleccione -") Then
                lblmsg.Text = "seleccione a un Auditor"
                Exit Sub
            End If
            ObjArchivo.Validacion = "inserta_seguimiento_asignacion"
            ObjArchivo.Asignacion_Solicitud()
            ObjArchivo.Validacion = "actualiza_estado_proceso"
            ObjArchivo.ticket = lbl_num_ticket.Text
            ObjArchivo.Asignacion_Solicitud()
            btn_buscar_todos_Click(1, Nothing) 'llamo el metodo del evento del boton Buscar todos
            lblmsg.Text = "Asignacion Exitosa"
            limpiar()
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
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
