Public Class Menu1
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim objdatos As New clsgeneral
            Dim dtmenuitems As New DataSet
            objdatos.estado = CType(Session("permisos"), clsusuario).perfil
            'dtmenuitems = objdatos.consultarmenu()
            If Session("dtsSeguridad") Is Nothing Then
                Session("dtsSeguridad") = objdatos.consultarmenu()
                dtmenuitems = Session("dtsSeguridad")
            Else
                dtmenuitems = Session("dtsSeguridad")
            End If
            For Each drMenuItem As Data.DataRow In dtmenuitems.Tables(0).Rows
                If drMenuItem("MenuId").Equals(drMenuItem("PadreId")) Then
                    Dim mnuMenuItem As New MenuItem
                    mnuMenuItem.Value = drMenuItem("MenuId").ToString
                    mnuMenuItem.Text = drMenuItem("descripcion").ToString
                    mnuMenuItem.NavigateUrl = drMenuItem("Url").ToString
                    'agregamos el Ítem al menú
                    Menugest.Items.Add(mnuMenuItem)
                    'hacemos un llamado al metodo recursivo encargado de generar el árbol del menú.
                    AddMenuItem(mnuMenuItem, dtmenuitems.Tables(0))
                End If
            Next

        End If
    End Sub
    Protected Sub AddMenuItem(ByRef mnuMenuItem As MenuItem, ByVal dtMenuItems As Data.DataTable)

        'recorremos cada elemento del datatable para poder determinar cuales son elementos hijos
        'del menuitem dado pasado como parametro ByRef.
        For Each drMenuItem As Data.DataRow In dtMenuItems.Rows
            If drMenuItem("PadreId").ToString.Equals(mnuMenuItem.Value) AndAlso _
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
    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles menugest.MenuItemClick
        If Menugest.SelectedItem.Text = "Salir" Then
            'Session("dtsSeguridad") = Nothing
            Session.Clear()
            FormsAuthentication.SignOut()
            Response.Redirect("~/entrada.aspx")
        End If
    End Sub

End Class