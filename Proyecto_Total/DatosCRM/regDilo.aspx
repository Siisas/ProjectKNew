<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="regDilo.aspx.vb" Inherits="digitacion.regDilo" %>

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
     
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
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
                        style="font-size: medium; font-style: italic">Registro DILO cliente</asp:Label>
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
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                <asp:Button ID="btnguardar" runat="server" Text="Guardar" 
                                    style="height: 26px" />
                            &nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;
                                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Fecha Reporte</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TextBox3" runat="server" Width="105px"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Solicitud</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtobs" runat="server" Width="99%" Height="45px" 
                                    TextMode="MultiLine"></asp:TextBox>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                MIN</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drltipificacionll" runat="server" Height="22px" 
                                    Width="322px">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Tel Contacto</td>
                            <td class="celdascons">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Cliente</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TextBox4" runat="server" Width="316px"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Equipo</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlequipo" runat="server" Height="22px" 
                                    Width="322px">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Departamento</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlmarca" runat="server" Height="22px" 
                                    Width="322px" AutoPostBack="True">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Ciudad</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlmarca0" runat="server" Height="22px" 
                                    Width="322px" AutoPostBack="True">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Barrio</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TextBox2" runat="server" Width="316px"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Dirección</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TextBox1" runat="server" Width="316px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Canal</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlmarca1" runat="server" Height="22px" 
                                    Width="322px" AutoPostBack="True">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Tipo de Falla</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlmarca2" runat="server" Height="22px" 
                                    Width="322px" AutoPostBack="True">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                </asp:DropDownList>
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
                <td class="celdascent">
                    &nbsp;&nbsp;&nbsp;&nbsp;
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
            </table>
    
    </div>
    </form>
</body>
</html>
