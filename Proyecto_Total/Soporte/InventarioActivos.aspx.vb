Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Public Class InventarioActivos
    Inherits System.Web.UI.Page
    Dim ObjInventario As New clsInventario
    Dim Dispositivodrl As Boolean = False
    Dim ModuloCondrl As Boolean = False
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
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
            lblmsg.Text = "Se presento erro: " + ex.Message
        End Try
    End Sub
    Public Sub Cargardrl()
        With drlcodigoagente
            .DataSource = ObjInventario.ConsultaCodigoAgentesActivo
            .DataTextField = "codnom"
            .DataValueField = "codnom"
            .DataBind()
        End With
        With drlAgenteDispositivo
            .DataSource = ObjInventario.Consulta_AgentesActivo
            .DataTextField = "nombreu"
            .DataValueField = "codnom"
            .DataBind()
        End With
        With drlMarcaDisposivito
            .DataSource = ObjInventario.Consulta_MarcaActivo
            .DataTextField = "Marca"
            .DataValueField = "Marca"
            .DataBind()
        End With
        With drlMarcaConsulta
            .DataSource = ObjInventario.Consulta_MarcaActivo
            .DataTextField = "Marca"
            .DataValueField = "Marca"
            .DataBind()
        End With
        With drlDispositivo
            .DataSource = ObjInventario.Consulta_DispositivosActivo
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Nombre_Dispositivo"
            .DataBind()
        End With
        With drlDispositivoconsulta
            .DataSource = ObjInventario.Consulta_DispositivosActivo
            .DataTextField = "Nombre_Dispositivo"
            .DataValueField = "Nombre_Dispositivo"
            .DataBind()
        End With
        With drlAgenteConsulta
            .DataSource = ObjInventario.Consulta_AgentesActivo
            .DataTextField = "nombreu"
            .DataValueField = "codnom"
            .DataBind()
        End With
    End Sub
    Protected Sub drlMarcaConsulta_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlMarcaConsulta.SelectedIndexChanged
        If drlMarcaConsulta.Text = "" Then
            TxtMarcaConsulta.Enabled = True
        Else
            TxtMarcaConsulta.Enabled = False
            TxtMarcaConsulta.Text = ""
        End If
    End Sub
    Protected Sub drlEmpresaConsulta_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlEmpresaConsulta.SelectedIndexChanged
        If drlEmpresaConsulta.Text = "Otro" Then
            TxtEmpresaConsulta.Enabled = True
        Else
            TxtEmpresaConsulta.Enabled = False
            TxtEmpresaConsulta.Text = ""
        End If
    End Sub
    Public Sub Consulta_Filtros()
        Try
            ''''''''' Codigo Agente
            If Rdbtncodigoagente.Checked = True Then
                If drlcodigoagente.SelectedItem.Text = "- Seleccione -" Then
                    LblmsgConsultas.Text = "Seleccione un código agente"
                    Exit Sub
                End If
                ObjInventario.Cod_Agente = drlcodigoagente.Text
                dtgConsultaMonitores.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                dtgConsultaMonitores.DataBind()
                ObjInventario.Cod_Agente = drlcodigoagente.Text
                dtgConsultaMonitores2.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                dtgConsultaMonitores2.DataBind()
                lblcantidad.Text = ObjInventario.Cantidad
                LblmsgConsultas.Text = ""
                lblmsg.Text = ""
                Exit Sub
            End If
            '''''''''Modulo
            If RdbtnModulo.Checked = True Then
                If drlModuloConsultas.Text = "- Seleccione -" Then
                    LblmsgConsultas.Text = "Seleccione una Sede"
                    Exit Sub
                End If
                ObjInventario.Sede = drlModuloConsultas.Text
                dtgConsultaMonitores.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                dtgConsultaMonitores.DataBind()
                dtgConsultaMonitores2.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                dtgConsultaMonitores2.DataBind()
                lblcantidad.Text = ObjInventario.Cantidad
                LblmsgConsultas.Text = ""
                lblmsg.Text = ""
                Exit Sub
            End If
            '''''''''Marca
            If RdbtnMarca.Checked = True Then
                If drlMarcaConsulta.Text = "" Then
                    If TxtMarcaConsulta.Text = "" Then
                        LblmsgConsultas.Text = "Ingrese una marca"
                        Exit Sub
                    Else
                        ObjInventario.Marca = TxtMarcaConsulta.Text
                    End If
                Else
                    ObjInventario.Marca = drlMarcaConsulta.Text
                    TxtMarcaConsulta.Enabled = False
                End If
                dtgConsultaMonitores.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                dtgConsultaMonitores.DataBind()
                dtgConsultaMonitores2.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                dtgConsultaMonitores2.DataBind()
                lblcantidad.Text = ObjInventario.Cantidad
                LblmsgConsultas.Text = ""
                lblmsg.Text = ""
                Exit Sub
            End If
            '''''''''Modelo
            If RdbtnModelo.Checked = True Then
                If TxtModeloConsulta.Text = "" Then
                    LblmsgConsultas.Text = "Ingrese un modelo"
                    Exit Sub
                End If
                ObjInventario.Modelo = TxtModeloConsulta.Text
                dtgConsultaMonitores.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                dtgConsultaMonitores.DataBind()
                dtgConsultaMonitores2.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                dtgConsultaMonitores2.DataBind()
                lblcantidad.Text = ObjInventario.Cantidad
                LblmsgConsultas.Text = ""
                lblmsg.Text = ""
                Exit Sub
            End If
            '''''''''Serial
            If RdbtnSerial.Checked = True Then
                If TxtSerialConsulta.Text = "" Then
                    LblmsgConsultas.Text = "Ingrese un serial"
                    Exit Sub
                Else
                    ObjInventario.Serial = TxtSerialConsulta.Text
                    dtgConsultaMonitores.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                    dtgConsultaMonitores.DataBind()
                    dtgConsultaMonitores2.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                    dtgConsultaMonitores2.DataBind()
                    lblcantidad.Text = ObjInventario.Cantidad
                    LblmsgConsultas.Text = ""
                    lblmsg.Text = ""
                    Exit Sub
                End If
            End If
            '''''''''Serial Kamilion
            If RdbtnSerialKamilion.Checked = True Then
                If TxtSerialKamilionConsulta.Text = "" Then
                    LblmsgConsultas.Text = "Ingrese un serial Kamilion"
                    Exit Sub
                Else
                    ObjInventario.Serial_Kamilion = TxtSerialKamilionConsulta.Text
                    dtgConsultaMonitores.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                    dtgConsultaMonitores.DataBind()
                    dtgConsultaMonitores2.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                    dtgConsultaMonitores2.DataBind()
                    lblcantidad.Text = ObjInventario.Cantidad
                    LblmsgConsultas.Text = ""
                    lblmsg.Text = ""
                    Exit Sub
                End If
            End If
            '''''''''Empresa
            If RdbtnEmpresa.Checked = True Then
                If drlEmpresaConsulta.Text = "- Seleccione -" Then
                    LblmsgConsultas.Text = "Seleccione una empresa"
                    Exit Sub
                End If
                If drlEmpresaConsulta.Text = "Otro" Then
                    If TxtEmpresaConsulta.Text = "" Then
                        LblmsgConsultas.Text = "Ingrese una empresa"
                        Exit Sub
                    Else
                        ObjInventario.Empresa = TxtEmpresaConsulta.Text
                    End If
                Else
                    ObjInventario.Empresa = drlEmpresaConsulta.Text
                End If
                dtgConsultaMonitores.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                dtgConsultaMonitores.DataBind()
                dtgConsultaMonitores2.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                dtgConsultaMonitores2.DataBind()
                lblcantidad.Text = ObjInventario.Cantidad
                LblmsgConsultas.Text = ""
                lblmsg.Text = ""
                Exit Sub
            End If
            '''''''''Todo
            If RdbtnTodo.Checked = True Then
                ObjInventario.Todo = 1
                dtgConsultaMonitores.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                dtgConsultaMonitores.DataBind()
                dtgConsultaMonitores2.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                dtgConsultaMonitores2.DataBind()
                lblcantidad.Text = ObjInventario.Cantidad
                LblmsgConsultas.Text = ""
                lblmsg.Text = ""
                Exit Sub
            End If
            '''''''''Agente
            If RdbtnAgente.Checked = True Then
                If drlAgenteConsulta.SelectedItem.Text = "- Seleccione -" Then
                    LblmsgConsultas.Text = "Seleccione un usuario\agente"
                    Exit Sub
                End If
                ObjInventario.Cod_Agente = drlAgenteConsulta.Text
                dtgConsultaMonitores.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                dtgConsultaMonitores.DataBind()
                dtgConsultaMonitores2.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                dtgConsultaMonitores2.DataBind()
                lblcantidad.Text = ObjInventario.Cantidad
                LblmsgConsultas.Text = ""
                lblmsg.Text = ""
                Exit Sub
            End If
            '''''''''Dispositivo
            If Rdbtndispositivo.Checked = True Then
                If drlDispositivoconsulta.SelectedItem.Text = "- Seleccione -" Then
                    LblmsgConsultas.Text = "Seleccione un dispositivo"
                    Exit Sub
                End If
                ObjInventario.Nombre_Dispositivo = drlDispositivoconsulta.Text
                dtgConsultaMonitores.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                dtgConsultaMonitores.DataBind()
                ObjInventario.Nombre_Dispositivo = drlDispositivoconsulta.Text
                dtgConsultaMonitores2.DataSource = ObjInventario.Consulta_Inventario_FiltrosActivo()
                dtgConsultaMonitores2.DataBind()
                lblcantidad.Text = ObjInventario.Cantidad
                LblmsgConsultas.Text = ""
                lblmsg.Text = ""
                Exit Sub
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " + ex.Message
        End Try
    End Sub

    Protected Sub BtnConsultaespe_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultaespe.Click
        Try
            If RdbtnModulo.Checked = False And RdbtnTodo.Checked = False And RdbtnAgente.Checked = False And Rdbtndispositivo.Checked = False And RdbtnMarca.Checked = False And RdbtnModelo.Checked = False And RdbtnSerial.Checked = False And RdbtnSerialKamilion.Checked = False And RdbtnEmpresa.Checked = False Then
                LblmsgConsultas.Text = "Seleccione alguna opcion  de consulta"
            Else
                Consulta_Filtros()
            End If
            If LblmsgConsultas.Text <> "" And LblmsgConsultas.Text <> "0" Then
                BtnExel.Visible = False
            Else
                BtnExel.Visible = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " + ex.Message
        End Try
    End Sub
    Protected Sub BtnConsultaInventario_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnConsultaInventario.Click
        Try
            If RdbtnModulo.Checked = False And RdbtnTodo.Checked = False And RdbtnAgente.Checked = False And Rdbtndispositivo.Checked = False And RdbtnMarca.Checked = False And RdbtnModelo.Checked = False And RdbtnSerial.Checked = False And RdbtnSerialKamilion.Checked = False And RdbtnEmpresa.Checked = False And Rdbtncodigoagente.Checked = False Then
                LblmsgConsultas.Text = "Seleccione alguna opcion  de consulta"
            Else
                Consulta_Filtros()
            End If
            If LblmsgConsultas.Text <> "" And LblmsgConsultas.Text <> "0" Then
                BtnExel.Visible = False
            Else
                BtnExel.Visible = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " + ex.Message
        End Try
    End Sub

    Protected Sub drlMarcaDisposivito_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlMarcaDisposivito.SelectedIndexChanged
        If drlMarcaDisposivito.Text = "" Then
            TxtMarcaDispositivo.Enabled = True
        Else
            TxtMarcaDispositivo.Enabled = False
        End If
    End Sub
    Protected Sub drlDispositivo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlDispositivo.SelectedIndexChanged
        Try
            If drlDispositivo.SelectedItem.Text = "Diademas" Or drlDispositivo.SelectedItem.Text = "Locker x16 Cajones" Or drlDispositivo.SelectedItem.Text = "Locker x6 Cajones" Then
                drlModuloDispositivo.Enabled = False
                drlAgenteDispositivo.Enabled = True
            Else
                drlModuloDispositivo.Enabled = True
                drlAgenteDispositivo.Enabled = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub drlEmpresaDispositivo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlEmpresaDispositivo.SelectedIndexChanged
        Try
            If drlEmpresaDispositivo.Text = "Otro" Then
                TxtEmpresaDispositivo.Enabled = True
            Else
                TxtEmpresaDispositivo.Enabled = False
                TxtEmpresaDispositivo.Text = ""
            End If

            If drlEmpresaDispositivo.Text <> "KAMILION" Then
                TxtSerialKamilionDispositivo.Text = ""
                TxtSerialKamilionDispositivo.Enabled = False
            Else
                TxtSerialKamilionDispositivo.Enabled = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " + ex.Message
        End Try
    End Sub

    Protected Sub BtnGuardarDispositivo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGuardarDispositivo.Click
        Try
            If drlDispositivo.SelectedItem.Text = "- Seleccione -" Then
                LblmsgDispositivo.Text = "Seleccione un Dispositivo para ingresar"
                Exit Sub
            End If
            If TxtMarcaDispositivo.Enabled = True And TxtMarcaDispositivo.Text = "" Then
                LblmsgDispositivo.Text = "Ingrese una Marca para el Dispositivo"
                Exit Sub
            Else
                ObjInventario.Marca = TxtMarcaDispositivo.Text
            End If
            If TxtMarcaDispositivo.Enabled = False Then
                TxtMarcaDispositivo.Text = ""
                ObjInventario.Marca = drlMarcaDisposivito.Text()
            End If
            If TxtModeloDispositivo.Text = "" Then
                LblmsgDispositivo.Text = "Ingrese un Modelo para el Dispositivo"
                Exit Sub
            Else
                ObjInventario.Modelo = TxtModeloDispositivo.Text
            End If
            If TxtDescripcion.Text = "" Then
                LblmsgDispositivo.Text = "Ingrese una Descripcion para el Dispositivo"
                Exit Sub
            Else
                ObjInventario.Descripcion = TxtDescripcion.Text
            End If
            If TxtSerialDispositivo.Text = "" Then
                ObjInventario.Serial = ""
            Else
                ObjInventario.Serial = TxtSerialDispositivo.Text
                Dim Registro2 As Integer
                Dim dts As New DataSet
                ObjInventario.Serial = TxtSerialDispositivo.Text
                dts = ObjInventario.Validacion_Modulo_Un_Registro2Activo
                Registro2 = dts.Tables(0).Rows.Count
                If Registro2 >= 1 Then
                    LblmsgDispositivo.Text = "ya exite un Dispositivo con el mismo Serial"
                    Exit Sub
                End If
            End If
            If TxtSerialKamilionDispositivo.Enabled = True Then
                If TxtSerialKamilionDispositivo.Text = "" Then
                    LblmsgDispositivo.Text = "Ingrese un serial kamilion para el Dispositivo"
                    Exit Sub
                Else
                    ObjInventario.Serial_Kamilion = TxtSerialKamilionDispositivo.Text
                    Dim Registro As Integer
                    Dim dts As New DataSet
                    ObjInventario.Serial_Kamilion = TxtSerialKamilionDispositivo.Text
                    dts = ObjInventario.Validacion_Modulo_Un_RegistroActivo
                    Registro = dts.Tables(0).Rows.Count
                    If Registro >= 1 Then
                        LblmsgDispositivo.Text = "ya exite un Dispositivo con el mismo Serial Kamilion"
                        Exit Sub
                    End If
                End If
            End If
            If drlEmpresaDispositivo.SelectedItem.Text = "- Seleccione -" Then
                LblmsgDispositivo.Text = "Seleccione una Empresa para el Dispositivo"
                Exit Sub
            Else
                If drlEmpresaDispositivo.SelectedItem.Text = "Otro" And TxtSerialDispositivo.Text = "" Then
                    LblmsgDispositivo.Text = "Ingrese un serial para el dispositivo"
                    Exit Sub
                End If
            End If
            If TxtEmpresaDispositivo.Enabled = True And TxtEmpresaDispositivo.Text = "" Then
                LblmsgDispositivo.Text = "Ingrese una Empresa para el Dispositivo"
                Exit Sub
            End If
            If TxtEmpresaDispositivo.Enabled = True Then
                ObjInventario.Empresa = TxtEmpresaDispositivo.Text
            Else
                ObjInventario.Empresa = drlEmpresaDispositivo.Text
            End If
            If drlModuloDispositivo.Enabled = True Then
                ObjInventario.Cod_Agente = Nothing
                If drlModuloDispositivo.Text = "- Seleccione -" Then
                    LblmsgDispositivo.Text = "Ingrese un usuario o sede para el Dispositivo"
                    Exit Sub
                End If
                If TxtSerialDispositivo.Enabled = True And TxtSerialDispositivo.Text <> Nothing Then
                    ObjInventario.Serial = TxtSerialDispositivo.Text
                    ObjInventario.Serial_Kamilion = TxtSerialKamilionDispositivo.Text
                    ObjInventario.Nombre_Dispositivo = drlDispositivo.Text
                    ObjInventario.Cambio_Nombre_CodigoActivo()
                    lblCodigo.Text = ObjInventario.Cod_Invent_Dispositivo
                    ObjInventario.Sede = drlModuloDispositivo.Text
                    ObjInventario.FK_Cod_Invent_Dispositivo = lblCodigo.Text
                    ObjInventario.Id_Usuario = lblusuario.Text
                    ObjInventario.Estado = "Activo"
                    ObjInventario.Ingresar_InventarioActivo()
                    LblmsgDispositivo.Text = "Dispositivo ingresado"
                    lblmsg.Text = ""
                    drlEmpresaDispositivo.Text = "- Seleccione -"
                    TxtEmpresaDispositivo.Text = ""
                    TxtModeloDispositivo.Text = ""
                    TxtDescripcion.Text = ""
                    TxtSerialDispositivo.Text = ""
                    TxtSerialKamilionDispositivo.Text = ""
                    drlModuloDispositivo.Text = "- Seleccione -"
                    TxtMarcaDispositivo.Text = ""
                    Cargardrl()
                Else
                    If TxtSerialKamilionDispositivo.Enabled = True Then
                        ObjInventario.Serial = ""
                        ObjInventario.Serial_Kamilion = TxtSerialKamilionDispositivo.Text
                        ObjInventario.Nombre_Dispositivo = drlDispositivo.Text
                        ObjInventario.Cambio_Nombre_CodigoActivo()
                        lblCodigo.Text = ObjInventario.Cod_Invent_Dispositivo
                        ObjInventario.Sede = drlModuloDispositivo.Text
                        ObjInventario.FK_Cod_Invent_Dispositivo = lblCodigo.Text
                        ObjInventario.Id_Usuario = lblusuario.Text
                        ObjInventario.Estado = "Activo"
                        ObjInventario.Ingresar_InventarioActivo()
                        LblmsgDispositivo.Text = "Dispositivo ingresado"
                        lblmsg.Text = ""
                        drlEmpresaDispositivo.Text = "- Seleccione -"
                        TxtEmpresaDispositivo.Text = ""
                        TxtModeloDispositivo.Text = ""
                        TxtDescripcion.Text = ""
                        TxtSerialDispositivo.Text = ""
                        TxtSerialKamilionDispositivo.Text = ""
                        drlModuloDispositivo.Text = "- Seleccione -"
                        TxtMarcaDispositivo.Text = ""
                        Cargardrl()
                    Else
                        ObjInventario.Serial = TxtSerialDispositivo.Text
                        ObjInventario.Serial_Kamilion = ""
                        ObjInventario.Nombre_Dispositivo = drlDispositivo.Text
                        ObjInventario.Cambio_Nombre_CodigoActivo()
                        lblCodigo.Text = ObjInventario.Cod_Invent_Dispositivo
                        ObjInventario.Sede = drlModuloDispositivo.Text
                        ObjInventario.FK_Cod_Invent_Dispositivo = lblCodigo.Text
                        ObjInventario.Id_Usuario = lblusuario.Text
                        ObjInventario.Estado = "Activo"
                        ObjInventario.Ingresar_InventarioActivo()
                        LblmsgDispositivo.Text = "Dispositivo ingresado"
                        lblmsg.Text = ""
                        drlEmpresaDispositivo.Text = "- Seleccione -"
                        TxtEmpresaDispositivo.Text = ""
                        TxtModeloDispositivo.Text = ""
                        TxtDescripcion.Text = ""
                        TxtSerialDispositivo.Text = ""
                        TxtSerialKamilionDispositivo.Text = ""
                        drlModuloDispositivo.Text = "- Seleccione -"
                        TxtMarcaDispositivo.Text = ""
                        Cargardrl()
                    End If
                End If
            End If
            If drlAgenteDispositivo.Enabled = True Then
                ObjInventario.Sede = Nothing
                ObjInventario.Cod_Agente = drlAgenteDispositivo.SelectedItem.Text
                ObjInventario.Cod_Agente = drlAgenteDispositivo.Text
                If drlAgenteDispositivo.SelectedItem.Text = "- Seleccione -" Or drlAgenteDispositivo.Text = "" Then
                    LblmsgDispositivo.Text = "Ingrese un usuario o sede para el Dispositivo"
                    Exit Sub
                End If
                If drlAgenteDispositivo.SelectedItem.Text = "BODEGA" Then
                    ObjInventario.Nombre_Dispositivo = drlDispositivo.Text
                    ObjInventario.Cambio_Nombre_CodigoActivo()
                    lblCodigo.Text = ObjInventario.Cod_Invent_Dispositivo
                    ObjInventario.Sede = "BOD"
                    ObjInventario.FK_Cod_Invent_Dispositivo = lblCodigo.Text
                    ObjInventario.Id_Usuario = lblusuario.Text
                    ObjInventario.Estado = "Activo"
                    ObjInventario.Ingresar_Inventario3Activo()
                    LblmsgDispositivo.Text = "Dispositivo ingresado"
                    lblmsg.Text = ""
                    drlEmpresaDispositivo.Text = "- Seleccione -"
                    TxtEmpresaDispositivo.Text = ""
                    TxtModeloDispositivo.Text = ""
                    TxtDescripcion.Text = ""
                    TxtSerialDispositivo.Text = ""
                    TxtSerialKamilionDispositivo.Text = ""
                    drlModuloDispositivo.Text = "- Seleccione -"
                    TxtMarcaDispositivo.Text = ""
                    Cargardrl()
                End If
                Dim Registro2 As Integer
                Dim dts2 As New DataSet
                ObjInventario.Cod_Agente = drlAgenteDispositivo.Text
                ObjInventario.Nombre_Dispositivo = drlDispositivo.SelectedItem.Text
                dts2 = ObjInventario.Validacion_Agente_Un_RegistroActivo
                Registro2 = dts2.Tables(0).Rows.Count
                If Registro2 >= 1 Then
                    LblmsgDispositivo.Text = "ya exite un Dispositivo '" + drlDispositivo.SelectedItem.Text + "' registrado en el agente " + drlAgenteDispositivo.Text
                    Exit Sub
                End If
                ObjInventario.Nombre_Dispositivo = drlDispositivo.Text
                ObjInventario.Cambio_Nombre_CodigoActivo()
                lblCodigo.Text = ObjInventario.Cod_Invent_Dispositivo
                ObjInventario.Cod_Agente = drlAgenteDispositivo.Text
                ObjInventario.FK_Cod_Invent_Dispositivo = lblCodigo.Text
                ObjInventario.Id_Usuario = lblusuario.Text
                ObjInventario.Estado = "Activo"
                ObjInventario.Ingresar_Inventario2Activo()
                LblmsgDispositivo.Text = "Dispositivo ingresado"
                lblmsg.Text = ""
                drlEmpresaDispositivo.Text = "- Seleccione -"
                TxtEmpresaDispositivo.Text = ""
                TxtModeloDispositivo.Text = ""
                TxtDescripcion.Text = ""
                TxtSerialDispositivo.Text = ""
                TxtSerialKamilionDispositivo.Text = ""
                drlModuloDispositivo.Text = "- Seleccione -"
                TxtMarcaDispositivo.Text = ""
                Cargardrl()
            End If

        Catch ex As Exception
            lblmsg.Text = "Se presento falla: " + ex.Message
        End Try
    End Sub

    Protected Sub TxtMarcaDispositivo_TextChanged(sender As Object, e As EventArgs)

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
            If dtgConsultaMonitores2.Visible = False Then
                dtgConsultaMonitores2.Visible = True
            End If
            form.Controls.Add(dtgConsultaMonitores2)
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
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub BtnExel_Click(sender As Object, e As EventArgs) Handles BtnExel.Click
        Try
            Exportarxls()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub dtgConsultaMonitores_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtgConsultaMonitores.PageIndexChanging
        dtgConsultaMonitores.PageIndex = e.NewPageIndex
        Consulta_Filtros()
    End Sub
    Protected Sub dtgConsultaMonitores2_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtgConsultaMonitores2.PageIndexChanging
        dtgConsultaMonitores2.PageIndex = e.NewPageIndex
        Consulta_Filtros()
    End Sub
End Class