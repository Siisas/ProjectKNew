Public Class estadisticasvoz
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                traemes()
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
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Private Sub limpia()
        lblvlr1.Text = ""
        lblvlr2.Text = ""
        lblvlr3.Text = ""
        lblvlr4.Text = ""
        lblvlr5.Text = ""
        lblvlr6.Text = ""
        lblvlr7.Text = ""
        lblvlr8.Text = ""
        lblvlr9.Text = ""
        lblvlr10.Text = ""
        lblp1.Text = ""
        lblp2.Text = ""
        lblp3.Text = ""
        lblp4.Text = ""
        lblp5.Text = ""
        lblp6.Text = ""
        lblp7.Text = ""
        lblp8.Text = ""
        lblp9.Text = ""
        lblp10.Text = ""
        lbltit1.Text = ""
        lbltit2.Text = ""
        lbltit3.Text = ""
        lbltit4.Text = ""
        lbltit5.Text = ""
        lbltit6.Text = ""
        lbltit7.Text = ""
        lbltit8.Text = ""
        lbltit9.Text = ""
        lbltit10.Text = ""
        lbltotal.Text = ""
        lblilocpotencial.Text = ""
        lblptes.Text = ""
        lblpilocpotencial.Text = ""
        lblpptes.Text = ""
        lblcierre.Text = ""
        lblpcierre.Text = ""
        lblgestion.Text = ""
        lblpgestion.Text = ""
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            limpia()
            Dim objdatos As New clsvoz
            If txtfcini.Text = "" Then
                lblmsg.Text = "Digite la fecha inicial para generar el reporte"
                Exit Sub
            Else
                objdatos.fcini = txtfcini.Text
            End If
            If txtfcfin.Text = "" Then
                lblmsg.Text = "Digite la fecha final para generar el reporte"
                Exit Sub
            Else
                objdatos.fcfin = txtfcfin.Text
            End If
            objdatos.estadisticagralvoz()
            If objdatos.cantidad = 0 Then
                lblmsg.Text = "No se encontraron registros para las fechas buscadas"
            Else
                dtggeneral.DataSource = objdatos.estadisticagralvoz
                dtggeneral.DataBind()
                lblcantidad.Text = objdatos.cantidad
                asigna()
                suma()
                pendientes()
                formato()
                lblmsg.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Private Sub asigna()
        Try
            Dim celda As Integer
            Dim valor As String
            celda = 1

            For Each row As GridViewRow In dtggeneral.Rows
                valor = CStr(row.Cells(0).Text)
                If celda = 1 Then
                    lbltit1.Text = valor
                End If
                If celda = 2 Then
                    lbltit2.Text = valor
                End If
                If celda = 3 Then
                    lbltit3.Text = valor
                End If
                If celda = 4 Then
                    lbltit4.Text = valor
                End If
                If celda = 5 Then
                    lbltit5.Text = valor
                End If
                If celda = 6 Then
                    lbltit6.Text = valor
                End If
                If celda = 7 Then
                    lbltit7.Text = valor
                End If
                If celda = 8 Then
                    lbltit8.Text = valor
                End If
                If celda = 9 Then
                    lbltit9.Text = valor
                End If
                If celda = 10 Then
                    lbltit10.Text = valor
                End If
                celda = celda + 1
            Next
            celda = 1
            For Each row As GridViewRow In dtggeneral.Rows
                valor = CStr(row.Cells(1).Text)
                If celda = 1 Then
                    lblvlr1.Text = valor
                End If
                If celda = 2 Then
                    lblvlr2.Text = valor
                End If
                If celda = 3 Then
                    lblvlr3.Text = valor
                End If
                If celda = 4 Then
                    lblvlr4.Text = valor
                End If
                If celda = 5 Then
                    lblvlr5.Text = valor
                End If
                If celda = 6 Then
                    lblvlr6.Text = valor
                End If
                If celda = 7 Then
                    lblvlr7.Text = valor
                End If
                If celda = 8 Then
                    lblvlr8.Text = valor
                End If
                If celda = 9 Then
                    lblvlr9.Text = valor
                End If
                If celda = 10 Then
                    lblvlr10.Text = valor
                End If
                celda = celda + 1
            Next
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Private Sub suma()
        Try
            If lblvlr3.Text = "" Then
                lblvlr3.Text = 0
            End If
            If lblvlr4.Text = "" Then
                lblvlr4.Text = 0
            End If
            If lblvlr5.Text = "" Then
                lblvlr5.Text = 0
            End If
            If lblvlr6.Text = "" Then
                lblvlr6.Text = 0
            End If
            If lblvlr7.Text = "" Then
                lblvlr7.Text = 0
            End If
            If lblvlr8.Text = "" Then
                lblvlr8.Text = 0
            End If
            If lblvlr9.Text = "" Then
                lblvlr9.Text = 0
            End If
            If lblvlr10.Text = "" Then
                lblvlr10.Text = 0
            End If
            lbltotal.Text = Convert.ToInt32(lblvlr1.Text) + Convert.ToInt32(lblvlr2.Text) + Convert.ToInt32(lblvlr3.Text) + Convert.ToInt32(lblvlr4.Text) + Convert.ToInt32(lblvlr5.Text) + Convert.ToInt32(lblvlr6.Text) + Convert.ToInt32(lblvlr7.Text) + Convert.ToInt32(lblvlr8.Text) + Convert.ToInt32(lblvlr9.Text) + Convert.ToInt32(lblvlr10.Text)
            lblp1.Text = FormatPercent(Convert.ToInt32(lblvlr1.Text) / Convert.ToInt32(lbltotal.Text))
            lblp2.Text = FormatPercent(Convert.ToInt32(lblvlr2.Text) / Convert.ToInt32(lbltotal.Text))
            lblp3.Text = FormatPercent(Convert.ToInt32(lblvlr3.Text) / Convert.ToInt32(lbltotal.Text))
            lblp4.Text = FormatPercent(Convert.ToInt32(lblvlr4.Text) / Convert.ToInt32(lbltotal.Text))
            lblp5.Text = FormatPercent(Convert.ToInt32(lblvlr5.Text) / Convert.ToInt32(lbltotal.Text))
            lblp6.Text = FormatPercent(Convert.ToInt32(lblvlr6.Text) / Convert.ToInt32(lbltotal.Text))
            lblp7.Text = FormatPercent(Convert.ToInt32(lblvlr7.Text) / Convert.ToInt32(lbltotal.Text))
            lblp8.Text = FormatPercent(Convert.ToInt32(lblvlr8.Text) / Convert.ToInt32(lbltotal.Text))
            lblp9.Text = FormatPercent(Convert.ToInt32(lblvlr9.Text) / Convert.ToInt32(lbltotal.Text))
            lblp10.Text = FormatPercent(Convert.ToInt32(lblvlr10.Text) / Convert.ToInt32(lbltotal.Text))
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Private Sub pendientes()
        Try
            Dim objdatos As New clsvoz
            objdatos.fcini = txtfcini.Text
            objdatos.fcfin = txtfcfin.Text
            'pendientes
            objdatos.estadisticaptesvoz()
            lblptes.Text = objdatos.caso
            'ilocalizables
            objdatos.estadisticailocvoz()
            lblilocpotencial.Text = objdatos.caso
            'gestionados
            objdatos.estadisticagestionvoz()
            lblgestion.Text = objdatos.caso
            'cerrados
            lblcierre.Text = Convert.ToInt32(lbltotal.Text) - Convert.ToInt32(lblptes.Text)

            lblpptes.Text = FormatPercent(Convert.ToInt32(lblptes.Text) / Convert.ToInt32(lbltotal.Text))
            lblpilocpotencial.Text = FormatPercent(Convert.ToInt32(lblilocpotencial.Text) / Convert.ToInt32(lbltotal.Text))
            lblpgestion.Text = FormatPercent(Convert.ToInt32(lblgestion.Text) / Convert.ToInt32(lbltotal.Text))
            lblpcierre.Text = FormatPercent(Convert.ToInt32(lblcierre.Text) / Convert.ToInt32(lbltotal.Text))
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Private Sub formato()
        Try
            lblvlr1.Text = FormatNumber(lblvlr1.Text, 0)
            lblvlr2.Text = FormatNumber(lblvlr2.Text, 0)
            lblvlr3.Text = FormatNumber(lblvlr3.Text, 0)
            lblvlr4.Text = FormatNumber(lblvlr4.Text, 0)
            lblvlr5.Text = FormatNumber(lblvlr5.Text, 0)
            lblvlr6.Text = FormatNumber(lblvlr6.Text, 0)
            lblvlr7.Text = FormatNumber(lblvlr7.Text, 0)
            lblvlr8.Text = FormatNumber(lblvlr8.Text, 0)
            lblvlr9.Text = FormatNumber(lblvlr9.Text, 0)
            lblvlr10.Text = FormatNumber(lblvlr10.Text, 0)
            lbltotal.Text = FormatNumber(lbltotal.Text, 0)
            lblptes.Text = FormatNumber(lblptes.Text, 0)
            lblgestion.Text = FormatNumber(lblgestion.Text, 0)
            lblcierre.Text = FormatNumber(lblcierre.Text, 0)
            lblilocpotencial.Text = FormatNumber(lblilocpotencial.Text, 0)
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        traemes()
    End Sub
    Private Sub traemes()
        Try
            Dim objdatos As New clsvoz
            Dim rata As Decimal
            'casos proyectados a recibir
            objdatos.casosmesvoz()
            If txtprrecep.Text = "" Then
                lblmesact.Text = (objdatos.caso) * 1.05
            Else
                rata = txtprrecep.Text
                lblmesact.Text = (objdatos.caso) * rata
            End If

            'casos proyectados de cierre
            objdatos.casosmescierrevoz()
            If txtprccierre.Text = "" Then
                lblcierrem.Text = (objdatos.caso) * 1.05
            Else
                rata = txtprccierre.Text
                lblcierrem.Text = (objdatos.caso) * rata
            End If

            'casos cerrados actual
            objdatos.casosmescierreactvoz()
            lbleject.Text = objdatos.caso

            'porcentaje de cumplimiento
            lblpcumplim.Text = FormatPercent(Convert.ToDecimal(lbleject.Text) / Convert.ToDecimal(lblcierrem.Text))

            'peresonal disponible
            If txtpersona.Text = "" Then
                objdatos.personaldispvoz()
                lblpersonal.Text = objdatos.cantidad
            Else
                lblpersonal.Text = txtpersona.Text
            End If


            'casos por persona
            If txtcasosxp.Text = "" Then
                lblcasosxp.Text = 25
            Else
                lblcasosxp.Text = txtcasosxp.Text
            End If

            'dias para cierre
            If txtdxcierre.Text = "" Then
                Dim fecha2 As DateTime
                fecha2 = New DateTime(Today.Year, Today.Month + 1, 1).AddDays(-1)
                'primermes = FormatDateTime("01/" & (Month(Today) + 1) & "/" & Year(Today))
                lbldxcierre.Text = DateDiff("d", Today, fecha2)
            Else
                lbldxcierre.Text = txtdxcierre.Text
            End If

            'calcula final
            If lblcasosxp.Text <> "" And lbldxcierre.Text <> "" And lblpersonal.Text <> "" Then
                lblcasosproyect.Text = FormatNumber(((lblcasosxp.Text * lbldxcierre.Text * lblpersonal.Text)) + lbleject.Text, 0)
                lblejectmes.Text = FormatPercent(Convert.ToDecimal(lblcasosproyect.Text) / Convert.ToDecimal(lblcierrem.Text))
            End If

            'formato
            lblmesact.Text = FormatNumber(lblmesact.Text, 0)
            lblcierrem.Text = FormatNumber(lblcierrem.Text, 0)
            lbleject.Text = FormatNumber(lbleject.Text, 0)
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
End Class