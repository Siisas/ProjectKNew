Public Class Liberarasiggestion
    Inherits System.Web.UI.Page
    Dim perfil As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Liberacion General de Casos"
                Cargar_DRL()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub Cargar_DRL()
        Dim objdatos As New clsgeneral
        Dim objdatosban As New clscrmdatos
        With drlusuario
            .DataSource = objdatos.consultaagentegrupo
            .DataTextField = "nombreu"
            .DataValueField = "idusuario"
            .DataBind()
        End With
        With drlEstado
            .DataSource = objdatosban.Consulta_drlestado
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        objdatosban.Validacion = "Masiva"
        With drlestadomas
            .DataSource = objdatosban.Consulta_drlestado
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
            .Items.Insert(8, "Todos los anteriores")
        End With
    End Sub
    Protected Sub btnLiberaMasiva_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLiberaMasiva.Click
        Try
            Dim actualizar As New clscrmdatos
            If lblcantidad.Text = "" Or dtggeneral.Rows.Count = 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Antes de realizar una liberacion consulte los casos, ya que se liberaran los que se visualizan"
                Exit Sub
            End If
            If btnLiberaMasiva.Text = "Aceptar" Then
                actualizar.Validacion = "Masiva"
                '---Liberacion---'
                Liberar()
                btnCancelar.Visible = False
                btnLiberaMasiva.Text = "Liberacion Masiva"
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Liberacion masiva ejecutada correctamente"
            Else
                btnLiberaMasiva.Text = "Aceptar"
                btnCancelar.Visible = True
                actualizar.Validacion = "Casos"

                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Esta seguro que va a realizar una liberacion masiva"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub btnCancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelar.Click
        Try
            If btnLiberaMasiva.Text = "Aceptar" Then
                btnLiberaMasiva.Text = "Liberacion Masiva"
                btnCancelar.Visible = False
                lblmsg.Text = Nothing
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            busca()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub busca()
        Try
            Dim objdatos As New clscrmdatos

            If drlusuario.SelectedItem.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione a un usuario antes de realizar la consulta"
                dtggeneral.DataSource = Nothing
                dtggeneral.DataBind()
                lblcantidad.Text = ""
                Exit Sub
            End If
            '---Ingeniero---'
            If drlusuario.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.idusuario = drlusuario.SelectedItem.Value
            End If
            '---Caso---'
            If txtcaso.Text <> "" Then
                objdatos.caso = txtcaso.Text
                '---DATOS---'
                If lblcampaña.Text.Contains("DATOS") Then
                    objdatos.Bandeja = "DATOS"
                    '---DILO---'
                ElseIf lblcampaña.Text.Contains("DILO") Then
                    objdatos.Bandeja = "DILO"
                    '---DESACTIVACION---'
                ElseIf lblcampaña.Text.Contains("DESACTIVACION") Then
                    objdatos.Bandeja = "DESACTIVACION"
                    '---BSCS---'
                ElseIf lblcampaña.Text.Contains("BSCS") Then
                    objdatos.Bandeja = "BSCS"
                    '---INBOUND---'
                ElseIf lblcampaña.Text.Contains("INBOUND") Then
                    objdatos.Bandeja = "INBOUND"
                End If

                dtggeneral.DataSource = objdatos.consultaasignadogestion
                dtggeneral.DataBind()
                lblcantidad.Text = objdatos.cantidad
                If lblcantidad.Text = 0 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros"
                    dtggeneral.DataSource = Nothing
                    dtggeneral.DataBind()
                    Panel_Tabla.Visible = False
                Else
                    Panel_Tabla.Visible = True
                End If
                Exit Sub
            End If
            '---Estado---'
            If drlEstado.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.estadoinc = drlEstado.SelectedItem.Text
            End If
            '---Cantidad casos---'
            If txtcantidadcaso.Text <> "" Then
                objdatos.cantidad = txtcantidadcaso.Text
            End If

            '---DATOS---'
            If lblcampaña.Text.Contains("DATOS") Then
                objdatos.Bandeja = "DATOS"
                '--- Campaña
                If drl_campaña_indivi.SelectedItem.Text <> "- Seleccione -" Then
                    objdatos.CampanaLogin = drl_campaña_indivi.SelectedItem.Text
                End If
                '--- Marcacion
                If Drl_Marcacion_individual.SelectedItem.Text <> "- Seleccione -" Then
                    objdatos.marca = Drl_Marcacion_individual.SelectedItem.Text
                End If
                '---DILO---'
            ElseIf lblcampaña.Text.Contains("DILO") Then
                objdatos.Bandeja = "DILO"
                '---DESACTIVACION---'
            ElseIf lblcampaña.Text.Contains("DESACTIVACION") Then
                objdatos.Bandeja = "DESACTIVACION"
                '---BSCS---'
            ElseIf lblcampaña.Text.Contains("BSCS") Then
                objdatos.Bandeja = "BSCS"
                '--- Marcacion
                If Drl_Marcacion_individual.SelectedItem.Text <> "- Seleccione -" Then
                    objdatos.marca = Drl_Marcacion_individual.SelectedItem.Text
                End If
                '---INBOUND---'
            ElseIf lblcampaña.Text.Contains("INBOUND") Then
                objdatos.Bandeja = "INBOUND"
            End If
            dtggeneral.DataSource = objdatos.consultaasignadogestion
            dtggeneral.DataBind()
            lblcantidad.Text = objdatos.cantidad
            If lblcantidad.Text = 0 Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros"
                Panel_Tabla.Visible = False
                Exit Sub
            Else
                Panel_Tabla.Visible = True
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            busca()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub btnbuscarmas_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnbuscarmas.Click
        Try
            Dim objdatos As New clscrmdatos
            If drlestadomas.SelectedItem.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Seleccione un estado para realizar liberacion masiva"
                limpiar()
                Exit Sub
            End If
            objdatos.Validacion = "Masiva"
            objdatos.estadoinc = drlestadomas.SelectedItem.Text


            '---DATOS---'
            If lblcampaña.Text.Contains("DATOS") Then
                objdatos.Bandeja = "DATOS"
                '--- CAMPAÑA
                If drl_Campaña.SelectedItem.Text <> "- Seleccione -" Then
                    objdatos.CampanaLogin = drl_Campaña.SelectedItem.Text
                End If
                '--- MARCACION
                If drl_Marcacion.SelectedItem.Text <> "- Seleccione -" Then
                    objdatos.marca = drl_Marcacion.SelectedItem.Text
                End If
                '---DILO---'
            ElseIf lblcampaña.Text.Contains("DILO") Then
                objdatos.Bandeja = "DILO"
                '---DESACTIVACION---'
            ElseIf lblcampaña.Text.Contains("DESACTIVACION") Then
                objdatos.Bandeja = "DESACTIVACION"
                '---BSCS---'
            ElseIf lblcampaña.Text.Contains("BSCS") Then
                objdatos.Bandeja = "BSCS"
                '--- MARCACION
                If drl_Marcacion.SelectedItem.Text <> "- Seleccione -" Then
                    objdatos.marca = drl_Marcacion.SelectedItem.Text
                End If
                '---INBOUND---'
            ElseIf lblcampaña.Text.Contains("INBOUND") Then
                objdatos.Bandeja = "INBOUND"
            End If

            dtggeneral.DataSource = objdatos.consultaasignadogestion
            dtggeneral.DataBind()
            lblcantidad.Text = objdatos.cantidad
            If lblcantidad.Text = 0 Then
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros"
                Panel_Tabla.Visible = False
                Exit Sub
            Else
                Panel_Tabla.Visible = True
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Busqueda Exitosa"
            End If

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Panel_Datos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Panel_Datos.Click
        Try
            Cargar_DRL()
            drl_Campaña.Enabled = True
            drl_campaña_indivi.Enabled = True
            drl_Marcacion.Enabled = True
            Drl_Marcacion_individual.Enabled = True

            drl_Campaña.SelectedIndex = 0
            drl_campaña_indivi.SelectedIndex = 0
            drl_Marcacion.SelectedIndex = 0
            Drl_Marcacion_individual.SelectedIndex = 0
            lblcampaña.Text = "FILTROS PARA LIBERACION - DATOS"
            limpiar()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Panel_BSCS_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Panel_BSCS.Click
        Try
            Cargar_DRL()
            drl_Campaña.Enabled = False
            drl_campaña_indivi.Enabled = False
            drl_Marcacion.Enabled = True
            Drl_Marcacion_individual.Enabled = True

            drl_Campaña.SelectedIndex = 0
            drl_campaña_indivi.SelectedIndex = 0
            drl_Marcacion.SelectedIndex = 0
            Drl_Marcacion_individual.SelectedIndex = 0

            lblcampaña.Text = "FILTROS PARA LIBERACION - BSCS"
            limpiar()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Panel_Inbound_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Panel_Inbound.Click
        Try
            drl_Campaña.Enabled = False
            drl_campaña_indivi.Enabled = False
            drl_Marcacion.Enabled = False
            Drl_Marcacion_individual.Enabled = False
            drlEstado.Items.Remove("Auto-Asignacion")
            drlestadomas.Items.Remove("Auto-Asignacion")
            drl_Campaña.SelectedIndex = 0
            drl_campaña_indivi.SelectedIndex = 0
            drl_Marcacion.SelectedIndex = 0
            Drl_Marcacion_individual.SelectedIndex = 0

            lblcampaña.Text = "FILTROS PARA LIBERACION - INBOUND"
            limpiar()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Panel_Dilo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Panel_Dilo.Click
        Try
            Cargar_DRL()
            drl_Campaña.Enabled = False
            drl_campaña_indivi.Enabled = False
            drl_Marcacion.Enabled = False
            Drl_Marcacion_individual.Enabled = False

            drl_Campaña.SelectedIndex = 0
            drl_campaña_indivi.SelectedIndex = 0
            drl_Marcacion.SelectedIndex = 0
            Drl_Marcacion_individual.SelectedIndex = 0

            lblcampaña.Text = "FILTROS PARA LIBERACION - DILO"
            limpiar()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Panel_Desact_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Panel_Desact.Click
        Try
            Cargar_DRL()
            drl_Campaña.Enabled = False
            drl_campaña_indivi.Enabled = False
            drl_Marcacion.Enabled = False
            Drl_Marcacion_individual.Enabled = False

            drl_Campaña.SelectedIndex = 0
            drl_campaña_indivi.SelectedIndex = 0
            drl_Marcacion.SelectedIndex = 0
            Drl_Marcacion_individual.SelectedIndex = 0
            lblcampaña.Text = "FILTROS PARA LIBERACION - DESACTIVACION"
            limpiar()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " & ex.Message
        End Try
    End Sub
    Public Sub limpiar()
        Try
            dtggeneral.DataSource = Nothing
            dtggeneral.DataBind()
            drlestadomas.SelectedIndex = 0
            drlEstado.SelectedIndex = 0
            drlusuario.SelectedIndex = 0
            txtcantidadcaso.Text = ""
            txtcaso.Text = ""
            lblcantidad.Text = ""
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " & ex.Message
        End Try

    End Sub
    Public Sub Liberar()
        Try
            Dim actualizar As New clscrmdatos
            '---DATOS---'
            If lblcampaña.Text.Contains("DATOS") Then
                actualizar.Bandeja = "DATOS"
                '---DILO---'
            ElseIf lblcampaña.Text.Contains("DILO") Then
                actualizar.Bandeja = "DILO"
                '---DESACTIVACION---'
            ElseIf lblcampaña.Text.Contains("DESACTIVACION") Then
                actualizar.Bandeja = "DESACTIVACION"
                '---BSCS---'
            ElseIf lblcampaña.Text.Contains("BSCS") Then
                actualizar.Bandeja = "BSCS"
                '---INBOUND---'
            ElseIf lblcampaña.Text.Contains("INBOUND") Then
                actualizar.Bandeja = "INBOUND"
            End If
            For Each row As GridViewRow In dtggeneral.Rows
                actualizar.caso = Int64.Parse(row.Cells(0).Text)
                actualizar.liberaasiggestion()
            Next

            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Liberación realizada con éxito"
            '---Limpiar herramientas---'
            limpiar()

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se produjo error " & ex.Message
        End Try
    End Sub
End Class