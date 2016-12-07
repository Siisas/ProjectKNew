<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RegCrm_Falla_Des.aspx.vb" Inherits="digitacion.RegCrm_Falla_Des" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <%--© CDRR--%>
    <title>ERP Kamilion - Registro CRM Clientes con Intención de Desactivación</title>
    <link rel="icon" href="../favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../favicon.ico" type="image/x-icon" />
    <%--Colocar como comentario para ver correctamente la vista diseño--%>
        <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />
        <link type="text/css" rel="stylesheet" href="../Css2/maquetacion.css" />
    <%------------------------------------------------------------------%>

      <!-- Inicio Script jQuery Datepicker --->
      <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
      <script type="text/javascript" src="../Css2/jquery.min.js"></script>
      <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
      <script type="text/javascript" src="../Css2/jquery-ui-timepiker.js"></script>
    <script type="text/jscript">
        var $_$ = jQuery.noConflict();
        function pageLoad() {
            $_$("#txtfcingn3").datepicker({}).val();
            $_$("#txtfcactivacion").datepicker({}).val();
            $_$("#txtfc_programado").datetimepicker({}).val(); /*Fecha y Hora*/
        }
    </script>

      <!-- Fin Script jQuery Datepicker --->
    <style type="text/css">
        ::-webkit-scrollbar {
            width: 14px;    
        }
        ::-webkit-scrollbar-button {
            background-color:#B3C556;
            border-radius: 5px;
	        background-image: -webkit-linear-gradient(45deg,rgba(255, 255, 255, .2) 25%,transparent 25%,
											          transparent 50%,rgba(255, 255, 255, .2) 50%,rgba(255, 255, 255, .2) 75%,
											          transparent 75%,/*SD*/transparent)
        } 
        ::-webkit-scrollbar-button:hover {
            background-color: #EEEEEE;
        }
        ::-webkit-scrollbar-button:active {
          background: #aeaeb5;
        }
        ::-webkit-scrollbar-thumb {
            background-color: #B3C556;	
            border-radius: 12px;
	        background-image: -webkit-linear-gradient(45deg,rgba(255, 255, 255, .2) 25%,transparent 25%,
											          transparent 50%,rgba(255, 255, 255, .2) 50%,rgba(255, 255, 255, .2) 75%,
											          transparent 75%,/*SD*/transparent)
        }
        ::-webkit-scrollbar-thumb:hover {
            background-color: #EEEEEE;
        }
        ::-webkit-scrollbar-thumb:active {
          background: #aeaeb5;
        }
        
        *::selection {
            background: #B3C556;
            color: #fff;
                    }
       ::-moz-selection {background: #B3C556;
        color: #fff;

       }
        @font-face {
            font-family: FuenteKamilion;
            src: url(../Css2/Boot/fonts/NEUROPOL.ttf);
        }

        body {
            background-color: #eee;
        }

        .titulo {
            transition: 2s ease;
            color: #B3C556;
            text-shadow: -2px -2px 1px #000;
        }

            .titulo:hover {
                color: #B3C556;
                text-shadow: -2px -2px 1px #fff;
            }

        .bordes {
            /*border: 1px solid black;*/
            -webkit-border-radius: 5px;
            -moz-border-radius: 5px;
            border-radius: 5px;
            overflow: hidden;
        }

        .celdasder {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
        }

        .celdascent {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
        }



        .style2 {
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

        .celdascons {
            width: 35%;
        }

        .celdascons {
            width: 35%;
        }

        .style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
        }

        .style5 {
            width: 80%;
        }
        .auto-style1 {
            width: 5%;
        }
        .linkbutton
        {
          color: #B3C556;
          text-decoration:none ;


        }
        .linkbutton:hover
        {
            color: #555555;
            text-decoration:solid;
            text-decoration-color: #fff; 
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <table style="width: 100%; height: 100%">
            <tr>
                <td class="celdasder"></td>
                <td class="celdascent">
                    <table style="width: 100%">
                        <tr>
                            <td align="left" style="width: 100%">
                                <h1 class="text-center" style="font-family: FuenteKamilion"><span class="titulo" style="font-size: 110%">Kamilion Comunicaciones ERP</span></h1>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder"></td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="style4">
                    <uc1:menu ID="menu" runat="server" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="style4">
                    <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Registro CRM Clientes con Intención de Desactivación</em></h4></asp:Label>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder"></td>
                <td valign="top" class="style5">
                    <table class="style2">
                        <tr>
                            <td style="width: 30%">
                                <asp:Label ID="lblusuario" runat="server"></asp:Label>
                            </td>
                            <td style="width: 70%">
                                <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
                                &nbsp;&nbsp;<asp:Label ID="LblPerfil" runat="server" Font-Size="X-Large" ForeColor="#009933"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="LblSuperVisorTitulo" runat="server" Text="Supervisor: "></asp:Label><asp:Label ID="LblSupervisor" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder"></td>
            </tr>  
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="style4">
                <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                <ContentTemplate>
                    <span class="alert alert-danger">
                        <asp:Label ID="lblmsg" runat="server" Style="color: #843534"></asp:Label>
                    </span><br/>
                </ContentTemplate>
                </asp:UpdatePanel>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>            
            <tr>
                <td class="celdasder">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" style="color:#8F9E45"/>
                </td>
                <td class="textotittabla">
                  <table cellpadding="1" cellspacing="1" width="100%">
                        <tr>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                <div class="form-group">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Caso<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtcaso"
                                                ErrorMessage="El caso debe ser numérico" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                                        </div>
                                        <asp:TextBox ID="txtcaso" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                <div class="form-group">
                                    <div>
                                        <div>
                                            <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" />
                                            &nbsp;
                                            <asp:Button ID="BtnNuevo_caso" runat="server" Text="Nuevo Caso" CssClass="btn btn-primary" />
                                            &nbsp;&nbsp;&nbsp;
                                            <asp:Label ID="LblEscalamiento" runat="server"></asp:Label>
                                        </div>
                                    </div>
                                </div>
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
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px;
                                    padding: 0.5px 0px 1px 0px">
                                    <strong>&nbsp;</strong>
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
                                <h4>
                                    <em style="color: #8F9E45">Identificación Caso Nivel 3&nbsp;&nbsp;&nbsp;</em>
                                    <asp:Button ID="Btn_Indentifica_N3" runat="server" Text="Guardar" CssClass="btn btn-primary" /></h4>
                            </td>
                            <td class="auto-style1">
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
                                            Fecha Ingreso Caso
                                            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtfcingn3"
                                                ErrorMessage="La fecha de ingreso no es válida" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                        </div>
                                        <asp:TextBox ID="txtfcingn3" runat="server" CssClass="form-control" placeholder="DD/MM/YYYY"
                                            MaxLength="10"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            PQR
                                        </div>
                                        <asp:CheckBox ID="chkpqr" runat="server" CssClass="form-control" />
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
                                            Consultor Claro Remite
                                        </div>
                                        <asp:DropDownList ID="drlingclaro" runat="server" CssClass="form-control">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Nuevo Consultor
                                        </div>
                                        <asp:TextBox ID="txtingclaro" runat="server" CssClass="form-control" Width="67%"></asp:TextBox>&nbsp;<asp:Button
                                            ID="Btn_Guardar_NConsultor" runat="server" Text="Guardar" CssClass="btn btn-primary"
                                            Width="30%" />
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5" class="auto-style2">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px;
                                    padding: 0.5px 0px 1px 0px">
                                    <strong>&nbsp;</strong>
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
                                <h4>
                                    <em style="color: #8F9E45">Registro de Seguimiento&nbsp;&nbsp;&nbsp;</em>
                                    <asp:Button ID="Btn_Guardar" runat="server" Text="Guardar" Enabled="False" CssClass="btn btn-primary" /></h4>
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                &nbsp;
                            </td>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                        </tr>
                       <%-- <tr>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                               
                            </td>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                        </tr>--%>
                       
                        <tr>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                <div>
                                    <asp:UpdatePanel ID="UpdatePanel26" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">
                                                    Se comunica a linea alterna
                                                    <asp:CompareValidator ID="CompareValidator3" Display="Dynamic"  runat="server" ControlToValidate="txtnumalt" ValidationGroup="VG_Registrar" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                                    <asp:RegularExpressionValidator ID="telefono" runat="server" ErrorMessage="*" ValidationExpression="^[\w \# \. \: \- \s]{10,200}$" ControlToValidate="txtnumalt" Display="Dynamic" CssClass="textoError" />    
                                                    <asp:RadioButton ID="chkSi" runat="server" GroupName="Numero" Text="SI" AutoPostBack="true" />
                                                    <asp:RadioButton ID="chkNo" runat="server" GroupName="Numero" Text="NO" AutoPostBack="true" />
                                                </div>
                                                <asp:TextBox ID="txtnumalt" runat="server" MaxLength="10" CssClass="form-control" Enabled="False" placeholder="Numero"></asp:TextBox>
                                                
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>


                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                               
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Observación
                                        </div>
                                        <asp:TextBox ID="txtobs" runat="server" TextMode="MultiLine" CssClass="form-control" Width=100%></asp:TextBox>
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
                                            Marca
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlmarca" runat="server" AutoPostBack="True" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
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
                                            Equipo
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlequipo" runat="server" CssClass="form-control" Width="76%">
                                                </asp:DropDownList>
                                                <span id="Span3" runat="server" class="input-group-btn">
                                                    <asp:Button ID="Btn_act_equipo" Width="99%" runat="server" Visible="true" Enabled="false"
                                                        Text="Actualizar" CssClass="btn btn-primary" />
                                                </span>
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
                                            Departamento
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drldpto" runat="server" AutoPostBack="True" CssClass="form-control">
                                                    <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>SI</asp:ListItem>
                                                    <asp:ListItem>NO</asp:ListItem>
                                                    <asp:ListItem>NS/NR</asp:ListItem>
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
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
                                            Municipio
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlmun" runat="server" CssClass="form-control" Width="75%">
                                                    <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>SI</asp:ListItem>
                                                    <asp:ListItem>NO</asp:ListItem>
                                                    <asp:ListItem>NS/NR</asp:ListItem>
                                                </asp:DropDownList>
                                                <span id="Span2" runat="server" class="input-group-btn">
                                                    <asp:Button ID="Btn_act_municipio" Width="99%" runat="server" Visible="true" Enabled="false"
                                                        Text="Actualizar" CssClass="btn btn-primary" />
                                                </span>
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
                                            Escalamiento CPD/SD
                                        </div>
                                        <asp:TextBox ID="TxtEscalamiento_CPD_SD" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                             <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Tipo linea
                                        </div>
                                        <asp:DropDownList ID="drltipolinea" runat="server" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem>Pospago</asp:ListItem>
                                            <asp:ListItem>Prepago</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <%--<div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Segmentación línea
                                        </div>
                                        <asp:DropDownList ID="drlSegmentacion_linea" runat="server" CssClass="form-control">
                                        </asp:DropDownList>
                                    </div>
                                </div>--%>
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
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Tipo PQR
                                    </div>
                                    <asp:DropDownList ID="drlTipo_PQR" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            PQR
                                            <asp:CompareValidator ID="CV_PQR" runat="server" ControlToValidate="TxtPQR" ErrorMessage="El valor del PQR debe ser numerico"
                                                Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                                        </div>
                                        <asp:Label ID="LblPQR" runat="server" Width="65%" Style="text-align: right;" CssClass="form-control"></asp:Label><asp:TextBox
                                            ID="TxtPQR" runat="server" MaxLength="7" Width="35%" CssClass="form-control"></asp:TextBox>
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
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Línea de Servicio
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drllinea" runat="server" CssClass="form-control" AutoPostBack="True">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Servicio
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlservicio2" runat="server" CssClass="form-control" AutoPostBack="True">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
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
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Subservicio
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel20" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlsubservicio" runat="server" CssClass="form-control" AutoPostBack="True">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Solicitud / Tipo Falla
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel21" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlsolicitud" runat="server" CssClass="form-control">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
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
                                            Correo electrónico
                                        </div>
                                        <asp:TextBox ID="TxtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>

                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                               
                            </td>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                        </tr>
                     
                        <%--TIPO CLIENTE--%>
                        <tr>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px;
                                    padding: 0.5px 0px 1px 0px">
                                    <strong>
                                        <center>TIPO CLIENTE</center>
                                    </strong>
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
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Intensión de Desactivación por falla en
                                    </div>
                                    <asp:DropDownList ID="drlIntension_Des_Por_Fallaen" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Tipo de proceso de la línea
                                    </div>
                                    <asp:DropDownList ID="drlTipo_Proceso_Linea" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                    </asp:DropDownList>
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
                               <div class="input-group">
                                    <div class="input-group-addon">
                                        Tipo pqr adicional
                                    </div>
                                    <asp:DropDownList ID="drlTipo_Pqr_Adicional" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                              <div class="input-group">
                                    <div class="input-group-addon">
                                        Aplica fidelizacion
                                    </div>
                                    <asp:DropDownList ID="drlAplica_Fidelizacion" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </td>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                        </tr>
                        <%-----------------%>

                        <tr>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px;
                                    padding: 0.5px 0px 1px 0px">
                                    <strong>
                                        <center>
                                            CATALOGO DE DIAGNOSTICO</center>
                                    </strong>
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
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Reclamo Principal
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel_Reclamo_Principal" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlreclamoppal" runat="server" CssClass="form-control" AutoPostBack="True">
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                <asp:ListItem>SI</asp:ListItem>
                                                <asp:ListItem>NO</asp:ListItem>
                                                <asp:ListItem>NS/NR</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Tipo Falla Rec Ppal
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel_Tipo_Falla_Reclamo_Ppal" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drltipofalla" runat="server" CssClass="form-control">
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                <asp:ListItem>SI</asp:ListItem>
                                                <asp:ListItem>NO</asp:ListItem>
                                                <asp:ListItem>NS/NR</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
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
                             <div class="input-group">
                                    <div class="input-group-addon">
                                        Causa raiz
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlCausa_Raiz" runat="server" CssClass="form-control" AutoPostBack=true>
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>


                               
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                             <div class="input-group">
                                    <div class="input-group-addon">
                                        Segmento
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlSegmento" runat="server" AutoPostBack="True" CssClass="form-control" >
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
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
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Elemento
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlElemento" runat="server" AutoPostBack="True" CssClass="form-control" >
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                               
                            </td>
                            <td class="auto-style1">
                                 &nbsp;
                            </td>
                            <td style="width: 25%">
                               <div class="input-group">
                                    <div class="input-group-addon">
                                        Tipo de falla
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlTipo_De_Falla" runat="server" AutoPostBack="True" CssClass="form-control" >
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
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
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Error en Registro
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel_Variable_Diagnostico_2_drl" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlvariableCatalogo" runat="server" AutoPostBack="True" CssClass="form-control">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                <div class="input-group "  >
                                    <asp:UpdatePanel ID="UpdatePanel_Variable_Diagnostico_3_Lbl" runat="server" >
                                        <ContentTemplate>
                                            <asp:Label Style="background-color: inherit" ID="lblvariable1" runat="server" Font-Size="XX-Small"
                                                CssClass="form-control" ></asp:Label>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
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
                                    <strong>
                                        <center>
                                            CATEGORIA DE CIERRE</center>
                                    </strong>
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
                                            Tipo Soporte
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drltsoporte" runat="server" CssClass="form-control" AutoPostBack=true>
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                                
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Tipo Grupo
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlgrupo" runat="server" AutoPostBack="True" CssClass="form-control" Enabled= false>
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
                                            Tipificación Llamada N3
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                                        <ContentTemplate>
                                                   <asp:DropDownList ID="drltipificacionll" runat="server" CssClass="form-control" AutoPostBack="true">
                                                   </asp:DropDownList>
                                        </ContentTemplate>
                                        </asp:UpdatePanel>

                                        
                                    </div>
                                </div>

                                
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                               <%-- <div class="input-group">
                                    <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                                        <ContentTemplate>
                                            <asp:Label Style="background-color: inherit" ID="LblCategoriaCierre" runat="server"
                                                Font-Size="XX-Small" CssClass="form-control"></asp:Label>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>--%>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Categoria de cierre
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlCategoriaCierre" runat="server"  CssClass="form-control" AutoPostBack="True">
                                                
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </td>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                        </tr>
                        <%--ESCLA CON--%>
                        <tr>
                           <td style="width: 9%">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Se realizo contacto
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel27" runat="server">
                                            <ContentTemplate>
                                                <asp:RadioButtonList ID="Rdb_Contacto" runat="server" CssClass="form-control" Style="list-style-type:upper-alpha;" RepeatDirection="Horizontal" Enabled ="false">
                                                <asp:ListItem Value="SI">SI</asp:ListItem>
                                                <asp:ListItem Value="NO">NO</asp:ListItem>

                                                </asp:RadioButtonList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">                              
                            </td>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                        </tr>
                        <%-------------------%>



                        <%--Programacion--%>
                         <tr>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px;
                                    padding: 0.5px 0px 1px 0px">
                                    <strong>
                                        <center>
                                            SEGUIMIENTO</center>
                                    </strong>
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
                                            Fecha Programacion
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="txtfc_programado" runat="server" CssClass="form-control" placeholder="DD/MM/YYYY H:mm:ss"
                                             MaxLength="20"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Liberar Caso
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel25" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlLibera" runat="server" AutoPostBack="True" CssClass="form-control"
                                                    Enabled="true">
                                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>SI</asp:ListItem>
                                                    <asp:ListItem>NO</asp:ListItem>
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
                        <%--fin programacion--%>

                        <%-----------Nuevo-----%>
                        <tr>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px;
                                    padding: 0.5px 0px 1px 0px">
                                    <strong> <center>
                                            ENCUESTA</center></strong>
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
                                           Inconsistencia atencion *611
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel22" runat="server">
                                            <ContentTemplate> <asp:DropDownList ID="drlinconsistencia" runat="server" AutoPostBack="True" CssClass="form-control" Enabled="true">
                                                </asp:DropDownList>
                                                </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                                
                            </td>
                            <td class="auto-style1">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                             Observacion de inconsistencia
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel23" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="txtobsincon" runat="server" TextMode="MultiLine" AutoPostBack="true" CssClass="form-control" Enabled="false" ></asp:TextBox>       
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                        </tr>
                       <%---Fin---%>
 


                        <tr>
                            <td colspan="5" class="auto-style2">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px;
                                    padding: 0.5px 0px 1px 0px">
                                    <strong>&nbsp;</strong>
                                </div>
                            </td>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5" class="auto-style2">
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
                                            MIN
                                        </div>
                                        <asp:Label Style="background-color: inherit" ID="lblmin" runat="server" CssClass="form-control"
                                            Enable="False"></asp:Label>
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
                                            Caso
                                        </div>
                                        <asp:Label Style="background-color: inherit" ID="lblcaso" runat="server" CssClass="form-control"></asp:Label>
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
                                            Caso Claro
                                        </div>
                                        <asp:Label Style="background-color: inherit" ID="LblCasoClaro" runat="server" CssClass="form-control"></asp:Label>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">
                                &nbsp;
                            </td>
                            <td style="width: 25%">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Call Remite
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="LblCall_Remite" runat="server" CssClass="form-control"></asp:Label>
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
                                            Nombre
                                        </div>
                                        <asp:Label Style="background-color: inherit" ID="lblcliente" runat="server" CssClass="form-control"
                                            Enable="False"></asp:Label>
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
                                            Documento
                                        </div>
                                        <asp:Label Style="background-color: inherit" ID="lbldocumento" runat="server" CssClass="form-control"></asp:Label>
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
                                            Bandeja
                                        </div>
                                        <asp:Label Style="background-color: inherit" ID="lblBandeja" runat="server" CssClass="form-control"
                                            Enable="False"></asp:Label>
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
                                            Plan
                                        </div>
                                        <asp:Label Style="background-color: inherit" ID="lblplan" runat="server" CssClass="form-control"></asp:Label>
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
                                            Departamento Falla
                                        </div>
                                        <asp:Label Style="background-color: inherit; overflow-y: auto" Height="80px" ID="lbllugar"
                                            runat="server" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                </div>
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Numero Alterno
                                        </div>
                                        <asp:Label Style="background-color: inherit; overflow-y: auto"  ID="lblNumero_Alterno"
                                            runat="server" CssClass="form-control" Enable="False"></asp:Label>
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
                                            Observación *611
                                        </div>
                                        <asp:Label Style="background-color: inherit; overflow-y: auto" Height="80px" ID="lblobs611"
                                            runat="server" CssClass="form-control"></asp:Label>
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
                                            Estado Bandeja
                                        </div>
                                        <asp:Label Style="background-color: inherit" ID="lblestado" runat="server" CssClass="form-control"
                                            Enable="False"></asp:Label>
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
                                            Fecha Ingreso
                                        </div>
                                        <asp:Label Style="background-color: inherit" ID="Lblfc_ingreso" runat="server" CssClass="form-control"></asp:Label>
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
                                            Estado Nivel 3
                                        </div>
                                        <asp:Label Style="background-color: inherit" ID="lblestadon3" runat="server" CssClass="form-control"
                                            Enable="False"></asp:Label>
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
                                            Fecha Ingreso Nivel 3
                                        </div>
                                        <asp:Label Style="background-color: inherit" ID="lblfcingn3" runat="server" CssClass="form-control"></asp:Label>
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
                            <td colspan="5">
                                &nbsp;
                            </td>
                        </tr>
                    </table>

                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;
                </td>
                <td class="celdascent">
                <table width="100%">
                <tr>
                            <td style="width: 9%">
                                &nbsp;
                            </td>
                            <td style="width: 55%">
                            <em style="color: #8F9E45">Casos Asignados: &nbsp;<asp:Label ID="lblcasos_asig" 
                                    runat="server"></asp:Label>&nbsp;&nbsp;</em>
                                 <asp:GridView ID="dtgprog" runat="server" AllowPaging="True"
                        CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="5" Width="100%"
                        Style="font-size: x-small" EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                            </td>
                           
                            <td style="width: 9%">
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
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                
                    <asp:LinkButton ID="LinkBtn_Inconsistencia" runat="server" CssClass="linkbutton">Reportar Inconsistencia</asp:LinkButton>
                    <asp:LinkButton ID="LinkBtn_Oculta_Inconsistencia" runat="server" CssClass="linkbutton" Visible="False">Ocultar Inconsistencia</asp:LinkButton>
                    &nbsp;&nbsp;
                    <asp:LinkButton ID="LinkBtn_Falla_Red" runat="server" CssClass="linkbutton">Reportar Falla Red</asp:LinkButton>
                    <asp:LinkButton ID="LinkBtn_Oculta_Falla_Red" runat="server" CssClass="linkbutton" Visible="False">Ocultar Falla Red</asp:LinkButton>
                &nbsp;&nbsp;
                    <asp:LinkButton ID="LinkBtn_Esc_Service" runat="server" CssClass="linkbutton">Escalamiento Service</asp:LinkButton>
                    <asp:LinkButton ID="LinkBtn_Ocultar_Esc_Service" runat="server" CssClass="linkbutton" Visible="False">Ocultar Escalamiento Service</asp:LinkButton>

                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="textotittabla">
                    <asp:Panel ID="pnnuevo2" runat="server" Visible="False">
                              <table cellpadding="1" cellspacing="1" width="100%" class="style1">  
                        <tr>
                              <td style="width: 9%">&nbsp;</td>
                                     <td style="width: 25%">                    
                                <h4><em style="color: #8F9E45">Nuevo Registro Inbound&nbsp;&nbsp;&nbsp;</em><asp:Button ID="Btn_Nuevo_Regist_Inb" runat="server" Text="Guardar" Visible="False"  CssClass="btn btn-primary" /></h4>
                                                </td>
                            <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>                              
                        </tr>                        
                    </table>
               </asp:Panel>
                        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                        <ContentTemplate>                        
                    <span class="alert alert-danger">
                        <asp:Label ID="LblmsgOtros" runat="server" Style="color: #843534"></asp:Label>
                    </span><br/>
                    <asp:Panel ID="pnnuevo" runat="server" Visible="False">        
                    <table cellpadding="1" cellspacing="1" width="100%"
                     class="style1">              
                            <tr>
                                 <td style="width: 9%">&nbsp;</td>
                                 <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Min
                                                <asp:CompareValidator ID="CompareValidato7" runat="server" ControlToValidate="txtminnv" ErrorMessage="El min es numérico sin espacios ni caracteres" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                            </div>                                          
                                                <asp:TextBox ID="txtminnv" runat="server" MaxLength="10"  CssClass="form-control"></asp:TextBox>       
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                 <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Plan
                                            </div>
                                             <asp:TextBox ID="txtplannv" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                  <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>  <td style="width: 9%">&nbsp;</td>
                                 <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Nombre
                                            </div>
                                             <asp:TextBox ID="txtnombrenv" runat="server"  MaxLength="60" CssClass="form-control"></asp:TextBox>
                                       </div>
                                    </div>
                                </td>
                               <td style="width: 5%">&nbsp;</td>      
                                    <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Identificacion
                                                <asp:CompareValidator ID="CompareValidator8" runat="server" ControlToValidate="txtidentifnv" ErrorMessage="La identificación es numérica sin espacios ni caracteres" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                            </div>
                                            <asp:TextBox ID="txtidentifnv" runat="server" CssClass="form-control"></asp:TextBox>
                                       </div>
                                    </div>
                                </td>
                                  <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                  <td style="width: 9%">&nbsp;</td>
                                 <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Ingeniero Remite
                                            </div>
                                            <asp:TextBox ID="TxtIngRemite" runat="server" MaxLength="60" CssClass="form-control"></asp:TextBox>
                                       </div>
                                    </div>
                                </td>
                              <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Caso
                                                <asp:CompareValidator ID="CompareValidator11" runat="server" ControlToValidate="TxtCasoNuevo" ErrorMessage="El caso debe ser numérico" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                            </div>
                                             <asp:TextBox ID="TxtCasoNuevo" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                       </div>
                                    </div>
                                </td>
                              <td style="width: 9%">&nbsp;</td>
                            </tr>
                         <tr>                 
                                    <td style="width: 9%">&nbsp;</td>
                                    <td style="width: 25%">
                                         <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Tipo
                                            </div>
                                           <asp:RadioButtonList ID="rdbtipoinb" runat="server" Font-Size="XX-Small" style="color: #8F9E45" height="70px" CssClass="form-control">
                                            <asp:ListItem>Corporativo</asp:ListItem> 
                                           <asp:ListItem>Fidelización</asp:ListItem>
                                            </asp:RadioButtonList>                                            
                                        </div>
                                    </div> 
                                    </td>
                               <td class="auto-style16">&nbsp;</td>
                                 <td style="width: 25%">                                               
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                        <asp:Panel ID="Pninc" runat="server" Visible="False">
                        <table cellpadding="1" cellspacing="1" width="100%">
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <h4><em style="color: #8F9E45">Registro de Inconsistencia&nbsp;&nbsp;&nbsp;</em>
                                        <asp:Button ID="Btn_Guardar_Inconsistencia" runat="server" Text="Guardar" 
                                            CssClass="btn btn-primary" /></h4>
                                </td>
                                <td class="auto-style1">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Cuenta Financiera
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_registro_numerico"
                                                    ErrorMessage="el numero debe ser positivo" ValidationExpression="^[0-9]*$">*</asp:RegularExpressionValidator>
                                            </div>
                                            <asp:TextBox ID="txt_registro_numerico" runat="server" CssClass="form-control" MaxLength="12"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr> 
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Tipificación
                                            </div>
                                            <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                            <ContentTemplate>
                                            <asp:DropDownList ID="drlinconsglobal" runat="server" AutoPostBack="True" CssClass="form-control">
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                <asp:ListItem>SI</asp:ListItem>
                                                <asp:ListItem>NO</asp:ListItem>
                                                <asp:ListItem>NS/NR</asp:ListItem>
                                            </asp:DropDownList>
                                            </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Tipo Inconsistencia
                                            </div>                                            
                                            <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                            <ContentTemplate>
                                            <asp:DropDownList ID="drlincons" runat="server" CssClass="form-control">
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                <asp:ListItem>SI</asp:ListItem>
                                                <asp:ListItem>NO</asp:ListItem>
                                                <asp:ListItem>NS/NR</asp:ListItem>
                                            </asp:DropDownList>
                                            </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Nivel
                                            </div>
                                            <asp:DropDownList ID="drlnivel" runat="server" CssClass="form-control">
                                                <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                <asp:ListItem>Call</asp:ListItem>
                                                <asp:ListItem>Operacion</asp:ListItem>
                                                <asp:ListItem>Call/Operac</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Observación Inconsistencia
                                            </div>
                                            <asp:TextBox ID="txtobsinc" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                        </table>
                        </asp:Panel>
                        
                        <asp:Panel ID="Pnfallared" runat="server" Visible="False">
                        <table cellpadding="1" cellspacing="1" width="100%">
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <h4><em style="color: #8F9E45">Registro de Falla de Red&nbsp;&nbsp;&nbsp;</em>
                                        <asp:Button ID="Btn_Guardar_Falla_Red" runat="server" Text="Guardar" 
                                            CssClass="btn btn-primary" /></h4>
                                </td>
                                <td class="auto-style1">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Condiciones de Uso
                                            </div>
                                                <asp:DropDownList ID="drlFtectolog" runat="server" CssClass="form-control">
                                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>GSM</asp:ListItem>
                                                    <asp:ListItem>3G</asp:ListItem>
                                                </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Barrio
                                            </div>
                                                <asp:TextBox ID="txtbarrio" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Persona Contacto
                                            </div>
                                            <asp:TextBox ID="txtFcontacto" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Número Contacto
                                            </div>
                                            <asp:TextBox ID="txtFnum" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Tiempo Falla
                                            </div>
                                     <asp:DropDownList ID="drlFtiempo" runat="server" CssClass="form-control">
                                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                        <asp:ListItem Value="&lt;=15">&lt;=15</asp:ListItem>
                                                        <asp:ListItem Value="&gt;15">&gt;15</asp:ListItem>
                                                        </asp:DropDownList>   

                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Tipo Falla
                                            </div>
                                            <asp:TextBox ID="txtFtipofalla" runat="server" CssClass="form-control"></asp:TextBox> 
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Características de la Falla
                                            </div>
                                            <asp:DropDownList ID="drlFcaract" runat="server" CssClass="form-control">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Línea Portada
                                            </div>
                                            <asp:DropDownList ID="drlFportada" runat="server" CssClass="form-control">
                                                <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                    <asp:ListItem>FALSO</asp:ListItem>
                                    <asp:ListItem>VERDADERO</asp:ListItem>

                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr> 
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Nombre Vereda o Corregimiento
                                            </div>
                                            <asp:TextBox ID="txtFciudad" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Tipo Lugar
                                            </div>
                                            <asp:RadioButtonList ID="rdbvc" runat="server" Font-Size="XX-Small" Height="90px" CssClass="form-control">
                                                <asp:ListItem Value="VRD">Vereda</asp:ListItem>
                                                <asp:ListItem Value="CRG">Corregimiento</asp:ListItem>
                                                <asp:ListItem Value="INS">Inspección</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>                            
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Dirección Falla
                                            </div>
                                            <asp:TextBox ID="txtFdirecc" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                               APN
                                            </div>
                                            <asp:TextBox ID="txtapn" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>                             
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                QoS
                                            </div>
                                            <asp:DropDownList ID="Drl_Qos" runat="server" CssClass="form-control">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                </asp:DropDownList>


                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Lineas con falla <br />en la Ubicación Reportada
                                            </div>
                                         <asp:DropDownList ID="drlFlineasfalla" runat="server" CssClass="form-control" Height="45px">
                                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                        <asp:ListItem>SI</asp:ListItem>
                                                        <asp:ListItem>NO</asp:ListItem>
                                                    </asp:DropDownList>

                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr> 
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Observación Cliente
                                            </div>
                                            <asp:TextBox ID="txtfobs" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%"></td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>  
                            <tr>
                                <td style="width: 9%">
                                    &nbsp;
                                </td>
                                <td colspan="3">
                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px;
                                        padding: 0.5px 0px 1px 0px">
                                        <strong>
                                            <center>
                                                Validaciones servicio al cliente</center>
                                        </strong>
                                    </div>
                                </td>
                                <td style="width: 9%">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 9%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            La falla se presenta luego<br />
                                            de que se construyera una <br />
                                            edificación aledaña
                                        </div>
                                        <div style="background-color: inherit; overflow-y: auto; height: 60px" class="form-control">
                                            <asp:DropDownList ID="Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania"
                                                runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            La falla se presenta luego <br />
                                            de que se remodelara la <br />
                                            estructura física del edificio
                                        </div>
                                        <div style="background-color: inherit; overflow-y: auto; height: 60px" class="form-control">
                                            <asp:DropDownList ID="Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio"
                                                runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">
                                    &nbsp;</td>
                                <td style="width: 25%">                                
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Tipo de edificación donde <br />
                                            se presenta la falla
                                        </div>
                                        <asp:DropDownList ID="Drl_Tipo_Edificacion_Donde_Presenta_Falla_1" runat="server" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:DropDownList ID="Drl_Tipo_Edificacion_Donde_Presenta_Falla_2" runat="server" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </td>
                                <td style="width: 5%">
                                    &nbsp;</td>
                                <td style="width: 25%">                                
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Validaciones de falla masiva
                                        </div>
                                        <asp:DropDownList ID="Drl_Validaciones_Falla_Masiva" runat="server" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </td>
                                <td style="width: 9%">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Tecnología en la que se <br />
                                            presenta la falla - <br />
                                            Luego de pruebas
                                        </div>
                                        <div style="background-color: inherit; overflow-y: auto; height: 60px" class="form-control">
                                            <asp:DropDownList ID="Drl_Tecnologia_Presenta_Falla_Luegodepruebas" runat="server"
                                                CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Validación de Coordenadas
                                        </div>
                                        <asp:TextBox ID="Txt_Validacion_Coordenadas" runat="server" MaxLength="20" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </td>
                                <td style="width: 9%">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Línea no cuenta con
                                            <br />
                                            bloqueos de Internet 
                                        </div>
                                        <div style="background-color: inherit; overflow-y: auto; height: 50px" class="form-control">
                                            <asp:DropDownList ID="Drl_Linea_No_Cuenta_Bloqueos_Internet" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Línea no ha superado el
                                            <br />
                                            limite de consumos
                                        </div>
                                        <div style="background-color: inherit; overflow-y: auto; height: 50px" class="form-control">
                                            <asp:DropDownList ID="Drl_Linea_No_Superado_Limite_Consumos" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Línea no se encuentra
                                            <br />
                                            enrutada por pagos
                                        </div>
                                        <div style="background-color: inherit; overflow-y: auto; height: 50px" class="form-control">
                                            <asp:DropDownList ID="Drl_Linea_No_Encuentra_Enrutada_PorPagos" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            HLR / HSS
                                        </div>
                                        <asp:DropDownList ID="Drl_HLR_HSS" runat="server" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </td>
                                <td style="width: 9%">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            No existen cambios
                                            <br />
                                            administrativos sobre la
                                            <br />
                                            línea o cuenta maestra
                                        </div>
                                        <div style="background-color: inherit; overflow-y: auto; height: 60px" class="form-control">
                                            <asp:UpdatePanel ID="UpdatePanel_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra"
                                                runat="server">
                                                <ContentTemplate>
                                                    <asp:DropDownList ID="Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra"
                                                        runat="server" AutoPostBack="True" CssClass="form-control">
                                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                                        <asp:ListItem Value="FALSO"></asp:ListItem>
                                                        <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                                    </asp:DropDownList>
                                                    <br />
                                                    <asp:DropDownList ID="Drl_Split_Billing" runat="server" CssClass="form-control" Visible="False">
                                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    </asp:DropDownList>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Se realizan pruebas de
                                            <br />
                                            SIMCARD en otro dispositivo
                                            <br />
                                            (Persiste Falla)
                                        </div>
                                        <div style="background-color: inherit; overflow-y: auto; height: 60px" class="form-control">
                                            <asp:DropDownList ID="Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla"
                                                runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Se forza la red del dispositivo
                                        </div>
                                        <asp:DropDownList ID="Drl_Forza_Red_Dispositivo" runat="server" 
                                            CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </td>
                                <td style="width: 5%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Se verifica o realiza
                                            <br />
                                            configuración de APN
                                        </div>
                                        <div style="background-color: inherit; overflow-y: auto; height: 50px" class="form-control">
                                            <asp:DropDownList ID="Drl_Verifica_Realiza_Configuración_APN" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Equipo se encuentra
                                            <br />
                                            homologado por el operador
                                        </div>
                                        <div style="background-color: inherit; overflow-y: auto; height: 50px" class="form-control">
                                            <asp:DropDownList ID="Drl_Equipo_Encuentra_Homologado_Operador" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">
                                    &nbsp;</td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Se realiza conciliación
                                            <br />
                                            sobre la línea
                                        </div>
                                        <div style="background-color: inherit; overflow-y: auto; height: 50px" class="form-control">
                                            <asp:DropDownList ID="Drl_Realiza_Conciliacion_Sobre_linea" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">
                                    &nbsp;</td>
                            </tr>

                        </table>
                        </asp:Panel>
                        </ContentTemplate>
                        </asp:UpdatePanel>

                          <asp:Panel ID="Pnl_Esc_Service" runat="server" Visible="false">
                        <table cellpadding="1" cellspacing="1" width="100%">
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <h4>
                                        <em style="color: #8F9E45">Escalamiento Service &nbsp;&nbsp;&nbsp;</em>

                                        <asp:Button ID="Btn_Guardar_Esc_Service" runat="server" Text="Guardar" 
                                        CssClass="btn btn-primary" />

                                    </h4>
                                </td>
                                <td class="auto-style1">&nbsp;</td>
                                <td style="width: 25%">
                              
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr> 
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                               Apn
                                            </div>
                                            <asp:UpdatePanel ID="UpdatePanel24" runat="server">
                                            <ContentTemplate>
                                            <asp:DropDownList ID="drlapn" runat="server" AutoPostBack="True" CssClass="form-control">                                      
                                            </asp:DropDownList>
                                            </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                               Fecha Activacion
                                              
                                           <asp:CompareValidator ID="CompareValidator_fcactivacion" runat="server" ControlToValidate="txtfcactivacion"
                                    ErrorMessage="La fecha de activacion no es válida" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                                 </div>                                            
                                            <%--<asp:UpdatePanel ID="UpdatePanel23" runat="server">
                                            <ContentTemplate>--%>
                                          <asp:TextBox ID="txtfcactivacion" runat="server" placeholder="DD/MM/YYYY" CssClass="form-control" MaxLength="12"></asp:TextBox>
                                           <%-- </ContentTemplate>
                                            </asp:UpdatePanel>--%>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                              QoS
                                            </div>
                                            <asp:DropDownList ID="drlqos" runat="server" CssClass="form-control">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Imagen
                                            </div>
                                                <asp:FileUpload ID="FileDocumento" Width ="100%" Height ="50%"  CssClass="btn btn-primary" runat="server" />
                                    </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                        </table>
                        </asp:Panel>

                    </td>
                </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <h4><em style="color: #8F9E45">Consulta Seguimientos :</em>
                        <asp:Label ID="lblcuenta" runat="server" ForeColor="#8F9E45"></asp:Label></h4>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <div class="bordes">
                        <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small" 
                            EnableModelValidation="True">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <Columns>
                                <asp:BoundField DataField="Id_CRM_Falla_Desactivacion_D_V" HeaderText="ID" />
                                <asp:BoundField DataField="Id_Bandeja_Falla_Desactivacion_D_V" HeaderText="Caso" />
                                <asp:BoundField DataField="Id_Caso" HeaderText="Caso Claro" />
                                <asp:BoundField DataField="Min" HeaderText="Min" />
                                <asp:BoundField DataField="Fc_Reg_Ges" HeaderText="Fecha Registro" />
                                <asp:BoundField DataField="Id_Usuario" HeaderText="Agente" />
                                <asp:BoundField DataField="obs" HeaderText="Observación" />
                                <asp:BoundField DataField="Tipo_Soporte" HeaderText="Tipo Soporte" />
                                <asp:BoundField DataField="Tipificacion" HeaderText="Tipificación" />
                                <asp:BoundField DataField="Falla_Red" HeaderText="Falla de Red" />
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
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">&nbsp;</td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            </table> 
    </div>
    </form>
</body>
</html>
