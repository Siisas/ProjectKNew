Imports System.IO
Public Class InformesVoz_Datos
    Inherits System.Web.UI.Page
    Dim Objinfo As New clsInformes

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
            lblmsg.Text = "Se presento erro: " + ex.Message
        End Try
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If drlgrupo.Text = "- Seleccionar -" Then
                lblmsg.Text = "Ingrese el grupo para consultar"
                Exit Sub
            End If
            Format$(txtfini.Text, "dd/mm/yyyy")
            Format$(txtffin.Text, "dd/mm/yyyy")
            If txtfini.Text = Nothing Then
                lblmsg.Text = "Ingrese una fecha inicial para consultar"
                Exit Sub
            End If
            If txtffin.Text = Nothing Then
                lblmsg.Text = "Ingrese una fecha final para consultar"
                Exit Sub
            End If
            If CDate(txtfini.Text) > CDate(txtffin.Text) Then
                lblmsg.Text = "La fecha inicial es mayor que la fecha final del período"
                Exit Sub
            End If
            If drlgrupo.Text = "Datos" Then
                Objinfo.Fcini = txtfini.Text
                Objinfo.Fcfin = txtffin.Text
                dtgConsbande.DataSource = Objinfo.Consulta_InformeDatosBandeja()
                dtgConsbande.DataBind()
                dtgConsesta.DataSource = Objinfo.Consulta_InformeDatosEstado()
                dtgConsesta.DataBind()
                lblcantidad.Text = Objinfo.Cantidad
                btnExportar.Visible = True
            End If
            If drlgrupo.Text = "Voz" Then
                Objinfo.Fcini = txtfini.Text
                Objinfo.Fcfin = txtffin.Text
                dtgConsbande.DataSource = Objinfo.Consulta_InformeVozBandeja()
                dtgConsbande.DataBind()
                dtgConsesta.DataSource = Objinfo.Consulta_InformeVozEstado()
                dtgConsesta.DataBind()
                lblcantidad.Text = Objinfo.Cantidad
                btnExportar.Visible = True
            End If
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento erro: " + ex.Message
        End Try
    End Sub

    Protected Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            Exportarxls()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Public Sub Exportarxls()
        Try
            Dim sb As New StringBuilder
            Dim sw As New StringWriter(sb)
            Dim htw As New HtmlTextWriter(sw)
            Dim pagina As Page = New Page
            Dim form = New HtmlForm
            Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
            pagina.EnableEventValidation = False
            pagina.DesignerInitialize()
            pagina.Controls.Add(form)
            form.Controls.Add(dtgConsbande)
            form.Controls.Add(dtgConsesta)
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
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
End Class