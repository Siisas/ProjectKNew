<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PollaMundialista.aspx.vb" Inherits="digitacion.PollaMundialista" %>

<%@ Register Src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ERP Kamilion</title>

  <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <script type="text/jscript">
      $(function () {
          $("#txtFechaInicio").datepicker();
          $('#txtFechaInicio').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
  </script>
  <script type="text/jscript">
      $(function () {
          $("#txtFechasolucion").datepicker();
          $('#txtFechasolucion').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
  </script>
  <script type="text/jscript">
      $(function () {
          $("#TxtFechaConsulta1").datepicker();
          $('#TxtFechaConsulta1').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
  </script>
  <script type="text/jscript">
      $(function () {
          $("#TxtFechaConsulta2").datepicker();
          $('#TxtFechaConsulta2').datepicker('option', { dateFormat: 'dd/mm/yy' });
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
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 10%;
            background: #E2E8FA;
        }
        .style7
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 28%;
            background: #E2E8FA;
        }
        .style8
        {
            width: 28%;
        }
        .style9
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 19%;
            background: #E2E8FA;
        }
        .style10
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 6%;
            background: #E2E8FA;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <table style="width:100%; height: 100%">
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                    <table style="border-style: outset; border-width: 1px; width:100%">
                        <tr>
                            <td style="width:20%">
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
                <td class="style4">
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
                <td class="style4">
                    <asp:Label ID="lblmsg0" runat="server" 
                        style="font-size: medium; font-style: italic">Polla Mundialista Kamilion</asp:Label>
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
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <center>
                        <table cellpadding="1" cellspacing="1">
                        <tr>
                        <td colspan="1">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" colspan="2">
                            <center><asp:Label ID="LblTitulo_Premiacion" runat="server" Text="Tabla de Premiacion" Font-Size="X-Large"></asp:Label></center></td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                <center>Puesto</center></td>
                            <td class="textotittabla">
                                <center>Premio</center></td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                <center>1º</center></td>
                            <td class="celdascons">
                                <center>$600.000</center></td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                <center>2º</center></td>
                            <td class="celdascons">                                
                                <center>$400.000</center></td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                <center>3º</center></td>
                            <td class="celdascons">                                
                                <center>$300.000</center></td>
                        </tr> 
                        <tr>
                            <td class="textotittabla">
                                <center>4º</center></td>
                            <td class="celdascons">                                
                                <center>$150.000</center></td>
                        </tr> 
                        <tr>
                            <td class="textotittabla">
                                <center>5º</center></td>
                            <td class="celdascons">                                
                                <center>$50.000</center></td>
                        </tr>                                    
                        </table>
                        </td>
                        <td colspan="1">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" colspan="2">
                            <center><asp:Label ID="Label4" runat="server" Text="Normas para los Resultados del mundial" Font-Size="X-Large"></asp:Label></center></td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                <center>Normas</center></td>
                            <td class="textotittabla">
                                <center>Observacion</center></td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                <center>1º</center></td>
                            <td class="celdascons">
                                Registrar el Marcador del encuentro antes de que comience el partido</td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                <center>2º</center></td>
                            <td class="celdascons">                                
                                Por cada acierto en el "GANADOR" se sumaran 5 pts</td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                <center>3º</center></td>
                            <td class="celdascons">                                
                                Por cada acierto en el "MARCADOR" se sumaran 3 pts mas</td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                <center>4º</center></td>
                            <td class="celdascons">                                
                                Apoyar a COLOMBIA</td>
                        </tr>
                        </table>
                        </td>
                        </tr>
                        <tr>
                        <td colspan="2">
                        <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" colspan="6">
                            <center><asp:Label ID="Label3" runat="server" Text="Encuentros de la fecha" 
                                    Font-Size="Large"></asp:Label>
                                <asp:Label ID="LblFecha_Actual" runat="server" Font-Overline="False" 
                                    Font-Size="Large"></asp:Label>
                            </center></td>
                        </tr>                        
                        <tr>
                            <td class="style6">
                                <center>Grupo</center></td>
                            <td class="style7" colspan="2">
                                <center>Equipo Nº1</center></td>
                            <td class="style10">
                                <center>VS</center></td>
                            <td class="style7" colspan="2">
                                <center>Equipo Nº2</center></td>
                        </tr>                        
                        <tr>
                            <td class="style6">
                                <center><asp:Label ID="LblGrupo1" runat="server"></asp:Label></center>
                            </td>
                            <td class="textotittabla">
                                <center><asp:Label ID="LblFecha1" runat="server"></asp:Label></center>
                            </td>
                            <td class="style8">
                                <center><table border="2" >
                                <tr>
                                <td>
                                <asp:Image ID="ImgFecha1" runat="server" /><br />
                                </td>
                                </tr>
                                </table>
                                </td></center>
                            <td class="style10">
                                <center>VS</center></td>
                            <td class="style9">
                                <center><asp:Label ID="LblFecha11" runat="server"></asp:Label></center>
                            </td>
                            <td class="celdascons">
                               <center><table border="2" >
                                <tr>
                                <td>
                                <asp:Image ID="ImgFecha11" runat="server" /><br />
                                </td>
                                </tr>
                                </table>
                                </td></center>
                        </tr>
                        <tr>                        
                            <td class="style6">
                                <center><asp:Label ID="LblGrupo2" runat="server"></asp:Label></center>
                            </td>
                            <td class="textotittabla">
                                <center><asp:Label ID="LblFecha2" runat="server"></asp:Label></center>
                            </td>
                            <td class="style8">
                                <center><table border="2" >
                                <tr>
                                <td>
                                <asp:Image ID="ImgFecha2" runat="server" /><br />
                                </td>
                                </tr>
                                </table>
                                </td></center>
                            <td class="style10">
                                <center>VS</center></td>
                            <td class="style9">
                                <center><asp:Label ID="LblFecha22" runat="server"></asp:Label></center>
                            </td>
                            <td class="celdascons">
                                <center><table border="2" >
                                <tr>
                                <td>
                                <asp:Image ID="ImgFecha22" runat="server" /><br />
                                </td>
                                </tr>
                                </table>
                                </td></center>
                        </tr>
                        <tr>                        
                            <td class="style6">
                                <center><asp:Label ID="LblGrupo3" runat="server"></asp:Label></center>
                            </td>
                            <td class="textotittabla">
                                <center><asp:Label ID="LblFecha3" runat="server"></asp:Label></center>
                            </td>
                            <td class="style8">
                                <center><table border="2" >
                                <tr>
                                <td>
                                <asp:Image ID="ImgFecha3" runat="server" /><br />
                                </td>
                                </tr>
                                </table>
                                </td></center>
                            <td class="style10">
                                <center>VS</center></td>
                            <td class="style9">
                                <center><asp:Label ID="LblFecha33" runat="server"></asp:Label></center>
                            </td>
                            <td class="celdascons">
                                <center><table border="2" >
                                <tr>
                                <td>
                                <asp:Image ID="ImgFecha33" runat="server" /><br />
                                </td>
                                </tr>
                                </table>
                                </td></center>
                        </tr> 
                        <tr>
                            <td class="style6">
                                <center><asp:Label ID="LblGrupo4" runat="server"></asp:Label></center>
                            </td>
                            <td class="textotittabla">
                                <center><asp:Label ID="LblFecha4" runat="server"></asp:Label></center>
                            </td>
                            <td class="style8">
                                <center><table border="2" >
                                <tr>
                                <td>
                                <asp:Image ID="ImgFecha4" runat="server" /><br />
                                </td>
                                </tr>
                                </table>
                                </td></center>
                            <td class="style10">
                                <center>VS</center></td>
                            <td class="style9">
                                <center><asp:Label ID="LblFecha44" runat="server"></asp:Label></center>
                            </td>
                            <td class="celdascons">
                                <center><table border="2" >
                                <tr>
                                <td>
                                <asp:Image ID="ImgFecha44" runat="server" /><br />
                                </td>
                                </tr>
                                </table>
                                </td></center>
                        </tr>
                        </table>
                        </td>
                        </tr>
                        </table>
                        </center>
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    Pronostica tu Resultado</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" colspan="4">
                                <center>
                                    <asp:Label ID="Label2" runat="server" Text="ENCUENTRO" 
                                        Font-Size="Large"></asp:Label></center>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Grupo</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlGrupo" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem Value="A">A</asp:ListItem>
                                    <asp:ListItem Value="B">B</asp:ListItem>
                                    <asp:ListItem Value="C">C</asp:ListItem>
                                    <asp:ListItem Value="D">D</asp:ListItem>
                                    <asp:ListItem Value="E">E</asp:ListItem>
                                    <asp:ListItem Value="F">F</asp:ListItem>
                                    <asp:ListItem>G</asp:ListItem>
                                    <asp:ListItem>H</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Partido</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlPartido" runat="server" AutoPostBack="True">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem Value="1">Partido 1</asp:ListItem>
                                    <asp:ListItem Value="2">Partido 2</asp:ListItem>
                                    <asp:ListItem Value="3">Partido 3</asp:ListItem>
                                    <asp:ListItem Value="4">Partido 4</asp:ListItem>
                                    <asp:ListItem Value="5">Partido 5</asp:ListItem>
                                    <asp:ListItem Value="6">Partido 6</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Button ID="BtnConsulta" runat="server" Text="Consultar" />
                            </td>
                        </tr>
                        </table>
                        <br />
                        <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" colspan="4">
                                <center><asp:Label ID="Label1" runat="server" Text="EQUIPOS QUE SE ENFRENTAN" 
                                        Font-Size="Large"></asp:Label></center>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Equipo 
                                Nº 1</td>
                            <td class="celdascons">
                            <center>
                                <asp:Label ID="LblEquipo1" runat="server"></asp:Label>
                                <table border="2" >
                                <tr>
                                <td>
                                <asp:Image ID="ImgEquipo1" runat="server" /><br />
                                </td>
                                </tr>
                                </table>
                            </center>
                            </td>
                            <td class="textotittabla">
                                Equipo Nº 2</td>
                            <td class="celdascons">
                            <center>
                                <asp:Label ID="LblEquipo2" runat="server"></asp:Label>
                                <table border="2">
                                <tr>
                                <td>
                                <asp:Image ID="ImgEquipo2" runat="server" /><br />
                                </td>
                                </tr>
                                </table>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Marcador</td>
                            <td class="celdascons">                                
                                <center><asp:TextBox ID="TxtResultado1" runat="server" Width="10%" MaxLength="2"></asp:TextBox></center>
                            </td>
                            <td class="textotittabla">
                                Marcador</td>
                            <td class="celdascons">
                                <center><asp:TextBox ID="TxtResultado2" runat="server" Width="10%" MaxLength="2"></asp:TextBox></center>
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <asp:Button ID="btnguardar" runat="server" Text="Guardar" style="height: 26px" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    Mis Resultados&nbsp;
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Grupo</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlGrupoConsulta" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem Value="A">A</asp:ListItem>
                                    <asp:ListItem Value="B">B</asp:ListItem>
                                    <asp:ListItem Value="C">C</asp:ListItem>
                                    <asp:ListItem Value="D">D</asp:ListItem>
                                    <asp:ListItem Value="E">E</asp:ListItem>
                                    <asp:ListItem Value="F">F</asp:ListItem>
                                    <asp:ListItem>G</asp:ListItem>
                                    <asp:ListItem>H</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Partido</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlPartidoConsulta" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem Value="1">Partido 1</asp:ListItem>
                                    <asp:ListItem Value="2">Partido 2</asp:ListItem>
                                    <asp:ListItem Value="3">Partido 3</asp:ListItem>
                                    <asp:ListItem Value="4">Partido 4</asp:ListItem>
                                    <asp:ListItem Value="5">Partido 5</asp:ListItem>
                                    <asp:ListItem Value="6">Partido 6</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        </table>
                    <asp:Button ID="BtnConsultar_Resultados" runat="server" 
                        Text="Consultar Pronostico" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
    
                    <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="1000" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Grupo" HeaderText="Grupo" />
                            <asp:BoundField DataField="Partido" HeaderText="Partido" />
                            <asp:BoundField DataField="Equipo1" HeaderText="Equipo1" />
                            <asp:BoundField DataField="Resultado1" HeaderText="Marcador 1" />
                            <asp:BoundField DataField="Equipo2" HeaderText="Equipo2" />
                            <asp:BoundField DataField="Resultado2" HeaderText="Marcador 2" />
                            <asp:BoundField DataField="Fc_Reg" HeaderText="Fecha de Registro" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
        </table>
    
    </form>
</body>
</html>
