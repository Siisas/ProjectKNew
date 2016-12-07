Imports System.IO

Public Class InformeRemisionEquiposCav
    Inherits System.Web.UI.Page
    Dim ObjInforme As New clsInformes

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

    Public Sub ConsultarCav()
        Try
            If TxtFecha_Inicio.Text = "" Then
                lblmsg.Text = "Ingrese Fecha Inicial"
                Exit Sub
            End If
            If TxtFecha_Fin.Text = "" Then
                lblmsg.Text = "Ingrese Fecha Final"
                Exit Sub
            End If
            lblmsg.Text = ""
            ObjInforme.Fcini = TxtFecha_Inicio.Text
            ObjInforme.Fcfin = TxtFecha_Fin.Text

            GridView1.DataSource = ObjInforme.Consulta_Remision_Equipos_cav
            GridView1.DataBind()
            lblCasos.Text = ObjInforme.Cantidad
            TxtFecha_Inicio.Text = ""
            TxtFecha_Fin.Text = ""
            
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub

    Protected Sub Colsultar_Click(sender As Object, e As EventArgs) Handles Colsultar.Click
        Try
            ConsultarCav()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    'EXPORTAR A EXCEL
    Sub crearexcel()
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
            GridView2.Visible = True
            form.Controls.Add(GridView2)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True

            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=Remision_equipos_CAV.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub Exportar_Click(sender As Object, e As EventArgs) Handles Exportar.Click
        Try
            If TxtFecha_Inicio.Text = "" Then
                lblmsg.Text = "Ingrese Fecha Inicial"
                Exit Sub
            End If
            If TxtFecha_Fin.Text = "" Then
                lblmsg.Text = "Ingrese Fecha Final"
                Exit Sub
            End If
            lblmsg.Text = ""
            ObjInforme.Fcini = TxtFecha_Inicio.Text
            ObjInforme.Fcfin = TxtFecha_Fin.Text
            GridView2.DataSource = ObjInforme.Consulta_Remision_Equipos_cav
            GridView2.DataBind()
            crearexcel()
            TxtFecha_Inicio.Text = ""
            TxtFecha_Fin.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
            lblmsg.ForeColor = Drawing.Color.Red
        End Try
    End Sub

    Protected Sub GridView1_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        Try

            GridView1.PageIndex = e.NewPageIndex
            ConsultarCav()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
        
    End Sub
End Class