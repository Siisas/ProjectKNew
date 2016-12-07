Public Class dilo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                objdatos.idusuario = lblusuario.Text
                Consulta_Asignados()
                objdatos.consultared()

                If objdatos.estado <> " " Then
                    btncrea.Visible = True
                Else
                    btncrea.Visible = False
                End If

                '--------inconsistencia encuesta---------'
                With drlinconsistencia
                    .DataSource = objdatos.Consulta_inconsistencia_encuesta
                    .DataTextField = "Nombre"
                    .DataValueField = "Cod_BD_Datos_Complemento"
                    .DataBind()
                End With
                '-----------------'

                With drldpto
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultadpto
                    .DataTextField = "nombredpto"
                    .DataValueField = "coddpto"
                    .DataBind()
                End With
                objdatos.dpto = drldpto.SelectedItem.Value
                With drlmun
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultamun
                    .DataTextField = "nombremun"
                    .DataValueField = "coddiv"
                    .DataBind()
                End With
                'Cargo drlMotivo de la campaña NxMonitor
                Dim ObjclsDatos As New clscrmdatos
                'With drlMotivo
                '    .DataSource = ObjclsDatos.Consulta_Campo_NxMonitor
                '    .DataTextField = "Nombre_NxMonitor"
                '    .DataValueField = "Nombre_NxMonitor"
                '    .DataBind()
                'End With
                'Inconsistencia Global
                objdatos.cargo = "Global"
                With drlinconsglobal
                    .DataSource = objdatos.consultaincdatos
                    .DataTextField = "inconsistencia"
                    .DataValueField = "idtipoinc"
                    .DataBind()
                End With
                'Inconsistencia
                objdatos.cargo = "Global2"
                objdatos.estado = drlincons.Text
                With drlincons
                    .DataSource = objdatos.consultaincdatos
                    .DataTextField = "inconsistencia"
                    .DataValueField = "idtipoinc"
                    .DataBind()
                End With
                With drlmarca
                    .DataSource = objdatos.consultamarca
                    .DataTextField = "marca"
                    .DataValueField = "marca"
                    .DataBind()
                End With
                objdatos.estado = drlmarca.SelectedItem.Value
                With drlequipo
                    .DataSource = objdatos.consultaequipo
                    .DataTextField = "equipo"
                    .DataValueField = "equipo"
                    .DataBind()
                End With
                With drlvariable
                    objdatos.idusuario = 6
                    .DataSource = objdatos.consultadiagnostico
                    .DataTextField = "detalle"
                    .DataValueField = "idreg"
                    .DataBind()
                End With
                'caracteristicas
                With drlFcaract
                    .DataSource = objdatos.consultacaractdat
                    .DataTextField = "desccarac"
                    .DataValueField = "idcarac"
                    .DataBind()
                End With
                'objdatos.idusuario = lblusuario.Text
                'objdatos.ConsultaSinRestriccion()
                'If objdatos.cantreg > 0 Then
                '    With drlgrupo
                '        .DataSource = objdatos.consultagrupo
                '        .DataTextField = "grupo"
                '        .DataValueField = "grupo"
                '        .DataBind()
                '    End With
                '    objdatos.tipo = drlgrupo.SelectedItem.Value
                '    objdatos.estado = drltipificacionll.SelectedItem.Text
                '    With drltsoporte
                '        .DataSource = objdatos.consultatsoportegrupo
                '        .DataTextField = "escenario"
                '        .DataValueField = "escenario"
                '        .DataBind()
                '    End With
                'Else
                '    objdatos.estado = drltipificacionll.SelectedItem.Text
                '    'grupo de tipificación
                '    With drlgrupo
                '        .DataSource = objdatos.consultagrupoResticcion
                '        .DataTextField = "grupo"
                '        .DataValueField = "grupo"
                '        .DataBind()
                '    End With
                '    objdatos.tipo = drlgrupo.SelectedItem.Value
                '    objdatos.estado = drltipificacionll.SelectedItem.Text
                '    With drltsoporte
                '        .DataSource = objdatos.consultatsoportegrupoRestriccion
                '        .DataTextField = "escenario"
                '        .DataValueField = "escenario"
                '        .DataBind()
                '    End With
                'End If
                LblPQR.Text = objdatos.Consulta_Numero_PQR().Tables(0).Rows(0).Item("Nombre")
                cargadrl()
                With DrlCanalDilo
                    .DataSource = objdatos.Consulta_Complemento_CanalDilo
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                End With

                With DrlCanalDiloNv
                    .DataSource = objdatos.Consulta_Complemento_CanalDilo
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
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
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Consulta_Asignados()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.idusuario = lblusuario.Text
            objdatos.Validacion = "Asignados"

            Session("Asignados") = objdatos.Consulta_Asignado_Dilo
            dtgprog.DataSource = Session("Asignados")
            dtgprog.DataBind()
            lblcasos_asig.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Public Sub cargadrl()
        Try
            Dim objdatos As New clsgeneral
            'linea
            objdatos.identidad = 21
            With drllinea
                .DataSource = objdatos.consultalineadt
                .DataTextField = "tipo"
                .DataValueField = "tipo"
                .DataBind()
            End With

            'servicio
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.identidad = 21
            With drlservicio2
                .DataSource = objdatos.consultaservicio
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            'subservicio
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.mun = drlservicio2.SelectedItem.Text
            objdatos.identidad = 21
            With drlsubservicio
                .DataSource = objdatos.consultasubservicio
                .DataTextField = "tipificacion"
                .DataValueField = "tipificacion"
                .DataBind()
            End With
            'solicitud
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.mun = drlservicio2.SelectedItem.Text
            objdatos.nombre = drlsubservicio.SelectedItem.Text
            objdatos.identidad = 21
            With drlsolicitud
                .DataSource = objdatos.consultasolicitud
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
            With drlvariableCatalogo
                objdatos.idusuario = 6
                .DataSource = objdatos.consultadiagnostico
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
            'reclamo ppal
            With drlreclamoppal
                .DataSource = objdatos.consultareclamo
                .DataTextField = "descreclamo"
                .DataValueField = "descreclamo"
                .DataBind()
            End With
            objdatos.tipo = drlreclamoppal.SelectedItem.Value
            'tipo falla
            With drltipofalla
                .DataSource = objdatos.consultatipofalla
                .DataTextField = "desctipofalla"
                .DataValueField = "desctipofalla"
                .DataBind()
            End With
            '*Catalogo de Servicio 3 drl
            'Tipo PQR
            objdatos.Validacion = "Tipo PQR"
            With drlTipo_PQR
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            'Tipo Cliente
            'objdatos.Validacion = "Tipo Cliente"
            'With drlTipo_Cliente
            '    .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
            '    .DataTextField = "tipo2"
            '    .DataValueField = "tipo2"
            '    .DataBind()
            'End With
            'Modalidad
            objdatos.Validacion = "Modalidad"
            With drlModalidad
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            '*CATALOGO DE DIAGNOSTICO
            '---Causa Raiz---'
            objdatos.idusuario = lblusuario.Text
            objdatos.ConsultaSinRestriccion()
            If objdatos.cantreg > 0 Then
                objdatos.Validacion = "Causa raiz"
                With drlCausa_Raiz
                    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                    .DataTextField = "tipificacion1"
                    .DataValueField = "tipificacion1"
                    .DataBind()
                End With
            Else
                objdatos.Validacion = "Causa raiz 2"
                With drlCausa_Raiz
                    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                    .DataTextField = "tipificacion1"
                    .DataValueField = "tipificacion1"
                    .DataBind()
                End With
            End If

            'Segmento
            objdatos.Validacion = "Segmento"
            objdatos.localidad = drlCausa_Raiz.SelectedValue
            With drlSegmento
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion4"
                .DataValueField = "tipificacion4"
                .DataBind()
            End With
            'Elemento
            objdatos.Validacion = "Elemento"
            objdatos.localidad = drlCausa_Raiz.SelectedValue
            objdatos.nombre = drlSegmento.SelectedItem.Text
            With drlElemento
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion3"
                .DataValueField = "id_tipificacion"
                .DataBind()
            End With
            'Tipo de falla
            objdatos.Validacion = "Tipo de falla"
            objdatos.localidad = drlElemento.SelectedValue
            With drlTipo_De_Falla
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion2"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With

            ''''''''''''''''''CATEGORIA DE CIERRE''''''''''''''''''''''
            'tipo soporte'
            objdatos.Validacion = "Tipo Soporte"
            objdatos.localidad = drlTipo_De_Falla.SelectedValue
            With drltsoporte
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion2"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With

            'grupo
            objdatos.Validacion = "Grupo"
            objdatos.localidad = drlTipo_De_Falla.SelectedValue
            objdatos.nombre = drltsoporte.SelectedItem.Text
            With drlgrupo
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion1"
                .DataValueField = "tipificacion1"
                .DataBind()
            End With


            '----Estados---'           
            objdatos.Validacion = "Estado"
            objdatos.localidad = "Tipificacion"
            objdatos.nombre = drltsoporte.SelectedValue
            With drltipificacionll
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion2"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With

           '*CATEGORIA DE CIERRE
            'Categoria de cierre drl
            objdatos.Validacion = "Categoria de cierre"
            objdatos.localidad = drltipificacionll.SelectedValue
            With drlCategoriaCierre
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion1"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With

            



            'Categoria de cierre drl
            'objdatos.Validacion = "Categoria de cierre"
            'With drlCategoriaCierre
            '    .DataSource = objdatos.Consulta_Cargue_Catalogo_Servicio_V2
            '    .DataTextField = "tipificacion"
            '    .DataValueField = "idreg"
            '    .DataBind()
            'End With
            'Categoria de cierre lbl
            'LblCategoriaCierre.Text = ""
            '* FALLA DE RED - VALIDACIONES SERVICIO AL CLINETE
            'Tipo de Edificacion Donde se Presenta la Falla
            objdatos.Validacion = "VF_Tipo_Edificacion_Donde_Presenta_Falla_1"
            With Drl_Tipo_Edificacion_Donde_Presenta_Falla_1
                .DataSource = objdatos.Carga_Drl_Servicio_Cliente_SAC
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
            objdatos.Validacion = "VF_Tipo_Edificacion_Donde_Presenta_Falla_2"
            With Drl_Tipo_Edificacion_Donde_Presenta_Falla_2
                .DataSource = objdatos.Carga_Drl_Servicio_Cliente_SAC
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
            'Tecnologia en la que se Presenta la Falla Luego de pruebas
            objdatos.Validacion = "VF_Tecnologia_Presenta_Falla_Luegodepruebas"
            With Drl_Tecnologia_Presenta_Falla_Luegodepruebas
                .DataSource = objdatos.Carga_Drl_Servicio_Cliente_SAC
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
            'Para cuando la opcion "No existen cambios administrativos sobre la línea o cuenta maestra" sea falsoSplit_Billing
            objdatos.Validacion = "Split_Billing"
            With Drl_Split_Billing
                .DataSource = objdatos.Carga_Drl_Servicio_Cliente_SAC
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
            'Valores de HLR_HSS
            objdatos.Validacion = "HLR_HSS"
            With Drl_HLR_HSS
                .DataSource = objdatos.Carga_Drl_Servicio_Cliente_SAC
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
            'Se forza la red del dispositivo
            objdatos.Validacion = "VF_Forza_Red_Dispositivo"
            With Drl_Forza_Red_Dispositivo
                .DataSource = objdatos.Carga_Drl_Servicio_Cliente_SAC
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
            'Se verifica o realiza configuración de APN
            objdatos.Validacion = "VF_Verifica_Realiza_Configuración_APN"
            With Drl_Verifica_Realiza_Configuración_APN
                .DataSource = objdatos.Carga_Drl_Servicio_Cliente_SAC
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With
            ' Qos
            objdatos.Validacion = "VF_Qos"
            With Drl_Qos
                .DataSource = objdatos.Carga_Drl_Servicio_Cliente_SAC
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
            End With


        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Public Sub Consulta_Gestion()
        Try
            Dim ObjDatos As New clscrmdatos
            Dim dts As New DataSet
            ObjDatos.CampanaLogin = LblPerfil.Text
            ObjDatos.estadoinc = drltipificacionll.SelectedItem.Text
            dts = ObjDatos.Consulta_Gestion_Campaña()
            If dts.Tables(0).Rows.Count > 0 Then
                ObjDatos.caso = lblcaso.Text
                ObjDatos.idusuario = lblusuario.Text
                ObjDatos.estadoinc = drltipificacionll.SelectedItem.Text
                ObjDatos.CampanaLogin = LblPerfil.Text
                ObjDatos.Superv = LblSupervisor.Text
                ObjDatos.Ingreso_Gestion()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub guardadiagnostico()
        Try
            Dim objdatos As New clscrmdatos
            'If drlTipo_PQR.SelectedItem.Text <> "- Seleccione -" Or drlTipo_Cliente.SelectedItem.Text <> "- Seleccione -" Or drlModalidad.SelectedItem.Text <> "- Seleccione -" Or drlCausa_Raiz.SelectedItem.Text <> "- Seleccione -" Or drlCategoriaCierre.SelectedItem.Text <> "- Seleccione -" Or drlsolicitud.SelectedItem.Text = "- Seleccione -" Or drltipofalla.SelectedItem.Text = "- Seleccione -" Or drlvariableCatalogo.SelectedItem.Text = "- Seleccione -" Then
            'Condicion nueva
            If drlTipo_PQR.SelectedItem.Text <> "- Seleccione -" Or drlModalidad.SelectedItem.Text <> "- Seleccione -" Or drlCausa_Raiz.SelectedItem.Text <> "- Seleccione -" Or drlCategoriaCierre.SelectedItem.Text <> "- Seleccione -" Or drlsolicitud.SelectedItem.Text = "- Seleccione -" Or drltipofalla.SelectedItem.Text = "- Seleccione -" Or drlvariableCatalogo.SelectedItem.Text = "- Seleccione -" Then

                '-----------Inconsistencia-------------'
                If drlinconsistencia.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.inconsistencia_encuesta = ""
                ElseIf drlinconsistencia.SelectedItem.Text <> "Otro" Then
                    objdatos.inconsistencia_encuesta = drlinconsistencia.SelectedItem.Text
                Else
                    objdatos.inconsistencia_encuesta = txtobsincon.Text
                End If
                '----------------------'

                If drlTipo_PQR.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Tipo_PQR = ""
                Else
                    objdatos.Tipo_PQR = drlTipo_PQR.SelectedItem.Text
                End If
                'NUEVO
                'If drlTipo_Cliente.SelectedItem.Text = "- Seleccione -" Then
                objdatos.Tipo_Cliente = ""
                'Else
                '    objdatos.Tipo_Cliente = drlTipo_Cliente.SelectedItem.Text
                'End If
                If drlModalidad.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Modalidad = ""
                Else
                    objdatos.Modalidad = drlModalidad.SelectedItem.Text
                End If
                If drlTipo_De_Falla.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Causa_Raiz = "0"
                Else
                    objdatos.Causa_Raiz = drlTipo_De_Falla.SelectedValue
                End If
                If drlCategoriaCierre.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.Categoria_Cierre = "0"
                Else
                    objdatos.Categoria_Cierre = drlCategoriaCierre.SelectedValue
                End If
                If drlsolicitud.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.solicitud = "0"
                Else
                    objdatos.solicitud = drlsolicitud.SelectedItem.Value
                End If
                If drltipofalla.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.tipofalla = "0"
                Else
                    objdatos.tipofalla = drltipofalla.SelectedItem.Value
                End If
                If drlvariableCatalogo.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.diagvariable = "0"
                Else
                    objdatos.diagvariable = drlvariableCatalogo.SelectedItem.Value
                End If
                objdatos.Validacion = "Diagnostico Dilo y Fidelizacion"
                objdatos.Bandeja = "Dilo"
                objdatos.caso = lblcaso.Text
                objdatos.registrodiag()
                txtbarrio.Text = ""
                cargadrl()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try

    End Sub
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clscrmdatos
        Try
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            objdatos.Validacion = 3
            objdatos.ConsultarEstados()
            If objdatos.tipificacion.Contains("Cerrado") Then
                lblmsg.Text = "¡El Caso que desea guardar se encuentra Cerrado!"
                Exit Sub
            Else
                objdatos.Validacion = Nothing
            End If

            If drltipificacionll.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione la tipificación de la llamada"
                Exit Sub
            Else
                objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            End If
            If txtobs.Text = "" Then
                lblmsg.Text = "Digite la observación de atención al caso"
                Exit Sub
            Else
                objdatos.obs = txtobs.Text
            End If
            'If txtincidente.Text <> "" And drltipincidente.SelectedItem.Value = 19 Then
            '    lblmsg.Text = "Elija un estado para el incidente"
            '    Exit Sub
            'Else
            '    If drltipincidente.SelectedItem.Value = 19 Then
            objdatos.estadoinc = ""
            '    Else
            '        objdatos.estadoinc = drltipincidente.SelectedItem.Text
            '    End If
            'End If
            'If drltipificacionll.SelectedItem.Text = "Escalado" Then
            '    If drlmesaesc.SelectedItem.Value = "0" Then
            '        lblmsg.Text = "Seleccione la mesa a la que se escala el caso"
            '        Exit Sub
            '    Else
            '        objdatos.mesaesc = drlmesaesc.SelectedItem.Text
            '    End If
            '    If txtincidente.Text = "" Then
            '        lblmsg.Text = "Digite el número de incidente asignado"
            '        Exit Sub
            '    Else
            '        objdatos.incidente = txtincidente.Text
            '    End If
            'Else
            objdatos.mesaesc = ""
            objdatos.incidente = ""
            'End If
            If (drltipificacionll.SelectedItem.Text = "Cerrado" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD") And drlmun.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el departamento y municipio"
                Exit Sub
            End If
            objdatos.mun = drlmun.SelectedItem.Value

            If txtbarrio.Text = "" And drltipificacionll.SelectedItem.Text <> "No Contactado" Then
                lblmsg.Text = "Digite el barrio"
                Exit Sub
            Else
                objdatos.barrio = txtbarrio.Text
            End If


            'If drlIntalaApp.Enabled = True And drlMotivo.Enabled = True Then
            '    If drlIntalaApp.Text = "1" Then
            '        lblmsg.Text = "Seleccione una opcion de instalacion de APP"
            '        Exit Sub
            '    End If
            '    If drlIntalaApp.Text = "NO" Then
            '        If drlMotivo.Text = "- Seleccione -" Then
            '            lblmsg.Text = "Seleccione un motivo por el cual no se instalo la APP"
            '            Exit Sub
            '        Else
            '            objdatos.preg2 = drlIntalaApp.Text
            '            objdatos.preg3 = drlMotivo.Text
            '        End If
            '    Else
            '        objdatos.preg2 = drlIntalaApp.Text
            '        objdatos.preg3 = "OK"
            '    End If
            'Else
            '    objdatos.preg2 = Nothing
            'End If
            If drltsoporte.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el tipo de soporte brindado"
                Exit Sub
            End If
            objdatos.tiposoporte = drltsoporte.SelectedItem.Text
            If drlTipo_PQR.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un tipo PQR"
                Exit Sub
            End If
            'If drlTipo_Cliente.SelectedItem.Text = "- Seleccione -" Then
            '    lblmsg.Text = "Seleccione un tipo de cliente"
            '    Exit Sub
            'End If
            If drlModalidad.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una modalidad"
                Exit Sub
            End If
            If drlsolicitud.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una Solicitud / Tipo Falla (VOZ DEL CLIENTE - Solicitud / Tipo Falla)"
                Exit Sub
            End If
            If drltipificacionll.SelectedItem.Text = "Cerrado" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD" Or drltipificacionll.SelectedItem.Text = "Gestionado" Then
                If drlreclamoppal.SelectedItem.Text = "- Seleccione -" Or drltipofalla.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Si el caso es cerrado, Solicitud Escalar o gestionado, debe elegir el reclamo principal y el tipo de falla (CATALOGO DE DIAGNOSTICO - Reclamo Principal & Tipo Falla Rec Ppal)"
                    Exit Sub
                End If
            End If
            If drlCausa_Raiz.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una causa raiz de falla"
                Exit Sub
            End If
            If drlCategoriaCierre.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una categoria de cierre"
                Exit Sub
            End If
            If TxtPQR.Text = "" Then
                lblmsg.Text = "Ingrese el consecutivo PQR"
                Exit Sub
            Else
                objdatos.pqr = Int64.Parse(LblPQR.Text + TxtPQR.Text)
            End If

            '---Programado---'
            If drltipificacionll.SelectedItem.Text = "Programado" Then
                If txtfc_programado.Text = "" Then
                    lblmsg.Text = "Seleccione una fecha de programacion"
                    Exit Sub
                Else
                    If txtfc_programado.Text < DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") Then
                        lblmsg.Text = "La fecha debe ser mayor a la actual"
                        Exit Sub
                    End If
                    objdatos.horaprog = txtfc_programado.Text
                End If
            Else
                objdatos.horaprog = Nothing
            End If
            '---Fin Programados---'



            '-------Escalar--------'
            If (drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD") And lblescalamiento.Text = Nothing Then
                lblmsg.Text = "Antes de que realice el registro de gestion, debe realizar el escalamiento a falla de red o services"
                Exit Sub
            Else
                If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar CPD" And lblescalamiento.Text = "Falla de red" Then
                    lblmsg.Text = "Si reporto falla de red el estado del caso debe ser Solicitud Escalar CPD"
                    Exit Sub
                End If
                If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar SD" And lblescalamiento.Text = "Escalamiento" Then
                    lblmsg.Text = "Si realizó Escalamiento Service el estado del caso debe ser Solicitud Escalar SD"
                    Exit Sub
                End If
            End If

            '-----------inconsistencia--------'
            If drltipificacionll.SelectedItem.Text = "Cerrado" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar CPD" Or drltipificacionll.SelectedItem.Text = "Solicitud Escalar SD" Then
                If drlinconsistencia.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione inconsistencia en *611 / ENCUESTA"
                    Exit Sub
                Else
                    If drlinconsistencia.SelectedItem.Text = "Otro" And txtobsincon.Text = "" Then
                        lblmsg.Text = "Escriba una observacion en inconsistencia"
                        Exit Sub
                    ElseIf drlinconsistencia.SelectedItem.Text <> "Otro" Then
                        objdatos.inconsistencia_encuesta = drlinconsistencia.SelectedItem.Text
                    Else
                        objdatos.inconsistencia_encuesta = txtobsincon.Text
                    End If
                End If
            Else
                If drlinconsistencia.SelectedItem.Text = "- Seleccione -" Then
                    objdatos.inconsistencia_encuesta = ""
                ElseIf drlinconsistencia.SelectedItem.Text = "Otro" And txtobsincon.Text = "" Then
                    lblmsg.Text = "Escriba una observacion en inconsistencia"
                    Exit Sub
                ElseIf drlinconsistencia.SelectedItem.Text <> "Otro" Then
                    objdatos.inconsistencia_encuesta = drlinconsistencia.SelectedItem.Text
                Else
                    objdatos.inconsistencia_encuesta = txtobsincon.Text
                End If
            End If
            '---------------------'
            '------Numero Alterno------'
            If chkSi.Checked = False And chkNo.Checked = False Then
                lblmsg.Text = "Seleccione si realizo contacto a linea alterna"
                Exit Sub
            Else
                If chkSi.Checked = True Then
                    If txtnumalt.Text = "" Then
                        lblmsg.Text = "Digite el numero alterno"
                        Exit Sub
                    Else
                        objdatos.telalt = txtnumalt.Text
                    End If
                End If
                If chkNo.Checked = True Then
                    objdatos.telalt = lblmin.Text
                End If
            End If
            '----Fin numero alterno------'



            objdatos.idusuario = lblusuario.Text
            objdatos.registrodilo()
            actbandeja()
           '---Autoasignar caso---'
            If drltipificacionll.SelectedItem.Text = "Programado" Then
                If drlLibera.SelectedItem.Text = "SI" Then
                    objdatos.caso = lblcaso.Text
                    objdatos.Validacion = "Libera"
                    objdatos.asignacionDilo()
                ElseIf drlLibera.SelectedItem.Text = "NO" Then
                    objdatos.caso = lblcaso.Text
                    objdatos.idusuario = lblusuario.Text
                    objdatos.Validacion = "Autoasigna"
                    objdatos.asignacionDilo()
                End If
            End If


            guardadiagnostico()
            buscarinf()
            Consulta_Gestion()
            lblmsg.Text = "Seguimiento ingresado con éxito"
            lbltelcontacto.Text = ""
            lblcliente.Text = ""
            lblfcreporte.Text = ""
            lbltecnologia.Text = ""
            lblequipo.Text = ""
            lbltipofalla.Text = ""
            lblmin.Text = ""
            lblsolicitud.Text = ""
            lblestado.Text = ""
            txtcaso.Text = ""
            txtbarrio.Text = ""
            txtobs.Text = ""
            'txtincidente.Text = ""
            'drlIntalaApp.SelectedValue = 1
            'drlMotivo.SelectedValue = "- Seleccione -"
            'drltipificacionll.SelectedValue = 8
            'drlgrupo.SelectedValue = "- Seleccione -"
            'drltipincidente.SelectedValue = 19
            lblNumero_Alterno.Text = ""
            txtnumalt.Visible = False
            chkSi.Checked = False
            chkNo.Checked = False

            drltipificacionll.SelectedValue = "3"
            drltipificacionll_SelectedIndexChanged(1, Nothing)

            '----Inconsistencia------'
            drlinconsistencia.SelectedValue = 0
            txtobsincon.Text = ""
            txtobsincon.Enabled = False
            '------------------------'

            'drlmesaesc.SelectedValue = "0"
            drldpto.SelectedValue = "0"
            lblcaso.Text = ""
            Lblfc_ingreso.Text = ""
            TxtPQR.Text = ""
            '---Escalamiento---'
            lblescalamiento.Text = ""

            dpto1()
            cargadrl()

            Consulta_Asignados()

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub actbandeja()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            If drltipificacionll.SelectedItem.Value = "- Seleccione -" Then
                lblmsg.Text = "Seleccione la tipificación de la llamada"
                Exit Sub
            Else
                objdatos.tipificacion = drltipificacionll.SelectedItem.Text
            End If
            objdatos.modificarbandejadilo()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub buscarinf()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el Caso o Min que desea consultar"
            Else
                If txtcaso.Text <> "" Then
                    objdatos.caso = txtcaso.Text
                End If
                dtggeneral.DataSource = objdatos.consultadilo
                dtggeneral.DataBind()
                lblcuenta.Text = objdatos.cantidad
                If objdatos.cantidad > 0 Then
                    lblfcreporte.Text = objdatos.fcreg
                    lblmin.Text = objdatos.min
                    lbltelcontacto.Text = objdatos.telcontacto
                    lblcliente.Text = objdatos.cliente
                    lblequipo.Text = objdatos.equipo
                    lbltecnologia.Text = objdatos.tecnologia
                    lbltipofalla.Text = objdatos.tiposoporte
                    lblestado.Text = objdatos.tipificacion
                    lblmesa.Text = objdatos.mesa
                    lblsolicitud.Text = objdatos.obsini
                    lblbarrio.Text = objdatos.barrio
                    lblNumero_Alterno.Text = objdatos.telalt
                    'txtincidente.Text = objdatos.incidente
                    If txtcaso.Text = "" Then
                        txtcaso.Text = objdatos.caso
                    End If
                    lblcaso.Text = objdatos.caso
                    Lblfc_ingreso.Text = objdatos.casfcregistro
                    lblmsg.Text = ""
                Else
                    lblfcreporte.Text = ""
                    lblmin.Text = ""
                    lbltelcontacto.Text = ""
                    lblcliente.Text = ""
                    lblequipo.Text = ""
                    lbltecnologia.Text = ""
                    lbltipofalla.Text = ""
                    lblestado.Text = ""
                    lblmesa.Text = ""
                    lblsolicitud.Text = ""
                    lblbarrio.Text = ""
                    lblNumero_Alterno.Text = ""
                    'txtincidente.Text = ""
                    lblmsg.Text = "No se han encontrado registros coincidentes"
                End If
                ''''ConsultaNxMotor
                'If txtcaso.Text <> "" Then
                '    objdatos.caso = txtcaso.Text
                'End If
                'objdatos.ConsultaNxMonitorDILO()
                'If objdatos.preg2 = "SI" Then
                '    drlIntalaApp.Enabled = False
                '    drlMotivo.Enabled = False
                'Else
                '    drlIntalaApp.Enabled = True
                '    drlMotivo.Enabled = True
                'End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        buscarinf()
    End Sub
    Protected Sub dpto1()
        Try
            Dim objdatos As New clsgeneral
            'divipola - dpto
            objdatos.dpto = drldpto.SelectedItem.Value
            With drlmun
                objdatos.idtip = 1
                .DataSource = objdatos.consultamun
                .DataTextField = "nombremun"
                .DataValueField = "coddiv"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drldpto_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drldpto.SelectedIndexChanged
        Try
            dpto1()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btncrea_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncrea.Click
        Try
            pnnuevo.Visible = True
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar2.Click
        Try
            Dim objdatos As New clscrmdatos
            If txtminnv.Text = "" Then
                lblmsg.Text = "Digite el Min del caso recibido en Dilo"
                Exit Sub
            End If
            If txtnombrenv.Text = "" Then
                lblmsg.Text = "Digite el nombre del usuario del caso recibido en Dilo"
                Exit Sub
            End If
            If DrlCanalDiloNv.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un canal para crear caso"
                Exit Sub
            End If

            objdatos.min = txtminnv.Text
            objdatos.cliente = txtnombrenv.Text
            objdatos.idusuario = lblusuario.Text
            objdatos.mesa = DrlCanalDiloNv.SelectedItem.Text
            objdatos.AsignaConsecDilo()
            Dim cas As String
            cas = objdatos.abierto
            If TxtCasoNuevo.Text <> "" Then
                objdatos.abierto = TxtCasoNuevo.Text
            End If
            objdatos.caso = objdatos.abierto
            objdatos.RegistroDiloNuevo()
            lblmsg.Text = "Registro Dilo ingresado con éxito"
            objdatos.abierto = cas
            txtcaso.Text = objdatos.abierto
            buscarinf()
            pnnuevo.Visible = False
            txtminnv.Text = ""
            TxtCasoNuevo.Text = ""
            txtnombrenv.Text = ""

            DrlCanalDiloNv.SelectedIndex = 0

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton3.Click
        Try
            If lblcaso.Text = "" Then
                lblmsg.Text = "Consulte el caso antes de generar una inconsistencia"
            Else
                Pninc.Visible = True
                PNEscalam.Visible = False
                pnservice.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton4.Click
        Try
            Pninc.Visible = False
            PNEscalam.Visible = False
            pnservice.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton5.Click
        Try
            If lblcaso.Text = "" Then
                lblmsg.Text = "Antes de crear una falla de red de clic en el botón buscar para verificar que el caso es válido"
                Exit Sub
            End If
            'If drltsoporte.SelectedItem.Text = "- Seleccione -" Then
            '    lblmsg.Text = "Elija el tipo de cierre brindado antes de generar una falla de red"
            '    Exit Sub
            'End If
            If drlmun.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Elija el municipio antes de generar una falla de red"
                Exit Sub
            End If
            If txtbarrio.Text = "" Then
                lblmsg.Text = "Digite el barrio antes de generar una falla de red"
                Exit Sub
            End If
            If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar CPD" Then
                lblmsg.Text = "Si desea guardar una falla de red la tipificación debe ser Solicitud Escalar CPD, verifique"
                Exit Sub
            Else

                'PENDIENTE VALIDAR TIPIFICACIONES SERVICE
                'If drltsoporte.SelectedItem.Value = 10 Or drltsoporte.SelectedItem.Value = 17 Then
                '    lblmsg.Text = "Si el escalamiento es a Servisdesk no es necesario crear falla de red, verifique"
                '    Exit Sub
                'Else
                Pninc.Visible = False
                PNEscalam.Visible = True
                pnservice.Visible = False
                pnservice.Visible = False
                lblmsg.Text = ""

                txtFcontacto.Text = lblcliente.Text
                txtFnum.Text = lbltelcontacto.Text
                'txtFtipofalla.Text = lblobs611.Text
                'End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton6.Click
        Pninc.Visible = False
        PNEscalam.Visible = False
    End Sub

    Protected Sub LinkButton7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton7.Click
        Try
            If drltipificacionll.SelectedItem.Text <> "Solicitud Escalar SD" Then
                lblmsg.Text = "Si va a realizár Esclamiento Service el estado debe ser Solicitud Escalar SD"
                Exit Sub
            End If


            Dim objdatos As New clscrmdatos
            Dim objcargas As New clsgeneral
            If lblcaso.Text = "" Then
                lblmsg.Text = "Consulte el caso antes de realizar escalamiento a Service"
                Exit Sub
            End If
            If txtobs.Text = "" Then
                lblmsg.Text = "Digite una descripción del escalamiento antes de dar clic en el link"
                Exit Sub
            End If
            With drlapn
                .DataSource = objcargas.consultaapn
                .DataTextField = "apn"
                .DataValueField = "apn"
                .DataBind()
            End With
            With drlqos
                .DataSource = objcargas.consultaqos
                .DataTextField = "qos"
                .DataValueField = "qos"
                .DataBind()
            End With
            pnservice.Visible = True
            Pninc.Visible = False
            PNEscalam.Visible = False
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton8.Click
        Pninc.Visible = False
        PNEscalam.Visible = False
        pnservice.Visible = False
    End Sub

    Protected Sub rdbron_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdbron.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            If rdbron.SelectedItem.Value = "Error en Registro" Then
                objdatos.idusuario = 6
            End If
            If rdbron.SelectedItem.Value = "Ajeno a Red Celular" Then
                objdatos.idusuario = 7
            End If
            If rdbron.SelectedItem.Value = "Asociado Red Celular" Then
                objdatos.idusuario = 9
            End If
            With drlvariable
                .DataSource = objdatos.consultadiagnostico
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drlvariable_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlvariable.SelectedIndexChanged
        Try
            Dim objdatos As New clscrmdatos
            objdatos.diagservicio = drlvariable.SelectedItem.Value
            objdatos.consultaproceso()
            lblvariable.Text = objdatos.tipificacion
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drlinconsglobal_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlinconsglobal.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            'Inconsistencia
            objdatos.cargo = "Inconsistencia"
            objdatos.estado = drlinconsglobal.Text
            With drlincons
                .DataSource = objdatos.consultaincdatos
                .DataTextField = "inconsistencia"
                .DataValueField = "idtipoinc"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drlmarca_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlmarca.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.estado = drlmarca.SelectedItem.Value
            With drlequipo
                objdatos.idtip = 1
                .DataSource = objdatos.consultaequipo
                .DataTextField = "equipo"
                .DataValueField = "equipo"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardservice_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardservice.Click
        Try
            Dim objdatos As New clscrmdatos
            Dim Fn As String
            Dim SaveLocation As String
            If drlvariable.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Elija la variable de diagnóstico antes de realizar escalamiento a Service"
                Exit Sub
            End If
            If drlapn.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Elija el APN del caso"
                Exit Sub
            Else
                objdatos.apn = drlapn.SelectedItem.Text
            End If
            If drlqos.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el QoS del caso"
                Exit Sub
            Else
                objdatos.qos = drlqos.SelectedItem.Text
            End If
            If txtfcactivacion.Text = "" Then
                lblmsg.Text = "Digite la fecha de activación del servicio"
                Exit Sub
            Else
                objdatos.fcini = txtfcactivacion.Text
            End If
            If Not FileDocumento.PostedFile Is Nothing And FileDocumento.PostedFile.ContentLength > 0 Then
                Fn = System.IO.Path.GetExtension(FileDocumento.PostedFile.FileName)
                SaveLocation = Server.MapPath("data_Doc") & "\\" & lblcaso.Text + Fn
                FileDocumento.PostedFile.SaveAs(SaveLocation)
                objdatos.archivo = lblcaso.Text + Fn
            Else
                objdatos.archivo = ""
                lblmsg.Text = "Adjunte un archivo"
                Exit Sub
            End If
            objdatos.caso = lblcaso.Text
            objdatos.diagvariable = drlvariable.SelectedItem.Value
            objdatos.obs = txtobs.Text
            objdatos.idusuario = lblusuario.Text
            objdatos.Registroservice()
            lblmsg.Text = "Escalamiento Service realizado con éxito"
            drlapn.SelectedValue = "- Seleccione -"
            drlqos.SelectedValue = "- Seleccione -"
            txtfcactivacion.Text = ""
            pnservice.Visible = False
            '--Escalamiento--'
            lblescalamiento.Text = "Escalamiento"

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar0.Click
        Try
            Dim objdatos As New clscrmdatos
            If drlincons.SelectedItem.Value = 0 Then
                lblmsg.Text = "Elija el tipo de inconsistencia a reportar"
                Exit Sub
            Else
                objdatos.incidente = drlincons.SelectedItem.Value
            End If
            If txtobsinc.Text = "" Then
                lblmsg.Text = "Digite la observación de la inconsistencia"
                Exit Sub
            Else
                objdatos.obs = txtobsinc.Text
            End If

            If Txt_custcode.Text = "" And txt_registro_numerico.Text = "" Then
                lblmsg.Text = "Es obligatorio llenar uno de los dos campos:  Custcode o Cuenta Financiera"
                Exit Sub
            ElseIf Txt_custcode.Text <> "" And txt_registro_numerico.Text <> "" Then
                lblmsg.Text = "Solo es permitido llenar uno de los dos campos:  Custcode o Cuenta Financiera"
                Exit Sub
            ElseIf Txt_custcode.Text <> "" And txt_registro_numerico.Text = "" Then
                objdatos.custcode = Txt_custcode.Text
            ElseIf Txt_custcode.Text = "" And txt_registro_numerico.Text <> "" Then
                objdatos.Num_Intento = txt_registro_numerico.Text
            End If
            If Txt_usuario_reporta.Text = "" Then
                lblmsg.Text = "Digite el usuario reporta de la inconsistencia"
                Exit Sub
            Else
                objdatos.usuarioreporta = Txt_usuario_reporta.Text
            End If


            If drlnivel.SelectedItem.Value <> "0" Then
                objdatos.barrio = drlnivel.SelectedItem.Value
            Else
                lblmsg.Text = "Elija el nivel que genera la inconsistencia, verifique"
                Exit Sub
            End If
            If txt_registro_numerico.Text <> "" Then
                objdatos.Num_Intento = txt_registro_numerico.Text
            End If
            objdatos.caso = lblcaso.Text
            objdatos.idusuario = lblusuario.Text
            objdatos.estadoinc = "Aprobado"
            objdatos.registroinc()
            lblmsg.Text = "Inconsistencia reportada con exito"
            drlincons.SelectedValue = 0
            txtobsinc.Text = ""
            Txt_custcode.Text = ""
            Txt_usuario_reporta.Text = ""

            Pninc.Visible = False
            drlnivel.SelectedValue = "0"
            txt_registro_numerico.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub guardacrm()
        Dim objdatos As New clsvoz
        Try
            objdatos.caso = txtcaso.Text
            If txtfobs.Text = "" Then
                objdatos.obs = ""
            Else
                objdatos.obs = txtfobs.Text
            End If
            objdatos.tipificacion = "Creado"
            objdatos.idusuario = lblusuario.Text
            objdatos.registrocrmfallareddilo()
            lblmsg.Text = "Seguimiento ingresado con éxito"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub


    Protected Sub btnguardar1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar1.Click
        Try
            Dim objdatos As New clsvoz
            If txtFcontacto.Text = "" Then
                lblmsg.Text = "Digite la persona de contacto"
                Exit Sub
            Else
                objdatos.cliente = txtFcontacto.Text
            End If
            If txtFnum.Text = "" Then
                lblmsg.Text = "Digite el número de contacto"
                Exit Sub
            Else
                objdatos.telcontacto = txtFnum.Text
            End If
            If drlFtiempo.SelectedItem.Value = "0" Then
                lblmsg.Text = "Elija el tiempo que lleva presentándose la falla"
                Exit Sub
            Else
                objdatos.tiempo = drlFtiempo.SelectedItem.Value
            End If
            If txtFtipofalla.Text = "" Then
                objdatos.tipofalla = ""
            Else
                objdatos.tipofalla = txtFtipofalla.Text
            End If
            If drlFcaract.SelectedItem.Value = "0" Then
                lblmsg.Text = "Describa las características del tipo de falla"
                Exit Sub
            Else
                objdatos.caracter = drlFcaract.SelectedItem.Text
            End If
            If drlFportada.SelectedItem.Value = "0" Then
                lblmsg.Text = "Elija si la línea es portada o no"
                Exit Sub
            Else
                objdatos.portada = drlFportada.SelectedItem.Value
            End If
            If drlmun.SelectedItem.Value = 0 Then
                lblmsg.Text = "Elija el Departamento y Municipio de la falla"
                Exit Sub
            Else
                objdatos.mun = drlmun.SelectedItem.Value
            End If
            If txtFciudad.Text = "" Then
                objdatos.vereda = ""
            Else
                If rdbvc.SelectedValue = Nothing And txtFciudad.Text <> Nothing Then
                    lblmsg.Text = "Elija si el lugar corresponde a un corregimiento, Vereda o Inspección"
                    Exit Sub
                Else
                    objdatos.vereda = rdbvc.SelectedItem.Value & " " & txtFciudad.Text
                End If
            End If
            If txtFdirecc.Text = "" Then
                lblmsg.Text = "Digite la dirección donde se presenta la falla"
                Exit Sub
            Else
                objdatos.dir = txtFdirecc.Text
            End If
            If txtbarrio.Text = "" Then
                lblmsg.Text = "Digite el barrio donde se presenta la falla"
                Exit Sub
            Else
                objdatos.barrio = txtbarrio.Text
            End If
            If drlFtectolog.SelectedItem.Value = "0" Then
                lblmsg.Text = "Elija la tecnología del equipo que presenta la falla"
                Exit Sub
            Else
                objdatos.tecnologia = drlFtectolog.SelectedItem.Text
            End If
            If drlequipo.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Elija el equipo actual antes de generar una falla de red"
                Exit Sub
            Else
                objdatos.equipo = drlequipo.SelectedItem.Value
            End If
            If drlFlineasfalla.SelectedItem.Value = "0" Then
                lblmsg.Text = "Elija si se reportan más líneas con falla en la ubicación reportada"
                Exit Sub
            Else
                objdatos.maslineas = drlFlineasfalla.SelectedItem.Value
            End If
            If txtfobs.Text = "" Then
                lblmsg.Text = "Digite las observaciones reportadas por el usuario"
                Exit Sub
            Else
                objdatos.obs = txtfobs.Text
            End If
            If txtapn.Text = "" Then
                lblmsg.Text = "Digite el APN Afectado"
                Exit Sub
            Else
                objdatos.apn = txtapn.Text
            End If
            If Drl_Qos.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un QoS"
                Exit Sub
            Else
                objdatos.qos = Drl_Qos.SelectedItem.Text
            End If

            If DrlCanalDilo.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el canal de ingreso"
                Exit Sub
            Else
                objdatos.CanalDilo = DrlCanalDilo.Text
            End If
            '''''''Validacion Servicio Cliente''''''''
            If Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para La falla se presenta luego de que se construyera una edificación aledaña"
                Exit Sub
            End If
            If Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para La falla se presenta luego de que se remodelara la estructura física del edificio"
                Exit Sub
            End If
            If Drl_Tipo_Edificacion_Donde_Presenta_Falla_1.SelectedItem.Text = "- Seleccione -" Or Drl_Tipo_Edificacion_Donde_Presenta_Falla_2.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione las dos (2) opciones para Tipo de edificación donde se presenta la falla"
                Exit Sub
            End If
            If Drl_Validaciones_Falla_Masiva.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Validaciones de falla masiva"
                Exit Sub
            End If
            If Drl_Tecnologia_Presenta_Falla_Luegodepruebas.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Tecnología en la que se presenta la falla - Luego de pruebas"
                Exit Sub
            End If
            If Txt_Validacion_Coordenadas.Text = "" Then
                lblmsg.Text = "Ingrese un valor para Validación de Coordenadas de maximo 20 caracteres"
                Exit Sub
            End If
            If Drl_Linea_No_Cuenta_Bloqueos_Internet.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Línea no cuenta con bloqueos de Internet"
                Exit Sub
            End If
            If Drl_Linea_No_Superado_Limite_Consumos.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Línea no ha superado el limite de consumos"
                Exit Sub
            End If
            If Drl_Linea_No_Encuentra_Enrutada_PorPagos.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Línea no se encuentra enrutada por pagos"
                Exit Sub
            End If
            If Drl_HLR_HSS.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para HLR / HSS"
                Exit Sub
            End If
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para No existen cambios administrativos sobre la línea o cuenta maestra"
                Exit Sub
            End If
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text = "FALSO" And Drl_Split_Billing.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "En opcion No existen cambios administrativos sobre la línea o cuenta maestra seleccione una opción de la segunda lista 'split billing'"
                Exit Sub
            End If
            If Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Se realizan pruebas de SIMCARD en otro dispositivo (Persiste Falla)"
                Exit Sub
            End If
            If Drl_Forza_Red_Dispositivo.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Se forza la red del dispositivo"
                Exit Sub
            End If
            If Drl_Verifica_Realiza_Configuración_APN.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Se verifica o realiza configuración de APN"
                Exit Sub
            End If
            If Drl_Equipo_Encuentra_Homologado_Operador.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Equipo se encuentra homologado por el operador"
                Exit Sub
            End If

            If Drl_Realiza_Conciliacion_Sobre_linea.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opción para Se realiza conciliación sobre la línea"
                Exit Sub
            End If
            objdatos.Falla_Presenta_Luego_Construyera_Edificacion_Aledania = Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania.SelectedItem.Text
            objdatos.Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio.SelectedItem.Text
            objdatos.Tipo_Edificacion_Donde_Presenta_Falla = Drl_Tipo_Edificacion_Donde_Presenta_Falla_1.SelectedItem.Text + " - " + Drl_Tipo_Edificacion_Donde_Presenta_Falla_2.SelectedItem.Text
            objdatos.Validaciones_Falla_Masiva = Drl_Validaciones_Falla_Masiva.SelectedItem.Text
            objdatos.Tecnologia_Presenta_Falla_Luegodepruebas = Drl_Tecnologia_Presenta_Falla_Luegodepruebas.SelectedItem.Text
            objdatos.Validacion_Coordenadas = Txt_Validacion_Coordenadas.Text
            objdatos.Linea_No_Cuenta_Bloqueos_Internet = Drl_Linea_No_Cuenta_Bloqueos_Internet.SelectedItem.Text
            objdatos.Linea_No_Superado_Limite_Consumos = Drl_Linea_No_Superado_Limite_Consumos.SelectedItem.Text
            objdatos.Linea_No_Encuentra_Enrutada_PorPagos = Drl_Linea_No_Encuentra_Enrutada_PorPagos.SelectedItem.Text
            objdatos.HLR_HSS = Drl_HLR_HSS.SelectedItem.Text
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text = "FALSO" Then
                objdatos.No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text + " - " + Drl_Split_Billing.SelectedItem.Text
            Else
                objdatos.No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text
            End If
            objdatos.Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla.SelectedItem.Text
            objdatos.Forza_Red_Dispositivo = Drl_Forza_Red_Dispositivo.SelectedItem.Text
            objdatos.Verifica_Realiza_Configuración_APN = Drl_Verifica_Realiza_Configuración_APN.SelectedItem.Text
            objdatos.Equipo_Encuentra_Homologado_Operador = Drl_Equipo_Encuentra_Homologado_Operador.SelectedItem.Text
            objdatos.Realiza_Conciliacion_Sobre_linea = Drl_Realiza_Conciliacion_Sobre_linea.SelectedItem.Text





            objdatos.campana = "Datos"
            objdatos.caso = lblcaso.Text
            objdatos.idusuario = lblusuario.Text
            objdatos.fcini = Lblfc_ingreso.Text
            objdatos.registrofallasred()
            guardacrm()
            lblmsg.Text = "Falla de red reportada con éxito"
            'limpiar
            Pninc.Visible = False
            PNEscalam.Visible = False
            txtfobs.Text = ""
            drlFlineasfalla.SelectedValue = "0"
            txtFdirecc.Text = ""
            txtFciudad.Text = ""
            rdbvc.SelectedValue = Nothing
            drlFportada.SelectedValue = "0"
            drlFcaract.SelectedValue = "13"
            txtFtipofalla.Text = ""
            txtFcontacto.Text = ""
            txtFnum.Text = ""
            lblctrl.Text = "1"
            DrlCanalDilo.Text = "- Seleccione -"
            txtapn.Text = ""
            Drl_Qos.SelectedValue = "- Seleccione -"
            ''''''''Validacion Servicio Cliente'''''''''''''
            Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania.SelectedValue = "- Seleccione -"
            Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio.SelectedValue = "- Seleccione -"
            Drl_Tipo_Edificacion_Donde_Presenta_Falla_1.SelectedValue = "- Seleccione -"
            Drl_Tipo_Edificacion_Donde_Presenta_Falla_2.SelectedValue = "- Seleccione -"
            Drl_Validaciones_Falla_Masiva.SelectedValue = "- Seleccione -"
            Drl_Tecnologia_Presenta_Falla_Luegodepruebas.SelectedValue = "- Seleccione -"
            Txt_Validacion_Coordenadas.Text = ""
            Drl_Linea_No_Cuenta_Bloqueos_Internet.SelectedValue = "- Seleccione -"
            Drl_Linea_No_Superado_Limite_Consumos.SelectedValue = "- Seleccione -"
            Drl_Linea_No_Encuentra_Enrutada_PorPagos.SelectedValue = "- Seleccione -"
            Drl_HLR_HSS.SelectedValue = "- Seleccione -"
            Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedValue = "- Seleccione -"
            Drl_Split_Billing.SelectedValue = "- Seleccione -"
            Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla.SelectedValue = "- Seleccione -"
            Drl_Forza_Red_Dispositivo.SelectedValue = "- Seleccione -"
            Drl_Verifica_Realiza_Configuración_APN.SelectedValue = "- Seleccione -"
            Drl_Equipo_Encuentra_Homologado_Operador.SelectedValue = "- Seleccione -"
            Drl_Realiza_Conciliacion_Sobre_linea.SelectedValue = "- Seleccione -"

            drlFtiempo.SelectedValue = "0"

            '------Escalamiento-----'
            lblescalamiento.Text = "Falla de red"

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drltipificacionll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drltipificacionll.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.Validacion = "Categoria de cierre"
            objdatos.localidad = drltipificacionll.SelectedValue
            With drlCategoriaCierre
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion1"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drlgrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlgrupo.SelectedIndexChanged
        Try
            'Dim objdatos As New clsgeneral
            'objdatos.idusuario = lblusuario.Text
            'objdatos.ConsultaSinRestriccion()
            'If objdatos.cantreg > 0 Then
            '    objdatos.tipo = drlgrupo.SelectedItem.Value
            '    objdatos.estado = drltipificacionll.SelectedItem.Text
            '    With drltsoporte
            '        .DataSource = objdatos.consultatsoportegrupo
            '        .DataTextField = "escenario"
            '        .DataValueField = "escenario"
            '        .DataBind()
            '    End With
            'Else
            '    objdatos.tipo = drlgrupo.SelectedItem.Value
            '    objdatos.estado = drltipificacionll.SelectedItem.Text
            '    With drltsoporte
            '        .DataSource = objdatos.consultatsoportegrupoRestriccion
            '        .DataTextField = "escenario"
            '        .DataValueField = "escenario"
            '        .DataBind()
            '    End With
            'End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drlCausa_Raiz_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drlCausa_Raiz.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            If drlCausa_Raiz.SelectedValue <> Nothing Then
                If drlCausa_Raiz.SelectedValue = "- Seleccione -" Then
                    drlSegmento.SelectedIndex = 0
                    drlElemento.SelectedIndex = 0
                    drlTipo_De_Falla.SelectedIndex = 0
                    drltsoporte.SelectedIndex = 0
                    drlgrupo.ClearSelection()
                    Exit Sub
                End If
                objdatos.Validacion = "Segmento"
                objdatos.localidad = drlCausa_Raiz.SelectedValue
                'If objdatos.localidad = "Diagnostico en curso" Then
                With drlSegmento
                    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                    .DataTextField = "tipificacion4"
                    .DataValueField = "tipificacion4"
                    .DataBind()
                    If drlSegmento.Items.Count >= 3 Then
                        drlSegmento.SelectedIndex = 0
                        drlElemento.SelectedIndex = 0
                        drlTipo_De_Falla.SelectedIndex = 0
                    Else
                        drlSegmento.SelectedIndex = 1
                    End If
                End With

                objdatos.Validacion = "Elemento"
                objdatos.localidad = drlCausa_Raiz.SelectedValue
                objdatos.nombre = drlSegmento.SelectedValue
                With drlElemento
                    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                    .DataTextField = "tipificacion3"
                    .DataValueField = "id_tipificacion"
                    .DataBind()
                    If drlElemento.Items.Count >= 3 Then
                        drlElemento.SelectedIndex = 0
                        drlTipo_De_Falla.SelectedIndex = 0
                    ElseIf drlSegmento.SelectedIndex = 0 Then
                        drlElemento.SelectedIndex = 0
                    Else
                        drlElemento.SelectedIndex = 1
                    End If
                End With

                objdatos.Validacion = "Tipo de falla"
                objdatos.localidad = objdatos.tipo
                With drlTipo_De_Falla
                    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                    .DataTextField = "tipificacion2"
                    .DataValueField = "cod_tipificacion"
                    .DataBind()
                    If drlTipo_De_Falla.Items.Count >= 3 Then
                        drlTipo_De_Falla.SelectedIndex = 0
                    ElseIf drlElemento.SelectedIndex = 0 Then
                        drlTipo_De_Falla.SelectedIndex = 0
                    Else
                        drlTipo_De_Falla.SelectedIndex = 1
                    End If
                End With
                objdatos.Validacion = "Tipo Soporte"
                objdatos.localidad = drlTipo_De_Falla.SelectedValue
                With drltsoporte
                    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                    .DataTextField = "tipificacion2"
                    .DataValueField = "cod_tipificacion"
                    .DataBind()
                    If drltsoporte.Items.Count >= 3 Then
                        drltsoporte.SelectedIndex = 0
                    ElseIf drlTipo_De_Falla.SelectedIndex = 0 Then
                        drltsoporte.SelectedIndex = 0
                    Else
                        drltsoporte.SelectedIndex = 1
                    End If

                End With
                objdatos.Validacion = "Grupo"
                objdatos.localidad = drlTipo_De_Falla.SelectedValue
                objdatos.nombre = drltsoporte.SelectedItem.Text
                With drlgrupo
                    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                    .DataTextField = "tipificacion1"
                    .DataValueField = "tipificacion1"
                    .DataBind()
                End With
                If drltsoporte.SelectedIndex = 0 Then
                    drlgrupo.SelectedValue = ""
                End If
                objdatos.Validacion = "Estado"
                objdatos.localidad = "Tipificacion"
                objdatos.nombre = drltsoporte.SelectedValue
                With drltipificacionll
                    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                    .DataTextField = "tipificacion2"
                    .DataValueField = "cod_tipificacion"
                    .DataBind()
                End With
            Else
                lblmsg.Text = "ingrese la Causa Raiz"
                Exit Sub
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub



    Protected Sub drlSegmento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlSegmento.SelectedIndexChanged
                Try
            Dim objdatos As New clsgeneral
            objdatos.Validacion = "Elemento"
            objdatos.localidad = drlCausa_Raiz.SelectedValue
            objdatos.nombre = drlSegmento.SelectedValue
            With drlElemento
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion3"
                .DataValueField = "id_tipificacion"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try

    End Sub

    Protected Sub drlElemento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlElemento.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.Validacion = "Tipo de falla"
            objdatos.localidad = drlElemento.SelectedValue
            With drlTipo_De_Falla
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion2"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try

    End Sub

    Protected Sub drlTipo_De_Falla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlTipo_De_Falla.SelectedIndexChanged
       Try
            Dim objdatos As New clsgeneral
            objdatos.Validacion = "Tipo Soporte"
            objdatos.localidad = drlTipo_De_Falla.SelectedValue
            With drltsoporte
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion2"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With

        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try

    End Sub

    Protected Sub drlCategoriaCierre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlCategoriaCierre.SelectedIndexChanged
        Try
            'Dim objdatos As New clsgeneral
            'objdatos.Validacion = "Estado"
            'objdatos.localidad = "Dilo"
            'objdatos.nombre = drlCategoriaCierre.SelectedValue
            'With drltipificacionll
            '    .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
            '    .DataTextField = "tipificacion2"
            '    .DataValueField = "tipificacion2"
            '    .DataBind()
            'End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try

    End Sub


    Protected Sub drltsoporte_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drltsoporte.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.Validacion = "Grupo"
            objdatos.localidad = drlTipo_De_Falla.SelectedValue
            objdatos.nombre = drltsoporte.SelectedItem.Text
            With drlgrupo
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion1"
                .DataValueField = "tipificacion1"
                .DataBind()
            End With

            objdatos.Validacion = "Estado"
            objdatos.localidad = "Tipificacion"
            objdatos.nombre = drltsoporte.SelectedValue
            With drltipificacionll
                .DataSource = objdatos.Consulta_Cargue_Catalogo_Diagnostico
                .DataTextField = "tipificacion2"
                .DataValueField = "cod_tipificacion"
                .DataBind()
            End With

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drllinea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drllinea.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            'servicio
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.identidad = 21
            With drlservicio2
                .DataSource = objdatos.consultaservicio
                .DataTextField = "tipo2"
                .DataValueField = "tipo2"
                .DataBind()
            End With
            'subservicio
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.mun = drlservicio2.SelectedItem.Text
            objdatos.identidad = 21
            With drlsubservicio
                .DataSource = objdatos.consultasubservicio
                .DataTextField = "tipificacion"
                .DataValueField = "tipificacion"
                .DataBind()
            End With
            If drllinea.SelectedItem.Text = "- Seleccione -" Then
                'solicitud
                objdatos.localidad = drllinea.SelectedItem.Text
                objdatos.mun = drlservicio2.SelectedItem.Text
                objdatos.nombre = drlsubservicio.SelectedItem.Text
                objdatos.identidad = 21
                With drlsolicitud
                    .DataSource = objdatos.consultasolicitud
                    .DataTextField = "detalle"
                    .DataValueField = "idreg"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drlservicio2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlservicio2.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            'subservicio
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.mun = drlservicio2.SelectedItem.Text
            objdatos.identidad = 21
            With drlsubservicio
                .DataSource = objdatos.consultasubservicio
                .DataTextField = "tipificacion"
                .DataValueField = "tipificacion"
                .DataBind()
            End With
            'solicitud
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.mun = drlservicio2.SelectedItem.Text
            objdatos.nombre = drlsubservicio.SelectedItem.Text
            objdatos.identidad = 21
            With drlsolicitud
                .DataSource = objdatos.consultasolicitud
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drlsubservicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlsubservicio.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            'solicitud
            objdatos.localidad = drllinea.SelectedItem.Text
            objdatos.mun = drlservicio2.SelectedItem.Text
            objdatos.nombre = drlsubservicio.SelectedItem.Text
            objdatos.identidad = 21
            With drlsolicitud
                .DataSource = objdatos.consultasolicitud
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drlreclamoppal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlreclamoppal.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.tipo = drlreclamoppal.SelectedItem.Value
            'tipo falla
            With drltipofalla
                .DataSource = objdatos.consultatipofalla
                .DataTextField = "desctipofalla"
                .DataValueField = "desctipofalla"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drlvariableCatalogo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlvariableCatalogo.SelectedIndexChanged
        Try
            Dim objdatos As New clscrmdatos
            objdatos.diagservicio = drlvariableCatalogo.SelectedItem.Value
            objdatos.consultaproceso()
            lblvariable1.Text = objdatos.tipificacion
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedIndexChanged
        Try
            If Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.SelectedItem.Text = "FALSO" Then
                Drl_Split_Billing.Visible = True
            Else
                Drl_Split_Billing.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try

    End Sub

    Protected Sub drlinconsistencia_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlinconsistencia.SelectedIndexChanged
        Try
            If drlinconsistencia.SelectedItem.Text = "Otro" Then
                txtobsincon.Enabled = True
            Else
                txtobsincon.Enabled = False
                txtobsincon.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub
    Protected Sub dtgprog_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgprog.PageIndexChanging
        Try
            dtgprog.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtgprog.DataSource = Session("Asignados")
            dtgprog.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub


    Protected Sub Si_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkSi.CheckedChanged
        Try
            If chkSi.Checked = True Then
                txtnumalt.Visible = True
                txtnumalt.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub

    Protected Sub chkNo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkNo.CheckedChanged
        Try
            If chkNo.Checked = True Then
                txtnumalt.Visible = False
                txtnumalt.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error: " & ex.Message
        End Try
    End Sub


End Class