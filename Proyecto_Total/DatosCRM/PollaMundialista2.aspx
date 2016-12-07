<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PollaMundialista2.aspx.vb" Inherits="digitacion.PollaMundialista2" %>

<%@ Register Src="../menu.ascx" tagname="menu" tagprefix="uc1"  %>

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
        .textotittabla2
{
	font-family: Arial, Helvetica, sans-serif;
	font-size:small;
	color: #000042;
	font-weight: bold;
	background: #FFFFFF;
	width: 10%;
}
    .textotittabla3
{
	font-family: Arial, Helvetica, sans-serif;
	font-size:small;
	color: #000042;
	font-weight: bold;
	background: #FFFFFF;
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
        .style12
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 23px;
        }
        .style13
        {
            color: #000099;
            width: 80%;
            height: 23px;
        }
        .style14
        {
            width: 36px;
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
                            <center><asp:Label ID="Label4" runat="server" Text="Normas para los Resultados del mundial Segunda Fase" Font-Size="X-Large"></asp:Label></center></td>
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
                                Para la fase de "OCTAVOS": Por cada acierto en el "GANADOR" se sumaran 8 pts, Por cada acierto en el "MARCADOR" se sumaran 5 pts mas 
                                y Por cada acierto en el que "CLASIFICA" se sumaran 3 pts mas</td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                <center>3º</center></td>
                            <td class="celdascons">                                
                                 Para la fase de "CUARTOS": Por cada acierto en el "GANADOR" se sumaran 12 pts, Por cada acierto en el "MARCADOR" se sumaran 8 pts mas 
                                 y Por cada acierto en el que "CLASIFICA" se sumaran 5 pts mas</td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                <center>4º</center></td>
                            <td class="celdascons">                                
                                 Para la fase de "SEMIFINAL", "3RO" y "4TO" puesto: Por cada acierto en el "GANADOR" se sumaran 15 pts, Por cada acierto en el "MARCADOR" se sumaran 10 pts mas 
                                 y Por cada acierto en el que "CLASIFICA, o gana en caso de empate" se sumaran 8 pts mas</td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                               <center>5º</center></td>
                            <td class="celdascons">                                
                                 Para la "FINAL": Por cada acierto en el "GANADOR" se sumaran 20 pts, Por cada acierto en el "MARCADOR" se sumaran 12 pts mas 
                                 y Por cada acierto en el que "CLASIFICA, o gana en caso de empate" se sumaran 10 pts mas</td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                <center>6º</center></td>
                            <td class="celdascons">                                
                                APOYAR&nbsp; A&nbsp; COLOMBIA, LA TRICOLOR, MI SELECCION...</td>
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
                <td class="style12">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style13">
                    Pronostica tu Resultado</td>
                <td class="style12">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    Seleccione un partido ingrese el marcador y realice el registro:<br />
                                <asp:DropDownList ID="drlPartido" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem Value="49">Partido 49</asp:ListItem>
                                    <asp:ListItem Value="50">Partido 50</asp:ListItem>
                                    <asp:ListItem Value="51">Partido 51</asp:ListItem>
                                    <asp:ListItem Value="52">Partido 52</asp:ListItem>
                                    <asp:ListItem Value="53">Partido 53</asp:ListItem>
                                    <asp:ListItem Value="54">Partido 54</asp:ListItem>
                                    <asp:ListItem Value="55">Partido 55</asp:ListItem>
                                    <asp:ListItem Value="56">Partido 56</asp:ListItem>
                                    <asp:ListItem Value="57">Partido 57</asp:ListItem>
                                    <asp:ListItem Value="58">Partido 58</asp:ListItem>
                                    <asp:ListItem Value="59">Partido 59</asp:ListItem>
                                    <asp:ListItem Value="60">Partido 60</asp:ListItem>
                                    <asp:ListItem Value="61">Partido 61</asp:ListItem>
                                    <asp:ListItem Value="62">Partido 62</asp:ListItem>
                                    <asp:ListItem Value="63">Partido 63</asp:ListItem>
                                    <asp:ListItem Value="64">Partido 64</asp:ListItem>
                                </asp:DropDownList>
                            &nbsp;<asp:Button ID="btnguardar" runat="server" Text="Guardar" style="height: 26px" />
                    <br />
                    En caso de Empate seleccione el quipo que pasaria</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>         
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                        <!-- Tabla para ubicacion -->
                        <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <!-- Octavos de final -->
                            <td class="textotittabla2">
                            <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                Partido 49<br/>
                                <table border="1" >
                                <tr>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha49_1" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/BRASIL.png" /><br />
                                    <asp:Label ID="LblFecha49_1" runat="server">BRASIL</asp:Label><br />
                                    <asp:TextBox ID="TxtResultado49_1" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado49_1" runat="server" GroupName="49" />
                                </center>
                                </td>
                                <td>
                                    28 jun.<br />
                                    13:00 
                                </td>
                                <td class="style14">
                                <center>
                                <asp:Image ID="ImgFecha49_2" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/CHILE.png" /><br />
                                    <asp:Label ID="LblFecha49_2" runat="server">CHILE</asp:Label><br />
                                    <asp:TextBox ID="TxtResultado49_2" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado49_2" runat="server" GroupName="49" />
                                </center>
                                </td>
                                </tr>
                                </table></center>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                   Partido 50<br/>
                                <table border="1" >
                                <tr>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha50_1" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/COLOMBIA.png" /><br />
                                    <asp:Label ID="LblFecha50_1" runat="server">COLOMBIA</asp:Label><br />
                                    <asp:TextBox ID="TxtResultado50_1" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado50_1" runat="server" GroupName="50" />
                                </center>
                                </td>
                                <td>
                                    28 jun.<br />
                                    17:00
                                </td>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha50_2" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/URUGUAY.png" /><br />
                                    <asp:Label ID="LblFecha50_2" runat="server">URUGUAY</asp:Label><br />
                                    <asp:TextBox ID="TxtResultado50_2" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado50_2" runat="server" GroupName="50" />
                                </center>
                                </td>
                                </tr>
                                </table></center>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                Partido 53<br/>
                                <table border="1" >
                                <tr>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha53_1" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/FRANCIA.png" /><br />
                                    <asp:Label ID="LblFecha53_1" runat="server">FRANCIA</asp:Label><br />
                                    <asp:TextBox ID="TxtResultado53_1" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado53_1" runat="server" GroupName="53" />
                                </center>
                                </td>
                                <td>
                                    30 jun.<br />
                                    13:00
                                </td>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha53_2" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/NIGERIA.png" /><br />
                                    <asp:Label ID="LblFecha53_2" runat="server">NIGERIA</asp:Label><br />
                                    <asp:TextBox ID="TxtResultado53_2" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado53_2" runat="server" GroupName="53" />
                                </center>
                                </td>
                                </tr>
                                </table></center>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                Partido 54<br/>
                                <table border="1" >
                                <tr>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha54_1" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/ALEMANIA.png" /><br />
                                    <asp:Label ID="LblFecha54_1" runat="server">ALEMANIA</asp:Label><br />
                                    <asp:TextBox ID="TxtResultado54_1" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado54_1" runat="server" GroupName="54" />
                                    </center>
                                </td>
                                <td>
                                    30 jun.<br />
                                    17:00
                                </td>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha54_2" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/ARGELIA.png" /><br />
                                    <asp:Label ID="LblFecha54_2" runat="server">ARGELIA</asp:Label><br />
                                    <asp:TextBox ID="TxtResultado54_2" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado54_2" runat="server" GroupName="54" />
                                    </center>
                                </td>
                                </tr>
                                </table></center>
                                </td>
                        </tr>
                        </table>
                                </td>
                            <!-- Cuartos de final -->
                                <td class="textotittabla2">
                            <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla3">
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                Partido 57<br/>
                                <table border="1" >
                                <tr>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha57_1" runat="server" /><br />
                                    <asp:Label ID="LblFecha57_1" runat="server"></asp:Label><br />
                                    <asp:TextBox ID="TxtResultado57_1" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado57_1" runat="server" GroupName="57" />
                                    </center>
                                </td>
                                <td>
                                    4 jul.<br />
                                    17:00
                                </td>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha57_2" runat="server" /><br />
                                    <asp:Label ID="LblFecha57_2" runat="server"></asp:Label><br />
                                    <asp:TextBox ID="TxtResultado57_2" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado57_2" runat="server" GroupName="57" />
                                    </center>
                                </td>
                                </tr>
                                </table></center>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                Partido 58<br/>
                                <table border="1" >
                                <tr>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha58_1" runat="server" /><br />
                                    <asp:Label ID="LblFecha58_1" runat="server"></asp:Label><br />
                                    <asp:TextBox ID="TxtResultado58_1" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado58_1" runat="server" GroupName="58" />
                                    </center>
                                </td>
                                <td>
                                    4 jul.<br />
                                    13:00
                                </td>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha58_2" runat="server" /><br />
                                    <asp:Label ID="LblFecha58_2" runat="server"></asp:Label><br />
                                    <asp:TextBox ID="TxtResultado58_2" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado58_2" runat="server" GroupName="58" />
                                    </center>
                                </td>
                                </tr>
                                </table></center>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                </td>
                        </tr>
                        </table>
                                </td>
                            <!-- Semi de final -->
                                <td class="textotittabla2">
                            <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla3">
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                Partido 61<br/>
                                <table border="1" >
                                <tr>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha61_1" runat="server"/><br />
                                    <asp:Label ID="LblFecha61_1" runat="server"></asp:Label><br />
                                    <asp:TextBox ID="TxtResultado61_1" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado61_1" runat="server" GroupName="61" />
                                    </center>
                                </td>
                                <td>
                                    8 jul.<br />
                                    17:00
                                </td>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha61_2" runat="server" /><br />
                                    <asp:Label ID="LblFecha61_2" runat="server"></asp:Label><br />
                                    <asp:TextBox ID="TxtResultado61_2" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado61_2" runat="server" GroupName="61" />
                                    </center>
                                </td>
                                </tr>
                                </table></center>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                </td>
                        </tr>
                        </table>
                                </td>
                                <!-- FINAL FINAL NO VA MAS -->
                                <td class="textotittabla2">
                            <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                <asp:Image ID="ImgCopaDoMundo" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/COPA.jpg" Width="120px" /></center>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                Partido 64<br/>
                                <table border="1" >
                                <tr>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha64_1" runat="server" /><br />
                                    <asp:Label ID="LblFecha64_1" runat="server"></asp:Label><br />
                                    <asp:TextBox ID="TxtResultado64_1" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado64_1" runat="server" GroupName="64" />
                                    </center>
                                </td>
                                <td>
                                    13 jul.<br />
                                    16:00
                                </td>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha64_2" runat="server" /><br />
                                    <asp:Label ID="LblFecha64_2" runat="server"></asp:Label><br />
                                    <asp:TextBox ID="TxtResultado64_2" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado64_2" runat="server" GroupName="64" />
                                    </center>
                                </td>
                                </tr>
                                </table></center>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                Partido 63<br/>
                                <table border="1" >
                                <tr>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha63_1" runat="server" /><br />
                                    <asp:Label ID="LblFecha63_1" runat="server"></asp:Label><br />
                                    <asp:TextBox ID="TxtResultado63_1" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado63_1" runat="server" GroupName="63" />
                                    </center>
                                </td>
                                <td>
                                    12 jul.<br />
                                    17:00
                                </td>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha63_2" runat="server" /><br />
                                    <asp:Label ID="LblFecha63_2" runat="server"></asp:Label><br />
                                    <asp:TextBox ID="TxtResultado63_2" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado63_2" runat="server" GroupName="63" />
                                    </center>
                                </td>
                                </tr>
                                </table></center>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                <asp:Image ID="ImgLogo" runat="server" ImageUrl="~/Css2/Imagenes_Mundial/LOGO.gif" 
                                        Width="120px" /></center> 
                                </td>
                        </tr>
                        </table>
                                </td>                                
                            <!-- Semi de final -->
                                <td class="textotittabla2">
                            <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla3">
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                Partido 62<br/>
                                <table border="1" >
                                <tr>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha62_1" runat="server" /><br />
                                    <asp:Label ID="LblFecha62_1" runat="server"></asp:Label><br />
                                    <asp:TextBox ID="TxtResultado62_1" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado62_1" runat="server" GroupName="62" />
                                    </center>
                                </td>
                                <td>
                                    9 jul.<br />
                                    17:00
                                </td>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha62_2" runat="server" /><br />
                                    <asp:Label ID="LblFecha62_2" runat="server"></asp:Label><br />
                                    <asp:TextBox ID="TxtResultado62_2" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado62_2" runat="server" GroupName="62" />
                                    </center>
                                </td>
                                </tr>
                                </table></center>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                </td>
                        </tr>
                        </table>
                                </td>
                            <!-- Cuartos de final -->
                                <td class="textotittabla2">
                            <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla3">
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                    Partido 59<br/>
                                <table border="1" >
                                <tr>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha59_1" runat="server" /><br />
                                    <asp:Label ID="LblFecha59_1" runat="server"></asp:Label><br />
                                    <asp:TextBox ID="TxtResultado59_1" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado59_1" runat="server" GroupName="59" />
                                    </center>
                                </td>
                                <td>
                                    5 jul.<br />
                                    17:00
                                </td>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha59_2" runat="server" /><br />
                                    <asp:Label ID="LblFecha59_2" runat="server"></asp:Label><br />
                                    <asp:TextBox ID="TxtResultado59_2" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado59_2" runat="server" GroupName="59" />
                                    </center>
                                </td>
                                </tr>
                                </table></center>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                    Partido 60<br/>
                                <table border="1" >
                                <tr>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha60_1" runat="server" /><br />
                                    <asp:Label ID="LblFecha60_1" runat="server"></asp:Label><br />
                                    <asp:TextBox ID="TxtResultado60_1" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado60_1" runat="server" GroupName="60" />
                                    </center>
                                </td>
                                <td>
                                    5 jul.<br />
                                    13:00
                                </td>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha60_2" runat="server" /><br />
                                    <asp:Label ID="LblFecha60_2" runat="server"></asp:Label><br />
                                    <asp:TextBox ID="TxtResultado60_2" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado60_2" runat="server" GroupName="60" />
                                    </center>
                                </td>
                                </tr>
                                </table></center>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                </td>
                        </tr>
                        </table>
                                </td>
                                
                                <!-- Octavos de final -->
                            <td class="textotittabla2">
                            <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                    Partido 51<br/>
                                <table border="1" >
                                <tr>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha51_1" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/HOLANDA.png" /><br />
                                    <asp:Label ID="LblFecha51_1" runat="server">HOLANDA</asp:Label><br />
                                    <asp:TextBox ID="TxtResultado51_1" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado51_1" runat="server" GroupName="51" />
                                    </center>
                                </td>
                                <td>
                                    29 jun.<br />
                                    13:00
                                </td>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha51_2" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/MÉXICO.png" /><br />
                                    <asp:Label ID="LblFecha51_2" runat="server">MÉXICO</asp:Label><br />
                                    <asp:TextBox ID="TxtResultado51_2" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado51_2" runat="server" GroupName="51" />
                                    </center>
                                </td>
                                </tr>
                                </table></center>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                Partido 52<br/>
                                <table border="1" >
                                <tr>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha52_1" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/COSTA RICA.png" /><br />
                                    <asp:Label ID="LblFecha52_1" runat="server">COSTA RICA</asp:Label><br />
                                    <asp:TextBox ID="TxtResultado52_1" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado52_1" runat="server" GroupName="52" />
                                    </center>
                                </td>
                                <td>
                                    29&nbsp; jun.<br />
                                    17:00
                                </td>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha52_2" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/GRECIA.png" /><br />
                                    <asp:Label ID="LblFecha52_2" runat="server">GRECIA</asp:Label><br />
                                    <asp:TextBox ID="TxtResultado52_2" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado52_2" runat="server" GroupName="52" />
                                    </center>
                                </td>
                                </tr>
                                </table></center>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                Partido 55<br/>
                                <table border="1" >
                                <tr>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha55_1" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/ARGENTINA.png" /><br />
                                    <asp:Label ID="LblFecha55_1" runat="server">ARGENTINA</asp:Label><br />
                                    <asp:TextBox ID="TxtResultado55_1" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado55_1" runat="server" GroupName="55" />
                                    </center>
                                </td>
                                <td>
                                    1 jul.<br />
                                    13:00
                                </td>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha55_2" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/SUIZA.png" /><br />
                                    <asp:Label ID="LblFecha55_2" runat="server">SUIZA</asp:Label><br />
                                    <asp:TextBox ID="TxtResultado55_2" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado55_2" runat="server" GroupName="55" />
                                    </center>
                                </td>
                                </tr>
                                </table></center>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla3">
                                <center>
                                Partido 56<br/>
                                <table border="1" >
                                <tr>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha56_1" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/BÉLGICA.png" /><br />
                                    <asp:Label ID="LblFecha56_1" runat="server">BÉLGICA</asp:Label><br />
                                    <asp:TextBox ID="TxtResultado56_1" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado56_1" runat="server" GroupName="56" />
                                    </center>
                                </td>
                                <td>
                                    1 jul.<br />
                                    17:00
                                </td>
                                <td>
                                <center>
                                <asp:Image ID="ImgFecha56_2" runat="server" 
                                        ImageUrl="~/Css2/Imagenes_Mundial/ESTADOS UNIDOS.png" /><br />
                                    <asp:Label ID="LblFecha56_2" runat="server">ESTADOS UNIDOS</asp:Label><br />
                                    <asp:TextBox ID="TxtResultado56_2" runat="server" Width="30px"></asp:TextBox>
                                    <br />
                                    <asp:RadioButton ID="RadioBtnResultado56_2" runat="server" GroupName="56" />
                                    </center>
                                </td>
                                </tr>
                                </table></center>
                                </td>
                        </tr>
                        </table>
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
    
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    Mis Resultados&nbsp;Segunda Fase
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
                                Partido</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlPartidoConsulta" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem Value="49">Partido 49</asp:ListItem>
                                    <asp:ListItem Value="50">Partido 50</asp:ListItem>
                                    <asp:ListItem Value="51">Partido 51</asp:ListItem>
                                    <asp:ListItem Value="52">Partido 52</asp:ListItem>
                                    <asp:ListItem Value="53">Partido 53</asp:ListItem>
                                    <asp:ListItem Value="54">Partido 54</asp:ListItem>
                                    <asp:ListItem Value="55">Partido 55</asp:ListItem>
                                    <asp:ListItem Value="56">Partido 56</asp:ListItem>
                                    <asp:ListItem Value="57">Partido 57</asp:ListItem>
                                    <asp:ListItem Value="58">Partido 58</asp:ListItem>
                                    <asp:ListItem Value="59">Partido 59</asp:ListItem>
                                    <asp:ListItem Value="60">Partido 60</asp:ListItem>
                                    <asp:ListItem Value="61">Partido 61</asp:ListItem>
                                    <asp:ListItem Value="62">Partido 62</asp:ListItem>
                                    <asp:ListItem Value="63">Partido 63</asp:ListItem>
                                    <asp:ListItem Value="64">Partido 64</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        </table>
                    <asp:Button ID="BtnConsultar_Resultados" runat="server" 
                        Text="Consultar Pronostico" />
                &nbsp;
                    <asp:Button ID="BtnConsultar_Raiking" runat="server" 
                        Text="Consultar Ranking" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" colspan="2">
                            <center><asp:Label ID="Label1" runat="server" Text="Consulta de Pronostico" 
                                    Font-Size="X-Large"></asp:Label></center></td>
                        </tr>
                        <tr>
                            <td class="celdascons">
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
                            <asp:BoundField DataField="EquipoGana" HeaderText="Equipo que pasa" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                            </td>
                        </tr>                                    
                        </table>
                            </td>
                            <td class="textotittabla">
                                <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" colspan="2">
                            <center>
                                <asp:Label ID="Label2" runat="server" Text="Tabla de Ranking" 
                                    Font-Size="X-Large"></asp:Label></center></td>
                        </tr>
                        <tr>
                            <td class="celdascons">
                                <asp:GridView ID="dtgRaiking" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="1000" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Id_Usuario" HeaderText="Id Usuario" />
                            <asp:BoundField DataField="nombreu" HeaderText="Nombre" />
                            <asp:BoundField DataField="Cargo" HeaderText="Grupo" />
                            <asp:BoundField DataField="Pts" HeaderText="Puntos" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                            </td>
                        </tr>                                    
                        </table>
                            </td>
                        </tr>                                  
                        </table>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>          
        </table>
    
    </form>
</body>
</html>
