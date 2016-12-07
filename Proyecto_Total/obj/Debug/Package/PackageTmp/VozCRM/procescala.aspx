<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="procescala.aspx.vb" Inherits="digitacion.procescala" %>

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
                        style="font-size: medium; font-style: italic">Escalamiento Voz</asp:Label>
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
                                    </tr>
                                </table>
                            </td>
                            <td style="width: 70%" rowspan="1">
                                            <asp:Button ID="Button1" runat="server" Text="Buscar" />
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                <asp:Panel ID="Panel2" runat="server">
                                    <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                                        <tr>
                                            <td class="textotittabla">
                                                CPD</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtcpd" runat="server" Width="142px" MaxLength="15"></asp:TextBox>
                                            </td>
                                            <td class="textotittabla">
                                                &nbsp;</td>
                                            <td class="celdascons">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Devolver</td>
                                            <td class="celdascons">
                                                <asp:CheckBox ID="chkdev" runat="server" />
                                            </td>
                                            <td class="textotittabla">
                                                Observación</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtobs" runat="server" Height="47px" MaxLength="10" 
                                                    TextMode="MultiLine" Width="318px"></asp:TextBox>
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
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" />
                </td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Campaña<td class="celdascons">
                                <asp:Label ID="lblcampana" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Min</td>
                            <td class="celdascons">
                                <asp:Label ID="lblmin" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Caso<td class="celdascons">
                                <asp:Label ID="lblcaso" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Contacto</td>
                            <td class="celdascons">
                                <asp:Label ID="lblcliente" runat="server"></asp:Label>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Número Contacto</td>
                            <td class="celdascons">
                                <asp:Label ID="lbltelcontacto" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Tiempo falla</td>
                            <td class="celdascons">
                                <asp:Label ID="lbltiempo" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Tipo Falla</td>
                            <td class="celdascons">
                                <asp:Label ID="lbltipof" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Características Falla</td>
                            <td class="celdascons">
                                <asp:Label ID="lblcaract" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Línea Portada</td>
                            <td class="celdascons">
                                <asp:Label ID="lblportada" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Departamento</td>
                            <td class="celdascons">
                                <asp:Label ID="lbldpto" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Municipio</td>
                            <td class="celdascons">
                                <asp:Label ID="lblmun" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Vereda Correg</td>
                            <td class="celdascons">
                                <asp:Label ID="lblvereda" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Dirección</td>
                            <td class="celdascons">
                                <asp:Label ID="lbldir" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Barrio</td>
                            <td class="celdascons">
                                <asp:Label ID="lblbarrio" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Tecnología</td>
                            <td class="celdascons">
                                <asp:Label ID="lbltecnologia" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Equipo</td>
                            <td class="celdascons">
                                <asp:Label ID="lblequipo" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                APN</td>
                            <td class="celdascons">
                                <asp:Label ID="lblapn" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                QoS</td>
                            <td class="celdascons">
                                <asp:Label ID="lblqos" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Más Lineas Reportadas</td>
                            <td class="celdascons">
                                <asp:Label ID="lblmaslineas" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Observación</td>
                            <td class="celdascons">
                                <asp:Label ID="lblobs" runat="server"></asp:Label>
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
                            <asp:BoundField DataField="campana" HeaderText="Campaña" />
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="idusuario" HeaderText="Agente Escala" />
                            <asp:BoundField DataField="fcasignado" HeaderText="Fecha Asignado" />
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
