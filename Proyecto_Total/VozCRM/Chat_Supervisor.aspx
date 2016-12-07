<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Chat_Supervisor.aspx.vb" Inherits="digitacion.Chat_Supervisor" %>

<%@ Register src="../menu.ascx" tagname="menu" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ERP Kamilion</title>
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
                        style="font-size: medium; font-style: italic">Asignación Digitación Voz</asp:Label>
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
                                <asp:Panel ID="Panel2" runat="server">
                                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                                        <tr>
                                            <td class="celdascons" colspan="4">
                                                Bandeja de Entrada:<asp:Label ID="LblCantidadMensajes" runat="server"></asp:Label>
                                                &nbsp;<asp:Button ID="BtnActualizarBandeja" runat="server" 
                                                    Text="Actualizar Bandeja" />
                                            </td>
                                        </tr>
                                        <tr>
                                        <td colspan="4">
                                            <asp:GridView ID="dtgBandeja" runat="server" 
                                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                                                GridLines="None" Width="50%" style="font-size: x-small" 
                                                EnableModelValidation="True" AllowPaging="True">
                                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                                <Columns>
                                                    <asp:BoundField DataField="cargo" HeaderText="Grupo" >
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="nombreu" HeaderText="Mensaje de" >
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="IdUsuario" HeaderText="Usuario" >
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="Fecha_Reg" HeaderText="Fecha de envio" >
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:ButtonField CommandName="Seleccionar" HeaderText="Seleccionar" Text="Seleccionar">
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    </asp:ButtonField>
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
                                        <tr>
                                            <td class="textotittabla">
                                                Grupo</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlGrupo" runat="server" AutoPostBack="True" 
                                                    Height="22px" Width="322px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Agente</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlUsuario" runat="server" 
                                                    Height="22px" Width="322px">
                                                </asp:DropDownList>
                                            </td>
                                            <td class="textotittabla">
                                                Actualizar Conversacion</td>
                                            <td class="celdascons">
                                                <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Mensaje Max.1000 Caracteres</td>
                                            <td class="celdascons" colspan="3">
                                                <asp:TextBox ID="TxtMensaje" runat="server" Height="74px" TextMode="MultiLine" 
                                                    MaxLength="1000" Width="875px" ></asp:TextBox>
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
                    <asp:Button ID="btnEnviar" runat="server" style="height: 26px" Text="Enviar" />
                 </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
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
                        GridLines="None" PageSize="500" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Fecha_Reg" HeaderText="Fecha de envio" >
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Usuario" HeaderText="Usuario que envia" >
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Obs" HeaderText="Mensaje" >
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
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
