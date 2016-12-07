Public Class RegCrmMTI
    Inherits System.Web.UI.Page
    Dim ObjVoz As New clsvoz

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
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
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Public Sub Cargar_Drl()
        ObjVoz.Validacion = 1
        With drlEmpresa
            .DataSource = ObjVoz.Consulta_Adicionales_MTI
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        With drlEmpresa_Consulta
            .DataSource = ObjVoz.Consulta_Adicionales_MTI
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        ObjVoz.Validacion = 2
        With drlEstado_llamada
            .DataSource = ObjVoz.Consulta_Adicionales_MTI
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        With drlEstado_Llamada_Consulta
            .DataSource = ObjVoz.Consulta_Adicionales_MTI
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        ObjVoz.Validacion = 3
        'With drlRecepcion_Invitacion
        '    .DataSource = ObjVoz.Consulta_Adicionales_MTI
        '    .DataTextField = "Nombre"
        '    .DataValueField = "Nombre"
        '    .DataBind()
        'End With
        'With drlPersonaInteresada
        '    .DataSource = ObjVoz.Consulta_Adicionales_MTI
        '    .DataTextField = "Nombre"
        '    .DataValueField = "Nombre"
        '    .DataBind()
        'End With
        'With drlPersonaInteresada_Consulta
        '    .DataSource = ObjVoz.Consulta_Adicionales_MTI
        '    .DataTextField = "Nombre"
        '    .DataValueField = "Nombre"
        '    .DataBind()
        'End With
        'With drlAsiste_Evento
        '    .DataSource = ObjVoz.Consulta_Adicionales_MTI
        '    .DataTextField = "Nombre"
        '    .DataValueField = "Nombre"
        '    .DataBind()
        'End With
        dtggeneral.DataSource = ObjVoz.Consulta_Bandeja_MTI
        dtggeneral.DataBind()
        lblcuenta.Text = ObjVoz.cantidad
        ObjVoz.Validacion = 4
        ObjVoz.Consulta_Adicionales_MTI()
        LblCantidad_Casos.Text = ObjVoz.cantidad
        ObjVoz.Validacion = 5
        ObjVoz.Consulta_Adicionales_MTI()
        LblCantidad_Casos_ProximosD.Text = ObjVoz.cantidad
    End Sub

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBuscar.Click
        Try
            If txtcaso.Text = "" Then
                lblmsg.Text = "Ingrese el caso"
                Exit Sub
            End If
            Dim dts As New DataSet
            ObjVoz.Cod_Bandeja_MTI = txtcaso.Text
            dts = ObjVoz.Consulta_Registro_MTI()

            If dts.Tables(0).Rows.Count > 0 Then
                ''''''' Carga informacion Lbl
                LblEmpresa.Text = ObjVoz.Empresa
                LblNombre.Text = ObjVoz.Nombre
                LblCargo.Text = ObjVoz.Cargo
                LblCorreo.Text = ObjVoz.Correo
                LblTelefono.Text = ObjVoz.Telefono
                LblRealizo_Llamada.Text = ObjVoz.resolucion
                LblContacto_Adicional.Text = ObjVoz.Contacto_Adicional
                LblComentario.Text = ObjVoz.Comentario
                LblCaso.Text = ObjVoz.Cod_Bandeja_MTI

                'Modificacion
                LblNombre1.Text = ObjVoz.Nombre1
                LblNombre2.Text = ObjVoz.Nombre2
                LblNombre3.Text = ObjVoz.Nombre3

                LblCargo1.Text = ObjVoz.Cargo1
                LblCargo2.Text = ObjVoz.Cargo2
                LblCargo3.Text = ObjVoz.Cargo3

                LblCorreo1.Text = ObjVoz.Correo1
                LblCorreo2.Text = ObjVoz.Correo2
                LblCorreo3.Text = ObjVoz.Correo3

                LblTelefono1.Text = ObjVoz.Telefono1
                LblTelefono2.Text = ObjVoz.Telefono2
                LblTelefono3.Text = ObjVoz.Telefono3

                ''''''' Carga informacion Herramientas
                If dts.Tables(0).Rows(0).Item("Empresa") Is System.DBNull.Value Then
                    drlEmpresa.Text = ""
                Else
                    drlEmpresa.Text = dts.Tables(0).Rows(0).Item("Empresa")
                End If

                If dts.Tables(0).Rows(0).Item("Nombre") Is System.DBNull.Value Then
                    TxtNombre.Text = ""
                Else
                    TxtNombre.Text = dts.Tables(0).Rows(0).Item("Nombre")
                End If
                If dts.Tables(0).Rows(0).Item("Nombre1") Is System.DBNull.Value Then
                    TxtNombre1.Text = ""
                Else
                    TxtNombre1.Text = dts.Tables(0).Rows(0).Item("Nombre1")
                End If
                If dts.Tables(0).Rows(0).Item("Nombre2") Is System.DBNull.Value Then
                    TxtNombre2.Text = ""
                Else
                    TxtNombre2.Text = dts.Tables(0).Rows(0).Item("Nombre2")
                End If
                If dts.Tables(0).Rows(0).Item("Nombre3") Is System.DBNull.Value Then
                    TxtNombre3.Text = ""
                Else
                    TxtNombre3.Text = dts.Tables(0).Rows(0).Item("Nombre3")
                End If
                If dts.Tables(0).Rows(0).Item("Cargo") Is System.DBNull.Value Then
                    TxtCargo.Text = ""
                Else
                    TxtCargo.Text = dts.Tables(0).Rows(0).Item("Cargo")
                End If
                If dts.Tables(0).Rows(0).Item("Cargo1") Is System.DBNull.Value Then
                    TxtCargo1.Text = ""
                Else
                    TxtCargo1.Text = dts.Tables(0).Rows(0).Item("Cargo1")
                End If
                If dts.Tables(0).Rows(0).Item("Cargo2") Is System.DBNull.Value Then
                    TxtCargo2.Text = ""
                Else
                    TxtCargo2.Text = dts.Tables(0).Rows(0).Item("Cargo2")
                End If
                If dts.Tables(0).Rows(0).Item("Cargo3") Is System.DBNull.Value Then
                    TxtCargo3.Text = ""
                Else
                    TxtCargo3.Text = dts.Tables(0).Rows(0).Item("Cargo3")
                End If

                If dts.Tables(0).Rows(0).Item("Correo") Is System.DBNull.Value Then
                    TxtCorreo.Text = ""
                Else
                    TxtCorreo.Text = dts.Tables(0).Rows(0).Item("Correo")
                End If
                If dts.Tables(0).Rows(0).Item("Correo1") Is System.DBNull.Value Then
                    TxtCorreo1.Text = ""
                Else
                    TxtCorreo1.Text = dts.Tables(0).Rows(0).Item("Correo1")
                End If
                If dts.Tables(0).Rows(0).Item("Correo2") Is System.DBNull.Value Then
                    TxtCorreo2.Text = ""
                Else
                    TxtCorreo2.Text = dts.Tables(0).Rows(0).Item("Correo2")
                End If
                If dts.Tables(0).Rows(0).Item("Correo3") Is System.DBNull.Value Then
                    TxtCorreo3.Text = ""
                Else
                    TxtCorreo3.Text = dts.Tables(0).Rows(0).Item("Correo3")
                End If

                If dts.Tables(0).Rows(0).Item("Telefono") Is System.DBNull.Value Then
                    TxtTelefono.Text = ""
                Else
                    TxtTelefono.Text = dts.Tables(0).Rows(0).Item("Telefono")
                End If
                If dts.Tables(0).Rows(0).Item("Telefono1") Is System.DBNull.Value Then
                    TxtTelefono1.Text = ""
                Else
                    TxtTelefono1.Text = dts.Tables(0).Rows(0).Item("Telefono1")
                End If
                If dts.Tables(0).Rows(0).Item("Telefono2") Is System.DBNull.Value Then
                    TxtTelefono2.Text = ""
                Else
                    TxtTelefono2.Text = dts.Tables(0).Rows(0).Item("Telefono2")
                End If
                If dts.Tables(0).Rows(0).Item("Telefono3") Is System.DBNull.Value Then
                    TxtTelefono3.Text = ""
                Else
                    TxtTelefono3.Text = dts.Tables(0).Rows(0).Item("Telefono3")
                End If
                If dts.Tables(0).Rows(0).Item("Realizo_llamada") Is System.DBNull.Value Then
                    TxtRealizoLlamada.Text = ""
                Else
                    TxtRealizoLlamada.Text = dts.Tables(0).Rows(0).Item("Realizo_llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Contacto_Adicional") Is System.DBNull.Value Then
                    TxtContacto_Adicional.Text = ""
                Else
                    TxtContacto_Adicional.Text = dts.Tables(0).Rows(0).Item("Contacto_Adicional")
                End If
                If dts.Tables(0).Rows(0).Item("Comentario") Is System.DBNull.Value Then
                    TxtComentario.Text = ""
                Else
                    TxtComentario.Text = dts.Tables(0).Rows(0).Item("Comentario")
                End If
            Else
                lblmsg.Text = "No se encontraron registros con ese caso: " + txtcaso.Text
                drlEmpresa.SelectedValue = "- Seleccione -"
                TxtNombre.Text = ""
                TxtNombre1.Text = ""
                TxtNombre2.Text = ""
                TxtNombre3.Text = ""


                TxtCargo.Text = ""
                TxtCargo1.Text = ""
                TxtCargo2.Text = ""
                TxtCargo3.Text = ""

                TxtCorreo.Text = ""
                TxtCorreo1.Text = ""
                TxtCorreo2.Text = ""
                TxtCorreo3.Text = ""

                TxtTelefono.Text = ""
                TxtTelefono1.Text = ""
                TxtTelefono2.Text = ""
                TxtTelefono3.Text = ""

                
                TxtRealizoLlamada.Text = ""
                TxtContacto_Adicional.Text = ""
                TxtComentario.Text = ""
                LblCaso.Text = ""
                Exit Sub

            End If
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnActualizar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnActualizar.Click
        Try
            If LblCaso.Text = "" Then
                lblmsg.Text = "Realice la consulta del caso antes de actualizar"
                Exit Sub
            End If

            ObjVoz.Validacion = "1"

            ObjVoz.Empresa = drlEmpresa.Text

            ObjVoz.Nombre = TxtNombre.Text
            ObjVoz.Nombre1 = TxtNombre1.Text
            ObjVoz.Nombre2 = TxtNombre2.Text
            ObjVoz.Nombre3 = TxtNombre3.Text

            'ObjVoz.Apellido = TxtApellido.Text

            ObjVoz.Cargo = TxtCargo.Text
            ObjVoz.Cargo1 = TxtCargo1.Text
            ObjVoz.Cargo2 = TxtCargo2.Text
            ObjVoz.Cargo3 = TxtCargo3.Text

            ObjVoz.Correo = TxtCorreo.Text
            ObjVoz.Correo1 = TxtCorreo1.Text
            ObjVoz.Correo2 = TxtCorreo2.Text
            ObjVoz.Correo3 = TxtCorreo3.Text

            'If TxtTelefono.Text = "" Then
            '    ObjVoz.Telefono = Nothing
            'Else
            '    ObjVoz.Telefono = TxtTelefono.Text
            'End If
            'If TxtCelular.Text = "" Then
            '    ObjVoz.Celular = Nothing
            'Else
            '    ObjVoz.Celular = TxtCelular.Text
            'End If

            ObjVoz.Telefono = TxtTelefono.Text
            ObjVoz.Telefono1 = TxtTelefono1.Text
            ObjVoz.Telefono2 = TxtTelefono2.Text
            ObjVoz.Telefono3 = TxtTelefono3.Text
            'ObjVoz.Contacto_CLO = TxtContacto_CLO.Text
            'ObjVoz.Envio_Invitacion = TxtEnvio_Invitacion.Text
            ObjVoz.resolucion = TxtRealizoLlamada.Text
            ObjVoz.Contacto_Adicional = TxtContacto_Adicional.Text
            ObjVoz.Realizo_llamada = TxtRealizoLlamada.Text
            ObjVoz.Comentario = TxtComentario.Text
            ObjVoz.Cod_Bandeja_MTI = LblCaso.Text
            ObjVoz.idusuario = lblusuario.Text

            ObjVoz.Actualizacion_MTI()

            'ObjVoz.Recepcion_Inivtacion = drlRecepcion_Invitacion.Text
            'ObjVoz.Persona_Interesada = drlPersonaInteresada.Text
            'ObjVoz.Asiste = drlAsiste_Evento.Text

            lblmsg.Text = "Registro actualizado"

            TxtNombre.Text = ""
            TxtNombre1.Text = ""
            TxtNombre2.Text = ""
            TxtNombre3.Text = ""
            'TxtApellido.Text = ""

            TxtCargo.Text = ""
            TxtCargo1.Text = ""
            TxtCargo2.Text = ""
            TxtCargo3.Text = ""

            TxtCorreo.Text = ""
            TxtCorreo1.Text = ""
            TxtCorreo2.Text = ""
            TxtCorreo3.Text = ""

            TxtTelefono.Text = ""
            TxtTelefono1.Text = ""
            TxtTelefono2.Text = ""
            TxtTelefono3.Text = ""

            'TxtCelular.Text = ""
            'TxtContacto_CLO.Text = ""
            'TxtEnvio_Invitacion.Text = ""
            TxtRealizoLlamada.Text = ""
            TxtContacto_Adicional.Text = ""
            TxtComentario.Text = ""
            LblCaso.Text = ""
            txtcaso.Text = ObjVoz.Cod_Bandeja_MTI

            Cargar_Drl()

        Catch ex As Exception
            lblmsg.Text = "Sepresento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnRegNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnRegNuevo.Click
        Try
            If drlEmpresa.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una empresa"
                Exit Sub
            End If
            If TxtNombre.Text = "" Then
                lblmsg.Text = "Ingrese un nombre"
                Exit Sub
            End If
            If TxtTelefono.Text = "" Then
                lblmsg.Text = "Ingrese un telefono"
                Exit Sub
            End If

            ObjVoz.Empresa = drlEmpresa.Text

            ObjVoz.Nombre = TxtNombre.Text
            ObjVoz.Nombre1 = TxtNombre1.Text
            ObjVoz.Nombre2 = TxtNombre2.Text
            ObjVoz.Nombre3 = TxtNombre3.Text

            'ObjVoz.Apellido = TxtApellido.Text

            ObjVoz.Cargo = TxtCargo.Text
            ObjVoz.Cargo1 = TxtCargo1.Text
            ObjVoz.Cargo2 = TxtCargo2.Text
            ObjVoz.Cargo3 = TxtCargo3.Text

            ObjVoz.Correo = TxtCorreo.Text
            ObjVoz.Correo1 = TxtCorreo1.Text
            ObjVoz.Correo2 = TxtCorreo2.Text
            ObjVoz.Correo3 = TxtCorreo3.Text

            'If TxtTelefono.Text = "" Then
            '    ObjVoz.Telefono = Nothing
            'Else
            '    ObjVoz.Telefono = TxtTelefono.Text
            'End If
            'If TxtCelular.Text = "" Then
            '    ObjVoz.Celular = Nothing
            'Else
            '    ObjVoz.Celular = TxtCelular.Text
            'End If

            ObjVoz.Telefono = TxtTelefono.Text
            ObjVoz.Telefono1 = TxtTelefono1.Text
            ObjVoz.Telefono2 = TxtTelefono2.Text
            ObjVoz.Telefono3 = TxtTelefono3.Text

            'ObjVoz.Contacto_CLO = TxtContacto_CLO.Text
            'ObjVoz.Envio_Invitacion = TxtEnvio_Invitacion.Text
            ObjVoz.resolucion = TxtRealizoLlamada.Text
            ObjVoz.Contacto_Adicional = TxtContacto_Adicional.Text
            ObjVoz.Realizo_llamada = TxtRealizoLlamada.Text
            ObjVoz.Comentario = TxtComentario.Text
            ObjVoz.idusuario = lblusuario.Text



            ObjVoz.Registro_MTI()

            ObjVoz.Consulta_Registro_MTI()

            lblmsg.Text = "Registro realizado con el codigo: " + ObjVoz.Cod_Bandeja_MTI.ToString

            txtcaso.Text = ObjVoz.Cod_Bandeja_MTI

            TxtNombre.Text = ""
            TxtNombre1.Text = ""
            TxtNombre2.Text = ""
            TxtNombre3.Text = ""

            'TxtApellido.Text = ""
            TxtCargo.Text = ""
            TxtCargo1.Text = ""
            TxtCargo2.Text = ""
            TxtCargo3.Text = ""

            TxtCorreo.Text = ""
            TxtCorreo1.Text = ""
            TxtCorreo2.Text = ""
            TxtCorreo3.Text = ""

            TxtTelefono.Text = ""
            TxtTelefono1.Text = ""
            TxtTelefono2.Text = ""
            TxtTelefono3.Text = ""

            'TxtCelular.Text = ""
            'TxtContacto_CLO.Text = ""
            'TxtEnvio_Invitacion.Text = ""
            TxtRealizoLlamada.Text = ""
            TxtContacto_Adicional.Text = ""
            TxtComentario.Text = ""
            LblCaso.Text = ""
            Cargar_Drl()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnActualizar_Estado_Llamada_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnActualizar_Estado_Llamada.Click
        Try
            If LblCaso.Text = "" Then
                lblmsg.Text = "Realice la consulta del caso antes de actualizar"
                Exit Sub
            End If
            If drlEstado_llamada.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un estado para la llamada"
                Exit Sub
            End If
            If drlEstado_llamada.Text <> "Contacto Efectivo" Then
                If TxtFecha_Programada.Text = "" Or TxtHora_Programada.Text = "" Or TxtMinuto_Programado.Text = "" Then
                    lblmsg.Text = "Ingrese la fecha en la que volvera a ponerse en contacto"
                    Exit Sub
                End If
                If Integer.Parse(TxtHora_Programada.Text) > "23" Or Integer.Parse(TxtHora_Programada.Text) < "1" Then
                    lblmsg.Text = "verifique la hora en la que realizara nuevamente contacto"
                    Exit Sub
                End If
                If Integer.Parse(TxtMinuto_Programado.Text) > "59" Or Integer.Parse(TxtMinuto_Programado.Text) < "0" Then
                    lblmsg.Text = "verifique los minutos en los que realizara nuevamente contacto"
                    Exit Sub
                End If
                ObjVoz.Fc_Programado = TxtFecha_Programada.Text + " " + TxtHora_Programada.Text + ":" + TxtMinuto_Programado.Text
            Else
                ObjVoz.Fc_Programado = "01/01/0001"
            End If
            ObjVoz.Validacion = "2"
            ObjVoz.Cod_Bandeja_MTI = LblCaso.Text
            ObjVoz.Estado_Llamada = drlEstado_llamada.Text
            ObjVoz.idusuario = lblusuario.Text

            ObjVoz.Actualizacion_MTI()

            lblmsg.Text = "Estado de la llamada actualizado"
            TxtFecha_Programada.Text = ""
            TxtHora_Programada.Text = ""
            TxtMinuto_Programado.Text = ""
            Cargar_Drl()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    'Protected Sub BtnActualizar_Invitacion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnActualizar_Invitacion.Click
    '    Try
    '        If LblCaso.Text = "" Then
    '            lblmsg.Text = "Realice la consulta del caso antes de actualizar"
    '            Exit Sub
    '        End If
    '        'If drlRecepcion_Invitacion.Text = "- Seleccione -" Then
    '        '    lblmsg.Text = "Seleccione una opcion de recepcion"
    '        '    Exit Sub
    '        'End If
    '        'If drlPersonaInteresada.Text = "- Seleccione -" Then
    '        '    lblmsg.Text = "seleccione una opcion de persona interesada"
    '        '    Exit Sub
    '        'End If
    '        'If drlAsiste_Evento.Text = "- Seleccione -" Then
    '        '    lblmsg.Text = "seleccione una opcion de asistencia"
    '        '    Exit Sub
    '        'End If
    '        ObjVoz.Validacion = "3"
    '        ObjVoz.Cod_Bandeja_MTI = LblCaso.Text
    '        ObjVoz.Recepcion_Invitacion = drlRecepcion_Invitacion.Text
    '        ObjVoz.Persona_Interesada = drlPersonaInteresada.Text
    '        ObjVoz.Asiste = drlAsiste_Evento.Text
    '        ObjVoz.idusuario = lblusuario.Text
    '        ObjVoz.Actualizacion_MTI()
    '        lblmsg.Text = "Datos sobre la invitacion actualizados"
    '        Cargar_Drl()
    '    Catch ex As Exception
    '        lblmsg.Text = "Se presento error: " + ex.Message
    '    End Try
    'End Sub

    Protected Sub BtnConsulta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsulta.Click
        Try
            If drlEstado_Llamada_Consulta.Text <> "- Seleccione -" And drlEstado_Llamada_Consulta.Text <> Nothing Then
                ObjVoz.Estado_Llamada = drlEstado_Llamada_Consulta.Text
            End If
            'If drlPersonaInteresada_Consulta.Text <> "- Seleccione -" And drlPersonaInteresada_Consulta.Text <> Nothing Then
            '    ObjVoz.Persona_Interesada = drlPersonaInteresada_Consulta.Text
            'End If
            'If drlAsiste_Evento_Consulta.Text <> "- Seleccione -" And drlAsiste_Evento_Consulta.Text <> Nothing Then
            '    ObjVoz.Asiste = drlAsiste_Evento_Consulta.Text
            'End If
            If drlEmpresa_Consulta.Text <> "- Seleccione -" And drlEmpresa_Consulta.Text <> Nothing Then
                ObjVoz.Empresa = drlEmpresa_Consulta.Text
            End If
            If TxtFecha_Programada_Consulta.Text <> "" Then
                ObjVoz.Fc_Programado = TxtFecha_Programada_Consulta.Text
            End If

            dtggeneral.DataSource = ObjVoz.Consulta_Bandeja_MTI
            dtggeneral.DataBind()

            lblcuenta.Text = ObjVoz.cantidad

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
End Class
