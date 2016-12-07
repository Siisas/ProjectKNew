<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="regcrm.aspx.vb" Inherits="digitacion.regcrm" %>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
   
    
        .style4
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 5px;
        }
        .style5
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 5px;
        }
       
    
        .style2
        {
            width: 100%;
        }
 
        
        .style1
        {
            width: 100%; height:100%;
        }
 
        .textotittabla
{
	font-family: Arial, Helvetica, sans-serif;
	font-size:small;
	color: #000042;
	font-weight: bold;
	background: #E2E8FA;
	width: 15%;
}
 
        .textotittabla
{
	font-family: Arial, Helvetica, sans-serif;
	font-size:small;
	color: #000042;
	font-weight: bold;
	background: #E2E8FA;
	width: 15%;
}
   
        .celdascons
{
		width: 35%;
}
     
        .celdascons
{
		width: 35%;
}
       
        .style6
        {
            width: 30%;
            height: 22px;
        }
        .style7
        {
            width: 70%;
            height: 22px;
        }
       
        </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <table style="width: 100%; height: 100%">
            <tr>
                <td class="celdasder">
                </td>
                <td class="celdascent">
                    <table style="border-style: outset; border-width: 1px; width:100%">
                        <tr>
                            <td style="width:20%">
                                &nbsp;</td>
                            <td align="left" class="titulo">
                                Kamilion Comunicaciones ERP</td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:Label ID="lblmsg" runat="server" style="color: #FF3300"></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    </td>
                <td class="style5">
                    <uc1:menu ID="menu1" runat="server" />
                </td>
                <td class="style4">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:Label ID="lblmsg0" runat="server" 
                        style="font-size: medium; font-style: italic">Registro CRM N2 - N1</asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td style="width:15%" valign="top">
                    <table class="style2">
                        <tr>
                            <td class="style6">
                                <asp:Label ID="lblusuario" runat="server"></asp:Label>
                            </td>
                            <td class="style7">
                                <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 30%" rowspan="1">
                                <table class="style2" frame="border" 
                                    style="padding: inherit; visibility: visible">
                                    <tr>
                                        <td id="Caso" bgcolor="#CCCCFF">
                                            Caso:</td>
                                        <td>
                                            <asp:TextBox ID="txtcaso" runat="server" Width="138px"></asp:TextBox>
                                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                ControlToValidate="txtcaso" ErrorMessage="El caso debe ser numérico" 
                                                Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            <asp:TextBox ID="txtmin" runat="server" Width="138px" Visible="False"></asp:TextBox>
                                            <asp:CompareValidator ID="CompareValidator2" runat="server" 
                                                ControlToValidate="txtmin" ErrorMessage="El min debe ser numérico" 
                                                Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="width: 70%" rowspan="1">
                                            <asp:Button ID="Button1" runat="server" Text="Buscar" />
                                        </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td class="celdascent">
                    &nbsp;</td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:Panel ID="Pnreg" runat="server">
                        <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                            <tr>
                                <td class="textotittabla">
                                    <asp:Button ID="btnguardar" runat="server" style="height: 26px" 
                                        Text="Guardar" />
                                </td>
                                <td class="celdascons">
                                    Registro de Seguimiento</td>
                                <td class="textotittabla">
                                    &nbsp;</td>
                                <td class="celdascons">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Satisfecha atención *611</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drl611" runat="server" Height="22px" Width="322px">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Tipificación Llamada</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drltipificacionll" runat="server" Height="22px" 
                                        Width="322px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Tipo Grupo</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlgrupo" runat="server" Height="22px" Width="322px" 
                                    AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Tipo Soporte</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drltsoporte" runat="server" Height="22px" Width="322px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Marca</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlmarca" runat="server" Height="22px" 
                                    Width="322px" AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Equipo&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="lblctrl" runat="server">0</asp:Label>
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlequipo" runat="server" Height="22px" 
                                    Width="322px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Numero Alterno</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtnumalt" runat="server" Width="136px" MaxLength="10"></asp:TextBox>
                                    <asp:CompareValidator ID="CompareValidator3" runat="server" 
                                                ControlToValidate="txtnumalt" ErrorMessage="El número alterno debe ser numérico" 
                                                Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                    <asp:Label ID="lblred" runat="server"></asp:Label>
                                </td>
                                <td class="textotittabla">
                                    Observación</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtobs" runat="server" Width="99%" Height="45px" 
                                    TextMode="MultiLine"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Estado Fallatec</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlfallatec" runat="server" Height="22px" Width="129px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>CERRADO</asp:ListItem>
                                        <asp:ListItem>ILOCALIZABLE</asp:ListItem>
                                        <asp:ListItem>ESCALADO</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Es Fallatec</td>
                                <td class="celdascons">
                                    <asp:Label ID="lblfallatec" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    &nbsp;</td>
                                <td class="celdascons">
                                    &nbsp;</td>
                                <td class="textotittabla">
                                    &nbsp;</td>
                                <td class="celdascons">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Servicio Afectado</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlservicio" runat="server" AutoPostBack="True" 
                                        Height="22px" Width="322px">
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Característica de la Falla</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlcaractfalla" runat="server" AutoPostBack="True" 
                                        Height="22px" Width="322px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Percepción de Falla</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlpercep" runat="server" AutoPostBack="True" 
                                        Height="22px" Width="322px">
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Tecnología</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlFtectolog" runat="server" Height="22px" Width="130px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>GSM</asp:ListItem>
                                        <asp:ListItem>3G</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Condición de Cobertura</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlcondic" runat="server" AutoPostBack="True" 
                                        Height="22px" Width="322px">
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Tipo de Cierre</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drltcierre" runat="server" AutoPostBack="True" 
                                        Height="22px" Width="322px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Variables de Diagnóstico</td>
                                <td class="celdascons">
                                    <asp:RadioButtonList ID="rdbron" runat="server" AutoPostBack="True" 
                                        Font-Size="XX-Small">
                                        <asp:ListItem Selected="True">Error en Registro</asp:ListItem>
                                        <asp:ListItem>Ageno a Red Celular</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                                <td class="textotittabla">
                                    &nbsp;</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlvariable" runat="server" AutoPostBack="True" 
                                        Height="22px" Width="322px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Departamento</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drldpto" runat="server" AutoPostBack="True" Height="22px" 
                                        Width="322px">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Municipio</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlmun" runat="server" Height="22px" Width="322px">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Barrio</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtbarrio" runat="server" Width="310px"></asp:TextBox>
                                </td>
                                <td class="textotittabla">
                                    &nbsp;</td>
                                <td class="celdascons">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:LinkButton ID="LinkButton3" runat="server">Reportar Inconsistencia</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton4" runat="server">Ocultar Inconsistencia</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton5" runat="server">Reportar Falla Red</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton6" runat="server">Ocultar Falla Red</asp:LinkButton>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:Panel ID="Pninc" runat="server" Visible="False">
                        <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                            <tr>
                                <td class="textotittabla">
                                    <asp:Button ID="btnguardar0" runat="server" Text="Guardar" Width="68px" />
                                </td>
                                <td class="celdascons">
                                    Registro de Inconsistencia</td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Tipo Inconsistencia</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlincons" runat="server" Height="22px" Width="322px">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Observación Inconsistencia</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtobsinc" runat="server" Height="45px" TextMode="MultiLine" 
                                        Width="99%"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:Panel ID="PNEscalam" runat="server" Visible="False">
                        <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                            <tr>
                                <td class="textotittabla">
                                    <asp:Button ID="btnguardar1" runat="server" style="height: 26px" 
                                        Text="Guardar" />
                                </td>
                                <td>
                                    Registro de Falla de Red</td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Persona Contacto</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtFcontacto" runat="server" Width="278px"></asp:TextBox>
                                </td>
                                <td class="textotittabla">
                                    Número Contacto</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtFnum" runat="server" Width="136px" MaxLength="10"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Tiempo Falla</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlFtiempo" runat="server" Height="22px" Width="130px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem Value="&lt;=30">&lt;=30</asp:ListItem>
                                        <asp:ListItem Value="&gt;30">&gt;30</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Tipo Falla</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtFtipofalla" runat="server" Width="285px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Características de la Falla</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlFcaract" runat="server" Height="22px" Width="302px">
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Línea Portada</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlFportada" runat="server" Height="22px" Width="130px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Nombre Vereda o Corregimiento</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtFciudad" runat="server" Width="279px"></asp:TextBox>
                                </td>
                                <td class="textotittabla">
                                    Tipo Lugar</td>
                                <td class="celdascons">
                                    <asp:RadioButtonList ID="rdbvc" runat="server" Font-Size="XX-Small" 
                                        Width="219px">
                                        <asp:ListItem Value="VRD">Vereda</asp:ListItem>
                                        <asp:ListItem Value="CRG">Corregimiento</asp:ListItem>
                                        <asp:ListItem Value="INS">Inspección</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Dirección Falla</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtFdirecc" runat="server" Width="279px"></asp:TextBox>
                                </td>
                                <td class="textotittabla">
                                    &nbsp;</td>
                                <td class="celdascons">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    APN</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtapn" runat="server" Width="279px"></asp:TextBox>
                                </td>
                                <td class="textotittabla">
                                    QoS</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtqos" runat="server" Width="279px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Lineas con falla en la Ubicación Reportada</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlFlineasfalla" runat="server" Height="22px" 
                                        Width="130px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Observación Cliente</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtfobs" runat="server" Height="45px" TextMode="MultiLine" 
                                        Width="99%"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" />
                </td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                MIN</td>
                            <td class="celdascons">
                                <asp:Label ID="lblmin" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Caso</td>
                            <td class="celdascons">
                                <asp:Label ID="lblcaso" runat="server"></asp:Label>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nombre</td>
                            <td class="celdascons">
                                <asp:Label ID="lblcliente" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Documento</td>
                            <td class="celdascons">
                                <asp:Label ID="lbldocumento" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Equipo</td>
                            <td class="celdascons">
                                <asp:Label ID="lblequipo" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Plan</td>
                            <td class="celdascons">
                                <asp:Label ID="lblplan" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Departamento Falla</td>
                            <td class="celdascons">
                                <asp:Label ID="lbllugar" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Correo Electrónico</td>
                            <td class="celdascons">
                                <asp:Label ID="lblemail" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Estado</td>
                            <td class="celdascons">
                                <asp:Label ID="lblestado" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Observación *611</td>
                            <td class="celdascons">
                                <asp:Label ID="lblobs611" runat="server"></asp:Label>
                            </td>
                        </tr>
                        </table>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:LinkButton ID="lnk1" runat="server">Ver Seguimiento</asp:LinkButton>
&nbsp; 
                    <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton2" runat="server">Ver Casos Asociados</asp:LinkButton>
&nbsp; 
                    <asp:Label ID="lblcuenta1" runat="server"></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                    <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idcrm" HeaderText="ID" />
                            <asp:BoundField DataField="cas_id" HeaderText="Caso" />
                            <asp:BoundField DataField="min_ac" HeaderText="Min" />
                            <asp:BoundField DataField="fcreg" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="idusuario" HeaderText="Agente" />
                            <asp:BoundField DataField="obs" HeaderText="Observación" />
                            <asp:BoundField DataField="tipo_soporte" HeaderText="Tipo Soporte" />
                            <asp:BoundField DataField="tipificacion" HeaderText="Tipificación" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    </asp:GridView>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                    <asp:GridView ID="dtgcoincidentes" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        Visible="False">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="cas_id" HeaderText="Caso" />
                            <asp:BoundField DataField="min_ac" HeaderText="MIN" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    </asp:GridView>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </table>
    
    </form>
</body>
</html>
