Imports System.Web.Script.Serialization
Partial Public Class _default
    Inherits System.Web.UI.Page
    Private objdatos As New clsgeneral
    Private Obj_Gestion_Datos As New Cls_Gestion_Datos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            If Not IsPostBack Then
                Session("Formulario") = "Default Kamilion ERP"
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                Generar_Graficos()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            Lbl_Message.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Private Sub Generar_Graficos()
        Try
            If Session("Json_Graphics") = Nothing Then
                objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                Dim MyDts As DataSet = objdatos.Cons_Productividad()
                Session("Json_Graphics") = Obj_Gestion_Datos.Object_To_JSON(Obj_Gestion_Datos.DataSet_To_Object(MyDts))
                Dim dt As String = Session("Json_Graphics")
            End If
            If Session("Json_Graphics") <> Nothing Then
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Ini_Graphics", "Order_Graphics_Date('" & Session("Json_Graphics") & "');", True)
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            Lbl_Message.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
End Class