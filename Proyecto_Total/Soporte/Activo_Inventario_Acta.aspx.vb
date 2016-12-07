Public Class Activo_Inventario_Acta
    Inherits System.Web.UI.Page
    Public objeto As New clsInventario
    Dim dts As New DataSet
    Dim DBNull As IFormatProvider
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Acta de entrega-recepcion de los activos fijos"
                Lblfechareg.Text = DateTime.Now.ToLongDateString()
                cargardrl()
                Consulta_Codigo_Acta()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Sub cargardrl()
        With drlTrabajador
            .DataSource = objeto.consultarUsuario()
            .DataTextField = "nombreu"
            .DataValueField = "idusuario"
            .DataBind()
        End With
        With drlArea
            .DataSource = objeto.consulta_lista_area()
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
    End Sub
    Protected Sub drlTrabajador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlTrabajador.SelectedIndexChanged
        llenarcampos()
    End Sub
    Sub llenarcampos()
        objeto.subResponsable = drlTrabajador.SelectedValue
        objeto.consultarUsuario()
        LblCedula.Text = objeto._documento
        LblCodigo.Text = objeto.Cod_Agente
        Lblcargo.Text = objeto._cargo
        dtgactivos.DataSource = objeto.consultaAcTodo()
        dtgactivos.DataBind()
        If objeto.Cantidad = 0 Then
            limpiar()
        End If
        RecorreDatos()

    End Sub
    Public Sub RecorreDatos() ' Recorre el GridView  "dtgUpdate" y reliza la respectiva actualizacion 
        Try
            For Each row As GridViewRow In dtgactivos.Rows
                LblSerial.Text = row.Cells(0).Text
                [Lblnombre].Text = row.Cells(1).Text
                [Lbldescripcion].Text = row.Cells(2).Text
                [Lblsede].Text = row.Cells(3).Text
                enviardatos()
            Next
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Sub enviardatos()
        If LblSerial1.Text = "" Or LblSerial1.Text = Nothing Then
            ''Cargo Valor al label
            LblSerial1.Text = LblSerial.Text
            [Lblnombre1].Text = [Lblnombre].Text
            [Lbldescripcion1].Text = [Lbldescripcion].Text
            [Lblsede1].Text = [Lblsede].Text
            Exit Sub
        End If
        If (LblSerial2.Text = "" Or LblSerial2.Text = Nothing) Then
            LblSerial2.Text = LblSerial.Text
            [Lblnombre2].Text = [Lblnombre].Text
            [Lbldescripcion2].Text = [Lbldescripcion].Text
            [Lblsede2].Text = [Lblsede].Text
            Exit Sub
        End If
        If (LblSerial3.Text = "" Or LblSerial3.Text = Nothing) Then
            LblSerial3.Text = LblSerial.Text
            [Lblnombre3].Text = [Lblnombre].Text
            [Lbldescripcion3].Text = [Lbldescripcion].Text
            [Lblsede3].Text = [Lblsede].Text
            Exit Sub
        End If
        If (LblSerial4.Text = "" Or LblSerial4.Text = Nothing) Then
            LblSerial4.Text = LblSerial.Text
            [Lblnombre4].Text = [Lblnombre].Text
            [Lbldescripcion4].Text = [Lbldescripcion].Text
            [Lblsede4].Text = [Lblsede].Text
            Exit Sub
        End If
        If (LblSerial5.Text = "" Or LblSerial5.Text = Nothing) Then
            LblSerial5.Text = LblSerial.Text
            [Lblnombre5].Text = [Lblnombre].Text
            [Lbldescripcion5].Text = [Lbldescripcion].Text
            [Lblsede5].Text = [Lblsede].Text
            Exit Sub
        End If
        If (LblSerial6.Text = "" Or LblSerial6.Text = Nothing) Then
            LblSerial6.Text = LblSerial.Text
            [Lblnombre6].Text = [Lblnombre].Text
            [Lbldescripcion6].Text = [Lbldescripcion].Text
            [Lblsede6].Text = [Lblsede].Text
            Exit Sub
        End If
        If (LblSerial7.Text = "" Or LblSerial7.Text = Nothing) Then
            LblSerial7.Text = LblSerial.Text
            [Lblnombre7].Text = [Lblnombre].Text
            [Lbldescripcion7].Text = [Lbldescripcion].Text
            [Lblsede7].Text = [Lblsede].Text
            Exit Sub
        End If
        If (LblSerial8.Text = "" Or LblSerial8.Text = Nothing) Then
            LblSerial8.Text = LblSerial.Text
            [Lblnombre8].Text = [Lblnombre].Text
            [Lbldescripcion8].Text = [Lbldescripcion].Text
            [Lblsede8].Text = [Lblsede].Text
            Exit Sub
        End If
        If (LblSerial9.Text = "" Or LblSerial9.Text = Nothing) Then
            LblSerial9.Text = LblSerial.Text
            [Lblnombre9].Text = [Lblnombre].Text
            [Lbldescripcion9].Text = [Lbldescripcion].Text
            [Lblsede9].Text = [Lblsede].Text
            Exit Sub
        End If
        If (LblSerial10.Text = "" Or LblSerial10.Text = Nothing) Then
            LblSerial10.Text = LblSerial.Text
            [Lblnombre10].Text = [Lblnombre].Text
            [Lbldescripcion10].Text = [Lbldescripcion].Text
            [Lblsede10].Text = [Lblsede].Text
            Exit Sub
        End If
    End Sub
    Sub limpiar()
        LblSerial.Text = ""
        Lblsede.Text = ""
        Lbldescripcion.Text = ""
        Lblnombre.Text = ""
        '----------------------------------------
        LblSerial1.Text = ""
        Lblsede1.Text = ""
        Lbldescripcion1.Text = ""
        Lblnombre1.Text = ""
        '----------------------------------------
        LblSerial2.Text = ""
        Lblsede2.Text = ""
        Lbldescripcion2.Text = ""
        Lblnombre2.Text = ""
        '----------------------------------------
        LblSerial3.Text = ""
        Lblsede3.Text = ""
        Lbldescripcion3.Text = ""
        Lblnombre3.Text = ""
        '----------------------------------------
        LblSerial4.Text = ""
        Lblsede4.Text = ""
        Lbldescripcion4.Text = ""
        Lblnombre4.Text = ""
        '----------------------------------------
        LblSerial5.Text = ""
        Lblsede5.Text = ""
        Lbldescripcion5.Text = ""
        Lblnombre5.Text = ""
        '----------------------------------------
        LblSerial6.Text = ""
        Lblsede6.Text = ""
        Lbldescripcion6.Text = ""
        Lblnombre6.Text = ""

        '----------------------------------------
        LblSerial7.Text = ""
        Lblsede7.Text = ""
        Lbldescripcion7.Text = ""
        Lblnombre7.Text = ""
        '----------------------------------------
        LblSerial8.Text = ""
        Lblsede8.Text = ""
        Lbldescripcion8.Text = ""
        Lblnombre8.Text = ""
        '----------------------------------------
        LblSerial9.Text = ""
        Lblsede9.Text = ""
        Lbldescripcion9.Text = ""
        Lblnombre9.Text = ""
        '----------------------------------------
        LblSerial10.Text = ""
        Lblsede10.Text = ""
        Lbldescripcion10.Text = ""
        Lblnombre10.Text = ""
        '_-----------------------------------------
        txtMotivo1.Text = ""
        txtMotivo2.Text = ""
        txtMotivo3.Text = ""
        txtMotivo4.Text = ""
        txtMotivo5.Text = ""
        txtMotivo6.Text = ""
        txtMotivo7.Text = ""
        txtMotivo8.Text = ""
        txtMotivo9.Text = ""
        txtMotivo10.Text = ""
    End Sub
    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If drlTrabajador.SelectedItem.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Empleado "
                Exit Sub
            End If
            If txtfcreg.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione una fecha de asignacion "
                Exit Sub
            End If
            If drlArea.SelectedItem.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione un Area "
                Exit Sub
            End If
            objeto.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            objeto.subResponsable = drlTrabajador.SelectedValue
            objeto.Cod_Agente = LblCodigo.Text
            objeto._documento = LblCedula.Text
            objeto._cargo = Lblcargo.Text
            objeto.fc_mto = txtfcreg.Text
            objeto._area = drlArea.SelectedItem.Text
            objeto.RegistrarActa()
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro Exitoso"
            If objeto.Validacion = 1 Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se realizo el registro"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Public Sub Consulta_Codigo_Acta()
        Try
            dts = objeto.Consulta_Cod
            Lblcodacta.Text = Convert.ToString(dts.Tables(0).Rows(0).Item("Cod_Activo_Inventario_Acta"))
            If Lblcodacta.Text = "" Or Lblcodacta.Text = Nothing Then
                Lblcodacta.Text = "1"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Pnl_Message.CssClass = Nothing
        lblmsg.Text = Nothing
        Try
            paneltitulo.Visible = False
            Panelconsulta.Visible = False
            LblfcAsig.Text = txtfcreg.Text
            txtfcreg.Visible = False

            LblArea.Text = drlArea.Text
            drlArea.Visible = False
            LblTrabaj.Text = drlTrabajador.SelectedItem.Text
            drlTrabajador.Visible = False

            LblMotivo1.Text = txtMotivo1.Text
            LblMotivo2.Text = txtMotivo2.Text
            LblMotivo3.Text = txtMotivo3.Text
            LblMotivo4.Text = txtMotivo4.Text
            LblMotivo5.Text = txtMotivo5.Text
            LblMotivo6.Text = txtMotivo6.Text
            LblMotivo7.Text = txtMotivo7.Text
            LblMotivo8.Text = txtMotivo8.Text
            LblMotivo9.Text = txtMotivo9.Text
            LblMotivo10.Text = txtMotivo10.Text
            txtMotivo1.Visible = False
            txtMotivo2.Visible = False
            txtMotivo3.Visible = False
            txtMotivo4.Visible = False
            txtMotivo5.Visible = False
            txtMotivo6.Visible = False
            txtMotivo7.Visible = False
            txtMotivo8.Visible = False
            txtMotivo9.Visible = False
            txtMotivo10.Visible = False
            PanelIMP.Visible = True
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            limpiar_cajas()
            limpiar()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Sub limpiar_cajas()
        LblCedula.Text = ""
        Lblcargo.Text = ""
        LblCodigo.Text = ""
        txtfcreg.Text = ""
        drlArea.SelectedIndex = 0
        drlTrabajador.SelectedIndex = 0
    End Sub
    Protected Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            If RdbCosusu.Checked = False And RdbCodActa.Checked = False Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Especifique un criterio de busqueda"
                Exit Sub
            End If
            If RdbCosusu.Checked = True And txtCodusu.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Especifique un codigo de usuario"
                Exit Sub
            End If
            If RdbCodActa.Checked = True And TxtcodActa.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Especifique un codigo de acta"
                Exit Sub
            End If
            If RdbCosusu.Checked = True And txtCodusu.Text <> Nothing Then
                objeto.Cod_Agente = txtCodusu.Text
                objeto.ConsultarActa()
            End If
            If RdbCodActa.Checked = True And TxtcodActa.Text <> Nothing Then
                objeto.cod_Acta = TxtcodActa.Text
                objeto.ConsultarActa()
            End If
            If objeto.Validacion = "1" Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron Registros"
                Exit Sub
            End If
            drlTrabajador.SelectedValue = objeto.subResponsable
            Dim fecha As String = Mid(objeto.fc_mto, 1, 10)
            txtfcreg.Text = fecha
            Lblcodacta.Text = objeto.cod_Acta
            drlArea.SelectedValue = objeto._area
            limpiar()
            llenarcampos()
            If objeto.Validacion = 1 Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros con el criterio de busqueda especificado"
                Exit Sub
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class