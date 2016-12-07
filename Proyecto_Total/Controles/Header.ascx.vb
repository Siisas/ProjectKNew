Public Class Header
    Inherits System.Web.UI.UserControl
    Dim Obj_General As New clsgeneral
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Session("dtsSeguridad") Is Nothing Then
                Obj_General.estado = CType(HttpContext.Current.Session("permisos"), clsusuario).perfil
                Session("dtsSeguridad") = Obj_General.consultarmenu()
            End If
            'Seguridad()
            Menu_Load()
            Lbl_Usuario.Text = CType(Session("permisos"), clsusuario).usuario
            Lbl_Nombre.Text = CType(Session("permisos"), clsusuario).nombre
            Lbl_Perfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
            Lbl_Supervisor.Text = CType(Session("permisos"), clsusuario).Superv
            Lbl_Cod.Text = CType(Session("permisos"), clsusuario).Codnom
            Lbl_Jefe_Inmediato.Text = CType(Session("permisos"), clsusuario).Jefe
            Lbl_Segmento.Text = CType(Session("permisos"), clsusuario).Segmento
            Titulo_Formulario.Text = Session("Formulario")
            If Lbl_Supervisor.Text = Nothing Then
                Lbl_SuperVisor_Titulo.Visible = False
            End If
        End If
    End Sub
    Protected Sub Seguridad()
        Obj_General.idusuario = CType(Session("permisos"), clsusuario).usuario
        Obj_General.DtsSeguridad = Session("dtsSeguridad")
        Dim Url_frag = Request.RawUrl.Split("/")
        Dim Url As String = "~"
        Dim Directorio = System.AppDomain.CurrentDomain.BaseDirectory().Split("\")
        For I As Integer = 1 To Url_frag.Count - 1
            If I = 1 And Url_frag(1) = Directorio(Directorio.Count - 2) Then
            Else
                Url = Url & "/" & Url_frag(I)
            End If
        Next
        Obj_General.PaginaAcceso = Url
        Obj_General.PermisosUrl()
    End Sub
    Protected Sub Menu_Load()
        Dim Dts_Items As DataSet = Session("dtsSeguridad")
        For Each drMenuItem As Data.DataRow In Dts_Items.Tables(0).Rows
            If drMenuItem("MenuId").Equals(drMenuItem("PadreId")) Then
                Dim mnuMenuItem As New MenuItem
                mnuMenuItem.Value = drMenuItem("MenuId").ToString
                mnuMenuItem.Text = drMenuItem("descripcion").ToString
                mnuMenuItem.NavigateUrl = drMenuItem("Url").ToString
                'agregamos el Ítem al menú
                menugest.Items.Add(mnuMenuItem)
                'hacemos un llamado al metodo recursivo encargado de generar el árbol del menú.
                AddMenuItem(mnuMenuItem, Dts_Items.Tables(0))
            End If
        Next
    End Sub
    Protected Sub AddMenuItem(ByRef mnuMenuItem As MenuItem, ByVal dtMenuItems As Data.DataTable)
        'recorremos cada elemento del datatable para poder determinar cuales son elementos hijos
        'del menuitem dado pasado como parametro ByRef.
        For Each drMenuItem As Data.DataRow In dtMenuItems.Rows
            If drMenuItem("PadreId").ToString.Equals(mnuMenuItem.Value) AndAlso
            Not drMenuItem("MenuId").Equals(drMenuItem("PadreId")) Then
                Dim mnuNewMenuItem As New MenuItem
                mnuNewMenuItem.Value = drMenuItem("MenuId").ToString
                mnuNewMenuItem.Text = drMenuItem("descripcion").ToString
                mnuNewMenuItem.NavigateUrl = drMenuItem("Url").ToString
                'Agregamos el Nuevo MenuItem al MenuItem que viene de un nivel superior.
                mnuMenuItem.ChildItems.Add(mnuNewMenuItem)
                'llamada recursiva para ver si el nuevo menú ítem aun tiene elementos hijos.
                AddMenuItem(mnuNewMenuItem, dtMenuItems)
            End If
        Next
    End Sub
    Protected Sub MenuItem_Click(ByVal sender As Object, ByVal e As MenuEventArgs) Handles menugest.MenuItemClick
        If menugest.SelectedItem.Text = "Salir" Then
            Session.Clear()
            FormsAuthentication.SignOut()
            Response.Redirect("~/entrada.aspx")
        End If
    End Sub
End Class