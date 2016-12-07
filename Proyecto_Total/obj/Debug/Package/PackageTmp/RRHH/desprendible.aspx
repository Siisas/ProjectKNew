<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="desprendible.aspx.vb" Inherits="digitacion.desprendible" %>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
                        style="font-size: medium; font-style: italic" ForeColor="#003300">Detalle de Pago</asp:Label>
                </td>
                <td class="style10">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td style="width:15%" valign="top">
                    <table class="style2">
                        <tr>
                            <td class="style6">
                                <asp:Label ID="lblusuario" runat="server"></asp:Label>
                            </td>
                            <td class="style7">
                                <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 30%" rowspan="1">
                                <table class="style2" frame="border" 
                                    style="padding: inherit; visibility: visible">
                                    <tr>
                                        <td id="Caso" bgcolor="#CCFFCC">
                                            Periodo:</td>
                                        <td>
                                <asp:DropDownList ID="drlperiodo" runat="server" Height="24px" Width="136px">
                                    <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                    <asp:ListItem>SI</asp:ListItem>
                                    <asp:ListItem>NO</asp:ListItem>
                                    <asp:ListItem>NS/NR</asp:ListItem>
                                </asp:DropDownList>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="width: 70%" rowspan="1">
                                            <asp:Button ID="Button1" runat="server" Text="Buscar" />
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
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                            &nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;
                                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #003300;" 
                    valign="top" class="style3">
                            Información del Empleado</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Documento</td>
                            <td class="celdascons">
                                <asp:Label ID="lbldoc" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Código</td>
                            <td class="celdascons">
                                <asp:Label ID="lblcod" runat="server" ForeColor="#003300"></asp:Label>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Nombre</td>
                            <td class="celdascons">
                                <asp:Label ID="lblnombre" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Cargo</td>
                            <td class="celdascons">
                                <asp:Label ID="lblcargo" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                &nbsp;</td>
                            <td class="celdascons">
                                &nbsp;</td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                &nbsp;</td>
                            <td class="celdascons">
                                &nbsp;</td>
                        </tr>
                        </table>
                                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #003300;" 
                    valign="top" class="style9">
                            Información General</td>
                <td class="style8">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Sueldo Básico</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblsueldob" runat="server" ForeColor="#003300"></asp:Label> 
                                
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Auxilio de Transporte</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblauxtransp" runat="server" ForeColor="#003300"></asp:Label>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Gastos de Representación</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblgastosrep" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                &nbsp;</td>
                            <td class="celdascons">
                                &nbsp;</td>
                        </tr>
                        </table>
                                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #003300;" 
                    valign="top" class="style3">
                            Devengado</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" />
                </td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Días Laborados</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lbldiastr" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Días Incapacidad</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lbldiasinc" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Sueldo Devengado</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblsueldo" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Vacaciones</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblvac" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Aux. Transp</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblauxtranspp" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Horas Extras</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblhe" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Otros Pagos no Constituyen Salario</td>
                            <td class="celdascons">
                                &nbsp;</td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                &nbsp;</td>
                            <td class="celdascons">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Gastos de Representación</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblgastosrepp" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Bonificación Extralegal</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblbonifextra" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Int Cesantías</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblintcesant" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Prima</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblprima" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Viáticos</td> 
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblviaticos" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Contingencia Ordinaria</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblcontord" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Contingencia Festiva</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblcontfes" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Contingencia Nocturna</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblcontnoc" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Bonificación y Reintegro</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblreint" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                &nbsp;</td>
                            <td class="celdascons">
                                &nbsp;</td>
                        </tr>
                        </table>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <table bgcolor="#FFFFCC" class="style2">
                        <tr>
                            <td>
                                <asp:Label ID="lbldev" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#003300">Total Devengado:   </asp:Label>
                                <asp:Label ID="lbltotaldev" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#003300"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent" style="color: #003300">
                    Deducido</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Pensión</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblpension" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                EPS</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lbleps" runat="server" ForeColor="#003300"></asp:Label>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                UPS</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblups" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Ret. Fte</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblretfte" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                FSP</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblfsp" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Cafeteria</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblcafeteria" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Anticipo</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblanticipo" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Otros Descuentos</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblotrosdesc" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Cantidad Retardos</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblretardo" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Valor Retardos</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblvlrretardos" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                No. Inasistencias</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblinasist" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" style="background-color: #CCFFCC; color: #003300;">
                                Valor Inasistencias</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblvlrinasist" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                        </tr>
                        </table>
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <table bgcolor="#FFFFCC" class="style2">
                        <tr>
                            <td>
                                <asp:Label ID="lbldev0" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#003300">Total Deducido:   </asp:Label>
                                <asp:Label ID="lbltotalded" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#003300"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent" style="color: #003300">
                    Resumen Total de Pago</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" bgcolor="#CCFFCC" style="background-color: #CCFFCC">
                                Total Pago</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lbltotalpago" runat="server" ForeColor="#003300"></asp:Label>
                            </td>
                            <td class="textotittabla" bgcolor="#CCFFCC" style="background-color: #CCFFCC">
                                Liquidaciones</td>
                            <td class="celdascons" align="right">
                                <asp:Label ID="lblliquidac" runat="server" ForeColor="#003300"></asp:Label>
                                </td>
                        </tr>
                        </table>
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <table bgcolor="#FFFFCC" class="style2">
                        <tr>
                            <td>
                                <asp:Label ID="lbldev1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#003300">Total Consignado:   </asp:Label>
                                <asp:Label ID="lblconsignado" runat="server" Font-Size="Large" ForeColor="#003300"></asp:Label>
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
