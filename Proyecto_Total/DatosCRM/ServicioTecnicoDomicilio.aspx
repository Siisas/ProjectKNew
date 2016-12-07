<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ServicioTecnicoDomicilio.aspx.vb" Inherits="digitacion.ServicioTecnicoDomicilio" %>

<%@ Register Src="../menu.ascx" TagPrefix="uc1" TagName="menu" %>

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
        .auto-style16 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 37px;
        }
        .auto-style17 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 82%;
            height: 37px;
        }
         .auto-style18 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 15%;
            height: 4px;
            background: #E2E8FA;
        }
        .auto-style22 {
            width: 30%;
            height: 23px;
        }
        .auto-style23 {
            width: 70%;
            height: 23px;
        }
        .auto-style24 {
            font-size: large;
            color: #0000FF;
        }
        .auto-style25 {
            width: 624px;
            font-weight: 700;
        }
        .auto-style29 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 206px;
        }
        .auto-style30 {
            color: #000099;
            width: 82%;
            height: 206px;
        }
        .auto-style31 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 32px;
        }
        .auto-style32 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 82%;
            height: 32px;
        }
        .auto-style33 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 82%;
        }
        .auto-style34 {
            width: 82%;
        }
        .auto-style35 {
            color: #000099;
            width: 82%;
        }
        .auto-style36 {
            height: 4px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <table style="width:100%; height: 576px; margin-bottom: 0px;">
            <tr>
                <td class="celdasder">
                </td>
                <td class="auto-style33">
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
                <td class="auto-style33">
                    <asp:Label ID="lblmsg" runat="server" style="color: #FF3300"></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
            <tr>
                <td class="celdasder">
                    &nbsp;</td>                    
                <td class="auto-style33">
                    <uc1:menu ID="menu1" runat="server" />
                </td>
                
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="auto-style33">
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="auto-style33">
                    SERVICIO TECNICO A DOMICILIO</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td valign="top" class="auto-style34">
                    <table class="style2">
                        <tr>
                            <td class="auto-style22">
                                <asp:Label ID="lblusuario" runat="server"></asp:Label>
                            </td>
                            <td class="auto-style23">
                                <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="auto-style16">
                </td>
                <td class="auto-style17">
                    <table class="style1" cellpadding="1" cellspacing="1" border ="1">
                        <tr>
                            <td class="auto-style18">Fecha Inicio</td>
                            <td class="auto-style36">
                                
                                <asp:TextBox ID="TxtFecha_Inicio" runat="server" placeholder="DD/MM/YYYY" Width="117px"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtFecha_Inicio" ErrorMessage="Revise Fecha Inicio" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                            </td>
                            <td class="auto-style18">Fecha Fin</td>
                            <td class="auto-style36">                               
                                <asp:TextBox ID="TxtFecha_Fin" runat="server" placeholder="DD/MM/YYYY" Width="111px"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtFecha_Fin" ErrorMessage="Revise fecha fin" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style18">Ciudad</td>
                            <td>
                                <asp:TextBox ID="TxtCiudad" runat="server"></asp:TextBox>
                                
                                </td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style16">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style35">
                    <table border="0">
                    <tr>
                    <td class="style6">
                    <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" />
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
                        <asp:Label ID="lblf1" runat="server"></asp:Label>
&nbsp;-
                        <asp:Label ID="lblf2" runat="server"></asp:Label>
                        </td>
                    <td class="style7">                               
                            &nbsp;</td>
                    </tr>
                    <tr>
                    <td class="auto-style25">
                        Numero de registros:
                        &nbsp;<asp:Label ID="lblcantgral" runat="server"></asp:Label>
                        </td>
                    <td class="style7">                               
                                <asp:Button ID="BtnExpo" runat="server" Text="Exportar" ALIGN="right" Visible="False"/>
                            </td>
                    </tr>
                    </table>
                                
                                
                            </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style29">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style30">
                              <asp:GridView ID="DtgServicio" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="90" Width="100%" style="font-size: x-small" 
                                    EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                                
                                
                            </td>
                <td class="auto-style29">
                    &nbsp;</td>
            </tr>
      
            <tr>
                <td class="auto-style31">
                    </td>
                <td class="auto-style32">
                
    
                              <asp:GridView ID="DtgServicio2" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20000" Width="100%" style="font-size: x-small" 
                                    EnableModelValidation="True" Visible="False">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                                
                                
                </td>
                <td class="auto-style31">
                    </td>

            </tr>
      
        </table>
    
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" />
        <p class="auto-style24">
            
                &nbsp;</p>
    </form>
</body>
</html>
