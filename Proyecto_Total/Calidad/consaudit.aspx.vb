Imports System.IO
Public Class consaudit
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                With drlagente
                    .DataSource = objdatos.consultaagente
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

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            buscarinf()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub buscarinf()
        Try
            Dim objdatos As New clscalidad
            If txtcodigo.Text <> "" Then
                Dim objusu As New clsgeneral
                objusu.idusuario = txtcodigo.Text
                objusu.traeusuario()
                drlagente.SelectedValue = objusu.cargo
            End If
            If drlagente.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.agente = drlagente.SelectedItem.Value
                Panel3.Visible = True
            Else
                Panel3.Visible = False
            End If
            If txtfcini.Text <> "" Then
                objdatos.fcini = txtfcini.Text
            End If
            If txtfcfin.Text <> "" Then
                objdatos.fcfin = txtfcfin.Text
            End If
            If txtid.Text <> "" Then
                objdatos.idreg = txtid.Text
            End If
            If drltipo.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.tipo = drltipo.SelectedItem.Value
            End If
            If drlnivel.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.nivel = drlnivel.SelectedItem.Value
            End If
            If txtfcinill.Text <> "" Then
                objdatos.fcinill = txtfcinill.Text
            End If
            If txtfcfinll.Text <> "" Then
                objdatos.fcfinll = txtfcfinll.Text
            End If
           
            dtggeneral.DataSource = objdatos.consultaaudit
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
            'consulta nota final
            objdatos.consultanotafin()
            lblnota.Text = FormatNumber(objdatos.nota / (lblcuenta.Text / 2))


            If txtid.Text <> "" Then
                objdatos.idreg = txtid.Text
                dtgdetalle.DataSource = objdatos.consultaauditdetalle
                dtgdetalle.DataBind()
                lblcuentaaud.Text = objdatos.cantidad
            Else
                dtgdetalle.DataSource = Nothing
                dtgdetalle.DataBind()
                lblcuentaaud.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
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
        Dim r As New clscalidad
        Dim objdtsconsultaxls As New DataSet
        Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
        If lblcuenta.Text <> Nothing Then
            If lblcuenta.Text < 20001 Then
                If drlagente.SelectedItem.Text <> "- Seleccione -" Then
                    r.agente = drlagente.SelectedItem.Value
                End If
                If txtfcini.Text <> "" Then
                    r.fcini = txtfcini.Text
                End If
                If txtfcfin.Text <> "" Then
                    r.fcfin = txtfcfin.Text
                End If
                If txtid.Text <> "" Then
                    r.idreg = txtid.Text
                End If
                If drltipo.SelectedItem.Text <> "- Seleccione -" Then
                    r.tipo = drltipo.SelectedItem.Value
                End If
                If drlnivel.SelectedItem.Text <> "- Seleccione -" Then
                    r.nivel = drlnivel.SelectedItem.Value
                End If
                If txtfcinill.Text <> "" Then
                    r.fcinill = txtfcinill.Text
                End If
                If txtfcfinll.Text <> "" Then
                    r.fcfinll = txtfcfinll.Text
                End If
                dtgxls.DataSource = r.consultaaudit
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

    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            buscarinf()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class