<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ReporteEscalamiento.aspx.vb" Inherits="digitacion.ReporteEscalamiento1" %>

<!DOCTYPE html>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>


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
 
        .celdascons
{
		width: 35%;
}
       
        .celdascons
{
		width: 35%;
}
     
        .auto-style1 {}
        .auto-style2 {
            width: 50%;
            height: 22px;
        }
     
        .auto-style43 {
            width: 100%;
            border: 1px solid #000000;
        }
        .auto-style44 {
            color: #FFFFFF;
            font-size: small;
        }
        
        .auto-style48 {
            height: 146px;
            width: 130px;
            text-align: center;
        }
        .auto-style55 {
            height: 146px;
            width: 40px;
            text-align: center;
        }
        .auto-style45 {
            height: 146px;
            width: 42px;
            text-align: center;
        }

        .auto-style51 {
            width: 130px;
            color: #000000;
        }
        .auto-style52 {
            width: 40px;
        }
        .auto-style56 {
            width: 42px;
        }
        .auto-style57 {
            width: 130px;
            height: 22px;
        }
        .auto-style58 {
            width: 40px;
            height: 22px;
        }
        .auto-style59 {
            width: 42px;
            height: 22px;
        }

        .auto-style60 {
            width: 130px;
            height: 24px;
        }
        .auto-style61 {
            width: 40px;
            height: 24px;
        }
        .auto-style62 {
            width: 42px;
            height: 24px;
        }

        .auto-style63 {
            width: 130px;
            color: #000000;
            height: 24px;
        }

        .auto-style71 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 981px;
        }
        .auto-style72 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 981px;
        }
        .auto-style73 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 359px;
        }
        .auto-style74 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 359px;
        }
        .auto-style64 {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style65 {
            text-align: center;
        }
        .auto-style67 {
            width: 90px;
        }
        .auto-style66 {
            color: black;
            text-align: center;
        }
        .auto-style70 {
            height: 22px;
            text-align: center;
        }
        .auto-style69 {
            width: 90px;
            height: 22px;
            text-align: center;
        }
        .auto-style75 {
            text-align: center;
            font-size: large;
        }
        .auto-style76 {
            width: 90px;
            text-align: center;
        }
        .auto-style77 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 23px;
        }
        .auto-style78 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 23px;
        }
      
        </style>
