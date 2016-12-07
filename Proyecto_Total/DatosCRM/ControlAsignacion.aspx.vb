Imports System.IO

Public Class ControlAsignacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                objdatos.idusuario = lblusuario.Text
                objdatos.consultacod()
                cargar()
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
    '----------CARGAR LISTA------------'
    Sub cargar()
        Dim objDatos As New clscrmdatos
        objDatos.Validacion = "Control"
        With DrlEstado
            .DataSource = objDatos.Consulta_drlestado
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
    End Sub


    Protected Sub BtnBusca_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBusca.Click
        Try
            Dim objDatos As New clscrmdatos
            objDatos.Validacion = "Control"
            If DrlEstado.SelectedItem.Text <> "- Seleccione -" Then
                objDatos.estadoinc = DrlEstado.SelectedItem.Text
                If DrlEstado.SelectedItem.Text = "Programado" Then
                    If DrlProgramado.SelectedItem.Text <> "- Seleccione -" Then
                        objDatos.tipificacion = DrlProgramado.SelectedItem.Text
                        objDatos.Validacion = "Programado"
                    End If
                End If
                Lblcampaña.Text = DrlEstado.SelectedItem.Text
            Else
                Lblcampaña.Text = "General"
            End If

            Session("Control") = objDatos.Consulta_Control_Operacion
            DtgControl.DataSource = Session("Control")
            DtgControl.DataBind()

            If objDatos.cantidad = 0 Then
                lblmsg.Text = "No se encontraron registros"
                Exit Sub
            Else
                dtggeneral.DataSource = Nothing
                dtggeneral.DataBind()
                lblcuenta.Text = ""
            End If
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub DrlEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DrlEstado.SelectedIndexChanged
        Try
            If DrlEstado.SelectedItem.Text = "Programado" Then
                PnlProgramado.Visible = True
                DrlProgramado.SelectedIndex = 0
            Else
                PnlProgramado.Visible = False
                DrlProgramado.SelectedIndex = 0
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub


   

    Dim ingeniero, campaña As String

    Protected Sub DtgControl_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles DtgControl.RowCommand
        Try
            Dim objDatos As New clscrmdatos
            ingeniero = DtgControl.Rows(e.CommandArgument).Cells(0).Text
            campaña = e.CommandName.ToString

            objDatos.idusuario = ingeniero
            objDatos.Bandeja = campaña
            If DrlEstado.SelectedItem.Text <> "- Seleccione -" Then
                objDatos.estadoinc = DrlEstado.SelectedItem.Text
                If DrlEstado.SelectedItem.Text = "Programado" Then
                    If DrlProgramado.SelectedItem.Text <> "- Seleccione -" Then
                        objDatos.tipificacion = DrlProgramado.SelectedItem.Text
                    End If
                End If
            End If
            objDatos.Validacion = "Individual"
            Session("Individual") = objDatos.Consulta_Control_Operacion
            dtggeneral.DataSource = Session("Individual")
            dtggeneral.DataBind()

            lblcuenta.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Btnexportar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btnexportar.Click
        Try
            If DtgControl.Rows.Count = 0 Then
                lblmsg.Text = "Realice una consulta primero"
                Exit Sub
            Else
                dtggeneral.DataSource = Session("Control")
                dtggeneral.DataBind()
                crearexcel(dtggeneral)
                dtggeneral.DataSource = Session("Individual")
                dtggeneral.DataBind()
            End If
            
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnExportar2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnExportar2.Click
        Try
            If dtggeneral.Rows.Count = 0 Then
                lblmsg.Text = "Realice una consulta primero"
                Exit Sub
            End If
            crearexcel(dtggeneral)
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub crearexcel(ByVal dtg As GridView)
        Try
            Dim sw As New StringWriter()
            Dim hw As New HtmlTextWriter(sw)
            Dim tabla As New Table()
            Dim tr1 As New TableRow()

            Dim cell1 As New TableCell()
            Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"

            cell1.Controls.Add(dtg)
            tr1.Cells.Add(cell1)
            tabla.Rows.Add(tr1)
            tabla.RenderControl(hw)
            Response.Clear()
            Response.Buffer = True
            Response.AddHeader("Content-Disposition", "attachment;filename=Control Operacion.xls")
            Response.Charset = "UTF-8"
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.Write(style)
            Response.Output.Write(sw.ToString())
            Response.Flush()
            Response.End()

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
End Class