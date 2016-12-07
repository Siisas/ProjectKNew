<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RetroCalidad.aspx.vb" Inherits="digitacion.RetroCalidad" %>


<%@ Register Src="../menu.ascx" TagName="menu" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ERP - Kamilion</title>
    
  <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <script type="text/jscript">
      $(function () {
          $('#txtfc_inicial').datepicker({ dateFormat: 'dd/mm/yy' }).val();
          $('#txtfc_final').datepicker({ dateFormat: 'dd/mm/yy' }).val();
      });
  </script>
  <!-- Fin Script jQuery Datepicker --->
    <style type="text/css">
        
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

.titulo
{ 
 font-family:Arial, Helvetica, sans-serif;
   font-size:xx-large;
   color:navy
   }
   
    
       
  .style2
        {
            width: 100%;
            border-color:Black;
            border-style:solid;
            border-width: 2px;
            
        }
        
        .textotittabla
{
	font-family: Arial, Helvetica, sans-serif;
	font-size:small;
	color: #000042;
	font-weight: bold;
	background: #E2E8FA;
	width: 15%;
            text-align: center;
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
        

        .auto-style1 {
            width: 35%;
            height: 22px;
        }
        

        .auto-style2 {
            width: 35%;
            height: 35px;
        }
        

        </style>
</head>
<body>
   
       <form id="form1" runat="server" class="tamanio">
       <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>

               <table style="width: 100%; height: 100%">
            <asp:Panel ID="Panelkam" runat="server">
                <tr>
                    <td class="celdasder"></td>
                    <td class="style4">
                        <table style="border-style: outset; border-width: 1px; width: 100%">
                            <tr>
                                <td style="width: 20%">&nbsp;</td>
                                <td align="left" class="titulo">Kamilion Comunicaciones ERP</td>
                            </tr>
                        </table>
                    </td>
                    <td class="celdasder"></td>
                </tr>
                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="style4">
                        <asp:Label ID="lblmsg" runat="server" Style="color: #FF3300"></asp:Label>
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="style4">
                        <uc1:menu ID="menu1" runat="server" />
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="style4">
                        <asp:Label ID="lblmsg0" runat="server"
                            Style="font-size: medium; font-style: italic">Retroalimentacion Calidad</asp:Label>
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <tr>
                    <td class="celdasder"></td>
                    <td valign="top" class="style5">
                        <table style="width: 100%">
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
                    <td class="celdasder"></td>
                </tr>
            </asp:Panel>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;"
                    valign="top" class="style3">&nbsp;</td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="style4">
                    <table style="width: 100%; height: 100%">
                        <tr>
                            <td class="celdascons">
                                <table class="style2" style="width: 100%; height: 100%">
                                    <tr>
                                        <td class="celdascons">
                                            <center>
                                                <asp:Image ID="Image1" runat="server" Height="87px" ImageUrl="~/LOGO.jpg" BorderStyle="Dashed" /></center>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td class="celdascons">
                                <table border="1" style="width: 100%; height: 100%" class="style2">
                                    <tr>
                                        <td class="celdascons" style="color: #000000">
                                            <center style="color: #000000; font-size: small;">SISTEMA DE GESTION DE CALIDAD</center>
                                        </td>
                                        <td class="auto-style79" colspan="2">
                                            <center style="color: #000000; font-size: small;">GCM-F-18</center>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="celdascons" style="color: #000000">
                                            <center style="color: #000000; font-size: small;">GESTION DE CALIDAD Y MEJORA</center>
                                        </td>
                                        <td class="celdascons" style="color: #000000">
                                            <center style="color: #000000; font-size: small;">FECHA<br />
                                                26-05-2014<asp:Label ID="Lblfechareg" runat="server" ForeColor="Black"
                                                    Font-Size="Small" Visible="False"></asp:Label></center>
                                        </td>
                                        <td class="celdascons" style="color: #000000">
                                            <center style="color: #000000; font-size: small;">VERSION<br />
                                                <asp:Label ID="Lbl_Version" runat="server" Text="1.1"></asp:Label>
                                            </center>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="celdascons" style="color: #000000">
                                            <center style="color: #000000; font-size: small;">FORMATO DE RETROALIMENTACION</center>
                                        </td>
                                        <td class="auto-style66" rowspan="2" colspan="2">
                                           <center style="color: #000000; font-size: small;">Página 1 de 1</center> </td>
                                        
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="style4">
                    <table border="3" style="width: 100%; height: 100%" class="style2" frame="border">
                        <tr>
                            <td colspan="6">
                                <center style="color: #000000">INFORMACION GENERAL</center>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2" style="color: #000000; font-size: small;" colspan="3">ID Auditoria
                                     <asp:TextBox ID="txtidaud" runat="server"></asp:TextBox>
                                &nbsp;
                                     <asp:Button ID="btnidaud" runat="server" Text="Buscar" />
                                &nbsp;<asp:Label ID="lblidaud" runat="server"></asp:Label>
                                <asp:Label ID="Lbl_Version_Retro" text="Version"  runat="server"></asp:Label>
                                <asp:DropDownList ID="Drl_Version" runat="server" AutoPostBack="True">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style2" style="color: #000000; font-size: small;" colspan="3">
                                Codigo de Retroalimentación :
                                                <asp:Label ID="Lblcodretro" runat="server"
                                                    Font-Size="Small"></asp:Label>
                            </td>

                        </tr>
                        <tr>
                            <td class="celdascons" style="color: #000000; font-size: small;" colspan="3">Fecha de Retroalimentacion
                            </td>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="Lblfcretro" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                            </td>

                        </tr>
                        <tr>
                            <td class="celdascons" style="color: #000000; font-size: small;" colspan="3">Fecha de Auditoria (s)</td>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="Lblfcaud" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                            </td>

                        </tr>
                        <tr>
                            <td class="auto-style1" style="color: #000000; font-size: small;" colspan="3">Nombre del Ingeniero / Agente de soporte</td>
                            <td class="auto-style1" colspan="3">
                                <asp:Label ID="LblNomAgte" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                            </td>

                        </tr>
                        <tr>
                            <td class="celdascons" style="color: #000000; font-size: small;" colspan="3">Grupo</td>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblGrupo" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                            </td>

                        </tr>
                        <tr>
                            <td class="celdascons" style="color: #000000; font-size: small;" colspan="3">Auditor</td>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblNomaud" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                            </td>

                        </tr>
                        <tr>
                            <td class="auto-style1" style="color: #000000; font-size: small;" colspan="3">Campaña</td>
                            <td class="auto-style1" colspan="3">
                                <asp:Label ID="LblCampa" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                            </td>

                        </tr>

                        <tr>
                            <td class="celdascons" style="color: #000000; font-size: small;" colspan="3">Area o Nivel de Gestion</td>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblArea" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>

                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" style="color: #000000; font-size: small;" colspan="3">Fecha y Hora de la llamada</td>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblFc_Hora_llam" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" style="color: #000000; font-size: small;" colspan="3">Numero de caso - MIN</td>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblCaso" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" style="color: #000000; font-size: small;" colspan="3">Estado Caso</td>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblEstado_Caso" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" style="color: #000000; font-size: small;" colspan="3">Calificacion</td>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblCalificacion" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                            </td>
                        </tr>

                        <tr>
                            <td class="celdascons" style="color: #000000; font-size: small;" colspan="3">Seguimiento o historico auditoria</td>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblSeguimiento" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                <asp:TextBox ID="TxtSgto" runat="server" MaxLength="2" Width="27px"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="TxtSgto" ErrorMessage="Verifique el numero de seguimiento" Type="Integer" Operator="DataTypeCheck">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" style="color: #000000; font-size: small;" colspan="3">Tipo de Retroalimentación</td>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblTipoRetro" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" style="color: #000000; font-size: small;" colspan="3">Tiempo de Retroalimentación</td>
                            <td class="celdascons" colspan="3">
                                <asp:Panel ID="Pntiemporetroalimentacion" runat="server">
                                    <asp:TextBox ID="TxtHora" runat="server" MaxLength="2" placeholder="HH" Width="24px"></asp:TextBox>
                                    <asp:CompareValidator ID="CompareValidator1" runat="server"
                                        ControlToValidate="TxtHora" ErrorMessage="La hora debe ser numérica"
                                        Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                    :<asp:TextBox ID="TxtMinuto" runat="server" MaxLength="2" placeholder="MM" Width="24px"></asp:TextBox>
                                    <asp:CompareValidator ID="CompareValidator2" runat="server"
                                        ControlToValidate="TxtMinuto" ErrorMessage="Los minutos deben ser numéricos"
                                        Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                    :<asp:TextBox ID="TxtSegundo" runat="server" MaxLength="2" placeholder="SS" Width="24px"></asp:TextBox>
                                    <asp:CompareValidator ID="CompareValidator4" runat="server"
                                        ControlToValidate="TxtSegundo" ErrorMessage="Los segundos deben ser numéricos"
                                        Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                </asp:Panel>
                                <asp:Label ID="Lbltiemporetroalimentacion" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6" class="celdascons">
                                <center style="color: #000000">CAUSAS DE RETROALIMENTACION</center>
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" colspan="3">
                                <center style="color: #000000">Parametro</center>
                            </td>
                            <td class="celdascons" colspan="3">
                                <center style="color: #000000">Observacion</center>
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblParametro" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                <center>
                                    <asp:DropDownList ID="drlParametro" runat="server" Width="200px">
                                    </asp:DropDownList>
                                </center>
                            </td>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblObservacion" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                <center>
                                    <asp:TextBox ID="txtObservacion" runat="server" Width="90%" Height="100%" TextMode="MultiLine" Style="margin-left: 0px"></asp:TextBox></center>
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblParametro0" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                <center>
                                    <asp:DropDownList ID="drlParametro0" runat="server" Width="200px">
                                    </asp:DropDownList>
                                </center>
                            </td>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblObservacion0" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                <center>
                                    <asp:TextBox ID="txtObservacion0" runat="server" Width="90%" Height="100%" TextMode="MultiLine" Style="margin-left: 0px"></asp:TextBox></center>
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblParametro1" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                <center>
                                    <asp:DropDownList ID="drlParametro1" runat="server" Width="200px">
                                    </asp:DropDownList>
                                </center>
                            </td>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblObservacion1" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                <center>
                                    <asp:TextBox ID="txtObservacion1" runat="server" Width="90%" Height="100%" TextMode="MultiLine" Style="margin-left: 0px"></asp:TextBox></center>
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblParametro2" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                <center>
                                    <asp:DropDownList ID="drlParametro2" runat="server" Width="200px">
                                    </asp:DropDownList>
                                </center>
                            </td>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblObservacion2" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                <center>
                                    <asp:TextBox ID="txtObservacion2" runat="server" Width="90%" Height="100%" TextMode="MultiLine" Style="margin-left: 0px"></asp:TextBox></center>
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblParametro3" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                <center>
                                    <asp:DropDownList ID="drlParametro3" runat="server" Width="200px">
                                    </asp:DropDownList>
                                </center>
                            </td>
                            <td class="celdascons" colspan="3">
                                <asp:Label ID="LblObservacion3" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                <center>
                                    <asp:TextBox ID="txtObservacion3" runat="server" Width="90%" Height="100%" TextMode="MultiLine" Style="margin-left: 0px"></asp:TextBox></center>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6" class="celdascons">
                                <center style="color: #000000;">Observacion de la persona que realiza la Retroalimentacion</center>
                                &nbsp;
                                <asp:Label ID="LblObservacionP" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                <center>
                                    <asp:TextBox ID="txtObservacionP" runat="server" Height="40%" TextMode="MultiLine" Width="80%" Style="margin-left: 0px"></asp:TextBox></center>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6" class="celdascons">
                                <center style="color: #000000;">Compromiso del Agente/Ingeniero</center>
                                &nbsp;
                                <asp:Label ID="LblCompromiso" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                <center>
                                    <asp:TextBox ID="txtCompromiso" runat="server" Height="40%" TextMode="MultiLine" Width="80%"></asp:TextBox></center>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6" class="celdascons">
                                <center style="color: #000000;">Conclusion final y/o Plan de Accion a ejecutar</center>
                                &nbsp;
                                <asp:Label ID="LblConclusionF" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                <center>
                                    <asp:TextBox ID="txtConclucionF" runat="server" Height="40%" TextMode="MultiLine" Width="80%"></asp:TextBox></center>
                            </td>
                        </tr>
                        <asp:Panel ID="Pnl_eficacia_Reg" Visible="false" runat="server">                      
                        <tr>
                            <td class="celdascons" style="color: #000000; padding-left:20px;" colspan="3">1. Presta atención a la información suministrada
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                <asp:RadioButtonList ID="RadioBtn1" AutoPostBack="true" runat="server">
                                    <asp:ListItem Value="10" Text="Excelente" />
                                    <asp:ListItem Value="3" Text="Regular" />
                                    <asp:ListItem Value="1" Text="Insuficiente" />
                                </asp:RadioButtonList>
                                </ContentTemplate>
                                </asp:UpdatePanel>  
                            </td>

                            <td class="celdascons" style="color: #000000; padding-left:20px;" colspan="3">2. Entiende claramente los parámetros a mejorar
                                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <asp:RadioButtonList ID="RadioBtn2" AutoPostBack="true" runat="server">
                                    <asp:ListItem Value="10" Text="Excelente" />
                                    <asp:ListItem Value="3" Text="Regular" />
                                    <asp:ListItem Value="1" Text="Insuficiente" />
                                </asp:RadioButtonList>
                                </ContentTemplate>
                                </asp:UpdatePanel>  
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" style="color: #000000; padding-left:20px;" colspan="3">3. El compromiso es coherente con las observaciones realizada
                                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                <ContentTemplate>
                                <asp:RadioButtonList ID="RadioBtn3" AutoPostBack="true" runat="server">
                                    <asp:ListItem Value="10" Text="Excelente" />
                                    <asp:ListItem Value="3" Text="Regular" />
                                    <asp:ListItem Value="1" Text="Insuficiente" />
                                </asp:RadioButtonList>
                                </ContentTemplate>
                                </asp:UpdatePanel>  
                            </td>
                            <td class="celdascons" style="color: #000000; padding-left:20px;"  colspan="3">4. Es receptivo al cambio y la mejora continua
                                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                <ContentTemplate>
                                <asp:RadioButtonList ID="RadioBtn4" AutoPostBack="true" runat="server">
                                    <asp:ListItem Value="10" Text="Excelente" />
                                    <asp:ListItem Value="3" Text="Regular" />
                                    <asp:ListItem Value="1" Text="Insuficiente" />
                                </asp:RadioButtonList>
                                </ContentTemplate>
                                </asp:UpdatePanel>  
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" style="color: #000000; padding-left:20px;" colspan="3">5. Ingeniero escucha grabacion
                                <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                <ContentTemplate>
                                <asp:RadioButtonList ID="RadioBtn5" AutoPostBack="true" runat="server">
                                    <asp:ListItem Value="10" Text="SI" />
                                    <asp:ListItem Value="3" Text="NO" />
                                </asp:RadioButtonList>
                                </ContentTemplate>
                                </asp:UpdatePanel>  
                            </td>
                            <td class="celdascons" style="color: #000000;" colspan="3">
                                <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                <ContentTemplate>
                                    Resultado
                                <asp:TextBox ID="txtresultado" Enabled="false" runat="server"></asp:TextBox>
                                </ContentTemplate>
                                </asp:UpdatePanel>  
                            </td>
                        </tr>
                           <%--****************PANEL DE CONSULTA*********************--%>
                        </asp:Panel>
                        <asp:Panel ID="Pnl_eficacia_con" Visible="false" runat="server">
                            <tr>
                            <td class="celdascons" style="color: #000000; padding-left:20px;" colspan="3">1. Presta atención a la información suministrada:<br />
                                <asp:Label ID="lblitem1" runat="server" />
                            </td>

                            <td class="celdascons" style="color: #000000; padding-left:20px;" colspan="3">2. Entiende claramente los parámetros a mejorar:<br />
                                <asp:Label ID="lblitem2" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" style="color: #000000; padding-left:20px;" colspan="3">3. El compromiso es coherente con las observaciones realizada:<br />
                                <asp:Label ID="lblitem3" runat="server" /> 
                            </td>
                            <td class="celdascons" style="color: #000000; padding-left:20px;"  colspan="3">4. Es receptivo al cambio y la mejora continua:<br />
                                <asp:Label ID="lblitem4" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" style="color: #000000; padding-left:20px;" colspan="3">5. Ingeniero escucha grabacion:<br />
                                <asp:Label ID="lblitem5" runat="server" />
                            </td>
                            <td class="celdascons" style="color: #000000;" colspan="3">Resultado:&nbsp;
                                <asp:Label ID="lblresultado" runat="server" />
                            </td>
                        </tr>
                        </asp:Panel>    


                        <tr>
                            <td class="celdascons">
                               <center style="color: #000000; font-size: small;">FIRMA DEL AGENTE/INGENIERO</center></td>
                            <td colspan="4" class="celdascons">
                                <center style="color: #000000; font-size: small;">FIRMA AUDITOR</center></td>
                            <td class="celdascons">
                                <center style="color: #000000; font-size: small;">FIRMA SUPERVISOR</center></td>
                        </tr>
                        <tr>
                            <td class="celdascons">
                                <br />
                                <br />
                            </td>
                            <td colspan="4" class="celdascons">
                                &nbsp;</td>
                            <td class="celdascons">
                                &nbsp;</td>
                        </tr>
                        
                        <tr>
                            <td colspan="6">
                                <asp:Panel ID="Plcons" runat="server" Style="width: 100%; height: 100%">
                                    <table border="3" style="width: 100%; height: 100%">

                                        <tr>

                                            <td class="celdascons" colspan="2">

                                                <center style="color: #000000;">
                                                    CONSULTAS</center>
                                            </td>

                                        </tr>
                                        <tr>
                                            <td class="textotittabla" style="color: #000000;">Codigo Retroalimentacion</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtcodbus" runat="server" Width="30%"></asp:TextBox>
                                                &nbsp;
                                <asp:Button ID="BtnConsultar" runat="server" Style="height: 26px" Text="Consultar" />
                                                <asp:Label ID="lblFc_Reg_Actualiza" runat="server" Font-Size="Small" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                    <br />
                                    &nbsp;
                        <asp:Button ID="btnguardar" runat="server" Style="height: 26px" Text="Guardar" Visible="true" />
                                    &nbsp;
                        <asp:Button ID="btnimprimir" runat="server" OnClientClick="javascript:window.print" Style="height: 26px" Text="Imprimir" />
                                    &nbsp;
                        <asp:Button ID="BtnNuevo" runat="server" Text="Nuevo" Width="68px" />
                                    &nbsp;
                        <asp:Button ID="btnactualizar" runat="server" Text="Actualizar" />
                                </asp:Panel>
                            </td>

                        </tr>
                    </table>
                   </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="style4">
                    
                   
                    <asp:Panel ID="PanelIMP" runat="server" Visible="False">
                        <a id="letrapeque" onclick="document.getElementById('letrapeque').style.display = 'none'; document.getElementById('Image1').style.height = '40px';  $('.celdasder').css('width', '1%'); $('center, td, span').css('font-size', '80%');">Presione antes de imprimir</a>
                    </asp:Panel>
                </td>

                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="style4">
                    
                   
                    <asp:Panel ID="PanelVerificacion" runat="server">
                        <table border="3" style="color: #000000;" width="100%">
                            <tr>
                                <td colspan="2" style="text-align: center;">Verificacion Retroalimentaciones</td>
                            </tr>
                            <tr>
                                <td>Codigo Agente:
                                    <asp:TextBox ID="txtcodagente" runat="server"></asp:TextBox>
                                </td>
                                <td>Grupo:
                                    <asp:DropDownList ID="drlGrupos" runat="server" Height="17px" Width="162px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                
                                <td>Fecha Inicial:&nbsp;&nbsp;
                                    <asp:TextBox ID="txtfc_inicial" runat="server" placeholder="DD/MM/YYYY"></asp:TextBox>
                                </td>
                                <td>Fecha Final:&nbsp;&nbsp;
                                    <asp:TextBox ID="txtfc_final" runat="server" placeholder="DD/MM/YYYY"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btnVerificar" runat="server" Text="Consultar" />
                                    &nbsp;
                                    <asp:Button ID="btnxls" runat="server" Text="Exportar" />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" >Registros Encontrados 
                                    <asp:Label ID="LblCantidad" runat="server" Text="0"></asp:Label>
                                    <asp:GridView ID="dtgConsultas" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" PageSize="100" style="font-size: x-small; text-align: center;" Width="100%">
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <Columns>
                                            <asp:BoundField DataField="ID" HeaderText="ID" />
                                            <asp:BoundField DataField="Grupo" HeaderText="Grupo" />
                                            <asp:BoundField DataField="Codigo" HeaderText="Código" />
                                            <asp:BoundField DataField="Agente" HeaderText="Agente" />
                                            <asp:BoundField DataField="Tipo_Retro" HeaderText="Tipo Retroalimentacion" />
                                            <asp:BoundField DataField="REF_AUD" HeaderText="Ref. Auditoria" />
                                            <asp:BoundField DataField="FECHA" HeaderText="Fecha Retroalimentacion" />
                                            <asp:BoundField DataField="Version_Retro" HeaderText="Version Retro" />
                                        </Columns>
                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <EditRowStyle BackColor="#999999" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                    </asp:GridView>
                                    <asp:GridView ID="dtgxls" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" PageSize="2000" style="font-size: x-small; text-align: center;" Visible="False" Width="100%">
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <Columns>
                                            <asp:BoundField DataField="ID" HeaderText="ID" />
                                            <asp:BoundField DataField="Grupo" HeaderText="Grupo" />
                                            <asp:BoundField DataField="Codigo" HeaderText="Código" />
                                            <asp:BoundField DataField="Agente" HeaderText="Agente" />
                                            <asp:BoundField DataField="Tipo_Retro" HeaderText="Tipo Retroalimentacion" />
                                            <asp:BoundField DataField="REF_AUD" HeaderText="Ref. Auditoria" />
                                            <asp:BoundField DataField="FECHA" HeaderText="Fecha Retroalimentacion" />
                                            <asp:BoundField DataField="Version_Retro" HeaderText="Version Retro" />
                                        </Columns>
                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <EditRowStyle BackColor="#999999" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                    </asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>

                <td class="celdasder">&nbsp;</td>
            </tr>
        </table>
    </form>
 
</body>
</html>
