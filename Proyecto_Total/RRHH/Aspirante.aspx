<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Aspirante.aspx.vb" Inherits="digitacion.Aspirante" %>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <script type="text/jscript">
      $(function () {
          $("#TxtFecha_Filtro").datepicker();
          $('#TxtFecha_Filtro').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
      $(function () {
          $("#TxtFecha_Entrevista").datepicker();
          $('#TxtFecha_Entrevista').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
      $(function () {
          $("#TxtFecha_Filtro_Consulta").datepicker();
          $('#TxtFecha_Filtro_Consulta').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
      $(function () {
          $("#TxtFecha_Entrevista_Consulta").datepicker();
          $('#TxtFecha_Entrevista_Consulta').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
  </script>
  <!-- Fin Script jQuery Datepicker --->
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
            width: 80%;
        }
        .style4
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
        }
        .style5
        {
            width: 80%;
        }
        .style9
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
            color: navy;
            width: 597px;
        }
        .style12
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 23px;
        }
        .style13
        {
            color: #000099;
            width: 80%;
            height: 23px;
        }
        .style14
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 15%;
            height: 24px;
            background: #E2E8FA;
        }
        .style15
        {
            width: 35%;
            height: 24px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <table style="width:100%; height: 100%">
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                    <table style="border-style: outset; border-width: 1px; width:100%">
                        <tr>
                            <td style="width:20%">
                                &nbsp;</td>
                            <td align="left" class="style9">
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
                <td class="style4">
                    <asp:Label ID="lblmsg" runat="server" style="color: #FF3300"></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="style4">
                    <uc1:menu ID="menu1" runat="server" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="lblmsg0" runat="server" 
                        style="font-size: medium; font-style: italic">Registro Recursos Humanos</asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td valign="top" class="style5">
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
                <td class="style12">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style13">
                    Datos de Aspirantes</td>
                <td class="style12">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: small;" 
                    valign="top" class="style3">
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                    <tr>
                            <td class="textotittabla" colspan="4">
                                <center>Registro</center>
                                </td>                            
                        <tr>
                            <td class="textotittabla">
                                Fecha_Filtro</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtFecha_Filtro" runat="server" Width="24%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidatorTxtFecha_Filtro" runat="server" ControlToValidate="TxtFecha_Filtro" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                </td>
                            <td class="textotittabla">
                                Fecha_Entrevista</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtFecha_Entrevista" runat="server" Width="24%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidatorTxtFecha_Entrevista" runat="server" ControlToValidate="TxtFecha_Entrevista" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                AM_PM</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlAM_PM" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>TARDE</asp:ListItem>
                                    <asp:ListItem>MAÑANA</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                &nbsp;</td>
                            <td class="celdascons">                                
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Empresa</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlEmpresa" runat="server">
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Nueva Empresa
                                </td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtNuevaEmpresa" runat="server"></asp:TextBox>
                                <asp:Button ID="BtnNuevaEmpresa" runat="server" Text="Guardar" />
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Identificacion
                                </td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtId_Aspirante" runat="server" Width="90%" MaxLength="11"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TxtId_Aspirante" ErrorMessage="Revise ahora" Operator="DataTypeCheck" type="Integer">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nombres
                                </td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtNombre" runat="server" Width="90%" MaxLength="50"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Apellidos</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtApellido" runat="server" Width="90%" MaxLength="60"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Telefono 1</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtTelefono1" runat="server" Width="90%" MaxLength="15"></asp:TextBox>
                            <asp:CompareValidator ID="CVTxtTelefono1" runat="server" 
                                    ControlToValidate="TxtTelefono1" ErrorMessage="Revise ahora" 
                                    Operator="DataTypeCheck" type="Integer">*</asp:CompareValidator>
                            </td>
                            <td class="textotittabla">
                                Telefono 2</td>
                            <td class="celdascons">                               
                                <asp:TextBox ID="TxtTelefono2" runat="server" Width="90%" MaxLength="15"></asp:TextBox>
                            <asp:CompareValidator ID="CVTxtTelefono2" runat="server" 
                                    ControlToValidate="TxtTelefono2" ErrorMessage="Revise ahora" 
                                    Operator="DataTypeCheck" type="Integer">*</asp:CompareValidator>
                                    </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Celular 1</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtCelular1" runat="server" Width="90%" MaxLength="10"></asp:TextBox>
                                <asp:CompareValidator ID="CVTxtCelular1" runat="server" ControlToValidate="TxtCelular1" ErrorMessage="Revise ahora" Operator="DataTypeCheck" type="Integer">*</asp:CompareValidator>
                            </td>
                            <td class="textotittabla">
                                Celular 2</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtCelular2" runat="server" Width="90%" MaxLength="10"></asp:TextBox>
                                <asp:CompareValidator ID="CVTxtCelular2" runat="server" ControlToValidate="TxtCelular2" ErrorMessage="Revise ahora" Operator="DataTypeCheck" type="Integer">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style14">
                                Perfil</td>
                            <td class="style15">                                
                                <asp:DropDownList ID="drlPerfil" runat="server">
                                </asp:DropDownList>
                            </td>
                            <td class="style14">
                                Nuevo Perfil</td>
                            <td class="style15">
                                <asp:TextBox ID="TxtNuevoPerfil" runat="server"></asp:TextBox>
                                <asp:Button ID="BtnNuevoPerfil" runat="server" Text="Guardar" />
                            </td>
                        </tr>                        
                        <tr>
                            <td class="textotittabla">
                                Cargo</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlCargoAspira" runat="server">
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                Nuevo Cargo</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtNuevoCargo" runat="server"></asp:TextBox>
                                <asp:Button ID="BtnNuevoCargo" runat="server" Text="Guardar" />
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Estado</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlEstado" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>Citado</asp:ListItem>
                                    <asp:ListItem>Errado</asp:ListItem>
                                    <asp:ListItem>No Contesta</asp:ListItem>
                                    <asp:ListItem>No le Interesa</asp:ListItem>
                                    <asp:ListItem>Pendiente</asp:ListItem>
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                Estudiando</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlEstudiando" runat="server">
                                    <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                    <asp:ListItem>SI</asp:ListItem>
                                    <asp:ListItem>NO</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>                                 
                        <tr>
                            <td class="textotittabla">
                                Experiencia</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlExperiencia" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>SI</asp:ListItem>
                                    <asp:ListItem>NO</asp:ListItem>
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                Carrera</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtCarrera" runat="server" Width="90%"></asp:TextBox>
                                </td>
                        </tr>                        
                        <tr>
                            <td class="textotittabla">
                                Medio de Difucion                                
                                </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlMedioDifucion" runat="server">
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Nuevo Medio de Difucion
                                </td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtNuevoMD" runat="server"></asp:TextBox>
                                <asp:Button ID="BtnNuevoMD" runat="server" Text="Guardar" />
                                </td>
                        </tr>                                 
                        <tr>
                            <td class="textotittabla">
                                Convocado</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlConvocado" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>SI</asp:ListItem>
                                    <asp:ListItem>NO</asp:ListItem>
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                Asiste Entrevista</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlAsiste_Entrevista" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>SI</asp:ListItem>
                                    <asp:ListItem>NO</asp:ListItem>
                                </asp:DropDownList>
                                </td>
                        </tr>
                        </tr>                                 
                        <tr>
                            <td class="textotittabla">
                                Promedio Entrevista</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtPromedio_Entrevista" runat="server" Width="90%"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Promedio Optimo</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtPromedio_Optimo" runat="server" Width="90%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Promedio Digitacion</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtPromedio_Digitacion" runat="server" Width="90%"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Promedio C Lectura</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtPromedio_C_Lectura" runat="server" Width="90%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Promedio Ortografía</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtPromedio_Ortografia" runat="server" Width="90%"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Test Wartegg</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtTest_Wartegg" runat="server" Width="90%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                16 PF</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="Txt16_PF" runat="server" Width="90%"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Assessment Center</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtAssessment_Center" runat="server" Width="90%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Diligencias</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtDiligencias" runat="server" Width="90%"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Resultado General</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtResultado_General" runat="server" Width="90%"></asp:TextBox>
                            </td>
                        </tr>                        
                        <tr>
                            <td class="textotittabla">
                                Preseleccionado</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlPreseleccionado" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>VERDADERO</asp:ListItem>
                                    <asp:ListItem>FALSO</asp:ListItem>
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
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>                    
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: small;" 
                    valign="top" class="style3">
                    
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
            <tr>
                <td class="celdasder">
                    &nbsp;</td>                    
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: small;" 
                    valign="top" class="style3">
                    
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                    <tr>
                            <td class="textotittabla" colspan="3">
                                <center>Actualizacion</center>
                                </td>                            
                        <tr>
                            <td class="celdascons" colspan="3">
                                Para realizan algun cambio u actualizacion, consulte la identificacion y los datos seran cargados, para sus respectivos cambios</td>                            
                        <tr>
                            <td class="textotittabla">
                                Identificacion</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtId_Aspirante_Actualiza" runat="server" Width="90%" 
                                    MaxLength="11"></asp:TextBox>
                                <asp:CompareValidator ID="CVID_Aspirante_Actualiza" runat="server" 
                                    ControlToValidate="TxtId_Aspirante_Actualiza" ErrorMessage="Revise ahora" 
                                    Operator="DataTypeCheck" type="Integer">*</asp:CompareValidator>
                                </td>
                            <td class="celdascons" colspan="2">                                
                                
                    <asp:Button ID="BtnConsultaActualiza" runat="server" Text="Consulta" />
                                <asp:Button ID="BtnValidar" runat="server" BorderStyle="None" 
                                    Text="Consultar Otro Aspirante" Visible="False" />
                    &nbsp;
                    <asp:Button ID="BtnActualizacion" runat="server" Text="Actualizar" Visible="False" />
                    
                                </td>
                        </tr>
                    </tr>
                    </table>

                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
            <tr>
                <td class="celdasder">
                    &nbsp;</td>                    
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: small;" 
                    valign="top" class="style3">
                    
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
            <tr>
                <td class="celdasder">
                    &nbsp;</td>                    
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: small;" 
                    valign="top" class="style3">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                    <tr>
                            <td class="textotittabla" colspan="4">
                                <center>Consultas</center>
                                </td>                            
                        <tr>
                            <td class="textotittabla">
                                Identificacion</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtId_Aspirante_Consulta" runat="server" Width="90%" 
                                    MaxLength="11"></asp:TextBox>
                                <asp:CompareValidator ID="CVID_Aspirante_Consulta" runat="server" 
                                    ControlToValidate="TxtId_Aspirante_Consulta" ErrorMessage="Revise ahora" 
                                    Operator="DataTypeCheck" type="Integer">*</asp:CompareValidator>
                                </td>
                            <td class="textotittabla">
                                Nombre</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtNombre_Consulta" runat="server" Width="90%" MaxLength="11"></asp:TextBox>
                                </td>
                        </tr>
                    </tr>
                        <tr>
                            <td class="textotittabla">
                                Apellido</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtApellido_Consulta" runat="server" Width="90%" 
                                    MaxLength="11"></asp:TextBox>
                                </td>
                            <td class="textotittabla">
                                Fecha Filtro</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtFecha_Filtro_Consulta" runat="server" Width="24%" 
                                    MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidatorTxtFecha_Filtro_Consulta" runat="server" 
                                    ControlToValidate="TxtFecha_Filtro_Consulta" ErrorMessage="Revise hora" 
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Fecha Entrevista</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtFecha_Entrevista_Consulta" runat="server" Width="24%" 
                                    MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidatorTxtFecha_Entrevista_Consulta" 
                                    runat="server" ControlToValidate="TxtFecha_Entrevista_Consulta" 
                                    ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                </td>
                            <td class="textotittabla">
                                Empresa</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlEmpresa_Consulta" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Perfil</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlPerfil_Consulta" runat="server">
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Cargo</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlCargoAspira_Consulta" runat="server">
                                </asp:DropDownList>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Convocado</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlConvocado_Consulta" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>SI</asp:ListItem>
                                    <asp:ListItem>NO</asp:ListItem>
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                Asiste Entrevista</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlAsiste_Entrevista_Consulta" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>SI</asp:ListItem>
                                    <asp:ListItem>NO</asp:ListItem>
                                </asp:DropDownList>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Preseleccionado</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlPreseleccionado_Consulta" runat="server">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                    <asp:ListItem>VERDADERO</asp:ListItem>
                                    <asp:ListItem>FALSO</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" colspan="4">                                
                                
                                <asp:Button ID="BtnConsulta" runat="server" Text="Consultar" />
                                
                                &nbsp;
                                <asp:Button ID="Btnxls" runat="server" Text="Exportar Excel" />
                                
                                &nbsp;
                                <asp:Button ID="BtnVerTodos" runat="server" Text="Ver Todos" />
&nbsp;
                                <asp:Button ID="Btnxls_Todos" runat="server" Text="Exportar Excel Todos" />
                                
                                <asp:Label ID="LblCantidad_Total" runat="server" Visible="False"></asp:Label>
                                
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: small;" 
                    valign="top" class="style3">
                    Cantidad de Aspirantes:
                    <asp:Label ID="LblCuenta_Aspirantes" runat="server"></asp:Label>
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
            <tr>
                <td class="celdasder">
                    &nbsp;</td>                    
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: small;" 
                    valign="top" class="style3">
                                <asp:GridView ID="dtgGeneral" runat="server" AllowPaging="True"
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" Width="100%" style="font-size: x-small" 
                                    EnableModelValidation="True" PageSize="1000">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Fecha_Registro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario Registra" />
                            <asp:BoundField DataField="Fecha_Filtro" HeaderText="Fecha Filtro" />
                            <asp:BoundField DataField="Fecha_Entrevista" HeaderText="Fecha Entrevista" />
                            <asp:BoundField DataField="AM_PM" HeaderText="AM PM" />
                            <asp:BoundField DataField="Nombre_Empresa" HeaderText="Empresa" />
                            <asp:BoundField DataField="Id_Aspirante" HeaderText="Id Aspirante" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                            <asp:BoundField DataField="Telefono1" HeaderText="Telefono1" />
                            <asp:BoundField DataField="Telefono2" HeaderText="Telefono2" />
                            <asp:BoundField DataField="Celular1" HeaderText="Celular1" />
                            <asp:BoundField DataField="Celular2" HeaderText="Celular2" />
                            <asp:BoundField DataField="Nombre_Perfil" HeaderText="Perfil" />
                            <asp:BoundField DataField="Nombre_Cargo" HeaderText="Cargo" />
                            <asp:BoundField DataField="Estado" HeaderText="Estado" />
                            <asp:BoundField DataField="Convocado" HeaderText="Convocado" />
                            <asp:BoundField DataField="Asiste_Entrevista" HeaderText="Asiste Entrevista" />
                            <asp:BoundField DataField="Preseleccionado" HeaderText="Preseleccionado" />
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: small;" 
                    valign="top" class="style3">
                                <asp:GridView ID="dtgGeneral_Ver_Todos" runat="server" 
                        AutoGenerateColumns="False" CellPadding="2" ForeColor="#333333" 
                        GridLines="None" Width="100%" style="font-size: x-small" 
                                    EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Fecha_Registro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario Registra" />
                            <asp:BoundField DataField="Fecha_Registro_Update" 
                                HeaderText="Fecha Registro Update" />
                            <asp:BoundField DataField="Id_Usuario_Update" HeaderText="Id Usuario Update" />
                            <asp:BoundField DataField="Fecha_Filtro" HeaderText="Fecha Filtro" />
                            <asp:BoundField DataField="Fecha_Entrevista" HeaderText="Fecha Entrevista" />
                            <asp:BoundField DataField="AM_PM" HeaderText="AM PM" />
                            <asp:BoundField DataField="Nombre_Empresa" HeaderText="Empresa" />
                            <asp:BoundField DataField="Id_Aspirante" HeaderText="Id Aspirante" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                            <asp:BoundField DataField="Telefono1" HeaderText="Telefono1" />
                            <asp:BoundField DataField="Telefono2" HeaderText="Telefono2" />
                            <asp:BoundField DataField="Celular1" HeaderText="Celular1" />
                            <asp:BoundField DataField="Celular2" HeaderText="Celular2" />
                            <asp:BoundField DataField="Nombre_Perfil" HeaderText="Perfil" />
                            <asp:BoundField DataField="Nombre_Cargo" HeaderText="Cargo" />
                            <asp:BoundField DataField="Estado" HeaderText="Estado" />
                            <asp:BoundField DataField="Estudia" HeaderText="Estudia" />
                            <asp:BoundField DataField="Experiencia" HeaderText="Experiencia" />
                            <asp:BoundField DataField="Carrera" HeaderText="Carrera" />
                            <asp:BoundField DataField="Nombre_MD" HeaderText="Medio de Difucion" />
                            <asp:BoundField DataField="Convocado" HeaderText="Convocado" />
                            <asp:BoundField DataField="Asiste_Entrevista" HeaderText="Asiste Entrevista" />
                            <asp:BoundField DataField="Promedio_Entrevista" 
                                HeaderText="Promedio Entrevista" />
                            <asp:BoundField DataField="Promedio_Optimo" HeaderText="Promedio Optimo" />
                            <asp:BoundField DataField="Promedio_Digitacion" 
                                HeaderText="Promedio Digitacion" />
                            <asp:BoundField DataField="Promedio_C_Lectura" 
                                HeaderText="Promedio C Lectura" />
                            <asp:BoundField DataField="Promedio_Ortografia" 
                                HeaderText="Promedio Ortografia" />
                            <asp:BoundField DataField="Test_Wartegg" HeaderText="Test Wartegg" />
                            <asp:BoundField DataField="PF_16" HeaderText="PF 16" />
                            <asp:BoundField DataField="Assessment_Center" HeaderText="Assessment Center" />
                            <asp:BoundField DataField="Diligencias" HeaderText="Diligencias" />
                            <asp:BoundField DataField="Resultado_General" HeaderText="Resultado General" />
                            <asp:BoundField DataField="Preseleccionado" HeaderText="Preseleccionado" />
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
