<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Estadistica.aspx.vb" Inherits="digitacion.Estadistica" %>

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
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:Label ID="lblmsg0" runat="server" 
                        style="font-size: medium; font-style: italic">Estadística General Mesa Datos</asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
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
                                            <asp:Button ID="Button1" runat="server" Text="Buscar" />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                </td>
                            <td style="width: 70%" rowspan="1">
                                            &nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" />
                </td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                <asp:Panel ID="Panel2" runat="server">
                                    <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                                        <tr>
                                            <td class="textotittabla">
                                                Fecha Inicial</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtfcini" runat="server"></asp:TextBox>
                                            </td>
                                            <td class="textotittabla">
                                                Fecha Final</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtfcfin" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                                    <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                                        <tr>
                                            <td class="textotittabla">
                                                <asp:Label ID="lblcantidad" runat="server"></asp:Label>
                                            </td>
                                            <td class="textotittabla">
                                                Casos Recibidos</td>
                                            <td class="textotittabla">
                                                Porcentaje</td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                <asp:Label ID="lbltit1" runat="server"> </asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblvlr1" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblp1" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                <asp:Label ID="lbltit2" runat="server"> </asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblvlr2" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblp2" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                <asp:Label ID="lbltit3" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblvlr3" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblp3" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                <asp:Label ID="lbltit4" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblvlr4" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblp4" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                <asp:Label ID="lbltit5" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblvlr5" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblp5" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                <asp:Label ID="lbltit6" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblvlr6" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblp6" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                <asp:Label ID="lbltit7" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblvlr7" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblp7" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                <asp:Label ID="lbltit8" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblvlr8" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblp8" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                <asp:Label ID="lbltit9" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblvlr9" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblp9" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                <asp:Label ID="lbltit10" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblvlr10" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblp10" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                &nbsp;</td>
                                            <td class="celdascons">
                                                &nbsp;</td>
                                            <td class="celdascons">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Total Recibidos</td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lbltotal" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblptotal" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Total Casos Pendientes de Proceso</td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblptes" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblpptes" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Potencial Ilocalizable</td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblilocpotencial" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblpilocpotencial" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Indicador de Gestión</td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblgestion" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblpgestion" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Indicador de Cierre</td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblcierre" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblpcierre" runat="server"></asp:Label>
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
    
                                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                                    <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                                        <tr>
                                            <td class="textotittabla">
                                            <asp:Button ID="Button2" runat="server" Text="Calcular" />
                                            </td>
                                            <td class="textotittabla">
                                                &nbsp;</td>
                                            <td class="textotittabla">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                &nbsp;</td>
                                            <td class="textotittabla">
                                                &nbsp;</td>
                                            <td class="textotittabla">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Casos Proyectados a Recibir</td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblmesact" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                Por defecto 5% (1,05)<asp:CompareValidator ID="CompareValidator1" 
                                                    runat="server" ControlToValidate="txtprrecep" 
                                                    ErrorMessage="El valor debe ser mayor de uno más el porcentaje de aumento esperado" 
                                                    Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                                <asp:TextBox ID="txtprrecep" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Casos Proyectados a Cerrar</td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblcierrem" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                Por defecto 5% (1,05)<asp:CompareValidator ID="CompareValidator2" 
                                                    runat="server" ControlToValidate="txtprccierre" 
                                                    ErrorMessage="El valor debe ser mayor de uno más el porcentaje de aumento esperado" 
                                                    Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                                <asp:TextBox ID="txtprccierre" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Ejecutado</td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lbleject" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Cumplimiento Actual</td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblpcumplim" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Personal Disponible</td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblpersonal" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                Promedio durante el mes<asp:TextBox ID="txtpersona" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Casos proyectados por persona/día</td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblcasosxp" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                Estático&nbsp; 25<asp:TextBox ID="txtcasosxp" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Días para el Cierre</td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lbldxcierre" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                Días para el fin de mes<asp:TextBox ID="txtdxcierre" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Casos Proyectados</td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblcasosproyect" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Cumplimiento Esperado</td>
                                            <td class="celdascons" align="right">
                                                <asp:Label ID="lblejectmes" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons" align="right">
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
    
                                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                    <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True" Visible="False">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="estado" HeaderText="estado" />
                            <asp:BoundField DataField="casos" HeaderText="Caso" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    </asp:GridView>
                                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </table>
    
    </form>
</body>
</html>
