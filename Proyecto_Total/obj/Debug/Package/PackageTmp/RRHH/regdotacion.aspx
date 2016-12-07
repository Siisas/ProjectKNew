<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="regdotacion.aspx.vb" Inherits="digitacion.regdotacion" %>

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
   
    
        .style2
        {
            width: 100%;
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
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <uc1:menu ID="menu1" runat="server" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:Label ID="lblmsg0" runat="server" 
                        style="font-size: medium; font-style: italic">Actualización de Dotación</asp:Label>
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
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" Visible="False" />
                </td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Código</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtcod" runat="server" Width="20%"></asp:TextBox>
                            </td>
                            <td class="celdascons">
                                <asp:Button ID="btnvalidar" runat="server" Text="Validar" Width="87px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nombre</td>
                            <td class="celdascons">
                                <asp:Label ID="lblnombre" runat="server"></asp:Label>
                            </td>
                            <td class="celdascons">
                                &nbsp;</td>
                        </tr>
                        </table>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                <asp:Button ID="btnguardar" runat="server" Text="Guardar" />
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
                                Carné</td>
                            <td class="celdascons">
                                <asp:RadioButtonList ID="rdbcarne" runat="server" Width="146px">
                                    <asp:ListItem>Si</asp:ListItem>
                                    <asp:ListItem>No</asp:ListItem>
                                    <asp:ListItem Value="Pr">Provisional</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                            <td class="textotittabla">
                                Chaleco</td>
                            <td class="celdascons">
                                <asp:RadioButtonList ID="rdbchaleco" runat="server" Width="157px">
                                    <asp:ListItem>Si</asp:ListItem>
                                    <asp:ListItem>No</asp:ListItem>
                                    <asp:ListItem Value="NA">No Aplica</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Diadema </td>
                            <td class="celdascons">
                                <asp:RadioButtonList ID="rdbdiadema" runat="server" Width="137px">
                                    <asp:ListItem>Si</asp:ListItem>
                                    <asp:ListItem>No</asp:ListItem>
                                    <asp:ListItem Value="NA">No Aplica</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                            <td class="textotittabla">
                                Locker</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtlocker" runat="server" Width="20%" MaxLength="3"></asp:TextBox>
                            &nbsp;&nbsp;
                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                    ControlToValidate="txtlocker" ErrorMessage="El valor debe ser numérico" 
                                    Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                                <asp:CheckBox ID="chklocker" runat="server" Text="No Aplica" />
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Uniforme</td>
                            <td class="celdascons">
                                <asp:RadioButtonList ID="rdbuniforme" runat="server" Width="148px">
                                    <asp:ListItem>Si</asp:ListItem>
                                    <asp:ListItem>No</asp:ListItem>
                                    <asp:ListItem Value="NA">No Aplica</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                            <td class="textotittabla">
                                &nbsp;</td>
                            <td class="celdascons">
                                &nbsp;</td>
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
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    Detalle Documentall<asp:Label ID="lblcuenta" runat="server"></asp:Label>
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
                            <asp:BoundField DataField="Documento" HeaderText="Documento" />
                            <asp:BoundField DataField="codigo" HeaderText="Código" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombre" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellido" />
                            <asp:BoundField DataField="nombreproyecto" HeaderText="Proyecto" />
                            <asp:BoundField DataField="area" HeaderText="Área" />
                            <asp:BoundField DataField="carne" HeaderText="Carné" />
                            <asp:BoundField DataField="chaleco" HeaderText="Chaleco" />
                            <asp:BoundField DataField="diadema" HeaderText="Diadema" />
                            <asp:BoundField DataField="locker" HeaderText="Locker" />
                            <asp:BoundField DataField="uniforme" HeaderText="Uniforme" />
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
