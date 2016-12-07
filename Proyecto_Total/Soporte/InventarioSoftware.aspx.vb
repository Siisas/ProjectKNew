Imports System.IO

Public Class InventarioSoftware
    Inherits System.Web.UI.Page
    Dim ObjInventario As New clsInventario
    Dim dt As DataTable
    Dim valor As Int16

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario 'obtengo los datos del usuario logueado tales como nombre,nembre del prefil, supervisor 
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                cargar_drl() 'cargue de listas desplegables
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

    Public Sub cargar_drl()
        With Drl_tipo_licencia
            .DataSource = ObjInventario.Consulta_Licencias()
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        With Drl_tipo_licencia2
            .DataSource = ObjInventario.Consulta_Licencias()
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        With Drl_tipo_licencia_actualizar
            .DataSource = ObjInventario.Consulta_Licencias()
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        ObjInventario.Validacion = "Modulos"
        With Drl_modulo
            .DataSource = ObjInventario.Consulta_Licencias
            .DataTextField = "ID_Modulo"
            .DataValueField = "ID_Modulo"
            .DataBind()
        End With
        With Drl_modulo_2
            .DataSource = ObjInventario.Consulta_Licencias
            .DataTextField = "ID_Modulo"
            .DataValueField = "ID_Modulo"
            .DataBind()
        End With
        ObjInventario.Validacion = "Programas"
        With Drl_Programas
            .DataSource = ObjInventario.Consulta_Licencias()
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        With Drl_Programas2
            .DataSource = ObjInventario.Consulta_Licencias()
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        With Drl_producto_actualizar
            .DataSource = ObjInventario.Consulta_Licencias()
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
    End Sub

    Public Sub limpiar()
        Txt_obs_reg.Text = ""
        txt_Version.Text = ""
        Txt_codigo_licencia.Text = ""
        Txt_fecha_instalacion.Text = ""
        Drl_tipo_licencia.SelectedValue = "- Seleccione -"
        Drl_Programas.SelectedValue = "- Seleccione -"
    End Sub

    Protected Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            If RdbtnModulo.Checked = False And RdbtnSerial.Checked = False Then
                lblmsg.Text = "Seleccione una Opcion"
                Exit Sub
            End If
            If RdbtnModulo.Checked = True Then
                If Drl_modulo.SelectedValue = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione Un Modulo"
                    Exit Sub
                End If
                ObjInventario.ID_Modulo = Drl_modulo.SelectedValue
            Else
                Txt_serial.Text = LTrim(Txt_serial.Text)
                Txt_serial.Text = RTrim(Txt_serial.Text)
                If Txt_serial.Text = "" Then
                    lblmsg.Text = "Digite Un Serial"
                    Exit Sub
                End If
                ObjInventario.Serial_Kamilion = Txt_serial.Text
            End If
            ObjInventario.Consulta_Inventario()
            If ObjInventario.Cantidad <= 0 Then
                lblmsg.Text = "No Existen Registros"
                Exit Sub
            End If
            Lbl_serial.Text = ObjInventario.Serial_Kamilion
            lbl_sede.Text = ObjInventario.Sede
            Lbl_empresa.Text = ObjInventario.Empresa
            Lbl_modelo.Text = ObjInventario.Modelo
            Lbl_Codigo_inventario.Text = ObjInventario.Cod_Inventario
            lblmsg.Text = ""
            Btn_Guardar.Visible = True
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Try
            If Drl_Programas.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione El Producto"
                Exit Sub
            Else
                ObjInventario.Descripcion = Drl_Programas.SelectedValue
            End If
            If Drl_tipo_licencia.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Seleccione El Tipo De Licencia"
                Exit Sub
            Else
                ObjInventario.Todo = Drl_tipo_licencia.SelectedValue
            End If
            If Txt_fecha_instalacion.Text = "" Then
                lblmsg.Text = "Seleccione La Fecha de Instalacion"
                Exit Sub
            Else
                ObjInventario.Dispositivoconsulta = Txt_fecha_instalacion.Text
            End If
            If Drl_tipo_licencia.SelectedValue = "Licencia Masiva" Then
                If Txt_obs_reg.Text = "" Then
                    lblmsg.Text = "Digite una Observacion"
                    Exit Sub
                End If
            End If
            ObjInventario.Id_Usuario = lblusuario.Text()
            ObjInventario.Letra = Lbl_serial.Text
            ObjInventario.Validacion = "validar_producto"
            ObjInventario.Consulta_Licencias()
            If ObjInventario.Validacion > "1" Then
                lblmsg.Text = "El Producto " & ObjInventario.Descripcion & " Con el tipo de " & ObjInventario.Todo & " Ya Se Encuentra Instalado"
                Exit Sub
            End If
            ObjInventario.Observacion = Txt_obs_reg.Text
            ObjInventario.Marca = txt_Version.Text
            ObjInventario.Serial = Txt_codigo_licencia.Text
            ObjInventario.Cod_Inventario = Lbl_Codigo_inventario.Text
            ObjInventario.Registro_Inventario_Software()
            lblmsg.Text = "Registro Exitoso"
            limpiar()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_Buscar1_Click(sender As Object, e As EventArgs) Handles Btn_Buscar1.Click
        Try
            If RdbtnTipo_Licencia.Checked = False And RdbtnProgramas2.Checked = False And RdbtnSerial2.Checked = False And RdbtnModulo2.Checked = False Then
                lblmsg.Text = "Seleccione una Opcion"
                Exit Sub
            End If
            ObjInventario.Validacion = "Filtros"
            If RdbtnTipo_Licencia.Checked = True Then
                If Drl_tipo_licencia2.SelectedValue = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione Un Tipo De Licencia"
                    Exit Sub
                End If
                ObjInventario.Todo = Drl_tipo_licencia2.SelectedValue
            End If
            If RdbtnModulo2.Checked = True Then
                If Drl_modulo_2.SelectedValue = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione Un Modulo"
                    Exit Sub
                End If
                ObjInventario.ID_Modulo = Drl_modulo_2.SelectedValue
            End If
            If RdbtnSerial2.Checked = True Then
                If Txt_serial_Kamilion2.Text = "" Then
                    lblmsg.Text = "Digite Un Serial"
                    Exit Sub
                End If
                ObjInventario.Serial_Kamilion = Txt_serial_Kamilion2.Text
            End If
            If RdbtnProgramas2.Checked = True Then
                If Drl_Programas2.SelectedValue = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione Un Producto"
                    Exit Sub
                End If
                ObjInventario.Empresa = Drl_Programas2.SelectedValue
            End If
            Session("dtsB") = ObjInventario.Consulta_Licencias()
            dtggeneral.DataSource = Session("dtsB")
            dtggeneral.DataBind()
            dtggeneral2.DataSource = Session("dtsB")
            dtggeneral2.DataBind()
            dtggeneral.Visible = True
            lblcuenta.Text = ObjInventario.Cod_Inventario
            lblmsg.Text = ""
            Lbl_Consulta_grid.Text = "2"
            If ObjInventario.Validacion = "1" Then
                lblmsg.Text = "No Se encontraron Registros"
                dtggeneral.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_buscar_todos_Click(sender As Object, e As EventArgs) Handles Btn_buscar_todos.Click
        Try
            dtggeneral.Visible = True
            ObjInventario.Validacion = "Buscar_Todos"
            Session("dtsB") = ObjInventario.Consulta_Licencias()
            dtggeneral.DataSource = Session("dtsB")
            dtggeneral.DataBind()
            dtggeneral2.DataSource = Session("dtsB")
            dtggeneral2.DataBind()
            lblcuenta.Text = ObjInventario.Cod_Inventario
            lblmsg.Text = ""
            Lbl_Consulta_grid.Text = "1"
            If ObjInventario.Validacion = "1" Then
                lblmsg.Text = "No Se encontraron Registros"
                dtggeneral.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub dtgConsultas_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex
            dtggeneral.DataSource = Session("dtsB")
            dtggeneral.DataBind()
            dtggeneral2.DataSource = Session("dtsB")
            dtggeneral2.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btn_guardar_programa_Click(sender As Object, e As EventArgs) Handles btn_guardar_programa.Click
        Try
            Txt_nuevo_programa.Text = LTrim(Txt_nuevo_programa.Text)
            Txt_nuevo_programa.Text = RTrim(Txt_nuevo_programa.Text)
            If Txt_nuevo_programa.Text = "" Then
                lblmsg.Text = "Digite El Software a Registrar"
                Exit Sub
            End If
            ObjInventario.Empresa = Txt_nuevo_programa.Text
            ObjInventario.Validacion = "validar"
            ObjInventario.Consulta_Licencias()
            If ObjInventario.Validacion > "1" Then
                lblmsg.Text = "Ese Producto ya se encuentra Resgistrado"
                Exit Sub
            End If
            ObjInventario.Id_Usuario = lblusuario.Text
            ObjInventario.Validacion = "Registro_programa"
            ObjInventario.Registro_Inventario_Software()
            lblmsg.Text = "Registro De Software Exitoso"
            ObjInventario.Validacion = "Programas"
            With Drl_Programas
                .DataSource = ObjInventario.Consulta_Licencias()
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With Drl_Programas2
                .DataSource = ObjInventario.Consulta_Licencias()
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            Txt_nuevo_programa.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnVer2_Click(sender As Object, e As EventArgs) Handles BtnVer2.Click
        Try
            If dt Is Nothing And Path.GetExtension(FileArchivo.FileName).ToLower() <> ".xlsx" Then
                lblmsg.Text = "El formato no es correcto"
                Exit Sub
            End If
            If Path.GetExtension(FileArchivo.FileName).ToLower() <> ".xlsx" Then
                lblmsg.Text = "El formato no es correcto"
                Exit Sub
            End If
            lblmsg.Text = ""
            lblcantidad.Text = ""
            FileArchivo.SaveAs(Server.MapPath("~/Documento/" & Path.GetFileName(FileArchivo.FileName)))
            Session("Ruta") = Server.MapPath("~/Documento/" & Path.GetFileName(FileArchivo.FileName))
            ObjInventario.Fc_ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("~/Documento/" & Path.GetFileName(FileArchivo.FileName)) & ";Extended Properties=Excel 12.0;"
            ObjInventario.Id_Usuario = lblusuario.Text
            ObjInventario.Validacion = 1
            dt = ObjInventario.Malla()
            Session("dtsB") = dt
            DtgVisualizar.DataSource = Session("dtsB")
            DtgVisualizar.DataBind()
            LblCantidad2.Text = ObjInventario.Cantidad
            Session("valor") = 1
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        Try
            lblmsg.Text = ""
            lblcantidad.Text = ""
            If Session("valor") = 1 Then
                dt = Session("dtsB")
            End If
            If dt Is Nothing And Path.GetExtension(FileArchivo.FileName).ToLower() <> ".xlsx" Then
                lblmsg.Text = "El formato no es correcto"
                Exit Sub
            End If
            lblmsg.Text = ""
            If dt Is Nothing Then
                FileArchivo.SaveAs(Server.MapPath("~/Documento/" & Path.GetFileName(FileArchivo.FileName)))
                Session("Ruta") = Server.MapPath("~/Documento/" & Path.GetFileName(FileArchivo.FileName))
                ObjInventario.Fc_ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("~/Documento/" & Path.GetFileName(FileArchivo.FileName)) & ";Extended Properties=Excel 12.0;"
                ObjInventario.Id_Usuario = lblusuario.Text
                ObjInventario.Validacion = 2
                ObjInventario.Malla()
                lblcantidad.Text = ObjInventario.Cantidad
            Else
                ObjInventario.Fc_Dtecxel = dt
                ObjInventario.Malla()
                lblcantidad.Text = ObjInventario.Cantidad
                LblCantidad2.Text = ""
            End If
            dt = Nothing
            Session("dtsB") = dt
            lblmsg.Text = "Registro de Inventario De Software masivo realizado con exito "
            DtgVisualizar.DataSource = Nothing
            DtgVisualizar.DataBind()
            File.Delete(Session("Ruta"))
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        Try
            crearexcel()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
            lblmsg.ForeColor = Drawing.Color.Red
        End Try
    End Sub

    Sub crearexcel()
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
            If dtggeneral2.Visible = False  Then
                dtggeneral2.Visible = True
            End If
            form.Controls.Add(dtggeneral2)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=Inventario_Software.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    'Protected Sub btn_Consultar_Click(sender As Object, e As EventArgs) Handles btn_Consultar.Click
    '    Try
    '        If Txt_numero_registro.Text = "" Then
    '            Btn_cancelar_Click(1, Nothing)
    '            lblmsg.Text = "Digite el numero del registro a Actualizar "
    '            Exit Sub
    '        End If
    '        ObjInventario.Cod_Inventario = Txt_numero_registro.Text
    '        ObjInventario.Consulta_Registro_Inventario_Software()
    '        Drl_producto_actualizar.SelectedValue = ObjInventario.Nombre_Activo
    '        Txt_version_actualizar.Text = ObjInventario._cargo
    '        Drl_tipo_licencia_actualizar.SelectedValue = ObjInventario.Tipo_Dispositivo
    '        Txt_Serial_actualizar.Text = ObjInventario.Serial_Kamilion
    '        txt_fecha_actualizar.Text = ObjInventario.Fc_ruta
    '        Txt_Observacion_Actualizar.Text = ObjInventario.Observacion
    '        btn_Editar.Visible = True
    '        btn_Actualizar.Visible = False
    '    Catch ex As Exception
    '        lblmsg.Text = "Se produjo error " + ex.Message
    '    End Try
    'End Sub


    Sub limpiar2()
        lblmsg.Text = ""
        lblmsg1.Text = ""
        Txt_numero_registro.Text = ""
        Drl_producto_actualizar.SelectedValue = "- Seleccione -"
        Txt_version_actualizar.Text = ""
        Txt_Serial_actualizar.Text = ""
        Drl_tipo_licencia_actualizar.SelectedValue = "- Seleccione -"
        txt_fecha_actualizar.Text = ""
        Txt_Observacion_Actualizar.Text = ""
    End Sub

    Protected Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Try
            If Txt_numero_registro.Text = "" Then
                lblmsg1.Text = "Seleccione Un Registro por favor"
                Exit Sub
            End If

            If Drl_producto_actualizar.Text = "- Seleccione -" Then
                lblmsg1.Text = "Seleccione El Producto"
                Exit Sub
            Else
                ObjInventario.Descripcion = Drl_producto_actualizar.SelectedValue
            End If
            If Drl_tipo_licencia_actualizar.SelectedValue = "- Seleccione -" Then
                lblmsg1.Text = "Seleccione El Tipo De Licencia"
                Exit Sub
            Else
                ObjInventario.Todo = Drl_tipo_licencia_actualizar.SelectedValue
            End If
            If txt_fecha_actualizar.Text = "" Then
                lblmsg1.Text = "Seleccione La Fecha de Instalacion"
                Exit Sub
            Else
                ObjInventario.Dispositivoconsulta = txt_fecha_actualizar.Text
            End If
            If Drl_tipo_licencia_actualizar.SelectedValue = "Licencia Masiva" Then
                If Txt_Observacion_Actualizar.Text = "" Then
                    lblmsg1.Text = "Digite una Observacion"
                    Exit Sub
                End If
            End If
            ObjInventario.Letra = Txt_numero_registro.Text

            'ObjInventario.Validacion = "validar_producto"
            'ObjInventario.Consulta_Licencias()
            'If ObjInventario.Validacion > "1" Then
            '    lblmsg.Text = "El Producto " & ObjInventario.Descripcion & " Con el tipo de " & ObjInventario.Todo & " Ya Se Encuentra Instalado"
            '    Exit Sub
            'End If

            ObjInventario.Observacion = Txt_Observacion_Actualizar.Text
            ObjInventario.Marca = Txt_version_actualizar.Text
            ObjInventario.Serial = Txt_Serial_actualizar.Text
            ObjInventario.Cod_Inventario = Txt_numero_registro.Text
            ObjInventario.Validacion = "Actualizacion_Inventario_Software"
            ObjInventario.Registro_Inventario_Software()
            limpiar2()
            Btn_buscar_todos_Click(1, Nothing)
            lblmsg1.Text = "Actualizacion Exitosa "
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub dtgConsultas_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtggeneral.RowCommand
        Try
            If e.CommandName = "Desinstalar" Then
                ObjInventario.Id_Usuario = lblusuario.Text()
                dtggeneral.Visible = True
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                ObjInventario.Cod_Inventario = dtggeneral.Rows(index).Cells(0).Text
                ObjInventario.Validacion = "Desinstalar"
                ObjInventario.Registro_Inventario_Software()
                lblmsg.Text = "Desinstalacion Exitosa"
                If Lbl_Consulta_grid.Text = "1" Then
                    Btn_buscar_todos_Click(1, Nothing)
                Else
                    Btn_Buscar1_Click(1, Nothing)
                End If
            End If
            If e.CommandName = "Editar" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                Txt_numero_registro.Text = dtggeneral.Rows(index).Cells(0).Text
                Drl_producto_actualizar.SelectedValue = HttpUtility.HtmlDecode(dtggeneral.Rows(index).Cells(3).Text)
                Txt_version_actualizar.Text = HttpUtility.HtmlDecode(dtggeneral.Rows(index).Cells(4).Text)
                Drl_tipo_licencia_actualizar.SelectedValue = dtggeneral.Rows(index).Cells(5).Text
                Txt_Serial_actualizar.Text = HttpUtility.HtmlDecode(dtggeneral.Rows(index).Cells(6).Text)
                txt_fecha_actualizar.Text = dtggeneral.Rows(index).Cells(7).Text
                Txt_Observacion_Actualizar.Text = HttpUtility.HtmlDecode(dtggeneral.Rows(index).Cells(8).Text)
                lblmsg1.Text = ""
            End If

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

  
End Class