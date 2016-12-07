Imports System.IO

Public Class RetroCalidad
    Inherits System.Web.UI.Page
    Dim dts As New DataSet
    Dim ObjRetroCal As New Clsretroalimentacion
    Dim Validacioncausa As Boolean = False

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Obtengo los datos del usuario'
        Try
            CalcularResultado()
            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                Lblfechareg.Text = DateTime.Now.ToLongDateString()
                ObjRetroCal.Validacion = "Versiones_Retro"
                With Drl_Version
                    .DataSource = ObjRetroCal.ObtenerParametros
                    .DataTextField = "Nombre"
                    .DataValueField = "Nombre"
                    .DataBind()
                End With
                ObjRetroCal.Validacion = ""
                ObjRetroCal.Validacion_Version = "V3"
                Drl_Version_SelectedIndexChanged(1, Nothing)

                Cargardrls()
                btnactualizar.Visible = False
                btnguardar.Visible = False
                btnimprimir.Visible = False
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

    Public Sub Cargardrls()

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

        With drlGrupos
            .DataSource = ObjRetroCal.BuscarGrupos
            .DataTextField = "Cargo"
            .DataValueField = "Cargo"
            .DataBind()
        End With
    End Sub

    Public Sub Campos_Blanco()
        Try
            TxtHora.Text = ""
            TxtMinuto.Text = ""
            TxtSegundo.Text = ""
            Lbltiemporetroalimentacion.Text = ""
            Lblfcretro.Text = ""

            LblArea.Text = ""
            LblCalificacion.Text = ""
            LblCampa.Text = ""
            LblCaso.Text = ""
            Lblcodretro.Text = ""
            LblCompromiso.Text = ""
            LblConclusionF.Text = ""
            LblEstado_Caso.Text = ""
            LblFc_Hora_llam.Text = ""
            Lblfcaud.Text = ""

            Lblfechareg.Text = ""
            LblGrupo.Text = ""
            lblidaud.Text = ""
            LblNomaud.Text = ""
            LblNomAgte.Text = ""
            LblObservacion.Text = ""
            LblObservacion0.Text = ""
            LblObservacion1.Text = ""
            LblObservacion2.Text = ""
            LblObservacion3.Text = ""
            LblObservacionP.Text = ""
            drlParametro.SelectedItem.Text = "- Seleccione -"
            drlParametro0.SelectedItem.Text = "- Seleccione -"
            drlParametro1.SelectedItem.Text = "- Seleccione -"
            drlParametro2.SelectedItem.Text = "- Seleccione -"
            drlParametro3.SelectedItem.Text = "- Seleccione -"

            LblParametro.Text = ""
            LblParametro0.Text = ""
            LblParametro1.Text = ""
            LblParametro2.Text = ""
            LblParametro3.Text = ""
            LblSeguimiento.Text = ""
            LblTipoRetro.Text = ""
            txtCompromiso.Text = ""
            txtConclucionF.Text = ""

            txtidaud.Text = ""
            txtObservacion.Text = ""
            txtObservacion0.Text = ""
            txtObservacion1.Text = ""
            txtObservacion2.Text = ""
            txtObservacion3.Text = ""
            txtObservacionP.Text = ""
            TxtSgto.Text = ""

            RadioBtn1.ClearSelection()
            RadioBtn2.ClearSelection()
            RadioBtn3.ClearSelection()
            RadioBtn4.ClearSelection()
            RadioBtn5.ClearSelection()
            txtresultado.Text = ""

        Catch ex As Exception
            lblmsg.Text = "Se produjo un error: " + ex.Message
        End Try

    End Sub
    Protected Sub btnidaud_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnidaud.Click
        Try
            Dim dts As DataSet

            lblmsg.Text = ""
            ObjRetroCal.Validacion_Version = Drl_Version.SelectedValue
            If txtidaud.Text = "" Then
                lblmsg.Text = "Ingrese un ID para realizar la busqueda"
                Exit Sub

            Else

                ObjRetroCal.Id_Auditoria = txtidaud.Text

                If ObjRetroCal.ValidacionId().Tables(0).Rows.Count > 0 Then
                    lblmsg.Text = "Ya existe una retroalimentacion para esa auditoria con el Codigo Retroalimentacion " + CStr(ObjRetroCal.Cod_Retroalimentacion)

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
                    LblGrupo.Text = ObjRetroCal.Grupo
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
                    lblmsg.Text = "No se encontraron casos con el id " + ObjRetroCal.Id_Auditoria
                    Campos_Blanco()
                    btnguardar.Visible = False
                End If

            End If

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            lblmsg.Text = ""
            ObjRetroCal.Validacion_Version = Drl_Version.SelectedValue
            ObjRetroCal.Id_Auditoria = lblidaud.Text
            If lblidaud.Text = "" Then
                lblmsg.Text = "Para guardar Retroalimentación debe realizar la búsqueda de un ID"
                Exit Sub
            End If
            'Verificación id con retroalimentación
            If ObjRetroCal.ValidacionId().Tables(0).Rows.Count > 0 Then
                lblmsg.Text = "Ya existe una retroalimentación para esa auditoria"
                Exit Sub
            End If
            If TxtSgto.Text = "" Then
                lblmsg.Text = "Debe ingresar el numero de seguimiento"
                Exit Sub
            End If
            If (drlParametro.SelectedItem.Text <> "- Seleccione -" And txtObservacion.Text = "") Or drlParametro.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Ingrese el primer parametro y observacion "
                Exit Sub
            End If
            If (drlParametro0.SelectedItem.Text <> "- Seleccione -" And txtObservacion0.Text = "") Or drlParametro0.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Ingrese el segundo parametro y observacion"
                Exit Sub
            End If
            If (drlParametro1.SelectedItem.Text <> "- Seleccione -" And txtObservacion1.Text = "") Or (drlParametro1.SelectedItem.Text = "- Seleccione -" And txtObservacion1.Text <> "") Then
                lblmsg.Text = "Ingrese la tercer observacion"
                Exit Sub
            End If
            If (drlParametro2.SelectedItem.Text <> "- Seleccione -" And txtObservacion2.Text = "") Or (drlParametro2.SelectedItem.Text = "- Seleccione -" And txtObservacion2.Text <> "") Then
                lblmsg.Text = "Ingrese la cuarta observación"
                Exit Sub
            End If
            If (drlParametro3.SelectedItem.Text <> "- Seleccione -" And txtObservacion3.Text = "") Or (drlParametro3.SelectedItem.Text = "- Seleccione -" And txtObservacion3.Text <> "") Then
                lblmsg.Text = "Ingrese la quinta observación"
                Exit Sub
            End If
            If txtObservacionP.Text = "" Then
                lblmsg.Text = "Debe ingresar la Observación de la persona que realiza la Retroalimentación"
                Exit Sub
            End If
            If TxtHora.Text <> "" Or TxtMinuto.Text <> "" Or TxtSegundo.Text <> "" Then
                If Integer.Parse(TxtHora.Text) > 24 Or Integer.Parse(TxtHora.Text) < 0 Then
                    lblmsg.Text = "Verifique la hora del Tiempo de Retroalimentación"
                    Exit Sub
                End If
                If Integer.Parse(TxtMinuto.Text) > 59 Or Integer.Parse(TxtMinuto.Text) < 0 Then
                    lblmsg.Text = "Verifique los minutos del Tiempo de Retroalimentación"
                    Exit Sub
                End If
                If Integer.Parse(TxtSegundo.Text) > 59 Or Integer.Parse(TxtSegundo.Text) < 0 Then
                    lblmsg.Text = "Verifique los segundos del Tiempo de Retroalimentación"
                    Exit Sub
                End If
            End If
            If TxtHora.Text = "" And TxtMinuto.Text = "" And TxtSegundo.Text = "" Then
                ObjRetroCal.Tiempo_Retroalimentacion = ""
            Else
                ObjRetroCal.Tiempo_Retroalimentacion = TxtHora.Text + ":" + TxtMinuto.Text + ":" + TxtSegundo.Text
            End If
            ObjRetroCal.Id_Usuario = lblusuario.Text
            ObjRetroCal.Seguimiento = TxtSgto.Text
            ObjRetroCal.Tipo_Retro = LblTipoRetro.Text
            ObjRetroCal.ObservacionP = txtObservacionP.Text
            ObjRetroCal.Compromiso_Usu = txtCompromiso.Text
            ObjRetroCal.Conclusion = txtConclucionF.Text
            ObjRetroCal.Inserta_Retro_Calidad()
            ''Obtiene codigo de registro realizado
            ObjRetroCal.consultaidusuario()
            Lblcodretro.Text = ObjRetroCal.Cod_Retroalimentacion

            'Lblcodretro.Text = ObjRetroCal.Cod_Retroalimentacion
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
            lblmsg.Text = "Se Realizo la Retroalimentación Correctamente con el Id " + Lblcodretro.Text
            Campos_Blanco()
        Catch ex As Exception
            lblmsg.Text = "Se presento error la realizar la retroalimentacion: " + ex.Message
        End Try
    End Sub


    Protected Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            If txtcodbus.Text = "" Then
                lblmsg.Text = "Ingrese un Código de Retroalimentación para realizar la busqueda"
                Exit Sub
            End If
            ObjRetroCal.Validacion_Version = Drl_Version.SelectedValue
            lblmsg.Text = ""
            ObjRetroCal.Validacion = "1"
            ObjRetroCal.Cod_Retroalimentacion = txtcodbus.Text
            ObjRetroCal.Llenar_Campos()
            If ObjRetroCal.Id_Auditoria = 0 Then
                lblmsg.Text = "No se encontraron registros con el codigo " + CStr(ObjRetroCal.Cod_Retroalimentacion)
                btnactualizar.Visible = False
                btnimprimir.Visible = False
                Campos_Blanco()
                Exit Sub
            End If
            lblidaud.Text = ObjRetroCal.Id_Auditoria
            txtidaud.Visible = False
            btnidaud.Visible = False

            Lblfcretro.Text = ObjRetroCal.Fc_Retro

            LblSeguimiento.Text = ObjRetroCal.Seguimiento
            TxtSgto.Visible = False
            LblTipoRetro.Text = ObjRetroCal.Tipo_Retro
            Lbltiemporetroalimentacion.Text = ObjRetroCal.Tiempo_Retroalimentacion
            LblCompromiso.Text = ObjRetroCal.Compromiso_Usu
            LblConclusionF.Text = ObjRetroCal.Conclusion
            Pntiemporetroalimentacion.Visible = False
            txtCompromiso.Visible = False
            txtConclucionF.Visible = False
            LblObservacionP.Text = ObjRetroCal.ObservacionP
            txtObservacionP.Visible = False
            Lblcodretro.Text = txtcodbus.Text
            If ObjRetroCal.Todo = "V2" Then
                Lbl_Version.Text = "1"
            End If
            If ObjRetroCal.Todo = "V3" Then
                Lbl_Version.Text = "1.1"
            End If

            ObjRetroCal.Validacion = "2"
            ObjRetroCal.Id_Auditoria = lblidaud.Text
            ObjRetroCal.Llenar_Campos()

            Lblfcaud.Text = ObjRetroCal.Fc_Reg_CR
            LblCampa.Text = ObjRetroCal.Campania
            LblNomAgte.Text = ObjRetroCal.Agente
            LblArea.Text = ObjRetroCal.Area
            LblNomaud.Text = ObjRetroCal.Auditor
            LblGrupo.Text = ObjRetroCal.Grupo
            LblFc_Hora_llam.Text = ObjRetroCal.Fc_Llamada
            LblCaso.Text = ObjRetroCal.Id_Caso
            LblEstado_Caso.Text = ObjRetroCal.Estado_Caso
            LblCalificacion.Text = ObjRetroCal.Calificacion
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
            If ObjRetroCal.Todo = "V3" Then
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

            ObjRetroCal.Validacion = "3"
            ObjRetroCal.Cod_Retroalimentacion = txtcodbus.Text
            ObjRetroCal.Llenar_Campos()

            LblParametro.Text = ObjRetroCal.Parametro
            LblParametro0.Text = ObjRetroCal.Parametro0
            If ObjRetroCal.Parametro1 = "- Seleccione -" Then
                LblParametro1.Text = ""
            Else
                LblParametro1.Text = ObjRetroCal.Parametro1
            End If

            If ObjRetroCal.Parametro2 = "- Seleccione -" Then
                LblParametro2.Text = ""
            Else
                LblParametro2.Text = ObjRetroCal.Parametro2
            End If

            If ObjRetroCal.Parametro3 = "- Seleccione -" Then
                LblParametro3.Text = ""
            Else
                LblParametro3.Text = ObjRetroCal.Parametro3
            End If
            drlParametro.Visible = False
            drlParametro0.Visible = False
            drlParametro1.Visible = False
            drlParametro2.Visible = False
            drlParametro3.Visible = False

            LblObservacion.Text = ObjRetroCal.Observacion
            LblObservacion0.Text = ObjRetroCal.Observacion0
            LblObservacion1.Text = ObjRetroCal.Observacion1
            LblObservacion2.Text = ObjRetroCal.Observacion2
            LblObservacion3.Text = ObjRetroCal.Observacion3

            txtObservacion.Visible = False
            txtObservacion0.Visible = False
            txtObservacion1.Visible = False
            txtObservacion2.Visible = False
            txtObservacion3.Visible = False
            btnactualizar.Visible = False
            If ObjRetroCal.Fc_Reg_Actualiza = Nothing Then
                '/*******NUEVO************/
                Pnl_eficacia_Reg.Visible = True
                Pnl_eficacia_con.Visible = False
                If ObjRetroCal.Resultado <> Nothing Or ObjRetroCal.Resultado <> 0 Then
                    RadioBtn1.SelectedValue = ObjRetroCal.Item_1
                    RadioBtn2.SelectedValue = ObjRetroCal.Item_2
                    RadioBtn3.SelectedValue = ObjRetroCal.Item_3
                    RadioBtn4.SelectedValue = ObjRetroCal.Item_4
                    RadioBtn5.SelectedValue = ObjRetroCal.Item_5
                    If ObjRetroCal.Resultado >= 7 Then
                        txtresultado.Text = "Retro Aceptada"
                    ElseIf ObjRetroCal.Resultado < 7 And ObjRetroCal.Resultado >= 4.5 Then
                        txtresultado.Text = "Se requiere Refuerzo"
                    ElseIf ObjRetroCal.Resultado < 4.5 And ObjRetroCal.Resultado > 0 Then
                        txtresultado.Text = "Rechazada"
                    Else
                        txtresultado.Text = ""
                    End If
                End If
                '/*************************/
                btnactualizar.Visible = True
                LblConclusionF.Visible = False
                LblCompromiso.Visible = False
                Lbltiemporetroalimentacion.Visible = False
                txtConclucionF.Visible = True
                txtCompromiso.Visible = True
                txtConclucionF.Text = ObjRetroCal.Conclusion
                txtCompromiso.Text = ObjRetroCal.Compromiso_Usu
                Pntiemporetroalimentacion.Visible = True
                If ObjRetroCal.Tiempo_Retroalimentacion <> Nothing Then
                    TxtHora.Text = ObjRetroCal.Tiempo_Retroalimentacion.Substring(0, 2)
                    TxtMinuto.Text = ObjRetroCal.Tiempo_Retroalimentacion.Substring(3, 2)
                    TxtSegundo.Text = ObjRetroCal.Tiempo_Retroalimentacion.Substring(6, 2)
                Else
                    TxtHora.Text = Nothing
                    TxtMinuto.Text = Nothing
                    TxtSegundo.Text = Nothing
                End If
            Else
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
                Pnl_eficacia_Reg.Visible = False
                Pnl_eficacia_con.Visible = True
            End If
            btnimprimir.Visible = True
            btnguardar.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se presento error al realizar la consulta: " + ex.Message
        End Try
    End Sub



    Protected Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Try
            If txtCompromiso.Text = "" Or txtConclucionF.Text = "" Then
                lblmsg.Text = "Debe llenar los campos Compromiso y Conclusion final"
                Exit Sub
            End If
            If TxtHora.Text = "" Or TxtMinuto.Text = "" Or TxtSegundo.Text = "" Then
                lblmsg.Text = "Ingrese el Tiempo de Retroalimentacion"
                Exit Sub
            Else
                If Integer.Parse(TxtHora.Text) > 24 Or Integer.Parse(TxtHora.Text) < 0 Then
                    lblmsg.Text = "Verifique la hora del Tiempo de Retroalimentación"
                    Exit Sub
                End If
                If Integer.Parse(TxtMinuto.Text) > 59 Or Integer.Parse(TxtMinuto.Text) < 0 Then
                    lblmsg.Text = "Verifique los minutos del Tiempo de Retroalimentación"
                    Exit Sub
                End If
                If Integer.Parse(TxtSegundo.Text) > 59 Or Integer.Parse(TxtSegundo.Text) < 0 Then
                    lblmsg.Text = "Verifique los segundos del Tiempo de Retroalimentación"
                    Exit Sub
                End If
            End If
            If txtresultado.Text = "" Then
                lblmsg.Text = "Verifique que los items de la eficacia de Retroalimentación esten evaluados"
                Exit Sub
            End If
            lblmsg.Text = ""
            ObjRetroCal.Cod_Retroalimentacion = Lblcodretro.Text
            ObjRetroCal.Fecha_Retro = Now
            ObjRetroCal.Compromiso_Usu = txtCompromiso.Text
            ObjRetroCal.Conclusion = txtConclucionF.Text
            ObjRetroCal.Id_Usuario = lblusuario.Text
            ObjRetroCal.Tiempo_Retroalimentacion = TxtHora.Text + ":" + TxtMinuto.Text + ":" + TxtSegundo.Text
            '/******************NUEVO******22/12/2015***/
            ''Registro de items Eficacia Retrocalidad
            ObjRetroCal.Resultado = resultado
            ObjRetroCal.Item_1 = RadioBtn1.SelectedValue
            ObjRetroCal.Item_2 = RadioBtn2.SelectedValue
            ObjRetroCal.Item_3 = RadioBtn3.SelectedValue
            ObjRetroCal.Item_4 = RadioBtn4.SelectedValue
            ObjRetroCal.Item_5 = RadioBtn5.SelectedValue
            '/*****************************************/
            ObjRetroCal.Actualiza_Retro_Calidad()
            '/*****************************************/
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
            Pnl_eficacia_con.Visible = True
            Pnl_eficacia_Reg.Visible = False
            '/*****************************************/
            lblmsg.Text = "Se realizo la actualizacion correctamente"
            LblCompromiso.Text = txtCompromiso.Text
            LblConclusionF.Text = txtConclucionF.Text
            Lbltiemporetroalimentacion.Text = TxtHora.Text + ":" + TxtMinuto.Text + ":" + TxtSegundo.Text
            LblCompromiso.Visible = True
            LblConclusionF.Visible = True
            Lbltiemporetroalimentacion.Visible = True
            txtCompromiso.Visible = False
            txtConclucionF.Visible = False
            Pntiemporetroalimentacion.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo un error al actualizar" + ex.Message
        End Try
    End Sub


    Protected Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Try
            Page.Response.Redirect(Page.Request.Url.AbsolutePath)
        Catch ex As Exception
            lblmsg.Text = "Se produjo un error: " + ex.Message
        End Try

    End Sub



    Protected Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        Try
            ObjRetroCal.Validacion_Version = Drl_Version.SelectedValue
            Lbl_Version_Retro.Visible = False
            Drl_Version.Visible = False

            ObjRetroCal.Validacion = "1"
            ObjRetroCal.Cod_Retroalimentacion = txtcodbus.Text
            ObjRetroCal.Llenar_Campos()

            Panelkam.Visible = False
            Plcons.Visible = False

            LblCompromiso.Text = ObjRetroCal.Compromiso_Usu
            LblConclusionF.Text = ObjRetroCal.Conclusion
            Lbltiemporetroalimentacion.Text = ObjRetroCal.Tiempo_Retroalimentacion
            Pntiemporetroalimentacion.Visible = False


            LblCompromiso.Visible = True
            LblConclusionF.Visible = True
            Lbltiemporetroalimentacion.Visible = True


            txtCompromiso.Visible = False
            txtConclucionF.Visible = False
            PanelIMP.Visible = True
            PanelVerificacion.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo un error: " + ex.Message
        End Try
    End Sub

    Public Sub Consulta()
        Try
            lblmsg.Text = ""
            If txtfc_inicial.Text = "" And txtfc_final.Text = "" And txtcodagente.Text = "" And drlGrupos.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Es necesario ingresar un parametro para la consulta"
                dtgConsultas.DataSource = Nothing
                dtgConsultas.DataBind()
                LblCantidad.Text = "0"
                Exit Sub
            Else
                If (txtfc_inicial.Text <> Nothing And txtfc_final.Text = Nothing) Or (txtfc_inicial.Text = Nothing And txtfc_final.Text <> Nothing) Then
                    lblmsg.Text = "Debe ingresar la fecha inicial y la fecha final"
                    dtgConsultas.DataSource = Nothing
                    dtgConsultas.DataBind()
                    LblCantidad.Text = "0"
                    Exit Sub
                End If
                ObjRetroCal.Agente = txtcodagente.Text
                ObjRetroCal.Grupo = drlGrupos.SelectedItem.Text

                If txtfc_inicial.Text = "" Then
                    ObjRetroCal.Fc_Inicial = Nothing
                Else
                    ObjRetroCal.Fc_Inicial = txtfc_inicial.Text
                End If

                If txtfc_final.Text = "" Then
                    ObjRetroCal.Fc_Final = Nothing
                Else
                    ObjRetroCal.Fc_Final = txtfc_final.Text
                End If


                'Busqueda por Rango de fechas
                If txtfc_inicial.Text <> "" And txtfc_final.Text <> "" Then
                    ObjRetroCal.Validacion = 3
                    'Busqueda por Rango de fechas y codigo
                    If txtcodagente.Text <> "" Then
                        ObjRetroCal.Validacion = 4
                    End If

                    'Busqueda por Rango de fechas y Grupo
                    If drlGrupos.SelectedItem.Text <> "- Seleccione -" Then
                        ObjRetroCal.Validacion = 5
                    End If


                End If

                'Busqueda por Codigo
                If txtcodagente.Text <> "" And (txtfc_inicial.Text = "" And txtfc_final.Text = "") Then
                    ObjRetroCal.Validacion = 1

                End If
                'Busqueda por Grupo
                If drlGrupos.SelectedItem.Text <> "- Seleccione -" And (txtfc_inicial.Text = "" And txtfc_final.Text = "") Then
                    ObjRetroCal.Validacion = 2
                End If

                If ValidaExcel = "1" Then
                    dtgxls.DataSource = ObjRetroCal.Busqueda_Avanzada()
                    dtgxls.DataBind()
                Else
                    ValidaExcel = "2"
                End If

                dtgConsultas.DataSource = ObjRetroCal.Busqueda_Avanzada()
                dtgConsultas.DataBind()
                LblCantidad.Text = ObjRetroCal.Cantidad
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo un error: " + ex.Message
        End Try
    End Sub

    Protected Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Try
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se produjo un error: " + ex.Message
        End Try
    End Sub

    Dim ValidaExcel As String
    Protected Sub btnxls_Click(sender As Object, e As EventArgs) Handles btnxls.Click
        Try
            If Integer.Parse(LblCantidad.Text) < 1 Then
                lblmsg.Text = "Realice una consulta antes de exportar a excel."
                Exit Sub
            End If
            ValidaExcel = "1"
            Consulta()
            If ValidaExcel = "2" Then
                Exit Sub
            End If

            crearexcel()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Sub crearexcel()
        Try
            Dim sb As New StringBuilder
            Dim sw As New StringWriter(sb)
            Dim htw As New HtmlTextWriter(sw)
            Dim pagina As Page = New Page
            Dim form = New HtmlForm
            Dim objdtsconsultaxls As New DataSet
            Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"

            pagina.EnableEventValidation = False
            pagina.DesignerInitialize()
            pagina.Controls.Add(form)
            dtgxls.Visible = True
            form.Controls.Add(dtgxls)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=Retroalimentacion_Calidad.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub


    Protected Sub dtgConsultas_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtgConsultas.PageIndexChanging
        Try
            dtgConsultas.PageIndex = e.NewPageIndex
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub Drl_Version_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Drl_Version.SelectedIndexChanged
        Try
            If Drl_Version.SelectedValue = "V2" Then
                ObjRetroCal.Validacion_Version = "V2"
                Lbl_Version.Text = "1"
                Cargardrls()
            Else
                If Drl_Version.SelectedValue = "V3" Then
                    ObjRetroCal.Validacion_Version = "V3"
                    Lbl_Version.Text = "1.1"
                    Cargardrls()
                End If
            End If
            Campos_Blanco()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub


    'Calcula el promedio de la eficacia retro calidad
    Dim resultado As Decimal
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

End Class