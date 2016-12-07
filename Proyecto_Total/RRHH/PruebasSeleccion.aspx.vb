Public Class PruebasSeleccion
    Inherits System.Web.UI.Page
    Dim ObjProcesoSeleccion As New clsProcesoSeleccion

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Obtengo los datos de usuario
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                CargardrlProceso_Seleccion()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Public Sub CargardrlProceso_Seleccion()
        With drlProcesoSeleccion
            .DataSource = ObjProcesoSeleccion.ConsultaProceso_Seleccion
            .DataTextField = "Proceso"
            .DataValueField = "Cod_Proceso_Seleccion"
            .DataBind()
        End With
        With drlEstadoSeleccion
            .DataSource = ObjProcesoSeleccion.ConsultarEstadoSeleccion
            .DataTextField = "Nombre"
            .DataValueField = "Cod_Estado_Seleccion"
            .DataBind()
        End With
        With drlFiltroSeleccion
            .DataSource = ObjProcesoSeleccion.ConsultarFiltroSeleccion
            .DataTextField = "Nombre"
            .DataValueField = "Cod_Filtro_Seleccion"
            .DataBind()
        End With
    End Sub


    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''Detalle_PS_A'''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub ConsultaFiltro()
        Try
            dtgAspirantes.DataSource = ObjProcesoSeleccion.Consulta_Filtro
            dtgAspirantes.DataBind()
            LblNumAspirantes.Text = ObjProcesoSeleccion.CantidadE
        Catch ex As Exception
            lblmsg.Text = "Se produjo error" & ex.Message
        End Try
    End Sub

    Protected Sub drlProcesoSeleccion_Load(ByVal sender As Object, ByVal e As EventArgs) Handles drlProcesoSeleccion.Load
        Try
            ObjProcesoSeleccion.Cod_Proceso_Seleccion = drlProcesoSeleccion.Text
            dtgAspirantes.DataSource = ObjProcesoSeleccion.ConsultaProcesoAspirante()
            dtgAspirantes.DataBind()
            LblNumAspirantes.Text = ObjProcesoSeleccion.Cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub dtgAspirantes_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtgAspirantes.RowCommand

        Try
            'Mediante este codigo envio la identificacion del aspirante, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Seleccion" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                ObjProcesoSeleccion.Id_Aspirante = dtgAspirantes.Rows(index).Cells(0).Text
                ObjProcesoSeleccion.Consultar_Aspirantes()
                TxtIdAspirante.Text = ObjProcesoSeleccion.Id_Aspirante
                TxtNombre.Text = ObjProcesoSeleccion.Nombre_Aspirante
                TxtApellido.Text = ObjProcesoSeleccion.Apellido

                BtnGuardar.Visible = True
                drlProcesoSeleccion.Enabled = False
                BtnValidacion.Visible = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
    Protected Sub BtnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGuardar.Click
        Try
            If ((TxtIdAspirante.Text = "") Or (TxtNombre.Text = "") Or (TxtApellido.Text = "") Or (TxtObservacion_Detalle.Text = "") Or
                (drlFiltroSeleccion.Text = "1") Or (drlEstadoSeleccion.Text = "1")) Then
                lblmsg.Text = "Por favor llene todos los datos, elija filtro y estado"
            Else
                ObjProcesoSeleccion.Fk_Cod_Filtro_Seleccion = drlFiltroSeleccion.Text
                ObjProcesoSeleccion.Observacion = TxtObservacion_Detalle.Text
                ObjProcesoSeleccion.Fk_Id_Aspirante = TxtIdAspirante.Text
                ObjProcesoSeleccion.Fk_Cod_Proceso_Seleccion = drlProcesoSeleccion.Text
                ObjProcesoSeleccion.Fk_Cod_Estado_Seleccion = drlEstadoSeleccion.Text

                ObjProcesoSeleccion.Ingresar_Detalle_PS_A()

                'Cambio estado
                ObjProcesoSeleccion.Id_Aspirante = TxtIdAspirante.Text
                If ((drlFiltroSeleccion.Text = "8") And (drlEstadoSeleccion.Text = "2")) Then
                    'Actualizo cantidad de aspirantes contratados
                    ObjProcesoSeleccion.Cod_Proceso_Seleccion = drlProcesoSeleccion.Text
                    ObjProcesoSeleccion.Actualizar_Cantidad_Proceso_Seleccion()
                    'Cambio el estado del aspirante a finalizado(1)
                    ObjProcesoSeleccion.Finalizado = True
                    ObjProcesoSeleccion.Cod_Proceso_Seleccion = Nothing
                    ObjProcesoSeleccion.Actualizar_Proceso_Aspirante()
                End If
                If (drlEstadoSeleccion.Text = "5") Then
                    ObjProcesoSeleccion.Estado = False
                    ObjProcesoSeleccion.Cod_Proceso_Seleccion = Nothing
                    ObjProcesoSeleccion.Actualizar_Proceso_Aspirante()
                End If
                If (drlEstadoSeleccion.Text = "4") Then
                    ObjProcesoSeleccion.Cod_Proceso_Seleccion = 4
                    ObjProcesoSeleccion.Actualizar_Proceso_Aspirante()
                End If


                lblmsg.Text = "El filtro de selccion se ingreso correctamente"

                drlProcesoSeleccion.Enabled = True
                BtnValidacion.Visible = False
                TxtIdAspirante.Text = ""
                TxtNombre.Text = ""
                TxtApellido.Text = ""
                TxtObservacion_Detalle.Text = ""
                drlFiltroSeleccion.Text = "1"
                drlEstadoSeleccion.Text = "1"

                ''''Validacion si el proceso de selecicon ya finalizo
                ObjProcesoSeleccion.Cod_Proceso_Seleccion = drlProcesoSeleccion.Text
                ObjProcesoSeleccion.Consultar_CantidadObtenida_Proceso_Seleccion()

                If ObjProcesoSeleccion.Cantidad_Obtenida >= ObjProcesoSeleccion.Cantidad_Requerida Then
                    ObjProcesoSeleccion.Cod_Proceso_Seleccion = drlProcesoSeleccion.Text
                    ObjProcesoSeleccion.Estado = "Finalizado"
                    ObjProcesoSeleccion.Actualizar_Fin_ProcesoDeSeleccion()

                    ''Liberacion aspirantes del proceso de seleccion
                    ObjProcesoSeleccion.Cod_Proceso_Seleccion = drlProcesoSeleccion.Text
                    ObjProcesoSeleccion.Actualizar_Liberacion_aspirantes()

                End If

            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnValidacion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnValidacion.Click
        drlProcesoSeleccion.Enabled = True
        TxtIdAspirante.Text = ""
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        BtnValidacion.Visible = False
        BtnGuardar.Visible = False
    End Sub
End Class