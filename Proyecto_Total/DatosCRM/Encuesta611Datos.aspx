<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Encuesta611Datos.aspx.vb" Inherits="digitacion.Encuesta611Datos" %>

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
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 118px;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 118px;
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
            width: 80%;
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
        .auto-style19 {
            width: 35%;
            height: 4px;
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
        .auto-style26 {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style27 {
            height: 23px;
        }
        .auto-style28 {
            height: 25px;
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
            width: 80%;
            height: 206px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <table style="width:100%; height: 100%; margin-bottom: 0px;">
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
                <td class="celdascent">
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    Encuesta *611 Datos</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td valign="top" class="style5">
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
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="auto-style18" rowspan="0">
                                Fecha inicio</td>
                            <td class="auto-style19" rowspan="0">                                
                                
                                <asp:TextBox ID="TxtFecha_Inicio" runat="server" placeholder="DD/MM/YYYY" Width="234px"></asp:TextBox>
                            </td>
                            <td class="auto-style18" rowspan="0">
                                Fecha Fin</td>
                            <td class="auto-style19" rowspan="0">                                
                                <asp:TextBox ID="TxtFecha_Fin" runat="server" placeholder="DD/MM/YYYY" Width="234px"></asp:TextBox>
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
                    valign="top" class="style3">
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
                    <td class="auto-style25">
                        &nbsp;<asp:Label ID="lblcantgral" runat="server" Visible="False"></asp:Label>
                        </td>
                    <td class="style7">                               
                            &nbsp;</td>
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
                    <asp:Panel ID="PnlEncuesta" runat="server" Height="191px" Visible="False">
                        <table class="auto-style26" border="1">
                            <tr>
                                <td style="background-color: #409131; color: #FFFFFF; text-align: center; font-family: verdana, Geneva, Tahoma, sans-serif;" class="auto-style28" colspan="3">
                                    <asp:Label ID="Lblfeci" runat="server"></asp:Label>
                                    &nbsp;-&nbsp;
                                    <asp:Label ID="Lblfecf" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="background-color: #409131; color: #FFFFFF; font-family: verdana, Geneva, Tahoma, sans-serif;" class="auto-style28">Etiqueta de fila</td>
                                <td style="background-color: #409131; color: #FFFFFF; font-family: verdana, Geneva, Tahoma, sans-serif;" class="auto-style28">Porcentaje</td>
                                <td style="background-color: #409131; color: #FFFFFF; font-family: verdana, Geneva, Tahoma, sans-serif;" class="auto-style28">Respuesta</td>
                            </tr>
                            <tr>
                                <td class="auto-style27">
                                    <asp:Label ID="LblEti1" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style27">
                                    <asp:Label ID="LblPor1" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style27">
                                    <asp:Label ID="LblRes1" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="LblEti2" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td id="TblEncuesta">
                                    <asp:Label ID="LblPor2" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LblRes2" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="LblEti3" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LblPor3" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LblRes3" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style27" style="background-color: #409131; color: #FFFFFF; font-family: verdana, Geneva, Tahoma, sans-serif;">Total</td>
                                <td class="auto-style27" style="background-color: #409131; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFFF">
                                    <asp:Label ID="LblPorTot" runat="server" ForeColor="White"></asp:Label>
                                </td>
                                <td class="auto-style27" style="background-color: #409131; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFFF">
                                    <asp:Label ID="LblResTot" runat="server" ForeColor="White"></asp:Label>
                                </td>
                            </tr>
                        </table>
                        <asp:Button ID="BtnExportar" runat="server" ALIGN="right" Text="Exportar" />
                    </asp:Panel>
                                
                                
                            </td>
                <td class="auto-style29">
                    </td>
            </tr>
      
            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style4">
                
    
                    <asp:GridView ID="dtggeneral" runat="server" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    </asp:GridView>

                    <asp:GridView ID="dtggeneralPorcentajes" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" EnableModelValidation="True" ForeColor="Black" GridLines="Horizontal" SelectedIndex="3">
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                        <HeaderStyle BackColor="#4E6228" Font-Bold="True" ForeColor="#F7F7F7" />
                        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#4E6228" Font-Bold="True" ForeColor="#F7F7F7" />
                    </asp:GridView>
                </td>
                <td class="auto-style3">
                    &nbsp;</td>

            </tr>
      
        </table>
    
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" />
        <p class="auto-style24">
            
                &nbsp;</p>
    </form>
</body>
</html>
