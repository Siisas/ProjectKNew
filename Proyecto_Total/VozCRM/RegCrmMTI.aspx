<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RegCrmMTI.aspx.vb" Inherits="digitacion.RegCrmMTI" %>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Registro MTI Chile</title>
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
     
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 29px;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 29px;
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
                        style="font-size: medium; font-style: italic">Registro MTI Chile</asp:Label>
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
                                            <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" />
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
                    <asp:Panel ID="Panel1" runat="server" Visible="False">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" colspan="4">
                            <center>Consulta</center>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Empresa<td class="celdascons">
                                <asp:Label ID="LblEmpresa" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                &nbsp;</td>
                            <td class="celdascons">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="textotittabla" colspan="4">
                                <center>Contacto Principal</center> </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nombre</td>
                            <td class="celdascons">
                                <asp:Label ID="LblNombre" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Cargo</td>
                            <td class="celdascons">
                                <asp:Label ID="LblCargo" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Correo</td>
                            <td class="celdascons">
                                <asp:Label ID="LblCorreo" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Telefono</td>
                            <td class="celdascons">
                                <asp:Label ID="LblTelefono" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" colspan="4">
                                <center>Contacto 2</center> </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nombre</td>
                            <td class="celdascons">
                                <asp:Label ID="LblNombre1" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Cargo</td>
                            <td class="celdascons">
                                <asp:Label ID="LblCargo1" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Correo</td>
                            <td class="celdascons">
                                <asp:Label ID="LblCorreo1" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Telefono</td>
                            <td class="celdascons">
                                <asp:Label ID="LblTelefono1" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" colspan="4">
                                <center>Contacto 3</center> </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nombre</td>
                            <td class="celdascons">
                                <asp:Label ID="LblNombre2" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Cargo</td>
                            <td class="celdascons">
                                <asp:Label ID="LblCargo2" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Correo</td>
                            <td class="celdascons">
                                <asp:Label ID="LblCorreo2" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Telefono</td>
                            <td class="celdascons">
                                <asp:Label ID="LblTelefono2" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla" colspan="4">
                                <center>Contacto 4</center> </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nombre</td>
                            <td class="celdascons">
                                <asp:Label ID="LblNombre3" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Cargo</td>
                            <td class="celdascons">
                                <asp:Label ID="LblCargo3" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Correo</td>
                            <td class="celdascons">
                                <asp:Label ID="LblCorreo3" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Telefono</td>
                            <td class="celdascons">
                                <asp:Label ID="LblTelefono3" runat="server"></asp:Label>
                            </td>
                        </tr>
                      
                        <tr>
                            <td class="textotittabla" colspan="4">
                                <center>Información</center> </td>
                        </tr>
                      
                        <tr>
                            <td class="textotittabla">
                                Asiste al evento</td>
                            <td class="celdascons">
                                <asp:Label ID="LblAsiste" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Contacto CLO</td>
                            <td class="celdascons">
                                <asp:Label ID="LblContacto_CLO" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                                Se envío invitación</td>
                            <td class="celdascons">
                                                <asp:Label ID="LblEnvio_Invitacion" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Se realizo llamada</td>
                            <td class="celdascons">
                                <asp:Label ID="LblRealizo_Llamada" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                                Contacto adicional (Secretaria)</td>
                            <td class="celdascons">
                                <asp:Label ID="LblContacto_Adicional" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Comentario</td>
                            <td class="celdascons">
                                <asp:Label ID="LblComentario" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                                &nbsp;</td>
                            <td class="celdascons">
                                &nbsp;</td>
                            <td class="textotittabla">
                                &nbsp;</td>
                            <td class="celdascons">
                                <asp:Label ID="LblCaso" runat="server" Visible="False"></asp:Label>
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
                    Cantidad de caso programados para la fecha actual:&nbsp;<asp:Label ID="LblCantidad_Casos" runat="server"></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    Cantidad de caso programados 
                    para proximos dias:&nbsp;<asp:Label ID="LblCantidad_Casos_ProximosD" runat="server"></asp:Label>
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
                                    <table border="1" cellpadding="1" cellspacing="1"  class="style1">
                            <tr>
                            <td class="textotittabla" colspan="4">
                            <center>Actualizacion de Datoss</center>
                            </td>
                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Empresa</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlEmpresa" runat="server" Height="22px" Width="322px" 
                                                    AutoPostBack="True">
                                                </asp:DropDownList>
                                            </td>
                                            <td class="textotittabla">
                                                &nbsp;</td>
                                            <td class="celdascons">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla" colspan="4">
                                                <center>Contacto Principal</center></td>
                                            
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Nombre</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
                                            </td>
                                            <td class="textotittabla">
                                                Cargo</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtCargo" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Correo</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtCorreo" runat="server"></asp:TextBox>
                                            </td>
                                            <td class="textotittabla">
                                                Telefono</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtTelefono" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla" colspan="4">
                                                <center>Contacto 2</center> </td>
                                            
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Nombre</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtNombre1" runat="server"></asp:TextBox>
                                            </td>
                                            <td class="textotittabla">
                                                Cargo</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtCargo1" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Correo</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtCorreo1" runat="server"></asp:TextBox>
                                            </td>
                                            <td class="textotittabla">
                                                Telefono</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtTelefono1" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla" colspan="4">
                                                <center>Contacto 3</center></td>
                                            
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Nombre</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtNombre2" runat="server"></asp:TextBox>
                                            </td>
                                            <td class="textotittabla">
                                                Cargo</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtCargo2" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Correo</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtCorreo2" runat="server"></asp:TextBox>
                                            </td>
                                            <td class="textotittabla">
                                                Telefono</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtTelefono2" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla" colspan="4">
                                                <center>Contacto 4</center> </td>
                                         
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Nombre</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtNombre3" runat="server"></asp:TextBox>
                                            </td>
                                            <td class="textotittabla">
                                                Cargo</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtCargo3" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Correo</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtCorreo3" runat="server"></asp:TextBox>
                                            </td>
                                            <td class="textotittabla">
                                                Telefono</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtTelefono3" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla" colspan="4">
                                                <center>Información</center>
                                                </td>
                                            
                                        </tr>
                            <%--<tr>
                                <td class="textotittabla">
                                                Se envío invitación</td>
                                <td class="celdascons">
                                                <asp:TextBox ID="TxtEnvio_Invitacion" runat="server"></asp:TextBox>
                                </td>
                                <td class="textotittabla">
                                                Contacto CLO</td>
                                <td class="celdascons">
                                                <asp:TextBox ID="TxtContacto_CLO" runat="server"></asp:TextBox>
                                </td>
                            </tr>--%>
                                        <tr>
                                            <td class="textotittabla">
                                                Contacto adicional (Secretaria)</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtContacto_Adicional" runat="server"></asp:TextBox>
                                            </td>
                                            <td class="textotittabla">
                                                Se realizo llamada</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtRealizoLlamada" runat="server"></asp:TextBox>
                                                <br />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Comentario</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtComentario" runat="server" Height="45px" 
                                                    TextMode="MultiLine" Width="99%"></asp:TextBox>
                                            </td>
                                            <td class="textotittabla">
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
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                                <asp:Button ID="BtnActualizar" runat="server" style="height: 26px" 
                                                    Text="Actualizar" />
                &nbsp;
                                                <asp:Button ID="BtnRegNuevo" runat="server" 
                                                    Text="Registro Nuevo" />
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
                    <table border="1" cellpadding="1" cellspacing="1"  class="style1">
                            <tr>
                            <td class="textotittabla" colspan="4">
                            <center>Estado de Llamada</center>
                            </td>
                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Estado</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlEstado_llamada" runat="server" Height="22px" 
                                                    Width="226px">
                                                </asp:DropDownList>
                                            </td>
                                            <td class="style8">
                                                Fecha Reprogramacion</td>
                                            <td class="celdascons">
                                <asp:TextBox ID="TxtFecha_Programada" runat="server" Width="24%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="TxtFecha_Programada" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                <asp:TextBox ID="TxtHora_Programada" runat="server" Width="5%" MaxLength="2" 
                                    placeholder="HH"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator6" runat="server" 
                                    ControlToValidate="TxtHora_Programada" ErrorMessage="Revise hora" 
                                    Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                                <asp:TextBox ID="TxtMinuto_Programado" runat="server" Width="5%" MaxLength="2" 
                                    placeholder="MM"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator7" runat="server" 
                                    ControlToValidate="TxtMinuto_Programado" ErrorMessage="Revise hora" 
                                    Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
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
                                                <asp:Button ID="BtnActualizar_Estado_Llamada" 
                        runat="server" 
                                                    Text="Actualizar" />
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
           <%-- <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1"  class="style1">
                            <tr>
                            <td class="textotittabla" colspan="4">
                            <center>Gestion de Invitacion</center>
                            </td>
                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Hubo recepcion de invitacion</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlRecepcion_Invitacion" runat="server" Height="22px" 
                                                    Width="322px">
                                                </asp:DropDownList>
                                            </td>
                                            <td class="textotittabla">
                                                Persona Interesada</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlPersonaInteresada" runat="server" Height="22px" 
                                                    Width="322px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                    Asiste al evento</td>
                                            <td class="celdascons">
                                    <asp:DropDownList ID="drlAsiste_Evento" runat="server">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                    </asp:DropDownList>
                                            </td>
                                            <td class="textotittabla">
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
                                                <asp:Button ID="BtnActualizar_Invitacion" 
                        runat="server" style="height: 26px" 
                                                    Text="Actualizar" />
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
            </tr>--%>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                <table border="1" cellpadding="1" cellspacing="1"  class="style1">
                            <tr>
                            <td class="textotittabla" colspan="4">
                            <center>Consultas</center>
                            </td>
                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Estado de la llamada</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlEstado_Llamada_Consulta" runat="server" Height="22px" 
                                                    Width="322px">
                                                </asp:DropDownList>
                                            </td>
                                            <td class="textotittabla">
                                                Empresa</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlEmpresa_Consulta" runat="server" Height="22px" Width="322px" 
                                                    AutoPostBack="True">
                                                </asp:DropDownList>
                                                <%--<asp:DropDownList ID="drlPersonaInteresada_Consulta" runat="server" Height="22px" 
                                                    Width="322px">
                                                </asp:DropDownList>--%>
                                            </td>

                                            <%--<td class="textotittabla">
                                                Persona Interesada</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlPersonaInteresada_Consulta" runat="server" Height="22px" 
                                                    Width="322px">
                                                </asp:DropDownList>
                                            </td>--%>
                                        </tr>
                                        <tr>
                                            <%--<td class="textotittabla">
                                    Asiste al evento</td>
                                            <td class="celdascons">
                                    <asp:DropDownList ID="drlAsiste_Evento_Consulta" runat="server">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                    </asp:DropDownList>
                                            </td>--%>
                                            <td class="textotittabla">
                                                Fecha Reprogramacion</td>
                                            <td class="celdascons">
                                <asp:TextBox ID="TxtFecha_Programada_Consulta" runat="server" Width="24%" MaxLength="10" 
                                                    placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator8" runat="server" 
                                                    ControlToValidate="TxtFecha_Programada_Consulta" ErrorMessage="Revise hora" 
                                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                            </td>
                                        </tr>
                        </table>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    </td>
                <td class="auto-style2">
                    <asp:Button ID="BtnConsulta" runat="server" Text="Consuta" />
                </td>
                <td class="auto-style1">
                    </td>
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
&nbsp;Numero de registros: 
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
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Cod_Bandeja_MTI" HeaderText="Id Caso" />
                            <asp:BoundField DataField="Empresa" HeaderText="Empresa" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="Cargo" HeaderText="Cargo" />
                            <asp:BoundField DataField="Correo" HeaderText="Correo" />
                            <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                           <%-- <asp:BoundField DataField="Envio_Invitacion" HeaderText="Se Envio Invitacion" />--%>
                            <%--<asp:BoundField DataField="Contacto_CLO" HeaderText="Contacto CLO" />--%>
                            <asp:BoundField DataField="Realizo_llamada" HeaderText="Se Realizo llamada" />
                            <asp:BoundField DataField="Contacto_Adicional" HeaderText="Contacto Adicional" />
                            <%--<asp:BoundField DataField="Recepcion_Invitacion" HeaderText="Recepcion Invitacion" />--%>
                            <asp:BoundField DataField="Comentario" HeaderText="Comentario" />
                            <%--<asp:BoundField DataField="Persona_Interesada" HeaderText="Persona Interesada" />--%>
                           <%-- <asp:BoundField DataField="Asiste" HeaderText="Asite al Evento" />--%>
                            <asp:BoundField DataField="Fc_Programado" HeaderText="Fecha Programada"></asp:BoundField>
                            <asp:BoundField DataField="Estado_Llamada" HeaderText="Estado Llamada"></asp:BoundField>
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
           <%-- <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                    <asp:GridView ID="dtggeneralExport" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        Visible="False">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Cod_Bandeja_MTI" HeaderText="Id Caso" />
                            <asp:BoundField DataField="Empresa" HeaderText="Empresa" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                            <asp:BoundField DataField="Cargo" HeaderText="Cargo" />
                            <asp:BoundField DataField="Correo" HeaderText="Correo" />
                            <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                            <asp:BoundField DataField="Celular" HeaderText="Celular" />
                            <asp:BoundField DataField="Envio_Invitacion" HeaderText="Se Envio Invitacion" />
                            <asp:BoundField DataField="Contacto_CLO" HeaderText="Contacto CLO" />
                            <asp:BoundField DataField="Realizo_llamada" HeaderText="Se Realizo llamada" />
                            <asp:BoundField DataField="Contacto_Adicional" HeaderText="Contacto Adicional" />
                            <asp:BoundField DataField="Recepcion_Invitacion" HeaderText="Recepcion Invitacion" />
                            <asp:BoundField DataField="Comentario" HeaderText="Comentario" />
                            <asp:BoundField DataField="Persona_Interesada" HeaderText="Persona Interesada" />
                            <asp:BoundField DataField="Asiste" HeaderText="Asite al Evento" />
                            <asp:BoundField DataField="Fc_Programado" HeaderText="Fecha Programada"></asp:BoundField>
                            <asp:BoundField DataField="Estado_Llamada" HeaderText="Estado Llamada"></asp:BoundField>
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
            </tr>--%>
            </table>
    
    </form>
</body>
</html>
