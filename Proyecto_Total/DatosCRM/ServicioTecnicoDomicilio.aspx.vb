Imports System.IO

Public Class ServicioTecnicoDomicilio
    Inherits System.Web.UI.Page
    Dim ObjInformes As New clsInformes
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
            cargar()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Public Sub cargar()
        Try
            Dim fcini As New Date
            Dim fcfin As New Date
            If TxtFecha_Inicio.Text <> Nothing Then
                fcini = TxtFecha_Inicio.Text
                ObjInformes.Fecha_inicio = TxtFecha_Inicio.Text
                lblf1.Text = TxtFecha_Inicio.Text
            Else
                ObjInformes.Fecha_inicio = ""
            End If
            If TxtFecha_Fin.Text <> Nothing Then
                fcfin = TxtFecha_Fin.Text
                ObjInformes.Fecha_Fin = TxtFecha_Fin.Text
                If fcfin < fcini Then
                    lblmsg.Text = "Verifique que Fecha Inicio sea menor a Fecha Fin"
                    TxtFecha_Fin.Text = ""
                    TxtFecha_Inicio.Text = ""
                    lblcantgral.Text = ""
                    lblf1.Text = ""
                    lblf2.Text = ""
                    BtnExpo.Visible = False
                    DtgServicio.Visible = False
                    Exit Sub
                Else
                    lblf2.Text = TxtFecha_Fin.Text
                End If
            Else
                ObjInformes.Fecha_Fin = ""
            End If
            If TxtCiudad.Text <> Nothing Then
                ObjInformes.Ciudad = TxtCiudad.Text
                DtgServicio.Visible = True
                DtgServicio.DataSource = ObjInformes.ServicioCliente
                DtgServicio.DataBind()
                DtgServicio2.DataSource = ObjInformes.ServicioCliente
                DtgServicio2.DataBind()
                lblcantgral.Text = ObjInformes.Cantidad
                BtnExpo.Visible = True
                If lblcantgral.Text = 0 Then
                    lblmsg.Text = "No se encontraron datos"
                    TxtFecha_Fin.Text = ""
                    TxtFecha_Inicio.Text = ""
                    TxtCiudad.Text = ""
                    lblf1.Text = ""
                    lblf2.Text = ""
                    BtnExpo.Visible = False
                    DtgServicio.Visible = False
                    Exit Sub
                End If
            Else
                lblmsg.Text = "Digite una ciudad"
                lblcantgral.Text = ""
                TxtFecha_Fin.Text = ""
                TxtFecha_Inicio.Text = ""
                lblf1.Text = ""
                lblf2.Text = ""
                BtnExpo.Visible = False
                DtgServicio.Visible = False
                Exit Sub
            End If

            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
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
            Response.AddHeader("Content-Disposition", "attachment;filename=ServicioCli:" + TxtFecha_Inicio.Text + "-" + TxtFecha_Fin.Text + ".xls")
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

            Exportarxls()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub DtgServicio_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles DtgServicio.PageIndexChanging
        Try
            DtgServicio.PageIndex = e.NewPageIndex
            cargar()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub DtgServicio2_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles DtgServicio2.SelectedIndexChanging
        Try
            DtgServicio2.PageIndex = e.NewSelectedIndex
            cargar()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
End Class