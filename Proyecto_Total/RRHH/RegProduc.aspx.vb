Public Class RegProduc
    Inherits System.Web.UI.Page
    Dim ObjCafeteria As New clsCafeteria


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                Consulta()
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

    Public Sub Consulta()
        Try
            dtgproductos.DataSource = ObjCafeteria.ConsultaRegPro
            dtgproductos.DataBind()
            lblcantgral.Text = ObjCafeteria.Contador
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub btnGuardarPro_Click(sender As Object, e As EventArgs) Handles btnGuardarPro.Click
        Try
            If TxtNombreNuev.Text = "" Or TxtPrecNuev.Text = "" Then
                lblmsg.Text = "LLene los campos del producto que va a registrar"
                Exit Sub
            End If
            ObjCafeteria.NombreProNuevo = TxtNombreNuev.Text
            ObjCafeteria.ValorUnitProNuevo = Val(TxtPrecNuev.Text)
            ObjCafeteria.RegistroPro()
            ''Menasaje ingreso

            lblmsg.Text = "Se han registrado correctamente"
            ''Limpia cajas
            TxtNombreNuev.Text = ""
            TxtPrecNuev.Text = ""
            Consulta()
            lblcantgral.Text = ObjCafeteria.Contador
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try

    End Sub

   
    Protected Sub dtgproductos_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtgproductos.PageIndexChanging
        Try
            dtgproductos.PageIndex = e.NewPageIndex
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
        
    End Sub
End Class