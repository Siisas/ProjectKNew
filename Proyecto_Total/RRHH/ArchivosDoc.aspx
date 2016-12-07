<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ArchivosDoc.aspx.vb" Inherits="digitacion.ArchivosDoc" %>

<%@ Register Src="../menu.ascx" TagName="menu" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ERP Kamilion - Archivos Doc</title>
    <link rel="icon" href="../favicon.ico" type="image/x-icon"/>
  <link type="text/css"rel="stylesheet" href="../Css2/FormStyle.css" />  
  <!-- Inicio Script jQuery Datepicker --->

  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <script type="text/jscript">
      $(function () {
          $("#TxtFecha_Recepcion").datepicker();
          $('#TxtFecha_Recepcion').datepicker('option', { dateFormat: 'dd/mm/yy' });
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
        .auto-style1 {
            width: 86px;
        }
        /*letra*/
.Rotate-90
{
  -webkit-transform: rotate(-90deg);
  -moz-transform: rotate(-90deg);
  -ms-transform: rotate(-90deg);
  -o-transform: rotate(-90deg);
  transform: rotate(-90deg);
 
  -webkit-transform-origin: 50% 50%;
  -moz-transform-origin: 50% 50%;
  -ms-transform-origin: 50% 50%;
  -o-transform-origin: 50% 50%;
  transform-origin: 50% 50%;
 
  font-size: 40px;
  background: #e0e0e0;
  width: 121px;
  position: relative;
  top: -3px;
            left: -2px;
            height: 184px;
        }
        .auto-style7 {
            width: 196px;
        }
        .auto-style9 {
            width: 185px;
        }
        .auto-style10 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 33px;
        }
        .auto-style12 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 55px;
        }
        .auto-style13 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 9%;
        }
        .auto-style14 {
            width: 48px;
            height: 48px;
        }
        .auto-style15 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
        }
        .auto-style16 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 233px;
        }
        .auto-style17 {
            width: 23%;
        }
        .auto-style18 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 18%;
            background: #E2E8FA;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
           </asp:ScriptManager>
        <table style="width:100%; height: 100%">
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
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    Documentos Kamilion</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </table>
            <table style="width:100%">
            <tr>
                <td class="auto-style16">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Verdana, Geneva, Tahoma, sans-serif; color: #000000; background-color: #AAD2FF;" class="style3">
                    <center>PROCESOS ESTRATEGICOS</center></td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>        
            <tr>
                <td class="auto-style16" align="right"><div style="border: medium ridge #6CAFFC; width:300px; height: 40px; background: #FFFFFF; font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif; color: #000000; font-size: 180%;" class="Rotate-90">
<center>REQUISITOS DEL CLIENTE</center></div></td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">

                    <table style="width:100%; height: 30%">
            <tr>
                
                <td class="auto-style9" style="background-color: #AAD2FF">
                            <center><asp:Button ID="btngerencial" runat="server" CssClass="EstiloBoton" Text="GERENCIAL" Font-Size="Small" /></center>
                        </td>
                <td class="auto-style7" style="background-color: #AAD2FF">
                <center><asp:Button ID="btnComercial" runat="server" CssClass="EstiloBoton" Text="COMERCIAL" Font-Size="Small" /></center>
                </td>
                <td class="auto-style1" style="background-color: #AAD2FF">
                        <center><asp:Button ID="btnCalidadymejora" runat="server" CssClass="EstiloBoton" Text="CALIDAD Y MEJORA" Font-Size="Small" Width="161px" /></center>
                    </td>
                
            </tr>
            </table>
                    <table style="width:100%">
                        <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <center><img class="auto-style14" src="../Css2/Imagenes/abajo.png" /></center></td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Verdana, Geneva, Tahoma, sans-serif; color: #000000; background-color: #D4D4D4;" class="style3">
                    <center>PROCESOS MISIONALES</center></td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </table>
                    <table style="width:100%">
        <tr>
                <td class="celdasder">
                    <img alt="" class="auto-style14" src="../Css2/Imagenes/derecha.png" /></td>
            <td class="auto-style13" style="background-color: #D4D4D4;">
                    &nbsp;</td>
                <td class="auto-style10" style="background-color: #D4D4D4;">
                            <center><asp:Button ID="btnOperaciones" runat="server" CssClass="EstiloBoton" Text="OPERACIONES" Font-Size="Small" Width="122px" /></center>
                        </td>
            <td class="celdasder" style="background-color: #D4D4D4;">
                    &nbsp;</td>
            <td class="celdasder">
                <img alt="" class="auto-style14" src="../Css2/Imagenes/izquierda.png" /></td>
            </tr>
            </table>
                    <table style="width:100%">
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; background-color: #D4D4D4;" 
                    valign="top" class="style3"></td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <center><img alt="" class="auto-style14" src="../Css2/Imagenes/arriba.png" /></center></td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </table>
        <table style="width:100%">
        <tr>
                
            <td class="celdasder" style="background-color: #AAD2FF">
                <center><asp:Button ID="btnTecnologia" runat="server" CssClass="EstiloBoton" Text="TECNOLOGIA" Font-Size="Small" /></center>
                            </td>
                <td class="celdasder" style="background-color: #AAD2FF">
                            <center><asp:Button ID="btnCompras" runat="server" CssClass="EstiloBoton" Text="COMPRAS" Font-Size="Small" /></center>
                        </td>
            <td class="celdasder" style="background-color: #AAD2FF">
                        <center><asp:Button ID="btnFinanciera" runat="server" CssClass="EstiloBoton" Text="FINANCIERA" Font-Size="Small" /></center>
                    </td>
            <td class="celdasder" style="background-color: #AAD2FF">
                <center><asp:Button ID="btnTalentohumano" runat="server" CssClass="EstiloBoton" Text="TALENTO HUMANO" Font-Size="Small" Width="181px" /></center>
                    </td>
            </tr>
            </table>
                </td>
                <td class="auto-style15"><div style="border: medium ridge #6CAFFC; width:300px; height: 40px; background: #FFFFFF; font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif; color: #000000; font-size: 180%;" class="Rotate-90">
