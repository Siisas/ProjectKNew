Imports System.IO
Public Class RegDatosUsu
    Inherits System.Web.UI.Page
    Dim ObjRRHH As New clsrrhh
    Dim ValidacionExit As Boolean = False
    Dim ValidacionCodigo As Boolean = False
    Dim ValidacionUsuRed As Boolean = False
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If

            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Registro Credenciales"
                Cargar_Drl()

            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Public Sub Cargar_Drl()
        Try
            With Drl_PlataformaRed2
                ObjRRHH.Validacion = 5
                .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                .DataTextField = "Nombre"
                .DataValueField = "cod_estado_usu"
                .DataBind()
            End With
            With Drl_PlataformaRed
                ObjRRHH.Validacion = 5
                .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                .DataTextField = "Nombre"
                .DataValueField = "cod_estado_usu"
                .DataBind()
            End With
            With Drl_PlataformaE2
                ObjRRHH.Plataforma = "Red"
                ObjRRHH.Validacion = 4
                .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With Drl_EstadoP
                ObjRRHH.Validacion = 4
                .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With Drl_Plataforma2
                ObjRRHH.Validacion = 1
                .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                .DataTextField = "Nombre"
                .DataValueField = "cod_estado_usu"
                .DataBind()
            End With
            With Drl_Plataforma
                ObjRRHH.Validacion = 1
                .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                .DataTextField = "Nombre"
                .DataValueField = "cod_estado_usu"
                .DataBind()
            End With
            ObjRRHH.nombres = "CRM"
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Public Sub Limpiar_herramientas()
        Txt_Formato.Text = ""
        Txt_Area.Text = ""
        Txt_Cedula.Text = ""
        Txt_Codigo.Text = ""
        Txt_Codigo.Enabled = True
        Txt_Grupo.Text = ""
        Txt_Nombre.Text = ""
        Cargar_Drl()
        Txt_Cod_Asignacion.Text = ""
        Txt_Pass_Plataforma.Text = ""
        Txt_Usu_Plataforma.Text = ""
        Drl_Plataforma.Visible = True
        Drl_PlataformaRed.Visible = True
        Drl_Plataforma.Enabled = True
        Drl_PlataformaRed.Enabled = True
        Pnl_Drl_Plataforma.Visible = True
        Pnl_Drl_PlataformaRed.Visible = True
    End Sub
    Protected Sub Btn_Reg_Acta_Click(sender As Object, e As EventArgs) Handles Btn_Reg_Acta.Click
        Try
            If Session("RegDatosUsu.aspx.vb").codigo <> Nothing And Txt_Codigo.Text <> Nothing Then
                If Txt_Fehca_Acta.Text = Nothing Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Debe ingrezar la fecha de entrega de acta"
                End If
                ObjRRHH.codigo = Session("RegDatosUsu.aspx.vb").codigo
                ObjRRHH.idusuario = CType(Session("permisos"), clsusuario).usuario
                ObjRRHH.Fecha_Acta = Txt_Fehca_Acta.Text
                If ObjRRHH.Registrar_Acta_Credenciales() > 0 Then
                    Txt_Fehca_Acta.Text = ObjRRHH.Fecha_Acta
                    Txt_Fehca_Acta.Enabled = False
                    Pnl_Fecha_Acta.Visible = False
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro Exitoso"
                Else
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No se pudo completar el registro del acta"
                End If
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> primero debe consultar un usuario"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_guardar_Click(sender As Object, e As EventArgs) Handles Btn_guardar.Click
        Try
            If Txt_Codigo.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el codigo del usuario y  consultelo"
                Exit Sub
            End If
            If Drl_Plataforma.SelectedItem.Text = "- Seleccione -" And Drl_PlataformaRed.SelectedItem.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una plataforma"
                Exit Sub
            End If
            If Drl_EstadoP.SelectedItem.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione el estado de la plataforma"
                Exit Sub
            End If
            If Txt_Usu_Plataforma.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione el usuario de la plataforma"
                Exit Sub
            End If
            If Txt_Pass_Plataforma.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione el password de la plataforma"
                Exit Sub
            End If

            ObjRRHH.codigo = Txt_Codigo.Text
            ObjRRHH.Validacion = "3"
            If ObjRRHH.Consulta_Estados_Usu_Pass().Tables(0).Rows.Count = 0 Then
                ObjRRHH.idusuario = CType(Session("permisos"), clsusuario).usuario
                ObjRRHH.Ingresar_Datos_Usu_pass()
            End If
            ObjRRHH.idusuario = Txt_Codigo.Text
            If Drl_Plataforma.SelectedItem.Text <> "- Seleccione -" Then
                ObjRRHH.Plataforma = Drl_Plataforma.SelectedValue
            ElseIf Drl_PlataformaRed.SelectedItem.Text <> "- Seleccione -" Then
                ObjRRHH.Plataforma = Drl_PlataformaRed.SelectedValue
            End If
            ObjRRHH.Validacion = "10"
            If ObjRRHH.Consulta_Estados_Usu_Pass().Tables(0).Rows.Count > 0 Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> El Usuario ya tiene asociada esta plataforma"
                Exit Sub
            End If
            If Drl_Plataforma.SelectedItem.Text = "Mail" Then
                If IsValidEmail(Txt_Usu_Plataforma.Text) = 0 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> El formato del correo no es correcto "
                    Exit Sub
                End If
            End If
            ObjRRHH.Usuario_Plataforma = Txt_Usu_Plataforma.Text
            ObjRRHH.Password_Plataforma = Txt_Pass_Plataforma.Text
            ObjRRHH.Estado_Plataforma = Drl_EstadoP.SelectedItem.Text
            ObjRRHH.Formato = Txt_Formato.Text
            ObjRRHH.Usu_CRM = CType(Session("permisos"), clsusuario).usuario
            ObjRRHH.Estado_General = Nothing
            ObjRRHH.Ingresar_Plataforma()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro Exitoso"
            Limpiar_herramientas()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Consultar_Click(sender As Object, e As EventArgs) Handles Btn_Consultar.Click
        Try
            If Txt_Codigo.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el codigo del usuario para consultar"
                Exit Sub
            End If
            ObjRRHH.codigo = Txt_Codigo.Text
            ObjRRHH.Validacion = "2"
            If ObjRRHH.Consulta_Estados_Usu_Pass().Tables(0).Rows.Count > 0 Then
                Pnl_Message.CssClass = Nothing
                lblmsg.Text = Nothing
                Txt_Codigo.Enabled = False
                Txt_Area.Text = ObjRRHH.area
                Txt_Cedula.Text = ObjRRHH.documento
                Txt_Codigo.Text = ObjRRHH.codigo
                Txt_Grupo.Text = ObjRRHH.grupo
                Txt_Nombre.Text = ObjRRHH.nombres
                If ObjRRHH.Fecha_Acta <> Nothing Then
                    Txt_Fehca_Acta.Text = ObjRRHH.Fecha_Acta
                    Txt_Fehca_Acta.Enabled = False
                    Pnl_Fecha_Acta.Visible = False
                Else
                    Pnl_Fecha_Acta.Visible = True
                    Txt_Fehca_Acta.Enabled = True
                    Txt_Fehca_Acta.Text = "PDT. ENTREGAR"
                End If
                Session("RegDatosUsu.aspx.vb") = ObjRRHH
            Else
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> El usuario no existe"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_ConsultaGeneral_Click(sender As Object, e As EventArgs) Handles Btn_ConsultaGeneral.Click
        Try
            Detalle.Visible = False
            DtgSolicitudes.DataSource = Nothing
            DtgSolicitudes.DataBind()
            DtgCredenciales.DataSource = Nothing
            DtgCredenciales.DataBind()
            lblcuentaCredenciales.Text = Nothing
            If Txt_ConsultaCodigo.Text = Nothing And Drl_Plataforma2.SelectedIndex = 0 And Drl_PlataformaRed2.SelectedIndex = 0 And Drl_PlataformaE2.SelectedIndex = 0 And Txt_Inicio.Text = Nothing And Txt_Fin.Text = Nothing Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un filtro de consulta"
                colores()
                Exit Sub
            End If
            ObjRRHH.codigo = Txt_ConsultaCodigo.Text
            If Txt_Inicio.Text <> Nothing Then
                Try
                    ObjRRHH.fcini = Date.Parse(Txt_Inicio.Text)
                Catch ex As Exception
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> la fecha inicial no tiene el formato correcto"
                    colores()
                    Exit Sub
                End Try
            End If
            If Txt_Fin.Text <> Nothing Then
                Try
                    ObjRRHH.fcfin = Date.Parse(Txt_Fin.Text)
                Catch ex As Exception
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> la fecha final no tiene el formato correcto"
                    colores()
                    Exit Sub
                End Try
            End If

            If Txt_Inicio.Text <> Nothing And Txt_Fin.Text <> Nothing Then
                If Date.Parse(Txt_Inicio.Text) > Date.Parse(Txt_Fin.Text) Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> el rango de fechas debe ser racional"
                    colores()
                    Exit Sub
                End If
            End If
            If Drl_Plataforma2.SelectedIndex <> 0 And Drl_Plataforma2.Visible = True Then
                ObjRRHH.Plataforma = Drl_Plataforma2.SelectedValue
            ElseIf Drl_PlataformaRed2.SelectedIndex <> 0 And Drl_PlataformaRed2.Visible = True Then
                ObjRRHH.Plataforma = Drl_PlataformaRed2.SelectedValue
            End If
            If Drl_PlataformaE2.SelectedIndex <> 0 Then
                ObjRRHH.Estado_Plataforma = Drl_PlataformaE2.SelectedItem.Text
            End If
            Session("DatasetCredenciales") = ObjRRHH.Consultar_credenciales
            If Session("DatasetCredenciales").Rows.Count > 0 Then
                DtgCredenciales.DataSource = Session("DatasetCredenciales")
                DtgCredenciales.DataBind()
                lblcuentaCredenciales.Text = Session("DatasetCredenciales").Rows.Count
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> no se encontraron registros que coincidan con su criterio de búsqueda"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_Actualizacion_Click(sender As Object, e As EventArgs) Handles Btn_Actualizacion.Click
        Try
            Detalle.Visible = False
            If Txt_Codigo.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el codigo del usuario y  consultelo"
                Exit Sub
            End If
            If Txt_Cod_Asignacion.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Realice un filtro de consulta y seleccione un plataforma"
                Exit Sub
            End If
            If Drl_EstadoP.SelectedItem.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione el estado de la plataforma"
                Exit Sub
            End If
            If Txt_Usu_Plataforma.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione el usuario de la plataforma"
                Exit Sub
            End If
            If Txt_Pass_Plataforma.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione el password de la plataforma"
                Exit Sub
            End If
            ObjRRHH.Codigo_Atuliza = Txt_Cod_Asignacion.Text
            ObjRRHH.Estado_Plataforma = Drl_EstadoP.SelectedItem.Text
            ObjRRHH.Password_Plataforma = Txt_Pass_Plataforma.Text
            ObjRRHH.Usuario_Plataforma = Txt_Usu_Plataforma.Text
            ObjRRHH.Estado_General = Nothing
            ObjRRHH.Formato = Txt_Formato.Text
            If Drl_PlataformaRed.SelectedIndex <> 0 Then
                ObjRRHH.Plataforma = Drl_PlataformaRed.SelectedValue
            ElseIf Drl_Plataforma.SelectedIndex <> 0 Then
                ObjRRHH.Plataforma = Drl_Plataforma.SelectedValue
            End If
            ObjRRHH.idusuario = CType(Session("permisos"), clsusuario).usuario
            ObjRRHH.codigo = Txt_Codigo.Text

            ObjRRHH.Actualizar_Plataforma()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> La plataforma ha sido actualizada"
            Limpiar_herramientas()
            Btn_Actualizacion.Visible = False
            Btn_Cancelar.Visible = False
            Btn_guardar.Visible = True
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_xls_Click(sender As Object, e As EventArgs) Handles Btn_xls.Click
        Try
            If DtgCredenciales.Rows.Count = 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Realice una consulta"
                Exit Sub
            End If
            Exportarxls()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Try
            Btn_Actualizacion.Visible = False
            Btn_Cancelar.Visible = False
            Btn_guardar.Visible = True
            DtgCredenciales.DataSource = Session("DatasetCredenciales")
            DtgCredenciales.DataBind()
            DtgDetalle.DataSource = Nothing
            Detalle.Visible = False
            DtgSolicitudes.DataSource = Nothing
            DtgSolicitudes.Visible = False
            Limpiar_herramientas()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Public Sub colores()
        If DtgCredenciales.Rows.Count <> Nothing Then
            DtgCredenciales.DataSource = Session("DatasetCredenciales")
            DtgCredenciales.DataBind()
        End If
    End Sub
    Public Sub Exportarxls()
        Try
            Dim sb As New StringBuilder
            Dim sw As New StringWriter(sb)
            Dim htw As New HtmlTextWriter(sw)
            Dim pagina As Page = New Page
            Dim form = New HtmlForm
            Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
            pagina.EnableEventValidation = False
            pagina.DesignerInitialize()
            pagina.Controls.Add(form)
            form.Controls.Add(DtgCredenciales)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True

            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=data.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False

        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function

    Protected Sub DtgCredenciales_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles DtgCredenciales.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "ACTIVO" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#B3C556")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "ELIMINADO" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#81BEF7")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "INACTIVADO" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#81BEF7")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "PDT. CREAR" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#F71717")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "PDT. ELIMINAR" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#F71717")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "PDT. HABILITAR" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#F71717")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If

                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "PDT. MODIFICAR" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#F71717")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "HABILITANDO" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#FE9F07")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "HABILITANDO AC" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#FE9F07")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "AC INHABILITADO" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#F71717")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "BLOQUEADO" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#F71717")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "DESBLOQUEANDO" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#FE9F07")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If

            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub DtgDetalle_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles DtgDetalle.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then


                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "ACTIVO" Then
                    e.Row.Cells(3).BackColor = Drawing.Color.FromName("#B3C556")
                    e.Row.Cells(3).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "ELIMINADO" Then
                    e.Row.Cells(3).BackColor = Drawing.Color.FromName("#81BEF7")
                    e.Row.Cells(3).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "INACTIVADO" Then
                    e.Row.Cells(3).BackColor = Drawing.Color.FromName("#81BEF7")
                    e.Row.Cells(3).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "PDT. CREAR" Then
                    e.Row.Cells(3).BackColor = Drawing.Color.FromName("#F71717")
                    e.Row.Cells(3).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "PDT. ELIMINAR" Then
                    e.Row.Cells(3).BackColor = Drawing.Color.FromName("#F71717")
                    e.Row.Cells(3).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "PDT. HABILITAR" Then
                    e.Row.Cells(3).BackColor = Drawing.Color.FromName("#F71717")
                    e.Row.Cells(3).ForeColor = Drawing.Color.Black
                End If

                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "PDT. MODIFICAR" Then
                    e.Row.Cells(3).BackColor = Drawing.Color.FromName("#F71717")
                    e.Row.Cells(3).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "HABILITANDO" Then
                    e.Row.Cells(3).BackColor = Drawing.Color.FromName("#FE9F07")
                    e.Row.Cells(3).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "HABILITANDO AC" Then
                    e.Row.Cells(3).BackColor = Drawing.Color.FromName("#FE9F07")
                    e.Row.Cells(3).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "AC INHABILITADO" Then
                    e.Row.Cells(3).BackColor = Drawing.Color.FromName("#F71717")
                    e.Row.Cells(3).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "BLOQUEADO" Then
                    e.Row.Cells(3).BackColor = Drawing.Color.FromName("#F71717")
                    e.Row.Cells(3).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "DESBLOQUEANDO" Then
                    e.Row.Cells(3).BackColor = Drawing.Color.FromName("#FE9F07")
                    e.Row.Cells(3).ForeColor = Drawing.Color.Black
                End If

            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub

    Protected Sub DtgCredenciales_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles DtgCredenciales.RowCommand
        Try
            If e.CommandName = "Seleccion" Then
                'DtgCredenciales_RowDataBound(1, Nothing)
                Drl_Plataforma.Visible = True
                Drl_Plataforma.Enabled = True
                Drl_PlataformaRed.Visible = True
                Drl_PlataformaRed.Enabled = True
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                ObjRRHH.Codigo_Atuliza = DtgCredenciales.Rows(index).Cells(0).Text
                ObjRRHH.Validacion = 9
                ObjRRHH.Consulta_Estados_Usu_Pass()
                ObjRRHH.Validacion = 11
                DtgSolicitudes.Visible = True
                If ObjRRHH.Plataforma = 75 Then
                    DtgSolicitudes.Columns(DtgSolicitudes.Columns.Count - 1).Visible = True
                Else
                    DtgSolicitudes.Columns(DtgSolicitudes.Columns.Count - 1).Visible = False
                End If
                DtgSolicitudes.DataSource = ObjRRHH.Consulta_Estados_Usu_Pass()
                DtgSolicitudes.DataBind()
                If ObjRRHH.Consulta_Estados_Usu_Pass().Tables(0).Rows.Count > 0 Then
                    ObjRRHH.Validacion = 14
                    If ObjRRHH.Consulta_Estados_Usu_Pass().Tables(0).Rows.Count > 0 Then
                        DtgDetalle.DataSource = ObjRRHH.Consulta_Estados_Usu_Pass()
                        DtgDetalle.DataBind()
                        Detalle.Visible = True
                    Else
                        Detalle.Visible = False
                    End If
                End If
                ObjRRHH.Validacion = 9
                If ObjRRHH.Consulta_Estados_Usu_Pass().Tables(0).Rows.Count > 0 Then
                    Btn_guardar.Visible = False
                    Btn_Actualizacion.Visible = True
                    Btn_Cancelar.Visible = True
                    Txt_Codigo.Enabled = False
                    Txt_Area.Text = ObjRRHH.area
                    Txt_Cedula.Text = ObjRRHH.documento
                    Txt_Codigo.Text = ObjRRHH.codigo
                    If ObjRRHH.Fecha_Acta <> Nothing Then
                        Txt_Fehca_Acta.Text = ObjRRHH.Fecha_Acta
                        Txt_Fehca_Acta.Enabled = False
                        Pnl_Fecha_Acta.Visible = False
                    Else
                        Pnl_Fecha_Acta.Visible = True
                        Txt_Fehca_Acta.Enabled = True
                        Txt_Fehca_Acta.Text = "PDT. ENTREGAR"
                    End If
                    Session("RegDatosUsu.aspx.vb") = ObjRRHH
                    Txt_Grupo.Text = ObjRRHH.grupo
                    Txt_Nombre.Text = ObjRRHH.nombres
                    If ObjRRHH.apellidos = "Credenciales" Then
                        Drl_Plataforma.SelectedValue = ObjRRHH.Plataforma
                        Drl_Plataforma_SelectedIndexChanged(1, Nothing)
                        Drl_Plataforma.Enabled = False
                    ElseIf ObjRRHH.apellidos = "Plataforma_Red" Then
                        Drl_PlataformaRed.SelectedValue = ObjRRHH.Plataforma
                        Drl_PlataformaRed.Enabled = False
                        Drl_PlataformaRed_SelectedIndexChanged(1, Nothing)
                    End If
                    Drl_EstadoP.SelectedValue = ObjRRHH.Estado_Plataforma
                    Txt_Cod_Asignacion.Text = ObjRRHH.Codigo_Atuliza
                    Txt_Pass_Plataforma.Text = ObjRRHH.Password_Plataforma
                    Txt_Usu_Plataforma.Text = ObjRRHH.Usuario_Plataforma
                    DtgCredenciales.DataSource = Nothing
                    DtgCredenciales.DataBind()
                    lblcuentaCredenciales.Text = ""
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub DtgSolicitudes_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles DtgSolicitudes.PageIndexChanging
        Try
            DtgSolicitudes.PageIndex = e.NewPageIndex
            DtgSolicitudes.DataSource = ObjRRHH.Consulta_Estados_Usu_Pass()
            DtgSolicitudes.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub DtgCredenciales_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles DtgCredenciales.PageIndexChanging
        Try
            DtgCredenciales.PageIndex = e.NewPageIndex
            DtgCredenciales.DataSource = Session("DatasetCredenciales")
            DtgCredenciales.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub Drl_Plataforma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Plataforma.SelectedIndexChanged
        Try
            If Drl_Plataforma.SelectedItem.Text <> "- Seleccione -" Then
                Pnl_Drl_PlataformaRed.Visible = False

            ElseIf Drl_Plataforma.SelectedItem.Text = "- Seleccione -" Then
                With Drl_PlataformaE2
                    ObjRRHH.Plataforma = Drl_Plataforma.SelectedItem.Text
                    ObjRRHH.Validacion = 4
                    .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                    .DataTextField = "Nombre"
                    .DataValueField = "Nombre"
                    .DataBind()
                End With
                Pnl_Drl_PlataformaRed.Visible = True
            End If
            ObjRRHH.Plataforma = Drl_Plataforma.SelectedItem.Text
            With Drl_EstadoP
                ObjRRHH.Validacion = 4
                .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            colores()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Drl_PlataformaRed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_PlataformaRed.SelectedIndexChanged
        Try
            If Drl_PlataformaRed.SelectedItem.Text <> "- Seleccione -" Then
                Pnl_Drl_Plataforma.Visible = False
                With Drl_EstadoP
                    ObjRRHH.Validacion = 6
                    .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                    .DataTextField = "Nombre"
                    .DataValueField = "Nombre"
                    .DataBind()
                End With
            Else
                Pnl_Drl_Plataforma.Visible = True
            End If
            colores()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Drl_Plataforma2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Plataforma2.SelectedIndexChanged
        Try
            If Drl_Plataforma2.SelectedItem.Text <> "- Seleccione -" Then
                Pnl_Drl_PlataformaRed2.Visible = False
            ElseIf Drl_Plataforma2.SelectedItem.Text = "- Seleccione -" Then
                With Drl_PlataformaE2
                    ObjRRHH.Plataforma = "Red"
                    ObjRRHH.Validacion = 4
                    .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                    .DataTextField = "Nombre"
                    .DataValueField = "Nombre"
                    .DataBind()
                End With
                Pnl_Drl_PlataformaRed2.Visible = True
                colores()
                Exit Sub
            End If
            ObjRRHH.Plataforma = Drl_Plataforma2.SelectedItem.Text
            With Drl_PlataformaE2
                ObjRRHH.Validacion = 4
                .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                .DataTextField = "Nombre"
                .DataValueField = "cod_estado_usu"
                .DataBind()
            End With
            colores()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Drl_PlataformaRed2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_PlataformaRed2.SelectedIndexChanged
        Try
            If Drl_PlataformaRed2.SelectedItem.Text <> "- Seleccione -" Then
                Pnl_Drl_Plataforma2.Visible = False
                With Drl_PlataformaE2
                    ObjRRHH.Validacion = 6
                    .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                    .DataTextField = "Nombre"
                    .DataValueField = "cod_estado_usu"
                    .DataBind()
                End With
            Else
                Pnl_Drl_Plataforma2.Visible = True
            End If
            colores()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class