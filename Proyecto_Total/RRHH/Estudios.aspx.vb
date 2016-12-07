Imports System.IO

Public Class Estudios
    Inherits System.Web.UI.Page
    Dim ObjInformes As New clsInformes
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim categoria As Integer = 0
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                ObjInformes.Validacionn = 1
                With DrpExpe
                    .DataSource = ObjInformes.Listas
                    .DataTextField = "nombre"
                    .DataValueField = "cod_estudio_complemento"
                    .DataBind()
                End With
                ObjInformes.Validacionn = 2
                With DrpNivel
                    .DataSource = ObjInformes.Listas
                    .DataTextField = "nombre"
                    .DataValueField = "cod_estudio_complemento"
                    .DataBind()
                End With
                ObjInformes.Validacionn = 3
                With DrpAreaC
                    .DataSource = ObjInformes.Listas
                    .DataTextField = "nombre"
                    .DataValueField = "cod_estudio_complemento"
                    .DataBind()
                End With
                ObjInformes.Validacionn = 1
                With DrpExpe0
                    .DataSource = ObjInformes.Listas
                    .DataTextField = "nombre"
                    .DataValueField = "cod_estudio_complemento"
                    .DataBind()
                End With
                ObjInformes.Validacionn = 2
                With DrpNivel0
                    .DataSource = ObjInformes.Listas
                    .DataTextField = "nombre"
                    .DataValueField = "cod_estudio_complemento"
                    .DataBind()
                End With
                ObjInformes.Validacionn = 3
                With DrpAreaC0
                    .DataSource = ObjInformes.Listas
                    .DataTextField = "nombre"
                    .DataValueField = "cod_estudio_complemento"
                    .DataBind()
                End With
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
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



    Protected Sub BtnValidar_Click(sender As Object, e As EventArgs) Handles BtnValidar.Click
        Try
            Dim dts As New DataSet
            Dim can As Integer = 0
            If txtCodigo.Text = Nothing And txtDocumento.Text = Nothing Then
                lblmsg.Text = "Debe validar la existencia del usuario"
                Exit Sub
            End If
            If txtCodigo.Text <> Nothing Then
                ObjInformes.codigo = txtCodigo.Text
            Else
                ObjInformes.codigo = ""
            End If
            If txtDocumento.Text <> Nothing Then
                ObjInformes.Documento = txtDocumento.Text
            Else
                ObjInformes.Documento = txtDocumento.Text
            End If
            dts = ObjInformes.ValidacionEstudio
            If ObjInformes.Cantidad = 0 Then
                lblmsg.Text = "No se encontraron Registros"
                lblcantidad.Text = "Registros encontrados: 0"
                txtDocumento.Text = ""
                Lblnombre.Text = ""
                Exit Sub
            End If
            Lblnombre.Text = dts.Tables(0).Rows(0).Item("Nombre")
            txtCodigo.Text = dts.Tables(0).Rows(0).Item("codigo")
            txtDocumento.Text = dts.Tables(0).Rows(0).Item("documento")
            llenar()


            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Public Sub llenar()
        If txtCodigo.Text <> Nothing Then
            ObjInformes.codigo = txtCodigo.Text
        Else
            ObjInformes.codigo = ""
        End If
        If txtDocumento.Text <> Nothing Then
            ObjInformes.Documento = txtDocumento.Text
        Else
            ObjInformes.Documento = txtDocumento.Text
        End If
        ObjInformes.Validacionn = 1
        dtgConsulta.DataSource = ObjInformes.ValidacionEstudio
        dtgConsulta.DataBind()
    End Sub
    Protected Sub DrpAreaC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DrpAreaC.SelectedIndexChanged
        Try
            ObjInformes.codigo = DrpAreaC.SelectedValue
            ObjInformes.Validacionn = 4
            With DrpCatego
                .DataSource = ObjInformes.Listas
                .DataTextField = "nombre"
                .DataValueField = "cod_estudio_complemento"
                .DataBind()
            End With

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub DrpExpe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DrpExpe.SelectedIndexChanged
        Try
            If DrpExpe.SelectedItem.Text = "Aplazado" Then
                DrlSemApla.Enabled = True
                txtAñoAplaza.Enabled = True
            Else
                DrlSemApla.Enabled = False
                txtAñoAplaza.Enabled = False
                txtAñoAplaza.Text = ""
                DrlSemApla.SelectedValue = ""
            End If

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try

    End Sub


    Protected Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Lblnombre.Text = "" Then
                lblmsg.Text = "Valide el usuario"
                Exit Sub
            End If

            If txtCodigo.Text <> Nothing Then
                ObjInformes.codigo = txtCodigo.Text
            Else
                lblmsg.Text = "Verifique codigo del usuario"
                Exit Sub
            End If

            If txtDocumento.Text <> Nothing Then
                ObjInformes.Documento = txtDocumento.Text
            Else
                lblmsg.Text = "Verifique Documento del usuario"
                Exit Sub
            End If

            If DrpExpe.SelectedValue <> 0 Then
                ObjInformes.Experiencia = DrpExpe.SelectedValue
            Else
                lblmsg.Text = "Verifique el campo de Experiencia Academica"
                Exit Sub
            End If

            If DrpNivel.SelectedValue <> 0 Then
                ObjInformes.Nivel = DrpNivel.SelectedValue
            Else
                lblmsg.Text = "Verifique el campo de Nivel Academico"
                Exit Sub
            End If

            If DrpExpe.SelectedItem.Text = "Aplazado" Then
                If txtAñoAplaza.Text <> Nothing Then
                    ObjInformes.AñoApla = txtAñoAplaza.Text
                Else
                    lblmsg.Text = "Verifique año de aplazamiento"
                    Exit Sub
                End If
                If DrlSemApla.SelectedValue <> 0 Then
                    ObjInformes.SemApla = DrlSemApla.SelectedValue
                Else
                    lblmsg.Text = "Verifique semestre del año aplazado"
                    Exit Sub
                End If
            Else
                ObjInformes.AñoApla = "0"
                ObjInformes.SemApla = "0"
            End If

            If DrpAreaC.SelectedValue <> 0 Then
                ObjInformes.Area = DrpAreaC.SelectedValue
            Else
                lblmsg.Text = "Verifique Area Conocimiento"
                Exit Sub
            End If

            If DrpCatego.SelectedValue <> 0 Then
                ObjInformes.Categoria = DrpCatego.SelectedValue
            Else
                lblmsg.Text = "Verifique Categoria"
                Exit Sub
            End If


            If txtSemCertificado.Text <> Nothing And txtSemCertificado.Text < "15" Then
                ObjInformes.semestre = txtSemCertificado.Text
            Else
                lblmsg.Text = "Verifique el campo de semestre certificado"
                Exit Sub
            End If

            If txtInstitucion.Text <> Nothing Then
                ObjInformes.institucion = txtInstitucion.Text
            Else
                lblmsg.Text = "Verifique el campo de institucion"
                Exit Sub
            End If

            If DrpPractica.SelectedValue <> Nothing Then
                ObjInformes.Practica = DrpPractica.SelectedValue
            Else
                lblmsg.Text = "Verifique practica"
                Exit Sub
            End If
            ObjInformes.InsertarEstudio()

            lblmsg.Text = "Se ha registrado correctamente"
            llenar()
            txtCodigo.Text = ""
            txtDocumento.Text = ""
            Lblnombre.Text = ""
            DrpExpe.SelectedValue = 0
            DrpNivel.SelectedValue = 0
            If DrpExpe.SelectedItem.Text = "Aplazado" Then
                txtAñoAplaza.Text = ""
                DrlSemApla.SelectedValue = 0
            End If

            DrpAreaC.SelectedValue = 0
            DrpCatego.SelectedValue = 0
            txtSemCertificado.Text = ""
            txtInstitucion.Text = ""
            DrpPractica.SelectedValue = ""

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub



    Protected Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            Dim dts As New DataSet
            If txtBusqueda.Text <> Nothing Then
                ObjInformes.Id = txtBusqueda.Text
                dts = ObjInformes.SeleccionEstudio()
                If ObjInformes.Cantidad > 0 Then
                    txtBusqueda.Enabled = False
                    BtnActualizar.Enabled = True
                    BtnCancelar.Enabled = True
                    BtnGuardar.Enabled = False
                    If ObjInformes.codigo <> Nothing Then
                        txtCodigo.Text = ObjInformes.codigo
                        txtCodigo.Enabled = False
                    Else
                        txtCodigo.Text = ""
                    End If

                    If ObjInformes.Documento <> Nothing Then
                        txtDocumento.Text = ObjInformes.Documento
                        txtDocumento.Enabled = False
                    Else
                        txtDocumento.Text = ""
                    End If

                    If ObjInformes.Nombre <> Nothing Then
                        Lblnombre.Text = ObjInformes.Nombre
                    Else
                        Lblnombre.Text = ""
                    End If

                    If ObjInformes.Experiencia <> Nothing Then
                        DrpExpe.SelectedValue = ObjInformes.Experiencia
                    Else
                        DrpExpe.SelectedValue = 0
                    End If

                    If ObjInformes.Nivel <> Nothing Then
                        DrpNivel.SelectedValue = ObjInformes.Nivel
                    Else
                        DrpNivel.SelectedValue = 0
                    End If


                    If DrpExpe.SelectedItem.Text = "Aplazado" Then
                        If ObjInformes.AñoApla <> Nothing Then
                            txtAñoAplaza.Text = ObjInformes.AñoApla
                            txtAñoAplaza.Enabled = True
                        Else
                            txtAñoAplaza.Text = ""
                        End If
                        If ObjInformes.SemApla = 0 Then
                            DrlSemApla.SelectedValue = 0
                        Else
                            DrlSemApla.SelectedValue = ObjInformes.SemApla
                            DrlSemApla.Enabled = True
                        End If
                    End If

                    If ObjInformes.Area <> Nothing Then
                        DrpAreaC.SelectedValue = ObjInformes.Area
                    Else
                        DrpAreaC.SelectedValue = 0
                    End If
                    ObjInformes.codigo = DrpAreaC.SelectedValue
                    ObjInformes.Validacionn = 4
                    With DrpCatego
                        .DataSource = ObjInformes.Listas
                        .DataTextField = "nombre"
                        .DataValueField = "cod_estudio_complemento"
                        .DataBind()
                    End With
                    If ObjInformes.Categoria <> Nothing Then
                        DrpCatego.SelectedValue = ObjInformes.Categoria
                    Else
                        DrpCatego.SelectedValue = 0
                    End If

                    If ObjInformes.semestre <> Nothing Then
                        txtSemCertificado.Text = ObjInformes.semestre
                    Else
                        txtSemCertificado.Text = ""
                    End If

                    If ObjInformes.institucion <> Nothing Then
                        txtInstitucion.Text = ObjInformes.institucion
                    Else
                        txtInstitucion.Text = ""
                    End If

                    If ObjInformes.Practica <> Nothing Then
                        DrpPractica.SelectedValue = ObjInformes.Practica
                    Else
                        DrpPractica.SelectedValue = 0
                    End If
                Else

                    lblmsg.Text = "No se encontraron datos"
                    lblcantidad.Text = "Registros encontrados: 0"
                    txtCodigo.Text = ""
                    txtDocumento.Text = ""
                    Lblnombre.Text = ""
                    DrpExpe.SelectedValue = 0
                    DrpNivel.SelectedValue = 0
                    txtAñoAplaza.Text = ""
                    DrlSemApla.SelectedValue = ""
                    DrpAreaC.SelectedValue = 0
                    DrpCatego.SelectedValue = 0
                    txtSemCertificado.Text = ""
                    txtInstitucion.Text = ""
                    DrpPractica.SelectedValue = 0
                    Exit Sub
                End If
            Else
                lblmsg.Text = "Debe consultar por id"
                Exit Sub
            End If
            llenar()
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub



    Protected Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If Lblnombre.Text = "" Then
                lblmsg.Text = "Valide el usuario"
                Exit Sub
            End If

            If txtCodigo.Text <> Nothing Then
                ObjInformes.codigo = txtCodigo.Text
            Else
                lblmsg.Text = "Verifique codigo del usuario"
                Exit Sub
            End If

            If txtDocumento.Text <> Nothing Then
                ObjInformes.Documento = txtDocumento.Text
            Else
                lblmsg.Text = "Verifique Documento del usuario"
                Exit Sub
            End If

            If DrpExpe.SelectedValue <> 0 Then
                ObjInformes.Validacionn = 1
                ObjInformes.Id = txtBusqueda.Text
                ObjInformes.Experiencia = DrpExpe.SelectedValue
                ObjInformes.ActualizarEstudio()
            Else
                lblmsg.Text = "Verifique el campo de Experiencia Academica"
                Exit Sub
            End If

            If DrpNivel.SelectedValue <> 0 Then
                ObjInformes.Validacionn = 2
                ObjInformes.Id = txtBusqueda.Text
                ObjInformes.Nivel = DrpNivel.SelectedValue
                ObjInformes.ActualizarEstudio()
            Else
                lblmsg.Text = "Verifique el campo de Nivel Academico"
                Exit Sub
            End If


            If txtAñoAplaza.Text <> Nothing Then
                ObjInformes.Validacionn = 3
                ObjInformes.Id = txtBusqueda.Text
                ObjInformes.AñoApla = txtAñoAplaza.Text
                ObjInformes.ActualizarEstudio()
            ElseIf txtAñoAplaza.Text = Nothing Then
                ObjInformes.Validacionn = 3
                ObjInformes.Id = txtBusqueda.Text
                ObjInformes.AñoApla = "0"
                ObjInformes.ActualizarEstudio()
            Else
                lblmsg.Text = "Verifique año de aplazamiento"
                Exit Sub
            End If

            If DrlSemApla.SelectedValue <> Nothing Then
                ObjInformes.Validacionn = 4
                ObjInformes.Id = txtBusqueda.Text
                ObjInformes.SemApla = DrlSemApla.SelectedValue
                ObjInformes.ActualizarEstudio()
            ElseIf DrlSemApla.SelectedValue = Nothing Then
                ObjInformes.Validacionn = 4
                ObjInformes.Id = txtBusqueda.Text
                ObjInformes.SemApla = "0"
                ObjInformes.ActualizarEstudio()
            Else
                lblmsg.Text = "Verifique semestre del año aplazado"
                Exit Sub
            End If


            If DrpAreaC.SelectedValue <> 0 Then
                ObjInformes.Validacionn = 5
                ObjInformes.Id = txtBusqueda.Text
                ObjInformes.Area = DrpAreaC.SelectedValue
                ObjInformes.ActualizarEstudio()
            Else
                lblmsg.Text = "Verifique Area Conocimiento"
                Exit Sub
            End If

            If DrpCatego.SelectedValue <> 0 Then
                ObjInformes.Validacionn = 6
                ObjInformes.Id = txtBusqueda.Text
                ObjInformes.Categoria = DrpCatego.SelectedValue
                ObjInformes.ActualizarEstudio()

            Else
                lblmsg.Text = "Verifique Categoria"
                Exit Sub
            End If


            If txtSemCertificado.Text <> Nothing And txtSemCertificado.Text < "15" Then
                ObjInformes.Validacionn = 7
                ObjInformes.Id = txtBusqueda.Text
                ObjInformes.semestre = txtSemCertificado.Text
                ObjInformes.ActualizarEstudio()

            Else
                lblmsg.Text = "Verifique el campo de semestre certificado"
                Exit Sub
            End If

            If txtInstitucion.Text <> Nothing Then
                ObjInformes.Validacionn = 8
                ObjInformes.Id = txtBusqueda.Text
                ObjInformes.institucion = txtInstitucion.Text
                ObjInformes.ActualizarEstudio()

            Else
                lblmsg.Text = "Verifique el campo de institucion"
                Exit Sub
            End If

            If DrpPractica.SelectedValue <> Nothing Then
                ObjInformes.Validacionn = 9
                ObjInformes.Id = txtBusqueda.Text
                ObjInformes.Practica = DrpPractica.SelectedValue
                ObjInformes.ActualizarEstudio()

            Else
                lblmsg.Text = "Verifique practica"
                Exit Sub
            End If

            lblmsg.Text = "Se ha Actualizado correctamente"
            llenar()
            txtCodigo.Text = ""
            txtDocumento.Text = ""

            Lblnombre.Text = ""
            DrpNivel.SelectedValue = 0
            If DrpExpe.SelectedItem.Text = "Aplazado" Then
                txtAñoAplaza.Text = ""
                DrlSemApla.SelectedValue = ""
            End If
            DrpExpe.SelectedValue = 0
            DrpAreaC.SelectedValue = 0
            DrpCatego.SelectedValue = 0
            txtSemCertificado.Text = ""
            txtInstitucion.Text = ""
            DrpPractica.SelectedValue = ""
            BtnActualizar.Enabled = False
            BtnCancelar.Enabled = False
            BtnGuardar.Enabled = True
            txtBusqueda.Enabled = True
            txtBusqueda.Text = ""
            txtCodigo.Enabled = True
            txtDocumento.Enabled = True
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            txtBusqueda.Enabled = True
            txtCodigo.Text = ""
            txtDocumento.Text = ""
            Lblnombre.Text = ""
            DrpExpe.SelectedValue = 0
            DrpNivel.SelectedValue = 0
            If DrpExpe.SelectedItem.Text <> "Aplazado" Then
                txtAñoAplaza.Text = ""
                DrlSemApla.SelectedValue = ""
            End If

            DrpAreaC.SelectedValue = 0
            DrpCatego.SelectedValue = 0
            txtSemCertificado.Text = ""
            txtInstitucion.Text = ""
            DrpPractica.SelectedValue = ""
            BtnActualizar.Enabled = False
            BtnCancelar.Enabled = False
            BtnGuardar.Enabled = True
            txtBusqueda.Enabled = True
            txtCodigo.Enabled = True
            txtDocumento.Enabled = True
            txtBusqueda.Text = ""
            dtgConsulta.DataSource = Nothing
            dtgConsulta.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub DrpPractica0_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DrpPractica0.SelectedIndexChanged

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If DrpExpe0.SelectedValue = 0 And DrpNivel0.SelectedValue = 0 And DrpAreaC0.SelectedValue = 0 And DrpCatego0.SelectedValue = Nothing And DrpPractica0.SelectedValue = "" And txtCodAgente.Text = "" Then
                lblmsg.Text = "Debe consultar por un valor"
                lblcantidad.Text = "Registros encontrados: 0"
                dtgConsulta.DataSource = Nothing
                dtgConsulta.DataBind()
                Exit Sub
            End If


            If DrpExpe0.SelectedValue = 0 Then
                ObjInformes.Experiencia = Nothing
            Else
                ObjInformes.Experiencia = DrpExpe0.SelectedValue
            End If

            If DrpNivel0.SelectedValue = 0 Then
                ObjInformes.Nivel = Nothing
            Else
                ObjInformes.Nivel = DrpNivel0.SelectedValue
            End If

            If DrpAreaC0.SelectedValue = 0 Then
                ObjInformes.Area = Nothing
            Else
                ObjInformes.Area = DrpAreaC0.SelectedValue
            End If

            If DrpCatego0.SelectedValue = Nothing Then
                ObjInformes.Categoria = Nothing
            Else
                ObjInformes.Categoria = DrpCatego0.SelectedValue
            End If

            If DrpPractica0.SelectedValue = Nothing Then
                ObjInformes.Practica = Nothing
            Else
                ObjInformes.Practica = DrpPractica0.SelectedValue
            End If

            ObjInformes.codigo = txtCodAgente.Text

            ObjInformes.Area = DrpAreaC0.SelectedValue
            dtgConsulta.DataSource = ObjInformes.Consulta_Especifica()
            dtgConsulta.DataBind()
            If ObjInformes.Cantidad = 0 Then
                lblmsg.Text = "No se encontraron datos"
                lblcantidad.Text = "Registros encontrados: 0"
                dtgConsulta.DataSource = Nothing
                dtgConsulta.DataBind()
                Exit Sub
            Else
                lblcantidad.Text = "Registros encontrados: " & ObjInformes.Cantidad
            End If

            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub DrpAreaC0_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DrpAreaC0.SelectedIndexChanged
        Try
            ObjInformes.codigo = DrpAreaC0.SelectedValue
            ObjInformes.Validacionn = 4
            With DrpCatego0
                .DataSource = ObjInformes.Listas
                .DataTextField = "nombre"
                .DataValueField = "cod_estudio_complemento"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ObjInformes.Validacionn = 1
            dtgConsulta.DataSource = ObjInformes.Consulta_Especifica
            dtgConsulta.DataBind()
            If ObjInformes.Cantidad = 0 Then
                lblmsg.Text = "No se encontraron datos"
                lblcantidad.Text = "Registros encontrados: 0"
                dtgConsulta.DataSource = Nothing
                dtgConsulta.DataBind()
                Exit Sub
            Else
                lblcantidad.Text = "Registros encontrados: " & ObjInformes.Cantidad
                lblmsg.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

   

    Sub crearexcel()
        Dim sb As New StringBuilder
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim form = New HtmlForm
        Dim objdtsconsultaxls As New DataSet
        Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
        dtgXls.Visible = True

        pagina.EnableEventValidation = False
        pagina.DesignerInitialize()
        pagina.Controls.Add(form)
        form.Controls.Add(dtgXls)
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

    Protected Sub btnExpXls_Click(sender As Object, e As EventArgs) Handles btnExpXls.Click
        Try
            If DrpExpe0.SelectedValue = 0 And DrpNivel0.SelectedValue = 0 And DrpAreaC0.SelectedValue = 0 And DrpCatego0.SelectedValue = Nothing And DrpPractica0.SelectedValue = Nothing Then
                lblmsg.Text = "Para exportar debe elegir uno o varios filtros"
                dtgXls.DataSource = Nothing
                dtgXls.DataBind()
                Exit Sub
            End If

            If DrpExpe0.SelectedValue = 0 Then
                ObjInformes.Experiencia = Nothing
            Else
                ObjInformes.Experiencia = DrpExpe0.SelectedValue
            End If

            If DrpNivel0.SelectedValue = 0 Then
                ObjInformes.Nivel = Nothing
            Else
                ObjInformes.Nivel = DrpNivel0.SelectedValue
            End If

            If DrpAreaC0.SelectedValue = 0 Then
                ObjInformes.Area = Nothing
            Else
                ObjInformes.Area = DrpAreaC0.SelectedValue
            End If

            If DrpCatego0.SelectedValue = Nothing Then
                ObjInformes.Categoria = Nothing
            Else
                ObjInformes.Categoria = DrpCatego0.SelectedValue
            End If

            If DrpPractica0.SelectedValue = Nothing Then
                ObjInformes.Practica = Nothing
            Else
                ObjInformes.Practica = DrpPractica0.SelectedValue
            End If
            ObjInformes.Area = DrpAreaC0.SelectedValue
            dtgXls.DataSource = ObjInformes.Consulta_Especifica()
            dtgXls.DataBind()
            If ObjInformes.Cantidad = 0 Then
                lblmsg.Text = "No se encontraron datos"
                lblcantidad.Text = "Registros encontrados: 0"
                dtgXls.DataSource = Nothing
                dtgXls.DataBind()
                Exit Sub
            Else
                crearexcel()
                lblcantidad.Text = "Registros encontrados: " & ObjInformes.Cantidad
            End If

            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

End Class