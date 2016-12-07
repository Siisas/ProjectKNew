<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Tipo_Cliente_Datos.aspx.vb" Inherits="digitacion.Tipo_Cliente_Datos" %>

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
        width: 26px;
        }
     
        .auto-style22 {
        font-family: Arial, Helvetica, sans-serif;
        font-size: small;
        color: #000042;
        font-weight: bold;
        width: 16%;
        background: #E2E8FA;
        }
     
        .auto-style29 {
        width: 24%;
    }
         
        .auto-style31 {
        width: 15%;
    }
         
        .auto-style47 {
        width: 18%;
        height: 24px;
    }
    .auto-style51 {
        width: 14%;
    }
    .auto-style52 {
        width: 14%;
        height: 24px;
    }
             
        .auto-style55 {
        font-family: Arial, Helvetica, sans-serif;
        font-size: small;
        color: #000042;
        font-weight: bold;
        width: 79px;
        background: #E2E8FA;
    }
    .auto-style57 {
        width: 65px;
    }
    .auto-style60 {
        font-family: Arial, Helvetica, sans-serif;
        font-size: small;
        color: #000042;
        font-weight: bold;
        width: 80px;
        background: #E2E8FA;
    }
    .auto-style61 {
        width: 53px;
    }
         
        .auto-style62 {
        width: 10%;
    }
         
        .auto-style68 {
        width: 17%;
        height: 24px;
    }
    .auto-style69 {
        width: 17%;
    }
    .auto-style70 {
        width: 16%;
    }
    .auto-style71 {
        width: 16%;
        height: 24px;
    }
    .auto-style72 {
        width: 18%;
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
                        style="font-size: medium; font-style: italic">Tipo De Cliente</asp:Label>
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
                            <td class="auto-style55"><center>Dia :</center></td>
                                        <td class="auto-style57"><center><asp:RadioButton ID="RdbDia" runat="server" GroupName="TipoInfo" /></center>
                                </td>
                          <td class="auto-style60"><center>Mes :</center></td>
                                        <td class="auto-style61"><center><asp:RadioButton ID="RdbMes" runat="server" GroupName="TipoInfo" /></center>
                                </td>
                            <td class="auto-style17">
                              <center><asp:Button ID="Colsultar" runat="server" Text="Colsultar" style="margin-left: 0px" /></center>
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
                            <td class="auto-style62" border="0" style="border-style: none">&nbsp;</td>
                            <td bgcolor="64984A" class="auto-style70" style="background-color: #FFFFFF;">                                
                    <asp:Label ID="lblFecha" runat="server" Text=""></asp:Label>
                            </td>
                            <td bgcolor="64984A" class="auto-style72" style="background-color: #FFFFFF;">                                
                                &nbsp;</td>
                            <td bgcolor="64984A" class="auto-style51" style="background-color: #FFFFFF;">
                                &nbsp;</td>
                            <td bgcolor="64984A" class="auto-style69" style="background-color: #FFFFFF;">                                
                                &nbsp;</td>
                            <td bgcolor="64984A" class="auto-style70" style="background-color: #FFFFFF;">                                
                                &nbsp;</td>
                            <td class="style8" style="background-color: #FFFFFF;">&nbsp;</td>
                        </tr>
                        
                        <tr>
                            <td class="auto-style62" border="0" style="border-style: none"></td>
                            <td bgcolor="64984A" class="auto-style70" style="color: #FFFFFF; background-color: #3366CC;">                                
                                <center>Tipo Cliente</center></td>
                            <td bgcolor="64984A" class="auto-style72" style="color: #FFFFFF; background-color: #3366CC;">                                
                                <center>Prepago</center></td>
                            <td bgcolor="64984A" class="auto-style51" style="color: #FFFFFF; background-color: #3366CC;">
                                <center>Pospago</center></td>
                            <td bgcolor="64984A" class="auto-style69" style="color: #FFFFFF; background-color: #3366CC;">                                
                                <center>Empresarial</center></td>
                            <td bgcolor="64984A" class="auto-style70" style="color: #FFFFFF; background-color: #3366CC;">                                
                                <center>Total</center></td>
                            <td class="style8" style="border-style: none"></td>
                        </tr>
                        <tr>
                            <td class="auto-style62" border="0" style="border-style: none; color: #FFFFFF;"></td>
                            <td bgcolor="64984A" class="auto-style70" style="color: #FFFFFF; background-color: #3366CC;">                                
                                <center>Casos</center></td>
                            <td class="auto-style47" style="background-color: #99CCFF; color: #000000;">                                
                                <center><asp:Label ID="lblTlpre" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style52" style="background-color: #99CCFF; color: #000000;">
                                <center><asp:Label ID="lblTlpos" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style68" style="background-color: #99CCFF; color: #000000;">                                
                                <center><asp:Label ID="lblTlemp" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style71" bgcolor="white" style="background-color: #99CCFF; color: #000000;">                                
                                <center><asp:Label ID="lblTlcasos" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style29" border="0" style="border-style: none"></td>
                            
                        </tr>
                        <tr>
                            <td class="auto-style62" border="0" style="border-style: none"></td>
                            <td class="auto-style70" bgcolor="64984A" style="color: #FFFFFF; background-color: #3366CC;">
                                <center><asp:Label ID="lblTotal" runat="server" ForeColor="White">Porcentaje</asp:Label></center></td>
                            <td class="auto-style47" bgcolor="64984A" style="background-color: #99CCFF; color: #000000;">                                
                                <center><asp:Label ID="lblPorpre" runat="server" ForeColor="Black"></asp:Label></center></td>
                            </td>
                            <td class="auto-style52" bgcolor="64984A" style="background-color: #99CCFF; color: #000000;">
                                <center><asp:Label ID="lblPorpos" runat="server" ForeColor="Black"></asp:Label></center></td>
                            <td class="auto-style68" bgcolor="64984A" style="background-color: #99CCFF; color: #000000;">                                
                                <center><asp:Label ID="lblPoremp" runat="server" ForeColor="Black"></asp:Label></center></td>
                        <td class="auto-style71" bgcolor="64984A" style="background-color: #99CCFF; color: #000000;">                                
                                <center><asp:Label ID="lblTlpor" runat="server" ForeColor="Black"></asp:Label></center></td>
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
                    valign="top" class="style9">
                    &nbsp;</td>
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
