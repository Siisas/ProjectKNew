Public Class Formacion_Respuesta
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
                Btn_buscar_todos_Click(1, Nothing)
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
        With Drl_Prioridad
            ObjFormacion.validacion = "4"
            .DataSource = ObjFormacion.cargar_drl
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        With Drl_Estado
            ObjFormacion.validacion = "5"
            .DataSource = ObjFormacion.cargar_drl
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
    End Sub

    Protected Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
        Try
            If txtcaso.Text <> "" And Drl_Prioridad.SelectedValue = "- Seleccione -" And Txt_fc_inicio.Text <> "" And Txt_fc_fin.Text <> "" Then
                lblmsg.Text = "Ingrese minimo un filtro para realizar la consulta"
                Exit Sub
            End If
            ObjFormacion.Usuario = lblusuario.Text
            If txtcaso.Text <> "" Then
                ObjFormacion.id = txtcaso.Text
            Else
                If Drl_Prioridad.SelectedValue <> "- Seleccione -" Then
                    ObjFormacion.prioridad = Drl_Prioridad.SelectedValue
                End If
                If Txt_fc_inicio.Text <> "" And Txt_fc_fin.Text <> "" Then
                    If Date.Parse(ObjFormacion.Fecha_Actual) > Date.Parse(Txt_fc_fin.Text) Then
                        lblmsg.Text = "Verifique el rango de fechas ya que la fecha inicio no puede ser mayor a la fecha fin"
                        Exit Sub
                    End If
                End If
                If Txt_fc_inicio.Text <> "" Then
                    ObjFormacion.fecha = Txt_fc_inicio.Text
                End If
                If Txt_fc_fin.Text <> "" Then
                    ObjFormacion.fecha2 = Txt_fc_fin.Text
                End If
            End If
            ObjFormacion.validacion = "Filtros_3"
            Session("dtsB") = ObjFormacion.consultas()
            dtggeneral.DataSource = Session("dtsB")
            dtggeneral.DataBind()
            lblcuenta.Text = ObjFormacion.area

            If dtggeneral.Rows.Count > 0 Then
                Pnl_cabecera_2.Visible = True
            Else
                Pnl_cabecera_2.Visible = False
            End If
            lblmsg.Text = ""
            If ObjFormacion.validacion = "1" Then
                lblmsg.Text = "No se encontraron Registros"
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_buscar_todos_Click(sender As Object, e As EventArgs) Handles Btn_buscar_todos.Click
        Try
            ObjFormacion.validacion = "Buscar_Todos3"
            ObjFormacion.Usuario = lblusuario.Text
            Session("dtsB") = ObjFormacion.consultas()
            dtggeneral.DataSource = Session("dtsB")
            dtggeneral.DataBind()
            lblcuenta.Text = ObjFormacion.area
            lblmsg.Text = ""
            dtg_seguim.DataSource = Nothing
            dtg_seguim.DataBind()
            Pnl_cabecera_1.Visible = False
            If dtggeneral.Rows.Count > 0 Then
                Pnl_cabecera_2.Visible = True
            Else
                Pnl_cabecera_2.Visible = False
            End If
            lblcuenta2.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub btn_Guardar_Click(sender As Object, e As ImageClickEventArgs) Handles btn_Guardar.Click
        Try
            If Lbl_estado.Text = "Cerrado" Then
                lblmsg.Text = "Esta Formacion ya se encuentra Cerrada"
                Exit Sub
            End If
            If Lbl_estado.Text = "Sin Asignar" Then
                lblmsg.Text = "Esta Formacion no le esta Asignada"
                Exit Sub
            End If
            If Txt_id_cargue.Text = "" Then
                lblmsg.Text = "Seleccione una Formacion"
                Exit Sub
            End If
            If Drl_Estado.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un estado"
                Exit Sub
            End If
            If Txt_Observacion.Text = "" Then
                lblmsg.Text = "Digite una Observacion"
                Exit Sub
            End If
            ObjFormacion.observacion = Txt_Observacion.Text
            ObjFormacion.Usuario = lblusuario.Text
            ObjFormacion.id = Txt_id_cargue.Text
            ObjFormacion.tema = Drl_Estado.SelectedValue
            ObjFormacion.prioridad = Txt_Grupo.Text
            ObjFormacion.Numero_Personas = Txt_Modulo.Text
            ObjFormacion.validacion = "Estado Modulo"
            ObjFormacion.Formador = Lbl_Cod_Respuesta.Text
            ObjFormacion.Actualizacion_Solicitud_Formacion()


            ObjFormacion.validacion = "Registro_Respuesta"
            ObjFormacion.Ingreso_Solicitud_Formacion()
            ObjFormacion.validacion = "Respuesta"
            ObjFormacion.id = Txt_id_cargue.Text
            dtg_seguim.DataSource = ObjFormacion.consultas()
            dtg_seguim.DataBind()
            lblcuenta2.Text = ObjFormacion.area
            lblmsg.Text = "Registro Exitoso"
            If dtg_seguim.Rows.Count > 0 Then
                Pnl_cabecera_1.Visible = True
            Else
                Pnl_cabecera_1.Visible = False
            End If
            ObjFormacion.validacion = "Validar_Cerrar"
            ObjFormacion.consultas()
            If ObjFormacion.area = "0" Then
                ObjFormacion.validacion = "Cerrar Formacion"
                ObjFormacion.Actualizacion_Solicitud_Formacion()
            End If
            ObjFormacion.validacion = "Buscar_Todos3"
            ObjFormacion.Usuario = lblusuario.Text
            Session("dtsB") = ObjFormacion.consultas()
            dtggeneral.DataSource = Session("dtsB")
            dtggeneral.DataBind()
            lblcuenta.Text = ObjFormacion.area
            Txt_Observacion.Text = ""
            Txt_id_cargue.Text = ""
            Txt_tipo_Solicitud_Cargue.Text = ""
            Txt_Grupo.Text = ""
            Txt_Modulo.Text = ""
            Drl_Estado.SelectedValue = "- Seleccione -"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtggeneral.RowCommand
        Try
            'Mediante este codigo envio la identificacion del aspirante, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Seleccion" Then
                dtggeneral.Visible = True
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                'aqui selecciono la columna y la muestro en una herramienta
                Lbl_Cod_Respuesta.Text = dtggeneral.Rows(index).Cells(0).Text
                Txt_id_cargue.Text = dtggeneral.Rows(index).Cells(1).Text
                Txt_tipo_Solicitud_Cargue.Text = dtggeneral.Rows(index).Cells(8).Text
                Lbl_estado.Text = dtggeneral.Rows(index).Cells(10).Text
                Txt_Grupo.Text = dtggeneral.Rows(index).Cells(2).Text
                Txt_Modulo.Text = dtggeneral.Rows(index).Cells(3).Text

                lblmsg.Text = ""
                ObjFormacion.validacion = "Respuesta"
                ObjFormacion.id = Txt_id_cargue.Text
                dtg_seguim.DataSource = ObjFormacion.consultas()
                dtg_seguim.DataBind()
                lblcuenta2.Text = ObjFormacion.area
                If dtg_seguim.Rows.Count > 0 Then
                    Pnl_cabecera_1.Visible = True
                Else
                    Pnl_cabecera_1.Visible = False
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub


    Protected Sub dtggeneral_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles dtggeneral.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Dim x As Date = DataBinder.Eval(e.Row.DataItem, "Fecha")
                If FormatDateTime(x, DateFormat.ShortDate) = Date.Parse(DateTime.Now.Date) Then
                    e.Row.ForeColor = Drawing.Color.Blue
                End If
                If FormatDateTime(x, DateFormat.ShortDate) > Date.Parse(DateTime.Now.Date) Then
                    e.Row.ForeColor = Drawing.Color.Red
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub



End Class