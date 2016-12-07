Public Class InventarioCambios
    Inherits System.Web.UI.Page
    Dim ObjInventario As New clsInventario
    Dim objsecurity As New clsgeneral
    Dim Liberacion As Boolean = False
    Dim Asiganacion As Boolean = False
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Cargar_Drl()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Public Sub Cargar_Drl()
        ''Libreacion
        With drlEstadoLib
            .DataSource = ObjInventario.Consulta_Estado_Libera
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Nombre_Dispositivo"
            .DataBind()
        End With
        With DDrlDispositivoC
            .DataSource = ObjInventario.Consulta_Moduloslib
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Cod_Invent_Dispositivo"
            .DataBind()
            .Items(0).Value = ""
        End With
        With drlDispositivoLib
            .DataSource = ObjInventario.Consulta_Moduloslib
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Cod_Invent_Dispositivo"
            .DataBind()
        End With
        ''Asignacion
        With drlDispositivoIng
            .DataSource = ObjInventario.Consulta_Moduloslib
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Cod_Invent_Dispositivo"
            .DataBind()
        End With
        With drlModuloIng
            .DataSource = ObjInventario.Consulta_Modul
            .DataTextField = "ID_Modulo"
            .DataValueField = "ID_Modulo"
            .DataBind()
        End With
        ''Cambio de estado
        With drlCambioEstado
            .DataSource = ObjInventario.Consulta_Estado_Libera
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Nombre_Dispositivo"
            .DataBind()
        End With
        With drlDispositivoEstado
            .DataSource = ObjInventario.Consulta_Moduloslib
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Cod_Invent_Dispositivo"
            .DataBind()
        End With
        ''Consultas
        With drlCambioEstadoConsulta
            .DataSource = ObjInventario.Consulta_Estado_Libera
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Nombre_Dispositivo"
            .DataBind()
            .Items(0).Value = ""
        End With
        With drlModuloConsultas
            .DataSource = ObjInventario.Consulta_Modul
            .DataTextField = "ID_Modulo"
            .DataValueField = "ID_Modulo"
            .DataBind()
            .Items(0).Value = ""
        End With
    End Sub
    Public Sub Cargardrl_Lib()
        If Liberacion = True Then
            With drlDispositivoLib
                .DataSource = ObjInventario.Consulta_Moduloslib
                .DataTextField = "Nombre_Dispositivo"
                .DataValueField = "Cod_Invent_Dispositivo"
                .DataBind()
            End With
            Liberacion = False
        End If
        If Liberacion = True Then
            With drlModuloLib
                .DataSource = ObjInventario.Consulta_Moduloslib
                .DataTextField = "ID_Modulo"
                .DataValueField = "ID_Modulo"
                .DataBind()
            End With
            Liberacion = False
        End If
        If Asiganacion = True Then
            With drlDispositivoIng
                .DataSource = ObjInventario.Consulta_Moduloslib
                .DataTextField = "Nombre_Dispositivo"
                .DataValueField = "Cod_Invent_Dispositivo"
                .DataBind()
            End With
            With drlModuloIng
                .DataSource = ObjInventario.Consulta_Modul
                .DataTextField = "ID_Modulo"
                .DataValueField = "ID_Modulo"
                .DataBind()
            End With
        End If
        With drlEstadoLib
            .DataSource = ObjInventario.Consulta_Estado_Libera
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Nombre_Dispositivo"
            .DataBind()
        End With
    End Sub
    Public Sub Cargardrl_Cambio()
        With drlCambioEstado
            .DataSource = ObjInventario.Consulta_Estado_Libera
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Nombre_Dispositivo"
            .DataBind()
        End With
        With drlDispositivoEstado
            .DataSource = ObjInventario.Consulta_Moduloslib
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Cod_Invent_Dispositivo"
            .DataBind()
        End With
    End Sub
    Protected Sub Btn_Asignar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Asignar.Click
        Try
            If drlDispositivoIng.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Dispositivo"
                Exit Sub
            End If
            If drlModuloIng.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un modulo al cual Asiganara un dispositivo"
                Exit Sub
            End If
            ObjInventario.ID_Modulo = drlModuloIng.Text
            ObjInventario.Validacion_Modulo()
            If ObjInventario.ID_Modulo <> "RAC" Then
                ObjInventario.ID_Modulo = drlModuloIng.Text
                ObjInventario.Nombre_Dispositivo = drlDispositivoIng.SelectedItem.Text
                If ObjInventario.Validacion_Modulo_Un_Registro_Asigancion.Tables(0).Rows.Count >= 1 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> ya exite un Dispositivo(" + drlDispositivoIng.SelectedItem.Text + ") registrada en el modulo " + drlModuloIng.Text
                    Exit Sub
                End If
            End If
            If drlMarca.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una Marca"
                Exit Sub
            End If
            If drlModelo.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Modelo"
                Exit Sub
            End If
            If drlEmpresa.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione Una Empresa"
            End If
            If drlSerialKamilion.Enabled = True Then
                If drlSerialKamilion.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Selecione un serial Kamilion"
                End If
            End If
            If drlSerial.Enabled = True Then
                If drlSerial.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Serial"
                    Exit Sub
                End If
            End If
            If TxtObservacionIng.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingerse una observacion respecto a la liberacion"
                Exit Sub
            End If

            If drlSerialKamilion.Enabled = False Then
                ObjInventario.Serial = drlSerial.SelectedItem.Text
            ElseIf drlSerial.Enabled = False Then
                ObjInventario.Serial_Kamilion = drlSerialKamilion.SelectedItem.Text
            End If
            ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoIng.Text
            Dim Dts_Inventario = ObjInventario.Consultar_Inventario()
            If Dts_Inventario.Tables(0).Rows.Count <= 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No se pudo obtener el código de inventario del dispositivo que intenta asignar"
                Exit Sub
            End If
            ObjInventario.ID_Modulo = drlModuloIng.Text
            ObjInventario.Cod_Inventario = Dts_Inventario.Tables(0).Rows(0)("Cod_Inventario")
            ObjInventario.Estado = "Activo"



            ObjInventario.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            ObjInventario.Observacion = TxtObservacionIng.Text


            If Not ObjInventario.Asignar_Dispositivo() Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por algún motivo no se ha podido realizar la asignación del dispositivo"
                Exit Sub
            End If

            If Not ObjInventario.Registrar_Gestion_Dispositivo() Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por algún motivo no se ha podido realizar el registro de la asignación del dispositivo"
                Exit Sub
            End If




            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Dispositivo Asiganado"
            TxtObservacionIng.Text = ""
            drlMarca.Items.Clear()
            drlModelo.Items.Clear()
            drlEmpresa.Items.Clear()
            drlSerialKamilion.Items.Clear()
            drlSerial.Items.Clear()
            Asiganacion = True
            Cargardrl_Lib()

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Liberar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Liberar.Click
        Try
            If drlModuloLib.SelectedItem.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un modulo del cual liberar un dispositivo"
                Exit Sub
            End If
            If drlEstadoLib.SelectedItem.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un estado para el dispositivo"
                Exit Sub
            End If
            If drlDispositivoLib.SelectedItem.Text = Nothing Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione el dispositivo que desea liberar"
                Exit Sub
            End If
            If drlEmpresaLib.SelectedItem.Text = Nothing Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione la Empresa para liberar"
                Exit Sub
            End If
            If drlSerialKamilionLib.Enabled = True Then
                If drlSerialKamilionLib.SelectedItem.Text = Nothing Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Serial Kamilion para liberar"
                    Exit Sub
                End If
            End If
            If drlSerialLib.Enabled = True Then
                If drlSerialLib.SelectedItem.Text = Nothing Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Serial para liberar"
                    Exit Sub
                End If
            End If
            If TxtObservacionLib.Text = Nothing Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingerse una observacion respecto a la liberacion"
                Exit Sub
            End If
            If TxtObservacionLib.Text = Nothing Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingerse una observacion respecto a la liberacion"
                Exit Sub
            End If

            If drlSerialKamilionLib.Enabled = False Then
                ObjInventario.Serial = drlSerialLib.SelectedItem.Text
            ElseIf drlSerialLib.Enabled = False Then
                ObjInventario.Serial_Kamilion = drlSerialKamilionLib.SelectedItem.Text
            End If

            ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoLib.SelectedValue
            Dim Dts_Inventario = ObjInventario.Consultar_Inventario()
            If Dts_Inventario.Tables(0).Rows.Count <= 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No se pudo obtener el código de inventario del dispositivo que intenta liberar"
                Exit Sub
            End If

            ObjInventario.Cod_Inventario = Dts_Inventario.Tables(0).Rows(0)("Cod_Inventario")
            ObjInventario.ID_Modulo = "BODEGA"
            ObjInventario.Estado = drlEstadoLib.SelectedItem.Text
            ObjInventario.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            ObjInventario.Observacion = TxtObservacionLib.Text

            If Not ObjInventario.Asignar_Dispositivo() Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por algún motivo no se ha podido realizar la liberación del dispositivo"
                Exit Sub
            End If

            If Not ObjInventario.Registrar_Gestion_Dispositivo() Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por algún motivo no se ha podido realizar el registro de la asignación del dispositivo"
                Exit Sub
            End If


            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Dispositivo liberado"

            drlEmpresaLib.Items.Clear()
            drlModuloLib.Items.Clear()
            drlSerialKamilionLib.Items.Clear()
            drlSerialLib.Items.Clear()
            drlSerialKamilionLib.Enabled = True
            drlSerialLib.Enabled = True
            TxtObservacionLib.Text = ""
            Liberacion = True
            Cargardrl_Lib()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Cambiar_Estado_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Cambiar_Estado.Click
        Try
            If drlDispositivoEstado.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Dispositivo del cual cambiara el estado"
                Exit Sub
            End If
            If drlCambioEstado.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Estado para el dispositivo"
                Exit Sub
            End If
            If drlModuloEstado.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un modulo del cual cambiara el estado del dispositivo"
                Exit Sub
            End If
            If drlMarcaEstado.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una Marca del cual cambiara el estado"
                Exit Sub
            End If
            If drlModeloEstado.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Modelo del cual cambiara el estado"
                Exit Sub
            End If
            If drlSerialKamilionEstado.Enabled = True Then
                If drlSerialKamilionEstado.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Serial Kamilion del cual cambiara el estado"
                    Exit Sub
                End If
            End If
            If drlSerialEstado.Enabled = True Then
                If drlSerialEstado.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Serial del cual cambiara el estado"
                    Exit Sub
                End If
            End If
            If TxtObservacionEstado.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingerse una observacion respecto al cambio de estado"
                Exit Sub
            End If
            If drlSerialKamilionEstado.Enabled = True And drlSerialKamilionEstado.SelectedIndex <> 0 Then
                ObjInventario.Serial_Kamilion = drlSerialKamilionEstado.SelectedItem.Text
            End If
            If drlSerialEstado.Enabled = True And drlSerialEstado.SelectedIndex <> 0 Then
                ObjInventario.Serial = drlSerialEstado.SelectedItem.Text
            End If

            ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoEstado.Text
            Dim Dts_Inventario = ObjInventario.Consultar_Inventario()
            If Dts_Inventario.Tables(0).Rows.Count <= 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No se pudo obtener el código de inventario del dispositivo que intenta liberar"
                Exit Sub
            End If



            ObjInventario.Cod_Inventario = Dts_Inventario.Tables(0).Rows(0)("Cod_Inventario")
            ObjInventario.Estado = drlCambioEstado.SelectedItem.Text
            ObjInventario.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            ObjInventario.Observacion = TxtObservacionEstado.Text
            ObjInventario.ID_Modulo = drlModuloEstado.SelectedItem.Text


            If Not ObjInventario.Cambiar_Estado() Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por algún motivo no se ha podido realizar la liberación del dispositivo"
                Exit Sub
            End If

            If Not ObjInventario.Registrar_Gestion_Dispositivo() Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por algún motivo no se ha podido realizar el registro de la asignación del dispositivo"
                Exit Sub
            End If




            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span>Estado del Dispositivo Modificado"
            drlModuloEstado.Items.Clear()

            drlMarcaEstado.Items.Clear()
            drlModeloEstado.Items.Clear()
            drlEmpresaEstado.Items.Clear()
            drlSerialKamilionEstado.Items.Clear()
            drlSerialEstado.Items.Clear()
            TxtObservacionEstado.Text = ""
            Cargardrl_Cambio()

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Consultar_Inventario_Click(sender As Object, e As EventArgs) Handles Btn_Consultar_Inventario.Click
        Try
            If drlModuloConsultas.SelectedIndex = 0 And TxtCodigoInventario.Text = Nothing And drlCambioEstadoConsulta.SelectedIndex = 0 And DDrlDispositivoC.SelectedIndex = 0 And Txt_ConsSerial.Text = Nothing And Txt_ConsSerialKami.Text = Nothing Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un filtro de consulta"
                Pnl_1.Visible = False
                Pnl_2.Visible = False
                Exit Sub
            End If

            '''''Serial
            If Txt_ConsSerial.Text = Nothing Then
                Pnl_1.Visible = False
                Pnl_2.Visible = False
            Else
                ObjInventario.Serial = Txt_ConsSerial.Text
                Session("Consulta") = ObjInventario.Consulta_Inventario_Filtros()
                Pnl_1.Visible = True
                dtggeneral1.DataSource = Session("Consulta")
                dtggeneral1.DataBind()
                lblcantidad.Text = Session("Consulta").Tables(0).rows.count
                If lblcantidad.Text = 0 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros"
                    Pnl_1.Visible = False
                Else
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Busqueda Exitosa"
                End If
                Pnl_2.Visible = False
                dtggeneral2.DataSource = Nothing
                dtggeneral2.DataBind()
                LblCantidad2.Text = ""
                Exit Sub
            End If

            '''''SerialKamilion
            If Txt_ConsSerialKami.Text = Nothing Then
                Pnl_1.Visible = False
                Pnl_2.Visible = False
            Else
                ObjInventario.Serial_Kamilion = Txt_ConsSerialKami.Text
                Session("consulta") = ObjInventario.Consulta_Inventario_Filtros
                Pnl_1.Visible = True
                dtggeneral1.DataSource = Session("consulta")
                dtggeneral1.DataBind()
                lblcantidad.Text = Session("Consulta").Tables(0).rows.count
                If lblcantidad.Text = 0 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros"
                    Pnl_1.Visible = False
                Else
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Busqueda Exitosa"
                End If
                Pnl_2.Visible = False
                dtggeneral2.DataSource = Nothing
                dtggeneral2.DataBind()
                LblCantidad2.Text = ""
                Exit Sub
            End If


            '''''''''Dispositivo
            If DDrlDispositivoC.SelectedIndex <> 0 Then
                If DDrlDispositivoC.SelectedIndex <> 0 And drlModuloConsultas.SelectedIndex = 0 And TxtCodigoInventario.Text = Nothing And drlCambioEstadoConsulta.SelectedIndex = 0 Then
                    If Txt_ConsSerial.Text <> Nothing Or Txt_ConsSerialKami.Text <> Nothing Then
                        Pnl_Message.CssClass = "alert alert-info"
                        lblmsg.Text = "<span Class='glyphicon glyphicon-info-sign'></span> dejar en 'seleccione' el dispositivo si desea buscar por un tipo de Serial."
                    End If
                    ObjInventario.Dispositivoconsulta = "Si"
                    ObjInventario.Cod_Invent_Dispositivo = DDrlDispositivoC.SelectedValue
                    Session("Consulta") = ObjInventario.Consulta_Inventario_Registros()
                    dtggeneral1.DataSource = Session("Consulta")
                    dtggeneral1.DataBind()
                    lblcantidad.Text = Session("Consulta").Tables(0).rows.count
                    If lblcantidad.Text = 0 Then
                        Pnl_Message.CssClass = "alert alert-info"
                        lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros"
                        Pnl_1.Visible = False
                    Else
                        Pnl_Message.CssClass = "alert alert-success"
                        lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Busqueda Exitosa"
                    End If
                    ''Limpio dgt 2
                    Pnl_2.Visible = False
                    dtggeneral2.DataSource = Nothing
                    dtggeneral2.DataBind()
                    LblCantidad2.Text = ""
                    Exit Sub
                Else
                    ObjInventario.Cod_Invent_Dispositivo = DDrlDispositivoC.SelectedValue
                    ObjInventario.Dispositivoconsulta = "Si"
                End If
            Else
                ObjInventario.Dispositivoconsulta = Nothing
                Pnl_1.Visible = False
                Pnl_2.Visible = False
                Pnl_1.Visible = True
            End If

            '''''''''Codio
            If TxtCodigoInventario.Text = Nothing Then
                Pnl_1.Visible = False
                Pnl_2.Visible = False
            ElseIf TxtCodigoInventario.Text <> Nothing Then
                ObjInventario.Cod_Inventario = TxtCodigoInventario.Text
                Session("Consulta") = ObjInventario.Consulta_Inventario_Registros()
                Pnl_1.Visible = True
                dtggeneral1.DataSource = Session("Consulta")
                dtggeneral1.DataBind()
                lblcantidad.Text = Session("Consulta").Tables(0).rows.count
                If lblcantidad.Text = 0 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros"
                    Pnl_1.Visible = False
                Else
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Busqueda Exitosa"
                End If
                ObjInventario.Cod_Inventario = TxtCodigoInventario.Text
                Pnl_2.Visible = True
                dtggeneral2.DataSource = ObjInventario.Consulta_Inventario_Registros_Detalle()
                dtggeneral2.DataBind()
                LblCantidad2.Text = ObjInventario.Cantidad
                Exit Sub
            End If

            '''''''''Modulo
            If drlModuloConsultas.SelectedIndex = 0 Then
                Pnl_1.Visible = False
                Pnl_2.Visible = False
            ElseIf drlModuloConsultas.SelectedIndex <> 0 Then
                ObjInventario.ID_Modulo = drlModuloConsultas.Text
                Session("Consulta") = ObjInventario.Consulta_Inventario_Registros()
                Pnl_1.Visible = True
                dtggeneral1.DataSource = Session("Consulta")
                dtggeneral1.DataBind()
                lblcantidad.Text = Session("Consulta").Tables(0).rows.count
                If lblcantidad.Text = 0 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros"
                    Pnl_1.Visible = False
                Else
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Busqueda Exitosa"
                End If
                ''Limpio dgt 2
                Pnl_2.Visible = False
                dtggeneral2.DataSource = Nothing
                dtggeneral2.DataBind()
                LblCantidad2.Text = ""
                Exit Sub
            End If

            '''''''''Estado
            If drlCambioEstadoConsulta.SelectedIndex = 0 Then
                Pnl_1.Visible = False
                Pnl_2.Visible = False
            ElseIf drlCambioEstadoConsulta.SelectedIndex <> 0 Then
                ObjInventario.Estado = drlCambioEstadoConsulta.Text
                Session("Consulta") = ObjInventario.Consulta_Inventario_Registros()
                Pnl_1.Visible = True
                dtggeneral1.DataSource = Session("Consulta")
                dtggeneral1.DataBind()
                lblcantidad.Text = Session("Consulta").Tables(0).rows.count
                If lblcantidad.Text = 0 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros"
                    Pnl_1.Visible = False
                Else
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Busqueda Exitosa"
                End If
                ''Limpio dgt 
                Pnl_2.Visible = False
                dtggeneral2.DataSource = Nothing
                dtggeneral2.DataBind()
                LblCantidad2.Text = ""
                Exit Sub
            Else
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub drlModuloLib_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlModuloLib.SelectedIndexChanged
        Try
            ObjInventario.Fk_ID_Modulo = drlModuloLib.Text
            ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoLib.Text
            With drlEmpresaLib
                .DataSource = ObjInventario.Consulta_Liberar()
                .DataTextField = "Empresa"
                .DataValueField = "Empresa"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub drlDispositivoIng_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlDispositivoIng.SelectedIndexChanged
        Try
            ObjInventario.Cod_Invent_Dispositivo = drlDispositivoIng.Text
            With drlMarca
                .DataSource = ObjInventario.Consulta_Filtro_Marca_Asignar_Dispositivos
                .DataTextField = "Marca"
                .DataValueField = "Marca"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub drlMarca_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlMarca.SelectedIndexChanged
        Try
            ObjInventario.Cod_Invent_Dispositivo = drlDispositivoIng.Text
            ObjInventario.Marca = drlMarca.Text
            With drlModelo
                .DataSource = ObjInventario.Consulta_Filtro_Modelo_Asignar_Dispositivos
                .DataTextField = "Modelo"
                .DataValueField = "Modelo"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub drlModelo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlModelo.SelectedIndexChanged
        Try
            ObjInventario.Modelo = drlModelo.Text
            With drlEmpresa
                .DataSource = ObjInventario.Consulta_Filtro_Serial_Asignar_Dispositivos
                .DataTextField = "Empresa"
                .DataValueField = "Empresa"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub drlModuloEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlModuloEstado.SelectedIndexChanged
        Try
            ObjInventario.Fk_ID_Modulo = drlModuloEstado.Text
            ObjInventario.Cod_Invent_Dispositivo = drlDispositivoEstado.Text
            With drlMarcaEstado
                .DataSource = ObjInventario.Consulta_Filtro_Marca_Estado_Dispositivos
                .DataTextField = "Marca"
                .DataValueField = "Marca"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub drlDispositivoEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlDispositivoEstado.SelectedIndexChanged
        Try
            ObjInventario.Cod_Invent_Dispositivo = drlDispositivoEstado.Text
            With drlModuloEstado

                .DataSource = ObjInventario.Consulta_Liberar_Dispositivos()
                .DataTextField = "FK_ID_Modulo"
                .DataValueField = "FK_ID_Modulo"

                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub drlMarcaEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlMarcaEstado.SelectedIndexChanged
        Try
            ObjInventario.Fk_ID_Modulo = drlModuloEstado.Text
            ObjInventario.Marca = drlMarcaEstado.Text
            ObjInventario.Cod_Invent_Dispositivo = drlDispositivoEstado.SelectedValue
            With drlModeloEstado
                .DataSource = ObjInventario.Consulta_Filtro_Modelo_Estado_Dispositivos
                .DataTextField = "Modelo"
                .DataValueField = "Modelo"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub drlModeloEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlModeloEstado.SelectedIndexChanged
        Try
            ObjInventario.Fk_ID_Modulo = drlModuloEstado.Text
            ObjInventario.Modelo = drlModeloEstado.Text
            ObjInventario.Validacion = 1
            ObjInventario.Cod_Invent_Dispositivo = drlDispositivoEstado.SelectedValue
            With drlEmpresaEstado
                .DataSource = ObjInventario.Consulta_Filtro_Serial_Estado_Dispositivos
                .DataTextField = "Empresa"
                .DataValueField = "Empresa"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub drlDispositivoLib_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlDispositivoLib.SelectedIndexChanged
        Try
            ObjInventario.Cod_Invent_Dispositivo = drlDispositivoLib.Text

            With drlModuloLib
                .DataSource = ObjInventario.Consulta_Liberar_Dispositivos()
                .DataTextField = "FK_ID_Modulo"
                .DataValueField = "FK_ID_Modulo"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub drlEmpresaLib_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlEmpresaLib.SelectedIndexChanged
        Try
            ObjInventario.Fk_ID_Modulo = drlModuloLib.Text
            ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoLib.Text
            ObjInventario.Empresa = drlEmpresaLib.Text
            If drlEmpresaLib.Text = "KAMILION" Then
                drlSerialLib.Items.Clear()
                drlSerialKamilionLib.Enabled = True
                With drlSerialKamilionLib
                    .Items.Clear()
                    .DataSource = ObjInventario.Consulta_Liberar2()
                    .DataTextField = "Serial_Kamilion"
                    .DataValueField = "Serial_Kamilion"
                    .DataBind()
                End With
                drlSerialLib.Enabled = False
            ElseIf drlEmpresaLib.Text = "- Seleccione -" Then
                drlSerialLib.Items.Clear()
                drlSerialKamilionLib.Items.Clear()
                drlSerialLib.Enabled = False
                drlSerialKamilionLib.Enabled = False
            Else
                drlSerialLib.Enabled = True
                drlSerialKamilionLib.Items.Clear()
                With drlSerialLib
                    .Items.Clear()
                    .DataSource = ObjInventario.Consulta_Liberar2()
                    .DataTextField = "Serial"
                    .DataValueField = "Serial"
                    .DataBind()
                End With
                drlSerialKamilionLib.Enabled = False
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub drlEmpresa_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlEmpresa.SelectedIndexChanged
        Try
            If drlEmpresa.Text = "KAMILION" Then
                drlSerial.Enabled = False
                drlSerialKamilion.Enabled = True
                ObjInventario.Modelo = drlModelo.Text
                ObjInventario.Empresa = drlEmpresa.Text
                With drlSerialKamilion
                    .DataSource = ObjInventario.Consulta_Filtro_Serial
                    .DataTextField = "Serial_Kamilion"
                    .DataValueField = "cod_inventario"
                    .DataBind()
                End With
            Else
                drlSerialKamilion.Enabled = False
                drlSerial.Enabled = True
                ObjInventario.Modelo = drlModelo.Text
                ObjInventario.Empresa = drlEmpresa.Text
                With drlSerial
                    .DataSource = ObjInventario.Consulta_Filtro_Serial
                    .DataTextField = "Serial"
                    .DataValueField = "cod_inventario"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub drlEmpresaEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlEmpresaEstado.SelectedIndexChanged
        Try
            If drlEmpresaEstado.Text = "KAMILION" Then
                drlSerialKamilionEstado.Enabled = True
                drlSerialEstado.Enabled = False

                ObjInventario.Fk_ID_Modulo = drlModuloEstado.Text
                ObjInventario.Modelo = drlModeloEstado.Text
                ObjInventario.Cod_Invent_Dispositivo = drlDispositivoEstado.SelectedValue
                With drlSerialKamilionEstado
                    .DataSource = ObjInventario.Consulta_Filtro_Serial_Estado_Dispositivos
                    .DataTextField = "Serial_Kamilion"
                    .DataValueField = "Serial_Kamilion"
                    .DataBind()
                End With
            Else
                drlSerialEstado.Enabled = True
                drlSerialKamilionEstado.Enabled = False
                ObjInventario.Fk_ID_Modulo = drlModuloEstado.Text
                ObjInventario.Modelo = drlModeloEstado.Text
                ObjInventario.Cod_Invent_Dispositivo = drlDispositivoEstado.SelectedValue

                With drlSerialEstado
                    .DataSource = ObjInventario.Consulta_Filtro_Serial_Estado_Dispositivos
                    .DataTextField = "Serial"
                    .DataValueField = "Serial"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub dtggeneral1_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtggeneral1.PageIndexChanging
        dtggeneral1.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
        dtggeneral1.DataSource = Session("Consulta")
        dtggeneral1.DataBind()
    End Sub
End Class