Public Class Direct_TV
    Inherits System.Web.UI.Page
    Dim objDirect_tv As New clsDirectTv


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If

                'Datos Ciudad
                With DrlCiudad
                    .DataSource = objDirect_tv.ObtenerCiudades
                    .DataTextField = "nombremun"
                    .DataValueField = "nombremun"
                    .DataBind()
                End With

                'Datos Lugar expedicion
                With DrlLugarExpedicion
                    .DataSource = objDirect_tv.ObtenerCiudades
                    .DataTextField = "nombremun"
                    .DataValueField = "nombremun"
                    .DataBind()
                End With

                'Datos Tipo Plan
                With DrlTipoPlan
                    .DataSource = objDirect_tv.ObtenerTiposPlan
                    .DataTextField = "nombre"
                    .DataValueField = "Cod_BD_Voz_Complemento"
                    .DataBind()
                End With

                'Datos Como se entero
                With DrlComoSeEntero
                    .DataSource = objDirect_tv.ObtenerEntero
                    .DataTextField = "nombre"
                    .DataValueField = "Cod_BD_Voz_Complemento"
                    .DataBind()
                End With

                'Datos Operador
                With Drl_Operador
                    .DataSource = objDirect_tv.ObtenerOperador
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                End With
                DrlVenta_SelectedIndexChanged(1, Nothing)

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

    'Agregar ventas al datagrip
    Protected Sub BtnVentas_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnVentas.Click
        Dim dt As New DataTable
        Dim dr As DataRow
        Try
            If DrlTipoPlan.SelectedItem.Text <> "- Seleccione -" Then
                If Me.ViewState("Tabla") Is Nothing Then
                    dt.Columns.Add(New DataColumn("Tipo_Plan", GetType(String)))
                    dt.Columns.Add(New DataColumn("Desc_Plan", GetType(String)))
                Else
                    dt = Me.ViewState("Tabla")
                End If
                dr = dt.NewRow()
                dr("Tipo_Plan") = DrlTipoPlan.SelectedItem.Text
                dr("Desc_Plan") = TxtDescripcionPlan.Text
                dt.Rows.Add(dr)
                Me.ViewState.Add("Tabla", dt)

                dtgVentas.DataSource = dt.DefaultView
                dtgVentas.DataBind()
                lblmsg.Text = ""
            Else
                lblmsg.Text = "Antes de agregar la venta primero Seleccione el tipo de plan"
                Exit Sub
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    'Agregar Referencias al datagrip
    Protected Sub BtnReferidos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAgregar_Referidos.Click
        Dim dt As New DataTable
        Dim dr As DataRow
        Try
            If TxtNombreReferido.Text <> "" And TxtTelefonoReferido.Text <> "" Then
                If Me.ViewState("Tabla_Referidos") Is Nothing Then
                    dt.Columns.Add(New DataColumn("Nombre_Referido", GetType(String)))
                    dt.Columns.Add(New DataColumn("Telefono_Referido", GetType(String)))
                Else
                    dt = Me.ViewState("Tabla_Referidos")
                End If
                dr = dt.NewRow()

                dr("Nombre_Referido") = TxtNombreReferido.Text
                dr("Telefono_Referido") = TxtTelefonoReferido.Text
                dt.Rows.Add(dr)
                Me.ViewState.Add("Tabla_Referidos", dt)
                dtgReferidos.DataSource = dt.DefaultView
                dtgReferidos.DataBind()

                TxtNombreReferido.Text = ""
                TxtTelefonoReferido.Text = ""
                lblmsg.Text = ""
            Else
                lblmsg.Text = "Debe ingresar el nombre del referido y su telefono"
                Exit Sub
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub




    'Llenar Descripcion plan segun el tipo de plan
    Protected Sub DrlTipoPlan_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DrlTipoPlan.SelectedIndexChanged
        Try

            If DrlTipoPlan.SelectedValue = 111 Then
                objDirect_tv.Descripcion_Plan = "PlanDTVDesc1"
            End If
            If DrlTipoPlan.SelectedValue = 112 Then
                objDirect_tv.Descripcion_Plan = "PlanDTVDesc2"
            End If
            If DrlTipoPlan.SelectedValue = 113 Then
                objDirect_tv.Descripcion_Plan = "PlanDTVDesc3"
            End If
            objDirect_tv.ObtenerTiposPlanDescripcion()
            TxtDescripcionPlan.Text = objDirect_tv.Descripcion_Plan

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    'asigna valores de tipificacion segun el valor de Venta
    Protected Sub DrlVenta_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DrlVenta.SelectedIndexChanged
        Try
            If DrlVenta.SelectedItem.Text = "Seleccione" Then
                DrlTipificacion.Items.Clear()
                DrlTipificacion.Items.Add("- Seleccione -")
                DrlTipificacion_SelectedIndexChanged(1, Nothing)
                Exit Sub
            End If
            If DrlVenta.SelectedValue = "False" Then
                'Datos Tipificacion
                With DrlTipificacion
                    .DataSource = objDirect_tv.ObtenerTipificaciones
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
                    .DataBind()
                End With
            End If
            If DrlVenta.SelectedValue = "True" Then
                DrlTipificacion.Items.Clear()
                DrlTipificacion.Items.Add("Venta")
            End If
            DrlTipificacion_SelectedIndexChanged(1, Nothing)
        Catch ex As Exception
            lblmsg.Text = "Se produjo un error al cargar Droplist Tipificacion " & ex.Message
        End Try
    End Sub


    Protected Sub BtnIdCliente_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnIdCliente.Click
        Try
            BtnGuardar.Enabled = True
            lblmsg.Text = ""

            If TxtIdCliente.Text = "" Then
                lblmsg.Text = "Debe ingresar un valor para la busqueda ID cliente o R+Celular 'Referido' "
                Borrar_Cajas()
                Exit Sub

            ElseIf LblTipoLlamada.Text = "" Then
                lblmsg.Text = "Debe ingresar si la llamada es INBOUND o OUTBOUND"
                Exit Sub
            Else

                If InStr(1, TxtIdCliente.Text, "R") Then
                    objDirect_tv.Validacion = 1
                    objDirect_tv.Id_Busq_Char = TxtIdCliente.Text
                    objDirect_tv.Id_Busq_Num = 0
                Else
                    objDirect_tv.Validacion = 0
                    objDirect_tv.Id_Busq_Char = ""
                    objDirect_tv.Id_Busq_Num = TxtIdCliente.Text
                End If

                objDirect_tv.Obtener_Cliente()
                If objDirect_tv.Id_Direct_TV_Cliente = Nothing Then
                    lblmsg.Text = "No se encontraron Resultados con el ID " + TxtIdCliente.Text
                    Borrar_Cajas()
                    Exit Sub
                End If
                Borrar_Cajas()
                If objDirect_tv.Id_Cliente = "" Then
                    objDirect_tv.Id_Cliente = objDirect_tv.Id_Direct_TV_Cliente
                End If

                LblIdDirectTvCliente.Text = objDirect_tv.Id_Direct_TV_Cliente
                LblIdCliente.Text = objDirect_tv.Id_Cliente
                LblNombreCliente.Text = objDirect_tv.Nombre_Cliente
                TxtDireccion.Text = objDirect_tv.Direccion
                TxtTelefonoCliente.Text = objDirect_tv.Telefono_Cliente
                TxtTelefonoCliente0.Text = objDirect_tv.Telefono_Cliente0
                TxtCelularCliente.Text = objDirect_tv.Celular_Cliente
                If objDirect_tv.Ciudad <> "" Then
                    DrlCiudad.SelectedValue = objDirect_tv.Ciudad
                End If
                LblIdCaso.Text = objDirect_tv.Id_Direct_TV_Caso
                LblTipificacion.Text = objDirect_tv.Tipificacion
                If objDirect_tv.FechaProg = "01/01/2000 12:00:00" Then

                Else

                    TxtFechaProg.Text = objDirect_tv.FechaProg.ToShortDateString
                    TxtHoraProg.Text = Format(objDirect_tv.FechaProg, "HH")
                    TxtMinProg.Text = DatePart(DateInterval.Minute, objDirect_tv.FechaProg)
                End If
                TxtObservacion.Text = objDirect_tv.Observacion

                TxtCedula.Text = objDirect_tv.Cedula_Cliente
                If objDirect_tv.Expedicion_Cedula <> "" Then
                    DrlLugarExpedicion.SelectedValue = objDirect_tv.Expedicion_Cedula
                End If


                If objDirect_tv.Fc_Nacimiento = Nothing Then
                    TxtFcNacimiento.Text = ""
                Else
                    TxtFcNacimiento.Text = objDirect_tv.Fc_Nacimiento
                End If
                TxtCorreo.Text = objDirect_tv.Correo_Cliente
                TxtNombreContacto.Text = objDirect_tv.Nombre_Contacto
                TxtTelefonoContacto.Text = objDirect_tv.Telefono_Contacto

                TxtNumeroContrato.Text = objDirect_tv.Numero_Contrato
                TxtCodCodensa.Text = objDirect_tv.Cod_Factura_Codensa
                TxtIBS.Text = objDirect_tv.IBS

                TxtLocalidad.Text = objDirect_tv.Localidad
                If objDirect_tv.Estrato <> "" Then
                    DrlEstrato.SelectedValue = objDirect_tv.Estrato
                End If
                If objDirect_tv.Operador <> "" Then
                    Drl_Operador.SelectedValue = objDirect_tv.Operador
                End If

                objDirect_tv.Obtener_Referentes()
                LblNombreReferente.Text = objDirect_tv.Nombre_Referente
                LblIdReferente.Text = objDirect_tv.Id_Referente
                dtgVerVentas.DataSource = objDirect_tv.Obtener_Ventas()
                dtgVerVentas.DataBind()
                dtgReferidosVista.DataSource = objDirect_tv.Obtener_Referencias()
                dtgReferidosVista.DataBind()

                dtgCasos.DataSource = objDirect_tv.Obtener_Casos
                dtgCasos.DataBind()
            End If

        Catch ex As Exception
            lblmsg.Text = "Se produjo un error al Obtener la informacion del cliente " & ex.Message
        End Try
    End Sub

    Protected Sub BtnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGuardar.Click
        Try
            If LblIdCliente.Text = "" Then
                lblmsg.Text = "Primero se debe realizar una busqueda de cliente"
                BtnGuardar.Enabled = True
                Exit Sub
            End If

            If DrlVenta.SelectedItem.Text = "Seleccione" Then
                lblmsg.Text = "Debe ingresar si se realizo o no una venta"
                BtnGuardar.Enabled = True
                Exit Sub
            ElseIf DrlTipificacion.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Debe ingresar una tipificación"
                BtnGuardar.Enabled = True
                Exit Sub
            Else
                objDirect_tv.Tipificacion = DrlTipificacion.SelectedItem.Text
            End If
            If DrlTipificacion.SelectedItem.Text = "Venta" Then
                If dtgVentas.Rows.Count = 0 Then
                    lblmsg.Text = "Se debe realizar una Venta"
                    BtnGuardar.Enabled = True
                    Exit Sub
                End If
                If TxtIBS.Text = "" Or TxtIBS.Text = "0" Then
                    lblmsg.Text = "Ingrese el IBS de la Venta"
                    Exit Sub
                End If
            End If
            If LblTipoLlamada.Text = "OUTBOUND" And DrlTipificacion.SelectedItem.Text = "Ilocalizable" And Drl_Ilozaliza_Por.Visible = True Then
                If Drl_Ilozaliza_Por.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione el motivo por el cual la llamada es ilocalizable"
                    Exit Sub
                End If
            End If
            If DrlCiudad.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una ciudad"
                Exit Sub
            End If

            BtnGuardar.Enabled = False
            lblmsg.Text = ""
            If InStr(1, LblIdCliente.Text, "R") Then
                objDirect_tv.Validacion = 1
            Else
                objDirect_tv.Validacion = 0
            End If
            '-------Guardar Informacion Clientes-------'
            objDirect_tv.Id_Cliente = LblIdCliente.Text
            objDirect_tv.Direccion = TxtDireccion.Text
            objDirect_tv.Telefono_Cliente = TxtTelefonoCliente.Text
            objDirect_tv.Telefono_Cliente0 = TxtTelefonoCliente0.Text
            objDirect_tv.Celular_Cliente = TxtCelularCliente.Text
            objDirect_tv.Ciudad = DrlCiudad.SelectedItem.Text
            objDirect_tv.Cedula_Cliente = TxtCedula.Text
            objDirect_tv.Expedicion_Cedula = DrlLugarExpedicion.SelectedItem.Text

            If TxtFcNacimiento.Text <> "" Then
                objDirect_tv.Fc_Nacimiento = CDate(TxtFcNacimiento.Text)
            Else
                objDirect_tv.Fc_Nacimiento = Nothing
            End If

            objDirect_tv.Nombre_Contacto = TxtNombreContacto.Text
            objDirect_tv.Telefono_Contacto = TxtTelefonoContacto.Text
            objDirect_tv.Correo_Cliente = TxtCorreo.Text

            objDirect_tv.Localidad = TxtLocalidad.Text
            If DrlEstrato.SelectedItem.Text <> "- Seleccione -" Then
                objDirect_tv.Estrato = DrlEstrato.Text
            Else
                objDirect_tv.Estrato = ""
            End If
            If Drl_Operador.SelectedItem.Text <> "- Seleccione -" Then
                objDirect_tv.Operador = Drl_Operador.Text
            Else
                objDirect_tv.Operador = ""
            End If

            objDirect_tv.Guardar_Informacion_Clientes()
            '------------------------------------------'

            '----------------Guardar Caso--------------'
            'If DrlTipificacion.SelectedValue = "" Then
            '    objDirect_tv.Tipificacion = LblTipificacion.Text
            '    If LblTipificacion.Text = "" Then
            '        lblmsg.Text = "Debe ingresar si se realizo venta y su correspondiente tipificacion"
            '        BtnGuardar.Enabled = True
            '        Exit Sub
            '    End If
            'Else


            'End If
            objDirect_tv.Id_Cliente = LblIdCliente.Text
            objDirect_tv.Id_Agente = lblusuario.Text

            If DrlTipificacion.SelectedItem.Text = "Interesado Programado" Then
                If TxtFechaProg.Text = "" Or TxtHoraProg.Text = "" Or TxtMinProg.Text = "" Then
                    lblmsg.Text = "Debe ingresar fecha y hora de programacion"
                    BtnGuardar.Enabled = True
                    Exit Sub
                Else
                    If CDate(TxtFechaProg.Text + " " + TxtHoraProg.Text + ":" + TxtMinProg.Text) < Now Then
                        lblmsg.Text = "La fecha de programacion debe ser una fecha mayor a la actual"
                        BtnGuardar.Enabled = True
                        Exit Sub
                    Else
                        objDirect_tv.FechaProg = CDate(TxtFechaProg.Text + " " + TxtHoraProg.Text + ":" + TxtMinProg.Text)
                    End If
                End If
            Else
                objDirect_tv.FechaProg = Nothing
            End If


            objDirect_tv.Observacion = TxtObservacion.Text
            objDirect_tv.Id_Direct_TV_Caso = LblIdCaso.Text

            'If LblIdCaso.Text = 0 Then
            '    objDirect_tv.Validacion = 1
            'Else
            '    objDirect_tv.Validacion = 0
            'End If


            objDirect_tv.Numero_Contrato = TxtNumeroContrato.Text
            objDirect_tv.Cod_Factura_Codensa = TxtCodCodensa.Text
            objDirect_tv.IBS = TxtIBS.Text
            objDirect_tv.TipoLlamada = LblTipoLlamada.Text
            If Drl_Ilozaliza_Por.Visible = True Then
                    objDirect_tv.Ilocalizado_Por = Drl_Ilozaliza_Por.SelectedItem.Text
            End If

            objDirect_tv.ComoSeEntero = DrlComoSeEntero.SelectedItem.Text + " " + TxtComoSeEntero.Text

            objDirect_tv.Guardar_Caso()

            '------------------------------------------'

            '----------------Guardar Ventas--------------'
            For Each row As GridViewRow In dtgVentas.Rows
                objDirect_tv.Id_Cliente = LblIdCliente.Text
                objDirect_tv.Obtener_Id_Caso()
                objDirect_tv.Id_Direct_TV_Cliente = LblIdDirectTvCliente.Text
                objDirect_tv.Tipo_Plan = row.Cells(0).Text
                objDirect_tv.Descripcion_Plan = row.Cells(1).Text
                objDirect_tv.Guardar_Ventas()
            Next
            '------------------------------------------'

            '----------------Guardar Referidos--------------'
            For Each row As GridViewRow In dtgReferidos.Rows
                objDirect_tv.Id_Cliente = LblIdCliente.Text
                objDirect_tv.Nombre_Referido = row.Cells(0).Text
                objDirect_tv.Telefono_Referido = "R" + row.Cells(1).Text
                objDirect_tv.Guardar_Referidos()
            Next
            '------------------------------------------'


            lblmsg.Text = "Se guardo correctamente la información del cliente "
            Borrar_Cajas()
            LblTipoLlamada.Text = ""
            BtnGuardar.Enabled = True

        Catch ex As Exception
            lblmsg.Text = "Se produjo un error " & ex.Message
        End Try
    End Sub




    Protected Sub Borrar_Cajas()
        Try
            LblFcProgramacion.Text = ""
            LblIdCaso.Text = ""
            LblIdCliente.Text = ""
            LblIdReferente.Text = ""
            LblNombreCliente.Text = ""
            LblNombreReferente.Text = ""
            LblTipificacion.Text = ""
            TxtTelefonoCliente.Text = ""
            TxtTelefonoCliente0.Text = ""
            TxtCelularCliente.Text = ""

            TxtDescripcionPlan.Text = ""
            TxtDireccion.Text = ""
            TxtFechaProg.Text = ""
            TxtHoraProg.Text = ""
            TxtIdCliente.Text = ""
            TxtMinProg.Text = ""
            TxtObservacion.Text = ""
            DrlCiudad.SelectedValue = "- SELECCIONE -"
            DrlVenta.SelectedValue = "Seleccione"
            DrlVenta_SelectedIndexChanged(1, Nothing)
            DrlTipificacion_SelectedIndexChanged(1, Nothing)

            TxtCedula.Text = ""
            DrlLugarExpedicion.SelectedValue = "- SELECCIONE -"
            TxtFcNacimiento.Text = ""
            TxtCorreo.Text = ""
            TxtNombreContacto.Text = ""
            TxtTelefonoContacto.Text = ""
            TxtCodCodensa.Text = ""
            TxtNumeroContrato.Text = ""
            TxtIBS.Text = ""
            DrlComoSeEntero.SelectedValue = "1"
            TxtComoSeEntero.Text = ""
            DrlTipoPlan.SelectedValue = "1"
            TxtLocalidad.Text = ""
            DrlEstrato.SelectedValue = "- Seleccione -"
            Drl_Operador.SelectedValue = "- Seleccione -"

            dtgVentas.DataSource = Nothing
            dtgVentas.DataBind()
            dtgVerVentas.DataSource = Nothing
            dtgVerVentas.DataBind()
            dtgReferidos.DataSource = Nothing
            dtgReferidos.DataBind()
            dtgReferidosVista.DataSource = Nothing
            dtgReferidosVista.DataBind()
            dtgCasos.DataSource = Nothing
            dtgCasos.DataBind()
            DrlTipificacion.Items.Clear()

        Catch ex As Exception
            lblmsg.Text = "Se produjo un error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNuevo.Click
        Try
            Page.Response.Redirect(Page.Request.Url.AbsolutePath)
        Catch ex As Exception
            lblmsg.Text = "Se produjo un error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnAgregarCliente_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAgregarCliente.Click
        Try
            PanelCliente.Visible = True
        Catch ex As Exception
            lblmsg.Text = "Se produjo un error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnAgregar_Cliente_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAgregar_Cliente.Click
        Try
            If TxtGuardarNomCliente.Text = "" Or TxtGuardarTelCliente.Text = "" Then
                lblmsg.Text = "Debe ingresar nombre y numero telefonico"
                Exit Sub
            End If
            objDirect_tv.Nombre_Cliente = TxtGuardarNomCliente.Text
            objDirect_tv.Telefono_Cliente = TxtGuardarTelCliente.Text
            objDirect_tv.Id_Agente = lblusuario.Text
            If objDirect_tv.Cliente_Duplicado().Tables(0).Rows.Count = 0 Then
                objDirect_tv.Guardar_Cliente_Nuevo()

                Exit Sub
            End If

            objDirect_tv.Obtener_Ultimo_Cliente()
            TxtIdCliente.Text = objDirect_tv.Id_Cliente
            LblTipoLlamada.Text = "INBOUND"
            PanelCliente.Visible = False
            TxtGuardarNomCliente.Text = ""
            TxtGuardarTelCliente.Text = ""
            BtnIdCliente_Click(1, Nothing)
        Catch ex As Exception
            lblmsg.Text = "Se produjo un error: " + ex.Message
        End Try
    End Sub


    Protected Sub BtnIn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnIn.Click
        Try
            LblTipoLlamada.Text = "INBOUND"
            DrlTipificacion_SelectedIndexChanged(1, Nothing)
        Catch ex As Exception
            lblmsg.Text = ex.Message
        End Try
    End Sub


    Protected Sub BtnOut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnOut.Click
        Try
            LblTipoLlamada.Text = "OUTBOUND"
            DrlTipificacion_SelectedIndexChanged(1, Nothing)
        Catch ex As Exception
            lblmsg.Text = ex.Message
        End Try
    End Sub

    Protected Sub dtgCasos_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs) Handles dtgCasos.PageIndexChanging
        Try
            objDirect_tv.Id_Cliente = LblIdCliente.Text
            dtgCasos.PageIndex = e.NewPageIndex
            dtgCasos.DataSource = objDirect_tv.Obtener_Casos
            dtgCasos.DataBind()
        Catch ex As Exception
            lblmsg.Text = ex.Message
        End Try
    End Sub


    Protected Sub DrlTipificacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DrlTipificacion.SelectedIndexChanged
        Try
            If DrlTipificacion.SelectedItem.Value = "Ilocalizable" And LblTipoLlamada.Text = "OUTBOUND" Then
                'Datos Operador
                With Drl_Ilozaliza_Por
                    .DataSource = objDirect_tv.ObtenerIlocalizado_Por
                    .DataTextField = "nombre"
                    .DataValueField = "Cod_BD_Voz_Complemento"
                    .DataBind()
                End With
                Panel_Drl_Ilozaliza_Por.Visible = True
            Else
                Panel_Drl_Ilozaliza_Por.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
End Class