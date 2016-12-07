Imports System.IO

Public Class CasosHoraV
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

    Protected Sub BtnFiltro_Click(sender As Object, e As EventArgs) Handles BtnFiltro.Click
        Try
            Try
                Dim can As Integer = 0
                If TxtFecha_Inicio.Text = "" Then
                    lblmsg.Text = "Debe digitar una fecha"
                    DtgDiario.DataSource = Nothing
                    DtgDiario.DataBind()
                    BtnExpo.Visible = False
                    Exit Sub
                Else
                    Dim diaAc As Date
                    diaAc = TxtFecha_Inicio.Text
                    Dim dia1 As Date = diaAc.AddDays(-7)
                    Dim dia2 As Date = diaAc.AddDays(-14)
                    Dim dia3 As Date = diaAc.AddDays(-21)
                    Dim dia4 As Date = diaAc.AddDays(-28)

                    objinformes.Validacionn = 1
                    objinformes.fcini = dia4.AddDays(-1)
                    objinformes.fcfin = diaAc
                    objinformes.F1 = dia4
                    objinformes.F2 = dia3
                    objinformes.F3 = dia2
                    objinformes.F4 = dia1
                    objinformes.F5 = diaAc
                    fc1.Text = dia4
                    fc2.Text = dia3
                    fc3.Text = dia2
                    fc4.Text = dia1
                    fc5.Text = diaAc

                    DtgDiario.DataSource = objinformes.CasosHoraV
                    DtgDiario.DataBind()
                    can = objinformes.Cantidad
                    If can = 0 Then
                        lblmsg.Text = "No se encontraron datos"
                        DtgDiario.DataSource = Nothing
                        DtgDiario.DataBind()
                        Exit Sub
                    Else
                        BtnExpo.Visible = True
                    End If
                End If

                TxtFecha_Inicio.Text = ""
                lblmsg.Text = ""
            Catch ex As Exception
                lblmsg.Text = "Se presento error: " + ex.Message
            End Try
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnDiario_Click(sender As Object, e As EventArgs) Handles BtnDiario.Click
        Try
            Dim can As Integer = 0
            Dim diaAc As Date = FormatDateTime(Now.Date)
            Dim dia1 As Date = diaAc.AddDays(-7)
            Dim dia2 As Date = diaAc.AddDays(-14)
            Dim dia3 As Date = diaAc.AddDays(-21)
            Dim dia4 As Date = diaAc.AddDays(-28)

            objinformes.Validacionn = 1
            objinformes.fcini = dia4.AddDays(-1)
            objinformes.fcfin = diaAc
            objinformes.F1 = dia4
            objinformes.F2 = dia3
            objinformes.F3 = dia2
            objinformes.F4 = dia1
            objinformes.F5 = diaAc
            fc1.Text = dia4
            fc2.Text = dia3
            fc3.Text = dia2
            fc4.Text = dia1
            fc5.Text = diaAc

            DtgDiario.DataSource = objinformes.CasosHoraV
            DtgDiario.DataBind()
            can = objinformes.Cantidad
            If can = 0 Then
                lblmsg.Text = "No se encontraron datos"
                DtgDiario.DataSource = Nothing
                DtgDiario.DataBind()
                Exit Sub
            Else
                BtnExpo.Visible = True
            End If
            TxtFecha_Inicio.Text = ""
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
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
            form.Controls.Add(DtgDiario)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=CasosHora.xls")
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
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Dim f1 As Int64 = 0
    Dim f2 As Int64 = 0
    Dim f3 As Int64 = 0
    Dim f4 As Int64 = 0
    Dim f5 As Int64 = 0
    Protected Sub DtgDiario_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles DtgDiario.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                f1 = f1 + DataBinder.Eval(e.Row.DataItem, fc1.Text)
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(1).Text = f1.ToString
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                f2 = f2 + DataBinder.Eval(e.Row.DataItem, fc2.Text)
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(2).Text = f2.ToString
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                f3 = f3 + DataBinder.Eval(e.Row.DataItem, fc3.Text)
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(3).Text = f3.ToString
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                f4 = f4 + DataBinder.Eval(e.Row.DataItem, fc4.Text)
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(4).Text = f4.ToString
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                f5 = f5 + DataBinder.Eval(e.Row.DataItem, fc5.Text)
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(5).Text = f5.ToString
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                DataBinder.Eval(e.Row.DataItem, "Hora")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(0).Text = "Total"
            End If
        Catch ex As Exception
            lblmsg.Text = "se presento error: " + ex.Message
        End Try

    End Sub
End Class