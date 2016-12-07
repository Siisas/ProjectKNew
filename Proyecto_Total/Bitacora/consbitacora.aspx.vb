Imports System.IO
Partial Public Class consbitacora
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                With drlproyecto
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultaproyecto
                    .DataTextField = "nombreproyecto"
                    .DataValueField = "idproyecto"
                    .DataBind()
                End With
                With drlusuario
                    .DataSource = objdatos.consultausuario
                    .DataTextField = "nombreu"
                    .DataValueField = "idusuario"
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
    Sub buscarinf()
        Dim objdatos As New clsbitacora
        If drlproyecto.SelectedItem.Value = "0" And txtfcbitacora.Text = "" And txtfcreg.Text = "" And drlusuario.SelectedItem.Value = "0" Then
            lblmsg.Text = "Elija una opción de filtro antes de realizar la consulta"
        Else
            If drlusuario.SelectedItem.Value <> "0" Then
                objdatos.idusuario = drlusuario.SelectedItem.Value
            End If
            If txtfcbitacora.Text <> "" Then
                objdatos.fcbitacora = txtfcbitacora.Text
            End If
            If txtfcreg.Text <> "" Then
                objdatos.fcregistro = txtfcreg.Text
            End If
            If drlproyecto.SelectedItem.Value <> 0 Then
                objdatos.proyecto = drlproyecto.SelectedItem.Value
            End If
            dtgbitacora.DataSource = objdatos.consultabitacora
            dtgbitacora.DataBind()
            lblcuenta.Text = objdatos.cantidad
            lblmsg.Text = ""
        End If
    End Sub
    Protected Sub btnconsultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnconsultar.Click
        Try
            dtgbitacora.PageIndex = 0
            buscarinf()
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
        Dim r As New clsbitacora
        Dim objdtsconsultaxls As New DataSet
        Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
        If lblcuenta.Text <> Nothing Then
            If lblcuenta.Text < 20001 Then
                If drlusuario.SelectedItem.Value <> "0" Then
                    r.idusuario = drlusuario.SelectedItem.Value
                End If
                If txtfcbitacora.Text <> "" Then
                    r.fcbitacora = txtfcbitacora.Text
                End If
                If txtfcreg.Text <> "" Then
                    r.fcregistro = txtfcreg.Text
                End If
                If drlproyecto.SelectedItem.Value <> 0 Then
                    r.proyecto = drlproyecto.SelectedItem.Value
                End If
                dtgxls.DataSource = r.consultabitacora
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

    Protected Sub btnxls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnxls.Click
        Try
            crearexcel()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
            lblmsg.ForeColor = Drawing.Color.Red
        End Try
    End Sub
End Class