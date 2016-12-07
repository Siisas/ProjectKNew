Imports System.IO
Imports System.Data.SqlClient

Public Class Cambio
    Inherits System.Web.UI.Page
    Dim objeto As New clsInventario
    Dim FechaActual As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("Permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("Permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                Cargar_drl()
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
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
        Try
            FechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    'Carga las listas desplegables
    Public Sub Cargar_drl()
        Try
            With DrlSede
                .DataSource = objeto.consultasdrl
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With DrlSede0
                .DataSource = objeto.consultasdrl
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With

            With DrlSubresponsable
                .DataSource = objeto.consultarUsuario()
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
            With drlresponsable
                .DataSource = objeto.consultaresponsable()
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
            With drlresponsable0
                .DataSource = objeto.consultaresponsable()
                .DataTextField = "nombreu"
                .DataValueField = "idusuario"
                .DataBind()
            End With
            objeto.Validacion = 1
            With DrlEstado3
                .DataSource = objeto.consultasdrl()
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With DrlEstadoC0
                .DataSource = objeto.consultasdrl()
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            objeto.Validacion = 2
            With DrlZona
                .DataSource = objeto.consultasdrl
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            objeto.Validacion = 3
            With drlclasificacionconsulta
                .DataSource = objeto.consultasdrl()
                .DataTextField = "pertenece"
                .DataValueField = "pertenece"
                .DataBind()
            End With
            objeto.Validacion = 7
            With DrlActivoC0
                .DataSource = objeto.consultasdrl()
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    'realiza los filtros de consulta
    Protected Sub BtBuscarActivo0_Click(sender As Object, e As EventArgs) Handles BtBuscarActivo0.Click
        Try
            dtgHistorial.Visible = False
            LblNregCambios.Visible = False
            lblmsg.Text = ""
            If RdbSede.Checked = False And RdbCod0.Checked = False And Rdbestado1.Checked = False And RdbSerial.Checked = False And Rdbresponsable.Checked = False And RdbClasificacion.Checked = False And RdbN_Acta.Checked = False Then
                lblmsg.Text = "Especifique un criterio de busqueda"
                Exit Sub
            End If
            If TxtSerialConsulta.Text = "" And RdbSerial.Checked = True Then
                lblmsg.Text = "Especifique un serial "
                Exit Sub
            End If
            If RdbSede.Checked = True And DrlSede0.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Especifique la sede "
                Exit Sub
            End If
            If Rdbestado1.Checked = True And DrlEstadoC0.SelectedIndex = 0 Then
                lblmsg.Text = "Especifique el estado "
                Exit Sub
            End If
            If RdbCod0.Checked = True And txtCodInventario0.Text = "" Then
                lblmsg.Text = "Especifique el codigo de inventario "
                Exit Sub
            End If
            If Rdbresponsable.Checked = True And drlresponsable0.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Especifique el Responsable "
                Exit Sub
            End If
            If RdbN_Acta.Checked = True And TxtN_ActaC.Text = "" Then
                lblmsg.Text = "Especifique  N° de acta  "
                Exit Sub
            End If
            If RdbClasificacion.Checked = True And drlclasificacionconsulta.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Especifique Clasificacion "
                Exit Sub
            End If
           
            If DrlSede0.SelectedItem.Text <> "- Seleccione -" And RdbSede.Checked = True And DrlActivoC0.SelectedItem.Text <> "- Seleccione -" Then
                objeto.Sede = DrlSede0.SelectedValue
                objeto.Nombre_Activo = DrlActivoC0.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
                LblN_Registros.Visible = True
                LblN_Registros.Text = objeto.Cantidad
            End If
            If DrlSede0.SelectedItem.Text <> "- Seleccione -" And RdbSede.Checked = True Then
                objeto.Sede = DrlSede0.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
                LblN_Registros.Visible = True
                LblN_Registros.Text = objeto.Cantidad
            End If
            If DrlEstadoC0.SelectedItem.Text <> "- Seleccione -" And Rdbestado1.Checked = True And DrlActivoC0.SelectedItem.Text <> "- Seleccione -" Then
                objeto.Estado = DrlEstadoC0.SelectedValue
                objeto.Nombre_Activo = DrlActivoC0.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
                LblN_Registros.Visible = True
                LblN_Registros.Text = objeto.Cantidad
            End If
            If DrlEstadoC0.SelectedItem.Text <> "- Seleccione -" And Rdbestado1.Checked = True And DrlActivoC0.SelectedItem.Text = "- Seleccione -" Then
                objeto.Estado = DrlEstadoC0.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
                LblN_Registros.Visible = True
                LblN_Registros.Text = objeto.Cantidad
            End If
          
            If TxtSerialConsulta.Text <> "" And RdbSerial.Checked = True Then
                objeto.Serial = TxtSerialConsulta.Text
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
                LblN_Registros.Visible = True
                LblN_Registros.Text = objeto.Cantidad
            End If
            If txtCodInventario0.Text <> "" And RdbCod0.Checked = True Then
                objeto.Cod_Inventario = txtCodInventario0.Text
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
                LblN_Registros.Visible = True
                LblN_Registros.Text = objeto.Cantidad
                objeto.Cod_Inventario = txtCodInventario0.Text
                dtgHistorial.Visible = True
                objeto.Validacion = 2
                dtgHistorial.DataSource = objeto.consultaAcTodo()
                dtgHistorial.DataBind()
                LblNregCambios.Visible = True
                LblNregCambios.Text = objeto.Cantidad1
            End If
            If drlresponsable0.SelectedItem.Text <> "- Seleccione -" And Rdbresponsable.Checked = True Then
                objeto.Responsable = drlresponsable0.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
                LblN_Registros.Visible = True
                LblN_Registros.Text = objeto.Cantidad
            End If
            If TxtN_ActaC.Text <> "" And RdbN_Acta.Checked = True Then
                objeto.No_Acta = TxtN_ActaC.Text
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
                LblN_Registros.Visible = True
                LblN_Registros.Text = objeto.Cantidad
            End If
            If drlclasificacionconsulta.SelectedItem.Text <> "- Seleccione -" And RdbClasificacion.Checked = True Then
                objeto._clasificacion = drlclasificacionconsulta.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
                LblN_Registros.Visible = True
                LblN_Registros.Text = objeto.Cantidad
            End If
            If objeto.Cantidad = 0 Then
                lblmsg.Text = "No se encontraron registros con el criterio de busqueda especificado"
            Else
                BtExportar.Visible = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub BtExportar_Click(sender As Object, e As EventArgs) Handles BtExportar.Click
        Try
            crearexcel()
            BtExportar.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Sub crearexcel() 'crea el ecxel que se exporta de las grillas  dtgxls1 y  dtgxls2 exporta ambas consultas 
        Dim sb As New StringBuilder
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim form = New HtmlForm
        Dim r As New clsInventario
        Dim objdtsconsultaxls As New DataSet
        Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
        Dim Validar As Boolean
        If DrlSede0.SelectedValue <> "- Seleccione -" And RdbSede.Checked = True Then
            objeto.Sede = DrlSede0.SelectedValue
            Validar = True
        End If
        If TxtSerialConsulta.Text <> "" And RdbSerial.Checked = True Then
            objeto.Serial = TxtSerialConsulta.Text
            Validar = True
        End If
        If DrlEstadoC0.SelectedValue <> "- Seleccione -" And Rdbestado1.Checked = True Then
            objeto.Estado = DrlEstadoC0.SelectedValue
            Validar = True
        End If
        If txtCodInventario0.Text <> "" And RdbCod0.Checked = True Then
            objeto.Cod_Inventario = txtCodInventario0.Text
            Validar = True
        End If
        If drlclasificacionconsulta.SelectedValue <> "- Seleccione -" And RdbClasificacion.Checked = True Then
            objeto._clasificacion = drlclasificacionconsulta.SelectedValue
            Validar = True
        End If
        If TxtN_ActaC.Text <> "" And RdbN_Acta.Checked = True Then
            objeto.No_Acta = TxtN_ActaC.Text
            Validar = True
        End If
        If drlresponsable0.SelectedItem.Text <> "- Seleccione -" And Rdbresponsable.Checked = True Then
            objeto.Responsable = drlresponsable0.SelectedValue
            Validar = True
        End If
        If Validar = True Then
            dtgxls1.DataSource = objeto.consultaAcTodo
            dtgxls1.DataBind()
            dtgxls1.Visible = True
            dtgxls1.EnableViewState = False
            If txtCodInventario0.Text <> "" Then
                objeto.Cod_Inventario = txtCodInventario0.Text
                objeto.Validacion = 2
                dtgxls2.DataSource = objeto.consultaAcTodo
                dtgxls2.DataBind()
                dtgxls2.Visible = True
                dtgxls2.EnableViewState = False
            End If
            pagina.EnableEventValidation = False
            pagina.DesignerInitialize()
            pagina.Controls.Add(form)
            form.Controls.Add(dtgxls1)
            form.Controls.Add(dtgxls2)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=Inventario_Activos_cambios.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Else
            lblmsg.Text = "Porfavor verifique que el tipo de consuta selecionada, no este en blanco, o tenga una opcion"
        End If
    End Sub
    Protected Sub dtgasig_PageIndexChanging _
       (ByVal sender As Object, ByVal e As GridViewPageEventArgs) Handles dtgInvt.PageIndexChanging
        dtgInvt.PageIndex = e.NewPageIndex
        cambioindicedtgasig()
    End Sub
    Protected Sub dtghistorial_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgHistorial.PageIndexChanging, dtgHistorial.PageIndexChanging
        Try
            dtgHistorial.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            cambioindicehistorial()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Sub cambioindicehistorial()
        Try
            If txtCodInventario0.Text <> "" And RdbCod0.Checked = True Then
                objeto.Cod_Inventario = txtCodInventario0.Text
                objeto.Validacion = 2
                dtgHistorial.DataSource = objeto.consultaAcTodo()
                dtgHistorial.DataBind()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Sub cambioindicedtgasig() 'verifica que al menos haya una consulta seleccionada para cambiar la paginacion 
        Try
            If DrlSede0.Text <> "0" And RdbSede.Checked = True Then
                objeto.Sede = DrlSede0.SelectedValue
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
                If DrlActivoC0.SelectedValue <> "- Seleccione -" And RdbSede.Checked = True Then
                    objeto.Nombre_Activo = DrlActivoC0.SelectedValue
                    dtgInvt.DataSource = objeto.consultaAcTodo()
                    dtgInvt.DataBind()
                End If
            End If
            If DrlEstadoC0.SelectedValue <> "- Seleccione -" And Rdbestado1.Checked = True And DrlActivoC0.SelectedValue = "2" Then
                objeto.Estado = DrlEstadoC0.SelectedValue
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If
            If DrlActivoC0.SelectedValue <> "- Seleccione -" And Rdbestado1.Checked = True And DrlEstadoC0.Text <> "0" Then
                objeto.Nombre_Activo = DrlActivoC0.SelectedValue
                objeto.Estado = DrlEstadoC0.SelectedValue
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If
            If txtCodInventario0.Text <> "" And RdbCod0.Checked = True Then
                objeto.Cod_Inventario = txtCodInventario0.Text
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
                objeto.Cod_Inventario = txtCodInventario0.Text
                objeto.Validacion = 2
                dtgHistorial.DataSource = objeto.consultaAcTodo()
                dtgHistorial.DataBind()
            End If
            If TxtSerialConsulta.Text <> "" And RdbSerial.Checked = True Then
                objeto.Serial = TxtSerialConsulta.Text
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If
            If drlresponsable0.SelectedItem.Text <> "- Seleccione -" And Rdbresponsable.Checked = True Then
                objeto.Responsable = drlresponsable0.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If
            If TxtN_ActaC.Text <> "" And RdbN_Acta.Checked = True Then
                objeto.No_Acta = TxtN_ActaC.Text
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If
            If drlclasificacionconsulta.SelectedItem.Text <> "- Seleccione -" And RdbClasificacion.Checked = True Then
                objeto._clasificacion = drlclasificacionconsulta.SelectedValue
                dtgInvt.Visible = True
                dtgInvt.DataSource = objeto.consultaAcTodo()
                dtgInvt.DataBind()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    'llena las herramientas (Texboxt,Dropdowlist) Con el Activo que sea seleccionado en el GridView
    Protected Sub dtgasig_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtgInvt.RowCommand
        Try
            If e.CommandName = "Seleccione" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                lblmsg.Text = ""
                Lblcodigocambio.Text = dtgInvt.Rows(index).Cells(1).Text
                objeto.Cod_Inventario = Lblcodigocambio.Text
                objeto.consultadtgcodigos()
                If objeto.Responsable = "" Then
                    drlresponsable.SelectedIndex = "0"
                Else
                    drlresponsable.SelectedValue = objeto.Responsable
                End If
                Lblserialcambio.Text = objeto.Serial
                TxtDescripcionActivo.Text = objeto.Descripcion
                DrlEstado3.SelectedValue = objeto.Estado
                DrlSede.SelectedValue = objeto.Sede
                DrlZona.SelectedValue = objeto.Zona
                If objeto.subResponsable = "" Then
                    DrlSubresponsable.SelectedIndex = "0"
                Else
                    DrlSubresponsable.SelectedValue = objeto.subResponsable
                End If


                TxtN_Acta.Text = objeto.No_Acta
                If DrlEstado3.SelectedValue = "Baja" Then
                    Panel1.Visible = True
                End If
                If Lblcodigocambio.Text <> "" Then
                    DrlEstado3.Enabled = True
                    DrlZona.Enabled = True
                    DrlSede.Enabled = True
                    drlresponsable.Enabled = True
                    TxtDescripcionActivo.ReadOnly = False
                    TxtObservacion.ReadOnly = False
                    DrlSubresponsable.Enabled = True
                    TxtN_Acta.ReadOnly = False
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    ' realiza las actualizaciones a un activo 
    Protected Sub BtCambiarEstado1_Click(sender As Object, e As EventArgs) Handles BtCambiarEstado1.Click
        Try
            lblmsg.Text = " "
            If Lblcodigocambio.Text = "" Then
                lblmsg.Text = "Debe consultar primero el registro que desee modificar"
                Exit Sub
            End If
            If DrlSede.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Debe seleccionar la sede"
                DrlSede.Focus()
                Exit Sub
            End If
            If DrlZona.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Debe seleccionar la Zona"
                DrlSede.Focus()
                Exit Sub
            End If
            If drlresponsable.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un responsable"
                drlresponsable.Focus()
                Exit Sub
            End If
            If DrlSubresponsable.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un Usuario"
                DrlSubresponsable.Focus()
                Exit Sub
            End If
            If TxtDescripcionActivo.Text = "" Then
                lblmsg.Text = "Digite una Descripcion"
                DrlSubresponsable.Focus()
                Exit Sub
            End If
            If DrlEstado3.SelectedValue = "Baja" Then
                If TxtN_Acta.Text = "" Then
                    lblmsg.Text = "Recuerde que si el estado es 'Baja' debe asociar el numero de acta"
                    TxtN_Acta.Focus()
                    Exit Sub
                End If
            Else
                TxtN_Acta.Text = ""
            End If
            Me.TxtObservacion.Text = Trim(Replace(Me.TxtObservacion.Text, " ", " "))
            If TxtObservacion.Text = "" Then
                lblmsg.Text = "Debe asignar una observacion"
                TxtObservacion.Focus()
                Exit Sub
            End If
            If DrlEstado3.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Debe Seleccionar el estado a cambiar "
                DrlEstado3.Focus()
                Exit Sub
            End If
            objeto.Estado = DrlEstado3.SelectedValue
            objeto.Serial = Lblserialcambio.Text
            objeto.Zona = DrlZona.SelectedValue
            objeto.Sede = DrlSede.SelectedValue
            objeto.Responsable = drlresponsable.SelectedValue
            objeto.Descripcion = TxtDescripcionActivo.Text
            objeto.subResponsable = DrlSubresponsable.SelectedValue
            objeto.No_Acta = TxtN_Acta.Text
            objeto.Cod_Inventario = Lblcodigocambio.Text
            objeto.CambiarActivo()
            Me.TxtObservacion.Text = Trim(Replace(Me.TxtObservacion.Text, " ", " "))
            objeto._Observacion_Cambio = TxtObservacion.Text
            objeto.FcReg_Invent = FechaActual
            objeto.Id_Usuario = lblusuario.Text
            objeto.registrarActivocambio()
            If objeto.valida = 1 Then
                lblmsg.Text = "error"
            Else
                lblmsg.Text = "Cambios realizados con exito"
                Lblserialcambio.Text = ""
                TxtObservacion.Text = ""
                TxtDescripcionActivo.Text = ""
                Lblcodigocambio.Text = ""
                DrlEstado3.Enabled = False
                DrlZona.Enabled = False
                DrlSede.Enabled = False
                drlresponsable.Enabled = False
                DrlSubresponsable.Enabled = False
                Panel1.Visible = False
                TxtN_Acta.Text = ""
                TxtObservacion.ReadOnly = True
                TxtDescripcionActivo.ReadOnly = True
                DrlEstado3.SelectedIndex = 0
                DrlSubresponsable.SelectedIndex = 0
                DrlZona.SelectedIndex = 0
                DrlSede.SelectedIndex = 0
                drlresponsable.SelectedIndex = 0
            End If
        Catch ex As Exception
            lblmsg.Text = "ERROR:" & ex.Message
        End Try
    End Sub
    'si en la lista DrlEstado3 es igual a "Baja" Se muestra el campo de No de acta para ser ingresado
    Protected Sub DrlEstado3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DrlEstado3.SelectedIndexChanged
        If DrlEstado3.SelectedValue = "Baja" Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
    End Sub
    'realiza el carge del archivo excel con formato .xlsx para realizar la actualizacion masiva 
    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
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
            dtgUpdate.DataSource = objeto.UpdateExcel()
            dtgUpdate.DataBind()
            Registrar()
            If objeto.valida = 1 Then
                lblmsg.Text = "Los registros que intenta modificar no se encuentran en la base de datos"
                Exit Sub
            Else
                lblmsg.Text = "Actualizacion exitosa"
            End If
        Catch ex As Exception
            lblmsg.Text = "ERROR:" & ex.Message
        End Try
    End Sub



    Public Sub Registrar() ' Recorre el GridView  "dtgUpdate" y reliza la respectiva actualizacion 
        Try
            For Each row As GridViewRow In dtgUpdate.Rows
                objeto.Cod_Inventario = row.Cells(0).Text
                objeto.Estado = row.Cells(1).Text
                objeto.Sede = row.Cells(2).Text
                objeto.Zona = row.Cells(3).Text
                objeto.Responsable = row.Cells(4).Text
                objeto.subResponsable = row.Cells(5).Text
                objeto.No_Acta = row.Cells(6).Text
                objeto.FcReg_Invent = row.Cells(7).Text
                objeto.Id_Usuario = row.Cells(8).Text
                objeto._Observacion_Cambio = row.Cells(9).Text
                objeto.Descripcion = row.Cells(10).Text
                objeto.CambiarActivo()
                objeto.registrarActivocambio()
                If objeto.Validacion = 1 Then
                    lblmsg.Text = "Verifique que los cambios esten asociados a un codigo valido en el inventario"
                End If
            Next
        Catch ex As Exception
            lblmsg.Text = "Se produjo error:" & ex.Message
        Finally

        End Try
    End Sub


End Class