<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="consaudit.aspx.vb" Inherits="digitacion.consaudit" %>

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
                        style="font-size: medium; font-style: italic">Consulta Auditoría de Calidad</asp:Label>
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
                                            <asp:Button ID="Button1" runat="server" Text="Buscar" style="height: 26px" />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="btnxls" runat="server" Text="Exportar Excel" Width="91px" />
                            </td>
                            <td style="width: 70%" rowspan="1">
                                            &nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" />
                </td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                <asp:Panel ID="Panel2" runat="server">
                                    <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                                        <tr>
                                            <td class="textotittabla">
                                                Agente</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlagente" runat="server" AutoPostBack="True" 
                                                    Height="22px" Width="322px">
                                                </asp:DropDownList>
                                            </td>
                                            <td class="textotittabla">
                                                Consecutivo</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Tipo</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drltipo" runat="server" Height="21px" Width="133px">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>Protocolo</asp:ListItem>
                                                    <asp:ListItem>Conocimiento</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td class="textotittabla">
                                                Nivel</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlnivel" runat="server" AutoPostBack="True" 
                                                    Height="21px" Width="133px">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>Nivel1</asp:ListItem>
                                                    <asp:ListItem>Nivel3</asp:ListItem>
                                                    <asp:ListItem>Voz</asp:ListItem>
                                                    <asp:ListItem>Datos</asp:ListItem>
                                                    <asp:ListItem>DatosN3</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Fecha llamada Inicial</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtfcinill" runat="server"></asp:TextBox>
                                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                    ControlToValidate="txtfcinill" ErrorMessage="Fecha no válida" 
                                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                            </td>
                                            <td class="textotittabla">
                                                Fecha Llamada final</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtfcfinll" runat="server"></asp:TextBox>
                                                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                                                    ControlToValidate="txtfcfinll" ErrorMessage="Fecha no válida" 
                                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Fecha Auditoría Inicial</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtfcini" runat="server"></asp:TextBox>
                                                <asp:CompareValidator ID="CompareValidator3" runat="server" 
                                                    ControlToValidate="txtfcini" ErrorMessage="Fecha no válida" 
                                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                            </td>
                                            <td class="textotittabla">
                                                Fecha Auditoría&nbsp; Final</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtfcfin" runat="server"></asp:TextBox>
                                                <asp:CompareValidator ID="CompareValidator4" runat="server" 
                                                    ControlToValidate="txtfcfin" ErrorMessage="Fecha no válida" 
                                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
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
    
                    Auditorías Realizadas&nbsp;&nbsp;&nbsp; 
                    &nbsp; 
                    <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                &nbsp;
                    <asp:Panel ID="Panel3" runat="server" Visible="False">
                        Nota final por agente en el periodo filtrado:
                        <asp:Label ID="lblnota" runat="server"></asp:Label>
                    </asp:Panel>
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
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idaudit" HeaderText="ID" />
                            <asp:BoundField DataField="codagente" HeaderText="Código" />
                            <asp:BoundField DataField="grupo" HeaderText="Grupo" />
                            <asp:BoundField DataField="nombreu" HeaderText="Agente" />
                            <asp:BoundField DataField="tipo" HeaderText="Tipo" />
                            <asp:BoundField DataField="nivel" HeaderText="Nivel" />
                            <asp:BoundField DataField="caso" HeaderText="Caso" />
                            <asp:BoundField DataField="fcllamada" HeaderText="Fecha Llamada" />
                            <asp:BoundField DataField="tiempoacum" HeaderText="Tiempo Acumulado" />
                            <asp:BoundField DataField="llamadas" HeaderText="Llamadas" />
                            <asp:BoundField DataField="fcauditoria" HeaderText="Fecha Auditoría" />
                            <asp:BoundField DataField="idusuarioaudita" HeaderText="Auditor" />
                            <asp:BoundField DataField="nota" HeaderText="nota" />
                            <asp:BoundField DataField="pondera" HeaderText="Ponderación" />
                            <asp:BoundField DataField="obs" HeaderText="Observación" />
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
    
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                    Detalle de Auditoría&nbsp;&nbsp;&nbsp; 
                    &nbsp; 
                    <asp:Label ID="lblcuentaaud" runat="server"></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                    <asp:GridView ID="dtgdetalle" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idaudit" HeaderText="ID" />
                            <asp:BoundField DataField="tipo" HeaderText="Tipo" />
                            <asp:BoundField DataField="nivel" HeaderText="Nivel" />
                            <asp:BoundField DataField="iditem" HeaderText="Id Item" />
                            <asp:BoundField DataField="item" HeaderText="Item" />
                            <asp:BoundField DataField="partic" HeaderText="Ponderación" />
                            <asp:BoundField DataField="nota" HeaderText="Nota" />
                            <asp:BoundField DataField="obs" HeaderText="Obervación" />
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
    
                    <asp:GridView ID="dtgxls" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="4000" Width="100%" style="font-size: x-small" 
                        Visible="False">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                             <asp:BoundField DataField="idaudit" HeaderText="ID" />
                            <asp:BoundField DataField="codagente" HeaderText="Código" />
                            <asp:BoundField DataField="grupo" HeaderText="Grupo" />
                            <asp:BoundField DataField="nombreu" HeaderText="Agente" />
                            <asp:BoundField DataField="tipo" HeaderText="Tipo" />
                            <asp:BoundField DataField="nivel" HeaderText="Nivel" />
                            <asp:BoundField DataField="caso" HeaderText="Caso" />
                            <asp:BoundField DataField="fcllamada" HeaderText="Fecha Llamada" />
                            <asp:BoundField DataField="tiempoacum" HeaderText="Tiempo Acumulado" />
                            <asp:BoundField DataField="llamadas" HeaderText="Llamadas" />
                            <asp:BoundField DataField="fcauditoria" HeaderText="Fecha Auditoría" />
                            <asp:BoundField DataField="idusuarioaudita" HeaderText="Auditor" />
                            <asp:BoundField DataField="nota" HeaderText="nota" />
                            <asp:BoundField DataField="pondera" HeaderText="Ponderación" />
                            <asp:BoundField DataField="obs" HeaderText="Observación" />
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
