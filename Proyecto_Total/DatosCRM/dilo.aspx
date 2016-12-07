<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="dilo.aspx.vb" Inherits="digitacion.dilo" %>

<%@ Register Src="../menu.ascx" TagName="menu" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro DILO</title>
          <!-- Inicio Script jQuery Datepicker --->
    <link type="text/css" rel="stylesheet" href="../Css2/jquery-ui.css" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui-timepiker.js"></script>
    <script type="text/jscript">
        var $_$ = jQuery.noConflict();
        function pageLoad() {
            $_$("#txtfc_programado").datetimepicker({}).val(); /*Fecha y Hora*/
        }
    </script>

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
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
            color: navy;
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
            width: 100%;
            height: 100%;
        }
        
        .textotittabla
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            background: #E2E8FA;
            width: 15%;
        }
        
        .textotittabla
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
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
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>


    <table style="width: 100%; height: 100%">
        <tr>
            <td class="celdasder">
            </td>
            <td class="celdascent">
                <table style="border-style: outset; border-width: 1px; width: 100%">
                    <tr>
                        <td style="width: 20%">
                            &nbsp;
                        </td>
                        <td align="left" class="titulo">
                            Kamilion Comunicaciones ERP
                        </td>
                    </tr>
                </table>
            </td>
            <td class="celdasder">
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:Label ID="lblmsg" runat="server" Style="color: #FF3300"></asp:Label>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
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
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:Label ID="lblmsg0" runat="server" Style="font-size: medium; font-style: italic">Registro DILO</asp:Label>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
            </td>
            <td style="width: 15%" valign="top">
                <table class="style2">
                    <tr>
                        <td class="style6">
                            <asp:Label ID="lblusuario" runat="server"></asp:Label>
                        </td>
                        <td class="style7">
                            <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
                            &nbsp;&nbsp;<asp:Label ID="LblPerfil" runat="server" Font-Size="X-Large" ForeColor="#0000CC"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label
                                ID="LblSuperVisorTitulo" runat="server" Text="Supervisor: "></asp:Label><asp:Label
                                    ID="LblSupervisor" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 30%" rowspan="1">
                            <table class="style2" frame="border" style="padding: inherit; visibility: visible">
                                <tr>
                                    <td id="Caso" bgcolor="#CCCCFF">
                                        Caso:
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtcaso" runat="server" Width="138px"></asp:TextBox>
                                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtcaso"
                                            ErrorMessage="El caso debe ser numérico" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td style="width: 70%" rowspan="1">
                            <asp:Button ID="Button1" runat="server" Text="Buscar" />
                            &nbsp;<asp:Button ID="btncrea" runat="server" Text="Crear Caso" Visible="False" />
                            <asp:Label ID="lblescalamiento" runat="server" Style="font-size: medium; font-style: italic"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
            <td class="celdasder">
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td style="width: 15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif;
                font-size: medium;" valign="top" class="style3">
                <asp:Button ID="btnguardar" runat="server" Text="Guardar" Style="height: 26px" />
                &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
            </td>
            <td class="celdascent">
             <table border="1" cellpadding="1" cellspacing="1" class="style1">
                    <tr>
                        <td class="textotittabla">
                            Observación
                        </td>
                        
                        <td class="celdascons" colspan=1>
                            <asp:TextBox ID="txtobs" runat="server" Width="99%" Height="45px" TextMode="MultiLine"></asp:TextBox>
                        </td>
                   <%-- </tr>
                    <tr>
                        <td class="textotittabla">
                            Incidente
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="txtincidente" runat="server" Width="250px"></asp:TextBox>
                        </td>
                        <td class="textotittabla">
                            Estado Incidente
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drltipincidente" runat="server" Height="22px" Width="322px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Mesa Escalada
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drlmesaesc" runat="server" Height="27px" Width="249px">
                                <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                <asp:ListItem>P&amp;D</asp:ListItem>
                                <asp:ListItem>O&amp;M</asp:ListItem>
                            </asp:DropDownList>
                        </td>--%>
                        <td class="textotittabla">
                            Barrio
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="txtbarrio" runat="server" Width="310px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Departamento
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drldpto" runat="server" AutoPostBack="True" Height="22px" Width="322px">
                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                <asp:ListItem>SI</asp:ListItem>
                                <asp:ListItem>NO</asp:ListItem>
                                <asp:ListItem>NS/NR</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="textotittabla">
                            Municipio
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drlmun" runat="server" Height="22px" Width="322px">
                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                <asp:ListItem>SI</asp:ListItem>
                                <asp:ListItem>NO</asp:ListItem>
                                <asp:ListItem>NS/NR</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <%--<tr>
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
                            Motivo
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drlMotivo" runat="server">
                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                <asp:ListItem>Informa  Instalar Nx Monitor en otro Momento</asp:ListItem>
                                <asp:ListItem>No le interesa instalar</asp:ListItem>
                                <asp:ListItem>Prefiere que lo llamen despues para asesoria de instalacion</asp:ListItem>
                                <asp:ListItem>Otras causas</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>--%>
                   
                    <tr>
                        <td class="textotittabla" colspan="4">
                            <center>
                                Catalogo de Servicio</center>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Tipo PQR
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drlTipo_PQR" runat="server" Height="22px" Width="322px">
                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="textotittabla">
                            Modalidad
                        </td>
                        <td class="celdascons">
                            
                            <asp:DropDownList ID="drlModalidad" runat="server" Height="22px" Width="322px">
                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                   <%-- <tr>
                        <td class="textotittabla">
                            Tipo Cliente
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drlTipo_Cliente" runat="server" Height="22px" Width="322px">
                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="textotittabla">
                            
                        </td>
                        <td class="celdascons">
                            &nbsp;</td>
                    </tr>--%>
                    <tr>
                        <td class="textotittabla">
                            Línea de Servicio
                        </td>
                        <td class="celdascons">
                            <asp:UpdatePanel ID="UpdatePanel_Linea_Servicio" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="drllinea" runat="server" AutoPostBack="True" Height="22px"
                                        Width="322px">
                                    </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                        <td class="textotittabla">
                            Servicio
                        </td>
                        <td class="celdascons">
                            <asp:UpdatePanel ID="UpdatePanel_Servicio" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="drlservicio2" runat="server" AutoPostBack="True" Height="22px"
                                        Width="322px">
                                    </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Subservicio
                        </td>
                        <td class="celdascons">
                            <asp:UpdatePanel ID="UpdatePanel_Sub_Servicio" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="drlsubservicio" runat="server" AutoPostBack="True" Height="22px"
                                        Width="322px">
                                    </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                        <td class="textotittabla">
                            Solicitud / Tipo Falla
                        </td>
                        <td class="celdascons">
                            <asp:UpdatePanel ID="UpdatePanel_Solicitud_Tipo_Falla" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="drlsolicitud" runat="server" Height="22px" Width="322px">
                                    </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla" style="height: 5px;" colspan="4">
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla" colspan="4">
                            <center>
                                CATALOGO DE DIAGNOSTICO</center>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Reclamo Principal
                        </td>
                        <td class="celdascons">
                            <asp:UpdatePanel ID="UpdatePanel_Reclamo_Principal" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="drlreclamoppal" runat="server" Height="22px" Width="322px"
                                        AutoPostBack="True">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                        <td class="textotittabla">
                            Tipo Falla Rec Ppal
                        </td>
                        <td class="celdascons">
                            <asp:UpdatePanel ID="UpdatePanel_Tipo_Falla_Reclamo_Ppal" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="drltipofalla" runat="server" Height="22px" Width="322px">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Causa raiz
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drlCausa_Raiz" runat="server" Height="22px" Width="322px" 
                                AutoPostBack="True">
                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="textotittabla">
                            Segmento</td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drlSegmento" runat="server" Height="22px" Width="322px" AutoPostBack="True">
                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Elemento
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drlElemento" runat="server" Height="22px" Width="322px" AutoPostBack="True">
                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="textotittabla">
                            &nbsp;Tipo de falla
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drlTipo_De_Falla" runat="server" Height="22px" Width="322px"
                                AutoPostBack="True">
                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Error en Registro
                        </td>
                        <td class="celdascons">
                            <asp:UpdatePanel ID="UpdatePanel_Variable_Diagnostico_2_drl" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="drlvariableCatalogo" runat="server" AutoPostBack="True" Height="22px"
                                        Width="322px">
                                    </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                        <td class="textotittabla">
                            <asp:UpdatePanel ID="UpdatePanel_Variable_Diagnostico_3_Lbl" runat="server">
                                <ContentTemplate>
                                    <asp:Label ID="lblvariable1" runat="server" Font-Size="XX-Small"></asp:Label>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                        <td class="celdascons">
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla" colspan="4">
                            <center>
                                CATEGORIA DE CIERRE</center>
                        </td>
                    </tr>
                     <tr>
                        <td class="textotittabla">
                            Tipo Soporte</td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drltsoporte" runat="server" Height="22px" Width="322px" 
                                AutoPostBack="True">
                            </asp:DropDownList>
                        </td>
                        <td class="textotittabla">
                            &nbsp;Tipo Grupo</td>
                        <td class="celdascons">
