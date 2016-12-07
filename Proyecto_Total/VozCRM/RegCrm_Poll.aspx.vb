Public Class RegCrm_Poll
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                Cargar_Drl()

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
    Public Sub Cargar_Drl()
        Dim ObjVoz As New clsvoz
        ObjVoz.Validacion = "Estado_Encuesta"
        With drltipificacionll
            .DataSource = ObjVoz.ConsultadrlBienvenidaDatos
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        ObjVoz.Validacion = "Ha_Tenido_Dificultad_Datos"
        With DrlHa_Tenido_Dificultad_Datos
            .DataSource = ObjVoz.Consulta_Listas_Poll_Perception_Service
            .DataTextField = "Nombre_Poll_P_S_Des_Option"
            .DataValueField = "Cod_Poll_P_S_Des_Option"
            .DataBind()
        End With
        ObjVoz.Validacion = "Ha_Tenido_Dificultad_Voz"
        With DrlHa_Tenido_Dificultad_Voz
            .DataSource = ObjVoz.Consulta_Listas_Poll_Perception_Service
            .DataTextField = "Nombre_Poll_P_S_Des_Option"
            .DataValueField = "Cod_Poll_P_S_Des_Option"
            .DataBind()
        End With
        ObjVoz.Validacion = "Cual_Es_Mas_Molesta_Datos"
        With DrlCual_Es_Mas_Molesta_Datos
            .DataSource = ObjVoz.Consulta_Listas_Poll_Perception_Service
            .DataTextField = "Nombre_Poll_P_S_Des_Option"
            .DataValueField = "Cod_Poll_P_S_Des_Option"
            .DataBind()
        End With
        ObjVoz.Validacion = "Cual_Es_Mas_Molesta_Voz"
        With DrlCual_Es_Mas_Molesta_Voz
            .DataSource = ObjVoz.Consulta_Listas_Poll_Perception_Service
            .DataTextField = "Nombre_Poll_P_S_Des_Option"
            .DataValueField = "Cod_Poll_P_S_Des_Option"
            .DataBind()
        End With
        ObjVoz.Validacion = "Razones_Pricipales_No_Recomiende_Servicio"
        With Drl_Razones_Pricipales_No_Recomiende_Servicio
            .DataSource = ObjVoz.Consulta_Listas_Poll_Perception_Service
            .DataTextField = "Nombre_Poll_P_S_Des_Option"
            .DataValueField = "Cod_Poll_P_S_Des_Option"
            .DataBind()
        End With
        ObjVoz.Validacion = "Razones_Pricipales_Si_Recomiende_Servicio"
        With Drl_Razones_Pricipales_Si_Recomiende_Servicio
            .DataSource = ObjVoz.Consulta_Listas_Poll_Perception_Service
            .DataTextField = "Nombre_Poll_P_S_Des_Option"
            .DataValueField = "Cod_Poll_P_S_Des_Option"
            .DataBind()
        End With

        ObjVoz.Validacion = "Motivos_de_culminacion"
        With Drl_motivos_culminacion
            .DataSource = ObjVoz.Consulta_Listas_Poll_Perception_Service
            .DataTextField = "Nombre_Poll_P_S_Des_Option"
            .DataValueField = "Cod_Poll_P_S_Des_Option"
            .DataBind()
        End With

        ObjVoz.Validacion = "Intencion_De_Usuario"
        With Drl_Intension_Del_Usuario
            .DataSource = ObjVoz.Consulta_Listas_Poll_Perception_Service
            .DataTextField = "Nombre_Poll_P_S_Des_Option"
            .DataValueField = "Nombre_Poll_P_S_Des_Option"
            .DataBind()
        End With



    End Sub

    Protected Sub BtnAgregar_No_Probable_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAgregar_No_Probable.Click
        Try
            If Drl_Razones_Pricipales_No_Recomiende_Servicio.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Antes de agregar seleccione una opcion"
                txtcaso.Focus()
                Exit Sub
            End If
            If LblNo_Probable1.Text <> "" And LblNo_Probable2.Text <> "" And LblNo_Probable3.Text <> "" Then
                lblmsg.Text = "Solo puede elegir hasta tres respuestas"
                txtcaso.Focus()
                Exit Sub
            End If
            If LblNo_Probable1.Text = ("1)" + Drl_Razones_Pricipales_No_Recomiende_Servicio.SelectedItem.Text) Or LblNo_Probable2.Text = ("2)" + Drl_Razones_Pricipales_No_Recomiende_Servicio.SelectedItem.Text) Or LblNo_Probable3.Text = ("3)" + Drl_Razones_Pricipales_No_Recomiende_Servicio.SelectedItem.Text) Then
                lblmsg.Text = "La opcion acutal ya fue agregada verifique"
                txtcaso.Focus()
                Exit Sub
            End If
            lblmsg.Text = ""
            If LblNo_Probable1.Text = "" Then
                LblNo_Probable_Valor1.Text = Drl_Razones_Pricipales_No_Recomiende_Servicio.SelectedValue
                LblNo_Probable1.Text = "1)" + Drl_Razones_Pricipales_No_Recomiende_Servicio.SelectedItem.Text
                BtnRegresar_No_Probable.Visible = True
                Exit Sub
            End If
            If LblNo_Probable2.Text = "" Then
                LblNo_Probable_Valor2.Text = Drl_Razones_Pricipales_No_Recomiende_Servicio.SelectedValue
                LblNo_Probable2.Text = "2)" + Drl_Razones_Pricipales_No_Recomiende_Servicio.SelectedItem.Text
                Exit Sub
            End If
            If LblNo_Probable3.Text = "" Then
                LblNo_Probable_Valor3.Text = Drl_Razones_Pricipales_No_Recomiende_Servicio.SelectedValue
                LblNo_Probable3.Text = "3)" + Drl_Razones_Pricipales_No_Recomiende_Servicio.SelectedItem.Text
                BtnAgregar_No_Probable.Visible = False
                Exit Sub
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub BtnRegresar_No_Probable_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnRegresar_No_Probable.Click
        Try
            If LblNo_Probable3.Text <> "" Then
                LblNo_Probable_Valor3.Text = ""
                LblNo_Probable3.Text = ""
                BtnAgregar_No_Probable.Visible = True
                Exit Sub
            End If
            If LblNo_Probable2.Text <> "" Then
                LblNo_Probable_Valor2.Text = ""
                LblNo_Probable2.Text = ""
                Exit Sub
            End If
            If LblNo_Probable1.Text <> "" Then
                LblNo_Probable_Valor1.Text = ""
                LblNo_Probable1.Text = ""
                BtnRegresar_No_Probable.Visible = False
                Exit Sub
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnAgregar_Si_Probable_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAgregar_Si_Probable.Click
        Try
            If Drl_Razones_Pricipales_Si_Recomiende_Servicio.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Antes de agregar seleccione una opcion"
                txtcaso.Focus()
                Exit Sub
            End If
            If LblSi_Probable1.Text <> "" And LblSi_Probable2.Text <> "" And LblSi_Probable3.Text <> "" Then
                lblmsg.Text = "Solo puede elegir hasta tres respuestas"
                txtcaso.Focus()
                Exit Sub
            End If
            If LblSi_Probable1.Text = ("1)" + Drl_Razones_Pricipales_Si_Recomiende_Servicio.SelectedItem.Text) Or LblSi_Probable2.Text = ("2)" + Drl_Razones_Pricipales_Si_Recomiende_Servicio.SelectedItem.Text) Or LblSi_Probable3.Text = ("3)" + Drl_Razones_Pricipales_Si_Recomiende_Servicio.SelectedItem.Text) Then
                lblmsg.Text = "La opcion acutal ya fue agregada verifique"
                txtcaso.Focus()
                Exit Sub
            End If
            If LblSi_Probable1.Text = "" Then
                LblSi_Probable_Valor1.Text = Drl_Razones_Pricipales_Si_Recomiende_Servicio.SelectedValue
                LblSi_Probable1.Text = "1)" + Drl_Razones_Pricipales_Si_Recomiende_Servicio.SelectedItem.Text
                BtnRegresar_Si_Probable.Visible = True
                Exit Sub
            End If
            If LblSi_Probable2.Text = "" Then
                LblSi_Probable_Valor2.Text = Drl_Razones_Pricipales_Si_Recomiende_Servicio.SelectedValue
                LblSi_Probable2.Text = "2)" + Drl_Razones_Pricipales_Si_Recomiende_Servicio.SelectedItem.Text
                Exit Sub
            End If
            If LblSi_Probable3.Text = "" Then
                LblSi_Probable_Valor3.Text = Drl_Razones_Pricipales_Si_Recomiende_Servicio.SelectedValue
                LblSi_Probable3.Text = "3)" + Drl_Razones_Pricipales_Si_Recomiende_Servicio.SelectedItem.Text
                BtnAgregar_Si_Probable.Visible = False
                Exit Sub
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub BtnRegresar_Si_Probable_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnRegresar_Si_Probable.Click
        Try
            If LblSi_Probable3.Text <> "" Then
                LblSi_Probable_Valor3.Text = ""
                LblSi_Probable3.Text = ""
                BtnAgregar_Si_Probable.Visible = True
                Exit Sub
            End If
            If LblSi_Probable2.Text <> "" Then
                LblSi_Probable_Valor2.Text = ""
                LblSi_Probable2.Text = ""
                Exit Sub
            End If
            If LblSi_Probable1.Text <> "" Then
                LblSi_Probable_Valor1.Text = ""
                LblSi_Probable1.Text = ""
                BtnRegresar_Si_Probable.Visible = False
                Exit Sub
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub DrlTipo_Encuesta_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DrlTipo_Encuesta.SelectedIndexChanged
        Try
            If DrlTipo_Encuesta.SelectedItem.Text = "Larga" Then
                Panel_Poll_Long.Visible = True
            Else
                Panel_Poll_Long.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBuscar.Click
        Try
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el Caso que desea consultar"
            Else
                If InStr(1, txtcaso.Text, " ") Then
                    lblmsg.Text = "En la caja de texto caso no pueden existir espacios verifique!!"
                    Exit Sub
                End If
                Dim ObjVoz As New clsvoz
                ObjVoz.caso = txtcaso.Text
                ObjVoz.Consulta_Bandeja_Poll_Perception_Service()
                If ObjVoz.cantidad > 0 Then
                    Btn_Guardar.Visible = True
                    lblmin.Text = ObjVoz.min
                    lblcaso.Text = ObjVoz.caso
                    lblcliente.Text = ObjVoz.cliente
                    lblgrupo.Text = ObjVoz.Titular_Linea
                    Lbldepartamento.Text = ObjVoz.Que_Tan_Satisfecho_Con_Servicio_Voz
                    Lblmunicipio.Text = ObjVoz.Establecimiento_Llamadas
                    Lbltipolinea.Text = ObjVoz.Continuidad_Llamadas
                    Lblfc_ingreso.Text = ObjVoz.Recomienda_Contratar_Servicios_Claro_AmigaConocida
                    lblestado.Text = ObjVoz.tipificacion
                    lblmsg.Text = ""
                Else
                    lblmsg.Text = "No se encontraron registros del caso: " + txtcaso.Text
                    Btn_Guardar.Visible = False
                    limpia()
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Sub limpia()
        lblmin.Text = ""
        lblcaso.Text = ""
        lblcliente.Text = ""
        lblgrupo.Text = ""
        Lbldepartamento.Text = ""
        Lblmunicipio.Text = ""
        Lbltipolinea.Text = ""
        Lblfc_ingreso.Text = ""
        lblestado.Text = ""
        Txt_Obs.Text = ""
        Txt_hora.Text = ""

        txtfcingn3.Text = ""
    End Sub

    Protected Sub Btn_Guardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Guardar.Click
        Try
            If lblestado.Text = "Encuesta Satisfecha" Then
                lblmsg.Text = "Encuesta Satisfecha no se puede gestionar por segunda vez"
                Exit Sub
            End If

            If lblcaso.Text = "" Then
                lblmsg.Text = "Antes de realizar un registro de encuesta consulte un caso"
                Exit Sub
            End If
            If drltipificacionll.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una tipificacion para la llamada"
                Exit Sub
            End If
            If Txt_Obs.Text = "" Then
                lblmsg.Text = "Por Favor Digite una Observacion"
                Exit Sub
            End If
            If drltipificacionll.SelectedItem.Text = "Encuesta Programada" Or drltipificacionll.SelectedItem.Text = "Encuesta Rechazada" Or drltipificacionll.SelectedItem.Text = "Encuesta Buzon" Then
                Dim ObjVoz As New clsvoz
                ObjVoz.caso = lblcaso.Text
                ObjVoz.idusuario = lblusuario.Text
                ObjVoz.obs = Txt_Obs.Text
                ObjVoz.tipificacion = drltipificacionll.SelectedItem.Text
                If drltipificacionll.SelectedItem.Text = "Encuesta Programada" Then
                    If txtfcingn3.Text = "" Then
                        lblmsg.Text = "Ingrese una Fecha"
                        Exit Sub
                    End If
                    If Date.Parse(Date.Now.ToString("dd/MM/yyyy")) > Date.Parse(txtfcingn3.Text) Then
                        lblmsg.Text = "La fecha de programado no puede ser anterior a la actual"
                        Exit Sub
                    End If
                    If Txt_hora.Text = "" Then
                        lblmsg.Text = "Selecione una hora"
                        Exit Sub
                    End If
                    ObjVoz.fcreg = txtfcingn3.Text & " " & Txt_hora.Text
                    ObjVoz.Validacion = "encuesta_programada"
                End If
                If drltipificacionll.SelectedItem.Text = "Encuesta Rechazada" Then
                    If Drl_motivos_culminacion.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione un motivo de culminacion de llamada"
                        Exit Sub
                    End If
                    ObjVoz.Validacion = "encuesta_rechazada"
                    ObjVoz.Claridad_Llamadas = Drl_motivos_culminacion.SelectedValue
                End If
                If drltipificacionll.SelectedItem.Text = "Encuesta Buzon" Then
                    ObjVoz.Validacion = "encuesta_buzon"
                End If
                ObjVoz.RegistroCRM_Poll_Perception_Service_Short()
                ActualizarBandeja()
                lblmsg.Text = "Registro de Encuestas realizada con exito"
            Else
                If DrlTipo_Encuesta.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione un tipo de encuesta"
                    Exit Sub
                End If
                If DrlGenero.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione un Genero"
                    Exit Sub
                End If
                If DrlTitular_Linea.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione si el cliente es titular de la linea"
                    Exit Sub
                End If
                If drlTipo_Cliente.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione el tipo de cliente"
                    Exit Sub
                End If
                If drlInternet_Redes_sociales.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una opcion para, ¿Ha navegado por internet y/o en redes sociales utilizando los datos de su celular en los últimos 15 días?"
                    Exit Sub
                End If
                If DrlDificultad_Usar_Servicio_Datos.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una opcion para, ¿Ha tenido alguna dificultad al usar el servicio de datos en los últimos 15 días?"
                    Exit Sub
                End If
                If DrlDificultad_Usar_Servicio_Voz.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una opcion para, ¿Ha tenido alguna dificultad al usar el servicio de voz en los últimos 15 días?"
                    Exit Sub
                End If
                If DrlHa_Tenido_Dificultad_Datos.SelectedItem.Text = "- Seleccione -" And DrlHa_Tenido_Dificultad_Datos.Enabled = True Then
                    lblmsg.Text = "Seleccione una opcion para, Si el cliente ha tenido alguna dificultad Datos"
                    Exit Sub
                End If
                If DrlHa_Tenido_Dificultad_Voz.SelectedItem.Text = "- Seleccione -" And DrlHa_Tenido_Dificultad_Voz.Enabled = True Then
                    lblmsg.Text = "Seleccione una opcion para, Si el cliente ha tenido alguna dificultad Voz"
                    Exit Sub
                End If
                If DrlCual_Es_Mas_Molesta_Datos.SelectedItem.Text = "- Seleccione -" And DrlCual_Es_Mas_Molesta_Datos.Enabled = True Then
                    lblmsg.Text = "Seleccione una opcion para, ¿De las dificultades manifestadas anteriormente, cuál es la más molesta para usted - Datos?"
                    Exit Sub
                End If
                If DrlCual_Es_Mas_Molesta_Voz.SelectedItem.Text = "- Seleccione -" And DrlCual_Es_Mas_Molesta_Voz.Enabled = True Then
                    lblmsg.Text = "Seleccione una opcion para, ¿De las dificultades manifestadas anteriormente, cuál es la más molesta para usted - Voz?"
                    Exit Sub
                End If

                If DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos.SelectedItem.Text = "- Seleccione -" And DrlCual_Es_Mas_Molesta_Datos.Enabled = True Then
                    lblmsg.Text = "Seleccione una opcion para, En estos 7 días ¿como percibe la calidad del servicio con respecto a la semana anterior - Datos?"
                    Exit Sub
                End If
                If DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione una opcion para, En estos 7 días ¿como percibe la calidad del servicio con respecto a la semana anterior - Voz?"
                    Exit Sub
                End If
                If Drl_Intension_Del_Usuario.SelectedValue = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione Una intencion por parte del usuario"
                    Exit Sub
                End If


                '''''' Fin Encueta Short ''''''
                Dim ObjVoz As New clsvoz
                '''' Insert Poll Short

                ObjVoz.Persona_Interesada = Drl_Intension_Del_Usuario.SelectedValue
                ObjVoz.obs = Txt_Obs.Text
                ObjVoz.caso = lblcaso.Text
                ObjVoz.Tipo_Poll = DrlTipo_Encuesta.SelectedItem.Text
                ObjVoz.idusuario = lblusuario.Text
                ObjVoz.Genero = DrlGenero.SelectedItem.Text
                ObjVoz.Titular_Linea = DrlTitular_Linea.SelectedItem.Text
                ObjVoz.Tipo_Cliente = drlTipo_Cliente.SelectedItem.Text
                ObjVoz.Internet_Redes_sociales = drlInternet_Redes_sociales.SelectedItem.Text
                ObjVoz.Dificultad_Usar_Servicio_Datos = DrlDificultad_Usar_Servicio_Datos.SelectedItem.Text
                ObjVoz.Dificultad_Usar_Servicio_Voz = DrlDificultad_Usar_Servicio_Voz.SelectedItem.Text
                '----------------
                If DrlHa_Tenido_Dificultad_Datos.SelectedItem.Text = "- Seleccione -" Then
                    ObjVoz.Ha_Tenido_Dificultad_Datos = ""
                Else
                    If DrlHa_Tenido_Dificultad_Datos.SelectedItem.Text = "Otras" Then
                        ObjVoz.Ha_Tenido_Dificultad_Datos = DrlHa_Tenido_Dificultad_Datos.SelectedItem.Text + " " + Txt_Cual_1.Text 'concateno otras mas la nueva tipificacion
                    Else
                        ObjVoz.Ha_Tenido_Dificultad_Datos = DrlHa_Tenido_Dificultad_Datos.SelectedItem.Text
                    End If
                End If
                '----------------
                If DrlHa_Tenido_Dificultad_Voz.SelectedItem.Text = "- Seleccione -" Then
                    ObjVoz.Ha_Tenido_Dificultad_Voz = ""
                Else
                    If DrlHa_Tenido_Dificultad_Voz.SelectedItem.Text = "Otras" Then
                        ObjVoz.Ha_Tenido_Dificultad_Voz = DrlHa_Tenido_Dificultad_Voz.SelectedItem.Text + " " + Txt_cual_2.Text 'concateno otras mas la nueva tipificacion
                    Else
                        ObjVoz.Ha_Tenido_Dificultad_Voz = DrlHa_Tenido_Dificultad_Voz.SelectedItem.Text
                    End If
                End If
                '----------------
                If DrlCual_Es_Mas_Molesta_Datos.SelectedItem.Text = "- Seleccione -" Then
                    ObjVoz.Cual_Es_Mas_Molesta_Datos = ""
                Else
                    If DrlCual_Es_Mas_Molesta_Datos.SelectedItem.Text = "Otras" Then
                        ObjVoz.Cual_Es_Mas_Molesta_Datos = DrlCual_Es_Mas_Molesta_Datos.SelectedItem.Text + " " + Txt_Cual_3.Text 'concateno otras mas la nueva tipificacion
                    Else
                        ObjVoz.Cual_Es_Mas_Molesta_Datos = DrlCual_Es_Mas_Molesta_Datos.SelectedItem.Text
                    End If
                End If
                '----------------
                If DrlCual_Es_Mas_Molesta_Voz.SelectedItem.Text = "- Seleccione -" Then
                    ObjVoz.Cual_Es_Mas_Molesta_Voz = ""
                Else
                    If DrlCual_Es_Mas_Molesta_Voz.SelectedItem.Text = "Otras" Then
                        ObjVoz.Cual_Es_Mas_Molesta_Voz = DrlCual_Es_Mas_Molesta_Voz.SelectedItem.Text + " " + Txt_Cual_4.Text 'concateno otras mas la nueva tipificacion
                    Else
                        ObjVoz.Cual_Es_Mas_Molesta_Voz = DrlCual_Es_Mas_Molesta_Voz.SelectedItem.Text
                    End If
                End If
                '----------------
                If DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos.SelectedItem.Text = "- Seleccione -" Then
                    ObjVoz.Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos = ""
                Else
                    ObjVoz.Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos = DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos.SelectedItem.Text
                End If
                ObjVoz.Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz = DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz.SelectedItem.Text
                ObjVoz.tipificacion = drltipificacionll.SelectedItem.Text
                ObjVoz.Validacion = "encuesta_satisfecha"
                ObjVoz.RegistroCRM_Poll_Perception_Service_Short()

                '''''' Incio Encueta Long ''''''
                If DrlTipo_Encuesta.SelectedItem.Text = "Larga" Then
                    If DrlRecomienda_Contratar_Servicios_Claro_AmigaConocida.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una opcion para, ¿qué tan probable es que usted recomiende contratar los servicios de Claro a una persona amiga o conocida?"
                        Exit Sub
                    End If
                    '''''' Inicio Registros Tabla Aparte "Poll_P_S_RTA_Multiple" ''''''
                    If LblNo_Probable1.Text = "" Then
                        lblmsg.Text = "Seleccione almenos una opcion para, ¿Cuáles son las principales razones por las que usted considera que no es muy probable que recomiende a una persona amiga o conocida contratar los servicios de Claro?"
                        Exit Sub
                    End If
                    If LblSi_Probable1.Text = "" Then
                        lblmsg.Text = "Seleccione almenos una opcion para, ¿Cuáles son las principales razones por las que usted considera que no es muy probable que recomiende a una persona amiga o conocida contratar los servicios de Claro?"
                        Exit Sub
                    End If
                    '''''' Fin Registros Tabla Aparte "Poll_P_S_RTA_Multiple" ''''''
                    If DrlQue_Tan_Satisfecho_Con_Servicio_Voz.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una opcion para, ¿Qué tan satisfecho está con el servicio de VOZ de Claro?"
                        Exit Sub
                    End If
                    If DrlEstablecimiento_Llamadas.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una opcion para, El establecimiento de llamadas"
                        Exit Sub
                    End If
                    If DrlContinuidad_Llamadas.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una opcion para, Continuidad de las llamadas"
                        Exit Sub
                    End If
                    If DrlClaridad_Llamadas.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una opcion para, Claridad de las llamadas"
                        Exit Sub
                    End If
                    If DrlQue_Tan_Satisfecho_Con_Servicio_Datos.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una opcion para, ¿Qué tan satisfecho está con el servicio de DATOS de Claro?"
                        Exit Sub
                    End If
                    If DrlAccesibilidad_Servicio_Datos.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una opcion para, La accesibilidad del servicio de datos, es decir, puede abrir páginas de Internet cuando lo necesita"
                        Exit Sub
                    End If
                    If DrlCapacidad_Retencion_Servicio_Datos.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una opcion para, La capacidad de retención del servicio de datos, es decir, la conexión de datos no se cae mientras se usa y no es necesario volver a conectarse"
                        Exit Sub
                    End If
                    If DrlVelocidad_Navegacion_Servicio_Datos.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una opcion para, La velocidad de navegación del servicio de datos, es decir, que puede usar el servicio tan rápido como lo permite el equipo, sin lentitud y sin que el equipo deje de responder."
                        Exit Sub
                    End If
                    If DrlEnvio_Recepcion_Correos_Electronicos.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una opcion para, El envío y recepción de los correos electrónicos"
                        Exit Sub
                    End If
                    If DrlEnvio_Recepcion_Mensajes_ATraves_Whatsapp_Twitter_Facebook_Line.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una opcion para, El envío y recepción de mensajes a través de whatsapp, twitter, facebook o line"
                        Exit Sub
                    End If
                    If DrlSubir_Descargar_Imagenes_Videos_ATraves_Youtube_Instagram_Snapchat_Otras_Redes_Sociales.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una opcion para, Subir y descargar imágenes o videos a través de youtube, instagram, snapchat y otras redes sociales"
                        Exit Sub
                    End If
                    If DrlTiempo_Espera_Para_Abrir_Pagina_Favorita_Internet.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione una opcion para, El tiempo de espera para abrir su página favorita de internet."
                        Exit Sub
                    End If
                    '''' Insert Poll Long

                    ObjVoz.Recomienda_Contratar_Servicios_Claro_AmigaConocida = DrlRecomienda_Contratar_Servicios_Claro_AmigaConocida.Text
                    '/*Razones_Pricipales_No_Recomiende_Servicio varchar(100),*/ -- /*<---- hasta tres (3) respuestas*/ Inserciones multiples
                    '/*Razones_Pricipales_Si_Recomiende_Servicio varchar(100),*/ -- /*<---- hasta tres (3) respuestas*/ Inserciones multiples
                    ObjVoz.Que_Tan_Satisfecho_Con_Servicio_Voz = DrlQue_Tan_Satisfecho_Con_Servicio_Voz.Text
                    ObjVoz.Establecimiento_Llamadas = DrlEstablecimiento_Llamadas.Text
                    ObjVoz.Continuidad_Llamadas = DrlContinuidad_Llamadas.Text
                    ObjVoz.Claridad_Llamadas = DrlClaridad_Llamadas.Text
                    ObjVoz.Que_Tan_Satisfecho_Con_Servicio_Datos = DrlQue_Tan_Satisfecho_Con_Servicio_Datos.Text
                    ObjVoz.Accesibilidad_Servicio_Datos = DrlAccesibilidad_Servicio_Datos.Text
                    ObjVoz.Capacidad_Retencion_Servicio_Datos = DrlCapacidad_Retencion_Servicio_Datos.Text
                    ObjVoz.Velocidad_Navegacion_Servicio_Datos = DrlVelocidad_Navegacion_Servicio_Datos.Text
                    ObjVoz.Envio_Recepcion_Correos_Electronicos = DrlEnvio_Recepcion_Correos_Electronicos.Text
                    ObjVoz.Envio_Recepcion_Mensajes_ATraves_Whatsapp_Twitter_Facebook_Line = DrlEnvio_Recepcion_Mensajes_ATraves_Whatsapp_Twitter_Facebook_Line.Text
                    ObjVoz.Subir_Descargar_Imagenes_Videos_ATraves_Youtube_Instagram_Snapchat_Otras_Redes_Sociales = DrlSubir_Descargar_Imagenes_Videos_ATraves_Youtube_Instagram_Snapchat_Otras_Redes_Sociales.Text
                    ObjVoz.Tiempo_Espera_Para_Abrir_Pagina_Favorita_Internet = DrlTiempo_Espera_Para_Abrir_Pagina_Favorita_Internet.Text
                    ObjVoz.RegistroCRM_Poll_Perception_Service_Long()

                    '''' Insert Poll Multiples respuestas

                    'El siguiente valor se obtiene por medio de la insercion anterior por ende no es necesario enviarlo en el nuevo insert
                    'ObjVoz.Fk_Cod_CRM_Poll_Perception_Service_S_L = ObjVoz.Fk_Cod_CRM_Poll_Perception_Service_S_L
                    If ObjVoz.Fk_Cod_CRM_Poll_Perception_Service_S_L = "" Then
                        lblmsg.Text = "Falla al realizar el registro por encuenta Larga por favor concate al área de informacio o desarrollo"
                        Exit Sub
                    End If

                    If Pnl_P1B.Visible = True Then
                        '/*hasta tres (3) respuestas No*/
                        If LblNo_Probable_Valor1.Text <> "" Then
                            ObjVoz.Fk_Cod_Poll_P_S_Des_Option = LblNo_Probable_Valor1.Text
                            ObjVoz.RegistroPoll_P_S_RTA_Multiple()
                        End If
                        If LblNo_Probable_Valor2.Text <> "" Then
                            ObjVoz.Fk_Cod_Poll_P_S_Des_Option = LblNo_Probable_Valor2.Text
                            ObjVoz.RegistroPoll_P_S_RTA_Multiple()
                        End If
                        If LblNo_Probable_Valor3.Text <> "" Then
                            ObjVoz.Fk_Cod_Poll_P_S_Des_Option = LblNo_Probable_Valor3.Text
                            ObjVoz.RegistroPoll_P_S_RTA_Multiple()
                        End If
                    End If

                    If pnl_P1C.Visible = True Then
                        '/*hasta tres (3) respuestas Si*/
                        If LblSi_Probable_Valor1.Text <> "" Then
                            ObjVoz.Fk_Cod_Poll_P_S_Des_Option = LblSi_Probable_Valor1.Text
                            ObjVoz.RegistroPoll_P_S_RTA_Multiple()
                        End If
                        If LblSi_Probable_Valor2.Text <> "" Then
                            ObjVoz.Fk_Cod_Poll_P_S_Des_Option = LblSi_Probable_Valor2.Text
                            ObjVoz.RegistroPoll_P_S_RTA_Multiple()
                        End If
                        If LblSi_Probable_Valor3.Text <> "" Then
                            ObjVoz.Fk_Cod_Poll_P_S_Des_Option = LblSi_Probable_Valor3.Text
                            ObjVoz.RegistroPoll_P_S_RTA_Multiple()
                        End If
                    End If
                End If

                ActualizarBandeja()
                lblmsg.Text = "Registro de Encuestas realizada con exito"
                ''Poll Short
                lblcaso.Text = ""
                DrlTipo_Encuesta.SelectedValue = "- Seleccione -"
                DrlGenero.SelectedValue = "- Seleccione -"
                DrlTitular_Linea.SelectedValue = "- Seleccione -"
                drlTipo_Cliente.SelectedValue = "- Seleccione -"
                drlInternet_Redes_sociales.SelectedValue = "- Seleccione -"
                DrlDificultad_Usar_Servicio_Datos.SelectedValue = "- Seleccione -"
                DrlDificultad_Usar_Servicio_Voz.SelectedValue = "- Seleccione -"
                DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos.SelectedValue = "- Seleccione -"
                DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz.SelectedValue = "- Seleccione -"
                ''Poll Long
                DrlRecomienda_Contratar_Servicios_Claro_AmigaConocida.SelectedValue = "- Seleccione -"
                DrlQue_Tan_Satisfecho_Con_Servicio_Voz.SelectedValue = "- Seleccione -"
                DrlEstablecimiento_Llamadas.SelectedValue = "- Seleccione -"
                DrlContinuidad_Llamadas.SelectedValue = "- Seleccione -"
                DrlClaridad_Llamadas.SelectedValue = "- Seleccione -"
                DrlQue_Tan_Satisfecho_Con_Servicio_Datos.SelectedValue = "- Seleccione -"
                DrlAccesibilidad_Servicio_Datos.SelectedValue = "- Seleccione -"
                DrlCapacidad_Retencion_Servicio_Datos.SelectedValue = "- Seleccione -"
                DrlVelocidad_Navegacion_Servicio_Datos.SelectedValue = "- Seleccione -"
                DrlEnvio_Recepcion_Correos_Electronicos.SelectedValue = "- Seleccione -"
                DrlEnvio_Recepcion_Mensajes_ATraves_Whatsapp_Twitter_Facebook_Line.SelectedValue = "- Seleccione -"
                DrlSubir_Descargar_Imagenes_Videos_ATraves_Youtube_Instagram_Snapchat_Otras_Redes_Sociales.SelectedValue = "- Seleccione -"
                DrlTiempo_Espera_Para_Abrir_Pagina_Favorita_Internet.SelectedValue = "- Seleccione -"
                ''Options multiples
                LblNo_Probable_Valor1.Text = ""
                LblNo_Probable1.Text = ""
                LblNo_Probable_Valor2.Text = ""
                LblNo_Probable2.Text = ""
                LblNo_Probable_Valor3.Text = ""
                LblNo_Probable3.Text = ""
                LblSi_Probable_Valor1.Text = ""
                LblSi_Probable1.Text = ""
                LblSi_Probable_Valor2.Text = ""
                LblSi_Probable2.Text = ""
                LblSi_Probable_Valor3.Text = ""
                LblSi_Probable3.Text = ""
            End If
            Cargar_Drl()
            limpia()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub DrlDificultad_Usar_Servicio_Datos_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DrlDificultad_Usar_Servicio_Datos.SelectedIndexChanged
        Try
            If DrlDificultad_Usar_Servicio_Datos.SelectedValue = "No" Or DrlDificultad_Usar_Servicio_Datos.SelectedValue = "NS/NR" Then
                DrlHa_Tenido_Dificultad_Datos.Enabled = False
                DrlCual_Es_Mas_Molesta_Datos.Enabled = False
                DrlHa_Tenido_Dificultad_Datos.SelectedValue = 1
                DrlCual_Es_Mas_Molesta_Datos.SelectedValue = 1
                Txt_Cual_1.Enabled = False
                Txt_Cual_3.Enabled = False
                Txt_Cual_1.Text = ""
                Txt_Cual_3.Text = ""
                DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos.Enabled = False
                DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos.SelectedValue = "- Seleccione -"
            Else
                DrlHa_Tenido_Dificultad_Datos.Enabled = True
                DrlCual_Es_Mas_Molesta_Datos.Enabled = True
                DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos.Enabled = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub DrlDificultad_Usar_Servicio_Voz_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DrlDificultad_Usar_Servicio_Voz.SelectedIndexChanged
        Try
            If DrlDificultad_Usar_Servicio_Voz.SelectedValue = "No" Or DrlDificultad_Usar_Servicio_Voz.SelectedValue = "NS/NR" Then
                DrlHa_Tenido_Dificultad_Voz.Enabled = False
                DrlCual_Es_Mas_Molesta_Voz.Enabled = False
                DrlHa_Tenido_Dificultad_Voz.SelectedValue = 1
                DrlCual_Es_Mas_Molesta_Voz.SelectedValue = 1
                Txt_cual_2.Enabled = False
                Txt_Cual_4.Enabled = False
                Txt_cual_2.Text = ""
                Txt_Cual_4.Text = ""
            Else
                DrlHa_Tenido_Dificultad_Voz.Enabled = True
                DrlCual_Es_Mas_Molesta_Voz.Enabled = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub DrlHa_Tenido_Dificultad_Datos_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DrlHa_Tenido_Dificultad_Datos.SelectedIndexChanged
        Try
            If DrlHa_Tenido_Dificultad_Datos.SelectedItem.Text = "Otras" Then
                Txt_Cual_1.Enabled = True
            Else
                Txt_Cual_1.Enabled = False
                Txt_Cual_1.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub DrlHa_Tenido_Dificultad_Voz_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DrlHa_Tenido_Dificultad_Voz.SelectedIndexChanged
        Try
            If DrlHa_Tenido_Dificultad_Voz.SelectedItem.Text = "Otras" Then
                Txt_cual_2.Enabled = True
            Else
                Txt_cual_2.Enabled = False
                Txt_cual_2.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub DrlCual_Es_Mas_Molesta_Datos_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DrlCual_Es_Mas_Molesta_Datos.SelectedIndexChanged
        Try
            If DrlCual_Es_Mas_Molesta_Datos.SelectedItem.Text = "Otras" Then
                Txt_Cual_3.Enabled = True
            Else
                Txt_Cual_3.Enabled = False
                Txt_Cual_3.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub DrlCual_Es_Mas_Molesta_Voz_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DrlCual_Es_Mas_Molesta_Voz.SelectedIndexChanged
        Try
            If DrlCual_Es_Mas_Molesta_Voz.SelectedItem.Text = "Otras" Then
                Txt_Cual_4.Enabled = True
            Else
                Txt_Cual_4.Enabled = False
                Txt_Cual_4.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub DrlRecomienda_Contratar_Servicios_Claro_AmigaConocida_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DrlRecomienda_Contratar_Servicios_Claro_AmigaConocida.SelectedIndexChanged
        Try
            If DrlRecomienda_Contratar_Servicios_Claro_AmigaConocida.SelectedValue = "- Seleccione -" Then
                Pnl_P1B.Visible = False
                pnl_P1C.Visible = False
            End If
            If DrlRecomienda_Contratar_Servicios_Claro_AmigaConocida.SelectedValue >= 1 And DrlRecomienda_Contratar_Servicios_Claro_AmigaConocida.SelectedValue <= 8 Or DrlRecomienda_Contratar_Servicios_Claro_AmigaConocida.SelectedValue = 0 Then
                Pnl_P1B.Visible = True
                pnl_P1C.Visible = False
            End If
            If DrlRecomienda_Contratar_Servicios_Claro_AmigaConocida.SelectedValue >= 9 And DrlRecomienda_Contratar_Servicios_Claro_AmigaConocida.SelectedValue <= 10 Then
                Pnl_P1B.Visible = False
                pnl_P1C.Visible = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Private Sub ActualizarBandeja()
        Try
            If drltipificacionll.Text <> "- Seleccione -" Then
                Dim ObjVoz As New clsvoz
                ObjVoz.caso = lblcaso.Text
                ObjVoz.tipificacion = drltipificacionll.SelectedItem.Text
                ObjVoz.Actualizar_Bandeja_Poll()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drltipificacionll_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drltipificacionll.SelectedIndexChanged
        Try
            If drltipificacionll.SelectedItem.Text = "Encuesta Programada" Or drltipificacionll.SelectedItem.Text = "Encuesta Rechazada" Or drltipificacionll.SelectedItem.Text = "Encuesta Buzon" Then
                limpiar_y_ocultar()
                If drltipificacionll.SelectedItem.Text = "Encuesta Programada" Then
                    Txt_Obs.Enabled = True
                    txtfcingn3.Enabled = True
                    Txt_hora.Enabled = True

                End If
                If drltipificacionll.SelectedItem.Text = "Encuesta Rechazada" Then
                    Txt_Obs.Enabled = True
                    Drl_motivos_culminacion.Enabled = True
                End If
                If drltipificacionll.SelectedItem.Text = "Encuesta Buzon" Then
                    Txt_Obs.Enabled = True
                End If
            Else
                limpiar_y_ocutar_fecha()
                Drl_motivos_culminacion.Enabled = False
                DrlTipo_Encuesta.Enabled = True
                Txt_Obs.Enabled = True
                DrlGenero.Enabled = True
                DrlTitular_Linea.Enabled = True
                drlTipo_Cliente.Enabled = True
                drlInternet_Redes_sociales.Enabled = True
                DrlDificultad_Usar_Servicio_Datos.Enabled = True
                Drl_Intension_Del_Usuario.Enabled = True
                ''Prueba Tipificacion datos
                If DrlDificultad_Usar_Servicio_Datos.SelectedItem.Text = "No" Then
                    DrlHa_Tenido_Dificultad_Datos.Enabled = False
                    Txt_Cual_1.Enabled = False
                    DrlCual_Es_Mas_Molesta_Datos.Enabled = False
                    Txt_Cual_3.Enabled = False
                    DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos.Enabled = False
                    limpiar_y_ocutar_fecha()
                Else
                    DrlHa_Tenido_Dificultad_Datos.Enabled = True
                    Txt_Cual_1.Enabled = True
                    DrlCual_Es_Mas_Molesta_Datos.Enabled = True
                    Txt_Cual_3.Enabled = True
                    DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos.Enabled = True
                End If
                DrlDificultad_Usar_Servicio_Voz.Enabled = True
                ''Prueba Tipificacion Voz
                If DrlDificultad_Usar_Servicio_Voz.SelectedItem.Text = "No" Then
                    Txt_cual_2.Enabled = False
                    Txt_Cual_4.Enabled = False
                    DrlHa_Tenido_Dificultad_Voz.Enabled = False
                    DrlCual_Es_Mas_Molesta_Voz.Enabled = False
                    limpiar_y_ocutar_fecha()
                Else
                    Txt_cual_2.Enabled = True
                    Txt_Cual_4.Enabled = True
                    DrlHa_Tenido_Dificultad_Voz.Enabled = True
                    DrlCual_Es_Mas_Molesta_Voz.Enabled = True
                End If
                DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz.Enabled = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Sub limpiar_y_ocutar_fecha()
        txtfcingn3.Text = ""
        Txt_hora.Text = ""
        txtfcingn3.Enabled = False
        Txt_hora.Enabled = False
    End Sub

    Sub limpiar_y_ocultar()
        Panel_Poll_Long.Visible = False
        Pnl_P1B.Visible = False
        pnl_P1C.Visible = False

        DrlTipo_Encuesta.SelectedValue = "- Seleccione -"
        DrlGenero.SelectedValue = "- Seleccione -"
        DrlTitular_Linea.SelectedValue = "- Seleccione -"
        drlTipo_Cliente.SelectedValue = "- Seleccione -"
        drlInternet_Redes_sociales.SelectedValue = "- Seleccione -"
        DrlDificultad_Usar_Servicio_Datos.SelectedValue = "- Seleccione -"
        DrlDificultad_Usar_Servicio_Voz.SelectedValue = "- Seleccione -"
        DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos.SelectedValue = "- Seleccione -"
        DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz.SelectedValue = "- Seleccione -"
        Drl_Intension_Del_Usuario.SelectedValue = "- Seleccione -"
        DrlHa_Tenido_Dificultad_Datos.SelectedValue = 1
        DrlHa_Tenido_Dificultad_Voz.SelectedValue = 1
        DrlCual_Es_Mas_Molesta_Datos.SelectedValue = 1
        DrlCual_Es_Mas_Molesta_Voz.SelectedValue = 1
        Drl_motivos_culminacion.SelectedValue = 1
        Txt_Cual_1.Text = ""
        Txt_cual_2.Text = ""
        Txt_Cual_3.Text = ""
        Txt_Cual_4.Text = ""
        Txt_Obs.Text = ""

        DrlTipo_Encuesta.Enabled = False
        DrlGenero.Enabled = False
        DrlTitular_Linea.Enabled = False
        drlTipo_Cliente.Enabled = False
        drlInternet_Redes_sociales.Enabled = False
        DrlDificultad_Usar_Servicio_Datos.Enabled = False
        DrlDificultad_Usar_Servicio_Voz.Enabled = False
        DrlHa_Tenido_Dificultad_Datos.Enabled = False
        DrlHa_Tenido_Dificultad_Voz.Enabled = False
        DrlCual_Es_Mas_Molesta_Datos.Enabled = False
        DrlCual_Es_Mas_Molesta_Voz.Enabled = False
        DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz.Enabled = False
        DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos.Enabled = False
        DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz.Enabled = False
        Drl_motivos_culminacion.Enabled = False
        Txt_Cual_1.Enabled = False
        Txt_cual_2.Enabled = False
        Txt_Cual_3.Enabled = False
        Txt_Cual_4.Enabled = False
        Txt_Obs.Enabled = False
        Drl_Intension_Del_Usuario.Enabled = False
        limpiar_y_ocutar_fecha()
    End Sub


End Class