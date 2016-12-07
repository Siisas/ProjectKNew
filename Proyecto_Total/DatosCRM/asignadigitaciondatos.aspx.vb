Imports System.IO
Public Class asignadigitaciondatos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                asignado()
                With drlusuario
                    .DataSource = objdatos.consultadigitador
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
    Protected Sub asignado()
        Try
            Dim objdatos As New clscrmdatos
            dtgestad.DataSource = objdatos.consultaenprocdigitadt
            dtgestad.DataBind()
            objdatos.consultapteasignartotaldigitacdt()
            lblcantidadtot.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim actualizar As New clscrmdatos
        Try
            actualizar.idusuario = Me.drlusuario.SelectedItem.Value
            actualizar.idcrm = lblusuario.Text
            If txtcaso.Text <> Nothing Then
                actualizar.caso = txtcaso.Text
                actualizar.asignaescalaxcasodigdt()
                txtcaso.Text = ""
                lblmsg.Text = "Asignación individual realizada con éxito"
            Else
                For Each row As GridViewRow In dtggeneral.Rows
                    actualizar.caso = CInt(row.Cells(0).Text)
                    actualizar.asignaescalaxcasodigdt()
                Next
                lblmsg.Text = "Asignación masiva realizada con éxito"
            End If
            dtggeneral.DataSource = Nothing
            dtggeneral.DataBind()
            lblcantidad.Text = ""
            asignado()
        Catch ex As Exception
            Me.lblmsg.Text = "se ha producido un error:" & ex.Message
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            busca()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub busca()
        Try
            Dim objdatos As New clscrmdatos
            If txtcantidad.Text = "" Then
                lblmsg.Text = "Digite la cantidad de casos que desea asignar"
                Exit Sub
            Else
                objdatos.cantidad = txtcantidad.Text
                dtggeneral.DataSource = objdatos.consultapteasignardigitadt
                dtggeneral.DataBind()
                dtgGeneralExcel.DataSource = objdatos.consultapteasignardigitadt
                dtgGeneralExcel.DataBind()
                lblcantidad.Text = objdatos.cantidad
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub dtgestad_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgestad.PageIndexChanging
        Try
            dtgestad.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            asignado()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub crearexcel()
        Dim sb As New StringBuilder
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim form = New HtmlForm
        Dim r As New clsCaidaSistema
        Dim objdtsconsultaxls As New DataSet
        Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"

        If dtgGeneralExcel.Rows.Count > 0 Then

            pagina.EnableEventValidation = False
            pagina.DesignerInitialize()
            pagina.Controls.Add(form)
            dtgGeneralExcel.Visible = True
            form.Controls.Add(dtgGeneralExcel)
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
            lblmsg.Text = ""
        Else
            lblmsg.Text = "Por favor realice una consulta antes de exportar"
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

    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        dtggeneral.PageIndex = e.NewPageIndex()
        busca()
    End Sub
End Class