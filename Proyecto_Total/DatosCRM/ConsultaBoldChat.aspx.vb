Imports System.IO
Public Class ConsultaBoldChat
    Inherits System.Web.UI.Page
    Dim ObjBoldChat As New clsBoldChat

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            pnl_message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Session("Formulario") = "Consulta  de Bold chat"
                Dim ObjBoldCaht As New clsBoldChat
                With drltipificacionll
                    .DataSource = ObjBoldCaht.consultatipificacion
                    .DataTextField = "tipificacion"
                    .DataValueField = "tipificacion"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            pnl_message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Sub buscarinf()
        Try
            pnl_message.CssClass = Nothing
            lblmsg.Text = Nothing
            'PnlBoldchat.Visible = False
            'PnlDatos.Visible = False
            'PnlDtgInforme.Visible = False
            'PnlSeguimientoVoz.Visible = False
            'PnlSegumientoDatos.Visible = False
            ' PnlVoz.Visible = False
            If txtcaso.Text = "" And txtcliente.Text = "" And txtmin.Text = "" And TxtFecha_Inicio_Recepcion.Text = "" And TxtFecha_Fin_Recepcion.Text = "" And TxtFecha_Inicio_Gestion.Text = "" And TxtFecha_Fin_Gestion.Text = "" And drltipificacionll.SelectedItem.Text = "- Seleccione -" Then
                pnl_message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite algún criterio de filtro antes de realizar la consulta"
                Exit Sub
            Else
                If TxtFecha_Inicio_Recepcion.Text <> Nothing And TxtFecha_Fin_Recepcion.Text <> Nothing Then
                    If Date.Parse(TxtFecha_Inicio_Recepcion.Text) > Date.Parse(TxtFecha_Fin_Recepcion.Text) Then
                        pnl_message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> La fecha de inicio Recepcion no puede ser mayor a la de fecha fin Recepcion"
                        Exit Sub
                    Else
                        lblmsg.Text = ""
                    End If
                End If
                If TxtFecha_Inicio_Gestion.Text <> Nothing And TxtFecha_Fin_Gestion.Text <> Nothing Then
                    If Date.Parse(TxtFecha_Inicio_Gestion.Text) > Date.Parse(TxtFecha_Fin_Gestion.Text) Then
                        pnl_message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> La fecha de inicio Gestion no puede ser mayor a la de fecha fin Gestion"
                        Exit Sub
                    Else
                        pnl_message.CssClass = Nothing
                        lblmsg.Text = Nothing
                    End If
                End If
            End If
            If txtmin.Text <> Nothing Then
                ObjBoldChat.Min_Ac = txtmin.Text
            End If
            If txtcaso.Text <> Nothing Then
                ObjBoldChat.Idcaso = txtcaso.Text
            End If
            If txtcliente.Text <> Nothing Then
                ObjBoldChat.Nom_Cliente = txtcliente.Text
            End If
            If drltipificacionll.SelectedItem.Text <> "- Seleccione -" Then
                ObjBoldChat.Estado = drltipificacionll.SelectedItem.Text
            End If
            If TxtFecha_Inicio_Recepcion.Text <> Nothing Then
                ObjBoldChat.Fecha_Inicio = TxtFecha_Inicio_Recepcion.Text
            End If
            If TxtFecha_Fin_Recepcion.Text <> Nothing Then
                ObjBoldChat.Fecha_Fin = TxtFecha_Fin_Recepcion.Text
            End If
            If TxtFecha_Inicio_Gestion.Text <> Nothing Then
                ObjBoldChat.Fecha_Inicio_Gestion = TxtFecha_Inicio_Gestion.Text
            End If
            If TxtFecha_Fin_Gestion.Text <> Nothing Then
                ObjBoldChat.Fecha_Fin_Gestion = TxtFecha_Fin_Gestion.Text
            End If
            ''''''''Consulta En las Bandejas segun por CASO, NOMBRE o NUMERO(MIN)'''''''
            If Left(txtmin.Text, 1) = "0" Or Left(txtcaso.Text, 1) = "0" Then
                Exit Sub
            ElseIf txtcaso.Text <> Nothing Or txtcliente.Text <> Nothing Or txtmin.Text <> Nothing Then
                ''''Datos
                Session("data") = ObjBoldChat.Datos_Consulta_Bandeja
                dtgDatos.DataSource = Session("data")
                dtgDatos.DataBind()
                lblCuentaDatos.Text = ObjBoldChat.Cantidad
                If ObjBoldChat.Cantidad = 0 Then
                    pnl_message.CssClass = Nothing
                    lblmsg.Text = Nothing
                End If

                ''''Voz
                Session("data") = ObjBoldChat.Voz_Consulta_Bandeja
                dtgVoz.DataSource = Session("data")
                dtgVoz.DataBind()
                lblCuentaVoz.Text = ObjBoldChat.Cantidad
                If ObjBoldChat.Cantidad = 0 Then
                    pnl_message.CssClass = Nothing
                    lblmsg.Text = Nothing
                End If
            End If

            ''''''''Consulta En la Bandeja Bolt segun por CASO, NOMBRE o NUMERO(MIN)'''''''
            If txtmin.Text <> Nothing Or txtcliente.Text <> Nothing Or txtcaso.Text <> Nothing Or TxtFecha_Inicio_Recepcion.Text <> Nothing Or TxtFecha_Fin_Recepcion.Text <> Nothing Then
                Session("dtsB") = ObjBoldChat.ConsultaBandeja_Bolt_Numero_NomCliente
                dtgBoldChat.DataSource = Session("dtsB")
                dtgBoldChat.DataBind()
                lblcuenta.Text = ObjBoldChat.Cantidad
            Else
                dtgBoldChat.DataSource = Nothing
                dtgBoldChat.DataBind()
                lblcuenta.Text = ""
            End If
            If drltipificacionll.SelectedItem.Text <> "- Seleccione -" Then
                Session("dtsB") = ObjBoldChat.Consulta_Estado_Casos_BoldChat
                dtgBoldChat.DataSource = Session("dtsB")
                dtgBoldChat.DataBind()
                lblcuenta.Text = ObjBoldChat.Cantidad
            End If


            '''''''' SEGUIMIENTO POR FECHAS ''''''''
            If TxtFecha_Inicio_Gestion.Text <> Nothing And TxtFecha_Fin_Gestion.Text <> Nothing Then
                ''VOZ
                Dim dsV
                dsV = ObjBoldChat.Consulta_Gestion_Voz
                Session("dtsV") = dsV
                dtgSeguimientoVoz.DataSource = dsV
                dtgSeguimientoVoz.DataBind()
                lblcuenta1.Text = ObjBoldChat.Cantidad
                ''DATOS
                Dim dsD As DataSet
                dsD = ObjBoldChat.Consulta_Gestion_Datos
                Session("dts2") = dsD
                dtgSeguimientoDatos.DataSource = dsD
                dtgSeguimientoDatos.DataBind()
                lblcuenta0.Text = ObjBoldChat.Cantidad
                dtgSeguimientoDatos.Visible = True
                Dim dsD2 As DataSet = ObjBoldChat.Consulta_Gestion_Datos
                Dim dtsg As DataSet
                Session("dtg") = dsD2
                Session("dtg").Merge(dsV, True, MissingSchemaAction.Add)
                Session("dtg").AcceptChanges()
                dtsg = Session("dtg")
                DtgInforme.DataSource = dtsg
                DtgInforme.DataBind()
                lblcuenta2.Text = Session("dtg").Tables(0).Rows.Count
            Else
                If TxtFecha_Inicio_Gestion.Text <> Nothing Or TxtFecha_Fin_Gestion.Text <> Nothing Then
                    If TxtFecha_Inicio_Gestion.Text <> Nothing Then
                        pnl_message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite fecha fin gestion"
                    End If
                    If TxtFecha_Fin_Gestion.Text <> Nothing Then
                        pnl_message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite fecha inicio gestion"
                    End If
                End If
                ''DATOS
                dtgSeguimientoDatos.Visible = False
                dtgSeguimientoVoz.Visible = False
                dtgSeguimientoDatos.DataSource = Nothing
                dtgSeguimientoDatos.DataBind()
                lblcuenta0.Text = ""
                ''VOZ
                dtgSeguimientoVoz.DataSource = Nothing
                dtgSeguimientoVoz.DataBind()
                lblcuenta1.Text = ""
            End If


            '''' Consulta por Estado del caso

        Catch ex As Exception
            pnl_message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        buscarinf()
        If ((lblcuenta.Text = "0" Or lblcuenta.Text = "") And (lblcuenta0.Text = "0" Or lblcuenta0.Text = "") And (lblcuenta1.Text = "0" Or lblcuenta1.Text = "")) Then
            PanelGeneral.Visible = False
        Else
            PanelGeneral.Visible = True
            If lblcuenta.Text = "0" Or lblcuenta.Text = "" Then
                LinkBtnInfBoldChat.Visible = False
                lblcuenta.Visible = False
            End If
            If lblcuenta0.Text = "0" Or lblcuenta0.Text = "" Then
                LinkBtnSeguimientoDatos.Visible = False
                lblcuenta0.Visible = False
            End If
            If lblcuenta1.Text = "0" Or lblcuenta1.Text = "" Then
                LinkBtnSeguimiento0.Visible = False
                lblcuenta1.Visible = False
            End If
            If lblcuenta2.Text = "0" Or lblcuenta2.Text = "" Then
                LinkBtnSeguimiento1.Visible = False
                lblcuenta2.Visible = False
            End If
        End If
        If lblCuentaDatos.Text = "0" Or lblCuentaDatos.Text = "" Then
            PanelDatos.Visible = False
        Else
            PanelDatos.Visible = True
        End If
        If lblCuentaVoz.Text = "0" Or lblCuentaVoz.Text = "" Then
            PanelVoz.Visible = False
        Else
            PanelVoz.Visible = True
        End If
        If (lblcuenta.Text = "0" Or lblcuenta.Text = "") And (lblcuenta0.Text = "0" Or lblcuenta0.Text = "") And (lblcuenta1.Text = "0" Or lblcuenta1.Text = "") And (lblcuenta2.Text = "0" Or lblcuenta2.Text = "") And (lblCuentaDatos.Text = "0" Or lblCuentaDatos.Text = "") And (lblCuentaVoz.Text = "0" Or lblCuentaVoz.Text = "") Then
            pnl_message.CssClass = "alert alert-info"
            lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros"
        Else
            pnl_message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Busqueda exitosa"
        End If


    End Sub

    Protected Sub LinkButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkBtnVoz.Click
        Try
            PnlDtgInforme.Visible = False
            PnlBoldchat.Visible = False
            PnlSeguimientoVoz.Visible = False
            PnlSegumientoDatos.Visible = False
            PnlDatos.Visible = False
            PnlVoz.Visible = True
            pnl_message.CssClass = Nothing
            lblmsg.Text = Nothing
            dtgVoz.Visible = True
        Catch ex As Exception
            pnl_message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span Class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub LinkButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkBtnDatos.Click
        Try
            PnlDtgInforme.Visible = False
            PnlBoldchat.Visible = False
            PnlSeguimientoVoz.Visible = False
            PnlSegumientoDatos.Visible = False
            PnlDatos.Visible = True
            PnlVoz.Visible = False
            pnl_message.CssClass = Nothing
            lblmsg.Text = Nothing
            dtgDatos.Visible = True
            dtgSeguimientoVoz.Visible = False
        Catch ex As Exception
            pnl_message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub LinkBtnInfGeneral_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkBtnInfBoldChat.Click
        Try
            PnlBoldchat.Visible = True
            dtgBoldChat.Visible = True
            PnlDtgInforme.Visible = False
            PnlSeguimientoVoz.Visible = False
            PnlSegumientoDatos.Visible = False
            PnlDatos.Visible = False
            PnlVoz.Visible = False
            pnl_message.CssClass = Nothing
            lblmsg.Text = Nothing
        Catch ex As Exception
            pnl_message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub LinkBtnSeguimiento_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkBtnSeguimientoDatos.Click
        Try
            PnlSegumientoDatos.Visible = True
            PnlSeguimientoVoz.Visible = False
            dtgSeguimientoDatos.Visible = True
            PnlBoldchat.Visible = False
            PnlDtgInforme.Visible = False
            pnl_message.CssClass = Nothing
            lblmsg.Text = Nothing
        Catch ex As Exception
            pnl_message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub LinkBtnSeguimiento0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkBtnSeguimiento0.Click
        Try
            PnlSeguimientoVoz.Visible = True
            dtgSeguimientoVoz.Visible = True
            PnlBoldchat.Visible = False
            PnlDtgInforme.Visible = False
            PnlSegumientoDatos.Visible = False
            PnlDatos.Visible = False
            PnlVoz.Visible = False
            PnlDatos.Visible = False
            PnlVoz.Visible = False
            pnl_message.CssClass = Nothing
            lblmsg.Text = Nothing
        Catch ex As Exception
            pnl_message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub LinkBtnSeguimiento1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkBtnSeguimiento1.Click
        Try
            PnlDtgInforme.Visible = True
            DtgInforme.Visible = True
            PnlBoldchat.Visible = False
            PnlSeguimientoVoz.Visible = False
            PnlSegumientoDatos.Visible = False
            PnlDatos.Visible = False
            PnlVoz.Visible = False
            pnl_message.CssClass = Nothing
            lblmsg.Text = Nothing
        Catch ex As Exception
            pnl_message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub dtgBoldChat_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgBoldChat.PageIndexChanging
        Try
            dtgBoldChat.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtgBoldChat.DataSource = Session("dtsB")
            dtgBoldChat.DataBind()
        Catch ex As Exception
            pnl_message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub dtgDatos_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgDatos.PageIndexChanging
        Try
            dtgDatos.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtgDatos.DataSource = Session("data")
            dtgDatos.DataBind()
        Catch ex As Exception
            pnl_message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Sub crearexcel()
        Try
            Dim v As String
            Dim sb As New StringBuilder
            Dim sw As New StringWriter(sb)
            Dim htw As New HtmlTextWriter(sw)
            Dim pagina As Page = New Page
            Dim form = New HtmlForm
            Dim r As New clsrrhh
            Dim GridViewNuevo As New GridView()
            Dim objdtsconsultaxls As New DataSet
            Dim strStyle As String = "<style> .textmode { mso-number-format:\@; } </style>"
            pagina.EnableEventValidation = False
            pagina.DesignerInitialize()
            pagina.Controls.Add(form)

            If dtgBoldChat.Visible = True And lblcuenta.Text <> Nothing And lblcuenta.Text <> "0" Then
                dtgBoldChat.AllowPaging = False
                dtgBoldChat.DataSource = Session("dtsB")
                dtgBoldChat.DataBind()
                form.Controls.Add(dtgBoldChat)
                v = "_Bandeja"
                dtgBoldChat.AllowPaging = True
            ElseIf dtgSeguimientoDatos.Visible = True And lblcuenta0.Text <> Nothing And lblcuenta0.Text <> "0" Then
                dtgSeguimientoDatos.AllowPaging = False
                dtgSeguimientoDatos.DataSource = Session("dts2")
                dtgSeguimientoDatos.DataBind()
                form.Controls.Add(dtgSeguimientoDatos)
                v = "_Datos"
                dtgSeguimientoDatos.AllowPaging = True
            ElseIf dtgSeguimientoVoz.Visible = True And lblcuenta1.Text <> Nothing And lblcuenta1.Text <> "0" Then
                dtgSeguimientoVoz.AllowPaging = False
                dtgSeguimientoVoz.DataSource = Session("DtsV")
                dtgSeguimientoVoz.DataBind()
                form.Controls.Add(dtgSeguimientoVoz)
                v = "_Voz"
                dtgSeguimientoVoz.AllowPaging = True
            ElseIf DtgInforme.Visible = True And lblcuenta2.Text <> Nothing And lblcuenta2.Text <> "0" Then
                DtgInforme.AllowPaging = False
                DtgInforme.DataSource = Session("dtg")
                DtgInforme.DataBind()
                form.Controls.Add(DtgInforme)
                v = "_General"
                DtgInforme.AllowPaging = True
            Else
                pnl_message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Debe realizar un filtro de consulta o seleccionar una opcion"
                Exit Sub
            End If
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=Gestion_Bold_Chat" + v + ".xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()



            pnl_message.CssClass = "alert alert-danger"
            lblmsg.Text = "Hola Mundo"
        Catch ex As Exception
            pnl_message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message = "<style> .textmode { mso-number-format:\@; } </style>"
        End Try
    End Sub
    Dim valida As Boolean = True
    Protected Sub btnxls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnxls.Click
        Try

            If valida = True Then
                crearexcel()
            End If
        Catch ex As Exception
            pnl_message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

   

    Protected Sub dtgSeguimientoDatos_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgSeguimientoDatos.PageIndexChanging
        Try
            dtgSeguimientoDatos.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtgSeguimientoDatos.DataSource = Session("dts2")
            dtgSeguimientoDatos.DataBind()

        Catch ex As Exception
            pnl_message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub dtgSeguimientoVoz_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgSeguimientoVoz.PageIndexChanging
        Try
            dtgSeguimientoVoz.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtgSeguimientoVoz.DataSource = Session("dtsV")
            dtgSeguimientoVoz.DataBind()
        Catch ex As Exception
            pnl_message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub DtgInforme_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles DtgInforme.PageIndexChanging
        Try
            DtgInforme.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            DtgInforme.DataSource = Session("dtg")
            DtgInforme.DataBind()
        Catch ex As Exception
            pnl_message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
End Class