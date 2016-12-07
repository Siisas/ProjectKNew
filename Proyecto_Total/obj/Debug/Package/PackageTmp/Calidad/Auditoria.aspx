<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Auditoria.aspx.vb" Inherits="digitacion.Auditoria" %>

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
            color: #000042;
            font-weight: bold;
            width: 15%;
            background: #E2E8FA;
        }
        .style9
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 21%;
            background: #E2E8FA;
        }
        .style10
        {
            width: 21%;
        }
        .style11
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 23%;
            background: #E2E8FA;
        }
        .style12
        {
            width: 23%;
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
                        style="font-size: medium; font-style: italic">Auditoría de Calidad</asp:Label>
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
                                            &nbsp;<asp:Button ID="btnguardar" runat="server" style="height: 26px" 
                                                    Text="Guardar" />
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
                                                Agente</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlagente" runat="server" AutoPostBack="True" 
                                                    Height="22px" Width="322px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Grupo</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtgrupo" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Consecutivo</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtcaso" runat="server"></asp:TextBox>
                                                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                                                    ControlToValidate="txtcaso" ErrorMessage="El caso debe ser un valor numérico" 
                                                    Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                                &nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="btnvalida" runat="server" style="height: 26px" Text="Validar" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Mesa</td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblmesa" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Min</td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblmin" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Solicitud</td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblsolic" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Estado Actual</td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblestado" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Fecha y Hora de Llamada</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtfchora" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Tiempo Acumulado de Llamada</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txttiempo" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Cantidad de Llamdas</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtllamadas" runat="server"></asp:TextBox>
                                                <asp:Label ID="lblidtabla" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Observación General</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtobs11" runat="server" TextMode="MultiLine" Width="608px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Falta Grave</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlfaltaGR" runat="server" AutoPostBack="True" 
                                                    Height="22px" Width="608px">
                                                </asp:DropDownList>
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
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
    
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
    
                                    <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                                        <tr>
                                            <td class="textotittabla">
                                                Tipo</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drltipo" runat="server" 
                                                    Height="21px" Width="133px">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>Protocolo</asp:ListItem>
                                                    <asp:ListItem>Conocimiento</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td class="textotittabla">
                                                Nivel</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlnivel" runat="server" AutoPostBack="True" 
                                                    Height="21px" Width="133px">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>Nivel1</asp:ListItem>
                                                    <asp:ListItem>Nivel3</asp:ListItem>
                                                    <asp:ListItem>Voz</asp:ListItem>
                                                    <asp:ListItem>Datos</asp:ListItem>
                                                    <asp:ListItem>DatosN3</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td class="textotittabla">
                                                <asp:Button ID="btncalcular" runat="server" style="height: 26px" 
                                                    Text="Calcular" />
                                            </td>
                                            <td class="style8">
                                                <asp:Button ID="btnreestab" runat="server" style="height: 26px" 
                                                    Text="Reestablecer" />
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
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
    
                                    <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                                        <tr>
                                            <td class="style9">
                                                ID</td>
                                            <td class="style11">
                                                Peso Calificación</td>
                                            <td class="textotittabla">
                                                Ítem de Calificación</td>
                                            <td class="textotittabla">
                                                Aplica</td>
                                            <td class="textotittabla">
                                                Calificación</td>
                                            <td class="textotittabla">
                                                Total</td>
                                            <td class="textotittabla">
                                                Observación</td>
                                        </tr>
                                        <tr>
                                            <td class="style10">
                                                <asp:Label ID="lblid1" runat="server"></asp:Label>
                                            </td>
                                            <td class="style12">
                                                <asp:Label ID="lblpeso1" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblitem1" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:CheckBox ID="chk1" runat="server" />
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtcalif1" runat="server" Width="92px"></asp:TextBox>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lbltot1" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtobs1" runat="server" TextMode="MultiLine" Width="143px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style10">
                                                <asp:Label ID="lblid2" runat="server"></asp:Label>
                                            </td>
                                            <td class="style12">
                                                <asp:Label ID="lblpeso2" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblitem2" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:CheckBox ID="chk2" runat="server" />
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtcalif2" runat="server" Width="92px"></asp:TextBox>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lbltot2" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtobs2" runat="server" TextMode="MultiLine" Width="143px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style10">
                                                <asp:Label ID="lblid3" runat="server"></asp:Label>
                                            </td>
                                            <td class="style12">
                                                <asp:Label ID="lblpeso3" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblitem3" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:CheckBox ID="chk3" runat="server" />
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtcalif3" runat="server" Width="92px"></asp:TextBox>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lbltot3" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtobs3" runat="server" TextMode="MultiLine" Width="143px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style10">
                                                <asp:Label ID="lblid4" runat="server"></asp:Label>
                                            </td>
                                            <td class="style12">
                                                <asp:Label ID="lblpeso4" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblitem4" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:CheckBox ID="chk4" runat="server" />
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtcalif4" runat="server" Width="92px"></asp:TextBox>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lbltot4" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtobs4" runat="server" TextMode="MultiLine" Width="143px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style10">
                                                <asp:Label ID="lblid5" runat="server"></asp:Label>
                                            </td>
                                            <td class="style12">
                                                <asp:Label ID="lblpeso5" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblitem5" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:CheckBox ID="chk5" runat="server" />
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtcalif5" runat="server" Width="92px"></asp:TextBox>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lbltot5" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtobs5" runat="server" TextMode="MultiLine" Width="143px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style10">
                                                <asp:Label ID="lblid6" runat="server"></asp:Label>
                                            </td>
                                            <td class="style12">
                                                <asp:Label ID="lblpeso6" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblitem6" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:CheckBox ID="chk6" runat="server" />
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtcalif6" runat="server" Width="92px"></asp:TextBox>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lbltot6" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtobs6" runat="server" TextMode="MultiLine" Width="143px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style10">
                                                <asp:Label ID="lblid7" runat="server"></asp:Label>
                                            </td>
                                            <td class="style12">
                                                <asp:Label ID="lblpeso7" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblitem7" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:CheckBox ID="chk7" runat="server" />
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtcalif7" runat="server" Width="92px"></asp:TextBox>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lbltot7" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtobs7" runat="server" TextMode="MultiLine" Width="143px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style10">
                                                <asp:Label ID="lblid8" runat="server"></asp:Label>
                                            </td>
                                            <td class="style12">
                                                <asp:Label ID="lblpeso8" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblitem8" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:CheckBox ID="chk8" runat="server" />
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtcalif8" runat="server" Width="92px"></asp:TextBox>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lbltot8" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtobs8" runat="server" TextMode="MultiLine" Width="143px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style10">
                                                <asp:Label ID="lblid9" runat="server"></asp:Label>
                                            </td>
                                            <td class="style12">
                                                <asp:Label ID="lblpeso9" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblitem9" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:CheckBox ID="chk9" runat="server" />
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtcalif9" runat="server" Width="92px"></asp:TextBox>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lbltot9" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtobs9" runat="server" TextMode="MultiLine" Width="143px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style10">
                                                <asp:Label ID="lblid10" runat="server"></asp:Label>
                                            </td>
                                            <td class="style12">
                                                <asp:Label ID="lblpeso10" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblitem10" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:CheckBox ID="chk10" runat="server" />
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtcalif10" runat="server" Width="92px"></asp:TextBox>
                                            </td>
                                            <td class="celdascons">
                                                <asp:Label ID="lbltot10" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtobs10" runat="server" TextMode="MultiLine" Width="143px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style10">
                                                &nbsp;</td>
                                            <td class="style12">
                                                <asp:Label ID="lblpeso11" runat="server"></asp:Label>
                                            </td>
                                            <td class="celdascons">
                                                &nbsp;</td>
                                            <td class="celdascons">
                                                &nbsp;</td>
                                            <td class="celdascons">
                                                &nbsp;</td>
                                            <td class="celdascons">
                                                <asp:Label ID="lbltot11" runat="server"></asp:Label>
                                            </td>
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
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
    
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
                        GridLines="None" PageSize="1000" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True" Visible="False">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="tipo" HeaderText="tipo" />
                            <asp:BoundField DataField="nivel" HeaderText="Nivel" />
                            <asp:BoundField DataField="item" HeaderText="item" />
                            <asp:BoundField DataField="partic" HeaderText="Partic" />
                            <asp:BoundField DataField="id" HeaderText="id" />
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
