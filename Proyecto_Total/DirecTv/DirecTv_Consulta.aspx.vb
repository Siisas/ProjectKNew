Imports System.IO
Public Class Directv_consulta
    Inherits System.Web.UI.Page
    Dim objDirect_tv As New clsDirectTv
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                'Datos Tipificacion
                With drltipificación
                    drltipificación.DataSource = objDirect_tv.ObtenerTipificacionconsulta
                    drltipificación.DataTextField = "nombre"
                    drltipificación.DataValueField = "nombre"
                    drltipificación.DataBind()
                End With
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
    Protected Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Public Sub Consulta()
        Try
            If Txtid_cliente.Text = Nothing And Txttelefono1.Text = Nothing And TxtFechaInicio.Text = Nothing And TxtFechaFin.Text = Nothing And drltipificación.SelectedItem.Text = "- Seleccione -" And Txtcodigoasesor.Text = Nothing And Drltipollamada.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Debe ingresar un valor para la consulta"
                LblCuenta.Text = ""
                Lblcuenta1.Text = ""
                dtgGeneral.DataSource = Nothing
                dtgGeneral.DataBind()
                dtgGeneral1.DataSource = Nothing
                dtgGeneral1.DataBind()
            Else
                If Txtid_cliente.Text <> "" Then
                    objDirect_tv.Id_Cliente = Txtid_cliente.Text
                End If
                If Txttelefono1.Text <> "" Then
                    objDirect_tv.Telefono_Cliente = Txttelefono1.Text
                End If
                If TxtFechaInicio.Text <> "" Then
                    objDirect_tv.fcini = TxtFechaInicio.Text
                End If
                If TxtFechaFin.Text <> "" Then
                    objDirect_tv.fcfin = TxtFechaFin.Text
                End If
                If drltipificación.SelectedItem.Text <> "- Seleccione -" Then
                    objDirect_tv.Tipificacion = drltipificación.Text
                End If
                If Txtcodigoasesor.Text <> Nothing Then
                    objDirect_tv.Id_Agente = Txtcodigoasesor.Text
                End If
                If Drltipollamada.SelectedItem.Text <> "- Seleccione -" Then
                    objDirect_tv.TipoLlamada = Drltipollamada.Text
                End If
                If TxtFechaInicio.Text <> Nothing Or TxtFechaFin.Text <> Nothing Then
                    If TxtFechaInicio.Text = Nothing And TxtFechaFin.Text <> Nothing Then
                        lblmsg.Text = "Para consultar, las fechas deben tener una fecha inicio y una fecha fin"
                        Exit Sub
                    End If
                    If TxtFechaInicio.Text <> Nothing And TxtFechaFin.Text = Nothing Then
                        lblmsg.Text = "Para consultar, las fechas deben tener una fecha inicio y una fecha fin"
                        Exit Sub
                    End If
                    If Date.Parse(TxtFechaInicio.Text) > Date.Parse(TxtFechaFin.Text) Then
                        lblmsg.Text = "La fecha inicio es mayor que la fecha fin"
                        Exit Sub
                    End If
                End If
                objDirect_tv.Validacion = 1
                If Txtcodigoasesor.Text <> Nothing Then
                    objDirect_tv.Consultacodigoasesor()
                End If
                lblmsg.Text = ""
                Lblcuenta1.Text = ""
                dtgGeneral1.DataSource = Nothing
                dtgGeneral1.DataBind()
                'Validacion Id Cliente 
                If Txtid_cliente.Text <> Nothing Then
                    objDirect_tv.Id_Cliente = Txtid_cliente.Text
                    If InStr(1, Txtid_cliente.Text, "R") <> Nothing Then
                        objDirect_tv.Id_Cliente = Txtid_cliente.Text
                        objDirect_tv.Validacion = 5
                        lblmsg.Text = ""
                    ElseIf Txtid_cliente.Text <> Nothing Then
                        If InStr(1, Txtid_cliente.Text, "0") <> Nothing Or InStr(1, Txtid_cliente.Text, "1") <> Nothing Or InStr(1, Txtid_cliente.Text, "2") <> Nothing Or InStr(1, Txtid_cliente.Text, "3") <> Nothing Or InStr(1, Txtid_cliente.Text, "4") <> Nothing Or InStr(1, Txtid_cliente.Text, "5") <> Nothing Or InStr(1, Txtid_cliente.Text, "6") <> Nothing Or InStr(1, Txtid_cliente.Text, "7") <> Nothing Or InStr(1, Txtid_cliente.Text, "8") <> Nothing Or InStr(1, Txtid_cliente.Text, "9") Then

                        Else
                            lblmsg.Text = "ID Cliente " + Txtid_cliente.Text + " Incorrecto"
                            Exit Sub
                        End If
                        objDirect_tv.Id_Direct_TV_Cliente = Txtid_cliente.Text
                        objDirect_tv.Validacion = 6
                        lblmsg.Text = ""
                    End If
                    objDirect_tv.validarcliente()
                End If
                If Txtid_cliente.Text <> Nothing Then
                    dtgGeneral1.DataSource = objDirect_tv.Obtener_Datos_Caso
                    dtgGeneral1.DataBind()
                    Lblcuenta1.Text = objDirect_tv.cantidad
                    dtgGeneral.DataSource = objDirect_tv.Consultageneralidcliente
                    dtgGeneral.DataBind()
                Else
                    dtgGeneral.DataSource = objDirect_tv.Obtener_Datos_Caso
                    dtgGeneral.DataBind()
                End If
                LblCuenta.Text = objDirect_tv.cantidad
                If objDirect_tv.cantidad > 0 Then
                    If Excel = True Then
                        If Txtid_cliente.Text <> Nothing Then
                            dtgGeneralExcel.DataSource = objDirect_tv.Consultageneralidcliente
                            dtgGeneralExcel.DataBind()
                            dtgGeneral1Excel.DataSource = objDirect_tv.Obtener_Datos_Caso
                            dtgGeneral1Excel.DataBind()
                        Else
                            dtgGeneralExcel.DataSource = objDirect_tv.Obtener_Datos_Caso
                            dtgGeneralExcel.DataBind()
                        End If
                    End If
                Else
                    If Txtid_cliente.Text <> Nothing Then
                        lblmsg.Text = "No se encontraron resultados con el Id Cliente " + Txtid_cliente.Text
                    Else
                        lblmsg.Text = "No se encontraron resultados"
                    End If
                    LblCuenta.Text = ""
                    Lblcuenta1.Text = ""
                    dtgGeneral.DataSource = Nothing
                    dtgGeneral.DataBind()
                    dtgGeneral1.DataSource = Nothing
                    dtgGeneral1.DataBind()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Public Sub CrearExcel()
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
            If dtgGeneralExcel.Rows.Count > 0 Then
                dtgGeneralExcel.Visible = True
                form.Controls.Add(dtgGeneralExcel)
            End If
            If dtgGeneral1Excel.Rows.Count > 0 Then
                dtgGeneral1Excel.Visible = True
                form.Controls.Add(dtgGeneral1Excel)
            End If
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=DirecTv_Consulta.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Dim Excel As Boolean = False
    Protected Sub BtnExporExc_Click(sender As Object, e As EventArgs) Handles BtnExporExc.Click
        Try
            If LblCuenta.Text = "" Or LblCuenta.Text = "0" Then
                lblmsg.Text = "Antes de exportar realice una consulta"
                Exit Sub
            End If
            If Txtid_cliente.Text = Nothing And Txttelefono1.Text = Nothing And TxtFechaInicio.Text = Nothing And TxtFechaFin.Text = Nothing And Txtcodigoasesor.Text = Nothing And drltipificación.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Antes de exportar realice una consulta"
                Exit Sub
            End If
            Excel = True
            Consulta()
            CrearExcel()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub dtgGeneral_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtgGeneral.PageIndexChanging
        Try
            dtgGeneral.PageIndex = e.NewPageIndex
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub dtgGeneral1_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtgGeneral1.PageIndexChanging
        Try
            dtgGeneral1.PageIndex = e.NewPageIndex
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
End Class