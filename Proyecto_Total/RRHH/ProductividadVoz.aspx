<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ProductividadVoz.aspx.vb" Inherits="digitacion.ProductividadVoz" %>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página sin título</title>

   <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>  
  <script type="text/jscript">
      $(function () {
          $("#TxtFechaConsulta1").datepicker();
          $('#TxtFechaConsulta1').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
  </script>
  <script type="text/jscript">
      $(function () {
          $("#TxtFechaConsulta2").datepicker();
          $('#TxtFechaConsulta2').datepicker('option', { dateFormat: 'dd/mm/yy' });
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
                    <asp:Panel ID="Panel1" runat="server" Visible="False">
                    <asp:Label ID="LblRechazado" runat="server" Text="R:"></asp:Label>
                    <asp:Label ID="LblRechazadoCantidad" runat="server" Text="0"></asp:Label>&nbsp;
                    <asp:Label ID="LblCerrado" runat="server" Text="C:"></asp:Label>
                    <asp:Label ID="LblCerradoCantidad" runat="server" Text="0"></asp:Label>&nbsp;
                    <asp:Label ID="LblEscalado" runat="server" Text="E:"></asp:Label>
                    <asp:Label ID="LblEscaladoCantidad" runat="server" Text="0"></asp:Label>&nbsp;
                    <asp:Label ID="LblAsignado" runat="server" Text="A:"></asp:Label>
                    <asp:Label ID="LblAsignadoCantidad" runat="server" Text="0"></asp:Label>&nbsp;
                    <asp:Label ID="LblTotal" runat="server" Text="Total:"></asp:Label>
                    <asp:Label ID="LblTotalDia" runat="server" Text="0"></asp:Label>&nbsp;
                    <asp:Label ID="LblPorcentaje" runat="server" Text="Porcentaje:"></asp:Label>
                    <asp:Label ID="LblPorcentajeDia" runat="server" Text="0"></asp:Label>
                    <asp:Label ID="LblSimbolo" runat="server" Text="%"></asp:Label>&nbsp;
                    <asp:Button ID="BtnCalcularProductividad" runat="server" Text="Calcular" style="height: 26px; width: 69px;" />
                    <asp:Label ID="LblCargo" runat="server" Visible="False"></asp:Label>
                    </asp:Panel>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="lblmsg0" runat="server" 
                        style="font-size: medium; font-style: italic">Consulta Productividad</asp:Label>
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
                <td class="style4">
                    <asp:Label ID="Label1" runat="server" 
                        style="font-size: medium; font-style: italic">Productividad VOZ</asp:Label>
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
                            <td class="textotittabla" colspan="2"><center style="font-size: x-large">
                                PRODUCTIVIDAD</center></td>
                        </tr>
                        <tr>
                            <td class="style9">
                        <asp:RadioButton ID="RdbtnOnline" GroupName="Seleccion" runat="server" Text="Online" ForeColor="Black"/>
                            </td>
                            <td class="celdascons">
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                        <asp:RadioButton ID="RdbtnFechas" GroupName="Seleccion" runat="server" Text="Fechas" ForeColor="Black" /><br />
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Jornada
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtFechaConsulta1" runat="server" Width="10%" MaxLength="10" 
                                    placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator8" runat="server" ControlToValidate="TxtFechaConsulta1" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                <asp:TextBox ID="TxtFechaConsulta2" runat="server" Width="10%" MaxLength="10" 
                                    placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator10" runat="server" ControlToValidate="TxtFechaConsulta2" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator><br />
                                <asp:RadioButton ID="RdbtnMañana" GroupName="Turno" runat="server" Text="Mañana" ForeColor="Black" /><asp:RadioButton ID="RdbtnTarde" GroupName="Turno" runat="server" Text="Tarde" ForeColor="Black" />
                                <asp:RadioButton ID="RdbtnCompleta" GroupName="Turno" runat="server" Text="Completa" ForeColor="Black" />
                                </td>
                        </tr>
                        <tr>
                            <td class="style9">
                                <asp:RadioButton ID="RdbtnTodos" GroupName="Grupo" runat="server" Text="Todos" />
                                <br />
                                <asp:RadioButton ID="RdbtnGrupo" GroupName="Grupo" runat="server" Text="Grupo" />
                            </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlGrupo" runat="server" AutoPostBack="True">
                                </asp:DropDownList>
                                </td>
                        </tr>                        
                        <tr>
                            <td class="style9">
                                Agentes</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlAgentes" runat="server" Height="26px" Width="333px">
                                </asp:DropDownList>
                                </td>
                        </tr>
                        <tr>                            
                            <td class="celdascons" colspan="2">
                                <asp:Button ID="BtnTodos" runat="server" Text="Actualizar" 
                                    style="height: 26px" />
                            &nbsp;&nbsp;&nbsp;<asp:Button ID="btnxls" runat="server" Text="Exportar Excel" 
                            Width="102px" />
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
                    <table border="0">
                    <tr>
                    <td class="style8">
                     Numero de agentes: 
                        <asp:Label ID="lblcantgral" runat="server"></asp:Label>
                        <asp:Label ID="lblcantgralN2" runat="server"></asp:Label>
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
                                <asp:GridView ID="dtgConsultasN1" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                                    EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Idusu" HeaderText="ID Usuario" />
                            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="cargou" HeaderText="cargo" />
                            <asp:BoundField DataField="Cerrado" HeaderText="Cerrados" />
                            <asp:BoundField DataField="Rechazado" HeaderText="Rechazados" />
                            <asp:BoundField DataField="Escalado" HeaderText="Escalados" />
                            <asp:BoundField DataField="Total" HeaderText="Total" />
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
                <td class="style4">
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                <asp:GridView ID="dtgConsultasN2" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                                    EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Idusu" HeaderText="ID Usuario" />
                            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="cargou" HeaderText="cargo" />
                            <asp:BoundField DataField="Cerrado" HeaderText="Cerrados" />
                            <asp:BoundField DataField="Reportado" HeaderText="Reportados" />
                            <asp:BoundField DataField="Asignado" HeaderText="Asignados" />
                            <asp:BoundField DataField="Total" HeaderText="Total" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>

                                <asp:GridView ID="dtgConsultas" runat="server" AllowPaging="True" 
                                    CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small" 
                                    EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
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
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" />
    </form>
</body>
</html>