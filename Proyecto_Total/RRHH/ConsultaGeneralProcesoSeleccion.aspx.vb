Imports System.IO

Public Class ConsultaGeneralProcesoSeleccion
    Inherits System.Web.UI.Page
    Dim ObjProcesoSeleccion As New clsProcesoSeleccion

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnConsultarProcesoSeleccion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultarProcesoSeleccion.Click
        Try
            ''Limpio las dtg para no dejar datos de consultas anteriores
            dtgAspirantes.DataSource = Nothing
            dtgAspirantes.DataBind()
            LblCantidadAspirantes.Text = ""
            dtgEstudios.DataSource = Nothing
            dtgEstudios.DataBind()
            LblCantidadEstudios.Text = ""
            dtgExperienciaLab.DataSource = Nothing
            dtgExperienciaLab.DataBind()
            LblCantidadExpeLaboral.Text = ""
            dtgProcesosAspirante.DataSource = Nothing
            dtgProcesosAspirante.DataBind()
            LblCantidadProcesosAspirante.Text = ""

            If TxtCod_Proceso_Seleccion.Text <> Nothing Then
                ObjProcesoSeleccion.Cod_Proceso_Seleccion = TxtCod_Proceso_Seleccion.Text
                ''Valido por si consultan con un proceso de seleccion con 0
                If TxtCod_Proceso_Seleccion.Text = "0" Then
                    ObjProcesoSeleccion.Cod_Proceso_Seleccion = -1
                End If
                dtgAspirantes.DataSource = ObjProcesoSeleccion.Consulta_General_Aspirantes()
                dtgAspirantes.DataBind()
                LblCantidadAspirantes.Text = ObjProcesoSeleccion.Cantidad
                ''Envio nuevamente el codigo de consulta
                ObjProcesoSeleccion.Cod_Proceso_Seleccion = TxtCod_Proceso_Seleccion.Text
            End If
            If drlEstadoProcesoSeleccion.Text <> "0" Then
                ObjProcesoSeleccion.Estado = drlEstadoProcesoSeleccion.Text
            End If
            If (TxtFecha_Inicio.Text <> Nothing) Or TxtFecha_Fin.Text <> Nothing Then
                ObjProcesoSeleccion.Fecha_Inicio = TxtFecha_Inicio.Text
                ObjProcesoSeleccion.Fecha_Fin = TxtFecha_Fin.Text
            End If

            dtgGeneral.DataSource = ObjProcesoSeleccion.Consulta_General_Proceso_Seleccion
            dtgGeneral.DataBind()
            LblCantidadProcesosSeleccion.Text = ObjProcesoSeleccion.Cantidad
            TxtFecha_Inicio.Text = ""
            TxtFecha_Fin.Text = ""
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try

        ''Validacion para exportar a excel
        If LblCantidadAspirantes.Text = "" Or LblCantidadAspirantes.Text = "0" Then
            btnxls.Visible = False
        Else
            btnxls.Visible = True
        End If
    End Sub

    Protected Sub dtgGeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgGeneral.PageIndexChanging
        dtgGeneral.DataSource = ObjProcesoSeleccion.Consulta_General_Proceso_Seleccion()
        dtgGeneral.PageIndex = e.NewPageIndex
        dtgGeneral.DataBind()
    End Sub

    Protected Sub BtnConsultaAspirante_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultaAspirante.Click
        Try
            If TxtId_Aspirante.Text <> Nothing Then
                ObjProcesoSeleccion.Id_Aspirante = TxtId_Aspirante.Text
                ''consulta estudios del aspirante
                dtgEstudios.DataSource = ObjProcesoSeleccion.Consulta_General_Estudio()
                dtgEstudios.DataBind()
                LblCantidadEstudios.Text = ObjProcesoSeleccion.Cantidad
                ''Consulta Esperiencia laboral del aspirante
                dtgExperienciaLab.DataSource = ObjProcesoSeleccion.Consultar_General_ExperienciaLab()
                dtgExperienciaLab.DataBind()
                LblCantidadExpeLaboral.Text = ObjProcesoSeleccion.Cantidad
                ''Consulta los Procesos del aspirnate
                dtgProcesosAspirante.DataSource = ObjProcesoSeleccion.Consulta_General_Procesos_Aspirante()
                dtgProcesosAspirante.DataBind()
                LblCantidadProcesosAspirante.Text = ObjProcesoSeleccion.Cantidad
            End If
            If drlEstado.Text <> "Opcion" Then
                ObjProcesoSeleccion.Estado = drlEstado.Text
            End If
            If drlAlgunProceso.Text <> "Opcion" Then
                ObjProcesoSeleccion.Fk_Cod_Proceso_Seleccion = drlAlgunProceso.Text
            Else
                ObjProcesoSeleccion.Fk_Cod_Proceso_Seleccion = -1
            End If
            dtgAspirantes.DataSource = ObjProcesoSeleccion.Consulta_General_Aspirantes()
            dtgAspirantes.DataBind()
            LblCantidadAspirantes.Text = ObjProcesoSeleccion.Cantidad

        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
        ''Validacion para exportar a excel
        If LblCantidadAspirantes.Text = "" Or LblCantidadAspirantes.Text = "0" Then
            btnxls.Visible = False
        Else
            btnxls.Visible = True
        End If
    End Sub

    Protected Sub dtgAspirantes_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgAspirantes.PageIndexChanging
        dtgAspirantes.DataSource = ObjProcesoSeleccion.Consulta_General_Aspirantes()
        dtgAspirantes.PageIndex = e.NewPageIndex
        dtgAspirantes.DataBind()
    End Sub

    Protected Sub dtgEstudios_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgEstudios.PageIndexChanging
        ObjProcesoSeleccion.Id_Aspirante = TxtId_Aspirante.Text
        dtgEstudios.DataSource = ObjProcesoSeleccion.Consulta_General_Estudio()
        dtgEstudios.DataBind()
    End Sub

    Protected Sub dtgExperienciaLab_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgExperienciaLab.PageIndexChanging
        ObjProcesoSeleccion.Id_Aspirante = TxtId_Aspirante.Text
        dtgExperienciaLab.DataSource = ObjProcesoSeleccion.Consultar_General_ExperienciaLab()
        dtgExperienciaLab.DataBind()
    End Sub

    Protected Sub dtgProcesosAspirante_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgProcesosAspirante.PageIndexChanging
        ObjProcesoSeleccion.Id_Aspirante = TxtId_Aspirante.Text
        dtgProcesosAspirante.DataSource = ObjProcesoSeleccion.Consulta_General_Procesos_Aspirante()
        dtgProcesosAspirante.DataBind()
    End Sub
    Sub crearexcel()
        Dim sb As New StringBuilder
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim form As New HtmlForm
        Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"

        dtgAspirantes.EnableViewState = False

        pagina.EnableEventValidation = False
        pagina.DesignerInitialize()
        pagina.Controls.Add(form)
        form.Controls.Add(dtgAspirantes)
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
    End Sub
    Protected Sub btnxls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnxls.Click
        Try
            crearexcel()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
            lblmsg.ForeColor = Drawing.Color.Red
        End Try
    End Sub
End Class