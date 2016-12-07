<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InformeBarriosVoz.aspx.vb" Inherits="digitacion.InformeBarriosVoz" %>

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
          $("#txtFecha_Inicio").datepicker();
          $('#txtFecha_Inicio').datepicker('option', { dateFormat: 'dd/mm/yy' });
          $("#txtFecha_Fin").datepicker();
          $('#txtFecha_Fin').datepicker('option', { dateFormat: 'dd/mm/yy' });
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
     
        .style8
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 23px;
        }
        .style9
        {
            color: #000099;
            width: 15%;
            height: 23px;
        }
     
        .style10
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 22px;
        }
        .style11
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 22px;
        }
     
        .auto-style1 {
            width: 6%;
            height: 21px;
        }
             
        .auto-style9 {
            width: 18%;
            height: 21px;
        }
        #Text1 {
            width: 47px;
            margin-left: 8px;
            margin-bottom: 0px;
        }
     
        .auto-style15 {
            color: #000099;
            height: 23px;
        }
     
        .auto-style22 {
        font-family: Arial, Helvetica, sans-serif;
        font-size: small;
        color: #000042;
        font-weight: bold;
        width: 16%;
        background: #E2E8FA;
        }
     
        .auto-style31 {
        width: 15%;
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
                <td class="style10">
                    </td>
                <td class="style11">
                    <asp:Label ID="lblmsg0" runat="server" 
                        style="font-size: medium; font-style: italic">Informe Barrios Voz</asp:Label>
                </td>
                <td class="style10">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td valign="top" class="auto-style31">
                    <table class="style2">
                        <tr>
                            <td class="auto-style1">
                                <asp:Label ID="lblusuario" runat="server"></asp:Label>
                            </td>
                            <td class="auto-style9">
                                <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
                            </td>
                        </tr>
                        </table>
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        
                      <tr>
                            <td class="auto-style22"><center>Fecha Inicial :</center></td>
                            <td class="celdascons">
                                <center><asp:TextBox ID="txtFecha_Inicio" runat="server" Width="24%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtFecha_Inicio" ErrorMessage="Revise Fecha" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator></center>
                            </td>
                          <td class="auto-style22"><center>Fecha Final :</center></td>       
                            <td class="celdascons">
                                <center><asp:TextBox ID="txtFecha_Fin" runat="server" Width="24%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtFecha_Fin" ErrorMessage="Revise Fecha" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator></center>
                            </td>
                            </tr>
                    </table>
                <tr>
                
                <td class="style8">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #003300;" 
                    valign="top" class="style9">
                </td>
                <td class="style8">
                </td>
            </tr>
            <tr>
                
                <td class="style8">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #003300;" 
                    valign="top" class="style9">
            <center><asp:Button ID="Paso1" runat="server" Text="Paso1" />&nbsp
                    <asp:Button ID="Paso2" runat="server" Text="Paso2" Visible="False" />&nbsp
                    <asp:Button ID="Generar" runat="server" Text="Generar" Visible="False" />&nbsp
                    <asp:Button ID="Consultar" runat="server" Text="Consultar" Visible="False" /></center>
                </td>
                <td class="style8">
                </td>
            </tr>
             <tr>
                <td class="style8">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style15"><center>Información</center></td>
                <td class="style8"></td>
            </tr>
             <tr>
                
                <td class="style8">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #000099;" 
                    valign="top" class="style9"><center><asp:Label ID="lblFcini" runat="server" ForeColor="#000099"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;AL&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblFcfin" runat="server" ForeColor="#000099"></asp:Label></center>
                </td>
                <td class="style8">
                </td>
            </tr>
                <td class="style8">
                </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #003300;" align="right" class="style9"><asp:Button ID="Exportar" runat="server" Text="Exportar" Visible="False"/>
                </td>
                <td class="style8">
                </td>
            </tr>
            <tr>
                
                <td class="style8">
                    &nbsp;&nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #000099;" 
                    valign="top" class="style9">
                    <asp:Panel ID="Panel1" runat="server" style="margin-left: 218px" Width="356px">
                        Numero de registros: <asp:Label ID="lbltotal" runat="server" ForeColor="#000099"></asp:Label>
                    </asp:Panel>
                   </td>
                <td class="style8">
                </td>
            </tr>
                <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent" aria-orientation="horizontal" colspan="1">
                    
                    
                                <center><asp:GridView ID="GridView1" runat="server" AllowPaging="True"
                        AutoGenerateColumns="False" CellPadding="8" ForeColor="Black" 
                        GridLines="None" Width="70%" style="font-size: x-small; margin-left: 0px; margin-right: 0px;" EnableModelValidation="True" PageSize="80" Height="16px" Align="Center" BackColor="Silver" BorderWidth="1px" CellSpacing="1">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" HorizontalAlign="Center"/>
                        <FooterStyle BackColor="#3366CC" Font-Bold="True" ForeColor="White" Font-Italic="False" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#125EB4" Font-Bold="True" ForeColor="White"/>
                        <HeaderStyle BackColor="#125EB4" Font-Bold="False" ForeColor="White" HorizontalAlign="Center" />
                                    <Columns>
                                        <asp:BoundField DataField="cas_fecha_registro" HeaderText="FECHA DE REGISTRO" />
                                        <asp:BoundField DataField="idcaso" HeaderText="CASOS" />
                                        <asp:BoundField DataField="nombremun" HeaderText="CIUDAD"/>
<asp:BoundField DataField="barrio" HeaderText="BARRIO" ApplyFormatInEditMode="True"></asp:BoundField>
                                        <asp:BoundField DataField="Tecnologia_Voz_01" HeaderText="TECNOLOGIA" />
                                        <asp:BoundField DataField="min_ac" HeaderText="N° MIN" />
                                        <asp:BoundField DataField="ÚltimoDetipificacion1" HeaderText="ULTIMA TIPIFICACION" />
                                        <asp:BoundField DataField="ÚltimoDecpd" HeaderText="ULTIMO DECPD" />
                                    </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView></center>

                    
                    </td>
                <td class="celdasder" aria-autocomplete="list">
                    &nbsp;</td>
                    <tr>
                
                <td class="style8">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #003300;" 
                    valign="top" class="style9">
                </td>
                <td class="style8">
                </td>
            </tr>
              <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent" aria-orientation="horizontal" colspan="1">
                    
                    
                                <center><asp:GridView ID="GridView2" runat="server" AllowPaging="True"
                        AutoGenerateColumns="False" CellPadding="8" ForeColor="Black" 
                        GridLines="None" Width="70%" style="font-size: x-small; margin-left: 0px; margin-right: 0px;" EnableModelValidation="True" PageSize="20000" Height="16px" Align="Center" BackColor="Silver" BorderWidth="1px" CellSpacing="1">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" HorizontalAlign="Center"/>
                        <FooterStyle BackColor="#3366CC" Font-Bold="True" ForeColor="White" Font-Italic="False" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#125EB4" Font-Bold="True" ForeColor="White"/>
                        <HeaderStyle BackColor="#125EB4" Font-Bold="False" ForeColor="White" HorizontalAlign="Center" />
                                    <Columns>
                                        <asp:BoundField DataField="cas_fecha_registro" HeaderText="FECHA DE REGISTRO" />
                                        <asp:BoundField DataField="idcaso" HeaderText="CASOS" />
                                        <asp:BoundField DataField="nombremun" HeaderText="CIUDAD"/>
<asp:BoundField DataField="barrio" HeaderText="BARRIO" ApplyFormatInEditMode="True"></asp:BoundField>
                                        <asp:BoundField DataField="Tecnologia_Voz_01" HeaderText="TECNOLOGIA" />
                                        <asp:BoundField DataField="min_ac" HeaderText="N° MIN" />
                                        <asp:BoundField DataField="ÚltimoDetipificacion1" HeaderText="ULTIMA TIPIFICACION" />
                                        <asp:BoundField DataField="ÚltimoDecpd" HeaderText="ULTIMO DECPD" />
                                    </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView></center>

                    
                    </td>
                <td class="celdasder" aria-autocomplete="list">
                    &nbsp;</td>
                    <tr>
                
                <td class="style8">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #003300;" 
                    valign="top" class="style9">
                </td>
                <td class="style8">
                </td>
            </tr>
              
            <tr>
                
                <td class="style8">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #003300;" 
                    valign="top" class="style9">
                </td>
                <td class="style8">
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
                <td class="celdascons" align="right">
                                &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <table bgcolor="" class="style1">
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </table>
    <div>
                        
                    </div>
    </form>
</body>
</html>
