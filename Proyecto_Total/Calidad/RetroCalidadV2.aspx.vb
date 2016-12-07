Imports System.IO

Public Class RetroCalidadV2
    Inherits System.Web.UI.Page
    Dim resultado As Decimal
    Dim ObjRetroCal As New Clsretroalimentacion
    Dim ObjValidacion As New Cls_Gestion_Datos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("permisos") Is Nothing Then
            Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
        End If
        Pnl_Message.CssClass = Nothing
        lblmsg.Text = Nothing

        Try
            CalcularResultado()
            If Not IsPostBack Then
                ObjRetroCal.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
                ObjRetroCal.Validacion = "Versiones_Retro"
                With Drl_Version
                    .DataSource = ObjRetroCal.ObtenerParametros
                    .DataTextField = "Nombre"
                    .DataValueField = "Nombre"
                    .DataBind()
                End With
                ObjRetroCal.Validacion = ""
                ObjRetroCal.Validacion_Version = "V4"
                Cargardrls()
            End If
        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub

    'Calcular resulltado
    Public Sub CalcularResultado()
        If RadioBtn1.SelectedValue <> "" And RadioBtn2.SelectedValue <> "" And RadioBtn3.SelectedValue <> "" And RadioBtn4.SelectedValue <> "" And RadioBtn5.SelectedValue <> "" Then
            resultado = (Decimal.Parse(RadioBtn1.SelectedValue) * 0.15) + (Decimal.Parse(RadioBtn2.SelectedValue) * 0.15) +
                (Decimal.Parse(RadioBtn3.SelectedValue) * 0.25) + (Decimal.Parse(RadioBtn4.SelectedValue) * 0.2) + (Decimal.Parse(RadioBtn5.SelectedValue) * 0.25)
        End If
        If resultado >= 7 Then
            txtresultado.Text = "Retro Aceptada"
        ElseIf resultado < 7 And resultado >= 4.5 Then
            txtresultado.Text = "Se requiere Refuerzo"
        ElseIf resultado < 4.5 And resultado > 0 Then
            txtresultado.Text = "Rechazada"
        Else
            txtresultado.Text = ""
        End If
    End Sub
    'CARGAR DRL
    Public Sub Cargardrls()
        Try
            With drlParametro
                .DataSource = ObjRetroCal.ObtenerParametros
                .DataTextField = "Nombre"
                .DataValueField = "Cod_Calidad_Registro_Complemento"
                .DataBind()
            End With

            With drlParametro0
                .DataSource = ObjRetroCal.ObtenerParametros
                .DataTextField = "Nombre"
                .DataValueField = "Cod_Calidad_Registro_Complemento"
                .DataBind()
            End With

            With drlParametro1
                .DataSource = ObjRetroCal.ObtenerParametros
                .DataTextField = "Nombre"
                .DataValueField = "Cod_Calidad_Registro_Complemento"
                .DataBind()
            End With

            With drlParametro2
                .DataSource = ObjRetroCal.ObtenerParametros
                .DataTextField = "Nombre"
                .DataValueField = "Cod_Calidad_Registro_Complemento"
                .DataBind()
            End With

            With drlParametro3
                .DataSource = ObjRetroCal.ObtenerParametros
                .DataTextField = "Nombre"
                .DataValueField = "Cod_Calidad_Registro_Complemento"
                .DataBind()
            End With

            With drltipo_retro
                ObjRetroCal.Validacion = "Tipo_retro"
                .DataSource = ObjRetroCal.Consulta_Retro_Complemento
                .DataTextField = "Tipo_retro"
                .DataValueField = "Tipo_retro"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
            End With


        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'DRL VERSION
    Protected Sub Drl_Version_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Drl_Version.SelectedIndexChanged
        Try
            If Drl_Version.SelectedValue = "V2" Then
                Lbl_Version.Text = "1"
            ElseIf Drl_Version.SelectedValue = "V3" Or Drl_Version.SelectedValue = "V4" Then
                Lbl_Version.Text = "1.1"
            End If
            ObjRetroCal.Validacion_Version = Drl_Version.SelectedValue
            Cargardrls()
        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub
    'LIMPIAR HERRAMIENTAS
    Public Sub CamposBlancos()
        Try
            Dim tx As TextBox
            Dim drl As DropDownList
            Dim btn As RadioButtonList
            Dim lbl As Label
            Dim pnl As Panel
            For Each control In Panel_registro2.Controls
                If TypeOf control Is TextBox Then
                    tx = control
                    tx.Text = Nothing
                End If
                If TypeOf control Is DropDownList Then
                    drl = control
                    drl.SelectedIndex = 0
                End If
                If TypeOf control Is RadioButtonList Then
                    btn = control
                    btn.ClearSelection()
                End If
                If TypeOf control Is Label Then
                    lbl = control
                    lbl.Text = Nothing
                End If
                If TypeOf control Is Panel Then
                    pnl = control
                    LimpiarTabla(pnl)
                End If
            Next
            If Drl_Version.SelectedValue = "V2" Then
                Lbl_Version.Text = "1"
            ElseIf Drl_Version.SelectedValue = "V3" Or Drl_Version.SelectedValue = "V4" Then
                Lbl_Version.Text = "1.1"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub LimpiarTabla(panel As Panel)
        Try
            Dim tx As TextBox
            Dim drl As DropDownList
            Dim btn As RadioButtonList
            Dim lbl As Label
            For Each control In panel.Controls
                If TypeOf control Is TextBox Then
                    tx = control
                    tx.Text = Nothing
                End If
                If TypeOf control Is DropDownList Then
                    drl = control
                    drl.SelectedIndex = 0
                End If
                If TypeOf control Is RadioButtonList Then
                    btn = control
                    btn.ClearSelection()
                End If
                If TypeOf control Is Label Then
                    lbl = control
                    lbl.Text = Nothing
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            ObjValidacion.Validar_Herramientas(txtcodbus, "codigo retroalimentacion")
            'Valida Version
            ObjRetroCal.Validacion = "2"
            ObjRetroCal.Cod_Retroalimentacion = txtcodbus.Text
            ObjRetroCal.Llenar_CamposV2()
            'Busca Info
            ObjRetroCal.Validacion = "1"
            ObjRetroCal.Validacion_Version = ObjRetroCal.Validacion_Version
            ObjRetroCal.Cod_Retroalimentacion = txtcodbus.Text
            ObjRetroCal.Llenar_CamposV2()
            If ObjRetroCal.Id_Auditoria = 0 Then
                mostrar_Mensaje("No se encontraron registros con el codigo " + CStr(ObjRetroCal.Cod_Retroalimentacion), 2)
                Panel1.Visible = False
                Exit Sub
            Else
                Panel1.Visible = True
                PanelConsulta.Visible = False
                PanelGeneral.Visible = False

                lblidaud.Text = ObjRetroCal.Id_Auditoria
                Lblfcretro.Text = ObjRetroCal.Fc_Retro
                Lblfcaud.Text = ObjRetroCal.Fc_Reg_CR
                LblNomAgte.Text = ObjRetroCal.Agente
                LblNomaud.Text = ObjRetroCal.Auditor
                LblCampa.Text = ObjRetroCal.Campania
                LblArea.Text = ObjRetroCal.Area
                LblFc_Hora_llam.Text = ObjRetroCal.Fc_Llamada
                LblCaso.Text = ObjRetroCal.Id_Caso
                LblEstado_Caso.Text = ObjRetroCal.Estado_Caso
                LblCalificacion.Text = ObjRetroCal.Calificacion
                LblSeguimiento.Text = ObjRetroCal.Seguimiento
                LblTipoRetro.Text = ObjRetroCal.Tipo_Retro
                Lbltiemporetroalimentacion.Text = ObjRetroCal.Tiempo_Retroalimentacion
                Lbl_Version_Retro.Text = "Version " & ObjRetroCal.Todo
                If ObjRetroCal.Todo = "V2" Then
                    Lbl_Version.Text = "1"
                ElseIf ObjRetroCal.Todo = "V3" Or ObjRetroCal.Todo = "V4" Then
                    Lbl_Version.Text = "1.1"
                End If

                LblCompromiso.Text = ObjRetroCal.Compromiso_Usu
                LblConclusionF.Text = ObjRetroCal.Conclusion
                LblObservacionP.Text = ObjRetroCal.ObservacionP
                Lblcodretro.Text = txtcodbus.Text


                txtidaud.Visible = False
                btnidaud.Visible = False
                TxtSgto.Visible = False
                TxtHora.Visible = False
                Drl_Version.Visible = False
                txtObservacionP.Visible = False
                txtCompromiso.Visible = False
                txtConclucionF.Visible = False

                If ObjRetroCal.Todo = "V2" Then
                    If CDec(LblCalificacion.Text) > 95 Then
                        LblTipoRetro.Text = "Positiva"
                    ElseIf CDec(LblCalificacion.Text) > 90 And CDec(LblCalificacion.Text) <= 95 Then
                        LblTipoRetro.Text = "Mejora"
                    ElseIf CDec(LblCalificacion.Text) > 80 And CDec(LblCalificacion.Text) <= 90 Then
                        LblTipoRetro.Text = "Seguimiento"
                    ElseIf CDec(LblCalificacion.Text) > 0 And CDec(LblCalificacion.Text) <= 80 Then
                        LblTipoRetro.Text = "Correctiva"
                    ElseIf CDec(LblCalificacion.Text) = 0 Then
                        LblTipoRetro.Text = "Error Critico"
                    End If
                End If
                If ObjRetroCal.Todo = "V3" Or ObjRetroCal.Todo = "V4" Then
                    If CDec(LblCalificacion.Text) > 95 Then
                        LblTipoRetro.Text = "Positiva"
                    ElseIf CDec(LblCalificacion.Text) > 90 And CDec(LblCalificacion.Text) <= 95 Then
                        LblTipoRetro.Text = "Mejora"
                    ElseIf CDec(LblCalificacion.Text) > 80 And CDec(LblCalificacion.Text) <= 90 Then
                        LblTipoRetro.Text = "Seguimiento"
                    ElseIf CDec(LblCalificacion.Text) > 50 And CDec(LblCalificacion.Text) <= 80 Then
                        LblTipoRetro.Text = "Correctiva"
                    ElseIf CDec(LblCalificacion.Text) > 0 And CDec(LblCalificacion.Text) <= 50 Then
                        LblTipoRetro.Text = "Error Critico"
                    End If
                End If

                'oculta herramientas
                For Each control In PnlParametros.Controls
                    If TypeOf control Is TextBox Then
                        control.visible = False
                    End If
                    If TypeOf control Is DropDownList Then
                        control.visible = False
                    End If
                Next
                For Each control In PnlItems.Controls
                    If TypeOf control Is RadioButtonList Then
                        control.visible = False
                    End If
                    If TypeOf control Is TextBox Then
                        control.visible = False
                    End If
                Next

                ObjRetroCal.Validacion = "3"
                ObjRetroCal.Cod_Retroalimentacion = txtcodbus.Text
                ObjRetroCal.Llenar_Campos()

                LblParametro.Text = ObjRetroCal.Parametro
                LblObservacion.Text = ObjRetroCal.Observacion
                LblParametro0.Text = ObjRetroCal.Parametro0
                LblObservacion0.Text = ObjRetroCal.Observacion0

                If ObjRetroCal.Parametro1 = "- Seleccione -" Then
                    LblParametro1.Text = ""
                Else
                    LblParametro1.Text = ObjRetroCal.Parametro1
                    LblObservacion1.Text = ObjRetroCal.Observacion1
                End If

                If ObjRetroCal.Parametro2 = "- Seleccione -" Then
                    LblParametro2.Text = ""
                Else
                    LblParametro2.Text = ObjRetroCal.Parametro2
                    LblObservacion2.Text = ObjRetroCal.Observacion2
                End If

                If ObjRetroCal.Parametro3 = "- Seleccione -" Then
                    LblParametro3.Text = ""
                Else
                    LblParametro3.Text = ObjRetroCal.Parametro3
                    LblObservacion3.Text = ObjRetroCal.Observacion3
                End If

                If ObjRetroCal.Resultado <> Nothing Or ObjRetroCal.Resultado <> 0 Then
                    '********ITEM_1***********
                    If ObjRetroCal.Item_1 = 10 Then
                        lblitem1.Text = "Excelente"
                    ElseIf ObjRetroCal.Item_1 = 3 Then
                        lblitem1.Text = "Regular"
                    ElseIf ObjRetroCal.Item_1 = 1 Then
                        lblitem1.Text = "Insuficiente"
                    Else
                        lblitem1.Text = ""
                    End If
                    '********ITEM_2***********
                    If ObjRetroCal.Item_2 = 10 Then
                        lblitem2.Text = "Excelente"
                    ElseIf ObjRetroCal.Item_2 = 3 Then
                        lblitem2.Text = "Regular"
                    ElseIf ObjRetroCal.Item_2 = 1 Then
                        lblitem2.Text = "Insuficiente"
                    Else
                        lblitem2.Text = ""
                    End If
                    '********ITEM_3***********
                    If ObjRetroCal.Item_3 = 10 Then
                        lblitem3.Text = "Excelente"
                    ElseIf ObjRetroCal.Item_3 = 3 Then
                        lblitem3.Text = "Regular"
                    ElseIf ObjRetroCal.Item_3 = 1 Then
                        lblitem3.Text = "Insuficiente"
                    Else
                        lblitem3.Text = ""
                    End If
                    '********ITEM_4***********
                    If ObjRetroCal.Item_4 = 10 Then
                        lblitem4.Text = "Excelente"
                    ElseIf ObjRetroCal.Item_4 = 3 Then
                        lblitem4.Text = "Regular"
                    ElseIf ObjRetroCal.Item_4 = 1 Then
                        lblitem4.Text = "Insuficiente"
                    Else
                        lblitem4.Text = ""
                    End If
                    '********ITEM_5***********
                    If ObjRetroCal.Item_5 = 10 Then
                        lblitem5.Text = "Si"
                    ElseIf ObjRetroCal.Item_5 = 3 Then
                        lblitem5.Text = "No"
                    Else
                        lblitem1.Text = ""
                    End If
                    '********RESULTADO********
                    If ObjRetroCal.Resultado >= 7 Then
                        lblresultado.Text = "Retro Aceptada"
                    ElseIf ObjRetroCal.Resultado < 7 And ObjRetroCal.Resultado >= 4.5 Then
                        lblresultado.Text = "Se requiere Refuerzo"
                    ElseIf ObjRetroCal.Resultado < 4.5 And ObjRetroCal.Resultado > 0 Then
                        lblresultado.Text = "Rechazada"
                    Else
                        lblresultado.Text = ""
                    End If
                Else
                    lblitem1.Text = ""
                    lblitem2.Text = ""
                    lblitem3.Text = ""
                    lblitem4.Text = ""
                    lblitem5.Text = ""
                End If
            End If
        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub
    'BTN buscar auditoria
    Protected Sub btnidaud_Click(sender As Object, e As EventArgs) Handles btnidaud.Click
        Try
            Dim dts As DataSet
            ObjValidacion.Validar_Herramientas(txtidaud, "Id Auditoria")
            ObjRetroCal.Validacion_Version = Drl_Version.SelectedValue
            ObjRetroCal.Id_Auditoria = txtidaud.Text

            If ObjRetroCal.ValidacionId().Tables(0).Rows.Count > 0 Then
                mostrar_Mensaje("Ya existe una retroalimentacion para esa auditoria con el Codigo Retroalimentacion " + CStr(ObjRetroCal.Cod_Retroalimentacion), 2)
            End If

            dts = ObjRetroCal.Buscar_ID()

            If dts.Tables(0).Rows.Count > 0 Then
                btnguardar.Visible = True
                lblidaud.Text = txtidaud.Text
                Lblfcaud.Text = ObjRetroCal.Fc_Audit
                LblCampa.Text = ObjRetroCal.Campania
                LblNomAgte.Text = ObjRetroCal.Agente
                LblArea.Text = ObjRetroCal.Area
                LblNomaud.Text = ObjRetroCal.Auditor
                LblFc_Hora_llam.Text = ObjRetroCal.Fc_Llamada
                LblCaso.Text = ObjRetroCal.Id_Caso
                LblEstado_Caso.Text = ObjRetroCal.Estado_Caso
                LblCalificacion.Text = ObjRetroCal.Calificacion
                If CDec(LblCalificacion.Text) > 95 Then
                    LblTipoRetro.Text = "Positiva"
                ElseIf CDec(LblCalificacion.Text) > 90 And CDec(LblCalificacion.Text) <= 95 Then
                    LblTipoRetro.Text = "Mejora"
                ElseIf CDec(LblCalificacion.Text) > 80 And CDec(LblCalificacion.Text) <= 90 Then
                    LblTipoRetro.Text = "Seguimiento"
                ElseIf CDec(LblCalificacion.Text) > 0 And CDec(LblCalificacion.Text) <= 80 Then
                    LblTipoRetro.Text = "Correctiva"
                ElseIf CDec(LblCalificacion.Text) = 0 Then
                    LblTipoRetro.Text = "Error Critico"
                End If
            Else
                mostrar_Mensaje("No se encontraron casos con el id " + ObjRetroCal.Id_Auditoria, 2)
                CamposBlancos()
                btnguardar.Visible = False
            End If

        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub
    'Mostrar Mensajes
    Sub mostrar_Mensaje(mensaje As String, tipo As Integer)
        Try
            If tipo = 1 Then
                Pnl_Message.CssClass = "alert alert-danger"
                lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & mensaje
            ElseIf tipo = 2 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span Class='glyphicon glyphicon-warning-sign'></span> " & mensaje
            ElseIf tipo = 3 Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> " & mensaje
            ElseIf tipo = 4 Then
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> " & mensaje

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If lblidaud.Text = "" Then
                mostrar_Mensaje("Para guardar Retroalimentación debe realizar la búsqueda de un ID", 2)
                Exit Sub
            End If
            ObjRetroCal.Validacion_Version = Drl_Version.SelectedValue
            ObjRetroCal.Id_Auditoria = lblidaud.Text
            'Verificación id con retroalimentación
            If ObjRetroCal.ValidacionId().Tables(0).Rows.Count > 0 Then
                mostrar_Mensaje("Ya existe una retroalimentación para esa auditoria", 2)
                Exit Sub
            End If

            ObjValidacion.Validar_Herramientas(TxtSgto, "numero de seguimiento")
            ObjValidacion.Validar_Herramientas(TxtHora, "tiempo de Retroalimentación")

            If (drlParametro.SelectedItem.Text <> "- Seleccione -" And txtObservacion.Text = "") Or drlParametro.SelectedItem.Text = "- Seleccione -" Then
                mostrar_Mensaje("Ingrese el primer parametro y observacion", 2)
                Exit Sub
            End If
            If (drlParametro0.SelectedItem.Text <> "- Seleccione -" And txtObservacion0.Text = "") Or drlParametro0.SelectedItem.Text = "- Seleccione -" Then
                mostrar_Mensaje("Ingrese el segundo parametro y observacion", 2)
                Exit Sub
            End If
            If (drlParametro1.SelectedItem.Text <> "- Seleccione -" And txtObservacion1.Text = "") Or (drlParametro1.SelectedItem.Text = "- Seleccione -" And txtObservacion1.Text <> "") Then
                mostrar_Mensaje("Ingrese la tercer observacion", 2)
                Exit Sub
            End If
            If (drlParametro2.SelectedItem.Text <> "- Seleccione -" And txtObservacion2.Text = "") Or (drlParametro2.SelectedItem.Text = "- Seleccione -" And txtObservacion2.Text <> "") Then
                mostrar_Mensaje("Ingrese la cuarta observación", 2)
                Exit Sub
            End If
            If (drlParametro3.SelectedItem.Text <> "- Seleccione -" And txtObservacion3.Text = "") Or (drlParametro3.SelectedItem.Text = "- Seleccione -" And txtObservacion3.Text <> "") Then
                mostrar_Mensaje("Ingrese la quinta observación", 2)
                Exit Sub
            End If

            If txtresultado.Text = "" Then
                mostrar_Mensaje("Verifique que los items de NIVEL DE PERCEPCION esten evaluados", 2)
                Exit Sub
            End If

            ObjValidacion.Validar_Herramientas(txtCompromiso, "compromiso del Ingeniero/Agente")
            ObjValidacion.Validar_Herramientas(txtObservacionP, "observacion de quien realiza retroalimentacion")
            ObjValidacion.Validar_Herramientas(txtConclucionF, "conclucion final")

            ObjRetroCal.Id_Auditoria = lblidaud.Text
            ObjRetroCal.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            ObjRetroCal.Fc_Audit = Lblfcaud.Text
            ObjRetroCal.Seguimiento = TxtSgto.Text
            ObjRetroCal.Tipo_Retro = LblTipoRetro.Text
            ObjRetroCal.ObservacionP = txtObservacionP.Text
            ObjRetroCal.Compromiso_Usu = txtCompromiso.Text
            ObjRetroCal.Conclusion = txtConclucionF.Text
            ObjRetroCal.Tiempo_Retroalimentacion = TxtHora.Text
            ObjRetroCal.Validacion_Version = Drl_Version.SelectedValue
            ObjRetroCal.Item_1 = RadioBtn1.SelectedValue
            ObjRetroCal.Item_2 = RadioBtn2.SelectedValue
            ObjRetroCal.Item_3 = RadioBtn3.SelectedValue
            ObjRetroCal.Item_4 = RadioBtn4.SelectedValue
            ObjRetroCal.Item_5 = RadioBtn5.SelectedValue
            ObjRetroCal.Resultado = resultado
            ''Obtiene codigo de registro realizado
            ObjRetroCal.Inserta_Retro_Calidad()
            Lblcodretro.Text = ObjRetroCal.Cod_Retroalimentacion

            ObjRetroCal.Fk_Cod_Retroalimentacion = Lblcodretro.Text
            ObjRetroCal.Parametro = drlParametro.SelectedItem.Text
            ObjRetroCal.Observacion = txtObservacion.Text
            If ObjRetroCal.Parametro <> "- Seleccione -" Then
                ObjRetroCal.Ingresar_Causas()
            End If
            ObjRetroCal.Fk_Cod_Retroalimentacion = Lblcodretro.Text
            ObjRetroCal.Parametro = drlParametro0.SelectedItem.Text
            ObjRetroCal.Observacion = txtObservacion0.Text
            If ObjRetroCal.Parametro <> "- Seleccione -" Then
                ObjRetroCal.Ingresar_Causas()
            End If
            ObjRetroCal.Fk_Cod_Retroalimentacion = Lblcodretro.Text
            ObjRetroCal.Parametro = drlParametro1.SelectedItem.Text
            ObjRetroCal.Observacion = txtObservacion1.Text
            If ObjRetroCal.Parametro <> "- Seleccione -" Then
                ObjRetroCal.Ingresar_Causas()
            End If
            ObjRetroCal.Fk_Cod_Retroalimentacion = Lblcodretro.Text
            ObjRetroCal.Parametro = drlParametro2.SelectedItem.Text
            ObjRetroCal.Observacion = txtObservacion2.Text
            If ObjRetroCal.Parametro <> "- Seleccione -" Then
                ObjRetroCal.Ingresar_Causas()
            End If
            ObjRetroCal.Fk_Cod_Retroalimentacion = Lblcodretro.Text
            ObjRetroCal.Parametro = drlParametro3.SelectedItem.Text
            ObjRetroCal.Observacion = txtObservacion3.Text
            If ObjRetroCal.Parametro <> "- Seleccione -" Then
                ObjRetroCal.Ingresar_Causas()
            End If
            mostrar_Mensaje("Se Realizo la Retroalimentación Correctamente con el Id " + Lblcodretro.Text, 4)
            CamposBlancos()


        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub

    Protected Sub BtnConsultaRetros_Click(sender As Object, e As EventArgs) Handles BtnConsultaRetros.Click
        Try
            ObjValidacion.Validar_Herramientas(TxtFechaInicio, "Hora inicio")
            ObjValidacion.Validar_Herramientas(TxtFechaFin, "Hora fin")
            If Date.Parse(TxtFechaInicio.Text) > Date.Parse(TxtFechaFin.Text) Then
                mostrar_Mensaje("verifique que Fecha Inicio sea menor a Fecha Fin", "Advertencia")
                Exit Sub
            End If
            ObjRetroCal.Fc_Inicial = TxtFechaInicio.Text
            ObjRetroCal.Fc_Final = TxtFechaFin.Text
            If TxtCod_Agente.Text <> "" Then
                ObjRetroCal.Cod_Usuario = TxtCod_Agente.Text
            End If
            If drltipo_retro.SelectedIndex <> 0 Then
                ObjRetroCal.Tipo_Retro = drltipo_retro.SelectedItem.Text
            End If


            Session("dtggeneral_RetroCalidadV2") = ObjRetroCal.Busqueda_Avanzada
            dtgConsultas.DataSource = Session("dtggeneral_RetroCalidadV2")
            dtgConsultas.DataBind()
            If ObjRetroCal.Cantidad > 0 Then
                LblCantidad.Text = "Registros encontrados: " & ObjRetroCal.Cantidad
                BtnExporta.Visible = True
            Else
                LblCantidad.Text = "Registros encontrados: 0"
                mostrar_Mensaje("No se encontraron registros", 3)
                dtgConsultas.DataSource = Nothing
                dtgConsultas.DataBind()
                BtnExporta.Visible = True
            End If
        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub

    'Btn Exportar
    Protected Sub BtnExporta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnExporta.Click
        Try
            If dtgConsultas.Rows.Count < 1 Then
                mostrar_Mensaje("Realice una consulta antes de exportar a excel y no modifique los filtros que utilizo para realizar la consulta.", "Advertencia")
                Exit Sub
            End If
            crearexcel()
        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub
    'Metodo Esportar
    Sub crearexcel()
        Try
            Dim sw As New StringWriter()
            Dim hw As New HtmlTextWriter(sw)
            Dim tabla As New Table()
            Dim tr1 As New TableRow()
            Dim cell1 As New TableCell()
            Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"
            If dtgConsultas.Rows.Count() > 0 Then
                dtggeneral.Visible = True
                dtggeneral.DataSource = Session("dtggeneral_RetroCalidadV2")
                dtggeneral.DataBind()
                cell1.Controls.Add(dtggeneral)
                tr1.Cells.Add(cell1)
                tabla.Rows.Add(tr1)
                tabla.RenderControl(hw)
                Response.Clear()
                Response.Buffer = True
                Response.AddHeader("Content-Disposition", "attachment;filename=Retroalimentaciones.xls")
                Response.Charset = "UTF-8"
                Response.ContentType = "application/vnd.ms-excel"
                Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                Response.Write(style)
                Response.Output.Write(sw.ToString())
                Response.Flush()
                Response.End()
            Else
                mostrar_Mensaje("Primero haga una consulta e intente Exportarla!", "Advertencia")
            End If
            dtggeneral.DataSource = Nothing
            dtggeneral.DataBind()
            dtggeneral.Visible = False
        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub

    Protected Sub dtgConsultas_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtgConsultas.PageIndexChanging
        Try
            dtgConsultas.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtgConsultas.DataSource = Session("dtggeneral_RetroCalidadV2")
            dtgConsultas.DataBind()
        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub

    Protected Sub dtgConsultas_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles dtgConsultas.RowCommand
        Try
            Dim Index As Integer

            Select Case e.CommandName
                Case "Seleccionar"
                    Index = Convert.ToInt32(e.CommandArgument)
                    txtcodbus.Text = dtgConsultas.Rows(Index).Cells(1).Text
                    BtnConsultar_Click(1, Nothing)
            End Select

        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub
End Class