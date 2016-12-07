<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Seguimasig.aspx.vb" Inherits="digitacion.Seguimasig" %>

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
            height: 65px;
        }
        .style11
        {
            color: #000099;
            width: 15%;
            height: 65px;
        }
       
                                
        .style1
        {
            width: 100%; height:22%;
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
                        style="font-size: medium; font-style: italic">Seguimiento Asignados Solicitudes Claro</asp:Label>
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
                        </table>
                </td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="style8">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style9">
                                &nbsp;<asp:LinkButton ID="lnkseguimiento" runat="server">Seguimiento Solicitud</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton ID="lnkconsulta" runat="server">Consulta General</asp:LinkButton>
                                &nbsp;&nbsp;
                                <asp:Label ID="lblidasig" runat="server" Font-Size="XX-Small"></asp:Label>
                                </td>
                <td class="style8">
                    </td>
            </tr>
            <tr>
                <td class="style10">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" />
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style11">
                                <asp:Panel ID="pnseguimiento" runat="server" Visible="False">
                                    <asp:Button ID="btnconsultar" runat="server" style="height: 26px" 
                                        Text="Consultar" />
                                    &nbsp;&nbsp;
                                    <asp:Button ID="btnguardarseg" runat="server" style="height: 26px" 
                                        Text="Guardar" />
                                    <br />
                                    <br />
                                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                                        <tr>
                                            <td class="textotittabla">
                                                Solicitud
                                            </td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtidreg" runat="server"></asp:TextBox>
                                            </td>
                                            <td class="textotittabla">
                                                Solicitud</td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblidsolic" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Tipo De Solicitud</td>
                                            <td class="celdascons">
                                                <asp:Label ID="lbltipo" runat="server"></asp:Label>
                                            </td>
                                            <td class="textotittabla">
                                                Prioridad</td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblprioridad" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Descripción</td>
                                            <td class="celdascons">
                                                <asp:Label ID="lbldescrip" runat="server"></asp:Label>
                                            </td>
                                            <td class="textotittabla">
                                                Adjunto</td>
                                            <td class="celdascons">
                                                <asp:HyperLink ID="hpladjunto" runat="server">[hpladjunto]</asp:HyperLink>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Estado</td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblestado" runat="server"></asp:Label>
                                            </td>
                                            <td class="textotittabla">
                                                Fecha Probable Respuesta</td>
                                            <td class="celdascons">
                                                <asp:Label ID="lblfcprobable" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Estado</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlestadoact" runat="server" Height="22px" Width="322px">
                                                </asp:DropDownList>
                                            </td>
                                            <td class="textotittabla">
                                                &nbsp;</td>
                                            <td class="celdascons">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Observación Seguimiento</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="txtobsseg" runat="server" Height="45px" TextMode="MultiLine" 
                                                    Width="99%"></asp:TextBox>
                                            </td>
                                            <td class="textotittabla">
                                                Nuevo Adjunto</td>
                                            <td class="celdascons">
                                                <asp:FileUpload ID="Fluadjuntoseg" runat="server" />
                                            </td>
                                        </tr>
                                    </table>
                                    <br />
                                    Registros Guardados<br />
                                    <br />
                                    <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                                        GridLines="None" PageSize="10" style="font-size: x-small" Width="100%">
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <Columns>
                                            <asp:BoundField DataField="idsolicitud" HeaderText="ID" />
                                            <asp:BoundField DataField="descestado" HeaderText="Estado" />
                                            <asp:BoundField DataField="obsrespuesta" HeaderText="Observación" />
                                            <asp:BoundField DataField="idusuario" HeaderText="Usuario" />
                                            <asp:BoundField DataField="fcreg" HeaderText="Fecha" />
                                            <asp:BoundField DataField="fuente" HeaderText="Fuente" />
                                            <asp:BoundField DataField="Interno" HeaderText="Tipo" />
                                            <asp:TemplateField HeaderText="Archivo">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink2" runat="server" 
                                            text='<%#Databinder.Eval(container, "DataItem.archivoseg")%>' 
                                            NavigateUrl='<%#Databinder.Eval(container, "DataItem.archivoseg","~/SolicClaro/data/{0}")%>' 
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
                                    <br />
                                    <br />
                                    <br />
                                </asp:Panel>
                </td>
                <td class="style10">
                    </td>
            </tr>
            <tr>
                <td class="style10">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style11">
                                <asp:Panel ID="pnconsulta" runat="server" Visible="False">
                                    Registros Encontrados:<asp:Label ID="lblcantidad" runat="server"></asp:Label>
                                    &nbsp;<asp:GridView ID="dtgconsulta" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" 
                                        ForeColor="#333333" GridLines="None" PageSize="10" style="font-size: x-small" 
                                        Width="100%">
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <Columns>
                                            <asp:BoundField DataField="idsolicitud" HeaderText="ID" />
                                            <asp:BoundField DataField="descsolicitud" HeaderText="Tipo" />
                                            <asp:BoundField DataField="descprioridad" HeaderText="Prioridad" />
                                            <asp:BoundField DataField="obssolicitud" HeaderText="Solicitud" />
                                            <asp:BoundField DataField="idusuario_solic" HeaderText="Usuario" />
                                            <asp:BoundField DataField="fcreg_solic" HeaderText="Fecha Registro" />
                                            <asp:BoundField DataField="descestado" HeaderText="Estado" />
                                            <asp:BoundField DataField="fcprobable" HeaderText="Fecha Probable" />
                                            <asp:BoundField DataField="fcreal" HeaderText="Fecha Real" />
                                            <asp:TemplateField HeaderText="Archivo">
                                                <ItemTemplate>
                                                    <asp:HyperLink ID="HyperLink3" runat="server" 
                                                        NavigateUrl='<%#Databinder.Eval(container, "DataItem.arc_solicitud","~/SolicClaro/data/{0}")%>' 
                                                        Target="_blank" text='<%#Databinder.Eval(container, "DataItem.arc_solicitud")%>'></asp:HyperLink>
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
                                    <br />
                                </asp:Panel>
                </td>
                <td class="style10">
                    &nbsp;</td>
            </tr>
            </table>
    
    </form>
</body>
</html>
