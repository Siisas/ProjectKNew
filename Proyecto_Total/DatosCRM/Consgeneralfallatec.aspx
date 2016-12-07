
<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Consgeneralfallatec.aspx.vb" Inherits="digitacion.Consgeneralfallatec" %><%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>ERP Kamilion </title>
    <link rel="icon" href="favicon.ico" type="image/x-icon" />
     <link type="text/css" rel="stylesheet" href="../Css2/jquery-ui.css" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <script type="text/jscript">
        $(function () {
            $("#txtFechainicio").datepicker({ dateFormat: 'dd/mm/yy' }).val();
            $("#txtFechafin").datepicker({ dateFormat: 'dd/mm/yy' }).val();
           
        });
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
     
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 15%;
            height: 27px;
            background: #E2E8FA;
        }
        .auto-style2 {
            width: 35%;
            height: 27px;
        }
        .auto-style3 {
            width: 34%;
        }
        .auto-style4 {
            width: 34%;
            height: 27px;
        }
     
        .auto-style5 {
            width: 25%;
        }
        .auto-style6 {
            width: 40%;
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
                <table style="border-style: outset; border-width: 1px; width: 100%">
                    <tr>
                        <td align="center" class="titulo">
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
                        style="font-size: medium; font-style: italic">Consulta General Fallatec</asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <table style="width: 100%; height: 100%">
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lblusuario" runat="server" Font-Names="Times New Roman" ForeColor="Black"></asp:Label>
                        </td>
                        <td class="auto-style6">
                            <asp:Label ID="lblnombreusu" runat="server" Font-Names="Times New Roman" ForeColor="Black"></asp:Label>
                            &nbsp;<asp:Label ID="LblPerfil" runat="server" Font-Size="X-Large" ForeColor="#0000CC"
                                Font-Names="Times New Roman"></asp:Label>
                        </td>
                        <td style="width: 34%">
                            <asp:Label ID="LblSuperVisorTitulo" runat="server" Text="Supervisor: " Font-Names="Times New Roman"
                                ForeColor="Black"></asp:Label>
                            <asp:Label ID="LblSupervisor" runat="server" Font-Names="Times New Roman" ForeColor="Black"></asp:Label>
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
                    &nbsp;</td>
                <td style="width:15%" valign="top">
                    <table class="style2">
                        <tr>
                            <td style="width: 30%" rowspan="1">
                                            <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnxls" runat="server" Text="Exportar Excel" Width="98px" />
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
                                Cod&nbsp; Fallatec</td>
                            <td class="auto-style3">
                                <asp:TextBox ID="txtidfallatec" runat="server" MaxLength="10"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="regularexpression3" runat="server" ControlToValidate="txtidfallatec" Operator="DataTypeCheck" Type="Double" ValidationExpression="[0-9 ]*$" ErrorMessage="El Codigo debe ser  numerico">*</asp:RegularExpressionValidator>
                            </td>
                            <td class="textotittabla">
                                Min</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtmin" runat="server" MaxLength="12"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="regularexpression1" runat="server" ControlToValidate="txtmin" Operator="DataTypeCheck" Type="Double" ValidationExpression="[0-9 ]*$" ErrorMessage="El Min debe ser  numerico">*</asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Estado</td>
                            <td class="auto-style3">
                                    <asp:DropDownList ID="drlestadofallatec" runat="server" Height="22px" 
                                        Width="236px">
                                    </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Caso</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtcaso" runat="server" MaxLength="20"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="regularexpression2" runat="server" ControlToValidate="Txtcaso" Operator="DataTypeCheck" Type="Double" ValidationExpression="[0-9 ]*$" ErrorMessage="El caso debe ser numerico">*</asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                Tickler</td>
                            <td class="auto-style4">
                                <asp:TextBox ID="txttikler" runat="server" MaxLength="20"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="regularexpression4" runat="server" ControlToValidate="txttikler" Operator="DataTypeCheck" Type="Double" ValidationExpression="[0-9 ]*$" ErrorMessage="El tickler debe ser numerico">*</asp:RegularExpressionValidator>
                            </td>
                            <td class="auto-style1">
                                Rango de fecha</td>
                            <td class="auto-style2">
                                de<asp:TextBox ID="txtFechainicio" runat="server"  placeholder="DD/MM/YYYY" Width="90px" MaxLength="12"></asp:TextBox> a
                                <asp:TextBox ID="txtFechafin" runat="server"  placeholder="DD/MM/YYYY" Width="90px" MaxLength="12"></asp:TextBox>

                                 

                                    <asp:CompareValidator ID="CVFechaIni" runat="server"
                                        ControlToValidate="TxtFechaInicio" ErrorMessage="Revise hora"
                                        Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>

                                    <asp:CompareValidator ID="CVFechaIni0" runat="server"
                                        ControlToValidate="TxtFechafin" ErrorMessage="Revise hora"
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
                    &nbsp;<asp:LinkButton ID="LinkButton3" runat="server">Información General</asp:LinkButton>
                    &nbsp;&nbsp; <asp:Label ID="lblifogeneral" runat="server"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton2" runat="server" Visible="False">Seguimientos</asp:LinkButton>
&nbsp;<asp:Label ID="lblseguimientos" runat="server"></asp:Label>
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" Visible="False" />
                </td>
                <td class="celdascent">
    
                    <asp:GridView ID="dtgseguimiento" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small" EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="id_Ctrlfallatec" HeaderText="Cod Fallatec" />
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="min" HeaderText="Min" />
                            <asp:BoundField DataField="tickler" HeaderText="Tikler" />
                            <asp:BoundField DataField="fcsap" HeaderText="Fecha SAP" />
                            <asp:BoundField DataField="Fcasignacion" HeaderText="Fecha Asignacion" />
                            <asp:BoundField DataField="idusuarioasigna" HeaderText="Usu Asigna" />
                            <asp:BoundField DataField="idusuarioasignado" HeaderText="Usu asignado" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="tipo" HeaderText="Tipo" />
                            <asp:BoundField DataField="pertenece" HeaderText="Pertenece" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
    
                    <asp:GridView ID="dtgxls1" runat="server" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small" EnableModelValidation="True" EnableSortingAndPagingCallbacks="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="id_Ctrlfallatec" HeaderText="Cod Fallatec" />
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="min" HeaderText="Min" />
                            <asp:BoundField DataField="tickler" HeaderText="Tikler" />
                            <asp:BoundField DataField="fcsap" HeaderText="Fecha SAP" />
                            <asp:BoundField DataField="Fcasignacion" HeaderText="Fecha Asignacion" />
                            <asp:BoundField DataField="idusuarioasigna" HeaderText="Usu Asigna" />
                            <asp:BoundField DataField="idusuarioasignado" HeaderText="Usu asignado" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="tipo" HeaderText="Tipo" />
                            <asp:BoundField DataField="pertenece" HeaderText="Pertenece" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                    &nbsp; 
                    &nbsp;&nbsp;
                    &nbsp;&nbsp; 
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                    <asp:GridView ID="dtgseguimientos" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small" EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="min" HeaderText="Min" />
                            <asp:BoundField DataField="tickler" HeaderText="Tikler" />
                            <asp:BoundField DataField="fc_reg" HeaderText="Fecha registro" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="obs" HeaderText="Observacion" />
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
    
                    <asp:GridView ID="dtgxls2" runat="server" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small" EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="min" HeaderText="Min" />
                            <asp:BoundField DataField="tickler" HeaderText="Tikler" />
                            <asp:BoundField DataField="fc_reg" HeaderText="Fecha registro" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="obs" HeaderText="Observacion" />
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
    
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </table>
    
    </form>
</body>
</html>