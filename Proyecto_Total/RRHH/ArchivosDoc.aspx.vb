Public Class ArchivosDoc
    Inherits System.Web.UI.Page
    Dim ObjArchivo As New clsrrhh

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Obtengo los datos del usuario'
        Try
            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                Cargardrl()
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
        Try
            With drlCategoria
                .DataSource = ObjArchivo.Consulta_Archivo_Categoria
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With drlCategoria_Registro
                .DataSource = ObjArchivo.Consulta_Archivo_Categoria
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            ObjArchivo.Validacion = "seleccionar"  'Asigno valor a esta variable por que se necesita en una función
            With drlDependencia_Registro
                .DataSource = ObjArchivo.Consulta_Archivo_Tipo_Solicitud
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With drlDependencia
                .DataSource = ObjArchivo.Consulta_Archivo_Tipo_Solicitud
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
    Public Sub Versiones()
        Try

        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
    Public Sub Consulta()
        Try
            dtggeneral.DataSource = Nothing
            lblCuenta_Registros.Text = ""
            dtgVersiones.DataSource = Nothing
            lblcuentaVersiones.Text = ""
            If TxtCod_Archivo.Text = "" Then
                ObjArchivo.Cod_Archivo = Nothing
            Else
                ObjArchivo.Cod_Archivo = TxtCod_Archivo.Text
                ObjArchivo.Validacion = 1
                dtggeneral.DataSource = ObjArchivo.Consulta_Archivo_Versiones()
                dtggeneral.DataBind()
                lblCuenta_Registros.Text = ObjArchivo.cantidad
                lblbCodhistorial.Text = ObjArchivo.tipocont
                ObjArchivo.Validacion = 2
                dtgVersiones.DataSource = ObjArchivo.Consulta_Archivo_Versiones()
                dtgVersiones.DataBind()
                lblcuentaVersiones.Text = ObjArchivo.cantidad
            End If
            If drlCategoria.SelectedItem.Text = "GESTION DE OPERACIONES" Then
                If drlDependencia.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una dependencia"
                    Exit Sub
                Else
                    ObjArchivo.deporte = drlDependencia_Registro.Text
                End If
            End If
            ObjArchivo.documento = TxtNombre.Text
            dtggeneral.DataSource = ObjArchivo.Consulta_Archivos()
            dtggeneral.DataBind()
            lblCuenta_Registros.Text = ObjArchivo.cantidad
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
    Protected Sub BtnConsulta_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnConsulta.Click
        Try
            dtggeneral.DataSource = Nothing
            lblCuenta_Registros.Text = ""
            dtgVersiones.DataSource = Nothing
            lblcuentaVersiones.Text = ""
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Public Sub Actualizar_Documento()
        Try
            If lblidCodigo.Text = "" Then
                lblmsg.Text = "Seleccione la versión que va actualizar"
                Exit Sub
            End If
            If Txtversion2.Text <= lblVersion.Text Then
                lblmsg.Text = "La versión debe ser mayor a la version anterior"
                Exit Sub
            ElseIf Txtversion2.Text = "" Then
                lblmsg.Text = "Ingrese una versión para el archivo"
                Exit Sub
            Else
                ObjArchivo.Version = Txtversion2.Text
            End If
            Dim Fn As String
            Dim SaveLocation As String
            If Not FileDocumento2.PostedFile Is Nothing And FileDocumento2.PostedFile.ContentLength > 0 Then
                Fn = System.IO.Path.GetFileName(FileDocumento2.PostedFile.FileName)
                SaveLocation = Server.MapPath("data_Doc") & "\\" & Fn
                FileDocumento2.PostedFile.SaveAs(SaveLocation)
                ObjArchivo.rutahv = Fn
            Else
                ObjArchivo.rutahv = ""
                lblmsg.Text = "Adjunte un archivo"
                Exit Sub
            End If
            Dim fcreg As Date = FormatDateTime(Now.Date)
            ObjArchivo.cargo = lblProceso.Text
            ObjArchivo.deporte = lblSubproceso.Text
            ObjArchivo.Observacion = txtObservacion2.Text
            ObjArchivo.documento = lblnombre.Text
            ObjArchivo.Usu_CRM = lblusuario.Text
            ObjArchivo.fcregistro = fcreg
            ObjArchivo.Cod_Archivo = lblidCodigo.Text
            ObjArchivo.tipocont = lblCodHistorial.Text

            ObjArchivo.Validacion = 2
            ObjArchivo.Registro_Documento()
            lblmsg.Text = "El archivo se a registrado"

            lblidCodigo.Text = ""
            lblCodHistorial.Text = ""
            lblFcreg.Text = ""
            lblnombre.Text = ""
            lblProceso.Text = ""
            lblSubproceso.Text = ""
            lblVersion.Text = ""
            Txtversion2.Text = ""
            txtObservacion2.Text = ""

            Cargardrl()

        Catch ex As Exception
            lblmsg.Text = "Se presenot error: " + ex.Message
        End Try
    End Sub

    Protected Sub btnActualizar2_Click(sender As Object, e As ImageClickEventArgs) Handles btnActualizar2.Click
        Try
            Actualizar_Documento()
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Public Sub Registrar_Documento()
        Try
            If drlCategoria_Registro.SelectedItem.Text = "- Seleccione -" Then
                ObjArchivo.cargo = ""
                lblmsg.Text = "Seleccione una categoria"
                Exit Sub
            Else
                ObjArchivo.cargo = drlCategoria_Registro.Text
                ObjArchivo.deporte = Nothing
            End If
            'If drlCategoria_Registro.SelectedItem.Text = "GESTION DE OPERACIONES" Then
            If drlDependencia_Registro.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una dependencia"
                Exit Sub
            Else
                ObjArchivo.deporte = drlDependencia_Registro.Text
            End If
            'End If
            If TxtNombre_Registro.Text = "" Then
                lblmsg.Text = "Ingrese un nombre para el archivo"
                Exit Sub
            Else
                ObjArchivo.documento = TxtNombre_Registro.Text
            End If
            ObjArchivo.Version = 1
            ObjArchivo.Observacion = txtObservacion.Text
            Dim Fn As String
            Dim SaveLocation As String
            If Not FileDocumento.PostedFile Is Nothing And FileDocumento.PostedFile.ContentLength > 0 Then
                Fn = System.IO.Path.GetFileName(FileDocumento.PostedFile.FileName)
                SaveLocation = Server.MapPath("data_Doc") & "\\" & Fn
                FileDocumento.PostedFile.SaveAs(SaveLocation)
                ObjArchivo.rutahv = Fn
            Else
                ObjArchivo.rutahv = ""
                lblmsg.Text = "Adjunte un archivo"
                Exit Sub
            End If
            Dim fcreg As Date = FormatDateTime(Now.Date)
            ObjArchivo.Usu_CRM = lblusuario.Text
            ObjArchivo.fcregistro = fcreg
            ObjArchivo.Validacion = 1
            ObjArchivo.Registro_Documento()
            ObjArchivo.Consulta_Archivo_Capturavalor()
            ObjArchivo.Validacion = 3
            ObjArchivo.Registro_Documento()
            lblmsg.Text = "El archivo se a registrado"
            txtObservacion.Text = ""
            TxtNombre_Registro.Text = ""
            Cargardrl()

        Catch ex As Exception
            lblmsg.Text = "Se presenot error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnRegistrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnRegistrar.Click
        Try
            Registrar_Documento()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub btngerencial_Click(sender As Object, e As EventArgs) Handles btngerencial.Click
        Try
            PanelSubprocesos.Visible = False
            PanelBotones.Visible = False
            dtggeneral.DataSource = Nothing
            lblCuenta_Registros.Text = ""
            dtgVersiones.DataSource = Nothing
            lblcuentaVersiones.Text = ""
            ObjArchivo.Validacion = 1
            dtggeneral.DataSource = ObjArchivo.Consulta_Archivos_Botones()
            dtggeneral.DataBind()
            lblCuenta_Registros.Text = ObjArchivo.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub

    Protected Sub btnCalidadymejora_Click(sender As Object, e As EventArgs) Handles btnCalidadymejora.Click
        Try
            PanelSubprocesos.Visible = False
            PanelBotones.Visible = False
            dtggeneral.DataSource = Nothing
            lblCuenta_Registros.Text = ""
            dtgVersiones.DataSource = Nothing
            lblcuentaVersiones.Text = ""
            ObjArchivo.Validacion = 2
            dtggeneral.DataSource = ObjArchivo.Consulta_Archivos_Botones()
            dtggeneral.DataBind()
            lblCuenta_Registros.Text = ObjArchivo.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub

    Protected Sub btnOperaciones_Click(sender As Object, e As EventArgs) Handles btnOperaciones.Click
        Try
            btnDatos.Visible = True
            btnVoz.Visible = True
            btnVozyDatos.Visible = True
            btnFormacion.Visible = True
            btnInformacion.Visible = True
            btnOtros.Visible = True
            PanelSubprocesos.Visible = True
            PanelBotones.Visible = True
            dtggeneral.DataSource = Nothing
            lblCuenta_Registros.Text = ""
            dtgVersiones.DataSource = Nothing
            lblcuentaVersiones.Text = ""
            ObjArchivo.Validacion = 3
            dtggeneral.DataSource = ObjArchivo.Consulta_Archivos_Botones()
            dtggeneral.DataBind()
            lblCuenta_Registros.Text = ObjArchivo.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub

    Protected Sub btnComercial_Click(sender As Object, e As EventArgs) Handles btnComercial.Click
        Try
            
            PanelSubprocesos.Visible = False
            PanelBotones.Visible = False
            dtggeneral.DataSource = Nothing
            lblCuenta_Registros.Text = ""
            dtgVersiones.DataSource = Nothing
            lblcuentaVersiones.Text = ""
            ObjArchivo.Validacion = 4
            dtggeneral.DataSource = ObjArchivo.Consulta_Archivos_Botones()
            dtggeneral.DataBind()
            lblCuenta_Registros.Text = ObjArchivo.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub

    Protected Sub btnTecnologia_Click(sender As Object, e As EventArgs) Handles btnTecnologia.Click
        Try
            PanelSubprocesos.Visible = False
            PanelBotones.Visible = False
            dtggeneral.DataSource = Nothing
            lblCuenta_Registros.Text = ""
            dtgVersiones.DataSource = Nothing
            lblcuentaVersiones.Text = ""
            ObjArchivo.Validacion = 5
            dtggeneral.DataSource = ObjArchivo.Consulta_Archivos_Botones()
            dtggeneral.DataBind()
            lblCuenta_Registros.Text = ObjArchivo.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub

    Protected Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        Try
            
            PanelSubprocesos.Visible = False
            PanelBotones.Visible = False
            dtggeneral.DataSource = Nothing
            lblCuenta_Registros.Text = ""
            dtgVersiones.DataSource = Nothing
            lblcuentaVersiones.Text = ""
            ObjArchivo.Validacion = 6
            dtggeneral.DataSource = ObjArchivo.Consulta_Archivos_Botones()
            dtggeneral.DataBind()
            lblCuenta_Registros.Text = ObjArchivo.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub

    Protected Sub btnFinanciera_Click(sender As Object, e As EventArgs) Handles btnFinanciera.Click
        Try
            PanelSubprocesos.Visible = False
            PanelBotones.Visible = False
            dtggeneral.DataSource = Nothing
            lblCuenta_Registros.Text = ""
            dtgVersiones.DataSource = Nothing
            lblcuentaVersiones.Text = ""
            ObjArchivo.Validacion = 7
            dtggeneral.DataSource = ObjArchivo.Consulta_Archivos_Botones()
            dtggeneral.DataBind()
            lblCuenta_Registros.Text = ObjArchivo.cantidad

        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub

    Protected Sub btnTalentohumano_Click(sender As Object, e As EventArgs) Handles btnTalentohumano.Click
        Try
            PanelSubprocesos.Visible = False
            PanelBotones.Visible = False
            dtggeneral.DataSource = Nothing
            lblCuenta_Registros.Text = ""
            dtgVersiones.DataSource = Nothing
            lblcuentaVersiones.Text = ""
            ObjArchivo.Validacion = 8
            dtggeneral.DataSource = ObjArchivo.Consulta_Archivos_Botones()
            dtggeneral.DataBind()
            lblCuenta_Registros.Text = ObjArchivo.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub
    Protected Sub drlCategoria_Registro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlCategoria_Registro.SelectedIndexChanged
        Try
            'If drlCategoria_Registro.Text = "GESTION DE OPERACIONES" Then
            '    drlDependencia_Registro.Enabled = True
            'Else
            '    drlDependencia_Registro.Enabled = False
            'End If
            ObjArchivo.Validacion = "cargar drl_Sub_proceso"
            ObjArchivo.tipo_solicitud = drlCategoria_Registro.SelectedValue
            With drlDependencia_Registro
                .DataSource = ObjArchivo.Consulta_Archivo_Tipo_Solicitud
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles dtggeneral.RowCommand
        Try
            'Mediante este codigo envio la identificacion del aspirante, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Seleccionar" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                ObjArchivo.idusuario = lblusuario.Text
                ObjArchivo.Cod_Archivo = dtggeneral.Rows(index).Cells(0).Text
                ObjArchivo.Consulta_Archivo_documentos()
                lblidCodigo.Text = ObjArchivo.Cod_Archivo
                lblCodHistorial.Text = ObjArchivo.tipocont
                lblFcreg.Text = ObjArchivo.fcregistro
                lblnombre.Text = ObjArchivo.nombres
                lblProceso.Text = ObjArchivo.cargo
                lblSubproceso.Text = ObjArchivo.proyecto
                Txtversion2.Text = ObjArchivo.codigo
                lblVersion.Text = ObjArchivo.codigo

                'If TxtCod_Archivo.Text <> Nothing Then
                '    ObjArchivo.Cod_HelpDesk_Solucion = LblCod_HeplDeks.Text

                '    dtggeneralHelpDeskSolucion.DataSource = ObjHelpDesk.Consulta_Proceso
                '    dtggeneralHelpDeskSolucion.DataBind()
                '    lblcuentaSoluciones.Text = ObjHelpDesk.Cantidad
                'End If

                'If LblCod_HeplDeks.Text = "0" Then
                '    BtnGuardar.Visible = False
                'Else
                '    BtnGuardar.Visible = True
                'End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub drlCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlCategoria.SelectedIndexChanged
        Try
            'If drlCategoria.Text = "GESTION DE OPERACIONES" Then
            '    drlDependencia.Enabled = True
            'Else
            '    drlDependencia.Enabled = False
            'End If
            ObjArchivo.Validacion = "cargar drl_Sub_proceso"
            ObjArchivo.tipo_solicitud = drlCategoria.SelectedValue
            With drlDependencia
                .DataSource = ObjArchivo.Consulta_Archivo_Tipo_Solicitud
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub

    Protected Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        Try
            dtggeneral.DataSource = Nothing
            lblCuenta_Registros.Text = ""
            dtgVersiones.DataSource = Nothing
            lblcuentaVersiones.Text = ""
            ObjArchivo.Validacion = 9
            dtggeneral.DataSource = ObjArchivo.Consulta_Archivos_Botones()
            dtggeneral.DataBind()
            lblCuenta_Registros.Text = ObjArchivo.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub

    Protected Sub btnVoz_Click(sender As Object, e As EventArgs) Handles btnVoz.Click
        Try
            dtggeneral.DataSource = Nothing
            lblCuenta_Registros.Text = ""
            dtgVersiones.DataSource = Nothing
            lblcuentaVersiones.Text = ""
            ObjArchivo.Validacion = 10
            dtggeneral.DataSource = ObjArchivo.Consulta_Archivos_Botones()
            dtggeneral.DataBind()
            lblCuenta_Registros.Text = ObjArchivo.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub

    Protected Sub btnVozyDatos_Click(sender As Object, e As EventArgs) Handles btnVozyDatos.Click
        Try
            dtggeneral.DataSource = Nothing
            lblCuenta_Registros.Text = ""
            dtgVersiones.DataSource = Nothing
            lblcuentaVersiones.Text = ""
            ObjArchivo.Validacion = 11
            dtggeneral.DataSource = ObjArchivo.Consulta_Archivos_Botones()
            dtggeneral.DataBind()
            lblCuenta_Registros.Text = ObjArchivo.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub

    Protected Sub btnFormacion_Click(sender As Object, e As EventArgs) Handles btnFormacion.Click
        Try
            dtggeneral.DataSource = Nothing
            lblCuenta_Registros.Text = ""
            dtgVersiones.DataSource = Nothing
            lblcuentaVersiones.Text = ""
            ObjArchivo.Validacion = 12
            dtggeneral.DataSource = ObjArchivo.Consulta_Archivos_Botones()
            dtggeneral.DataBind()
            lblCuenta_Registros.Text = ObjArchivo.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub

    Protected Sub btnInformacion_Click(sender As Object, e As EventArgs) Handles btnInformacion.Click
        Try
            dtggeneral.DataSource = Nothing
            lblCuenta_Registros.Text = ""
            dtgVersiones.DataSource = Nothing
            lblcuentaVersiones.Text = ""
            ObjArchivo.Validacion = 13
            dtggeneral.DataSource = ObjArchivo.Consulta_Archivos_Botones()
            dtggeneral.DataBind()
            lblCuenta_Registros.Text = ObjArchivo.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub

    Protected Sub btnOtros_Click(sender As Object, e As EventArgs) Handles btnOtros.Click
        Try
            dtggeneral.DataSource = Nothing
            lblCuenta_Registros.Text = ""
            dtgVersiones.DataSource = Nothing
            lblcuentaVersiones.Text = ""
            ObjArchivo.Validacion = 14
            dtggeneral.DataSource = ObjArchivo.Consulta_Archivos_Botones()
            dtggeneral.DataBind()
            lblCuenta_Registros.Text = ObjArchivo.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub
End Class