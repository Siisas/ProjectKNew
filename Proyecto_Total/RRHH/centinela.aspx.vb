Imports System.Net
Public Class centinela
    Inherits System.Web.UI.Page

    Dim Objrrhh As New clsrrhh
    Dim Registro As String
    Dim FechaActual As Date
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            FechaActual = Now
            Objrrhh.fcregistro = FechaActual
            If Not IsPostBack Then
                Session("Formulario") = "Registro de Entrada y Salida"
                Dim objdatos As New clsgeneral
                ''Cargue Centinela
                Dim objrrhh As New clsrrhh
                objrrhh.codigo = CType(Session("permisos"), clsusuario).Codnom
                objrrhh.fcregistro = FechaActual
                objrrhh.Tipo_Horario = "3"
                dtggeneral.DataSource = objrrhh.Consulta_Ultimos_Registros_Malla_turno
                dtggeneral.DataBind()
                dtgMallaTurno.DataSource = objrrhh.Consulta_Mallas_Turno
                dtgMallaTurno.DataBind()
                LblCuenta.Text = objrrhh.cantidad
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Public Function ConsultaIP() As String
        Dim hostname As String = CStr(Request.ServerVariables("REMOTE_ADDR"))
        Return hostname
    End Function


    Function obtenerHoraMinuto(ByVal fecha As Date) As String
        Dim horaMinuto As String = "00:00"
        Dim hora As String = "00"
        Dim minuto As String = "00"

        If Len(Trim(Str(fecha.Hour))) = 1 Then
            hora = "0" & fecha.Hour
        Else
            hora = fecha.Hour
        End If
        If Len(Trim(Str(fecha.Minute))) = 1 Then
            minuto = "0" & fecha.Minute
        Else
            minuto = fecha.Minute
        End If

        horaMinuto = hora & ":" & minuto

        obtenerHoraMinuto = horaMinuto
    End Function


    Protected Sub Registrar_Malla_Turno()
        Try
            Objrrhh.codigo = CType(Session("permisos"), clsusuario).Codnom
            If Registro = "Centinela" Then
                Objrrhh.Tipo_Horario = "3"
                Objrrhh.Consulta_Registros_Ingreso_Salida_Validacion()
                If Objrrhh.cantidad = 0 Then
                    Objrrhh.IPEntrada = ConsultaIP()
                    Objrrhh.Registro_Ingreso_Malla_Turno()
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro de Ingreso Centinela"
                Else
                    Objrrhh.Tipo_Horario = "3"
                    Objrrhh.IPSalida = ConsultaIP()
                    Objrrhh.Registro_Salida_Malla_Turno()
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro de Salida Centinela"
                End If

            End If
            If Registro = "Break-1" Then
                Objrrhh.Tipo_Horario = "5"
                Objrrhh.Consulta_Registros_Ingreso_Salida_Validacion()
                If Objrrhh.cantidad = 0 Then
                    Objrrhh.IPEntrada = ConsultaIP()
                    Objrrhh.Registro_Ingreso_Malla_Turno()
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro de Ingreso Break-1"
                Else
                    Objrrhh.IPSalida = ConsultaIP()
                    Objrrhh.Registro_Salida_Malla_Turno()
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro de Salida Break-1"
                End If
            End If
            If Registro = "Break-2" Then
                Objrrhh.Tipo_Horario = "7"
                Objrrhh.Consulta_Registros_Ingreso_Salida_Validacion()
                If Objrrhh.cantidad = 0 Then
                    Objrrhh.IPEntrada = ConsultaIP()
                    Objrrhh.Registro_Ingreso_Malla_Turno()
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro de Ingreso Break-2"
                Else
                    Objrrhh.IPSalida = ConsultaIP()
                    Objrrhh.Registro_Salida_Malla_Turno()
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro de Salida Break-2"
                End If
            End If
            If Registro = "Almuerzo" Then
                Objrrhh.Tipo_Horario = "6"
                Objrrhh.Consulta_Registros_Ingreso_Salida_Validacion()
                If Objrrhh.cantidad = 0 Then
                    Objrrhh.IPEntrada = ConsultaIP()
                    Objrrhh.Registro_Ingreso_Malla_Turno()
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro de Ingreso Almuerzo"
                Else
                    Objrrhh.IPSalida = ConsultaIP()
                    Objrrhh.Registro_Salida_Malla_Turno()
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro de Salida Almuerzo"
                End If
            End If
            If Registro = "Capacitacion" Then
                Objrrhh.Tipo_Horario = "8"
                Objrrhh.Consulta_Registros_Ingreso_Salida_Validacion()
                If Objrrhh.cantidad = 0 Then
                    Objrrhh.IPEntrada = ConsultaIP()
                    Objrrhh.Registro_Ingreso_Malla_Turno()
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro de Ingreso Capacitacion"
                Else
                    Objrrhh.IPSalida = ConsultaIP()
                    Objrrhh.Registro_Salida_Malla_Turno()
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro de Salida Capacitacion"
                End If
            End If
            If Registro = "Pre-Turno" Then
                Objrrhh.Tipo_Horario = "9"
                Objrrhh.Consulta_Registros_Ingreso_Salida_Validacion()
                If Objrrhh.cantidad = 0 Then
                    Objrrhh.IPEntrada = ConsultaIP()
                    Objrrhh.Registro_Ingreso_Malla_Turno()
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro de Ingreso Pre-Turno"
                Else
                    Objrrhh.IPSalida = ConsultaIP()
                    Objrrhh.Registro_Salida_Malla_Turno()
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro de Salida Pre-Turno"
                End If
            End If
            Consulta_Malla_Turno()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Consulta_Malla_Turno()
        Try
            Objrrhh.codigo = CType(Session("permisos"), clsusuario).Codnom
            ''''Centinela
            If Objrrhh.Tipo_Horario = "3" Then
                dtggeneral.DataSource = Objrrhh.Consulta_Ultimos_Registros_Malla_turno
                dtggeneral.DataBind()
                dtgMallaTurno.DataSource = Objrrhh.Consulta_Mallas_Turno
                dtgMallaTurno.DataBind()
                LblCuenta.Text = Objrrhh.cantidad
            End If
            ''''Break-1
            If Objrrhh.Tipo_Horario = "5" Then
                Dtgbreak.DataSource = Objrrhh.Consulta_Ultimos_Registros_Malla_turno
                Dtgbreak.DataBind()
                Dtgmallaturnobreak.DataSource = Objrrhh.Consulta_Mallas_Turno
                Dtgmallaturnobreak.DataBind()
                Lblcuentamallabreak.Text = Objrrhh.cantidad
            End If
            ''''Almuerzo
            If Objrrhh.Tipo_Horario = "6" Then
                Dtgalmuerzo.DataSource = Objrrhh.Consulta_Ultimos_Registros_Malla_turno
                Dtgalmuerzo.DataBind()
                Dtgmallaturnoalmuerzo.DataSource = Objrrhh.Consulta_Mallas_Turno
                Dtgmallaturnoalmuerzo.DataBind()
                Llblcuentamallaalmuerzo.Text = Objrrhh.cantidad
            End If
            ''''Break-2
            If Objrrhh.Tipo_Horario = "7" Then
                dtgbreak2.DataSource = Objrrhh.Consulta_Ultimos_Registros_Malla_turno
                dtgbreak2.DataBind()
                Dtgmallaturnobreakdos.DataSource = Objrrhh.Consulta_Mallas_Turno
                Dtgmallaturnobreakdos.DataBind()
                Lblcuentamallabreakdos.Text = Objrrhh.cantidad
            End If
            ''''Capacitacion
            If Objrrhh.Tipo_Horario = "8" Then
                Dtgcapacitacion.DataSource = Objrrhh.Consulta_Ultimos_Registros_Malla_turno
                Dtgcapacitacion.DataBind()
                Dtgmallaturnocapacitacion.DataSource = Objrrhh.Consulta_Mallas_Turno
                Dtgmallaturnocapacitacion.DataBind()
                lblcuentamallacapacitacion.Text = Objrrhh.cantidad
            End If
            ''''Pre-Turno
            If Objrrhh.Tipo_Horario = "9" Then
                Dtgpreturno.DataSource = Objrrhh.Consulta_Ultimos_Registros_Malla_turno
                Dtgpreturno.DataBind()
                dtgmallaturnopreturno.DataSource = Objrrhh.Consulta_Mallas_Turno
                dtgmallaturnopreturno.DataBind()
                lblcuentamallapreturno.Text = Objrrhh.cantidad
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''' VISIBILIDAD '''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub VisibilidadPanel()
        Try
            Pncentinela.Visible = False
            Pnbreaks.Visible = False
            Pnalmuerzo.Visible = False
            Pncapacitación.Visible = False
            Pnpreturno.Visible = False
            Pnbreak.Visible = False
            Pnbreak2.Visible = False
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Registro = "Centinela" Then
                Pncentinela.Visible = True
                Objrrhh.Tipo_Horario = "3"
            End If
            If Registro = "Break" Then
                Pnbreaks.Visible = True
            End If
            If Registro = "Break-1" Then
                Pnbreaks.Visible = True
                Pnbreak.Visible = True
                Objrrhh.Tipo_Horario = "5"
            End If
            If Registro = "Break-2" Then
                Pnbreaks.Visible = True
                Pnbreak2.Visible = True
                Objrrhh.Tipo_Horario = "7"
            End If
            If Registro = "Almuerzo" Then
                Pnalmuerzo.Visible = True
                Objrrhh.Tipo_Horario = "6"
            End If
            If Registro = "Capacitacion" Then
                Pncapacitación.Visible = True
                Objrrhh.Tipo_Horario = "8"
            End If
            If Registro = "Pre-Turno" Then
                Pnpreturno.Visible = True
                Objrrhh.Tipo_Horario = "9"
            End If
            If (Registro = "Centinela") Or (Registro = "Break-1") Or (Registro = "Break-2") Or (Registro = "Almuerzo") Or (Registro = "Capacitacion") Or (Registro = "Pre-Turno") Then
                Consulta_Malla_Turno()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub LinkButtoncentinela_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButtoncentinela.Click
        Try
            Registro = "Centinela"
            VisibilidadPanel()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub LinkButtonbreak_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButtonbreak.Click
        Try
            Registro = "Break"
            VisibilidadPanel()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub LinkButtonbreak1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButtonbreak1.Click
        Try
            Registro = "Break-1"
            VisibilidadPanel()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub LinkButtonbreak2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButtonbreak2.Click
        Try
            Registro = "Break-2"
            VisibilidadPanel()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub LinkButtonalmuerzo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButtonalmuerzo.Click
        Try
            Registro = "Almuerzo"
            VisibilidadPanel()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub LinkButtoncapacitacion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButtoncapacitacion.Click
        Try
            Registro = "Capacitacion"
            VisibilidadPanel()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try

    End Sub
    Protected Sub LinkButtonpreturno_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButtonpreturno.Click
        Try
            Registro = "Pre-Turno"
            VisibilidadPanel()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try

    End Sub
    Protected Sub LinkButtonocultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButtonocultar.Click
        Try
            Registro = "OTRO"
            VisibilidadPanel()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''' REGISTROS '''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Protected Sub Btn_Si_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Si.Click
        guardar()
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Plegar", "PlegDes_Dinamico('#Desp_General', 'slide', '', '', '');", True)
    End Sub
    Protected Sub Btnregistrarbreak_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btnregistrarbreak.Click
        Try
            Registro = "Break-1"
            Registrar_Malla_Turno()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btnbreakdosregistrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btnbreakdosregistrar.Click
        Try
            Registro = "Break-2"
            Registrar_Malla_Turno()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btnregistraralmuerzo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btnregistraralmuerzo.Click
        Try
            Registro = "Almuerzo"
            Registrar_Malla_Turno()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btnregistrarcapacitacion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btnregistrarcapacitacion.Click
        Try
            Registro = "Capacitacion"
            Registrar_Malla_Turno()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btnregistrarpreturno_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btnregistrarpreturno.Click
        Try
            Registro = "Pre-Turno"
            Registrar_Malla_Turno()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Sub guardar()
        Registro = "Centinela"
        Registrar_Malla_Turno()
    End Sub
    Protected Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Objrrhh.codigo = CType(Session("permisos"), clsusuario).Codnom
            Objrrhh.fcregistro = FechaActual
            Objrrhh.Tipo_Horario = "1"
            Objrrhh.Consulta_Mallas_Turno()
            Objrrhh.Consulta_Ultimos_Registros_Malla_turno()
            Try
                If Objrrhh.fcretiro <> Nothing Then
                    Dim validarsalidamalla As Date = Objrrhh.fcretiro
                    Dim validarhoramalla = Mid((obtenerHoraMinuto(validarsalidamalla)).ToString, 1, 2)
                    Dim validarhoraactual = Mid((obtenerHoraMinuto(FechaActual)).ToString, 1, 2)
                    If Objrrhh.fcing <> Nothing Then
                        If Objrrhh.fcfin <> Nothing Then
                            Lbl_Msgdesp.Text = "¿Ya se encuentra un registro de turno, desea registrarse de nuevo?"
                            ScriptManager.RegisterStartupScript(Page, GetType(Page), "desplegar", "PlegDes_Dinamico('#Desp_General', 'slide', '', '', '');", True)
                        ElseIf validarhoramalla - validarhoraactual > 1 Then
                            Lbl_Msgdesp.Text = "¿Esta seguro de que desea registrar la salida en este momento?"
                            ScriptManager.RegisterStartupScript(Page, GetType(Page), "desplegar", "PlegDes_Dinamico('#Desp_General', 'slide', '', '', '');", True)
                        Else
                            guardar()
                        End If
                    Else
                        guardar()
                    End If
                Else
                    If Objrrhh.fcing <> Nothing Then
                        Objrrhh.Tipo_Horario = "2"
                        Objrrhh.Consulta_Ultimos_Registros_Malla_turno()
                        If Objrrhh.fcfin <> Nothing Then
                            Lbl_Msgdesp.Text = "¿Esta seguro de que desea registrarse  en este momento?"
                            ScriptManager.RegisterStartupScript(Page, GetType(Page), "desplegar", "PlegDes_Dinamico('#Desp_General', 'slide', '', '', '');", True)
                        Else
                            Lbl_Msgdesp.Text = "¿Esta seguro de que desea registrar la salida en este momento?"
                            ScriptManager.RegisterStartupScript(Page, GetType(Page), "desplegar", "PlegDes_Dinamico('#Desp_General', 'slide', '', '', '');", True)
                        End If
                    Else
                        guardar()
                    End If
                End If
            Catch ex As Exception
                Pnl_Message.CssClass = "alert alert-danger"
                lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
            End Try
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class