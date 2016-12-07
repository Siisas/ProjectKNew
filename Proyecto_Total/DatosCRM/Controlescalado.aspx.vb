Imports System.IO
Public Class Controlescalado
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
            Dim objdatos As New clscrmdatos
            'If drlestado.SelectedItem.Value <> "0" Then
            '    objdatos.tipificacion = drlestado.SelectedItem.Text
            'End If
            'If txtfcdesde.Text <> Nothing Then
            '    objdatos.fcini = txtfcdesde.Text
            'End If
            'If txtfchasta.Text <> Nothing Then
            '    objdatos.fcfin = txtfchasta.Text
            'End If
            'If txtcaso.Text <> Nothing Then
            '    objdatos.caso = txtcaso.Text
            'End If
            'If drlnivel.SelectedItem.Value <> "0" Then
            '    objdatos.barrio = drlnivel.SelectedItem.Value
            'End If
            dtggeneral.DataSource = objdatos.consultacontrolescalados
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
                If drlestado.SelectedItem.Value <> "0" Then
                    r.tipificacion = drlestado.SelectedItem.Text
                End If
                If txtfcdesde.Text <> Nothing Then
                    r.fcini = txtfcdesde.Text
                End If
                If txtfchasta.Text <> Nothing Then
                    r.fcfin = txtfchasta.Text
                End If
                If txtcaso.Text <> Nothing Then
                    r.caso = txtcaso.Text
                End If
                If drlnivel.SelectedItem.Value <> "0" Then
                    r.barrio = drlnivel.SelectedItem.Value
                End If
                dtgxls.DataSource = r.consultainc
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