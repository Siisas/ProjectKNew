<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="default.aspx.vb" Inherits="digitacion._default" %>
<%@ Register src="~/Controles/Header.ascx" tagname="Header" tagprefix="Control" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1"  runat="server">
        <title>Kamilion ERP</title>
        <link rel="icon" href="~/favicon.ico" type="image/x-icon"/>              
        <link rel="shortcut icon" href="~/favicon.ico" type="image/x-icon"/>     
        <!--#########Scripts############-->
       <script type="text/javascript" src="Css2/jquery.min.js"></script>      
        <script type="text/javascript" src="Css2/jquery-ui.min.js"></script>   
        <script type="text/javascript" src="Css2/highcharts/highcharts.js"></script>
        <script type="text/javascript" src="Css2/highcharts/highcharts-3d.js"></script>
        <!--<script type="text/javascript" src="Css2/highcharts/exporting.js"></script>-->
        <script type="text/javascript" src="Css2/highcharts/highslide-full.min.js"></script>
        <script type="text/javascript" src="Css2/scripts.js"></script>
        <script type="text/javascript" src="default.aspx.js"></script>
        <!--#########Estilos############-->
        <link type="text/css" rel="Stylesheet" href="~/Css2/highcharts/highslide.css" />
        <link type="text/css" rel="Stylesheet" href="~/Css2/Boot/css/bootstrap.min.css"/>   
        <link type="text/css" rel="stylesheet" href="~/Css2/jquery-ui.css" />
        <link type="text/css" rel="Stylesheet" href="~/Css2/Kamilion.css"/>  
    </head>
    <body>    
        <form id="form1" runat="server">
            <asp:ScriptManager ID="Script_Mng_Cons_Novedad" runat="server"></asp:ScriptManager>
            <Control:Header ID="Header" runat="server"/>
            <asp:UpdatePanel ID="UpPan_Help_Reg" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Pnl_Message" runat="server">
                        <asp:Label ID="Lbl_Message" runat="server" ></asp:Label>
                    </asp:Panel>
                </ContentTemplate> 
            </asp:UpdatePanel>
            <article>
                <section id="Container_Graficos">
                </section>
            </article>
        </form>
        <footer ></footer>
    </body>
</html>


