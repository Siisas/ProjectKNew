<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="procescalav2.aspx.vb" Inherits="digitacion.procescalav2" %>

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
                        style="font-size: medium; font-style: italic">Escalamiento Voz Service</asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" />
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
                                                <asp:Button ID="btnbusca" runat="server" style="height: 26px" 
                                                    Text="Buscar" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="width: 70%" rowspan="1">
                                                <asp:Button ID="btnguardar" runat="server" style="height: 26px" 
                                                    Text="Guardar" />
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
                                    <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                                        <tr>
                                            <td class="textotittabla">
                                                Min</td>
                                            <td class="celdascons">
                                <asp:Label ID="lblmin" runat="server"></asp:Label>
                                            </td>
                                            <td class="textotittabla">
                                                Cliente</td>
                                            <td>
                                <asp:Label ID="lblcliente" runat="server"></asp:Label>
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
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                <asp:Panel ID="Panel2" runat="server">
                                    <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                                        <tr>
                                            <td class="textotittabla">
                                                Ticket</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtcpd" runat="server" Width="142px" MaxLength="15"></asp:TextBox>
                                            </td>
                                            <td class="textotittabla">
                                                Observación</td>
                                            <td>
                                                <asp:TextBox ID="txtobs" runat="server" Height="38px" MaxLength="15" 
                                                    TextMode="MultiLine" Width="359px"></asp:TextBox>
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
                    Casos asignados pendientes&nbsp; 
                    <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                    &nbsp; 
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
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="cas_fecha_registro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="min_ac" HeaderText="MIN" />
                            <asp:BoundField DataField="nom_cliente" HeaderText="Cliente" />
                            <asp:BoundField DataField="documento" HeaderText="Identificación" />
                            <asp:BoundField DataField="equipo_ac" HeaderText="Equipo" />
                            <asp:BoundField DataField="usuario_asignado" HeaderText="Usuario Asignado" />
                            <asp:BoundField DataField="tipoinc" HeaderText="Tipo Inconsistencia" />
                            <asp:BoundField DataField="bandeja" HeaderText="Bandeja" />
                            <asp:BoundField DataField="nombredpto" HeaderText="Departamento" />
                            <asp:BoundField DataField="nombremun" HeaderText="Municipio" />
                            <asp:BoundField DataField="fcreg" HeaderText="Fecha Reporte" />
                            <asp:BoundField DataField="idusuario" HeaderText="Agente Reporte" />
                            <asp:BoundField DataField="obs" HeaderText="Observación" />
                            <asp:BoundField DataField="tipificacion" HeaderText="Tipificación" />
                            <asp:BoundField DataField="numalt" HeaderText="Número Tel" />
                            <asp:BoundField DataField="barrio" HeaderText="Barrio" />
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
