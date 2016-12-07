Public Class BoldChat
    Inherits System.Web.UI.Page
    Dim ObjBoldChat As New clsBoldChat

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Registro Bold Chat"
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                '*****   NUEVO   ******
                Dim objdatosCRM As New clscrmdatos
                With Drl_Tipo_Falla
                    .DataSource = objdatosCRM.Consulta_Tipo_Falla
                    .DataTextField = "tipificacion1"
                    .DataValueField = "id_tipificacion"
                    .DataBind()
                End With

                With drlingclaro
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultaing
                    .DataTextField = "ingclaro"
                    .DataValueField = "ingclaro"
                    .DataBind()
                End With
                With drlTipo
                    .DataSource = ObjBoldChat.BolTipo
                    .DataTextField = "Nombre"
                    .DataValueField = "Cod_Bol_Tipo"
                    .DataBind()
                End With
                ObjBoldChat.Estado = drlTipo.SelectedItem.Value
                With drlSegmento
                    .DataSource = ObjBoldChat.BolSegmento
                    .DataTextField = "Nombre"
                    .DataValueField = "Cod_Bol_Segmento"
                    .DataBind()
                End With
                With drlTS
                    .DataSource = ObjBoldChat.BolTipoSoporte
                    .DataTextField = "Nombre"
                    .DataValueField = "Cod_Bol_TS"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Sub buscarinf()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el Caso o Min que desea consultar"
            Else
                If txtcaso.Text <> "" Then
                    objdatos.caso = txtcaso.Text
                    ObjBoldChat.Idcaso = txtcaso.Text
                End If
                objdatos.Consultacasos_Datos_Dilo_Voz()
                If objdatos.cantidad > 0 Then
                    lblcliente.Text = objdatos.cliente
                    lblmin.Text = objdatos.min
                    lblequipo.Text = objdatos.equipo
                    lblcaso.Text = objdatos.caso
                    LblMesa.Text = objdatos.mesa
                    If txtcaso.Text = "" Then
                        txtcaso.Text = objdatos.caso
                    End If
                    Pnl_Message.CssClass = Nothing
                    lblmsg.Text = Nothing
                    'Gestion Casos Datos, Dilo o Voz'
                    dtggeneral.DataSource = objdatos.ConsultaGestion_Casos_Datos_Dilo_Voz
                    dtggeneral.DataBind()
                    lblcuenta.Text = objdatos.cantidad
                    If lblcuenta.Text = "" Then
                        Panel1.Visible = False
                    Else
                        Panel1.Visible = True
                    End If

                    'Casos Boldchat '
                    dtggeneralBolchat.DataSource = ObjBoldChat.Consultacasos_Bolchat
                    dtggeneralBolchat.DataBind()
                    lblcuentaBol.Text = ObjBoldChat.Cantidad
                    If lblcuentaBol.Text = "" Then
                        PnlGeneral.Visible = False
                    Else
                        PnlGeneral.Visible = True
                    End If
                    PanelBoldChat.Visible = False
                    TxtCasoReg.Text = ""
                Else
                    lblcliente.Text = ""
                    lblmin.Text = ""
                    lblequipo.Text = ""
                    lblcaso.Text = ""
                    LblMesa.Text = ""
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No se han encontrado registros coincidentes"
                    dtggeneral.DataSource = Nothing
                    dtggeneral.DataBind()
                    lblcuenta.Text = ""
                    dtggeneralBolchat.DataSource = Nothing
                    dtggeneralBolchat.DataBind()
                    lblcuentaBol.Text = ""
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub btnConsultaCaso_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConsultaCaso.Click
        Try
            buscarinf()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardarIngClaro.Click
        Try
            Dim objdatos As New clscrmdatos
            Dim objdatosgr As New clsgeneral
            If txtingclaro.Text = "" Then
              Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el nuevo ingeniero a registrar"
                Exit Sub
            Else
                objdatos.ingn3 = txtingclaro.Text
            End If
            objdatos.registroingclaro()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Ingeniero ingresado con éxito"
            txtingclaro.Text = ""
            With drlingclaro
                objdatosgr.idtip = 1
                .DataSource = objdatosgr.consultaing
                .DataTextField = "ingclaro"
                .DataValueField = "ingclaro"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub drlTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlTipo.SelectedIndexChanged
        Try
            ObjBoldChat.Estado = drlTipo.SelectedItem.Value
            With drlSegmento
                ObjBoldChat.idtip = 1
                .DataSource = ObjBoldChat.BolSegmento
                .DataTextField = "Nombre"
                .DataValueField = "Cod_Bol_Segmento"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub btnindentifBol_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnindentifBol.Click
        Try
            If (TxtFecha_Recepcion.Text = "") Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione la fecha de recepcion del caso"
                Exit Sub
            End If
            If (drlingclaro.Text = "- Seleccione -") Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione el ingeniero que remite el caso"
                Exit Sub
            End If
            If (drlTipo.Text = "1") Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione el tipo"
                Exit Sub
            End If
            If ((drlSegmento.Text = "1") Or (drlSegmento.Text = "2") Or (drlSegmento.Text = "3")) Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione el segmento"
                Exit Sub
            End If
            If (drlRecomendado.Text = "- Seleccione -") Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione la recomdacion del caso"
                Exit Sub
            End If
            If (drlTS.Text = "- Seleccione -") Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Seleccione un tipo de soporte"
                Exit Sub
            End If
            ObjBoldChat.Idcaso = lblcaso.Text
            ObjBoldChat.Idusuario = CType(Session("permisos"), clsusuario).usuario
            ObjBoldChat.Ing_Remite = drlingclaro.SelectedItem.Text
            ObjBoldChat.Cas_Fecha_Registro = ObjBoldChat.Cas_Fecha_Registro
            If TxtFecha_Recepcion.Text > ObjBoldChat.Cas_Fecha_Registro Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> La fecha de recepcion no puede ser mayor a la fecha actual"
                Exit Sub
            Else
                ObjBoldChat.Cas_Fecha_Recepcion = TxtFecha_Recepcion.Text
            End If
            ObjBoldChat.Recomen_Prioridad = drlRecomendado.SelectedItem.Text
            ObjBoldChat.Tipo = drlTipo.Text
            ObjBoldChat.Segmento = drlSegmento.Text
            ObjBoldChat.Tipo_Soporte = drlTS.Text
            ObjBoldChat.Min_Ac = lblmin.Text
            ObjBoldChat.Nom_Cliente = lblcliente.Text
            ObjBoldChat.Equipo_Ac = lblequipo.Text
            ObjBoldChat.Bandeja = LblMesa.Text
            ObjBoldChat.IngresarCasoBandeja_Bolt()

            TxtFecha_Recepcion.Text = ""
            drlingclaro.Text = "- Seleccione -"
            drlRecomendado.Text = "- Seleccione -"
            drlTipo.Text = "1"
            drlTS.Text = "1"

            buscarinf()

            txtcaso.Text = ""

            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Caso registrado como Bolchat"


        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub btncrea_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncrea.Click
        Try
            If txtcaso.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Antes de realizar un registro bold chat Consulte el caso"
                Exit Sub
            End If
            buscarinf()
            If dtggeneral.Rows.Count > 0 Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> Este caso " + txtcaso.Text + " ya se encuentra registrado en alguna bandeja"
                PanelBoldChat.Visible = False
                Exit Sub
            End If
            PanelBoldChat.Visible = True
            TxtCasoReg.Text = txtcaso.Text
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnRegBoldCha_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnRegBoldCha.Click
        Try
            Dim objdatos As New clscrmdatos
            If TxtNombreReg.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el nombre del cliente"
                Exit Sub
            End If
            If TxtMinReg.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el min ac"
                Exit Sub
            End If
            If TxtEquipoReg.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el equipo"
                Exit Sub
            End If
            If drlRegMesa.SelectedItem.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> seleccione la mesa de donde probiene el caso"
                Exit Sub
            End If
            '******  NUEVO   *******
            If (Drl_Tipo_Falla.SelectedItem.Text = "- Seleccione -") Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Tipo de Falla"
                Exit Sub
            End If
            objdatos.Tipo_Falla = Drl_Tipo_Falla.SelectedItem.Text


            If drlRegMesa.SelectedItem.Text = "Dilo" Then
                objdatos.min = TxtMinReg.Text
                objdatos.cliente = TxtNombreReg.Text
                objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                objdatos.mesa = drlRegMesa.SelectedItem.Text
                objdatos.AsignaConsecDilo()
                Dim cas As String
                cas = objdatos.abierto
                objdatos.caso = objdatos.abierto
                objdatos.RegistroDiloNuevo()
                txtcaso.Text = cas
            Else
                objdatos.nompaquete = TxtNombreReg.Text
                objdatos.min = TxtMinReg.Text
                objdatos.equipo = TxtEquipoReg.Text
                objdatos.caso = TxtCasoReg.Text
                objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                objdatos.mesa = drlRegMesa.SelectedItem.Text
                objdatos.RegistroBoldChat()
                txtcaso.Text = TxtCasoReg.Text
            End If
            buscarinf()
            PanelBoldChat.Visible = False
            TxtNombreReg.Text = ""
            TxtMinReg.Text = ""
            TxtEquipoReg.Text = ""
            drlRegMesa.Text = "- Seleccione -"
            TxtCasoReg.Text = ""
            lblcaso = Nothing
            lblcliente = Nothing
            lblequipo = Nothing
            LblMesa = Nothing
            lblmin = Nothing
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub dtggeneralBolchat_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneralBolchat.PageIndexChanging
        Try
            dtggeneralBolchat.PageIndex = e.NewPageIndex 
            buscarinf()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex
            buscarinf()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
End Class