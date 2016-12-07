<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CasosHoraD.aspx.vb" Inherits="digitacion.CasosHoraD" %>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Kamilion - ERP</title>
      <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <script type="text/jscript">
      $(function () {
          $("#TxtFecha_Inicio").datepicker();
          $('#TxtFecha_Inicio').datepicker('option', { dateFormat: 'dd/mm/yy' });
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
     
        .auto-style1 {}
        .auto-style2 {
            width: 50%;
            height: 22px;
        }
     
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 23px;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 23px;
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
                    Casos Hora</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td style="width:15%" valign="top">
                    <table class="style2">
                        <tr>
                            <td class="auto-style2">
                                <asp:Label ID="lblusuario" runat="server"></asp:Label>
                            </td>
                            <td class="style7">
                                <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1" colspan="2">
                               

                                    <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                                        <tr>
                                            <td class="textotittabla">
                                                Fecha Inicial</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtFecha_Inicio" runat="server"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtFecha_Inicio" ErrorMessage="Revise Fecha Inicio" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Button ID="BtnFiltro" runat="server" Text="Buscar" />
                                            </td>
                                        </tr>
                                    </table>
                               

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
                                &nbsp;<asp:Button ID="BtnDiario" runat="server" Text="Diario" />
                                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                </td>
                <td class="auto-style4">
                        <asp:Label ID="lblf1" runat="server"></asp:Label>
                        &nbsp;<asp:Label ID="lblcantgral" runat="server"></asp:Label>
                        </td>
                <td class="auto-style3">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                                <asp:Button ID="BtnExpo" runat="server" Text="Exportar" ALIGN="right" Visible="False"/>
                                <asp:Label ID="fc1" runat="server" Visible="False"></asp:Label>
                                <asp:Label ID="fc2" runat="server" Visible="False"></asp:Label>
                                <asp:Label ID="fc3" runat="server" Visible="False"></asp:Label>
                                <asp:Label ID="fc4" runat="server" Visible="False"></asp:Label>
                                <asp:Label ID="fc5" runat="server" Visible="False"></asp:Label>
                            </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                
                <td class="celdascent">
                    <CENTER>
                                <asp:GridView ID="DtgDiario" runat="server" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" BackColor="Black" BorderColor="Black" BorderWidth="1px" CellSpacing="1" Font-Names="Verdana" Font-Size="10pt" ShowFooter="True">
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" BorderColor="Black" />
                                    <EditRowStyle BackColor="#999999" />
                                    <FooterStyle BackColor="#0065FD" Font-Bold="True" ForeColor="White" BorderColor="Black" />
                                    <HeaderStyle BackColor="#0065FD" Font-Bold="True" ForeColor="White" BorderColor="Black" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                </asp:GridView>
                        </CENTER>
                </td>
                   
                <td class="celdasder">
                    &nbsp;</td>
                     
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    &nbsp;
                                
    
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
