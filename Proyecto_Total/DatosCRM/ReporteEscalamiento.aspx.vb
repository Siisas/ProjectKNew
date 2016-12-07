Imports System.IO

Public Class ReporteEscalamiento1
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

    Protected Sub BtnExpo_Click(sender As Object, e As EventArgs) Handles BtnExpo.Click
        Try
            If Escala.Visible = True Then
                Exportar()
                ExportarDimen()

                Exportarxls()
            Else
                lblmsg.Text = "No se encuentran datos"
                Exit Sub
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
            form.Controls.Add(DtgEscalamiento)
            form.Controls.Add(DtgDimen)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=ReporteEscalamiento.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub Exportar()
        Try
            Dim dt As New DataTable()
            'columnas
            dt.Columns.Add("Fecha Registro")
            dt.Columns.Add("Escalamiento Voz")
            dt.Columns.Add("Escalamiento Datos")
            dt.Columns.Add("Fallatec Voz")
            dt.Columns.Add("Fallatec Datos")
            dt.Columns.Add("Ilocalizable voz")
            dt.Columns.Add("Ilocalizable Datos")
            dt.Columns.Add("Seguimiento Voz")
            dt.Columns.Add("Seguimiento Datos")
            dt.Columns.Add("Revision Voz")
            dt.Columns.Add("Revision Datos")
            dt.Columns.Add("Service Voz")
            dt.Columns.Add("Service Datos")
            dt.Columns.Add("Formatos")
            dt.Columns.Add("Municipios")
            dt.Columns.Add("Observacion")



            Dim row As DataRow = dt.NewRow()
            row("Fecha Registro") = LblFecha1.Text
            row("Escalamiento Voz") = LblEscVozfc1.Text
            row("Escalamiento Datos") = LblEscDatfc1.Text
            row("Fallatec Voz") = LblFallVozfc1.Text
            row("Fallatec Datos") = LblFallDatfc1.Text
            row("Ilocalizable voz") = LblIloVfc1.Text
            row("Ilocalizable Datos") = LblIloDfc1.Text
            row("Seguimiento Voz") = LblSegV1.Text
            row("Seguimiento Datos") = LblSegD1.Text
            row("Revision Voz") = LblRevV1.Text
            row("Revision Datos") = LblRevD1.Text
            row("Service Voz") = LblSerV1.Text
            row("Service Datos") = LblSerD1.Text
            row("Formatos") = LblOtr1.Text
            row("Municipios") = LblObs1.Text
            dt.Rows.Add(row)

            Dim row1 As DataRow = dt.NewRow()
            row1("Fecha Registro") = LblFecha2.Text
            row1("Escalamiento Voz") = LblEscVozfc2.Text
            row1("Escalamiento Datos") = LblEscDatfc2.Text
            row1("Fallatec Voz") = LblFallVozfc2.Text
            row1("Fallatec Datos") = LblFallDatfc2.Text
            row1("Ilocalizable voz") = LblIloVfc2.Text
            row1("Ilocalizable Datos") = LblIloDfc2.Text
            row1("Seguimiento Voz") = LblSegV2.Text
            row1("Seguimiento Datos") = LblSegD2.Text
            row1("Revision Voz") = LblRevV2.Text
            row1("Revision Datos") = LblRevD2.Text
            row1("Service Voz") = LblSerV2.Text
            row1("Service Datos") = LblSerD2.Text
            row1("Formatos") = LblOtr2.Text
            row1("Municipios") = LblObs2.Text

            dt.Rows.Add(row1)

            Dim row2 As DataRow = dt.NewRow()
            row2("Fecha Registro") = LblFecha3.Text
            row2("Escalamiento Voz") = LblEscVozfc3.Text
            row2("Escalamiento Datos") = LblEscDatfc3.Text
            row2("Fallatec Voz") = LblFallVozfc3.Text
            row2("Fallatec Datos") = LblFallDatfc3.Text
            row2("Ilocalizable voz") = LblIloVfc3.Text
            row2("Ilocalizable Datos") = LblIloDfc3.Text
            row2("Seguimiento Voz") = LblSegV3.Text
            row2("Seguimiento Datos") = LblSegD3.Text
            row2("Revision Voz") = LblRevV3.Text
            row2("Revision Datos") = LblRevD3.Text
            row2("Service Voz") = LblSerV3.Text
            row2("Service Datos") = LblSerD3.Text
            row2("Formatos") = LblOtr3.Text
            row2("Municipios") = LblObs3.Text

            dt.Rows.Add(row2)

            Dim row3 As DataRow = dt.NewRow()
            row3("Fecha Registro") = LblFecha4.Text
            row3("Escalamiento Voz") = LblEscVozfc4.Text
            row3("Escalamiento Datos") = LblEscDatfc4.Text
            row3("Fallatec Voz") = LblFallVozfc4.Text
            row3("Fallatec Datos") = LblFallDatfc4.Text
            row3("Ilocalizable voz") = LblIloVfc4.Text
            row3("Ilocalizable Datos") = LblIloDfc4.Text
            row3("Seguimiento Voz") = LblSegV4.Text
            row3("Seguimiento Datos") = LblSegD4.Text
            row3("Revision Voz") = LblRevV4.Text
            row3("Revision Datos") = LblRevD4.Text
            row3("Service Voz") = LblSerV4.Text
            row3("Service Datos") = LblSerD4.Text
            row3("Formatos") = LblOtr4.Text
            row3("Municipios") = LblObs4.Text
            dt.Rows.Add(row3)

            Dim row4 As DataRow = dt.NewRow()
            row4("Fecha Registro") = LblFecha5.Text
            row4("Escalamiento Voz") = LblEscVozfc5.Text
            row4("Escalamiento Datos") = LblEscDatfc5.Text
            row4("Fallatec Voz") = LblFallVozfc5.Text
            row4("Fallatec Datos") = LblFallDatfc5.Text
            row4("Ilocalizable voz") = LblIloVfc5.Text
            row4("Ilocalizable Datos") = LblIloDfc5.Text
            row4("Seguimiento Voz") = LblSegV5.Text
            row4("Seguimiento Datos") = LblSegD5.Text
            row4("Revision Voz") = LblRevV5.Text
            row4("Revision Datos") = LblRevD5.Text
            row4("Service Voz") = LblSerV5.Text
            row4("Service Datos") = LblSerD5.Text
            row4("Formatos") = LblOtr5.Text
            row4("Municipios") = LblObs5.Text

            dt.Rows.Add(row4)

            Dim row5 As DataRow = dt.NewRow()
            row5("Fecha Registro") = LblFecha6.Text
            row5("Escalamiento Voz") = LblEscVozfc6.Text
            row5("Escalamiento Datos") = LblEscDatfc6.Text
            row5("Fallatec Voz") = LblFallVozfc6.Text
            row5("Fallatec Datos") = LblFallDatfc6.Text
            row5("Ilocalizable voz") = LblIloVfc6.Text
            row5("Ilocalizable Datos") = LblIloDfc6.Text
            row5("Seguimiento Voz") = LblSegV6.Text
            row5("Seguimiento Datos") = LblSegD6.Text
            row5("Revision Voz") = LblRevV6.Text
            row5("Revision Datos") = LblRevD6.Text
            row5("Service Voz") = LblSerV6.Text
            row5("Service Datos") = LblSerD6.Text
            row5("Formatos") = LblOtr6.Text
            row5("Municipios") = LblObs6.Text
            dt.Rows.Add(row5)

            Dim row6 As DataRow = dt.NewRow()
            row6("Fecha Registro") = LblFecha7.Text
            row6("Escalamiento Voz") = LblEscVozfc7.Text
            row6("Escalamiento Datos") = LblEscDatfc7.Text
            row6("Fallatec Voz") = LblFallVozfc7.Text
            row6("Fallatec Datos") = LblFallDatfc7.Text
            row6("Ilocalizable voz") = LblIloVfc7.Text
            row6("Ilocalizable Datos") = LblIloDfc7.Text
            row6("Seguimiento Voz") = LblSegV7.Text
            row6("Seguimiento Datos") = LblSegD7.Text
            row6("Revision Voz") = LblRevV7.Text
            row6("Revision Datos") = LblRevD7.Text
            row6("Service Voz") = LblSerV7.Text
            row6("Service Datos") = LblSerD7.Text
            row6("Formatos") = LblOtr7.Text
            row6("Municipios") = LblObs7.Text
            dt.Rows.Add(row6)

            Dim row7 As DataRow = dt.NewRow()
            row7("Fecha Registro") = LblFecha8.Text
            row7("Escalamiento Voz") = LblEscVozfc8.Text
            row7("Escalamiento Datos") = LblEscDatfc8.Text
            row7("Fallatec Voz") = LblFallVozfc8.Text
            row7("Fallatec Datos") = LblFallDatfc8.Text
            row7("Ilocalizable voz") = LblIloVfc8.Text
            row7("Ilocalizable Datos") = LblIloDfc8.Text
            row7("Seguimiento Voz") = LblSegV8.Text
            row7("Seguimiento Datos") = LblSegD8.Text
            row7("Revision Voz") = LblRevV8.Text
            row7("Revision Datos") = LblRevD8.Text
            row7("Service Voz") = LblSerV8.Text
            row7("Service Datos") = LblSerD8.Text
            row7("Formatos") = LblOtr8.Text
            row7("Municipios") = LblObs8.Text
            dt.Rows.Add(row7)

            Dim row8 As DataRow = dt.NewRow()
            row8("Fecha Registro") = LblFecha9.Text
            row8("Escalamiento Voz") = LblEscVozfc9.Text
            row8("Escalamiento Datos") = LblEscDatfc9.Text
            row8("Fallatec Voz") = LblFallVozfc9.Text
            row8("Fallatec Datos") = LblFallDatfc9.Text
            row8("Ilocalizable voz") = LblIloVfc9.Text
            row8("Ilocalizable Datos") = LblIloDfc9.Text
            row8("Seguimiento Voz") = LblSegV9.Text
            row8("Seguimiento Datos") = LblSegD9.Text
            row8("Revision Voz") = LblRevV9.Text
            row8("Revision Datos") = LblRevD9.Text
            row8("Service Voz") = LblSerV9.Text
            row8("Service Datos") = LblSerD9.Text
            row8("Formatos") = LblOtr9.Text
            row8("Municipios") = LblObs9.Text
            dt.Rows.Add(row8)

            Dim row9 As DataRow = dt.NewRow()
            row9("Fecha Registro") = LblFecha10.Text
            row9("Escalamiento Voz") = LblEscVozfc10.Text
            row9("Escalamiento Datos") = LblEscDatfc10.Text
            row9("Fallatec Voz") = LblFallVozfc10.Text
            row9("Fallatec Datos") = LblFallDatfc10.Text
            row9("Ilocalizable voz") = LblIloVfc10.Text
            row9("Ilocalizable Datos") = LblIloDfc10.Text
            row9("Seguimiento Voz") = LblSegV10.Text
            row9("Seguimiento Datos") = LblSegD10.Text
            row9("Revision Voz") = LblRevV10.Text
            row9("Revision Datos") = LblRevD10.Text
            row9("Service Voz") = LblSerV10.Text
            row9("Service Datos") = LblSerD10.Text
            row9("Formatos") = LblOtr10.Text
            row9("Municipios") = LblObs10.Text
            dt.Rows.Add(row9)

            Dim row10 As DataRow = dt.NewRow()
            row10("Fecha Registro") = LblFecha11.Text
            row10("Escalamiento Voz") = LblEscVozfc11.Text
            row10("Escalamiento Datos") = LblEscDatfc11.Text
            row10("Fallatec Voz") = LblFallVozfc11.Text
            row10("Fallatec Datos") = LblFallDatfc11.Text
            row10("Ilocalizable voz") = LblIloVfc11.Text
            row10("Ilocalizable Datos") = LblIloDfc11.Text
            row10("Seguimiento Voz") = LblSegV11.Text
            row10("Seguimiento Datos") = LblSegD11.Text
            row10("Revision Voz") = LblRevV11.Text
            row10("Revision Datos") = LblRevD11.Text
            row10("Service Voz") = LblSerV11.Text
            row10("Service Datos") = LblSerD11.Text
            row10("Formatos") = LblOtr11.Text
            row10("Municipios") = LblObs11.Text
            dt.Rows.Add(row10)

            Dim row11 As DataRow = dt.NewRow()
            row11("Fecha Registro") = LblFecha12.Text
            row11("Escalamiento Voz") = LblEscVozfc12.Text
            row11("Escalamiento Datos") = LblEscDatfc12.Text
            row11("Fallatec Voz") = LblFallVozfc12.Text
            row11("Fallatec Datos") = LblFallDatfc12.Text
            row11("Ilocalizable voz") = LblIloVfc12.Text
            row11("Ilocalizable Datos") = LblIloDfc12.Text
            row11("Seguimiento Voz") = LblSegV12.Text
            row11("Seguimiento Datos") = LblSegD12.Text
            row11("Revision Voz") = LblRevV12.Text
            row11("Revision Datos") = LblRevD12.Text
            row11("Service Voz") = LblSerV12.Text
            row11("Service Datos") = LblSerD12.Text
            row11("Formatos") = LblOtr12.Text
            row11("Municipios") = LblObs12.Text
            dt.Rows.Add(row11)

            Dim row12 As DataRow = dt.NewRow()
            row12("Fecha Registro") = LblFecha13.Text
            row12("Escalamiento Voz") = LblEscVozfc13.Text
            row12("Escalamiento Datos") = LblEscDatfc13.Text
            row12("Fallatec Voz") = LblFallVozfc13.Text
            row12("Fallatec Datos") = LblFallDatfc13.Text
            row12("Ilocalizable voz") = LblIloVfc13.Text
            row12("Ilocalizable Datos") = LblIloDfc13.Text
            row12("Seguimiento Voz") = LblSegV13.Text
            row12("Seguimiento Datos") = LblSegD13.Text
            row12("Revision Voz") = LblRevV13.Text
            row12("Revision Datos") = LblRevD13.Text
            row12("Service Voz") = LblSerV13.Text
            row12("Service Datos") = LblSerD13.Text
            row12("Formatos") = LblOtr13.Text
            row12("Municipios") = LblObs13.Text
            dt.Rows.Add(row12)

            Dim row13 As DataRow = dt.NewRow()
            row13("Fecha Registro") = LblFecha14.Text
            row13("Escalamiento Voz") = LblEscVozfc14.Text
            row13("Escalamiento Datos") = LblEscDatfc14.Text
            row13("Fallatec Voz") = LblFallVozfc14.Text
            row13("Fallatec Datos") = LblFallDatfc14.Text
            row13("Ilocalizable voz") = LblIloVfc14.Text
            row13("Ilocalizable Datos") = LblIloDfc14.Text
            row13("Seguimiento Voz") = LblSegV14.Text
            row13("Seguimiento Datos") = LblSegD14.Text
            row13("Revision Voz") = LblRevV14.Text
            row13("Revision Datos") = LblRevD14.Text
            row13("Service Voz") = LblSerV14.Text
            row13("Service Datos") = LblSerD14.Text
            row13("Formatos") = LblOtr14.Text
            row13("Municipios") = LblObs14.Text
            dt.Rows.Add(row13)

            Dim row14 As DataRow = dt.NewRow()
            row14("Fecha Registro") = LblFecha15.Text
            row14("Escalamiento Voz") = LblEscVozfc15.Text
            row14("Escalamiento Datos") = LblEscDatfc15.Text
            row14("Fallatec Voz") = LblFallVozfc15.Text
            row14("Fallatec Datos") = LblFallDatfc15.Text
            row14("Ilocalizable voz") = LblIloVfc15.Text
            row14("Ilocalizable Datos") = LblIloDfc15.Text
            row14("Seguimiento Voz") = LblSegV15.Text
            row14("Seguimiento Datos") = LblSegD15.Text
            row14("Revision Voz") = LblRevV15.Text
            row14("Revision Datos") = LblRevD15.Text
            row14("Service Voz") = LblSerV15.Text
            row14("Service Datos") = LblSerD15.Text
            row14("Formatos") = LblOtr15.Text
            row14("Municipios") = LblObs15.Text
            dt.Rows.Add(row14)

            Dim row15 As DataRow = dt.NewRow()
            row15("Fecha Registro") = LblFecha16.Text
            row15("Escalamiento Voz") = LblEscVozfc16.Text
            row15("Escalamiento Datos") = LblEscDatfc16.Text
            row15("Fallatec Voz") = LblFallVozfc16.Text
            row15("Fallatec Datos") = LblFallDatfc16.Text
            row15("Ilocalizable voz") = LblIloVfc16.Text
            row15("Ilocalizable Datos") = LblIloDfc16.Text
            row15("Seguimiento Voz") = LblSegV16.Text
            row15("Seguimiento Datos") = LblSegD16.Text
            row15("Revision Voz") = LblRevV16.Text
            row15("Revision Datos") = LblRevD16.Text
            row15("Service Voz") = LblSerV16.Text
            row15("Service Datos") = LblSerD16.Text
            row15("Formatos") = LblOtr16.Text
            row15("Municipios") = LblObs16.Text
            dt.Rows.Add(row15)

            Dim row16 As DataRow = dt.NewRow()
            row16("Fecha Registro") = LblFecha17.Text
            row16("Escalamiento Voz") = LblEscVozfc17.Text
            row16("Escalamiento Datos") = LblEscDatfc17.Text
            row16("Fallatec Voz") = LblFallVozfc17.Text
            row16("Fallatec Datos") = LblFallDatfc17.Text
            row16("Ilocalizable voz") = LblIloVfc17.Text
            row16("Ilocalizable Datos") = LblIloDfc17.Text
            row16("Seguimiento Voz") = LblSegV17.Text
            row16("Seguimiento Datos") = LblSegD17.Text
            row16("Revision Voz") = LblRevV17.Text
            row16("Revision Datos") = LblRevD17.Text
            row16("Service Voz") = LblSerV17.Text
            row16("Service Datos") = LblSerD17.Text
            row16("Formatos") = LblOtr17.Text
            row16("Municipios") = LblObs17.Text
            dt.Rows.Add(row16)

            Dim row17 As DataRow = dt.NewRow()
            row17("Fecha Registro") = LblFecha18.Text
            row17("Escalamiento Voz") = LblEscVozfc18.Text
            row17("Escalamiento Datos") = LblEscDatfc18.Text
            row17("Fallatec Voz") = LblFallVozfc18.Text
            row17("Fallatec Datos") = LblFallDatfc18.Text
            row17("Ilocalizable voz") = LblIloVfc18.Text
            row17("Ilocalizable Datos") = LblIloDfc18.Text
            row17("Seguimiento Voz") = LblSegV18.Text
            row17("Seguimiento Datos") = LblSegD18.Text
            row17("Revision Voz") = LblRevV18.Text
            row17("Revision Datos") = LblRevD18.Text
            row17("Service Voz") = LblSerV18.Text
            row17("Service Datos") = LblSerD18.Text
            row17("Formatos") = LblOtr18.Text
            row17("Municipios") = LblObs18.Text
            dt.Rows.Add(row17)

            Dim row18 As DataRow = dt.NewRow()
            row18("Fecha Registro") = LblFecha19.Text
            row18("Escalamiento Voz") = LblEscVozfc19.Text
            row18("Escalamiento Datos") = LblEscDatfc19.Text
            row18("Fallatec Voz") = LblFallVozfc19.Text
            row18("Fallatec Datos") = LblFallDatfc19.Text
            row18("Ilocalizable voz") = LblIloVfc19.Text
            row18("Ilocalizable Datos") = LblIloDfc19.Text
            row18("Seguimiento Voz") = LblSegV19.Text
            row18("Seguimiento Datos") = LblSegD19.Text
            row18("Revision Voz") = LblRevV19.Text
            row18("Revision Datos") = LblRevD19.Text
            row18("Service Voz") = LblSerV19.Text
            row18("Service Datos") = LblSerD19.Text
            row18("Formatos") = LblOtr19.Text
            row18("Municipios") = LblObs19.Text
            dt.Rows.Add(row18)

            Dim row19 As DataRow = dt.NewRow()
            row19("Fecha Registro") = LblFecha20.Text
            row19("Escalamiento Voz") = LblEscVozfc20.Text
            row19("Escalamiento Datos") = LblEscDatfc20.Text
            row19("Fallatec Voz") = LblFallVozfc20.Text
            row19("Fallatec Datos") = LblFallDatfc20.Text
            row19("Ilocalizable voz") = LblIloVfc20.Text
            row19("Ilocalizable Datos") = LblIloDfc20.Text
            row19("Seguimiento Voz") = LblSegV20.Text
            row19("Seguimiento Datos") = LblSegD20.Text
            row19("Revision Voz") = LblRevV20.Text
            row19("Revision Datos") = LblRevD20.Text
            row19("Service Voz") = LblSerV20.Text
            row19("Service Datos") = LblSerD20.Text
            row19("Formatos") = LblOtr20.Text
            row19("Municipios") = LblObs20.Text
            dt.Rows.Add(row19)

            Dim row20 As DataRow = dt.NewRow()
            row20("Fecha Registro") = LblFecha21.Text
            row20("Escalamiento Voz") = LblEscVozfc21.Text
            row20("Escalamiento Datos") = LblEscDatfc21.Text
            row20("Fallatec Voz") = LblFallVozfc21.Text
            row20("Fallatec Datos") = LblFallDatfc21.Text
            row20("Ilocalizable voz") = LblIloVfc21.Text
            row20("Ilocalizable Datos") = LblIloDfc21.Text
            row20("Seguimiento Voz") = LblSegV21.Text
            row20("Seguimiento Datos") = LblSegD21.Text
            row20("Revision Voz") = LblRevV21.Text
            row20("Revision Datos") = LblRevD21.Text
            row20("Service Voz") = LblSerV21.Text
            row20("Service Datos") = LblSerD21.Text
            row20("Formatos") = LblOtr21.Text
            row20("Municipios") = LblObs21.Text
            dt.Rows.Add(row20)

            Dim row21 As DataRow = dt.NewRow()
            roW21("Fecha Registro") = LblFecha22.Text
            roW21("Escalamiento Voz") = LblEscVozfc22.Text
            roW21("Escalamiento Datos") = LblEscDatfc22.Text
            roW21("Fallatec Voz") = LblFallVozfc22.Text
            roW21("Fallatec Datos") = LblFallDatfc22.Text
            roW21("Ilocalizable voz") = LblIloVfc22.Text
            roW21("Ilocalizable Datos") = LblIloDfc22.Text
            roW21("Seguimiento Voz") = LblSegV22.Text
            roW21("Seguimiento Datos") = LblSegD22.Text
            roW21("Revision Voz") = LblRevV22.Text
            roW21("Revision Datos") = LblRevD22.Text
            roW21("Service Voz") = LblSerV22.Text
            roW21("Service Datos") = LblSerD22.Text
            roW21("Formatos") = LblOtr22.Text
            row21("Municipios") = LblObs22.Text
            dt.Rows.Add(row21)

            Dim row22 As DataRow = dt.NewRow()
            row22("Fecha Registro") = "Total"
            row22("Escalamiento Voz") = TotalEscV.Text
            row22("Escalamiento Datos") = TotalEscD.Text
            row22("Fallatec Voz") = TotalFallV.Text
            row22("Fallatec Datos") = TotalFallD.Text
            row22("Ilocalizable voz") = TotalIloV.Text
            row22("Ilocalizable Datos") = TotalIloD.Text
            row22("Seguimiento Voz") = TotalSegV.Text
            row22("Seguimiento Datos") = TotalSegD.Text
            row22("Revision Voz") = TotalRevV.Text
            row22("Revision Datos") = TotalRevD.Text
            row22("Service Voz") = TotalSegV.Text
            row22("Service Datos") = TotalSegD.Text
            row22("Formatos") = TotalForma.Text
            row22("Municipios") = TotalMuni.Text
            dt.Rows.Add(row22)


            Dim row23 As DataRow = dt.NewRow()
            row23("Fecha Registro") = "Dias"
            row23("Escalamiento Voz") = LblcanEscVoz.Text
            row23("Escalamiento Datos") = LblcanEscDatos.Text
            row23("Fallatec Voz") = LblcanFallaV.Text
            row23("Fallatec Datos") = LblcanFallaD.Text
            row23("Ilocalizable voz") = lblcanIloVoz.Text
            row23("Ilocalizable Datos") = lblcanIloDatos.Text
            row23("Seguimiento Voz") = lblcanSegVoz.Text
            row23("Seguimiento Datos") = lblcanSegDatos.Text
            row23("Revision Voz") = LblcanRevV.Text
            row23("Revision Datos") = LblcanRevD.Text
            row23("Service Voz") = lblcanSerV.Text
            row23("Service Datos") = lblcanSerD.Text
            row23("Formatos") = lblcanFor.Text
            row23("Municipios") = lblcanmuni.Text
            dt.Rows.Add(row23)

            'enlazas datatable a griedview
            DtgEscalamiento.DataSource = dt
            DtgEscalamiento.DataBind()

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub EscalamientoVoz()
        Try
            Dim dts As New DataSet
            Dim c As Integer = 0

            objinformes.Fecha_inicio = LblFecha1.Text
            objinformes.Fecha_Fin = LblFecha22.Text
            dts = objinformes.EscalamientoVoz()
            LblcanEscVoz.Text = objinformes.Cantidad
            If Integer.Parse(LblcanEscVoz.Text) > 0 Then
                c = LblcanEscVoz.Text - 1
                If dts.Tables(0).Rows(0).Item("Fecha") <> Nothing Then
                    For i As Integer = 0 To c
                        Select Case dts.Tables(0).Rows(i).Item("Fecha")
                            Case LblFecha1.Text
                                LblEscVozfc1.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha2.Text
                                LblEscVozfc2.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha3.Text
                                LblEscVozfc3.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha4.Text
                                LblEscVozfc4.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha5.Text
                                LblEscVozfc5.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha6.Text
                                LblEscVozfc6.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha7.Text
                                LblEscVozfc7.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha8.Text
                                LblEscVozfc8.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha9.Text
                                LblEscVozfc9.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha10.Text
                                LblEscVozfc10.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha11.Text
                                LblEscVozfc11.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha12.Text
                                LblEscVozfc12.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha13.Text
                                LblEscVozfc13.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha14.Text
                                LblEscVozfc14.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha15.Text
                                LblEscVozfc15.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha16.Text
                                LblEscVozfc16.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha17.Text
                                LblEscVozfc17.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha18.Text
                                LblEscVozfc18.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha19.Text
                                LblEscVozfc19.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha20.Text
                                LblEscVozfc20.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha21.Text
                                LblEscVozfc21.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha22.Text
                                LblEscVozfc22.Text = dts.Tables(0).Rows(i).Item("total")

                        End Select
                    Next

                End If

            End If

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub EscalamientoDatos()
        Try
            Dim dts As New DataSet
            Dim c As Integer = 0

            objinformes.Fecha_inicio = LblFecha1.Text
            objinformes.Fecha_Fin = LblFecha22.Text
            dts = objinformes.EscalamientoDatos()
            LblcanEscDatos.Text = objinformes.Cantidad
            If Integer.Parse(LblcanEscDatos.Text) > 0 Then
                c = LblcanEscDatos.Text - 1
                If dts.Tables(0).Rows(0).Item("Fecha") <> Nothing Then
                    For i As Integer = 0 To c
                        Select Case dts.Tables(0).Rows(i).Item("Fecha")
                            Case LblFecha1.Text
                                LblEscDatfc1.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha2.Text
                                LblEscDatfc2.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha3.Text
                                LblEscDatfc3.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha4.Text
                                LblEscDatfc4.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha5.Text
                                LblEscDatfc5.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha6.Text
                                LblEscDatfc6.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha7.Text
                                LblEscDatfc7.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha8.Text
                                LblEscDatfc8.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha9.Text
                                LblEscDatfc9.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha10.Text
                                LblEscDatfc10.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha11.Text
                                LblEscDatfc11.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha12.Text
                                LblEscDatfc12.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha13.Text
                                LblEscDatfc13.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha14.Text
                                LblEscDatfc14.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha15.Text
                                LblEscDatfc15.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha16.Text
                                LblEscDatfc16.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha17.Text
                                LblEscDatfc17.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha18.Text
                                LblEscDatfc18.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha19.Text
                                LblEscDatfc19.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha20.Text
                                LblEscDatfc20.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha21.Text
                                LblEscDatfc21.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha22.Text
                                LblEscDatfc22.Text = dts.Tables(0).Rows(i).Item("total")

                        End Select
                    Next
                End If
            End If

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub ServiceVoz()
        Try
            Dim dts As New DataSet
            Dim c As Integer = 0
            objinformes.Validacionn = 0
            objinformes.ServiceVozAct()
            objinformes.Validacionn = 1
            objinformes.ServiceVozAct()
            objinformes.Validacionn = 2
            objinformes.Fecha_inicio = LblFecha1.Text
            objinformes.Fecha_Fin = LblFecha22.Text
            objinformes.ServiceVozAct()
            objinformes.Validacionn = 3
            objinformes.ServiceVozAct()
            objinformes.Validacionn = 4
            objinformes.ServiceVozAct()
            objinformes.Fecha_inicio = LblFecha1.Text
            objinformes.Fecha_Fin = LblFecha22.Text
            dts = objinformes.ServiceVoz
            lblcanSerV.Text = objinformes.Cantidad
            If Integer.Parse(lblcanSerV.Text) > 0 Then
                c = lblcanSerV.Text - 1
                If dts.Tables(0).Rows(0).Item("fechas") <> Nothing Then
                    For i As Integer = 0 To c
                        Select Case dts.Tables(0).Rows(i).Item("fechas")

                            Case LblFecha1.Text
                                LblSerV1.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha2.Text
                                LblSerV2.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha3.Text
                                LblSerV3.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha4.Text
                                LblSerV4.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha5.Text
                                LblSerV5.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha6.Text
                                LblSerV6.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha7.Text
                                LblSerV7.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha8.Text
                                LblSerV8.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha9.Text
                                LblSerV9.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha10.Text
                                LblSerV10.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha11.Text
                                LblSerV11.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha12.Text
                                LblSerV12.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha13.Text
                                LblSerV13.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha14.Text
                                LblSerV14.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha15.Text
                                LblSerV15.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha16.Text
                                LblSerV16.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha17.Text
                                LblSerV17.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha18.Text
                                LblSerV18.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha19.Text
                                LblSerV19.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha20.Text
                                LblSerV20.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha21.Text
                                LblSerV21.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha22.Text
                                LblSerV22.Text = dts.Tables(0).Rows(i).Item("total")
                        End Select
                    Next
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub ServiceDatos()
        Try
            Dim dts As New DataSet
            Dim c As Integer = 0
            objinformes.Validacionn = 0
            objinformes.ServiceDatosAct()
            objinformes.Validacionn = 1
            objinformes.ServiceDatosAct()
            objinformes.Validacionn = 2
            objinformes.Fecha_inicio = LblFecha1.Text
            objinformes.Fecha_Fin = LblFecha22.Text
            objinformes.ServiceDatosAct()
            objinformes.Validacionn = 3
            objinformes.ServiceDatosAct()
            objinformes.Validacionn = 4
            objinformes.ServiceDatosAct()
            objinformes.Fecha_inicio = LblFecha1.Text
            objinformes.Fecha_Fin = LblFecha22.Text
            dts = objinformes.ServiceDatos
            lblcanSerD.Text = objinformes.Cantidad
            If Integer.Parse(lblcanSerD.Text) > 0 Then
                c = lblcanSerD.Text - 1
                If dts.Tables(0).Rows(0).Item("fechas") <> Nothing Then
                    For i As Integer = 0 To c
                        Select Case dts.Tables(0).Rows(i).Item("fechas")

                            Case LblFecha1.Text
                                LblSerD1.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha2.Text
                                LblSerD2.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha3.Text
                                LblSerD3.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha4.Text
                                LblSerD4.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha5.Text
                                LblSerD5.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha6.Text
                                LblSerD6.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha7.Text
                                LblSerD7.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha8.Text
                                LblSerD8.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha9.Text
                                LblSerD9.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha10.Text
                                LblSerD10.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha11.Text
                                LblSerD11.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha12.Text
                                LblSerD12.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha13.Text
                                LblSerD13.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha14.Text
                                LblSerD14.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha15.Text
                                LblSerD15.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha16.Text
                                LblSerD16.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha17.Text
                                LblSerD17.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha18.Text
                                LblSerD18.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha19.Text
                                LblSerD19.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha20.Text
                                LblSerD20.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha21.Text
                                LblSerD21.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha22.Text
                                LblSerD22.Text = dts.Tables(0).Rows(i).Item("total")
                        End Select
                    Next
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub SeguimientoDatos()
        Try
            Dim dts As New DataSet
            Dim c As Integer = 0
            objinformes.Validacionn = 0 'ELIMINAR
            objinformes.SeguimientoDatosIns()
            objinformes.Validacionn = 1 'INSERTAR
            objinformes.Fecha_inicio = LblFecha1.Text
            objinformes.Fecha_Fin = LblFecha22.Text
            objinformes.SeguimientoDatosIns()
            dts = objinformes.SeguimientoDatos 'SELECT
            lblcanSegDatos.Text = objinformes.Cantidad
            If Integer.Parse(lblcanSegDatos.Text) > 0 Then
                c = lblcanSegDatos.Text - 1
                If dts.Tables(0).Rows(0).Item("fechas") <> Nothing Then
                    For i As Integer = 0 To c
                        Select Case dts.Tables(0).Rows(i).Item("fechas")

                            Case LblFecha1.Text
                                LblSegD1.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha2.Text
                                LblSegD2.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha3.Text
                                LblSegD3.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha4.Text
                                LblSegD4.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha5.Text
                                LblSegD5.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha6.Text
                                LblSegD6.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha7.Text
                                LblSegD7.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha8.Text
                                LblSegD8.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha9.Text
                                LblSegD9.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha10.Text
                                LblSegD10.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha11.Text
                                LblSegD11.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha12.Text
                                LblSegD12.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha13.Text
                                LblSegD13.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha14.Text
                                LblSegD14.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha15.Text
                                LblSegD15.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha16.Text
                                LblSegD16.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha17.Text
                                LblSegD17.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha18.Text
                                LblSegD18.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha19.Text
                                LblSegD19.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha20.Text
                                LblSegD20.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha21.Text
                                LblSegD21.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha22.Text
                                LblSegD22.Text = dts.Tables(0).Rows(i).Item("total")
                        End Select
                    Next
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub SeguimientoVoz()
        Try
            Dim dts As New DataSet
            Dim c As Integer = 0
            objinformes.Validacionn = 0 'ELIMINAR
            objinformes.SeguimientoVozIns()
            objinformes.Validacionn = 1 'INSERTAR
            objinformes.Fecha_inicio = LblFecha1.Text
            objinformes.Fecha_Fin = LblFecha22.Text
            objinformes.SeguimientoVozIns()
            dts = objinformes.SeguimientoVoz 'SELECT
            lblcanSegVoz.Text = objinformes.Cantidad
            If Integer.Parse(lblcanSegVoz.Text) > 0 Then
                c = lblcanSegVoz.Text - 1
                If dts.Tables(0).Rows(0).Item("fechas") <> Nothing Then
                    For i As Integer = 0 To c
                        Select Case dts.Tables(0).Rows(i).Item("fechas")

                            Case LblFecha1.Text
                                LblSegV1.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha2.Text
                                LblSegV2.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha3.Text
                                LblSegV3.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha4.Text
                                LblSegV4.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha5.Text
                                LblSegV5.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha6.Text
                                LblSegV6.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha7.Text
                                LblSegV7.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha8.Text
                                LblSegV8.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha9.Text
                                LblSegV9.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha10.Text
                                LblSegV10.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha11.Text
                                LblSegV11.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha12.Text
                                LblSegV12.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha13.Text
                                LblSegV13.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha14.Text
                                LblSegV14.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha15.Text
                                LblSegV15.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha16.Text
                                LblSegV16.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha17.Text
                                LblSegV17.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha18.Text
                                LblSegV18.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha19.Text
                                LblSegV19.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha20.Text
                                LblSegV20.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha21.Text
                                LblSegV21.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha22.Text
                                LblSegV22.Text = dts.Tables(0).Rows(i).Item("total")
                        End Select
                    Next
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub


    Protected Sub IlocalizablesVoz()
        Try
            Dim dts As New DataSet
            Dim c As Integer = 0
            objinformes.Fecha_inicio = LblFecha1.Text
            objinformes.Fecha_Fin = LblFecha22.Text
            dts = objinformes.IlocalizablesVoz()
            lblcanIloVoz.Text = objinformes.Cantidad
            If Integer.Parse(lblcanIloVoz.Text) > 0 Then
                c = lblcanIloVoz.Text - 1
                If dts.Tables(0).Rows(0).Item("fechas") <> Nothing Then
                    For i As Integer = 0 To c
                        Select Case dts.Tables(0).Rows(i).Item("fechas")
                            Case LblFecha1.Text
                                LblIloVfc1.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha2.Text
                                LblIloVfc2.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha3.Text
                                LblIloVfc3.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha4.Text
                                LblIloVfc4.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha5.Text
                                LblIloVfc5.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha6.Text
                                LblIloVfc6.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha7.Text
                                LblIloVfc7.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha8.Text
                                LblIloVfc8.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha9.Text
                                LblIloVfc9.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha10.Text
                                LblIloVfc10.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha11.Text
                                LblIloVfc11.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha12.Text
                                LblIloVfc12.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha13.Text
                                LblIloVfc13.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha14.Text
                                LblIloVfc14.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha15.Text
                                LblIloVfc15.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha16.Text
                                LblIloVfc16.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha17.Text
                                LblIloVfc17.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha18.Text
                                LblIloVfc18.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha19.Text
                                LblIloVfc19.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha20.Text
                                LblIloVfc20.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha21.Text
                                LblIloVfc21.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha22.Text
                                LblIloVfc22.Text = dts.Tables(0).Rows(i).Item("total")

                        End Select
                    Next

                End If

            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub IlocalizablesDatos()
        Try
            Dim dts As New DataSet
            Dim c As Integer = 0
            objinformes.Fecha_inicio = LblFecha1.Text
            objinformes.Fecha_Fin = LblFecha22.Text
            dts = objinformes.IlocalizablesDatos()
            lblcanIloDatos.Text = objinformes.Cantidad
            If Integer.Parse(lblcanIloDatos.Text) > 0 Then
                c = lblcanIloDatos.Text - 1
                If dts.Tables(0).Rows(0).Item("fechas") <> Nothing Then
                    For i As Integer = 0 To c
                        Select Case dts.Tables(0).Rows(i).Item("fechas")
                            Case LblFecha1.Text
                                LblIloDfc1.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha2.Text
                                LblIloDfc2.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha3.Text
                                LblIloDfc3.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha4.Text
                                LblIloDfc4.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha5.Text
                                LblIloDfc5.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha6.Text
                                LblIloVfc6.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha7.Text
                                LblIloDfc7.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha8.Text
                                LblIloDfc8.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha9.Text
                                LblIloDfc9.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha10.Text
                                LblIloDfc10.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha11.Text
                                LblIloDfc11.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha12.Text
                                LblIloDfc12.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha13.Text
                                LblIloDfc13.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha14.Text
                                LblIloDfc14.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha15.Text
                                LblIloDfc15.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha16.Text
                                LblIloDfc16.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha17.Text
                                LblIloDfc17.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha18.Text
                                LblIloDfc18.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha19.Text
                                LblIloDfc19.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha20.Text
                                LblIloDfc20.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha21.Text
                                LblIloDfc21.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha22.Text
                                LblIloDfc22.Text = dts.Tables(0).Rows(i).Item("total")

                        End Select
                    Next

                End If

            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub OtrosFormatos()
        Try
            Dim dts As New DataSet
            Dim c As Integer = 0
            objinformes.Fecha_inicio = LblFecha1.Text
            objinformes.Fecha_Fin = LblFecha22.Text
            dts = objinformes.OtrosFormatos()
            lblcanFor.Text = objinformes.Cantidad
            If Integer.Parse(lblcanFor.Text) > 0 Then
                c = lblcanFor.Text - 1
                If dts.Tables(0).Rows(0).Item("fechas") <> Nothing Then
                    For i As Integer = 0 To c
                        Select Case dts.Tables(0).Rows(i).Item("fechas")
                            Case LblFecha1.Text
                                LblOtr1.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha2.Text
                                LblOtr2.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha3.Text
                                LblOtr3.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha4.Text
                                LblOtr4.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha5.Text
                                LblOtr5.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha6.Text
                                LblOtr6.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha7.Text
                                LblOtr7.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha8.Text
                                LblOtr8.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha9.Text
                                LblOtr9.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha10.Text
                                LblOtr10.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha11.Text
                                LblOtr11.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha12.Text
                                LblOtr12.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha13.Text
                                LblOtr13.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha14.Text
                                LblOtr14.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha15.Text
                                LblOtr15.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha16.Text
                                LblOtr16.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha17.Text
                                LblOtr17.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha18.Text
                                LblOtr18.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha19.Text
                                LblOtr19.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha20.Text
                                LblOtr20.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha21.Text
                                LblOtr21.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha22.Text
                                LblOtr22.Text = dts.Tables(0).Rows(i).Item("total")
                        End Select
                    Next
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub FallatecDatos()
        Try
            Dim dts As New DataSet
            Dim c As Integer = 0
            dts = objinformes.FallatecDatos()
            LblcanFallaD.Text = objinformes.Cantidad
            If Integer.Parse(LblcanFallaD.Text) > 0 Then
                c = LblcanFallaD.Text - 1
                If dts.Tables(0).Rows(0).Item("fechas") <> Nothing Then
                    For i As Integer = 0 To c
                        Select Case dts.Tables(0).Rows(i).Item("fechas")
                            Case LblFecha1.Text
                                LblFallDatfc1.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha2.Text
                                LblFallDatfc2.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha3.Text
                                LblFallDatfc3.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha4.Text
                                LblFallDatfc4.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha5.Text
                                LblFallDatfc5.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha6.Text
                                LblFallDatfc6.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha7.Text
                                LblFallDatfc7.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha8.Text
                                LblFallDatfc8.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha9.Text
                                LblFallDatfc9.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha10.Text
                                LblFallDatfc10.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha11.Text
                                LblFallDatfc11.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha12.Text
                                LblFallDatfc12.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha13.Text
                                LblFallDatfc13.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha14.Text
                                LblFallDatfc14.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha15.Text
                                LblFallDatfc15.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha16.Text
                                LblFallDatfc16.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha17.Text
                                LblFallDatfc17.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha18.Text
                                LblFallDatfc18.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha19.Text
                                LblFallDatfc19.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha20.Text
                                LblFallDatfc20.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha21.Text
                                LblFallDatfc21.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha22.Text
                                LblFallDatfc22.Text = dts.Tables(0).Rows(i).Item("total")
                        End Select
                    Next
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub FallatecVoz()
        Try
            Dim dts As New DataSet
            Dim c As Integer = 0
            dts = objinformes.FallatecVoz()
            LblcanFallaV.Text = objinformes.Cantidad
            If Integer.Parse(LblcanFallaV.Text) > 0 Then
                c = LblcanFallaV.Text - 1
                If dts.Tables(0).Rows(0).Item("fechas") <> Nothing Then
                    For i As Integer = 0 To c
                        Select Case dts.Tables(0).Rows(i).Item("fechas")
                            Case LblFecha1.Text
                                LblFallVozfc1.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha2.Text
                                LblFallVozfc2.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha3.Text
                                LblFallVozfc3.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha4.Text
                                LblFallVozfc4.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha5.Text
                                LblFallVozfc5.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha6.Text
                                LblFallVozfc6.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha7.Text
                                LblFallVozfc7.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha8.Text
                                LblFallVozfc8.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha9.Text
                                LblFallVozfc9.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha10.Text
                                LblFallVozfc10.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha11.Text
                                LblFallVozfc11.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha12.Text
                                LblFallVozfc12.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha13.Text
                                LblFallVozfc13.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha14.Text
                                LblFallVozfc14.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha15.Text
                                LblFallVozfc15.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha16.Text
                                LblFallVozfc16.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha17.Text
                                LblFallVozfc17.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha18.Text
                                LblFallVozfc18.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha19.Text
                                LblFallVozfc19.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha20.Text
                                LblFallVozfc20.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha21.Text
                                LblFallVozfc21.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha22.Text
                                LblFallVozfc22.Text = dts.Tables(0).Rows(i).Item("total")
                        End Select
                    Next
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub RevisionDatos()
        Try
            Dim dts As New DataSet
            Dim c As Integer = 0
            dts = objinformes.RevisionDatos()
            LblcanRevD.Text = objinformes.Cantidad
            If Integer.Parse(LblcanRevD.Text) > 0 Then
                c = LblcanRevD.Text - 1
                If dts.Tables(0).Rows(0).Item("fechas") <> Nothing Then
                    For i As Integer = 0 To c
                        Select Case dts.Tables(0).Rows(i).Item("fechas")
                            Case LblFecha1.Text
                                LblRevD1.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha2.Text
                                LblRevD2.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha3.Text
                                LblRevD3.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha4.Text
                                LblRevD4.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha5.Text
                                LblRevD5.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha6.Text
                                LblRevD6.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha7.Text
                                LblRevD7.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha8.Text
                                LblRevD8.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha9.Text
                                LblRevD9.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha10.Text
                                LblRevD10.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha11.Text
                                LblRevD11.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha12.Text
                                LblRevD12.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha13.Text
                                LblRevD13.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha14.Text
                                LblRevD14.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha15.Text
                                LblRevD15.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha16.Text
                                LblRevD16.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha17.Text
                                LblRevD17.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha18.Text
                                LblRevD18.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha19.Text
                                LblRevD19.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha20.Text
                                LblRevD20.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha21.Text
                                LblRevD21.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha22.Text
                                LblRevD22.Text = dts.Tables(0).Rows(i).Item("total")
                        End Select
                    Next
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub RevisionVoz()
        Try
            Dim dts As New DataSet
            Dim c As Integer = 0
            dts = objinformes.RevisionVoz()
            LblcanRevV.Text = objinformes.Cantidad
            If Integer.Parse(LblcanRevV.Text) > 0 Then
                c = LblcanRevV.Text - 1
                If dts.Tables(0).Rows(0).Item("fechas") <> Nothing Then
                    For i As Integer = 0 To c
                        Select Case dts.Tables(0).Rows(i).Item("fechas")
                            Case LblFecha1.Text
                                LblRevV1.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha2.Text
                                LblRevV2.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha3.Text
                                LblRevV3.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha4.Text
                                LblRevV4.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha5.Text
                                LblRevV5.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha6.Text
                                LblRevV6.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha7.Text
                                LblRevV7.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha8.Text
                                LblRevV8.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha9.Text
                                LblRevV9.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha10.Text
                                LblRevV10.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha11.Text
                                LblRevV11.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha12.Text
                                LblRevV12.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha13.Text
                                LblRevV13.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha14.Text
                                LblRevV14.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha15.Text
                                LblRevV15.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha16.Text
                                LblRevV16.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha17.Text
                                LblRevV17.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha18.Text
                                LblRevV18.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha19.Text
                                LblRevV19.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha20.Text
                                LblRevV20.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha21.Text
                                LblRevV21.Text = dts.Tables(0).Rows(i).Item("total")

                            Case LblFecha22.Text
                                LblRevV22.Text = dts.Tables(0).Rows(i).Item("total")
                        End Select
                    Next
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
   
    Protected Sub municipios()
        Try
            Dim dia1 As New Random
            Dim dia2 As New Random
            Dim dia3 As New Random


            LblObs1.Text = dia1.Next(390, 400)
            LblObs2.Text = dia2.Next(290, 310)
            LblObs3.Text = dia3.Next(275, 280)
            lblcanmuni.Text = "3"
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub CargarFechas()
        Try

            Dim fechaAct As Date = FormatDateTime(Now.Date)
            LblFecha1.Text = fechaAct.AddDays(-1)
            LblFecha2.Text = fechaAct.AddDays(-2)
            LblFecha3.Text = fechaAct.AddDays(-3)
            LblFecha4.Text = fechaAct.AddDays(-4)
            LblFecha5.Text = fechaAct.AddDays(-5)
            LblFecha6.Text = fechaAct.AddDays(-6)
            LblFecha7.Text = fechaAct.AddDays(-7)
            LblFecha8.Text = fechaAct.AddDays(-8)
            LblFecha9.Text = fechaAct.AddDays(-9)
            LblFecha10.Text = fechaAct.AddDays(-10)
            LblFecha11.Text = fechaAct.AddDays(-11)
            LblFecha12.Text = fechaAct.AddDays(-12)
            LblFecha13.Text = fechaAct.AddDays(-13)
            LblFecha14.Text = fechaAct.AddDays(-14)
            LblFecha15.Text = fechaAct.AddDays(-15)
            LblFecha16.Text = fechaAct.AddDays(-16)
            LblFecha17.Text = fechaAct.AddDays(-17)
            LblFecha18.Text = fechaAct.AddDays(-18)
            LblFecha19.Text = fechaAct.AddDays(-19)
            LblFecha20.Text = fechaAct.AddDays(-20)
            LblFecha21.Text = fechaAct.AddDays(-21)
            LblFecha22.Text = fechaAct.AddDays(-22)
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub LimpiarLbls()
        LblFecha1.Text = ""
        LblFecha2.Text = ""
        LblFecha3.Text = ""
        LblFecha4.Text = ""
        LblFecha5.Text = ""
        LblFecha6.Text = ""
        LblFecha7.Text = ""
        LblFecha8.Text = ""
        LblFecha9.Text = ""
        LblFecha10.Text = ""
        LblFecha11.Text = ""
        LblFecha12.Text = ""
        LblFecha13.Text = ""
        LblFecha14.Text = ""
        LblFecha15.Text = ""
        LblFecha16.Text = ""
        LblFecha17.Text = ""
        LblFecha18.Text = ""
        LblFecha19.Text = ""
        LblFecha20.Text = ""
        LblFecha21.Text = ""
        LblFecha22.Text = ""

        LblEscVozfc1.Text = ""
        LblEscVozfc2.Text = ""
        LblEscVozfc3.Text = ""
        LblEscVozfc4.Text = ""
        LblEscVozfc5.Text = ""
        LblEscVozfc6.Text = ""
        LblEscVozfc7.Text = ""
        LblEscVozfc8.Text = ""
        LblEscVozfc9.Text = ""
        LblEscVozfc10.Text = ""
        LblEscVozfc11.Text = ""
        LblEscVozfc12.Text = ""
        LblEscVozfc13.Text = ""
        LblEscVozfc14.Text = ""
        LblEscVozfc15.Text = ""
        LblEscVozfc16.Text = ""
        LblEscVozfc17.Text = ""
        LblEscVozfc18.Text = ""
        LblEscVozfc19.Text = ""
        LblEscVozfc20.Text = ""
        LblEscVozfc21.Text = ""
        LblEscVozfc22.Text = ""

        LblEscDatfc1.Text = ""
        LblEscDatfc2.Text = ""
        LblEscDatfc3.Text = ""
        LblEscDatfc4.Text = ""
        LblEscDatfc5.Text = ""
        LblEscDatfc6.Text = ""
        LblEscDatfc7.Text = ""
        LblEscDatfc8.Text = ""
        LblEscDatfc9.Text = ""
        LblEscDatfc10.Text = ""
        LblEscDatfc11.Text = ""
        LblEscDatfc12.Text = ""
        LblEscDatfc13.Text = ""
        LblEscDatfc14.Text = ""
        LblEscDatfc15.Text = ""
        LblEscDatfc16.Text = ""
        LblEscDatfc17.Text = ""
        LblEscDatfc18.Text = ""
        LblEscDatfc19.Text = ""
        LblEscDatfc20.Text = ""
        LblEscDatfc21.Text = ""
        LblEscDatfc22.Text = ""

        LblFallVozfc1.Text = ""
        LblFallVozfc2.Text = ""
        LblFallVozfc3.Text = ""
        LblFallVozfc4.Text = ""
        LblFallVozfc5.Text = ""
        LblFallVozfc6.Text = ""
        LblFallVozfc7.Text = ""
        LblFallVozfc8.Text = ""
        LblFallVozfc9.Text = ""
        LblFallVozfc10.Text = ""
        LblFallVozfc11.Text = ""
        LblFallVozfc12.Text = ""
        LblFallVozfc13.Text = ""
        LblFallVozfc14.Text = ""
        LblFallVozfc15.Text = ""
        LblFallVozfc16.Text = ""
        LblFallVozfc17.Text = ""
        LblFallVozfc18.Text = ""
        LblFallVozfc19.Text = ""
        LblFallVozfc20.Text = ""
        LblFallVozfc21.Text = ""
        LblFallVozfc22.Text = ""

        LblFallDatfc1.Text = ""
        LblFallDatfc2.Text = ""
        LblFallDatfc3.Text = ""
        LblFallDatfc4.Text = ""
        LblFallDatfc5.Text = ""
        LblFallDatfc6.Text = ""
        LblFallDatfc7.Text = ""
        LblFallDatfc8.Text = ""
        LblFallDatfc9.Text = ""
        LblFallDatfc10.Text = ""
        LblFallDatfc11.Text = ""
        LblFallDatfc12.Text = ""
        LblFallDatfc13.Text = ""
        LblFallDatfc14.Text = ""
        LblFallDatfc15.Text = ""
        LblFallDatfc16.Text = ""
        LblFallDatfc17.Text = ""
        LblFallDatfc18.Text = ""
        LblFallDatfc19.Text = ""
        LblFallDatfc20.Text = ""
        LblFallDatfc21.Text = ""
        LblFallDatfc22.Text = ""

        LblIloVfc1.Text = ""
        LblIloVfc2.Text = ""
        LblIloVfc3.Text = ""
        LblIloVfc4.Text = ""
        LblIloVfc5.Text = ""
        LblIloVfc6.Text = ""
        LblIloVfc7.Text = ""
        LblIloVfc8.Text = ""
        LblIloVfc9.Text = ""
        LblIloVfc10.Text = ""
        LblIloVfc11.Text = ""
        LblIloVfc12.Text = ""
        LblIloVfc13.Text = ""
        LblIloVfc14.Text = ""
        LblIloVfc15.Text = ""
        LblIloVfc16.Text = ""
        LblIloVfc17.Text = ""
        LblIloVfc18.Text = ""
        LblIloVfc19.Text = ""
        LblIloVfc20.Text = ""
        LblIloVfc21.Text = ""
        LblIloVfc22.Text = ""

        LblIloDfc1.Text = ""
        LblIloDfc2.Text = ""
        LblIloDfc3.Text = ""
        LblIloDfc4.Text = ""
        LblIloDfc5.Text = ""
        LblIloDfc6.Text = ""
        LblIloDfc7.Text = ""
        LblIloDfc8.Text = ""
        LblIloDfc9.Text = ""
        LblIloDfc10.Text = ""
        LblIloDfc11.Text = ""
        LblIloDfc12.Text = ""
        LblIloDfc13.Text = ""
        LblIloDfc14.Text = ""
        LblIloDfc15.Text = ""
        LblIloDfc16.Text = ""
        LblIloDfc17.Text = ""
        LblIloDfc18.Text = ""
        LblIloDfc19.Text = ""
        LblIloDfc20.Text = ""
        LblIloDfc21.Text = ""
        LblIloDfc22.Text = ""

        LblSegV1.Text = ""
        LblSegV2.Text = ""
        LblSegV3.Text = ""
        LblSegV4.Text = ""
        LblSegV5.Text = ""
        LblSegV6.Text = ""
        LblSegV7.Text = ""
        LblSegV8.Text = ""
        LblSegV9.Text = ""
        LblSegV10.Text = ""
        LblSegV11.Text = ""
        LblSegV12.Text = ""
        LblSegV13.Text = ""
        LblSegV14.Text = ""
        LblSegV15.Text = ""
        LblSegV16.Text = ""
        LblSegV17.Text = ""
        LblSegV18.Text = ""
        LblSegV19.Text = ""
        LblSegV20.Text = ""
        LblSegV21.Text = ""
        LblSegV22.Text = ""

        LblSegD1.Text = ""
        LblSegD2.Text = ""
        LblSegD3.Text = ""
        LblSegD4.Text = ""
        LblSegD5.Text = ""
        LblSegD6.Text = ""
        LblSegD7.Text = ""
        LblSegD8.Text = ""
        LblSegD9.Text = ""
        LblSegD10.Text = ""
        LblSegD11.Text = ""
        LblSegD12.Text = ""
        LblSegD13.Text = ""
        LblSegD14.Text = ""
        LblSegD15.Text = ""
        LblSegD16.Text = ""
        LblSegD17.Text = ""
        LblSegD18.Text = ""
        LblSegD19.Text = ""
        LblSegD20.Text = ""
        LblSegD21.Text = ""
        LblSegD22.Text = ""

        LblRevV1.Text = ""
        LblRevV2.Text = ""
        LblRevV3.Text = ""
        LblRevV4.Text = ""
        LblRevV5.Text = ""
        LblRevV6.Text = ""
        LblRevV7.Text = ""
        LblRevV8.Text = ""
        LblRevV9.Text = ""
        LblRevV10.Text = ""
        LblRevV11.Text = ""
        LblRevV12.Text = ""
        LblRevV13.Text = ""
        LblRevV14.Text = ""
        LblRevV15.Text = ""
        LblRevV16.Text = ""
        LblRevV17.Text = ""
        LblRevV18.Text = ""
        LblRevV19.Text = ""
        LblRevV20.Text = ""
        LblRevV21.Text = ""
        LblRevV22.Text = ""

        LblRevD1.Text = ""
        LblRevD2.Text = ""
        LblRevD3.Text = ""
        LblRevD4.Text = ""
        LblRevD5.Text = ""
        LblRevD6.Text = ""
        LblRevD7.Text = ""
        LblRevD8.Text = ""
        LblRevD9.Text = ""
        LblRevD10.Text = ""
        LblRevD11.Text = ""
        LblRevD12.Text = ""
        LblRevD13.Text = ""
        LblRevD14.Text = ""
        LblRevD15.Text = ""
        LblRevD16.Text = ""
        LblRevD17.Text = ""
        LblRevD18.Text = ""
        LblRevD19.Text = ""
        LblRevD20.Text = ""
        LblRevD21.Text = ""
        LblRevD22.Text = ""

        LblSerV1.Text = ""
        LblSerV2.Text = ""
        LblSerV3.Text = ""
        LblSerV4.Text = ""
        LblSerV5.Text = ""
        LblSerV6.Text = ""
        LblSerV7.Text = ""
        LblSerV8.Text = ""
        LblSerV9.Text = ""
        LblSerV10.Text = ""
        LblSerV11.Text = ""
        LblSerV12.Text = ""
        LblSerV13.Text = ""
        LblSerV14.Text = ""
        LblSerV15.Text = ""
        LblSerV16.Text = ""
        LblSerV17.Text = ""
        LblSerV18.Text = ""
        LblSerV19.Text = ""
        LblSerV20.Text = ""
        LblSerV21.Text = ""
        LblSerV22.Text = ""

        LblSerD1.Text = ""
        LblSerD2.Text = ""
        LblSerD3.Text = ""
        LblSerD4.Text = ""
        LblSerD5.Text = ""
        LblSerD6.Text = ""
        LblSerD7.Text = ""
        LblSerD8.Text = ""
        LblSerD9.Text = ""
        LblSerD10.Text = ""
        LblSerD11.Text = ""
        LblSerD12.Text = ""
        LblSerD13.Text = ""
        LblSerD14.Text = ""
        LblSerD15.Text = ""
        LblSerD16.Text = ""
        LblSerD17.Text = ""
        LblSerD18.Text = ""
        LblSerD19.Text = ""
        LblSerD20.Text = ""
        LblSerD21.Text = ""
        LblSerD22.Text = ""

        LblOtr1.Text = ""
        LblOtr2.Text = ""
        LblOtr3.Text = ""
        LblOtr4.Text = ""
        LblOtr5.Text = ""
        LblOtr6.Text = ""
        LblOtr7.Text = ""
        LblOtr8.Text = ""
        LblOtr9.Text = ""
        LblOtr10.Text = ""
        LblOtr11.Text = ""
        LblOtr12.Text = ""
        LblOtr13.Text = ""
        LblOtr14.Text = ""
        LblOtr15.Text = ""
        LblOtr16.Text = ""
        LblOtr17.Text = ""
        LblOtr18.Text = ""
        LblOtr19.Text = ""
        LblOtr20.Text = ""
        LblOtr21.Text = ""
        LblOtr22.Text = ""

        LblObs1.Text = ""
        LblObs2.Text = ""
        LblObs3.Text = ""
        LblObs4.Text = ""
        LblObs5.Text = ""
        LblObs6.Text = ""
        LblObs7.Text = ""
        LblObs8.Text = ""
        LblObs9.Text = ""
        LblObs10.Text = ""
        LblObs11.Text = ""
        LblObs12.Text = ""
        LblObs13.Text = ""
        LblObs14.Text = ""
        LblObs15.Text = ""
        LblObs16.Text = ""
        LblObs17.Text = ""
        LblObs18.Text = ""
        LblObs19.Text = ""
        LblObs20.Text = ""
        LblObs21.Text = ""
        LblObs22.Text = ""



        LblcanEscVoz.Text = ""
        LblcanEscDatos.Text = ""
        LblcanFallaV.Text = ""
        LblcanFallaD.Text = ""
        lblcanIloVoz.Text = ""
        lblcanIloDatos.Text = ""
        lblcanSegVoz.Text = ""
        lblcanSegDatos.Text = ""
        LblcanRevV.Text = ""
        LblcanRevD.Text = ""
        lblcanSerV.Text = ""
        lblcanSerD.Text = ""
        lblcanFor.Text = ""
        lblcanmuni.Text = ""

        TotalEscV.Text = ""
        TotalEscD.Text = ""
        TotalFallV.Text = ""
        TotalFallD.Text = ""
        TotalIloV.Text = ""
        TotalIloD.Text = ""
        TotalSegV.Text = ""
        TotalSegD.Text = ""
        TotalRevV.Text = ""
        TotalRevD.Text = ""
        TotalSerV.Text = ""
        TotalSerD.Text = ""
        TotalForma.Text = ""
        TotalMuni.Text = ""


    End Sub
    Protected Sub suma()
        Try
            TotalEscV.Text = Val(LblEscVozfc1.Text) + Val(LblEscVozfc2.Text) + Val(LblEscVozfc3.Text) + Val(LblEscVozfc4.Text) + Val(LblEscVozfc5.Text) + Val(LblEscVozfc6.Text) + Val(LblEscVozfc7.Text) + Val(LblEscVozfc8.Text) + Val(LblEscVozfc9.Text) + Val(LblEscVozfc10.Text) + Val(LblEscVozfc11.Text) + Val(LblEscVozfc12.Text) + Val(LblEscVozfc13.Text) + Val(LblEscVozfc14.Text) + Val(LblEscVozfc15.Text) + Val(LblEscVozfc16.Text) + Val(LblEscVozfc17.Text) + Val(LblEscVozfc18.Text) + Val(LblEscVozfc19.Text) + Val(LblEscVozfc20.Text) + Val(LblEscVozfc21.Text) + Val(LblEscVozfc22.Text)
            TotalEscD.Text = Val(LblEscDatfc1.Text) + Val(LblEscDatfc2.Text) + Val(LblEscDatfc3.Text) + Val(LblEscDatfc4.Text) + Val(LblEscDatfc5.Text) + Val(LblEscDatfc6.Text) + Val(LblEscDatfc7.Text) + Val(LblEscDatfc8.Text) + Val(LblEscDatfc9.Text) + Val(LblEscDatfc10.Text) + Val(LblEscDatfc11.Text) + Val(LblEscDatfc12.Text) + Val(LblEscDatfc13.Text) + Val(LblEscDatfc14.Text) + Val(LblEscDatfc15.Text) + Val(LblEscDatfc16.Text) + Val(LblEscDatfc17.Text) + Val(LblEscDatfc18.Text) + Val(LblEscDatfc19.Text) + Val(LblEscDatfc20.Text) + Val(LblEscDatfc21.Text) + Val(LblEscDatfc22.Text)
            TotalFallV.Text = Val(LblFallVozfc1.Text) + Val(LblFallVozfc2.Text) + Val(LblFallVozfc3.Text) + Val(LblFallVozfc4.Text) + Val(LblFallVozfc5.Text) + Val(LblFallVozfc6.Text) + Val(LblFallVozfc7.Text) + Val(LblFallVozfc8.Text) + Val(LblFallVozfc9.Text) + Val(LblFallVozfc10.Text) + Val(LblFallVozfc11.Text) + Val(LblFallVozfc12.Text) + Val(LblFallVozfc13.Text) + Val(LblFallVozfc14.Text) + Val(LblFallVozfc15.Text) + Val(LblFallVozfc16.Text) + Val(LblFallVozfc17.Text) + Val(LblFallVozfc18.Text) + Val(LblFallVozfc19.Text) + Val(LblFallVozfc20.Text) + Val(LblFallVozfc21.Text) + Val(LblFallVozfc22.Text)
            TotalFallD.Text = Val(LblFallDatfc1.Text) + Val(LblFallDatfc2.Text) + Val(LblFallDatfc3.Text) + Val(LblFallDatfc4.Text) + Val(LblFallDatfc5.Text) + Val(LblFallDatfc6.Text) + Val(LblFallDatfc7.Text) + Val(LblFallDatfc8.Text) + Val(LblFallDatfc9.Text) + Val(LblFallDatfc10.Text) + Val(LblFallDatfc11.Text) + Val(LblFallDatfc12.Text) + Val(LblFallDatfc13.Text) + Val(LblFallDatfc14.Text) + Val(LblFallDatfc15.Text) + Val(LblFallDatfc16.Text) + Val(LblFallDatfc17.Text) + Val(LblFallDatfc18.Text) + Val(LblFallDatfc19.Text) + Val(LblFallDatfc20.Text) + Val(LblFallDatfc21.Text) + Val(LblFallDatfc22.Text)
            TotalIloV.Text = Val(LblIloVfc1.Text) + Val(LblIloVfc2.Text) + Val(LblIloVfc3.Text) + Val(LblIloVfc4.Text) + Val(LblIloVfc5.Text) + Val(LblIloVfc6.Text) + Val(LblIloVfc7.Text) + Val(LblIloVfc8.Text) + Val(LblIloVfc9.Text) + Val(LblIloVfc10.Text) + Val(LblIloVfc11.Text) + Val(LblIloVfc12.Text) + Val(LblIloVfc13.Text) + Val(LblIloVfc14.Text) + Val(LblIloVfc15.Text) + Val(LblIloVfc16.Text) + Val(LblIloVfc17.Text) + Val(LblIloVfc18.Text) + Val(LblIloVfc19.Text) + Val(LblIloVfc20.Text) + Val(LblIloVfc21.Text) + Val(LblIloVfc22.Text)
            TotalIloD.Text = Val(LblIloDfc1.Text) + Val(LblIloDfc2.Text) + Val(LblIloDfc3.Text) + Val(LblIloDfc4.Text) + Val(LblIloDfc5.Text) + Val(LblIloDfc6.Text) + Val(LblIloDfc7.Text) + Val(LblIloDfc8.Text) + Val(LblIloDfc9.Text) + Val(LblIloDfc10.Text) + Val(LblIloDfc11.Text) + Val(LblIloDfc12.Text) + Val(LblIloDfc13.Text) + Val(LblIloDfc14.Text) + Val(LblIloDfc15.Text) + Val(LblIloDfc16.Text) + Val(LblIloDfc17.Text) + Val(LblIloDfc18.Text) + Val(LblIloDfc19.Text) + Val(LblIloDfc20.Text) + Val(LblIloDfc21.Text) + Val(LblIloDfc22.Text)
            TotalSegV.Text = Val(LblSegV1.Text) + Val(LblSegV2.Text) + Val(LblSegV3.Text) + Val(LblSegV4.Text) + Val(LblSegV5.Text) + Val(LblSegV6.Text) + Val(LblSegV7.Text) + Val(LblSegV8.Text) + Val(LblSegV9.Text) + Val(LblSegV10.Text) + Val(LblSegV11.Text) + Val(LblSegV12.Text) + Val(LblSegV13.Text) + Val(LblSegV14.Text) + Val(LblSegV15.Text) + Val(LblSegV16.Text) + Val(LblSegV17.Text) + Val(LblSegV18.Text) + Val(LblSegV19.Text) + Val(LblSegV20.Text) + Val(LblSegV21.Text) + Val(LblSegV22.Text)
            TotalSegD.Text = Val(LblSegD1.Text) + Val(LblSegD2.Text) + Val(LblSegD3.Text) + Val(LblSegD4.Text) + Val(LblSegD5.Text) + Val(LblSegD6.Text) + Val(LblSegD7.Text) + Val(LblSegD8.Text) + Val(LblSegD9.Text) + Val(LblSegD10.Text) + Val(LblSegD11.Text) + Val(LblSegD12.Text) + Val(LblSegD13.Text) + Val(LblSegD14.Text) + Val(LblSegD15.Text) + Val(LblSegD16.Text) + Val(LblSegD17.Text) + Val(LblSegD18.Text) + Val(LblSegD19.Text) + Val(LblSegD20.Text) + Val(LblSegD21.Text) + Val(LblSegD22.Text)
            TotalRevV.Text = Val(LblRevV1.Text) + Val(LblRevV2.Text) + Val(LblRevV3.Text) + Val(LblRevV4.Text) + Val(LblRevV5.Text) + Val(LblRevV6.Text) + Val(LblRevV7.Text) + Val(LblRevV8.Text) + Val(LblRevV9.Text) + Val(LblRevV10.Text) + Val(LblRevV11.Text) + Val(LblRevV12.Text) + Val(LblRevV13.Text) + Val(LblRevV14.Text) + Val(LblRevV15.Text) + Val(LblRevV16.Text) + Val(LblRevV17.Text) + Val(LblRevV18.Text) + Val(LblRevV19.Text) + Val(LblRevV20.Text) + Val(LblRevV21.Text) + Val(LblRevV22.Text)
            TotalRevD.Text = Val(LblRevD1.Text) + Val(LblRevD2.Text) + Val(LblRevD3.Text) + Val(LblRevD4.Text) + Val(LblRevD5.Text) + Val(LblRevD6.Text) + Val(LblRevD7.Text) + Val(LblRevD8.Text) + Val(LblRevD9.Text) + Val(LblRevD10.Text) + Val(LblRevD11.Text) + Val(LblRevD12.Text) + Val(LblRevD13.Text) + Val(LblRevD14.Text) + Val(LblRevD15.Text) + Val(LblRevD16.Text) + Val(LblRevD17.Text) + Val(LblRevD18.Text) + Val(LblRevD19.Text) + Val(LblRevD20.Text) + Val(LblRevD21.Text) + Val(LblRevD22.Text)
            TotalSerV.Text = Val(LblSerV1.Text) + Val(LblSerV2.Text) + Val(LblSerV3.Text) + Val(LblSerV4.Text) + Val(LblSerV5.Text) + Val(LblSerV6.Text) + Val(LblSerV7.Text) + Val(LblSerV8.Text) + Val(LblSerV9.Text) + Val(LblSerV10.Text) + Val(LblSerV11.Text) + Val(LblSerV12.Text) + Val(LblSerV13.Text) + Val(LblSerV14.Text) + Val(LblSerV15.Text) + Val(LblSerV16.Text) + Val(LblSerV17.Text) + Val(LblSerV18.Text) + Val(LblSerV19.Text) + Val(LblSerV20.Text) + Val(LblSerV21.Text) + Val(LblSerV22.Text)
            TotalSerD.Text = Val(LblSerD1.Text) + Val(LblSerD2.Text) + Val(LblSerD3.Text) + Val(LblSerD4.Text) + Val(LblSerD5.Text) + Val(LblSerD6.Text) + Val(LblSerD7.Text) + Val(LblSerD8.Text) + Val(LblSerD9.Text) + Val(LblSerD10.Text) + Val(LblSerD11.Text) + Val(LblSerD12.Text) + Val(LblSerD13.Text) + Val(LblSerD14.Text) + Val(LblSerD15.Text) + Val(LblSerD16.Text) + Val(LblSerD17.Text) + Val(LblSerD18.Text) + Val(LblSerD19.Text) + Val(LblSerD20.Text) + Val(LblSerD21.Text) + Val(LblSerD22.Text)
            TotalForma.Text = Val(LblOtr1.Text) + Val(LblOtr2.Text) + Val(LblOtr3.Text) + Val(LblOtr4.Text) + Val(LblOtr5.Text) + Val(LblOtr6.Text) + Val(LblOtr7.Text) + Val(LblOtr8.Text) + Val(LblOtr9.Text) + Val(LblOtr10.Text) + Val(LblOtr11.Text) + Val(LblOtr12.Text) + Val(LblOtr13.Text) + Val(LblOtr14.Text) + Val(LblOtr15.Text) + Val(LblOtr16.Text) + Val(LblOtr17.Text) + Val(LblOtr18.Text) + Val(LblOtr19.Text) + Val(LblOtr20.Text) + Val(LblOtr21.Text) + Val(LblOtr22.Text)
            TotalMuni.Text = Val(LblObs1.Text) + Val(LblObs2.Text) + Val(LblObs3.Text) + Val(LblObs4.Text) + Val(LblObs5.Text) + Val(LblObs6.Text) + Val(LblObs7.Text) + Val(LblObs8.Text) + Val(LblObs9.Text) + Val(LblObs10.Text) + Val(LblObs11.Text) + Val(LblObs12.Text) + Val(LblObs13.Text) + Val(LblObs14.Text) + Val(LblObs15.Text) + Val(LblObs16.Text) + Val(LblObs17.Text) + Val(LblObs18.Text) + Val(LblObs19.Text) + Val(LblObs20.Text) + Val(LblObs21.Text) + Val(LblObs22.Text)


        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Escala.Visible = True
            BtnExpo.Visible = True
            BtnDimen.Visible = True
            LimpiarLbls()
            CargarFechas()
            EscalamientoVoz()
            EscalamientoDatos()
            FallatecVoz()
            FallatecDatos()
            IlocalizablesVoz()
            IlocalizablesDatos()
            SeguimientoDatos()
            SeguimientoVoz()
            RevisionVoz()
            RevisionDatos()
            ServiceDatos()
            ServiceVoz()
            OtrosFormatos()
            municipios()
            suma()

            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnDimen_Click(sender As Object, e As EventArgs) Handles BtnDimen.Click
        Try
            Dimen.Visible = True
            DtgDimen.Visible = True
            EscaV.Text = TotalEscV.Text
            EscaD.Text = TotalEscD.Text
            FallaV.Text = TotalFallV.Text
            FallaD.Text = TotalFallD.Text
            IlocV.Text = TotalIloV.Text
            IlocD.Text = TotalIloD.Text
            SeguV.Text = TotalSegV.Text
            SeguD.Text = TotalSegD.Text
            ReviV.Text = TotalRevV.Text
            ReviD.Text = TotalRevD.Text
            ServV.Text = TotalSerV.Text
            ServD.Text = TotalSerD.Text
            Forma.Text = TotalForma.Text
            Munic.Text = TotalMuni.Text

            EscV.Text = 42
            EscD.Text = 42
            FallV.Text = 60
            FallD.Text = 60
            IloV.Text = 500
            IloD.Text = 500
            SegV.Text = 500
            SegD.Text = 500
            RevV.Text = 500
            RevD.Text = 500
            SerV.Text = 30
            SerD.Text = 30
            Form.Text = 300
            Muni.Text = 1000


            calcular()


        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub calcular()
        Try
            EscaV0.Text = Math.Round(Val(EscaV.Text) / Val(EscV.Text))
            EscaD0.Text = Math.Round(Val(EscaD.Text) / Val(EscD.Text))
            FallaV0.Text = Math.Round(Val(FallaV.Text) / Val(FallV.Text))
            FallaD0.Text = Math.Round(Val(FallaD.Text) / Val(FallD.Text))
            IlocV0.Text = Math.Round(Val(IlocV.Text) / Val(IloV.Text))
            IlocD0.Text = Math.Round(Val(IlocD.Text) / Val(IloD.Text))
            SeguV0.Text = Math.Round(Val(SeguV.Text) / Val(SegV.Text))
            SeguD0.Text = Math.Round(Val(SeguD.Text) / Val(SegD.Text))
            ReviV0.Text = Math.Round(Val(ReviV.Text) / Val(RevV.Text))
            ReviD0.Text = Math.Round(Val(ReviD.Text) / Val(RevD.Text))
            ServV0.Text = Math.Round(Val(ServV.Text) / Val(SerV.Text))
            ServD0.Text = Math.Round(Val(ServD.Text) / Val(SerD.Text))
            Forma0.Text = Math.Round(Val(Forma.Text) / Val(Form.Text))
            Munic0.Text = Math.Round(Val(Munic.Text) / Val(Muni.Text))

            Asesoresuma.Text = Val(EscaV0.Text) + Val(EscaD0.Text) + Val(FallaV0.Text) + Val(FallaD0.Text) + Val(IlocV0.Text) + Val(IlocD0.Text) + Val(SeguV0.Text) + Val(SeguD0.Text) + Val(ReviV0.Text) + Val(ReviD0.Text) + Val(ServV0.Text) + Val(ServD0.Text) + Val(Forma0.Text) + Val(Munic0.Text)

            Dim dts As New DataSet
            dts = objinformes.Dimensio
            If dts.Tables(0).Rows(0).Item("total") <> 0 Then
                Asesores.Text = dts.Tables(0).Rows(0).Item("total")
            End If
            Dias.Text = Math.Round(Val(Asesoresuma.Text) / Val(Asesores.Text), 1)
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub ExportarDimen()
        Try
            DtgDimen.Visible = True
            Dim dt As New DataTable()
            'columnas


            dt.Columns.Add(DiaAC.Text)
            dt.Columns.Add("Escalamiento Voz")
            dt.Columns.Add("Escalamiento Datos")
            dt.Columns.Add("Fallatec Voz")
            dt.Columns.Add("Fallatec Datos")
            dt.Columns.Add("Ilocalizable voz")
            dt.Columns.Add("Ilocalizable Datos")
            dt.Columns.Add("Seguimiento Voz")
            dt.Columns.Add("Seguimiento Datos")
            dt.Columns.Add("Revision Voz")
            dt.Columns.Add("Revision Datos")
            dt.Columns.Add("Service Voz")
            dt.Columns.Add("Service Datos")
            dt.Columns.Add("Formatos")
            dt.Columns.Add("Municipios")
            dt.Columns.Add("TOTAL DE ASESORES")


            Dim row As DataRow = dt.NewRow()
            row(DiaAC.Text) = "TOTAL"
            row("Escalamiento Voz") = EscaV.Text
            row("Escalamiento Datos") = EscaD.Text
            row("Fallatec Voz") = FallaV.Text
            row("Fallatec Datos") = FallaD.Text
            row("Ilocalizable voz") = IlocV.Text
            row("Ilocalizable Datos") = IlocD.Text
            row("Seguimiento Voz") = SeguV.Text
            row("Seguimiento Datos") = SeguD.Text
            row("Revision Voz") = ReviV.Text
            row("Revision Datos") = ReviD.Text
            row("Service Voz") = ServV.Text
            row("Service Datos") = ServD.Text
            row("Formatos") = Forma.Text
            row("Municipios") = Munic.Text
            dt.Rows.Add(row)

            Dim row1 As DataRow = dt.NewRow()
            row1(DiaAC.Text) = "GESTIONES" & vbLf & " DIARIAS POR" & vbLf & " CAMPAÑA"
            row1("Escalamiento Voz") = EscV.Text
            row1("Escalamiento Datos") = EscD.Text
            row1("Fallatec Voz") = FallV.Text
            row1("Fallatec Datos") = FallD.Text
            row1("Ilocalizable voz") = IloV.Text
            row1("Ilocalizable Datos") = IloD.Text
            row1("Seguimiento Voz") = SegV.Text
            row1("Seguimiento Datos") = SegD.Text
            row1("Revision Voz") = RevV.Text
            row1("Revision Datos") = RevD.Text
            row1("Service Voz") = SerV.Text
            row1("Service Datos") = SerD.Text
            row1("Formatos") = Form.Text
            row1("Municipios") = Muni.Text
            dt.Rows.Add(row1)

            Dim row2 As DataRow = dt.NewRow()
            row2(DiaAC.Text) = "NUMERO DE ASESORES PARA QUEDAR AL DIA"
            row2("Escalamiento Voz") = EscaV0.Text
            row2("Escalamiento Datos") = EscaD0.Text
            row2("Fallatec Voz") = FallaV0.Text
            row2("Fallatec Datos") = FallaD0.Text
            row2("Ilocalizable voz") = IlocV0.Text
            row2("Ilocalizable Datos") = IlocD0.Text
            row2("Seguimiento Voz") = SeguV0.Text
            row2("Seguimiento Datos") = SeguD0.Text
            row2("Revision Voz") = ReviV0.Text
            row2("Revision Datos") = ReviD0.Text
            row2("Service Voz") = ServV0.Text
            row2("Service Datos") = ServD0.Text
            row2("Formatos") = Forma0.Text
            row2("Municipios") = Munic0.Text
            row2("TOTAL DE ASESORES") = Asesoresuma.Text
            dt.Rows.Add(row2)



            Dim row3 As DataRow = dt.NewRow()
            row3(DiaAC.Text) = "CANTIDAD DE ASESORES ACTUALMENTE"
            row3("Escalamiento Voz") = Asesores.Text
            dt.Rows.Add(row3)

            Dim row4 As DataRow = dt.NewRow()
            row4(DiaAC.Text) = "CANTIDAD DE DIAS PARA QUEDAR AL DIA"
            row4("Escalamiento Voz") = Dias.Text
            dt.Rows.Add(row4)

            'enlazas datatable a griedview
            DtgDimen.DataSource = dt
            DtgDimen.DataBind()

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub DtgDimen_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles DtgDimen.RowDataBound
        Try
            Select Case e.Row.RowType
                Case DataControlRowType.Header
                    e.Row.Cells(15).RowSpan = 3
                    e.Row.Cells(15).BackColor = Drawing.Color.Black
            End Select

        If (e.Row.RowType = DataControlRowType.DataRow) Then
                If DataBinder.Eval(e.Row.DataItem, "TOTAL DE ASESORES") Is DBNull.Value Then
                    e.Row.Cells(15).BackColor = Drawing.Color.White
                Else
                    e.Row.Cells(15).BackColor = Drawing.Color.FromName("#92D050")
                End If
                If DataBinder.Eval(e.Row.DataItem, DiaAC.Text) = "TOTAL" Then
                    e.Row.Cells(0).BackColor = Drawing.Color.White
                Else
                    e.Row.Cells(0).BackColor = Drawing.Color.FromName("#002060")
                    e.Row.Cells(0).ForeColor = Drawing.Color.White
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try

    End Sub
End Class
