Imports System.IO

Public Class EscalamientoInbound1
    Inherits System.Web.UI.Page
    Dim Objinformes As New clsInformes
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
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
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim fcini As Date
            Dim fcfin As Date
            If txtFecha_inicio.Text <> Nothing And txtFecha_Fin.Text <> Nothing Then
                fcini = txtFecha_inicio.Text
                fcfin = txtFecha_Fin.Text
            Else
                lblmsg.Text = "Debe consultar por Fecha inicio y Fecha fin"
                txtFecha_Fin.Text = ""
                txtFecha_inicio.Text = ""
                lblcantgral.Text = ""
                lblf1.Text = ""
                DtgEscalados.DataSource = Nothing
                DtgEscalados.DataBind()
                BtnExpo.Visible = False
                Exit Sub
            End If
            If fcini > fcfin Then
                lblmsg.Text = "Fecha inicio debe ser menor a Fecha fin"
                txtFecha_Fin.Text = ""
                txtFecha_inicio.Text = ""
                lblcantgral.Text = ""
                lblf1.Text = ""
                DtgEscalados.DataSource = Nothing
                DtgEscalados.DataBind()
                BtnExpo.Visible = False
                Exit Sub
            Else
                lblf1.Text = "Consulta desde " + txtFecha_inicio.Text + " hasta " + txtFecha_Fin.Text
                Objinformes.Validacionn = 0
                Objinformes.Escalamientoinbound()
                Objinformes.Validacionn = 1
                Objinformes.Fecha_inicio = txtFecha_inicio.Text
                Objinformes.Fecha_Fin = txtFecha_Fin.Text
                Objinformes.Escalamientoinbound()
                Objinformes.Validacionn = 2
                Objinformes.Escalamientoinbound()
                Objinformes.Validacionn = 3
                Objinformes.Escalamientoinbound()
                Objinformes.Validacionn = 4
                Objinformes.Escalamientoinbound()
                Objinformes.Validacionn = 5
                Objinformes.Escalamientoinbound()
                Objinformes.Validacionn = 6
                Objinformes.Escalamientoinbound()
                Objinformes.Validacionn = 7
                Objinformes.Escalamientoinbound()
                DtgEscalados.DataSource = Objinformes.Finalinbound
                DtgEscalados.DataBind()
                lblcantgral.Text = Objinformes.Cantidad
            End If
            If lblcantgral.Text = 0 Then
                lblmsg.Text = "No se encontraron registros"
                txtFecha_Fin.Text = ""
                txtFecha_inicio.Text = ""
                lblcantgral.Text = ""
                lblf1.Text = ""
                BtnExpo.Visible = False
                DtgEscalados.DataSource = Nothing
                DtgEscalados.DataBind()
                Exit Sub
            Else
                BtnExpo.Visible = True
            End If
            txtFecha_Fin.Text = ""
            txtFecha_inicio.Text = ""
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Public Sub Exportarxls()
        Try
            DtgServicio2.Visible = True
            Dim sb As New StringBuilder
            Dim sw As New StringWriter(sb)
            Dim htw As New HtmlTextWriter(sw)
            Dim pagina As Page = New Page
            Dim form = New HtmlForm
            Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
            pagina.EnableEventValidation = False
            pagina.DesignerInitialize()
            pagina.Controls.Add(form)
            form.Controls.Add(DtgServicio2)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=EscaladosInbound.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub BtnExpo_Click(sender As Object, e As EventArgs) Handles BtnExpo.Click
        Try
            DtgServicio2.DataSource = Objinformes.Finalinbound()
            DtgServicio2.DataBind()
            Exportarxls()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub DtgServicio2_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles DtgServicio2.PageIndexChanging
        Try
            DtgEscalados.DataSource = Objinformes.Finalinbound
            DtgEscalados.PageIndex = e.NewPageIndex
            DtgEscalados.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

End Class