<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InformeInconsistencias.aspx.vb" Inherits="digitacion.InformeInconsistencias" %>

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
     
        .auto-style29 {
        width: 24%;
    }
         
        .auto-style31 {
        width: 15%;
    }
         
        .auto-style36 {
        width: 13%;
    }
    .auto-style45 {
        width: 14%;
        height: 24px;
    }
    .auto-style47 {
        width: 20%;
        height: 24px;
    }
    .auto-style48 {
        width: 20%;
    }
    .auto-style49 {
        width: 16%;
    }
    .auto-style51 {
        width: 19%;
    }
    .auto-style52 {
        width: 19%;
        height: 24px;
    }
    .auto-style53 {
        width: 14%;
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
                        style="font-size: medium; font-style: italic">Informe De Inconsistencias Datos</asp:Label>
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
                            <td class="auto-style22">Fecha Inicial :</td>
                            <td class="auto-style18">
                                <asp:TextBox ID="TxtFecha_Inicio" runat="server" Width="90px" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                            </td>       
                            <td class="auto-style26">Fecha Final :</td>
                                        <td class="auto-style27">
                                <asp:TextBox ID="TxtFecha_Fin" runat="server" Width="90px" MaxLength="10" placeholder="DD/MM/YYYY" style="margin-left: 0px"></asp:TextBox>
                            </td>
                            <td class="auto-style17">
                              <asp:Button ID="Colsultar" runat="server" Text="Colsultar" />
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #003300;" 
                    valign="top" class="style9">
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
                            <td class="auto-style49" border="0" style="border-style: none"></td>
                            <td bgcolor="64984A" class="auto-style36" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">
                                <center>Día</center></td>
                            <td bgcolor="64984A" class="auto-style48" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">                                
                                <center>Inconsistencias</center></td>
                            <td bgcolor="64984A" class="auto-style51" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">
                                <center>Gestión</center></td>
                            <td bgcolor="64984A" class="auto-style53" style="border-color: #333333; border-width: thin; color: #FFFFFF; border-top-style: groove; border-right-style: groove; border-left-style: groove;">                                
                                <center>Porcentaje</center></td>
                            <td class="style8" style="border-style: none"></td>
                        </tr>
                        <tr>
                            <td class="auto-style49" border="0" style="border-style: none"></td>
                            <td class="auto-style36" bgcolor="C1DFBE" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">
                                <center><asp:Label ID="lblFecha1" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style47" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">                                
                                <center><asp:Label ID="lblInco1" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style52" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">
                                <center><asp:Label ID="lblGes1" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style45" style="border-color: #333333; border-width: thin; color: #FFFFFF; border-top-style: groove; border-right-style: groove; border-left-style: groove;">                                
                                <center><asp:Label ID="lblporcen1" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style29" border="0" style="border-style: none"></td>
                            
                        </tr>
                        <tr>
                            <td class="auto-style49" border="0" style="border-style: none"></td>
                            <td class="auto-style36" bgcolor="C1DFBE" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">
                                <center><asp:Label ID="lblFecha2" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style47" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">                                
                                <center><asp:Label ID="lblInco2" runat="server" ForeColor="Black"></asp:Label></center></td>
                            
                            <td class="auto-style52" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">
                                <center><asp:Label ID="lblGes2" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style45" style="border-color: #333333; border-width: thin; color: #FFFFFF; border-top-style: groove; border-right-style: groove; border-left-style: groove;">                                
                                <center><asp:Label ID="lblporcen2" runat="server" ForeColor="Black"></asp:Label></center></td>
                           
                            <td class="auto-style29" border="0" style="border-style: none"></td>
                        </tr>
                         <tr>
                             <td class="auto-style49" border="0" style="border-style: none"></td>
                            <td class="auto-style36" bgcolor="C1DFBE" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">
                                <center><asp:Label ID="lblFecha3" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style47" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">                                
                                <center><asp:Label ID="lblInco3" runat="server" ForeColor="Black"></asp:Label></center></td>
                            
                            <td class="auto-style52" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">
                                <center><asp:Label ID="lblGes3" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style45" style="border-color: #333333; border-width: thin; color: #FFFFFF; border-top-style: groove; border-right-style: groove; border-left-style: groove;">                                
                                <center><asp:Label ID="lblporcen3" runat="server" ForeColor="Black"></asp:Label></center></td>
                             <td class="auto-style29" border="0" style="border-style: none"></td>
                            
                        </tr>
                          <tr>
                              <td class="auto-style49" border="0" style="border-style: none"></td>
                            <td class="auto-style36" bgcolor="C1DFBE" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">
                                <center><asp:Label ID="lblFecha4" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style47" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">                                
                                <center><asp:Label ID="lblInco4" runat="server" ForeColor="Black"></asp:Label></center></td>
                            
                            <td class="auto-style52" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">
                                <center><asp:Label ID="lblGes4" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style45" style="border-color: #333333; border-width: thin; color: #FFFFFF; border-top-style: groove; border-right-style: groove; border-left-style: groove;">                                
                                <center><asp:Label ID="lblporcen4" runat="server" ForeColor="Black"></asp:Label></center></td>
                              <td class="auto-style29" border="0" style="border-style: none"></td>
                            
                        </tr>
                        <tr>
                            <td class="auto-style49" border="0" style="border-style: none"></td>
                            <td class="auto-style36" bgcolor="C1DFBE" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">
                                <center><asp:Label ID="lblFecha5" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style47" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">                                
                                <center><asp:Label ID="lblInco5" runat="server" ForeColor="Black"></asp:Label></center></td>
                            
                            <td class="auto-style52" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">
                               <center><asp:Label ID="lblGes5" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style45" style="border-color: #333333; border-width: thin; color: #FFFFFF; border-top-style: groove; border-right-style: groove; border-left-style: groove;">                                
                                <center><asp:Label ID="lblporcen5" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style29" border="0" style="border-style: none"></td>
                            
                        </tr>
                        <tr>
                            <td class="auto-style49" border="0" style="border-style: none"></td>
                            <td class="auto-style36" bgcolor="C1DFBE" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">
                                <center><asp:Label ID="lblFecha6" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style47" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">                                
                                <center><asp:Label ID="lblInco6" runat="server" ForeColor="Black"></asp:Label></center></td>
                            
                            <td class="auto-style52" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">
                               <center><asp:Label ID="lblGes6" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style45" style="border-color: #333333; border-width: thin; color: #FFFFFF; border-top-style: groove; border-right-style: groove; border-left-style: groove;">                                
                                <center><asp:Label ID="lblporcen6" runat="server" ForeColor="Black"></asp:Label></center></td>
                            
                            <td class="auto-style29" border="0" style="border-style: none"></td>
                        </tr>
                         <tr>
                            <td class="auto-style49" border="0" style="border-style: none"></td>
                            <td class="auto-style36" bgcolor="C1DFBE" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">
                                <center><asp:Label ID="lblFecha7" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style47" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">                                
                                <center><asp:Label ID="lblInco7" runat="server" ForeColor="Black"></asp:Label></center></td>
                            
                            <td class="auto-style52" style="border-color: #000000; border-width: thin; color: #FFFFFF; border-top-style: groove; border-left-style: groove;">
                                <center><asp:Label ID="lblGes7" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style45" style="border-color: #333333; border-width: thin; color: #FFFFFF; border-top-style: groove; border-right-style: groove; border-left-style: groove;">                                
                                <center><asp:Label ID="lblporcen7" runat="server" ForeColor="Black"></asp:Label></center></td>
                            
                            <td class="auto-style29" border="0" style="border-style: none"></td>
                        </tr>
                        <tr>
                            <td class="auto-style49" border="0" style="border-style: none"></td>
                            <td class="auto-style36" bgcolor="64984A" style="border-color: #000000; border-style: groove none groove groove; border-top-width: thin; border-left-width: thin; border-bottom-width: thin;">
                                <center><asp:Label ID="lblTotal" runat="server" ForeColor="White">Total</asp:Label></center></td>
                            <td class="auto-style47" bgcolor="64984A" style="border-color: #000000; border-style: groove none groove groove; border-top-width: thin; border-left-width: thin; border-bottom-width: thin;">                                
                                <center><asp:Label ID="lblTotalinco" runat="server" ForeColor="White"></asp:Label></center></td>
                            </td>
                            <td class="auto-style52" bgcolor="64984A" style="border-color: #000000; border-style: groove none groove groove; border-top-width: thin; border-left-width: thin; border-bottom-width: thin;">
                                <center><asp:Label ID="lblTotalges" runat="server" ForeColor="White"></asp:Label></center></td>
                            <td class="auto-style45" bgcolor="64984A" style="border: thin groove #000000;">                                
                                <center><asp:Label ID="lblTotalpor" runat="server" ForeColor="White"></asp:Label></center></td>
                            </td>
                            <td class="auto-style29" border="0" style="border-style: none"></td>
                        </tr>
                        </table>
                                
                <td class="celdasder">
                    &nbsp;</td>
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
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" 
                        GridLines="None" Width="100%" style="font-size: x-small; margin-left: 0px; margin-right: 0px;" EnableModelValidation="True" PageSize="80" Height="16px" Align="Center" Visible="False" SelectedIndex="7">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" HorizontalAlign="Center"/>
                        <FooterStyle BackColor="#669900" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#437320" Font-Bold="True" ForeColor="White"/>
                        <HeaderStyle BackColor="#437320" Font-Bold="True" ForeColor="White" />
                                    <Columns>
                                        <asp:BoundField DataField="Dia" HeaderText="Dia"/>
                                        <asp:BoundField DataField="Inconsistencia" HeaderText="Inconsistencia" />
                                        <asp:BoundField DataField="Gestion" HeaderText="Gestion" />
                                        <asp:BoundField DataField="Porcentaje" HeaderText="Porcentaje" />
                                    </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>

                    
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

