<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Acumulado_Voz.aspx.vb" Inherits="digitacion.Acumulado_Voz" %>

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
     
        .auto-style17 {
            width: 14px;
            }
     
        .auto-style18 {
        width: 57px;
        }
     
        .auto-style22 {
        font-family: Arial, Helvetica, sans-serif;
        font-size: small;
        color: #000042;
        font-weight: bold;
        width: 18%;
        background: #E2E8FA;
        }
     
        .auto-style26 {
        font-family: Arial, Helvetica, sans-serif;
        font-size: small;
        color: #000042;
        font-weight: bold;
        width: 83px;
        background: #E2E8FA;
        }
     
        .auto-style27 {
        width: 42px;
        }
     
        .auto-style31 {
        width: 15%;
    }
         
        .auto-style63 {
        height: 24px;
    }
    .auto-style66 {
        width: 15%;
        height: 24px;
    }
    .auto-style71 {
        width: 13%;
    }
    .auto-style72 {
        width: 13%;
        height: 24px;
    }
    .auto-style73 {
        width: 16%;
    }
    .auto-style74 {
        width: 10%;
    }
    .auto-style75 {
        width: 10%;
        height: 24px;
    }
    .auto-style76 {
        width: 12%;
    }
    .auto-style77 {
        width: 12%;
        height: 24px;
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
                        style="font-size: medium; font-style: italic">Informe Acumulado De Voz</asp:Label>
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
                            <td class="auto-style18">
                                <center><asp:TextBox ID="TxtFecha_Inicio" runat="server" Width="90px" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox></center>
                            </td>       
                            <td class="auto-style26"><center>Fecha Final :</center></td>
                                        <td class="auto-style27">
                                <center><asp:TextBox ID="TxtFecha_Fin" runat="server" Width="90px" MaxLength="10" placeholder="DD/MM/YYYY" style="margin-left: 0px"></asp:TextBox></center>
                            </td>
                            <td class="auto-style17">
                              <center><asp:Button ID="Colsultar" runat="server" Text="Colsultar" /></center>
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
                    <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        
                        <tr>
                            <td bgcolor="64984A" class="auto-style73" style="color: #FFFFFF; background-color: #125EB4; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: x-small;">
                                <center>INGRESOS A MESA DE SOPORTE</center></td>
                            <td bgcolor="64984A" class="auto-style31" style="color: #FFFFFF; background-color: #125EB4; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: x-small;">                                
                                <center>TOTAL CASOS</center></td>
                            <td bgcolor="64984A" class="auto-style31" style="color: #FFFFFF; background-color: #125EB4; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: x-small;">
                                <center>ASOCIADOS A RED</center></td>
                            <td bgcolor="64984A" style="color: #FFFFFF; background-color: #125EB4; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: x-small;">                                
                                <center>%</center></td>
                            <td bgcolor="64984A" class="auto-style76" style="color: #FFFFFF; background-color: #125EB4; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: x-small;">                                
                                <center>TECN/2G</center></td>
                            <td bgcolor="64984A" class="auto-style74" style="color: #FFFFFF; background-color: #125EB4; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: x-small;">                                
                                <center>% 2G</center></td>
                            <td bgcolor="64984A" class="auto-style71" style="color: #FFFFFF; background-color: #125EB4; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: x-small;">                                
                                <center>TECN/3G</center></td>
                            <td bgcolor="64984A" class="auto-style74" style="color: #FFFFFF; background-color: #125EB4; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: x-small;">                                
                                <center>% 3G</center></td>
                        </tr>
                        <tr>
                            <td bgcolor="64984A" class="auto-style73" style="color: #FFFFFF; background-color: #125EB4; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: x-small;">
                                <center><asp:Label ID="lblVOZ" runat="server" Text="VOZ" Font-Size="X-Small"></asp:Label></center></td>
                            <td class="auto-style66" style="background-color: #D7EBFF;">                                
                                <center><asp:Label ID="lblTlvoz" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style66" style="background-color: #D7EBFF;">                                
                                <center><asp:Label ID="lblvozred" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style63" style="background-color: #D7EBFF;">                                
                                <center><asp:Label ID="lblporvoz" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style77" style="background-color: #D7EBFF;">                                
                                <center><asp:Label ID="lblTec2g" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style75" style="background-color: #D7EBFF;">                                
                                <center><asp:Label ID="lblporcen2g" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style72" style="background-color: #D7EBFF;">
                                <center><asp:Label ID="lblTec3g" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style75" style="background-color: #D7EBFF;">                                
                                <center><asp:Label ID="lblporcen3g" runat="server" ForeColor="Black"></asp:Label></center></td>
                                                 
                        </tr>
                        <tr>
                            <td bgcolor="64984A" class="auto-style73" style="color: #FFFFFF; background-color: #125EB4; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: x-small;">
                                <center><asp:Label ID="lblotros" runat="server" Text="OTROS SERVICIOS - BUZON - SMS" Font-Size="X-Small"></asp:Label></center></td>
                            <td class="auto-style66" style="background-color: #D7EBFF;">                                
                                <center><asp:Label ID="lblTlotros" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style66" style="background-color: #D7EBFF;">                                
                                <center><asp:Label ID="lblotrosred" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style63" style="background-color: #D7EBFF;">                                
                                <center><asp:Label ID="lblporotros" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style77" style="background-color: #D7EBFF;">                                
                                <center></center></td>
                            <td class="auto-style75" style="background-color: #D7EBFF;">                                
                                <center></center></td>
                            <td class="auto-style72" style="background-color: #D7EBFF;">
                                <center></center></td>
                            <td class="auto-style75" style="background-color: #D7EBFF;">                                
                                <center></center></td>
                         </tr>
                         <tr>
                            <td class="auto-style73" bgcolor="64984A" style="background-color: #125EB4; color: #FFFFFF; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: x-small;">
                                <center><asp:Label ID="lblTotal" runat="server" Text="Total" Font-Size="Small"></asp:Label></center></td>
                            <td class="auto-style66" bgcolor="64984A" style="background-color: #D7EBFF; color: #000000;">                                
                                <center><asp:Label ID="lblTlcasos" runat="server" ForeColor="Black"></asp:Label></center></td>
                            </td>
                            <td class="auto-style66" bgcolor="64984A" style="background-color: #D7EBFF; color: #000000;">
                                <center><asp:Label ID="lblTlred" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style63" bgcolor="64984A" style="background-color: #D7EBFF; color: #000000;">                                
                                <center></center></td>
                            <td class="auto-style77" bgcolor="64984A" style="background-color: #D7EBFF; color: #000000;">                                
                                <center></center></td>
                        <td class="auto-style75" bgcolor="64984A" style="background-color: #D7EBFF; color: #000000;">                                
                                <center></center></td>
                        <td class="auto-style72" bgcolor="64984A" style="background-color: #D7EBFF; color: #000000;">                                
                                <center></center></td>
                        <td class="auto-style75" bgcolor="64984A" style="background-color: #D7EBFF; color: #000000;">                                
                                <center></center></td>    
                        </td>
                        </tr>
                        </table>
                                
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
        <tr>
                
                <td class="style8">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #003300;" 
                    valign="top" class="style9">
                    &nbsp;</td>
                <td class="style8">
                </td>
            </tr>
        <tr>
                
                <td class="style8">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #003300;" 
                    align="right" class="style9">
                    <asp:Button ID="Exportar" runat="server" Text="Exportar"/>
                </td>
                <td class="style8">
                </td>
            </tr>
                <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    
                    
                                <asp:GridView ID="GridView1" runat="server" AllowPaging="True"
                        AutoGenerateColumns="False" CellPadding="10" ForeColor="Black" 
                        GridLines="None" Width="100%" style="font-size: x-small; margin-left: 0px; margin-right: 0px;" EnableModelValidation="True" PageSize="80" Height="16px" Align="Center" CellSpacing="1">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" HorizontalAlign="Center"/>
                        <FooterStyle BackColor="#3366CC" Font-Bold="True" ForeColor="White" Font-Italic="False" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#125EB4" Font-Bold="True" ForeColor="White"/>
                        <HeaderStyle BackColor="#125EB4" Font-Bold="False" ForeColor="White" HorizontalAlign="Center" />
                                    <Columns>
                                        <asp:BoundField DataField="INGRESOS_MESA_SOPORTE" HeaderText="INGRESOS A MESA DE SOPORTE">
                                        <ItemStyle BackColor="#125EB4" ForeColor="White" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="TOTAL_CASOS" HeaderText="TOTAL CASOS" />
                                        <asp:BoundField DataField="ASOCIADOS_RED" HeaderText="ASOCIADOS A RED" />
                                        <asp:BoundField DataField="Porcentaje_red" HeaderText="%" />
                                        <asp:BoundField DataField="TECN_2G" HeaderText="TECN/2G" />
                                        <asp:BoundField DataField="Porcentaje_2g" HeaderText="% 2G" />
                                        <asp:BoundField DataField="TECN_3G" HeaderText="TECN/3G" />
                                        <asp:BoundField DataField="Porcentaje_3g" HeaderText="% 3G" />
                                    </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>

                    
                    </td>
                <td class="celdasder" aria-autocomplete="inline">
                    &nbsp;</td>
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

