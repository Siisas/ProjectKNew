<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CampañasVoz.aspx.vb" Inherits="digitacion.CampañasVoz" %>

<%@ Register Src="../menu.ascx" tagprefix="uc1" tagname="menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <title>Kamilion - ERP</title> <!-- Inicio Script jQuery Datepicker --->
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
        .style9
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 7%;
            background: #E2E8FA;
        }
        .auto-style9 {
            width: 20%;
        }
        .auto-style17 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 81%;
            height: 39px;
        }
        .auto-style20 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 21px;
        }
        .auto-style23 {
            color: #000099;
            width: 81%;
            height: 21px;
        }
        .auto-style26 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 26px;
        }
        .auto-style27 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 81%;
            height: 26px;
        }
        .auto-style30 {
        }
        .auto-style31 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 63px;
        }
        .auto-style32 {
            color: #000099;
            width: 81%;
            height: 63px;
        }
        .auto-style34 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 24px;
        }
        .auto-style35 {
            color: #000099;
            width: 81%;
            height: 24px;
        }
        .auto-style36 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 39px;
        }
        .auto-style37 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 81%;
        }
        .auto-style38 {
            width: 81%;
        }
        .auto-style40 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 25%;
            background: #E2E8FA;
        }
        .auto-style41 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 1px;
        }
        .auto-style42 {
            color: #000099;
            width: 81%;
            height: 1px;
        }
        .auto-style43 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
            color: navy;
            width: 698px;
        }
        .auto-style44 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 13%;
        }
        .auto-style45 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 13%;
            height: 26px;
        }
        .auto-style46 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 13%;
            height: 21px;
        }
        .auto-style47 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 13%;
            height: 39px;
        }
        .auto-style48 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 13%;
            height: 63px;
        }
        .auto-style49 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 13%;
            height: 24px;
        }
        .auto-style50 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 13%;
            height: 1px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <table style="width:100%; height: 100%">
            <tr>
                <td class="celdasder">
                </td>
                <td class="auto-style37">
                    <table style="border-style: outset; border-width: 1px; width:100%">
                        <tr>
                            <td class="auto-style9">
                                &nbsp;</td>
                            <td align="left" class="auto-style43">
                                Kamilion Comunicaciones - ERP</td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style44">
                </td>
            </tr>            
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="auto-style37">
                    <asp:Label ID="lblmsg" runat="server" style="color: #FF3300"></asp:Label>
                </td>
                <td class="auto-style44">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style26">
                    </td>                    
                <td class="auto-style27">
                    <uc1:menu ID="menu1" runat="server" />
                </td>
                
                <td class="auto-style45">
                    </td>
            </tr>
            
            <tr>
                <td class="celdasder">
                </td>
                <td valign="top" class="auto-style38">
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
                <td class="auto-style44">
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style23">
                    Campañas Voz</td>
                <td class="auto-style46">
                    </td>
            </tr>            
            <tr>
                <td class="auto-style36">
                </td>
                <td class="auto-style17">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>                            
                            <td class="auto-style40">
                                Campaña</td>
                            <td class="auto-style30">                                
                                
                                <asp:DropDownList ID="DrpCampa" runat="server">
                                    <asp:listitem value="0">-Seleccione-</asp:listitem>
                                    <asp:listitem value="1">Voz</asp:listitem>
                                    <asp:listitem value="2">Mensajes</asp:listitem>
                                    <asp:listitem value="3">Buzon</asp:listitem>
                                    <asp:listitem value="4">OTROS SERV</asp:listitem>
                                    <asp:listitem value="5">LDI</asp:listitem>
                                    <asp:listitem value="6">Banca Movil</asp:listitem>
                                    <asp:listitem value="7">PQR</asp:listitem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        </table>
                </td>
                <td class="auto-style47">
                </td>
            </tr>
            <tr>
                <td class="auto-style31">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style32">
                    <table border="0">
                    <tr>
                    <td class="style6">
                        <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="BtnVoz" runat="server" Text="Consolidado Voz" />
                        </td>
                    <td class="style7">                               
                            &nbsp;&nbsp;
                                &nbsp;&nbsp;
                                &nbsp;&nbsp;
                                </td>
                    </tr>
                    <tr>
                    <td class="style6">
                        &nbsp;</td>
                    <td class="style7" ALIGN=right>                               
                            <asp:Button ID="BtnExportar" runat="server" Text="Exportar" Visible="False" />
                        </td>
                    </tr>
                    </table>
                                
                                
                            </td>
                <td class="auto-style48">
                    </td>
            </tr>
            <tr>
                <td class="auto-style34">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style35" >                    
                                <br />
                    <CENTER>
                                <asp:Label ID="lblmensa" runat="server" ForeColor="Black"></asp:Label>
                        </CENTER>
                    <center>
                                <asp:GridView ID="DtgGrupo" runat="server" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" BackColor="Black" BorderColor="Black" BorderWidth="1px" CellSpacing="1" Font-Names="Verdana" Font-Size="10pt" ShowFooter="True" AutoGenerateColumns="False">
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" BorderColor="Black" />
                                    <EditRowStyle BackColor="#999999" />
                                    <FooterStyle BackColor="#0065FD" Font-Bold="True" ForeColor="White" BorderColor="Black" />
                                    <HeaderStyle BackColor="#0065FD" Font-Bold="True" ForeColor="White" BorderColor="Black" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                       <Columns>
                                        <asp:BoundField DataField="Fecha_Sap" HeaderText="Fecha_Sap"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Fecha_Corta" HeaderText="Fecha_Corta"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Abierto" HeaderText="Abierto"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Cerrado" HeaderText="Cerrado"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Escalado" HeaderText="Escalado"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Gestionado" HeaderText="Gestionado"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="ILOCALIZABLE" HeaderText="ILOCALIZABLE"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="No Disponible" HeaderText="No Disponible"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Rechazado" HeaderText="Rechazado"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Total" HeaderText="Total"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Pendientes" HeaderText="Pendientes"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Porcentaje" HeaderText="Porcentaje"  HtmlEncode=false />
                                    </Columns>
                                </asp:GridView>
                                <asp:GridView ID="DtgCampa" runat="server" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" BackColor="Black" BorderColor="Black" BorderWidth="1px" CellSpacing="1" Font-Names="Verdana" Font-Size="10pt" ShowFooter="True" AutoGenerateColumns="False">
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" BorderColor="Black" />
                                    <EditRowStyle BackColor="#999999" />
                                    <FooterStyle BackColor="#0065FD" Font-Bold="True" ForeColor="White" BorderColor="Black" />
                                    <HeaderStyle BackColor="#0065FD" Font-Bold="True" ForeColor="White" BorderColor="Black" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                       <Columns>
                                           <asp:BoundField DataField="bandeja" HeaderText="Bandeja"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Fecha_Sap" HeaderText="Fecha_Sap"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Fecha_Corta" HeaderText="Fecha_Corta"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Abierto" HeaderText="Abierto"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Cerrado" HeaderText="Cerrado"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Escalado" HeaderText="Escalado"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Gestionado" HeaderText="Gestionado"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="ILOCALIZABLE" HeaderText="ILOCALIZABLE"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="No Disponible" HeaderText="No Disponible"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Rechazado" HeaderText="Rechazado"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Total" HeaderText="Total"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Pendientes" HeaderText="Pendientes"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="Porcentaje" HeaderText="Porcentaje"  HtmlEncode=false />
                                    </Columns>
                                </asp:GridView>
                                <br />
                        </center>
                            </td>
                <td class="auto-style49">
                    </td>
            </tr>
            <tr>
                <td class="auto-style41">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style42">
                    &nbsp;</td>
                <td class="auto-style50">
                    </td>
            </tr>
        </table>
    
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" Height="16px" />
    </form>
</body>
</html>