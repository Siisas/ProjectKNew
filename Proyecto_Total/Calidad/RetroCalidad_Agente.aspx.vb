Imports System.IO
Public Class RetroCalidad_Agente
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
            If Not IsPostBack Then
                ObjRetroCal.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
                ConsultaRetro()
            End If
        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub

    Protected Sub ConsultaRetro()
        Try
            ObjRetroCal.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            Session("dtggeneral_RetroCalidadV2") = ObjRetroCal.Busqueda_Avanzada
            dtgConsultas.DataSource = Session("dtggeneral_RetroCalidadV2")
            dtgConsultas.DataBind()
            If ObjRetroCal.Cantidad > 0 Then
                LblCantidad.Text = "Registros encontrados: " & ObjRetroCal.Cantidad

            Else
                LblCantidad.Text = "Registros encontrados: 0"
                mostrar_Mensaje("No se encontraron registros", 3)
                dtgConsultas.DataSource = Nothing
                dtgConsultas.DataBind()
            End If

        Catch ex As Exception
            Throw ex
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
            Dim retro As String
            Select Case e.CommandName
                Case "Seleccionar"
                    Index = Convert.ToInt32(e.CommandArgument)
                    ObjRetroCal.Validacion = "2"
                    retro = dtgConsultas.Rows(Index).Cells(1).Text


                    ObjRetroCal.Validacion = "2"
                    ObjRetroCal.Cod_Retroalimentacion = retro
                    ObjRetroCal.Llenar_CamposV2()
                    'Busca Info
                    ObjRetroCal.Validacion = "1"
                    ObjRetroCal.Validacion_Version = ObjRetroCal.Validacion_Version
                    ObjRetroCal.Cod_Retroalimentacion = retro
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
                        Lblcodretro.Text = retro

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
                        ObjRetroCal.Cod_Retroalimentacion = retro
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
            End Select
        Catch ex As Exception
            ObjValidacion.Val_Ex(ex)
            Pnl_Message.CssClass = ObjValidacion.Ex("Alert")
            lblmsg.Text = ObjValidacion.Ex("Message")
        End Try
    End Sub

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

End Class