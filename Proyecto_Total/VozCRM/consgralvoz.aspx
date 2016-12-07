<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="consgralvoz.aspx.vb" Inherits="digitacion.consgralvoz" %>

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
                        style="font-size: medium; font-style: italic">Consulta General Casos Voz</asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" Visible="False" />
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
                                            <asp:Button ID="Button1" runat="server" Text="Buscar" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
                </td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Min</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtmin" runat="server"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Caso</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtcaso" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Cliente</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtcliente" runat="server"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Bandeja</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlbandeja" runat="server" Height="22px" Width="138px">
                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                    <asp:ListItem>Voz</asp:ListItem>
                                    <asp:ListItem>Mensajes</asp:ListItem>
                                    <asp:ListItem>Buzon</asp:ListItem>
                                    <asp:ListItem>Otros</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Documento</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtnit" runat="server"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Rango de Fecha</td>
                            <td class="celdascons">
                                de
                                <asp:TextBox ID="txtFechainicio" runat="server" Width="100px"></asp:TextBox>
                                a
                                <asp:TextBox ID="txtFechafin" runat="server" Width="100px"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                    ControlToValidate="txtFechainicio" ErrorMessage="Fecha de inicio no es válida" 
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                                    ControlToValidate="txtFechafin" ErrorMessage="Fecha de fin no es válida" 
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Fallatec Pendientess</td>
                            <td class="celdascons">
                                <asp:CheckBox ID="chkfallatec" runat="server" />
                            </td>
                            <td class="textotittabla">
                                Fecha SAP</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtfcsap" runat="server"></asp:TextBox>
                            </td>
                             <tr>
                            <td class="textotittabla">
                           Tipificación</td>
                           <td class="celdascons">
                           <asp:TextBox ID="txtTipificacion" runat="server"></asp:TextBox>
                           </td>
                            <td class="textotittabla">
                                &nbsp;</td>
                            <td class="celdascons">
                                &nbsp;</td>
                        </tr>
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
                    <asp:LinkButton ID="LinkButton3" runat="server">Información General</asp:LinkButton>
                    &nbsp;&nbsp; 
                    <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                &nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton2" runat="server">Seguimientos</asp:LinkButton>
&nbsp;&nbsp; 
                    <asp:Label ID="lblcuenta0" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton1" runat="server">Marcaciones</asp:LinkButton>
&nbsp;<asp:Label ID="lblcuenta1" runat="server"></asp:Label>
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
                        GridLines="None" PageSize="100" Width="100%" style="font-size: x-small">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="cas_fecha_registro" HeaderText="Fecha de Registro" />
                            <asp:BoundField DataField="min_ac" HeaderText="Min" />
                            <asp:BoundField DataField="nom_cliente" HeaderText="Cliente" />
                            <asp:BoundField DataField="documento" HeaderText="Identificación" />
                            <asp:BoundField DataField="usuario_asignado" HeaderText="Usuario Bandeja" />
                            <asp:BoundField DataField="tipoinc" HeaderText="Tipo Inconsistencia" />
                            <asp:BoundField DataField="bandeja" HeaderText="Bandeja" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="fallatec" HeaderText="Fallatec" />
                            <asp:BoundField DataField="fcsap" HeaderText="Fecha Sap" />
                            <asp:BoundField DataField="estadofallatec" HeaderText="Estado Fallatec" />
                            <asp:BoundField DataField="cpd" HeaderText="CPD" />
                            <asp:BoundField DataField="estadocpd" HeaderText="Estado CPD" />
                            <asp:BoundField DataField="tickler" HeaderText="SD" />
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
    
                    <asp:GridView ID="dtgxls" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="1000" Width="100%" style="font-size: x-small" 
                        Visible="False">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="cas_fecha_registro" HeaderText="Fecha de Registro" />
                            <asp:BoundField DataField="min_ac" HeaderText="Min" />
                            <asp:BoundField DataField="nom_cliente" HeaderText="Cliente" />
                            <asp:BoundField DataField="documento" HeaderText="Identificación" />
                            <asp:BoundField DataField="usuario_asignado" HeaderText="Usuario Bandeja" />
                            <asp:BoundField DataField="tipoinc" HeaderText="Tipo Inconsistencia" />
                            <asp:BoundField DataField="bandeja" HeaderText="Bandeja" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="fallatec" HeaderText="Fallatec" />
                            <asp:BoundField DataField="fcsap" HeaderText="Fecha Sap" />
                            <asp:BoundField DataField="estadofallatec" HeaderText="Estado Fallatec" />
                            <asp:BoundField DataField="cpd" HeaderText="CPD" />
                            <asp:BoundField DataField="estadocpd" HeaderText="Estado CPD" />
                            <asp:BoundField DataField="tickler" HeaderText="SD" />
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
    
                    <asp:GridView ID="dtgseguimiento" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="min_ac" HeaderText="Min" />
                            <asp:BoundField DataField="fcreg" HeaderText="Fecha Seguimiento" />
                            <asp:BoundField DataField="idusuario" HeaderText="Agente" />
                            <asp:BoundField DataField="obs" HeaderText="Observaciones" />
                            <asp:BoundField DataField="Tipificacion" HeaderText="Tipificación" />
                            <asp:BoundField DataField="numalt" HeaderText="Numero alterno" />
                            <asp:BoundField DataField="fallared" HeaderText="Falla de Red" />
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
    
                    <asp:GridView ID="dtgmarcacion" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="contrato" HeaderText="Caso" />
                            <asp:BoundField DataField="estado" HeaderText="Tipo Contacto" />
                            <asp:BoundField DataField="agente" HeaderText="Agente" />
                            <asp:BoundField DataField="duracion" HeaderText="Duración" />
                            <asp:BoundField DataField="Lista" HeaderText="Lista" />
                            <asp:BoundField DataField="min_ac" HeaderText="MIN" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Marcación" />
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
    
                    <table style="width: 100%; height: 100%">
                        <tr>
                            <td class="celdascent">
                                <asp:GridView ID="dtgtipificacion" runat="server" AllowPaging="True" 
                                    AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" 
                                    ForeColor="#333333" GridLines="None" PageSize="100" style="font-size: x-small" 
                                    Width="100%">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="idcaso" HeaderText="CASOS">
                                        <ItemStyle HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="cas_fecha_registro" HeaderText="FECHA DE REGISTRO">
                                        <ItemStyle HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="fcreg" HeaderText="FECHA DE GESTION">
                                        <ItemStyle HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="min_ac" HeaderText="MIN">
                                        <ItemStyle HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="obs" HeaderText="OBSERVACIÓN">
                                        <ItemStyle HorizontalAlign="Justify" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="tipificacion" HeaderText="TIPIFICACIÓN" />
                                    </Columns>
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                                <asp:GridView ID="dtgxls2" runat="server" AllowPaging="True" 
                                    AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" 
                                    ForeColor="#333333" GridLines="None" PageSize="20000" 
                                    style="font-size: x-small" Width="100%">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="idcaso" HeaderText="CASOS">
                                        <ItemStyle HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="cas_fecha_registro" HeaderText="FECHA DE REGISTRO">
                                        <ItemStyle HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="fcreg" HeaderText="FECHA DE GESTION">
                                        <ItemStyle HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="min_ac" HeaderText="MIN">
                                        <ItemStyle HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="obs" HeaderText="OBSERVACIÓN">
                                        <ItemStyle HorizontalAlign="Justify" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="tipificacion" HeaderText="TIPIFICACIÓN" />
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
            </table>
    
    </form>
</body>
</html>
