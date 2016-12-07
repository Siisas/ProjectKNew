Public Class FiltroSeleccion
    Inherits System.Web.UI.Page
    Dim ObjProcesoSeleccion As New clsProcesoSeleccion

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Obtengo los datos de usuario
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                CargardrlNivelEstudio()
                With drlProcesoSeleccion
                    .DataSource = ObjProcesoSeleccion.ConsultaProceso_Seleccion
                    .DataTextField = "Proceso"
                    .DataValueField = "Cod_Proceso_Seleccion"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Public Sub CargardrlNivelEstudio()
        With drlNivel
            .DataSource = ObjProcesoSeleccion.ConsultarNivel
            .DataTextField = "Nombre"
            .DataValueField = "Cod_Estudio"
            .DataBind()
        End With
    End Sub

    Protected Sub BtnValidarProcesoSeleccion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnValidarProcesoSeleccion.Click
        Try
            If ((TxtCargo.Text = "") Or (TxtObservacion.Text = "") Or (drlEstado.Text <> "En proceso") Or (TxtCantidadRequerida.Text = "") Or (TxtMaxCandidatos.Text = "") Or (TxtFecha_Inicio.Text = "")) Then
                lblmsg.Text = "Por favor llene todo los campos para poder continuar con el proceso de seleccion o seleccione el estado correcto"
            Else
                If (Integer.Parse(TxtCantidadRequerida.Text) >= Integer.Parse(TxtMaxCandidatos.Text)) Then
                    lblmsg.Text = "El maximo numero de candidatos solicitados para ocupar el cargo no puede ser igual o inferior a la cantidad requerida "
                Else
                    TxtCargo.Enabled = False
                    TxtObservacion.Enabled = False
                    drlEstado.Enabled = False
                    TxtCantidadRequerida.Enabled = False
                    TxtMaxCandidatos.Enabled = False
                    TxtFecha_Inicio.Enabled = False

                    ''Filtro de seleccion
                    drlNivel.Enabled = True
                    TxtCargoLabor.Enabled = True
                    TxtTiempo.Enabled = True
                    drlTiempo.Enabled = True
                    BtnValidarFiltro.Enabled = True
                    BtnValidacion.Visible = True
                    BtnValidarProcesoSeleccion.Visible = False
                    lblmsg.Text = ""
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnGuardarEstudio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGuardarProcesoSeleccion.Click
        Try
            ''Nuevo registro
            If RbtnNuevo.Checked = True Then
                If ((TxtCargo.Text = "") Or (TxtObservacion.Text = "") Or (drlEstado.Text <> "En proceso") Or (TxtCantidadRequerida.Text = "") Or (TxtFecha_Inicio.Text = "")) Then
                    lblmsg.Text = "Por favor llene todo los campos para poder ingresar el proceso de seleccion o seleccione el estado correcto"
                Else
                    ObjProcesoSeleccion.Cargo = TxtCargo.Text
                    ObjProcesoSeleccion.Observacion = TxtObservacion.Text
                    ObjProcesoSeleccion.Estado = drlEstado.Text
                    ObjProcesoSeleccion.Cantidad_Requerida = TxtCantidadRequerida.Text
                    ObjProcesoSeleccion.Cantidad_Obtenida = 0
                    ObjProcesoSeleccion.Fecha_Inicio = TxtFecha_Inicio.Text + " " + DateTime.Now.ToString("HH:mm:ss")
                    ObjProcesoSeleccion.Fecha_Fin = "01/01/1754 "

                    ObjProcesoSeleccion.InsertarProceso_Seleccion()

                    'Actualizacion del Cod_Proceso_Seleccion del Aspirante'
                    Dim Id_Aspirante As Int64
                    ObjProcesoSeleccion.Consulta_UltimoR_Proceso_Seleccion()
                    Dim Cod_Proceso_Seleccion As Integer = ObjProcesoSeleccion.Cod_Proceso_Seleccion
                    For Each row As GridViewRow In dtgAspirantes.Rows
                        Id_Aspirante = CStr(row.Cells(0).Text)
                        ObjProcesoSeleccion.Cod_Proceso_Seleccion = Cod_Proceso_Seleccion
                        ObjProcesoSeleccion.Id_Aspirante_Update = Id_Aspirante
                        ObjProcesoSeleccion.Actualizar_Cod_PS_Aspirante()
                    Next

                    lblmsg.Text = "Los datos del proceso de seleccion fueron ingresados correctamente"

                    TxtCargo.Text = ""
                    TxtObservacion.Text = ""
                    drlEstado.Text = "0"
                    TxtCantidadRequerida.Text = ""
                    TxtMaxCandidatos.Text = ""
                    TxtFecha_Inicio.Text = ""

                    drlNivel.Text = "1"
                    TxtCargoLabor.Text = ""
                    TxtTiempo.Text = ""
                    drlTiempo.Text = "0"

                    BtnGuardarProcesoSeleccion.Visible = False
                    TxtCargo.Enabled = True
                    TxtObservacion.Enabled = True
                    drlEstado.Enabled = True
                    TxtCantidadRequerida.Enabled = True
                    TxtMaxCandidatos.Enabled = True
                    TxtFecha_Inicio.Enabled = True

                    ''Filtro de seleccion
                    drlNivel.Enabled = False
                    TxtCargoLabor.Enabled = False
                    TxtTiempo.Enabled = False
                    drlTiempo.Enabled = False
                    BtnValidarFiltro.Enabled = False
                    BtnValidacion.Visible = False
                    dtgAspirantes.DataSource = Nothing
                    dtgAspirantes.DataBind()
                    LblNumAspirantes.Text = ""


                    ''Dejo el formulario como si volcieran a ingresar
                    BtnRegresar.Visible = False
                    BtnActualizarRegistro.Visible = True
                    RbtnNuevo.Visible = True
                    RbtnNuevo.Checked = False
                    RbtAgregar.Visible = True
                    RbtAgregar.Checked = False
                    Panel_AgregarAspirantes.Visible = False
                    Panel_RegistroNuevo.Visible = False
                End If
            End If
            ''Agregar mas apirantes
            If RbtAgregar.Checked = True Then
                'Actualizacion del Cod_Proceso_Seleccion del Aspirante'
                Dim Id_Aspirante As Int64
                Dim Cod_Proceso_Seleccion As Integer = drlProcesoSeleccion.Text
                For Each row As GridViewRow In dtgAspirantes.Rows
                    Id_Aspirante = CStr(row.Cells(0).Text)
                    ObjProcesoSeleccion.Cod_Proceso_Seleccion = Cod_Proceso_Seleccion
                    ObjProcesoSeleccion.Id_Aspirante_Update = Id_Aspirante
                    ObjProcesoSeleccion.Actualizar_Cod_PS_Aspirante()
                Next

                lblmsg.Text = "El aspirante fue incorporado al proceso de seleccion"

                TxtCargoConsulta.Text = ""
                TxtObservacionConsulta.Text = ""
                drlEstadoConsulta.Text = "0"
                TxtCantidadRequeridaConsulta.Text = ""
                TxtFecha_Inicio_Consulta.Text = ""
                TxtFecha_Fin_Consulta.Text = ""
                drlProcesoSeleccion.Enabled = True
                BtnConsultaProcesoSeleccion.Visible = True
                BtnValidacionConsulta.Visible = False

                drlNivel.Text = "1"
                TxtCargoLabor.Text = ""
                TxtTiempo.Text = ""
                drlTiempo.Text = "0"

                BtnGuardarProcesoSeleccion.Visible = False

                ''Filtro de seleccion
                drlNivel.Enabled = False
                TxtCargoLabor.Enabled = False
                TxtTiempo.Enabled = False
                drlTiempo.Enabled = False
                BtnValidarFiltro.Enabled = False
                BtnValidacion.Visible = False
                dtgAspirantes.DataSource = Nothing
                dtgAspirantes.DataBind()
                LblNumAspirantes.Text = ""

                ''Dejo el formulario como si volcieran a ingresar
                BtnRegresar.Visible = False
                BtnActualizarRegistro.Visible = True
                RbtnNuevo.Visible = True
                RbtnNuevo.Checked = False
                RbtAgregar.Visible = True
                RbtAgregar.Checked = False
                Panel_AgregarAspirantes.Visible = False
                Panel_RegistroNuevo.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub


    Public Sub ConsultaFiltro()
        Try
            Dim Cantidadmaxima As Integer
            ObjProcesoSeleccion.Fk_Cod_Estudio = drlNivel.Text
            ObjProcesoSeleccion.Cargo_Explab = TxtCargoLabor.Text
            ObjProcesoSeleccion.TiempoNum = TxtTiempo.Text
            ObjProcesoSeleccion.Tiempo_Consul = drlTiempo.Text
            If RbtnNuevo.Checked = True Then
                ObjProcesoSeleccion.Cantidad_Requerida = TxtMaxCandidatos.Text
                Cantidadmaxima = TxtMaxCandidatos.Text
            Else
                ObjProcesoSeleccion.Cantidad_Requerida = Integer.Parse(TxtCantidadRequeridaConsulta.Text) - Integer.Parse(TxtCantidadObtenidaConsulta.Text)
                ObjProcesoSeleccion.Cantidad_Requerida = ObjProcesoSeleccion.Cantidad_Requerida * 2
                Cantidadmaxima = ObjProcesoSeleccion.Cantidad_Requerida
            End If
            dtgAspirantes.DataSource = ObjProcesoSeleccion.Consulta_Filtro
            dtgAspirantes.PageSize() = Cantidadmaxima
            dtgAspirantes.DataBind()
            If (Cantidadmaxima > 60) Then
                dtgAspirantes.AllowPaging = True
            Else
                dtgAspirantes.AllowPaging = False
            End If
            LblNumAspirantes.Text = ObjProcesoSeleccion.CantidadE
            If Integer.Parse(LblNumAspirantes.Text) > 0 Then
                BtnGuardarProcesoSeleccion.Visible = True
                'BtnxlsEstudio.Visible = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error" & ex.Message
        End Try
    End Sub

    Protected Sub BtnValidarFiltro_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnValidarFiltro.Click
        Try
            If ((TxtCargoLabor.Text = "") Or (TxtTiempo.Text = "") Or (drlTiempo.Text = "0")) Then
                lblmsg.Text = "Por favor llene todos los campos para realizar el filtro"
                dtgAspirantes.DataSource = Nothing
                dtgAspirantes.DataBind()
                LblNumAspirantes.Text = ""
            Else
                ConsultaFiltro()
                lblmsg.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnValidacion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnValidacion.Click
        TxtCargo.Enabled = True
        TxtObservacion.Enabled = True
        drlEstado.Enabled = True
        TxtCantidadRequerida.Enabled = True
        TxtMaxCandidatos.Enabled = True
        TxtFecha_Inicio.Enabled = True
        BtnValidarProcesoSeleccion.Visible = True

        ''Filtro de seleccion
        BtnGuardarProcesoSeleccion.Visible = False
        drlNivel.Enabled = False
        TxtCargoLabor.Enabled = False
        TxtTiempo.Enabled = False
        drlTiempo.Enabled = False
        BtnValidarFiltro.Enabled = False
        BtnValidacion.Visible = False
        dtgAspirantes.DataSource = Nothing
        dtgAspirantes.DataBind()
        LblNumAspirantes.Text = ""
    End Sub

    Protected Sub dtgAspirantes_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgAspirantes.PageIndexChanging
        dtgAspirantes.PageIndex = e.NewPageIndex
        ConsultaFiltro()
    End Sub

    Protected Sub BtnActualizarRegistro_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnActualizarRegistro.Click
        If RbtnNuevo.Checked = True Then
            Panel_RegistroNuevo.Visible = True
            Panel_AgregarAspirantes.Visible = False
            BtnRegresar.Visible = True
            BtnActualizarRegistro.Visible = False
            RbtnNuevo.Visible = False
            RbtAgregar.Visible = False
            lblmsg.Text = ""
        Else
            If RbtAgregar.Checked = True Then
                Panel_AgregarAspirantes.Visible = True
                Panel_RegistroNuevo.Visible = False
                BtnRegresar.Visible = True
                BtnRegresar.Visible = True
                BtnActualizarRegistro.Visible = False
                RbtnNuevo.Visible = False
                RbtAgregar.Visible = False
                lblmsg.Text = ""
            Else
                lblmsg.Text = "Seleccione una opcion Nuevo Registro o Agregar mas aspirantes"
            End If
        End If
    End Sub

    Protected Sub BtnConsultaProcesoSeleccion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultaProcesoSeleccion.Click
        Try
            ObjProcesoSeleccion.Cod_Proceso_Seleccion = drlProcesoSeleccion.Text
            ObjProcesoSeleccion.Consulta_Agregar_Aspirantes()
            TxtCargoConsulta.Text = ObjProcesoSeleccion.Cargo
            TxtObservacionConsulta.Text = ObjProcesoSeleccion.Observacion
            drlEstadoConsulta.Text = ObjProcesoSeleccion.Estado
            TxtCantidadRequeridaConsulta.Text = ObjProcesoSeleccion.Cantidad_Requerida
            TxtCantidadObtenidaConsulta.Text = ObjProcesoSeleccion.Cantidad_Obtenida
            TxtFecha_Inicio_Consulta.Text = ObjProcesoSeleccion.Fecha_Inicio
            If ObjProcesoSeleccion.Fecha_Fin = "01/01/1754" Then
                TxtFecha_Fin_Consulta.Text = "No a finalizado el proceso"
            Else
                TxtFecha_Fin_Consulta.Text = ObjProcesoSeleccion.Fecha_Fin
            End If

            drlProcesoSeleccion.Enabled = False
            BtnConsultaProcesoSeleccion.Visible = False
            BtnValidacionConsulta.Visible = True

            ''Filtro de seleccion
            drlNivel.Enabled = True
            TxtCargoLabor.Enabled = True
            TxtTiempo.Enabled = True
            drlTiempo.Enabled = True
            BtnValidarFiltro.Enabled = True
            BtnValidacion.Visible = True
            lblmsg.Text = ""

        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnValidacionConsulta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnValidacionConsulta.Click

        drlProcesoSeleccion.Enabled = True
        BtnConsultaProcesoSeleccion.Visible = True
        BtnValidacionConsulta.Visible = False

        ''Filtro de seleccion
        drlNivel.Enabled = False
        TxtCargoLabor.Enabled = False
        TxtTiempo.Enabled = False
        drlTiempo.Enabled = False
        BtnValidarFiltro.Enabled = False
        BtnValidacion.Visible = False
        BtnGuardarProcesoSeleccion.Visible = False
        lblmsg.Text = ""

        'Limpio cajas
        TxtCargoConsulta.Text = ""
        TxtObservacionConsulta.Text = ""
        drlEstadoConsulta.Text = "0"
        TxtCantidadRequeridaConsulta.Text = ""
        TxtCantidadObtenidaConsulta.Text = ""
        TxtFecha_Inicio_Consulta.Text = ""
        TxtFecha_Fin_Consulta.Text = ""
    End Sub

    Protected Sub BtnRegresar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnRegresar.Click
        BtnRegresar.Visible = False
        BtnGuardarProcesoSeleccion.Visible = False
        BtnActualizarRegistro.Visible = True
        RbtnNuevo.Visible = True
        RbtnNuevo.Checked = False
        RbtAgregar.Visible = True
        RbtAgregar.Checked = False
        Panel_AgregarAspirantes.Visible = False
        Panel_RegistroNuevo.Visible = False
        lblmsg.Text = ""

        ''Filtro de Seleccion
        drlNivel.Enabled = False
        TxtCargoLabor.Enabled = False
        TxtCargoLabor.Text = ""
        TxtTiempo.Enabled = False
        TxtTiempo.Text = ""
        drlTiempo.Enabled = False
        BtnValidarFiltro.Enabled = False
        BtnValidacion.Visible = False
        LblNumAspirantes.Text = ""
        dtgAspirantes.DataSource = Nothing
        dtgAspirantes.DataBind()
    End Sub
End Class