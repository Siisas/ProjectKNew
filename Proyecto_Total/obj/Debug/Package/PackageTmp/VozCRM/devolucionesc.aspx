<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="devolucionesc.aspx.vb" Inherits="digitacion.devolucionesc" %>

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
                        style="font-size: medium; font-style: italic">Devolución y Corrección de Escalamiento Voz y Datos</asp:Label>
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
                                <table class="style2" frame="border" 
                                    style="padding: inherit; visibility: visible">
                                    <tr>
                                        <td id="Caso" bgcolor="#CCCCFF">
                                            Caso:</td>
                                        <td>
                                            <asp:TextBox ID="txtcaso" runat="server" Width="138px"></asp:TextBox>
                                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                ControlToValidate="txtcaso" ErrorMessage="El caso debe ser numérico" 
                                                Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
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
                                &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" />
                </td>
                <td class="celdascent">
                    <asp:Panel ID="Panel1" runat="server">
                        <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                            <tr>
                                <td class="textotittabla">
                                    <asp:Button ID="btnguardar0" runat="server" style="height: 26px" 
                                        Text="Guardar" />
                                </td>
                                <td>
                                    Registro de Falla de Red</td>
                                <td class="textotittabla">
                                    Anula Falla de Red</td>
                                <td>
                                    <asp:CheckBox ID="chkanula" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Campaña</td>
                                <td>
                                    <asp:Label ID="lblcampana" runat="server"></asp:Label>
                                </td>
                                <td class="textotittabla">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Persona Contacto</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtFcontacto" runat="server" Width="278px"></asp:TextBox>
                                </td>
                                <td class="textotittabla">
                                    Número Contacto</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtFnum" runat="server" Width="136px" MaxLength="10"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Marca</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlmarca" runat="server" AutoPostBack="True" 
                                        Height="22px" Width="322px">
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Equipo</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlequipo" runat="server" Height="22px" Width="322px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Tiempo Falla</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlFtiempo" runat="server" Height="22px" Width="130px">
                                         <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem Value="&lt;=30">&lt;=30</asp:ListItem>
                                        <asp:ListItem Value="&gt;30">&gt;30</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Tipo Falla</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtFtipofalla" runat="server" Width="285px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Características de la Falla</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlFcaract" runat="server" Height="20px" Width="311px">
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Línea Portada</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlFportada" runat="server" Height="22px" Width="130px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Departamento</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drldpto" runat="server" AutoPostBack="True" Height="22px" 
                                        Width="322px">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Municipio</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlmun" runat="server" Height="22px" Width="322px">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    &nbsp;</td>
                                <td class="celdascons">
                                    &nbsp;</td>
                                <td class="textotittabla">
                                    Barrio</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtbarrio" runat="server" Width="278px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Nombre Vereda o Corregimiento</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtFciudad" runat="server" Width="279px"></asp:TextBox>
                                </td>
                                <td class="textotittabla">
                                    Tipo Lugar</td>
                                <td class="celdascons">
                                    <asp:RadioButtonList ID="rdbvc" runat="server" Font-Size="XX-Small" 
                                        Width="219px">
                                        <asp:ListItem Value="VRD">Vereda</asp:ListItem>
                                        <asp:ListItem Value="CRG">Corregimiento</asp:ListItem>
                                        <asp:ListItem Value="INS">Inspección</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Dirección Falla</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtFdirecc" runat="server" Width="279px"></asp:TextBox>
                                </td>
                                <td class="textotittabla">
                                    Tecnología</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlFtectolog" runat="server" Height="22px" Width="130px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>GSM</asp:ListItem>
                                        <asp:ListItem>3G</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    APN</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtapn" runat="server" Width="200px"></asp:TextBox>
                                </td>
                                <td class="textotittabla">
                                    Qos</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtqos" runat="server" Width="200px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Lineas con falla en la Ubicación Reportada</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlFlineasfalla" runat="server" Height="22px" 
                                        Width="130px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Observación Cliente</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtfobs" runat="server" Height="45px" TextMode="MultiLine" 
                                        Width="99%"></asp:TextBox>
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
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    Casos escalados devueltos&nbsp; <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                    <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="campana" HeaderText="Campaña" />
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="idusuario" HeaderText="Agente Escala" />
                            <asp:BoundField DataField="fcasignado" HeaderText="Fecha Asignado" />
                            <asp:BoundField DataField="obscpd" HeaderText="Observación Devolución" />
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
