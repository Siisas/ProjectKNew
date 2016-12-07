<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FallaMasivaConsulta.aspx.vb" Inherits="digitacion.FallaMasivaConsulta" %>

<%@ Register Src="../menu.ascx" tagprefix="uc1" tagname="menu" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>Kamilion - ERP</title> <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <script type="text/jscript">
      $(function () {
          $("#TxtFecha_Inicio").datepicker();
          $('#TxtFecha_Inicio').datepicker('option', { dateFormat: 'dd/mm/yy' })
          $("#TxtFechaFin").datepicker();
          $('#TxtFechaFin').datepicker('option', { dateFormat: 'dd/mm/yy' });
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
        .style6
        {
            width: 624px;
        }
        .style7
        {
            width: 411px;
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
        .auto-style9 {
            width: 20%;
        }
        .auto-style17 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 33px;
        }
        .auto-style20 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 21px;
        }
        .auto-style23 {
            color: #000099;
            width: 80%;
            height: 21px;
        }
        .auto-style26 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 26px;
        }
        .auto-style27 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 26px;
        }
        .auto-style30 {
            height: 28px;
            width: 257px;
        }
        .auto-style31 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 63px;
        }
        .auto-style32 {
            color: #000099;
            width: 80%;
            height: 63px;
        }
        .auto-style36 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 33px;
        }
        .auto-style38 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 25%;
            background: #E2E8FA;
            height: 28px;
        }
        .auto-style39 {
            color: #000099;
            width: 43%;
        }
        .auto-style40 {
            height: 28px;
        }
        .auto-style41 {
            width: 624px;
            height: 30px;
        }
        .auto-style42 {
            width: 411px;
            height: 30px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <table style="width:100%; height: 100%">
            <tr>
                <td class="celdasder">
                </td>
                <td class="celdascent">
                    <table style="border-style: outset; border-width: 1px; width:100%">
                        <tr>
                            <td class="auto-style9">
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
                <td class="auto-style26">
                    </td>                    
                <td class="auto-style27">
                    <uc1:menu ID="menu1" runat="server" />
                </td>
                
                <td class="auto-style26">
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
                <td class="auto-style20">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style23">
                    Falla Masiva</td>
                <td class="auto-style20">
                    </td>
            </tr>            
            <tr>
                <td class="auto-style36">
                </td>
                <td class="auto-style17">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>                            
                            <td class="auto-style38">
                                Fecha inicio</td>
                            <td class="auto-style30">                                
                                
                                <asp:TextBox ID="TxtFecha_Inicio" runat="server" Width="50%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                            </td>
                            <td class="auto-style38">Fecha fin</td>
                            <td class="auto-style40">
                                <asp:TextBox ID="TxtFechaFin" runat="server" Width="38%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>                            
                            <td class="auto-style38">
                                Municipio</td>
                            <td class="auto-style30">                                
                                
                                <asp:TextBox ID="TxtOtro" runat="server"></asp:TextBox>
                            </td>
                            <td class="auto-style38">
                                Departamento</td>
                            <td class="auto-style40">
                                <asp:TextBox ID="TxtDepar" runat="server" Width="130px"></asp:TextBox>
                            </td>
                        </tr>
                        </table>
                </td>
                <td class="auto-style36">
                </td>
            </tr>
            <tr>
                <td class="auto-style31">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style32">
                    <table border="0">
                    <tr>
                    <td class="auto-style41">
                        <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" />
                        </td>
                    <td class="auto-style42">                               
                            &nbsp;&nbsp;
                                &nbsp;&nbsp;
                                &nbsp;&nbsp;
                                </td>
                    </tr>
                    <tr>
                    <td class="style6">
                        Numero de registros: <asp:Label ID="LblCantidad" runat="server"></asp:Label>
                            <br />
                        <asp:Label ID="lblOtro" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="lbldep" runat="server"></asp:Label>
                            </td>
                    <td class="style7" ALIGN=right>                               
                            <asp:Button ID="BtnExportar" runat="server" Text="Exportar" Visible="False" />
                        </td>
                    </tr>
                    </table>
                                
                                
                            </td>
                <td class="auto-style31">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <center>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style39">
                    <center>
                                <br />
                    <asp:GridView ID="DtgFalla" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True" AutoGenerateColumns="False">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                         <Columns>
                                        <asp:BoundField DataField="cas_id" HeaderText="Caso"  HtmlEncode=false />
                                        <asp:BoundField DataField="cas_fecha_registro" HeaderText="Fecha Registro"  DataFormatString="{0:d}" HtmlEncode=false />
                                        <asp:BoundField DataField="cas_observaciones" HeaderText="Observacion"   HtmlEncode=false />
                                        <asp:BoundField DataField="min_ac" HeaderText="Min"   HtmlEncode=false />
                                        <asp:BoundField DataField="nom_cliente" HeaderText="Nombre Cliente"   HtmlEncode=false />
                                        <asp:BoundField DataField="no_documento" HeaderText="Documento"  HtmlEncode=false />
                                        <asp:BoundField DataField="equipo_ac" HeaderText="Equipo_ac"   HtmlEncode=false />
                                        <asp:BoundField DataField="otro_cual" HeaderText="Otro"   HtmlEncode=false />
                                        <asp:BoundField DataField="departamento_falla" HeaderText="Departamento"  HtmlEncode=false />
                                        <asp:BoundField DataField="ciudad" HeaderText="Ciudad"  HtmlEncode=false />
                                        <asp:BoundField DataField="estado" HeaderText="Estado"   HtmlEncode=false />
                                        <asp:BoundField DataField="falla_desde_cuando" HeaderText="Falla desde"   HtmlEncode=false />
                                        <asp:BoundField DataField="CPD" HeaderText="CPD"  HtmlEncode=false />
                                        <asp:BoundField DataField="estadocpd" HeaderText="Estado CPD"   HtmlEncode=false />
                                        <asp:BoundField DataField="obscpd" HeaderText="Observacion CPD"  HtmlEncode=false />
                                                                          </Columns>
                    </asp:GridView>                    
                        </center>
                </td>
                    </center>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
        </table>
    
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" />
    </form>
</body>
</html>