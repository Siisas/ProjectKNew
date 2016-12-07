<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TipoFallaVozNueva.aspx.vb" Inherits="digitacion.TipoFallaVozNueva1" %>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Página sin título</title>

  <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <script type="text/jscript">
      $(function () {
          $("#TxtFecha_Inicio").datepicker();
          $('#TxtFecha_Inicio').datepicker('option', { dateFormat: 'dd/mm/yy' })
          $("#TxtFecha_Fin").datepicker();
          $('#TxtFecha_Fin').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
  </script>
  <!-- Fin Script jQuery Datepicker --->
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
     
        .style3
        {
            color: #000099;
            width: 80%;
        }
        .style4
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
        }
        .style5
        {
            width: 80%;
        }
        .style6
        {
            width: 624px;
        }
        .style7
        {
            width: 411px;
        }
        .style8
        {
            width: 864px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <table style="width:100%; height: 100%">
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                    <table style="border-style: outset; border-width: 1px; width:100%">
                        <tr>
                            <td style="width:20%">
                                &nbsp;</td>
                            <td align="left" class="titulo">
                                Kamilion Comunicaciones - ERP</td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="lblmsg" runat="server" style="color: #FF3300"></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="style4">
                    <uc1:menu ID="menu1" runat="server" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td valign="top" class="style5">
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    Tipo de falla voz Nuevo Formato</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Fecha Inicio</td>
                            <td class="celdascons">                                
                                
                                <asp:TextBox ID="TxtFecha_Inicio" runat="server" Width="58%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtFecha_Inicio" ErrorMessage="Revise Fecha Inicio" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                            </td>
                            <td class="textotittabla">
                                Fecha Fin</td>
                            <td class="celdascons">                                
                                
                                <asp:TextBox ID="TxtFecha_Fin" runat="server" Width="58%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="txtFecha_Fin" ErrorMessage="Revise Fecha fin" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <table border="0">
                    <tr>
                    <td class="style6">
                        <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="BtnDiaria" runat="server" Text="Busqueda diaria" />
                            &nbsp;&nbsp;
                                &nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;</td>
                    <td class="style7">                               
                            &nbsp;&nbsp;
                                &nbsp;&nbsp;
                                &nbsp;&nbsp;
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
                <td class="style4">
                        <asp:Label ID="lblmensa" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lblfalla1" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lblfalla2" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lblfalla3" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lblfalla4" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lblfalla5" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltot1" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltot2" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltot3" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltot4" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltot5" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lblfallap1" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lblfallap2" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lblfallap3" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lblfallap4" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lblfallap5" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltotp1" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltotp2" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltotp3" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltotp4" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltotp5" runat="server" Visible="False"></asp:Label>
                </td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <table border="0">
                    <tr>
                    <td class="style8">
                     &nbsp;                               
                            <asp:Button ID="BtnExportar" runat="server" Text="Exportar" Visible="False" />
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <center>
                                <asp:GridView ID="DtgDiario" runat="server" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" BackColor="Black" BorderColor="Black" BorderWidth="1px" CellSpacing="1" Font-Names="Verdana" Font-Size="10pt" ShowFooter="True" Visible="False">
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" BorderColor="Black" />
                                    <EditRowStyle BackColor="#999999" />
                                    <FooterStyle BackColor="#0065FD" Font-Bold="True" ForeColor="White" BorderColor="Black" />
                                    <HeaderStyle BackColor="#0065FD" Font-Bold="True" ForeColor="White" BorderColor="Black" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                </asp:GridView>
                                <asp:Button ID="BtnQuitar" runat="server" Text="Quitar" Visible="False" />
                                <br />
                        </center>

                            </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <center>
                            <asp:Label ID="lblcantidad" runat="server"></asp:Label>
                                <br />
                                <asp:Label ID="lblmensa2" runat="server" ALIGN=left></asp:Label>
                                <asp:GridView ID="Dtgpersonal" runat="server" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" BackColor="Black" BorderColor="Black" BorderWidth="1px" CellSpacing="1" Font-Names="Verdana" Font-Size="10pt"  ShowFooter="True" Visible="False">
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" BorderColor="Black" />
                                    <EditRowStyle BackColor="#999999" />
                                    <FooterStyle BackColor="#0065FD" Font-Bold="True" ForeColor="White" BorderColor="Black" />
                                    <HeaderStyle BackColor="#0065FD" Font-Bold="True" ForeColor="White" BorderColor="Black" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                </asp:GridView>
                                <br />
                                <asp:Button ID="BtnQuitar2" runat="server" Text="Quitar"  Visible="False"/>
                        </center>

                            </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
        </table>
    
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" />
    </form>
</body>
</html>

