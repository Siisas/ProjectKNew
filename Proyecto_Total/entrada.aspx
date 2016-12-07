<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="entrada.aspx.vb" Inherits="digitacion.entrada" %>

<%--ooo--%>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">    
    <title>ERP Kamilion</title>
    <link rel="icon" href="favicon.ico" type="image/x-icon"/>
    <script type="text/javascript" src="Css2/jquery.min.js"></script>
    <script type="text/javascript" src="Css2/Boot/js/bootstrap.min.js"></script>
    <link type="text/css" rel="Stylesheet" href="~/Css2/Boot/css/bootstrap.min.css" />
    <link type="text/css" rel="Stylesheet" href="~/Css2/Kamilion.css"/>  
    <script type="text/javascript">
        $(document).ready(function () {
            var Val = false
            document.getElementById('Txt_Usuario').focus();
            $('#Txt_Password').off('keydown').keydown(function (event) {
                if (event.keyCode == 20) {
                    if (Val) {
                        Val = false;
                        document.getElementById('Caplock').style.visibility = 'hidden';
                    } else {
                        Val = true;
                        document.getElementById('Caplock').style.visibility = 'visible';
                    };
                };
            }).off('keypress').keypress(function (event) {
                if (event.shiftKey && (event.charCode >= 97 && event.charCode <= 122)) {
                    Val = true;
                    document.getElementById('Caplock').style.visibility = 'visible';
                } else if (!event.shiftKey) {
                    if (event.charCode >= 65 && event.charCode <= 90) {
                        Val = true;
                        document.getElementById('Caplock').style.visibility = 'visible';
                    } else {
                        Val = false;
                        document.getElementById('Caplock').style.visibility = 'hidden';
                    };
                } else {
                    Val = false;
                    document.getElementById('Caplock').style.visibility = 'hidden';
                }
            });
            //#d87474
        });
    </script>
</head>
<body style="background-image:url(Css2/Imagenes/FondoCafeteria.jpg);" >
    <form style="padding-top:90px;" runat="server">
        <div id="Pnl_Login">
        <div id="Form_Login" >
            <div id="Titulo_Login" class="text-center">
                <div id="Logo_Login"></div><div>ERP</div>
            </div><br />
            <div class="input-group input-group-lg">
                <div class="input-group-addon">
                    <span class="glyphicon glyphicon-user"></span>&nbsp;Vendedor&nbsp;&nbsp;&nbsp;
                </div>
                <asp:TextBox ID="Txt_Usuario"  runat="server" CssClass="form-control text-center"></asp:TextBox>
            </div>
            <div class="input-group input-group-lg">
                <div class="input-group-addon">
                    <span class="glyphicon glyphicon-lock"></span> Contraseña 
                </div>
                <asp:TextBox ID="Txt_Password" runat="server" TextMode="Password" CssClass="form-control text-center"></asp:TextBox>
            </div><br />
            <asp:Button ID="Btn_Login" runat="server" Text="Ingresar" CssClass="btn btn-primary center-block btn-lg"/>
            <asp:Panel runat="server" ID="Pnl_Message">
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </asp:Panel>
            <div id="Caplock" class="alert alert-info " >
                <span class="glyphicon glyphicon-info-sign glyphicon-bold"></span> Bloq Mayús activado
            </div>
        </div>
        </div>
    </form>
    <footer class="navbar-default navbar-fixed-bottom">
        <div class="container text-center">
            <p style="font-size:1.0vw">Copyright © Cafeteria Mil Delicias 2016</p>
        </div>
    </footer>   
</body>
</html>
