Imports System.IO

Public Class Acumulado_Voz
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
            Dim porcen As Double
            ObjInforme.Fcini = TxtFecha_Inicio.Text
            ObjInforme.Fcfin = TxtFecha_Fin.Text
            lblFcini.Text = ObjInforme.Fcini
            lblFcfin.Text = ObjInforme.Fcfin
            ObjInforme.Validacionn = "Voz"
            dts = ObjInforme.Consulta_Total_Voz()
            If dts.Tables(0).Rows(0).Item("Cantidad") Is System.DBNull.Value Then
                lblTlvoz.Text = ""
            Else
                lblTlvoz.Text = dts.Tables(0).Rows(0).Item("Cantidad")
            End If

            ObjInforme.Validacionn = "Otros"
            dts = ObjInforme.Consulta_Total_Voz()
            If dts.Tables(0).Rows(0).Item("Cantidad") Is System.DBNull.Value Then
                lblTlotros.Text = ""
            Else
                lblTlotros.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                lblTlcasos.Text = (Val(lblTlvoz.Text) + Val(lblTlotros.Text))
            End If

            ObjInforme.Validacionn = "Vozred"
            dts = ObjInforme.Consulta_Total_Voz()
            If dts.Tables(0).Rows(0).Item("Cantidad") Is System.DBNull.Value Then
                lblvozred.Text = ""
            Else
                lblvozred.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                porcen = (Val(lblvozred.Text) / Val(lblTlvoz.Text))
                lblporvoz.Text = Math.Round(porcen, 3) * (100) & " % "
            End If

            ObjInforme.Validacionn = "Otrosred"
            dts = ObjInforme.Consulta_Total_Voz()
            If dts.Tables(0).Rows(0).Item("Cantidad") Is System.DBNull.Value Then
                lblotrosred.Text = ""
            Else
                lblotrosred.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                lblTlred.Text = (Val(lblvozred.Text) + Val(lblotrosred.Text))
                porcen = (Val(lblotrosred.Text) / Val(lblTlotros.Text))
                lblporotros.Text = Math.Round(porcen, 3) * (100) & " % "
            End If

            ObjInforme.Validacionn = "2G"
            dts = ObjInforme.Consulta_Total_Voz()
            If dts.Tables(0).Rows(0).Item("Cantidad") Is System.DBNull.Value Then
                lblTec2g.Text = ""
            Else
                lblTec2g.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                porcen = (Val(lblTec2g.Text) / Val(lblTlvoz.Text))
                lblporcen2g.Text = Math.Round(porcen, 3) * (100) & " % "
            End If

            ObjInforme.Validacionn = "3G"
            dts = ObjInforme.Consulta_Total_Voz()
            If dts.Tables(0).Rows(0).Item("Cantidad") Is System.DBNull.Value Then
                lblTec3g.Text = ""
            Else
                lblTec3g.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                porcen = (Val(lblTec3g.Text) / Val(lblTlvoz.Text))
                lblporcen3g.Text = Math.Round(porcen, 3) * (100) & " % "
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
            dt.Columns.Add("INGRESOS_MESA_SOPORTE")
            dt.Columns.Add("TOTAL_CASOS")
            dt.Columns.Add("ASOCIADOS_RED")
            dt.Columns.Add("Porcentaje_red")
            dt.Columns.Add("TECN_2G")
            dt.Columns.Add("Porcentaje_2g")
            dt.Columns.Add("TECN_3G")
            dt.Columns.Add("Porcentaje_3g")

            Dim row As DataRow = dt.NewRow()
            row("INGRESOS_MESA_SOPORTE") = lblVOZ.Text
            row("TOTAL_CASOS") = lblTlvoz.Text
            row("ASOCIADOS_RED") = lblvozred.Text
            row("Porcentaje_red") = lblporvoz.Text
            row("TECN_2G") = lblTec2g.Text
            row("Porcentaje_2g") = lblporcen2g.Text
            row("TECN_3G") = lblTec3g.Text
            row("Porcentaje_3g") = lblporcen3g.Text
            dt.Rows.Add(row)

            Dim row1 As DataRow = dt.NewRow()
            row1("INGRESOS_MESA_SOPORTE") = lblotros.Text
            row1("TOTAL_CASOS") = lblTlotros.Text
            row1("ASOCIADOS_RED") = lblotrosred.Text
            row1("Porcentaje_red") = lblporotros.Text
            row1("TECN_2G") = ""
            row1("Porcentaje_2g") = ""
            row1("TECN_3G") = ""
            row1("Porcentaje_3g") = ""
            dt.Rows.Add(row1)

            Dim row2 As DataRow = dt.NewRow()
            row2("INGRESOS_MESA_SOPORTE") = lblTotal.Text
            row2("TOTAL_CASOS") = lblTlcasos.Text
            row2("ASOCIADOS_RED") = lblTlred.Text
            row2("Porcentaje_red") = " "
            row2("TECN_2G") = " "
            row2("Porcentaje_2g") = " "
            row2("TECN_3G") = ""
            row2("Porcentaje_3g") = " "
            dt.Rows.Add(row2)

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
            Response.AddHeader("Content-Disposition", "attachment;filename=Acumulado_voz.xls")
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