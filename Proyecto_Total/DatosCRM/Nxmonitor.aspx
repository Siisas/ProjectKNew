<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Nxmonitor.aspx.vb" Inherits="digitacion.Nxmonitor" %>

<%@ Register Src="../menu.ascx" TagPrefix="uc1" TagName="menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Kamilion - ERP</title>
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
 
        
        .style1
        {
            width: 68%; 
height:99%;
        margin-left: 109px;
        margin-right: 0px;
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
     
        .auto-style26 {
        height: 14px;
        width: 244px;
    }
     
        .auto-style27 {
        font-family: Arial, Helvetica, sans-serif;
        font-size: small;
        color: #000042;
        font-weight: bold;
        width: 16%;
        background: #E2E8FA;
        height: 14px;
    }
         
        .auto-style28 {
        width: 536px;
    }
    .auto-style29 {
        width: 530px;
        text-align: center;
    }
         
        .auto-style30 {
        color: #000099;
        height: 23px;
    }
         
        .auto-style31 {
        width: 188px;
    }
         
        .auto-style32 {
        width: 536px;
        height: 24px;
    }
    .auto-style33 {
        width: 530px;
        text-align: center;
        height: 24px;
    }
    .auto-style34 {
        width: 536px;
        height: 30px;
    }
    .auto-style35 {
        width: 530px;
        text-align: center;
        height: 30px;
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
                    &nbsp;</td>
                <td class="style10">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td style="width:15%" valign="top">
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
                            <td class="auto-style27"> <center> Fecha :</center></td>
                            <td class="auto-style26">
                                <center><asp:TextBox ID="TxtFecha_inicio" runat="server" placeholder="DD/MM/YYYYY"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TxtFecha_inicio" ErrorMessage="Verifique la fecha" Type="Date" Operator="DataTypeCheck">*</asp:CompareValidator></center> 
                            </td>  
                            <td class="auto-style31">
                              <center style="width: 286px"><asp:Button ID="Buscar" runat="server" Text="Buscar" style="width: 61px" /></center>
                            </td>
                      </tr>                                        
                                                    
                    </table>
                <td class="celdasder">
                </td>
            <tr>
                <td class="style8">
                    </td>
                <td valign="top" class="auto-style30">


                    
                   <asp:Button ID="Exportar" runat="server" Text="Exportar" Visible="False"/>
                    </td>
                <td class="style8">
                    </td>
            
           
            </tr>
            <tr>
                
                <td class="style8">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #003300;" 
                    valign="top" class="style9">
                     <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        
                          <tr>
                            <td class="auto-style32" style="color: #000099; background-color: #00FFFF;">
                                  <center><asp:Label ID="lblMes" runat="server"></asp:Label></center>
                              </td>
                              <td class="auto-style33" style="color: #000099">
                                  <asp:Label ID="lblFecha" runat="server"></asp:Label>
                              </td>
                         </tr> 
                         <tr>
                            <td class="auto-style28" style="color: #000099; background-color: #00FFFF;">
                                <center><asp:Label ID="Lbltip1" runat="server" Text="Contactos de Soporte Dia"></asp:Label></center>
                                  
                            </td>
                              <td class="auto-style29" style="color: #000099">
                                  <asp:Label ID="lblfalla1" runat="server"></asp:Label>
                                  </td>
                         </tr> 
                   <tr>
                            <td class="auto-style28" style="color: #000099; background-color: #00FFFF;">
                                <center><asp:Label ID="Lblofnxm" runat="server" Text="Ofrecimientos Nx Monitor"></asp:Label></center>
                            </td>
                              <td class="auto-style29" style="color: #000099">
                                  <asp:Label ID="lblfalla2" runat="server"></asp:Label>
                                  </td>
                         </tr> 
                         <tr>
                            <td class="auto-style28" style="color: #000099; background-color: #00FFFF;">
                                 <center><asp:Label ID="LabofrC" runat="server" Text="% Ofrecimiento / Contacto"></asp:Label></center></td>
                              <td class="auto-style29" style="color: #000099; background-color: #C0C0C0;">
                                  <asp:Label ID="lblporcen1" runat="server"></asp:Label>
                                  </td>
                         </tr> 
                         <tr>
                            <td class="auto-style34" style="color: #000099">
                               <br />
                                <br />

                            </td>
                              <td class="auto-style35" style="color: #000099">
                                  <asp:Label ID="lblporcenfin" runat="server" Visible="False"></asp:Label>
                                  </td>
                         </tr> 
                           <tr>
                            <td class="auto-style28" style="color: #000099; background-color: #00FFFF;">
                                <center><asp:Label ID="LblTotalOfr" runat="server" Text="Total Ofrecimientos"></asp:Label></center>
                            </td>
                              <td class="auto-style29" style="color: #000099">
                                  <asp:Label ID="lblfalla4" runat="server"></asp:Label>
                                  </td>
                         </tr> 
                           <tr>
                            <td class="auto-style28" style="color: #000099; background-color: #00FFFF;">
                                <center><asp:Label ID="Lblinstmon" runat="server" Text="Instala Nx Monitor en Llamada"></asp:Label></center>
                            </td>
                              <td class="auto-style29" style="color: #000099">
                                  <asp:Label ID="lblfalla5" runat="server"></asp:Label>
                                  </td>
                         </tr> 
                           <tr>
                            <td class="auto-style28" style="color: #000099; background-color: #00FFFF;">
                               <center> <asp:Label ID="Lblotromomen" runat="server" Text="Informa Instalar Nx Monitor en otro Momento"></asp:Label></center> </td>
                              <td class="auto-style29" style="color: #000099">
                                  <asp:Label ID="lblfalla6" runat="server"></asp:Label>
                                  </td>
                         </tr> 
                           <tr>
                            <td class="auto-style28" style="color: #000099; background-color: #00FFFF;">
                               <center><asp:Label ID="Lblnointeresains" runat="server" Text="No le interesa instalar"></asp:Label> </center></td>
                              <td class="auto-style29" style="color: #000099">
                                  <asp:Label ID="lblfalla7" runat="server"></asp:Label>
                                  </td>
                         </tr> 
                           <tr>
                            <td class="auto-style28" style="color: #000099; background-color: #00FFFF;">
                               <center> <asp:Label ID="Lblprefllamendesp" runat="server" Text="Prefiere que lo llamen despues para asesoria de instalacion"></asp:Label></center></td>
                              <td class="auto-style29" style="color: #000099">
                                  <asp:Label ID="lblfalla8" runat="server"></asp:Label>
                                  </td>
                         </tr> 
                           <tr>
                            <td class="auto-style28" style="color: #000099; background-color: #00FFFF;">
                               <center> <asp:Label ID="Lblotrascausas" runat="server" Text="Otras causas"></asp:Label></center> </td>
                              <td class="auto-style29" style="color: #000099">
                                  <asp:Label ID="lblfalla9" runat="server"></asp:Label>
                                  </td>
                         </tr> 
                           <tr>
                            <td class="auto-style28" style="color: #000099; background-color: #FFCC99;">
                                <center> <asp:Label ID="Lbltotal" runat="server" Text="Total"></asp:Label></center></td>
                              <td class="auto-style29" style="color: #000099; background-color: #FFCC99;">
                                  <asp:Label ID="lblfalla10" runat="server"></asp:Label>
                                  </td>
                         </tr> 
                           <tr>
                            <td class="auto-style28" style="color: #000099">
                                <br />
                                <br />
                            </td>
                              <td class="auto-style29" style="color: #000099">
                                  </td>
                         </tr> 
                          <tr>
                            <td class="auto-style28" style="color: #000099; background-color: #FFCC99;">
                               <center> <asp:Label ID="Lblmetaacum" runat="server" Text="Meta Acumulada"></asp:Label></center> </td>
                              <td class="auto-style29" style="color: #000099; background-color: #FFCC99;">
                                  <asp:Label ID="lblfalla11" runat="server"></asp:Label>
                                  </td>
                         </tr> 
                          <tr>
                            <td class="auto-style28" style="color: #000099; background-color: #FFCC99;">
                                <center> <asp:Label ID="Lblmetadiaria" runat="server" Text="Meta Diaria"></asp:Label></center></td>
                              <td class="auto-style29" style="color: #000099; background-color: #FFCC99;">
                                  <asp:Label ID="lblfalla12" runat="server"></asp:Label>
                                  </td>
                         </tr> 
                          <tr>
                            <td class="auto-style28" style="color: #000099">
                                 <center> <asp:Label ID="Lblinsacumulado" runat="server" Text="Nx Monitor instalados acumulado"></asp:Label></center></td>
                              <td class="auto-style29" style="color: #000099">
                                  <asp:Label ID="lblfalla13" runat="server"></asp:Label>
                                  </td>
                         </tr> 
                          <tr>
                            <td class="auto-style28" style="color: #000099">
                                <center> <asp:Label ID="Lblinsdiario" runat="server" Text="Nx Monitor instalados diario"></asp:Label></center></td>
                              <td class="auto-style29" style="color: #000099">
                                  <asp:Label ID="lblfalla14" runat="server"></asp:Label>
                                  </td>
                         </tr> 
                          <tr>
                            <td class="auto-style28" style="color: #000099">
                                 <center> <asp:Label ID="Lblnxpotenciales" runat="server" Text="Nx Monitor Potenciales"></asp:Label></td>
                              <td class="auto-style29" style="color: #000099">
                                  <asp:Label ID="lblfalla15" runat="server"></asp:Label>
                                  </td>
                         </tr> 
                          <tr>
                            <td class="auto-style28" style="color: #000099; background-color: #00FFFF;">
                                <center> <asp:Label ID="Lblcumplmetad" runat="server" Text="Cumplimiento meta Diaria"></asp:Label> </td>
                              <td class="auto-style29" style="color: #000099; background-color: #C0C0C0;">
                                  <asp:Label ID="lblfalla16" runat="server"></asp:Label>
                                  </td>
                         </tr> 
                          <tr>
                            <td class="auto-style28" style="color: #000099; background-color: #00FFFF;">
                                 <center> <asp:Label ID="Lblcumpmacumu" runat="server" Text="Cumplimiento meta Acumulada"></asp:Label> </td>
                              <td class="auto-style29" style="color: #000099; background-color: #C0C0C0;">
                                  <asp:Label ID="lblfalla17" runat="server"></asp:Label>
                                </td>
                         </tr> 
                          <tr>
                            <td class="auto-style28" style="color: #000099; background-color: #00FFFF;">
                                 <center> <asp:Label ID="Lbldesacum" runat="server" Text="Desviacion de la meta acumulada"></asp:Label></td>
                              <td class="auto-style29" style="color: #000099; background-color: #FF0000;">
                                  <asp:Label ID="lblfalla18" runat="server"></asp:Label>
                                  </td>
                         </tr>  
                         </table> 

               

                <td class="style8">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700;" align="right">
                    
                    
                         <center><asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#33CCCC" 
                        GridLines="None" PageSize="18" Width="65%" style="font-size: x-small; margin-left: 0px;" EnableModelValidation="True" BackColor="Gray" BorderColor="Black" CellSpacing="2" SelectedIndex="12" Height="186px">
                        <%--ItemStyle BackColor="#33CCCC" ForeColor="White" />--%>
                         <HeaderStyle BackColor="Red" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        <Columns>
                             <asp:BoundField DataField="fcreg" HeaderText="fecha" >
                   <FooterStyle BackColor="#33CCFF" />
                             </asp:BoundField>
                          <asp:BoundField DataField="Requerimiento" HeaderText="Requerimiento" />
                            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />

                        </Columns>
                     <EditRowStyle BackColor="#33CCCC" BorderColor="Black" />
                       <FooterStyle BackColor="Silver" Font-Bold="True" ForeColor="#33CCCC" />
                           <HeaderStyle BackColor="#33CCCC" ForeColor="#E6E600" />
                        <PagerStyle BackColor="#999999" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#FFAC84" Font-Bold="True" ForeColor="Black" />
                    </asp:GridView></center>


                    
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
