<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ReporteSolicitado.aspx.vb" Inherits="digitacion.ReporteSolicitado" %>
<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="head1" runat="server">
<title>ERP Kamilion</title>

  <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  
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
        .style8
        {
            width: 864px;
        }
        .style9
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 7%;
            background: #E2E8FA;
        }
        .style10
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 15%;
            height: 34px;
            background: #E2E8FA;
        }
        .style11
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 15%;
            height: 27px;
            background: #E2E8FA;
        }
        .style12
        {
            width: 35%;
            height: 27px;
        }
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 53%;
        }
        .auto-style2 {
            width: 53%;
        }
        .auto-style3 {
            color: #000099;
            width: 53%;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 36%;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <table style="width:100%; height: 100%">
        <tr>
                <td class="celdasder">
                </td>
                <td class="auto-style1">
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
                <td class="auto-style1">
                    <asp:Label ID="lblmsg" runat="server" style="color: #FF3300"></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
        <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="auto-style1">
                    <uc1:menu ID="menu1" runat="server" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
        <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="auto-style1">
                    <asp:Label ID="lblmsg0" runat="server" 
                        style="font-size: medium; font-style: italic">Reportes Solicitados</asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
         <tr>
                <td class="celdasder">
                </td>
                <td valign="top" class="auto-style2">
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
                    valign="top" class="auto-style3">
                    Busqueda</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
         <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style3">
                <table border="1" cellpadding="1" cellspacing="1" class="style1">
                    <tr>
                            <td class="textotittabla">
                                Campaña</td>
                            <td class="auto-style4">
                                <asp:DropDownList ID="drlCampaña" runat="server" AutoPostBack="True">
                                    <asp:ListItem>- Elija una opción -</asp:ListItem>
                                    <asp:ListItem>Datos</asp:ListItem>
                                    <asp:ListItem>Voz</asp:ListItem>
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                Sub Campaña</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlconsultaDa" runat="server" Visible ="false" >
                                    <asp:ListItem>- Elija una opción -</asp:ListItem>
                                    <asp:ListItem>CIERRE</asp:ListItem>
                                    <asp:ListItem>DATOS</asp:ListItem>
                                    <asp:ListItem>DATOS_PREPAGO</asp:ListItem>
                                    <asp:ListItem>DATOS_POSPAGO</asp:ListItem>
                                    <asp:ListItem>EMPRESARIALES</asp:ListItem>
                                    <asp:ListItem>INBOUND</asp:ListItem>
                                     <asp:ListItem>NIVEL_3</asp:ListItem>
                                    <asp:ListItem>PQR_DATOS</asp:ListItem>
                                    <asp:ListItem>4G-LTE</asp:ListItem>
                                </asp:DropDownList>
                                <asp:DropDownList ID="drlconsultaVo" runat="server" Visible ="false" >
                                    <asp:ListItem>- Elija una opción -</asp:ListItem>
                                    <asp:ListItem>BANCA MOVIL</asp:ListItem>
                                    <asp:ListItem>BUZON</asp:ListItem>
                                   <asp:ListItem>CONSOLIDADO_VOZ</asp:ListItem>
                                    <asp:ListItem>LDI</asp:ListItem>
                                    <asp:ListItem>MENSAJES</asp:ListItem>
                                    <asp:ListItem>OTROS SERV</asp:ListItem>
                                    <asp:ListItem>PQR_VOZ</asp:ListItem>
                                    <asp:ListItem>VOZ</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                    <tr>
                        <td class="textotittabla">
                               Fecha</td>
                        <td class="celdascons">                                
                               <asp:TextBox ID="txtFecha" runat="server" placeholder="DD/MM/AAAA" MaxLength="10"></asp:TextBox>
                                 <asp:CompareValidator ID="ComVatxtFecha" runat="server" ControlToValidate="txtFecha" ErrorMessage="Fecha mal ingresada" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
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
                <td class="style4">
                        <asp:Label ID="LblmsgReportes" runat="server" style="color: #FF3300"></asp:Label>
                        </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
         <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style3">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Visible="true" />
                    &nbsp;&nbsp;&nbsp;
                   <asp:Button ID="btnExportar" runat="server" Text="Exportar" Visible="False" /> </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
         <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style3">
                    <table cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="celdascons" colspan="2">
                                <center>
                                    Numero de registros:
                                    <asp:Label ID="lblcantidad" runat="server"></asp:Label>
                                </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5" colspan="2">
                                <center>
                                    CONSULTAS</center>
                            </td>
                        </tr>
                        <tr  style="border:none">
                            <td>
                                <asp:GridView ID="dtgReporteso" runat="server" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="false" ForeColor="#333333" GridLines="None" PageSize="900" style="font-size: x-small" Width="100%">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="fsap" HeaderText="Fecha Sap" />
                                        <asp:BoundField DataField="fc_corta" HeaderText="Fecha Registro" />
                                        <asp:BoundField DataField="ABIERTO" HeaderText="Abierto" />
                                        <asp:BoundField DataField="CERRADO" HeaderText="Cerrado" />
                                        <asp:BoundField DataField="ESCALADO" HeaderText="Escalado" />
                                        <asp:BoundField DataField="GESTIONADO" HeaderText="Gestionado" />
                                        <asp:BoundField DataField="ILOCALIZABLE" HeaderText="Ilocalizable" />
                                        <asp:BoundField DataField="NO DISPONIBLE" HeaderText="No Disponible" />
                                        <asp:BoundField DataField="PROGRAMADO" HeaderText="Programado" />
                                        <asp:BoundField DataField="RELLAMADA" HeaderText="Rellamada" />
                                        <asp:BoundField DataField="Tol" HeaderText="Total" />
                                        <asp:BoundField DataField="Pend" HeaderText="Pendiaentes" />
                                        <asp:BoundField DataField="Por" HeaderText="Porcentaje" />
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
                        <tr  style="border:none">
                            <td>
                                <asp:GridView ID="dtgReporteso2" runat="server" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="false" ForeColor="#333333" GridLines="None" PageSize="900" style="font-size: x-small" Visible="False" Width="100%">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="f_sap" HeaderText="Fecha Sap" />
                                        <asp:BoundField DataField="fccorta" HeaderText="Fecha Registro" />
                                        <asp:BoundField DataField="Abierto" HeaderText="Abierto" />
                                        <asp:BoundField DataField="Cerrado" HeaderText="Cerrado" />
                                        <asp:BoundField DataField="Escalado" HeaderText="Escalado" />
                                        <asp:BoundField DataField="Gestionado" HeaderText="Gestionado" />
                                        <asp:BoundField DataField="Ilocalizable" HeaderText="Ilocalizable" />
                                        <asp:BoundField DataField="No Disponible" HeaderText="No Disponible" />
                                        <asp:BoundField DataField="Rechazado" HeaderText="Rechazado" />
                                        <asp:BoundField DataField="Tol" HeaderText="Total" />
                                        <asp:BoundField DataField="Pend" HeaderText="Pendiaentes" />
                                        <asp:BoundField DataField="Por" HeaderText="Porcentaje" />
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
                         <tr  style="border:none">
                            <td>
                                <asp:GridView ID="dtgReporteso1" runat="server" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="false" ForeColor="#333333" GridLines="None" PageSize="900" style="font-size: x-small" Visible="False" Width="100%">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="fsap" HeaderText="Fecha Sap" />
                                        <asp:BoundField DataField="Fc_corta" HeaderText="Fecha Registro" />
                                        <asp:BoundField DataField="Abierto" HeaderText="Abierto" />
                                        <asp:BoundField DataField="Cerrado" HeaderText="Cerrado" />
                                        <asp:BoundField DataField="Escalado" HeaderText="Escalado" />
                                        <asp:BoundField DataField="Ilocalizable" HeaderText="Ilocalizable" />
                                        <asp:BoundField DataField="No Disponible" HeaderText="No Disponible" />
                                        <asp:BoundField DataField="Programado" HeaderText="Programado" />
                                        <asp:BoundField DataField="Rellamada" HeaderText="Rellamada" />
                                        <asp:BoundField DataField="Tol" HeaderText="Total" />
                                        <asp:BoundField DataField="Pend" HeaderText="Pendiaentes" />
                                        <asp:BoundField DataField="Por" HeaderText="Porcentaje" />
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
                        <tr  style="border:none">
                            <td>
                                <asp:GridView ID="dtgReporteso3" runat="server" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="false" ForeColor="#333333" GridLines="None" PageSize="900" style="font-size: x-small" Visible="False" Width="100%">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="fsap" HeaderText="Fecha Sap" />
                                        <asp:BoundField DataField="Fc_corta" HeaderText="Fecha Registro" />
                                        <asp:BoundField DataField="Abierto" HeaderText="Abierto" />
                                        <asp:BoundField DataField="Cerrado" HeaderText="Cerrado" />
                                        <asp:BoundField DataField="Escalado" HeaderText="Escalado" />
                                        <asp:BoundField DataField="Ilocalizable" HeaderText="Ilocalizable" />
                                        <asp:BoundField DataField="No Disponible" HeaderText="No Disponible" />
                                        <asp:BoundField DataField="Programado" HeaderText="Programado" />
                                        <asp:BoundField DataField="Seguimiento" HeaderText="Seguimiento" />
                                        <asp:BoundField DataField="Tol" HeaderText="Total" />
                                        <asp:BoundField DataField="Pend" HeaderText="Pendiaentes" />
                                        <asp:BoundField DataField="Por" HeaderText="Porcentaje" />
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
                        <tr style="border:none">
                            <td>
                                <asp:GridView ID="dtgReporteso4" runat="server" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="false" ForeColor="#333333" GridLines="None" PageSize="900" style="font-size: x-small" Visible="False" Width="100%">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="fsap" HeaderText="Fecha Sap" />
                                        <asp:BoundField DataField="Fc_corta" HeaderText="Fecha Registro" />
                                        <asp:BoundField DataField="Abierto" HeaderText="Abierto" />
                                        <asp:BoundField DataField="Cerrado" HeaderText="Cerrado" />
                                        <asp:BoundField DataField="Escalado" HeaderText="Escalado" />
                                        <asp:BoundField DataField="Gestionado" HeaderText="Gestionado" />
                                        <asp:BoundField DataField="Ilocalizable" HeaderText="Ilocalizable" />
                                        <asp:BoundField DataField="No Disponible" HeaderText="No Disponible" />
                                        <asp:BoundField DataField="Rellamada" HeaderText="Rellamada" />
                                        <asp:BoundField DataField="Tol" HeaderText="Total" />
                                        <asp:BoundField DataField="Pend" HeaderText="Pendiaentes" />
                                        <asp:BoundField DataField="Por" HeaderText="Porcentaje" />
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
                        <tr style="border:none">
                            <td>
                                <asp:GridView ID="dtgReporteso5" runat="server" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="false" ForeColor="#333333" GridLines="None" PageSize="900" style="font-size: x-small" Visible="False" Width="100%">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="fsap" HeaderText="Fecha Sap" />
                                        <asp:BoundField DataField="Fc_corta" HeaderText="Fecha Registro" />
                                        <asp:BoundField DataField="Abierto" HeaderText="Abierto" />
                                        <asp:BoundField DataField="Cerrado" HeaderText="Cerrado" />
                                        <asp:BoundField DataField="Escalado" HeaderText="Escalado" />
                                        <asp:BoundField DataField="Ilocalizable" HeaderText="Ilocalizable" />
                                        <asp:BoundField DataField="No Disponible" HeaderText="No Disponible" />
                                        <asp:BoundField DataField="Programado" HeaderText="Programado" />
                                        <asp:BoundField DataField="Rellamada" HeaderText="Rellamada" />
                                        <asp:BoundField DataField="Tol" HeaderText="Total" />
                                        <asp:BoundField DataField="Pend" HeaderText="Pendiaentes" />
                                        <asp:BoundField DataField="Por" HeaderText="Porcentaje" />
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
                        <tr style="border:none">
                            <td>
                                <asp:GridView ID="dtgReporteso6" runat="server" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="false" ForeColor="#333333" GridLines="None" PageSize="900" style="font-size: x-small" Visible="False" Width="100%">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="fsap" HeaderText="Fecha Sap" />
                                        <asp:BoundField DataField="Fc_corta" HeaderText="Fecha Registro" />
                                        <asp:BoundField DataField="Abierto" HeaderText="Abierto" />
                                        <asp:BoundField DataField="Cerrado" HeaderText="Cerrado" />
                                        <asp:BoundField DataField="Escalado" HeaderText="Escalado" />
                                        <asp:BoundField DataField="Gestionado" HeaderText="Gestionado" />
                                        <asp:BoundField DataField="Ilocalizable" HeaderText="Ilocalizable" />
                                        <asp:BoundField DataField="No Disponible" HeaderText="No Disponible" />
                                        <asp:BoundField DataField="Programado" HeaderText="Programado" />
                                        <asp:BoundField DataField="Tol" HeaderText="Total" />
                                        <asp:BoundField DataField="Pend" HeaderText="Pendiaentes" />
                                        <asp:BoundField DataField="Por" HeaderText="Porcentaje" />
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
                        <tr style="border:none">
                            <td>
                                <asp:GridView ID="dtgReporteso7" runat="server" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="false" ForeColor="#333333" GridLines="None" PageSize="900" style="font-size: x-small" Visible="False" Width="100%">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="fsap" HeaderText="Fecha Sap" />
                                        <asp:BoundField DataField="Fc_corta" HeaderText="Fecha Registro" />
                                        <asp:BoundField DataField="Abierto" HeaderText="Abierto" />
                                        <asp:BoundField DataField="Cerrado" HeaderText="Cerrado" />
                                        <asp:BoundField DataField="Escalado" HeaderText="Escalado" />
                                        <asp:BoundField DataField="Ilocalizable" HeaderText="Ilocalizable" />
                                        <asp:BoundField DataField="Rellamada" HeaderText="Rellamada" />
                                        <asp:BoundField DataField="Tol" HeaderText="Total" />
                                        <asp:BoundField DataField="Pend" HeaderText="Pendiaentes" />
                                        <asp:BoundField DataField="Por" HeaderText="Porcentaje" />
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
                        <tr style="border:none">
                            <td>
                                <asp:GridView ID="dtgReporteso8" runat="server" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="false" ForeColor="#333333" GridLines="None" PageSize="900" style="font-size: x-small" Visible="False" Width="100%">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="fsap" HeaderText="Fecha Sap" />
                                        <asp:BoundField DataField="Fc_corta" HeaderText="Fecha Registro" />
                                        <asp:BoundField DataField="Abierto" HeaderText="Abierto" />
                                        <asp:BoundField DataField="Cerrado" HeaderText="Cerrado" />
                                        <asp:BoundField DataField="Escalado" HeaderText="Escalado" />
                                        <asp:BoundField DataField="Ilocalizable" HeaderText="Ilocalizable" />
                                        <asp:BoundField DataField="Rellamada" HeaderText="Rellamada" />
                                        <asp:BoundField DataField="Tol" HeaderText="Total" />
                                        <asp:BoundField DataField="Pend" HeaderText="Pendiaentes" />
                                        <asp:BoundField DataField="Por" HeaderText="Porcentaje" />
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
                        <tr  style="border:none">
                            <td>
                                <asp:GridView ID="dtgReporteso9" runat="server" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="false" ForeColor="#333333" GridLines="None" PageSize="900" style="font-size: x-small" Visible="False" Width="100%">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="Bandeja" HeaderText="Bandeja" />
                                        <asp:BoundField DataField="f_sap" HeaderText="Fecha Sap" />
                                        <asp:BoundField DataField="fccorta" HeaderText="Fecha Registro" />
                                        <asp:BoundField DataField="Cerrado" HeaderText="Cerrado" />
                                        <asp:BoundField DataField="Escalado" HeaderText="Escalado" />
                                        <asp:BoundField DataField="Gestionado" HeaderText="Gestionado" />
                                        <asp:BoundField DataField="Ilocalizable" HeaderText="Ilocalizable" />
                                        <asp:BoundField DataField="No Disponible" HeaderText="No Disponible" />
                                        <asp:BoundField DataField="Rechazado" HeaderText="Rechazado" />
                                        <asp:BoundField DataField="Tol" HeaderText="Total" />
                                        <asp:BoundField DataField="Pend" HeaderText="Pendiaentes" />
                                        <asp:BoundField DataField="Por" HeaderText="Porcentaje" />
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
                        <tr  style="border:none">
                            <td>
                                <asp:GridView ID="dtgReporteso10" runat="server" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="false" ForeColor="#333333" GridLines="None" PageSize="900" style="font-size: x-small" Visible="False" Width="100%">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="fsap" HeaderText="Fecha Sap" />
                                        <asp:BoundField DataField="Fc_corta" HeaderText="Fecha Registro" />
                                        <asp:BoundField DataField="Abierto" HeaderText="Abierto" />
                                        <asp:BoundField DataField="Cerrado" HeaderText="Cerrado" />
                                        <asp:BoundField DataField="Escalado" HeaderText="Escalado" />
                                        <asp:BoundField DataField="Ilocalizable" HeaderText="Ilocalizable" />
                                        <asp:BoundField DataField="No Disponible" HeaderText="No Disponible" />
                                        <asp:BoundField DataField="Programado" HeaderText="Programado" />
                                        <asp:BoundField DataField="Seguimiento" HeaderText="Seguimiento" />
                                        <asp:BoundField DataField="Tol" HeaderText="Total" />
                                        <asp:BoundField DataField="Pend" HeaderText="Pendiaentes" />
                                        <asp:BoundField DataField="Por" HeaderText="Porcentaje" />
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
                    </table>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
     </table> 
    </form>
</body>
</html>