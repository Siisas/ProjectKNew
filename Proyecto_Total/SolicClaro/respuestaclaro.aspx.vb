Imports System.IO
Public Class respuestaclaro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                With drltiposolicitudcons
                    .DataSource = objdatos.consultatiposolic
                    .DataTextField = "descsolicitud"
                    .DataValueField = "idtipo"
                    .DataBind()
                End With
                With drlpriorizacioncons
                    .DataSource = objdatos.consultaprioridad
                    .DataTextField = "descprioridad"
                    .DataValueField = "idprioridad"
                    .DataBind()
                End With
                With drlestado
                    .DataSource = objdatos.consultaestado
                    .DataTextField = "descestado"
                    .DataValueField = "idestado"
                    .DataBind()
                End With
                With drlestadoact
                    .DataSource = objdatos.consultaestado
                    .DataTextField = "descestado"
                    .DataValueField = "idestado"
                    .DataBind()
                End With
                With drlasignar
                    .DataSource = objdatos.consultaareaasigna
                    .DataTextField = "descarea"
                    .DataValueField = "descarea"
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

    Protected Sub lnkseguimiento_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnkseguimiento.Click
        lnkseguimiento.ForeColor = Drawing.Color.Black
        lnkconsulta.ForeColor = Drawing.Color.Blue
        pnconsulta.Visible = False
        pnseguimiento.Visible = True
        lblmsg.Text = ""
    End Sub
    Protected Sub consultar()
        Try
            Dim objdatos As New clssolicitud
            If txtidreg.Text <> "" Then
                objdatos.idreg = txtidreg.Text
            Else
                lblmsg.Text = "Digite el número de caso a consultar"
                Exit Sub
            End If
            dtggeneral.DataSource = objdatos.consultaseguimientos
            dtggeneral.DataBind()

            objdatos.consultasolic()
            If objdatos.cantidad > 0 Then

                lbltipo.Text = objdatos.tiposolic
                lblprioridad.Text = objdatos.prioridad
                lbldescrip.Text = objdatos.obs
                lblestado.Text = objdatos.estado
                lblfcprobable.Text = objdatos.fcprobable
                lblidsolic.Text = objdatos.idreg
                hpladjunto.Text = objdatos.archivo
                If objdatos.idasignado <> "- Seleccione -" Then
                    drlasignar.SelectedValue = objdatos.idasignado
                    btnasignar.Enabled = False
                Else
                    btnasignar.Enabled = True
                    drlasignar.SelectedValue = "- Seleccione -"
                End If

                hpladjunto.NavigateUrl = "~/SolicClaro/data/" & objdatos.archivo
            Else
                lbltipo.Text = ""
                lblprioridad.Text = ""
                lbldescrip.Text = ""
                lblestado.Text = ""
                lblfcprobable.Text = ""
                lblidsolic.Text = ""
                hpladjunto.Text = ""
                hpladjunto.NavigateUrl = Nothing
            End If

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub btnconsultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnconsultar.Click
        Try
            consultar()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardarseg_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardarseg.Click
        Try
            If lblestado.Text = "Cerrado" Then
                lblmsg.Text = "La solicitud se encuentra cerrada y no se puede generar seguimientos, si se requiere cree una nueva solicitud"
                Exit Sub
            End If
            Dim Fn As String
            Dim SaveLocation As String
            Dim objdatos As New clssolicitud
            If Fluadjuntoseg.HasFile Then
                Fn = System.IO.Path.GetFileName(Fluadjuntoseg.PostedFile.FileName)
                SaveLocation = Server.MapPath("data") & "\\" & Fn
                Fluadjuntoseg.PostedFile.SaveAs(SaveLocation)
                objdatos.archivo = Fn
            Else
                objdatos.archivo = ""
            End If
            If txtobsseg.Text = "" Then
                lblmsg.Text = "Digite la observación de atención al caso"
                Exit Sub
            Else
                objdatos.obs = txtobsseg.Text
            End If
            If drlestadoact.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Elija el estado de la solicitud"
                Exit Sub
            Else
                objdatos.estado = drlestadoact.SelectedItem.Value
            End If
            If lblfcprobable.Text = " " Then
                If txtfcprobable.Text = "" Then
                    lblmsg.Text = "Digite la fecha probable de entrega del informe"
                    Exit Sub
                Else
                    objdatos.fcprobable = txtfcprobable.Text
                End If
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.idreg = lblidsolic.Text
            objdatos.registroseguimientokam()
            lblmsg.Text = "Solcitid registrada con éxito"
            actualizaestado()
            consultar()
            txtobsseg.Text = ""
            lbltipo.Text = ""
            lblprioridad.Text = ""
            lbldescrip.Text = ""
            lblestado.Text = ""
            lblfcprobable.Text = ""
            lblidsolic.Text = ""
            hpladjunto.Text = ""
            hpladjunto.NavigateUrl = Nothing
            txtidreg.Text = ""
            drlestadoact.SelectedValue = 0
            txtfcprobable.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub actualizaestado()
        Try
            Dim objdatos As New clssolicitud
            objdatos.idreg = lblidsolic.Text
            objdatos.estado = drlestadoact.SelectedItem.Value
            If txtfcprobable.Text <> "" Then
                objdatos.fcprobable = txtfcprobable.Text
            End If
            objdatos.Actualizaestado()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub lnkconsulta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnkconsulta.Click
        lnkseguimiento.ForeColor = Drawing.Color.Blue
        lnkconsulta.ForeColor = Drawing.Color.Black
        pnconsulta.Visible = True
        pnseguimiento.Visible = False
        lblmsg.Text = ""
    End Sub
    Protected Sub consultagral()
        Try
            Dim objdatos As New clssolicitud
            If txtidregconsulta.Text <> "" Then
                objdatos.idreg = txtidregconsulta.Text
            End If
            If drlestado.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.estado = drlestado.SelectedItem.Value
            End If
            If drltiposolicitudcons.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.tiposolic = drltiposolicitudcons.SelectedItem.Value
            End If
            If drlpriorizacioncons.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.prioridad = drlpriorizacioncons.SelectedItem.Value
            End If
            dtgconsulta.DataSource = objdatos.consultasolicitudes
            dtgconsulta.DataBind()
            lblcantidad.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub btnconsultar0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnconsultar0.Click
        Try
            consultagral()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Private Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            consultar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub dtgconsulta_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgconsulta.PageIndexChanging
        Try
            dtgconsulta.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            consultagral()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub btnexpxls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnexpxls.Click
        Try
            crearexcel()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
            lblmsg.ForeColor = Drawing.Color.Red
        End Try
    End Sub
    Sub crearexcel()
        Dim sb As New StringBuilder
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim form = New HtmlForm
        Dim r As New clssolicitud
        Dim objdtsconsultaxls As New DataSet
        Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
        If lblcantidad.Text <> Nothing Then
            If lblcantidad.Text < 20001 Then
                If txtidregconsulta.Text <> "" Then
                    r.idreg = txtidregconsulta.Text
                End If
                If drlestado.SelectedItem.Text <> "- Seleccione -" Then
                    r.estado = drlestado.SelectedItem.Value
                End If
                If drltiposolicitudcons.SelectedItem.Text <> "- Seleccione -" Then
                    r.tiposolic = drltiposolicitudcons.SelectedItem.Value
                End If
                If drlpriorizacioncons.SelectedItem.Text <> "- Seleccione -" Then
                    r.prioridad = drlpriorizacioncons.SelectedItem.Value
                End If
                dtgxls.DataSource = r.consultasolicitudes
                dtgxls.DataBind()
                dtgxls.Visible = True
                dtgxls.EnableViewState = False
                pagina.EnableEventValidation = False
                pagina.DesignerInitialize()
                pagina.Controls.Add(form)
                form.Controls.Add(dtgxls)
                pagina.RenderControl(htw)
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/vnd.ms-excel"
                Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                Response.AddHeader("Content-Disposition", "attachment;filename=data.xls")
                Response.Charset = "UTF-8"
                Response.Write(strStyle)
                Response.Write(sb.ToString())
                Response.End()
            Else
                lblmsg.Text = "No se puede generar archivo en xls, realice un filtro adicional o solicite la consulta al administrador de la base de datos"
            End If
        Else
            lblmsg.Text = "Realice una consulta y luego intente exportarla"
        End If
    End Sub

    Protected Sub btnasignar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnasignar.Click
        Try
            Dim objdatos As New clsvoz
            If lblidsolic.Text = "" Then
                lblmsg.Text = "Digite el número de solicitud antes de realizar la asignación"
            Else
                If drlasignar.SelectedItem.Text = "- Seleccione -" Then
                    lblmsg.Text = "Elija el usuario a quien desea asignar el caso antes de realizar la asignación"
                Else
                    objdatos.areafalla = drlasignar.SelectedItem.Text
                    objdatos.idcrm = lblidsolic.Text
                    objdatos.asignasolicitud()
                    lblmsg.Text = "Asignación realizada con éxito"
                End If
                drlasignar.SelectedValue = "- Seleccione -"
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try

    End Sub
End Class