<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Menu.ascx.vb" Inherits="digitacion.Menu1" %>
<asp:Menu ID="menugest" runat="server" 
    StaticPopOutImageUrl="~/Css2/Imagenes/flecha.png"
    DynamicPopOutImageUrl="~/Css2/Imagenes/flecha.png"
    DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="Small" 
    Orientation="Horizontal" StaticSubMenuIndent="10px"  
    StaticMenuStyle-CssClass ="Menu"             
    StaticMenuItemStyle-CssClass="Celdas" 
    StaticHoverStyle-CssClass="Celdas-Hover"
    DynamicMenuItemStyle-CssClass="Celdas" 
    DynamicMenuStyle-CssClass="Fondo_Trans_Hover" 
    DynamicHoverStyle-CssClass="Celdas-Hover" 
    DynamicSelectedStyle-CssClass="Fondo_Trans_Hover">
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicMenuStyle BackColor="transparent"/>
</asp:Menu>
<%-- editado por aprendiz sena Gerson Sanchez Ospina 20/11/2015  --%>
