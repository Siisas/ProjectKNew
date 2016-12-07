Public Class ConsultaCasosVipSegGran
    Inherits System.Web.UI.Page
    Dim ObjVoz As New clsvoz

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Obtengo los datos del usuario'
        Try
            If Not IsPostBack Then
                Dim dt As New DataSet
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
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        dtggeneral.PageIndex = e.NewPageIndex

    End Sub

    Protected Sub BtnConsulta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsulta.Click
        Try
            If TxtFecha_Inicio.Text = "" And TxtFecha_Fin.Text = "" Then
                lblmsg.Text = "Ingrese alguna fecha de consulta"
                Exit Sub
            End If
            If TxtFecha_Inicio.Text <> Nothing Then
                ObjVoz.fcini = TxtFecha_Inicio.Text
            End If
            If TxtFecha_Fin.Text <> Nothing Then
                ObjVoz.fcfin = TxtFecha_Fin.Text
            End If

            dtggeneral.DataSource = ObjVoz.Consulta_Vip_Seg_Gran
            dtggeneral.DataBind()

            TxtFecha_Fin.Text = ""
            TxtFecha_Inicio.Text = ""
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
End Class