Public Class InventarioActivosCambio
    Inherits System.Web.UI.Page
    Dim ObjInventario As New clsInventario
    Dim Liberacion As Boolean = False
    Dim Asiganacion As Boolean = False

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre

                ''Libreacion
                Cargardrl_Lib()
                ''Asignacion
                Cargardrl_Asignacion()
                ''Cambio de estado
                Cargardrl_Estado()
                ''Consultas
                With drlCambioEstadoConsulta
                    .DataSource = ObjInventario.Consulta_Estado_LiberaActivo
                    .DataTextField = "Nombre_Dispositivo"
                    .DataValueField = "Nombre_Dispositivo"
                    .DataBind()
                End With
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

    Public Sub Cargardrl_Lib()
        With drlEstadoLib
            .DataSource = ObjInventario.Consulta_Estado_LiberaActivo
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Nombre_Dispositivo"
            .DataBind()
        End With
        With drlDispositivoLib
            .DataSource = ObjInventario.Consulta_Dispo_LiberaActivo
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Fk_Cod_Invent_Dispositivo"
            .DataBind()
        End With
        With drlAgenLib
            .DataSource = ObjInventario.Consulta_Agente_LiberaActivo
            .DataTextField = "nombreu"
            .DataValueField = "codnom"
            .DataBind()
        End With
    End Sub

    Public Sub Cargardrl_Asignacion()
        With drlDispositivoIng
            .DataSource = ObjInventario.Consulta_Asignar_DispositivosActivo
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Fk_Cod_Invent_Dispositivo"
            .DataBind()
        End With
        With drlAgenIng
            .DataSource = ObjInventario.Consulta_Agente_LiberaActivo
            .DataTextField = "nombreu"
            .DataValueField = "codnom"
            .DataBind()
        End With
    End Sub

    Public Sub Cargardrl_Estado()
        With drlDispositivoEstado
            .DataSource = ObjInventario.Consulta_Dispo_EstadoActivo
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Fk_Cod_Invent_Dispositivo"
            .DataBind()
        End With
        With drlCambioEstado
            .DataSource = ObjInventario.Consulta_Estado_LiberaActivo
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Nombre_Dispositivo"
            .DataBind()
        End With
    End Sub
    Protected Sub BtnLiberar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnLiberar.Click
        Try
            If drlDispositivoLib.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un dispositivo que desea liberar"
                Exit Sub
            End If
            If drlEstadoLib.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un estado para el dispositivo"
                Exit Sub
            End If
            If drlModuloLib.Enabled = False Then
                If drlAgenLib.Text = "" Then
                    lblmsg.Text = "Seleccione una sede o usuario del cual liberar el dispositivo"
                    Exit Sub
                End If
            End If
            If drlModuloLib.Enabled = True Then
                If drlModuloLib.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una sede o usuario del cual liberar el dispositivo"
                    Exit Sub
                End If
            End If
            If drlEmpresaLib.Text = "" Then
                lblmsg.Text = "Seleccione una empresa o usuario del cual liberar el dispositivo"
                Exit Sub
            End If
            If drlSerialLib.Enabled = False Then
                If drlSerial1Lib.Text = "" Then
                    lblmsg.Text = "Ingerse un serial para la liberacion"
                    Exit Sub
                End If
            End If
            If drlSerialLib.Enabled = True Then
                If drlSerialLib.Text = "" Then
                    lblmsg.Text = "Ingerse un serial para la liberacion"
                    Exit Sub
                End If
            End If
            If TxtObservacionLib.Text = "" Then
                lblmsg.Text = "Ingerse una observacion respecto a la liberacion"
                Exit Sub
            End If
            If drlSerialLib.Enabled = True Then
                ObjInventario.Serial_Kamilion = drlSerialLib.Text
                ObjInventario.Estado = drlEstadoLib.Text
                ObjInventario.Liberar_DispositivoActivo()
                If drlModuloLib.Enabled = False Then
                    ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoLib.Text
                    ObjInventario.Cod_Agente = drlAgenLib.Text
                    ObjInventario.Sede = " "
                    ObjInventario.Serial_Kamilion = drlSerialLib.Text
                    ObjInventario.Validacion_Codigo_Iventario_ActivosActivo()
                    LblCod_Inventario_Activos.Text = ObjInventario.Cod_Inventario
                    ObjInventario.Sede = " "
                    ObjInventario.Observacion = TxtObservacionLib.Text
                    ObjInventario.Fk_Cod_Inventario = LblCod_Inventario_Activos.Text
                    ObjInventario.Estado = drlEstadoLib.Text
                    ObjInventario.Id_Usuario = lblusuario.Text
                    ObjInventario.Cod_Agente = drlAgenLib.Text
                    ObjInventario.Registro_Liberacion_DispositivoActivo()
                End If
                If drlModuloLib.Enabled = True Then
                    ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoLib.Text
                    ObjInventario.Cod_Agente = " "
                    ObjInventario.Sede = drlModuloLib.Text
                    ObjInventario.Serial_Kamilion = drlSerialLib.Text
                    ObjInventario.Validacion_Codigo_Iventario_ActivosActivo()
                    LblCod_Inventario_Activos.Text = ObjInventario.Cod_Inventario
                    ObjInventario.Cod_Agente = " "
                    ObjInventario.Observacion = TxtObservacionLib.Text
                    ObjInventario.Fk_Cod_Inventario = LblCod_Inventario_Activos.Text
                    ObjInventario.Sede = drlModuloLib.Text
                    ObjInventario.Estado = drlEstadoLib.Text
                    ObjInventario.Id_Usuario = lblusuario.Text
                    ObjInventario.Registro_Liberacion_DispositivoActivo()
                End If
                drlSerialLib.SelectedItem.Text = ""
                drlSerial1Lib.Text = ""
            Else
                ObjInventario.Serial = drlSerial1Lib.Text
                ObjInventario.Estado = drlEstadoLib.Text
                ObjInventario.Liberar_Dispositivo1Activo()
                If drlModuloLib.Enabled = False Then
                    ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoLib.Text
                    ObjInventario.Cod_Agente = drlAgenLib.Text
                    ObjInventario.Sede = " "
                    ObjInventario.Serial = drlSerial1Lib.Text
                    ObjInventario.Validacion_Codigo_Iventario_Activos1Activo()
                    LblCod_Inventario_Activos.Text = ObjInventario.Cod_Inventario
                    ObjInventario.Sede = " "
                    ObjInventario.Observacion = TxtObservacionLib.Text
                    ObjInventario.Fk_Cod_Inventario = LblCod_Inventario_Activos.Text
                    ObjInventario.Estado = drlEstadoLib.Text
                    ObjInventario.Id_Usuario = lblusuario.Text
                    ObjInventario.Cod_Agente = drlAgenLib.Text
                    ObjInventario.Registro_Liberacion_DispositivoActivo()
                End If
                If drlModuloLib.Enabled = True Then
                    ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoLib.Text
                    ObjInventario.Cod_Agente = " "
                    ObjInventario.Sede = drlModuloLib.Text
                    ObjInventario.Serial = drlSerial1Lib.Text
                    ObjInventario.Validacion_Codigo_Iventario_Activos1Activo()
                    LblCod_Inventario_Activos.Text = ObjInventario.Cod_Inventario
                    ObjInventario.Cod_Agente = " "
                    ObjInventario.Observacion = TxtObservacionLib.Text
                    ObjInventario.Fk_Cod_Inventario = LblCod_Inventario_Activos.Text
                    ObjInventario.Sede = drlModuloLib.Text
                    ObjInventario.Estado = drlEstadoLib.Text
                    ObjInventario.Id_Usuario = lblusuario.Text
                    ObjInventario.Registro_Liberacion_DispositivoActivo()
                End If
                drlSerialLib.SelectedItem.Text = ""
                drlSerial1Lib.Text = ""
            End If
            lblmsg.Text = ""
            lblmsg.Text = "Dispositivo liberado"
            drlModuloLib.SelectedItem.Text = "- Seleccione -"

            TxtObservacionLib.Text = ""
            drlEmpresaLib.Text = ""

            Liberacion = True
            ''Libreacion
            Cargardrl_Lib()
            ''Asignacion
            Cargardrl_Asignacion()
            ''Cambio de estado
            Cargardrl_Estado()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnEstado_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnEstado.Click
        Try
            If drlDispositivoEstado.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un Dispositivo del cual cambiara el estado"
                Exit Sub
            End If
            If drlMarcaEstado.Text = "" Then
                lblmsg.Text = "Seleccione una Marca del cual cambiara el estado"
                Exit Sub
            End If
            If drlModeloEstado.Text = "" Then
                lblmsg.Text = "Seleccione un Modelo del cual cambiara el estado"
                Exit Sub
            End If
            If drlEmpresaEstado.Text = "" Then
                lblmsg.Text = "Seleccione una Empresa del cual cambiara el estado"
                Exit Sub
            End If
            If drlSerialEstado.Enabled = True Then
                If drlSerialEstado.Text = "" Then
                    lblmsg.Text = "Seleccione un Serial del cual cambiara el estado"
                    Exit Sub
                End If
            End If
            If drlSerial1Estado.Enabled = True Then
                If drlSerial1Estado.Text = "" Then
                    lblmsg.Text = "Seleccione un Serial del cual cambiara el estado"
                    Exit Sub
                End If
            End If
            If drlCambioEstado.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un Estado para el dispositivo"
                Exit Sub
            End If
            If TxtObservacionEstado.Text = "" Then
                lblmsg.Text = "Ingerse una observacion respecto al cambio de estado"
                Exit Sub
            End If
            If drlSerialEstado.Enabled = True Then
                ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoEstado.Text
                ObjInventario.Marca = drlMarcaEstado.Text
                ObjInventario.Modelo = drlModeloEstado.Text
                ObjInventario.Serial_Kamilion = drlSerialEstado.SelectedItem.Text
                ObjInventario.Estado = drlCambioEstado.Text
                ObjInventario.Cambio_Estado2Activo()
                ObjInventario.Validacion_Codigo_Iventario_Activos2Activo()
                LblCod_Inventario_Activos0.Text = ObjInventario.Cod_Inventario
                ObjInventario.Observacion = TxtObservacionEstado.Text
                ObjInventario.Fk_Cod_Inventario = LblCod_Inventario_Activos0.Text
                ObjInventario.Estado = drlCambioEstado.Text
                ObjInventario.Id_Usuario = lblusuario.Text
                ObjInventario.Sede = ""
                ObjInventario.Cod_Agente = ""
                ObjInventario.Registro_Liberacion_DispositivoActivo()
                drlSerialEstado.SelectedItem.Text = ""
            End If
            If drlSerial1Estado.Enabled = True Then
                ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoEstado.Text
                ObjInventario.Marca = drlMarcaEstado.Text
                ObjInventario.Modelo = drlModeloEstado.Text
                ObjInventario.Serial_Kamilion = ""
                ObjInventario.Serial = drlSerial1Estado.Text
                ObjInventario.Estado = drlCambioEstado.Text
                ObjInventario.Cambio_Estado2Activo()
                ObjInventario.Validacion_Codigo_Iventario_Activos3Activo()
                LblCod_Inventario_Activos0.Text = ObjInventario.Cod_Inventario
                ObjInventario.Observacion = TxtObservacionEstado.Text
                ObjInventario.Fk_Cod_Inventario = LblCod_Inventario_Activos0.Text
                ObjInventario.Estado = drlCambioEstado.Text
                ObjInventario.Id_Usuario = lblusuario.Text
                ObjInventario.Sede = ""
                ObjInventario.Cod_Agente = ""
                ObjInventario.Registro_Liberacion_DispositivoActivo()
                drlSerial1Estado.Text = ""
            End If
            lblmsg.Text = ""
            lblmsg.Text = "Estado del Dispositivo Modificado"
            drlEmpresaEstado.Text = ""
            drlMarcaEstado.SelectedItem.Text = ""
            drlModeloEstado.SelectedItem.Text = ""
            TxtObservacionEstado.Text = ""
            ''Libreacion
            Cargardrl_Lib()
            ''Asignacion
            Cargardrl_Asignacion()
            ''Cambio de estado
            Cargardrl_Estado()

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub drlDispositivoLib_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlDispositivoLib.SelectedIndexChanged

        Try
            ObjInventario.Nombre_Dispositivo = drlDispositivoLib.SelectedItem.Text
            With drlAgenLib
                .DataSource = ObjInventario.Consulta_Liberar_AgenteActivo
                .DataTextField = "Cod_Agente"
                .DataValueField = "Cod_Agente"
                .DataBind()
            End With
            With drlModuloLib
                .DataSource = ObjInventario.Consulta_Liberar_ModuloActivo
                .DataTextField = "Sede"
                .DataValueField = "Sede"
                .DataBind()
            End With
            If drlModuloLib.Text = Nothing Then
                drlAgenLib.Enabled = True
                drlModuloLib.Enabled = False
            Else
                If drlAgenLib.Text = Nothing Then
                    drlAgenLib.Enabled = False
                    drlModuloLib.Enabled = True
                End If
            End If
            ObjInventario.Nombre_Dispositivo = drlDispositivoLib.SelectedItem.Text
            With drlEmpresaLib
                .DataSource = ObjInventario.Consulta_Liberar_EmpresaActivo
                .DataTextField = "Empresa"
                .DataValueField = "Empresa"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Sepresento error: " + ex.Message
        End Try
    End Sub
    Protected Sub drlEmpresaLib_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlEmpresaLib.SelectedIndexChanged
        Try
            ObjInventario.Cod_Agente = drlAgenLib.SelectedItem.Text
            ObjInventario.Sede = drlModuloLib.Text
            ObjInventario.Empresa = drlEmpresaLib.Text
            ObjInventario.Nombre_Dispositivo = drlDispositivoLib.SelectedItem.Text
            With drlSerialLib
                .DataSource = ObjInventario.Consulta_Liberar_DispositivosActivo
                .DataTextField = "Serial_Kamilion"
                .DataValueField = "Serial_Kamilion"
                .DataBind()
            End With
            ObjInventario.Sede = drlModuloLib.Text
            ObjInventario.Cod_Agente = drlAgenLib.SelectedItem.Text
            ObjInventario.Empresa = drlEmpresaLib.Text
            ObjInventario.Nombre_Dispositivo = drlDispositivoLib.SelectedItem.Text
            With drlSerial1Lib
                .DataSource = ObjInventario.Consulta_Liberar_Dispositivos1Activo
                .DataTextField = "Serial"
                .DataValueField = "Serial"
                .DataBind()
            End With
            If drlSerialLib.Text > Nothing And drlSerial1Lib.Text > Nothing Then
                drlSerial1Lib.Enabled = True
                drlSerialLib.Enabled = True
            Else
                If drlSerial1Lib.Text > Nothing Then
                    drlSerial1Lib.Enabled = True
                    drlSerialLib.Enabled = False
                Else
                    If drlSerial1Lib.Text > Nothing Then
                        drlSerial1Lib.Enabled = False
                        drlSerialLib.Enabled = True
                    End If
                    End If
            End If
        Catch ex As Exception
                lblmsg.Text = "Sepresento error: " + ex.Message
            End Try
    End Sub
    Protected Sub drlDispositivoIng_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlDispositivoIng.SelectedIndexChanged
        Try
            ObjInventario.Nombre_Dispositivo = drlDispositivoIng.SelectedItem.Text
            With drlMarca
                .DataSource = ObjInventario.Consulta_Filtro_Marca_Asignar_DispositivosActivo
                .DataTextField = "Marca"
                .DataValueField = "Marca"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
        Try
            If drlDispositivoIng.SelectedItem.Text = "Diademas" Or drlDispositivoIng.SelectedItem.Text = "Locker x16 Cajones" Or drlDispositivoIng.SelectedItem.Text = "Locker x6 Cajones" Then
                drlModuloIng.Enabled = False
                drlAgenIng.Enabled = True
            Else
                drlModuloIng.Enabled = True
                drlAgenIng.Enabled = False
            End If

        Catch ex As Exception

        End Try
    End Sub
    Protected Sub drlMarca_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlMarca.SelectedIndexChanged
        Try
            ObjInventario.Marca = drlMarca.Text
            With drlModelo
                .DataSource = ObjInventario.Consulta_Filtro_Modelo_Asignar_DispositivosActivo
                .DataTextField = "Modelo"
                .DataValueField = "Modelo"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drlModelo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlModelo.SelectedIndexChanged
        Try
            ObjInventario.Modelo = drlModelo.Text
            With drlEmpresa
                .DataSource = ObjInventario.Consulta_Filtro_Serial_Asignar_DispositivosActivo
                .DataTextField = "Empresa"
                .DataValueField = "Empresa"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub drlEmpresa_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlEmpresa.SelectedIndexChanged
        Try
            ObjInventario.Modelo = drlModelo.Text
            ObjInventario.Empresa = drlEmpresa.Text
            If drlEmpresa.Text = "KAMILION" Then
                drlSerial.Enabled = True
                drlSerial1.Enabled = False
                With drlSerial
                    .DataSource = ObjInventario.Consulta_Filtro_Serial_Asignar_SerialActivo
                    .DataTextField = "Serial_Kamilion"
                    .DataValueField = "Serial_Kamilion"
                    .DataBind()
                End With
            Else
                drlSerial.Enabled = False
                drlSerial1.Enabled = True
                With drlSerial1
                    .DataSource = ObjInventario.Consulta_Filtro_Serial_Asignar_Serial1Activo
                    .DataTextField = "Serial"
                    .DataValueField = "Serial"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub BtnAsignar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAsignar.Click
        Try
            If drlDispositivoIng.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un dispsitivo"
                Exit Sub
            End If
            If drlMarca.Text = "" Then
                lblmsg.Text = "Seleccione una Marca"
                Exit Sub
            End If
            If drlModelo.Text = "" Then
                lblmsg.Text = "Seleccione un Modelo"
                Exit Sub
            End If
            If drlEmpresa.Text = "" Then
                lblmsg.Text = "Seleccione una empresa o usuario del cual asignar el dispositivo"
                Exit Sub
            End If
            If drlSerial.Enabled = False Then
                If drlSerial1.Text = "" Then
                    lblmsg.Text = "Ingerse un serial para la asignacion"
                    Exit Sub
                End If
            End If
            If drlSerial.Enabled = True Then
                If drlSerial.Text = "" Then
                    lblmsg.Text = "Ingerse un serial para la asignacion"
                    Exit Sub
                End If
            End If
            If drlModuloIng.Enabled = False Then
                drlModuloIng.Text = Nothing
                If drlAgenIng.Enabled = True Then
                    If drlAgenIng.Text = "" Then
                        lblmsg.Text = "Seleccione una sede o usuario al cual Asiganara el dispositivo"
                        Exit Sub
                    End If
                End If
            Else
                If drlModuloIng.Enabled = True Then
                    drlAgenLib.Text = Nothing
                    If drlModuloIng.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una sede o usuario al cual Asiganara el dispositivo"
                        Exit Sub
                    End If
                End If
            End If
            If TxtObservacionIng.Text = "" Then
                lblmsg.Text = "Ingerse una observacion respecto a la asignacion"
                Exit Sub
            End If
            If drlModuloIng.Enabled = True Then
                If drlSerial.Enabled = True Then
                    Dim Registro As Integer
                    Dim dts As New DataSet
                    ObjInventario.Sede = drlModuloIng.Text
                    ObjInventario.Serial_Kamilion = drlSerial.Text
                    dts = ObjInventario.Validacion_Modulo_Un_Registro_AsigancionActivo
                    Registro = dts.Tables(0).Rows.Count
                    If Registro >= 1 Then
                        lblmsg.Text = "ya exite un Dispositivo (" + drlSerial.Text + ") registrada en el modulo " + drlModuloIng.Text
                        Exit Sub
                    End If
                Else
                    If drlSerial.Enabled = False Then
                        Dim Registro As Integer
                        Dim dts As New DataSet
                        ObjInventario.Sede = drlModuloIng.Text
                        ObjInventario.Serial = drlSerial1.Text
                        dts = ObjInventario.Validacion_Modulo_Un_Registro_Asigancion1Activo
                        Registro = dts.Tables(0).Rows.Count
                        If Registro >= 1 Then
                            lblmsg.Text = "ya exite un Dispositivo (" + drlSerial1.Text + ") registrada en el modulo " + drlModuloIng.Text
                            Exit Sub
                        End If
                    End If
                End If
                ObjInventario.Sede = drlModuloIng.Text
                ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoIng.Text
                ObjInventario.Estado = "Activo"
                ObjInventario.Serial_Kamilion = drlSerial.Text
                ObjInventario.Asignar_DispositivoActivo()
                If drlSerial.Enabled = True Then
                    ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoIng.Text
                    ObjInventario.Serial_Kamilion = drlSerial.Text
                    ObjInventario.Validacion_Codigo_Iventario_ActivosActivo()
                    LblCod_Inventario_Activos1.Text = ObjInventario.Cod_Inventario
                    drlSerial.Text = ""
                Else
                    If drlSerial.Enabled = False Then
                        ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoIng.Text
                        ObjInventario.Serial = drlSerial1.Text
                        ObjInventario.Validacion_Codigo_Iventario_Activos1Activo()
                        LblCod_Inventario_Activos1.Text = ObjInventario.Cod_Inventario
                        drlSerial1.Text = ""
                    End If
                End If
                ObjInventario.Cod_Agente = ""
                ObjInventario.Observacion = TxtObservacionIng.Text
                ObjInventario.Fk_Cod_Inventario = LblCod_Inventario_Activos1.Text
                ObjInventario.Sede = drlModuloIng.Text
                ObjInventario.Estado = "Activo"
                ObjInventario.Id_Usuario = lblusuario.Text
                ObjInventario.Registro_Liberacion_DispositivoActivo()
            Else
                If drlAgenIng.Enabled = True Then
                    Dim Registro As Integer
                    Dim dts As New DataSet
                    ObjInventario.Cod_Agente = drlAgenIng.Text
                    ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoIng.Text
                    dts = ObjInventario.Validacion_Agente_Un_Registro_AsigancionActivo
                    Registro = dts.Tables(0).Rows.Count
                    If Registro >= 1 Then
                        lblmsg.Text = "ya exite el Dispositivo registrado en el usuario " + drlAgenIng.Text
                        Exit Sub
                    End If
                    ObjInventario.Cod_Agente = drlAgenIng.Text
                    ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoIng.Text
                    ObjInventario.Estado = "Activo"
                    ObjInventario.Serial_Kamilion = drlSerial.Text
                    ObjInventario.Asignar_Dispositivo2Activo()
                    If drlSerial.Enabled = True Then
                        ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoIng.Text
                        ObjInventario.Serial_Kamilion = drlSerial.Text
                        ObjInventario.Validacion_Codigo_Iventario_ActivosActivo()
                        LblCod_Inventario_Activos1.Text = ObjInventario.Cod_Inventario
                        drlSerial.Text = ""
                    Else
                        If drlSerial.Enabled = False Then
                            ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivoIng.Text
                            ObjInventario.Serial = drlSerial1.Text
                            ObjInventario.Validacion_Codigo_Iventario_Activos1Activo()
                            LblCod_Inventario_Activos1.Text = ObjInventario.Cod_Inventario
                            drlSerial1.Text = ""
                        End If
                    End If
                    ObjInventario.Cod_Agente = drlAgenIng.Text
                    ObjInventario.Observacion = TxtObservacionIng.Text
                    ObjInventario.Fk_Cod_Inventario = LblCod_Inventario_Activos1.Text
                    ObjInventario.Sede = ""
                    ObjInventario.Estado = "Activo"
                    ObjInventario.Id_Usuario = lblusuario.Text
                    ObjInventario.Registro_Liberacion_DispositivoActivo()
                End If
            End If
            drlEmpresa.Text = ""
            lblmsg.Text = ""
            lblmsg.Text = "Dispositivo Asiganado"
            drlMarca.SelectedItem.Text = ""
            drlModelo.SelectedItem.Text = ""
            drlModuloIng.SelectedItem.Text = ""
            TxtObservacionIng.Text = ""
            Asiganacion = True
            ''Libreacion
            Cargardrl_Lib()
            ''Asignacion
            Cargardrl_Asignacion()
            ''Cambio de estado
            Cargardrl_Estado()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub


    Public Sub Consultas()
        Try
            '''''''''Estado
            If RdbtnEstado.Checked = True Then
                If drlCambioEstadoConsulta.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione un Estado que desea consultar"
                    Exit Sub
                End If
                ObjInventario.Estado = drlCambioEstadoConsulta.Text
                dtggeneral1.DataSource = ObjInventario.Consulta_Inventario_RegistrosActivo()
                dtggeneral1.DataBind()
                lblcantidad.Text = ObjInventario.Cantidad
                LblmsgConsultas.Text = ""
                ''Limpio dgt 2
                LblCantidad2.Text = ObjInventario.Cantidad
                LblmsgConsultas.Text = ""
                lblmsg.Text = ""
                Exit Sub
            End If
            If RdbtnSerial.Checked = True Then
                If TxtSerialConsulta.Text = "" Then
                    lblmsg.Text = "Seleccione un Serial que desea consultar"
                    Exit Sub
                End If
                ObjInventario.Serial_Kamilion = TxtSerialConsulta.Text
                dtggeneral1.DataSource = ObjInventario.Consulta_Inventario_RegistrosActivo()
                dtggeneral1.DataBind()
                lblcantidad.Text = ObjInventario.Cantidad
                LblmsgConsultas.Text = ""
                ''Limpio dgt 2
                LblCantidad2.Text = ""
                LblmsgConsultas.Text = ""
                lblmsg.Text = ""
                Exit Sub
            End If
            If RdbtnCodigo.Checked = True Then
                If TxtCodigo.Text = "" Then
                    lblmsg.Text = "Seleccione un Serial que desea consultar"
                    Exit Sub
                End If
                ObjInventario.Cod_Inventario = TxtCodigo.Text
                dtggeneral1.DataSource = ObjInventario.Consulta_Inventario_RegistrosActivo()
                dtggeneral1.DataBind()
                lblcantidad.Text = ObjInventario.Cantidad
                LblmsgConsultas.Text = ""
                ''Limpio dgt 2
                dtggeneral2.DataSource = ObjInventario.Consulta_Inventario_Registros_DetalleActivo()
                dtggeneral2.DataBind()
                LblCantidad2.Text = ObjInventario.Cantidad
                LblmsgConsultas.Text = ""
                lblmsg.Text = ""
                Exit Sub
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnConsultaInventario_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnConsultaInventario.Click
        Try
            Consultas()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drlDispositivoEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlDispositivoEstado.SelectedIndexChanged
        Try
            ObjInventario.Nombre_Dispositivo = drlDispositivoEstado.SelectedItem.Text
            With drlMarcaEstado
                .DataSource = ObjInventario.Consulta_Filtro_Marca_Estado_DispositivosActivo
                .DataTextField = "Marca"
                .DataValueField = "Marca"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drlMarcaEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlMarcaEstado.SelectedIndexChanged
        Try
            ObjInventario.Marca = drlMarcaEstado.Text
            With drlModeloEstado
                .DataSource = ObjInventario.Consulta_Filtro_Modelo_Estado_DispositivosActivo
                .DataTextField = "Modelo"
                .DataValueField = "Modelo"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drlModeloEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlModeloEstado.SelectedIndexChanged
        Try
            ObjInventario.Marca = drlMarcaEstado.Text
            ObjInventario.Nombre_Dispositivo = drlDispositivoEstado.SelectedItem.Text
            ObjInventario.Modelo = drlModeloEstado.Text
            With drlEmpresaEstado
                .DataSource = ObjInventario.Consulta_Filtro_empresa_Estado_DispositivosActivo
                .DataTextField = "Empresa"
                .DataValueField = "Empresa"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub drlempresaEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlEmpresaEstado.SelectedIndexChanged
        If drlEmpresaEstado.Text = "KAMILION" Then
            drlSerialEstado.Enabled = True
            drlSerial1Estado.Enabled = False
            Try
                ObjInventario.Marca = drlMarcaEstado.Text
                ObjInventario.Nombre_Dispositivo = drlDispositivoEstado.SelectedItem.Text
                ObjInventario.Modelo = drlModeloEstado.Text
                ObjInventario.Empresa = drlEmpresaEstado.Text
                With drlSerialEstado
                    .DataSource = ObjInventario.Consulta_Filtro_Serial_Estado_DispositivosActivo
                    .DataTextField = "Serial_Kamilion"
                    .DataValueField = "Serial_Kamilion"
                    .DataBind()
                End With
            Catch ex As Exception
                lblmsg.Text = "Se presento error: " + ex.Message
            End Try
        Else
            drlSerialEstado.Enabled = False
            drlSerial1Estado.Enabled = True
            Try
                ObjInventario.Marca = drlMarcaEstado.Text
                ObjInventario.Nombre_Dispositivo = drlDispositivoEstado.SelectedItem.Text
                ObjInventario.Modelo = drlModeloEstado.Text
                ObjInventario.Empresa = drlEmpresaEstado.Text
                With drlSerial1Estado
                    .DataSource = ObjInventario.Consulta_Filtro_Serial_Estado_DispositivosActivo
                    .DataTextField = "Serial"
                    .DataValueField = "Serial"
                    .DataBind()
                End With
            Catch ex As Exception
                lblmsg.Text = "Se presento error: " + ex.Message
            End Try
        End If
    End Sub
End Class