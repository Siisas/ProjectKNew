<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="regrrhh.aspx.vb" Inherits="digitacion.regrrhh" %>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
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
     
        .style3
        {
            color: #000099;
        }
        .style4
        {
            width: 495px;
        }
        .style5
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 42px;
        }
        .style6
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 42px;
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
                                Kamilion Comunicaciones - ERP</td>
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
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <uc1:menu ID="menu1" runat="server" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:Label ID="lblmsg0" runat="server" 
                        style="font-size: medium; font-style: italic">Registro Recursos Humanos</asp:Label>
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
                            <td style="width: 30%">
                                <asp:Label ID="lblusuario" runat="server"></asp:Label>
                            </td>
                            <td style="width: 70%">
                                <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
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
                    Datos Personales</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                <asp:Button ID="btnguardar" runat="server" Text="Guardar" 
                                    style="height: 26px" />
                            &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnconsultar" runat="server" Text="Consultar" 
                                    style="height: 26px" />
                            &nbsp;&nbsp;
                                <asp:Button ID="btnactualiza" runat="server" Text="Actualizar" 
                                    style="height: 26px" />
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
                                Documento</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtdocumento" runat="server" Width="43%"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                    ControlToValidate="txtdocumento" ErrorMessage="Campo Númerico" 
                                    ValidationExpression="[0-9]*">*</asp:RegularExpressionValidator>
                            </td>
                            <td class="textotittabla">
                                Código</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtcodigo" runat="server" Width="43%" MaxLength="6"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nombres</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtnombres" runat="server" MaxLength="50" Width="95%"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Apellidos</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtapellidos" runat="server" Width="94%" MaxLength="50"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                EPS</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drleps" runat="server" Height="26px" Width="333px">
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                FPS</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlfps" runat="server" Height="26px" 
                                    style="margin-bottom: 0px" Width="333px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Dirección</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtdireccion" runat="server" Width="95%"></asp:TextBox>
                                </td>
                            <td class="textotittabla">
                                Teléfono</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txttelefono" runat="server" Width="43%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Fecha Nacimiento</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtfcnac" runat="server" Width="43%"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                    ControlToValidate="txtfcnac" ErrorMessage="Campo de Fecha" 
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                            </td>
                            <td class="textotittabla">
                                e-Mail</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtemail" runat="server" Width="94%"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                    ControlToValidate="txtemail" ErrorMessage="Campo de email" 
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Genero</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlgenero" runat="server">
                                    <asp:ListItem Value="0">- Elija una opción -</asp:ListItem>
                                    <asp:ListItem Value="F">Femenino</asp:ListItem>
                                    <asp:ListItem Value="M">Masculino</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Estado Civil</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlecivil" runat="server">
                                    <asp:ListItem Value="0">- Elija una opción -</asp:ListItem>
                                    <asp:ListItem>Soltero</asp:ListItem>
                                    <asp:ListItem>Unión Libre</asp:ListItem>
                                    <asp:ListItem>Casado</asp:ListItem>
                                    <asp:ListItem>Separado</asp:ListItem>
                                    <asp:ListItem>Viudo</asp:ListItem>
                                    <asp:ListItem>No Informa</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Número Hijos</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtnhijos" runat="server" Width="15%"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator6" runat="server" 
                                    ControlToValidate="txtnhijos" ErrorMessage="Campo numérico" 
                                    Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                            </td>
                            <td class="textotittabla">
                                Numero Cuenta</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtncuenta" runat="server" Width="94%"></asp:TextBox>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                RH</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtrh" runat="server" Width="15%"></asp:TextBox>
                                </td>
                            <td class="textotittabla">
                                Deporte</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtdeporte" runat="server" Width="94%"></asp:TextBox>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nivel de Escolaridad</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlescolaridad" runat="server" Height="26px" 
                                    Width="239px">
                                    <asp:ListItem Value="0">- Elija una opción -</asp:ListItem>
                                    <asp:ListItem>Ninguno</asp:ListItem>
                                    <asp:ListItem>Primaria</asp:ListItem>
                                    <asp:ListItem>Bachillerato</asp:ListItem>
                                    <asp:ListItem>Técnico/Tecnólogo</asp:ListItem>
                                    <asp:ListItem>Profesional</asp:ListItem>
                                    <asp:ListItem>Especialización</asp:ListItem>
                                    <asp:ListItem>Maestría</asp:ListItem>
                                    <asp:ListItem>Doctorado</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Profesión</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtprofesion" runat="server" Width="94%"></asp:TextBox>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Estudia Actualmente</td>
                            <td class="celdascons">
                                <asp:RadioButtonList ID="rbtestudia" runat="server" Height="16px" 
                                    style="font-size: small" Width="178px">
                                    <asp:ListItem>SI</asp:ListItem>
                                    <asp:ListItem>NO</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                            <td class="textotittabla">
                                Observaciones</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtobs" runat="server" Width="94%" Height="45px" 
                                    TextMode="MultiLine"></asp:TextBox>
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
                    Datos Laborales</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Cargo</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtcargo" runat="server" Width="94%"></asp:TextBox>
                                </td>
                            <td class="textotittabla">
                                Proyecto</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlproyecto" runat="server" Height="26px" 
                                    style="margin-bottom: 0px" Width="333px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Área</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlarea" runat="server" Height="26px" 
                                    style="margin-bottom: 0px" Width="333px">
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Tipo Contrato</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drltipocontrato" runat="server" Height="26px" 
                                    style="margin-bottom: 0px" Width="333px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Salario </td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtsalario" runat="server" Width="43%"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator4" runat="server" 
                                    ControlToValidate="txtsalario" ErrorMessage="Campo numérico" 
                                    Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                            </td>
                            <td class="textotittabla">
                                Bonificaciones</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtbonificacion" runat="server" Width="43%"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator5" runat="server" 
                                    ControlToValidate="txtbonificacion" ErrorMessage="Campo numérico" 
                                    Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Auxilio Transp.</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtauxtransp" runat="server" Width="43%"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator7" runat="server" 
                                    ControlToValidate="txtauxtransp" ErrorMessage="Campo numérico" 
                                    Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                            </td>
                            <td class="textotittabla">
                                Turno</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlturno" runat="server" Height="26px" 
                                    style="margin-bottom: 0px" Width="144px">
                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                    <asp:ListItem>Mañana</asp:ListItem>
                                    <asp:ListItem>Tarde</asp:ListItem>
                                    <asp:ListItem>Noche</asp:ListItem>
                                    <asp:ListItem>Oficina</asp:ListItem>
                                    <asp:ListItem>Rota</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Fecha de Ingreso</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtfcing" runat="server" Width="43%"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                                    ControlToValidate="txtfcing" ErrorMessage="Campo de Fecha" 
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                            </td>
                            <td class="textotittabla">
                                Estado</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlestado" runat="server" Height="26px" Width="144px">
                                    <asp:ListItem Value="0">- Elija una opción -</asp:ListItem>
                                    <asp:ListItem Value="A">Activo</asp:ListItem>
                                    <asp:ListItem Value="I">Inactivo</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Fecha de Retiro</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtfcretiro" runat="server" Width="43%"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator3" runat="server" 
                                    ControlToValidate="txtfcretiro" ErrorMessage="Campo de Fecha" 
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                    <input id="File1" runat="server" name="File1" size="78" 
                        style="Z-INDEX: 114; POSITION: absolute; WIDTH: 604px; HEIGHT: 22px; TOP: 814px; LEFT: 203px" 
                        type="file" /></td>
                            <td class="textotittabla">
                                Empresa</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlempresa" runat="server" Height="25px" 
                                    style="margin-bottom: 0px" Width="144px">
                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                    <asp:ListItem>Kamilion</asp:ListItem>
                                    <asp:ListItem>TMC</asp:ListItem>
                                </asp:DropDownList>
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
                    Registro
                    <br />
                    Fotográfico<br />
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    </td>
                <td class="style6">
                    Hoja de
                    <br />
                    Vida<input id="File2" 
                        runat="server" name="File2" size="78" 
                        style="Z-INDEX: 114; POSITION: absolute; WIDTH: 596px; HEIGHT: 22px; TOP: 857px; LEFT: 205px; right: 219px;" 
                        type="file" /></td>
                <td class="style5">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    Historial de Modificaciones</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                                <asp:Button ID="btnactualiza0" runat="server" Text="Registrar Histórico" 
                                    style="height: 26px" Width="128px" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Tipo Actualización</td>
                            <td class="style4">
                                <asp:DropDownList ID="drlactualizacion" runat="server" Height="26px" 
                                    style="margin-bottom: 0px" Width="333px">
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                Descripción Actualización</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtdescripcion" runat="server" Width="98%" Height="52px" 
                                    TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        </table>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
        </table>
    
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" />
    </form>
</body>
</html>
