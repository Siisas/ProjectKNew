<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="HelpDeskSolucion.aspx.vb"
    Inherits="digitacion.HelpDeskSolucion" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ERP Kamilion - Solucion Help Desk</title>
    <link rel="icon" href="../favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../favicon.ico" type="image/x-icon" />
    <!-- Inicio Script jQuery Datepicker --->
    <link type="text/css" rel="stylesheet" href="../Css2/jquery-ui.css" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <link href="../Css2/Boot/css/ScrollBar.css" rel="stylesheet" />
    <script type="text/jscript">

        $(function () {
            $("#TxtFecha_Inicio").datepicker();
            $('#TxtFecha_Inicio').datepicker('option', { dateFormat: 'dd/mm/yy' });
            $("#TxtFecha_Fin").datepicker()
            $('#TxtFecha_Fin').datepicker('option', { dateFormat: 'dd/mm/yy' });
        });
    </script>
    <link href="../Css2/Boot/css/ScrollBar.css" rel="stylesheet" />
    <!-- Fin Script jQuery Datepicker --->
    <%--Colocar como comentario para ver correctamente la vista diseño--%>
    <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />
    <link type="text/css" rel="stylesheet" href="../Css2/maquetacion.css" />
    <%------------------------------------------------------------------%>
    <style type="text/css">
        ::-webkit-scrollbar
        {
            width: 14px;
        }
        ::-webkit-scrollbar-button
        {
            background-color: #B3C556;
            border-radius: 5px;
            background-image: -webkit-linear-gradient(45deg,rgba(255, 255, 255, .2) 25%,transparent 25%,
											          transparent 50%,rgba(255, 255, 255, .2) 50%,rgba(255, 255, 255, .2) 75%,
											          transparent 75%,/*SD*/transparent);
        }
        ::-webkit-scrollbar-button:hover
        {
            background-color: #EEEEEE;
        }
        ::-webkit-scrollbar-button:active
        {
            background: #aeaeb5;
        }
        ::-webkit-scrollbar-thumb
        {
            background-color: #B3C556;
            border-radius: 12px;
            background-image: -webkit-linear-gradient(45deg,rgba(255, 255, 255, .2) 25%,transparent 25%,
											          transparent 50%,rgba(255, 255, 255, .2) 50%,rgba(255, 255, 255, .2) 75%,
											          transparent 75%,/*SD*/transparent);
        }
        ::-webkit-scrollbar-thumb:hover
        {
            background-color: #EEEEEE;
        }
        ::-webkit-scrollbar-thumb:active
        {
            background: #aeaeb5;
        }
        
        *::selection
        {
            background: #B3C556;
            color: #fff;
        }
        ::-moz-selection
        {
            background: #B3C556;
            color: #fff;
        }
        @font-face
        {
            font-family: FuenteKamilion;
            src: url(../Css2/Boot/fonts/NEUROPOL.ttf);
        }
        body
        {
            background-color: #eee;
        }
        
        .titulo
        {
            transition: 2s ease;
            color: #B3C556;
            text-shadow: -2px -2px 1px #000;
        }
        
        .titulo:hover
        {
            color: #B3C556;
            text-shadow: -2px -2px 1px #fff;
        }
        
        .bordes
        {
            /*border: 1px solid black;*/
            -webkit-border-radius: 5px;
            -moz-border-radius: 5px;
            border-radius: 5px;
            overflow: hidden;
        }
        
        .celdasder
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
        }
        .celdascent
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
        }
        
        
        
        .style2
        {
            width: 100%;
        }
        
        
        
        
        /* .textotittabla
{
	font-family: Arial, Helvetica, sans-serif;
	font-size:small;
	color: #000042;
	font-weight: bold;
	background: #E2E8FA;
	width: 9%;
}*/
        
        .celdascons
        {
            width: 35%;
        }
        
        .celdascons
        {
            width: 35%;
        }
        
        .style3
        {
            color: #000099;
            width: 80%;
        }
        .style4
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
        }
        .style5
        {
            width: 80%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <table style="width: 100%; height: 100%">
        <tr>
            <td class="celdasder">
            </td>
            <td class="celdascent">
                <table style="width: 100%">
                    <tr>
                        <td align="left" style="width: 100%">
                            <h1 class="text-center" style="font-family: FuenteKamilion">
                                <span class="titulo" style="font-size: 110%">Kamilion Comunicaciones ERP</span></h1>
                        </td>
                    </tr>
                </table>
            </td>
            <td class="celdasder">
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="style4">
                <uc1:menu ID="menu" runat="server" />
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="style4">
                <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Consulta Help Desk</em></h4></asp:Label>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
            </td>
            <td class="auto-style2">
                <span class="alert alert-danger">
                    <asp:Label ID="lblmsg" runat="server" Style="color: #843534"></asp:Label>
                </span>
            </td>
            <td class="auto-style3">
            </td>
            <td class="auto-style2">
            </td>
            <td class="auto-style1">
            </td>
        </tr>
        <tr>
            <td class="celdasder">
            </td>
            <td valign="top" class="style5">
                <table class="style2">
                    <tr>
                        <td style="width: 30%">
                            <asp:Label ID="lblusuario" runat="server"></asp:Label>
                        </td>
                        <td style="width: 70%">
                            <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
            <td class="celdasder">
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;"
                valign="top" class="style3">
                &nbsp;
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="textotittabla">
                <table cellpadding="1" cellspacing="1" width="100%">
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td colspan="3">
                            <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px;
                                padding: 0.5px 0px 1px 0px">
                                <strong>Filtros de consulta</strong>
                            </div>
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            &nbsp;
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            &nbsp;
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Codigo Help Desk
                                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TxtCod_Help_Desk"
                                            ErrorMessage="El Codigo debe ser numérico" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                    </div>
                                    <asp:TextBox ID="TxtCod_Help_Desk" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                              <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Codigo Usuario 
                                        </div>
                                        <asp:TextBox ID="txt_cod_usu" runat="server" CssClass="form-control" MaxLength="5"></asp:TextBox>
                                    </div>
                                </div>

                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Fecha Inicio
                                        <asp:CompareValidator ID="CVFecha_Inicio" runat="server" ControlToValidate="TxtFecha_Inicio"
                                            ErrorMessage="Error en la fecha" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                    </div>
                                    <asp:TextBox ID="TxtFecha_Inicio" runat="server" CssClass="form-control" MaxLength="10"
                                        placeholder="DD/MM/YYYY"></asp:TextBox>
                                </div>
                            </div>
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Fecha Fin
                                        <asp:CompareValidator ID="CVFecha_Fin" runat="server" ControlToValidate="TxtFecha_Fin"
                                            ErrorMessage="Error en la fecha" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                    </div>
                                    <asp:TextBox ID="TxtFecha_Fin" runat="server" CssClass="form-control" MaxLength="10"
                                        placeholder="DD/MM/YYYY"></asp:TextBox>
                                </div>
                            </div>
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Estado
                                    </div>
                                    <asp:DropDownList ID="drlEstadoConsulta" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Abierto</asp:ListItem>
                                        <asp:ListItem>Gestionado</asp:ListItem>
                                        <asp:ListItem>Escalado</asp:ListItem>
                                        <asp:ListItem>Solucionado</asp:ListItem>
                                        <asp:ListItem>Rechazado</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                         <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Prioridad
                                    </div>
                                    <asp:DropDownList ID="drlPrioridad" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Bajo</asp:ListItem>
                                        <asp:ListItem>Medio</asp:ListItem>
                                        <asp:ListItem>Alto</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <asp:Button ID="btnConsultaCod_HelpDesk" runat="server" Text="Buscar" CssClass="btn btn-primary" />
                            <asp:Button ID="BtnTodos" runat="server" Text="Ver todos" CssClass="btn btn-primary" />
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            &nbsp;
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            &nbsp;
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            &nbsp;
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td colspan="3">
                            <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px;
                                padding: 0.5px 0px 1px 0px">
                                <strong>Registro de seguimiento del Help Desk</strong>
                            </div>
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            &nbsp;
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            &nbsp;
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Codigo HelpDesk
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="LblCod_HeplDeks" runat="server"
                                        CssClass="form-control" Enable="False"></asp:Label>
                                </div>
                            </div>
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Fecha Registro
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="LblFecha_Registro" runat="server"
                                        CssClass="form-control"></asp:Label>
                                </div>
                            </div>
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Usuario Asigna
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="LblUsuarioAsigan" runat="server"
                                        CssClass="form-control"></asp:Label>
                                </div>
                            </div>
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Fecha Asigando
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="LblFecha_Asigan" runat="server"
                                        CssClass="form-control"></asp:Label>
                                </div>
                            </div>
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Comentario
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="LblComentario" runat="server" CssClass="form-control"></asp:Label>
                                    <asp:TextBox ID="LblComentario1" runat="server" TextMode="MultiLine" CssClass="form-control"
                                        Enabled="False" Visible="False"></asp:TextBox>
                                </div>
                            </div>
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Prioridad
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="LblPrioridad" runat="server" CssClass="form-control"></asp:Label>
                                </div>
                            </div>
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Tema
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="LblTema" runat="server" CssClass="form-control"></asp:Label>
                                    <asp:TextBox ID="LblTema1" runat="server" TextMode="MultiLine" CssClass="form-control"
                                        Enabled="False" Visible="False"></asp:TextBox>
                                </div>
                            </div>
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Observacion
                                    </div>
                                    <asp:Label Style="background-color: inherit; overflow-y: auto" Height="80px" ID="LblObservacion"
                                        runat="server" CssClass="form-control"></asp:Label>
                                    <asp:TextBox ID="LblObservacion1" runat="server" TextMode="MultiLine" CssClass="form-control"
                                        Enabled="False" Visible="False"></asp:TextBox>
                                </div>
                            </div>
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Persona reporta falla
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="LblPersona_Reporta_Falla" runat="server"
                                        CssClass="form-control"></asp:Label>
                                </div>
                            </div>
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Modulo
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="LblModulo" runat="server" CssClass="form-control"></asp:Label>
                                </div>
                            </div>
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Estado
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="LblEstado" runat="server" CssClass="form-control"></asp:Label>
                                </div>
                            </div>
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Area
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="LblArea" runat="server" CssClass="form-control"></asp:Label>
                                </div>
                            </div>
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td colspan="3">
                            <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px;
                                padding: 0.5px 0px 1px 0px">
                                <strong></strong>
                            </div>
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            &nbsp;
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            &nbsp;
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Observacion
                                    </div>
                                    <asp:TextBox ID="txtObservacion" runat="server" TextMode="MultiLine" CssClass="form-control"
                                        MaxLength="250"></asp:TextBox>
                                </div>
                            </div>
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Estado
                                    </div>
                                    <asp:DropDownList ID="drlEstado" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Gestionado</asp:ListItem>
                                        <asp:ListItem>Escalado</asp:ListItem>
                                        <asp:ListItem>Solucionado</asp:ListItem>
                                        <asp:ListItem>Rechazado</asp:ListItem>
                                        <asp:ListItem>Escalado Claro</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Complejidad
                                    </div>
                                    <asp:DropDownList ID="drlcomplejidad" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Operatividad
                                    </div>
                                    <asp:DropDownList ID="drloperatividad" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Reiteracion
                                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtreiteracion"
                                            ErrorMessage="Error en la Reiteracion" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                    </div>
                                    <asp:TextBox ID="txtreiteracion" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Asignar a
                                    </div>
                                    <asp:DropDownList ID="drlTecnico" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                <asp:CheckBox ID="CheckBoxTipificacion" AutoPostBack="true" runat="server" />
                                                Cambio Tipificacion Categoria
                                            </div>
                                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                <ContentTemplate>
                                                    <asp:DropDownList ID="drlCategoria" runat="server" CssClass="form-control" AutoPostBack="True">
                                                    </asp:DropDownList>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Tipo
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlTipo" runat="server" CssClass="form-control">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        <asp:CheckBox ID="CheckBoxArea" runat="server" />
                                        Area
                                    </div>
                                    <asp:DropDownList ID="drlAreaUpdate" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" Visible="False" CssClass="btn btn-primary" />
                        </td>
                        <td style="width: 5%">
                            &nbsp;
                        </td>
                        <td style="width: 25%">
                            &nbsp;
                        </td>
                        <td style="width: 9%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5">
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <h4>
                    <em style="color: #8F9E45">Consulta Help Desk</em>
                    <asp:Label ID="lblcuentaHelpDesk" runat="server" ForeColor="#8F9E45"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button
                        ID="Btnxls" runat="server" Text="Exportar" Visible="False" CssClass="btn btn-primary" /></h4>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <div class="bordes">
                    <asp:GridView ID="dtggeneralHelpDesk" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                        CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="80" Width="100%"
                        Style="font-size: x-small" EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Cod_HelpDesk_Registro" HeaderText="Codigo" />
                            <asp:BoundField DataField="Fecha_Registro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="Prioridad" HeaderText="Prioridad" />
                            <asp:BoundField DataField="Tema" HeaderText="Tema" />
                            <asp:BoundField DataField="Observacion" HeaderText="Observación" />
                            <asp:BoundField DataField="Estado" HeaderText="Estado" />
                            <asp:BoundField DataField="Canal" HeaderText="Canal" />
                            <asp:BoundField DataField="Persona_Reporta" HeaderText="Reporta" />
                            <asp:BoundField DataField="Modulo" HeaderText="Modulo" />
                            <asp:BoundField DataField="codnom" HeaderText="Cod" />
                            <asp:BoundField DataField="Area" HeaderText="Area" />
                            <asp:BoundField DataField="Asigna" HeaderText="Asigna" />
                            <asp:BoundField DataField="Fecha_Asigna" HeaderText="Fecha Asigna" />
                            <asp:BoundField DataField="ObservacionAsigna" HeaderText="Observacion Asigna" />
                            <asp:ButtonField CommandName="Seleccion" HeaderText="Seleccion un Caso" Text="Seleccion" />
                        </Columns>
                        <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                </div>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;"
                valign="top" class="style3">
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <h4 style="color: #8F9E45">
                    <em>Consulta Soluciones Brindadas:&nbsp;&nbsp;&nbsp;&nbsp;</em>
                    <asp:Label ID="lblcuentaSoluciones" runat="server"></asp:Label></h4>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <div class="bordes">
                    <asp:GridView ID="dtggeneralHelpDeskSolucion" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                        CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="40" Width="100%"
                        Style="font-size: x-small" EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Cod_HelpDesk_Solucion" HeaderText="Codigo" />
                            <asp:BoundField DataField="Fecha_Registro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario" />
                            <asp:BoundField DataField="Categoria" HeaderText="Categoria" />
                            <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                            <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                            <asp:BoundField DataField="Estado" HeaderText="Estado" />
                            <asp:BoundField DataField="Complejidad" HeaderText="Complejidad" />
                            <asp:BoundField DataField="Operatividad" HeaderText="Operatividad" />
                            <asp:BoundField DataField="Reiteracion" HeaderText="Reiteracion" />
                            <asp:BoundField DataField="Fk_Cod_HelpDesk_Registro" HeaderText="Help Desk Registro" />
                        </Columns>
                        <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                </div>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                &nbsp;
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
    </table>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" />
    </form>
</body>
</html>
