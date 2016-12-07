<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RegCRM_Config_Red.aspx.vb"
    Inherits="digitacion.RegCRM_Config_Red" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <%--© CDRR--%>
    <title>ERP Kamilion - Registro CRM Configuracion Red</title>
    <link rel="icon" href="../favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../favicon.ico" type="image/x-icon" />
    <%--Colocar como comentario para ver correctamente la vista diseño--%>
    <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />
    <link type="text/css" rel="stylesheet" href="../Css2/maquetacion.css" />
    <%------------------------------------------------------------------%>
    <!-- Inicio Script jQuery Datepicker --->
    <link type="text/css" rel="stylesheet" href="../Css2/jquery-ui.css" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui-timepiker.js"></script>
    <script type="text/jscript">
        var $_$ = jQuery.noConflict();
        function pageLoad() {
            $_$("#txtfecha").datetimepicker({}).val(); /*Fecha y Hora*/
        }
    </script>
    <!-- Fin Script jQuery Datepicker --->
    <style type="text/css">
        ::-webkit-scrollbar
        {
            width: 14px;
        }
        
        ::-webkit-scrollbar-button
        {
            background-color: #B3C556;
            border-radius: 5px;
            background-image: -webkit-linear-gradient(45deg,rgba(255, 255, 255, .2) 25%,transparent 25%, transparent 50%,rgba(255, 255, 255, .2) 50%,rgba(255, 255, 255, .2) 75%, transparent 75%, /*SD*/ transparent);
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
            background-image: -webkit-linear-gradient(45deg,rgba(255, 255, 255, .2) 25%,transparent 25%, transparent 50%,rgba(255, 255, 255, .2) 50%,rgba(255, 255, 255, .2) 75%, transparent 75%, /*SD*/ transparent);
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
        
        .celdascent_Bootstrap
        {
            width: 80%;
        }
        
        .Tamanio_Tabla
        {
            width: 100%;
            height: 100%;
        }
        
        .linkbutton
        {
            color: #B3C556;
            text-decoration: none;
        }
        
        .linkbutton:hover
        {
            color: #555555;
            text-decoration: solid;
            text-decoration-color: #fff;
        }
        /*Tamaños Internos de un TD*/
        .td_Mitad
        {
            width: 5%;
        }
        
        .td_Mitad
        {
            width: 5%;
        }
        
        .td_Intermedio
        {
            /*width: 25%;*/
            width: 34%;
        }
        /*.td_Externo
        {
            width: 9%;
        }*/
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
            <td class="celdascent_Bootstrap">
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
            <td class="celdascent_Bootstrap">
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
            <td class="celdascent_Bootstrap">
                <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Registro CRM Configuracion Cambio de Red</em></h4></asp:Label>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
            </td>
            <td class="celdascent_Bootstrap">
                <table class="Tamanio_Tabla">
                    <tr>
                        <td style="width: 30%">
                            <asp:Label ID="lblusuario" runat="server"></asp:Label>
                        </td>
                        <td style="width: 70%">
                            <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
                            &nbsp;&nbsp;<asp:Label ID="LblPerfil" runat="server" Font-Size="X-Large" ForeColor="#009933"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label
                                ID="LblSuperVisorTitulo" runat="server" Text="Supervisor: "></asp:Label><asp:Label
                                    ID="LblSupervisor" runat="server"></asp:Label>
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
            <td class="celdascent_Bootstrap">
                <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                    <ContentTemplate>
                        <span class="alert alert-danger">
                            <asp:Label ID="lblmsg" runat="server" Style="color: #843534"></asp:Label>
                        </span>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent_Bootstrap">
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                <%--  <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
                    Style="color: #8F9E45" />--%>
            </td>
            <td class="celdascent_Bootstrap">
                <table cellpadding="1" cellspacing="1" width="100%">
                    <tr>
                        <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        <td class="td_Intermedio">
                            <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Caso<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtcaso"
                                            ErrorMessage="El caso debe ser numérico" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                                    </div>
                                    <asp:TextBox ID="txtcaso" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                </div>
                            </div>
                        </td>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
                            <div class="form-group">
                                <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" />
                            </div>
                        </td>
                        <%--   <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                    </tr>
                    <tr>
                        <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        <td colspan="3">
                            <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px;
                                padding: 0.5px 0px 1px 0px">
                                <strong>&nbsp;</strong>
                            </div>
                        </td>
                        <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                    </tr>
                    <tr>
                        <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        <td colspan="3">
                            &nbsp;
                        </td>
                        <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                    </tr>
                    <tr>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Caso</div>
                                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                    <ContentTemplate>
                                        <asp:Label ID="lblcaso" runat="server" CssClass="form-control" Style="background-color: inherit"></asp:Label>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <%--  <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
                        </td>
                        <%--<td class="td_Externo">
                            &nbsp;
                        </td>--%>
                    </tr>
                    <tr>
                        <%--  <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Nombre
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                    <ContentTemplate>
                                        <asp:Label Style="background-color: inherit" ID="lblcliente" runat="server" CssClass="form-control"
                                            Enable="False"></asp:Label>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Min</div>
                                <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                    <ContentTemplate>
                                        <asp:Label Style="background-color: inherit" ID="lblmin" runat="server" CssClass="form-control"
                                            Enable="False"></asp:Label>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <%--  <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                    </tr>
                    <tr>
                        <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Departamento</div>
                                <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                    <ContentTemplate>
                                        <asp:Label Style="background-color: inherit" ID="Lbldepartamento" runat="server"
                                            CssClass="form-control" Enable="False"></asp:Label>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Municipio
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                                    <ContentTemplate>
                                        <asp:Label Style="background-color: inherit" ID="Lblmunicipio" runat="server" CssClass="form-control"></asp:Label>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                    </tr>
                    <tr>
                        <%--<td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Tipo de Linea
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                                    <ContentTemplate>
                                        <asp:Label Style="background-color: inherit" ID="Lbltipolinea" runat="server" CssClass="form-control"
                                            Enable="False"></asp:Label>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Estado Linea
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel20" runat="server">
                                    <ContentTemplate>
                                        <asp:Label Style="background-color: inherit" ID="LblEstado_linea" runat="server"
                                            CssClass="form-control" Enable="False"></asp:Label>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                    </tr>
                    <tr>
                        <%--<td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Resultado Contacto
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel21" runat="server">
                                    <ContentTemplate>
                                        <asp:Label Style="background-color: inherit" ID="lblresultado" runat="server" CssClass="form-control"
                                            Enable="False"></asp:Label>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Fecha Ingreso
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel23" runat="server">
                                    <ContentTemplate>
                                        <asp:Label Style="background-color: inherit" ID="Lblfc_ingreso" runat="server" CssClass="form-control"></asp:Label>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                    </tr>
                    <tr>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Equipo
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel25" runat="server">
                                    <ContentTemplate>
                                        <asp:Label Style="background-color: inherit" ID="lblEquipo" runat="server" CssClass="form-control"></asp:Label>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Campaña
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel26" runat="server">
                                    <ContentTemplate>
                                        <asp:Label Style="background-color: inherit" ID="lblcampaña" runat="server" CssClass="form-control"></asp:Label>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Corporativo
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel27" runat="server">
                                    <ContentTemplate>
                                        <asp:Label Style="background-color: inherit" ID="lblCorporativo" runat="server" CssClass="form-control"></asp:Label>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Numero Alterno
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel28" runat="server">
                                    <ContentTemplate>
                                        <asp:Label Style="background-color: inherit" ID="lblmin_alterno" runat="server" CssClass="form-control"></asp:Label>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <%--  <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        <td colspan="3">
                            <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px;
                                padding: 0.5px 0px 1px 0px">
                                <strong>&nbsp;</strong>
                            </div>
                        </td>
                        <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                    </tr>
                    <tr>
                        <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        <td class="td_Intermedio">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <h4>
                                        &nbsp;<asp:Button ID="Btn_Guardar" runat="server" Text="Guardar" Visible="true" CssClass="btn btn-primary" /></h4>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
                            &nbsp;
                        </td>
                        <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                    </tr>
                    <tr>
                        <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Resultado Contacto</div>
                                <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="drlresultado" runat="server" CssClass="form-control" AutoPostBack="True">
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Resultado Configuracion
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel_Tipo_Encuesta" runat="server">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="Drlresultado_config" runat="server" CssClass="form-control"
                                            AutoPostBack="True">
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <%--                            <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                    </tr>
                    <tr>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Fecha Programado
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel22" runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox ID="txtfecha" runat="server" CssClass="form-control" placeholder="DD/MM/YYYY"
                                            Enabled="False" MaxLength="20"></asp:TextBox>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="Txt_min_Alterno"
                                                ErrorMessage="El campo debe ser numerico" Operator="DataTypeCheck" Type="Integer" Display="Dynamic"/>
                            <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                <ContentTemplate>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Numero Alterno                                            
                                        </div>
                                        <asp:TextBox ID="Txt_min_Alterno" CssClass="form-control" Enabled="true" MaxLength="10"
                                            runat="server"></asp:TextBox>
                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Observaciones
                                </div>
                                <%--<div style="background-color: inherit;"  class="form-control">--%>
                                <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox ID="Txt_Obs" CssClass="form-control" TextMode="MultiLine" Enabled="true"
                                            runat="server"></asp:TextBox>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                <%--</div>--%>
                            </div>
                        </td>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Corporativo
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="DrlCorporativo" runat="server" CssClass="form-control">
                                            <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                            <asp:ListItem>SI</asp:ListItem>
                                            <asp:ListItem>NO</asp:ListItem>
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Estado Linea</div>
                                <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="Drlestado_linea" Enabled="true" runat="server" CssClass="form-control">
                                            <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                            <asp:ListItem>Activa</asp:ListItem>
                                            <asp:ListItem>Inactiva</asp:ListItem>
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Dual Sim
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="DrlDual_sim" runat="server" CssClass="form-control">
                                            <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                            <asp:ListItem>SI</asp:ListItem>
                                            <asp:ListItem>NO</asp:ListItem>
                                            <asp:ListItem>NO REGISTRA</asp:ListItem>
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <%--<td class="td_Externo">
                            &nbsp;
                        </td>--%>
                    </tr>
                    <tr>
                        <%--  <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        <td class="td_Intermedio">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Marca
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlmarca" runat="server" AutoPostBack="True" CssClass="form-control">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                        </td>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
                            <div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Equipo
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlequipo" runat="server" CssClass="form-control" Width="76%"
                                                AutoPostBack="true">
                                            </asp:DropDownList>
                                            <asp:TextBox ID="txtequipo_act" CssClass="form-control" Enabled="false" MaxLength="50"
                                                runat="server" Width="120px"></asp:TextBox>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                        </td>
                        <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                    </tr>
                    <tr>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Departamento Actual
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="drldpto" runat="server" AutoPostBack="True" CssClass="form-control">
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Municipio Actual
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel24" runat="server">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="drlmun" runat="server" CssClass="form-control">
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        <td class="td_Intermedio">
                            <asp:RegularExpressionValidator ID="direccion" runat="server" ErrorMessage="La direccion debe tener minimo 5 caracteres"
                                ValidationExpression="^[\w \# \. \: \- \s]{5,200}$" ControlToValidate="txtdireccion" Display="Dynamic" CssClass="textoError" />
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Direccion
                                </div>
                                <%-- <div style="background-color: inherit; " class="form-control">--%>
                                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox ID="txtdireccion" CssClass="form-control" Enabled="true" MaxLength="80"
                                            runat="server"></asp:TextBox>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                            <%--  </div>--%>
                        </td>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
                        <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                    <ContentTemplate>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="El barrio debe tener minimo 4 caracteres"
                                ValidationExpression="^[\w \# \. \- \s]{4,200}$" ControlToValidate="txtbarrio" Display="Dynamic" CssClass="textoError" />
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Barrio</div>
                                <%--<div style="background-color: inherit; " class="form-control">--%>
                                
                                        <asp:TextBox ID="txtbarrio" CssClass="form-control" Enabled="true" MaxLength="100"
                                            runat="server"></asp:TextBox>
                                   
                            </div>
                             </ContentTemplate>
                                </asp:UpdatePanel>
                            <%--   </div>--%>
                        </td>
                        <%--<td class="td_Externo">
                            &nbsp;
                        </td>--%>
                    </tr>
                    <tr>
                        <td class="td_Intermedio">
                            <asp:CompareValidator ID="ICCID" runat="server" ControlToValidate="txtnumero" ErrorMessage="La primera parte de ICCID debe ser numeros"
                                Operator="DataTypeCheck" Type="Double" Display="Dynamic" />
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtletra"
                                ErrorMessage="La segunda parte de ICCID debe ser letras" ForeColor="Red" Display="Dynamic"
                                ValidationExpression="^[A-Za-z]*$" />
                            <asp:UpdatePanel ID="UpdatePanel30" runat="server">
                                <ContentTemplate>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            ICCID &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <div class="input-group">
                                            <asp:TextBox ID="txtnumero" runat="server" CssClass="form-control" Width="100%"
                                                MaxLength="17"></asp:TextBox>
                                            <span class="input-group-addon">-</span>
                                            <asp:TextBox ID="txtletra" runat="server" CssClass="form-control" Width="25%" MaxLength="2"></asp:TextBox>
                                        </div>
                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                        <td class="td_Mitad">
                            &nbsp;
                        </td>
                        <td class="td_Intermedio">
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
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent_Bootstrap">
                <h4>
                    <em style="color: #8F9E45">Consulta Gestiones :</em>
                    <asp:Label ID="lblcuenta" runat="server" ForeColor="#8F9E45"></asp:Label></h4>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent_Bootstrap">
                <asp:UpdatePanel ID="UpdatePanel29" runat="server">
                    <ContentTemplate>
                        <div class="bordes">
                            <asp:GridView ID="dtggestiones" runat="server" AllowPaging="True" CellPadding="4"
                                ForeColor="#333333" GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent_Bootstrap">
                &nbsp;
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
