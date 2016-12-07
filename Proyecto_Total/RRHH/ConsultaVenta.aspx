<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConsultaVenta.aspx.vb" Inherits="digitacion.ConsultaVenta" %>

<%@ Register Src="../menu.ascx" tagprefix="uc1" tagname="menu" %>

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
            width: 80%;
            height: 119px;
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
            width: 80%;
            height: 21px;
        }
        .auto-style24 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 119px;
        }
        .auto-style25 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            background: #E2E8FA;
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
            width: 80%;
            height: 26px;
        }
        .auto-style28 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            background: #E2E8FA;
            height: 41px;
        }
        .auto-style29 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 15%;
            height: 41px;
            background: #E2E8FA;
        }
        .auto-style30 {
            width: 35%;
            height: 41px;
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
            width: 80%;
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
            width: 80%;
            height: 24px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <table style="width:100%; height: 100%">
            <tr>
                <td class="celdasder">
                </td>
                <td class="celdascent">
                    <table style="border-style: outset; border-width: 1px; width:100%">
                        <tr>
                            <td class="auto-style9">
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
                <td class="celdascent">
                    <asp:Label ID="lblmsg" runat="server" style="color: #FF3300"></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style26">
                    </td>                    
                <td class="auto-style27">
                    <uc1:menu ID="menu1" runat="server" />
                </td>
                
                <td class="auto-style26">
                    </td>
            </tr>
            
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:Label ID="lblmsg0" runat="server" 
                        style="font-size: medium; font-style: italic">Cafeteria</asp:Label>
                </td>
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
                <td class="auto-style20">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style23">
                    Consulta de Ventas</td>
                <td class="auto-style20">
                    </td>
            </tr>            
            <tr>
                <td class="auto-style24">
                </td>
                <td class="auto-style17">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>                            
                            <td class="textotittabla">
                                <asp:RadioButton ID="RdbTotal" runat="server" Checked="True" GroupName="Consulta" Text="Todas las ventas" />
                            </td>
                            <td class="celdascons">                                
                                
                                &nbsp;</td>                            
                            <td class="auto-style25">
                                <asp:RadioButton ID="RdbCodigo" runat="server" GroupName="Consulta" Text="Codigo de Ticket" />
                            </td>                            
                            <td class="celdascons">                                
                                <asp:TextBox ID="txtCod" runat="server"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtCod" ErrorMessage="Digite un dato numerico " Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>                            
                            <td class="auto-style29">
                                <asp:RadioButton ID="RdbDocumento" runat="server" GroupName="Consulta" Text="Documento Cliente" />
                                </td>
                            <td class="auto-style30">                                
                                
                                <asp:TextBox ID="txtdoc" runat="server"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtdoc" ErrorMessage="Digite un dato numerico" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer">*</asp:CompareValidator>
                            </td>
                            <td class="auto-style28">
                                <asp:RadioButton ID="RdbUsu" runat="server" GroupName="Consulta" Text="Usuario Vendedor" />
                            </td>                            
                            <td class="auto-style30">                                
                                <asp:TextBox ID="txtUsu" runat="server"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="txtUsu" ErrorMessage="Digite un dato numerico" Operator="DataTypeCheck" SetFocusOnError="True">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>                            
                            <td class="auto-style29">
                                <asp:RadioButton ID="rdbFecha" runat="server" GroupName="Consulta" Text="Fecha" />
                                </td>
                        </tr>
                        <tr>                            
                            <td class="auto-style29">
                                Fecha Inicio</td>
                            <td class="auto-style30">                                
                                
                                <asp:TextBox ID="TxtFecha_Inicio" runat="server" Width="23%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                            </td>
                            <td class="auto-style28">
                                Fecha fin</td>                            
                            <td class="auto-style30">                                
                                <asp:TextBox ID="TxtFecha_Fin" runat="server" Width="23%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                            </td>
                        </tr>
                        </table>
                </td>
                <td class="auto-style24">
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
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                            &nbsp;&nbsp;
                                &nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;</td>
                    <td class="style7">                               
                            &nbsp;&nbsp;
                                &nbsp;&nbsp;
                                &nbsp;&nbsp;
                                </td>
                    </tr>
                    <tr>
                    <td class="style6">
                        Numero de registros: <asp:Label ID="lblcantgral" runat="server"></asp:Label></td>
                    <td class="style7" ALIGN=right>                               
                            <asp:Button ID="BtnExportar" runat="server" Text="Exportar" />
                        </td>
                    </tr>
                    </table>
                                
                                
                            </td>
                <td class="auto-style31">
                    </td>
            </tr>
            <tr>
                <td class="auto-style31">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style32">
                    <asp:GridView ID="DtgVentas" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Cod_Cafeteria_Venta" HeaderText="Codigo Ticket" />
                            <asp:BoundField DataField="Fecha_Venta" HeaderText="Fecha venta" />
                            <asp:BoundField DataField="Id_Usuario" HeaderText="Vendedor" />
                            <asp:BoundField DataField="Codigo" HeaderText="Codigo Cliente" />
                            <asp:BoundField DataField="Documento_Cliente" HeaderText="Documento Cliente" />
                            <asp:BoundField DataField="Total" HeaderText="Total Venta" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView></td>
                <td class="auto-style31">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style34">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style35" ALIGN=right>                    
                            TOTAL: $<asp:Label ID="lbltotal" runat="server"></asp:Label>
                        </td>
                <td class="auto-style34">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
        </table>
    
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" />
    </form>
</body>
</html>
