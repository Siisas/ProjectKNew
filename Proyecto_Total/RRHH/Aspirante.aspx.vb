Imports System.IO

Public Class Aspirante
    Inherits System.Web.UI.Page

    Dim ObjPS As New clsProcesoSeleccion

    Dim Registrorep As Boolean = False
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Obtengo los datos del usuario'
        Try
            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                Cargardrl()
                Consulta_Aspirante()
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
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Public Sub Cargardrl()
        With drlEmpresa
            .DataSource = ObjPS.Consulta_Empresa
            .DataTextField = "Nombre"
            .DataValueField = "Cod_Empresa"
            .DataBind()
        End With
        With drlPerfil
            .DataSource = ObjPS.Consulta_Perfil
            .DataTextField = "Nombre"
            .DataValueField = "Cod_Perfil_PS"
            .DataBind()
        End With
        With drlCargoAspira
            .DataSource = ObjPS.Consulta_Cargo_Aspira
            .DataTextField = "Nombre"
            .DataValueField = "Cod_Cargo_Aspira"
            .DataBind()
        End With
        With drlMedioDifucion
            .DataSource = ObjPS.Consulta_Medio_Difucion
            .DataTextField = "Nombre"
            .DataValueField = "Cod_Medio_Difucion"
            .DataBind()
        End With

        ''Consultas
        With drlEmpresa_Consulta
            .DataSource = ObjPS.Consulta_Empresa
            .DataTextField = "Nombre"
            .DataValueField = "Cod_Empresa"
            .DataBind()
        End With
        With drlPerfil_Consulta
            .DataSource = ObjPS.Consulta_Perfil
            .DataTextField = "Nombre"
            .DataValueField = "Cod_Perfil_PS"
            .DataBind()
        End With
        With drlCargoAspira_Consulta
            .DataSource = ObjPS.Consulta_Cargo_Aspira
            .DataTextField = "Nombre"
            .DataValueField = "Cod_Cargo_Aspira"
            .DataBind()
        End With
    End Sub

    Public Sub Consulta_Aspirante()
        Try
            dtgGeneral.DataSource = ObjPS.Consultar_Aspirantes()
            dtgGeneral.DataBind()
            LblCuenta_Aspirantes.Text = ObjPS.Cantidad
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Dim Tabla As DataSet
    Dim Cantidad As Integer
    Public Sub ConsultaAspirantesValidacion()
        Try
            ObjPS.Id_Aspirante = TxtId_Aspirante.Text
            Tabla = ObjPS.Consultar_Aspirantes_Validacion()
            Cantidad = Tabla.Tables.Count.ToString()
            If Cantidad > 0 Then
                Registrorep = True
            Else
                'lblmsg.Text="No hay ningun Aspirante con esta identificacion: " & TxtConsulta_Id_Aspirante.Text
                Registrorep = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnNuevoCargo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNuevoCargo.Click
        Try
            ObjPS.Nombre_Aspirante = TxtNuevoCargo.Text
            ObjPS.Ingresar_Nuevo_Cargo()
            Cargardrl()
            TxtNuevoCargo.Text = ""
            lblmsg.Text = "Se a ingresado el nuevo cargo "
        Catch ex As Exception
            lblmsg.Text = "Se prodijo error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnNuevaEmpresa_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNuevaEmpresa.Click
        Try
            ObjPS.Nombre_Aspirante = TxtNuevaEmpresa.Text
            ObjPS.Ingresar_Nueva_Empresa()
            Cargardrl()
            TxtNuevaEmpresa.Text = ""
            lblmsg.Text = "Se a ingresado la nueva empresa "
        Catch ex As Exception
            lblmsg.Text = "Se prodijo error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnNuevoMD_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNuevoMD.Click
        Try
            ObjPS.Nombre_Aspirante = TxtNuevoMD.Text
            ObjPS.Ingresar_Nuevo_MD()
            Cargardrl()
            TxtNuevoMD.Text = ""
            lblmsg.Text = "Se a ingresado el nuevo medio de difucion "
        Catch ex As Exception
            lblmsg.Text = "Se prodijo error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnNuevoPerfil_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNuevoPerfil.Click
        Try
            ObjPS.Nombre_Aspirante = TxtNuevoPerfil.Text
            ObjPS.Ingresar_Nuevo_Perfil()
            Cargardrl()
            TxtNuevoPerfil.Text = ""
            lblmsg.Text = "Se a ingresado el nuevo perfil"
        Catch ex As Exception
            lblmsg.Text = "Se prodijo error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGuardar.Click
        Try
            If TxtId_Aspirante.Text = "" Then
                lblmsg.Text = "Ingrese una Identifiacion"
                Exit Sub
            End If
            ConsultaAspirantesValidacion()
            If (Registrorep = True) Then
                lblmsg.Text = "Ya existe un registro con esta identificacion: " & TxtId_Aspirante.Text
                TxtId_Aspirante.Text = ""
            Else
                If TxtNombre.Text = "" Then
                    lblmsg.Text = "Ingrese un Nombre"
                    Exit Sub
                End If
                If TxtApellido.Text = "" Then
                    lblmsg.Text = "Ingrese un Apellido"
                    Exit Sub
                End If
                If drlEstudiando.Text = "1" Then
                    lblmsg.Text = "Seleccione si el aspirante estudia"
                    Exit Sub
                End If
                If drlEmpresa.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una empresa"
                    Exit Sub
                End If
                If drlPerfil.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione un perfil"
                    Exit Sub
                End If
                If drlCargoAspira.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione un cargo para el aspirante"
                    Exit Sub
                End If
                If drlMedioDifucion.Text = "1" Then
                    lblmsg.Text = "Seleccione un medio de difucion"
                    Exit Sub
                End If

                ObjPS.Id_Usuario = lblusuario.Text
                ObjPS.Fecha_Filtro = TxtFecha_Filtro.Text
                ObjPS.Fecha_Entrevista = TxtFecha_Entrevista.Text
                ObjPS.AM_PM = drlAM_PM.Text
                ObjPS.Fk_Cod_Empresa = drlEmpresa.Text
                ObjPS.Id_Aspirante = TxtId_Aspirante.Text
                ObjPS.Nombre_Aspirante = TxtNombre.Text
                ObjPS.Apellido = TxtApellido.Text
                ObjPS.Telefono1 = TxtTelefono1.Text
                ObjPS.Telefono2 = TxtTelefono2.Text
                ObjPS.Celular1 = TxtCelular1.Text
                ObjPS.Celular2 = TxtCelular2.Text
                ObjPS.Fk_Cod_Perfil_PS = drlPerfil.Text
                ObjPS.Fk_Cod_Cargo_Aspira = drlCargoAspira.Text
                ObjPS.Estado = drlEstado.Text
                ObjPS.Estudia = drlEstudiando.Text
                ObjPS.Experiencia = drlExperiencia.Text
                ObjPS.Carrera = TxtCarrera.Text
                ObjPS.Fk_Cod_Medio_Difucion = drlMedioDifucion.Text
                ObjPS.Convocado = drlConvocado.Text
                ObjPS.Asiste_Entrevista = drlAsiste_Entrevista.Text
                ObjPS.Promedio_Entrevista = TxtPromedio_Entrevista.Text
                ObjPS.Promedio_Optimo = TxtPromedio_Optimo.Text
                ObjPS.Promedio_Digitacion = TxtPromedio_Digitacion.Text
                ObjPS.Promedio_C_Lectura = TxtPromedio_C_Lectura.Text
                ObjPS.Promedio_Ortografia = TxtPromedio_Ortografia.Text
                ObjPS.Test_Wartegg = TxtTest_Wartegg.Text
                ObjPS.PF_16 = Txt16_PF.Text
                ObjPS.Assessment_Center = TxtAssessment_Center.Text
                ObjPS.Diligencias = TxtDiligencias.Text
                ObjPS.Resultado_General = TxtResultado_General.Text
                ObjPS.Preseleccionado = drlPreseleccionado.Text

                ObjPS.IngresarAspirante()


                lblmsg.Text = "Datos Ingresados"


                Limpia()
            End If
        Catch ex As Exception
            lblmsg.Text = "Verifique los datos Error: " & ex.Message
        End Try
    End Sub

    Protected Sub BtnConsultaActualiza_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultaActualiza.Click
        Try
            If TxtId_Aspirante_Actualiza.Text = "" Then
                lblmsg.Text = "Ingrese la Identificacion del Aspirante que desea actualizar"
                Exit Sub
            End If

            Dim dts As New DataSet

            ObjPS.Id_Aspirante = TxtId_Aspirante_Actualiza.Text
            dts = ObjPS.Consultar_Aspirantes_Actualizar()

            TxtFecha_Filtro.Text = ObjPS.Fecha_Filtro
            TxtFecha_Entrevista.Text = ObjPS.Fecha_Entrevista
            drlAM_PM.Text = ObjPS.AM_PM
            drlEmpresa.Text = ObjPS.Fk_Cod_Empresa
            TxtId_Aspirante.Text = ObjPS.Id_Aspirante
            TxtNombre.Text = ObjPS.Nombre_Aspirante
            TxtApellido.Text = ObjPS.Apellido
            TxtTelefono1.Text = ObjPS.Telefono1
            TxtTelefono2.Text = ObjPS.Telefono2
            TxtCelular1.Text = ObjPS.Celular1
            TxtCelular2.Text = ObjPS.Celular2
            drlPerfil.Text = ObjPS.Fk_Cod_Perfil_PS
            drlCargoAspira.Text = ObjPS.Fk_Cod_Cargo_Aspira
            drlEstado.Text = ObjPS.Estado
            drlEstudiando.Text = ObjPS.Estudia
            drlExperiencia.Text = ObjPS.Experiencia
            TxtCarrera.Text = ObjPS.Carrera
            drlMedioDifucion.Text = ObjPS.Fk_Cod_Medio_Difucion
            drlConvocado.Text = ObjPS.Convocado
            drlAsiste_Entrevista.Text = ObjPS.Asiste_Entrevista
            TxtPromedio_Entrevista.Text = ObjPS.Promedio_Entrevista
            TxtPromedio_Optimo.Text = ObjPS.Promedio_Optimo
            TxtPromedio_Digitacion.Text = ObjPS.Promedio_Digitacion
            TxtPromedio_C_Lectura.Text = ObjPS.Promedio_C_Lectura
            TxtPromedio_Ortografia.Text = ObjPS.Promedio_Ortografia
            TxtTest_Wartegg.Text = ObjPS.Test_Wartegg
            Txt16_PF.Text = ObjPS.PF_16
            TxtAssessment_Center.Text = ObjPS.Assessment_Center
            TxtDiligencias.Text = ObjPS.Diligencias
            TxtResultado_General.Text = ObjPS.Resultado_General
            drlPreseleccionado.Text = ObjPS.Preseleccionado

            If dts.Tables(0).Rows.Count > 0 Then
                BtnValidar.Visible = True
                BtnActualizacion.Visible = True
                BtnConsultaActualiza.Visible = False
                TxtId_Aspirante_Actualiza.Enabled = False
                lblmsg.Text = ""
            Else
                lblmsg.Text = "Verifique la consulta, ya que no se encontraron registros con el filtro indicado"
            End If
        Catch ex As Exception
            lblmsg.Text = "Se preseto error: " + ex.Message
        End Try
    End Sub

    Public Sub Limpia()
        TxtFecha_Filtro.Text = ""
        TxtFecha_Entrevista.Text = ""
        drlAM_PM.Text = "- Seleccione -"
        TxtId_Aspirante.Text = ""
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtTelefono1.Text = ""
        TxtTelefono2.Text = ""
        TxtCelular1.Text = ""
        TxtCelular2.Text = ""
        drlEstado.Text = "- Seleccione -"
        drlEstudiando.Text = "- Seleccione -"
        drlExperiencia.Text = "- Seleccione -"
        TxtCarrera.Text = ""
        drlConvocado.Text = "- Seleccione -"
        drlAsiste_Entrevista.Text = "- Seleccione -"
        TxtPromedio_Entrevista.Text = ""
        TxtPromedio_Optimo.Text = ""
        TxtPromedio_Digitacion.Text = ""
        TxtPromedio_C_Lectura.Text = ""
        TxtPromedio_Ortografia.Text = ""
        TxtTest_Wartegg.Text = ""
        Txt16_PF.Text = ""
        TxtAssessment_Center.Text = ""
        TxtDiligencias.Text = ""
        TxtResultado_General.Text = ""
        drlPreseleccionado.Text = "- Seleccione -"
        BtnValidar.Visible = False
        BtnActualizacion.Visible = False
        BtnConsultaActualiza.Visible = True
        TxtId_Aspirante_Actualiza.Enabled = True
        Cargardrl()
        Consulta_Aspirante()
    End Sub

    Protected Sub BtnValidar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnValidar.Click
        Try
            BtnValidar.Visible = False
            BtnActualizacion.Visible = False
            BtnConsultaActualiza.Visible = True
            TxtId_Aspirante_Actualiza.Enabled = True
            Limpia()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnActualizacion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnActualizacion.Click
        Try
            If TxtId_Aspirante.Text = "" Then
                lblmsg.Text = "Ingrese una Identifiacion"
                Exit Sub
            End If
            ConsultaAspirantesValidacion()
            If (Registrorep = True) Then
                lblmsg.Text = "Ya existe un registro con esta identificacion: " & TxtId_Aspirante.Text
                TxtId_Aspirante.Text = ""
            Else
                If TxtNombre.Text = "" Then
                    lblmsg.Text = "Ingrese un Nombre"
                    Exit Sub
                End If
                If TxtApellido.Text = "" Then
                    lblmsg.Text = "Ingrese un Apellido"
                    Exit Sub
                End If
                If drlEstudiando.Text = "1" Then
                    lblmsg.Text = "Seleccione si el aspirante estudia"
                    Exit Sub
                End If
                If drlEmpresa.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una empresa"
                    Exit Sub
                End If
                If drlPerfil.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione un perfil"
                    Exit Sub
                End If
                If drlCargoAspira.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione un cargo para el aspirante"
                    Exit Sub
                End If
                If drlMedioDifucion.Text = "1" Then
                    lblmsg.Text = "Seleccione un medio de difucion"
                    Exit Sub
                End If

                ObjPS.Id_Usuario = lblusuario.Text
                ObjPS.Fecha_Filtro = TxtFecha_Filtro.Text
                ObjPS.Fecha_Entrevista = TxtFecha_Entrevista.Text
                ObjPS.AM_PM = drlAM_PM.Text
                ObjPS.Fk_Cod_Empresa = drlEmpresa.Text
                ObjPS.Id_Aspirante = TxtId_Aspirante.Text
                ObjPS.Nombre_Aspirante = TxtNombre.Text
                ObjPS.Apellido = TxtApellido.Text
                ObjPS.Telefono1 = TxtTelefono1.Text
                ObjPS.Telefono2 = TxtTelefono2.Text
                ObjPS.Celular1 = TxtCelular1.Text
                ObjPS.Celular2 = TxtCelular2.Text
                ObjPS.Fk_Cod_Perfil_PS = drlPerfil.Text
                ObjPS.Fk_Cod_Cargo_Aspira = drlCargoAspira.Text
                ObjPS.Estado = drlEstado.Text
                ObjPS.Estudia = drlEstudiando.Text
                ObjPS.Experiencia = drlExperiencia.Text
                ObjPS.Carrera = TxtCarrera.Text
                ObjPS.Fk_Cod_Medio_Difucion = drlMedioDifucion.Text
                ObjPS.Convocado = drlConvocado.Text
                ObjPS.Asiste_Entrevista = drlAsiste_Entrevista.Text
                ObjPS.Promedio_Entrevista = TxtPromedio_Entrevista.Text
                ObjPS.Promedio_Optimo = TxtPromedio_Optimo.Text
                ObjPS.Promedio_Digitacion = TxtPromedio_Digitacion.Text
                ObjPS.Promedio_C_Lectura = TxtPromedio_C_Lectura.Text
                ObjPS.Promedio_Ortografia = TxtPromedio_Ortografia.Text
                ObjPS.Test_Wartegg = TxtTest_Wartegg.Text
                ObjPS.PF_16 = Txt16_PF.Text
                ObjPS.Assessment_Center = TxtAssessment_Center.Text
                ObjPS.Diligencias = TxtDiligencias.Text
                ObjPS.Resultado_General = TxtResultado_General.Text
                ObjPS.Preseleccionado = drlPreseleccionado.Text

                ObjPS.Id_Aspirante_Update = TxtId_Aspirante_Actualiza.Text

                ObjPS.ActualizarAspirante()

                lblmsg.Text = "Datos Ingresados"

                Limpia()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnVerTodos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnVerTodos.Click
        Try
            ObjPS.Id_Aspirante = Nothing
            Consulta_Aspirante()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Dim Validancion As Boolean = False

    Public Sub CrearExcel()
        Dim sb As New StringBuilder
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim form = New HtmlForm
        Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"


        pagina.EnableEventValidation = False
        pagina.DesignerInitialize()
        pagina.Controls.Add(form)

        If Validancion = True Then
            form.Controls.Add(dtgGeneral_Ver_Todos)
        Else
            form.Controls.Add(dtgGeneral)
        End If

        pagina.RenderControl(htw)
        Response.Clear()
        Response.Buffer = True

        Response.ContentType = "application/vnd.ms-excel"
        Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
        Response.AddHeader("Content-Disposition", "attachment;filename=Aspirantes.xls")
        Response.Charset = "UTF-8"
        Response.Write(strStyle)
        Response.Write(sb.ToString())
        Response.End()
    End Sub

    Protected Sub Btnxls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btnxls.Click
        Try
            crearexcel()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
            lblmsg.ForeColor = Drawing.Color.Red
        End Try
    End Sub

    Protected Sub BtnConsulta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsulta.Click
        Try
            If TxtId_Aspirante_Consulta.Text = "" And TxtNombre_Consulta.Text = "" And TxtApellido_Consulta.Text = "" And TxtFecha_Filtro_Consulta.Text = "" And TxtFecha_Entrevista_Consulta.Text = "" And drlEmpresa_Consulta.SelectedItem.Text = "- Seleccione -" And drlPerfil_Consulta.SelectedItem.Text = "- Seleccione -" And drlCargoAspira_Consulta.SelectedItem.Text = "- Seleccione -" And drlConvocado_Consulta.Text = "- Seleccione -" And drlAsiste_Entrevista_Consulta.Text = "- Seleccione -" And drlPreseleccionado_Consulta.Text = "- Seleccione -" Then
                lblmsg.Text = "Ingrese alguna opcion de filtro"
                Exit Sub
            Else
                If TxtId_Aspirante_Consulta.Text <> "" Then
                    ObjPS.Id_Aspirante = TxtId_Aspirante_Consulta.Text
                End If
                If TxtNombre_Consulta.Text <> "" Then
                    ObjPS.Nombre_Aspirante = TxtNombre_Consulta.Text
                End If
                If TxtApellido_Consulta.Text <> "" Then
                    ObjPS.Apellido = TxtApellido_Consulta.Text
                End If
                If TxtFecha_Filtro_Consulta.Text <> "" Then
                    ObjPS.Fecha_Filtro = TxtFecha_Filtro_Consulta.Text
                End If
                If TxtFecha_Entrevista_Consulta.Text <> "" Then
                    ObjPS.Fecha_Entrevista = TxtFecha_Entrevista_Consulta.Text
                End If
                If drlEmpresa_Consulta.SelectedItem.Text <> "- Seleccione -" Then
                    ObjPS.Fk_Cod_Empresa = drlEmpresa_Consulta.Text
                End If
                If drlPerfil_Consulta.SelectedItem.Text <> "- Seleccione -" Then
                    ObjPS.Fk_Cod_Perfil_PS = drlPerfil_Consulta.Text
                End If
                If drlCargoAspira_Consulta.SelectedItem.Text <> "- Seleccione -" Then
                    ObjPS.Fk_Cod_Cargo_Aspira = drlCargoAspira_Consulta.Text
                End If
                If drlConvocado_Consulta.Text <> "- Seleccione -" Then
                    ObjPS.Convocado = drlConvocado_Consulta.Text
                End If
                If drlAsiste_Entrevista_Consulta.Text <> "- Seleccione -" Then
                    ObjPS.Asiste_Entrevista = drlAsiste_Entrevista_Consulta.Text
                End If
                If drlPreseleccionado_Consulta.Text <> "- Seleccione -" Then
                    ObjPS.Preseleccionado = drlPreseleccionado_Consulta.Text
                End If

                dtgGeneral.DataSource = ObjPS.Consultar_Aspirantes_Filtros()
                dtgGeneral.DataBind()
                LblCuenta_Aspirantes.Text = ObjPS.Cantidad
                lblmsg.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub Btnxls_Todos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btnxls_Todos.Click
        Try
            dtgGeneral_Ver_Todos.DataSource = ObjPS.Consultar_Aspirantes
            dtgGeneral_Ver_Todos.DataBind()
            LblCantidad_Total.Text = ObjPS.Cantidad
            If LblCantidad_Total.Text > 20000 Then
                lblmsg.Text = "No se puede generar archivo en xls, realice un filtro adicional o solicite la consulta al administrador de la base de datos"
                Exit Sub
            End If
            LblCantidad_Total.Text = ""
            Validancion = True
            CrearExcel()
            dtgGeneral_Ver_Todos.DataSource = Nothing
            dtgGeneral_Ver_Todos.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
            lblmsg.ForeColor = Drawing.Color.Red
        End Try
    End Sub

    Protected Sub dtgGeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgGeneral.PageIndexChanging
        dtgGeneral.PageIndex = e.NewPageIndex
        Consulta_Aspirante()
    End Sub
End Class