</head>
<body>
    <form id="form1" runat="server">
    
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
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    Reporte Escalamiento</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td style="width:15%" valign="top">
                    <table class="style2">
                        <tr>
                            <td class="auto-style2">
                                <asp:Label ID="lblusuario" runat="server"></asp:Label>
                            </td>
                            <td class="style7">
                                <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1" colspan="2">
                               

                                    &nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                &nbsp;<asp:Button ID="BtnBuscar" runat="server" Text="Buscar" />
                                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td class="celdascent">
                        <asp:Button ID="BtnDimen" runat="server" Text="Dimensionamiento" Visible="False" />
                        </td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                                <asp:Button ID="BtnExpo" runat="server" Text="Exportar" ALIGN="right" Visible="False"/>
                            </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style71">
                    </td>
                <td class="auto-style72">
                                <asp:Panel ID="Escala" runat="server" Height="902px" Visible="False">
                                    <table cellspacing="1" class="auto-style43" border ="1" id="Escala0">
                                        <tr class="auto-style44">
                                            <td class="auto-style48" style="background-color: #002060; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFCE;">FECHA<br /> REGISTRO</td>
                                            <td class="auto-style55" style="background-color: #002060; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFCE;">E<br /> S<br /> C<br /> A<br /> L<br /> A<br /> M<br /> I<br /> E<br /> N<br /> T<br /> O<br /> &nbsp;<br /> V<br /> O<br /> Z</td>
                                            <td class="auto-style55" style="background-color: #002060; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFCE;">E<br /> S<br /> C<br /> A<br /> L<br /> A<br /> M<br /> I<br /> E<br /> N<br /> T<br /> O<br /> &nbsp;<br /> D<br /> A<br /> T<br /> O<br /> S</td>
                                            <td class="auto-style55" style="background-color: #002060; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFCE;">F<br /> A<br /> L<br /> L<br /> A<br /> T<br /> E<br /> C<br /> &nbsp;<br /> V<br /> O<br /> Z</td>
                                            <td class="auto-style55" style="background-color: #002060; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFCE;">F<br /> A<br /> L<br /> L<br /> A<br /> T<br /> E<br /> C<br /> &nbsp;<br /> D<br /> A<br /> T<br /> O<br /> S</td>
                                            <td class="auto-style55" style="background-color: #002060; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFCE;">I<br /> L<br /> O<br /> C<br /> A<br /> L<br /> I<br /> Z<br /> A<br /> B<br /> L<br /> E<br /> S<br /> &nbsp;<br /> V<br /> O<br /> Z</td>
                                            <td class="auto-style55" style="background-color: #002060; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFCE;">I<br /> L<br /> O<br /> C<br /> A<br /> L<br /> I<br /> Z<br /> A<br /> B<br /> L<br /> E<br /> S<br /> &nbsp;<br /> D<br /> A<br /> T<br /> O<br /> S</td>
                                            <td class="auto-style55" style="background-color: #002060; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFCE;">S<br /> E<br /> G<br /> U<br /> I<br /> M<br /> I<br /> E<br /> N<br /> T<br /> O<br /> &nbsp;<br /> V<br /> O<br /> Z</td>
                                            <td class="auto-style55" style="background-color: #002060; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFCE;">S<br /> E<br /> G<br /> U<br /> I<br /> M<br /> I<br /> E<br /> N<br /> T<br /> O<br /> &nbsp;<br /> D<br /> A<br /> T<br /> O<br /> S</td>
                                            <td class="auto-style55" style="background-color: #002060; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFCE;">R<br /> E<br /> V<br /> I<br /> S<br /> I<br /> O<br /> N<br /> &nbsp;<br /> V<br /> O<br /> Z</td>
                                            <td class="auto-style55" style="background-color: #002060; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFCE;">R<br /> E<br /> V<br /> I<br /> S<br /> I<br /> O<br /> N<br /> &nbsp;<br /> D<br /> A<br /> T<br /> O<br /> S</td>
                                            <td class="auto-style55" style="background-color: #002060; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFCE;">S<br /> E<br /> R<br /> V<br /> I<br /> C<br /> E<br /> &nbsp;<br /> V<br /> O<br /> Z</td>
                                            <td class="auto-style55" style="background-color: #002060; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFCE;">S<br /> E<br /> R<br /> V<br /> I<br /> C<br /> E<br />
                                                <br />
                                                D<br /> A<br /> T<br /> O<br /> S</td>
                                            <td class="auto-style55" style="background-color: #002060; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFCE;">F<br /> O<br /> R<br /> M<br /> A<br /> T<br /> O<br /> S</td>
                                            <td class="auto-style45" style="background-color: #002060; font-family: verdana, Geneva, Tahoma, sans-serif; color: #FFFFCE;">M<br /> U<br /> N<br /> I<br /> C<br /> I<br /> P<br /> I<br /> O<br /> S</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha1" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc1" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc1" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc1" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc1" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc1" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc1" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV1" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD1" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV1" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD1" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV1" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD1" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr1" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs1" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style57">
                                                <asp:Label ID="LblFecha2" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style58">
                                                <asp:Label ID="LblEscVozfc2" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style58">
                                                <asp:Label ID="LblEscDatfc2" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style58">
                                                <asp:Label ID="LblFallVozfc2" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style58">
                                                <asp:Label ID="LblFallDatfc2" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style58">
                                                <asp:Label ID="LblIloVfc2" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style58">
                                                <asp:Label ID="LblIloDfc2" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style58">
                                                <asp:Label ID="LblSegV2" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style58">
                                                <asp:Label ID="LblSegD2" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style58">
                                                <asp:Label ID="LblRevV2" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style58">
                                                <asp:Label ID="LblRevD2" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style58">
                                                <asp:Label ID="LblSerV2" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style58">
                                                <asp:Label ID="LblSerD2" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style58">
                                                <asp:Label ID="LblOtr2" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style59">
                                                <asp:Label ID="LblObs2" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha3" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc3" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc3" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc3" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc3" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc3" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc3" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV3" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD3" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV3" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD3" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV3" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD3" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr3" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs3" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha4" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc4" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc4" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc4" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc4" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc4" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc4" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV4" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD4" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV4" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD4" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV4" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD4" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr4" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs4" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style60">
                                                <asp:Label ID="LblFecha5" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblEscVozfc5" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblEscDatfc5" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblFallVozfc5" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblFallDatfc5" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblIloVfc5" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblIloDfc5" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblSegV5" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblSegD5" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblRevV5" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblRevD5" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblSerV5" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblSerD5" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblOtr5" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style62">
                                                <asp:Label ID="LblObs5" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha6" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc6" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc6" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc6" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc6" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc6" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc6" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV6" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD6" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV6" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD6" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV6" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD6" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr6" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs6" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha7" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc7" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc7" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc7" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc7" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc7" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc7" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV7" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD7" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV7" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD7" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV7" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD7" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr7" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs7" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha8" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc8" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc8" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc8" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc8" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc8" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc8" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV8" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD8" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV8" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD8" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV8" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD8" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr8" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs8" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style63">
                                                <asp:Label ID="LblFecha9" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblEscVozfc9" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblEscDatfc9" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblFallVozfc9" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblFallDatfc9" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblIloVfc9" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblIloDfc9" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblSegV9" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblSegD9" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblRevV9" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblRevD9" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblSerV9" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblSerD9" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style61">
                                                <asp:Label ID="LblOtr9" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style62">
                                                <asp:Label ID="LblObs9" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha10" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc10" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc10" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc10" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc10" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc10" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc10" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV10" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD10" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV10" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD10" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV10" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD10" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr10" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs10" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha11" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc11" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc11" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc11" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc11" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc11" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc11" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV11" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD11" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV11" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD11" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV11" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD11" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr11" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs11" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha12" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc12" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc12" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc12" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc12" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc12" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc12" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV12" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD12" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV12" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD12" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV12" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD12" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr12" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs12" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha13" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc13" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc13" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc13" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc13" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc13" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc13" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV13" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD13" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV13" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD13" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV13" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD13" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr13" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs13" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha14" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc14" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc14" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc14" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc14" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc14" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc14" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV14" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD14" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV14" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD14" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV14" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD14" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr14" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs14" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha15" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc15" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc15" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc15" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc15" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc15" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc15" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV15" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD15" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV15" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD15" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV15" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD15" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr15" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs15" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha16" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc16" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc16" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc16" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc16" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc16" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc16" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV16" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD16" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV16" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD16" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV16" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD16" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr16" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs16" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha17" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc17" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc17" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc17" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc17" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc17" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc17" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV17" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD17" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV17" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD17" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV17" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD17" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr17" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs17" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha18" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc18" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc18" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc18" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc18" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc18" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc18" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV18" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD18" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV18" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD18" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV18" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD18" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr18" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs18" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha19" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc19" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc19" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc19" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc19" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc19" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc19" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV19" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD19" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV19" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD19" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV19" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD19" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr19" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs19" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha20" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc20" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc20" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc20" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc20" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc20" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc20" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV20" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD20" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV20" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD20" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV20" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD20" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr20" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs20" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha21" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc21" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc21" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc21" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc21" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc21" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc21" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV21" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD21" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV21" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD21" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV21" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD21" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr21" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs21" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">
                                                <asp:Label ID="LblFecha22" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscVozfc22" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblEscDatfc22" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallVozfc22" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblFallDatfc22" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloVfc22" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblIloDfc22" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegV22" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSegD22" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevV22" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblRevD22" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerV22" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblSerD22" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblOtr22" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="LblObs22" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">Total</td>
                                            <td class="auto-style52">
                                                <asp:Label ID="TotalEscV" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="TotalEscD" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="TotalFallV" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="TotalFallD" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="TotalIloV" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="TotalIloD" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="TotalSegV" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="TotalSegD" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="TotalRevV" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="TotalRevD" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="TotalSerV" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="TotalSerD" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="TotalForma" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="TotalMuni" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style51">Dias</td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblcanEscVoz" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblcanEscDatos" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblcanFallaV" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblcanFallaD" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="lblcanIloVoz" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="lblcanIloDatos" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="lblcanSegVoz" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="lblcanSegDatos" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblcanRevV" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="LblcanRevD" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="lblcanSerV" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="lblcanSerD" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style52">
                                                <asp:Label ID="lblcanFor" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Label ID="lblcanmuni" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                    <br />
                                    <br />
                                </asp:Panel>
                                
                                
                            </td>
                <td class="auto-style71">
                    </td>
            </tr>
            <tr>
                <td class="auto-style73">
                    </td>
                <td class="auto-style74">
                    <asp:Panel ID="Dimen" runat="server" Height="347px" style="margin-bottom: 3px" Visible="False">
                        <br />
                        <table border="1" cellspacing="1" class="auto-style64">
                            <tr>
                                <td class="auto-style75" colspan="15" style="background-color: #002060; color: #FFFFFF; font-family: Calibri">
                                    <asp:Label ID="DiaAC" runat="server" Text="DIA ACTUAL"></asp:Label>
                                </td>
                                <td class="auto-style65" rowspan="4" style="background-color: #000000; color: #FFFFFF; font-family: Calibri">
                                    <asp:Label ID="Label1" runat="server" Text="TOTAL DE ASESORES"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="background-color: #002060; color: #FFFFFF; font-family: Calibri">&nbsp;</td>
                                <td style="background-color: #002060; color: #FFFFFF; font-family: Calibri">Escalamiento Voz</td>
                                <td style="background-color: #002060; color: #FFFFFF; font-family: Calibri">Escalamiento Datos</td>
                                <td style="background-color: #002060; color: #FFFFFF; font-family: Calibri">Fallatec Voz</td>
                                <td style="background-color: #002060; color: #FFFFFF; font-family: Calibri">Fallatec Datos</td>
                                <td style="background-color: #002060; color: #FFFFFF; font-family: Calibri">Ilocalizable Voz</td>
                                <td style="background-color: #002060; color: #FFFFFF; font-family: Calibri">Ilocalizable Datos</td>
                                <td style="background-color: #002060; color: #FFFFFF; font-family: Calibri">Seguimiento Voz</td>
                                <td style="background-color: #002060; color: #FFFFFF; font-family: Calibri">Seguimiento Datos</td>
                                <td style="background-color: #002060; color: #FFFFFF; font-family: Calibri">Revision Voz</td>
                                <td style="background-color: #002060; color: #FFFFFF; font-family: Calibri">Revision Datos</td>
                                <td style="background-color: #002060; color: #FFFFFF; font-family: Calibri">Service Voz</td>
                                <td style="background-color: #002060; color: #FFFFFF; font-family: Calibri">Service Datos</td>
                                <td style="background-color: #002060; color: #FFFFFF; font-family: Calibri">Formatos</td>
                                <td class="auto-style67" style="background-color: #002060; color: #FFFFFF; font-family: Calibri">Municipios</td>
                            </tr>
                            <tr>
                                <td class="auto-style66">TOTAL</td>
                                <td class="auto-style65">
                                    <asp:Label ID="EscaV" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style65">
                                    <asp:Label ID="EscaD" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style65">
                                    <asp:Label ID="FallaV" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style65">
                                    <asp:Label ID="FallaD" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style65">
                                    <asp:Label ID="IlocV" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style65">
                                    <asp:Label ID="IlocD" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style65">
                                    <asp:Label ID="SeguV" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style65">
                                    <asp:Label ID="SeguD" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style65">
                                    <asp:Label ID="ReviV" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style65">
                                    <asp:Label ID="ReviD" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style65">
                                    <asp:Label ID="ServV" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style65">
                                    <asp:Label ID="ServD" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style65">
                                    <asp:Label ID="Forma" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style76">
                                    <asp:Label ID="Munic" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style65" style="font-family: Calibri; color: #FFFFFF; background-color: #002060; font-size: small;">GESTIONES
                                    <br />
                                    DIARIAS<br /> POR CAMPAÑA</td>
                                <td style="font-family: Calibri; color: #FFFFFF; background-color: #002060" class="auto-style65">
                                    <asp:Label ID="EscV" runat="server"></asp:Label>
                                </td>
                                <td style="font-family: Calibri; color: #FFFFFF; background-color: #002060" class="auto-style65">
                                    <asp:Label ID="EscD" runat="server"></asp:Label>
                                </td>
                                <td style="font-family: Calibri; color: #FFFFFF; background-color: #002060" class="auto-style65">
                                    <asp:Label ID="FallV" runat="server"></asp:Label>
                                </td>
                                <td style="font-family: Calibri; color: #FFFFFF; background-color: #002060" class="auto-style65">
                                    <asp:Label ID="FallD" runat="server"></asp:Label>
                                </td>
                                <td style="font-family: Calibri; color: #FFFFFF; background-color: #002060" class="auto-style65">
                                    <asp:Label ID="IloV" runat="server"></asp:Label>
                                </td>
                                <td style="font-family: Calibri; color: #FFFFFF; background-color: #002060" class="auto-style65">
                                    <asp:Label ID="IloD" runat="server"></asp:Label>
                                </td>
                                <td style="font-family: Calibri; color: #FFFFFF; background-color: #002060" class="auto-style65">
                                    <asp:Label ID="SegV" runat="server"></asp:Label>
                                </td>
                                <td style="font-family: Calibri; color: #FFFFFF; background-color: #002060" class="auto-style65">
                                    <asp:Label ID="SegD" runat="server"></asp:Label>
                                </td>
                                <td style="font-family: Calibri; color: #FFFFFF; background-color: #002060" class="auto-style65">
                                    <asp:Label ID="RevV" runat="server"></asp:Label>
                                </td>
                                <td style="font-family: Calibri; color: #FFFFFF; background-color: #002060" class="auto-style65">
                                    <asp:Label ID="RevD" runat="server"></asp:Label>
                                </td>
                                <td style="font-family: Calibri; color: #FFFFFF; background-color: #002060" class="auto-style65">
                                    <asp:Label ID="SerV" runat="server"></asp:Label>
                                </td>
                                <td style="font-family: Calibri; color: #FFFFFF; background-color: #002060" class="auto-style65">
                                    <asp:Label ID="SerD" runat="server"></asp:Label>
                                </td>
                                <td style="font-family: Calibri; color: #FFFFFF; background-color: #002060" class="auto-style65">
                                    <asp:Label ID="Form" runat="server"></asp:Label>
                                </td>
                                <td class="auto-style76" style="font-family: Calibri; color: #FFFFFF; background-color: #002060">
                                    <asp:Label ID="Muni" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style70" style="font-family: CALibri; color: #FFFFFF; background-color: #002060; font-size: small;">NUMERO DE<br /> ASESORES PARA<br /> QUEDAR AL DIA<br /> POR CAMPAÑA</td>
                                <td class="auto-style70">
                                    <asp:Label ID="EscaV0" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style70">
                                    <asp:Label ID="EscaD0" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style70">
                                    <asp:Label ID="FallaV0" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style70">
                                    <asp:Label ID="FallaD0" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style70">
                                    <asp:Label ID="IlocV0" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style70">
                                    <asp:Label ID="IlocD0" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style70">
                                    <asp:Label ID="SeguV0" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style70">
                                    <asp:Label ID="SeguD0" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style70">
                                    <asp:Label ID="ReviV0" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style70">
                                    <asp:Label ID="ReviD0" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style70">
                                    <asp:Label ID="ServV0" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style70">
                                    <asp:Label ID="ServD0" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style70">
                                    <asp:Label ID="Forma0" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style69">
                                    <asp:Label ID="Munic0" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td class="auto-style70" style="background-color: #92D050">
                                    <asp:Label ID="Asesoresuma" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style65" style="font-family: CALibri; color: #FFFFFF; background-color: #002060; font-size: small;">CANTIDAD DE<br /> ASESORES
                                    <br />
                                    ACTUALMENTE</td>
                                <td class="auto-style65">
                                    <asp:Label ID="Asesores" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                                <td colspan="14" rowspan="2">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style65" style="font-family: CALibri; color: #FFFFFF; background-color: #002060; font-size: small;">CANTIDAD DE
                                    <br />
                                    DIAS PARA<br /> QUEDAR AL DIA</td>
                                <td class="auto-style65">
                                    <asp:Label ID="Dias" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                                
                                
                </td>
                <td class="auto-style73">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    &nbsp;
                                
    
                              <asp:GridView ID="DtgEscalamiento" runat="server" BackColor="White" BorderColor="Black" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" GridLines="Horizontal" Width="1004px" style="margin-bottom: 0px">
                                  <FooterStyle BackColor="White" ForeColor="#333333" />
                                  <HeaderStyle BackColor="#002060" Font-Bold="True" ForeColor="White" />
                                  <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                                  <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                  <SelectedRowStyle BackColor="#999999" Font-Bold="True" ForeColor="White" />
                              </asp:GridView>
                                
                                
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style77">
                    </td>
                <td class="auto-style78">
    
                    </td>
                <td class="auto-style77">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
    
                              <asp:GridView ID="DtgDimen" runat="server" BackColor="White" BorderColor="White" BorderWidth="0px" CellPadding="4" EnableModelValidation="True" GridLines="Horizontal" Width="1004px" style="margin-bottom: 0px" SelectedIndex="1" BorderStyle="None" Visible="False" >
                                  <FooterStyle BackColor="White" ForeColor="#333333" />
                                  <HeaderStyle BackColor="#002060" Font-Bold="True" ForeColor="White" />
                                  <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                                  <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                  <SelectedRowStyle BackColor="#002060" Font-Bold="True" ForeColor="White" />

                              </asp:GridView>
                                
                                
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </table>
    
    </form>
</body>
</html>