<center>CLIENTE SATISFECHO</center></div></td>
                
            </tr>
            <tr>
                <td class="auto-style16">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Verdana, Geneva, Tahoma, sans-serif; color: #000000; background-color: #AAD2FF;" class="style3">
                    <center>PROCESO DE APOYO</center></td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
                <tr>
                <td class="auto-style16">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Verdana, Geneva, Tahoma, sans-serif; color: #000000; " class="style3">
                    &nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16">
                    &nbsp;</td>
                <asp:Panel ID="PanelSubprocesos" runat="server" Visible="false"><td style="font-weight: 700; font-family: Verdana, Geneva, Tahoma, sans-serif; color: #000000; background-color: #AAD2FF;" class="style3">
                    <center>SUB-PROCESOS</center></td></asp:Panel>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Verdana, Geneva, Tahoma, sans-serif; color: #000000; " class="style3">
                    <table style="width:100%">
                    <asp:Panel ID="PanelBotones" runat="server" Visible="true"><tr>
                
            <td class="celdasder" style="background-color: #AAD2FF">
                <center><asp:Button ID="btnDatos" runat="server" CssClass="EstiloBoton" Text="Datos" Font-Size="Small" Visible="False" /></center>
                            </td>
                <td class="celdasder" style="background-color: #AAD2FF">
                            <center><asp:Button ID="btnVoz" runat="server" CssClass="EstiloBoton" Text="Voz" Font-Size="Small" Visible="False" /></center>
                        </td>
                        <td class="celdasder" style="background-color: #AAD2FF">
                        <center><asp:Button ID="btnVozyDatos" runat="server" CssClass="EstiloBoton" Text="Voz y Datos" Font-Size="Small" Visible="False" /></center>
                    </td>
            <td class="celdasder" style="background-color: #AAD2FF">
                        <center><asp:Button ID="btnFormacion" runat="server" CssClass="EstiloBoton" Text="Formación" Font-Size="Small" Visible="False" /></center>
                    </td>
            <td class="celdasder" style="background-color: #AAD2FF">
                        <center><asp:Button ID="btnInformacion" runat="server" CssClass="EstiloBoton" Text="Información" Font-Size="Small" Visible="False" /></center>
                    </td>
            <td class="celdasder" style="background-color: #AAD2FF">
                        <center><asp:Button ID="btnOtros" runat="server" CssClass="EstiloBoton" Text="Otros" Font-Size="Small" Visible="False" /></center>
                    </td>
                </tr></asp:Panel>
                </table>
                </td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
         </table> 
        <table style="width:100%; height: 100%">
            
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" colspan="4">
                                <center><asp:Label ID="Label1" runat="server" Text="Registros" 
                                        Font-Size="Larger"></asp:Label></center></td>                           
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nombre</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtNombre_Registro" runat="server"></asp:TextBox>
                                </td>
                            <td class="textotittabla">
                                Adjuntar Documento</td>
                            <td class="celdascons">
                                <asp:FileUpload ID="FileDocumento" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Proceso</td>
                            <td class="celdascons">
                                <asp:UpdatePanel ID="UpdatePanel_Categoria_Registro" runat="server">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="drlCategoria_Registro" runat="server" AutoPostBack="true">
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                            <td class="textotittabla">
                                 Sub-procesos</td>
                            <td class="celdascons">
                                <asp:UpdatePanel ID="UpdatePanel_Dependencia_Registro" runat="server">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="drlDependencia_Registro" runat="server">
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                 Observación</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="txtObservacion" runat="server" Height="45px" TextMode="MultiLine" 
                                    Width="99%" MaxLength="500"></asp:TextBox></td>
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <asp:ImageButton ID="BtnRegistrar" runat="server" Height="57px" 
                        ImageUrl="~/Css2/Imagenes/Nuevo.png" Width="60px" 
                        AlternateText="Registrar" title="Registrar" />                    
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
                            <td class="textotittabla" colspan="4">
                                <center><asp:Label ID="Label2" runat="server" Text="Actualización de la Version" 
                                        Font-Size="Larger"></asp:Label></center></td>                           
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Codigo</td>
                            <td class="auto-style17">
                                <asp:Label ID="lblidCodigo" runat="server"></asp:Label>
                                <asp:Label ID="lblbCodhistorial" runat="server" Visible="False"></asp:Label>
                                </td>
                            <td class="auto-style18">
                                Fecha de Registrio</td>
                            <td class="celdascons">
                                <asp:Label ID="lblFcreg" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nombre</td>
                            <td class="auto-style17">
                                <asp:Label ID="lblnombre" runat="server" ></asp:Label>
                                </td>
                            <td class="auto-style18">
                                Adjuntar Documento</td>
                            <td class="celdascons">
                                <asp:FileUpload ID="FileDocumento2" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Proceso</td>
                            <td class="auto-style17">
                                <asp:Label ID="lblProceso" runat="server"></asp:Label>
                                </td>
                            <td class="auto-style18">
                                 Sub-Procesos</td>
                            <td class="celdascons">
                                <asp:Label ID="lblSubproceso" runat="server" ></asp:Label>                                
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Versión</td>
                            <td class="auto-style17">
                                <asp:TextBox ID="Txtversion2" runat="server"></asp:TextBox>
                                <asp:CompareValidator ID="CVversion" runat="server" ErrorMessage="La version solo puede ser numerica *" Operator="DataTypeCheck" ControlToValidate="Txtversion2" Type="Double">*</asp:CompareValidator>
                                <asp:Label ID="lblVersion" runat="server" visible="false"></asp:Label>
                                </td>
                            <td class="auto-style18">
                                 Observación</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="txtObservacion2" runat="server" Height="45px" TextMode="MultiLine" 
                                    Width="99%" MaxLength="500"></asp:TextBox></td>
                        </tr>
                        </table>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <asp:ImageButton ID="btnActualizar2" runat="server" Height="57px" 
                        ImageUrl="~/Css2/Imagenes/Actualiza.png" Width="60px" 
                        AlternateText="Actualizar" title="Actualizar" />
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
                            <td class="textotittabla" colspan="4">
                                <center><asp:Label ID="LblTitulo" runat="server" Text="Consultas" 
                                        Font-Size="Larger"></asp:Label></center></td>                           
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Codigo</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtCod_Archivo" runat="server"></asp:TextBox>
                                <asp:CompareValidator ID="CVCod_Archivo" runat="server" ErrorMessage="El codigo que intenta buscar debe ser numerico *" Operator="DataTypeCheck" ControlToValidate="TxtCod_Archivo" Type="Double">*</asp:CompareValidator>
                                <asp:Label ID="lblCodHistorial" runat="server" visible="false"></asp:Label>
                                </td>
                            <td class="textotittabla">
                                Proceso</td>
                            <td class="celdascons">
                                <asp:UpdatePanel ID="UpdatePanel_Categoria" runat="server">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="drlCategoria" runat="server" AutoPostBack="true">
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nombre</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
                                </td>
                            <td class="textotittabla">
                                 Sub-proceso</td>
                            <td class="celdascons">
                                <asp:UpdatePanel ID="UpdatePanel_Dependencia" runat="server">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="drlDependencia" runat="server">
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <asp:ImageButton ID="BtnConsulta" runat="server" Height="57px" 
                        ImageUrl="~/Css2/Imagenes/Consulta.png" Width="60px" 
                        AlternateText="Consultar" title="Consultar" />                    
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    Registros Encontrados&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Label ID="lblCuenta_Registros" runat="server"></asp:Label>
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
                        GridLines="None" PageSize="100" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Cod_Archivo" HeaderText="Codigo" >
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Categoria" HeaderText="Categoria" >
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Dependencia" HeaderText="Dependencia" >
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" >
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Version" HeaderText="VERSION">
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Observacion" HeaderText="OBSERVACION">
                            <ItemStyle HorizontalAlign="Justify" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Id_Usuario" HeaderText="USUARIO">
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="FcReg" HeaderText="FECHA DE REGISTRO">
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="Descargar Archivo">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink1" runat="server" text="Descargar" NavigateUrl='<%#Databinder.Eval(container, "DataItem.url","~/RRHH/data_doc/{0}")%>' Target='_blank'></asp:HyperLink>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                            <asp:ButtonField HeaderText="Seleccionar" Text="Seleccionar" CommandName="Seleccionar">
                            <HeaderStyle HorizontalAlign="Center" />
                            </asp:ButtonField>
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
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    Consulta Versiones almacenadas :&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Label ID="lblcuentaVersiones" runat="server"></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                    <asp:GridView ID="dtgVersiones" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="100" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Cod_Archivo" HeaderText="Codigo" >
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Categoria" HeaderText="Categoria" >
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Dependencia" HeaderText="Dependencia" >
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" >
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Version" HeaderText="VERSION">
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Observacion" HeaderText="OBSERVACION">
                            <ItemStyle HorizontalAlign="Justify" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="Descargar Archivo">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink1" runat="server" text="Descargar" NavigateUrl='<%#Databinder.Eval(container, "DataItem.url","~/RRHH/data_doc/{0}")%>' Target='_blank'></asp:HyperLink>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
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
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
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