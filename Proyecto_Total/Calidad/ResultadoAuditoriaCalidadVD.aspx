<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ResultadoAuditoriaCalidadVD.aspx.vb" Inherits="digitacion.ResultadoAuditotiaCalidadVD" %>

<%@ Register Src="../menu.ascx" TagName="menu" tagprefix="uc1"%>

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
          $("#TxtFechaInicio").datepicker();
          $('#TxtFechaInicio').datepicker('option', { dateFormat: 'dd/mm/yy' });
          $("#TxtFechaFin").datepicker();
          $('#TxtFechaFin').datepicker('option', { dateFormat: 'dd/mm/yy' });
          $("#TxtFechaInicioLlamada").datepicker();
          $('#TxtFechaInicioLlamada').datepicker('option', { dateFormat: 'dd/mm/yy' });
          $("#TxtFechaFinLlamada").datepicker();
          $('#TxtFechaFinLlamada').datepicker('option', { dateFormat: 'dd/mm/yy' });
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
                        style="font-size: medium; font-style: italic">Resultados Auditorias Calidad Voz y Datos</asp:Label>
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
                    </table>
                </td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%" valign="top">
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
               <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                <asp:Panel ID="Panel1" runat="server">
                                    <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                                        <tr>
                                            <td class="textotittabla" colspan="4">
                                                <center>Consultas</center></td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Fecha Auditoria Inicio</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtFechaInicio" runat="server" MaxLength="10" 
                                                    placeholder="DD/MM/YYYY" Width="24%"></asp:TextBox>
                                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                    ControlToValidate="TxtFechaInicio" ErrorMessage="Revise hora" 
                                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                            </td>
                                            <td class="textotittabla">
                                                Fecha Auditoria Fin</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtFechaFin" runat="server" MaxLength="10" 
                                                    placeholder="DD/MM/YYYY" Width="24%"></asp:TextBox>
                                                <asp:CompareValidator ID="CompareValidator3" runat="server" 
                                                    ControlToValidate="TxtFechaFin" ErrorMessage="Revise hora" 
                                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Fecha Llamada Inicio</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtFechaInicioLlamada" runat="server" MaxLength="10" 
                                                    placeholder="DD/MM/YYYY" Width="24%"></asp:TextBox>
                                                <asp:CompareValidator ID="CompareValidator4" runat="server" 
                                                    ControlToValidate="TxtFechaInicioLlamada" ErrorMessage="Revise hora" 
                                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                            </td>
                                            <td class="textotittabla">
                                                Fecha Llamada Fin</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtFechaFinLlamada" runat="server" MaxLength="10" 
                                                    placeholder="DD/MM/YYYY" Width="24%"></asp:TextBox>
                                                <asp:CompareValidator ID="CompareValidator5" runat="server" 
                                                    ControlToValidate="TxtFechaFinLlamada" ErrorMessage="Revise hora" 
                                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Operacion</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlOperacion" runat="server">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    <asp:ListItem Value="N">Datos</asp:ListItem>
                                                    <asp:ListItem>Voz</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td class="textotittabla">
                                                Supervisor</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlSupervisor" runat="server">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="textotittabla">
                                                Grupo</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlGrupoConsulta" runat="server">
                                                </asp:DropDownList>
                                            </td>
                                            <td class="textotittabla">
                                                Codigo</td>
                                            <td class="celdascons">
                                                <asp:TextBox ID="TxtCodigo" runat="server"></asp:TextBox>
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
                                <asp:Button ID="BtnConsulta" runat="server" Text="Consulta" />
                                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    Cantidad de Registros:&nbsp; 
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
                            <asp:BoundField DataField="cargo" HeaderText="Grupo" />
                            <asp:BoundField DataField="codnom" HeaderText="Codigo" />
                            <asp:BoundField DataField="Nombreu" HeaderText="Nombres y Apellidos" />
                            <asp:BoundField DataField="Total" HeaderText="Promedio" />
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
