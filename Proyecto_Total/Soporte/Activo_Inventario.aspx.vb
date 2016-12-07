Imports System.IO
Public Class cambiestilo
    Inherits System.Web.UI.Page
    Public objeto As New clsInventario
    Dim FechaActual As String


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Obtengo los datos del usuario'
        Try
            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("Permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("Permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                cargardrl()
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
        'Cargo la fecha actual'
        Try
            FechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            objeto.FcReg_Invent = FechaActual
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    ' Carge listas desplegables
    Protected Sub cargardrl()
        With drlresponsable
            .DataSource = objeto.consultaresponsable()
            .DataTextField = "nombreu"
            .DataValueField = "Idusuario"
            .DataBind()
        End With

        With drlsub_responsable
            .DataSource = objeto.consultarUsuario()
            .DataTextField = "nombreu"
            .DataValueField = "Idusuario"
            .DataBind()
        End With
        With drlsubResponsable
            .DataSource = objeto.consultarUsuario()
            .DataTextField = "nombreu"
            .DataValueField = "Idusuario"
            .DataBind()
        End With

        With drlresponsable
            .DataSource = objeto.consultaresponsable()
            .DataTextField = "nombreu"
            .DataValueField = "Idusuario"
            .DataBind()
        End With
        With drlresponsable0
            .DataSource = objeto.consultaresponsable()
            .DataTextField = "nombreu"
            .DataValueField = "Idusuario"
            .DataBind()
        End With
        With drlcodresponsable
            .DataSource = objeto.consultaresponsable()
            .DataTextField = "Codnom"
            .DataValueField = "Idusuario"
            .DataBind()
        End With

        With drlSedeActivo
            .DataSource = objeto.consultasdrl()
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        objeto.Validacion = 1
        If objeto.Validacion = 1 Then
            With drlEstadoActivo
                .DataSource = objeto.consultasdrl()
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            objeto.Validacion = 2
        End If
        If objeto.Validacion = 2 Then
            With drlZonaActivo
                .DataSource = objeto.consultasdrl()
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With drlZona
                .DataSource = objeto.consultasdrl()
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            objeto.Validacion = 3
        End If
        If objeto.Validacion = 3 Then
            With drlclasificacion
                .DataSource = objeto.consultasdrl()
                .DataTextField = "pertenece"
                .DataValueField = "pertenece"
                .DataBind()
            End With
            With drlclasificacionconsulta
                .DataSource = objeto.consultasdrl()
                .DataTextField = "pertenece"
                .DataValueField = "pertenece"
                .DataBind()
            End With
            With drlclasificacion0
                .DataSource = objeto.consultasdrl()
                .DataTextField = "Pertenece"
                .DataValueField = "Pertenece"
                .DataBind()
            End With
            objeto.Validacion = 4
        End If
        If objeto.Validacion = 4 Then
            With drlMarcaActivo
                .DataSource = objeto.consultasdrl()
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With drlMarca
                .DataSource = objeto.consultasdrl()
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            objeto.Validacion = 5
        End If

        If objeto.Validacion = 5 Then
            With drlReferencia
                .DataSource = objeto.consultasdrl()
                .DataTextField = "Referencia"
                .DataValueField = "Referencia"
                .DataBind()
            End With
            objeto.Validacion = 6
        End If
        If objeto.Validacion = 6 Then
            With drlPertenece
                .DataSource = objeto.consultasdrl()
                .DataTextField = "Pertenece"
                .DataValueField = "Pertenece"
                .DataBind()
            End With
            objeto.Validacion = 7
        End If
        If objeto.Validacion = 7 Then
            With drlNombreActivo0
                .DataSource = objeto.consultasdrl()
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
        End If
    End Sub

    'Registro de activo
    Protected Sub btnRegistrarActivo_Click(sender As Object, e As EventArgs) Handles btnRegistrarActivo.Click
        Try
            If drlclasificacion.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Debe seleccionar clasificacion"
                drlclasificacion.Focus()
                Exit Sub
            End If
            If drlNombreActivo.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Debe seleccionar un activo"
                drlNombreActivo.Focus()
                Exit Sub
            End If
            TxtSerialActivo.Text = Trim(Replace(TxtSerialActivo.Text, " ", " "))
            If TxtSerialActivo.Text = "" Then
                lblmsg.Text = "Debe llenar el campo serial activo"
                TxtSerialActivo.Focus()
                Exit Sub
            End If
            If drlSedeActivo.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Debe seleccionar una sede"
                drlSedeActivo.Focus()
                Exit Sub
            End If
            If drlZonaActivo.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Debe seleccionar una zona"
                drlZonaActivo.Focus()
                Exit Sub
            End If
            If drlMarcaActivo.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Debe seleccionar la marca del activo"
                drlMarcaActivo.Focus()
                Exit Sub
            End If
            TxtReferenciaActivo.Text = Trim(Replace(TxtReferenciaActivo.Text, " ", " "))
            If TxtReferenciaActivo.Text = "" Then
                lblmsg.Text = "Debe llenar el campo referencia"
                TxtReferenciaActivo.Focus()
                Exit Sub
            End If
            TxtDescripcionActivo.Text = Trim(Replace(TxtDescripcionActivo.Text, " ", " "))
            If TxtDescripcionActivo.Text = "" Then
                lblmsg.Text = "Debe llenar el campo descripcion"
                TxtDescripcionActivo.Focus()
                Exit Sub
            End If
            If drlresponsable.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Debe seleccionar un responsable"
                drlresponsable.Focus()
                Exit Sub
            End If
            If drlsubResponsable.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Debe seleccionar un USUARIO"
                drlsubResponsable.Focus()
                Exit Sub
            End If
            If drlEstadoActivo.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Debe seleccionar el estado del activo"
                drlEstadoActivo.Focus()
                Exit Sub
            End If
            If drlEstadoActivo.SelectedItem.Text <> "Baja" Then
                TxtN_Acta.Text = ""
            End If
            If drlEstadoActivo.SelectedItem.Text = "Baja" And TxtN_Acta.Text = "" Then
                lblmsg.Text = "Debe ingresar el numero de acta de baja"
                TxtN_Acta.Focus()
                Exit Sub
            End If
            TxtReferenciaActivo.Text = Trim(Replace(TxtReferenciaActivo.Text, " ", " "))
            Dim sigla As String = Mid(TxtSerialActivo.Text, 7, 2)
            objeto.Id_Usuario = lblusuario.Text
            objeto.Nombre_Activo = drlNombreActivo.SelectedValue
            objeto.Serial = TxtSerialActivo.Text
            TxtSerialConsulta.Text = UCase(TxtSerialConsulta.Text)
            objeto._Sigla = sigla
            objeto.Estado = drlEstadoActivo.SelectedValue
            objeto.Marca = drlMarcaActivo.SelectedValue
            objeto.Sede = drlSedeActivo.SelectedValue
            objeto.Zona = drlZonaActivo.SelectedValue
            objeto.Responsable = drlresponsable.SelectedValue
            objeto.Modelo = TxtReferenciaActivo.Text
            objeto.Descripcion = TxtDescripcionActivo.Text
            objeto.subResponsable = drlsubResponsable.SelectedValue
            objeto.No_Acta = TxtN_Acta.Text
            objeto.registrarActivo()
            If objeto.valida = 1 Then
                lblmsg.Text = "Ya hay un registro con el serial " & TxtSerialActivo.Text & "  verifique"
            Else
                lblmsg.Text = " Registro Exitoso"
                drlclasificacion.SelectedIndex = 0
                drlSedeActivo.SelectedIndex = 0
                drlZonaActivo.SelectedIndex = 0
                drlMarcaActivo.SelectedIndex = 0
                drlresponsable.SelectedIndex = 0
                drlsubResponsable.SelectedIndex = 0
                drlEstadoActivo.SelectedIndex = 0
                drlNombreActivo.SelectedIndex = 0
                TxtReferenciaActivo.Text = ""
                TxtDescripcionActivo.Text = ""
                TxtSerialActivo.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Error Verifique"
        End Try
        Exit Sub
    End Sub
    'Con este metodo se realiza el registros de marcas,activos,estados,sedes y zonas que no se encuentren registradas en la base de datos 
    Protected Sub btnRegistrarNuevo_Click(sender As Object, e As EventArgs) Handles btnRegistrarNuevo.Click
        Try
            TxtNombre.Text = Trim(Replace(TxtNombre.Text, " ", " "))
            If TxtNombre.Text = "" Then
                lblmsg.Text = "Debe llenar el campo Nombre"
                TxtNombre.Focus()
                Exit Sub
            End If
            If drlPertenece.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Debe asignar pertenencia"
                drlPertenece.Focus()
                Exit Sub
            End If
            If drlPertenece.SelectedItem.Text = "Activo" Then
                If drlclasificacion0.SelectedValue = "- Seleccione -" Then
                    lblmsg.Text = "Debe clasificar el activo"
                    drlclasificacion0.Focus()
                    Exit Sub
                End If
                objeto._Nombre = TxtNombre.Text
                objeto._Pertenece = drlclasificacion0.SelectedValue
                objeto.Registrar()

                If objeto.valida = 0 Then
                    lblmsg.Text = "Registro Exitoso"
                    objeto.Validacion = 7
                    With drlNombreActivo0
                        .DataSource = objeto.consultasdrl()
                        .DataTextField = "Nombre"
                        .DataValueField = "Nombre"
                        .DataBind()
                    End With
                    TxtNombre.Text = ""
                    drlPertenece.SelectedIndex = 0
                    drlclasificacion0.SelectedIndex = 0
                Else
                    lblmsg.Text = "Ya existe un registro '" & TxtNombre.Text & "' en la base de datos, ingrese  datos validos"
                End If
                Exit Sub
            End If

            If drlPertenece.SelectedValue <> "Activo" Then
                objeto._Nombre = TxtNombre.Text
                objeto._Pertenece = drlPertenece.SelectedValue
                objeto.Registrar()

                If objeto.valida = 1 Then
                    lblmsg.Text = "Ya existe un registro '" & TxtNombre.Text & "' en la base de datos, ingrese  datos validos"
                Else
                    lblmsg.Text = "Registro Exitoso"

                    If drlPertenece.SelectedValue = "Marca" Then
                        objeto.Validacion = 4
                        With drlMarcaActivo
                            .DataSource = objeto.consultasdrl()
                            .DataTextField = "Nombre"
                            .DataValueField = "Nombre"
                            .DataBind()
                        End With
                    End If

                    If drlPertenece.SelectedValue = "Estado" Then
                        objeto.Validacion = 1
                        With drlEstadoActivo
                            .DataSource = objeto.consultasdrl()
                            .DataTextField = "Nombre"
                            .DataValueField = "Nombre"
                            .DataBind()
                        End With
                    End If

                    If drlPertenece.SelectedValue = "Zona" Then
                        objeto.Validacion = 2
                        With drlZona
                            .DataSource = objeto.consultasdrl
                            .DataTextField = "Nombre"
                            .DataValueField = "Nombre"
                            .DataBind()
                        End With
                    End If
                    If drlPertenece.SelectedValue = "Sede" Then
                        With drlSedeActivo
                            .DataSource = objeto.consultasdrl()
                            .DataTextField = "Nombre"
                            .DataValueField = "Nombre"
                            .DataBind()
                        End With
                        TxtNombre.Text = ""
                        drlPertenece.SelectedIndex = 0
                    End If
                End If
                TxtNombre.Text = ""
                drlPertenece.SelectedIndex = 0
                drlclasificacion0.SelectedIndex = 0
            End If
        Catch ex As Exception
            lblmsg.Text = "Ya existe un registro '" & TxtNombre.Text & "' en la base de datos, ingrese  datos validos"
        End Try

    End Sub
    'realiza los diferente filtros de busqueda
    Protected Sub btnConsultarActivo_Click(sender As Object, e As EventArgs) Handles btnConsultarActivo.Click
        Try
            lblmsg.Text = ""
            If RdbSeriall.Checked = False And Rdbresponsable.Checked = False And RdbZona.Checked = False And RdbActivo.Checked = False And RdbClasificacion.Checked = False And Rdbmarca.Checked = False And Rdbcodres.Checked = False And RdbN_ActaC.Checked = False And Rdbsub_responsable.Checked = False Then
                lblmsg.Text = "Selecccione un criterio de busqueda"
                Exit Sub
            End If

            If RdbSeriall.Checked = True And TxtSerialConsulta.Text = "" Then
                lblmsg.Text = "Especifique el serial"
                Exit Sub
            End If

            If Rdbresponsable.Checked = True And drlresponsable0.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Especifique El Responsable"
                Exit Sub
            End If

            If RdbZona.Checked = True And drlZona.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Especifique la zona"
                Exit Sub
            End If

            If RdbActivo.Checked = True And drlNombreActivo0.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Especifique el activo"
                Exit Sub
            End If

            If RdbClasificacion.Checked = True And drlclasificacionconsulta.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Especifique una clasificacion"
                Exit Sub
            End If

            If Rdbmarca.Checked = True And drlMarca.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Especifique una marca"
                Exit Sub
            End If

            If Rdbcodres.Checked = True And drlcodresponsable.SelectedItem.Text = "" Then
                lblmsg.Text = "Especifique un codigo"
                Exit Sub
            End If

            If Rdbsub_responsable.Checked = True And drlsub_responsable.SelectedItem.Text = "- Seleccione -" And drlsub_responsable.SelectedItem.Text = "" Then
                lblmsg.Text = "Especifique el usuario"
                Exit Sub
            End If
            If RdbN_ActaC.Checked = True And TxtN_ActaC.Text = "" Then
                lblmsg.Text = "Especifique N° de Acta"
                Exit Sub
            End If
            If TxtSerialConsulta.Text <> Nothing And RdbSeriall.Checked = True Then
                objeto.Serial = TxtSerialConsulta.Text
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If

            If drlresponsable0.SelectedValue <> "- Seleccione -" And Rdbresponsable.Checked = True Then
                objeto.Responsable = drlresponsable0.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If

            If drlZona.SelectedValue <> "- Seleccione -" And RdbZona.Checked = True Then
                objeto.Zona = drlZona.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If

            If drlNombreActivo0.SelectedValue <> "- Seleccione -" And RdbActivo.Checked = True And drlReferencia.SelectedValue <> "- Seleccione -" Then
                objeto.Nombre_Activo = drlNombreActivo0.SelectedValue
                objeto.Modelo = drlReferencia.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If

            If drlNombreActivo0.SelectedValue <> "- Seleccione -" And RdbActivo.Checked = True Then
                objeto.Nombre_Activo = drlNombreActivo0.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If

            If drlclasificacionconsulta.SelectedValue <> "- Seleccione -" And RdbClasificacion.Checked = True Then
                objeto._clasificacion = drlclasificacionconsulta.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If

            If drlMarca.SelectedValue <> "- Seleccione -" And Rdbmarca.Checked = True Then
                objeto.Marca = drlMarca.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If

            If drlcodresponsable.SelectedValue <> "- Seleccione -" And Rdbcodres.Checked = True Then
                objeto.Responsable = drlcodresponsable.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If

            If drlsub_responsable.SelectedValue <> "- Seleccione -" And drlsub_responsable.SelectedValue <> "" And Rdbsub_responsable.Checked = True Then
                objeto.subResponsable = drlsub_responsable.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If

            If TxtN_ActaC.Text <> "" And RdbN_ActaC.Checked = True Then
                objeto.No_Acta = TxtN_ActaC.Text
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If

            LblN_Registros.Visible = True
            LblN_Registros.Text = objeto.Cantidad
            If objeto.Cantidad = 0 Then
                lblmsg.Text = "No se encontraron registros con el criterio de busqueda especificado"
                btnExportarActivo.Visible = False
                dtgInvt.Visible = False
                LblN_Registros.Visible = False
            Else
                btnExportarActivo.Visible = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " & ex.Message
        End Try
    End Sub

    Protected Sub btnExportarActivo_Click(sender As Object, e As EventArgs) Handles btnExportarActivo.Click
        Try
            crearexcel2()
            btnExportarActivo.Visible = True
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
            lblmsg.ForeColor = Drawing.Color.Red
        End Try
    End Sub
    Protected Sub crearexcel2() 'crea el excel a exportar
        Dim sb As New StringBuilder
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim form = New HtmlForm
        Dim r As New clsInventario
        Dim objdtsconsultaxls As New DataSet
        Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
        Dim Validar As Boolean

        If TxtSerialConsulta.Text <> "" And RdbSeriall.Checked = True Then
            objeto.Serial = TxtSerialConsulta.Text
            Validar = True
        End If
        If drlresponsable0.SelectedItem.Text <> "- Seleccione -" And Rdbresponsable.Checked = True Then
            objeto.Responsable = drlresponsable.SelectedValue
            Validar = True
        End If
        If drlZona.SelectedItem.Text <> "- Seleccione -" And RdbZona.Checked = True Then
            objeto.Zona = drlZona.SelectedValue
            Validar = True
        End If
        If drlNombreActivo0.SelectedItem.Text <> "- Seleccione -" And RdbActivo.Checked = True Then
            objeto.Nombre_Activo = drlNombreActivo0.SelectedValue
            Validar = True
        End If
        If drlMarca.SelectedItem.Text <> "- Seleccione -" And Rdbmarca.Checked = True Then
            objeto.Marca = drlMarca.SelectedValue
            Validar = True
        End If
        If drlclasificacionconsulta.SelectedItem.Text <> "- Seleccione -" And RdbClasificacion.Checked = True Then
            objeto._clasificacion = drlclasificacionconsulta.SelectedValue
            Validar = True
        End If
        If drlcodresponsable.SelectedItem.Text <> "- Seleccione -" And Rdbcodres.Checked = True Then
            objeto.Responsable = drlcodresponsable.SelectedValue
            Validar = True
        End If
        If Validar = True Then
            dtgxls.DataSource = objeto.consultaAcTodo()
            dtgxls.DataBind()
            dtgxls.Visible = True
            dtgxls.EnableViewState = False
            pagina.EnableEventValidation = False
            pagina.DesignerInitialize()
            pagina.Controls.Add(form)
            form.Controls.Add(dtgxls)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=Inventario_Activos.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Else
            lblmsg.Text = "Porfavor verifique que el tipo de consuta selecionada, no este en blanco, o tenga una opcion"
        End If
    End Sub

    'realiza el carge del archivo excel con formato .xlsx con el cual se realiza el registro masivo de activos 
    Protected Sub btnRegistrarActivo0_Click(sender As Object, e As EventArgs) Handles btnRegistrarActivo0.Click
        Try
            If Path.GetExtension(FileUpload1.FileName).ToLower() = "" Then
                lblmsg.Text = "Seleccione un archivo del equipo"
                Exit Sub
            End If
            If Path.GetExtension(FileUpload1.FileName).ToLower() <> ".xlsx" Then
                lblmsg.Text = "El formato no es correcto"
                Exit Sub
            End If
            FileUpload1.SaveAs(Server.MapPath("~/Usuarios/" & Path.GetFileName(FileUpload1.FileName)))
            Server.MapPath("~/Usuarios/" & Path.GetFileName(FileUpload1.FileName))
            objeto._Ruta_Excel = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("~/Usuarios/" & Path.GetFileName(FileUpload1.FileName)) & ";Extended Properties=Excel 12.0;"
            objeto.Id_Usuario = lblusuario.Text
            objeto.Validacion = 2
            objeto.AExcel()
            If objeto.Cantidad = 0 Then
                lblmsg.Text = " La informacion que intenta ingresar ya existe "
                Exit Sub
            Else
                lblmsg.Text = " Se realizaron " & objeto.Cantidad & " registros efectivos"
            End If
        Catch ex As Exception
            lblmsg.Text = "ERROR:" & ex.Message
        End Try
    End Sub
    Protected Sub dtgInvt_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtgInvt.PageIndexChanging
        Try
            dtgInvt.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            cambioindicedtgasig()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Sub cambioindicedtgasig()
        Try
            If TxtSerialConsulta.Text <> " " And RdbSeriall.Checked = True Then
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
                If drlresponsable.Text <> " " And Rdbresponsable.Checked = True Then
                    objeto.Responsable = drlresponsable.SelectedValue
                    dtgInvt.Visible = True
                    dtgInvt.DataSource = objeto.consultaAcTodo()
                    dtgInvt.DataBind()
                End If
            End If
            If drlZona.SelectedValue <> "0" And RdbZona.Checked = True Then
                objeto.Zona = drlZona.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If
            If drlNombreActivo0.SelectedValue <> "0" And RdbActivo.Checked = True Then
                objeto.Nombre_Activo = drlNombreActivo0.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If
            If drlresponsable0.SelectedValue <> "- Seleccione -" And Rdbresponsable.Checked = True Then
                objeto.Responsable = drlresponsable0.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If

            If drlclasificacionconsulta.SelectedValue <> "- Seleccione -" And RdbClasificacion.Checked = True Then
                objeto._clasificacion = drlclasificacionconsulta.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If
            If drlMarca.SelectedValue <> "- Seleccione -" And Rdbmarca.Checked = True Then
                objeto.Marca = drlMarca.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If
            If drlcodresponsable.SelectedValue <> "- Seleccione -" And Rdbcodres.Checked = True Then
                objeto.Responsable = drlcodresponsable.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If
            If drlsub_responsable.SelectedValue <> "- Seleccione -" And Rdbsub_responsable.Checked = True Then
                objeto.subResponsable = drlsub_responsable.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If
            If TxtN_ActaC.Text <> "" And RdbN_ActaC.Checked = True Then
                objeto.No_Acta = TxtN_ActaC.Text
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    'carga la lista drlNombreActivo segun lo seleccionado en la lista de clasificacion
    Protected Sub drlclasificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlclasificacion.SelectedIndexChanged
        With drlNombreActivo
            objeto._Pertenece = drlclasificacion.SelectedValue
            .DataSource = objeto.consultaActivo
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
    End Sub
    Protected Sub drlPertenece_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlPertenece.SelectedIndexChanged
        If drlPertenece.SelectedValue = "Activo" Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
    End Sub

    Protected Sub TxtSerialActivo_TextChanged(sender As Object, e As EventArgs) Handles TxtSerialActivo.TextChanged
        Me.TxtSerialActivo.Text = Trim(Replace(Me.TxtSerialActivo.Text, " ", " ")) 'evita el ingreso de espacios y espacios duros
        TxtSerialActivo.Text = UCase(TxtSerialActivo.Text) 'las letras que se encuentren en el serial siempre iran en mayuscula
    End Sub

    Protected Sub drlEstadoActivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlEstadoActivo.SelectedIndexChanged
        If drlEstadoActivo.SelectedValue = "Baja" Then
            Panel3.Visible = True
        Else
            Panel3.Visible = False
        End If
    End Sub
End Class