<asp:DropDownList ID="drlgrupo" runat="server" AutoPostBack="True" Height="22px"
                                Width="322px" Enabled=false>
                            </asp:DropDownList>
                        &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            &nbsp;Tipificación Llamada</td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drltipificacionll" runat="server" Height="22px" Width="322px"
                                AutoPostBack="True">
                            </asp:DropDownList>
                        </td>
                        <td class="textotittabla">
                            Categoria de cierre</td>
                        <td class="celdascons">                           
                            <asp:DropDownList ID="drlCategoriaCierre" runat="server" AutoPostBack="True" Height="22px"
                                Width="322px">
                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            PQR
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="LblPQR" runat="server"></asp:Label><asp:TextBox ID="TxtPQR" runat="server"
                                MaxLength="7" Width="55px"></asp:TextBox>
                            <asp:CompareValidator ID="CV_PQR" runat="server" ControlToValidate="TxtPQR" ErrorMessage="El valor del PQR debe ser numerico"
                                Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                        </td>
                        <td class="textotittabla">
                                Se comunica a linea alterna</td>
                            <td class="celdascons">
                             <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                    <ContentTemplate> 
                                <asp:RadioButton ID="chkSi" runat="server" GroupName="Numero" Text="SI" AutoPostBack="true"/>
                                <asp:RadioButton ID="chkNo" runat="server" GroupName="Numero" Text="NO" AutoPostBack="true" />
                                <asp:TextBox ID="txtnumalt" runat="server" MaxLength="10" Width="136px" Visible="False" placeholder="Numero" ></asp:TextBox>
                                 <asp:CompareValidator ID="CompareValidator2" Display="Dynamic"  runat="server" ControlToValidate="txtnumalt" ValidationGroup="VG_Registrar" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                 <asp:RegularExpressionValidator ID="telefono" runat="server" ErrorMessage="*" ValidationExpression="^[\w \# \. \: \- \s]{10,200}$" ControlToValidate="txtnumalt" Display="Dynamic" CssClass="textoError" />
                                    </ContentTemplate> 
                                    </asp:UpdatePanel>                                   
                            </td>

                    </tr>
                    <%--Fecha programado--%>
                    <tr>
                        <td class="textotittabla" colspan="4">
                            <center>
                                SEGUIMIENTO</center>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Fecha Programacion
                        </td>
                        <td class="celdascons">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:TextBox ID="txtfc_programado" runat="server"  placeholder="DD/MM/YYYY H:mm:ss"
                                             MaxLength="20"></asp:TextBox>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                        <td class="textotittabla">
                            Liberar Caso
                        </td>
                        <td class="celdascons">
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="drlLibera" runat="server" AutoPostBack="True" CssClass="form-control"
                                                    Enabled="true">
                                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>SI</asp:ListItem>
                                                    <asp:ListItem>NO</asp:ListItem>
                                                </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <%--fin programado--%>




                    <%--Inconsistencia *611--%>
                    <tr>
                        <td class="textotittabla" colspan="4">
                            <center>
                                ENCUESTA</center>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Inconsistencia atencion *611
                        </td>
                        <td class="celdascons">
                            <asp:UpdatePanel ID="UpdatePanel22" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="drlinconsistencia" runat="server" AutoPostBack="True" Enabled="true">
                                    </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                        <td class="textotittabla">
                            Observacion de inconsistencia
                        </td>
                        <td class="celdascons">
                            <asp:UpdatePanel ID="UpdatePanel23" runat="server">
                                <ContentTemplate>
                                    <asp:TextBox ID="txtobsincon" runat="server" TextMode="MultiLine" AutoPostBack="true"
                                        Width="99%" Enabled="false"></asp:TextBox>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <%--fin Inconsistencia--%>


                </table>

            </td>
            <td class="celdasder">
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" />
            </td>
            <td class="celdascent">
                <table border="1" cellpadding="1" cellspacing="1" class="style1">
                    <tr>
                        <td class="textotittabla">
                            Fecha Reporte
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="lblfcreporte" runat="server"></asp:Label>
                        </td>
                        <td class="textotittabla">
                            Min
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="lblmin" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Tel Contacto
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="lbltelcontacto" runat="server"></asp:Label>
                        </td>
                        <td class="textotittabla">
                            Cliente
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="lblcliente" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Equipo
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="lblequipo" runat="server"></asp:Label>
                        </td>
                        <td class="textotittabla">
                            Tecnología
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="lbltecnologia" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Tipo Falla
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="lbltipofalla" runat="server"></asp:Label>
                        </td>
                        <td class="textotittabla">
                            Estado
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="lblestado" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Mesa
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="lblmesa" runat="server"></asp:Label>
                        </td>
                        <td class="textotittabla">
                            Solicitud
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="lblsolicitud" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Barrio
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="lblbarrio" runat="server"></asp:Label>
                        </td>
                        <td class="textotittabla">
                            Caso
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="lblcaso" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Fecha Ingreso
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="Lblfc_ingreso" runat="server"></asp:Label>
                        </td>
                        <td class="textotittabla">
                            Numero Alterno
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="lblNumero_Alterno" runat="server"></asp:Label>
                        </td>

                    </tr>
                </table>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
   
                            Casos Asignados:
                            <asp:Label ID="lblcasos_asig" 
                                    runat="server"></asp:Label>
                            <asp:GridView ID="dtgprog" runat="server" AllowPaging="True"
                                CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="5" Width="100%"
                                Style="font-size: x-small" EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" HorizontalAlign="Center"/>
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>        
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>


        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                &nbsp;
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:LinkButton ID="LinkButton3" runat="server">Reportar Inconsistencia</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton4" runat="server">Ocultar Inconsistencia</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton5" runat="server">Reportar Falla Red</asp:LinkButton>
                &nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton6" runat="server">Ocultar Falla Red</asp:LinkButton>
                &nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton7" runat="server">Escalamiento Service</asp:LinkButton>
                &nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton8" runat="server">Ocultar Esc. Service</asp:LinkButton>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:Panel ID="pnservice" runat="server" Visible="False">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                <asp:Button ID="btnguardservice" runat="server" Text="Guardar" Width="68px" />
                            </td>
                            <td class="celdascons">
                                Escalamiento Service
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Variables de Diagnóstico
                            </td>
                            <td class="celdascons">
                                <asp:RadioButtonList ID="rdbron" runat="server" AutoPostBack="True" Font-Size="XX-Small">
                                    <asp:ListItem Selected="True">Error en Registro</asp:ListItem>
                                    <asp:ListItem>Ajeno a Red Celular</asp:ListItem>
                                    <asp:ListItem>Asociado Red Celular</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                            <td class="textotittabla">
                                <asp:Label ID="lblvariable" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlvariable" runat="server" AutoPostBack="True" Height="22px"
                                    Width="322px">
                                </asp:DropDownList>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Apn
                            </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlapn" runat="server" Height="22px" Width="322px">
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Fecha Activación
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtfcactivacion" runat="server" MaxLength="10" placeholder="dd/mm/aaaa"
                                    Width="136px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                QoS
                            </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlqos" runat="server" Height="22px" Width="322px">
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Archivo
                            </td>
                            <td class="celdascons">
                                <asp:FileUpload ID="FileDocumento" runat="server" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                &nbsp;
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:Panel ID="Pninc" runat="server" Visible="False">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                <asp:Button ID="btnguardar0" runat="server" Text="Guardar" Width="68px" />
                            </td>
                            <td class="celdascons">
                                Registro de Inconsistencia
                            </td>
                            <td class="textotittabla">
                                Cuenta Financiera
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="txt_registro_numerico" runat="server" Width="136px" MaxLength="12"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_registro_numerico"
                                    ErrorMessage="el numero debe ser positivo" ValidationExpression="^[0-9]*$">*</asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Custcode
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="Txt_custcode" runat="server" Width="136px" MaxLength="23"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" Type="Decimal" runat="server"
                                    ControlToValidate="Txt_custcode" ErrorMessage="El custcode debe ser numerico"
                                    ValidationExpression="([0-9]|\.)*">*</asp:RegularExpressionValidator>
                            </td>
                            <td class="textotittabla">
                                Usuario Reporta
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="Txt_usuario_reporta" runat="server" Width="136px" MaxLength="20"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td class="textotittabla">
                                Tipificación
                            </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlinconsglobal" runat="server" AutoPostBack="True" Height="22px"
                                    Width="322px">
                                    <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                    <asp:ListItem>SI</asp:ListItem>
                                    <asp:ListItem>NO</asp:ListItem>
                                    <asp:ListItem>NS/NR</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Tipo Inconsistencia
                            </td>
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
                                Nivel
                            </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlnivel" runat="server" Height="22px" Width="322px">
                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                    <asp:ListItem>Call</asp:ListItem>
                                    <asp:ListItem>Operacion</asp:ListItem>
                                    <asp:ListItem>Call/Operac</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Observación Inconsistencia
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtobsinc" runat="server" Height="45px" TextMode="MultiLine" Width="99%"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:Panel ID="PNEscalam" runat="server" Visible="False">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                <asp:Button ID="btnguardar1" runat="server" Style="height: 26px" Text="Guardar" />
                            </td>
                            <td>
                                Registro de Falla de Red
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Persona Contacto
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtFcontacto" runat="server" Width="278px"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Número Contacto
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtFnum" runat="server" Width="136px" MaxLength="10"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Tiempo Falla
                            </td>
                            <td class="celdascons">
                    <asp:DropDownList ID="drlFtiempo" runat="server" CssClass="form-control">
                                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                        <asp:ListItem Value="&lt;=15">&lt;=15</asp:ListItem>
                                                        <asp:ListItem Value="&gt;15">&gt;15</asp:ListItem>
                                                        </asp:DropDownList>   

                            </td>
                            <td class="textotittabla">
                                Tipo Falla
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtFtipofalla" runat="server" Width="285px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Características de la Falla
                            </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlFcaract" runat="server" Height="22px" Width="302px">
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Línea Portada
                            </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlFportada" runat="server" Height="22px" Width="130px">
                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                    <asp:ListItem>FALSO</asp:ListItem>
                                    <asp:ListItem>VERDADERO</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nombre Vereda o Corregimiento
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtFciudad" runat="server" Width="279px"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Tipo Lugar
                            </td>
                            <td class="celdascons">
                                <asp:RadioButtonList ID="rdbvc" runat="server" Font-Size="XX-Small" Width="219px">
                                    <asp:ListItem Value="VRD">Vereda</asp:ListItem>
                                    <asp:ListItem Value="CRG">Corregimiento</asp:ListItem>
                                    <asp:ListItem Value="INS">Inspección</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Dirección Falla
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtFdirecc" runat="server" Width="279px"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Condiciones de Uso
                            </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlFtectolog" runat="server" Height="22px" Width="130px">
                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                    <asp:ListItem>GSM</asp:ListItem>
                                    <asp:ListItem>3G</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Marca
                            </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlmarca" runat="server" Height="22px" Width="322px" AutoPostBack="True">
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Equipo&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="lblctrl" runat="server">0</asp:Label>
                            </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlequipo" runat="server" Height="22px" Width="322px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                APN
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtapn" runat="server" Width="279px"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                QoS
                            </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="Drl_Qos" runat="server" Height="22px" Width="322px">
                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Lineas con falla en la Ubicación Reportada
                            </td>
                            <td class="celdascons">
                              <asp:DropDownList ID="drlFlineasfalla" runat="server" CssClass="form-control" Height="45px">
                                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                        <asp:ListItem>SI</asp:ListItem>
                                                        <asp:ListItem>NO</asp:ListItem>
                           
                         </asp:DropDownList>

                            </td>
                            <td class="textotittabla">
                                Observación Cliente
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtfobs" runat="server" Height="45px" TextMode="MultiLine" Width="99%"></asp:TextBox>
                            </td>
                            <tr>
                                <td class="textotittabla">
                                    Canal Dilo
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="DrlCanalDilo" runat="server" Height="22px" Width="130px">
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                </td>
                                <td class="celdascons">
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla" colspan="4">
                                    <center>
                                        Validaciones servicio al cliente</center>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    La falla se presenta luego de que se construyera una edificación aledaña
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania"
                                        runat="server" Height="22px" Width="322px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem Value="FALSO"></asp:ListItem>
                                        <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    La falla se presenta luego de que se remodelara la estructura física del edificio
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio"
                                        runat="server" Height="22px" Width="322px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem Value="FALSO"></asp:ListItem>
                                        <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Tipo de edificación donde se presenta la falla
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="Drl_Tipo_Edificacion_Donde_Presenta_Falla_1" runat="server"
                                        Height="22px" Width="200px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:DropDownList ID="Drl_Tipo_Edificacion_Donde_Presenta_Falla_2" runat="server"
                                        Height="22px" Width="100px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Validaciones de falla masiva
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="Drl_Validaciones_Falla_Masiva" runat="server" Height="22px"
                                        Width="322px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem Value="FALSO"></asp:ListItem>
                                        <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Tecnología en la que se presenta la falla - Luego de pruebas
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="Drl_Tecnologia_Presenta_Falla_Luegodepruebas" runat="server"
                                        Height="22px" Width="322px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Validación de Coordenadas
                                </td>
                                <td class="celdascons">
                                    <asp:TextBox ID="Txt_Validacion_Coordenadas" runat="server" MaxLength="20" Width="279px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Línea no cuenta con bloqueos de Internet
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="Drl_Linea_No_Cuenta_Bloqueos_Internet" runat="server" Height="22px"
                                        Width="322px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem Value="FALSO"></asp:ListItem>
                                        <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Línea no ha superado el limite de consumos
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="Drl_Linea_No_Superado_Limite_Consumos" runat="server" Height="22px"
                                        Width="322px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem Value="FALSO"></asp:ListItem>
                                        <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Línea no se encuentra enrutada por pagos
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="Drl_Linea_No_Encuentra_Enrutada_PorPagos" runat="server" Height="22px"
                                        Width="322px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem Value="FALSO"></asp:ListItem>
                                        <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    HLR / HSS
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="Drl_HLR_HSS" runat="server" Height="22px" Width="322px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem Value="FALSO"></asp:ListItem>
                                        <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    No existen cambios administrativos sobre la línea o cuenta maestra
                                </td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UpdatePanel_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra"
                                        runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra"
                                                runat="server" AutoPostBack="True" Height="22px" Width="322px">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                            <br />
                                            <asp:DropDownList ID="Drl_Split_Billing" runat="server" Height="22px" Visible="False"
                                                Width="322px">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="textotittabla">
                                    Se realizan pruebas de SIMCARD en otro dispositivo (Persiste Falla)
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla"
                                        runat="server" Height="22px" Width="322px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem Value="FALSO"></asp:ListItem>
                                        <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Se forza la red del dispositivo
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="Drl_Forza_Red_Dispositivo" runat="server" Height="22px" Width="322px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Se verifica o realiza configuración de APN
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="Drl_Verifica_Realiza_Configuración_APN" runat="server" Height="22px"
                                        Width="322px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Equipo se encuentra homologado por el operador
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="Drl_Equipo_Encuentra_Homologado_Operador" runat="server" Height="22px"
                                        Width="322px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem Value="FALSO"></asp:ListItem>
                                        <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">
                                    Se realiza conciliación sobre la línea
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="Drl_Realiza_Conciliacion_Sobre_linea" runat="server" Height="22px"
                                        Width="322px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem Value="FALSO"></asp:ListItem>
                                        <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                &nbsp;
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:Panel ID="pnnuevo" runat="server" Visible="False">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                <asp:Button ID="btnguardar2" runat="server" Text="Guardar" Width="68px" />
                            </td>
                            <td class="celdascons">
                                Nuevo Registro Dilo
                            </td>
                            <td class="textotittabla">
                                Caso
                            </td>
                            <td>
                                <asp:TextBox ID="TxtCasoNuevo" runat="server" Width="138px"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator8" runat="server" ControlToValidate="TxtCasoNuevo"
                                    ErrorMessage="El caso debe ser numérico" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Min
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtminnv" runat="server" MaxLength="10"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator7" runat="server" ControlToValidate="txtminnv"
                                    ErrorMessage="El min es numérico sin espacios ni caracteres" Operator="DataTypeCheck"
                                    Type="Double">*</asp:CompareValidator>
                            </td>
                            <td class="textotittabla">
                                Nombre
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtnombrenv" runat="server" Width="283px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">Canal</td>
                            <td class="celdascons">
                             <asp:DropDownList ID="DrlCanalDiloNv" runat="server" Height="22px" Width="130px">
                                        </asp:DropDownList>
                            </td>
                            </tr>

                    </table>
                </asp:Panel>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                Consulta Seguimientos&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblcuenta" runat="server"></asp:Label>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                    CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="20" Width="100%"
                    Style="font-size: x-small">
                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="idcrmdilo" HeaderText="ID" />
                        <asp:BoundField DataField="idcasodilo" HeaderText="Caso" />
                        <asp:BoundField DataField="mesa" HeaderText="Mesa" />
                        <asp:BoundField DataField="min" HeaderText="Min" />
                        <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                        <asp:BoundField DataField="idusuario" HeaderText="Agente" />
                        <asp:BoundField DataField="obs" HeaderText="Observación" />
                        <asp:BoundField DataField="tipo_soporte" HeaderText="Tipo Soporte" />
                        <asp:BoundField DataField="tipificacion" HeaderText="Tipificación" />
                        <asp:BoundField DataField="incidente" HeaderText="Incidente" />
                        <asp:BoundField DataField="estadoinc" HeaderText="Estado Incidente" />
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
                &nbsp;
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
