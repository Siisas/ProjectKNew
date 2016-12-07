Public Class AsignacionHorariosCambios
    Inherits System.Web.UI.Page
    Dim ObjAdmin As New clsrrhh
    Dim Fecha As DateTime = Now
    Dim permisos As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Cambios en la Asiganacion de Horarios"
                Session("Val") = ""
                Dim objdatos As New clsgeneral
                Cargar_Drl()
                Dim x As Integer = CInt(CType(Session("permisos"), clsusuario).perfil)
                Dim cod As String = CType(Session("permisos"), clsusuario).Codnom
                If cod = "C1583" Or cod = "C0714" Or cod = "C1707" Or x = 1 Then
                    ObjAdmin.Validacion = "Permitir"
                    Consulta_Solicitudes()
                    BtnSolicitar.Visible = False
                    permisos = "permisos"
                ElseIf x = 38 Or x = 3 Then
                    BtnAprobar.Visible = False
                    BtnRechazar.Visible = False
                    dtgGeneral2.Columns(dtgGeneral2.Columns.Count - 1).Visible = False
                    ObjAdmin.Validacion = "No_Permitir_Superv"
                    Consulta_Solicitudes()
                Else
                    Pnl_Registro.Visible = False
                    Pnl_Consulta.Visible = False
                    Pnl_DtgGeneral.Visible = False
                    dtgGeneral2.Columns(dtgGeneral2.Columns.Count - 1).Visible = False
                    ObjAdmin.Validacion = "No_Permitir"
                    Consulta_Solicitudes()
                End If

            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error" & ex.Message
        End Try
    End Sub
    'CLICK
    Protected Sub BtnAprobar_Click(sender As Object, e As EventArgs) Handles BtnAprobar.Click
        Try
            If LblCod_Agente.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No hay horarios para actualizar"
                Exit Sub
            End If
            If TxtFecha_Ingreso.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese una fecha de ingreso para el o los agentes"
                Exit Sub
            End If

            If (Drl_Hora_Ingreso.SelectedValue <> "00:00" Or Drl_Hora_Salida.SelectedValue <> "00:00") And drlTipoHorario.SelectedValue <> "3" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por favor Verifique que la hora de ingreso sea 00:00 si la jornada va hacer diferente a Laboral"
                Exit Sub
            End If
            If drlTipoHorario.SelectedItem.Text = "- Seleccione -" Or drlTipoHorario.SelectedItem.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un tipo de horario"
                Exit Sub
            End If

            If drlTipoHorario.SelectedItem.Text = "Descanso" Or drlTipoHorario.SelectedItem.Text = "Aus. Justificada" Or drlTipoHorario.SelectedItem.Text = "Suspension" Or drlTipoHorario.SelectedItem.Text = "Vacaciones" Then
                Drl_Hora_Ingreso.SelectedValue = "00:00"
                Drl_Hora_Salida.SelectedValue = "00:00"
            Else
                If Drl_Hora_Ingreso.SelectedValue = "00:00" Or Drl_Hora_Ingreso.SelectedValue = "- Seleccione -" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite una hora de ingreso para el o los agentes"
                    Exit Sub
                End If
                If Drl_Hora_Salida.SelectedValue = "00:00" Or Drl_Hora_Salida.SelectedValue = "- Seleccione -" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite una hora de Salida para el o los agentes"
                    Exit Sub
                End If
            End If
            ObjAdmin.idusuario = CType(Session("permisos"), clsusuario).usuario
            ObjAdmin.codigo = LblCod_Agente.Text
            Dim Almuerzo As String = ""
            Dim Break1 As String = ""
            Dim Break2 As String = ""
            Dim Capacitacion As String = ""
            Dim Pre_turno As String = ""
            Dim Segmento As String = ""
            'Validar Almuerzo
            If Lbl_Cod_Almuerzo.Text <> "" And (Lbl_Jornada.Text = "Jornada Oficina" Or Lbl_Jornada.Text = "Personalizada") And DrlHora_Almuerzo_1.SelectedValue = "- Seleccione -" And DrlHora_Almuerzo_2.SelectedValue = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Ingrese la hora de Almuerzo Por favor"
                Exit Sub
            ElseIf Lbl_Cod_Almuerzo.Text <> "" And (Lbl_Jornada.Text = "Jornada Mañana" Or Lbl_Jornada.Text = "Jornada Tarde" Or Lbl_Jornada.Text = "Jornada Noche" Or Lbl_Jornada.Text = "Descanso" Or Lbl_Jornada.Text = "Aus. Justificada" Or Lbl_Jornada.Text = "Suspension" Or Lbl_Jornada.Text = "Vacaciones") Then
                Session("AgregarAlmuerzo") = "QuitarId"
                Almuerzo = "si"
            ElseIf Lbl_Cod_Almuerzo.Text = "" And (Lbl_Jornada.Text = "Jornada Oficina" Or Lbl_Jornada.Text = "Personalizada") And DrlHora_Almuerzo_1.SelectedValue <> "- Seleccione -" And DrlHora_Almuerzo_1.SelectedValue <> "- Seleccione -" Then
                Almuerzo = "si"
            Else
                If Lbl_Cod_Almuerzo.Text <> "" Then
                    Almuerzo = "si"
                End If
            End If
            ''validar break's

            If Lbl_Cod_Break1.Text <> "" Then
                Break1 = "si"
            End If
            If Lbl_Cod_Break2.Text <> "" Then
                Break2 = "si"
            End If
            'validar capacitacion 
            If (Lbl_Jornada.Text = "Jornada Oficina" Or Lbl_Jornada.Text = "Jornada Mañana" Or Lbl_Jornada.Text = "Jornada Tarde") And Lbl_Cod_Capacitacion.Text <> "" And Txt_Hora_Capacitacion_1.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la hora de Capacitacion Por favor"
                Exit Sub
            Else
                If Lbl_Cod_Capacitacion.Text <> "" Then
                    Capacitacion = "si"
                End If
            End If
            'validar Pre - Turno
            If (Lbl_Jornada.Text = "Jornada Oficina" Or Lbl_Jornada.Text = "Jornada Mañana" Or Lbl_Jornada.Text = "Jornada Tarde") And (Txt_Pre_Turno_1.Text = "" Or Txt_Pre_Turno_2.Text = "") And Lbl_Cod_Pre_turno.Text <> "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la hora de Pre - Turno Por favor"
                Exit Sub
            Else
                If Lbl_Cod_Pre_turno.Text <> "" Then
                    Pre_turno = "si"
                End If
            End If
            'validar segmento
            If LblSegmento1.Text <> "" Then
                Segmento = "si"
            End If
            ObjAdmin.Validacion = "Aprobado"
            If Lbl_Jornada.Text = "Jornada Noche" Then
                Dim s1 = DateTime.Parse(TxtFecha_Ingreso.Text & " " & Drl_Hora_Ingreso.SelectedValue)
                Dim s2 = s1.AddHours(8)

                ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + Drl_Hora_Ingreso.SelectedValue
                ObjAdmin.fcretiro = s2
            Else
                ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + Drl_Hora_Ingreso.SelectedValue
                ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " " + Drl_Hora_Salida.SelectedValue
            End If
            ObjAdmin.Cod_Archivo = LblCod_Registro.Text
            ObjAdmin.tipocont = drlTipoHorario.Text
            If Segmento = "si" Then
                ObjAdmin.Ubicacion = DrlSegmento.SelectedValue
            End If
            ObjAdmin.Actualizacion_Registro_Horario()

            If Almuerzo = "si" Then
                If PnlAlmuerzo.Visible = True Then
                    ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + DrlHora_Almuerzo_1.SelectedValue
                    ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " " + DrlHora_Almuerzo_2.SelectedValue
                Else
                    ObjAdmin.fcing = TxtFecha_Ingreso.Text + " 00:00"
                    ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " 00:00"
                End If
                If Session("ValidarHorariosDescanso") = "CambioAdes" Or Session("AgregarAlmuerzo") = "Si" Then
                    ObjAdmin.Cod_Diagnostico = Lbl_Cod_Almuerzo.Text
                    ObjAdmin.tipocont = "6"
                    ObjAdmin.Validacion = "AprobadoCambioDes"
                    ObjAdmin.Actualizacion_Registro_Horario()
                ElseIf Session("ValidarHorariosDescanso") = "CambioAlab" Or Session("AgregarAlmuerzo") = "QuitarId" Then
                    ObjAdmin.Cod_Archivo = Lbl_Cod_Almuerzo.Text
                    ObjAdmin.tipocont = "2"
                    ObjAdmin.estado = "0"
                    ObjAdmin.Actualizacion_Registro_Horario()
                    ObjAdmin.estado = Nothing
                Else
                    ObjAdmin.Validacion = "Aprobado"
                    ObjAdmin.Cod_Archivo = Lbl_Cod_Almuerzo.Text
                    ObjAdmin.tipocont = "6"
                    ObjAdmin.Actualizacion_Registro_Horario()
                End If
            End If

            If Break1 = "si" Then
                If PnlBreak1.Visible = True Then
                    If Drl_Hora_Break1_1.SelectedValue = "- Seleccione -" Then
                        ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + Txt_Hora_Break1_1.Text
                        ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " " + Txt_Hora_Break1_2.Text
                    Else
                        ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + Drl_Hora_Break1_1.SelectedValue
                        ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " " + Drl_Hora_Break1_2.SelectedValue
                    End If
                Else
                    ObjAdmin.fcing = TxtFecha_Ingreso.Text + " 00:00"
                    ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " 00:00"
                End If
                If Session("ValidarHorariosDescanso") = "CambioAdes" Or Session("AddBreak1") = "Si" Then
                    ObjAdmin.Cod_Diagnostico = Lbl_Cod_Break1.Text
                    ObjAdmin.tipocont = "5"
                    ObjAdmin.Validacion = "AprobadoCambioDes"
                    ObjAdmin.Actualizacion_Registro_Horario()
                ElseIf Session("ValidarHorariosDescanso") = "CambioAlab" Or Session("QuitarBreak1") = "QuitarId" Then
                    ObjAdmin.Cod_Archivo = Lbl_Cod_Break1.Text
                    ObjAdmin.tipocont = "2"
                    ObjAdmin.estado = "0"
                    ObjAdmin.Actualizacion_Registro_Horario()
                    ObjAdmin.estado = Nothing
                Else
                    ObjAdmin.Validacion = "Aprobado"
                    ObjAdmin.Cod_Archivo = Lbl_Cod_Break1.Text
                    ObjAdmin.tipocont = "5"
                    ObjAdmin.Actualizacion_Registro_Horario()
                End If
            End If

            If Break2 = "si" Then
                If PnlBreak2.Visible = True Then
                    If Drl_Hora_Break2_1.SelectedValue = "- Seleccione -" Then
                        ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + Txt_Hora_Break2_1.Text
                        ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " " + Txt_Hora_Break2_2.Text
                    Else
                        ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + Drl_Hora_Break2_1.SelectedValue
                        ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " " + Drl_Hora_Break2_2.SelectedValue
                    End If
                Else
                    ObjAdmin.fcing = TxtFecha_Ingreso.Text + " 00:00"
                    ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " 00:00"
                End If
                If Session("ValidarHorariosDescanso") = "CambioAdes" Or Session("AddBreak2") = "Si" Then
                    ObjAdmin.Cod_Diagnostico = Lbl_Cod_Break2.Text
                    ObjAdmin.tipocont = "7"
                    ObjAdmin.Validacion = "AprobadoCambioDes"
                    ObjAdmin.Actualizacion_Registro_Horario()
                ElseIf Session("ValidarHorariosDescanso") = "CambioAlab" Or Session("QuitarBreak2") = "QuitarId" Then
                    ObjAdmin.Cod_Archivo = Lbl_Cod_Break2.Text
                    ObjAdmin.tipocont = "2"
                    ObjAdmin.estado = "0"
                    ObjAdmin.Actualizacion_Registro_Horario()
                    ObjAdmin.estado = Nothing
                Else
                    ObjAdmin.Validacion = "Aprobado"
                    ObjAdmin.Cod_Archivo = Lbl_Cod_Break2.Text
                    ObjAdmin.tipocont = "7"
                    ObjAdmin.Actualizacion_Registro_Horario()
                End If
            End If

            If Capacitacion = "si" Then
                If PnlCapacitacion.Visible = True Then
                    ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + Txt_Hora_Capacitacion_1.Text
                    ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " " + Txt_Hora_Capacitacion_2.Text
                Else
                    ObjAdmin.fcing = TxtFecha_Ingreso.Text + " 00:00"
                    ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " 00:00"
                End If
                If Session("ValidarHorariosDescanso") = "CambioAdes" Or Session("cap") = "Si" Then
                    ObjAdmin.Cod_Diagnostico = Lbl_Cod_Capacitacion.Text
                    ObjAdmin.tipocont = "8"
                    ObjAdmin.Validacion = "AprobadoCambioDes"
                    ObjAdmin.Actualizacion_Registro_Horario()
                ElseIf Session("ValidarHorariosDescanso") = "CambioAlab" Or Session("QuitarCapacitacion") = "QuitarId" Then
                    ObjAdmin.Cod_Archivo = Lbl_Cod_Capacitacion.Text
                    ObjAdmin.tipocont = "2"
                    ObjAdmin.estado = "0"
                    ObjAdmin.Actualizacion_Registro_Horario()
                    ObjAdmin.estado = Nothing
                Else
                    ObjAdmin.Validacion = "Aprobado"
                    ObjAdmin.Cod_Archivo = Lbl_Cod_Capacitacion.Text
                    ObjAdmin.tipocont = "8"
                    ObjAdmin.Actualizacion_Registro_Horario()
                End If
            End If

            If Pre_turno = "si" Then
                If PnlPreTurno.Visible = True Then
                    ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + Txt_Pre_Turno_1.Text
                    ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " " + Txt_Pre_Turno_2.Text
                Else
                    ObjAdmin.fcing = TxtFecha_Ingreso.Text + " 00:00"
                    ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " 00:00"
                End If
                If Session("ValidarHorariosDescanso") = "CambioAdes" Or Session("pre") = "Si" Then
                    ObjAdmin.Cod_Diagnostico = Lbl_Cod_Pre_turno.Text
                    ObjAdmin.tipocont = "9"
                    ObjAdmin.Validacion = "AprobadoCambioDes"
                    ObjAdmin.Actualizacion_Registro_Horario()
                ElseIf Session("ValidarHorariosDescanso") = "CambioAlab" Or Session("QuitarPre") = "QuitarId" Then
                    ObjAdmin.Cod_Archivo = Lbl_Cod_Pre_turno.Text
                    ObjAdmin.tipocont = "2"
                    ObjAdmin.estado = "0"
                    ObjAdmin.Actualizacion_Registro_Horario()
                    ObjAdmin.estado = Nothing
                Else
                    ObjAdmin.Validacion = "Aprobado"
                    ObjAdmin.Cod_Archivo = Lbl_Cod_Pre_turno.Text
                    ObjAdmin.tipocont = "9"
                    ObjAdmin.Actualizacion_Registro_Horario()
                End If

            End If
            limpiar()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Actualizacion de Horario Realizada"
            LblCod_Agente.Text = ""
            TxtFecha_Ingreso.Text = " "
            Drl_Hora_Ingreso.SelectedValue = "- Seleccione -"
            Drl_Hora_Salida.SelectedValue = "- Seleccione -"
            LblCod_Registro.Text = ""
            Cargar_Drl()
            dtgGeneral.DataSource = Nothing
            dtgGeneral.DataBind()
            LblCuenta.Text = ""
            Txt_Hora_Salida_Antigua.Text = ""
            Txt_Hora_Entrada_Antigua.Text = ""
            Txt_Pre_Turno_2.Text = ""
            ObjAdmin.Validacion = "Permitir"
            Consulta_Solicitudes()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            limpiar()
            LblCod_Agente.Text = ""
            Drl_Hora_Ingreso.SelectedValue = "- Seleccione -"
            Drl_Hora_Salida.SelectedValue = "- Seleccione -"
            Txt_Hora_Entrada_Antigua.Text = ""
            Txt_Hora_Salida_Antigua.Text = ""
            Lbl_Jornada.Text = ""
            TxtFecha_Ingreso.Text = ""
            Btn_Buscar_Full_Horarios.Enabled = False
            Btn_Buscar_Horarios_Predeterminado.Enabled = False
            Drl_Hora_Ingreso.Enabled = False
            Drl_Hora_Salida.Enabled = False
            drlTipoHorario.Enabled = False
            Drl_Hora_Break1_2.Enabled = False
            Drl_Hora_Break2_2.Enabled = False
            Txt_Hora_Capacitacion_2.Enabled = False
            Consulta()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Buscar_Full_Horarios_Click(sender As Object, e As EventArgs) Handles Btn_Buscar_Full_Horarios.Click
        Try
            If PnlBreak1.Visible = False Then
                PnlBreak1.Visible = True
                PnlBreak2.Visible = True
                PnlPreTurno.Visible = True
            End If
            Traer_Todos_Los_Horarios()
            Txt_Pre_Turno_2.Enabled = False
            Drl_Hora_Salida.Enabled = True
            Drl_Hora_Break2_2.Enabled = True
            Drl_Hora_Break1_2.Enabled = True
            PnlAlmuerzo.Visible = True
            DrlHora_Almuerzo_2.Enabled = False
            Lbl_Jornada.Text = "Personalizada"
            Session("Val") = "FULL"
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Buscar_Horarios_Predeterminado_Click(sender As Object, e As EventArgs) Handles Btn_Buscar_Horarios_Predeterminado.Click
        Try
            If PnlBreak1.Visible = False Then
                PnlBreak1.Visible = True
                PnlBreak2.Visible = True
                PnlPreTurno.Visible = True
            End If
            Session("Val") = ""
            ObjAdmin.Validacion = "Tod_Out"
            With Drl_Hora_Break1_2
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "Fc_Salida"
                .DataValueField = "Fc_Salida"
                .DataBind()
            End With
            ObjAdmin.Validacion = "Tod_Out"
            With Drl_Hora_Break2_2
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "Fc_Salida"
                .DataValueField = "Fc_Salida"
                .DataBind()
            End With
            Drl_Hora_Salida.Enabled = False
            ObjAdmin.Validacion = "1"
            With Drl_Hora_Ingreso
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "Fc_Entrada"
                .DataValueField = "Fc_Entrada"
                .DataBind()
            End With
            ObjAdmin.Validacion = "2"
            With Drl_Hora_Salida
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "Fc_Salida"
                .DataValueField = "Fc_Salida"
                .DataBind()
            End With
            Drl_Hora_Ingreso.SelectedValue = "- Seleccione -"
            Drl_Hora_Break2_2.SelectedValue = "- Seleccione -"
            Drl_Hora_Break1_2.SelectedValue = "- Seleccione -"
            Txt_Pre_Turno_2.Enabled = False
            Drl_Hora_Salida.Enabled = False
            Drl_Hora_Break2_2.Enabled = False
            Drl_Hora_Break1_2.Enabled = False
            Txt_Pre_Turno_2.Text = ""
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub BtnSolicitar_Click(sender As Object, e As EventArgs) Handles BtnSolicitar.Click
        Try
            If LblCod_Agente.Text = "" Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No hay horarios para actualizar"
                Exit Sub
            End If
            If (Drl_Hora_Ingreso.SelectedValue <> Txt_Hora_Entrada_Antigua.Text And Drl_Hora_Ingreso.SelectedValue <> Txt_Hora_Entrada_Antigua.Text) And PnlBreak1.Visible = True And PnlBreak2.Visible = True And Drl_Hora_Break1_1.SelectedValue = "- Seleccione -" And Drl_Hora_Break2_1.SelectedValue = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Debe modificar los break para que queden acorde al turno"
                Exit Sub
            End If
            If dtgGeneral.Rows.Count < 1 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Antes de realizar el registro primero agrege un agente"
                Exit Sub
            End If
            If TxtFecha_Ingreso.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese una fecha de ingreso para el o los agentes"
                Exit Sub
            End If
            If (Drl_Hora_Ingreso.SelectedValue <> "00:00" Or Drl_Hora_Salida.SelectedValue <> "00:00") And drlTipoHorario.SelectedValue <> "3" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>"
                lblmsg.Text = "Por favor Verifique que la hora de ingreso y de salida sea 00:00 si la jornada va hacer diferente a Laboral"
                Exit Sub
            End If
            If drlTipoHorario.SelectedItem.Text = "- Seleccione -" Or drlTipoHorario.SelectedItem.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un tipo de horario"
                Exit Sub
            End If
            If drlTipoHorario.SelectedItem.Text = "Descanso" Or drlTipoHorario.SelectedItem.Text = "Aus. Justificada" Or drlTipoHorario.SelectedItem.Text = "Suspension" Or drlTipoHorario.SelectedItem.Text = "Vacaciones" Then
                Drl_Hora_Ingreso.SelectedValue = "00:00"
                Drl_Hora_Salida.SelectedValue = "00:00"
            Else
                If Drl_Hora_Ingreso.SelectedValue = "00:00" Or Drl_Hora_Ingreso.SelectedValue = "- Seleccione -" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite una hora de ingreso para el o los agentes"
                    Exit Sub
                End If
                If Drl_Hora_Salida.SelectedValue = "00:00" Or Drl_Hora_Salida.SelectedValue = "- Seleccione -" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite una hora de Salida para el o los agentes"
                    Exit Sub
                End If
            End If
            ' Validar Personalizado 

            If Lbl_Jornada.Text = "Personalizada" Then
                If CInt(Left(Drl_Hora_Break1_1.SelectedValue, 2)) = CInt(Left(Drl_Hora_Break1_2.SelectedValue, 2)) Then
                    If CInt(Right(Drl_Hora_Break1_2.SelectedValue, 2)) - CInt(Right(Drl_Hora_Break1_1.SelectedValue, 2)) <> 15 Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Asegurese de que el tiempo de break1 no sea superior a 15 minutos!"
                        Exit Sub
                    End If
                ElseIf CInt(Left(Drl_Hora_Break1_1.SelectedValue, 2)) < CInt(Left(Drl_Hora_Break1_2.SelectedValue, 2)) Then
                    If CInt(Left(Drl_Hora_Break1_2.SelectedValue, 2)) - CInt(Left(Drl_Hora_Break1_1.SelectedValue, 2)) <> 1 Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Asegurese de que el tiempo de break1 no sea superior a 15 minutos!"
                        Exit Sub
                    End If
                    Dim a As String = Right(Drl_Hora_Break1_2.SelectedValue, 2)
                    Dim b As String = Right(Drl_Hora_Break1_1.SelectedValue, 2)
                    If Right(Drl_Hora_Break1_1.SelectedValue, 2) = "45" And Right(Drl_Hora_Break1_2.SelectedValue, 2) = "00" Then
                    Else
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> La hora de salida  del break1 no puede ser menor o igual a la hora de entrada"
                        Exit Sub
                    End If
                End If

                If CInt(Left(Drl_Hora_Break2_1.SelectedValue, 2)) = CInt(Left(Drl_Hora_Break2_2.SelectedValue, 2)) Then
                    If CInt(Right(Drl_Hora_Break2_2.SelectedValue, 2)) - CInt(Right(Drl_Hora_Break2_1.SelectedValue, 2)) <> 15 Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Asegurese de que el tiempo de break2 no sea superior a 15 minutos!"
                        Exit Sub
                    End If
                ElseIf CInt(Left(Drl_Hora_Break2_1.SelectedValue, 2)) < CInt(Left(Drl_Hora_Break2_2.SelectedValue, 2)) Then
                    If CInt(Left(Drl_Hora_Break2_2.SelectedValue, 2)) - CInt(Left(Drl_Hora_Break2_1.SelectedValue, 2)) <> 1 Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Asegurese de que el tiempo de break2 no sea superior a 15 minutos!"
                        Exit Sub
                    End If
                    If CInt(Right(Drl_Hora_Break2_2.SelectedValue, 2)) <> 00 And CInt(Right(Drl_Hora_Break2_1.SelectedValue, 2)) <> 45 Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Asegurese de que el tiempo de break2 no sea superior a 15 minutos!"
                        Exit Sub
                    End If
                End If
                'If CInt(Replace((Txt_Pre_Turno_2.Text), ":", "")) - CInt(Replace((Txt_Pre_Turno_1.Text), ":", "")) <> 15 Then
                '    Pnl_Message.CssClass = "alert alert-warning"
                '    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Asegurese de que el tiempo de pre-turno no sea superior a 15 minutos!"
                '    Exit Sub
                'ElseIf CInt(Replace((Txt_Pre_Turno_2.Text), ":", "")) - CInt(Replace((Txt_Pre_Turno_1.Text), ":", "")) <> 15 Then
                '    Pnl_Message.CssClass = "alert alert-warning"
                '    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Asegurese de que el tiempo de pre-turno no sea superior a 15 minutos!"
                '    Exit Sub
                'End If
                If (CInt(Replace((Drl_Hora_Break1_1.SelectedValue), ":", "")) < CInt(Replace((Drl_Hora_Ingreso.SelectedValue), ":", ""))) Or (CInt(Replace((Drl_Hora_Break2_1.SelectedValue), ":", "")) < CInt(Replace((Drl_Hora_Ingreso.SelectedValue), ":", ""))) Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡La hora de ENTRADA del break no puede ser MENOR a la hora de ENTRADA del turno!"
                    Exit Sub
                End If
                If (CInt(Replace((Drl_Hora_Break1_2.SelectedValue), ":", "")) < CInt(Replace((Drl_Hora_Ingreso.SelectedValue), ":", ""))) Or (CInt(Replace((Drl_Hora_Break2_2.SelectedValue), ":", "")) < CInt(Replace((Drl_Hora_Ingreso.SelectedValue), ":", ""))) Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡La hora de SALIDA del break no puede ser MENOR a la hora de ENTRADA del turno!"
                    Exit Sub
                End If
                If (CInt(Replace((Drl_Hora_Break1_1.SelectedValue), ":", "")) > CInt(Replace((Drl_Hora_Salida.SelectedValue), ":", ""))) Or (CInt(Replace((Drl_Hora_Break2_1.SelectedValue), ":", "")) > CInt(Replace((Drl_Hora_Salida.SelectedValue), ":", ""))) Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡La hora de ENTRADA del break no puede ser MAYOR a la hora de SALIDA del turno!"
                    Exit Sub
                End If
                If (CInt(Replace((Drl_Hora_Break1_2.SelectedValue), ":", "")) > CInt(Replace((Drl_Hora_Salida.SelectedValue), ":", ""))) Or (CInt(Replace((Drl_Hora_Break2_2.SelectedValue), ":", "")) > CInt(Replace((Drl_Hora_Salida.SelectedValue), ":", ""))) Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡La hora de SALIDA del break no puede ser MAYOR a la hora de SALIDA del turno!"
                    Exit Sub
                End If
                If (CInt(Left(Drl_Hora_Break1_1.SelectedValue, 2)) >= CInt(Left(Drl_Hora_Break2_1.SelectedValue, 2))) Or (CInt(Left(Drl_Hora_Break1_2.SelectedValue, 2)) >= CInt(Left(Drl_Hora_Break2_2.SelectedValue, 2))) Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡La hora del break2 no puede ser Menor a la hora  del break1!"
                    Exit Sub
                End If
                If Lbl_Jornada.Text = "Personalizada" And (DrlHora_Almuerzo_1.SelectedValue <> "- Seleccione -" And DrlHora_Almuerzo_2.SelectedValue = "- Seleccione -") Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese las dos horas del Almuerzo"
                    Exit Sub
                End If
            End If

            'Validacion  BREAK
            If Drl_Hora_Break1_1.SelectedValue = "- Seleccione -" And Drl_Hora_Break2_1.SelectedValue = "- Seleccione -" And (drlTipoHorario.SelectedItem.Text = "Laboral" Or drlTipoHorario.SelectedItem.Text = "Personalizada") Then
                If Drl_Hora_Ingreso.SelectedItem.Text = "22:00" And Drl_Hora_Salida.SelectedItem.Text = "06:00" Then

                Else
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la hora del la del break-1 y la del break-2"
                    If PnlBreak1.Visible = False And PnlBreak2.Visible = False Then
                        PnlBreak1.Visible = True
                        PnlBreak2.Visible = True
                    End If
                    Exit Sub
                End If
            ElseIf Drl_Hora_Break1_1.SelectedValue <> "- Seleccione -" And Drl_Hora_Break2_1.SelectedValue = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la hora del la del break-2"
                Exit Sub
            ElseIf Drl_Hora_Break1_1.SelectedValue = "- Seleccione -" And Drl_Hora_Break2_1.SelectedValue <> "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la hora del la del break-1"
                Exit Sub
            ElseIf (Drl_Hora_Break1_2.SelectedValue = "- Seleccione -" Or Drl_Hora_Break2_2.SelectedValue = "- Seleccione -") And (drlTipoHorario.SelectedItem.Text = "Laboral" Or drlTipoHorario.SelectedItem.Text = "Personalizada") Then
                If Drl_Hora_Ingreso.SelectedItem.Text = "22:00" And Drl_Hora_Salida.SelectedItem.Text = "06:00" Then

                Else
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Asegurese de que todos los break's esten seleccionados!."
                    Exit Sub
                End If
            End If

            If Lbl_Jornada.Text = "Jornada Oficina" And (DrlHora_Almuerzo_1.SelectedValue = "- Seleccione -" Or DrlHora_Almuerzo_2.SelectedValue = "- Seleccione -") Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la hora del Almuerzo"
                Exit Sub
            End If
            ObjAdmin.idusuario = CType(Session("permisos"), clsusuario).usuario
            ObjAdmin.codigo = LblCod_Agente.Text
            Dim Almuerzo As String = ""
            Dim Break1 As String = ""
            Dim Break2 As String = ""
            Dim Capacitacion As String = ""
            Dim Pre_turno As String = ""
            Dim Segmento As String = ""
            'validaciones para cambio de descanso a laboral
            If Lbl_Cod_Break1.Text = "" And Lbl_Cod_Break2.Text = "" And Drl_Hora_Break1_1.SelectedValue <> "- Seleccione -" And Drl_Hora_Break2_1.SelectedValue <> "- Seleccione -" Then
                Break1 = "si"
                Break2 = "si"
                Lbl_Cod_Break1.Text = 1
                Lbl_Cod_Break2.Text = 1
            End If
            If Lbl_Cod_Almuerzo.Text = "" And DrlHora_Almuerzo_1.SelectedValue <> "- Seleccione -" And (Lbl_Jornada.Text = "Jornada Oficina" Or Lbl_Jornada.Text = "Personalizada") Then
                Almuerzo = "si"
                Lbl_Cod_Almuerzo.Text = 1
            End If
            If Lbl_Cod_Capacitacion.Text = "" And Txt_Hora_Capacitacion_1.Text <> Nothing Then
                Capacitacion = "si"
                Lbl_Cod_Capacitacion.Text = 1
            End If
            If Lbl_Cod_Pre_turno.Text = "" And Txt_Pre_Turno_1.Text <> Nothing And (drlTipoHorario.SelectedItem.Text <> "descanso" Or drlTipoHorario.SelectedItem.Text <> "aus. justificada" Or drlTipoHorario.SelectedItem.Text <> "suspension" Or drlTipoHorario.SelectedItem.Text <> "vacaciones") Then
                Pre_turno = "si"
                Lbl_Cod_Pre_turno.Text = 1
            End If

            'Validar Almuerzo
            If Lbl_Cod_Almuerzo.Text <> "" And (Lbl_Jornada.Text = "Jornada Oficina" Or Lbl_Jornada.Text = "Personalizada") And DrlHora_Almuerzo_1.SelectedValue = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la hora de Almuerzo Por favor"
                Exit Sub
            ElseIf Lbl_Cod_Almuerzo.Text <> "" And (Lbl_Jornada.Text = "Jornada Mañana" Or Lbl_Jornada.Text = "Jornada Tarde" Or Lbl_Jornada.Text = "Jornada Noche" Or Lbl_Jornada.Text = "Descanso" Or Lbl_Jornada.Text = "Aus. Justificada" Or Lbl_Jornada.Text = "Suspension" Or Lbl_Jornada.Text = "Vacaciones") Then
                Session("AgregarAlmuerzo") = "QuitarId"
                Almuerzo = "si"
            Else
                If Lbl_Cod_Almuerzo.Text <> "" And (Lbl_Jornada.Text = "Jornada Oficina" Or Lbl_Jornada.Text = "Personalizada") Then
                    Almuerzo = "si"
                End If
            End If
            'validar Break's
            If Lbl_Cod_Break1.Text <> "" And (Lbl_Jornada.Text = "Descanso" Or Lbl_Jornada.Text = "Aus. Justificada" Or Lbl_Jornada.Text = "Suspension" Or Lbl_Jornada.Text = "Vacaciones") Then
                Session("QuitarBreak1") = "QuitarId"
                Break1 = "si"
            ElseIf Lbl_Cod_Break1.Text <> "" Then
                Session("QuitarBreak1") = Nothing
                Break1 = "si"
            End If
            If Lbl_Cod_Break2.Text <> "" And (Lbl_Jornada.Text = "Descanso" Or Lbl_Jornada.Text = "Aus. Justificada" Or Lbl_Jornada.Text = "Suspension" Or Lbl_Jornada.Text = "Vacaciones") Then
                Session("QuitarBreak2") = "QuitarId"
                Break2 = "si"
            ElseIf Lbl_Cod_Break2.Text <> "" Then
                Session("QuitarBreak2") = Nothing
                Break2 = "si"

            End If
            'validar capacitacion 
            If (Lbl_Jornada.Text = "Jornada Oficina" Or Lbl_Jornada.Text = "Jornada Mañana" Or Lbl_Jornada.Text = "Jornada Tarde") And Lbl_Cod_Capacitacion.Text <> "" And Txt_Hora_Capacitacion_1.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la hora de Capacitacion Por favor"
                Exit Sub
            ElseIf Lbl_Cod_Capacitacion.Text <> "" And (Lbl_Jornada.Text = "Descanso" Or Lbl_Jornada.Text = "Aus. Justificada" Or Lbl_Jornada.Text = "Suspension" Or Lbl_Jornada.Text = "Vacaciones") Then
                Session("QuitarCapacitacion") = "QuitarId"
                Capacitacion = "si"
                If Lbl_Cod_Capacitacion.Text <> "" Then
                    Capacitacion = "si"
                End If
            End If
            'validar Pre - Turno
            If (Lbl_Jornada.Text = "Jornada Oficina" Or Lbl_Jornada.Text = "Jornada Mañana" Or Lbl_Jornada.Text = "Jornada Tarde") And (Txt_Pre_Turno_1.Text = "" Or Txt_Pre_Turno_2.Text = "") And Lbl_Cod_Pre_turno.Text <> "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la hora de Pre - Turno Por favor"
                Exit Sub
            ElseIf Lbl_Cod_Pre_turno.Text <> "" And (Lbl_Jornada.Text = "Descanso" Or Lbl_Jornada.Text = "Aus. Justificada" Or Lbl_Jornada.Text = "Suspension" Or Lbl_Jornada.Text = "Vacaciones") Then
                Session("QuitarPre") = "QuitarId"
                Pre_turno = "si"
            Else
                If Lbl_Cod_Pre_turno.Text <> "" Then
                    Pre_turno = "si"
                End If
            End If
            'Validar Segmento
            If LblSegmento1.Text <> Nothing Then
                Segmento = "si"
            End If
            If Lbl_Jornada.Text = "Jornada Noche" Then
                Dim s1 = DateTime.Parse(TxtFecha_Ingreso.Text & " " & Drl_Hora_Ingreso.SelectedValue)
                Dim s2 = s1.AddHours(8)

                ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + Drl_Hora_Ingreso.SelectedValue
                ObjAdmin.fcretiro = s2
            Else
                ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + Drl_Hora_Ingreso.SelectedValue
                ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " " + Drl_Hora_Salida.SelectedValue
            End If
            ObjAdmin.Cod_Archivo = LblCod_Registro.Text
            ObjAdmin.tipocont = drlTipoHorario.Text
            If PnlSegmmento.Visible = True Then
                If DrlSegmento.SelectedValue <> "- Seleccione -" Then
                    ObjAdmin.Ubicacion = DrlSegmento.SelectedValue
                Else
                    ObjAdmin.Ubicacion = LblSegmento.Text
                End If
            Else
                ObjAdmin.Ubicacion = LblSegmento.Text
            End If
            ObjAdmin.Validacion = "Solicitud_Cambio_Horario"
            ObjAdmin.Actualizacion_Registro_Horario()
            If Almuerzo = "si" Then
                If PnlAlmuerzo.Visible = True Then
                    ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + DrlHora_Almuerzo_1.SelectedValue
                    ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " " + DrlHora_Almuerzo_2.SelectedValue
                Else
                    ObjAdmin.fcing = TxtFecha_Ingreso.Text + " 00:00"
                    ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " 00:00"
                End If
                ObjAdmin.Cod_Archivo = Lbl_Cod_Almuerzo.Text
                ObjAdmin.tipocont = "6"
                ObjAdmin.Actualizacion_Registro_Horario()
            End If
            If Break1 = "si" Then
                If PnlBreak1.Visible = True Then
                    If Drl_Hora_Break1_1.SelectedValue = "- Seleccione -" Then
                        ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + Txt_Hora_Break1_1.Text
                        ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " " + Txt_Hora_Break1_2.Text
                    Else
                        ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + Drl_Hora_Break1_1.SelectedValue
                        ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " " + Drl_Hora_Break1_2.SelectedValue
                    End If
                Else
                    ObjAdmin.fcing = TxtFecha_Ingreso.Text + " 00:00"
                    ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " 00:00"
                End If
                ObjAdmin.Cod_Archivo = Lbl_Cod_Break1.Text
                ObjAdmin.tipocont = "5"
                ObjAdmin.Actualizacion_Registro_Horario()
            End If
            If Break2 = "si" Then
                If PnlBreak2.Visible = True Then
                    If Drl_Hora_Break2_1.SelectedValue = "- Seleccione -" Then
                        ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + Txt_Hora_Break2_1.Text
                        ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " " + Txt_Hora_Break2_2.Text
                    Else
                        ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + Drl_Hora_Break2_1.SelectedValue
                        ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " " + Drl_Hora_Break2_2.SelectedValue
                    End If
                Else
                    ObjAdmin.fcing = TxtFecha_Ingreso.Text + " 00:00"
                    ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " 00:00"
                End If
                ObjAdmin.Cod_Archivo = Lbl_Cod_Break2.Text
                ObjAdmin.tipocont = "7"
                ObjAdmin.Actualizacion_Registro_Horario()
            End If
            If Capacitacion = "si" Then
                If PnlCapacitacion.Visible = True Then
                    ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + Txt_Hora_Capacitacion_1.Text
                    ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " " + Txt_Hora_Capacitacion_2.Text
                Else
                    ObjAdmin.fcing = TxtFecha_Ingreso.Text + " 00:00"
                    ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " 00:00"
                End If
                ObjAdmin.Cod_Archivo = Lbl_Cod_Capacitacion.Text
                ObjAdmin.tipocont = "8"
                ObjAdmin.Actualizacion_Registro_Horario()
            End If
            If Pre_turno = "si" Then
                If PnlPreTurno.Visible = True Then
                    ObjAdmin.fcing = TxtFecha_Ingreso.Text + " " + Txt_Pre_Turno_1.Text
                    ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " " + Txt_Pre_Turno_2.Text
                Else
                    ObjAdmin.fcing = TxtFecha_Ingreso.Text + " 00:00"
                    ObjAdmin.fcretiro = TxtFecha_Ingreso.Text + " 00:00"
                End If
                ObjAdmin.Cod_Archivo = Lbl_Cod_Pre_turno.Text
                ObjAdmin.tipocont = "9"
                ObjAdmin.Actualizacion_Registro_Horario()
            End If
            limpiar()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Solicitud de Cambio de Horario Registrada"
            LblCod_Agente.Text = ""
            TxtFecha_Ingreso.Text = " "
            Drl_Hora_Ingreso.SelectedValue = "- Seleccione -"
            Drl_Hora_Salida.SelectedValue = "- Seleccione -"
            LblCod_Registro.Text = ""
            Cargar_Drl()
            dtgGeneral.DataSource = Nothing
            dtgGeneral.DataBind()
            LblCuenta.Text = ""
            Txt_Hora_Salida_Antigua.Text = ""
            Txt_Hora_Entrada_Antigua.Text = ""
            Txt_Pre_Turno_2.Text = ""
            ObjAdmin.Validacion = "No_Permitir"
            Consulta_Solicitudes()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    'DTGGENERAL

    Protected Sub dtgGeneral_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtgGeneral.RowCommand
        Try
            ObjAdmin.Validacion = "1"
            With Drl_Hora_Ingreso
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "Fc_Entrada"
                .DataValueField = "Fc_Entrada"
                .DataBind()
            End With
            ObjAdmin.Validacion = "2"
            With Drl_Hora_Salida
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "Fc_Salida"
                .DataValueField = "Fc_Salida"
                .DataBind()
            End With
            Drl_Hora_Salida.Enabled = False
            Dim x As Integer = CInt(LblCuenta.Text) - 1
            For Each row As GridViewRow In dtgGeneral.Rows
                If e.CommandName = "Seleccione" Then
                    Dim index As Integer = x
                    If dtgGeneral.Rows(index).Cells(5).Text = "Laboral" Or dtgGeneral.Rows(index).Cells(5).Text = "Descanso" Or dtgGeneral.Rows(index).Cells(5).Text = "Vacaciones" Or dtgGeneral.Rows(index).Cells(5).Text = "Aus. Justificada" Or dtgGeneral.Rows(index).Cells(5).Text = "Suspension" Then
                        LblCod_Registro.Text = dtgGeneral.Rows(index).Cells(0).Text
                        LblCod_Agente.Text = dtgGeneral.Rows(index).Cells(2).Text
                        TxtFecha_Ingreso.Text = Date.Parse(dtgGeneral.Rows(index).Cells(3).Text).Date
                        Txt_Hora_Entrada_Antigua.Text = obtenerHoraMinuto(Date.Parse(dtgGeneral.Rows(index).Cells(3).Text))
                        Txt_Hora_Salida_Antigua.Text = obtenerHoraMinuto(Date.Parse(dtgGeneral.Rows(index).Cells(4).Text))
                        Try
                            Drl_Hora_Ingreso.SelectedValue = obtenerHoraMinuto(Date.Parse(dtgGeneral.Rows(index).Cells(3).Text))
                            Drl_Hora_Salida.SelectedValue = obtenerHoraMinuto(Date.Parse(dtgGeneral.Rows(index).Cells(4).Text))
                        Catch ex As Exception
                            With Drl_Hora_Ingreso
                                .DataSource = Nothing
                                .DataTextField = Nothing
                                .DataValueField = Nothing
                                .DataBind()
                            End With
                            Traer_Todos_Los_Horarios()
                        End Try
                        If dtgGeneral.Rows(index).Cells(7).Text <> "" Then
                            LblSegmento1.Text = dtgGeneral.Rows(index).Cells(0).Text
                            LblSegmento.Text = (dtgGeneral.Rows(index).Cells(7).Text)
                            ObjAdmin.Validacion = "segmento"
                            With DrlSegmento
                                .DataSource = ObjAdmin.Consulta_Horarios
                                .DataTextField = "segmento"
                                .DataValueField = "segmento"
                                .DataBind()
                            End With
                        End If
                        PnlSegmmento.Visible = True
                        If dtgGeneral.Rows(index).Cells(5).Text = "Vacaciones" Then
                            Drl_Hora_Salida.SelectedValue = "00:00"
                            Lbl_Jornada.Text = "Vacaciones"
                            PnlSegmmento.Visible = False
                        ElseIf dtgGeneral.Rows(index).Cells(5).Text = "Aus. Justificada" Then
                            Drl_Hora_Salida.SelectedValue = "00:00"
                            Lbl_Jornada.Text = "Aus. Justificada"
                            PnlSegmmento.Visible = False
                        ElseIf dtgGeneral.Rows(index).Cells(5).Text = "Suspension" Then
                            Drl_Hora_Salida.SelectedValue = "00:00"
                            Lbl_Jornada.Text = "Suspension"
                            PnlSegmmento.Visible = False
                        ElseIf dtgGeneral.Rows(index).Cells(5).Text = "Descanso" Then
                            Drl_Hora_Salida.SelectedValue = "00:00"
                            Lbl_Jornada.Text = "Descanso"
                            PnlSegmmento.Visible = False
                        ElseIf Txt_Hora_Entrada_Antigua.Text = "06:00" And Txt_Hora_Salida_Antigua.Text = "14:00" Or Txt_Hora_Entrada_Antigua.Text = "07:00" And Txt_Hora_Salida_Antigua.Text = "15:00" Or Txt_Hora_Entrada_Antigua.Text = "08:00" And Txt_Hora_Salida_Antigua.Text = "17:00" Or Txt_Hora_Entrada_Antigua.Text = "13:00" And Txt_Hora_Salida_Antigua.Text = "21:00" Or Txt_Hora_Entrada_Antigua.Text = "14:00" And Txt_Hora_Salida_Antigua.Text = "22:00" Or Txt_Hora_Entrada_Antigua.Text = "22:00" And Txt_Hora_Salida_Antigua.Text = "06:00" Or Txt_Hora_Entrada_Antigua.Text = "00:00" And Txt_Hora_Salida_Antigua.Text = "00:00" Then
                            Session("Val") = ""
                            validar_Jornada()
                        Else
                            Session("Val") = "FULL"
                            validar_Jornada()
                        End If

                        If dtgGeneral.Rows(index).Cells(6).Text = Nothing Then
                        Else
                            drlTipoHorario.SelectedValue = dtgGeneral.Rows(index).Cells(6).Text
                            Lbl_Tipo_Horario.Text = dtgGeneral.Rows(index).Cells(5).Text
                        End If

                    End If
                    If dtgGeneral.Rows(index).Cells(5).Text = "Almuerzo" Then
                        Lbl_Cod_Almuerzo.Text = dtgGeneral.Rows(index).Cells(0).Text
                        DrlHora_Almuerzo_1.SelectedValue = obtenerHoraMinuto(Date.Parse(dtgGeneral.Rows(index).Cells(3).Text))
                        DrlHora_Almuerzo_2.SelectedValue = obtenerHoraMinuto(Date.Parse(dtgGeneral.Rows(index).Cells(4).Text))
                        PnlAlmuerzo.Visible = True
                    End If
                    If dtgGeneral.Rows(index).Cells(5).Text = "Break 1" Then
                        Lbl_Cod_Break1.Text = dtgGeneral.Rows(index).Cells(0).Text
                        Txt_Hora_Break1_1.Text = obtenerHoraMinuto(Date.Parse(dtgGeneral.Rows(index).Cells(3).Text))
                        Txt_Hora_Break1_2.Text = obtenerHoraMinuto(Date.Parse(dtgGeneral.Rows(index).Cells(4).Text))
                        PnlBreak1.Visible = True
                    End If
                    If dtgGeneral.Rows(index).Cells(5).Text = "Break 2" Then
                        Lbl_Cod_Break2.Text = dtgGeneral.Rows(index).Cells(0).Text
                        Txt_Hora_Break2_1.Text = obtenerHoraMinuto(Date.Parse(dtgGeneral.Rows(index).Cells(3).Text))
                        Txt_Hora_Break2_2.Text = obtenerHoraMinuto(Date.Parse(dtgGeneral.Rows(index).Cells(4).Text))
                        PnlBreak2.Visible = True
                    End If
                    If dtgGeneral.Rows(index).Cells(5).Text = "Capacitacion" Then
                        Lbl_Cod_Capacitacion.Text = dtgGeneral.Rows(index).Cells(0).Text
                        Txt_Hora_Capacitacion_1.Text = obtenerHoraMinuto(Date.Parse(dtgGeneral.Rows(index).Cells(3).Text))
                        Txt_Hora_Capacitacion_2.Text = obtenerHoraMinuto(Date.Parse(dtgGeneral.Rows(index).Cells(4).Text))
                        PnlCapacitacion.Visible = True
                    End If
                    If dtgGeneral.Rows(index).Cells(5).Text = "Pre-Turno" Then
                        Lbl_Cod_Pre_turno.Text = dtgGeneral.Rows(index).Cells(0).Text
                        Txt_Pre_Turno_1.Text = obtenerHoraMinuto(Date.Parse(dtgGeneral.Rows(index).Cells(3).Text))
                        Txt_Pre_Turno_2.Text = obtenerHoraMinuto(Date.Parse(dtgGeneral.Rows(index).Cells(4).Text))
                        PnlPreTurno.Visible = True
                    End If

                    Pnl_Message.CssClass = Nothing
                    lblmsg.Text = Nothing
                    x = index - 1
                End If
            Next
            Dim objdatos As New clsgeneral
            x = CInt(CType(Session("permisos"), clsusuario).perfil)
            If objdatos.cargo = "C1583" Or x = 1 Then
                Drl_Hora_Ingreso.Enabled = False
                drlTipoHorario.Enabled = False
                LblCuenta.Enabled = True
                Drl_Hora_Break1_2.Enabled = False
                Drl_Hora_Break1_1.Enabled = False
                Drl_Hora_Break2_2.Enabled = False
                Drl_Hora_Break2_1.Enabled = False
                DrlSegmento.Enabled = False
                DrlHora_Almuerzo_1.Enabled = False
                LblCuenta.Text = dtgGeneral.Rows.Count
                Btn_Buscar_Full_Horarios.Enabled = False
                Btn_Buscar_Horarios_Predeterminado.Enabled = False
            Else
                Drl_Hora_Ingreso.Enabled = True
                drlTipoHorario.Enabled = True
                LblCuenta.Enabled = True
                LblCuenta.Text = dtgGeneral.Rows.Count
                Btn_Buscar_Full_Horarios.Enabled = True
                Btn_Buscar_Horarios_Predeterminado.Enabled = True
            End If


        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
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
    Protected Sub dtgGeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgGeneral.PageIndexChanging
        Try
            dtgGeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            Consulta()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'DRL'S SelectedIndexChanged
    Protected Sub drlTipoHorario_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlTipoHorario.SelectedIndexChanged
        Try
            If drlTipoHorario.SelectedItem.Text = "Descanso" Or drlTipoHorario.SelectedItem.Text = "Suspension" Or drlTipoHorario.SelectedItem.Text = "Aus. Justificada" Or drlTipoHorario.SelectedItem.Text = "Vacaciones" Or drlTipoHorario.SelectedItem.Text = "Contingencia" Or drlTipoHorario.SelectedItem.Text = "Licencia no remunerada" Then
                Ocultar_Herramientas()
                Try
                    Traer_Todos_Los_Horarios()
                    Drl_Hora_Ingreso.SelectedValue = "00:00"
                    Drl_Hora_Salida.SelectedValue = "00:00"
                Catch ex As Exception
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Recuerde Rectificar Las Horas y Horarios Por Favor "
                End Try
                Lbl_Jornada.Text = drlTipoHorario.SelectedItem.Text
            ElseIf drlTipoHorario.SelectedItem.Text = "Laboral" Then
                Btn_Buscar_Horarios_Predeterminado_Click(1, Nothing)
                If Lbl_Cod_Almuerzo.Text <> "" Then
                    PnlAlmuerzo.Visible = True
                End If
                If Lbl_Cod_Break1.Text <> "" Then
                    PnlBreak1.Visible = True
                End If
                If Lbl_Cod_Break2.Text <> "" Then
                    PnlBreak2.Visible = True
                End If
                If Lbl_Cod_Capacitacion.Text <> "" Then
                    PnlCapacitacion.Visible = True
                End If
                If Lbl_Cod_Pre_turno.Text <> "" Then
                    PnlPreTurno.Visible = True
                End If
                Lbl_Jornada.Text = drlTipoHorario.SelectedItem.Text
            End If
            If Lbl_Jornada.Text <> "Jornada Oficina" Then
                PnlAlmuerzo.Visible = False
            Else
                PnlAlmuerzo.Visible = True
            End If

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub Drl_Hora_Ingreso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Hora_Ingreso.SelectedIndexChanged
        Try
            validar_Jornada()
            pre_turno()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub Drl_Hora_Salida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Hora_Salida.SelectedIndexChanged
        Try

            If Drl_Hora_Ingreso.SelectedValue = "- Seleccione -" Then
                Drl_Hora_Salida.SelectedValue = "- Seleccione -"
            ElseIf Drl_Hora_Ingreso.SelectedValue = "06:00" And Drl_Hora_Salida.SelectedValue = "14:00" Then
                Session("Val") = ""
                validar_Jornada()
                pre_turno()
            ElseIf Drl_Hora_Ingreso.SelectedValue = "07:00" And Drl_Hora_Salida.SelectedValue = "15:00" Then
                Session("Val") = ""
                validar_Jornada()
                pre_turno()
            ElseIf Drl_Hora_Ingreso.SelectedValue = "08:00" And Drl_Hora_Salida.SelectedValue = "17:00" Then
                Session("Val") = ""
                validar_Jornada()
                pre_turno()
            ElseIf Drl_Hora_Ingreso.SelectedValue = "13:00" And Drl_Hora_Salida.SelectedValue = "21:00" Then
                Session("Val") = ""
                validar_Jornada()
                pre_turno()
            ElseIf Drl_Hora_Ingreso.SelectedValue = "14:00" And Drl_Hora_Salida.SelectedValue = "22:00" Then
                Session("Val") = ""
                validar_Jornada()
                pre_turno()
            ElseIf Drl_Hora_Ingreso.SelectedValue = "22:00" And Drl_Hora_Salida.SelectedValue = "06:00" Then
                Session("Val") = ""
                validar_Jornada()
                pre_turno()
            Else
                Session("Val") = "FULL"
                Session("ValPerso") = "Si"
                validar_Jornada()
                pre_turno()
                Session("ValPerso") = "No"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub DrlHora_Almuerzo_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DrlHora_Almuerzo_1.SelectedIndexChanged
        Try
            If DrlHora_Almuerzo_1.SelectedValue = "- Seleccione -" Then
                DrlHora_Almuerzo_2.SelectedValue = "- Seleccione -"
            End If
            If (Lbl_Jornada.Text = "Jornada Oficina") Or (Lbl_Jornada.Text = "Personalizada") Then
                If DrlHora_Almuerzo_1.SelectedValue = "12:00" Then
                    DrlHora_Almuerzo_2.SelectedValue = "13:00"
                End If
                If DrlHora_Almuerzo_1.SelectedValue = "13:00" Then
                    DrlHora_Almuerzo_2.SelectedValue = "14:00"
                End If

            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub Drl_Hora_Break1_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Hora_Break1_1.SelectedIndexChanged
        Try
            If Drl_Hora_Break1_1.SelectedValue = "- Seleccione -" Then
                Drl_Hora_Break1_2.SelectedValue = "- Seleccione -"
            End If
            If Drl_Hora_Break1_1.SelectedValue = "00:00" Then
                Drl_Hora_Break1_2.SelectedValue = "00:00"
            End If
            If Lbl_Jornada.Text = "Jornada Oficina" Then
                If Drl_Hora_Break1_1.SelectedValue = "09:45" Then
                    Drl_Hora_Break1_2.SelectedValue = "10:00"
                End If
                If Drl_Hora_Break1_1.SelectedValue = "10:00" Then
                    Drl_Hora_Break1_2.SelectedValue = "10:15"
                End If
                If Drl_Hora_Break1_1.SelectedValue = "10:15" Then
                    Drl_Hora_Break1_2.SelectedValue = "10:30"
                End If
                If Drl_Hora_Break1_1.SelectedValue = "10:30" Then
                    Drl_Hora_Break1_2.SelectedValue = "10:45"
                End If
                If Drl_Hora_Break1_1.SelectedValue = "10:45" Then
                    Drl_Hora_Break1_2.SelectedValue = "11:00"
                End If
            End If
            If Lbl_Jornada.Text = "Jornada Mañana" Then
                If Drl_Hora_Break1_1.SelectedValue = "08:15" Then
                    Drl_Hora_Break1_2.SelectedValue = "08:30"
                End If
                If Drl_Hora_Break1_1.SelectedValue = "08:30" Then
                    Drl_Hora_Break1_2.SelectedValue = "08:45"
                End If
                If Drl_Hora_Break1_1.SelectedValue = "08:45" Then
                    Drl_Hora_Break1_2.SelectedValue = "09:00"
                End If
                If Drl_Hora_Break1_1.SelectedValue = "09:00" Then
                    Drl_Hora_Break1_2.SelectedValue = "09:15"
                End If
                If Drl_Hora_Break1_1.SelectedValue = "09:15" Then
                    Drl_Hora_Break1_2.SelectedValue = "09:30"
                End If
                If Drl_Hora_Break1_1.SelectedValue = "09:30" Then
                    Drl_Hora_Break1_2.SelectedValue = "09:45"
                End If
                If Drl_Hora_Break1_1.SelectedValue = "09:45" Then
                    Drl_Hora_Break1_2.SelectedValue = "10:00"
                End If
                If Drl_Hora_Break1_1.SelectedValue = "10:00" Then
                    Drl_Hora_Break1_2.SelectedValue = "10:15"
                End If
            End If
            If Lbl_Jornada.Text = "Jornada Tarde" Then
                If Drl_Hora_Break1_1.SelectedValue = "10:10" Then
                    Drl_Hora_Break1_2.SelectedValue = "10:15"
                End If
                If Drl_Hora_Break1_1.SelectedValue = "16:00" Then
                    Drl_Hora_Break1_2.SelectedValue = "16:15"
                End If
                If Drl_Hora_Break1_1.SelectedValue = "16:15" Then
                    Drl_Hora_Break1_2.SelectedValue = "16:30"
                End If
                If Drl_Hora_Break1_1.SelectedValue = "16:30" Then
                    Drl_Hora_Break1_2.SelectedValue = "16:45"
                End If
                If Drl_Hora_Break1_1.SelectedValue = "16:45" Then
                    Drl_Hora_Break1_2.SelectedValue = "17:00"
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub Drl_Hora_Break2_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Hora_Break2_1.SelectedIndexChanged
        Try
            If Drl_Hora_Break2_1.SelectedValue = "- Seleccione -" Then
                Drl_Hora_Break2_2.SelectedValue = "- Seleccione -"
            End If

            If Drl_Hora_Break2_1.SelectedValue = "00:00" Then
                Drl_Hora_Break2_2.SelectedValue = "00:00"
            End If

            If Lbl_Jornada.Text = "Jornada Oficina" Then
                '--Break 2
                If Drl_Hora_Break2_1.SelectedValue = "14:45" Then
                    Drl_Hora_Break2_2.SelectedValue = "15:00"
                End If
                If Drl_Hora_Break2_1.SelectedValue = "15:00" Then
                    Drl_Hora_Break2_2.SelectedValue = "15:15"
                End If
                If Drl_Hora_Break2_1.SelectedValue = "15:15" Then
                    Drl_Hora_Break2_2.SelectedValue = "15:30"
                End If
                If Drl_Hora_Break2_1.SelectedValue = "15:30" Then
                    Drl_Hora_Break2_2.SelectedValue = "15:45"
                End If
                If Drl_Hora_Break2_1.SelectedValue = "15:45" Then
                    Drl_Hora_Break2_2.SelectedValue = "16:00"
                End If
            End If

            If Lbl_Jornada.Text = "Jornada Mañana" Then
                '--Break 2
                If Drl_Hora_Break2_1.SelectedValue = "11:15" Then
                    Drl_Hora_Break2_2.SelectedValue = "11:30"
                End If
                If Drl_Hora_Break2_1.SelectedValue = "11:30" Then
                    Drl_Hora_Break2_2.SelectedValue = "11:45"
                End If
                If Drl_Hora_Break2_1.SelectedValue = "11:45" Then
                    Drl_Hora_Break2_2.SelectedValue = "12:00"
                End If
                If Drl_Hora_Break2_1.SelectedValue = "12:00" Then
                    Drl_Hora_Break2_2.SelectedValue = "12:15"
                End If
                If Drl_Hora_Break2_1.SelectedValue = "12:15" Then
                    Drl_Hora_Break2_2.SelectedValue = "12:30"
                End If
                If Drl_Hora_Break2_1.SelectedValue = "12:30" Then
                    Drl_Hora_Break2_2.SelectedValue = "12:45"
                End If
                If Drl_Hora_Break2_1.SelectedValue = "12:45" Then
                    Drl_Hora_Break2_2.SelectedValue = "13:00"
                End If
                If Drl_Hora_Break2_1.SelectedValue = "15:00" Then
                    Drl_Hora_Break2_2.SelectedValue = "15:15"
                End If
            End If

            If Lbl_Jornada.Text = "Jornada Tarde" Then
                '--Break 2
                If Drl_Hora_Break2_1.SelectedValue = "15:00" Then
                    Drl_Hora_Break2_2.SelectedValue = "15:15"
                End If
                If Drl_Hora_Break2_1.SelectedValue = "19:00" Then
                    Drl_Hora_Break2_2.SelectedValue = "19:15"
                End If
                If Drl_Hora_Break2_1.SelectedValue = "19:15" Then
                    Drl_Hora_Break2_2.SelectedValue = "19:30"
                End If
                If Drl_Hora_Break2_1.SelectedValue = "19:30" Then
                    Drl_Hora_Break2_2.SelectedValue = "19:45"
                End If
                If Drl_Hora_Break2_1.SelectedValue = "19:45" Then
                    Drl_Hora_Break2_2.SelectedValue = "20:00"
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    'LOCALES
    Sub Consulta_Solicitudes()
        ObjAdmin.idusuario = CType(Session("permisos"), clsusuario).usuario
        ObjAdmin.codigo = CType(Session("permisos"), clsusuario).Codnom
        Session("dtsB") = ObjAdmin.Consulta_Registro_Horarios()
        dtgGeneral2.DataSource = Session("dtsB")
        dtgGeneral2.DataBind()
        LblCuenta2.Text = ObjAdmin.cantidad
    End Sub
    Public Sub Cargar_Drl()
        Try
            ObjAdmin.tipocont = "1"
            With drlTipoHorario
                .DataSource = ObjAdmin.Consulta_Personal_Cargo
                .DataTextField = "Nombre"
                .DataValueField = "Cod_Validacion_Horario_Complemento"
                .DataBind()
            End With

            ObjAdmin.Validacion = "1"
            With Drl_Hora_Ingreso
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "Fc_Entrada"
                .DataValueField = "Fc_Entrada"
                .DataBind()
            End With

            ObjAdmin.Validacion = "2"
            With Drl_Hora_Salida
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "Fc_Salida"
                .DataValueField = "Fc_Salida"
                .DataBind()
            End With

            'CARGUE DE LISTAS DE BREAK

            ObjAdmin.Validacion = "Tod_Out"
            With Drl_Hora_Break1_2
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "Fc_Salida"
                .DataValueField = "Fc_Salida"
                .DataBind()
            End With

            ObjAdmin.Validacion = "Tod_Out"
            With Drl_Hora_Break2_2
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "Fc_Salida"
                .DataValueField = "Fc_Salida"
                .DataBind()
            End With
            Drl_Hora_Ingreso.SelectedValue = "- Seleccione -"

            ObjAdmin.Validacion = "AlmuerzoIng"
            With DrlHora_Almuerzo_1
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "Fc_Entrada"
                .DataValueField = "Fc_Entrada"
                .DataBind()
            End With
            DrlHora_Almuerzo_1.SelectedValue = "- Seleccione -"
            ObjAdmin.Validacion = "AlmuerzoSal"

            With DrlHora_Almuerzo_2
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "Fc_Salida"
                .DataValueField = "Fc_Salida"
                .DataBind()
            End With
            DrlHora_Almuerzo_2.SelectedValue = "- Seleccione -"

            ObjAdmin.Validacion = "segmento"
            With DrlSegmento
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "segmento"
                .DataValueField = "segmento"
                .DataBind()
            End With

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Public Sub Consulta()
        Try
            If TxtCod_Agente.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese algun codigo de agente por favor"
                Exit Sub
            End If
            If TxtFecha_Ingreso_Consulta.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese La Fecha a Modificar por favor"
                Exit Sub
            End If
            If TxtFecha_Ingreso_Consulta.Text <> "" Then
                ObjAdmin.fcing = TxtFecha_Ingreso_Consulta.Text
            End If
            ObjAdmin.codigo = TxtCod_Agente.Text
            Dim dts As New DataSet
            dts = ObjAdmin.Consulta_Registro_Horarios()
            If dts.Tables(0).Rows.Count > 0 Then
                dtgGeneral.Columns(7).Visible = True
                dtgGeneral.DataSource = dts
                dtgGeneral.DataBind()
                LblCuenta.Text = ObjAdmin.cantidad
                dtgGeneral.Columns(6).Visible = False
                lblmsg.Text = Nothing
            Else
                dtgGeneral.DataSource = Nothing
                dtgGeneral.DataBind()
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>No se encontraron registros"
                LblCuenta.Text = Nothing
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Sub Ocultar_Herramientas()
        PnlAlmuerzo.Visible = False
        PnlBreak1.Visible = False
        PnlBreak2.Visible = False
        PnlCapacitacion.Visible = False
        PnlPreTurno.Visible = False
        PnlSegmmento.Visible = False
    End Sub
    Sub validar_Jornada()
        Try
            If Session("Val") <> "FULL" Then
                PnlAlmuerzo.Visible = False
                If Drl_Hora_Ingreso.SelectedValue = "06:00" Then
                    Drl_Hora_Salida.SelectedValue = "14:00"
                    Lbl_Jornada.Text = "Jornada Mañana"
                    drlTipoHorario.SelectedIndex = 2
                    PnlBreak1.Visible = True
                    PnlBreak2.Visible = True
                    PnlPreTurno.Visible = True
                    PnlSegmmento.Visible = True
                    pre_turno()
                    ObjAdmin.Validacion = "Mañ_1_In"
                    With Drl_Hora_Break1_1
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Entrada"
                        .DataValueField = "Fc_Entrada"
                        .DataBind()
                    End With

                    ObjAdmin.Validacion = "Mañ_2_In"
                    With Drl_Hora_Break2_1
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Entrada"
                        .DataValueField = "Fc_Entrada"
                        .DataBind()
                    End With
                End If

                If Drl_Hora_Ingreso.SelectedValue = "07:00" Then
                    Drl_Hora_Salida.SelectedValue = "15:00"
                    Lbl_Jornada.Text = "Jornada Mañana"
                    drlTipoHorario.SelectedIndex = 2
                    PnlBreak1.Visible = True
                    PnlBreak2.Visible = True
                    PnlPreTurno.Visible = True
                    PnlSegmmento.Visible = True
                    pre_turno()
                    ObjAdmin.Validacion = "Mañ_1_In"
                    With Drl_Hora_Break1_1
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Entrada"
                        .DataValueField = "Fc_Entrada"
                        .DataBind()
                    End With

                    ObjAdmin.Validacion = "Mañ_2_In"
                    With Drl_Hora_Break2_1
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Entrada"
                        .DataValueField = "Fc_Entrada"
                        .DataBind()
                    End With
                End If

                If Drl_Hora_Ingreso.SelectedValue = "08:00" Then
                    Drl_Hora_Salida.SelectedValue = "17:00"
                    Lbl_Jornada.Text = "Jornada Oficina"
                    drlTipoHorario.SelectedIndex = 2
                    PnlBreak1.Visible = True
                    PnlBreak2.Visible = True
                    PnlAlmuerzo.Visible = True
                    PnlPreTurno.Visible = True
                    PnlSegmmento.Visible = True
                    pre_turno()
                    ObjAdmin.Validacion = "AlmuerzoIng"
                    With DrlHora_Almuerzo_1
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Entrada"
                        .DataValueField = "Fc_Entrada"
                        .DataBind()
                    End With
                    DrlHora_Almuerzo_1.SelectedValue = "- Seleccione -"
                    ObjAdmin.Validacion = "AlmuerzoSal"
                    With DrlHora_Almuerzo_2
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Salida"
                        .DataValueField = "Fc_Salida"
                        .DataBind()
                    End With
                    DrlHora_Almuerzo_2.SelectedValue = "- Seleccione -"
                    DrlHora_Almuerzo_2.Enabled = False
                    ObjAdmin.Validacion = "Ofi_1_In"
                    With Drl_Hora_Break1_1
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Entrada"
                        .DataValueField = "Fc_Entrada"
                        .DataBind()
                    End With
                    ObjAdmin.Validacion = "Ofi_2_In"
                    With Drl_Hora_Break2_1
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Entrada"
                        .DataValueField = "Fc_Entrada"
                        .DataBind()
                    End With
                End If

                If Drl_Hora_Ingreso.SelectedValue = "13:00" Then
                    Drl_Hora_Salida.SelectedValue = "21:00"
                    Lbl_Jornada.Text = "Jornada Tarde"
                    drlTipoHorario.SelectedIndex = 2
                    PnlBreak1.Visible = True
                    PnlBreak2.Visible = True
                    PnlPreTurno.Visible = True
                    PnlSegmmento.Visible = True
                    pre_turno()
                    ObjAdmin.Validacion = "Tar_1_In"
                    With Drl_Hora_Break1_1
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Entrada"
                        .DataValueField = "Fc_Entrada"
                        .DataBind()
                    End With
                    ObjAdmin.Validacion = "Tar_2_In"
                    With Drl_Hora_Break2_1
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Entrada"
                        .DataValueField = "Fc_Entrada"
                        .DataBind()
                    End With
                End If
                If Drl_Hora_Ingreso.SelectedValue = "14:00" Then
                    Drl_Hora_Salida.SelectedValue = "22:00"
                    Lbl_Jornada.Text = "Jornada Tarde"
                    drlTipoHorario.SelectedIndex = 2
                    PnlBreak1.Visible = True
                    PnlBreak2.Visible = True
                    PnlPreTurno.Visible = True
                    PnlSegmmento.Visible = True
                    pre_turno()
                    ObjAdmin.Validacion = "Tar_1_In"
                    With Drl_Hora_Break1_1
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Entrada"
                        .DataValueField = "Fc_Entrada"
                        .DataBind()
                    End With
                    ObjAdmin.Validacion = "Tar_2_In"
                    With Drl_Hora_Break2_1
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Entrada"
                        .DataValueField = "Fc_Entrada"
                        .DataBind()
                    End With
                End If
                If Drl_Hora_Ingreso.SelectedValue = "22:00" Then
                    Drl_Hora_Salida.SelectedValue = "06:00"
                    Lbl_Jornada.Text = "Jornada Noche"
                    drlTipoHorario.SelectedIndex = 2
                    PnlBreak1.Visible = False
                    PnlBreak2.Visible = False
                    PnlPreTurno.Visible = True
                    PnlSegmmento.Visible = True
                    pre_turno()
                    'ObjAdmin.Validacion = "Tar_1_In"
                    'With Drl_Hora_Break1_1
                    '    .DataSource = ObjAdmin.Consulta_Horarios
                    '    .DataTextField = "Fc_Entrada"
                    '    .DataValueField = "Fc_Entrada"
                    '    .DataBind()
                    'End With
                    'ObjAdmin.Validacion = "Tar_2_In"
                    'With Drl_Hora_Break2_1
                    '    .DataSource = ObjAdmin.Consulta_Horarios
                    '    .DataTextField = "Fc_Entrada"
                    '    .DataValueField = "Fc_Entrada"
                    '    .DataBind()
                    'End With
                End If
                If Drl_Hora_Ingreso.SelectedValue = "00:00" Then
                    Drl_Hora_Salida.SelectedValue = "00:00"
                    Lbl_Jornada.Text = "Descanso"
                    drlTipoHorario.SelectedIndex = 1
                    PnlBreak1.Visible = False
                    PnlBreak2.Visible = False
                    PnlPreTurno.Visible = False
                    PnlSegmmento.Visible = False
                    pre_turno()
                    ObjAdmin.Validacion = "Des_In"
                    With Drl_Hora_Break1_1
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Entrada"
                        .DataValueField = "Fc_Entrada"
                        .DataBind()
                    End With

                    ObjAdmin.Validacion = "Des_In"
                    With Drl_Hora_Break2_1
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Entrada"
                        .DataValueField = "Fc_Entrada"
                        .DataBind()
                    End With
                End If
            Else
                If Session("ValPerso") = "Si" Then

                Else
                    Drl_Hora_Salida.SelectedValue = "- Seleccione -"
                End If


                Lbl_Jornada.Text = "Personalizada"
                    PnlAlmuerzo.Visible = True
                    ObjAdmin.Validacion = "Tod_In"
                    With Drl_Hora_Break1_1
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Entrada"
                        .DataValueField = "Fc_Entrada"
                        .DataBind()
                    End With
                    With Drl_Hora_Break2_1
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Entrada"
                        .DataValueField = "Fc_Entrada"
                        .DataBind()
                    End With
                    ObjAdmin.Validacion = "AlmuerzoIng"
                    With DrlHora_Almuerzo_1
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Entrada"
                        .DataValueField = "Fc_Entrada"
                        .DataBind()
                    End With
                    DrlHora_Almuerzo_1.SelectedValue = "- Seleccione -"
                    ObjAdmin.Validacion = "AlmuerzoSal"

                    With DrlHora_Almuerzo_2
                        .DataSource = ObjAdmin.Consulta_Horarios
                        .DataTextField = "Fc_Salida"
                        .DataValueField = "Fc_Salida"
                        .DataBind()
                    End With
                    DrlHora_Almuerzo_2.SelectedValue = "- Seleccione -"
                End If
                If Drl_Hora_Ingreso.SelectedValue = "- Seleccione -" Then
                Drl_Hora_Salida.SelectedValue = "- Seleccione -"
            End If
            If Lbl_Jornada.Text = "Personalizada" Then
                Drl_Hora_Break1_2.Enabled = True
                Drl_Hora_Break2_2.Enabled = True
            Else
                Drl_Hora_Break1_2.Enabled = False
                Drl_Hora_Break2_2.Enabled = False
            End If
            Drl_Hora_Break1_1.SelectedValue = "- Seleccione -"
            Drl_Hora_Break1_2.SelectedValue = "- Seleccione -"
            Drl_Hora_Break2_1.SelectedValue = "- Seleccione -"
            Drl_Hora_Break2_2.SelectedValue = "- Seleccione -"
        Catch ex As Exception
            Drl_Hora_Salida.SelectedValue = "- Seleccione -"

            Lbl_Jornada.Text = "Personalizada"
            ObjAdmin.Validacion = "Tod_In"
            With Drl_Hora_Break1_1
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "Fc_Entrada"
                .DataValueField = "Fc_Entrada"
                .DataBind()
            End With
            With Drl_Hora_Break2_1
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "Fc_Entrada"
                .DataValueField = "Fc_Entrada"
                .DataBind()
            End With
        End Try
    End Sub
    Sub Traer_Todos_Los_Horarios()
        ObjAdmin.Validacion = "Tod_In"
        With Drl_Hora_Break1_1
            .DataSource = ObjAdmin.Consulta_Horarios
            .DataTextField = "Fc_Entrada"
            .DataValueField = "Fc_Entrada"
            .DataBind()
        End With
        With Drl_Hora_Break2_1
            .DataSource = ObjAdmin.Consulta_Horarios
            .DataTextField = "Fc_Entrada"
            .DataValueField = "Fc_Entrada"
            .DataBind()
        End With

        ObjAdmin.Validacion = "Tod_Out"
        With Drl_Hora_Break1_2
            .DataSource = ObjAdmin.Consulta_Horarios
            .DataTextField = "Fc_Salida"
            .DataValueField = "Fc_Salida"
            .DataBind()
        End With
        With Drl_Hora_Break2_2
            .DataSource = ObjAdmin.Consulta_Horarios
            .DataTextField = "Fc_Salida"
            .DataValueField = "Fc_Salida"
            .DataBind()
        End With

        ObjAdmin.Validacion = "Tod_In"
        With Drl_Hora_Ingreso
            .DataSource = ObjAdmin.Consulta_Horarios
            .DataTextField = "Fc_Entrada"
            .DataValueField = "Fc_Entrada"
            .DataBind()
        End With

        ObjAdmin.Validacion = "Tod_Out"
        With Drl_Hora_Salida
            .DataSource = ObjAdmin.Consulta_Horarios
            .DataTextField = "Fc_Salida"
            .DataValueField = "Fc_Salida"
            .DataBind()
        End With
        ObjAdmin.Validacion = "AlmuerzoIng"
        With DrlHora_Almuerzo_1
            .DataSource = ObjAdmin.Consulta_Horarios
            .DataTextField = "Fc_Entrada"
            .DataValueField = "Fc_Entrada"
            .DataBind()
        End With
        ObjAdmin.Validacion = "AlmuerzoSal"
        With DrlHora_Almuerzo_2
            .DataSource = ObjAdmin.Consulta_Horarios
            .DataTextField = "Fc_Salida"
            .DataValueField = "Fc_Salida"
            .DataBind()
        End With
        DrlHora_Almuerzo_2.SelectedValue = "- Seleccione -"
    End Sub
    Sub pre_turno()
        Try
            Txt_Pre_Turno_1.Text = Drl_Hora_Ingreso.SelectedValue
            If Drl_Hora_Ingreso.SelectedValue = "13:00" Then
                Txt_Pre_Turno_2.Text = "13:15"
            End If
            If Drl_Hora_Ingreso.SelectedValue = "06:00" Then
                Txt_Pre_Turno_2.Text = "06:15"
            End If
            If Drl_Hora_Ingreso.SelectedValue = "07:00" Then
                Txt_Pre_Turno_2.Text = "07:15"
            End If
            If Drl_Hora_Ingreso.SelectedValue = "08:00" Then
                Txt_Pre_Turno_2.Text = "08:15"
            End If
            If Drl_Hora_Ingreso.SelectedValue = "- Seleccione -" Then
                Txt_Pre_Turno_2.Text = ""
            End If
            If Drl_Hora_Ingreso.SelectedValue = "00:00" Then
                Txt_Pre_Turno_2.Text = "00:00"
            End If
            If Drl_Hora_Salida.SelectedValue = "- Seleccione -" Then
                Drl_Hora_Salida.Enabled = True
            End If
            If Drl_Hora_Ingreso.SelectedValue <> "- Seleccione -" Then
                Dim HoraAux As String
                Dim minutoagg As String
                If (Drl_Hora_Ingreso.SelectedValue) = "00:00" Then
                    Txt_Pre_Turno_2.Text = "00:00"
                ElseIf (Left(Drl_Hora_Ingreso.SelectedValue, 1)) = "0" Then
                    HoraAux = CInt(Replace((Txt_Pre_Turno_1.Text), ":", ""))
                    HoraAux = HoraAux + 15
                    minutoagg = "0" & Left(HoraAux, 1) & ":" & Right(HoraAux, 2)
                    If Right(minutoagg, 2) = "60" Then
                        minutoagg = CInt(Left(minutoagg, 2)) + 1 & ":" & "00"
                    End If
                    HoraAux = FormatDateTime(minutoagg, DateFormat.ShortTime)
                    Txt_Pre_Turno_2.Text = HoraAux
                    Exit Sub
                Else
                    HoraAux = CInt(Replace((Txt_Pre_Turno_1.Text), ":", ""))
                    HoraAux = HoraAux + 15
                    minutoagg = Left(HoraAux, 2) & ":" & Right(HoraAux, 2)
                    If Right(minutoagg, 2) = "60" Then
                        minutoagg = CInt(Left(minutoagg, 2)) + 1 & ":" & "00"
                    End If
                    HoraAux = FormatDateTime(minutoagg, DateFormat.ShortTime)
                    Txt_Pre_Turno_2.Text = HoraAux
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Sub limpiar()
        LblCod_Registro.Text = ""
        Lbl_Tipo_Horario.Text = ""
        TxtFecha_Ingreso.Text = ""
        LblCod_Agente.Text = ""
        Drl_Hora_Ingreso.SelectedValue = "- Seleccione -"
        Drl_Hora_Salida.SelectedValue = "- Seleccione -"
        drlTipoHorario.SelectedValue = "1"
        Lbl_Jornada.Text = ""
        Lbl_Cod_Almuerzo.Text = ""
        DrlHora_Almuerzo_1.SelectedValue = "- Seleccione -"
        DrlHora_Almuerzo_2.SelectedValue = "- Seleccione -"
        Lbl_Cod_Break1.Text = ""
        Drl_Hora_Break1_1.SelectedValue = "- Seleccione -"
        Drl_Hora_Break1_2.SelectedValue = "- Seleccione -"
        Txt_Hora_Break1_1.Text = ""
        Txt_Hora_Break1_2.Text = ""
        Lbl_Cod_Break2.Text = ""
        Drl_Hora_Break2_1.SelectedValue = "- Seleccione -"
        Drl_Hora_Break2_2.SelectedValue = "- Seleccione -"
        Txt_Hora_Break2_1.Text = ""
        Txt_Hora_Break2_2.Text = ""
        Lbl_Cod_Capacitacion.Text = ""
        Txt_Hora_Capacitacion_1.Text = ""
        Txt_Hora_Capacitacion_2.Text = ""
        Lbl_Cod_Pre_turno.Text = ""
        Txt_Pre_Turno_1.Text = ""
        Txt_Pre_Turno_2.Text = ""
        Ocultar_Herramientas()
        Drl_Hora_Ingreso.Enabled = False
        Drl_Hora_Salida.Enabled = False
        drlTipoHorario.Enabled = False
        LblCuenta.Enabled = False
        TxtFecha_Ingreso.Enabled = False
        Txt_Hora_Entrada_Antigua.Text = ""
        Txt_Hora_Salida_Antigua.Text = ""
        Btn_Buscar_Full_Horarios.Enabled = False
        Btn_Buscar_Horarios_Predeterminado.Enabled = False
        PnlSegmmento.Visible = False
    End Sub
    Dim A As System.Web.UI.WebControls.GridViewCommandEventArgs = Nothing
    Dim B As Object
    Protected Sub dtggeneral2_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtgGeneral2.RowCommand
        Try
            limpiar()
            ObjAdmin.Validacion = "1"
            With Drl_Hora_Ingreso
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "Fc_Entrada"
                .DataValueField = "Fc_Entrada"
                .DataBind()
            End With
            ObjAdmin.Validacion = "2"
            With Drl_Hora_Salida
                .DataSource = ObjAdmin.Consulta_Horarios
                .DataTextField = "Fc_Salida"
                .DataValueField = "Fc_Salida"
                .DataBind()
            End With
            Drl_Hora_Salida.Enabled = False
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim x As Integer = 0
            '/******************************************/
            If e.CommandName = "Seleccione" Then
                ObjAdmin.fcing = dtgGeneral2.Rows(index).Cells(0).Text
                ObjAdmin.idusuario = dtgGeneral2.Rows(index).Cells(2).Text
                ObjAdmin.codigo = dtgGeneral2.Rows(index).Cells(3).Text
                ObjAdmin.fcregistro = dtgGeneral2.Rows(index).Cells(1).Text
                ObjAdmin.Validacion = "Solicitudes_Cambio_Horario"
                With Dtg_Solicitudes
                    Session("Detalle_Solicitud") = ObjAdmin.Consulta_Registro_Horarios
                    .DataSource = Session("Detalle_Solicitud")
                    .DataBind()
                End With
                Btn_Buscar_Full_Horarios_Click(sender, e)
            End If
            '/*****************************************/
            For Each row As GridViewRow In Dtg_Solicitudes.Rows
                index = x
                If e.CommandName = "Seleccione" Then
                    'If Date.Parse(Dtg_Solicitudes.Rows(index).Cells(3).Text).Date <= Fecha.Date Then
                    '    lblmsg.Text = "Solo puede seleccionar los registros que tengan fechas mayores a las de: " + Fecha.Date
                    '    Exit Sub
                    'End If

                    If Dtg_Solicitudes.Rows(index).Cells(5).Text = "Laboral" Or Dtg_Solicitudes.Rows(index).Cells(5).Text = "Descanso" Or Dtg_Solicitudes.Rows(index).Cells(5).Text = "Vacaciones" Or Dtg_Solicitudes.Rows(index).Cells(5).Text = "Aus. Justificada" Or Dtg_Solicitudes.Rows(index).Cells(5).Text = "Suspension" Then
                        LblCod_Registro.Text = Dtg_Solicitudes.Rows(index).Cells(0).Text
                        LblCod_Agente.Text = Dtg_Solicitudes.Rows(index).Cells(2).Text
                        TxtFecha_Ingreso.Text = Date.Parse(Dtg_Solicitudes.Rows(index).Cells(3).Text).Date
                        Txt_Hora_Entrada_Antigua.Text = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(7).Text))
                        Txt_Hora_Salida_Antigua.Text = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(8).Text))
                        Try
                            ObjAdmin.Validacion = "Tod_Out"
                            Drl_Hora_Salida.DataSource = ObjAdmin.Consulta_Horarios()
                            Drl_Hora_Salida.DataBind()
                            Drl_Hora_Ingreso.SelectedValue = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(3).Text))
                            Drl_Hora_Salida.SelectedValue = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(4).Text))
                        Catch ex As Exception
                            With Drl_Hora_Ingreso
                                .DataSource = Nothing
                                .DataTextField = Nothing
                                .DataValueField = Nothing
                                .DataBind()
                            End With
                            Traer_Todos_Los_Horarios()
                        End Try
                        If Dtg_Solicitudes.Rows(index).Cells(5).Text = "Vacaciones" Then
                            Drl_Hora_Salida.SelectedValue = "00:00"
                            Lbl_Jornada.Text = "Vacaciones"
                        ElseIf Dtg_Solicitudes.Rows(index).Cells(5).Text = "Aus. Justificada" Then
                            Drl_Hora_Salida.SelectedValue = "00:00"
                            Lbl_Jornada.Text = "Aus. Justificada"
                        ElseIf Dtg_Solicitudes.Rows(index).Cells(5).Text = "Suspension" Then
                            Drl_Hora_Salida.SelectedValue = "00:00"
                            Lbl_Jornada.Text = "Suspension"
                        ElseIf Dtg_Solicitudes.Rows(index).Cells(5).Text = "Descanso" Then
                            Drl_Hora_Salida.SelectedValue = "00:00"
                            Lbl_Jornada.Text = "Descanso"
                        Else
                            ObjAdmin.fcing = Drl_Hora_Ingreso.SelectedValue
                            ObjAdmin.fcretiro = Drl_Hora_Salida.SelectedValue
                            ObjAdmin.Validacion = "VerificarJornada"
                            ObjAdmin.Consulta_Horarios()
                            If ObjAdmin.fcnovedad = "Mañana" Or ObjAdmin.fcnovedad = "Oficina" Or ObjAdmin.fcnovedad = "Tarde" Or ObjAdmin.fcnovedad = "Noche" Or ObjAdmin.fcnovedad = "Descanso" Then
                                Session("Val") = ""
                                validar_Jornada()
                            Else
                                Session("Val") = "FULL"
                                validar_Jornada()
                            End If
                            ObjAdmin.Validacion = "segmento"
                            With DrlSegmento
                                .DataSource = ObjAdmin.Consulta_Horarios
                                .DataTextField = "segmento"
                                .DataValueField = "segmento"
                                .DataBind()
                            End With
                            'If ObjAdmin.fcnovedad = "Mañana" And ObjAdmin.fcnovedad = "Oficina" And ObjAdmin.fcnovedad = "Tarde" And ObjAdmin.fcnovedad = "Noche" And ObjAdmin.fcnovedad = "Personalizada" Then
                            If Dtg_Solicitudes.Rows(index).Cells(10).Text <> "" And Dtg_Solicitudes.Rows(index).Cells(10).Text <> " " And Dtg_Solicitudes.Rows(index).Cells(10).Text <> "&nbsp;" Then

                                LblSegmento1.Text = Dtg_Solicitudes.Rows(index).Cells(0).Text
                                DrlSegmento.SelectedValue = ObjAdmin.Segmento
                                'DrlSegmento.SelectedValue = Dtg_Solicitudes.Rows(index).Cells(10).Text
                                DrlSegmento.Enabled = False
                                LblSegmento.Text = Dtg_Solicitudes.Rows(index).Cells(11).Text
                                PnlSegmmento.Visible = True
                            Else
                                LblSegmento1.Text = Nothing
                                    PnlSegmmento.Visible = False
                                End If
                            'Else
                            '    LblSegmento1.Text = Nothing
                            '    PnlSegmmento.Visible = False
                            'End If

                            Drl_Hora_Ingreso.SelectedValue = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(3).Text))
                            Drl_Hora_Salida.SelectedValue = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(4).Text))
                        End If
                        drlTipoHorario.SelectedValue = Dtg_Solicitudes.Rows(index).Cells(6).Text
                        Lbl_Tipo_Horario.Text = Dtg_Solicitudes.Rows(index).Cells(5).Text
                        ''valida si es 00:00 significa que se cambia de una jornada laborar a un descanso
                        If obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(7).Text)) = "00:00" And obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(8).Text)) = "00:00" Then
                            Session("ValidarHorariosDescanso") = "CambioAdes"
                        End If
                        ''valida si se va a cambiar de descanso a laboral
                        If Dtg_Solicitudes.Rows(index).Cells(5).Text = "Descanso" And obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(3).Text)) = "00:00" And obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(4).Text)) = "00:00" Then
                            Session("ValidarHorariosDescanso") = "CambioAlab"
                        End If
                    End If

                    If Dtg_Solicitudes.Rows(index).Cells(5).Text = "Almuerzo" Then
                        If Session("ValidarHorariosDescanso") = "CambioAdes" Then
                            Lbl_Cod_Almuerzo.Text = Dtg_Solicitudes.Rows(index).Cells(9).Text
                        Else
                            If Dtg_Solicitudes.Rows(index).Cells(0).Text = "&nbsp;" Then
                                Session("AgregarAlmuerzo") = "Si"
                                Lbl_Cod_Almuerzo.Text = Dtg_Solicitudes.Rows(index).Cells(9).Text
                                DrlHora_Almuerzo_1.Enabled = False
                                DrlHora_Almuerzo_2.Enabled = False
                            Else
                                Lbl_Cod_Almuerzo.Text = Dtg_Solicitudes.Rows(index).Cells(0).Text
                            End If
                        End If
                        If obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(3).Text)) = "" Or obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(3).Text)) = "00:00" Then
                            DrlHora_Almuerzo_1.SelectedValue = Nothing
                            DrlHora_Almuerzo_2.SelectedValue = Nothing
                            PnlAlmuerzo.Visible = False
                        Else
                            DrlHora_Almuerzo_1.SelectedValue = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(3).Text))
                            DrlHora_Almuerzo_2.SelectedValue = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(4).Text))
                        End If

                        ' PnlAlmuerzo.Visible = True
                    End If
                        If Dtg_Solicitudes.Rows(index).Cells(5).Text = "Break 1" Then
                        If Session("ValidarHorariosDescanso") = "CambioAdes" Then
                            Lbl_Cod_Break1.Text = Dtg_Solicitudes.Rows(index).Cells(9).Text
                            Txt_Hora_Break1_1.Text = "00:00"
                            Txt_Hora_Break1_2.Text = "00:00"
                        Else
                            If Dtg_Solicitudes.Rows(index).Cells(0).Text = "&nbsp;" Then
                                Session("AddBreak1") = "Si"
                                Lbl_Cod_Break1.Text = Dtg_Solicitudes.Rows(index).Cells(9).Text
                                Txt_Hora_Break1_1.Enabled = False
                                Txt_Hora_Break1_2.Enabled = False
                            Else
                                Lbl_Cod_Break1.Text = Dtg_Solicitudes.Rows(index).Cells(0).Text
                                Txt_Hora_Break1_1.Text = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(7).Text))
                                Txt_Hora_Break1_2.Text = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(8).Text))
                            End If
                        End If
                        Drl_Hora_Break1_1.SelectedValue = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(3).Text))
                        Drl_Hora_Break1_2.SelectedValue = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(4).Text))
                        PnlBreak1.Visible = True
                    End If
                    If Dtg_Solicitudes.Rows(index).Cells(5).Text = "Break 2" Then
                        If Session("ValidarHorariosDescanso") = "CambioAdes" Then
                            Lbl_Cod_Break2.Text = Dtg_Solicitudes.Rows(index).Cells(9).Text
                            Txt_Hora_Break2_1.Text = "00:00"
                            Txt_Hora_Break2_2.Text = "00:00"
                        Else
                            If Dtg_Solicitudes.Rows(index).Cells(0).Text = "&nbsp;" Then
                                Session("AddBreak2") = "Si"
                                Lbl_Cod_Break2.Text = Dtg_Solicitudes.Rows(index).Cells(9).Text
                                Txt_Hora_Break2_1.Enabled = False
                                Txt_Hora_Break2_2.Enabled = False
                            Else
                                Lbl_Cod_Break2.Text = Dtg_Solicitudes.Rows(index).Cells(0).Text
                                Txt_Hora_Break2_1.Text = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(7).Text))
                                Txt_Hora_Break2_2.Text = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(8).Text))
                            End If
                        End If
                        Drl_Hora_Break2_1.SelectedValue = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(3).Text))
                        Drl_Hora_Break2_2.SelectedValue = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(4).Text))
                        PnlBreak2.Visible = True
                    End If
                    If Dtg_Solicitudes.Rows(index).Cells(5).Text = "Capacitacion" Then
                        If Session("ValidarHorariosDescanso") = "CambioAdes" Then
                            Lbl_Cod_Capacitacion.Text = Dtg_Solicitudes.Rows(index).Cells(9).Text
                            Lbl_Cod_Capacitacion.Text = "a"
                        Else
                            If Dtg_Solicitudes.Rows(index).Cells(0).Text = "&nbsp;" Then
                                Session("cap") = "Si"
                                Lbl_Cod_Capacitacion.Text = Dtg_Solicitudes.Rows(index).Cells(9).Text
                            Else
                                Lbl_Cod_Capacitacion.Text = Dtg_Solicitudes.Rows(index).Cells(0).Text
                            End If
                        End If
                        Txt_Hora_Capacitacion_1.Text = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(3).Text))
                        Txt_Hora_Capacitacion_2.Text = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(4).Text))
                        PnlCapacitacion.Visible = True
                    End If
                    If Dtg_Solicitudes.Rows(index).Cells(5).Text = "Pre-Turno" Then
                        If Session("ValidarHorariosDescanso") = "CambioAdes" Then
                            Lbl_Cod_Pre_turno.Text = Dtg_Solicitudes.Rows(index).Cells(9).Text
                        Else
                            If Dtg_Solicitudes.Rows(index).Cells(0).Text = "&nbsp;" Then
                                Session("pre") = "Si"
                                Lbl_Cod_Pre_turno.Text = Dtg_Solicitudes.Rows(index).Cells(9).Text
                            Else
                                Lbl_Cod_Pre_turno.Text = Dtg_Solicitudes.Rows(index).Cells(0).Text
                            End If
                        End If
                        Txt_Pre_Turno_1.Text = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(3).Text))
                        Txt_Pre_Turno_2.Text = obtenerHoraMinuto(Date.Parse(Dtg_Solicitudes.Rows(index).Cells(4).Text))
                        PnlPreTurno.Visible = True
                    End If
                    lblmsg.Text = Nothing
                    x = index + 1
                End If
            Next
            Drl_Hora_Ingreso.Enabled = False
            drlTipoHorario.Enabled = False
            Btn_Buscar_Full_Horarios.Enabled = False
            Btn_Buscar_Horarios_Predeterminado.Enabled = False
            Drl_Hora_Salida.Enabled = False
            Drl_Hora_Break1_1.Enabled = False
            Drl_Hora_Break1_2.Enabled = False
            Drl_Hora_Break2_1.Enabled = False
            Drl_Hora_Break2_2.Enabled = False
            Txt_Hora_Capacitacion_1.Enabled = False
            Txt_Hora_Capacitacion_2.Enabled = False
            DrlHora_Almuerzo_1.Enabled = False
            DrlHora_Almuerzo_2.Enabled = False
            Txt_Pre_Turno_2.Enabled = False
            BtnRechazar.Visible = True
            With dtgGeneral2
                ObjAdmin.Validacion = "Permitir"
                .DataSource = ObjAdmin.Consulta_Registro_Horarios
                .DataBind()
                LblCuenta2.Text = ObjAdmin.cantidad
            End With
            With Dtg_Solicitudes
                .DataSource = Nothing
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
    Protected Sub BtnRechazar_Click(sender As Object, e As EventArgs) Handles BtnRechazar.Click
        Try
            ObjAdmin.Validacion = "Rechazado"
            If LblCod_Registro.Text = Nothing Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Seleccione una solicitud antes de rechazarla!"
                Exit Sub
            Else
                ObjAdmin.Cod_Archivo = LblCod_Registro.Text
            End If

            ObjAdmin.Actualizacion_Registro_Horario()
            'Validar Almuerzo
            If Lbl_Cod_Almuerzo.Text <> "" And Lbl_Jornada.Text = "Jornada Oficina" And DrlHora_Almuerzo_1.SelectedValue = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese la hora de Almuerzo Por favor"
                Exit Sub
            Else
                If Lbl_Cod_Almuerzo.Text <> "" Then
                    ObjAdmin.Cod_Archivo = Lbl_Cod_Almuerzo.Text
                    ObjAdmin.Actualizacion_Registro_Horario()
                End If
            End If
            If Lbl_Cod_Break1.Text <> "" Then
                ObjAdmin.Cod_Archivo = Lbl_Cod_Break1.Text
                ObjAdmin.Actualizacion_Registro_Horario()
            End If
            If Lbl_Cod_Break2.Text <> "" Then
                ObjAdmin.Cod_Archivo = Lbl_Cod_Break2.Text
                ObjAdmin.Actualizacion_Registro_Horario()
            End If
            'validar capacitacion 
            If Lbl_Cod_Capacitacion.Text <> "" Then
                ObjAdmin.Cod_Archivo = Lbl_Cod_Capacitacion.Text
                ObjAdmin.Actualizacion_Registro_Horario()
            End If
            'validar Pre - Turno
            If Lbl_Cod_Pre_turno.Text <> "" Then
                ObjAdmin.Cod_Archivo = Lbl_Cod_Pre_turno.Text
                ObjAdmin.Actualizacion_Registro_Horario()
            End If
            limpiar()
            Ocultar_Herramientas()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Se rechazo la solicitud correctamente!"
            ObjAdmin.Validacion = "Permitir"
            Consulta_Solicitudes()
            With Dtg_Solicitudes
                .DataSource = Nothing
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub

    Protected Sub dtgGeneral2_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtgGeneral2.PageIndexChanging
        Try
            dtgGeneral2.DataSource = Session("dtsB")
            dtgGeneral2.PageIndex = e.NewPageIndex
            dtgGeneral2.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
End Class