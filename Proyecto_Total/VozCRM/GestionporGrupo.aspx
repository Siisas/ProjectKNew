<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="GestionporGrupo.aspx.vb" Inherits="digitacion.GestionporGrupo" %>
<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="head1" runat="server">
<title>ERP Kamilion</title>

  <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <script type="text/jscript">
      $(function () {
          $("#txtFechaInicio").datepicker();
          $('#txtFechaInicio').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
  </script>
  <script type="text/jscript">
      $(function () {
          $("#txtFechasolucion").datepicker();
          $('#txtFechasolucion').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
  </script>
  <script type="text/jscript">
      $(function () {
          $("#TxtFechaConsulta1").datepicker2();
          $('#TxtFechaConsulta1').datepicker2('option', { dateFormat: 'hh/mm/ss' });
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
            height: 28px;
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
                        style="font-size: medium; font-style: italic">Gestion por Grupo - Supervisor</asp:Label>
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
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Grupo</td>
                            <td class="celdascons">
                            <asp:DropDownList ID="drlgrupo" runat="server">
                                <asp:ListItem>- Seleccionar -</asp:ListItem>
                                <asp:ListItem>Datos</asp:ListItem>
                                <asp:ListItem>Voz</asp:ListItem>
                                 </asp:DropDownList>     
                            </td>
                            <td class="textotittabla">
                                Fecha Inicial</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtfini" runat="server" Width="24%" placeholder="DD/MM/AAAA"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                    ControlToValidate="txtfini" ErrorMessage="La fecha no es válida" 
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                        <td class="textotittabla">
                                Informe</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlInforme" runat="server" AutoPostBack="true" >
                                <asp:ListItem>- Seleccionar -</asp:ListItem>
                                <asp:ListItem>Casos Gestionados</asp:ListItem>
                                <asp:ListItem>Casos Reincidentes</asp:ListItem>
                                <asp:ListItem>Casos 4G</asp:ListItem>
                                <asp:ListItem>Dato</asp:ListItem>
                                </asp:DropDownList>
                            </td>    
                            <td class="textotittabla">
                                Jornada</td>
                            <td class="celdascons">
                            <asp:DropDownList ID="drljornada" runat="server">
                                <asp:ListItem>- Seleccionar -</asp:ListItem>
                                <asp:ListItem>Mañana</asp:ListItem>
                                <asp:ListItem>Tarde</asp:ListItem>
                                 </asp:DropDownList>     
                            </td>
                       </tr>
                        <tr>
                            <td class="textotittabla">
                                Cola</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtcola" runat="server" Width="25%"></asp:TextBox>
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
                    valign="top" class="auto-style3">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnExportar" runat="server" Text="Exportar" Visible="False" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
         <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style3">
                    <table border="2" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="celdascons" colspan="2">
                                <center>
                                    Numero de registros:
                                    <asp:Label ID="lblcantidad" runat="server"></asp:Label>
                                </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4" colspan="2">
                                <center>
                                    CONSULTAS</center>
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" colspan="2">
                                <asp:GridView ID="dtgConsultages" runat="server" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="false" ForeColor="#333333" GridLines="None" PageSize="80" style="font-size: x-small" Width="100%">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                        <asp:BoundField DataField="registros" HeaderText="Registros" />
                                        <asp:BoundField DataField="llamadas" HeaderText="Llamadas Efectivas" />
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
                            <td class="celdascons" colspan="2">
                                <asp:GridView ID="dtgConsultages1" runat="server" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="false" ForeColor="#333333" GridLines="None" PageSize="9000" style="font-size: x-small" Width="100%" Visible="False">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                        <asp:BoundField DataField="registros" HeaderText="Registros" />
                                        <asp:BoundField DataField="llamadas" HeaderText="Llamadas Efectivas" />
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
                            <td class="celdascons" colspan="2">
                                <asp:GridView ID="dtgConsultages0" runat="server" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="false" ForeColor="#333333" GridLines="None" PageSize="80" style="font-size: x-small" Width="100%">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                       <asp:BoundField DataField="lista" HeaderText="Lista" />
                                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                        <asp:BoundField DataField="registros" HeaderText="Registros" />
                                        <asp:BoundField DataField="campana" HeaderText="Campaña" />
                                        <asp:BoundField DataField="cola" HeaderText="Cola" />
                                        <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                                        <asp:BoundField DataField="horario" HeaderText="Horario" />
                                        <asp:BoundField DataField="llamadas" HeaderText="Llamadas Efectivas" />
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
                            <td class="celdascons" colspan="2">
                                <asp:GridView ID="dtgConsultages2" runat="server" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="false" ForeColor="#333333" GridLines="None" PageSize="9000" style="font-size: x-small" Width="100%">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                       <asp:BoundField DataField="lista" HeaderText="Lista" />
                                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                        <asp:BoundField DataField="registros" HeaderText="Registros" />
                                        <asp:BoundField DataField="campana" HeaderText="Campaña" />
                                        <asp:BoundField DataField="cola" HeaderText="Cola" />
                                        <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                                        <asp:BoundField DataField="horario" HeaderText="Horario" />
                                        <asp:BoundField DataField="llamadas" HeaderText="Llamadas Efectivas" />
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
