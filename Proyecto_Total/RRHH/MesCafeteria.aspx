<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="MesCafeteria.aspx.vb" Inherits="digitacion.MesCafeteria" %>

<%@ Register Src="../menu.ascx" TagPrefix="uc1" TagName="menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Kamilion - ERP</title>


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
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 23px;
        }
        .style9
        {
            color: #000099;
            width: 15%;
            height: 23px;
        }
     
        .style10
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 22px;
        }
        .style11
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 22px;
        }
     
        .auto-style1 {
            width: 10%;
            height: 21px;
        }
             
        .auto-style5 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 9%;
            height: 24px;
            background: #E2E8FA;
        }
        .auto-style6 {
            width: 9%;
            height: 24px;
        }
     
        .auto-style9 {
            width: 18%;
            height: 21px;
        }
        #Text1 {
            width: 47px;
            margin-left: 8px;
            margin-bottom: 0px;
        }
     
        .auto-style13 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 15%;
            background: #E2E8FA;
        }
     
        .auto-style15 {
            color: #000099;
            height: 23px;
        }
     
        .auto-style16 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 13%;
            height: 14px;
        }
        .auto-style17 {
            width: 241px;
            height: 14px;
        }
     
        .auto-style18 {
            width: 152px;
            height: 14px;
        }
     
        .auto-style19 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 18%;
            background: #E2E8FA;
            height: 14px;
        }
     
        .auto-style20 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 15%;
            background: #E2E8FA;
            height: 24px;
        }
        .auto-style21 {
            width: 35%;
            height: 24px;
        }
        .auto-style22 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 15%;
            background: #E2E8FA;
            height: 14px;
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
                <td class="style10">
                    </td>
                <td class="style11">
                    <asp:Label ID="lblmsg0" runat="server" 
                        style="font-size: medium; font-style: italic">Pedidos Cafeteria</asp:Label>
                </td>
                <td class="style10">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td style="width:15%" valign="top">
                    <table class="style2">
                        <tr>
                            <td class="auto-style1">
                                <asp:Label ID="lblusuario" runat="server"></asp:Label>
                            </td>
                            <td class="auto-style9">
                                <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
                            </td>
                        </tr>
                        </table>
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        
                                    <tr>
                                        <td class="auto-style22">Periodo:</td>
                                        <td class="auto-style18">
                                <asp:DropDownList ID="drlperiodo" runat="server" Height="24px" Width="136px" style="margin-left: 3px">
                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                    <asp:ListItem Value="01">Enero</asp:ListItem>
                                    <asp:ListItem Value="02">Febrero</asp:ListItem>
                                    <asp:ListItem Value="03">Marzo</asp:ListItem>
                                    <asp:ListItem Value="04">Abril</asp:ListItem>
                                    <asp:ListItem Value="04">Mayo</asp:ListItem>
                                    <asp:ListItem Value="06">Junio</asp:ListItem>
                                    <asp:ListItem Value="07">Julio</asp:ListItem>
                                    <asp:ListItem Value="08">Agosto</asp:ListItem>
                                    <asp:ListItem Value="09">Septiembre</asp:ListItem>
                                    <asp:ListItem Value="10">Octubre</asp:ListItem>
                                    <asp:ListItem Value="11">Noviembre</asp:ListItem>
                                    <asp:ListItem Value="12">Diciembre</asp:ListItem>
                                </asp:DropDownList>
                            </td>       
                            <td class="auto-style19">Digite Año</td>
                            <td class="auto-style16">
                              <asp:TextBox ID="Año" runat="server" placeholder="AAAA" maxlength="4" Width="41px"></asp:TextBox>
                                <asp:CompareValidator ID="CVAño" runat="server" ErrorMessage="Revise año *" Operator="DataTypeCheck" ControlToValidate="Año" Type="Integer">*</asp:CompareValidator>
                            </td>
                            <td class="auto-style17">
                              <asp:Button ID="Buscar" runat="server" Text="Buscar" />
                            </td>
                            
                        </tr>
                    </table>
                
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td valign="top" class="style3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
                    <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td valign="top" class="style3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style15">Información del Empleado</td>
                <td class="style8"></td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="auto-style13">
                                Documento</td>
                            <td class="celdascons">                                
                                <asp:Label ID="Lbldoc" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Código</td>
                            <td class="celdascons">                                
                                <asp:Label ID="lblcod" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style20">
                                Nombre</td>
                            <td class="auto-style21">                                
                                <asp:Label ID="lblnombre" runat="server"></asp:Label>
                            </td>
                            <td class="auto-style20">
                                Cargo</td>
                            <td class="auto-style21">                                
                                <asp:Label ID="lblcargo" runat="server"></asp:Label>
                            </td>
                        </tr>
                        </table>
                                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #003300;" 
                    valign="top" class="style9">
                </td>
                <td class="style8">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                            Productos Adquiridos</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    
                    
                                <asp:GridView ID="dtgConsultas" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" Width="100%" style="font-size: x-small" EnableModelValidation="True" PageSize="80">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Id_Usuario" HeaderText="Realiza Venta" />
                            <asp:BoundField DataField="Fecha_Venta" HeaderText="Fecha Compra" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre Producto" />
                            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                            <asp:BoundField DataField="Valor_Unitario" HeaderText="Valor Producto" />
                            <asp:BoundField DataField="Sub_Total" HeaderText="SubTotal" />
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    &nbsp;</td>
                <td class="celdasder">
                                &nbsp;</td>
                <td class="celdascons" align="right">
                                &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    align="center" valing="top" class="auto-style5">
                    Total Pago</td>
                            <td class="auto-style6" align="center" colspan="2" rowspan="2">
                                <asp:Label ID="LblVtotal" runat="server"></asp:Label>
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
                    <table bgcolor="" class="style1">
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </table>
    <div>
                        
                    </div>
    </form>
</body>
</html>
