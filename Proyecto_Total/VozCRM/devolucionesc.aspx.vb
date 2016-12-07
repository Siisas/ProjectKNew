Imports System.IO
Public Class devolucionesc
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Devolución y Corrección de Escalamiento Voz y Datos"
                casosptes()
                Cargar_DRLS()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Public Sub Cargar_DRLS()
        Dim objdatos As New clsgeneral
        With drlmarca
            objdatos.idtip = 1
            .DataSource = objdatos.consultamarca
            .DataTextField = "marca"
            .DataValueField = "marca"
            .DataBind()
        End With
        With drlequipo
            .DataSource = objdatos.consultaequipo
            .DataTextField = "equipo"
            .DataValueField = "equipo"
            .DataBind()
        End With
        'divipola - dpto
        With drldpto
            objdatos.idtip = 1
            .DataSource = objdatos.consultadpto
            .DataTextField = "nombredpto"
            .DataValueField = "coddpto"
            .DataBind()
        End With
        With drlmun
            .DataSource = objdatos.consultamun
            .DataTextField = "nombremun"
            .DataValueField = "coddiv"
            .DataBind()
        End With
    End Sub
    Protected Sub casosptes()
        Try
            Dim objdatos As New clsvoz
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            Session("dtggeneral") = objdatos.consultadevueltos
            dtggeneral.DataSource = Session("dtggeneral")
            dtggeneral.DataBind()
            lblcuenta.Text = "Casos escalados devueltos: " & objdatos.cantidad
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            Dim objdatos As New clsvoz
            If txtcaso.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el caso que desea consultar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
                objdatos.consultacamapana()
                If objdatos.cantidad = 0 Then
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No existen registros coincidentes para ese caso, revise la información"
                    Exit Sub
                Else
                    lblcampana.Text = objdatos.campana
                    buscarinf()
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub drlmarca_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlmarca.SelectedIndexChanged
        Try
            equipo1()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub drldpto_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drldpto.SelectedIndexChanged
        Try
            dpto1()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
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
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub equipo1()
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
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub habilitaestado()
        Dim objdatos As New clsvoz
        Try
            objdatos.caso = txtcaso.Text
            If lblcampana.Text = "Datos" Then
                objdatos.actualizaestadocpdbandejadatos()
            Else
                objdatos.actualizaestadocpdbandeja()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub btnguardar0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar0.Click
        Try
            Dim objdatos As New clsvoz
            objdatos.caso = txtcaso.Text
            If chkanula.Checked = True Then
                habilitaestado()
                objdatos.areafalla = 1
                objdatos.cpd = "0"
                objdatos.devolver = "0"
                objdatos.obs = ""
                objdatos.actualizacpd()
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Falla de red anulada con éxito"
            Else
                If txtFcontacto.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite la persona de contacto"
                    Exit Sub
                Else
                    objdatos.cliente = txtFcontacto.Text
                End If
                If txtFnum.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el número de contacto"
                    Exit Sub
                Else
                    objdatos.telcontacto = txtFnum.Text
                End If
                If drlFtiempo.SelectedItem.Value = "0" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija el tiempo que lleva presentándose la falla"
                    Exit Sub
                Else
                    objdatos.tiempo = drlFtiempo.SelectedItem.Value
                End If
                If txtFtipofalla.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Describa el tipo de falla que se presenta"
                    Exit Sub
                Else
                    objdatos.tipofalla = txtFtipofalla.Text
                End If
                If drlFcaract.SelectedItem.Value = "0" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Describa las características del tipo de falla"
                    Exit Sub
                Else
                    objdatos.caracter = drlFcaract.SelectedItem.Text
                End If
                If drlFportada.SelectedItem.Value = "0" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija si la línea es portada o no"
                    Exit Sub
                Else
                    objdatos.portada = drlFportada.SelectedItem.Value
                End If
                If drlmun.SelectedItem.Value = 0 Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija el Departamento y Municipio de la falla"
                    Exit Sub
                Else
                    objdatos.mun = drlmun.SelectedItem.Value
                End If
                If txtFciudad.Text = "" Then
                    objdatos.vereda = ""
                Else
                    If rdbvc.SelectedValue = Nothing And txtFciudad.Text <> Nothing Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija si el lugar corresponde a un corregimiento, Vereda o Inspección"
                        Exit Sub
                    Else
                        objdatos.vereda = rdbvc.SelectedItem.Value & " " & txtFciudad.Text
                    End If
                End If
                If txtFdirecc.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite la dirección donde se presenta la falla"
                    Exit Sub
                Else
                    objdatos.dir = txtFdirecc.Text
                End If
                If txtbarrio.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija el barrio donde se presenta la falla"
                    Exit Sub
                Else
                    objdatos.barrio = txtbarrio.Text
                End If
                If drlFtectolog.SelectedItem.Value = "0" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija la tecnología del equipo que presenta la falla"
                    Exit Sub
                Else
                    objdatos.tecnologia = drlFtectolog.SelectedItem.Value
                End If
                If drlequipo.SelectedItem.Text = "- Seleccione -" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija el equipo correspondiente"
                    Exit Sub
                Else
                    objdatos.equipo = drlequipo.SelectedItem.Value
                End If
                If drlFlineasfalla.SelectedItem.Value = "0" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija si se reportan más líneas con falla en la ubicación reportada"
                    Exit Sub
                Else
                    objdatos.maslineas = drlFlineasfalla.SelectedItem.Value
                End If
                If txtfobs.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite las observaciones reportadas por el usuario"
                    Exit Sub
                Else
                    objdatos.obs = txtfobs.Text
                End If
                If txtapn.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el APN"
                    Exit Sub
                Else
                    objdatos.apn = txtapn.Text
                End If
                If txtqos.Text = "" Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el QoS"
                    Exit Sub
                Else
                    objdatos.qos = txtqos.Text
                End If
                objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                objdatos.modificafallasred()
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Falla de red modificada con éxito"
            End If
            guardacrm()
            'limpiar
            txtfobs.Text = ""
            drlFlineasfalla.SelectedValue = "0"
            drlFtectolog.SelectedValue = "0"
            txtbarrio.Text = ""
            txtFdirecc.Text = ""
            txtFciudad.Text = ""
            rdbvc.SelectedValue = Nothing
            drlFportada.SelectedValue = "0"
            'caracteristicas
            Dim objgral As New clsgeneral
            With drlFcaract
                .DataSource = objgral.consultacaract
                .DataTextField = "desccarac"
                .DataValueField = "idcarac"
                .DataBind()
            End With
            drlFcaract.SelectedValue = "0"
            txtFtipofalla.Text = ""
            txtFcontacto.Text = ""
            txtFnum.Text = ""
            txtapn.Text = ""
            txtqos.Text = ""
            lblcampana.Text = ""
            drlFtiempo.SelectedValue = "0"
            txtcaso.Text = ""
            drlequipo.SelectedIndex = 0
            drlmun.SelectedIndex = 0
            casosptes()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub guardacrm()
        Dim objdatos As New clsvoz
        Try
            If txtcaso.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            objdatos.obs = ""
            If chkanula.Checked = True Then
                objdatos.tipificacion = "Anulado"
            Else
                objdatos.tipificacion = "Corregido"
            End If
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            If lblcampana.Text = "Datos" Then
                objdatos.registrocrmfallareddatos()
            Else
                objdatos.registrocrmfallared()
            End If
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Falla de Red Modificada con éxito"
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Private Sub cargacaracter()
        Dim objdatos As New clsgeneral
        With drlFcaract
            If lblcampana.Text = "Datos" Then
                .DataSource = objdatos.consultacaractdat
            Else
                .DataSource = objdatos.consultacaract
            End If
            .DataTextField = "desccarac"
            .DataValueField = "idcarac"
            .DataBind()
        End With
    End Sub
    Sub buscarinf()
        Try
            Dim objdatos As New clsvoz
            cargacaracter()
            objdatos.caso = txtcaso.Text
            objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
            objdatos.consultacasodevuelto()
            If objdatos.cantidad > 0 Then
                txtcaso.Text = objdatos.caso
                txtFcontacto.Text = objdatos.cliente
                txtFnum.Text = objdatos.telcontacto
                drlFtiempo.SelectedValue = objdatos.tiempo
                txtFtipofalla.Text = objdatos.tipofalla
                drlFcaract.SelectedItem.Text = objdatos.caracter
                drlFcaract.SelectedItem.Value = "1"
                drlFportada.SelectedValue = objdatos.portada
                drlmun.SelectedValue = objdatos.mun
                txtFciudad.Text = objdatos.vereda
                txtFdirecc.Text = objdatos.dir
                txtbarrio.Text = objdatos.barrio
                drlFtectolog.SelectedValue = objdatos.tecnologia
                drlequipo.SelectedValue = objdatos.equipo
                drlFlineasfalla.SelectedValue = objdatos.maslineas
                txtfobs.Text = objdatos.obs
                txtapn.Text = objdatos.apn
                txtqos.Text = objdatos.qos
                lblcampana.Text = objdatos.campana
                Pnl_Message.CssClass = Nothing
                lblmsg.Text = Nothing
            Else
                txtfobs.Text = ""
                drlFlineasfalla.SelectedValue = "0"
                drlFtectolog.SelectedValue = "0"
                txtbarrio.Text = ""
                txtFdirecc.Text = ""
                txtFciudad.Text = ""
                txtapn.Text = ""
                txtqos.Text = ""
                lblcampana.Text = ""
                rdbvc.SelectedValue = Nothing
                drlFportada.SelectedValue = "0"
                'caracteristicas
                cargacaracter()
                txtFtipofalla.Text = ""
                txtFcontacto.Text = ""
                txtFnum.Text = ""
                drlFtiempo.SelectedValue = "0"
                txtcaso.Text = ""
                casosptes()
                Pnl_Message.CssClass = "alert alert-info"
                lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> El caso no existe o no se encuentra asignado a su usuario o ya fue reportado el CPD, verifique"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Private Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex
            dtggeneral.DataSource = Session("dtggeneral")
            dtggeneral.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub BtnExportar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnExportar.Click
        Try
            Dim sw As New StringWriter()
            Dim hw As New HtmlTextWriter(sw)
            Dim tabla As New Table()
            Dim tr1 As New TableRow()
            Dim cell1 As New TableCell()
            Dim Val As Boolean = False
            Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"
            If dtggeneral.Rows.Count > 0 And dtggeneral.Rows.Count < 8101 Then
                Val = True
                dtggeneral.AllowPaging = False
                dtggeneral.DataSource = Session("dtggeneral")
                dtggeneral.DataBind()
                cell1.Controls.Add(dtggeneral)
                tr1.Cells.Add(cell1)
                tabla.Rows.Add(tr1)
                tabla.RenderControl(hw)
                dtggeneral.AllowPaging = True
            ElseIf dtggeneral.Rows.Count > 8100 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Se denego el permiso de exportacion debido a que exede el limite de registros; Realice otro filtro y reintente exportar! "
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span Class='glyphicon glyphicon-warning-sign'></span> ¡No se encontraron registros para realizar la exportacion! "
            End If
            If Val = True Then
                Response.Clear()
                Response.Buffer = True
                Response.AddHeader("Content-Disposition", "attachment;filename=Data.xls")
                Response.Charset = "UTF-8"
                Response.ContentType = "application/vnd.ms-excel"
                Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                Response.Write(style)
                Response.Output.Write(sw.ToString())
                Response.End()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class