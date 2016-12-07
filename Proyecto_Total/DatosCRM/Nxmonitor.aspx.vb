Imports System.IO

Public Class Nxmonitor
    Inherits System.Web.UI.Page
    Dim objinf As New clsInformes
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


    '' FECHA Y CONTACTOS SOPORTE DIA''
    Protected Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click

        Try
            If TxtFecha_inicio.Text = "" Then
                lblmsg.Text = "Ingrese una Fecha  para la Busqueda"
                Exit Sub
            End If

            Dim dts As DataSet
            Dim porcentaje As Double
            Dim cien As Double = 100
            objinf.Fcini = TxtFecha_inicio.Text
            dts = objinf.ConsultaDianx
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("fcreg") Is System.DBNull.Value Then
                    lblFecha.Text = ""
                Else
                    lblFecha.Text = dts.Tables(0).Rows(0).Item("fcreg")
                End If
                If dts.Tables(0).Rows(0).Item("Cantidad") Is System.DBNull.Value Then
                    lblfalla1.Text = ""
                Else
                    lblfalla1.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                End If
            Else
                lblmsg.Text = "No se encontraron Registros"
                Exportar.Visible = False
                lblFecha.Text = ""
                lblfalla1.Text = ""
                lblfalla2.Text = ""
                lblporcen1.Text = ""
                lblporcenfin.Text = ""
                lblfalla4.Text = ""
                lblfalla5.Text = ""
                lblfalla6.Text = ""
                lblfalla7.Text = ""
                lblfalla8.Text = ""
                lblfalla9.Text = ""
                lblfalla10.Text = ""
                lblfalla11.Text = ""
                lblfalla12.Text = ""
                lblfalla13.Text = ""
                lblfalla14.Text = ""
                lblfalla15.Text = ""
                lblfalla16.Text = ""
                lblfalla17.Text = ""
                lblfalla18.Text = ""
                Exit Sub
            End If

            '"Ofrecimientos Nx Monitor" Y "% Ofrecimiento / Contacto"
            objinf.Fcini = TxtFecha_inicio.Text
            dts = objinf.Consulta_Nxmonitor_2
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cantidad") Is DBNull.Value Then
                    lblfalla2.Text = ""
                Else
                    lblfalla2.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                    porcentaje = lblfalla2.Text / lblfalla1.Text
                    lblporcen1.Text = Math.Round(porcentaje, 2) * 100 & "%"
                End If
            Else
                lblmsg.Text = "No se encontraron Registros"
                Exportar.Visible = False
                lblFecha.Text = ""
                lblfalla1.Text = ""
                lblfalla2.Text = ""
                lblporcen1.Text = ""
                lblporcenfin.Text = ""
                lblfalla4.Text = ""
                lblfalla5.Text = ""
                lblfalla6.Text = ""
                lblfalla7.Text = ""
                lblfalla8.Text = ""
                lblfalla9.Text = ""
                lblfalla10.Text = ""
                lblfalla11.Text = ""
                lblfalla12.Text = ""
                lblfalla13.Text = ""
                lblfalla14.Text = ""
                lblfalla15.Text = ""
                lblfalla16.Text = ""
                lblfalla17.Text = ""
                lblfalla18.Text = ""
            End If
            '"Instala Nx Monitor en Llamada"
            objinf.Fcini = TxtFecha_inicio.Text
            dts = objinf.Inst_Nxmonitor_llamada

            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cantidad") Is DBNull.Value Then
                    lblfalla5.Text = ""
                Else
                    lblfalla5.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                End If
            End If

            '"Total Ofrecimientos"
            objinf.Fcini = TxtFecha_inicio.Text
            dts = objinf.Consulta_Nxmonitor_2
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cantidad") Is DBNull.Value Then
                    lblfalla4.Text = ""
                Else
                    lblfalla4.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                End If
            End If

            '"Informa Instalar Nx Monitor en otro Momento"
            objinf.Fcini = TxtFecha_inicio.Text
            dts = objinf.Inst_Nx_Mon_otro_Momen

            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cantidad") Is DBNull.Value Then
                    lblfalla6.Text = ""
                Else
                    lblfalla6.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                End If
            End If

            '"No le interesa instalar"
            objinf.Fcini = TxtFecha_inicio.Text
            dts = objinf.No_le_interesa_instalar
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cantidad") Is DBNull.Value Then
                    lblfalla7.Text = ""
                Else
                    lblfalla7.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                End If
            End If
            '"Prefiere que lo llamen despues para asesoria de instalacion"
            objinf.Fcini = TxtFecha_inicio.Text
            dts = objinf.Prefiere_qlo_llamen_despues
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cantidad") Is DBNull.Value Then
                    lblfalla8.Text = ""
                Else
                    lblfalla8.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                End If
            End If
            '"Otras causas"
            objinf.Fcini = TxtFecha_inicio.Text
            dts = objinf.Otras_Causas
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cantidad") Is DBNull.Value Then
                    lblfalla9.Text = ""
                Else
                    lblfalla9.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                End If
            End If
            '"Total"
            objinf.Fcini = TxtFecha_inicio.Text
            dts = objinf.Consulta_Nxmonitor_2
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cantidad") Is DBNull.Value Then
                    lblfalla10.Text = ""
                Else
                    lblfalla10.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                End If
            End If

            'metadiaria
            objinf.Fcini = TxtFecha_inicio.Text
            lblfalla12.Text = 650
            '' Meta ACUMULADA''
            lblfalla11.Text = (Day(TxtFecha_inicio.Text) * 650)
          

            '"Nx Monitor instalados diario"
            objinf.Fcini = TxtFecha_inicio.Text
            dts = objinf.Inst_Nxmonitor_llamada
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cantidad") Is DBNull.Value Then
                    lblfalla14.Text = ""
                Else
                    lblfalla14.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                    porcentaje = lblfalla14.Text / lblfalla12.Text
                    '"Cumplimiento meta Diaria"
                    lblfalla16.Text = Math.Round(porcentaje, 2) * 100 & "%"
                    porcentaje = lblfalla14.Text / lblfalla12.Text

                    lblfalla17.Text = Math.Round(porcentaje, 2) * 100 & "%"
                    porcentaje = lblfalla14.Text / lblfalla11.Text
                End If

            End If
            '"Cumplimiento meta Acumulada"
            objinf.Fcini = TxtFecha_inicio.Text
            dts = objinf.Inst_Nxmonitor_llamada
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cantidad") Is DBNull.Value Then
                    lblfalla14.Text = ""
                Else
                    lblfalla14.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                    lblfalla17.Text = Math.Round(porcentaje, 2) * 100
                    porcentaje = lblfalla14.Text / lblfalla11.Text
                End If
            End If

            ''''''''' 'Mes'''''''
            lblMes.Text = MonthName(Month(TxtFecha_inicio.Text))
            '"""""""""""""""""""""""""""""""""""""""""""""""""""""""""
            If objinf.Fcini = TxtFecha_inicio.Text Then
                dts = objinf.Nx_Mon_Potenciales
                '' Nxmonitor potenciales''
                If dts.Tables(0).Rows.Count > 0 Then
                    If dts.Tables(0).Rows(0).Item("Cantidad") Is DBNull.Value Then
                        lblfalla15.Text = ""
                    Else
                        lblfalla15.Text = dts.Tables(0).Rows(0).Item("Cantidad")
                    End If
                End If
            End If
            '"Nx Monitor instalados acumulado"


            Dim Cuenta1, cuenta2 As Integer
            Dim Fecha As Date
            Fecha = TxtFecha_inicio.Text
            Fecha = Fecha.AddDays(-1)
            objinf.Fcini = Fecha
            dts = objinf.Desviacion_meta_acumulada
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cantidad") Is DBNull.Value Then
                    Cuenta1 = 0
                Else
                    Cuenta1 = dts.Tables(0).Rows(0).Item("Cantidad")
                End If
                If dts.Tables(0).Rows(1).Item("Cantidad") Is DBNull.Value Then
                    cuenta2 = 0
                Else
                    cuenta2 = dts.Tables(0).Rows(1).Item("Cantidad")
                End If
            End If

            lblfalla13.Text = Cuenta1 + cuenta2

            ''DESVIACION META ACUMULADA ''
            lblfalla18.Text = 100 - Integer.Parse(lblfalla17.Text)
            lblfalla17.Text = lblfalla17.Text & "%"
            lblfalla18.Text = lblfalla18.Text + "%"
            Exportar.Visible = True
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    'CARGAR DATOS AL GridView

    Public Sub Cargar_Datos()
        Try
            Dim dt As New DataTable()
            'columnas
            dt.Columns.Add("fcreg")
            dt.Columns.Add("Requerimiento")
            dt.Columns.Add("Cantidad")

            Dim row As DataRow = dt.NewRow()
            row("fcreg") = lblFecha.Text
            row("Requerimiento") = Lbltip1.Text
            row("Cantidad") = lblfalla1.Text
            dt.Rows.Add(row)

            Dim row1 As DataRow = dt.NewRow()
            row1("fcreg") = lblFecha.Text
            row1("Requerimiento") = Lblofnxm.Text
            row1("Cantidad") = lblfalla2.Text
            dt.Rows.Add(row1)

            Dim row2 As DataRow = dt.NewRow()
            row2("fcreg") = lblFecha.Text
            row2("Requerimiento") = LabofrC.Text
            row2("Cantidad") = lblporcen1.Text
            dt.Rows.Add(row2)

            Dim row3 As DataRow = dt.NewRow()
            row3("fcreg") = lblFecha.Text
            row3("Requerimiento") = LblTotalOfr.Text
            row3("Cantidad") = lblfalla4.Text
            dt.Rows.Add(row3)

            Dim row4 As DataRow = dt.NewRow()
            row4("fcreg") = lblFecha.Text
            row4("Requerimiento") = Lblinstmon.Text
            row4("Cantidad") = lblfalla5.Text
            dt.Rows.Add(row4)

            Dim row5 As DataRow = dt.NewRow()
            row5("fcreg") = lblFecha.Text
            row5("Requerimiento") = Lblotromomen.Text
            row5("Cantidad") = lblfalla6.Text
            dt.Rows.Add(row5)

            Dim row6 As DataRow = dt.NewRow()
            row6("fcreg") = lblFecha.Text
            row6("Requerimiento") = Lblnointeresains.Text
            row6("Cantidad") = lblfalla7.Text
            dt.Rows.Add(row6)

            Dim row7 As DataRow = dt.NewRow()
            row7("fcreg") = lblFecha.Text
            row7("Requerimiento") = Lblprefllamendesp.Text
            row7("Cantidad") = lblfalla8.Text
            dt.Rows.Add(row7)

            Dim row8 As DataRow = dt.NewRow()
            row8("fcreg") = lblFecha.Text
            row8("Requerimiento") = Lblotrascausas.Text
            row8("Cantidad") = lblfalla9.Text
            dt.Rows.Add(row8)

            Dim row9 As DataRow = dt.NewRow()
            row9("fcreg") = lblFecha.Text
            row9("Requerimiento") = Lbltotal.Text
            row9("Cantidad") = lblfalla10.Text
            dt.Rows.Add(row9)

            Dim row10 As DataRow = dt.NewRow()
            row10("fcreg") = lblFecha.Text
            row10("Requerimiento") = Lblmetaacum.Text
            row10("Cantidad") = lblfalla11.Text
            dt.Rows.Add(row10)

            Dim row11 As DataRow = dt.NewRow()
            row11("fcreg") = lblFecha.Text
            row11("Requerimiento") = Lblmetadiaria.Text
            row11("Cantidad") = lblfalla12.Text
            dt.Rows.Add(row11)

            Dim row12 As DataRow = dt.NewRow()
            row12("fcreg") = lblFecha.Text
            row12("Requerimiento") = Lblinsacumulado.Text
            row12("Cantidad") = lblfalla13.Text
            dt.Rows.Add(row12)

            Dim row13 As DataRow = dt.NewRow()
            row13("fcreg") = lblFecha.Text
            row13("Requerimiento") = Lblinsdiario.Text
            row13("Cantidad") = lblfalla14.Text
            dt.Rows.Add(row13)

            Dim row14 As DataRow = dt.NewRow()
            row14("fcreg") = lblFecha.Text
            row14("Requerimiento") = Lblnxpotenciales.Text
            row14("Cantidad") = lblfalla15.Text
            dt.Rows.Add(row14)

            Dim row15 As DataRow = dt.NewRow()
            row15("fcreg") = lblFecha.Text
            row15("Requerimiento") = Lblcumplmetad.Text
            row15("Cantidad") = lblfalla16.Text
            dt.Rows.Add(row15)

            Dim row16 As DataRow = dt.NewRow()
            row16("fcreg") = lblFecha.Text
            row16("Requerimiento") = Lblcumpmacumu.Text
            row16("Cantidad") = lblfalla17.Text
            dt.Rows.Add(row16)

            Dim row17 As DataRow = dt.NewRow()
            row17("fcreg") = lblFecha.Text
            row17("Requerimiento") = Lbldesacum.Text
            row17("Cantidad") = lblfalla18.Text
            dt.Rows.Add(row17)

            'enlazas datatable a griedview
            dtggeneral.DataSource = dt
            dtggeneral.DataBind()

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
            dtggeneral.Visible = True
            form.Controls.Add(dtggeneral)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True

            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=Nxmonitor.xls")
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

End Class