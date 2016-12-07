<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="devolucionservice.aspx.vb" Inherits="digitacion.devolucionservice" %>

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
                        style="font-size: medium; font-style: italic">Devolución y Corrección de Escalamiento Service Datos</asp:Label>
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
                                    Anula Falla Service</td>
                                <td>
                                    <asp:CheckBox ID="chkanula" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Variables de Diagnóstico</td>
                                <td>
                                    <asp:RadioButtonList ID="rdbron" runat="server" AutoPostBack="True" 
                                        Font-Size="XX-Small">
                                        <asp:ListItem Selected="True">Error en Registro</asp:ListItem>
                                        <asp:ListItem>Ajeno a Red Celular</asp:ListItem>
                                        <asp:ListItem>Asociado Red Celular</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                                <td class="textotittabla">
                                    &nbsp;</td>
                                <td>
                                    <asp:DropDownList ID="drlvariable" runat="server" AutoPostBack="True" 
                                        Height="22px" Width="322px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Apn</td>
                                <td>
                                    <asp:DropDownList ID="drlapn" runat="server" Height="22px" Width="322px">
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Fecha Activación</td>
                                <td>
                                    <asp:TextBox ID="txtfcactivacion" runat="server" MaxLength="10" 
                                        placeholder="dd/mm/aaaa" Width="136px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    QoS</td>
                                <td>
                                    <asp:DropDownList ID="drlqos" runat="server" Height="22px" Width="322px">
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Archivo</td>
                                <td>
                                    <asp:FileUpload ID="FileDocumento" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Observación</td>
                                <td>
                                    <asp:TextBox ID="Txtobs" runat="server" Height="86px" TextMode="MultiLine" 
                                        Width="327px"></asp:TextBox>
                                </td>
                                <td class="textotittabla">
                                    Archivo</td>
                                <td>
                                    <asp:HyperLink ID="hlkarchivo" runat="server" Target="_blank">Archivo</asp:HyperLink>
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
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                         <asp:ButtonField CommandName="Seleccion" HeaderText="Selección" 
                                Text="Seleccion" />
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="obsescal" HeaderText="Observación Escalamiento" />
                            <asp:BoundField DataField="apn" HeaderText="Apn" />
                            <asp:BoundField DataField="qos" HeaderText="QoS" />
                            <asp:BoundField DataField="Detalle" HeaderText="Tipificación" />
                            <asp:BoundField DataField="idusuarioescala" HeaderText="Agente Reporta" />
                            <asp:BoundField DataField="fcregserv" HeaderText="Fecha Reporte" />
                            <asp:BoundField DataField="fcasignado" HeaderText="Fecha Asignado" />
                            <asp:BoundField DataField="fcprocesado" HeaderText="Fecha Devolución" />
                            <asp:BoundField DataField="idusuarioserv" HeaderText="Agente Devuelve" />
                            <asp:BoundField DataField="obsescalamiento" HeaderText="Observación Devolución" />
                            <asp:TemplateField HeaderText="Documento">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink2" runat="server" 
                                            text='<%#Databinder.Eval(container, "DataItem.archivo")%>' 
                                            NavigateUrl='<%#Databinder.Eval(container, "DataItem.archivo","~/DatosCRM/data_Doc/{0}")%>' 
                                            Target='_blank'></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
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
