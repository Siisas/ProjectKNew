Imports System.IO
Imports System.Drawing
Public Class CampañaDatos
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

    Dim fila As Integer

    Dim a, b, c As Integer
    '----BUSCAR----'
    Protected Sub btnBuscar_Click1(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
        Try
            Dim ObjInformes As New clsInformes
            Dim fsap As Date = FormatDateTime(Now.Date)
            If DrlCampaña.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una campaña"
                dtgBusqueda.DataSource = Nothing
                dtgBusqueda.DataBind()
                dtggeneral.DataSource = Nothing
                dtggeneral.DataBind()
                lblcampaña.Text = ""
                lblcuenta.Text = ""
                BtnExportarPendientes.Visible = False
                Exit Sub
            Else
                ObjInformes.Campa = DrlCampaña.SelectedItem.Text
            End If
            If txtfc_inicio.Text = "" And txtfc_fin.Text = "" Then
                ObjInformes.Fecha_inicio = fsap.AddDays(-30)
                ObjInformes.Fecha_Fin = fsap
            Else
                If txtfc_inicio.Text = "" Then
                    lblmsg.Text = "Seleccione fecha inicio"
                    Exit Sub
                End If
                If txtfc_fin.Text = "" Then
                    lblmsg.Text = "Seleccione fecha fin"
                    Exit Sub
                End If
                If Date.Parse(txtfc_fin.Text) < Date.Parse(txtfc_inicio.Text) Then
                    lblmsg.Text = "Fecha inicio debe ser menor"
                    Exit Sub
                End If

                ObjInformes.Fecha_inicio = txtfc_inicio.Text
                ObjInformes.Fecha_Fin = txtfc_fin.Text
            End If
            ObjInformes.Validacionn = "Solicitado"
            Session("Informe") = ObjInformes.Consulta_solicitados()
            a = ObjInformes.Cantidad
            dtgBusqueda.DataSource = Session("Informe")
            dtgBusqueda.DataBind()
            lblcampaña.Text = DrlCampaña.SelectedItem.Text
            If ObjInformes.Cantidad = 0 Then
                lblmsg.Text = "No se encontraron registros"
                BtnExportarPendientes.Visible = False
                BtnAsignacion.Visible = False
                Exit Sub
            Else
                BtnAsignacion.Visible = False
                BtnExportarPendientes.Visible = True
                fila = ObjInformes.Cantidad
            End If
            limpiar()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    '----EXPORTAR----'
    Protected Sub BtnExportar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnExportar.Click
        Try
            dtggeneral.DataSource = Session("Informe")
            dtggeneral.DataBind()
            crearexcel()
            dtggeneral.DataSource = Session("Pendiente")
            dtggeneral.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub



    Sub crearexcel()
        Dim sw As New StringWriter()
        Dim hw As New HtmlTextWriter(sw)
        Dim tabla As New Table()
        Dim tr1 As New TableRow()
        Dim cell1 As New TableCell()
        Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"

        If dtgBusqueda.Rows.Count() > 0 Then
            cell1.Controls.Add(dtggeneral)
            tr1.Cells.Add(cell1)
            tabla.Rows.Add(tr1)
            tabla.RenderControl(hw)
            Response.Clear()
            Response.Buffer = True
            Response.AddHeader("Content-Disposition", "attachment;filename=Informe_solicitado.xls")
            Response.Charset = "UTF-8"
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.Write(style)
            Response.Output.Write(sw.ToString())
            Response.Flush()
            Response.End()
        Else
            lblmsg.Text = "Primero haga una consulta e intente Exportarla!!"
        End If
    End Sub
    Sub limpiar()
        lblmsg.Text = ""
        lblcuenta.Text = ""
        dtggeneral.DataSource = Nothing
        dtggeneral.DataBind()
        lblcuenta.Text = ""
    End Sub

    Protected Sub dtgBusqueda_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles dtgBusqueda.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Dim Estado As String = DataBinder.Eval(e.Row.DataItem, "Fecha Corta")
                If Estado = "total" Then
                    e.Row.ForeColor = Drawing.Color.White
                    e.Row.BackColor = Drawing.Color.FromArgb(179, 197, 86)
                    'color que deseen           'o sino : Color.Red o Color.BurlyWood
                End If
                If c = 0 Then
                    For b As Integer = 1 To (a - 1)
                        If dtgBusqueda.HeaderRow.Cells(b).Text = "Pendientes" Then
                            c = b
                            Exit For
                        End If
                    Next
                End If
                e.Row.Cells(c).ForeColor = Drawing.Color.White
                e.Row.Cells(c).BackColor = Drawing.Color.FromArgb(179, 197, 86)
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub BtnExportarPendientes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnExportarPendientes.Click
        Try
            If dtggeneral.Rows.Count < 1 Then
                lblmsg.Text = "Realice una Consulta"
                Exit Sub
            End If
            crearexcel()

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Dim Hora, Tipo As String

    Protected Sub dtgBusqueda_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtgBusqueda.RowCommand
        Try
            Dim ObjInformes As New clsInformes
            Dim fsap As Date = FormatDateTime(Now.Date)
            Hora = dtgBusqueda.Rows(e.CommandArgument).Cells(0).Text
            Tipo = e.CommandName.ToString
            If Tipo = "Pendientes" Then
                BtnAsignacion.Visible = True
            Else
                BtnAsignacion.Visible = False
            End If
            ObjInformes.Campa = DrlCampaña.SelectedItem.Text
            If Hora = "total" Then
                If txtfc_inicio.Text = "" And txtfc_fin.Text = "" Then
                    ObjInformes.Fecha_inicio = fsap.AddDays(-30)
                    ObjInformes.Fecha_Fin = fsap
                Else
                    ObjInformes.Fecha_inicio = txtfc_inicio.Text
                    ObjInformes.Fecha_Fin = txtfc_fin.Text
                End If
            Else
                ObjInformes.Fecha_inicio = Hora
            End If

            ObjInformes.estadoinc = Tipo

            ObjInformes.Validacionn = "Pendiente"
            Session("Pendiente") = ObjInformes.Consulta_solicitados()
            b = ObjInformes.Area
            dtggeneral.DataSource = Session("Pendiente")
            dtggeneral.DataBind()
            lblcuenta.Text = "Registros: " & b
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnAsignacion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAsignacion.Click
        Try
            Dim ObjDatos As New clscrmdatos
            ObjDatos.Validacion = lblcampaña.Text
            ObjDatos.tipificacion = "Manual"
            For Each row As GridViewRow In dtggeneral.Rows
                ObjDatos.caso = Int64.Parse(row.Cells(0).Text)
                ObjDatos.Asignacion_solicitado()
            Next
            lblmsg.Text = "Asignacion Realizada"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub


    Protected Sub dtggeneral_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles dtggeneral.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Dim Manual As String = e.Row.Cells(4).Text
                If Manual <> "&nbsp;" Then
                    e.Row.ForeColor = Drawing.Color.White
                    e.Row.BackColor = Drawing.Color.FromArgb(191, 191, 191)
                End If
               
                
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
End Class