<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Header.ascx.vb" Inherits="digitacion.Header" %>
<%--IMPORTAR ICONO--%>
<link rel="icon" href="~/favicon.ico" type="image/x-icon"/>   
<%--####### Copyrigth © 2016 Area de Desarrollo, Crisitan Duarte C1477, Gerson Sanchez C1555 #######--%>
<header>
    <div class="Big-Title">Kamilion Comunicaciones ERP</div>    
    <asp:Menu ID="menugest" runat="server" StaticPopOutImageUrl="~/Css2/Imagenes/flecha.png" DynamicPopOutImageUrl="~/Css2/Imagenes/flecha.png" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="Small" Orientation="Horizontal" StaticSubMenuIndent="10px" StaticMenuStyle-CssClass ="Menu" StaticMenuItemStyle-CssClass="Celdas" StaticHoverStyle-CssClass="Celdas-Hover" DynamicMenuItemStyle-CssClass="Celdas" DynamicMenuStyle-CssClass="Fondo_Trans_Hover" DynamicHoverStyle-CssClass="Celdas-Hover" DynamicSelectedStyle-CssClass="Fondo_Trans_Hover" SkipLinkText="">
        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <DynamicMenuStyle BackColor="transparent"/>
    </asp:Menu>
    <div class="Small-Title"><asp:Label runat="server" ID="Titulo_Formulario"></asp:Label></div>
    <div class="Credenciales">
        <asp:Label ID="Lbl_Usuario" runat="server"></asp:Label>
        <asp:Label ID="Lbl_Cod" runat="server"></asp:Label>
        <asp:Label ID="Lbl_Nombre" runat="server"></asp:Label>
        <asp:Label ID="Lbl_Perfil" runat="server"></asp:Label>
        <span>
            <asp:Label ID="Lbl_SuperVisor_Titulo" runat="server">Supervisor: </asp:Label>
            <asp:Label ID="Lbl_Supervisor" runat="server"></asp:Label>
        </span>
        <span>
            <asp:Label ID="Lbl_Jefe_Inmediato" runat="server"></asp:Label>
        </span>
        <span>
            <asp:Label ID="Lbl_Segmento" runat="server"></asp:Label>
        </span>
    </div>
</header>
<div id="Desp_Loading" class="Desplegable"></div>
<%--####### Copyrigth © 2016 Area de Desarrollo, Crisitan Duarte C1477, Gerson Sanchez C1555 #######--%>