Public Class Dilo_inbound
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Registro CRM Dilo"
                Dim objdatos As New clsgeneral
                objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                cargar_drl()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    'Cargar DRL
    Sub cargar_drl()
        Try
            Dim ObjGeneral As New clsgeneral
            'divipola - dpto - REGISTRO CRM
            With drldpto
                ObjGeneral.idtip = 1
                .DataSource = ObjGeneral.consultadpto
                .DataTextField = "nombredpto"
                .DataValueField = "coddpto"
                .DataBind()
            End With
            ObjGeneral.dpto = drldpto.SelectedItem.Value
            With drlmun
                ObjGeneral.idtip = 1
                .DataSource = ObjGeneral.consultamun
                .DataTextField = "nombremun"
                .DataValueField = "coddiv"
                .DataBind()
            End With

            'Condiciones de uso
            With drlFtectolog
                ObjGeneral.idusuario = 4
                .DataSource = ObjGeneral.consultadiagnostico
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With

            'marca
            With drlmarca
                .DataSource = ObjGeneral.consultamarca
                .DataTextField = "marca"
                .DataValueField = "marca"
                .DataBind()
            End With

            'equipo
            ObjGeneral.estado = drlmarca.SelectedItem.Value
            With drlequipo
                .DataSource = ObjGeneral.consultaequipo
                .DataTextField = "equipo"
                .DataValueField = "equipo"
                .DataBind()
            End With
            'Tipo Canal
            With drl_canal
                ObjGeneral.Validacion = "Canal_Dilo"
                .DataSource = ObjGeneral.consulta_campaña_inb
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
            End With

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    'Limpiar herramientas
    Protected Sub limpiar_herramientas()
        Try
            txt_IDAVAYA.Text = ""
            txt_nombre.Text = ""
            txt_min.Text = ""
            txt_red_distribucion.Text = ""
            txtbarrio.Text = ""
            txt_direccion.Text = ""
            drl_zona.SelectedIndex = 0
            drlFtectolog.SelectedIndex = 0
            CHKSD.Checked = False
            txt_SD.Enabled = False
            txt_SD.Text = ""
            txt_formato.Text = ""
            drl_mesa.SelectedIndex = 0
            drl_canal.SelectedIndex = 0

            txtnumalt.Text = ""
            txtnumalt.Enabled = False
            drlmarca.SelectedIndex = 0
            drlmarca_SelectedIndexChanged(1, Nothing)
            drldpto.SelectedIndex = 0
            drldpto_SelectedIndexChanged(1, Nothing)
            chkSi.Checked = False
            chkNo.Checked = False
            txtobs.Text = ""

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    'CREAR
    Protected Sub Btn_caso_nuevo_Click(sender As Object, e As EventArgs) Handles Btn_caso_nuevo.Click
        Try
            Panel_seguimiento.Visible = True
            Session("PermiteGuardar") = "True"
            btnguardar.Enabled = True
            Panel_consulta.Visible = False
            txtcaso.Text=""
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    'Buscar
    Protected Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            If txtcaso.Text = "" Then
                Panel_consulta.Visible = False
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el caso que desea buscar"
                Exit Sub
            End If
            'CASO
            If InStr(1, txtcaso.Text, " ") Then
                Panel_consulta.Visible = False
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> En la caja de texto caso no pueden existir espacios verifique!!"
                Exit Sub
            End If
            Dim objdatos As New clscrmdatos
            objdatos.caso = txtcaso.Text
            objdatos.Validacion = "Consulta"
            Session("consulta") = objdatos.Validacion_caso_inbound_dilo()
            If objdatos.cantidad = 0 Then
                Panel_consulta.Visible = False
                Panel_seguimiento.Visible = False
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No se encontraron registros"
                Exit Sub
            Else
                Panel_seguimiento.Visible = False
                Panel_consulta.Visible = True
                DtgGeneral.DataSource = Session("consulta")
                DtgGeneral.DataBind()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            Dim objdatos As New clscrmdatos
            Dim caso As String
            'ID AVAYA
            If txt_IDAVAYA.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite Id de AVAYA"
                Exit Sub
            End If
            'Nombre
            If txt_nombre.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite Nombre"
                Exit Sub
            End If
            'Min
            If txt_min.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite Min"
                Exit Sub
            End If
            'Red de distribucion
            If txt_red_distribucion.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite Red de Distribucion"
                Exit Sub
            End If
            'Marca - Equipo
            If drlequipo.SelectedIndex = 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione Marca y Equipo"
                Exit Sub
            End If
            'Depto - Municipio
            If drlmun.SelectedIndex = 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione Departamento y Municipio"
                Exit Sub
            End If
            'Barrio
            If txtbarrio.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite Barrio"
                Exit Sub
            End If
            'Direccion
            If txt_direccion.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite Direccion"
                Exit Sub
            End If
            'Zona
            If drl_zona.SelectedIndex = 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione Zona"
                Exit Sub
            End If
            'NUMERO ALTERNO'
            If chkSi.Checked = False And chkNo.Checked = False Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione si realizo contacto a linea alterna"
                Exit Sub
            Else
                If chkSi.Checked = True Then
                    If txtnumalt.Text = "" Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el numero alterno"
                        Exit Sub
                    Else
                        objdatos.telalt = txtnumalt.Text
                    End If
                End If
                If chkNo.Checked = True Then
                    objdatos.telalt = txt_min.Text
                End If
            End If
            'Condiciones de uso
            If drlFtectolog.SelectedIndex = 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione Condiciones de uso"
                Exit Sub
            End If
            'Falla SGSC
            If CHKSD.Checked = True Then
                If txt_SD.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el SD de incidencia"
                    Exit Sub
                End If
            End If
            'CASO
            If InStr(1, txt_formato.Text, " ") Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> En la caja de texto caso no pueden existir espacios verifique!!"
                Exit Sub
            End If
            'CASO
            If txt_formato.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el caso que desea registrar"
                Exit Sub
            End If
            'Mesa
            If drl_mesa.SelectedIndex = 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione Mesa"
                Exit Sub
            End If
            'Canal
            If drl_canal.SelectedIndex = 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Canal"
                Exit Sub
            End If
            'Observacion
            If txtobs.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite una observacion"
                Exit Sub
            End If


            '---------------CAPTURA INFORMACION------------
            'ID AVAYA
            If txt_IDAVAYA.Text = "" Then
                objdatos.idcrm = ""
            Else
                objdatos.idcrm = txt_IDAVAYA.Text
            End If
            'cliente
            If txt_nombre.Text = "" Then
                objdatos.cliente = ""
            Else
                objdatos.cliente = txt_nombre.Text.ToUpper
            End If
            'Min
            If txt_min.Text = "" Then
                objdatos.min = ""
            Else
                objdatos.min = txt_min.Text
            End If
            'Red de distribucion
            If txt_red_distribucion.Text = "" Then
                objdatos.areafalla = ""
            Else
                objdatos.areafalla = txt_red_distribucion.Text.ToUpper
            End If
            'Marca - Equipo
            If drlequipo.SelectedIndex = 0 Then
                objdatos.equipo = ""
            Else
                objdatos.equipo = drlequipo.SelectedItem.Text.ToUpper
            End If
            'Municipio
            If drldpto.SelectedIndex = 0 Then
                objdatos.dpto = ""
            Else
                objdatos.dpto = drldpto.SelectedItem.Text.ToUpper
            End If
            'Municipio
            If drlmun.SelectedIndex = 0 Then
                objdatos.mun = ""
            Else
                objdatos.mun = drlmun.SelectedItem.Text.ToUpper
            End If
            'Barrio
            If txtbarrio.Text = "" Then
                objdatos.barrio = ""
            Else
                objdatos.barrio = txtbarrio.Text.ToUpper.ToUpper
            End If
            'Direccion
            If txt_direccion.Text = "" Then
                objdatos.dir = ""
            Else
                objdatos.dir = txt_direccion.Text.ToUpper.ToUpper
            End If
            'Zona
            If drl_zona.SelectedIndex = 0 Then
                objdatos.zona = ""
            Else
                objdatos.zona = drl_zona.SelectedItem.Text
            End If
            'Condiciones de uso
            If drlFtectolog.SelectedIndex = 0 Then
                objdatos.tecnologia = ""
            Else
                objdatos.tecnologia = drlFtectolog.SelectedItem.Text.ToUpper
            End If
            'Falla SGSC
            If txt_SD.Text = "" Then
                objdatos.tickler = ""
            Else
                objdatos.tickler = txt_SD.Text
            End If
            'CASO
            If txt_formato.Text = "" Then
                objdatos.caso = ""
            Else
                objdatos.caso = txt_formato.Text
            End If
            'Mesa
            If drl_mesa.SelectedIndex = 0 Then
                objdatos.mesa = ""
            Else
                objdatos.mesa = drl_mesa.SelectedItem.Text
            End If
            'canal
            If drl_canal.SelectedIndex = 0 Then
                objdatos.Bandeja = ""
            Else
                objdatos.Bandeja = drl_canal.SelectedItem.Text
            End If
            'Observacion
            If txtobs.Text = "" Then
                objdatos.obs = ""
            Else
                objdatos.obs = txtobs.Text
            End If
            objdatos.caso = txt_formato.Text
            If objdatos.Validacion_caso_inbound_dilo().Tables(0).Rows.Count <> 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> El caso " & txt_formato.Text & " ya fue creado"
                Exit Sub
            End If
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            'REGISTRO CRMDETALLE
            If Session("PermiteGuardar") <> Nothing Then
                caso = objdatos.Registrar_Dilo_inbound().Tables(0).Rows(0).Item("Caso")
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> La acción esta inhabilita o genera duplicidad consulta de nuevo el caso para validar la gestión y permitir el registro"
                Exit Sub
            End If

            If caso <> "" Then
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Seguimiento ingresado con éxito, se genero el consecutivo " & caso & " "
            End If
            Session("PermiteGuardar") = Nothing
            Panel_seguimiento.Visible = False
            limpiar_herramientas()
            txtcaso.Text = caso
            btn_buscar_Click(1, Nothing)

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub


    '--------DRL--------
    'marca > equipo
    Protected Sub drlmarca_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlmarca.SelectedIndexChanged
        Try
            Dim ObjGeneral As New clsgeneral
            ObjGeneral.estado = drlmarca.SelectedItem.Value
            With drlequipo
                ObjGeneral.idtip = 1
                .DataSource = ObjGeneral.consultaequipo
                .DataTextField = "equipo"
                .DataValueField = "equipo"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span>  " & ex.Message
        End Try
    End Sub
    'drl departamento
    Protected Sub drldpto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drldpto.SelectedIndexChanged
        Try
            Dim ObjGeneral As New clsgeneral
            'divipola - dpto
            ObjGeneral.dpto = drldpto.SelectedItem.Value
            With drlmun
                ObjGeneral.idtip = 1
                .DataSource = ObjGeneral.consultamun
                .DataTextField = "nombremun"
                .DataValueField = "coddiv"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>  " & ex.Message
        End Try
    End Sub

    'numero alterno
    Protected Sub Si_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkSi.CheckedChanged
        Try
            If chkSi.Checked = True Then
                txtnumalt.Visible = True
                txtnumalt.Text = ""
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span>  " & ex.Message
        End Try
    End Sub
    Protected Sub chkNo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkNo.CheckedChanged
        Try
            If chkNo.Checked = True Then
                txtnumalt.Visible = False
                txtnumalt.Text = ""
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span>  " & ex.Message
        End Try
    End Sub
    'chk falla sgsc
    Protected Sub CHKSD_CheckedChanged(sender As Object, e As EventArgs) Handles CHKSD.CheckedChanged
        Try
            If CHKSD.Checked = True Then
                txt_SD.Enabled = True
                lbl_formato.Text = "CUN o MIN"
            Else
                txt_SD.Enabled = False
                txt_SD.Text = ""
                lbl_formato.Text = "Caso"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span>  " & ex.Message
        End Try
    End Sub

End Class