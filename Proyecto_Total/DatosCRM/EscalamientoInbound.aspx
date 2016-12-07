<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EscalamientoInbound.aspx.vb" Inherits="digitacion.EscalamientoInbound1" %>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kamilion - ERP</title>
      <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <script type="text/jscript">
      $(function () {
          $("#TxtFecha_Inicio").datepicker();
          $('#TxtFecha_Inicio').datepicker('option', { dateFormat: 'dd/mm/yy' });
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
                    Escalamiento Inbound</td>
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
                                            <td class="textotittabla">
                                                Fecha Final</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtFecha_Fin" runat="server"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtFecha_Fin" ErrorMessage="Revise fecha fin" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
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
                                &nbsp;<asp:Button ID="BtnBuscar" runat="server" Text="Buscar" />
                                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td class="celdascent">
                        <asp:Label ID="lblf1" runat="server"></asp:Label>
                        <br />
                        Numero de registros:
                        &nbsp;<asp:Label ID="lblcantgral" runat="server"></asp:Label>
                        </td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                                <asp:Button ID="BtnExpo" runat="server" Text="Exportar" ALIGN="right" Visible="False"/>
                            </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                              <asp:GridView ID="DtgEscalados" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="90" Width="100%" style="font-size: x-small" 
                                    EnableModelValidation="True" AutoGenerateColumns="False">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="Cas_id" HeaderText="Cas_id"  HtmlEncode=false />
                                        <asp:BoundField DataField="Estado" HeaderText="Estado"   HtmlEncode=false />
                                        <asp:BoundField DataField="F_escalamiento" HeaderText="Fecha_escalamiento"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Bandeja" HeaderText="Bandeja"   HtmlEncode=false />
                                        <asp:BoundField DataField="Segmento" HeaderText="Segmento"   HtmlEncode=false />
                                        <asp:BoundField DataField="Area_Escalamiento" HeaderText="Area_escalamiento"   HtmlEncode=false />
                                        <asp:BoundField DataField="CPD" HeaderText="CPD"   HtmlEncode=false />
                                    </Columns>
                    </asp:GridView>
                                
                                
                            </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    &nbsp;
                                
    
                              <asp:GridView ID="DtgServicio2" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20000" Width="100%" style="font-size: x-small" 
                                    EnableModelValidation="True" Visible="False" AutoGenerateColumns="False">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="Cas_id" HeaderText="Cas_id"  HtmlEncode=false />
                                        <asp:BoundField DataField="Estado" HeaderText="Estado"   HtmlEncode=false />
                                        <asp:BoundField DataField="F_escalamiento" HeaderText="Fecha_escalamiento"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Bandeja" HeaderText="Bandeja"   HtmlEncode=false />
                                        <asp:BoundField DataField="Segmento" HeaderText="Segmento"   HtmlEncode=false />
                                        <asp:BoundField DataField="Area_Escalamiento" HeaderText="Area_escalamiento"   HtmlEncode=false />
                                        <asp:BoundField DataField="CPD" HeaderText="CPD"   HtmlEncode=false />
                                    </Columns>
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
            </table>
    
    </form>
</body>
</html>
