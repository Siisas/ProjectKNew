<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CalibracionSala.aspx.vb" Inherits="digitacion.CalibracionSala" %>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">

 
        
.Color
{
    background-color:#A6A6A6;
    color:White;
    border-color:Black;
    border-style:solid;
}

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
            border-color:Black;
            border-style:solid;
        }
 
        .style8
        {
            width: 100%;
            color:Black;
        }
        
        .style9
        {
            border-color:Black;
            border-style:solid;
            
            
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
                        style="font-size: medium; font-style: italic">Sala de Calibracion</asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style11">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" />
                </td>
                <td valign="top" class="style10">
                    <table class="style8">
                        <tr>
                            <td class="style6">
                                <asp:Label ID="lblusuario" runat="server"></asp:Label>
                            </td>
                            <td class="style7">
                                <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
                                <asp:Label ID="LblPermiso" runat="server"></asp:Label>
                            </td>
                        </tr>
                        </table>
                </td>
                <td class="style11">
                </td>
            </tr>
            <asp:Panel ID="PanelSalaCalibracion" runat="server" Visible="true" > 
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                            <asp:Button ID="BtnCreaSesion" runat="server" Text="Crear Sesión" Visible="False" />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="BtnUnirse" runat="server" Text="Unirse" />
                                <asp:TextBox ID="TxtUnirSesion" runat="server"></asp:TextBox>
                                            <br />
                                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                Mis sesiones de calibración:</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
    
                    <asp:GridView ID="dtgSesionCalibracion" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="15" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Cod_CalibracionSesion" HeaderText="ID" />
                            <asp:BoundField DataField="Fc_Creacion" HeaderText="Fecha de creación" />
                            <asp:BoundField DataField="Fc_Cierre" HeaderText="Fecha de cierre" />
                            <asp:BoundField DataField="Administrador" HeaderText="Administrador" />
                            <asp:BoundField DataField="Estado" HeaderText="Estado" />
                            <asp:ButtonField CommandName="Ver" HeaderText="Acciones " Text="Ver" />
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
                                Invitacion:</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
    
                    <asp:GridView ID="dtgInvitacion" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="15" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Cod_CalibracionSesionInvita" HeaderText="ID" />
                            <asp:BoundField DataField="Fc_Creacion" HeaderText="Fecha de creación" />
                            <asp:BoundField DataField="Fc_Cierre" HeaderText="Fecha de cierre" />
                            <asp:BoundField DataField="Administrador" HeaderText="Administrador" />
                            <asp:BoundField DataField="Fk_Cod_CalibracionSesion" HeaderText="ID Sesión de Calibracion" />
                            <asp:ButtonField CommandName="RespuestaAceptar" HeaderText="Aceptar" DataTextField="Aceptar" />
                            <asp:ButtonField CommandName="RespuestaRechazar" HeaderText="Rechazar" DataTextField="Rechazar" />
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
                                Consolidado Sesiones de calibración:</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
    
                    <asp:GridView ID="dtgTodasSesionesCalibracion" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="15" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Cod_CalibracionSesion" HeaderText="ID" />
                            <asp:BoundField DataField="Fc_Creacion" HeaderText="Fecha de creación" />
                            <asp:BoundField DataField="Fc_Cierre" HeaderText="Fecha de cierre" />
                            <asp:BoundField DataField="Administrador" HeaderText="Administrador" />
                            <asp:BoundField DataField="Estado" HeaderText="Estado" />
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
            </asp:Panel>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <asp:Panel ID="PanelSesion" runat="server" Visible="False">
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                Sesión
                                <asp:Label ID="LblCodigoSesion" runat="server"></asp:Label>
                                &nbsp;<asp:Label ID="LblSesionAU" runat="server"></asp:Label>
                                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                <asp:Button ID="BtnActualizarSesion" runat="server" Text="Actualizar sesión" />
&nbsp;
                                <asp:Button ID="BtnCerrarSesion" runat="server" Text="Cerrar sesión" 
                                    Visible="False" />
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
            <asp:Panel ID="PanelSesionAdmin" runat="server" Visible="False">
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                Adicionar caso a calibrar:</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                     <table border="1" cellpadding="1" cellspacing="1" class="style8">
                        <tr>
                            <td class="textotittabla">
                                Caso</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtCaso" runat="server"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Nombre</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
                            </td>
                        </tr>                        
                        <tr>
                            <td class="textotittabla">
                                Grupo</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtGrupo" runat="server"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Campaña</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtCampania" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    <asp:Button ID="BtnGuardaAdicion" runat="server" Text="Guardar" />
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
                                Vincular usuario:</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <table border="1" cellpadding="1" cellspacing="1" class="style8">
                        <tr>
                            <td class="textotittabla">
                                Codigo</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtCodigo" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                    </table>                    
                    <asp:Button ID="BtnGuardaVincular" runat="server" Text="Guardar" />
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
            </asp:Panel>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                Integrantes de la sesión:</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
    
                    <asp:GridView ID="dtgIntegrantesSesion" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="15" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
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
                                Casos:</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
    
                    <asp:GridView ID="dtgCasos" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="15" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Caso" HeaderText="Caso" />
                            <asp:BoundField DataField="Min_ac" HeaderText="Min" />
                            <asp:BoundField DataField="Nombre" HeaderText="Agente" />
                            <asp:BoundField DataField="Grupo" HeaderText="Grupo" />
                            <asp:BoundField DataField="Campania" HeaderText="Campaña" />
                            <asp:BoundField DataField="N_Registro" HeaderText="N° Registros" />
                            <asp:ButtonField CommandName="Registrar" HeaderText="Accion" Text="Registrar" />
                            <asp:ButtonField CommandName="Ver" HeaderText="Acciones " Text="Ver" />
                            <asp:ButtonField CommandName="RegistrarConsenso" HeaderText="Acciones " 
                                Text="Registrar consenso" />
                            <asp:ButtonField CommandName="Consultar_Macro" HeaderText="Acciones " 
                                Text="Consultar Macro" />
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                    
                    <asp:GridView ID="dtgCasosVoz" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="15" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Caso" HeaderText="Caso" />
                            <asp:BoundField DataField="Min_ac" HeaderText="Min" />
                            <asp:BoundField DataField="Nombre" HeaderText="Agente" />
                            <asp:BoundField DataField="Grupo" HeaderText="Grupo" />
                            <asp:BoundField DataField="Campania" HeaderText="Campaña" />
                            <asp:BoundField DataField="N_Registro" HeaderText="N° Registros" />
                            <asp:ButtonField CommandName="Registrar" HeaderText="Accion" Text="Registrar" />
                            <asp:ButtonField CommandName="Ver" HeaderText="Acciones " Text="Ver" />
                            <asp:ButtonField CommandName="RegistrarConsenso" HeaderText="Acciones " 
                                Text="Registrar consenso" />
                            <asp:ButtonField CommandName="Consultar_Macro" HeaderText="Acciones " 
                                Text="Consultar Macro" />
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                                <asp:Button ID="BtnVolver" runat="server" Text="Volver" />
                                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </asp:Panel>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <asp:Panel ID="PanelRegistroCalibracion" runat="server" Visible="False">
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%" valign="top">
                    <table class="style2" border="2">
                        <tr>
                            <td width="65%">
                                <table class="style8">
                                    <tr>
                                        <td width="40%">
                                            <table class="style2" border="2">
                                                <tr>
                                                    <td width="40%">
                                                        <center><asp:Image ID="Image1" runat="server" ImageUrl="~/LOGO.jpg" 
                                                                Height="67px"  /></center>
                                                    </td>
                                                 </tr>
                                            </table>
                                        </td>
                                        <td width="40%">
                                            <table class="style2" border="2">
                                                <tr>
                                                    <td width="40%">
                                                        <center><asp:Label ID="LblTitulo" runat="server" Text="SISTEMA DE GESTION DE CALIDAD"></asp:Label></center>
                                                    </td>
                                                    <td width="50%" class="style9" colspan="2">
                                                        <center>GCM-F-24</center>
                                                    </td>
                                                 </tr>
                                                <tr>
                                                    <td width="40%">
                                                    <center><asp:Label ID="LblTitulo1" runat="server" Text="GESTION DE CALIDAD Y MEJORA"></asp:Label></center>
                                                    </td>
                                                    <td class="style9">
                                                        <center>FECHA<asp:Label ID="LblFecha" runat="server" Visible="False"></asp:Label></center>
                                                        <center>17/09/2014</center>                                            
                                                    </td>
                                                    <td class="style9">
                                                        <center>VERSION</center>
                                                        <center>1</center>
                                                    </td>
                                                 </tr>
                                                <tr>
                                                    <td width="40%">
                                                    <center><asp:Label ID="LblTitulo2" runat="server" Text="AUDITORIA"></asp:Label></center>
                                                    </td>
                                                    <td class="style9" colspan="2">
                                                        <center>Página 1 DE 1</center>
                                                    </td>
                                                 </tr>
                                            </table> 
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    <table class="style2" border="2">
                        <tr>
                            <td width="50%" class="style9">
                                NUMERO DE CONSECUTIVO</td>
                            <td width="50%" class="style9">
                                            <asp:Label ID="Lblcaso" runat="server"></asp:Label>
                                            
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                                NOMBRE DE INGENIERO/AGENTE DE SOPORTE</td>
                            <td class="style9">
                                <asp:Label ID="LblNomAgente" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                                GRUPO</td>
                            <td class="style9">
                                <asp:Label ID="LblGrupo" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                                EVALUADOR</td>
                            <td class="style9">
                                <asp:Label ID="LblAuditor" runat="server"></asp:Label>
                                
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                                CAMPAÑA</td>
                            <td class="style9">
                                <asp:Label ID="LblCampaña" runat="server"></asp:Label>
                            </td>
                        </tr>
                        </table>
                    <table class="style2" border="2">
                        <tr>
                            <td class="Color" >
                            <center>Errores Criticos</center>
                            </td>
                        </tr>
                    </table>
                    <table class="style2" border="2">
                        <tr>
                            <td width="30%" class="Color" >
                                <center>ITEM</center>
                                </td>
                            <td width="20%" class="Color">
                                <center>CALIFICACION</center>
                                </td>
                            <td width="50%" class="Color">
                                <center>OBSERVACION</center>
                                </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center><asp:Label ID="LblItem1" runat="server" Text="Amabilidad y Empatia" 
                                    
                                    ToolTip="Se enfrenta o interrumpe al cliente de manera continúa durante la llamada, utiliza expresiones de ironía, burlescas o recalcadas, demuestra impaciencia e intolerancia con el cliente.  El trato debe ser cálido, mantener en todo momento la calma y tolerancia, respeta las opiniones del cliente."></asp:Label>
                                </center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:DropDownList ID="drlAmabilidad_Empatia" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>100</asp:ListItem>
                                    <asp:ListItem>0</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblAmabilidad_Empatia" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Amabilidad_Empatia" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Amabilidad_Empatia" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center><asp:Label ID="LblItem2" runat="server" Text="Colgada de Llamada" 
                                    ToolTip="Consultor finaliza la llamada sin atender el requerimiento al cliente o permite que el cliente cuelgue por falta de atención. (Hold o espera prolongada  sin retomar la llamada."></asp:Label></center>
                            </td>
                            <td class="style9">                            
                            <center>
                                <asp:DropDownList ID="drlColgada_Llamada" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>100</asp:ListItem>
                                    <asp:ListItem>0</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblColgada_Llamada" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Colgada_Llamada" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Colgada_Llamada" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center><asp:Label ID="LblItem3" runat="server" Text="Realiza filtros adecuados" 
                                    ToolTip="Soluciona en el menor tiempo posible y de manera eficaz la necesidad del cliente, es coherente con el tiempo de la llamada; utiliza en forma adecuada las herramientas disponibles para realizar las diferentes consultas que requiere el caso .  Indaga y realiza preguntas que lo llevan a identificar el requerimiento exacto del cliente."></asp:Label></center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:DropDownList ID="drlRealiza_Filtro_A" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>100</asp:ListItem>
                                    <asp:ListItem>0</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblRealiza_Filtro_A" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Realiza_Filtro_A" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Realiza_Filtro_A" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center><asp:Label ID="LblItem4" runat="server" Text="Corona Abierta" 
                                    ToolTip="El consultor debe realizar acompañamiento continuo para evitar que el cliente perciba el ruido del ambiente laboral durante el desarrollo de la llamada (situaciones como: Intrucciones dentro de la operación por parte del personal administrativo, conversaciones entre consultores, digitación del teclado por tiempos extensos y otros escenarios que afecten ante el cliente el buen nombre de la compañía."></asp:Label></center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:DropDownList ID="drlCorona_Abierta" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>100</asp:ListItem>
                                    <asp:ListItem>0</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblCorona_Abierta" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Corona_Abierta" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Corona_Abierta" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center><asp:Label ID="LblItem5" runat="server" Text="Documentación" 
                                    ToolTip="Se afecta al consultor cuando: • Ingresa a las cuentas y no registra las acciones o información brindada al cliente. • Cuando deja comentarios con informacion que no corresponde a la gestion realizada. • Cuando no tipifica de forma adecuada."></asp:Label></center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:DropDownList ID="drlDocumentacion" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>100</asp:ListItem>
                                    <asp:ListItem>0</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblDocumentacion" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Documentacion" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Documentacion" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center><asp:Label ID="LblItem6" runat="server" Text="Procedimiento de PQR" 
                                    ToolTip="• Aplica correctamente los procedimientos relacionados con tipología de PQR, para cierre de fallatec/soportec/SMS queja. • No documenta tickler terminos"></asp:Label></center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:DropDownList ID="drlProcedimiento_PQR" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>100</asp:ListItem>
                                    <asp:ListItem>0</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblProcedimiento_PQR" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Procedimiento_PQR" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Procedimiento_PQR" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center><asp:Label ID="LblItem7" runat="server" 
                                    Text="Procedimientos pruebas y trámites incompletos o incorrectos" 
                                    ToolTip="• Consultor debe informar y aplicar de forma completa  y correcta los procesos y pruebas establecidas para el tipo de falla reportado por el cliente, evitando escalamientos innecesarios a tercer nivel, procurando una respuesta de acuerdo a los lineamientos y procesos establecidos. • Consulta todos los aplicativos dados por la compañia para realizar el diagnostico y suministrar una respuesta a la solucuitud del cliente.  • Cuando no captura o no toma los datos que permitan identificar la falla, dar una solucion optima o en su defecto generar el escalamiento correspondiente a el area resolutora con toda la informacion requerida. (CHEK LIST).  •No Reporta la inconsistencia identificada."></asp:Label></center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:DropDownList ID="drlProcedimiento_Prueb_Tram_Incom_Incorrec" 
                                    runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>100</asp:ListItem>
                                    <asp:ListItem>0</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblProcedimiento_Prueb_Tram_Incom_Incorrec" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Procedimiento_Prueb_Tram_Incom_Incorrec" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Procedimiento_Prueb_Tram_Incom_Incorrec" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                    </table>
                    <table class="style2" border="2">
                        <tr>
                            <td class="Color">
                            <center>Errores De Gestion (NO CRITICO)</center>
                            </td>
                        </tr>
                    </table>
                    <table class="style2" border="2">
                        <tr>
                            <td width="30%">                            
                            <center>
                                <asp:Label ID="LblItem8" runat="server" 
                                    Text="Presenta el objetivo de la llamada" 
                                    ToolTip="Al generar contacto con el cliente informa el motivo de la llamada, aclarando a que tipo de servicio  se dara el soporte."></asp:Label>
                                </center>
                            </td>
                            <td width="20%">
                            <center>
                                <asp:DropDownList ID="drlPresenta_Obj_Llamada" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                    <asp:ListItem>0</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblPresenta_Obj_Llamada" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td width="50%">
                            <center>
                                <asp:TextBox ID="TxtObs_Presenta_Obj_Llamada" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Presenta_Obj_Llamada" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center><asp:Label ID="LblItem9" runat="server" Text="Cordialidad y Comunicación" 
                                    ToolTip="Evidencia una correcta vocalización, pronunciación, articulacióon, entonación e intesidad utilizando un lenguaje apropiado evitando tecnicismos o jergas inadecuadas. Evidencia cordialidad con la que atiende a los clientes manifestando el gusto y/o entusiasmo por atenderlos. Tiene fluidez verbal al dirigirse con el cliente, encontrando palabras precisas en el momento indicado, hace que su comunicación sea grata y armoniosa, con una adecuada entonación y dicción, genera combinación de sucesos de voces y dinamismo al hablar. En las interlocuciones con el usuario es importante solicitar el nombre y hacer uso de el mínimo 2 veces, utiliza títulos de respeto, evita respiraciones audibles ocasionadas por cercanía al tubo acústico, brinda la información de manera oportuna evitando interrumpir al usuario esporádicamente"></asp:Label></center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:DropDownList ID="drlCordialidad_Comunicacion" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                    <asp:ListItem>0</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblCordialidad_Comunicacion" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Cordialidad_Comunicacion" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Cordialidad_Comunicacion" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center>
                                <asp:Label ID="LblItem10" runat="server" 
                                    Text="Claridad al transmitir la información" 
                                    ToolTip="Evita Explicar en forma mecanica los procedimientos y tramites, se coloca en el lugar del cliente para brindar informaciòn pausada y coherente de principio a fin."></asp:Label></center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:DropDownList ID="drlClaridad_Transmitir_Inf" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                    <asp:ListItem>0</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblClaridad_Transmitir_Inf" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Claridad_Transmitir_Inf" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Claridad_Transmitir_Inf" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center><asp:Label ID="LblItem11" runat="server" Text="Seguridad" 
                                    ToolTip="No duda al suministrar la información y transmite confianza al cliente, tiene el control de la llamada. El líder de servicio debe apoderarse de la situación planteada desde el principio evitando realizar preguntas cuyas respuestas están en el sistema. Evita referirse a Claro como un tercero."></asp:Label></center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:DropDownList ID="drlSeguridad" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                    <asp:ListItem>0</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblSeguridad" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Seguridad" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Seguridad" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center><asp:Label ID="LblItem12" runat="server" 
                                    
                                    
                                    Text="Utiliza guion de saludo y nombre completo/Guiones de etiqueta telefonica" 
                                    ToolTip="Utiliza los guiones establecidos por la compañía  para el manejo de etiqueta telefonica. Utiliza guion de saludo y despedida.  Se identifica con nombre completo."></asp:Label></center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:DropDownList ID="drlUtiliza_Guion_Saludo_Nom" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                    <asp:ListItem>0</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblUtiliza_Guion_Saludo_Nom" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Utiliza_Guion_Saludo_Nom" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Utiliza_Guion_Saludo_Nom" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        </table>
                    <table class="style2" border="2">
                        <tr>
                            <td class="Color">
                            <center>Errores Criticos Internas Kamilion</center>
                            </td>
                        </tr>
                    </table>
                    <table class="style2" border="2">
                        <tr>
                            <td width="30%" class="style9">                            
                            <center><asp:Label ID="LblItem13" runat="server" Text="Gestion de Llamada" 
                                    ToolTip="Tipifica de manera correcta el resultado de la gestion realizada al caso en CRM (Cerrado, Escalado, gestionado, rechazado, Previamente Cerrado) de acuerdo a la gestion realizada durante (la o las) llamadas generadas."></asp:Label>
                                </center>
                                </td>
                            <td width="20%" class="style9">
                            <center>
                                <asp:DropDownList ID="drlGestion_Llamada" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>100</asp:ListItem>
                                    <asp:ListItem>0</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblGestion_Llamada" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td width="50%" class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Gestion_Llamada" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Gestion_Llamada" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center><asp:Label ID="LblItem14" runat="server" Text="Gestion de Soporte" 
                                    ToolTip="Tipifica cada uno de los parametros que son parte relevante del diagnostico, gestion y cierre del caso teniendo en cuenta el tipo de requerimiento reportado por el usuario."></asp:Label></center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:DropDownList ID="drlGestion_Soporte" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>100</asp:ListItem>
                                    <asp:ListItem>0</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblGestion_Soporte" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Gestion_Soporte" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Gestion_Soporte" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center><asp:Label ID="LblItem15" runat="server" Text="Gestion de Asignacion" 
                                    ToolTip="Diligencia de manera correta y completa la solicitu de de escalamiento a las areas Tenicas e Informatica en las herramientas disponibles para dicha gestion."></asp:Label></center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:DropDownList ID="drlGestion_Asignacion" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>100</asp:ListItem>
                                    <asp:ListItem>0</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblGestion_Asignacion" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Gestion_Asignacion" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Gestion_Asignacion" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center><asp:Label ID="LblItem16" runat="server" Text="Gestion de Cierre" 
                                    ToolTip="Confirma con el usuario el estado en el cual quedara el caso o la reclamacion."></asp:Label></center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:DropDownList ID="drlGestion_Cierre" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>100</asp:ListItem>
                                    <asp:ListItem>0</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblGestion_Cierre" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Gestion_Cierre" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Gestion_Cierre" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                                <center>
                                    <asp:Label ID="LblReincide1" runat="server" Text="Reincide" ToolTip="El ingeniero tiene en cuenta las recomendaciones realizadas en las ultimas retroalimentaciones generadas."></asp:Label></center>
                            </td>
                            <td class="style9">
                                <center>
                                    <asp:DropDownList ID="DrlReincide" runat="server">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Si</asp:ListItem>
                                        <asp:ListItem>No</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:Label ID="LblReincide" runat="server"></asp:Label>
                                </center>
                            </td>
                            <td class="style9">
                                <center>
                                    <asp:TextBox ID="TxtObsReincide" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                    <asp:Label ID="LblObs_Reincide" runat="server"></asp:Label>
                                </center>
                            </td>
                        </tr>
                        </table>


                    <table class="style2" border="2">
                        <tr>
                            <td class="Color">
                            <center>Variables Estadisticas</center>
                            </td>
                        </tr>
                    </table>
                    <table class="style2" border="2">
                        <tr>
                            <td width="30%" class="style9">
                                <center><asp:Label ID="LblItem17" runat="server" Text="Solución" 
                                        ToolTip="Asesor logró resolver las inquietudes y peticiones del cliente en el primer contacto de acuerdo a los procedimientos establecidos por la compañía."></asp:Label></center>
                                </td>
                            <td width="20%" class="style9">
                            <center>
                                <asp:DropDownList ID="drlSolucion" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>SI</asp:ListItem>
                                    <asp:ListItem>NO</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblSolucion" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td width="50%" class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Solucion" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Solucion" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center>
                                <asp:Label ID="LblItem18" runat="server" 
                                    Text="Interés en escuchar, entender sus necesidades y plantear soluciones" 
                                    ToolTip="No se apersona del requerimiento, poca disposición en atender al cliente, no ofrece alternativas, remitea  otra instancia teniendo los recursos para brindar la solución, no consulta las herraminetas disponibles para obtener información completa y correcta de los procedimientos y trámites."></asp:Label></center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:DropDownList ID="drlInteres_Escucha" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>SI</asp:ListItem>
                                    <asp:ListItem>NO</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LblInteres_Escucha" runat="server"></asp:Label>
                            </center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:TextBox ID="TxtObs_Interes_Escucha" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                <asp:Label ID="LblObs_Interes_Escucha" runat="server"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        </table>

                    <table class="style2" border="2">
                        <tr>
                            <td class="style9">
                            <center><asp:Label ID="Label23" runat="server" Text="OBSERVACIONES GENERALES:"></asp:Label>                            
                                <br />
                                <asp:TextBox ID="TxtObs_Generales" runat="server" TextMode="MultiLine" 
                                    Width="1000px"></asp:TextBox>
                                <asp:Label ID="LblObs_Generales" runat="server"></asp:Label>
                            </center>
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
                    <asp:Button ID="btnguardar" runat="server" Text="Guardar" />
                    <asp:Button ID="BtnVolver1" runat="server" Text="Volver" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </asp:Panel>
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
                                &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <asp:Panel ID="PanelMacro" runat="server" Visible="false">
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <center>Macro <asp:Label ID="LblMacro" runat="server"></asp:Label>
                                </center>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" valign="top" class="style3">
                
                    <asp:GridView ID="dtgMacro" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="15" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Auditor" HeaderText="Auditor" />
                            <asp:BoundField DataField="1" HeaderText="Item 1" />
                            <asp:BoundField DataField="2" HeaderText="Item 2" />
                            <asp:BoundField DataField="3" HeaderText="Item 3" />
                            <asp:BoundField DataField="4" HeaderText="Item 4" />
                            <asp:BoundField DataField="5" HeaderText="Item 5" />
                            <asp:BoundField DataField="6" HeaderText="Item 6" />
                            <asp:BoundField DataField="7" HeaderText="Item 7" />
                            <asp:BoundField DataField="8" HeaderText="Item 8" />
                            <asp:BoundField DataField="9" HeaderText="Item 9" />
                            <asp:BoundField DataField="10" HeaderText="Item 10" />
                            <asp:BoundField DataField="11" HeaderText="Item 11" />
                            <asp:BoundField DataField="12" HeaderText="Item 12" />
                            <asp:BoundField DataField="13" HeaderText="Item 13" />
                            <asp:BoundField DataField="14" HeaderText="Item 14" />
                            <asp:BoundField DataField="15" HeaderText="Item 15" />
                            <asp:BoundField DataField="16" HeaderText="Item 16" />
                            <asp:BoundField DataField="Reproducibilidad" HeaderText="Reproducibilidad"/>
                            <asp:BoundField HeaderText="Precision"/>
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" valign="top" class="style3">                    
                    <asp:Button ID="BtnVolver2" runat="server" Text="Volver" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>       
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" valign="top" class="style3">
                <table class="style2" border="2">
                        <tr>
                            <td width="5%" class="Color" >
                                <center>N°</center>
                                </td>
                            <td width="45%" class="Color">
                                <center>ITEM</center>
                                </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center>1</center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:Label ID="LblItem1Vista" runat="server" Text="Amabilidad y Empatia" 
                                    
                                    ToolTip="Se enfrenta o interrumpe al cliente de manera continúa durante la llamada, utiliza expresiones de ironía, burlescas o recalcadas, demuestra impaciencia e intolerancia con el cliente.  El trato debe ser cálido, mantener en todo momento la calma y tolerancia, respeta las opiniones del cliente."></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center>2</center>
                            </td>
                            <td class="style9">                            
                            <center>
                                <asp:Label ID="LblItem2Vista" runat="server" Text="Colgada de Llamada" 
                                    ToolTip="Consultor finaliza la llamada sin atender el requerimiento al cliente o permite que el cliente cuelgue por falta de atención. (Hold o espera prolongada  sin retomar la llamada."></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center>3</center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:Label ID="LblItem3Vista" runat="server" Text="Realiza filtros adecuados" 
                                    ToolTip="Soluciona en el menor tiempo posible y de manera eficaz la necesidad del cliente, es coherente con el tiempo de la llamada; utiliza en forma adecuada las herramientas disponibles para realizar las diferentes consultas que requiere el caso .  Indaga y realiza preguntas que lo llevan a identificar el requerimiento exacto del cliente."></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center>4</center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:Label ID="LblItem4Vista" runat="server" Text="Corona Abierta" 
                                    ToolTip="El consultor debe realizar acompañamiento continuo para evitar que el cliente perciba el ruido del ambiente laboral durante el desarrollo de la llamada (situaciones como: Intrucciones dentro de la operación por parte del personal administrativo, conversaciones entre consultores, digitación del teclado por tiempos extensos y otros escenarios que afecten ante el cliente el buen nombre de la compañía."></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center>5</center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:Label ID="LblItem5Vista" runat="server" Text="Documentación" 
                                    ToolTip="Se afecta al consultor cuando: • Ingresa a las cuentas y no registra las acciones o información brindada al cliente. • Cuando deja comentarios con informacion que no corresponde a la gestion realizada. • Cuando no tipifica de forma adecuada."></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center>6</center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:Label ID="LblItem6Vista" runat="server" Text="Procedimiento de PQR" 
                                    ToolTip="• Aplica correctamente los procedimientos relacionados con tipología de PQR, para cierre de fallatec/soportec/SMS queja. • No documenta tickler terminos"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center>7</center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:Label ID="LblItem7Vista" runat="server" 
                                    Text="Procedimientos pruebas y trámites incompletos o incorrectos" 
                                    ToolTip="• Consultor debe informar y aplicar de forma completa  y correcta los procesos y pruebas establecidas para el tipo de falla reportado por el cliente, evitando escalamientos innecesarios a tercer nivel, procurando una respuesta de acuerdo a los lineamientos y procesos establecidos. • Consulta todos los aplicativos dados por la compañia para realizar el diagnostico y suministrar una respuesta a la solucuitud del cliente.  • Cuando no captura o no toma los datos que permitan identificar la falla, dar una solucion optima o en su defecto generar el escalamiento correspondiente a el area resolutora con toda la informacion requerida. (CHEK LIST).  •No Reporta la inconsistencia identificada."></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%">                            
                            <center>8</center>
                            </td>
                            <td width="20%">
                            <center>
                                <asp:Label ID="LblItem8Vista" runat="server" 
                                    Text="Presenta el objetivo de la llamada" 
                                    ToolTip="Al generar contacto con el cliente informa el motivo de la llamada, aclarando a que tipo de servicio  se dara el soporte."></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center>9</center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:Label ID="LblItem9Vista" runat="server" Text="Cordialidad y Comunicación" 
                                    ToolTip="Evidencia una correcta vocalización, pronunciación, articulacióon, entonación e intesidad utilizando un lenguaje apropiado evitando tecnicismos o jergas inadecuadas. Evidencia cordialidad con la que atiende a los clientes manifestando el gusto y/o entusiasmo por atenderlos. Tiene fluidez verbal al dirigirse con el cliente, encontrando palabras precisas en el momento indicado, hace que su comunicación sea grata y armoniosa, con una adecuada entonación y dicción, genera combinación de sucesos de voces y dinamismo al hablar. En las interlocuciones con el usuario es importante solicitar el nombre y hacer uso de el mínimo 2 veces, utiliza títulos de respeto, evita respiraciones audibles ocasionadas por cercanía al tubo acústico, brinda la información de manera oportuna evitando interrumpir al usuario esporádicamente"></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center>10</center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:Label ID="LblItem10Vista" runat="server" 
                                    Text="Claridad al transmitir la información" 
                                    ToolTip="Evita Explicar en forma mecanica los procedimientos y tramites, se coloca en el lugar del cliente para brindar informaciòn pausada y coherente de principio a fin."></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center>11</center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:Label ID="LblItem11Vista" runat="server" Text="Seguridad" 
                                    ToolTip="No duda al suministrar la información y transmite confianza al cliente, tiene el control de la llamada. El líder de servicio debe apoderarse de la situación planteada desde el principio evitando realizar preguntas cuyas respuestas están en el sistema. Evita referirse a Claro como un tercero."></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center>12</center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:Label ID="LblItem12Vista" runat="server"
                                    Text="Utiliza guion de saludo y nombre completo/Guiones de etiqueta telefonica" 
                                    ToolTip="Utiliza los guiones establecidos por la compañía  para el manejo de etiqueta telefonica. Utiliza guion de saludo y despedida.  Se identifica con nombre completo."></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" class="style9">                            
                            <center>13</center>
                                </td>
                            <td width="20%" class="style9">
                            <center>
                                <asp:Label ID="LblItem13Vista" runat="server" Text="Gestion de Llamada" 
                                    ToolTip="Tipifica de manera correcta el resultado de la gestion realizada al caso en CRM (Cerrado, Escalado, gestionado, rechazado, Previamente Cerrado) de acuerdo a la gestion realizada durante (la o las) llamadas generadas."></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center>14</center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:Label ID="LblItem14Vista" runat="server" Text="Gestion de Soporte" 
                                    ToolTip="Tipifica cada uno de los parametros que son parte relevante del diagnostico, gestion y cierre del caso teniendo en cuenta el tipo de requerimiento reportado por el usuario."></asp:Label>
                            </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center>15</center>
                            </td>
                            <td class="style9">
                            <center><asp:Label ID="LblItem15Vista" runat="server" Text="Gestion de Asignacion" 
                                    ToolTip="Diligencia de manera correta y completa la solicitu de de escalamiento a las areas Tenicas e Informatica en las herramientas disponibles para dicha gestion."></asp:Label></center>
                                </td>
                        </tr>
                        <tr>
                            <td class="style9">
                            <center>16</center>
                            </td>
                            <td class="style9">
                            <center>
                                <asp:Label ID="LblItem16Vista" runat="server" Text="Gestion de Cierre" 
                                    ToolTip="Confirma con el usuario el estado en el cual quedara el caso o la reclamacion."></asp:Label>
                            </center>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </asp:Panel>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </table>
    
    </form>
</body>
</html>