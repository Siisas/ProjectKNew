Imports System.IO
Public Class procescala
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Exp") = False
                Session("Formulario") = "Escalamiento Tecnica"
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                Dim objdatosv As New clsvoz
                With DrlGrupo_Asignado
                    .DataSource = objdatosv.ConsultaGrupo_Asignado()
                    .DataTextField = "Nombre"
                    .DataValueField = "Cod_BD_Voz_Complemento"
                    .DataBind()
                End With
                casosptes()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Protected Sub casosptes()
        Try
            Dim objdatos As New clsvoz
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            Session("dtggeneral.procescala") = objdatos.consultaasigxusu
            dtggeneral.DataSource = Session("dtggeneral.procescala")
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clsvoz
        Try
            If txtcaso.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            If txtcpd.Text = "" And chkdev.Checked = False Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> Elija si el caso se escala o se devuelve"
                Exit Sub
            Else
                If chkdev.Checked = False Then
                    objdatos.cpd = txtcpd.Text
                    objdatos.devolver = "0"
                    objdatos.Estado_Llamada = "Escalado"
                Else
                    objdatos.cpd = " "
                    objdatos.devolver = "1"
                    objdatos.Estado_Llamada = "Devuelto"
                End If
            End If
            If txtobs.Text = "" And chkdev.Checked = True Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> Si desea devolver la falla deberá registrar la observación de devolución"
                Exit Sub
            Else
                If chkdev.Checked = False Then
                    objdatos.obs = ""
                Else
                    objdatos.obs = txtobs.Text
                End If
            End If
            If DrlGrupo_Asignado.SelectedItem.Text = "- Seleccione -" And chkdev.Checked = False Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> Por favor seleccione un Grupo Asignado!!"
                Exit Sub
            Else
                If DrlGrupo_Asignado.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Grupo_Asignado = ""
                Else
                    objdatos.Grupo_Asignado = DrlGrupo_Asignado.SelectedItem.Text
                End If
            End If
            objdatos.actualizacpd()
            Dim objDts As New clscrmdatos
            If objdatos.devolver = "0" Then
                If LblValidacion.Text = "Fidelizacion" Then
                    objdatos.caso = txtcaso.Text
                    objdatos.tipificacion = "Escalado"
                    objdatos.modificarbandejafallaFideliza() 'Fidelizacion
                Else
                    If LblCanal.Text <> " " Then ' DIlo
                        objdatos.caso = txtcaso.Text
                        objdatos.tipificacion = "Escalado"
                        objdatos.modificarbandejafallaDilo()
                    ElseIf lblcampana.Text = "Datos" Or lblcampana.Text = "BSCS" Then ' DAtos
                        objDts.caso = txtcaso.Text
                        objDts.tipificacion = "Escalado"
                        objDts.Actualiza_Estado_Bandeja_Datos()
                    ElseIf lblcampana.Text = "INBOUND" Then ' DAtos
                        objdatos.Validacion = "INBOUND"
                        objdatos.Nombre = "Escalado"
                        objdatos.Modificar_Bandejas_Estado_Escalado()
                    Else ' VOZ
                        objdatos.caso = txtcaso.Text
                        objdatos.tipificacion = "Escalado"
                        objdatos.Actualiza_Estado_Bandeja_Voz()
                    End If
                End If
            Else
                If LblValidacion.Text = "Fidelizacion" Then
                    objdatos.caso = txtcaso.Text
                    objdatos.tipificacion = "No Contactado"
                    objdatos.modificarbandejafallaFideliza() 'Fidelizacion
                Else
                    If LblCanal.Text <> " " Then ' DIlo
                        objdatos.caso = txtcaso.Text
                        objdatos.tipificacion = "No Contactado"
                        objdatos.modificarbandejafallaDilo()
                    ElseIf lblcampana.Text = "Datos" Or lblcampana.Text = "BSCS" Then ' DAtos
                        objDts.caso = txtcaso.Text
                        objDts.tipificacion = "No Contactado"
                        objDts.Actualiza_Estado_Bandeja_Datos()
                    ElseIf lblcampana.Text = "INBOUND" Then ' DAtos
                        objdatos.Validacion = "INBOUND"
                        objdatos.Nombre = "No Contactado"
                        objdatos.Modificar_Bandejas_Estado_Escalado()
                    Else ' VOZ
                        objdatos.caso = txtcaso.Text
                        objdatos.tipificacion = "No Contactado"
                        objdatos.Actualiza_Estado_Bandeja_Voz()
                    End If
                End If
            End If
            guardacrm()
            casosptes()
            Limpiar()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<strong><span class='glyphicon glyphicon-ok-circle'></span></strong> Registro ingresado con éxito"
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Protected Sub guardacrm()
        Dim objvoz As New clsvoz
        Dim objdatos As New clscrmdatos
        Try
            objvoz.caso = txtcaso.Text
            objdatos.caso = txtcaso.Text
            If txtobs.Text = "" Then
                objvoz.obs = ""
                objdatos.obs = ""
            Else
                objvoz.obs = txtobs.Text
                objdatos.obs = txtobs.Text
            End If
            If chkdev.Checked = True Then
                objvoz.tipificacion = "Devuelto"
                objdatos.tipificacion = "Devuelto"
            Else
                objvoz.tipificacion = "Reportado"
                objdatos.tipificacion = "Reportado"
            End If
            objvoz.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            If LblValidacion.Text = "Fidelizacion" Then
                Dim Obj_Fideliza As New clscrmdatos
                Obj_Fideliza.caso = txtcaso.Text
                Obj_Fideliza.Validacion = "Fidelizacion"
                If Obj_Fideliza.Validacion_Registro_Inboun.Tables(0).Rows.Count > 0 Then
                    objvoz.caso = Obj_Fideliza.min
                End If
                objvoz.RegistroCrm_FallaRed_Fidelizacion()
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<strong><span class='glyphicon glyphicon-ok-circle'></span></strong> Seguimiento ingresado con éxito"
                Exit Sub
                '----CRMDIlo----'
            ElseIf LblCanal.Text <> " " Then
                objvoz.registrocrmfallareddilo()
                Exit Sub
            End If
            If lblcampana.Text = "Datos" Or lblcampana.Text = "BSCS" Then
                objvoz.registrocrmfallareddatos()
            ElseIf lblcampana.Text = "INBOUND" Then
                objdatos.preg2 = "Tecnica"
                objdatos.registro_CRM_inbound_escalamiento()
            Else
                objvoz.registrocrmfallared()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Sub buscarinf()
        Try
            Dim objdatos As New clsvoz
            If txtcaso.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<strong><span Class='glyphicon glyphicon-warning-sign'></span></strong> Digite el Caso que desea consultar"
                Session("Exp") = False
                Lbl_Inf.Visible = False
                Lbl_Inf.Text = ""
            Else
                objdatos.caso = txtcaso.Text
                objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                objdatos.consultacasoescalado()
                If objdatos.cantidad > 0 Then
                    Session("Exp") = True
                    Lbl_N_Doc_Id.Text = objdatos.N_Doc_Id
                    lblcaso.Text = objdatos.caso
                    lblcliente.Text = objdatos.cliente
                    lbltelcontacto.Text = objdatos.telcontacto
                    lbltiempo.Text = objdatos.tiempo
                    lbltipof.Text = objdatos.tipofalla
                    lblcaract.Text = objdatos.caracter
                    lblportada.Text = objdatos.portada
                    lbldpto.Text = objdatos.dpto
                    lblmun.Text = objdatos.mun
                    lblvereda.Text = objdatos.vereda
                    lbldir.Text = objdatos.dir
                    lblbarrio.Text = objdatos.barrio
                    lbltecnologia.Text = objdatos.tecnologia
                    lblequipo.Text = objdatos.equipo
                    lblmaslineas.Text = objdatos.maslineas
                    lblobs.Text = objdatos.obs
                    lblcampana.Text = objdatos.campana
                    lblapn.Text = objdatos.apn
                    lblqos.Text = objdatos.qos
                    ''''Validaciones servicio al cliente
                    Lbl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania.Text = objdatos.Falla_Presenta_Luego_Construyera_Edificacion_Aledania
                    Lbl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio.Text = objdatos.Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio
                    Lbl_Tipo_Edificacion_Donde_Presenta_Falla.Text = objdatos.Tipo_Edificacion_Donde_Presenta_Falla
                    Lbl_Validaciones_Falla_Masiva.Text = objdatos.Validaciones_Falla_Masiva
                    Lbl_Tecnologia_Presenta_Falla_Luegodepruebas.Text = objdatos.Tecnologia_Presenta_Falla_Luegodepruebas
                    Lbl_Validacion_Coordenadas.Text = objdatos.Validacion_Coordenadas
                    Lbl_Linea_No_Cuenta_Bloqueos_Internet.Text = objdatos.Linea_No_Cuenta_Bloqueos_Internet
                    Lbl_Linea_No_Superado_Limite_Consumos.Text = objdatos.Linea_No_Superado_Limite_Consumos
                    Lbl_Linea_No_Encuentra_Enrutada_PorPagos.Text = objdatos.Linea_No_Encuentra_Enrutada_PorPagos
                    Lbl_HLR_HSS.Text = objdatos.HLR_HSS
                    Lbl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.Text = objdatos.No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra
                    Lbl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla.Text = objdatos.Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla
                    Lbl_Forza_Red_Dispositivo.Text = objdatos.Forza_Red_Dispositivo
                    Lbl_Verifica_Realiza_Configuración_APN.Text = objdatos.Verifica_Realiza_Configuración_APN
                    Lbl_Equipo_Encuentra_Homologado_Operador.Text = objdatos.Equipo_Encuentra_Homologado_Operador
                    Lbl_Realiza_Conciliacion_Sobre_linea.Text = objdatos.Realiza_Conciliacion_Sobre_linea
                    Pnl_Message.CssClass = Nothing
                    lblmsg.Text = Nothing
                    txtcpd.Text = ""
                    txtobs.Text = ""
                    LblCanal.Text = objdatos.CanalDilo
                    objdatos.Consulta_VFallared_Bandeja_Fideliza()
                    LblCall_Remite.Text = objdatos.lugar
                    If LblCall_Remite.Text <> "" And objdatos.cantidad > 0 Then
                        LblValidacion.Text = "Fidelizacion"
                        lblmin.Text = objdatos.min
                    Else
                        LblValidacion.Text = Nothing
                    End If
                    Lbl_Inf.Visible = True
                    Lbl_Inf.Text = "Va a exportar el  archivo VALIDACIONES_SAC_MIN" & lblmin.Text & "_CASO" & txtcaso.Text & ".xls en la carpeta Descargas por defecto"
                Else
                    Limpiar()
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> El caso no existe o no se encuentra asignado a su usuario o ya fue reportado el CPD, verifique"
                    Exit Sub
                End If
                If (LblCanal.Text <> "" Or LblCanal.Text <> " ") And LblCall_Remite.Text = "" And LblValidacion.Text = Nothing Then
                    objdatos.consultacasodilo()
                    If objdatos.cantidad > 0 Then
                        lblmin.Text = objdatos.min
                        Dim objdatosv As New clsvoz
                        With DrlGrupo_Asignado
                            objdatosv.Validacion = "Dilo"
                            .DataSource = objdatosv.ConsultaGrupo_Asignado()
                            .DataTextField = "Nombre"
                            .DataValueField = "Cod_BD_Voz_Complemento"
                            .DataBind()
                        End With
                    Else
                        lblmin.Text = ""
                        Dim objdatosv As New clsvoz
                        With DrlGrupo_Asignado
                            .DataSource = objdatosv.ConsultaGrupo_Asignado()
                            .DataTextField = "Nombre"
                            .DataValueField = "Cod_BD_Voz_Complemento"
                            .DataBind()
                        End With
                    End If
                End If


                If lblcampana.Text = "Datos" And (LblCanal.Text = "" Or LblCanal.Text = " ") Then
                    Dim objdatosd As New clscrmdatos
                    objdatosd.caso = lblcaso.Text
                    objdatosd.consultacaso()
                    If objdatosd.cantidad > 0 Then
                        lblmin.Text = objdatosd.min
                    Else
                        lblmin.Text = ""
                    End If
                End If
                If lblcampana.Text = "INBOUND" Then
                    Dim objvoz As New clsvoz
                    objvoz.caso = lblcaso.Text
                    objvoz.Consultacaso_Inb()
                    If objvoz.cantidad > 0 Then
                        lblmin.Text = objvoz.min
                    Else
                        lblmin.Text = ""
                    End If
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Public Sub Limpiar()
        Session("Exp") = False
        Lbl_N_Doc_Id.Text = Nothing
        lblcaso.Text = ""
        lblmin.Text = ""
        lblcliente.Text = ""
        lbltelcontacto.Text = ""
        lbltiempo.Text = ""
        lbltipof.Text = ""
        lblcaract.Text = ""
        lblportada.Text = ""
        lbldpto.Text = ""
        lblmun.Text = ""
        lblvereda.Text = ""
        lbldir.Text = ""
        lblbarrio.Text = ""
        lbltecnologia.Text = ""
        lblequipo.Text = ""
        lblmaslineas.Text = ""
        lblobs.Text = ""
        lblcampana.Text = ""
        lblapn.Text = ""
        lblqos.Text = ""
        txtcpd.Text = ""
        txtobs.Text = ""
        txtcaso.Text = ""
        chkdev.Checked = False
        DrlGrupo_Asignado.SelectedIndex = 0
        ''''Validaciones servicio al cliente
        Lbl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania.Text = ""
        Lbl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio.Text = ""
        Lbl_Tipo_Edificacion_Donde_Presenta_Falla.Text = ""
        Lbl_Validaciones_Falla_Masiva.Text = ""
        Lbl_Tecnologia_Presenta_Falla_Luegodepruebas.Text = ""
        Lbl_Validacion_Coordenadas.Text = ""
        Lbl_Linea_No_Cuenta_Bloqueos_Internet.Text = ""
        Lbl_Linea_No_Superado_Limite_Consumos.Text = ""
        Lbl_Linea_No_Encuentra_Enrutada_PorPagos.Text = ""
        Lbl_HLR_HSS.Text = ""
        Lbl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.Text = ""
        Lbl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla.Text = ""
        Lbl_Forza_Red_Dispositivo.Text = ""
        Lbl_Verifica_Realiza_Configuración_APN.Text = ""
        Lbl_Equipo_Encuentra_Homologado_Operador.Text = ""
        Lbl_Realiza_Conciliacion_Sobre_linea.Text = ""
        LblCanal.Text = ""
        LblCall_Remite.Text = ""
        Lbl_Inf.Visible = False
        Lbl_Inf.Text = ""
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            buscarinf()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Exportar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Exportar.Click
        exportar()
    End Sub
    Public Sub exportar()
        Try
            Lbl_Inf.Visible = True
            If Session("Exp") = True Then
                Dim sw As New StringWriter()
                Dim hw As New HtmlTextWriter(sw)
                Dim data As New GridView
                Dim datatable As New DataTable
                Dim tabla As New Table()
                Dim tr1 As New TableRow()
                Dim cell1 As New TableCell()
                Dim Val As Boolean = False
                Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"
                Dim cont As Integer
                Dim i As Integer
                Dim ItemList As New ArrayList()
                Dim ItemList1 As New ArrayList

                ItemList.Add("Min")
                ItemList.Add("Caso")
                ItemList.Add("La falla se presenta luego de que se construyera una edificación aledaña")
                ItemList.Add("La falla se presenta luego de que se remodelara la estructura física del edificio")
                ItemList.Add("Tipo de edificación donde se presenta la falla")
                ItemList.Add("Validaciones de falla masiva")
                ItemList.Add("Tecnología en la que se presenta la falla - Luego de pruebas")
                ItemList.Add("Validación de Coordenadas")
                ItemList.Add("Línea no cuenta con bloqueos de Internet")
                ItemList.Add("Línea no ha superado el limite de consumos")
                ItemList.Add("Línea Portada")
                ItemList.Add("Línea no se encuentra enrutada por pagos")
                ItemList.Add("QoS")
                ItemList.Add("HLR / HSS")
                ItemList.Add("No existen cambios administrativos sobre la línea o cuenta maestra")
                ItemList.Add("Se realizan pruebas de SIMCARD en otro dispositivo (Persiste Falla")
                ItemList.Add("Se forza la red del dispositivo")
                ItemList.Add("Se verifica o realiza configuración de APN")
                ItemList.Add("Equipo se encuentra homologado por el operador")
                ItemList.Add("Se realiza conciliación sobre la línea")

                ItemList1.Add(lblmin.Text)
                ItemList1.Add(lblcaso.Text)
                ItemList1.Add(Lbl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania.Text)
                ItemList1.Add(Lbl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio.Text)
                ItemList1.Add(Lbl_Tipo_Edificacion_Donde_Presenta_Falla.Text)
                ItemList1.Add(Lbl_Validaciones_Falla_Masiva.Text)
                ItemList1.Add(Lbl_Tecnologia_Presenta_Falla_Luegodepruebas.Text)
                ItemList1.Add(Lbl_Validacion_Coordenadas.Text)
                ItemList1.Add(Lbl_Linea_No_Encuentra_Enrutada_PorPagos.Text)
                ItemList1.Add(Lbl_Linea_No_Cuenta_Bloqueos_Internet.Text)
                ItemList1.Add(lblportada.Text)
                ItemList1.Add(Lbl_Linea_No_Superado_Limite_Consumos.Text)
                ItemList1.Add(lblqos.Text)
                ItemList1.Add(Lbl_HLR_HSS.Text)
                ItemList1.Add(Lbl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.Text)
                ItemList1.Add(Lbl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla.Text)
                ItemList1.Add(Lbl_Forza_Red_Dispositivo.Text)
                ItemList1.Add(Lbl_Verifica_Realiza_Configuración_APN.Text)
                ItemList1.Add(Lbl_Equipo_Encuentra_Homologado_Operador.Text)
                ItemList1.Add(Lbl_Realiza_Conciliacion_Sobre_linea.Text)
                cont = 1

                For i = 0 To ItemList.Count - 1
                    If cont = 1 Then
                        datatable.Columns.Add("VALIDACION SAC", GetType(String))
                        datatable.Columns.Add("  ", GetType(String))
                        cont = 2
                    End If
                    datatable.Rows.Add(ItemList.Item(i), ItemList1.Item(i))
                Next

                data.DataSource = datatable
                data.DataBind()
                If data.Rows.Count > 0 And data.Rows.Count < 8101 Then
                    Val = True
                    data.DataSource = datatable
                    data.DataBind()
                    cell1.Controls.Add(data)
                    tr1.Cells.Add(cell1)
                    tabla.Rows.Add(tr1)
                    tabla.RenderControl(hw)
                ElseIf data.Rows.Count > 8100 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Se denego el permiso de exportacion debido a que exede el limite de registros; Realice otro filtro y reintente exportar! "
                Else
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span Class='glyphicon glyphicon-warning-sign'></span> ¡No se encontraron registros para realizar la exportacion! "
                End If
                If Val = True Then
                    Session("Exp") = False
                    Response.Clear()
                    Response.Buffer = True
                    Response.AddHeader("Content-Disposition", "attachment;filename=VALIDACIONES_SAC_MIN" & lblmin.Text & "_CASO" & txtcaso.Text & ".xls")
                    Response.Charset = "UTF-8"
                    Response.ContentType = "application/vnd.ms-excel"
                    Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                    Response.Write(style)
                    Response.Output.Write(sw.ToString())
                    Response.End()
                End If
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span Class='glyphicon glyphicon-warning-sign'></span> ¡Busque Un caso antes de exportarlo! "
                Lbl_Inf.Visible = False
                Lbl_Inf.Text = ""
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-warning"
            lblmsg.Text = "Se a exportado el siguiente archivo 'VALIDACIONES_SAC_MIN" & lblmin.Text & "_CASO" & txtcaso.Text & " .xls'"
        End Try
    End Sub
    Private Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex
            dtggeneral.DataSource = Session("dtggeneral.procescala")
            dtggeneral.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

End Class