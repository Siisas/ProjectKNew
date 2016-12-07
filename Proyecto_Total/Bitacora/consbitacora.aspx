<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="consbitacora.aspx.vb" Inherits="digitacion.consbitacora" %>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
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
	font-size: xx-small;
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
            width: 62%; 
height:100%;
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
 
        .style4
        {
            width: 495px;
        }
         
        .celdascons
{
		width: 35%;
}
       
        .celdascons
{
		width: 35%;
}
     
        .style5
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 19px;
        }
        .style6
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-small;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 19px;
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
                        style="font-size: medium; font-style: italic">Consulta Recursos Humanos</asp:Label>
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
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    Datos Personales</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                &nbsp;<table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Usuario</td>
                            <td class="style4">
                                <asp:DropDownList ID="drlusuario" runat="server" Height="22px" Width="322px">
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                Fecha Bitácora</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtfcbitacora" runat="server" Width="52%" Height="22px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Proyecto</td>
                            <td class="style4">
                                <asp:DropDownList ID="drlproyecto" runat="server" Height="22px" Width="322px">
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                Fecha de Registro</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtfcreg" runat="server" Width="52%" Height="22px"></asp:TextBox>
                            </td>
                        </tr>
                        </table>
                            </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td class="celdascent">
                                <asp:Button ID="btnconsultar" runat="server" Text="Consultar" Width="91px" />
                &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnxls" runat="server" Text="Exportar Excel" Width="91px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;
                                &nbsp;&nbsp;
                                </td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="style5">
                    </td>
                <td class="style6">
                                Registros Encontrados:
                                <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                </td>
                <td class="style5">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                    <asp:GridView ID="dtgbitacora" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="68%" 
            style="font-size: x-small">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                           <asp:BoundField DataField="idbitacora" HeaderText="ID" />
                           <asp:BoundField DataField="nombreu" HeaderText="Usuario" />
                            <asp:BoundField DataField="fcbitacora" HeaderText="Fecha Bitácora" />
                            <asp:BoundField DataField="hhinicio" HeaderText="Hora Inicio" />
                            <asp:BoundField DataField="tiempo" HeaderText="Tiempo Empleado" />
                            <asp:BoundField DataField="nombreproyecto" HeaderText="Proyecto" />
                            <asp:BoundField DataField="descripcion" HeaderText="descripcion" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
    
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:GridView ID="dtgxls" runat="server" AutoGenerateColumns="False" 
                        CellPadding="4" ForeColor="#333333" GridLines="None">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                             <asp:BoundField DataField="idbitacora" HeaderText="ID" />
                             <asp:BoundField DataField="nombreu" HeaderText="Usuario" />
                            <asp:BoundField DataField="fcbitacora" HeaderText="Fecha Bitácora" />
                            <asp:BoundField DataField="hhinicio" HeaderText="Hora Inicio" />
                            <asp:BoundField DataField="tiempo" HeaderText="Tiempo Empleado" />
                            <asp:BoundField DataField="nombreproyecto" HeaderText="Proyecto" />
                            <asp:BoundField DataField="descripcion" HeaderText="descripcion" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </table>
    
    </form>
</body>
</html>
