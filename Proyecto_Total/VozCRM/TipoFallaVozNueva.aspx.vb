Imports System.IO

Public Class TipoFallaVozNueva1
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
            form.Controls.Add(Dtgpersonal)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=Tipo_Falla_Voz.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
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

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim fechai As Date
            Dim fechaf As Date
            Dim fechaAct As Date = FormatDateTime(Now.Date)
            Dim cantidad As Integer = 0
            Dim dts As New DataSet
            semana = DatePart("ww", fechaAct)
            Dim cantidad2 As Integer = 0
            If TxtFecha_Inicio.Text <> Nothing Then
                fechai = TxtFecha_Inicio.Text
                ObjInformes.Fcini = fechai.AddDays(-1)

                lblmensa2.Text = "Fecha desde " & fechai
            Else
                ObjInformes.Fcini = ""
            End If
            If TxtFecha_Fin.Text <> Nothing Then
                fechaf = TxtFecha_Fin.Text
                ObjInformes.Fcfin = fechaf.AddDays(-1)

                lblmensa2.Text = "Fecha hasta " & fechaf
            Else
                ObjInformes.Fcfin = ""
            End If


            If TxtFecha_Fin.Text = "" And TxtFecha_Inicio.Text = "" Then
                lblmsg.Text = "Tiene que consultar una fecha por lo menos"
                TxtFecha_Fin.Text = ""
                TxtFecha_Inicio.Text = ""
                Exit Sub
            ElseIf TxtFecha_Fin.Text <> "" And TxtFecha_Inicio.Text <> "" Then
                lblmensa2.Text = "Fechas desde " & fechai & " hasta " & fechaf
                If fechaf < fechai Then
                    lblmsg.Text = "Verifique que fecha inicio sea menor a fecha fin"
                    TxtFecha_Fin.Text = ""
                    TxtFecha_Inicio.Text = ""
                    lblmensa2.Text = ""
                    lblcantidad.Text = ""
                    Dtgpersonal.Visible = False
                    BtnQuitar2.Visible = False
                    If DtgDiario.Visible = False Then
                        BtnExportar.Visible = False
                    Else
                        BtnExportar.Visible = True
                    End If

                    Exit Sub
                End If
            End If
            dts = ObjInformes.FallaVozNi()
            cantidad2 = ObjInformes.Cantidad
            If cantidad2 > 0 Then
                lblmensa.Visible = True
                If lblmensa.Text = "" Then
                    lblmensa.Text = "Numero de la semana actual: " & semana
                End If
                BtnExportar.Visible = True
                Dtgpersonal.Visible = True
                BtnQuitar2.Visible = True
            Else
                lblmsg.Text = "No se encontraron datos"
                Dtgpersonal.Visible = False
                BtnQuitar2.Visible = False
                BtnExportar.Visible = False
                TxtFecha_Fin.Text = ""
                TxtFecha_Inicio.Text = ""
                lblmensa2.Text = ""
                lblcantidad.Text = ""
                Exit Sub
            End If
            If dts.Tables(0).Rows(0).Item("tipoinc") Is DBNull.Value Then
                lblfallap1.Text = ""
            Else
                lblfallap1.Text = dts.Tables(0).Rows(0).Item("tipoinc")
                lbltotp1.Text = dts.Tables(0).Rows(0).Item("total")
            End If

            If dts.Tables(0).Rows(1).Item("tipoinc") Is DBNull.Value Then
                lblfallap2.Text = ""
            Else
                lblfallap2.Text = dts.Tables(0).Rows(1).Item("tipoinc")
                lbltotp2.Text = dts.Tables(0).Rows(1).Item("total")
            End If

            If dts.Tables(0).Rows(2).Item("tipoinc") Is DBNull.Value Then
                lblfallap3.Text = ""
            Else
                lblfallap3.Text = dts.Tables(0).Rows(2).Item("tipoinc")
                lbltotp3.Text = dts.Tables(0).Rows(2).Item("total")
            End If

            If dts.Tables(0).Rows(3).Item("tipoinc") Is DBNull.Value Then
                lblfallap4.Text = ""
            Else
                lblfallap4.Text = dts.Tables(0).Rows(3).Item("tipoinc")
                lbltotp4.Text = dts.Tables(0).Rows(3).Item("total")
            End If

            If dts.Tables(0).Rows(4).Item("tipoinc") Is DBNull.Value Then
                lblfallap5.Text = ""
            Else
                lblfallap5.Text = dts.Tables(0).Rows(4).Item("tipoinc")
                lbltotp5.Text = dts.Tables(0).Rows(4).Item("total")
            End If


            ObjInformes.Validacionn = 2
            If TxtFecha_Inicio.Text <> Nothing Then
                ObjInformes.Fcini = fechai.AddDays(-1)
            Else
                ObjInformes.Fcini = ""
            End If
            If TxtFecha_Fin.Text <> Nothing Then
                ObjInformes.Fcfin = fechaf.AddDays(-1)
            Else
                ObjInformes.Fcfin = ""
            End If
            ObjInformes.Validacionn = 1
            Dtgpersonal.Visible = True
            Dtgpersonal.DataSource = ObjInformes.FallaVozNu
            Dtgpersonal.DataBind()
            lblcantidad.Text = "Semanas encontradas: " & ObjInformes.Cantidad
            lblmsg.Text = ""
            TxtFecha_Fin.Text = ""
            TxtFecha_Inicio.Text = ""

        Catch ex As Exception
            lblmsg.Text = "se presento error: " + ex.Message
        End Try
    End Sub
    Dim semana As Integer = 0

    Protected Sub BtnDiaria_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDiaria.Click
        Try
            Dim fechaAct As Date = FormatDateTime(Now.Date)
            Dim nombredia As String = CDate(fechaAct).ToString("dddd")
            Dim fechaini As Date
            Dim cantidad As Integer = 0
            semana = DatePart("ww", fechaAct)
            Dim dts As New DataSet
            If nombredia = "lunes" Then
                fechaini = fechaAct.AddDays(-56)
            End If
            If nombredia = "martes" Then
                fechaini = fechaAct.AddDays(-57)
            End If
            If nombredia = "miércoles" Then
                fechaini = fechaAct.AddDays(-58)
            End If
            If nombredia = "jueves" Then
                fechaini = fechaAct.AddDays(-59)
            End If
            If nombredia = "viernes" Then
                fechaini = fechaAct.AddDays(-60)
            End If
            If nombredia = "sábado" Then
                fechaini = fechaAct.AddDays(-61)
            End If
            If nombredia = "domingo" Then
                fechaini = fechaAct.AddDays(-62)
            End If
            ObjInformes.Validacionn = 1
            ObjInformes.Fecha_inicio = fechaini.AddDays(-1)
            ObjInformes.Fecha_Fin = fechaAct.AddDays(-1)
            dts = ObjInformes.FallaVozN
            cantidad = ObjInformes.Cantidad
            If cantidad > 0 Then
                lblmensa.Visible = True
                If lblmensa.Text = "" Then
                    lblmensa.Text = "Numero de la semana actual: " & semana
                End If
                BtnExportar.Visible = True
                DtgDiario.Visible = True
                BtnQuitar.Visible = True
            Else
                lblmsg.Text = "No se encontraron datos"
                DtgDiario.Visible = False
                BtnExportar.Visible = False
                BtnQuitar.Visible = False
                lblmensa.Text = ""
                Exit Sub
            End If
            If dts.Tables(0).Rows(0).Item("tipoinc") Is DBNull.Value Then
                lblfalla1.Text = ""
                lbltot1.Text = ""
            Else
                lblfalla1.Text = dts.Tables(0).Rows(0).Item("tipoinc")
                lbltot1.Text = dts.Tables(0).Rows(0).Item("total")
            End If

            If dts.Tables(0).Rows(1).Item("tipoinc") Is DBNull.Value Then
                lblfalla2.Text = ""
                lbltot2.Text = ""
            Else
                lblfalla2.Text = dts.Tables(0).Rows(1).Item("tipoinc")
                lbltot2.Text = dts.Tables(0).Rows(1).Item("total")
            End If

            If dts.Tables(0).Rows(2).Item("tipoinc") Is DBNull.Value Then
                lblfalla3.Text = ""
                lbltot3.Text = ""
            Else
                lblfalla3.Text = dts.Tables(0).Rows(2).Item("tipoinc")
                lbltot3.Text = dts.Tables(0).Rows(2).Item("total")
            End If

            If dts.Tables(0).Rows(3).Item("tipoinc") Is DBNull.Value Then
                lblfalla4.Text = ""
                lbltot4.Text = ""
            Else
                lblfalla4.Text = dts.Tables(0).Rows(3).Item("tipoinc")
                lbltot4.Text = dts.Tables(0).Rows(3).Item("total")
            End If

            If dts.Tables(0).Rows(4).Item("tipoinc") Is DBNull.Value Then
                lblfalla5.Text = ""
                lbltot5.Text = ""
            Else
                lblfalla5.Text = dts.Tables(0).Rows(4).Item("tipoinc")
                lbltot5.Text = dts.Tables(0).Rows(4).Item("total")
            End If
            ObjInformes.Validacionn = 2
            ObjInformes.Fcini = fechaini.AddDays(-1)
            ObjInformes.Fcfin = fechaAct.AddDays(-1)
            ObjInformes.F1 = lblfalla1.Text
            ObjInformes.F2 = lblfalla2.Text
            ObjInformes.F3 = lblfalla3.Text
            ObjInformes.F4 = lblfalla4.Text
            ObjInformes.F5 = lblfalla5.Text
            DtgDiario.DataSource = ObjInformes.FallaVozN
            DtgDiario.DataBind()


            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "se presento error: " + ex.Message
        End Try
    End Sub
    Dim falla1 As Int64 = 0
    Dim falla2 As Int64 = 0
    Dim falla3 As Int64 = 0
    Dim falla4 As Int64 = 0
    Dim falla5 As Int64 = 0

    Protected Sub DtgDiario_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles DtgDiario.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                falla1 = falla1 + DataBinder.Eval(e.Row.DataItem, lblfalla1.Text)
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(1).Text = falla1.ToString
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                falla2 = falla2 + DataBinder.Eval(e.Row.DataItem, lblfalla2.Text)
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(2).Text = falla2.ToString
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                falla3 = falla3 + DataBinder.Eval(e.Row.DataItem, lblfalla3.Text)
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(3).Text = falla3.ToString
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                falla4 = falla4 + DataBinder.Eval(e.Row.DataItem, lblfalla4.Text)
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(4).Text = falla4.ToString
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                falla5 = falla5 + DataBinder.Eval(e.Row.DataItem, lblfalla5.Text)
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(5).Text = falla5.ToString
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                DataBinder.Eval(e.Row.DataItem, "Semana")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(0).Text = "Total"
            End If
        Catch ex As Exception
            lblmsg.Text = "se presento error: " + ex.Message
        End Try
    End Sub
    Dim fallap1 As Int64 = 0
    Dim fallap2 As Int64 = 0
    Dim fallap3 As Int64 = 0
    Dim fallap4 As Int64 = 0
    Dim fallap5 As Int64 = 0
    Protected Sub Dtgpersonal_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtgpersonal.RowDataBound
        Try

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                fallap1 += DataBinder.Eval(e.Row.DataItem, lblfallap1.Text)
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(1).Text = lbltotp1.Text
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                fallap2 = fallap2 + DataBinder.Eval(e.Row.DataItem, lblfallap2.Text)
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(2).Text = lbltotp2.Text
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                fallap3 = fallap3 + DataBinder.Eval(e.Row.DataItem, lblfallap3.Text)
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(3).Text = lbltotp3.Text
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                fallap4 = fallap4 + DataBinder.Eval(e.Row.DataItem, lblfallap4.Text)
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(4).Text = lbltotp4.Text
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                fallap5 = fallap5 + DataBinder.Eval(e.Row.DataItem, lblfallap5.Text)
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(5).Text = lbltotp5.Text
            End If
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                DataBinder.Eval(e.Row.DataItem, "Semana")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(0).Text = "Total"
            End If

        Catch ex As Exception
            lblmsg.Text = "se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnQuitar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnQuitar.Click
        Try
            DtgDiario.Visible = False
            BtnQuitar.Visible = False
            If Dtgpersonal.Visible = True Then
                BtnExportar.Visible = True
            Else
                BtnExportar.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnQuitar2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnQuitar2.Click
        Try
            Dtgpersonal.Visible = False
            BtnQuitar2.Visible = False
            lblmensa2.Visible = False
            lblcantidad.Visible = False
            If DtgDiario.Visible = True Then
                BtnExportar.Visible = True
            Else
                BtnExportar.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "se presento error: " + ex.Message
        End Try
    End Sub
End Class