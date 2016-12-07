Imports System.Security.Cryptography
Partial Public Class entrada
    Inherits System.Web.UI.Page
    Dim Obj_G_Data As New Cls_Gestion_Datos
    Dim Obj_General As New clsgeneral
    Dim Obj_Usuario As New clsusuario
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Session("dtsSeguridad") = Nothing
                Txt_Usuario.Focus()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Private Sub Btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Login.Click
        Try
            Obj_Usuario.usuario = Txt_Usuario.Text
            Obj_Usuario.Passwor = Obj_G_Data.String_To_MD5(Txt_Password.Text)

            If Obj_Usuario.Validar_Usuario Then
                Obj_Usuario.Consultar_Usuario()
                Session("permisos") = Obj_Usuario
                Obj_General.idusuario = Txt_Usuario.Text
                'Obj_General.Registrar_Ingreso()
                FormsAuthentication.RedirectFromLoginPage(Txt_Usuario.Text, False)
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> la información incorrecta"
                Txt_Usuario.Focus()
            End If

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try

    End Sub
End Class