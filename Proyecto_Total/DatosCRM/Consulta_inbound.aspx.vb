Public Class Consulta_inbound
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If

            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Consulta Inbound"

                Carga_drl()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub Carga_drl()
        Try
            Dim ObjGeneral As New clsgeneral
            ''Campaña
            With drlcampaña
                .DataSource = ObjGeneral.consulta_campaña_inb
                .DataTextField = "nombre"
                .DataValueField = "nombre"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
            End With
            Dim row As Integer
            'Estado
            row = ObjGeneral.consultartipificacion.Tables(0).Rows.Count
            With drl_estado
                .DataSource = ObjGeneral.consultartipificacion
                .DataTextField = "Tipificacion1"
                .DataValueField = "Tipificacion1"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items.Insert(1, "ABIERTO")
                .Items.Insert(row + 1, "Escalado")
                .Items.Insert(row + 2, "Cerrado Informatica")
                .Items.Insert(row + 3, "Cerrado Tecnica")
                .Items.Insert(row + 4, "Rechazado")
            End With

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            Dim ObjDatos As New clscrmdatos
            Dim dts As DataSet
            If txtcaso.Text = "" And Txt_Fc_Fin.Text = "" And Txt_Fc_Ini.Text = "" And txt_idavaya.Text = "" And txt_min.Text = "" And drlcampaña.SelectedIndex = 0 And drl_estado.SelectedIndex = 0 Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Escoja un filtro de busqueda"
                Exit Sub
            Else
                If txtcaso.Text <> "" Then
                    ObjDatos.caso = txtcaso.Text
                End If
                If txt_min.Text <> "" Then
                    ObjDatos.min = txt_min.Text
                End If
                If txt_idavaya.Text <> "" Then
                    ObjDatos.idcrm = txt_idavaya.Text
                End If
                If drl_estado.SelectedIndex <> 0 Then
                    ObjDatos.tipificacion = drl_estado.SelectedItem.Text
                End If
                If drlcampaña.SelectedIndex <> 0 Then
                    ObjDatos.Bandeja = drlcampaña.SelectedItem.Text
                End If
                If Txt_Fc_Ini.Text <> "" Then
                    ObjDatos.fcini = Txt_Fc_Ini.Text
                End If
                If Txt_Fc_Fin.Text <> "" Then
                    ObjDatos.fcfin = Txt_Fc_Fin.Text
                End If
                If Txt_Fc_Ini.Text <> "" And Txt_Fc_Fin.Text <> "" Then
                    If Date.Parse(Txt_Fc_Ini.Text) > Date.Parse(Txt_Fc_Fin.Text) Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Fecha inicio debe ser menor a fecha fin"
                        Exit Sub
                    End If
                End If

                dts = ObjDatos.Consulta_General_inbound()
                If ObjDatos.cantidad = 0 Then
                    dtgbandeja.DataSource = dts.Tables(0)
                    dtgbandeja.DataBind()
                    LblCuentaAsignados.Text = ""
                    dtggeneral.DataSource = Nothing
                    dtggeneral.DataBind()
                    Lbl_seguimiento.Text = ""
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No se encontraron registros"
                    Exit Sub
                End If
                dtgbandeja.DataSource = dts.Tables(0)
                dtgbandeja.DataBind()
                LblCuentaAsignados.Text = "Casos " + ObjDatos.cantidad

                If dts.Tables.Count > 1 Then
                    dtggeneral.DataSource = dts.Tables(1)
                    dtggeneral.DataBind()
                    Lbl_seguimiento.Text = "Seguimientos: " & dts.Tables(1).Rows.Count
                Else
                    dtggeneral.DataSource = Nothing
                    dtggeneral.DataBind()
                    Lbl_seguimiento.Text = ""
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub dtggeneral_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles dtggeneral.RowDataBound
        If (e.Row.RowType = DataControlRowType.DataRow) Or (e.Row.RowType = DataControlRowType.Header) Then
            e.Row.Cells(8).Visible = False
            If DataBinder.Eval(e.Row.DataItem, "Estado") = "Eliminado" Then
                e.Row.ForeColor = Drawing.Color.Red
            End If
        End If
    End Sub

End Class