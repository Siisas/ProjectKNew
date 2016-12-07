<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="consnovxusu.aspx.vb" Inherits="digitacion.consnovxusu" %>

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
                        style="font-size: medium; font-style: italic">Novedades por usuario</asp:Label>
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
                                <asp:Label ID="lblcod" runat="server" ForeColor="#003300"></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                <asp:Button ID="btnguardar" runat="server" Text="Consultar" 
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
                                Fecha Inicio</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtfcini" runat="server" Width="32%"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                    ControlToValidate="txtfcini" ErrorMessage="La fecha no es válida" 
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                            </td>
                            <td class="textotittabla">
                                Fecha Fin</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtfcfin" runat="server" Width="32%"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                                    ControlToValidate="txtfcfin" ErrorMessage="La fecha no es válida" 
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
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    Novedades Reportadas:&nbsp; <asp:Label ID="lblcuenta" runat="server"></asp:Label>
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
                            <asp:BoundField DataField="idreg" HeaderText="ID" />
                            <asp:BoundField DataField="cod" HeaderText="Código" />
                            <asp:BoundField DataField="fcnovedad" HeaderText="Fecha Novedad" />
                            <asp:BoundField DataField="descripcioninasistencia" HeaderText="Tipo Novedad" />
                            <asp:BoundField DataField="dias" HeaderText="Dias Nov" />
                            <asp:BoundField DataField="horas" HeaderText="Horas Nov" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="repone" HeaderText="Repone" />
                            <asp:BoundField DataField="reportanom" HeaderText="Reporta Nom" />
                            <asp:BoundField DataField="desctipo" HeaderText="Tipificación" />
                            <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="idusuarioreg" HeaderText="Usuario Reg" />
                            <asp:BoundField DataField="mesreporte" HeaderText="Mes Reportado" />
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
