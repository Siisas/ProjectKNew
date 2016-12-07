Imports System.IO

Public Class FallaMasivaConsulta
    Inherits System.Web.UI.Page
    Dim objinformes As New clsInformes
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

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim fechai As Date
            Dim fechaf As Date
            lbldep.Text = ""
            lblOtro.Text = ""
            If TxtOtro.Text = "" And TxtDepar.Text = "" Then
                lblmsg.Text = "Debe consultar por Departamento o Municipio"
                lbldep.Text = ""
                lblOtro.Text = ""
                TxtDepar.Text = ""
                TxtFecha_Inicio.Text = ""
                TxtFechaFin.Text = ""
                LblCantidad.Text = ""
                DtgFalla.DataSource = Nothing
                DtgFalla.DataBind()
                BtnExportar.Visible = False
                Exit Sub
            Else
                If TxtOtro.Text <> Nothing And TxtDepar.Text <> Nothing Then
                    objinformes.Validacionn = 3
                    objinformes.Depar = TxtDepar.Text
                    objinformes.Otro = TxtOtro.Text
                    If TxtFecha_Inicio.Text <> Nothing Then
                        objinformes.Validacionn = 5
                        objinformes.Fecha_inicio = TxtFecha_Inicio.Text
                    End If
                    If TxtFechaFin.Text <> Nothing Then
                        objinformes.Validacionn = 4
                        objinformes.Fecha_Fin = TxtFechaFin.Text
                    End If
                    If TxtFecha_Inicio.Text <> Nothing And TxtFechaFin.Text <> Nothing Then
                        objinformes.Validacionn = 6
                        fechai = TxtFecha_Inicio.Text
                        fechaf = TxtFechaFin.Text
                        If fechai > fechaf Then
                            lblmsg.Text = "Fecha Inicio debe se menor a Fecha Fin"
                            lbldep.Text = ""
                            lblOtro.Text = ""
                            TxtFecha_Inicio.Text = ""
                            TxtFechaFin.Text = ""
                            BtnExportar.Visible = False
                            Exit Sub
                        End If
                    End If
                    DtgFalla.DataSource = objinformes.FallaMasiva
                    DtgFalla.DataBind()
                    lbldep.Text = "Departamento buscado: " + TxtDepar.Text
                    lblOtro.Text = "Municipio Buscado: " + TxtOtro.Text
                End If
            End If



            If TxtOtro.Text <> Nothing And TxtDepar.Text = "" Then
                objinformes.Validacionn = 1
                objinformes.Otro = TxtOtro.Text
                If TxtFecha_Inicio.Text <> Nothing Then
                    objinformes.Validacionn = 11
                    objinformes.Fecha_inicio = TxtFecha_Inicio.Text
                End If
                If TxtFechaFin.Text <> Nothing Then
                    objinformes.Validacionn = 10
                    objinformes.Fecha_Fin = TxtFechaFin.Text
                End If
                If TxtFecha_Inicio.Text <> Nothing And TxtFechaFin.Text <> Nothing Then
                    objinformes.Validacionn = 12
                    fechai = TxtFecha_Inicio.Text
                    fechaf = TxtFechaFin.Text
                    If fechai > fechaf Then
                        lblmsg.Text = "Fecha Inicio debe se menor a Fecha Fin"
                        lbldep.Text = ""
                        lblOtro.Text = ""
                        TxtFecha_Inicio.Text = ""
                        TxtFechaFin.Text = ""
                        BtnExportar.Visible = False
                        Exit Sub
                    End If
                End If
                DtgFalla.DataSource = objinformes.FallaMasiva
                DtgFalla.DataBind()
                lblOtro.Text = "Municipio buscado: " + TxtOtro.Text
            End If

            If TxtDepar.Text <> Nothing And TxtOtro.Text = "" Then
                objinformes.Validacionn = 2
                objinformes.Depar = TxtDepar.Text
                If TxtFecha_Inicio.Text <> Nothing Then
                    objinformes.Validacionn = 8
                    objinformes.Fecha_inicio = TxtFecha_Inicio.Text
                End If
                If TxtFechaFin.Text <> Nothing Then
                    objinformes.Validacionn = 7
                    objinformes.Fecha_Fin = TxtFechaFin.Text
                End If
                If TxtFecha_Inicio.Text <> Nothing And TxtFechaFin.Text <> Nothing Then
                    objinformes.Validacionn = 9
                    fechai = TxtFecha_Inicio.Text
                    fechaf = TxtFechaFin.Text
                    If fechai > fechaf Then
                        lblmsg.Text = "Fecha Inicio debe se menor a Fecha Fin"
                        lbldep.Text = ""
                        lblOtro.Text = ""
                        TxtFecha_Inicio.Text = ""
                        TxtFechaFin.Text = ""
                        BtnExportar.Visible = False
                        Exit Sub
                    End If
                End If
                DtgFalla.DataSource = objinformes.FallaMasiva
                DtgFalla.DataBind()
                lbldep.Text = "Departamento buscado: " + TxtDepar.Text
            End If

            LblCantidad.Text = objinformes.Cantidad
            If LblCantidad.Text = 0 Then
                lblmsg.Text = "No se encontraron datos"
                lbldep.Text = ""
                lblOtro.Text = ""
                TxtFecha_Inicio.Text = ""
                TxtFechaFin.Text = ""
                BtnExportar.Visible = False
                Exit Sub
            Else
                BtnExportar.Visible = True
            End If
            lblmsg.Text = ""
            TxtFecha_Inicio.Text = ""
            TxtFechaFin.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnExportar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnExportar.Click
        Try
            BtnExportar.Visible = False
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
            form.Controls.Add(DtgFalla)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=FallaMasiva.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
End Class