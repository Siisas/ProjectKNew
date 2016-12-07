Public Class Inventario
    Inherits System.Web.UI.Page
    Dim ObjInventario As New clsInventario
    Dim Monitordrl As Boolean = False
    Dim Tecladodrl As Boolean = False
    Dim Mousedrl As Boolean = False
    Dim Torredrl As Boolean = False
    Dim Dispositivodrl As Boolean = False
    Dim ModuloCondrl As Boolean = False

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Pnl_Message.CssClass = Nothing
                lblmsg.Text = Nothing
                Session("Formulario") = "Inventario"
                '/***************************************/
                With drlModuloMonitor
                    .DataSource = ObjInventario.Consulta_Modulos
                    .DataTextField = "ID_Modulo"
                    .DataValueField = "ID_Modulo"
                    .DataBind()
                End With


                With drlModuloTeclado
                    .DataSource = ObjInventario.Consulta_Modulos
                    .DataTextField = "ID_Modulo"
                    .DataValueField = "ID_Modulo"
                    .DataBind()
                End With
                With drlModuloMouse
                    .DataSource = ObjInventario.Consulta_Modulos
                    .DataTextField = "ID_Modulo"
                    .DataValueField = "ID_Modulo"
                    .DataBind()
                End With
                With drlModuloTorre
                    .DataSource = ObjInventario.Consulta_Modulos
                    .DataTextField = "ID_Modulo"
                    .DataValueField = "ID_Modulo"
                    .DataBind()
                End With
                With drlModuloConsultas
                    .DataSource = ObjInventario.Consulta_Modulos
                    .DataTextField = "ID_Modulo"
                    .DataValueField = "ID_Modulo"
                    .DataBind()
                End With
                With drlModuloDispositivo
                    .DataSource = ObjInventario.Consulta_Modulos
                    .DataTextField = "ID_Modulo"
                    .DataValueField = "ID_Modulo"
                    .DataBind()
                End With
                With drlDispositivo
                    .DataSource = ObjInventario.Consulta_Dispositivos
                    .DataTextField = "Nombre_Dispositivo"
                    .DataValueField = "Cod_Invent_Dispositivo"
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
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento erro: " & ex.Message
        End Try
    End Sub

    Public Sub Cargardrl()
        If Monitordrl = True Then
            With drlModuloMonitor
                .DataSource = ObjInventario.Consulta_Modulos
                .DataTextField = "ID_Modulo"
                .DataValueField = "ID_Modulo"
                .DataBind()
            End With
            Monitordrl = False
        End If
        If Tecladodrl = True Then
            With drlModuloTeclado
                .DataSource = ObjInventario.Consulta_Modulos
                .DataTextField = "ID_Modulo"
                .DataValueField = "ID_Modulo"
                .DataBind()
            End With
            Tecladodrl = False
        End If
        If Mousedrl = True Then
            With drlModuloMouse
                .DataSource = ObjInventario.Consulta_Modulos
                .DataTextField = "ID_Modulo"
                .DataValueField = "ID_Modulo"
                .DataBind()
            End With
            Mousedrl = False
        End If
        If Torredrl = True Then
            With drlModuloTorre
                .DataSource = ObjInventario.Consulta_Modulos
                .DataTextField = "ID_Modulo"
                .DataValueField = "ID_Modulo"
                .DataBind()
            End With
            Torredrl = False
        End If
        If Dispositivodrl = True Then
            With drlModuloDispositivo
                .DataSource = ObjInventario.Consulta_Modulos
                .DataTextField = "ID_Modulo"
                .DataValueField = "ID_Modulo"
                .DataBind()
            End With
            Dispositivodrl = False
        End If
        If ModuloCondrl = True Then
            With drlModuloConsultas
                .DataSource = ObjInventario.Consulta_Modulos
                .DataTextField = "ID_Modulo"
                .DataValueField = "ID_Modulo"
                .DataBind()
            End With
            With drlDispositivo
                .DataSource = ObjInventario.Consulta_Dispositivos
                .DataTextField = "Nombre_Dispositivo"
                .DataValueField = "Cod_Invent_Dispositivo"
                .DataBind()
            End With
            ModuloCondrl = False
        End If
    End Sub


    Protected Sub drlMarcaPantalla_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlMarcaMonitor.SelectedIndexChanged
        If drlMarcaMonitor.Text = "Otro" Then
            TxtMarcaMonitor.Enabled = True
        Else
            TxtMarcaMonitor.Enabled = False
            TxtMarcaMonitor.Text = ""
        End If
    End Sub

    Protected Sub drlMarcaTeclado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlMarcaTeclado.SelectedIndexChanged
        If drlMarcaTeclado.Text = "Otro" Then
            TxtMarcaTeclado.Enabled = True
        Else
            TxtMarcaTeclado.Enabled = False
            TxtMarcaTeclado.Text = ""
        End If
    End Sub

    Protected Sub drlMarcaMouse_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlMarcaMouse.SelectedIndexChanged
        If drlMarcaMouse.Text = "Otro" Then
            TxtMarcaMouse.Enabled = True
        Else
            TxtMarcaMouse.Enabled = False
            TxtMarcaMouse.Text = ""
        End If
    End Sub

    Protected Sub drlMarcaTorre_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlMarcaTorre.SelectedIndexChanged
        If drlMarcaTorre.Text = "Otro" Then
            TxtMarcaTorre.Enabled = True
        Else
            TxtMarcaTorre.Enabled = False
            TxtMarcaTorre.Text = ""
        End If
    End Sub

    Protected Sub drlMarcaConsulta_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlMarcaConsulta.SelectedIndexChanged
        If drlMarcaConsulta.Text = "Otro" Then
            TxtMarcaConsulta.Enabled = True
        Else
            TxtMarcaConsulta.Enabled = False
            TxtMarcaConsulta.Text = ""
        End If
    End Sub

    Protected Sub BtnGuardarModulo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGuardarModulo.Click
        Try
            If TxtLetra.Text = "" And TxtNumero.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese una letra y Numero"
                Exit Sub
            End If
            TxtLetra.Text = (UCase(TxtLetra.Text))
            Dim Registro As Integer
            Dim dts As New DataSet
            ObjInventario.ID_Modulo = TxtLetra.Text + TxtNumero.Text
            dts = ObjInventario.Validacion_Modulo
            Registro = dts.Tables(0).Rows.Count
            If Registro >= 1 Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> El Modulo " + TxtLetra.Text + TxtNumero.Text + " ya existe"
                Exit Sub
            End If
            ObjInventario.Letra = TxtLetra.Text
            ObjInventario.Numero = TxtNumero.Text
            ObjInventario.ID_Modulo = TxtLetra.Text + TxtNumero.Text
            If Txt_Fc_Adq.Text <> Nothing Then
                ObjInventario.FcReg_Invent = Txt_Fc_Adq.Text
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la fecha de adquisición Modulo"
                Exit Sub
            End If
            ObjInventario.Estado = "Activo"
            ObjInventario.Ingresar_Modulo()

            LblModulo.Text = TxtLetra.Text + TxtNumero.Text
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Modulo ingresado"
            Cargardrl()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento erro: " & ex.Message
        End Try
    End Sub


    Protected Sub BtnGuardarMonitor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGuardarMonitor.Click
        Try
            If drlModuloMonitor.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Modulo para el Monitor"
                Exit Sub
            End If
            Dim Registro As Integer
            Dim dts As New DataSet
            Dim x As String
            ObjInventario.ID_Modulo = drlModuloDispositivo.SelectedItem.Text
            ObjInventario.Validacion_Modulo()
            x = ObjInventario.ID_Modulo
            If drlModuloMonitor.SelectedItem.Text <> "BODEGA" Then
                ObjInventario.ID_Modulo = drlModuloMonitor.Text
                ObjInventario.FK_Cod_Invent_Dispositivo = 1
                dts = ObjInventario.Validacion_Modulo_Un_Registro
                Registro = dts.Tables(0).Rows.Count
                If x <> "RAC" Then
                    If Registro >= 1 Then
                        Pnl_Message.CssClass = "alert alert-info"
                        lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> ya exite un Monitor registrada en el modulo " + drlModuloMonitor.Text
                        Exit Sub
                    End If
                End If
            End If

            If drlMarcaMonitor.Text = "1" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione la marca del Monitor"
                Exit Sub
            End If
            If TxtMarcaMonitor.Enabled = True And TxtMarcaMonitor.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la marca del Monitor"
                Exit Sub
            End If
            If drlEmpresaMonitor.Text = "1" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione la empresa del Monitor"
                Exit Sub
            End If
            If TxtEmpresaMonitor.Enabled = True And TxtEmpresaMonitor.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la empresa del Monitor"
                Exit Sub
            End If
            If TxtSerialKamilionMonitor.Enabled = False And TxtSerialMonitor.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el serial del Monitor"
                Exit Sub
            End If
            If TxtSerialKamilionMonitor.Enabled = True And TxtSerialKamilionMonitor.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese un serial Kamilion para el Monitor"
                Exit Sub
            End If

            If TxtMarcaMonitor.Enabled = True Then
                ObjInventario.Marca = TxtMarcaMonitor.Text
            Else
                ObjInventario.Marca = drlMarcaMonitor.Text
            End If
            If TxtModeloMonitor.Text = "" Then
                ObjInventario.Modelo = ""
            Else
                ObjInventario.Modelo = TxtModeloMonitor.Text
            End If
            If TxtSerialMonitor.Text = "" Then
                ObjInventario.Serial = ""
            Else
                ObjInventario.Serial = TxtSerialMonitor.Text
            End If
            If TxtEmpresaMonitor.Enabled = True Then
                ObjInventario.Empresa = TxtEmpresaMonitor.Text
            Else
                ObjInventario.Empresa = drlEmpresaMonitor.Text
            End If
            If TxtSerialKamilionMonitor.Text = "" Then
                ObjInventario.Serial_Kamilion = ""
            Else
                ObjInventario.Serial_Kamilion = TxtSerialKamilionMonitor.Text
            End If


            If TxtSerialMonitor.Text <> "" Or TxtSerialMonitor.Text <> Nothing Then
                dts = ObjInventario.Consulta_Validacion_Serial
                Registro = dts.Tables(0).Rows.Count
                If Registro >= 1 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> ya exite un Monitor registrado con este Serial: " + TxtSerialMonitor.Text
                    Exit Sub
                End If
            End If

            If TxtSerialKamilionMonitor.Text <> "" Or TxtSerialKamilionMonitor.Text <> Nothing Then
                dts = ObjInventario.Consulta_Validacion_Serial_Kamilion
                Registro = dts.Tables(0).Rows.Count
                If Registro >= 1 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> ya exite un Monitor registrado con este Serial Kamilion: " + TxtSerialKamilionMonitor.Text
                    Exit Sub
                End If
            End If

            ObjInventario.Fk_ID_Modulo = drlModuloMonitor.Text
            ObjInventario.FK_Cod_Invent_Dispositivo = 1
            ObjInventario.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            If txt_Fc_Adq_Monitor.Text <> Nothing Then
                ObjInventario.Fc_ruta = txt_Fc_Adq_Monitor.Text
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la fecha de adquisición del Monitor"
                Exit Sub
            End If
            ObjInventario.Estado = "Activo"
            ObjInventario.Ingresar_Inventario()

            drlMarcaMonitor.Text = "1"
            TxtMarcaMonitor.Text = ""
            TxtMarcaMonitor.Enabled = False
            TxtModeloMonitor.Text = ""
            TxtSerialMonitor.Text = ""
            TxtSerialKamilionMonitor.Text = ""
            drlEmpresaMonitor.Text = "1"
            TxtEmpresaMonitor.Text = ""
            TxtEmpresaMonitor.Enabled = False
            Monitordrl = True
            Cargardrl()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Monitor ingresado"

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento erro: " & ex.Message
        End Try
    End Sub

    Protected Sub BtnGuardarTeclado_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGuardarTeclado.Click
        Try
            If drlModuloTeclado.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un modulo para el Teclado"
                Exit Sub
            End If
            Dim Registro As Integer
            Dim dts As New DataSet
            Dim x As String
            ObjInventario.ID_Modulo = drlModuloDispositivo.SelectedItem.Text
            ObjInventario.Validacion_Modulo()
            x = ObjInventario.ID_Modulo
            If drlModuloTeclado.SelectedItem.Text <> "BODEGA" Then
                ObjInventario.ID_Modulo = drlModuloTeclado.Text
                ObjInventario.FK_Cod_Invent_Dispositivo = 2
                dts = ObjInventario.Validacion_Modulo_Un_Registro
                Registro = dts.Tables(0).Rows.Count
                If x <> "RAC" Then
                    If Registro >= 1 Then
                        Pnl_Message.CssClass = "alert alert-info"
                        lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> ya exite un Teclado registrada en el modulo " + drlModuloTeclado.Text
                        Exit Sub
                    End If
                End If
            End If

            If drlMarcaTeclado.Text = "1" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione la marca del Teclado"
                Exit Sub
            End If
            If TxtMarcaTeclado.Enabled = True And TxtMarcaTeclado.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la maraca del Teclado"
                Exit Sub
            End If
            If drlEmpresaTeclado.Text = "1" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione la empresa del Teclado"
                Exit Sub
            End If
            If TxtEmpresaTeclado.Enabled = True And TxtEmpresaTeclado.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la empresa del Teclado"
                Exit Sub
            End If
            If TxtSerialKamilionTeclado.Enabled = False And TxtSerialTeclado.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el serial del Teclado"
                Exit Sub
            End If
            If TxtSerialKamilionTeclado.Enabled = True And TxtSerialKamilionTeclado.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese un serial Kamilion para el Teclado"
                Exit Sub
            End If

            If TxtMarcaTeclado.Enabled = True Then
                ObjInventario.Marca = TxtMarcaTeclado.Text
            Else
                ObjInventario.Marca = drlMarcaTeclado.Text
            End If
            If TxtModeloTeclado.Text = "" Then
                ObjInventario.Modelo = ""
            Else
                ObjInventario.Modelo = TxtModeloTeclado.Text
            End If
            If TxtSerialTeclado.Text = "" Then
                ObjInventario.Serial = ""
            Else
                ObjInventario.Serial = TxtSerialTeclado.Text
            End If
            If TxtEmpresaTeclado.Enabled = True Then
                ObjInventario.Empresa = TxtEmpresaTeclado.Text
            Else
                ObjInventario.Empresa = drlEmpresaTeclado.Text
            End If
            If TxtSerialKamilionTeclado.Text = "" Then
                ObjInventario.Serial_Kamilion = ""
            Else
                ObjInventario.Serial_Kamilion = TxtSerialKamilionTeclado.Text
            End If

            If TxtSerialTeclado.Text <> "" Or TxtSerialTeclado.Text <> Nothing Then
                dts = ObjInventario.Consulta_Validacion_Serial
                Registro = dts.Tables(0).Rows.Count
                If Registro >= 1 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> ya exite un Teclado registrado con este Serial: " + TxtSerialTeclado.Text
                    Exit Sub
                End If
            End If

            If TxtSerialKamilionTeclado.Text <> "" Or TxtSerialKamilionTeclado.Text <> Nothing Then
                dts = ObjInventario.Consulta_Validacion_Serial_Kamilion
                Registro = dts.Tables(0).Rows.Count
                If Registro >= 1 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> ya exite un Teclado registrado con este Serial Kamilion: " + TxtSerialKamilionTeclado.Text
                    Exit Sub
                End If
            End If

            ObjInventario.Fk_ID_Modulo = drlModuloTeclado.Text
            ObjInventario.FK_Cod_Invent_Dispositivo = 2
            ObjInventario.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            If txt_Fc_Adq_Teclado.Text <> Nothing Then
                ObjInventario.Fc_ruta = txt_Fc_Adq_Teclado.Text
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>  Ingrese la fecha de adquisición del Monitor"
                Exit Sub
            End If
            ObjInventario.Estado = "Activo"

            ObjInventario.Ingresar_Inventario()

            drlMarcaTeclado.Text = "1"
            TxtMarcaTeclado.Text = ""
            TxtMarcaTeclado.Enabled = False
            TxtModeloTeclado.Text = ""
            TxtSerialTeclado.Text = ""
            TxtSerialKamilionTeclado.Text = ""
            drlEmpresaTeclado.Text = "1"
            TxtEmpresaTeclado.Text = ""
            TxtEmpresaTeclado.Enabled = False
            Tecladodrl = True
            Cargardrl()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Teclado Ingresado"
        Catch ex As Exception

            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento falla: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnGuardarMouse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGuardarMouse.Click
        Try
            If drlModuloMouse.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un modulo para el Mouse"
                Exit Sub
            End If
            Dim Registro As Integer
            Dim dts As New DataSet
            Dim x As String
            ObjInventario.ID_Modulo = drlModuloDispositivo.SelectedItem.Text
            ObjInventario.Validacion_Modulo()
            x = ObjInventario.ID_Modulo
            If drlModuloMouse.SelectedItem.Text <> "BODEGA" Then
                ObjInventario.ID_Modulo = drlModuloMouse.Text
                ObjInventario.FK_Cod_Invent_Dispositivo = 3
                dts = ObjInventario.Validacion_Modulo_Un_Registro
                Registro = dts.Tables(0).Rows.Count
                If x <> "RAC" Then
                    If Registro >= 1 Then
                        Pnl_Message.CssClass = "alert alert-info"
                        lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> ya exite un Mouse registrada en el modulo " + drlModuloMouse.Text
                        Exit Sub
                    End If
                End If
            End If

            If drlMarcaMouse.Text = "1" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione la marca del Mouse"
                Exit Sub
            End If
            If TxtMarcaMouse.Enabled = True And TxtMarcaMouse.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la marca del Mouse"
                Exit Sub
            End If
            If drlEmpresaMouse.Text = "1" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione la empresa del Mouse"
                Exit Sub
            End If
            If TxtEmpresaMouse.Enabled = True And TxtEmpresaMouse.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la empresa del Mouse"
                Exit Sub
            End If
            If TxtSerialKamilionMouse.Enabled = False And TxtSerialMouse.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el serial para el Mouse"
                Exit Sub
            End If
            If TxtSerialKamilionMouse.Enabled = True And TxtSerialKamilionMouse.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese un serial Kamilion para el Mouse"
                Exit Sub
            End If

            If TxtMarcaMouse.Enabled = True Then
                ObjInventario.Marca = TxtMarcaMouse.Text
            Else
                ObjInventario.Marca = drlMarcaMouse.Text
            End If
            If TxtModeloMouse.Text = "" Then
                ObjInventario.Modelo = ""
            Else
                ObjInventario.Modelo = TxtModeloMouse.Text
            End If
            If TxtSerialMouse.Text = "" Then
                ObjInventario.Serial = ""
            Else
                ObjInventario.Serial = TxtSerialMouse.Text
            End If
            If TxtEmpresaMouse.Enabled = True Then
                ObjInventario.Empresa = TxtEmpresaMouse.Text
            Else
                ObjInventario.Empresa = drlEmpresaMouse.Text
            End If
            If TxtSerialKamilionMouse.Text = "" Then
                ObjInventario.Serial_Kamilion = ""
            Else
                ObjInventario.Serial_Kamilion = TxtSerialKamilionMouse.Text
            End If

            If TxtSerialMouse.Text <> "" Or TxtSerialMouse.Text <> Nothing Then
                dts = ObjInventario.Consulta_Validacion_Serial
                Registro = dts.Tables(0).Rows.Count
                If Registro >= 1 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> ya exite un Mouse registrado con este Serial: " + TxtSerialMouse.Text
                    Exit Sub
                End If
            End If

            If TxtSerialKamilionMouse.Text <> "" Or TxtSerialKamilionMouse.Text <> Nothing Then
                dts = ObjInventario.Consulta_Validacion_Serial_Kamilion
                Registro = dts.Tables(0).Rows.Count
                If Registro >= 1 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> ya exite un Mouse registrado con este Serial Kamilion: " + TxtSerialKamilionMouse.Text
                    Exit Sub
                End If
            End If

            ObjInventario.Fk_ID_Modulo = drlModuloMouse.Text
            ObjInventario.FK_Cod_Invent_Dispositivo = 3
            ObjInventario.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            If txt_Fc_Adq_Mouse.Text <> Nothing Then
                ObjInventario.Fc_ruta = txt_Fc_Adq_Mouse.Text
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>  Ingrese la fecha de adquisición del Mouse"
                Exit Sub
            End If
            ObjInventario.Estado = "Activo"

            ObjInventario.Ingresar_Inventario()

            drlMarcaMouse.Text = "1"
            TxtMarcaMouse.Text = ""
            TxtMarcaMouse.Enabled = False
            TxtModeloMouse.Text = ""
            TxtSerialMouse.Text = ""
            TxtSerialKamilionMouse.Text = ""
            drlEmpresaMouse.Text = "1"
            TxtEmpresaMouse.Text = ""
            TxtEmpresaMouse.Enabled = False
            Mousedrl = True
            Cargardrl()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Mouse Ingresado"

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento falla: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnGuardarTorre_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGuardarTorre.Click
        Try
            If drlModuloTorre.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un modulo para la Torre"
                Exit Sub
            End If
            Dim Registro As Integer
            Dim dts As New DataSet
            Dim x As String
            ObjInventario.ID_Modulo = drlModuloDispositivo.SelectedItem.Text
            ObjInventario.Validacion_Modulo()
            x = ObjInventario.ID_Modulo
            If drlModuloTorre.SelectedItem.Text <> "BODEGA" Then
                ObjInventario.ID_Modulo = drlModuloTorre.Text
                ObjInventario.FK_Cod_Invent_Dispositivo = 4
                dts = ObjInventario.Validacion_Modulo_Un_Registro
                Registro = dts.Tables(0).Rows.Count
                If x <> "RAC" Then
                    If Registro >= 1 Then
                        Pnl_Message.CssClass = "alert alert-info"
                        lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> ya exite una Torre registrada en el modulo " + drlModuloTorre.Text
                        Exit Sub
                    End If
                End If
            End If
            If drlMarcaTorre.Text = "1" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione la marca de la Torre"
                Exit Sub
            End If
            If TxtMarcaTorre.Enabled = True And TxtMarcaTorre.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la marca de la Torre"
                Exit Sub
            End If
            If drlEmpresaTorre.Text = "1" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione la Empresa de la Torre"
                Exit Sub
            End If
            If TxtEmpresaTorre.Enabled = True And TxtEmpresaTorre.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la empresa de la Torre"
                Exit Sub
            End If
            If TxtSerialKamilionTorre.Enabled = False And TxtSerialTorre.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el serial de la Torre"
                Exit Sub
            End If
            If TxtSerialKamilionTorre.Enabled = True And TxtSerialKamilionTorre.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese un serial Kamilion para la Torre"
                Exit Sub
            End If

            If TxtMarcaTorre.Enabled = True Then
                ObjInventario.Marca = TxtMarcaTorre.Text
            Else
                ObjInventario.Marca = drlMarcaTorre.Text
            End If
            If TxtModeloTorre.Text = "" Then
                ObjInventario.Modelo = ""
            Else
                ObjInventario.Modelo = TxtModeloTorre.Text
            End If
            If TxtSerialTorre.Text = "" Then
                ObjInventario.Serial = ""
            Else
                ObjInventario.Serial = TxtSerialTorre.Text
            End If
            If TxtEmpresaTorre.Enabled = True Then
                ObjInventario.Empresa = TxtEmpresaTorre.Text
            Else
                ObjInventario.Empresa = drlEmpresaTorre.Text
            End If
            If TxtSerialKamilionTorre.Text = "" Then
                ObjInventario.Serial_Kamilion = ""
            Else
                ObjInventario.Serial_Kamilion = TxtSerialKamilionTorre.Text
            End If

            If TxtSerialTorre.Text <> "" Or TxtSerialTorre.Text <> Nothing Then
                dts = ObjInventario.Consulta_Validacion_Serial
                Registro = dts.Tables(0).Rows.Count
                If Registro >= 1 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> ya exite una Torre registrada con este Serial: " + TxtSerialTorre.Text
                    Exit Sub
                End If
            End If

            If TxtSerialKamilionTorre.Text <> "" Or TxtSerialKamilionTorre.Text <> Nothing Then
                dts = ObjInventario.Consulta_Validacion_Serial_Kamilion
                Registro = dts.Tables(0).Rows.Count
                If Registro >= 1 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> ya exite una Torre registrada con este Serial Kamilion: " + TxtSerialKamilionTorre.Text
                    Exit Sub
                End If
            End If

            ObjInventario.Fk_ID_Modulo = drlModuloTorre.Text
            ObjInventario.FK_Cod_Invent_Dispositivo = 4
            ObjInventario.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            If txt_Fc_Adq_Torre.Text <> Nothing Then
                ObjInventario.Fc_ruta = txt_Fc_Adq_Torre.Text
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>  Ingrese la fecha de adquisición de la Torre"
                Exit Sub
            End If
            ObjInventario.Estado = "Activo"

            ObjInventario.Ingresar_Inventario()

            drlMarcaTorre.Text = "1"
            TxtMarcaTorre.Text = ""
            TxtMarcaTorre.Enabled = False
            TxtModeloTorre.Text = ""
            TxtSerialTorre.Text = ""
            TxtSerialKamilionTorre.Text = ""
            drlEmpresaTorre.Text = "1"
            TxtEmpresaTorre.Text = ""
            TxtEmpresaTorre.Enabled = False
            Torredrl = True
            Cargardrl()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Torre Ingresada"
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento falla: " + ex.Message
        End Try
    End Sub

    Public Sub Consulta_Filtros()
        Try
            '''''''''Modulo
            If RdbtnModulo.Checked = True Then
                If drlModuloConsultas.Text = "- Seleccione -" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Modulo"
                    Exit Sub
                End If
                ObjInventario.ID_Modulo = drlModuloConsultas.Text
            End If
            '''''''''Marca
            If RdbtnMarca.Checked = True Then
                If drlMarcaConsulta.Text = "- Seleccione -" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una marca"
                    Exit Sub
                End If
                If drlMarcaConsulta.Text = "Otro" Then
                    If TxtMarcaConsulta.Text = "" Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese una marca"
                        Exit Sub
                    Else
                        ObjInventario.Marca = TxtMarcaConsulta.Text
                    End If
                Else
                    ObjInventario.Marca = drlMarcaConsulta.Text
                End If
            End If
            '''''''''Modelo
            If RdbtnModelo.Checked = True Then
                If TxtModeloConsulta.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese un modelo"
                    Exit Sub
                End If
                ObjInventario.Modelo = TxtModeloConsulta.Text
            End If
            '''''''''Serial
            If RdbtnSerial.Checked = True Then
                If TxtSerialConsulta.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese un serial"
                    Exit Sub
                Else
                    ObjInventario.Serial = TxtSerialConsulta.Text
                End If
            End If
            '''''''''Serial Kamilion
            If RdbtnSerialKamilion.Checked = True Then
                If TxtSerialKamilionConsulta.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese un serial Kamilion"
                    Exit Sub
                Else
                    ObjInventario.Serial_Kamilion = TxtSerialKamilionConsulta.Text
                End If
            End If
            '''''''''Empresa
            If RdbtnEmpresa.Checked = True Then
                If drlEmpresaConsulta.Text = "- Seleccione -" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una empresa"
                    Exit Sub
                End If
                If drlEmpresaConsulta.Text = "Otro" Then
                    If TxtEmpresaConsulta.Text = "" Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese una empresa"
                        Exit Sub
                    Else
                        ObjInventario.Empresa = TxtEmpresaConsulta.Text
                    End If
                Else
                    ObjInventario.Empresa = drlEmpresaConsulta.Text
                End If
            End If
            If RdbtnFc_Adquisicion.Checked = True Then
                If Txt_Consuta_Adquisicion.Text = "- Seleccione -" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una Fecha de Adquisición"
                    Exit Sub
                End If
                ObjInventario.Fc_ruta = Txt_Consuta_Adquisicion.Text
            End If
            Session("Session2") = ObjInventario.Consulta_Inventario_Filtros
            dtgConsultaMonitores.DataSource = Session("Session2")
            dtgConsultaMonitores.DataBind()
            lblcantidad.Text = ObjInventario.Cantidad
            If lblcantidad.Text = 0 Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros"
            Else
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Busqueda exitosa"
            End If

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error " + ex.Message
        End Try
    End Sub



    Protected Sub drlEmpresaPantalla_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlEmpresaMonitor.SelectedIndexChanged
        If drlEmpresaMonitor.Text = "Otro" Then
            TxtEmpresaMonitor.Enabled = True
        Else
            TxtEmpresaMonitor.Enabled = False
            TxtEmpresaMonitor.Text = ""
        End If

        If drlEmpresaMonitor.Text <> "KAMILION" Then
            TxtSerialKamilionMonitor.Text = ""
            TxtSerialKamilionMonitor.Enabled = False
        Else
            TxtSerialKamilionMonitor.Enabled = True
        End If
    End Sub

    Protected Sub drlEmpresaTeclado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlEmpresaTeclado.SelectedIndexChanged
        If drlEmpresaTeclado.Text = "Otro" Then
            TxtEmpresaTeclado.Enabled = True
        Else
            TxtEmpresaTeclado.Enabled = False
            TxtEmpresaTeclado.Text = ""
        End If

        If drlEmpresaTeclado.Text <> "KAMILION" Then
            TxtSerialKamilionTeclado.Text = ""
            TxtSerialKamilionTeclado.Enabled = False
        Else
            TxtSerialKamilionTeclado.Enabled = True
        End If
    End Sub

    Protected Sub drlEmpresaMouse_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlEmpresaMouse.SelectedIndexChanged
        If drlEmpresaMouse.Text = "Otro" Then
            TxtEmpresaMouse.Enabled = True
        Else
            TxtEmpresaMouse.Enabled = False
            TxtEmpresaMouse.Text = ""
        End If

        If drlEmpresaMouse.Text <> "KAMILION" Then
            TxtSerialKamilionMouse.Text = ""
            TxtSerialKamilionMouse.Enabled = False
        Else
            TxtSerialKamilionMouse.Enabled = True
        End If
    End Sub

    Protected Sub drlEmpresaTorre_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlEmpresaTorre.SelectedIndexChanged
        If drlEmpresaTorre.Text = "Otro" Then
            TxtEmpresaTorre.Enabled = True
        Else
            TxtEmpresaTorre.Enabled = False
            TxtEmpresaTorre.Text = ""
        End If

        If drlEmpresaTorre.Text <> "KAMILION" Then
            TxtSerialKamilionTorre.Text = ""
            TxtSerialKamilionTorre.Enabled = False
        Else
            TxtSerialKamilionTorre.Enabled = True
        End If
    End Sub

    Protected Sub BtnConsultaInventario_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultaInventario.Click
        Try
            If RdbtnModulo.Checked = False And RdbtnMarca.Checked = False And RdbtnModelo.Checked = False And RdbtnSerial.Checked = False And RdbtnSerialKamilion.Checked = False And RdbtnEmpresa.Checked = False And RdbtnFc_Adquisicion.Checked = False Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Seleccione alguna opcion  de consulta"
            Else
                Consulta_Filtros()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error " + ex.Message
        End Try
    End Sub


    Protected Sub drlMarcaDisposivito_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlMarcaDisposivito.SelectedIndexChanged
        If drlMarcaDisposivito.Text = "Otro" Then
            TxtMarcaDispositivo.Enabled = True
        Else
            TxtMarcaDispositivo.Enabled = False
            TxtMarcaDispositivo.Text = ""
        End If
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
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error " + ex.Message
        End Try
    End Sub

    Protected Sub BtnGuardarDispositivo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGuardarDispositivo.Click
        Try
            If drlDispositivo.Text = 5 Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Seleccione un Dispositivo para ingresar"
                Exit Sub
            End If
            If drlModuloDispositivo.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un modulo para el Dispositivo"
                Exit Sub
            End If

            Dim Registro As Integer
            Dim dts As New DataSet
            Dim x As String
            ObjInventario.ID_Modulo = drlModuloDispositivo.SelectedItem.Text
            ObjInventario.Validacion_Modulo()
            x = ObjInventario.ID_Modulo
            If drlModuloDispositivo.SelectedItem.Text <> "BODEGA" Then
                ObjInventario.ID_Modulo = drlModuloDispositivo.Text
                ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivo.Text
                dts = ObjInventario.Validacion_Modulo_Un_Registro
                Registro = dts.Tables(0).Rows.Count
                If x <> "RAC" Then
                    If Registro >= 1 Then
                        Pnl_Message.CssClass = "alert alert-info"
                        lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> ya exite un Dispositivo registrada en el modulo " + drlModuloDispositivo.Text
                        Exit Sub
                    End If
                End If
            End If

            If drlMarcaDisposivito.Text = "1" Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span Class='glyphicon glyphicon-info-sign'></span> Seleccione la marca del Dispositivo"
                Exit Sub
            End If
            If TxtMarcaDispositivo.Enabled = True And TxtMarcaDispositivo.Text = "" Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Ingrese la marca del Dispositivo"
                Exit Sub
            End If
            If drlEmpresaDispositivo.Text = "1" Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Seleccione la empresa del Dispositivo"
                Exit Sub
            End If
            If TxtEmpresaDispositivo.Enabled = True And TxtEmpresaDispositivo.Text = "" Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Ingrese la empresa del Dispositivo"
                Exit Sub
            End If
            If TxtSerialKamilionDispositivo.Enabled = False And TxtSerialDispositivo.Text = "" Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Ingrese el serial del Dispositivo"
                Exit Sub
            End If
            If TxtSerialKamilionDispositivo.Enabled = True And TxtSerialKamilionDispositivo.Text = "" Then
                Pnl_Message.CssClass = "alert alert-info"
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> <span class='glyphicon glyphicon-info-sign'></span> Ingrese un serial Kamilion para el Dispositivo"
                Exit Sub
            End If

            If TxtMarcaDispositivo.Enabled = True Then
                ObjInventario.Marca = TxtMarcaDispositivo.Text
            Else
                ObjInventario.Marca = drlMarcaDisposivito.Text()
            End If
            If TxtModeloDispositivo.Text = "" Then
                ObjInventario.Modelo = ""
            Else
                ObjInventario.Modelo = TxtModeloDispositivo.Text
            End If
            If TxtSerialDispositivo.Text = "" Then
                ObjInventario.Serial = ""
            Else
                ObjInventario.Serial = TxtSerialDispositivo.Text
            End If
            If TxtEmpresaDispositivo.Enabled = True Then
                ObjInventario.Empresa = TxtEmpresaDispositivo.Text
            Else
                ObjInventario.Empresa = drlEmpresaDispositivo.Text
            End If
            If TxtSerialKamilionDispositivo.Text = "" Then
                ObjInventario.Serial_Kamilion = ""
            Else
                ObjInventario.Serial_Kamilion = TxtSerialKamilionDispositivo.Text
            End If

            If TxtSerialDispositivo.Text <> "" Or TxtSerialDispositivo.Text <> Nothing Then
                dts = ObjInventario.Consulta_Validacion_Serial
                Registro = dts.Tables(0).Rows.Count
                If Registro >= 1 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> ya exite un Dispositivo registrado con este Serial: " + TxtSerialDispositivo.Text
                    Exit Sub
                End If
            End If

            If TxtSerialKamilionDispositivo.Text <> "" Or TxtSerialKamilionDispositivo.Text <> Nothing Then
                dts = ObjInventario.Consulta_Validacion_Serial_Kamilion
                Registro = dts.Tables(0).Rows.Count
                If Registro >= 1 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> ya exite un Dispositivo registrado con este Serial Kamilion: " + TxtSerialKamilionDispositivo.Text
                    Exit Sub
                End If
            End If

            ObjInventario.Fk_ID_Modulo = drlModuloDispositivo.Text
            ObjInventario.FK_Cod_Invent_Dispositivo = drlDispositivo.Text
            ObjInventario.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            If txt_Fc_Adq_Dispositivo.Text <> Nothing Then
                ObjInventario.Fc_ruta = txt_Fc_Adq_Dispositivo.Text
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>  Ingrese la fecha de adquisición de la Torre"
                Exit Sub
            End If
            ObjInventario.Estado = "Activo"

            ObjInventario.Ingresar_Inventario()

            drlMarcaDisposivito.Text = "1"
            TxtMarcaDispositivo.Text = ""
            TxtMarcaDispositivo.Enabled = False
            TxtModeloDispositivo.Text = ""
            TxtSerialDispositivo.Text = ""
            TxtSerialKamilionDispositivo.Text = ""
            drlEmpresaDispositivo.Text = "1"
            TxtEmpresaDispositivo.Text = ""
            TxtEmpresaDispositivo.Enabled = False
            Dispositivodrl = True
            Cargardrl()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Dispositivo ingresado"
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>  Se presento falla: " + ex.Message
        End Try
    End Sub
    Protected Sub drlEmpresaConsulta_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlEmpresaConsulta.SelectedIndexChanged
        If drlEmpresaConsulta.Text = "Otro" Then
            TxtEmpresaConsulta.Enabled = True
        Else
            TxtEmpresaConsulta.Enabled = False
            TxtEmpresaConsulta.Text = ""
        End If
    End Sub

    'Protected Sub ChecBoxMas_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ChecBoxMas.CheckedChanged
    '    If ChecBoxMas.Checked = True Then
    '        Panel_Mas.Visible = True
    '        ChecBoxMas.Text = "Menos↑"
    '    Else
    '        Panel_Mas.Visible = False
    '        ChecBoxMas.Text = "Mas↓"
    '    End If
    'End Sub
    Protected Sub dtgConsultaMonitores_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgConsultaMonitores.PageIndexChanging
        Try
            Consulta_Filtros()
            dtgConsultaMonitores.PageIndex = e.NewPageIndex
            dtgConsultaMonitores.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " + ex.Message
        End Try
    End Sub





End Class