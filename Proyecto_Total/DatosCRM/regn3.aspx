<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="regn3.aspx.vb" Inherits="digitacion.regn3" %>

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
            margin-top: 0px;
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
                        style="font-size: medium; font-style: italic">Registro CRM Nivel 3</asp:Label>
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
                                &nbsp;&nbsp;<asp:Label ID="LblPerfil" runat="server" Font-Size="X-Large" ForeColor="#0000CC"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="LblSuperVisorTitulo" runat="server" Text="Supervisor: "></asp:Label><asp:Label ID="LblSupervisor" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 30%" rowspan="1">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Caso</td>
                            <td class="celdascons">
                                            <asp:TextBox ID="txtcaso" runat="server" Width="138px"></asp:TextBox>
                                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                ControlToValidate="txtcaso" ErrorMessage="El caso debe ser numérico" 
                                                Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                            </td>
                            <td class="textotittabla">
                                            <asp:Button ID="Button1" runat="server" Text="Buscar" />
                                        </td>
                        </tr>
                        </table>
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
                                Identificación Caso Nivel 3&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnindentifn3" runat="server" Text="Guardar" 
                                    style="height: 26px" />
                                </td>
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
                            <td class="textotittabla">
                                Fecha Ingreso Caso</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtfcingn3" runat="server"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                                    ControlToValidate="txtfcingn3" ErrorMessage="La fecha de ingreso no es válida" 
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                            </td>
                            <td class="textotittabla">
                                PQR</td>
                            <td class="celdascons">
                                <asp:CheckBox ID="chkpqr" runat="server" />
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Ingeniero Claro Remite</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlingclaro" runat="server" Height="22px" 
                                    Width="322px">
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Nuevo Ing&nbsp; 
                                <asp:Button ID="btnguardar0" runat="server" Text="Guardar" 
                                    style="height: 26px" />
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtingclaro" runat="server"></asp:TextBox>
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
                    Registro de Seguimiento&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                <asp:Button ID="btnguardar" runat="server" Text="Guardar" 
                                    style="height: 26px" Enabled="False" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Tipificación Llamada N3</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drltipificacionll" runat="server" Height="22px" 
                                    Width="322px">
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                &nbsp;</td>
                            <td class="celdascons">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Tipo Grupo</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlgrupo" runat="server" Height="22px" Width="322px" 
                                    AutoPostBack="True">
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Tipo Soporte</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drltsoporte" runat="server" Height="22px" Width="322px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Numero Alterno</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtnumalt" runat="server" Width="136px"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Observación</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtobs" runat="server" Width="99%" Height="45px" 
                                    TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                    Estado Fallatec</td>
                            <td class="celdascons">
                                    <asp:DropDownList ID="drlfallatec" runat="server" Height="22px" 
                                    Width="129px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>CERRADO</asp:ListItem>
                                        <asp:ListItem>ILOCALIZABLE</asp:ListItem>
                                        <asp:ListItem>ESCALADO</asp:ListItem>
                                    </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                    Es Fallatec</td>
                            <td class="celdascons">
                                    <asp:Label ID="lblfallatec" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Se Instalo App Nx Monitor
                            </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlIntalaApp" runat="server">
                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                <asp:ListItem>SI</asp:ListItem>
                                <asp:ListItem>NO</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                            Motivo</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlMotivo" runat="server">
                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                <asp:ListItem>Informa  Instalar Nx Monitor en otro Momento</asp:ListItem>
                                <asp:ListItem>No le interesa instalar</asp:ListItem>
                                <asp:ListItem>Prefiere que lo llamen después para asesoría de instalación</asp:ListItem>
                                <asp:ListItem>Otras causas</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            </tr>
                            <tr>
                            <td class="textotittabla">
                                Client Id
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtClientId" runat="server" Width="104px" MaxLength="10"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                PQR</td>
                            <td class="celdascons">
                                <asp:Label ID="LblPQR" runat="server"></asp:Label><asp:TextBox ID="TxtPQR" runat="server" MaxLength="7" Width="55px"></asp:TextBox>
                                <asp:CompareValidator ID="CV_PQR" runat="server" ControlToValidate="TxtPQR" ErrorMessage="El valor del PQR debe ser numerico" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                            </td>
                        </tr>
                        </table>
                </td>
                <td class="celdasder">
                <asp:GridView ID="dtgprog" runat="server" AllowPaging="True"
                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                GridLines="None" PageSize="5" Width="62%" style="font-size: x-small">
                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                <Columns>
                <asp:BoundField DataField="Id_Caso" HeaderText="Caso" />
                <asp:BoundField DataField="min_ac" HeaderText="Min" />
                <asp:BoundField DataField="FC_REG_ASIGNA" HeaderText="Fecha Asignado" />
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
            <tr>
                <td class="celdasder">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" />
                </td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                MIN</td>
                            <td class="celdascons">
                                <asp:Label ID="lblmin" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Caso</td>
                            <td class="celdascons">
                                <asp:Label ID="lblcaso" runat="server"></asp:Label>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nombre</td>
                            <td class="celdascons">
                                <asp:Label ID="lblcliente" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Documento</td>
                            <td class="celdascons">
                                <asp:Label ID="lbldocumento" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Equipo</td>
                            <td class="celdascons">
                                <asp:Label ID="lblequipo" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Plan</td>
                            <td class="celdascons">
                                <asp:Label ID="lblplan" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Departamento Falla</td>
                            <td class="celdascons">
                                <asp:Label ID="lbllugar" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Correo Electrónico</td>
                            <td class="celdascons">
                                <asp:Label ID="lblemail" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Estado Bandeja</td>
                            <td class="celdascons">
                                <asp:Label ID="lblestado" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Observación *611</td>
                            <td class="celdascons">
                                <asp:Label ID="lblobs611" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Estado Nivel 3</td>
                            <td class="celdascons">
                                <asp:Label ID="lblestadon3" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Fecha Ingreso Nivel 3</td>
                            <td class="celdascons">
                                <asp:Label ID="lblfcingn3" runat="server"></asp:Label>
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
                    <asp:LinkButton ID="LinkButton3" runat="server">Reportar Inconsistencia</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton4" runat="server">Ocultar Inconsistencia</asp:LinkButton>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:Panel ID="Pninc" runat="server" Visible="False">
                        <table border="1" cellpadding="1" cellspacing="1" class="style1">
                            <tr>
                                <td class="textotittabla">
                                    <asp:Button ID="Button2" runat="server" Text="Guardar" Width="68px" />
                                </td>
                                <td class="celdascons">
                                    Registro de Inconsistencia</td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Tipificacion</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlinconsglobal" runat="server" AutoPostBack="True" 
                                        Height="22px" Width="322px">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Tipo Inconsistencia</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlincons" runat="server" Height="22px" Width="322px">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Nivel</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlnivel" runat="server" Height="22px" Width="322px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Call</asp:ListItem>
                                        <asp:ListItem>Operacion</asp:ListItem>
                                        <asp:ListItem>Call/Operac</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Observación Inconsistencia</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtobsinc" runat="server" Height="45px" TextMode="MultiLine" 
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
                    Consulta Seguimientos&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                </td>
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
                            <asp:BoundField DataField="idcrm" HeaderText="ID" />
                            <asp:BoundField DataField="cas_id" HeaderText="Caso" />
                            <asp:BoundField DataField="min_ac" HeaderText="Min" />
                            <asp:BoundField DataField="fcreg" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="idusuario" HeaderText="Agente" />
                            <asp:BoundField DataField="obs" HeaderText="Observación" />
                            <asp:BoundField DataField="tipo_soporte" HeaderText="Tipo Soporte" />
                            <asp:BoundField DataField="tipificacion" HeaderText="Tipificación" />
                            <asp:BoundField DataField="fallared" HeaderText="Falla de Red" />
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
    
    </div>
    </form>
</body>
</html>
