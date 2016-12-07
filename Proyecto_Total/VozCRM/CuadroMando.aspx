<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CuadroMando.aspx.vb" Inherits="digitacion.CuadroMando" %>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
       
                
        .style3
        {
            color: #000099;
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
       
        .style8
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 20%;
            background: #E2E8FA;
        }
               
        .style11
        {
            width: 20%;
        }
        .style14
        {
            width: 10%;
        }
       
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    
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
                        style="font-size: medium; font-style: italic">Cuadro de Mando</asp:Label>
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
                            <td colspan="2">
                            <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                AÑO
                            </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlAño" runat="server">
                                    <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                    <asp:ListItem>2014</asp:ListItem>
                                    <asp:ListItem>2015</asp:ListItem>
                                    <asp:ListItem>2016</asp:ListItem>
                                    <asp:ListItem>2018</asp:ListItem>
                                    <asp:ListItem>2019</asp:ListItem>
                                    <asp:ListItem>2020</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                MES</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlMes" runat="server">
                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                    <asp:ListItem Value="1">Enero</asp:ListItem>
                                    <asp:ListItem Value="2">Febrero</asp:ListItem>
                                    <asp:ListItem Value="3">Marzo</asp:ListItem>
                                    <asp:ListItem Value="4">Abril</asp:ListItem>
                                    <asp:ListItem Value="5">Mayo</asp:ListItem>
                                    <asp:ListItem Value="6">Junio</asp:ListItem>
                                    <asp:ListItem Value="7">Julio</asp:ListItem>
                                    <asp:ListItem Value="8">Agosto</asp:ListItem>
                                    <asp:ListItem Value="9">Septiembre</asp:ListItem>
                                    <asp:ListItem Value="10">Octubre</asp:ListItem>
                                    <asp:ListItem Value="11">Novembre</asp:ListItem>
                                    <asp:ListItem Value="12">Diciembre</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Bandeja</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlBandeja" runat="server">
                                    <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                    <asp:ListItem>VOZ</asp:ListItem>
                                    <asp:ListItem>DATOS</asp:ListItem>
                                    <asp:ListItem>DATOS-VOZ</asp:ListItem>
                                    <asp:ListItem>TOTAL</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                            Ocultar Tablas
                            </td>
                            <td class="celdascons">
                                <asp:CheckBox ID="CheckBoxOcultar" runat="server" />
                            </td>
                        </tr>
                        </table>
                            <asp:Button ID="BtnConsulta" runat="server" Text="Consultar" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%" valign="top">
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%" valign="top" class="celdascent">
                    Mes de consulta: 
                    <asp:Label ID="LblMesConsulta" runat="server"></asp:Label>
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                <asp:Panel ID="PanelVOZ" runat="server" Visible="False">
                                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                                        <tr>
                                            <td class="textotittabla"colspan="2">
                                                <center>VOZ</center>
                                            </td>
                                            <td class="style8">
                                                Menor 24 Horas
                                            </td>
                                            <td class="style8">
                                                Entre 24 y 48 Horas
                                            </td>
                                            <td class="style8">
                                                Mayor a 48 Horas
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Ingreso</td>
                                            <td class="style14">
                                                <asp:Label ID="LblIngreso_VOZ" runat="server"></asp:Label>
                                                </td>
                                            <td class="style11">
                                            <center>Casos</center></td>
                                            <td class="style11">
                                            <center>Casos</center></td>
                                            <td class="style11">
                                            <center>Casos</center></td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Efectividad</td>
                                            <td class="style14">
                                                <asp:Label ID="LblEfectividad_VOZ" runat="server"></asp:Label>
                                                %</td>
                                            <td class="style11">
                                                <center><asp:Label ID="LblEfectividad_VOZ_2" runat="server"></asp:Label></center>
                                            </td>
                                            <td class="style11">
                                                <center><asp:Label ID="LblEfectividad_VOZ_3" runat="server"></asp:Label></center>
                                            </td>
                                            <td class="style11">
                                                <center><asp:Label ID="LblEfectividad_VOZ_4" runat="server"></asp:Label></center>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Contactabilidad</td>
                                            <td class="style14">
                                                <asp:Label ID="LblContactabilidad_VOZ" runat="server"></asp:Label>
                                                %</td>
                                            <td class="style11">
                                            <center>Porcentaje %</center></td>
                                            <td class="style11">
                                            <center>Porcentaje %</center></td>
                                            <td class="style11">
                                            <center>Porcentaje %</center></td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                TMO(min)</td>
                                            <td class="style14">
                                                <asp:Label ID="Lbl_TMO_Min_VOZ" runat="server"></asp:Label>
                                            </td>
                                            <td class="style11">
                                                <center><asp:Label ID="Lbl_TMO_Min_VOZ_2" runat="server"></asp:Label></center>
                                            </td >
                                            <td class="style11">
                                                <center><asp:Label ID="Lbl_TMO_Min_VOZ_3" runat="server"></asp:Label></center>
                                            </td>
                                            <td class="style11">
                                                <center><asp:Label ID="Lbl_TMO_Min_VOZ_4" runat="server"></asp:Label></center>
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
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                <asp:Panel ID="PanelDATOS" runat="server" Visible="False">
                                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                                        <tr>
                                            <td class="textotittabla"colspan="2">
                                                <center>DATOS</center>
                                            </td>
                                            <td class="style8">
                                                Menor 24 Horas
                                            </td>
                                            <td class="style8">
                                                Entre 24 y 48 Horas
                                            </td>
                                            <td class="style8">
                                                Mayor a 48 Horas
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Ingreso</td>
                                            <td class="style14">
                                                <asp:Label ID="LblIngreso_DATOS" runat="server"></asp:Label>
                                                </td>
                                            <td class="style11">
                                            <center>Casos</center></td>
                                            <td class="style11">
                                            <center>Casos</center></td>
                                            <td class="style11">
                                            <center>Casos</center></td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Efectividad</td>
                                            <td class="style14">
                                                <asp:Label ID="LblEfectividad_DATOS" runat="server"></asp:Label>
                                                %</td>
                                            <td class="style11">
                                                <center><asp:Label ID="LblEfectividad_DATOS_2" runat="server"></asp:Label></center>
                                            </td>
                                            <td class="style11">
                                                <center><asp:Label ID="LblEfectividad_DATOS_3" runat="server"></asp:Label></center>
                                            </td>
                                            <td class="style11">
                                                <center><asp:Label ID="LblEfectividad_DATOS_4" runat="server"></asp:Label></center>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Contactabilidad</td>
                                            <td class="style14">
                                                <asp:Label ID="LblContactabilidad_DATOS" runat="server"></asp:Label>
                                                %</td>
                                            <td class="style11">
                                            <center>Porcentaje %</center></td>
                                            <td class="style11">
                                            <center>Porcentaje %</center></td>
                                            <td class="style11">
                                            <center>Porcentaje %</center></td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                TMO(min)</td>
                                            <td class="style14">
                                                <asp:Label ID="Lbl_TMO_Min_DATOS" runat="server"></asp:Label>
                                            </td>
                                            <td class="style11">
                                                <center><asp:Label ID="Lbl_TMO_Min_DATOS_2" runat="server"></asp:Label></center>
                                            </td>
                                            <td class="style11">
                                                <center><asp:Label ID="Lbl_TMO_Min_DATOS_3" runat="server"></asp:Label></center>
                                            </td>
                                            <td class="style11">
                                                <center><asp:Label ID="Lbl_TMO_Min_DATOS_4" runat="server"></asp:Label></center>
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
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                <asp:Panel ID="PanelTOTAL" runat="server" Visible="False">
                                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                                        <tr>
                                            <td class="textotittabla"colspan="2">
                                                <center>VOZ & DATOS</center>
                                            </td>
                                            <td class="style8">
                                                Menor 24 Horas
                                            </td>
                                            <td class="style8">
                                                Entre 24 y 48 Horas
                                            </td>
                                            <td class="style8">
                                                Mayor a 48 Horas
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Ingreso</td>
                                            <td class="style14">
                                                <asp:Label ID="LblIngreso_TOTAL" runat="server"></asp:Label>
                                                </td>
                                            <td class="style11">
                                            <center>Casos</center></td>
                                            <td class="style11">
                                            <center>Casos</center></td>
                                            <td class="style11">
                                            <center>Casos</center></td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Efectividad</td>
                                            <td class="style14">
                                                <asp:Label ID="LblEfectividad_TOTAL" runat="server"></asp:Label>
                                                %</td>
                                            <td class="style11">
                                                <center><asp:Label ID="LblEfectividad_TOTAL_2" runat="server"></asp:Label></center>
                                            </td>
                                            <td class="style11">
                                                <center><asp:Label ID="LblEfectividad_TOTAL_3" runat="server"></asp:Label></center>
                                            </td>
                                            <td class="style11">
                                                <center><asp:Label ID="LblEfectividad_TOTAL_4" runat="server"></asp:Label></center>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Contactabilidad</td>
                                            <td class="style14">
                                                <asp:Label ID="LblContactabilidad_TOTAL" runat="server"></asp:Label>
                                                %</td>
                                            <td class="style11">
                                            <center>Porcentaje %</center></td>
                                            <td class="style11">
                                            <center>Porcentaje %</center></td>
                                            <td class="style11">
                                            <center>Porcentaje %</center></td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                TMO(min)</td>
                                            <td class="style14">
                                                <asp:Label ID="Lbl_TMO_Min_TOTAL" runat="server"></asp:Label>
                                            </td>
                                            <td class="style11">
                                                <center><asp:Label ID="Lbl_TMO_Min_TOTAL_2" runat="server"></asp:Label></center>
                                            </td>
                                            <td class="style11">
                                                <center><asp:Label ID="Lbl_TMO_Min_TOTAL_3" runat="server"></asp:Label></center>
                                            </td>
                                            <td class="style11">
                                                <center><asp:Label ID="Lbl_TMO_Min_TOTAL_4" runat="server"></asp:Label></center>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </table>
    
    </form>
</body>
</html>
