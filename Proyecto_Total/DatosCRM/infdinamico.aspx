<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="infdinamico.aspx.vb" Inherits="digitacion.infdinamico" %>

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
            width: 22%;
            height: 22px;
        }
        .style7
        {
            width: 70%;
            height: 22px;
        }
       
                
        .style10
        {
            width: 22%;
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
     
        .style11
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 23px;
        }
        .style12
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 23px;
        }
     
        .style13
        {
            width: 9%;
        }
        .style14
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 3%;
            background: #E2E8FA;
        }
        .style15
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 9%;
            background: #E2E8FA;
        }
        .style16
        {
            width: 12%;
        }
        .style17
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 8%;
            background: #E2E8FA;
        }
        .style18
        {
            width: 21%;
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
                        style="font-size: medium; font-style: italic">Informes Dinámicos</asp:Label>
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
                            <td class="style6">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td rowspan="1" class="style10">
                                            <asp:Button ID="Button1" runat="server" Text="Buscar" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </td>
                            <td style="width: 70%" rowspan="1">
                                <asp:Button ID="btnxls" runat="server" Text="Exportar Excel" Width="91px" />
                            </td>
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
                                Fecha Inicial</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtfcdesden3" runat="server" Width="129px"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator3" runat="server" 
                                    ControlToValidate="txtfcdesden3" 
                                    ErrorMessage="El formato de Fecha desde no es correcta" 
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                            </td>
                            <td class="textotittabla">
                                Fecha Final</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtfchastan3" runat="server"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator4" runat="server" 
                                    ControlToValidate="txtfchastan3" 
                                    ErrorMessage="El formato de Fecha hasta no es correcta" 
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
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
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="style14">
                                <asp:CheckBox ID="chkcaso" runat="server" Text="Caso" />
                            </td>
                            <td class="style13">
                                <asp:CheckBox ID="chkmin" runat="server" Text="Min" />
                            </td>
                            <td class="style15">
                                <asp:CheckBox ID="chkfcreg" runat="server" Text="Fecha Creación" />
                            </td>
                            <td class="style16">
                                <asp:CheckBox ID="chknombre" runat="server" Text="Nombre" />
                            </td>
                            <td class="style17">
                                <asp:CheckBox ID="chkdocumento" runat="server" Text="Identificación" />
                            </td>
                            <td class="style16">
                                <asp:CheckBox ID="chkestado" runat="server" Text="Estado" />
                            </td>
                            <td class="style17">
                                <asp:CheckBox ID="chkfavorabilidad" runat="server" Text="Favorabilidad" />
                            </td>
                            <td class="style18">
                                <asp:CheckBox ID="chknxmonitor" runat="server" Text="NxMonitor" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style14">
                                <asp:CheckBox ID="chkfcseguim" runat="server" Text="Fecha Seguimiento" />
                            </td>
                            <td class="style13">
                                <asp:CheckBox ID="chkrespuesta" runat="server" Text="Respuesta" />
                            </td>
                            <td class="style15">
                                <asp:CheckBox ID="chkgrupo" runat="server" Text="Grupo" />
                            </td>
                            <td class="style16">
                                <asp:CheckBox ID="chkcausalcierre" runat="server" Text="Causal Cierre" />
                            </td>
                            <td class="style17">
                                <asp:CheckBox ID="chkclientesito" runat="server" Text="Tipo Clientesito" />
                            </td>
                            <td class="style16">
                                <asp:CheckBox ID="chktipoasunto" runat="server" Text="Tipo Asunto" />
                            </td>
                            <td class="style17">
                                &nbsp;</td>
                            <td class="style18">
                                <asp:CheckBox ID="chktodos" runat="server" Text="Todos" />
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
                <td class="style11">
                    </td>
                <td class="style12">
                    Registros&nbsp;&nbsp;&nbsp; 
                    &nbsp; 
                    <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                </td>
                <td class="style11">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                    <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="100" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                          
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
    
                    <asp:GridView ID="dtgxls" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="4000" Width="100%" style="font-size: x-small" 
                        Visible="False" EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
 
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
