<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConsultaInbound.aspx.vb" Inherits="digitacion.ConsultaInbound" %>

<%@ Register Src="../menu.ascx" TagName="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ERP - Kamilion</title>

<!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <script type="text/jscript">
      $(function () {
          $("#txtFechaInicio").datepicker();
          $('#txtFechaInicio').datepicker('option', { dateFormat: 'dd/mm/yy' });
          $("#txtFechaFin").datepicker();
          $('#txtFechaFin').datepicker('option', { dateFormat: 'dd/mm/yy' });
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
                        style="font-size: medium; font-style: italic">Consulta INBOUND</asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
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
                                            <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" style="height: 26px" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Btnxls" runat="server" Text="Exportar Excel" Width="99px" />
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
                </td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Estado Inbound</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlEstadoInboun" runat="server" Height="22px" 
                                    Width="322px">
                                    <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                    <asp:ListItem>SI</asp:ListItem>
                                    <asp:ListItem>NO</asp:ListItem>
                                    <asp:ListItem>NS/NR</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Tipo de Inbound</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtBandeja" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Desde</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtFechaInicio" runat="server" Width="24%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtFechaInicio" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                            </td>
                            <td class="textotittabla">
                                Hasta</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtFechaFin" runat="server" Width="24%" MaxLength="10" 
                                    placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator3" runat="server" 
                                    ControlToValidate="txtFechaFin" ErrorMessage="Revise hora" 
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
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
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    Consulta Inbound&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp; 
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
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="cas_id" HeaderText="IDCaso" />
                            <asp:BoundField DataField="Bandeja" HeaderText="Bandeja" />
                            <asp:BoundField DataField="cas_fecha_registro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="cas_observaciones" HeaderText="Observacion" />
                            <asp:BoundField DataField="min_ac" HeaderText="Min" />
                            <asp:BoundField DataField="telefono_contac" HeaderText="Tel Contacto" />
                            <asp:BoundField DataField="nom_cliente" HeaderText="Cliente" />
                            <asp:BoundField DataField="plan_acual_ac" HeaderText="Plan Actual" />
                            <asp:BoundField DataField="equipo_ac" HeaderText="Equipo" />
                            <asp:BoundField DataField="fcreg" HeaderText="Fecha Gestion" />
                            <asp:BoundField DataField="IdUsuario" HeaderText="Id Usuario" />
                            <asp:BoundField DataField="obs" HeaderText="Observacion Gestion" />
                            <asp:BoundField DataField="fcprogram" HeaderText="Fecha Programado" />
                            <asp:BoundField DataField="tipificacion" HeaderText="Tipificacion" />
                            <asp:BoundField DataField="estado" HeaderText="Estado Caso" />
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
    
                    <asp:GridView ID="dtgxls" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="1000" Width="100%" style="font-size: x-small" 
                        Visible="False">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="cas_id" HeaderText="IDCaso" />
                            <asp:BoundField DataField="Bandeja" HeaderText="Bandeja" />
                            <asp:BoundField DataField="cas_fecha_registro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="cas_observaciones" HeaderText="Observacion" />
                            <asp:BoundField DataField="min_ac" HeaderText="Min" />
                            <asp:BoundField DataField="telefono_contac" HeaderText="Tel Contacto" />
                            <asp:BoundField DataField="nom_cliente" HeaderText="Cliente" />
                            <asp:BoundField DataField="plan_acual_ac" HeaderText="Plan Actual" />
                            <asp:BoundField DataField="equipo_ac" HeaderText="Equipo" />
                            <asp:BoundField DataField="fcreg" HeaderText="Fecha Gestion" />
                            <asp:BoundField DataField="IdUsuario" HeaderText="Id Usuario" />
                            <asp:BoundField DataField="obs" HeaderText="Observacion Gestion" />
                            <asp:BoundField DataField="fcprogram" HeaderText="Fecha Programado" />
                            <asp:BoundField DataField="tipificacion" HeaderText="Tipificacion" />
                            <asp:BoundField DataField="estado" HeaderText="Estado Caso" />
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
