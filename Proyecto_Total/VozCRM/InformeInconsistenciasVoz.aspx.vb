Imports System.IO

Public Class InformeInconsistenciasVoz
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

    Protected Sub Colsultar_Click(sender As Object, e As EventArgs) Handles Colsultar.Click
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

            Dim dts As New DataSet
            ObjInforme.Fcini = TxtFecha_Inicio.Text
            ObjInforme.Fcfin = TxtFecha_Fin.Text
            dts = ObjInforme.ConsultaDiaVoz()
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("fcreg") Is System.DBNull.Value Then
                    lblFecha1.Text = ""
                Else
                    lblFecha1.Text = dts.Tables(0).Rows(0).Item("fcreg")
                End If
                If dts.Tables(0).Rows(0).Item("Cantidad") Is System.DBNull.Value Then
                    lblInco1.Text = ""
                Else
                    lblInco1.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                    lblTotalinco.Text = (Integer.Parse(lblInco1.Text))
                End If
            Else
                lblFecha1.Text = ""
                lblFecha2.Text = ""
                lblFecha3.Text = ""
            End If

            If dts.Tables(0).Rows.Count > 1 Then
                If dts.Tables(0).Rows(1).Item("fcreg") Is System.DBNull.Value Then
                    lblFecha2.Text = ""
                Else
                    lblFecha2.Text = dts.Tables(0).Rows(1).Item("fcreg")
                End If
                If dts.Tables(0).Rows(1).Item("Cantidad") Is System.DBNull.Value Then
                    lblInco2.Text = ""
                Else
                    lblInco2.Text = dts.Tables(0).Rows(1).Item("Cantidad")
                    lblTotalinco.Text = (Integer.Parse(lblInco1.Text) + Integer.Parse(lblInco2.Text))
                End If
            Else
                lblFecha2.Text = ""
                lblFecha3.Text = ""
                lblFecha4.Text = ""
                lblFecha5.Text = ""
                lblFecha6.Text = ""
                lblFecha7.Text = ""
                lblInco2.Text = ""
                lblInco3.Text = ""
                lblInco4.Text = ""
                lblInco5.Text = ""
                lblInco6.Text = ""
                lblInco7.Text = ""
            End If

            If dts.Tables(0).Rows.Count > 2 Then
                If dts.Tables(0).Rows(2).Item("fcreg") Is System.DBNull.Value Then
                    lblFecha3.Text = ""
                Else
                    lblFecha3.Text = dts.Tables(0).Rows(2).Item("fcreg")
                End If
                If dts.Tables(0).Rows(2).Item("Cantidad") Is System.DBNull.Value Then
                    lblInco3.Text = ""
                Else
                    lblInco3.Text = dts.Tables(0).Rows(2).Item("Cantidad")
                    lblTotalinco.Text = (Integer.Parse(lblInco1.Text) + Integer.Parse(lblInco2.Text) + Integer.Parse(lblInco3.Text))
                End If
            Else
                lblFecha3.Text = ""
                lblFecha4.Text = ""
                lblFecha5.Text = ""
                lblFecha6.Text = ""
                lblFecha7.Text = ""
                lblInco3.Text = ""
                lblInco4.Text = ""
                lblInco5.Text = ""
                lblInco6.Text = ""
                lblInco7.Text = ""
            End If
            If dts.Tables(0).Rows.Count > 3 Then
                If dts.Tables(0).Rows(3).Item("fcreg") Is System.DBNull.Value Then
                    lblFecha4.Text = ""
                Else
                    lblFecha4.Text = dts.Tables(0).Rows(3).Item("fcreg")
                End If
                If dts.Tables(0).Rows(3).Item("Cantidad") Is System.DBNull.Value Then
                    lblInco4.Text = ""
                Else
                    lblInco4.Text = dts.Tables(0).Rows(3).Item("Cantidad")
                    lblTotalinco.Text = (Integer.Parse(lblInco1.Text) + Integer.Parse(lblInco2.Text) + Integer.Parse(lblInco3.Text) + Integer.Parse(lblInco4.Text))
                End If
            Else
                lblFecha4.Text = ""
                lblFecha5.Text = ""
                lblFecha6.Text = ""
                lblFecha7.Text = ""
                lblInco4.Text = ""
                lblInco5.Text = ""
                lblInco6.Text = ""
                lblInco7.Text = ""
            End If
            If dts.Tables(0).Rows.Count > 4 Then
                If dts.Tables(0).Rows(4).Item("fcreg") Is System.DBNull.Value Then
                    lblFecha5.Text = ""
                Else
                    lblFecha5.Text = dts.Tables(0).Rows(4).Item("fcreg")
                End If
                If dts.Tables(0).Rows(4).Item("Cantidad") Is System.DBNull.Value Then
                    lblInco5.Text = ""
                Else
                    lblInco5.Text = dts.Tables(0).Rows(4).Item("Cantidad")
                    lblTotalinco.Text = (Integer.Parse(lblInco1.Text) + Integer.Parse(lblInco2.Text) + Integer.Parse(lblInco3.Text) + Integer.Parse(lblInco4.Text) + Integer.Parse(lblInco5.Text))
                End If
            Else
                lblFecha5.Text = ""
                lblFecha6.Text = ""
                lblFecha7.Text = ""
                lblInco5.Text = ""
                lblInco6.Text = ""
                lblInco7.Text = ""
            End If
            If dts.Tables(0).Rows.Count > 5 Then
                If dts.Tables(0).Rows(5).Item("fcreg") Is System.DBNull.Value Then
                    lblFecha6.Text = ""
                Else
                    lblFecha6.Text = dts.Tables(0).Rows(5).Item("fcreg")
                End If
                If dts.Tables(0).Rows(5).Item("Cantidad") Is System.DBNull.Value Then
                    lblInco6.Text = ""
                Else
                    lblInco6.Text = dts.Tables(0).Rows(5).Item("Cantidad")
                    lblTotalinco.Text = (Integer.Parse(lblInco1.Text) + Integer.Parse(lblInco2.Text) + Integer.Parse(lblInco3.Text) + Integer.Parse(lblInco4.Text) + Integer.Parse(lblInco5.Text) + Integer.Parse(lblInco6.Text))
                End If
            Else
                lblFecha6.Text = ""
                lblFecha7.Text = ""
                lblInco6.Text = ""
                lblInco7.Text = ""
            End If
            If dts.Tables(0).Rows.Count > 6 Then
                If dts.Tables(0).Rows(6).Item("fcreg") Is System.DBNull.Value Then
                    lblFecha7.Text = ""
                Else
                    lblFecha7.Text = dts.Tables(0).Rows(6).Item("fcreg")
                End If
                If dts.Tables(0).Rows(6).Item("Cantidad") Is System.DBNull.Value Then
                    lblInco7.Text = ""
                Else
                    lblInco7.Text = dts.Tables(0).Rows(6).Item("Cantidad")
                    lblTotalinco.Text = (Integer.Parse(lblInco1.Text) + Integer.Parse(lblInco2.Text) + Integer.Parse(lblInco3.Text) + Integer.Parse(lblInco4.Text) + Integer.Parse(lblInco5.Text) + Integer.Parse(lblInco6.Text) + Integer.Parse(lblInco7.Text))
                End If
            Else
                lblFecha7.Text = ""
                lblInco7.Text = ""
            End If

            dts = ObjInforme.ConsultaInconsisVoz()
            Dim porcen As Double
            Dim Tltporcen As Double
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Total de idcaso") Is System.DBNull.Value Then
                    lblGes1.Text = ""
                Else
                    lblGes1.Text = dts.Tables(0).Rows(0).Item("Total de idcaso")
                    lblTotalges.Text = Val(lblGes1.Text)
                    porcen = (Val(lblInco1.Text) / Val(lblGes1.Text))
                    lblporcen1.Text = Math.Round(porcen, 2) * (100) & " % "
                    Tltporcen = (Val(lblTotalinco.Text) / Val(lblTotalges.Text))
                    lblTotalpor.Text = Math.Round(Tltporcen, 2) * (100) & " % "
                End If
            Else
                lblGes1.Text = ""
                lblGes2.Text = ""
                lblGes3.Text = ""
                lblGes4.Text = ""
                lblGes5.Text = ""
                lblGes6.Text = ""
                lblGes7.Text = ""
                lblporcen1.Text = ""
            End If
            If dts.Tables(0).Rows.Count > 1 Then
                If dts.Tables(0).Rows(1).Item("Total de idcaso") Is System.DBNull.Value Then
                    lblGes2.Text = ""
                Else
                    lblGes2.Text = dts.Tables(0).Rows(1).Item("Total de idcaso")
                    lblTotalges.Text = (Val(lblGes1.Text) + Val(lblGes2.Text))
                    porcen = (Val(lblInco2.Text) / Val(lblGes2.Text))
                    lblporcen2.Text = Math.Round(porcen, 2) * (100) & " % "
                    Tltporcen = (Val(lblTotalinco.Text) / Val(lblTotalges.Text))
                    lblTotalpor.Text = Math.Round(Tltporcen, 2) * (100) & " % "
                End If
            Else
                lblGes2.Text = ""
                lblGes3.Text = ""
                lblGes4.Text = ""
                lblGes5.Text = ""
                lblGes6.Text = ""
                lblGes7.Text = ""
                lblporcen2.Text = ""
            End If
            If dts.Tables(0).Rows.Count > 2 Then
                If dts.Tables(0).Rows(2).Item("Total de idcaso") Is System.DBNull.Value Then
                    lblGes3.Text = ""
                Else
                    lblGes3.Text = dts.Tables(0).Rows(2).Item("Total de idcaso")
                    lblTotalges.Text = (Val(lblGes1.Text) + Val(lblGes2.Text) + Val(lblGes3.Text))
                    porcen = (Val(lblInco3.Text) / Val(lblGes3.Text))
                    lblporcen3.Text = Math.Round(porcen, 2) * (100) & " % "
                    Tltporcen = (Val(lblTotalinco.Text) / Val(lblTotalges.Text))
                    lblTotalpor.Text = Math.Round(Tltporcen, 2) * (100) & " % "
                End If
            Else
                lblGes3.Text = ""
                lblGes4.Text = ""
                lblGes5.Text = ""
                lblGes6.Text = ""
                lblGes7.Text = ""
                lblporcen3.Text = ""
            End If
            If dts.Tables(0).Rows.Count > 3 Then
                If dts.Tables(0).Rows(3).Item("Total de idcaso") Is System.DBNull.Value Then
                    lblGes4.Text = ""
                Else
                    lblGes4.Text = dts.Tables(0).Rows(3).Item("Total de idcaso")
                    lblTotalges.Text = (Val(lblGes1.Text) + Val(lblGes2.Text) + Val(lblGes3.Text) + Val(lblGes4.Text))
                    porcen = (Val(lblInco4.Text) / Val(lblGes4.Text))
                    lblporcen4.Text = Math.Round(porcen, 2) * (100) & " % "
                    Tltporcen = (Val(lblTotalinco.Text) / Val(lblTotalges.Text))
                    lblTotalpor.Text = Math.Round(Tltporcen, 2) * (100) & " % "
                End If
            Else
                lblGes4.Text = ""
                lblGes5.Text = ""
                lblGes6.Text = ""
                lblGes7.Text = ""
                lblporcen4.Text = ""
            End If
            If dts.Tables(0).Rows.Count > 4 Then
                If dts.Tables(0).Rows(4).Item("Total de idcaso") Is System.DBNull.Value Then
                    lblGes5.Text = ""
                Else
                    lblGes5.Text = dts.Tables(0).Rows(4).Item("Total de idcaso")
                    lblTotalges.Text = (Val(lblGes1.Text) + Val(lblGes2.Text) + Val(lblGes3.Text) + Val(lblGes4.Text) + Val(lblGes5.Text))
                    porcen = (Val(lblInco5.Text) / Val(lblGes5.Text))
                    lblporcen5.Text = Math.Round(porcen, 2) * (100) & " % "
                    Tltporcen = (Val(lblTotalinco.Text) / Val(lblTotalges.Text))
                    lblTotalpor.Text = Math.Round(Tltporcen, 2) * (100) & " % "
                End If
            Else
                lblGes5.Text = ""
                lblGes6.Text = ""
                lblGes7.Text = ""
                lblporcen5.Text = ""
            End If
            If dts.Tables(0).Rows.Count > 5 Then
                If dts.Tables(0).Rows(5).Item("Total de idcaso") Is System.DBNull.Value Then
                    lblGes6.Text = ""
                Else
                    lblGes6.Text = dts.Tables(0).Rows(5).Item("Total de idcaso")
                    lblTotalges.Text = (Val(lblGes1.Text) + Val(lblGes2.Text) + Val(lblGes3.Text) + Val(lblGes4.Text) + Val(lblGes5.Text) + Val(lblGes6.Text))
                    porcen = (Val(lblInco6.Text) / Val(lblGes6.Text))
                    lblporcen6.Text = Math.Round(porcen, 2) * (100) & " % "
                    Tltporcen = (Val(lblTotalinco.Text) / Val(lblTotalges.Text))
                    lblTotalpor.Text = Math.Round(Tltporcen, 2) * (100) & " % "
                End If
            Else
                lblGes6.Text = ""
                lblGes7.Text = ""
                lblporcen6.Text = ""
            End If
            If dts.Tables(0).Rows.Count > 6 Then
                If dts.Tables(0).Rows(6).Item("Total de idcaso") Is System.DBNull.Value Then
                    lblGes7.Text = ""
                Else
                    lblGes7.Text = dts.Tables(0).Rows(6).Item("Total de idcaso")
                    lblTotalges.Text = (Val(lblGes1.Text) + Val(lblGes2.Text) + Val(lblGes3.Text) + Val(lblGes4.Text) + Val(lblGes5.Text) + Val(lblGes6.Text) + Val(lblGes7.Text))
                    porcen = (Val(lblInco7.Text) / Val(lblGes7.Text))
                    lblporcen7.Text = Math.Round(porcen, 2) * (100) & " % "
                    Tltporcen = (Val(lblTotalinco.Text) / Val(lblTotalges.Text))
                    lblTotalpor.Text = Math.Round(porcen, 2) * (100) & " % "
                End If
            Else
                lblGes7.Text = ""
                lblporcen7.Text = ""
            End If
            TxtFecha_Inicio.Text = ""
            TxtFecha_Fin.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub
    'CARGAR DATOS AL DATGRIDVIEW
    Public Sub Cargar_Datos()
        Try
            Dim dt As New DataTable()
            'columnas
            dt.Columns.Add("Dia")
            dt.Columns.Add("Inconsistencia")
            dt.Columns.Add("Gestion")
            dt.Columns.Add("Porcentaje")

            Dim row As DataRow = dt.NewRow()
            row("Dia") = lblFecha1.Text
            row("Inconsistencia") = lblInco1.Text
            row("Gestion") = lblGes1.Text
            row("Porcentaje") = lblporcen1.Text
            dt.Rows.Add(row)
            Dim row1 As DataRow = dt.NewRow()
            row1("Dia") = lblFecha2.Text
            row1("Inconsistencia") = lblInco2.Text
            row1("Gestion") = lblGes2.Text
            row1("Porcentaje") = lblporcen2.Text
            dt.Rows.Add(row1)
            Dim row2 As DataRow = dt.NewRow()
            row2("Dia") = lblFecha3.Text
            row2("Inconsistencia") = lblInco3.Text
            row2("Gestion") = lblGes3.Text
            row2("Porcentaje") = lblporcen3.Text
            dt.Rows.Add(row2)
            Dim row3 As DataRow = dt.NewRow()
            row3("Dia") = lblFecha4.Text
            row3("Inconsistencia") = lblInco4.Text
            row3("Gestion") = lblGes4.Text
            row3("Porcentaje") = lblporcen4.Text
            dt.Rows.Add(row3)
            Dim row4 As DataRow = dt.NewRow()
            row4("Dia") = lblFecha5.Text
            row4("Inconsistencia") = lblInco5.Text
            row4("Gestion") = lblGes5.Text
            row4("Porcentaje") = lblporcen5.Text
            dt.Rows.Add(row4)
            Dim row5 As DataRow = dt.NewRow()
            row5("Dia") = lblFecha6.Text
            row5("Inconsistencia") = lblInco6.Text
            row5("Gestion") = lblGes6.Text
            row5("Porcentaje") = lblporcen6.Text
            dt.Rows.Add(row5)
            Dim row6 As DataRow = dt.NewRow()
            row6("Dia") = lblFecha7.Text
            row6("Inconsistencia") = lblInco7.Text
            row6("Gestion") = lblGes7.Text
            row6("Porcentaje") = lblporcen7.Text
            dt.Rows.Add(row6)
            Dim row7 As DataRow = dt.NewRow()
            row7("Dia") = lblTotal.Text
            row7("Inconsistencia") = lblTotalinco.Text
            row7("Gestion") = lblTotalges.Text
            row7("Porcentaje") = lblTotalpor.Text
            dt.Rows.Add(row7)
            'enlazas datatable a griedview
            GridView1.DataSource = dt
            GridView1.DataBind()

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    'EXPORTAR A EXCEL
    Sub crearexcel()
        Try
            Cargar_Datos()

            Dim sb As New StringBuilder
            Dim sw As New StringWriter(sb)
            Dim htw As New HtmlTextWriter(sw)
            Dim pagina As Page = New Page
            Dim form = New HtmlForm
            Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"


            pagina.EnableEventValidation = False
            pagina.DesignerInitialize()
            pagina.Controls.Add(form)
            GridView1.Visible = True
            form.Controls.Add(GridView1)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True

            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=Reporte_Inconsistencias.xls")
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
            crearexcel()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
            lblmsg.ForeColor = Drawing.Color.Red
        End Try
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class