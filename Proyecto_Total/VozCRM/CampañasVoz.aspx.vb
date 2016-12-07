Imports System.IO

Public Class CampañasVoz
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

    Protected Sub BtnVoz_Click(sender As Object, e As EventArgs) Handles BtnVoz.Click
        Try
            Dim fsap As Date = FormatDateTime(Now.Date)
            Dim fcorta As Date
            Dim can As Integer = 0
            fcorta = fsap.AddDays(-23)
            DtgGrupo.Visible = True
            ObjInformes.Fsap = fsap
            ObjInformes.Fcorta = fcorta
            ObjInformes.Validacionn = 0
            DtgGrupo.DataSource = ObjInformes.CampañaVoz
            DtgGrupo.DataBind()
            can = ObjInformes.Cantidad
            If can = 0 Then
                lblmsg.Text = "No se encontraron datos"
                BtnExportar.Visible = False
                DtgGrupo.Visible = False
                DtgCampa.Visible = False
                lblmensa.Text = ""
                Exit Sub
            Else
                lblmensa.Text = "CONSOLIDADO VOZ"
                BtnExportar.Visible = True
                DtgCampa.Visible = False
            End If
            lblmsg.Text = ""

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Dim Abier As Int64 = 0
    Dim Cerrado As Int64 = 0
    Dim escalado As Int64 = 0
    Dim Gestionado As Int64 = 0
    Dim ILOCALIZABLE As Int64 = 0
    Dim NoDis As Int64 = 0
    Dim rechazado As Int64 = 0
    Dim Total As Int64 = 0
    Dim Pendi As Int64 = 0
    Dim Porcen As Double = 0
    Protected Sub DtgGrupo_RowDataBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs) Handles DtgGrupo.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Abier += DataBinder.Eval(e.Row.DataItem, "Abierto")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(2).Text = Abier
            End If
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Cerrado = Cerrado + DataBinder.Eval(e.Row.DataItem, "Cerrado")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(3).Text = Cerrado
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                escalado = escalado + DataBinder.Eval(e.Row.DataItem, "Escalado")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(4).Text = escalado
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Gestionado = Gestionado + DataBinder.Eval(e.Row.DataItem, "Gestionado")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(5).Text = Gestionado
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                ILOCALIZABLE = ILOCALIZABLE + DataBinder.Eval(e.Row.DataItem, "ILOCALIZABLE")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(6).Text = ILOCALIZABLE
            End If
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                NoDis = NoDis + DataBinder.Eval(e.Row.DataItem, "No Disponible")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(7).Text = NoDis
            End If
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                rechazado = rechazado + DataBinder.Eval(e.Row.DataItem, "Rechazado")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(8).Text = rechazado
            End If
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Total = Total + DataBinder.Eval(e.Row.DataItem, "Total")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(9).Text = Total
            End If
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Pendi = Pendi + DataBinder.Eval(e.Row.DataItem, "Pendientes")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(10).Text = Pendi
            End If
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Porcen = Porcen + DataBinder.Eval(e.Row.DataItem, "Porcentaje")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(11).Text = Porcen & "%"
            End If
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                DataBinder.Eval(e.Row.DataItem, "Fecha_Corta")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(1).Text = "Total General"
            End If
        Catch ex As Exception
            lblmsg.Text = "se presento error: " + ex.Message
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
            form.Controls.Add(DtgGrupo)
            form.Controls.Add(DtgCampa)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=CampañaVoz.xls")
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
            Dim fsap As Date = FormatDateTime(Now.Date)
            Dim fcorta As Date
            Dim can As Integer = 0
            fcorta = fsap.AddDays(-23)
            'fsap = fsap.AddDays(-1)
            If DrpCampa.SelectedValue = 0 Then
                lblmsg.Text = "Consulte por una campaña"
                BtnExportar.Visible = False
                DrpCampa.SelectedIndex = 0
                DtgCampa.Visible = False
                DtgGrupo.Visible = False
                lblmensa.Text = ""
                Exit Sub
            End If

            If DrpCampa.SelectedValue <> 0 Then
                DtgCampa.Visible = True
                If DrpCampa.SelectedValue = 1 Or DrpCampa.SelectedValue = 2 Or DrpCampa.SelectedValue = 3 Or DrpCampa.SelectedValue = 4 Or DrpCampa.SelectedValue = 5 Then
                    lblmensa.Text = DrpCampa.SelectedItem.Text
                    ObjInformes.Campa = DrpCampa.SelectedItem.Text
                    ObjInformes.Fsap = fsap
                    ObjInformes.Fcorta = fcorta
                    ObjInformes.Validacionn = 1
                    DtgCampa.DataSource = ObjInformes.CampañaVoz
                    DtgCampa.DataBind()
                    can = ObjInformes.Cantidad
                    If can = 0 Then
                        lblmsg.Text = "No se encontraron datos"
                        BtnExportar.Visible = False
                        DrpCampa.SelectedIndex = 0
                        DtgCampa.Visible = False
                        DtgGrupo.Visible = False
                        lblmensa.Text = ""
                        Exit Sub
                    Else
                        BtnExportar.Visible = True
                        DtgGrupo.Visible = False
                    End If
                End If
                If DrpCampa.SelectedValue = 6 Then
                    lblmensa.Text = DrpCampa.SelectedItem.Text
                    ObjInformes.Fsap = fsap
                    ObjInformes.Fcorta = fcorta
                    ObjInformes.Validacionn = 2
                    DtgCampa.DataSource = ObjInformes.CampañaVoz
                    DtgCampa.DataBind()
                    can = ObjInformes.Cantidad
                    If can = 0 Then
                        lblmsg.Text = "No se encontraron datos"
                        BtnExportar.Visible = False
                        DrpCampa.SelectedIndex = 0
                        DtgCampa.Visible = False
                        DtgGrupo.Visible = False
                        lblmensa.Text = ""
                        Exit Sub
                    Else
                        BtnExportar.Visible = True
                        DtgGrupo.Visible = False
                    End If
                End If
                If DrpCampa.SelectedValue = 7 Then
                    lblmensa.Text = DrpCampa.SelectedItem.Text
                    ObjInformes.Fsap = fsap
                    ObjInformes.Fcorta = fcorta
                    ObjInformes.Validacionn = 3
                    DtgCampa.DataSource = ObjInformes.CampañaVoz
                    DtgCampa.DataBind()
                    can = ObjInformes.Cantidad
                    If can = 0 Then
                        lblmsg.Text = "No se encontraron datos"
                        BtnExportar.Visible = False
                        DrpCampa.SelectedIndex = 0
                        DtgCampa.Visible = False
                        DtgGrupo.Visible = False
                        lblmensa.Text = ""
                        Exit Sub
                    Else
                        BtnExportar.Visible = True
                        DtgGrupo.Visible = False
                    End If
                End If
            End If

            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub DtgCampa_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles DtgCampa.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Abier += DataBinder.Eval(e.Row.DataItem, "Abierto")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(3).Text = Abier
            End If
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Cerrado = Cerrado + DataBinder.Eval(e.Row.DataItem, "Cerrado")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(4).Text = Cerrado
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                escalado = escalado + DataBinder.Eval(e.Row.DataItem, "Escalado")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(5).Text = escalado
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Gestionado = Gestionado + DataBinder.Eval(e.Row.DataItem, "Gestionado")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(6).Text = Gestionado
            End If

            If (e.Row.RowType = DataControlRowType.DataRow) Then
                ILOCALIZABLE = ILOCALIZABLE + DataBinder.Eval(e.Row.DataItem, "ILOCALIZABLE")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(7).Text = ILOCALIZABLE
            End If
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                NoDis = NoDis + DataBinder.Eval(e.Row.DataItem, "No Disponible")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(8).Text = NoDis
            End If
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                rechazado = rechazado + DataBinder.Eval(e.Row.DataItem, "Rechazado")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(9).Text = rechazado
            End If
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Total = Total + DataBinder.Eval(e.Row.DataItem, "Total")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(10).Text = Total
            End If
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Pendi = Pendi + DataBinder.Eval(e.Row.DataItem, "Pendientes")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(11).Text = Pendi
            End If
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Porcen = Porcen + DataBinder.Eval(e.Row.DataItem, "Porcentaje")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(12).Text = Porcen & "%"
            End If
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                DataBinder.Eval(e.Row.DataItem, "Fecha_Corta")
            ElseIf (e.Row.RowType = DataControlRowType.Footer) Then
                e.Row.Cells(2).Text = "Total General"
            End If
        Catch ex As Exception
            lblmsg.Text = "se presento error: " + ex.Message
        End Try
    End Sub
End Class