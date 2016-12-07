Imports System.Security.Cryptography
Public Class ConsCredenciales
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Msg_Error_Pw.CssClass = Nothing
            Lbl_Msg_Error_Pw.Text = Nothing
            Pnl_Alerta.CssClass = Nothing
            Lbl_Alerta.Text = Nothing

            If Not IsPostBack Then
                Session("Formulario") = "Consulta Credenciales de Usuario"
                Dim objrrhh As New clsrrhh
                objrrhh.codigo = CType(Session("permisos"), clsusuario).Codnom
                DtgVisualizar.DataSource = objrrhh.Consulta_credenciales_usuario()
                DtgVisualizar.DataBind()
                'Activos fijos''''
                objrrhh.idusuario = CType(Session("permisos"), clsusuario).usuario
                Session("dtsB") = objrrhh.Consulta_Activos_usuario()
                DtgVisualizarAct.DataSource = Session("dtsB")
                DtgVisualizarAct.DataBind()
            End If
        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert danger"
            Lbl_Alerta.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Protected Sub DtgVisualizar_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles DtgVisualizar.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "ACTIVO" Then
                    e.Row.Cells(4).BackColor = Drawing.Color.FromName("#B3C556")
                    e.Row.Cells(4).ForeColor = Drawing.Color.Black
                End If

                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "ACTIVO" Then
                    e.Row.Cells(4).BackColor = Drawing.Color.FromName("#B3C556")
                    e.Row.Cells(4).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "ELIMINADO" Then
                    e.Row.Cells(4).BackColor = Drawing.Color.FromName("#81BEF7")
                    e.Row.Cells(4).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "INACTIVADO" Then
                    e.Row.Cells(4).BackColor = Drawing.Color.FromName("#81BEF7")
                    e.Row.Cells(4).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "PDT. CREAR" Then
                    e.Row.Cells(4).BackColor = Drawing.Color.FromName("#F78181")
                    e.Row.Cells(4).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "PDT. ELIMINAR" Then
                    e.Row.Cells(4).BackColor = Drawing.Color.FromName("#F78181")
                    e.Row.Cells(4).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "PDT. HABILITAR" Then
                    e.Row.Cells(4).BackColor = Drawing.Color.FromName("#F78181")
                    e.Row.Cells(4).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "HABILITANDO" Then
                    e.Row.Cells(4).BackColor = Drawing.Color.FromName("#F2F5A9")
                    e.Row.Cells(4).ForeColor = Drawing.Color.Black
                End If
            End If
        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert danger"
            Lbl_Alerta.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Protected Sub DtgVisualizarAct_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles DtgVisualizarAct.PageIndexChanging
        Try
            Dim objrrhh As New clsrrhh
            DtgVisualizarAct.PageIndex = e.NewPageIndex
            DtgVisualizarAct.DataSource = Session("dtsB")
            DtgVisualizarAct.DataBind()
        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert danger"
            Lbl_Alerta.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Change_Pw_Ok_Click(sender As Object, e As EventArgs) Handles Btn_Change_Pw_Ok.Click
        Try
            Dim Obj_Usuario As New clsusuario
            Dim Obj_G_Data As New Cls_Gestion_Datos
            Obj_Usuario.usuario = CType(Session("permisos"), clsusuario).usuario
            Obj_Usuario.Passwor = Obj_G_Data.String_To_MD5(Txb_Pw_Actual.Text)
            If Obj_Usuario.Validar_Usuario Then
                Obj_Usuario.Passwor = Obj_G_Data.String_To_MD5(Txb_New_Pw.Text)
                If Obj_Usuario.Cambiar_Password() > 0 Then
                    Pnl_Msg_Error_Pw.CssClass = "alert alert-success"
                    Lbl_Msg_Error_Pw.Text = "<span class='glyphicon glyphicon-ok-circle'></span> El cambio se ha realizado exitosamente"
                Else
                    Pnl_Msg_Error_Pw.CssClass = "alert alert-danger"
                    Lbl_Msg_Error_Pw.Text = "<span class='glyphicon glyphicon-remove-sign'></span> El cambio no se ha realizado"
                End If
            Else
                Pnl_Msg_Error_Pw.CssClass = "alert alert-warning"
                Lbl_Msg_Error_Pw.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Contraseña erronea"
            End If
        Catch ex As Exception
            Pnl_Msg_Error_Pw.CssClass = "alert alert-danger"
            Lbl_Msg_Error_Pw.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
End Class