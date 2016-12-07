Imports System.IO
Public Class infdinamico
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
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

    Sub buscarinf()
        Try
            'filtro vertical
            Dim objdatos As New clscrmdatos
            If txtfcdesden3.Text <> Nothing Then
                objdatos.fcini3 = txtfcdesden3.Text
                lblmsg.Text = ""
            Else
                lblmsg.Text = "Debe seleccionar un rango de fechas para realizar la consulta"
                Exit Sub
            End If
            If txtfchastan3.Text <> Nothing Then
                If Convert.ToDateTime(txtfcdesden3.Text) > Convert.ToDateTime(txtfchastan3.Text) Then
                    lblmsg.Text = "La fecha inicial no puede ser mayor que la fecha final"
                    Exit Sub
                End If
                objdatos.fcfin3 = txtfchastan3.Text
            End If
            If chkcaso.Checked = False And chkmin.Checked = False And chkfcreg.Checked = False And chknombre.Checked = False And chkdocumento.Checked = False And chkfcseguim.Checked = False And chkestado.Checked = False And chknxmonitor.Checked = False And chkrespuesta.Checked = False And chkfavorabilidad.Checked = False And chkgrupo.Checked = False And chkcausalcierre.Checked = False And chkclientesito.Checked = False And chktipoasunto.Checked = False Then
                lblmsg.Text = "Debe elgir los campos que desea consultar"
                Exit Sub
            End If
            'filtro horizontal
            If chkcaso.Checked Then
                objdatos.caso = 1
            End If
            If chkmin.Checked = True Then
                objdatos.min = 1
            End If
            If chkfcreg.Checked = True Then
                objdatos.fcreg = 1
            End If
            If chknombre.Checked = True Then
                objdatos.cliente = 1
            End If
            If chkdocumento.Checked = True Then
                objdatos.identificacion = 1
            End If
            If chkfcseguim.Checked = True Then
                objdatos.fcsap = 1
            End If
            If chkestado.Checked = True Then
                objdatos.estadoinc = 1
            End If
            If chknxmonitor.Checked = True Then
                objdatos.nit = 1
            End If
            If chkrespuesta.Checked = True Then
                objdatos.preg1 = 1
            End If
            If chkfavorabilidad.Checked = True Then
                objdatos.fcrest = 1
            End If
            If chkgrupo.Checked = True Then
                objdatos.grupo = 1
            End If
            If chkcausalcierre.Checked = True Then
                objdatos.chk1 = 1
            End If
            If chkclientesito.Checked = True Then
                objdatos.tipificacion = 1
            End If
            If chktipoasunto.Checked = True Then
                objdatos.tiposoporte = 1
            End If
            If chktodos.Checked = True Then
                objdatos.tlinea = 1
            End If
            dtggeneral.DataSource = objdatos.infdinamicos
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        buscarinf()
    End Sub

    Protected Sub btnxls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnxls.Click
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
        Dim r As New clscrmdatos
        Dim objdtsconsultaxls As New DataSet
        Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
        If lblcuenta.Text <> Nothing Then
            If lblcuenta.Text < 20001 Then
                If txtfcdesden3.Text <> Nothing Then
                    r.fcini3 = txtfcdesden3.Text
                End If
                If txtfchastan3.Text <> Nothing Then
                    r.fcfin3 = txtfchastan3.Text
                End If
                If chkcaso.Checked Then
                    r.caso = 1
                End If
                If chkmin.Checked = True Then
                    r.min = 1
                End If
                If chkfcreg.Checked = True Then
                    r.fcreg = 1
                End If
                If chknombre.Checked = True Then
                    r.cliente = 1
                End If
                If chkdocumento.Checked = True Then
                    r.identificacion = 1
                End If
                If chkfcseguim.Checked = True Then
                    r.fcsap = 1
                End If
                If chkestado.Checked = True Then
                    r.estadoinc = 1
                End If
                If chknxmonitor.Checked = True Then
                    r.nit = 1
                End If
                If chkrespuesta.Checked = True Then
                    r.preg1 = 1
                End If
                If chkfavorabilidad.Checked = True Then
                    r.fcrest = 1
                End If
                If chkgrupo.Checked = True Then
                    r.grupo = 1
                End If
                If chkcausalcierre.Checked = True Then
                    r.chk1 = 1
                End If
                If chkclientesito.Checked = True Then
                    r.tipificacion = 1
                End If
                If chktipoasunto.Checked = True Then
                    r.tiposoporte = 1
                End If
                If chktodos.Checked = True Then
                    r.tlinea = 1
                End If
                dtgxls.DataSource = r.infdinamicos
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
End Class