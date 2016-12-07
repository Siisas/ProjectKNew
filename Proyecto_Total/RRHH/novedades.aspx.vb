Imports System.IO

Public Class novedades
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Session("Formulario") = "Novedades de nómina"
                objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                objdatos.consultared()
                lblred.Text = objdatos.cargo
                Session("Cod") = CType(Session("permisos"), clsusuario).usuario
                If lblred.Text = "2" Then
                    btnactualiza.Enabled = True
                Else
                    btnactualiza.Enabled = False
                End If
                cargadrl()
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
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message

        End Try
    End Sub
    Protected Sub cargadrl()
        Dim objdatos As New clsgeneral
        With drltiponov
            .DataSource = objdatos.consultatipoact
            .DataTextField = "descripcioninasistencia"
            .DataValueField = "idinasistencia"
            .DataBind()
        End With
        objdatos.tipo = drltiponov.SelectedValue
        With drltipificacion
            .DataSource = objdatos.consultatiponoved
            .DataTextField = "desctipo"
            .DataValueField = "idtipo"
            .DataBind()
        End With
    End Sub
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clsrrhh
        Try
            If lblnombre.Text = "" Or txtcod.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el documento del empleado que desea consultar"
            Else
                objdatos.codigo = txtcod.Text
                If txtfcnov.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite la fecha en que se produce la novedad"
                    Exit Sub
                Else
                    objdatos.fcnovedad = txtfcnov.Text
                End If
                If drltiponov.SelectedItem.Value = 0 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija el tipo de novedad que se reporta"
                    Exit Sub
                Else
                    objdatos.tiponov = drltiponov.SelectedItem.Value
                End If
                If drltiponov.SelectedItem.Text = "Retiro" Then
                    objdatos.documento = LblDocumento.Text
                End If
                If txtdia.Text = "" And txthora.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite los días o las horas que se reporta en la novedad"
                    Exit Sub
                Else
                    If txtdia.Text = "" Then
                        objdatos.dianov = 0
                    Else
                        objdatos.dianov = txtdia.Text
                    End If
                    If txthora.Text = "" Then
                        objdatos.horanov = 0
                    Else
                        objdatos.horanov = txthora.Text
                    End If
                End If
                If txtestado.Text = "" Then
                    objdatos.estado = ""
                Else
                    objdatos.estado = txtestado.Text
                End If
                If rdbrepone.SelectedValue = Nothing Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija la opción si la novedad requiere reposición o no"

                    Exit Sub
                Else
                    objdatos.repone = rdbrepone.SelectedItem.Value
                End If
                If rdbreporta.SelectedValue = Nothing Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija la opción si la novedad se reporta a nómina o no"
                    Exit Sub
                Else
                    objdatos.reporta = rdbreporta.SelectedItem.Value
                End If
                If drltipificacion.SelectedItem.Text = "- Seleccione -" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<strong><span Class='glyphicon glyphicon-warning-sign'></span></strong> Elija la tipificación de la novedad que se reporta"
                    Exit Sub
                Else
                    objdatos.tipificacion = drltipificacion.SelectedItem.Value
                End If

                If txtobs.Text = "" Then
                    objdatos.obs = ""
                Else
                    objdatos.obs = txtobs.Text
                End If
                If drltiponov.SelectedItem.Text = "Incapacidad" Then
                    If TxtCodigoMedicina.Text = "" Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el codigo de la Constancia medica"
                        Exit Sub
                    Else
                        If LblDiagnostico.Text <> "Registro Valido" Then
                            Pnl_Message.CssClass = "alert alert-warning"
                            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Consulte el codigo para verificar que si exista el registro"
                            Exit Sub
                        Else
                            objdatos.Cod_Diagnostico = TxtCodigoMedicina.Text
                        End If
                    End If
                Else
                    objdatos.Cod_Diagnostico = ""
                End If
                If drltiponov.SelectedItem.Text = "Retiro" Then
                    objdatos.Validacion = "Retiro"
                    objdatos.Usu_CRM = drltipificacion.SelectedItem.Text
                End If

                objdatos.idusuario = Session("Cod")
                objdatos.registronov()
                buscarinf()
                limpiar()
                cargadrl()
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Novedad ingresada con éxito"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Sub limpiar()
        txtfcnov.Enabled = True
        drltiponov.Enabled = True
        txtdia.Enabled = True
        txthora.Enabled = True
        rdbrepone.Enabled = True
        txtid.Text = ""
        txtcod.Text = ""
        TxtCodigoMedicina.Text = ""
        LblDiagnostico.Text = ""
        txtfcnov.Text = ""
        txtdia.Text = ""
        txthora.Text = ""
        txtestado.Text = ""
        rdbrepone.SelectedValue = Nothing
        rdbreporta.SelectedValue = Nothing
        cargadrl()
        lblnombre.Text = ""
        txtobs.Text = ""
        BtnCancelar.Visible = False
        btnactualiza.Visible = False
        btnguardar.Visible = True
        panel2.Visible = False
    End Sub

    Sub buscarinf()
        Dim objdatos As New clsrrhh
        If txtcod.Text <> "" Then
            objdatos.codigo = txtcod.Text
            If txtid.Text <> "" Then
                objdatos.id = txtid.Text
            End If
            panel1.Visible = True
            panel2.Visible = False
            dtggeneral.DataSource = objdatos.consultanovedad
            dtggeneral.DataBind()
            Lblcuenta.Text = objdatos.cantidad
            If objdatos.cantidad > 0 And txtid.Text <> "" Then
                txtfcnov.Text = objdatos.fcnovedad
                drltiponov.SelectedValue = objdatos.tiponov
                Dim objtmp As New clsgeneral
                objtmp.tipo = drltiponov.SelectedValue
                With drltipificacion
                    .DataSource = objtmp.consultatiponoved
                    .DataTextField = "desctipo"
                    .DataValueField = "idtipo"
                    .DataBind()
                End With
                TxtCodigoMedicina.Text = objdatos.Cod_Diagnostico
                drltipificacion.SelectedValue = objdatos.tipificacion
                txtdia.Text = objdatos.dianov
                txthora.Text = objdatos.horanov
                txtestado.Text = objdatos.estado
                txtobs.Text = objdatos.obs
                If objdatos.repone = "0" Then
                    rdbrepone.SelectedValue = Nothing
                Else
                    rdbrepone.SelectedValue = objdatos.repone
                End If
                If objdatos.reporta = "0" Then
                    rdbreporta.SelectedValue = Nothing
                Else
                    rdbreporta.SelectedValue = objdatos.reporta
                End If
                lblmes.Text = objdatos.mesreporte
            Else
                txtfcnov.Text = ""
                txtdia.Text = ""
                txthora.Text = ""
                txtestado.Text = ""
                rdbrepone.SelectedValue = Nothing
                rdbreporta.SelectedValue = Nothing
                cargadrl()
                txtobs.Text = ""
                lblmes.Text = ""
            End If

        End If
        Pnl_Message.CssClass = Nothing
        lblmsg.Text = ""
    End Sub

    Protected Sub btnvalidar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnvalidar.Click
        Try
            Dim objdatos As New clsrrhh
            If txtcod.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el código de usuario al que desea registrar la novedad"
            Else
                objdatos.idusuario = txtcod.Text
                objdatos.consultanombre()
                If objdatos.cantidad > 0 Then
                    lblnombre.Text = objdatos.nombres & " " & objdatos.apellidos
                    LblDocumento.Text = objdatos.documento
                    buscarinf()
                    If txtcod.Text <> "" And txtid.Text <> "" Then
                        btnactualiza.Visible = True
                        BtnCancelar.Visible = True
                        btnguardar.Visible = False
                    Else
                        btnactualiza.Visible = False
                        BtnCancelar.Visible = False
                        btnguardar.Visible = True
                    End If

                Else
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> El código no se encuentran creado en la base de datos, revise la información"
                    lblnombre.Text = ""
                    panel1.Visible = False
                    dtggeneral.DataSource = Nothing
                    dtggeneral.DataBind()
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

   Protected Sub btnactualiza_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnactualiza.Click
        Dim objdatos As New clsrrhh
        Try
            If lblnombre.Text = "" Or txtid.Text = "" Or txtfcnov.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el código del empleado que desea consultar junto con el ID del registro que desea modificar"

            Else
                If lblmes.Text <> " " And lblmes.Text <> "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> La novedad ya fue reportada a nómina, no es posible realizar ninguna modificación"
                    Exit Sub
                End If
                objdatos.id = txtid.Text
                If txtestado.Text = "" Then
                    objdatos.estado = ""
                Else
                    objdatos.estado = txtestado.Text
                End If
                If rdbreporta.SelectedValue = Nothing Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija la opción si la novedad se reporta a nómina o no"
                    Exit Sub
                Else
                    objdatos.reporta = rdbreporta.SelectedItem.Value
                End If
                objdatos.tipificacion = drltipificacion.SelectedItem.Value
                If txtobs.Text = "" Then
                    objdatos.obs = ""
                Else
                    objdatos.obs = txtobs.Text
                End If
                'nuevos
                If txtfcnov.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-danger"
                    lblmsg.Text = "<strong><span Class='glyphicon glyphicon-warning-sign'></span></strong> Digite la fecha en que se produce la novedad"
                    Exit Sub
                Else
                    objdatos.fcnovedad = txtfcnov.Text
                End If
                If drltiponov.SelectedItem.Value = 0 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija el tipo de novedad que se reporta"
                    Exit Sub
                Else
                    objdatos.tiponov = drltiponov.SelectedItem.Value
                End If
                If txtdia.Text = "" And txthora.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite los días o las horas que se reporta en la novedad"
                    Exit Sub
                Else
                    If txtdia.Text = "" Then
                        objdatos.dianov = 0
                    Else
                        objdatos.dianov = txtdia.Text
                    End If
                    If txthora.Text = "" Then
                        objdatos.horanov = 0
                    Else
                        objdatos.horanov = txthora.Text
                    End If
                End If
                If rdbrepone.SelectedValue = Nothing Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija la opción si la novedad requiere reposición o no"
                    Exit Sub
                Else
                    objdatos.repone = rdbrepone.SelectedItem.Value
                End If
                If drltipificacion.SelectedValue = 9 Then
                    If TxtCodigoMedicina.Text = "" Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el codigo de la Constancia medica"
                        LblDiagnostico.Text = ""
                        Exit Sub
                    Else
                        If LblDiagnostico.Text <> "Registro Valido" Then
                            Pnl_Message.CssClass = "alert alert-warning"
                            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Consulte el codigo para verificar que si exista el registro"
                            Exit Sub
                        Else
                            objdatos.Cod_Diagnostico = TxtCodigoMedicina.Text
                        End If
                    End If
                Else
                    objdatos.Cod_Diagnostico = ""
                End If

                objdatos.idusuario = Session("Cod")
                objdatos.Validacion = "verificar"
                objdatos.he = "verificar"
                objdatos.consultanovedad()
                If objdatos.cantidad = 0 Then
                    objdatos.id = txtid.Text
                    objdatos.codigo = txtcod.Text
                    objdatos.RegistroActualizacion()
                End If
                objdatos.Validacion = Nothing
                objdatos.modificanov()
                objdatos.id = txtid.Text
                objdatos.codigo = txtcod.Text
                objdatos.RegistroActualizacion()
                buscarinf()
                limpiar()

                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span>  Novedad modificada con éxito"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message

        End Try
    End Sub


    Protected Sub drltiponov_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drltiponov.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            objdatos.tipo = drltiponov.SelectedValue
            With drltipificacion
                .DataSource = objdatos.consultatiponoved
                .DataTextField = "desctipo"
                .DataValueField = "idtipo"
                .DataBind()
            End With
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message

        End Try
    End Sub

    Protected Sub BtnConsultaCodMedico_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultaCodMedico.Click
        Try
            If TxtCodigoMedicina.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el codigo que desea consultar"
                LblDiagnostico.Text = ""
                Exit Sub
            Else
                Dim objdatos As New clsgeneral

                objdatos.Cod_Diagnostico = TxtCodigoMedicina.Text
                objdatos.Consulta_Diagnostico()
                If objdatos.cantreg > 0 Then
                    LblDiagnostico.Text = "Registro Valido"
                Else
                    LblDiagnostico.Text = "No se encuentra registro"
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message

        End Try

    End Sub

    Protected Sub btnregistroM_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnregistroM.Click
        Dim objdatos As New clsrrhh
        Try
            If Path.GetExtension(FileUpload1.FileName).ToLower() = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>  Seleccione un archivo del equipo"
                Exit Sub
            End If
            If Path.GetExtension(FileUpload1.FileName).ToLower() <> ".xlsx" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>  El formato no es correcto"
                Exit Sub
            End If
            FileUpload1.SaveAs(Server.MapPath("~/Usuarios/" & Path.GetFileName(FileUpload1.FileName)))
            Server.MapPath("~/Usuarios/" & Path.GetFileName(FileUpload1.FileName))
            objdatos.Fc_ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("~/Usuarios/" & Path.GetFileName(FileUpload1.FileName)) & ";Extended Properties=Excel 12.0;"
            objdatos.idusuario = Session("Cod")
            objdatos.Validacion = 2
            objdatos.ExcelNovedades()
            If objdatos.Validacion <> 4 Then
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span>  Se realizaron  " & objdatos.cantidad & " registros efectivos "
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<strong><span Class='glyphicon glyphicon-warning-sign'></span></strong> Se precento error"
            End If
        Catch ex As Exception
            objdatos.Validacion = 4
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> ERROR:" & ex.Message
            lblmsg.Text = "ERROR:" & ex.Message
        End Try
    End Sub

    Protected Sub BtnCancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCancelar.Click
        limpiar()
        panel1.Visible = False
    End Sub


    Protected Sub Btn_Historial_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Historial.Click
        Dim objdatos As New clsrrhh
        objdatos.he = Nothing
        If txt_HistorialNov.Text <> Nothing Or txtcod.Text <> Nothing Then
            objdatos.he = "Buscar"
            objdatos.id = txt_HistorialNov.Text
            Session("historial") = objdatos.consultanovedad()
            If objdatos.cantidad > 0 Then
                panel2.Visible = True
                panel1.Visible = False
                dtgHistorial.DataSource = Session("historial")
                dtgHistorial.DataBind()
                Lbl_CantidadHis.Text = objdatos.cantidad
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span>  Busqueda Exitosa"
                objdatos.he = Nothing
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>  No se encontraron Actualizaciones de esa Novedad"
                objdatos.he = Nothing
            End If
        Else
            Pnl_Message.CssClass = "alert alert-warning"
            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>  Asegurese de ingresar el codigo de usuario"
        End If
    End Sub

End Class