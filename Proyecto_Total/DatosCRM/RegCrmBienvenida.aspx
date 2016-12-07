<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RegCrmBienvenida.aspx.vb" Inherits="digitacion.RegCrmBienvenida" %>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
                    <asp:Label ID="lblmsg0" runat="server" 
                        style="font-size: medium; font-style: italic">Registro CRM Bienvenida</asp:Label>
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
                                <table class="style2" frame="border" 
                                    style="padding: inherit; visibility: visible">
                                    <tr>
                                        <td id="Caso" bgcolor="#CCCCFF">
                                            Min:</td>
                                        <td>
                                            <asp:TextBox ID="txtcaso" runat="server" Width="138px"></asp:TextBox>
                                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                ControlToValidate="txtcaso" ErrorMessage="El caso debe ser numérico" 
                                                Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                            <td style="width: 70%" rowspan="1">
                                            <asp:Button ID="Button1" runat="server" Text="Buscar" style="height: 26px" />
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
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                MIN</td>
                            <td class="celdascons">
                                <asp:Label ID="lblmin" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Nombre</td>
                            <td class="celdascons">
                                <asp:Label ID="lblcliente" runat="server"></asp:Label>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Documento</td>
                            <td class="celdascons">
                                <asp:Label ID="lbldocumento" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Departamento</td>
                            <td class="celdascons">
                                <asp:Label ID="lbllugar" runat="server"></asp:Label>
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
                            &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Fecha de compra</td>
                            <td class="celdascons">
                                <asp:Label ID="LblFcCompra" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Paquete de Datos</td>
                            <td class="celdascons">
                                <asp:Label ID="LblPaqDatos" runat="server"></asp:Label>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Caso</td>
                            <td class="celdascons">
                                <asp:Label ID="lblcaso" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Estado</td>
                            <td class="celdascons">
                                <asp:Label ID="lblestado" runat="server"></asp:Label>
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
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" />
                </td>
                <td class="celdascent">
                <asp:Panel ID="Pndiagnostico" runat="server">
                <asp:Button ID="btnguardar" runat="server" Text="Guardar" />
                        <table border="1" cellpadding="1" cellspacing="1" class="style1">
                            <tr>
                                <td class="textotittabla">
                                    Observación</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtobs" runat="server" Height="45px" TextMode="MultiLine" 
                                        Width="99%"></asp:TextBox>
                                </td>
                                <td class="textotittabla">
                                    Tipificación Llamada</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drltipificacionll" runat="server" AutoPostBack="True" 
                                        Height="22px" Width="322px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Llamada Satisfecha </asp:ListItem>
                                        <asp:ListItem>Llamada Programada</asp:ListItem>
                                        <asp:ListItem>Llamada Rechazada</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Causa Llamada Rechazada</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlTipificacionRechaza" runat="server" 
                                        Height="22px" Width="322px" Enabled="False">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Llamada Satisfecha </asp:ListItem>
                                        <asp:ListItem>Llamada Programada</asp:ListItem>
                                        <asp:ListItem>Llamada Rechazada</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Orientación, enfoque de la llamada</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drltipificacionllEnfoque" runat="server" 
                                        Height="22px" Width="322px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Llamada Satisfecha </asp:ListItem>
                                        <asp:ListItem>Llamada Programada</asp:ListItem>
                                        <asp:ListItem>Llamada Rechazada</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Fecha Programación</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtfcprog" runat="server" MaxLength="10" 
                                        placeholder="dd/mm/aaaa" Width="136px"></asp:TextBox>
                                    <asp:CompareValidator ID="CompareValidator6" runat="server" 
                                        ControlToValidate="txtfcprog" 
                                        ErrorMessage="La fecha de Programación no es válida" Operator="DataTypeCheck" 
                                        Type="Date">*</asp:CompareValidator>
                                </td>
                                <td class="textotittabla">
                                    Hora</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txthora" runat="server" MaxLength="2" placeholder="hh" 
                                        Width="31px"></asp:TextBox>
                                    &nbsp;<asp:TextBox ID="txtmin" runat="server" MaxLength="2" placeholder="mm" 
                                        Width="31px"></asp:TextBox>
                                    <asp:CompareValidator ID="CompareValidator5" runat="server" 
                                        ControlToValidate="txthora" ErrorMessage="El monto a ajustar debe ser numérico" 
                                        Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
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
                                        <asp:ListItem>Prefiere que lo llamen despues para asesoria de instalacion</asp:ListItem>
                                        <asp:ListItem>Otras causas</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Se brindo Soporte</td>
                                <td class="celdascons">
                                    <asp:RadioButtonList ID="RdbtnSoporte" runat="server">
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                                <td class="textotittabla">
                                    Numero alterno</td>
                                <td class="celdascons">

                                    <asp:TextBox ID="txtnumalt" runat="server" MaxLength="10" Width="136px"></asp:TextBox>

                                </td>
                            </tr>
                        </table>
                        <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" colspan="3">
                                <center>
                                    VARIABLES DE MEDICION</center>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 60%; font-family: Arial,Helvetica,sans-serif; font-size: small;
                                color: #000042; font-weight: bold; background: #E2E8FA;">
                                <center>
                                    Momentos de la Llamada</center>
                            </td>
                            <td style="width: 20%; font-family: Arial,Helvetica,sans-serif; font-size: small;
                                color: #000042; font-weight: bold; background: #E2E8FA;">
                                <center>
                                    ¿De los siguientes objetivos, cuales le informo al cliente?</center>
                            </td>
                            <td style="width: 20%; font-family: Arial,Helvetica,sans-serif; font-size: small;
                                color: #000042; font-weight: bold; background: #E2E8FA;">
                                <center>
                                    ¿El cliente requirio aclaracion sobre alguno de los siguientes objetivos?</center>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Descripción característica del plan
                            </td>
                            <td>
                                <center>
                                    <asp:CheckBox ID="CheckBox_Des_Caracteristica_Plan" runat="server" />
                                </center>
                            </td>
                            <td>
                                <center>
                                    <asp:DropDownList ID="Drl_Des_Caracteristica_Plan" runat="server" Width="120px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                    </asp:DropDownList>
                                </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Canales de consulta para el control de consumo
                            </td>
                            <td>
                                <center>
                                    <asp:CheckBox ID="CheckBox_Canal_Consulta_Control_Consumo" runat="server" />
                                </center>
                            </td>
                            <td>
                                <center>
                                    <asp:DropDownList ID="Drl_Canal_Consulta_Control_Consumo" runat="server" 
                                        Width="120px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                    </asp:DropDownList>
                                </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Asesoría registron en la tienda y descarga de aplicaciones
                            </td>
                            <td>
                                <center>
                                    <asp:CheckBox ID="CheckBox_Asesoria_Reg_Tienda_Des_App" runat="server" />
                                </center>
                            </td>
                            <td>
                                <center>
                                    <asp:DropDownList ID="Drl_Asesoria_Reg_Tienda_Des_App" runat="server" 
                                        Width="120px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                    </asp:DropDownList>
                                </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Configuración de cuenta de correo
                            </td>
                            <td>
                                <center>
                                    <asp:CheckBox ID="CheckBox_Config_Cuenta_Correo" runat="server" />
                                </center>
                            </td>
                            <td>
                                <center>
                                    <asp:DropDownList ID="Drl_Config_Cuenta_Correo" runat="server" Width="120px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                    </asp:DropDownList>
                                </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Características básicas del equipo
                            </td>
                            <td>
                                <center>
                                    <asp:CheckBox ID="CheckBox_Caracte_Basica_Equipo" runat="server" />
                                </center>
                            </td>
                            <td>
                                <center>
                                    <asp:DropDownList ID="Drl_Caracte_Basica_Equipo" runat="server" Width="120px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                    </asp:DropDownList>
                                </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Condiciones de la cobertura de red
                            </td>
                            <td>
                                <center>
                                    <asp:CheckBox ID="CheckBox_Condiciones_Cobertura_Red" runat="server" />
                                </center>
                            </td>
                            <td>
                                <center>
                                    <asp:DropDownList ID="Drl_Condiciones_Cobertura_Red" runat="server" 
                                        Width="120px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                    </asp:DropDownList>
                                </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Tips de auto atención
                            </td>
                            <td>
                                <center>
                                    <asp:CheckBox ID="CheckBox_Tips_Auto_Atencion" runat="server" />
                                </center>
                            </td>
                            <td>
                                <center>
                                    <asp:DropDownList ID="Drl_Tips_Auto_Atencion" runat="server" Width="120px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                    </asp:DropDownList>
                                </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Información Roaming Internacional
                            </td>
                            <td>
                                <center>
                                    <asp:CheckBox ID="CheckBox_Info_Roaming_Internacional" runat="server" />
                                </center>
                            </td>
                            <td>
                                <center>
                                    <asp:DropDownList ID="Drl_Info_Roaming_Internacional" runat="server" 
                                        Width="120px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                    </asp:DropDownList>
                                </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Remisión a los canales de atención
                            </td>
                            <td>
                                <center>
                                    <asp:CheckBox ID="CheckBox_Remision_Canal_Atencion" runat="server" />
                                </center>
                            </td>
                            <td>
                                <center>
                                    <asp:DropDownList ID="Drl_Remision_Canal_Atencion" runat="server" Width="120px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                    </asp:DropDownList>
                                </center>
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
                    <asp:LinkButton ID="LinkButton3" runat="server">Reportar Inconsistencia</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton4" runat="server">Ocultar Inconsistencia</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;                   
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:Panel ID="Pninc" runat="server" Visible="False">
                        <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                            <tr>
                                <td class="textotittabla">
                                    <asp:Button ID="btnguardar0" runat="server" Text="Guardar" Width="68px" />
                                </td>
                                <td class="celdascons">
                                    Registro de Inconsistencia</td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Tipificación</td>
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
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style1">
                     &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style1">
                     &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    Seguimientos: 
                    <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                    &nbsp; 
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
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idcrm" HeaderText="ID" />
                            <asp:BoundField DataField="cas_id" HeaderText="Caso" />
                            <asp:BoundField DataField="min_ac" HeaderText="Min" />
                            <asp:BoundField DataField="fcreg" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="idusuario" HeaderText="Agente" />
                            <asp:BoundField DataField="obs" HeaderText="Observación" />
                            <asp:BoundField DataField="tipificacion" HeaderText="Tipificación" />
                            <asp:BoundField DataField="tipo_soporte" HeaderText="Causa Rechazada" />
                            <asp:BoundField DataField="preg1" HeaderText="Orientacion Enfoque" />
                             <asp:BoundField DataField="fcprogram" HeaderText="Fecha Programación" />
                            <asp:BoundField DataField="preg2" HeaderText="Instala Nx" />
                            <asp:BoundField DataField="preg3" HeaderText="Motivo Nx" />
                            <asp:BoundField DataField="numalt" HeaderText="Num Alt" />
                            <asp:BoundField DataField="Preg4" HeaderText="Brindo Soporte" />
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
                <td class="celdascent">
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </table>
    
    </form>
</body>
</html>