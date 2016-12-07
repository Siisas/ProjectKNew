Imports System.IO

Public Class Encuesta611Voz
    Inherits System.Web.UI.Page
    Dim ObjInformes As New clsInformes
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
    End Sub

    Protected Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim dts As New DataSet
            PnlEncuesta.Visible = True
            If TxtFecha_Inicio.Text <> "" And TxtFecha_Fin.Text <> "" Then
                ObjInformes.fcini = TxtFecha_Inicio.Text
                ObjInformes.fcfin = TxtFecha_Fin.Text
                dtggeneral.DataSource = ObjInformes.Consulta_611
                dtggeneral.DataBind()
                Lblfecf.Text = TxtFecha_Fin.Text
                Lblfeci.Text = TxtFecha_Inicio.Text
                lblcantgral.Text = ObjInformes.Cantidad
                dts = ObjInformes.Consulta_611
                Dim fcfin As New Date
                Dim fcini As New Date
                fcfin = TxtFecha_Fin.Text
                fcini = TxtFecha_Inicio.Text

                If fcfin < fcini Then
                    lblmsg.Text = "Verifique que Fecha Inicio sea menor a Fecha Fin"
                    PnlEncuesta.Visible = False
                    TxtFecha_Fin.Text = ""
                    TxtFecha_Inicio.Text = ""
                    lblcantgral.Text = ""
                    Exit Sub
                End If

                If lblcantgral.Text = 0 Or lblcantgral.Text = 1 Or lblcantgral.Text = 2 Then
                    lblmsg.Text = "No se encontraron datos"
                    PnlEncuesta.Visible = False
                    TxtFecha_Fin.Text = ""
                    TxtFecha_Inicio.Text = ""
                    lblcantgral.Text = ""
                    Exit Sub
                Else
                    LblEti1.Text = dts.Tables(0).Rows(0).Item("Etiquetas de fila")
                    If dts.Tables(0).Rows(1).Item("Etiquetas de fila") = "NS/NR" Then
                        LblEti2.Text = "N/R"
                    End If
                    LblEti3.Text = dts.Tables(0).Rows(2).Item("Etiquetas de fila")
                End If

                If dts.Tables(0).Rows(0).Item("Respuestas") <> Nothing Then
                    LblRes1.Text = dts.Tables(0).Rows(0).Item("Respuestas")
                    LblRes2.Text = dts.Tables(0).Rows(1).Item("Respuestas")
                    LblRes3.Text = dts.Tables(0).Rows(2).Item("Respuestas")
                Else
                    lblmsg.Text = "No se encontraron datos"
                    lblcantgral.Text = ""
                    TxtFecha_Fin.Text = ""
                    TxtFecha_Inicio.Text = ""
                    Exit Sub
                End If
                Dim por1 As Double
                Dim por2 As Double
                Dim por3 As Double
                If dts.Tables(0).Rows(0).Item("Porcentaje_SI") <> Nothing Then
                    por3 = dts.Tables(0).Rows(0).Item("Porcentaje_SI")
                    LblPor3.Text = Math.Round(por3, 2) & "%"
                End If
                If dts.Tables(0).Rows(0).Item("Porcentaje_NO") <> Nothing Then
                    por1 = dts.Tables(0).Rows(0).Item("Porcentaje_NO")
                    LblPor1.Text = Math.Round(por1, 2) & "%"
                End If
                If dts.Tables(0).Rows(0).Item("Porcentaje_N/R") <> Nothing Then
                    por2 = dts.Tables(0).Rows(0).Item("Porcentaje_N/R")
                    LblPor2.Text = Math.Round(por2, 2) & "%"
                End If


                If dts.Tables(0).Rows(0).Item("Total") <> Nothing Then
                    LblResTot.Text = dts.Tables(0).Rows(0).Item("Total")
                End If
                If dts.Tables(0).Rows(0).Item("Porcentaje_Total") <> Nothing Then
                    LblPorTot.Text = dts.Tables(0).Rows(0).Item("Porcentaje_Total")
                End If
                'LblPorTot.Text = Val(LblPor1.Text) + Val(LblPor2.Text) + Val(LblPor3.Text) & "%"
                'LblPorTot.Text = LblPor1.Text + LblPor2.Text + LblPor3.Text & "%"
            Else
                lblmsg.Text = "Digite el rango de fechas"
                PnlEncuesta.Visible = False
                lblcantgral.Text = ""
                TxtFecha_Fin.Text = ""
                TxtFecha_Inicio.Text = ""
                Exit Sub
            End If
            TxtFecha_Inicio.Text = ""
            TxtFecha_Fin.Text = ""
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Public Sub Cargar_Datos()
        Try
            Dim dt As New DataTable()
            'columnas
            dt.Columns.Add("Etiqueta de fila")
            dt.Columns.Add("Porcentaje")
            dt.Columns.Add("Respuesta")


            Dim row As DataRow = dt.NewRow()
            row("Etiqueta de fila") = LblEti1.Text
            row("Porcentaje") = LblPor1.Text()
            row("Respuesta") = LblRes1.Text
            dt.Rows.Add(row)

            Dim row1 As DataRow = dt.NewRow()
            row1("Etiqueta de fila") = LblEti2.Text
            row1("Porcentaje") = LblPor2.Text()
            row1("Respuesta") = LblRes2.Text
            dt.Rows.Add(row1)

            Dim row2 As DataRow = dt.NewRow()
            row2("Etiqueta de fila") = LblEti3.Text
            row2("Porcentaje") = LblPor3.Text()
            row2("Respuesta") = LblRes3.Text
            dt.Rows.Add(row2)

            Dim row3 As DataRow = dt.NewRow()
            row3("Etiqueta de fila") = "TOTAL"
            row3("Porcentaje") = LblPorTot.Text()
            row3("Respuesta") = LblResTot.Text
            dt.Rows.Add(row3)

            'enlazas datatable a griedview
            dtggeneralPorcentajes.DataSource = dt
            dtggeneralPorcentajes.DataBind()

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
            form.Controls.Add(dtggeneralPorcentajes)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=611_voz:" + Lblfeci.Text + "-" + Lblfecf.Text + ".xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Try
            Cargar_Datos()
            Exportarxls()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
End Class